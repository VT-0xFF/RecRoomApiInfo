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
	public class LogRegistrationIndex : NNAGAKKCAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6AD62F0", Offset = "0x6AD4EF0", VA = "0x186AD62F0", Slot = "4")]
		public override void NGMFPPEDCJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OHLEBIGBKHI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCA00", Offset = "0x6ADB600", VA = "0x186ADCA00")]
	public static void CIGJCBODMIJ(this Rigidbody NCKHCJDOKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC8D0", Offset = "0x6ADB4D0", VA = "0x186ADC8D0")]
	public static void CIGJCBODMIJ(this Rigidbody NCKHCJDOKCD, Vector3 MMDNFFEENED, Quaternion IPIMGOCDKPL, Vector3 ALJMGCBFJAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct KPCKLPGBLFP : IReadOnlyList<PEAFMKHEGLL>, IEnumerable<PEAFMKHEGLL>, IEnumerable, IReadOnlyCollection<PEAFMKHEGLL>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct AHCAJJKMONE : IEnumerator<PEAFMKHEGLL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly MILLCJNFGCE DIDDAJAOOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator CHFIEPEFDPA;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PEAFMKHEGLL KENACMDPOBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6ACCB40", Offset = "0x6ACB740", VA = "0x186ACCB40", Slot = "4")]
			get
			{
				return default(PEAFMKHEGLL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6ACCAC0", Offset = "0x6ACB6C0", VA = "0x186ACCAC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x423E700", Offset = "0x423D300", VA = "0x18423E700")]
		public AHCAJJKMONE(MILLCJNFGCE DIDDAJAOOPG, NativeArray<LocalId>.Enumerator CHFIEPEFDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCA00", Offset = "0x6ACB600", VA = "0x186ACCA00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCA40", Offset = "0x6ACB640", VA = "0x186ACCA40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCA80", Offset = "0x6ACB680", VA = "0x186ACCA80", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly MILLCJNFGCE DIDDAJAOOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> BDDJKPADFHM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public PEAFMKHEGLL PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4230", Offset = "0x6AD2E30", VA = "0x186AD4230", Slot = "4")]
		get
		{
			return default(PEAFMKHEGLL);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3D50", Offset = "0x6AD2950", VA = "0x186AD3D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int GIGHOFCCBCD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x863DA0", VA = "0x1808651A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int IEIDDKENJGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x863DA0", VA = "0x1808651A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LFJOKDMJBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3B90", Offset = "0x6AD2790", VA = "0x186AD3B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> MHBIHCICEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2566380", Offset = "0x2564F80", VA = "0x182566380")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> OLOOIADKCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3DA0", Offset = "0x6AD29A0", VA = "0x186AD3DA0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6AD41A0", Offset = "0x6AD2DA0", VA = "0x186AD41A0")]
	public KPCKLPGBLFP(int DFJDDCJIBIA, MILLCJNFGCE DIDDAJAOOPG, Allocator MJBDBDLLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x423E140", Offset = "0x423CD40", VA = "0x18423E140")]
	public KPCKLPGBLFP(MILLCJNFGCE DIDDAJAOOPG, NativeArray<LocalId> BDDJKPADFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3FE0", Offset = "0x6AD2BE0", VA = "0x186AD3FE0")]
	internal KPCKLPGBLFP(MILLCJNFGCE DIDDAJAOOPG, NativeArray<Entity> PBGFKAHLPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4100", Offset = "0x6AD2D00", VA = "0x186AD4100")]
	public KPCKLPGBLFP(MILLCJNFGCE DIDDAJAOOPG, int AEGGIAICNFC, Allocator MJBDBDLLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4050", Offset = "0x6AD2C50", VA = "0x186AD4050")]
	public KPCKLPGBLFP(KPCKLPGBLFP JFBCMLGCKAJ, Allocator MJBDBDLLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3CA0", Offset = "0x6AD28A0", VA = "0x186AD3CA0")]
	public KPCKLPGBLFP FEPLHPFJIDG(Allocator MJBDBDLLDBK = Allocator.Temp)
	{
		return default(KPCKLPGBLFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3C60", Offset = "0x6AD2860", VA = "0x186AD3C60", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3BD0", Offset = "0x6AD27D0", VA = "0x186AD3BD0")]
	public AHCAJJKMONE DHNABIACCII()
	{
		return default(AHCAJJKMONE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3E00", Offset = "0x6AD2A00", VA = "0x186AD3E00", Slot = "6")]
	private IEnumerator<PEAFMKHEGLL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3EF0", Offset = "0x6AD2AF0", VA = "0x186AD3EF0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct NHOLEINKLHA : IList<PEAFMKHEGLL>, ICollection<PEAFMKHEGLL>, IEnumerable<PEAFMKHEGLL>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct DKINFDBLIKG : IEnumerator<PEAFMKHEGLL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly MILLCJNFGCE DIDDAJAOOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator CHFIEPEFDPA;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public PEAFMKHEGLL KENACMDPOBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0A90", Offset = "0x6ACF690", VA = "0x186AD0A90", Slot = "4")]
			get
			{
				return default(PEAFMKHEGLL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0A10", Offset = "0x6ACF610", VA = "0x186AD0A10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x423E700", Offset = "0x423D300", VA = "0x18423E700")]
		public DKINFDBLIKG(MILLCJNFGCE DIDDAJAOOPG, NativeArray<LocalId>.Enumerator CHFIEPEFDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0950", Offset = "0x6ACF550", VA = "0x186AD0950", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0990", Offset = "0x6ACF590", VA = "0x186AD0990", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6AD09D0", Offset = "0x6ACF5D0", VA = "0x186AD09D0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MILLCJNFGCE DIDDAJAOOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> BDDJKPADFHM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PEAFMKHEGLL PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB710", Offset = "0x6ADA310", VA = "0x186ADB710", Slot = "4")]
		get
		{
			return default(PEAFMKHEGLL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB790", Offset = "0x6ADA390", VA = "0x186ADB790", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB230", Offset = "0x6AD9E30", VA = "0x186ADB230", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int IEIDDKENJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB230", Offset = "0x6AD9E30", VA = "0x186ADB230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool JGMKIDPCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB570", Offset = "0x6ADA170", VA = "0x186ADB570")]
	public NHOLEINKLHA(int DFJDDCJIBIA, MILLCJNFGCE DIDDAJAOOPG, Allocator MJBDBDLLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB690", Offset = "0x6ADA290", VA = "0x186ADB690")]
	public NHOLEINKLHA(MILLCJNFGCE DIDDAJAOOPG, Allocator MJBDBDLLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB600", Offset = "0x6ADA200", VA = "0x186ADB600")]
	public NHOLEINKLHA(MILLCJNFGCE DIDDAJAOOPG, int AEGGIAICNFC, Allocator MJBDBDLLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB1B0", Offset = "0x6AD9DB0", VA = "0x186ADB1B0")]
	public KPCKLPGBLFP PBGIBFOIDFI()
	{
		return default(KPCKLPGBLFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAD80", Offset = "0x6AD9980", VA = "0x186ADAD80", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6ADADC0", Offset = "0x6AD99C0", VA = "0x186ADADC0", Slot = "13")]
	public bool Contains(PEAFMKHEGLL NLEFMACAEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAE50", Offset = "0x6AD9A50", VA = "0x186ADAE50", Slot = "14")]
	public void CopyTo(PEAFMKHEGLL[] DKCMKELIAPN, int ELEIFPFNELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAD00", Offset = "0x6AD9900", VA = "0x186ADAD00", Slot = "11")]
	public void Add(PEAFMKHEGLL NLEFMACAEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB100", Offset = "0x6AD9D00", VA = "0x186ADB100", Slot = "7")]
	public void Insert(int BAEBMIBABAE, PEAFMKHEGLL NLEFMACAEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB2C0", Offset = "0x6AD9EC0", VA = "0x186ADB2C0", Slot = "15")]
	public bool Remove(PEAFMKHEGLL NLEFMACAEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB070", Offset = "0x6AD9C70", VA = "0x186ADB070", Slot = "6")]
	public int IndexOf(PEAFMKHEGLL NLEFMACAEAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB270", Offset = "0x6AD9E70", VA = "0x186ADB270", Slot = "8")]
	public void RemoveAt(int BAEBMIBABAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB030", Offset = "0x6AD9C30", VA = "0x186ADB030", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAFA0", Offset = "0x6AD9BA0", VA = "0x186ADAFA0")]
	public DKINFDBLIKG DHNABIACCII()
	{
		return default(DKINFDBLIKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB390", Offset = "0x6AD9F90", VA = "0x186ADB390", Slot = "16")]
	private IEnumerator<PEAFMKHEGLL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB480", Offset = "0x6ADA080", VA = "0x186ADB480", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MDAEPJINHKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int DKNDJJIOCAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> JIADIDJOGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PEAFMKHEGLL DDLLDICCNIG(PEAFMKHEGLL BDDJKPADFHM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JIKILIEFMFO : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface FLPGBOCMGLL : ECBDCOLJPJM, DBENOAJDGJG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool DLCDMGIPGPC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	JHMHANBPADG GDABKMFFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	HGNKEMIOJCN NCAIOCAOMLC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	DLGLCBKLECI BLCFABFNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	LBEOGCNNDJK BJPOMKMBCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface DBENOAJDGJG
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool FOKNBPHHGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface PFOEBGFLCEH
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCMHFIONHKO(bool IIPLJLPCLBC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[KHCGLFKHKLK(MNBOKCFMODA.PhotonRoom)]
public interface PCLPJAAJKCM
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool HIPLOPIKFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPPPEEDOGOF(bool NODMMGDBLME);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGONENEHPMF();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ACNOJACIOON(ByteString HNJEGMGEKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LEEFAJDICFP();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MKNGLHNDFMN();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LLJKMIMGMPC();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NJKNMDELKAD();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PJPMBIHFMKN();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface DLGLCBKLECI
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	IELNGKFCIIK GDABKMFFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	HGNKEMIOJCN NCAIOCAOMLC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	FHOGNAOGBDD ADFIKCDPCMK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	CLLGFAIMGIL OGNDENMDNOO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	FLPGBOCMGLL ANKPJAEMNMF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	PCLPJAAJKCM IFPONHBPPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	CMCFFEGLMCA ELABCBFKGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	JPACDLKDDPO JEJGIDPGGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	FKCONCNGCPO DIPLANCLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	OCPLLHNHGPO NALFGIGDBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	EBCJHBEGMEO GCKINBOICDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	LFKHPEFHEAF EBKBLCJEAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	KDCLDLEDKND AGHBEPIBPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	APBMEOLDFNM AJKHHOGDGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	OAAHNCPHMEA PAFNGOMCPCN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	FCDEJMGHBDB JOJDHCBBBMK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	DJIKGLGNKNN IOEMODDFGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	OAIJMCPCDPL BPIGPIOKAIP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	CJCGPBOHHJH LAGLBLLJKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	MEMBPKACKGM PDFACNJCLAL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	CCKGCFEENAF PKFCGJBCDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	GHOBGKJAONH ABGBCBPFGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	HOMJBKNNEAD GDODJPMKALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	MFGDJEOJOAM GCDBGEFDEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	IJDOGAIGDNJ PCJFBIOMGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	JGDJNNLNPOO BDKFHCGMEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	DGMJOGCAKKG MCFOIODCLBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	NPIAAMNJJPL DICCGADMCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(HJNEJACCJHD))]
public readonly struct PEAFMKHEGLL : IComparable<PEAFMKHEGLL>, IEquatable<PEAFMKHEGLL>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly PEAFMKHEGLL IAEFNBLMFND;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int LFHFNLPBLIO = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int FBNCFMMIHOM = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int DCJPOJLLBLD = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int EIHOPAJJEKF = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId IDIEOFKIGBL;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public FLPGBOCMGLL ANKPJAEMNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE960", Offset = "0x6ADD560", VA = "0x186ADE960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public LocalId BCFGCDBOMFD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEC50", Offset = "0x6ADD850", VA = "0x186ADEC50")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal LBEOGCNNDJK BJPOMKMBCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEC40", Offset = "0x6ADD840", VA = "0x186ADEC40")]
		get
		{
			return default(LBEOGCNNDJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool BCICDOOEJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEC90", Offset = "0x6ADD890", VA = "0x186ADEC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool PLPPNHFMJNA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEEF0", Offset = "0x6ADDAF0", VA = "0x186ADEEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF070", Offset = "0x6ADDC70", VA = "0x186ADF070")]
	public PEAFMKHEGLL(MILLCJNFGCE CDIFAELGFOM, LocalId IDIEOFKIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
	public KNGFJCECCLB MNOHDHFCOFI()
	{
		return default(KNGFJCECCLB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE920", Offset = "0x6ADD520", VA = "0x186ADE920")]
	public static LocalId ANHILFPCAJJ(PEAFMKHEGLL PBJHALNOGKB)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE8E0", Offset = "0x6ADD4E0", VA = "0x186ADE8E0")]
	public static Entity ANHILFPCAJJ(PEAFMKHEGLL PBJHALNOGKB)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEDD0", Offset = "0x6ADD9D0", VA = "0x186ADEDD0")]
	public static bool IGDKJEPDLHP(PEAFMKHEGLL PFJBMEMCGDE, PEAFMKHEGLL GCHHKKAJBGE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3910", Offset = "0x6AD2510", VA = "0x186AD3910")]
	public static bool OAODAFKFIOO(PEAFMKHEGLL PFJBMEMCGDE, PEAFMKHEGLL GCHHKKAJBGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEF40", Offset = "0x6ADDB40", VA = "0x186ADEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEAA0", Offset = "0x6ADD6A0", VA = "0x186ADEAA0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE9C0", Offset = "0x6ADD5C0", VA = "0x186ADE9C0", Slot = "4")]
	public int CompareTo(PEAFMKHEGLL HEIGABGMPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "5")]
	public bool Equals(PEAFMKHEGLL HEIGABGMPLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IIAHFGOKGLL
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1AA0", Offset = "0x6AD06A0", VA = "0x186AD1AA0")]
	public static FBKGLLHAOCB EFDKABLIFJF(this PEAFMKHEGLL APKAFMDACKK)
	{
		return default(FBKGLLHAOCB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1B50", Offset = "0x6AD0750", VA = "0x186AD1B50")]
	public static KNGFJCECCLB NFHGJFCGPHF(this PEAFMKHEGLL APKAFMDACKK)
	{
		return default(KNGFJCECCLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2B78790", Offset = "0x2B77390", VA = "0x182B78790")]
	public static T EGGILPACPBM<T>(this PEAFMKHEGLL APKAFMDACKK) where T : struct, IGMHMGEDMIG
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class HJNEJACCJHD
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct LBEOGCNNDJK : IEquatable<LBEOGCNNDJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte MJBLPCEDGPJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] OGFCEDKDAFA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static MILLCJNFGCE PKGFOJLEKHA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static FLPGBOCMGLL LACEFIHODJC;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static MILLCJNFGCE[] BKKHKIMLLDO;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static FLPGBOCMGLL[] BMNIDJKOPIC;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> ANMBJOMFGPH;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public FLPGBOCMGLL ANKPJAEMNMF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4D50", Offset = "0x6AD3950", VA = "0x186AD4D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public MILLCJNFGCE BPNAGLIGNIA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4EB0", Offset = "0x6AD3AB0", VA = "0x186AD4EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD58C0", Offset = "0x6AD44C0", VA = "0x186AD58C0")]
	static LBEOGCNNDJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x217CC00", Offset = "0x217B800", VA = "0x18217CC00")]
	internal LBEOGCNNDJK(byte IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5C37F00", Offset = "0x5C36B00", VA = "0x185C37F00", Slot = "4")]
	public bool Equals(LBEOGCNNDJK HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5100", Offset = "0x6AD3D00", VA = "0x186AD5100", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D7B190", Offset = "0x1D79D90", VA = "0x181D7B190", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5800", Offset = "0x6AD4400", VA = "0x186AD5800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5750", Offset = "0x6AD4350", VA = "0x186AD5750")]
	private static MILLCJNFGCE PIACMHMPHOB(byte MJBLPCEDGPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6AD53D0", Offset = "0x6AD3FD0", VA = "0x186AD53D0")]
	private static FLPGBOCMGLL MGBFGMEDHCG(byte MJBLPCEDGPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4F90", Offset = "0x6AD3B90", VA = "0x186AD4F90")]
	private static object DIFCGBFJMJF(byte MJBLPCEDGPJ, object[] COOBAOCKFHD, object APDNGABBFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6AD51A0", Offset = "0x6AD3DA0", VA = "0x186AD51A0")]
	private static int FDNJONABIDB(byte MJBLPCEDGPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5740", Offset = "0x6AD4340", VA = "0x186AD5740")]
	private static int PAIBFEHFPFK(byte MJBLPCEDGPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4E30", Offset = "0x6AD3A30", VA = "0x186AD4E30")]
	private static (int, int) CBFHBNNGCNN(byte MJBLPCEDGPJ)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD53C0", Offset = "0x6AD3FC0", VA = "0x186AD53C0")]
	private static byte KPFGKJEBNDB(int FAEMFOKJHDK, int BAEBMIBABAE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5480", Offset = "0x6AD4080", VA = "0x186AD5480")]
	internal static LBEOGCNNDJK NGMFPPEDCJG(FLPGBOCMGLL AIDCGLBEAPF, MILLCJNFGCE HANNIFBNJJP)
	{
		return default(LBEOGCNNDJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD51B0", Offset = "0x6AD3DB0", VA = "0x186AD51B0")]
	internal static void JCNGKHJCBAJ(LBEOGCNNDJK MJBLPCEDGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6AD49C0", Offset = "0x6AD35C0", VA = "0x186AD49C0")]
	private static void ACLLEHENKJG(int DFJDDCJIBIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface HCEFOPFLHAJ
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CICOENPMNNI();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGFLNDNDOAC(bool MIPOPLIIJBJ);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MNKNENGLNCB(GameObject OJCNPGOLEHK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface MGMCJKGEGCK
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Guid KMOMOALBIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BDFFBPFHNDC(Guid CJMGHKPDCFB, Guid DDPGCLLGMBN, Guid EJGFIJCNNPD);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Guid COGOMKAJMBD(Guid CJJOKEDEAPE);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task DGMPMGHHPMJ(PEAFMKHEGLL ANJNOEEBMAF);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PCKKIAPKICI(KOEOKJHJALF DMCCEONBCKA, Guid JOBPFKIMLPM);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BOOFCDGHFKB(Guid CJJOKEDEAPE, bool NODMMGDBLME);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface OMPPKOFCBHP
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCEKLEPBFNP(KPCKLPGBLFP BDDJKPADFHM);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface HEDKOJBBLJE
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ABGPOGIHAIO(GameObject AICALHFMKAH, GameObject FEJFGIAMCEH, int JKNCMIJCBON);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface HGNKEMIOJCN
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	HCEFOPFLHAJ LLIJFJPMCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	KFDKPCPEEMH MHOLAEJEBMG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	JHPFNEMIJJD PBJAPNLFBKA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	CPCAGNMNMLK HAKBDKOPLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	BEKLHLEMNJF AAMENENIOAG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	ILMLKNKGGGB CPMBPCNPECJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	PNGFPBGOGPN HDIBMCBAAIF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	MHGHGKGLCCD AIKBFHPHAHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EKNMIJAMJJP CLEMNPDODDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	GNPLLOBGHEO APGDPBLFOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface KFDKPCPEEMH
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string AMJCDGFNCDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface HPJODHLMIKD
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGKHKBLPIHL(Action OBNFAOABLKL, bool CEDONJNOFGH);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NGIMFPFEHNB(string LONKACOOPGJ);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int LAJLGAFCPHH(string LONKACOOPGJ, int APDNGABBFBA);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OLFECJOHAPF([Out] bool IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JJAIKKFEGPI([Out] bool IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FACDDLAKFIF([Out] int IIPLJLPCLBC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface JHPFNEMIJJD
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string OKOEDDFPFCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] DGGGKJDJBIH(IEnumerable<AOELPJPGLMM> AELEACAABJM, bool LAJMAFPPIMH);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PAPODKGMAGO(GameObject OJCNPGOLEHK, [Out] FBKGLLHAOCB[] GNKLEMOMGKC);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FDHBPEAHBKF(GameObject OJCNPGOLEHK, [Out] int AEBGBDOKEJA, [Out] EBKFNFACOLI OEBDHGNIACG);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KOEOKJHJALF ALPFMEKGODA(AOELPJPGLMM KAIGMLIOMBJ);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KOEOKJHJALF ALPFMEKGODA(string MGAAGEAKAIC, FBKGLLHAOCB[] JNJFNANDEGO, Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO, Vector3 DANMJNNJDHD);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KOEOKJHJALF ABMACHEEOPF(string MGAAGEAKAIC, FBKGLLHAOCB[] JNJFNANDEGO, Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO, Vector3 DANMJNNJDHD);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject BKIFJNNIMMJ(string MGAAGEAKAIC);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BCLHIHPCNDJ(GameObject ELBCMMGGGEC, bool NIKNNKAMGHO);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EGIMMKFAKLH(GameObject OJCNPGOLEHK, bool HLFMHNAJMEH, bool AINIMFHILKK);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JCJFHMAFJHK
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2050", Offset = "0x6AD0C50", VA = "0x186AD2050")]
	public static KOEOKJHJALF ALPFMEKGODA(this JHPFNEMIJJD JMKPKEHPNLL, Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO, Vector3 DANMJNNJDHD, params FBKGLLHAOCB[] GNKLEMOMGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1F00", Offset = "0x6AD0B00", VA = "0x186AD1F00")]
	public static KOEOKJHJALF ABMACHEEOPF(this JHPFNEMIJJD JMKPKEHPNLL, Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO, Vector3 DANMJNNJDHD, params FBKGLLHAOCB[] GNKLEMOMGKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface CPCAGNMNMLK
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGEOHMBNOIO(bool NODMMGDBLME);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface BEKLHLEMNJF
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool KKJOEIGDAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool EIFGBLGGAPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool DNJAAIGABDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int LOHKCANOOPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool HJFEFFHJMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OEJPJGJOOJP(object BHGBMMFNCAD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OEELLFKAGJF(object BHGBMMFNCAD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CHCFCFGGPFJ(object EEOLDJILHGA);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ONLAJHDAFOH(object EEOLDJILHGA);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ViewId LMOKILFLMOD(GameObject OKNHMCBCFPH);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AGCIOLDKJMM(NativeArray<ViewId> MBMGMEFLEKH);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DINHIOECEED(NativeArray<ViewId> JFBBPKPMJMN);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CFCDFCMCFFJ();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JLOBONPHBLI(uint HOMIGNNBMKB, ReadOnlySpan<byte> CCEPGMDALLF, bool LEHEDLMICKF = false);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JLOBONPHBLI(uint HOMIGNNBMKB, ReadOnlySpan<byte> CCEPGMDALLF, ReadOnlySpan<byte> ODPOLGGFCPB, bool LEHEDLMICKF = false);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JNHEOBNONKM(Func<int, bool, int> AKIHLIBIKJI, bool NONPNJLLPGO);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MFEPJDGJHEA(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KNKMLOIPEJJ(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	uint OCPOFNCIFPG(uint LOLFBCCGJCN);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class GONHOIMALPI
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6AD18F0", Offset = "0x6AD04F0", VA = "0x186AD18F0")]
	public static GGLOGJAKCEH BFPBKCCFDNK(this BEKLHLEMNJF KMGJPDDKEEH, object GBENACPKFNA)
	{
		return default(GGLOGJAKCEH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GGLOGJAKCEH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private BEKLHLEMNJF KMGJPDDKEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private object GBENACPKFNA;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1490", Offset = "0x6AD0090", VA = "0x186AD1490")]
	public GGLOGJAKCEH(BEKLHLEMNJF KMGJPDDKEEH, object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1440", Offset = "0x6AD0040", VA = "0x186AD1440", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface ILMLKNKGGGB
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEMNJLMBBCM(GameObject OJCNPGOLEHK);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface PNGFPBGOGPN
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct DHJLLNAEKBC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private PNGFPBGOGPN MMIIJLDFFJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Task LJPOAIPEHGB;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Task OGCKIIIPMEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E70", Offset = "0x8D5A70", VA = "0x1808D6E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0560", Offset = "0x6ACF160", VA = "0x186AD0560")]
		public DHJLLNAEKBC(PNGFPBGOGPN MMIIJLDFFJC, CancellationToken PPKBAEMFIMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0510", Offset = "0x6ACF110", VA = "0x186AD0510", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJNNOLGCEHM(string NKAJDDICLFH, float CNHHDPPEEFN = 5f);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KIHJILPIPJN(CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ENHPAFJFOOB();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class GOEHCAFJLFF
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6AD18D0", Offset = "0x6AD04D0", VA = "0x186AD18D0")]
	public static PNGFPBGOGPN.DHJLLNAEKBC KLBEPGHMKNJ(this PNGFPBGOGPN KMGJPDDKEEH, CancellationToken PPKBAEMFIMG)
	{
		return default(PNGFPBGOGPN.DHJLLNAEKBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface OLJPMNHMEOB
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int ILPBDNMNBCI(GameObject OJCNPGOLEHK);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPMAALIKPHI(GameObject OJCNPGOLEHK);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FIIEPMMKKFC(int OAINFFFHFMB);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object JHHIJACHDPF(PEAFMKHEGLL IDIEOFKIGBL, GameObject OJCNPGOLEHK, Action<PEAFMKHEGLL, int> LABOKGHKKOB);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CGELBKCLPAE(GameObject OJCNPGOLEHK, object KHAEINBABKA);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface KMIJAJNNKCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool FPBMIGABMNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate EFKKKIJCCIK(PKDEHLJAPLK.HHOGMBPOJKB MIGJAGAFFND, Action<PKDEHLJAPLK.HHOGMBPOJKB> LABOKGHKKOB);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BLECEFICGMO(PKDEHLJAPLK.HHOGMBPOJKB MIGJAGAFFND, Delegate LABOKGHKKOB);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate LBHANDPGNED(PKDEHLJAPLK.HHOGMBPOJKB MIGJAGAFFND, Action<PKDEHLJAPLK.HHOGMBPOJKB> GDGIJFBEMPA);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AGCCCPEDODH(PKDEHLJAPLK.HHOGMBPOJKB MIGJAGAFFND, Delegate LABOKGHKKOB);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OCAHNLHHELK(PKDEHLJAPLK.HHOGMBPOJKB MIGJAGAFFND);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PKDEHLJAPLK.HHOGMBPOJKB GBPKGLIJBPN(GameObject OJCNPGOLEHK);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface MHGHGKGLCCD
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	int AIJCLHFFEKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	int GNBIAFLEDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int DBMDDHIPDMO(GameObject OJCNPGOLEHK);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LICAJCOPNFI([Out] Vector3 DCDKACDAEIJ);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMKAOPGKNNH();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PEAFMKHEGLL KGICEJOFLKP(int OAINFFFHFMB);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface EKNMIJAMJJP
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool HIPLOPIKFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface BFAFLPGLHFG
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	GDFNHDHNEKL OHFDAIAHFNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	LBELADODJLM ENPHIAIKJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PINOCGBBNMM(Transform MENBKJEFCNP);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGMHPIJPAKG(Transform MENBKJEFCNP, BPFOGIPMOBA IMJNBNFDPBF);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDFILOBGFOI(Transform MENBKJEFCNP, FKPBJOFDNBG FJNHLGEPLMK);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface KMGKJPEKFBO
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface GNPLLOBGHEO
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LIPHBNCJHKJ;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DIDICKIMPEA(KPCKLPGBLFP JCJHJEFDDBG, bool LFFKDHOCMED);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface JOBCEKKHCIB
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CALBCFJCHBP();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface MGBPAECOFOI
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EBKFNFACOLI ICJAAKJODMH(GameObject OKNHMCBCFPH);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MEHLNACJHNL(GameObject OJCNPGOLEHK, AMDHMCDLIKB JEBHHGOIHEP, PPDPJNIDGAP HJBEOEOGBEH);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IHDJNMGKHLM(PEAFMKHEGLL IDIEOFKIGBL, bool HEFPBFDJGGO, float3 ENAODCJOGED, quaternion LICFIHAILBI);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PLJOOIJPGEP(KNGFJCECCLB DJNHJDCMHHE, KNGFJCECCLB EEOLDJILHGA, ENHGDLNCONB DEJLCIIFBAN);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HBBAHFPLAHA(KNGFJCECCLB DJNHJDCMHHE, ENHGDLNCONB DEJLCIIFBAN);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LEHNGKJHDJP(KPCKLPGBLFP BIGEIKNMIKM);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DDICDGMFMBE(KPCKLPGBLFP DIDDAJAOOPG, NativeArray<LocalPoseData> PLIELJOBHAI, NativeArray<float3> AIONDKHPCHC);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IMEFFDOHPMM(KPCKLPGBLFP DIDDAJAOOPG, KPCKLPGBLFP CFJKKILEIAA);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EOKDHFHBCGF(KPCKLPGBLFP DIDDAJAOOPG, bool OAECNFHPJME);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JAMABHODEKK(KPCKLPGBLFP DIDDAJAOOPG, bool PFMIBPLMKCC);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct DJFAPDCJEPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly CHEPIJBAOOI CNNPCLMHBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly CHEPIJBAOOI CLJNFDDEOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly uint MCEMHDGIDNI;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0650", Offset = "0x6ACF250", VA = "0x186AD0650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct KFGILBHPMAD
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly DJFAPDCJEPG OBNFAOABLKL;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1E60", Offset = "0x6AD0A60", VA = "0x186AD1E60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct JACHMCJFEEE
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal readonly DJFAPDCJEPG OBNFAOABLKL;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1E60", Offset = "0x6AD0A60", VA = "0x186AD1E60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct BBFCGEJBOOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal readonly uint MCEMHDGIDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal readonly bool CJAPFEKDGGD;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEF30", Offset = "0x6ACDB30", VA = "0x186ACEF30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct CHEPIJBAOOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal int JEHLDDEOFLK;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFEF0", Offset = "0x6ACEAF0", VA = "0x186ACFEF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface HEPMMBMGLOB
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	GFCOLDFMDGM HFKLDFIJMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum DDENMKJJDHB
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
public interface KOEOKJHJALF : EFOKGOGGOOA
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	DDENMKJJDHB FLPMDBBICDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool JBBOHCMEFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject OJCNPGOLEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KOEOKJHJALF> NLCFCOPJPJO;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(FHOGNAOGBDD PJPKFFPGDHE, PEAFMKHEGLL OPOINFAILGB);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool FGLKDFDKLMC);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class PKHKOMONFFL
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF430", Offset = "0x6ADE030", VA = "0x186ADF430")]
	public static bool FJAAMBOBGLM(this KOEOKJHJALF CGLODONKFEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF480", Offset = "0x6ADE080", VA = "0x186ADF480")]
	public static bool ICLPGMGPEBA(this KOEOKJHJALF CGLODONKFEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF4D0", Offset = "0x6ADE0D0", VA = "0x186ADF4D0")]
	public static bool NOJJJMJLEDI(this KOEOKJHJALF CGLODONKFEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF3A0", Offset = "0x6ADDFA0", VA = "0x186ADF3A0")]
	public static bool DLCDMGIPGPC(this KOEOKJHJALF CGLODONKFEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EFOKGOGGOOA
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool FIIEBMHFBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
internal interface OCAFFKPFNKO
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<KECGKEPGMKP> GHJMIJHCGEF;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface KPBDJKIOIKB
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBALHLPAGMI(Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO, Vector3 DANMJNNJDHD);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PNCCPJNBDLO(PEAFMKHEGLL DELFIACNBGK);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIBIFEDNIMO(bool MPOBJFGHMHG);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AAJFKFAOGKI(bool PFMIBPLMKCC);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface KLGOMKEBKDC
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface DIELCOIPGIL
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(NIJCOMOFOFB PDNFKKCKLPB);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface NIJCOMOFOFB
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	GameObject OJCNPGOLEHK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Transform MENBKJEFCNP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	EGNFIBKBHKP BODPPGFPBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool ADNJINLDBGD
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EEIFILKOELO(EGNFIBKBHKP JPJGGLNFIBC);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface EGNFIBKBHKP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	Rigidbody CKFDKNLJFBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	NIJCOMOFOFB HOOMNGJJCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	GameObject CPHJNMFHAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Transform LHELEJKIFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	EGNFIBKBHKP BBKNDFHDFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	EGNFIBKBHKP LIOIAHEPIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	int FOOFFHHPMDI
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool OCAHNLHHELK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool EEPDKLKKOLN
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	INHEMIHIBFP DFIDBGCEBII
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "31")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	EDACBNCGKFK LIODHEOELNH
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	float MOPMJLHOCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "35")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 JPMEJPLLBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 FDBDBELGLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	Vector3 CDMANJEHLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 JEAEJDIOEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool GILGEOCHDBD
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool MLLHNOBJLDC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	bool GHBJLIODJHF
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 KHKHPEILLBD
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 BPONHOGLMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 LMNBHBJAJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "50")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Vector3 HAIHKHGGPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float ECJECJPONJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float GOBLNFAJJOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Vector3 PNJPKBMKLJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion NEDIJPEDJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float EEJCJOIJJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	float HHODGMIMJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool FPHBHOGHBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	LHFCBMFLLBG FFPPBFFPFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool PHMLJIAJDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform JBNNMFNNNAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 HOGGFEAJLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float GPJBNIKGDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float MMGMJPBKMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion ODHCJDCMGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 BOKOHHFILBG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion CKGMEBIHNIC
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints LAFPPCHIKBM
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool FAFDAGIIDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode CJKJNHCCBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool LAPFFGJNIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event PADECADCPBE CFHLFFFLALO;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event PADECADCPBE PDHLFFDEEJB;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event PADECADCPBE JPIIIJEFFCH;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event PADECADCPBE MBJBDJEOMPC;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event PADECADCPBE JPCEHDELPPJ;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event PADECADCPBE EKMLDGKMBHD;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event PADECADCPBE KLHGFHNHGEH;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event PNHJLHINCOF IGAOMNPMGGA;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<IABFIAOBIIB, IABFIAOBIIB> HNJNIGNEAPH;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "26")]
	EGNFIBKBHKP EBNFKEFJACB(int BAEBMIBABAE);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void DIODJNGDMDD((Quaternion rot, Vector3 moments) DAKHJKLEMDA);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void BCJIBCPCLJO();

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void BNHPIAHLGPC();

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void GJIAHAHPEPP();

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void PHFOJALJMOJ();

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void PNCCPJNBDLO(EGNFIBKBHKP IIPLJLPCLBC, bool NOFJHFMCCCG = false);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void KDAPIPLKMJC(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void IHCDJFFHDDG(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 PHAPDKMGHBI(Vector3 HPLCNCFNOCB);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 BOLPKKOBOEM(Vector3 AANPGIPGGCD);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void GBOMHIENMBH();

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void AJABIOHJCJL();

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void MLHLKKDAIEE();

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void HMNHDGDMDAE(Vector3 AJDEPJADDIH, Vector3 MAEPOHBIICK);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void FEIELGKMBHN(Vector3 PAHGAPJJGCH, Vector3 EGODONBGLKF);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void NBOHEJKAJEC(Vector3 MFMBALHFABC);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void DPKPHGABCLN(JDPIALONKJP JIPJBNBKBLG, Vector3 NKHOFGAANEK, float EDHDLGGJOCE, float PKDMCAHEPPF = 8f, float FFHCMFMNDIM = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void PPAAECDKFNC(OKFMPDPEOKJ HHBPGGPPJEP, Vector3 BGIPBKEALAM, float FDECAJPPJOA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void ABEANEABNLI(OKFMPDPEOKJ HHBPGGPPJEP, Vector3 GPEICHFGELO, float HLFLCONGPIA = 7f, float EKICCDEOMKG = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "105")]
	Vector3 HEHLNGGHFJC(Vector3 IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 DKLGFMNBFPD(Vector3 IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void NMMBIONOOKB();

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void NKBLFOLFIMI(EGNFIBKBHKP OBNADBOMLBC, object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void JOLHGJNGMAO(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void OLGGIMDAFGE();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void BOFJEGKPIDK();

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void KGOEDDJICMA();

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "113")]
	bool FGICBOJAMPD();

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void FCLCNJHCFEK();

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void AEGKOCEMEGJ(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void PEFODCFIPOM(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void OPGIAECBLAE(object GBENACPKFNA, bool KBFDDAHABNO);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void PANNMNBPPPO(Vector3 CIBLJNHHDEI, Quaternion MEKOHPCFOEN);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void MGGLAHFGLCF(Vector3 OODGCMHJCPI, Quaternion BBBLGHPGBJP);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "120")]
	bool EHMBHIMNJMI(float GMIJCBEMLNL);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void EMHMEOEEPHK(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void LDJNNFMGEDJ(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void ILHOGPAMLOI(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void DFNPFAMILKL(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void BABMAEABEIM(Vector3 FPPHGAIAECP, ForceMode FAJECLKJHJB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void ICKGEAJCKAG(Vector3 FPPHGAIAECP, Vector3 DCDKACDAEIJ, ForceMode FAJECLKJHJB);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void ALPGIIFOJJD(Vector3 FJDBDBPDFJB, ForceMode FAJECLKJHJB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void NFMDMFEEENC(Vector3 FJDBDBPDFJB, ForceMode FAJECLKJHJB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "129")]
	bool LMDHKAMDKDE(Vector3 MLCEOGMBLFG, [Out] RaycastHit IEALFPDCKEB, float DIPNJIGHAJA);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void FIAFIGKJINB();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EDACBNCGKFK
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMKAIHDHHFF(Vector3 KJHJOKGMDEH);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHKAEECHHAE(Vector3 EGKIANADJEO);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EDDBIMFMOPC(Vector3 KJHJOKGMDEH);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LHHDAMDODIO(Vector3 EGKIANADJEO);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface INHEMIHIBFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 CFKODBLBHJI();

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 KHDGCHKELJI();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public delegate void PADECADCPBE(NIJCOMOFOFB LBFAIKPNNEA);
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum CAELFOIKDDG
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
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum JDPIALONKJP
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
[Cpp2IlInjected.Token(Token = "0x2000042")]
public delegate void PNHJLHINCOF(NIJCOMOFOFB LBFAIKPNNEA, bool NOFJHFMCCCG = false);
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum OKFMPDPEOKJ
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct CCGIPMCDDGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Rigidbody JJDGGMNFHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public object EFEMGJMOAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector3 LPLGLMOGFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector3 ABEPCGMOPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public GPOLNCCKNBK NKHEJILBBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool GMJFJBOHOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool MBJOGPBLOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool AOEEHIGGDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool MBJHEJJAKHH;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface LFHNLOCMOLI : ILEBMCPHAGK<FBKGLLHAOCB>, FFJOECNIMAA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface NMCJNHDFDLB<T> : PLEKKPJOJJK<FBKGLLHAOCB, T>, ILEBMCPHAGK<FBKGLLHAOCB>, FFJOECNIMAA, IDisposable, LFHNLOCMOLI where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class CGBKGEPNNBO
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x2954430", Offset = "0x2953030", VA = "0x182954430")]
	public static bool LPJAHGPAPEL<T>(this ILEBMCPHAGK<FBKGLLHAOCB> LPPIGHILDBI, FBKGLLHAOCB JNJFNANDEGO, [Out] T IIPLJLPCLBC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x294ED00", Offset = "0x294D900", VA = "0x18294ED00")]
	public static bool IJGOPKKNHAN<T>(this ILEBMCPHAGK<FBKGLLHAOCB> LPPIGHILDBI, FBKGLLHAOCB JNJFNANDEGO, [In] T NHPLJONGPGD) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface OBPGAIGCCCJ : ILEBMCPHAGK<PEAFMKHEGLL>, FFJOECNIMAA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface HLFMGIFMPBB<T> : PLEKKPJOJJK<PEAFMKHEGLL, T>, ILEBMCPHAGK<PEAFMKHEGLL>, FFJOECNIMAA, IDisposable, OBPGAIGCCCJ where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class NPHLAMANOEB
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x294F030", Offset = "0x294DC30", VA = "0x18294F030")]
	public static T OIPGNBHOLEB<T>(this ILEBMCPHAGK<PEAFMKHEGLL> LPPIGHILDBI, PEAFMKHEGLL IDIEOFKIGBL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x294ED00", Offset = "0x294D900", VA = "0x18294ED00")]
	public static bool IJGOPKKNHAN<T>(this ILEBMCPHAGK<PEAFMKHEGLL> LPPIGHILDBI, PEAFMKHEGLL IDIEOFKIGBL, [In] T NHPLJONGPGD) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct GJLJEKHEBJD : IComparable<GJLJEKHEBJD>, IEquatable<GJLJEKHEBJD>
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly GJLJEKHEBJD IAEFNBLMFND;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly GJLJEKHEBJD JKNLBEFEIGJ;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GJLJEKHEBJD HGIHAIMEJKH;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly GJLJEKHEBJD HHDJMMIPDDL;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly GJLJEKHEBJD FHMABHGFEAH;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly GJLJEKHEBJD MAMKDODIDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public int ICIBDGPPAOE;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool LLIGGBGGKCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6AD15C0", Offset = "0x6AD01C0", VA = "0x186AD15C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public int EHDBDINBMPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6AD15B0", Offset = "0x6AD01B0", VA = "0x186AD15B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510")]
	public GJLJEKHEBJD(int BAEBMIBABAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1660", Offset = "0x6AD0260", VA = "0x186AD1660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6AD15D0", Offset = "0x6AD01D0", VA = "0x186AD15D0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0xA07AD0", Offset = "0xA066D0", VA = "0x180A07AD0", Slot = "5")]
	public bool Equals(GJLJEKHEBJD HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A650", Offset = "0x1A99250", VA = "0x181A9A650", Slot = "4")]
	public int CompareTo(GJLJEKHEBJD HEIGABGMPLJ)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0xE24FB0", Offset = "0xE23BB0", VA = "0x180E24FB0")]
	public static GJLJEKHEBJD ANHILFPCAJJ(int BAEBMIBABAE)
	{
		return default(GJLJEKHEBJD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0xE24FB0", Offset = "0xE23BB0", VA = "0x180E24FB0")]
	public static int ANHILFPCAJJ(GJLJEKHEBJD OJLGEGJAMDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6AD16C0", Offset = "0x6AD02C0", VA = "0x186AD16C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct KNGFJCECCLB : IEquatable<KNGFJCECCLB>, EFOKGOGGOOA
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly KNGFJCECCLB NAHNFHANEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "6")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public MMEOAANEJBN LHELEJKIFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(MMEOAANEJBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public OCMPFBEHOCL ELABCBFKGBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(OCMPFBEHOCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public GameObject OJCNPGOLEHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3480", Offset = "0x6AD2080", VA = "0x186AD3480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public FBKGLLHAOCB FICFMHEBLDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3930", Offset = "0x6AD2530", VA = "0x186AD3930")]
		get
		{
			return default(FBKGLLHAOCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public EBNDBGDLOPE PAIBOJHOJKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3210", Offset = "0x6AD1E10", VA = "0x186AD3210")]
		get
		{
			return default(EBNDBGDLOPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public EBKFNFACOLI AKCDPONFLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6AD32B0", Offset = "0x6AD1EB0", VA = "0x186AD32B0")]
		get
		{
			return default(EBKFNFACOLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool OPKEEJPOHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6AD31F0", Offset = "0x6AD1DF0", VA = "0x186AD31F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool DBPPHIEKMBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6AD33E0", Offset = "0x6AD1FE0", VA = "0x186AD33E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool OCOKOIADCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3460", Offset = "0x6AD2060", VA = "0x186AD3460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool LPGPBOGJEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3850", Offset = "0x6AD2450", VA = "0x186AD3850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool MCNKGKCLOGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3440", Offset = "0x6AD2040", VA = "0x186AD3440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool DALGBOPOMII
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3A90", Offset = "0x6AD2690", VA = "0x186AD3A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool GCGFJLJMOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3810", Offset = "0x6AD2410", VA = "0x186AD3810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool JMEHGGLHKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3A20", Offset = "0x6AD2620", VA = "0x186AD3A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool LEDLMIDCLIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3A00", Offset = "0x6AD2600", VA = "0x186AD3A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public LAGCOEOEOME GGKGJNKLPEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(LAGCOEOEOME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public COAEBCOPOJE BOGCPGBFCCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(COAEBCOPOJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public AELDLPLLNKB AJKHHOGDGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(AELDLPLLNKB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public AFKNCMIOFHA NBNDCJEBKFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(AFKNCMIOFHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public MMLCEJAIBIA AGHBEPIBPHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(MMLCEJAIBIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public DDECPECPEEK JGJDGPHBOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(DDECPECPEEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public PBODHHDDCNE EHLDHGDECFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(PBODHHDDCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public OLDKBNDCDGG EOCKKAJNOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(OLDKBNDCDGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public NGMEIBLGJHB BIPLBLEAKAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(NGMEIBLGJHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public BLKAPGJIICI MPOKCMJIGGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(BLKAPGJIICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public LHJOFIEOMPI DCKPMEJNEFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(LHJOFIEOMPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public CCMFCAIBDAG MKNMAMOAABC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(CCMFCAIBDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool FJAAMBOBGLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3720", Offset = "0x6AD2320", VA = "0x186AD3720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool BICNGDAGEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3400", Offset = "0x6AD2000", VA = "0x186AD3400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool PCCGAGDAJFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6AD36E0", Offset = "0x6AD22E0", VA = "0x186AD36E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	private bool ONHAHPOBPOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public KNGFJCECCLB(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD250", Offset = "0x6ACBE50", VA = "0x186ACD250")]
	public static bool ANHILFPCAJJ(KNGFJCECCLB IIPLJLPCLBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
	public static PEAFMKHEGLL ANHILFPCAJJ(KNGFJCECCLB IIPLJLPCLBC)
	{
		return default(PEAFMKHEGLL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6ACDAA0", Offset = "0x6ACC6A0", VA = "0x186ACDAA0")]
	public static bool IGDKJEPDLHP(KNGFJCECCLB PFJBMEMCGDE, KNGFJCECCLB GCHHKKAJBGE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3910", Offset = "0x6AD2510", VA = "0x186AD3910")]
	public static bool OAODAFKFIOO(KNGFJCECCLB PFJBMEMCGDE, KNGFJCECCLB GCHHKKAJBGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3350", Offset = "0x6AD1F50", VA = "0x186AD3350", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(KNGFJCECCLB HEIGABGMPLJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
	public static KNGFJCECCLB ANHILFPCAJJ(PEAFMKHEGLL PKDLIJKOEEE)
	{
		return default(KNGFJCECCLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3660", Offset = "0x6AD2260", VA = "0x186AD3660")]
	public AKBALEJCBDO KMLOAHIIPIN()
	{
		return default(AKBALEJCBDO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6AD39D0", Offset = "0x6AD25D0", VA = "0x186AD39D0")]
	public NBACAGGDLFP OHNLGKMNDDN()
	{
		return default(NBACAGGDLFP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3610", Offset = "0x6AD2210", VA = "0x186AD3610")]
	public MEOGFGIKLDO KKFDEECCGPL()
	{
		return default(MEOGFGIKLDO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3A60", Offset = "0x6AD2660", VA = "0x186AD3A60")]
	public OFHGNINPCCG PGDNPGCDCJO()
	{
		return default(OFHGNINPCCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3870", Offset = "0x6AD2470", VA = "0x186AD3870")]
	public void NFHGJFCGPHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3AB0", Offset = "0x6AD26B0", VA = "0x186AD3AB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct PBODHHDDCNE : IEquatable<PBODHHDDCNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private DLGLCBKLECI BLCFABFNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE7F0", Offset = "0x6ADD3F0", VA = "0x186ADE7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private DJIKGLGNKNN KOPCGLLENFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE880", Offset = "0x6ADD480", VA = "0x186ADE880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool NHCPDBHFAND
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE760", Offset = "0x6ADD360", VA = "0x186ADE760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Guid BNILNIJJJNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE5A0", Offset = "0x6ADD1A0", VA = "0x186ADE5A0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool KEOBLBJDCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE090", Offset = "0x6ADCC90", VA = "0x186ADE090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public Guid BJFLFINBBIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE480", Offset = "0x6ADD080", VA = "0x186ADE480")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public PBODHHDDCNE(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE120", Offset = "0x6ADCD20", VA = "0x186ADE120", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(PBODHHDDCNE HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE6C0", Offset = "0x6ADD2C0", VA = "0x186ADE6C0")]
	public bool MAJIDHLCFEO([Out] Guid CJJOKEDEAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE1B0", Offset = "0x6ADCDB0", VA = "0x186ADE1B0")]
	public void GAILELFFEAM(Guid BMEHNBDMOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDFF0", Offset = "0x6ADCBF0", VA = "0x186ADDFF0")]
	public bool DDCIPKOPKNB([Out] Guid DDPGCLLGMBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE360", Offset = "0x6ADCF60", VA = "0x186ADE360")]
	public void HKLJHJGLOKN(Guid BMEHNBDMOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE2D0", Offset = "0x6ADCED0", VA = "0x186ADE2D0")]
	public void HHDFEPLNPMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct MEOGFGIKLDO : IEquatable<MEOGFGIKLDO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private DLGLCBKLECI BLCFABFNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6AD68F0", Offset = "0x6AD54F0", VA = "0x186AD68F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private OAIJMCPCDPL LCLBALANGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6AD63C0", Offset = "0x6AD4FC0", VA = "0x186AD63C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 LAHHBDOEPHL
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD67A0", Offset = "0x6AD53A0", VA = "0x186AD67A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public Quaternion MHFCAFIEMCD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6B40", Offset = "0x6AD5740", VA = "0x186AD6B40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public KNGFJCECCLB CIIHNMKGONA
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6570", Offset = "0x6AD5170", VA = "0x186AD6570")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public MEOGFGIKLDO(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD250", Offset = "0x6ACBE50", VA = "0x186ACD250")]
	public static bool ANHILFPCAJJ(MEOGFGIKLDO IIPLJLPCLBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
	public static PEAFMKHEGLL ANHILFPCAJJ(MEOGFGIKLDO IIPLJLPCLBC)
	{
		return default(PEAFMKHEGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6600", Offset = "0x6AD5200", VA = "0x186AD6600", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(MEOGFGIKLDO HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6420", Offset = "0x6AD5020", VA = "0x186AD6420")]
	public void CHFMKHCGCLE(Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6690", Offset = "0x6AD5290", VA = "0x186AD6690")]
	public void GKMNDNJCJCJ(float DANMJNNJDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6980", Offset = "0x6AD5580", VA = "0x186AD6980")]
	public void NJMGKDHBIMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct AKBALEJCBDO : IEquatable<AKBALEJCBDO>
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly AKBALEJCBDO NAHNFHANEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public MMEOAANEJBN LHELEJKIFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(MMEOAANEJBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public OCMPFBEHOCL ELABCBFKGBN
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(OCMPFBEHOCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private DLGLCBKLECI BLCFABFNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE160", Offset = "0x6ACCD60", VA = "0x186ACE160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private CMCFFEGLMCA ANMEGDAIHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD6D0", Offset = "0x6ACC2D0", VA = "0x186ACD6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public KPCKLPGBLFP AOIFMLNNKMA
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD3D0", Offset = "0x6ACBFD0", VA = "0x186ACD3D0")]
		get
		{
			return default(KPCKLPGBLFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public IEnumerable<KNGFJCECCLB> ICKCFCDEAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD560", Offset = "0x6ACC160", VA = "0x186ACD560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public IEnumerable<KNGFJCECCLB> IHBNBNENOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD910", Offset = "0x6ACC510", VA = "0x186ACD910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public int FOOFFHHPMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD270", Offset = "0x6ACBE70", VA = "0x186ACD270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public int OLGBAECIHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE310", Offset = "0x6ACCF10", VA = "0x186ACE310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public string ACNBDEPIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE1F0", Offset = "0x6ACCDF0", VA = "0x186ACE1F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDFD0", Offset = "0x6ACCBD0", VA = "0x186ACDFD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public MPNFGDHDJCH IGIOKADAHGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDA40", Offset = "0x6ACC640", VA = "0x186ACDA40")]
		get
		{
			return default(MPNFGDHDJCH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDC60", Offset = "0x6ACC860", VA = "0x186ACDC60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public NEOFKOLGLOF PHAGAKBLEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDAD0", Offset = "0x6ACC6D0", VA = "0x186ACDAD0")]
		get
		{
			return default(NEOFKOLGLOF);
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDD30", Offset = "0x6ACC930", VA = "0x186ACDD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public GNDAOAFMAFP JFKCMAIANHN
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCE80", Offset = "0x6ACBA80", VA = "0x186ACCE80")]
		get
		{
			return default(GNDAOAFMAFP);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE080", Offset = "0x6ACCC80", VA = "0x186ACE080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public float MGEANHEGJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDC00", Offset = "0x6ACC800", VA = "0x186ACDC00")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE2A0", Offset = "0x6ACCEA0", VA = "0x186ACE2A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool HKMFDJHINOF
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCDB0", Offset = "0x6ACB9B0", VA = "0x186ACCDB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE360", Offset = "0x6ACCF60", VA = "0x186ACE360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool MAIIPMMPJAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD370", Offset = "0x6ACBF70", VA = "0x186ACD370")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE0F0", Offset = "0x6ACCCF0", VA = "0x186ACE0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool JAADHHHOOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE3D0", Offset = "0x6ACCFD0", VA = "0x186ACE3D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD8A0", Offset = "0x6ACC4A0", VA = "0x186ACD8A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool JJJGAGBIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDB30", Offset = "0x6ACC730", VA = "0x186ACDB30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDB90", Offset = "0x6ACC790", VA = "0x186ACDB90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool EMGGLNGCOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDCD0", Offset = "0x6ACC8D0", VA = "0x186ACDCD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCE10", Offset = "0x6ACBA10", VA = "0x186ACCE10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool MBDNFIICNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD730", Offset = "0x6ACC330", VA = "0x186ACD730")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD300", Offset = "0x6ACBF00", VA = "0x186ACD300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public AKBALEJCBDO(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD250", Offset = "0x6ACBE50", VA = "0x186ACD250")]
	public static bool ANHILFPCAJJ(AKBALEJCBDO IIPLJLPCLBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6ACDAA0", Offset = "0x6ACC6A0", VA = "0x186ACDAA0")]
	public static bool IGDKJEPDLHP(AKBALEJCBDO PFJBMEMCGDE, AKBALEJCBDO GCHHKKAJBGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD810", Offset = "0x6ACC410", VA = "0x186ACD810", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(AKBALEJCBDO HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
	public static KNGFJCECCLB ANHILFPCAJJ(AKBALEJCBDO ENEDBNLKLJL)
	{
		return default(KNGFJCECCLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6ACDAB0", Offset = "0x6ACC6B0", VA = "0x186ACDAB0")]
	public bool IOOGEFFGBCF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD4F0", Offset = "0x6ACC0F0", VA = "0x186ACD4F0")]
	public bool CAMNCLODDIA(DHKMNICNAEB EPNIAJOMGOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD790", Offset = "0x6ACC390", VA = "0x186ACD790")]
	public void EALEANEIEIA(DHKMNICNAEB EPNIAJOMGOO, bool IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACDDA0", Offset = "0x6ACC9A0", VA = "0x186ACDDA0")]
	public KPCKLPGBLFP LCKIAAIODEC(Allocator MJBDBDLLDBK)
	{
		return default(KPCKLPGBLFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6ACCEE0", Offset = "0x6ACBAE0", VA = "0x186ACCEE0")]
	public void ALIPFDGMGBL(AKBALEJCBDO HEIGABGMPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE430", Offset = "0x6ACD030", VA = "0x186ACE430")]
	public void PPMCPFNPBJA(List<KNGFJCECCLB> DOEIEBBBAAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct HGCILGECPMI : IEquatable<HGCILGECPMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1A10", Offset = "0x6AD0610", VA = "0x186AD1A10", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(HGCILGECPMI HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct COAEBCOPOJE : IEquatable<COAEBCOPOJE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public COAEBCOPOJE(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFF50", Offset = "0x6ACEB50", VA = "0x186ACFF50", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(COAEBCOPOJE HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0120", Offset = "0x6ACED20", VA = "0x186AD0120")]
	public void KHBCMNOGPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFFE0", Offset = "0x6ACEBE0", VA = "0x186ACFFE0")]
	public void IJIEOMCDDKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0080", Offset = "0x6ACEC80", VA = "0x186AD0080")]
	public bool JDDEKJMOBLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct OCMPFBEHOCL : IEquatable<OCMPFBEHOCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private DLGLCBKLECI BLCFABFNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBFB0", Offset = "0x6ADABB0", VA = "0x186ADBFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private CMCFFEGLMCA ANMEGDAIHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB990", Offset = "0x6ADA590", VA = "0x186ADB990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public PEAFMKHEGLL KLDDDABKGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBF20", Offset = "0x6ADAB20", VA = "0x186ADBF20")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public KNGFJCECCLB BBKNDFHDFHL
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC290", Offset = "0x6ADAE90", VA = "0x186ADC290")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public KNGFJCECCLB LIOIAHEPIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBD90", Offset = "0x6ADA990", VA = "0x186ADBD90")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public OCMPFBEHOCL(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBA80", Offset = "0x6ADA680", VA = "0x186ADBA80", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(OCMPFBEHOCL HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC160", Offset = "0x6ADAD60", VA = "0x186ADC160")]
	public bool PNCCPJNBDLO(KNGFJCECCLB DELFIACNBGK, bool OLDAPIKDMMJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBE80", Offset = "0x6ADAA80", VA = "0x186ADBE80")]
	public bool KCCKJCMAANI(KNGFJCECCLB DKKIKIJGBAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBB10", Offset = "0x6ADA710", VA = "0x186ADBB10")]
	private void FMAPIPBPIIG(KNGFJCECCLB KDIFAODLCKO, List<KNGFJCECCLB> GKAHMAJCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB9F0", Offset = "0x6ADA5F0", VA = "0x186ADB9F0")]
	public AKBALEJCBDO DJNHEJCBLFN()
	{
		return default(AKBALEJCBDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBE20", Offset = "0x6ADAA20", VA = "0x186ADBE20")]
	public void IHLBPNBBAFG(List<KNGFJCECCLB> HAJABHNBILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC040", Offset = "0x6ADAC40", VA = "0x186ADC040")]
	public NativeArray<PEAFMKHEGLL> PAMJLJCDNOM()
	{
		return default(NativeArray<PEAFMKHEGLL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct LAGCOEOEOME : IEquatable<LAGCOEOEOME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public string NGJMKJKOLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4850", Offset = "0x6AD3450", VA = "0x186AD4850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string KNEGDNLGFIG
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4690", Offset = "0x6AD3290", VA = "0x186AD4690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private bool DDODNHOOMFH
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4270", Offset = "0x6AD2E70", VA = "0x186AD4270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public string FJKENMOLGNG
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD48D0", Offset = "0x6AD34D0", VA = "0x186AD48D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public string OGLGGKPGPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4440", Offset = "0x6AD3040", VA = "0x186AD4440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public string MIFDLAFLGEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4760", Offset = "0x6AD3360", VA = "0x186AD4760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public LAGCOEOEOME(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6AD43B0", Offset = "0x6AD2FB0", VA = "0x186AD43B0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(LAGCOEOEOME HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct LHJOFIEOMPI : IEquatable<LHJOFIEOMPI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private DLGLCBKLECI BLCFABFNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5FB0", Offset = "0x6AD4BB0", VA = "0x186AD5FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private NPIAAMNJJPL DICCGADMCDE
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5AA0", Offset = "0x6AD46A0", VA = "0x186AD5AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public BAFAKCLLDFJ FIJOFJEIKIK
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6150", Offset = "0x6AD4D50", VA = "0x186AD6150")]
		get
		{
			return default(BAFAKCLLDFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6040", Offset = "0x6AD4C40", VA = "0x186AD6040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool BNCCKHKJKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5E80", Offset = "0x6AD4A80", VA = "0x186AD5E80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5D50", Offset = "0x6AD4950", VA = "0x186AD5D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public string[] KHDMFJBOGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5B90", Offset = "0x6AD4790", VA = "0x186AD5B90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6250", Offset = "0x6AD4E50", VA = "0x186AD6250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public string[] GPOICJOPJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5DF0", Offset = "0x6AD49F0", VA = "0x186AD5DF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5CB0", Offset = "0x6AD48B0", VA = "0x186AD5CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public string[] DHIHJGJEKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6AD58D0", Offset = "0x6AD44D0", VA = "0x186AD58D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5A00", Offset = "0x6AD4600", VA = "0x186AD5A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public string[] OMPDACMDMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5C20", Offset = "0x6AD4820", VA = "0x186AD5C20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5960", Offset = "0x6AD4560", VA = "0x186AD5960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public LHJOFIEOMPI(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
	public static PEAFMKHEGLL ANHILFPCAJJ(LHJOFIEOMPI IIPLJLPCLBC)
	{
		return default(PEAFMKHEGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5B00", Offset = "0x6AD4700", VA = "0x186AD5B00", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(LHJOFIEOMPI HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5F10", Offset = "0x6AD4B10", VA = "0x186AD5F10")]
	public bool MPGOEHDOCJB(PEAFMKHEGLL OCPDBKCKFCD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct GJFBBIINENB : IEquatable<GJFBBIINENB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1520", Offset = "0x6AD0120", VA = "0x186AD1520", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(GJFBBIINENB HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct AELDLPLLNKB : IEquatable<AELDLPLLNKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public AELDLPLLNKB(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB730", Offset = "0x6ACA330", VA = "0x186ACB730", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(AELDLPLLNKB HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB800", Offset = "0x6ACA400", VA = "0x186ACB800")]
	public bool KDAFCBJNPEF([Out] Collider PENEDLAGBJG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct OFHGNINPCCG : IEquatable<OFHGNINPCCG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private MakerPenHeldDataWrapper GOKDFGKADIO
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC870", Offset = "0x6ADB470", VA = "0x186ADC870")]
		get
		{
			return default(MakerPenHeldDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool COJBCBEGHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC800", Offset = "0x6ADB400", VA = "0x186ADC800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public OFHGNINPCCG(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC770", Offset = "0x6ADB370", VA = "0x186ADC770", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(OFHGNINPCCG HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct NGMEIBLGJHB : IEquatable<NGMEIBLGJHB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private DLGLCBKLECI BLCFABFNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAAC0", Offset = "0x6AD96C0", VA = "0x186ADAAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private IJDOGAIGDNJ PCJFBIOMGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAA60", Offset = "0x6AD9660", VA = "0x186ADAA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public NGMEIBLGJHB(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA9D0", Offset = "0x6AD95D0", VA = "0x186ADA9D0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(NGMEIBLGJHB HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAB50", Offset = "0x6AD9750", VA = "0x186ADAB50")]
	public void POGPMCHGOGC(bool ILGEHEKPMNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct AFKNCMIOFHA : IEquatable<AFKNCMIOFHA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private DLGLCBKLECI BLCFABFNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC630", Offset = "0x6ACB230", VA = "0x186ACC630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private ObjectPolicyDataWrapper KMDGKCKMNFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC480", Offset = "0x6ACB080", VA = "0x186ACC480")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private NavMeshGenerationDataWrapper JBEJJGKNIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x6ACBBA0", Offset = "0x6ACA7A0", VA = "0x186ACBBA0")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public bool MOMNAOCELOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC300", Offset = "0x6ACAF00", VA = "0x186ACC300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool PKMFFNOOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC4E0", Offset = "0x6ACB0E0", VA = "0x186ACC4E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool EIINEKPEGCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC3B0", Offset = "0x6ACAFB0", VA = "0x186ACC3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool CEDLHIHPNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC5C0", Offset = "0x6ACB1C0", VA = "0x186ACC5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool OPOCEILBFFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC1C0", Offset = "0x6ACADC0", VA = "0x186ACC1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool JKPMNFKKOBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6ACBA60", Offset = "0x6ACA660", VA = "0x186ACBA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool OCCEMFMNFHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC150", Offset = "0x6ACAD50", VA = "0x186ACC150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool IIPMONKKBJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC860", Offset = "0x6ACB460", VA = "0x186ACC860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool HDEHECFIINF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x6ACBB30", Offset = "0x6ACA730", VA = "0x186ACBB30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool DBHHPKMBIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC8D0", Offset = "0x6ACB4D0", VA = "0x186ACC8D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool DGPDKBCLFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC7F0", Offset = "0x6ACB3F0", VA = "0x186ACC7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool FHCKNDDMAOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC6C0", Offset = "0x6ACB2C0", VA = "0x186ACC6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool INOMNFKAHFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC420", Offset = "0x6ACB020", VA = "0x186ACC420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool ABHIODLOPIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6ACB980", Offset = "0x6ACA580", VA = "0x186ACB980")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC550", Offset = "0x6ACB150", VA = "0x186ACC550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public POIKLOCLNGI FALNGEEPGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC730", Offset = "0x6ACB330", VA = "0x186ACC730")]
		get
		{
			return default(POIKLOCLNGI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC290", Offset = "0x6ACAE90", VA = "0x186ACC290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool BOFLJOAJGAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6ACBD00", Offset = "0x6ACA900", VA = "0x186ACBD00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public PPDPJNIDGAP HNMILDNOAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC790", Offset = "0x6ACB390", VA = "0x186ACC790")]
		get
		{
			return default(PPDPJNIDGAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool BOCFECLEGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6ACBAD0", Offset = "0x6ACA6D0", VA = "0x186ACBAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 BHEOAMENAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC940", Offset = "0x6ACB540", VA = "0x186ACC940")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 FLHMFMINLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC0A0", Offset = "0x6ACACA0", VA = "0x186ACC0A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public bool FANIENAFEPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6ACBC00", Offset = "0x6ACA800", VA = "0x186ACBC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public AFKNCMIOFHA(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBED0", Offset = "0x6ACAAD0", VA = "0x186ACBED0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(AFKNCMIOFHA HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC030", Offset = "0x6ACAC30", VA = "0x186ACC030")]
	public bool FPBJHLACDAK(BJCLPFLGMNG EPNIAJOMGOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC340", Offset = "0x6ACAF40", VA = "0x186ACC340")]
	public bool KEBPMDDKAFG(AMDHMCDLIKB EPNIAJOMGOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB9E0", Offset = "0x6ACA5E0", VA = "0x186ACB9E0")]
	public void ADGBKBJEKEJ(AMDHMCDLIKB EPNIAJOMGOO, bool NCJAANPMPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBF60", Offset = "0x6ACAB60", VA = "0x186ACBF60")]
	public AMDHMCDLIKB FKKPECDBDJI()
	{
		return default(AMDHMCDLIKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBFC0", Offset = "0x6ACABC0", VA = "0x186ACBFC0")]
	public bool FKOINFJICND(AMDHMCDLIKB IIPLJLPCLBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct BLKAPGJIICI : IEquatable<BLKAPGJIICI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private DLGLCBKLECI BLCFABFNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x6ACF830", Offset = "0x6ACE430", VA = "0x186ACF830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private DGMJOGCAKKG MCFOIODCLBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6ACF100", Offset = "0x6ACDD00", VA = "0x186ACF100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public BLKAPGJIICI(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF5C0", Offset = "0x6ACE1C0", VA = "0x186ACF5C0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(BLKAPGJIICI HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEFD0", Offset = "0x6ACDBD0", VA = "0x186ACEFD0")]
	public bool ADMHEDFIGCL(ENHGDLNCONB DEJLCIIFBAN, List<KNGFJCECCLB> DOEIEBBBAAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF270", Offset = "0x6ACDE70", VA = "0x186ACF270")]
	public int AMJEMKPCGMI(ENHGDLNCONB DEJLCIIFBAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF4B0", Offset = "0x6ACE0B0", VA = "0x186ACF4B0")]
	public void DOKOPKGFLHD(List<KNGFJCECCLB> DOEIEBBBAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFA80", Offset = "0x6ACE680", VA = "0x186ACFA80")]
	public int OFNMBPGBNNI(KNGFJCECCLB EEOLDJILHGA, ENHGDLNCONB DEJLCIIFBAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF650", Offset = "0x6ACE250", VA = "0x186ACF650")]
	public KNGFJCECCLB HLGDHJAPGBD(int BAEBMIBABAE, ENHGDLNCONB DEJLCIIFBAN)
	{
		return default(KNGFJCECCLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF380", Offset = "0x6ACDF80", VA = "0x186ACF380")]
	public void DOCLADPMHEA(KNGFJCECCLB EEOLDJILHGA, ENHGDLNCONB DEJLCIIFBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF780", Offset = "0x6ACE380", VA = "0x186ACF780")]
	public bool MBHOJFKEMCH(KNGFJCECCLB EEOLDJILHGA, ENHGDLNCONB DEJLCIIFBAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF8C0", Offset = "0x6ACE4C0", VA = "0x186ACF8C0")]
	public void NLBDEHMHNKJ(ENHGDLNCONB DEJLCIIFBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF9D0", Offset = "0x6ACE5D0", VA = "0x186ACF9D0")]
	public bool NMFEIHBIINM(KNGFJCECCLB EEOLDJILHGA, ENHGDLNCONB DEJLCIIFBAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF160", Offset = "0x6ACDD60", VA = "0x186ACF160")]
	public bool ALNLEIJLPGA(ENHGDLNCONB DEJLCIIFBAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct DDECPECPEEK : IEquatable<DDECPECPEEK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	private MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private DLGLCBKLECI BLCFABFNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6AD02E0", Offset = "0x6ACEEE0", VA = "0x186AD02E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public DDECPECPEEK(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6AD01C0", Offset = "0x6ACEDC0", VA = "0x186AD01C0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(DDECPECPEEK HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0370", Offset = "0x6ACEF70", VA = "0x186AD0370")]
	public void PECDGMLALMN(bool IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0250", Offset = "0x6ACEE50", VA = "0x186AD0250")]
	public void JDNBGPDINMK(bool IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x29944D0", Offset = "0x29930D0", VA = "0x1829944D0")]
	public T NKAGPNFCCBO<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct CCMFCAIBDAG : IEquatable<CCMFCAIBDAG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	private MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private DLGLCBKLECI BLCFABFNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x6ACFDC0", Offset = "0x6ACE9C0", VA = "0x186ACFDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private GHOBGKJAONH JGGNLNBCMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6ACFD60", Offset = "0x6ACE960", VA = "0x186ACFD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public bool NKLPGEGDEBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6ACFBB0", Offset = "0x6ACE7B0", VA = "0x186ACFBB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public bool JIANAMFEKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6ACFC40", Offset = "0x6ACE840", VA = "0x186ACFC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public CCMFCAIBDAG(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFCD0", Offset = "0x6ACE8D0", VA = "0x186ACFCD0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(CCMFCAIBDAG HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct NHJJCMLALKO : IEquatable<NHJJCMLALKO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAC70", Offset = "0x6AD9870", VA = "0x186ADAC70", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(NHJJCMLALKO HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct MMLCEJAIBIA : IEquatable<MMLCEJAIBIA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private DLGLCBKLECI BLCFABFNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA0A0", Offset = "0x6AD8CA0", VA = "0x186ADA0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private KDCLDLEDKND IDCIBMBBBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9BC0", Offset = "0x6AD87C0", VA = "0x186AD9BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private CCKGCFEENAF PKFCGJBCDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9F70", Offset = "0x6AD8B70", VA = "0x186AD9F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool PHCEPFEFHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9B30", Offset = "0x6AD8730", VA = "0x186AD9B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool DNODPAPDKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9ED0", Offset = "0x6AD8AD0", VA = "0x186AD9ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool NGFOJIMAIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9960", Offset = "0x6AD8560", VA = "0x186AD9960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool CPJBOPAOELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9FD0", Offset = "0x6AD8BD0", VA = "0x186AD9FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool EOPHBIBKFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA130", Offset = "0x6AD8D30", VA = "0x186ADA130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool MGJCLEGHJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6AD97C0", Offset = "0x6AD83C0", VA = "0x186AD97C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool AIHJNJJMOPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x6AD95B0", Offset = "0x6AD81B0", VA = "0x186AD95B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool EKFDLLJGOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9C20", Offset = "0x6AD8820", VA = "0x186AD9C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public MMLCEJAIBIA(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD250", Offset = "0x6ACBE50", VA = "0x186ACD250")]
	public static bool ANHILFPCAJJ(MMLCEJAIBIA IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9990", Offset = "0x6AD8590", VA = "0x186AD9990", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(MMLCEJAIBIA HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD94A0", Offset = "0x6AD80A0", VA = "0x186AD94A0")]
	public bool ALFFBNFIKFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9510", Offset = "0x6AD8110", VA = "0x186AD9510")]
	public KNGFJCECCLB AOJEKJCLLEL(KNGFJCECCLB EEOLDJILHGA)
	{
		return default(KNGFJCECCLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9850", Offset = "0x6AD8450", VA = "0x186AD9850")]
	public PEAFMKHEGLL CPJIMDBJANE()
	{
		return default(PEAFMKHEGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9D90", Offset = "0x6AD8990", VA = "0x186AD9D90")]
	public bool INJDBDGCPNP(PEAFMKHEGLL GFIBDLFJKNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9E30", Offset = "0x6AD8A30", VA = "0x186AD9E30")]
	public bool JBDIBAABBBE(PEAFMKHEGLL JPAOFHCBHNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9A20", Offset = "0x6AD8620", VA = "0x186AD9A20")]
	public bool GBCHLLLCDKN(PEAFMKHEGLL EEOLDJILHGA, [Out] PEAFMKHEGLL GFIBDLFJKNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct NBACAGGDLFP : IEquatable<NBACAGGDLFP>
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly NBACAGGDLFP NAHNFHANEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public MMEOAANEJBN LHELEJKIFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(MMEOAANEJBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public OCMPFBEHOCL ELABCBFKGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(OCMPFBEHOCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private ShapeTypeDataWrapper DNPJPPJLGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA570", Offset = "0x6AD9170", VA = "0x186ADA570")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public StandardRenderableVisualDataWrapper CNKKLBGIDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA320", Offset = "0x6AD8F20", VA = "0x186ADA320")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public PhysicsMaterialDataWrapper MAHIHGAGPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA7C0", Offset = "0x6AD93C0", VA = "0x186ADA7C0")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public ShapeConfigDataWrapper KEHNLNHBANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA510", Offset = "0x6AD9110", VA = "0x186ADA510")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public DOPHNCBCMMA PIDOPBJMHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA960", Offset = "0x6AD9560", VA = "0x186ADA960")]
		get
		{
			return default(DOPHNCBCMMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public DIEJALMDMOK LNDJCPFPLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA760", Offset = "0x6AD9360", VA = "0x186ADA760")]
		get
		{
			return default(DIEJALMDMOK);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA1C0", Offset = "0x6AD8DC0", VA = "0x186ADA1C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public HHLFHEPFPPA HGAKPOFCKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA820", Offset = "0x6AD9420", VA = "0x186ADA820")]
		get
		{
			return default(HHLFHEPFPPA);
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA2B0", Offset = "0x6AD8EB0", VA = "0x186ADA2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public float NNFMFCMBEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA700", Offset = "0x6AD9300", VA = "0x186ADA700")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA420", Offset = "0x6AD9020", VA = "0x186ADA420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 DLEHHIBJKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA380", Offset = "0x6AD8F80", VA = "0x186ADA380")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA660", Offset = "0x6AD9260", VA = "0x186ADA660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public float LJBOGONNDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA8F0", Offset = "0x6AD94F0", VA = "0x186ADA8F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public PDCECJCBAEH GCNGGKNOOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA160", Offset = "0x6AD8D60", VA = "0x186ADA160")]
		get
		{
			return default(PDCECJCBAEH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA880", Offset = "0x6AD9480", VA = "0x186ADA880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public NBACAGGDLFP(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD250", Offset = "0x6ACBE50", VA = "0x186ACD250")]
	public static bool ANHILFPCAJJ(NBACAGGDLFP IIPLJLPCLBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3910", Offset = "0x6AD2510", VA = "0x186AD3910")]
	public static bool OAODAFKFIOO(NBACAGGDLFP PFJBMEMCGDE, NBACAGGDLFP GCHHKKAJBGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA5D0", Offset = "0x6AD91D0", VA = "0x186ADA5D0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(NBACAGGDLFP HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA490", Offset = "0x6AD9090", VA = "0x186ADA490")]
	public EJHNEPCKNCO DIMMNDDELPG()
	{
		return default(EJHNEPCKNCO);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA230", Offset = "0x6AD8E30", VA = "0x186ADA230")]
	public JGDFBGDAAPD CECOFKMOCBO()
	{
		return default(JGDFBGDAAPD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct EJHNEPCKNCO : IEquatable<EJHNEPCKNCO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public NBACAGGDLFP DDJHHODHFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(NBACAGGDLFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private PrimitiveShapeDataWrapper JPBGLKBNBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0D80", Offset = "0x6ACF980", VA = "0x186AD0D80")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public PPNDJOMCIKD PAKPGIPGBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0D20", Offset = "0x6ACF920", VA = "0x186AD0D20")]
		get
		{
			return default(PPNDJOMCIKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public EJHNEPCKNCO(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD250", Offset = "0x6ACBE50", VA = "0x186ACD250")]
	public static bool ANHILFPCAJJ(EJHNEPCKNCO IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0C90", Offset = "0x6ACF890", VA = "0x186AD0C90", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(EJHNEPCKNCO HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public readonly struct JGDFBGDAAPD : IEquatable<JGDFBGDAAPD>
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly JGDFBGDAAPD NAHNFHANEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public MMEOAANEJBN LHELEJKIFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(MMEOAANEJBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private DLGLCBKLECI BLCFABFNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD27A0", Offset = "0x6AD13A0", VA = "0x186AD27A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private EBCJHBEGMEO GCKINBOICDD
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD22C0", Offset = "0x6AD0EC0", VA = "0x186AD22C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public NBACAGGDLFP DDJHHODHFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(NBACAGGDLFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public JCHPNDGNLDH MCDKNIAKPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2680", Offset = "0x6AD1280", VA = "0x186AD2680")]
		get
		{
			return default(JCHPNDGNLDH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2450", Offset = "0x6AD1050", VA = "0x186AD2450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public IEnumerable<EOEAHGHJCKJ> LDFBOHKGHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2C80", Offset = "0x6AD1880", VA = "0x186AD2C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public EOEAHGHJCKJ PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2570", Offset = "0x6AD1170", VA = "0x186AD2570")]
		get
		{
			return default(EOEAHGHJCKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2230", Offset = "0x6AD0E30", VA = "0x186AD2230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public JGDFBGDAAPD(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD250", Offset = "0x6ACBE50", VA = "0x186ACD250")]
	public static bool ANHILFPCAJJ(JGDFBGDAAPD IIPLJLPCLBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x6ACDAA0", Offset = "0x6ACC6A0", VA = "0x186ACDAA0")]
	public static bool IGDKJEPDLHP(JGDFBGDAAPD PFJBMEMCGDE, JGDFBGDAAPD GCHHKKAJBGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6AD23C0", Offset = "0x6AD0FC0", VA = "0x186AD23C0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(JGDFBGDAAPD HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2830", Offset = "0x6AD1430", VA = "0x186AD2830")]
	public EOEAHGHJCKJ OGNDIGPFEIJ(float3? DCDKACDAEIJ, [Optional] quaternion? GPEICHFGELO, [Optional] Vector3? DANMJNNJDHD)
	{
		return default(EOEAHGHJCKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2A50", Offset = "0x6AD1650", VA = "0x186AD2A50")]
	public EOEAHGHJCKJ OIJHPPOGALI(int BAEBMIBABAE, float3? DCDKACDAEIJ, [Optional] quaternion? GPEICHFGELO, [Optional] Vector3? DANMJNNJDHD)
	{
		return default(EOEAHGHJCKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2320", Offset = "0x6AD0F20", VA = "0x186AD2320")]
	public void EPMMPCEOBCB(int BAEBMIBABAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6AD21A0", Offset = "0x6AD0DA0", VA = "0x186AD21A0")]
	public void AFPCPCPKMJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct EOEAHGHJCKJ : IEquatable<EOEAHGHJCKJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public JGDFBGDAAPD LKKGGPMJMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1020", Offset = "0x6ACFC20", VA = "0x186AD1020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public float3 BOKOHHFILBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0E50", Offset = "0x6ACFA50", VA = "0x186AD0E50")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1190", Offset = "0x6ACFD90", VA = "0x186AD1190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public quaternion CKGMEBIHNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6AD13C0", Offset = "0x6ACFFC0", VA = "0x186AD13C0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1350", Offset = "0x6ACFF50", VA = "0x186AD1350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public float3 FHMBAPHHKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6AD12D0", Offset = "0x6ACFED0", VA = "0x186AD12D0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x6AD10B0", Offset = "0x6ACFCB0", VA = "0x186AD10B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public LEBNOFPPBOJ FHJGOCCFKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0DE0", Offset = "0x6ACF9E0", VA = "0x186AD0DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	private SplinePointParentDataWrapper HNIGDMOGELJ
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1130", Offset = "0x6ACFD30", VA = "0x186AD1130")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	private SplinePointPositionDataWrapper DJPKFOKNMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0ED0", Offset = "0x6ACFAD0", VA = "0x186AD0ED0")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private SplinePointRotationDataWrapper OCFILCFCNBK
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0FC0", Offset = "0x6ACFBC0", VA = "0x186AD0FC0")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private SplinePointScaleDataWrapper DAKOMALMAKF
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1210", Offset = "0x6ACFE10", VA = "0x186AD1210")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	private SplinePointOrderDataWrapper BHEOLOELPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1270", Offset = "0x6ACFE70", VA = "0x186AD1270")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public EOEAHGHJCKJ(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0F30", Offset = "0x6ACFB30", VA = "0x186AD0F30", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(EOEAHGHJCKJ HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1020", Offset = "0x6ACFC20", VA = "0x186AD1020")]
	public void JHNCAFKEKON(JGDFBGDAAPD IIPLJLPCLBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct OLDKBNDCDGG : IEquatable<OLDKBNDCDGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	private MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private DLGLCBKLECI BLCFABFNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6ADDEC0", Offset = "0x6ADCAC0", VA = "0x186ADDEC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private MFGDJEOJOAM PLGIBOOAGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADDC80", Offset = "0x6ADC880", VA = "0x186ADDC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	private ToolCleanupSettingsDataWrapper COPJGPEFECH
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD530", Offset = "0x6ADC130", VA = "0x186ADD530")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public bool GNDAPCJCLLN
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD590", Offset = "0x6ADC190", VA = "0x186ADD590")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6ADDE50", Offset = "0x6ADCA50", VA = "0x186ADDE50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool ILMKOHGLEIN
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6ADDD50", Offset = "0x6ADC950", VA = "0x186ADDD50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD3C0", Offset = "0x6ADBFC0", VA = "0x186ADD3C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public float PGOJMKAHNEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD430", Offset = "0x6ADC030", VA = "0x186ADD430")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6ADDCE0", Offset = "0x6ADC8E0", VA = "0x186ADDCE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool GOAMLMPOCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6ADDF50", Offset = "0x6ADCB50", VA = "0x186ADDF50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public OLDKBNDCDGG(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD850", Offset = "0x6ADC450", VA = "0x186ADD850", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(OLDKBNDCDGG HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDDB0", Offset = "0x6ADC9B0", VA = "0x186ADDDB0")]
	public void MHHBKBBCOHE(int DJNHJDCMHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD740", Offset = "0x6ADC340", VA = "0x186ADD740")]
	public bool EJGLLBHIFJG([Out] int DJNHJDCMHHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD490", Offset = "0x6ADC090", VA = "0x186ADD490")]
	public void AJMIPDLOMII(bool ENDOBPICEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDB40", Offset = "0x6ADC740", VA = "0x186ADDB40")]
	public void HPOONGIKPLI(float EKNIPGDGPJN, float MCHJNNNPGLL, float HEBPDPBGEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD5F0", Offset = "0x6ADC1F0", VA = "0x186ADD5F0")]
	public void DEOHEDKEPNA(float3 OLOCBBKJCEO, quaternion IPIECNMLAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDA10", Offset = "0x6ADC610", VA = "0x186ADDA10")]
	public bool FNLBOKODHJD([Out] float3 OLOCBBKJCEO, [Out] quaternion IPIECNMLAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD8E0", Offset = "0x6ADC4E0", VA = "0x186ADD8E0")]
	public bool FEMPMMGFDBG([Out] float KPMGBEDMFPM, [Out] float BNGGIPPJOHK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct MMEOAANEJBN : IEquatable<MMEOAANEJBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly PEAFMKHEGLL PKDLIJKOEEE;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public KNGFJCECCLB OAKDNPEENLF
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(KNGFJCECCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public OCMPFBEHOCL ELABCBFKGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
		get
		{
			return default(OCMPFBEHOCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private MILLCJNFGCE GEDMJOAFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC230", Offset = "0x6ACAE30", VA = "0x186ACC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private JPACDLKDDPO JGBAEIDKOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7BE0", Offset = "0x6AD67E0", VA = "0x186AD7BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public bool HIOFMJECLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x6AD74F0", Offset = "0x6AD60F0", VA = "0x186AD74F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public Vector3 BOKOHHFILBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6E00", Offset = "0x6AD5A00", VA = "0x186AD6E00")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x6AD80D0", Offset = "0x6AD6CD0", VA = "0x186AD80D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public Quaternion CKGMEBIHNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9360", Offset = "0x6AD7F60", VA = "0x186AD9360")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8D90", Offset = "0x6AD7990", VA = "0x186AD8D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Vector3 HOGGFEAJLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8EB0", Offset = "0x6AD7AB0", VA = "0x186AD8EB0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD79C0", Offset = "0x6AD65C0", VA = "0x186AD79C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public Quaternion ODHCJDCMGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD81A0", Offset = "0x6AD6DA0", VA = "0x186AD81A0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8CC0", Offset = "0x6AD78C0", VA = "0x186AD8CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public float GPJBNIKGDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD70A0", Offset = "0x6AD5CA0", VA = "0x186AD70A0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6D50", Offset = "0x6AD5950", VA = "0x186AD6D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public float MMGMJPBKMDK
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9220", Offset = "0x6AD7E20", VA = "0x186AD9220")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public Vector3 FHMBAPHHKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8AA0", Offset = "0x6AD76A0", VA = "0x186AD8AA0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7750", Offset = "0x6AD6350", VA = "0x186AD7750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public Vector3 CIADPODNBLP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9000", Offset = "0x6AD7C00", VA = "0x186AD9000")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public Matrix4x4 KCPIMKGMMBC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7680", Offset = "0x6AD6280", VA = "0x186AD7680")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
	public MMEOAANEJBN(PEAFMKHEGLL IDIEOFKIGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7D0", Offset = "0x6ACA3D0", VA = "0x186ACB7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD76C0", Offset = "0x6AD62C0", VA = "0x186AD76C0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7C0", Offset = "0x6ACA3C0", VA = "0x186ACB7C0", Slot = "4")]
	public bool Equals(MMEOAANEJBN HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB960", Offset = "0x6ACA560", VA = "0x186ACB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8E60", Offset = "0x6AD7A60", VA = "0x186AD8E60")]
	public FOJDOHLODGM OILJLLGDNAB()
	{
		return default(FOJDOHLODGM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x6AD82E0", Offset = "0x6AD6EE0", VA = "0x186AD82E0")]
	public void KAJBPMJDGJO([Out] Matrix4x4 APILGPEEJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7210", Offset = "0x6AD5E10", VA = "0x186AD7210")]
	public void DECEGLKKOIJ([Out] Vector3 MGJLOHBNCOA, [Out] Quaternion HDOLEGNHCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6AD72F0", Offset = "0x6AD5EF0", VA = "0x186AD72F0")]
	public void DECEGLKKOIJ([Out] RigidTransform KHBIBKOPGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8760", Offset = "0x6AD7360", VA = "0x186AD8760")]
	public void LNPBIBFJKBA([Out] Vector3 MGJLOHBNCOA, [Out] Quaternion HDOLEGNHCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6AD86B0", Offset = "0x6AD72B0", VA = "0x186AD86B0")]
	public void LNPBIBFJKBA([Out] RigidTransform KHBIBKOPGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6AD89B0", Offset = "0x6AD75B0", VA = "0x186AD89B0")]
	public UniformTRS MDNGDMHKOFG()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6AD89E0", Offset = "0x6AD75E0", VA = "0x186AD89E0")]
	public void MDNGDMHKOFG([Out] UniformTRS GFONEHJLJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6AD78D0", Offset = "0x6AD64D0", VA = "0x186AD78D0")]
	public UniformTRS GNLOEDIPFHN()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7900", Offset = "0x6AD6500", VA = "0x186AD7900")]
	public void GNLOEDIPFHN([Out] UniformTRS KHBIBKOPGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7A90", Offset = "0x6AD6690", VA = "0x186AD7A90")]
	public Vector3 IAHLCCPOAOI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9150", Offset = "0x6AD7D50", VA = "0x186AD9150")]
	public void PELOCLMPBFF([In] Vector3 IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7E40", Offset = "0x6AD6A40", VA = "0x186AD7E40")]
	public Vector3 JIKEHGNAEIO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7140", Offset = "0x6AD5D40", VA = "0x186AD7140")]
	public void DCFLEAGBHGK([In] Vector3 IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7F90", Offset = "0x6AD6B90", VA = "0x186AD7F90")]
	public Quaternion JMMFCEPJNLI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8BF0", Offset = "0x6AD77F0", VA = "0x186AD8BF0")]
	public void NGKFEJJHPHH([In] Quaternion IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8570", Offset = "0x6AD7170", VA = "0x186AD8570")]
	public Quaternion LHOBFOAEAAO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6C80", Offset = "0x6AD5880", VA = "0x186AD6C80")]
	public void ABCBCIHLJMM([In] Quaternion IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8840", Offset = "0x6AD7440", VA = "0x186AD8840")]
	public float LOLCOADGNIA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6AD83F0", Offset = "0x6AD6FF0", VA = "0x186AD83F0")]
	public void KAMHBKKGAPC(float IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6AD92C0", Offset = "0x6AD7EC0", VA = "0x186AD92C0")]
	public float POBNMLINGFL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7820", Offset = "0x6AD6420", VA = "0x186AD7820")]
	public void GMDKNIPAMCM(float IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6AD84A0", Offset = "0x6AD70A0", VA = "0x186AD84A0")]
	public void KEDLPNHIHCN([In] Vector3 IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7530", Offset = "0x6AD6130", VA = "0x186AD7530")]
	public Vector3 EHKENKOBBFJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7CA0", Offset = "0x6AD68A0", VA = "0x186AD7CA0")]
	public void IIGPFGCJBMN([In] Vector3 IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6AD73A0", Offset = "0x6AD5FA0", VA = "0x186AD73A0")]
	public Vector3 DGIDGLDBDGE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6AD88E0", Offset = "0x6AD74E0", VA = "0x186AD88E0")]
	public void LPGCPDOPCMH([In] Vector3 IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6F50", Offset = "0x6AD5B50", VA = "0x186AD6F50")]
	public Vector3 BABEMCOGDFN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7D70", Offset = "0x6AD6970", VA = "0x186AD7D70")]
	public void JIGNENNHHNN([In] Vector3 IIPLJLPCLBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class APOHKKOIJDF
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct BDJCMIAAIOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Guid GBCIBJHFOHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AIBJHMDJMCN ALNGLNEKFOL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private struct AIBJHMDJMCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int IIPLJLPCLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int OHMKFLIELMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int HOMIGNNBMKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int IPIJKHLGPBB;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCCE0", Offset = "0x6ACB8E0", VA = "0x186ACCCE0")]
		public bool OMMGEAHMNBC([Out] FBKGLLHAOCB JNJFNANDEGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCD70", Offset = "0x6ACB970", VA = "0x186ACCD70")]
		public AIBJHMDJMCN(FBKGLLHAOCB JNJFNANDEGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEE90", Offset = "0x6ACDA90", VA = "0x186ACEE90")]
	public static Guid PNDHEIADCMM(this FBKGLLHAOCB JNJFNANDEGO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEE70", Offset = "0x6ACDA70", VA = "0x186ACEE70")]
	public static bool FIEHONMDCEN(this Guid GBCIBJHFOHP, [Out] FBKGLLHAOCB JNJFNANDEGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal static class IOMDNOPBHAI
{
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1CD0", Offset = "0x6AD08D0", VA = "0x186AD1CD0")]
	public static DLGLCBKLECI BLCFABFNOHM(this PEAFMKHEGLL CABAGOHBNFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1C00", Offset = "0x6AD0800", VA = "0x186AD1C00")]
	public static FHOGNAOGBDD ADFIKCDPCMK(this PEAFMKHEGLL CABAGOHBNFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1D60", Offset = "0x6AD0960", VA = "0x186AD1D60")]
	public static EntityManager PMCJCDLGBEK(this PEAFMKHEGLL CABAGOHBNFK)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2B86460", Offset = "0x2B85060", VA = "0x182B86460")]
	public static T LGEPNHOLBAK<T>(this PEAFMKHEGLL CABAGOHBNFK) where T : struct, IGMHMGEDMIG
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2B860F0", Offset = "0x2B84CF0", VA = "0x182B860F0")]
	public static bool IKNPCJDMICH<T>(this PEAFMKHEGLL CABAGOHBNFK) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2B863B0", Offset = "0x2B84FB0", VA = "0x182B863B0")]
	public static bool KOOKMPPBGFP<T>(this PEAFMKHEGLL CABAGOHBNFK) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface DJIKGLGNKNN
{
	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEOBLBJDCNC(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHCPDBHFAND(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MAJIDHLCFEO(PEAFMKHEGLL IDIEOFKIGBL, [Out] Guid CJJOKEDEAPE);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid APKLDAGMONB(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GAILELFFEAM(PEAFMKHEGLL IDIEOFKIGBL, Guid CJJOKEDEAPE);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DDCIPKOPKNB(PEAFMKHEGLL IDIEOFKIGBL, [Out] Guid DDPGCLLGMBN);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid DMELCFCFOBP(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HKLJHJGLOKN(PEAFMKHEGLL IDIEOFKIGBL, Guid DDPGCLLGMBN);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HHDFEPLNPMJ(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task PENIGDIMHCO(PEAFMKHEGLL INEKOMJGJNI, PEAFMKHEGLL DELFIACNBGK);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface MOGMDOELMPG
{
	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	Guid KMOMOALBIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JMEJAOFIAGB(NativeList<Guid> JBDLNBHLHGA, NativeList<Guid> PEGGHMLCDBD, NativeList<FixedString64Bytes> AAKLLPFNDDF);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface GHOBGKJAONH
{
	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHOPBJODCOF(List<PEAFMKHEGLL> OKGKOBOKFOD);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBKBCMCFCFN(List<PEAFMKHEGLL> JPJGLGDBOMB);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EGDMDLFGLLH(PEAFMKHEGLL OPOINFAILGB);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NKLPGEGDEBC(PEAFMKHEGLL OPOINFAILGB);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JIANAMFEKOO(PEAFMKHEGLL OPOINFAILGB);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int ACEKPFGHNPL(PEAFMKHEGLL OPOINFAILGB);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MAGIIOOOBDN(PEAFMKHEGLL OPOINFAILGB, int KNHDHKABHEK);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PEAFMKHEGLL PADMHFBHOBB(PEAFMKHEGLL BMDPGIOJOEG);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int JAFPPOCJNAE(PEAFMKHEGLL BMDPGIOJOEG);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PEBAKEHKADG(PEAFMKHEGLL BMDPGIOJOEG, int GIGOEGEHIEJ);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int CIEGJKEADFJ(PEAFMKHEGLL BMDPGIOJOEG);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DIBAFBCPKHC(PEAFMKHEGLL BMDPGIOJOEG, int EMAIGKPHHCK);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HLIHLBHHFNL(PEAFMKHEGLL PKDLIJKOEEE);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CDBNJANDKEJ(PEAFMKHEGLL IDIEOFKIGBL, bool GHKPCGFMEPP);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PFAJHLKCGLN(PEAFMKHEGLL[] BDDJKPADFHM, bool GHKPCGFMEPP);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface MEMBPKACKGM
{
	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	IReadOnlyCollection<OCBOOCIIKII> DHKCMBPDLND
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OPFOACEIPNI(int MEKCIDKBALP, [Out] OCBOOCIIKII ELJHEBAHMEL);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OCBOOCIIKII HCEECPCCDDA(Type HGPIKDLKBHO);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class HKBMMOBDNCB
{
	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2B5A440", Offset = "0x2B59040", VA = "0x182B5A440")]
	public static T AHMJGLPFBJP<T>(this MEMBPKACKGM ECPPHLPJLHL, Entity AOPPIDPOGKL) where T : struct, IGMHMGEDMIG
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2B5A4F0", Offset = "0x2B590F0", VA = "0x182B5A4F0")]
	public static OCBOOCIIKII HCEECPCCDDA<T>(this MEMBPKACKGM ECPPHLPJLHL) where T : struct, IGMHMGEDMIG
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface KDFFENJGPJB
{
	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FBKGLLHAOCB[] AKPLGAABLJO(string LONKACOOPGJ, KNGFJCECCLB HANOEADEEDL, bool HCJFAMAIBBA = false);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKFAGPMKOAA(string MGAAGEAKAIC, FBKGLLHAOCB[] GNKLEMOMGKC);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface OAIJMCPCDPL
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<PEAFMKHEGLL, PEAFMKHEGLL> IEEOABPFLDI;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<PEAFMKHEGLL, PEAFMKHEGLL> CJNGIEAFHOE;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<PEAFMKHEGLL, PEAFMKHEGLL, PEAFMKHEGLL> HEIFCDMOCFP;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<PEAFMKHEGLL> EKDECJGMDBL;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NPFKJOODGMG(PEAFMKHEGLL IDIEOFKIGBL, PEAFMKHEGLL KLLNIJEHEBO);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PEAFMKHEGLL HAPLPFIPBMN(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<PEAFMKHEGLL> MGDHOMMEPPL(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PEAFMKHEGLL IFLOJKPJEBK(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CHFMKHCGCLE(PEAFMKHEGLL IDIEOFKIGBL, Vector3 BHCAFIHIHOH, Quaternion MCACAMOJANL);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GKMNDNJCJCJ(PEAFMKHEGLL IDIEOFKIGBL, float FIPJKJHLJML);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool HGAGMMADMHN(PEAFMKHEGLL IDIEOFKIGBL, [Out] PEAFMKHEGLL DELFIACNBGK);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool FFBKEOLEFEP(PEAFMKHEGLL IDIEOFKIGBL, [Out] RigidTransform NMAKHJJGIJA);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool DDJCGCAEPOG(PEAFMKHEGLL IDIEOFKIGBL, [Out] float DKGHCFAHEEF);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 BHPIJAIIGBH(MEOGFGIKLDO LMEMAJDKKED);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion CBKIMDPEOND(MEOGFGIKLDO LMEMAJDKKED);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class EOHKOEFCPKG
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface NJGFJDKFHKB
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	object FJPEJPPBICL
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCEKLEPBFNP(KPCKLPGBLFP BDDJKPADFHM);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct AILCMAFNNMD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly string LONKACOOPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly T APDNGABBFBA;

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x3D30E00", Offset = "0x3D2FA00", VA = "0x183D30E00")]
	public AILCMAFNNMD(T APDNGABBFBA, [Optional][CallerMemberName] string LONKACOOPGJ)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public static readonly AILCMAFNNMD<int> MMBPPLFPDLB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public enum IDDKAOFAEHE
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class DLMOFKGLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0xD89F80", Offset = "0xD88B80", VA = "0x180D89F80")]
	public static bool KBAJHLBHJNH(this IDDKAOFAEHE FFBJIDDDHKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0xD89F70", Offset = "0xD88B70", VA = "0x180D89F70")]
	public static bool BOKCAHKBPPO(this IDDKAOFAEHE FFBJIDDDHKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x25568F0", Offset = "0x25554F0", VA = "0x1825568F0")]
	public static bool NEGGFBONEFM(this IDDKAOFAEHE FFBJIDDDHKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface EPFCHKEJEID
{
	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	bool DCFCMPGMHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface CJCGPBOHHJH
{
	[Cpp2IlInjected.Token(Token = "0x17000180")]
	IDDKAOFAEHE DDNJAPLBLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	IDDKAOFAEHE LIMAJKMFJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	IDDKAOFAEHE FEPLHPFJIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	IDDKAOFAEHE MIOJBJMJHHE
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	IDDKAOFAEHE OGMNCHEFKPG
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	IDDKAOFAEHE AJKHHOGDGPM
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	IDDKAOFAEHE PBCLEMOOMOD
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	IDDKAOFAEHE PCNHEHLHNEH
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	IDDKAOFAEHE MGBLFMKJCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	IDDKAOFAEHE EAMEMKIOIAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	IDDKAOFAEHE IPBPEKECBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	IDDKAOFAEHE MBCPNJNMBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	IDDKAOFAEHE BOBDBDGOIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	IDDKAOFAEHE ADJOGONIMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	IDDKAOFAEHE JDOJEFLNIBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OIPGNBHOLEB(AILCMAFNNMD<int> JOKNJOHCHIH);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface CMCFFEGLMCA
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<KECGKEPGMKP> GHJMIJHCGEF;

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PEAFMKHEGLL MGDADEKIEEN(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNANCDDJHBM(List<PEAFMKHEGLL> JPJGLGDBOMB);

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LEBNOFPPBOJ PKANDMEDNBC(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HDJAGAPGPGO(IEnumerable<PEAFMKHEGLL> DEMABOKPFNP);

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LEBNOFPPBOJ LKFJCNAPGMG(PEAFMKHEGLL DELFIACNBGK, PEAFMKHEGLL IOFJKAICIIH, bool BACBMHCEPNL, PEAFMKHEGLL EEOLDJILHGA);

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PEAFMKHEGLL BOCPKBOKCHE(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PNCCPJNBDLO(PEAFMKHEGLL IDIEOFKIGBL, PEAFMKHEGLL DELFIACNBGK, bool OLDAPIKDMMJ);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ADCNHCEIHAJ(PEAFMKHEGLL IDIEOFKIGBL, PEAFMKHEGLL DELFIACNBGK);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool HGEAHCAPIDE(PEAFMKHEGLL DEAGOJOOALH, PEAFMKHEGLL GHFLNAGKECL);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int BDFPOOKINFA(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "12")]
	KPCKLPGBLFP NCCNNNEKKKH(PEAFMKHEGLL PKDLIJKOEEE);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<PEAFMKHEGLL> PAMJLJCDNOM(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool BIJDOOFACBM(PEAFMKHEGLL IDIEOFKIGBL, PEAFMKHEGLL EPCHLNNNIHC);

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<PEAFMKHEGLL> DCPPHKNPKCC(PEAFMKHEGLL IDIEOFKIGBL, bool GAOPBPJBFLK = false);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool KCCKJCMAANI(PEAFMKHEGLL IDIEOFKIGBL, PEAFMKHEGLL DKKIKIJGBAJ);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "17")]
	PEAFMKHEGLL KODJIBIFHBD(PEAFMKHEGLL EEOLDJILHGA, PEAFMKHEGLL FANANEJKNDJ);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool GJDOIECPGDO(PEAFMKHEGLL EEOLDJILHGA, PEAFMKHEGLL FANANEJKNDJ, [Out] PEAFMKHEGLL JINBELGPHMK);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class NJPOMAIJEIF
{
	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB820", Offset = "0x6ADA420", VA = "0x186ADB820")]
	public static List<PEAFMKHEGLL> DNANCDDJHBM(this CMCFFEGLMCA DHCLBOOHAIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB920", Offset = "0x6ADA520", VA = "0x186ADB920")]
	public static bool IGBHMJICOCE(this CMCFFEGLMCA DHCLBOOHAIF, PEAFMKHEGLL IDIEOFKIGBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface NPIAAMNJJPL
{
	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BAFAKCLLDFJ HAFPJLFGNNK(PEAFMKHEGLL OPOINFAILGB);

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APEJFNJBDMP(PEAFMKHEGLL OPOINFAILGB, BAFAKCLLDFJ OBDCAHGLCIJ);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ONFHJKMGIEB(PEAFMKHEGLL OPOINFAILGB);

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KPCODBBDBCH(PEAFMKHEGLL OPOINFAILGB, bool IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string[] OJBEJAKCHDL(PEAFMKHEGLL OPOINFAILGB);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FFOLHAMFFBO(PEAFMKHEGLL OPOINFAILGB, IEnumerable<string> PJNBHAEFPPO);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string[] FHJMDOBPCPB(PEAFMKHEGLL OPOINFAILGB);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HHDDAKIHNEA(PEAFMKHEGLL OPOINFAILGB, IEnumerable<string> PJNBHAEFPPO);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string[] HPMDOCEMKAF(PEAFMKHEGLL OPOINFAILGB);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NDPICLDGMEO(PEAFMKHEGLL OPOINFAILGB, IEnumerable<string> PJNBHAEFPPO);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] BOJKFCHPJEF(PEAFMKHEGLL OPOINFAILGB);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void COLIIDEBPGM(PEAFMKHEGLL OPOINFAILGB, IEnumerable<string> PJNBHAEFPPO);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MPGOEHDOCJB(PEAFMKHEGLL OPOINFAILGB, PEAFMKHEGLL OCPDBKCKFCD);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface AMPPNHLBENL
{
	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	bool LILNFMHJFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	bool HGAONEANHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface BGPIDBKNPBP : JCGIMGFKLLE
{
	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJCNDBBPKNC(Entity AOPPIDPOGKL, [Out] CHEOCCGIGNH MJBLPCEDGPJ);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBMDADINHPL(NativeArray<CHEOCCGIGNH> OGFCEDKDAFA, NativeArray<NHEABNBGDJP> NMFDFKNILIF);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LMMEKMIAFNJ(CHEOCCGIGNH MJBLPCEDGPJ);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FOADMDFDCBG(CHEOCCGIGNH MJBLPCEDGPJ, [Out] Collider PENEDLAGBJG);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface JCGIMGFKLLE
{
	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FCPAJKCPKDJ([In] float3 PPDGJCIMLMA, [In] float3 MLCEOGMBLFG, float DIPNJIGHAJA, Allocator MJBDBDLLDBK, [Out] NativeArray<Entity> PBGFKAHLPAM);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface LFKHPEFHEAF
{
	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FCPAJKCPKDJ([In] float3 PPDGJCIMLMA, [In] float3 MLCEOGMBLFG, float DIPNJIGHAJA, [Out] JDAALIIHFBB CEABDOPCPIJ, [Out] PEAFMKHEGLL BBBOJPMLDLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface JAJBFCEGCCB
{
	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCPAJKCPKDJ([In] NativeArray<Entity> PBGFKAHLPAM, [In] float3 PPDGJCIMLMA, [In] float3 MLCEOGMBLFG, [In] NativeArray<JDAALIIHFBB> KIEHPIPJDPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct CHEOCCGIGNH : PCHGDIKACAK, IEquatable<CHEOCCGIGNH>
{
	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public int ICIBDGPPAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public int PDDGDECCJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x256F310", Offset = "0x256DF10", VA = "0x18256F310", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6600", Offset = "0x5DA5200", VA = "0x185DA6600", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFE50", Offset = "0x6ACEA50", VA = "0x186ACFE50", Slot = "8")]
	public bool Equals(CHEOCCGIGNH HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFEA0", Offset = "0x6ACEAA0", VA = "0x186ACFEA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct JDAALIIHFBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float BENGHNCOGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float3 BCLJLGDCOIN;
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface ANDKAOLLMLL
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface MILLCJNFGCE
{
	[Cpp2IlInjected.Token(Token = "0x17000193")]
	DLGLCBKLECI BLCFABFNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	LBEOGCNNDJK BJPOMKMBCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<KPCKLPGBLFP, NativeArray<EBKFNFACOLI>> COHAMEEFMHB;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<KPCKLPGBLFP> LLCBIKHKLJM;

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EBNDBGDLOPE PFICPLFIJME(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EBKFNFACOLI LFIHGFHOKAO(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NGMFPPEDCJG(FBKGLLHAOCB JNJFNANDEGO, KOEOKJHJALF CGLODONKFEN);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OAOKHCNGDDF(FBKGLLHAOCB[] GNKLEMOMGKC, GameObject OJCNPGOLEHK);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KNGFJCECCLB NFHGJFCGPHF(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FOPCOCKFJLI(PEAFMKHEGLL IDIEOFKIGBL, [Out] Transform MENBKJEFCNP);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FJAAMBOBGLM(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OFJCJHIKCDE(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PEAFMKHEGLL LDDPNMKMNOJ(FBKGLLHAOCB JNJFNANDEGO);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool CLAJBPNOBOA(FBKGLLHAOCB JNJFNANDEGO, [Out] PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FBKGLLHAOCB EFDKABLIFJF(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "17")]
	KPCKLPGBLFP LDDPNMKMNOJ(NativeArray<FBKGLLHAOCB> JNJFNANDEGO, Allocator MJBDBDLLDBK);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	KPCKLPGBLFP KNMNBMDDAKI(EBKFNFACOLI OEBDHGNIACG, int LLHINFJPPOH, Allocator MJBDBDLLDBK);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	KPCKLPGBLFP IAEABMNBOOH(NativeArray<FBKGLLHAOCB> JNJFNANDEGO, NativeArray<ACMNKJMLOOL> MDNEHHPCIPN, Allocator MJBDBDLLDBK);

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	FBKGLLHAOCB[] AKPLGAABLJO(string MGAAGEAKAIC, KNGFJCECCLB HANOEADEEDL, bool HCJFAMAIBBA);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BKFAGPMKOAA(string MGAAGEAKAIC, FBKGLLHAOCB[] GNKLEMOMGKC);

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	KNGFJCECCLB JKNLBEFEIGJ(EBKFNFACOLI OEBDHGNIACG, bool PDDFHKPFFEB);

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	KNGFJCECCLB JKNLBEFEIGJ(EBKFNFACOLI OEBDHGNIACG);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "24")]
	KNGFJCECCLB KAKIPDMCOGD(EBKFNFACOLI OEBDHGNIACG);

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KNGFJCECCLB GJHODAGEIIM(EBKFNFACOLI OEBDHGNIACG);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "26")]
	KNGFJCECCLB CBADLLAEPDJ(FBKGLLHAOCB JNJFNANDEGO, EBKFNFACOLI OEBDHGNIACG);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "27")]
	AKBALEJCBDO ECHBFCLBGHF();

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "28")]
	JGDFBGDAAPD HKLGILHOELK();

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "29")]
	EJHNEPCKNCO DANMMFJPIBC(PPNDJOMCIKD MGBAMGCJHON);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IJIEOMCDDKP(KPCKLPGBLFP BDDJKPADFHM);

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void KHBCMNOGPLL(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void GOIEFPONEEF(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void IJIEOMCDDKP(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void IKDAFMIJEJC(PEAFMKHEGLL BDDJKPADFHM);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool JDDEKJMOBLF(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "36")]
	KPCKLPGBLFP HFCBFAACJOK(KPCKLPGBLFP HAGAPFIEJOM, Allocator MJBDBDLLDBK);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool BCICDOOEJDJ(PEAFMKHEGLL IDIEOFKIGBL);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class OIIGLODMEOI
{
	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD090", Offset = "0x6ADBC90", VA = "0x186ADD090")]
	public static void OFJCJHIKCDE(this MILLCJNFGCE DIDDAJAOOPG, KOEOKJHJALF CGLODONKFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD060", Offset = "0x6ADBC60", VA = "0x186ADD060")]
	public static KNGFJCECCLB PDJHGMDACCA(this MILLCJNFGCE DIDDAJAOOPG, LocalId IDIEOFKIGBL)
	{
		return default(KNGFJCECCLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD110", Offset = "0x6ADBD10", VA = "0x186ADD110")]
	public static KNGFJCECCLB PDJHGMDACCA(this MILLCJNFGCE DIDDAJAOOPG, FBKGLLHAOCB JNJFNANDEGO)
	{
		return default(KNGFJCECCLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD060", Offset = "0x6ADBC60", VA = "0x186ADD060")]
	public static PEAFMKHEGLL LDDPNMKMNOJ(this MILLCJNFGCE DIDDAJAOOPG, LocalId IDIEOFKIGBL)
	{
		return default(PEAFMKHEGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCCF0", Offset = "0x6ADB8F0", VA = "0x186ADCCF0")]
	public static FBKGLLHAOCB EFDKABLIFJF(this MILLCJNFGCE DIDDAJAOOPG, LocalId IDIEOFKIGBL)
	{
		return default(FBKGLLHAOCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCB90", Offset = "0x6ADB790", VA = "0x186ADCB90")]
	public static bool BCICDOOEJDJ(this MILLCJNFGCE DIDDAJAOOPG, FBKGLLHAOCB JNJFNANDEGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5890", Offset = "0x2CD4490", VA = "0x182CD5890")]
	public static T EGGILPACPBM<T>(this MILLCJNFGCE DIDDAJAOOPG, LocalId IDIEOFKIGBL) where T : struct, IGMHMGEDMIG
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCC00", Offset = "0x6ADB800", VA = "0x186ADCC00")]
	public static AKBALEJCBDO DAJPGGNNOHO(this MILLCJNFGCE DIDDAJAOOPG, RigidTransform GFONEHJLJDG)
	{
		return default(AKBALEJCBDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD170", Offset = "0x6ADBD70", VA = "0x186ADD170")]
	public static EJHNEPCKNCO PGCJGDOACBA(this MILLCJNFGCE DIDDAJAOOPG, PPNDJOMCIKD HHJJGHCKFKM, RigidTransform GFONEHJLJDG)
	{
		return default(EJHNEPCKNCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCF70", Offset = "0x6ADBB70", VA = "0x186ADCF70")]
	public static JGDFBGDAAPD FJKCHNMJCHM(this MILLCJNFGCE DIDDAJAOOPG, RigidTransform GFONEHJLJDG)
	{
		return default(JGDFBGDAAPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCD70", Offset = "0x6ADB970", VA = "0x186ADCD70")]
	private static void EFLFHENOLCH(KNGFJCECCLB HHBONKBJGJI, RigidTransform GFONEHJLJDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface KDCLDLEDKND
{
	[Cpp2IlInjected.Token(Token = "0x17000195")]
	bool KAPEMMBHKID
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	PEAFMKHEGLL DFKPHJHPEGN
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	KNGFJCECCLB GJNCEMFLEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event CPMGIAKFKLG GAKMKJIAONH;

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PEAFMKHEGLL KODJIBIFHBD(PEAFMKHEGLL EEOLDJILHGA, PEAFMKHEGLL FANANEJKNDJ);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GJDOIECPGDO(PEAFMKHEGLL EEOLDJILHGA, PEAFMKHEGLL FANANEJKNDJ, [Out] PEAFMKHEGLL JINBELGPHMK);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KBJNNHJFCLC();

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OJOIJCFCLDF();

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool PHCEPFEFHNB(PEAFMKHEGLL EEOLDJILHGA);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MGJCLEGHJLK(PEAFMKHEGLL EEOLDJILHGA);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public delegate void CPMGIAKFKLG(KNGFJCECCLB MIGJKNIGAEA, KNGFJCECCLB MCGGOPKBHBI);
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class DMKLGOHKEAI
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0B60", Offset = "0x6ACF760", VA = "0x186AD0B60")]
	public static bool DJNBJBMDLGJ(this KDCLDLEDKND OKHAAGNOMFJ, KNGFJCECCLB EEOLDJILHGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0BB0", Offset = "0x6ACF7B0", VA = "0x186AD0BB0")]
	public static bool FOLMFANMDDE(this KDCLDLEDKND OKHAAGNOMFJ, PEAFMKHEGLL EEOLDJILHGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0AE0", Offset = "0x6ACF6E0", VA = "0x186AD0AE0")]
	public static bool CPJBOPAOELD(this KDCLDLEDKND OKHAAGNOMFJ, PEAFMKHEGLL EEOLDJILHGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface DGMJOGCAKKG
{
	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADMHEDFIGCL(KNGFJCECCLB HHBONKBJGJI, ENHGDLNCONB DEJLCIIFBAN, List<KNGFJCECCLB> DOEIEBBBAAA);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int AMJEMKPCGMI(KNGFJCECCLB HHBONKBJGJI, ENHGDLNCONB DEJLCIIFBAN);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DOKOPKGFLHD(KNGFJCECCLB HHBONKBJGJI, List<KNGFJCECCLB> DOEIEBBBAAA);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OFNMBPGBNNI(KNGFJCECCLB DJNHJDCMHHE, KNGFJCECCLB EEOLDJILHGA, ENHGDLNCONB DEJLCIIFBAN);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KNGFJCECCLB HLGDHJAPGBD(KNGFJCECCLB DJNHJDCMHHE, int BAEBMIBABAE, ENHGDLNCONB DEJLCIIFBAN);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DOCLADPMHEA(KNGFJCECCLB DJNHJDCMHHE, KNGFJCECCLB EEOLDJILHGA, ENHGDLNCONB DEJLCIIFBAN);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MBHOJFKEMCH(KNGFJCECCLB DJNHJDCMHHE, KNGFJCECCLB EEOLDJILHGA, ENHGDLNCONB DEJLCIIFBAN);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NLBDEHMHNKJ(KNGFJCECCLB DJNHJDCMHHE, ENHGDLNCONB DEJLCIIFBAN);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NMFEIHBIINM(KNGFJCECCLB DJNHJDCMHHE, KNGFJCECCLB EEOLDJILHGA, ENHGDLNCONB DEJLCIIFBAN);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CCADKIKLOPK(Entity DJNHJDCMHHE, Entity EEOLDJILHGA, ENHGDLNCONB DEJLCIIFBAN);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IHINNCFDILB(Entity DJNHJDCMHHE, ENHGDLNCONB DEJLCIIFBAN);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ALNLEIJLPGA(KNGFJCECCLB EEOLDJILHGA, ENHGDLNCONB DEJLCIIFBAN);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface ENOFKJNANEE
{
	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IAILNEENBLG(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FJAFMAFHBMB(PEAFMKHEGLL IDIEOFKIGBL, Transform MENBKJEFCNP);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface CCKGCFEENAF
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INJDBDGCPNP(PEAFMKHEGLL EEOLDJILHGA, PEAFMKHEGLL GFIBDLFJKNJ);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JBDIBAABBBE(PEAFMKHEGLL EEOLDJILHGA, PEAFMKHEGLL JPAOFHCBHNK);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GBCHLLLCDKN(PEAFMKHEGLL EEOLDJILHGA, [Out] PEAFMKHEGLL MGHFJEJDDGH);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface FCDEJMGHBDB
{
	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PECDGMLALMN(PEAFMKHEGLL PKDLIJKOEEE, bool IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDNBGPDINMK(PEAFMKHEGLL PKDLIJKOEEE, bool IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADLJJBHPNDB(PEAFMKHEGLL PKDLIJKOEEE, int IIPLJLPCLBC);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface EBCJHBEGMEO
{
	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<PEAFMKHEGLL> CMCIBGFMBOB(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PEAFMKHEGLL CHIOCKKHENG(PEAFMKHEGLL IDIEOFKIGBL, int BAEBMIBABAE);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int CMCCFHHCMHH(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JCHPNDGNLDH HPBHNMCODIC(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NIAPALGOPNH(PEAFMKHEGLL IDIEOFKIGBL, JCHPNDGNLDH AINJPEDDNEM);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PEAFMKHEGLL JJMJPAIGCKI(PEAFMKHEGLL IDIEOFKIGBL, [Optional] float3? DCDKACDAEIJ, [Optional] quaternion? GPEICHFGELO, [Optional] float3? DANMJNNJDHD);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PEAFMKHEGLL CIOLMDAMEGG(PEAFMKHEGLL IDIEOFKIGBL, int BAEBMIBABAE, [Optional] float3? DCDKACDAEIJ, [Optional] quaternion? GPEICHFGELO, [Optional] float3? DANMJNNJDHD);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OCNJJDHCKHM(PEAFMKHEGLL IDIEOFKIGBL, int BAEBMIBABAE);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LKPJICPNECE(PEAFMKHEGLL IDIEOFKIGBL);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface CLLGFAIMGIL
{
	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCCLIGKLLBK();

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMKCEKKGEDP();

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OKKBBIHALDF();

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HHJCJIECKGL();

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MFHIMBNEFHG();

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MDFNPPGFNJH();

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DPMPJFDJFFK();

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PIGCLDBLMKP();

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AEDECPHNILO();

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IIJOHGHJOKC();

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PBEJIPBMHDJ();

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LKLOCEIJKAA();

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FGMHAMHAJHI();
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface MFGDJEOJOAM
{
	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJGLLBHIFJG(PEAFMKHEGLL EEOLDJILHGA, [Out] int DJNHJDCMHHE);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHHBKBBCOHE(PEAFMKHEGLL EEOLDJILHGA, int DJNHJDCMHHE);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKNHMJGDIBG(PEAFMKHEGLL EEOLDJILHGA, bool NCJAANPMPCE);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AJMIPDLOMII(PEAFMKHEGLL EEOLDJILHGA, bool ENDOBPICEPG);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HPOONGIKPLI(PEAFMKHEGLL EEOLDJILHGA, float EKNIPGDGPJN, float MCHJNNNPGLL, float HEBPDPBGEGM);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FEMPMMGFDBG(PEAFMKHEGLL IDIEOFKIGBL, [Out] float MCHJNNNPGLL, [Out] float HEBPDPBGEGM);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DEOHEDKEPNA(PEAFMKHEGLL EEOLDJILHGA, float3 DCDKACDAEIJ, quaternion GPEICHFGELO);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FNLBOKODHJD(PEAFMKHEGLL EEOLDJILHGA, [Out] float3 DCDKACDAEIJ, [Out] quaternion GPEICHFGELO);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface JPACDLKDDPO
{
	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDDFJAIOMDD(Entity AOPPIDPOGKL);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PELOCLMPBFF(Entity AOPPIDPOGKL, [In] float3 IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 IAHLCCPOAOI(Entity AOPPIDPOGKL);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGKFEJJHPHH(Entity AOPPIDPOGKL, [In] quaternion IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion JMMFCEPJNLI(Entity AOPPIDPOGKL);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NJBBCJDIKPA(Entity AOPPIDPOGKL, [In] float3 DCDKACDAEIJ, [In] quaternion GPEICHFGELO);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DECEGLKKOIJ(Entity AOPPIDPOGKL, [Out] float3 DCDKACDAEIJ, [Out] quaternion GPEICHFGELO);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DECEGLKKOIJ(Entity AOPPIDPOGKL, [Out] RigidTransform NDMPKGIBHEM);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LNPBIBFJKBA(Entity AOPPIDPOGKL, [Out] float3 DCDKACDAEIJ, [Out] quaternion GPEICHFGELO);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LNPBIBFJKBA(Entity AOPPIDPOGKL, [Out] RigidTransform NDMPKGIBHEM);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float3 PNEDEDOHDKH(Entity AOPPIDPOGKL);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KEDLPNHIHCN(Entity AOPPIDPOGKL, [In] float3 IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KAMHBKKGAPC(Entity AOPPIDPOGKL, float IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float LOLCOADGNIA(Entity AOPPIDPOGKL);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LPGCPDOPCMH(Entity AOPPIDPOGKL, [In] float3 IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 DGIDGLDBDGE(Entity AOPPIDPOGKL);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DCFLEAGBHGK(Entity AOPPIDPOGKL, [In] float3 IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 JIKEHGNAEIO(Entity AOPPIDPOGKL);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ABCBCIHLJMM(Entity AOPPIDPOGKL, [In] quaternion IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "19")]
	quaternion LHOBFOAEAAO(Entity AOPPIDPOGKL);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 EHKENKOBBFJ(Entity AOPPIDPOGKL);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IIGPFGCJBMN(Entity AOPPIDPOGKL, [In] float3 IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GMDKNIPAMCM(Entity AOPPIDPOGKL, float IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float POBNMLINGFL(Entity AOPPIDPOGKL);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JIGNENNHHNN(Entity AOPPIDPOGKL, [In] float3 IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float3 BABEMCOGDFN(Entity AOPPIDPOGKL);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CDDBLNBALAP(Entity AOPPIDPOGKL, [Out] float4x4 APILGPEEJFM);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MOGLHKEOJCL(Entity AOPPIDPOGKL, [In] float4x4 APILGPEEJFM);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GGPCILCFMAF(Entity AOPPIDPOGKL, [Out] float4x4 APILGPEEJFM);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool FOPCOCKFJLI(Entity AOPPIDPOGKL, [Out] Transform MENBKJEFCNP);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GMPHPBHFBGO(Entity AOPPIDPOGKL);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void KCHGPKEABBF(Entity AOPPIDPOGKL, Entity GHDBKDKCNKN, Entity EGKBIIFMAKK);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class NBEOJCGKIGO
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface JGDJNNLNPOO
{
	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PLMPEFCNCPD(bool DLFBAKFHOFN);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface FPMEACBBOMC
{
	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADHMCIJEPGK(PEAFMKHEGLL OPOINFAILGB, IEnumerable<string> PJNBHAEFPPO);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGPFHPHFGID(PEAFMKHEGLL OPOINFAILGB, IEnumerable<string> PJNBHAEFPPO);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GJOJGICNOHO(PEAFMKHEGLL OPOINFAILGB, params string[] PJNBHAEFPPO);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DBKPLIDNHKG(PEAFMKHEGLL OPOINFAILGB, params string[] PJNBHAEFPPO);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPJDEODKEPB(PEAFMKHEGLL OPOINFAILGB, params string[] PJNBHAEFPPO);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LPMNNEOIKFG(PEAFMKHEGLL OPOINFAILGB, params string[] PJNBHAEFPPO);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int PGJDKGJPPBF(PEAFMKHEGLL OPOINFAILGB);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int HKNGDEHKOCD(PEAFMKHEGLL OPOINFAILGB);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MAAJHGEDHLA(PEAFMKHEGLL OPOINFAILGB, ICollection<string> NANFAOJNGGH);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MDNJMHHCHKM(PEAFMKHEGLL OPOINFAILGB, ICollection<string> NANFAOJNGGH);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NLAIIEHELJO(PEAFMKHEGLL OPOINFAILGB, string OKKJFMBNHDK);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ELILGNIBOLJ(string OKKJFMBNHDK, NHOLEINKLHA OJNGBKIPOFO);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ANFBOJFMDPP(string OKKJFMBNHDK, NHOLEINKLHA OJNGBKIPOFO);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool GMMJPPHNOGH();

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NFBABPEKKFG(IEnumerable<string> PJNBHAEFPPO);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface NPLBLJNANGH
{
	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World LNGENBNIPJD(string BGLHDKMMKLD = "Main");

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World LDKFNGNEDDL(string BGLHDKMMKLD = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World FBDMNIBHFND(string BGLHDKMMKLD = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World CNELGKMCBIL(string BGLHDKMMKLD = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface FHOGNAOGBDD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000198")]
	World OJEIJAJHGCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	World KNNNGNJHDAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	EntityManager PMCJCDLGBEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	bool DLCDMGIPGPC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase GHBLEBMLNHM(Type HGPIKDLKBHO);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class DJKHCDAPEKE
{
	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x6AD08C0", Offset = "0x6ACF4C0", VA = "0x186AD08C0")]
	public static ComponentSystemBase PPLPDIBJELF(this World PJPKFFPGDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2995900", Offset = "0x2994500", VA = "0x182995900")]
	public static T GHBLEBMLNHM<T>(this FHOGNAOGBDD EFOFCJADDMI) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface HENJPDKCBMI
{
	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBBEENFPOKC(NativeListAsync<Entity> AGNCFNAEFBI);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPCIIEECHDA(EJPBNFKNGNG BKIMKHELEOL);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ALPILFCPHFK(NativeListAsync<Entity> DFIEEEIMDOH, bool DHFCMJHKOEB);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HOBIBDAALHD();
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface HOMJBKNNEAD
{
	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KCEKFHOBHIP(Collider PENEDLAGBJG, [Out] HKPEMOOMPIO JKNPCONEGFP);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface APBMEOLDFNM
{
	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JGLAELCBCIG(PEAFMKHEGLL IDIEOFKIGBL, [Out] Collider PENEDLAGBJG);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject OAHAMBCEGNC(PEAFMKHEGLL LLBFCHHIGFL, GameObject GKHPLJIBDDP, Vector3 PNBKCIFAGHL, Quaternion DIBEOMGKEFO);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLODLDANLBI(GameObject PENEDLAGBJG);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider OPDKMPIEPPG<TCollider>(GameObject HPDFOCPFEEI) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MALJFJBLDDL(Collider PENEDLAGBJG);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject OADCNJDHHPH<TCollider>(string LONKACOOPGJ) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public enum OFEJGAMOCCD
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
[Cpp2IlInjected.Token(Token = "0x200009C")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface BMJEHCHNPCI
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public struct GJNCEOMMCLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int PBOKPCJKDJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GameObject GKHPLJIBDDP;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABBCEODOBEO(PEAFMKHEGLL IDIEOFKIGBL, MPNFGDHDJCH AFLNFKFKGHE, bool NPFJNFFJGHL, DHKMNICNAEB CJFMNLNKLMA);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBKCPDIOHCL(PEAFMKHEGLL IDIEOFKIGBL, MPNFGDHDJCH AFLNFKFKGHE, bool NPFJNFFJGHL, bool EKOEJKOLBAK, bool AEIAMNPOACI);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CLFMKMNAACC HGPKGBFGFMC(PEAFMKHEGLL LNPGMAMPBAC, List<PEAFMKHEGLL> DIEEHOOADNI);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KGFHLFNAMOE(GameObject JIDEGFDJGBP, GameObject JFHFCNJAPNG);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DHHJLIMOKMJ(GameObject JIDEGFDJGBP, [In] GLMBAMGBOHP<GameObject> COFDJDLEDJL);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DLEMLKNJGNC(GameObject JFHFCNJAPNG);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T OPDKMPIEPPG<T>(GameObject HPDFOCPFEEI) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MALJFJBLDDL(Collider PENEDLAGBJG);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GCCPOMPONDJ(KPCKLPGBLFP IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MADMJDHEKHP(KPCKLPGBLFP IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject CDDMJFIFPIK<T>(string LONKACOOPGJ) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IELGLFOHMKD(Collider PENEDLAGBJG, [Out] PEAFMKHEGLL DJNHJDCMHHE);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PBLJLJOJPGP(PEAFMKHEGLL IDIEOFKIGBL, [Out] HKPEMOOMPIO JKNPCONEGFP);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<OFEJGAMOCCD> KMMLFKCIILJ(Allocator MJBDBDLLDBK = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Mesh[] DIGFLCGCDOP();

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int JIJGKIKIODK(MPNFGDHDJCH AFLNFKFKGHE);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string FLJFMHCKDOA(MPNFGDHDJCH AFLNFKFKGHE);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface KFHCBDFANBF
{
	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEHNFNCPIPE(PEAFMKHEGLL IDIEOFKIGBL, PEAFMKHEGLL IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHFKIMOCFLD(PEAFMKHEGLL IDIEOFKIGBL, PEAFMKHEGLL IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BDFPOOKINFA(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PEAFMKHEGLL EBNFKEFJACB(PEAFMKHEGLL IDIEOFKIGBL, int BAEBMIBABAE);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KPCKLPGBLFP DMGCHPFFAIM(PEAFMKHEGLL IDIEOFKIGBL, Allocator MJBDBDLLDBK = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MFGOLCDDLKD(PEAFMKHEGLL IDIEOFKIGBL, object GBENACPKFNA, PEAFMKHEGLL IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LGDFHKOHFNH(PEAFMKHEGLL IDIEOFKIGBL, object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DKPKGNBECMN(PEAFMKHEGLL IDIEOFKIGBL, [Out] PEAFMKHEGLL IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DGDBAHGHING(PEAFMKHEGLL IDIEOFKIGBL, float3 IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HPPEHDEKFGI(PEAFMKHEGLL IDIEOFKIGBL, [Out] float3 IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MBLPPBGNEFC(PEAFMKHEGLL IDIEOFKIGBL, float3 IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IFECCIBDIDF(PEAFMKHEGLL IDIEOFKIGBL, [Out] float3 IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KMMHGANBLOF(PEAFMKHEGLL IDIEOFKIGBL, (Quaternion rot, Vector3 moments) DAKHJKLEMDA);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool GIPHLGIEJHK(PEAFMKHEGLL IDIEOFKIGBL, [Out] quaternion CPJEMABJFPA, [Out] float3 IHBIKHAHGPG);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GCKLHKFIKCP(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 GFHPKHMNOPF(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 ENPLHKIPDEK(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PGDDDBILHDF(PEAFMKHEGLL IDIEOFKIGBL, float3 IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HIJEJJMAHBL(PEAFMKHEGLL IDIEOFKIGBL, float3 IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float LOHKEHPCBMC(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float KGMMFEIHLLE(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HJPKGHLIFFG(PEAFMKHEGLL IDIEOFKIGBL, float IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void AGPHLAJEGMC(PEAFMKHEGLL IDIEOFKIGBL, float IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode ONGAAAMGPIO(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EAAAPGOGOCD(PEAFMKHEGLL IDIEOFKIGBL, CollisionDetectionMode IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LHFCBMFLLBG IAGHJNIOAOG(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NAOLIFIMLPN(PEAFMKHEGLL IDIEOFKIGBL, LHFCBMFLLBG IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool FFMNFHGGCAL(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void PMEBDCBDMGM(PEAFMKHEGLL IDIEOFKIGBL, bool IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "29")]
	PEAFMKHEGLL MGDADEKIEEN(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void OFMDFMBDIGK(PEAFMKHEGLL IDIEOFKIGBL, PEAFMKHEGLL IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "31")]
	PEAFMKHEGLL BOCPKBOKCHE(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void PNCCPJNBDLO(PEAFMKHEGLL IDIEOFKIGBL, PEAFMKHEGLL IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "33")]
	GPOLNCCKNBK CNDGEAJIPJA(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void PJKNAIPLDKG(PEAFMKHEGLL IDIEOFKIGBL, GPOLNCCKNBK NKHEJILBBLG);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool PINNLKIFKDP(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void BEJHNJPNHNP(PEAFMKHEGLL IDIEOFKIGBL, bool IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool EIDLIMOJKJP(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void FCBNNPHEHOJ(PEAFMKHEGLL IDIEOFKIGBL, bool IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints BJHFKDEJPOA(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void NANJJGNHKJG(PEAFMKHEGLL IDIEOFKIGBL, RigidbodyConstraints IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float PGGJJKIBGKC(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void IIDAJMPCJJH(PEAFMKHEGLL IDIEOFKIGBL, float IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float DFBGJCMPHPJ(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void KDMJFAFHDHJ(PEAFMKHEGLL IDIEOFKIGBL, float IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool PMPNOCOFLCG(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void LKMOGKILGHB(PEAFMKHEGLL IDIEOFKIGBL, bool IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool MFKLENJCGLK(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void DPIMPGCMCKG(PEAFMKHEGLL IDIEOFKIGBL, bool IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void BMOFABDIEDA(PEAFMKHEGLL IDIEOFKIGBL, int IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "50")]
	INHEMIHIBFP DBHJFEKCCNC(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void LJFPHKNLFDG(PEAFMKHEGLL IDIEOFKIGBL, INHEMIHIBFP IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "52")]
	EDACBNCGKFK PBHKKEAPMBN(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void MPDPNJPCFJE(PEAFMKHEGLL IDIEOFKIGBL, EDACBNCGKFK IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float HGHCGPNHLND(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void EGCNPGKMDDN(PEAFMKHEGLL IDIEOFKIGBL, float IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void PMAINANINEB(PEAFMKHEGLL IDIEOFKIGBL, object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void OHALAFBLKNE(PEAFMKHEGLL IDIEOFKIGBL, object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool GCNALPMNPBN(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void EGDFAEKGGBA(PEAFMKHEGLL IDIEOFKIGBL, object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void BPFLPKOKDHN(PEAFMKHEGLL IDIEOFKIGBL, object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool PGBONKIFGHP(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool MBOCFHJLODB(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody BGGKBFMOGCP(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void JGNMOAHHHPK(PEAFMKHEGLL IDIEOFKIGBL, Rigidbody IGFNCGLOHFM);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void ILHOGPAMLOI(PEAFMKHEGLL IDIEOFKIGBL, object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void DFNPFAMILKL(PEAFMKHEGLL IDIEOFKIGBL, object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool NFKHAAHPENO(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void NJDKOANMEEA(PEAFMKHEGLL IDIEOFKIGBL, float3 IFAKEJMGKPK);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void MCPMFHFKJOE(PEAFMKHEGLL IDIEOFKIGBL, float3 EGKIANADJEO);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool HBNLDGHJIGB(PEAFMKHEGLL IDIEOFKIGBL, [Out] float3 IFAKEJMGKPK);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool GJAHKDGCEAI(PEAFMKHEGLL IDIEOFKIGBL, [Out] float3 EGKIANADJEO);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool PHMLJIAJDCC(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void OKPIKLGGIOG(PEAFMKHEGLL IDIEOFKIGBL, object GBENACPKFNA, bool KBFDDAHABNO);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void OMEKNHGEGEF(PEAFMKHEGLL IDIEOFKIGBL, bool BJMBCDFNBFE);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void CMGDBOIBMJF(PEAFMKHEGLL IDIEOFKIGBL);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool HDMAMLOPGND(PEAFMKHEGLL IDIEOFKIGBL);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface KGDPKPOOFPL
{
	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMKCJNHDPOK(Entity FDNLFPMMJGE);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MIMJAHAEDNC(Entity FDNLFPMMJGE);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface IJDOGAIGDNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMOKDENPJOK(PEAFMKHEGLL EEOLDJILHGA, bool ILGEHEKPMNK);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BLLJLKIANHC(PEAFMKHEGLL EEOLDJILHGA, int OAINFFFHFMB);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public delegate void POPOGCFBGHI(GKMNENFCNLC LNKPADLMPGF);
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public readonly struct GKMNENFCNLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly KPCKLPGBLFP BIGEIKNMIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly NativeArray<byte> ENGENJKJCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly NativeArray<byte> FMCKCFBKEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly GJLJEKHEBJD OJLGEGJAMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly int JAPKEEDOKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly Type EIFCIABEDKO;

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public KPCKLPGBLFP KDGCHCIMKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xA8CFC0", Offset = "0xA8BBC0", VA = "0x180A8CFC0")]
		get
		{
			return default(KPCKLPGBLFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1860", Offset = "0x6AD0460", VA = "0x186AD1860")]
	public GKMNENFCNLC(KPCKLPGBLFP BIGEIKNMIKM, NativeArray<byte> ENGENJKJCHN, NativeArray<byte> FMCKCFBKEAB, GJLJEKHEBJD OJLGEGJAMDH, int JAPKEEDOKCF, Type EIFCIABEDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x2B38E00", Offset = "0x2B37A00", VA = "0x182B38E00")]
	public NativeArray<T> NFGNIINJFDE<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x2B38DC0", Offset = "0x2B379C0", VA = "0x182B38DC0")]
	public NativeArray<T> JMFNNAHLAHK<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x2B38E40", Offset = "0x2B37A40", VA = "0x182B38E40")]
	public (KPCKLPGBLFP, NativeArray<T>, NativeArray<T>) OIPGNBHOLEB<T>() where T : struct
	{
		return default((KPCKLPGBLFP, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1810", Offset = "0x6AD0410", VA = "0x186AD1810")]
	public KECGKEPGMKP FONLOFJGMCI()
	{
		return default(KECGKEPGMKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface IJKBOCDDHNB
{
	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	string MAIDOLDPCDE
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	IJKBOCDDHNB OHGJIHMIPHA
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	IEnumerable<IJKBOCDDHNB> IFAOFJONDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface AICABOPJMBO
{
	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	IJKBOCDDHNB HMBPBGGKBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	List<OBPGAIGCCCJ> ODNGPFHAKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HAGCNFFKNEO(OBPGAIGCCCJ LPPIGHILDBI, [Out] IJKBOCDDHNB BEIEEDBGEJH);

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGMFPPEDCJG(OBPGAIGCCCJ LPPIGHILDBI, POPOGCFBGHI LHOOFJNFHOP);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JCNGKHJCBAJ(OBPGAIGCCCJ LPPIGHILDBI, POPOGCFBGHI LHOOFJNFHOP);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public readonly struct KECGKEPGMKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly GKMNENFCNLC JGFKFMMOAJO;

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public KPCKLPGBLFP KDGCHCIMKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xA8CFC0", Offset = "0xA8BBC0", VA = "0x180A8CFC0")]
		get
		{
			return default(KPCKLPGBLFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3130", Offset = "0x6AD1D30", VA = "0x186AD3130")]
	public KECGKEPGMKP(GKMNENFCNLC JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2F40", Offset = "0x6AD1B40", VA = "0x186AD2F40")]
	public KPCKLPGBLFP NFGNIINJFDE()
	{
		return default(KPCKLPGBLFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2E70", Offset = "0x6AD1A70", VA = "0x186AD2E70")]
	public KPCKLPGBLFP JMFNNAHLAHK()
	{
		return default(KPCKLPGBLFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3010", Offset = "0x6AD1C10", VA = "0x186AD3010")]
	public (KPCKLPGBLFP, KPCKLPGBLFP, KPCKLPGBLFP) OIPGNBHOLEB()
	{
		return default((KPCKLPGBLFP, KPCKLPGBLFP, KPCKLPGBLFP));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
[DefaultMember("Item")]
public interface LHMKNLDKAOG : IEnumerable<GPEOFHLMMPO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	NativeBitArray FJNGACJPGOH
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	NativeBitArray BJFMDGCEKOL
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	NativeArray<int> JPOFOKKJONJ
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	GPEOFHLMMPO PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	GPEOFHLMMPO PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GPEOFHLMMPO EEBCHPEEGCE(PBLMAPFOOLN FNBFCLGAMDN);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GJLJEKHEBJD PLFAKHLPGLO(PBLMAPFOOLN FNBFCLGAMDN);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class DJGKACPLHLH
{
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[DefaultMember("Item")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface IFJGBKIHLMA : IEnumerable<LFHNLOCMOLI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	LFHNLOCMOLI PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LFHNLOCMOLI EEBCHPEEGCE(PBLMAPFOOLN FNBFCLGAMDN);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GJLJEKHEBJD PLFAKHLPGLO(PBLMAPFOOLN FNBFCLGAMDN);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class EJNEBJAIOGM
{
	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x29E4F00", Offset = "0x29E3B00", VA = "0x1829E4F00")]
	public static GJLJEKHEBJD PLFAKHLPGLO<T>(this IFJGBKIHLMA AKNIKBOBNFK, AKCMCEICDOK<T> LONKACOOPGJ) where T : struct
	{
		return default(GJLJEKHEBJD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[DefaultMember("Item")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface KDCLNCDPIIB : IEnumerable<OBPGAIGCCCJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	OBPGAIGCCCJ PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OBPGAIGCCCJ EEBCHPEEGCE(PBLMAPFOOLN FNBFCLGAMDN);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GJLJEKHEBJD PLFAKHLPGLO(PBLMAPFOOLN FNBFCLGAMDN);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class EJPEHPFDOGL
{
	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x29E54A0", Offset = "0x29E40A0", VA = "0x1829E54A0")]
	public static HLFMGIFMPBB<T> EEBCHPEEGCE<T>(this KDCLNCDPIIB AKNIKBOBNFK, PBLMAPFOOLN LONKACOOPGJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x29E55E0", Offset = "0x29E41E0", VA = "0x1829E55E0")]
	public static GJLJEKHEBJD PLFAKHLPGLO<T>(this KDCLNCDPIIB AKNIKBOBNFK, AKCMCEICDOK<T> LONKACOOPGJ) where T : struct
	{
		return default(GJLJEKHEBJD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface OCPLLHNHGPO
{
	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGMFPPEDCJG(PBLMAPFOOLN LPPIGHILDBI, POPOGCFBGHI LHOOFJNFHOP);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCNGKHJCBAJ(PBLMAPFOOLN LPPIGHILDBI, POPOGCFBGHI LHOOFJNFHOP);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class LBDDPJNECOM
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x2BFA9C0", Offset = "0x2BF95C0", VA = "0x182BFA9C0")]
	public static void NGMFPPEDCJG<T>(this OCPLLHNHGPO OFGGNHMCLCN, AKCMCEICDOK<T> LPPIGHILDBI, POPOGCFBGHI LHOOFJNFHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x2BFA630", Offset = "0x2BF9230", VA = "0x182BFA630")]
	public static void JCNGKHJCBAJ<T>(this OCPLLHNHGPO OFGGNHMCLCN, AKCMCEICDOK<T> LPPIGHILDBI, POPOGCFBGHI LHOOFJNFHOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface EFECOFPPGCA
{
	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	AHOENICFKBC BMCJGOGKLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IBAIPAPPOPG(FBKGLLHAOCB JNJFNANDEGO, GJLJEKHEBJD LPPIGHILDBI);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKBLJGFJHLB(FBKGLLHAOCB JNJFNANDEGO, Span<GJLJEKHEBJD> AKNIKBOBNFK, bool AGPOGMJCLLF);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCLCBPBCPMF(NativeArray<FBKGLLHAOCB> GNKLEMOMGKC);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class OKIKNHJIFKM
{
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD270", Offset = "0x6ADBE70", VA = "0x186ADD270")]
	public static void PKBLJGFJHLB(this EFECOFPPGCA ABEBJCGPEJM, FBKGLLHAOCB JNJFNANDEGO, GJLJEKHEBJD LPPIGHILDBI, bool AGPOGMJCLLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public readonly struct AHOENICFKBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NativeBitArray LLNMBLNFFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly NativeParallelHashMap<FBKGLLHAOCB, int> HDABKKDECBO;

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public bool FOKNBPHHGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCB90", Offset = "0x6ACB790", VA = "0x186ACCB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x423A8D0", Offset = "0x42394D0", VA = "0x18423A8D0")]
	public AHOENICFKBC(NativeBitArray LLNMBLNFFJN, NativeParallelHashMap<FBKGLLHAOCB, int> HDABKKDECBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x6ACCBB0", Offset = "0x6ACB7B0", VA = "0x186ACCBB0")]
	public bool IBAIPAPPOPG(FBKGLLHAOCB JNJFNANDEGO, GJLJEKHEBJD LPPIGHILDBI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface ALNFPCPKOBP
{
	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JBNDKGKMEDI(PEAFMKHEGLL IDIEOFKIGBL, IHOAIJPBPNP IIPLJLPCLBC);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface MPFKFCLCLJF
{
	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	FKPBJOFDNBG PKJHOMBOCCI
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface MJIOLBFBJPN
{
	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GOMJFFPGCKB(World PJPKFFPGDHE);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LAOCNPBOIDM(World PJPKFFPGDHE);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase EMHOECHIGEM(World PJPKFFPGDHE);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ANIMABFMJPF(World PJPKFFPGDHE);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HHJAIBPLNPB(World PJPKFFPGDHE);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PONEKGFKJDP(World PJPKFFPGDHE);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[KHCGLFKHKLK(MNBOKCFMODA.LoadInstance)]
public interface OAAHNCPHMEA
{
	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHOGFHEHOCO(PEAFMKHEGLL PKDLIJKOEEE, bool IIPLJLPCLBC);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public readonly struct OFCDOCJBOOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IEnumerable<AOELPJPGLMM> AELEACAABJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IReadOnlyList<GameObject> HEJGPHCJMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IReadOnlyList<int> BHJKBMGDDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly IReadOnlyList<(FBKGLLHAOCB, FBKGLLHAOCB)> FIINKBHFEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly int JDJPKGKBEFI;

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public bool PHIOAAOKLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC6A0", Offset = "0x6ADB2A0", VA = "0x186ADC6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public int KOGDAPECMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x8E1AD0", Offset = "0x8E06D0", VA = "0x1808E1AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public IEnumerable<GameObject> BKKIHLDMMGF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E70", Offset = "0x8D5A70", VA = "0x1808D6E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public IEnumerable<(FBKGLLHAOCB src, FBKGLLHAOCB dst)> DOMNHPLDBDF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC700", Offset = "0x6ADB300", VA = "0x186ADC700")]
	public OFCDOCJBOOA(IEnumerable<AOELPJPGLMM> AELEACAABJM, IReadOnlyList<GameObject> HEJGPHCJMGL, IReadOnlyList<int> BHJKBMGDDCD, IReadOnlyList<(FBKGLLHAOCB src, FBKGLLHAOCB dst)> FIINKBHFEGB, int JDJPKGKBEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC320", Offset = "0x6ADAF20", VA = "0x186ADC320")]
	public (GameObject, int)[] DJOJPPFLAEN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface FKCONCNGCPO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	bool DOHGIPCHLFN
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	bool LDOPNDKGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	DBHJIBAHJAE BGBHMIDIHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	POCOLNBBHAJ NJHGOBEKFHK();

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	POCOLNBBHAJ FEEAIMAEAPC(IEnumerable<PEAFMKHEGLL> BDDJKPADFHM, [In] UniformTRS GPDJOBEMBOL);

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NKELELCFNOO NLOHNCPPDDN(ByteString EADEIPDDJEE);

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AEPKLJKLHKC EIBHDKMGHDN(ByteString HNJEGMGEKFJ, PEAFMKHEGLL DELFIACNBGK, [In] UniformTRS EGANHNCHDDF, NEJJJDAHOHC IOLDKBEMPCL, bool OAEIBMHPHON = true);

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KKOBPPPCOKH();

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OFCDOCJBOOA CBPAFLPPMOJ(IEnumerable<AOELPJPGLMM> AELEACAABJM);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class AGCBEOLBJCG
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface BBBNMOPJLCI
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action LLJKMIMGMPC;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action JCDPDILBAEC;
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public struct ACMNKJMLOOL : OJJNLGDFJIK, IEquatable<ACMNKJMLOOL>
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public static readonly int ABELFHCGLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public EBKFNFACOLI OEBDHGNIACG;

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB660", Offset = "0x6ACA260", VA = "0x186ACB660", Slot = "5")]
	public void GCPIDJEBGBI(HJODIKIPGEG KLAPEMMBNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB590", Offset = "0x6ACA190", VA = "0x186ACB590", Slot = "4")]
	public void CJJBNJOFCID(BDFAIAGABOK PNCAPBLIAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB690", Offset = "0x6ACA290", VA = "0x186ACB690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0xA07AD0", Offset = "0xA066D0", VA = "0x180A07AD0", Slot = "6")]
	public bool Equals(ACMNKJMLOOL HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB5C0", Offset = "0x6ACA1C0", VA = "0x186ACB5C0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct AOELPJPGLMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Guid GBCIBJHFOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public string MGAAGEAKAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Vector3 DCDKACDAEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Quaternion GPEICHFGELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Vector3 DANMJNNJDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int LBJKBBMNGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public Dictionary<string, object> AINJPEDDNEM;

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEB80", Offset = "0x6ACD780", VA = "0x186ACEB80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE9F0", Offset = "0x6ACD5F0", VA = "0x186ACE9F0")]
	private static string KLACMNKDPIE(Dictionary<string, object> JCFGPFAFJCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public enum LAIIPICEDPO
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
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class ONLFEDMHFNM
{
	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0F50", Offset = "0x5EDFB50", VA = "0x185EE0F50")]
	public static bool FCEENNPLLLG(this LAIIPICEDPO HGPIKDLKBHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[Flags]
public enum AHPLMJKGHLE
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
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface AEPKLJKLHKC : DBHJIBAHJAE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	NEJJJDAHOHC LHBMBGPKGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MGFNPLKOLEC();

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKIAHIGBLKM();
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public interface DBHJIBAHJAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	IEnumerable<AOELPJPGLMM> OOFJBDAJPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	OFCDOCJBOOA DDNJNJBGJEL
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	LAIIPICEDPO DOJGHAOJFFO
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	LocalId JGFBCCHCLDF
	{
		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	MDAEPJINHKC NGGGOHPHHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool INOEKLCMBOB(AHPLMJKGHLE KNOHAJMCEPE);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface NEJJJDAHOHC
{
	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NMKMNDEJDPK(Guid IOFJKAICIIH, [Out] Guid EGMKHAEDBDP);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface NKELELCFNOO : DBHJIBAHJAE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[Flags]
public enum PBKNOMICENM
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
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public interface POCOLNBBHAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	MDAEPJINHKC HMHIPALJCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString MIPJNHABMKM();
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public enum DPGPNCNFBNC
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public delegate bool LIHHFHOEJPN(KOFMIAHEABN PGNMDNNEENI, [In] ACJOMMOAIML IIPLJLPCLBC);
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public delegate bool JICLFCDPNAO<T>(KOFMIAHEABN PGNMDNNEENI, [In] T IIPLJLPCLBC);
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface CAGAPABEIBB
{
	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGMFPPEDCJG(GJLJEKHEBJD OJLGEGJAMDH, Type FMOPLEBEHNN, LIHHFHOEJPN BKGLMGGBCDK);

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MOJPKNFIJHM(GJLJEKHEBJD OJLGEGJAMDH, [Out] LIHHFHOEJPN BKGLMGGBCDK);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class DEKONCMIEBG
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class NBOHPGECIKI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public JICLFCDPNAO<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public NBOHPGECIKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x44DC860", Offset = "0x44DB460", VA = "0x1844DC860")]
		internal bool KMPCPFEKHKD(KOFMIAHEABN pendingList, [In] ACJOMMOAIML value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x2994BD0", Offset = "0x29937D0", VA = "0x182994BD0")]
	public static void NGMFPPEDCJG<T>(this CAGAPABEIBB OFGGNHMCLCN, GJLJEKHEBJD OJLGEGJAMDH, JICLFCDPNAO<T> BKGLMGGBCDK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0400", Offset = "0x6ACF000", VA = "0x186AD0400")]
	public static bool OBNKDENIDAC(this CAGAPABEIBB OFGGNHMCLCN, KOFMIAHEABN PGNMDNNEENI, GJLJEKHEBJD OJLGEGJAMDH, [In] ACJOMMOAIML IIPLJLPCLBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface NCJBLPDKOGO
{
	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	uint BHABEMFHCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface KOFMIAHEABN
{
	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFMBBLBBOKB(FBKGLLHAOCB JKKBNNOELLP, GJLJEKHEBJD OJLGEGJAMDH, ReadOnlySpan<byte> KGKMNHAABKB, ReadOnlySpan<byte> AHPLPFPAAJG);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFEIOIAGDPI(FBKGLLHAOCB JKKBNNOELLP, GJLJEKHEBJD OJLGEGJAMDH, ReadOnlySpan<byte> KGKMNHAABKB, ReadOnlySpan<byte> AHPLPFPAAJG);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LLFLCIGFMIN(FBKGLLHAOCB JKKBNNOELLP, GJLJEKHEBJD OJLGEGJAMDH);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MDKFILHMFJM(FBKGLLHAOCB JKKBNNOELLP, GJLJEKHEBJD OJLGEGJAMDH, ReadOnlySpan<byte> AHPLPFPAAJG);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DBFAGBCLJCJ(FBKGLLHAOCB JKKBNNOELLP, GJLJEKHEBJD OJLGEGJAMDH, Span<byte> KGKMNHAABKB, Span<byte> AHPLPFPAAJG);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class DOIMFAPDKBF
{
	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x2998BE0", Offset = "0x29977E0", VA = "0x182998BE0")]
	public static bool DBFAGBCLJCJ<T>(this KOFMIAHEABN JDDBDHLCDNL, FBKGLLHAOCB JKKBNNOELLP, GJLJEKHEBJD OJLGEGJAMDH, [Out] T KGKMNHAABKB, [Out] T AHPLPFPAAJG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x2998DD0", Offset = "0x29979D0", VA = "0x182998DD0")]
	public static bool MDKFILHMFJM<T>(this KOFMIAHEABN JDDBDHLCDNL, FBKGLLHAOCB JKKBNNOELLP, GJLJEKHEBJD OJLGEGJAMDH, T AHPLPFPAAJG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public enum MMHEJHFGHKJ
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
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface BEJDMBDDIEK
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBCFOKHECLN(PGIPBPAMNJO LNMFGKOJMJG, ReadOnlySpan<byte> BHGBMMFNCAD);

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAKNALHLMBB(uint HOMIGNNBMKB, ReadOnlySpan<byte> BHGBMMFNCAD);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CAGFICIMOEG(int MELONOGBNCF);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface JHICBCDGHON
{
	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PGIPBPAMNJO BJIGIMIIHPG(ReadOnlySpan<byte> BHGBMMFNCAD);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface LNBPJEPODPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEJPJGJOOJP(PGIPBPAMNJO NCMHANGAILD, ReadOnlySpan<byte> BHGBMMFNCAD);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNKGLLKEAHG(ReadOnlySpan<PGIPBPAMNJO> JPEBFLLJBHM);
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public struct DFLPEGDENFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public PGIPBPAMNJO LNMFGKOJMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public ReadOnlyMemory<byte> BHGBMMFNCAD;
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public struct PGIPBPAMNJO
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static PGIPBPAMNJO IBDNNNOBFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public uint CKOADLAGGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public int HCDGKDFFAFJ;

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0xC51CA0", Offset = "0xC508A0", VA = "0x180C51CA0")]
	public PGIPBPAMNJO(uint CKOADLAGGBG, int HCDGKDFFAFJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF280", Offset = "0x6ADDE80", VA = "0x186ADF280")]
	public static bool IGDKJEPDLHP([In] PGIPBPAMNJO HFIDNJCGLJB, [In] PGIPBPAMNJO MGPFNHKFBHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF1A0", Offset = "0x6ADDDA0", VA = "0x186ADF1A0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF250", Offset = "0x6ADDE50", VA = "0x186ADF250", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF2B0", Offset = "0x6ADDEB0", VA = "0x186ADF2B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF2A0", Offset = "0x6ADDEA0", VA = "0x186ADF2A0")]
	public void LLELCMMKHDC([Out] uint CKOADLAGGBG, [Out] int HCDGKDFFAFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[KHCGLFKHKLK(MNBOKCFMODA.OMRoom)]
public interface HIIJCEPADMM : JMNCNHGDLKH<HIIJCEPADMM>
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LPJAHGPAPEL(GJLJEKHEBJD CABAGOHBNFK, [Out] BEBENICMHOJ ELJHEBAHMEL);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public static class FDDFFKEGPDH
{
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public interface BEBENICMHOJ
{
	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	Type MCNOEGGFNNB
	{
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCPIDJEBGBI(HJODIKIPGEG KLAPEMMBNLL, Span<byte> EEOLDJILHGA);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CJJBNJOFCID(BDFAIAGABOK PNCAPBLIAKM, ReadOnlySpan<byte> LNMFGKOJMJG);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public static class COABLGHFGCB
{
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public struct NHEABNBGDJP : ISystemStateComponentData, IComponentData, IEquatable<NHEABNBGDJP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 NJNEJPJNLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3 DLBKGDNBNPH;

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x6ADABF0", Offset = "0x6AD97F0", VA = "0x186ADABF0", Slot = "4")]
	public bool Equals(NHEABNBGDJP HEIGABGMPLJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public class KNEBJPIKILJ
{
	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public KNEBJPIKILJ()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
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
