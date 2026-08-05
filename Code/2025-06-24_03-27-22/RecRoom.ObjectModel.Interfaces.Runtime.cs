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
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F9FB20", Offset = "0x7F9E720", VA = "0x187F9FB20", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OPOEAEPALEO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4CE0", Offset = "0x7FA38E0", VA = "0x187FA4CE0")]
	public static void LFOKACLHANF(this Rigidbody CEEGPENJFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4BB0", Offset = "0x7FA37B0", VA = "0x187FA4BB0")]
	public static void LFOKACLHANF(this Rigidbody CEEGPENJFND, Vector3 EHPJPHLEOFL, Quaternion PPICPDJMKLA, Vector3 NPCDPDOGMNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct EDFFLPPIDFO : IReadOnlyList<GBGGLBKJJPC>, IEnumerable<GBGGLBKJJPC>, IEnumerable, IReadOnlyCollection<GBGGLBKJJPC>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct MHCMEALLHEL : IEnumerator<GBGGLBKJJPC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly BNNLGKNFBBF BEIHHAGEJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator PBCAONFLPOM;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public GBGGLBKJJPC FGILBCMPPDP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7FA1280", Offset = "0x7F9FE80", VA = "0x187FA1280", Slot = "4")]
			get
			{
				return default(GBGGLBKJJPC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7FA1230", Offset = "0x7F9FE30", VA = "0x187FA1230", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5278F70", Offset = "0x5277B70", VA = "0x185278F70")]
		public MHCMEALLHEL(BNNLGKNFBBF BEIHHAGEJIL, NativeArray<LocalId>.Enumerator PBCAONFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1170", Offset = "0x7F9FD70", VA = "0x187FA1170", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7FA11B0", Offset = "0x7F9FDB0", VA = "0x187FA11B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7FA11F0", Offset = "0x7F9FDF0", VA = "0x187FA11F0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly OGGBFDFNKPF BEPAMKMBKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> HKCBJNOPFKH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GBGGLBKJJPC HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F93310", Offset = "0x7F91F10", VA = "0x187F93310", Slot = "4")]
		get
		{
			return default(GBGGLBKJJPC);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F92BB0", Offset = "0x7F917B0", VA = "0x187F92BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int FEONCBPPKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C110", Offset = "0xA1AD10", VA = "0x180A1C110", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BNNLGKNFBBF CKPEGOEMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F92E50", Offset = "0x7F91A50", VA = "0x187F92E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int COFHLHAAMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA1C110", Offset = "0xA1AD10", VA = "0x180A1C110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HLKMBCEEOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F92E10", Offset = "0x7F91A10", VA = "0x187F92E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> IGNECJNKBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B24E40", Offset = "0x2B23A40", VA = "0x182B24E40")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> GEOKFKOKEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F92750", Offset = "0x7F91350", VA = "0x187F92750")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F93120", Offset = "0x7F91D20", VA = "0x187F93120")]
	public EDFFLPPIDFO(int PDJAEHLNOAH, BNNLGKNFBBF BEIHHAGEJIL, Allocator CMJGNOOCEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F93110", Offset = "0x7F91D10", VA = "0x187F93110")]
	public EDFFLPPIDFO(OGGBFDFNKPF BEPAMKMBKNC, NativeArray<LocalId> HKCBJNOPFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F92F80", Offset = "0x7F91B80", VA = "0x187F92F80")]
	public EDFFLPPIDFO(OGGBFDFNKPF BEPAMKMBKNC, NativeArray<Entity> HKCBJNOPFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F931D0", Offset = "0x7F91DD0", VA = "0x187F931D0")]
	internal EDFFLPPIDFO(BNNLGKNFBBF BEIHHAGEJIL, NativeArray<Entity> NKHJILJFELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F92FF0", Offset = "0x7F91BF0", VA = "0x187F92FF0")]
	internal EDFFLPPIDFO(BNNLGKNFBBF BEIHHAGEJIL, NativeArray<LocalId> HKCBJNOPFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F93260", Offset = "0x7F91E60", VA = "0x187F93260")]
	public EDFFLPPIDFO(BNNLGKNFBBF BEIHHAGEJIL, int FMOIHNPEKPL, Allocator CMJGNOOCEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F93060", Offset = "0x7F91C60", VA = "0x187F93060")]
	public EDFFLPPIDFO(EDFFLPPIDFO CNEDFPHDGBE, Allocator CMJGNOOCEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F927B0", Offset = "0x7F913B0", VA = "0x187F927B0")]
	public void BMGNJMMNIBI(List<GBGGLBKJJPC> DNNGKIFFAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F92700", Offset = "0x7F91300", VA = "0x187F92700")]
	public void AHGEDCOHLPA(int EMMACFPOKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F92C10", Offset = "0x7F91810", VA = "0x187F92C10")]
	public EDFFLPPIDFO KIKIFBKOCFE(Allocator CMJGNOOCEGA)
	{
		return default(EDFFLPPIDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F92A60", Offset = "0x7F91660", VA = "0x187F92A60")]
	public Span<GBGGLBKJJPC> EAKAKOCILJH()
	{
		return default(Span<GBGGLBKJJPC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F92D70", Offset = "0x7F91970", VA = "0x187F92D70")]
	public EDFFLPPIDFO MICGKJIPEEC(int EILAIOEPAPK, int FMOIHNPEKPL)
	{
		return default(EDFFLPPIDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F92A20", Offset = "0x7F91620", VA = "0x187F92A20", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7F92CB0", Offset = "0x7F918B0", VA = "0x187F92CB0")]
	public MHCMEALLHEL MEEEBEDBKAB()
	{
		return default(MHCMEALLHEL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F92EA0", Offset = "0x7F91AA0", VA = "0x187F92EA0", Slot = "6")]
	private IEnumerator<GBGGLBKJJPC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7F92F10", Offset = "0x7F91B10", VA = "0x187F92F10", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ODFKDFBLANK
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E460", Offset = "0x3C6D060", VA = "0x183C6E460")]
	public static HBFEOHNMHAE<T> KGJOOOPNCNO<T>(this EDFFLPPIDFO ENEAIMANIIG) where T : Component
	{
		return default(HBFEOHNMHAE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct DLJNFMBIPPJ : IList<GBGGLBKJJPC>, ICollection<GBGGLBKJJPC>, IEnumerable<GBGGLBKJJPC>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct JMIEFJAPKNE : IEnumerator<GBGGLBKJJPC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly BNNLGKNFBBF BEIHHAGEJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator PBCAONFLPOM;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GBGGLBKJJPC FGILBCMPPDP
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7F9B490", Offset = "0x7F9A090", VA = "0x187F9B490", Slot = "4")]
			get
			{
				return default(GBGGLBKJJPC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7F9B440", Offset = "0x7F9A040", VA = "0x187F9B440", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5278F70", Offset = "0x5277B70", VA = "0x185278F70")]
		public JMIEFJAPKNE(BNNLGKNFBBF BEIHHAGEJIL, NativeArray<LocalId>.Enumerator PBCAONFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7F9B380", Offset = "0x7F99F80", VA = "0x187F9B380", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F9B3C0", Offset = "0x7F99FC0", VA = "0x187F9B3C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7F9B400", Offset = "0x7F9A000", VA = "0x187F9B400", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly BNNLGKNFBBF BEIHHAGEJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> HKCBJNOPFKH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GBGGLBKJJPC HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7F91CF0", Offset = "0x7F908F0", VA = "0x187F91CF0", Slot = "4")]
		get
		{
			return default(GBGGLBKJJPC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7F91DE0", Offset = "0x7F909E0", VA = "0x187F91DE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7F916F0", Offset = "0x7F902F0", VA = "0x187F916F0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int COFHLHAAMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7F916F0", Offset = "0x7F902F0", VA = "0x187F916F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> IGNECJNKBAK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B24E40", Offset = "0x2B23A40", VA = "0x182B24E40")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KKNAEFNJMGF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F91C70", Offset = "0x7F90870", VA = "0x187F91C70")]
	public DLJNFMBIPPJ(BNNLGKNFBBF BEIHHAGEJIL, Allocator CMJGNOOCEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7F91BE0", Offset = "0x7F907E0", VA = "0x187F91BE0")]
	public DLJNFMBIPPJ(BNNLGKNFBBF BEIHHAGEJIL, int FMOIHNPEKPL, Allocator CMJGNOOCEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F915E0", Offset = "0x7F901E0", VA = "0x187F915E0")]
	public EDFFLPPIDFO FEPCGFBFDCP()
	{
		return default(EDFFLPPIDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F91300", Offset = "0x7F8FF00", VA = "0x187F91300", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F91340", Offset = "0x7F8FF40", VA = "0x187F91340", Slot = "13")]
	public bool Contains(GBGGLBKJJPC ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F913D0", Offset = "0x7F8FFD0", VA = "0x187F913D0", Slot = "14")]
	public void CopyTo(GBGGLBKJJPC[] IKALPCJBCLK, int CEPNAODLCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F91280", Offset = "0x7F8FE80", VA = "0x187F91280", Slot = "11")]
	public void Add(GBGGLBKJJPC ONKLOOMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F917C0", Offset = "0x7F903C0", VA = "0x187F917C0", Slot = "7")]
	public void Insert(int EMMACFPOKFB, GBGGLBKJJPC ONKLOOMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7F91950", Offset = "0x7F90550", VA = "0x187F91950", Slot = "15")]
	public bool Remove(GBGGLBKJJPC ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7F91730", Offset = "0x7F90330", VA = "0x187F91730", Slot = "6")]
	public int IndexOf(GBGGLBKJJPC ONKLOOMCJOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7F91900", Offset = "0x7F90500", VA = "0x187F91900", Slot = "8")]
	public void RemoveAt(int EMMACFPOKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F915A0", Offset = "0x7F901A0", VA = "0x187F915A0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7F91870", Offset = "0x7F90470", VA = "0x187F91870")]
	public JMIEFJAPKNE MEEEBEDBKAB()
	{
		return default(JMIEFJAPKNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7F91A20", Offset = "0x7F90620", VA = "0x187F91A20", Slot = "16")]
	private IEnumerator<GBGGLBKJJPC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7F91B00", Offset = "0x7F90700", VA = "0x187F91B00", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DDHFEHEHOPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GBGGLBKJJPC IIOPCKDFHEH(GBGGLBKJJPC HKCBJNOPFKH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KOEGMNDDJGF : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface JDBCEGGLCFN : EJBOBNHHFCE, CLJEBCIFPND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	BJBGLOOCAAJ GGMIIEDCLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	OGGBFDFNKPF PHGGKMMOPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface CLJEBCIFPND
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool PPEACIHDMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface HLPBMDILIPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCFLNFNOKMN(bool OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILJKHADAMOK();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface KLFEMCBFHKC
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool FPOPMAGMNEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool KJJJCFPPAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool FALNHLEEHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool CHOGLEAEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool FBFHFGMECFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CNGMJLGGPNK(bool DAMJJNFLPNM);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HKFLONGJPLE(ByteString ELJEDMCONKF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HOJELHHBLPD();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LONCLLEGBFE();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DMLOAJBBKBD();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface COKECCKPMJD
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	OLKHLOEBPJH GGMIIEDCLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	KOKIMCDKHNC GKJBDADONDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	OOIKPNNGOPE EABAFNMCBGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	JDBCEGGLCFN JDIANLGEMMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	KDLGBKDKOGH NDFPFGDAPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	KLFEMCBFHKC EDOHCFMOEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	AFLKGGANELK APBPIBEOEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	BNDCOFDPGEP BDKAACHOIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	AHNOMBGEGCI AJADFFOPBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	OGJOONKMAFC BILKCCFOPBP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	DJNEJMCNLGN CPDDIEFPFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	ANGMIKFLIGC OPBEMOPONLB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	BNNLGKNFBBF CKPEGOEMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	NAPPFKMHMBI AIPBPECPPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	FCCHHHFAFPC EBJPDBEABEH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	NLAGGDIGIND HABLEHDHEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	KMBJEGLJKKF KHMBCBKKFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ECEKGFJENJP CBLMLAACNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	FLCHLFOMKAN PJINHEPDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	PEHOCFBOMFM DAAHGMEAANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NLLFABDOIGH GGCDOHHJJJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	PPJGJJLCEOG CNGHPICEGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	AIFNOKLMGEM PGBEFHGANEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	NEHCENEIDAI ILJKJFDONCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	MAKBBLKFAAF COABBPBMKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	GMMMEDMHNJN KLCPKCFHEAF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	CKDKJFBJHAH LJHKBFJHCCN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	CGHCFDJMGCD ICPKOBDFLDG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	POIFENLBGHJ HFKBNADKIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	HFHOLDMNOBH OHOCIIGPLCE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	IGJPLOFHPFK HNPBEMIFAHK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	DIOBJPDBJAJ MLDHFINAALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	HFFKJKEAFEC KCPMIFFIICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	MHPMBGAOEOP DONGBLLLLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	EELOJCDDLBJ BHOCNOFDODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	COEGIEAFHBM EMPLJBDAFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	LGPCKFACDNO EFGMJHJPPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerTypeProxy(typeof(EINDLIKHNFP))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct GBGGLBKJJPC : IComparable<GBGGLBKJJPC>, IEquatable<GBGGLBKJJPC>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly GBGGLBKJJPC CBFHDBFDJFA;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int NLOALLKGCHO = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int BNINDDADKKJ = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int NFHCDLBGFDD = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int ODLNCFIPMNE = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId EAOPNGFGOCP;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BNNLGKNFBBF CKPEGOEMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7F968D0", Offset = "0x7F954D0", VA = "0x187F968D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public JDBCEGGLCFN JDIANLGEMMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7F96AA0", Offset = "0x7F956A0", VA = "0x187F96AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public LocalId MAJLHMAKMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7F970A0", Offset = "0x7F95CA0", VA = "0x187F970A0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	internal OGGBFDFNKPF PHGGKMMOPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7F96B00", Offset = "0x7F95700", VA = "0x187F96B00")]
		get
		{
			return default(OGGBFDFNKPF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool DOBEMPPDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7F96E10", Offset = "0x7F95A10", VA = "0x187F96E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private bool EGMDEEIDEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7F97050", Offset = "0x7F95C50", VA = "0x187F97050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7F97210", Offset = "0x7F95E10", VA = "0x187F97210")]
	public GBGGLBKJJPC(BNNLGKNFBBF MKPKCEHDGOH, LocalId EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7F972D0", Offset = "0x7F95ED0", VA = "0x187F972D0")]
	public GBGGLBKJJPC(OGGBFDFNKPF BEPAMKMBKNC, LocalId EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
	public GBGEFMIEGNI IGGNIHJKBID()
	{
		return default(GBGEFMIEGNI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7F96DD0", Offset = "0x7F959D0", VA = "0x187F96DD0")]
	public static LocalId GHOKLFELACP(GBGGLBKJJPC FFCOGJOEHDN)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F96D90", Offset = "0x7F95990", VA = "0x187F96D90")]
	public static Entity GHOKLFELACP(GBGGLBKJJPC FFCOGJOEHDN)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7F96F30", Offset = "0x7F95B30", VA = "0x187F96F30")]
	public static bool JOHLOKGLNML(GBGGLBKJJPC ABBBJFPFEKP, GBGGLBKJJPC KLKIJPOLHDE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7F961D0", Offset = "0x7F94DD0", VA = "0x187F961D0")]
	public static bool FOFOJFKGMNN(GBGGLBKJJPC ABBBJFPFEKP, GBGGLBKJJPC KLKIJPOLHDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7F970E0", Offset = "0x7F95CE0", VA = "0x187F970E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F96C00", Offset = "0x7F95800", VA = "0x187F96C00", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F96B10", Offset = "0x7F95710", VA = "0x187F96B10", Slot = "4")]
	public int CompareTo(GBGGLBKJJPC GMNGNCHKEBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "5")]
	public bool Equals(GBGGLBKJJPC GMNGNCHKEBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class OJHMOCOBKJG
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4B00", Offset = "0x7FA3700", VA = "0x187FA4B00")]
	public static PLLPLODJPBF AFGOGEGFECH(this GBGGLBKJJPC KDKJDFFGNJJ)
	{
		return default(PLLPLODJPBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class EINDLIKHNFP
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct OGGBFDFNKPF : IEquatable<OGGBFDFNKPF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte BEPAMKMBKNC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] EJOMAHOPPJE;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static BNNLGKNFBBF MPACIAPGOFH;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static JDBCEGGLCFN FJCPBGALONE;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static BNNLGKNFBBF[] OHJHHKEFAAB;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static JDBCEGGLCFN[] ALAOBOAPIAO;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> EPFAKGIEJGK;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public JDBCEGGLCFN JDIANLGEMMO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3FF0", Offset = "0x7FA2BF0", VA = "0x187FA3FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public BNNLGKNFBBF GIHIBCBBJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4520", Offset = "0x7FA3120", VA = "0x187FA4520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4AF0", Offset = "0x7FA36F0", VA = "0x187FA4AF0")]
	static OGGBFDFNKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C480", Offset = "0x2B6B080", VA = "0x182B6C480")]
	internal OGGBFDFNKPF(byte OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6E31FF0", Offset = "0x6E30BF0", VA = "0x186E31FF0", Slot = "4")]
	public bool Equals(OGGBFDFNKPF GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4340", Offset = "0x7FA2F40", VA = "0x187FA4340", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xFA8900", Offset = "0xFA7500", VA = "0x180FA8900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4A30", Offset = "0x7FA3630", VA = "0x187FA4A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7FA43E0", Offset = "0x7FA2FE0", VA = "0x187FA43E0")]
	private static BNNLGKNFBBF FEEBKMOGOIF(byte BEPAMKMBKNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4480", Offset = "0x7FA3080", VA = "0x187FA4480")]
	private static JDBCEGGLCFN HHKLNOGDBJO(byte BEPAMKMBKNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4610", Offset = "0x7FA3210", VA = "0x187FA4610")]
	private static object KFOGGHNFPMA(byte BEPAMKMBKNC, object[] AIPJHMCGMIB, object IPOLOHBNCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4600", Offset = "0x7FA3200", VA = "0x187FA4600")]
	private static int JGCKKJDFPEF(byte BEPAMKMBKNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4A10", Offset = "0x7FA3610", VA = "0x187FA4A10")]
	private static int NNIHMNLPNJA(byte BEPAMKMBKNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7FA42C0", Offset = "0x7FA2EC0", VA = "0x187FA42C0")]
	private static (int, int) DECDKHGKGMG(byte BEPAMKMBKNC)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4A20", Offset = "0x7FA3620", VA = "0x187FA4A20")]
	private static byte OPLMLDENNEE(int JBMEHOAGBAN, int EMMACFPOKFB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4770", Offset = "0x7FA3370", VA = "0x187FA4770")]
	internal static OGGBFDFNKPF KHPGHNAFBFC(JDBCEGGLCFN LHDEGMCKBKO, BNNLGKNFBBF DLFIGPDLPBH)
	{
		return default(OGGBFDFNKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA40D0", Offset = "0x7FA2CD0", VA = "0x187FA40D0")]
	internal static void BFGPHHDGACD(OGGBFDFNKPF BEPAMKMBKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3C90", Offset = "0x7FA2890", VA = "0x187FA3C90")]
	private static void AEIMIGAKOLA(int PDJAEHLNOAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum FPAHLLAJKMM
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
public interface HKKGGFHOHPK
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool OKEFEEFGMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool KHAABKOLMGG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool AMCOKLPEMMP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool KAKCAEHILMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool CAMFLIKLLPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NDCBDPCDCMD
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ONABBGBMGIC(GJGDLAGAJME MHCMGFKMEEN, int EMMACFPOKFB);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CHBIHLIBHHA(GJGDLAGAJME COIKCNJKFKO, int EMMACFPOKFB);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MKMNBADEJCN(INKLBHCAEHL MBOJJJMBPDH, int EMMACFPOKFB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CEMENICCMKO : GJGDLAGAJME, HKKGGFHOHPK
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	int IPLLEAKJOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKGNNBNEAGE(KEEGLIIBMPB DAAJJNMMALF, int EMMACFPOKFB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GJGDLAGAJME : HKKGGFHOHPK
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum CEGJFBJCAJN
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

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool IHGHFJIAMMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool FMBJFNCHPBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool FNDEJKALGBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KEEGLIIBMPB
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool BFCHJCHJJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	DDKHKNGGFFK PJOADDMNFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	HDCJKDBKFML JDNHFAIPNIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float3 AIFJIFCFPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	quaternion FFNFOABACEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float3 KFBJOMJJKHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	PNJAKOMAJFI NCKFIMBLHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	LGJLDBFLECO NLKOKMDALIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float IKGOEOBCJNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float3 DAAPPGHMJIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float PCPJHABEDLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	DAMCLPLILIH CIBCHAPBFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface NEHABIANDOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	float3 GKIMFBHMEAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	float3 CAFENJPBDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion MIFHADELGMG(float3 GINDDCIIAAF);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface HDCJKDBKFML
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool MOPIONDHEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool GGMHMHIBFCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool BCLPPAANIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	float HNKFFHFOEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int KMMEFBHACEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	int FMLGDFPOEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FDFADFFHGLO(NEHABIANDOJ DAAJJNMMALF, int EMMACFPOKFB);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.Application)]
public interface FNBGLOAOKBH
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	Guid MFFBEECJOMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ALLJPFLDPIB(Guid MCLIOLJNHFD, Guid GKLJHCMGFAB, Guid KLLOKDBCBDD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task PPAIKKEPGDC(Guid MCLIOLJNHFD, Guid[] ANPJCOOCPBL, Guid KLLOKDBCBDD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid KDOAOEAMHKO(Guid LMBLGALMBCI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PFMJMGFMFIK(GBGGLBKJJPC DJGPHCJGAGN);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JIFNDLGODJH(Guid LMBLGALMBCI);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OCHCPLPFMGJ(NHOBIEOLNMI HIFPKFLIMAE, Guid CFJHLLCMOII);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PPBKPHOHBNH(Guid LMBLGALMBCI, bool DAMJJNFLPNM);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LJOEHFOHJKC(Guid LMBLGALMBCI, PLLPLODJPBF DCHNNCLJCAA);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GHELBKHHAEL(PLLPLODJPBF DCHNNCLJCAA);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PDBIIPKOHMF(GBGGLBKJJPC EAOPNGFGOCP);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface FIMFJKLCIEC
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface FAJJMEKHFNF
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "0")]
	void DFIPJCOJCHC(bool AENFHNMCJOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface KOKIMCDKHNC
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	FAJJMEKHFNF MOGPLOADICO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	NMHFKAAEABE DNICHDJEFCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	KNLAJMHCBIC PDIBADJACND
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	HAPHOAILNEL GOMJKBBNHOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	OJIMFEKPJFE MBNBCOIHGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	IPMPOKEIPCD IBHOLEKLDHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	PPKDLJBFFKL OKGBNGCIMDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	MAFCBEMGACL OAPDDINGMMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface NMHFKAAEABE
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	string HNGLJJJOILC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface JJFFJHDHDAC
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLOBMPPJNAF(Action IFDCDCHOGGB, bool CICOMCHNDIO);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CLIADENEHKE(string LAOCJKNALFF);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int KAGOMEGHHGP(string LAOCJKNALFF, int IPOLOHBNCGD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OLDNOGEGIKF([Out] bool OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OFCMMINCKHM([Out] bool OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GEMBPPLCPMG([Out] int OOHGFGHCOAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface KNLAJMHCBIC
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "0")]
	void DBLJICJBCFO(bool DAMJJNFLPNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface HAPHOAILNEL
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid NJAEKDDCHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid MKODHMDKOBP;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid FEHEAGANJBC;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid OCNAMCNBDEC;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool KDAPHLMANFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	bool IOMGAMGFFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	bool FOGOLLOBBFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F97FD0", Offset = "0x7F96BD0", VA = "0x187F97FD0", Slot = "3")]
	string[] OKKLGBBFFBB(JIEEKEEBHCL FKPKEALHCCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BIKPAGGHJGO();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7F97FA0", Offset = "0x7F96BA0", VA = "0x187F97FA0", Slot = "5")]
	Guid ECPPEPKBAMP(Guid KEHLNMLEOEL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int IANJALABGCN(JIEEKEEBHCL FKPKEALHCCP);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GHONBMLJAPD(JIEEKEEBHCL FKPKEALHCCP, NativeArray<DANCMKCABBF> OGGBMDEKFHN, NativeList<UniformTRS> GJJEHFMADDK);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int EEKOPBLFNFH(Guid LHECJJHBNHF);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KBANKKPKIPO(string KJKNEFAFPLG, [Out] Guid LHECJJHBNHF);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string NEKMGOHLLPD(Guid LHECJJHBNHF);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KJGCCKNACNK(RRObjectPrefabData JKBHLGCNCNE, [Out] LocalId JMNEAPNCNHN);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HBFEOHNMHAE<byte[]> KHBNOMAEIND(NativeArray<DANCMKCABBF> PAPGHGNEIBB);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CFMBGBDGKAP(byte[] FEJIMEBDDBJ);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GameObject MMMCPMFEOAF(string KJKNEFAFPLG);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HPLLMFPDEIP(Transform NMIBCHFJGAE, RRObjectPrefabData FLCEJFFOMMN, GJAKMMJKIGI CBLPKFIJGLH);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool NEGECNDJHHJ(JIEEKEEBHCL FKPKEALHCCP, NativeParallelHashMap<Guid, LocalId> BIBJIIMKKBH, [Out] Exception OBGCCKHNEKJ);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MHBBIMPHFDK(JIEEKEEBHCL FKPKEALHCCP, NativeParallelHashMap<Guid, LocalId> BIBJIIMKKBH, [Out] NativeArray<LocalId> NKHJILJFELH, [Out] NativeArray<LocalId> MKBPPMEGIKB, [Out] NativeArray<AuthoredLocalPoseData> BOGIIKKEJPM, Allocator CMJGNOOCEGA);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "18")]
	void MJFFHJJJBLA(JIEEKEEBHCL DEELHKGGHPE, NativeArray<int> AOGBBJDELEI, JAGGGNKIKJG<GameObject> IJFIMMBOJLK, HBFEOHNMHAE<GameObject> MNCBDDJBGFO, FPAHLLAJKMM NADPDHGDDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IBFBDBNGMKM();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "20")]
	void HENPONENGFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "21")]
	void LMIKOGBEPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "22")]
	bool EHMDMBJHOLM(JIEEKEEBHCL FKPKEALHCCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "23")]
	NDCBDPCDCMD KNDCDCBKAPK(JIEEKEEBHCL FKPKEALHCCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "24")]
	void CFIONOCFNNP(Guid NCHDMOCJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "25")]
	bool CPINKPBIPGF(Guid NCHDMOCJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7F98060", Offset = "0x7F96C60", VA = "0x187F98060")]
	static HAPHOAILNEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface PPIINJBMAGL
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	long GAJEPFKHBMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	long MJCPBDFGJPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface OJIMFEKPJFE
{
	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool IDBGBOKLOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool DIHOLIIEPMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	int PGDMGEMOHPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	int NJEGMIIDGMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	int CJPCPLEDDLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool JLECBALCNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int LGOIOMKHNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "6")]
	void LDDPCDONNCE(NNPEOCDJHNF ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
	void CKCMOLBEMII(bool HIEJJEDELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "8")]
	bool NJAGHFPCKCH(LDINANBBIGL EOHMOFMBNIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "9")]
	void KKNEGJEDMCG(object ADKJHPADFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "10")]
	void GCNMMKLDCBP(object ADKJHPADFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KPFKFEENGBJ(Action<object> PKPICGJJKNN);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NFFJCGHJNPB(Action<object> PKPICGJJKNN);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "13")]
	void MOACDDFDEIA(NativeArray<ViewId> PEMNJLIDFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "14")]
	void NKIPDBOAHDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "15")]
	void CDOOANDIKDL(FAPEBMBEKBP OPOPAMPKKGD, ReadOnlySpan<byte> PEDMEJIDLNB, LDINANBBIGL LKIPHEHMEBC, bool MCHGKPOGGMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "16")]
	void CDOOANDIKDL(FAPEBMBEKBP OPOPAMPKKGD, ReadOnlySpan<byte> EAHCPJFHBAH, bool MCHGKPOGGMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "17")]
	void CDOOANDIKDL(FAPEBMBEKBP OPOPAMPKKGD, ReadOnlySpan<byte> EAHCPJFHBAH, ReadOnlySpan<byte> CPEEIHCNELH, bool MCHGKPOGGMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "18")]
	void ACOPHAAJBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "19")]
	void ILOPIKKDPLG(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "20")]
	void FLIJBHODGFH(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "21")]
	void HFCGEEMKJDF(Dictionary<object, object> APNHEJEKBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "22")]
	void KDJMGIPNJLN(NativeList<PLLPLODJPBF> DIJMALDBJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "24")]
	void FOJKFHCGKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "25")]
	void NKGLACCALCC(List<object> OJHGNMCGJFK, int DPCFFPEBOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "26")]
	void NJOLKELAJJA(int NDMJKJBHIAJ, object AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "27")]
	void BJCDHMKOGKA(LDINANBBIGL EOHMOFMBNIL, Dictionary<object, object> JBCEKMOHDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "28")]
	void PNOPLHJACOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "29")]
	void BCGIALCJEOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class CGEGFAFNHOF
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7F90A00", Offset = "0x7F8F600", VA = "0x187F90A00")]
	public static MGFMCHGOBJG BFCHGJHAGDE(this OJIMFEKPJFE BNLGIODIEPM, object HEDGIMBCGHA)
	{
		return default(MGFMCHGOBJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct MGFMCHGOBJG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private OJIMFEKPJFE BNLGIODIEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object HEDGIMBCGHA;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0480", Offset = "0x7F9F080", VA = "0x187FA0480")]
	public MGFMCHGOBJG(OJIMFEKPJFE BNLGIODIEPM, object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0430", Offset = "0x7F9F030", VA = "0x187FA0430", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AABOODEENBH
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate void EIMBJENBEDD(ViewId AAHKEEEBFIN, JADGOGMAGBG FOOEOLNDGBE, int MONEFJFBDPB);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "0")]
	void CPAMPFHGGFK(EIMBJENBEDD DCINLPBGPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "1")]
	void BPHBDMOKGOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "2")]
	void HBIOMGIPKNA(GFAMPFOJDDN KHKBFEMNDEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ServiceLifetime(Lifetime.Application)]
public interface FCEBIFEDDDL
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface IPMPOKEIPCD
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct HKAGIAFIHJI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private IPMPOKEIPCD CKEMIGBBBLA;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7F984D0", Offset = "0x7F970D0", VA = "0x187F984D0")]
		public HKAGIAFIHJI(IPMPOKEIPCD CKEMIGBBBLA, string CBBHDDJIAGB, string OINDNNFPHJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7F98410", Offset = "0x7F97010", VA = "0x187F98410", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct MIMGHAIFMKJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private IPMPOKEIPCD CKEMIGBBBLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task NKDMFOKACBI;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1590", Offset = "0x7FA0190", VA = "0x187FA1590", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "0")]
	void ACNNCJLBHDG(string FNFIPKNHEOF, float PMNGLFBCFIN = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "1")]
	void ALGCOALINJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EJGBCOCFOMP(bool JABABILEDKD, string CBBHDDJIAGB, string OINDNNFPHJC);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "3")]
	void IDAPJJKGOJL(string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class PLIMMIOGHBA
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7550", Offset = "0x7FA6150", VA = "0x187FA7550")]
	public static IPMPOKEIPCD.HKAGIAFIHJI HDGLMACJEKM(this IPMPOKEIPCD BNLGIODIEPM, string CBBHDDJIAGB, string OINDNNFPHJC)
	{
		return default(IPMPOKEIPCD.HKAGIAFIHJI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[ServiceLifetime(Lifetime.Application)]
public interface DCFOLABJIMB
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GFFBNADGCND(GameObject AOALCMHDOFP);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFKMDPICKAF(GameObject AOALCMHDOFP);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PLMEECKBEKC(int EOHMOFMBNIL);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object MBPJPFHPOLM(GBGGLBKJJPC EAOPNGFGOCP, GameObject AOALCMHDOFP, Action<GBGGLBKJJPC, int> LKGGIMHKLEG);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDGHJHDEFCK(GameObject AOALCMHDOFP, object OKPMKNIGKAG);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CLHHKIPENNE
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EBCDGODJGHA(LJNJPJOGIHD MPFBANPBMKI, DBAKCHLGNBP PMNLAKKLOLA);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface HACDKHEHDLB
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLPDEIDOFHH(object KDKJDFFGNJJ, NativeList<byte> PEDMEJIDLNB);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object EBAGJKMAFHO(NativeArray<byte> PEDMEJIDLNB);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface EHBEADDPELN
{
	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool GKJBOJKFBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate NBOCNIBDCMP(MBNIPOOIKJF KPHBKFALBDF, Action<MBNIPOOIKJF> LKGGIMHKLEG);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ACPDDMMFNFO(MBNIPOOIKJF KPHBKFALBDF, Delegate LKGGIMHKLEG);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate IJOEDIIIBCE(MBNIPOOIKJF KPHBKFALBDF, Action<MBNIPOOIKJF> IKANMJHGPPG);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GGLCIDMFICK(MBNIPOOIKJF KPHBKFALBDF, Delegate LKGGIMHKLEG);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KAAEIICEOJI(MBNIPOOIKJF KPHBKFALBDF);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MBNIPOOIKJF FDJIPLMPBLB(GameObject AOALCMHDOFP);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface BMNJEMHFHNE
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int CILDBHLFPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	int LHPGJCKJOFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool IDBGBOKLOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool OCOOPFIBOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool FBKGLCFBDFG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GBGGLBKJJPC IDGHAKMFICP(int EOHMOFMBNIL);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ODNAKHJHHBN(GameObject KGIFKLHCKKI, JobHandle IBPOHIOILAF);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface JJBJFMJFHNL
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EBCDGODJGHA(int KJIKHIJJPOK, DBAKCHLGNBP NONBAJMGCBM);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
public interface PPKDLJBFFKL
{
	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool FPOPMAGMNEN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.Application)]
public interface KLONDPBKHOO
{
	[Cpp2IlInjected.Token(Token = "0x17000081")]
	MEFOENIIPMB IMIHMFPONKH
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	FOCKMLOJPND FANILCBKBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool HPMLFFOAPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OPLNJFMMLFB(Transform NMIBCHFJGAE);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KDGEPCDGANH(Transform NMIBCHFJGAE, JOMANKOGPON PBMEBACPAGC);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DEOAKADPECG(Transform NMIBCHFJGAE, AGAICHLALAG FPDMHGECAFI);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.Application)]
public interface MAFCBEMGACL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MGGEJPDDIJG;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface DDAOPHEMMOI
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDMNNNFOFKD();
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.Application)]
public interface BFIDCBJGHGN
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEHFDGOKGHD(GameObject AOALCMHDOFP, EPNMKAKCGCP MOGLLAILMJK, JJAKBBFCFFN GNHFOJAJCIO);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EPGIMKFJIOA(GBGGLBKJJPC EAOPNGFGOCP, bool ABLBLCIIDOA, float3 KODDILHMBDE, quaternion JNGPEBPJJHL);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KALOHKDLGHO(EDFFLPPIDFO OHKHNHILKKC);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PKINOOLNIKB(GBGEFMIEGNI IJNCJOKBAFO, GBGEFMIEGNI MDKAAPLMLKG, FBBLGIGMICK OCHMMOHMIHP);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FEFCJEDCKFE(GBGEFMIEGNI IJNCJOKBAFO, FBBLGIGMICK OCHMMOHMIHP);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PMPFAKFBFFF(EDFFLPPIDFO JDLCLEMAEDM);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MHCLKACNBAL(JIEEKEEBHCL GCHJKMFEAOA, ReadOnlySpan<Guid> KGKNINJOHPL, ReadOnlySpan<int> IALAPHHBGPF, HBFEOHNMHAE<GameObject> BJBEEPJNPIE);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PNKGBKICBMH(BAPIJFCDNAC NOFOOCBNKOH);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct IBMIBKIGPPF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> PEDMEJIDLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle BEPAMKMBKNC;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A050", Offset = "0x7F98C50", VA = "0x187F9A050")]
	public IBMIBKIGPPF(ReadOnlyMemory<byte> JCOAOOCLABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A010", Offset = "0x7F98C10", VA = "0x187F9A010", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum OKKEPEHCGIN
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
public struct JIEEKEEBHCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString CAMDFEKADFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object PHDENLGHLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object LNPKDGKOILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> FBFBNALAPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool GMBMJOGHEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public BCEKJLJLIMJ.IAHOAMGIEAH? FIHJJCADFPI;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B300", Offset = "0x7F99F00", VA = "0x187F9B300")]
	public JIEEKEEBHCL(ByteString CAMDFEKADFO, [Optional] object PHDENLGHLEE, [Optional] object LNPKDGKOILE, [Optional] IEnumerable<string> FBFBNALAPAA, bool GMBMJOGHEMN = true, [Optional] BCEKJLJLIMJ.IAHOAMGIEAH? FIHJJCADFPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct HBDGGGAJPKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object BGJDBEFJPBC;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct DANCMKCABBF
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[Flags]
	public enum FCBELFPJGBK
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
	public RRObjectPrefabData HAKAFAOLAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid OAKDFCIMAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid FHFKMAFMEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid EOIFKJGOLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid KHHBAMJHCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public FCBELFPJGBK GEFKHBLJENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 KHNGGFHHMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int MAFPHIKGPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public EIKEEHFPHOM NMCKOMAMCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int KNDOCBPPEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int EJOKEPPIIGO;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Guid PIPNJLHCFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x52747C0", Offset = "0x52733C0", VA = "0x1852747C0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool PCHALNKMPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7F91260", Offset = "0x7F8FE60", VA = "0x187F91260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public bool EDMJCDDNDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7F91240", Offset = "0x7F8FE40", VA = "0x187F91240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool FEMKPIEFBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7F91250", Offset = "0x7F8FE50", VA = "0x187F91250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool FLAJKKNLMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7F91270", Offset = "0x7F8FE70", VA = "0x187F91270")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct GNNMBFHNIEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly JOIOBPEJMMD EILAIOEPAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly JOIOBPEJMMD NHCGLFAFCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal readonly uint HHMECCALHEO;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7F97C00", Offset = "0x7F96800", VA = "0x187F97C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct HCMDGDIPGKB
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal readonly GNNMBFHNIEB IFDCDCHOGGB;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7F98180", Offset = "0x7F96D80", VA = "0x187F98180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct NDBEOLDNBHM
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly GNNMBFHNIEB IFDCDCHOGGB;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7F98180", Offset = "0x7F96D80", VA = "0x187F98180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct NANNMGKBILB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly uint HHMECCALHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly bool APNMPKGJNFG;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA16F0", Offset = "0x7FA02F0", VA = "0x187FA16F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct JOIOBPEJMMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal int KPHEINADMCH;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B560", Offset = "0x7F9A160", VA = "0x187F9B560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[ServiceLifetime(Lifetime.Application)]
public interface ELNAPNPGAGM
{
	[Cpp2IlInjected.Token(Token = "0x17000089")]
	MFONIEFNMGH ACCFNKGCLKD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface NHOBIEOLNMI
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface NDPGIELEHDE
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class AJGNGHGGEAK
{
	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3045E80", Offset = "0x3044A80", VA = "0x183045E80")]
	public static GBGEFMIEGNI IGGNIHJKBID<T>(this T EAOPNGFGOCP) where T : NHOBIEOLNMI
	{
		return default(GBGEFMIEGNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FC60", Offset = "0x7F8E860", VA = "0x187F8FC60")]
	public static MonoBehaviour KONJIKGFPLI(this NHOBIEOLNMI EAOPNGFGOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FCE0", Offset = "0x7F8E8E0", VA = "0x187F8FCE0")]
	public static GameObject OPELENGGFMH(this NHOBIEOLNMI EAOPNGFGOCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface AEEBKLIANEM : NHOBIEOLNMI
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(GBGGLBKJJPC AEIJGHPBELE);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface PCGBGKBCAMP : NHOBIEOLNMI
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface MKDHCDAPLNK
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate void FHBFNEBPINN(PLGDEPDOHJO KAOOHJJODMA);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event FHBFNEBPINN GELPPIIBDOI;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface FLFJDMGBHJP
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface EBBFPPDKBKK
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface ONFGDKBJPCG
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(GBGGLBKJJPC PGBFIOFJIIP);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool HEDJILAIFJG);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GGGPCDPJJLK(GBGGLBKJJPC EGALIAAOIOO);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface COGJBDCNDED
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(IODHBDFJLPB POHIMCNOIOA);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface IODHBDFJLPB
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	GameObject AOALCMHDOFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Transform NMIBCHFJGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	EADBHHGHCOL HLBFAIALFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	bool MNLIIJNIENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AHCCAMFJHDJ(EADBHHGHCOL JCPBJCFMJCO);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EOOCHJMGNCA GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class ADNPANFFOEE
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F840", Offset = "0x7F8E440", VA = "0x187F8F840")]
	public static void BNBALIDPADP(this IODHBDFJLPB KBHNLJCJFLC, GJAKMMJKIGI CBLPKFIJGLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface EADBHHGHCOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Rigidbody FIMACPMLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	IODHBDFJLPB DDADIEEDCAL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	GameObject OPELENGGFMH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Transform FPIONCNEDML
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	EADBHHGHCOL AJPFGIFICJD
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	EADBHHGHCOL MMGGJKMBNAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	int KAHKOGIKFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	bool DGGJALNGJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	bool KAAEIICEOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	bool CNLFLMDCNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	LMAIOBGFFMJ DBNNHGCNHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	JKCAKHJBMFN PDHGEMIBIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	float FMNHKGBBGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	Vector3 KHFBCHDFOMD
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	Vector3 BFIGAHMHCGA
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	Vector3 ODPIFACDMLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	Vector3 LELBJFGMPFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	bool GKOFIHHONPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	bool IHGINKKDLBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	bool CIKKFEDDEPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	bool OCLDBLJLAGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Vector3 OICBDALMHKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	Vector3 KJFFFNKHNMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Vector3 AEFNNECIPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	Vector3 ICOHFDFCKPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	float ICALMNBIFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	float HPNIPIHDNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Vector3 MAABGALEAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	Quaternion APNHJPBPEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	float OJDACIDBFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	float JDMNGAIEPNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	bool MKKEOHFAMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	FDCMEMEDMHG BAIEILCIPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	bool HMCGEPBNCCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	Transform KPEKEICBDNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	Vector3 OMJNPDPKPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	float KBFPPGJADNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	float AFACDHALJJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	Quaternion AMOOKIJLHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	Vector3 GKIMFBHMEAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	Quaternion DINJLOEPCHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	RigidbodyConstraints OKGCBBPILDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	bool NFJJJKKIPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	CollisionDetectionMode CFOLMFCLIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	bool BLGIDELGDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event LNOEFCDNOHA GDJBBFNCKDJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event LNOEFCDNOHA MMLABBPOMIO;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event LNOEFCDNOHA CNAOKDDACNB;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event LNOEFCDNOHA KJEFEAPCMDI;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event LNOEFCDNOHA PCFMOPPLHIH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event LNOEFCDNOHA PDNDHCJJDHA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event LNOEFCDNOHA AMDDALDADAE;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event NKGOBEKODPF KFPKMMEILIC;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<OEENMKMDDDK, OEENMKMDDDK> FENHDBEDJNN;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "26")]
	EADBHHGHCOL DKBHGBNCHJL(int EMMACFPOKFB);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void BBNNMDLBGEI((Quaternion rot, Vector3 moments) LKNPLOMJHIG);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void DJGFNKKBNHD();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void CGFIMGKAOGJ();

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void GPJOGNDFODC();

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void KEJHPEIBPAE();

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void JOHFJLBKODA();

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void OAAMBAOIOOB(EADBHHGHCOL OOHGFGHCOAJ, bool KIEEDBDBNHO = false);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void AHMMNBBFFPD(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void BECDFCMJLME(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 AHAHEAFAIOM(Vector3 MKKLJCLAENJ);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 LBPADMLAJPO(Vector3 KHCAEECDNDM);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void EGLFPKADDFB();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void PAJKABDAGFJ();

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void KHCNKJLJKHG();

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void KFGOBBOADCN(Vector3 AABFLGNECOB, Vector3 FHPBADOOCKG);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void LBFNJIDNBOD(Vector3 PDOEEHIABID, Vector3 FAFGAPDLINP);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void MDJPOAOCGKP(Vector3 FBDGFEEKAPH);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void MCNBCNIBGFA(IBAPNPEDNNP GFBHFNJFEGM, Vector3 JIIHIAGFIGK, float HHKBILOIFPE, float ADBHMBMIDLI = 8f, float DKOCDAOHKFH = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void GDAPFOMNLMF(MPBEDBOENLK BKMICPMKELA, Vector3 BLLAOHANMCE, float HKDLPFFMCIB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void LIGIGFIECDM(MPBEDBOENLK BKMICPMKELA, Vector3 BFEELDCLMGM, float IOPBCCGPEBC = 7f, float NNKGFLBDMBK = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 INAHMCMAAEB(Vector3 OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 DFCLMIJOBFA(Vector3 OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void IHHGJKMLHPI();

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void AOPEPADOBLM(EADBHHGHCOL GOFCONACJJP, object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void GCPHLBALOGF(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void ODDOIBMGJEC();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void GLBFKBLGOAA();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void MNKHFAMJDOF();

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool DIBBMJGICDL();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void LFHJKHNNKDK();

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void OHGHFDPHKOH(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void LONBJOKABJH(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void CKAJJOGPHOE(object HEDGIMBCGHA, bool CBMPLHDBDAJ);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void GGFKBKNJDGE(Vector3 MMDDGEEAFDM, Quaternion PKHGEFEODIE);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void ACBPHDHLGCE(Vector3 NBPBOJNOCJM, Quaternion EGIHCMJEEGC);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool LKHCIBDJBIA(float NPEKDNBDINN);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void PHBLPACBAAK(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void MNJENCMHICP(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void GHMOAFKJOHK(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void CFBDGKKPEKB(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void FGJDCKNOFFI(Vector3 JMDCPKFBLOI, ForceMode KHLACBHAFGM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void ADEILJPAOFF(Vector3 JMDCPKFBLOI, Vector3 IIBJECFMAJC, ForceMode KHLACBHAFGM);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void CGOMMKCIOLJ(Vector3 LCCBDJMIEBH, ForceMode KHLACBHAFGM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void MGEFMEIPEAO(Vector3 LCCBDJMIEBH, ForceMode KHLACBHAFGM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool NJOBNDEIHPK(Vector3 HLIFPOIPBBB, [Out] RaycastHit AAJGGMIMFEH, float KNLGCBPGFKL);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void OOBJPHFMIEL();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface JKCAKHJBMFN
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class GCMCBHIJHBA : JKCAKHJBMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GCMCBHIJHBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "0")]
	void DPOKELEJDFO(Vector3 EADCNILDIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "1")]
	void FKEOEBIOMKE(Vector3 NOBIPBDPLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "2")]
	void ACBFKHAFHFP(Vector3 EADCNILDIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "3")]
	void DBBFDEIPCPK(Vector3 NOBIPBDPLMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface LMAIOBGFFMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 PACLJIPJLOI();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 FDDEGKCDOAD();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool COGOEEHJMIE(float APFNPNDPMLP, float PAJIBFEJOBE);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate void LNOEFCDNOHA(IODHBDFJLPB EMFFLEPIPEJ);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum NHLGNCFFPAD
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
public enum IBAPNPEDNNP
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
public delegate void NKGOBEKODPF(IODHBDFJLPB EMFFLEPIPEJ, bool KIEEDBDBNHO = false);
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum MPBEDBOENLK
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct EOOCHJMGNCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Rigidbody KOGOAMNMHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public object NFBECNGMMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 KDJGBALEEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Vector3 JFPJINJILLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public GKDEPMMONOP EOGPMCJGNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool AMHFCJANHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool DMJJJHCNMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool FFHJPKBOFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool ELBLFFMLNOP;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct GBGEFMIEGNI : IEquatable<GBGEFMIEGNI>
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly GBGEFMIEGNI KLPCNDNNFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public GameObject AOALCMHDOFP
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7F965C0", Offset = "0x7F951C0", VA = "0x187F965C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public PLLPLODJPBF OOMPMJLBBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7F96750", Offset = "0x7F95350", VA = "0x187F96750")]
		get
		{
			return default(PLLPLODJPBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public HDHIOCEBAND OGDCHLCOCEG
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7F962A0", Offset = "0x7F94EA0", VA = "0x187F962A0")]
		get
		{
			return default(HDHIOCEBAND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public RRObjectPrefabData BHBMONGPFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7F95F80", Offset = "0x7F94B80", VA = "0x187F95F80")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool LMGHFMNAIGB
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7F965A0", Offset = "0x7F951A0", VA = "0x187F965A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool FDBMLFKFCFF
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7F96880", Offset = "0x7F95480", VA = "0x187F96880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool BFCHJCHJJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7F95E50", Offset = "0x7F94A50", VA = "0x187F95E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool CKGHMPKOIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7F967F0", Offset = "0x7F953F0", VA = "0x187F967F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool KGFPMEFGBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7F95E30", Offset = "0x7F94A30", VA = "0x187F95E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool ECGBAEHNJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7F968A0", Offset = "0x7F954A0", VA = "0x187F968A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool CAEDPDKHIIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7F95DB0", Offset = "0x7F949B0", VA = "0x187F95DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool JCPJJAMAOBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7F95D70", Offset = "0x7F94970", VA = "0x187F95D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool HNHHMBBKMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7F95EC0", Offset = "0x7F94AC0", VA = "0x187F95EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool OLEFPFDHHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7F96420", Offset = "0x7F95020", VA = "0x187F96420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool BCPMBKALFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7F96350", Offset = "0x7F94F50", VA = "0x187F96350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool FEFKLKIFBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7F96840", Offset = "0x7F95440", VA = "0x187F96840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool EFCFKBCGGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7F95DF0", Offset = "0x7F949F0", VA = "0x187F95DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool HNLEANLKHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7F96260", Offset = "0x7F94E60", VA = "0x187F96260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool JPIIFHCPJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7F96390", Offset = "0x7F94F90", VA = "0x187F96390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public CDPLIHJIMIK PFJLEDBOJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(CDPLIHJIMIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public NBOENINNEJK AEJAPDACDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(NBOENINNEJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public HKEBGMJOKMA AIPBPECPPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(HKEBGMJOKMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public ELLEHCPJINE BLNOLHJJOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(ELLEHCPJINE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public FMCFACGFNCH LCHCHFMDLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(FMCFACGFNCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public LKLLGOOCBEB NDNNIOLNFCC
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(LKLLGOOCBEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public NJLOOAKOMJA HNOOKOLDLEG
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(NJLOOAKOMJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public PBDBGIGGOCB NNNAPHEEGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(PBDBGIGGOCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public MHJDGJPPAHO CNAIBNDNMFL
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(MHJDGJPPAHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public FDPKGAKDIEJ EBJPDBEABEH
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(FDPKGAKDIEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public LIJDGNNNPCB BEJKBEEGLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(LIJDGNNNPCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public KCBNBDPKAGF MKNCFFMJINH
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(KCBNBDPKAGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public GEBPJCNPJMI JODEHHKLAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GEBPJCNPJMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public KBFFHNNLOGN EKBOMNNCEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(KBFFHNNLOGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public bool GCFDIONPNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7F964B0", Offset = "0x7F950B0", VA = "0x187F964B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool IEJMLMLKINH
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7F96460", Offset = "0x7F95060", VA = "0x187F96460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool CMIBBAGCNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7F95AB0", Offset = "0x7F946B0", VA = "0x187F95AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool DOBEMPPDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x7F96340", Offset = "0x7F94F40", VA = "0x187F96340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool KLKIKEIFBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x7F96140", Offset = "0x7F94D40", VA = "0x187F96140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool ICMKJNKCNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7F95D30", Offset = "0x7F94930", VA = "0x187F95D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool KGJAMOLKHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7F96220", Offset = "0x7F94E20", VA = "0x187F96220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public PAJKCLCKHDE FPIONCNEDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(PAJKCLCKHDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public JFAOBFHPOAA BILKCCFOPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(JFAOBFHPOAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private BNNLGKNFBBF CKPEGOEMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7F968D0", Offset = "0x7F954D0", VA = "0x187F968D0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
	public static GBGEFMIEGNI GHOKLFELACP(GBGGLBKJJPC AEIJGHPBELE)
	{
		return default(GBGEFMIEGNI);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7F95F00", Offset = "0x7F94B00", VA = "0x187F95F00")]
	public CHCNCIHCOLF EHKGNJDDHML()
	{
		return default(CHCNCIHCOLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7F96810", Offset = "0x7F95410", VA = "0x187F96810")]
	public IPCJHLFPFEO LHPLMMMBMIN()
	{
		return default(IPCJHLFPFEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7F963D0", Offset = "0x7F94FD0", VA = "0x187F963D0")]
	public HMEEFLBBNMM HMPCNFHPGCL()
	{
		return default(HMEEFLBBNMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7F961F0", Offset = "0x7F94DF0", VA = "0x187F961F0")]
	public MEFHNPCOLPL GNJCGKCHKHB()
	{
		return default(MEFHNPCOLPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7F96180", Offset = "0x7F94D80", VA = "0x187F96180")]
	public NJLGOCOGNAH FNMCMCJJMIC()
	{
		return default(NJLGOCOGNAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7F95CE0", Offset = "0x7F948E0", VA = "0x187F95CE0")]
	public OCCIKADKNIM BJBDJMHJBEP()
	{
		return default(OCCIKADKNIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7F95E70", Offset = "0x7F94A70", VA = "0x187F95E70")]
	public FPGHGKFKKDN DFFJLFMPICK()
	{
		return default(FPGHGKFKKDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7F95BF0", Offset = "0x7F947F0", VA = "0x187F95BF0")]
	public MCPEFGGKMOK AHJGKHJAICO()
	{
		return default(MCPEFGGKMOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7F95AF0", Offset = "0x7F946F0", VA = "0x187F95AF0")]
	public void ADNEDBNPIKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7F95C40", Offset = "0x7F94840", VA = "0x187F95C40")]
	public void AMAAGOMLOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x7F95A10", Offset = "0x7F94610", VA = "0x187F95A10")]
	public bool ADANMKNDCBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7F96930", Offset = "0x7F95530", VA = "0x187F96930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public GBGEFMIEGNI(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7F90BA0", Offset = "0x7F8F7A0", VA = "0x187F90BA0")]
	public static bool GHOKLFELACP(GBGEFMIEGNI OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
	public static GBGGLBKJJPC GHOKLFELACP(GBGEFMIEGNI OOHGFGHCOAJ)
	{
		return default(GBGGLBKJJPC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7F964A0", Offset = "0x7F950A0", VA = "0x187F964A0")]
	public static bool JOHLOKGLNML(GBGEFMIEGNI ABBBJFPFEKP, GBGEFMIEGNI KLKIJPOLHDE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7F961D0", Offset = "0x7F94DD0", VA = "0x187F961D0")]
	public static bool FOFOJFKGMNN(GBGEFMIEGNI ABBBJFPFEKP, GBGEFMIEGNI KLKIJPOLHDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7F960B0", Offset = "0x7F94CB0", VA = "0x187F960B0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(GBGEFMIEGNI GMNGNCHKEBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct GEBPJCNPJMI : IEquatable<GEBPJCNPJMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private MHPMBGAOEOP EPMOPHKNEIF
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x7F976E0", Offset = "0x7F962E0", VA = "0x187F976E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7F978D0", Offset = "0x7F964D0", VA = "0x187F978D0")]
	public void GAJMNNCCBGC(uint ALPNKEJICNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7F97740", Offset = "0x7F96340", VA = "0x187F97740")]
	public bool EHOAHAGFMDP([Out] uint ALPNKEJICNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7F97A70", Offset = "0x7F96670", VA = "0x187F97A70")]
	public bool OEGNHPNMEKB([Out] uint ALPNKEJICNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7F975F0", Offset = "0x7F961F0", VA = "0x187F975F0")]
	public void CAFGOBECAJC(string ALPNKEJICNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7F97360", Offset = "0x7F95F60", VA = "0x187F97360")]
	[CanBeNull]
	public string AHAOKJGOBLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7F97470", Offset = "0x7F96070", VA = "0x187F97470")]
	public bool BMPGAFBGMNA([Out] string FIADECNLFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7F979D0", Offset = "0x7F965D0", VA = "0x187F979D0")]
	public void NGHELMAKBEF(string FIADECNLFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public GEBPJCNPJMI(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7F97840", Offset = "0x7F96440", VA = "0x187F97840", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(GEBPJCNPJMI GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct CDPLIHJIMIK : IEquatable<CDPLIHJIMIK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private AFLKGGANELK PPNOBLJHFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7F909A0", Offset = "0x7F8F5A0", VA = "0x187F909A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private MHPMBGAOEOP DONGBLLLLID
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7F901E0", Offset = "0x7F8EDE0", VA = "0x187F901E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public bool DCDOMCDBELL
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7F904E0", Offset = "0x7F8F0E0", VA = "0x187F904E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool MGHHPHFIELE
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7F901A0", Offset = "0x7F8EDA0", VA = "0x187F901A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool EHEPNGHCHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7F907C0", Offset = "0x7F8F3C0", VA = "0x187F907C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Guid OPGENDCMBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7F90740", Offset = "0x7F8F340", VA = "0x187F90740")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public Guid PJPLDNJNBEC
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7F90880", Offset = "0x7F8F480", VA = "0x187F90880")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Guid BMACJFELKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7F902D0", Offset = "0x7F8EED0", VA = "0x187F902D0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public JFAOBFHPOAA BILKCCFOPBP
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(JFAOBFHPOAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7F90900", Offset = "0x7F8F500", VA = "0x187F90900")]
	public bool MBCEAKEMDIL([Out] Guid LMBLGALMBCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7F90690", Offset = "0x7F8F290", VA = "0x187F90690")]
	public bool KDDJGFFKLCE([Out] Guid GKLJHCMGFAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7F90570", Offset = "0x7F8F170", VA = "0x187F90570")]
	public void IENJMLCAMJP(Guid AGKJLFOJIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7F900A0", Offset = "0x7F8ECA0", VA = "0x187F900A0")]
	public void CFOIJBMMFBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF80", Offset = "0x7F8EB80", VA = "0x187F8FF80")]
	public Guid AONACGGDKED()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public CDPLIHJIMIK(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x7F90240", Offset = "0x7F8EE40", VA = "0x187F90240", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(CDPLIHJIMIK GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct HMEEFLBBNMM : IEquatable<HMEEFLBBNMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private AHNOMBGEGCI JGDCIAPDNIN
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7F99AB0", Offset = "0x7F986B0", VA = "0x187F99AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Vector3 ILGLCEDGMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7F99CF0", Offset = "0x7F988F0", VA = "0x187F99CF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public Quaternion BIAPBNHBOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7F99ED0", Offset = "0x7F98AD0", VA = "0x187F99ED0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GBGEFMIEGNI NEILFLODELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7F99E40", Offset = "0x7F98A40", VA = "0x187F99E40")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x7F99C20", Offset = "0x7F98820", VA = "0x187F99C20")]
	public EDFFLPPIDFO KHLBEEJBIIC(Allocator CMJGNOOCEGA)
	{
		return default(EDFFLPPIDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7F99980", Offset = "0x7F98580", VA = "0x187F99980")]
	public bool CPBNOEIPPOC(GBGEFMIEGNI LIPFJJEAFCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7F99670", Offset = "0x7F98270", VA = "0x187F99670")]
	public void AJPFOHLIBAE(Vector3 IIBJECFMAJC, Quaternion BFEELDCLMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x7F99B10", Offset = "0x7F98710", VA = "0x187F99B10")]
	public void JDDEHHGPHMK(float LHHOCCKJGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7F997C0", Offset = "0x7F983C0", VA = "0x187F997C0")]
	public void CLLEIMGOCKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public HMEEFLBBNMM(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x7F90BA0", Offset = "0x7F8F7A0", VA = "0x187F90BA0")]
	public static bool GHOKLFELACP(HMEEFLBBNMM OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
	public static GBGGLBKJJPC GHOKLFELACP(HMEEFLBBNMM OOHGFGHCOAJ)
	{
		return default(GBGGLBKJJPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x7F99A20", Offset = "0x7F98620", VA = "0x187F99A20", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(HMEEFLBBNMM GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct CHCNCIHCOLF : IEquatable<CHCNCIHCOLF>
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly CHCNCIHCOLF KLPCNDNNFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private OGJOONKMAFC NLGAGGGLMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7F91060", Offset = "0x7F8FC60", VA = "0x187F91060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<GBGEFMIEGNI> JCKAMMHMPCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7F91140", Offset = "0x7F8FD40", VA = "0x187F91140")]
		get
		{
			return default(Span<GBGEFMIEGNI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public string AJPMCBKCCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7F910C0", Offset = "0x7F8FCC0", VA = "0x187F910C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7F90A90", Offset = "0x7F8F690", VA = "0x187F90A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public PAJKCLCKHDE FPIONCNEDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(PAJKCLCKHDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public JFAOBFHPOAA BILKCCFOPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(JFAOBFHPOAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x7F90BC0", Offset = "0x7F8F7C0", VA = "0x187F90BC0")]
	public void GIFBJPMAAGO(CHCNCIHCOLF GMNGNCHKEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public CHCNCIHCOLF(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7F90BA0", Offset = "0x7F8F7A0", VA = "0x187F90BA0")]
	public static bool GHOKLFELACP(CHCNCIHCOLF OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x7F90B10", Offset = "0x7F8F710", VA = "0x187F90B10", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(CHCNCIHCOLF GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
	public static GBGEFMIEGNI GHOKLFELACP(CHCNCIHCOLF LAAPKLDJLPE)
	{
		return default(GBGEFMIEGNI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DefaultMember("Item")]
public struct KKGIBOCPNMG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Dictionary<int, object> IGFGOFBOBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private INFEFFPBFJD CCGEMHNPMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool NICELLELNGE;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		[CompilerGenerated]
		readonly get
		{
			return default(GBGEFMIEGNI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public IBHIECCBNKI HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7F9C3D0", Offset = "0x7F9AFD0", VA = "0x187F9C3D0")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C540", Offset = "0x7F9B140", VA = "0x187F9C540")]
	internal KKGIBOCPNMG(GBGEFMIEGNI KDKJDFFGNJJ, bool NICELLELNGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C2A0", Offset = "0x7F9AEA0", VA = "0x187F9C2A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x3B69070", Offset = "0x3B67C70", VA = "0x183B69070")]
	public void DANHEBLHIFP<T>(IBHIECCBNKI MEPFFFGIFGB, T OOHGFGHCOAJ, [Optional] T IPOLOHBNCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C490", Offset = "0x7F9B090", VA = "0x187F9C490")]
	public void HMCNGGMNMHK(IBHIECCBNKI MEPFFFGIFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510")]
	public Dictionary<int, object> EAFCEAEKFGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C230", Offset = "0x7F9AE30", VA = "0x187F9C230")]
	private readonly void BEILEFJOLNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class KKJFOLJBJOF
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C610", Offset = "0x7F9B210", VA = "0x187F9C610")]
	public static KKGIBOCPNMG IICJEEGNAKN(this GBGEFMIEGNI KDKJDFFGNJJ)
	{
		return default(KKGIBOCPNMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct KBFFHNNLOGN : IEquatable<KBFFHNNLOGN>
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly KBFFHNNLOGN KLPCNDNNFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	private bool BCPMBKALFFF
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7F9B800", Offset = "0x7F9A400", VA = "0x187F9B800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public Vector3 DIEDNBGDFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7F9B5C0", Offset = "0x7F9A1C0", VA = "0x187F9B5C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7F9B970", Offset = "0x7F9A570", VA = "0x187F9B970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B840", Offset = "0x7F9A440", VA = "0x187F9B840")]
	public Vector3 KHNKGILOFFN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B670", Offset = "0x7F9A270", VA = "0x187F9B670")]
	public void DCBDDJLGLJA([In] Vector3 OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B780", Offset = "0x7F9A380", VA = "0x187F9B780")]
	public void FINEEFAMFGO([In] Vector3 OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B8C0", Offset = "0x7F9A4C0", VA = "0x187F9B8C0")]
	public bool LOJMOMGNBBM([In] Vector3 OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public KBFFHNNLOGN(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B6F0", Offset = "0x7F9A2F0", VA = "0x187F9B6F0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(KBFFHNNLOGN GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B9D0", Offset = "0x7F9A5D0", VA = "0x187F9B9D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct DODICMNMJPJ : IEquatable<DODICMNMJPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7F91E70", Offset = "0x7F90A70", VA = "0x187F91E70", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(DODICMNMJPJ GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct MCPEFGGKMOK : IEquatable<MCPEFGGKMOK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private LGPCKFACDNO EFGMJHJPPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7F9FFF0", Offset = "0x7F9EBF0", VA = "0x187F9FFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool AKLPGBPJMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0190", Offset = "0x7F9ED90", VA = "0x187FA0190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public KEHIJGGMCEB NACIGHFIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F9FDE0", Offset = "0x7F9E9E0", VA = "0x187F9FDE0")]
		get
		{
			return default(KEHIJGGMCEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool GOIFCEBFFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0050", Offset = "0x7F9EC50", VA = "0x187FA0050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool KGGNMHPFLEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7F9FFB0", Offset = "0x7F9EBB0", VA = "0x187F9FFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7FA02C0", Offset = "0x7F9EEC0", VA = "0x187FA02C0")]
	public void NLGDHBAFJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F9FCC0", Offset = "0x7F9E8C0", VA = "0x187F9FCC0")]
	public ReadOnlySpan<GBGGLBKJJPC> BAMNIIJKHHJ()
	{
		return default(ReadOnlySpan<GBGGLBKJJPC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public MCPEFGGKMOK(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F961D0", Offset = "0x7F94DD0", VA = "0x187F961D0")]
	public static bool FOFOJFKGMNN(MCPEFGGKMOK ABBBJFPFEKP, MCPEFGGKMOK KLKIJPOLHDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F9FF20", Offset = "0x7F9EB20", VA = "0x187F9FF20", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(MCPEFGGKMOK GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct FPGHGKFKKDN : IEquatable<FPGHGKFKKDN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private LGPCKFACDNO LFPMNMOACCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F95920", Offset = "0x7F94520", VA = "0x187F95920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public PAJKCLCKHDE FPIONCNEDML
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(PAJKCLCKHDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7F95880", Offset = "0x7F94480", VA = "0x187F95880")]
	public bool AIHKBFOADNG(FPGHGKFKKDN GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public FPGHGKFKKDN(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F95980", Offset = "0x7F94580", VA = "0x187F95980", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(FPGHGKFKKDN GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct JFAOBFHPOAA : IEquatable<JFAOBFHPOAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private OGJOONKMAFC NLGAGGGLMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F9AD20", Offset = "0x7F99920", VA = "0x187F9AD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public GBGGLBKJJPC NOGFOLGCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7F9B270", Offset = "0x7F99E70", VA = "0x187F9B270")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public GBGEFMIEGNI AJPFGIFICJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F9AEB0", Offset = "0x7F99AB0", VA = "0x187F9AEB0")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public GBGEFMIEGNI MMGGJKMBNAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F9AC90", Offset = "0x7F99890", VA = "0x187F9AC90")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A8F0", Offset = "0x7F994F0", VA = "0x187F9A8F0")]
	public Span<GBGEFMIEGNI> ALEMEAAPPOL()
	{
		return default(Span<GBGEFMIEGNI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x7F9AB00", Offset = "0x7F99700", VA = "0x187F9AB00")]
	public Span<GBGEFMIEGNI> DMHBGICAOME()
	{
		return default(Span<GBGEFMIEGNI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B170", Offset = "0x7F99D70", VA = "0x187F9B170")]
	public Span<GBGEFMIEGNI> OFOCKDEGAGM()
	{
		return default(Span<GBGEFMIEGNI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B070", Offset = "0x7F99C70", VA = "0x187F9B070")]
	public Span<GBGEFMIEGNI> OEFAEBMBPKH()
	{
		return default(Span<GBGEFMIEGNI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7F9AF40", Offset = "0x7F99B40", VA = "0x187F9AF40")]
	public bool OAAMBAOIOOB(GBGEFMIEGNI LIPFJJEAFCE, bool PGCCOHFPPFF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7F9AE10", Offset = "0x7F99A10", VA = "0x187F9AE10")]
	public bool MKBAFCHGJDC(GBGEFMIEGNI BMMHMAPMBII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A9F0", Offset = "0x7F995F0", VA = "0x187F9A9F0")]
	public GBGEFMIEGNI BKPPABCCNHM(uint EPBNDINKOJC)
	{
		return default(GBGEFMIEGNI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7F9AD80", Offset = "0x7F99980", VA = "0x187F9AD80")]
	public CHCNCIHCOLF KPICGDDGAHL()
	{
		return default(CHCNCIHCOLF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public JFAOBFHPOAA(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7F90BA0", Offset = "0x7F8F7A0", VA = "0x187F90BA0")]
	public static bool GHOKLFELACP(JFAOBFHPOAA OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7F9AC00", Offset = "0x7F99800", VA = "0x187F9AC00", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(JFAOBFHPOAA GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct NBOENINNEJK : IEquatable<NBOENINNEJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public string DLMLBBCIDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1950", Offset = "0x7FA0550", VA = "0x187FA1950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public string HFPBKHBAMNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1850", Offset = "0x7FA0450", VA = "0x187FA1850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public string HCDEJMBHLLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA19E0", Offset = "0x7FA05E0", VA = "0x187FA19E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public string BGPFNJENGLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1A90", Offset = "0x7FA0690", VA = "0x187FA1A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1790", Offset = "0x7FA0390", VA = "0x187FA1790")]
	public bool BMPGAFBGMNA([Out] string FIADECNLFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public NBOENINNEJK(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7FA18C0", Offset = "0x7FA04C0", VA = "0x187FA18C0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(NBOENINNEJK GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct NJLGOCOGNAH : IEquatable<NJLGOCOGNAH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private DJNEJMCNLGN CPDDIEFPFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2B50", Offset = "0x7FA1750", VA = "0x187FA2B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public KEEGFEGMDGI JEDJFPNBNCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2930", Offset = "0x7FA1530", VA = "0x187FA2930")]
		get
		{
			return default(KEEGFEGMDGI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2820", Offset = "0x7FA1420", VA = "0x187FA2820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public bool PLOOFBFDLNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7FA25E0", Offset = "0x7FA11E0", VA = "0x187FA25E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7FA30D0", Offset = "0x7FA1CD0", VA = "0x187FA30D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public HBFEOHNMHAE<string> MGNFJMOIGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2BB0", Offset = "0x7FA17B0", VA = "0x187FA2BB0")]
		get
		{
			return default(HBFEOHNMHAE<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2D70", Offset = "0x7FA1970", VA = "0x187FA2D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public HBFEOHNMHAE<string> PJOAKMACNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2FB0", Offset = "0x7FA1BB0", VA = "0x187FA2FB0")]
		get
		{
			return default(HBFEOHNMHAE<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2A30", Offset = "0x7FA1630", VA = "0x187FA2A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public HBFEOHNMHAE<string> GHBOKFEHCMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2700", Offset = "0x7FA1300", VA = "0x187FA2700")]
		get
		{
			return default(HBFEOHNMHAE<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2E90", Offset = "0x7FA1A90", VA = "0x187FA2E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public HBFEOHNMHAE<string> NDFDPEGBEHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3170", Offset = "0x7FA1D70", VA = "0x187FA3170")]
		get
		{
			return default(HBFEOHNMHAE<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3290", Offset = "0x7FA1E90", VA = "0x187FA3290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7FA2CD0", Offset = "0x7FA18D0", VA = "0x187FA2CD0")]
	public bool LMFNOHJIMFP(GBGGLBKJJPC NEOGODNGJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public NJLGOCOGNAH(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
	public static GBGGLBKJJPC GHOKLFELACP(NJLGOCOGNAH OOHGFGHCOAJ)
	{
		return default(GBGGLBKJJPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7FA2670", Offset = "0x7FA1270", VA = "0x187FA2670", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(NJLGOCOGNAH GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct MOEGNMJMGEA : IEquatable<MOEGNMJMGEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1660", Offset = "0x7FA0260", VA = "0x187FA1660", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(MOEGNMJMGEA GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct LDCMFHDDIIE : IEquatable<LDCMFHDDIIE>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[Flags]
	public enum LINOCFIFMAN
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		SUCCESS = 0,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		ANCHOR_A_INVALID = 1,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		ANCHOR_B_INVALID = 2,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		ANCHOR_A_CANNOT_CONNECT = 4,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		ANCHOR_B_CANNOT_CONNECT = 8
	}

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly LDCMFHDDIIE KLPCNDNNFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private BNNLGKNFBBF CKPEGOEMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x7F968D0", Offset = "0x7F954D0", VA = "0x187F968D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D450", Offset = "0x7F9C050", VA = "0x187F9D450")]
	public static LINOCFIFMAN EAFFFBIIKCF(LDCMFHDDIIE ABBBJFPFEKP, LDCMFHDDIIE KLKIJPOLHDE)
	{
		return default(LINOCFIFMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D700", Offset = "0x7F9C300", VA = "0x187F9D700")]
	public bool NKMIJLOCHPH([Out] GameObject LIPFJJEAFCE, [Out] GameObject AOALCMHDOFP, [Out] GBGEFMIEGNI LGKJIFFPIKD, [Out] GBGEFMIEGNI BEEDFJLOHBF, [Out] Vector3 IIBJECFMAJC, [Out] Vector3 DJBHGDJIPOK, [Out] Vector3 FCFFHIKPKAE, [Out] GBGEFMIEGNI NMLMIKEIOJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D240", Offset = "0x7F9BE40", VA = "0x187F9D240")]
	public bool CKOKPLOFDFM([Out] GameObject LIPFJJEAFCE, [Out] GameObject AOALCMHDOFP, [Out] GBGEFMIEGNI LGKJIFFPIKD, [Out] GBGEFMIEGNI BEEDFJLOHBF, [Out] Vector3 IIBJECFMAJC, [Out] Vector3 DJBHGDJIPOK, [Out] Vector3 FCFFHIKPKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7F9CED0", Offset = "0x7F9BAD0", VA = "0x187F9CED0")]
	private void ALELHCKDINN(Entity JMNEAPNCNHN, EntityManager JHOBPOCDEGC, MagneticAnchorData ELHGCCEDDHE, [Out] GameObject LIPFJJEAFCE, [Out] GameObject AOALCMHDOFP, [Out] GBGEFMIEGNI LGKJIFFPIKD, [Out] GBGEFMIEGNI BEEDFJLOHBF, [Out] Vector3 IIBJECFMAJC, [Out] Vector3 DJBHGDJIPOK, [Out] Vector3 FCFFHIKPKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public LDCMFHDDIIE(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D670", Offset = "0x7F9C270", VA = "0x187F9D670", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(LDCMFHDDIIE GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DC30", Offset = "0x7F9C830", VA = "0x187F9DC30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct CCAICJCPCCA : IEquatable<CCAICJCPCCA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FE90", Offset = "0x7F8EA90", VA = "0x187F8FE90", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(CCAICJCPCCA GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct HKEBGMJOKMA : IEquatable<HKEBGMJOKMA>
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly ComponentTypes AEDDGACDHHH;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static readonly HKEBGMJOKMA KLPCNDNNFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public Collider NJOHANOBFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7F99290", Offset = "0x7F97E90", VA = "0x187F99290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public HGLJMJMDMPG CJDMNBEHHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7F98920", Offset = "0x7F97520", VA = "0x187F98920")]
		get
		{
			return default(HGLJMJMDMPG);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7F988D0", Offset = "0x7F974D0", VA = "0x187F988D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public CDIPECLIEEJ HDAEPHMPMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7F98710", Offset = "0x7F97310", VA = "0x187F98710")]
		get
		{
			return default(CDIPECLIEEJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7F98D10", Offset = "0x7F97910", VA = "0x187F98D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public DIMFMGDBPGE BJDLMFFNKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7F98560", Offset = "0x7F97160", VA = "0x187F98560")]
		get
		{
			return default(DIMFMGDBPGE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7F98750", Offset = "0x7F97350", VA = "0x187F98750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public float DPOCGOGEGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x7F98AC0", Offset = "0x7F976C0", VA = "0x187F98AC0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x7F98640", Offset = "0x7F97240", VA = "0x187F98640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool IHGHFJIAMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x7F993E0", Offset = "0x7F97FE0", VA = "0x187F993E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x7F98B00", Offset = "0x7F97700", VA = "0x187F98B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public bool CKJMICDNNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x7F98690", Offset = "0x7F97290", VA = "0x187F98690")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x7F98830", Offset = "0x7F97430", VA = "0x187F98830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool DJOGPHBBLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x7F98A40", Offset = "0x7F97640", VA = "0x187F98A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x7F99090", Offset = "0x7F97C90", VA = "0x187F99090")]
	public static bool PABLDNJEEMB(GBGEFMIEGNI NFOBKJCDANP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x7F98D60", Offset = "0x7F97960", VA = "0x187F98D60")]
	public static bool OMPOHNEBOIH(GBGEFMIEGNI NFOBKJCDANP, [Out] HKEBGMJOKMA MMEAIBEMAMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x7F98BA0", Offset = "0x7F977A0", VA = "0x187F98BA0")]
	public bool NEEOPFJNOIF([Out] ONFGDKBJPCG HNEMFCNMJHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x7F98FA0", Offset = "0x7F97BA0", VA = "0x187F98FA0")]
	public bool ONDKAFEHNOC([Out] GBGGLBKJJPC HMGDINOCJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7F98960", Offset = "0x7F97560", VA = "0x187F98960")]
	public bool IDGGNIMFELC(PPFJOHBKEDL FCCNKGNGPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7F989C0", Offset = "0x7F975C0", VA = "0x187F989C0")]
	public void INCBPBBDNKN(PPFJOHBKEDL FCCNKGNGPGC, bool AENFHNMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7F985A0", Offset = "0x7F971A0", VA = "0x187F985A0")]
	public void CALOOALJFCL(PPFJOHBKEDL FCCNKGNGPGC, bool AENFHNMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public HKEBGMJOKMA(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7F987A0", Offset = "0x7F973A0", VA = "0x187F987A0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(HKEBGMJOKMA GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7F99450", Offset = "0x7F98050", VA = "0x187F99450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct MEFHNPCOLPL : IEquatable<MEFHNPCOLPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public bool JNCLBDHGNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7FA03E0", Offset = "0x7F9EFE0", VA = "0x187FA03E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public MEFHNPCOLPL(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0350", Offset = "0x7F9EF50", VA = "0x187FA0350", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(MEFHNPCOLPL GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct ELLEHCPJINE : IEquatable<ELLEHCPJINE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private NLAGGDIGIND HABLEHDHEHE
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x7F938A0", Offset = "0x7F924A0", VA = "0x187F938A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7F93720", Offset = "0x7F92320", VA = "0x187F93720")]
	public void DHLNOFHJNJG(bool LPGGHPEPEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public ELLEHCPJINE(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7F93810", Offset = "0x7F92410", VA = "0x187F93810", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(ELLEHCPJINE GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct FMCFACGFNCH : IEquatable<FMCFACGFNCH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool JJEJACCLDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7F95400", Offset = "0x7F94000", VA = "0x187F95400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool HJGGJLBFIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x7F94E10", Offset = "0x7F93A10", VA = "0x187F94E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool EIPKAOJGDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x7F954B0", Offset = "0x7F940B0", VA = "0x187F954B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x7F95490", Offset = "0x7F94090", VA = "0x187F95490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool FPALHBOOLAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x7F955C0", Offset = "0x7F941C0", VA = "0x187F955C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool GOHAMOCJNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7F95660", Offset = "0x7F94260", VA = "0x187F95660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool MMMOBIEBFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7F956B0", Offset = "0x7F942B0", VA = "0x187F956B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public bool OHJNDNMEJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7F94D70", Offset = "0x7F93970", VA = "0x187F94D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public bool AOEDICPMMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x7F95830", Offset = "0x7F94430", VA = "0x187F95830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool FDDJALKFKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x7F94E60", Offset = "0x7F93A60", VA = "0x187F94E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool EDCMIIDCIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x7F952E0", Offset = "0x7F93EE0", VA = "0x187F952E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool IMPALJEEJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x7F95290", Offset = "0x7F93E90", VA = "0x187F95290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public bool NFKCKMKCPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x7F95610", Offset = "0x7F94210", VA = "0x187F95610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool KHAABKOLMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x7F957E0", Offset = "0x7F943E0", VA = "0x187F957E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public bool AMCOKLPEMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x7F95060", Offset = "0x7F93C60", VA = "0x187F95060")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x7F95700", Offset = "0x7F94300", VA = "0x187F95700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public EOELGIAPNLB EPLGIGDALGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7F94D30", Offset = "0x7F93930", VA = "0x187F94D30")]
		get
		{
			return default(EOELGIAPNLB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x7F94EF0", Offset = "0x7F93AF0", VA = "0x187F94EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool HPPDECJCLDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x7F94F40", Offset = "0x7F93B40", VA = "0x187F94F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public JJAKBBFCFFN MGFKBGEEKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x7F94EB0", Offset = "0x7F93AB0", VA = "0x187F94EB0")]
		get
		{
			return default(JJAKBBFCFFN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x7F95440", Offset = "0x7F94040", VA = "0x187F95440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool MPIMDAOMIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x7F95330", Offset = "0x7F93F30", VA = "0x187F95330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 HHNPEFIHLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x7F95760", Offset = "0x7F94360", VA = "0x187F95760")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 LDAKOPCDFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x7F95540", Offset = "0x7F94140", VA = "0x187F95540")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public bool GIIOOPNFENG
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x7F95100", Offset = "0x7F93D00", VA = "0x187F95100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7F950A0", Offset = "0x7F93CA0", VA = "0x187F950A0")]
	public bool ECAMLJHOHPC(LONOPCKPNAE FCCNKGNGPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x7F95370", Offset = "0x7F93F70", VA = "0x187F95370")]
	public void HMJPMFLCCFI(LONOPCKPNAE FCCNKGNGPGC, bool AENFHNMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7F94C60", Offset = "0x7F93860", VA = "0x187F94C60")]
	public bool AMJLBOEPEHP(EPNMKAKCGCP FCCNKGNGPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7F94CB0", Offset = "0x7F938B0", VA = "0x187F94CB0")]
	public void ANNNHOKNMHI(EPNMKAKCGCP FCCNKGNGPGC, bool AENFHNMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7F95500", Offset = "0x7F94100", VA = "0x187F95500")]
	public EPNMKAKCGCP JKOPOCMDBHF()
	{
		return default(EPNMKAKCGCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7F94DC0", Offset = "0x7F939C0", VA = "0x187F94DC0")]
	public bool BNMNDKNKBOF(EPNMKAKCGCP OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public FMCFACGFNCH(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7F95200", Offset = "0x7F93E00", VA = "0x187F95200", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(FMCFACGFNCH GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct LKLLGOOCBEB : IEquatable<LKLLGOOCBEB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private FLCHLFOMKAN PJINHEPDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x7F9F860", Offset = "0x7F9E460", VA = "0x187F9F860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F0C0", Offset = "0x7F9DCC0", VA = "0x187F9F0C0")]
	public bool ELKLHMPGMOG(FBBLGIGMICK OCHMMOHMIHP, List<GBGEFMIEGNI> HECIKPJEDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EFB0", Offset = "0x7F9DBB0", VA = "0x187F9EFB0")]
	public int BDCICFJNKOK(FBBLGIGMICK OCHMMOHMIHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F6A0", Offset = "0x7F9E2A0", VA = "0x187F9F6A0")]
	public void MAIAOPBKOJJ(List<GBGEFMIEGNI> HECIKPJEDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F8C0", Offset = "0x7F9E4C0", VA = "0x187F9F8C0")]
	public int OJMMCCEOOLO(GBGEFMIEGNI MDKAAPLMLKG, FBBLGIGMICK OCHMMOHMIHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F3B0", Offset = "0x7F9DFB0", VA = "0x187F9F3B0")]
	public GBGEFMIEGNI JKIINCMFJGL(int EMMACFPOKFB, FBBLGIGMICK OCHMMOHMIHP)
	{
		return default(GBGEFMIEGNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F280", Offset = "0x7F9DE80", VA = "0x187F9F280")]
	public void GNGMJOFJHGM(GBGEFMIEGNI MDKAAPLMLKG, FBBLGIGMICK OCHMMOHMIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F5F0", Offset = "0x7F9E1F0", VA = "0x187F9F5F0")]
	public bool LJCGPKLDBFB(GBGEFMIEGNI MDKAAPLMLKG, FBBLGIGMICK OCHMMOHMIHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F4E0", Offset = "0x7F9E0E0", VA = "0x187F9F4E0")]
	public void KACBCFCABGJ(FBBLGIGMICK OCHMMOHMIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F7B0", Offset = "0x7F9E3B0", VA = "0x187F9F7B0")]
	public bool MODCMOADGIB(GBGEFMIEGNI MDKAAPLMLKG, FBBLGIGMICK OCHMMOHMIHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EEA0", Offset = "0x7F9DAA0", VA = "0x187F9EEA0")]
	public bool AMKHHFLJLDO(FBBLGIGMICK OCHMMOHMIHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public LKLLGOOCBEB(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F1F0", Offset = "0x7F9DDF0", VA = "0x187F9F1F0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(LKLLGOOCBEB GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct NJLOOAKOMJA : IEquatable<NJLOOAKOMJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA34D0", Offset = "0x7FA20D0", VA = "0x187FA34D0")]
	public void PPIHKAIBHPM(bool OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA33B0", Offset = "0x7FA1FB0", VA = "0x187FA33B0")]
	public void AIJGKKHPJDH(bool OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x3C40D80", Offset = "0x3C3F980", VA = "0x183C40D80")]
	public T PFEHHOGJOLD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public NJLOOAKOMJA(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3440", Offset = "0x7FA2040", VA = "0x187FA3440", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(NJLOOAKOMJA GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct PBDBGIGGOCB : IEquatable<PBDBGIGGOCB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool FPJHBMNCIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6F90", Offset = "0x7FA5B90", VA = "0x187FA6F90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6E80", Offset = "0x7FA5A80", VA = "0x187FA6E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public bool BGJHOFONJEE
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6F10", Offset = "0x7FA5B10", VA = "0x187FA6F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public int KDBOLHJGBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6ED0", Offset = "0x7FA5AD0", VA = "0x187FA6ED0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6DF0", Offset = "0x7FA59F0", VA = "0x187FA6DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public PBDBGIGGOCB(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6D60", Offset = "0x7FA5960", VA = "0x187FA6D60", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(PBDBGIGGOCB GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct MHJDGJPPAHO : IEquatable<MHJDGJPPAHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public int NPINPMACFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1470", Offset = "0x7FA0070", VA = "0x187FA1470")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1540", Offset = "0x7FA0140", VA = "0x187FA1540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public int OAJALAAGPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1500", Offset = "0x7FA0100", VA = "0x187FA1500")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1350", Offset = "0x7F9FF50", VA = "0x187FA1350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public uint PECGBKKJDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7FA13A0", Offset = "0x7F9FFA0", VA = "0x187FA13A0")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA14B0", Offset = "0x7FA00B0", VA = "0x187FA14B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public MHJDGJPPAHO(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA13E0", Offset = "0x7F9FFE0", VA = "0x187FA13E0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(MHJDGJPPAHO GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct FDPKGAKDIEJ : IEquatable<FDPKGAKDIEJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private FCCHHHFAFPC ACAFOALLEEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F949D0", Offset = "0x7F935D0", VA = "0x187F949D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	private PPJGJJLCEOG CNGHPICEGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F94AC0", Offset = "0x7F936C0", VA = "0x187F94AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool KPAGJIHBLGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F94380", Offset = "0x7F92F80", VA = "0x187F94380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public bool JJMIHBOJKHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F94580", Offset = "0x7F93180", VA = "0x187F94580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public bool EJMLJDGLBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7F94110", Offset = "0x7F92D10", VA = "0x187F94110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool BAPOBGHFMHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7F94B90", Offset = "0x7F93790", VA = "0x187F94B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public bool FOKJNLPDCGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x7F94620", Offset = "0x7F93220", VA = "0x187F94620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public bool GIOGNPCFPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7F94A30", Offset = "0x7F93630", VA = "0x187F94A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public bool DICGDDGMNEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7F94650", Offset = "0x7F93250", VA = "0x187F94650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool JCDOOHEJGLE
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x7F94410", Offset = "0x7F93010", VA = "0x187F94410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public bool BBPDKMEPOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7F94140", Offset = "0x7F92D40", VA = "0x187F94140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F94B20", Offset = "0x7F93720", VA = "0x187F94B20")]
	public bool NHDMONFFGPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F94930", Offset = "0x7F93530", VA = "0x187F94930")]
	public GBGEFMIEGNI HKMMEMBMFEG(GBGEFMIEGNI MDKAAPLMLKG)
	{
		return default(GBGEFMIEGNI);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F94270", Offset = "0x7F92E70", VA = "0x187F94270")]
	public GBGGLBKJJPC BBIGDBGJEIJ()
	{
		return default(GBGGLBKJJPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7F94880", Offset = "0x7F93480", VA = "0x187F94880")]
	public bool HKJDEEIKLHK(GBGGLBKJJPC MDKAAPLMLKG, [Out] GBGGLBKJJPC AIGAIBGOMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public FDPKGAKDIEJ(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x7F90BA0", Offset = "0x7F8F7A0", VA = "0x187F90BA0")]
	public static bool GHOKLFELACP(FDPKGAKDIEJ OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x7F947F0", Offset = "0x7F933F0", VA = "0x187F947F0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(FDPKGAKDIEJ GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct IPCJHLFPFEO : IEquatable<IPCJHLFPFEO>
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static readonly IPCJHLFPFEO KLPCNDNNFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public FFOMNPBCHOB PJOADDMNFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A630", Offset = "0x7F99230", VA = "0x187F9A630")]
		get
		{
			return default(FFOMNPBCHOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public LGJLDBFLECO NLKOKMDALIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A280", Offset = "0x7F98E80", VA = "0x187F9A280")]
		get
		{
			return default(LGJLDBFLECO);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A480", Offset = "0x7F99080", VA = "0x187F9A480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public PNJAKOMAJFI NCKFIMBLHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A790", Offset = "0x7F99390", VA = "0x187F9A790")]
		get
		{
			return default(PNJAKOMAJFI);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A390", Offset = "0x7F98F90", VA = "0x187F9A390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public float OGPPHOMLAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A440", Offset = "0x7F99040", VA = "0x187F9A440")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A7D0", Offset = "0x7F993D0", VA = "0x187F9A7D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public Vector3 LFFFNMLHNHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A560", Offset = "0x7F99160", VA = "0x187F9A560")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A2C0", Offset = "0x7F98EC0", VA = "0x187F9A2C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public float PCPJHABEDLC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A340", Offset = "0x7F98F40", VA = "0x187F9A340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public DAMCLPLILIH CIBCHAPBFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A8B0", Offset = "0x7F994B0", VA = "0x187F9A8B0")]
		get
		{
			return default(DAMCLPLILIH);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A860", Offset = "0x7F99460", VA = "0x187F9A860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public bool ENNGJDDIGPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A820", Offset = "0x7F99420", VA = "0x187F9A820")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A3E0", Offset = "0x7F98FE0", VA = "0x187F9A3E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public PAJKCLCKHDE FPIONCNEDML
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(PAJKCLCKHDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public JFAOBFHPOAA BILKCCFOPBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(JFAOBFHPOAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A5E0", Offset = "0x7F991E0", VA = "0x187F9A5E0")]
	public NIBPHBJCJKD IMIIDCMKGED()
	{
		return default(NIBPHBJCJKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A670", Offset = "0x7F99270", VA = "0x187F9A670")]
	public MGHMHMMMJHA LMFAEHIHKJE()
	{
		return default(MGHMHMMMJHA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A740", Offset = "0x7F99340", VA = "0x187F9A740")]
	private bool NAHEKNHCKLI(DAMCLPLILIH FCCNKGNGPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A6C0", Offset = "0x7F992C0", VA = "0x187F9A6C0")]
	public void LNBMOCCKBMM(DAMCLPLILIH FCCNKGNGPGC, bool AENFHNMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public IPCJHLFPFEO(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7F90BA0", Offset = "0x7F8F7A0", VA = "0x187F90BA0")]
	public static bool GHOKLFELACP(IPCJHLFPFEO OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x7F961D0", Offset = "0x7F94DD0", VA = "0x187F961D0")]
	public static bool FOFOJFKGMNN(IPCJHLFPFEO ABBBJFPFEKP, IPCJHLFPFEO KLKIJPOLHDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A4D0", Offset = "0x7F990D0", VA = "0x187F9A4D0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(IPCJHLFPFEO GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct NIBPHBJCJKD : IEquatable<NIBPHBJCJKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public IPCJHLFPFEO HELMILIDHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(IPCJHLFPFEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public DDKHKNGGFFK IBEBECLIJBK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA23F0", Offset = "0x7FA0FF0", VA = "0x187FA23F0")]
		get
		{
			return default(DDKHKNGGFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public NIBPHBJCJKD(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x7F90BA0", Offset = "0x7F8F7A0", VA = "0x187F90BA0")]
	public static bool GHOKLFELACP(NIBPHBJCJKD OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x7FA2360", Offset = "0x7FA0F60", VA = "0x187FA2360", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(NIBPHBJCJKD GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DefaultMember("Item")]
public readonly struct MGHMHMMMJHA : IEquatable<MGHMHMMMJHA>
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly MGHMHMMMJHA KLPCNDNNFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	private MAKBBLKFAAF COABBPBMKME
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0730", Offset = "0x7F9F330", VA = "0x187FA0730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public IPCJHLFPFEO HELMILIDHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(IPCJHLFPFEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public BMIAJFBBPCI HBMDBCAGOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1040", Offset = "0x7F9FC40", VA = "0x187FA1040")]
		get
		{
			return default(BMIAJFBBPCI);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0BC0", Offset = "0x7F9F7C0", VA = "0x187FA0BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public IEnumerable<KJCPBHFFDCI> HEKFKCLMLGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0820", Offset = "0x7F9F420", VA = "0x187FA0820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public KJCPBHFFDCI HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0A20", Offset = "0x7F9F620", VA = "0x187FA0A20")]
		get
		{
			return default(KJCPBHFFDCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0CE0", Offset = "0x7F9F8E0", VA = "0x187FA0CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public PAJKCLCKHDE FPIONCNEDML
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(PAJKCLCKHDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0510", Offset = "0x7F9F110", VA = "0x187FA0510")]
	public KJCPBHFFDCI EJMCHEMJKKP(float3? IIBJECFMAJC, [Optional] quaternion? BFEELDCLMGM, [Optional] Vector3? LHHOCCKJGIB)
	{
		return default(KJCPBHFFDCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0D70", Offset = "0x7F9F970", VA = "0x187FA0D70")]
	public KJCPBHFFDCI MNKKDLLNIJE(int EMMACFPOKFB, float3? IIBJECFMAJC, [Optional] quaternion? BFEELDCLMGM, [Optional] Vector3? LHHOCCKJGIB)
	{
		return default(KJCPBHFFDCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0FA0", Offset = "0x7F9FBA0", VA = "0x187FA0FA0")]
	public void OKBAODAHDOH(int EMMACFPOKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0B30", Offset = "0x7F9F730", VA = "0x187FA0B30")]
	public void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public MGHMHMMMJHA(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7F90BA0", Offset = "0x7F8F7A0", VA = "0x187F90BA0")]
	public static bool GHOKLFELACP(MGHMHMMMJHA OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x7F964A0", Offset = "0x7F950A0", VA = "0x187F964A0")]
	public static bool JOHLOKGLNML(MGHMHMMMJHA ABBBJFPFEKP, MGHMHMMMJHA KLKIJPOLHDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0790", Offset = "0x7F9F390", VA = "0x187FA0790", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(MGHMHMMMJHA GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public readonly struct KJCPBHFFDCI : IEquatable<KJCPBHFFDCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public MGHMHMMMJHA JDNHFAIPNIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7F9BE70", Offset = "0x7F9AA70", VA = "0x187F9BE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public float3 GKIMFBHMEAF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7F9C140", Offset = "0x7F9AD40", VA = "0x187F9C140")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x7F9BF80", Offset = "0x7F9AB80", VA = "0x187F9BF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public quaternion DINJLOEPCHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7F9BFE0", Offset = "0x7F9ABE0", VA = "0x187F9BFE0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7F9C090", Offset = "0x7F9AC90", VA = "0x187F9C090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public float3 CAFENJPBDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7F9C030", Offset = "0x7F9AC30", VA = "0x187F9C030")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7F9C0E0", Offset = "0x7F9ACE0", VA = "0x187F9C0E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public BBNAELAIBIF BEKMDJENBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x7F9C1A0", Offset = "0x7F9ADA0", VA = "0x187F9C1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BE60", Offset = "0x7F9AA60", VA = "0x187F9BE60")]
	public void AIFEFMMGMIP(MGHMHMMMJHA OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public KJCPBHFFDCI(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BEF0", Offset = "0x7F9AAF0", VA = "0x187F9BEF0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(KJCPBHFFDCI GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public readonly struct OCCIKADKNIM : IEquatable<OCCIKADKNIM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public bool PDMHOGNFOBD
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3B60", Offset = "0x7FA2760", VA = "0x187FA3B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public OCCIKADKNIM(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3AD0", Offset = "0x7FA26D0", VA = "0x187FA3AD0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(OCCIKADKNIM GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct LIJDGNNNPCB : IEquatable<LIJDGNNNPCB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	private CKDKJFBJHAH FGNFJKGMIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E2C0", Offset = "0x7F9CEC0", VA = "0x187F9E2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public bool KLPMDFNKGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E520", Offset = "0x7F9D120", VA = "0x187F9E520")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x7F9EBA0", Offset = "0x7F9D7A0", VA = "0x187F9EBA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public bool JJJPGPDMNOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E570", Offset = "0x7F9D170", VA = "0x187F9E570")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E5C0", Offset = "0x7F9D1C0", VA = "0x187F9E5C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public float FJONLFNADPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E6B0", Offset = "0x7F9D2B0", VA = "0x187F9E6B0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E320", Offset = "0x7F9CF20", VA = "0x187F9E320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public bool PCFGLCIPKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E9D0", Offset = "0x7F9D5D0", VA = "0x187F9E9D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E930", Offset = "0x7F9D530", VA = "0x187F9E930")]
	public void HANBDLHNIGO(int IJNCJOKBAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E820", Offset = "0x7F9D420", VA = "0x187F9E820")]
	public bool GGHLCIPPIIJ([Out] int IJNCJOKBAFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E370", Offset = "0x7F9CF70", VA = "0x187F9E370")]
	public void EIDJKMGEJKJ(bool HCECJAHDMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EA20", Offset = "0x7F9D620", VA = "0x187F9EA20")]
	public bool JLNOIOBMOEC(DODJEDKBCKA FCCNKGNGPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E410", Offset = "0x7F9D010", VA = "0x187F9E410")]
	public void EPLBPGHPGNF(DODJEDKBCKA FCCNKGNGPGC, bool AENFHNMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EC00", Offset = "0x7F9D800", VA = "0x187F9EC00")]
	public void OIBAOCBHKNG(float PALKODGLGEA, float GKDIFLDALMK, float GCMCFADHMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9ED50", Offset = "0x7F9D950", VA = "0x187F9ED50")]
	public void ONLABJMPEHG(float3 NIAFNFNJCAI, quaternion AJJDMOGKLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E6F0", Offset = "0x7F9D2F0", VA = "0x187F9E6F0")]
	public bool GAIKKJBDLHN([Out] float3 NIAFNFNJCAI, [Out] quaternion AJJDMOGKLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EA70", Offset = "0x7F9D670", VA = "0x187F9EA70")]
	public bool LEGJDLHJIGP([Out] float KFANGDFLDBM, [Out] float BBNFLDDAHBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E620", Offset = "0x7F9D220", VA = "0x187F9E620")]
	public void FHKAMNBKDBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public LIJDGNNNPCB(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E490", Offset = "0x7F9D090", VA = "0x187F9E490", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(LIJDGNNNPCB GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct PAJKCLCKHDE : IEquatable<PAJKCLCKHDE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	private CGHCFDJMGCD EEIBNIGCBML
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6930", Offset = "0x7FA5530", VA = "0x187FA6930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public Vector3 GKIMFBHMEAF
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6B30", Offset = "0x7FA5730", VA = "0x187FA6B30")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5510", Offset = "0x7FA4110", VA = "0x187FA5510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public Quaternion DINJLOEPCHE
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA55E0", Offset = "0x7FA41E0", VA = "0x187FA55E0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x7FA58D0", Offset = "0x7FA44D0", VA = "0x187FA58D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public Vector3 OMJNPDPKPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5C50", Offset = "0x7FA4850", VA = "0x187FA5C50")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4FF0", Offset = "0x7FA3BF0", VA = "0x187FA4FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public Quaternion AMOOKIJLHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x7FA69F0", Offset = "0x7FA55F0", VA = "0x187FA69F0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x7FA63E0", Offset = "0x7FA4FE0", VA = "0x187FA63E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public float KBFPPGJADNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5470", Offset = "0x7FA4070", VA = "0x187FA5470")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5330", Offset = "0x7FA3F30", VA = "0x187FA5330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public float AFACDHALJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5E30", Offset = "0x7FA4A30", VA = "0x187FA5E30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public Matrix4x4 PAIJAMOIAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5ED0", Offset = "0x7FA4AD0", VA = "0x187FA5ED0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public JFAOBFHPOAA BILKCCFOPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(JFAOBFHPOAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	private BNNLGKNFBBF CKPEGOEMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x7F968D0", Offset = "0x7F954D0", VA = "0x187F968D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5880", Offset = "0x7FA4480", VA = "0x187FA5880")]
	public LNFJEBGBMKD HPILIPNKAPH()
	{
		return default(LNFJEBGBMKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6670", Offset = "0x7FA5270", VA = "0x187FA6670")]
	public void NEJKMCHNPCD([Out] Matrix4x4 HHGKCBBJJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5A90", Offset = "0x7FA4690", VA = "0x187FA5A90")]
	public void IPHFLHIIJAJ([In] Vector3 MICNLECKIBH, [In] Quaternion HNIPNOOHHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5B90", Offset = "0x7FA4790", VA = "0x187FA5B90")]
	public void IPHFLHIIJAJ([In] RigidTransform NHMANADFPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5F10", Offset = "0x7FA4B10", VA = "0x187FA5F10")]
	public void KPGJKOKBAAL([Out] RigidTransform NHMANADFPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA64B0", Offset = "0x7FA50B0", VA = "0x187FA64B0")]
	public void NDLJNKHKFAC([In] Vector3 OPDDCGHIKJF, [In] Quaternion LMKNDHGPNEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA65B0", Offset = "0x7FA51B0", VA = "0x187FA65B0")]
	public void NDLJNKHKFAC([In] RigidTransform OGGBJDJMOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4F10", Offset = "0x7FA3B10", VA = "0x187FA4F10")]
	public void AJMJGGFCNMG([Out] Vector3 OPDDCGHIKJF, [Out] Quaternion LMKNDHGPNEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4E60", Offset = "0x7FA3A60", VA = "0x187FA4E60")]
	public void AJMJGGFCNMG([Out] RigidTransform NHMANADFPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5170", Offset = "0x7FA3D70", VA = "0x187FA5170")]
	public UniformTRS CIHABHDLDLI()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7FA51A0", Offset = "0x7FA3DA0", VA = "0x187FA51A0")]
	public void CIHABHDLDLI([Out] UniformTRS OGGBJDJMOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7FA59A0", Offset = "0x7FA45A0", VA = "0x187FA59A0")]
	public UniformTRS IIHFHJIMBMM()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7FA59D0", Offset = "0x7FA45D0", VA = "0x187FA59D0")]
	public void IIHFHJIMBMM([Out] UniformTRS NHMANADFPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5D40", Offset = "0x7FA4940", VA = "0x187FA5D40")]
	public Vector3 JHLCPHGCAGL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5260", Offset = "0x7FA3E60", VA = "0x187FA5260")]
	public void DHBNBCGKDJF([In] Vector3 OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x7FA61B0", Offset = "0x7FA4DB0", VA = "0x187FA61B0")]
	public Vector3 MHMPBAIFDJG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6860", Offset = "0x7FA5460", VA = "0x187FA6860")]
	public void NPPCHLCOLBG([In] Vector3 OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x7FA62A0", Offset = "0x7FA4EA0", VA = "0x187FA62A0")]
	public Quaternion MIFHADELGMG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5720", Offset = "0x7FA4320", VA = "0x187FA5720")]
	public void GAGFANNGIBL([In] Quaternion OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5FC0", Offset = "0x7FA4BC0", VA = "0x187FA5FC0")]
	public Quaternion LHFDHHGAHBA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6790", Offset = "0x7FA5390", VA = "0x187FA6790")]
	public void NMBBMLLBKPL([In] Quaternion OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6C20", Offset = "0x7FA5820", VA = "0x187FA6C20")]
	public float POOBAMDCJPM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6100", Offset = "0x7FA4D00", VA = "0x187FA6100")]
	public void MBLMCHMLHKC(float OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6CC0", Offset = "0x7FA58C0", VA = "0x187FA6CC0")]
	public float PPLPLILNAPF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7FA50C0", Offset = "0x7FA3CC0", VA = "0x187FA50C0")]
	public void CFCMKNPPLBF(float OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7FA57F0", Offset = "0x7FA43F0", VA = "0x187FA57F0")]
	public Vector3 GJNBABDEIMN([In] Vector3 HLIFPOIPBBB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public PAJKCLCKHDE(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7FA53E0", Offset = "0x7FA3FE0", VA = "0x187FA53E0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(PAJKCLCKHDE GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct KCBNBDPKAGF : IEquatable<KCBNBDPKAGF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	private HFHOLDMNOBH OHOCIIGPLCE
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x7F9BC80", Offset = "0x7F9A880", VA = "0x187F9BC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	private COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x7F90730", Offset = "0x7F8F330", VA = "0x187F90730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BB40", Offset = "0x7F9A740", VA = "0x187F9BB40")]
	public void MLDGFOHMCLK(string GPIJFOKHGBC, DLJNFMBIPPJ BEIHHAGEJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public KCBNBDPKAGF(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BAB0", Offset = "0x7F9A6B0", VA = "0x187F9BAB0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(KCBNBDPKAGF GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF60", Offset = "0x7F8EB60", VA = "0x187F8FF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public readonly struct KILBBMGFLMH : IEquatable<KILBBMGFLMH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public LJNJPJOGIHD BEAKOJPFCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x7F9BD70", Offset = "0x7F9A970", VA = "0x187F9BD70")]
		get
		{
			return default(LJNJPJOGIHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public KILBBMGFLMH(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BCE0", Offset = "0x7F9A8E0", VA = "0x187F9BCE0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(KILBBMGFLMH GMNGNCHKEBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct DPGAHMBFJJC : IEquatable<DPGAHMBFJJC>
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public struct LMFMMDKMEND : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private GBGGLBKJJPC EAOPNGFGOCP;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x7F9FA80", Offset = "0x7F9E680", VA = "0x187F9FA80")]
		public LMFMMDKMEND(GBGGLBKJJPC EAOPNGFGOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x7F9F9F0", Offset = "0x7F9E5F0", VA = "0x187F9F9F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x7F91FC0", Offset = "0x7F90BC0", VA = "0x187F91FC0")]
	public LMFMMDKMEND BNBBJFBFOAH()
	{
		return default(LMFMMDKMEND);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7F922D0", Offset = "0x7F90ED0", VA = "0x187F922D0")]
	public KMBMEPCOJFD IMNBEGECCCP(Allocator CMJGNOOCEGA = Allocator.Temp)
	{
		return default(KMBMEPCOJFD);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x7F921A0", Offset = "0x7F90DA0", VA = "0x187F921A0")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> HJFDEJAHAEL(Allocator CMJGNOOCEGA = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x7F923C0", Offset = "0x7F90FC0", VA = "0x187F923C0")]
	public NativeArray<PLLPLODJPBF> NEGLAAHGKCH(Allocator CMJGNOOCEGA = Allocator.Temp)
	{
		return default(NativeArray<PLLPLODJPBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x7F925B0", Offset = "0x7F911B0", VA = "0x187F925B0")]
	public NativeArray<PLLPLODJPBF> OKPNHIFNCNF(Allocator CMJGNOOCEGA = Allocator.Temp)
	{
		return default(NativeArray<PLLPLODJPBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x7F920E0", Offset = "0x7F90CE0", VA = "0x187F920E0")]
	public EDFFLPPIDFO GDMCEJPKLIM(Allocator CMJGNOOCEGA = Allocator.Temp)
	{
		return default(EDFFLPPIDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x7F924F0", Offset = "0x7F910F0", VA = "0x187F924F0")]
	public EDFFLPPIDFO OEFCGIFEKLO(Allocator CMJGNOOCEGA = Allocator.Temp)
	{
		return default(EDFFLPPIDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7F91F00", Offset = "0x7F90B00", VA = "0x187F91F00")]
	public EDFFLPPIDFO BJPNMILPEDD(Allocator CMJGNOOCEGA = Allocator.Temp)
	{
		return default(EDFFLPPIDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public DPGAHMBFJJC(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7F92050", Offset = "0x7F90C50", VA = "0x187F92050", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(DPGAHMBFJJC GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x7F926E0", Offset = "0x7F912E0", VA = "0x187F926E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct FDNKLMNPJFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int BENECPLONLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int MABAHGLEBCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct OBGNMNBMKOE : IEquatable<OBGNMNBMKOE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public DPGAHMBFJJC AODCFNAJEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(DPGAHMBFJJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public IEPHKFJDAFC BFGAMFNDOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(IEPHKFJDAFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public KILBBMGFLMH DJEGFAIGLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(KILBBMGFLMH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3A30", Offset = "0x7FA2630", VA = "0x187FA3A30")]
	public bool NICJHJJJBHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA38C0", Offset = "0x7FA24C0", VA = "0x187FA38C0")]
	public bool FEODGKGEEHE([Out] Exception FCEJBDLGOKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public OBGNMNBMKOE(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
	public static GBGGLBKJJPC GHOKLFELACP(OBGNMNBMKOE OOHGFGHCOAJ)
	{
		return default(GBGGLBKJJPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3830", Offset = "0x7FA2430", VA = "0x187FA3830", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(OBGNMNBMKOE GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x7F926E0", Offset = "0x7F912E0", VA = "0x187F926E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public readonly struct NNKKLIHKNGN : IDisposable, IEquatable<NNKKLIHKNGN>
{
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public static readonly NNKKLIHKNGN KLPCNDNNFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public OBGNMNBMKOE BGAIKNCNNOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(OBGNMNBMKOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public DPGAHMBFJJC AODCFNAJEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(DPGAHMBFJJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x7FA36C0", Offset = "0x7FA22C0", VA = "0x187FA36C0")]
	public void JDNFFANODMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3560", Offset = "0x7FA2160", VA = "0x187FA3560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public NNKKLIHKNGN(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3630", Offset = "0x7FA2230", VA = "0x187FA3630", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "5")]
	public bool Equals(NNKKLIHKNGN GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3740", Offset = "0x7FA2340", VA = "0x187FA3740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public readonly struct IEPHKFJDAFC : IEquatable<IEPHKFJDAFC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public bool EILBDHBNCCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A100", Offset = "0x7F98D00", VA = "0x187F9A100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	public IEPHKFJDAFC(GBGGLBKJJPC EAOPNGFGOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8EB30", VA = "0x187F8FF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A190", Offset = "0x7F98D90", VA = "0x187F9A190", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF20", Offset = "0x7F8EB20", VA = "0x187F8FF20", Slot = "4")]
	public bool Equals(IEPHKFJDAFC GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x7F926E0", Offset = "0x7F912E0", VA = "0x187F926E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class OCPDLHKDDJD
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private struct MPGAMIECKDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Guid LHECJJHBNHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public HHIAGFHCONF BPOPEOMDAML;
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private struct HHIAGFHCONF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int OOHGFGHCOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int OMPONBMFDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int DCDGODDHGDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int HNGEKBGMGAI;

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x7F98330", Offset = "0x7F96F30", VA = "0x187F98330")]
		public bool GJIJNECHGLA([Out] PLLPLODJPBF OAJMKPFMDHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x7F983D0", Offset = "0x7F96FD0", VA = "0x187F983D0")]
		public HHIAGFHCONF(PLLPLODJPBF OAJMKPFMDHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3BF0", Offset = "0x7FA27F0", VA = "0x187FA3BF0")]
	public static Guid DGJDPHIPHOL(this PLLPLODJPBF OAJMKPFMDHN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3BD0", Offset = "0x7FA27D0", VA = "0x187FA3BD0")]
	public static bool CLDPNKILKGM(this Guid LHECJJHBNHF, [Out] PLLPLODJPBF OAJMKPFMDHN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal static class ENJPFHIKEBN
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x7F93990", Offset = "0x7F92590", VA = "0x187F93990")]
	public static COKECCKPMJD DJECBLFHAPB(this GBGGLBKJJPC ALPNKEJICNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x7F93B30", Offset = "0x7F92730", VA = "0x187F93B30")]
	public static DIOBJPDBJAJ MLDHFINAALK(this GBGGLBKJJPC ALPNKEJICNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x7F93900", Offset = "0x7F92500", VA = "0x187F93900")]
	public static EntityManager DAJNGOJPDIC(this GBGGLBKJJPC ALPNKEJICNA)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x3913AA0", Offset = "0x39126A0", VA = "0x183913AA0")]
	internal static bool NONGECHPGBF<T>(this GBGGLBKJJPC ALPNKEJICNA, bool AENFHNMCJOM) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x7F93A20", Offset = "0x7F92620", VA = "0x187F93A20")]
	public static bool LJHPJAKMHGO(this GBGGLBKJJPC ALPNKEJICNA, LECBLDAKGLK NMCGBFDKCMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x3913C60", Offset = "0x3912860", VA = "0x183913C60")]
	public static bool ODEFPJJGAIN<T>(this GBGGLBKJJPC ALPNKEJICNA) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x390F570", Offset = "0x390E170", VA = "0x18390F570")]
	public static bool HCJPLLLAALI<T>(this GBGGLBKJJPC ALPNKEJICNA) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x3912110", Offset = "0x3910D10", VA = "0x183912110")]
	[LPFAIGMGHEK]
	public static T MIGEIABABKB<T>(this GBGGLBKJJPC ALPNKEJICNA) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x390F6D0", Offset = "0x390E2D0", VA = "0x18390F6D0")]
	[LPFAIGMGHEK]
	public static T HPLJCPPBGJA<T>(this GBGGLBKJJPC ALPNKEJICNA) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x3913980", Offset = "0x3912580", VA = "0x183913980")]
	public static bool NMGAKFIANFK<T>(this GBGGLBKJJPC ALPNKEJICNA, [Out] T OOHGFGHCOAJ) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x390F440", Offset = "0x390E040", VA = "0x18390F440")]
	public static T ENDCJMJLCFB<T>(this GBGGLBKJJPC ALPNKEJICNA) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x390F4F0", Offset = "0x390E0F0", VA = "0x18390F4F0")]
	public static T FBGHIFOEANG<T>(this GBGGLBKJJPC ALPNKEJICNA) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal static class DNLBEGEIFOC
{
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public struct KMBMEPCOJFD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private EDFFLPPIDFO ENEAIMANIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> IPAPOLDFDMI;

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E9D0", Offset = "0x5D4D5D0", VA = "0x185D4E9D0")]
	public KMBMEPCOJFD(EDFFLPPIDFO ENEAIMANIIG, NativeArray<EntityRemapUtility.EntityRemapInfo> IPAPOLDFDMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C740", Offset = "0x7F9B340", VA = "0x187F9C740")]
	public LocalId IIOPCKDFHEH(LocalId KDKJDFFGNJJ)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C780", Offset = "0x7F9B380", VA = "0x187F9C780")]
	public LocalId IIOPCKDFHEH(int EMMACFPOKFB)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C6D0", Offset = "0x7F9B2D0", VA = "0x187F9C6D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GNBFCNMFCOJ
{
	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMBKKNFIFBA(World CJNNELLKJGB, NativeParallelHashSet<FixedString64Bytes> EGKDOOBHPIK);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MHPMBGAOEOP
{
	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OEGNHPNMEKB(GBGGLBKJJPC EGALIAAOIOO, [Out] uint ALPNKEJICNA);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EHOAHAGFMDP(GBGGLBKJJPC EGALIAAOIOO, [Out] uint ALPNKEJICNA);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GAJMNNCCBGC(GBGGLBKJJPC EGALIAAOIOO, uint ALPNKEJICNA);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JKNEPAGJNAG(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string AHAOKJGOBLP(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CAFGOBECAJC(GBGGLBKJJPC EGALIAAOIOO, string ALPNKEJICNA);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BMPGAFBGMNA(GBGGLBKJJPC EGALIAAOIOO, [Out] string FIADECNLFGK);

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NGHELMAKBEF(GBGGLBKJJPC EGALIAAOIOO, string FIADECNLFGK);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AFLKGGANELK
{
	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	Guid MFFBEECJOMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	Guid JIMEBBHJBOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DCDOMCDBELL(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task LLLEBMLJKEB(GBGEFMIEGNI KDKJDFFGNJJ);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid AONACGGDKED(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IENJMLCAMJP(GBGGLBKJJPC EAOPNGFGOCP, Guid GKLJHCMGFAB);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CFOIJBMMFBC(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task COPDPKLFJHC(GBGGLBKJJPC DIMLHDJJHIH, GBGGLBKJJPC LIPFJJEAFCE);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KMHMKMMHJDO(GBGGLBKJJPC EAOPNGFGOCP, PLLPLODJPBF DCHNNCLJCAA);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NNJKMHDELAP
{
	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	Guid MFFBEECJOMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHHNNEAPHJP(NativeList<Guid> KNLODIDIJIP, NativeList<Guid> ANPJCOOCPBL, NativeList<FixedString64Bytes> KEAICMBCGPK);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PEHOCFBOMFM
{
	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EDFFLPPIDFO PNBMEBMHFCF(Allocator CMJGNOOCEGA);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EDFFLPPIDFO GJJEHIIDOIN(Allocator CMJGNOOCEGA);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GCBGNJBJBOB(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BGJHOFONJEE(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool COBHELMBJAF(GBGGLBKJJPC EGALIAAOIOO, [Out] GBGGLBKJJPC PHNEDIJGAMP);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FPJHBMNCIPC(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MGFHEHGFJPO(GBGGLBKJJPC EGALIAAOIOO, int KJIKHIJJPOK);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GBGGLBKJJPC EBNIKCHBOCA(GBGGLBKJJPC PHNEDIJGAMP);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LOPCLODBCCB(EDFFLPPIDFO HKCBJNOPFKH, bool GBGLCKLJIPC);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MMEMDEEDCFJ(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MKFOHNFILIN(GBGGLBKJJPC EGALIAAOIOO, bool JOGEGKKLLBN);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int KGFPIBBJGNF();

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BHCFMKDLNIO(GBGGLBKJJPC EAOPNGFGOCP);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AHNOMBGEGCI
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<GBGGLBKJJPC, GBGGLBKJJPC> BMHFCNIEJMJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<GBGGLBKJJPC, GBGGLBKJJPC> CDOFOAKLIPA;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<GBGGLBKJJPC, GBGGLBKJJPC, GBGGLBKJJPC> LPDDKEFMKEN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<GBGGLBKJJPC> LLOJMJALKMC;

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CPBNOEIPPOC(GBGGLBKJJPC EAOPNGFGOCP, GBGGLBKJJPC MIIBEKEODGD);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GBGGLBKJJPC FBCGNFPACAC(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EDFFLPPIDFO KHLBEEJBIIC(GBGGLBKJJPC EAOPNGFGOCP, Allocator CMJGNOOCEGA);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GBGGLBKJJPC PMKLIOIKNKL(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AJPFOHLIBAE(GBGGLBKJJPC EAOPNGFGOCP, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JDDEHHGPHMK(GBGGLBKJJPC EAOPNGFGOCP, float HKEPCDNIKBH);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool MGEKCBCNOCH(GBGGLBKJJPC EAOPNGFGOCP, [Out] GBGGLBKJJPC LIPFJJEAFCE);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool FGJIBPFGLFN(GBGGLBKJJPC EAOPNGFGOCP, [Out] RigidTransform BMDIJMIOFKD);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 JHNINFEKLDA(HMEEFLBBNMM GGCJLICHELN);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion LAMAHPINDBK(HMEEFLBBNMM GGCJLICHELN);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class BGFJCHEBBNF
{
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FAIJCKGPCBG
{
	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	object GNKAEKDJHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BNDCOFDPGEP
{
	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BOOEPEFHGED(GBGGLBKJJPC KDKJDFFGNJJ, BAPIJFCDNAC NOFOOCBNKOH);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFADMFGAMNF(BAPIJFCDNAC NOFOOCBNKOH);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NEGNADDGOFG(GBGGLBKJJPC EAOPNGFGOCP, [Out] BAPIJFCDNAC ODBOIEPHNIO);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[Flags]
public enum CMHIEMGELPP
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	IncludeSelf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	IncludeChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	IncludeDescendants = 6,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	IncludeMask = 7,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Disembodied = 8,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Embodied = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	IgnoreEmbodiment = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	EmbodimentMask = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Runtime = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Authored = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	AuthoredAndRuntime = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	HierarchyMask = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	HintInputsAreDisjoint = 0x80
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LGPCKFACDNO
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public ref struct MBBIMPPGJHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public ReadOnlySpan<GBGGLBKJJPC> NFEMIIJCKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public GBGGLBKJJPC GMAMJHIJAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public GBGGLBKJJPC OBICKBAIPBI;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PPLJBECONHF(GBGGLBKJJPC LNJGDGDBIPB, GBGGLBKJJPC LJBPNMDBICI);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JFLFBEOOLCA(GBGGLBKJJPC LHMLMAPKPBE);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ReadOnlySpan<GBGGLBKJJPC> HNHAKFFMGKM(GBGGLBKJJPC LHMLMAPKPBE);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<GBGGLBKJJPC> ENHBJEMIOFI(GBGGLBKJJPC LHMLMAPKPBE);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MBBIMPPGJHC HGLGKJIBNIL(GBGGLBKJJPC LHMLMAPKPBE, float ECJIMMLMELA);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EBLIPBJAKMH(GBGGLBKJJPC LHMLMAPKPBE, [Out] KEHIJGGMCEB EAMDNJPMPAF);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AICADDCIEGP(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IEFBOMHOJIB(GBGGLBKJJPC EAOPNGFGOCP);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public readonly struct JBMCLGIJLCD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly string LAOCJKNALFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly T IPOLOHBNCGD;

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x50AF6F0", Offset = "0x50AE2F0", VA = "0x1850AF6F0")]
	public JBMCLGIJLCD(T IPOLOHBNCGD, [Optional][CallerMemberName] string LAOCJKNALFF)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public static readonly JBMCLGIJLCD<int> OMBAHHPJDDH;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public static readonly JBMCLGIJLCD<int> KMLFMCNMHHP;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly JBMCLGIJLCD<int> OJGEDKHFHEH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public enum CLHEBDHLKJG
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class JKPKOPBEKJD
{
	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x138B880", Offset = "0x138A480", VA = "0x18138B880")]
	public static bool AAJAOLOJIJJ(this CLHEBDHLKJG DKILGKEHOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x1797400", Offset = "0x1796000", VA = "0x181797400")]
	public static bool KOOIOCHONPP(this CLHEBDHLKJG DKILGKEHOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2FD4FA0", Offset = "0x2FD3BA0", VA = "0x182FD4FA0")]
	public static bool CPMFKLLPAAD(this CLHEBDHLKJG DKILGKEHOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x138B870", Offset = "0x138A470", VA = "0x18138B870")]
	public static bool FFJJNFAEPGG(this CLHEBDHLKJG DKILGKEHOLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BCEKJLJLIMJ
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public enum HACIDJMBEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public enum IAHOAMGIEAH
	{
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	HACIDJMBEKJ DLFBAAOOPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	bool BFKJBJJHNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	bool AKCLHOMFGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	IAHOAMGIEAH ONIMJLMHHKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[ServiceLifetime(Lifetime.Application)]
public interface OOIKPNNGOPE
{
	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	CLHEBDHLKJG AIAEELCEDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	CLHEBDHLKJG KIKIFBKOCFE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	CLHEBDHLKJG DJEHIKMHIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	CLHEBDHLKJG CMICAOGODDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	CLHEBDHLKJG OFDMOPNMNKG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	CLHEBDHLKJG OGEKKCPEKKF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	CLHEBDHLKJG HDFEKGDNKGH
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	CLHEBDHLKJG KJDMNHHLIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	CLHEBDHLKJG ILDIIFGDGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	CLHEBDHLKJG AIPBPECPPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	CLHEBDHLKJG LEIBJHJEOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	CLHEBDHLKJG FOCIHDGFMIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	CLHEBDHLKJG PHAEAGGIPKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	CLHEBDHLKJG HMHEHDDFDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	CLHEBDHLKJG DMKOJFMIJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	CLHEBDHLKJG FHHAHBMHHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	CLHEBDHLKJG KPMCHHMKPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	CLHEBDHLKJG PIBDJABACKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	CLHEBDHLKJG FNLENPNGDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	CLHEBDHLKJG IHENMMACBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LBDBFELEJGA(JBMCLGIJLCD<int> JLMFPIBLIFF);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OGJOONKMAFC
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event MKDHCDAPLNK.FHBFNEBPINN GELPPIIBDOI;

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GBGGLBKJJPC CNCPPNJKLOG(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EDFFLPPIDFO CPGGFHLKFCI(Allocator CMJGNOOCEGA);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BBNAELAIBIF NGIPIFKMGEH(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JAJDOOIEPJK(IEnumerable<GBGGLBKJJPC> JLGOAPDKKAP);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BBNAELAIBIF ICPMONHFGOM(GBGGLBKJJPC LIPFJJEAFCE, GBGGLBKJJPC ENEAIMANIIG, bool DBDEPKIJKON, GBGGLBKJJPC MDKAAPLMLKG);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GBGGLBKJJPC GPBMOMKFEAK(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OAAMBAOIOOB(GBGGLBKJJPC EAOPNGFGOCP, GBGGLBKJJPC LIPFJJEAFCE, bool PGCCOHFPPFF = false);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PDHDKFGGEFH(GBGGLBKJJPC EAOPNGFGOCP, GBGGLBKJJPC LIPFJJEAFCE);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MJIHKACDOBJ(GBGGLBKJJPC KMHILJCDMII, GBGGLBKJJPC LOHGNICJIMD);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	EDFFLPPIDFO NCAOGOEEECP(GBGGLBKJJPC AEIJGHPBELE);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MFMIGFJGEHG(GBGGLBKJJPC EAOPNGFGOCP, GBGGLBKJJPC OCOKIJBLALF);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EDFFLPPIDFO KNKGOGOIGID(EDFFLPPIDFO HFGPOPJOMIJ, CMHIEMGELPP GEFKHBLJENB, Allocator CMJGNOOCEGA);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool MKBAFCHGJDC(GBGGLBKJJPC EAOPNGFGOCP, GBGGLBKJJPC BMMHMAPMBII);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GBGGLBKJJPC DFHMHJKJCCE(GBGGLBKJJPC MDKAAPLMLKG, GBGGLBKJJPC JPMDOIJPBNE);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool PFGBNPMGJGN(GBGGLBKJJPC MDKAAPLMLKG, GBGGLBKJJPC JPMDOIJPBNE, [Out] GBGGLBKJJPC FNEGNABGJOM);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	GBGGLBKJJPC EAJLNMLJAHO(GBGGLBKJJPC[] HKCBJNOPFKH);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	GBGGLBKJJPC BKPPABCCNHM(GBGGLBKJJPC EAOPNGFGOCP, uint EPBNDINKOJC);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class LDGEDJAHNCC
{
	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DF00", Offset = "0x7F9CB00", VA = "0x187F9DF00")]
	public static bool DGGJALNGJOA(this OGJOONKMAFC GNNAEMCNMBG, GBGGLBKJJPC EAOPNGFGOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DFB0", Offset = "0x7F9CBB0", VA = "0x187F9DFB0")]
	public static EDFFLPPIDFO KNKGOGOIGID(this OGJOONKMAFC CHLLPCJOLAE, GBGGLBKJJPC EAOPNGFGOCP, CMHIEMGELPP GEFKHBLJENB, Allocator CMJGNOOCEGA)
	{
		return default(EDFFLPPIDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DF70", Offset = "0x7F9CB70", VA = "0x187F9DF70")]
	public static EDFFLPPIDFO DMHBGICAOME(this OGJOONKMAFC CHLLPCJOLAE, GBGGLBKJJPC EAOPNGFGOCP, Allocator CMJGNOOCEGA)
	{
		return default(EDFFLPPIDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E240", Offset = "0x7F9CE40", VA = "0x187F9E240")]
	public static EDFFLPPIDFO OEFAEBMBPKH(this OGJOONKMAFC CHLLPCJOLAE, GBGGLBKJJPC EAOPNGFGOCP, Allocator CMJGNOOCEGA)
	{
		return default(EDFFLPPIDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DD20", Offset = "0x7F9C920", VA = "0x187F9DD20")]
	public static EDFFLPPIDFO AIMBKBJFKDB(this OGJOONKMAFC CHLLPCJOLAE, GBGGLBKJJPC EAOPNGFGOCP, Allocator CMJGNOOCEGA)
	{
		return default(EDFFLPPIDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E280", Offset = "0x7F9CE80", VA = "0x187F9E280")]
	public static EDFFLPPIDFO OFOCKDEGAGM(this OGJOONKMAFC CHLLPCJOLAE, GBGGLBKJJPC EAOPNGFGOCP, Allocator CMJGNOOCEGA)
	{
		return default(EDFFLPPIDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DD60", Offset = "0x7F9C960", VA = "0x187F9DD60")]
	public static EDFFLPPIDFO ALEMEAAPPOL(this OGJOONKMAFC CHLLPCJOLAE, GBGGLBKJJPC EAOPNGFGOCP, Allocator CMJGNOOCEGA)
	{
		return default(EDFFLPPIDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DDA0", Offset = "0x7F9C9A0", VA = "0x187F9DDA0")]
	public static EDFFLPPIDFO BHOFFOPJJPF(this OGJOONKMAFC CHLLPCJOLAE, GBGGLBKJJPC EAOPNGFGOCP, Allocator CMJGNOOCEGA)
	{
		return default(EDFFLPPIDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DDE0", Offset = "0x7F9C9E0", VA = "0x187F9DDE0")]
	public static EDFFLPPIDFO BHOFFOPJJPF(this OGJOONKMAFC CHLLPCJOLAE, EDFFLPPIDFO EAOPNGFGOCP, Allocator CMJGNOOCEGA)
	{
		return default(EDFFLPPIDFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DJNEJMCNLGN
{
	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KEEGFEGMDGI JFJINDHKCGK(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MLBLNEKFGNB(GBGGLBKJJPC EGALIAAOIOO, KEEGFEGMDGI MJBPAAHDCKD);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HNLDPJKPHOL(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DHNOFJLOAIA(GBGGLBKJJPC EGALIAAOIOO, bool OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HBFEOHNMHAE<string> LFCGHJIFEOF(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NJIEEFPDAGP(GBGGLBKJJPC EGALIAAOIOO, HBFEOHNMHAE<string> FHDDDNNLNCN);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HBFEOHNMHAE<string> NICBNGIDIHC(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JIEANEOBFJO(GBGGLBKJJPC EGALIAAOIOO, HBFEOHNMHAE<string> FHDDDNNLNCN);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HBFEOHNMHAE<string> OOMNDBIAJOG(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OJKODCPEGLM(GBGGLBKJJPC EGALIAAOIOO, HBFEOHNMHAE<string> FHDDDNNLNCN);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HBFEOHNMHAE<string> MLOKELLNFOK(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KDCIIGNBPAH(GBGGLBKJJPC EGALIAAOIOO, HBFEOHNMHAE<string> FHDDDNNLNCN);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LMFNOHJIMFP(GBGGLBKJJPC EGALIAAOIOO, GBGGLBKJJPC NEOGODNGJJE);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IHCGOCIDEPL
{
	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A220", Offset = "0x7F98E20", VA = "0x187F9A220", Slot = "0")]
	Task<OBGNMNBMKOE> JPKFOKEFNLH(JIEEKEEBHCL GCHJKMFEAOA, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "1")]
	void BMCMGENNKCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EELOJCDDLBJ
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event MKDHCDAPLNK.FHBFNEBPINN GELPPIIBDOI;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GBGGLBKJJPC GPBMOMKFEAK(GBGGLBKJJPC DIMLHDJJHIH);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<GBGGLBKJJPC> CDIIIMIHLEF();

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<GBGGLBKJJPC> BPOJCHJBCKD(GBGGLBKJJPC LIPFJJEAFCE);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MNCFEMGMONE(GBGGLBKJJPC LGNMMAJOHOB, GBGGLBKJJPC OLIDCOOFFFH, [Out] BBNAELAIBIF LGOAIGPFOHO);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BNHABFNIBFD(GBGGLBKJJPC LGNMMAJOHOB, GBGGLBKJJPC NIIGKLLKCBE, [Out] BBNAELAIBIF LGOAIGPFOHO);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PDMNANMPNLJ(GBGGLBKJJPC LGNMMAJOHOB);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PDHDKFGGEFH(GBGGLBKJJPC OANMFHLFOLA, GBGGLBKJJPC JHPFPLHIKAH);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BBNAELAIBIF LKMIAJAIBEI(GBGGLBKJJPC EAOPNGFGOCP);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HCBADEACGBJ
{
	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	bool OEMADNCDEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	bool IBINGBAMGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	bool EELGNENAGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FHFJAJIOENP
{
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BKBJPKOJMNG
{
	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECOJPKHGAPP(GBGGLBKJJPC EAOPNGFGOCP, LECBLDAKGLK NMCGBFDKCMK);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AABCEKPPJCG(GBGGLBKJJPC EAOPNGFGOCP, LECBLDAKGLK NMCGBFDKCMK);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NEHCENEIDAI
{
	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNDONEPBMAH([In] float3 NFEAKPLEKJO, [In] float3 HLIFPOIPBBB, float KNLGCBPGFKL, [Out] IENBEMANHLI JDMFCDCHMIE, [Out] GBGGLBKJJPC GIIDJBGBEKP);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int DEAHDNKGIFD([In] float3 NFEAKPLEKJO, float HPDHPFDMAAO, List<GBGGLBKJJPC> HKCBJNOPFKH);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HJCCGJBFOAI(Plane[] AHLGFFENEOJ, float3 NFEAKPLEKJO, float3 HBCLGDCABJJ, quaternion BFEELDCLMGM, List<GBGGLBKJJPC> HKCBJNOPFKH);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MJPPCDPBAIF
{
	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CNDONEPBMAH([In] NativeArray<Entity> NKHJILJFELH, [In] float3 NFEAKPLEKJO, [In] float3 HLIFPOIPBBB, [In] NativeArray<IENBEMANHLI> PGFOJKHILIM);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> DEAHDNKGIFD([In] NativeArray<Entity> NKHJILJFELH, [In] float3 NFEAKPLEKJO, float HPDHPFDMAAO);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> HJCCGJBFOAI([In] NativeArray<Entity> NKHJILJFELH, [In] NativeArray<float4> LFABAHBLJAK);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public struct AKLICLNLBCH : PNKHKLJALOP, IEquatable<AKLICLNLBCH>
{
	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public int FCJKCAOMEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0xD41C90", Offset = "0xD40890", VA = "0x180D41C90", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x140F560", Offset = "0x140E160", VA = "0x18140F560", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public int DLHOIMFANJP
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x2FF6F80", Offset = "0x2FF5B80", VA = "0x182FF6F80", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4900", Offset = "0x6FA3500", VA = "0x186FA4900", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FDA0", Offset = "0x7F8E9A0", VA = "0x187F8FDA0", Slot = "8")]
	public bool Equals(AKLICLNLBCH GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FDF0", Offset = "0x7F8E9F0", VA = "0x187F8FDF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct IENBEMANHLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public float ABLNBEFPPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public float3 AKLPJIPJBIP;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CNFMOHHOLKP
{
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BNNLGKNFBBF
{
	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	OGGBFDFNKPF PHGGKMMOPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<EDFFLPPIDFO, NativeArray<RRObjectPrefabData>> FJMMDDOJILA;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<EDFFLPPIDFO> MGKIAKEDMCL;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EDFFLPPIDFO OMBIGCIAFAC();

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HDHIOCEBAND DLPIOECBEDL(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "8")]
	RRObjectPrefabData IHKOCDAACEG(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ELFAFBJLKLC(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GBGEFMIEGNI ADNEDBNPIKG(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GCFDIONPNLA(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LJFNAFAMLKI(GBGGLBKJJPC EAOPNGFGOCP, [Out] Transform NMIBCHFJGAE);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GBGGLBKJJPC HJHFJNBEOIM(PLLPLODJPBF OAJMKPFMDHN);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool MJLLNANGBKD(PLLPLODJPBF OAJMKPFMDHN, [Out] GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PLLPLODJPBF AFGOGEGFECH(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "16")]
	EDFFLPPIDFO HJHFJNBEOIM(NativeArray<PLLPLODJPBF> OAJMKPFMDHN, Allocator CMJGNOOCEGA, bool DGPDMNCOCMA = true);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool GLKGKMBKMPO(NativeArray<EFEDKDCKBEH> HEICIDEBPNM, NativeArray<PLLPLODJPBF> IGANLDGJBGG, NativeArray<Entity> FNHHGPHLLCG, HBFEOHNMHAE<INFEFFPBFJD> NKEAANFOBPI);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "18")]
	GBGEFMIEGNI LNBFKNEOCOJ();

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "19")]
	GBGEFMIEGNI GMDOJMCNFAB(RRObjectPrefabData OGJLEDHLGFK, [Optional] ILDPOIGDHNO NJAKKEHADMF);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "20")]
	CHCNCIHCOLF JAIEOBEJHIP();

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "21")]
	MGHMHMMMJHA EBGKJAFNIEN();

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "22")]
	NIBPHBJCJKD GEGFOEFMFCF(DDKHKNGGFFK ACPKDGGGDAE);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MCAJHFNOCKB(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool ADANMKNDCBG(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "25")]
	EDFFLPPIDFO DKEHIHCNAGC(EDFFLPPIDFO IAIGNKFFBBA, Allocator CMJGNOOCEGA);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool DOBEMPPDGDH(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool CLKJFNJBAIM(GBGGLBKJJPC EAOPNGFGOCP, ComponentTypes ONPALAGGLAB);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	GBGGLBKJJPC BNCEGIEKJDB(Transform NMIBCHFJGAE);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class LBBACMGOHAL
{
	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x7F9CE20", Offset = "0x7F9BA20", VA = "0x187F9CE20")]
	internal static GBGGLBKJJPC PFPPIECFDOD(this Entity JMNEAPNCNHN, BNNLGKNFBBF BEIHHAGEJIL)
	{
		return default(GBGGLBKJJPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C870", Offset = "0x7F9B470", VA = "0x187F9C870")]
	public static GBGEFMIEGNI FOIEMJKIJLB(this BNNLGKNFBBF BEIHHAGEJIL, LocalId EAOPNGFGOCP)
	{
		return default(GBGEFMIEGNI);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9CA20", Offset = "0x7F9B620", VA = "0x187F9CA20")]
	public static GBGGLBKJJPC HJHFJNBEOIM(this BNNLGKNFBBF BEIHHAGEJIL, LocalId EAOPNGFGOCP)
	{
		return default(GBGGLBKJJPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C7D0", Offset = "0x7F9B3D0", VA = "0x187F9C7D0")]
	public static PLLPLODJPBF AFGOGEGFECH(this BNNLGKNFBBF BEIHHAGEJIL, LocalId EAOPNGFGOCP)
	{
		return default(PLLPLODJPBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x7F9CC80", Offset = "0x7F9B880", VA = "0x187F9CC80")]
	public static CHCNCIHCOLF NFMBMIGHLNA(this BNNLGKNFBBF BEIHHAGEJIL, RigidTransform OGGBJDJMOGK)
	{
		return default(CHCNCIHCOLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x7F9CAD0", Offset = "0x7F9B6D0", VA = "0x187F9CAD0")]
	public static NIBPHBJCJKD JCLBLMKNMHF(this BNNLGKNFBBF BEIHHAGEJIL, DDKHKNGGFFK CKCLCKKEEHN, RigidTransform OGGBJDJMOGK)
	{
		return default(NIBPHBJCJKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C880", Offset = "0x7F9B480", VA = "0x187F9C880")]
	public static MGHMHMMMJHA HHOKCOBABNN(this BNNLGKNFBBF BEIHHAGEJIL, RigidTransform OGGBJDJMOGK)
	{
		return default(MGHMHMMMJHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C840", Offset = "0x7F9B440", VA = "0x187F9C840")]
	private static void AHGHODNLPJA(GBGEFMIEGNI NFOBKJCDANP, RigidTransform OGGBJDJMOGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal interface OHFHJJFIHBL
{
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FCCHHHFAFPC
{
	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	bool DHJDFIAJCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	GBGGLBKJJPC DNPBJBGEFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	GBGEFMIEGNI MCNMPIPLFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event HEGHAFKJKML COGMKIGNBCC;

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GBGGLBKJJPC DFHMHJKJCCE(GBGGLBKJJPC MDKAAPLMLKG, GBGGLBKJJPC JPMDOIJPBNE);

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PFGBNPMGJGN(GBGGLBKJJPC MDKAAPLMLKG, GBGGLBKJJPC JPMDOIJPBNE, [Out] GBGGLBKJJPC FNEGNABGJOM);

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MCIIFMIAENN();

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NCLIICPCBOE();

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KPAGJIHBLGB(GBGGLBKJJPC MDKAAPLMLKG);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GIOGNPCFPOJ(GBGGLBKJJPC MDKAAPLMLKG);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public delegate void HEGHAFKJKML(GBGEFMIEGNI MHBEHJIEMCN, GBGEFMIEGNI FNEMKAGGCDJ);
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public static class NJHALIKNJNK
{
	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x7FA2590", Offset = "0x7FA1190", VA = "0x187FA2590")]
	public static bool KEBGBJLKOCA(this FCCHHHFAFPC HDPMEEHIEPD, GBGEFMIEGNI MDKAAPLMLKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x7FA24B0", Offset = "0x7FA10B0", VA = "0x187FA24B0")]
	public static bool DGCJCAJKBNM(this FCCHHHFAFPC HDPMEEHIEPD, GBGGLBKJJPC MDKAAPLMLKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x7FA2430", Offset = "0x7FA1030", VA = "0x187FA2430")]
	public static bool BAPOBGHFMHK(this FCCHHHFAFPC HDPMEEHIEPD, GBGGLBKJJPC MDKAAPLMLKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HFFKJKEAFEC
{
	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCOCPFLLOLA(NativeList<RRObjectPrefabData> PCGHLEDDMEB);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FLCHLFOMKAN
{
	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELKLHMPGMOG(GBGEFMIEGNI NFOBKJCDANP, FBBLGIGMICK OCHMMOHMIHP, List<GBGEFMIEGNI> HECIKPJEDLM);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int BDCICFJNKOK(GBGEFMIEGNI NFOBKJCDANP, FBBLGIGMICK OCHMMOHMIHP);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MAIAOPBKOJJ(GBGEFMIEGNI NFOBKJCDANP, List<GBGEFMIEGNI> HECIKPJEDLM);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OJMMCCEOOLO(GBGEFMIEGNI IJNCJOKBAFO, GBGEFMIEGNI MDKAAPLMLKG, FBBLGIGMICK OCHMMOHMIHP);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GBGEFMIEGNI JKIINCMFJGL(GBGEFMIEGNI IJNCJOKBAFO, int EMMACFPOKFB, FBBLGIGMICK OCHMMOHMIHP);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GNGMJOFJHGM(GBGEFMIEGNI IJNCJOKBAFO, GBGEFMIEGNI MDKAAPLMLKG, FBBLGIGMICK OCHMMOHMIHP);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LJCGPKLDBFB(GBGEFMIEGNI IJNCJOKBAFO, GBGEFMIEGNI MDKAAPLMLKG, FBBLGIGMICK OCHMMOHMIHP);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KACBCFCABGJ(GBGEFMIEGNI IJNCJOKBAFO, FBBLGIGMICK OCHMMOHMIHP);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MODCMOADGIB(GBGEFMIEGNI IJNCJOKBAFO, GBGEFMIEGNI MDKAAPLMLKG, FBBLGIGMICK OCHMMOHMIHP);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PILEBGLDNEK(Entity IJNCJOKBAFO, Entity MDKAAPLMLKG, FBBLGIGMICK OCHMMOHMIHP);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OOAEKBEJOJN(Entity IJNCJOKBAFO, FBBLGIGMICK OCHMMOHMIHP);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AMKHHFLJLDO(GBGEFMIEGNI MDKAAPLMLKG, FBBLGIGMICK OCHMMOHMIHP);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NLLFABDOIGH
{
	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	KILBBMGFLMH BEPGAOILFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LJNJPJOGIHD EIBIKLBGKMI(KILBBMGFLMH IPOHHENOLFI);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KILBBMGFLMH CENMBHCFIDI();

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KILBBMGFLMH HNPAMNCMNPD();
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PPJGJJLCEOG
{
	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HKJDEEIKLHK(GBGGLBKJJPC MDKAAPLMLKG, [Out] GBGGLBKJJPC OHKOCODJLOK);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AIFNOKLMGEM
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<GBGGLBKJJPC> NJILCEHCLBK;

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PPIHKAIBHPM(GBGGLBKJJPC AEIJGHPBELE, bool OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AIJGKKHPJDH(GBGGLBKJJPC AEIJGHPBELE, bool OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FHHEKBIMBAA(GBGGLBKJJPC AEIJGHPBELE, int OOHGFGHCOAJ);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MAKBBLKFAAF
{
	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<GBGGLBKJJPC> DJNKAOPPANH(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GBGGLBKJJPC PKNNBJEHKFJ(GBGGLBKJJPC EAOPNGFGOCP, int EMMACFPOKFB);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int JMGPGKNBGCF(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BMIAJFBBPCI HNBEEOKJGIL(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CDGDCJPAJCB(GBGGLBKJJPC EAOPNGFGOCP, BMIAJFBBPCI GALEDNLDGCG);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GBGGLBKJJPC DCDCFICDEIP(GBGGLBKJJPC EAOPNGFGOCP, [Optional] float3? IIBJECFMAJC, [Optional] quaternion? BFEELDCLMGM, [Optional] float3? LHHOCCKJGIB);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GBGGLBKJJPC KCCDHFGAEAF(GBGGLBKJJPC EAOPNGFGOCP, int EMMACFPOKFB, [Optional] float3? IIBJECFMAJC, [Optional] quaternion? BFEELDCLMGM, [Optional] float3? LHHOCCKJGIB);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NEMOINDLBJB(GBGGLBKJJPC EAOPNGFGOCP, int EMMACFPOKFB);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HKCLDOKCJBE(GBGGLBKJJPC EAOPNGFGOCP);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IHGNDIBFEKP
{
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GMMMEDMHNJN
{
	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	bool FPOACOKBIJF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LNEMHKNCJKD();

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CAHOFHCGOOG();

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OJHJLHGBFLP();

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADODFIPLNCM();

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FNEDGJEPHLK();

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ODGELNOAPCB();

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HLMPEBGNILH();

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NJJGIMMJDAI();

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JCNHDFLLHDI();

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DLKNPJECOLI();

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BAAHCNJEKCH();

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NKJMIBJKAIA();
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CKDKJFBJHAH
{
	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGHLCIPPIIJ(GBGGLBKJJPC MDKAAPLMLKG, [Out] int IJNCJOKBAFO);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HANBDLHNIGO(GBGGLBKJJPC MDKAAPLMLKG, int IJNCJOKBAFO);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIDJKMGEJKJ(GBGGLBKJJPC MDKAAPLMLKG, bool HCECJAHDMKO);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OIBAOCBHKNG(GBGGLBKJJPC MDKAAPLMLKG, float PALKODGLGEA, float GKDIFLDALMK, float GCMCFADHMDF);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LEGJDLHJIGP(GBGGLBKJJPC EAOPNGFGOCP, [Out] float GKDIFLDALMK, [Out] float GCMCFADHMDF);

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ONLABJMPEHG(GBGGLBKJJPC MDKAAPLMLKG, float3 IIBJECFMAJC, quaternion BFEELDCLMGM);

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GAIKKJBDLHN(GBGGLBKJJPC MDKAAPLMLKG, [Out] float3 IIBJECFMAJC, [Out] quaternion BFEELDCLMGM);

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FHKAMNBKDBG(GBGGLBKJJPC MDKAAPLMLKG);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CGHCFDJMGCD
{
	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHBNBCGKDJF(Entity JMNEAPNCNHN, [In] float3 OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 JHLCPHGCAGL(Entity JMNEAPNCNHN);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GAGFANNGIBL(Entity JMNEAPNCNHN, [In] quaternion OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion MIFHADELGMG(Entity JMNEAPNCNHN);

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPHFLHIIJAJ(Entity JMNEAPNCNHN, [In] float3 IIBJECFMAJC, [In] quaternion BFEELDCLMGM);

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KPGJKOKBAAL(Entity JMNEAPNCNHN, [Out] RigidTransform LIAJFGLFJOK);

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NDLJNKHKFAC(Entity JMNEAPNCNHN, [In] float3 IIBJECFMAJC, [In] quaternion BFEELDCLMGM);

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AJMJGGFCNMG(Entity JMNEAPNCNHN, [Out] float3 IIBJECFMAJC, [Out] quaternion BFEELDCLMGM);

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AJMJGGFCNMG(Entity JMNEAPNCNHN, [Out] RigidTransform LIAJFGLFJOK);

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MBLMCHMLHKC(Entity JMNEAPNCNHN, float OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float POOBAMDCJPM(Entity JMNEAPNCNHN);

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NPPCHLCOLBG(Entity JMNEAPNCNHN, [In] float3 OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 MHMPBAIFDJG(Entity JMNEAPNCNHN);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NMBBMLLBKPL(Entity JMNEAPNCNHN, [In] quaternion OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion LHFDHHGAHBA(Entity JMNEAPNCNHN);

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CFCMKNPPLBF(Entity JMNEAPNCNHN, float OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float PPLPLILNAPF(Entity JMNEAPNCNHN);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BIFJMKOPDIC(Entity JMNEAPNCNHN, [Out] float4x4 HHGKCBBJJPO);

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FONJJJKEMLK(Entity JMNEAPNCNHN, [In] float4x4 HHGKCBBJJPO);

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PNLFLOJDHFE(Entity JMNEAPNCNHN);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GDOKANMIOKD(Entity JMNEAPNCNHN, Entity FGKFJDBOFLH, Entity JHPFPLHIKAH);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class DLHEHHPNPPM
{
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface POIFENLBGHJ
{
	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPDBCHEPJEC(bool IBOKCFEKOPO);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HFHOLDMNOBH
{
	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCGBLONFNHP(GBGGLBKJJPC EGALIAAOIOO, HBFEOHNMHAE<string> FHDDDNNLNCN);

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFJEPLGNLNN(GBGGLBKJJPC EGALIAAOIOO, HBFEOHNMHAE<string> FHDDDNNLNCN);

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMNMADIJNKO(GBGGLBKJJPC EGALIAAOIOO, HBFEOHNMHAE<string> FHDDDNNLNCN);

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCCMJGIDEDL(GBGGLBKJJPC EGALIAAOIOO, HBFEOHNMHAE<string> FHDDDNNLNCN);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KLFKBIBKCAH(GBGGLBKJJPC EGALIAAOIOO, HBFEOHNMHAE<string> FHDDDNNLNCN);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CDNEKNFEKFL(GBGGLBKJJPC EGALIAAOIOO, HBFEOHNMHAE<string> FHDDDNNLNCN);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int APHAGDOPLFB(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int OEHFNBAJKHB(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int KGEAKFOKHNE(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JAGGGNKIKJG<string> JNDFNLDPGGB(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool CGGNPABMOPP(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JAGGGNKIKJG<string> GKNNJGHMGLO(GBGGLBKJJPC EGALIAAOIOO);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PCJPAHJAPLM(GBGGLBKJJPC EGALIAAOIOO, string GPIJFOKHGBC);

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OLODGKLEHGE(string GPIJFOKHGBC, DLJNFMBIPPJ JMKPKMBCFLN);

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GBGGLBKJJPC GCGEMMGLION(string GPIJFOKHGBC);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OMGCCIIMFKO(string GPIJFOKHGBC, DLJNFMBIPPJ JMKPKMBCFLN);

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MLDGFOHMCLK(GBGGLBKJJPC APFCJCINCOL, string GPIJFOKHGBC, DLJNFMBIPPJ JMKPKMBCFLN);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	JAGGGNKIKJG<string> NFMMECCMGPO();
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class JDDKFMPBHDG
{
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DBEBOAEICJK
{
	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World HKDOODKMIKG(string AKMMBKCKFJN = "Main");

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World JJPHMDFPONF(string AKMMBKCKFJN = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World MKKLBHGBDNC(string AKMMBKCKFJN = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World HKEBPJEJNDF(string AKMMBKCKFJN = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DIOBJPDBJAJ
{
	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	World BJMLDCNLINK
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	World NINLDOHIOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	EntityManager DAJNGOJPDIC
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	bool PPEBHELAIMP
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase FMCDEIHECBH(Type OPOPAMPKKGD);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class GKFAGHBGPBH
{
	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x7F97B70", Offset = "0x7F96770", VA = "0x187F97B70")]
	public static ComponentSystemBase KHEOFFJOHNP(this World CJNNELLKJGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C180", Offset = "0x3A9AD80", VA = "0x183A9C180")]
	public static T FMCDEIHECBH<T>(this DIOBJPDBJAJ FONACJLPMGC) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EBHECMLDCFL
{
	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKOPNHFMBHD(NativeListAsync<Entity> KFDMFNAHLMK);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LDMAIINHIHM(KPPACFMPCNJ ABNCLDHIMJA);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EOPONCIKNEI(NativeListAsync<Entity> HADNBJDNBDO, bool MLIEKBNGHOP);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GALJHMMCADJ();

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PDHLDHGGCCC(Entity HMGDINOCJAI);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface ANGMIKFLIGC
{
	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHJHLKGIJAA(Collider HNEMFCNMJHE, [Out] PEPMMAMONPM DCMCHDGNMMD);
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NAPPFKMHMBI
{
	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider CJAOILOKFCD(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject PKMPGCPOGDN(GBGGLBKJJPC NJCDPIJDMMG, GameObject DNPJNJCBEBE, Vector3 MICNLECKIBH, Quaternion HNIPNOOHHIL);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICBDDGFLGLM(GameObject HNEMFCNMJHE);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider HPGIIPJNIBL<TCollider>(GameObject NALPHBPHOKI) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LMMJNKKAFFJ(Collider HNEMFCNMJHE);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject BHBJNGKKMLG<TCollider>(string LAOCJKNALFF) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ONFGDKBJPCG FKBPMFPKNAM(GBGGLBKJJPC HJAEJJFLNJK, GBGGLBKJJPC IIBHALIEKEC, DDKHKNGGFFK CPMOBFKIGOO, float3 KKMOANFLIDF, quaternion JCECADIFBFL, float3 CDHHINPIGMF);

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NEEOPFJNOIF(GBGGLBKJJPC EAOPNGFGOCP, [Out] ONFGDKBJPCG HNEMFCNMJHE);

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FMDGDGGBPDC(GBGGLBKJJPC EAOPNGFGOCP, [Out] GBGGLBKJJPC HMGDINOCJAI);
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public enum HFJBDKKIEDE
{
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HLGIOBGHNLH
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public struct KCBBMOFMOJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int CPMOBFKIGOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public GameObject DNPJNJCBEBE;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CLOLMJHONDA(GBGGLBKJJPC EAOPNGFGOCP, HGLJMJMDMPG EFEEJDLPAIK, bool FKMOKCGPCGK, PPFJOHBKEDL MJMPNBCKHAG);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNCIBIJAFAG(GBGGLBKJJPC EAOPNGFGOCP, HGLJMJMDMPG EFEEJDLPAIK, bool FKMOKCGPCGK, bool PFCCILPLBGJ, bool EHDEFFOOCJB);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FGMAABPPANI KLGEFFIDGMB(GBGGLBKJJPC HMGDINOCJAI, List<GBGGLBKJJPC> JHODFFNCLPD);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ONFGDKBJPCG PEMOMBPPCCI(GameObject FJOPJEJALAE, GameObject HDPBDLIPIGI);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ENPJDHABIPE(GameObject FJOPJEJALAE, List<GameObject> CKCDGJMFOHJ);

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LDMMDGGJCMG(GameObject HDPBDLIPIGI);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T HPGIIPJNIBL<T>(GameObject NALPHBPHOKI) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LMMJNKKAFFJ(Collider HNEMFCNMJHE);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject DNOFNHLFBBI<T>(string LAOCJKNALFF) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JANBMMOKEII(Collider HNEMFCNMJHE, [Out] GBGGLBKJJPC IJNCJOKBAFO);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NEFEAGIPPLC(GBGGLBKJJPC EAOPNGFGOCP, [Out] PEPMMAMONPM DCMCHDGNMMD);

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<HFJBDKKIEDE> HKJGKMKKDNG(Allocator CMJGNOOCEGA = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] AKJEDFLLBCP();
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ECEKGFJENJP
{
	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LAIHPFGHOIE(GBGGLBKJJPC EAOPNGFGOCP, GBGGLBKJJPC OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJOBPMGGNMC(GBGGLBKJJPC EAOPNGFGOCP, GBGGLBKJJPC OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int PIFKCJDMLGB(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GBGGLBKJJPC DKBHGBNCHJL(GBGGLBKJJPC EAOPNGFGOCP, int EMMACFPOKFB);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EDFFLPPIDFO GGJMEDHNADJ(GBGGLBKJJPC EAOPNGFGOCP, Allocator CMJGNOOCEGA = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NKMPLONJECG(GBGGLBKJJPC EAOPNGFGOCP, object HEDGIMBCGHA, GBGGLBKJJPC OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IGJKBIMNKBK(GBGGLBKJJPC EAOPNGFGOCP, object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JAOHHKLFHDN(GBGGLBKJJPC EAOPNGFGOCP, [Out] GBGGLBKJJPC OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OJOFEMHGFLE(GBGGLBKJJPC EAOPNGFGOCP, float3 OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MCKNNLPCKEP(GBGGLBKJJPC EAOPNGFGOCP, [Out] float3 OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AJONBEFOGDC(GBGGLBKJJPC EAOPNGFGOCP, float3 OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool JODHDEMMDIG(GBGGLBKJJPC EAOPNGFGOCP, [Out] float3 OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DBOFFBGFLKD(GBGGLBKJJPC EAOPNGFGOCP, (Quaternion rot, Vector3 moments) LKNPLOMJHIG);

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool PPGDLKLMABO(GBGGLBKJJPC EAOPNGFGOCP, [Out] quaternion LJJPEGCDGFJ, [Out] float3 IJEJODEGIPL);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LMJGEPHDDIN(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 JPIAJCOKFNL(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 DADJBEJGKKK(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JHKFKELGBAP(GBGGLBKJJPC EAOPNGFGOCP, float3 OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HFBJJFABFFO(GBGGLBKJJPC EAOPNGFGOCP, float3 OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float AFGLCDJEAOK(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float EAEJBGOCDIM(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BFCAIIJOJLF(GBGGLBKJJPC EAOPNGFGOCP, float OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BAJAHEMJCFM(GBGGLBKJJPC EAOPNGFGOCP, float OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode PAHNKHDIEKI(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IKJICAAEFGL(GBGGLBKJJPC EAOPNGFGOCP, CollisionDetectionMode OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "25")]
	FDCMEMEDMHG FBOLINIHMKM(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void APPFFKGCPJL(GBGGLBKJJPC EAOPNGFGOCP, FDCMEMEDMHG OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool BBDJNJAFBIA(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OHEFCNNDIOB(GBGGLBKJJPC EAOPNGFGOCP, bool OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(Slot = "29")]
	GBGGLBKJJPC CNCPPNJKLOG(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KDOLAHJBCDA(GBGGLBKJJPC EAOPNGFGOCP, GBGGLBKJJPC OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	GBGGLBKJJPC GPBMOMKFEAK(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void OAAMBAOIOOB(GBGGLBKJJPC EAOPNGFGOCP, GBGGLBKJJPC OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	GKDEPMMONOP JFJHADMOKJJ(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void JIGGKIPMMLE(GBGGLBKJJPC EAOPNGFGOCP, GKDEPMMONOP EOGPMCJGNGN);

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool PPOCFOHEBGB(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void FFLGKCKHICF(GBGGLBKJJPC EAOPNGFGOCP, bool OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool BICPDGFHOHI(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void ECDIGLEMIDL(GBGGLBKJJPC EAOPNGFGOCP, bool OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints DABCHJLMEDO(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void ELJKOBGCHGI(GBGGLBKJJPC EAOPNGFGOCP, RigidbodyConstraints OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float KDOGDEPNNPK(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void LCAPHIEGDDL(GBGGLBKJJPC EAOPNGFGOCP, float OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float IOAGOJLCKDB(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void AOMPDBDJDAK(GBGGLBKJJPC EAOPNGFGOCP, float OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool MHDHMIPKIJO(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void JBLKICHODIC(GBGGLBKJJPC EAOPNGFGOCP, bool OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool BEDBMNBJDAN(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void OHKLHBHOKHE(GBGGLBKJJPC EAOPNGFGOCP, bool OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void GCEIFBJDDMF(GBGGLBKJJPC EAOPNGFGOCP, int OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(Slot = "50")]
	LMAIOBGFFMJ DKCGKLMBAEG(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void KCDHBOGJBHH(GBGGLBKJJPC EAOPNGFGOCP, LMAIOBGFFMJ OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(Slot = "52")]
	JKCAKHJBMFN FKFGKIDEGLJ(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void NCHBOLCMBAK(GBGGLBKJJPC EAOPNGFGOCP, JKCAKHJBMFN OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float NHIOKAMPILC(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void DDPCAOGGEMI(GBGGLBKJJPC EAOPNGFGOCP, float OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void OCMOLPFBFGI(GBGGLBKJJPC EAOPNGFGOCP, object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void MFLAKNCMBMC(GBGGLBKJJPC EAOPNGFGOCP, object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool MHKEKLFJOLK(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void MGEMLFMOEGD(GBGGLBKJJPC EAOPNGFGOCP, object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void DLBMOEOKEFH(GBGGLBKJJPC EAOPNGFGOCP, object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool EIHNJLAICBO(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool DBECEEFLFLF(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody PJGHNDEDCHN(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void IFELCGKHIKA(GBGGLBKJJPC EAOPNGFGOCP, Rigidbody LCBHJGJGEAD);

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void GHMOAFKJOHK(GBGGLBKJJPC EAOPNGFGOCP, object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void CFBDGKKPEKB(GBGGLBKJJPC EAOPNGFGOCP, object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool PFIHNONBOFL(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void OAIEOMJDMKD(GBGGLBKJJPC EAOPNGFGOCP, float3 PLOBHHEKGDJ);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void JEKBKCHBIHC(GBGGLBKJJPC EAOPNGFGOCP, float3 NOBIPBDPLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool GHELGAMJIIP(GBGGLBKJJPC EAOPNGFGOCP, [Out] float3 PLOBHHEKGDJ);

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool PGCIKFBOBBG(GBGGLBKJJPC EAOPNGFGOCP, [Out] float3 NOBIPBDPLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool HMCGEPBNCCF(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void LCPLMCHFLPH(GBGGLBKJJPC EAOPNGFGOCP, object HEDGIMBCGHA, bool CBMPLHDBDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void ICIIMFIMLGO(GBGGLBKJJPC EAOPNGFGOCP, bool HJPLEOKHBAG);

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void PELLDHCKENG(GBGGLBKJJPC EAOPNGFGOCP);

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool IGBFGDLLODF(GBGGLBKJJPC EAOPNGFGOCP);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KOEABLGPNPB
{
	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMACMMKKNPK(Entity MHLOCHIHBKF);

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJPPJEDAOGP(Entity MHLOCHIHBKF);

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCBICIDOOCC(Entity MHLOCHIHBKF);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NLAGGDIGIND
{
	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFJOKOEMDAI(GBGGLBKJJPC MDKAAPLMLKG, bool LPGGHPEPEIL);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public delegate void JJFJDCANOGD(AJCCKAAIBMG FEGIGELCECP);
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public readonly ref struct AJCCKAAIBMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly EDFFLPPIDFO JDLCLEMAEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly NativeArray<byte> DMHGCKEGLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly NativeArray<byte> PIFBFMMDFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly LECBLDAKGLK NMCGBFDKCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly int PJPJLIACPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly Type MMBLNNOBCPE;

	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	public EDFFLPPIDFO NEKIAFIAPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x4710BE0", Offset = "0x470F7E0", VA = "0x184710BE0")]
		get
		{
			return default(EDFFLPPIDFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	public int COFHLHAAMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x7F8FBD0", Offset = "0x7F8E7D0", VA = "0x187F8FBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001EC")]
	public LECBLDAKGLK FFIINAPJLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xA3B560", Offset = "0xA3A160", VA = "0x180A3B560")]
		get
		{
			return default(LECBLDAKGLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FC20", Offset = "0x7F8E820", VA = "0x187F8FC20")]
	public AJCCKAAIBMG(EDFFLPPIDFO JDLCLEMAEDM, NativeArray<byte> DMHGCKEGLMH, NativeArray<byte> PIFBFMMDFPF, LECBLDAKGLK NMCGBFDKCMK, int PJPJLIACPLP, Type MMBLNNOBCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x3045D10", Offset = "0x3044910", VA = "0x183045D10")]
	public NativeArray<T> FMPCALHIEEB<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x3045E40", Offset = "0x3044A40", VA = "0x183045E40")]
	public NativeArray<T> OBNBLBFLJMO<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x3045D50", Offset = "0x3044950", VA = "0x183045D50")]
	public (EDFFLPPIDFO, NativeArray<T>, NativeArray<T>) LBDBFELEJGA<T>() where T : struct
	{
		return default((EDFFLPPIDFO, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FBF0", Offset = "0x7F8E7F0", VA = "0x187F8FBF0")]
	public PLGDEPDOHJO NHCNJENPEDP()
	{
		return default(PLGDEPDOHJO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public interface GLDBECJOKMP
{
	[Cpp2IlInjected.Token(Token = "0x170001ED")]
	string JCPIPMHGBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EE")]
	GLDBECJOKMP HLCICLLGJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EF")]
	IEnumerable<GLDBECJOKMP> HCBIJDAPFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface AACOEHMNKAI
{
	[Cpp2IlInjected.Token(Token = "0x170001F0")]
	GLDBECJOKMP FEFNCGGMEEC
	{
		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F1")]
	NativeArray<LECBLDAKGLK> LMGICCIBJLH
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MHPFCHFFMKN(LECBLDAKGLK NMCGBFDKCMK, [Out] GLDBECJOKMP KAEEKMHMHPB);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KHPGHNAFBFC(LECBLDAKGLK NMCGBFDKCMK, JJFJDCANOGD EJLLJKGOAMM);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BFGPHHDGACD(LECBLDAKGLK NMCGBFDKCMK, JJFJDCANOGD EJLLJKGOAMM);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KMBJEGLJKKF
{
	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHPGHNAFBFC(LECBLDAKGLK NMCGBFDKCMK, JJFJDCANOGD EJLLJKGOAMM);

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFGPHHDGACD(LECBLDAKGLK NMCGBFDKCMK, JJFJDCANOGD EJLLJKGOAMM);
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public static class AEIJFNHKLCL
{
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LANCAEOKFKH
{
	[Cpp2IlInjected.Token(Token = "0x170001F2")]
	bool KAIHBEFPGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F3")]
	EJGPCIHOALI EFNADAPBDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FCNIBDDNCHA(LJNJPJOGIHD OAJMKPFMDHN, bool ODCEKNMFIDF);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NDPEPICICJG(PLLPLODJPBF OAJMKPFMDHN, LECBLDAKGLK NMCGBFDKCMK);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FDHLCPPHFDP(NativeArray<PLLPLODJPBF> AMFCLKIFJEC);
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class BLMJELPCJNE
{
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public readonly ref struct PLGDEPDOHJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly AJCCKAAIBMG PEDMEJIDLNB;

	[Cpp2IlInjected.Token(Token = "0x170001F4")]
	public EDFFLPPIDFO NEKIAFIAPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x4710BE0", Offset = "0x470F7E0", VA = "0x184710BE0")]
		get
		{
			return default(EDFFLPPIDFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7520", Offset = "0x7FA6120", VA = "0x187FA7520")]
	public PLGDEPDOHJO(AJCCKAAIBMG PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6FD0", Offset = "0x7FA5BD0", VA = "0x187FA6FD0")]
	public EDFFLPPIDFO FMPCALHIEEB()
	{
		return default(EDFFLPPIDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA73F0", Offset = "0x7FA5FF0", VA = "0x187FA73F0")]
	public EDFFLPPIDFO OBNBLBFLJMO()
	{
		return default(EDFFLPPIDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7100", Offset = "0x7FA5D00", VA = "0x187FA7100")]
	public (EDFFLPPIDFO, EDFFLPPIDFO, EDFFLPPIDFO) LBDBFELEJGA()
	{
		return default((EDFFLPPIDFO, EDFFLPPIDFO, EDFFLPPIDFO));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public static class MACKKOMLJON
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly struct EJGPCIHOALI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly NativeBitArray PEPELIPAHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly NativeParallelHashMap<PLLPLODJPBF, int> DAJMJKKAIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly NativeParallelHashSet<LJNJPJOGIHD> KIBJLHEOGGG;

	[Cpp2IlInjected.Token(Token = "0x170001F5")]
	public bool DGABBGEFKOD
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x7F934E0", Offset = "0x7F920E0", VA = "0x187F934E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F6")]
	public bool KAIHBEFPGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x7F93500", Offset = "0x7F92100", VA = "0x187F93500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE3E0", Offset = "0x5DBCFE0", VA = "0x185DBE3E0")]
	public EJGPCIHOALI(NativeBitArray PEPELIPAHMI, NativeParallelHashMap<PLLPLODJPBF, int> DAJMJKKAIFJ, NativeParallelHashSet<LJNJPJOGIHD> KIBJLHEOGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x7F93530", Offset = "0x7F92130", VA = "0x187F93530")]
	public bool NDPEPICICJG(PLLPLODJPBF OAJMKPFMDHN, LECBLDAKGLK NMCGBFDKCMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NAPFPJCKNHK
{
	[Cpp2IlInjected.Token(Token = "0x170001F7")]
	AGAICHLALAG CBDHGEKHJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PCCJKEOOMPO
{
	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DDHHIBCGBPC(GBGGLBKJJPC EAOPNGFGOCP, NPPLDKJABIP OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EEHGLNGJALI IIMONHHEPBJ();
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GJPDHMLGPKL
{
	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGMPBLENANE(World CJNNELLKJGB);

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DILKGCOCDPK(World CJNNELLKJGB);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase HDONDECGHEM(World CJNNELLKJGB);

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HDANGDEFAOF(World CJNNELLKJGB);

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DFMNNLAFLAO(World CJNNELLKJGB);

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GMAKGOJBEIM(World CJNNELLKJGB);

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CFDEFPBNJEK(World CJNNELLKJGB);

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> LGGGCGHNBKH();
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IGJPLOFHPFK
{
	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FDNFLBLHAAG(GBGGLBKJJPC AEIJGHPBELE, bool OOHGFGHCOAJ);
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public readonly struct JFKACMOKEAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly IEnumerable<HFHADPNNPJI> MEDKCOHHKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly IReadOnlyList<GameObject> DDFMNHKAENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly IReadOnlyList<int> HDEOLHMJJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly IReadOnlyList<(PLLPLODJPBF, PLLPLODJPBF)> KJBDFKFNFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly int MHFDDJLNHLD;
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public struct BOMLCKNDALF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public InventionIdData ALPNKEJICNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public InventionInstanceIdData NOIFDPBHJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public bool CNEOFHHMJIG;

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FE40", Offset = "0x7F8EA40", VA = "0x187F8FE40")]
	public BOMLCKNDALF(long ALPNKEJICNA, Guid NOIFDPBHJJB, bool CNEOFHHMJIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[ServiceLifetime(Lifetime.Application)]
public interface KDLGBKDKOGH
{
	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OBGNMNBMKOE LINPIKCPFAN(JIEEKEEBHCL FKPKEALHCCP, int GOPJGFBCOPL = 0, bool AAJBFMKNGND = false);

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NNKKLIHKNGN DNNPCKKIGNF(JIEEKEEBHCL FKPKEALHCCP, GBGGLBKJJPC LIPFJJEAFCE, [In] UniformTRS MEIHJLMEDKN, PJPDNOFBGFG EBFGALPEOHI, [Optional] BOMLCKNDALF AEIPJPGFNBM, bool LNDAOGKCLDC = true, bool HCMBIHCDOIO = false, bool AAJBFMKNGND = false, bool OHDDGMHNAON = false);

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AOBKKFOCJOG LFCHKHBMIAJ();

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AOBKKFOCJOG DJCOKJBOKFK(EDFFLPPIDFO HKCBJNOPFKH, [In] UniformTRS INHLNHJCAKJ, [Optional] PJPDNOFBGFG IFHOKKGGHAE);

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NICJHJJJBHH(GBGGLBKJJPC PELNNGKCLFG);

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FEODGKGEEHE(GBGGLBKJJPC PELNNGKCLFG, [Out] Exception OBGCCKHNEKJ);

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<PLLPLODJPBF> NEGLAAHGKCH(GBGGLBKJJPC PELNNGKCLFG, Allocator CMJGNOOCEGA);

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<PLLPLODJPBF> OKPNHIFNCNF(GBGGLBKJJPC PELNNGKCLFG, Allocator CMJGNOOCEGA);

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EDFFLPPIDFO GDMCEJPKLIM(GBGGLBKJJPC PELNNGKCLFG, Allocator CMJGNOOCEGA);

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EDFFLPPIDFO OEFCGIFEKLO(GBGGLBKJJPC PELNNGKCLFG, Allocator CMJGNOOCEGA);

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EDFFLPPIDFO NENJJOHBOPA(GBGGLBKJJPC PELNNGKCLFG, Allocator CMJGNOOCEGA);

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> HJFDEJAHAEL(GBGGLBKJJPC PELNNGKCLFG, Allocator CMJGNOOCEGA);

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool AIEMLFIBAJF(GBGGLBKJJPC PELNNGKCLFG);

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int CFAGIOPHNAA(GBGGLBKJJPC PELNNGKCLFG, int DPOOEAFKIHD);
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[ServiceLifetime(Lifetime.Application)]
public interface NEFBGKDCGAO
{
	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0xEA3280", Offset = "0xEA1E80", VA = "0x180EA3280", Slot = "0")]
	bool NEHHPOOOFJA(object AGFKEDPOHKE, GFAMPFOJDDN PLMACNLDEMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public static class NHCPCHKOKFP
{
	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1F00", Offset = "0x7FA0B00", VA = "0x187FA1F00")]
	public static bool NEHHPOOOFJA(this NEFBGKDCGAO CHLLPCJOLAE, object AGFKEDPOHKE, [Out] GFAMPFOJDDN PLMACNLDEMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public enum FNNHJNADHKF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	MaxPlayers = byte.MaxValue,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	IsVisible = 254,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	IsOpen = 253,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	PlayerCount = 252,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Removed = 251,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	PropsListedInLobby = 250,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	CleanupCacheOnLeave = 249,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	MasterClientId = 248,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	ExpectedUsers = 247,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	PlayerTtl = 246,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	EmptyRoomTtl = 245,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	HasDedicatedMaster = 87
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface GFAMPFOJDDN
{
	[Cpp2IlInjected.Token(Token = "0x170001F8")]
	LPHCCGFOIIK JKOHHHGJLLP
	{
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	LDINANBBIGL JNDMEOBIFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	bool NGKGPJIBBNA
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	bool GHDHLPIDEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object AJDLHDJFJOL();

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "5")]
	(LDINANBBIGL, Dictionary<object, object>) LKBCBHKFAKK()
	{
		return default((LDINANBBIGL, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "6")]
	(PLLPLODJPBF, LDINANBBIGL) IDJGFAHHCCI()
	{
		return default((PLLPLODJPBF, LDINANBBIGL));
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "7")]
	KDBMEGHDADG<(PLLPLODJPBF, LDINANBBIGL)> DOBEEPEJJBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "8")]
	(FAPEBMBEKBP, byte[]) IECALGINACK()
	{
		return default((FAPEBMBEKBP, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "9")]
	(NHKBALJGDFM, byte[]) OMEDENNCKIO()
	{
		return default((NHKBALJGDFM, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0xFE7DC0", Offset = "0xFE69C0", VA = "0x180FE7DC0", Slot = "10")]
	T LJPPGOCEOMC<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public static class NCPHHIBDIDL
{
	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1D30", Offset = "0x7FA0930", VA = "0x187FA1D30")]
	public static bool MEHJLNPMLJK(this GFAMPFOJDDN KHKBFEMNDEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface NPMFCIFAJIH : KDBMEGHDADG<JADGOGMAGBG>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[DefaultMember("Item")]
public interface KDBMEGHDADG<T>
{
	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	T HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	int COFHLHAAMAM
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public enum LPHCCGFOIIK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	BulkInstantiate = 1,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	BulkDestroy = 2,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	OMSendPacket = 4,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RR_OutOfBandMessage = 5,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	RR_FastForwardMarker = 6,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	RR_SelfJoinMarker = 7,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	RR_DebugOp = 10,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	RR_CachedEvent = 11,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RRRoomRequestEvent = 20,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	RRRoomRequestFailedResponseEvent = 21,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	RRBufferedRoomEvent = 22,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	RRClearBufferedRoomEvent = 23,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	RR_CreationOp = 24,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	RR_CreationOpResponse = 25,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	RR_CreationOp_Unchecked = 26,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RR_MasterLockBlockComplete = 27,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	RR_NetworkSynchronization = 28,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	RR_NetworkInstantiate = 29,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	RR_BulkInstantiate = 31,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	RR_Destroy = 32,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	RR_BulkDestroy = 33,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RR_TransferOwnership = 34,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	RR_OwnershipUpdate = 35,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	RR_RPC = 36,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	RR_JoinRequest = 100,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	RR_JoinResponse = 101,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	RR_RoomUpdate = 102,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	RR_PlayerUpdate = 103,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	RR_RemotePlayerJoined = 104,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	RR_RemotePlayerLeft = 105,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	RR_Leave = 106,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	RPC = 200,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	SendSerialize = 201,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	Instantiation = 202,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	CloseConnection = 203,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Destroy = 204,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	RemoveCachedRPCs = 205,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	SendSerializeReliable = 206,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	DestroyPlayer = 207,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	OwnershipRequest = 209,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	OwnershipTransfer = 210,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	VacantViewIds = 211,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	OwnershipUpdate = 212,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	AuthEvent = 223,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	LobbyStats = 224,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	AppStats = 226,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	Match = 227,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	QueueState = 228,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	GameListUpdate = 229,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	GameList = 230,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	CacheSliceChanged = 250,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	ErrorInfo = 251,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	PropertiesChanged = 253,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Leave = 254,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Join = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public enum FAPEBMBEKBP : uint
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	None = 0u,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	NetworkTransformInitializationData = 1314146628u,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	RestoreCreationData = 1380140064u,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	OldestCachedPacketId = 1329811529u,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	SnapshotPublished = 1397773634u,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	SnapshotPayload = 1397771332u,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	SnapshotClear = 1129337683u
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class FCGHMCPOANF
{
	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x7F940D0", Offset = "0x7F92CD0", VA = "0x187F940D0")]
	public static PLLPLODJPBF PLECBMGPACE(this ILEEHEAKPIA PEDMEJIDLNB)
	{
		return default(PLLPLODJPBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F94080", Offset = "0x7F92C80", VA = "0x187F94080")]
	public static PLLPLODJPBF KKCCHMAGNNL([In] this ILEEHEAKPIA PEDMEJIDLNB)
	{
		return default(PLLPLODJPBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x7F1DC70", Offset = "0x7F1C870", VA = "0x187F1DC70")]
	public static PLLPLODJPBF BLDLKDPDEIE(this ILEEHEAKPIA PEDMEJIDLNB)
	{
		return default(PLLPLODJPBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F1DC70", Offset = "0x7F1C870", VA = "0x187F1DC70")]
	public static ViewId EFHHLPHJBNG(this ILEEHEAKPIA PEDMEJIDLNB)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F93E20", Offset = "0x7F92A20", VA = "0x187F93E20")]
	public static FixedString64Bytes GBILLNGNCHP(this LJNJPJOGIHD ALPNKEJICNA)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x7F93B90", Offset = "0x7F92790", VA = "0x187F93B90")]
	public static FixedString64Bytes DOCOEKNMNOM(this PLLPLODJPBF ALPNKEJICNA)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F93FF0", Offset = "0x7F92BF0", VA = "0x187F93FF0")]
	public static FixedString32Bytes GBILLNGNCHP(this Entity JMNEAPNCNHN)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AGEADCLGAKO : NNPEOCDJHNF
{
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public enum DNIABJJCHIG
{
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NBMAOHPKHLN
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<object> NMMGPPBPIID;

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "2")]
	void DLOJKJIOKCA(object AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "3")]
	void EOAHPNKFHPN(NHKBALJGDFM GBEGHJIHKEG, ReadOnlySpan<byte> ADKJHPADFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
	void PLDJFFBFCKM(FAPEBMBEKBP OPOPAMPKKGD, ReadOnlySpan<byte> ADKJHPADFOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LFAKBFBINJD
{
	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHKBALJGDFM BKOLGEBNCHF(ReadOnlySpan<byte> ADKJHPADFOA);
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GADEOCLHIDI
{
	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKNEGJEDMCG(NHKBALJGDFM MEPFFFGIFGB, ReadOnlySpan<byte> ADKJHPADFOA);

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IOCCOJCHALH(ReadOnlySpan<NHKBALJGDFM> FGFGDCHOMOK);
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public struct ODGBFHBLIJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public NHKBALJGDFM GBEGHJIHKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public ReadOnlyMemory<byte> ADKJHPADFOA;
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public struct NHKBALJGDFM
{
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static NHKBALJGDFM OPPBEBFJIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public LJNJPJOGIHD MPFBANPBMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public int PMEBHIPHDKB;

	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	public static LJNJPJOGIHD DCFALMGAIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1FF0", Offset = "0x7FA0BF0", VA = "0x187FA1FF0")]
		get
		{
			return default(LJNJPJOGIHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x5274050", Offset = "0x5272C50", VA = "0x185274050")]
	public NHKBALJGDFM(LJNJPJOGIHD MPFBANPBMKI, int PMEBHIPHDKB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x7FA21A0", Offset = "0x7FA0DA0", VA = "0x187FA21A0")]
	public static bool JOHLOKGLNML([In] NHKBALJGDFM HLPEBKMLKLE, [In] NHKBALJGDFM MAELALMKOEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x7FA2040", Offset = "0x7FA0C40", VA = "0x187FA2040", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x7FA2140", Offset = "0x7FA0D40", VA = "0x187FA2140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x7FA2230", Offset = "0x7FA0E30", VA = "0x187FA2230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1FE0", Offset = "0x7FA0BE0", VA = "0x187FA1FE0")]
	public void AMHBPBGIPFF([Out] LJNJPJOGIHD KPGHEBOCEPO, [Out] int PMEBHIPHDKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public static class MKMMIMIHDBO
{
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public struct HFHADPNNPJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public Guid LHECJJHBNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public string KJKNEFAFPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public Vector3 IIBJECFMAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public Quaternion BFEELDCLMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public Vector3 LHHOCCKJGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public int HGIBOHNJJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public ILDPOIGDHNO GALEDNLDGCG;

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x7F98210", Offset = "0x7F96E10", VA = "0x187F98210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public enum BAOAOPFCABB
{
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class KKCAAOKPDGL
{
	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C1F0", Offset = "0x7F9ADF0", VA = "0x187F9C1F0")]
	public static bool DKCCAFIANLK(this BAOAOPFCABB OPOPAMPKKGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C220", Offset = "0x7F9AE20", VA = "0x187F9C220")]
	public static bool NKBHNGEPNMH(this BAOAOPFCABB OPOPAMPKKGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C210", Offset = "0x7F9AE10", VA = "0x187F9C210")]
	public static bool GDBEJOKIKKI(this BAOAOPFCABB OPOPAMPKKGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
[Flags]
public enum LDOFKPFBECJ
{
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface PJPDNOFBGFG
{
	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BBPJLKHEHNJ([In] Guid ENEAIMANIIG, [Out] Guid JAKICABDOHC);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
[Flags]
public enum NFBMFFIFFHD
{
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface AOBKKFOCJOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	DDHFEHEHOPP JFFCJKMHHIO
	{
		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString FIFENDLLBAA();
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public enum BLAPGDECGBB
{
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct MKJLEEIOJMH : ISystemStateComponentData, IComponentData, IEquatable<MKJLEEIOJMH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public float3 MKJDLLMDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public float3 DACOOMLDGBC;

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x7FA15E0", Offset = "0x7FA01E0", VA = "0x187FA15E0", Slot = "4")]
	public bool Equals(MKJLEEIOJMH GMNGNCHKEBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface COEGIEAFHBM
{
	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<GBGGLBKJJPC> DGFAMKINPGE(GBGGLBKJJPC LHMLMAPKPBE);
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ENFLJIMFKKE
{
	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HKFEFGHECEG(long CJCDDDPLOLA);

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPKBFHJLHBJ(NativeParallelHashSet<long> JGJIMGAPAHA);

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DHAICLHABII(World CJNNELLKJGB, NativeParallelHashMap<Guid, long> ILCPGOCMOEK);

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IHFPDGEHGKA(PLLPLODJPBF OAJMKPFMDHN);

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MHBFPLIKEEL(PLLPLODJPBF OAJMKPFMDHN, [Out] Guid ALEJJCDJJAP, [Out] long CJCDDDPLOLA);

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GFLCKMKHEME(PLLPLODJPBF OAJMKPFMDHN, Guid ALEJJCDJJAP, long CJCDDDPLOLA);

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FIIPFAPBHMA(Guid ALEJJCDJJAP);

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool IDEHDPHPBAG(Guid ALEJJCDJJAP, [Out] int AOHGJMOLCMM, [Out] int FCNBKAMFCNF);

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void COBCMEHDKGK(Guid ALEJJCDJJAP, int AOHGJMOLCMM, int FCNBKAMFCNF);

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CPEENNKCNKL(Guid ALEJJCDJJAP);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000100")]
public class GCLFJLNKBGD
{
	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public GCLFJLNKBGD()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
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
