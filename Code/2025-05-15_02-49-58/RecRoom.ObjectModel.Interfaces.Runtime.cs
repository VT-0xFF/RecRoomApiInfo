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
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_Interfaces_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DE75E0", Offset = "0x7DE5BE0", VA = "0x187DE75E0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NAEHJCHIFDP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8E80", Offset = "0x7DE7480", VA = "0x187DE8E80")]
	public static void AODACIHCPJE(this Rigidbody MHLPIBDABBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8D50", Offset = "0x7DE7350", VA = "0x187DE8D50")]
	public static void AODACIHCPJE(this Rigidbody MHLPIBDABBK, Vector3 AFFBIOACIEI, Quaternion CNGGDPNDMNH, Vector3 NPEDAJFDEKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct EPFJFEANHAG : IReadOnlyList<PKENAFNLEAO>, IEnumerable<PKENAFNLEAO>, IEnumerable, IReadOnlyCollection<PKENAFNLEAO>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct MJEICEPECDM : IEnumerator<PKENAFNLEAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly JFDGJOPOGFB GGBPNJIDLBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator FMKNFJBKBAJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PKENAFNLEAO FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7DE8B10", Offset = "0x7DE7110", VA = "0x187DE8B10", Slot = "4")]
			get
			{
				return default(PKENAFNLEAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7DE8AC0", Offset = "0x7DE70C0", VA = "0x187DE8AC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x50CA230", Offset = "0x50C8830", VA = "0x1850CA230")]
		public MJEICEPECDM(JFDGJOPOGFB GGBPNJIDLBN, NativeArray<LocalId>.Enumerator FMKNFJBKBAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8A00", Offset = "0x7DE7000", VA = "0x187DE8A00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8A40", Offset = "0x7DE7040", VA = "0x187DE8A40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8A80", Offset = "0x7DE7080", VA = "0x187DE8A80", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly MCIKHPLGCGG BOJCEMEJOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> OMFFBFINKMM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public PKENAFNLEAO OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE920", Offset = "0x7DDCF20", VA = "0x187DDE920", Slot = "4")]
		get
		{
			return default(PKENAFNLEAO);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7DDDE30", Offset = "0x7DDC430", VA = "0x187DDDE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int JEHPDOFOLPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JFDGJOPOGFB PIJODJEEGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7DDDDE0", Offset = "0x7DDC3E0", VA = "0x187DDDDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool AHPBLIDLKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7DDDDA0", Offset = "0x7DDC3A0", VA = "0x187DDDDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> BMDBNANJBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0300", Offset = "0x2DEE900", VA = "0x182DF0300")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> CPINBOKPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE140", Offset = "0x7DDC740", VA = "0x187DDE140")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE870", Offset = "0x7DDCE70", VA = "0x187DDE870")]
	public EPFJFEANHAG(int GDBMBEIFFOO, JFDGJOPOGFB GGBPNJIDLBN, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE6D0", Offset = "0x7DDCCD0", VA = "0x187DDE6D0")]
	public EPFJFEANHAG(MCIKHPLGCGG BOJCEMEJOMP, NativeArray<LocalId> OMFFBFINKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE800", Offset = "0x7DDCE00", VA = "0x187DDE800")]
	public EPFJFEANHAG(MCIKHPLGCGG BOJCEMEJOMP, NativeArray<Entity> OMFFBFINKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE590", Offset = "0x7DDCB90", VA = "0x187DDE590")]
	internal EPFJFEANHAG(JFDGJOPOGFB GGBPNJIDLBN, NativeArray<Entity> ANKLKPHHPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE790", Offset = "0x7DDCD90", VA = "0x187DDE790")]
	internal EPFJFEANHAG(JFDGJOPOGFB GGBPNJIDLBN, NativeArray<LocalId> OMFFBFINKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE620", Offset = "0x7DDCC20", VA = "0x187DDE620")]
	public EPFJFEANHAG(JFDGJOPOGFB GGBPNJIDLBN, int DDGBDMFPMAI, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE6E0", Offset = "0x7DDCCE0", VA = "0x187DDE6E0")]
	public EPFJFEANHAG(EPFJFEANHAG LGNNGLLKIKE, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE240", Offset = "0x7DDC840", VA = "0x187DDE240")]
	public void PNJIDJCBNNF(List<PKENAFNLEAO> OLEDHEBBJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDD10", Offset = "0x7DDC310", VA = "0x187DDDD10")]
	public void AAHELIFIAAL(int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDE90", Offset = "0x7DDC490", VA = "0x187DDDE90")]
	public EPFJFEANHAG OKKBPPIELHH(Allocator NDFENJBGNOB)
	{
		return default(EPFJFEANHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDFF0", Offset = "0x7DDC5F0", VA = "0x187DDDFF0")]
	public Span<PKENAFNLEAO> OOGBNKDJAHM()
	{
		return default(Span<PKENAFNLEAO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE1A0", Offset = "0x7DDC7A0", VA = "0x187DDE1A0")]
	public EPFJFEANHAG PEBMDKLANEN(int IPAELMFFKOA, int DDGBDMFPMAI)
	{
		return default(EPFJFEANHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDD60", Offset = "0x7DDC360", VA = "0x187DDDD60", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDF30", Offset = "0x7DDC530", VA = "0x187DDDF30")]
	public MJEICEPECDM OMLAPONJPHN()
	{
		return default(MJEICEPECDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE4B0", Offset = "0x7DDCAB0", VA = "0x187DDE4B0", Slot = "6")]
	private IEnumerator<PKENAFNLEAO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE520", Offset = "0x7DDCB20", VA = "0x187DDE520", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NEFMNEBKBBH
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x39A9740", Offset = "0x39A7D40", VA = "0x1839A9740")]
	public static KOGLLFEDMCC<T> KMMGNKNMKMG<T>(this EPFJFEANHAG KIDPOMGFMKB) where T : Component
	{
		return default(KOGLLFEDMCC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct CKOFFFONKMO : IList<PKENAFNLEAO>, ICollection<PKENAFNLEAO>, IEnumerable<PKENAFNLEAO>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct NDDIFLICJDI : IEnumerator<PKENAFNLEAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly JFDGJOPOGFB GGBPNJIDLBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator FMKNFJBKBAJ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public PKENAFNLEAO FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7DE9FE0", Offset = "0x7DE85E0", VA = "0x187DE9FE0", Slot = "4")]
			get
			{
				return default(PKENAFNLEAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7DE9F90", Offset = "0x7DE8590", VA = "0x187DE9F90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x50CA230", Offset = "0x50C8830", VA = "0x1850CA230")]
		public NDDIFLICJDI(JFDGJOPOGFB GGBPNJIDLBN, NativeArray<LocalId>.Enumerator FMKNFJBKBAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7DE9ED0", Offset = "0x7DE84D0", VA = "0x187DE9ED0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7DE9F10", Offset = "0x7DE8510", VA = "0x187DE9F10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7DE9F50", Offset = "0x7DE8550", VA = "0x187DE9F50", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly JFDGJOPOGFB GGBPNJIDLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> OMFFBFINKMM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PKENAFNLEAO OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7DDA2C0", Offset = "0x7DD88C0", VA = "0x187DDA2C0", Slot = "4")]
		get
		{
			return default(PKENAFNLEAO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7DDA3B0", Offset = "0x7DD89B0", VA = "0x187DDA3B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9E00", Offset = "0x7DD8400", VA = "0x187DD9E00", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9E00", Offset = "0x7DD8400", VA = "0x187DD9E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> BMDBNANJBPG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0300", Offset = "0x2DEE900", VA = "0x182DF0300")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool DJCGEFIJFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA1B0", Offset = "0x7DD87B0", VA = "0x187DDA1B0")]
	public CKOFFFONKMO(JFDGJOPOGFB GGBPNJIDLBN, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA230", Offset = "0x7DD8830", VA = "0x187DDA230")]
	public CKOFFFONKMO(JFDGJOPOGFB GGBPNJIDLBN, int DDGBDMFPMAI, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9B70", Offset = "0x7DD8170", VA = "0x187DD9B70")]
	public EPFJFEANHAG DHMFHDDCNJK()
	{
		return default(EPFJFEANHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD98D0", Offset = "0x7DD7ED0", VA = "0x187DD98D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9910", Offset = "0x7DD7F10", VA = "0x187DD9910", Slot = "13")]
	public bool Contains(PKENAFNLEAO HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD99A0", Offset = "0x7DD7FA0", VA = "0x187DD99A0", Slot = "14")]
	public void CopyTo(PKENAFNLEAO[] NBBLCIBNPBK, int DDFLLHIGBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9850", Offset = "0x7DD7E50", VA = "0x187DD9850", Slot = "11")]
	public void Add(PKENAFNLEAO HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9D50", Offset = "0x7DD8350", VA = "0x187DD9D50", Slot = "7")]
	public void Insert(int OHHMJGCBCKD, PKENAFNLEAO HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9F20", Offset = "0x7DD8520", VA = "0x187DD9F20", Slot = "15")]
	public bool Remove(PKENAFNLEAO HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9CC0", Offset = "0x7DD82C0", VA = "0x187DD9CC0", Slot = "6")]
	public int IndexOf(PKENAFNLEAO HOJKNIMMINF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9ED0", Offset = "0x7DD84D0", VA = "0x187DD9ED0", Slot = "8")]
	public void RemoveAt(int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9C80", Offset = "0x7DD8280", VA = "0x187DD9C80", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9E40", Offset = "0x7DD8440", VA = "0x187DD9E40")]
	public NDDIFLICJDI OMLAPONJPHN()
	{
		return default(NDDIFLICJDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9FF0", Offset = "0x7DD85F0", VA = "0x187DD9FF0", Slot = "16")]
	private IEnumerator<PKENAFNLEAO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA0D0", Offset = "0x7DD86D0", VA = "0x187DDA0D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FFHNDOJIMFO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PKENAFNLEAO GHNOODGANAA(PKENAFNLEAO OMFFBFINKMM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MBPIDFACANH : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface PFIKMKHDNCH : GLPKDACECEH, IEMPDOBFCIM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	ALAAAJBIMIM PLNJCPEJNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MCIKHPLGCGG AINIPMHHIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface IEMPDOBFCIM
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool KMGCMFNJFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface KNEHMBDDKIF
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBEMMBAOEOC(bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INBDHNEFJBE();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface LCNNNBGPKHN
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool IECDEPKNLOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool MOIFPOAHOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool CAGFFACEPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool EJINKNCGMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IKADPFOBFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AHFMHDDHHEN(bool BFEIIPBAHBE);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JKKBCHDOMDE(ByteString MIBOELPFKBE);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DDGEAFABPCA();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EAOGNGGGLAD();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BHNGKIAAHOI();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface KJLADPJFBIO
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	APJCDBKKFBB PLNJCPEJNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	AGIEMMJDJAD GLHNOPBCEOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	BIKLLMMLFGM DEOHEGAAGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	PFIKMKHDNCH CLBMDBENHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	KDLBBIAEJNJ AKAHANDDLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	LCNNNBGPKHN OFKCBLKLCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	OIAIGLOONMN CCLMFNNFKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	PDGCBJKMJFK CEFKEGEJHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	KLJACPCBIBJ CGMCDMEHMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MIJCBDFLLCM OFIGOOBGDCB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	KDOJOMBFCFA NLFNLADEAGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	IPEFIGEONOD AJMIFJPNKHH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	JFDGJOPOGFB PIJODJEEGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	PHKFLJLJBDP EMKCPEDCHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	BKLGCLGIMOD IJLGNAMOBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	DMHMIPOBNHA OJMKBAKEOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	CPMCMNDHPDL AJLPDIKMENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	LKFCPOJLLGG PDFKONLEFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	AOCGLAEEKHI LBBCGLDFBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	PBMPONFKFKP MKCLPAMNEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	KKFMEKIBEHB EFBMPEKPPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	FIBHLFPAKOC EMAEMDKMDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	FMMMFNOHJJM FEICAMGDMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	NLBMBIBOAOO HMKELMLPOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	MJHMJMMJCJL DJGALKENBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	BIJELNGKGKC KDEGGKGBMAH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	BGCCOPGGOCK LKBJLHGLADO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	JHOFBNJCHGN JAGKPLKJHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	EEJGJECIGEM BNKAAPPJNDH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	MOMONMFDFEH EHOCENAJCEI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	BNOONHHEGEJ GLCBCECBDJF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	DIDIFHNCLFN PPJOFODMHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IDDFCADBHKL PNHMNBBECMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	ACFBKCGGNLM ALDKCMKOLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	PLCKOGMOKKF IBKJIKBJGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerTypeProxy(typeof(CGJIKGMPKNN))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct PKENAFNLEAO : IComparable<PKENAFNLEAO>, IEquatable<PKENAFNLEAO>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly PKENAFNLEAO CABIBLEKJPN;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int LDKCPCNINFG = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int KBMOPGGBMMD = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int DKAFGOKHHED = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int CEHJPKABJPG = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId GOGGPBKDKBC;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public JFDGJOPOGFB PIJODJEEGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB510", Offset = "0x7DD9B10", VA = "0x187DDB510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public PFIKMKHDNCH CLBMDBENHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7DED990", Offset = "0x7DEBF90", VA = "0x187DED990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public LocalId AFDJOEOIOAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7DED400", Offset = "0x7DEBA00", VA = "0x187DED400")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	internal MCIKHPLGCGG AINIPMHHIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7DED7E0", Offset = "0x7DEBDE0", VA = "0x187DED7E0")]
		get
		{
			return default(MCIKHPLGCGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool NOMOJCGANNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7DED530", Offset = "0x7DEBB30", VA = "0x187DED530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private bool LGPFIJOLBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7DED3B0", Offset = "0x7DEB9B0", VA = "0x187DED3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7DEDBB0", Offset = "0x7DEC1B0", VA = "0x187DEDBB0")]
	public PKENAFNLEAO(JFDGJOPOGFB HMEANHHOLMN, LocalId GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7DEDB20", Offset = "0x7DEC120", VA = "0x187DEDB20")]
	public PKENAFNLEAO(MCIKHPLGCGG BOJCEMEJOMP, LocalId GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
	public FHMOHIBLLDK AFDJJEADFEL()
	{
		return default(FHMOHIBLLDK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7DED950", Offset = "0x7DEBF50", VA = "0x187DED950")]
	public static LocalId OIFHDJNIHDL(PKENAFNLEAO DKBBAMEMKLO)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7DED910", Offset = "0x7DEBF10", VA = "0x187DED910")]
	public static Entity OIFHDJNIHDL(PKENAFNLEAO DKBBAMEMKLO)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7DED7F0", Offset = "0x7DEBDF0", VA = "0x187DED7F0")]
	public static bool MMJMCICIDNJ(PKENAFNLEAO FDJHCIBLFFB, PKENAFNLEAO CNIMJCCKEDM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0FE0", Offset = "0x7DDF5E0", VA = "0x187DE0FE0")]
	public static bool DIKHMNDIIDO(PKENAFNLEAO FDJHCIBLFFB, PKENAFNLEAO CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7DED9F0", Offset = "0x7DEBFF0", VA = "0x187DED9F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7DED650", Offset = "0x7DEBC50", VA = "0x187DED650", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7DED440", Offset = "0x7DEBA40", VA = "0x187DED440", Slot = "4")]
	public int CompareTo(PKENAFNLEAO MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "5")]
	public bool Equals(PKENAFNLEAO MIJLJBIHDMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EFGGEGNGFLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDA90", Offset = "0x7DDC090", VA = "0x187DDDA90")]
	public static JOKHKLAANOK MFBOGNHADKK(this PKENAFNLEAO BOMDCGFKGKF)
	{
		return default(JOKHKLAANOK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class CGJIKGMPKNN
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct MCIKHPLGCGG : IEquatable<MCIKHPLGCGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte BOJCEMEJOMP;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] LPJEPOMELAF;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static JFDGJOPOGFB PNFLGDNPCAN;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static PFIKMKHDNCH GLAPPNAJFJI;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static JFDGJOPOGFB[] HDAMGCBJEJD;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static PFIKMKHDNCH[] ICIPMDICAAF;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> IBAJIMKLAFG;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public PFIKMKHDNCH CLBMDBENHBE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7DE83D0", Offset = "0x7DE69D0", VA = "0x187DE83D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public JFDGJOPOGFB GJEHCPMCLIN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8030", Offset = "0x7DE6630", VA = "0x187DE8030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8610", Offset = "0x7DE6C10", VA = "0x187DE8610")]
	static MCIKHPLGCGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x29A9300", Offset = "0x29A7900", VA = "0x1829A9300")]
	internal MCIKHPLGCGG(byte OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6CDD2D0", Offset = "0x6CDB8D0", VA = "0x186CDD2D0", Slot = "4")]
	public bool Equals(MCIKHPLGCGG MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7C30", Offset = "0x7DE6230", VA = "0x187DE7C30", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xF3E440", Offset = "0xF3CA40", VA = "0x180F3E440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8550", Offset = "0x7DE6B50", VA = "0x187DE8550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8140", Offset = "0x7DE6740", VA = "0x187DE8140")]
	private static JFDGJOPOGFB MLLMHMJPAIE(byte BOJCEMEJOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7DE84B0", Offset = "0x7DE6AB0", VA = "0x187DE84B0")]
	private static PFIKMKHDNCH PIKMGANLKLG(byte BOJCEMEJOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7AD0", Offset = "0x7DE60D0", VA = "0x187DE7AD0")]
	private static object DPPPILPIOPJ(byte BOJCEMEJOMP, object[] DHLGAIMCINE, object JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8120", Offset = "0x7DE6720", VA = "0x187DE8120")]
	private static int KMOOGPOBOFE(byte BOJCEMEJOMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8130", Offset = "0x7DE6730", VA = "0x187DE8130")]
	private static int KOMODOIIBMM(byte BOJCEMEJOMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7A50", Offset = "0x7DE6050", VA = "0x187DE7A50")]
	private static (int, int) BBPNAMOOABL(byte BOJCEMEJOMP)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8110", Offset = "0x7DE6710", VA = "0x187DE8110")]
	private static byte GPCBCABHEFJ(int DJNGLBELENN, int OHHMJGCBCKD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7DE77B0", Offset = "0x7DE5DB0", VA = "0x187DE77B0")]
	internal static MCIKHPLGCGG AMBIAOGNIIF(PFIKMKHDNCH FIOIFOJKKOC, JFDGJOPOGFB GEGFLIFOKBD)
	{
		return default(MCIKHPLGCGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7DE81E0", Offset = "0x7DE67E0", VA = "0x187DE81E0")]
	internal static void OMFPKPKPLOB(MCIKHPLGCGG BOJCEMEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7CD0", Offset = "0x7DE62D0", VA = "0x187DE7CD0")]
	private static void GLNJLHBIKLI(int GDBMBEIFFOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum IPHDJOCEDEC
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
public interface APBGIPJFONH
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool HNIJKEHIFHG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool HLHIMMMHDCN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool PCGEAJOBCHI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool HDEHGNAIIOI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool AEEFKJKAFOE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MDAMIAHMJMG
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGINGBIJMIF(OBPKIIBMPDB NELIKBMJKPH, int OHHMJGCBCKD);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LJPHIJFCJAI(OBPKIIBMPDB DLGFEIHNEEL, int OHHMJGCBCKD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GACPANOOIED : OBPKIIBMPDB, APBGIPJFONH
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int PJLJIJDCEPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFIIOHOMPLL(LNMIFJPCOFM HIECCNNOPLP, int OHHMJGCBCKD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OBPKIIBMPDB : APBGIPJFONH
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum PCALFNEAGLA
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
	bool IFNEFCOEAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool BLJOPGAPDCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool NLOEIFNCGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface LNMIFJPCOFM
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool ADABPPHFAHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	JMKKFNHDEDM DDFIIFDAIAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	FOMLNLPBHFI KGCJNDOKALP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float3 MJJFMHOFJKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	quaternion GMKIGHDIIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float3 DAEGLJOIOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	OFEGKJHLAID FNLBLGEDCDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	GBOINGGHPAL FIGDBNMNPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float GLOADLJCNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float3 EHLPPMACBJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float BLIHKAJLHIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	CMOLENMEPKL DDPGFAHMEKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface CLKJFOBLBON
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float3 HOKNMKCMKBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float3 PHFBCBJEPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion BFANIFNHBPL(float3 MPHNLOFBHEJ);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface FOMLNLPBHFI
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool GAGKMEDIIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool DCIOKLKOBML
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool JPDHAHGCJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	float AFHEOEDEDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	int LMJOALMNJPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int HJJOOOBJKML
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PDBEGOIBOHP(CLKJFOBLBON HIECCNNOPLP, int OHHMJGCBCKD);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.Application)]
public interface PBIHKACBFOG
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Guid FGOMODEFFAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CCGKNLEPJOE(Guid GKPONEBNEEG, Guid MIEKOPKCEML, Guid POCIGDHABEG);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task JODLAOJBBKP(Guid GKPONEBNEEG, Guid[] HJGPIGMNBKJ, Guid POCIGDHABEG);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid CHBDNOGILFE(Guid KJCOKJBCCGD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task GHPLGFFHBGK(PKENAFNLEAO HCFCILAOEGC);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NOFOKDDDNFK(Guid KJCOKJBCCGD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KEGABFANPIJ(BFGONFIABIE DKPNLGKCOGG, Guid GNAFDNCDHNF);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OPKMCCGOKHC(Guid KJCOKJBCCGD, bool BFEIIPBAHBE);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IPEAPJLCEDA(Guid KJCOKJBCCGD, JOKHKLAANOK BJDODAFJOLK);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ECJOCGLFDEB(JOKHKLAANOK BJDODAFJOLK);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JEEDMHEJJHE(PKENAFNLEAO GOGGPBKDKBC);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface MBIJHFNKOKE
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface OBGKLBPGBOB
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBHJEKPCPDJ(GameObject JGOBGJAFGMO, GameObject ALEFILFOPMD, int DCKHPKBNAHB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface OEGDGICABHM
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "0")]
	void JGNHDFDNIFH(bool MIHGKLOAIPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface AGIEMMJDJAD
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	OEGDGICABHM ACAAFAOMBHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	PHDLCJPOFGG AIHCIMBGDII
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	LDJPADFKOLN EMIMCJJICOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	HLDCDCEOOGF LPILECHLBNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	DONCFGGANJP FMBMLHKHPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	EDPPKIGFMAH LGEDLEMKDIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	NALOABJFOMC EIAOJEOMFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	FCAFMICDBAN JKEBHBNHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface PHDLCJPOFGG
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	string ABPDBHDFBEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface BHCNCOLEGHH
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLBCPNNADOH(Action BDCLNIJAFBF, bool APHALDJIPGE);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KICLCFLDCJC(string NFHOBPDKIPM);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int NNOIHJGKKGM(string NFHOBPDKIPM, int JMMNJNFGHEP);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ONFPPKHLLJM([Out] bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MHAIOCLMHEM([Out] bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GEBMELFDCFP([Out] int OHLIHBDBKCE);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface LDJPADFKOLN
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "0")]
	void EFABNCHHBNE(bool BFEIIPBAHBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface HLDCDCEOOGF
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid NGBOMHKCBKL;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid CGLPLEKEDIG;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid KBANGBACIEK;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid FOCMLOHPNEJ;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool CKOLJBHFBAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool CMFLEGDLPII
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool MJMENIKKMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3D50", Offset = "0x7DE2350", VA = "0x187DE3D50", Slot = "3")]
	string[] AHAENMNLAJH(GMMJMMMKMBM ONIFFPELODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DLIIACADACF();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3DE0", Offset = "0x7DE23E0", VA = "0x187DE3DE0", Slot = "5")]
	Guid LCCMIPNIGKE(Guid FBONMOIDOMA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int HFGONLBEBHH(GMMJMMMKMBM ONIFFPELODH);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EOCDJNPLIFG(GMMJMMMKMBM ONIFFPELODH, NativeArray<AGCPOHHPGAF> BEKJIGEKCOF, NativeList<UniformTRS> AIFOHNJFHGN);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int LGELBINNONB(Guid DGNNPFFMIEE);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ODGDOKGIONG(string NJBHNMHIDFO, [Out] Guid DGNNPFFMIEE);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string EAFHOAFCGEO(Guid DGNNPFFMIEE);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HCGGFJOFFLD(RRObjectPrefabData MCINBCDCECO, [Out] LocalId IOGPJKLGKKO);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	KOGLLFEDMCC<byte[]> JMCEHFGEBGE(NativeArray<AGCPOHHPGAF> NIACHDJHBLJ);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HIMLMDMHGGN(byte[] GAJOCMHPGFM);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GameObject KPLNLNBHDFL(string NJBHNMHIDFO);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LLLLLLOFFNI(Transform KOOMPFGMBLG, RRObjectPrefabData GBKIPHJMLKJ, IDHOFIHAGPL INLEBAAACKH);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool CIJKICGDGHJ(GMMJMMMKMBM ONIFFPELODH, NativeParallelHashMap<Guid, LocalId> POIJNLDGPMA, [Out] Exception FJADMGBFJLD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OHBLEJNOAIP(GMMJMMMKMBM ONIFFPELODH, NativeParallelHashMap<Guid, LocalId> POIJNLDGPMA, [Out] NativeArray<LocalId> ANKLKPHHPBD, [Out] NativeArray<LocalId> GJBCDGBBFFE, [Out] NativeArray<AuthoredLocalPoseData> KDPBFBKIDNK, Allocator NDFENJBGNOB);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "18")]
	void ACPCNAFCLLH(GMMJMMMKMBM MKIDPONBDDE, NativeArray<int> HKHJDBHLOPP, IEALDBHBOML<GameObject> DKCADDLDDHK, KOGLLFEDMCC<GameObject> AMKFPCCJENE, IPHDJOCEDEC KIFOODGHOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KKFBAFGHHEO();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "20")]
	void PGDCFMADNDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "21")]
	void AKLOKBMEPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "22")]
	bool MBHLHADIJIE(GMMJMMMKMBM ONIFFPELODH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "23")]
	MDAMIAHMJMG KPJAKCGCJCC(GMMJMMMKMBM ONIFFPELODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "24")]
	void AKLJKPNNOLK(Guid IGEEKENFEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "25")]
	bool BDJKNEJFENH(Guid IGEEKENFEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3E10", Offset = "0x7DE2410", VA = "0x187DE3E10")]
	static HLDCDCEOOGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface FIADFKFHGFN
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	long AAEELLGEEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	long OCNLGJJEGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface DONCFGGANJP
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool CHECBKFCEBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool IKLDAEPDKBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int AGOECKHDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	int BGJGEDOMAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	int DDCBBJHJIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool JNMCILIFCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	int BIKBDINGKJG
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "6")]
	void OCENNBDNFPA(LGPPLIONBEJ NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
	void FLKJBDIOONN(bool BEGGKKFBCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "8")]
	bool PMGKBGMFLIC(AEMMHEJJEHA LFJPHGCMAAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "9")]
	void OFMEIPHEHKH(object DGHLABNPIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "10")]
	void NPLJIMPLMPL(object DGHLABNPIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JMAIIBAAAHB(Action<object> KJDFKHKDNAG);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DKEEGAHIBDC(Action<object> KJDFKHKDNAG);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "13")]
	void OMOAFCHFHED(NativeArray<ViewId> GLPPOJJACGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "14")]
	void AIAECCDLHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "15")]
	void PKMLHPLFEOA(JJHDADELCNN MLCOGCMJLBB, ReadOnlySpan<byte> APDBNIMCPID, AEMMHEJJEHA HDJKAKBEEHP, bool GDODKGKIGCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "16")]
	void PKMLHPLFEOA(JJHDADELCNN MLCOGCMJLBB, ReadOnlySpan<byte> POKFLEFBJIN, bool GDODKGKIGCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "17")]
	void PKMLHPLFEOA(JJHDADELCNN MLCOGCMJLBB, ReadOnlySpan<byte> POKFLEFBJIN, ReadOnlySpan<byte> FCFDBMEMFFB, bool GDODKGKIGCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "18")]
	void LIPMCIFOFMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "19")]
	void KGNAMHOFKAH(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "20")]
	void HNJICKPJFPC(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "21")]
	void DJCBAHCAGBO(Dictionary<object, object> OOEBHGBDHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "22")]
	void CIKCAKFFBAA(NativeList<JOKHKLAANOK> KKNDIEDAIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "24")]
	void OIBCJJHHIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "25")]
	void IDBMOIOCGKJ(List<object> EIHAJEPOKNO, int NGFMNKONPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "26")]
	void KCBNGLMGLMO(int IOJMHKOAJAA, object NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "27")]
	void KKJCGJAIKOO(AEMMHEJJEHA LFJPHGCMAAL, Dictionary<object, object> FBEFHOGBKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "28")]
	void HJEEFCHPPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "29")]
	void DAHNNJDIFFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class GBBOFAGGLNN
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1C10", Offset = "0x7DE0210", VA = "0x187DE1C10")]
	public static BIPNFKLBNLH DFKJBIGKMDL(this DONCFGGANJP JDPKJPILGNF, object EJJDDFFADPC)
	{
		return default(BIPNFKLBNLH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct BIPNFKLBNLH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private DONCFGGANJP JDPKJPILGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object EJJDDFFADPC;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7DD89E0", Offset = "0x7DD6FE0", VA = "0x187DD89E0")]
	public BIPNFKLBNLH(DONCFGGANJP JDPKJPILGNF, object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8990", Offset = "0x7DD6F90", VA = "0x187DD8990", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MAEGKODGPCB
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate void LNPDCBELAAF(ViewId HMGHCPIBIBG, ABBHPHKIIPL MBIKDPPKIJB, int OHEIAKHGGAM);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "0")]
	void AFDGONJKHDP(LNPDCBELAAF AEFKIHAGPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "1")]
	void BHELIOMMIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "2")]
	void HLMCIJOMPJF(CEADAKHMIIO KGFBFINKAKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface KIMGFOJMMIB
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[ServiceLifetime(Lifetime.Application)]
public interface EDPPKIGFMAH
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct PNPGPAFCDHD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private EDPPKIGFMAH COPBMIMKBIE;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7DEDFD0", Offset = "0x7DEC5D0", VA = "0x187DEDFD0")]
		public PNPGPAFCDHD(EDPPKIGFMAH COPBMIMKBIE, string PAGMGOCFAHK, string GIHMCGLNOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7DEDF10", Offset = "0x7DEC510", VA = "0x187DEDF10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct GIGJIOJBCKO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private EDPPKIGFMAH COPBMIMKBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task BGKKDAHMDLM;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1E50", Offset = "0x7DE0450", VA = "0x187DE1E50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "0")]
	void FBDIDGLJBCF(string NAAMEAFIHJI, float JHNMLGDIFJL = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "1")]
	void CABKKGAOGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DAIHFPDFCLF(bool BGNGIHPLDAI, string PAGMGOCFAHK, string GIHMCGLNOKD);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "3")]
	void PGJENBANMPN(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class NFBJLFPBOIE
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB1C0", Offset = "0x7DE97C0", VA = "0x187DEB1C0")]
	public static EDPPKIGFMAH.PNPGPAFCDHD NGBHBPEMCEM(this EDPPKIGFMAH JDPKJPILGNF, string PAGMGOCFAHK, string GIHMCGLNOKD)
	{
		return default(EDPPKIGFMAH.PNPGPAFCDHD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.Application)]
public interface CPLANMEIGJD
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int EIAJDHKABLL(GameObject CEKGANCAJPA);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IABGODELEJD(GameObject CEKGANCAJPA);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LDDCNPOMEFA(int LFJPHGCMAAL);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object IBDNLIKAJFA(PKENAFNLEAO GOGGPBKDKBC, GameObject CEKGANCAJPA, Action<PKENAFNLEAO, int> COLEJLDPDCO);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CBFHCOICNDL(GameObject CEKGANCAJPA, object LCCLAAIELLN);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface OODLEFFHPAE
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFNAEDFOBIJ(object BOMDCGFKGKF, NativeList<byte> APDBNIMCPID);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object AKDPGDCBDMI(NativeArray<byte> APDBNIMCPID);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface CAPHLEAENCM
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool NHGNKHJLJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate NLJEEIDPLCC(KGHDONEDALP KNDMDBLHCEC, Action<KGHDONEDALP> COLEJLDPDCO);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NEOHJLCGNHK(KGHDONEDALP KNDMDBLHCEC, Delegate COLEJLDPDCO);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate BAHINBKLIHM(KGHDONEDALP KNDMDBLHCEC, Action<KGHDONEDALP> MECIBEIJCFG);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DEBEKGFJFCJ(KGHDONEDALP KNDMDBLHCEC, Delegate COLEJLDPDCO);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BNFOGIBLEGI(KGHDONEDALP KNDMDBLHCEC);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KGHDONEDALP GNPGDGJEKDG(GameObject CEKGANCAJPA);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface LHHJMHEOFOE
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int GFPNNIAMODL
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	int BFDHHFOPKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool CHECBKFCEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool GEJDDFMKNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool IIDFPACHPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PKENAFNLEAO KJAKCECOEFI(int LFJPHGCMAAL);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
public interface NALOABJFOMC
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool IECDEPKNLOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
public interface FKMDIIGFMOG
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	GDHFOHFFOAJ EJHJKDKNCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	LGCPEOGBNJG NPOIHCKJNLL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool GLDGJHELAFP
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PNCGAIBHMMI(Transform KOOMPFGMBLG);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HIDCIJOICIF(Transform KOOMPFGMBLG, LIPCMCBNFNH PFJJFNALOCA);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ELBKMKIFEFB(Transform KOOMPFGMBLG, KIOOHKBHOLJ PNKDOABFNIB);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.Application)]
public interface FCAFMICDBAN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NHNHFNBFLJL;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.Application)]
public interface IFKLACHFPCM
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHPIELNAPFF();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface JNELMDNMFDC
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMLBDOBFCPP(GameObject CEKGANCAJPA, FMJNGMHIFLD NBNFPDIJKLC, NAAMCHMIHPA PAEADOBBFMB);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PNHEIDDBCIG(PKENAFNLEAO GOGGPBKDKBC, bool DIMLBBHKPHM, float3 PIGBFBNLBPB, quaternion BGKEBAKNOPK);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MPDIHOCNHAE(EPFJFEANHAG IIBNCDLJLAM);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LCDKGIMCBEL(FHMOHIBLLDK AMICCGMJHBK, FHMOHIBLLDK FCPOJLOEIEO, AEGDAJEGAFP KOJNMKELJGK);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDGHBEMECNF(FHMOHIBLLDK AMICCGMJHBK, AEGDAJEGAFP KOJNMKELJGK);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GHCBEGOOPMG(EPFJFEANHAG LFAAMINANEC);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject HFPIKPLJHLM(Guid FDOHCLJHKCE);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BCIMMNOJFIM(BENOGLOIGDB FPNICFGNJFG);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct DIPNDLFJDFI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> APDBNIMCPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle BOJCEMEJOMP;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC350", Offset = "0x7DDA950", VA = "0x187DDC350")]
	public DIPNDLFJDFI(ReadOnlyMemory<byte> OAEJJMIBANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC310", Offset = "0x7DDA910", VA = "0x187DDC310", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public enum KCLKFNLJNED
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
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct GMMJMMMKMBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString BMJLEGKBFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object NGAFBJACKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object EOPDLHGAHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> AAFOOIONLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool AGDDJKICOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public IPMMDEECEEK.ICKPMAIPPEB? FOLOAIHNJIN;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2350", Offset = "0x7DE0950", VA = "0x187DE2350")]
	public GMMJMMMKMBM(ByteString BMJLEGKBFJF, [Optional] object NGAFBJACKDA, [Optional] object EOPDLHGAHLC, [Optional] IEnumerable<string> AAFOOIONLMM, bool AGDDJKICOBO = true, [Optional] IPMMDEECEEK.ICKPMAIPPEB? FOLOAIHNJIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct ANHMGEDKMKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object CDBBEPNLPPM;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct AGCPOHHPGAF
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[Flags]
	public enum MJGNNGDLOEF
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
	public RRObjectPrefabData AIKIMFDJJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid CJHMIILEEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid HKDKICKHFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid LCEONEOACGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid FHJKOGOPCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public MJGNNGDLOEF EIBMLBPPJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 FMGCKKPOHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int ILIJOMFFCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public ODJKILGOGDI CPAIMIDEHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int PFOOLLIKJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int FCJDDOLABEA;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Guid HEJDCDKKMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x50C5C10", Offset = "0x50C4210", VA = "0x1850C5C10")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public bool LPEHKAKMMPO
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7DD7FA0", Offset = "0x7DD65A0", VA = "0x187DD7FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public bool AMKIAPGOAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7DD7F90", Offset = "0x7DD6590", VA = "0x187DD7F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool HPFGKIHMNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7DD7F80", Offset = "0x7DD6580", VA = "0x187DD7F80")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct BEBOGOKNNFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal readonly AOLBMFFJHGC IPAELMFFKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly AOLBMFFJHGC LLDMNGOPBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly uint JKPNJMLFOAJ;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8730", Offset = "0x7DD6D30", VA = "0x187DD8730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct EPBOIDHPIDB
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal readonly BEBOGOKNNFD BDCLNIJAFBF;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDC80", Offset = "0x7DDC280", VA = "0x187DDDC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct MCBLNCPIMEB
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal readonly BEBOGOKNNFD BDCLNIJAFBF;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDC80", Offset = "0x7DDC280", VA = "0x187DDDC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct PILIOEOBCPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly uint JKPNJMLFOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly bool HOLJHPAALAE;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7DED310", Offset = "0x7DEB910", VA = "0x187DED310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct AOLBMFFJHGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal int LLPAIMMACAP;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7FB0", Offset = "0x7DD65B0", VA = "0x187DD7FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[ServiceLifetime(Lifetime.Application)]
public interface EMEIOKNONNN
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	OFDILCIHJGN OKKKLCKJJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface BFGONFIABIE
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface LBDMLBBBNCA
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class EFPHPBHOLEI
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x36FBFE0", Offset = "0x36FA5E0", VA = "0x1836FBFE0")]
	public static FHMOHIBLLDK AFDJJEADFEL<T>(this T GOGGPBKDKBC) where T : BFGONFIABIE
	{
		return default(FHMOHIBLLDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDC00", Offset = "0x7DDC200", VA = "0x187DDDC00")]
	public static MonoBehaviour JNBKLJNDNKG(this BFGONFIABIE GOGGPBKDKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDB40", Offset = "0x7DDC140", VA = "0x187DDDB40")]
	public static GameObject ACLMMAOCLNG(this BFGONFIABIE GOGGPBKDKBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface HILAFJDBHDG : BFGONFIABIE
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(PKENAFNLEAO DCOBGODCAEM);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface HJFIADACPMC : BFGONFIABIE
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DJCKMCMPEID
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public delegate void HKJAOCICHEG(LKIPFKKDGIK AHKPNJKCKBD);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event HKJAOCICHEG LKKEEJJEFKN;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface CODAMHMGOBC
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface PLBHICEOMKN
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface BOIHGIDCPDB
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(PKENAFNLEAO KGKNGKFAHON);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool ALDLIBJKCFM);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IHOJPFIJONP(PKENAFNLEAO FOCJCDLOOLD);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface BJKEPIMPBJP
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(HAIPDKCGNLO JNMADIEGPNH);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface HAIPDKCGNLO
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	GameObject CEKGANCAJPA
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Transform KOOMPFGMBLG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	AEHCCAJOAGK FNDDPAPJHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool BLMJJKMHDAL
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LEEOOEGGPMK(AEHCCAJOAGK HCAMONPFOJM);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JOBMDEJONPK GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class BJAFKBDJDIN
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8A70", Offset = "0x7DD7070", VA = "0x187DD8A70")]
	public static void LABPEBAABNH(this HAIPDKCGNLO DPBHNMFBAMI, IDHOFIHAGPL INLEBAAACKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface AEHCCAJOAGK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Rigidbody LJPLOMDHOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	HAIPDKCGNLO JONJPMBBDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	GameObject ACLMMAOCLNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Transform IOFGLPCMIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	AEHCCAJOAGK LHCPKJJPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	AEHCCAJOAGK FMDIEJKNFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	int GGKEEFPNDLI
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	bool MPKPPHOFPOF
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	bool BNFOGIBLEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	bool LMGPENNCPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	FGHLALPKLCB GPHCHFOOBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	EKDAONPNEDM PFHAOKHAIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	float KAAKNIDJMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Vector3 MBONAKJIGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Vector3 PPKJNICDJFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	Vector3 MHHKMIMGCEN
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	Vector3 NGPCALAEKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	bool CEDPDMFFJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool DDMKCNDEBIH
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	bool AAHPAEKNPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	bool ACLAGMPFHFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 IKEEOKKFNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 PPOEAMFJKMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Vector3 DIFEGNJKDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Vector3 GDHCBFHODJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	float ILIOIANLCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	float IMNDBPGANOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	Vector3 KCEMHIHMFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	Quaternion NEFBFOAEHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	float HLOJOBIKJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	float AEIOPPGFCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool KNIBBPIGMCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	DINEBAHNNBA COBALJIKJEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	bool KGPPIMBCPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	Transform BBBFMBKGKMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Vector3 OAPICFGGNEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	float JLKGIJBFPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	float LAJMIGPLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	Quaternion MHHJHPJKLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	Vector3 HOKNMKCMKBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	Quaternion OIMDLFMMKJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	RigidbodyConstraints NDDPBBNBEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	bool GOEFNOABCHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	CollisionDetectionMode JJAOGKDDDON
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	bool MEJBNGFPHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event PNBPECEEHKD AOKFEFCGPPH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event PNBPECEEHKD GIBENIPGOKD;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event PNBPECEEHKD HMGIPDEBDGF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event PNBPECEEHKD GMDAEOELBFI;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event PNBPECEEHKD GMAEPBAHAJE;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event PNBPECEEHKD GPEMFODEPMN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event PNBPECEEHKD OEJFEEIDNPB;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event GNDLKMBGIHB KIAKJBHJBDD;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<MEACMOOJHJN, MEACMOOJHJN> CEBDFAKFDNI;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	AEHCCAJOAGK PFAEDCJHGFC(int OHHMJGCBCKD);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void NMOLEIEJHFM((Quaternion rot, Vector3 moments) CKBACCDPBIH);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void LLGFJHIIOAB();

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void JAINDIDLLHK();

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void OIABCBMEMDD();

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void NKDGHBONJAC();

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void PLELPHGDIGK();

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void PFEAOMFGIPC(AEHCCAJOAGK OHLIHBDBKCE, bool CCADIPLOOPF = false);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void IBEAKFJFBKO(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void BKNOHCLGOHB(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 IIACFCKBMEK(Vector3 BNPCCEGFLAG);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 FABBPJPCFND(Vector3 OCDMHIHKCOM);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void IDLPDECABCM();

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void CLGDPDBNAMG();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void DIIEGPIOIEF();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void MBNADKIEICD(Vector3 BFCMGGLPKOG, Vector3 CFMHHLGNOMG);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void FOPCBHBBKFA(Vector3 FHHDANGJANF, Vector3 MKJAKHMCJFJ);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void LANBKIAKANC(Vector3 PBPCDIDONHL);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void IOFCEMOCNKJ(OCNBACAEJKA IIPHGHABFEI, Vector3 FBJOGNFJNKE, float GINNKEFNNNJ, float AGKFEOKGNFN = 8f, float LKKCFIBADJL = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void CKHAMKNHENO(GNGBJGPGOGK DMMOCNOPLNI, Vector3 CFIMLPPLPIK, float KMIIDKLEDDJ = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void JBLCNFLLANL(GNGBJGPGOGK DMMOCNOPLNI, Vector3 OOBEGCNALKF, float LNKOBALGGOE = 7f, float OKOMENKNBDN = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 BMCODDGJPBA(Vector3 OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 FODFMHBJNNH(Vector3 OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void ONIIAKFKNGM();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void GMDBJOIEBEK(AEHCCAJOAGK GHCGIEELPNO, object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void HCJADAIAMEA(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void BHIHKAKKCLF();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void HPBGKAMNHIG();

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void KLLMDLAJOMO();

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool GMPMKPGGEJG();

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void BOLEDFNDLNO();

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void HHNGPMIMDOO(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void ECLLEAMJHDE(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void BLLMHFJJADE(object EJJDDFFADPC, bool GFJJBICPGBM);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void ICKOCOBMLLD(Vector3 DPNBIIDKBAI, Quaternion JFHALMAIDBM);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void FNKNCAGNOEC(Vector3 MELCAIBPDLF, Quaternion IFIPONJHJJD);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool DEJIONOLPFN(float KDJJCHBMFBP);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void MPHIBMNGJNG(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void FGCBCNACPMH(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void OLPGEFNAPKA(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void LLJCOJABAHE(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void FGIFEHKDDPN(Vector3 ECOALLGHBMI, ForceMode FMAPMNGMDMD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void LGOCIELBIIK(Vector3 ECOALLGHBMI, Vector3 EPCLGOKLIPO, ForceMode FMAPMNGMDMD);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void KKOKDJLJLLK(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void NJFLMALDHNB(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool LMNOMKFELDH(Vector3 IGEMMIGMOOK, [Out] RaycastHit CHOONAICPAA, float JPGIFEODCKP);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void EPCDCICFCMJ();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface EKDAONPNEDM
{
	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCHKOFLPAJO(Vector3 HLDOPCINELP);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGABAHFECHD(Vector3 NAPJPBKPLFK);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OLHOOAFKHHP(Vector3 HLDOPCINELP);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JHLAIMHHNJG(Vector3 NAPJPBKPLFK);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface FGHLALPKLCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 KHMLNLOJDIG();

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 PCGDBHDCGFH();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GNDAJCOACJJ(float CLFAAEDMDHI, float FBDABLGDOKL);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate void PNBPECEEHKD(HAIPDKCGNLO KGBOBDLJEJA);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum HMJOAFBBNIA
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
[Cpp2IlInjected.Token(Token = "0x2000059")]
public enum OCNBACAEJKA
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
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate void GNDLKMBGIHB(HAIPDKCGNLO KGBOBDLJEJA, bool CCADIPLOOPF = false);
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum GNGBJGPGOGK
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct JOBMDEJONPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Rigidbody OHEGODNMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public object EGLHICHHNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Vector3 BPGNLFEJJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 IHADCAGHIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public KDGIOFPALDJ KAHHOMCKKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool JEABCFIILCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool KBIPMHKJCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool BMOGIIBLMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool OJMCGKMFGHI;
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct FHMOHIBLLDK : IEquatable<FHMOHIBLLDK>
{
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public static readonly FHMOHIBLLDK APCCKFBGCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public GameObject CEKGANCAJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1670", Offset = "0x7DDFC70", VA = "0x187DE1670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public JOKHKLAANOK DJFLGABMOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1440", Offset = "0x7DDFA40", VA = "0x187DE1440")]
		get
		{
			return default(JOKHKLAANOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public GJNFILFOLKG JCIBBEHNKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0D50", Offset = "0x7DDF350", VA = "0x187DE0D50")]
		get
		{
			return default(GJNFILFOLKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public RRObjectPrefabData LHJNCGFCANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1140", Offset = "0x7DDF740", VA = "0x187DE1140")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool FDABMDENDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1880", Offset = "0x7DDFE80", VA = "0x187DE1880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool LOPFELBFCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7DE12F0", Offset = "0x7DDF8F0", VA = "0x187DE12F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool ADABPPHFAHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1120", Offset = "0x7DDF720", VA = "0x187DE1120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool AMGEAKLHNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0ED0", Offset = "0x7DDF4D0", VA = "0x187DE0ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool LJDBFAFCPOG
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1420", Offset = "0x7DDFA20", VA = "0x187DE1420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool HCPEECLPKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7DE18A0", Offset = "0x7DDFEA0", VA = "0x187DE18A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool POPKLEAALBB
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1340", Offset = "0x7DDF940", VA = "0x187DE1340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool ICCPOCMFLOB
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7DE15F0", Offset = "0x7DDFBF0", VA = "0x187DE15F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool JFPJBMAHEPE
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1840", Offset = "0x7DDFE40", VA = "0x187DE1840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool DCHDPFJKCAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7DE14E0", Offset = "0x7DDFAE0", VA = "0x187DE14E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool CLENHCLHFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1560", Offset = "0x7DDFB60", VA = "0x187DE1560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool HLJKGLGCBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1050", Offset = "0x7DDF650", VA = "0x187DE1050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public FFILBNGKAEI HBLBHDLDIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FFILBNGKAEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public HLBCBCAPFMK BKPDOGJBNCH
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(HLBCBCAPFMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public NDOAGFPLDPK EMKCPEDCHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(NDOAGFPLDPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public OPBOIHIBKPJ IFBCANCBFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(OPBOIHIBKPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public PEJPDCJFEEE IAIDOPELHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PEJPDCJFEEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public NCAEICFPBFD GFCBKOJCFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(NCAEICFPBFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public GGKIHAKCMMB NPOHIGDKKGH
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(GGKIHAKCMMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public GKICDLHNCGI KDHCAHGIEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(GKICDLHNCGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public GOAJGFMONCL IJLGNAMOBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(GOAJGFMONCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public OKCIBHBFCOA HAPDFBNNNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(OKCIBHBFCOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public MEANPGBNIMN GOIDMDDDDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(MEANPGBNIMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public BCCKKOJMEKI IAJFHPLPFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(BCCKKOJMEKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public FFHIEPLKEAI LPEKLBINOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FFHIEPLKEAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool ELNDFGOAECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0EF0", Offset = "0x7DDF4F0", VA = "0x187DE0EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool CDLJJFLFJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0E90", Offset = "0x7DDF490", VA = "0x187DE0E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool JPKMPLCHJKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1630", Offset = "0x7DDFC30", VA = "0x187DE1630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool NOMOJCGANNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1040", Offset = "0x7DDF640", VA = "0x187DE1040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool IEFMFOLOPKL
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1800", Offset = "0x7DDFE00", VA = "0x187DE1800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool DBGLFHDECKF
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1000", Offset = "0x7DDF600", VA = "0x187DE1000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool IDIJNGCGMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1520", Offset = "0x7DDFB20", VA = "0x187DE1520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public CPPKHLEDPPI IOFGLPCMIME
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(CPPKHLEDPPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public DJLMBDFBDEJ OFIGOOBGDCB
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(DJLMBDFBDEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private JFDGJOPOGFB PIJODJEEGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB510", Offset = "0x7DD9B10", VA = "0x187DDB510")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
	public static FHMOHIBLLDK OIFHDJNIHDL(PKENAFNLEAO DCOBGODCAEM)
	{
		return default(FHMOHIBLLDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1270", Offset = "0x7DDF870", VA = "0x187DE1270")]
	public DOHDBOLIGOB FJCFLBNPMFL()
	{
		return default(DOHDBOLIGOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7DE18D0", Offset = "0x7DDFED0", VA = "0x187DE18D0")]
	public KBDIFHCKPFF OAFOIBELKKI()
	{
		return default(KBDIFHCKPFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1A50", Offset = "0x7DE0050", VA = "0x187DE1A50")]
	public CGNFCMEGBON PDKLEKLHCGA()
	{
		return default(CGNFCMEGBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1310", Offset = "0x7DDF910", VA = "0x187DE1310")]
	public MKLBNEFOJLE GLBMHNMBJEP()
	{
		return default(MKLBNEFOJLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1A00", Offset = "0x7DE0000", VA = "0x187DE1A00")]
	public JEMGPGCFPMK ONJJFOGMPNF()
	{
		return default(JEMGPGCFPMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7DE15A0", Offset = "0x7DDFBA0", VA = "0x187DE15A0")]
	public EENOHCEIIBC KLKJPDAIHCD()
	{
		return default(EENOHCEIIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1900", Offset = "0x7DDFF00", VA = "0x187DE1900")]
	public void OFGNPFAPJKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1380", Offset = "0x7DDF980", VA = "0x187DE1380")]
	public void HMHHJKJOIHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0DF0", Offset = "0x7DDF3F0", VA = "0x187DE0DF0")]
	public bool AKFDKENFCCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1AA0", Offset = "0x7DE00A0", VA = "0x187DE1AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public FHMOHIBLLDK(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9710", Offset = "0x7DD7D10", VA = "0x187DD9710")]
	public static bool OIFHDJNIHDL(FHMOHIBLLDK OHLIHBDBKCE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
	public static PKENAFNLEAO OIFHDJNIHDL(FHMOHIBLLDK OHLIHBDBKCE)
	{
		return default(PKENAFNLEAO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF9F0", Offset = "0x7DDDFF0", VA = "0x187DDF9F0")]
	public static bool MMJMCICIDNJ(FHMOHIBLLDK FDJHCIBLFFB, FHMOHIBLLDK CNIMJCCKEDM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0FE0", Offset = "0x7DDF5E0", VA = "0x187DE0FE0")]
	public static bool DIKHMNDIIDO(FHMOHIBLLDK FDJHCIBLFFB, FHMOHIBLLDK CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1090", Offset = "0x7DDF690", VA = "0x187DE1090", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(FHMOHIBLLDK MIJLJBIHDMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct BCCKKOJMEKI : IEquatable<BCCKKOJMEKI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private ACFBKCGGNLM ONBFJLOJABD
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7DD86B0", Offset = "0x7DD6CB0", VA = "0x187DD86B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7DD86A0", Offset = "0x7DD6CA0", VA = "0x187DD86A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD85A0", Offset = "0x7DD6BA0", VA = "0x187DD85A0")]
	public void IGPKHBKGLAH(uint HJPLNJNIFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8470", Offset = "0x7DD6A70", VA = "0x187DD8470")]
	public bool GBGPONOIJJH([Out] uint HJPLNJNIFLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7DD82D0", Offset = "0x7DD68D0", VA = "0x187DD82D0")]
	public bool DHJMHCKECJL([Out] uint HJPLNJNIFLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8170", Offset = "0x7DD6770", VA = "0x187DD8170")]
	public void ALBBAGEFKMH(string HJPLNJNIFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8010", Offset = "0x7DD6610", VA = "0x187DD8010")]
	[CanBeNull]
	public string AHHNPJPDHHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public BCCKKOJMEKI(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7DD83D0", Offset = "0x7DD69D0", VA = "0x187DD83D0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(BCCKKOJMEKI MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct FFILBNGKAEI : IEquatable<FFILBNGKAEI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private OIAIGLOONMN IMPGAEAPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x7DE02E0", Offset = "0x7DDE8E0", VA = "0x187DE02E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private ACFBKCGGNLM ALDKCMKOLIP
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0760", Offset = "0x7DDED60", VA = "0x187DE0760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool PJALKEFLPME
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x7DE05B0", Offset = "0x7DDEBB0", VA = "0x187DE05B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool KNGFPLIINEO
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0460", Offset = "0x7DDEA60", VA = "0x187DE0460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool PEBEDEEIPBN
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7DE09D0", Offset = "0x7DDEFD0", VA = "0x187DE09D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public Guid EIKAIJOGKJF
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7DE04A0", Offset = "0x7DDEAA0", VA = "0x187DE04A0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Guid IIODNFIGJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0640", Offset = "0x7DDEC40", VA = "0x187DE0640")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Guid HNOMMBBAEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x7DE07C0", Offset = "0x7DDEDC0", VA = "0x187DE07C0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public DJLMBDFBDEJ OFIGOOBGDCB
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(DJLMBDFBDEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7DD86A0", Offset = "0x7DD6CA0", VA = "0x187DD86A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0B90", Offset = "0x7DDF190", VA = "0x187DE0B90")]
	public bool MBPIODHDMOI([Out] Guid KJCOKJBCCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7DE06C0", Offset = "0x7DDECC0", VA = "0x187DE06C0")]
	public bool IEKLGDANHOJ([Out] Guid MIEKOPKCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0340", Offset = "0x7DDE940", VA = "0x187DE0340")]
	public void BDFNOJEDOMC(Guid GCDAJLDGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0A90", Offset = "0x7DDF090", VA = "0x187DE0A90")]
	public void LIGMPAHFHFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0C30", Offset = "0x7DDF230", VA = "0x187DE0C30")]
	public Guid PPBADINLJJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public FFILBNGKAEI(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0520", Offset = "0x7DDEB20", VA = "0x187DE0520", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(FFILBNGKAEI MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct CGNFCMEGBON : IEquatable<CGNFCMEGBON>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private KLJACPCBIBJ KJKEOGAHFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9570", Offset = "0x7DD7B70", VA = "0x187DD9570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public Vector3 BBOBBKPELCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9230", Offset = "0x7DD7830", VA = "0x187DD9230")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Quaternion MLEPDKMCLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7DD95D0", Offset = "0x7DD7BD0", VA = "0x187DD95D0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public FHMOHIBLLDK NLGAFFCBOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9730", Offset = "0x7DD7D30", VA = "0x187DD9730")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7DD86A0", Offset = "0x7DD6CA0", VA = "0x187DD86A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8E00", Offset = "0x7DD7400", VA = "0x187DD8E00")]
	public EPFJFEANHAG CELLOBKJNPK(Allocator NDFENJBGNOB)
	{
		return default(EPFJFEANHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9380", Offset = "0x7DD7980", VA = "0x187DD9380")]
	public bool IBKFNGFMKLC(FHMOHIBLLDK JHDAOHEONAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9420", Offset = "0x7DD7A20", VA = "0x187DD9420")]
	public void KOEEGHFIPHL(Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8ED0", Offset = "0x7DD74D0", VA = "0x187DD8ED0")]
	public void EOOOLAKNNAP(float HDLKNIPAJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9070", Offset = "0x7DD7670", VA = "0x187DD9070")]
	public void FDEFNDPOEJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public CGNFCMEGBON(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9710", Offset = "0x7DD7D10", VA = "0x187DD9710")]
	public static bool OIFHDJNIHDL(CGNFCMEGBON OHLIHBDBKCE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
	public static PKENAFNLEAO OIFHDJNIHDL(CGNFCMEGBON OHLIHBDBKCE)
	{
		return default(PKENAFNLEAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8FE0", Offset = "0x7DD75E0", VA = "0x187DD8FE0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(CGNFCMEGBON MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct DOHDBOLIGOB : IEquatable<DOHDBOLIGOB>
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly DOHDBOLIGOB APCCKFBGCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private MIJCBDFLLCM FLDMCAPGAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD2A0", Offset = "0x7DDB8A0", VA = "0x187DDD2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<FHMOHIBLLDK> CKOCFIAIKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD8B0", Offset = "0x7DDBEB0", VA = "0x187DDD8B0")]
		get
		{
			return default(Span<FHMOHIBLLDK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD830", Offset = "0x7DDBE30", VA = "0x187DDD830")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD220", Offset = "0x7DDB820", VA = "0x187DDD220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public CPPKHLEDPPI IOFGLPCMIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(CPPKHLEDPPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public DJLMBDFBDEJ OFIGOOBGDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(DJLMBDFBDEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7DD86A0", Offset = "0x7DD6CA0", VA = "0x187DD86A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD390", Offset = "0x7DDB990", VA = "0x187DDD390")]
	public void HCAEMIDAKGI(DOHDBOLIGOB MIJLJBIHDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public DOHDBOLIGOB(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9710", Offset = "0x7DD7D10", VA = "0x187DD9710")]
	public static bool OIFHDJNIHDL(DOHDBOLIGOB OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD300", Offset = "0x7DDB900", VA = "0x187DDD300", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(DOHDBOLIGOB MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
	public static FHMOHIBLLDK OIFHDJNIHDL(DOHDBOLIGOB OCACDKEJIIB)
	{
		return default(FHMOHIBLLDK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public struct PDFFKFEBJJB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Dictionary<int, object> DHPEMHCCIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private IGDOAEDLMGO NBKEAHKBHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private bool IBIHDDIPMBP;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		[CompilerGenerated]
		readonly get
		{
			return default(FHMOHIBLLDK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public IHCOLJNPEOE OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC4D0", Offset = "0x7DEAAD0", VA = "0x187DEC4D0")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC590", Offset = "0x7DEAB90", VA = "0x187DEC590")]
	internal PDFFKFEBJJB(FHMOHIBLLDK BOMDCGFKGKF, bool IBIHDDIPMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC2F0", Offset = "0x7DEA8F0", VA = "0x187DEC2F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x3A0A9A0", Offset = "0x3A08FA0", VA = "0x183A0A9A0")]
	public void NDIHEKGNDCH<T>(IHCOLJNPEOE OEHHKNIGGMI, T OHLIHBDBKCE, [Optional] T JMMNJNFGHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC420", Offset = "0x7DEAA20", VA = "0x187DEC420")]
	public void GNAALOCCJEL(IHCOLJNPEOE OEHHKNIGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0xD8F1E0", Offset = "0xD8D7E0", VA = "0x180D8F1E0")]
	public Dictionary<int, object> ICNDBGEHKNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC280", Offset = "0x7DEA880", VA = "0x187DEC280")]
	private readonly void ACJCHOCLCKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class OBEHLNJOIPJ
{
	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB2E0", Offset = "0x7DE98E0", VA = "0x187DEB2E0")]
	public static PDFFKFEBJJB BGJDLLDNNKP(this FHMOHIBLLDK BOMDCGFKGKF)
	{
		return default(PDFFKFEBJJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct FFHIEPLKEAI : IEquatable<FFHIEPLKEAI>
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly FFHIEPLKEAI APCCKFBGCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private bool CLENHCLHFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0110", Offset = "0x7DDE710", VA = "0x187DE0110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Vector3 DOGELGMOKIE
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0150", Offset = "0x7DDE750", VA = "0x187DE0150")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7DDFE70", Offset = "0x7DDE470", VA = "0x187DDFE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFFE0", Offset = "0x7DDE5E0", VA = "0x187DDFFE0")]
	public Vector3 FDLDBAMKLFJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFF60", Offset = "0x7DDE560", VA = "0x187DDFF60")]
	public void FDKBEBCKKDC([In] Vector3 OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFDF0", Offset = "0x7DDE3F0", VA = "0x187DDFDF0")]
	public void AJEGGLMKGPF([In] Vector3 OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0060", Offset = "0x7DDE660", VA = "0x187DE0060")]
	public bool IFNDFMEDHAM([In] Vector3 OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public FFHIEPLKEAI(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFED0", Offset = "0x7DDE4D0", VA = "0x187DDFED0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(FFHIEPLKEAI MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0200", Offset = "0x7DDE800", VA = "0x187DE0200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct MMAHDEHLIDH : IEquatable<MMAHDEHLIDH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8CC0", Offset = "0x7DE72C0", VA = "0x187DE8CC0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(MMAHDEHLIDH MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct DJLMBDFBDEJ : IEquatable<DJLMBDFBDEJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private MIJCBDFLLCM FLDMCAPGAFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC4A0", Offset = "0x7DDAAA0", VA = "0x187DDC4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public PKENAFNLEAO NNLPMFLCDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7DDCD80", Offset = "0x7DDB380", VA = "0x187DDCD80")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public FHMOHIBLLDK LHCPKJJPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC7A0", Offset = "0x7DDADA0", VA = "0x187DDC7A0")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public FHMOHIBLLDK FMDIEJKNFGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7DDCBC0", Offset = "0x7DDB1C0", VA = "0x187DDCBC0")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7DD86A0", Offset = "0x7DD6CA0", VA = "0x187DD86A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC830", Offset = "0x7DDAE30", VA = "0x187DDC830")]
	public Span<FHMOHIBLLDK> KDFJKLABAAA()
	{
		return default(Span<FHMOHIBLLDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC590", Offset = "0x7DDAB90", VA = "0x187DDC590")]
	public Span<FHMOHIBLLDK> GMPMPDLAEDC()
	{
		return default(Span<FHMOHIBLLDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCAC0", Offset = "0x7DDB0C0", VA = "0x187DDCAC0")]
	public Span<FHMOHIBLLDK> MELEPNLNKIF()
	{
		return default(Span<FHMOHIBLLDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC930", Offset = "0x7DDAF30", VA = "0x187DDC930")]
	public Span<FHMOHIBLLDK> KFNFGKOAKOH()
	{
		return default(Span<FHMOHIBLLDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCC50", Offset = "0x7DDB250", VA = "0x187DDCC50")]
	public bool PFEAOMFGIPC(FHMOHIBLLDK JHDAOHEONAC, bool DJMMAMFFPAF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC400", Offset = "0x7DDAA00", VA = "0x187DDC400")]
	public bool CHGLENDAFLP(FHMOHIBLLDK GPLPPJLEDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC690", Offset = "0x7DDAC90", VA = "0x187DDC690")]
	public FHMOHIBLLDK HFDIPANCLMI(uint PMFBMKFDOMN)
	{
		return default(FHMOHIBLLDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCA30", Offset = "0x7DDB030", VA = "0x187DDCA30")]
	public DOHDBOLIGOB LAAANBKHMHN()
	{
		return default(DOHDBOLIGOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public DJLMBDFBDEJ(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9710", Offset = "0x7DD7D10", VA = "0x187DD9710")]
	public static bool OIFHDJNIHDL(DJLMBDFBDEJ OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC500", Offset = "0x7DDAB00", VA = "0x187DDC500", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(DJLMBDFBDEJ MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct HLBCBCAPFMK : IEquatable<HLBCBCAPFMK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public string HKGGJOPMJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3970", Offset = "0x7DE1F70", VA = "0x187DE3970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public string NANJFPGMFGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3A00", Offset = "0x7DE2000", VA = "0x187DE3A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public string ODPNAKIJEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3AB0", Offset = "0x7DE20B0", VA = "0x187DE3AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3820", Offset = "0x7DE1E20", VA = "0x187DE3820")]
	public bool DAMOENFDCPN([Out] string LDEELKBKKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public HLBCBCAPFMK(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7DE38E0", Offset = "0x7DE1EE0", VA = "0x187DE38E0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(HLBCBCAPFMK MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct JEMGPGCFPMK : IEquatable<JEMGPGCFPMK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private KDOJOMBFCFA NLFNLADEAGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4BF0", Offset = "0x7DE31F0", VA = "0x187DE4BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public JCGOJLOCOAC CGJECBOPALA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4430", Offset = "0x7DE2A30", VA = "0x187DE4430")]
		get
		{
			return default(JCGOJLOCOAC);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7DE49C0", Offset = "0x7DE2FC0", VA = "0x187DE49C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool GAOFDCBHFND
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4C50", Offset = "0x7DE3250", VA = "0x187DE4C50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5160", Offset = "0x7DE3760", VA = "0x187DE5160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public KOGLLFEDMCC<string> FDHEKMHKHBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4CE0", Offset = "0x7DE32E0", VA = "0x187DE4CE0")]
		get
		{
			return default(KOGLLFEDMCC<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5040", Offset = "0x7DE3640", VA = "0x187DE5040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public KOGLLFEDMCC<string> GKPGGDPHDFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4AD0", Offset = "0x7DE30D0", VA = "0x187DE4AD0")]
		get
		{
			return default(KOGLLFEDMCC<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4E00", Offset = "0x7DE3400", VA = "0x187DE4E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public KOGLLFEDMCC<string> KKCMDIIPPCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4780", Offset = "0x7DE2D80", VA = "0x187DE4780")]
		get
		{
			return default(KOGLLFEDMCC<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7DE48A0", Offset = "0x7DE2EA0", VA = "0x187DE48A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public KOGLLFEDMCC<string> OBJBMJOPGDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4F20", Offset = "0x7DE3520", VA = "0x187DE4F20")]
		get
		{
			return default(KOGLLFEDMCC<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7DE45D0", Offset = "0x7DE2BD0", VA = "0x187DE45D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7DD86A0", Offset = "0x7DD6CA0", VA = "0x187DD86A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4530", Offset = "0x7DE2B30", VA = "0x187DE4530")]
	public bool BPIICJIOBFH(PKENAFNLEAO EKEPPODJHCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public JEMGPGCFPMK(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
	public static PKENAFNLEAO OIFHDJNIHDL(JEMGPGCFPMK OHLIHBDBKCE)
	{
		return default(PKENAFNLEAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x7DE46F0", Offset = "0x7DE2CF0", VA = "0x187DE46F0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(JEMGPGCFPMK MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct NKGPCHFOEDM : IEquatable<NKGPCHFOEDM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB250", Offset = "0x7DE9850", VA = "0x187DEB250", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(NKGPCHFOEDM MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct ODBEPCGMLLE : IEquatable<ODBEPCGMLLE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB3E0", Offset = "0x7DE99E0", VA = "0x187DEB3E0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(ODBEPCGMLLE MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct NDOAGFPLDPK : IEquatable<NDOAGFPLDPK>
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly ComponentTypes KOPFLHHPBGG;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly NDOAGFPLDPK APCCKFBGCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Collider IKDKJNKIDHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7DEAAC0", Offset = "0x7DE90C0", VA = "0x187DEAAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public JKFPCOPLDFP EEHNGFOGCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA720", Offset = "0x7DE8D20", VA = "0x187DEA720")]
		get
		{
			return default(JKFPCOPLDFP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA2B0", Offset = "0x7DE88B0", VA = "0x187DEA2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public KCBFJLKHEKK DJBOOIHEOID
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7DEAA80", Offset = "0x7DE9080", VA = "0x187DEAA80")]
		get
		{
			return default(KCBFJLKHEKK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA6D0", Offset = "0x7DE8CD0", VA = "0x187DEA6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public NEKAFJNOKCP JEMLLKCJHAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA270", Offset = "0x7DE8870", VA = "0x187DEA270")]
		get
		{
			return default(NEKAFJNOKCP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA1A0", Offset = "0x7DE87A0", VA = "0x187DEA1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public float JJNAOEDIBGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA690", Offset = "0x7DE8C90", VA = "0x187DEA690")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA300", Offset = "0x7DE8900", VA = "0x187DEA300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool IFNEFCOEAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7DEAEB0", Offset = "0x7DE94B0", VA = "0x187DEAEB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA4C0", Offset = "0x7DE8AC0", VA = "0x187DEA4C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool EOJJDLHNLLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DEAF20", Offset = "0x7DE9520", VA = "0x187DEAF20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7DEAC10", Offset = "0x7DE9210", VA = "0x187DEAC10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool JMHCBJKEFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA7C0", Offset = "0x7DE8DC0", VA = "0x187DEA7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7DEACB0", Offset = "0x7DE92B0", VA = "0x187DEACB0")]
	public static bool NCIPPDPNNCP(FHMOHIBLLDK AOCIIHJNNPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7DEA840", Offset = "0x7DE8E40", VA = "0x187DEA840")]
	public static bool LEDEGLNAGAD(FHMOHIBLLDK AOCIIHJNNPK, [Out] NDOAGFPLDPK OPAPEEOJOND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7DEA350", Offset = "0x7DE8950", VA = "0x187DEA350")]
	public bool DPCANEGLNPL([Out] BOIHGIDCPDB LOEOJMJDAPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7DEA0B0", Offset = "0x7DE86B0", VA = "0x187DEA0B0")]
	public bool APCENGKGMDM([Out] PKENAFNLEAO KNNDNAPJIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7DEA760", Offset = "0x7DE8D60", VA = "0x187DEA760")]
	public bool JCLHFOJFNCL(HGKJLDPCHCO CPNOKLLGBPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7DEA1F0", Offset = "0x7DE87F0", VA = "0x187DEA1F0")]
	public void BPGIGHMDAIJ(HGKJLDPCHCO CPNOKLLGBPJ, bool MIHGKLOAIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7DEA5F0", Offset = "0x7DE8BF0", VA = "0x187DEA5F0")]
	public void FCIJCHOGAEA(HGKJLDPCHCO CPNOKLLGBPJ, bool MIHGKLOAIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public NDOAGFPLDPK(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7DEA560", Offset = "0x7DE8B60", VA = "0x187DEA560", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(NDOAGFPLDPK MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7DEAFA0", Offset = "0x7DE95A0", VA = "0x187DEAFA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct MKLBNEFOJLE : IEquatable<MKLBNEFOJLE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public bool BKDNDPHGAID
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8BE0", Offset = "0x7DE71E0", VA = "0x187DE8BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public MKLBNEFOJLE(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8C30", Offset = "0x7DE7230", VA = "0x187DE8C30", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(MKLBNEFOJLE MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct OPBOIHIBKPJ : IEquatable<OPBOIHIBKPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private DMHMIPOBNHA OJMKBAKEOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC0F0", Offset = "0x7DEA6F0", VA = "0x187DEC0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD86A0", Offset = "0x7DD6CA0", VA = "0x187DD86A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC1E0", Offset = "0x7DEA7E0", VA = "0x187DEC1E0")]
	public void FDFOAJBGNEM(bool PDFAMNMPAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public OPBOIHIBKPJ(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC150", Offset = "0x7DEA750", VA = "0x187DEC150", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(OPBOIHIBKPJ MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct PEJPDCJFEEE : IEquatable<PEJPDCJFEEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public bool AIICHOJLIJE
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC9F0", Offset = "0x7DEAFF0", VA = "0x187DEC9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public bool DEKIBPDEFHG
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x7DECCC0", Offset = "0x7DEB2C0", VA = "0x187DECCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool NDOJMAFGPHK
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC810", Offset = "0x7DEAE10", VA = "0x187DEC810")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x7DECFC0", Offset = "0x7DEB5C0", VA = "0x187DECFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public bool PPKPEIGODNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x7DECF70", Offset = "0x7DEB570", VA = "0x187DECF70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool HJIGJDIHDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x7DED270", Offset = "0x7DEB870", VA = "0x187DED270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool LBGPNMNHHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x7DECA30", Offset = "0x7DEB030", VA = "0x187DECA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool PBEDEICOIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x7DECC20", Offset = "0x7DEB220", VA = "0x187DECC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool AEDAMDCCHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x7DECFE0", Offset = "0x7DEB5E0", VA = "0x187DECFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool HMIAMBAMDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC860", Offset = "0x7DEAE60", VA = "0x187DEC860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool PNOHCBEHDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x7DED2C0", Offset = "0x7DEB8C0", VA = "0x187DED2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool APPFGBDMHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7DED160", Offset = "0x7DEB760", VA = "0x187DED160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool KJHEGMKBNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7DECD50", Offset = "0x7DEB350", VA = "0x187DECD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool HLHIMMMHDCN
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7DECDA0", Offset = "0x7DEB3A0", VA = "0x187DECDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool PCGEAJOBCHI
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7DED230", Offset = "0x7DEB830", VA = "0x187DED230")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7DED030", Offset = "0x7DEB630", VA = "0x187DED030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public GCBFKFHDHEE OFCJJFMCDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7DED120", Offset = "0x7DEB720", VA = "0x187DED120")]
		get
		{
			return default(GCBFKFHDHEE);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7DECC70", Offset = "0x7DEB270", VA = "0x187DECC70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool BIOODMLPHNH
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC6F0", Offset = "0x7DEACF0", VA = "0x187DEC6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public NAAMCHMIHPA FJKMJELLHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7DECB50", Offset = "0x7DEB150", VA = "0x187DECB50")]
		get
		{
			return default(NAAMCHMIHPA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7DECDF0", Offset = "0x7DEB3F0", VA = "0x187DECDF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public bool KCBAKDABJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC8B0", Offset = "0x7DEAEB0", VA = "0x187DEC8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 JFOAACLOOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x7DED1B0", Offset = "0x7DEB7B0", VA = "0x187DED1B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Vector3 OHBIGGFOFMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x7DECEF0", Offset = "0x7DEB4F0", VA = "0x187DECEF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool HNAOOMJBGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC8F0", Offset = "0x7DEAEF0", VA = "0x187DEC8F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7DD86A0", Offset = "0x7DD6CA0", VA = "0x187DD86A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7DECE90", Offset = "0x7DEB490", VA = "0x187DECE90")]
	public bool HMPMIPMOHEN(CMOADABFGJO CPNOKLLGBPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7DED090", Offset = "0x7DEB690", VA = "0x187DED090")]
	public void MJFPOKFFANJ(CMOADABFGJO CPNOKLLGBPJ, bool MIHGKLOAIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7DECA80", Offset = "0x7DEB080", VA = "0x187DECA80")]
	public bool DLFJBGFDLHD(FMJNGMHIFLD CPNOKLLGBPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7DECAD0", Offset = "0x7DEB0D0", VA = "0x187DECAD0")]
	public void ECCKKAJGKBF(FMJNGMHIFLD CPNOKLLGBPJ, bool MIHGKLOAIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7DECD10", Offset = "0x7DEB310", VA = "0x187DECD10")]
	public FMJNGMHIFLD FLILINLDKMP()
	{
		return default(FMJNGMHIFLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7DECE40", Offset = "0x7DEB440", VA = "0x187DECE40")]
	public bool HFEDIPIOKCH(FMJNGMHIFLD OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public PEJPDCJFEEE(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7DECB90", Offset = "0x7DEB190", VA = "0x187DECB90", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(PEJPDCJFEEE MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct NCAEICFPBFD : IEquatable<NCAEICFPBFD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private AOCGLAEEKHI LBBCGLDFBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x7DE9C00", Offset = "0x7DE8200", VA = "0x187DE9C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	private KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x7DD86A0", Offset = "0x7DD6CA0", VA = "0x187DD86A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7DE95C0", Offset = "0x7DE7BC0", VA = "0x187DE95C0")]
	public bool CNMDOGILOAL(AEGDAJEGAFP KOJNMKELJGK, List<FHMOHIBLLDK> NOMCIBPFMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7DE98B0", Offset = "0x7DE7EB0", VA = "0x187DE98B0")]
	public int HKNEJMHEFIH(AEGDAJEGAFP KOJNMKELJGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9380", Offset = "0x7DE7980", VA = "0x187DE9380")]
	public void CAFEDFEEJGC(List<FHMOHIBLLDK> NOMCIBPFMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9AD0", Offset = "0x7DE80D0", VA = "0x187DE9AD0")]
	public int KBEMGMDGBFE(FHMOHIBLLDK FCPOJLOEIEO, AEGDAJEGAFP KOJNMKELJGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9490", Offset = "0x7DE7A90", VA = "0x187DE9490")]
	public FHMOHIBLLDK CDNJEOJHBBA(int OHHMJGCBCKD, AEGDAJEGAFP KOJNMKELJGK)
	{
		return default(FHMOHIBLLDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9780", Offset = "0x7DE7D80", VA = "0x187DE9780")]
	public void FGPBCDFCPIC(FHMOHIBLLDK FCPOJLOEIEO, AEGDAJEGAFP KOJNMKELJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9C60", Offset = "0x7DE8260", VA = "0x187DE9C60")]
	public bool NPDEJNAOCHH(FHMOHIBLLDK FCPOJLOEIEO, AEGDAJEGAFP KOJNMKELJGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7DE99C0", Offset = "0x7DE7FC0", VA = "0x187DE99C0")]
	public void JBHFIILBJBH(AEGDAJEGAFP KOJNMKELJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9E20", Offset = "0x7DE8420", VA = "0x187DE9E20")]
	public bool PPMGKOMGMAD(FHMOHIBLLDK FCPOJLOEIEO, AEGDAJEGAFP KOJNMKELJGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9D10", Offset = "0x7DE8310", VA = "0x187DE9D10")]
	public bool PFNHGBODMBB(AEGDAJEGAFP KOJNMKELJGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public NCAEICFPBFD(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x7DE96F0", Offset = "0x7DE7CF0", VA = "0x187DE96F0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(NCAEICFPBFD MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct GGKIHAKCMMB : IEquatable<GGKIHAKCMMB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x7DD86A0", Offset = "0x7DD6CA0", VA = "0x187DD86A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1DC0", Offset = "0x7DE03C0", VA = "0x187DE1DC0")]
	public void GJDAKHHOFGC(bool OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1CA0", Offset = "0x7DE02A0", VA = "0x187DE1CA0")]
	public void ECCHJCNICDG(bool OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x387A6C0", Offset = "0x3878CC0", VA = "0x18387A6C0")]
	public T DIPLLKGCIIG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public GGKIHAKCMMB(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1D30", Offset = "0x7DE0330", VA = "0x187DE1D30", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(GGKIHAKCMMB MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct GKICDLHNCGI : IEquatable<GKICDLHNCGI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public bool ABOCOHOOLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1FB0", Offset = "0x7DE05B0", VA = "0x187DE1FB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x7DE20C0", Offset = "0x7DE06C0", VA = "0x187DE20C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool LAEELMEOIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1F30", Offset = "0x7DE0530", VA = "0x187DE1F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public int NPPFMPLHIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2080", Offset = "0x7DE0680", VA = "0x187DE2080")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x7DE1FF0", Offset = "0x7DE05F0", VA = "0x187DE1FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x7DD86A0", Offset = "0x7DD6CA0", VA = "0x187DD86A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public GKICDLHNCGI(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1EA0", Offset = "0x7DE04A0", VA = "0x187DE1EA0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(GKICDLHNCGI MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct ILILBMILDDD : IEquatable<ILILBMILDDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public int EPNOMPGFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x7DE41D0", Offset = "0x7DE27D0", VA = "0x187DE41D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4060", Offset = "0x7DE2660", VA = "0x187DE4060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public int JMNCLNBPHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x7DE40B0", Offset = "0x7DE26B0", VA = "0x187DE40B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x7DE40F0", Offset = "0x7DE26F0", VA = "0x187DE40F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public ILILBMILDDD(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4140", Offset = "0x7DE2740", VA = "0x187DE4140", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(ILILBMILDDD MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct GOAJGFMONCL : IEquatable<GOAJGFMONCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	private BKLGCLGIMOD FMOCMBBANLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2480", Offset = "0x7DE0A80", VA = "0x187DE2480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	private FIBHLFPAKOC EMAEMDKMDII
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x7DE26E0", Offset = "0x7DE0CE0", VA = "0x187DE26E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public bool BIFHJLCFICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2CF0", Offset = "0x7DE12F0", VA = "0x187DE2CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public bool GCOONPMHNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2EB0", Offset = "0x7DE14B0", VA = "0x187DE2EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool BFDANIPLPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2CC0", Offset = "0x7DE12C0", VA = "0x187DE2CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool IOMADFFLMPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7DE24E0", Offset = "0x7DE0AE0", VA = "0x187DE24E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool DNGJMOHHNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2A80", Offset = "0x7DE1080", VA = "0x187DE2A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool GPGFCGMINOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2740", Offset = "0x7DE0D40", VA = "0x187DE2740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool HNBOEPKBLCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7DE28E0", Offset = "0x7DE0EE0", VA = "0x187DE28E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool OKJHDEAFBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2B50", Offset = "0x7DE1150", VA = "0x187DE2B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool DBMBEHNCKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2D80", Offset = "0x7DE1380", VA = "0x187DE2D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	private KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7DD86A0", Offset = "0x7DD6CA0", VA = "0x187DD86A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2870", Offset = "0x7DE0E70", VA = "0x187DE2870")]
	public bool IBIDGFLPHAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7DE25B0", Offset = "0x7DE0BB0", VA = "0x187DE25B0")]
	public FHMOHIBLLDK BJCGBGFJFJF(FHMOHIBLLDK FCPOJLOEIEO)
	{
		return default(FHMOHIBLLDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2F50", Offset = "0x7DE1550", VA = "0x187DE2F50")]
	public PKENAFNLEAO PCMNODCMPEK()
	{
		return default(PKENAFNLEAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7DE27D0", Offset = "0x7DE0DD0", VA = "0x187DE27D0")]
	public bool HEKEDPLJEFK(PKENAFNLEAO HFDAONCMGAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2AB0", Offset = "0x7DE10B0", VA = "0x187DE2AB0")]
	public bool KCJEKMAKECM(PKENAFNLEAO GHKCFENMCIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7DE23D0", Offset = "0x7DE09D0", VA = "0x187DE23D0")]
	public bool AJPFCMAFLDL(PKENAFNLEAO FCPOJLOEIEO, [Out] PKENAFNLEAO HFDAONCMGAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public GOAJGFMONCL(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9710", Offset = "0x7DD7D10", VA = "0x187DD9710")]
	public static bool OIFHDJNIHDL(GOAJGFMONCL OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2650", Offset = "0x7DE0C50", VA = "0x187DE2650", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(GOAJGFMONCL MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct KBDIFHCKPFF : IEquatable<KBDIFHCKPFF>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly KBDIFHCKPFF APCCKFBGCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public DDDGCGEFBGF DDFIIFDAIAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7DE56D0", Offset = "0x7DE3CD0", VA = "0x187DE56D0")]
		get
		{
			return default(DDDGCGEFBGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public GBOINGGHPAL FIGDBNMNPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5570", Offset = "0x7DE3B70", VA = "0x187DE5570")]
		get
		{
			return default(GBOINGGHPAL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5680", Offset = "0x7DE3C80", VA = "0x187DE5680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public OFEGKJHLAID FNLBLGEDCDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5710", Offset = "0x7DE3D10", VA = "0x187DE5710")]
		get
		{
			return default(OFEGKJHLAID);
		}
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5820", Offset = "0x7DE3E20", VA = "0x187DE5820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public float CPCKKDECKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7DE54F0", Offset = "0x7DE3AF0", VA = "0x187DE54F0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7DE57D0", Offset = "0x7DE3DD0", VA = "0x187DE57D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public Vector3 FJGGLLEDHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5A10", Offset = "0x7DE4010", VA = "0x187DE5A10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5750", Offset = "0x7DE3D50", VA = "0x187DE5750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public float BLIHKAJLHIL
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7DE59C0", Offset = "0x7DE3FC0", VA = "0x187DE59C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public CMOLENMEPKL DDPGFAHMEKN
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5530", Offset = "0x7DE3B30", VA = "0x187DE5530")]
		get
		{
			return default(CMOLENMEPKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5870", Offset = "0x7DE3E70", VA = "0x187DE5870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public bool KBLOIDENJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5640", Offset = "0x7DE3C40", VA = "0x187DE5640")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7DE58C0", Offset = "0x7DE3EC0", VA = "0x187DE58C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public CPPKHLEDPPI IOFGLPCMIME
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(CPPKHLEDPPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public DJLMBDFBDEJ OFIGOOBGDCB
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(DJLMBDFBDEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x7DE5420", Offset = "0x7DE3A20", VA = "0x187DE5420")]
	public JJIBGPGOCLE COEIADNCLBE()
	{
		return default(JJIBGPGOCLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x7DE5920", Offset = "0x7DE3F20", VA = "0x187DE5920")]
	public FENODIDCBGH NKJPFJOLDGF()
	{
		return default(FENODIDCBGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x7DE5970", Offset = "0x7DE3F70", VA = "0x187DE5970")]
	private bool NOOCFAPGLID(CMOLENMEPKL CPNOKLLGBPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x7DE5470", Offset = "0x7DE3A70", VA = "0x187DE5470")]
	public void DAOMBENBNKB(CMOLENMEPKL CPNOKLLGBPJ, bool MIHGKLOAIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public KBDIFHCKPFF(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9710", Offset = "0x7DD7D10", VA = "0x187DD9710")]
	public static bool OIFHDJNIHDL(KBDIFHCKPFF OHLIHBDBKCE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0FE0", Offset = "0x7DDF5E0", VA = "0x187DE0FE0")]
	public static bool DIKHMNDIIDO(KBDIFHCKPFF FDJHCIBLFFB, KBDIFHCKPFF CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x7DE55B0", Offset = "0x7DE3BB0", VA = "0x187DE55B0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(KBDIFHCKPFF MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct JJIBGPGOCLE : IEquatable<JJIBGPGOCLE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public KBDIFHCKPFF PBBEPMMNECD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(KBDIFHCKPFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public JMKKFNHDEDM OAOAECOFCOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5200", Offset = "0x7DE3800", VA = "0x187DE5200")]
		get
		{
			return default(JMKKFNHDEDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public JJIBGPGOCLE(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9710", Offset = "0x7DD7D10", VA = "0x187DD9710")]
	public static bool OIFHDJNIHDL(JJIBGPGOCLE OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x7DE5240", Offset = "0x7DE3840", VA = "0x187DE5240", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(JJIBGPGOCLE MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DefaultMember("Item")]
public readonly struct FENODIDCBGH : IEquatable<FENODIDCBGH>
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly FENODIDCBGH APCCKFBGCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private MJHMJMMJCJL DJGALKENBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7DDF700", Offset = "0x7DDDD00", VA = "0x187DDF700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public KBDIFHCKPFF PBBEPMMNECD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(KBDIFHCKPFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public JCLGHPNFNJF BFADDAECBNM
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x7DDF320", Offset = "0x7DDD920", VA = "0x187DDF320")]
		get
		{
			return default(JCLGHPNFNJF);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7DDFA00", Offset = "0x7DDE000", VA = "0x187DDFA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public IEnumerable<LKMBOJBJICB> OOGPJFDIODL
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7DDF760", Offset = "0x7DDDD60", VA = "0x187DDF760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public LKMBOJBJICB OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x7DDF180", Offset = "0x7DDD780", VA = "0x187DDF180")]
		get
		{
			return default(LKMBOJBJICB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7DDF960", Offset = "0x7DDDF60", VA = "0x187DDF960")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public CPPKHLEDPPI IOFGLPCMIME
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(CPPKHLEDPPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	private KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7DD86A0", Offset = "0x7DD6CA0", VA = "0x187DD86A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF450", Offset = "0x7DDDA50", VA = "0x187DDF450")]
	public LKMBOJBJICB FMLNAEFDMPJ(float3? EPCLGOKLIPO, [Optional] quaternion? OOBEGCNALKF, [Optional] Vector3? HDLKNIPAJGK)
	{
		return default(LKMBOJBJICB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFB20", Offset = "0x7DDE120", VA = "0x187DDFB20")]
	public LKMBOJBJICB PAPPCCJNIHC(int OHHMJGCBCKD, float3? EPCLGOKLIPO, [Optional] quaternion? OOBEGCNALKF, [Optional] Vector3? HDLKNIPAJGK)
	{
		return default(LKMBOJBJICB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFD50", Offset = "0x7DDE350", VA = "0x187DDFD50")]
	public void PCPGCJBCFNA(int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF670", Offset = "0x7DDDC70", VA = "0x187DDF670")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public FENODIDCBGH(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9710", Offset = "0x7DD7D10", VA = "0x187DD9710")]
	public static bool OIFHDJNIHDL(FENODIDCBGH OHLIHBDBKCE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF9F0", Offset = "0x7DDDFF0", VA = "0x187DDF9F0")]
	public static bool MMJMCICIDNJ(FENODIDCBGH FDJHCIBLFFB, FENODIDCBGH CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF290", Offset = "0x7DDD890", VA = "0x187DDF290", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(FENODIDCBGH MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct LKMBOJBJICB : IEquatable<LKMBOJBJICB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public FENODIDCBGH KGCJNDOKALP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7DE7360", Offset = "0x7DE5960", VA = "0x187DE7360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public float3 HOKNMKCMKBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7DE71A0", Offset = "0x7DE57A0", VA = "0x187DE71A0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7DE7300", Offset = "0x7DE5900", VA = "0x187DE7300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public quaternion OIMDLFMMKJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7DE73E0", Offset = "0x7DE59E0", VA = "0x187DE73E0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7DE7100", Offset = "0x7DE5700", VA = "0x187DE7100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public float3 PHFBCBJEPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7DE7430", Offset = "0x7DE5A30", VA = "0x187DE7430")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7DE7200", Offset = "0x7DE5800", VA = "0x187DE7200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public ENANNCNMKEP JOMGBPGGHFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7DE7150", Offset = "0x7DE5750", VA = "0x187DE7150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7DE72F0", Offset = "0x7DE58F0", VA = "0x187DE72F0")]
	public void FJHDDCHLAOG(FENODIDCBGH OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public LKMBOJBJICB(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7260", Offset = "0x7DE5860", VA = "0x187DE7260", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(LKMBOJBJICB MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct EENOHCEIIBC : IEquatable<EENOHCEIIBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public bool NFAJAPANNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7DDDA40", Offset = "0x7DDC040", VA = "0x187DDDA40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public EENOHCEIIBC(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD9B0", Offset = "0x7DDBFB0", VA = "0x187DDD9B0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(EENOHCEIIBC MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct OKCIBHBFCOA : IEquatable<OKCIBHBFCOA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	private BGCCOPGGOCK MCFMABFOAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB6B0", Offset = "0x7DE9CB0", VA = "0x187DEB6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public bool DMCKEMGALDO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7DEBB20", Offset = "0x7DEA120", VA = "0x187DEBB20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7DEBC70", Offset = "0x7DEA270", VA = "0x187DEBC70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public bool JKDEDKONDBN
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC060", Offset = "0x7DEA660", VA = "0x187DEC060")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7DEBC10", Offset = "0x7DEA210", VA = "0x187DEBC10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public float IDBDDKOHBNN
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC0B0", Offset = "0x7DEA6B0", VA = "0x187DEC0B0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB510", Offset = "0x7DE9B10", VA = "0x187DEB510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public bool JPFLPHDHGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB710", Offset = "0x7DE9D10", VA = "0x187DEB710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	private KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7DD86A0", Offset = "0x7DD6CA0", VA = "0x187DD86A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7DEBB70", Offset = "0x7DEA170", VA = "0x187DEBB70")]
	public void HHBHPOHNBCE(int AMICCGMJHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB8E0", Offset = "0x7DE9EE0", VA = "0x187DEB8E0")]
	public bool EMNHLKCFHJC([Out] int AMICCGMJHBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x7DEBA80", Offset = "0x7DEA080", VA = "0x187DEBA80")]
	public void GBKIMJMNLFE(bool CDNLEFGHGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB890", Offset = "0x7DE9E90", VA = "0x187DEB890")]
	public bool EGCJPELOGKA(LLKIPCFLHEA CPNOKLLGBPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x7DEBE00", Offset = "0x7DEA400", VA = "0x187DEBE00")]
	public void LECHGAIAKDI(LLKIPCFLHEA CPNOKLLGBPJ, bool MIHGKLOAIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7DEBF10", Offset = "0x7DEA510", VA = "0x187DEBF10")]
	public void NDFFCALLMCN(float BDKPEDNHMEI, float POADOIPDEEP, float HMMFIOJHIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB560", Offset = "0x7DE9B60", VA = "0x187DEB560")]
	public void AOLBKGDCCGJ(float3 LCPNMBCGIMD, quaternion LKLFJGDAGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB760", Offset = "0x7DE9D60", VA = "0x187DEB760")]
	public bool DMOOECPCMAN([Out] float3 LCPNMBCGIMD, [Out] quaternion LKLFJGDAGOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7DEBCD0", Offset = "0x7DEA2D0", VA = "0x187DEBCD0")]
	public bool KNFNJAFAAPG([Out] float AILAINFALGO, [Out] float FNDFFHGMNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7DEBE80", Offset = "0x7DEA480", VA = "0x187DEBE80")]
	public void LNHDEBAABAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public OKCIBHBFCOA(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB9F0", Offset = "0x7DE9FF0", VA = "0x187DEB9F0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(OKCIBHBFCOA MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct CPPKHLEDPPI : IEquatable<CPPKHLEDPPI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	private JHOFBNJCHGN LMMOGMIEIHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAAF0", Offset = "0x7DD90F0", VA = "0x187DDAAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public Vector3 HOKNMKCMKBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAE30", Offset = "0x7DD9430", VA = "0x187DDAE30")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB3A0", Offset = "0x7DD99A0", VA = "0x187DDB3A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public Quaternion OIMDLFMMKJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7DDBDB0", Offset = "0x7DDA3B0", VA = "0x187DDBDB0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7DDA8E0", Offset = "0x7DD8EE0", VA = "0x187DDA8E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public Vector3 OAPICFGGNEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAD40", Offset = "0x7DD9340", VA = "0x187DDAD40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB920", Offset = "0x7DD9F20", VA = "0x187DDB920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public Quaternion MHHJHPJKLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x7DDBB40", Offset = "0x7DDA140", VA = "0x187DDBB40")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7DDA810", Offset = "0x7DD8E10", VA = "0x187DDA810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public float JLKGIJBFPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC270", Offset = "0x7DDA870", VA = "0x187DDC270")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7DDBA90", Offset = "0x7DDA090", VA = "0x187DDBA90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public float LAJMIGPLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAF20", Offset = "0x7DD9520", VA = "0x187DDAF20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public Matrix4x4 GHCKOOAHILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x7DDBD70", Offset = "0x7DDA370", VA = "0x187DDBD70")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public DJLMBDFBDEJ OFIGOOBGDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(DJLMBDFBDEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	private JFDGJOPOGFB PIJODJEEGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB510", Offset = "0x7DD9B10", VA = "0x187DDB510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB8D0", Offset = "0x7DD9ED0", VA = "0x187DDB8D0")]
	public CIPJGNAKHIH INEJIFMPCOL()
	{
		return default(CIPJGNAKHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB050", Offset = "0x7DD9650", VA = "0x187DDB050")]
	public void FCMACHIDOKO([Out] Matrix4x4 HFLBLHLDCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB630", Offset = "0x7DD9C30", VA = "0x187DDB630")]
	public void HOBDOAGMFGH([In] Vector3 IHMLAPGNLCC, [In] Quaternion JHMNNKLOODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB570", Offset = "0x7DD9B70", VA = "0x187DDB570")]
	public void HOBDOAGMFGH([In] RigidTransform MCIJHBGIMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB170", Offset = "0x7DD9770", VA = "0x187DDB170")]
	public void FKPBALNJKDH([Out] RigidTransform MCIJHBGIMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA710", Offset = "0x7DD8D10", VA = "0x187DDA710")]
	public void AMHNAFNCIOG([In] Vector3 MNCPLIOMLIO, [In] Quaternion BHNBHMFNEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA650", Offset = "0x7DD8C50", VA = "0x187DDA650")]
	public void AMHNAFNCIOG([In] RigidTransform LGKMMMDABOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x7DDAC60", Offset = "0x7DD9260", VA = "0x187DDAC60")]
	public void BKACFIPHJBK([Out] Vector3 MNCPLIOMLIO, [Out] Quaternion BHNBHMFNEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7DDABB0", Offset = "0x7DD91B0", VA = "0x187DDABB0")]
	public void BKACFIPHJBK([Out] RigidTransform MCIJHBGIMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC240", Offset = "0x7DDA840", VA = "0x187DDC240")]
	public UniformTRS NPPKIHPJPMD()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC180", Offset = "0x7DDA780", VA = "0x187DDC180")]
	public void NPPKIHPJPMD([Out] UniformTRS LGKMMMDABOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDBC80", Offset = "0x7DDA280", VA = "0x187DDBC80")]
	public UniformTRS LDNNPPNMGJK()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDBCB0", Offset = "0x7DDA2B0", VA = "0x187DDBCB0")]
	public void LDNNPPNMGJK([Out] UniformTRS MCIJHBGIMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC090", Offset = "0x7DDA690", VA = "0x187DDC090")]
	public Vector3 NKMKEDLPJIH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA580", Offset = "0x7DD8B80", VA = "0x187DDA580")]
	public void AGKGIONFDCG([In] Vector3 OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB7E0", Offset = "0x7DD9DE0", VA = "0x187DDB7E0")]
	public Vector3 IAKMOLDLBAC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x7DDBEF0", Offset = "0x7DDA4F0", VA = "0x187DDBEF0")]
	public void MLNIAKCDNOH([In] Vector3 OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA9B0", Offset = "0x7DD8FB0", VA = "0x187DDA9B0")]
	public Quaternion BFANIFNHBPL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB220", Offset = "0x7DD9820", VA = "0x187DDB220")]
	public void FNCDDIOOAJL([In] Quaternion OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA440", Offset = "0x7DD8A40", VA = "0x187DDA440")]
	public Quaternion AAGNGHLEPHI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x7DDBFC0", Offset = "0x7DDA5C0", VA = "0x187DDBFC0")]
	public void NBPCLNCAEJN([In] Quaternion OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB470", Offset = "0x7DD9A70", VA = "0x187DDB470")]
	public float HBDOJDJGBID()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB2F0", Offset = "0x7DD98F0", VA = "0x187DDB2F0")]
	public void GGGPFJBLGID(float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB9F0", Offset = "0x7DD9FF0", VA = "0x187DDB9F0")]
	public float IOKKLAHBPIJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB730", Offset = "0x7DD9D30", VA = "0x187DDB730")]
	public void HPGPKJFIMHD(float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public CPPKHLEDPPI(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDAFC0", Offset = "0x7DD95C0", VA = "0x187DDAFC0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(CPPKHLEDPPI MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct MEANPGBNIMN : IEquatable<MEANPGBNIMN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	private MOMONMFDFEH EHOCENAJCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x7DE86B0", Offset = "0x7DE6CB0", VA = "0x187DE86B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	private KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD86A0", Offset = "0x7DD6CA0", VA = "0x187DD86A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8710", Offset = "0x7DE6D10", VA = "0x187DE8710")]
	public void OGHBMEFHLAN(string ALDJJJCLNOI, CKOFFFONKMO GGBPNJIDLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public MEANPGBNIMN(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8620", Offset = "0x7DE6C20", VA = "0x187DE8620", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(MEANPGBNIMN MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct PEJCHKDCDAA : IEquatable<PEJCHKDCDAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x7DEC660", Offset = "0x7DEAC60", VA = "0x187DEC660", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(PEJCHKDCDAA MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8710", Offset = "0x7DD6D10", VA = "0x187DD8710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public readonly struct DNJHJBKCFMJ : IEquatable<DNJHJBKCFMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public KNIHOKEGCFA CNKBCGLMAIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD0A0", Offset = "0x7DDB6A0", VA = "0x187DDD0A0")]
		get
		{
			return default(KNIHOKEGCFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public DNJHJBKCFMJ(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD190", Offset = "0x7DDB790", VA = "0x187DDD190", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(DNJHJBKCFMJ MIJLJBIHDMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public readonly struct LGNNOIJKLDA : IEquatable<LGNNOIJKLDA>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct HOJIFPOHBBN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private PKENAFNLEAO GOGGPBKDKBC;

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3FC0", Offset = "0x7DE25C0", VA = "0x187DE3FC0")]
		public HOJIFPOHBBN(PKENAFNLEAO GOGGPBKDKBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3F30", Offset = "0x7DE2530", VA = "0x187DE3F30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7DE64E0", Offset = "0x7DE4AE0", VA = "0x187DE64E0")]
	public HOJIFPOHBBN EMNBOFGFIPB()
	{
		return default(HOJIFPOHBBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7DE66C0", Offset = "0x7DE4CC0", VA = "0x187DE66C0")]
	public INPKHPAKDGP IFIPOHELAJM(Allocator NDFENJBGNOB = Allocator.Temp)
	{
		return default(INPKHPAKDGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7DE67B0", Offset = "0x7DE4DB0", VA = "0x187DE67B0")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> LFLGFEPGCBG(Allocator NDFENJBGNOB = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7DE63B0", Offset = "0x7DE49B0", VA = "0x187DE63B0")]
	public NativeArray<JOKHKLAANOK> EIBBAPHHMBO(Allocator NDFENJBGNOB = Allocator.Temp)
	{
		return default(NativeArray<JOKHKLAANOK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6280", Offset = "0x7DE4880", VA = "0x187DE6280")]
	public NativeArray<JOKHKLAANOK> BEAEANJABHK(Allocator NDFENJBGNOB = Allocator.Temp)
	{
		return default(NativeArray<JOKHKLAANOK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6600", Offset = "0x7DE4C00", VA = "0x187DE6600")]
	public EPFJFEANHAG HKPALECCCOC(Allocator NDFENJBGNOB = Allocator.Temp)
	{
		return default(EPFJFEANHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7DE68E0", Offset = "0x7DE4EE0", VA = "0x187DE68E0")]
	public EPFJFEANHAG MCGDEAICJEE(Allocator NDFENJBGNOB = Allocator.Temp)
	{
		return default(EPFJFEANHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE69A0", Offset = "0x7DE4FA0", VA = "0x187DE69A0")]
	public EPFJFEANHAG NPGAJCMLCLG(Allocator NDFENJBGNOB = Allocator.Temp)
	{
		return default(EPFJFEANHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public LGNNOIJKLDA(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6570", Offset = "0x7DE4B70", VA = "0x187DE6570", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(LGNNOIJKLDA MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6100", Offset = "0x7DE4700", VA = "0x187DE6100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct CKIHILNNOFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int GGOFIHFFDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int FPPAPAOIDIG;
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct PNMPDOEFGAA : IEquatable<PNMPDOEFGAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public LGNNOIJKLDA EMLNLPOOMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(LGNNOIJKLDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public KJMPFONNKEE CIJAJIIDNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(KJMPFONNKEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public DNJHJBKCFMJ CGPMBOLPGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(DNJHJBKCFMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7DEDE70", Offset = "0x7DEC470", VA = "0x187DEDE70")]
	public bool NJLJFFBEMMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x7DEDC70", Offset = "0x7DEC270", VA = "0x187DEDC70")]
	public bool EEOFOEHBFGG([Out] Exception GGOAKKKDCJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public PNMPDOEFGAA(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
	public static PKENAFNLEAO OIFHDJNIHDL(PNMPDOEFGAA OHLIHBDBKCE)
	{
		return default(PKENAFNLEAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7DEDDE0", Offset = "0x7DEC3E0", VA = "0x187DEDDE0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(PNMPDOEFGAA MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6100", Offset = "0x7DE4700", VA = "0x187DE6100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public readonly struct PPLNLDGJMFG : IDisposable, IEquatable<PPLNLDGJMFG>
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public static readonly PPLNLDGJMFG APCCKFBGCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public PNMPDOEFGAA AAIHBKEDJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PNMPDOEFGAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public LGNNOIJKLDA EMLNLPOOMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(LGNNOIJKLDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7DEE130", Offset = "0x7DEC730", VA = "0x187DEE130")]
	public void EMBKIELNOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7DEE060", Offset = "0x7DEC660", VA = "0x187DEE060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public PPLNLDGJMFG(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x7DEE1B0", Offset = "0x7DEC7B0", VA = "0x187DEE1B0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "5")]
	public bool Equals(PPLNLDGJMFG MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7DEE240", Offset = "0x7DEC840", VA = "0x187DEE240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct KJMPFONNKEE : IEquatable<KJMPFONNKEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public bool PLLOJFMAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5FE0", Offset = "0x7DE45E0", VA = "0x187DE5FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	public KJMPFONNKEE(PKENAFNLEAO GOGGPBKDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8570", Offset = "0x7DD6B70", VA = "0x187DD8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6070", Offset = "0x7DE4670", VA = "0x187DE6070", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8460", Offset = "0x7DD6A60", VA = "0x187DD8460", Slot = "4")]
	public bool Equals(KJMPFONNKEE MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6100", Offset = "0x7DE4700", VA = "0x187DE6100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class INLMALJIFLM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private struct ELEDEJDBFBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Guid DGNNPFFMIEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public FCOGEDJDGMA HMFPKJADOHA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private struct FCOGEDJDGMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int OHLIHBDBKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int MCPGCAOOHIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int GMEEBNGOFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int BFBJCIPLFFD;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x7DDF0A0", Offset = "0x7DDD6A0", VA = "0x187DDF0A0")]
		public bool GEELJLDGOIB([Out] JOKHKLAANOK CEDMGFDCANL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x7DDF140", Offset = "0x7DDD740", VA = "0x187DDF140")]
		public FCOGEDJDGMA(JOKHKLAANOK CEDMGFDCANL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4230", Offset = "0x7DE2830", VA = "0x187DE4230")]
	public static Guid PFLLFAMNBMN(this JOKHKLAANOK CEDMGFDCANL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4210", Offset = "0x7DE2810", VA = "0x187DE4210")]
	public static bool JFPKCLLLJFM(this Guid DGNNPFFMIEE, [Out] JOKHKLAANOK CEDMGFDCANL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal static class DKCBKMNNOBI
{
	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCFB0", Offset = "0x7DDB5B0", VA = "0x187DDCFB0")]
	public static KJLADPJFBIO LBCCNKIBLED(this PKENAFNLEAO HJPLNJNIFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD040", Offset = "0x7DDB640", VA = "0x187DDD040")]
	public static DIDIFHNCLFN PPJOFODMHEJ(this PKENAFNLEAO HJPLNJNIFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCF20", Offset = "0x7DDB520", VA = "0x187DDCF20")]
	public static EntityManager EGDKMGEFJAC(this PKENAFNLEAO HJPLNJNIFLL)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x36BDCD0", Offset = "0x36BC2D0", VA = "0x1836BDCD0")]
	internal static bool LKDIKBBMHMH<T>(this PKENAFNLEAO HJPLNJNIFLL, bool MIHGKLOAIPI) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCE10", Offset = "0x7DDB410", VA = "0x187DDCE10")]
	public static bool ACOBHKEEFHI(this PKENAFNLEAO HJPLNJNIFLL, ANLDAMAMKAN LLPAKFGNDOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x36BD220", Offset = "0x36BB820", VA = "0x1836BD220")]
	public static bool GAGCPCMGOGP<T>(this PKENAFNLEAO HJPLNJNIFLL) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x36BDA40", Offset = "0x36BC040", VA = "0x1836BDA40")]
	public static bool HEBFBMGDHGF<T>(this PKENAFNLEAO HJPLNJNIFLL) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x36B8E20", Offset = "0x36B7420", VA = "0x1836B8E20")]
	[CDDEMIEPFBK]
	public static T COIFKINFOIL<T>(this PKENAFNLEAO HJPLNJNIFLL) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x36BA9A0", Offset = "0x36B8FA0", VA = "0x1836BA9A0")]
	[CDDEMIEPFBK]
	public static T EMAFGLJABIL<T>(this PKENAFNLEAO HJPLNJNIFLL) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x36BDAF0", Offset = "0x36BC0F0", VA = "0x1836BDAF0")]
	public static bool KCDJPHLJHPE<T>(this PKENAFNLEAO HJPLNJNIFLL, [Out] T OHLIHBDBKCE) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x36BDE90", Offset = "0x36BC490", VA = "0x1836BDE90")]
	public static T PFOOCKICOAO<T>(this PKENAFNLEAO HJPLNJNIFLL) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x36BDC30", Offset = "0x36BC230", VA = "0x1836BDC30")]
	public static T KHHCKHKNAAB<T>(this PKENAFNLEAO HJPLNJNIFLL) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal static class KNFGFLDHEGA
{
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[DefaultMember("Item")]
public struct INPKHPAKDGP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private EPFJFEANHAG KIDPOMGFMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> EPIKPEGAIGB;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x5B9FD10", Offset = "0x5B9E310", VA = "0x185B9FD10")]
	public INPKHPAKDGP(EPFJFEANHAG KIDPOMGFMKB, NativeArray<EntityRemapUtility.EntityRemapInfo> EPIKPEGAIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4390", Offset = "0x7DE2990", VA = "0x187DE4390")]
	public LocalId GHNOODGANAA(LocalId BOMDCGFKGKF)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4340", Offset = "0x7DE2940", VA = "0x187DE4340")]
	public LocalId GHNOODGANAA(int OHHMJGCBCKD)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x7DE42D0", Offset = "0x7DE28D0", VA = "0x187DE42D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GNKJBJGCEMB
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNEENKIHMFG(World JEOJCJGMOLH, NativeParallelHashSet<FixedString64Bytes> PLCHJPEBCCN);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ACFBKCGGNLM
{
	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHJMHCKECJL(PKENAFNLEAO FOCJCDLOOLD, [Out] uint HJPLNJNIFLL);

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GBGPONOIJJH(PKENAFNLEAO FOCJCDLOOLD, [Out] uint HJPLNJNIFLL);

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IGPKHBKGLAH(PKENAFNLEAO FOCJCDLOOLD, uint HJPLNJNIFLL);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HOFOEMEEILN(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string AHHNPJPDHHD(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ALBBAGEFKMH(PKENAFNLEAO FOCJCDLOOLD, string HJPLNJNIFLL);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OIAIGLOONMN
{
	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	Guid FGOMODEFFAG
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	Guid HLHHAHFDHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PJALKEFLPME(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PDMCPGFGCMP(FHMOHIBLLDK BOMDCGFKGKF);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid PPBADINLJJD(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BDFNOJEDOMC(PKENAFNLEAO GOGGPBKDKBC, Guid MIEKOPKCEML);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LIGMPAHFHFI(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task AJOMPAOHNPD(PKENAFNLEAO HMCFPGIFOED, PKENAFNLEAO JHDAOHEONAC);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EAIHMBALMJD(PKENAFNLEAO GOGGPBKDKBC, JOKHKLAANOK BJDODAFJOLK);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IIHOJFFOFHG
{
	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	Guid FGOMODEFFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFDJAMDCCHP(NativeList<Guid> ABPNPJLODEN, NativeList<Guid> HJGPIGMNBKJ, NativeList<FixedString64Bytes> DJNGDOFECCN);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PBMPONFKFKP
{
	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EPFJFEANHAG CLFAHBAKOFD(Allocator NDFENJBGNOB);

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EPFJFEANHAG FKLCBNCJLEP(Allocator NDFENJBGNOB);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MLMBPPKFMGL(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LAEELMEOIFK(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ABOCOHOOLGP(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JIGGIIAGCHB(PKENAFNLEAO FOCJCDLOOLD, int GIBLACJPDHG);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PKENAFNLEAO HIMHIJIJCGI(PKENAFNLEAO HAJFCDJDOIB);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EPOONKGMMNM(EPFJFEANHAG OMFFBFINKMM, bool JJFFJOMEODC);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CMKLHDPHOED(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CIJABOCJEGN(PKENAFNLEAO FOCJCDLOOLD, bool CAEICADEMHB);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int NHJNECPAEPO();

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MPFHHNOHKGB(PKENAFNLEAO GOGGPBKDKBC);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KLJACPCBIBJ
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<PKENAFNLEAO, PKENAFNLEAO> KGOCIDFOONL;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<PKENAFNLEAO, PKENAFNLEAO> GMKPBCMEFDE;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<PKENAFNLEAO, PKENAFNLEAO, PKENAFNLEAO> POPCBAGNKEM;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<PKENAFNLEAO> KIJPHNNGKOF;

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IBKFNGFMKLC(PKENAFNLEAO GOGGPBKDKBC, PKENAFNLEAO MFIFMINLAOI);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PKENAFNLEAO DMJOJCCBECI(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EPFJFEANHAG CELLOBKJNPK(PKENAFNLEAO GOGGPBKDKBC, Allocator NDFENJBGNOB);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PKENAFNLEAO CMIOAGKPFMF(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KOEEGHFIPHL(PKENAFNLEAO GOGGPBKDKBC, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EOOOLAKNNAP(PKENAFNLEAO GOGGPBKDKBC, float MJAHKCHDPBO);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool DOICOPFKJJF(PKENAFNLEAO GOGGPBKDKBC, [Out] PKENAFNLEAO JHDAOHEONAC);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool BGFCBLMKDOC(PKENAFNLEAO GOGGPBKDKBC, [Out] RigidTransform GJDMGPKGKGK);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 MBBHPPGFEMF(CGNFCMEGBON OAECINPEBBO);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion JKLKBDCBECE(CGNFCMEGBON OAECINPEBBO);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class MACDOELMMJP
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CCJNJBAAKAD
{
	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	object COLECDGBHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PDGCBJKMJFK
{
	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFCNOHHPLNE(PKENAFNLEAO BOMDCGFKGKF, BENOGLOIGDB FPNICFGNJFG);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMHJNABJPCE(BENOGLOIGDB FPNICFGNJFG);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BCKOJJIEHJO(PKENAFNLEAO GOGGPBKDKBC, [Out] BENOGLOIGDB GENLCGDHAFE);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[Flags]
public enum IIMEBOHMNIF
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	IncludeSelf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	IncludeChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	IncludeDescendants = 6,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	IncludeMask = 7,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Disembodied = 8,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Embodied = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	IgnoreEmbodiment = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	EmbodimentMask = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Runtime = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Authored = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	AuthoredAndRuntime = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	HierarchyMask = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	HintInputsAreDisjoint = 0x80
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public readonly struct PPEIGEKCNMP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly string NFHOBPDKIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly T JMMNJNFGHEP;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x563C570", Offset = "0x563AB70", VA = "0x18563C570")]
	public PPEIGEKCNMP(T JMMNJNFGHEP, [Optional][CallerMemberName] string NFHOBPDKIPM)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly PPEIGEKCNMP<int> ENDIGLOLHLG;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly PPEIGEKCNMP<int> GDOHPNIKHPF;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly PPEIGEKCNMP<int> PCPFMHFENPB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public enum PPOANPLCKLH
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class IOCFLDNMLCN
{
	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x1250E10", Offset = "0x124F410", VA = "0x181250E10")]
	public static bool LCEGOANCOFF(this PPOANPLCKLH IDAKFFICKHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x16218E0", Offset = "0x161FEE0", VA = "0x1816218E0")]
	public static bool NGMAKMKLKGB(this PPOANPLCKLH IDAKFFICKHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x2DD4FF0", Offset = "0x2DD35F0", VA = "0x182DD4FF0")]
	public static bool MKDDDONFICG(this PPOANPLCKLH IDAKFFICKHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x1250E20", Offset = "0x124F420", VA = "0x181250E20")]
	public static bool IGCJPHOABKK(this PPOANPLCKLH IDAKFFICKHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IPMMDEECEEK
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum OBBIGBJNPDK
	{
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public enum ICKPMAIPPEB
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	OBBIGBJNPDK GPOCLAPJNHC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	bool CBCMGBLGEMK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	bool JFILDILNBLA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	ICKPMAIPPEB OAOJJKBJKAM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[ServiceLifetime(Lifetime.Application)]
public interface BIKLLMMLFGM
{
	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	PPOANPLCKLH FCGHNNIELOP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	PPOANPLCKLH OKKBPPIELHH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	PPOANPLCKLH MFPJMENKIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	PPOANPLCKLH JDEFNGBGNOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	PPOANPLCKLH BMEBKGKAFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	PPOANPLCKLH NBDFABCACAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	PPOANPLCKLH JIBEAJCGBAK
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	PPOANPLCKLH CKGDPHFINKD
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	PPOANPLCKLH OAMFOCMDPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	PPOANPLCKLH EMKCPEDCHCF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	PPOANPLCKLH CKPOPMGJIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	PPOANPLCKLH IDJNBFEKCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	PPOANPLCKLH AIAGJHMMIGO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	PPOANPLCKLH ILBFCGAJHPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	PPOANPLCKLH OBLCAPHCPGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	PPOANPLCKLH KJDDJBBMEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	PPOANPLCKLH EGIBCLFAKDH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	PPOANPLCKLH CPJMLBHDJFB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	PPOANPLCKLH KPKJCJJFKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PHDCGNDDLGA(PPEIGEKCNMP<int> NFFGNPJGBOO);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MIJCBDFLLCM
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event DJCKMCMPEID.HKJAOCICHEG LKKEEJJEFKN;

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PKENAFNLEAO DJFHDAJFGEI(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EPFJFEANHAG NDIMPFGEAND(Allocator NDFENJBGNOB);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ENANNCNMKEP KNFPBCAFOMJ(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MKLKDEPLOOG(IEnumerable<PKENAFNLEAO> FJOJDLPCGDO);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ENANNCNMKEP FKBLGGCKKCA(PKENAFNLEAO JHDAOHEONAC, PKENAFNLEAO KIDPOMGFMKB, bool HCFHAKBJPJB, PKENAFNLEAO FCPOJLOEIEO);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PKENAFNLEAO AGDGBBECAOP(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PFEAOMFGIPC(PKENAFNLEAO GOGGPBKDKBC, PKENAFNLEAO JHDAOHEONAC, bool DJMMAMFFPAF = false);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool LBLMMLGLMFG(PKENAFNLEAO GOGGPBKDKBC, PKENAFNLEAO JHDAOHEONAC);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OFKOMJPDBJG(PKENAFNLEAO ILDCCOBMOHE, PKENAFNLEAO AGEIPMIEJFD);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	EPFJFEANHAG LAHKLOKICOK(PKENAFNLEAO DCOBGODCAEM);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IMNGANPMDBE(PKENAFNLEAO GOGGPBKDKBC, PKENAFNLEAO JOLJJNBCAPK);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EPFJFEANHAG BDODIJNEHCI(EPFJFEANHAG IFAAKOAPAMH, IIMEBOHMNIF EIBMLBPPJAJ, Allocator NDFENJBGNOB);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool CHGLENDAFLP(PKENAFNLEAO GOGGPBKDKBC, PKENAFNLEAO GPLPPJLEDDP);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PKENAFNLEAO KKHGGGPNOHO(PKENAFNLEAO FCPOJLOEIEO, PKENAFNLEAO IKOOFECKNCL);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool KAFJLPFDBLL(PKENAFNLEAO FCPOJLOEIEO, PKENAFNLEAO IKOOFECKNCL, [Out] PKENAFNLEAO PPBGJBBHIKG);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "17")]
	PKENAFNLEAO GINANMOOGAA(PKENAFNLEAO[] OMFFBFINKMM);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "18")]
	PKENAFNLEAO HFDIPANCLMI(PKENAFNLEAO GOGGPBKDKBC, uint PMFBMKFDOMN);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public static class HHFFIGDAILA
{
	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x7DE37B0", Offset = "0x7DE1DB0", VA = "0x187DE37B0")]
	public static bool MPKPPHOFPOF(this MIJCBDFLLCM EBBCJEKFBII, PKENAFNLEAO GOGGPBKDKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x7DE33E0", Offset = "0x7DE19E0", VA = "0x187DE33E0")]
	public static EPFJFEANHAG BDODIJNEHCI(this MIJCBDFLLCM BEGHPONNAEO, PKENAFNLEAO GOGGPBKDKBC, IIMEBOHMNIF EIBMLBPPJAJ, Allocator NDFENJBGNOB)
	{
		return default(EPFJFEANHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3670", Offset = "0x7DE1C70", VA = "0x187DE3670")]
	public static EPFJFEANHAG GMPMPDLAEDC(this MIJCBDFLLCM BEGHPONNAEO, PKENAFNLEAO GOGGPBKDKBC, Allocator NDFENJBGNOB)
	{
		return default(EPFJFEANHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3730", Offset = "0x7DE1D30", VA = "0x187DE3730")]
	public static EPFJFEANHAG KFNFGKOAKOH(this MIJCBDFLLCM BEGHPONNAEO, PKENAFNLEAO GOGGPBKDKBC, Allocator NDFENJBGNOB)
	{
		return default(EPFJFEANHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x7DE36B0", Offset = "0x7DE1CB0", VA = "0x187DE36B0")]
	public static EPFJFEANHAG IOOPECCBNKE(this MIJCBDFLLCM BEGHPONNAEO, PKENAFNLEAO GOGGPBKDKBC, Allocator NDFENJBGNOB)
	{
		return default(EPFJFEANHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3770", Offset = "0x7DE1D70", VA = "0x187DE3770")]
	public static EPFJFEANHAG MELEPNLNKIF(this MIJCBDFLLCM BEGHPONNAEO, PKENAFNLEAO GOGGPBKDKBC, Allocator NDFENJBGNOB)
	{
		return default(EPFJFEANHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x7DE36F0", Offset = "0x7DE1CF0", VA = "0x187DE36F0")]
	public static EPFJFEANHAG KDFJKLABAAA(this MIJCBDFLLCM BEGHPONNAEO, PKENAFNLEAO GOGGPBKDKBC, Allocator NDFENJBGNOB)
	{
		return default(EPFJFEANHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3280", Offset = "0x7DE1880", VA = "0x187DE3280")]
	public static EPFJFEANHAG ALGFMHJNMDJ(this MIJCBDFLLCM BEGHPONNAEO, PKENAFNLEAO GOGGPBKDKBC, Allocator NDFENJBGNOB)
	{
		return default(EPFJFEANHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x7DE32C0", Offset = "0x7DE18C0", VA = "0x187DE32C0")]
	public static EPFJFEANHAG ALGFMHJNMDJ(this MIJCBDFLLCM BEGHPONNAEO, EPFJFEANHAG GOGGPBKDKBC, Allocator NDFENJBGNOB)
	{
		return default(EPFJFEANHAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KDOJOMBFCFA
{
	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JCGOJLOCOAC INDLAHOEBFD(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DHDDEJGLJCM(PKENAFNLEAO FOCJCDLOOLD, JCGOJLOCOAC JMIAELOFDFB);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ENIALPBNAEH(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CABIGFLEEBC(PKENAFNLEAO FOCJCDLOOLD, bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KOGLLFEDMCC<string> GGJJMJEJGFK(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AFJAENFKFGK(PKENAFNLEAO FOCJCDLOOLD, KOGLLFEDMCC<string> MKHFKNEFINC);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KOGLLFEDMCC<string> LAMOAIJAOAK(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NMCGFMKJIPB(PKENAFNLEAO FOCJCDLOOLD, KOGLLFEDMCC<string> MKHFKNEFINC);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KOGLLFEDMCC<string> GCOIGMKONOA(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OPBAMEBMFPE(PKENAFNLEAO FOCJCDLOOLD, KOGLLFEDMCC<string> MKHFKNEFINC);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KOGLLFEDMCC<string> NEPDDOLFGJP(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PNDPEDPLKKO(PKENAFNLEAO FOCJCDLOOLD, KOGLLFEDMCC<string> MKHFKNEFINC);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BPIICJIOBFH(PKENAFNLEAO FOCJCDLOOLD, PKENAFNLEAO EKEPPODJHCN);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JAJMJMCBDCI
{
	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x7DE43D0", Offset = "0x7DE29D0", VA = "0x187DE43D0", Slot = "0")]
	Task<PNMPDOEFGAA> DHHHNNPGOBA(GMMJMMMKMBM EBOLOLBJOHE, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "1")]
	void CLOCLCACGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PLCKOGMOKKF
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event DJCKMCMPEID.HKJAOCICHEG LKKEEJJEFKN;

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PKENAFNLEAO AGDGBBECAOP(PKENAFNLEAO HMCFPGIFOED);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<PKENAFNLEAO> OBIJNBHBFON();

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<PKENAFNLEAO> FDJDJEGAIEJ(PKENAFNLEAO JHDAOHEONAC);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IIMHFJIMHOA(PKENAFNLEAO DINIDBCHECF, PKENAFNLEAO KHAPDHGPHDE, [Out] ENANNCNMKEP PLLDGDDNDJH);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DKHKMOOALFG(PKENAFNLEAO DINIDBCHECF, PKENAFNLEAO BJGPIFNNGLL, [Out] ENANNCNMKEP PLLDGDDNDJH);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PLDMGPFMCJH(PKENAFNLEAO DINIDBCHECF);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LBLMMLGLMFG(PKENAFNLEAO LIOPLHPGFBB, PKENAFNLEAO FAMAONKAFDI);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ENANNCNMKEP PNNDKCEJNJN(PKENAFNLEAO GOGGPBKDKBC);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IKIKHILFKDN
{
	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	bool EFJCEKIPLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	bool JPMKEOABLPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	bool AAHILHMGMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AAJNOLLDKHG
{
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IDFELIILEDI
{
	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCAGAJBPCNC(PKENAFNLEAO GOGGPBKDKBC, ANLDAMAMKAN LLPAKFGNDOB);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EKOPAOJCMMN(PKENAFNLEAO GOGGPBKDKBC, ANLDAMAMKAN LLPAKFGNDOB);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NLBMBIBOAOO
{
	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OKKELIMCIGO([In] float3 CKOFKNABLLG, [In] float3 IGEMMIGMOOK, float JPGIFEODCKP, [Out] MBPMEOINPFH MHBBDANNKDM, [Out] PKENAFNLEAO FKFPDEAIGAP);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int HONAGEDIJGA([In] float3 CKOFKNABLLG, float PIBKBDEFJIN, List<PKENAFNLEAO> OMFFBFINKMM);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BKOLOKMPDLC(Plane[] AAGNGNEIOEH, float3 CKOFKNABLLG, float3 LEJGDGMCMPG, quaternion OOBEGCNALKF, List<PKENAFNLEAO> OMFFBFINKMM);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HJGJIHFOFJC
{
	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OKKELIMCIGO([In] NativeArray<Entity> ANKLKPHHPBD, [In] float3 CKOFKNABLLG, [In] float3 IGEMMIGMOOK, [In] NativeArray<MBPMEOINPFH> FAAPCELEILM);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> HONAGEDIJGA([In] NativeArray<Entity> ANKLKPHHPBD, [In] float3 CKOFKNABLLG, float PIBKBDEFJIN);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> BKOLOKMPDLC([In] NativeArray<Entity> ANKLKPHHPBD, [In] NativeArray<float4> HAEPKHFNFHK);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct OFINNDLFBMB : PMKOIOKBFCO, IEquatable<OFINNDLFBMB>
{
	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public int CEBFMOBHAGD
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x12AC0B0", Offset = "0x12AA6B0", VA = "0x1812AC0B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public int IDOBOHLCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0910", Offset = "0x2DDEF10", VA = "0x182DE0910", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x6E50640", Offset = "0x6E4EC40", VA = "0x186E50640", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB470", Offset = "0x7DE9A70", VA = "0x187DEB470", Slot = "8")]
	public bool Equals(OFINNDLFBMB MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB4C0", Offset = "0x7DE9AC0", VA = "0x187DEB4C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct MBPMEOINPFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public float PHOKMKANBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public float3 HPAMHMBDLLL;
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BKPFMEKDIPK
{
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JFDGJOPOGFB
{
	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	MCIKHPLGCGG AINIPMHHIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<EPFJFEANHAG, NativeArray<RRObjectPrefabData>> AKOKDMLHMAO;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<EPFJFEANHAG> HCHBOJCJKPM;

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EPFJFEANHAG EFOKGNLELNI();

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GJNFILFOLKG PLMNACGNKNJ(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "8")]
	RRObjectPrefabData OJDBKJBPEIA(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LJMLMFBFOEG(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FHMOHIBLLDK OFGNPFAPJKI(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ELNDFGOAECP(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JGAILLIEEMI(PKENAFNLEAO GOGGPBKDKBC, [Out] Transform KOOMPFGMBLG);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	PKENAFNLEAO EIOCNHFCNCF(JOKHKLAANOK CEDMGFDCANL);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool MCKFEHLPLCP(JOKHKLAANOK CEDMGFDCANL, [Out] PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JOKHKLAANOK MFBOGNHADKK(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "16")]
	EPFJFEANHAG EIOCNHFCNCF(NativeArray<JOKHKLAANOK> CEDMGFDCANL, Allocator NDFENJBGNOB, bool HKGMNCGDAPL = true);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MBHFIGODOAI(RRObjectPrefabData BLHCDMNIPMC, NativeArray<Entity> ANKLKPHHPBD);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OOEPGLCONLO(NativeArray<JPEBIBFEEOG> PDMMGLGNPGE, NativeArray<JOKHKLAANOK> FDLMIFHKCBE, NativeArray<Entity> EPCJCNJCLDK);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "19")]
	FHMOHIBLLDK MHNKPDOPEGH();

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "20")]
	FHMOHIBLLDK MEMFJIEDBEK(RRObjectPrefabData BLHCDMNIPMC);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "21")]
	DOHDBOLIGOB DHKECOHFNEE();

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "22")]
	FENODIDCBGH HOOELCNKBCO();

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "23")]
	JJIBGPGOCLE OKNCLGEPLCG(JMKKFNHDEDM BJEAIIODINF);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BJDGAGALCGJ(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool AKFDKENFCCH(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	EPFJFEANHAG CDGCMOBJBOC(EPFJFEANHAG ELKGDMMAOOM, Allocator NDFENJBGNOB);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool NOMOJCGANNC(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool AAMGPMFECPH(PKENAFNLEAO GOGGPBKDKBC, ComponentTypes BIMMMOPIEEG);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	PKENAFNLEAO ICFLGCBFGIN(Transform KOOMPFGMBLG);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class EPIJNCENJFO
{
	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEFF0", Offset = "0x7DDD5F0", VA = "0x187DDEFF0")]
	internal static PKENAFNLEAO PIGBPOLDDCC(this Entity IOGPJKLGKKO, JFDGJOPOGFB GGBPNJIDLBN)
	{
		return default(PKENAFNLEAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEF70", Offset = "0x7DDD570", VA = "0x187DDEF70")]
	public static FHMOHIBLLDK JJGGDOGLJBC(this JFDGJOPOGFB GGBPNJIDLBN, LocalId GOGGPBKDKBC)
	{
		return default(FHMOHIBLLDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEB40", Offset = "0x7DDD140", VA = "0x187DDEB40")]
	public static PKENAFNLEAO EIOCNHFCNCF(this JFDGJOPOGFB GGBPNJIDLBN, LocalId GOGGPBKDKBC)
	{
		return default(PKENAFNLEAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEF80", Offset = "0x7DDD580", VA = "0x187DDEF80")]
	public static JOKHKLAANOK MFBOGNHADKK(this JFDGJOPOGFB GGBPNJIDLBN, LocalId GOGGPBKDKBC)
	{
		return default(JOKHKLAANOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEBF0", Offset = "0x7DDD1F0", VA = "0x187DDEBF0")]
	public static DOHDBOLIGOB FAGBBFIIEBE(this JFDGJOPOGFB GGBPNJIDLBN, RigidTransform LGKMMMDABOH)
	{
		return default(DOHDBOLIGOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEDC0", Offset = "0x7DDD3C0", VA = "0x187DDEDC0")]
	public static JJIBGPGOCLE INNMAFPFAEI(this JFDGJOPOGFB GGBPNJIDLBN, JMKKFNHDEDM ILGFPCICEOM, RigidTransform LGKMMMDABOH)
	{
		return default(JJIBGPGOCLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE9A0", Offset = "0x7DDCFA0", VA = "0x187DDE9A0")]
	public static FENODIDCBGH DJLNDMEENNM(this JFDGJOPOGFB GGBPNJIDLBN, RigidTransform LGKMMMDABOH)
	{
		return default(FENODIDCBGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x7DDED90", Offset = "0x7DDD390", VA = "0x187DDED90")]
	private static void HFDIHICGFKA(FHMOHIBLLDK AOCIIHJNNPK, RigidTransform LGKMMMDABOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal interface LCLJIJBIDAD
{
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BKLGCLGIMOD
{
	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	bool OBAKPLLBOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	PKENAFNLEAO OBCOPNBLJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	FHMOHIBLLDK PNFMJAKPMDA
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event ACFNPBLIFAO KAAPBEDINFG;

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PKENAFNLEAO KKHGGGPNOHO(PKENAFNLEAO FCPOJLOEIEO, PKENAFNLEAO IKOOFECKNCL);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KAFJLPFDBLL(PKENAFNLEAO FCPOJLOEIEO, PKENAFNLEAO IKOOFECKNCL, [Out] PKENAFNLEAO PPBGJBBHIKG);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IIEFNAMFPNF();

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JLCLOMGGIBJ();

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BIFHJLCFICD(PKENAFNLEAO FCPOJLOEIEO);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GPGFCGMINOJ(PKENAFNLEAO FCPOJLOEIEO);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public delegate void ACFNPBLIFAO(FHMOHIBLLDK MLGPHEAAGIA, FHMOHIBLLDK ANJJMPJOBIH);
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class MFAIJOODDMD
{
	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8930", Offset = "0x7DE6F30", VA = "0x187DE8930")]
	public static bool FEDJHLENOCL(this BKLGCLGIMOD IMMCNGPOMNH, FHMOHIBLLDK FCPOJLOEIEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8850", Offset = "0x7DE6E50", VA = "0x187DE8850")]
	public static bool EFCIHFKPNID(this BKLGCLGIMOD IMMCNGPOMNH, PKENAFNLEAO FCPOJLOEIEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x7DE8980", Offset = "0x7DE6F80", VA = "0x187DE8980")]
	public static bool IOMADFFLMPI(this BKLGCLGIMOD IMMCNGPOMNH, PKENAFNLEAO FCPOJLOEIEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IDDFCADBHKL
{
	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIHAACLLAHD(NativeList<RRObjectPrefabData> JMNHNJLAABL);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AOCGLAEEKHI
{
	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNMDOGILOAL(FHMOHIBLLDK AOCIIHJNNPK, AEGDAJEGAFP KOJNMKELJGK, List<FHMOHIBLLDK> NOMCIBPFMGJ);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int HKNEJMHEFIH(FHMOHIBLLDK AOCIIHJNNPK, AEGDAJEGAFP KOJNMKELJGK);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CAFEDFEEJGC(FHMOHIBLLDK AOCIIHJNNPK, List<FHMOHIBLLDK> NOMCIBPFMGJ);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KBEMGMDGBFE(FHMOHIBLLDK AMICCGMJHBK, FHMOHIBLLDK FCPOJLOEIEO, AEGDAJEGAFP KOJNMKELJGK);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FHMOHIBLLDK CDNJEOJHBBA(FHMOHIBLLDK AMICCGMJHBK, int OHHMJGCBCKD, AEGDAJEGAFP KOJNMKELJGK);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGPBCDFCPIC(FHMOHIBLLDK AMICCGMJHBK, FHMOHIBLLDK FCPOJLOEIEO, AEGDAJEGAFP KOJNMKELJGK);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NPDEJNAOCHH(FHMOHIBLLDK AMICCGMJHBK, FHMOHIBLLDK FCPOJLOEIEO, AEGDAJEGAFP KOJNMKELJGK);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JBHFIILBJBH(FHMOHIBLLDK AMICCGMJHBK, AEGDAJEGAFP KOJNMKELJGK);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PPMGKOMGMAD(FHMOHIBLLDK AMICCGMJHBK, FHMOHIBLLDK FCPOJLOEIEO, AEGDAJEGAFP KOJNMKELJGK);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KNHMENIDONE(Entity AMICCGMJHBK, Entity FCPOJLOEIEO, AEGDAJEGAFP KOJNMKELJGK);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BHFGFPPIKPE(Entity AMICCGMJHBK, AEGDAJEGAFP KOJNMKELJGK);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool PFNHGBODMBB(FHMOHIBLLDK FCPOJLOEIEO, AEGDAJEGAFP KOJNMKELJGK);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KKFMEKIBEHB
{
	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	DNJHJBKCFMJ CBFLIBFADGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KNIHOKEGCFA JFPLOFJCODF(DNJHJBKCFMJ CHJMGPBPDEK);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DNJHJBKCFMJ FBBBNDNOEOK();

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DNJHJBKCFMJ MLKPPAMGCPO();
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FIBHLFPAKOC
{
	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEKEDPLJEFK(PKENAFNLEAO FCPOJLOEIEO, PKENAFNLEAO HFDAONCMGAF);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KCJEKMAKECM(PKENAFNLEAO FCPOJLOEIEO, PKENAFNLEAO GHKCFENMCIO);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AJPFCMAFLDL(PKENAFNLEAO FCPOJLOEIEO, [Out] PKENAFNLEAO AENGBFKKPNL);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FMMMFNOHJJM
{
	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJDAKHHOFGC(PKENAFNLEAO DCOBGODCAEM, bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECCHJCNICDG(PKENAFNLEAO DCOBGODCAEM, bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMFBKKGKICH(PKENAFNLEAO DCOBGODCAEM, int OHLIHBDBKCE);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MJHMJMMJCJL
{
	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<PKENAFNLEAO> ONHLOPHNDNO(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PKENAFNLEAO FBAEHNAIFDI(PKENAFNLEAO GOGGPBKDKBC, int OHHMJGCBCKD);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int NIHANKOGBKN(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JCLGHPNFNJF KBKPECJBBBK(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PENAFPBMLEA(PKENAFNLEAO GOGGPBKDKBC, JCLGHPNFNJF PMLCGCAHNGK);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PKENAFNLEAO FDHGNKFIDGE(PKENAFNLEAO GOGGPBKDKBC, [Optional] float3? EPCLGOKLIPO, [Optional] quaternion? OOBEGCNALKF, [Optional] float3? HDLKNIPAJGK);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PKENAFNLEAO BCDLFGGKNFD(PKENAFNLEAO GOGGPBKDKBC, int OHHMJGCBCKD, [Optional] float3? EPCLGOKLIPO, [Optional] quaternion? OOBEGCNALKF, [Optional] float3? HDLKNIPAJGK);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NBBLLKDLNCH(PKENAFNLEAO GOGGPBKDKBC, int OHHMJGCBCKD);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KJACINJKCOK(PKENAFNLEAO GOGGPBKDKBC);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DDIIGHPJKLO
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BIJELNGKGKC
{
	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	bool KHMPCLMOIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPPLCBFIBJL();

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODHMJDANHEC();

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AIELAHDHKCM();

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBJNBMMLCGI();

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BFNANBEMFDN();

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GFBLGPGFGFC();

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DOMEOECCBPB();

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PHOAOKAKPJN();

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OHLMBBCMMOJ();

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BLFKNFKFFIN();

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ANFEGONHJBM();

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FILHMJFEFMM();
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BGCCOPGGOCK
{
	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EMNHLKCFHJC(PKENAFNLEAO FCPOJLOEIEO, [Out] int AMICCGMJHBK);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHBHPOHNBCE(PKENAFNLEAO FCPOJLOEIEO, int AMICCGMJHBK);

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBKIMJMNLFE(PKENAFNLEAO FCPOJLOEIEO, bool CDNLEFGHGIF);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NDFFCALLMCN(PKENAFNLEAO FCPOJLOEIEO, float BDKPEDNHMEI, float POADOIPDEEP, float HMMFIOJHIJL);

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KNFNJAFAAPG(PKENAFNLEAO GOGGPBKDKBC, [Out] float POADOIPDEEP, [Out] float HMMFIOJHIJL);

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AOLBKGDCCGJ(PKENAFNLEAO FCPOJLOEIEO, float3 EPCLGOKLIPO, quaternion OOBEGCNALKF);

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DMOOECPCMAN(PKENAFNLEAO FCPOJLOEIEO, [Out] float3 EPCLGOKLIPO, [Out] quaternion OOBEGCNALKF);

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LNHDEBAABAN(PKENAFNLEAO FCPOJLOEIEO);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JHOFBNJCHGN
{
	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGKGIONFDCG(Entity IOGPJKLGKKO, [In] float3 OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 NKMKEDLPJIH(Entity IOGPJKLGKKO);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNCDDIOOAJL(Entity IOGPJKLGKKO, [In] quaternion OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion BFANIFNHBPL(Entity IOGPJKLGKKO);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HOBDOAGMFGH(Entity IOGPJKLGKKO, [In] float3 EPCLGOKLIPO, [In] quaternion OOBEGCNALKF);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FKPBALNJKDH(Entity IOGPJKLGKKO, [Out] RigidTransform ICKENEFAALA);

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AMHNAFNCIOG(Entity IOGPJKLGKKO, [In] float3 EPCLGOKLIPO, [In] quaternion OOBEGCNALKF);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BKACFIPHJBK(Entity IOGPJKLGKKO, [Out] float3 EPCLGOKLIPO, [Out] quaternion OOBEGCNALKF);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BKACFIPHJBK(Entity IOGPJKLGKKO, [Out] RigidTransform ICKENEFAALA);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GGGPFJBLGID(Entity IOGPJKLGKKO, float OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float HBDOJDJGBID(Entity IOGPJKLGKKO);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MLNIAKCDNOH(Entity IOGPJKLGKKO, [In] float3 OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 IAKMOLDLBAC(Entity IOGPJKLGKKO);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NBPCLNCAEJN(Entity IOGPJKLGKKO, [In] quaternion OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion AAGNGHLEPHI(Entity IOGPJKLGKKO);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HPGPKJFIMHD(Entity IOGPJKLGKKO, float OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float IOKKLAHBPIJ(Entity IOGPJKLGKKO);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MDGMIMHPBOO(Entity IOGPJKLGKKO, [Out] float4x4 HFLBLHLDCPA);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MBNBOKBMCCH(Entity IOGPJKLGKKO, [In] float4x4 HFLBLHLDCPA);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IEKKLHEDJCB(Entity IOGPJKLGKKO);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NNBELJEEDHE(Entity IOGPJKLGKKO, Entity FKDPBFFLHKA, Entity FAMAONKAFDI);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class LHBPJDKFAHC
{
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EEJGJECIGEM
{
	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEAEMKHHCAL(bool MLHEEDKLBBC);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MOMONMFDFEH
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFJMMHFFAAN(PKENAFNLEAO FOCJCDLOOLD, KOGLLFEDMCC<string> MKHFKNEFINC);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEIFLAEHNGJ(PKENAFNLEAO FOCJCDLOOLD, KOGLLFEDMCC<string> MKHFKNEFINC);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IPFJBGGEILN(PKENAFNLEAO FOCJCDLOOLD, KOGLLFEDMCC<string> MKHFKNEFINC);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FCNFMLIPLEC(PKENAFNLEAO FOCJCDLOOLD, KOGLLFEDMCC<string> MKHFKNEFINC);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NEMGHAFINGP(PKENAFNLEAO FOCJCDLOOLD, KOGLLFEDMCC<string> MKHFKNEFINC);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFMMAELCMBA(PKENAFNLEAO FOCJCDLOOLD, KOGLLFEDMCC<string> MKHFKNEFINC);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int EGNJLHKHKCF(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int CAKACNBILEG(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int ANEMMGFLCIM(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEALDBHBOML<string> IMOFFBPAFGE(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool DKCJDFCDCHC(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEALDBHBOML<string> ILCECNOACDM(PKENAFNLEAO FOCJCDLOOLD);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GIBBNIMDDHM(PKENAFNLEAO FOCJCDLOOLD, string ALDJJJCLNOI);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GPAKNCJNPAL(string ALDJJJCLNOI, CKOFFFONKMO BAGMIJJFCLB);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PKENAFNLEAO DFEMKGNMHGC(string ALDJJJCLNOI);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EFCEOGNACLB(string ALDJJJCLNOI, CKOFFFONKMO BAGMIJJFCLB);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OGHBMEFHLAN(PKENAFNLEAO EOCHCIIJNGB, string ALDJJJCLNOI, CKOFFFONKMO BAGMIJJFCLB);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class DELIOCOOHOM
{
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GOGAIHELJPH
{
	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World KHAEPCEGGDA(string PILHIKEALKA = "Main");

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World BKBGLPOOBED(string PILHIKEALKA = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World DKBKIPDBGPL(string PILHIKEALKA = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World AFMHLAHBONM(string PILHIKEALKA = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DIDIFHNCLFN
{
	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	World JAHOOCJCAOC
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	World HEPOHAFGINL
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	EntityManager EGDKMGEFJAC
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	bool DINPHDIMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase PIPPPPLPPKB(Type MLCOGCMJLBB);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public static class CHJFBKBGPOJ
{
	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x7DD97C0", Offset = "0x7DD7DC0", VA = "0x187DD97C0")]
	public static ComponentSystemBase IPBIPFDNIOF(this World JEOJCJGMOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x36545A0", Offset = "0x3652BA0", VA = "0x1836545A0")]
	public static T PIPPPPLPPKB<T>(this DIDIFHNCLFN GICACMDJPJD) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HNPFGOEFHMJ
{
	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFNBMFPBGBD(NativeListAsync<Entity> JICPIFHADJH);

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OEPKECJGAPF(HELBNGOMAOP PCOFDBKGPAD);

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LHEPFMMDBMH(NativeListAsync<Entity> LPFEDJNAPBE, bool HFPBIAGEELK);

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PFJHOMODMPO();

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MLKPPFNBGKH(Entity KNNDNAPJIDP);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IPEFIGEONOD
{
	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GHNIMPCCPGD(Collider LOEOJMJDAPL, [Out] IFBFDABBFAD GKEDPOAOPAP);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PHKFLJLJBDP
{
	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider IBKFCGGJOEB(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject HBAJADFPPBJ(PKENAFNLEAO DKBHGAPAAMJ, GameObject OMOOALIODHP, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMJCFHLMFHB(GameObject LOEOJMJDAPL);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider HCDEJFGBEID<TCollider>(GameObject PFDOAGKAEGB) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BLDDFCGEPBP(Collider LOEOJMJDAPL);

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject PIDHFGPBOFN<TCollider>(string NFHOBPDKIPM) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BOIHGIDCPDB ANENOLOJPDP(PKENAFNLEAO MFFMHCNOLEP, PKENAFNLEAO PJFKCMMJALA, JMKKFNHDEDM BHAMLBCMCDF, float3 NNFGFFAJPOM, quaternion CEMMEEIEFOD, float3 IPGOJHIDCAE);

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DPCANEGLNPL(PKENAFNLEAO GOGGPBKDKBC, [Out] BOIHGIDCPDB LOEOJMJDAPL);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PPHJHJKDFKO(PKENAFNLEAO GOGGPBKDKBC, [Out] PKENAFNLEAO KNNDNAPJIDP);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public enum IICGDHHEMLN
{
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HDMAKFGCIBL
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public struct EPLGECLAPIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int BHAMLBCMCDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public GameObject OMOOALIODHP;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOLLHCHFAPM(PKENAFNLEAO GOGGPBKDKBC, JKFPCOPLDFP IPMHHJEICOK, bool FCMEGOBJICF, HGKJLDPCHCO AOIIGGIAJIN);

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJDMLJAHMNE(PKENAFNLEAO GOGGPBKDKBC, JKFPCOPLDFP IPMHHJEICOK, bool FCMEGOBJICF, bool GEALLBNAINJ, bool NIJINDJOBDK);

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DPMBPIGHIIN PKDKKJHIOCH(PKENAFNLEAO KNNDNAPJIDP, List<PKENAFNLEAO> AKIDFFMEDMP);

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BOIHGIDCPDB JCMMBOFDGIO(GameObject CJHLJJJLBGM, GameObject BKCKIGOLPJG);

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HLFGKKAJFFB(GameObject CJHLJJJLBGM, List<GameObject> HJFHNHBGMJC);

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LIILIOCOCDM(GameObject BKCKIGOLPJG);

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T HCDEJFGBEID<T>(GameObject PFDOAGKAEGB) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BLDDFCGEPBP(Collider LOEOJMJDAPL);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject AEKJFBGMNOF<T>(string NFHOBPDKIPM) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KEHIMAAMJAK(Collider LOEOJMJDAPL, [Out] PKENAFNLEAO AMICCGMJHBK);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KIJDKNOEEGC(PKENAFNLEAO GOGGPBKDKBC, [Out] IFBFDABBFAD GKEDPOAOPAP);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<IICGDHHEMLN> GBIFEGBAOIK(Allocator NDFENJBGNOB = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] PBKIDLMPAFK();
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LKFCPOJLLGG
{
	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHHBOOEOKAN(PKENAFNLEAO GOGGPBKDKBC, PKENAFNLEAO OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPCCIBAAOGI(PKENAFNLEAO GOGGPBKDKBC, PKENAFNLEAO OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GPAKPBJMGDK(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PKENAFNLEAO PFAEDCJHGFC(PKENAFNLEAO GOGGPBKDKBC, int OHHMJGCBCKD);

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EPFJFEANHAG GEINNOFBHGB(PKENAFNLEAO GOGGPBKDKBC, Allocator NDFENJBGNOB = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IMDJPIDFFPF(PKENAFNLEAO GOGGPBKDKBC, object EJJDDFFADPC, PKENAFNLEAO OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CBGLAHPCLDN(PKENAFNLEAO GOGGPBKDKBC, object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BLILKINCFFJ(PKENAFNLEAO GOGGPBKDKBC, [Out] PKENAFNLEAO OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NJFDIIFPODD(PKENAFNLEAO GOGGPBKDKBC, float3 OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GDMJOPCHIHI(PKENAFNLEAO GOGGPBKDKBC, [Out] float3 OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EEOCNGHCKKF(PKENAFNLEAO GOGGPBKDKBC, float3 OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CKFKOKBBGPO(PKENAFNLEAO GOGGPBKDKBC, [Out] float3 OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DDDACGGBLDF(PKENAFNLEAO GOGGPBKDKBC, (Quaternion rot, Vector3 moments) CKBACCDPBIH);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool FKKPEENBBPL(PKENAFNLEAO GOGGPBKDKBC, [Out] quaternion BNLJKPCLJFI, [Out] float3 AEOOBBJONAI);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HDOPDNIOJHB(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 DIKFDMKAAMB(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 DJFPMDJGCMJ(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HCIEGAAMJNN(PKENAFNLEAO GOGGPBKDKBC, float3 OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GOKJLGOINEA(PKENAFNLEAO GOGGPBKDKBC, float3 OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float NLAFKBHGJBB(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float EFKHAAEONKB(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HOMPCMLLJDF(PKENAFNLEAO GOGGPBKDKBC, float OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IHPOBMGJIMF(PKENAFNLEAO GOGGPBKDKBC, float OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode HBIMBJLGENC(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ACHKNAJNFIB(PKENAFNLEAO GOGGPBKDKBC, CollisionDetectionMode OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "25")]
	DINEBAHNNBA DGJFAAACNLL(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void BOFMMCHLHPB(PKENAFNLEAO GOGGPBKDKBC, DINEBAHNNBA OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool FDHHGAHFGDD(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IBEHHCJPBAI(PKENAFNLEAO GOGGPBKDKBC, bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "29")]
	PKENAFNLEAO DJFHDAJFGEI(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void EHJEFHIILKG(PKENAFNLEAO GOGGPBKDKBC, PKENAFNLEAO OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "31")]
	PKENAFNLEAO AGDGBBECAOP(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void PFEAOMFGIPC(PKENAFNLEAO GOGGPBKDKBC, PKENAFNLEAO OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "33")]
	KDGIOFPALDJ EGEBLMEKGOK(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void BGJMMJALAIE(PKENAFNLEAO GOGGPBKDKBC, KDGIOFPALDJ KAHHOMCKKDN);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool JLILPAMJCFH(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void NAPAMGJOODF(PKENAFNLEAO GOGGPBKDKBC, bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool CNJIHDOHMJF(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void OKPDJANEGNM(PKENAFNLEAO GOGGPBKDKBC, bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints GEFHKAPFDAC(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void ICNOAHHPLFA(PKENAFNLEAO GOGGPBKDKBC, RigidbodyConstraints OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float KMLEJIHNBAM(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void NNKKKCNPCPP(PKENAFNLEAO GOGGPBKDKBC, float OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float FNKEAAAEODJ(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void OPHJKAIDBJG(PKENAFNLEAO GOGGPBKDKBC, float OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool EKLLPLKGJCF(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void BOFONDIIBFI(PKENAFNLEAO GOGGPBKDKBC, bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool CIHNGEEEAGK(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void HIIMGHECALN(PKENAFNLEAO GOGGPBKDKBC, bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void OLOMMFPGIOI(PKENAFNLEAO GOGGPBKDKBC, int OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "50")]
	FGHLALPKLCB JBLJFMDCHEM(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void IGPKDOJJJBA(PKENAFNLEAO GOGGPBKDKBC, FGHLALPKLCB OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "52")]
	EKDAONPNEDM LNINFFJKFAI(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void BCFBIEIDPHK(PKENAFNLEAO GOGGPBKDKBC, EKDAONPNEDM OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float FAGIFOJGMPD(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void HAGKGDEMHHO(PKENAFNLEAO GOGGPBKDKBC, float OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void EMHGIIIDBOO(PKENAFNLEAO GOGGPBKDKBC, object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void LIOGICKJBEF(PKENAFNLEAO GOGGPBKDKBC, object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool KAKJDCNKEGM(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void EMCFMLCPLNM(PKENAFNLEAO GOGGPBKDKBC, object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void DIOJCGOGHEH(PKENAFNLEAO GOGGPBKDKBC, object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool CCMKJNMAJNK(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool PELKCHODMCP(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody ICBALKLHGOK(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void NJMDODMNKJP(PKENAFNLEAO GOGGPBKDKBC, Rigidbody FFHIAOPJEJF);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void OLPGEFNAPKA(PKENAFNLEAO GOGGPBKDKBC, object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void LLJCOJABAHE(PKENAFNLEAO GOGGPBKDKBC, object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool NPIKLIMPNBF(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void MHLKNEKBBDG(PKENAFNLEAO GOGGPBKDKBC, float3 NPNMEIDGLAE);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void LJHHJLAGGMH(PKENAFNLEAO GOGGPBKDKBC, float3 NAPJPBKPLFK);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool OELAKDJINEG(PKENAFNLEAO GOGGPBKDKBC, [Out] float3 NPNMEIDGLAE);

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool FICALOKKHBA(PKENAFNLEAO GOGGPBKDKBC, [Out] float3 NAPJPBKPLFK);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool KGPPIMBCPCK(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void OHMOPINAJKM(PKENAFNLEAO GOGGPBKDKBC, object EJJDDFFADPC, bool GFJJBICPGBM);

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void PCCJAKDEBOO(PKENAFNLEAO GOGGPBKDKBC, bool FGFHALJGKMI);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void FHHAAHOCPIJ(PKENAFNLEAO GOGGPBKDKBC);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool EBFMFEPOMEE(PKENAFNLEAO GOGGPBKDKBC);
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KEHCJKOHFBH
{
	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAECKCCANBK(Entity EDJFECNEEPI);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDHOCKKEJIL(Entity EDJFECNEEPI);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BOLONJKFONM(Entity EDJFECNEEPI);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DMHMIPOBNHA
{
	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCEEKBADBIG(PKENAFNLEAO FCPOJLOEIEO, bool PDFAMNMPAIB);
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public delegate void BPCBFLOODBB(GOGONLBFFOA LJMPAGDJPMD);
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public readonly ref struct GOGONLBFFOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly EPFJFEANHAG LFAAMINANEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly NativeArray<byte> IFKAFBEGKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly NativeArray<byte> AGPCDJANBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly ANLDAMAMKAN LLPAKFGNDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly int LBOGPIGPKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Type APCIGGMPPFB;

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public EPFJFEANHAG BHPJOGLBDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x4AD30B0", Offset = "0x4AD16B0", VA = "0x184AD30B0")]
		get
		{
			return default(EPFJFEANHAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public int JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3090", Offset = "0x7DE1690", VA = "0x187DE3090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public ANLDAMAMKAN CAKAJDAKFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0xA088E0", Offset = "0xA06EE0", VA = "0x180A088E0")]
		get
		{
			return default(ANLDAMAMKAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x7DE30B0", Offset = "0x7DE16B0", VA = "0x187DE30B0")]
	public GOGONLBFFOA(EPFJFEANHAG LFAAMINANEC, NativeArray<byte> IFKAFBEGKEH, NativeArray<byte> AGPCDJANBHN, ANLDAMAMKAN LLPAKFGNDOB, int LBOGPIGPKJN, Type APCIGGMPPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x387FB50", Offset = "0x387E150", VA = "0x18387FB50")]
	public NativeArray<T> BNGJJEONNAP<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x387FB90", Offset = "0x387E190", VA = "0x18387FB90")]
	public NativeArray<T> BOHNPGJDOND<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x387FBD0", Offset = "0x387E1D0", VA = "0x18387FBD0")]
	public (EPFJFEANHAG, NativeArray<T>, NativeArray<T>) PHDCGNDDLGA<T>() where T : struct
	{
		return default((EPFJFEANHAG, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3060", Offset = "0x7DE1660", VA = "0x187DE3060")]
	public LKIPFKKDGIK DOPDPJACBHI()
	{
		return default(LKIPFKKDGIK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public interface LNHHAEMFJCL
{
	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	string DIGDNMKILKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	LNHHAEMFJCL FMEOKCLJPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	IEnumerable<LNHHAEMFJCL> DKGHGDEALIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LEHLIJHKDMN
{
	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	LNHHAEMFJCL OOMKNOIDNCG
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	NativeArray<ANLDAMAMKAN> CCHHNJLIJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool APJBEKBANNB(ANLDAMAMKAN LLPAKFGNDOB, [Out] LNHHAEMFJCL FEHDPLGKCJJ);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AMBIAOGNIIF(ANLDAMAMKAN LLPAKFGNDOB, BPCBFLOODBB ILBBMDLMAJP);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OMFPKPKPLOB(ANLDAMAMKAN LLPAKFGNDOB, BPCBFLOODBB ILBBMDLMAJP);
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CPMCMNDHPDL
{
	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMBIAOGNIIF(ANLDAMAMKAN LLPAKFGNDOB, BPCBFLOODBB ILBBMDLMAJP);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMFPKPKPLOB(ANLDAMAMKAN LLPAKFGNDOB, BPCBFLOODBB ILBBMDLMAJP);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public static class LGDEOMPIGOB
{
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IKLDODHOHAH
{
	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	bool GFPPMAMJCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	GMMIKNBNAFB PMAELPHFHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HPPPCOJINNL(KNIHOKEGCFA CEDMGFDCANL, bool ACPGFLLIMML);

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JFNNBJPEKLH(JOKHKLAANOK CEDMGFDCANL, ANLDAMAMKAN LLPAKFGNDOB);

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CFMNDEJOFPB(NativeArray<JOKHKLAANOK> NOJPMKMNCOE);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public static class MDPJCLJFOFF
{
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public readonly ref struct LKIPFKKDGIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly GOGONLBFFOA APDBNIMCPID;

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public EPFJFEANHAG BHPJOGLBDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x4AD30B0", Offset = "0x4AD16B0", VA = "0x184AD30B0")]
		get
		{
			return default(EPFJFEANHAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x7DE70D0", Offset = "0x7DE56D0", VA = "0x187DE70D0")]
	public LKIPFKKDGIK(GOGONLBFFOA APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6B80", Offset = "0x7DE5180", VA = "0x187DE6B80")]
	public EPFJFEANHAG BNGJJEONNAP()
	{
		return default(EPFJFEANHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6CB0", Offset = "0x7DE52B0", VA = "0x187DE6CB0")]
	public EPFJFEANHAG BOHNPGJDOND()
	{
		return default(EPFJFEANHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6DE0", Offset = "0x7DE53E0", VA = "0x187DE6DE0")]
	public (EPFJFEANHAG, EPFJFEANHAG, EPFJFEANHAG) PHDCGNDDLGA()
	{
		return default((EPFJFEANHAG, EPFJFEANHAG, EPFJFEANHAG));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public static class EFCCCONEDHJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public readonly struct GMMIKNBNAFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly NativeBitArray NALBMHFBGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly NativeParallelHashMap<JOKHKLAANOK, int> DLJLDIPNKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly NativeParallelHashSet<KNIHOKEGCFA> KFOJEBIIPBF;

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public bool JACKIBDCEEF
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2300", Offset = "0x7DE0900", VA = "0x187DE2300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public bool GFPPMAMJCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2320", Offset = "0x7DE0920", VA = "0x187DE2320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x5C1D860", Offset = "0x5C1BE60", VA = "0x185C1D860")]
	public GMMIKNBNAFB(NativeBitArray NALBMHFBGMN, NativeParallelHashMap<JOKHKLAANOK, int> DLJLDIPNKEM, NativeParallelHashSet<KNIHOKEGCFA> KFOJEBIIPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2110", Offset = "0x7DE0710", VA = "0x187DE2110")]
	public bool JFNNBJPEKLH(JOKHKLAANOK CEDMGFDCANL, ANLDAMAMKAN LLPAKFGNDOB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CLFFFENGNKK
{
	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	KIOOHKBHOLJ GCHDFGOFFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface KMODMBDLHLB
{
	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGNNGPHJIGO(PKENAFNLEAO GOGGPBKDKBC, NBDNAFKNLDM OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NCCENBGIEMA OBHCPINIMHB();
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KHALAAIOGCO
{
	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGDPAKOJAAA(World JEOJCJGMOLH);

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OCJMJKHCBJB(World JEOJCJGMOLH);

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase ENGFLLCFLCP(World JEOJCJGMOLH);

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CNDJHACJOKD(World JEOJCJGMOLH);

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HFFOHFJMOJL(World JEOJCJGMOLH);

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FNJGGHLLPOG(World JEOJCJGMOLH);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IOJJKCOJGEJ(World JEOJCJGMOLH);

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> FPHGPOJJHCC();
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BNOONHHEGEJ
{
	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADOEJAOOHEB(PKENAFNLEAO DCOBGODCAEM, bool OHLIHBDBKCE);
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public readonly struct GGNCMIFHAAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly IEnumerable<LHBDCIMNFIA> NNFECOKKCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly IReadOnlyList<GameObject> AOHAMOKDOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly IReadOnlyList<int> BHLBMACGEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly IReadOnlyList<(JOKHKLAANOK, JOKHKLAANOK)> GEIFKKMNNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly int NPFIOIJEJPF;
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct HAEEGDDFOFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public InventionIdData HJPLNJNIFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public InventionInstanceIdData PKDLBFIDCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool PNLDJGEGEFO;

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3230", Offset = "0x7DE1830", VA = "0x187DE3230")]
	public HAEEGDDFOFN(long HJPLNJNIFLL, Guid PKDLBFIDCEC, bool PNLDJGEGEFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[ServiceLifetime(Lifetime.Application)]
public interface KDLBBIAEJNJ
{
	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PNMPDOEFGAA MDAGPEBKPOI(GMMJMMMKMBM ONIFFPELODH, int ECBKFDDKGKP = 0, bool IFGMIPOFMNM = false);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PPLNLDGJMFG ECIDGLPFONN(GMMJMMMKMBM ONIFFPELODH, PKENAFNLEAO JHDAOHEONAC, [In] UniformTRS BJBPDNJLNAA, FCOFBKLBGGE CCLPDFENGIL, [Optional] HAEEGDDFOFN MDPHHIJMMON, bool FEDFJECGBOE = true, bool MFIHDNGFBLF = false, bool IFGMIPOFMNM = false);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KDNCIDPCBFM OHPMIBJBHDE();

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KDNCIDPCBFM OLCLKEJCLLO(EPFJFEANHAG OMFFBFINKMM, [In] UniformTRS MFCKPGECJIE, [Optional] FCOFBKLBGGE AACFFEGDGCF);

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NJLJFFBEMMN(PKENAFNLEAO FLNGGJELCEB);

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EEOFOEHBFGG(PKENAFNLEAO FLNGGJELCEB, [Out] Exception FJADMGBFJLD);

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<JOKHKLAANOK> EIBBAPHHMBO(PKENAFNLEAO FLNGGJELCEB, Allocator NDFENJBGNOB);

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<JOKHKLAANOK> BEAEANJABHK(PKENAFNLEAO FLNGGJELCEB, Allocator NDFENJBGNOB);

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EPFJFEANHAG HKPALECCCOC(PKENAFNLEAO FLNGGJELCEB, Allocator NDFENJBGNOB);

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EPFJFEANHAG MCGDEAICJEE(PKENAFNLEAO FLNGGJELCEB, Allocator NDFENJBGNOB);

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EPFJFEANHAG CJMMEHEJLDP(PKENAFNLEAO FLNGGJELCEB, Allocator NDFENJBGNOB);

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> LFLGFEPGCBG(PKENAFNLEAO FLNGGJELCEB, Allocator NDFENJBGNOB);

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GFDIBAFBGFE(PKENAFNLEAO FLNGGJELCEB);

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int JAKLKHJOMIL(PKENAFNLEAO FLNGGJELCEB, int JAALIADHHOC);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[ServiceLifetime(Lifetime.Application)]
public interface FHPIJCIIFKO
{
	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0xDDD580", Offset = "0xDDBB80", VA = "0x180DDD580", Slot = "0")]
	bool HBGMKAEOAKP(object NKBJHKLGFDP, CEADAKHMIIO DJCKCBEAICI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class KKNDCGMJKBP
{
	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6120", Offset = "0x7DE4720", VA = "0x187DE6120")]
	public static bool HBGMKAEOAKP(this FHPIJCIIFKO BEGHPONNAEO, object NKBJHKLGFDP, [Out] CEADAKHMIIO DJCKCBEAICI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public enum FHAJBGDIGEK : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	MaxPlayers = byte.MaxValue,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	IsVisible = 254,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	IsOpen = 253,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	PlayerCount = 252,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Removed = 251,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	PropsListedInLobby = 250,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	CleanupCacheOnLeave = 249,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	MasterClientId = 248,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	ExpectedUsers = 247,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	PlayerTtl = 246,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	EmptyRoomTtl = 245,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	HasDedicatedMaster = 87
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public interface CEADAKHMIIO
{
	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	PMGMMGGAAPO KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	AEMMHEJJEHA FACMAKELJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	bool JHEKIIEFEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	bool HJDMADAPHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object KFABMFMFJPB();

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0xF6F390", Offset = "0xF6D990", VA = "0x180F6F390", Slot = "5")]
	(AEMMHEJJEHA, Dictionary<object, object>) ONCBHJOMKIO()
	{
		return default((AEMMHEJJEHA, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "6")]
	(JOKHKLAANOK, AEMMHEJJEHA) PCBPKPJODMM()
	{
		return default((JOKHKLAANOK, AEMMHEJJEHA));
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "7")]
	MLEJCHELJGC<(JOKHKLAANOK, AEMMHEJJEHA)> EKMLHDJOFNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0xF6F390", Offset = "0xF6D990", VA = "0x180F6F390", Slot = "8")]
	(JJHDADELCNN, byte[]) BBLIPEFDMKA()
	{
		return default((JJHDADELCNN, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0xF6F390", Offset = "0xF6D990", VA = "0x180F6F390", Slot = "9")]
	(NAKHDIPHEPO, byte[]) MDHPOFCEDCP()
	{
		return default((NAKHDIPHEPO, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0xF6F390", Offset = "0xF6D990", VA = "0x180F6F390", Slot = "10")]
	T PGKJJBBGDIO<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class JKFNLFIKKJF
{
	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x7DE52D0", Offset = "0x7DE38D0", VA = "0x187DE52D0")]
	public static bool NNNPHLMMHNO(this CEADAKHMIIO KGFBFINKAKM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface PLIPCGIFLFP : MLEJCHELJGC<ABBHPHKIIPL>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[DefaultMember("Item")]
public interface MLEJCHELJGC<T>
{
	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	T OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	int JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public enum PMGMMGGAAPO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	BulkInstantiate = 1,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	BulkDestroy = 2,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	OMSendPacket = 4,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	RR_OutOfBandMessage = 5,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	RR_FastForwardMarker = 6,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	RR_SelfJoinMarker = 7,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	RR_DebugOp = 10,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	RR_CachedEvent = 11,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	RRRoomRequestEvent = 20,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	RRRoomRequestFailedResponseEvent = 21,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	RRBufferedRoomEvent = 22,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	RRClearBufferedRoomEvent = 23,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	RR_CreationOp = 24,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	RR_CreationOpResponse = 25,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	RR_CreationOp_Unchecked = 26,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	RR_MasterLockBlockComplete = 27,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RR_NetworkSynchronization = 28,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RR_NetworkInstantiate = 29,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	RR_BulkInstantiate = 31,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	RR_Destroy = 32,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	RR_BulkDestroy = 33,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	RR_TransferOwnership = 34,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RR_OwnershipUpdate = 35,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	RR_RPC = 36,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	RPC = 200,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	SendSerialize = 201,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	Instantiation = 202,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	CloseConnection = 203,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	Destroy = 204,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RemoveCachedRPCs = 205,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	SendSerializeReliable = 206,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	DestroyPlayer = 207,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	OwnershipRequest = 209,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	OwnershipTransfer = 210,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	VacantViewIds = 211,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	OwnershipUpdate = 212,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	AuthEvent = 223,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	LobbyStats = 224,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	AppStats = 226,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	Match = 227,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	QueueState = 228,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	GameListUpdate = 229,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	GameList = 230,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	CacheSliceChanged = 250,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	ErrorInfo = 251,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	PropertiesChanged = 253,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	Leave = 254,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	Join = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public enum JJHDADELCNN : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	None = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	NetworkTransformInitializationData = 1314146628u,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	RestoreCreationData = 1380140064u,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	OldestCachedPacketId = 1329811529u,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	SnapshotPublished = 1397773634u,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	SnapshotPayload = 1397771332u,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	SnapshotClear = 1129337683u
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class KHLNOIJCODB
{
	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x7DE5D60", Offset = "0x7DE4360", VA = "0x187DE5D60")]
	public static JOKHKLAANOK OJAFJNDPMGH(this HMPMPJIHGEA APDBNIMCPID)
	{
		return default(JOKHKLAANOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE5A90", Offset = "0x7DE4090", VA = "0x187DE5A90")]
	public static JOKHKLAANOK LKAKEEODAFO([In] this HMPMPJIHGEA APDBNIMCPID)
	{
		return default(JOKHKLAANOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x7D639A0", Offset = "0x7D61FA0", VA = "0x187D639A0")]
	public static JOKHKLAANOK MMGOJPHLNCJ(this HMPMPJIHGEA APDBNIMCPID)
	{
		return default(JOKHKLAANOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x7D639A0", Offset = "0x7D61FA0", VA = "0x187D639A0")]
	public static ViewId GLLGGCIJFJN(this HMPMPJIHGEA APDBNIMCPID)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x7DE5E30", Offset = "0x7DE4430", VA = "0x187DE5E30")]
	public static FixedString64Bytes PCMGALDEIBD(this KNIHOKEGCFA HJPLNJNIFLL)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x7DE5AE0", Offset = "0x7DE40E0", VA = "0x187DE5AE0")]
	public static FixedString64Bytes OCHMKJFJNLH(this JOKHKLAANOK HJPLNJNIFLL)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x7DE5DA0", Offset = "0x7DE43A0", VA = "0x187DE5DA0")]
	public static FixedString32Bytes PCMGALDEIBD(this Entity IOGPJKLGKKO)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ONNBOENKDAE : LGPPLIONBEJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public enum JKPICNICOOB
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	End,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PLADEJNHEJL
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<object> IFGCGDBKJAE;

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "2")]
	void JDDNLBFKJDN(object NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "3")]
	void OMJBBDKLMBK(NAKHDIPHEPO NEKLMLONNIM, ReadOnlySpan<byte> DGHLABNPIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	void EPLPINMNPEG(JJHDADELCNN MLCOGCMJLBB, ReadOnlySpan<byte> DGHLABNPIEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CKOJBLLKCDI
{
	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NAKHDIPHEPO ACFFDOMCKPB(ReadOnlySpan<byte> DGHLABNPIEC);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DCIIAEEBHIA
{
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFMEIPHEHKH(NAKHDIPHEPO OEHHKNIGGMI, ReadOnlySpan<byte> DGHLABNPIEC);

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBDAPJANMNN(ReadOnlySpan<NAKHDIPHEPO> BABFMBLDKKB);
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public struct FAEBBJJOMID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public NAKHDIPHEPO NEKLMLONNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public ReadOnlyMemory<byte> DGHLABNPIEC;
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public struct NAKHDIPHEPO
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static NAKHDIPHEPO IABCNBFIBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public KNIHOKEGCFA EJHJGBMJABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public int FFBFLDGIIDE;

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	public static KNIHOKEGCFA ICLPGIJLJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x7DE9200", Offset = "0x7DE7800", VA = "0x187DE9200")]
		get
		{
			return default(KNIHOKEGCFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x50C53F0", Offset = "0x50C39F0", VA = "0x1850C53F0")]
	public NAKHDIPHEPO(KNIHOKEGCFA EJHJGBMJABF, int FFBFLDGIIDE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9170", Offset = "0x7DE7770", VA = "0x187DE9170")]
	public static bool MMJMCICIDNJ([In] NAKHDIPHEPO OBNCJFFHHLB, [In] NAKHDIPHEPO ODHPFGNCGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9010", Offset = "0x7DE7610", VA = "0x187DE9010", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9110", Offset = "0x7DE7710", VA = "0x187DE9110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9250", Offset = "0x7DE7850", VA = "0x187DE9250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x7DE9000", Offset = "0x7DE7600", VA = "0x187DE9000")]
	public void BGDNOIMKKGE([Out] KNIHOKEGCFA GMGHHBHDHEG, [Out] int FFBFLDGIIDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public static class OGMDLBCHMDA
{
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public struct LHBDCIMNFIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public Guid DGNNPFFMIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public string NJBHNMHIDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public Vector3 EPCLGOKLIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public Quaternion OOBEGCNALKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public Vector3 HDLKNIPAJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public int PAKBPCDLPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public NEEICKGOONJ PMLCGCAHNGK;

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6A60", Offset = "0x7DE5060", VA = "0x187DE6A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public enum PCONLGHKAAD
{
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public static class OCMDGHHNBNA
{
	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB3C0", Offset = "0x7DE99C0", VA = "0x187DEB3C0")]
	public static bool OIKFNDGJANL(this PCONLGHKAAD MLCOGCMJLBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB3B0", Offset = "0x7DE99B0", VA = "0x187DEB3B0")]
	public static bool NGHCOGNMFKB(this PCONLGHKAAD MLCOGCMJLBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB3A0", Offset = "0x7DE99A0", VA = "0x187DEB3A0")]
	public static bool HILGBPFJNFB(this PCONLGHKAAD MLCOGCMJLBB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[Flags]
public enum COOHOGKFLAK
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public interface FCOFBKLBGGE
{
	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KIODLPJJOLF([In] Guid KIDPOMGFMKB, [Out] Guid ELDDEEODOKE);
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[Flags]
public enum IFAIHBJHEBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public interface KDNCIDPCBFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	FFHNDOJIMFO ADFPEOCIKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString NPHDMNHHBLA();
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public enum AGHCKOBFLCI
{
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct KLIAIMBDJOH : ISystemStateComponentData, IComponentData, IEquatable<KLIAIMBDJOH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public float3 LCNBCNDGADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public float3 NOILKPIOAIK;

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6200", Offset = "0x7DE4800", VA = "0x187DE6200", Slot = "4")]
	public bool Equals(KLIAIMBDJOH MIJLJBIHDMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MNJDFMONHOE
{
	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IEHKPCNMALM(long OEOACNOOFPP);

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OAAGFPBOBFI(NativeParallelHashSet<long> JMIEPEMKCMB);

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNPKBBFMKFE(World JEOJCJGMOLH, NativeParallelHashMap<Guid, long> IKCGIPBAPFL);

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MNDNCGODNBL(JOKHKLAANOK CEDMGFDCANL);

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AFFPOEMHBJK(JOKHKLAANOK CEDMGFDCANL, [Out] Guid BDHMLGIEBED, [Out] long OEOACNOOFPP);

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GGHDMCGPNNC(JOKHKLAANOK CEDMGFDCANL, Guid BDHMLGIEBED, long OEOACNOOFPP);

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ILKMAILPLLC(Guid BDHMLGIEBED);

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CJNJJOECIFP(Guid BDHMLGIEBED, [Out] int DDGBNHGEPMO, [Out] int PECAOFODFDF);

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JFHCAPPEBJG(Guid BDHMLGIEBED, int DDGBNHGEPMO, int PECAOFODFDF);

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LNKLLNMHJLI(Guid BDHMLGIEBED);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public class PPHBBBBMJHN
{
	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PPHBBBBMJHN()
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
