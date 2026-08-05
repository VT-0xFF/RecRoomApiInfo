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
	public class LogRegistrationIndex : KGHKLAJDNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6300AA0", Offset = "0x62FF8A0", VA = "0x186300AA0", Slot = "4")]
		public override void GEBEKKCKBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LNIHHCJJENL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6300920", Offset = "0x62FF720", VA = "0x186300920")]
	public static void EGGIGHMPIGC(this Rigidbody IBHHKEIHCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x63007F0", Offset = "0x62FF5F0", VA = "0x1863007F0")]
	public static void EGGIGHMPIGC(this Rigidbody IBHHKEIHCOF, Vector3 EJIFMNPJHAH, Quaternion BOGDKECCPFP, Vector3 HJMJPALDILI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct GBACJLHJCCJ : IReadOnlyList<FHFOHBBENOG>, IEnumerable<FHFOHBBENOG>, IEnumerable, IReadOnlyCollection<FHFOHBBENOG>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct KCMAAGBOPOK : IEnumerator<FHFOHBBENOG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly IJAILEKGBDM OIOBKJIDCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator PCKGONCDMJF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FHFOHBBENOG HKCIIOLPAGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6300240", Offset = "0x62FF040", VA = "0x186300240", Slot = "4")]
			get
			{
				return default(FHFOHBBENOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x63001C0", Offset = "0x62FEFC0", VA = "0x1863001C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3DA00A0", Offset = "0x3D9EEA0", VA = "0x183DA00A0")]
		public KCMAAGBOPOK(IJAILEKGBDM OIOBKJIDCCC, NativeArray<LocalId>.Enumerator PCKGONCDMJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6300100", Offset = "0x62FEF00", VA = "0x186300100", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6300140", Offset = "0x62FEF40", VA = "0x186300140", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6300180", Offset = "0x62FEF80", VA = "0x186300180", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly IJAILEKGBDM OIOBKJIDCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> FOHMKIEPADL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FHFOHBBENOG OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62FADE0", Offset = "0x62F9BE0", VA = "0x1862FADE0", Slot = "4")]
		get
		{
			return default(FHFOHBBENOG);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62FA8B0", Offset = "0x62F96B0", VA = "0x1862FA8B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int ICMALEINLPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE110", Offset = "0x7ACF10", VA = "0x1807AE110", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IJAILEKGBDM KECKBJDCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NIBNLPMGPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE110", Offset = "0x7ACF10", VA = "0x1807AE110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JHNGBNKCFFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62FA740", Offset = "0x62F9540", VA = "0x1862FA740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> CAMKEJAJPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2361A00", Offset = "0x2360800", VA = "0x182361A00")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> KPDHOJHKMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x62FA810", Offset = "0x62F9610", VA = "0x1862FA810")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x62FAB90", Offset = "0x62F9990", VA = "0x1862FAB90")]
	public GBACJLHJCCJ(int GIOLCDOMFDF, IJAILEKGBDM OIOBKJIDCCC, Allocator ACBNCIGINAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F980", Offset = "0x3D9E780", VA = "0x183D9F980")]
	public GBACJLHJCCJ(IJAILEKGBDM OIOBKJIDCCC, NativeArray<LocalId> FOHMKIEPADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x62FAD70", Offset = "0x62F9B70", VA = "0x1862FAD70")]
	internal GBACJLHJCCJ(IJAILEKGBDM OIOBKJIDCCC, NativeArray<Entity> EIMPJPDNNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x62FACD0", Offset = "0x62F9AD0", VA = "0x1862FACD0")]
	public GBACJLHJCCJ(IJAILEKGBDM OIOBKJIDCCC, int PDCHCFIOJCE, Allocator ACBNCIGINAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x62FAC20", Offset = "0x62F9A20", VA = "0x1862FAC20")]
	public GBACJLHJCCJ(GBACJLHJCCJ LIBOPJIPFLB, Allocator ACBNCIGINAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x62FA900", Offset = "0x62F9700", VA = "0x1862FA900")]
	public GBACJLHJCCJ KKGLAFBLIAH(Allocator ACBNCIGINAO = Allocator.Temp)
	{
		return default(GBACJLHJCCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x62FA870", Offset = "0x62F9670", VA = "0x1862FA870", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62FA780", Offset = "0x62F9580", VA = "0x1862FA780")]
	public KCMAAGBOPOK CNEJODDGPIM()
	{
		return default(KCMAAGBOPOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62FA9B0", Offset = "0x62F97B0", VA = "0x1862FA9B0", Slot = "6")]
	private IEnumerator<FHFOHBBENOG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62FAAA0", Offset = "0x62F98A0", VA = "0x1862FAAA0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct CJMBBPDBFJG : IList<FHFOHBBENOG>, ICollection<FHFOHBBENOG>, IEnumerable<FHFOHBBENOG>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct FPAEBABLILL : IEnumerator<FHFOHBBENOG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly IJAILEKGBDM OIOBKJIDCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator PCKGONCDMJF;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FHFOHBBENOG HKCIIOLPAGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x62F8010", Offset = "0x62F6E10", VA = "0x1862F8010", Slot = "4")]
			get
			{
				return default(FHFOHBBENOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x62F7F90", Offset = "0x62F6D90", VA = "0x1862F7F90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3DA00A0", Offset = "0x3D9EEA0", VA = "0x183DA00A0")]
		public FPAEBABLILL(IJAILEKGBDM OIOBKJIDCCC, NativeArray<LocalId>.Enumerator PCKGONCDMJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x62F7ED0", Offset = "0x62F6CD0", VA = "0x1862F7ED0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x62F7F10", Offset = "0x62F6D10", VA = "0x1862F7F10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62F7F50", Offset = "0x62F6D50", VA = "0x1862F7F50", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IJAILEKGBDM OIOBKJIDCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> FOHMKIEPADL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FHFOHBBENOG OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x62F4640", Offset = "0x62F3440", VA = "0x1862F4640", Slot = "4")]
		get
		{
			return default(FHFOHBBENOG);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x62F46C0", Offset = "0x62F34C0", VA = "0x1862F46C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x62F40B0", Offset = "0x62F2EB0", VA = "0x1862F40B0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NIBNLPMGPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x62F40B0", Offset = "0x62F2EB0", VA = "0x1862F40B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool LIIHEFGBOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x62F45B0", Offset = "0x62F33B0", VA = "0x1862F45B0")]
	public CJMBBPDBFJG(IJAILEKGBDM OIOBKJIDCCC, int PDCHCFIOJCE, Allocator ACBNCIGINAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x62F4230", Offset = "0x62F3030", VA = "0x1862F4230")]
	public GBACJLHJCCJ PNHFPFIHDMD()
	{
		return default(GBACJLHJCCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x62F3E50", Offset = "0x62F2C50", VA = "0x1862F3E50", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x62F3E90", Offset = "0x62F2C90", VA = "0x1862F3E90", Slot = "13")]
	public bool Contains(FHFOHBBENOG LMLNLGNPIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x62F3F20", Offset = "0x62F2D20", VA = "0x1862F3F20", Slot = "14")]
	public void CopyTo(FHFOHBBENOG[] OKLABKDOFAF, int GKAEDFLMLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62F3D40", Offset = "0x62F2B40", VA = "0x1862F3D40", Slot = "11")]
	public void Add(FHFOHBBENOG LMLNLGNPIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x62F4180", Offset = "0x62F2F80", VA = "0x1862F4180", Slot = "7")]
	public void Insert(int AELAKOMEEDP, FHFOHBBENOG LMLNLGNPIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x62F4300", Offset = "0x62F3100", VA = "0x1862F4300", Slot = "15")]
	public bool Remove(FHFOHBBENOG LMLNLGNPIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x62F40F0", Offset = "0x62F2EF0", VA = "0x1862F40F0", Slot = "6")]
	public int IndexOf(FHFOHBBENOG LMLNLGNPIDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x62F42B0", Offset = "0x62F30B0", VA = "0x1862F42B0", Slot = "8")]
	public void RemoveAt(int AELAKOMEEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x62F4070", Offset = "0x62F2E70", VA = "0x1862F4070", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x62F3DC0", Offset = "0x62F2BC0", VA = "0x1862F3DC0")]
	public FPAEBABLILL CNEJODDGPIM()
	{
		return default(FPAEBABLILL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x62F43D0", Offset = "0x62F31D0", VA = "0x1862F43D0", Slot = "16")]
	private IEnumerator<FHFOHBBENOG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x62F44C0", Offset = "0x62F32C0", VA = "0x1862F44C0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface NOJGMPCAFBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int NENKKFPKBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> BKJJGLDPEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FHFOHBBENOG DDJCOFHNLIF(FHFOHBBENOG FOHMKIEPADL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OEPEHDNFCDA : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface PDOMNDPODJO : CBALHCGPJCK, FNFHLMDBIJH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool BOHPGLCBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IJALPBALGJA APIAGJAHKDI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BKACOBEBLJG JHCOJGDMGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	BNMPKLDHMJK KCEGDAKCOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	GPBLEENNFLF FDNJDEKBIOE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	DLGOHPEGION JFAOKOGFIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface FNFHLMDBIJH
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool EHLPLJOEEHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface BDKNONFKFOL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDEKFHABAFH(bool DIBNBLEEFNN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface GPBLEENNFLF
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool PLPNGOFDPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GFGGJLMJCMP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFKHKEDBBND(bool CDHMHHFKHDG);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FPJPAECELCC(ByteString FBMAMDNADFD);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HDLABKENIPP();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NNJBIGIEKNO();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OPHEMDAEGIE();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface BNMPKLDHMJK
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	JMJKBBCBMJB APIAGJAHKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	BKACOBEBLJG JHCOJGDMGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	DPNNBMFGGBI ADFBEOFHHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	PDOMNDPODJO KLHKLEEMLDF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	IJAILEKGBDM KECKBJDCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	ILBBHPFHOEM PCLEIHPBPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	OKLKBDPNBKA EGLCKFIKHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IBJLKBJAADP MEEAPGDKGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	NCNEBNMPPBF KBPBGFFOMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MBLNAJFLEGE JAGOJJICMPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	DCMDEHILIEG PHJFDEKBHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	DJHFNNMIKOL ANNPBHDFAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	CDCOGBLHLDK DNJFNMCGLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	HHNFECEIMOO BGACKFCJGNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	DMCJHKLCCGI JGMOJBMMDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	IGPNBFNOFLL BGMOIOICPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	KDIBOGJLGOE CDJJDNDELHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	EHHIPFBKECM JDPCAHADCIG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	FGLILLNEKBP IFPEGJHEGBB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	AENNDMDONBE GGADBFLFIBF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	IMCCDFFGNHE IHHGKHJFNEF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	GMPHDDBFJAH PDNCPINADIH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	FBGJPBGJNBH LCDNHKBPCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	BIFKANEBNBE FLPCCMJECID
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	NEAAOHNMINA CHOBCMJLOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerTypeProxy(typeof(MNKKPDJODHH))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct FHFOHBBENOG : IComparable<FHFOHBBENOG>, IEquatable<FHFOHBBENOG>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly FHFOHBBENOG AKAAHGKNKOG;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int AAICJBCFOMM = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int CLMMFENKPKK = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int IDLCGMPLDBI = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int DKCMBINMEAP = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId BLCHDPHIDBL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IJAILEKGBDM KECKBJDCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62F0B80", Offset = "0x62EF980", VA = "0x1862F0B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public PDOMNDPODJO KLHKLEEMLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62F71F0", Offset = "0x62F5FF0", VA = "0x1862F71F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public LocalId ELLLIJGOLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x62F73C0", Offset = "0x62F61C0", VA = "0x1862F73C0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal DLGOHPEGION JFAOKOGFIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x62F71E0", Offset = "0x62F5FE0", VA = "0x1862F71E0")]
		get
		{
			return default(DLGOHPEGION);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool NKPMKKDPBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62F70A0", Offset = "0x62F5EA0", VA = "0x1862F70A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool NEOGPPFHGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62F7250", Offset = "0x62F6050", VA = "0x1862F7250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x62F7530", Offset = "0x62F6330", VA = "0x1862F7530")]
	public FHFOHBBENOG(IJAILEKGBDM JFPEGMPGIOE, LocalId BLCHDPHIDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
	public CHNELAGJPNB PJKNOKDIEMG()
	{
		return default(CHNELAGJPNB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x62F6DE0", Offset = "0x62F5BE0", VA = "0x1862F6DE0")]
	public static LocalId BPFJNEHKLMP(FHFOHBBENOG FMONLPHFJEM)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x62F6DA0", Offset = "0x62F5BA0", VA = "0x1862F6DA0")]
	public static Entity BPFJNEHKLMP(FHFOHBBENOG FMONLPHFJEM)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x62F72A0", Offset = "0x62F60A0", VA = "0x1862F72A0")]
	public static bool OFKPFEHPLBH(FHFOHBBENOG CGAHKNIFIAB, FHFOHBBENOG CJOKOOBKDLJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x62F2B30", Offset = "0x62F1930", VA = "0x1862F2B30")]
	public static bool CAAJBKCJNPA(FHFOHBBENOG CGAHKNIFIAB, FHFOHBBENOG CJOKOOBKDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x62F7400", Offset = "0x62F6200", VA = "0x1862F7400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x62F6F00", Offset = "0x62F5D00", VA = "0x1862F6F00", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x62F6E20", Offset = "0x62F5C20", VA = "0x1862F6E20", Slot = "4")]
	public int CompareTo(FHFOHBBENOG GGINNHLAMLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "5")]
	public bool Equals(FHFOHBBENOG GGINNHLAMLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KKANKOCIHKF
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x63006B0", Offset = "0x62FF4B0", VA = "0x1863006B0")]
	public static KHKDIBBPDLL KCBJLBNLHAE(this FHFOHBBENOG EIFMADKIHON)
	{
		return default(KHKDIBBPDLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x63005F0", Offset = "0x62FF3F0", VA = "0x1863005F0")]
	public static CHNELAGJPNB IHMPNEIAMDN(this FHFOHBBENOG EIFMADKIHON, [Optional] object ADNDMAGEPOK)
	{
		return default(CHNELAGJPNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x294D5D0", Offset = "0x294C3D0", VA = "0x18294D5D0")]
	public static T GJNJCNHAAOE<T>(this FHFOHBBENOG EIFMADKIHON) where T : struct, MJIDKPGONBF
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class MNKKPDJODHH
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct DLGOHPEGION : IEquatable<DLGOHPEGION>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte GMPBFHBNPFC;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] LFGFBILIGAL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static IJAILEKGBDM GKDFKFBHIGD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static PDOMNDPODJO PGMLEBKABGO;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static IJAILEKGBDM[] DBMDHFKIGPN;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static PDOMNDPODJO[] ELPKMGCBPBG;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> IDFKFELEPIL;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public PDOMNDPODJO KLHKLEEMLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x62F6240", Offset = "0x62F5040", VA = "0x1862F6240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IJAILEKGBDM HBDGPMABPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x62F6750", Offset = "0x62F5550", VA = "0x1862F6750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x62F68F0", Offset = "0x62F56F0", VA = "0x1862F68F0")]
	static DLGOHPEGION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xCAAFD0", Offset = "0xCA9DD0", VA = "0x180CAAFD0")]
	internal DLGOHPEGION(byte DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x54F6160", Offset = "0x54F4F60", VA = "0x1854F6160", Slot = "4")]
	public bool Equals(DLGOHPEGION GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x62F5E80", Offset = "0x62F4C80", VA = "0x1862F5E80", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1B8FDB0", Offset = "0x1B8EBB0", VA = "0x181B8FDB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x62F6830", Offset = "0x62F5630", VA = "0x1862F6830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x62F5BF0", Offset = "0x62F49F0", VA = "0x1862F5BF0")]
	private static IJAILEKGBDM CHNNGAOEHFE(byte GMPBFHBNPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x62F6330", Offset = "0x62F5130", VA = "0x1862F6330")]
	private static PDOMNDPODJO KIHHIJAELBO(byte GMPBFHBNPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x62F5A90", Offset = "0x62F4890", VA = "0x1862F5A90")]
	private static object BOGKMBJHFNE(byte GMPBFHBNPFC, object[] NIEBKKPIOLC, object OPPINNBBHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x62F63D0", Offset = "0x62F51D0", VA = "0x1862F63D0")]
	private static int KJGAINBHMJG(byte GMPBFHBNPFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x62F6740", Offset = "0x62F5540", VA = "0x1862F6740")]
	private static int LLCANGLOPHL(byte GMPBFHBNPFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x62F5F20", Offset = "0x62F4D20", VA = "0x1862F5F20")]
	private static (int, int) GDLDNIDFKBM(byte GMPBFHBNPFC)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x62F6320", Offset = "0x62F5120", VA = "0x1862F6320")]
	private static byte JPHEDPHNOFJ(int MIJEJKOAIDK, int AELAKOMEEDP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x62F5FA0", Offset = "0x62F4DA0", VA = "0x1862F5FA0")]
	internal static DLGOHPEGION GEBEKKCKBFI(PDOMNDPODJO GHDIEJIAKBO, IJAILEKGBDM DAEPDBHDIPH)
	{
		return default(DLGOHPEGION);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x62F5C90", Offset = "0x62F4A90", VA = "0x1862F5C90")]
	internal static void CMPPHHJCDAF(DLGOHPEGION GMPBFHBNPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x62F63E0", Offset = "0x62F51E0", VA = "0x1862F63E0")]
	private static void LGGEDFALGPH(int GIOLCDOMFDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface BPBDAMCNBFL
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNADLCOMILH();

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKPFJGFIIKI(bool ECBELOMPMPD);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PHLJJKGJFIK(GameObject EBIGFKEAJMH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface KKIMKLOKIIH
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	Guid ENBDAKIOFOC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KHKEHIIHHHN(Guid EPFMKDBMGPD, Guid EIDEKCAFFFI);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task BDDFNMKJCPK(FHFOHBBENOG BAGNLLAJDGP);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MDGMPLMGFPE(FHFOHBBENOG APEMCPNHEOP, FHFOHBBENOG OGCHMLDLLMJ, [Out] Vector3 KNKOADKCJLL, [Out] Quaternion PJAOGCBLNOI);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HPAJGNHFEMH(IHEMLNFMDJB PCNBGPOCAJP, Vector3 KNKOADKCJLL, Quaternion PJAOGCBLNOI);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IFEOPHBMNBM(FHFOHBBENOG FPJANNGMIGM, [Out] Vector3 KBKKLAKLLEO, [Out] Quaternion KJJMEGENABM);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface EABGOGJDIGO
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICMIEAPBCFF(GBACJLHJCCJ FOHMKIEPADL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface KLDEMDKHIGH
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMFGFCKEBKC(GameObject GOKBMMEGOKN, GameObject FNGGIFEBMLB, int DLGPHLDHJHI);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface BKACOBEBLJG
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	BPBDAMCNBFL NFFNEAOLHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	DEEGIEEIGNI PJBJDDOIGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	JPAKIGFCGPH HNPIKPGLKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	IILMGBLAJDI GDHEGEKCNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	COGIOIBIAFK IJCOOGBOEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	HCNNOJKCONG CJMNHMKHFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	OEAKCNLKGGE MBGGLCHKEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	KMFFPMJFJGK BJGBINNOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface IFAHCDADGJN
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGNLNCJMIDJ(Action GOECALGCLOK, bool CCHJEKHDBDG);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AOPGKDJGBFD(string PHEKPMAPPHM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface DEEGIEEIGNI
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	string BBNECOJINGG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] HEOMABLHDFB(IEnumerable<JOPFHGHIGCL> KKEKLKFCIAO);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BHANPCAJMBI(GameObject EBIGFKEAJMH, [Out] KHKDIBBPDLL[] EDMAHOLJFKG);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PPIBCGMJAAI(GameObject EBIGFKEAJMH, [Out] int MJJKAMGHOLN, [Out] LGNBEHGCHLL MIEPJJBHNJD);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GKDNGLPPHAE FKAKADKLKMM(JOPFHGHIGCL AIAKOJMKOGA);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GKDNGLPPHAE FKAKADKLKMM(string IOAKLAMDNKM, KHKDIBBPDLL[] KCJGNECPFBB, Vector3 JPLKOMKCHGP, Quaternion IHHAEIJMAPE, Vector3 HDBPIAOAHOC);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject LCMINEKHFDK(string IOAKLAMDNKM);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FOFHEFJBGBL(GameObject BEHOHMIPOIP, bool PKGLPIFLEIB);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FHPDMMCPFFM(GameObject EBIGFKEAJMH, bool FFHPCEECEMJ, bool JLDPOLEGIID);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class GMFIENKMDKF
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x62FB0C0", Offset = "0x62F9EC0", VA = "0x1862FB0C0")]
	public static GKDNGLPPHAE FKAKADKLKMM(this DEEGIEEIGNI EEEILKJFPBG, Vector3 JPLKOMKCHGP, Quaternion IHHAEIJMAPE, Vector3 HDBPIAOAHOC, params KHKDIBBPDLL[] EDMAHOLJFKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface JPAKIGFCGPH
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFNELGPLNNJ(bool CDHMHHFKHDG);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface IILMGBLAJDI
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool CNOOCFHMKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool KIIMIIMONHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool KHGLODEHEOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int JFDKKPNKHGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DBGOOIAAEFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GALHCDFHEDH(object PENMOOOPINK);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FBLNBGCLNKK(object PENMOOOPINK);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PALPFJBHOPA(object KCDBINENHAL);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LDBJLHFHPAF(object KCDBINENHAL);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int NOBFPBHPBJP(GameObject ICOCFNDGAFN);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JNMCAKJNEPC(NativeArray<int> INLIPNAJAIN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KKDBGDJPMMC(NativeArray<int> CIFJPCOAEPJ);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BGHFPFNJOMM();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HIPFFPCAHDM(uint KKOLFKPALFD, ReadOnlySpan<byte> PAMPFHDGBIM, bool EJOGJJNMMOH = false);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HIPFFPCAHDM(uint KKOLFKPALFD, ReadOnlySpan<byte> PAMPFHDGBIM, ReadOnlySpan<byte> JDBFAKFNMEC, bool EJOGJJNMMOH = false);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface COGIOIBIAFK
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBBGKHFMHOC(GameObject EBIGFKEAJMH);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface CJDCIALPHPB
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAIIPEFHABC(string HPJAAILCALJ);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface ILLNOOMCDGG
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BHOCHOLJHJG(GameObject EBIGFKEAJMH);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAPHEKMEPOJ(GameObject EBIGFKEAJMH);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HGFPJENNCAF(int EKDOAMOHCJD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object FEIPAAPKIDH(FHFOHBBENOG BLCHDPHIDBL, GameObject EBIGFKEAJMH, Action<FHFOHBBENOG, int> KPIAINDMMOB);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CPJGIJKKCJM(GameObject EBIGFKEAJMH, object BKGPFJBPOCE);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface ONNGHHCOIPC
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool DENACNOGGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate OEPBEBJBALJ(KFECEFAMAOP.KFPBJJFAKOC DKBFBDKCHMC, Action<KFECEFAMAOP.KFPBJJFAKOC> KPIAINDMMOB);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIDPAMHPAHH(KFECEFAMAOP.KFPBJJFAKOC DKBFBDKCHMC, Delegate KPIAINDMMOB);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate EANOFHGLAAF(KFECEFAMAOP.KFPBJJFAKOC DKBFBDKCHMC, Action<KFECEFAMAOP.KFPBJJFAKOC> MNHMEDCNADL);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JBJAOEPAJOB(KFECEFAMAOP.KFPBJJFAKOC DKBFBDKCHMC, Delegate KPIAINDMMOB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NGPEMOIEPKB(KFECEFAMAOP.KFPBJJFAKOC DKBFBDKCHMC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KFECEFAMAOP.KFPBJJFAKOC LFFPEFIFKOO(GameObject EBIGFKEAJMH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface HCNNOJKCONG
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	int MCEEINPKFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	int PAAAGMDCNNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int LODGIAEGNCD(GameObject EBIGFKEAJMH);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MMFMMLNJPEJ([Out] Vector3 JPLKOMKCHGP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KABIEGAHAAE();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface OEAKCNLKGGE
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool PLPNGOFDPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool BBAEOFOJCMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface DIHINICFBAO
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	CEHKEOIGCIL IOBIJJFGCEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	KAAMBAOAABK MAHJPHGGPOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJHNNMGCLMN(Transform AFOLJDADEON);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LACGIEPIGFN(Transform AFOLJDADEON, HHFPIAGHHCN GLOJFOFNFJH);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJJBCGKGIKB(Transform AFOLJDADEON, JLKPHNPIODB DIIKGALEMAO);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface KMFFPMJFJGK
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLPONKGKPJK();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface BGEHJPFCJPL
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGPMMGKPPJO();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface HGNMDFDOBOL
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LGNBEHGCHLL KPPEDPOLKKN(GameObject ICOCFNDGAFN);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJGHNDJNMCK(GameObject EBIGFKEAJMH, BDIGGNJMLKE MILMPJHGOEK, CGMBPBLFFDP GHBDPDBKNKK);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string BOJBGOFPFAE(int NLFEJIHGBIC);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int COHLOFABONK(string FLCDMHECMDI);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AKJPBEGBGMC(FHFOHBBENOG BLCHDPHIDBL, int[] HMMKLKCHIGP);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EDIBKCBAMKH(InteractionFilterData LHODDAGAJKC, int HAEHFCPEDMJ);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PEJPADIBIDE(FHFOHBBENOG BLCHDPHIDBL, int HMMKLKCHIGP);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CPJDDHCBBOG(FHFOHBBENOG BLCHDPHIDBL, int HMMKLKCHIGP);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BLHNOOKMJKB(FHFOHBBENOG BLCHDPHIDBL, bool FFAFCGAFFMI, float3 HBEHEDKDMCJ, quaternion DNPEKBOGJLG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct DIOKNELPJID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly GLJEDOAPIHI GJACDHHHCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly GLJEDOAPIHI NFJLMFFPDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint GCLBKGIOFAH;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x62F5580", Offset = "0x62F4380", VA = "0x1862F5580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct LCMICMCGIEH
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly JNOMMELLEMA LEDKGOEDJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly DIOKNELPJID GOECALGCLOK;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6300760", Offset = "0x62FF560", VA = "0x186300760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct MGGEFKCDDFD
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly JNOMMELLEMA LEDKGOEDJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly DIOKNELPJID GOECALGCLOK;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6300760", Offset = "0x62FF560", VA = "0x186300760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct PPJKGPKEMBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint GCLBKGIOFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool MMEPMAJMEHM;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6302C30", Offset = "0x6301A30", VA = "0x186302C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct GLJEDOAPIHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int PJPGJICIKPG;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x62FAFA0", Offset = "0x62F9DA0", VA = "0x1862FAFA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface ELMIOFODKOF
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	JCJBKALOJPA JFDIADOJFFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum GJKKHCOINFL
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
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface GKDNGLPPHAE : EODPAONOPEP
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	GJKKHCOINFL DGHCCEHDBHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool FDENMNBHPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	GameObject EBIGFKEAJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<GKDNGLPPHAE> ACOGMEIOMIB;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(DPNNBMFGGBI BNCKCALLBDJ, FHFOHBBENOG BKCDJOGPNEN);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool GPKPGAKCHHO);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class GFGBBJOHHKK
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x62FAE20", Offset = "0x62F9C20", VA = "0x1862FAE20")]
	public static bool AMJDKKNJCHE(this GKDNGLPPHAE HPBKPLNBJBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x62FAF50", Offset = "0x62F9D50", VA = "0x1862FAF50")]
	public static bool OFPAGFJAOPB(this GKDNGLPPHAE HPBKPLNBJBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x62FAF00", Offset = "0x62F9D00", VA = "0x1862FAF00")]
	public static bool NAMJKICMIBL(this GKDNGLPPHAE HPBKPLNBJBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x62FAE70", Offset = "0x62F9C70", VA = "0x1862FAE70")]
	public static bool BOHPGLCBGLD(this GKDNGLPPHAE HPBKPLNBJBH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface EODPAONOPEP
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool HLCDKGLKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
internal interface ALOMLCMFNKC
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<IIBHPIOJOII> MOGJCBCCDEI;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface HKHGKFMCJHK
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface IFDDCFKEEOD
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(CJBNPFDPBKJ OKIPMFGBFNK);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface CJBNPFDPBKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	GameObject EBIGFKEAJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Transform AFOLJDADEON
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	AKGHONDNBFH FCBCFEIPFAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool EHMCAKFPMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KPMJPDMIDPB(AKGHONDNBFH LFPEHEIJNLK);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface AKGHONDNBFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Rigidbody KHNHAENIIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	CJBNPFDPBKJ AOLGLPEJIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	GameObject DBBMAMINFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	Transform IBPFDOOAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	AKGHONDNBFH DBLFEIKNGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	AKGHONDNBFH OLBMHECMJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	int GDNKIELLEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool NGPEMOIEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool DMFHGMAJOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	NBCOLHOOHLA LIBEDDGLDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	IPMNNOHAGGH KEDDGLJGBOM
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	float GDDDCPAMJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Vector3 FKLCHNPGOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	Vector3 NGGKALLNEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	Vector3 OONJHIGHOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 MLJDAKDGAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool NNMKFCFPEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool AJJFIHHHDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	bool EHBJIEEACAL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 OOHEKELGNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	Vector3 DGAPEEKADCM
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 KFFPBAIEJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "50")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 MELNCNPPNPL
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float KLOHAEEPJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float COEGFAGDEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 IJNNDDDEEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Quaternion INEHOMGOFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	float OEDBHJNKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float GGIEPMABIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool GEADIDCMMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	KCLBDKBPBDN IEJKKMMOANH
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool AOJAFCMIGNC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Transform HGPOKOHBALD
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 PLJDFINMPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	float GLALHHELIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	float KDADLHAHELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Quaternion HCADLGNAGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Vector3 CBHGHOKJHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Quaternion PEMBIJKPJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	RigidbodyConstraints EFFFCMMEDJH
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool HPEMPGOJNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	CollisionDetectionMode IGMIECLBNLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool HFLBHCECNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event OFINEMEBIAE JMCJLJFFOAF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event OFINEMEBIAE DMEPABNCDPJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event OFINEMEBIAE EENGHCPLOOB;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event OFINEMEBIAE JEHPOLLEKDO;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event OFINEMEBIAE DHPMKMEMJNC;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event OFINEMEBIAE NPPHEFNJOEO;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event OFINEMEBIAE OFALEBHKKAN;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event BPNEMCMFOAO FBGAKAKMMMG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<LJIBDJGPFIC, LJIBDJGPFIC> LKFLKOBHLBB;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "26")]
	AKGHONDNBFH NFGLKOCPPME(int AELAKOMEEDP);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void AOFMFEHAFMM((Quaternion rot, Vector3 moments) HFPKCKDFCCP);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void DOFCKMODMNI();

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void HECDDJLFMJH();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void JEDLMHNBLFF();

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void CJPEANJCFPK();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void CHDAKFMCKBA(AKGHONDNBFH DIBNBLEEFNN, bool OECKDFDIPHD = false);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void AGOPCJCHLOH(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void BKGGLMHLDEI(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 HNHPBBIDOPP(Vector3 FEBEDMALBGL);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 OFLBNPLJECH(Vector3 JJEHMIEJHFH);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void PDLIEDFBGGD();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void NODOGLFFAJJ();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void CNBMLLDKMID();

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void FDEINDINLMA(Vector3 NCHINPMAHPE, Vector3 CNNDEIHAEKF);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void JJLILNLBEND(Vector3 MIOENFHJJMC, Vector3 LKIGCGOOIDL);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void NODLCLEJEMD(Vector3 OHOEONEMMCE);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void MOBOBKOMMJE(NFOPMPPJPBC DAAKAAMCJGM, Vector3 FJPCMFDNDLK, float EALDBOAOAAB, float NLNDBIOAOBP = 8f, float ALNOJOLJNPA = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void FJEPJOKBNPN(OGKHIFLJBDJ LCIAHOMDBIP, Vector3 IPBBPJAIBDM, float EEBGFNENBKN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void PJLACDEEHEJ(OGKHIFLJBDJ LCIAHOMDBIP, Vector3 IHHAEIJMAPE, float LBPGBDGINCH = 7f, float GIGKBFGDMPH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "105")]
	Vector3 FCAGAKMLKIM(Vector3 DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 CHIMGNKOCOK(Vector3 DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void GMCECHADLDH();

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void CMMGKHOPAPA(AKGHONDNBFH MHGCENJIJEI, object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void CLLFKKEHBIC(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void IKHIJIJIIKL();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void BHBBAJNCMJF();

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void DAKLCLKFBEL();

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "113")]
	bool KPKOCFBPGPK();

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void LJGFGFIGPMD();

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void IMPLLPCGDLC(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void MJJHOONEELH(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void ABLEDFOLHJC(object ADNDMAGEPOK, bool GBKJJHMELHF);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void OMKKJNIEPCH(Vector3 KJHMEEOOCAB, Quaternion KHCHBAAGICK);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void AAMKMBIAAOG(Vector3 EPECGJEPBIE, Quaternion AMMFCHMAFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "120")]
	bool OALIGHPAKGD(float HGBKJEFLNMD);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void NJLHEHFMPCD(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void MPGBICNDDCJ(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void EEANEJDDGLP(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void KLIIOIMOEDI(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void IJMLFKJEBEC(Vector3 NLMEJPDDFJD, ForceMode JNAPKOAKBGI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void AOIECACNPKP(Vector3 NLMEJPDDFJD, Vector3 JPLKOMKCHGP, ForceMode JNAPKOAKBGI);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void CKGDGBCNPIJ(Vector3 EFPBPAKGILI, ForceMode JNAPKOAKBGI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void APICNIJKFEF(Vector3 EFPBPAKGILI, ForceMode JNAPKOAKBGI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "129")]
	bool PKFDFPLKPFA(Vector3 BCGALFAPEPA, [Out] RaycastHit HKJCACJKGEK, float OGFHDAHPALD);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void HLHJHEBCDHE();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface IPMNNOHAGGH
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BOJKNKDACCF(Vector3 GDAHOJNIHDJ);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJOBIHONCNN(Vector3 JHCGPEPGKKC);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDKJDFMKFMJ(Vector3 GDAHOJNIHDJ);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MMIGMNMBFMD(Vector3 JHCGPEPGKKC);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface NBCOLHOOHLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 EEGECBKPBGF();

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 GMJBDEAEEMF();
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public delegate void OFINEMEBIAE(CJBNPFDPBKJ JGMBMKEOJCP);
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum JJELFDNPLJK
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ChildAdded,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ChildRemoved,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	HierarchyMassUpdated,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	SleepChanged,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	DistanceBandChanged,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	IsKinematicChanged,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Discontinuity,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Destroyed,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum NFOPMPPJPBC
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public delegate void BPNEMCMFOAO(CJBNPFDPBKJ JGMBMKEOJCP, bool OECKDFDIPHD = false);
[Cpp2IlInjected.Token(Token = "0x200003C")]
public enum OGKHIFLJBDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct FAFMMNEEDEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Rigidbody GDOCMGOHKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object EDFAPFELCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector3 OKCDMFDFCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Vector3 GEBACHONAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public HOHJIBLCPPE OMNCCIOEEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public bool IEFGBGGAPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool FIFNKNIKPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool JFLICEOBANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public bool JLJKLHGMLLJ;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface DCDKOCELNFG : NBIDLCIMEPL<KHKDIBBPDLL>, KAIMHEKEPCE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface DIJLJDHKJDC<T> : DPIBGEHDBEF<KHKDIBBPDLL, T>, NBIDLCIMEPL<KHKDIBBPDLL>, KAIMHEKEPCE, IDisposable, DCDKOCELNFG where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class PGBAOMJCGAD
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x2A50E70", Offset = "0x2A4FC70", VA = "0x182A50E70")]
	public static bool HIBEGIGNEIP<T>(this NBIDLCIMEPL<KHKDIBBPDLL> CINANBNCBIJ, KHKDIBBPDLL KCJGNECPFBB, [Out] T DIBNBLEEFNN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x28E7FF0", Offset = "0x28E6DF0", VA = "0x1828E7FF0")]
	public static bool KNPAMBFMNAD<T>(this NBIDLCIMEPL<KHKDIBBPDLL> CINANBNCBIJ, KHKDIBBPDLL KCJGNECPFBB, [In] T BHCBINIFLAJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface NHLDGMAIICK : NBIDLCIMEPL<FHFOHBBENOG>, KAIMHEKEPCE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface JOBIOIPMDNN<T> : DPIBGEHDBEF<FHFOHBBENOG, T>, NBIDLCIMEPL<FHFOHBBENOG>, KAIMHEKEPCE, IDisposable, NHLDGMAIICK where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class ILGJEDLCBEO
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x269FF90", Offset = "0x269ED90", VA = "0x18269FF90")]
	public static T DJGCEJBDGHO<T>(this NBIDLCIMEPL<FHFOHBBENOG> CINANBNCBIJ, FHFOHBBENOG BLCHDPHIDBL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x28E7FD0", Offset = "0x28E6DD0", VA = "0x1828E7FD0")]
	public static bool KNPAMBFMNAD<T>(this NBIDLCIMEPL<FHFOHBBENOG> CINANBNCBIJ, FHFOHBBENOG BLCHDPHIDBL, [In] T BHCBINIFLAJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct HBHMLHENCBJ : IComparable<HBHMLHENCBJ>, IEquatable<HBHMLHENCBJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly HBHMLHENCBJ AKAAHGKNKOG;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly HBHMLHENCBJ MMKKGGNCHLI;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly HBHMLHENCBJ NLMOAEMBADC;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly HBHMLHENCBJ HFBEOHLPEDC;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly HBHMLHENCBJ KOEKCEMMDCH;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly HBHMLHENCBJ FCCHFIDCIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public int PCBIBNEPCKE;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool PPNGDKCJGGB
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x62FB400", Offset = "0x62FA200", VA = "0x1862FB400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int FPGBGECOECI
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x62FB500", Offset = "0x62FA300", VA = "0x1862FB500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0")]
	public HBHMLHENCBJ(int AELAKOMEEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x62FB4A0", Offset = "0x62FA2A0", VA = "0x1862FB4A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x62FB410", Offset = "0x62FA210", VA = "0x1862FB410", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x888BC0", Offset = "0x8879C0", VA = "0x180888BC0", Slot = "5")]
	public bool Equals(HBHMLHENCBJ GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x18935F0", Offset = "0x18923F0", VA = "0x1818935F0", Slot = "4")]
	public int CompareTo(HBHMLHENCBJ GGINNHLAMLI)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0xD6EEB0", Offset = "0xD6DCB0", VA = "0x180D6EEB0")]
	public static HBHMLHENCBJ BPFJNEHKLMP(int AELAKOMEEDP)
	{
		return default(HBHMLHENCBJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0xD6EEB0", Offset = "0xD6DCB0", VA = "0x180D6EEB0")]
	public static int BPFJNEHKLMP(HBHMLHENCBJ POKGHOJNGNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x62FB510", Offset = "0x62FA310", VA = "0x1862FB510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct CHNELAGJPNB : IEquatable<CHNELAGJPNB>, EODPAONOPEP
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly CHNELAGJPNB ODEBAKMNCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410", Slot = "6")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public GAGKMAKKPLC IBPFDOOAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(GAGKMAKKPLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public DBHDDFHIDOA PCLEIHPBPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(DBHDDFHIDOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private IJAILEKGBDM KECKBJDCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x62F0B80", Offset = "0x62EF980", VA = "0x1862F0B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public GameObject EBIGFKEAJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x62F3A30", Offset = "0x62F2830", VA = "0x1862F3A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public KHKDIBBPDLL LKINHKNGBCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x62F3BC0", Offset = "0x62F29C0", VA = "0x1862F3BC0")]
		get
		{
			return default(KHKDIBBPDLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public GKJFLINHNGP CNHBLCGBHJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x62F3220", Offset = "0x62F2020", VA = "0x1862F3220")]
		get
		{
			return default(GKJFLINHNGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public LGNBEHGCHLL GOEILOKCCBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x62F3940", Offset = "0x62F2740", VA = "0x1862F3940")]
		get
		{
			return default(LGNBEHGCHLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool AAPJJFEHJEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x62F36C0", Offset = "0x62F24C0", VA = "0x1862F36C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool GPJNPKBJJBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x62F3390", Offset = "0x62F2190", VA = "0x1862F3390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool GBNMMGPCIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x62F3550", Offset = "0x62F2350", VA = "0x1862F3550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool IJLNACCGGCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x62F3570", Offset = "0x62F2370", VA = "0x1862F3570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool ODOHIJDCLML
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x62F3870", Offset = "0x62F2670", VA = "0x1862F3870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool OJEBBEJCGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x62F3900", Offset = "0x62F2700", VA = "0x1862F3900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool EOKHCLFMFAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x62F38C0", Offset = "0x62F26C0", VA = "0x1862F38C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool PICFIDLDFKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x62F31E0", Offset = "0x62F1FE0", VA = "0x1862F31E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool EJEKEGGKMGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x62F3440", Offset = "0x62F2240", VA = "0x1862F3440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public JNMFHNHHEEE AIDHBLJDNOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(JNMFHNHHEEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public FBBBALPMKJM IODOOBPPFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(FBBBALPMKJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public BEIGOAMFFNN DNJFNMCGLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(BEIGOAMFFNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public BFCBNPIDEAF EIKDBCBEEJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(BFCBNPIDEAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public AGAEHJJMBDA ANNPBHDFAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(AGAEHJJMBDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public JBDGBGFGDAO JGAKKBIJEON
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(JBDGBGFGDAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public IHEMLNFMDJB MGNAJAFLAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(IHEMLNFMDJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public ICPBPEIJAKJ JCBIAAIPKEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(ICPBPEIJAKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public NKFIBMJCKCH EGALEJJDNJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(NKFIBMJCKCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public NIPNCEFJKLI JLOEGIDAKGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(NIPNCEFJKLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool AMJDKKNJCHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x62F35D0", Offset = "0x62F23D0", VA = "0x1862F35D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool EKODDCDPAPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x62F39E0", Offset = "0x62F27E0", VA = "0x1862F39E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool DPMBIIFLHNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x62F3590", Offset = "0x62F2390", VA = "0x1862F3590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private bool EEKNEFMEMIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public CHNELAGJPNB(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x62F0B60", Offset = "0x62EF960", VA = "0x1862F0B60")]
	public static bool BPFJNEHKLMP(CHNELAGJPNB DIBNBLEEFNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
	public static FHFOHBBENOG BPFJNEHKLMP(CHNELAGJPNB DIBNBLEEFNN)
	{
		return default(FHFOHBBENOG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x62F3A20", Offset = "0x62F2820", VA = "0x1862F3A20")]
	public static bool OFKPFEHPLBH(CHNELAGJPNB CGAHKNIFIAB, CHNELAGJPNB CJOKOOBKDLJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x62F2B30", Offset = "0x62F1930", VA = "0x1862F2B30")]
	public static bool CAAJBKCJNPA(CHNELAGJPNB CGAHKNIFIAB, CHNELAGJPNB CJOKOOBKDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x62F33B0", Offset = "0x62F21B0", VA = "0x1862F33B0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(CHNELAGJPNB GGINNHLAMLI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
	public static CHNELAGJPNB BPFJNEHKLMP(FHFOHBBENOG ACOAKBIHAJJ)
	{
		return default(CHNELAGJPNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x62F3310", Offset = "0x62F2110", VA = "0x1862F3310")]
	public JKMJOEINAFA DELPGMNFPNL()
	{
		return default(JKMJOEINAFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x62F3890", Offset = "0x62F2690", VA = "0x1862F3890")]
	public BIODMPHDLED INILIPIPHNC()
	{
		return default(BIODMPHDLED);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x62F32C0", Offset = "0x62F20C0", VA = "0x1862F32C0")]
	public CLGJEADGJIA DECNJMOILJO()
	{
		return default(CLGJEADGJIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x62F37D0", Offset = "0x62F25D0", VA = "0x1862F37D0")]
	public void IHMPNEIAMDN([Optional] object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x62F36E0", Offset = "0x62F24E0", VA = "0x1862F36E0")]
	public bool IDLBKLLJPNJ(object ADNDMAGEPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x62F3460", Offset = "0x62F2260", VA = "0x1862F3460")]
	public bool FKGPMLBMJIK(object ADNDMAGEPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x62F3C60", Offset = "0x62F2A60", VA = "0x1862F3C60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct IHEMLNFMDJB : IEquatable<IHEMLNFMDJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private IJAILEKGBDM KECKBJDCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x62F0B80", Offset = "0x62EF980", VA = "0x1862F0B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private BNMPKLDHMJK KCEGDAKCOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x62FBE10", Offset = "0x62FAC10", VA = "0x1862FBE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private IGPNBFNOFLL BFMOFNNEJAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x62FBDB0", Offset = "0x62FABB0", VA = "0x1862FBDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool LKKALKLHJMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x62FBA50", Offset = "0x62FA850", VA = "0x1862FBA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public Guid PJFIDPGKAJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x62FC060", Offset = "0x62FAE60", VA = "0x1862FC060")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool JGNEMHJCHJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x62FB930", Offset = "0x62FA730", VA = "0x1862FB930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Guid DFEGFMEFOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x62FBB70", Offset = "0x62FA970", VA = "0x1862FBB70")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public IHEMLNFMDJB(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x62F0B60", Offset = "0x62EF960", VA = "0x1862F0B60")]
	public static bool BPFJNEHKLMP(IHEMLNFMDJB DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x62FBAE0", Offset = "0x62FA8E0", VA = "0x1862FBAE0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(IHEMLNFMDJB GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x62FB890", Offset = "0x62FA690", VA = "0x1862FB890")]
	public bool AANFFIBIHHE([Out] Guid EIJDKKKBCNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x62FBC90", Offset = "0x62FAA90", VA = "0x1862FBC90")]
	public void GBELKAPHMBB(Guid FLOENDBPFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x62FBFC0", Offset = "0x62FADC0", VA = "0x1862FBFC0")]
	public bool MIFPJAAMEIF([Out] Guid NLOKDELMBLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x62FBEA0", Offset = "0x62FACA0", VA = "0x1862FBEA0")]
	public void LPFLOKGGIHH(Guid FLOENDBPFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x62FB9C0", Offset = "0x62FA7C0", VA = "0x1862FB9C0")]
	public void EGLNGIDMFEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct CLGJEADGJIA : IEquatable<CLGJEADGJIA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private IJAILEKGBDM KECKBJDCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x62F0B80", Offset = "0x62EF980", VA = "0x1862F0B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private BNMPKLDHMJK KCEGDAKCOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x62F49C0", Offset = "0x62F37C0", VA = "0x1862F49C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private KDIBOGJLGOE AHOCCFNEBME
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x62F4B90", Offset = "0x62F3990", VA = "0x1862F4B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 ANFOCOMKELP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x62F4750", Offset = "0x62F3550", VA = "0x1862F4750")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion DGDDDOCGPOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x62F4A50", Offset = "0x62F3850", VA = "0x1862F4A50")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public CHNELAGJPNB HOLKBFOJECO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x62F4930", Offset = "0x62F3730", VA = "0x1862F4930")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public CLGJEADGJIA(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
	public static FHFOHBBENOG BPFJNEHKLMP(CLGJEADGJIA DIBNBLEEFNN)
	{
		return default(FHFOHBBENOG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x62F48A0", Offset = "0x62F36A0", VA = "0x1862F48A0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(CLGJEADGJIA GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct JKMJOEINAFA : IEquatable<JKMJOEINAFA>
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly JKMJOEINAFA ODEBAKMNCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public GAGKMAKKPLC IBPFDOOAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(GAGKMAKKPLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public DBHDDFHIDOA PCLEIHPBPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(DBHDDFHIDOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private IJAILEKGBDM KECKBJDCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x62F0B80", Offset = "0x62EF980", VA = "0x1862F0B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private BNMPKLDHMJK KCEGDAKCOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x62FE300", Offset = "0x62FD100", VA = "0x1862FE300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private ILBBHPFHOEM IBMLCDKEHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x62FD7E0", Offset = "0x62FC5E0", VA = "0x1862FD7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public GBACJLHJCCJ EJCAPKIBHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x62FE4D0", Offset = "0x62FD2D0", VA = "0x1862FE4D0")]
		get
		{
			return default(GBACJLHJCCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public IEnumerable<CHNELAGJPNB> PJOPMMGNAII
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x62FCEA0", Offset = "0x62FBCA0", VA = "0x1862FCEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public IEnumerable<CHNELAGJPNB> CNBLAEOBPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x62FD950", Offset = "0x62FC750", VA = "0x1862FD950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int GDNKIELLEMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x62FD5E0", Offset = "0x62FC3E0", VA = "0x1862FD5E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int PCDNBOHMFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x62FE660", Offset = "0x62FD460", VA = "0x1862FE660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x62FCDF0", Offset = "0x62FBBF0", VA = "0x1862FCDF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x62FEDF0", Offset = "0x62FDBF0", VA = "0x1862FEDF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public GENGIDCKDKF AKJEECBIENO
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x62FD510", Offset = "0x62FC310", VA = "0x1862FD510")]
		get
		{
			return default(GENGIDCKDKF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x62FECE0", Offset = "0x62FDAE0", VA = "0x1862FECE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public NBCJNKAOEAB JDFOJFLBBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x62FD840", Offset = "0x62FC640", VA = "0x1862FD840")]
		get
		{
			return default(NBCJNKAOEAB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x62FD3D0", Offset = "0x62FC1D0", VA = "0x1862FD3D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public HINAGPNLPPN HBMJFNOJCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x62FDAF0", Offset = "0x62FC8F0", VA = "0x1862FDAF0")]
		get
		{
			return default(HINAGPNLPPN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x62FE8E0", Offset = "0x62FD6E0", VA = "0x1862FE8E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float EFMBCLBAMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x62FE950", Offset = "0x62FD750", VA = "0x1862FE950")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x62FEC10", Offset = "0x62FDA10", VA = "0x1862FEC10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool NALMHHNEFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x62FDC90", Offset = "0x62FCA90", VA = "0x1862FDC90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x62FE390", Offset = "0x62FD190", VA = "0x1862FE390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool AILEEOLAEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x62FEC80", Offset = "0x62FDA80", VA = "0x1862FEC80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x62FD770", Offset = "0x62FC570", VA = "0x1862FD770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool DCKIPEABADD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x62FD440", Offset = "0x62FC240", VA = "0x1862FD440")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x62FDB50", Offset = "0x62FC950", VA = "0x1862FDB50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool JBEKEPLHODK
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x62FEEA0", Offset = "0x62FDCA0", VA = "0x1862FEEA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x62FE290", Offset = "0x62FD090", VA = "0x1862FE290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool KKANGIKFBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x62FDBC0", Offset = "0x62FC9C0", VA = "0x1862FDBC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x62FE5F0", Offset = "0x62FD3F0", VA = "0x1862FE5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool PAJFKOPKDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x62FD710", Offset = "0x62FC510", VA = "0x1862FD710")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x62FE460", Offset = "0x62FD260", VA = "0x1862FE460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool HJHDMHKCLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x62FE400", Offset = "0x62FD200", VA = "0x1862FE400")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x62FD570", Offset = "0x62FC370", VA = "0x1862FD570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public FCCPAOFFAPB PLKBBDLAIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x62FD000", Offset = "0x62FBE00", VA = "0x1862FD000")]
		get
		{
			return default(FCCPAOFFAPB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x62FD4A0", Offset = "0x62FC2A0", VA = "0x1862FD4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public IEnumerable<int> OEHHPGMGCKM
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x62FED50", Offset = "0x62FDB50", VA = "0x1862FED50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x62FE9B0", Offset = "0x62FD7B0", VA = "0x1862FE9B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public int KEPOAKNEPLG
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x62FD670", Offset = "0x62FC470", VA = "0x1862FD670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public JKMJOEINAFA(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x62F0B60", Offset = "0x62EF960", VA = "0x1862F0B60")]
	public static bool BPFJNEHKLMP(JKMJOEINAFA DIBNBLEEFNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x62F3A20", Offset = "0x62F2820", VA = "0x1862F3A20")]
	public static bool OFKPFEHPLBH(JKMJOEINAFA CGAHKNIFIAB, JKMJOEINAFA CJOKOOBKDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x62FD8C0", Offset = "0x62FC6C0", VA = "0x1862FD8C0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(JKMJOEINAFA GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
	public static CHNELAGJPNB BPFJNEHKLMP(JKMJOEINAFA ILACEKALGJH)
	{
		return default(CHNELAGJPNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x62FD8A0", Offset = "0x62FC6A0", VA = "0x1862FD8A0")]
	public bool EIPPPPJMEJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x62FDC20", Offset = "0x62FCA20", VA = "0x1862FDC20")]
	public bool IDJBIFIPPDC(BAMHMIEKLNG KKMLCJFOHDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x62FDA70", Offset = "0x62FC870", VA = "0x1862FDA70")]
	public void FFJPLOGOLPJ(BAMHMIEKLNG KKMLCJFOHDK, bool DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x62FE6B0", Offset = "0x62FD4B0", VA = "0x1862FE6B0")]
	public GBACJLHJCCJ MJMEKNMLBCH(Allocator ACBNCIGINAO)
	{
		return default(GBACJLHJCCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x62FD060", Offset = "0x62FBE60", VA = "0x1862FD060")]
	public void BLGPCIKEODF(JKMJOEINAFA GGINNHLAMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x62FDCF0", Offset = "0x62FCAF0", VA = "0x1862FDCF0")]
	public void JAMPMCPBMPH(List<CHNELAGJPNB> GFIAAEICMAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct ACIFACKNJIJ : IEquatable<ACIFACKNJIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x62F08B0", Offset = "0x62EF6B0", VA = "0x1862F08B0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(ACIFACKNJIJ GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct FBBBALPMKJM : IEquatable<FBBBALPMKJM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private IJAILEKGBDM KECKBJDCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x62F0B80", Offset = "0x62EF980", VA = "0x1862F0B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public FBBBALPMKJM(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x62F6B30", Offset = "0x62F5930", VA = "0x1862F6B30", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(FBBBALPMKJM GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x62F6D00", Offset = "0x62F5B00", VA = "0x1862F6D00")]
	public void OFGJMFOHKEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x62F6BC0", Offset = "0x62F59C0", VA = "0x1862F6BC0")]
	public void JNHGHMHNMBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x62F6C60", Offset = "0x62F5A60", VA = "0x1862F6C60")]
	public bool MBCBFICOPPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct DBHDDFHIDOA : IEquatable<DBHDDFHIDOA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	private IJAILEKGBDM KECKBJDCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x62F0B80", Offset = "0x62EF980", VA = "0x1862F0B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private BNMPKLDHMJK KCEGDAKCOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x62F5210", Offset = "0x62F4010", VA = "0x1862F5210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private ILBBHPFHOEM IBMLCDKEHJD
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x62F4D80", Offset = "0x62F3B80", VA = "0x1862F4D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public FHFOHBBENOG DJFGLIOJLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x62F5180", Offset = "0x62F3F80", VA = "0x1862F5180")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public CHNELAGJPNB DBLFEIKNGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x62F5450", Offset = "0x62F4250", VA = "0x1862F5450")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public CHNELAGJPNB OLBMHECMJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x62F52A0", Offset = "0x62F40A0", VA = "0x1862F52A0")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public DBHDDFHIDOA(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x62F50F0", Offset = "0x62F3EF0", VA = "0x1862F50F0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(DBHDDFHIDOA GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x62F4BF0", Offset = "0x62F39F0", VA = "0x1862F4BF0")]
	public bool CHDAKFMCKBA(CHNELAGJPNB OGCHMLDLLMJ, bool PNDHGPCFPIM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x62F54E0", Offset = "0x62F42E0", VA = "0x1862F54E0")]
	public bool PJOLCAHGJLG(CHNELAGJPNB DONPBLGNHAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x62F4DE0", Offset = "0x62F3BE0", VA = "0x1862F4DE0")]
	private void EIPPGOMNCKJ(CHNELAGJPNB BAPMOBDIILP, List<CHNELAGJPNB> FMAPPPJJPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x62F5060", Offset = "0x62F3E60", VA = "0x1862F5060")]
	public JKMJOEINAFA EKODIAIBLBP()
	{
		return default(JKMJOEINAFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x62F4D20", Offset = "0x62F3B20", VA = "0x1862F4D20")]
	public void CIBOBLAHKDH(List<CHNELAGJPNB> HILCCCJGCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x62F5330", Offset = "0x62F4130", VA = "0x1862F5330")]
	public NativeArray<FHFOHBBENOG> OMBKIMCKIDL()
	{
		return default(NativeArray<FHFOHBBENOG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct JNMFHNHHEEE : IEquatable<JNMFHNHHEEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public string EMIKMDCGJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x62FF5C0", Offset = "0x62FE3C0", VA = "0x1862FF5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public string LAAJIPHGJBL
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x62FF2B0", Offset = "0x62FE0B0", VA = "0x1862FF2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool KIEADLHLGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x62FEF00", Offset = "0x62FDD00", VA = "0x1862FEF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public string FMICBOFLKEO
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x62FF040", Offset = "0x62FDE40", VA = "0x1862FF040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public string ENPFFOCADLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x62FF370", Offset = "0x62FE170", VA = "0x1862FF370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string KGIKMPCHPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x62FF130", Offset = "0x62FDF30", VA = "0x1862FF130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public JNMFHNHHEEE(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x62FF220", Offset = "0x62FE020", VA = "0x1862FF220", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(JNMFHNHHEEE GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct IOCLDMMGGBG : IEquatable<IOCLDMMGGBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x62FC8C0", Offset = "0x62FB6C0", VA = "0x1862FC8C0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(IOCLDMMGGBG GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct BEIGOAMFFNN : IEquatable<BEIGOAMFFNN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public BEIGOAMFFNN(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x62F16D0", Offset = "0x62F04D0", VA = "0x1862F16D0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(BEIGOAMFFNN GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x62F1760", Offset = "0x62F0560", VA = "0x1862F1760")]
	public bool GDCHJBAMGJI([Out] Collider PLGNHDMELGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct NIPNCEFJKLI : IEquatable<NIPNCEFJKLI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private BIFKANEBNBE LGMLIBBEGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6301950", Offset = "0x6300750", VA = "0x186301950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public NIPNCEFJKLI(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x63018C0", Offset = "0x63006C0", VA = "0x1863018C0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(NIPNCEFJKLI GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6301A10", Offset = "0x6300810", VA = "0x186301A10")]
	public void FHDMBCBBGPN(bool AHMABNFBLLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct BFCBNPIDEAF : IEquatable<BFCBNPIDEAF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private IJAILEKGBDM KECKBJDCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x62F0B80", Offset = "0x62EF980", VA = "0x1862F0B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	private BNMPKLDHMJK KCEGDAKCOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x62F2610", Offset = "0x62F1410", VA = "0x1862F2610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private ObjectPolicyDataWrapper CJBBPOKIDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x62F2120", Offset = "0x62F0F20", VA = "0x1862F2120")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private NavMeshGenerationDataWrapper GLAHCFAOIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x62F27F0", Offset = "0x62F15F0", VA = "0x1862F27F0")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool HCNEIJFMOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x62F2910", Offset = "0x62F1710", VA = "0x1862F2910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public bool EBAJHPHGOLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x62F2470", Offset = "0x62F1270", VA = "0x1862F2470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public bool BLFKIBEMMFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x62F2180", Offset = "0x62F0F80", VA = "0x1862F2180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool GAHDJGDCFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x62F1CB0", Offset = "0x62F0AB0", VA = "0x1862F1CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public bool LKDAFGENNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x62F25A0", Offset = "0x62F13A0", VA = "0x1862F25A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public bool PLHGCMACHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x62F1AF0", Offset = "0x62F08F0", VA = "0x1862F1AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool LLEINKKFGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x62F1A80", Offset = "0x62F0880", VA = "0x1862F1A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public bool BBNHOILNOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x62F1BD0", Offset = "0x62F09D0", VA = "0x1862F1BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool LOKIOHHMKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x62F2710", Offset = "0x62F1510", VA = "0x1862F2710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public bool IPOFFACALHE
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x62F1DA0", Offset = "0x62F0BA0", VA = "0x1862F1DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool GIPALEEJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x62F26A0", Offset = "0x62F14A0", VA = "0x1862F26A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public bool LCGOAIKIAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x62F1E10", Offset = "0x62F0C10", VA = "0x1862F1E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool BBBPIPJEGJA
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x62F20B0", Offset = "0x62F0EB0", VA = "0x1862F20B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool NGAEOOBLPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x62F28B0", Offset = "0x62F16B0", VA = "0x1862F28B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool EOKMHJBDKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x62F19C0", Offset = "0x62F07C0", VA = "0x1862F19C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x62F1B60", Offset = "0x62F0960", VA = "0x1862F1B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public NAPJHHHFHEA FICEHOHNMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x62F2850", Offset = "0x62F1650", VA = "0x1862F2850")]
		get
		{
			return default(NAPJHHHFHEA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x62F2040", Offset = "0x62F0E40", VA = "0x1862F2040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public bool EEGMIGNMCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x62F22A0", Offset = "0x62F10A0", VA = "0x1862F22A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public CGMBPBLFFDP ECGLGAHAPGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x62F1E80", Offset = "0x62F0C80", VA = "0x1862F1E80")]
		get
		{
			return default(CGMBPBLFFDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public bool OLMALFACNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x62F1A20", Offset = "0x62F0820", VA = "0x1862F1A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 JPHEKILFIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x62F24E0", Offset = "0x62F12E0", VA = "0x1862F24E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 GJAPAHFOFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x62F21F0", Offset = "0x62F0FF0", VA = "0x1862F21F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool FHJEMOHDDDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x62F18C0", Offset = "0x62F06C0", VA = "0x1862F18C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public BFCBNPIDEAF(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x62F1FB0", Offset = "0x62F0DB0", VA = "0x1862F1FB0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(BFCBNPIDEAF GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x62F1F40", Offset = "0x62F0D40", VA = "0x1862F1F40")]
	public bool EIPNNKBFHJI(KNGOHHKOPNC KKMLCJFOHDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x62F1C40", Offset = "0x62F0A40", VA = "0x1862F1C40")]
	public bool CJGAJDCKMFL(BDIGGNJMLKE KKMLCJFOHDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x62F1D20", Offset = "0x62F0B20", VA = "0x1862F1D20")]
	public void DCMFFFJOFIJ(BDIGGNJMLKE KKMLCJFOHDK, bool AIBEMFNIBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x62F1EE0", Offset = "0x62F0CE0", VA = "0x1862F1EE0")]
	public BDIGGNJMLKE EIJKBIJPPLN()
	{
		return default(BDIGGNJMLKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x62F2780", Offset = "0x62F1580", VA = "0x1862F2780")]
	public bool KJICCFHCKMN(BDIGGNJMLKE DIBNBLEEFNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct JBDGBGFGDAO : IEquatable<JBDGBGFGDAO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	private IJAILEKGBDM KECKBJDCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x62F0B80", Offset = "0x62EF980", VA = "0x1862F0B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	private BNMPKLDHMJK KCEGDAKCOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x62FCCD0", Offset = "0x62FBAD0", VA = "0x1862FCCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public JBDGBGFGDAO(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x62FCBB0", Offset = "0x62FB9B0", VA = "0x1862FCBB0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(JBDGBGFGDAO GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x62FCD60", Offset = "0x62FBB60", VA = "0x1862FCD60")]
	public void LEBIBKCNDNA(bool DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x62FCC40", Offset = "0x62FBA40", VA = "0x1862FCC40")]
	public void IPBNJADEEDH(bool DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2918040", Offset = "0x2916E40", VA = "0x182918040")]
	public T JHJMDBNIFEJ<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct AGAEHJJMBDA : IEquatable<AGAEHJJMBDA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private IJAILEKGBDM KECKBJDCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x62F0B80", Offset = "0x62EF980", VA = "0x1862F0B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private BNMPKLDHMJK KCEGDAKCOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x62F0E90", Offset = "0x62EFC90", VA = "0x1862F0E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private DJHFNNMIKOL MJAAPFFBPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x62F1310", Offset = "0x62F0110", VA = "0x1862F1310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private AENNDMDONBE GGADBFLFIBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x62F0B00", Offset = "0x62EF900", VA = "0x1862F0B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool LHOLGJOPNBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x62F1370", Offset = "0x62F0170", VA = "0x1862F1370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool MGHLABNFMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x62F0D80", Offset = "0x62EFB80", VA = "0x1862F0D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool EFKFJLBHKFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x62F1530", Offset = "0x62F0330", VA = "0x1862F1530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool PCODFHCBJJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x62F1030", Offset = "0x62EFE30", VA = "0x1862F1030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool HFCHDNKENID
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x62F0A30", Offset = "0x62EF830", VA = "0x1862F0A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool KBBFDMJLDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x62F1400", Offset = "0x62F0200", VA = "0x1862F1400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool OBGPENBJCLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x62F1100", Offset = "0x62EFF00", VA = "0x1862F1100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool KACHKEFMKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x62F1560", Offset = "0x62F0360", VA = "0x1862F1560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public AGAEHJJMBDA(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x62F0B60", Offset = "0x62EF960", VA = "0x1862F0B60")]
	public static bool BPFJNEHKLMP(AGAEHJJMBDA DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x62F0CF0", Offset = "0x62EFAF0", VA = "0x1862F0CF0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(AGAEHJJMBDA GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x62F0E20", Offset = "0x62EFC20", VA = "0x1862F0E20")]
	public bool IIHMNMBANCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x62F0A60", Offset = "0x62EF860", VA = "0x1862F0A60")]
	public CHNELAGJPNB ANLFCNPBPBH(CHNELAGJPNB KCDBINENHAL)
	{
		return default(CHNELAGJPNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x62F0BE0", Offset = "0x62EF9E0", VA = "0x1862F0BE0")]
	public FHFOHBBENOG EJCHBNLPKAC()
	{
		return default(FHFOHBBENOG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x62F0990", Offset = "0x62EF790", VA = "0x1862F0990")]
	public bool AJIKIOHEMPM(FHFOHBBENOG ACBOHCJAIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x62F1490", Offset = "0x62F0290", VA = "0x1862F1490")]
	public bool NFGBDHMGGGB(FHFOHBBENOG MEOEBCJBADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x62F0F20", Offset = "0x62EFD20", VA = "0x1862F0F20")]
	public bool KHDDJBIGGEJ(FHFOHBBENOG KCDBINENHAL, [Out] FHFOHBBENOG ACBOHCJAIIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct BIODMPHDLED : IEquatable<BIODMPHDLED>
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly BIODMPHDLED ODEBAKMNCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public GAGKMAKKPLC IBPFDOOAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(GAGKMAKKPLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private ShapeTypeDataWrapper OAJNHHCHDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x62F2EC0", Offset = "0x62F1CC0", VA = "0x1862F2EC0")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public StandardRenderableVisualDataWrapper LKIHELDNLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x62F2CB0", Offset = "0x62F1AB0", VA = "0x1862F2CB0")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public PhysicsMaterialDataWrapper CGABENMGFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x62F2E00", Offset = "0x62F1C00", VA = "0x1862F2E00")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public ShapeConfigDataWrapper MLBLFKNAHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x62F2E60", Offset = "0x62F1C60", VA = "0x1862F2E60")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public ELLPOKPINBO NHMBKJIFKIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x62F2D90", Offset = "0x62F1B90", VA = "0x1862F2D90")]
		get
		{
			return default(ELLPOKPINBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public DFGNLEDGGHJ HMNOCMLJBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x62F2AD0", Offset = "0x62F18D0", VA = "0x1862F2AD0")]
		get
		{
			return default(DFGNLEDGGHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x62F29F0", Offset = "0x62F17F0", VA = "0x1862F29F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public MBFCDAMJAPM MHCLJLHGBOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x62F3090", Offset = "0x62F1E90", VA = "0x1862F3090")]
		get
		{
			return default(MBFCDAMJAPM);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x62F2A60", Offset = "0x62F1860", VA = "0x1862F2A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public float BBEFPJBLFFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x62F2B50", Offset = "0x62F1950", VA = "0x1862F2B50")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x62F3170", Offset = "0x62F1F70", VA = "0x1862F3170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Vector3 AJMCEDEIIME
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x62F2F20", Offset = "0x62F1D20", VA = "0x1862F2F20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x62F2950", Offset = "0x62F1750", VA = "0x1862F2950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public float EJEDEAAGOHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x62F2FC0", Offset = "0x62F1DC0", VA = "0x1862F2FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public LKFJFAGGHBK GLIEJEOKOOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x62F3030", Offset = "0x62F1E30", VA = "0x1862F3030")]
		get
		{
			return default(LKFJFAGGHBK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x62F2BB0", Offset = "0x62F19B0", VA = "0x1862F2BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public BIODMPHDLED(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x62F0B60", Offset = "0x62EF960", VA = "0x1862F0B60")]
	public static bool BPFJNEHKLMP(BIODMPHDLED DIBNBLEEFNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x62F2B30", Offset = "0x62F1930", VA = "0x1862F2B30")]
	public static bool CAAJBKCJNPA(BIODMPHDLED CGAHKNIFIAB, BIODMPHDLED CJOKOOBKDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x62F2C20", Offset = "0x62F1A20", VA = "0x1862F2C20", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(BIODMPHDLED GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x62F2D10", Offset = "0x62F1B10", VA = "0x1862F2D10")]
	public FLEPPGKEDCP HIHJOECBEKO()
	{
		return default(FLEPPGKEDCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x62F30F0", Offset = "0x62F1EF0", VA = "0x1862F30F0")]
	public NEJNPNDBFLO NMJGOLOHCBM()
	{
		return default(NEJNPNDBFLO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct FLEPPGKEDCP : IEquatable<FLEPPGKEDCP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public BIODMPHDLED IOCEEJFAINK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(BIODMPHDLED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private PrimitiveShapeDataWrapper PJDOKEJDNPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x62F7750", Offset = "0x62F6550", VA = "0x1862F7750")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public GGOBOICLBDK LKEIAILCOMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x62F7660", Offset = "0x62F6460", VA = "0x1862F7660")]
		get
		{
			return default(GGOBOICLBDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public FLEPPGKEDCP(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x62F0B60", Offset = "0x62EF960", VA = "0x1862F0B60")]
	public static bool BPFJNEHKLMP(FLEPPGKEDCP DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x62F76C0", Offset = "0x62F64C0", VA = "0x1862F76C0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(FLEPPGKEDCP GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[DefaultMember("Item")]
public readonly struct NEJNPNDBFLO : IEquatable<NEJNPNDBFLO>
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly NEJNPNDBFLO ODEBAKMNCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public GAGKMAKKPLC IBPFDOOAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(GAGKMAKKPLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private IJAILEKGBDM KECKBJDCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x62F0B80", Offset = "0x62EF980", VA = "0x1862F0B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private BNMPKLDHMJK KCEGDAKCOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x63013F0", Offset = "0x63001F0", VA = "0x1863013F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private MBLNAJFLEGE JAGOJJICMPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x63015A0", Offset = "0x63003A0", VA = "0x1863015A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public BIODMPHDLED IOCEEJFAINK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(BIODMPHDLED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public LFIODJEGHHP PBFKFNBAMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6301480", Offset = "0x6300280", VA = "0x186301480")]
		get
		{
			return default(LFIODJEGHHP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x63017A0", Offset = "0x63005A0", VA = "0x1863017A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public IEnumerable<JOPALOFFKMN> NNNHEFLNMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6300EB0", Offset = "0x62FFCB0", VA = "0x186300EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public JOPALOFFKMN OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6301600", Offset = "0x6300400", VA = "0x186301600")]
		get
		{
			return default(JOPALOFFKMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6301710", Offset = "0x6300510", VA = "0x186301710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public NEJNPNDBFLO(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x62F0B60", Offset = "0x62EF960", VA = "0x1862F0B60")]
	public static bool BPFJNEHKLMP(NEJNPNDBFLO DIBNBLEEFNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x62F3A20", Offset = "0x62F2820", VA = "0x1862F3A20")]
	public static bool OFKPFEHPLBH(NEJNPNDBFLO CGAHKNIFIAB, NEJNPNDBFLO CJOKOOBKDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6300E20", Offset = "0x62FFC20", VA = "0x186300E20", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(NEJNPNDBFLO GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x63010A0", Offset = "0x62FFEA0", VA = "0x1863010A0")]
	public JOPALOFFKMN HFCJNOLAJIF(float3? JPLKOMKCHGP, [Optional] quaternion? IHHAEIJMAPE, [Optional] Vector3? HDBPIAOAHOC)
	{
		return default(JOPALOFFKMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6300BF0", Offset = "0x62FF9F0", VA = "0x186300BF0")]
	public JOPALOFFKMN EMBCACFGACK(int AELAKOMEEDP, float3? JPLKOMKCHGP, [Optional] quaternion? IHHAEIJMAPE, [Optional] Vector3? HDBPIAOAHOC)
	{
		return default(JOPALOFFKMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6301350", Offset = "0x6300150", VA = "0x186301350")]
	public void JCHAKBMPDKH(int AELAKOMEEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x63012C0", Offset = "0x63000C0", VA = "0x1863012C0")]
	public void HOCLBDDCDMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct JOPALOFFKMN : IEquatable<JOPALOFFKMN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public NEJNPNDBFLO PAIECOLNOFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x62FF640", Offset = "0x62FE440", VA = "0x1862FF640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float3 CBHGHOKJHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x62FFBC0", Offset = "0x62FE9C0", VA = "0x1862FFBC0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x62FFA00", Offset = "0x62FE800", VA = "0x1862FFA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public quaternion PEMBIJKPJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x62FFAE0", Offset = "0x62FE8E0", VA = "0x1862FFAE0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x62FF850", Offset = "0x62FE650", VA = "0x1862FF850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public float3 MBNCDMMGNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x62FF740", Offset = "0x62FE540", VA = "0x1862FF740")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x62FF8C0", Offset = "0x62FE6C0", VA = "0x1862FF8C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public BNGCCAMOOAG CAKFNMAFMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x62FF6D0", Offset = "0x62FE4D0", VA = "0x1862FF6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private SplinePointParentDataWrapper AKMCPIEGLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x62FFB60", Offset = "0x62FE960", VA = "0x1862FFB60")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private SplinePointPositionDataWrapper OHCCICJADAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x62FFA80", Offset = "0x62FE880", VA = "0x1862FFA80")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private SplinePointRotationDataWrapper NBAOPLENGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x62FFC40", Offset = "0x62FEA40", VA = "0x1862FFC40")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private SplinePointScaleDataWrapper MJJBKJDJOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x62FF9A0", Offset = "0x62FE7A0", VA = "0x1862FF9A0")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private SplinePointOrderDataWrapper HGDFDDAKNKE
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x62FF940", Offset = "0x62FE740", VA = "0x1862FF940")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public JOPALOFFKMN(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x62FF7C0", Offset = "0x62FE5C0", VA = "0x1862FF7C0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(JOPALOFFKMN GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x62FF640", Offset = "0x62FE440", VA = "0x1862FF640")]
	public void AABGJBDGMHK(NEJNPNDBFLO DIBNBLEEFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct NKFIBMJCKCH : IEquatable<NKFIBMJCKCH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	private IJAILEKGBDM KECKBJDCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x62F0B80", Offset = "0x62EF980", VA = "0x1862F0B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private BNMPKLDHMJK KCEGDAKCOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x6301E90", Offset = "0x6300C90", VA = "0x186301E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private FBGJPBGJNBH JLAELKFKLNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6301B40", Offset = "0x6300940", VA = "0x186301B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private ToolCleanupSettingsDataWrapper PKFOFEALCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x6301D00", Offset = "0x6300B00", VA = "0x186301D00")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool PBBJHFOCFBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x6301A80", Offset = "0x6300880", VA = "0x186301A80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6302060", Offset = "0x6300E60", VA = "0x186302060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool NJJILCPINCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x6301BA0", Offset = "0x63009A0", VA = "0x186301BA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x6301C90", Offset = "0x6300A90", VA = "0x186301C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public float HCPONCIFCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6301AE0", Offset = "0x63008E0", VA = "0x186301AE0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x6302330", Offset = "0x6301130", VA = "0x186302330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public bool GJMPFMOPLME
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6302570", Offset = "0x6301370", VA = "0x186302570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public NKFIBMJCKCH(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6301C00", Offset = "0x6300A00", VA = "0x186301C00", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(NKFIBMJCKCH GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6302610", Offset = "0x6301410", VA = "0x186302610")]
	public void PONPGJNEHCJ(int IMGBGPELIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6302220", Offset = "0x6301020", VA = "0x186302220")]
	public bool LNDCGNCGFAM([Out] int IMGBGPELIHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x63024D0", Offset = "0x63012D0", VA = "0x1863024D0")]
	public void NGPMFHJOCHN(bool AENKJCHAKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6301F20", Offset = "0x6300D20", VA = "0x186301F20")]
	public void JPPLPIPOLNM(float MJCNGPJBKMM, float PDCFLBGDCAI, float LNMDALJMFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x63020D0", Offset = "0x6300ED0", VA = "0x1863020D0")]
	public void KNAABIFFECK(float3 DFMOBEBPJNB, quaternion PJPCNAKLEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x63023A0", Offset = "0x63011A0", VA = "0x1863023A0")]
	public bool MKOJJELJELH([Out] float3 DFMOBEBPJNB, [Out] quaternion PJPCNAKLEAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6301D60", Offset = "0x6300B60", VA = "0x186301D60")]
	public bool HDHIJHCBDCC([Out] float EIEPDDHLOED, [Out] float GIKECDEGJBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct GAGKMAKKPLC : IEquatable<GAGKMAKKPLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public DBHDDFHIDOA PCLEIHPBPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(DBHDDFHIDOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private IJAILEKGBDM KECKBJDCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x62F0B80", Offset = "0x62EF980", VA = "0x1862F0B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private OKLKBDPNBKA IIEMPFNONFM
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x62F9ED0", Offset = "0x62F8CD0", VA = "0x1862F9ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool EFCAKOPLIDA
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x62FA2E0", Offset = "0x62F90E0", VA = "0x1862FA2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public Vector3 CBHGHOKJHGB
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x62FA4A0", Offset = "0x62F92A0", VA = "0x1862FA4A0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x62F9560", Offset = "0x62F8360", VA = "0x1862F9560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Quaternion PEMBIJKPJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x62F9B10", Offset = "0x62F8910", VA = "0x1862F9B10")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x62F90E0", Offset = "0x62F7EE0", VA = "0x1862F90E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 PLJDFINMPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x62F8330", Offset = "0x62F7130", VA = "0x1862F8330")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x62F93C0", Offset = "0x62F81C0", VA = "0x1862F93C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Quaternion HCADLGNAGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x62F9280", Offset = "0x62F8080", VA = "0x1862F9280")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x62F9490", Offset = "0x62F8290", VA = "0x1862F9490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float GLALHHELIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x62F9780", Offset = "0x62F8580", VA = "0x1862F9780")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x62FA320", Offset = "0x62F9120", VA = "0x1862FA320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float KDADLHAHELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x62F9F90", Offset = "0x62F8D90", VA = "0x1862F9F90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public Vector3 MBNCDMMGNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x62F8790", Offset = "0x62F7590", VA = "0x1862F8790")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x62F91B0", Offset = "0x62F7FB0", VA = "0x1862F91B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public Vector3 GPNLPIGIFOL
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x62F8BF0", Offset = "0x62F79F0", VA = "0x1862F8BF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public Matrix4x4 MHPILIPECLL
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x62F82F0", Offset = "0x62F70F0", VA = "0x1862F82F0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public GAGKMAKKPLC(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x62F8A20", Offset = "0x62F7820", VA = "0x1862F8A20", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(GAGKMAKKPLC GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x62F9C50", Offset = "0x62F8A50", VA = "0x1862F9C50")]
	public MPLDGLCJEIP MABMAKOHBFB()
	{
		return default(MPLDGLCJEIP);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x62F81E0", Offset = "0x62F6FE0", VA = "0x1862F81E0")]
	public void BJAOMDKADCO([Out] Matrix4x4 BNBHOPKIFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x62FA100", Offset = "0x62F8F00", VA = "0x1862FA100")]
	public void NLGMLOGFAGO([Out] Vector3 PCOMLDCGLAL, [Out] Quaternion HCFDIOEPCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x62F8130", Offset = "0x62F6F30", VA = "0x1862F8130")]
	public void BEHFCPEFLOL([Out] RigidTransform JOMGJGPBJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x62F8550", Offset = "0x62F7350", VA = "0x1862F8550")]
	public UniformTRS DAKBIACPDEN()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x62F8580", Offset = "0x62F7380", VA = "0x1862F8580")]
	public void DAKBIACPDEN([Out] UniformTRS IPDNDKBJMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x62F9EA0", Offset = "0x62F8CA0", VA = "0x1862F9EA0")]
	public UniformTRS MJDDGKHFLJG()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x62F9DE0", Offset = "0x62F8BE0", VA = "0x1862F9DE0")]
	public void MJDDGKHFLJG([Out] UniformTRS JOMGJGPBJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x62F9630", Offset = "0x62F8430", VA = "0x1862F9630")]
	public Vector3 JINECADPPJD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x62F8480", Offset = "0x62F7280", VA = "0x1862F8480")]
	public void CGIMGLMIGPC([In] Vector3 DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x62F8DF0", Offset = "0x62F7BF0", VA = "0x1862F8DF0")]
	public Vector3 FOJJMLLOAFA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x62F8F40", Offset = "0x62F7D40", VA = "0x1862F8F40")]
	public void GEGIHMOCFOJ([In] Vector3 DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x62F88E0", Offset = "0x62F76E0", VA = "0x1862F88E0")]
	public Quaternion EJIJPOLGDEL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x62FA3D0", Offset = "0x62F91D0", VA = "0x1862FA3D0")]
	public void PANFAEDPDPL([In] Quaternion DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x62F9CA0", Offset = "0x62F8AA0", VA = "0x1862F9CA0")]
	public Quaternion MECJDGADEAB()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x62F8060", Offset = "0x62F6E60", VA = "0x1862F8060")]
	public void AJLKJGGKGBB([In] Quaternion DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x62F8AB0", Offset = "0x62F78B0", VA = "0x1862F8AB0")]
	public float FCBEJINPAIP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x62F8D40", Offset = "0x62F7B40", VA = "0x1862F8D40")]
	public void FGIJBKFLKGC(float DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x62F8B50", Offset = "0x62F7950", VA = "0x1862F8B50")]
	public float FCGAFDIGMBO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x62FA230", Offset = "0x62F9030", VA = "0x1862FA230")]
	public void OFDCDHKFLJD(float DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x62F9010", Offset = "0x62F7E10", VA = "0x1862F9010")]
	public void HFAPAOAHIKM([In] Vector3 DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x62F98F0", Offset = "0x62F86F0", VA = "0x1862F98F0")]
	public Vector3 LHNMCMGMJEH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x62FA030", Offset = "0x62F8E30", VA = "0x1862FA030")]
	public void NGBFJLDGBKL([In] Vector3 DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x62F8640", Offset = "0x62F7440", VA = "0x1862F8640")]
	public Vector3 DEHBEIMBGJF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x62F9A40", Offset = "0x62F8840", VA = "0x1862F9A40")]
	public void LJDOJDLIIKJ([In] Vector3 DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x62FA5F0", Offset = "0x62F93F0", VA = "0x1862FA5F0")]
	public Vector3 PNMLBMCBBAL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x62F9820", Offset = "0x62F8620", VA = "0x1862F9820")]
	public void LCLPMJOHGJL([In] Vector3 DIBNBLEEFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct ICPBPEIJAKJ : IEquatable<ICPBPEIJAKJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly FHFOHBBENOG ACOAKBIHAJJ;

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public CHNELAGJPNB IFPHJFPGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
		get
		{
			return default(CHNELAGJPNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public int[] CABHHNEHBEP
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x62FB6A0", Offset = "0x62FA4A0", VA = "0x1862FB6A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool BBBNMBEPGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x62FB640", Offset = "0x62FA440", VA = "0x1862FB640")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x62FB820", Offset = "0x62FA620", VA = "0x1862FB820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x1885FB0", Offset = "0x1884DB0", VA = "0x181885FB0")]
	public ICPBPEIJAKJ(FHFOHBBENOG BLCHDPHIDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x62F0940", Offset = "0x62EF740", VA = "0x1862F0940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x62FB790", Offset = "0x62FA590", VA = "0x1862FB790", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF6A0", VA = "0x1862F08A0", Slot = "4")]
	public bool Equals(ICPBPEIJAKJ GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x62F0970", Offset = "0x62EF770", VA = "0x1862F0970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class DJDPBPDCCEE
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private struct MHAIHHMHGFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Guid IIGMMHCLOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public OIDJDJBPLLK ODJCDBICOFM;
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct OIDJDJBPLLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int DIBNBLEEFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int IHKLCNJINDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int KKOLFKPALFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int ECIAFCHGKPM;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x63028F0", Offset = "0x63016F0", VA = "0x1863028F0")]
		public bool PKILDJBCHFP([Out] KHKDIBBPDLL KCJGNECPFBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x6302970", Offset = "0x6301770", VA = "0x186302970")]
		public OIDJDJBPLLK(KHKDIBBPDLL KCJGNECPFBB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x62F5810", Offset = "0x62F4610", VA = "0x1862F5810")]
	public static Guid FECGEPDINNJ(this KHKDIBBPDLL KCJGNECPFBB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x62F57F0", Offset = "0x62F45F0", VA = "0x1862F57F0")]
	public static bool BFHKAMHMLDJ(this Guid IIGMMHCLOGB, [Out] KHKDIBBPDLL KCJGNECPFBB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal static class IONDBDOMNGP
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x62FCB20", Offset = "0x62FB920", VA = "0x1862FCB20")]
	public static BNMPKLDHMJK KCEGDAKCOOC(this FHFOHBBENOG NLFEJIHGBIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x62FC950", Offset = "0x62FB750", VA = "0x1862FC950")]
	public static DPNNBMFGGBI ADFBEOFHHGP(this FHFOHBBENOG NLFEJIHGBIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x62FCA20", Offset = "0x62FB820", VA = "0x1862FCA20")]
	public static EntityManager FBNPOHPPCMC(this FHFOHBBENOG NLFEJIHGBIC)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x290A190", Offset = "0x2908F90", VA = "0x18290A190")]
	public static T CEFHKHLPLOF<T>(this FHFOHBBENOG NLFEJIHGBIC) where T : struct, MJIDKPGONBF
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x290B350", Offset = "0x290A150", VA = "0x18290B350")]
	public static bool HLEDPCMMNNC<T>(this FHFOHBBENOG NLFEJIHGBIC) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x290B2A0", Offset = "0x290A0A0", VA = "0x18290B2A0")]
	public static bool DEILBAMPPKI<T>(this FHFOHBBENOG NLFEJIHGBIC) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface IGPNBFNOFLL
{
	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JGNEMHJCHJH(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LKKALKLHJMI(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AANFFIBIHHE(FHFOHBBENOG BLCHDPHIDBL, [Out] Guid EIJDKKKBCNG);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid OLCIBBCAPMG(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GBELKAPHMBB(FHFOHBBENOG BLCHDPHIDBL, Guid EIJDKKKBCNG);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MIFPJAAMEIF(FHFOHBBENOG BLCHDPHIDBL, [Out] Guid NLOKDELMBLG);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid JFOAJBPDNOH(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LPFLOKGGIHH(FHFOHBBENOG BLCHDPHIDBL, Guid NLOKDELMBLG);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EGLNGIDMFEM(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task FJDIDIFNCOA(FHFOHBBENOG APEMCPNHEOP, FHFOHBBENOG OGCHMLDLLMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface EKOIHBFDDPD
{
	[Cpp2IlInjected.Token(Token = "0x17000160")]
	Guid ENBDAKIOFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKMILIAPHHD(NativeList<Guid> ACENKDBHHMC, NativeList<Guid> JNDBFILIDIF, NativeList<FixedString64Bytes> EFNFHMGDKEE);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface IMCCDFFGNHE
{
	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPIKHIDAGLP(List<FHFOHBBENOG> OHIHLFCAPAO);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DLAAENOLGJD(FHFOHBBENOG BKCDJOGPNEN);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IFHLLNNDOEL(FHFOHBBENOG BKCDJOGPNEN);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AFHNKJGMCJO(FHFOHBBENOG BKCDJOGPNEN);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IHEILMJKKDK(FHFOHBBENOG BKCDJOGPNEN);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HEGKKEPFMOE(FHFOHBBENOG BKCDJOGPNEN, int HAEHFCPEDMJ);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FHFOHBBENOG KLIBCMHBGIB(FHFOHBBENOG GJNIOIEAMKF);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JIIFBHIADCM(FHFOHBBENOG GJNIOIEAMKF, FHFOHBBENOG FDGLJMEBBLC);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BCJNFHFNCMG(FHFOHBBENOG GJNIOIEAMKF);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int KIAGNBNFIHL(FHFOHBBENOG GJNIOIEAMKF);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FKBFPGADDMH(FHFOHBBENOG GJNIOIEAMKF, int NEBGPBEKPHF);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FHKHPIGDONM(FHFOHBBENOG ACOAKBIHAJJ);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IHIFMDFIMJN(FHFOHBBENOG BLCHDPHIDBL, bool DDHLGFGDCKO);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HNHEKMAOMIB(FHFOHBBENOG[] FOHMKIEPADL, bool DDHLGFGDCKO);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface FGLILLNEKBP
{
	[Cpp2IlInjected.Token(Token = "0x17000161")]
	IReadOnlyCollection<EANIEADIONO> GEIIIHNKIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IOGDOMJGOMM(int OIOKOFFMIPK, [Out] EANIEADIONO LNOAGJKLBNI);

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EANIEADIONO ADOONINMANB(Type DDEINLAGLLL);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class JNHCINPOOLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2938320", Offset = "0x2937120", VA = "0x182938320")]
	public static T HPMIPAJMFBG<T>(this FGLILLNEKBP LHNKBHIFINA, Entity IBOBFMDOLFK) where T : struct, MJIDKPGONBF
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x29376C0", Offset = "0x29364C0", VA = "0x1829376C0")]
	public static EANIEADIONO ADOONINMANB<T>(this FGLILLNEKBP LHNKBHIFINA) where T : struct, MJIDKPGONBF
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface IPAJCAFLLON
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KHKDIBBPDLL[] LOCKOMPDFOA(string PHEKPMAPPHM, CHNELAGJPNB KFDOMODGCJF, bool NJLFEIIGOKC = false);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIGKOLIGJGF(string IOAKLAMDNKM, KHKDIBBPDLL[] EDMAHOLJFKG);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface KDIBOGJLGOE
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<FHFOHBBENOG, FHFOHBBENOG> IMBNFAEBJNP;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<FHFOHBBENOG, FHFOHBBENOG> NADPMCGCFOA;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<FHFOHBBENOG, FHFOHBBENOG, FHFOHBBENOG> ADODHDPFNGK;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<FHFOHBBENOG> DIAGPCIHGCJ;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CAGLJFIACAE(FHFOHBBENOG BLCHDPHIDBL, FHFOHBBENOG GPPMMMMBODF);

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FHFOHBBENOG PDJFDKOFNMD(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<FHFOHBBENOG> NIPHLPJNMAP(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FHFOHBBENOG NKEIICMECCC(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EHEGJALDEDC(FHFOHBBENOG BLCHDPHIDBL, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI);

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HDKPFBLEFMD(FHFOHBBENOG BLCHDPHIDBL, float NDBJANJICJD);

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool JADFLFJLKEE(FHFOHBBENOG BLCHDPHIDBL, [Out] RigidTransform PDCILGLFGKG);

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool GGDFKNDCGJP(FHFOHBBENOG BLCHDPHIDBL, [Out] float HFELPDIKPPA);

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 NINOLDMNJNH(CLGJEADGJIA IEBAGHJDDMO);

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion MLKGPFACLGA(CLGJEADGJIA IEBAGHJDDMO);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class KOALLKEPIKB
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface ACKGLFMOCPM
{
	[Cpp2IlInjected.Token(Token = "0x17000162")]
	object CPCLGFGOGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICMIEAPBCFF(GBACJLHJCCJ FOHMKIEPADL);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public enum NJKDOHHIPPH
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class LCCLODAADOL
{
	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0xBEE4E0", Offset = "0xBED2E0", VA = "0x180BEE4E0")]
	public static bool FIPODGPDJKC(this NJKDOHHIPPH DEPIDMABJHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0xBEE500", Offset = "0xBED300", VA = "0x180BEE500")]
	public static bool PEJFLDNCPCB(this NJKDOHHIPPH DEPIDMABJHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x2353F40", Offset = "0x2352D40", VA = "0x182353F40")]
	public static bool BKNHAGFNDJB(this NJKDOHHIPPH DEPIDMABJHK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface EHHIPFBKECM
{
	[Cpp2IlInjected.Token(Token = "0x17000163")]
	NJKDOHHIPPH IKOJHAHMLOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	NJKDOHHIPPH EAKDHGIIFBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	NJKDOHHIPPH OGJOLBOGFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	NJKDOHHIPPH KKGLAFBLIAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	NJKDOHHIPPH HODDHNMKDFL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	NJKDOHHIPPH NNLNOCGNNAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	NJKDOHHIPPH DNJFNMCGLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	NJKDOHHIPPH IKJGODOPHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	NJKDOHHIPPH GEGINDNPDIF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	NJKDOHHIPPH KCNGNLPGOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	NJKDOHHIPPH HJOOMHABIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	NJKDOHHIPPH OKMLCOAKBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	NJKDOHHIPPH BCBMPJJMFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface ILBBHPFHOEM
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<IIBHPIOJOII> MOGJCBCCDEI;

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FHFOHBBENOG DLOHKIFFPAL(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HLBKIOOGINL(List<FHFOHBBENOG> OHIHLFCAPAO);

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BNGCCAMOOAG ILMNOFFACBF(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BNGCCAMOOAG DMKEMFAFBFK(FHFOHBBENOG OGCHMLDLLMJ, FHFOHBBENOG EKLFCLOPJMB, bool ALIJCAPGGBP, FHFOHBBENOG KCDBINENHAL);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FHFOHBBENOG MPDJOKILJNF(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CHDAKFMCKBA(FHFOHBBENOG BLCHDPHIDBL, FHFOHBBENOG OGCHMLDLLMJ, bool PNDHGPCFPIM);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FGKKKNLELGK(FHFOHBBENOG BLCHDPHIDBL, FHFOHBBENOG OGCHMLDLLMJ);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ONEFFDGGDBB(FHFOHBBENOG IAPDHNELNAO, FHFOHBBENOG GMIPHEGODAF);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int LOCKDMBHBLF(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GBACJLHJCCJ KCOIMILAAPO(FHFOHBBENOG ACOAKBIHAJJ);

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NativeArray<FHFOHBBENOG> OMBKIMCKIDL(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool OEJGIEBKMDG(FHFOHBBENOG BLCHDPHIDBL, FHFOHBBENOG IHJMJNNECMD);

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<FHFOHBBENOG> FPLMNFMLHKP(FHFOHBBENOG BLCHDPHIDBL, bool BINAFMMBIOC = false);

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool PJOLCAHGJLG(FHFOHBBENOG BLCHDPHIDBL, FHFOHBBENOG DONPBLGNHAN);

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FHFOHBBENOG NEIIMGDFDJA(FHFOHBBENOG KCDBINENHAL, FHFOHBBENOG NOALJOKBJBM);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool BJJMKDLLJEN(FHFOHBBENOG KCDBINENHAL, FHFOHBBENOG NOALJOKBJBM, [Out] FHFOHBBENOG LJBFJKMICNO);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class GPMGGBHJMKN
{
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x62FB300", Offset = "0x62FA100", VA = "0x1862FB300")]
	public static List<FHFOHBBENOG> HLBKIOOGINL(this ILBBHPFHOEM HIGIEDDKDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x62FB290", Offset = "0x62FA090", VA = "0x1862FB290")]
	public static bool BILKBDDKIJJ(this ILBBHPFHOEM HIGIEDDKDHE, FHFOHBBENOG BLCHDPHIDBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface IHKMGABJMIL
{
	[Cpp2IlInjected.Token(Token = "0x17000170")]
	bool KFEPLBPCBGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	bool MFGKGMMNLMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface HGEKFJGJFNB : ALIAILFNBML
{
	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LDGGNFPEBPH(Entity IBOBFMDOLFK, [Out] DMHHABIBEFJ GMPBFHBNPFC);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CAFNDLMKACO(NativeArray<DMHHABIBEFJ> LFGFBILIGAL, NativeArray<EGOEDPGDNJL> FDNPODEBBJG);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLPINDKBHIE(DMHHABIBEFJ GMPBFHBNPFC);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LOLDFFPPMEA(DMHHABIBEFJ GMPBFHBNPFC, [Out] Collider PLGNHDMELGA);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface ALIAILFNBML
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MNDLGFKHNBD([In] float3 GBCFIJMPBKM, [In] float3 BCGALFAPEPA, float OGFHDAHPALD, Allocator ACBNCIGINAO, [Out] NativeArray<Entity> EIMPJPDNNIE);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface DCMDEHILIEG
{
	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MNDLGFKHNBD([In] float3 GBCFIJMPBKM, [In] float3 BCGALFAPEPA, float OGFHDAHPALD, [Out] LCEFLBHAHDE GJKMBNDCEOK, [Out] FHFOHBBENOG DLIBIIFDOGA);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface BBIJMJCMJEM
{
	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNDLGFKHNBD([In] NativeArray<Entity> EIMPJPDNNIE, [In] float3 GBCFIJMPBKM, [In] float3 BCGALFAPEPA, [In] NativeArray<LCEFLBHAHDE> CGAPGDMIEIO);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct DMHHABIBEFJ : ICMAJFMJFMA, IEquatable<DMHHABIBEFJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int PCBIBNEPCKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x905FC0", Offset = "0x904DC0", VA = "0x180905FC0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int GGDKNGHMDFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x2373060", Offset = "0x2371E60", VA = "0x182373060", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x56467A0", Offset = "0x56455A0", VA = "0x1856467A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x62F6900", Offset = "0x62F5700", VA = "0x1862F6900", Slot = "8")]
	public bool Equals(DMHHABIBEFJ GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x62F6950", Offset = "0x62F5750", VA = "0x1862F6950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct LCEFLBHAHDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float OFOLDMPABKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float3 ELKFIDDLEIG;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface EPMIPCKAMML
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface IJAILEKGBDM
{
	[Cpp2IlInjected.Token(Token = "0x17000174")]
	BNMPKLDHMJK KCEGDAKCOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	DLGOHPEGION JFAOKOGFIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<GBACJLHJCCJ, NativeArray<LGNBEHGCHLL>> DOAOLEMFGPP;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<GBACJLHJCCJ> GHCHBDJNGKB;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GKJFLINHNGP CBPKALKFBFN(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LGNBEHGCHLL BNEMLLPODND(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GEBEKKCKBFI(KHKDIBBPDLL KCJGNECPFBB, GKDNGLPPHAE HPBKPLNBJBH);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GEHNLBJDAIN(KHKDIBBPDLL[] EDMAHOLJFKG, GameObject EBIGFKEAJMH);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CHNELAGJPNB IHMPNEIAMDN(FHFOHBBENOG BLCHDPHIDBL, [Optional] object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EEFGAGMAMIN(FHFOHBBENOG BLCHDPHIDBL, [Out] GKDNGLPPHAE HPBKPLNBJBH);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OEKOIOGAHPC(FHFOHBBENOG BLCHDPHIDBL, [Out] Transform AFOLJDADEON);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool AMJDKKNJCHE(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MDALBLLBJOK(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IDLBKLLJPNJ(LocalId BLCHDPHIDBL, object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool FKGPMLBMJIK(LocalId BLCHDPHIDBL, object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	FHFOHBBENOG DKOCBIPDHCN(KHKDIBBPDLL KCJGNECPFBB);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool LGNCAOAHNNG(KHKDIBBPDLL KCJGNECPFBB, [Out] FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	KHKDIBBPDLL KCBJLBNLHAE(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	GBACJLHJCCJ DKOCBIPDHCN(NativeArray<KHKDIBBPDLL> KCJGNECPFBB, Allocator ACBNCIGINAO);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	GBACJLHJCCJ LFMGOFONABK(LGNBEHGCHLL MIEPJJBHNJD, int NJKDAMEBDBN, Allocator ACBNCIGINAO);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	GBACJLHJCCJ EKNIJEFCJLC(NativeArray<KHKDIBBPDLL> KCJGNECPFBB, NativeArray<ONBNBEMIEOD> GHMMMPHFPEJ, Allocator ACBNCIGINAO);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	KHKDIBBPDLL[] LOCKOMPDFOA(string IOAKLAMDNKM, CHNELAGJPNB KFDOMODGCJF, bool NJLFEIIGOKC);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IIGKOLIGJGF(string IOAKLAMDNKM, KHKDIBBPDLL[] EDMAHOLJFKG);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "25")]
	CHNELAGJPNB MMKKGGNCHLI(LGNBEHGCHLL MIEPJJBHNJD, bool CFICAPGKMCM);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CHNELAGJPNB MMKKGGNCHLI(LGNBEHGCHLL MIEPJJBHNJD);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	CHNELAGJPNB EOPFGNLPEGP(LGNBEHGCHLL MIEPJJBHNJD);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "28")]
	CHNELAGJPNB LFBIBLFNAEJ(LGNBEHGCHLL MIEPJJBHNJD);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "29")]
	CHNELAGJPNB DALCKEGLPCK(KHKDIBBPDLL KCJGNECPFBB, LGNBEHGCHLL MIEPJJBHNJD);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "30")]
	JKMJOEINAFA NAOPBMJONLF();

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "31")]
	NEJNPNDBFLO LLACBJGOHOJ();

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "32")]
	FLEPPGKEDCP HJMEHDKLJPP(GGOBOICLBDK IPAMOAJOMEN);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void JNHGHMHNMBE(GBACJLHJCCJ FOHMKIEPADL);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void OFGJMFOHKEH(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void KHOJEBOOMMK(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void JNHGHMHNMBE(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool MBCBFICOPPB(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "38")]
	GBACJLHJCCJ PAHNGLBIMMO(GBACJLHJCCJ LHKGNLMNIKO, Allocator ACBNCIGINAO);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool NKPMKKDPBBC(FHFOHBBENOG BLCHDPHIDBL);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class FNCLGPJJAMM
{
	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x62F7CE0", Offset = "0x62F6AE0", VA = "0x1862F7CE0")]
	public static void MDALBLLBJOK(this IJAILEKGBDM OIOBKJIDCCC, GKDNGLPPHAE HPBKPLNBJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x62F79D0", Offset = "0x62F67D0", VA = "0x1862F79D0")]
	public static CHNELAGJPNB GEPDDPGGNFF(this IJAILEKGBDM OIOBKJIDCCC, LocalId BLCHDPHIDBL)
	{
		return default(CHNELAGJPNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x62F7A00", Offset = "0x62F6800", VA = "0x1862F7A00")]
	public static CHNELAGJPNB GEPDDPGGNFF(this IJAILEKGBDM OIOBKJIDCCC, KHKDIBBPDLL KCJGNECPFBB)
	{
		return default(CHNELAGJPNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x62F79D0", Offset = "0x62F67D0", VA = "0x1862F79D0")]
	public static FHFOHBBENOG DKOCBIPDHCN(this IJAILEKGBDM OIOBKJIDCCC, LocalId BLCHDPHIDBL)
	{
		return default(FHFOHBBENOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x62F7C60", Offset = "0x62F6A60", VA = "0x1862F7C60")]
	public static KHKDIBBPDLL KCBJLBNLHAE(this IJAILEKGBDM OIOBKJIDCCC, LocalId BLCHDPHIDBL)
	{
		return default(KHKDIBBPDLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x62F7E60", Offset = "0x62F6C60", VA = "0x1862F7E60")]
	public static bool NKPMKKDPBBC(this IJAILEKGBDM OIOBKJIDCCC, KHKDIBBPDLL KCJGNECPFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x28BA250", Offset = "0x28B9050", VA = "0x1828BA250")]
	public static T GJNJCNHAAOE<T>(this IJAILEKGBDM OIOBKJIDCCC, LocalId BLCHDPHIDBL) where T : struct, MJIDKPGONBF
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x62F7A60", Offset = "0x62F6860", VA = "0x1862F7A60")]
	public static JKMJOEINAFA IICECPCANGH(this IJAILEKGBDM OIOBKJIDCCC, RigidTransform IPDNDKBJMMA, [Optional] object ADNDMAGEPOK)
	{
		return default(JKMJOEINAFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x62F7D60", Offset = "0x62F6B60", VA = "0x1862F7D60")]
	public static FLEPPGKEDCP MFALBIBHCFD(this IJAILEKGBDM OIOBKJIDCCC, GGOBOICLBDK FLBAPADDJBH, RigidTransform IPDNDKBJMMA, [Optional] object ADNDMAGEPOK)
	{
		return default(FLEPPGKEDCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x62F7B60", Offset = "0x62F6960", VA = "0x1862F7B60")]
	public static NEJNPNDBFLO JINDKIAEFCN(this IJAILEKGBDM OIOBKJIDCCC, RigidTransform IPDNDKBJMMA, [Optional] object ADNDMAGEPOK)
	{
		return default(NEJNPNDBFLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x62F77B0", Offset = "0x62F65B0", VA = "0x1862F77B0")]
	private static void AOFNHIODCDM(CHNELAGJPNB AFFHDLDHCLL, RigidTransform IPDNDKBJMMA, [Optional] object ADNDMAGEPOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface DJHFNNMIKOL
{
	[Cpp2IlInjected.Token(Token = "0x17000176")]
	bool DEEJPGKLALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	FHFOHBBENOG LCCLBBCJEIM
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	CHNELAGJPNB EBCMIDHIICL
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event OGEGJLGLMJD JDFFAHJLELG;

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FHFOHBBENOG NEIIMGDFDJA(FHFOHBBENOG KCDBINENHAL, FHFOHBBENOG NOALJOKBJBM);

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BJJMKDLLJEN(FHFOHBBENOG KCDBINENHAL, FHFOHBBENOG NOALJOKBJBM, [Out] FHFOHBBENOG LJBFJKMICNO);

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JGAOIHPEOFA();

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IOCCNLDEDAE();

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LHOLGJOPNBF(FHFOHBBENOG KCDBINENHAL);

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KBBFDMJLDLH(FHFOHBBENOG KCDBINENHAL);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate void OGEGJLGLMJD(CHNELAGJPNB KLLCLEKKNCG, CHNELAGJPNB OLAFNEFNGDA);
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class NNDLJKCCCNB
{
	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x6302790", Offset = "0x6301590", VA = "0x186302790")]
	public static bool PAKNBCNHGGJ(this DJHFNNMIKOL OAALIFHDAIL, CHNELAGJPNB KCDBINENHAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x63026B0", Offset = "0x63014B0", VA = "0x1863026B0")]
	public static bool FDMDMJGHEHF(this DJHFNNMIKOL OAALIFHDAIL, FHFOHBBENOG KCDBINENHAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x63027E0", Offset = "0x63015E0", VA = "0x1863027E0")]
	public static bool PCODFHCBJJP(this DJHFNNMIKOL OAALIFHDAIL, FHFOHBBENOG KCDBINENHAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface HOFNHLNPOHM
{
	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCPAHHJIPDG(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFFDLOAAMBC(FHFOHBBENOG BLCHDPHIDBL, Transform AFOLJDADEON);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface AENNDMDONBE
{
	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJIKIOHEMPM(FHFOHBBENOG KCDBINENHAL, FHFOHBBENOG ACBOHCJAIIC);

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NFGBDHMGGGB(FHFOHBBENOG KCDBINENHAL, FHFOHBBENOG MEOEBCJBADL);

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KHDDJBIGGEJ(FHFOHBBENOG KCDBINENHAL, [Out] FHFOHBBENOG FCAKLBAEAOC);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface DMCJHKLCCGI
{
	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEBIBKCNDNA(FHFOHBBENOG ACOAKBIHAJJ, bool DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPBNJADEEDH(FHFOHBBENOG ACOAKBIHAJJ, bool DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BKFFHFAONJB(FHFOHBBENOG ACOAKBIHAJJ, int DIBNBLEEFNN);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface MBLNAJFLEGE
{
	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<FHFOHBBENOG> LCPPNNAFDMJ(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FHFOHBBENOG KPMPCCHLDDO(FHFOHBBENOG BLCHDPHIDBL, int AELAKOMEEDP);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int CPEJMHGJPKE(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LFIODJEGHHP DFPMDCIILMA(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JKGOPKAKAHD(FHFOHBBENOG BLCHDPHIDBL, LFIODJEGHHP AHMCCAODOOJ);

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FHFOHBBENOG FKAKBGCIDCL(FHFOHBBENOG BLCHDPHIDBL, [Optional] float3? JPLKOMKCHGP, [Optional] quaternion? IHHAEIJMAPE, [Optional] float3? HDBPIAOAHOC);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FHFOHBBENOG PADJILDJLIA(FHFOHBBENOG BLCHDPHIDBL, int AELAKOMEEDP, [Optional] float3? JPLKOMKCHGP, [Optional] quaternion? IHHAEIJMAPE, [Optional] float3? HDBPIAOAHOC);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AAFACLCBBFP(FHFOHBBENOG BLCHDPHIDBL, int AELAKOMEEDP);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OPAIBHAAMLB(FHFOHBBENOG BLCHDPHIDBL);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface FPFIPMBFMJA
{
	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MIPAGPAFEHK();

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHDFNPFAHDK();

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void APCCMNKBBBJ();

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NJLGENPAAOH();

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IOKHCGKMNBA();

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LLMCMLJICLF();

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FJGMBJLGHPK();

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BINHBAICKEE();

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MKMCFLNDKOL();

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PACOFDLLICB();

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MLBJAIBHDIP();

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PHNDKDKOMDG();
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface FBGJPBGJNBH
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LNDCGNCGFAM(FHFOHBBENOG KCDBINENHAL, [Out] int IMGBGPELIHK);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PONPGJNEHCJ(FHFOHBBENOG KCDBINENHAL, int IMGBGPELIHK);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KDHEIBHAKJA(FHFOHBBENOG KCDBINENHAL, bool AIBEMFNIBFC);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGPMFHJOCHN(FHFOHBBENOG KCDBINENHAL, bool AENKJCHAKBG);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPPLPIPOLNM(FHFOHBBENOG KCDBINENHAL, float MJCNGPJBKMM, float PDCFLBGDCAI, float LNMDALJMFNF);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HDHIJHCBDCC(FHFOHBBENOG BLCHDPHIDBL, [Out] float PDCFLBGDCAI, [Out] float LNMDALJMFNF);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KNAABIFFECK(FHFOHBBENOG KCDBINENHAL, float3 JPLKOMKCHGP, quaternion IHHAEIJMAPE);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MKOJJELJELH(FHFOHBBENOG KCDBINENHAL, [Out] float3 JPLKOMKCHGP, [Out] quaternion IHHAEIJMAPE);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface OKLKBDPNBKA
{
	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJPMCLDDPJA(Entity IBOBFMDOLFK);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGIMGLMIGPC(Entity IBOBFMDOLFK, [In] float3 DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 JINECADPPJD(Entity IBOBFMDOLFK);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PANFAEDPDPL(Entity IBOBFMDOLFK, [In] quaternion DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion EJIJPOLGDEL(Entity IBOBFMDOLFK);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NLGMLOGFAGO(Entity IBOBFMDOLFK, [Out] float3 JPLKOMKCHGP, [Out] quaternion IHHAEIJMAPE);

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NLGMLOGFAGO(Entity IBOBFMDOLFK, [Out] RigidTransform MGNAMAFFDPN);

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BEHFCPEFLOL(Entity IBOBFMDOLFK, [Out] RigidTransform MGNAMAFFDPN);

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 HECNOGFGLOL(Entity IBOBFMDOLFK);

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HFAPAOAHIKM(Entity IBOBFMDOLFK, [In] float3 DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FGIJBKFLKGC(Entity IBOBFMDOLFK, float DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float FCBEJINPAIP(Entity IBOBFMDOLFK);

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LJDOJDLIIKJ(Entity IBOBFMDOLFK, [In] float3 DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 DEHBEIMBGJF(Entity IBOBFMDOLFK);

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GEGIHMOCFOJ(Entity IBOBFMDOLFK, [In] float3 DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 FOJJMLLOAFA(Entity IBOBFMDOLFK);

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AJLKJGGKGBB(Entity IBOBFMDOLFK, [In] quaternion DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion MECJDGADEAB(Entity IBOBFMDOLFK);

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 LHNMCMGMJEH(Entity IBOBFMDOLFK);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NGBFJLDGBKL(Entity IBOBFMDOLFK, [In] float3 DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OFDCDHKFLJD(Entity IBOBFMDOLFK, float DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float FCGAFDIGMBO(Entity IBOBFMDOLFK);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LCLPMJOHGJL(Entity IBOBFMDOLFK, [In] float3 DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 PNMLBMCBBAL(Entity IBOBFMDOLFK);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GHGFKJEENCE(Entity IBOBFMDOLFK, [Out] float4x4 BNBHOPKIFIC);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void BIAHOLOOAEK(Entity IBOBFMDOLFK, [In] float4x4 BNBHOPKIFIC);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IKMJAICGMCO(Entity IBOBFMDOLFK, [Out] float4x4 BNBHOPKIFIC);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool OEKOIOGAHPC(Entity IBOBFMDOLFK, [Out] Transform AFOLJDADEON);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IKEJNFMMKJD(Entity IBOBFMDOLFK);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MJDFKBOGBEI(Entity IBOBFMDOLFK, Entity EBMEJPEOJDM, Entity OIJEBDLJMMH);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class BPIEHFNCGPG
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface NEAAOHNMINA
{
	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKHFBIMJAJP(bool MGIKOAEGEPK);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface EGDNBEAJFFG
{
	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World JMNNFJDBKMP(string HGHMKLICJOM = "Main");

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World MLBHGEHCIEF(string HGHMKLICJOM = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World JHPHDOHLOOI(string HGHMKLICJOM = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World MJJDPKAGLKL(string HGHMKLICJOM = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface DPNNBMFGGBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000179")]
	World BBOKNMAAMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	World KJOHFNJPLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	EntityManager FBNPOHPPCMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	bool BOHPGLCBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase PIFFGCOAEJF(Type DDEINLAGLLL);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class NNFKDJJFFIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6302860", Offset = "0x6301660", VA = "0x186302860")]
	public static ComponentSystemBase HEAHOAGFOMI(this World BNCKCALLBDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A2A0", Offset = "0x2A090A0", VA = "0x182A0A2A0")]
	public static T PIFFGCOAEJF<T>(this DPNNBMFGGBI DANCKHOJLBO) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface KLHJAALLCBM
{
	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEKOMDCLBMH(NativeListAsync<Entity> HAKNDKBNMLC);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MEAADIJMJPA(IBCJKBIIOID GKNHGDLAIKP);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EMCCPFPDBHM(NativeListAsync<Entity> LBCGMFDGMLD, bool EPMCFKDOKGO);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JLHPEHGKCLJ();
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface GMPHDDBFJAH
{
	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HDAPMFLILFO(Collider PLGNHDMELGA, [Out] DMIOBKAGFIO PCPGDIPCACF);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface CDCOGBLHLDK
{
	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OAGLNEKFBKK(FHFOHBBENOG BLCHDPHIDBL, [Out] Collider PLGNHDMELGA);

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject HHDLADFJBFL(FHFOHBBENOG JLJDBMEAABN, GameObject IHFDHAEOMFG, Vector3 ONAIBAMIBJL, Quaternion LCPHIJKNEAJ);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCJKEKPNNIM(GameObject PLGNHDMELGA);

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider IMFBOIBMLKM<TCollider>(GameObject KMGLEAHEFKG) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KOBFOCEHEON(Collider PLGNHDMELGA);

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject HHKBPEAMNJJ<TCollider>(string PHEKPMAPPHM) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface EKIHONLJFCG
{
	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLLCHLFKCOP(FHFOHBBENOG BLCHDPHIDBL, GENGIDCKDKF JKAMDDOGMDN, bool OGLFMPMMIGO, BAMHMIEKLNG GLMHNCIKDBI);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKIMMJFPDDE(FHFOHBBENOG BLCHDPHIDBL, GENGIDCKDKF JKAMDDOGMDN, bool OGLFMPMMIGO, bool NOPNCNKICNA, bool LHALJJPNEGG);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HCCCHEPBEJK HDOJOHMHIHP(FHFOHBBENOG GDOPFEEANMP, List<FHFOHBBENOG> HKGKBOEODKF);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IFGEHAODADI(GameObject OAMHPNFFIDM, GameObject LNHBBEANKOD);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDFACGGPEKJ(GameObject LNHBBEANKOD);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T IMFBOIBMLKM<T>(GameObject KMGLEAHEFKG) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KOBFOCEHEON(Collider PLGNHDMELGA);

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject CNGFBKEJPOD<T>(string PHEKPMAPPHM) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PPEGDKMFJEH(Collider PLGNHDMELGA, [Out] FHFOHBBENOG IMGBGPELIHK);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CBMMBCPHDAG(FHFOHBBENOG BLCHDPHIDBL, [Out] DMIOBKAGFIO PCPGDIPCACF);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface BCGCKMHMIDC
{
	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMOKIJJFMPI(FHFOHBBENOG BLCHDPHIDBL, FHFOHBBENOG DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALEADCEDJPP(FHFOHBBENOG BLCHDPHIDBL, FHFOHBBENOG DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int LOCKDMBHBLF(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FHFOHBBENOG NFGLKOCPPME(FHFOHBBENOG BLCHDPHIDBL, int AELAKOMEEDP);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GBACJLHJCCJ BPMJBGBPHHO(FHFOHBBENOG BLCHDPHIDBL, Allocator ACBNCIGINAO = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JIFIBPDLIEH(FHFOHBBENOG BLCHDPHIDBL, object ADNDMAGEPOK, FHFOHBBENOG DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BEIFFJCCIMF(FHFOHBBENOG BLCHDPHIDBL, object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ACALMPJPBHD(FHFOHBBENOG BLCHDPHIDBL, [Out] FHFOHBBENOG DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KNBPOLKBOBH(FHFOHBBENOG BLCHDPHIDBL, float3 DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OGKOPMLCDLP(FHFOHBBENOG BLCHDPHIDBL, [Out] float3 DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KIIMKAFOJOH(FHFOHBBENOG BLCHDPHIDBL, float3 DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NCCAILKOPBB(FHFOHBBENOG BLCHDPHIDBL, [Out] float3 DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ACFFABNLFIJ(FHFOHBBENOG BLCHDPHIDBL, (Quaternion rot, Vector3 moments) HFPKCKDFCCP);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool CINCPLMKCEN(FHFOHBBENOG BLCHDPHIDBL, [Out] quaternion PJAOGCBLNOI, [Out] float3 LNDHOECCKFI);

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ICFDKBJJDOH(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 CFMDIJNDEMG(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 MBDCFJCOCCM(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ABGJPOEHLIC(FHFOHBBENOG BLCHDPHIDBL, float3 DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PNOGCACIBJD(FHFOHBBENOG BLCHDPHIDBL, float3 DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float IKGFMLGKDFA(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float HLPMGECDELM(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void KEPCDLPEGGL(FHFOHBBENOG BLCHDPHIDBL, float DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IEMAHFMNBGO(FHFOHBBENOG BLCHDPHIDBL, float DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode FKDGIPMLCGK(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KPGIHOOCNNN(FHFOHBBENOG BLCHDPHIDBL, CollisionDetectionMode DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KCLBDKBPBDN IKMEKAGGHBC(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LFCHAHJHJMC(FHFOHBBENOG BLCHDPHIDBL, KCLBDKBPBDN DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool KEHBDIPKPND(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GFMNOPKLEHI(FHFOHBBENOG BLCHDPHIDBL, bool DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "29")]
	FHFOHBBENOG DLOHKIFFPAL(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GCABBAHMPBN(FHFOHBBENOG BLCHDPHIDBL, FHFOHBBENOG DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "31")]
	FHFOHBBENOG MPDJOKILJNF(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void CHDAKFMCKBA(FHFOHBBENOG BLCHDPHIDBL, FHFOHBBENOG DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "33")]
	HOHJIBLCPPE DMMJJOMCBEG(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void CAPBDFHFKEB(FHFOHBBENOG BLCHDPHIDBL, HOHJIBLCPPE OMNCCIOEEKP);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool KPHHLCIIKLP(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void NPANFJDAAKC(FHFOHBBENOG BLCHDPHIDBL, bool DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool BKBJOJKNHLC(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void LKBJLCGFCCI(FHFOHBBENOG BLCHDPHIDBL, bool DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints CIDHIAEIJLN(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void MNADLDMJBFH(FHFOHBBENOG BLCHDPHIDBL, RigidbodyConstraints DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float NIMEHBLIHBD(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void OBGDDKJMBAE(FHFOHBBENOG BLCHDPHIDBL, float DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float FCCMDCHBPDO(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void OMBKBBAKGBB(FHFOHBBENOG BLCHDPHIDBL, float DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool HJEFGOMCPHN(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void FNLMLJDFGHM(FHFOHBBENOG BLCHDPHIDBL, bool DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool HPHOIGPMGFD(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void ECCEKEBOGBC(FHFOHBBENOG BLCHDPHIDBL, bool DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void LPKMMDPPOLG(FHFOHBBENOG BLCHDPHIDBL, int DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "50")]
	NBCOLHOOHLA PPJNBKMOJHN(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void HAKFLPPEJCC(FHFOHBBENOG BLCHDPHIDBL, NBCOLHOOHLA DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "52")]
	IPMNNOHAGGH FDNDCPHBMJO(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void KJHDHJKJOIA(FHFOHBBENOG BLCHDPHIDBL, IPMNNOHAGGH DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float BGELCCGDDDL(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void NCANMJDHDJF(FHFOHBBENOG BLCHDPHIDBL, float DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void FAHHCOCJBDD(FHFOHBBENOG BLCHDPHIDBL, object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void NNIEFDJNDIM(FHFOHBBENOG BLCHDPHIDBL, object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool BOENJNNMIEE(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void OMEMBKHEHCJ(FHFOHBBENOG BLCHDPHIDBL, object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void IHMBEHOIHPD(FHFOHBBENOG BLCHDPHIDBL, object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool HANOPJJEADM(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool AEIGPEIJBIA(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody IEBBDLBKJAN(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void NEDNCHEMKGP(FHFOHBBENOG BLCHDPHIDBL, Rigidbody AAHNMGFGCFC);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void EEANEJDDGLP(FHFOHBBENOG BLCHDPHIDBL, object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void KLIIOIMOEDI(FHFOHBBENOG BLCHDPHIDBL, object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool CNHFBCNFDMA(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void AOGCCLFCPNA(FHFOHBBENOG BLCHDPHIDBL, float3 PKCNPDCOCJE);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void BNODNPCOFDF(FHFOHBBENOG BLCHDPHIDBL, float3 JHCGPEPGKKC);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool GBPFPPFIJLN(FHFOHBBENOG BLCHDPHIDBL, [Out] float3 PKCNPDCOCJE);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool AAHCMJHCHCF(FHFOHBBENOG BLCHDPHIDBL, [Out] float3 JHCGPEPGKKC);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool AOJAFCMIGNC(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void MFCBNHMMCAM(FHFOHBBENOG BLCHDPHIDBL, object ADNDMAGEPOK, bool GBKJJHMELHF);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void PJONACEGHHG(FHFOHBBENOG BLCHDPHIDBL, bool MIKMPGAKCPP);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void NHOHBDFAIHE(FHFOHBBENOG BLCHDPHIDBL);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool FOGKKNGJJGK(FHFOHBBENOG BLCHDPHIDBL);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface MKIAOOJJGJL
{
	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGKEKGAAOKA(Entity KKNPMPNEAOB);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MIGJMDHNOEH(Entity KKNPMPNEAOB);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface BIFKANEBNBE
{
	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void APCKBDHMCKM(FHFOHBBENOG KCDBINENHAL, bool AHMABNFBLLG);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NAJHNIOGOLL(FHFOHBBENOG KCDBINENHAL, int EKDOAMOHCJD);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public delegate void LKFDOLANFJB(GLMILGNPOGO MMOABPJNIMI);
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct GLMILGNPOGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly GBACJLHJCCJ PKOBHBCOLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NativeArray<byte> IOKCHIINDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly NativeArray<byte> DBBNADPHPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly HBHMLHENCBJ POKGHOJNGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly int MKGMMCBJCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly Type EMJEIICBIJE;

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public GBACJLHJCCJ MDLKNGBBLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x904CD0", Offset = "0x903AD0", VA = "0x180904CD0")]
		get
		{
			return default(GBACJLHJCCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x62FB050", Offset = "0x62F9E50", VA = "0x1862FB050")]
	public GLMILGNPOGO(GBACJLHJCCJ PKOBHBCOLNN, NativeArray<byte> IOKCHIINDMF, NativeArray<byte> DBBNADPHPKE, HBHMLHENCBJ POKGHOJNGNN, int MKGMMCBJCMK, Type EMJEIICBIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x28C59D0", Offset = "0x28C47D0", VA = "0x1828C59D0")]
	public NativeArray<T> MINCOEMNGLL<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x28C5990", Offset = "0x28C4790", VA = "0x1828C5990")]
	public NativeArray<T> KADHLKNCJMB<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x28C58A0", Offset = "0x28C46A0", VA = "0x1828C58A0")]
	public (GBACJLHJCCJ, NativeArray<T>, NativeArray<T>) DJGCEJBDGHO<T>() where T : struct
	{
		return default((GBACJLHJCCJ, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x62FB000", Offset = "0x62F9E00", VA = "0x1862FB000")]
	public IIBHPIOJOII GDDLKHHLCKL()
	{
		return default(IIBHPIOJOII);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public interface KOILEFLDEEF
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	string GAOOJHKPPPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	KOILEFLDEEF PBIKACGPDKN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	IEnumerable<KOILEFLDEEF> NJGGDLECNEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface OECOLBMFIJO
{
	[Cpp2IlInjected.Token(Token = "0x17000181")]
	KOILEFLDEEF MELDOONANJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	List<NHLDGMAIICK> PJHKGKMEHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ENCAHFBHANI(NHLDGMAIICK CINANBNCBIJ, [Out] KOILEFLDEEF JPNFLHEJMOJ);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GEBEKKCKBFI(NHLDGMAIICK CINANBNCBIJ, LKFDOLANFJB MHHMFBKMCKP);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CMPPHHJCDAF(NHLDGMAIICK CINANBNCBIJ, LKFDOLANFJB MHHMFBKMCKP);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public readonly struct IIBHPIOJOII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly GLMILGNPOGO LHODDAGAJKC;

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public GBACJLHJCCJ MDLKNGBBLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x904CD0", Offset = "0x903AD0", VA = "0x180904CD0")]
		get
		{
			return default(GBACJLHJCCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x62FC440", Offset = "0x62FB240", VA = "0x1862FC440")]
	public IIBHPIOJOII(GLMILGNPOGO LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x62FC370", Offset = "0x62FB170", VA = "0x1862FC370")]
	public GBACJLHJCCJ MINCOEMNGLL()
	{
		return default(GBACJLHJCCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x62FC2A0", Offset = "0x62FB0A0", VA = "0x1862FC2A0")]
	public GBACJLHJCCJ KADHLKNCJMB()
	{
		return default(GBACJLHJCCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x62FC180", Offset = "0x62FAF80", VA = "0x1862FC180")]
	public (GBACJLHJCCJ, GBACJLHJCCJ, GBACJLHJCCJ) DJGCEJBDGHO()
	{
		return default((GBACJLHJCCJ, GBACJLHJCCJ, GBACJLHJCCJ));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[DefaultMember("Item")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface ELBHPNHPMMB : IEnumerable<KCEOLLMAHMG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000184")]
	NativeBitArray IBOFFEBACIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	NativeArray<int> GANOJGAIFHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	KCEOLLMAHMG OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	KCEOLLMAHMG OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KCEOLLMAHMG IIJKDDJOKCO(OEOPJAPPBLH OOFPAAIKGCN);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HBHMLHENCBJ PGICMNHMNKK(OEOPJAPPBLH OOFPAAIKGCN);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class BPGKFNKGCOO
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
[DefaultMember("Item")]
public interface DADBFJADEOB : IEnumerable<DCDKOCELNFG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000189")]
	int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	DCDKOCELNFG OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DCDKOCELNFG IIJKDDJOKCO(OEOPJAPPBLH OOFPAAIKGCN);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HBHMLHENCBJ PGICMNHMNKK(OEOPJAPPBLH OOFPAAIKGCN);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class KCOCFIMGEHE
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x294C5D0", Offset = "0x294B3D0", VA = "0x18294C5D0")]
	public static HBHMLHENCBJ PGICMNHMNKK<T>(this DADBFJADEOB BLGIDAACNMF, INGFHJHDPPO<T> PHEKPMAPPHM) where T : struct
	{
		return default(HBHMLHENCBJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
[DefaultMember("Item")]
public interface AFBOJEINDLF : IEnumerable<NHLDGMAIICK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	NHLDGMAIICK OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NHLDGMAIICK IIJKDDJOKCO(OEOPJAPPBLH OOFPAAIKGCN);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HBHMLHENCBJ PGICMNHMNKK(OEOPJAPPBLH OOFPAAIKGCN);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class MKBGBOHKLMC
{
	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x298CEA0", Offset = "0x298BCA0", VA = "0x18298CEA0")]
	public static JOBIOIPMDNN<T> IIJKDDJOKCO<T>(this AFBOJEINDLF BLGIDAACNMF, OEOPJAPPBLH PHEKPMAPPHM) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x298CFE0", Offset = "0x298BDE0", VA = "0x18298CFE0")]
	public static HBHMLHENCBJ PGICMNHMNKK<T>(this AFBOJEINDLF BLGIDAACNMF, INGFHJHDPPO<T> PHEKPMAPPHM) where T : struct
	{
		return default(HBHMLHENCBJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface NCNEBNMPPBF
{
	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEBEKKCKBFI(OEOPJAPPBLH CINANBNCBIJ, LKFDOLANFJB MHHMFBKMCKP);

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CMPPHHJCDAF(OEOPJAPPBLH CINANBNCBIJ, LKFDOLANFJB MHHMFBKMCKP);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class OPDHOPKJFGP
{
	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2A294C0", Offset = "0x2A282C0", VA = "0x182A294C0")]
	public static void GEBEKKCKBFI<T>(this NCNEBNMPPBF HGDJDPOPAMG, INGFHJHDPPO<T> CINANBNCBIJ, LKFDOLANFJB MHHMFBKMCKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A292A0", Offset = "0x2A280A0", VA = "0x182A292A0")]
	public static void CMPPHHJCDAF<T>(this NCNEBNMPPBF HGDJDPOPAMG, INGFHJHDPPO<T> CINANBNCBIJ, LKFDOLANFJB MHHMFBKMCKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface JGFMODKIDFP
{
	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	PDDOFDJMBFO GCBDDAEOBJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GLGFEGPOFJP(KHKDIBBPDLL KCJGNECPFBB, HBHMLHENCBJ CINANBNCBIJ);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFJBKEJJBJL(KHKDIBBPDLL KCJGNECPFBB, Span<HBHMLHENCBJ> BLGIDAACNMF, bool KOFEGEEGNLC);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OACKNNLHCMN(NativeArray<KHKDIBBPDLL> EDMAHOLJFKG);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public static class KFNDPABHHNL
{
	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x6300290", Offset = "0x62FF090", VA = "0x186300290")]
	public static void GFJBKEJJBJL(this JGFMODKIDFP DOAJMMEMDOL, KHKDIBBPDLL KCJGNECPFBB, HBHMLHENCBJ CINANBNCBIJ, bool KOFEGEEGNLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public readonly struct PDDOFDJMBFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly NativeBitArray PGHBFABLFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly NativeParallelHashMap<KHKDIBBPDLL, int> BKMPOLPICIC;

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public bool EHLPLJOEEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x6302C10", Offset = "0x6301A10", VA = "0x186302C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0xBD10E0", Offset = "0xBCFEE0", VA = "0x180BD10E0")]
	public PDDOFDJMBFO(NativeBitArray PGHBFABLFEG, NativeParallelHashMap<KHKDIBBPDLL, int> BKMPOLPICIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x6302AE0", Offset = "0x63018E0", VA = "0x186302AE0")]
	public bool GLGFEGPOFJP(KHKDIBBPDLL KCJGNECPFBB, HBHMLHENCBJ CINANBNCBIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface LECNIOPBCOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAIIJEKOCLH(FHFOHBBENOG BLCHDPHIDBL, LDKPKFGPEFK DIBNBLEEFNN);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface KKCEFHGDDDL
{
	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	JLKPHNPIODB CPCNHHNDNMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface PMNBOILJNEK
{
	[Cpp2IlInjected.Token(Token = "0x17000190")]
	Type PACLFLCMLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[NHEMKOLBJOI(MCNCDDPANDH.LoadInstance)]
public interface HHNFECEIMOO
{
	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHPDLHNPLHK(FHFOHBBENOG ACOAKBIHAJJ, bool DIBNBLEEFNN);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public readonly struct IKIMMADMFAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly IEnumerable<JOPFHGHIGCL> KKEKLKFCIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly IReadOnlyList<GameObject> IAOOKGHGLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly IReadOnlyList<int> CLHNLLLLCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IReadOnlyList<(KHKDIBBPDLL, KHKDIBBPDLL)> IOHDJHAAJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int BMHJNDCCHKK;

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public bool GOBGLGCFBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x62FC470", Offset = "0x62FB270", VA = "0x1862FC470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public int JHLEDLJEKIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x9592D0", Offset = "0x9580D0", VA = "0x1809592D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public IEnumerable<GameObject> MALGJADEBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x9007C0", Offset = "0x8FF5C0", VA = "0x1809007C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public IEnumerable<(KHKDIBBPDLL src, KHKDIBBPDLL dst)> NHBPHOEGGFF
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x62FC850", Offset = "0x62FB650", VA = "0x1862FC850")]
	public IKIMMADMFAH(IEnumerable<JOPFHGHIGCL> KKEKLKFCIAO, IReadOnlyList<GameObject> IAOOKGHGLND, IReadOnlyList<int> CLHNLLLLCNL, IReadOnlyList<(KHKDIBBPDLL src, KHKDIBBPDLL dst)> IOHDJHAAJHP, int BMHJNDCCHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x62FC4D0", Offset = "0x62FB2D0", VA = "0x1862FC4D0")]
	public (GameObject, int)[] MBFJPPGLHIJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface IBJLKBJAADP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000195")]
	bool MNHDNLGGFHG
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	bool FMBEIMPJBCE
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	HNBBFGHKPME EBGBLIEFMLD
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HNPHAEAKEMB CCELGFGAHPO();

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HNPHAEAKEMB IECLBIFLHOL(IEnumerable<FHFOHBBENOG> FOHMKIEPADL, [In] UniformTRS JFMFFCBOACA);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BPPEKEALPPN EOLMMMGAEJK(ByteString IBPJIFGILOI);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LNGBMDDOEOE EGBMPNJBFBK(ByteString FBMAMDNADFD, FHFOHBBENOG OGCHMLDLLMJ, [In] UniformTRS CMMHBHLLEPJ, ALFHJKIDIOH LGBFFJIJJEH, bool HGAANHFMNHH = true);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ODKFIPGFKKN();

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IKIMMADMFAH AADLCLOBHKG(IEnumerable<JOPFHGHIGCL> KKEKLKFCIAO);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class ACAOKHCJGML
{
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface PAEIGMJFNBM
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action NNJBIGIEKNO;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action CHMHDHPHEJD;
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct ONBNBEMIEOD : OMNELJLLMHF, IEquatable<ONBNBEMIEOD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public LGNBEHGCHLL MIEPJJBHNJD;

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6302A20", Offset = "0x6301820", VA = "0x186302A20", Slot = "5")]
	public void FPNHMAJLCHC(BJFFNENABKH HGAPEJGOMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x6302A50", Offset = "0x6301850", VA = "0x186302A50", Slot = "4")]
	public void JPFDICAGNEF(PFDOBINNEOD DFHABBFDBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x6302A80", Offset = "0x6301880", VA = "0x186302A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x888BC0", Offset = "0x8879C0", VA = "0x180888BC0", Slot = "6")]
	public bool Equals(ONBNBEMIEOD GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x6302990", Offset = "0x6301790", VA = "0x186302990", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x905FC0", Offset = "0x904DC0", VA = "0x180905FC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct KHKDIBBPDLL : IComparable<KHKDIBBPDLL>, IEquatable<KHKDIBBPDLL>, OMNELJLLMHF
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const uint BCCPAGBPAMP = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public const uint APLHMEFOBAJ = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly KHKDIBBPDLL AKAAHGKNKOG;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private const int IJHKJHEALHC = 24;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private const uint MANIHGONPNI = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private const int GEJCDIOIAED = 8;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private const uint CLFCAPLKJHH = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly uint KKAMOMBNLOJ;

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public uint EKIMEFBLGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x7FC150", Offset = "0x7FAF50", VA = "0x1807FC150")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public uint ACOGNAIJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x63004E0", Offset = "0x62FF2E0", VA = "0x1863004E0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public uint JDKLKJIEBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x905FC0", Offset = "0x904DC0", VA = "0x180905FC0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public bool GOBGLGCFBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x626A5E0", Offset = "0x62693E0", VA = "0x18626A5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0xD6EEB0", Offset = "0xD6DCB0", VA = "0x180D6EEB0")]
	public static KHKDIBBPDLL PHLPDEEANDK(uint KKAMOMBNLOJ)
	{
		return default(KHKDIBBPDLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x63005E0", Offset = "0x62FF3E0", VA = "0x1863005E0")]
	public KHKDIBBPDLL(int POAKOKLLPFF, int LFGCGIBDHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x63005E0", Offset = "0x62FF3E0", VA = "0x1863005E0")]
	public KHKDIBBPDLL(uint POAKOKLLPFF, int LFGCGIBDHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x63005E0", Offset = "0x62FF3E0", VA = "0x1863005E0")]
	public KHKDIBBPDLL(uint POAKOKLLPFF, uint LFGCGIBDHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0")]
	private KHKDIBBPDLL(uint KKAMOMBNLOJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x1883660", Offset = "0x1882460", VA = "0x181883660")]
	public static bool OFKPFEHPLBH(KHKDIBBPDLL CGAHKNIFIAB, KHKDIBBPDLL CJOKOOBKDLJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x63003E0", Offset = "0x62FF1E0", VA = "0x1863003E0")]
	public static bool CAAJBKCJNPA(KHKDIBBPDLL CGAHKNIFIAB, KHKDIBBPDLL CJOKOOBKDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x888BC0", Offset = "0x8879C0", VA = "0x180888BC0", Slot = "5")]
	public bool Equals(KHKDIBBPDLL NLFEJIHGBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x63003F0", Offset = "0x62FF1F0", VA = "0x1863003F0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x2353E50", Offset = "0x2352C50", VA = "0x182353E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x6300550", Offset = "0x62FF350", VA = "0x186300550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x63004F0", Offset = "0x62FF2F0", VA = "0x1863004F0", Slot = "6")]
	public void JPFDICAGNEF(PFDOBINNEOD DFHABBFDBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x6300480", Offset = "0x62FF280", VA = "0x186300480", Slot = "7")]
	public void FPNHMAJLCHC(BJFFNENABKH HGAPEJGOMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x6218CB0", Offset = "0x6217AB0", VA = "0x186218CB0", Slot = "4")]
	public int CompareTo(KHKDIBBPDLL GGINNHLAMLI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct JOPFHGHIGCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Guid IIGMMHCLOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public string IOAKLAMDNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Vector3 JPLKOMKCHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Quaternion IHHAEIJMAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Vector3 HDBPIAOAHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public int AMIMMNABDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Dictionary<string, object> AHMCCAODOOJ;

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x62FFE20", Offset = "0x62FEC20", VA = "0x1862FFE20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x62FFCA0", Offset = "0x62FEAA0", VA = "0x1862FFCA0")]
	private static string MPECPFBOGJN(Dictionary<string, object> PLBNFDOAGDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public enum OCLEPPKAJJF
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class JCBDNLHMPGI
{
	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x577F6D0", Offset = "0x577E4D0", VA = "0x18577F6D0")]
	public static bool OOIDFNDBAJM(this OCLEPPKAJJF DDEINLAGLLL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[Flags]
public enum GBAIJNNAPPG
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	AdditivePhases = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public interface LNGBMDDOEOE : HNBBFGHKPME, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	ALFHJKIDIOH COBGKMHGKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHOFDHJJGBG();

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFAEHDNINCM();
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public interface HNBBFGHKPME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	IEnumerable<JOPFHGHIGCL> IPFLIHEBOFM
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	IKIMMADMFAH OGLHBIIJKMG
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	LocalId OCHLBFCCEJI
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	NOJGMPCAFBF AGBAOBCBNFD
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HBPDLPEKCDF(GBAIJNNAPPG POFMIOGCEHI);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public interface ALFHJKIDIOH
{
	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMJDCPDOMLL(Guid EKLFCLOPJMB, [Out] Guid ANFNAKKPDIL);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public interface BPPEKEALPPN : HNBBFGHKPME, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[Flags]
public enum FKFBMIFKHAL
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public interface HNPHAEAKEMB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	NOJGMPCAFBF FGNKDIMDPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString HONOPDMCGLI();
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public enum FIAEPCHEMOA
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public delegate bool HOMOACBIJON(BGGKKHHKJIL NLFOPPHECAB, [In] MLNIKOGIMEN DIBNBLEEFNN);
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public delegate bool AKHKPLHJMPO<T>(BGGKKHHKJIL NLFOPPHECAB, [In] T DIBNBLEEFNN);
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface PDEOCMPPCPO
{
	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEBEKKCKBFI(HBHMLHENCBJ POKGHOJNGNN, Type JEFNKFGFJJC, HOMOACBIJON MPHLOEHHNDN);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IBLENJCLCNE(HBHMLHENCBJ POKGHOJNGNN, [Out] HOMOACBIJON MPHLOEHHNDN);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class EHHJJOGKIND
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class GCCBHEFKFHA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AKHKPLHJMPO<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public GCCBHEFKFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x38FC170", Offset = "0x38FAF70", VA = "0x1838FC170")]
		internal bool ELFJMAHKENC(BGGKKHHKJIL pendingList, [In] MLNIKOGIMEN value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2771120", Offset = "0x276FF20", VA = "0x182771120")]
	public static void GEBEKKCKBFI<T>(this PDEOCMPPCPO HGDJDPOPAMG, HBHMLHENCBJ POKGHOJNGNN, AKHKPLHJMPO<T> MPHLOEHHNDN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x62F6A20", Offset = "0x62F5820", VA = "0x1862F6A20")]
	public static bool OKHCFOOFEFC(this PDEOCMPPCPO HGDJDPOPAMG, BGGKKHHKJIL NLFOPPHECAB, HBHMLHENCBJ POKGHOJNGNN, [In] MLNIKOGIMEN DIBNBLEEFNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface PHEEAFJINDJ
{
	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	uint AMMAADDMDJH
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface BGGKKHHKJIL
{
	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGPEEKIGIJJ(KHKDIBBPDLL NGPCLGFJLIJ, HBHMLHENCBJ POKGHOJNGNN, ReadOnlySpan<byte> COEHFIHIGOA, ReadOnlySpan<byte> CLKLEFGOOAP);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GBKLMLNJGFF(KHKDIBBPDLL NGPCLGFJLIJ, HBHMLHENCBJ POKGHOJNGNN);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ADBHPONMKMB(KHKDIBBPDLL NGPCLGFJLIJ, HBHMLHENCBJ POKGHOJNGNN, ReadOnlySpan<byte> CLKLEFGOOAP);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FBDPNKNPFHM(KHKDIBBPDLL NGPCLGFJLIJ, HBHMLHENCBJ POKGHOJNGNN, Span<byte> COEHFIHIGOA, Span<byte> CLKLEFGOOAP);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class NNMMAEGGPAE
{
	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A880", Offset = "0x2A09680", VA = "0x182A0A880")]
	public static bool FBDPNKNPFHM<T>(this BGGKKHHKJIL HDHKCNLKHFP, KHKDIBBPDLL NGPCLGFJLIJ, HBHMLHENCBJ POKGHOJNGNN, [Out] T COEHFIHIGOA, [Out] T CLKLEFGOOAP) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A760", Offset = "0x2A09560", VA = "0x182A0A760")]
	public static bool ADBHPONMKMB<T>(this BGGKKHHKJIL HDHKCNLKHFP, KHKDIBBPDLL NGPCLGFJLIJ, HBHMLHENCBJ POKGHOJNGNN, T CLKLEFGOOAP) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public enum MNPENABGAMC
{
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface PKPGGBOAHOE
{
	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPOONDJOEBN(DKDCGBLKAPE PFNKIIMPMKG, ReadOnlySpan<byte> PENMOOOPINK);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGNICGOOCIA(uint KKOLFKPALFD, ReadOnlySpan<byte> PENMOOOPINK);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FOOFIJCEBDN(int FHJHDBCPKDG);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface NEIEBNNNIHE
{
	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DKDCGBLKAPE NMANLPAFFOD(ReadOnlySpan<byte> PENMOOOPINK);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface LOOMBKHMJJO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GALHCDFHEDH(DKDCGBLKAPE OBPLDLNDJLE, ReadOnlySpan<byte> PENMOOOPINK);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFGHJPEPAKF(ReadOnlySpan<DKDCGBLKAPE> FOFNEPJBCEK);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public struct FFMLLHEIHEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public DKDCGBLKAPE PFNKIIMPMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public ReadOnlyMemory<byte> PENMOOOPINK;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public struct DKDCGBLKAPE
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public static DKDCGBLKAPE GIPDCGAOFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public uint POAKOKLLPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public int KMPNBFMAGJP;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0xAE9A50", Offset = "0xAE8850", VA = "0x180AE9A50")]
	public DKDCGBLKAPE(uint POAKOKLLPFF, int KMPNBFMAGJP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x62F5970", Offset = "0x62F4770", VA = "0x1862F5970")]
	public static bool OFKPFEHPLBH([In] DKDCGBLKAPE MAEINFGKCEL, [In] DKDCGBLKAPE FLBFHNBPNFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x62F5890", Offset = "0x62F4690", VA = "0x1862F5890", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x62F5940", Offset = "0x62F4740", VA = "0x1862F5940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x62F59A0", Offset = "0x62F47A0", VA = "0x1862F59A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x62F5990", Offset = "0x62F4790", VA = "0x1862F5990")]
	public void PHDHBCEACMN([Out] uint POAKOKLLPFF, [Out] int KMPNBFMAGJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface JBGLDNBJBAL : HFBBPAMKKJL<JBGLDNBJBAL>
{
	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HIBEGIGNEIP(HBHMLHENCBJ NLFEJIHGBIC, [Out] CPIGBELMOFB LNOAGJKLBNI);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public static class PBDLCMBLNGB
{
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public interface CPIGBELMOFB
{
	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	Type MAHGJMKOGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPNHMAJLCHC(BJFFNENABKH HGAPEJGOMLD, Span<byte> KCDBINENHAL);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPFDICAGNEF(PFDOBINNEOD DFHABBFDBND, ReadOnlySpan<byte> PFNKIIMPMKG);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class LJOIIJMDPJD
{
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public struct EGOEDPGDNJL : ISystemStateComponentData, IComponentData, IEquatable<EGOEDPGDNJL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 HPDLBBBABGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float3 DDAKJIOGBDN;

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x62F69A0", Offset = "0x62F57A0", VA = "0x1862F69A0", Slot = "4")]
	public bool Equals(EGOEDPGDNJL GGINNHLAMLI)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class LDJNHENMGAB
{
	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public LDJNHENMGAB()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
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
