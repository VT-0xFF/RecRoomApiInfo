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
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8567100", Offset = "0x8565F00", VA = "0x188567100", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NIJNIEANOHP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x85690E0", Offset = "0x8567EE0", VA = "0x1885690E0")]
	public static void NBFEHBBICFP(this Rigidbody PEIADFDMPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8569260", Offset = "0x8568060", VA = "0x188569260")]
	public static void NBFEHBBICFP(this Rigidbody PEIADFDMPPN, Vector3 EDHOKEMECNG, Quaternion BCOBPHBPFNE, Vector3 KINEMNILOKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct INGCKODPEPI : IReadOnlyList<CLPADLABDGI>, IEnumerable<CLPADLABDGI>, IEnumerable, IReadOnlyCollection<CLPADLABDGI>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct CIDBMLFFKOM : IEnumerator<CLPADLABDGI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly NKPGLIPFHAL HNCOOFAGEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator IFLDEFEGGME;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public CLPADLABDGI BONNGALDEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8556830", Offset = "0x8555630", VA = "0x188556830", Slot = "4")]
			get
			{
				return default(CLPADLABDGI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x85567E0", Offset = "0x85555E0", VA = "0x1885567E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x566BA30", Offset = "0x566A830", VA = "0x18566BA30")]
		public CIDBMLFFKOM(NKPGLIPFHAL HNCOOFAGEMC, NativeArray<LocalId>.Enumerator IFLDEFEGGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8556720", Offset = "0x8555520", VA = "0x188556720", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8556760", Offset = "0x8555560", VA = "0x188556760", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85567A0", Offset = "0x85555A0", VA = "0x1885567A0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NECKCGPIEFK MJIBDELKIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> GLBGOGEKNFA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CLPADLABDGI ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8560790", Offset = "0x855F590", VA = "0x188560790", Slot = "4")]
		get
		{
			return default(CLPADLABDGI);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x855FB80", Offset = "0x855E980", VA = "0x18855FB80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int FIAGGLNGPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NKPGLIPFHAL HHDKFMGHBPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x855FDD0", Offset = "0x855EBD0", VA = "0x18855FDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PJDGOCCOECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BHENCPOLICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x855FE20", Offset = "0x855EC20", VA = "0x18855FE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> JGBCFILNKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2CE46E0", Offset = "0x2CE34E0", VA = "0x182CE46E0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> IDGGMGOOOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x855FEA0", Offset = "0x855ECA0", VA = "0x18855FEA0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x85604B0", Offset = "0x855F2B0", VA = "0x1885604B0")]
	public INGCKODPEPI(int FIBLEJKLMBM, NKPGLIPFHAL HNCOOFAGEMC, Allocator GIEDOJCOPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x85605D0", Offset = "0x855F3D0", VA = "0x1885605D0")]
	public INGCKODPEPI(NECKCGPIEFK MJIBDELKIML, NativeArray<LocalId> GLBGOGEKNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8560560", Offset = "0x855F360", VA = "0x188560560")]
	public INGCKODPEPI(NECKCGPIEFK MJIBDELKIML, NativeArray<Entity> GLBGOGEKNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x85605E0", Offset = "0x855F3E0", VA = "0x1885605E0")]
	internal INGCKODPEPI(NKPGLIPFHAL HNCOOFAGEMC, NativeArray<Entity> ALJPELHALEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8560720", Offset = "0x855F520", VA = "0x188560720")]
	internal INGCKODPEPI(NKPGLIPFHAL HNCOOFAGEMC, NativeArray<LocalId> GLBGOGEKNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8560400", Offset = "0x855F200", VA = "0x188560400")]
	public INGCKODPEPI(NKPGLIPFHAL HNCOOFAGEMC, int MCJGICKIGFF, Allocator GIEDOJCOPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8560670", Offset = "0x855F470", VA = "0x188560670")]
	public INGCKODPEPI(INGCKODPEPI FDPMLLCIFHH, Allocator GIEDOJCOPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x85600B0", Offset = "0x855EEB0", VA = "0x1885600B0")]
	public void PHBHCKKHAEI(List<CLPADLABDGI> NGGCNGNMEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x855FF00", Offset = "0x855ED00", VA = "0x18855FF00")]
	public void OBAEMKHPDKB(int JJJJBEGKNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x855FBE0", Offset = "0x855E9E0", VA = "0x18855FBE0")]
	public INGCKODPEPI BKCDCCJFPOM(Allocator GIEDOJCOPKP)
	{
		return default(INGCKODPEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x855FC80", Offset = "0x855EA80", VA = "0x18855FC80")]
	public Span<CLPADLABDGI> CBIKLFIADBI()
	{
		return default(Span<CLPADLABDGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8560010", Offset = "0x855EE10", VA = "0x188560010")]
	public INGCKODPEPI PALHDBKJEDE(int NBLNCONJINM, int MCJGICKIGFF)
	{
		return default(INGCKODPEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x855FE60", Offset = "0x855EC60", VA = "0x18855FE60", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x855FF50", Offset = "0x855ED50", VA = "0x18855FF50")]
	public CIDBMLFFKOM OLGNAIIDMLF()
	{
		return default(CIDBMLFFKOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8560320", Offset = "0x855F120", VA = "0x188560320", Slot = "6")]
	private IEnumerator<CLPADLABDGI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8560390", Offset = "0x855F190", VA = "0x188560390", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GCIKKNGHODH
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3CF45C0", Offset = "0x3CF33C0", VA = "0x183CF45C0")]
	public static AICGKLKDKDK<T> FKFHIHLAGGB<T>(this INGCKODPEPI HNLFFLNNKGK) where T : Component
	{
		return default(AICGKLKDKDK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct GJPCKAHFHBB : IList<CLPADLABDGI>, ICollection<CLPADLABDGI>, IEnumerable<CLPADLABDGI>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct NLMGCBCJBNI : IEnumerator<CLPADLABDGI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly NKPGLIPFHAL HNCOOFAGEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator IFLDEFEGGME;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CLPADLABDGI BONNGALDEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8569C20", Offset = "0x8568A20", VA = "0x188569C20", Slot = "4")]
			get
			{
				return default(CLPADLABDGI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8569BD0", Offset = "0x85689D0", VA = "0x188569BD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x566BA30", Offset = "0x566A830", VA = "0x18566BA30")]
		public NLMGCBCJBNI(NKPGLIPFHAL HNCOOFAGEMC, NativeArray<LocalId>.Enumerator IFLDEFEGGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8569B10", Offset = "0x8568910", VA = "0x188569B10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8569B50", Offset = "0x8568950", VA = "0x188569B50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8569B90", Offset = "0x8568990", VA = "0x188569B90", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NKPGLIPFHAL HNCOOFAGEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> GLBGOGEKNFA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public CLPADLABDGI ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x855F030", Offset = "0x855DE30", VA = "0x18855F030", Slot = "4")]
		get
		{
			return default(CLPADLABDGI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x855F120", Offset = "0x855DF20", VA = "0x18855F120", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x855EA30", Offset = "0x855D830", VA = "0x18855EA30", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PJDGOCCOECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x855EA30", Offset = "0x855D830", VA = "0x18855EA30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> JGBCFILNKBH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2CE46E0", Offset = "0x2CE34E0", VA = "0x182CE46E0")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool MCPDIAGDFHA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x855EF20", Offset = "0x855DD20", VA = "0x18855EF20")]
	public GJPCKAHFHBB(NKPGLIPFHAL HNCOOFAGEMC, Allocator GIEDOJCOPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x855EFA0", Offset = "0x855DDA0", VA = "0x18855EFA0")]
	public GJPCKAHFHBB(NKPGLIPFHAL HNCOOFAGEMC, int MCJGICKIGFF, Allocator GIEDOJCOPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x855E920", Offset = "0x855D720", VA = "0x18855E920")]
	public INGCKODPEPI FJHGHEHHMMJ()
	{
		return default(INGCKODPEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x855E640", Offset = "0x855D440", VA = "0x18855E640", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x855E680", Offset = "0x855D480", VA = "0x18855E680", Slot = "13")]
	public bool Contains(CLPADLABDGI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x855E710", Offset = "0x855D510", VA = "0x18855E710", Slot = "14")]
	public void CopyTo(CLPADLABDGI[] ELLFIONNNHC, int JIAHMCCMBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x855E5C0", Offset = "0x855D3C0", VA = "0x18855E5C0", Slot = "11")]
	public void Add(CLPADLABDGI IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x855EB00", Offset = "0x855D900", VA = "0x18855EB00", Slot = "7")]
	public void Insert(int JJJJBEGKNIN, CLPADLABDGI IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x855EC90", Offset = "0x855DA90", VA = "0x18855EC90", Slot = "15")]
	public bool Remove(CLPADLABDGI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x855EA70", Offset = "0x855D870", VA = "0x18855EA70", Slot = "6")]
	public int IndexOf(CLPADLABDGI IIHDHELGAFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x855EC40", Offset = "0x855DA40", VA = "0x18855EC40", Slot = "8")]
	public void RemoveAt(int JJJJBEGKNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x855E8E0", Offset = "0x855D6E0", VA = "0x18855E8E0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x855EBB0", Offset = "0x855D9B0", VA = "0x18855EBB0")]
	public NLMGCBCJBNI OLGNAIIDMLF()
	{
		return default(NLMGCBCJBNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x855ED60", Offset = "0x855DB60", VA = "0x18855ED60", Slot = "16")]
	private IEnumerator<CLPADLABDGI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x855EE40", Offset = "0x855DC40", VA = "0x18855EE40", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BBGNGBEFDNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CLPADLABDGI FEGMOCEGDME(CLPADLABDGI GLBGOGEKNFA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CICHIJFDPCB : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface EAPCEAKOHMI : BGHGHKNNHPF, FCPFAFNBCNH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	PCPEGLMDJKJ PFACFEEGJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NECKCGPIEFK BNNMENJDFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface FCPFAFNBCNH
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool PBCFLHHCNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface KJPJGELKLED
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPKHGNCDNOF(bool HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FMJEOCFJDAJ();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface KJBKHCFDLBO
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool GPEIDAGPFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool KBAMMCDIHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool OEABMBCFNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool OGKPLBNHKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool OMPBBPBJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PEJHBKFECPK(bool GDNKPNFMPCI);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EDDOHFEMGMH(ByteString HKIEOKEEIDN);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OMHEENHOHNP();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GGAEEBHAHIC();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AKCEKOEOJGA();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface AEBDOBPMKGB
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	CKKEMANKHME PFACFEEGJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	LGMDEBLHPKM IKAIDOMANEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	LKKHMFBGCNA JNFBBJKLPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	EAPCEAKOHMI DFLCCJOJLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	KGPDANKDLON OJMKODOANNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	KJBKHCFDLBO LGNKFLLPIGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	BCICJPBDLAP PKJDKHCGBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	JPCLMBMGCGI ADJOMIOEOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	LAMALDPDKJM OEFPHBPHNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IBKCEPLCLAA FMDMLHKGGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	KHEMHDJNPEK GHAJICMEFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	AJOLJDIPOCE LAMLEEBMKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	NKPGLIPFHAL HHDKFMGHBPL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	AAKDKOPGDEE LAFDDNAKMAB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	HDEGCCCIJEC IDHFMEEAEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	LFJBEPBFBKH ICONMGOALGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	PNMGPEBBHJA EBBBFCGAODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	MOEODADCOFA OOFELJMMFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	KOMIMDAFOBH EJNBAEMABNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	EEFDHMPHFNO JLGACCKGNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HMLLHLOFAJO BJAPLPEFGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	JNHHJNEBHNH CHEDMDGKAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NNGNDBHBHPF EDAKPGGBKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	JNILILPCAIE NFLLKGPJGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	GCOIBHFPMCG DGEPLBBKKIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	FPLHLBNANAN EMJPACHFDJH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	OFBGLLOADOH OBJAJMJADIG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	LMNDMENDAKD KMPLMGBFLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	PJHCHAJNNMM PDJCOJNNDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CDEAGHECHAO IANILJPKOME
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	BHJOFIIBIEN HMNLMBFOMBL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IJIJHKDIMIJ FDDNDPHMAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GOABGEOLIHB NAPIBLFAGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	IGILKFLNECH NKMMEKKNHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	JGPAKENGFEL CDMDMEOHLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	EBFHPNDODNJ AMALOGOLFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	MCGPNAIJHKG DCHBCKJBNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	JCLBIPBLLFA IMFJPOKOEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	FLDMBGKELJF JPGOKEMNLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	KEPJLIAIPGC DOFMJAOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerTypeProxy(typeof(IGJCCHGGNJK))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct CLPADLABDGI : IComparable<CLPADLABDGI>, IEquatable<CLPADLABDGI>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly CLPADLABDGI EBFKLKOBJOD;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int LNDIPLGPLKM = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int HBMBMHMEPMK = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int PGEGMBNAHKA = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int BEMJLGBBAPC = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId DPODDKLLKHL;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public NKPGLIPFHAL HHDKFMGHBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8554120", Offset = "0x8552F20", VA = "0x188554120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EAPCEAKOHMI DFLCCJOJLLD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8556F10", Offset = "0x8555D10", VA = "0x188556F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public LocalId KBHMCAAJFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8556E80", Offset = "0x8555C80", VA = "0x188556E80")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal NECKCGPIEFK BNNMENJDFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x85573B0", Offset = "0x85561B0", VA = "0x1885573B0")]
		get
		{
			return default(NECKCGPIEFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool LHCDGKCPPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85573C0", Offset = "0x85561C0", VA = "0x1885573C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private bool NNAPNCKBIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8556EC0", Offset = "0x8555CC0", VA = "0x188556EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x85576A0", Offset = "0x85564A0", VA = "0x1885576A0")]
	public CLPADLABDGI(NKPGLIPFHAL AIKGFEGJMPG, LocalId DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8557610", Offset = "0x8556410", VA = "0x188557610")]
	public CLPADLABDGI(NECKCGPIEFK MJIBDELKIML, LocalId DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
	public PLCNDJEJBLF PHIKENNNBLD()
	{
		return default(PLCNDJEJBLF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8557330", Offset = "0x8556130", VA = "0x188557330")]
	public static LocalId MIDAFINGFAP(CLPADLABDGI JMPILGKOBGP)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8557370", Offset = "0x8556170", VA = "0x188557370")]
	public static Entity MIDAFINGFAP(CLPADLABDGI JMPILGKOBGP)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8557210", Offset = "0x8556010", VA = "0x188557210")]
	public static bool IKIADGFKNFC(CLPADLABDGI GENJGFGGINA, CLPADLABDGI KMNEIBIPMKI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x85571F0", Offset = "0x8555FF0", VA = "0x1885571F0")]
	public static bool GFAFFKCBFKA(CLPADLABDGI GENJGFGGINA, CLPADLABDGI KMNEIBIPMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x85574E0", Offset = "0x85562E0", VA = "0x1885574E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8557060", Offset = "0x8555E60", VA = "0x188557060", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8556F70", Offset = "0x8555D70", VA = "0x188556F70", Slot = "4")]
	public int CompareTo(CLPADLABDGI FGAEAFBDBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "5")]
	public bool Equals(CLPADLABDGI FGAEAFBDBPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EFHBBDABGGO
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x855B010", Offset = "0x8559E10", VA = "0x18855B010")]
	public static NEOKJNLGPDM BNBOJNJGCNL(this CLPADLABDGI ALGAKMGCCLO)
	{
		return default(NEOKJNLGPDM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class IGJCCHGGNJK
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct NECKCGPIEFK : IEquatable<NECKCGPIEFK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte MJIBDELKIML;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] KELIIEBDMOM;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static NKPGLIPFHAL MLIDKLIIBKB;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static EAPCEAKOHMI MNPNCCJNMPL;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static NKPGLIPFHAL[] NHBPLCGEIJF;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static EAPCEAKOHMI[] OAJAJHLJGLM;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> AMJEECJAGAP;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public EAPCEAKOHMI DFLCCJOJLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8568270", Offset = "0x8567070", VA = "0x188568270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public NKPGLIPFHAL PNIONCIJCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8568690", Offset = "0x8567490", VA = "0x188568690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8568F80", Offset = "0x8567D80", VA = "0x188568F80")]
	static NECKCGPIEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2D58AB0", Offset = "0x2D578B0", VA = "0x182D58AB0")]
	internal NECKCGPIEFK(byte HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x73A44A0", Offset = "0x73A32A0", VA = "0x1873A44A0", Slot = "4")]
	public bool Equals(NECKCGPIEFK FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8568350", Offset = "0x8567150", VA = "0x188568350", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x109E800", Offset = "0x109D600", VA = "0x18109E800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8568EC0", Offset = "0x8567CC0", VA = "0x188568EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x85681C0", Offset = "0x8566FC0", VA = "0x1885681C0")]
	private static NKPGLIPFHAL AIJIGECGDPA(byte MJIBDELKIML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8568120", Offset = "0x8566F20", VA = "0x188568120")]
	private static EAPCEAKOHMI ADEJKABPLKI(byte MJIBDELKIML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8568770", Offset = "0x8567570", VA = "0x188568770")]
	private static object FLDNIPCKJOD(byte MJIBDELKIML, object[] OOFDDMCKJPA, object PGFMONBPOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x85688D0", Offset = "0x85676D0", VA = "0x1885688D0")]
	private static int GDKGLLEKLDO(byte MJIBDELKIML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8568260", Offset = "0x8567060", VA = "0x188568260")]
	private static int APLNMIJLNML(byte MJIBDELKIML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8568E40", Offset = "0x8567C40", VA = "0x188568E40")]
	private static (int, int) OBKECIJLAMN(byte MJIBDELKIML)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x85688E0", Offset = "0x85676E0", VA = "0x1885688E0")]
	private static byte HKFOBILDMOE(int HNEGIKALKJG, int JJJJBEGKNIN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x85683F0", Offset = "0x85671F0", VA = "0x1885683F0")]
	internal static NECKCGPIEFK FAIIODDINIJ(EAPCEAKOHMI OJHLMPGNBJN, NKPGLIPFHAL BFBCMNKJIFH)
	{
		return default(NECKCGPIEFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x85688F0", Offset = "0x85676F0", VA = "0x1885688F0")]
	internal static void IIOINIJEMOP(NECKCGPIEFK MJIBDELKIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8568AE0", Offset = "0x85678E0", VA = "0x188568AE0")]
	private static void MKGNNBLOBAK(int FIBLEJKLMBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum POHNGBOFPDD
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
public interface GIOIAAPFLFL
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool HKONKGBAPAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool IKOPKKPDAMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool MJPLPFFKIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool CHGCGGFODHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool NIAGOIBDNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DGDFGGIHDHN
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBMPFKKDKMO(GPCIMDKDIKG HPOMHCIJOHD, int JJJJBEGKNIN);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AOENEGOIFBG(GPCIMDKDIKG HEOMLLMKLNJ, int JJJJBEGKNIN);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KPIDCPLNJEG(PGJGHOMCGCB ABBKDPPIEEB, int JJJJBEGKNIN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OBBLCEENHKH : GPCIMDKDIKG, GIOIAAPFLFL
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	int CHBBEHPCBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFILMCJMFOC(LNNMHHBEMJG ADPIMLAGACM, int JJJJBEGKNIN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GPCIMDKDIKG : GIOIAAPFLFL
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum CHDCKLMDKJA
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
	bool AHEJDPGOJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool DDGBGANDEHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool NMILOHKPNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface LNNMHHBEMJG
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool JJKPAIHDLIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	OJDJBNOCNOE KLLPKHBOCCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	EMBGAMKNBIL LOMADPKECJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float3 FEDKKAIHHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	quaternion NFKDICNPCDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float3 JLNAGFEDOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	NGKACLCIMKM FJEHDIIFJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	KDHLIEEPAHG MDANDEECNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float COJIMGECPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	float3 FFCDFGOHDFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	float GGDDNAGFCHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	HACLILBGPLE LJIBBLJOMOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KFIAIBJOJKI
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	float3 FEDOCAEMCFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	float3 FFPBKDOGKLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion JBHEMIDMOKI(float3 NKDFCLLCBEE);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface EMBGAMKNBIL
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool ELNOMNBHNEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool ODKBFDHHBOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool MMAFJLPBMDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float NHMOGDAJDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	int LHMNAJNKKII
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	int EKBBILMCNJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MFEDPFDBHDJ(KFIAIBJOJKI ADPIMLAGACM, int JJJJBEGKNIN);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.OMRoom)]
public class DDNGCBLACLE
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public DDNGCBLACLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface IAIEBCNMGDK
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Guid BCBIFKAFADF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FBCCFKGGGFO(Guid EPOGDNMGDKN, Guid NKENCNIEFON, Guid LLFEFFMJAHJ);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task OCHGHLGBLNO(Guid EPOGDNMGDKN, Guid[] ELPALPOGNID, Guid LLFEFFMJAHJ);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid ELLICBPFKFA(Guid CPLLEEFPGDP);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task ILMANIIEAMM(CLPADLABDGI KPLNGLJBFLL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JJBPFPNCHJJ(Guid CPLLEEFPGDP);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ECFCHNHNAAD(HPEPADPHLPE EJOCGDMOJAG, Guid DPKLMGKEDHA);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OADFFFBFOLG(Guid CPLLEEFPGDP, bool GDNKPNFMPCI);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ACLFLNAMENF(Guid CPLLEEFPGDP, NEOKJNLGPDM PABICHFPNEB);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ODDNJPNOHLJ(NEOKJNLGPDM PABICHFPNEB);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DONHHNDFOMH(CLPADLABDGI DPODDKLLKHL);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface EBHJCGEOKAB
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface ONHPHHOADJC
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "0")]
	void MPIGNOAAAFK(bool BNIEEGBIIHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface LGMDEBLHPKM
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	ONHPHHOADJC IKFOIAHNNFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	DJHDPDJDJJA KNLJEMFBBLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	EFBEODDJGJC KCJKLMHOEHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	MNOGIMNBLBE EBBPHIJGMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	DMAJLKBEGOM ABPBMHDJGLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	DJJPHGBIMBN KFIHPJABDKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	GGKNOCGGMGF HCBIMDCPGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	NNDBKKMJNOH NBFGKHCGFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface DJHDPDJDJJA
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	string OGLKGOFNHNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface BDLMLFGLAOL
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHOCDGALAGN(Action IJBAPONMLAP, bool BDFDDPGEDHE);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IOHJKJDDEOD(string PFLDDMDPCBI);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GHACNNDHHFO(string PFLDDMDPCBI, int PGFMONBPOJI);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OCCHFCJCNIC([Out] bool HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BLLKLFDBGDI([Out] bool HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PKNCJDOHLJM([Out] int HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DCLPKIDAKJH([Out] bool HGMAIPELJHM);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface EFBEODDJGJC
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "0")]
	void OKLLHMPMAIF(bool GDNKPNFMPCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface MNOGIMNBLBE
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid MHDKIMAMAGH;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid CJOIACNNDEH;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid ALJGIKBMAMJ;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid GHFGGKNLAEK;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool HPKDEOKHJLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool FJIFGGCFCIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool HCGDCDAHCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool FPELCLCJKME
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8567F70", Offset = "0x8566D70", VA = "0x188567F70", Slot = "4")]
	string[] NHDMFKNBBCN(IHELAIDILBO AAADMOPBEBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DJMOHJHCCMN();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8567F40", Offset = "0x8566D40", VA = "0x188567F40", Slot = "6")]
	Guid MIHMNMDHAKL(Guid LBHGKPMNMGO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int EKNMBCPJKPO(IHELAIDILBO AAADMOPBEBN);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OGALEAHHJHJ(IHELAIDILBO AAADMOPBEBN, NativeArray<ONJEDAIHEGA> AIDIOKBAIKJ, NativeList<UniformTRS> BPINMCEJOGE);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int BKEOOFPFIPG(Guid NMEMPCKPCOG);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KJLNGHMMMLK(string MLPOJPAGPBH, [Out] Guid NMEMPCKPCOG);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string KODJFKNEJOB(Guid NMEMPCKPCOG);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KNDPLIKCNBM(RRObjectPrefabData FIHEEGMDEJB, [Out] LocalId DJHHEAHBFFL);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AICGKLKDKDK<byte[]> AIHDAMMMFJO(NativeArray<ONJEDAIHEGA> BDALIDLKMJI);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DPEKPMKPAEB(byte[] PMPKBAGCEBF);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GameObject HKCBANHGKFL(string MLPOJPAGPBH);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IAMOLMCLKGP(Transform DNNOOFELIOA, RRObjectPrefabData FMICEEJGKGA, LDEHODDHNKL KKBNGKDBMPF);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool KNAFMAJFIPK(IHELAIDILBO AAADMOPBEBN, NativeParallelHashMap<Guid, LocalId> GECILCLEGFN, [Out] Exception DDMPALIOLHO);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NEDGCJAFNPI(IHELAIDILBO AAADMOPBEBN, NativeParallelHashMap<Guid, LocalId> GECILCLEGFN, [Out] NativeArray<LocalId> ALJPELHALEH, [Out] NativeArray<LocalId> HMDGCANLOCL, [Out] NativeArray<AuthoredLocalPoseData> DCOLKEIMCNA, Allocator GIEDOJCOPKP);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "19")]
	void LMJONFGDJOC(IHELAIDILBO OEACCCPPJMI, NativeArray<int> NCGAAPLMBDI, LIJJHMMHNOE<GameObject> CFDMEKMNONF, AICGKLKDKDK<GameObject> EOCIFBEBMLO, POHNGBOFPDD ACAOPJKDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BFOMAMAOCLD();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "21")]
	void NDFJEFNCDEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "22")]
	void EGIAAGLNDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "23")]
	bool HJLBJGBCDLD(IHELAIDILBO AAADMOPBEBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "24")]
	DGDFGGIHDHN DDDMJCLDNBB(IHELAIDILBO AAADMOPBEBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "25")]
	void DCAHBNIIAEG(Guid AFMILMGPOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "26")]
	bool ALILAGGPPGG(Guid AFMILMGPOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x8568000", Offset = "0x8566E00", VA = "0x188568000")]
	static MNOGIMNBLBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface GBCFLBCFJMI
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	long OKLPMBBIJNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	long GKIIDPONFGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface DMAJLKBEGOM
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool OEAHHMAJDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool NHDHJMDHBGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int ANJGCGGKKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	int OFGMNCCDFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int EAFDNJFDBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool GGFGOGGFMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	int NDBABECGGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "6")]
	void HDGKCMEHLOJ(ILJACFPOAHI BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
	void BKGPICNNLKH(bool EGHLEJDADPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "8")]
	bool NOKJOGEBPNM(JCHCDPDFDDM GAILPBKIIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "9")]
	void KFBKCEBBELK(object OBBABGHFJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "10")]
	void CEIKFCEONPE(object OBBABGHFJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FDMGEIMGCED(Action<object> PMDGOKCFCGJ);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EDDMNIMDHJM(Action<object> PMDGOKCFCGJ);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "13")]
	void MEPHMPDDGIE(NativeArray<ViewId> HGFMAEKJIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "14")]
	void MJAFHJKAKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "15")]
	void DJHBHDDPEJC(ADGKOLDKGHI ADGMECOLKNH, ReadOnlySpan<byte> KANAIIDGHCH, JCHCDPDFDDM NPKICFNLIBN, bool BDCIFIJNLHB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "16")]
	void DJHBHDDPEJC(ADGKOLDKGHI ADGMECOLKNH, ReadOnlySpan<byte> FOILPBDDJHN, bool BDCIFIJNLHB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "17")]
	void DJHBHDDPEJC(ADGKOLDKGHI ADGMECOLKNH, ReadOnlySpan<byte> FOILPBDDJHN, ReadOnlySpan<byte> FPFKKKJPLOE, bool BDCIFIJNLHB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "18")]
	void JAGKINPBKIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "19")]
	void MDOMBOEKGHG(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "20")]
	void NPIMIMAKGEN(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "21")]
	void LAHGEMINLFB(Dictionary<object, object> GNPAPNCFCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "22")]
	void CBEGADCMHIP(NativeList<NEOKJNLGPDM> CCANGHOFHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "24")]
	void LOFDGPLGBCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "25")]
	void ADJDFJPLDAL(List<object> LEIEIBBJFFC, int DOCKBMMINED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "26")]
	void AALPGPLBIII(int NBFKDLHPDMI, object PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "27")]
	void INLBLONNLCC(JCHCDPDFDDM GAILPBKIIHJ, object HLILEGEIPMA, bool DOCPLLCIJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "28")]
	void GBGHIEODIJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "29")]
	void BEOKPKEFOIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KAFMLOGCIJC
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8562B80", Offset = "0x8561980", VA = "0x188562B80")]
	public static LHNEPIJNLEK NLDPCJOCLBA(this DMAJLKBEGOM IHDHFEFDGDE, object OBGCPOCPFIJ)
	{
		return default(LHNEPIJNLEK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct LHNEPIJNLEK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private DMAJLKBEGOM IHDHFEFDGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object OBGCPOCPFIJ;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8566DA0", Offset = "0x8565BA0", VA = "0x188566DA0")]
	public LHNEPIJNLEK(DMAJLKBEGOM IHDHFEFDGDE, object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8566D50", Offset = "0x8565B50", VA = "0x188566D50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BDAFCEOBMGK
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate void LIKOJCGCFAI(ViewId IAAFAPENNJO, FJBDCPJKLML BFKCKILBBIJ, int JFKPMDJNDHF);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "0")]
	void BDCEPMMAHDG(LIKOJCGCFAI PBHNHOAOGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "1")]
	void KOHANKPCMJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "2")]
	void MDFNGODNLEN(KKIENGDGBHL HBOAEALHJLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface JNJMAIGKPHF
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[ServiceLifetime(Lifetime.Application)]
public interface DJJPHGBIMBN
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct EPOPGPHINLE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private DJJPHGBIMBN ODAOLDCMOOM;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x855B6C0", Offset = "0x855A4C0", VA = "0x18855B6C0")]
		public EPOPGPHINLE(DJJPHGBIMBN ODAOLDCMOOM, string GBBEGJGJHAK, string PIDDOKNGCLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x855B660", Offset = "0x855A460", VA = "0x18855B660", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct APOLGBDPGFE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private DJJPHGBIMBN ODAOLDCMOOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task MGEGHBBNKMN;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8553120", Offset = "0x8551F20", VA = "0x188553120", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "0")]
	void IEGPGFLPOKC(string JDFCBBCKOGJ, float DFOOIFEDPMI = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "1")]
	void PMBNPFCACAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJMCMACPJIK(bool BIIGIAMCFDE, string GBBEGJGJHAK, string PIDDOKNGCLM);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "3")]
	void HOLHJACCOMN(string JDFCBBCKOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class FAAKCGFNEPF
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x855B750", Offset = "0x855A550", VA = "0x18855B750")]
	public static DJJPHGBIMBN.EPOPGPHINLE NCNOCAKHOPJ(this DJJPHGBIMBN IHDHFEFDGDE, string GBBEGJGJHAK, string PIDDOKNGCLM)
	{
		return default(DJJPHGBIMBN.EPOPGPHINLE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.Application)]
public interface CMPNBICAFEJ
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JMHLLGFEMGO(GameObject DFFAMKHOIDB);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEFANPOGMAO(GameObject DFFAMKHOIDB);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NPAJIMOJAGG(int GAILPBKIIHJ);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object NBGPONMNFCA(CLPADLABDGI DPODDKLLKHL, GameObject DFFAMKHOIDB, Action<CLPADLABDGI, int> LBJMJKFNAPH);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PMIKNPDJCAC(GameObject DFFAMKHOIDB, object INBHIKBKLHL);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FOONHEKBKBL
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	PKDFHNCAKBF MEKKCEOONFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MHDHAKMDCEA
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFHDENMCEAB(HPPLJGHGLBJ PAPIFPAPPKH, JAJFJFNCIMG NDCBECONEPG);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ACGDOPPEHPO(JCHCDPDFDDM GLMBLPAKFLM, OBKNICDPGNA OMDCJNFKICO);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface KIPLDAGDLFD
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFACCHGGJAP(object ALGAKMGCCLO, NativeList<byte> KANAIIDGHCH);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object PPEAGMPJINO(NativeArray<byte> KANAIIDGHCH);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
public interface NLNMAFEAMEB
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool DMDBMEHEMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate EAFNFFHEDEI(CBMAMJCDIJM BIKADOFBELM, Action<CBMAMJCDIJM> LBJMJKFNAPH);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JEJGPKJPKAL(CBMAMJCDIJM BIKADOFBELM, Delegate LBJMJKFNAPH);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate CFGLIGDEEGN(CBMAMJCDIJM BIKADOFBELM, Action<CBMAMJCDIJM> KJCIHLFFMME);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LNGLNFPPLHJ(CBMAMJCDIJM BIKADOFBELM, Delegate LBJMJKFNAPH);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AOICDAFDFKM(CBMAMJCDIJM BIKADOFBELM);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CBMAMJCDIJM NDDOAJEJFKN(GameObject DFFAMKHOIDB);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
public interface DFIEEIFELII
{
	[Cpp2IlInjected.Token(Token = "0x17000080")]
	int IGKAFFECGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	int BELBJFKLGEF
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool OEAHHMAJDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool AOKIGHNDMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool NMGHCHELHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CLPADLABDGI MJGLFGHMPHN(int GAILPBKIIHJ);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CIELONDAAKC(GameObject IOAPGCIJNMN, JobHandle GFBCENIFCPE);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface PKDFHNCAKBF
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OAINNEMDMKD(OBKNICDPGNA KCABFJOLKBE, JAJFJFNCIMG BMODAEEGEKI);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.Application)]
public interface GGKNOCGGMGF
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool GPEIDAGPFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface CEMAGBAFCCI
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	DBDEJHBHIBB ALGLKLLAEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	CNCKGAMCPLB FMLHBHEAHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool AMPCMJHOLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CMBEGPAEHKK(Transform DNNOOFELIOA);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFGDAICPDBA(Transform DNNOOFELIOA, IEHEPMCODHJ ENPAFKGOEOH);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DOJANBDCMBD(Transform DNNOOFELIOA, EHMIJFGJLBH FNIKNONFPHG);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.Application)]
public interface NNDBKKMJNOH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action AKJBBLNALEA;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[ServiceLifetime(Lifetime.Application)]
public interface ICONBNNCGFM
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALNNLNFNCAF();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[ServiceLifetime(Lifetime.Application)]
public interface LJPALDDLJIN
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMDGDGIOHMD(GameObject DFFAMKHOIDB, KACCCBNHEJG COGPDCPLJBG, OGCCJBFBPME KKLKEEMHHBN);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ENOLHHMFFHD(CLPADLABDGI DPODDKLLKHL, bool PHPLFAGGAFM, float3 EODLAHDLJHC, quaternion GALPINKCNPG);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HEIPMCOOIKK(INGCKODPEPI DNDNJPKBDOA);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KOKAMBDAGFF(PLCNDJEJBLF KINIEEOGPPI, PLCNDJEJBLF BNIHAACOHPG, KIPBMIHDBPL PFAGOGPEPDI);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGGELKPBBOO(PLCNDJEJBLF KINIEEOGPPI, KIPBMIHDBPL PFAGOGPEPDI);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MHLIMHBDPEC(INGCKODPEPI LDKDBKDJAOD);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JIICCEMMCGN(IHELAIDILBO HIOIAJMAFCA, ReadOnlySpan<Guid> MAGEKAFGAHP, ReadOnlySpan<int> DGLCCHHJPMJ, AICGKLKDKDK<GameObject> JHEOFBAADPD);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DFADNMKKLEG(EABFHLPIJBI NLBNJKDHGFH);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PCCGOHGGLHH(GEGCLDBGOLG GNCKEGPOHJJ, GEGCLDBGOLG CLCIGJBKCKF);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PNEDKFDDEOK(GEGCLDBGOLG GNCKEGPOHJJ, GEGCLDBGOLG CLCIGJBKCKF);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GAPDJHFDLKO(CLPADLABDGI GHKHLAMDPKO);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct BKFPFMCMLLG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> KANAIIDGHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle MJIBDELKIML;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8553570", Offset = "0x8552370", VA = "0x188553570")]
	public BKFPFMCMLLG(ReadOnlyMemory<byte> CNLAJIDIBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8553530", Offset = "0x8552330", VA = "0x188553530", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum LFPLHICMKIB
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
public struct IHELAIDILBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString PPLCDLIFKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object INNPPOLECFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object JDEDIKDLLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> HCFFFCKKBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool AIFPIALHNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public BLDOKMDFDCD.ICNDIKLHKLE? CNKBOONAFLE;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x855F950", Offset = "0x855E750", VA = "0x18855F950")]
	public IHELAIDILBO(ByteString PPLCDLIFKOP, [Optional] object INNPPOLECFE, [Optional] object JDEDIKDLLII, [Optional] IEnumerable<string> HCFFFCKKBPJ, bool AIFPIALHNPI = true, [Optional] BLDOKMDFDCD.ICNDIKLHKLE? CNKBOONAFLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct PCPCAOLKACE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object CCFGNDPBIOF;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct ONJEDAIHEGA
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[Flags]
	public enum LLDAJPFBLFP
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
	public RRObjectPrefabData ABJKDKONDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid GIFNCLMKCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid CBGPEALJKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid JDKDPBECFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid JEJFGNGFPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public LLDAJPFBLFP AEDIGFLCOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 KDKAJNHANCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int KONLMGJNMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public KLNHEFGHEBN NCHLPOFFLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int NNAKOLGOCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int LHGFEOENHGD;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Guid HCLLDAPOFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x566BF40", Offset = "0x566AD40", VA = "0x18566BF40")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool KCKONONHMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8569FD0", Offset = "0x8568DD0", VA = "0x188569FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool CFEENDBFMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8569FF0", Offset = "0x8568DF0", VA = "0x188569FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool POPMLPCEFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8569FC0", Offset = "0x8568DC0", VA = "0x188569FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool LLHNFPIOMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8569FE0", Offset = "0x8568DE0", VA = "0x188569FE0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct JJMAJOPFGDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly LPJHKCBGPKE NBLNCONJINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly LPJHKCBGPKE MLFFNDAMMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal readonly uint OBNIHDJEIGK;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8562890", Offset = "0x8561690", VA = "0x188562890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct NLPKMPPHHOL
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal readonly JJMAJOPFGDJ IJBAPONMLAP;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8569CF0", Offset = "0x8568AF0", VA = "0x188569CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct PLLEJNLJHEK
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly JJMAJOPFGDJ IJBAPONMLAP;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8569CF0", Offset = "0x8568AF0", VA = "0x188569CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct IBEPNJFFFMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly uint OBNIHDJEIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly bool MGNEBHEGPGO;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x855F510", Offset = "0x855E310", VA = "0x18855F510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct LPJHKCBGPKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal int IBOFMHFOKKF;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x85670A0", Offset = "0x8565EA0", VA = "0x1885670A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[ServiceLifetime(Lifetime.Application)]
public interface NLDKOGDNJOM
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	BBDJJPOOHAL IPOFGIEHDGE
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface HPEPADPHLPE
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface KKAHPJIIELF
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class LGGPPNAPBBE
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3DC11F0", Offset = "0x3DBFFF0", VA = "0x183DC11F0")]
	public static PLCNDJEJBLF PHIKENNNBLD<T>(this T DPODDKLLKHL) where T : HPEPADPHLPE
	{
		return default(PLCNDJEJBLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8565E30", Offset = "0x8564C30", VA = "0x188565E30")]
	public static MonoBehaviour MJEHGBJOHPN(this HPEPADPHLPE DPODDKLLKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8565D70", Offset = "0x8564B70", VA = "0x188565D70")]
	public static GameObject AHIOLNHEPAG(this HPEPADPHLPE DPODDKLLKHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface JMLJCFOIBJA : HPEPADPHLPE
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(CLPADLABDGI JIKGGNOOJMH);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface AGGMHMDPHIA : HPEPADPHLPE
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface NJOFFJHGNDL
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public delegate void DAPPMPCMHKJ(CIDCIKGJBKJ OPKDMPMKEMB);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event DAPPMPCMHKJ GLNLFKJLLDG;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface ACIGHJDLICK
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface NLFKPJNKOEJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface IMADFODCNDH
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(CLPADLABDGI DHOIDOHGBJH);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool CMFPANECDGL);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EMIJNJPOCJH(CLPADLABDGI MPOBGGNJMLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface FAFEEBMAFHA
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(HJAKPLGAOLP IKMKHOAFPDD);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface HJAKPLGAOLP
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	GameObject DFFAMKHOIDB
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	Transform DNNOOFELIOA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	ICIJOOIDPLO GPILBDBOKJA
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	bool AINHEIIGKDH
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OGEJFINEJCI(ICIJOOIDPLO ICNBLBLHJLK);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OMBFMDMEAGH GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class IFPGLEGNMII
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x855F5B0", Offset = "0x855E3B0", VA = "0x18855F5B0")]
	public static void HPOGAPJFDAK(this HJAKPLGAOLP HFFACBJLEBJ, LDEHODDHNKL KKBNGKDBMPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface ICIJOOIDPLO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Rigidbody JODPDMKLEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	HJAKPLGAOLP ONODMNHNEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	GameObject AHIOLNHEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	Transform DGABKBJAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	ICIJOOIDPLO PJMJBHEBFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	ICIJOOIDPLO CNGEAHLGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	int BNKCOIOMPEO
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	bool DIDGIOCFILP
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool AOICDAFDFKM
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	bool CIGHLHEBGMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	HJKHHJEKPOI PLGKPLEHELN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	HDEDPMNNDDA ILJDLEKNLKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	float FCMKJAKFOBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 FDHPBGDOGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 MNCHFCFEIAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Vector3 CAGGGBMOMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Vector3 FJGNNHBIOHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	bool EFEEAPHEIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool GHHJDIOAJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	bool ACOJDDNGACI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool HEFAALIBAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	Vector3 KMFNAFPIADI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Vector3 GCPHINBANOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	Vector3 GELFIBKHDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Vector3 DONGLEPOCPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	float OIMKFACPPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	float HGBFFNEBENA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Vector3 KGHHKCPMFMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	Quaternion JABJILNIMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	float FEKALCDLCGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	float CLLEGFGGHPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool OGHHPJAHPGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	CNIFHCNMKAP LPOKCMGFPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool MMHELOIBDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	Transform ANGJBFBLBAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	Vector3 HFBGBKOKOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	float CGECDOCGIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	float FABENJOFCEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Quaternion MNHIMFBCPKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Vector3 FEDOCAEMCFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	Quaternion DILMENNOHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	RigidbodyConstraints DNCDKBPLHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	bool LMPIKOEOANH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	CollisionDetectionMode OCDLLLIFNHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	bool FPCJOBDJJMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event JMEGBAKHEFO JHHNDEAFDBM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JMEGBAKHEFO LCDCJFBNGAN;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event JMEGBAKHEFO CGEGEONHKCN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event JMEGBAKHEFO NIDNOEDNDKD;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event JMEGBAKHEFO LJIIBIIGEMA;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event JMEGBAKHEFO NFDAPPGLIPD;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event JMEGBAKHEFO HPLGMEHICDJ;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event FECAAPMBKPL CGPEGJKMJAH;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<MJNFJJNDMDN, MJNFJJNDMDN> LCLBMAAGGLJ;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	ICIJOOIDPLO CLANCDICICN(int JJJJBEGKNIN);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void IIABJNALIAE((Quaternion rot, Vector3 moments) FFGEJMBOODN);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void IODAHCPKPHJ();

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void MDBAGKDBGJA();

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void GEOHBDNPMHL();

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void PMIBHIGFNFJ();

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void MFNAGEOMFHF();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void CPHNKAAPMCL(ICIJOOIDPLO HGMAIPELJHM, bool DJFEPAFCLJM = false);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void OAKHHFBPMOG(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void GAFLLKMHKBI(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 FMJOKGDDFLD(Vector3 IOMNICHLECK);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 FPBOIOAPFGJ(Vector3 KNLLFEKJGLJ);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void PEGMHEODBFG();

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void MODAEGGGNDJ();

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void LLDDJIOAAIN();

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void GDLIHAANJDK(Vector3 DKBAGIDMLLA, Vector3 JOAHJHGIBFJ);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void CELGCOPHAIP(Vector3 HHPOLKLJIOE, Vector3 MJIMOFHAOMF);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void DNJACAMCJPF(Vector3 MLKGMLAMDCD);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void OFPMGDLCIOE(EIALNCDFAED JIFAODPPPFE, Vector3 OMELNKHNHFK, float MNOEJMMHLIN, float HCBJLIFMPGL = 8f, float FBOCAAAJEPC = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void JPLOGPCODMP(LJAIKEBCGJJ CFCDLCNIEAJ, Vector3 JDMHDKLLHAP, float EDENKKIACIM = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void OJCFFIOELDH(LJAIKEBCGJJ CFCDLCNIEAJ, Vector3 GKEKGHNHKDP, float NBICOHADIBA = 7f, float IFFFGOPNNJH = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 KCLENONKJJK(Vector3 HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 LCJGHOEKEGG(Vector3 HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void LFHCDCJMDHL();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void CDHBCLGNKJL(ICIJOOIDPLO KPFALAKOKCP, object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void CNBLGEABPFP(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void LBJDPALFFDD();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void FBDIEOIMINN();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void GOKOCGBDLAN();

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool BMOPIGAAFGK();

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void DKCHJGAFNFD();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void FEECNOBFPAD(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void OLHEGDMHMJB(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void EGGKMJIFAEK(object OBGCPOCPFIJ, bool BOENCBCIEDN);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void EKAGGIGKOMD(Vector3 CBHDFFLGHBJ, Quaternion JMFCAFDNPMO);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void OLNCKEDFOOO(Vector3 GEGNJDBBONG, Quaternion PAMHEICLBHH);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool KNNBJPPMOOF(float IMDFPOKEEGC);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void INEHOCHMNLA(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void FFDKKHOAIPO(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void AKIIELENDBN(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void LPMHAGFBAHA(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void IHGBMKOPJGJ(Vector3 PPPGPLMAHNI, ForceMode CIFCFDNDJDB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void EINLMJIPMHP(Vector3 PPPGPLMAHNI, Vector3 FLAPAOJCDCM, ForceMode CIFCFDNDJDB);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void HJLPLBGHBLO(Vector3 KKOEFOMCALN, ForceMode CIFCFDNDJDB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void MAPLNIAAFCA(Vector3 KKOEFOMCALN, ForceMode CIFCFDNDJDB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool NFLLFJDNNBJ(Vector3 GHKIAFFJCCO, [Out] RaycastHit IBOKBOJEINI, float AGKOFMHMOAG);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void APBNNHFDBAH();
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface HDEDPMNNDDA
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class OMNNCIKPJIM : HDEDPMNNDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public OMNNCIKPJIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "0")]
	void MNPFANNAJML(Vector3 HPFFKCPPMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "1")]
	void FAFPMPKNPJL(Vector3 IGFPHPPALII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "2")]
	void BMNBENEKJFA(Vector3 HPFFKCPPMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "3")]
	void LAFJFFPMBNK(Vector3 IGFPHPPALII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface HJKHHJEKPOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BAFAGHONHJM();

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 PBCDICPKOAA();

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PEGGKDAKCJO(float OOPEEIEHOEL, float BKIGJNHHIKM);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public delegate void JMEGBAKHEFO(HJAKPLGAOLP GEFADLJKGAC);
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum BFCHHCBLDNK
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
public enum EIALNCDFAED
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
public delegate void FECAAPMBKPL(HJAKPLGAOLP GEFADLJKGAC, bool DJFEPAFCLJM = false);
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum LJAIKEBCGJJ
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct OMBFMDMEAGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Rigidbody HPBIMOMPCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public object IOPMDOAOFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 PCJOIKEHIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Vector3 GABJAKCPAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public PBNGAEFDFBE HCJLODBPDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool NLDGJEMACFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool AJKNHMFLPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool LDPEEEMGJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool BDPBJMOPNFA;
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct PLCNDJEJBLF : IEquatable<PLCNDJEJBLF>
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly PLCNDJEJBLF NPEEJKJJDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public GameObject DFFAMKHOIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x856AE10", Offset = "0x8569C10", VA = "0x18856AE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public NEOKJNLGPDM GJIOGDANHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x856B330", Offset = "0x856A130", VA = "0x18856B330")]
		get
		{
			return default(NEOKJNLGPDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public NCJEFIDIKOA JBBLNHEOGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x856B420", Offset = "0x856A220", VA = "0x18856B420")]
		get
		{
			return default(NCJEFIDIKOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public RRObjectPrefabData NJNDKDGHIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x856B050", Offset = "0x8569E50", VA = "0x18856B050")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool OJBELACJCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x856B2C0", Offset = "0x856A0C0", VA = "0x18856B2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool NDCKBHEFMCL
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x856B200", Offset = "0x856A000", VA = "0x18856B200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool JJKPAIHDLIA
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x856A6F0", Offset = "0x85694F0", VA = "0x18856A6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool MPLLPNFHPDE
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x856A710", Offset = "0x8569510", VA = "0x18856A710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool KMLJNGDLKAB
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x856A730", Offset = "0x8569530", VA = "0x18856A730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool MCKJCAEKHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x856A6C0", Offset = "0x85694C0", VA = "0x18856A6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool HDFLIKHJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x856AD90", Offset = "0x8569B90", VA = "0x18856AD90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool JEGFJMCMBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x856B180", Offset = "0x8569F80", VA = "0x18856B180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool DDFGLLLLPNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x856B510", Offset = "0x856A310", VA = "0x18856B510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool BCDGIMNDBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x856A7A0", Offset = "0x85695A0", VA = "0x18856A7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool IPPHBMGGGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x856B550", Offset = "0x856A350", VA = "0x18856B550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool FJLCPGKADML
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x856AD50", Offset = "0x8569B50", VA = "0x18856AD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool LAIMEPMLEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x856AAD0", Offset = "0x85698D0", VA = "0x18856AAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool CADIEBAPAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x856AA50", Offset = "0x8569850", VA = "0x18856AA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool GLOPJCDGDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x856AFA0", Offset = "0x8569DA0", VA = "0x18856AFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool JJDMBDLILDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x856ADD0", Offset = "0x8569BD0", VA = "0x18856ADD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public KKGEKLEODKB EKHHEKPHAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(KKGEKLEODKB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public PJGKBBIFNBA JJMBMEBHAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PJGKBBIFNBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public DGGLOEAMLPD LAFDDNAKMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(DGGLOEAMLPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public PPGJHLPAKMA BFKFJOOGAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PPGJHLPAKMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public GAIGFCPEKCF DKGLCIFEIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(GAIGFCPEKCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public LANKLPBFANB PDBLDKOCLFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(LANKLPBFANB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public ILCCCOFCLCL EBNCOHFPLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(ILCCCOFCLCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public JCBELHJOGAG OFGKDMOBCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(JCBELHJOGAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public GGJIKNMADMM LALHCGCNILH
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(GGJIKNMADMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public DGDNFAAJAMO IDHFMEEAEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(DGDNFAAJAMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public MHKIDKKNKHJ IBCJOOEIADC
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(MHKIDKKNKHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public BICFDKMNBMC NGGCKLJBBNC
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(BICFDKMNBMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public LGBPEPNHKDH PEJEOILKOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(LGBPEPNHKDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public ALDNOEBMAFD MAOGNANEGMB
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(ALDNOEBMAFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public JCIDGBLCJBP GPNLAGOBENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(JCIDGBLCJBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool LEBAMBEDKCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x856A960", Offset = "0x8569760", VA = "0x18856A960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public bool CFMIAKLEHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x856B1C0", Offset = "0x8569FC0", VA = "0x18856B1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool NHKHIKHLMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x856ABA0", Offset = "0x85699A0", VA = "0x18856ABA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool LHCDGKCPPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x856B500", Offset = "0x856A300", VA = "0x18856B500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool KBNFBPICEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x856AFE0", Offset = "0x8569DE0", VA = "0x18856AFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool GHBFPPPMHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x856AA90", Offset = "0x8569890", VA = "0x18856AA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public bool IAONGIBBHKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x856B4C0", Offset = "0x856A2C0", VA = "0x18856B4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public CAHFPHJCPBO DGABKBJAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CAHFPHJCPBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public BKKIKPHPLGC FMDMLHKGGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(BKKIKPHPLGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	private NKPGLIPFHAL HHDKFMGHBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8554120", Offset = "0x8552F20", VA = "0x188554120")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40")]
	public static PLCNDJEJBLF MIDAFINGFAP(CLPADLABDGI JIKGGNOOJMH)
	{
		return default(PLCNDJEJBLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x856A8E0", Offset = "0x85696E0", VA = "0x18856A8E0")]
	public FJBCBBIMJGF DLFEAAAIGAG()
	{
		return default(FJBCBBIMJGF);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x856AD20", Offset = "0x8569B20", VA = "0x18856AD20")]
	public ECLCKKGJKGL GGGCMEJHHPA()
	{
		return default(ECLCKKGJKGL);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x856B2E0", Offset = "0x856A0E0", VA = "0x18856B2E0")]
	public JBENECDAAOL NBGNHMMMNKA()
	{
		return default(JBENECDAAOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x856B020", Offset = "0x8569E20", VA = "0x18856B020")]
	public DJKPEPFCGON KMNDMCKNNLG()
	{
		return default(DJKPEPFCGON);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x856ACD0", Offset = "0x8569AD0", VA = "0x18856ACD0")]
	public EDACABGAMOG FLJJDLJAKFM()
	{
		return default(EDACABGAMOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x856B3D0", Offset = "0x856A1D0", VA = "0x18856B3D0")]
	public AAHAIFJBNLC NCCIGFJJEJC()
	{
		return default(AAHAIFJBNLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x856B590", Offset = "0x856A390", VA = "0x18856B590")]
	public GEGCLDBGOLG PLCBDONABDI()
	{
		return default(GEGCLDBGOLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x856A750", Offset = "0x8569550", VA = "0x18856A750")]
	public KDEGMOLOIEG CBHAFOENCDL()
	{
		return default(KDEGMOLOIEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x856ABE0", Offset = "0x85699E0", VA = "0x18856ABE0")]
	public JAGLEOMKAHF FGDNFGIBIEJ()
	{
		return default(JAGLEOMKAHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x856A7E0", Offset = "0x85695E0", VA = "0x18856A7E0")]
	public void DALIONGFIFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x856B220", Offset = "0x856A020", VA = "0x18856B220")]
	public void MFDBANBONAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x856AC30", Offset = "0x8569A30", VA = "0x18856AC30")]
	public bool FKIMHNFJOMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x856B5E0", Offset = "0x856A3E0", VA = "0x18856B5E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public PLCNDJEJBLF(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x8553240", Offset = "0x8552040", VA = "0x188553240")]
	public static bool MIDAFINGFAP(PLCNDJEJBLF HGMAIPELJHM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40")]
	public static CLPADLABDGI MIDAFINGFAP(PLCNDJEJBLF HGMAIPELJHM)
	{
		return default(CLPADLABDGI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x855BE90", Offset = "0x855AC90", VA = "0x18855BE90")]
	public static bool IKIADGFKNFC(PLCNDJEJBLF GENJGFGGINA, PLCNDJEJBLF KMNEIBIPMKI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x85571F0", Offset = "0x8555FF0", VA = "0x1885571F0")]
	public static bool GFAFFKCBFKA(PLCNDJEJBLF GENJGFGGINA, PLCNDJEJBLF KMNEIBIPMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x856AB10", Offset = "0x8569910", VA = "0x18856AB10", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(PLCNDJEJBLF FGAEAFBDBPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct LGBPEPNHKDH : IEquatable<LGBPEPNHKDH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private IGILKFLNECH MHOLEIAHCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8565850", Offset = "0x8564650", VA = "0x188565850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8565BC0", Offset = "0x85649C0", VA = "0x188565BC0")]
	public void MLJFGLCNIGE(uint FMFDAFLDAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8565940", Offset = "0x8564740", VA = "0x188565940")]
	public bool IKAAMFOADLB([Out] uint FMFDAFLDAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8565640", Offset = "0x8564440", VA = "0x188565640")]
	public bool BMLJIJAABPJ([Out] uint FMFDAFLDAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8565550", Offset = "0x8564350", VA = "0x188565550")]
	public void BFBHJGHPINC(string FMFDAFLDAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8565740", Offset = "0x8564540", VA = "0x188565740")]
	[CanBeNull]
	public string BMOFAPDFKAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8565A40", Offset = "0x8564840", VA = "0x188565A40")]
	public bool LKAKNPJEBBA([Out] string MOHAGBMEKHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8565CD0", Offset = "0x8564AD0", VA = "0x188565CD0")]
	public void NCGMDAPFEDF(string MOHAGBMEKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public LGBPEPNHKDH(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x85658B0", Offset = "0x85646B0", VA = "0x1885658B0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(LGBPEPNHKDH FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct KKGEKLEODKB : IEquatable<KKGEKLEODKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private BCICJPBDLAP HIABKFJBBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8563710", Offset = "0x8562510", VA = "0x188563710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private IGILKFLNECH NKMMEKKNHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8563800", Offset = "0x8562600", VA = "0x188563800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool PJHPKBPGGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8563980", Offset = "0x8562780", VA = "0x188563980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public bool PNFDJMKKGLH
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8563E10", Offset = "0x8562C10", VA = "0x188563E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public bool PCFJMANDOGG
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8563D50", Offset = "0x8562B50", VA = "0x188563D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public Guid LPJHEAOHPLN
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8563A10", Offset = "0x8562810", VA = "0x188563A10")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Guid OPACLHCJMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8563C30", Offset = "0x8562A30", VA = "0x188563C30")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public Guid JJBNAAKCCBP
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8563500", Offset = "0x8562300", VA = "0x188563500")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public BKKIKPHPLGC FMDMLHKGGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(BKKIKPHPLGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8563B90", Offset = "0x8562990", VA = "0x188563B90")]
	public bool IKBBCHPOOGP([Out] Guid CPLLEEFPGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8563CB0", Offset = "0x8562AB0", VA = "0x188563CB0")]
	public bool KBMCBEFGNJN([Out] Guid NKENCNIEFON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8563860", Offset = "0x8562660", VA = "0x188563860")]
	public void GDFGCCONNPG(Guid DOMECMGKIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x8563A90", Offset = "0x8562890", VA = "0x188563A90")]
	public void IDHFDKCDMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x8563E50", Offset = "0x8562C50", VA = "0x188563E50")]
	public Guid PFONEFHDIBE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public KKGEKLEODKB(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x8563770", Offset = "0x8562570", VA = "0x188563770", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(KKGEKLEODKB FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct JBENECDAAOL : IEquatable<JBENECDAAOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private LAMALDPDKJM HICDLPFINFO
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8561A70", Offset = "0x8560870", VA = "0x188561A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Vector3 NGJIECLPEEE
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x85615A0", Offset = "0x85603A0", VA = "0x1885615A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Quaternion FIKNMHBJAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8561920", Offset = "0x8560720", VA = "0x188561920")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public PLCNDJEJBLF BMNLBFEGBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8561800", Offset = "0x8560600", VA = "0x188561800")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x8561430", Offset = "0x8560230", VA = "0x188561430")]
	public INGCKODPEPI BKPEEFFMDMP(Allocator GIEDOJCOPKP)
	{
		return default(INGCKODPEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x8561500", Offset = "0x8560300", VA = "0x188561500")]
	public bool CGJMFMNHJEK(PLCNDJEJBLF PJGOIMBEKPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x85612E0", Offset = "0x85600E0", VA = "0x1885612E0")]
	public void ABAJFPLHIIM(Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x85616F0", Offset = "0x85604F0", VA = "0x1885616F0")]
	public void DOMDONECMGC(float KBAEKIALOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x8561AD0", Offset = "0x85608D0", VA = "0x188561AD0")]
	public void PAAFNPBCFFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public JBENECDAAOL(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x8553240", Offset = "0x8552040", VA = "0x188553240")]
	public static bool MIDAFINGFAP(JBENECDAAOL HGMAIPELJHM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40")]
	public static CLPADLABDGI MIDAFINGFAP(JBENECDAAOL HGMAIPELJHM)
	{
		return default(CLPADLABDGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x8561890", Offset = "0x8560690", VA = "0x188561890", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(JBENECDAAOL FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct FJBCBBIMJGF : IEquatable<FJBCBBIMJGF>
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly FJBCBBIMJGF NPEEJKJJDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private IBKCEPLCLAA DKIJEJGCHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x855CC50", Offset = "0x855BA50", VA = "0x18855CC50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<PLCNDJEJBLF> OHHIJKHDBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x855CCB0", Offset = "0x855BAB0", VA = "0x18855CCB0")]
		get
		{
			return default(Span<PLCNDJEJBLF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x855CE30", Offset = "0x855BC30", VA = "0x18855CE30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x855CDB0", Offset = "0x855BBB0", VA = "0x18855CDB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public CAHFPHJCPBO DGABKBJAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CAHFPHJCPBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public BKKIKPHPLGC FMDMLHKGGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(BKKIKPHPLGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x855C720", Offset = "0x855B520", VA = "0x18855C720")]
	public void EEENEPJGDDB(FJBCBBIMJGF FGAEAFBDBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public FJBCBBIMJGF(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x8553240", Offset = "0x8552040", VA = "0x188553240")]
	public static bool MIDAFINGFAP(FJBCBBIMJGF HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x855CBC0", Offset = "0x855B9C0", VA = "0x18855CBC0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(FJBCBBIMJGF FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40")]
	public static PLCNDJEJBLF MIDAFINGFAP(FJBCBBIMJGF DBBEADIHLKO)
	{
		return default(PLCNDJEJBLF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[DefaultMember("Item")]
public struct AGAHNKFDNHP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Dictionary<int, object> OKBODOGBGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private BIDBFKMJJKN FEFDLCHGEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool GEOECIKGMFI;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		[CompilerGenerated]
		readonly get
		{
			return default(PLCNDJEJBLF);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public EALJOJPJJCH ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x85526E0", Offset = "0x85514E0", VA = "0x1885526E0")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x85529F0", Offset = "0x85517F0", VA = "0x1885529F0")]
	internal AGAHNKFDNHP(PLCNDJEJBLF ALGAKMGCCLO, bool GEOECIKGMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x85527A0", Offset = "0x85515A0", VA = "0x1885527A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x32504D0", Offset = "0x324F2D0", VA = "0x1832504D0")]
	public void MEBIAEPPKAJ<T>(EALJOJPJJCH OPGJHIOADCK, T HGMAIPELJHM, [Optional] T PGFMONBPOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x8552940", Offset = "0x8551740", VA = "0x188552940")]
	public void MDNHCHGJFLC(EALJOJPJJCH OPGJHIOADCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0xB3C8B0", Offset = "0xB3B6B0", VA = "0x180B3C8B0")]
	public Dictionary<int, object> LKLHGPCGKOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x85528D0", Offset = "0x85516D0", VA = "0x1885528D0")]
	private readonly void KNOBILFGHNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class KMMNPHJAKNM
{
	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x8563F70", Offset = "0x8562D70", VA = "0x188563F70")]
	public static AGAHNKFDNHP KOFNFADKKIF(this PLCNDJEJBLF ALGAKMGCCLO)
	{
		return default(AGAHNKFDNHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct ALDNOEBMAFD : IEquatable<ALDNOEBMAFD>
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly ALDNOEBMAFD NPEEJKJJDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private bool IPPHBMGGGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8552F50", Offset = "0x8551D50", VA = "0x188552F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 GFGDMJGBCFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8552F90", Offset = "0x8551D90", VA = "0x188552F90")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8552D60", Offset = "0x8551B60", VA = "0x188552D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x8552CE0", Offset = "0x8551AE0", VA = "0x188552CE0")]
	public Vector3 ALGCAADOFCC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x8552E50", Offset = "0x8551C50", VA = "0x188552E50")]
	public void IDJJPHGAHKJ([In] Vector3 HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x8552ED0", Offset = "0x8551CD0", VA = "0x188552ED0")]
	public void NJNGJNOBMPI([In] Vector3 HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8552C30", Offset = "0x8551A30", VA = "0x188552C30")]
	public bool AAJAEDFGBGF([In] Vector3 HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public ALDNOEBMAFD(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8552DC0", Offset = "0x8551BC0", VA = "0x188552DC0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(ALDNOEBMAFD FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8553040", Offset = "0x8551E40", VA = "0x188553040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct BJLNGGEFHAM : IEquatable<BJLNGGEFHAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x85534A0", Offset = "0x85522A0", VA = "0x1885534A0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(BJLNGGEFHAM FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct KDEGMOLOIEG : IEquatable<KDEGMOLOIEG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private MCGPNAIJHKG DCHBCKJBNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8563100", Offset = "0x8561F00", VA = "0x188563100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool LJINMMDOOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x85632A0", Offset = "0x85620A0", VA = "0x1885632A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool ALLADEIFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8562C10", Offset = "0x8561A10", VA = "0x188562C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public HPNGFHINOGL CAIHIDBMGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8563160", Offset = "0x8561F60", VA = "0x188563160")]
		get
		{
			return default(HPNGFHINOGL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool IHFMEFCHLKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8562D40", Offset = "0x8561B40", VA = "0x188562D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool APKOAPGECPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x85633D0", Offset = "0x85621D0", VA = "0x1885633D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public bool ODHFBGLLDFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8562E10", Offset = "0x8561C10", VA = "0x188562E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8562EA0", Offset = "0x8561CA0", VA = "0x188562EA0")]
	public bool HBEMOEKKFCP(KDEGMOLOIEG MFIOOMENBJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8563460", Offset = "0x8562260", VA = "0x188563460")]
	public bool MFCBMMMHAFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8562F40", Offset = "0x8561D40", VA = "0x188562F40")]
	public bool IIFKNEFENHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8562FE0", Offset = "0x8561DE0", VA = "0x188562FE0")]
	public ReadOnlySpan<CLPADLABDGI> JBALEAHIOFO()
	{
		return default(ReadOnlySpan<CLPADLABDGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public KDEGMOLOIEG(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x855BE90", Offset = "0x855AC90", VA = "0x18855BE90")]
	public static bool IKIADGFKNFC(KDEGMOLOIEG GENJGFGGINA, KDEGMOLOIEG KMNEIBIPMKI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x85571F0", Offset = "0x8555FF0", VA = "0x1885571F0")]
	public static bool GFAFFKCBFKA(KDEGMOLOIEG GENJGFGGINA, KDEGMOLOIEG KMNEIBIPMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8562D80", Offset = "0x8561B80", VA = "0x188562D80", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(KDEGMOLOIEG FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct GEGCLDBGOLG : IEquatable<GEGCLDBGOLG>
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly GEGCLDBGOLG NPEEJKJJDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private MCGPNAIJHKG GKPOBDHGPKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x855E1D0", Offset = "0x855CFD0", VA = "0x18855E1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool FNNIPPOACPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x855E040", Offset = "0x855CE40", VA = "0x18855E040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CAHFPHJCPBO DGABKBJAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CAHFPHJCPBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x855E130", Offset = "0x855CF30", VA = "0x18855E130")]
	public bool HBEMOEKKFCP(GEGCLDBGOLG FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x855DFA0", Offset = "0x855CDA0", VA = "0x18855DFA0")]
	public bool BNJEGIOAOOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x855E230", Offset = "0x855D030", VA = "0x18855E230")]
	public bool JNOFAIBDNNJ([Out] GEGCLDBGOLG DKBMONPPKOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x855E310", Offset = "0x855D110", VA = "0x18855E310")]
	public void LPPCIHPEHDG(JKEPBPODJPA FFAHAEGEIFG, bool NBJEPEHJPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public GEGCLDBGOLG(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x855BE90", Offset = "0x855AC90", VA = "0x18855BE90")]
	public static bool IKIADGFKNFC(GEGCLDBGOLG GENJGFGGINA, GEGCLDBGOLG KMNEIBIPMKI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x85571F0", Offset = "0x8555FF0", VA = "0x1885571F0")]
	public static bool GFAFFKCBFKA(GEGCLDBGOLG GENJGFGGINA, GEGCLDBGOLG KMNEIBIPMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x855E0A0", Offset = "0x855CEA0", VA = "0x18855E0A0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(GEGCLDBGOLG FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct BKKIKPHPLGC : IEquatable<BKKIKPHPLGC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private IBKCEPLCLAA DKIJEJGCHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8553910", Offset = "0x8552710", VA = "0x188553910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public CLPADLABDGI CPHGENEEOPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x85537F0", Offset = "0x85525F0", VA = "0x1885537F0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public PLCNDJEJBLF PJMJBHEBFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8553C00", Offset = "0x8552A00", VA = "0x188553C00")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public PLCNDJEJBLF CNGEAHLGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8553E90", Offset = "0x8552C90", VA = "0x188553E90")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x8553B00", Offset = "0x8552900", VA = "0x188553B00")]
	public Span<PLCNDJEJBLF> JFFIGFIEIHP()
	{
		return default(Span<PLCNDJEJBLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x8553C90", Offset = "0x8552A90", VA = "0x188553C90")]
	public Span<PLCNDJEJBLF> KEACKIBHNMG()
	{
		return default(Span<PLCNDJEJBLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x8553D90", Offset = "0x8552B90", VA = "0x188553D90")]
	public Span<PLCNDJEJBLF> MHLEGGNEAJA()
	{
		return default(Span<PLCNDJEJBLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x8553A00", Offset = "0x8552800", VA = "0x188553A00")]
	public Span<PLCNDJEJBLF> HKLLJJDJJMA()
	{
		return default(Span<PLCNDJEJBLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x8553620", Offset = "0x8552420", VA = "0x188553620")]
	public bool CPHNKAAPMCL(PLCNDJEJBLF PJGOIMBEKPK, bool LJCDLCNLAKI = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8553750", Offset = "0x8552550", VA = "0x188553750")]
	public bool DBLHHNIODCP(PLCNDJEJBLF FNOFFMCCBDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x8553F20", Offset = "0x8552D20", VA = "0x188553F20")]
	public PLCNDJEJBLF OOCDIMCODHE(uint LOCBGFBLGEG)
	{
		return default(PLCNDJEJBLF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x8553970", Offset = "0x8552770", VA = "0x188553970")]
	public FJBCBBIMJGF GPJCKHGIIMF()
	{
		return default(FJBCBBIMJGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public BKKIKPHPLGC(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x8553240", Offset = "0x8552040", VA = "0x188553240")]
	public static bool MIDAFINGFAP(BKKIKPHPLGC HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x8553880", Offset = "0x8552680", VA = "0x188553880", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(BKKIKPHPLGC FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct PJGKBBIFNBA : IEquatable<PJGKBBIFNBA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public string HFLFOHLMPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x856A630", Offset = "0x8569430", VA = "0x18856A630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string IFJMOOOCCFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x856A120", Offset = "0x8568F20", VA = "0x18856A120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public string MKIEMIDIIHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x856A4C0", Offset = "0x85692C0", VA = "0x18856A4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public string HPPLOKJCHGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x856A220", Offset = "0x8569020", VA = "0x18856A220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x856A570", Offset = "0x8569370", VA = "0x18856A570")]
	public bool LKAKNPJEBBA([Out] string MOHAGBMEKHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public PJGKBBIFNBA(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x856A190", Offset = "0x8568F90", VA = "0x18856A190", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(PJGKBBIFNBA FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct PACKLKGHOBA : IEquatable<PACKLKGHOBA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x856A000", Offset = "0x8568E00", VA = "0x18856A000", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(PACKLKGHOBA FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct LHJHGPGPHJO : IEquatable<LHJHGPGPHJO>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[Flags]
	public enum CMDLEPEDIOG
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
	private static ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly LHJHGPGPHJO NPEEJKJJDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private NKPGLIPFHAL HHDKFMGHBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8554120", Offset = "0x8552F20", VA = "0x188554120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x8566680", Offset = "0x8565480", VA = "0x188566680")]
	public static CMDLEPEDIOG KAEHJLHJPNH(LHJHGPGPHJO GENJGFGGINA, LHJHGPGPHJO KMNEIBIPMKI)
	{
		return default(CMDLEPEDIOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x85660C0", Offset = "0x8564EC0", VA = "0x1885660C0")]
	public bool AOFKFGNHDCN([Out] GameObject PJGOIMBEKPK, [Out] GameObject DFFAMKHOIDB, [Out] PLCNDJEJBLF DNHCELPCKKE, [Out] PLCNDJEJBLF CGIJFDOGBJI, [Out] Vector3 FLAPAOJCDCM, [Out] Vector3 IJPKOFOJLBJ, [Out] Vector3 GANDOGGFBGG, [Out] PLCNDJEJBLF PIAAELNBOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x8565EB0", Offset = "0x8564CB0", VA = "0x188565EB0")]
	public bool ALCLDIAJHKL([Out] GameObject PJGOIMBEKPK, [Out] GameObject DFFAMKHOIDB, [Out] PLCNDJEJBLF DNHCELPCKKE, [Out] PLCNDJEJBLF CGIJFDOGBJI, [Out] Vector3 FLAPAOJCDCM, [Out] Vector3 IJPKOFOJLBJ, [Out] Vector3 GANDOGGFBGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x85668A0", Offset = "0x85656A0", VA = "0x1885668A0")]
	private void OAKNCMKKGKD(Entity DJHHEAHBFFL, EntityManager GJNHEPEHOMO, MagneticAnchorData NNCBNHAAPOF, [Out] GameObject PJGOIMBEKPK, [Out] GameObject DFFAMKHOIDB, [Out] PLCNDJEJBLF DNHCELPCKKE, [Out] PLCNDJEJBLF CGIJFDOGBJI, [Out] Vector3 FLAPAOJCDCM, [Out] Vector3 IJPKOFOJLBJ, [Out] Vector3 GANDOGGFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public LHJHGPGPHJO(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x85665F0", Offset = "0x85653F0", VA = "0x1885665F0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(LHJHGPGPHJO FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8566C60", Offset = "0x8565A60", VA = "0x188566C60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct PGAEEGHKHAF : IEquatable<PGAEEGHKHAF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x856A090", Offset = "0x8568E90", VA = "0x18856A090", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(PGAEEGHKHAF FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct JCIDGBLCJBP : IEquatable<JCIDGBLCJBP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	private JCLBIPBLLFA GKPOBDHGPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8562380", Offset = "0x8561180", VA = "0x188562380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public EJBFMDKCMCB NPBANGNPAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8562190", Offset = "0x8560F90", VA = "0x188562190")]
		get
		{
			return default(EJBFMDKCMCB);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8561F00", Offset = "0x8560D00", VA = "0x188561F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public AICGKLKDKDK<string> JDNDFKAJJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x85623E0", Offset = "0x85611E0", VA = "0x1885623E0")]
		get
		{
			return default(AICGKLKDKDK<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8562070", Offset = "0x8560E70", VA = "0x188562070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public AICGKLKDKDK<string> JLPANJGFMBL
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8562260", Offset = "0x8561060", VA = "0x188562260")]
		get
		{
			return default(AICGKLKDKDK<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x8561F50", Offset = "0x8560D50", VA = "0x188561F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public JCIDGBLCJBP(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x85621D0", Offset = "0x8560FD0", VA = "0x1885621D0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(JCIDGBLCJBP FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct DGGLOEAMLPD : IEquatable<DGGLOEAMLPD>
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly ComponentTypes PPGKMFKDBMP;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly DGGLOEAMLPD NPEEJKJJDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public Collider CICKBPFBKBL
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x85585C0", Offset = "0x85573C0", VA = "0x1885585C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public KFEDHNGJABP ACGDGDPEGCO
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8558B50", Offset = "0x8557950", VA = "0x188558B50")]
		get
		{
			return default(KFEDHNGJABP);
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x85583E0", Offset = "0x85571E0", VA = "0x1885583E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public OPMNLOIMMHC HIDHAAJCANL
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8558C00", Offset = "0x8557A00", VA = "0x188558C00")]
		get
		{
			return default(OPMNLOIMMHC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8558B00", Offset = "0x8557900", VA = "0x188558B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public BODKJCEPELE KDGCFPNNBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x85582B0", Offset = "0x85570B0", VA = "0x1885582B0")]
		get
		{
			return default(BODKJCEPELE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8558470", Offset = "0x8557270", VA = "0x188558470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public float JKALFLJMLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8558430", Offset = "0x8557230", VA = "0x188558430")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8559150", Offset = "0x8557F50", VA = "0x188559150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool AHEJDPGOJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8558B90", Offset = "0x8557990", VA = "0x188558B90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x85589D0", Offset = "0x85577D0", VA = "0x1885589D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public bool HJKPCEMCJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8558F60", Offset = "0x8557D60", VA = "0x188558F60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x8558520", Offset = "0x8557320", VA = "0x188558520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool EKJNLCNOKKC
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8558EE0", Offset = "0x8557CE0", VA = "0x188558EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8558CE0", Offset = "0x8557AE0", VA = "0x188558CE0")]
	public static bool NFKBJHGOAPE(PLCNDJEJBLF GFOFGFPBFCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8558710", Offset = "0x8557510", VA = "0x188558710")]
	public static bool DDAKMEGCLEF(PLCNDJEJBLF GFOFGFPBFCL, [Out] DGGLOEAMLPD EFNJGOEPBAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8558FE0", Offset = "0x8557DE0", VA = "0x188558FE0")]
	public bool PBGHHPLMIJC([Out] IMADFODCNDH OJDDLOEFCAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x85582F0", Offset = "0x85570F0", VA = "0x1885582F0")]
	public bool BBPOODAKFGC([Out] CLPADLABDGI MMENCBNBOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x85584C0", Offset = "0x85572C0", VA = "0x1885584C0")]
	public bool CIDBAENDGNJ(NPGBDKBLCFB FFAHAEGEIFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8558950", Offset = "0x8557750", VA = "0x188558950")]
	public void EEOHCKOPLBD(NPGBDKBLCFB FFAHAEGEIFG, bool BNIEEGBIIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8558C40", Offset = "0x8557A40", VA = "0x188558C40")]
	public void MFOBBBBLNCA(NPGBDKBLCFB FFAHAEGEIFG, bool BNIEEGBIIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public DGGLOEAMLPD(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8558A70", Offset = "0x8557870", VA = "0x188558A70", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(DGGLOEAMLPD FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x85591A0", Offset = "0x8557FA0", VA = "0x1885591A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct DJKPEPFCGON : IEquatable<DJKPEPFCGON>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool BDNIMOKODJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x8559450", Offset = "0x8558250", VA = "0x188559450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public DJKPEPFCGON(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x85593C0", Offset = "0x85581C0", VA = "0x1885593C0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(DJKPEPFCGON FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct PPGJHLPAKMA : IEquatable<PPGJHLPAKMA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	private LFJBEPBFBKH ICONMGOALGL
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x856B860", Offset = "0x856A660", VA = "0x18856B860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x856B8C0", Offset = "0x856A6C0", VA = "0x18856B8C0")]
	public void OOGOBOCIIHK(bool DHMELENJBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public PPGJHLPAKMA(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x856B7D0", Offset = "0x856A5D0", VA = "0x18856B7D0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(PPGJHLPAKMA FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct EDACABGAMOG : IEquatable<EDACABGAMOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private KHEMHDJNPEK GHAJICMEFGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x855A8C0", Offset = "0x85596C0", VA = "0x18855A8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public EJBFMDKCMCB PEHIOABDABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x855A920", Offset = "0x8559720", VA = "0x18855A920")]
		get
		{
			return default(EJBFMDKCMCB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x855A3C0", Offset = "0x85591C0", VA = "0x18855A3C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool IEMCKCIDFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x855A0D0", Offset = "0x8558ED0", VA = "0x18855A0D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x855A320", Offset = "0x8559120", VA = "0x18855A320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public AICGKLKDKDK<string> HEPLCBIDDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x855AC60", Offset = "0x8559A60", VA = "0x18855AC60")]
		get
		{
			return default(AICGKLKDKDK<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x855AB40", Offset = "0x8559940", VA = "0x18855AB40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public AICGKLKDKDK<string> GDEIGOKAKIM
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x855A560", Offset = "0x8559360", VA = "0x18855A560")]
		get
		{
			return default(AICGKLKDKDK<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x855AA20", Offset = "0x8559820", VA = "0x18855AA20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public AICGKLKDKDK<string> BHGIHEDEGFD
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x8559FB0", Offset = "0x8558DB0", VA = "0x188559FB0")]
		get
		{
			return default(AICGKLKDKDK<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x855A7A0", Offset = "0x85595A0", VA = "0x18855A7A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public AICGKLKDKDK<string> JNCIEFCBFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x855A160", Offset = "0x8558F60", VA = "0x18855A160")]
		get
		{
			return default(AICGKLKDKDK<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x855A680", Offset = "0x8559480", VA = "0x18855A680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x855A280", Offset = "0x8559080", VA = "0x18855A280")]
	public bool CJJIELHKNBG(CLPADLABDGI GLMBLPAKFLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public EDACABGAMOG(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40")]
	public static CLPADLABDGI MIDAFINGFAP(EDACABGAMOG HGMAIPELJHM)
	{
		return default(CLPADLABDGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x855A4D0", Offset = "0x85592D0", VA = "0x18855A4D0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(EDACABGAMOG FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct GAIGFCPEKCF : IEquatable<GAIGFCPEKCF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool BABGIMJEPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x855D860", Offset = "0x855C660", VA = "0x18855D860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool CJJJDCCMOBA
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x855DDB0", Offset = "0x855CBB0", VA = "0x18855DDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public bool OOBBMAOFFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x855D150", Offset = "0x855BF50", VA = "0x18855D150")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x855DD90", Offset = "0x855CB90", VA = "0x18855DD90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public bool NBBIMNGKMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x855DB90", Offset = "0x855C990", VA = "0x18855DB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool OMPLGBPPGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x855D060", Offset = "0x855BE60", VA = "0x18855D060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool AAFOLLGHHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x855D2E0", Offset = "0x855C0E0", VA = "0x18855D2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool ALJAKIHILKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x855D8A0", Offset = "0x855C6A0", VA = "0x18855D8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool JPFLKPJLMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x855D4B0", Offset = "0x855C2B0", VA = "0x18855D4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool HLAIFHLNFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x855DB40", Offset = "0x855C940", VA = "0x18855DB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool CPOJFFGHCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x855D200", Offset = "0x855C000", VA = "0x18855D200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool NIEMGHLOLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x855D380", Offset = "0x855C180", VA = "0x18855D380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool MNKMMNAAPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x855D3D0", Offset = "0x855C1D0", VA = "0x18855D3D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool IKOPKKPDAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x855DC70", Offset = "0x855CA70", VA = "0x18855DC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool MJPLPFFKIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x855D500", Offset = "0x855C300", VA = "0x18855D500")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x855D1A0", Offset = "0x855BFA0", VA = "0x18855D1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public bool JJOBAJOLFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x855DBE0", Offset = "0x855C9E0", VA = "0x18855DBE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public KDMHPNFPNBI FBBJCGEGMKH
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x855D2A0", Offset = "0x855C0A0", VA = "0x18855D2A0")]
		get
		{
			return default(KDMHPNFPNBI);
		}
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x855D330", Offset = "0x855C130", VA = "0x18855D330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool JINILEJIAHP
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x855D9E0", Offset = "0x855C7E0", VA = "0x18855D9E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public OGCCJBFBPME IPGHCEJEDBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x855D110", Offset = "0x855BF10", VA = "0x18855D110")]
		get
		{
			return default(OGCCJBFBPME);
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x855D810", Offset = "0x855C610", VA = "0x18855D810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public bool MOMGKDAEKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x855DC30", Offset = "0x855CA30", VA = "0x18855DC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public Vector3 GEJPNFDLNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x855D540", Offset = "0x855C340", VA = "0x18855D540")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public Vector3 EJLBOFKNIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x855D790", Offset = "0x855C590", VA = "0x18855D790")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public bool FNINMDBGCOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x855D5C0", Offset = "0x855C3C0", VA = "0x18855D5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public bool KNFNCJNGPPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x855D8F0", Offset = "0x855C6F0", VA = "0x18855D8F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	private EntityManager CDPCMDMNAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x855DE90", Offset = "0x855CC90", VA = "0x18855DE90")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x855D0B0", Offset = "0x855BEB0", VA = "0x18855D0B0")]
	public bool BDMKLLHNABP(FMEOMHEDJLA FFAHAEGEIFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x855DE00", Offset = "0x855CC00", VA = "0x18855DE00")]
	public void OCNHNJEEDFB(FMEOMHEDJLA FFAHAEGEIFG, bool BNIEEGBIIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x855DCC0", Offset = "0x855CAC0", VA = "0x18855DCC0")]
	public bool MPHHPGCLLIF(KACCCBNHEJG FFAHAEGEIFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x855DD10", Offset = "0x855CB10", VA = "0x18855DD10")]
	public void NGOLNKAODIE(KACCCBNHEJG FFAHAEGEIFG, bool BNIEEGBIIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x855DB00", Offset = "0x855C900", VA = "0x18855DB00")]
	public KACCCBNHEJG JKEAPLIHFJK()
	{
		return default(KACCCBNHEJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x855D250", Offset = "0x855C050", VA = "0x18855D250")]
	public bool CGGGLOBJDFC(KACCCBNHEJG HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public GAIGFCPEKCF(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x855D420", Offset = "0x855C220", VA = "0x18855D420", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(GAIGFCPEKCF FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct LANKLPBFANB : IEquatable<LANKLPBFANB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private KOMIMDAFOBH EJNBAEMABNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8564430", Offset = "0x8563230", VA = "0x188564430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x8564940", Offset = "0x8563740", VA = "0x188564940")]
	public bool NJGMCDBBPLE(KIPBMIHDBPL PFAGOGPEPDI, List<PLCNDJEJBLF> LFLGOCOHDIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x8564A70", Offset = "0x8563870", VA = "0x188564A70")]
	public int PFBBFNNNJGN(KIPBMIHDBPL PFAGOGPEPDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x8564320", Offset = "0x8563120", VA = "0x188564320")]
	public void DBCIAKNGHBJ(List<PLCNDJEJBLF> LFLGOCOHDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x8564030", Offset = "0x8562E30", VA = "0x188564030")]
	public int AAEPANPJFBI(PLCNDJEJBLF BNIHAACOHPG, KIPBMIHDBPL PFAGOGPEPDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x8564810", Offset = "0x8563610", VA = "0x188564810")]
	public PLCNDJEJBLF MCMMGNICCDB(int JJJJBEGKNIN, KIPBMIHDBPL PFAGOGPEPDI)
	{
		return default(PLCNDJEJBLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x85646E0", Offset = "0x85634E0", VA = "0x1885646E0")]
	public void LNAHGCIMKJO(PLCNDJEJBLF BNIHAACOHPG, KIPBMIHDBPL PFAGOGPEPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x8564630", Offset = "0x8563430", VA = "0x188564630")]
	public bool LJMGGJMMNFH(PLCNDJEJBLF BNIHAACOHPG, KIPBMIHDBPL PFAGOGPEPDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x8564210", Offset = "0x8563010", VA = "0x188564210")]
	public void CIPCKEEMAAB(KIPBMIHDBPL PFAGOGPEPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x8564160", Offset = "0x8562F60", VA = "0x188564160")]
	public bool ABEEOOOFMNE(PLCNDJEJBLF BNIHAACOHPG, KIPBMIHDBPL PFAGOGPEPDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x8564520", Offset = "0x8563320", VA = "0x188564520")]
	public bool HBHCFOHEOOO(KIPBMIHDBPL PFAGOGPEPDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public LANKLPBFANB(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x8564490", Offset = "0x8563290", VA = "0x188564490", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(LANKLPBFANB FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct ILCCCOFCLCL : IEquatable<ILCCCOFCLCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x855F9D0", Offset = "0x855E7D0", VA = "0x18855F9D0")]
	public void EICONKDEPMJ(bool HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x855FAF0", Offset = "0x855E8F0", VA = "0x18855FAF0")]
	public void JFJHDBGHCJE(bool HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x3D4DDD0", Offset = "0x3D4CBD0", VA = "0x183D4DDD0")]
	public T IDHDEMMHIPC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public ILCCCOFCLCL(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x855FA60", Offset = "0x855E860", VA = "0x18855FA60", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(ILCCCOFCLCL FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct JCBELHJOGAG : IEquatable<JCBELHJOGAG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool PIMOBOHPGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x8561E40", Offset = "0x8560C40", VA = "0x188561E40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x8561D20", Offset = "0x8560B20", VA = "0x188561D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public bool HKFIGEDJKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x8561E80", Offset = "0x8560C80", VA = "0x188561E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int ADHKEPAEGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8561E00", Offset = "0x8560C00", VA = "0x188561E00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8561C90", Offset = "0x8560A90", VA = "0x188561C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public JCBELHJOGAG(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x8561D70", Offset = "0x8560B70", VA = "0x188561D70", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(JCBELHJOGAG FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct GGJIKNMADMM : IEquatable<GGJIKNMADMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public int OPILOJPCLPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x855E580", Offset = "0x855D380", VA = "0x18855E580")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x855E530", Offset = "0x855D330", VA = "0x18855E530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public int DLGMPGDKEDA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x855E410", Offset = "0x855D210", VA = "0x18855E410")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x855E450", Offset = "0x855D250", VA = "0x18855E450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public uint PNECFHBKHEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x855E380", Offset = "0x855D180", VA = "0x18855E380")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x855E3C0", Offset = "0x855D1C0", VA = "0x18855E3C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public GGJIKNMADMM(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x855E4A0", Offset = "0x855D2A0", VA = "0x18855E4A0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(GGJIKNMADMM FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct DGDNFAAJAMO : IEquatable<DGDNFAAJAMO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	private HDEGCCCIJEC IDCBDFKGAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8557A00", Offset = "0x8556800", VA = "0x188557A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	private JNHHJNEBHNH CHEDMDGKAAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8557BE0", Offset = "0x85569E0", VA = "0x188557BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public bool NOKGJJNAOAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8557FD0", Offset = "0x8556DD0", VA = "0x188557FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public bool OGLCKIDHJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x85577F0", Offset = "0x85565F0", VA = "0x1885577F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public bool NPJIBAJKJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x8558280", Offset = "0x8557080", VA = "0x188558280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool MKMPCNAMHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x8558060", Offset = "0x8556E60", VA = "0x188558060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public bool OPDNMJAMCMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8557E70", Offset = "0x8556C70", VA = "0x188557E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public bool EBOLEJNADJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8557760", Offset = "0x8556560", VA = "0x188557760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public bool GPIALLLNOOP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x8557CD0", Offset = "0x8556AD0", VA = "0x188557CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public bool KPPMHFBJMEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8557890", Offset = "0x8556690", VA = "0x188557890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public bool KHDFHIFHFPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8557EA0", Offset = "0x8556CA0", VA = "0x188557EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x8557B70", Offset = "0x8556970", VA = "0x188557B70")]
	public bool DBOHFJLCFAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x8558130", Offset = "0x8556F30", VA = "0x188558130")]
	public PLCNDJEJBLF ODONAEGIOJP(PLCNDJEJBLF BNIHAACOHPG)
	{
		return default(PLCNDJEJBLF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x8557A60", Offset = "0x8556860", VA = "0x188557A60")]
	public CLPADLABDGI DAFJOBMBKGP()
	{
		return default(CLPADLABDGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x85581D0", Offset = "0x8556FD0", VA = "0x1885581D0")]
	public bool OFNEGLLJFJI(CLPADLABDGI BNIHAACOHPG, [Out] CLPADLABDGI MCOHJGGHDLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public DGDNFAAJAMO(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x8553240", Offset = "0x8552040", VA = "0x188553240")]
	public static bool MIDAFINGFAP(DGDNFAAJAMO HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x8557C40", Offset = "0x8556A40", VA = "0x188557C40", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(DGDNFAAJAMO FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct ECLCKKGJKGL : IEquatable<ECLCKKGJKGL>
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static readonly ECLCKKGJKGL NPEEJKJJDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public DGCPDKIAPPI KLLPKHBOCCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x8559E30", Offset = "0x8558C30", VA = "0x188559E30")]
		get
		{
			return default(DGCPDKIAPPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public KDHLIEEPAHG MDANDEECNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x8559D10", Offset = "0x8558B10", VA = "0x188559D10")]
		get
		{
			return default(KDHLIEEPAHG);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x8559D50", Offset = "0x8558B50", VA = "0x188559D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public NGKACLCIMKM FJEHDIIFJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x8559A10", Offset = "0x8558810", VA = "0x188559A10")]
		get
		{
			return default(NGKACLCIMKM);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x8559BC0", Offset = "0x85589C0", VA = "0x188559BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public float MCMCEEADCJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x8559B30", Offset = "0x8558930", VA = "0x188559B30")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x8559940", Offset = "0x8558740", VA = "0x188559940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public Vector3 GECOOOBODNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x8559C10", Offset = "0x8558A10", VA = "0x188559C10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x8559990", Offset = "0x8558790", VA = "0x188559990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public float GGDDNAGFCHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x8559B70", Offset = "0x8558970", VA = "0x188559B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public HACLILBGPLE LJIBBLJOMOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x8559E70", Offset = "0x8558C70", VA = "0x188559E70")]
		get
		{
			return default(HACLILBGPLE);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x8559EB0", Offset = "0x8558CB0", VA = "0x188559EB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public bool AHHEHKEPPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x8559DA0", Offset = "0x8558BA0", VA = "0x188559DA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x8559F50", Offset = "0x8558D50", VA = "0x188559F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public CAHFPHJCPBO DGABKBJAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CAHFPHJCPBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public BKKIKPHPLGC FMDMLHKGGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(BKKIKPHPLGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x8559F00", Offset = "0x8558D00", VA = "0x188559F00")]
	public BDNBGBPDOEA PPCKLBGJKKF()
	{
		return default(BDNBGBPDOEA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x8559DE0", Offset = "0x8558BE0", VA = "0x188559DE0")]
	public FBCKBFCNNNP OIBBPAFNJHK()
	{
		return default(FBCKBFCNNNP);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x8559A50", Offset = "0x8558850", VA = "0x188559A50")]
	private bool DIJLEELJBPC(HACLILBGPLE FFAHAEGEIFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x8559C90", Offset = "0x8558A90", VA = "0x188559C90")]
	public void LIEFIBLBHFM(HACLILBGPLE FFAHAEGEIFG, bool BNIEEGBIIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public ECLCKKGJKGL(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x8553240", Offset = "0x8552040", VA = "0x188553240")]
	public static bool MIDAFINGFAP(ECLCKKGJKGL HGMAIPELJHM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x85571F0", Offset = "0x8555FF0", VA = "0x1885571F0")]
	public static bool GFAFFKCBFKA(ECLCKKGJKGL GENJGFGGINA, ECLCKKGJKGL KMNEIBIPMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x8559AA0", Offset = "0x85588A0", VA = "0x188559AA0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(ECLCKKGJKGL FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public readonly struct BDNBGBPDOEA : IEquatable<BDNBGBPDOEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public ECLCKKGJKGL MLPCGHEIFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(ECLCKKGJKGL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public OJDJBNOCNOE MAGKOPHJOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8553200", Offset = "0x8552000", VA = "0x188553200")]
		get
		{
			return default(OJDJBNOCNOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public BDNBGBPDOEA(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x8553240", Offset = "0x8552040", VA = "0x188553240")]
	public static bool MIDAFINGFAP(BDNBGBPDOEA HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x8553170", Offset = "0x8551F70", VA = "0x188553170", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(BDNBGBPDOEA FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DefaultMember("Item")]
public readonly struct FBCKBFCNNNP : IEquatable<FBCKBFCNNNP>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly FBCKBFCNNNP NPEEJKJJDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	private GCOIBHFPMCG DGEPLBBKKIP
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x855C1F0", Offset = "0x855AFF0", VA = "0x18855C1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public ECLCKKGJKGL MLPCGHEIFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(ECLCKKGJKGL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public GCFIDBADAPD LJPDOHBEJLO
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x855C0C0", Offset = "0x855AEC0", VA = "0x18855C0C0")]
		get
		{
			return default(GCFIDBADAPD);
		}
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x855BD70", Offset = "0x855AB70", VA = "0x18855BD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public IEnumerable<JJKAMNDBKIN> ALEDHCNMADB
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x855C250", Offset = "0x855B050", VA = "0x18855C250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public JJKAMNDBKIN ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x855B7E0", Offset = "0x855A5E0", VA = "0x18855B7E0")]
		get
		{
			return default(JJKAMNDBKIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x855BCE0", Offset = "0x855AAE0", VA = "0x18855BCE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public CAHFPHJCPBO DGABKBJAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CAHFPHJCPBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x855BEA0", Offset = "0x855ACA0", VA = "0x18855BEA0")]
	public JJKAMNDBKIN JFDMEJOLLOJ(float3? FLAPAOJCDCM, [Optional] quaternion? GKEKGHNHKDP, [Optional] Vector3? KBAEKIALOKB)
	{
		return default(JJKAMNDBKIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x855B8F0", Offset = "0x855A6F0", VA = "0x18855B8F0")]
	public JJKAMNDBKIN BFILBEHJCAP(int JJJJBEGKNIN, float3? FLAPAOJCDCM, [Optional] quaternion? GKEKGHNHKDP, [Optional] Vector3? KBAEKIALOKB)
	{
		return default(JJKAMNDBKIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x855BBB0", Offset = "0x855A9B0", VA = "0x18855BBB0")]
	public void FCAPKDJNHHB(int JJJJBEGKNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x855BC50", Offset = "0x855AA50", VA = "0x18855BC50")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public FBCKBFCNNNP(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x8553240", Offset = "0x8552040", VA = "0x188553240")]
	public static bool MIDAFINGFAP(FBCKBFCNNNP HGMAIPELJHM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x855BE90", Offset = "0x855AC90", VA = "0x18855BE90")]
	public static bool IKIADGFKNFC(FBCKBFCNNNP GENJGFGGINA, FBCKBFCNNNP KMNEIBIPMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x855BB20", Offset = "0x855A920", VA = "0x18855BB20", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(FBCKBFCNNNP FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct JJKAMNDBKIN : IEquatable<JJKAMNDBKIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public FBCKBFCNNNP LOMADPKECJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x8562500", Offset = "0x8561300", VA = "0x188562500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public float3 FEDOCAEMCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x85626D0", Offset = "0x85614D0", VA = "0x1885626D0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x8562670", Offset = "0x8561470", VA = "0x188562670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public quaternion DILMENNOHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x85627E0", Offset = "0x85615E0", VA = "0x1885627E0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x8562730", Offset = "0x8561530", VA = "0x188562730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public float3 FFPBKDOGKLE
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x8562780", Offset = "0x8561580", VA = "0x188562780")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x8562830", Offset = "0x8561630", VA = "0x188562830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public LMEPNFPGAJK IICMLMPBLOO
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x8562620", Offset = "0x8561420", VA = "0x188562620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x8562580", Offset = "0x8561380", VA = "0x188562580")]
	public void CHDMALJCAOC(FBCKBFCNNNP HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public JJKAMNDBKIN(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x8562590", Offset = "0x8561390", VA = "0x188562590", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(JJKAMNDBKIN FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct AAHAIFJBNLC : IEquatable<AAHAIFJBNLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public bool BOJOANLNLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x8552520", Offset = "0x8551320", VA = "0x188552520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public AAHAIFJBNLC(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x8552450", Offset = "0x8551250", VA = "0x188552450", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(AAHAIFJBNLC FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public readonly struct JAGLEOMKAHF : IEquatable<JAGLEOMKAHF>
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public static readonly JAGLEOMKAHF NPEEJKJJDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	private KEPJLIAIPGC DOFMJAOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x85609C0", Offset = "0x855F7C0", VA = "0x1885609C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public uint LPOOHBEFJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x8560810", Offset = "0x855F610", VA = "0x188560810")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x8560A20", Offset = "0x855F820", VA = "0x188560A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public OKJBFJAHLKK OIBHBMCBJOH
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x8560980", Offset = "0x855F780", VA = "0x188560980")]
		get
		{
			return default(OKJBFJAHLKK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x8561140", Offset = "0x855FF40", VA = "0x188561140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public float KFOCMAPLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x8561070", Offset = "0x855FE70", VA = "0x188561070")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8560F10", Offset = "0x855FD10", VA = "0x188560F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public float CHFLDOKCDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x8560ED0", Offset = "0x855FCD0", VA = "0x188560ED0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x8560AB0", Offset = "0x855F8B0", VA = "0x188560AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public ACLPPFGLGKG DNDMCONHAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x8560B00", Offset = "0x855F900", VA = "0x188560B00")]
		get
		{
			return default(ACLPPFGLGKG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x8560930", Offset = "0x855F730", VA = "0x188560930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public float DCFLMELOOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x8560A70", Offset = "0x855F870", VA = "0x188560A70")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x8561020", Offset = "0x855FE20", VA = "0x188561020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public float HGHJOLMPIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x8560E00", Offset = "0x855FC00", VA = "0x188560E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public float GKIAJGNABDB
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x8560E50", Offset = "0x855FC50", VA = "0x188560E50")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public float FMICHIGBFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x8560E90", Offset = "0x855FC90", VA = "0x188560E90")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x85608A0", Offset = "0x855F6A0", VA = "0x1885608A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public KDHLIEEPAHG NKKGNLHOBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x85612A0", Offset = "0x85600A0", VA = "0x1885612A0")]
		get
		{
			return default(KDHLIEEPAHG);
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x8560850", Offset = "0x855F650", VA = "0x188560850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public KDHLIEEPAHG PCIJPKHOIOA
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x85608F0", Offset = "0x855F6F0", VA = "0x1885608F0")]
		get
		{
			return default(KDHLIEEPAHG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x85610B0", Offset = "0x855FEB0", VA = "0x1885610B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public float BIDPLLIMEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x8561100", Offset = "0x855FF00", VA = "0x188561100")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x8561190", Offset = "0x855FF90", VA = "0x188561190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public ReadOnlySpan<TerrainGenerationLayer> IHMMLKECKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x8560F60", Offset = "0x855FD60", VA = "0x188560F60")]
		get
		{
			return default(ReadOnlySpan<TerrainGenerationLayer>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x8560CF0", Offset = "0x855FAF0", VA = "0x188560CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public ReadOnlySpan<MDCKBNLMNAM> BIDFJFJDOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x85611E0", Offset = "0x855FFE0", VA = "0x1885611E0")]
		get
		{
			return default(ReadOnlySpan<MDCKBNLMNAM>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x8560B40", Offset = "0x855F940", VA = "0x188560B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public JAGLEOMKAHF(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40")]
	public static CLPADLABDGI MIDAFINGFAP(JAGLEOMKAHF HGMAIPELJHM)
	{
		return default(CLPADLABDGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x8560C60", Offset = "0x855FA60", VA = "0x188560C60", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(JAGLEOMKAHF FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct MHKIDKKNKHJ : IEquatable<MHKIDKKNKHJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	private OFBGLLOADOH GNGDGIEHCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x8567360", Offset = "0x8566160", VA = "0x188567360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public bool GLFMCCNPDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x85674F0", Offset = "0x85662F0", VA = "0x1885674F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x85678A0", Offset = "0x85666A0", VA = "0x1885678A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public bool LDMIGDMHAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x8567BC0", Offset = "0x85669C0", VA = "0x188567BC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x8567EE0", Offset = "0x8566CE0", VA = "0x188567EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public float LMJLBOLEHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x8567AE0", Offset = "0x85668E0", VA = "0x188567AE0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x8567A90", Offset = "0x8566890", VA = "0x188567A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public bool NNDMCALFFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x8567E90", Offset = "0x8566C90", VA = "0x188567E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x8567B20", Offset = "0x8566920", VA = "0x188567B20")]
	public void JGIHMFKGLMM(int KINIEEOGPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x8567900", Offset = "0x8566700", VA = "0x188567900")]
	public bool HDEEFDHMPFA([Out] int KINIEEOGPPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x8567620", Offset = "0x8566420", VA = "0x188567620")]
	public void ENIICCKHJMK(bool KJCBNNDPGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x8567540", Offset = "0x8566340", VA = "0x188567540")]
	public bool DEHNFCMJPGK(AFACDOKHEJP FFAHAEGEIFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x8567A10", Offset = "0x8566810", VA = "0x188567A10")]
	public void HDFFJEEKJHM(AFACDOKHEJP FFAHAEGEIFG, bool BNIEEGBIIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x8567D40", Offset = "0x8566B40", VA = "0x188567D40")]
	public void KNMOCNACFKM(float GJLJJAONJCP, float MIFDKBPOLMJ, float PJMDDHBBPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x8567750", Offset = "0x8566550", VA = "0x188567750")]
	public void FGBEENBJMGI(float3 ADCENIMBAPK, quaternion BKNPIFLAOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x8567C10", Offset = "0x8566A10", VA = "0x188567C10")]
	public bool KNDNLBMKOEL([Out] float3 ADCENIMBAPK, [Out] quaternion BKNPIFLAOIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x85673C0", Offset = "0x85661C0", VA = "0x1885673C0")]
	public bool CHOFPPLKJEA([Out] float COBCPFGHACP, [Out] float OEEGOALCHAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x8567590", Offset = "0x8566390", VA = "0x188567590")]
	public void EGILPBJFJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public MHKIDKKNKHJ(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x85676C0", Offset = "0x85664C0", VA = "0x1885676C0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(MHKIDKKNKHJ FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct CAHFPHJCPBO : IEquatable<CAHFPHJCPBO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	private LMNDMENDAKD PKKAOLHGGLC
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8554B50", Offset = "0x8553950", VA = "0x188554B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	public Vector3 FEDOCAEMCFK
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x8554C10", Offset = "0x8553A10", VA = "0x188554C10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x8554A80", Offset = "0x8553880", VA = "0x188554A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	public Quaternion DILMENNOHIP
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x8555760", Offset = "0x8554560", VA = "0x188555760")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x8554DB0", Offset = "0x8553BB0", VA = "0x188554DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	public Vector3 HFBGBKOKOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x8555BA0", Offset = "0x85549A0", VA = "0x188555BA0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x85542A0", Offset = "0x85530A0", VA = "0x1885542A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	public Quaternion MNHIMFBCPKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x85544A0", Offset = "0x85532A0", VA = "0x1885544A0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x85549B0", Offset = "0x85537B0", VA = "0x1885549B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	public float CGECDOCGIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x85554F0", Offset = "0x85542F0", VA = "0x1885554F0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x85558B0", Offset = "0x85546B0", VA = "0x1885558B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	public float FABENJOFCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x85556C0", Offset = "0x85544C0", VA = "0x1885556C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public Matrix4x4 ECPILGGKIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x8554370", Offset = "0x8553170", VA = "0x188554370")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public BKKIKPHPLGC FMDMLHKGGPG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(BKKIKPHPLGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	private NKPGLIPFHAL HHDKFMGHBPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x8554120", Offset = "0x8552F20", VA = "0x188554120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x8554180", Offset = "0x8552F80", VA = "0x188554180")]
	public FHLDPOMNGOB CNAMOMPADGE()
	{
		return default(FHLDPOMNGOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x8555EB0", Offset = "0x8554CB0", VA = "0x188555EB0")]
	public void PMFEJAPFCKH([Out] Matrix4x4 GJAHLELDHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x8555190", Offset = "0x8553F90", VA = "0x188555190")]
	public void JJEFHMBLBKK([In] Vector3 JONEPNABAIM, [In] Quaternion NIALEBCNBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x8555290", Offset = "0x8554090", VA = "0x188555290")]
	public void JJEFHMBLBKK([In] RigidTransform KEAOBABINLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x8555AF0", Offset = "0x85548F0", VA = "0x188555AF0")]
	public void NPJIOHJMPME([Out] RigidTransform KEAOBABINLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x85545F0", Offset = "0x85533F0", VA = "0x1885545F0")]
	public void EGHNIJFOHPE([In] Vector3 KCJPNFAACCK, [In] Quaternion FLFBICACFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x85546F0", Offset = "0x85534F0", VA = "0x1885546F0")]
	public void EGHNIJFOHPE([In] RigidTransform JLCFMKHFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x8555A10", Offset = "0x8554810", VA = "0x188555A10")]
	public void NOJAJEGJEIG([Out] Vector3 KCJPNFAACCK, [Out] Quaternion FLFBICACFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x8555960", Offset = "0x8554760", VA = "0x188555960")]
	public void NOJAJEGJEIG([Out] RigidTransform KEAOBABINLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x8555400", Offset = "0x8554200", VA = "0x188555400")]
	public UniformTRS KHMCIOGBENP()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x8555430", Offset = "0x8554230", VA = "0x188555430")]
	public void KHMCIOGBENP([Out] UniformTRS JLCFMKHFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x8554470", Offset = "0x8553270", VA = "0x188554470")]
	public UniformTRS EAAFCKJJEDF()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x85543B0", Offset = "0x85531B0", VA = "0x1885543B0")]
	public void EAAFCKJJEDF([Out] UniformTRS KEAOBABINLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x8554030", Offset = "0x8552E30", VA = "0x188554030")]
	public Vector3 BAIHNJEHAEE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x85541D0", Offset = "0x8552FD0", VA = "0x1885541D0")]
	public void DADBNJKCFDC([In] Vector3 HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x8554E80", Offset = "0x8553C80", VA = "0x188554E80")]
	public Vector3 HIGEEIOBNPE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x85548E0", Offset = "0x85536E0", VA = "0x1885548E0")]
	public void GDJCIOOAFPD([In] Vector3 HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x8555040", Offset = "0x8553E40", VA = "0x188555040")]
	public Quaternion JBHEMIDMOKI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x8554F70", Offset = "0x8553D70", VA = "0x188554F70")]
	public void IBLBGEABHDL([In] Quaternion HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x8555C90", Offset = "0x8554A90", VA = "0x188555C90")]
	public Quaternion PGEBPHANDCB()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x8555DE0", Offset = "0x8554BE0", VA = "0x188555DE0")]
	public void PIPFNCILCMP([In] Quaternion HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x85547B0", Offset = "0x85535B0", VA = "0x1885547B0")]
	public float ENMOINNBMCL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8555350", Offset = "0x8554150", VA = "0x188555350")]
	public void KENCNPAKHOH(float HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x8555620", Offset = "0x8554420", VA = "0x188555620")]
	public float LOELCHABLDO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x8554D00", Offset = "0x8553B00", VA = "0x188554D00")]
	public void HFNIIJDDNMP(float HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x8555590", Offset = "0x8554390", VA = "0x188555590")]
	public Vector3 LLHHMKHAFDL([In] Vector3 GHKIAFFJCCO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public CAHFPHJCPBO(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x8554850", Offset = "0x8553650", VA = "0x188554850", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(CAHFPHJCPBO FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public readonly struct BICFDKMNBMC : IEquatable<BICFDKMNBMC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	private CDEAGHECHAO IANILJPKOME
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x8553440", Offset = "0x8552240", VA = "0x188553440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	private AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x8553430", Offset = "0x8552230", VA = "0x188553430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x85532F0", Offset = "0x85520F0", VA = "0x1885532F0")]
	public void HFDDEEJFBKH(string MIBLFIHKNOI, GJPCKAHFHBB HNCOOFAGEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public BICFDKMNBMC(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x8553260", Offset = "0x8552060", VA = "0x188553260", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(BICFDKMNBMC FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x8552590", Offset = "0x8551390", VA = "0x188552590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct CCOPJNMPOHD : IEquatable<CCOPJNMPOHD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	public HPPLJGHGLBJ FDCJPEKMKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x8556020", Offset = "0x8554E20", VA = "0x188556020")]
		get
		{
			return default(HPPLJGHGLBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public CCOPJNMPOHD(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x8556110", Offset = "0x8554F10", VA = "0x188556110", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(CCOPJNMPOHD FGAEAFBDBPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public readonly struct NKAJNHLOBJE : IEquatable<NKAJNHLOBJE>
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public struct ABPMMMNFIFI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private CLPADLABDGI DPODDKLLKHL;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x8552640", Offset = "0x8551440", VA = "0x188552640")]
		public ABPMMMNFIFI(CLPADLABDGI DPODDKLLKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x85525B0", Offset = "0x85513B0", VA = "0x1885525B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x8569490", Offset = "0x8568290", VA = "0x188569490")]
	public ABPMMMNFIFI CMDLJCGLGFE()
	{
		return default(ABPMMMNFIFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x8569660", Offset = "0x8568460", VA = "0x188569660")]
	public GBLNKAODILB KONIPDABDCA(Allocator GIEDOJCOPKP = Allocator.Temp)
	{
		return default(GBLNKAODILB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x85698C0", Offset = "0x85686C0", VA = "0x1885698C0")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> MBCBCLMHFMB(Allocator GIEDOJCOPKP = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x85695B0", Offset = "0x85683B0", VA = "0x1885695B0")]
	public NativeArray<NEOKJNLGPDM> IBKGNCIGJNC(Allocator GIEDOJCOPKP = Allocator.Temp)
	{
		return default(NativeArray<NEOKJNLGPDM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x8569750", Offset = "0x8568550", VA = "0x188569750")]
	public NativeArray<NEOKJNLGPDM> LMGNBNGMPAE(Allocator GIEDOJCOPKP = Allocator.Temp)
	{
		return default(NativeArray<NEOKJNLGPDM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x85699F0", Offset = "0x85687F0", VA = "0x1885699F0")]
	public INGCKODPEPI PDMAPLBJMHF(Allocator GIEDOJCOPKP = Allocator.Temp)
	{
		return default(INGCKODPEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x8569800", Offset = "0x8568600", VA = "0x188569800")]
	public INGCKODPEPI LMPBOLFCHIK(Allocator GIEDOJCOPKP = Allocator.Temp)
	{
		return default(INGCKODPEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x85693D0", Offset = "0x85681D0", VA = "0x1885693D0")]
	public INGCKODPEPI BFEMHEGIPDG(Allocator GIEDOJCOPKP = Allocator.Temp)
	{
		return default(INGCKODPEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public NKAJNHLOBJE(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x8569520", Offset = "0x8568320", VA = "0x188569520", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(NKAJNHLOBJE FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x855F4F0", Offset = "0x855E2F0", VA = "0x18855F4F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct NANGFMJKGKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int LPLHJAHBOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public int AGBBNBMGCIL;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public readonly struct LDDOIOOEBFD : IEquatable<LDDOIOOEBFD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	public NKAJNHLOBJE KBCHICIJJIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(NKAJNHLOBJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public HGEMEGGBFIE JOLJDOILEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(HGEMEGGBFIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public CCOPJNMPOHD NAJOMIJJNOM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CCOPJNMPOHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x8565330", Offset = "0x8564130", VA = "0x188565330")]
	public bool KIAPIPJCBFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x85653D0", Offset = "0x85641D0", VA = "0x1885653D0")]
	public bool NAIOHNNPDJM([Out] Exception DNLEOFNAGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public LDDOIOOEBFD(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40")]
	public static CLPADLABDGI MIDAFINGFAP(LDDOIOOEBFD HGMAIPELJHM)
	{
		return default(CLPADLABDGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x85652A0", Offset = "0x85640A0", VA = "0x1885652A0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(LDDOIOOEBFD FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x855F4F0", Offset = "0x855E2F0", VA = "0x18855F4F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public readonly struct FFBDLNJIFLA : IDisposable, IEquatable<FFBDLNJIFLA>
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static readonly FFBDLNJIFLA NPEEJKJJDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public LDDOIOOEBFD OHCGKIIBCGE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(LDDOIOOEBFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public NKAJNHLOBJE KBCHICIJJIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(NKAJNHLOBJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x855C450", Offset = "0x855B250", VA = "0x18855C450")]
	public void DNFEABGPDMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x855C4D0", Offset = "0x855B2D0", VA = "0x18855C4D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public FFBDLNJIFLA(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x855C5A0", Offset = "0x855B3A0", VA = "0x18855C5A0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "5")]
	public bool Equals(FFBDLNJIFLA FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x855C630", Offset = "0x855B430", VA = "0x18855C630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public readonly struct HGEMEGGBFIE : IEquatable<HGEMEGGBFIE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	public bool NPNMBDOAMDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x855F460", Offset = "0x855E260", VA = "0x18855F460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	public HGEMEGGBFIE(CLPADLABDGI DPODDKLLKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x85512F0", VA = "0x1885524F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x855F3D0", Offset = "0x855E1D0", VA = "0x18855F3D0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x85524E0", Offset = "0x85512E0", VA = "0x1885524E0", Slot = "4")]
	public bool Equals(HGEMEGGBFIE FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x855F4F0", Offset = "0x855E2F0", VA = "0x18855F4F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class MDOONJGJDFE
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private struct GIPEPAHPDFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Guid NMEMPCKPCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public AKOBMADBGKG FENDJOHFIMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private struct AKOBMADBGKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int HGMAIPELJHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int IJIAOFHPIOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int KHIPFJJABPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int HEDBHHDLDCM;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x8552B50", Offset = "0x8551950", VA = "0x188552B50")]
		public bool HAHEPAFIAMI([Out] NEOKJNLGPDM OALLMPFGEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x8552BF0", Offset = "0x85519F0", VA = "0x188552BF0")]
		public AKOBMADBGKG(NEOKJNLGPDM OALLMPFGEDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x85672C0", Offset = "0x85660C0", VA = "0x1885672C0")]
	public static Guid FAAHDBIOHHC(this NEOKJNLGPDM OALLMPFGEDN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x85672A0", Offset = "0x85660A0", VA = "0x1885672A0")]
	public static bool BKLOHKDGHEA(this Guid NMEMPCKPCOG, [Out] NEOKJNLGPDM OALLMPFGEDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class EDIEJMKCIAK
{
	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x855AF80", Offset = "0x8559D80", VA = "0x18855AF80")]
	public static AEBDOBPMKGB MFLMOIICLMK(this CLPADLABDGI FMFDAFLDAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x855AE10", Offset = "0x8559C10", VA = "0x18855AE10")]
	public static IJIJHKDIMIJ FDDNDPHMAON(this CLPADLABDGI FMFDAFLDAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x855AD80", Offset = "0x8559B80", VA = "0x18855AD80")]
	public static EntityManager CDPCMDMNAGE(this CLPADLABDGI FMFDAFLDAAK)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x3B7B5C0", Offset = "0x3B7A3C0", VA = "0x183B7B5C0")]
	internal static bool MCFIBFCKIIL<T>(this CLPADLABDGI FMFDAFLDAAK, bool BNIEEGBIIHG) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x855AE70", Offset = "0x8559C70", VA = "0x18855AE70")]
	public static bool IKLOEFFJFEN(this CLPADLABDGI FMFDAFLDAAK, MABMKHEOHGN HIGEDKBAGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x3B77880", Offset = "0x3B76680", VA = "0x183B77880")]
	public static bool FEDFAKACEBA<T>(this CLPADLABDGI FMFDAFLDAAK) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x3B7B460", Offset = "0x3B7A260", VA = "0x183B7B460")]
	public static bool KAKBIIKNGOK<T>(this CLPADLABDGI FMFDAFLDAAK) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x3B7B780", Offset = "0x3B7A580", VA = "0x183B7B780")]
	[ELJABFEJCMD]
	internal static NativeArray<T> OLOOLKIDJKI<T>(this CLPADLABDGI FMFDAFLDAAK, Allocator GIEDOJCOPKP) where T : struct, IBufferElementData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x3B7B870", Offset = "0x3B7A670", VA = "0x183B7B870")]
	[ELJABFEJCMD]
	public static T OOFACHMPLBJ<T>(this CLPADLABDGI FMFDAFLDAAK) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x3B78320", Offset = "0x3B77120", VA = "0x183B78320")]
	[ELJABFEJCMD]
	public static T GFNADJMNPKF<T>(this CLPADLABDGI FMFDAFLDAAK) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x3B776B0", Offset = "0x3B764B0", VA = "0x183B776B0")]
	public static bool ALEHFBPFOPH<T>(this CLPADLABDGI FMFDAFLDAAK, [Out] T HGMAIPELJHM) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x3B777D0", Offset = "0x3B765D0", VA = "0x183B777D0")]
	public static T BONPDDKOJII<T>(this CLPADLABDGI FMFDAFLDAAK) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x3B7B3E0", Offset = "0x3B7A1E0", VA = "0x183B7B3E0")]
	public static T GOINEOANNKP<T>(this CLPADLABDGI FMFDAFLDAAK) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
internal static class GPDKJJEJEKN
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[DefaultMember("Item")]
public struct GBLNKAODILB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private INGCKODPEPI HNLFFLNNKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> ANJJPNBIBOK;

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x61B79D0", Offset = "0x61B67D0", VA = "0x1861B79D0")]
	public GBLNKAODILB(INGCKODPEPI HNLFFLNNKGK, NativeArray<EntityRemapUtility.EntityRemapInfo> ANJJPNBIBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x855DF10", Offset = "0x855CD10", VA = "0x18855DF10")]
	public LocalId FEGMOCEGDME(LocalId ALGAKMGCCLO)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x855DF50", Offset = "0x855CD50", VA = "0x18855DF50")]
	public LocalId FEGMOCEGDME(int JJJJBEGKNIN)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x855DEA0", Offset = "0x855CCA0", VA = "0x18855DEA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IGILKFLNECH
{
	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMLJIJAABPJ(CLPADLABDGI MPOBGGNJMLJ, [Out] uint FMFDAFLDAAK);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IKAAMFOADLB(CLPADLABDGI MPOBGGNJMLJ, [Out] uint FMFDAFLDAAK);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MLJFGLCNIGE(CLPADLABDGI MPOBGGNJMLJ, uint FMFDAFLDAAK);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NKDFAEKJGAC(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string BMOFAPDFKAI(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BFBHJGHPINC(CLPADLABDGI MPOBGGNJMLJ, string FMFDAFLDAAK);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LKAKNPJEBBA(CLPADLABDGI MPOBGGNJMLJ, [Out] string MOHAGBMEKHD);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NCGMDAPFEDF(CLPADLABDGI MPOBGGNJMLJ, string MOHAGBMEKHD);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BCICJPBDLAP
{
	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	Guid BCBIFKAFADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	Guid JFDKJGNKBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PJHPKBPGGFJ(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task EFNMGPLHDFI(PLCNDJEJBLF ALGAKMGCCLO);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid PFONEFHDIBE(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GDFGCCONNPG(CLPADLABDGI DPODDKLLKHL, Guid NKENCNIEFON);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IDHFDKCDMLK(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task NAMIEPOMAMH(CLPADLABDGI NKJCHADOMOJ, CLPADLABDGI PJGOIMBEKPK);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BKPLEFKOEIC(CLPADLABDGI DPODDKLLKHL, NEOKJNLGPDM PABICHFPNEB);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GCNDEFOGKEL
{
	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	Guid BCBIFKAFADF
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBJBJOBHECN(NativeList<Guid> LNCDEJJPKPE, NativeList<Guid> ELPALPOGNID, NativeList<FixedString64Bytes> ABKAMLGFIEO);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EEFDHMPHFNO
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	INGCKODPEPI JGBPEAAHJHN(Allocator GIEDOJCOPKP);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	INGCKODPEPI OFCEMAOBNBP(Allocator GIEDOJCOPKP);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DPIHDJIMELM(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HKFIGEDJKOA(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CGGCBCOMMJA(CLPADLABDGI MPOBGGNJMLJ, [Out] CLPADLABDGI FAEANGEGEBM);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PIMOBOHPGHM(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PNPIAHENCGB(CLPADLABDGI MPOBGGNJMLJ, int DGMBCDDJKOF);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CLPADLABDGI LDNAHPEOKLI(CLPADLABDGI FAEANGEGEBM);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PCMLACGBDOO(INGCKODPEPI GLBGOGEKNFA, bool FCKOFOPFKFM);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HHMKNNGKJKJ(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KGHKCINPHAI(CLPADLABDGI MPOBGGNJMLJ, bool MPHIBGGCPJP);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int DIDGJAGNAGC();

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MCEJAPPPGIJ(CLPADLABDGI DPODDKLLKHL);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LAMALDPDKJM
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<CLPADLABDGI, CLPADLABDGI> HANGNNHAKDN;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<CLPADLABDGI, CLPADLABDGI> BADEECEBMFJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<CLPADLABDGI, CLPADLABDGI, CLPADLABDGI> AFJCOLLKCPG;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<CLPADLABDGI> KLACIDOHCDE;

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CGJMFMNHJEK(CLPADLABDGI DPODDKLLKHL, CLPADLABDGI BMHJAAIHHFB);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CLPADLABDGI IDJECJKAJIC(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "10")]
	INGCKODPEPI BKPEEFFMDMP(CLPADLABDGI DPODDKLLKHL, Allocator GIEDOJCOPKP);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CLPADLABDGI CCEJCKDHEIC(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ABAJFPLHIIM(CLPADLABDGI DPODDKLLKHL, Vector3 OBBBPEHENBE, Quaternion LAPDLKCLKNC);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DOMDONECMGC(CLPADLABDGI DPODDKLLKHL, float GONFABNGNBG);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool MJFFPILNGGI(CLPADLABDGI DPODDKLLKHL, [Out] CLPADLABDGI PJGOIMBEKPK);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool EECIIGDIDHI(CLPADLABDGI DPODDKLLKHL, [Out] RigidTransform BDCCPLNJOLF);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 OMAHIDPCKJN(JBENECDAAOL BCNMCDHKPLK);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion EEGJGKCLEGE(JBENECDAAOL BCNMCDHKPLK);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class CMFDGAGKGFB
{
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MLFEJDDCGOL
{
	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	object DBAMKDGNDHH
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JPCLMBMGCGI
{
	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABCCBANGCFE(CLPADLABDGI ALGAKMGCCLO, EABFHLPIJBI NLBNJKDHGFH);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMALCKBLOGO(EABFHLPIJBI NLBNJKDHGFH);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PJMMIGHHGIC(CLPADLABDGI DPODDKLLKHL, [Out] EABFHLPIJBI CMALGNGILNF);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FLDMBGKELJF
{
	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMJLICJJEAL(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeArray<CLPADLABDGI> IODPHDKIGAN();
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[Flags]
public enum LCBABNIFADO
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
public interface MCGPNAIJHKG
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public ref struct ODKPAHGJJCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ReadOnlySpan<CLPADLABDGI> BANDKEAPHFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public ReadOnlySpan<CLPADLABDGI> ANIJDNAEGEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public CLPADLABDGI EEGODGHNMOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public CLPADLABDGI DKJGJNLDCIH;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LEBLGCCCGIB(CLPADLABDGI PBDOJDILJGJ, CLPADLABDGI NAFMFPNKFGH);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NKNDNBPICOE(CLPADLABDGI IEGIIMMNDNC, bool PPPGPLMAHNI);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LMGIOODIMOH(CLPADLABDGI AMIAMCHPEJD, CLPADLABDGI OGDOKDLABLL);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GAGPPOMBLCM(CLPADLABDGI MNKEFBDJGBG, bool PPPGPLMAHNI);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ODHFBGLLDFL(CLPADLABDGI MNKEFBDJGBG);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool APKOAPGECPC(CLPADLABDGI MNKEFBDJGBG);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CLPADLABDGI CKCKABOBMGO(CLPADLABDGI IEGIIMMNDNC);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ReadOnlySpan<CLPADLABDGI> PHFBIHNJCLL(CLPADLABDGI MNKEFBDJGBG);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ReadOnlySpan<CLPADLABDGI> AEKAIDPFNLB(CLPADLABDGI MNKEFBDJGBG);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ODKPAHGJJCL KDPMIEDGHBK(CLPADLABDGI MNKEFBDJGBG, float KONMKOMCAJO, float JBANNCMKEGM);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KNADJJMKKCD(CLPADLABDGI MNKEFBDJGBG, [Out] HPNGFHINOGL BEGHOHJIGBF);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HENMFJAMFDM(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HBJBDDBGMEN(CLPADLABDGI DPODDKLLKHL);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public readonly struct MPJBPDGOFOP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly string PFLDDMDPCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly T PGFMONBPOJI;

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x5903DD0", Offset = "0x5902BD0", VA = "0x185903DD0")]
	public MPJBPDGOFOP(T PGFMONBPOJI, [Optional][CallerMemberName] string PFLDDMDPCBI)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly MPJBPDGOFOP<int> MGABBMINBFI;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public static readonly MPJBPDGOFOP<int> HFCCOJPEOGD;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static readonly MPJBPDGOFOP<int> CCKPMCFCLOE;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public enum DPGBMBDCCJA
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class OFAHODFKNOL
{
	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x14FC550", Offset = "0x14FB350", VA = "0x1814FC550")]
	public static bool IIOMAPAPCIK(this DPGBMBDCCJA GKGDEKNIOCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x1910630", Offset = "0x190F430", VA = "0x181910630")]
	public static bool BGIGHMMMPPA(this DPGBMBDCCJA GKGDEKNIOCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x31D1200", Offset = "0x31D0000", VA = "0x1831D1200")]
	public static bool OADKLKNBCPJ(this DPGBMBDCCJA GKGDEKNIOCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x14FC540", Offset = "0x14FB340", VA = "0x1814FC540")]
	public static bool HAKOGPDINGL(this DPGBMBDCCJA GKGDEKNIOCH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BLDOKMDFDCD
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public enum PINCLHEPBLP
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
	public enum ICNDIKLHKLE
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	PINCLHEPBLP IFIOPGGJJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	bool POBAPHEIPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	bool PCMBLJGJCCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	ICNDIKLHKLE AMIBFAOGPPK
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
public interface LKKHMFBGCNA
{
	[Cpp2IlInjected.Token(Token = "0x170001EC")]
	DPGBMBDCCJA CEJNLHPKGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001ED")]
	DPGBMBDCCJA BKCDCCJFPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EE")]
	DPGBMBDCCJA IMMGPMLNOKA
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EF")]
	DPGBMBDCCJA BGGJAJMLDMH
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F0")]
	DPGBMBDCCJA HBKOPJKFILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F1")]
	DPGBMBDCCJA BIICLBGFJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F2")]
	DPGBMBDCCJA HKBEFOGLFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F3")]
	DPGBMBDCCJA BMFBPFAACIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F4")]
	DPGBMBDCCJA IIIINAEDGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F5")]
	DPGBMBDCCJA LAFDDNAKMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F6")]
	DPGBMBDCCJA PMGMMLLEEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F7")]
	DPGBMBDCCJA BEBEJCAHGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F8")]
	DPGBMBDCCJA DJPGCOCIMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	DPGBMBDCCJA NLMNPDHDAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	DPGBMBDCCJA MJFDPLJPHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	DPGBMBDCCJA BHNELKLMPHA
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	DPGBMBDCCJA IBLBCJFPDPA
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	DPGBMBDCCJA LLDCIGKJHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	DPGBMBDCCJA FGENPINFLPD
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int DPMBHNJHJDJ(MPJBPDGOFOP<int> AFFIHAGMLBN);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IBKCEPLCLAA
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event NJOFFJHGNDL.DAPPMPCMHKJ GLNLFKJLLDG;

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CLPADLABDGI EBDDKJAIGNP(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "3")]
	INGCKODPEPI KPNMJOICGCN(Allocator GIEDOJCOPKP);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LMEPNFPGAJK DIPLFDKDJHI(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BKCLGMFIBPA(IEnumerable<CLPADLABDGI> HEPKNLNPJMF);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LMEPNFPGAJK PFIHPGGIPDP(CLPADLABDGI PJGOIMBEKPK, CLPADLABDGI HNLFFLNNKGK, bool NEEJCLFAKKP, CLPADLABDGI BNIHAACOHPG);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CLPADLABDGI EDCKDJLGGGP(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CPHNKAAPMCL(CLPADLABDGI DPODDKLLKHL, CLPADLABDGI PJGOIMBEKPK, bool LJCDLCNLAKI = false);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ABLPKMPPDDA(CLPADLABDGI DPODDKLLKHL, CLPADLABDGI PJGOIMBEKPK);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool IANOAGLLMJN(CLPADLABDGI AFINNENCFJO, CLPADLABDGI HGKBJJLINIA);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	INGCKODPEPI KEHPELHBJMB(CLPADLABDGI JIKGGNOOJMH);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BIKBOGANLAD(CLPADLABDGI DPODDKLLKHL, CLPADLABDGI EMFNIDKIKFJ);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	INGCKODPEPI NGHMBEFNEPH(INGCKODPEPI AMANEHLJDNA, LCBABNIFADO AEDIGFLCOAJ, Allocator GIEDOJCOPKP);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool DBLHHNIODCP(CLPADLABDGI DPODDKLLKHL, CLPADLABDGI FNOFFMCCBDL);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CLPADLABDGI IDIKCGOCCJG(CLPADLABDGI BNIHAACOHPG, CLPADLABDGI MHEHDLGGBDM);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool LKOPAFPCGFD(CLPADLABDGI BNIHAACOHPG, CLPADLABDGI MHEHDLGGBDM, [Out] CLPADLABDGI CGDGPDEJBCC);

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "17")]
	CLPADLABDGI FANDKILCLOE(CLPADLABDGI[] GLBGOGEKNFA);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "18")]
	CLPADLABDGI OOCDIMCODHE(CLPADLABDGI DPODDKLLKHL, uint LOCBGFBLGEG);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class EMLKBKDDICG
{
	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x855B220", Offset = "0x855A020", VA = "0x18855B220")]
	public static bool DIDGIOCFILP(this IBKCEPLCLAA PMABOMPCCFN, CLPADLABDGI DPODDKLLKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x855B3D0", Offset = "0x855A1D0", VA = "0x18855B3D0")]
	public static INGCKODPEPI NGHMBEFNEPH(this IBKCEPLCLAA PJFNDJALEFK, CLPADLABDGI DPODDKLLKHL, LCBABNIFADO AEDIGFLCOAJ, Allocator GIEDOJCOPKP)
	{
		return default(INGCKODPEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x855B350", Offset = "0x855A150", VA = "0x18855B350")]
	public static INGCKODPEPI KEACKIBHNMG(this IBKCEPLCLAA PJFNDJALEFK, CLPADLABDGI DPODDKLLKHL, Allocator GIEDOJCOPKP)
	{
		return default(INGCKODPEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x855B2D0", Offset = "0x855A0D0", VA = "0x18855B2D0")]
	public static INGCKODPEPI HKLLJJDJJMA(this IBKCEPLCLAA PJFNDJALEFK, CLPADLABDGI DPODDKLLKHL, Allocator GIEDOJCOPKP)
	{
		return default(INGCKODPEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x855B290", Offset = "0x855A090", VA = "0x18855B290")]
	public static INGCKODPEPI HBOKOCGJFNP(this IBKCEPLCLAA PJFNDJALEFK, CLPADLABDGI DPODDKLLKHL, Allocator GIEDOJCOPKP)
	{
		return default(INGCKODPEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x855B390", Offset = "0x855A190", VA = "0x18855B390")]
	public static INGCKODPEPI MHLEGGNEAJA(this IBKCEPLCLAA PJFNDJALEFK, CLPADLABDGI DPODDKLLKHL, Allocator GIEDOJCOPKP)
	{
		return default(INGCKODPEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x855B310", Offset = "0x855A110", VA = "0x18855B310")]
	public static INGCKODPEPI JFFIGFIEIHP(this IBKCEPLCLAA PJFNDJALEFK, CLPADLABDGI DPODDKLLKHL, Allocator GIEDOJCOPKP)
	{
		return default(INGCKODPEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x855B0C0", Offset = "0x8559EC0", VA = "0x18855B0C0")]
	public static INGCKODPEPI ABHCIDFPHLL(this IBKCEPLCLAA PJFNDJALEFK, CLPADLABDGI DPODDKLLKHL, Allocator GIEDOJCOPKP)
	{
		return default(INGCKODPEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x855B100", Offset = "0x8559F00", VA = "0x18855B100")]
	public static INGCKODPEPI ABHCIDFPHLL(this IBKCEPLCLAA PJFNDJALEFK, INGCKODPEPI DPODDKLLKHL, Allocator GIEDOJCOPKP)
	{
		return default(INGCKODPEPI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NLDCIMGIALO
{
	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x8569AB0", Offset = "0x85688B0", VA = "0x188569AB0", Slot = "0")]
	Task<LDDOIOOEBFD> HCACOFBIBDB(IHELAIDILBO HIOIAJMAFCA, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "1")]
	void IIDHFGFHIII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface JGPAKENGFEL
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event NJOFFJHGNDL.DAPPMPCMHKJ GLNLFKJLLDG;

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CLPADLABDGI EDCKDJLGGGP(CLPADLABDGI NKJCHADOMOJ);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<CLPADLABDGI> CANOHPEGADN();

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<CLPADLABDGI> OIBDLACOBJI(CLPADLABDGI PJGOIMBEKPK);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HGGIKHFJHEN(CLPADLABDGI AFNFHPFHFHO, CLPADLABDGI DGLANIMBCDF, [Out] LMEPNFPGAJK IAEPEAGINPA);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JHJBGDIKNMJ(CLPADLABDGI AFNFHPFHFHO, CLPADLABDGI JDFLEHBDHMI, [Out] LMEPNFPGAJK IAEPEAGINPA);

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FOIFFGMBABK(CLPADLABDGI AFNFHPFHFHO);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ABLPKMPPDDA(CLPADLABDGI MPCPGMDCAON, CLPADLABDGI HNDFKDHDHKN);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LMEPNFPGAJK KLJKLNKDKOL(CLPADLABDGI DPODDKLLKHL);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MEBBFMGIGNO
{
	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	bool COCNFELGHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000200")]
	bool IMABLJAADJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	bool GPKAKLBAEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EGNFDBDKABL
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KHAMKCDHFPG
{
	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIIPELBBPGK(CLPADLABDGI DPODDKLLKHL, MABMKHEOHGN HIGEDKBAGHN);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KGPKGFPCMIF(CLPADLABDGI DPODDKLLKHL, MABMKHEOHGN HIGEDKBAGHN);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface JCLBIPBLLFA
{
	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AICGKLKDKDK<string> FJLMOIGDFEB(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AICGKLKDKDK<string> LNGDJCFDLDF(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OGHKNMANHLF(CLPADLABDGI DPODDKLLKHL, AICGKLKDKDK<string> IEHEOLEINAP);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FCAFNNDDHBM(CLPADLABDGI DPODDKLLKHL, AICGKLKDKDK<string> IEHEOLEINAP);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EAFFAMBJHNI(CLPADLABDGI HMNHMIMKAGI, CLPADLABDGI NDFEPJAHJIP);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KHEMHDJNPEK
{
	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EJBFMDKCMCB JIJPLHOLFPJ(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJILJGFAPJJ(CLPADLABDGI MPOBGGNJMLJ, EJBFMDKCMCB IPLIBKINCBA);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PLIJPJPPACE(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CAMMEGNFCNB(CLPADLABDGI MPOBGGNJMLJ, bool HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AICGKLKDKDK<string> PNDOJIGJBBL(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PGOKMJOJMLJ(CLPADLABDGI MPOBGGNJMLJ, AICGKLKDKDK<string> IEHEOLEINAP);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AICGKLKDKDK<string> NALPOCHKJIP(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void INPGKJAJBGK(CLPADLABDGI MPOBGGNJMLJ, AICGKLKDKDK<string> IEHEOLEINAP);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AICGKLKDKDK<string> PODJIELCMIB(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LHIIIKDGBHL(CLPADLABDGI MPOBGGNJMLJ, AICGKLKDKDK<string> IEHEOLEINAP);

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AICGKLKDKDK<string> JMFJICCPMCM(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MCFHMFMMBAN(CLPADLABDGI MPOBGGNJMLJ, AICGKLKDKDK<string> IEHEOLEINAP);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CJJIELHKNBG(CLPADLABDGI MPOBGGNJMLJ, CLPADLABDGI GLMBLPAKFLM);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JNILILPCAIE
{
	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GBFMGJEHCLE([In] float3 BPPDJECPPGM, [In] float3 GHKIAFFJCCO, float AGKOFMHMOAG, [Out] OCDAKOHJCCB GNAHHKALKKA, [Out] CLPADLABDGI NAAPKOMAPGM);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int JEDFIBDEMCJ([In] float3 BPPDJECPPGM, float GDMMFIOGDOL, List<CLPADLABDGI> GLBGOGEKNFA);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HMPFODJGKDP(Plane[] PNEMPAGODBK, float3 BPPDJECPPGM, float3 PNJJCLMEMPP, quaternion GKEKGHNHKDP, List<CLPADLABDGI> GLBGOGEKNFA);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FKINOHKOBAO
{
	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBFMGJEHCLE([In] NativeArray<Entity> ALJPELHALEH, [In] float3 BPPDJECPPGM, [In] float3 GHKIAFFJCCO, [In] NativeArray<OCDAKOHJCCB> LJNNAAHILKH);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> JEDFIBDEMCJ([In] NativeArray<Entity> ALJPELHALEH, [In] float3 BPPDJECPPGM, float GDMMFIOGDOL);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> HMPFODJGKDP([In] NativeArray<Entity> ALJPELHALEH, [In] NativeArray<float4> FDNEEEAELCJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct LPIFFCKKIBA : JNOBALCJGHO, IEquatable<LPIFFCKKIBA>
{
	[Cpp2IlInjected.Token(Token = "0x17000202")]
	public int NELPMDCEMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xD91780", Offset = "0xD90580", VA = "0x180D91780", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000203")]
	public int ALOAEDJGJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x300A170", Offset = "0x3008F70", VA = "0x18300A170", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x300A160", Offset = "0x3008F60", VA = "0x18300A160", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x8567000", Offset = "0x8565E00", VA = "0x188567000", Slot = "8")]
	public bool Equals(LPIFFCKKIBA FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x8567050", Offset = "0x8565E50", VA = "0x188567050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct OCDAKOHJCCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float HONJHOGENBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public float3 INIBGDOOLID;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HKOBJEKALGK
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NKPGLIPFHAL
{
	[Cpp2IlInjected.Token(Token = "0x17000204")]
	AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	NECKCGPIEFK BNNMENJDFAB
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	int JFBJOMOEPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000207")]
	int LGFODCEEEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000208")]
	int CPFGOHNBCEP
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000209")]
	int LKPDIAFFOBL
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<INGCKODPEPI, NativeArray<RRObjectPrefabData>> FEDECLCLHDH;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<INGCKODPEPI> EJAHOIFKBGN;

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	INGCKODPEPI BDEMDFOJNEN();

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NCJEFIDIKOA GAFNOCBBHCG(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	RRObjectPrefabData MCPPNFMOHBL(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DNGGPLJACGF(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PLCNDJEJBLF DALIONGFIFN(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LEBAMBEDKCH(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool FEPIEOPEOCD(CLPADLABDGI DPODDKLLKHL, [Out] Transform DNNOOFELIOA);

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	CLPADLABDGI LGOGNKACHEB(NEOKJNLGPDM OALLMPFGEDN);

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool IKNBBAEIEFI(NEOKJNLGPDM OALLMPFGEDN, [Out] CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "19")]
	NEOKJNLGPDM BNBOJNJGCNL(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	INGCKODPEPI LGOGNKACHEB(NativeArray<NEOKJNLGPDM> OALLMPFGEDN, Allocator GIEDOJCOPKP, bool GBNEDBEANFN = true);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool KNGENHENLMC(NativeArray<CGMFMHBOIKJ> HAMEBFFCIEA, NativeArray<NEOKJNLGPDM> AKOJGNPOANP, NativeArray<Entity> DEDGADIJNLP, AICGKLKDKDK<BIDBFKMJJKN> MCPKLDBPECM);

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	PLCNDJEJBLF LIOHNMFDMFK();

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	PLCNDJEJBLF COLPLOCDAAG(RRObjectPrefabData HBKNEJHHAGJ, [Optional] BFDLJFNDJKD IDMGOALPCGG);

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	FJBCBBIMJGF FMMLHEAFFJB();

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	FBCKBFCNNNP OFKAHKDAFKE();

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	BDNBGBPDOEA BIKHNMIAFID(OJDJBNOCNOE FDPKABGLHNK);

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void PFOMLFEKGIK(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool FKIMHNFJOMO(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "29")]
	INGCKODPEPI CJAGHIKNOHP(INGCKODPEPI LALOIKJPCLM, Allocator GIEDOJCOPKP);

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool LHCDGKCPPOM(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool COLCCMKPAND(CLPADLABDGI DPODDKLLKHL, ComponentTypes BFJMCPLMMNO);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "32")]
	CLPADLABDGI OAKNCLCNLPK(Transform DNNOOFELIOA);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class LBNHCMHNAHB
{
	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x8564BF0", Offset = "0x85639F0", VA = "0x188564BF0")]
	internal static CLPADLABDGI CNLFBNDDPFH(this Entity DJHHEAHBFFL, NKPGLIPFHAL HNCOOFAGEMC)
	{
		return default(CLPADLABDGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x8564E50", Offset = "0x8563C50", VA = "0x188564E50")]
	public static PLCNDJEJBLF GBJBBDCMBMJ(this NKPGLIPFHAL HNCOOFAGEMC, LocalId DPODDKLLKHL)
	{
		return default(PLCNDJEJBLF);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x8565040", Offset = "0x8563E40", VA = "0x188565040")]
	public static CLPADLABDGI LGOGNKACHEB(this NKPGLIPFHAL HNCOOFAGEMC, LocalId DPODDKLLKHL)
	{
		return default(CLPADLABDGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x8564B80", Offset = "0x8563980", VA = "0x188564B80")]
	public static NEOKJNLGPDM BNBOJNJGCNL(this NKPGLIPFHAL HNCOOFAGEMC, LocalId DPODDKLLKHL)
	{
		return default(NEOKJNLGPDM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x8564CA0", Offset = "0x8563AA0", VA = "0x188564CA0")]
	public static FJBCBBIMJGF FCEPHGHHJFE(this NKPGLIPFHAL HNCOOFAGEMC, RigidTransform JLCFMKHFKNJ)
	{
		return default(FJBCBBIMJGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x8564E90", Offset = "0x8563C90", VA = "0x188564E90")]
	public static BDNBGBPDOEA LBGBIBJDFOF(this NKPGLIPFHAL HNCOOFAGEMC, OJDJBNOCNOE JBABKNDKMFA, RigidTransform JLCFMKHFKNJ)
	{
		return default(BDNBGBPDOEA);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x85650F0", Offset = "0x8563EF0", VA = "0x1885650F0")]
	public static FBCKBFCNNNP OJEKGKCMIEB(this NKPGLIPFHAL HNCOOFAGEMC, RigidTransform JLCFMKHFKNJ)
	{
		return default(FBCKBFCNNNP);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x8564E60", Offset = "0x8563C60", VA = "0x188564E60")]
	private static void JAEJKJKHKFL(PLCNDJEJBLF GFOFGFPBFCL, RigidTransform JLCFMKHFKNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal interface FDJCMJMPAAD
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HDEGCCCIJEC
{
	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	bool OCBKANONHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	CLPADLABDGI HDCHBCGFOKB
	{
		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	PLCNDJEJBLF BIAJAHBFKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event KHCHPEHIAJP JKLHOJLKGMB;

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CLPADLABDGI IDIKCGOCCJG(CLPADLABDGI BNIHAACOHPG, CLPADLABDGI MHEHDLGGBDM);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LKOPAFPCGFD(CLPADLABDGI BNIHAACOHPG, CLPADLABDGI MHEHDLGGBDM, [Out] CLPADLABDGI CGDGPDEJBCC);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BCENIHLGOLH();

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IGHMPDAONEC();

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NOKGJJNAOAP(CLPADLABDGI BNIHAACOHPG);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool EBOLEJNADJI(CLPADLABDGI BNIHAACOHPG);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public delegate void KHCHPEHIAJP(PLCNDJEJBLF HJBNJPHABAC, PLCNDJEJBLF CBFAHHGIDCO);
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class FLNNCGDPNKF
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x855CF90", Offset = "0x855BD90", VA = "0x18855CF90")]
	public static bool JKHHKGPDHCF(this HDEGCCCIJEC HPEDPAFLMJB, PLCNDJEJBLF BNIHAACOHPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x855CEB0", Offset = "0x855BCB0", VA = "0x18855CEB0")]
	public static bool JIFPCAMOAGB(this HDEGCCCIJEC HPEDPAFLMJB, CLPADLABDGI BNIHAACOHPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x855CFE0", Offset = "0x855BDE0", VA = "0x18855CFE0")]
	public static bool MKMPCNAMHNG(this HDEGCCCIJEC HPEDPAFLMJB, CLPADLABDGI BNIHAACOHPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GOABGEOLIHB
{
	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FONCPIPNIIH(NativeList<RRObjectPrefabData> BNFNBDGPLCE);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KOMIMDAFOBH
{
	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJGMCDBBPLE(PLCNDJEJBLF GFOFGFPBFCL, KIPBMIHDBPL PFAGOGPEPDI, List<PLCNDJEJBLF> LFLGOCOHDIN);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int PFBBFNNNJGN(PLCNDJEJBLF GFOFGFPBFCL, KIPBMIHDBPL PFAGOGPEPDI);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DBCIAKNGHBJ(PLCNDJEJBLF GFOFGFPBFCL, List<PLCNDJEJBLF> LFLGOCOHDIN);

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int AAEPANPJFBI(PLCNDJEJBLF KINIEEOGPPI, PLCNDJEJBLF BNIHAACOHPG, KIPBMIHDBPL PFAGOGPEPDI);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PLCNDJEJBLF MCMMGNICCDB(PLCNDJEJBLF KINIEEOGPPI, int JJJJBEGKNIN, KIPBMIHDBPL PFAGOGPEPDI);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LNAHGCIMKJO(PLCNDJEJBLF KINIEEOGPPI, PLCNDJEJBLF BNIHAACOHPG, KIPBMIHDBPL PFAGOGPEPDI);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LJMGGJMMNFH(PLCNDJEJBLF KINIEEOGPPI, PLCNDJEJBLF BNIHAACOHPG, KIPBMIHDBPL PFAGOGPEPDI);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CIPCKEEMAAB(PLCNDJEJBLF KINIEEOGPPI, KIPBMIHDBPL PFAGOGPEPDI);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ABEEOOOFMNE(PLCNDJEJBLF KINIEEOGPPI, PLCNDJEJBLF BNIHAACOHPG, KIPBMIHDBPL PFAGOGPEPDI);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BECGBDKLPAM(Entity KINIEEOGPPI, Entity BNIHAACOHPG, KIPBMIHDBPL PFAGOGPEPDI);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JPLIPBGBCJE(Entity KINIEEOGPPI, KIPBMIHDBPL PFAGOGPEPDI);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HBHCFOHEOOO(PLCNDJEJBLF BNIHAACOHPG, KIPBMIHDBPL PFAGOGPEPDI);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HMLLHLOFAJO
{
	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	CCOPJNMPOHD PIDDAAGPDND
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
	HPPLJGHGLBJ CCPJPCBKBHH(CCOPJNMPOHD OKCGKPEIJGC);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CCOPJNMPOHD NPFBNALEPED();

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CCOPJNMPOHD PCGAEHIHNAB();
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JNHHJNEBHNH
{
	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OFNEGLLJFJI(CLPADLABDGI BNIHAACOHPG, [Out] CLPADLABDGI FKIKMLLKAPK);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NNGNDBHBHPF
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<CLPADLABDGI> HJDMDLPADFA;

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EICONKDEPMJ(CLPADLABDGI JIKGGNOOJMH, bool HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JFJHDBGHCJE(CLPADLABDGI JIKGGNOOJMH, bool HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDJIHILDLHG(CLPADLABDGI JIKGGNOOJMH, int HGMAIPELJHM);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GCOIBHFPMCG
{
	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<CLPADLABDGI> MABIMBEMMBB(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CLPADLABDGI KBLHLHFFMIO(CLPADLABDGI DPODDKLLKHL, int JJJJBEGKNIN);

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int CJIECCCEKED(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GCFIDBADAPD HILKFFKKOEC(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FOEEKJMHNJO(CLPADLABDGI DPODDKLLKHL, GCFIDBADAPD ONHEEOKCMKO);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CLPADLABDGI FMEGOIDJAKH(CLPADLABDGI DPODDKLLKHL, [Optional] float3? FLAPAOJCDCM, [Optional] quaternion? GKEKGHNHKDP, [Optional] float3? KBAEKIALOKB);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CLPADLABDGI ABCKDLCOFHN(CLPADLABDGI DPODDKLLKHL, int JJJJBEGKNIN, [Optional] float3? FLAPAOJCDCM, [Optional] quaternion? GKEKGHNHKDP, [Optional] float3? KBAEKIALOKB);

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FNIPBGKDPLA(CLPADLABDGI DPODDKLLKHL, int JJJJBEGKNIN);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CKOMPOLBMJG(CLPADLABDGI DPODDKLLKHL);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JOGLEDCFNDJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface KEPJLIAIPGC
{
	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHFHDNEIEFA(CLPADLABDGI DPODDKLLKHL, ReadOnlySpan<TerrainGenerationLayer> NNIEIFKEOGA);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKIPEMPFCLE(CLPADLABDGI DPODDKLLKHL, ReadOnlySpan<MDCKBNLMNAM> NNIEIFKEOGA);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FPLHLBNANAN
{
	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	bool JHEJGHDMDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKMBDJONMPN();

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NBCGCHILOHO();

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HAHJGDFCIFM();

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BGLGLADEJNK();

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FLAFAAOMPMH();

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KLFPPGCJDFC();

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MOHAAKEJLLF();

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GHLLEECIELJ();

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NJHPDNFFGDO();

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EBNDLLAPIGA();

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KPOFNMIBOOD();

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OFEOEODBHEA();
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OFBGLLOADOH
{
	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HDEEFDHMPFA(CLPADLABDGI BNIHAACOHPG, [Out] int KINIEEOGPPI);

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGIHMFKGLMM(CLPADLABDGI BNIHAACOHPG, int KINIEEOGPPI);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ENIICCKHJMK(CLPADLABDGI BNIHAACOHPG, bool KJCBNNDPGOE);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KNMOCNACFKM(CLPADLABDGI BNIHAACOHPG, float GJLJJAONJCP, float MIFDKBPOLMJ, float PJMDDHBBPBI);

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CHOFPPLKJEA(CLPADLABDGI DPODDKLLKHL, [Out] float MIFDKBPOLMJ, [Out] float PJMDDHBBPBI);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGBEENBJMGI(CLPADLABDGI BNIHAACOHPG, float3 FLAPAOJCDCM, quaternion GKEKGHNHKDP);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KNDNLBMKOEL(CLPADLABDGI BNIHAACOHPG, [Out] float3 FLAPAOJCDCM, [Out] quaternion GKEKGHNHKDP);

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EGILPBJFJJN(CLPADLABDGI BNIHAACOHPG);
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LMNDMENDAKD
{
	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DADBNJKCFDC(Entity DJHHEAHBFFL, [In] float3 HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 BAIHNJEHAEE(Entity DJHHEAHBFFL);

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBLBGEABHDL(Entity DJHHEAHBFFL, [In] quaternion HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion JBHEMIDMOKI(Entity DJHHEAHBFFL);

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JJEFHMBLBKK(Entity DJHHEAHBFFL, [In] float3 FLAPAOJCDCM, [In] quaternion GKEKGHNHKDP);

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NPJIOHJMPME(Entity DJHHEAHBFFL, [Out] RigidTransform FOAELGPIFGE);

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EGHNIJFOHPE(Entity DJHHEAHBFFL, [In] float3 FLAPAOJCDCM, [In] quaternion GKEKGHNHKDP);

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NOJAJEGJEIG(Entity DJHHEAHBFFL, [Out] float3 FLAPAOJCDCM, [Out] quaternion GKEKGHNHKDP);

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NOJAJEGJEIG(Entity DJHHEAHBFFL, [Out] RigidTransform FOAELGPIFGE);

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KENCNPAKHOH(Entity DJHHEAHBFFL, float HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float ENMOINNBMCL(Entity DJHHEAHBFFL);

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GDJCIOOAFPD(Entity DJHHEAHBFFL, [In] float3 HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 HIGEEIOBNPE(Entity DJHHEAHBFFL);

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PIPFNCILCMP(Entity DJHHEAHBFFL, [In] quaternion HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion PGEBPHANDCB(Entity DJHHEAHBFFL);

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HFNIIJDDNMP(Entity DJHHEAHBFFL, float HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float LOELCHABLDO(Entity DJHHEAHBFFL);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PCDAMJGCPFA(Entity DJHHEAHBFFL, [Out] float4x4 GJAHLELDHFH);

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GLMFNKHJODL(Entity DJHHEAHBFFL, [In] float4x4 GJAHLELDHFH);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BIOBCIFDCDH(Entity DJHHEAHBFFL);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PDNAFBHBNKD(Entity DJHHEAHBFFL, Entity NMPEBJLLKBE, Entity HNDFKDHDHKN);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class JBKCJFHACDM
{
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PJHCHAJNNMM
{
	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGDAJMOKBID(bool KNNGNJNFEBM);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CDEAGHECHAO
{
	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMELDNCKFLO(CLPADLABDGI MPOBGGNJMLJ, AICGKLKDKDK<string> IEHEOLEINAP);

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOOGHNDNNEJ(CLPADLABDGI MPOBGGNJMLJ, AICGKLKDKDK<string> IEHEOLEINAP);

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EDCPDAOIFNM(CLPADLABDGI MPOBGGNJMLJ, AICGKLKDKDK<string> IEHEOLEINAP);

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LMFAPOOEIPO(CLPADLABDGI MPOBGGNJMLJ, AICGKLKDKDK<string> IEHEOLEINAP);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KCIDDEBNNII(CLPADLABDGI MPOBGGNJMLJ, AICGKLKDKDK<string> IEHEOLEINAP);

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BNLMKMPOKFM(CLPADLABDGI MPOBGGNJMLJ, AICGKLKDKDK<string> IEHEOLEINAP);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KEPHAOCANEG(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int JONAMGBCOOP(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int LECEGGMMNCH(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LIJJHMMHNOE<string> OODMCIJLOMD(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KLEIOKIEPKJ(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LIJJHMMHNOE<string> HPGNAEILINP(CLPADLABDGI MPOBGGNJMLJ);

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BLPJJAGDOIE(CLPADLABDGI MPOBGGNJMLJ, string MIBLFIHKNOI);

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KNNNHIDHPND(string MIBLFIHKNOI, GJPCKAHFHBB BFLHEDHKJMD);

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CLPADLABDGI CHFDPGDLIFD(string MIBLFIHKNOI);

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AFIBLJGJHGC(string MIBLFIHKNOI, GJPCKAHFHBB BFLHEDHKJMD);

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HFDDEEJFBKH(CLPADLABDGI LABDFCMEPDN, string MIBLFIHKNOI, GJPCKAHFHBB BFLHEDHKJMD);

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(Slot = "17")]
	LIJJHMMHNOE<string> AFPKIBGCPEF();
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class OFDLHCMMDPA
{
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DIPHJBNGILP
{
	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World DCLAKLOJPHN(string FNLHKHKEOMK = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World JFGFMEDLOGK(string FNLHKHKEOMK = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World ECGOPIPFNGJ(string FNLHKHKEOMK = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World OCGIKAEHEGI(string FNLHKHKEOMK = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IJIJHKDIMIJ
{
	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	World EGMMAEPJFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000210")]
	World CILGPMEJJAE
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000211")]
	EntityManager CDPCMDMNAGE
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000212")]
	bool KOBMDGOKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase GKHINLLOIMN(Type ADGMECOLKNH);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class JNJKJGGDLNM
{
	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x8562AF0", Offset = "0x85618F0", VA = "0x188562AF0")]
	public static ComponentSystemBase KBOMOPLCLJE(this World DJKOEPFGION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x3D77030", Offset = "0x3D75E30", VA = "0x183D77030")]
	public static T GKHINLLOIMN<T>(this IJIJHKDIMIJ BIGADNFIECB) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CLNCDDPFFAN
{
	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDMBPPKOAAH(NativeListAsync<Entity> LMCMKHNBDGI);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NEGKJMAINGO(OAGICBJODMH PBOHOBBFPLE);

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GJHBCHOCHJE(NativeListAsync<Entity> NCOPCHPDHMJ, bool KAOPHNGKGNA);

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NFCPIPCLLGD();

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CAIDAIBEIOA(Entity MMENCBNBOBJ);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface AJOLJDIPOCE
{
	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCDHNFNKHIJ(Collider OJDDLOEFCAJ, [Out] BOIJOIPAIPI MMPCOCHLEHG);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AAKDKOPGDEE
{
	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider BKNNLAMPHNC(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject DDGEMGCNKBK(CLPADLABDGI JDFLDHBOOMM, GameObject BLNABJHHOFA, Vector3 JONEPNABAIM, Quaternion NIALEBCNBKG);

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FEFAPPBELIC(GameObject OJDDLOEFCAJ);

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider MBPKNAABNHK<TCollider>(GameObject LGIOAHEAEJK) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AOCKNEMLMDC(Collider OJDDLOEFCAJ);

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject OHCPGDBLMNC<TCollider>(string PFLDDMDPCBI) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IMADFODCNDH LEAMKJLFKHL(CLPADLABDGI PNNNGDKMCDH, CLPADLABDGI IOAJHEECDIE, OJDJBNOCNOE HNCGBCDIMBJ, float3 LMGMBOADHEI, quaternion JFCMEFHMAPG, float3 PGJHMIHCLNJ);

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PBGHHPLMIJC(CLPADLABDGI DPODDKLLKHL, [Out] IMADFODCNDH OJDDLOEFCAJ);

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MFFKHMOCHHK(CLPADLABDGI DPODDKLLKHL, [Out] CLPADLABDGI MMENCBNBOBJ);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public enum GOAKEKGOEGL
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
public interface BKHEGJALGFC
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public struct FACHDMMDCML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int HNCGBCDIMBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GameObject BLNABJHHOFA;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBGOIOCEJMK(CLPADLABDGI DPODDKLLKHL, KFEDHNGJABP IIPKPEDLFCO, bool HPNPOBIAADK, NPGBDKBLCFB NPLHOGPFILF);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFJMKODDJII(CLPADLABDGI DPODDKLLKHL, KFEDHNGJABP IIPKPEDLFCO, bool HPNPOBIAADK, bool IAGOCMAEIKI, bool BMHAHBDKLOB);

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NBGGDDPBBMK PIHHDCMPHEO(CLPADLABDGI MMENCBNBOBJ, List<CLPADLABDGI> ENEOGGNBAHN);

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IMADFODCNDH EBLOHKNBMLC(GameObject JBLGKCPJKID, GameObject LPMBOKIMEDP);

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ELNMMMOHMPN(GameObject JBLGKCPJKID, List<GameObject> OOHNLIBMKCF);

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HIMOPFEBJBI(GameObject LPMBOKIMEDP);

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T MBPKNAABNHK<T>(GameObject LGIOAHEAEJK) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AOCKNEMLMDC(Collider OJDDLOEFCAJ);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject NCGIHJJCELI<T>(string PFLDDMDPCBI) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JBKCPBFLGAC(Collider OJDDLOEFCAJ, [Out] CLPADLABDGI KINIEEOGPPI);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OLDMKLPPKMN(CLPADLABDGI DPODDKLLKHL, [Out] BOIJOIPAIPI MMPCOCHLEHG);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<GOAKEKGOEGL> CPOAHOAIHGD(Allocator GIEDOJCOPKP = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] JKJNIMJOLHP();
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MOEODADCOFA
{
	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGFALDPOFMH(CLPADLABDGI DPODDKLLKHL, CLPADLABDGI HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKLNKCOCMLJ(CLPADLABDGI DPODDKLLKHL, CLPADLABDGI HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int ICAAMMIGMGE(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CLPADLABDGI CLANCDICICN(CLPADLABDGI DPODDKLLKHL, int JJJJBEGKNIN);

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(Slot = "4")]
	INGCKODPEPI GBLCIOFEPAJ(CLPADLABDGI DPODDKLLKHL, Allocator GIEDOJCOPKP = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MKCCGHAMIBB(CLPADLABDGI DPODDKLLKHL, object OBGCPOCPFIJ, CLPADLABDGI HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MEMCKGNJBMN(CLPADLABDGI DPODDKLLKHL, object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GBLKJCMACLP(CLPADLABDGI DPODDKLLKHL, [Out] CLPADLABDGI HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EPEFJMGANHH(CLPADLABDGI DPODDKLLKHL, float3 HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GGGPJHHHJDN(CLPADLABDGI DPODDKLLKHL, [Out] float3 HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NMOJOLDHHOP(CLPADLABDGI DPODDKLLKHL, float3 HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool COABLMDFMPD(CLPADLABDGI DPODDKLLKHL, [Out] float3 HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EPHOEJFOBCM(CLPADLABDGI DPODDKLLKHL, (Quaternion rot, Vector3 moments) FFGEJMBOODN);

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool EPFIDGNMFHA(CLPADLABDGI DPODDKLLKHL, [Out] quaternion MIKLOIFFBNA, [Out] float3 FOGFOCGMLPN);

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IEIFNBNDHMI(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 EIBPFAICEAM(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 IDNFIHKMNCB(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KMKOADDPLNP(CLPADLABDGI DPODDKLLKHL, float3 HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FHLENNDONFO(CLPADLABDGI DPODDKLLKHL, float3 HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float GENDEHOPPPF(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float EJNJPCPOIIC(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FMHHMBIFFKM(CLPADLABDGI DPODDKLLKHL, float HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LNJCHCBILIL(CLPADLABDGI DPODDKLLKHL, float HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode DMKHJOHCEJH(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LIHFNLCLPGN(CLPADLABDGI DPODDKLLKHL, CollisionDetectionMode HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(Slot = "25")]
	CNIFHCNMKAP DOBOCDKJGIH(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FEPOGJKGADN(CLPADLABDGI DPODDKLLKHL, CNIFHCNMKAP HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool KMPMOLPOGGL(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CBEMGOECMEN(CLPADLABDGI DPODDKLLKHL, bool HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(Slot = "29")]
	CLPADLABDGI EBDDKJAIGNP(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KBPNFDAPBMH(CLPADLABDGI DPODDKLLKHL, CLPADLABDGI HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	CLPADLABDGI EDCKDJLGGGP(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void CPHNKAAPMCL(CLPADLABDGI DPODDKLLKHL, CLPADLABDGI HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	PBNGAEFDFBE IPDKLGCCNKD(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void JALOICOOIAL(CLPADLABDGI DPODDKLLKHL, PBNGAEFDFBE HCJLODBPDNJ);

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool HCPGOEBDONG(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void DDEABBPNJCE(CLPADLABDGI DPODDKLLKHL, bool HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool GCLBGDEJKMP(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void PCMGIBGGMPJ(CLPADLABDGI DPODDKLLKHL, bool HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints HAEHMNFIPMC(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void JIDOCPOGFIB(CLPADLABDGI DPODDKLLKHL, RigidbodyConstraints HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float ILIMKAOCICF(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void MDJJCMGAHCG(CLPADLABDGI DPODDKLLKHL, float HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float JHCMBOAOKOB(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void GLLJMAHGJEI(CLPADLABDGI DPODDKLLKHL, float HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool NFHMMOAHAFF(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void EOPBHHDKKCL(CLPADLABDGI DPODDKLLKHL, bool HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool GHNJOPDCOMK(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void FAHLLOBOICL(CLPADLABDGI DPODDKLLKHL, bool HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void LBBNEHDKEPD(CLPADLABDGI DPODDKLLKHL, int HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(Slot = "50")]
	HJKHHJEKPOI KNGFFACHCCJ(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void JAKBPDIKFKI(CLPADLABDGI DPODDKLLKHL, HJKHHJEKPOI HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "52")]
	HDEDPMNNDDA DAMHLKOOLIP(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void LIPONLGAJJA(CLPADLABDGI DPODDKLLKHL, HDEDPMNNDDA HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float EKDPOLHGHCK(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void JGHOGNAPLOC(CLPADLABDGI DPODDKLLKHL, float HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void LCALLHBHEKD(CLPADLABDGI DPODDKLLKHL, object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void MOBIDANDIFC(CLPADLABDGI DPODDKLLKHL, object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool BLHNEPINKEA(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void NLPOPKABNKB(CLPADLABDGI DPODDKLLKHL, object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void ELAHOMFKFJC(CLPADLABDGI DPODDKLLKHL, object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool KDEKMDPBABM(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool FLGFIFHOOOP(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody JIDLPAELIGA(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void BLOCMJMEGAK(CLPADLABDGI DPODDKLLKHL, Rigidbody BKNONEHIOEE);

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void AKIIELENDBN(CLPADLABDGI DPODDKLLKHL, object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void LPMHAGFBAHA(CLPADLABDGI DPODDKLLKHL, object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool JHJELHMANAL(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void LACINEGLDNO(CLPADLABDGI DPODDKLLKHL, float3 ILLMOMMKCAB);

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void AEFMEMMDNPC(CLPADLABDGI DPODDKLLKHL, float3 IGFPHPPALII);

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool OCHOLHCOLFH(CLPADLABDGI DPODDKLLKHL, [Out] float3 ILLMOMMKCAB);

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool OPKOECBOMFL(CLPADLABDGI DPODDKLLKHL, [Out] float3 IGFPHPPALII);

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool MMHELOIBDFH(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void GBCCMBMFECO(CLPADLABDGI DPODDKLLKHL, object OBGCPOCPFIJ, bool BOENCBCIEDN);

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void LIPJDBPEGDC(CLPADLABDGI DPODDKLLKHL, bool JOCNNHCAMFI);

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void KGKBNOOAKLE(CLPADLABDGI DPODDKLLKHL);

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool LJDDAMLPKJJ(CLPADLABDGI DPODDKLLKHL);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FIILGGPLDCF
{
	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPGFHIDDNNJ(Entity AMEMDNLDIFH);

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHMNBHIAEEA(Entity AMEMDNLDIFH);

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPNCNOOJDLH(Entity AMEMDNLDIFH);
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LFJBEPBFBKH
{
	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIAFKHNCMNJ(CLPADLABDGI BNIHAACOHPG, bool DHMELENJBCO);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public delegate void INCNMGIFPDJ(AIJBJIAINBM BLDBGMKFLEO);
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public readonly ref struct AIJBJIAINBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly INGCKODPEPI LDKDBKDJAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly NativeArray<byte> ADNIDBPMOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly NativeArray<byte> AGJEBPCKJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly MABMKHEOHGN HIGEDKBAGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly int DPCGGFKANFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly Type IEGBOCGAGLL;

	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public INGCKODPEPI JBJIPBHAJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x5665330", Offset = "0x5664130", VA = "0x185665330")]
		get
		{
			return default(INGCKODPEPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public int PJDGOCCOECF
	{
		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x8552AC0", Offset = "0x85518C0", VA = "0x188552AC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000215")]
	public MABMKHEOHGN JCAIFGHKLKH
	{
		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xAB29F0", Offset = "0xAB17F0", VA = "0x180AB29F0")]
		get
		{
			return default(MABMKHEOHGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x8552B10", Offset = "0x8551910", VA = "0x188552B10")]
	public AIJBJIAINBM(INGCKODPEPI LDKDBKDJAOD, NativeArray<byte> ADNIDBPMOJD, NativeArray<byte> AGJEBPCKJCB, MABMKHEOHGN HIGEDKBAGHN, int DPCGGFKANFO, Type IEGBOCGAGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x3252420", Offset = "0x3251220", VA = "0x183252420")]
	public NativeArray<T> PLFNOOOBGOH<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x32523E0", Offset = "0x32511E0", VA = "0x1832523E0")]
	public NativeArray<T> OKHLJGJDBHD<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x32522F0", Offset = "0x32510F0", VA = "0x1832522F0")]
	public (INGCKODPEPI, NativeArray<T>, NativeArray<T>) DPMBHNJHJDJ<T>() where T : struct
	{
		return default((INGCKODPEPI, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x8552AE0", Offset = "0x85518E0", VA = "0x188552AE0")]
	public CIDCIKGJBKJ JAOFNDGNKOC()
	{
		return default(CIDCIKGJBKJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public interface DOOGJBAJEJK
{
	[Cpp2IlInjected.Token(Token = "0x17000216")]
	string EKMIMJMLJEG
	{
		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000217")]
	DOOGJBAJEJK DEMAPJKFKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	IEnumerable<DOOGJBAJEJK> PKMGEINLMGN
	{
		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface MOMCIPCCHGP
{
	[Cpp2IlInjected.Token(Token = "0x17000219")]
	DOOGJBAJEJK IMCMIFHPPJC
	{
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	NativeArray<MABMKHEOHGN> DIJGPNHCOAM
	{
		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FBKLKNDMHDD(MABMKHEOHGN HIGEDKBAGHN, [Out] DOOGJBAJEJK EBICCMLJNEM);

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FAIIODDINIJ(MABMKHEOHGN HIGEDKBAGHN, INCNMGIFPDJ MBCFAMKDEKH);

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IIOINIJEMOP(MABMKHEOHGN HIGEDKBAGHN, INCNMGIFPDJ MBCFAMKDEKH);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PNMGPEBBHJA
{
	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAIIODDINIJ(MABMKHEOHGN HIGEDKBAGHN, INCNMGIFPDJ MBCFAMKDEKH);

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIOINIJEMOP(MABMKHEOHGN HIGEDKBAGHN, INCNMGIFPDJ MBCFAMKDEKH);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class KHINGEDBLEG
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ACLEDFNEIEG
{
	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	bool DGPELEKMNLK
	{
		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	OGAFPPOPBCE AOEHHLHIAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GEHHKBMEPOF(HPPLJGHGLBJ OALLMPFGEDN, bool KPKIIAIGLPA);

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DIIDBKFFEOE(NEOKJNLGPDM OALLMPFGEDN, MABMKHEOHGN HIGEDKBAGHN);

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OBBPIFAFAIE(NativeArray<NEOKJNLGPDM> HAKCGGGNHMB);
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class MMEPFHJJDOI
{
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public readonly ref struct CIDCIKGJBKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly AIJBJIAINBM KANAIIDGHCH;

	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	public INGCKODPEPI JBJIPBHAJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x5665330", Offset = "0x5664130", VA = "0x185665330")]
		get
		{
			return default(INGCKODPEPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x8556E50", Offset = "0x8555C50", VA = "0x188556E50")]
	public CIDCIKGJBKJ(AIJBJIAINBM KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x8556D20", Offset = "0x8555B20", VA = "0x188556D20")]
	public INGCKODPEPI PLFNOOOBGOH()
	{
		return default(INGCKODPEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x8556BF0", Offset = "0x85559F0", VA = "0x188556BF0")]
	public INGCKODPEPI OKHLJGJDBHD()
	{
		return default(INGCKODPEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x8556900", Offset = "0x8555700", VA = "0x188556900")]
	public (INGCKODPEPI, INGCKODPEPI, INGCKODPEPI) DPMBHNJHJDJ()
	{
		return default((INGCKODPEPI, INGCKODPEPI, INGCKODPEPI));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class CGMNONBKPGC
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public readonly struct OGAFPPOPBCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly NativeBitArray FFIHBHBLIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly NativeParallelHashMap<NEOKJNLGPDM, int> CBMJJKPGLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly NativeParallelHashSet<HPPLJGHGLBJ> MKKBBCFMBBM;

	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	public bool CLMHNHKLNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x8569F70", Offset = "0x8568D70", VA = "0x188569F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	public bool DGPELEKMNLK
	{
		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x8569F90", Offset = "0x8568D90", VA = "0x188569F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x6237CD0", Offset = "0x6236AD0", VA = "0x186237CD0")]
	public OGAFPPOPBCE(NativeBitArray FFIHBHBLIJJ, NativeParallelHashMap<NEOKJNLGPDM, int> CBMJJKPGLOL, NativeParallelHashSet<HPPLJGHGLBJ> MKKBBCFMBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x8569D80", Offset = "0x8568B80", VA = "0x188569D80")]
	public bool DIIDBKFFEOE(NEOKJNLGPDM OALLMPFGEDN, MABMKHEOHGN HIGEDKBAGHN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NIOLEBCMJHG
{
	[Cpp2IlInjected.Token(Token = "0x17000220")]
	EHMIJFGJLBH KDPGFALOHNK
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
public interface GOCKEMDPACE
{
	[Cpp2IlInjected.Token(Token = "0x17000221")]
	int CHBBEHPCBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000222")]
	int GJFJFKDGLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEODBBAOOPP(CLPADLABDGI DPODDKLLKHL, CIBOKDDAPGP HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AIOBPENNHGA MCBELBEALLP();
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ILMMFBIKFOD
{
	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIIDMLJFPHG(World DJKOEPFGION);

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEAIOGFPMMO(World DJKOEPFGION);

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase KBAEHEIODJP(World DJKOEPFGION);

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LFAKFGFPLHK(World DJKOEPFGION);

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FOHCCGADKPO(World DJKOEPFGION);

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LEMEGJMOLDO(World DJKOEPFGION);

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JNCODDOGHGH(World DJKOEPFGION);

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> FGINMAHBGEP();
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BHJOFIIBIEN
{
	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNKBEDNEPCC(CLPADLABDGI JIKGGNOOJMH, bool HGMAIPELJHM);
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public readonly struct BIPCKOFHBMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly IEnumerable<DLNPJAMPHEG> JJPHDMFIAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly IReadOnlyList<GameObject> IABHCNIFBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly IReadOnlyList<int> EIAJCCILBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly IReadOnlyList<(NEOKJNLGPDM, NEOKJNLGPDM)> BCEJJGJMGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly int ADBMMCONAEN;
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public struct CBLLKDMIBKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public InventionIdData FMFDAFLDAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public InventionInstanceIdData FPIFCBCKHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public bool KGCINBMGLMA;

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x8555FD0", Offset = "0x8554DD0", VA = "0x188555FD0")]
	public CBLLKDMIBKP(long FMFDAFLDAAK, Guid FPIFCBCKHCM, bool KGCINBMGLMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[ServiceLifetime(Lifetime.Application)]
public interface KGPDANKDLON
{
	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LDDOIOOEBFD ECKPKCPLGMG(IHELAIDILBO AAADMOPBEBN, int KDKEOFJAODJ = 0, bool JGGOJONACKK = false);

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FFBDLNJIFLA FKJADCCEHPJ(IHELAIDILBO AAADMOPBEBN, CLPADLABDGI PJGOIMBEKPK, [In] UniformTRS OONLPNGGAOF, MLFKDKMIKON LMECDMOBOFM, [Optional] CBLLKDMIBKP JBELGILIPOH, bool KJOFEKEBAKA = true, bool JGFBKEMBCIO = false, bool JGGOJONACKK = false, bool BMODHLPHCLL = false);

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KMCJALDLNNE BGNDCDLHIGC();

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KMCJALDLNNE JJDNEEANCCL(INGCKODPEPI GLBGOGEKNFA, [In] UniformTRS CPLPBLMFMLK, [Optional] MLFKDKMIKON ODHHIPJJOMM);

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KIAPIPJCBFA(CLPADLABDGI OBALOIBKGEI);

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NAIOHNNPDJM(CLPADLABDGI OBALOIBKGEI, [Out] Exception DDMPALIOLHO);

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<NEOKJNLGPDM> IBKGNCIGJNC(CLPADLABDGI OBALOIBKGEI, Allocator GIEDOJCOPKP);

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<NEOKJNLGPDM> LMGNBNGMPAE(CLPADLABDGI OBALOIBKGEI, Allocator GIEDOJCOPKP);

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	INGCKODPEPI PDMAPLBJMHF(CLPADLABDGI OBALOIBKGEI, Allocator GIEDOJCOPKP);

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	INGCKODPEPI LMPBOLFCHIK(CLPADLABDGI OBALOIBKGEI, Allocator GIEDOJCOPKP);

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	INGCKODPEPI IMDKKICKJFC(CLPADLABDGI OBALOIBKGEI, Allocator GIEDOJCOPKP);

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> MBCBCLMHFMB(CLPADLABDGI OBALOIBKGEI, Allocator GIEDOJCOPKP);

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DNDNCKGDHNI(CLPADLABDGI OBALOIBKGEI);

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int NONDDFOIKPB(CLPADLABDGI OBALOIBKGEI, int FFKCBONKOOM);
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[ServiceLifetime(Lifetime.Application)]
public interface POMCHMJONBJ
{
	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0xF6D470", Offset = "0xF6C270", VA = "0x180F6D470", Slot = "0")]
	bool PJKONFNNFCK(object PEKEABNFGOF, KKIENGDGBHL KCMCAMOABPI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public static class HFMLDKGBOOP
{
	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x855F2F0", Offset = "0x855E0F0", VA = "0x18855F2F0")]
	public static bool PJKONFNNFCK(this POMCHMJONBJ PJFNDJALEFK, object PEKEABNFGOF, [Out] KKIENGDGBHL KCMCAMOABPI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public enum FFBLOOMEPLM : byte
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
public interface KKIENGDGBHL
{
	[Cpp2IlInjected.Token(Token = "0x17000223")]
	IFIOAPJLFKJ FOJLLEMFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000224")]
	JCHCDPDFDDM PEDHJHMKLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000225")]
	bool CCLECGDLNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000226")]
	bool JJMDJANACLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object BGAKFAJMBBA();

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x10D4110", Offset = "0x10D2F10", VA = "0x1810D4110", Slot = "5")]
	(JCHCDPDFDDM, object) MAIHNFFLOAF()
	{
		return default((JCHCDPDFDDM, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "6")]
	(NEOKJNLGPDM, JCHCDPDFDDM) MLFHPOPMJFO()
	{
		return default((NEOKJNLGPDM, JCHCDPDFDDM));
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "7")]
	EKJAGHLACDO<(NEOKJNLGPDM, JCHCDPDFDDM)> IFCPEPLPHOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x10D4110", Offset = "0x10D2F10", VA = "0x1810D4110", Slot = "8")]
	(ADGKOLDKGHI, byte[]) OIPJEKCCLJB()
	{
		return default((ADGKOLDKGHI, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x10D4110", Offset = "0x10D2F10", VA = "0x1810D4110", Slot = "9")]
	(DMKPPKIIPNE, byte[]) ODJBFMILHCM()
	{
		return default((DMKPPKIIPNE, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x10D4110", Offset = "0x10D2F10", VA = "0x1810D4110", Slot = "10")]
	T OBPKDNDEBIK<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public static class NHFNDJPBGAL
{
	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x8568F90", Offset = "0x8567D90", VA = "0x188568F90")]
	public static bool NPDFDHHDFNC(this KKIENGDGBHL HBOAEALHJLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface BBFCDPDHHBA : EKJAGHLACDO<FJBDCPJKLML>
{
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[DefaultMember("Item")]
public interface EKJAGHLACDO<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000227")]
	T ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000228")]
	int PJDGOCCOECF
	{
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public enum IFIOAPJLFKJ : byte
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
public enum ADGKOLDKGHI : uint
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
public static class CEBJAHFPCLH
{
	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x85566E0", Offset = "0x85554E0", VA = "0x1885566E0")]
	public static NEOKJNLGPDM PFPMLLALOFL(this DMOGMEMJLCA KANAIIDGHCH)
	{
		return default(NEOKJNLGPDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x8556430", Offset = "0x8555230", VA = "0x188556430")]
	public static NEOKJNLGPDM EJGKOOMLJNM([In] this DMOGMEMJLCA KANAIIDGHCH)
	{
		return default(NEOKJNLGPDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x84DD5C0", Offset = "0x84DC3C0", VA = "0x1884DD5C0")]
	public static NEOKJNLGPDM OAJLHNLMJMG(this DMOGMEMJLCA KANAIIDGHCH)
	{
		return default(NEOKJNLGPDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x84DD5C0", Offset = "0x84DC3C0", VA = "0x1884DD5C0")]
	public static ViewId DNFPGHEDJIB(this DMOGMEMJLCA KANAIIDGHCH)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x8556510", Offset = "0x8555310", VA = "0x188556510")]
	public static FixedString64Bytes NGAJMBFOLFG(this HPPLJGHGLBJ FMFDAFLDAAK)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x85561A0", Offset = "0x8554FA0", VA = "0x1885561A0")]
	public static FixedString64Bytes EIDJKENJPNB(this NEOKJNLGPDM FMFDAFLDAAK)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x8556480", Offset = "0x8555280", VA = "0x188556480")]
	public static FixedString32Bytes NGAJMBFOLFG(this Entity DJHHEAHBFFL)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BCGIAOHIPBK : ILJACFPOAHI
{
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public enum IDDFGNKEHMH
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
public interface HIKBJKNLAPL
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<object> JDFNINOHOLK;

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "2")]
	void KPMKHPKLOMB(object PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "3")]
	void FOKKEBBFFCM(DMKPPKIIPNE MKPEOGPFEFH, ReadOnlySpan<byte> OBBABGHFJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	void KPNOJOOEAKL(ADGKOLDKGHI ADGMECOLKNH, ReadOnlySpan<byte> OBBABGHFJAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DLFBJEGHMID
{
	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DMKPPKIIPNE IDDMBCCGGCM(ReadOnlySpan<byte> OBBABGHFJAB);
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KECKELNINDO
{
	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KFBKCEBBELK(DMKPPKIIPNE OPGJHIOADCK, ReadOnlySpan<byte> OBBABGHFJAB);

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LMMEEKFNEIE(ReadOnlySpan<DMKPPKIIPNE> IOIANNLAHMB);
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public struct JDFPGOLBKOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public DMKPPKIIPNE MKPEOGPFEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public ReadOnlyMemory<byte> OBBABGHFJAB;
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public struct DMKPPKIIPNE
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public static DMKPPKIIPNE ADDDCFJGCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public HPPLJGHGLBJ PAPIFPAPPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public int JBLLOOEHNPO;

	[Cpp2IlInjected.Token(Token = "0x17000229")]
	public static HPPLJGHGLBJ IGEAKFAKMLC
	{
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x85596C0", Offset = "0x85584C0", VA = "0x1885596C0")]
		get
		{
			return default(HPPLJGHGLBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x566B460", Offset = "0x566A260", VA = "0x18566B460")]
	public DMKPPKIIPNE(HPPLJGHGLBJ PAPIFPAPPKH, int JBLLOOEHNPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x8559770", Offset = "0x8558570", VA = "0x188559770")]
	public static bool IKIADGFKNFC([In] DMKPPKIIPNE CHAEOFDBIAH, [In] DMKPPKIIPNE EBEGEKLHGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x85595C0", Offset = "0x85583C0", VA = "0x1885595C0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x8559710", Offset = "0x8558510", VA = "0x188559710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x8559810", Offset = "0x8558610", VA = "0x188559810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x8559800", Offset = "0x8558600", VA = "0x188559800")]
	public void MLOAOPFMIPK([Out] HPPLJGHGLBJ KDPNMEKECKM, [Out] int JBLLOOEHNPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public static class EIEJMGHOCKC
{
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public struct DLNPJAMPHEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public Guid NMEMPCKPCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public string MLPOJPAGPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public Vector3 FLAPAOJCDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public Quaternion GKEKGHNHKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public Vector3 KBAEKIALOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public int AGJMFLKMGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public BFDLJFNDJKD ONHEEOKCMKO;

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x85594A0", Offset = "0x85582A0", VA = "0x1885594A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public enum KLPCKKJOBHI
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
public static class NIODONAPPKB
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x85693B0", Offset = "0x85681B0", VA = "0x1885693B0")]
	public static bool MKCMGMBLCNC(this KLPCKKJOBHI ADGMECOLKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x85693A0", Offset = "0x85681A0", VA = "0x1885693A0")]
	public static bool FEMLLKEAAEM(this KLPCKKJOBHI ADGMECOLKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x8569390", Offset = "0x8568190", VA = "0x188569390")]
	public static bool BPPGDHMAJCE(this KLPCKKJOBHI ADGMECOLKNH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
[Flags]
public enum PCKFNAEKDKB
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
public interface MLFKDKMIKON
{
	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OOPEAKLEHAB([In] Guid HNLFFLNNKGK, [Out] Guid AGEFPDLPNLM);
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
[Flags]
public enum PECKIIHECDM
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
public interface KMCJALDLNNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	BBGNGBEFDNP GGGMCCODMHE
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString LHNPJLIGKKH();
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public enum BLBJFMEKHOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct LPEMGGPALNP : ISystemStateComponentData, IComponentData, IEquatable<LPEMGGPALNP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public float3 BOPNBJFLGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public float3 BNCABPGHBGD;

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x8566F80", Offset = "0x8565D80", VA = "0x188566F80", Slot = "4")]
	public bool Equals(LPEMGGPALNP FGAEAFBDBPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EBFHPNDODNJ
{
	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<CLPADLABDGI> BBJEPIBEHDH(CLPADLABDGI MNKEFBDJGBG);

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JBHBCANKOJJ(CLPADLABDGI HHIJJIELJAP, [Out] CLPADLABDGI ECOOFFLNEFE);
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MIENIBMBPDG
{
	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OMHFDFBLINA(long FGABFPCMAHA);

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EAGLJIDCOGL(NativeParallelHashSet<long> DAKCMPFFPHJ);

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CIKMPHMNIMM(World DJKOEPFGION, NativeParallelHashMap<Guid, long> FJCEIGNGHBI);

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ACCPHJGPKCA(NEOKJNLGPDM OALLMPFGEDN);

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MDOCFCGMIHI(NEOKJNLGPDM OALLMPFGEDN, [Out] Guid GJHODONMPCP, [Out] long FGABFPCMAHA);

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LPNCADODKKA(NEOKJNLGPDM OALLMPFGEDN, Guid GJHODONMPCP, long FGABFPCMAHA);

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MCKCBCGKJOK(Guid GJHODONMPCP);

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DGIJLAPCGFB(Guid GJHODONMPCP, [Out] int COAJDDFJCNP, [Out] int MCEJEPPJBBD);

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FLIPNDPLFPN(Guid GJHODONMPCP, int COAJDDFJCNP, int MCEJEPPJBBD);

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BHCNDDONEGC(Guid GJHODONMPCP);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class EDFFLPDHNEN
{
	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public EDFFLPDHNEN()
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
