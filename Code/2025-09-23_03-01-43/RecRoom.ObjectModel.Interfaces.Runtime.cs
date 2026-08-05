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
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86E09C0", Offset = "0x86DEFC0", VA = "0x1886E09C0", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PEDEPBEOBLC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x86E8680", Offset = "0x86E6C80", VA = "0x1886E8680")]
	public static void DJHDBLOBHHB(this Rigidbody BBBGKMHBFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x86E8550", Offset = "0x86E6B50", VA = "0x1886E8550")]
	public static void DJHDBLOBHHB(this Rigidbody BBBGKMHBFLM, Vector3 MFAKPHMJPFP, Quaternion OBIDNALIIPD, Vector3 BJGMDAOLEPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct PDHGKNBOAKO : IReadOnlyList<NLPLHJLLGBB>, IEnumerable<NLPLHJLLGBB>, IEnumerable, IReadOnlyCollection<NLPLHJLLGBB>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct INJOMFCHHBJ : IEnumerator<NLPLHJLLGBB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly HNBHNOBANOG MIKGDJBNCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator DPOHFMKDFJP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NLPLHJLLGBB MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x86DCF20", Offset = "0x86DB520", VA = "0x1886DCF20", Slot = "4")]
			get
			{
				return default(NLPLHJLLGBB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x86DCED0", Offset = "0x86DB4D0", VA = "0x1886DCED0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x57AFA90", Offset = "0x57AE090", VA = "0x1857AFA90")]
		public INJOMFCHHBJ(HNBHNOBANOG MIKGDJBNCFJ, NativeArray<LocalId>.Enumerator DPOHFMKDFJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86DCE10", Offset = "0x86DB410", VA = "0x1886DCE10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86DCE50", Offset = "0x86DB450", VA = "0x1886DCE50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x86DCE90", Offset = "0x86DB490", VA = "0x1886DCE90", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NIPCMAEPLKK MNHLJANEAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> LFFADIOANKA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NLPLHJLLGBB LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86E84D0", Offset = "0x86E6AD0", VA = "0x1886E84D0", Slot = "4")]
		get
		{
			return default(NLPLHJLLGBB);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86E7AB0", Offset = "0x86E60B0", VA = "0x1886E7AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int FEPECOMLLNG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HNBHNOBANOG EIBKLMACMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x86E7A60", Offset = "0x86E6060", VA = "0x1886E7A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int AOCLJDLKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OBNBONBFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86E7D50", Offset = "0x86E6350", VA = "0x1886E7D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> IGHHAJMCEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2D63650", Offset = "0x2D61C50", VA = "0x182D63650")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> GGOAMJEBBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x86E8000", Offset = "0x86E6600", VA = "0x1886E8000")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86E82F0", Offset = "0x86E68F0", VA = "0x1886E82F0")]
	public PDHGKNBOAKO(int AHIAOIDMGDN, HNBHNOBANOG MIKGDJBNCFJ, Allocator EEDCBHBBPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x86E83A0", Offset = "0x86E69A0", VA = "0x1886E83A0")]
	public PDHGKNBOAKO(NIPCMAEPLKK MNHLJANEAIO, NativeArray<LocalId> LFFADIOANKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x86E8460", Offset = "0x86E6A60", VA = "0x1886E8460")]
	public PDHGKNBOAKO(NIPCMAEPLKK MNHLJANEAIO, NativeArray<Entity> LFFADIOANKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x86E8260", Offset = "0x86E6860", VA = "0x1886E8260")]
	internal PDHGKNBOAKO(HNBHNOBANOG MIKGDJBNCFJ, NativeArray<Entity> MEJIKACDFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x86E81F0", Offset = "0x86E67F0", VA = "0x1886E81F0")]
	internal PDHGKNBOAKO(HNBHNOBANOG MIKGDJBNCFJ, NativeArray<LocalId> LFFADIOANKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x86E8140", Offset = "0x86E6740", VA = "0x1886E8140")]
	public PDHGKNBOAKO(HNBHNOBANOG MIKGDJBNCFJ, int NODGHDHCBPE, Allocator EEDCBHBBPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x86E83B0", Offset = "0x86E69B0", VA = "0x1886E83B0")]
	public PDHGKNBOAKO(PDHGKNBOAKO IDBPFENAGDA, Allocator EEDCBHBBPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x86E7D90", Offset = "0x86E6390", VA = "0x1886E7D90")]
	public void OCEKIKEEKEK(List<NLPLHJLLGBB> BBBJHCKNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x86E7D00", Offset = "0x86E6300", VA = "0x1886E7D00")]
	public void JOIHFAMFLJI(int PMIGBJGNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x86E7C60", Offset = "0x86E6260", VA = "0x1886E7C60")]
	public PDHGKNBOAKO JGHKMFOJCLP(Allocator EEDCBHBBPKF)
	{
		return default(PDHGKNBOAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x86E7B10", Offset = "0x86E6110", VA = "0x1886E7B10")]
	public Span<NLPLHJLLGBB> GOEDBCODEJM()
	{
		return default(Span<NLPLHJLLGBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x86E79C0", Offset = "0x86E5FC0", VA = "0x1886E79C0")]
	public PDHGKNBOAKO EBJNBHKJFBA(int GHOFJOJMCOI, int NODGHDHCBPE)
	{
		return default(PDHGKNBOAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x86E7980", Offset = "0x86E5F80", VA = "0x1886E7980", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x86E78C0", Offset = "0x86E5EC0", VA = "0x1886E78C0")]
	public INJOMFCHHBJ ABGODHCJODA()
	{
		return default(INJOMFCHHBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x86E8060", Offset = "0x86E6660", VA = "0x1886E8060", Slot = "6")]
	private IEnumerator<NLPLHJLLGBB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x86E80D0", Offset = "0x86E66D0", VA = "0x1886E80D0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LLCLHKEADHC
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3EBB9B0", Offset = "0x3EB9FB0", VA = "0x183EBB9B0")]
	public static KIOIAGMFEML<T> DKAEBOKGIGL<T>(this PDHGKNBOAKO PPEFJKBNOEP) where T : Component
	{
		return default(KIOIAGMFEML<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct BBBGMONOBKI : IList<NLPLHJLLGBB>, ICollection<NLPLHJLLGBB>, IEnumerable<NLPLHJLLGBB>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct MOMMDBHGAHA : IEnumerator<NLPLHJLLGBB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly HNBHNOBANOG MIKGDJBNCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator DPOHFMKDFJP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NLPLHJLLGBB MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x86E1210", Offset = "0x86DF810", VA = "0x1886E1210", Slot = "4")]
			get
			{
				return default(NLPLHJLLGBB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x86E11C0", Offset = "0x86DF7C0", VA = "0x1886E11C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x57AFA90", Offset = "0x57AE090", VA = "0x1857AFA90")]
		public MOMMDBHGAHA(HNBHNOBANOG MIKGDJBNCFJ, NativeArray<LocalId>.Enumerator DPOHFMKDFJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86E1100", Offset = "0x86DF700", VA = "0x1886E1100", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x86E1140", Offset = "0x86DF740", VA = "0x1886E1140", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x86E1180", Offset = "0x86DF780", VA = "0x1886E1180", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HNBHNOBANOG MIKGDJBNCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> LFFADIOANKA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NLPLHJLLGBB LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86D1610", Offset = "0x86CFC10", VA = "0x1886D1610", Slot = "4")]
		get
		{
			return default(NLPLHJLLGBB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x86D1700", Offset = "0x86CFD00", VA = "0x1886D1700", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86D1060", Offset = "0x86CF660", VA = "0x1886D1060", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int AOCLJDLKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86D1060", Offset = "0x86CF660", VA = "0x1886D1060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> IGHHAJMCEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2D63650", Offset = "0x2D61C50", VA = "0x182D63650")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool BOFAKENAFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x86D1590", Offset = "0x86CFB90", VA = "0x1886D1590")]
	public BBBGMONOBKI(HNBHNOBANOG MIKGDJBNCFJ, Allocator EEDCBHBBPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x86D1500", Offset = "0x86CFB00", VA = "0x1886D1500")]
	public BBBGMONOBKI(HNBHNOBANOG MIKGDJBNCFJ, int NODGHDHCBPE, Allocator EEDCBHBBPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x86D0CB0", Offset = "0x86CF2B0", VA = "0x1886D0CB0")]
	public PDHGKNBOAKO CACDKEJBKIL()
	{
		return default(PDHGKNBOAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x86D0DC0", Offset = "0x86CF3C0", VA = "0x1886D0DC0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x86D0E00", Offset = "0x86CF400", VA = "0x1886D0E00", Slot = "13")]
	public bool Contains(NLPLHJLLGBB NANHMPOBBLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x86D0E90", Offset = "0x86CF490", VA = "0x1886D0E90", Slot = "14")]
	public void CopyTo(NLPLHJLLGBB[] GHKPAFFMJAO, int MHIOAOJIPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x86D0C30", Offset = "0x86CF230", VA = "0x1886D0C30", Slot = "11")]
	public void Add(NLPLHJLLGBB NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x86D1170", Offset = "0x86CF770", VA = "0x1886D1170", Slot = "7")]
	public void Insert(int PMIGBJGNLLP, NLPLHJLLGBB NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x86D1270", Offset = "0x86CF870", VA = "0x1886D1270", Slot = "15")]
	public bool Remove(NLPLHJLLGBB NANHMPOBBLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x86D10E0", Offset = "0x86CF6E0", VA = "0x1886D10E0", Slot = "6")]
	public int IndexOf(NLPLHJLLGBB NANHMPOBBLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86D1220", Offset = "0x86CF820", VA = "0x1886D1220", Slot = "8")]
	public void RemoveAt(int PMIGBJGNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x86D10A0", Offset = "0x86CF6A0", VA = "0x1886D10A0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x86D0BA0", Offset = "0x86CF1A0", VA = "0x1886D0BA0")]
	public MOMMDBHGAHA ABGODHCJODA()
	{
		return default(MOMMDBHGAHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x86D1340", Offset = "0x86CF940", VA = "0x1886D1340", Slot = "16")]
	private IEnumerator<NLPLHJLLGBB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x86D1420", Offset = "0x86CFA20", VA = "0x1886D1420", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HLLJOMFNLML : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NLPLHJLLGBB LNGEBDOJEJA(NLPLHJLLGBB LFFADIOANKA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FEDGLBAGMLE : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface BKHIMACOKMN : HACIDCOMDGE, AOGHPIKHELF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	ELCJHMDILDE GFLLHGLFKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NIPCMAEPLKK GJLBLBNFCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface AOGHPIKHELF
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CEILCAIBNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface ALJOCMHJIHL
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKIKLGNPEMH(bool KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELFNJAKNOMA();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface CIHJELMIPDH
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool JKEKNGDCJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool BBHEMKHLDBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool MEPCHBJEJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool ENPCJKHPHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool AKJKFFEGBOF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NCCFAEBGKNH(bool KBMMNNBFAAB);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FNDHHKPEPPP(ByteString EFBHHMENDFE);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AFDNMICNNBG();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PNMMFADLOLB();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IKKKHOBCEND();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface FIMHEFEBFND
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	CNPFBIMHGJN GFLLHGLFKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	LAENNFNMBAD BDHGNMLOIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	HKOHKDOPABA OLLAOALLLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	BKHIMACOKMN KKJADCNLGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	BOCDBMLPKHD OANAMOBGLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	CIHJELMIPDH BJAPLKOANMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	JNPPPJEJEON NBBLIJNKCDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	JOHJCGOKEFI ELKMNFOACHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	AFGPKHPOMIB GPDHIPOHABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	OJHGNPOOCLL NHMEMMHBOAI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	ACBKFBLFNKE FOAFDCKLDNM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	KIDLMHKNMCG MMHCLKMKPKH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	HNBHNOBANOG EIBKLMACMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	EGJJOCNMGDI KOLFHMIFFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	GKHBFHMKFME NIOGLIMGMHE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	GGLAFGKFCFM LJDKFLFHCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	NFKKFHABOFJ FGEBKLOKLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	EPGFAFJFPFA OIPIBCCOJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	BFFDFPCIJKG HIHPNOJJOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	IDCEBPCFOEC DAEAGPKLHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	GIJFGJDKJOB AJEHGPBIFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	LPKPBMLEPMA DKAHEBFMKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	IODFBDKJMNJ BBABOIBDAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	LLMJJJMPAJL OPEHEBEPHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	HCLANLDBIPL HJHEDNPGJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	ANDDHMDHIDP LOJNAMCBDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	MOMAELGFDAM AEAFKICBBHF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	BLCEJAOLGDJ FACHAJJABEC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	FGEEBEOFLCG NDEBNEMINMA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IOAHMMMBCHD NMGOFGODOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	GDMDBDLOIBN GEDBECHJLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	EPCIOFAAGGG CADNOFCPFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IBGFOGGBNCJ HAFJDNKDDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	OIEDFIPBJNH BFGAHJMFJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	HJAJILCFGKE KJDFDKMELAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	IEGDCHKOMEL MMICEFECNMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	LJFAHJAJKGF DAOJLPEMJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	OHOEFFCOCHD OJFMKGGONDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	MKENBHEPBNB KONGFMEEEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	BMLFEODEIIG EIBHLIKKBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerTypeProxy(typeof(HIONGJCBNJE))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct NLPLHJLLGBB : IComparable<NLPLHJLLGBB>, IEquatable<NLPLHJLLGBB>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly NLPLHJLLGBB IDBBECHCNHL;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int GFCDAIIALCP = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int FKMNAPNEHOJ = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int DACKCHCHHNN = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int GHLBCAFJNPJ = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId BJCKBJFHLNJ;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public HNBHNOBANOG EIBKLMACMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x86D3E60", Offset = "0x86D2460", VA = "0x1886D3E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public BKHIMACOKMN KKJADCNLGCO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x86E3090", Offset = "0x86E1690", VA = "0x1886E3090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public LocalId NFJMHCPMCHL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x86E2F70", Offset = "0x86E1570", VA = "0x1886E2F70")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal NIPCMAEPLKK GJLBLBNFCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x86E3030", Offset = "0x86E1630", VA = "0x1886E3030")]
		get
		{
			return default(NIPCMAEPLKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool CCCINLIBFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x86E2BD0", Offset = "0x86E11D0", VA = "0x1886E2BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private bool NNCKPJJGMCM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x86E3040", Offset = "0x86E1640", VA = "0x1886E3040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x86E3340", Offset = "0x86E1940", VA = "0x1886E3340")]
	public NLPLHJLLGBB(HNBHNOBANOG NDLBBNEGDEM, LocalId BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x86E3400", Offset = "0x86E1A00", VA = "0x1886E3400")]
	public NLPLHJLLGBB(NIPCMAEPLKK MNHLJANEAIO, LocalId BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
	public CENLKEFEGPJ IBCFIACEEMO()
	{
		return default(CENLKEFEGPJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x86E2FF0", Offset = "0x86E15F0", VA = "0x1886E2FF0")]
	public static LocalId HNGLNPFKABH(NLPLHJLLGBB CNPIFIIPICN)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x86E2FB0", Offset = "0x86E15B0", VA = "0x1886E2FB0")]
	public static Entity HNGLNPFKABH(NLPLHJLLGBB CNPIFIIPICN)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x86E30F0", Offset = "0x86E16F0", VA = "0x1886E30F0")]
	public static bool MGLHCKHANFO(NLPLHJLLGBB JGPEJMANNEB, NLPLHJLLGBB PDHHCOODKIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x86D1C90", Offset = "0x86D0290", VA = "0x1886D1C90")]
	public static bool HKOGMNAKMAE(NLPLHJLLGBB JGPEJMANNEB, NLPLHJLLGBB PDHHCOODKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x86E3210", Offset = "0x86E1810", VA = "0x1886E3210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x86E2DE0", Offset = "0x86E13E0", VA = "0x1886E2DE0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x86E2CF0", Offset = "0x86E12F0", VA = "0x1886E2CF0", Slot = "4")]
	public int CompareTo(NLPLHJLLGBB AAGCKLPFJME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "5")]
	public bool Equals(NLPLHJLLGBB AAGCKLPFJME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PHKJLIPJCEK
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x86E9280", Offset = "0x86E7880", VA = "0x1886E9280")]
	public static NEKBNCKOEOB PAHDNGBIDGC(this NLPLHJLLGBB MPIDDJPOOMJ)
	{
		return default(NEKBNCKOEOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class HIONGJCBNJE
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct NIPCMAEPLKK : IEquatable<NIPCMAEPLKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte MNHLJANEAIO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] NMIBJADALJH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static HNBHNOBANOG CPGOBHDFBCE;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static BKHIMACOKMN LFBKOBPFCLE;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static HNBHNOBANOG[] EFFFNEAMIJB;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static BKHIMACOKMN[] JMEIDMLCGOH;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> POJGFHCEICE;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public BKHIMACOKMN KKJADCNLGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x86E20C0", Offset = "0x86E06C0", VA = "0x1886E20C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public HNBHNOBANOG LGLJAKJALHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x86E25D0", Offset = "0x86E0BD0", VA = "0x1886E25D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x86E2BC0", Offset = "0x86E11C0", VA = "0x1886E2BC0")]
	static NIPCMAEPLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2DB7910", Offset = "0x2DB5F10", VA = "0x182DB7910")]
	internal NIPCMAEPLKK(byte KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x74DB0C0", Offset = "0x74D96C0", VA = "0x1874DB0C0", Slot = "4")]
	public bool Equals(NIPCMAEPLKK AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x86E1CE0", Offset = "0x86E02E0", VA = "0x1886E1CE0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x10D68B0", Offset = "0x10D4EB0", VA = "0x1810D68B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x86E2B00", Offset = "0x86E1100", VA = "0x1886E2B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x86E1F90", Offset = "0x86E0590", VA = "0x1886E1F90")]
	private static HNBHNOBANOG IJFNIMNAOPB(byte MNHLJANEAIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x86E26B0", Offset = "0x86E0CB0", VA = "0x1886E26B0")]
	private static BKHIMACOKMN PCABNKFABFI(byte MNHLJANEAIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x86E21A0", Offset = "0x86E07A0", VA = "0x1886E21A0")]
	private static object MOEBEHJHCHG(byte MNHLJANEAIO, object[] LGMBOCEBOMM, object APJDJFMLEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x86E1CC0", Offset = "0x86E02C0", VA = "0x1886E1CC0")]
	private static int DBBFCOKKLMA(byte MNHLJANEAIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x86E2AF0", Offset = "0x86E10F0", VA = "0x1886E2AF0")]
	private static int PPHEAHPKLIP(byte MNHLJANEAIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x86E2040", Offset = "0x86E0640", VA = "0x1886E2040")]
	private static (int, int) ILOKENDJOJG(byte MNHLJANEAIO)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x86E1CD0", Offset = "0x86E02D0", VA = "0x1886E1CD0")]
	private static byte DEMMNBCCGHC(int AENIMEGPBEO, int PMIGBJGNLLP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x86E2310", Offset = "0x86E0910", VA = "0x1886E2310")]
	internal static NIPCMAEPLKK NCEHDCEOICJ(BKHIMACOKMN ALEMNOAOHPA, HNBHNOBANOG PFACHOGLMAE)
	{
		return default(NIPCMAEPLKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x86E1D80", Offset = "0x86E0380", VA = "0x1886E1D80")]
	internal static void HKHOCFFLDMG(NIPCMAEPLKK MNHLJANEAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x86E2760", Offset = "0x86E0D60", VA = "0x1886E2760")]
	private static void PNIDBEBHDLB(int AHIAOIDMGDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum GECNDDPDPGB
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
public interface ELKFGJKILAN
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool GJNEFAJNPHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool HGKAHOMMAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool MMGCOAEOGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool MGPMNFKCPIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool GFJJKJPDJMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KOBFKCBIAIB
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CFPBALFCIJN(JAFBOAANIOO JBBCAANONNB, int PMIGBJGNLLP);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NEGAEAALFPJ(JAFBOAANIOO NPJKPHOCIHA, int PMIGBJGNLLP);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CFMIKDMOEPI(KGMKOBIBAKM HKNMPOMKMFD, int PMIGBJGNLLP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LPIPGOFPIAJ : JAFBOAANIOO, ELKFGJKILAN
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	int NHJDPOJGLIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLGNBAAFCBG(CKFNIPKIHDA KOJIMAFGDLP, int PMIGBJGNLLP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JAFBOAANIOO : ELKFGJKILAN
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum ANLPFCFCMLB
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
	bool LCHHEMKKHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool EAOFEGBMJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool HOHCDFEHJEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CKFNIPKIHDA
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool GJFKHDEBHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	PINBFOAJNAG JBDCFMHPLKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	PKDPNIDDECP JKOGLCLPFFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float3 PGBNPPMBLDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	quaternion BGKDKGECOAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float3 KHGBNADOONJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	HMCCGFBIKNJ GOHKLGDEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	GCJNBCEMIDE CAPMFCMMIDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float OAIKINPPNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	float3 EOCKFJJEBCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	float PIFDDJJGKOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	LIJKMCLPLEC FHDDNCDOEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DLLAKCBDCAA
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	float3 KNGNNNLEBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	float3 AJPCLIGCMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion DMJEBPFGJBJ(float3 MIFKFCAJJIH);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface PKDPNIDDECP
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool BNELHJIHEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool ABDJDENNPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool NIAIKODDALN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float JFBOACLEGLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	int IDDNLFFCBHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	int MGKOBDGCDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PDDEHLOIKJK(DLLAKCBDCAA KOJIMAFGDLP, int PMIGBJGNLLP);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.OMRoom)]
public class OJPONLCABHL
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public OJPONLCABHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface IINFJMECDIM
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Guid DMMFHPPBELL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LENGDGJKHFA(Guid BODLIFJJHFF, Guid PLBMJMHLGMM, Guid IIMKJNFIDIO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task EOMDGLGFBEF(Guid BODLIFJJHFF, Guid[] ILMBAOKGDLA, Guid IIMKJNFIDIO);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid AMCIJPAHDNE(Guid HCMLLANKMHP);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HKHHGNEEMBA(NLPLHJLLGBB NJEDNOMICCA);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GKCIFFFNDHB(Guid HCMLLANKMHP);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MHANLLFBPLD(KLHPGMPFKMA HKKPBEJOPND, Guid HAFEAFPCNCK);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FNNHOHMBBHL(Guid HCMLLANKMHP, bool KBMMNNBFAAB);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AACOFDNBFDD(Guid HCMLLANKMHP, NEKBNCKOEOB IBACMIDAKGN);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KIMICEJCPFJ(NEKBNCKOEOB IBACMIDAKGN);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PBOBONBNLMA(NLPLHJLLGBB BJCKBJFHLNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface KFOKIKACKHP
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface NLMHFFKGNLL
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "0")]
	void LDHPDAECACA(bool ALDDDKDADPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface LAENNFNMBAD
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	NLMHFFKGNLL PBJDJNKCGAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	OABIKPJHDHF PMFDIHDLGOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	FBHCNKKFLBG OCPONBAECJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	KBDJBAENJPE FEMBLANMJKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	CNKHDPAHPHO FAHBNDMPLNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	DLIAJHFCPBA NCMCNJKCLEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	IPJCLFGKDLA KIFOPGFNPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	GEGFAGGABJJ KHMLECEJGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface OABIKPJHDHF
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	string APJBAFAFNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface MPGMIBPKLDK
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOKHBOOGIEN(Action PMBBLAOPHON, bool CCFAJMJKKEC);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CKJJBIIDLIL(string NDIENANOGEK);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BFKBMPCOKDL(string NDIENANOGEK, int APJDJFMLEAP);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HIJOMDPCDGL([Out] bool KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ODELBPJLAPO([Out] bool KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GCINCHEALHI([Out] int KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HEFPIEHJCND([Out] bool KOPHBHGIACG);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface FBHCNKKFLBG
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "0")]
	void BAOIDPKDGNJ(bool KBMMNNBFAAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface KBDJBAENJPE
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid NDHGACCNGIG;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid HACAHPFKPMP;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid GFJFHPNMLPE;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid PGEMMGKBMNN;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool NFODKPEDMGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool OPFIGBAHLPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool EEJBFLDLEAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool IICKDGNADDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x86DE0A0", Offset = "0x86DC6A0", VA = "0x1886DE0A0", Slot = "4")]
	string[] ALPJGMEOBLE(DGKLLKHIJBK ILDPPLPIIKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NAJOIDDNNPP();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x86DE130", Offset = "0x86DC730", VA = "0x1886DE130", Slot = "6")]
	Guid CDCJANMLFJM(Guid GHPMHLIIIED)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int OJCACDCCLNK(DGKLLKHIJBK ILDPPLPIIKF);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PIKJGHCOINI(DGKLLKHIJBK ILDPPLPIIKF, NativeArray<AOOOOBNIDMA> NJJNEHDIBNF, NativeList<UniformTRS> IAGJJDAHIFM);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int LBFDGJMIMAM(Guid JJCLDINKIFD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool HNAHMIHKKPK(string CDCAHPOCPKO, [Out] Guid JJCLDINKIFD);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string LIKEJICPAGK(Guid JJCLDINKIFD);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MLICJLNLPAL(RRObjectPrefabData NEDKLGJKLNI, [Out] LocalId JAPNANJIKLB);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KIOIAGMFEML<byte[]> KIJFAGLJPOI(NativeArray<AOOOOBNIDMA> ALJGFPNHKEF);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DCIKAPMPOJB(byte[] EBMALMPGBIG);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GameObject AOEIJMAPHEF(string CDCAHPOCPKO);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PBKOCNIPCOC(Transform CCHLCEHOKAD, RRObjectPrefabData LDHBFMLLMMM, AIJJICHNHLM JIFPJFGEAIK);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool MIAENKFDMLM(DGKLLKHIJBK ILDPPLPIIKF, NativeParallelHashMap<Guid, LocalId> OCKHNEOFDJB, [Out] Exception MPBIHBFIGPI);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BNAGJEPLPEB(DGKLLKHIJBK ILDPPLPIIKF, NativeParallelHashMap<Guid, LocalId> OCKHNEOFDJB, [Out] NativeArray<LocalId> MEJIKACDFLB, [Out] NativeArray<LocalId> GKBKGOHGDLF, [Out] NativeArray<AuthoredLocalPoseData> JLAGECLEKAB, Allocator EEDCBHBBPKF);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "19")]
	void FLIMPOHJDEG(DGKLLKHIJBK PGEPJKBFLOM, NativeArray<int> OBIBBENNFHJ, BEHKKOBPFOO<GameObject> COLGECGKFKN, KIOIAGMFEML<GameObject> LOGKJKKAHNK, GECNDDPDPGB AEOBLDDKEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HNIBLKDAJGH();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "21")]
	void BKDHPNBELHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "22")]
	void LONLEOKACNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "23")]
	bool OGIDFCMHGON(DGKLLKHIJBK ILDPPLPIIKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "24")]
	KOBFKCBIAIB DCHEMFDHNMF(DGKLLKHIJBK ILDPPLPIIKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "25")]
	void CDNCEEAKDOA(Guid NJBICIMMCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "26")]
	bool LJFABGHLKAD(Guid NJBICIMMCMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x86DE160", Offset = "0x86DC760", VA = "0x1886DE160")]
	static KBDJBAENJPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface CJCHAHOAJGP
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	long KAJHDPPAKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	long BJLLHPIAHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface CNKHDPAHPHO
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool OPHODICPLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool CFEEBCNFDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int LPEGIPJBBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	int DCBGDKBHDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int FGDJOPOONMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool NFEDPNGMOJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	int CNHBLGKNIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "6")]
	void CCNKKACJHNB(FODJOCBDILC BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
	void AJDIBFBAJNG(bool DPIACEKGPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "8")]
	bool GKFOMEAPAOI(NOCCEEEBCMN JPKKOPNBEKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "9")]
	void EFFLGCJPCMC(object JFAOAIPNPMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "10")]
	void GPEMLMDDLEC(object JFAOAIPNPMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IGPMPDMDJFM(Action<object> JJNGEMOAIBF);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LNIHFLKANLM(Action<object> JJNGEMOAIBF);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "13")]
	void HILKEHGAKIL(NativeArray<ViewId> CCLFGMHDLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "14")]
	void CHLBJPCNEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "15")]
	void GBPIPOJDBGP(AHDIOKNFJLF GPEIAHGICNA, ReadOnlySpan<byte> CDDIADBJAOB, NOCCEEEBCMN LNJCEAKILKK, bool INDLFJBEPPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "16")]
	void GBPIPOJDBGP(AHDIOKNFJLF GPEIAHGICNA, ReadOnlySpan<byte> COLCMFNEJLB, bool INDLFJBEPPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "17")]
	void GBPIPOJDBGP(AHDIOKNFJLF GPEIAHGICNA, ReadOnlySpan<byte> COLCMFNEJLB, ReadOnlySpan<byte> IJPKBBEKAFB, bool INDLFJBEPPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "18")]
	void HGABBKCFJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "19")]
	void EGHMJBKNHAI(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "20")]
	void HDEFEFNKEJL(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "21")]
	void PDMLDKMEMJG(Dictionary<object, object> PIBANJKLIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "22")]
	void KIFOIGEDGBF(NativeList<NEKBNCKOEOB> NALGOPGOMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "24")]
	void NCDGBODKMGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "25")]
	void BEIKDCLJKAD(List<object> OIDEONFEIGM, int NDMFOILAFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "26")]
	void CCAKJHLMEAK(int EAHHAHHANOL, object CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "27")]
	void PACPCFGNADO(NOCCEEEBCMN JPKKOPNBEKB, object EKHHBKLNJDE, bool FNNCBALLFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "28")]
	void LILDAAPKGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "29")]
	void LNIJJPGLLDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class NFIHHBPFKCJ
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x86E1A70", Offset = "0x86E0070", VA = "0x1886E1A70")]
	public static MODFCMCBIPM PDFPNCDMOAA(this CNKHDPAHPHO AJLGIFGJLEI, object INEEADCBMPK)
	{
		return default(MODFCMCBIPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct MODFCMCBIPM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private CNKHDPAHPHO AJLGIFGJLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object INEEADCBMPK;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x86E1070", Offset = "0x86DF670", VA = "0x1886E1070")]
	public MODFCMCBIPM(CNKHDPAHPHO AJLGIFGJLEI, object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x86E1020", Offset = "0x86DF620", VA = "0x1886E1020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PJJOOLFIIKH
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate void MCDJKHBMANL(ViewId JCBIELMJFID, MDLDCBLBAPK EOECDEICEMH, int OBAFOAGLIMM);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "0")]
	void EEEOMJDOMAD(MCDJKHBMANL IELIAKJFJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "1")]
	void LAPMHDFNCAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "2")]
	void LIGBOOLONEE(BIEMNAKNEJO DONNKKDINIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface BNEPHCCNPOL
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface GAFHMJCDDMG
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKHALIHPCMD();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[ServiceLifetime(Lifetime.Application)]
public interface DLIAJHFCPBA
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct NGIMIOCHOPI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private DLIAJHFCPBA EINJINGHJEO;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x86E1BA0", Offset = "0x86E01A0", VA = "0x1886E1BA0")]
		public NGIMIOCHOPI(DLIAJHFCPBA EINJINGHJEO, string PPIKFHNMOAN, string PABFNLFHJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x86E1B40", Offset = "0x86E0140", VA = "0x1886E1B40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct ENLNEHELNPG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private DLIAJHFCPBA EINJINGHJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task DIAHJIAKEPB;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x86D6320", Offset = "0x86D4920", VA = "0x1886D6320", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "0")]
	void BHGMNDKINFO(string GKNICJPCIJJ, float KFCMKNFBLHC = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "1")]
	void MHJGMHIEDKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONLIAAEFOED(bool FIEDFKLDBGB, string PPIKFHNMOAN, string PABFNLFHJFD);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "3")]
	void NKINHAGOJJJ(string GKNICJPCIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class IDLINAEPIBD
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x86DC9E0", Offset = "0x86DAFE0", VA = "0x1886DC9E0")]
	public static DLIAJHFCPBA.NGIMIOCHOPI DFMEFJICEGF(this DLIAJHFCPBA AJLGIFGJLEI, string PPIKFHNMOAN, string PABFNLFHJFD)
	{
		return default(DLIAJHFCPBA.NGIMIOCHOPI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface OAKHHKGDKLC
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HBOPMAHHIFP(GameObject JJEACKINPOJ);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FGEGCNINADE(GameObject JJEACKINPOJ);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IKNGJJNJDJM(int JPKKOPNBEKB);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object GGCLHGKPAPD(NLPLHJLLGBB BJCKBJFHLNJ, GameObject JJEACKINPOJ, Action<NLPLHJLLGBB, int> LAOAAOBGDLL);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AMDHFEELEIO(GameObject JJEACKINPOJ, object GELDFFKJIOF);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OLKKOANGHFM
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	PIBDBDJHBIB JANBADAJCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JLOKOABLKAN
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNFBGKJOCEL(MLPFDOKAHEM HDJBBJKIGDL, BGMLECFHONH LGNOKIBMMII);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KECDANNOKEA(NOCCEEEBCMN AGIMJJDFEAF, MNAALBCCOMC LBOKMAIKEPA);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
public interface AOGEMCJMGLL
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANHNANMIGBP(object MPIDDJPOOMJ, NativeList<byte> CDDIADBJAOB);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object LPNJIHLFELG(NativeArray<byte> CDDIADBJAOB);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
public interface MFIGNHBHJBF
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool PNHKMBJKKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate CFEAKJFJJDI(GDGJFLEDIKD FHKBCJFCINK, Action<GDGJFLEDIKD> LAOAAOBGDLL);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OFMGIPKJDCE(GDGJFLEDIKD FHKBCJFCINK, Delegate LAOAAOBGDLL);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate PKDJIKHPGHM(GDGJFLEDIKD FHKBCJFCINK, Action<GDGJFLEDIKD> FAOEPNGIACL);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CEDHIKMGBLO(GDGJFLEDIKD FHKBCJFCINK, Delegate LAOAAOBGDLL);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CJKCNKHINOB(GDGJFLEDIKD FHKBCJFCINK);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GDGJFLEDIKD JIOJBAMKLBG(GameObject JJEACKINPOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.Application)]
public interface JHAFBACJELG
{
	[Cpp2IlInjected.Token(Token = "0x17000080")]
	int NADPHFCDLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	int GDPPDLCMKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool OPHODICPLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool CMMPLHAKFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool OBBMGIKLKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NLPLHJLLGBB HFCCMHFOGIK(int JPKKOPNBEKB);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CGHJPCFFIKG(GameObject AKCGFKJMPEN, JobHandle LAPLOJOHMMO);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface PIBDBDJHBIB
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DIGGGDPILBE(MNAALBCCOMC JFDKPNDDGFG, BGMLECFHONH DBCCEKNNHCG);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface IPJCLFGKDLA
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool JKEKNGDCJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.Application)]
public interface JILHBDOFIBK
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	EKBBEBOGNCO OOIBOPKIHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	DIBJFLJJFNO MMINMIPPDLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool NACKMIMHGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NAGGENPBMAL(Transform CCHLCEHOKAD);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NNOCGOPKHLH(Transform CCHLCEHOKAD, PDPGAAFEJAL FBHCOILPPKJ);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OGHCJGDAKKC(Transform CCHLCEHOKAD, POFMKFJLMNC BNPFBJAOLKG);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[ServiceLifetime(Lifetime.Application)]
public interface GEGFAGGABJJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action EDPHLAABOIC;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[ServiceLifetime(Lifetime.Application)]
public interface EPOJANJNLBK
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBNJHFEMKME();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[ServiceLifetime(Lifetime.Application)]
public interface CEFJOIJPKLP
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLEHBACHPGA(GameObject JJEACKINPOJ, ECECGBCBHKB OBOBFKPOFLE, OAOIGNGOHBK EHHDOBKFMKA);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GPGOPHMBLNP(NLPLHJLLGBB BJCKBJFHLNJ, bool HBMGLJAMKLC, float3 MGEEPPIELBH, quaternion HGLKNNFFDIG);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NMNEDMKGFCF(PDHGKNBOAKO PBBPAFMGFJA);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LGJDMGCOMFE(CENLKEFEGPJ PCLFJGMAHBI, CENLKEFEGPJ AMMKGILEHBG, INIBMAJCADC LJNIMHNLCFF);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNBEMBGCOND(CENLKEFEGPJ PCLFJGMAHBI, INIBMAJCADC LJNIMHNLCFF);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BHCGIIDIIMJ(PDHGKNBOAKO EJKPNBACEMN);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ELDJILNIMFH(DGKLLKHIJBK BPOFPMJEFHM, ReadOnlySpan<Guid> AMDEGBBKBBO, ReadOnlySpan<int> OPDAKPMHFFL, KIOIAGMFEML<GameObject> CENHGNJEDNF);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BPCFAIBINKO(FOHKKODBCBA LLBCHEOKJKH);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CEOHEBOCIIK(GCKPEEHAMFC MNOPDCFHCNJ, GCKPEEHAMFC FHLLIJEMDCJ);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KMNOMFJMIJP(GCKPEEHAMFC MNOPDCFHCNJ, GCKPEEHAMFC FHLLIJEMDCJ);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KPLDEJJCDKN(NLPLHJLLGBB OFMDPGKCHOC);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct KIEIAMCFJOI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> CDDIADBJAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle MNHLJANEAIO;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x86DEAE0", Offset = "0x86DD0E0", VA = "0x1886DEAE0")]
	public KIEIAMCFJOI(ReadOnlyMemory<byte> CAOLIPOOLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x86DEAA0", Offset = "0x86DD0A0", VA = "0x1886DEAA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum ALMNCCPIGFE
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
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct DGKLLKHIJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString KDCMLHCGOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object HAAOGCCMALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object HNDOLCNGMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> LOIPAABBFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool GBOAJCAMJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public CKBLGCNIDEA.MOIAEBCAJFA? ELNEFPFLHAL;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x86D5CA0", Offset = "0x86D42A0", VA = "0x1886D5CA0")]
	public DGKLLKHIJBK(ByteString KDCMLHCGOEM, [Optional] object HAAOGCCMALJ, [Optional] object HNDOLCNGMGG, [Optional] IEnumerable<string> LOIPAABBFIF, bool GBOAJCAMJPB = true, [Optional] CKBLGCNIDEA.MOIAEBCAJFA? ELNEFPFLHAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct PKDJKJIMHEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object IOLCAFLKJGI;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct AOOOOBNIDMA
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[Flags]
	public enum DNGFCELGCEA
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
	public RRObjectPrefabData ILGCEEGMJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid EIEGDICNOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid HAALKNJOFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid FIAOAFNJINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid HJBEPLOFDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public DNGFCELGCEA ANBGOGICGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 DMOKLEFHBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int GOCGBFBGDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public BIONAAGHEEM FHKEBILAKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int CBGJKKGPPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int GHJCNICLMKL;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Guid KLBECCFADEG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x57B0460", Offset = "0x57AEA60", VA = "0x1857B0460")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool MOCEHIJABNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x86D0B60", Offset = "0x86CF160", VA = "0x1886D0B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool BMNFHONNKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x86D0B80", Offset = "0x86CF180", VA = "0x1886D0B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool FHFDIGMOPIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x86D0B70", Offset = "0x86CF170", VA = "0x1886D0B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool INILCDCKKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x86D0B90", Offset = "0x86CF190", VA = "0x1886D0B90")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct HOEAIPHGBDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly DMAABKNJGLG GHOFJOJMCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly DMAABKNJGLG PAHJFGCGJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal readonly uint NGPNFAGMDCJ;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x86DB9B0", Offset = "0x86D9FB0", VA = "0x1886DB9B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct GNGJPPHOEMI
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal readonly HOEAIPHGBDO PMBBLAOPHON;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x86D9100", Offset = "0x86D7700", VA = "0x1886D9100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct NDKGFCKILIB
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly HOEAIPHGBDO PMBBLAOPHON;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x86D9100", Offset = "0x86D7700", VA = "0x1886D9100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct BCBLOOGGELF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly uint NGPNFAGMDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly bool HBHHHEMOKHN;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x86D1790", Offset = "0x86CFD90", VA = "0x1886D1790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct DMAABKNJGLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal int PIOCNHLFCNE;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x86D5D20", Offset = "0x86D4320", VA = "0x1886D5D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[ServiceLifetime(Lifetime.Application)]
public interface NIMPGPKBJEL
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	OAMDGJJGKHH PDLNLBKNECD
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface KLHPGMPFKMA
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface KCMKDLKMCAA
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class BNACLCDBPIH
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3B73030", Offset = "0x3B71630", VA = "0x183B73030")]
	public static CENLKEFEGPJ IBCFIACEEMO<T>(this T BJCKBJFHLNJ) where T : KLHPGMPFKMA
	{
		return default(CENLKEFEGPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x86D33A0", Offset = "0x86D19A0", VA = "0x1886D33A0")]
	public static MonoBehaviour EKLCJBMFNBP(this KLHPGMPFKMA BJCKBJFHLNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x86D3420", Offset = "0x86D1A20", VA = "0x1886D3420")]
	public static GameObject HPNHKENLPOK(this KLHPGMPFKMA BJCKBJFHLNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface LDJGJNJJBBG : KLHPGMPFKMA
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(NLPLHJLLGBB OIHEEOJKKOF);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface HFGEGKAJHPC : KLHPGMPFKMA
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface NCHPCAADJAG
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public delegate void HABFMOGJOAB(FHOIONDOKFH AFHFPABCBMI);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event HABFMOGJOAB MBEKIEIGEAE;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface JIDBHEIIMIH
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface JCAJMJFHOJJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface ONKGALPKPBA
{
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(NLPLHJLLGBB JKAPMNJOKDI);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool PMFPKHFNPHG);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PLHONCDPNHF(NLPLHJLLGBB IIIJIBCGHEO);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface DMDJMDLDNAP
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(OCHLPLCDEOP COBLONGGKAI);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface OCHLPLCDEOP
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	GameObject JJEACKINPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	Transform CCHLCEHOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	AFLINHCECMA JGKMLFPIJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	bool GANEOLNJPBI
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IFOHDDLAKEB(AFLINHCECMA MFNKIFOCMAO);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BMAKNOKMAHD GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class IEADGONNLML
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x86DCA70", Offset = "0x86DB070", VA = "0x1886DCA70")]
	public static void MONLHIJHNGJ(this OCHLPLCDEOP JDPJJGMMDGH, AIJJICHNHLM JIFPJFGEAIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface AFLINHCECMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Rigidbody MNPLGLEODBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	OCHLPLCDEOP MCFNJCKFPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	GameObject HPNHKENLPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	Transform JJKHGJPALLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	AFLINHCECMA IFNCNLOFOPF
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	AFLINHCECMA HMJJONKLDKG
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	int LABGDFIOJOP
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	bool JGJIPHIDAPM
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool CJKCNKHINOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	bool HMDJDGHDCBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	LDOJJNLFMJG IDJEEBDMJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	KNMODGMCAEJ PHHGNNEFNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	float MEHMIOIICDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 KMMLNNKOKKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 MJABHHPDODG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Vector3 JCHIBDNJAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Vector3 LFKDPNAGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	bool OAJMEEFOCJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool PHHANJFHBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	bool GCMINIMGNIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool GOFMMIKMJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	Vector3 HEAGGCAOIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Vector3 HPAFKOFENJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	Vector3 BFICBHNPEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Vector3 LMILABLNBNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	float HABFFBAPBJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	float PINPEFDKIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Vector3 DHPHCJHJBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	Quaternion ACMFNIJMGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	float JGDNBFMPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	float GFDHAKAPLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool HCJDFMGBPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	FLIFMIOEKDE IDNCNDEILKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool IKOEBPFPHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	Transform IMKDKMLBCJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	Vector3 GLHHDIBFIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	float PCAINAIAGBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	float BMBFLPIKNHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Quaternion CEJBPPBLEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Vector3 KNGNNNLEBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	Quaternion OGKNMPEPEHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	RigidbodyConstraints LDAPKPBEMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	bool DCJNAJFFGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	CollisionDetectionMode JCMCAJOOFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	bool NIMGFGNGKHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GJMCCLEBNCH PNNGFLPGHEM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event GJMCCLEBNCH FEHEPNOPKBH;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event GJMCCLEBNCH FFFKAKAOPAE;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event GJMCCLEBNCH PMDGDLGHLKK;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event GJMCCLEBNCH OOFEDCIOEJP;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event GJMCCLEBNCH HHHEHFDFCBO;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event GJMCCLEBNCH GOBHAOBFLON;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event ICCJKBLNFCN KOFKLAGLDEL;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<AHNGGBKKFOE, AHNGGBKKFOE> JDMNGFPHFAH;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	AFLINHCECMA LFBIIEDDKCD(int PMIGBJGNLLP);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void OIECIPFBALB((Quaternion rot, Vector3 moments) FGMFIOKLJLO);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void GIEDMCCENPN();

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void AAOGDOMHBGP();

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void KGIFKDJGHBJ();

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void DCHKGAFMEPN();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void IPODJONCDKD();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void NMLEEMHPCCP(AFLINHCECMA KOPHBHGIACG, bool NNOFAGIMANK = false);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void LGJJPMHGHPB(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void HHPDEAMMEOL(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 KHBKHPNFBEC(Vector3 INOKLOLKDMF);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 DMDGMFGGIAE(Vector3 BDPHNFIHANA);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void CJOABAEICMK();

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void COGKDECNKAF();

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void LEOEAJLLKJJ();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void HHGODEJMCCE(Vector3 JDNMLAKNLHJ, Vector3 OPOBMLOHGFE);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void AINIGLNJFBJ(Vector3 KKAOBCBGFIM, Vector3 DDMPBEFKBLL);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void AKCHLEGEPLL(Vector3 AADGBMGBAIC);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void FDLKOHMMCIM(JKCJIHCAFND CJJGBDBIKNK, Vector3 JGCOGMBGAIE, float JCMCABMDPDI, float JNJGMIJAPBG = 8f, float FGEMNCHJAOE = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void MPLEJJCMNFI(AGKPFFONCGI BOIEPIHDFOA, Vector3 DEFJCKCMJLK, float LPGBJACEOGH = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void DKOOOOCKALH(AGKPFFONCGI BOIEPIHDFOA, Vector3 LDAEEKEKDJC, float FGNDKKHAFBJ = 7f, float JDPKNMPDEGH = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 OHDPDACBGEN(Vector3 KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 BIGOJHBNDIA(Vector3 KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void GAOBPBHIPGN();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void GOCAMMAIKFO(AFLINHCECMA AGCHBDHDAAA, object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void DHIDEPCMGHN(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void JDNBIEICPCF();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void COHAPIBFEDH();

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void OEELEHNGNFM();

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool IODAFJKJAHN();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void MEDHHOOPBPI();

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void HMBCKCPHKFB(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void KJOEMODIGHA(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void MPFLAILIPIP(object INEEADCBMPK, bool KLPLCNHJGCO);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void CNICEBFNLID(Vector3 BAEGEJDEFCC, Quaternion DEPHFBPLKDJ);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void JIENMCCNBGF(Vector3 BMEDECNGGHD, Quaternion BDEAMIJGHLI);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool AGDEGLOOOAA(float PFDEEHBMFHF);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void NMBILEBPAHH(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void LEEFGEKGAFI(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void DFONOONJCJH(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void HCNECMLDKIA(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void OKCPPCHDIAC(Vector3 AKKFOJDOENB, ForceMode HBOKLBGANOG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void KCACIKMAHBF(Vector3 AKKFOJDOENB, Vector3 APHHGJIDDCM, ForceMode HBOKLBGANOG);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void HLJENLHDNIF(Vector3 LFDFEGCBLBM, ForceMode HBOKLBGANOG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void LDOPEKBCKFP(Vector3 LFDFEGCBLBM, ForceMode HBOKLBGANOG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool LKLOFHEOALP(Vector3 JPDMHOCEDGB, [Out] RaycastHit ACFNAAGLOLN, float AHKHODDOFPB);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void CIPNHALDNGO();
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface KNMODGMCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class JMOMBFFIOEC : KNMODGMCAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JMOMBFFIOEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "0")]
	void GEDLMCNBCHO(Vector3 BDMADEAKFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "1")]
	void MBEPDPFNHOB(Vector3 PCNHEAPIMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "2")]
	void PLLEOHPAIHH(Vector3 BDMADEAKFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "3")]
	void INIPHFBEKNL(Vector3 PCNHEAPIMMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface LDOJJNLFMJG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 HGAOGEFMHAK();

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 IOMIGILDBJN();

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OPKOIOHCOIH(float JEHLLHNJMME, float OEBLFGNLCLI);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public delegate void GJMCCLEBNCH(OCHLPLCDEOP MDNADLBDFPF);
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum BIBKPDEJCPG
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
[Cpp2IlInjected.Token(Token = "0x200005E")]
public enum JKCJIHCAFND
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
[Cpp2IlInjected.Token(Token = "0x200005F")]
public delegate void ICCJKBLNFCN(OCHLPLCDEOP MDNADLBDFPF, bool NNOFAGIMANK = false);
[Cpp2IlInjected.Token(Token = "0x2000060")]
public enum AGKPFFONCGI
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct BMAKNOKMAHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Rigidbody MLPKEKPNOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public object DOJBOEGBBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 HGPMPPHFMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Vector3 CADNMDCAAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public FMEBMDLLDAA ECFMGNDDOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool CLHNDFMENDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool CNCBBKNOFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool COLJDCPMOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool FDNBGJHBOHD;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct CENLKEFEGPJ : IEquatable<CENLKEFEGPJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly CENLKEFEGPJ JFGDHENPDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public GameObject JJEACKINPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x86D4580", Offset = "0x86D2B80", VA = "0x1886D4580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public NEKBNCKOEOB MDNGHJINCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x86D41B0", Offset = "0x86D27B0", VA = "0x1886D41B0")]
		get
		{
			return default(NEKBNCKOEOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public NBABKBBLJJL FEJHNHAKLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x86D3FF0", Offset = "0x86D25F0", VA = "0x1886D3FF0")]
		get
		{
			return default(NBABKBBLJJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public RRObjectPrefabData EJBEOMPPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x86D3A90", Offset = "0x86D2090", VA = "0x1886D3A90")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool JIFDFFBJAJH
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x86D3E40", Offset = "0x86D2440", VA = "0x1886D3E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool FEONFHPHKCH
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x86D44C0", Offset = "0x86D2AC0", VA = "0x1886D44C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool GJFKHDEBHLM
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x86D4530", Offset = "0x86D2B30", VA = "0x1886D4530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool BFDLDAECGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x86D3C80", Offset = "0x86D2280", VA = "0x1886D3C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool HLODCIMLOOH
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x86D44A0", Offset = "0x86D2AA0", VA = "0x1886D44A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool NNDLIIBGMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x86D4710", Offset = "0x86D2D10", VA = "0x1886D4710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool PGKGCGILFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x86D3CE0", Offset = "0x86D22E0", VA = "0x1886D3CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool IDDALDOADGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x86D3D20", Offset = "0x86D2320", VA = "0x1886D3D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool EOAOOKKHHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x86D47C0", Offset = "0x86D2DC0", VA = "0x1886D47C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool NENCEKHKIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x86D3FB0", Offset = "0x86D25B0", VA = "0x1886D3FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool MPJMALIHLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x86D4290", Offset = "0x86D2890", VA = "0x1886D4290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool HKMJBCEAALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x86D4090", Offset = "0x86D2690", VA = "0x1886D4090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool GDDDDBOGCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x86D38B0", Offset = "0x86D1EB0", VA = "0x1886D38B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool DIDPNIAPIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x86D3CA0", Offset = "0x86D22A0", VA = "0x1886D3CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool NLEKNJELKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x86D4800", Offset = "0x86D2E00", VA = "0x1886D4800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool AKPNIFACNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x86D3C40", Offset = "0x86D2240", VA = "0x1886D3C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool JLIJJODCCJB
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x86D4780", Offset = "0x86D2D80", VA = "0x1886D4780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public LAGFGFOACOD HAOFENCIKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(LAGFGFOACOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public FCEEBPCBLEC JFEBLGDCBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(FCEEBPCBLEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public GLCCGCCCJBH KOLFHMIFFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(GLCCGCCCJBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public DFJFIKHAJPC MMAEIMFJHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(DFJFIKHAJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public BHAEBHCFCBF FFFHDEICLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(BHAEBHCFCBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public PLGDCNOAHBJ CKCHCEAOCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(PLGDCNOAHBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public BGOKDKKJKFF LFGGJBPNDGB
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(BGOKDKKJKFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public MMKGLGGACOL BHAGAEMPKDL
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(MMKGLGGACOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public JEACOCCNADF EENDDBCJDIA
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(JEACOCCNADF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public HMJCDPEIIHB NIOGLIMGMHE
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(HMJCDPEIIHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public HENHGNPDHCM PJPMOANBJAP
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(HENHGNPDHCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public ANEFALGKKIK ACHHNNNFNJE
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(ANEFALGKKIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public KDAPKAHIMHA OGIJDDPEMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(KDAPKAHIMHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public JBPBJPOJMIP KOOGKHHNMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(JBPBJPOJMIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public JINEJFANKMN ALIMIOBDIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(JINEJFANKMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public bool LMANHHGDGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x86D42D0", Offset = "0x86D28D0", VA = "0x1886D42D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool CAJIKNEFPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x86D4460", Offset = "0x86D2A60", VA = "0x1886D4460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool NKOOMKELNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x86D4170", Offset = "0x86D2770", VA = "0x1886D4170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool CCCINLIBFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x86D3930", Offset = "0x86D1F30", VA = "0x1886D3930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool DPLPPNCNPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x86D4250", Offset = "0x86D2850", VA = "0x1886D4250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public bool LAHPFJIBIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x86D38F0", Offset = "0x86D1EF0", VA = "0x1886D38F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public bool KALCAGAFHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x86D4740", Offset = "0x86D2D40", VA = "0x1886D4740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public PAHODFNJBJK JJKHGJPALLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(PAHODFNJBJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public PEFJICAJNGM NHMEMMHBOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(PEFJICAJNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private HNBHNOBANOG EIBKLMACMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x86D3E60", Offset = "0x86D2460", VA = "0x1886D3E60")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	public static CENLKEFEGPJ HNGLNPFKABH(NLPLHJLLGBB OIHEEOJKKOF)
	{
		return default(CENLKEFEGPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x86D3BC0", Offset = "0x86D21C0", VA = "0x1886D3BC0")]
	public LNGFAPGMGKL DJAIPEGJHLK()
	{
		return default(LNGFAPGMGKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x86D4550", Offset = "0x86D2B50", VA = "0x1886D4550")]
	public GJKIJDNOFHL NJONNNFLMDO()
	{
		return default(GJKIJDNOFHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x86D4120", Offset = "0x86D2720", VA = "0x1886D4120")]
	public HGCNIPJCLII JFNLNIMOOJD()
	{
		return default(HGCNIPJCLII);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x86D4840", Offset = "0x86D2E40", VA = "0x1886D4840")]
	public BHMPPBLAFLK PPAJFGKNEOD()
	{
		return default(BHMPPBLAFLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x86D3D60", Offset = "0x86D2360", VA = "0x1886D3D60")]
	public HPGOHHJOIPE EPOGHJMKCKP()
	{
		return default(HPGOHHJOIPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x86D3F60", Offset = "0x86D2560", VA = "0x1886D3F60")]
	public MDPDPJFNMFP GFIPOBMEJKE()
	{
		return default(MDPDPJFNMFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x86D44E0", Offset = "0x86D2AE0", VA = "0x1886D44E0")]
	public GCKPEEHAMFC MNJJCPFGKLH()
	{
		return default(GCKPEEHAMFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x86D40D0", Offset = "0x86D26D0", VA = "0x1886D40D0")]
	public BCDNHMPAMPK IGNPJGLFPEM()
	{
		return default(BCDNHMPAMPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x86D3A40", Offset = "0x86D2040", VA = "0x1886D3A40")]
	public OOECFBCJOAH COGEJLKJFNH()
	{
		return default(OOECFBCJOAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x86D3940", Offset = "0x86D1F40", VA = "0x1886D3940")]
	public void CGADCFNHDKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x86D3EC0", Offset = "0x86D24C0", VA = "0x1886D3EC0")]
	public void GELLEPHLJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x86D43C0", Offset = "0x86D29C0", VA = "0x1886D43C0")]
	public void LIOBMJIDNHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x86D3810", Offset = "0x86D1E10", VA = "0x1886D3810")]
	public bool ADJGNLAGEPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x86D4870", Offset = "0x86D2E70", VA = "0x1886D4870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public CENLKEFEGPJ(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x86D3380", Offset = "0x86D1980", VA = "0x1886D3380")]
	public static bool HNGLNPFKABH(CENLKEFEGPJ KOPHBHGIACG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	public static NLPLHJLLGBB HNGLNPFKABH(CENLKEFEGPJ KOPHBHGIACG)
	{
		return default(NLPLHJLLGBB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x86D1F30", Offset = "0x86D0530", VA = "0x1886D1F30")]
	public static bool MGLHCKHANFO(CENLKEFEGPJ JGPEJMANNEB, CENLKEFEGPJ PDHHCOODKIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x86D1C90", Offset = "0x86D0290", VA = "0x1886D1C90")]
	public static bool HKOGMNAKMAE(CENLKEFEGPJ JGPEJMANNEB, CENLKEFEGPJ PDHHCOODKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x86D3DB0", Offset = "0x86D23B0", VA = "0x1886D3DB0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(CENLKEFEGPJ AAGCKLPFJME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct KDAPKAHIMHA : IEquatable<KDAPKAHIMHA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private OIEDFIPBJNH IGLFPBFOODD
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x86DE280", Offset = "0x86DC880", VA = "0x1886DE280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x86DE7F0", Offset = "0x86DCDF0", VA = "0x1886DE7F0")]
	public void JKGINMFFHCO(uint NMILEMOAODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x86DE9A0", Offset = "0x86DCFA0", VA = "0x1886DE9A0")]
	public bool NCBHNCMHFGJ([Out] uint NMILEMOAODL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x86DE3F0", Offset = "0x86DC9F0", VA = "0x1886DE3F0")]
	public bool EOGIOMFEKKD([Out] uint NMILEMOAODL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x86DE700", Offset = "0x86DCD00", VA = "0x1886DE700")]
	public void JBAJPJJLBGP(string NMILEMOAODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x86DE2E0", Offset = "0x86DC8E0", VA = "0x1886DE2E0")]
	[CanBeNull]
	public string DELLCBCODKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x86DE580", Offset = "0x86DCB80", VA = "0x1886DE580")]
	public bool FKDIADNHNDL([Out] string NIHHLFKJLCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x86DE900", Offset = "0x86DCF00", VA = "0x1886DE900")]
	public void LNPBDCMCBHJ(string NIHHLFKJLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public KDAPKAHIMHA(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x86DE4F0", Offset = "0x86DCAF0", VA = "0x1886DE4F0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(KDAPKAHIMHA AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct LAGFGFOACOD : IEquatable<LAGFGFOACOD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private JNPPPJEJEON BBLKGJCDGFO
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x86DF660", Offset = "0x86DDC60", VA = "0x1886DF660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	private OIEDFIPBJNH BFGAHJMFJML
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x86DF740", Offset = "0x86DDD40", VA = "0x1886DF740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public bool JFICHHNPGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x86DED30", Offset = "0x86DD330", VA = "0x1886DED30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public bool BDIPOFFKFAN
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x86DF580", Offset = "0x86DDB80", VA = "0x1886DF580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool CDPNIPAKLEE
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x86DF280", Offset = "0x86DD880", VA = "0x1886DF280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Guid KIPIKAIMLKA
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x86DF6C0", Offset = "0x86DDCC0", VA = "0x1886DF6C0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public Guid DHAAINMPAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x86DF500", Offset = "0x86DDB00", VA = "0x1886DF500")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public Guid NOGHPJAJDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x86DEFE0", Offset = "0x86DD5E0", VA = "0x1886DEFE0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public PEFJICAJNGM NHMEMMHBOAI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(PEFJICAJNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x86DF460", Offset = "0x86DDA60", VA = "0x1886DF460")]
	public bool JEPFNGEEDNK([Out] Guid HCMLLANKMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x86DF5C0", Offset = "0x86DDBC0", VA = "0x1886DF5C0")]
	public bool MFJCMOGOPMJ([Out] Guid PLBMJMHLGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x86DEDC0", Offset = "0x86DD3C0", VA = "0x1886DEDC0")]
	public void BIENGALPGFL(Guid IKJAADLGNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x86DEEE0", Offset = "0x86DD4E0", VA = "0x1886DEEE0")]
	public void EILKDJKLJLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x86DF340", Offset = "0x86DD940", VA = "0x1886DF340")]
	public Guid HEBFJPBLGEM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public LAGFGFOACOD(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x86DF1F0", Offset = "0x86DD7F0", VA = "0x1886DF1F0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(LAGFGFOACOD AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct HGCNIPJCLII : IEquatable<HGCNIPJCLII>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	private AFGPKHPOMIB OJFHKDBPCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x86DAB60", Offset = "0x86D9160", VA = "0x1886DAB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Vector3 NHEKBCEJBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x86DA410", Offset = "0x86D8A10", VA = "0x1886DA410")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public Quaternion LBEPBOAHBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x86DAA10", Offset = "0x86D9010", VA = "0x1886DAA10")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public CENLKEFEGPJ FKLEBJFAFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x86DAD30", Offset = "0x86D9330", VA = "0x1886DAD30")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x86DAC60", Offset = "0x86D9260", VA = "0x1886DAC60")]
	public PDHGKNBOAKO MEDKJPKNNHP(Allocator EEDCBHBBPKF)
	{
		return default(PDHGKNBOAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x86DABC0", Offset = "0x86D91C0", VA = "0x1886DABC0")]
	public bool IPPBLNEKNPP(CENLKEFEGPJ BEBONNCPGLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x86DA830", Offset = "0x86D8E30", VA = "0x1886DA830")]
	public void ELGPACJCOGM(Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x86DA720", Offset = "0x86D8D20", VA = "0x1886DA720")]
	public void DKMEJBAHOOB(float EAHAEIJNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x86DA560", Offset = "0x86D8B60", VA = "0x1886DA560")]
	public void DEANOJDOLFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public HGCNIPJCLII(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x86D3380", Offset = "0x86D1980", VA = "0x1886D3380")]
	public static bool HNGLNPFKABH(HGCNIPJCLII KOPHBHGIACG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	public static NLPLHJLLGBB HNGLNPFKABH(HGCNIPJCLII KOPHBHGIACG)
	{
		return default(NLPLHJLLGBB);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x86DA980", Offset = "0x86D8F80", VA = "0x1886DA980", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(HGCNIPJCLII AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct LNGFAPGMGKL : IEquatable<LNGFAPGMGKL>
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly LNGFAPGMGKL JFGDHENPDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private OJHGNPOOCLL ICECIEHMPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x86E0960", Offset = "0x86DEF60", VA = "0x1886E0960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<CENLKEFEGPJ> OOBEGDFAKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x86E0340", Offset = "0x86DE940", VA = "0x1886E0340")]
		get
		{
			return default(Span<CENLKEFEGPJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public string EEABAFMMHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x86E08E0", Offset = "0x86DEEE0", VA = "0x1886E08E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x86E0230", Offset = "0x86DE830", VA = "0x1886E0230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public PAHODFNJBJK JJKHGJPALLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(PAHODFNJBJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public PEFJICAJNGM NHMEMMHBOAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(PEFJICAJNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x86E0440", Offset = "0x86DEA40", VA = "0x1886E0440")]
	public void HIHELJEMOAL(LNGFAPGMGKL AAGCKLPFJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public LNGFAPGMGKL(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x86D3380", Offset = "0x86D1980", VA = "0x1886D3380")]
	public static bool HNGLNPFKABH(LNGFAPGMGKL KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x86E02B0", Offset = "0x86DE8B0", VA = "0x1886E02B0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(LNGFAPGMGKL AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	public static CENLKEFEGPJ HNGLNPFKABH(LNGFAPGMGKL JNMMMBJNOND)
	{
		return default(CENLKEFEGPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public struct CIGJPCGGKGI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Dictionary<int, object> PLDHKFPNKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private KOCJDBILEDO JMMKCOBOAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool MJCFBEAEKHN;

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		[CompilerGenerated]
		readonly get
		{
			return default(CENLKEFEGPJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public HOMAFMNGHDA LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x86D4BC0", Offset = "0x86D31C0", VA = "0x1886D4BC0")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x86D4CF0", Offset = "0x86D32F0", VA = "0x1886D4CF0")]
	internal CIGJPCGGKGI(CENLKEFEGPJ MPIDDJPOOMJ, bool MJCFBEAEKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x86D4A90", Offset = "0x86D3090", VA = "0x1886D4A90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x3BDE460", Offset = "0x3BDCA60", VA = "0x183BDE460")]
	public void KJBLMICKPHN<T>(HOMAFMNGHDA HAELBKGFDIJ, T KOPHBHGIACG, [Optional] T APJDJFMLEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x86D49E0", Offset = "0x86D2FE0", VA = "0x1886D49E0")]
	public void CBELOMAGFLH(HOMAFMNGHDA HAELBKGFDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0xB562D0", Offset = "0xB548D0", VA = "0x180B562D0")]
	public Dictionary<int, object> MMIEEIMPPDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x86D4C80", Offset = "0x86D3280", VA = "0x1886D4C80")]
	private readonly void GENEPJBPPKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class JKBGPMOLIBG
{
	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x86DDF00", Offset = "0x86DC500", VA = "0x1886DDF00")]
	public static CIGJPCGGKGI FPKBAGJOFGF(this CENLKEFEGPJ MPIDDJPOOMJ)
	{
		return default(CIGJPCGGKGI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct JBPBJPOJMIP : IEquatable<JBPBJPOJMIP>
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly JBPBJPOJMIP JFGDHENPDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private bool MPJMALIHLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x86DD4A0", Offset = "0x86DBAA0", VA = "0x1886DD4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 KPGJCMHMCHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x86DD1B0", Offset = "0x86DB7B0", VA = "0x1886DD1B0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x86DD150", Offset = "0x86DB750", VA = "0x1886DD150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x86DD0D0", Offset = "0x86DB6D0", VA = "0x1886DD0D0")]
	public Vector3 AKBFNHEIJKJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x86DD420", Offset = "0x86DBA20", VA = "0x1886DD420")]
	public void HKBLKHBAJLH([In] Vector3 KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x86DD260", Offset = "0x86DB860", VA = "0x1886DD260")]
	public void CFKLGIAKJIH([In] Vector3 KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x86DD370", Offset = "0x86DB970", VA = "0x1886DD370")]
	public bool GNALCPCIGKD([In] Vector3 KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public JBPBJPOJMIP(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x86DD2E0", Offset = "0x86DB8E0", VA = "0x1886DD2E0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(JBPBJPOJMIP AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x86DD4E0", Offset = "0x86DBAE0", VA = "0x1886DD4E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct GGLJBJGMNFG : IEquatable<GGLJBJGMNFG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x86D7810", Offset = "0x86D5E10", VA = "0x1886D7810", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(GGLJBJGMNFG AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct BCDNHMPAMPK : IEquatable<BCDNHMPAMPK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private LJFAHJAJKGF DAOJLPEMJJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x86D20F0", Offset = "0x86D06F0", VA = "0x1886D20F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool CKBOCADPPJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x86D1830", Offset = "0x86CFE30", VA = "0x1886D1830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool BFCMPBLKJGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x86D1960", Offset = "0x86CFF60", VA = "0x1886D1960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public GHDKOKGPEBF JLEOEMDDBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x86D1DF0", Offset = "0x86D03F0", VA = "0x1886D1DF0")]
		get
		{
			return default(GHDKOKGPEBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool CPJHKAMDDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x86D1C50", Offset = "0x86D0250", VA = "0x1886D1C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public bool GHNIFJGIJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x86D2060", Offset = "0x86D0660", VA = "0x1886D2060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public bool BCEIGKINKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x86D1B20", Offset = "0x86D0120", VA = "0x1886D1B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x86D1D50", Offset = "0x86D0350", VA = "0x1886D1D50")]
	public bool LFBCFCLGANN(BCDNHMPAMPK FALIJMAFJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x86D1BB0", Offset = "0x86D01B0", VA = "0x1886D1BB0")]
	public bool GCBPBMFKOHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x86D1CB0", Offset = "0x86D02B0", VA = "0x1886D1CB0")]
	public bool INBOKJHJMLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x86D1F40", Offset = "0x86D0540", VA = "0x1886D1F40")]
	public ReadOnlySpan<NLPLHJLLGBB> MIPHNDPBOPL()
	{
		return default(ReadOnlySpan<NLPLHJLLGBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public BCDNHMPAMPK(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x86D1F30", Offset = "0x86D0530", VA = "0x1886D1F30")]
	public static bool MGLHCKHANFO(BCDNHMPAMPK JGPEJMANNEB, BCDNHMPAMPK PDHHCOODKIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x86D1C90", Offset = "0x86D0290", VA = "0x1886D1C90")]
	public static bool HKOGMNAKMAE(BCDNHMPAMPK JGPEJMANNEB, BCDNHMPAMPK PDHHCOODKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x86D1A90", Offset = "0x86D0090", VA = "0x1886D1A90", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(BCDNHMPAMPK AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct GCKPEEHAMFC : IEquatable<GCKPEEHAMFC>
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly GCKPEEHAMFC JFGDHENPDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private LJFAHJAJKGF CLCNLOKJNCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x86D7740", Offset = "0x86D5D40", VA = "0x1886D7740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool DGOEJPHIAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x86D7640", Offset = "0x86D5C40", VA = "0x1886D7640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public PAHODFNJBJK JJKHGJPALLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(PAHODFNJBJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x86D76A0", Offset = "0x86D5CA0", VA = "0x1886D76A0")]
	public bool LFBCFCLGANN(GCKPEEHAMFC AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x86D74C0", Offset = "0x86D5AC0", VA = "0x1886D74C0")]
	public bool FEAMCECPOFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x86D7560", Offset = "0x86D5B60", VA = "0x1886D7560")]
	public bool IGJGPKJEEOO([Out] GCKPEEHAMFC JPHPEILFHOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x86D77A0", Offset = "0x86D5DA0", VA = "0x1886D77A0")]
	public void MDMJAFALHBO(BOPBKGGEOBN NLFMOKELAPM, bool KKIIDOGNCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public GCKPEEHAMFC(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x86D1F30", Offset = "0x86D0530", VA = "0x1886D1F30")]
	public static bool MGLHCKHANFO(GCKPEEHAMFC JGPEJMANNEB, GCKPEEHAMFC PDHHCOODKIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x86D1C90", Offset = "0x86D0290", VA = "0x1886D1C90")]
	public static bool HKOGMNAKMAE(GCKPEEHAMFC JGPEJMANNEB, GCKPEEHAMFC PDHHCOODKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x86D7430", Offset = "0x86D5A30", VA = "0x1886D7430", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(GCKPEEHAMFC AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct PEFJICAJNGM : IEquatable<PEFJICAJNGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	private OJHGNPOOCLL ICECIEHMPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x86E8A30", Offset = "0x86E7030", VA = "0x1886E8A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public NLPLHJLLGBB AEKGOOHIHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x86E8A90", Offset = "0x86E7090", VA = "0x1886E8A90")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public CENLKEFEGPJ IFNCNLOFOPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x86E8DF0", Offset = "0x86E73F0", VA = "0x1886E8DF0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CENLKEFEGPJ HMJJONKLDKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x86E88A0", Offset = "0x86E6EA0", VA = "0x1886E88A0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x86E8E80", Offset = "0x86E7480", VA = "0x1886E8E80")]
	public Span<CENLKEFEGPJ> OLPFCLAGNDA()
	{
		return default(Span<CENLKEFEGPJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x86E8930", Offset = "0x86E6F30", VA = "0x1886E8930")]
	public Span<CENLKEFEGPJ> IKDFGJPHNFJ()
	{
		return default(Span<CENLKEFEGPJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x86E9090", Offset = "0x86E7690", VA = "0x1886E9090")]
	public Span<CENLKEFEGPJ> PGEBDEBNAGM()
	{
		return default(Span<CENLKEFEGPJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x86E8B20", Offset = "0x86E7120", VA = "0x1886E8B20")]
	public Span<CENLKEFEGPJ> MOCIOACPCKF()
	{
		return default(Span<CENLKEFEGPJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x86E8CC0", Offset = "0x86E72C0", VA = "0x1886E8CC0")]
	public bool NMLEEMHPCCP(CENLKEFEGPJ BEBONNCPGLF, bool KONCKGMOKCH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x86E8C20", Offset = "0x86E7220", VA = "0x1886E8C20")]
	public bool NGIKDLJOEEL(CENLKEFEGPJ DOEFIPICAFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x86E8F80", Offset = "0x86E7580", VA = "0x1886E8F80")]
	public CENLKEFEGPJ PCFHMGJBDNC(uint EOPJMLCILKE)
	{
		return default(CENLKEFEGPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x86E9190", Offset = "0x86E7790", VA = "0x1886E9190")]
	public LNGFAPGMGKL PJDLPLKFGFP()
	{
		return default(LNGFAPGMGKL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public PEFJICAJNGM(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x86D3380", Offset = "0x86D1980", VA = "0x1886D3380")]
	public static bool HNGLNPFKABH(PEFJICAJNGM KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x86E8810", Offset = "0x86E6E10", VA = "0x1886E8810", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(PEFJICAJNGM AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct FCEEBPCBLEC : IEquatable<FCEEBPCBLEC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string AIHDEPPKDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x86D6760", Offset = "0x86D4D60", VA = "0x1886D6760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public string DGPAIHDAJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x86D66F0", Offset = "0x86D4CF0", VA = "0x1886D66F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public string GIKEGDHEINM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x86D6640", Offset = "0x86D4C40", VA = "0x1886D6640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public string AIODKJMLPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x86D67F0", Offset = "0x86D4DF0", VA = "0x1886D67F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x86D6580", Offset = "0x86D4B80", VA = "0x1886D6580")]
	public bool FKDIADNHNDL([Out] string NIHHLFKJLCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public FCEEBPCBLEC(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x86D64F0", Offset = "0x86D4AF0", VA = "0x1886D64F0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(FCEEBPCBLEC AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct COOCNJPEODA : IEquatable<COOCNJPEODA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x86D5A30", Offset = "0x86D4030", VA = "0x1886D5A30", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(COOCNJPEODA AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct OKAKHHMDEBM : IEquatable<OKAKHHMDEBM>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[Flags]
	public enum KIFGLPPBPAP
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
	private static IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly OKAKHHMDEBM JFGDHENPDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private HNBHNOBANOG EIBKLMACMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x86D3E60", Offset = "0x86D2460", VA = "0x1886D3E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	private EntityManager ACKHPMIHGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x86D2420", Offset = "0x86D0A20", VA = "0x1886D2420")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x86E49B0", Offset = "0x86E2FB0", VA = "0x1886E49B0")]
	public float NMABPCAHNKG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x86E3FD0", Offset = "0x86E25D0", VA = "0x1886E3FD0")]
	public void IFMLMIKDMCI(float KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x86E4750", Offset = "0x86E2D50", VA = "0x1886E4750")]
	public static KIFGLPPBPAP NCDCHLILNPH(OKAKHHMDEBM JGPEJMANNEB, OKAKHHMDEBM PDHHCOODKIC)
	{
		return default(KIFGLPPBPAP);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x86E39B0", Offset = "0x86E1FB0", VA = "0x1886E39B0")]
	public bool AHIBONNGGBG([Out] GameObject BEBONNCPGLF, [Out] GameObject JJEACKINPOJ, [Out] CENLKEFEGPJ CBEKJHOJHDO, [Out] CENLKEFEGPJ GAJOLBEDNHF, [Out] Vector3 APHHGJIDDCM, [Out] Vector3 PABPAPLNELK, [Out] Vector3 OGDODDEDCEC, [Out] CENLKEFEGPJ KCPEPMPNMFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x86E4520", Offset = "0x86E2B20", VA = "0x1886E4520")]
	public bool KHDAFAENMOE([Out] GameObject BEBONNCPGLF, [Out] GameObject JJEACKINPOJ, [Out] CENLKEFEGPJ CBEKJHOJHDO, [Out] CENLKEFEGPJ GAJOLBEDNHF, [Out] Vector3 APHHGJIDDCM, [Out] Vector3 PABPAPLNELK, [Out] Vector3 OGDODDEDCEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x86E4160", Offset = "0x86E2760", VA = "0x1886E4160")]
	private void JBMIEEJBMLC(Entity JAPNANJIKLB, EntityManager EAJJOPOPMMK, MagneticAnchorData EIGOPNHNDNO, [Out] GameObject BEBONNCPGLF, [Out] GameObject JJEACKINPOJ, [Out] CENLKEFEGPJ CBEKJHOJHDO, [Out] CENLKEFEGPJ GAJOLBEDNHF, [Out] Vector3 APHHGJIDDCM, [Out] Vector3 PABPAPLNELK, [Out] Vector3 OGDODDEDCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public OKAKHHMDEBM(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x86E3F40", Offset = "0x86E2540", VA = "0x1886E3F40", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(OKAKHHMDEBM AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x86E4A00", Offset = "0x86E3000", VA = "0x1886E4A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct FPCINFHMFMF : IEquatable<FPCINFHMFMF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x86D73A0", Offset = "0x86D59A0", VA = "0x1886D73A0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(FPCINFHMFMF AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct JINEJFANKMN : IEquatable<JINEJFANKMN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private OHOEFFCOCHD CLCNLOKJNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x86DDC80", Offset = "0x86DC280", VA = "0x1886DDC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public JFIFMMJLAJM CHOHNONGBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x86DDB20", Offset = "0x86DC120", VA = "0x1886DDB20")]
		get
		{
			return default(JFIFMMJLAJM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x86DD800", Offset = "0x86DBE00", VA = "0x1886DD800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public KIOIAGMFEML<string> BBHAMPBAAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x86DD850", Offset = "0x86DBE50", VA = "0x1886DD850")]
		get
		{
			return default(KIOIAGMFEML<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x86DDB60", Offset = "0x86DC160", VA = "0x1886DDB60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public KIOIAGMFEML<string> ICJACOAGNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x86DDCE0", Offset = "0x86DC2E0", VA = "0x1886DDCE0")]
		get
		{
			return default(KIOIAGMFEML<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x86DDA00", Offset = "0x86DC000", VA = "0x1886DDA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public JINEJFANKMN(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x86DD970", Offset = "0x86DBF70", VA = "0x1886DD970", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(JINEJFANKMN AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct GLCCGCCCJBH : IEquatable<GLCCGCCCJBH>
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly ComponentTypes MMFFMCFPDDN;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly GLCCGCCCJBH JFGDHENPDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Collider IFBBLKEFKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x86D8420", Offset = "0x86D6A20", VA = "0x1886D8420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public AEEBNJJBFGH IHFBMBDNFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x86D8940", Offset = "0x86D6F40", VA = "0x1886D8940")]
		get
		{
			return default(AEEBNJJBFGH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x86D8030", Offset = "0x86D6630", VA = "0x1886D8030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public CIGOCINADGN JPBBNPHFACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x86D8140", Offset = "0x86D6740", VA = "0x1886D8140")]
		get
		{
			return default(CIGOCINADGN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x86D8B10", Offset = "0x86D7110", VA = "0x1886D8B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public LMHFHHIHLDE DFDGDAHECNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x86D8100", Offset = "0x86D6700", VA = "0x1886D8100")]
		get
		{
			return default(LMHFHHIHLDE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x86D8870", Offset = "0x86D6E70", VA = "0x1886D8870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public float CILICBOGMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x86D8830", Offset = "0x86D6E30", VA = "0x1886D8830")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x86D8780", Offset = "0x86D6D80", VA = "0x1886D8780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool LCHHEMKKHLO
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x86D8DB0", Offset = "0x86D73B0", VA = "0x1886D8DB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x86D8980", Offset = "0x86D6F80", VA = "0x1886D8980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool CEALDLLOIKP
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x86D8080", Offset = "0x86D6680", VA = "0x1886D8080")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x86D8570", Offset = "0x86D6B70", VA = "0x1886D8570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool LGEJBMCJDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x86D88C0", Offset = "0x86D6EC0", VA = "0x1886D88C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x86D8210", Offset = "0x86D6810", VA = "0x1886D8210")]
	public static bool GOLDEAIMMGN(CENLKEFEGPJ FKEFBEHGFMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x86D8B60", Offset = "0x86D7160", VA = "0x1886D8B60")]
	public static bool PKCFNJDKDMF(CENLKEFEGPJ FKEFBEHGFMJ, [Out] GLCCGCCCJBH CGABDINCEMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x86D8610", Offset = "0x86D6C10", VA = "0x1886D8610")]
	public bool KANDIHBKJDF([Out] ONKGALPKPBA JKLOHCLNDDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x86D8A20", Offset = "0x86D7020", VA = "0x1886D8A20")]
	public bool OEJGIHOJILF([Out] NLPLHJLLGBB BOCNDANOLJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x86D87D0", Offset = "0x86D6DD0", VA = "0x1886D87D0")]
	public bool KHCLMPKFBEF(HEODPNLMNME NLFMOKELAPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x86D7F10", Offset = "0x86D6510", VA = "0x1886D7F10")]
	public void CBNOPKOLIDD(HEODPNLMNME NLFMOKELAPM, bool ALDDDKDADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x86D7F90", Offset = "0x86D6590", VA = "0x1886D7F90")]
	public void CCFCIOGBBDK(HEODPNLMNME NLFMOKELAPM, bool ALDDDKDADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public GLCCGCCCJBH(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x86D8180", Offset = "0x86D6780", VA = "0x1886D8180", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(GLCCGCCCJBH AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x86D8E20", Offset = "0x86D7420", VA = "0x1886D8E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct BHMPPBLAFLK : IEquatable<BHMPPBLAFLK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool DKDKMICGGEB
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x86D31D0", Offset = "0x86D17D0", VA = "0x1886D31D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public BHMPPBLAFLK(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x86D3220", Offset = "0x86D1820", VA = "0x1886D3220", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(BHMPPBLAFLK AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct DFJFIKHAJPC : IEquatable<DFJFIKHAJPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private GGLAFGKFCFM LJDKFLFHCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x86D5AC0", Offset = "0x86D40C0", VA = "0x1886D5AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x86D5BB0", Offset = "0x86D41B0", VA = "0x1886D5BB0")]
	public void FJICDHDIEOJ(bool HBBMKCLKMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public DFJFIKHAJPC(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x86D5B20", Offset = "0x86D4120", VA = "0x1886D5B20", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(DFJFIKHAJPC AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct HPGOHHJOIPE : IEquatable<HPGOHHJOIPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private ACBKFBLFNKE FOAFDCKLDNM
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x86DC8E0", Offset = "0x86DAEE0", VA = "0x1886DC8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public JFIFMMJLAJM EPIBBAOHGLM
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x86DC7E0", Offset = "0x86DADE0", VA = "0x1886DC7E0")]
		get
		{
			return default(JFIFMMJLAJM);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x86DBE50", Offset = "0x86DA450", VA = "0x1886DBE50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool AOPLPOJHBHN
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x86DC510", Offset = "0x86DAB10", VA = "0x1886DC510")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x86DC940", Offset = "0x86DAF40", VA = "0x1886DC940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public KIOIAGMFEML<string> BCNNJAAJINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x86DBF60", Offset = "0x86DA560", VA = "0x1886DBF60")]
		get
		{
			return default(KIOIAGMFEML<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x86DBC10", Offset = "0x86DA210", VA = "0x1886DBC10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public KIOIAGMFEML<string> LMHMNAJHOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x86DC080", Offset = "0x86DA680", VA = "0x1886DC080")]
		get
		{
			return default(KIOIAGMFEML<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x86DC5A0", Offset = "0x86DABA0", VA = "0x1886DC5A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public KIOIAGMFEML<string> MPBIONONJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x86DBD30", Offset = "0x86DA330", VA = "0x1886DBD30")]
		get
		{
			return default(KIOIAGMFEML<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x86DC1A0", Offset = "0x86DA7A0", VA = "0x1886DC1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public KIOIAGMFEML<string> CIJDPMHLGOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x86DC2C0", Offset = "0x86DA8C0", VA = "0x1886DC2C0")]
		get
		{
			return default(KIOIAGMFEML<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x86DC6C0", Offset = "0x86DACC0", VA = "0x1886DC6C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x86DC3E0", Offset = "0x86DA9E0", VA = "0x1886DC3E0")]
	public bool EGOOMBDOBGM(NLPLHJLLGBB AGIMJJDFEAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public HPGOHHJOIPE(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	public static NLPLHJLLGBB HNGLNPFKABH(HPGOHHJOIPE KOPHBHGIACG)
	{
		return default(NLPLHJLLGBB);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x86DC480", Offset = "0x86DAA80", VA = "0x1886DC480", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(HPGOHHJOIPE AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct BHAEBHCFCBF : IEquatable<BHAEBHCFCBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public bool PBFNMOJMBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x86D27A0", Offset = "0x86D0DA0", VA = "0x1886D27A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public bool AKJLOAGCMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x86D2C60", Offset = "0x86D1260", VA = "0x1886D2C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool KJMEHNABPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x86D2930", Offset = "0x86D0F30", VA = "0x1886D2930")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x86D2910", Offset = "0x86D0F10", VA = "0x1886D2910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool AOCMDEGOBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x86D2E80", Offset = "0x86D1480", VA = "0x1886D2E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool EPBAAIGKMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x86D3130", Offset = "0x86D1730", VA = "0x1886D3130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool OAGOMNLIDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x86D2B10", Offset = "0x86D1110", VA = "0x1886D2B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool KIJCCGKEGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x86D2710", Offset = "0x86D0D10", VA = "0x1886D2710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool MOHAGBLGLHK
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x86D23D0", Offset = "0x86D09D0", VA = "0x1886D23D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool CAHCEAHIJPB
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x86D27E0", Offset = "0x86D0DE0", VA = "0x1886D27E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool BGKDLPONMEE
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x86D2BB0", Offset = "0x86D11B0", VA = "0x1886D2BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool LHCDFCIAHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x86D2A70", Offset = "0x86D1070", VA = "0x1886D2A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool NNPHBBIDLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x86D2520", Offset = "0x86D0B20", VA = "0x1886D2520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public bool HGKAHOMMAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x86D28C0", Offset = "0x86D0EC0", VA = "0x1886D28C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public bool MMGCOAEOGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x86D30F0", Offset = "0x86D16F0", VA = "0x1886D30F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x86D2A10", Offset = "0x86D1010", VA = "0x1886D2A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool NGDLMCFHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x86D3020", Offset = "0x86D1620", VA = "0x1886D3020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public EEMOINOOAFE KACFFGMMFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x86D2390", Offset = "0x86D0990", VA = "0x1886D2390")]
		get
		{
			return default(EEMOINOOAFE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x86D2B60", Offset = "0x86D1160", VA = "0x1886D2B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public bool JLKHIDFHLBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x86D2570", Offset = "0x86D0B70", VA = "0x1886D2570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public OAOIGNGOHBK AACOOABJBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x86D2ED0", Offset = "0x86D14D0", VA = "0x1886D2ED0")]
		get
		{
			return default(OAOIGNGOHBK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x86D3180", Offset = "0x86D1780", VA = "0x1886D3180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public bool IBLMLKPIMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x86D2760", Offset = "0x86D0D60", VA = "0x1886D2760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public Vector3 EANCDPFFOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x86D2690", Offset = "0x86D0C90", VA = "0x1886D2690")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public Vector3 PGHPMCHKFKK
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x86D2F10", Offset = "0x86D1510", VA = "0x1886D2F10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public bool BPFPFLLMDNN
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x86D2CB0", Offset = "0x86D12B0", VA = "0x1886D2CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool JDADEEHGKJF
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x86D2430", Offset = "0x86D0A30", VA = "0x1886D2430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private EntityManager ACKHPMIHGLH
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x86D2420", Offset = "0x86D0A20", VA = "0x1886D2420")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x86D2C00", Offset = "0x86D1200", VA = "0x1886D2C00")]
	public bool LLMFHMBDPIM(EHGOHPLBEOO NLFMOKELAPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x86D2F90", Offset = "0x86D1590", VA = "0x1886D2F90")]
	public void OJIKAODOAMD(EHGOHPLBEOO NLFMOKELAPM, bool ALDDDKDADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x86D29C0", Offset = "0x86D0FC0", VA = "0x1886D29C0")]
	public bool HGFHNBGMBFC(ECECGBCBHKB NLFMOKELAPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x86D3070", Offset = "0x86D1670", VA = "0x1886D3070")]
	public void PBFKCABHGNK(ECECGBCBHKB NLFMOKELAPM, bool ALDDDKDADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x86D2980", Offset = "0x86D0F80", VA = "0x1886D2980")]
	public ECECGBCBHKB GOGGBBEIFEH()
	{
		return default(ECECGBCBHKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x86D2AC0", Offset = "0x86D10C0", VA = "0x1886D2AC0")]
	public bool KJKOAJDOIFK(ECECGBCBHKB KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public BHAEBHCFCBF(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x86D2830", Offset = "0x86D0E30", VA = "0x1886D2830", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(BHAEBHCFCBF AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct PLGDCNOAHBJ : IEquatable<PLGDCNOAHBJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private BFFDFPCIJKG HIHPNOJJOII
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x86E9330", Offset = "0x86E7930", VA = "0x1886E9330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x86E9390", Offset = "0x86E7990", VA = "0x1886E9390")]
	public bool BIEJENOIKEP(INIBMAJCADC LJNIMHNLCFF, List<CENLKEFEGPJ> NDPLDEAJBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x86E95F0", Offset = "0x86E7BF0", VA = "0x1886E95F0")]
	public int DPLIAEALHDG(INIBMAJCADC LJNIMHNLCFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x86E9700", Offset = "0x86E7D00", VA = "0x1886E9700")]
	public void ELHOGAIKFKB(List<CENLKEFEGPJ> NDPLDEAJBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x86E94C0", Offset = "0x86E7AC0", VA = "0x1886E94C0")]
	public int CKEBEBFKOFK(CENLKEFEGPJ AMMKGILEHBG, INIBMAJCADC LJNIMHNLCFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x86E9C40", Offset = "0x86E8240", VA = "0x1886E9C40")]
	public CENLKEFEGPJ OECELNBBHPH(int PMIGBJGNLLP, INIBMAJCADC LJNIMHNLCFF)
	{
		return default(CENLKEFEGPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x86E9A60", Offset = "0x86E8060", VA = "0x1886E9A60")]
	public void NEKLFLIBKIF(CENLKEFEGPJ AMMKGILEHBG, INIBMAJCADC LJNIMHNLCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x86E9B90", Offset = "0x86E8190", VA = "0x1886E9B90")]
	public bool NJGLDPBEIEK(CENLKEFEGPJ AMMKGILEHBG, INIBMAJCADC LJNIMHNLCFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x86E9D70", Offset = "0x86E8370", VA = "0x1886E9D70")]
	public void PLGPAEHIDHB(INIBMAJCADC LJNIMHNLCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x86E98A0", Offset = "0x86E7EA0", VA = "0x1886E98A0")]
	public bool GHLEMBINFPI(CENLKEFEGPJ AMMKGILEHBG, INIBMAJCADC LJNIMHNLCFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x86E9950", Offset = "0x86E7F50", VA = "0x1886E9950")]
	public bool KCMCFPDFHLD(INIBMAJCADC LJNIMHNLCFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public PLGDCNOAHBJ(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x86E9810", Offset = "0x86E7E10", VA = "0x1886E9810", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(PLGDCNOAHBJ AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct BGOKDKKJKFF : IEquatable<BGOKDKKJKFF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x86D2300", Offset = "0x86D0900", VA = "0x1886D2300")]
	public void OHLHNONFFNL(bool KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x86D2270", Offset = "0x86D0870", VA = "0x1886D2270")]
	public void HGJDGDKPJBC(bool KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x3B60D50", Offset = "0x3B5F350", VA = "0x183B60D50")]
	public T JMIHNFHCONJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public BGOKDKKJKFF(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x86D21E0", Offset = "0x86D07E0", VA = "0x1886D21E0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(BGOKDKKJKFF AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct MMKGLGGACOL : IEquatable<MMKGLGGACOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public bool BIFHLHNKHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x86E0E80", Offset = "0x86DF480", VA = "0x1886E0E80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x86E0EC0", Offset = "0x86DF4C0", VA = "0x1886E0EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public bool DMIKMDJILBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x86E0F10", Offset = "0x86DF510", VA = "0x1886E0F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public int DLPINAIBDFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x86E0E40", Offset = "0x86DF440", VA = "0x1886E0E40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x86E0F90", Offset = "0x86DF590", VA = "0x1886E0F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public MMKGLGGACOL(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x86E0DB0", Offset = "0x86DF3B0", VA = "0x1886E0DB0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(MMKGLGGACOL AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct JEACOCCNADF : IEquatable<JEACOCCNADF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public int ABFEOLKCHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x86DD5C0", Offset = "0x86DBBC0", VA = "0x1886DD5C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x86DD650", Offset = "0x86DBC50", VA = "0x1886DD650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public int KNNCAEOPHKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x86DD7C0", Offset = "0x86DBDC0", VA = "0x1886DD7C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x86DD600", Offset = "0x86DBC00", VA = "0x1886DD600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public uint JNNMJCBBJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x86DD730", Offset = "0x86DBD30", VA = "0x1886DD730")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x86DD770", Offset = "0x86DBD70", VA = "0x1886DD770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public JEACOCCNADF(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x86DD6A0", Offset = "0x86DBCA0", VA = "0x1886DD6A0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(JEACOCCNADF AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct HMJCDPEIIHB : IEquatable<HMJCDPEIIHB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	private GKHBFHMKFME BPNGJHNAPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x86DB110", Offset = "0x86D9710", VA = "0x1886DB110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	private LPKPBMLEPMA DKAHEBFMKIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x86DB8B0", Offset = "0x86D9EB0", VA = "0x1886DB8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public bool ECPLAGNBOAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x86DB710", Offset = "0x86D9D10", VA = "0x1886DB710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool IBGNMEPMOMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x86DADC0", Offset = "0x86D93C0", VA = "0x1886DADC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public bool HMDGCBFHEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x86DB2B0", Offset = "0x86D98B0", VA = "0x1886DB2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public bool LHBAENHMCCN
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x86DB580", Offset = "0x86D9B80", VA = "0x1886DB580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public bool DMKCJILGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x86DB6E0", Offset = "0x86D9CE0", VA = "0x1886DB6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public bool PPOEGPHDFFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x86DB650", Offset = "0x86D9C50", VA = "0x1886DB650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public bool GJFNEFHICGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x86DAF70", Offset = "0x86D9570", VA = "0x1886DAF70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public bool BKELJIBDKDL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x86DB2E0", Offset = "0x86D98E0", VA = "0x1886DB2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public bool GLMGAACEJCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x86DB450", Offset = "0x86D9A50", VA = "0x1886DB450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x86DB7A0", Offset = "0x86D9DA0", VA = "0x1886DB7A0")]
	public bool OLCOEIOGEOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x86DB810", Offset = "0x86D9E10", VA = "0x1886DB810")]
	public CENLKEFEGPJ PIGHDGICELG(CENLKEFEGPJ AMMKGILEHBG)
	{
		return default(CENLKEFEGPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x86DAE60", Offset = "0x86D9460", VA = "0x1886DAE60")]
	public NLPLHJLLGBB DLJFMMFJOGJ()
	{
		return default(NLPLHJLLGBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x86DB200", Offset = "0x86D9800", VA = "0x1886DB200")]
	public bool GBFHFIPLOBB(NLPLHJLLGBB AMMKGILEHBG, [Out] NLPLHJLLGBB BMNIGGGIJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public HMJCDPEIIHB(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x86D3380", Offset = "0x86D1980", VA = "0x1886D3380")]
	public static bool HNGLNPFKABH(HMJCDPEIIHB KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x86DB170", Offset = "0x86D9770", VA = "0x1886DB170", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(HMJCDPEIIHB AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public readonly struct GJKIJDNOFHL : IEquatable<GJKIJDNOFHL>
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static readonly GJKIJDNOFHL JFGDHENPDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public PIBCBJPPNOB JBDCFMHPLKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x86D7E00", Offset = "0x86D6400", VA = "0x1886D7E00")]
		get
		{
			return default(PIBCBJPPNOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public GCJNBCEMIDE CAPMFCMMIDO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x86D7A20", Offset = "0x86D6020", VA = "0x1886D7A20")]
		get
		{
			return default(GCJNBCEMIDE);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x86D7940", Offset = "0x86D5F40", VA = "0x1886D7940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public HMCCGFBIKNJ GOHKLGDEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x86D7DC0", Offset = "0x86D63C0", VA = "0x1886D7DC0")]
		get
		{
			return default(HMCCGFBIKNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x86D7AB0", Offset = "0x86D60B0", VA = "0x1886D7AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public float LOFJENNICHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x86D7B50", Offset = "0x86D6150", VA = "0x1886D7B50")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x86D7EC0", Offset = "0x86D64C0", VA = "0x1886D7EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public Vector3 NJLLFCLFMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x86D7B90", Offset = "0x86D6190", VA = "0x1886D7B90")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x86D7C60", Offset = "0x86D6260", VA = "0x1886D7C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public float PIFDDJJGKOE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x86D78A0", Offset = "0x86D5EA0", VA = "0x1886D78A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public LIJKMCLPLEC FHDDNCDOEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x86D7D80", Offset = "0x86D6380", VA = "0x1886D7D80")]
		get
		{
			return default(LIJKMCLPLEC);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x86D7C10", Offset = "0x86D6210", VA = "0x1886D7C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public bool JIDHOOOFBDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x86D7D40", Offset = "0x86D6340", VA = "0x1886D7D40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x86D7CE0", Offset = "0x86D62E0", VA = "0x1886D7CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public PAHODFNJBJK JJKHGJPALLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(PAHODFNJBJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public PEFJICAJNGM NHMEMMHBOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(PEFJICAJNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x86D78F0", Offset = "0x86D5EF0", VA = "0x1886D78F0")]
	public BIKIDNLDNDH CDICLJMNPEN()
	{
		return default(BIKIDNLDNDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x86D7A60", Offset = "0x86D6060", VA = "0x1886D7A60")]
	public CJNCELCCODB GLHBMDOJLDE()
	{
		return default(CJNCELCCODB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x86D7B00", Offset = "0x86D6100", VA = "0x1886D7B00")]
	private bool HCOKKHKHDDG(LIJKMCLPLEC NLFMOKELAPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x86D7E40", Offset = "0x86D6440", VA = "0x1886D7E40")]
	public void PODKJCGAPCA(LIJKMCLPLEC NLFMOKELAPM, bool ALDDDKDADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public GJKIJDNOFHL(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x86D3380", Offset = "0x86D1980", VA = "0x1886D3380")]
	public static bool HNGLNPFKABH(GJKIJDNOFHL KOPHBHGIACG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x86D1C90", Offset = "0x86D0290", VA = "0x1886D1C90")]
	public static bool HKOGMNAKMAE(GJKIJDNOFHL JGPEJMANNEB, GJKIJDNOFHL PDHHCOODKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x86D7990", Offset = "0x86D5F90", VA = "0x1886D7990", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(GJKIJDNOFHL AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public readonly struct BIKIDNLDNDH : IEquatable<BIKIDNLDNDH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public GJKIJDNOFHL FOIMALCOOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(GJKIJDNOFHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public PINBFOAJNAG OMLBHFIFGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x86D32B0", Offset = "0x86D18B0", VA = "0x1886D32B0")]
		get
		{
			return default(PINBFOAJNAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public BIKIDNLDNDH(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x86D3380", Offset = "0x86D1980", VA = "0x1886D3380")]
	public static bool HNGLNPFKABH(BIKIDNLDNDH KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x86D32F0", Offset = "0x86D18F0", VA = "0x1886D32F0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(BIKIDNLDNDH AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DefaultMember("Item")]
public readonly struct CJNCELCCODB : IEquatable<CJNCELCCODB>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly CJNCELCCODB JFGDHENPDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	private HCLANLDBIPL HJHEDNPGJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x86D5690", Offset = "0x86D3C90", VA = "0x1886D5690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public GJKIJDNOFHL FOIMALCOOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(GJKIJDNOFHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public GKJBALMMHEO JBNIOKGMCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x86D5560", Offset = "0x86D3B60", VA = "0x1886D5560")]
		get
		{
			return default(GKJBALMMHEO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x86D5440", Offset = "0x86D3A40", VA = "0x1886D5440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public IEnumerable<FOPMNDNHIJK> HLPGGPEDNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x86D4F80", Offset = "0x86D3580", VA = "0x1886D4F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public FOPMNDNHIJK LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x86D5920", Offset = "0x86D3F20", VA = "0x1886D5920")]
		get
		{
			return default(FOPMNDNHIJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x86D53B0", Offset = "0x86D39B0", VA = "0x1886D53B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public PAHODFNJBJK JJKHGJPALLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(PAHODFNJBJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x86D5190", Offset = "0x86D3790", VA = "0x1886D5190")]
	public FOPMNDNHIJK HGBCLCOEBGB(float3? APHHGJIDDCM, [Optional] quaternion? LDAEEKEKDJC, [Optional] Vector3? EAHAEIJNIMH)
	{
		return default(FOPMNDNHIJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x86D56F0", Offset = "0x86D3CF0", VA = "0x1886D56F0")]
	public FOPMNDNHIJK NDGGEIICLJP(int PMIGBJGNLLP, float3? APHHGJIDDCM, [Optional] quaternion? LDAEEKEKDJC, [Optional] Vector3? EAHAEIJNIMH)
	{
		return default(FOPMNDNHIJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x86D4DC0", Offset = "0x86D33C0", VA = "0x1886D4DC0")]
	public void DJKPDGOGCDJ(int PMIGBJGNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x86D4E60", Offset = "0x86D3460", VA = "0x1886D4E60")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public CJNCELCCODB(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x86D3380", Offset = "0x86D1980", VA = "0x1886D3380")]
	public static bool HNGLNPFKABH(CJNCELCCODB KOPHBHGIACG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x86D1F30", Offset = "0x86D0530", VA = "0x1886D1F30")]
	public static bool MGLHCKHANFO(CJNCELCCODB JGPEJMANNEB, CJNCELCCODB PDHHCOODKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x86D4EF0", Offset = "0x86D34F0", VA = "0x1886D4EF0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(CJNCELCCODB AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct FOPMNDNHIJK : IEquatable<FOPMNDNHIJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public CJNCELCCODB JKOGLCLPFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x86D7070", Offset = "0x86D5670", VA = "0x1886D7070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public float3 KNGNNNLEBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x86D71E0", Offset = "0x86D57E0", VA = "0x1886D71E0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x86D72A0", Offset = "0x86D58A0", VA = "0x1886D72A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public quaternion OGKNMPEPEHI
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x86D7300", Offset = "0x86D5900", VA = "0x1886D7300")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x86D7350", Offset = "0x86D5950", VA = "0x1886D7350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public float3 AJPCLIGCMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x86D7240", Offset = "0x86D5840", VA = "0x1886D7240")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x86D7010", Offset = "0x86D5610", VA = "0x1886D7010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public KBHPNNIEMBA IMCMDOCIAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x86D7190", Offset = "0x86D5790", VA = "0x1886D7190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x86D70F0", Offset = "0x86D56F0", VA = "0x1886D70F0")]
	public void EBPJLPHJILM(CJNCELCCODB KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public FOPMNDNHIJK(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x86D7100", Offset = "0x86D5700", VA = "0x1886D7100", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(FOPMNDNHIJK AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public readonly struct MDPDPJFNMFP : IEquatable<MDPDPJFNMFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public bool CHPIEBHJFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x86E0D40", Offset = "0x86DF340", VA = "0x1886E0D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public MDPDPJFNMFP(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x86E0CB0", Offset = "0x86DF2B0", VA = "0x1886E0CB0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(MDPDPJFNMFP AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct OOECFBCJOAH : IEquatable<OOECFBCJOAH>
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public static readonly OOECFBCJOAH JFGDHENPDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	private BMLFEODEIIG EIBHLIKKBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x86E4F30", Offset = "0x86E3530", VA = "0x1886E4F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public uint FHCJFNNFJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x86E53C0", Offset = "0x86E39C0", VA = "0x1886E53C0")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x86E4DD0", Offset = "0x86E33D0", VA = "0x1886E4DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public NGKDAGAOOPI JCEHJJDLCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x86E4E60", Offset = "0x86E3460", VA = "0x1886E4E60")]
		get
		{
			return default(NGKDAGAOOPI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x86E5860", Offset = "0x86E3E60", VA = "0x1886E5860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public float LDDFDCHBBCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x86E4D90", Offset = "0x86E3390", VA = "0x1886E4D90")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x86E52E0", Offset = "0x86E38E0", VA = "0x1886E52E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public float ELBCOFBKOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x86E5140", Offset = "0x86E3740", VA = "0x1886E5140")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x86E5290", Offset = "0x86E3890", VA = "0x1886E5290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public COCHOMAPEKN BNEENENIBAL
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x86E5560", Offset = "0x86E3B60", VA = "0x1886E5560")]
		get
		{
			return default(COCHOMAPEKN);
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x86E5790", Offset = "0x86E3D90", VA = "0x1886E5790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public float IBIKCGGCLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x86E5900", Offset = "0x86E3F00", VA = "0x1886E5900")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x86E4EE0", Offset = "0x86E34E0", VA = "0x1886E4EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public float CGHKAGPDKJP
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x86E56B0", Offset = "0x86E3CB0", VA = "0x1886E56B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public float HKJGLAMCDIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x86E4E20", Offset = "0x86E3420", VA = "0x1886E4E20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public float LEIDHEGILFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x86E4F90", Offset = "0x86E3590", VA = "0x1886E4F90")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x86E55A0", Offset = "0x86E3BA0", VA = "0x1886E55A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public GCJNBCEMIDE EGCKMMNLJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x86E4EA0", Offset = "0x86E34A0", VA = "0x1886E4EA0")]
		get
		{
			return default(GCJNBCEMIDE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x86E4FD0", Offset = "0x86E35D0", VA = "0x1886E4FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public GCJNBCEMIDE JKMKBBHEKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x86E5820", Offset = "0x86E3E20", VA = "0x1886E5820")]
		get
		{
			return default(GCJNBCEMIDE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x86E5400", Offset = "0x86E3A00", VA = "0x1886E5400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public float LENDLMHCHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x86E57E0", Offset = "0x86E3DE0", VA = "0x1886E57E0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x86E5450", Offset = "0x86E3A50", VA = "0x1886E5450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public PPLBBBHFMKJ BBIKCGLFALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x86E5700", Offset = "0x86E3D00", VA = "0x1886E5700")]
		get
		{
			return default(PPLBBBHFMKJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x86E58B0", Offset = "0x86E3EB0", VA = "0x1886E58B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public BMBIMNFFOOL OHJGKIJGFCN
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x86E5940", Offset = "0x86E3F40", VA = "0x1886E5940")]
		get
		{
			return default(BMBIMNFFOOL);
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x86E5740", Offset = "0x86E3D40", VA = "0x1886E5740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	public ReadOnlySpan<TerrainGenerationLayer> AHPLLINDHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x86E55F0", Offset = "0x86E3BF0", VA = "0x1886E55F0")]
		get
		{
			return default(ReadOnlySpan<TerrainGenerationLayer>);
		}
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x86E5180", Offset = "0x86E3780", VA = "0x1886E5180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	public ReadOnlySpan<OCLIGBIFNLE> CCKFNLEGDPB
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x86E54A0", Offset = "0x86E3AA0", VA = "0x1886E54A0")]
		get
		{
			return default(ReadOnlySpan<OCLIGBIFNLE>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x86E5020", Offset = "0x86E3620", VA = "0x1886E5020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public OOECFBCJOAH(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	public static NLPLHJLLGBB HNGLNPFKABH(OOECFBCJOAH KOPHBHGIACG)
	{
		return default(NLPLHJLLGBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x86E5330", Offset = "0x86E3930", VA = "0x1886E5330", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(OOECFBCJOAH AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct HENHGNPDHCM : IEquatable<HENHGNPDHCM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	private MOMAELGFDAM HOPFHMMFIPI
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x86D9E30", Offset = "0x86D8430", VA = "0x1886D9E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	public bool MLMBKCIFHBO
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x86D9A20", Offset = "0x86D8020", VA = "0x1886D9A20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x86D95D0", Offset = "0x86D7BD0", VA = "0x1886D95D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public bool LFHMJDCFGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x86D9D20", Offset = "0x86D8320", VA = "0x1886D9D20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x86D9E90", Offset = "0x86D8490", VA = "0x1886D9E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public float LLOFEPHDLID
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x86D9DF0", Offset = "0x86D83F0", VA = "0x1886D9DF0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x86D9630", Offset = "0x86D7C30", VA = "0x1886D9630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public bool LKAHPFNJOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x86D9EF0", Offset = "0x86D84F0", VA = "0x1886D9EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x86D9FE0", Offset = "0x86D85E0", VA = "0x1886D9FE0")]
	public void PKJJJJFDGNF(int PCLFJGMAHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x86D9C10", Offset = "0x86D8210", VA = "0x1886D9C10")]
	public bool JFJNKKKJCLJ([Out] int PCLFJGMAHBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x86D9F40", Offset = "0x86D8540", VA = "0x1886D9F40")]
	public void PJNKFHIPMPO(bool FHHAPCHNGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x86D9BC0", Offset = "0x86D81C0", VA = "0x1886D9BC0")]
	public bool IDOBEGLCPNH(BPFBLAOAHAF NLFMOKELAPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x86D9D70", Offset = "0x86D8370", VA = "0x1886D9D70")]
	public void LHCMBJBACLI(BPFBLAOAHAF NLFMOKELAPM, bool ALDDDKDADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x86D9A70", Offset = "0x86D8070", VA = "0x1886D9A70")]
	public void HLDADJEKKJI(float IDEEBBOKKCE, float HHAHNLNFEKF, float LFKCLNPAKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x86D98D0", Offset = "0x86D7ED0", VA = "0x1886D98D0")]
	public void GACCLNLLOOK(float3 BAPLIGJNDAM, quaternion CMPJAGKJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x86D94A0", Offset = "0x86D7AA0", VA = "0x1886D94A0")]
	public bool AFMDFBNKKJG([Out] float3 BAPLIGJNDAM, [Out] quaternion CMPJAGKJDHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x86D9710", Offset = "0x86D7D10", VA = "0x1886D9710")]
	public bool DIIJFNBFHMB([Out] float OOIDMOALOBB, [Out] float PNHJHHDAHBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x86D9680", Offset = "0x86D7C80", VA = "0x1886D9680")]
	public void CDOJHCIMAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public HENHGNPDHCM(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x86D9840", Offset = "0x86D7E40", VA = "0x1886D9840", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(HENHGNPDHCM AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public readonly struct PAHODFNJBJK : IEquatable<PAHODFNJBJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	private BLCEJAOLGDJ BJGMMDFIMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x86E5F90", Offset = "0x86E4590", VA = "0x1886E5F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	public Vector3 KNGNNNLEBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x86E6470", Offset = "0x86E4A70", VA = "0x1886E6470")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x86E66B0", Offset = "0x86E4CB0", VA = "0x1886E66B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	public Quaternion OGKNMPEPEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x86E7150", Offset = "0x86E5750", VA = "0x1886E7150")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x86E7510", Offset = "0x86E5B10", VA = "0x1886E7510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public Vector3 GLHHDIBFIHK
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x86E5B10", Offset = "0x86E4110", VA = "0x1886E5B10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x86E75E0", Offset = "0x86E5BE0", VA = "0x1886E75E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public Quaternion CEJBPPBLEFD
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x86E6560", Offset = "0x86E4B60", VA = "0x1886E6560")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x86E6EF0", Offset = "0x86E54F0", VA = "0x1886E6EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public float PCAINAIAGBP
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x86E61B0", Offset = "0x86E47B0", VA = "0x1886E61B0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x86E6D70", Offset = "0x86E5370", VA = "0x1886E6D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public float BMBFLPIKNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x86E6250", Offset = "0x86E4850", VA = "0x1886E6250")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	public Matrix4x4 LIGFGKDFHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x86E5AD0", Offset = "0x86E40D0", VA = "0x1886E5AD0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public PEFJICAJNGM NHMEMMHBOAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(PEFJICAJNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	private HNBHNOBANOG EIBKLMACMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x86D3E60", Offset = "0x86D2460", VA = "0x1886D3E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x86E7780", Offset = "0x86E5D80", VA = "0x1886E7780")]
	public ACLDACCHLEI PMLGOHFPJCB()
	{
		return default(ACLDACCHLEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x86E6870", Offset = "0x86E4E70", VA = "0x1886E6870")]
	public void IJONOCGDBMF([Out] Matrix4x4 PDKLFCKPAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x86E6BB0", Offset = "0x86E51B0", VA = "0x1886E6BB0")]
	public void JIBOHDAOEFO([In] Vector3 GDEKJEBPHAB, [In] Quaternion JJIKKLJGABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x86E6CB0", Offset = "0x86E52B0", VA = "0x1886E6CB0")]
	public void JIBOHDAOEFO([In] RigidTransform KEPDHPAHDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x86E5C00", Offset = "0x86E4200", VA = "0x1886E5C00")]
	public void DCEPBEBACDI([Out] RigidTransform KEPDHPAHDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x86E7360", Offset = "0x86E5960", VA = "0x1886E7360")]
	public void MIKKFMKIGAB([In] Vector3 JHADDIHGPPK, [In] Quaternion IFFHLFGFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x86E72A0", Offset = "0x86E58A0", VA = "0x1886E72A0")]
	public void MIKKFMKIGAB([In] RigidTransform PDIPPFLBMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x86E7070", Offset = "0x86E5670", VA = "0x1886E7070")]
	public void LPBFMBPPLJD([Out] Vector3 JHADDIHGPPK, [Out] Quaternion IFFHLFGFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x86E6FC0", Offset = "0x86E55C0", VA = "0x1886E6FC0")]
	public void LPBFMBPPLJD([Out] RigidTransform KEPDHPAHDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x86E63B0", Offset = "0x86E49B0", VA = "0x1886E63B0")]
	public UniformTRS GEBLAGCOIOI()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x86E62F0", Offset = "0x86E48F0", VA = "0x1886E62F0")]
	public void GEBLAGCOIOI([Out] UniformTRS PDIPPFLBMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x86E6840", Offset = "0x86E4E40", VA = "0x1886E6840")]
	public UniformTRS IGEIPFONIBP()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x86E6780", Offset = "0x86E4D80", VA = "0x1886E6780")]
	public void IGEIPFONIBP([Out] UniformTRS KEPDHPAHDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x86E77D0", Offset = "0x86E5DD0", VA = "0x1886E77D0")]
	public Vector3 PPAPOMLMMCE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x86E6AE0", Offset = "0x86E50E0", VA = "0x1886E6AE0")]
	public void JENHNLBELHK([In] Vector3 KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x86E5EA0", Offset = "0x86E44A0", VA = "0x1886E5EA0")]
	public Vector3 EJBIEJDBADJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x86E6E20", Offset = "0x86E5420", VA = "0x1886E6E20")]
	public void JPLNDNJIELG([In] Vector3 KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x86E5CB0", Offset = "0x86E42B0", VA = "0x1886E5CB0")]
	public Quaternion DMJEBPFGJBJ()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x86E76B0", Offset = "0x86E5CB0", VA = "0x1886E76B0")]
	public void OODEFOMALPL([In] Quaternion KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x86E5980", Offset = "0x86E3F80", VA = "0x1886E5980")]
	public Quaternion AEHGAOGOMKA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x86E6050", Offset = "0x86E4650", VA = "0x1886E6050")]
	public void EOEKADGOIBC([In] Quaternion KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x86E5E00", Offset = "0x86E4400", VA = "0x1886E5E00")]
	public float EDAFLCJNBFF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x86E6990", Offset = "0x86E4F90", VA = "0x1886E6990")]
	public void IMLCBDNNDLA(float KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x86E6A40", Offset = "0x86E5040", VA = "0x1886E6A40")]
	public float JAJHCKDKLJC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x86E7460", Offset = "0x86E5A60", VA = "0x1886E7460")]
	public void OBNAGDICMAP(float KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x86E63E0", Offset = "0x86E49E0", VA = "0x1886E63E0")]
	public Vector3 GFOHPGAFCBN([In] Vector3 JPDMHOCEDGB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public PAHODFNJBJK(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x86E6120", Offset = "0x86E4720", VA = "0x1886E6120", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(PAHODFNJBJK AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct ANEFALGKKIK : IEquatable<ANEFALGKKIK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	private IOAHMMMBCHD NMGOFGODOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x86D08D0", Offset = "0x86CEED0", VA = "0x1886D08D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	public CENLKEFEGPJ JGMAPBOCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(CENLKEFEGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	private FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x86D08C0", Offset = "0x86CEEC0", VA = "0x1886D08C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x86D09D0", Offset = "0x86CEFD0", VA = "0x1886D09D0")]
	public void FBGLFHMFELB(string PEIEJMGOHLN, BBBGMONOBKI MIKGDJBNCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public ANEFALGKKIK(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x86D0930", Offset = "0x86CEF30", VA = "0x1886D0930", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(ANEFALGKKIK AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B40", Offset = "0x86CF140", VA = "0x1886D0B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public readonly struct EOIOCFFOJPH : IEquatable<EOIOCFFOJPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public MLPFDOKAHEM MCCCINPAKPN
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x86D6400", Offset = "0x86D4A00", VA = "0x1886D6400")]
		get
		{
			return default(MLPFDOKAHEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public EOIOCFFOJPH(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x86D6370", Offset = "0x86D4970", VA = "0x1886D6370", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(EOIOCFFOJPH AAGCKLPFJME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public readonly struct NBIELCKFLNI : IEquatable<NBIELCKFLNI>
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public struct LAILBFDCAIG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private NLPLHJLLGBB BJCKBJFHLNJ;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x86DF830", Offset = "0x86DDE30", VA = "0x1886DF830")]
		public LAILBFDCAIG(NLPLHJLLGBB BJCKBJFHLNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x86DF7A0", Offset = "0x86DDDA0", VA = "0x1886DF7A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x86E12E0", Offset = "0x86DF8E0", VA = "0x1886E12E0")]
	public LAILBFDCAIG BEIMJHMCLML()
	{
		return default(LAILBFDCAIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x86E1370", Offset = "0x86DF970", VA = "0x1886E1370")]
	public JJHFOALIMMD EHJNNDPKHMA(Allocator EEDCBHBBPKF = Allocator.Temp)
	{
		return default(JJHFOALIMMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x86E17E0", Offset = "0x86DFDE0", VA = "0x1886E17E0")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> OPKCDBPDLEM(Allocator EEDCBHBBPKF = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x86E1910", Offset = "0x86DFF10", VA = "0x1886E1910")]
	public NativeArray<NEKBNCKOEOB> PDOPMJHIAEN(Allocator EEDCBHBBPKF = Allocator.Temp)
	{
		return default(NativeArray<NEKBNCKOEOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x86E15B0", Offset = "0x86DFBB0", VA = "0x1886E15B0")]
	public NativeArray<NEKBNCKOEOB> GENAGPJACAD(Allocator EEDCBHBBPKF = Allocator.Temp)
	{
		return default(NativeArray<NEKBNCKOEOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x86E14F0", Offset = "0x86DFAF0", VA = "0x1886E14F0")]
	public PDHGKNBOAKO FCNBAJOLKEM(Allocator EEDCBHBBPKF = Allocator.Temp)
	{
		return default(PDHGKNBOAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x86E1720", Offset = "0x86DFD20", VA = "0x1886E1720")]
	public PDHGKNBOAKO NFLGMPMHMKF(Allocator EEDCBHBBPKF = Allocator.Temp)
	{
		return default(PDHGKNBOAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x86E1660", Offset = "0x86DFC60", VA = "0x1886E1660")]
	public PDHGKNBOAKO IMNGLFIHBKM(Allocator EEDCBHBBPKF = Allocator.Temp)
	{
		return default(PDHGKNBOAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public NBIELCKFLNI(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x86E1460", Offset = "0x86DFA60", VA = "0x1886E1460", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(NBIELCKFLNI AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x86E19C0", Offset = "0x86DFFC0", VA = "0x1886E19C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct EIHMCGDLAPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int PDJOCFJGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public int CLIEOFBOBKM;
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public readonly struct OEIKFIGBJCJ : IEquatable<OEIKFIGBJCJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public NBIELCKFLNI NAIEKDFFKFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NBIELCKFLNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public OAMOIBGOMKK KPNDEMDNCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(OAMOIBGOMKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	public EOIOCFFOJPH ALPJCJPKLIL
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(EOIOCFFOJPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x86E3910", Offset = "0x86E1F10", VA = "0x1886E3910")]
	public bool NABKFONFNLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x86E3790", Offset = "0x86E1D90", VA = "0x1886E3790")]
	public bool JGFDOKGMAIG([Out] Exception MFJLILBLNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public OEIKFIGBJCJ(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	public static NLPLHJLLGBB HNGLNPFKABH(OEIKFIGBJCJ KOPHBHGIACG)
	{
		return default(NLPLHJLLGBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x86E3700", Offset = "0x86E1D00", VA = "0x1886E3700", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(OEIKFIGBJCJ AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x86E19C0", Offset = "0x86DFFC0", VA = "0x1886E19C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public readonly struct CDIEDCCGMNO : IDisposable, IEquatable<CDIEDCCGMNO>
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static readonly CDIEDCCGMNO JFGDHENPDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	public OEIKFIGBJCJ OLKMHNEGKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(OEIKFIGBJCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	public NBIELCKFLNI NAIEKDFFKFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NBIELCKFLNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x86D3690", Offset = "0x86D1C90", VA = "0x1886D3690")]
	public void OKDKNKPHBMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x86D3530", Offset = "0x86D1B30", VA = "0x1886D3530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public CDIEDCCGMNO(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x86D3600", Offset = "0x86D1C00", VA = "0x1886D3600", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "5")]
	public bool Equals(CDIEDCCGMNO AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x86D3710", Offset = "0x86D1D10", VA = "0x1886D3710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public readonly struct OAMOIBGOMKK : IEquatable<OAMOIBGOMKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly NLPLHJLLGBB OIHEEOJKKOF;

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	public bool DFBMMOPFMAA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x86E3670", Offset = "0x86E1C70", VA = "0x1886E3670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	public OAMOIBGOMKK(NLPLHJLLGBB BJCKBJFHLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x86D0B10", Offset = "0x86CF110", VA = "0x1886D0B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x86E35E0", Offset = "0x86E1BE0", VA = "0x1886E35E0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x86D09C0", Offset = "0x86CEFC0", VA = "0x1886D09C0", Slot = "4")]
	public bool Equals(OAMOIBGOMKK AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x86E19C0", Offset = "0x86DFFC0", VA = "0x1886E19C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class GLDEKAMILDE
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private struct OECCKEGHFEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Guid JJCLDINKIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public JOOMMLIBHBG MAKPGANOLGJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private struct JOOMMLIBHBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int KOPHBHGIACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int NAKGGLJDOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int ODJOHKOIKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int PKPBMFKHDPI;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x86DDFC0", Offset = "0x86DC5C0", VA = "0x1886DDFC0")]
		public bool MAEGLFANIMI([Out] NEKBNCKOEOB MLCIEJIIPCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x86DE060", Offset = "0x86DC660", VA = "0x1886DE060")]
		public JOOMMLIBHBG(NEKBNCKOEOB MLCIEJIIPCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x86D9040", Offset = "0x86D7640", VA = "0x1886D9040")]
	public static Guid HCDDIHGIELN(this NEKBNCKOEOB MLCIEJIIPCN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x86D90E0", Offset = "0x86D76E0", VA = "0x1886D90E0")]
	public static bool NGNDAIEDCIL(this Guid JJCLDINKIFD, [Out] NEKBNCKOEOB MLCIEJIIPCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
internal static class OLGHBMPLGKE
{
	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x86E4D00", Offset = "0x86E3300", VA = "0x1886E4D00")]
	public static FIMHEFEBFND OJEEGEKNOKC(this NLPLHJLLGBB NMILEMOAODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x86E4B90", Offset = "0x86E3190", VA = "0x1886E4B90")]
	public static EPCIOFAAGGG CADNOFCPFJN(this NLPLHJLLGBB NMILEMOAODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x86E4B00", Offset = "0x86E3100", VA = "0x1886E4B00")]
	public static EntityManager ACKHPMIHGLH(this NLPLHJLLGBB NMILEMOAODL)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x3F7E5B0", Offset = "0x3F7CBB0", VA = "0x183F7E5B0")]
	internal static bool AHCCCJLILIM<T>(this NLPLHJLLGBB NMILEMOAODL, bool ALDDDKDADPG) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x86E4BF0", Offset = "0x86E31F0", VA = "0x1886E4BF0")]
	public static bool FBDKAODIJGM(this NLPLHJLLGBB NMILEMOAODL, JPCENFLHKDB GBIEIIJCCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x3F839C0", Offset = "0x3F81FC0", VA = "0x183F839C0")]
	public static bool PIIOBNOCEFJ<T>(this NLPLHJLLGBB NMILEMOAODL) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x3F80520", Offset = "0x3F7EB20", VA = "0x183F80520")]
	public static bool ICBPMHLELLC<T>(this NLPLHJLLGBB NMILEMOAODL) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x3F80310", Offset = "0x3F7E910", VA = "0x183F80310")]
	[PEIHBKFLLHF]
	internal static NativeArray<T> FHDJNCLMPHN<T>(this NLPLHJLLGBB NMILEMOAODL, Allocator EEDCBHBBPKF) where T : struct, IBufferElementData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x3F7E770", Offset = "0x3F7CD70", VA = "0x183F7E770")]
	[PEIHBKFLLHF]
	public static T CMBMKOOPNMG<T>(this NLPLHJLLGBB NMILEMOAODL) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x3F80730", Offset = "0x3F7ED30", VA = "0x183F80730")]
	[PEIHBKFLLHF]
	public static T KJCCNIKFHHM<T>(this NLPLHJLLGBB NMILEMOAODL) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x3F80400", Offset = "0x3F7EA00", VA = "0x183F80400")]
	public static bool HLEELHHLBOE<T>(this NLPLHJLLGBB NMILEMOAODL, [Out] T KOPHBHGIACG) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x3F837F0", Offset = "0x3F81DF0", VA = "0x183F837F0")]
	public static T MNDHDPENFPO<T>(this NLPLHJLLGBB NMILEMOAODL) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x3F83940", Offset = "0x3F81F40", VA = "0x183F83940")]
	public static T NCNDDPICCNE<T>(this NLPLHJLLGBB NMILEMOAODL) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
internal static class COLLGPHOCFI
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[DefaultMember("Item")]
public struct JJHFOALIMMD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private PDHGKNBOAKO PPEFJKBNOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> IOBNFLCGDPP;

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x62A7AA0", Offset = "0x62A60A0", VA = "0x1862A7AA0")]
	public JJHFOALIMMD(PDHGKNBOAKO PPEFJKBNOEP, NativeArray<EntityRemapUtility.EntityRemapInfo> IOBNFLCGDPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x86DDEC0", Offset = "0x86DC4C0", VA = "0x1886DDEC0")]
	public LocalId LNGEBDOJEJA(LocalId MPIDDJPOOMJ)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x86DDE70", Offset = "0x86DC470", VA = "0x1886DDE70")]
	public LocalId LNGEBDOJEJA(int PMIGBJGNLLP)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x86DDE00", Offset = "0x86DC400", VA = "0x1886DDE00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OIEDFIPBJNH
{
	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EOGIOMFEKKD(NLPLHJLLGBB IIIJIBCGHEO, [Out] uint NMILEMOAODL);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NCBHNCMHFGJ(NLPLHJLLGBB IIIJIBCGHEO, [Out] uint NMILEMOAODL);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKGINMFFHCO(NLPLHJLLGBB IIIJIBCGHEO, uint NMILEMOAODL);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PEAGKDOPCBI(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string DELLCBCODKM(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JBAJPJJLBGP(NLPLHJLLGBB IIIJIBCGHEO, string NMILEMOAODL);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FKDIADNHNDL(NLPLHJLLGBB IIIJIBCGHEO, [Out] string NIHHLFKJLCA);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LNPBDCMCBHJ(NLPLHJLLGBB IIIJIBCGHEO, string NIHHLFKJLCA);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JNPPPJEJEON
{
	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	Guid DMMFHPPBELL
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	Guid NGPKBAFLMFA
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JFICHHNPGLF(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PBBIGOPOCMM(CENLKEFEGPJ MPIDDJPOOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid HEBFJPBLGEM(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BIENGALPGFL(NLPLHJLLGBB BJCKBJFHLNJ, Guid PLBMJMHLGMM);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EILKDJKLJLH(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task CBLJCLMGKGL(NLPLHJLLGBB PEKDBPKONMC, NLPLHJLLGBB BEBONNCPGLF);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ICCKFFLJJJF(NLPLHJLLGBB BJCKBJFHLNJ, NEKBNCKOEOB IBACMIDAKGN);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FNGNLPBEGGF
{
	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	Guid DMMFHPPBELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLPIPMFCEPO(NativeList<Guid> BNKCBDMAIAJ, NativeList<Guid> ILMBAOKGDLA, NativeList<FixedString64Bytes> CEIPJFFIMKL);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IDCEBPCFOEC
{
	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PDHGKNBOAKO PJAJABHPKJF(Allocator EEDCBHBBPKF);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PDHGKNBOAKO LJCDGHMKANM(Allocator EEDCBHBBPKF);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IEOJJOKJOEO(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DMIKMDJILBJ(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PNNAIAKBKJB(NLPLHJLLGBB IIIJIBCGHEO, [Out] NLPLHJLLGBB OGEBCAKDMMI);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BIFHLHNKHOO(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BIPPEDEGFOL(NLPLHJLLGBB IIIJIBCGHEO, int MGHFDLLINAI);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NLPLHJLLGBB OLIHNMFPHPF(NLPLHJLLGBB OGEBCAKDMMI);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NDMLCCGAPKP(PDHGKNBOAKO LFFADIOANKA, bool JOELCGNGHGJ);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool LMFECDGHEEF(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NJMDFDBHGAG(NLPLHJLLGBB IIIJIBCGHEO, bool DMCGKHHFFHF);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int MNMABBKDIMM();

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FEEEFHEKKGA(NLPLHJLLGBB BJCKBJFHLNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AFGPKHPOMIB
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<NLPLHJLLGBB, NLPLHJLLGBB> LHIGDOEHMML;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<NLPLHJLLGBB, NLPLHJLLGBB> IFPONFKPKAG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<NLPLHJLLGBB, NLPLHJLLGBB, NLPLHJLLGBB> MEHKHANDGIJ;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<NLPLHJLLGBB> CPBGCNCLMLF;

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IPPBLNEKNPP(NLPLHJLLGBB BJCKBJFHLNJ, NLPLHJLLGBB CPKJMACKMHK);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NLPLHJLLGBB MMBEKCEEEIB(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PDHGKNBOAKO MEDKJPKNNHP(NLPLHJLLGBB BJCKBJFHLNJ, Allocator EEDCBHBBPKF);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NLPLHJLLGBB CPKOGAFKJLC(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ELGPACJCOGM(NLPLHJLLGBB BJCKBJFHLNJ, Vector3 LCJCICAHHCF, Quaternion DKBCGKBLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DKMEJBAHOOB(NLPLHJLLGBB BJCKBJFHLNJ, float BJNPNLJGPDG);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool JKJHFHPPHBN(NLPLHJLLGBB BJCKBJFHLNJ, [Out] NLPLHJLLGBB BEBONNCPGLF);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool DJDFHEEPJCK(NLPLHJLLGBB BJCKBJFHLNJ, [Out] RigidTransform IBNAEGKOCIN);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 HFONECEGOMM(HGCNIPJCLII DFELMPOJHGA);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion PIDLHCFEINJ(HGCNIPJCLII DFELMPOJHGA);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class KMJNNDHBGJB
{
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BMMPJAGNPHD
{
	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	object HKAEACJCDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JOHJCGOKEFI
{
	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFFJPFNNKEH(NLPLHJLLGBB MPIDDJPOOMJ, FOHKKODBCBA LLBCHEOKJKH);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDLEIICPKDK(FOHKKODBCBA LLBCHEOKJKH);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HMMEEFIKJAA(NLPLHJLLGBB BJCKBJFHLNJ, [Out] FOHKKODBCBA DPFGFPKHPEK);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MKENBHEPBNB
{
	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLMKLEDBIGL(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeArray<NLPLHJLLGBB> DGKAHJCAPGE();
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Flags]
public enum DGLBKLPBPLC
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
[Cpp2IlInjected.Token(Token = "0x200009F")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LJFAHJAJKGF
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public ref struct MNIPFBBFJEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ReadOnlySpan<NLPLHJLLGBB> GEJJFCLFEAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public ReadOnlySpan<NLPLHJLLGBB> KENHGPAFDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public NLPLHJLLGBB ELFOPEKGIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public NLPLHJLLGBB MDKIHIMEKAK;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OEOFLCBOEMN(NLPLHJLLGBB DEPIAFALMNF, NLPLHJLLGBB PNMHGPDGNHB);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KOHJJNMDEFP(NLPLHJLLGBB KGLHNAOBPON, bool AKKFOJDOENB);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CIDFCFLIIOO(NLPLHJLLGBB NMIHHGOGOGB, NLPLHJLLGBB KHHBDNKEINE);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MMLFEAHKMNM(NLPLHJLLGBB LMKHOCAFFFE, bool AKKFOJDOENB);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BCEIGKINKGK(NLPLHJLLGBB LMKHOCAFFFE);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GHNIFJGIJNJ(NLPLHJLLGBB LMKHOCAFFFE);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NLPLHJLLGBB JFJHOKJFFDC(NLPLHJLLGBB KGLHNAOBPON);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ReadOnlySpan<NLPLHJLLGBB> NGOLGMMNMLG(NLPLHJLLGBB LMKHOCAFFFE);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ReadOnlySpan<NLPLHJLLGBB> NKOBADIJIEA(NLPLHJLLGBB LMKHOCAFFFE);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MNIPFBBFJEN FGGBPFMECKB(NLPLHJLLGBB LMKHOCAFFFE, float DAMLCCMJENA, float FCGHMAPKBNH);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NGMHNAEBECO(NLPLHJLLGBB LMKHOCAFFFE, [Out] GHDKOKGPEBF AIGJAIAAGPL);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BKAKOELNAGC(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JNPMLKBGCPH(NLPLHJLLGBB BJCKBJFHLNJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public readonly struct KECKAAKAFCN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly string NDIENANOGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly T APJDJFMLEAP;

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x55E6630", Offset = "0x55E4C30", VA = "0x1855E6630")]
	public KECKAAKAFCN(T APJDJFMLEAP, [Optional][CallerMemberName] string NDIENANOGEK)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly KECKAAKAFCN<int> AOJFHKIJKON;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public static readonly KECKAAKAFCN<int> JNAGBPIBOIN;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static readonly KECKAAKAFCN<int> LJFGDOFMNEF;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public enum KPJHNJFBKJO
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class GKCCADOCHPH
{
	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x1566090", Offset = "0x1564690", VA = "0x181566090")]
	public static bool JGDEKALAIMK(this KPJHNJFBKJO HFPFCKAPBFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x1977DE0", Offset = "0x19763E0", VA = "0x181977DE0")]
	public static bool BLPNOHPDPGH(this KPJHNJFBKJO HFPFCKAPBFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x3274F80", Offset = "0x3273580", VA = "0x183274F80")]
	public static bool KCLMEENHGMG(this KPJHNJFBKJO HFPFCKAPBFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x15660A0", Offset = "0x15646A0", VA = "0x1815660A0")]
	public static bool PKPGPAIONGM(this KPJHNJFBKJO HFPFCKAPBFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CKBLGCNIDEA
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public enum AHKBNHNHPPN
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

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum MOIAEBCAJFA
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001EC")]
	AHKBNHNHPPN LPGAFMLEJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001ED")]
	bool PALGANKOJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EE")]
	bool APGJJIGAFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EF")]
	MOIAEBCAJFA KAGKJCPNMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.Application)]
public interface HKOHKDOPABA
{
	[Cpp2IlInjected.Token(Token = "0x170001F0")]
	KPJHNJFBKJO PMJGIINPAIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F1")]
	KPJHNJFBKJO JGHKMFOJCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F2")]
	KPJHNJFBKJO INHLENOGAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F3")]
	KPJHNJFBKJO JOENHKFEPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F4")]
	KPJHNJFBKJO EHHPICMKJME
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F5")]
	KPJHNJFBKJO ODMJNILKHIE
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F6")]
	KPJHNJFBKJO LMNAFABIDLF
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F7")]
	KPJHNJFBKJO OMBMIAANNFD
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F8")]
	KPJHNJFBKJO DIHMABBPFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	KPJHNJFBKJO KOLFHMIFFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	KPJHNJFBKJO HLHHAJNCOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	KPJHNJFBKJO OFMHDCNOAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	KPJHNJFBKJO JPGDGCDNANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	KPJHNJFBKJO DGBPPHIBPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	KPJHNJFBKJO JOCOJOFPLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	KPJHNJFBKJO LADLNFMBHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000200")]
	KPJHNJFBKJO NMLBCPNOCOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	KPJHNJFBKJO PNOODGABAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000202")]
	KPJHNJFBKJO EDAJILFGNCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000203")]
	KPJHNJFBKJO FOGNLMIGKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HBAOOBIPNDD(KECKAAKAFCN<int> GKBHDDGIDDH);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OJHGNPOOCLL
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event NCHPCAADJAG.HABFMOGJOAB MBEKIEIGEAE;

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NLPLHJLLGBB NDDIDKGHBKN(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PDHGKNBOAKO LLGDMNOFODC(Allocator EEDCBHBBPKF);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KBHPNNIEMBA DICENPKCNKO(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KHHGMOBKCIH(IEnumerable<NLPLHJLLGBB> MHOFPPIEOOH);

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KBHPNNIEMBA FBKDHOBCKMF(NLPLHJLLGBB BEBONNCPGLF, NLPLHJLLGBB PPEFJKBNOEP, bool PNHKINKHLJE, NLPLHJLLGBB AMMKGILEHBG);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NLPLHJLLGBB AFGPLCNMJDO(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NMLEEMHPCCP(NLPLHJLLGBB BJCKBJFHLNJ, NLPLHJLLGBB BEBONNCPGLF, bool KONCKGMOKCH = false);

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HCCFICBBONP(NLPLHJLLGBB BJCKBJFHLNJ, NLPLHJLLGBB BEBONNCPGLF);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool PGDDLOKMLBI(NLPLHJLLGBB FIHGHBNABEC, NLPLHJLLGBB AAKALJPGDNG);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	PDHGKNBOAKO PIEIFBGOBEA(NLPLHJLLGBB OIHEEOJKKOF);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DCIPJCLIJAG(NLPLHJLLGBB BJCKBJFHLNJ, NLPLHJLLGBB FPGCFPKINEL);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "13")]
	PDHGKNBOAKO JCFPODMLGAL(PDHGKNBOAKO ECMHDBMLNPI, DGLBKLPBPLC ANBGOGICGFD, Allocator EEDCBHBBPKF);

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool NGIKDLJOEEL(NLPLHJLLGBB BJCKBJFHLNJ, NLPLHJLLGBB DOEFIPICAFB);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NLPLHJLLGBB IAIOPLFNNBO(NLPLHJLLGBB AMMKGILEHBG, NLPLHJLLGBB GIPKJCPOKBH);

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool GNHENEMEHPG(NLPLHJLLGBB AMMKGILEHBG, NLPLHJLLGBB GIPKJCPOKBH, [Out] NLPLHJLLGBB DAKNKMIEDDC);

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	NLPLHJLLGBB IAHPDNPDAIK(NLPLHJLLGBB[] LFFADIOANKA);

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	NLPLHJLLGBB PCFHMGJBDNC(NLPLHJLLGBB BJCKBJFHLNJ, uint EOPJMLCILKE);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class EIAEIBCJPBA
{
	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x86D61F0", Offset = "0x86D47F0", VA = "0x1886D61F0")]
	public static bool JGJIPHIDAPM(this OJHGNPOOCLL KBGMGHOLOND, NLPLHJLLGBB BJCKBJFHLNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x86D5F60", Offset = "0x86D4560", VA = "0x1886D5F60")]
	public static PDHGKNBOAKO JCFPODMLGAL(this OJHGNPOOCLL IPMDJANACCD, NLPLHJLLGBB BJCKBJFHLNJ, DGLBKLPBPLC ANBGOGICGFD, Allocator EEDCBHBBPKF)
	{
		return default(PDHGKNBOAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x86D5EE0", Offset = "0x86D44E0", VA = "0x1886D5EE0")]
	public static PDHGKNBOAKO IKDFGJPHNFJ(this OJHGNPOOCLL IPMDJANACCD, NLPLHJLLGBB BJCKBJFHLNJ, Allocator EEDCBHBBPKF)
	{
		return default(PDHGKNBOAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x86D6260", Offset = "0x86D4860", VA = "0x1886D6260")]
	public static PDHGKNBOAKO MOCIOACPCKF(this OJHGNPOOCLL IPMDJANACCD, NLPLHJLLGBB BJCKBJFHLNJ, Allocator EEDCBHBBPKF)
	{
		return default(PDHGKNBOAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x86D5F20", Offset = "0x86D4520", VA = "0x1886D5F20")]
	public static PDHGKNBOAKO JAIFJOLNPKP(this OJHGNPOOCLL IPMDJANACCD, NLPLHJLLGBB BJCKBJFHLNJ, Allocator EEDCBHBBPKF)
	{
		return default(PDHGKNBOAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x86D62E0", Offset = "0x86D48E0", VA = "0x1886D62E0")]
	public static PDHGKNBOAKO PGEBDEBNAGM(this OJHGNPOOCLL IPMDJANACCD, NLPLHJLLGBB BJCKBJFHLNJ, Allocator EEDCBHBBPKF)
	{
		return default(PDHGKNBOAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x86D62A0", Offset = "0x86D48A0", VA = "0x1886D62A0")]
	public static PDHGKNBOAKO OLPFCLAGNDA(this OJHGNPOOCLL IPMDJANACCD, NLPLHJLLGBB BJCKBJFHLNJ, Allocator EEDCBHBBPKF)
	{
		return default(PDHGKNBOAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x86D5EA0", Offset = "0x86D44A0", VA = "0x1886D5EA0")]
	public static PDHGKNBOAKO FCMBHKFMDIH(this OJHGNPOOCLL IPMDJANACCD, NLPLHJLLGBB BJCKBJFHLNJ, Allocator EEDCBHBBPKF)
	{
		return default(PDHGKNBOAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x86D5D80", Offset = "0x86D4380", VA = "0x1886D5D80")]
	public static PDHGKNBOAKO FCMBHKFMDIH(this OJHGNPOOCLL IPMDJANACCD, PDHGKNBOAKO BJCKBJFHLNJ, Allocator EEDCBHBBPKF)
	{
		return default(PDHGKNBOAKO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PHAHGEMCGEM
{
	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x86E9220", Offset = "0x86E7820", VA = "0x1886E9220", Slot = "0")]
	Task<OEIKFIGBJCJ> HMIGCBJFFPI(DGKLLKHIJBK BPOFPMJEFHM, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "1")]
	void IHDMKIDBGJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface HJAJILCFGKE
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event NCHPCAADJAG.HABFMOGJOAB MBEKIEIGEAE;

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NLPLHJLLGBB AFGPLCNMJDO(NLPLHJLLGBB PEKDBPKONMC);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<NLPLHJLLGBB> NEBAFACOFAA();

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<NLPLHJLLGBB> MKDBOPAHGDO(NLPLHJLLGBB BEBONNCPGLF);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GGGFBNJMGGA(NLPLHJLLGBB BAGLJMBCEGF, NLPLHJLLGBB ALPMAEMBMJC, [Out] KBHPNNIEMBA GKBFCEIDEIB);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EBFBDOLDIAK(NLPLHJLLGBB BAGLJMBCEGF, NLPLHJLLGBB DODDGLGIEAB, [Out] KBHPNNIEMBA GKBFCEIDEIB);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MNOHGAIAGGD(NLPLHJLLGBB BAGLJMBCEGF);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HCCFICBBONP(NLPLHJLLGBB BKHECBPCIBL, NLPLHJLLGBB JBFCMKMBEEK);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KBHPNNIEMBA BPNLKHEGMMF(NLPLHJLLGBB BJCKBJFHLNJ);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PMPEPOCCAFE
{
	[Cpp2IlInjected.Token(Token = "0x17000204")]
	bool MONGPHLDGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	bool KHMHGMCKHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	bool OIGPMOPHDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IHEHCHKBEAE
{
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CMAOOANIGPA
{
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPKCLDCKEGN(NLPLHJLLGBB BJCKBJFHLNJ, JPCENFLHKDB GBIEIIJCCOO);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMAKBNBIEGP(NLPLHJLLGBB BJCKBJFHLNJ, JPCENFLHKDB GBIEIIJCCOO);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface OHOEFFCOCHD
{
	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KIOIAGMFEML<string> FPIFOGPBINP(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KIOIAGMFEML<string> ECPICGBBOAG(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCDGLNLCFNH(NLPLHJLLGBB BJCKBJFHLNJ, KIOIAGMFEML<string> GFELOCNKDDG);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKEFPNCEIOL(NLPLHJLLGBB BJCKBJFHLNJ, KIOIAGMFEML<string> GFELOCNKDDG);

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JICGEGLPHON(NLPLHJLLGBB NDENDONJBMH, NLPLHJLLGBB IELBLNAFPCJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ACBKFBLFNKE
{
	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JFIFMMJLAJM HAPAPPNELEO(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFGBDIOOBGI(NLPLHJLLGBB IIIJIBCGHEO, JFIFMMJLAJM EKACEANNGBC);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GFFFJALALKM(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CPOMACGNGDJ(NLPLHJLLGBB IIIJIBCGHEO, bool KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KIOIAGMFEML<string> OAJHHBLMDOB(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void POHIGPFBHKM(NLPLHJLLGBB IIIJIBCGHEO, KIOIAGMFEML<string> GFELOCNKDDG);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KIOIAGMFEML<string> PADMEDHLFMH(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PFCEGGABFCO(NLPLHJLLGBB IIIJIBCGHEO, KIOIAGMFEML<string> GFELOCNKDDG);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KIOIAGMFEML<string> PIBLEODLAOH(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JHBMFODKPLA(NLPLHJLLGBB IIIJIBCGHEO, KIOIAGMFEML<string> GFELOCNKDDG);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KIOIAGMFEML<string> KBNCACDOCIG(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ALFFOJGNHDJ(NLPLHJLLGBB IIIJIBCGHEO, KIOIAGMFEML<string> GFELOCNKDDG);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool EGOOMBDOBGM(NLPLHJLLGBB IIIJIBCGHEO, NLPLHJLLGBB AGIMJJDFEAF);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LLMJJJMPAJL
{
	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOCCPAJAFAO([In] float3 BKLMKFANNGB, [In] float3 JPDMHOCEDGB, float AHKHODDOFPB, [Out] KGCCADNMPNL GKONFIPDNED, [Out] NLPLHJLLGBB CDGMNFKFLKC);

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int HFMGFAEBFBF([In] float3 BKLMKFANNGB, float JPNOJNLEGJO, List<NLPLHJLLGBB> LFFADIOANKA);

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int DIFMOBCJOBC(Plane[] AJDFFHMJLPB, float3 BKLMKFANNGB, float3 DDFLKLFFJOH, quaternion LDAEEKEKDJC, List<NLPLHJLLGBB> LFFADIOANKA);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MBAJOGLBJOM
{
	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOCCPAJAFAO([In] NativeArray<Entity> MEJIKACDFLB, [In] float3 BKLMKFANNGB, [In] float3 JPDMHOCEDGB, [In] NativeArray<KGCCADNMPNL> CKMDNPGGBGO);

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> HFMGFAEBFBF([In] NativeArray<Entity> MEJIKACDFLB, [In] float3 BKLMKFANNGB, float JPNOJNLEGJO);

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> DIFMOBCJOBC([In] NativeArray<Entity> MEJIKACDFLB, [In] NativeArray<float4> DBIDICGCOCM);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct HNPHKNNKMJI : EDMHOEDPFHJ, IEquatable<HNPHKNNKMJI>
{
	[Cpp2IlInjected.Token(Token = "0x17000207")]
	public int GKFLGCDAIDH
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000208")]
	public int AMOFDJHKCMK
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x30A0350", Offset = "0x309E950", VA = "0x1830A0350", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x30A0340", Offset = "0x309E940", VA = "0x1830A0340", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x86DB910", Offset = "0x86D9F10", VA = "0x1886DB910", Slot = "8")]
	public bool Equals(HNPHKNNKMJI AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x86DB960", Offset = "0x86D9F60", VA = "0x1886DB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public struct KGCCADNMPNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float PIBKPEPLPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public float3 EPCDDFCHPMD;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CPKHFKLKMKL
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HNBHNOBANOG
{
	[Cpp2IlInjected.Token(Token = "0x17000209")]
	FIMHEFEBFND OJEEGEKNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	NIPCMAEPLKK GJLBLBNFCBI
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	int HFIMGIMHACH
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	int IADLLHPKNOC
	{
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	int AKMHJOKDGIL
	{
		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	int JKPJDGKGALH
	{
		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	int EMIBOPCHOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<PDHGKNBOAKO, NativeArray<RRObjectPrefabData>> ENJBKLAEHMD;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<PDHGKNBOAKO> MPNJDGAMKAA;

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PDHGKNBOAKO NCDHPFGPAEH();

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NBABKBBLJJL DCDEMDKGFNE(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	RRObjectPrefabData FNCGFMGHPPI(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GOHANGDBJBC(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CENLKEFEGPJ CGADCFNHDKB(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool LMANHHGDGKP(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool HOCBOLIHOFD(NLPLHJLLGBB BJCKBJFHLNJ, [Out] Transform CCHLCEHOKAD);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	NLPLHJLLGBB FDENDNFCGCN(NEKBNCKOEOB MLCIEJIIPCN);

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool DPHPKKOIKII(NEKBNCKOEOB MLCIEJIIPCN, [Out] NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	NEKBNCKOEOB PAHDNGBIDGC(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	PDHGKNBOAKO FDENDNFCGCN(NativeArray<NEKBNCKOEOB> MLCIEJIIPCN, Allocator EEDCBHBBPKF, bool OBBGNLHHGCB = true);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool GONOKCNBDCH(NativeArray<NEDHOJEODGC> GABJCKOMPJE, NativeArray<NEKBNCKOEOB> DLPLOLCMMKG, NativeArray<Entity> MJNBGEDPCGH, KIOIAGMFEML<KOCJDBILEDO> HBKILDELNPK);

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CENLKEFEGPJ KADKGJOCJBA();

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "24")]
	CENLKEFEGPJ OIAFGENCPBK(RRObjectPrefabData LBMDJCMFBKL, [Optional] ANOCIKLGHAF NLJPEGOLHLM);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LNGFAPGMGKL FHLMELGLCKL();

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CJNCELCCODB FILAHHFGEAP();

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "27")]
	BIKIDNLDNDH BMAPMFENDIB(PINBFOAJNAG HLPPKMJGBMB);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JCKBOKNACMA(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void LIOBMJIDNHB(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool ADJGNLAGEPI(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "31")]
	PDHGKNBOAKO MDOFLOHODGI(PDHGKNBOAKO COBIDJKNGNN, Allocator EEDCBHBBPKF);

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool CCCINLIBFDH(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool EDNANANHBJI(NLPLHJLLGBB BJCKBJFHLNJ, ComponentTypes DGCBDOMMKIK);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "34")]
	NLPLHJLLGBB BMDGOPGNNFI(Transform CCHLCEHOKAD);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class LLKNAMEMPOO
{
	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x86DFF20", Offset = "0x86DE520", VA = "0x1886DFF20")]
	internal static NLPLHJLLGBB JDJIADAOGNJ(this Entity JAPNANJIKLB, HNBHNOBANOG MIKGDJBNCFJ)
	{
		return default(NLPLHJLLGBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x86E0000", Offset = "0x86DE600", VA = "0x1886E0000")]
	public static CENLKEFEGPJ PAAKPCLLAAD(this HNBHNOBANOG MIKGDJBNCFJ, LocalId BJCKBJFHLNJ)
	{
		return default(CENLKEFEGPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x86DFCC0", Offset = "0x86DE2C0", VA = "0x1886DFCC0")]
	public static NLPLHJLLGBB FDENDNFCGCN(this HNBHNOBANOG MIKGDJBNCFJ, LocalId BJCKBJFHLNJ)
	{
		return default(NLPLHJLLGBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x86E0010", Offset = "0x86DE610", VA = "0x1886E0010")]
	public static NEKBNCKOEOB PAHDNGBIDGC(this HNBHNOBANOG MIKGDJBNCFJ, LocalId BJCKBJFHLNJ)
	{
		return default(NEKBNCKOEOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x86E0080", Offset = "0x86DE680", VA = "0x1886E0080")]
	public static LNGFAPGMGKL PMHAEOFILEG(this HNBHNOBANOG MIKGDJBNCFJ, RigidTransform PDIPPFLBMHH)
	{
		return default(LNGFAPGMGKL);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x86DFB10", Offset = "0x86DE110", VA = "0x1886DFB10")]
	public static BIKIDNLDNDH EBPIJJLEDDE(this HNBHNOBANOG MIKGDJBNCFJ, PINBFOAJNAG FAAACGBLHKP, RigidTransform PDIPPFLBMHH)
	{
		return default(BIKIDNLDNDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x86DFD70", Offset = "0x86DE370", VA = "0x1886DFD70")]
	public static CJNCELCCODB HJFLNAHPBAK(this HNBHNOBANOG MIKGDJBNCFJ, RigidTransform PDIPPFLBMHH)
	{
		return default(CJNCELCCODB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x86DFFD0", Offset = "0x86DE5D0", VA = "0x1886DFFD0")]
	private static void KHEJGLFCNNJ(CENLKEFEGPJ FKEFBEHGFMJ, RigidTransform PDIPPFLBMHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal interface LGCJGIBAKPA
{
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GKHBFHMKFME
{
	[Cpp2IlInjected.Token(Token = "0x17000210")]
	bool GNJLEMOMNDN
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000211")]
	NLPLHJLLGBB OGINBEKJGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000212")]
	CENLKEFEGPJ FIOLNLMIOLN
	{
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event JPOADKOEJBG PFJCMFMNBEL;

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NLPLHJLLGBB IAIOPLFNNBO(NLPLHJLLGBB AMMKGILEHBG, NLPLHJLLGBB GIPKJCPOKBH);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GNHENEMEHPG(NLPLHJLLGBB AMMKGILEHBG, NLPLHJLLGBB GIPKJCPOKBH, [Out] NLPLHJLLGBB DAKNKMIEDDC);

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IFJLGDBMOOD();

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PGFGBCLJFHN();

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ECPLAGNBOAM(NLPLHJLLGBB AMMKGILEHBG);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PPOEGPHDFFK(NLPLHJLLGBB AMMKGILEHBG);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public delegate void JPOADKOEJBG(CENLKEFEGPJ JIKELDLEGIO, CENLKEFEGPJ BAKKALHFACL);
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class GPAHECCFLEE
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x86D91A0", Offset = "0x86D77A0", VA = "0x1886D91A0")]
	public static bool FCONEEGJAGG(this GKHBFHMKFME FIJACDCGIGO, CENLKEFEGPJ AMMKGILEHBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x86D91F0", Offset = "0x86D77F0", VA = "0x1886D91F0")]
	public static bool JLKADIBPILP(this GKHBFHMKFME FIJACDCGIGO, NLPLHJLLGBB AMMKGILEHBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x86D92D0", Offset = "0x86D78D0", VA = "0x1886D92D0")]
	public static bool LHBAENHMCCN(this GKHBFHMKFME FIJACDCGIGO, NLPLHJLLGBB AMMKGILEHBG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IBGFOGGBNCJ
{
	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEBCAJLKLIB(NativeList<RRObjectPrefabData> DJJNAKMCECB);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BFFDFPCIJKG
{
	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BIEJENOIKEP(CENLKEFEGPJ FKEFBEHGFMJ, INIBMAJCADC LJNIMHNLCFF, List<CENLKEFEGPJ> NDPLDEAJBHH);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int DPLIAEALHDG(CENLKEFEGPJ FKEFBEHGFMJ, INIBMAJCADC LJNIMHNLCFF);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ELHOGAIKFKB(CENLKEFEGPJ FKEFBEHGFMJ, List<CENLKEFEGPJ> NDPLDEAJBHH);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CKEBEBFKOFK(CENLKEFEGPJ PCLFJGMAHBI, CENLKEFEGPJ AMMKGILEHBG, INIBMAJCADC LJNIMHNLCFF);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CENLKEFEGPJ OECELNBBHPH(CENLKEFEGPJ PCLFJGMAHBI, int PMIGBJGNLLP, INIBMAJCADC LJNIMHNLCFF);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NEKLFLIBKIF(CENLKEFEGPJ PCLFJGMAHBI, CENLKEFEGPJ AMMKGILEHBG, INIBMAJCADC LJNIMHNLCFF);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NJGLDPBEIEK(CENLKEFEGPJ PCLFJGMAHBI, CENLKEFEGPJ AMMKGILEHBG, INIBMAJCADC LJNIMHNLCFF);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PLGPAEHIDHB(CENLKEFEGPJ PCLFJGMAHBI, INIBMAJCADC LJNIMHNLCFF);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GHLEMBINFPI(CENLKEFEGPJ PCLFJGMAHBI, CENLKEFEGPJ AMMKGILEHBG, INIBMAJCADC LJNIMHNLCFF);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PMCGMDAACJG(Entity PCLFJGMAHBI, Entity AMMKGILEHBG, INIBMAJCADC LJNIMHNLCFF);

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HHAAHEEMCMF(Entity PCLFJGMAHBI, INIBMAJCADC LJNIMHNLCFF);

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KCMCFPDFHLD(CENLKEFEGPJ AMMKGILEHBG, INIBMAJCADC LJNIMHNLCFF);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GIJFGJDKJOB
{
	[Cpp2IlInjected.Token(Token = "0x17000213")]
	EOIOCFFOJPH EEJAKMAMECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLPFDOKAHEM AEAHDKEELBE(EOIOCFFOJPH BLFJNFOGIPN);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EOIOCFFOJPH KJBFLBLLOFL();

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EOIOCFFOJPH MLAEEDELDIC();
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LPKPBMLEPMA
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GBFHFIPLOBB(NLPLHJLLGBB AMMKGILEHBG, [Out] NLPLHJLLGBB HDBEMDGPKDL);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IODFBDKJMNJ
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<NLPLHJLLGBB> KCCJHFKLLLC;

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OHLHNONFFNL(NLPLHJLLGBB OIHEEOJKKOF, bool KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HGJDGDKPJBC(NLPLHJLLGBB OIHEEOJKKOF, bool KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FNKPGOAAAFA(NLPLHJLLGBB OIHEEOJKKOF, int KOPHBHGIACG);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HCLANLDBIPL
{
	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<NLPLHJLLGBB> AAAEHOMGPJI(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NLPLHJLLGBB MMCIICEHPAB(NLPLHJLLGBB BJCKBJFHLNJ, int PMIGBJGNLLP);

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int IMJFKGONBNG(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GKJBALMMHEO IDAANFFBJIO(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MOAPPIFBNCG(NLPLHJLLGBB BJCKBJFHLNJ, GKJBALMMHEO ENMBHGMENHL);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NLPLHJLLGBB LDGBMPODFEN(NLPLHJLLGBB BJCKBJFHLNJ, [Optional] float3? APHHGJIDDCM, [Optional] quaternion? LDAEEKEKDJC, [Optional] float3? EAHAEIJNIMH);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NLPLHJLLGBB JKPAHABJGHJ(NLPLHJLLGBB BJCKBJFHLNJ, int PMIGBJGNLLP, [Optional] float3? APHHGJIDDCM, [Optional] quaternion? LDAEEKEKDJC, [Optional] float3? EAHAEIJNIMH);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FPFPLCALBDH(NLPLHJLLGBB BJCKBJFHLNJ, int PMIGBJGNLLP);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IPKCACEKLML(NLPLHJLLGBB BJCKBJFHLNJ);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HHBBBMLJOIJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BMLFEODEIIG
{
	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCIKNBCOHFD(NLPLHJLLGBB BJCKBJFHLNJ, ReadOnlySpan<TerrainGenerationLayer> FECDEJAMPNN);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDOJIMMEGGO(NLPLHJLLGBB BJCKBJFHLNJ, ReadOnlySpan<OCLIGBIFNLE> FECDEJAMPNN);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ANDDHMDHIDP
{
	[Cpp2IlInjected.Token(Token = "0x17000214")]
	bool DLDEIDDECGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLAHFEHEDPK();

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GFLJIFHAKMF();

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IICDFPIJGJI();

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HLEBLAHJHEH();

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HKHPBMFOPBE();

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OLJCOHFMHIC();

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ELPPMOOEJAD();

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JAPLFPBMJMC();

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AHGPGDJFEOF();

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PDLDCAFKGGL();

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OKNBDLGBJGN();

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MCODKGNBCIO();
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MOMAELGFDAM
{
	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JFJNKKKJCLJ(NLPLHJLLGBB AMMKGILEHBG, [Out] int PCLFJGMAHBI);

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKJJJJFDGNF(NLPLHJLLGBB AMMKGILEHBG, int PCLFJGMAHBI);

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJNKFHIPMPO(NLPLHJLLGBB AMMKGILEHBG, bool FHHAPCHNGEC);

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HLDADJEKKJI(NLPLHJLLGBB AMMKGILEHBG, float IDEEBBOKKCE, float HHAHNLNFEKF, float LFKCLNPAKAB);

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DIIJFNBFHMB(NLPLHJLLGBB BJCKBJFHLNJ, [Out] float HHAHNLNFEKF, [Out] float LFKCLNPAKAB);

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GACCLNLLOOK(NLPLHJLLGBB AMMKGILEHBG, float3 APHHGJIDDCM, quaternion LDAEEKEKDJC);

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool AFMDFBNKKJG(NLPLHJLLGBB AMMKGILEHBG, [Out] float3 APHHGJIDDCM, [Out] quaternion LDAEEKEKDJC);

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CDOJHCIMAKC(NLPLHJLLGBB AMMKGILEHBG);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BLCEJAOLGDJ
{
	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JENHNLBELHK(Entity JAPNANJIKLB, [In] float3 KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 PPAPOMLMMCE(Entity JAPNANJIKLB);

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OODEFOMALPL(Entity JAPNANJIKLB, [In] quaternion KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion DMJEBPFGJBJ(Entity JAPNANJIKLB);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JIBOHDAOEFO(Entity JAPNANJIKLB, [In] float3 APHHGJIDDCM, [In] quaternion LDAEEKEKDJC);

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DCEPBEBACDI(Entity JAPNANJIKLB, [Out] RigidTransform OMEKNHIGCGA);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MIKKFMKIGAB(Entity JAPNANJIKLB, [In] float3 APHHGJIDDCM, [In] quaternion LDAEEKEKDJC);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LPBFMBPPLJD(Entity JAPNANJIKLB, [Out] float3 APHHGJIDDCM, [Out] quaternion LDAEEKEKDJC);

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LPBFMBPPLJD(Entity JAPNANJIKLB, [Out] RigidTransform OMEKNHIGCGA);

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IMLCBDNNDLA(Entity JAPNANJIKLB, float KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float EDAFLCJNBFF(Entity JAPNANJIKLB);

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JPLNDNJIELG(Entity JAPNANJIKLB, [In] float3 KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 EJBIEJDBADJ(Entity JAPNANJIKLB);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EOEKADGOIBC(Entity JAPNANJIKLB, [In] quaternion KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion AEHGAOGOMKA(Entity JAPNANJIKLB);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OBNAGDICMAP(Entity JAPNANJIKLB, float KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float JAJHCKDKLJC(Entity JAPNANJIKLB);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KBJKKEHDGNF(Entity JAPNANJIKLB, [Out] float4x4 PDKLFCKPAOP);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JBPFAHJBLGK(Entity JAPNANJIKLB, [In] float4x4 PDKLFCKPAOP);

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KKHKKFOJIDL(Entity JAPNANJIKLB);

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GAGNHCGJNLC(Entity JAPNANJIKLB, Entity LJNFPGEOOPK, Entity JBFCMKMBEEK);
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public static class HJJKAGBKFEO
{
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FGEEBEOFLCG
{
	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFJOLOIJMJM(bool IOELFDJBDEL);
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IOAHMMMBCHD
{
	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIGOPKLPPII(NLPLHJLLGBB IIIJIBCGHEO, KIOIAGMFEML<string> GFELOCNKDDG);

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JADMNGNOCNM(NLPLHJLLGBB IIIJIBCGHEO, KIOIAGMFEML<string> GFELOCNKDDG);

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CJHOBGDBDBD(NLPLHJLLGBB IIIJIBCGHEO, KIOIAGMFEML<string> GFELOCNKDDG);

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CNHJFCIJFBC(NLPLHJLLGBB IIIJIBCGHEO, KIOIAGMFEML<string> GFELOCNKDDG);

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ICJACPLDCBB(NLPLHJLLGBB IIIJIBCGHEO, KIOIAGMFEML<string> GFELOCNKDDG);

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DAONNCAFFBL(NLPLHJLLGBB IIIJIBCGHEO, KIOIAGMFEML<string> GFELOCNKDDG);

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int DBPILHFFDPK(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int OJHMNJIPLHK(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int GPJHMBDGIOF(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BEHKKOBPFOO<string> GCOOLGOGNBF(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool ADKPJLCOBID(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BEHKKOBPFOO<string> PFLKOIAGHPC(NLPLHJLLGBB IIIJIBCGHEO);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BPMLNFABCLB(NLPLHJLLGBB IIIJIBCGHEO, string PEIEJMGOHLN);

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LCKHOJCNGLN(string PEIEJMGOHLN, BBBGMONOBKI EHLHAMMIEAN);

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NLPLHJLLGBB EHGMEEDECAN(string PEIEJMGOHLN);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CKBOJNGMKOF(string PEIEJMGOHLN, BBBGMONOBKI EHLHAMMIEAN);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FBGLFHMFELB(NLPLHJLLGBB CCCBIFDNPBH, string PEIEJMGOHLN, BBBGMONOBKI EHLHAMMIEAN);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "17")]
	BEHKKOBPFOO<string> LJCOLKKJHAN();
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public static class IDNICBFEKHD
{
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CEPFDGKMFIA
{
	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World IMKCEDIGOND(string KGBLCODINJH = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World JBHJFAAPNEL(string KGBLCODINJH = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World DPLBCALDDNO(string KGBLCODINJH = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World AKKKENHAEPI(string KGBLCODINJH = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EPCIOFAAGGG
{
	[Cpp2IlInjected.Token(Token = "0x17000215")]
	World BECOLCKJKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000216")]
	World CCDMACPIFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000217")]
	EntityManager ACKHPMIHGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	bool NMKMFLCMAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase OABCBFIMDNE(Type GPEIAHGICNA);
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public static class NGMNIIHGDLG
{
	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x86E1C30", Offset = "0x86E0230", VA = "0x1886E1C30")]
	public static ComponentSystemBase OEFAAHGDDCL(this World LGOKMFFDOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x3F46C90", Offset = "0x3F45290", VA = "0x183F46C90")]
	public static T OABCBFIMDNE<T>(this EPCIOFAAGGG NCCOAHFNDOC) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OPDCKKNDHJF
{
	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBNEKMAMIPK(NativeListAsync<Entity> CKJIJFICDOB);

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCAOEOFGAAP(HNMAOCBOPFC DCOBCEOFLNO);

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IENPJDJBBJG(NativeListAsync<Entity> GLPIJIBNKDL, bool FLCLNLNENJL);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MKPGKPKHMCF();

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HBMDHPNHDKI(Entity BOCNDANOLJJ);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface KIDLMHKNMCG
{
	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FPMGFDGJOFH(Collider JKLOHCLNDDL, [Out] AEJMIEKMDCM JGNAJEHKNEE);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EGJJOCNMGDI
{
	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider CGEHGGOMBML(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject HFBNJNKMMIM(NLPLHJLLGBB LMDGEELCGJG, GameObject IKHBLDCGHAN, Vector3 GDEKJEBPHAB, Quaternion JJIKKLJGABK);

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MLCPECBFNOF(GameObject JKLOHCLNDDL);

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider ODCFMOFLNCM<TCollider>(GameObject NAFIBINJFKL) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BABLOLEFIPO(Collider JKLOHCLNDDL);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject LFMDOLLPJGJ<TCollider>(string NDIENANOGEK) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ONKGALPKPBA BGNIDOBNEMJ(NLPLHJLLGBB CMAHJDLOLKI, NLPLHJLLGBB FAHABJKHDAN, PINBFOAJNAG ABFMDMOPGNK, float3 JAGPKMBPLMP, quaternion KBMJPCIJBPL, float3 KAKOAJGKEMH);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KANDIHBKJDF(NLPLHJLLGBB BJCKBJFHLNJ, [Out] ONKGALPKPBA JKLOHCLNDDL);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DKMCIGEGOKF(NLPLHJLLGBB BJCKBJFHLNJ, [Out] NLPLHJLLGBB BOCNDANOLJJ);
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public enum AGPDIGJMNKH
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
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LHFLBCKMPKJ
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public struct GKMANNABCFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int ABFMDMOPGNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GameObject IKHBLDCGHAN;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFHFKEMHMGJ(NLPLHJLLGBB BJCKBJFHLNJ, AEEBNJJBFGH FLDEFDKBNKM, bool ONMNDEDAHEO, HEODPNLMNME KIKPAKAOOBK);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBCBLIEMLCK(NLPLHJLLGBB BJCKBJFHLNJ, AEEBNJJBFGH FLDEFDKBNKM, bool ONMNDEDAHEO, bool DDNHHFLKHGA, bool LALPAMIIEKM);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FJEOIKNPIGF JKAIBAAFOLE(NLPLHJLLGBB BOCNDANOLJJ, List<NLPLHJLLGBB> BKNLJPCJLBF);

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ONKGALPKPBA LHMKALHMELE(GameObject KNHAMFEAKHO, GameObject BJIBGLLJNIO);

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KODNNDDPPGN(GameObject KNHAMFEAKHO, List<GameObject> GIIJGEOJAIK);

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MNGJPBMGOOO(GameObject BJIBGLLJNIO);

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T ODCFMOFLNCM<T>(GameObject NAFIBINJFKL) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BABLOLEFIPO(Collider JKLOHCLNDDL);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject OGEGDIOOMGC<T>(string NDIENANOGEK) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PKJIGOPKLCJ(Collider JKLOHCLNDDL, [Out] NLPLHJLLGBB PCLFJGMAHBI);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GIKGOAKBOJG(NLPLHJLLGBB BJCKBJFHLNJ, [Out] AEJMIEKMDCM JGNAJEHKNEE);

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<AGPDIGJMNKH> GDKDELDAGCI(Allocator EEDCBHBBPKF = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] MCIJKHKLKGF();
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EPGFAFJFPFA
{
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANIDMLCEDFO(NLPLHJLLGBB BJCKBJFHLNJ, NLPLHJLLGBB KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FILMOPDAIOE(NLPLHJLLGBB BJCKBJFHLNJ, NLPLHJLLGBB KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int NNLFPJDEGCP(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NLPLHJLLGBB LFBIIEDDKCD(NLPLHJLLGBB BJCKBJFHLNJ, int PMIGBJGNLLP);

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PDHGKNBOAKO NAGKNLJNHLE(NLPLHJLLGBB BJCKBJFHLNJ, Allocator EEDCBHBBPKF = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EGOBJOBFBPB(NLPLHJLLGBB BJCKBJFHLNJ, object INEEADCBMPK, NLPLHJLLGBB KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NKNOFGKMLLM(NLPLHJLLGBB BJCKBJFHLNJ, object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool IHCCFPPCKDC(NLPLHJLLGBB BJCKBJFHLNJ, [Out] NLPLHJLLGBB KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LHGMDKHHJPL(NLPLHJLLGBB BJCKBJFHLNJ, float3 KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CGLMJDGEKMM(NLPLHJLLGBB BJCKBJFHLNJ, [Out] float3 KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PDEOLJFALIB(NLPLHJLLGBB BJCKBJFHLNJ, float3 KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CKBMGMBPPEA(NLPLHJLLGBB BJCKBJFHLNJ, [Out] float3 KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CDAFENLJOHM(NLPLHJLLGBB BJCKBJFHLNJ, (Quaternion rot, Vector3 moments) FGMFIOKLJLO);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool MIDFPGJLJJD(NLPLHJLLGBB BJCKBJFHLNJ, [Out] quaternion LBDLDEPDKMC, [Out] float3 MNEJIKLOPPH);

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FDGNILHPKKA(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 NIFIGBIBDLA(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 KKKCAJMDIPJ(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KCBPEACMKJG(NLPLHJLLGBB BJCKBJFHLNJ, float3 KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AFDMBIJEIJL(NLPLHJLLGBB BJCKBJFHLNJ, float3 KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float DLFBPDHOKHN(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float DKAEHAFOJBC(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CAOBBELIHND(NLPLHJLLGBB BJCKBJFHLNJ, float KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BGLCEDANNDN(NLPLHJLLGBB BJCKBJFHLNJ, float KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode CIOELNPMFAC(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GLJBIEONBBJ(NLPLHJLLGBB BJCKBJFHLNJ, CollisionDetectionMode KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(Slot = "25")]
	FLIFMIOEKDE JFLCIJEHBDE(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KFDDEAICKNJ(NLPLHJLLGBB BJCKBJFHLNJ, FLIFMIOEKDE KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool BDGMKJBBOJD(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NIBJGEHJIBG(NLPLHJLLGBB BJCKBJFHLNJ, bool KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(Slot = "29")]
	NLPLHJLLGBB NDDIDKGHBKN(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void DJEMLOBFICC(NLPLHJLLGBB BJCKBJFHLNJ, NLPLHJLLGBB KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(Slot = "31")]
	NLPLHJLLGBB AFGPLCNMJDO(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void NMLEEMHPCCP(NLPLHJLLGBB BJCKBJFHLNJ, NLPLHJLLGBB KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	FMEBMDLLDAA MCANKIDCIAP(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void LDBDDPPIFAK(NLPLHJLLGBB BJCKBJFHLNJ, FMEBMDLLDAA ECFMGNDDOAN);

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool OGICIFANAME(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void IBIPPGLCJGL(NLPLHJLLGBB BJCKBJFHLNJ, bool KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool OCLIGNHDDFP(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void AAJMJNFHMBL(NLPLHJLLGBB BJCKBJFHLNJ, bool KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints MKOFFEACCCL(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void BFLODLEDBBM(NLPLHJLLGBB BJCKBJFHLNJ, RigidbodyConstraints KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float PHHPIIBLMEB(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void NJGMMCKLOAC(NLPLHJLLGBB BJCKBJFHLNJ, float KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float POIBDMJJLMO(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void HJPAHOHKBKH(NLPLHJLLGBB BJCKBJFHLNJ, float KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool LKAEBNCMPBI(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void ANLGMBLONHA(NLPLHJLLGBB BJCKBJFHLNJ, bool KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool HAILMPIFBGE(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void FBNKOCCHKLF(NLPLHJLLGBB BJCKBJFHLNJ, bool KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void FFILGMHALEK(NLPLHJLLGBB BJCKBJFHLNJ, int KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(Slot = "50")]
	LDOJJNLFMJG JKHJMNEFJBH(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void DBOOJCKMIGP(NLPLHJLLGBB BJCKBJFHLNJ, LDOJJNLFMJG KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(Slot = "52")]
	KNMODGMCAEJ JFIDILIMIIP(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void GIDEJGLBIGH(NLPLHJLLGBB BJCKBJFHLNJ, KNMODGMCAEJ KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float IEBCJFHPJKJ(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void FJNAHCCGCMA(NLPLHJLLGBB BJCKBJFHLNJ, float KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void BCANBHOPCJE(NLPLHJLLGBB BJCKBJFHLNJ, object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void CCFEKEKNFLH(NLPLHJLLGBB BJCKBJFHLNJ, object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool MDANDOFGMBF(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void FMBDPOBICMH(NLPLHJLLGBB BJCKBJFHLNJ, object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void LJFJKMFOHNH(NLPLHJLLGBB BJCKBJFHLNJ, object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool HJHOGIGFLPP(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool KMNNOOMPIBF(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody NJINMFKEECE(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void OEBNECNONBN(NLPLHJLLGBB BJCKBJFHLNJ, Rigidbody CCIMPGNIBAH);

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void DFONOONJCJH(NLPLHJLLGBB BJCKBJFHLNJ, object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void HCNECMLDKIA(NLPLHJLLGBB BJCKBJFHLNJ, object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool ODKONBFFNLJ(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void DGKKHDGJOEC(NLPLHJLLGBB BJCKBJFHLNJ, float3 EJLBFNGBOJC);

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void NAGKLCGENMI(NLPLHJLLGBB BJCKBJFHLNJ, float3 PCNHEAPIMMO);

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool EHIHCKKAAFC(NLPLHJLLGBB BJCKBJFHLNJ, [Out] float3 EJLBFNGBOJC);

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool CCLAEIGHIPL(NLPLHJLLGBB BJCKBJFHLNJ, [Out] float3 PCNHEAPIMMO);

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool IKOEBPFPHGH(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void JFJIAKECKLI(NLPLHJLLGBB BJCKBJFHLNJ, object INEEADCBMPK, bool KLPLCNHJGCO);

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void PHBNFEAGHPK(NLPLHJLLGBB BJCKBJFHLNJ, bool CCCAPNMOCCB);

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void EMHLIMJICIG(NLPLHJLLGBB BJCKBJFHLNJ);

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool PENINCEPAAJ(NLPLHJLLGBB BJCKBJFHLNJ);
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NIGGHIHCJDB
{
	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JELAIBPNDOL(Entity MBAKOADLEBB);

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HAOMAHJJKEF(Entity MBAKOADLEBB);

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNKBOKNNEGH(Entity MBAKOADLEBB);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GGLAFGKFCFM
{
	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFIPBPKNFPI(NLPLHJLLGBB AMMKGILEHBG, bool HBBMKCLKMEE);
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public delegate void NMECFMEGAJP(BCKENJIJJPM BMMGCMMLFOK);
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public readonly ref struct BCKENJIJJPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly PDHGKNBOAKO EJKPNBACEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly NativeArray<byte> NANNGIHMHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly NativeArray<byte> MKOBLEPGEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly JPCENFLHKDB GBIEIIJCCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly int KCIKHCIMPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly Type OCIIABCKJFO;

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	public PDHGKNBOAKO PPLLNMABIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x57B03F0", Offset = "0x57AE9F0", VA = "0x1857B03F0")]
		get
		{
			return default(PDHGKNBOAKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	public int AOCLJDLKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x86D2150", Offset = "0x86D0750", VA = "0x1886D2150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	public JPCENFLHKDB CLBHDAJPKPC
	{
		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xAC5000", Offset = "0xAC3600", VA = "0x180AC5000")]
		get
		{
			return default(JPCENFLHKDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x86D21A0", Offset = "0x86D07A0", VA = "0x1886D21A0")]
	public BCKENJIJJPM(PDHGKNBOAKO EJKPNBACEMN, NativeArray<byte> NANNGIHMHLM, NativeArray<byte> MKOBLEPGEHO, JPCENFLHKDB GBIEIIJCCOO, int KCIKHCIMPIK, Type OCIIABCKJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x3B58FC0", Offset = "0x3B575C0", VA = "0x183B58FC0")]
	public NativeArray<T> IALNGIMLCKH<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x3B59000", Offset = "0x3B57600", VA = "0x183B59000")]
	public NativeArray<T> JDOFGJHIFFD<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x3B58ED0", Offset = "0x3B574D0", VA = "0x183B58ED0")]
	public (PDHGKNBOAKO, NativeArray<T>, NativeArray<T>) HBAOOBIPNDD<T>() where T : struct
	{
		return default((PDHGKNBOAKO, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x86D2170", Offset = "0x86D0770", VA = "0x1886D2170")]
	public FHOIONDOKFH LOLNPLLPOOA()
	{
		return default(FHOIONDOKFH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface EKCCODBHGMH
{
	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	string MAKCNMFNBIF
	{
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	EKCCODBHGMH EEIBBPAPEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	IEnumerable<EKCCODBHGMH> HKJKHKEFDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface OFMHEFNNBKM
{
	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	EKCCODBHGMH BAHEPIGCLJK
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000220")]
	NativeArray<JPCENFLHKDB> GIKJLOHEEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CDHDJDJNHLF(JPCENFLHKDB GBIEIIJCCOO, [Out] EKCCODBHGMH DIHEIGLHFII);

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCEHDCEOICJ(JPCENFLHKDB GBIEIIJCCOO, NMECFMEGAJP NDINIBMIKJI);

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HKHOCFFLDMG(JPCENFLHKDB GBIEIIJCCOO, NMECFMEGAJP NDINIBMIKJI);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NFKKFHABOFJ
{
	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCEHDCEOICJ(JPCENFLHKDB GBIEIIJCCOO, NMECFMEGAJP NDINIBMIKJI);

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKHOCFFLDMG(JPCENFLHKDB GBIEIIJCCOO, NMECFMEGAJP NDINIBMIKJI);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class OEBJCKCEADK
{
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NKEJFFHGEOP
{
	[Cpp2IlInjected.Token(Token = "0x17000221")]
	bool NDKMEAEHJII
	{
		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000222")]
	LEEDPAIEHOL BJKABNFLNOI
	{
		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GLADABOLHEK(MLPFDOKAHEM MLCIEJIIPCN, bool DCDBCOBHFKC);

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OAKHNBOPPGF(NEKBNCKOEOB MLCIEJIIPCN, JPCENFLHKDB GBIEIIJCCOO);

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNIEAIAPINP(NativeArray<NEKBNCKOEOB> IBEOKBGJLLN);
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class NHEDONEPDII
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public readonly ref struct FHOIONDOKFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly BCKENJIJJPM CDDIADBJAOB;

	[Cpp2IlInjected.Token(Token = "0x17000223")]
	public PDHGKNBOAKO PPLLNMABIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x57B03F0", Offset = "0x57AE9F0", VA = "0x1857B03F0")]
		get
		{
			return default(PDHGKNBOAKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x86D6FE0", Offset = "0x86D55E0", VA = "0x1886D6FE0")]
	public FHOIONDOKFH(BCKENJIJJPM CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x86D6D80", Offset = "0x86D5380", VA = "0x1886D6D80")]
	public PDHGKNBOAKO IALNGIMLCKH()
	{
		return default(PDHGKNBOAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x86D6EB0", Offset = "0x86D54B0", VA = "0x1886D6EB0")]
	public PDHGKNBOAKO JDOFGJHIFFD()
	{
		return default(PDHGKNBOAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x86D6A90", Offset = "0x86D5090", VA = "0x1886D6A90")]
	public (PDHGKNBOAKO, PDHGKNBOAKO, PDHGKNBOAKO) HBAOOBIPNDD()
	{
		return default((PDHGKNBOAKO, PDHGKNBOAKO, PDHGKNBOAKO));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class DKJOBIAKNOL
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public readonly struct LEEDPAIEHOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly NativeBitArray HNFAKDEOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly NativeParallelHashMap<NEKBNCKOEOB, int> LDHMGNGPDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly NativeParallelHashSet<MLPFDOKAHEM> NJAMLEOHFAO;

	[Cpp2IlInjected.Token(Token = "0x17000224")]
	public bool JKMHKDIFEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x86DF900", Offset = "0x86DDF00", VA = "0x1886DF900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000225")]
	public bool NDKMEAEHJII
	{
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x86DF8D0", Offset = "0x86DDED0", VA = "0x1886DF8D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x631A7F0", Offset = "0x6318DF0", VA = "0x18631A7F0")]
	public LEEDPAIEHOL(NativeBitArray HNFAKDEOEKF, NativeParallelHashMap<NEKBNCKOEOB, int> LDHMGNGPDPH, NativeParallelHashSet<MLPFDOKAHEM> NJAMLEOHFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x86DF920", Offset = "0x86DDF20", VA = "0x1886DF920")]
	public bool OAKHNBOPPGF(NEKBNCKOEOB MLCIEJIIPCN, JPCENFLHKDB GBIEIIJCCOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ALJFHENHFCN
{
	[Cpp2IlInjected.Token(Token = "0x17000226")]
	POFMKFJLMNC HPOIAHGNKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface OPLNFCMNMMB
{
	[Cpp2IlInjected.Token(Token = "0x17000227")]
	int NHJDPOJGLIN
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000228")]
	int DMPLLALCLOI
	{
		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OHBHFCFNDFN(NLPLHJLLGBB BJCKBJFHLNJ, MKIABNBOMIK KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HELGAKOMGEN FGGPAOOLICP();

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HELGAKOMGEN NAPEIMAPLHI();
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AJKMEGNPKGN
{
	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADNAAADAJBN(World LGOKMFFDOAO);

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IOFOKMOMIKJ(World LGOKMFFDOAO);

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase DCKIEDKKKNH(World LGOKMFFDOAO);

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DPLFLGGDFBN(World LGOKMFFDOAO);

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AIFNCJAHCEH(World LGOKMFFDOAO);

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CDFIIAPBIJP(World LGOKMFFDOAO);

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NIDJCHOPLJP(World LGOKMFFDOAO);

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> AFNLJHADIPB();
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GDMDBDLOIBN
{
	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CLDMNHMGPFC(NLPLHJLLGBB OIHEEOJKKOF, bool KOPHBHGIACG);
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public readonly struct ALAEPECECDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly IEnumerable<KJEOFIIBDEN> IMIEBDIIGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly IReadOnlyList<GameObject> ILHFOIJCGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly IReadOnlyList<int> KLEMDEEDNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly IReadOnlyList<(NEKBNCKOEOB, NEKBNCKOEOB)> PIICBIJMFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly int PBNGEGPBBOL;
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public struct CCFMACDPGBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public InventionIdData NMILEMOAODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public InventionInstanceIdData NCAGFINAFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public bool ABEBJDJOJKG;

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x86D34E0", Offset = "0x86D1AE0", VA = "0x1886D34E0")]
	public CCFMACDPGBA(long NMILEMOAODL, Guid NCAGFINAFGN, bool ABEBJDJOJKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[ServiceLifetime(Lifetime.Application)]
public interface BOCDBMLPKHD
{
	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OEIKFIGBJCJ PCFOFOPCDEG(DGKLLKHIJBK ILDPPLPIIKF, int FMKCJNDALPC = 0, bool CHHFHDPKOPB = false);

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CDIEDCCGMNO HOHEECKCOFI(DGKLLKHIJBK ILDPPLPIIKF, NLPLHJLLGBB BEBONNCPGLF, [In] UniformTRS HEJIFOCJGFN, FNNCOCNHIBJ FMNPOOEHDAO, [Optional] CCFMACDPGBA PFNEIJJGHMO, bool PLKKNNODIJK = true, bool KCPEJNEDAKG = false, bool CHHFHDPKOPB = false, bool HMGGOPNKKKM = false);

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PNPFCICGFAP ILHIEIEHFOG();

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PNPFCICGFAP NIDPGKOLGDA(PDHGKNBOAKO LFFADIOANKA, [In] UniformTRS BNMOFJCKCJD, [Optional] FNNCOCNHIBJ KLJIMEIGLGA);

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NABKFONFNLB(NLPLHJLLGBB DOGNKENBLJH);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JGFDOKGMAIG(NLPLHJLLGBB DOGNKENBLJH, [Out] Exception MPBIHBFIGPI);

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<NEKBNCKOEOB> PDOPMJHIAEN(NLPLHJLLGBB DOGNKENBLJH, Allocator EEDCBHBBPKF);

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<NEKBNCKOEOB> GENAGPJACAD(NLPLHJLLGBB DOGNKENBLJH, Allocator EEDCBHBBPKF);

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PDHGKNBOAKO FCNBAJOLKEM(NLPLHJLLGBB DOGNKENBLJH, Allocator EEDCBHBBPKF);

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PDHGKNBOAKO NFLGMPMHMKF(NLPLHJLLGBB DOGNKENBLJH, Allocator EEDCBHBBPKF);

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PDHGKNBOAKO HNBFMDEGKHB(NLPLHJLLGBB DOGNKENBLJH, Allocator EEDCBHBBPKF);

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> OPKCDBPDLEM(NLPLHJLLGBB DOGNKENBLJH, Allocator EEDCBHBBPKF);

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JNNOGDFBKPC(NLPLHJLLGBB DOGNKENBLJH);

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int FOCLHJBLLNH(NLPLHJLLGBB DOGNKENBLJH, int LMJBLNOIBOL);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[ServiceLifetime(Lifetime.Application)]
public interface ENEHNEGEIHO
{
	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0xF9D570", Offset = "0xF9BB70", VA = "0x180F9D570", Slot = "0")]
	bool KKCEGINDOMB(object CBIMJBOHKKP, BIEMNAKNEJO LIJBKCOOFMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public static class INNDKCFHCGD
{
	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x86DCFF0", Offset = "0x86DB5F0", VA = "0x1886DCFF0")]
	public static bool KKCEGINDOMB(this ENEHNEGEIHO IPMDJANACCD, object CBIMJBOHKKP, [Out] BIEMNAKNEJO LIJBKCOOFMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public enum PAFBIBAIBCO : byte
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
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface BIEMNAKNEJO
{
	[Cpp2IlInjected.Token(Token = "0x17000229")]
	KDHFFFFPNJA HIKNDMJOAGH
	{
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	NOCCEEEBCMN PBMONNHFCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700022B")]
	bool CLPBAECCPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700022C")]
	bool JNLNHGALGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object KDPNDHNAFLP();

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KNILBBONLFP([Out] NOCCEEEBCMN OIFMJLAHCKJ);

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x1103AE0", Offset = "0x11020E0", VA = "0x181103AE0", Slot = "6")]
	(NOCCEEEBCMN, object) IMIJGOKPMIP()
	{
		return default((NOCCEEEBCMN, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "7")]
	(NEKBNCKOEOB, NOCCEEEBCMN) OBENKANKEOM()
	{
		return default((NEKBNCKOEOB, NOCCEEEBCMN));
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "8")]
	NAOOHNEIFIM<(NEKBNCKOEOB, NOCCEEEBCMN)> IDHEMFMCMOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x1103AE0", Offset = "0x11020E0", VA = "0x181103AE0", Slot = "9")]
	(AHDIOKNFJLF, byte[]) LELIGDHIELC()
	{
		return default((AHDIOKNFJLF, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x1103AE0", Offset = "0x11020E0", VA = "0x181103AE0", Slot = "10")]
	(HGADKIBHGFO, byte[]) GINNDCIMGGP()
	{
		return default((HGADKIBHGFO, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x1103AE0", Offset = "0x11020E0", VA = "0x181103AE0", Slot = "11")]
	T IEEOGNLMJFI<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public static class OAMDGFEIBCJ
{
	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x86E3490", Offset = "0x86E1A90", VA = "0x1886E3490")]
	public static bool DIPBLEDECNE(this BIEMNAKNEJO DONNKKDINIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface GNMPIPLMAAE : NAOOHNEIFIM<MDLDCBLBAPK>
{
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[DefaultMember("Item")]
public interface NAOOHNEIFIM<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700022D")]
	T LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700022E")]
	int AOCLJDLKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public enum KDHFFFFPNJA : byte
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
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public enum AHDIOKNFJLF : uint
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
	SnapshotClear = 1129337683u,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	RequestNetworkTransformInitialization = 1380865097u
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public static class ALJAFMGBLOG
{
	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x86D0340", Offset = "0x86CE940", VA = "0x1886D0340")]
	public static NEKBNCKOEOB FNEDFFNPPLG(this DPNIAKPBFKL CDDIADBJAOB)
	{
		return default(NEKBNCKOEOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x86D0380", Offset = "0x86CE980", VA = "0x1886D0380")]
	public static NEKBNCKOEOB GJEAKBNKGEH([In] this DPNIAKPBFKL CDDIADBJAOB)
	{
		return default(NEKBNCKOEOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x865C850", Offset = "0x865AE50", VA = "0x18865C850")]
	public static NEKBNCKOEOB JKFIIIBBBCB(this DPNIAKPBFKL CDDIADBJAOB)
	{
		return default(NEKBNCKOEOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x865C850", Offset = "0x865AE50", VA = "0x18865C850")]
	public static ViewId KKKNGJMCNHO(this DPNIAKPBFKL CDDIADBJAOB)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x86D0460", Offset = "0x86CEA60", VA = "0x1886D0460")]
	public static FixedString64Bytes IMPDOADIMGC(this MLPFDOKAHEM NMILEMOAODL)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x86D0630", Offset = "0x86CEC30", VA = "0x1886D0630")]
	public static FixedString64Bytes PDPGENDODBO(this NEKBNCKOEOB NMILEMOAODL)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x86D03D0", Offset = "0x86CE9D0", VA = "0x1886D03D0")]
	public static FixedString32Bytes IMPDOADIMGC(this Entity JAPNANJIKLB)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AEFLFEMMIFM : FODJOCBDILC
{
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public enum MAMFNMJNDPF
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	End,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EBIHMMJKLCA
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<object> PPACDNHKFIH;

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "2")]
	void JDLKLNMELHM(object CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "3")]
	void MCCHEJOPCEI(HGADKIBHGFO NGOJMGCIOHB, ReadOnlySpan<byte> JFAOAIPNPMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
	void KHAKDGLAOMA(AHDIOKNFJLF GPEIAHGICNA, ReadOnlySpan<byte> JFAOAIPNPMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GDADOKNKIJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HGADKIBHGFO HGJOAGOMOAF(ReadOnlySpan<byte> JFAOAIPNPMB);
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HCIHEAHFDKB
{
	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFFLGCJPCMC(HGADKIBHGFO HAELBKGFDIJ, ReadOnlySpan<byte> JFAOAIPNPMB);

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEKIOKBMMDP(ReadOnlySpan<HGADKIBHGFO> DJFFHBMKOAI);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public struct OIMOMJIGKBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public HGADKIBHGFO NGOJMGCIOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public ReadOnlyMemory<byte> JFAOAIPNPMB;
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public struct HGADKIBHGFO
{
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public static HGADKIBHGFO BBAPLJMICDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public MLPFDOKAHEM HDJBBJKIGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public int IMIMJGJNBEA;

	[Cpp2IlInjected.Token(Token = "0x1700022F")]
	public static MLPFDOKAHEM HLBICCNMLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x86DA080", Offset = "0x86D8680", VA = "0x1886DA080")]
		get
		{
			return default(MLPFDOKAHEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x57AF700", Offset = "0x57ADD00", VA = "0x1857AF700")]
	public HGADKIBHGFO(MLPFDOKAHEM HDJBBJKIGDL, int IMIMJGJNBEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x86DA240", Offset = "0x86D8840", VA = "0x1886DA240")]
	public static bool MGLHCKHANFO([In] HGADKIBHGFO BNPLNGPMIIG, [In] HGADKIBHGFO DIIGMDFDOAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x86DA0D0", Offset = "0x86D86D0", VA = "0x1886DA0D0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x86DA1D0", Offset = "0x86D87D0", VA = "0x1886DA1D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x86DA2D0", Offset = "0x86D88D0", VA = "0x1886DA2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x86DA230", Offset = "0x86D8830", VA = "0x1886DA230")]
	public void HEAGIBMIAPN([Out] MLPFDOKAHEM NCJELIFCHMF, [Out] int IMIMJGJNBEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public static class MDIAHOBMBFN
{
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public struct KJEOFIIBDEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public Guid JJCLDINKIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public string CDCAHPOCPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public Vector3 APHHGJIDDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public Quaternion LDAEEKEKDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public Vector3 EAHAEIJNIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public int ALBFFHFNEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public ANOCIKLGHAF ENMBHGMENHL;

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x86DEB90", Offset = "0x86DD190", VA = "0x1886DEB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public enum DPNIJLFKFEH
{
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public static class NGFKCNAFKKI
{
	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x86E1B20", Offset = "0x86E0120", VA = "0x1886E1B20")]
	public static bool KANINNALIJK(this DPNIJLFKFEH GPEIAHGICNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x86E1B00", Offset = "0x86E0100", VA = "0x1886E1B00")]
	public static bool AHCKBDAHPMO(this DPNIJLFKFEH GPEIAHGICNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x86E1B10", Offset = "0x86E0110", VA = "0x1886E1B10")]
	public static bool EKOEOOLGFLC(this DPNIJLFKFEH GPEIAHGICNA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[Flags]
public enum OFDOGGCOJIK
{
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public interface FNNCOCNHIBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELKGDOAOKLK([In] Guid PPEFJKBNOEP, [Out] Guid DNPKCGAKHLK);
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
[Flags]
public enum HMJGNMELMEG
{
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public interface PNPFCICGFAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000230")]
	HLLJOMFNLML GJPDEENAMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString AGBNOICMNJK();
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public enum NDCINKLFBFH
{
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct LABGNAGBAGG : ISystemStateComponentData, IComponentData, IEquatable<LABGNAGBAGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public float3 FFDMBCJMMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public float3 PDJAPHNEKLL;

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x86DECB0", Offset = "0x86DD2B0", VA = "0x1886DECB0", Slot = "4")]
	public bool Equals(LABGNAGBAGG AAGCKLPFJME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IEGDCHKOMEL
{
	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<NLPLHJLLGBB> MGIKICGHGDK(NLPLHJLLGBB LMKHOCAFFFE);

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KNALPOBGNCJ(NLPLHJLLGBB HBIEBKKOEGI, [Out] NLPLHJLLGBB EKBDNCNMFNL);
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HFMJKEAJMKL
{
	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EAPOEKAKPFH(long BGLPCAMMGKF);

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNMJDOOMHHN(NativeParallelHashSet<long> HELHNAFPFLG);

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OCPJKGCOBIN(World LGOKMFFDOAO, NativeParallelHashMap<Guid, long> OEOGOKGCNDD);

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IGDKBIMEOJM(NEKBNCKOEOB MLCIEJIIPCN);

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GHDDDDCFMCJ(NEKBNCKOEOB MLCIEJIIPCN, [Out] Guid LKIEDPABAGB, [Out] long BGLPCAMMGKF);

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PLAFEHECKLH(NEKBNCKOEOB MLCIEJIIPCN, Guid LKIEDPABAGB, long BGLPCAMMGKF);

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LBPNLIJNJGB(Guid LKIEDPABAGB);

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FMHKOKKIIPL(Guid LKIEDPABAGB, [Out] int GCNJPHEDKOI, [Out] int JHLKPELHMGI);

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IMKJINMLNLG(Guid LKIEDPABAGB, int GCNJPHEDKOI, int JHLKPELHMGI);

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CADBMIENCNO(Guid LKIEDPABAGB);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000107")]
public class IDEENHLMJMC
{
	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public IDEENHLMJMC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
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
