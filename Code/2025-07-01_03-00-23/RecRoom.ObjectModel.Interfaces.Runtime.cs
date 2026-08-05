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
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8188040", Offset = "0x8186640", VA = "0x188188040", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IKLANAODBBB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8180D00", Offset = "0x817F300", VA = "0x188180D00")]
	public static void JIMCJFMFKNG(this Rigidbody OJNHDOEHCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8180E90", Offset = "0x817F490", VA = "0x188180E90")]
	public static void JIMCJFMFKNG(this Rigidbody OJNHDOEHCKH, Vector3 DMPKCADFOFF, Quaternion HHJFGKOLDFM, Vector3 AJJAFICLGCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct IIKPNIBMDFG : IReadOnlyList<DAHJHHJGHIB>, IEnumerable<DAHJHHJGHIB>, IEnumerable, IReadOnlyCollection<DAHJHHJGHIB>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct LKFEKHGMJEE : IEnumerator<DAHJHHJGHIB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly NNEPMGCDLOI LONKPMILJIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator OOGKDOBKKND;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DAHJHHJGHIB CGHPBCAOGAD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8186E20", Offset = "0x8185420", VA = "0x188186E20", Slot = "4")]
			get
			{
				return default(DAHJHHJGHIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8186DD0", Offset = "0x81853D0", VA = "0x188186DD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x536FF60", Offset = "0x536E560", VA = "0x18536FF60")]
		public LKFEKHGMJEE(NNEPMGCDLOI LONKPMILJIG, NativeArray<LocalId>.Enumerator OOGKDOBKKND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8186D10", Offset = "0x8185310", VA = "0x188186D10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8186D50", Offset = "0x8185350", VA = "0x188186D50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8186D90", Offset = "0x8185390", VA = "0x188186D90", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly FIFKEPBKMKO MNCGAKBHIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> AMKPDLCNENL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DAHJHHJGHIB FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8180C80", Offset = "0x817F280", VA = "0x188180C80", Slot = "4")]
		get
		{
			return default(DAHJHHJGHIB);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81800C0", Offset = "0x817E6C0", VA = "0x1881800C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int KENPLJAGKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NNEPMGCDLOI LOJJBHPCFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8180410", Offset = "0x817EA10", VA = "0x188180410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GMOIMINMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MAFFJMNGDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x81803D0", Offset = "0x817E9D0", VA = "0x1881803D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> MPNBBIFGNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C330", Offset = "0x2B9A930", VA = "0x182B9C330")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> JJNMHOCPLHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8180370", Offset = "0x817E970", VA = "0x188180370")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x81808F0", Offset = "0x817EEF0", VA = "0x1881808F0")]
	public IIKPNIBMDFG(int BJPLKLLFDMG, NNEPMGCDLOI LONKPMILJIG, Allocator HOHBLCPFIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8180C70", Offset = "0x817F270", VA = "0x188180C70")]
	public IIKPNIBMDFG(FIFKEPBKMKO MNCGAKBHIPL, NativeArray<LocalId> AMKPDLCNENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8180B00", Offset = "0x817F100", VA = "0x188180B00")]
	public IIKPNIBMDFG(FIFKEPBKMKO MNCGAKBHIPL, NativeArray<Entity> AMKPDLCNENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8180B70", Offset = "0x817F170", VA = "0x188180B70")]
	internal IIKPNIBMDFG(NNEPMGCDLOI LONKPMILJIG, NativeArray<Entity> DCGEKCKMHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8180C00", Offset = "0x817F200", VA = "0x188180C00")]
	internal IIKPNIBMDFG(NNEPMGCDLOI LONKPMILJIG, NativeArray<LocalId> AMKPDLCNENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81809A0", Offset = "0x817EFA0", VA = "0x1881809A0")]
	public IIKPNIBMDFG(NNEPMGCDLOI LONKPMILJIG, int PHABMFMJBEC, Allocator HOHBLCPFIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8180A50", Offset = "0x817F050", VA = "0x188180A50")]
	public IIKPNIBMDFG(IIKPNIBMDFG AHHCNFHAIDO, Allocator HOHBLCPFIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8180460", Offset = "0x817EA60", VA = "0x188180460")]
	public void OGANFLEFEJB(List<DAHJHHJGHIB> BGGFBGFNIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8180070", Offset = "0x817E670", VA = "0x188180070")]
	public void AFODBCFDFFI(int KHMHPNKMLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8180770", Offset = "0x817ED70", VA = "0x188180770")]
	public IIKPNIBMDFG PLEBMHKEBJO(Allocator HOHBLCPFIEJ)
	{
		return default(IIKPNIBMDFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8180220", Offset = "0x817E820", VA = "0x188180220")]
	public Span<DAHJHHJGHIB> HJBLBGEGHDI()
	{
		return default(Span<DAHJHHJGHIB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x81806D0", Offset = "0x817ECD0", VA = "0x1881806D0")]
	public IIKPNIBMDFG PFNOIIGFBEK(int BKJCDJJKAFA, int PHABMFMJBEC)
	{
		return default(IIKPNIBMDFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x81801E0", Offset = "0x817E7E0", VA = "0x1881801E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8180120", Offset = "0x817E720", VA = "0x188180120")]
	public LKFEKHGMJEE DHKFMABLBKB()
	{
		return default(LKFEKHGMJEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8180810", Offset = "0x817EE10", VA = "0x188180810", Slot = "6")]
	private IEnumerator<DAHJHHJGHIB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8180880", Offset = "0x817EE80", VA = "0x188180880", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OKEPHFBJODF
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3CEEE40", Offset = "0x3CED440", VA = "0x183CEEE40")]
	public static LCBPMIKIJMM<T> DFOKDNCEGCE<T>(this IIKPNIBMDFG LFMKIINCPNH) where T : Component
	{
		return default(LCBPMIKIJMM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct CCDMGJJANIN : IList<DAHJHHJGHIB>, ICollection<DAHJHHJGHIB>, IEnumerable<DAHJHHJGHIB>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct CEEIOCDMGNH : IEnumerator<DAHJHHJGHIB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly NNEPMGCDLOI LONKPMILJIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator OOGKDOBKKND;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public DAHJHHJGHIB CGHPBCAOGAD
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8178430", Offset = "0x8176A30", VA = "0x188178430", Slot = "4")]
			get
			{
				return default(DAHJHHJGHIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x81783E0", Offset = "0x81769E0", VA = "0x1881783E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x536FF60", Offset = "0x536E560", VA = "0x18536FF60")]
		public CEEIOCDMGNH(NNEPMGCDLOI LONKPMILJIG, NativeArray<LocalId>.Enumerator OOGKDOBKKND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8178320", Offset = "0x8176920", VA = "0x188178320", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8178360", Offset = "0x8176960", VA = "0x188178360", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x81783A0", Offset = "0x81769A0", VA = "0x1881783A0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NNEPMGCDLOI LONKPMILJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> AMKPDLCNENL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DAHJHHJGHIB FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8177D90", Offset = "0x8176390", VA = "0x188177D90", Slot = "4")]
		get
		{
			return default(DAHJHHJGHIB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8177E80", Offset = "0x8176480", VA = "0x188177E80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8177820", Offset = "0x8175E20", VA = "0x188177820", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GMOIMINMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8177820", Offset = "0x8175E20", VA = "0x188177820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> MPNBBIFGNMB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C330", Offset = "0x2B9A930", VA = "0x182B9C330")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KJKCBDBHHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8177D10", Offset = "0x8176310", VA = "0x188177D10")]
	public CCDMGJJANIN(NNEPMGCDLOI LONKPMILJIG, Allocator HOHBLCPFIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8177C80", Offset = "0x8176280", VA = "0x188177C80")]
	public CCDMGJJANIN(NNEPMGCDLOI LONKPMILJIG, int PHABMFMJBEC, Allocator HOHBLCPFIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8177710", Offset = "0x8175D10", VA = "0x188177710")]
	public IIKPNIBMDFG GGEOLIIBECF()
	{
		return default(IIKPNIBMDFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x81773A0", Offset = "0x81759A0", VA = "0x1881773A0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x81773E0", Offset = "0x81759E0", VA = "0x1881773E0", Slot = "13")]
	public bool Contains(DAHJHHJGHIB GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8177470", Offset = "0x8175A70", VA = "0x188177470", Slot = "14")]
	public void CopyTo(DAHJHHJGHIB[] DDENONPPKCL, int FKFIMLILJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8177320", Offset = "0x8175920", VA = "0x188177320", Slot = "11")]
	public void Add(DAHJHHJGHIB GANFJJCKLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x81778F0", Offset = "0x8175EF0", VA = "0x1881778F0", Slot = "7")]
	public void Insert(int KHMHPNKMLMD, DAHJHHJGHIB GANFJJCKLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x81779F0", Offset = "0x8175FF0", VA = "0x1881779F0", Slot = "15")]
	public bool Remove(DAHJHHJGHIB GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8177860", Offset = "0x8175E60", VA = "0x188177860", Slot = "6")]
	public int IndexOf(DAHJHHJGHIB GANFJJCKLGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x81779A0", Offset = "0x8175FA0", VA = "0x1881779A0", Slot = "8")]
	public void RemoveAt(int KHMHPNKMLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x81776D0", Offset = "0x8175CD0", VA = "0x1881776D0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8177640", Offset = "0x8175C40", VA = "0x188177640")]
	public CEEIOCDMGNH DHKFMABLBKB()
	{
		return default(CEEIOCDMGNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8177AC0", Offset = "0x81760C0", VA = "0x188177AC0", Slot = "16")]
	private IEnumerator<DAHJHHJGHIB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8177BA0", Offset = "0x81761A0", VA = "0x188177BA0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MMIABAMBHNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DAHJHHJGHIB FABPKFIFKFJ(DAHJHHJGHIB AMKPDLCNENL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CHDIDCDNCIA : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface OLOOCEBJAOK : DJBMNHGCNMJ, CGLAHCPNNAM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NHAJEMBLBNA APHLNFEKAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	FIFKEPBKMKO PCCLFLFKLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface CGLAHCPNNAM
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool BKEBDEOALME
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface ACIMNCNDDNG
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGHFBLKGNLJ(bool KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHCEOPNNHLH();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface HOGOKHDOHIO
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool HKPMNCHNBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool MBKMCPECNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool IIMFOFDJLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool MOCAJGHHEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KBAFGMAMDFK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JFLALBFLNJE(bool IOAJJAMFEKK);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EIBBCFCBNHE(ByteString FOECJMNHFPG);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ENPCMLLICAG();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JKONILLIKOK();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CIDLKGMBFBE();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface FDLCNEOAOBH
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	MGPNAOEDNIM APHLNFEKAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	JOBJJPKFOOE KGEOAJLABMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	HPBOONODMMK JHGHCACGHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	OLOOCEBJAOK OJLHBADPEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	JNABHCLPBAD JPHKKODCPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	HOGOKHDOHIO KHLLPPMCBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	FOKLIOBGGNN CNOLLKCJMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	OMELAGLEPCC AMHGOECOLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	EGNFIJCEPIJ PFHMEFJIGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KGOKLMGHDGG EJLDIIMBBEB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	EEALEHMMMJI ODLKJCNHOLO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	ONPNKPCBPFO GDHMFHKINMM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	NNEPMGCDLOI LOJJBHPCFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CDCKCDNFOMB POKMHGHAKHP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	DKLIEHDNMBN IFILPLHPLFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	HGPGBOJCIDN NMCABOIBEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	PGDBNEEHBED KGNAKMPFFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DHINGPFKPJK HEFGBOLENJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	OPONHEPPMGD CIGKBIOIGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	LBLHKCNGHJA DLMEFODFOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	FLJFNHKCHAI ABLPFBNCHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	DKBDPOEBPOJ OFILGGBMCDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	OOFDMFJHDIP CEKHJAOHBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	EFOKELDHDDA FIJMGHGIKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	ELODOEPAFFG GLKJLPLEFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	DDNCFLMKNHJ ECCFGLHBNMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	GCKFMICNINL OPKLPILNGBL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	HDFJJJHIDHC DBLADLOOKEB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	MEGNKEJDOFA JEHHPONKGNL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	KNDMBEHEOII BOIDGHOOOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	LBJJNLBDJDJ MFGCFPAGIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	MCNADDNPOAH LMHIDNFMGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ALIBGHNMPLC PPMIKHHHEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	PKDNDBENIKM KIJEAHMEMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	EBAHIDFIMHO NKHHNHLBBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	OIKMDOGDMJA BLICCDPNBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	OEIFJNJODNF DBBCHBDKIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	BPELKFMMEGF NFELAJKOGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerTypeProxy(typeof(PACGNHGHIAG))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct DAHJHHJGHIB : IComparable<DAHJHHJGHIB>, IEquatable<DAHJHHJGHIB>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly DAHJHHJGHIB PAIEKNMKJII;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int PIGKELFIDJF = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int GHMMBKBHLOB = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int BDHFOIKDDPO = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int ILOILNOPOCK = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId OHGBPBLOAKN;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public NNEPMGCDLOI LOJJBHPCFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8176280", Offset = "0x8174880", VA = "0x188176280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public OLOOCEBJAOK OJLHBADPEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x817A9E0", Offset = "0x8178FE0", VA = "0x18817A9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LocalId JKGBGINFEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x817AD00", Offset = "0x8179300", VA = "0x18817AD00")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	internal FIFKEPBKMKO PCCLFLFKLNI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x817ACF0", Offset = "0x81792F0", VA = "0x18817ACF0")]
		get
		{
			return default(FIFKEPBKMKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool FMHHEEPBJPF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x817A750", Offset = "0x8178D50", VA = "0x18817A750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private bool PFJOALIMOHH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x817AD40", Offset = "0x8179340", VA = "0x18817AD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x817AF50", Offset = "0x8179550", VA = "0x18817AF50")]
	public DAHJHHJGHIB(NNEPMGCDLOI HJCGFDPDBNJ, LocalId OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x817AEC0", Offset = "0x81794C0", VA = "0x18817AEC0")]
	public DAHJHHJGHIB(FIFKEPBKMKO MNCGAKBHIPL, LocalId OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
	public MFPEINJHCFE FFBGJECHHAC()
	{
		return default(MFPEINJHCFE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x817A960", Offset = "0x8178F60", VA = "0x18817A960")]
	public static LocalId EIMKEBEILPD(DAHJHHJGHIB GJGNFMBHFMH)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x817A9A0", Offset = "0x8178FA0", VA = "0x18817A9A0")]
	public static Entity EIMKEBEILPD(DAHJHHJGHIB GJGNFMBHFMH)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x817ABD0", Offset = "0x81791D0", VA = "0x18817ABD0")]
	public static bool JKIBMILPCGE(DAHJHHJGHIB DLGEPLKGJOC, DAHJHHJGHIB OKKFDNDPGLP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8178060", Offset = "0x8176660", VA = "0x188178060")]
	public static bool FLMCEAOBGCC(DAHJHHJGHIB DLGEPLKGJOC, DAHJHHJGHIB OKKFDNDPGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x817AD90", Offset = "0x8179390", VA = "0x18817AD90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x817AA40", Offset = "0x8179040", VA = "0x18817AA40", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x817A870", Offset = "0x8178E70", VA = "0x18817A870", Slot = "4")]
	public int CompareTo(DAHJHHJGHIB HOPHFOOKMCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "5")]
	public bool Equals(DAHJHHJGHIB HOPHFOOKMCC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ACNHFCMNANF
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8174DE0", Offset = "0x81733E0", VA = "0x188174DE0")]
	public static DAAPNACEHGA MEJHHEAJCHB(this DAHJHHJGHIB ODCICEDDLMB)
	{
		return default(DAAPNACEHGA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class PACGNHGHIAG
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct FIFKEPBKMKO : IEquatable<FIFKEPBKMKO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte MNCGAKBHIPL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] HKOOIOCCCHM;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static NNEPMGCDLOI OKCEJEGLCGL;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static OLOOCEBJAOK EPLHNIEBHLL;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static NNEPMGCDLOI[] CGAGGLGMBIG;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static OLOOCEBJAOK[] BPCLDKFJFOH;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> EDFIPFLMIML;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public OLOOCEBJAOK OJLHBADPEIM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x817D230", Offset = "0x817B830", VA = "0x18817D230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public NNEPMGCDLOI HAHOIMCPILN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x817D660", Offset = "0x817BC60", VA = "0x18817D660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x817DAD0", Offset = "0x817C0D0", VA = "0x18817DAD0")]
	static FIFKEPBKMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE300", Offset = "0x2BCC900", VA = "0x182BCE300")]
	internal FIFKEPBKMKO(byte KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7001C50", Offset = "0x7000250", VA = "0x187001C50", Slot = "4")]
	public bool Equals(FIFKEPBKMKO HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x817D310", Offset = "0x817B910", VA = "0x18817D310", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xFC3720", Offset = "0xFC1D20", VA = "0x180FC3720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x817DA10", Offset = "0x817C010", VA = "0x18817DA10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x817D740", Offset = "0x817BD40", VA = "0x18817D740")]
	private static NNEPMGCDLOI OOCDAOAJOBD(byte MNCGAKBHIPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x817D3B0", Offset = "0x817B9B0", VA = "0x18817D3B0")]
	private static OLOOCEBJAOK HKLHCKMFNMN(byte MNCGAKBHIPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x817D4F0", Offset = "0x817BAF0", VA = "0x18817D4F0")]
	private static object KIPNHCCNLPP(byte MNCGAKBHIPL, object[] NIJLHKNCLKB, object COMAGLLDBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x817CE90", Offset = "0x817B490", VA = "0x18817CE90")]
	private static int DCEENKIOKNM(byte MNCGAKBHIPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x817D4E0", Offset = "0x817BAE0", VA = "0x18817D4E0")]
	private static int KDCCAPHMMIO(byte MNCGAKBHIPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x817D460", Offset = "0x817BA60", VA = "0x18817D460")]
	private static (int, int) KBIJPICIINE(byte MNCGAKBHIPL)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x817DA00", Offset = "0x817C000", VA = "0x18817DA00")]
	private static byte PAFMFDHKOOB(int PFGEKBLLNEL, int KHMHPNKMLMD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x817CBD0", Offset = "0x817B1D0", VA = "0x18817CBD0")]
	internal static FIFKEPBKMKO CCHHFLKMKEK(OLOOCEBJAOK JIDHBODOGAN, NNEPMGCDLOI DMELKGHGJBC)
	{
		return default(FIFKEPBKMKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x817D7F0", Offset = "0x817BDF0", VA = "0x18817D7F0")]
	internal static void PAEMAGCOOJI(FIFKEPBKMKO MNCGAKBHIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x817CEA0", Offset = "0x817B4A0", VA = "0x18817CEA0")]
	private static void EGCMKBEEACH(int BJPLKLLFDMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum INAKHIDEGOA
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
public interface EDJKOILJNHP
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool LKOOFDHDPBG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool JMMJHDNNFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool HDLMPGEMHMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool GKNJJMANAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool LMGOIBACCHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IOIGEJCCPDL
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CINIHKKAMAH(PGCPNPOCEKF FAIEEFHMPLL, int KHMHPNKMLMD);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BOOBNGEAAPH(PGCPNPOCEKF IHNOKPGIMJF, int KHMHPNKMLMD);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FLGIGHDLIMK(FNAJDFOCBLD GMFJBJMKGIP, int KHMHPNKMLMD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IIBKDCFHJNH : PGCPNPOCEKF, EDJKOILJNHP
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int PKAHLEKCPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEFMFFFJKHN(KBPCCEONKKI LPCNJBGEJJI, int KHMHPNKMLMD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PGCPNPOCEKF : EDJKOILJNHP
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum LBPAKDHAEDN
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

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool DKPJGDPBMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool FHNFIGFPKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool POCGPABJFFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KBPCCEONKKI
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool GMOMEHILPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	NKGGCFMEFLF GIAJEPCBJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	JIMPHAHLFDL MDBAKBIDIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float3 DGHMAMNELGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	quaternion GBHJDFCFFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float3 KFMIJCGMFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	NDMOGPNBENB PFNPFBIHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	OIMGLIMIDDE AKMCIMNLAFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float DNMLDIOIFIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float3 LBOKOIGMABN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float ADCPADJPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	PMDGEEGMAGC FLADFPDGLLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface HJOHPKNHMNA
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	float3 DCMHMEMBABG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float3 KLIDMDNDPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion FOODLGJJABM(float3 KCINGJPCGAK);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface JIMPHAHLFDL
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool GPBMBDPKACB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool EMGMDDLMAHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool IOLHOBJHBGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	float IELNLCHONJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	int JIAHFAHKPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int EBNICINLBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LPGOEFKCECO(HJOHPKNHMNA LPCNJBGEJJI, int KHMHPNKMLMD);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.Application)]
public interface OHINNNKCDAG
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Guid KBOLCNFNJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OOOLLDJCACP(Guid ENAOBJKOEBF, Guid OEEANCBNNKB, Guid KLOMONEBGPM);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task HGKIKNJAHHO(Guid ENAOBJKOEBF, Guid[] AABPCMEEMLO, Guid KLOMONEBGPM);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid NDELDCIBELL(Guid CIKIEGMNCAF);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task ENOCDAKJJGH(DAHJHHJGHIB ABKHAHOGMFI);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PDCEDPMIKBL(Guid CIKIEGMNCAF);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PMPKGJLCBBH(ENKKBHFOAAM BJEJFDGNNBJ, Guid BPKJONHKNAK);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BDBKBHDGLEB(Guid CIKIEGMNCAF, bool IOAJJAMFEKK);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JIFEPADMJCJ(Guid CIKIEGMNCAF, DAAPNACEHGA DMMBMGIHEJC);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NPGPKCLBIKD(DAAPNACEHGA DMMBMGIHEJC);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PNPIHLLGDKO(DAHJHHJGHIB OHGBPBLOAKN);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface CLLAMCDDCOD
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface HKCJMFJNGMF
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "0")]
	void AMDELGJNNDJ(bool IKCKHHEBILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface JOBJJPKFOOE
{
	[Cpp2IlInjected.Token(Token = "0x17000066")]
	HKCJMFJNGMF GBJNNNKGIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	CKNOJDGDHCI HACPDDLPFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	KOAJJAAMDDO ACIOEFMMCPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	CBGIJFKDOCO OPEHIIFBIEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	EJDAOAHPOGO LMHIBCEEMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	DHGFGAGHADN BMHMPGNPLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	BKOBJOKBLLB MHGMGNINCFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	ODNINLIFANH FOLFFAJMBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface CKNOJDGDHCI
{
	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	string OPPDFAGDKFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface LBGEALDPBNE
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPDAIBHMBBH(Action CJDOILFHDJI, bool BPAKAJAFCGA);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LIOIBBCADAP(string IEDAJGLJHNI);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int PLDLILDNDAM(string IEDAJGLJHNI, int COMAGLLDBOM);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DPNIGONKAMK([Out] bool KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JHAOPDBKPMH([Out] bool KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NDBCEFKAMCB([Out] int KKGBKLFKCPO);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface KOAJJAAMDDO
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "0")]
	void KGGJJKGMPPI(bool IOAJJAMFEKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface CBGIJFKDOCO
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid MMBIEMBBAGD;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid MDOEMHKNPKJ;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid LHPKIGMJDAD;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid HLEIPHLEKIL;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	bool OLONEJIBHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	bool EFJBEHMBJCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool EABJEANDJIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool CGDCJDBDGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x81770A0", Offset = "0x81756A0", VA = "0x1881770A0", Slot = "4")]
	string[] CGNAFKGFFNL(OLLBGKKIMKC HGJODMIHAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GKGPHOCGPMM();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8177130", Offset = "0x8175730", VA = "0x188177130", Slot = "6")]
	Guid JCAMEOAPNHO(Guid LGINNHJAHEN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int CMJENPNHAOE(OLLBGKKIMKC HGJODMIHAEL);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KGEILGNBKPH(OLLBGKKIMKC HGJODMIHAEL, NativeArray<JCONMMEJDOI> IMEGMKJBACK, NativeList<UniformTRS> IHJCKDNDKAL);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int GEABGLPMNFC(Guid PPIICOOCLEP);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NGLODJBMINO(string HDCPENAKGHI, [Out] Guid PPIICOOCLEP);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string CFECMEBCDON(Guid PPIICOOCLEP);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GMIIOLEIKCM(RRObjectPrefabData NPAOCANAKKP, [Out] LocalId DFPJIKCEODG);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LCBPMIKIJMM<byte[]> DFGKHKCFIPK(NativeArray<JCONMMEJDOI> CMMPKPJNBBM);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KGONPKIMHEI(byte[] JHPMEKDDJKA);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GameObject FHLNMBJGION(string HDCPENAKGHI);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NCLIJFHPMOJ(Transform DFOHJKCGEGI, RRObjectPrefabData BJINLKMCFNI, HPECJEKLOEK HILCMKALFIH);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool IOEPEHEMPGM(OLLBGKKIMKC HGJODMIHAEL, NativeParallelHashMap<Guid, LocalId> KEOBLBMMHFM, [Out] Exception KCNEOPLNBEN);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EONGADLAGFK(OLLBGKKIMKC HGJODMIHAEL, NativeParallelHashMap<Guid, LocalId> KEOBLBMMHFM, [Out] NativeArray<LocalId> DCGEKCKMHBF, [Out] NativeArray<LocalId> PPMJKNEDFGP, [Out] NativeArray<AuthoredLocalPoseData> KGJHEFCGCMG, Allocator HOHBLCPFIEJ);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "19")]
	void JFMLPPFFAGK(OLLBGKKIMKC MODBIBDJKOA, NativeArray<int> MKHHILLHEAP, POIJGDNEEOK<GameObject> OHJFPEKJFPC, LCBPMIKIJMM<GameObject> PELPNMONMLG, INAKHIDEGOA EAFHBCOCDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FAGNDIHCNDF();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "21")]
	void HGIKELOJLPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "22")]
	void KOLOPMPGDIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "23")]
	bool CBKMHMBHFGB(OLLBGKKIMKC HGJODMIHAEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "24")]
	IOIGEJCCPDL MIDGKCBBCIA(OLLBGKKIMKC HGJODMIHAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "25")]
	void LEIPIDJPHHC(Guid MGDNFCPIBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "26")]
	bool LGGEMACDJBL(Guid MGDNFCPIBHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x8177160", Offset = "0x8175760", VA = "0x188177160")]
	static CBGIJFKDOCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface JMCGLEHAOLI
{
	[Cpp2IlInjected.Token(Token = "0x17000073")]
	long LDHPIKAILFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	long OFKIMLAGNFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface EJDAOAHPOGO
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	bool PHFOHDOOMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool IPOEEOLGBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	int MKFPDJMEAIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	int DDDIPAHOJDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int CKBOIDCLDII
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool LCDBDBECOOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int BFOEENIPBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "6")]
	void NHOEBGCNIDB(AECMLGGEPDI GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
	void OPJHFOCJEAM(bool PEPAGCEAHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "8")]
	bool DCHELCBFLBA(PECONNHPBAN HKLGEDHKAEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "9")]
	void HNIFNCLEGMN(object INCLIAEIKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "10")]
	void EFADGJBOBFK(object INCLIAEIKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EHFMICIHOHH(Action<object> GMGCEPECBNJ);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ANOIEMFAMCL(Action<object> GMGCEPECBNJ);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "13")]
	void DCLJAEPHDOI(NativeArray<ViewId> CDGHLMKDLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "14")]
	void EIEIGFGPBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "15")]
	void JPALCMHLOPF(AILCKHEHOHJ JLPANLJHHFI, ReadOnlySpan<byte> ACJFHCNBBBO, PECONNHPBAN NOFJGJEACCI, bool KEMOCIGHHKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "16")]
	void JPALCMHLOPF(AILCKHEHOHJ JLPANLJHHFI, ReadOnlySpan<byte> GJAPBMHJHLM, bool KEMOCIGHHKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "17")]
	void JPALCMHLOPF(AILCKHEHOHJ JLPANLJHHFI, ReadOnlySpan<byte> GJAPBMHJHLM, ReadOnlySpan<byte> EDOLLPKNODF, bool KEMOCIGHHKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "18")]
	void LFDKPMNHCGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "19")]
	void KNNJKICIPFB(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "20")]
	void GHLAOADLCMC(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "21")]
	void HMKDHPPEIPM(Dictionary<object, object> ELMOEGLKFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "22")]
	void DDOACKGBGMB(NativeList<DAAPNACEHGA> FMIJONKEFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "24")]
	void KLNCAJDABPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "25")]
	void BPPHLMNKIBG(List<object> KLGCFGPCNMD, int IGHNHCKLCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "26")]
	void MKLPFCMNKOO(int MEOLDLEBKEJ, object FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "27")]
	void IFBOHDBNLNK(PECONNHPBAN HKLGEDHKAEJ, Dictionary<object, object> BKADBAJOKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "28")]
	void MPKFLLBBFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "29")]
	void APEHGOPPOMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class LCDCEIONJLK
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8185DC0", Offset = "0x81843C0", VA = "0x188185DC0")]
	public static MDGHEIIEOON BFKEBKKELHA(this EJDAOAHPOGO ILIOCACLGDN, object DKFMAIJGPFL)
	{
		return default(MDGHEIIEOON);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct MDGHEIIEOON : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EJDAOAHPOGO ILIOCACLGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object DKFMAIJGPFL;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8189340", Offset = "0x8187940", VA = "0x188189340")]
	public MDGHEIIEOON(EJDAOAHPOGO ILIOCACLGDN, object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x81892F0", Offset = "0x81878F0", VA = "0x1881892F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ACCIKKDAEHK
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate void HDMIMEDDAFF(ViewId KHKLDAJCFCJ, CJADACKPEDL BAOCIBMGJAC, int NDLIFLFKGJD);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "0")]
	void CFLDODKGCNL(HDMIMEDDAFF DHIBMENBFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "1")]
	void JPDGOONPHND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "2")]
	void KKFJFLJBGML(EFHLKFIPDPP OPFDLFBBADB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ServiceLifetime(Lifetime.Application)]
public interface LOLAHFMCJOC
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface DHGFGAGHADN
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct BHKDONEMFAF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private DHGFGAGHADN JPDEHLNKHLP;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8176AD0", Offset = "0x81750D0", VA = "0x188176AD0")]
		public BHKDONEMFAF(DHGFGAGHADN JPDEHLNKHLP, string CHFIPBCCMBD, string JPFKOMNPEPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8176A70", Offset = "0x8175070", VA = "0x188176A70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct OFBPHMMPOBI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private DHGFGAGHADN JPDEHLNKHLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task NPLKHMALANM;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x818B010", Offset = "0x8189610", VA = "0x18818B010", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "0")]
	void BOIJPMMBDPC(string CJIMOMNMAGD, float EMDIBPDBFEG = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "1")]
	void CBKJBAGKBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IMCDHDNCKNC(bool FBIJBDCICGG, string CHFIPBCCMBD, string JPFKOMNPEPB);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "3")]
	void LOCIHNBCJDC(string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class NLBPFBAAGAL
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x818A8D0", Offset = "0x8188ED0", VA = "0x18818A8D0")]
	public static DHGFGAGHADN.BHKDONEMFAF MGAGIBNOINC(this DHGFGAGHADN ILIOCACLGDN, string CHFIPBCCMBD, string JPFKOMNPEPB)
	{
		return default(DHGFGAGHADN.BHKDONEMFAF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[ServiceLifetime(Lifetime.Application)]
public interface BMOHFNAKEAO
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int EGDHNHFMEKN(GameObject KGMBEOBCDCB);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IEPGJPLKLPG(GameObject KGMBEOBCDCB);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FCDKAOHDGCL(int HKLGEDHKAEJ);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object HGMNKLOBBNO(DAHJHHJGHIB OHGBPBLOAKN, GameObject KGMBEOBCDCB, Action<DAHJHHJGHIB, int> BNOBGIHHJGL);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OBMPNGPEKIG(GameObject KGMBEOBCDCB, object APMACMLCCGL);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface COOLNKNIJHE
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DKNGDKAGHPL(NHPHNKOAKCC BHKKMKEIFKE, HLMDEMNIOLE LJAPEEGHDDO);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface LNGDKMCOOIJ
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGGJGPOGIBH(object ODCICEDDLMB, NativeList<byte> ACJFHCNBBBO);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object FJJOMODMCLM(NativeArray<byte> ACJFHCNBBBO);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface FJINECLIDEN
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool GNPEGBBGCMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate LIAGLADDOKL(NGNGIBJEHLI GLNFACGNIGJ, Action<NGNGIBJEHLI> BNOBGIHHJGL);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FIOONIDCDGL(NGNGIBJEHLI GLNFACGNIGJ, Delegate BNOBGIHHJGL);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate LKDIGAIJBNL(NGNGIBJEHLI GLNFACGNIGJ, Action<NGNGIBJEHLI> IGFPDPDEJMI);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODHJPJAIFFK(NGNGIBJEHLI GLNFACGNIGJ, Delegate BNOBGIHHJGL);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GKEDLOLAOJD(NGNGIBJEHLI GLNFACGNIGJ);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NGNGIBJEHLI PBEHPGKKHEO(GameObject KGMBEOBCDCB);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface GDFFDBGJJPC
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	int DLMKEPKAGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int KKNCPAKGPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool PHFOHDOOMGA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool GFENIBEPNED
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool GOLDCICNDAO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DAHJHHJGHIB IOLOMFADABM(int HKLGEDHKAEJ);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GEMECELGIGC(GameObject NEHHMLFLKHA, JobHandle DCPDOAFDFBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface GEKAHGJJFJJ
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DKNGDKAGHPL(int HFCJPLHKMHP, HLMDEMNIOLE MDKMHFPNICI);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
public interface BKOBJOKBLLB
{
	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool HKPMNCHNBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.Application)]
public interface CDNLMHPNODP
{
	[Cpp2IlInjected.Token(Token = "0x17000083")]
	FCDPDINJFJB JNCKENNLFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	GIELKEINIAC BDANMGKDCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool HGIHIHIAJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PNEAPOHJHLI(Transform DFOHJKCGEGI);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IAIMODNPKCN(Transform DFOHJKCGEGI, MNGEOBFFJGB OHIOLEAKKNK);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PNBMNJMIIJG(Transform DFOHJKCGEGI, CPCDDMBJLPC INCEDNPHADK);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.Application)]
public interface ODNINLIFANH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action DFMBCAPOGJK;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface DIIDGKBAPMK
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPJKJBLDEHN();
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.Application)]
public interface IJLKHABEIGI
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEPDIPBAEPB(GameObject KGMBEOBCDCB, AMAMMBOPIJC BGBOGBIPPDF, EAFLHKJFOAH GAHJDOAFNAF);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GIJIJAKHFLK(DAHJHHJGHIB OHGBPBLOAKN, bool CFBLINLGBEB, float3 JLCEKBPMACK, quaternion LPEPFBJLMLB);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ECEAJFMGOFA(IIKPNIBMDFG NIALJPGGGCM);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KJHEDJDPMHD(MFPEINJHCFE FMBOIKGHIFL, MFPEINJHCFE OKOGHNMMGGB, JGNPJEKDJKO PDFIFNAMHFC);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LMLDBMBNEEJ(MFPEINJHCFE FMBOIKGHIFL, JGNPJEKDJKO PDFIFNAMHFC);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CELDJHKHKDF(IIKPNIBMDFG BGHBLHEDMAA);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LOHLFIJDGGG(OLLBGKKIMKC KJCGEMCCGOO, ReadOnlySpan<Guid> JPADLEHEBLN, ReadOnlySpan<int> ENJJEAAAKOD, LCBPMIKIJMM<GameObject> AEGCKPDFCGK);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OAKBDJOKKOI(ODCNDAHGGBA IIMFJJALMBC);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MPIFEFBANPC(CDOCBEGMCIL MPKBHCECHEC, CDOCBEGMCIL LNBNNOJEDCA);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ODELLFCMNJD(CDOCBEGMCIL MPKBHCECHEC, CDOCBEGMCIL LNBNNOJEDCA);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct PEPPPMIEAOO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> ACJFHCNBBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle MNCGAKBHIPL;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x818BA60", Offset = "0x818A060", VA = "0x18818BA60")]
	public PEPPPMIEAOO(ReadOnlyMemory<byte> GAGIPKOCKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x818BA20", Offset = "0x818A020", VA = "0x18818BA20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum FCNBBFPMENN
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
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct OLLBGKKIMKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString LFEEEKKMHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object GFBONODGFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object JAKDLAGACLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> OKFCNEPFCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool EDHJMJFCDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public PFOLPACMFPD.DDPAEGDENPH? IAMGMIIHJGB;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x818B9A0", Offset = "0x8189FA0", VA = "0x18818B9A0")]
	public OLLBGKKIMKC(ByteString LFEEEKKMHCO, [Optional] object GFBONODGFEJ, [Optional] object JAKDLAGACLB, [Optional] IEnumerable<string> OKFCNEPFCDI, bool EDHJMJFCDEK = true, [Optional] PFOLPACMFPD.DDPAEGDENPH? IAMGMIIHJGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct DOEJAKLODLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object KKBBMCLDDHM;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct JCONMMEJDOI
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[Flags]
	public enum CCLFDPIDIFN
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
	public RRObjectPrefabData GOHHBCHHMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid NFFCEGGNLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid MIPPDCHCBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid DAGBDHPDBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid FPLFJDPGLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public CCLFDPIDIFN ENCLHPAOMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 MEAJNLNOFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int NNCJGJLNGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public PKONIMPODPH OHBGCCGBOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int OHPKLILGOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int ELJBHEEKCKO;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Guid BJBCEENKCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5370C20", Offset = "0x536F220", VA = "0x185370C20")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool BBBGIJOGLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8181680", Offset = "0x817FC80", VA = "0x188181680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool HLHANGDOBDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8181650", Offset = "0x817FC50", VA = "0x188181650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool CCELFAIHLKO
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8181660", Offset = "0x817FC60", VA = "0x188181660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool OIPDKOLGNMA
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8181670", Offset = "0x817FC70", VA = "0x188181670")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct KHBKJOMEPMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly OJACHHDEFCE BKJCDJJKAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly OJACHHDEFCE KNOCDJABJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal readonly uint AEOLBPCMOKH;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8184510", Offset = "0x8182B10", VA = "0x188184510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct IPBEEIEMBKN
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal readonly KHBKJOMEPMI CJDOILFHDJI;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x81815B0", Offset = "0x817FBB0", VA = "0x1881815B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct MBEPDNHEHHK
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly KHBKJOMEPMI CJDOILFHDJI;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x81815B0", Offset = "0x817FBB0", VA = "0x1881815B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct CBKEJGDGAGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly uint AEOLBPCMOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly bool LOOMEAFAGHC;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8177280", Offset = "0x8175880", VA = "0x188177280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct OJACHHDEFCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal int MOBKDJHFHDL;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x818B940", Offset = "0x8189F40", VA = "0x18818B940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[ServiceLifetime(Lifetime.Application)]
public interface JBAFNJFKMAA
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	PIDAMGFHPEM KAMIMBJFPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface ENKKBHFOAAM
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface POCOHMLPMHC
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class IBDIEBKOOMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3B78F20", Offset = "0x3B77520", VA = "0x183B78F20")]
	public static MFPEINJHCFE FFBGJECHHAC<T>(this T OHGBPBLOAKN) where T : ENKKBHFOAAM
	{
		return default(MFPEINJHCFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x817FBD0", Offset = "0x817E1D0", VA = "0x18817FBD0")]
	public static MonoBehaviour KMCGBKGGFNP(this ENKKBHFOAAM OHGBPBLOAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x817FB10", Offset = "0x817E110", VA = "0x18817FB10")]
	public static GameObject IOJHMLDNPHG(this ENKKBHFOAAM OHGBPBLOAKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface CEMDBHHCLBE : ENKKBHFOAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(DAHJHHJGHIB HJMEJBNHKHM);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface IODLNIJNNEC : ENKKBHFOAAM
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface ACDKDKEFMPI
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate void PEEGOFOKANI(JNIKOMMPACF IMKOEEHOPAB);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event PEEGOFOKANI PNDNJICPBCC;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface DMIKOEINGMG
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface CNJCGLHEOAD
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface JHMGFNMPOPK
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(DAHJHHJGHIB EPJCNCCHOLI);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool OFOLEHMJAEN);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IKAKINFHEGH(DAHJHHJGHIB ABGLFCMHAJA);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface FJBNCKLBPIP
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(KGNLHMPLHEM OKAAFPGDPJE);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface KGNLHMPLHEM
{
	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	GameObject KGMBEOBCDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Transform DFOHJKCGEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	KJMCALOBECF MIGKGBJEDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool FNJDFNGBGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MPMMABBGEPL(KJMCALOBECF FIAONBPCJJK);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AEHFEICJLEG GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class JJDMKAPDNDC
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8181C30", Offset = "0x8180230", VA = "0x188181C30")]
	public static void MCNFOBGCHKN(this KGNLHMPLHEM ALKKIHFIKDP, HPECJEKLOEK HILCMKALFIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface KJMCALOBECF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	Rigidbody AOLLOIANELI
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	KGNLHMPLHEM MNEFNILIAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	GameObject IOJHMLDNPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Transform BDBOCHCKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	KJMCALOBECF GCMDLKAOFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	KJMCALOBECF JOCLBAADBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	int FLLACKJMBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	bool IKAKALLGAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	bool GKEDLOLAOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	bool ICEMPBOOKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	MJAJOILNJDL KJBKCIOGHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	IPBPHKFFBLO GNCKEPNHHLA
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	float KONJLKJMJCK
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	Vector3 BFKLLHBBDEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	Vector3 CHPFEECDGGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Vector3 OEOMMCEFOBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 EHFIENHFGIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	bool EFNEMHAAIPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	bool LPKNONELLNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	bool IEPDCELLCEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	bool DEKJBEEPNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Vector3 MMIFFNNBOLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	Vector3 MAFELFPNHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	Vector3 LHHCANCPEFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	Vector3 EHHNFHGNBGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	float GMADLJBMDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	float HLGEDMHJMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Vector3 NJILMMEDHAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	Quaternion OHGPMDHLAAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	float JBIBDAIFABP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	float NFEEKMEAMML
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	bool KIMELNKGEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	CNFEEBNLJFN MGOHBGCOCLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool HLKDNGBMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	Transform EKICPBEHPHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	Vector3 OAIHMNHMDLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	float EFEHBBKPJFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	float MDMNADBPKPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	Quaternion LKJFNILHINF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	Vector3 DCMHMEMBABG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	Quaternion DMNEFDLDHJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	RigidbodyConstraints FJCAHLOMPNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	bool HEKODFAGFLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	CollisionDetectionMode EHGBNOBIOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	bool CAOKMKDOLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event IBJOPKNCPIE JOMNOEOAHNP;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event IBJOPKNCPIE LLKDGIILKLP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event IBJOPKNCPIE ADFEEMIDPKF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event IBJOPKNCPIE JIHFGAOFDPI;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event IBJOPKNCPIE KIJLJIHBNPL;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event IBJOPKNCPIE NJCIICKHHHN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event IBJOPKNCPIE PGMDFIFMFPA;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event CFAIFCIBAIO LBHMOJIBAAG;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<LNDADOOHAMM, LNDADOOHAMM> NMFJEKGGLON;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "26")]
	KJMCALOBECF IDLOPLPDGLN(int KHMHPNKMLMD);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void EEFCCNMFBOF((Quaternion rot, Vector3 moments) CGCPKONOFGF);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void JPNPNACFNCO();

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void AEFBOPMEEJD();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void EGLADLOFENO();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void CHHMHFNCKII();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void ANEGIPGNHPK();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void KNEPPBFGJJO(KJMCALOBECF KKGBKLFKCPO, bool NDGGHLKMBPJ = false);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void KNHKJJDGBFO(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void LJEPLLPMEGD(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 CKABKLDEEOE(Vector3 LMKBILFPCNN);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 LBHKOCIKHGA(Vector3 AMBPKDHGONF);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void EIFOBIMJAGC();

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void BEFPNKGEDNP();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void NKFNDPLCMBN();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void PALKGBIDBNA(Vector3 OMBFIEDHDAB, Vector3 MIBCMGLMBGC);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void NLELMACGJLN(Vector3 MGMMJFCDLHO, Vector3 FKIKANGLALM);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void EEMAPOGAEKE(Vector3 BGCEGOALDCG);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void HECHANHAPKA(JKINPDBJECI FOGGOOKDANB, Vector3 ECHOKDNKMPC, float EPGAPBLIBEP, float PNMMNFPGPCG = 8f, float AIFIBMGEPIP = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void EDLINEFOPPD(PKMLAHKLCAB FMNNFHFKKOM, Vector3 HOKDDCLKNCO, float FDOEOEDHBAF = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void ANJLPPOBDJL(PKMLAHKLCAB FMNNFHFKKOM, Vector3 CFFPEJBOBIA, float KNNDKDAPHBD = 7f, float EBHHKGCDOIB = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 JFBJCEJGNFB(Vector3 KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 EJELLMGKBFH(Vector3 KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void OCPLIMNHADO();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void MNMEHCKKGEH(KJMCALOBECF PAHOJJMFJGN, object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void CHJMGNAJNKL(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void LFELPMNNODD();

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void KIDAJKBLJEN();

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void KEBCPPFCMHF();

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool EBIFDFGHHKF();

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void OCBPHJPKKED();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void MIDNGBHBBFF(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void NEPDGGGEIHI(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void AMAMAGGPGCK(object DKFMAIJGPFL, bool PJBLBGNDEOD);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void MCGJCGPEJCK(Vector3 EDIEACHMBOE, Quaternion OKJJFLANHCE);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void FIEDHPBHGNF(Vector3 LEMEJCFGJPG, Quaternion JADFJJHPGEG);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool HJIFBALEFOM(float OKDFECFEJGM);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void IPLANBIMJAM(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void PGBMGLFPFNH(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void GHAIAGLOMLE(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void MILCNPIKOKP(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void LGJPECALCNE(Vector3 KKBNDFNEENM, ForceMode CCCAMKIFFEK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void LMFLFHEKGGA(Vector3 KKBNDFNEENM, Vector3 NHLFNDFGAHK, ForceMode CCCAMKIFFEK);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void MMLPGPOAMNO(Vector3 PNINFNAAJFD, ForceMode CCCAMKIFFEK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void FHFLJNMLPGN(Vector3 PNINFNAAJFD, ForceMode CCCAMKIFFEK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool CDEGNLJIFMN(Vector3 GJGHBLDDKFD, [Out] RaycastHit EBBBOJFKCOH, float AMEHFMMOAMH);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void ONCMLPOKMBK();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface IPBPHKFFBLO
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class IEHAGJMDHBB : IPBPHKFFBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public IEHAGJMDHBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "0")]
	void KDAOJPPDALK(Vector3 EAEILJKHFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "1")]
	void FOPCPMDPHHM(Vector3 BOPHMEPMHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "2")]
	void AJKAIELPHJI(Vector3 EAEILJKHFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "3")]
	void IFNIDLKNEFC(Vector3 BOPHMEPMHDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface MJAJOILNJDL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 FKLALKFKICC();

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 HKFLDCKPPLD();

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OOFLDNJMHOP(float BNMINBKLIME, float LFAGHDNDEOL);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate void IBJOPKNCPIE(KGNLHMPLHEM BOLCCHKGJKL);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum JBMOADNFMFD
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
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum JKINPDBJECI
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
[Cpp2IlInjected.Token(Token = "0x200005C")]
public delegate void CFAIFCIBAIO(KGNLHMPLHEM BOLCCHKGJKL, bool NDGGHLKMBPJ = false);
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum PKMLAHKLCAB
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct AEHFEICJLEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Rigidbody GPPACDEEKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public object PNENHMDGAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 FFFCNAKBILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Vector3 JAAELCGHBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public PHONBPAKPKN FFFBJJCPKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool GLNJBJKFIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool EIFANABBEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool LJOBKFECLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool AFPEFKPMBAN;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct MFPEINJHCFE : IEquatable<MFPEINJHCFE>
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly MFPEINJHCFE ENEIBJMGMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public GameObject KGMBEOBCDCB
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8189990", Offset = "0x8187F90", VA = "0x188189990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public DAAPNACEHGA AHFIPNKBHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x818A280", Offset = "0x8188880", VA = "0x18818A280")]
		get
		{
			return default(DAAPNACEHGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public DANGOHCJKPL PIDMOCBKDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x81897E0", Offset = "0x8187DE0", VA = "0x1881897E0")]
		get
		{
			return default(DANGOHCJKPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public RRObjectPrefabData MLPEPGEGAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8189E20", Offset = "0x8188420", VA = "0x188189E20")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool NNMPKHJPAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8189C00", Offset = "0x8188200", VA = "0x188189C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool IMKFIPPJGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x81897C0", Offset = "0x8187DC0", VA = "0x1881897C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool GMOMEHILPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x8189CA0", Offset = "0x81882A0", VA = "0x188189CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool MCKIODNEMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8189F50", Offset = "0x8188550", VA = "0x188189F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool FFKHMGFKMLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x8189BB0", Offset = "0x81881B0", VA = "0x188189BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool KOCMAFOKNIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8189C20", Offset = "0x8188220", VA = "0x188189C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool GLDDOBGJJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8189CC0", Offset = "0x81882C0", VA = "0x188189CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool MKHNHCMEOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8189B20", Offset = "0x8188120", VA = "0x188189B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool IMEDLHJKEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8189DA0", Offset = "0x81883A0", VA = "0x188189DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool GDICILPEMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x818A240", Offset = "0x8188840", VA = "0x18818A240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool ELAAOHDFDPM
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x8189F70", Offset = "0x8188570", VA = "0x188189F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool HFAHJFABFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8189880", Offset = "0x8187E80", VA = "0x188189880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool LIJJCKJKHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x81895F0", Offset = "0x8187BF0", VA = "0x1881895F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool KCPJNMOOIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8189DE0", Offset = "0x81883E0", VA = "0x188189DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool IPFMDAABAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x81895B0", Offset = "0x8187BB0", VA = "0x1881895B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public LNMOOOGJOAF JMEOFMMEFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(LNMOOOGJOAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public JFBNJFEFGBG CCFCFMCGCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(JFBNJFEFGBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public CLJFPDPMBGG POKMHGHAKHP
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(CLJFPDPMBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public LEDKONAKBKC LKOAKBIDCHM
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(LEDKONAKBKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public PJCHABHGKBB CLFLHLJFIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(PJCHABHGKBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public PJAKHNFACME KGGAFPONDNF
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(PJAKHNFACME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public IBPHJGNGCGN OCDHGNEGONJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(IBPHJGNGCGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public IEHKMIOJHLL NNGPLJJAAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(IEHKMIOJHLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public NOFEGPOHNMB JGNKHCEKABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(NOFEGPOHNMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public GLJBIPPBOCG IFILPLHPLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(GLJBIPPBOCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public CLNLIDOLKAA PHICMFOMNKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(CLNLIDOLKAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public ELDGNGFBGDD OGNFBEJHCGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(ELDGNGFBGDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public ADFGMPIDBCM EOEEDJFCJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(ADFGMPIDBCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public BJCKKNHMIFH CLCGFJMGEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(BJCKKNHMIFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public INLHALKHEDF GNAIGGKEBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(INLHALKHEDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool BBAJPFNKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x818A100", Offset = "0x8188700", VA = "0x18818A100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool HAOLACNMJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8189950", Offset = "0x8187F50", VA = "0x188189950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool AEFBMHDNENH
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x818A080", Offset = "0x8188680", VA = "0x18818A080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool FMHHEEPBJPF
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8189490", Offset = "0x8187A90", VA = "0x188189490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool JCHEKFHBHOC
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x81894D0", Offset = "0x8187AD0", VA = "0x1881894D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public bool JHGEKKEKPBC
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8189630", Offset = "0x8187C30", VA = "0x188189630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool GLMMOOMOPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x818A0C0", Offset = "0x81886C0", VA = "0x18818A0C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public JLCPCGEONCF BDBOCHCKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(JLCPCGEONCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public LFHOBEDMLBM EJLDIIMBBEB
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(LFHOBEDMLBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private NNEPMGCDLOI LOJJBHPCFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8176280", Offset = "0x8174880", VA = "0x188176280")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
	public static MFPEINJHCFE EIMKEBEILPD(DAHJHHJGHIB HJMEJBNHKHM)
	{
		return default(MFPEINJHCFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8189FB0", Offset = "0x81885B0", VA = "0x188189FB0")]
	public HHDOFEGIBLL MENJFLEPGMG()
	{
		return default(HHDOFEGIBLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8189BD0", Offset = "0x81881D0", VA = "0x188189BD0")]
	public FEGLIOCJLOM GEMOBEDFKPK()
	{
		return default(FEGLIOCJLOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x818A1F0", Offset = "0x81887F0", VA = "0x18818A1F0")]
	public MCPNENGPNBG OLPADIJIDPF()
	{
		return default(MCPNENGPNBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x81894A0", Offset = "0x8187AA0", VA = "0x1881894A0")]
	public KNANKAMACPN AMHNNCPHFJP()
	{
		return default(KNANKAMACPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8189C50", Offset = "0x8188250", VA = "0x188189C50")]
	public EIGOGPNGBIO IDMKIMNAKKI()
	{
		return default(EIGOGPNGBIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8189670", Offset = "0x8187C70", VA = "0x188189670")]
	public NFHCJGHJPEJ ECOEPKEMKBO()
	{
		return default(NFHCJGHJPEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x818A030", Offset = "0x8188630", VA = "0x18818A030")]
	public CDOCBEGMCIL MMDBDCENIHI()
	{
		return default(CDOCBEGMCIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8189B60", Offset = "0x8188160", VA = "0x188189B60")]
	public OHOPBFKNLMM FNPADIGOOAD()
	{
		return default(OHOPBFKNLMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x81896C0", Offset = "0x8187CC0", VA = "0x1881896C0")]
	public void EDCIKKJKNPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x8189510", Offset = "0x8187B10", VA = "0x188189510")]
	public void BNBAOKNGOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x8189D00", Offset = "0x8188300", VA = "0x188189D00")]
	public bool IPHNNENCBFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x818A320", Offset = "0x8188920", VA = "0x18818A320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public MFPEINJHCFE(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x817B010", Offset = "0x8179610", VA = "0x18817B010")]
	public static bool EIMKEBEILPD(MFPEINJHCFE KKGBKLFKCPO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
	public static DAHJHHJGHIB EIMKEBEILPD(MFPEINJHCFE KKGBKLFKCPO)
	{
		return default(DAHJHHJGHIB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x8178190", Offset = "0x8176790", VA = "0x188178190")]
	public static bool JKIBMILPCGE(MFPEINJHCFE DLGEPLKGJOC, MFPEINJHCFE OKKFDNDPGLP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x8178060", Offset = "0x8176660", VA = "0x188178060")]
	public static bool FLMCEAOBGCC(MFPEINJHCFE DLGEPLKGJOC, MFPEINJHCFE OKKFDNDPGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x81898C0", Offset = "0x8187EC0", VA = "0x1881898C0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(MFPEINJHCFE HOPHFOOKMCC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct ADFGMPIDBCM : IEquatable<ADFGMPIDBCM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private PKDNDBENIKM LBLALIEAEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x81751B0", Offset = "0x81737B0", VA = "0x1881751B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8174E90", Offset = "0x8173490", VA = "0x188174E90")]
	public void ALHHHCOIFHH(uint HLIPPIOIAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8174FA0", Offset = "0x81735A0", VA = "0x188174FA0")]
	public bool ALMKJMLHPNM([Out] uint HLIPPIOIAJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x81752C0", Offset = "0x81738C0", VA = "0x1881752C0")]
	public bool FBLAICLKKHB([Out] uint HLIPPIOIAJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8175610", Offset = "0x8173C10", VA = "0x188175610")]
	public void PJEDJAOMCAC(string HLIPPIOIAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x81750A0", Offset = "0x81736A0", VA = "0x1881750A0")]
	[CanBeNull]
	public string CFELLLNODDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8175490", Offset = "0x8173A90", VA = "0x188175490")]
	public bool MOFIABIIBCF([Out] string JLEDBPIFFKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x81753F0", Offset = "0x81739F0", VA = "0x1881753F0")]
	public void KOAIPOAMPEK(string JLEDBPIFFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public ADFGMPIDBCM(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8175230", Offset = "0x8173830", VA = "0x188175230", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(ADFGMPIDBCM HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct LNMOOOGJOAF : IEquatable<LNMOOOGJOAF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	private FOKLIOBGGNN CECGBFBFDNH
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x81878D0", Offset = "0x8185ED0", VA = "0x1881878D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private PKDNDBENIKM KIJEAHMEMEN
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8187D10", Offset = "0x8186310", VA = "0x188187D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool ANFDONJGCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x81875D0", Offset = "0x8185BD0", VA = "0x1881875D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool PKBOEDGNCPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8187760", Offset = "0x8185D60", VA = "0x188187760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public bool ODKPLIBFFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8187D70", Offset = "0x8186370", VA = "0x188187D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Guid AMHCNFCENEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8187660", Offset = "0x8185C60", VA = "0x188187660")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Guid EILGIDGBNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x81876E0", Offset = "0x8185CE0", VA = "0x1881876E0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Guid MACHLFAKBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8187E30", Offset = "0x8186430", VA = "0x188187E30")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public LFHOBEDMLBM EJLDIIMBBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(LFHOBEDMLBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x8187830", Offset = "0x8185E30", VA = "0x188187830")]
	public bool HALPLKPFEML([Out] Guid CIKIEGMNCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x8187A50", Offset = "0x8186050", VA = "0x188187A50")]
	public bool JANPIOEHPJC([Out] Guid OEEANCBNNKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x8187930", Offset = "0x8185F30", VA = "0x188187930")]
	public void IJKBJEDDBJA(Guid FADBOFNILPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x8187C10", Offset = "0x8186210", VA = "0x188187C10")]
	public void MDLCJKEKCCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8187AF0", Offset = "0x81860F0", VA = "0x188187AF0")]
	public Guid JFHNLFBIHEC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public LNMOOOGJOAF(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x81877A0", Offset = "0x8185DA0", VA = "0x1881877A0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(LNMOOOGJOAF HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct MCPNENGPNBG : IEquatable<MCPNENGPNBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	private EGNFIJCEPIJ OBDGIGMNIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8188C80", Offset = "0x8187280", VA = "0x188188C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Vector3 MPNIKABKBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x81888A0", Offset = "0x8186EA0", VA = "0x1881888A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public Quaternion FAEDPGGDNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8188760", Offset = "0x8186D60", VA = "0x188188760")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public MFPEINJHCFE NGNLHDMIOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8188CE0", Offset = "0x81872E0", VA = "0x188188CE0")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x8188BB0", Offset = "0x81871B0", VA = "0x188188BB0")]
	public IIKPNIBMDFG JKBDPGPLEPJ(Allocator HOHBLCPFIEJ)
	{
		return default(IIKPNIBMDFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x81883D0", Offset = "0x81869D0", VA = "0x1881883D0")]
	public bool APAPDBBCLPE(MFPEINJHCFE NBIJLPJHNNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x8188610", Offset = "0x8186C10", VA = "0x188188610")]
	public void FKKGFLPBNNB(Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x8188470", Offset = "0x8186A70", VA = "0x188188470")]
	public void BGMBBFGIMBD(float HKINPNLCPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x81889F0", Offset = "0x8186FF0", VA = "0x1881889F0")]
	public void JJJDKKJIDKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public MCPNENGPNBG(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x817B010", Offset = "0x8179610", VA = "0x18817B010")]
	public static bool EIMKEBEILPD(MCPNENGPNBG KKGBKLFKCPO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
	public static DAHJHHJGHIB EIMKEBEILPD(MCPNENGPNBG KKGBKLFKCPO)
	{
		return default(DAHJHHJGHIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x8188580", Offset = "0x8186B80", VA = "0x188188580", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(MCPNENGPNBG HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct HHDOFEGIBLL : IEquatable<HHDOFEGIBLL>
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly HHDOFEGIBLL ENEIBJMGMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private KGOKLMGHDGG POCGJGHCONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x817F180", Offset = "0x817D780", VA = "0x18817F180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<MFPEINJHCFE> OOOMLMJLCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x817F080", Offset = "0x817D680", VA = "0x18817F080")]
		get
		{
			return default(Span<MFPEINJHCFE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x817EEF0", Offset = "0x817D4F0", VA = "0x18817EEF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x817F000", Offset = "0x817D600", VA = "0x18817F000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public JLCPCGEONCF BDBOCHCKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(JLCPCGEONCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public LFHOBEDMLBM EJLDIIMBBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(LFHOBEDMLBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x817EA50", Offset = "0x817D050", VA = "0x18817EA50")]
	public void DEAJAKFLAKC(HHDOFEGIBLL HOPHFOOKMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public HHDOFEGIBLL(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x817B010", Offset = "0x8179610", VA = "0x18817B010")]
	public static bool EIMKEBEILPD(HHDOFEGIBLL KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x817EF70", Offset = "0x817D570", VA = "0x18817EF70", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(HHDOFEGIBLL HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
	public static MFPEINJHCFE EIMKEBEILPD(HHDOFEGIBLL PIKMBNLEPPK)
	{
		return default(MFPEINJHCFE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DefaultMember("Item")]
public struct POGNEKBDLPJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Dictionary<int, object> DIJLOLAHCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private MKDDAEOLBJB NLCEPAJBDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool CDOBNCPPFGA;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		[CompilerGenerated]
		readonly get
		{
			return default(MFPEINJHCFE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public OPHHBGNDGBE FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x818D550", Offset = "0x818BB50", VA = "0x18818D550")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x818D7B0", Offset = "0x818BDB0", VA = "0x18818D7B0")]
	internal POGNEKBDLPJ(MFPEINJHCFE ODCICEDDLMB, bool CDOBNCPPFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x818D610", Offset = "0x818BC10", VA = "0x18818D610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x3D05970", Offset = "0x3D03F70", VA = "0x183D05970")]
	public void ALNKNOEKMHL<T>(OPHHBGNDGBE BLIBAMJKLIA, T KKGBKLFKCPO, [Optional] T COMAGLLDBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x818D4A0", Offset = "0x818BAA0", VA = "0x18818D4A0")]
	public void BAFGFGCDOJB(OPHHBGNDGBE BLIBAMJKLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0xE5FAD0", Offset = "0xE5E0D0", VA = "0x180E5FAD0")]
	public Dictionary<int, object> MAHAFKGPDCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x818D740", Offset = "0x818BD40", VA = "0x18818D740")]
	private readonly void KGIEHDNPABP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class MCBEPFBPBCA
{
	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x8188310", Offset = "0x8186910", VA = "0x188188310")]
	public static POGNEKBDLPJ APICEOOGHHC(this MFPEINJHCFE ODCICEDDLMB)
	{
		return default(POGNEKBDLPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct BJCKKNHMIFH : IEquatable<BJCKKNHMIFH>
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly BJCKKNHMIFH ENEIBJMGMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private bool ELAAOHDFDPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8176E00", Offset = "0x8175400", VA = "0x188176E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 HLAPAMOHCCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x8176E40", Offset = "0x8175440", VA = "0x188176E40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x8176BF0", Offset = "0x81751F0", VA = "0x188176BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8176EF0", Offset = "0x81754F0", VA = "0x188176EF0")]
	public Vector3 LIBCPLJFCCO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x8176CD0", Offset = "0x81752D0", VA = "0x188176CD0")]
	public void JIGDEHNMFON([In] Vector3 KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x8176C50", Offset = "0x8175250", VA = "0x188176C50")]
	public void JAGFNGIJOFO([In] Vector3 KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x8176D50", Offset = "0x8175350", VA = "0x188176D50")]
	public bool KLADAFAELPM([In] Vector3 KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public BJCKKNHMIFH(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x8176B60", Offset = "0x8175160", VA = "0x188176B60", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(BJCKKNHMIFH HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x8176F70", Offset = "0x8175570", VA = "0x188176F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct KEPECIJMAIH : IEquatable<KEPECIJMAIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8184480", Offset = "0x8182A80", VA = "0x188184480", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(KEPECIJMAIH HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct OHOPBFKNLMM : IEquatable<OHOPBFKNLMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private OEIFJNJODNF DBBCHBDKIDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x818B2C0", Offset = "0x81898C0", VA = "0x18818B2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool NFGPEIGNMAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x818B190", Offset = "0x8189790", VA = "0x18818B190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool LBHAFDHMLOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x818B490", Offset = "0x8189A90", VA = "0x18818B490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public CAEJLDNLONB OFLKCMNIJBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x818B060", Offset = "0x8189660", VA = "0x18818B060")]
		get
		{
			return default(CAEJLDNLONB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool EHFGDKGCPNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x818B3C0", Offset = "0x81899C0", VA = "0x18818B3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool ADJKDDBEPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x818B5C0", Offset = "0x8189BC0", VA = "0x18818B5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool JIOOMPBAJHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x818B8B0", Offset = "0x8189EB0", VA = "0x18818B8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x818B810", Offset = "0x8189E10", VA = "0x18818B810")]
	public bool NILHJOHNIGH(OHOPBFKNLMM DLOILBMFNEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x818B320", Offset = "0x8189920", VA = "0x18818B320")]
	public bool ECBNPFGLONJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x818B770", Offset = "0x8189D70", VA = "0x18818B770")]
	public bool NDCAOANFGLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x818B650", Offset = "0x8189C50", VA = "0x18818B650")]
	public ReadOnlySpan<DAHJHHJGHIB> LKBABNCFOEL()
	{
		return default(ReadOnlySpan<DAHJHHJGHIB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public OHOPBFKNLMM(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8178190", Offset = "0x8176790", VA = "0x188178190")]
	public static bool JKIBMILPCGE(OHOPBFKNLMM DLGEPLKGJOC, OHOPBFKNLMM OKKFDNDPGLP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x8178060", Offset = "0x8176660", VA = "0x188178060")]
	public static bool FLMCEAOBGCC(OHOPBFKNLMM DLGEPLKGJOC, OHOPBFKNLMM OKKFDNDPGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x818B400", Offset = "0x8189A00", VA = "0x18818B400", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(OHOPBFKNLMM HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct CDOCBEGMCIL : IEquatable<CDOCBEGMCIL>
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly CDOCBEGMCIL ENEIBJMGMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private OEIFJNJODNF KOHOONDAPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8177F70", Offset = "0x8176570", VA = "0x188177F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public bool JMAOHJDMMGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8177F10", Offset = "0x8176510", VA = "0x188177F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public JLCPCGEONCF BDBOCHCKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(JLCPCGEONCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8178280", Offset = "0x8176880", VA = "0x188178280")]
	public bool NILHJOHNIGH(CDOCBEGMCIL HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x81780F0", Offset = "0x81766F0", VA = "0x1881780F0")]
	public bool JBFHJMFJOEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x81781A0", Offset = "0x81767A0", VA = "0x1881781A0")]
	public bool JLPCCNLFLKF([Out] CDOCBEGMCIL EGNKPFJJPNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x8178080", Offset = "0x8176680", VA = "0x188178080")]
	public void IKEKIEEAOEG(FJDEBDGOFDG MGNCINIDNEO, bool OEJKHGFMKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public CDOCBEGMCIL(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8178190", Offset = "0x8176790", VA = "0x188178190")]
	public static bool JKIBMILPCGE(CDOCBEGMCIL DLGEPLKGJOC, CDOCBEGMCIL OKKFDNDPGLP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8178060", Offset = "0x8176660", VA = "0x188178060")]
	public static bool FLMCEAOBGCC(CDOCBEGMCIL DLGEPLKGJOC, CDOCBEGMCIL OKKFDNDPGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8177FD0", Offset = "0x81765D0", VA = "0x188177FD0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(CDOCBEGMCIL HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct LFHOBEDMLBM : IEquatable<LFHOBEDMLBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	private KGOKLMGHDGG POCGJGHCONH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x81868D0", Offset = "0x8184ED0", VA = "0x1881868D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public DAHJHHJGHIB PLIHJDCLCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x81860C0", Offset = "0x81846C0", VA = "0x1881860C0")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public MFPEINJHCFE GCMDLKAOFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x81862F0", Offset = "0x81848F0", VA = "0x1881862F0")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public MFPEINJHCFE JOCLBAADBME
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x8186480", Offset = "0x8184A80", VA = "0x188186480")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x81866D0", Offset = "0x8184CD0", VA = "0x1881866D0")]
	public Span<MFPEINJHCFE> LNCLFPLPDDD()
	{
		return default(Span<MFPEINJHCFE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x81867D0", Offset = "0x8184DD0", VA = "0x1881867D0")]
	public Span<MFPEINJHCFE> OFIBALCLGPD()
	{
		return default(Span<MFPEINJHCFE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x8186930", Offset = "0x8184F30", VA = "0x188186930")]
	public Span<MFPEINJHCFE> PKDIHJFNACG()
	{
		return default(Span<MFPEINJHCFE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x8186380", Offset = "0x8184980", VA = "0x188186380")]
	public Span<MFPEINJHCFE> GPFACMLIGAH()
	{
		return default(Span<MFPEINJHCFE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x81865A0", Offset = "0x8184BA0", VA = "0x1881865A0")]
	public bool KNEPPBFGJJO(MFPEINJHCFE NBIJLPJHNNE, bool GLFOCMLGNBC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x8186A30", Offset = "0x8185030", VA = "0x188186A30")]
	public bool PKPKLKHCFJK(MFPEINJHCFE GPPFMBFLIBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x81861E0", Offset = "0x81847E0", VA = "0x1881861E0")]
	public MFPEINJHCFE GLLGBCAANBL(uint KANAABFHOGN)
	{
		return default(MFPEINJHCFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x8186510", Offset = "0x8184B10", VA = "0x188186510")]
	public HHDOFEGIBLL HKGMOILLPKE()
	{
		return default(HHDOFEGIBLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public LFHOBEDMLBM(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x817B010", Offset = "0x8179610", VA = "0x18817B010")]
	public static bool EIMKEBEILPD(LFHOBEDMLBM KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x8186150", Offset = "0x8184750", VA = "0x188186150", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(LFHOBEDMLBM HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct JFBNJFEFGBG : IEquatable<JFBNJFEFGBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public string KNEGKBBPKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8181AE0", Offset = "0x81800E0", VA = "0x188181AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public string DKNHIMCKNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8181A70", Offset = "0x8180070", VA = "0x188181A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public string BFHFDKLBGNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x81819C0", Offset = "0x817FFC0", VA = "0x1881819C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public string DPHHOPKOPLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8181690", Offset = "0x817FC90", VA = "0x188181690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x8181B70", Offset = "0x8180170", VA = "0x188181B70")]
	public bool MOFIABIIBCF([Out] string JLEDBPIFFKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public JFBNJFEFGBG(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x8181930", Offset = "0x817FF30", VA = "0x188181930", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(JFBNJFEFGBG HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct LENKCGDHCJI : IEquatable<LENKCGDHCJI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x8186030", Offset = "0x8184630", VA = "0x188186030", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(LENKCGDHCJI HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct ANMNJDAJDFJ : IEquatable<ANMNJDAJDFJ>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[Flags]
	public enum IHIDBPONHFJ
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
	private static LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly ANMNJDAJDFJ ENEIBJMGMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private NNEPMGCDLOI LOJJBHPCFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8176280", Offset = "0x8174880", VA = "0x188176280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8175DC0", Offset = "0x81743C0", VA = "0x188175DC0")]
	public static IHIDBPONHFJ BCEKCGPODFI(ANMNJDAJDFJ DLGEPLKGJOC, ANMNJDAJDFJ OKKFDNDPGLP)
	{
		return default(IHIDBPONHFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8175890", Offset = "0x8173E90", VA = "0x188175890")]
	public bool ALKPIFGMALJ([Out] GameObject NBIJLPJHNNE, [Out] GameObject KGMBEOBCDCB, [Out] MFPEINJHCFE ECBGJFILJAH, [Out] MFPEINJHCFE JLHCLAMHMLL, [Out] Vector3 NHLFNDFGAHK, [Out] Vector3 KGLAFNDAAGH, [Out] Vector3 MKIKEEPMGNE, [Out] MFPEINJHCFE GBMAPNBNOKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8175FE0", Offset = "0x81745E0", VA = "0x188175FE0")]
	public bool CCJFHBIIPEA([Out] GameObject NBIJLPJHNNE, [Out] GameObject KGMBEOBCDCB, [Out] MFPEINJHCFE ECBGJFILJAH, [Out] MFPEINJHCFE JLHCLAMHMLL, [Out] Vector3 NHLFNDFGAHK, [Out] Vector3 KGLAFNDAAGH, [Out] Vector3 MKIKEEPMGNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x81762E0", Offset = "0x81748E0", VA = "0x1881762E0")]
	private void OMFHFMJEKPM(Entity DFPJIKCEODG, EntityManager OLDJKBMGNFC, MagneticAnchorData JEMKAMNMOFA, [Out] GameObject NBIJLPJHNNE, [Out] GameObject KGMBEOBCDCB, [Out] MFPEINJHCFE ECBGJFILJAH, [Out] MFPEINJHCFE JLHCLAMHMLL, [Out] Vector3 NHLFNDFGAHK, [Out] Vector3 KGLAFNDAAGH, [Out] Vector3 MKIKEEPMGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public ANMNJDAJDFJ(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x81761F0", Offset = "0x81747F0", VA = "0x1881761F0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(ANMNJDAJDFJ HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x81766A0", Offset = "0x8174CA0", VA = "0x1881766A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct MPLONMAOKGD : IEquatable<MPLONMAOKGD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x818A620", Offset = "0x8188C20", VA = "0x18818A620", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(MPLONMAOKGD HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct INLHALKHEDF : IEquatable<INLHALKHEDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private BPELKFMMEGF KOHOONDAPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x81810E0", Offset = "0x817F6E0", VA = "0x1881810E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public OBIGOCAPOLO IMPLNDBOMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8181400", Offset = "0x817FA00", VA = "0x188181400")]
		get
		{
			return default(OBIGOCAPOLO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8181560", Offset = "0x817FB60", VA = "0x188181560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public LCBPMIKIJMM<string> NAPNODECBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x81812F0", Offset = "0x817F8F0", VA = "0x1881812F0")]
		get
		{
			return default(LCBPMIKIJMM<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8181140", Offset = "0x817F740", VA = "0x188181140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public LCBPMIKIJMM<string> NEHHMGIPMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x8180FC0", Offset = "0x817F5C0", VA = "0x188180FC0")]
		get
		{
			return default(LCBPMIKIJMM<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x8181440", Offset = "0x817FA40", VA = "0x188181440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public INLHALKHEDF(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x8181260", Offset = "0x817F860", VA = "0x188181260", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(INLHALKHEDF HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct CLJFPDPMBGG : IEquatable<CLJFPDPMBGG>
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly ComponentTypes HBCDAKPNEEF;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly CLJFPDPMBGG ENEIBJMGMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public Collider LNBODJIBDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8178EA0", Offset = "0x81774A0", VA = "0x188178EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public JHCNKNHMPMK LGMBFNJGPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8178DD0", Offset = "0x81773D0", VA = "0x188178DD0")]
		get
		{
			return default(JHCNKNHMPMK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8178CB0", Offset = "0x81772B0", VA = "0x188178CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public KPMCCJPJMLK HCJNMCKIOFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8179060", Offset = "0x8177660", VA = "0x188179060")]
		get
		{
			return default(KPMCCJPJMLK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8178C60", Offset = "0x8177260", VA = "0x188178C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public AIANJGLPPCP PMAIOHOGALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8178790", Offset = "0x8176D90", VA = "0x188178790")]
		get
		{
			return default(AIANJGLPPCP);
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8178D80", Offset = "0x8177380", VA = "0x188178D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float KFCLALMAAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8178E60", Offset = "0x8177460", VA = "0x188178E60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8178E10", Offset = "0x8177410", VA = "0x188178E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public bool DKPJGDPBMFC
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8178FF0", Offset = "0x81775F0", VA = "0x188178FF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x81794C0", Offset = "0x8177AC0", VA = "0x1881794C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public bool MAKCCLBHMCA
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8178D00", Offset = "0x8177300", VA = "0x188178D00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8179560", Offset = "0x8177B60", VA = "0x188179560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public bool ECLCDIONIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8179440", Offset = "0x8177A40", VA = "0x188179440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x8178870", Offset = "0x8176E70", VA = "0x188178870")]
	public static bool DIOMNBNGIOP(MFPEINJHCFE BIKPNIDLFNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x8179100", Offset = "0x8177700", VA = "0x188179100")]
	public static bool MGMGGGDLPBE(MFPEINJHCFE BIKPNIDLFNI, [Out] CLJFPDPMBGG NMFIGDMCDGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8178A70", Offset = "0x8177070", VA = "0x188178A70")]
	public bool ECBBLMCKOIL([Out] JHMGFNMPOPK DDEHFNFBNGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8179350", Offset = "0x8177950", VA = "0x188179350")]
	public bool MLGDJLNEICK([Out] DAHJHHJGHIB CMAFOEIBEKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x81790A0", Offset = "0x81776A0", VA = "0x1881790A0")]
	public bool MCOJFILDFNA(HMMDHBIHKAK MGNCINIDNEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8179600", Offset = "0x8177C00", VA = "0x188179600")]
	public void PNGNJAEHIOH(HMMDHBIHKAK MGNCINIDNEO, bool IKCKHHEBILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x81787D0", Offset = "0x8176DD0", VA = "0x1881787D0")]
	public void CLKFNNGGHNO(HMMDHBIHKAK MGNCINIDNEO, bool IKCKHHEBILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public CLJFPDPMBGG(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x8178BD0", Offset = "0x81771D0", VA = "0x188178BD0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(CLJFPDPMBGG HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8179680", Offset = "0x8177C80", VA = "0x188179680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct KNANKAMACPN : IEquatable<KNANKAMACPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool FIIBHGFJBMD
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8185D70", Offset = "0x8184370", VA = "0x188185D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public KNANKAMACPN(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8185CE0", Offset = "0x81842E0", VA = "0x188185CE0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(KNANKAMACPN HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct LEDKONAKBKC : IEquatable<LEDKONAKBKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private HGPGBOJCIDN NMCABOIBEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x8185E50", Offset = "0x8184450", VA = "0x188185E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x8185F40", Offset = "0x8184540", VA = "0x188185F40")]
	public void OIDNHBLEIEJ(bool LBLAAHJBLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public LEDKONAKBKC(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x8185EB0", Offset = "0x81844B0", VA = "0x188185EB0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(LEDKONAKBKC HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct EIGOGPNGBIO : IEquatable<EIGOGPNGBIO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	private EEALEHMMMJI ODLKJCNHOLO
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x817C2D0", Offset = "0x817A8D0", VA = "0x18817C2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public OBIGOCAPOLO FJNPCBIBLHO
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x817BD40", Offset = "0x817A340", VA = "0x18817BD40")]
		get
		{
			return default(OBIGOCAPOLO);
		}
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x817C000", Offset = "0x817A600", VA = "0x18817C000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public bool BDMCBOCFEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x817BCB0", Offset = "0x817A2B0", VA = "0x18817BCB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x817C110", Offset = "0x817A710", VA = "0x18817C110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public LCBPMIKIJMM<string> DIJOHDKPIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x817B710", Offset = "0x8179D10", VA = "0x18817B710")]
		get
		{
			return default(LCBPMIKIJMM<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x817BA70", Offset = "0x817A070", VA = "0x18817BA70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public LCBPMIKIJMM<string> NJIHHHCOPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x817BEE0", Offset = "0x817A4E0", VA = "0x18817BEE0")]
		get
		{
			return default(LCBPMIKIJMM<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x817B560", Offset = "0x8179B60", VA = "0x18817B560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public LCBPMIKIJMM<string> HKMOKKLALNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x817C1B0", Offset = "0x817A7B0", VA = "0x18817C1B0")]
		get
		{
			return default(LCBPMIKIJMM<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x817BB90", Offset = "0x817A190", VA = "0x18817BB90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public LCBPMIKIJMM<string> NBPGOCDFNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x817B830", Offset = "0x8179E30", VA = "0x18817B830")]
		get
		{
			return default(LCBPMIKIJMM<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x817B950", Offset = "0x8179F50", VA = "0x18817B950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x817BE40", Offset = "0x817A440", VA = "0x18817BE40")]
	public bool MIOPFNHMKMM(DAHJHHJGHIB OPOGJMFOAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public EIGOGPNGBIO(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
	public static DAHJHHJGHIB EIMKEBEILPD(EIGOGPNGBIO KKGBKLFKCPO)
	{
		return default(DAHJHHJGHIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x817B680", Offset = "0x8179C80", VA = "0x18817B680", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(EIGOGPNGBIO HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct PJCHABHGKBB : IEquatable<PJCHABHGKBB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public bool FANICGFBLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x818C660", Offset = "0x818AC60", VA = "0x18818C660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public bool MNGANHFDJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x818D040", Offset = "0x818B640", VA = "0x18818D040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool KGMIJKDODDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x818D1F0", Offset = "0x818B7F0", VA = "0x18818D1F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x818CC50", Offset = "0x818B250", VA = "0x18818CC50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool IBILOALCADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x818CF00", Offset = "0x818B500", VA = "0x18818CF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool EOBGCPMDDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x818D450", Offset = "0x818BA50", VA = "0x18818D450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool IHCOJHIIPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x818CA30", Offset = "0x818B030", VA = "0x18818CA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public bool MHLACFOBBJL
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x818CEB0", Offset = "0x818B4B0", VA = "0x18818CEB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public bool DAEEBMOFIGE
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x818D090", Offset = "0x818B690", VA = "0x18818D090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool HHHODBCPNIB
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x818D190", Offset = "0x818B790", VA = "0x18818D190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool JKFNJOHIAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x818C9E0", Offset = "0x818AFE0", VA = "0x18818C9E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool IFFGKAIPFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x818C6E0", Offset = "0x818ACE0", VA = "0x18818C6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool NDOPNCLJBEI
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x818D0E0", Offset = "0x818B6E0", VA = "0x18818D0E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool JMMJHDNNFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x818CC00", Offset = "0x818B200", VA = "0x18818CC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool HDLMPGEMHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x818CCD0", Offset = "0x818B2D0", VA = "0x18818CCD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x818D130", Offset = "0x818B730", VA = "0x18818D130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool CGNFDDMGOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x818C990", Offset = "0x818AF90", VA = "0x18818C990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public FKDFLMOGDKH MPJMCKIJMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x818C730", Offset = "0x818AD30", VA = "0x18818C730")]
		get
		{
			return default(FKDFLMOGDKH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x818CBB0", Offset = "0x818B1B0", VA = "0x18818CBB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool JAPMBDOLCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x818C770", Offset = "0x818AD70", VA = "0x18818C770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public EAFLHKJFOAH AGAAAPHOJHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x818CD10", Offset = "0x818B310", VA = "0x18818CD10")]
		get
		{
			return default(EAFLHKJFOAH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x818CB60", Offset = "0x818B160", VA = "0x18818CB60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public bool INFGMMIOOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x818C6A0", Offset = "0x818ACA0", VA = "0x18818C6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 NKJEBKAJDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x818CD50", Offset = "0x818B350", VA = "0x18818CD50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 GJMFOKNBKCK
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x818C890", Offset = "0x818AE90", VA = "0x18818C890")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public bool JNLANHCMEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x818D240", Offset = "0x818B840", VA = "0x18818D240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public bool BEBBIONNHFM
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x818CF50", Offset = "0x818B550", VA = "0x18818CF50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	private EntityManager OAIANGGCCHK
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x818D1E0", Offset = "0x818B7E0", VA = "0x18818D1E0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x818CC70", Offset = "0x818B270", VA = "0x18818CC70")]
	public bool HDNJIKJEJLB(JNOPLLKMAJD MGNCINIDNEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x818CE20", Offset = "0x818B420", VA = "0x18818CE20")]
	public void IPMHCFBALDH(JNOPLLKMAJD MGNCINIDNEO, bool IKCKHHEBILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x818CDD0", Offset = "0x818B3D0", VA = "0x18818CDD0")]
	public bool IOHCHPOHHMJ(AMAMMBOPIJC MGNCINIDNEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x818C910", Offset = "0x818AF10", VA = "0x18818C910")]
	public void DCLIAFDECBB(AMAMMBOPIJC MGNCINIDNEO, bool IKCKHHEBILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x818D410", Offset = "0x818BA10", VA = "0x18818D410")]
	public AMAMMBOPIJC OEMECFAKOKD()
	{
		return default(AMAMMBOPIJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x818CA80", Offset = "0x818B080", VA = "0x18818CA80")]
	public bool EPFCPGJCEIC(AMAMMBOPIJC KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public PJCHABHGKBB(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x818CAD0", Offset = "0x818B0D0", VA = "0x18818CAD0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(PJCHABHGKBB HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct PJAKHNFACME : IEquatable<PJAKHNFACME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	private OPONHEPPMGD CIGKBIOIGND
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x818C1E0", Offset = "0x818A7E0", VA = "0x18818C1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x818BD30", Offset = "0x818A330", VA = "0x18818BD30")]
	public bool CKMGOKLMCOE(JGNPJEKDJKO PDFIFNAMHFC, List<MFPEINJHCFE> JMMJIFKPGAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x818C4A0", Offset = "0x818AAA0", VA = "0x18818C4A0")]
	public int NMOCCCPFBGL(JGNPJEKDJKO PDFIFNAMHFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x818C0D0", Offset = "0x818A6D0", VA = "0x18818C0D0")]
	public void IJANINCCPDN(List<MFPEINJHCFE> JMMJIFKPGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x818BF10", Offset = "0x818A510", VA = "0x18818BF10")]
	public int EFKJNNOOGEF(MFPEINJHCFE OKOGHNMMGGB, JGNPJEKDJKO PDFIFNAMHFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x818C370", Offset = "0x818A970", VA = "0x18818C370")]
	public MFPEINJHCFE NCIENKJAABH(int KHMHPNKMLMD, JGNPJEKDJKO PDFIFNAMHFC)
	{
		return default(MFPEINJHCFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x818C240", Offset = "0x818A840", VA = "0x18818C240")]
	public void JCFKLEJINMN(MFPEINJHCFE OKOGHNMMGGB, JGNPJEKDJKO PDFIFNAMHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x818C5B0", Offset = "0x818ABB0", VA = "0x18818C5B0")]
	public bool PPPMFNOMPHM(MFPEINJHCFE OKOGHNMMGGB, JGNPJEKDJKO PDFIFNAMHFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x818BB10", Offset = "0x818A110", VA = "0x18818BB10")]
	public void AIFOILDPLKE(JGNPJEKDJKO PDFIFNAMHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x818BE60", Offset = "0x818A460", VA = "0x18818BE60")]
	public bool DHHAFAMAGOB(MFPEINJHCFE OKOGHNMMGGB, JGNPJEKDJKO PDFIFNAMHFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x818BC20", Offset = "0x818A220", VA = "0x18818BC20")]
	public bool BOMCJIDFNAG(JGNPJEKDJKO PDFIFNAMHFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public PJAKHNFACME(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x818C040", Offset = "0x818A640", VA = "0x18818C040", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(PJAKHNFACME HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct IBPHJGNGCGN : IEquatable<IBPHJGNGCGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x817FCE0", Offset = "0x817E2E0", VA = "0x18817FCE0")]
	public void FBCENHDCAIH(bool KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x817FD70", Offset = "0x817E370", VA = "0x18817FD70")]
	public void NLONEEMFBFJ(bool KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x3B79130", Offset = "0x3B77730", VA = "0x183B79130")]
	public T KBEGGOMJECC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public IBPHJGNGCGN(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x817FC50", Offset = "0x817E250", VA = "0x18817FC50", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(IBPHJGNGCGN HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct IEHKMIOJHLL : IEquatable<IEHKMIOJHLL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool DOLIBMDDLAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x817FF50", Offset = "0x817E550", VA = "0x18817FF50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x8180020", Offset = "0x817E620", VA = "0x188180020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public bool MLPJLKMEBHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x817FE00", Offset = "0x817E400", VA = "0x18817FE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int GOCKDICJNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x817FF10", Offset = "0x817E510", VA = "0x18817FF10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x817FF90", Offset = "0x817E590", VA = "0x18817FF90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public IEHKMIOJHLL(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x817FE80", Offset = "0x817E480", VA = "0x18817FE80", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(IEHKMIOJHLL HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct NOFEGPOHNMB : IEquatable<NOFEGPOHNMB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int CNFKDDBEMLG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x818AEF0", Offset = "0x81894F0", VA = "0x18818AEF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x818ADC0", Offset = "0x81893C0", VA = "0x18818ADC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public int FKECACJOJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x818AEB0", Offset = "0x81894B0", VA = "0x18818AEB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x818AE10", Offset = "0x8189410", VA = "0x18818AE10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public uint LNGENENBBDL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x818ACF0", Offset = "0x81892F0", VA = "0x18818ACF0")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x818AE60", Offset = "0x8189460", VA = "0x18818AE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public NOFEGPOHNMB(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x818AD30", Offset = "0x8189330", VA = "0x18818AD30", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(NOFEGPOHNMB HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct GLJBIPPBOCG : IEquatable<GLJBIPPBOCG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	private DKLIEHDNMBN JCJFIJLGFJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x817E330", Offset = "0x817C930", VA = "0x18817E330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	private DKBDPOEBPOJ OFILGGBMCDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x817E070", Offset = "0x817C670", VA = "0x18817E070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public bool KKKAPPEPDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x817E390", Offset = "0x817C990", VA = "0x18817E390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public bool LLMKKMLGBGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x817DFD0", Offset = "0x817C5D0", VA = "0x18817DFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public bool IGMPFKCDLCF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x817DB40", Offset = "0x817C140", VA = "0x18817DB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public bool CBDMBABBIJE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x817E420", Offset = "0x817CA20", VA = "0x18817E420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public bool NACFNLOMABK
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x817DB70", Offset = "0x817C170", VA = "0x18817DB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public bool MGLBDPMGFDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x817DD10", Offset = "0x817C310", VA = "0x18817DD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public bool HBNBNDEDEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x817DE30", Offset = "0x817C430", VA = "0x18817DE30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool COIAGNIPINI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x817DBA0", Offset = "0x817C1A0", VA = "0x18817DBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public bool DEIDKJCDNHP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x817E560", Offset = "0x817CB60", VA = "0x18817E560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x817E4F0", Offset = "0x817CAF0", VA = "0x18817E4F0")]
	public bool OLNCKDNEMPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x817E0D0", Offset = "0x817C6D0", VA = "0x18817E0D0")]
	public MFPEINJHCFE JACDKLCCLKP(MFPEINJHCFE OKOGHNMMGGB)
	{
		return default(MFPEINJHCFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x817E220", Offset = "0x817C820", VA = "0x18817E220")]
	public DAHJHHJGHIB LOPBMLIGEPF()
	{
		return default(DAHJHHJGHIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x817E170", Offset = "0x817C770", VA = "0x18817E170")]
	public bool JLHFCBFFDPK(DAHJHHJGHIB OKOGHNMMGGB, [Out] DAHJHHJGHIB BPLNBKIJBBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public GLJBIPPBOCG(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x817B010", Offset = "0x8179610", VA = "0x18817B010")]
	public static bool EIMKEBEILPD(GLJBIPPBOCG KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x817DDA0", Offset = "0x817C3A0", VA = "0x18817DDA0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(GLJBIPPBOCG HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct FEGLIOCJLOM : IEquatable<FEGLIOCJLOM>
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static readonly FEGLIOCJLOM ENEIBJMGMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public KPMGCCKEPKI GIAJEPCBJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x817CB40", Offset = "0x817B140", VA = "0x18817CB40")]
		get
		{
			return default(KPMGCCKEPKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public OIMGLIMIDDE AKMCIMNLAFH
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x817C8F0", Offset = "0x817AEF0", VA = "0x18817C8F0")]
		get
		{
			return default(OIMGLIMIDDE);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x817C6A0", Offset = "0x817ACA0", VA = "0x18817C6A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public NDMOGPNBENB PFNPFBIHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x817C9B0", Offset = "0x817AFB0", VA = "0x18817C9B0")]
		get
		{
			return default(NDMOGPNBENB);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x817CB80", Offset = "0x817B180", VA = "0x18817CB80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public float FFKCECDOHON
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x817C930", Offset = "0x817AF30", VA = "0x18817C930")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x817C610", Offset = "0x817AC10", VA = "0x18817C610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public Vector3 HFDJLAJMCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x817CA40", Offset = "0x817B040", VA = "0x18817CA40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x817C820", Offset = "0x817AE20", VA = "0x18817C820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public float ADCPADJPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x817C9F0", Offset = "0x817AFF0", VA = "0x18817C9F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public PMDGEEGMAGC FLADFPDGLLL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x817C660", Offset = "0x817AC60", VA = "0x18817C660")]
		get
		{
			return default(PMDGEEGMAGC);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x817C560", Offset = "0x817AB60", VA = "0x18817C560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public bool FFCDDOFMKFG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x817C970", Offset = "0x817AF70", VA = "0x18817C970")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x817C5B0", Offset = "0x817ABB0", VA = "0x18817C5B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public JLCPCGEONCF BDBOCHCKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(JLCPCGEONCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public LFHOBEDMLBM EJLDIIMBBEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(LFHOBEDMLBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x817C8A0", Offset = "0x817AEA0", VA = "0x18817C8A0")]
	public DHHLGLAFMGJ FLMGAIIENIC()
	{
		return default(DHHLGLAFMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x817C740", Offset = "0x817AD40", VA = "0x18817C740")]
	public KJHAHBCOJIM CMJPDDMCFPK()
	{
		return default(KJHAHBCOJIM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x817C6F0", Offset = "0x817ACF0", VA = "0x18817C6F0")]
	private bool BMMDEFAOHII(PMDGEEGMAGC MGNCINIDNEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x817CAC0", Offset = "0x817B0C0", VA = "0x18817CAC0")]
	public void OFPGIMPGBEL(PMDGEEGMAGC MGNCINIDNEO, bool IKCKHHEBILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public FEGLIOCJLOM(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x817B010", Offset = "0x8179610", VA = "0x18817B010")]
	public static bool EIMKEBEILPD(FEGLIOCJLOM KKGBKLFKCPO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x8178060", Offset = "0x8176660", VA = "0x188178060")]
	public static bool FLMCEAOBGCC(FEGLIOCJLOM DLGEPLKGJOC, FEGLIOCJLOM OKKFDNDPGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x817C790", Offset = "0x817AD90", VA = "0x18817C790", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(FEGLIOCJLOM HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct DHHLGLAFMGJ : IEquatable<DHHLGLAFMGJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public FEGLIOCJLOM BHEFIFANING
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(FEGLIOCJLOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public NKGGCFMEFLF LEGCMAEMLAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x817B0C0", Offset = "0x81796C0", VA = "0x18817B0C0")]
		get
		{
			return default(NKGGCFMEFLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public DHHLGLAFMGJ(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x817B010", Offset = "0x8179610", VA = "0x18817B010")]
	public static bool EIMKEBEILPD(DHHLGLAFMGJ KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x817B030", Offset = "0x8179630", VA = "0x18817B030", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(DHHLGLAFMGJ HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[DefaultMember("Item")]
public readonly struct KJHAHBCOJIM : IEquatable<KJHAHBCOJIM>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly KJHAHBCOJIM ENEIBJMGMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	private ELODOEPAFFG GLKJLPLEFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x81850F0", Offset = "0x81836F0", VA = "0x1881850F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public FEGLIOCJLOM BHEFIFANING
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(FEGLIOCJLOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public HNLOHAHCDNN FLFKDHCJCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x8184F40", Offset = "0x8183540", VA = "0x188184F40")]
		get
		{
			return default(HNLOHAHCDNN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x81848B0", Offset = "0x8182EB0", VA = "0x1881848B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public IEnumerable<HMOFNAAGPNJ> LDMFGEJNFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x8185150", Offset = "0x8183750", VA = "0x188185150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public HMOFNAAGPNJ FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x8185350", Offset = "0x8183950", VA = "0x188185350")]
		get
		{
			return default(HMOFNAAGPNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x8184C00", Offset = "0x8183200", VA = "0x188184C00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public JLCPCGEONCF BDBOCHCKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(JLCPCGEONCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x8184C90", Offset = "0x8183290", VA = "0x188184C90")]
	public HMOFNAAGPNJ DJMKPHJGGIE(float3? NHLFNDFGAHK, [Optional] quaternion? CFFPEJBOBIA, [Optional] Vector3? HKINPNLCPPL)
	{
		return default(HMOFNAAGPNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x81849D0", Offset = "0x8182FD0", VA = "0x1881849D0")]
	public HMOFNAAGPNJ DHNNHIIHAMD(int KHMHPNKMLMD, float3? NHLFNDFGAHK, [Optional] quaternion? CFFPEJBOBIA, [Optional] Vector3? HKINPNLCPPL)
	{
		return default(HMOFNAAGPNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x8185460", Offset = "0x8183A60", VA = "0x188185460")]
	public void NIKCJECJEEC(int KHMHPNKMLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x8185060", Offset = "0x8183660", VA = "0x188185060")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public KJHAHBCOJIM(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x817B010", Offset = "0x8179610", VA = "0x18817B010")]
	public static bool EIMKEBEILPD(KJHAHBCOJIM KKGBKLFKCPO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x8178190", Offset = "0x8176790", VA = "0x188178190")]
	public static bool JKIBMILPCGE(KJHAHBCOJIM DLGEPLKGJOC, KJHAHBCOJIM OKKFDNDPGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x8184EB0", Offset = "0x81834B0", VA = "0x188184EB0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(KJHAHBCOJIM HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public readonly struct HMOFNAAGPNJ : IEquatable<HMOFNAAGPNJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public KJHAHBCOJIM MDBAKBIDIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x817F9E0", Offset = "0x817DFE0", VA = "0x18817F9E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public float3 DCMHMEMBABG
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x817F830", Offset = "0x817DE30", VA = "0x18817F830")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x817F980", Offset = "0x817DF80", VA = "0x18817F980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public quaternion DMNEFDLDHJA
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x817F7D0", Offset = "0x817DDD0", VA = "0x18817F7D0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x817FAC0", Offset = "0x817E0C0", VA = "0x18817FAC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public float3 KLIDMDNDPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x817FA60", Offset = "0x817E060", VA = "0x18817FA60")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x817F890", Offset = "0x817DE90", VA = "0x18817F890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public DGAEBPJIIOK GFBIGAMDIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x817F780", Offset = "0x817DD80", VA = "0x18817F780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x817F820", Offset = "0x817DE20", VA = "0x18817F820")]
	public void CIJJBBPMEOG(KJHAHBCOJIM KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public HMOFNAAGPNJ(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x817F8F0", Offset = "0x817DEF0", VA = "0x18817F8F0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(HMOFNAAGPNJ HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct NFHCJGHJPEJ : IEquatable<NFHCJGHJPEJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public bool KNCJOJOIEIK
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x818A860", Offset = "0x8188E60", VA = "0x18818A860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public NFHCJGHJPEJ(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x818A7D0", Offset = "0x8188DD0", VA = "0x18818A7D0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(NFHCJGHJPEJ HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct CLNLIDOLKAA : IEquatable<CLNLIDOLKAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	private GCKFMICNINL MLPOOCEKLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x8179D70", Offset = "0x8178370", VA = "0x188179D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public bool ALJJLBCOGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x817A160", Offset = "0x8178760", VA = "0x18817A160")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x8179D10", Offset = "0x8178310", VA = "0x188179D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public bool BOAPOHCGAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x817A1B0", Offset = "0x81787B0", VA = "0x18817A1B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x81798A0", Offset = "0x8177EA0", VA = "0x1881798A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public float KKLEJJPDBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x8179DD0", Offset = "0x81783D0", VA = "0x188179DD0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x8179CC0", Offset = "0x81782C0", VA = "0x188179CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public bool BGFDKMHHOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x8179F50", Offset = "0x8178550", VA = "0x188179F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x817A200", Offset = "0x8178800", VA = "0x18817A200")]
	public void MHFDHICHAIF(int FMBOIKGHIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x8179950", Offset = "0x8177F50", VA = "0x188179950")]
	public bool DMIKGKIHBFM([Out] int FMBOIKGHIFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x8179B90", Offset = "0x8178190", VA = "0x188179B90")]
	public void EMFCMMHIKGG(bool MBJJPODIBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x8179900", Offset = "0x8177F00", VA = "0x188179900")]
	public bool DJJFCADMPPO(BCONCEGBJCH MGNCINIDNEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x817A2A0", Offset = "0x81788A0", VA = "0x18817A2A0")]
	public void NLBJJBOAMOD(BCONCEGBJCH MGNCINIDNEO, bool IKCKHHEBILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x8179E10", Offset = "0x8178410", VA = "0x188179E10")]
	public void HAENHNMHMIE(float AKGHCBLLOCM, float CANABNDKEFF, float IGMMJFGNGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x817A320", Offset = "0x8178920", VA = "0x18817A320")]
	public void OKNOGENMIHJ(float3 HMMBPEDODBG, quaternion GLAOEALMNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x817A030", Offset = "0x8178630", VA = "0x18817A030")]
	public bool JJBDPINBJCG([Out] float3 HMMBPEDODBG, [Out] quaternion GLAOEALMNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x8179A60", Offset = "0x8178060", VA = "0x188179A60")]
	public bool EAIMJCMOFHP([Out] float AGGMNAKAJJO, [Out] float MLPFPKFKIIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x8179FA0", Offset = "0x81785A0", VA = "0x188179FA0")]
	public void JGPOLCKIOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public CLNLIDOLKAA(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x8179C30", Offset = "0x8178230", VA = "0x188179C30", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(CLNLIDOLKAA HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct JLCPCGEONCF : IEquatable<JLCPCGEONCF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	private HDFJJJHIDHC HFBFGOCFKFG
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x8183550", Offset = "0x8181B50", VA = "0x188183550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public Vector3 DCMHMEMBABG
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x81827C0", Offset = "0x8180DC0", VA = "0x1881827C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x8182A40", Offset = "0x8181040", VA = "0x188182A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public Quaternion DMNEFDLDHJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x8182430", Offset = "0x8180A30", VA = "0x188182430")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x8183AB0", Offset = "0x81820B0", VA = "0x188183AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public Vector3 OAIHMNHMDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x8182180", Offset = "0x8180780", VA = "0x188182180")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x8183C10", Offset = "0x8182210", VA = "0x188183C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public Quaternion LKJFNILHINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x81831C0", Offset = "0x81817C0", VA = "0x1881831C0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x8182580", Offset = "0x8180B80", VA = "0x188182580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public float EFEHBBKPJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x8182650", Offset = "0x8180C50", VA = "0x188182650")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x8182900", Offset = "0x8180F00", VA = "0x188182900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public float MDMNADBPKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x8183970", Offset = "0x8181F70", VA = "0x188183970")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public Matrix4x4 GHOAGKLPPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x81830B0", Offset = "0x81816B0", VA = "0x1881830B0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public LFHOBEDMLBM EJLDIIMBBEB
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(LFHOBEDMLBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	private NNEPMGCDLOI LOJJBHPCFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8176280", Offset = "0x8174880", VA = "0x188176280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x81828B0", Offset = "0x8180EB0", VA = "0x1881828B0")]
	public MBBBIPMPPEE COLFJDELBFJ()
	{
		return default(MBBBIPMPPEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x8182C60", Offset = "0x8181260", VA = "0x188182C60")]
	public void GBPKCIKPJNI([Out] Matrix4x4 GOCIIHLDDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x81837B0", Offset = "0x8181DB0", VA = "0x1881837B0")]
	public void LGLIEEABKLI([In] Vector3 GCBLNLANCOF, [In] Quaternion EFCAEMFMOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x81838B0", Offset = "0x8181EB0", VA = "0x1881838B0")]
	public void LGLIEEABKLI([In] RigidTransform GBCBAMENHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x81833B0", Offset = "0x81819B0", VA = "0x1881833B0")]
	public void IOPINLHDENK([Out] RigidTransform GBCBAMENHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x8182270", Offset = "0x8180870", VA = "0x188182270")]
	public void BMMEFFPHIPP([In] Vector3 PLCJHNBFJDJ, [In] Quaternion GHBFGHEPBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x8182370", Offset = "0x8180970", VA = "0x188182370")]
	public void BMMEFFPHIPP([In] RigidTransform PFNFBELHBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x8182F20", Offset = "0x8181520", VA = "0x188182F20")]
	public void GGFAHMFOBIN([Out] Vector3 PLCJHNBFJDJ, [Out] Quaternion GHBFGHEPBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x8182E70", Offset = "0x8181470", VA = "0x188182E70")]
	public void GGFAHMFOBIN([Out] RigidTransform GBCBAMENHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x8182E40", Offset = "0x8181440", VA = "0x188182E40")]
	public UniformTRS GFAKILDEOGJ()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x8182D80", Offset = "0x8181380", VA = "0x188182D80")]
	public void GFAKILDEOGJ([Out] UniformTRS PFNFBELHBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x8183520", Offset = "0x8181B20", VA = "0x188183520")]
	public UniformTRS KDHJCOEBJOA()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x8183460", Offset = "0x8181A60", VA = "0x188183460")]
	public void KDHJCOEBJOA([Out] UniformTRS GBCBAMENHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x8181FC0", Offset = "0x81805C0", VA = "0x188181FC0")]
	public Vector3 ADAFENCCGGP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x81820B0", Offset = "0x81806B0", VA = "0x1881820B0")]
	public void AKPJJODKFPC([In] Vector3 KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x81836C0", Offset = "0x8181CC0", VA = "0x1881836C0")]
	public Vector3 LFCLCGIBKEL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x8183E30", Offset = "0x8182430", VA = "0x188183E30")]
	public void PLNLFNPNJCK([In] Vector3 KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x8182B10", Offset = "0x8181110", VA = "0x188182B10")]
	public Quaternion FOODLGJJABM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x81830F0", Offset = "0x81816F0", VA = "0x1881830F0")]
	public void HGAMBLGFJMN([In] Quaternion KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x8183CE0", Offset = "0x81822E0", VA = "0x188183CE0")]
	public Quaternion NFBLFGKPGOJ()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x81826F0", Offset = "0x8180CF0", VA = "0x1881826F0")]
	public void CIPMFHPBILO([In] Quaternion KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x8183310", Offset = "0x8181910", VA = "0x188183310")]
	public float IDHAONMBJDD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x8183000", Offset = "0x8181600", VA = "0x188183000")]
	public void GGNPGIAMGGF(float KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x8183A10", Offset = "0x8182010", VA = "0x188183A10")]
	public float MEGPLPLGIFN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x8183610", Offset = "0x8181C10", VA = "0x188183610")]
	public void KPCJNOLPLHG(float KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x8183B80", Offset = "0x8182180", VA = "0x188183B80")]
	public Vector3 MIJINJIPHOH([In] Vector3 GJGHBLDDKFD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public JLCPCGEONCF(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x81829B0", Offset = "0x8180FB0", VA = "0x1881829B0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(JLCPCGEONCF HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public readonly struct ELDGNGFBGDD : IEquatable<ELDGNGFBGDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	private KNDMBEHEOII BOIDGHOOOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x817C330", Offset = "0x817A930", VA = "0x18817C330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	private FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x8175210", Offset = "0x8173810", VA = "0x188175210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x817C390", Offset = "0x817A990", VA = "0x18817C390")]
	public void EKNEIJPNCLF(string MFGALGGOPCB, CCDMGJJANIN LONKPMILJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public ELDGNGFBGDD(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x817C4D0", Offset = "0x817AAD0", VA = "0x18817C4D0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(ELDGNGFBGDD HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173D00", VA = "0x188175700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct DMOHOPKIMJK : IEquatable<DMOHOPKIMJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	public NHPHNKOAKCC FAGPGHPJFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x817B100", Offset = "0x8179700", VA = "0x18817B100")]
		get
		{
			return default(NHPHNKOAKCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public DMOHOPKIMJK(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x817B1F0", Offset = "0x81797F0", VA = "0x18817B1F0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(DMOHOPKIMJK HOPHFOOKMCC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct LNMAFLKPNID : IEquatable<LNMAFLKPNID>
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public struct CNKCCEJKJLC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private DAHJHHJGHIB OHGBPBLOAKN;

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x817A500", Offset = "0x8178B00", VA = "0x18817A500")]
		public CNKCCEJKJLC(DAHJHHJGHIB OHGBPBLOAKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x817A470", Offset = "0x8178A70", VA = "0x18817A470", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x8186EF0", Offset = "0x81854F0", VA = "0x188186EF0")]
	public CNKCCEJKJLC CPBIMDAHFIL()
	{
		return default(CNKCCEJKJLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x8186F80", Offset = "0x8185580", VA = "0x188186F80")]
	public MICJILPCMKH EHHJJJEKEOP(Allocator HOHBLCPFIEJ = Allocator.Temp)
	{
		return default(MICJILPCMKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x8187270", Offset = "0x8185870", VA = "0x188187270")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> MIHKCPADNCB(Allocator HOHBLCPFIEJ = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x8187460", Offset = "0x8185A60", VA = "0x188187460")]
	public NativeArray<DAAPNACEHGA> NFMIOGAJGHK(Allocator HOHBLCPFIEJ = Allocator.Temp)
	{
		return default(NativeArray<DAAPNACEHGA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x81871C0", Offset = "0x81857C0", VA = "0x1881871C0")]
	public NativeArray<DAAPNACEHGA> KGBDKNBCCBA(Allocator HOHBLCPFIEJ = Allocator.Temp)
	{
		return default(NativeArray<DAAPNACEHGA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x8187100", Offset = "0x8185700", VA = "0x188187100")]
	public IIKPNIBMDFG JNDCLKENBHK(Allocator HOHBLCPFIEJ = Allocator.Temp)
	{
		return default(IIKPNIBMDFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x81873A0", Offset = "0x81859A0", VA = "0x1881873A0")]
	public IIKPNIBMDFG NEDHMEHFKJK(Allocator HOHBLCPFIEJ = Allocator.Temp)
	{
		return default(IIKPNIBMDFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x8187510", Offset = "0x8185B10", VA = "0x188187510")]
	public IIKPNIBMDFG NOONAANHMEH(Allocator HOHBLCPFIEJ = Allocator.Temp)
	{
		return default(IIKPNIBMDFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public LNMAFLKPNID(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x8187070", Offset = "0x8185670", VA = "0x188187070", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(LNMAFLKPNID HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x8176A50", Offset = "0x8175050", VA = "0x188176A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct MOKIJIEFECC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public int OKLAHEOPLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int EPHAOFFGOLD;
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public readonly struct BFGBENOAGHM : IEquatable<BFGBENOAGHM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public LNMAFLKPNID LGDNNGOGLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(LNMAFLKPNID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public GNPAGAAGPEH ILBKEFOPONE
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(GNPAGAAGPEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public DMOHOPKIMJK OPFLEEGJJAM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DMOHOPKIMJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8176920", Offset = "0x8174F20", VA = "0x188176920")]
	public bool ECGKABADMAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x81767A0", Offset = "0x8174DA0", VA = "0x1881767A0")]
	public bool BOBBJNOKLMD([Out] Exception DHMKLCNLGMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public BFGBENOAGHM(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
	public static DAHJHHJGHIB EIMKEBEILPD(BFGBENOAGHM KKGBKLFKCPO)
	{
		return default(DAHJHHJGHIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x81769C0", Offset = "0x8174FC0", VA = "0x1881769C0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(BFGBENOAGHM HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x8176A50", Offset = "0x8175050", VA = "0x188176A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public readonly struct DPNDAIDOLIE : IDisposable, IEquatable<DPNDAIDOLIE>
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public static readonly DPNDAIDOLIE ENEIBJMGMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public BFGBENOAGHM INLICGFLEGK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(BFGBENOAGHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public LNMAFLKPNID LGDNNGOGLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(LNMAFLKPNID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x817B3E0", Offset = "0x81799E0", VA = "0x18817B3E0")]
	public void HLAOKPPKFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x817B280", Offset = "0x8179880", VA = "0x18817B280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public DPNDAIDOLIE(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x817B350", Offset = "0x8179950", VA = "0x18817B350", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "5")]
	public bool Equals(DPNDAIDOLIE HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x817B460", Offset = "0x8179A60", VA = "0x18817B460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct GNPAGAAGPEH : IEquatable<GNPAGAAGPEH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	public bool HOLIHGIJPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x817E720", Offset = "0x817CD20", VA = "0x18817E720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	public GNPAGAAGPEH(DAHJHHJGHIB OHGBPBLOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x81753C0", Offset = "0x81739C0", VA = "0x1881753C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x817E690", Offset = "0x817CC90", VA = "0x18817E690", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173820", VA = "0x188175220", Slot = "4")]
	public bool Equals(GNPAGAAGPEH HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x8176A50", Offset = "0x8175050", VA = "0x188176A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class MFKKCOEPOCJ
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private struct KGGDLEBEBKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Guid PPIICOOCLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public OAJBEOLGKNC DNCPOKPMAHP;
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct OAJBEOLGKNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int KKGBKLFKCPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int DPPKHMGGMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int LNLMALHGADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int NDKLJBABHKC;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x818AF30", Offset = "0x8189530", VA = "0x18818AF30")]
		public bool LHONNKDAEJM([Out] DAAPNACEHGA EILOFNMLIOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x818AFD0", Offset = "0x81895D0", VA = "0x18818AFD0")]
		public OAJBEOLGKNC(DAAPNACEHGA EILOFNMLIOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x81893F0", Offset = "0x81879F0", VA = "0x1881893F0")]
	public static Guid DABPDKJFNLI(this DAAPNACEHGA EILOFNMLIOM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x81893D0", Offset = "0x81879D0", VA = "0x1881893D0")]
	public static bool DAAGAOBOFEA(this Guid PPIICOOCLEP, [Out] DAAPNACEHGA EILOFNMLIOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal static class CJMMPIILHDA
{
	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x8178610", Offset = "0x8176C10", VA = "0x188178610")]
	public static FDLCNEOAOBH EBDGAJLIBNH(this DAHJHHJGHIB HLIPPIOIAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x81786A0", Offset = "0x8176CA0", VA = "0x1881786A0")]
	public static MCNADDNPOAH LMHIDNFMGHF(this DAHJHHJGHIB HLIPPIOIAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x8178700", Offset = "0x8176D00", VA = "0x188178700")]
	public static EntityManager OAIANGGCCHK(this DAHJHHJGHIB HLIPPIOIAJK)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x3956480", Offset = "0x3954A80", VA = "0x183956480")]
	internal static bool IOGMELECPMM<T>(this DAHJHHJGHIB HLIPPIOIAJK, bool IKCKHHEBILP) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x8178500", Offset = "0x8176B00", VA = "0x188178500")]
	public static bool COFGJEKDFLB(this DAHJHHJGHIB HLIPPIOIAJK, LNGKIIMFKIB PJAMOIBNMIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x3956640", Offset = "0x3954C40", VA = "0x183956640")]
	public static bool MNFHFOFBKPI<T>(this DAHJHHJGHIB HLIPPIOIAJK) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x3953520", Offset = "0x3951B20", VA = "0x183953520")]
	public static bool GJJOPKKDLHM<T>(this DAHJHHJGHIB HLIPPIOIAJK) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x3951BA0", Offset = "0x39501A0", VA = "0x183951BA0")]
	[BNHKBKBKCHN]
	public static T FKKAKGBAKEO<T>(this DAHJHHJGHIB HLIPPIOIAJK) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x3953680", Offset = "0x3951C80", VA = "0x183953680")]
	[BNHKBKBKCHN]
	public static T IHBPFLOHDIE<T>(this DAHJHHJGHIB HLIPPIOIAJK) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x3951A80", Offset = "0x3950080", VA = "0x183951A80")]
	public static bool ALNJGENDFNA<T>(this DAHJHHJGHIB HLIPPIOIAJK, [Out] T KKGBKLFKCPO) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x3957040", Offset = "0x3955640", VA = "0x183957040")]
	public static T NLOLGKPBFJJ<T>(this DAHJHHJGHIB HLIPPIOIAJK) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x3956400", Offset = "0x3954A00", VA = "0x183956400")]
	public static T IIFOOFNKOKB<T>(this DAHJHHJGHIB HLIPPIOIAJK) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
internal static class NHIDHEMDLKN
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[DefaultMember("Item")]
public struct MICJILPCMKH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private IIKPNIBMDFG LFMKIINCPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> BLPGPLBGKAH;

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E70680", Offset = "0x5E6EC80", VA = "0x185E70680")]
	public MICJILPCMKH(IIKPNIBMDFG LFMKIINCPNH, NativeArray<EntityRemapUtility.EntityRemapInfo> BLPGPLBGKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x818A550", Offset = "0x8188B50", VA = "0x18818A550")]
	public LocalId FABPKFIFKFJ(LocalId ODCICEDDLMB)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x818A500", Offset = "0x8188B00", VA = "0x18818A500")]
	public LocalId FABPKFIFKFJ(int KHMHPNKMLMD)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x818A490", Offset = "0x8188A90", VA = "0x18818A490", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BLDEDLGHDCP
{
	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCCPDEKCHOF(World JLOAJOGDOIE, NativeParallelHashSet<FixedString64Bytes> MOLEGANPELH);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PKDNDBENIKM
{
	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBLAICLKKHB(DAHJHHJGHIB ABGLFCMHAJA, [Out] uint HLIPPIOIAJK);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ALMKJMLHPNM(DAHJHHJGHIB ABGLFCMHAJA, [Out] uint HLIPPIOIAJK);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ALHHHCOIFHH(DAHJHHJGHIB ABGLFCMHAJA, uint HLIPPIOIAJK);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ENHFGFPCENA(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string CFELLLNODDG(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PJEDJAOMCAC(DAHJHHJGHIB ABGLFCMHAJA, string HLIPPIOIAJK);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MOFIABIIBCF(DAHJHHJGHIB ABGLFCMHAJA, [Out] string JLEDBPIFFKI);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KOAIPOAMPEK(DAHJHHJGHIB ABGLFCMHAJA, string JLEDBPIFFKI);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FOKLIOBGGNN
{
	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	Guid KBOLCNFNJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	Guid PLOPCOGKKCF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ANFDONJGCBI(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HCOLMIBOPPI(MFPEINJHCFE ODCICEDDLMB);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid JFHNLFBIHEC(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IJKBJEDDBJA(DAHJHHJGHIB OHGBPBLOAKN, Guid OEEANCBNNKB);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MDLCJKEKCCC(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task CIELNIEEGFJ(DAHJHHJGHIB JDOHELGNGHJ, DAHJHHJGHIB NBIJLPJHNNE);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HHMJIGCHGLE(DAHJHHJGHIB OHGBPBLOAKN, DAAPNACEHGA DMMBMGIHEJC);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GGEJOPNGKIK
{
	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	Guid KBOLCNFNJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLANBDPGOFB(NativeList<Guid> FADHOMBENBM, NativeList<Guid> AABPCMEEMLO, NativeList<FixedString64Bytes> KMMCICBFIJO);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LBLHKCNGHJA
{
	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IIKPNIBMDFG FDJJICDLGEL(Allocator HOHBLCPFIEJ);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IIKPNIBMDFG GDIHDAGIMFP(Allocator HOHBLCPFIEJ);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AONBAFILNEB(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MLPJLKMEBHM(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NJCKDIBAAOL(DAHJHHJGHIB ABGLFCMHAJA, [Out] DAHJHHJGHIB AAELOFGPENJ);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DOLIBMDDLAD(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BGAAGIJONHA(DAHJHHJGHIB ABGLFCMHAJA, int HFCJPLHKMHP);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DAHJHHJGHIB JGEOCAFMBIE(DAHJHHJGHIB AAELOFGPENJ);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GOGPKJGHOFM(IIKPNIBMDFG AMKPDLCNENL, bool CJCDHAAKEIN);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HHJOFDGJDLM(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HAABIOEJJNN(DAHJHHJGHIB ABGLFCMHAJA, bool BLPOHPGGJND);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int OAJCGDEHPCL();

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HAHCAFFBBIF(DAHJHHJGHIB OHGBPBLOAKN);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EGNFIJCEPIJ
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<DAHJHHJGHIB, DAHJHHJGHIB> LINOGAPPPCG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<DAHJHHJGHIB, DAHJHHJGHIB> JFGIFDLLJFL;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<DAHJHHJGHIB, DAHJHHJGHIB, DAHJHHJGHIB> HNAIDDFDIKC;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<DAHJHHJGHIB> OJFIPLMPJCG;

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool APAPDBBCLPE(DAHJHHJGHIB OHGBPBLOAKN, DAHJHHJGHIB GLAFJGCHJJC);

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DAHJHHJGHIB LAIKOFJKEEJ(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IIKPNIBMDFG JKBDPGPLEPJ(DAHJHHJGHIB OHGBPBLOAKN, Allocator HOHBLCPFIEJ);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DAHJHHJGHIB OANKEDCCJNL(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FKKGFLPBNNB(DAHJHHJGHIB OHGBPBLOAKN, Vector3 LEMKBBMDECK, Quaternion KOAPCOJKAJK);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BGMBBFGIMBD(DAHJHHJGHIB OHGBPBLOAKN, float ADNFJIEHGHC);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool LNEMGJKDHPI(DAHJHHJGHIB OHGBPBLOAKN, [Out] DAHJHHJGHIB NBIJLPJHNNE);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool PICJKLJFPEI(DAHJHHJGHIB OHGBPBLOAKN, [Out] RigidTransform EKBIPKNJDEL);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 OMMEBMGELOO(MCPNENGPNBG KMEGNEJIGOP);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion HIGFKOHLCDA(MCPNENGPNBG KMEGNEJIGOP);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class ALEOONMHKFK
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NPLEHCFGHOL
{
	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	object ACKLDMPHOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OMELAGLEPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCKIIOEBHBH(DAHJHHJGHIB ODCICEDDLMB, ODCNDAHGGBA IIMFJJALMBC);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JMLKCEGABGM(ODCNDAHGGBA IIMFJJALMBC);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AHEMBMFAGAH(DAHJHHJGHIB OHGBPBLOAKN, [Out] ODCNDAHGGBA KMOHBAJDKFI);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[Flags]
public enum NLCHGMFAOHN
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	IncludeSelf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	IncludeChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	IncludeDescendants = 6,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	IncludeMask = 7,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Disembodied = 8,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Embodied = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	IgnoreEmbodiment = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	EmbodimentMask = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Runtime = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Authored = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	AuthoredAndRuntime = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	HierarchyMask = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	HintInputsAreDisjoint = 0x80
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface OEIFJNJODNF
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public ref struct DCOLJIKPENL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ReadOnlySpan<DAHJHHJGHIB> AAHHANFMMAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public ReadOnlySpan<DAHJHHJGHIB> ICCMMMCFBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public DAHJHHJGHIB EDKBGMKCEGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public DAHJHHJGHIB CFGFCNPMIIC;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BHGCMJMKJHD(DAHJHHJGHIB CBONFNAPPDE, DAHJHHJGHIB FAKMDCDKDHA);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHHCPECMBBF(DAHJHHJGHIB JGDCHGNDPLC, bool KKBNDFNEENM);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IIHOOOBEGHG(DAHJHHJGHIB HDEMOEJNIHP, DAHJHHJGHIB JIDBOMLDPMP);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MAKLNBNIEKH(DAHJHHJGHIB OLLPKLKPIGH, bool KKBNDFNEENM);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JIOOMPBAJHA(DAHJHHJGHIB OLLPKLKPIGH);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ADJKDDBEPMP(DAHJHHJGHIB OLLPKLKPIGH);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DAHJHHJGHIB MCMOMILDAIF(DAHJHHJGHIB JGDCHGNDPLC);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ReadOnlySpan<DAHJHHJGHIB> JIDHOKJNBFN(DAHJHHJGHIB OLLPKLKPIGH);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ReadOnlySpan<DAHJHHJGHIB> IDGGLIDHMJA(DAHJHHJGHIB OLLPKLKPIGH);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DCOLJIKPENL MAJDCMFEJOH(DAHJHHJGHIB OLLPKLKPIGH, float DAOPJJAELJA, float MFCIAMICMGP);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EDIJDJKDAKN(DAHJHHJGHIB OLLPKLKPIGH, [Out] CAEJLDNLONB GLNNAENDNMD);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FHKPDKBLAFA(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IGDGEKIHFDJ(DAHJHHJGHIB OHGBPBLOAKN);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public readonly struct MJOGAIMAOIL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly string IEDAJGLJHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly T COMAGLLDBOM;

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x5613150", Offset = "0x5611750", VA = "0x185613150")]
	public MJOGAIMAOIL(T COMAGLLDBOM, [Optional][CallerMemberName] string IEDAJGLJHNI)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly MJOGAIMAOIL<int> CHIJIJHKHEB;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly MJOGAIMAOIL<int> KGBMNILMNOD;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly MJOGAIMAOIL<int> OFNCMFGECMO;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public enum ILBCAOABDPF
{
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class NMJJMBEDDBH
{
	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x13DAC60", Offset = "0x13D9260", VA = "0x1813DAC60")]
	public static bool ALLHBMGNMKN(this ILBCAOABDPF DCPJOMEJHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x17CDCC0", Offset = "0x17CC2C0", VA = "0x1817CDCC0")]
	public static bool AEHEGNLEHFM(this ILBCAOABDPF DCPJOMEJHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x304E5F0", Offset = "0x304CBF0", VA = "0x18304E5F0")]
	public static bool KOHGIPIENIJ(this ILBCAOABDPF DCPJOMEJHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x13DAC50", Offset = "0x13D9250", VA = "0x1813DAC50")]
	public static bool MKMCEFAOBPG(this ILBCAOABDPF DCPJOMEJHIO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PFOLPACMFPD
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public enum PHEHGAPMPCP
	{
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public enum DDPAEGDENPH
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	PHEHGAPMPCP ONBMFLDBKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	bool KJFHADAHKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	bool EKLCNDNFKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	DDPAEGDENPH MANFFAAFICC
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.Application)]
public interface HPBOONODMMK
{
	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	ILBCAOABDPF OLELLJIDKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	ILBCAOABDPF PLEBMHKEBJO
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	ILBCAOABDPF FONPBNJOCKK
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	ILBCAOABDPF KOBGMGDADOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	ILBCAOABDPF KNEHGKLPGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	ILBCAOABDPF EEPFACIMHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	ILBCAOABDPF IOCAIOKALBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	ILBCAOABDPF DKJFJHLANAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	ILBCAOABDPF JCFOKCFMHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	ILBCAOABDPF POKMHGHAKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	ILBCAOABDPF AIJOCCGICPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	ILBCAOABDPF NLPHGBOIKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	ILBCAOABDPF AKLNPGBLELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	ILBCAOABDPF BHPPJEHMNIL
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	ILBCAOABDPF JNNLMMHOOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	ILBCAOABDPF EPNMGNFNGJE
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	ILBCAOABDPF DJDDFAJIEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	ILBCAOABDPF HGKEFOIGFBC
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	ILBCAOABDPF LMDEEKLMOLB
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	ILBCAOABDPF KLMKFGCFPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int KBGIPADPFGF(MJOGAIMAOIL<int> HHBGHAKIGCN);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KGOKLMGHDGG
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event ACDKDKEFMPI.PEEGOFOKANI PNDNJICPBCC;

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DAHJHHJGHIB EJOGGCINJEM(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IIKPNIBMDFG NCCJDPFFAFL(Allocator HOHBLCPFIEJ);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DGAEBPJIIOK BJHMPLBKDGC(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PINELEKJNHE(IEnumerable<DAHJHHJGHIB> AJLCCPJLHKP);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DGAEBPJIIOK KHBPLHHFJJM(DAHJHHJGHIB NBIJLPJHNNE, DAHJHHJGHIB LFMKIINCPNH, bool PGMDODNMANJ, DAHJHHJGHIB OKOGHNMMGGB);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DAHJHHJGHIB BJFCBLMDKHF(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KNEPPBFGJJO(DAHJHHJGHIB OHGBPBLOAKN, DAHJHHJGHIB NBIJLPJHNNE, bool GLFOCMLGNBC = false);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KBPBIHJCCPA(DAHJHHJGHIB OHGBPBLOAKN, DAHJHHJGHIB NBIJLPJHNNE);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NMBLDBPOLJL(DAHJHHJGHIB IECEHCOHACG, DAHJHHJGHIB IIOFOBLFJMF);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	IIKPNIBMDFG KCPKHKHFCEN(DAHJHHJGHIB HJMEJBNHKHM);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LNBJCDGBFFO(DAHJHHJGHIB OHGBPBLOAKN, DAHJHHJGHIB DMFMPBNAAAJ);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IIKPNIBMDFG FCPBHDJLIBP(IIKPNIBMDFG CFOPGKCHBKP, NLCHGMFAOHN ENCLHPAOMCM, Allocator HOHBLCPFIEJ);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool PKPKLKHCFJK(DAHJHHJGHIB OHGBPBLOAKN, DAHJHHJGHIB GPPFMBFLIBE);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DAHJHHJGHIB LKFOIHKFNKB(DAHJHHJGHIB OKOGHNMMGGB, DAHJHHJGHIB KIKHMOCMCCN);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool IKDKJINJHDB(DAHJHHJGHIB OKOGHNMMGGB, DAHJHHJGHIB KIKHMOCMCCN, [Out] DAHJHHJGHIB IKIGPKBKHIJ);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "17")]
	DAHJHHJGHIB JNCCDMKBIHP(DAHJHHJGHIB[] AMKPDLCNENL);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "18")]
	DAHJHHJGHIB GLLGBCAANBL(DAHJHHJGHIB OHGBPBLOAKN, uint KANAABFHOGN);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class HLOGIDAPFOG
{
	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x817F4F0", Offset = "0x817DAF0", VA = "0x18817F4F0")]
	public static bool IKAKALLGAEP(this KGOKLMGHDGG BCEMINIMFEN, DAHJHHJGHIB OHGBPBLOAKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x817F1E0", Offset = "0x817D7E0", VA = "0x18817F1E0")]
	public static IIKPNIBMDFG FCPBHDJLIBP(this KGOKLMGHDGG BDLLFBOLFCP, DAHJHHJGHIB OHGBPBLOAKN, NLCHGMFAOHN ENCLHPAOMCM, Allocator HOHBLCPFIEJ)
	{
		return default(IIKPNIBMDFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x817F700", Offset = "0x817DD00", VA = "0x18817F700")]
	public static IIKPNIBMDFG OFIBALCLGPD(this KGOKLMGHDGG BDLLFBOLFCP, DAHJHHJGHIB OHGBPBLOAKN, Allocator HOHBLCPFIEJ)
	{
		return default(IIKPNIBMDFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x817F4B0", Offset = "0x817DAB0", VA = "0x18817F4B0")]
	public static IIKPNIBMDFG GPFACMLIGAH(this KGOKLMGHDGG BDLLFBOLFCP, DAHJHHJGHIB OHGBPBLOAKN, Allocator HOHBLCPFIEJ)
	{
		return default(IIKPNIBMDFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x817F470", Offset = "0x817DA70", VA = "0x18817F470")]
	public static IIKPNIBMDFG FIPNGBIGIEB(this KGOKLMGHDGG BDLLFBOLFCP, DAHJHHJGHIB OHGBPBLOAKN, Allocator HOHBLCPFIEJ)
	{
		return default(IIKPNIBMDFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x817F740", Offset = "0x817DD40", VA = "0x18817F740")]
	public static IIKPNIBMDFG PKDIHJFNACG(this KGOKLMGHDGG BDLLFBOLFCP, DAHJHHJGHIB OHGBPBLOAKN, Allocator HOHBLCPFIEJ)
	{
		return default(IIKPNIBMDFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x817F6C0", Offset = "0x817DCC0", VA = "0x18817F6C0")]
	public static IIKPNIBMDFG LNCLFPLPDDD(this KGOKLMGHDGG BDLLFBOLFCP, DAHJHHJGHIB OHGBPBLOAKN, Allocator HOHBLCPFIEJ)
	{
		return default(IIKPNIBMDFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x817F680", Offset = "0x817DC80", VA = "0x18817F680")]
	public static IIKPNIBMDFG ILEJKBKMJPH(this KGOKLMGHDGG BDLLFBOLFCP, DAHJHHJGHIB OHGBPBLOAKN, Allocator HOHBLCPFIEJ)
	{
		return default(IIKPNIBMDFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x817F560", Offset = "0x817DB60", VA = "0x18817F560")]
	public static IIKPNIBMDFG ILEJKBKMJPH(this KGOKLMGHDGG BDLLFBOLFCP, IIKPNIBMDFG OHGBPBLOAKN, Allocator HOHBLCPFIEJ)
	{
		return default(IIKPNIBMDFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FJJIMNOHOPC
{
	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x817DAE0", Offset = "0x817C0E0", VA = "0x18817DAE0", Slot = "0")]
	Task<BFGBENOAGHM> LGBFCIDJGEI(OLLBGKKIMKC KJCGEMCCGOO, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "1")]
	void OBNPKCHHKEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EBAHIDFIMHO
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event ACDKDKEFMPI.PEEGOFOKANI PNDNJICPBCC;

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DAHJHHJGHIB BJFCBLMDKHF(DAHJHHJGHIB JDOHELGNGHJ);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<DAHJHHJGHIB> CIAPKKAINGO();

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<DAHJHHJGHIB> JCBBPAJKGGN(DAHJHHJGHIB NBIJLPJHNNE);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NLJDHLCCPGH(DAHJHHJGHIB NNGGENIIOBH, DAHJHHJGHIB JGDEMMIPJMF, [Out] DGAEBPJIIOK CCOMCMBKMOF);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IGPHLHEIKCI(DAHJHHJGHIB NNGGENIIOBH, DAHJHHJGHIB FJHMAIDOPGF, [Out] DGAEBPJIIOK CCOMCMBKMOF);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CLEMNHMOPJP(DAHJHHJGHIB NNGGENIIOBH);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KBPBIHJCCPA(DAHJHHJGHIB ONFGHLDEPCA, DAHJHHJGHIB BADBAFBEKHJ);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DGAEBPJIIOK FLNENFGFLMI(DAHJHHJGHIB OHGBPBLOAKN);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LGFOOLKGBCJ
{
	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	bool LHMHOJFCEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	bool BPMDAIIPMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EC")]
	bool BDEGEDPFJMP
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FODPLGGPOOE
{
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JBPKAOLIFHP
{
	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKEBPODHGKH(DAHJHHJGHIB OHGBPBLOAKN, LNGKIIMFKIB PJAMOIBNMIO);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJBHPJPEEIC(DAHJHHJGHIB OHGBPBLOAKN, LNGKIIMFKIB PJAMOIBNMIO);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BPELKFMMEGF
{
	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LCBPMIKIJMM<string> ECGDJDGKDMF(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LCBPMIKIJMM<string> JDICEMEAAIA(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EFPKLGOPFLA(DAHJHHJGHIB OHGBPBLOAKN, LCBPMIKIJMM<string> FDNFPDAMLJB);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IHLBGAFEPDD(DAHJHHJGHIB OHGBPBLOAKN, LCBPMIKIJMM<string> FDNFPDAMLJB);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JAHNLJOHFKI(DAHJHHJGHIB AAEAPBAKGGE, DAHJHHJGHIB GOOONLOFHDI);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EEALEHMMMJI
{
	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OBIGOCAPOLO JAHEJOAGKBB(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EKDKHGDHEFA(DAHJHHJGHIB ABGLFCMHAJA, OBIGOCAPOLO DELOOPIPFGE);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool APFDEKMDKEI(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IDMKDOHGLOF(DAHJHHJGHIB ABGLFCMHAJA, bool KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LCBPMIKIJMM<string> GFNBJEKJAMD(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KNMFOELDGPJ(DAHJHHJGHIB ABGLFCMHAJA, LCBPMIKIJMM<string> FDNFPDAMLJB);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LCBPMIKIJMM<string> CMPNPJDKOIG(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KIPNDKLEFDL(DAHJHHJGHIB ABGLFCMHAJA, LCBPMIKIJMM<string> FDNFPDAMLJB);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LCBPMIKIJMM<string> NEECKGKMLAN(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DHMOPHJLDPC(DAHJHHJGHIB ABGLFCMHAJA, LCBPMIKIJMM<string> FDNFPDAMLJB);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LCBPMIKIJMM<string> KAPIBGDEJDE(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DCPDBPKKLMI(DAHJHHJGHIB ABGLFCMHAJA, LCBPMIKIJMM<string> FDNFPDAMLJB);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MIOPFNHMKMM(DAHJHHJGHIB ABGLFCMHAJA, DAHJHHJGHIB OPOGJMFOAFI);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EFOKELDHDDA
{
	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JPMGELPJBHC([In] float3 HOPJCEGNGCM, [In] float3 GJGHBLDDKFD, float AMEHFMMOAMH, [Out] FJKMGDABMBE OMLNIIKHEAN, [Out] DAHJHHJGHIB HPDPKHBCCGD);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int BOPCLFGKLPA([In] float3 HOPJCEGNGCM, float OFCEKCJNBGJ, List<DAHJHHJGHIB> AMKPDLCNENL);

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int ICFHFPEABGI(Plane[] CDBBMENIAAP, float3 HOPJCEGNGCM, float3 MHKLCCGOICM, quaternion CFFPEJBOBIA, List<DAHJHHJGHIB> AMKPDLCNENL);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface POLOCBABMPN
{
	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPMGELPJBHC([In] NativeArray<Entity> DCGEKCKMHBF, [In] float3 HOPJCEGNGCM, [In] float3 GJGHBLDDKFD, [In] NativeArray<FJKMGDABMBE> DPBIHMDNNGP);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> BOPCLFGKLPA([In] NativeArray<Entity> DCGEKCKMHBF, [In] float3 HOPJCEGNGCM, float OFCEKCJNBGJ);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> ICFHFPEABGI([In] NativeArray<Entity> DCGEKCKMHBF, [In] NativeArray<float4> KIDLAFELKKD);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public struct MALOLLPMDBG : PEDJJCFICCD, IEquatable<MALOLLPMDBG>
{
	[Cpp2IlInjected.Token(Token = "0x170001ED")]
	public int BPENJJIEFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001EE")]
	public int IECDKBKDFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x306D380", Offset = "0x306B980", VA = "0x18306D380", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x7175C10", Offset = "0x7174210", VA = "0x187175C10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x81881E0", Offset = "0x81867E0", VA = "0x1881881E0", Slot = "8")]
	public bool Equals(MALOLLPMDBG HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x8188230", Offset = "0x8186830", VA = "0x188188230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct FJKMGDABMBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public float EMHJGAJIIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float3 IFDADDNBHKB;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CMPKPFKIGDG
{
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NNEPMGCDLOI
{
	[Cpp2IlInjected.Token(Token = "0x170001EF")]
	FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F0")]
	FIFKEPBKMKO PCCLFLFKLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<IIKPNIBMDFG, NativeArray<RRObjectPrefabData>> PFAHICAFIPE;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<IIKPNIBMDFG> OPDGLCKGCBI;

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IIKPNIBMDFG GENBJIHKANB();

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DANGOHCJKPL MKEAMAEOLJH(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "8")]
	RRObjectPrefabData POHCPMKKNBF(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BEMLCAEMECA(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MFPEINJHCFE EDCIKKJKNPD(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BBAJPFNKNBP(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IPEBBJPCIFM(DAHJHHJGHIB OHGBPBLOAKN, [Out] Transform DFOHJKCGEGI);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DAHJHHJGHIB NADMJLJHANM(DAAPNACEHGA EILOFNMLIOM);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool BIBOKEFEONI(DAAPNACEHGA EILOFNMLIOM, [Out] DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DAAPNACEHGA MEJHHEAJCHB(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IIKPNIBMDFG NADMJLJHANM(NativeArray<DAAPNACEHGA> EILOFNMLIOM, Allocator HOHBLCPFIEJ, bool EKNPGIIDDIG = true);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool CAMMNMDBECC(NativeArray<FOLGEENNEHN> OGBMAIKFJGD, NativeArray<DAAPNACEHGA> OPHFCLKNEEJ, NativeArray<Entity> PDKDIFDGLCH, LCBPMIKIJMM<MKDDAEOLBJB> LDLPKFFFBAF);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	MFPEINJHCFE BJOFFEELJBK();

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	MFPEINJHCFE JCJCJCMAFJK(RRObjectPrefabData CANHKFFPDPD, [Optional] AKGINPGMGBG JCLBIBKAALH);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "20")]
	HHDOFEGIBLL CEIDFHNEOND();

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "21")]
	KJHAHBCOJIM CDJKJPEHEOD();

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "22")]
	DHHLGLAFMGJ IAPLOBAGNIA(NKGGCFMEFLF MNGLFJMOJNN);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KLBGICOCHDL(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool IPHNNENCBFJ(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "25")]
	IIKPNIBMDFG OAIOIDJDNJC(IIKPNIBMDFG HAJDNHHLBPC, Allocator HOHBLCPFIEJ);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool FMHHEEPBJPF(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool LPIHGFCFLND(DAHJHHJGHIB OHGBPBLOAKN, ComponentTypes AAONABAICIP);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "28")]
	DAHJHHJGHIB FPCDGKOPBPI(Transform DFOHJKCGEGI);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public static class KMGHELBDCAG
{
	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x8185B80", Offset = "0x8184180", VA = "0x188185B80")]
	internal static DAHJHHJGHIB MLFHGNGMBOI(this Entity DFPJIKCEODG, NNEPMGCDLOI LONKPMILJIG)
	{
		return default(DAHJHHJGHIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x8185770", Offset = "0x8183D70", VA = "0x188185770")]
	public static MFPEINJHCFE EEAMDNMHCIP(this NNEPMGCDLOI LONKPMILJIG, LocalId OHGBPBLOAKN)
	{
		return default(MFPEINJHCFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x8185C30", Offset = "0x8184230", VA = "0x188185C30")]
	public static DAHJHHJGHIB NADMJLJHANM(this NNEPMGCDLOI LONKPMILJIG, LocalId OHGBPBLOAKN)
	{
		return default(DAHJHHJGHIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x8185B10", Offset = "0x8184110", VA = "0x188185B10")]
	public static DAAPNACEHGA MEJHHEAJCHB(this NNEPMGCDLOI LONKPMILJIG, LocalId OHGBPBLOAKN)
	{
		return default(DAAPNACEHGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x81855C0", Offset = "0x8183BC0", VA = "0x1881855C0")]
	public static HHDOFEGIBLL AFCBBOGNBDB(this NNEPMGCDLOI LONKPMILJIG, RigidTransform PFNFBELHBGM)
	{
		return default(HHDOFEGIBLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x8185960", Offset = "0x8183F60", VA = "0x188185960")]
	public static DHHLGLAFMGJ KHLMOKLIPBI(this NNEPMGCDLOI LONKPMILJIG, NKGGCFMEFLF FBOFKEOBJPN, RigidTransform PFNFBELHBGM)
	{
		return default(DHHLGLAFMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x8185780", Offset = "0x8183D80", VA = "0x188185780")]
	public static KJHAHBCOJIM EPFBPCONMBJ(this NNEPMGCDLOI LONKPMILJIG, RigidTransform PFNFBELHBGM)
	{
		return default(KJHAHBCOJIM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x8185930", Offset = "0x8183F30", VA = "0x188185930")]
	private static void HAKIDEMKPEB(MFPEINJHCFE BIKPNIDLFNI, RigidTransform PFNFBELHBGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal interface CFIHAHEDFBE
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DKLIEHDNMBN
{
	[Cpp2IlInjected.Token(Token = "0x170001F1")]
	bool CGKHDBPKHHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F2")]
	DAHJHHJGHIB NMDEMOGNHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F3")]
	MFPEINJHCFE KMDBPKDBPAI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event DBFJDNHEJDP FCFBJNPBKPB;

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DAHJHHJGHIB LKFOIHKFNKB(DAHJHHJGHIB OKOGHNMMGGB, DAHJHHJGHIB KIKHMOCMCCN);

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IKDKJINJHDB(DAHJHHJGHIB OKOGHNMMGGB, DAHJHHJGHIB KIKHMOCMCCN, [Out] DAHJHHJGHIB IKIGPKBKHIJ);

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PAJPMHMNKNO();

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OIKMLNGCAGJ();

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KKKAPPEPDEM(DAHJHHJGHIB OKOGHNMMGGB);

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MGLBDPMGFDN(DAHJHHJGHIB OKOGHNMMGGB);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public delegate void DBFJDNHEJDP(MFPEINJHCFE LHMFILMJJIH, MFPEINJHCFE CCCEBHFJBDH);
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class DADEAIJBJJG
{
	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x817A700", Offset = "0x8178D00", VA = "0x18817A700")]
	public static bool OFBFCMPPICC(this DKLIEHDNMBN LOCMJEKPENO, MFPEINJHCFE OKOGHNMMGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x817A620", Offset = "0x8178C20", VA = "0x18817A620")]
	public static bool ODKNPNIHLHG(this DKLIEHDNMBN LOCMJEKPENO, DAHJHHJGHIB OKOGHNMMGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x817A5A0", Offset = "0x8178BA0", VA = "0x18817A5A0")]
	public static bool CBDMBABBIJE(this DKLIEHDNMBN LOCMJEKPENO, DAHJHHJGHIB OKOGHNMMGGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ALIBGHNMPLC
{
	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCOPBKJCIPJ(NativeList<RRObjectPrefabData> PPFMPBPNIED);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OPONHEPPMGD
{
	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKMGOKLMCOE(MFPEINJHCFE BIKPNIDLFNI, JGNPJEKDJKO PDFIFNAMHFC, List<MFPEINJHCFE> JMMJIFKPGAE);

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int NMOCCCPFBGL(MFPEINJHCFE BIKPNIDLFNI, JGNPJEKDJKO PDFIFNAMHFC);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IJANINCCPDN(MFPEINJHCFE BIKPNIDLFNI, List<MFPEINJHCFE> JMMJIFKPGAE);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int EFKJNNOOGEF(MFPEINJHCFE FMBOIKGHIFL, MFPEINJHCFE OKOGHNMMGGB, JGNPJEKDJKO PDFIFNAMHFC);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MFPEINJHCFE NCIENKJAABH(MFPEINJHCFE FMBOIKGHIFL, int KHMHPNKMLMD, JGNPJEKDJKO PDFIFNAMHFC);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JCFKLEJINMN(MFPEINJHCFE FMBOIKGHIFL, MFPEINJHCFE OKOGHNMMGGB, JGNPJEKDJKO PDFIFNAMHFC);

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PPPMFNOMPHM(MFPEINJHCFE FMBOIKGHIFL, MFPEINJHCFE OKOGHNMMGGB, JGNPJEKDJKO PDFIFNAMHFC);

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AIFOILDPLKE(MFPEINJHCFE FMBOIKGHIFL, JGNPJEKDJKO PDFIFNAMHFC);

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DHHAFAMAGOB(MFPEINJHCFE FMBOIKGHIFL, MFPEINJHCFE OKOGHNMMGGB, JGNPJEKDJKO PDFIFNAMHFC);

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void APDOFEHFNAE(Entity FMBOIKGHIFL, Entity OKOGHNMMGGB, JGNPJEKDJKO PDFIFNAMHFC);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JLKHKECADFB(Entity FMBOIKGHIFL, JGNPJEKDJKO PDFIFNAMHFC);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BOMCJIDFNAG(MFPEINJHCFE OKOGHNMMGGB, JGNPJEKDJKO PDFIFNAMHFC);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FLJFNHKCHAI
{
	[Cpp2IlInjected.Token(Token = "0x170001F4")]
	DMOHOPKIMJK JFGFCNDMIGO
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHPHNKOAKCC OPBODEKNCHD(DMOHOPKIMJK EOECEDBNACA);

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DMOHOPKIMJK OLPNDBJPFFF();

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DMOHOPKIMJK HLALGJELMCF();
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DKBDPOEBPOJ
{
	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLHFCBFFDPK(DAHJHHJGHIB OKOGHNMMGGB, [Out] DAHJHHJGHIB IDGFABNPOLN);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OOFDMFJHDIP
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<DAHJHHJGHIB> BPCDJDMGLDK;

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FBCENHDCAIH(DAHJHHJGHIB HJMEJBNHKHM, bool KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NLONEEMFBFJ(DAHJHHJGHIB HJMEJBNHKHM, bool KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECHFIIIGOGB(DAHJHHJGHIB HJMEJBNHKHM, int KKGBKLFKCPO);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ELODOEPAFFG
{
	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<DAHJHHJGHIB> KJLMJBHHOIP(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DAHJHHJGHIB PBDBAJKBHNJ(DAHJHHJGHIB OHGBPBLOAKN, int KHMHPNKMLMD);

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int ELOJGHIOIHK(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HNLOHAHCDNN AGNGAMEJJCH(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MGHALOBDMLG(DAHJHHJGHIB OHGBPBLOAKN, HNLOHAHCDNN MJNKOFMOBDK);

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DAHJHHJGHIB IIJACACCJOB(DAHJHHJGHIB OHGBPBLOAKN, [Optional] float3? NHLFNDFGAHK, [Optional] quaternion? CFFPEJBOBIA, [Optional] float3? HKINPNLCPPL);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DAHJHHJGHIB KFKFIDGAEOD(DAHJHHJGHIB OHGBPBLOAKN, int KHMHPNKMLMD, [Optional] float3? NHLFNDFGAHK, [Optional] quaternion? CFFPEJBOBIA, [Optional] float3? HKINPNLCPPL);

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EJIGGEBEING(DAHJHHJGHIB OHGBPBLOAKN, int KHMHPNKMLMD);

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DIACPLCJDKP(DAHJHHJGHIB OHGBPBLOAKN);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GAPAMDEFAFD
{
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DDNCFLMKNHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001F5")]
	bool PHNFINNDHFC
	{
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HPDOGPHJEBK();

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BBODDANLAIL();

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NIFEJMHBANK();

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NCOOHLOBANK();

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void INOJKOANNEP();

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NCBAPGPIGOH();

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OMAMEHKIDLC();

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CFMBCIEFGBN();

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KJDGCBPINCC();

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LAKFMBEDEJO();

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NFLALNOHJOM();

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FJOEPKFDKNM();
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GCKFMICNINL
{
	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMIKGKIHBFM(DAHJHHJGHIB OKOGHNMMGGB, [Out] int FMBOIKGHIFL);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHFDHICHAIF(DAHJHHJGHIB OKOGHNMMGGB, int FMBOIKGHIFL);

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EMFCMMHIKGG(DAHJHHJGHIB OKOGHNMMGGB, bool MBJJPODIBOG);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HAENHNMHMIE(DAHJHHJGHIB OKOGHNMMGGB, float AKGHCBLLOCM, float CANABNDKEFF, float IGMMJFGNGLM);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EAIMJCMOFHP(DAHJHHJGHIB OHGBPBLOAKN, [Out] float CANABNDKEFF, [Out] float IGMMJFGNGLM);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OKNOGENMIHJ(DAHJHHJGHIB OKOGHNMMGGB, float3 NHLFNDFGAHK, quaternion CFFPEJBOBIA);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JJBDPINBJCG(DAHJHHJGHIB OKOGHNMMGGB, [Out] float3 NHLFNDFGAHK, [Out] quaternion CFFPEJBOBIA);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JGPOLCKIOAD(DAHJHHJGHIB OKOGHNMMGGB);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HDFJJJHIDHC
{
	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKPJJODKFPC(Entity DFPJIKCEODG, [In] float3 KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 ADAFENCCGGP(Entity DFPJIKCEODG);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HGAMBLGFJMN(Entity DFPJIKCEODG, [In] quaternion KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion FOODLGJJABM(Entity DFPJIKCEODG);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGLIEEABKLI(Entity DFPJIKCEODG, [In] float3 NHLFNDFGAHK, [In] quaternion CFFPEJBOBIA);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IOPINLHDENK(Entity DFPJIKCEODG, [Out] RigidTransform PKKLEMAAFCG);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BMMEFFPHIPP(Entity DFPJIKCEODG, [In] float3 NHLFNDFGAHK, [In] quaternion CFFPEJBOBIA);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GGFAHMFOBIN(Entity DFPJIKCEODG, [Out] float3 NHLFNDFGAHK, [Out] quaternion CFFPEJBOBIA);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GGFAHMFOBIN(Entity DFPJIKCEODG, [Out] RigidTransform PKKLEMAAFCG);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GGNPGIAMGGF(Entity DFPJIKCEODG, float KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float IDHAONMBJDD(Entity DFPJIKCEODG);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PLNLFNPNJCK(Entity DFPJIKCEODG, [In] float3 KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 LFCLCGIBKEL(Entity DFPJIKCEODG);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CIPMFHPBILO(Entity DFPJIKCEODG, [In] quaternion KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion NFBLFGKPGOJ(Entity DFPJIKCEODG);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KPCJNOLPLHG(Entity DFPJIKCEODG, float KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float MEGPLPLGIFN(Entity DFPJIKCEODG);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DHFFICPNDNG(Entity DFPJIKCEODG, [Out] float4x4 GOCIIHLDDEK);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DNDANGGBHPF(Entity DFPJIKCEODG, [In] float4x4 GOCIIHLDDEK);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CACOIFBGELP(Entity DFPJIKCEODG);

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void CIPBLOJAAMI(Entity DFPJIKCEODG, Entity GGFNABANHGE, Entity BADBAFBEKHJ);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public static class MEEBIOEBECD
{
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MEGNKEJDOFA
{
	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JMMCKBFPFOK(bool EPAEFBCGGBA);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KNDMBEHEOII
{
	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGHFNDPCEBJ(DAHJHHJGHIB ABGLFCMHAJA, LCBPMIKIJMM<string> FDNFPDAMLJB);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBIJHCDFLOG(DAHJHHJGHIB ABGLFCMHAJA, LCBPMIKIJMM<string> FDNFPDAMLJB);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CNNBKMFDGDA(DAHJHHJGHIB ABGLFCMHAJA, LCBPMIKIJMM<string> FDNFPDAMLJB);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LPLFEMOJFOI(DAHJHHJGHIB ABGLFCMHAJA, LCBPMIKIJMM<string> FDNFPDAMLJB);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BBIDAJHIFNF(DAHJHHJGHIB ABGLFCMHAJA, LCBPMIKIJMM<string> FDNFPDAMLJB);

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void COOPHGNMIHD(DAHJHHJGHIB ABGLFCMHAJA, LCBPMIKIJMM<string> FDNFPDAMLJB);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int NIKHODLHMGI(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int HBFHKHLKDFG(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int LPLOGIOKENO(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "9")]
	POIJGDNEEOK<string> OAABKHEBMBO(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool JGGECDGNPJA(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	POIJGDNEEOK<string> HIDAFIOBDPK(DAHJHHJGHIB ABGLFCMHAJA);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IKFDHIDJJDF(DAHJHHJGHIB ABGLFCMHAJA, string MFGALGGOPCB);

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GFMOLEIKPKA(string MFGALGGOPCB, CCDMGJJANIN DEEAFNIKGCJ);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DAHJHHJGHIB CMHBKDNDOEO(string MFGALGGOPCB);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JMGGENAIILI(string MFGALGGOPCB, CCDMGJJANIN DEEAFNIKGCJ);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EKNEIJPNCLF(DAHJHHJGHIB AHKBEPCBHME, string MFGALGGOPCB, CCDMGJJANIN DEEAFNIKGCJ);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "17")]
	POIJGDNEEOK<string> IGGOAEOAPJC();
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class KHLHFGIGDCO
{
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JFOBNNLFPLI
{
	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World DLCLJONGJJF(string GNCCFOLHOIO = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World LNCCMKBLDOM(string GNCCFOLHOIO = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World NPIJGHBBJGJ(string GNCCFOLHOIO = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World FEJENKKFBJD(string GNCCFOLHOIO = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MCNADDNPOAH
{
	[Cpp2IlInjected.Token(Token = "0x170001F6")]
	World MCAJFMKGGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F7")]
	World EDBHOAKABJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F8")]
	EntityManager OAIANGGCCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	bool ICKKICKDNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase DKKNDDNIOCG(Type JLPANLJHHFI);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class AMFKKKPEAEP
{
	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x8175800", Offset = "0x8173E00", VA = "0x188175800")]
	public static ComponentSystemBase JOKKONAGEDK(this World JLOAJOGDOIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x30BC210", Offset = "0x30BA810", VA = "0x1830BC210")]
	public static T DKKNDDNIOCG<T>(this MCNADDNPOAH BOONDPAMAPI) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FPELMDIEKOD
{
	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMIHLFMNKME(NativeListAsync<Entity> GMLBHPAGPJK);

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGDAHNKIEGK(BDALEHGGBEB LGFEKIJIOEK);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OLCLPGECFMG(NativeListAsync<Entity> PFJAHIHEFJP, bool IBAOAFPBHDE);

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GOBLKJJANDA();

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGJFOKFDKAN(Entity CMAFOEIBEKN);
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface ONPNKPCBPFO
{
	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EIKPICJABDF(Collider DDEHFNFBNGL, [Out] NDHDGBELFKK EFFPDMHHLBM);
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CDCKCDNFOMB
{
	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider NJCIKHBKPPI(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject FNLIJNMJPMP(DAHJHHJGHIB OEOBELALDDA, GameObject KFAEMGBGGCC, Vector3 GCBLNLANCOF, Quaternion EFCAEMFMOII);

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HBCKEBHGLOA(GameObject DDEHFNFBNGL);

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider LJIDFELNIGI<TCollider>(GameObject BJGIJLAJIGC) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ICKMBLACENL(Collider DDEHFNFBNGL);

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject BIHHALLJAHF<TCollider>(string IEDAJGLJHNI) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JHMGFNMPOPK ANANMBLMNLL(DAHJHHJGHIB GCMLLBMNCJJ, DAHJHHJGHIB LKIHFKIHFNB, NKGGCFMEFLF MCDHMJBLBOH, float3 JOIACHHOPMC, quaternion HPDCPIBCEFP, float3 NNACFDDJPBG);

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ECBBLMCKOIL(DAHJHHJGHIB OHGBPBLOAKN, [Out] JHMGFNMPOPK DDEHFNFBNGL);

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HLBKJBNNLBP(DAHJHHJGHIB OHGBPBLOAKN, [Out] DAHJHHJGHIB CMAFOEIBEKN);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public enum EBFLKMEJNNP
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IDGBPCCJAGL
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public struct ONPIIEJIPKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int MCDHMJBLBOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public GameObject KFAEMGBGGCC;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBOMDELDAFE(DAHJHHJGHIB OHGBPBLOAKN, JHCNKNHMPMK HEFOFMDPEDO, bool IIGCKJPAKHN, HMMDHBIHKAK IMNNFLOIAOM);

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCHPLIMNING(DAHJHHJGHIB OHGBPBLOAKN, JHCNKNHMPMK HEFOFMDPEDO, bool IIGCKJPAKHN, bool JGKFMJJCCEK, bool AGGPAPJNCHG);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PMADPENEMKM FEJEPEKGGKK(DAHJHHJGHIB CMAFOEIBEKN, List<DAHJHHJGHIB> HFGKHFPCPNG);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JHMGFNMPOPK KJCKPLMHMLC(GameObject CAFILJICELD, GameObject DFBKGNJJDJO);

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MFBNJGLIKEA(GameObject CAFILJICELD, List<GameObject> KFHPJNPKDNO);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NOOBJJMFNHG(GameObject DFBKGNJJDJO);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T LJIDFELNIGI<T>(GameObject BJGIJLAJIGC) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ICKMBLACENL(Collider DDEHFNFBNGL);

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject KCBLPPLAKCP<T>(string IEDAJGLJHNI) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GDADAIBNGIE(Collider DDEHFNFBNGL, [Out] DAHJHHJGHIB FMBOIKGHIFL);

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FGLCLFBPNIB(DAHJHHJGHIB OHGBPBLOAKN, [Out] NDHDGBELFKK EFFPDMHHLBM);

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EBFLKMEJNNP> DLJBINACHJC(Allocator HOHBLCPFIEJ = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] CMFNIHDKODA();
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DHINGPFKPJK
{
	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOFCKFLGCNH(DAHJHHJGHIB OHGBPBLOAKN, DAHJHHJGHIB KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELJKAGOPJIJ(DAHJHHJGHIB OHGBPBLOAKN, DAHJHHJGHIB KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GKENOPINDHP(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DAHJHHJGHIB IDLOPLPDGLN(DAHJHHJGHIB OHGBPBLOAKN, int KHMHPNKMLMD);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IIKPNIBMDFG FOPAAPGGGII(DAHJHHJGHIB OHGBPBLOAKN, Allocator HOHBLCPFIEJ = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LNMFLJJGKNH(DAHJHHJGHIB OHGBPBLOAKN, object DKFMAIJGPFL, DAHJHHJGHIB KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void INONHIMNJMD(DAHJHHJGHIB OHGBPBLOAKN, object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NDPLIKFEODG(DAHJHHJGHIB OHGBPBLOAKN, [Out] DAHJHHJGHIB KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DJNKDDLNCEI(DAHJHHJGHIB OHGBPBLOAKN, float3 KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PMJGOBBMDFG(DAHJHHJGHIB OHGBPBLOAKN, [Out] float3 KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OJEHHOGEOND(DAHJHHJGHIB OHGBPBLOAKN, float3 KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LDMAAFBPLNB(DAHJHHJGHIB OHGBPBLOAKN, [Out] float3 KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KNGGGEHKOGJ(DAHJHHJGHIB OHGBPBLOAKN, (Quaternion rot, Vector3 moments) CGCPKONOFGF);

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool GPGIINIKHGI(DAHJHHJGHIB OHGBPBLOAKN, [Out] quaternion LFABKDOANNB, [Out] float3 DCHIPMCAOKI);

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AKIKPGINGPN(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 PKLECCFGPCB(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 IDIKHGDPMOI(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LNLDGLKIFNE(DAHJHHJGHIB OHGBPBLOAKN, float3 KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OEBDNKNCBBC(DAHJHHJGHIB OHGBPBLOAKN, float3 KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float CEEFNJDJCCG(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float LADPLNOLHFJ(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FFDMKGIMOGF(DAHJHHJGHIB OHGBPBLOAKN, float KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JMKPAJADFLA(DAHJHHJGHIB OHGBPBLOAKN, float KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode KHBEMNEGLKC(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FEJLENMAKJG(DAHJHHJGHIB OHGBPBLOAKN, CollisionDetectionMode KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "25")]
	CNFEEBNLJFN KCPGCGPOOCO(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JLHLDHJJLMO(DAHJHHJGHIB OHGBPBLOAKN, CNFEEBNLJFN KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool KDBIPDLLIAB(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KNGINNCPEIK(DAHJHHJGHIB OHGBPBLOAKN, bool KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "29")]
	DAHJHHJGHIB EJOGGCINJEM(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void POGJOOEDIHD(DAHJHHJGHIB OHGBPBLOAKN, DAHJHHJGHIB KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DAHJHHJGHIB BJFCBLMDKHF(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void KNEPPBFGJJO(DAHJHHJGHIB OHGBPBLOAKN, DAHJHHJGHIB KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "33")]
	PHONBPAKPKN BBIPFLBJPOI(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void DIOJJMMFGKC(DAHJHHJGHIB OHGBPBLOAKN, PHONBPAKPKN FFFBJJCPKNN);

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool PBNHEAHEPBF(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void HMBIJJKLLIH(DAHJHHJGHIB OHGBPBLOAKN, bool KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool MMKMCDNOLCG(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void AEHABPIMDLD(DAHJHHJGHIB OHGBPBLOAKN, bool KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints BDLFFALENLB(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void BCFGLMFJOGO(DAHJHHJGHIB OHGBPBLOAKN, RigidbodyConstraints KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float ELKEICILGJN(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void OHHLIKCPLEO(DAHJHHJGHIB OHGBPBLOAKN, float KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float DNJDOBODDBD(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void BJLEEKNOBDJ(DAHJHHJGHIB OHGBPBLOAKN, float KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool FPAJIOCEFLJ(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void OLMLOPBCNFP(DAHJHHJGHIB OHGBPBLOAKN, bool KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool JIGKNBHEIFF(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void BNJNCFHJMDL(DAHJHHJGHIB OHGBPBLOAKN, bool KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void FJBMGLLPDLF(DAHJHHJGHIB OHGBPBLOAKN, int KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "50")]
	MJAJOILNJDL PHOKFFHNCHJ(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void LEAEAGBFGMA(DAHJHHJGHIB OHGBPBLOAKN, MJAJOILNJDL KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "52")]
	IPBPHKFFBLO FMGKMMEJJDF(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void IALCHEEHCEA(DAHJHHJGHIB OHGBPBLOAKN, IPBPHKFFBLO KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float MPLIMBPMDEF(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void LPLCMKEKDFI(DAHJHHJGHIB OHGBPBLOAKN, float KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void PHPJLJLLADK(DAHJHHJGHIB OHGBPBLOAKN, object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void KMAHNDGDKOH(DAHJHHJGHIB OHGBPBLOAKN, object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool POALEODKCMI(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void AGDMPBGDJID(DAHJHHJGHIB OHGBPBLOAKN, object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void APCJCNBDANJ(DAHJHHJGHIB OHGBPBLOAKN, object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool GLNADAKABMO(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool DDGDJONAHFE(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody ECDCKCPKCOB(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void JBDCOEEFOLJ(DAHJHHJGHIB OHGBPBLOAKN, Rigidbody DLDHGDFMDNB);

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void GHAIAGLOMLE(DAHJHHJGHIB OHGBPBLOAKN, object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void MILCNPIKOKP(DAHJHHJGHIB OHGBPBLOAKN, object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool LFDPEJOLDLH(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void NPLFIICLPHJ(DAHJHHJGHIB OHGBPBLOAKN, float3 OFCFOGHNCGN);

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void LCJBPOMILGN(DAHJHHJGHIB OHGBPBLOAKN, float3 BOPHMEPMHDE);

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool ODIOMOMPOOB(DAHJHHJGHIB OHGBPBLOAKN, [Out] float3 OFCFOGHNCGN);

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool PFFKIBKCKOD(DAHJHHJGHIB OHGBPBLOAKN, [Out] float3 BOPHMEPMHDE);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool HLKDNGBMEHB(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void FGNFOBBJFBB(DAHJHHJGHIB OHGBPBLOAKN, object DKFMAIJGPFL, bool PJBLBGNDEOD);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void KCMLDFHHCNG(DAHJHHJGHIB OHGBPBLOAKN, bool OOAKEKDDDCF);

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void EGGELPFBMNJ(DAHJHHJGHIB OHGBPBLOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool LJIMNGOOOEF(DAHJHHJGHIB OHGBPBLOAKN);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JDIPIJONBEN
{
	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFNIMHCMOHG(Entity DOFEMFDDIBC);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMILINBFBOF(Entity DOFEMFDDIBC);

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KBEKCILEPIP(Entity DOFEMFDDIBC);
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HGPGBOJCIDN
{
	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPHHBOMACOC(DAHJHHJGHIB OKOGHNMMGGB, bool LBLAAHJBLDI);
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public delegate void NAPOOGNAMLE(MNODAICACOC LEFENBOEPCF);
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public readonly ref struct MNODAICACOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly IIKPNIBMDFG BGHBLHEDMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly NativeArray<byte> DNGPJGHLFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly NativeArray<byte> NOJLDFBEPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly LNGKIIMFKIB PJAMOIBNMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly int DAHKBFIMFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly Type MINJJHHFPCG;

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	public IIKPNIBMDFG IFENMKPALCI
	{
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x53697A0", Offset = "0x5367DA0", VA = "0x1853697A0")]
		get
		{
			return default(IIKPNIBMDFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	public int GMOIMINMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x818A5C0", Offset = "0x8188BC0", VA = "0x18818A5C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	public LNGKIIMFKIB LPNDDFLMCEP
	{
		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xA635A0", Offset = "0xA61BA0", VA = "0x180A635A0")]
		get
		{
			return default(LNGKIIMFKIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x818A5E0", Offset = "0x8188BE0", VA = "0x18818A5E0")]
	public MNODAICACOC(IIKPNIBMDFG BGHBLHEDMAA, NativeArray<byte> DNGPJGHLFNP, NativeArray<byte> NOJLDFBEPEA, LNGKIIMFKIB PJAMOIBNMIO, int DAHKBFIMFHK, Type MINJJHHFPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x3C283B0", Offset = "0x3C269B0", VA = "0x183C283B0")]
	public NativeArray<T> GDDJAHDLPJF<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x3C284E0", Offset = "0x3C26AE0", VA = "0x183C284E0")]
	public NativeArray<T> PMMALKLFMHH<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x3C283F0", Offset = "0x3C269F0", VA = "0x183C283F0")]
	public (IIKPNIBMDFG, NativeArray<T>, NativeArray<T>) KBGIPADPFGF<T>() where T : struct
	{
		return default((IIKPNIBMDFG, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x818A590", Offset = "0x8188B90", VA = "0x18818A590")]
	public JNIKOMMPACF ELJHAMGEJLO()
	{
		return default(JNIKOMMPACF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public interface BPBNDODFDDG
{
	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	string NNACDLDJCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	BPBNDODFDDG NGJPHMIHINN
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	IEnumerable<BPBNDODFDDG> PBLGPGPBNJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DHJLLODDDFN
{
	[Cpp2IlInjected.Token(Token = "0x17000200")]
	BPBNDODFDDG CNJAGBOKFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	NativeArray<LNGKIIMFKIB> HKCEIHJCEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IKCCMEICKGB(LNGKIIMFKIB PJAMOIBNMIO, [Out] BPBNDODFDDG HLMMJBEMNBB);

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CCHHFLKMKEK(LNGKIIMFKIB PJAMOIBNMIO, NAPOOGNAMLE IHKMNPGFJLL);

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PAEMAGCOOJI(LNGKIIMFKIB PJAMOIBNMIO, NAPOOGNAMLE IHKMNPGFJLL);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PGDBNEEHBED
{
	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCHHFLKMKEK(LNGKIIMFKIB PJAMOIBNMIO, NAPOOGNAMLE IHKMNPGFJLL);

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PAEMAGCOOJI(LNGKIIMFKIB PJAMOIBNMIO, NAPOOGNAMLE IHKMNPGFJLL);
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class APMJMKMKFML
{
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JKMOOHPMCJF
{
	[Cpp2IlInjected.Token(Token = "0x17000202")]
	bool MKBFHNMDAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000203")]
	LHBBHIELLCG OPHCFHFANLD
	{
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AAFCBLIECLC(NHPHNKOAKCC EILOFNMLIOM, bool MNKADPBEGKF);

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CBJGMEPCPAG(DAAPNACEHGA EILOFNMLIOM, LNGKIIMFKIB PJAMOIBNMIO);

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GBFBLDPDGJC(NativeArray<DAAPNACEHGA> NLNGMCBMDEL);
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public static class FJAOHEDGNCG
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly ref struct JNIKOMMPACF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly MNODAICACOC ACJFHCNBBBO;

	[Cpp2IlInjected.Token(Token = "0x17000204")]
	public IIKPNIBMDFG IFENMKPALCI
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x53697A0", Offset = "0x5367DA0", VA = "0x1853697A0")]
		get
		{
			return default(IIKPNIBMDFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x8184450", Offset = "0x8182A50", VA = "0x188184450")]
	public JNIKOMMPACF(MNODAICACOC ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x8183F00", Offset = "0x8182500", VA = "0x188183F00")]
	public IIKPNIBMDFG GDDJAHDLPJF()
	{
		return default(IIKPNIBMDFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x8184320", Offset = "0x8182920", VA = "0x188184320")]
	public IIKPNIBMDFG PMMALKLFMHH()
	{
		return default(IIKPNIBMDFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x8184030", Offset = "0x8182630", VA = "0x188184030")]
	public (IIKPNIBMDFG, IIKPNIBMDFG, IIKPNIBMDFG) KBGIPADPFGF()
	{
		return default((IIKPNIBMDFG, IIKPNIBMDFG, IIKPNIBMDFG));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class COKHBPHOGOP
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public readonly struct LHBBHIELLCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly NativeBitArray IKPECOFHHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly NativeParallelHashMap<DAAPNACEHGA, int> NJPGHBEHKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly NativeParallelHashSet<NHPHNKOAKCC> KHGOHACBAKC;

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	public bool BJFKOLCMLCF
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x8186CF0", Offset = "0x81852F0", VA = "0x188186CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	public bool MKBFHNMDAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x8186CC0", Offset = "0x81852C0", VA = "0x188186CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2D90", Offset = "0x5EE1390", VA = "0x185EE2D90")]
	public LHBBHIELLCG(NativeBitArray IKPECOFHHOA, NativeParallelHashMap<DAAPNACEHGA, int> NJPGHBEHKAE, NativeParallelHashSet<NHPHNKOAKCC> KHGOHACBAKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x8186AD0", Offset = "0x81850D0", VA = "0x188186AD0")]
	public bool CBJGMEPCPAG(DAAPNACEHGA EILOFNMLIOM, LNGKIIMFKIB PJAMOIBNMIO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CCMHHMMNBHB
{
	[Cpp2IlInjected.Token(Token = "0x17000207")]
	CPCDDMBJLPC PENKEHCAPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PAODCFCHNKD
{
	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FCNMACGPLBD(DAHJHHJGHIB OHGBPBLOAKN, BPPBNOIINPP KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OMKHNGNFNIM HFNBFENMEBO();
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GIMNLGKEBAI
{
	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCGGKGBDFIP(World JLOAJOGDOIE);

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGCOMDBCKFI(World JLOAJOGDOIE);

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase AGDEBKFIGIM(World JLOAJOGDOIE);

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBFLMKFIEEC(World JLOAJOGDOIE);

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GBECOJEEPMH(World JLOAJOGDOIE);

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EKOIMPLPGKD(World JLOAJOGDOIE);

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KIMHLNGOGFM(World JLOAJOGDOIE);

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> EDMGHCMEOPL();
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LBJJNLBDJDJ
{
	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGAEIPFIBNF(DAHJHHJGHIB HJMEJBNHKHM, bool KKGBKLFKCPO);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public readonly struct MHDJJFMOEEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly IEnumerable<NBKFDFCLFFC> BMFONFFIFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly IReadOnlyList<GameObject> KOCNMLMNLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly IReadOnlyList<int> FMCIHBOPACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly IReadOnlyList<(DAAPNACEHGA, DAAPNACEHGA)> JMNELEKJEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly int KFGIEMKBFFE;
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public struct CBDKLGGBAGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public InventionIdData HLIPPIOIAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public InventionInstanceIdData NHDKLIMHKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public bool EIGGDGOLJDC;

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x8177050", Offset = "0x8175650", VA = "0x188177050")]
	public CBDKLGGBAGL(long HLIPPIOIAJK, Guid NHDKLIMHKOH, bool EIGGDGOLJDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[ServiceLifetime(Lifetime.Application)]
public interface JNABHCLPBAD
{
	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFGBENOAGHM HKCMFAGFFND(OLLBGKKIMKC HGJODMIHAEL, int MPOICMMGOPB = 0, bool FGBLFADJKDA = false);

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DPNDAIDOLIE CDICLLCLFAG(OLLBGKKIMKC HGJODMIHAEL, DAHJHHJGHIB NBIJLPJHNNE, [In] UniformTRS BOAOEPHHLPF, ONIBJMBIAFB HLMAACDBLAB, [Optional] CBDKLGGBAGL CIEPKFEOCCN, bool NICJHOAGBLO = true, bool OCGMOPFPHNP = false, bool FGBLFADJKDA = false, bool CMDOIEAIOCK = false);

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DPIHEKIAILI MNGOPKHJMIK();

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DPIHEKIAILI NCIPEELBMGO(IIKPNIBMDFG AMKPDLCNENL, [In] UniformTRS MBAGOINBCOJ, [Optional] ONIBJMBIAFB JABDDNOKGIF);

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ECGKABADMAB(DAHJHHJGHIB PIEHEKKHGID);

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BOBBJNOKLMD(DAHJHHJGHIB PIEHEKKHGID, [Out] Exception KCNEOPLNBEN);

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<DAAPNACEHGA> NFMIOGAJGHK(DAHJHHJGHIB PIEHEKKHGID, Allocator HOHBLCPFIEJ);

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<DAAPNACEHGA> KGBDKNBCCBA(DAHJHHJGHIB PIEHEKKHGID, Allocator HOHBLCPFIEJ);

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IIKPNIBMDFG JNDCLKENBHK(DAHJHHJGHIB PIEHEKKHGID, Allocator HOHBLCPFIEJ);

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IIKPNIBMDFG NEDHMEHFKJK(DAHJHHJGHIB PIEHEKKHGID, Allocator HOHBLCPFIEJ);

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IIKPNIBMDFG GEHECNIAOEG(DAHJHHJGHIB PIEHEKKHGID, Allocator HOHBLCPFIEJ);

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> MIHKCPADNCB(DAHJHHJGHIB PIEHEKKHGID, Allocator HOHBLCPFIEJ);

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JGAFGPCCLEJ(DAHJHHJGHIB PIEHEKKHGID);

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int IGMJCKLCMDP(DAHJHHJGHIB PIEHEKKHGID, int FOAMCIPOLAA);
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[ServiceLifetime(Lifetime.Application)]
public interface BBPJHPEPBKN
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0xEA7EA0", Offset = "0xEA64A0", VA = "0x180EA7EA0", Slot = "0")]
	bool BCPBDAOBLPL(object FLDOIECLDLD, EFHLKFIPDPP GGPBILBNPMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class AHMGMAJLKCB
{
	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x8175720", Offset = "0x8173D20", VA = "0x188175720")]
	public static bool BCPBDAOBLPL(this BBPJHPEPBKN BDLLFBOLFCP, object FLDOIECLDLD, [Out] EFHLKFIPDPP GGPBILBNPMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public enum MBOIFBFCPPO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	MaxPlayers = byte.MaxValue,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	IsVisible = 254,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	IsOpen = 253,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	PlayerCount = 252,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Removed = 251,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	PropsListedInLobby = 250,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	CleanupCacheOnLeave = 249,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	MasterClientId = 248,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	ExpectedUsers = 247,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	PlayerTtl = 246,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	EmptyRoomTtl = 245,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	HasDedicatedMaster = 87
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface EFHLKFIPDPP
{
	[Cpp2IlInjected.Token(Token = "0x17000208")]
	EEGPAMBNKLP AKEHBOGGIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000209")]
	PECONNHPBAN BPEKBDECLLM
	{
		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	bool BPJFFGFHIOO
	{
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	bool HNLPKOIGGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object IGFMFGFKKPJ();

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0xFF3FA0", Offset = "0xFF25A0", VA = "0x180FF3FA0", Slot = "5")]
	(PECONNHPBAN, Dictionary<object, object>) IDBCLOCOANI()
	{
		return default((PECONNHPBAN, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "6")]
	(DAAPNACEHGA, PECONNHPBAN) DHHPODMONEN()
	{
		return default((DAAPNACEHGA, PECONNHPBAN));
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "7")]
	KLAPNFJPOFD<(DAAPNACEHGA, PECONNHPBAN)> PMCKANBNKJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0xFF3FA0", Offset = "0xFF25A0", VA = "0x180FF3FA0", Slot = "8")]
	(AILCKHEHOHJ, byte[]) FKFLHLDKHEP()
	{
		return default((AILCKHEHOHJ, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0xFF3FA0", Offset = "0xFF25A0", VA = "0x180FF3FA0", Slot = "9")]
	(NLIIBEFEBCJ, byte[]) JMHAOODFLCP()
	{
		return default((NLIIBEFEBCJ, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0xFF3FA0", Offset = "0xFF25A0", VA = "0x180FF3FA0", Slot = "10")]
	T LNBDEFBDLKK<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public static class KHEAOGBADGK
{
	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x8184770", Offset = "0x8182D70", VA = "0x188184770")]
	public static bool NCFPDJCILAD(this EFHLKFIPDPP OPFDLFBBADB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface MBGMLGGHALK : KLAPNFJPOFD<CJADACKPEDL>
{
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[DefaultMember("Item")]
public interface KLAPNFJPOFD<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	T FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	int GMOIMINMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public enum EEGPAMBNKLP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	BulkInstantiate = 1,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	BulkDestroy = 2,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	OMSendPacket = 4,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	RR_OutOfBandMessage = 5,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	RR_FastForwardMarker = 6,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RR_SelfJoinMarker = 7,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	RR_DebugOp = 10,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	RR_CachedEvent = 11,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	RRRoomRequestEvent = 20,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	RRRoomRequestFailedResponseEvent = 21,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	RRBufferedRoomEvent = 22,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	RRClearBufferedRoomEvent = 23,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RR_CreationOp = 24,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	RR_CreationOpResponse = 25,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	RR_CreationOp_Unchecked = 26,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	RR_MasterLockBlockComplete = 27,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	RR_NetworkSynchronization = 28,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	RR_NetworkInstantiate = 29,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RR_BulkInstantiate = 31,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	RR_Destroy = 32,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	RR_BulkDestroy = 33,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	RR_TransferOwnership = 34,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	RR_OwnershipUpdate = 35,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	RR_RPC = 36,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	RR_JoinRequest = 100,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	RR_JoinResponse = 101,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	RR_RoomUpdate = 102,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	RR_PlayerUpdate = 103,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	RR_RemotePlayerJoined = 104,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	RR_RemotePlayerLeft = 105,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	RR_Leave = 106,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	RPC = 200,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	SendSerialize = 201,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Instantiation = 202,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	CloseConnection = 203,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Destroy = 204,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	RemoveCachedRPCs = 205,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	SendSerializeReliable = 206,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	DestroyPlayer = 207,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	OwnershipRequest = 209,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	OwnershipTransfer = 210,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	VacantViewIds = 211,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	OwnershipUpdate = 212,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	AuthEvent = 223,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	LobbyStats = 224,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	AppStats = 226,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Match = 227,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	QueueState = 228,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	GameListUpdate = 229,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	GameList = 230,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	CacheSliceChanged = 250,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	ErrorInfo = 251,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	PropertiesChanged = 253,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Leave = 254,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Join = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public enum AILCKHEHOHJ : uint
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	None = 0u,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	NetworkTransformInitializationData = 1314146628u,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	RestoreCreationData = 1380140064u,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	OldestCachedPacketId = 1329811529u,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	SnapshotPublished = 1397773634u,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	SnapshotPayload = 1397771332u,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	SnapshotClear = 1129337683u
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public static class MDCNFNCJDPH
{
	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x8188DC0", Offset = "0x81873C0", VA = "0x188188DC0")]
	public static DAAPNACEHGA KIIAANCGPBO(this PBOLJEHJOJC ACJFHCNBBBO)
	{
		return default(DAAPNACEHGA);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x8188D70", Offset = "0x8187370", VA = "0x188188D70")]
	public static DAAPNACEHGA HDJEGDGMNFC([In] this PBOLJEHJOJC ACJFHCNBBBO)
	{
		return default(DAAPNACEHGA);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x80FEA30", Offset = "0x80FD030", VA = "0x1880FEA30")]
	public static DAAPNACEHGA HMJDAAKKAKD(this PBOLJEHJOJC ACJFHCNBBBO)
	{
		return default(DAAPNACEHGA);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x80FEA30", Offset = "0x80FD030", VA = "0x1880FEA30")]
	public static ViewId BOMBJIIMKKP(this PBOLJEHJOJC ACJFHCNBBBO)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x8189090", Offset = "0x8187690", VA = "0x188189090")]
	public static FixedString64Bytes KLNKFHEMHOA(this NHPHNKOAKCC HLIPPIOIAJK)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x8188E00", Offset = "0x8187400", VA = "0x188188E00")]
	public static FixedString64Bytes KJKKNNEKGAB(this DAAPNACEHGA HLIPPIOIAJK)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x8189260", Offset = "0x8187860", VA = "0x188189260")]
	public static FixedString32Bytes KLNKFHEMHOA(this Entity DFPJIKCEODG)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FKODIEDEAEL : AECMLGGEPDI
{
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public enum KEFDAADNHIP
{
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DIOJGJIOGLE
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<object> HBJNHOPEDBK;

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "2")]
	void DEIMBMBODNH(object FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "3")]
	void KLNNALBELAB(NLIIBEFEBCJ INCFEGIJJJL, ReadOnlySpan<byte> INCLIAEIKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	void PBAKOLDIEEP(AILCKHEHOHJ JLPANLJHHFI, ReadOnlySpan<byte> INCLIAEIKDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GIOKILMHNBN
{
	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NLIIBEFEBCJ GNJKLFHFHHA(ReadOnlySpan<byte> INCLIAEIKDJ);
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JBKFGEGJGHO
{
	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNIFNCLEGMN(NLIIBEFEBCJ BLIBAMJKLIA, ReadOnlySpan<byte> INCLIAEIKDJ);

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJMEECBOGGC(ReadOnlySpan<NLIIBEFEBCJ> MHCKEHDNIPB);
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public struct KNECIHEABJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public NLIIBEFEBCJ INCFEGIJJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public ReadOnlyMemory<byte> INCLIAEIKDJ;
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public struct NLIIBEFEBCJ
{
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public static NLIIBEFEBCJ KHAAJCALKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public NHPHNKOAKCC BHKKMKEIFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public int EFKHBNDJDLI;

	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	public static NHPHNKOAKCC CINNKJOIAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x818A960", Offset = "0x8188F60", VA = "0x18818A960")]
		get
		{
			return default(NHPHNKOAKCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x53701A0", Offset = "0x536E7A0", VA = "0x1853701A0")]
	public NLIIBEFEBCJ(NHPHNKOAKCC BHKKMKEIFKE, int EFKHBNDJDLI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x818AB20", Offset = "0x8189120", VA = "0x18818AB20")]
	public static bool JKIBMILPCGE([In] NLIIBEFEBCJ IAPIHBICBOE, [In] NLIIBEFEBCJ FJDIHEBKFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x818A9B0", Offset = "0x8188FB0", VA = "0x18818A9B0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x818AAC0", Offset = "0x81890C0", VA = "0x18818AAC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x818ABB0", Offset = "0x81891B0", VA = "0x18818ABB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x818AAB0", Offset = "0x81890B0", VA = "0x18818AAB0")]
	public void GMJJAGOJIKC([Out] NHPHNKOAKCC AIEJLCEJPCJ, [Out] int EFKHBNDJDLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class APAGNKMLOPE
{
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public struct NBKFDFCLFFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public Guid PPIICOOCLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public string HDCPENAKGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public Vector3 NHLFNDFGAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public Quaternion CFFPEJBOBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public Vector3 HKINPNLCPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public int KKPNOAIPBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public AKGINPGMGBG MJNKOFMOBDK;

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x818A6B0", Offset = "0x8188CB0", VA = "0x18818A6B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public enum LNDKOKKLEPI
{
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public static class KKMAKLONGCF
{
	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x8185500", Offset = "0x8183B00", VA = "0x188185500")]
	public static bool FMIOLBKKIJC(this LNDKOKKLEPI JLPANLJHHFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x8185520", Offset = "0x8183B20", VA = "0x188185520")]
	public static bool ICJKNHJNCEJ(this LNDKOKKLEPI JLPANLJHHFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x8185530", Offset = "0x8183B30", VA = "0x188185530")]
	public static bool IOJFNADLIBK(this LNDKOKKLEPI JLPANLJHHFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
[Flags]
public enum MKJMPKKDENH
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface ONIBJMBIAFB
{
	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EOLHEGFNIHG([In] Guid LFMKIINCPNH, [Out] Guid PFPDPIHOEAL);
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[Flags]
public enum PDFPJKFKLOD
{
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public interface DPIHEKIAILI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	MMIABAMBHNP LCJAJPGLMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString KKOKKGGBBFG();
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public enum EHPADHNBEMF
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct KLAKHJPEDKJ : ISystemStateComponentData, IComponentData, IEquatable<KLAKHJPEDKJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public float3 PFFIFMIDILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public float3 ALHEMDAAOKF;

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x8185540", Offset = "0x8183B40", VA = "0x188185540", Slot = "4")]
	public bool Equals(KLAKHJPEDKJ HOPHFOOKMCC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OIKMDOGDMJA
{
	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<DAHJHHJGHIB> JJAOPDIJGOK(DAHJHHJGHIB OLLPKLKPIGH);

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GNCKKHJACCD(DAHJHHJGHIB MAKFIOJJNDB, [Out] DAHJHHJGHIB NCAGNOFBJME);
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BIJHHGAMKIO
{
	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AIKIIAFBKBE(long GHKEFPGHNPK);

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CMJBPOMDLLM(NativeParallelHashSet<long> PJCJFAOELIH);

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GINBNOBNJMK(World JLOAJOGDOIE, NativeParallelHashMap<Guid, long> HCJLKANGAGJ);

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AJNILJNLMIP(DAAPNACEHGA EILOFNMLIOM);

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CGNFAJEJOPI(DAAPNACEHGA EILOFNMLIOM, [Out] Guid AIOAKDGGCGL, [Out] long GHKEFPGHNPK);

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GBGPDPILCAP(DAAPNACEHGA EILOFNMLIOM, Guid AIOAKDGGCGL, long GHKEFPGHNPK);

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JBMHCNIIBMJ(Guid AIOAKDGGCGL);

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JBNBJOCHNFI(Guid AIOAKDGGCGL, [Out] int NBCACAFBNAJ, [Out] int ICGCCLAPLIE);

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LGLCJPPBMPK(Guid AIOAKDGGCGL, int NBCACAFBNAJ, int ICGCCLAPLIE);

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PHKOENGNAEE(Guid AIOAKDGGCGL);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000102")]
public class ILCOKFFEKFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public ILCOKFFEKFJ()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
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
