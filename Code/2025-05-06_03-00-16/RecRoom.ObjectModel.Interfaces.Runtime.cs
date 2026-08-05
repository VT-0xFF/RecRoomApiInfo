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
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA8C0", Offset = "0x7CB90C0", VA = "0x187CBA8C0", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MEHDNGAKJBI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7CBAB60", Offset = "0x7CB9360", VA = "0x187CBAB60")]
	public static void ANECEEFHFBD(this Rigidbody JPDCKBNMJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7CBACE0", Offset = "0x7CB94E0", VA = "0x187CBACE0")]
	public static void ANECEEFHFBD(this Rigidbody JPDCKBNMJLM, Vector3 MGGGDMCCMGB, Quaternion PHAGKHNDLGD, Vector3 MAGHCFIDEFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct DPONIGJFOLB : IReadOnlyList<FGFPKLDJIEL>, IEnumerable<FGFPKLDJIEL>, IEnumerable, IReadOnlyCollection<FGFPKLDJIEL>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct AKKGPGDEMNP : IEnumerator<FGFPKLDJIEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly EFICJEHFEEE KIJJLOBIFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator GDPKJELKNKD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FGFPKLDJIEL IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7CA9E90", Offset = "0x7CA8690", VA = "0x187CA9E90", Slot = "4")]
			get
			{
				return default(FGFPKLDJIEL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7CA9E40", Offset = "0x7CA8640", VA = "0x187CA9E40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4FBDC00", Offset = "0x4FBC400", VA = "0x184FBDC00")]
		public AKKGPGDEMNP(EFICJEHFEEE KIJJLOBIFNN, NativeArray<LocalId>.Enumerator GDPKJELKNKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9D80", Offset = "0x7CA8580", VA = "0x187CA9D80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9DC0", Offset = "0x7CA85C0", VA = "0x187CA9DC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9E00", Offset = "0x7CA8600", VA = "0x187CA9E00", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly IMKLBBCIIKG EKNJAMPDKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> GAEDEONJGAN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FGFPKLDJIEL EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD90", Offset = "0x7CAC590", VA = "0x187CADD90", Slot = "4")]
		get
		{
			return default(FGFPKLDJIEL);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7CAD1D0", Offset = "0x7CAB9D0", VA = "0x187CAD1D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int BOFAINLJPDH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EFICJEHFEEE HIBEMMMBGIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7CAD180", Offset = "0x7CAB980", VA = "0x187CAD180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GJDKFIAMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IIAMENEAPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7CAD8E0", Offset = "0x7CAC0E0", VA = "0x187CAD8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> LDHAKGIGABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2DBCB00", Offset = "0x2DBB300", VA = "0x182DBCB00")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> AINLGCOCJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7CAD230", Offset = "0x7CABA30", VA = "0x187CAD230")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7CADAC0", Offset = "0x7CAC2C0", VA = "0x187CADAC0")]
	public DPONIGJFOLB(int CFHPBCCHEDC, EFICJEHFEEE KIJJLOBIFNN, Allocator KKCJNCNIICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7CADAB0", Offset = "0x7CAC2B0", VA = "0x187CADAB0")]
	public DPONIGJFOLB(IMKLBBCIIKG EKNJAMPDKID, NativeArray<LocalId> GAEDEONJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7CADB70", Offset = "0x7CAC370", VA = "0x187CADB70")]
	public DPONIGJFOLB(IMKLBBCIIKG EKNJAMPDKID, NativeArray<Entity> GAEDEONJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD00", Offset = "0x7CAC500", VA = "0x187CADD00")]
	internal DPONIGJFOLB(EFICJEHFEEE KIJJLOBIFNN, NativeArray<Entity> OOCEMABKIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7CADBE0", Offset = "0x7CAC3E0", VA = "0x187CADBE0")]
	internal DPONIGJFOLB(EFICJEHFEEE KIJJLOBIFNN, NativeArray<LocalId> GAEDEONJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7CADC50", Offset = "0x7CAC450", VA = "0x187CADC50")]
	public DPONIGJFOLB(EFICJEHFEEE KIJJLOBIFNN, int IMNFCKGEMOH, Allocator KKCJNCNIICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7CADA00", Offset = "0x7CAC200", VA = "0x187CADA00")]
	public DPONIGJFOLB(DPONIGJFOLB IFBFBOJICFG, Allocator KKCJNCNIICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD4E0", Offset = "0x7CABCE0", VA = "0x187CAD4E0")]
	public void IBCENFPGIMP(List<FGFPKLDJIEL> GIPAMJGJGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD7F0", Offset = "0x7CABFF0", VA = "0x187CAD7F0")]
	public void LAMJHDKJBCP(int FPEOONOJHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD840", Offset = "0x7CAC040", VA = "0x187CAD840")]
	public DPONIGJFOLB LMNLEEHCNJH(Allocator KKCJNCNIICO)
	{
		return default(DPONIGJFOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD390", Offset = "0x7CABB90", VA = "0x187CAD390")]
	public Span<FGFPKLDJIEL> FDAGFKAJDLE()
	{
		return default(Span<FGFPKLDJIEL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD750", Offset = "0x7CABF50", VA = "0x187CAD750")]
	public DPONIGJFOLB ICJNIDCOAJJ(int MLFBDFDDHEO, int IMNFCKGEMOH)
	{
		return default(DPONIGJFOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD350", Offset = "0x7CABB50", VA = "0x187CAD350", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD290", Offset = "0x7CABA90", VA = "0x187CAD290")]
	public AKKGPGDEMNP DPNIJJHCOGM()
	{
		return default(AKKGPGDEMNP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD920", Offset = "0x7CAC120", VA = "0x187CAD920", Slot = "6")]
	private IEnumerator<FGFPKLDJIEL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD990", Offset = "0x7CAC190", VA = "0x187CAD990", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HHDAFKHIIBB
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x37B8060", Offset = "0x37B6860", VA = "0x1837B8060")]
	public static JMGGLJLNFLA<T> ABHDAECJBDL<T>(this DPONIGJFOLB GGBFBJAOFOK) where T : Component
	{
		return default(JMGGLJLNFLA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct FALCLEJOKEC : IList<FGFPKLDJIEL>, ICollection<FGFPKLDJIEL>, IEnumerable<FGFPKLDJIEL>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OLEBOAMLINE : IEnumerator<FGFPKLDJIEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly EFICJEHFEEE KIJJLOBIFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator GDPKJELKNKD;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FGFPKLDJIEL IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7CBF9C0", Offset = "0x7CBE1C0", VA = "0x187CBF9C0", Slot = "4")]
			get
			{
				return default(FGFPKLDJIEL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7CBF970", Offset = "0x7CBE170", VA = "0x187CBF970", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4FBDC00", Offset = "0x4FBC400", VA = "0x184FBDC00")]
		public OLEBOAMLINE(EFICJEHFEEE KIJJLOBIFNN, NativeArray<LocalId>.Enumerator GDPKJELKNKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF8B0", Offset = "0x7CBE0B0", VA = "0x187CBF8B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF8F0", Offset = "0x7CBE0F0", VA = "0x187CBF8F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF930", Offset = "0x7CBE130", VA = "0x187CBF930", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EFICJEHFEEE KIJJLOBIFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> GAEDEONJGAN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FGFPKLDJIEL EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0690", Offset = "0x7CAEE90", VA = "0x187CB0690", Slot = "4")]
		get
		{
			return default(FGFPKLDJIEL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0780", Offset = "0x7CAEF80", VA = "0x187CB0780", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0010", Offset = "0x7CAE810", VA = "0x187CB0010", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GJDKFIAMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0010", Offset = "0x7CAE810", VA = "0x187CB0010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> LDHAKGIGABK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2DBCB00", Offset = "0x2DBB300", VA = "0x182DBCB00")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KFFGFCMACFL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0580", Offset = "0x7CAED80", VA = "0x187CB0580")]
	public FALCLEJOKEC(EFICJEHFEEE KIJJLOBIFNN, Allocator KKCJNCNIICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0600", Offset = "0x7CAEE00", VA = "0x187CB0600")]
	public FALCLEJOKEC(EFICJEHFEEE KIJJLOBIFNN, int IMNFCKGEMOH, Allocator KKCJNCNIICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0190", Offset = "0x7CAE990", VA = "0x187CB0190")]
	public DPONIGJFOLB NMBEIPAKAAG()
	{
		return default(DPONIGJFOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7CAFCA0", Offset = "0x7CAE4A0", VA = "0x187CAFCA0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7CAFCE0", Offset = "0x7CAE4E0", VA = "0x187CAFCE0", Slot = "13")]
	public bool Contains(FGFPKLDJIEL BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7CAFD70", Offset = "0x7CAE570", VA = "0x187CAFD70", Slot = "14")]
	public void CopyTo(FGFPKLDJIEL[] CPIDEKBKOPO, int KNKIMBLHNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7CAFC20", Offset = "0x7CAE420", VA = "0x187CAFC20", Slot = "11")]
	public void Add(FGFPKLDJIEL BLFLGKHLJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7CB00E0", Offset = "0x7CAE8E0", VA = "0x187CB00E0", Slot = "7")]
	public void Insert(int FPEOONOJHML, FGFPKLDJIEL BLFLGKHLJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7CB02F0", Offset = "0x7CAEAF0", VA = "0x187CB02F0", Slot = "15")]
	public bool Remove(FGFPKLDJIEL BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0050", Offset = "0x7CAE850", VA = "0x187CB0050", Slot = "6")]
	public int IndexOf(FGFPKLDJIEL BLFLGKHLJNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7CB02A0", Offset = "0x7CAEAA0", VA = "0x187CB02A0", Slot = "8")]
	public void RemoveAt(int FPEOONOJHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7CAFFD0", Offset = "0x7CAE7D0", VA = "0x187CAFFD0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CAFF40", Offset = "0x7CAE740", VA = "0x187CAFF40")]
	public OLEBOAMLINE DPNIJJHCOGM()
	{
		return default(OLEBOAMLINE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7CB03C0", Offset = "0x7CAEBC0", VA = "0x187CB03C0", Slot = "16")]
	private IEnumerator<FGFPKLDJIEL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7CB04A0", Offset = "0x7CAECA0", VA = "0x187CB04A0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AGKHEMIBBDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FGFPKLDJIEL LBNDDGMBJFF(FGFPKLDJIEL GAEDEONJGAN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HHHPNJMOJJM : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface OCIEFLKOBFM : COHPFCBCCHD, CGIJAKAAGPG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	MHDFNKHNBGK PFHHCKGIPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IMKLBBCIIKG FLLPLEDEMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface CGIJAKAAGPG
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool ACOHCKOENBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface FMDCFHDNDCG
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LAHHBNNPKCM(bool OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNEMBDPLFBE();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface BNOJHMIOIDB
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool NHMPONKHLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CILEFNEKLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool MDNJFPDKDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool PNMHOFOLMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NDCGACPDPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CKBOBCGDLCM(bool BCOFJMBGKOE);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool IAJGJEANAEL(ByteString EKCOFEBFMJL);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NMMFDHBHHAC();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HBLNFMCOMGB();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ECNDBAFIHHO();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface KOJGGCMNOGM
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	FOMOPIDDKEF PFHHCKGIPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	FPPCGPBHIGA BMLJCKKJMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	IKKDIMICPHE OOBEEBOPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	OCIEFLKOBFM FBKJPNJAPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	MGBDCACEGOF GBEFBDELKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	BNOJHMIOIDB EOKLPODFDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	DPLIOIGJMLF MLPGBFHPNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	AKFLFPOJBPN KKCEDMMDHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	GODLKGCKBJN COJFENFFCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KOMJNIJGCJJ GIKNDILAGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	LGODHAOEKND NIDPFHNHICI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	LOIGJFJHEDG IKMJJFACNLO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	EFICJEHFEEE HIBEMMMBGIH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	DCOIIMPPJDP GODPPDHCCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	IKJIEEDFKNA LBMCOGFDEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	BIPKHHKACLN IOPAEPLJDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	LJMLLJCCPAD HKHFFLCDOJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DBFKAHIMBKK ABKFOAEILOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	HGPBHOIABME JLHNBHIBKKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NJNHJACBCAD MAMLJEBAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	OLEKALOLFKN PLJNMHHNEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	EFEKNHONLLK KPGFCGNHKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	FDGEPCBPMOO CKKCGMJFOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	FMDDHDAPDGK LNIMCOFCLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	KGJFFJIGIDO CCGBAGHJNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	HDBIMJGHPFI KJNAIHBFEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	ADLHIHAEEOL IPIIAIHEDDP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GLMBECBONIF LMLBJIJDIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	NNGFBEACHAB DFMFPMCMALA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	LKDBPLEOIHK PLMPBOEMGBM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ADPIECNHEBO JMBFLJADOKL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	FHKJIGHACNJ POMJOMHKPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PNGMEOJDNHP BJFBJCGCLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	BAKEHHONAJF GOJJLICECOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	DBJIFOGNHIO GBIJFCDHELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(IGFNLOKLJBE))]
public readonly struct FGFPKLDJIEL : IComparable<FGFPKLDJIEL>, IEquatable<FGFPKLDJIEL>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly FGFPKLDJIEL HCANDHABHHO;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int JDEGADLJMJH = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int EKOOOPLKLEK = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int EFMDCAMKLCH = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int BGCPAKJNFOG = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId DGLFHMAFDAJ;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public EFICJEHFEEE HIBEMMMBGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7CAA690", Offset = "0x7CA8E90", VA = "0x187CAA690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public OCIEFLKOBFM FBKJPNJAPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1010", Offset = "0x7CAF810", VA = "0x187CB1010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public LocalId JNPFDGFGLEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7CB11A0", Offset = "0x7CAF9A0", VA = "0x187CB11A0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	internal IMKLBBCIIKG FLLPLEDEMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1070", Offset = "0x7CAF870", VA = "0x187CB1070")]
		get
		{
			return default(IMKLBBCIIKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool IPJBOCLFEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0EF0", Offset = "0x7CAF6F0", VA = "0x187CB0EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private bool IGEAFMDOJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0EA0", Offset = "0x7CAF6A0", VA = "0x187CB0EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1330", Offset = "0x7CAFB30", VA = "0x187CB1330")]
	public FGFPKLDJIEL(EFICJEHFEEE MFPEPKIDKOA, LocalId DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB13F0", Offset = "0x7CAFBF0", VA = "0x187CB13F0")]
	public FGFPKLDJIEL(IMKLBBCIIKG EKNJAMPDKID, LocalId DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
	public JAIEPPMCFLB LFIKMKJHPHC()
	{
		return default(JAIEPPMCFLB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0E20", Offset = "0x7CAF620", VA = "0x187CB0E20")]
	public static LocalId FGIKKMMHFBO(FGFPKLDJIEL IFHJAMIIJFB)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0E60", Offset = "0x7CAF660", VA = "0x187CB0E60")]
	public static Entity FGIKKMMHFBO(FGFPKLDJIEL IFHJAMIIJFB)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1080", Offset = "0x7CAF880", VA = "0x187CB1080")]
	public static bool NIDGPKKMDPO(FGFPKLDJIEL BINANFFLHIK, FGFPKLDJIEL NOAPPAEGHOH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7CB11E0", Offset = "0x7CAF9E0", VA = "0x187CB11E0")]
	public static bool ONONOJDPAAN(FGFPKLDJIEL BINANFFLHIK, FGFPKLDJIEL NOAPPAEGHOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1200", Offset = "0x7CAFA00", VA = "0x187CB1200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0C90", Offset = "0x7CAF490", VA = "0x187CB0C90", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0BA0", Offset = "0x7CAF3A0", VA = "0x187CB0BA0", Slot = "4")]
	public int CompareTo(FGFPKLDJIEL PGPJMFPAKOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "5")]
	public bool Equals(FGFPKLDJIEL PGPJMFPAKOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class POHPKGJMNEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7CBFB70", Offset = "0x7CBE370", VA = "0x187CBFB70")]
	public static EPFBCAMMJCA KJMEHAIEIAD(this FGFPKLDJIEL PNHCNFOFAFI)
	{
		return default(EPFBCAMMJCA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class IGFNLOKLJBE
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct IMKLBBCIIKG : IEquatable<IMKLBBCIIKG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte EKNJAMPDKID;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] HAIKNNMBBDO;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static EFICJEHFEEE KLMOAIGLGPB;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static OCIEFLKOBFM LEKJIHOCDFK;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static EFICJEHFEEE[] MJFFMINFEPD;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static OCIEFLKOBFM[] FPCHNPCHEOK;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> DIAHJIEGGHL;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public OCIEFLKOBFM FBKJPNJAPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB6750", Offset = "0x7CB4F50", VA = "0x187CB6750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public EFICJEHFEEE DFIOMGDLCBM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB60C0", Offset = "0x7CB48C0", VA = "0x187CB60C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6B20", Offset = "0x7CB5320", VA = "0x187CB6B20")]
	static IMKLBBCIIKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2976410", Offset = "0x2974C10", VA = "0x182976410")]
	internal IMKLBBCIIKG(byte OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5880", Offset = "0x6BE4080", VA = "0x186BE5880", Slot = "4")]
	public bool Equals(IMKLBBCIIKG PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5CC0", Offset = "0x7CB44C0", VA = "0x187CB5CC0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xF136D0", Offset = "0xF11ED0", VA = "0x180F136D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6A60", Offset = "0x7CB5260", VA = "0x187CB6A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7CB66B0", Offset = "0x7CB4EB0", VA = "0x187CB66B0")]
	private static EFICJEHFEEE KNEDFABNICJ(byte EKNJAMPDKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6990", Offset = "0x7CB5190", VA = "0x187CB6990")]
	private static OCIEFLKOBFM OEFJIFLOJBN(byte EKNJAMPDKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6830", Offset = "0x7CB5030", VA = "0x187CB6830")]
	private static object MMGKJGMHGME(byte EKNJAMPDKID, object[] MGEDIIGJIGC, object LHCNPHOLELG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6A30", Offset = "0x7CB5230", VA = "0x187CB6A30")]
	private static int OEKHLPOIKKM(byte EKNJAMPDKID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6A40", Offset = "0x7CB5240", VA = "0x187CB6A40")]
	private static int OJLHPLKOFMD(byte EKNJAMPDKID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6390", Offset = "0x7CB4B90", VA = "0x187CB6390")]
	private static (int, int) JKPNGPFLIMP(byte EKNJAMPDKID)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6A50", Offset = "0x7CB5250", VA = "0x187CB6A50")]
	private static byte PGODJNKJGEP(int JLNEBEJFOHB, int FPEOONOJHML)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6410", Offset = "0x7CB4C10", VA = "0x187CB6410")]
	internal static IMKLBBCIIKG JNEAPGDNFGC(OCIEFLKOBFM MJEJPGIMDNP, EFICJEHFEEE EHALGOCJDLB)
	{
		return default(IMKLBBCIIKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7CB61A0", Offset = "0x7CB49A0", VA = "0x187CB61A0")]
	internal static void IMKDBAIPGDE(IMKLBBCIIKG EKNJAMPDKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5D60", Offset = "0x7CB4560", VA = "0x187CB5D60")]
	private static void FGAEKLACLEP(int CFHPBCCHEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum IPDOEBOBKGH
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
public interface PGNDFNIONIE
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool EJMKHNKNBFM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool IDOBOIFHAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool MGCBGDDMCMN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool DCEFAKCDOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool POHMDJODDDP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LHMLKPCJLKO
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DBEFEFPPMCL(IHAEEMBLIGK PMKEELMHMLA, int FPEOONOJHML);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HMAEEDBFJKH(IHAEEMBLIGK AAJANDEJHCA, int FPEOONOJHML);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FAAMJOGLFIH : IHAEEMBLIGK, PGNDFNIONIE
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int EPAGNICOKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NIMDIAKNKBL(LBACFFIHDLK AAMAJMKCBNJ, int FPEOONOJHML);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface IHAEEMBLIGK : PGNDFNIONIE
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum MDPCCFOCPFG
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
	bool EHPGFGJPDNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool EGHHJKBBOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool JILKBODNPFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface LBACFFIHDLK
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool CJLPJFNNCCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	INNMCPGDHCO JOMNJMOOMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	EHJLIFLDLPO KPCBMBOIFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float3 COFBFGOOFOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	quaternion PHMBAJJGPAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float3 BDDFJFCLMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	BPKIIKGALAC AHJGKHIHKBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	EMNBMFIJODE GEHPAEKDJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float FKJMKHIOOMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float3 GNKAJCNAHJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float MDDJOJPINPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	MGFGEDENDIF OMAELGJELAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface AICKIBMPAHM
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float3 CHPCAADKHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float3 KLAJACPANNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion DNBOAHGEBNP(float3 CHLKIEMAELF);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface EHJLIFLDLPO
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool NNBCPAEDGCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool CCBOMDCEPLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool BPOLINDOIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	float HEALHAGNOCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	int DMLIMHEEOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int CGMOKNHDMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CBCHHNKNLGI(AICKIBMPAHM AAMAJMKCBNJ, int FPEOONOJHML);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.Application)]
public interface DKKAFKPIGGH
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Guid EELIAAMEOBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FBCCMPONOOL(Guid LAPNHIHIGLC, Guid OPPFCAMGFJA, Guid FOBOMAACFMO);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task DPPLLKLGMCI(Guid LAPNHIHIGLC, Guid[] FOPDMKKOMHK, Guid FOBOMAACFMO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid JMJJGICJIOG(Guid FOEJGIIEFNC);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task FMIDBIBNCNM(FGFPKLDJIEL NDJBGDKPEMC);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OFKIDIDLHJE(Guid FOEJGIIEFNC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JMHCFJPCJOJ(CIGNFMOLPHH LLGDANBMMBL, Guid EAOCPBPEOJB);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PFMDPHLBDLH(Guid FOEJGIIEFNC, bool BCOFJMBGKOE);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface LEFFBBHDGKI
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface DBEPPKJPBOE
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CIOCOLMGEBA(GameObject JHJKHABPALK, GameObject OFCDMPHPKIH, int NNHGELLNEAO);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface KPLFMCLMBFA
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "0")]
	void HMIBHPODPKP(bool CEHDHOOIGBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface FPPCGPBHIGA
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	KPLFMCLMBFA HNGGPHNELAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	AGGLFGGGIBA DNBNHIABJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	GLIAMKPGLJM LOEKGKDPOAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	NMEJEAKIHGI PHNNICLMECM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	EAFEELAANAC NOGIBDOIPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	MBMNPKMJLHA JLJEIDGOHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	GIANHHGDCJE LOMAOJFBPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	CMJAAMJACMN KKDHMGJEFPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface AGGLFGGGIBA
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	string OOLIAFMHHOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface LFADMAONKDK
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COOJKIJNOLO(Action GFMBHCHPLDH, bool CNLKBKNGNIC);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BNNPAAEOINF(string GLGOHIJMLFB);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int FADAAMKHIIM(string GLGOHIJMLFB, int LHCNPHOLELG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KCNPEHHMKKM([Out] bool OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KIINELPOONH([Out] bool OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LEANBMKACGA([Out] int OPMIAMEJKDH);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface GLIAMKPGLJM
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "0")]
	void GCCEHEBBHLA(bool BCOFJMBGKOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface NMEJEAKIHGI
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid KEHPAECINIA;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid BPFENHCDIDJ;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid MAKFMAPIGMM;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid OEPIPFJGEBF;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool IBEFAEOPIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool OMKIBPIKKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool IKPHJEMJJKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDDB0", Offset = "0x7CBC5B0", VA = "0x187CBDDB0", Slot = "3")]
	string[] KPHKDIPBFJI(DKLAEGBPMFH IJAMCKPECNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MFGHNDHFOLF();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDD80", Offset = "0x7CBC580", VA = "0x187CBDD80", Slot = "5")]
	Guid FBCALFKMKIO(Guid JFOPNGFECMK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KAJFPJDFEOH(DKLAEGBPMFH IJAMCKPECNH);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NPHCGHMCOII(DKLAEGBPMFH IJAMCKPECNH, NativeArray<JDGEJHLCMOC> LLEFCIILDPE, NativeList<UniformTRS> ADOKJHFPLGO);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int HBPAAJEBICD(Guid BGPPHEMBCAA);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GIHPAICNOKL(string OLMKGDACLDI, [Out] Guid BGPPHEMBCAA);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string AIINCHHMEKP(Guid BGPPHEMBCAA);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool PGBOMICLDAH(RRObjectPrefabData KGPONPBIBOF, [Out] LocalId EAALLGNPDMK);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JMGGLJLNFLA<byte[]> OICKBAMCNHL(NativeArray<JDGEJHLCMOC> OHIANKLKAKK);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GBODLFFIBED(byte[] EPONNBFFLDB);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GameObject OBLMLILDKMH(string OLMKGDACLDI);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PNHLCPKALLE(Transform POFBAOBKAGL, RRObjectPrefabData EKEBMKILAGN, EKBDCGJJOMD KLNHOILIBHH);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool HCEHLHDEDID(DKLAEGBPMFH IJAMCKPECNH, NativeParallelHashMap<Guid, LocalId> NNABMNJCKPK, [Out] Exception GEIIPKBBOEI);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DDAHDGPILHP(DKLAEGBPMFH IJAMCKPECNH, NativeParallelHashMap<Guid, LocalId> NNABMNJCKPK, [Out] NativeArray<LocalId> OOCEMABKIJN, [Out] NativeArray<LocalId> KNGEPMJCFBL, [Out] NativeArray<AuthoredLocalPoseData> NFPIKGOCIBE, Allocator KKCJNCNIICO);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "18")]
	void POPMAIPPLMD(DKLAEGBPMFH PDNEBCPKAAP, NativeArray<int> NKDBAHNOGCM, JNOBHPMEBLN<GameObject> NBEMKLHDNKM, JMGGLJLNFLA<GameObject> KMDHGAKGGCP, IPDOEBOBKGH ANBLFOHBKMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PFHOJHDIOJD();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "20")]
	void LHMKDNGLNIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "21")]
	void HEPICEACHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "22")]
	bool DKCKKOGJDFG(DKLAEGBPMFH IJAMCKPECNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "23")]
	LHMLKPCJLKO ALAIPLDNIML(DKLAEGBPMFH IJAMCKPECNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "24")]
	void IIOBOGDENBE(Guid DPEKEOGLAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "25")]
	bool HOJIJADIJHA(Guid DPEKEOGLAOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDE40", Offset = "0x7CBC640", VA = "0x187CBDE40")]
	static NMEJEAKIHGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface LONMHPLNFOG
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	long MBPCJKPBAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	long OKIJAKPGEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface EAFEELAANAC
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool ADAEIDAFINM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool FJEEEBCNAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int JIDJLPNJOBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	int OPHONDFMJHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	int KMODJJBFMDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool IAMDBHGIOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	int MKLGMCLKBJH
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "6")]
	void IDJJEOPAFHA(MDPOJJFDCFF KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
	void PEOHCFIGLHD(bool LHLBMFCHIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "8")]
	bool DLGCCPGOBEB(NDBHNEPADKO OJPIEODNKAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "9")]
	void CJBJKOCACHE(object JDGDKOENECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "10")]
	void IGAOOBGJCCI(object JDGDKOENECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "11")]
	void NJMPHCAMHNB(object ALLFIKNKLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "12")]
	void CGJKAIIHFIJ(object ALLFIKNKLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "13")]
	void GGBCOFPFKAL(NativeArray<ViewId> LODHBOGNHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "14")]
	void OEMJPCOIAME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "15")]
	void PGPEGFBHEOK(FOELPGKCNLK PIJHKCJDAHO, ReadOnlySpan<byte> NFNBKNAJBPN, NDBHNEPADKO JBNEOFFGAMD, bool FMHINBEMMHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "16")]
	void PGPEGFBHEOK(FOELPGKCNLK PIJHKCJDAHO, ReadOnlySpan<byte> MBPLBFCDGMH, bool FMHINBEMMHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "17")]
	void PGPEGFBHEOK(FOELPGKCNLK PIJHKCJDAHO, ReadOnlySpan<byte> MBPLBFCDGMH, ReadOnlySpan<byte> COBJLBHNGBK, bool FMHINBEMMHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "18")]
	void MCHCAMDEIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "19")]
	void OFAGHGMIBLB(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "20")]
	void IJEEOPDFBBN(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "21")]
	void LAPMMNJHCIA(Dictionary<object, object> DGGJDJNKHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "22")]
	void EKCFKOHKDFB(NativeList<EPFBCAMMJCA> HMGMHNLDFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "24")]
	void OMJCMCKHHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "25")]
	void NCJNMMIPFIC(List<object> NAEDIAJJFEH, int IFOFOJHAFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "26")]
	void IPPGHCEHKCI(int HAGACLBAONE, object BKLKAFKNCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "27")]
	void LEEMKFIJCCB(NDBHNEPADKO OJPIEODNKAI, Dictionary<object, object> OMHBAAPJDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "28")]
	void GOCJGLJFFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "29")]
	void OMCAHBAIGPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KGJDENFEKJM
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8450", Offset = "0x7CB6C50", VA = "0x187CB8450")]
	public static AEPGLFLBBID OBPMNGBNAIG(this EAFEELAANAC MHBIGPFAJHC, object JILOCOLKOMJ)
	{
		return default(AEPGLFLBBID);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct AEPGLFLBBID : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EAFEELAANAC MHBIGPFAJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object JILOCOLKOMJ;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9B20", Offset = "0x7CA8320", VA = "0x187CA9B20")]
	public AEPGLFLBBID(EAFEELAANAC MHBIGPFAJHC, object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9AD0", Offset = "0x7CA82D0", VA = "0x187CA9AD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.Application)]
public interface FMPMPIELLNE
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ServiceLifetime(Lifetime.Application)]
public interface MBMNPKMJLHA
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct ECMGDELHLDL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private MBMNPKMJLHA AAJKOOGAMAK;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7CADED0", Offset = "0x7CAC6D0", VA = "0x187CADED0")]
		public ECMGDELHLDL(MBMNPKMJLHA AAJKOOGAMAK, string OJJDJJMGEHH, string IEKJIOEBJDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7CADE10", Offset = "0x7CAC610", VA = "0x187CADE10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct JGIEFKNOFIL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private MBMNPKMJLHA AAJKOOGAMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task BFOIMBMKJIA;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7A90", Offset = "0x7CB6290", VA = "0x187CB7A90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "0")]
	void IKIBGCAAAPB(string NJAAPDELBNN, float DJFBMECKBEL = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "1")]
	void PLFKNNDENJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFJCDCOJELL(bool LNLAKBHPGKH, string OJJDJJMGEHH, string IEKJIOEBJDP);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "3")]
	void KBLCKAGMBIM(string NJAAPDELBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class FPKGEMFFHGM
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB15C0", Offset = "0x7CAFDC0", VA = "0x187CB15C0")]
	public static MBMNPKMJLHA.ECMGDELHLDL JCBHFMAHDPO(this MBMNPKMJLHA MHBIGPFAJHC, string OJJDJJMGEHH, string IEKJIOEBJDP)
	{
		return default(MBMNPKMJLHA.ECMGDELHLDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[ServiceLifetime(Lifetime.Application)]
public interface FFGLMJIKAOE
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HPLLKPEONGF(GameObject KJMBGAPFJAM);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MADNMKICMEJ(GameObject KJMBGAPFJAM);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DHPJMBKFPOJ(int OJPIEODNKAI);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object BJDPBJJNFND(FGFPKLDJIEL DGLFHMAFDAJ, GameObject KJMBGAPFJAM, Action<FGFPKLDJIEL, int> NELMOECDPJP);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJOKMAHGPMN(GameObject KJMBGAPFJAM, object HPKFDDPOFCB);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[ServiceLifetime(Lifetime.Application)]
public interface HBIGBEJGKFL
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LIJGMGKAKKG(object PNHCNFOFAFI, NativeList<byte> NFNBKNAJBPN);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object MPBEICGIKAG(NativeArray<byte> NFNBKNAJBPN);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.Application)]
public interface KGJJGPHPBLB
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool EICENHJGIAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate BJBNEHCGOPH(GJEDOGGJDGG GOAAKCMIDIK, Action<GJEDOGGJDGG> NELMOECDPJP);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GCBLHDMOLNJ(GJEDOGGJDGG GOAAKCMIDIK, Delegate NELMOECDPJP);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate KEIEKJPJGFG(GJEDOGGJDGG GOAAKCMIDIK, Action<GJEDOGGJDGG> NFPMENOGMDO);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GDMJILFOABO(GJEDOGGJDGG GOAAKCMIDIK, Delegate NELMOECDPJP);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JAPKJEKLGAB(GJEDOGGJDGG GOAAKCMIDIK);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GJEDOGGJDGG GKKPAIBNPOD(GameObject KJMBGAPFJAM);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface PIEAJBHNKPP
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int BFGDHCELOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	int MCJAPEBPLBL
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool ADAEIDAFINM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool BDDDOHLAGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool CEMIDMDILHH
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FGFPKLDJIEL JHDDFPCDKPF(int OJPIEODNKAI);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface GIANHHGDCJE
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool NHMPONKHLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface HOJAHAKCPLA
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	OBHDPEBCHIG FFJELFFNNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	OJMGMPCIMIF AFDMIKHOJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool LOMBKPENEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DBGFCPALKDE(Transform POFBAOBKAGL);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IBCLHJDJCDB(Transform POFBAOBKAGL, KKHCPEKNJIC GCHGGPONOCH);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FMGPCGNNIDK(Transform POFBAOBKAGL, HFLHFCIMFNP POCCMBPNGEN);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
public interface CMJAAMJACMN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action CKONLHCANMN;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
public interface FBHOFFJGFBB
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KBJFPMOJBID();
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.Application)]
public interface CFLEBAKJHHG
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NHKMFDMEEAH(GameObject KJMBGAPFJAM, CBEOOPEFCFB PDMHLHGPOEN, GPENBGAGNGF HIJEKAGJENN);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BNONAMHLKBO(FGFPKLDJIEL DGLFHMAFDAJ, bool EHJHAFHOALP, float3 HOCJBGALBBL, quaternion CNHPIDGMGIL);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IHHLMDMBLAL(DPONIGJFOLB LKMCKKFCIDL);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCDBGBJFIEK(JAIEPPMCFLB PIDPEOCOGMC, JAIEPPMCFLB ALLFIKNKLHM, OCDLEPLDLBO KJHADNKKPBJ);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OCNNPHOEPEJ(JAIEPPMCFLB PIDPEOCOGMC, OCDLEPLDLBO KJHADNKKPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PIINLDIOONA(DPONIGJFOLB MAJJEEJJKLB);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject AKAKMBKNOEH(Guid BOCOKFDDIDC);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OBDNGLJPINJ(NKCKAAGEAMB MDOFGLOOKBP);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct BCPAMJCIANE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> NFNBKNAJBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle EKNJAMPDKID;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA060", Offset = "0x7CA8860", VA = "0x187CAA060")]
	public BCPAMJCIANE(ReadOnlyMemory<byte> LLKGFCLBHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA020", Offset = "0x7CA8820", VA = "0x187CAA020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum JNACEKPOEJN
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
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct DKLAEGBPMFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString EFLIJFJLBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object PFDBPAEPGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object DPLDPPKJEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> AMAKJPNMIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool BBNJEHANHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public CDOANDEPEMK.AKHNKGHCFLJ? MDICFPOLDGH;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD040", Offset = "0x7CAB840", VA = "0x187CAD040")]
	public DKLAEGBPMFH(ByteString EFLIJFJLBNA, [Optional] object PFDBPAEPGGN, [Optional] object DPLDPPKJEIE, [Optional] IEnumerable<string> AMAKJPNMIPJ, bool BBNJEHANHHF = true, [Optional] CDOANDEPEMK.AKHNKGHCFLJ? MDICFPOLDGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct FNBGGPLAMCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object JGGLFPNHAPE;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct JDGEJHLCMOC
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[Flags]
	public enum DPINCLNIFHA
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
	public RRObjectPrefabData FLJMGGPFPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid OLBCGDKCLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid FDMKNGPIPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid CEPDNEOGPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid KDHCIMFJPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public DPINCLNIFHA ENMPGGCMLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 NMIGAPCDJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int JIENEFJJAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public DNFBILKEBPE LOJGBCNFHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int NOHKGOPGNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int DHJLCCIPLHI;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Guid FKBCEPONPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4FBE4F0", Offset = "0x4FBCCF0", VA = "0x184FBE4F0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public bool OFLDGFNEGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7A80", Offset = "0x7CB6280", VA = "0x187CB7A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public bool AECKGHDMNDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7A60", Offset = "0x7CB6260", VA = "0x187CB7A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool GAIOMCDPEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7A70", Offset = "0x7CB6270", VA = "0x187CB7A70")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct KCJAOCLKLBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal readonly FNBEHAODJLB MLFBDFDDHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly FNBEHAODJLB HDGKPCMCJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly uint PDABAFBMKMD;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB81F0", Offset = "0x7CB69F0", VA = "0x187CB81F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct MOMCECKIENM
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal readonly KCJAOCLKLBB GFMBHCHPLDH;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3D90", Offset = "0x7CB2590", VA = "0x187CB3D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct HLFCHIGEAFG
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal readonly KCJAOCLKLBB GFMBHCHPLDH;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3D90", Offset = "0x7CB2590", VA = "0x187CB3D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct LGJIKAFODKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly uint PDABAFBMKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly bool IAHCMALOLOJ;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA820", Offset = "0x7CB9020", VA = "0x187CBA820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct FNBEHAODJLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal int BFKGIFAKMAP;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1560", Offset = "0x7CAFD60", VA = "0x187CB1560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[ServiceLifetime(Lifetime.Application)]
public interface MCDFIMAJGCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	DKDGJCGDNBL PHMOGNCGJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface CIGNFMOLPHH
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface CEOHBNHJGBA
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class MIBNCGOCFBI
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x38C1980", Offset = "0x38C0180", VA = "0x1838C1980")]
	public static JAIEPPMCFLB LFIKMKJHPHC<T>(this T DGLFHMAFDAJ) where T : CIGNFMOLPHH
	{
		return default(JAIEPPMCFLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7CBAE10", Offset = "0x7CB9610", VA = "0x187CBAE10")]
	public static MonoBehaviour CBCJOCHIMDP(this CIGNFMOLPHH DGLFHMAFDAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7CBAE90", Offset = "0x7CB9690", VA = "0x187CBAE90")]
	public static GameObject KHPLFMGJOON(this CIGNFMOLPHH DGLFHMAFDAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface DFCGDHAEDBM : CIGNFMOLPHH
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(FGFPKLDJIEL GHMCDKKCGHO);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface DOKNGHMHEGM : CIGNFMOLPHH
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface JBJEOPODDJF
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate void PLJACGHLGCC(KKDMEOCPFPE MBFMPICHGMH);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event PLJACGHLGCC DJBONNEEGDL;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface GJGNAFKMGCM
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface DJCCIDBLCMI
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface KNHIBECPCDK
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(FGFPKLDJIEL LENJAJKGOLA);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool FOEBHFBALNN);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ANEDPHJHOME(FGFPKLDJIEL GOKHBEHMPCJ);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface BCPDPDJAJPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(PHIEGKANMEI JLDPJBJCDAA);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface PHIEGKANMEI
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	GameObject KJMBGAPFJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Transform POFBAOBKAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	GDKBCAGCEIA EBGAJCBGFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool ECLCJLCFKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BAFJMAFEHAL(GDKBCAGCEIA JLPKBNIJDEI);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MBPKKAEDNLN GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class LEHCNACOKIP
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA490", Offset = "0x7CB8C90", VA = "0x187CBA490")]
	public static void AMNCNMOFMEN(this PHIEGKANMEI MHNKLADFOHL, EKBDCGJJOMD KLNHOILIBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface GDKBCAGCEIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Rigidbody OPNCMGGOPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	PHIEGKANMEI IGDDOKKFMMP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	GameObject KHPLFMGJOON
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Transform FCHHAJKLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	GDKBCAGCEIA BKMKKMCIDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	GDKBCAGCEIA DFJAHCLMMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	int LKGPMNCFJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	bool EEIMJJONDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	bool JAPKJEKLGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	bool CCLBBOJOHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	CHJDOPIOJPF DJGPCKEJFPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	MDAEMGHHEEI IFOLNHGDNCK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	float MKNFODOJMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Vector3 PNALLFEIODC
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Vector3 OPLKOCLBGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	Vector3 KNJCODDIFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	Vector3 KCFLMICDHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	bool INADBBBPAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool EBEGBNALIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	bool BFMNHDHEHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	bool PPODHFIDBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 AOFPKPBCAPC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 FDLOOIMHJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Vector3 MJDHBOMHLJE
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Vector3 GFEIFHPPKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	float OKBOIFJHIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	float LCGEHHPDACH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	Vector3 GBLDNHNDBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	Quaternion HNBPIOHMHKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	float ANELGFOKONF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	float PJKJFEBLNAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool MODDEKJEOHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	LDLKAPLIJLM EOGPKINPGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	bool MBOANJLCFCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	Transform IGFDKOONDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Vector3 GLHOKEIGHFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	float CAHFINAIIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	float DFEDMDDOOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	Quaternion IMPNJHKBDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	Vector3 CHPCAADKHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	Quaternion OIHKBFCJFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	RigidbodyConstraints EKHJBHKHECD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	bool NKBIAPCOCPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	CollisionDetectionMode BMKFHFJKBKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	bool FDPGOPGHNPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event FNDIPFLKNAB MCDJNNMAMAF;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event FNDIPFLKNAB EFLOAFEPOOM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event FNDIPFLKNAB AGMDLEMNFKM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event FNDIPFLKNAB HPCMGAOPDNG;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event FNDIPFLKNAB KJDBBLBEOGB;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FNDIPFLKNAB EDKPLACGCKE;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event FNDIPFLKNAB JGIIEHNDEEM;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event NDDIPIPMLIO DOGMIKHPCAE;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<GLBLJMJHHNB, GLBLJMJHHNB> HPCPGOPELBG;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "26")]
	GDKBCAGCEIA CMOFFOOHDIE(int FPEOONOJHML);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void ODEPOCEJIHB((Quaternion rot, Vector3 moments) ADLDOCGHNOD);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void AEBHHIOLPOG();

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void LFPKMPBIEJN();

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void FPHEFBGHLOM();

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void EKMOEIKANHO();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void POODEKDDHKA();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void GDNIECKCIEP(GDKBCAGCEIA OPMIAMEJKDH, bool NHEENLIEFAC = false);

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void KDFHBOFOEFL(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void HBAECMBAOIC(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 DCDLPLHNFEJ(Vector3 DIPBPPFCBBL);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 AAGLFKAIHBB(Vector3 AJKHHBKHKFM);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void EOJNKAGEINB();

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void BDHEJHPCKND();

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void LPJCCGPGAKO();

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void FOMOFHDHOLK(Vector3 ADFNPAHJJPN, Vector3 EFJBLAGMOBF);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void GGBDGHLCOHD(Vector3 JCNJOFMBACI, Vector3 FHCAMOOFEPF);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void FGJKGGCGJIE(Vector3 LJIHODIHHNH);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void EKLPHNIANMH(BEKOKAGGBFN INGIIIHLDGC, Vector3 PPKNLPOPFLE, float GBPBCCOFJFK, float MDBPJKOKEGF = 8f, float AOJEEBFLHCB = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void EJAHPKKMCPJ(FBDAOBLHIEH GMLICJILPOE, Vector3 IFMNFMEAKID, float NCNCGHGIJLC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void KCKBDILFFOO(FBDAOBLHIEH GMLICJILPOE, Vector3 PMHMEKBKJJA, float OLCPAEAGNDC = 7f, float KIJDFDGNDME = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 FHCGODLNJHA(Vector3 OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 BJGHADGMPFA(Vector3 OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void EEJKMNNJIJI();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void ICLGNMJGIAI(GDKBCAGCEIA CCNOJOKDHHE, object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void DFLDCLEGEAB(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void AOPHHMAEJCC();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void FCGMCLAFHII();

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void CFPHIACOOHA();

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool EJBOBEPMKHL();

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void OKGHPCCIHAC();

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void EHODPBBNBAJ(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void KMNNOCLBOAB(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void BGOPPMHIIOA(object JILOCOLKOMJ, bool LAKEKLDFPHG);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void PJEICJBPJLN(Vector3 DIHBKEFFCBA, Quaternion CIDCNDIBGFF);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void NNAJHGIIEJI(Vector3 FGKEFLJBKKJ, Quaternion BDAPMPGJHAP);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool JJBIBHDGGBN(float PPDPODCGICD);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void MEOIPAMNEDF(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void KAOMHMJAELC(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void AICDEMPEFDP(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void JIKJAMIHJAA(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void BKLLLLHCDGJ(Vector3 IOHDICMKADP, ForceMode KKMLBMDBNEE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void IMMOLDDCHNA(Vector3 IOHDICMKADP, Vector3 NCGKJMOKFAF, ForceMode KKMLBMDBNEE);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void OCCJDFOICJN(Vector3 FKMHBOJEDEG, ForceMode KKMLBMDBNEE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void EHKODDGEHFK(Vector3 FKMHBOJEDEG, ForceMode KKMLBMDBNEE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool POLHEFCBKCM(Vector3 ELEEIMOLKDP, [Out] RaycastHit CHIFGMMDKPM, float ECLNGJKMDDA);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void FIKBBIPHFKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface MDAEMGHHEEI
{
	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMBLILKFACE(Vector3 BLMNDHDHIDK);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNEKDFLAHIH(Vector3 PMKMNPODBEH);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BDPPMBAFAPG(Vector3 BLMNDHDHIDK);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JIBGHPALLNF(Vector3 PMKMNPODBEH);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface CHJDOPIOJPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 HAIJHMDKMBI();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 JKLPDPMGFPG();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool POKDEKOGNKC(float DKAILJIMLKA, float HBHGMKKFOHA);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public delegate void FNDIPFLKNAB(PHIEGKANMEI NIAHLKCFFDC);
[Cpp2IlInjected.Token(Token = "0x2000056")]
public enum POBNFFLGDJD
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
[Cpp2IlInjected.Token(Token = "0x2000057")]
public enum BEKOKAGGBFN
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
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate void NDDIPIPMLIO(PHIEGKANMEI NIAHLKCFFDC, bool NHEENLIEFAC = false);
[Cpp2IlInjected.Token(Token = "0x2000059")]
public enum FBDAOBLHIEH
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct MBPKKAEDNLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Rigidbody NMOLGGIPLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public object ANFLHMAADCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Vector3 DMHCFGBDPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 CIBHNMHOCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LBIAHMGKBGM CMBPKLECODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool DHOMCFLAPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool AKCBOLLNKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool JPADLHAGCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool IPPNMNNHNOK;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct JAIEPPMCFLB : IEquatable<JAIEPPMCFLB>
{
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public static readonly JAIEPPMCFLB KHBPMGHIGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public GameObject KJMBGAPFJAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7CB6EB0", Offset = "0x7CB56B0", VA = "0x187CB6EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public EPFBCAMMJCA KLNMHOJGNFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7CB73A0", Offset = "0x7CB5BA0", VA = "0x187CB73A0")]
		get
		{
			return default(EPFBCAMMJCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public KPAHBABLLHC GOILCPIHHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7650", Offset = "0x7CB5E50", VA = "0x187CB7650")]
		get
		{
			return default(KPAHBABLLHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public RRObjectPrefabData ACDOCFFCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7760", Offset = "0x7CB5F60", VA = "0x187CB7760")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool KHDALDNIJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7CB6CD0", Offset = "0x7CB54D0", VA = "0x187CB6CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool ANKODBKJAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7070", Offset = "0x7CB5870", VA = "0x187CB7070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool CJLPJFNNCCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7CB71B0", Offset = "0x7CB59B0", VA = "0x187CB71B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool DFOALHOLIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7890", Offset = "0x7CB6090", VA = "0x187CB7890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool JHBNKAGDMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7530", Offset = "0x7CB5D30", VA = "0x187CB7530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool ABMIMIBOFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7500", Offset = "0x7CB5D00", VA = "0x187CB7500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool IGMPEAPADOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7130", Offset = "0x7CB5930", VA = "0x187CB7130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool AFICJFIFAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7CB70F0", Offset = "0x7CB58F0", VA = "0x187CB70F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool OAEMHDFIFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7CB78B0", Offset = "0x7CB60B0", VA = "0x187CB78B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool DAPNMFOGKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7170", Offset = "0x7CB5970", VA = "0x187CB7170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool DOPCDMBOLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7CB6DE0", Offset = "0x7CB55E0", VA = "0x187CB6DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool MMHFMBEFAFN
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB71D0", Offset = "0x7CB59D0", VA = "0x187CB71D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public HBPCPFJIKAD IBDECBOEJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(HBPCPFJIKAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public HJBDNMBLMKH KPGAHBPPJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(HJBDNMBLMKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public NCGLHOPEOMO GODPPDHCCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(NCGLHOPEOMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public KMHFGKGCGEF JPFKHGDNCJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(KMHFGKGCGEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public KHDJHPLLEED APFIGIFMDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(KHDJHPLLEED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public NCCPIGKJDLM CONGKKEOOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(NCCPIGKJDLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public IKDFLOKILAJ MAHDFDJHNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(IKDFLOKILAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public JLKGNGLENKC KENLJGOJLJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JLKGNGLENKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public EMKBNFNALIF LBMCOGFDEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(EMKBNFNALIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public OBJAEBAJHKA DHINJOFGKLI
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(OBJAEBAJHKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public EHCDEKIGHOL EKOIJIEOLEH
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(EHCDEKIGHOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public OLAPEOFBEGE KEILBLIOGKM
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(OLAPEOFBEGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public CLIPNDPJNNE PKMMIKDNLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(CLIPNDPJNNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool MCEJCCPHMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7210", Offset = "0x7CB5A10", VA = "0x187CB7210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool HKKELNLAJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB6C90", Offset = "0x7CB5490", VA = "0x187CB6C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool BCCHPPDCBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7CB6C50", Offset = "0x7CB5450", VA = "0x187CB6C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool IPJBOCLFEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7090", Offset = "0x7CB5890", VA = "0x187CB7090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool INBPDEBCOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7CB76F0", Offset = "0x7CB5EF0", VA = "0x187CB76F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool LBGCAOLFBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7CB74C0", Offset = "0x7CB5CC0", VA = "0x187CB74C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool ENGIAMONPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7CB6C10", Offset = "0x7CB5410", VA = "0x187CB6C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public CDFIMNOIJPM FCHHAJKLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(CDFIMNOIJPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public HGEGIFKAJCN GIKNDILAGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(HGEGIFKAJCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private EFICJEHFEEE HIBEMMMBGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7CAA690", Offset = "0x7CA8E90", VA = "0x187CAA690")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static JAIEPPMCFLB FGIKKMMHFBO(FGFPKLDJIEL GHMCDKKCGHO)
	{
		return default(JAIEPPMCFLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7440", Offset = "0x7CB5C40", VA = "0x187CB7440")]
	public HKIMKJHJGKF LIJHJGGILEE()
	{
		return default(HKIMKJHJGKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7040", Offset = "0x7CB5840", VA = "0x187CB7040")]
	public IHGIFGBBEFE GJDBAJKJILG()
	{
		return default(IHGIFGBBEFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6BC0", Offset = "0x7CB53C0", VA = "0x187CB6BC0")]
	public KLINFNEFFJL AFGCBCMABKD()
	{
		return default(KLINFNEFFJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7730", Offset = "0x7CB5F30", VA = "0x187CB7730")]
	public OPLALLEFFBM OFFMBLGPNKD()
	{
		return default(OPLALLEFFBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6CF0", Offset = "0x7CB54F0", VA = "0x187CB6CF0")]
	public EJEBCPDAIJN DIEMNKCBPJN()
	{
		return default(EJEBCPDAIJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7CB70A0", Offset = "0x7CB58A0", VA = "0x187CB70A0")]
	public FIEBDMKNIKC IAKKKMJEHFM()
	{
		return default(FIEBDMKNIKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7550", Offset = "0x7CB5D50", VA = "0x187CB7550")]
	public void MMAGBEONLHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7300", Offset = "0x7CB5B00", VA = "0x187CB7300")]
	public void KNAKPKDGKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6D40", Offset = "0x7CB5540", VA = "0x187CB6D40")]
	public bool DKGOCHGPNLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7CB78F0", Offset = "0x7CB60F0", VA = "0x187CB78F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public JAIEPPMCFLB(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF420", Offset = "0x7CADC20", VA = "0x187CAF420")]
	public static bool FGIKKMMHFBO(JAIEPPMCFLB OPMIAMEJKDH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static FGFPKLDJIEL FGIKKMMHFBO(JAIEPPMCFLB OPMIAMEJKDH)
	{
		return default(FGFPKLDJIEL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB47F0", Offset = "0x7CB2FF0", VA = "0x187CB47F0")]
	public static bool NIDGPKKMDPO(JAIEPPMCFLB BINANFFLHIK, JAIEPPMCFLB NOAPPAEGHOH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB11E0", Offset = "0x7CAF9E0", VA = "0x187CB11E0")]
	public static bool ONONOJDPAAN(JAIEPPMCFLB BINANFFLHIK, JAIEPPMCFLB NOAPPAEGHOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6E20", Offset = "0x7CB5620", VA = "0x187CB6E20", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(JAIEPPMCFLB PGPJMFPAKOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct OLAPEOFBEGE : IEquatable<OLAPEOFBEGE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private BAKEHHONAJF EFIICFCKBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF850", Offset = "0x7CBE050", VA = "0x187CBF850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC8A0", VA = "0x187CAE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF390", Offset = "0x7CBDB90", VA = "0x187CBF390")]
	public void GBEEEKLJEHB(uint MLBCMOLHELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF750", Offset = "0x7CBDF50", VA = "0x187CBF750")]
	public bool LMDECMCJKME([Out] uint MLBCMOLHELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF290", Offset = "0x7CBDA90", VA = "0x187CBF290")]
	public bool FHFHOLIMIDL([Out] uint MLBCMOLHELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF5F0", Offset = "0x7CBDDF0", VA = "0x187CBF5F0")]
	public void LEBPOJBGAIL(string MLBCMOLHELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF490", Offset = "0x7CBDC90", VA = "0x187CBF490")]
	[CanBeNull]
	public string GPEJHFJEEMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public OLAPEOFBEGE(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF200", Offset = "0x7CBDA00", VA = "0x187CBF200", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(OLAPEOFBEGE PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct HBPCPFJIKAD : IEquatable<HBPCPFJIKAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private DPLIOIGJMLF HLCCLAOMENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7CB20F0", Offset = "0x7CB08F0", VA = "0x187CB20F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private BAKEHHONAJF GOJJLICECOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1D00", Offset = "0x7CB0500", VA = "0x187CB1D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool ELNCEAALLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2250", Offset = "0x7CB0A50", VA = "0x187CB2250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool CFLDOLOJLOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1BA0", Offset = "0x7CB03A0", VA = "0x187CB1BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool CCDLMJCKJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1F10", Offset = "0x7CB0710", VA = "0x187CB1F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public Guid CALGJHAFIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1B20", Offset = "0x7CB0320", VA = "0x187CB1B20")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Guid ECFJFNFNNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1FD0", Offset = "0x7CB07D0", VA = "0x187CB1FD0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Guid KEJFGILGDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7CB22E0", Offset = "0x7CB0AE0", VA = "0x187CB22E0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public HGEGIFKAJCN GIKNDILAGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(HGEGIFKAJCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC8A0", VA = "0x187CAE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2050", Offset = "0x7CB0850", VA = "0x187CB2050")]
	public bool IHBFNDGBMKG([Out] Guid FOEJGIIEFNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1A80", Offset = "0x7CB0280", VA = "0x187CB1A80")]
	public bool COCPGLOCGPG([Out] Guid OPPFCAMGFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1BE0", Offset = "0x7CB03E0", VA = "0x187CB1BE0")]
	public void EHGMLDKLHHA(Guid DDLBJHGGANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2150", Offset = "0x7CB0950", VA = "0x187CB2150")]
	public void LMOCJEMFPKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1DF0", Offset = "0x7CB05F0", VA = "0x187CB1DF0")]
	public Guid GDKBLOECKAA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public HBPCPFJIKAD(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1D60", Offset = "0x7CB0560", VA = "0x187CB1D60", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(HBPCPFJIKAD PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct KLINFNEFFJL : IEquatable<KLINFNEFFJL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private GODLKGCKBJN HOPIDKEFJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7CB9D70", Offset = "0x7CB8570", VA = "0x187CB9D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public Vector3 JEEFOHOLIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7CB9F70", Offset = "0x7CB8770", VA = "0x187CB9F70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Quaternion GKJDJFKNKEO
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB9C30", Offset = "0x7CB8430", VA = "0x187CB9C30")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public JAIEPPMCFLB NHDJGPPPNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB9DD0", Offset = "0x7CB85D0", VA = "0x187CB9DD0")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC8A0", VA = "0x187CAE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9B60", Offset = "0x7CB8360", VA = "0x187CB9B60")]
	public DPONIGJFOLB HJHAFOIBNDM(Allocator KKCJNCNIICO)
	{
		return default(DPONIGJFOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB98E0", Offset = "0x7CB80E0", VA = "0x187CB98E0")]
	public bool CMLGCCJCKEJ(JAIEPPMCFLB DFPCBMGPBFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9A10", Offset = "0x7CB8210", VA = "0x187CB9A10")]
	public void HCIBPNFNAMM(Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9E60", Offset = "0x7CB8660", VA = "0x187CB9E60")]
	public void NBCNECGLKJA(float EGLHBCAIJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9720", Offset = "0x7CB7F20", VA = "0x187CB9720")]
	public void CAOAMKGEFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public KLINFNEFFJL(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF420", Offset = "0x7CADC20", VA = "0x187CAF420")]
	public static bool FGIKKMMHFBO(KLINFNEFFJL OPMIAMEJKDH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static FGFPKLDJIEL FGIKKMMHFBO(KLINFNEFFJL OPMIAMEJKDH)
	{
		return default(FGFPKLDJIEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9980", Offset = "0x7CB8180", VA = "0x187CB9980", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(KLINFNEFFJL PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct HKIMKJHJGKF : IEquatable<HKIMKJHJGKF>
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly HKIMKJHJGKF KHBPMGHIGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private KOMJNIJGCJJ JFHENDNPIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3B30", Offset = "0x7CB2330", VA = "0x187CB3B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<JAIEPPMCFLB> MHBEANDDIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3B90", Offset = "0x7CB2390", VA = "0x187CB3B90")]
		get
		{
			return default(Span<JAIEPPMCFLB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3D10", Offset = "0x7CB2510", VA = "0x187CB3D10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3C90", Offset = "0x7CB2490", VA = "0x187CB3C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public CDFIMNOIJPM FCHHAJKLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(CDFIMNOIJPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public HGEGIFKAJCN GIKNDILAGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(HGEGIFKAJCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC8A0", VA = "0x187CAE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3600", Offset = "0x7CB1E00", VA = "0x187CB3600")]
	public void BFOFOLMHCJC(HKIMKJHJGKF PGPJMFPAKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public HKIMKJHJGKF(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF420", Offset = "0x7CADC20", VA = "0x187CAF420")]
	public static bool FGIKKMMHFBO(HKIMKJHJGKF OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3AA0", Offset = "0x7CB22A0", VA = "0x187CB3AA0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(HKIMKJHJGKF PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static JAIEPPMCFLB FGIKKMMHFBO(HKIMKJHJGKF NFOGFJOGLPE)
	{
		return default(JAIEPPMCFLB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public struct NCOJGBNNBKA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Dictionary<int, object> BGBFHIDBILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private DCHLEEHOHFH MJDNMIDANMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private bool LLMFDIDBMNA;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		[CompilerGenerated]
		readonly get
		{
			return default(JAIEPPMCFLB);
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public GKAJKPBFFAP EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7CBD270", Offset = "0x7CBBA70", VA = "0x187CBD270")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD4D0", Offset = "0x7CBBCD0", VA = "0x187CBD4D0")]
	internal NCOJGBNNBKA(JAIEPPMCFLB PNHCNFOFAFI, bool LLMFDIDBMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD330", Offset = "0x7CBBB30", VA = "0x187CBD330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x3925120", Offset = "0x3923920", VA = "0x183925120")]
	public void ENHHOBHEDMI<T>(GKAJKPBFFAP BELIEAFHDAH, T OPMIAMEJKDH, [Optional] T LHCNPHOLELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD1C0", Offset = "0x7CBB9C0", VA = "0x187CBD1C0")]
	public void AHELLINFOCL(GKAJKPBFFAP BELIEAFHDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0xD68560", Offset = "0xD66D60", VA = "0x180D68560")]
	public Dictionary<int, object> DKKIGKEALJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD460", Offset = "0x7CBBC60", VA = "0x187CBD460")]
	private readonly void GODJHLEDLIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class DOMAIODCILL
{
	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD0C0", Offset = "0x7CAB8C0", VA = "0x187CAD0C0")]
	public static NCOJGBNNBKA ICKLOKHJFMM(this JAIEPPMCFLB PNHCNFOFAFI)
	{
		return default(NCOJGBNNBKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct CLIPNDPJNNE : IEquatable<CLIPNDPJNNE>
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly CLIPNDPJNNE KHBPMGHIGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private bool DOPCDMBOLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7CAC740", Offset = "0x7CAAF40", VA = "0x187CAC740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Vector3 JFHGOEDCDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7CAC8F0", Offset = "0x7CAB0F0", VA = "0x187CAC8F0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7CAC810", Offset = "0x7CAB010", VA = "0x187CAC810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7CACA20", Offset = "0x7CAB220", VA = "0x187CACA20")]
	public Vector3 OJOGFHADINC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC870", Offset = "0x7CAB070", VA = "0x187CAC870")]
	public void KFNOPOJLBMC([In] Vector3 OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC9A0", Offset = "0x7CAB1A0", VA = "0x187CAC9A0")]
	public void MCJFFCJOKAG([In] Vector3 OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7CACAA0", Offset = "0x7CAB2A0", VA = "0x187CACAA0")]
	public bool ONAFOOMPGHL([In] Vector3 OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public CLIPNDPJNNE(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC780", Offset = "0x7CAAF80", VA = "0x187CAC780", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(CLIPNDPJNNE PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7CACB50", Offset = "0x7CAB350", VA = "0x187CACB50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct DGLKJIDNHCK : IEquatable<DGLKJIDNHCK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7CACFB0", Offset = "0x7CAB7B0", VA = "0x187CACFB0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(DGLKJIDNHCK PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct HGEGIFKAJCN : IEquatable<HGEGIFKAJCN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private KOMJNIJGCJJ JFHENDNPIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2A00", Offset = "0x7CB1200", VA = "0x187CB2A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public FGFPKLDJIEL MCLCDILBEHP
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2580", Offset = "0x7CB0D80", VA = "0x187CB2580")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public JAIEPPMCFLB BKMKKMCIDFM
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2970", Offset = "0x7CB1170", VA = "0x187CB2970")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public JAIEPPMCFLB DFJAHCLMMPD
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2E00", Offset = "0x7CB1600", VA = "0x187CB2E00")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC8A0", VA = "0x187CAE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2C00", Offset = "0x7CB1400", VA = "0x187CB2C00")]
	public Span<JAIEPPMCFLB> ICJFGMAPJPF()
	{
		return default(Span<JAIEPPMCFLB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2870", Offset = "0x7CB1070", VA = "0x187CB2870")]
	public Span<JAIEPPMCFLB> HBMIPADHIGN()
	{
		return default(Span<JAIEPPMCFLB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2D00", Offset = "0x7CB1500", VA = "0x187CB2D00")]
	public Span<JAIEPPMCFLB> KPBEEJEJHKA()
	{
		return default(Span<JAIEPPMCFLB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2E90", Offset = "0x7CB1690", VA = "0x187CB2E90")]
	public Span<JAIEPPMCFLB> PDMFGLKLABM()
	{
		return default(Span<JAIEPPMCFLB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2740", Offset = "0x7CB0F40", VA = "0x187CB2740")]
	public bool GDNIECKCIEP(JAIEPPMCFLB DFPCBMGPBFO, bool ABFEHPEBJCO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2610", Offset = "0x7CB0E10", VA = "0x187CB2610")]
	public bool ELIPNFPBEMD(JAIEPPMCFLB LIGGNDMEMHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2AF0", Offset = "0x7CB12F0", VA = "0x187CB2AF0")]
	public JAIEPPMCFLB ICGLNADJCKO(uint DHOLNPBNFDH)
	{
		return default(JAIEPPMCFLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2A60", Offset = "0x7CB1260", VA = "0x187CB2A60")]
	public HKIMKJHJGKF HGOONKLHOIF()
	{
		return default(HKIMKJHJGKF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public HGEGIFKAJCN(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF420", Offset = "0x7CADC20", VA = "0x187CAF420")]
	public static bool FGIKKMMHFBO(HGEGIFKAJCN OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7CB26B0", Offset = "0x7CB0EB0", VA = "0x187CB26B0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(HGEGIFKAJCN PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct HJBDNMBLMKH : IEquatable<HJBDNMBLMKH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public string DGFFOJPABFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3400", Offset = "0x7CB1C00", VA = "0x187CB3400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public string EDBJLBHJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3490", Offset = "0x7CB1C90", VA = "0x187CB3490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public string AOMDMOBDOCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3160", Offset = "0x7CB1960", VA = "0x187CB3160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3540", Offset = "0x7CB1D40", VA = "0x187CB3540")]
	public bool NNNKELOELHB([Out] string CDKPNMEDHPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public HJBDNMBLMKH(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7CB30D0", Offset = "0x7CB18D0", VA = "0x187CB30D0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(HJBDNMBLMKH PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct EJEBCPDAIJN : IEquatable<EJEBCPDAIJN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private LGODHAOEKND NIDPFHNHICI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE990", Offset = "0x7CAD190", VA = "0x187CAE990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public PBJOOGKFKOE GEKFCECMLBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7CAEDD0", Offset = "0x7CAD5D0", VA = "0x187CAEDD0")]
		get
		{
			return default(PBJOOGKFKOE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7CAECC0", Offset = "0x7CAD4C0", VA = "0x187CAECC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool NPGKANOKEOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7CAEB10", Offset = "0x7CAD310", VA = "0x187CAEB10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7CAEED0", Offset = "0x7CAD6D0", VA = "0x187CAEED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public JMGGLJLNFLA<string> JENCGHHAMAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE240", Offset = "0x7CACA40", VA = "0x187CAE240")]
		get
		{
			return default(JMGGLJLNFLA<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE6C0", Offset = "0x7CACEC0", VA = "0x187CAE6C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public JMGGLJLNFLA<string> LGJBCIOHPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE5A0", Offset = "0x7CACDA0", VA = "0x187CAE5A0")]
		get
		{
			return default(JMGGLJLNFLA<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE480", Offset = "0x7CACC80", VA = "0x187CAE480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public JMGGLJLNFLA<string> FEJOHAKKKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE9F0", Offset = "0x7CAD1F0", VA = "0x187CAE9F0")]
		get
		{
			return default(JMGGLJLNFLA<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE870", Offset = "0x7CAD070", VA = "0x187CAE870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public JMGGLJLNFLA<string> LOOMIKAMBEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7CAEBA0", Offset = "0x7CAD3A0", VA = "0x187CAEBA0")]
		get
		{
			return default(JMGGLJLNFLA<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE360", Offset = "0x7CACB60", VA = "0x187CAE360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC8A0", VA = "0x187CAE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE1A0", Offset = "0x7CAC9A0", VA = "0x187CAE1A0")]
	public bool ACIDMBCIKPN(FGFPKLDJIEL PPBALHIMPIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public EJEBCPDAIJN(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static FGFPKLDJIEL FGIKKMMHFBO(EJEBCPDAIJN OPMIAMEJKDH)
	{
		return default(FGFPKLDJIEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE7E0", Offset = "0x7CACFE0", VA = "0x187CAE7E0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(EJEBCPDAIJN PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct HDKKONAKPFE : IEquatable<HDKKONAKPFE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7CB24F0", Offset = "0x7CB0CF0", VA = "0x187CB24F0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(HDKKONAKPFE PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct CKKMGGMEJHE : IEquatable<CKKMGGMEJHE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC560", Offset = "0x7CAAD60", VA = "0x187CAC560", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(CKKMGGMEJHE PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct NCGLHOPEOMO : IEquatable<NCGLHOPEOMO>
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly ComponentTypes FHBKGBLEHKO;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly NCGLHOPEOMO KHBPMGHIGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Collider DGNEAMMMGKD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC610", Offset = "0x7CBAE10", VA = "0x187CBC610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public BJAFCOANKPJ JCKNHFNEJJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC8F0", Offset = "0x7CBB0F0", VA = "0x187CBC8F0")]
		get
		{
			return default(BJAFCOANKPJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC570", Offset = "0x7CBAD70", VA = "0x187CBC570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public ADAAIALDPAD JGCCABDFKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC1E0", Offset = "0x7CBA9E0", VA = "0x187CBC1E0")]
		get
		{
			return default(ADAAIALDPAD);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC8A0", Offset = "0x7CBB0A0", VA = "0x187CBC8A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public NNNNHLPIDJL NIMHEAEELEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC0B0", Offset = "0x7CBA8B0", VA = "0x187CBC0B0")]
		get
		{
			return default(NNNNHLPIDJL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC0F0", Offset = "0x7CBA8F0", VA = "0x187CBC0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public float LKEAGJKDCDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC220", Offset = "0x7CBAA20", VA = "0x187CBC220")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC5C0", Offset = "0x7CBADC0", VA = "0x187CBC5C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool EHPGFGJPDNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7CBCF30", Offset = "0x7CBB730", VA = "0x187CBCF30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC760", Offset = "0x7CBAF60", VA = "0x187CBC760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool GOFCKHLOLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7CBCD40", Offset = "0x7CBB540", VA = "0x187CBCD40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC800", Offset = "0x7CBB000", VA = "0x187CBC800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool AELCAJCJBPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC260", Offset = "0x7CBAA60", VA = "0x187CBC260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC370", Offset = "0x7CBAB70", VA = "0x187CBC370")]
	public static bool FIHOABBCNCA(JAIEPPMCFLB AKEHEMPNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7CBCB00", Offset = "0x7CBB300", VA = "0x187CBCB00")]
	public static bool MMIGFMCEJDL(JAIEPPMCFLB AKEHEMPNMOK, [Out] NCGLHOPEOMO KHALHMCHOHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC990", Offset = "0x7CBB190", VA = "0x187CBC990")]
	public bool MDDCGCOPCLD([Out] KNHIBECPCDK BMLEIFODCAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7CBCDC0", Offset = "0x7CBB5C0", VA = "0x187CBCDC0")]
	public bool OHICKIJPJFF([Out] FGFPKLDJIEL PNDCHGJLEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC930", Offset = "0x7CBB130", VA = "0x187CBC930")]
	public bool KINFOHFGNBL(LJAJHDLLPIK GAKNJCMEOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7CBCEB0", Offset = "0x7CBB6B0", VA = "0x187CBCEB0")]
	public void OOJOHMBEMBE(LJAJHDLLPIK GAKNJCMEOCN, bool CEHDHOOIGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC140", Offset = "0x7CBA940", VA = "0x187CBC140")]
	public void EEGKLALDODM(LJAJHDLLPIK GAKNJCMEOCN, bool CEHDHOOIGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public NCGLHOPEOMO(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC2E0", Offset = "0x7CBAAE0", VA = "0x187CBC2E0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(NCGLHOPEOMO PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7CBCFA0", Offset = "0x7CBB7A0", VA = "0x187CBCFA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct OPLALLEFFBM : IEquatable<OPLALLEFFBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public bool CECEPDICAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFB20", Offset = "0x7CBE320", VA = "0x187CBFB20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public OPLALLEFFBM(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7CBFA90", Offset = "0x7CBE290", VA = "0x187CBFA90", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(OPLALLEFFBM PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct KMHFGKGCGEF : IEquatable<KMHFGKGCGEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private BIPKHHKACLN IOPAEPLJDAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA150", Offset = "0x7CB8950", VA = "0x187CBA150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC8A0", VA = "0x187CAE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA1B0", Offset = "0x7CB89B0", VA = "0x187CBA1B0")]
	public void NPCMGFJPNIK(bool KHPCNHFKOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public KMHFGKGCGEF(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA0C0", Offset = "0x7CB88C0", VA = "0x187CBA0C0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(KMHFGKGCGEF PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct KHDJHPLLEED : IEquatable<KHDJHPLLEED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public bool GFCOFAFEHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8570", Offset = "0x7CB6D70", VA = "0x187CB8570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public bool AGNFDLCIHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x7CB86B0", Offset = "0x7CB6EB0", VA = "0x187CB86B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool CMCKLAOIBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8DA0", Offset = "0x7CB75A0", VA = "0x187CB8DA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8B00", Offset = "0x7CB7300", VA = "0x187CB8B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public bool KLBMGGKDGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7CB84E0", Offset = "0x7CB6CE0", VA = "0x187CB84E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool NBOAHBFHBCG
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8DF0", Offset = "0x7CB75F0", VA = "0x187CB8DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool PFENMOKPCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8930", Offset = "0x7CB7130", VA = "0x187CB8930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool DICLIIJJCKA
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8F70", Offset = "0x7CB7770", VA = "0x187CB8F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool ECGDEICKIAG
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8ED0", Offset = "0x7CB76D0", VA = "0x187CB8ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool LGOCIOFBAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8AB0", Offset = "0x7CB72B0", VA = "0x187CB8AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool INCFFPECOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8C10", Offset = "0x7CB7410", VA = "0x187CB8C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool HCCODJMKNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8980", Offset = "0x7CB7180", VA = "0x187CB8980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool AFOCCFKNELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8700", Offset = "0x7CB6F00", VA = "0x187CB8700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool IDOBOIFHAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8F20", Offset = "0x7CB7720", VA = "0x187CB8F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool MGCBGDDMCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8530", Offset = "0x7CB6D30", VA = "0x187CB8530")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8BB0", Offset = "0x7CB73B0", VA = "0x187CB8BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public NMCCPBDEEDE NNPDHDGCJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8FC0", Offset = "0x7CB77C0", VA = "0x187CB8FC0")]
		get
		{
			return default(NMCCPBDEEDE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8D50", Offset = "0x7CB7550", VA = "0x187CB8D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool ILFCACFLHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8810", Offset = "0x7CB7010", VA = "0x187CB8810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public GPENBGAGNGF EKAJAFKHLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8750", Offset = "0x7CB6F50", VA = "0x187CB8750")]
		get
		{
			return default(GPENBGAGNGF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8E80", Offset = "0x7CB7680", VA = "0x187CB8E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public bool AOPACAHJCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8E40", Offset = "0x7CB7640", VA = "0x187CB8E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 KHAGFDCNAAE
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB85B0", Offset = "0x7CB6DB0", VA = "0x187CB85B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Vector3 KEKBJPFCJMN
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8630", Offset = "0x7CB6E30", VA = "0x187CB8630")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool CKLOGOFCOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7CB9000", Offset = "0x7CB7800", VA = "0x187CB9000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC8A0", VA = "0x187CAE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8CF0", Offset = "0x7CB74F0", VA = "0x187CB8CF0")]
	public bool HKHJKODJHDA(PCPMDCFFHNO GAKNJCMEOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8B20", Offset = "0x7CB7320", VA = "0x187CB8B20")]
	public void FDNJDIIJNOK(PCPMDCFFHNO GAKNJCMEOCN, bool CEHDHOOIGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7CB89D0", Offset = "0x7CB71D0", VA = "0x187CB89D0")]
	public bool EOKLNPOMBIN(CBEOOPEFCFB GAKNJCMEOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8790", Offset = "0x7CB6F90", VA = "0x187CB8790")]
	public void DODJHNKLMBD(CBEOOPEFCFB GAKNJCMEOCN, bool CEHDHOOIGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8CB0", Offset = "0x7CB74B0", VA = "0x187CB8CB0")]
	public CBEOOPEFCFB HJOFEGHNPJP()
	{
		return default(CBEOOPEFCFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8C60", Offset = "0x7CB7460", VA = "0x187CB8C60")]
	public bool HFELKDBLGKM(CBEOOPEFCFB OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public KHDJHPLLEED(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8A20", Offset = "0x7CB7220", VA = "0x187CB8A20", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(KHDJHPLLEED PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct NCCPIGKJDLM : IEquatable<NCCPIGKJDLM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private HGPBHOIABME JLHNBHIBKKN
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x7CBBBD0", Offset = "0x7CBA3D0", VA = "0x187CBBBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	private KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC8A0", VA = "0x187CAE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBE70", Offset = "0x7CBA670", VA = "0x187CBBE70")]
	public bool OAKLIANGHBG(OCDLEPLDLBO KJHADNKKPBJ, List<JAIEPPMCFLB> FNEFJGHGJFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBA10", Offset = "0x7CBA210", VA = "0x187CBBA10")]
	public int HPJKGBCKADJ(OCDLEPLDLBO KJHADNKKPBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBD60", Offset = "0x7CBA560", VA = "0x187CBBD60")]
	public void NFMBAOLHOFL(List<JAIEPPMCFLB> FNEFJGHGJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB670", Offset = "0x7CB9E70", VA = "0x187CBB670")]
	public int EPEAOGKBKKK(JAIEPPMCFLB ALLFIKNKLHM, OCDLEPLDLBO KJHADNKKPBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBC30", Offset = "0x7CBA430", VA = "0x187CBBC30")]
	public JAIEPPMCFLB MDDBNEMKLIG(int FPEOONOJHML, OCDLEPLDLBO KJHADNKKPBJ)
	{
		return default(JAIEPPMCFLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB8E0", Offset = "0x7CBA0E0", VA = "0x187CBB8E0")]
	public void FHFDODODGFG(JAIEPPMCFLB ALLFIKNKLHM, OCDLEPLDLBO KJHADNKKPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBB20", Offset = "0x7CBA320", VA = "0x187CBBB20")]
	public bool IBAKHGAMKIB(JAIEPPMCFLB ALLFIKNKLHM, OCDLEPLDLBO KJHADNKKPBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBFA0", Offset = "0x7CBA7A0", VA = "0x187CBBFA0")]
	public void OHMHAJGENAH(OCDLEPLDLBO KJHADNKKPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB830", Offset = "0x7CBA030", VA = "0x187CBB830")]
	public bool FFEKIIBJBCJ(JAIEPPMCFLB ALLFIKNKLHM, OCDLEPLDLBO KJHADNKKPBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB560", Offset = "0x7CB9D60", VA = "0x187CBB560")]
	public bool EGKMJHLAFNP(OCDLEPLDLBO KJHADNKKPBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public NCCPIGKJDLM(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB7A0", Offset = "0x7CB9FA0", VA = "0x187CBB7A0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(NCCPIGKJDLM PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct IKDFLOKILAJ : IEquatable<IKDFLOKILAJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC8A0", VA = "0x187CAE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB54A0", Offset = "0x7CB3CA0", VA = "0x187CB54A0")]
	public void KNKAFBMGBBK(bool OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5530", Offset = "0x7CB3D30", VA = "0x187CB5530")]
	public void OJCIBCHLLOI(bool OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x37F1970", Offset = "0x37F0170", VA = "0x1837F1970")]
	public T IICCGGGOJJN<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public IKDFLOKILAJ(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5410", Offset = "0x7CB3C10", VA = "0x187CB5410", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(IKDFLOKILAJ PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct JLKGNGLENKC : IEquatable<JLKGNGLENKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public bool ENAPOACFGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7E40", Offset = "0x7CB6640", VA = "0x187CB7E40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7D20", Offset = "0x7CB6520", VA = "0x187CB7D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool PNAHHGJELCP
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7C10", Offset = "0x7CB6410", VA = "0x187CB7C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public int AMFJDEEDECH
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7E00", Offset = "0x7CB6600", VA = "0x187CB7E00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7C90", Offset = "0x7CB6490", VA = "0x187CB7C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC8A0", VA = "0x187CAE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public JLKGNGLENKC(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7D70", Offset = "0x7CB6570", VA = "0x187CB7D70", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(JLKGNGLENKC PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct GJOCBECGNLF : IEquatable<GJOCBECGNLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public int NHPFJHDPNJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x7CB17C0", Offset = "0x7CAFFC0", VA = "0x187CB17C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1770", Offset = "0x7CAFF70", VA = "0x187CB1770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public int KPBKKKBBCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1730", Offset = "0x7CAFF30", VA = "0x187CB1730")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1650", Offset = "0x7CAFE50", VA = "0x187CB1650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public GJOCBECGNLF(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB16A0", Offset = "0x7CAFEA0", VA = "0x187CB16A0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(GJOCBECGNLF PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct EMKBNFNALIF : IEquatable<EMKBNFNALIF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	private IKJIEEDFKNA NGBNCFNIGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x7CAFBC0", Offset = "0x7CAE3C0", VA = "0x187CAFBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	private EFEKNHONLLK KPGFCGNHKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF550", Offset = "0x7CADD50", VA = "0x187CAF550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public bool LFAOPMLBHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF080", Offset = "0x7CAD880", VA = "0x187CAF080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public bool LGFNCLPJCKC
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x7CAFB20", Offset = "0x7CAE320", VA = "0x187CAFB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool DBBPPFLCPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF2B0", Offset = "0x7CADAB0", VA = "0x187CAF2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool IKPBCICMMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF9B0", Offset = "0x7CAE1B0", VA = "0x187CAF9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool IKHFGEKOHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF5B0", Offset = "0x7CADDB0", VA = "0x187CAF5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool PCOMHAPOPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF880", Offset = "0x7CAE080", VA = "0x187CAF880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool OCMOKPEFLPE
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF110", Offset = "0x7CAD910", VA = "0x187CAF110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool CFKHOJLFOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF710", Offset = "0x7CADF10", VA = "0x187CAF710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool GFKBHFBKCJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF5E0", Offset = "0x7CADDE0", VA = "0x187CAF5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	private KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC8A0", VA = "0x187CAE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF440", Offset = "0x7CADC40", VA = "0x187CAF440")]
	public bool IBPPKGKDOCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF910", Offset = "0x7CAE110", VA = "0x187CAF910")]
	public JAIEPPMCFLB KPIMMKPJFJB(JAIEPPMCFLB ALLFIKNKLHM)
	{
		return default(JAIEPPMCFLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEF70", Offset = "0x7CAD770", VA = "0x187CAEF70")]
	public FGFPKLDJIEL BALPNJNGGCE()
	{
		return default(FGFPKLDJIEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7CAFA80", Offset = "0x7CAE280", VA = "0x187CAFA80")]
	public bool NGBAIPKEBLH(FGFPKLDJIEL GLIHBFGDOCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF4B0", Offset = "0x7CADCB0", VA = "0x187CAF4B0")]
	public bool IGKMADOBPKE(FGFPKLDJIEL KOCEIDEJIGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF2E0", Offset = "0x7CADAE0", VA = "0x187CAF2E0")]
	public bool DIIOOPLMIMJ(FGFPKLDJIEL ALLFIKNKLHM, [Out] FGFPKLDJIEL GLIHBFGDOCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public EMKBNFNALIF(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF420", Offset = "0x7CADC20", VA = "0x187CAF420")]
	public static bool FGIKKMMHFBO(EMKBNFNALIF OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF390", Offset = "0x7CADB90", VA = "0x187CAF390", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(EMKBNFNALIF PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct IHGIFGBBEFE : IEquatable<IHGIFGBBEFE>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly IHGIFGBBEFE KHBPMGHIGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public DHNPNMDCFJA JOMNJMOOMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7CB5020", Offset = "0x7CB3820", VA = "0x187CB5020")]
		get
		{
			return default(DHNPNMDCFJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public EMNBMFIJODE GEHPAEKDJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E90", Offset = "0x7CB3690", VA = "0x187CB4E90")]
		get
		{
			return default(EMNBMFIJODE);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB5300", Offset = "0x7CB3B00", VA = "0x187CB5300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public BPKIIKGALAC AHJGKHIHKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7CB53D0", Offset = "0x7CB3BD0", VA = "0x187CB53D0")]
		get
		{
			return default(BPKIIKGALAC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7CB5060", Offset = "0x7CB3860", VA = "0x187CB5060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public float HEMNKINECGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4FE0", Offset = "0x7CB37E0", VA = "0x187CB4FE0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4DA0", Offset = "0x7CB35A0", VA = "0x187CB4DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public Vector3 KBHONPLELAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7CB50B0", Offset = "0x7CB38B0", VA = "0x187CB50B0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4F60", Offset = "0x7CB3760", VA = "0x187CB4F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public float MDDJOJPINPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4DF0", Offset = "0x7CB35F0", VA = "0x187CB4DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public MGFGEDENDIF OMAELGJELAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7CB5350", Offset = "0x7CB3B50", VA = "0x187CB5350")]
		get
		{
			return default(MGFGEDENDIF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E40", Offset = "0x7CB3640", VA = "0x187CB4E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public bool MILDILAPJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7CB5390", Offset = "0x7CB3B90", VA = "0x187CB5390")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB5250", Offset = "0x7CB3A50", VA = "0x187CB5250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public CDFIMNOIJPM FCHHAJKLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(CDFIMNOIJPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public HGEGIFKAJCN GIKNDILAGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(HGEGIFKAJCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB51B0", Offset = "0x7CB39B0", VA = "0x187CB51B0")]
	public JNBIHFOAGIL JMHKLJOBJCD()
	{
		return default(JNBIHFOAGIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB52B0", Offset = "0x7CB3AB0", VA = "0x187CB52B0")]
	public IEELNOOEJIA MJFCMHOMPCJ()
	{
		return default(IEELNOOEJIA);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5200", Offset = "0x7CB3A00", VA = "0x187CB5200")]
	private bool LDMOGHKIGKN(MGFGEDENDIF GAKNJCMEOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5130", Offset = "0x7CB3930", VA = "0x187CB5130")]
	public void IDHDNPMHBCO(MGFGEDENDIF GAKNJCMEOCN, bool CEHDHOOIGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public IHGIFGBBEFE(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF420", Offset = "0x7CADC20", VA = "0x187CAF420")]
	public static bool FGIKKMMHFBO(IHGIFGBBEFE OPMIAMEJKDH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x7CB11E0", Offset = "0x7CAF9E0", VA = "0x187CB11E0")]
	public static bool ONONOJDPAAN(IHGIFGBBEFE BINANFFLHIK, IHGIFGBBEFE NOAPPAEGHOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4ED0", Offset = "0x7CB36D0", VA = "0x187CB4ED0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(IHGIFGBBEFE PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct JNBIHFOAGIL : IEquatable<JNBIHFOAGIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public IHGIFGBBEFE PBPAAHAMKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(IHGIFGBBEFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public INNMCPGDHCO OCKFKHHPDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7F10", Offset = "0x7CB6710", VA = "0x187CB7F10")]
		get
		{
			return default(INNMCPGDHCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public JNBIHFOAGIL(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF420", Offset = "0x7CADC20", VA = "0x187CAF420")]
	public static bool FGIKKMMHFBO(JNBIHFOAGIL OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7E80", Offset = "0x7CB6680", VA = "0x187CB7E80", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(JNBIHFOAGIL PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DefaultMember("Item")]
public readonly struct IEELNOOEJIA : IEquatable<IEELNOOEJIA>
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly IEELNOOEJIA KHBPMGHIGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private KGJFFJIGIDO CCGBAGHJNOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7CB41E0", Offset = "0x7CB29E0", VA = "0x187CB41E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public IHGIFGBBEFE PBPAAHAMKDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(IHGIFGBBEFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public IGMEPMPFKOO HCFOGMLCNIO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4500", Offset = "0x7CB2D00", VA = "0x187CB4500")]
		get
		{
			return default(IGMEPMPFKOO);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4630", Offset = "0x7CB2E30", VA = "0x187CB4630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public IEnumerable<FGALNGBLIBB> AJEKEJHLJBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4890", Offset = "0x7CB3090", VA = "0x187CB4890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public FGALNGBLIBB EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7CB40D0", Offset = "0x7CB28D0", VA = "0x187CB40D0")]
		get
		{
			return default(FGALNGBLIBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4040", Offset = "0x7CB2840", VA = "0x187CB4040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public CDFIMNOIJPM FCHHAJKLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(CDFIMNOIJPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	private KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC8A0", VA = "0x187CAE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3E20", Offset = "0x7CB2620", VA = "0x187CB3E20")]
	public FGALNGBLIBB BJOHCNAKMFD(float3? NCGKJMOKFAF, [Optional] quaternion? PMHMEKBKJJA, [Optional] Vector3? EGLHBCAIJLF)
	{
		return default(FGALNGBLIBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4240", Offset = "0x7CB2A40", VA = "0x187CB4240")]
	public FGALNGBLIBB DIKHLCLGBEB(int FPEOONOJHML, float3? NCGKJMOKFAF, [Optional] quaternion? PMHMEKBKJJA, [Optional] Vector3? EGLHBCAIJLF)
	{
		return default(FGALNGBLIBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4750", Offset = "0x7CB2F50", VA = "0x187CB4750")]
	public void MPKPFGMPGFE(int FPEOONOJHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4800", Offset = "0x7CB3000", VA = "0x187CB4800")]
	public void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public IEELNOOEJIA(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF420", Offset = "0x7CADC20", VA = "0x187CAF420")]
	public static bool FGIKKMMHFBO(IEELNOOEJIA OPMIAMEJKDH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7CB47F0", Offset = "0x7CB2FF0", VA = "0x187CB47F0")]
	public static bool NIDGPKKMDPO(IEELNOOEJIA BINANFFLHIK, IEELNOOEJIA NOAPPAEGHOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4470", Offset = "0x7CB2C70", VA = "0x187CB4470", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(IEELNOOEJIA PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct FGALNGBLIBB : IEquatable<FGALNGBLIBB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public IEELNOOEJIA KPCBMBOIFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0870", Offset = "0x7CAF070", VA = "0x187CB0870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public float3 CHPCAADKHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7CB09D0", Offset = "0x7CAF1D0", VA = "0x187CB09D0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0AE0", Offset = "0x7CAF2E0", VA = "0x187CB0AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public quaternion OIHKBFCJFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7CB08F0", Offset = "0x7CAF0F0", VA = "0x187CB08F0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0B50", Offset = "0x7CAF350", VA = "0x187CB0B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public float3 KLAJACPANNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0810", Offset = "0x7CAF010", VA = "0x187CB0810")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0A80", Offset = "0x7CAF280", VA = "0x187CB0A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public LHFAABAKNBI LNAKCPJJILC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0A30", Offset = "0x7CAF230", VA = "0x187CB0A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0B40", Offset = "0x7CAF340", VA = "0x187CB0B40")]
	public void OAAGNECMAFN(IEELNOOEJIA OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public FGALNGBLIBB(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0940", Offset = "0x7CAF140", VA = "0x187CB0940", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(FGALNGBLIBB PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct FIEBDMKNIKC : IEquatable<FIEBDMKNIKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public bool MPIIJFCENOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1480", Offset = "0x7CAFC80", VA = "0x187CB1480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public FIEBDMKNIKC(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7CB14D0", Offset = "0x7CAFCD0", VA = "0x187CB14D0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(FIEBDMKNIKC PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct OBJAEBAJHKA : IEquatable<OBJAEBAJHKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	private ADLHIHAEEOL HFBMMDCKBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE5F0", Offset = "0x7CBCDF0", VA = "0x187CBE5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public bool KOHBNLKDKDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE5A0", Offset = "0x7CBCDA0", VA = "0x187CBE5A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7CBEB20", Offset = "0x7CBD320", VA = "0x187CBEB20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public bool DGHAMMIOALC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7CBEF60", Offset = "0x7CBD760", VA = "0x187CBEF60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE8E0", Offset = "0x7CBD0E0", VA = "0x187CBE8E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public float JMNEDHEPLAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7CBEA90", Offset = "0x7CBD290", VA = "0x187CBEA90")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7CBECB0", Offset = "0x7CBD4B0", VA = "0x187CBECB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public bool MAPCPBJECFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE890", Offset = "0x7CBD090", VA = "0x187CBE890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	private KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC8A0", VA = "0x187CAE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE500", Offset = "0x7CBCD00", VA = "0x187CBE500")]
	public void ADBCPPDHLPM(int PIDPEOCOGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x7CBEE50", Offset = "0x7CBD650", VA = "0x187CBEE50")]
	public bool OJJBICNMILG([Out] int PIDPEOCOGMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE650", Offset = "0x7CBCE50", VA = "0x187CBE650")]
	public void EIEMBJCCHOC(bool AABNLKFMPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x7CBEAD0", Offset = "0x7CBD2D0", VA = "0x187CBEAD0")]
	public bool JMPHDNPHKPH(LLAPIMFLHKI GAKNJCMEOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE810", Offset = "0x7CBD010", VA = "0x187CBE810")]
	public void GFNEDAJGOJG(LLAPIMFLHKI GAKNJCMEOCN, bool CEHDHOOIGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE940", Offset = "0x7CBD140", VA = "0x187CBE940")]
	public void IGJKNNJEBCM(float NHKBONPKEAL, float EOABHEIFOIL, float JLBDHLENJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x7CBED00", Offset = "0x7CBD500", VA = "0x187CBED00")]
	public void NOCJPOKJIID(float3 HMMIOBJIIDO, quaternion MPFOAHPFPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x7CBEFB0", Offset = "0x7CBD7B0", VA = "0x187CBEFB0")]
	public bool PGPPAAOMEEA([Out] float3 HMMIOBJIIDO, [Out] quaternion MPFOAHPFPFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7CBEB80", Offset = "0x7CBD380", VA = "0x187CBEB80")]
	public bool LCAEFMPCLHE([Out] float AFOECAJCBOE, [Out] float CPBECLNEOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE6F0", Offset = "0x7CBCEF0", VA = "0x187CBE6F0")]
	public void EIOOFLJHDPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public OBJAEBAJHKA(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE780", Offset = "0x7CBCF80", VA = "0x187CBE780", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(OBJAEBAJHKA PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct CDFIMNOIJPM : IEquatable<CDFIMNOIJPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	private GLMBECBONIF ONHEBHGCCEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x7CAB160", Offset = "0x7CA9960", VA = "0x187CAB160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public Vector3 CHPCAADKHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7CABB60", Offset = "0x7CAA360", VA = "0x187CABB60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7CABDF0", Offset = "0x7CAA5F0", VA = "0x187CABDF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public Quaternion OIHKBFCJFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CAADC0", Offset = "0x7CA95C0", VA = "0x187CAADC0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7CABEC0", Offset = "0x7CAA6C0", VA = "0x187CABEC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public Vector3 GLHOKEIGHFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7CAB220", Offset = "0x7CA9A20", VA = "0x187CAB220")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7CAB5D0", Offset = "0x7CA9DD0", VA = "0x187CAB5D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public Quaternion IMPNJHKBDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7CAC060", Offset = "0x7CAA860", VA = "0x187CAC060")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7CAB7E0", Offset = "0x7CA9FE0", VA = "0x187CAB7E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public float CAHFINAIIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7CAAD20", Offset = "0x7CA9520", VA = "0x187CAAD20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7CAABD0", Offset = "0x7CA93D0", VA = "0x187CAABD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public float DFEDMDDOOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7CAAC80", Offset = "0x7CA9480", VA = "0x187CAAC80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public Matrix4x4 BOIABGKDNPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7CAC520", Offset = "0x7CAAD20", VA = "0x187CAC520")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public HGEGIFKAJCN GIKNDILAGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(HGEGIFKAJCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	private EFICJEHFEEE HIBEMMMBGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7CAA690", Offset = "0x7CA8E90", VA = "0x187CAA690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC1A0", Offset = "0x7CAA9A0", VA = "0x187CAC1A0")]
	public AIFAFFNBDPH OHJGIOLCBPP()
	{
		return default(AIFAFFNBDPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB040", Offset = "0x7CA9840", VA = "0x187CAB040")]
	public void EHFELGGPNDN([Out] Matrix4x4 NNEKMEDCPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB970", Offset = "0x7CAA170", VA = "0x187CAB970")]
	public void JIDFKANEEIP([In] Vector3 IKAECBBFJHO, [In] Quaternion KOBOFDGKPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB8B0", Offset = "0x7CAA0B0", VA = "0x187CAB8B0")]
	public void JIDFKANEEIP([In] RigidTransform LAOFMLPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA7E0", Offset = "0x7CA8FE0", VA = "0x187CAA7E0")]
	public void BDEIGKLLBAL([Out] RigidTransform LAOFMLPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC2B0", Offset = "0x7CAAAB0", VA = "0x187CAC2B0")]
	public void PCJEGMOBMPK([In] Vector3 PCNFMONCJHL, [In] Quaternion BGFPHMGFCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC1F0", Offset = "0x7CAA9F0", VA = "0x187CAC1F0")]
	public void PCJEGMOBMPK([In] RigidTransform GGLAGEKANKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB3A0", Offset = "0x7CA9BA0", VA = "0x187CAB3A0")]
	public void FAMMHLIKBGF([Out] Vector3 PCNFMONCJHL, [Out] Quaternion BGFPHMGFCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB480", Offset = "0x7CA9C80", VA = "0x187CAB480")]
	public void FAMMHLIKBGF([Out] RigidTransform LAOFMLPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA7B0", Offset = "0x7CA8FB0", VA = "0x187CAA7B0")]
	public UniformTRS AILBIMGHJCN()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA6F0", Offset = "0x7CA8EF0", VA = "0x187CAA6F0")]
	public void AILBIMGHJCN([Out] UniformTRS GGLAGEKANKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7CABA70", Offset = "0x7CAA270", VA = "0x187CABA70")]
	public UniformTRS LDPNCBNLPEL()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x7CABAA0", Offset = "0x7CAA2A0", VA = "0x187CABAA0")]
	public void LDPNCBNLPEL([Out] UniformTRS LAOFMLPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x7CAAA30", Offset = "0x7CA9230", VA = "0x187CAAA30")]
	public Vector3 BICCFNODBNE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC450", Offset = "0x7CAAC50", VA = "0x187CAC450")]
	public void PKINDKBGBOO([In] Vector3 OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x7CABD00", Offset = "0x7CAA500", VA = "0x187CABD00")]
	public Vector3 MGGJGAMACGK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA960", Offset = "0x7CA9160", VA = "0x187CAA960")]
	public void BFHENGBDCPH([In] Vector3 OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7CAAF00", Offset = "0x7CA9700", VA = "0x187CAAF00")]
	public Quaternion DNBOAHGEBNP()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA890", Offset = "0x7CA9090", VA = "0x187CAA890")]
	public void BEHEKEFABJB([In] Quaternion OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB6A0", Offset = "0x7CA9EA0", VA = "0x187CAB6A0")]
	public Quaternion HKCCDFANAKH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7CABF90", Offset = "0x7CAA790", VA = "0x187CABF90")]
	public void OECKGJNNGNK([In] Quaternion OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB530", Offset = "0x7CA9D30", VA = "0x187CAB530")]
	public float GOOMPKCLJDI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x7CABC50", Offset = "0x7CAA450", VA = "0x187CABC50")]
	public void MCCAIBDACAG(float OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC3B0", Offset = "0x7CAABB0", VA = "0x187CAC3B0")]
	public float PHCCMEPGABD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x7CAAB20", Offset = "0x7CA9320", VA = "0x187CAAB20")]
	public void BJDAGDILMEO(float OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public CDFIMNOIJPM(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB310", Offset = "0x7CA9B10", VA = "0x187CAB310", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(CDFIMNOIJPM PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct EHCDEKIGHOL : IEquatable<EHCDEKIGHOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	private LKDBPLEOIHK PLMPBOEMGBM
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE0B0", Offset = "0x7CAC8B0", VA = "0x187CAE0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	private KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC8A0", VA = "0x187CAE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x7CADF60", Offset = "0x7CAC760", VA = "0x187CADF60")]
	public void CLBHGDAJADM(string LEKFEHEMONH, FALCLEJOKEC KIJJLOBIFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public EHCDEKIGHOL(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE110", Offset = "0x7CAC910", VA = "0x187CAE110", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(EHCDEKIGHOL PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct AFNLICJCECK : IEquatable<AFNLICJCECK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BC0", Offset = "0x7CA83C0", VA = "0x187CA9BC0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(AFNLICJCECK PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C80", Offset = "0x7CA8480", VA = "0x187CA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct BJJIAAPCIKL : IEquatable<BJJIAAPCIKL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public IHHMOLPFMOD JPNEDJEMINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7CAA1A0", Offset = "0x7CA89A0", VA = "0x187CAA1A0")]
		get
		{
			return default(IHHMOLPFMOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public BJJIAAPCIKL(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA110", Offset = "0x7CA8910", VA = "0x187CAA110", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(BJJIAAPCIKL PGPJMFPAKOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct NKMNBJCCLOD : IEquatable<NKMNBJCCLOD>
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public struct JLFPEGIMNGN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private FGFPKLDJIEL DGLFHMAFDAJ;

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7B70", Offset = "0x7CB6370", VA = "0x187CB7B70")]
		public JLFPEGIMNGN(FGFPKLDJIEL DGLFHMAFDAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7AE0", Offset = "0x7CB62E0", VA = "0x187CB7AE0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDC30", Offset = "0x7CBC430", VA = "0x187CBDC30")]
	public JLFPEGIMNGN LIDOJKMJGCF()
	{
		return default(JLFPEGIMNGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDA80", Offset = "0x7CBC280", VA = "0x187CBDA80")]
	public MBHPMHDKCBC HCCKDJDKDPJ(Allocator KKCJNCNIICO = Allocator.Temp)
	{
		return default(MBHPMHDKCBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD950", Offset = "0x7CBC150", VA = "0x187CBD950")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> HBNCJKENJHP(Allocator KKCJNCNIICO = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD6D0", Offset = "0x7CBBED0", VA = "0x187CBD6D0")]
	public NativeArray<EPFBCAMMJCA> AEAKHDKGNAH(Allocator KKCJNCNIICO = Allocator.Temp)
	{
		return default(NativeArray<EPFBCAMMJCA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD5A0", Offset = "0x7CBBDA0", VA = "0x187CBD5A0")]
	public NativeArray<EPFBCAMMJCA> ABOFOJLKMOE(Allocator KKCJNCNIICO = Allocator.Temp)
	{
		return default(NativeArray<EPFBCAMMJCA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDB70", Offset = "0x7CBC370", VA = "0x187CBDB70")]
	public DPONIGJFOLB JGKAFPICLOE(Allocator KKCJNCNIICO = Allocator.Temp)
	{
		return default(DPONIGJFOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD890", Offset = "0x7CBC090", VA = "0x187CBD890")]
	public DPONIGJFOLB GKPLIPAAOHD(Allocator KKCJNCNIICO = Allocator.Temp)
	{
		return default(DPONIGJFOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDCC0", Offset = "0x7CBC4C0", VA = "0x187CBDCC0")]
	public DPONIGJFOLB PIGKHFOJNDH(Allocator KKCJNCNIICO = Allocator.Temp)
	{
		return default(DPONIGJFOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public NKMNBJCCLOD(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD800", Offset = "0x7CBC000", VA = "0x187CBD800", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(NKMNBJCCLOD PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1920", Offset = "0x7CB0120", VA = "0x187CB1920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct PAMLJNDHIBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int AMNAMGKDDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int GINKLBFIKGE;
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct JPPDCKCEBKK : IEquatable<JPPDCKCEBKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public NKMNBJCCLOD JJMKMDJKJBG
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(NKMNBJCCLOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public GNFNIFCEKNK JBGJDBLIIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(GNFNIFCEKNK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public BJJIAAPCIKL DDFPOIBBNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(BJJIAAPCIKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7F50", Offset = "0x7CB6750", VA = "0x187CB7F50")]
	public bool DPALLFCDBBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8080", Offset = "0x7CB6880", VA = "0x187CB8080")]
	public bool KEIEKJJKBCC([Out] Exception HNILHIIFGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public JPPDCKCEBKK(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static FGFPKLDJIEL FGIKKMMHFBO(JPPDCKCEBKK OPMIAMEJKDH)
	{
		return default(FGFPKLDJIEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7FF0", Offset = "0x7CB67F0", VA = "0x187CB7FF0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(JPPDCKCEBKK PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1920", Offset = "0x7CB0120", VA = "0x187CB1920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct CBHNMODAFOP : IDisposable, IEquatable<CBHNMODAFOP>
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public static readonly CBHNMODAFOP KHBPMGHIGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public JPPDCKCEBKK CDKKILOLLJE
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(JPPDCKCEBKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public NKMNBJCCLOD JJMKMDJKJBG
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(NKMNBJCCLOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA440", Offset = "0x7CA8C40", VA = "0x187CAA440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public CBHNMODAFOP(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA510", Offset = "0x7CA8D10", VA = "0x187CAA510", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "5")]
	public bool Equals(CBHNMODAFOP PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA5A0", Offset = "0x7CA8DA0", VA = "0x187CAA5A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct GNFNIFCEKNK : IEquatable<GNFNIFCEKNK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public bool PBNEGOFDAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1800", Offset = "0x7CB0000", VA = "0x187CB1800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	public GNFNIFCEKNK(FGFPKLDJIEL DGLFHMAFDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9C50", Offset = "0x7CA8450", VA = "0x187CA9C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1890", Offset = "0x7CB0090", VA = "0x187CB1890", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9BB0", Offset = "0x7CA83B0", VA = "0x187CA9BB0", Slot = "4")]
	public bool Equals(GNFNIFCEKNK PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1920", Offset = "0x7CB0120", VA = "0x187CB1920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class BBPENKDGFJN
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private struct ELPDHNMMOEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Guid BGPPHEMBCAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public HHDFIJPNEIO JAOLDICAFLD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private struct HHDFIJPNEIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int OPMIAMEJKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int IJBDMIGIKHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int KLOBILDMOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int MHHFEKGEGFH;

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2F90", Offset = "0x7CB1790", VA = "0x187CB2F90")]
		public bool EBKMAMJPCJD([Out] EPFBCAMMJCA DMBOJOBJMEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3030", Offset = "0x7CB1830", VA = "0x187CB3030")]
		public HHDFIJPNEIO(EPFBCAMMJCA DMBOJOBJMEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9F80", Offset = "0x7CA8780", VA = "0x187CA9F80")]
	public static Guid LONDMIHLKKG(this EPFBCAMMJCA DMBOJOBJMEI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9F60", Offset = "0x7CA8760", VA = "0x187CA9F60")]
	public static bool EJJJLBIGMJN(this Guid BGPPHEMBCAA, [Out] EPFBCAMMJCA DMBOJOBJMEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
internal static class IEKAMLLJCEP
{
	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4B20", Offset = "0x7CB3320", VA = "0x187CB4B20")]
	public static KOJGGCMNOGM JKGJBDFHPNL(this FGFPKLDJIEL MLBCMOLHELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4BB0", Offset = "0x7CB33B0", VA = "0x187CB4BB0")]
	public static FHKJIGHACNJ POMJOMHKPIF(this FGFPKLDJIEL MLBCMOLHELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4A90", Offset = "0x7CB3290", VA = "0x187CB4A90")]
	public static EntityManager DAIKDJIAKCG(this FGFPKLDJIEL MLBCMOLHELH)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x37E5B50", Offset = "0x37E4350", VA = "0x1837E5B50")]
	internal static bool ICBKFHDJPFB<T>(this FGFPKLDJIEL MLBCMOLHELH, bool CEHDHOOIGBC) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4C10", Offset = "0x7CB3410", VA = "0x187CB4C10")]
	public static bool PPLFFCGHJJE(this FGFPKLDJIEL MLBCMOLHELH, GCGDFOMGHFM KIIAJPLCJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x37E5D10", Offset = "0x37E4510", VA = "0x1837E5D10")]
	public static bool JOEEFKDLHCC<T>(this FGFPKLDJIEL MLBCMOLHELH) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x37E6530", Offset = "0x37E4D30", VA = "0x1837E6530")]
	public static bool MCJAHIJNFKJ<T>(this FGFPKLDJIEL MLBCMOLHELH) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x37E1540", Offset = "0x37DFD40", VA = "0x1837E1540")]
	[FMOKBKACDAE]
	public static T EBLPNDHNCKF<T>(this FGFPKLDJIEL MLBCMOLHELH) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x37E32D0", Offset = "0x37E1AD0", VA = "0x1837E32D0")]
	[FMOKBKACDAE]
	public static T HKEFPOCHOBD<T>(this FGFPKLDJIEL MLBCMOLHELH) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x37E30C0", Offset = "0x37E18C0", VA = "0x1837E30C0")]
	public static bool ECHLLBEKDCL<T>(this FGFPKLDJIEL MLBCMOLHELH, [Out] T OPMIAMEJKDH) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x37E3200", Offset = "0x37E1A00", VA = "0x1837E3200")]
	public static T GJJEAAIPGHC<T>(this FGFPKLDJIEL MLBCMOLHELH) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x37E14A0", Offset = "0x37DFCA0", VA = "0x1837E14A0")]
	public static T DNAKPLBMFNK<T>(this FGFPKLDJIEL MLBCMOLHELH) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal static class KDHLCFMDMMG
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[DefaultMember("Item")]
public struct MBHPMHDKCBC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private DPONIGJFOLB GGBFBJAOFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> BEDIBNPBEDP;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB140", Offset = "0x5AE9940", VA = "0x185AEB140")]
	public MBHPMHDKCBC(DPONIGJFOLB GGBFBJAOFOK, NativeArray<EntityRemapUtility.EntityRemapInfo> BEDIBNPBEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x7CBAAD0", Offset = "0x7CB92D0", VA = "0x187CBAAD0")]
	public LocalId LBNDDGMBJFF(LocalId PNHCNFOFAFI)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBAB10", Offset = "0x7CB9310", VA = "0x187CBAB10")]
	public LocalId LBNDDGMBJFF(int FPEOONOJHML)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x7CBAA60", Offset = "0x7CB9260", VA = "0x187CBAA60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CLNDLOOGPJG
{
	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEMDEJHEOPG(World GOCNACMHICP, NativeParallelHashSet<FixedString64Bytes> AOGLJAKMPLL);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BAKEHHONAJF
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FHFHOLIMIDL(FGFPKLDJIEL GOKHBEHMPCJ, [Out] uint MLBCMOLHELH);

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LMDECMCJKME(FGFPKLDJIEL GOKHBEHMPCJ, [Out] uint MLBCMOLHELH);

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBEEEKLJEHB(FGFPKLDJIEL GOKHBEHMPCJ, uint MLBCMOLHELH);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BHMDMAJMIBE(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string GPEJHFJEEMB(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LEBPOJBGAIL(FGFPKLDJIEL GOKHBEHMPCJ, string MLBCMOLHELH);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DPLIOIGJMLF
{
	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	Guid EELIAAMEOBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	Guid AEJGFGEIODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ELNCEAALLEK(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task FLGFEKNOBPI(JAIEPPMCFLB PNHCNFOFAFI);

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid GDKBLOECKAA(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EHGMLDKLHHA(FGFPKLDJIEL DGLFHMAFDAJ, Guid OPPFCAMGFJA);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LMOCJEMFPKG(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task EDMLAOLMCKO(FGFPKLDJIEL NGDINOANFEF, FGFPKLDJIEL DFPCBMGPBFO);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HNLGFBANEKN
{
	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	Guid EELIAAMEOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLADPPKOOMB(NativeList<Guid> HMKHBBGACIB, NativeList<Guid> FOPDMKKOMHK, NativeList<FixedString64Bytes> NOFHJHBODEF);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NJNHJACBCAD
{
	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DPONIGJFOLB KMHMPHFHBOO(Allocator KKCJNCNIICO);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DPONIGJFOLB LJDIKLIGBKK(Allocator KKCJNCNIICO);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BPMFKOLGKBM(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PNAHHGJELCP(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ENAPOACFGLB(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ALMHFKBFOPB(FGFPKLDJIEL GOKHBEHMPCJ, int EIOPAHLHHKC);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FGFPKLDJIEL LAIOMDEGDDC(FGFPKLDJIEL PENIEFMJEJK);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IBNJCCLDCID(DPONIGJFOLB GAEDEONJGAN, bool MDCMDIHLPOG);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BANDPDDDEID(FGFPKLDJIEL GHMCDKKCGHO);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OADGANDPDPA(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AHLMGKPBFDB(FGFPKLDJIEL GOKHBEHMPCJ, bool MAKPEPBFONA);

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int OMADJGLEOBF();
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GODLKGCKBJN
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<FGFPKLDJIEL, FGFPKLDJIEL> KNAJNKHAMOF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<FGFPKLDJIEL, FGFPKLDJIEL> GDKODLBBOEP;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<FGFPKLDJIEL, FGFPKLDJIEL, FGFPKLDJIEL> CHNJCJGBFCO;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<FGFPKLDJIEL> GBMFILJMOOC;

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CMLGCCJCKEJ(FGFPKLDJIEL DGLFHMAFDAJ, FGFPKLDJIEL ABMMCPHJMGL);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FGFPKLDJIEL DLJEEFDNECC(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DPONIGJFOLB HJHAFOIBNDM(FGFPKLDJIEL DGLFHMAFDAJ, Allocator KKCJNCNIICO);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FGFPKLDJIEL ONOJDHLOFAI(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HCIBPNFNAMM(FGFPKLDJIEL DGLFHMAFDAJ, Vector3 FPOMPEMDEMP, Quaternion BEOOEAAADEN);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NBCNECGLKJA(FGFPKLDJIEL DGLFHMAFDAJ, float EIKFDBNGDHM);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool PIODJFADLMB(FGFPKLDJIEL DGLFHMAFDAJ, [Out] FGFPKLDJIEL DFPCBMGPBFO);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool JLLKELMEKJM(FGFPKLDJIEL DGLFHMAFDAJ, [Out] RigidTransform AKDHNOKLGHC);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 OKMOLLLLPBA(KLINFNEFFJL OKJLAPLBHOI);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion ABEENPFDEMM(KLINFNEFFJL OKJLAPLBHOI);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class PHMJPJIALEB
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KHDECKDGGAP
{
	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	object MMPCFANFGGI
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AKFLFPOJBPN
{
	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMIEOPPIPGB(FGFPKLDJIEL PNHCNFOFAFI, NKCKAAGEAMB MDOFGLOOKBP);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHIIADIOIME(NKCKAAGEAMB MDOFGLOOKBP);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FGAOHGMPPJL(FGFPKLDJIEL DGLFHMAFDAJ, [Out] NKCKAAGEAMB KMKEEEMPGCG);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[Flags]
public enum FLKPGJCFCFE
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
[Cpp2IlInjected.Token(Token = "0x2000093")]
public readonly struct PHHPLDFLCKP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly string GLGOHIJMLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly T LHCNPHOLELG;

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x555A5A0", Offset = "0x5558DA0", VA = "0x18555A5A0")]
	public PHHPLDFLCKP(T LHCNPHOLELG, [Optional][CallerMemberName] string GLGOHIJMLFB)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly PHHPLDFLCKP<int> ICBLMLJEGKD;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly PHHPLDFLCKP<int> LDCOPHBOFGK;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly PHHPLDFLCKP<int> AOOAEBPJMDK;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public enum NLPPPKGGOBJ
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class BFMJDACCBOI
{
	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x12106E0", Offset = "0x120EEE0", VA = "0x1812106E0")]
	public static bool EIHKIOFBGBH(this NLPPPKGGOBJ LLNIPANPIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x15E7E40", Offset = "0x15E6640", VA = "0x1815E7E40")]
	public static bool FFCNIJFMGMO(this NLPPPKGGOBJ LLNIPANPIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x2D98AA0", Offset = "0x2D972A0", VA = "0x182D98AA0")]
	public static bool IKDIBLCCHDG(this NLPPPKGGOBJ LLNIPANPIOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CDOANDEPEMK
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public enum NCFHEEANLOD
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

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public enum AKHNKGHCFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	NCFHEEANLOD CGEBLJMNOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	bool JLJLNCEGEKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	bool MJAIPHKJPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	AKHNKGHCFLJ GLHAKBEMLCO
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ServiceLifetime(Lifetime.Application)]
public interface IKKDIMICPHE
{
	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	NLPPPKGGOBJ JEPCGDOCNKF
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	NLPPPKGGOBJ LMNLEEHCNJH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	NLPPPKGGOBJ HPIEHJAFDGA
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	NLPPPKGGOBJ MCKFNIJNPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	NLPPPKGGOBJ PBDNLNACDOM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	NLPPPKGGOBJ AOLJNKLNJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	NLPPPKGGOBJ LKEOIHPELFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	NLPPPKGGOBJ COMGFDPJGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	NLPPPKGGOBJ NKPAHFFDBGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	NLPPPKGGOBJ GODPPDHCCGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	NLPPPKGGOBJ OLMOADGCNJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	NLPPPKGGOBJ AEJNINIBGML
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	NLPPPKGGOBJ BEDACCAJHEN
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	NLPPPKGGOBJ CFBLKGFHKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	NLPPPKGGOBJ DOPOJMKIGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	NLPPPKGGOBJ HPKJCINLEPG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	NLPPPKGGOBJ LNEGLEJLJIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	NLPPPKGGOBJ FHCOMAGGOBG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int EFPADONOPCC(PHHPLDFLCKP<int> PKENAIPAKDA);
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KOMJNIJGCJJ
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event JBJEOPODDJF.PLJACGHLGCC DJBONNEEGDL;

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FGFPKLDJIEL MFKDGJOFMOG(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DPONIGJFOLB KFLOHIKMKCH(Allocator KKCJNCNIICO);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LHFAABAKNBI NPHDJKNCFNK(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PCEHALHFDFM(IEnumerable<FGFPKLDJIEL> KFDDIKDMKEB);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LHFAABAKNBI NENMECNADDM(FGFPKLDJIEL DFPCBMGPBFO, FGFPKLDJIEL GGBFBJAOFOK, bool AGFGGMNJJIG, FGFPKLDJIEL ALLFIKNKLHM);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FGFPKLDJIEL ENELMFFLDAO(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GDNIECKCIEP(FGFPKLDJIEL DGLFHMAFDAJ, FGFPKLDJIEL DFPCBMGPBFO, bool ABFEHPEBJCO = false);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NNILPHIMKLB(FGFPKLDJIEL DGLFHMAFDAJ, FGFPKLDJIEL DFPCBMGPBFO);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OKELKMNLOJK(FGFPKLDJIEL EJLJCFJAFJI, FGFPKLDJIEL BEPGBEHMMAB);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	DPONIGJFOLB IMIKFINLBID(FGFPKLDJIEL GHMCDKKCGHO);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BGJNDNOFGNM(FGFPKLDJIEL DGLFHMAFDAJ, FGFPKLDJIEL IEEEDCKFECE);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DPONIGJFOLB FCBDPKAOJEJ(DPONIGJFOLB EFPMMBOGHCF, FLKPGJCFCFE ENMPGGCMLIP, Allocator KKCJNCNIICO);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool ELIPNFPBEMD(FGFPKLDJIEL DGLFHMAFDAJ, FGFPKLDJIEL LIGGNDMEMHD);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FGFPKLDJIEL AGENNKMHMMK(FGFPKLDJIEL ALLFIKNKLHM, FGFPKLDJIEL CMGLCBFABDM);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool FJLDIFPMPAM(FGFPKLDJIEL ALLFIKNKLHM, FGFPKLDJIEL CMGLCBFABDM, [Out] FGFPKLDJIEL EGNIEDOCHLI);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "17")]
	FGFPKLDJIEL CGKPFDBKGGL(FGFPKLDJIEL[] GAEDEONJGAN);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "18")]
	FGFPKLDJIEL ICGLNADJCKO(FGFPKLDJIEL DGLFHMAFDAJ, uint DHOLNPBNFDH);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public static class OBHAALNJKBO
{
	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDF60", Offset = "0x7CBC760", VA = "0x187CBDF60")]
	public static bool EEIMJJONDNM(this KOMJNIJGCJJ MDDANENBEND, FGFPKLDJIEL DGLFHMAFDAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDFD0", Offset = "0x7CBC7D0", VA = "0x187CBDFD0")]
	public static DPONIGJFOLB FCBDPKAOJEJ(this KOMJNIJGCJJ KICOAPCJPFE, FGFPKLDJIEL DGLFHMAFDAJ, FLKPGJCFCFE ENMPGGCMLIP, Allocator KKCJNCNIICO)
	{
		return default(DPONIGJFOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE260", Offset = "0x7CBCA60", VA = "0x187CBE260")]
	public static DPONIGJFOLB HBMIPADHIGN(this KOMJNIJGCJJ KICOAPCJPFE, FGFPKLDJIEL DGLFHMAFDAJ, Allocator KKCJNCNIICO)
	{
		return default(DPONIGJFOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE4C0", Offset = "0x7CBCCC0", VA = "0x187CBE4C0")]
	public static DPONIGJFOLB PDMFGLKLABM(this KOMJNIJGCJJ KICOAPCJPFE, FGFPKLDJIEL DGLFHMAFDAJ, Allocator KKCJNCNIICO)
	{
		return default(DPONIGJFOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE480", Offset = "0x7CBCC80", VA = "0x187CBE480")]
	public static DPONIGJFOLB OHIBLLCFKDB(this KOMJNIJGCJJ KICOAPCJPFE, FGFPKLDJIEL DGLFHMAFDAJ, Allocator KKCJNCNIICO)
	{
		return default(DPONIGJFOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE440", Offset = "0x7CBCC40", VA = "0x187CBE440")]
	public static DPONIGJFOLB KPBEEJEJHKA(this KOMJNIJGCJJ KICOAPCJPFE, FGFPKLDJIEL DGLFHMAFDAJ, Allocator KKCJNCNIICO)
	{
		return default(DPONIGJFOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE400", Offset = "0x7CBCC00", VA = "0x187CBE400")]
	public static DPONIGJFOLB ICJFGMAPJPF(this KOMJNIJGCJJ KICOAPCJPFE, FGFPKLDJIEL DGLFHMAFDAJ, Allocator KKCJNCNIICO)
	{
		return default(DPONIGJFOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE2A0", Offset = "0x7CBCAA0", VA = "0x187CBE2A0")]
	public static DPONIGJFOLB HFPNCPECCKB(this KOMJNIJGCJJ KICOAPCJPFE, FGFPKLDJIEL DGLFHMAFDAJ, Allocator KKCJNCNIICO)
	{
		return default(DPONIGJFOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE2E0", Offset = "0x7CBCAE0", VA = "0x187CBE2E0")]
	public static DPONIGJFOLB HFPNCPECCKB(this KOMJNIJGCJJ KICOAPCJPFE, DPONIGJFOLB DGLFHMAFDAJ, Allocator KKCJNCNIICO)
	{
		return default(DPONIGJFOLB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LGODHAOEKND
{
	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PBJOOGKFKOE OOEFPKGBIKC(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBCJKCKKHFN(FGFPKLDJIEL GOKHBEHMPCJ, PBJOOGKFKOE GHHJJCPCHAI);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HBIPJCIPLAF(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CGABDIGCFAE(FGFPKLDJIEL GOKHBEHMPCJ, bool OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JMGGLJLNFLA<string> MPFJJADHJOA(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MGKOLBNBPBP(FGFPKLDJIEL GOKHBEHMPCJ, JMGGLJLNFLA<string> CHKOHMIIEJH);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JMGGLJLNFLA<string> KAHAPECPPOD(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OOLJIDHPHDD(FGFPKLDJIEL GOKHBEHMPCJ, JMGGLJLNFLA<string> CHKOHMIIEJH);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JMGGLJLNFLA<string> AENNGPDONKO(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BLMAEMCBIAD(FGFPKLDJIEL GOKHBEHMPCJ, JMGGLJLNFLA<string> CHKOHMIIEJH);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JMGGLJLNFLA<string> GINOCPPMPGO(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IGHLELEGALG(FGFPKLDJIEL GOKHBEHMPCJ, JMGGLJLNFLA<string> CHKOHMIIEJH);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ACIDMBCIKPN(FGFPKLDJIEL GOKHBEHMPCJ, FGFPKLDJIEL PPBALHIMPIH);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HIEHDDMHKLI
{
	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3070", Offset = "0x7CB1870", VA = "0x187CB3070", Slot = "0")]
	Task<JPPDCKCEBKK> CIABDLJHHJM(DKLAEGBPMFH DOPIMMMIBFB, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "1")]
	void JIPKIMPGBKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DBJIFOGNHIO
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event JBJEOPODDJF.PLJACGHLGCC DJBONNEEGDL;

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FGFPKLDJIEL ENELMFFLDAO(FGFPKLDJIEL NGDINOANFEF);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<FGFPKLDJIEL> ELLBIELPOJL();

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<FGFPKLDJIEL> DPEANELDHIP(FGFPKLDJIEL DFPCBMGPBFO);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BFCKIKEEECJ(FGFPKLDJIEL EPNIFJBOHFH, FGFPKLDJIEL GABCKPFBCHE, [Out] LHFAABAKNBI NLBKGOFEKJH);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HLNOGHGEDOI(FGFPKLDJIEL EPNIFJBOHFH, FGFPKLDJIEL ALJFMCDOLHI, [Out] LHFAABAKNBI NLBKGOFEKJH);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DKLMPCJJNDC(FGFPKLDJIEL EPNIFJBOHFH);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NNILPHIMKLB(FGFPKLDJIEL GCBKJOJEIKL, FGFPKLDJIEL GPDOCAJDCGI);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LHFAABAKNBI ACMNDMDFANN(FGFPKLDJIEL DGLFHMAFDAJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MPMGNAFDKAM
{
	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	bool JPLJIMDBPLF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	bool FBCCPOJBCIC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	bool PHJIDFPKFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LJJGPOPNLPE
{
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EEMICJDFJCK
{
	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGBCNNNALOP(FGFPKLDJIEL DGLFHMAFDAJ, GCGDFOMGHFM KIIAJPLCJIE);

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNEBIGHCPOJ(FGFPKLDJIEL DGLFHMAFDAJ, GCGDFOMGHFM KIIAJPLCJIE);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FMDDHDAPDGK
{
	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CDHDNBFOKPK([In] float3 HBMCBDFIIOP, [In] float3 ELEEIMOLKDP, float ECLNGJKMDDA, [Out] JLCPOPAOPMC AENJOMGNAAL, [Out] FGFPKLDJIEL MAPHNMEPAOC);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int DAMIFFODKNL([In] float3 HBMCBDFIIOP, float BCDEDKPOOJB, List<FGFPKLDJIEL> GAEDEONJGAN);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int JKILGJMCOGH(Plane[] KCFFKCAEFCG, float3 HBMCBDFIIOP, float3 PIFHIFKACOG, quaternion PMHMEKBKJJA, List<FGFPKLDJIEL> GAEDEONJGAN);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CGBIECNMFOO
{
	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDHDNBFOKPK([In] NativeArray<Entity> OOCEMABKIJN, [In] float3 HBMCBDFIIOP, [In] float3 ELEEIMOLKDP, [In] NativeArray<JLCPOPAOPMC> MHGAFKNLMFL);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> DAMIFFODKNL([In] NativeArray<Entity> OOCEMABKIJN, [In] float3 HBMCBDFIIOP, float BCDEDKPOOJB);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> JKILGJMCOGH([In] NativeArray<Entity> OOCEMABKIJN, [In] NativeArray<float4> CAPJFJDKHPC);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct KKHIOKKOJAP : KAICMPMFPHE, IEquatable<KKHIOKKOJAP>
{
	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public int NHCKMLOFHLI
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x127A100", Offset = "0x1278900", VA = "0x18127A100", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public int ILGJIFNMLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0CE0", Offset = "0x2DAF4E0", VA = "0x182DB0CE0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x6D588B0", Offset = "0x6D570B0", VA = "0x186D588B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9680", Offset = "0x7CB7E80", VA = "0x187CB9680", Slot = "8")]
	public bool Equals(KKHIOKKOJAP PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x7CB96D0", Offset = "0x7CB7ED0", VA = "0x187CB96D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct JLCPOPAOPMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public float AKKGPFGELLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public float3 GLANACDLEOF;
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JCLDGMDIFKN
{
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EFICJEHFEEE
{
	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	IMKLBBCIIKG FLLPLEDEMEC
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<DPONIGJFOLB, NativeArray<RRObjectPrefabData>> MDKNMGIKILC;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<DPONIGJFOLB> DFOCJGPLIFO;

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DPONIGJFOLB LFNGJMADAJM();

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KPAHBABLLHC CFFNGBIHAKL(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	RRObjectPrefabData FJOBKPCBHGI(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ALIFBLHLHGM(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JAIEPPMCFLB MMAGBEONLHE(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MCEJCCPHMKJ(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MDLEAMMMPKH(FGFPKLDJIEL DGLFHMAFDAJ, [Out] Transform POFBAOBKAGL);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FGFPKLDJIEL CMHJBHJFJHC(EPFBCAMMJCA DMBOJOBJMEI);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool IAHLDMOJMCJ(EPFBCAMMJCA DMBOJOBJMEI, [Out] FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EPFBCAMMJCA KJMEHAIEIAD(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "16")]
	DPONIGJFOLB CMHJBHJFJHC(NativeArray<EPFBCAMMJCA> DMBOJOBJMEI, Allocator KKCJNCNIICO, bool IMJBFGGCBHP = true);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ANJDNJJOFJK(RRObjectPrefabData FGKCPBHGPJL, NativeArray<Entity> OOCEMABKIJN);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool JLJGEPIHBAK(NativeArray<FBIOHAIPMGF> LHKDNNFNLIC, NativeArray<EPFBCAMMJCA> PAICEPEEJPJ, NativeArray<Entity> PGOADKAKHGL);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "19")]
	JAIEPPMCFLB GDFCDHLMIIO();

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "20")]
	JAIEPPMCFLB IBPJHMCGPID(RRObjectPrefabData FGKCPBHGPJL);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "21")]
	HKIMKJHJGKF KBBLBFEMLFL();

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	IEELNOOEJIA KOBINBOGOCA();

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "23")]
	JNBIHFOAGIL NFCDPDKCLCN(INNMCPGDHCO IKJHJAKGMGG);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PEEEOGCGDOB(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool DKGOCHGPNLO(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	DPONIGJFOLB NEDICMLOPNJ(DPONIGJFOLB NDLGAFEDCEK, Allocator KKCJNCNIICO);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool IPJBOCLFEHF(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool BACEFJBIMGM(FGFPKLDJIEL DGLFHMAFDAJ, ComponentTypes LHEKOBJHPPK);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "29")]
	FGFPKLDJIEL EGGNADIKGED(Transform POFBAOBKAGL);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class ILKBPFLIJIO
{
	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5A00", Offset = "0x7CB4200", VA = "0x187CB5A00")]
	internal static FGFPKLDJIEL IPCCKNGEJHB(this Entity EAALLGNPDMK, EFICJEHFEEE KIJJLOBIFNN)
	{
		return default(FGFPKLDJIEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x7CB56A0", Offset = "0x7CB3EA0", VA = "0x187CB56A0")]
	public static JAIEPPMCFLB FEBNOHEAMKG(this EFICJEHFEEE KIJJLOBIFNN, LocalId DGLFHMAFDAJ)
	{
		return default(JAIEPPMCFLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x7CB55C0", Offset = "0x7CB3DC0", VA = "0x187CB55C0")]
	public static FGFPKLDJIEL CMHJBHJFJHC(this EFICJEHFEEE KIJJLOBIFNN, LocalId DGLFHMAFDAJ)
	{
		return default(FGFPKLDJIEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5AB0", Offset = "0x7CB42B0", VA = "0x187CB5AB0")]
	public static EPFBCAMMJCA KJMEHAIEIAD(this EFICJEHFEEE KIJJLOBIFNN, LocalId DGLFHMAFDAJ)
	{
		return default(EPFBCAMMJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x7CB56B0", Offset = "0x7CB3EB0", VA = "0x187CB56B0")]
	public static HKIMKJHJGKF HIOKALJCAMH(this EFICJEHFEEE KIJJLOBIFNN, RigidTransform GGLAGEKANKP)
	{
		return default(HKIMKJHJGKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5850", Offset = "0x7CB4050", VA = "0x187CB5850")]
	public static JNBIHFOAGIL IGCCGEFLLPO(this EFICJEHFEEE KIJJLOBIFNN, INNMCPGDHCO KJNOHGKHCJC, RigidTransform GGLAGEKANKP)
	{
		return default(JNBIHFOAGIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5B20", Offset = "0x7CB4320", VA = "0x187CB5B20")]
	public static IEELNOOEJIA PCIGBDIGAGE(this EFICJEHFEEE KIJJLOBIFNN, RigidTransform GGLAGEKANKP)
	{
		return default(IEELNOOEJIA);
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5670", Offset = "0x7CB3E70", VA = "0x187CB5670")]
	private static void DCFDENIKAMG(JAIEPPMCFLB AKEHEMPNMOK, RigidTransform GGLAGEKANKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal interface JELPCBOPLAN
{
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IKJIEEDFKNA
{
	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	bool KDOLLHGPDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	FGFPKLDJIEL NPJHGADIBIM
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	JAIEPPMCFLB ALEMHIDDCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event BDBHGPPMPIK CIGNAMOKCOA;

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FGFPKLDJIEL AGENNKMHMMK(FGFPKLDJIEL ALLFIKNKLHM, FGFPKLDJIEL CMGLCBFABDM);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FJLDIFPMPAM(FGFPKLDJIEL ALLFIKNKLHM, FGFPKLDJIEL CMGLCBFABDM, [Out] FGFPKLDJIEL EGNIEDOCHLI);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FBANBMPCLEB();

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LGHOIIBDBCA();

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LFAOPMLBHPE(FGFPKLDJIEL ALLFIKNKLHM);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PCOMHAPOPLE(FGFPKLDJIEL ALLFIKNKLHM);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public delegate void BDBHGPPMPIK(JAIEPPMCFLB DHGMGMHJCKC, JAIEPPMCFLB NPDMIGCGOKI);
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class BKPAJOFLNAB
{
	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA3F0", Offset = "0x7CA8BF0", VA = "0x187CAA3F0")]
	public static bool PHPBILOKGHN(this IKJIEEDFKNA GGJHNOCCFNF, JAIEPPMCFLB ALLFIKNKLHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA290", Offset = "0x7CA8A90", VA = "0x187CAA290")]
	public static bool HOEIFDNGBKE(this IKJIEEDFKNA GGJHNOCCFNF, FGFPKLDJIEL ALLFIKNKLHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA370", Offset = "0x7CA8B70", VA = "0x187CAA370")]
	public static bool IKPBCICMMBK(this IKJIEEDFKNA GGJHNOCCFNF, FGFPKLDJIEL ALLFIKNKLHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PNGMEOJDNHP
{
	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPMCHDGNHNE(NativeList<RRObjectPrefabData> IMDCJLMPBPM);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HGPBHOIABME
{
	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OAKLIANGHBG(JAIEPPMCFLB AKEHEMPNMOK, OCDLEPLDLBO KJHADNKKPBJ, List<JAIEPPMCFLB> FNEFJGHGJFO);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int HPJKGBCKADJ(JAIEPPMCFLB AKEHEMPNMOK, OCDLEPLDLBO KJHADNKKPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NFMBAOLHOFL(JAIEPPMCFLB AKEHEMPNMOK, List<JAIEPPMCFLB> FNEFJGHGJFO);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int EPEAOGKBKKK(JAIEPPMCFLB PIDPEOCOGMC, JAIEPPMCFLB ALLFIKNKLHM, OCDLEPLDLBO KJHADNKKPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JAIEPPMCFLB MDDBNEMKLIG(JAIEPPMCFLB PIDPEOCOGMC, int FPEOONOJHML, OCDLEPLDLBO KJHADNKKPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FHFDODODGFG(JAIEPPMCFLB PIDPEOCOGMC, JAIEPPMCFLB ALLFIKNKLHM, OCDLEPLDLBO KJHADNKKPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IBAKHGAMKIB(JAIEPPMCFLB PIDPEOCOGMC, JAIEPPMCFLB ALLFIKNKLHM, OCDLEPLDLBO KJHADNKKPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OHMHAJGENAH(JAIEPPMCFLB PIDPEOCOGMC, OCDLEPLDLBO KJHADNKKPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FFEKIIBJBCJ(JAIEPPMCFLB PIDPEOCOGMC, JAIEPPMCFLB ALLFIKNKLHM, OCDLEPLDLBO KJHADNKKPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BDBHBPHIIMI(Entity PIDPEOCOGMC, Entity ALLFIKNKLHM, OCDLEPLDLBO KJHADNKKPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GDBGJLKNAAB(Entity PIDPEOCOGMC, OCDLEPLDLBO KJHADNKKPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EGKMJHLAFNP(JAIEPPMCFLB ALLFIKNKLHM, OCDLEPLDLBO KJHADNKKPBJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OLEKALOLFKN
{
	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	BJJIAAPCIKL IKMOJFEEELC
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IHHMOLPFMOD IKOEJGJKFHD(BJJIAAPCIKL MGAACDLILLD);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BJJIAAPCIKL EOANNDCPDFC();

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BJJIAAPCIKL PKNDOJEFHEI();
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EFEKNHONLLK
{
	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NGBAIPKEBLH(FGFPKLDJIEL ALLFIKNKLHM, FGFPKLDJIEL GLIHBFGDOCO);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IGKMADOBPKE(FGFPKLDJIEL ALLFIKNKLHM, FGFPKLDJIEL KOCEIDEJIGJ);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DIIOOPLMIMJ(FGFPKLDJIEL ALLFIKNKLHM, [Out] FGFPKLDJIEL LFCKAEHPGHP);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FDGEPCBPMOO
{
	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNKAFBMGBBK(FGFPKLDJIEL GHMCDKKCGHO, bool OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJCIBCHLLOI(FGFPKLDJIEL GHMCDKKCGHO, bool OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LPOICIBNFEI(FGFPKLDJIEL GHMCDKKCGHO, int OPMIAMEJKDH);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KGJFFJIGIDO
{
	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<FGFPKLDJIEL> FLPPENLKNMB(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FGFPKLDJIEL GNEOONEDMDI(FGFPKLDJIEL DGLFHMAFDAJ, int FPEOONOJHML);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GCIKFPGHBDA(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IGMEPMPFKOO CFCJAJEPPMH(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GDLGFLBOJBN(FGFPKLDJIEL DGLFHMAFDAJ, IGMEPMPFKOO KIAKHLGFPAF);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FGFPKLDJIEL GILJKADOFGG(FGFPKLDJIEL DGLFHMAFDAJ, [Optional] float3? NCGKJMOKFAF, [Optional] quaternion? PMHMEKBKJJA, [Optional] float3? EGLHBCAIJLF);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FGFPKLDJIEL PEMCMHFGNEM(FGFPKLDJIEL DGLFHMAFDAJ, int FPEOONOJHML, [Optional] float3? NCGKJMOKFAF, [Optional] quaternion? PMHMEKBKJJA, [Optional] float3? EGLHBCAIJLF);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DIHNJKKOACN(FGFPKLDJIEL DGLFHMAFDAJ, int FPEOONOJHML);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DLMEGPPEOMC(FGFPKLDJIEL DGLFHMAFDAJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OKNHCIALBAJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HDBIMJGHPFI
{
	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	bool PLDJGMBBCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDIHHICCPKB();

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JNJNIABBOEO();

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BNFNCMAAFHH();

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OGGFKFJPALF();

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void INCEJBPDGAF();

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MHPHHJHELLF();

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AHNCNDHJCJO();

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ENDBOPJEFMM();

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GIHEFGJICEK();

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NCMJEEGMHBH();

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NJGEPOKMLMK();

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KAAFIHDLFIK();
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ADLHIHAEEOL
{
	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OJJBICNMILG(FGFPKLDJIEL ALLFIKNKLHM, [Out] int PIDPEOCOGMC);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADBCPPDHLPM(FGFPKLDJIEL ALLFIKNKLHM, int PIDPEOCOGMC);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIEMBJCCHOC(FGFPKLDJIEL ALLFIKNKLHM, bool AABNLKFMPGO);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IGJKNNJEBCM(FGFPKLDJIEL ALLFIKNKLHM, float NHKBONPKEAL, float EOABHEIFOIL, float JLBDHLENJDO);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LCAEFMPCLHE(FGFPKLDJIEL DGLFHMAFDAJ, [Out] float EOABHEIFOIL, [Out] float JLBDHLENJDO);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NOCJPOKJIID(FGFPKLDJIEL ALLFIKNKLHM, float3 NCGKJMOKFAF, quaternion PMHMEKBKJJA);

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PGPPAAOMEEA(FGFPKLDJIEL ALLFIKNKLHM, [Out] float3 NCGKJMOKFAF, [Out] quaternion PMHMEKBKJJA);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EIOOFLJHDPN(FGFPKLDJIEL ALLFIKNKLHM);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GLMBECBONIF
{
	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKINDKBGBOO(Entity EAALLGNPDMK, [In] float3 OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 BICCFNODBNE(Entity EAALLGNPDMK);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEHEKEFABJB(Entity EAALLGNPDMK, [In] quaternion OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion DNBOAHGEBNP(Entity EAALLGNPDMK);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JIDFKANEEIP(Entity EAALLGNPDMK, [In] float3 NCGKJMOKFAF, [In] quaternion PMHMEKBKJJA);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BDEIGKLLBAL(Entity EAALLGNPDMK, [Out] RigidTransform NAIBNNNHEIO);

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PCJEGMOBMPK(Entity EAALLGNPDMK, [In] float3 NCGKJMOKFAF, [In] quaternion PMHMEKBKJJA);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FAMMHLIKBGF(Entity EAALLGNPDMK, [Out] float3 NCGKJMOKFAF, [Out] quaternion PMHMEKBKJJA);

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FAMMHLIKBGF(Entity EAALLGNPDMK, [Out] RigidTransform NAIBNNNHEIO);

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MCCAIBDACAG(Entity EAALLGNPDMK, float OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float GOOMPKCLJDI(Entity EAALLGNPDMK);

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BFHENGBDCPH(Entity EAALLGNPDMK, [In] float3 OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 MGGJGAMACGK(Entity EAALLGNPDMK);

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OECKGJNNGNK(Entity EAALLGNPDMK, [In] quaternion OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion HKCCDFANAKH(Entity EAALLGNPDMK);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BJDAGDILMEO(Entity EAALLGNPDMK, float OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float PHCCMEPGABD(Entity EAALLGNPDMK);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IBOEBMIOFBC(Entity EAALLGNPDMK, [Out] float4x4 NNEKMEDCPOO);

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IJBGGOCCNNF(Entity EAALLGNPDMK, [In] float4x4 NNEKMEDCPOO);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DNHOONAFJJN(Entity EAALLGNPDMK);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FLADEKBEJHF(Entity EAALLGNPDMK, Entity HLEGNILMIKJ, Entity GPDOCAJDCGI);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class HMNMLKGBJMB
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NNGFBEACHAB
{
	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFJGFNBMJEA(bool POJMALAACLJ);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LKDBPLEOIHK
{
	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGABOBMHHFG(FGFPKLDJIEL GOKHBEHMPCJ, JMGGLJLNFLA<string> CHKOHMIIEJH);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNIIKELJLGA(FGFPKLDJIEL GOKHBEHMPCJ, JMGGLJLNFLA<string> CHKOHMIIEJH);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BCIIPDBPHJJ(FGFPKLDJIEL GOKHBEHMPCJ, JMGGLJLNFLA<string> CHKOHMIIEJH);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void COENKMHLOAH(FGFPKLDJIEL GOKHBEHMPCJ, JMGGLJLNFLA<string> CHKOHMIIEJH);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDLPOGKBMKP(FGFPKLDJIEL GOKHBEHMPCJ, JMGGLJLNFLA<string> CHKOHMIIEJH);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LMDIJONFJNJ(FGFPKLDJIEL GOKHBEHMPCJ, JMGGLJLNFLA<string> CHKOHMIIEJH);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int IAFJIPOLBMP(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int KJLLIMJLMGI(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int MOKOPGLAJGP(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JNOBHPMEBLN<string> HJNLGCBAJDL(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OJJLKMKBGGL(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JNOBHPMEBLN<string> AIKMAKBGKDK(FGFPKLDJIEL GOKHBEHMPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HFPBDDGOFJB(FGFPKLDJIEL GOKHBEHMPCJ, string LEKFEHEMONH);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AIKGCMJDEAB(string LEKFEHEMONH, FALCLEJOKEC LKDELALLEBC);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FGFPKLDJIEL PEOHFNHEHEF(string LEKFEHEMONH);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FIJPKIJHFDF(string LEKFEHEMONH, FALCLEJOKEC LKDELALLEBC);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CLBHGDAJADM(FGFPKLDJIEL ODHANJCPHJK, string LEKFEHEMONH, FALCLEJOKEC LKDELALLEBC);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class MOPNIHBEDDO
{
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NKAFFJGFNNL
{
	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World LONAHHGIJPJ(string DCCCAGPMHAJ = "Main");

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World LLKEMJDINIH(string DCCCAGPMHAJ = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World AFJOIOOCBCK(string DCCCAGPMHAJ = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World ICDJOPLEKMK(string DCCCAGPMHAJ = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FHKJIGHACNJ
{
	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	World EKEFCOCCMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	World IDAEKLDNHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	EntityManager DAIKDJIAKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	bool ABPKKBNEOIA
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase MEPKBJMPEMN(Type PIJHKCJDAHO);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public static class AANFIFCGAPB
{
	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9A40", Offset = "0x7CA8240", VA = "0x187CA9A40")]
	public static ComponentSystemBase LKBBNJKPJLB(this World GOCNACMHICP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x3EFD360", Offset = "0x3EFBB60", VA = "0x183EFD360")]
	public static T MEPKBJMPEMN<T>(this FHKJIGHACNJ ILIHMGJKJBL) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IDPMCOIBDFK
{
	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HAADMJPEPFE(NativeListAsync<Entity> IKDMOHMLPBF);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGIJBJAEKDK(NHBNOFIDAKN IEDJLEBOCFM);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKMJCLPELAO(NativeListAsync<Entity> BPONAIHEJHM, bool JMGDCCNPBCI);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GECGFBJMGPO();

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HHCKMGPMOPM(Entity PNDCHGJLEGG);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LOIGJFJHEDG
{
	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HCJOFDGLOAE(Collider BMLEIFODCAD, [Out] HHHFGKDAGPO FCLDMCEGHPB);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DCOIIMPPJDP
{
	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider IBOFCECHHNM(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject LKLKOMIMOHF(FGFPKLDJIEL MKCCLNEJMJP, GameObject GLNOEJGIDBO, Vector3 IKAECBBFJHO, Quaternion KOBOFDGKPML);

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KBIHGLIDAJK(GameObject BMLEIFODCAD);

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider PHDCEHDOCOM<TCollider>(GameObject LBMGEAJFJBP) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NPAIBHBOACB(Collider BMLEIFODCAD);

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject JGEJBCFILED<TCollider>(string GLGOHIJMLFB) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KNHIBECPCDK EPAOCNLIOCA(FGFPKLDJIEL OEHIEDJFCEB, FGFPKLDJIEL MOEAAHCFEFD, INNMCPGDHCO HJFHFLKBEPK, float3 AEAIADEGMEJ, quaternion CMLBBLEKDNJ, float3 JDMHKICIBAK);

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MDDCGCOPCLD(FGFPKLDJIEL DGLFHMAFDAJ, [Out] KNHIBECPCDK BMLEIFODCAD);

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LNPDDHOKIMD(FGFPKLDJIEL DGLFHMAFDAJ, [Out] FGFPKLDJIEL PNDCHGJLEGG);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public enum IJEKDLNEDAM
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
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LONGCCCLIGA
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public struct KPGLNHFHDKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int HJFHFLKBEPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public GameObject GLNOEJGIDBO;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONPNCKAAPOD(FGFPKLDJIEL DGLFHMAFDAJ, BJAFCOANKPJ ONLMAGFCCNK, bool GGFPCFJIABB, LJAJHDLLPIK JPHFDJHCNLI);

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPOIIOPEKKN(FGFPKLDJIEL DGLFHMAFDAJ, BJAFCOANKPJ ONLMAGFCCNK, bool GGFPCFJIABB, bool ANCMCAKBFIE, bool ONGGPJHMOOL);

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EECHAHGKDLL PJEGOFDOENB(FGFPKLDJIEL PNDCHGJLEGG, List<FGFPKLDJIEL> KMDHDMMKOPJ);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KNHIBECPCDK BAMNCONJLCE(GameObject NEHEDCEPFFI, GameObject GFBPHDOPEHF);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AJAPPFHKNMG(GameObject NEHEDCEPFFI, List<GameObject> MLMCLKACCGC);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NLNBDJMMFDB(GameObject GFBPHDOPEHF);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T PHDCEHDOCOM<T>(GameObject LBMGEAJFJBP) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NPAIBHBOACB(Collider BMLEIFODCAD);

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject LEDCLBCGPLL<T>(string GLGOHIJMLFB) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OKOODNJMHGN(Collider BMLEIFODCAD, [Out] FGFPKLDJIEL PIDPEOCOGMC);

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool PHNLMBFHCEG(FGFPKLDJIEL DGLFHMAFDAJ, [Out] HHHFGKDAGPO FCLDMCEGHPB);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<IJEKDLNEDAM> JFANJDKHJMK(Allocator KKCJNCNIICO = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] EPPFOFHCGJI();
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DBFKAHIMBKK
{
	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFLMNIPCHGD(FGFPKLDJIEL DGLFHMAFDAJ, FGFPKLDJIEL OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMBFIEHHGPA(FGFPKLDJIEL DGLFHMAFDAJ, FGFPKLDJIEL OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int KLKOJFIMMOK(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FGFPKLDJIEL CMOFFOOHDIE(FGFPKLDJIEL DGLFHMAFDAJ, int FPEOONOJHML);

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DPONIGJFOLB CKHFKIBOAFC(FGFPKLDJIEL DGLFHMAFDAJ, Allocator KKCJNCNIICO = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NGNAJGMFLKP(FGFPKLDJIEL DGLFHMAFDAJ, object JILOCOLKOMJ, FGFPKLDJIEL OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IILBNADNOGE(FGFPKLDJIEL DGLFHMAFDAJ, object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OHLKHEKKDKO(FGFPKLDJIEL DGLFHMAFDAJ, [Out] FGFPKLDJIEL OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EFKMMIKMPDB(FGFPKLDJIEL DGLFHMAFDAJ, float3 OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool AEHCNDKAKOD(FGFPKLDJIEL DGLFHMAFDAJ, [Out] float3 OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EFHKGEIMHJL(FGFPKLDJIEL DGLFHMAFDAJ, float3 OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool PHMJFEDMCPK(FGFPKLDJIEL DGLFHMAFDAJ, [Out] float3 OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IIPOICNGFDL(FGFPKLDJIEL DGLFHMAFDAJ, (Quaternion rot, Vector3 moments) ADLDOCGHNOD);

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool OEIKHBMHDOM(FGFPKLDJIEL DGLFHMAFDAJ, [Out] quaternion MODLABAKDKE, [Out] float3 HCMFHLHNOFJ);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OCEDCKBEGHP(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 AJGPOGOJFPI(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 IAEBIIBFMKC(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AIBKMDMOBLM(FGFPKLDJIEL DGLFHMAFDAJ, float3 OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MDHAHCCDOAD(FGFPKLDJIEL DGLFHMAFDAJ, float3 OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float JNGOOKHEOKJ(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float CADOEBPGJBM(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HNFFCDHMJPH(FGFPKLDJIEL DGLFHMAFDAJ, float OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MHFCNINPIHB(FGFPKLDJIEL DGLFHMAFDAJ, float OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode KDPOBMDMKMN(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JLNALANLFME(FGFPKLDJIEL DGLFHMAFDAJ, CollisionDetectionMode OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LDLKAPLIJLM NCDEOKPEEEP(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void BHNNCNPPOPM(FGFPKLDJIEL DGLFHMAFDAJ, LDLKAPLIJLM OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool DOMCCCHKCOA(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void PKPAMFCLLCM(FGFPKLDJIEL DGLFHMAFDAJ, bool OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "29")]
	FGFPKLDJIEL MFKDGJOFMOG(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void FDOHDCMPFNC(FGFPKLDJIEL DGLFHMAFDAJ, FGFPKLDJIEL OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "31")]
	FGFPKLDJIEL ENELMFFLDAO(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void GDNIECKCIEP(FGFPKLDJIEL DGLFHMAFDAJ, FGFPKLDJIEL OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "33")]
	LBIAHMGKBGM GKMIGNHKMCG(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void PBAGGEFNJAC(FGFPKLDJIEL DGLFHMAFDAJ, LBIAHMGKBGM CMBPKLECODO);

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool GHKKONFLPGG(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void IHIIEPHMBDL(FGFPKLDJIEL DGLFHMAFDAJ, bool OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool MEBFOPANPOA(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void EHJAMFNNCDH(FGFPKLDJIEL DGLFHMAFDAJ, bool OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints LCOPBFJJHJL(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void MNCGILKCOPG(FGFPKLDJIEL DGLFHMAFDAJ, RigidbodyConstraints OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float HMPJJJLJMGK(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void JMANHLJNPIG(FGFPKLDJIEL DGLFHMAFDAJ, float OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float MBFCEBGMKHL(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void DNDPOPJKBIL(FGFPKLDJIEL DGLFHMAFDAJ, float OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool LDAHEMLNCCG(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void LOFKCNAAHHB(FGFPKLDJIEL DGLFHMAFDAJ, bool OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool ODAPHLCIKDA(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void JIHFEOAEEBP(FGFPKLDJIEL DGLFHMAFDAJ, bool OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void HBDDJLONBPF(FGFPKLDJIEL DGLFHMAFDAJ, int OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "50")]
	CHJDOPIOJPF ELGMFOMAHDO(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void BEEGFKDJMJK(FGFPKLDJIEL DGLFHMAFDAJ, CHJDOPIOJPF OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "52")]
	MDAEMGHHEEI GAGDMMEDEFK(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void DIAOEBLDBBL(FGFPKLDJIEL DGLFHMAFDAJ, MDAEMGHHEEI OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float CEBIDABECGG(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void FHBILNMNEKL(FGFPKLDJIEL DGLFHMAFDAJ, float OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void MFOIPLBHKEJ(FGFPKLDJIEL DGLFHMAFDAJ, object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void PNKHNABKEBF(FGFPKLDJIEL DGLFHMAFDAJ, object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool IINPBGGNODC(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void PGIJBFPGKID(FGFPKLDJIEL DGLFHMAFDAJ, object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void CFIPKNPMGOO(FGFPKLDJIEL DGLFHMAFDAJ, object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool KIPBJOCAMDE(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool DOHPDPLNPFI(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody DCEIIOBNNEN(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void MIIDDNOMGFC(FGFPKLDJIEL DGLFHMAFDAJ, Rigidbody DNDBHALNMFA);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void AICDEMPEFDP(FGFPKLDJIEL DGLFHMAFDAJ, object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void JIKJAMIHJAA(FGFPKLDJIEL DGLFHMAFDAJ, object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool DAKIBAKMOIB(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void NMBNMPMLONN(FGFPKLDJIEL DGLFHMAFDAJ, float3 CPDFCHMENBI);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void JPPLAEMMIHA(FGFPKLDJIEL DGLFHMAFDAJ, float3 PMKMNPODBEH);

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool DPDFPELEPFD(FGFPKLDJIEL DGLFHMAFDAJ, [Out] float3 CPDFCHMENBI);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool CHOKDAGHPPO(FGFPKLDJIEL DGLFHMAFDAJ, [Out] float3 PMKMNPODBEH);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool MBOANJLCFCC(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void NAADEBILMAD(FGFPKLDJIEL DGLFHMAFDAJ, object JILOCOLKOMJ, bool LAKEKLDFPHG);

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void MNFLJFEAPDC(FGFPKLDJIEL DGLFHMAFDAJ, bool EDBOEGNJFFD);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void MPFKHEHANON(FGFPKLDJIEL DGLFHMAFDAJ);

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool IEBICIKBEOF(FGFPKLDJIEL DGLFHMAFDAJ);
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EBDNGJNFNPK
{
	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIKIJKBOAMJ(Entity HPAENCAAKKN);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNGNOMLJLJB(Entity HPAENCAAKKN);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OPNAAMBGLCK(Entity HPAENCAAKKN);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BIPKHHKACLN
{
	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANBFCIHIKNG(FGFPKLDJIEL ALLFIKNKLHM, bool KHPCNHFKOLC);
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public delegate void OMGKPKIJOLD(IPCLBEINCBH HJPJLNPPCAB);
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public readonly ref struct IPCLBEINCBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly DPONIGJFOLB MAJJEEJJKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly NativeArray<byte> ACFACIOKNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly NativeArray<byte> EINBIEMJACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly GCGDFOMGHFM KIIAJPLCJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly int MFCINLGKFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Type NIAPHHDHJAH;

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public DPONIGJFOLB PEMDFFIECFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x4FB7520", Offset = "0x4FB5D20", VA = "0x184FB7520")]
		get
		{
			return default(DPONIGJFOLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public int GJDKFIAMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x7CB6B30", Offset = "0x7CB5330", VA = "0x187CB6B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public GCGDFOMGHFM JCNPKOPOKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x9FCF80", Offset = "0x9FB780", VA = "0x1809FCF80")]
		get
		{
			return default(GCGDFOMGHFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6B80", Offset = "0x7CB5380", VA = "0x187CB6B80")]
	public IPCLBEINCBH(DPONIGJFOLB MAJJEEJJKLB, NativeArray<byte> ACFACIOKNNI, NativeArray<byte> EINBIEMJACC, GCGDFOMGHFM KIIAJPLCJIE, int MFCINLGKFLA, Type NIAPHHDHJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x37F4860", Offset = "0x37F3060", VA = "0x1837F4860")]
	public NativeArray<T> JMMPJPAJNPG<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x37F48A0", Offset = "0x37F30A0", VA = "0x1837F48A0")]
	public NativeArray<T> OLHPKCEGEEJ<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x37F4770", Offset = "0x37F2F70", VA = "0x1837F4770")]
	public (DPONIGJFOLB, NativeArray<T>, NativeArray<T>) EFPADONOPCC<T>() where T : struct
	{
		return default((DPONIGJFOLB, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6B50", Offset = "0x7CB5350", VA = "0x187CB6B50")]
	public KKDMEOCPFPE KFEKGJHPBIA()
	{
		return default(KKDMEOCPFPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public interface PLBDDFJBAKE
{
	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	string MGJEOEFJLDA
	{
		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	PLBDDFJBAKE AFAMIKKLKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	IEnumerable<PLBDDFJBAKE> OMOCDGPDDCB
	{
		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DGBKFMPADKB
{
	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	PLBDDFJBAKE PPCFDGEIHCH
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	NativeArray<GCGDFOMGHFM> NOOEFCEMBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EEJCEPJPECB(GCGDFOMGHFM KIIAJPLCJIE, [Out] PLBDDFJBAKE DIKHGKFCIGP);

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JNEAPGDNFGC(GCGDFOMGHFM KIIAJPLCJIE, OMGKPKIJOLD LHOJEEBKMPK);

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IMKDBAIPGDE(GCGDFOMGHFM KIIAJPLCJIE, OMGKPKIJOLD LHOJEEBKMPK);
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LJMLLJCCPAD
{
	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNEAPGDNFGC(GCGDFOMGHFM KIIAJPLCJIE, OMGKPKIJOLD LHOJEEBKMPK);

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMKDBAIPGDE(GCGDFOMGHFM KIIAJPLCJIE, OMGKPKIJOLD LHOJEEBKMPK);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class KOOCEPMHOOA
{
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JMPIPIDCPJJ
{
	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	bool PDKIKCKDBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	KMLPANMEAGK AECJNGOFFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HDMIIPAEPNH(IHHMOLPFMOD DMBOJOBJMEI, bool AOLHLCOOLJG);

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CJOIJFOCEOL(EPFBCAMMJCA DMBOJOBJMEI, GCGDFOMGHFM KIIAJPLCJIE);

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AKLDIFBGIKO(NativeArray<EPFBCAMMJCA> HODOMBPEPEP);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public static class IIHMGNGBAMA
{
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public readonly ref struct KKDMEOCPFPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly IPCLBEINCBH NFNBKNAJBPN;

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	public DPONIGJFOLB PEMDFFIECFE
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x4FB7520", Offset = "0x4FB5D20", VA = "0x184FB7520")]
		get
		{
			return default(DPONIGJFOLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9650", Offset = "0x7CB7E50", VA = "0x187CB9650")]
	public KKDMEOCPFPE(IPCLBEINCBH NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB93F0", Offset = "0x7CB7BF0", VA = "0x187CB93F0")]
	public DPONIGJFOLB JMMPJPAJNPG()
	{
		return default(DPONIGJFOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9520", Offset = "0x7CB7D20", VA = "0x187CB9520")]
	public DPONIGJFOLB OLHPKCEGEEJ()
	{
		return default(DPONIGJFOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9100", Offset = "0x7CB7900", VA = "0x187CB9100")]
	public (DPONIGJFOLB, DPONIGJFOLB, DPONIGJFOLB) EFPADONOPCC()
	{
		return default((DPONIGJFOLB, DPONIGJFOLB, DPONIGJFOLB));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public static class NOEKOIIEEPK
{
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public readonly struct KMLPANMEAGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly NativeBitArray MMIKJCFBMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly NativeParallelHashMap<EPFBCAMMJCA, int> KLIFDLBAECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly NativeParallelHashSet<IHHMOLPFMOD> MGLBNODENAP;

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public bool FKJGALMDBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA470", Offset = "0x7CB8C70", VA = "0x187CBA470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public bool PDKIKCKDBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA440", Offset = "0x7CB8C40", VA = "0x187CBA440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x5B5DBF0", Offset = "0x5B5C3F0", VA = "0x185B5DBF0")]
	public KMLPANMEAGK(NativeBitArray MMIKJCFBMMG, NativeParallelHashMap<EPFBCAMMJCA, int> KLIFDLBAECC, NativeParallelHashSet<IHHMOLPFMOD> MGLBNODENAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA250", Offset = "0x7CB8A50", VA = "0x187CBA250")]
	public bool CJOIJFOCEOL(EPFBCAMMJCA DMBOJOBJMEI, GCGDFOMGHFM KIIAJPLCJIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EIMGAAKBBMF
{
	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	HFLHFCIMFNP AHPKFLMKIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DEEEKFNCCJH
{
	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JINODKBAGLA(FGFPKLDJIEL DGLFHMAFDAJ, MCGLDLPOEGP OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NKPCNGHCBDP KCBNBMIKAGC();
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ELAFEKELMAB
{
	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KELGJIMEANC(World GOCNACMHICP);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODHIICHIDHA(World GOCNACMHICP);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase BJBODGOAIIE(World GOCNACMHICP);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MIKMGHBHIAL(World GOCNACMHICP);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODADPIMPIPE(World GOCNACMHICP);

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AINMKAOALFB(World GOCNACMHICP);

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HDDDKLNBGFD(World GOCNACMHICP);

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> OMLDFEKBLJA();
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ADPIECNHEBO
{
	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PMNLDIOMGLB(FGFPKLDJIEL GHMCDKKCGHO, bool OPMIAMEJKDH);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct OKJMPEIGOLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly IEnumerable<OEHDJONJJDO> LOCHJMGBNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly IReadOnlyList<GameObject> GKJPMOHEAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly IReadOnlyList<int> DKMCLALMEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly IReadOnlyList<(EPFBCAMMJCA, EPFBCAMMJCA)> GKOGPFBJIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly int PKJDMMGCPHO;
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public struct MAOEAFAIGNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public InventionIdData MLBCMOLHELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public InventionInstanceIdData BJDCNLDCGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool LPGBALPOKPL;

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x7CBAA10", Offset = "0x7CB9210", VA = "0x187CBAA10")]
	public MAOEAFAIGNL(long MLBCMOLHELH, Guid BJDCNLDCGFI, bool LPGBALPOKPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[ServiceLifetime(Lifetime.Application)]
public interface MGBDCACEGOF
{
	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JPPDCKCEBKK MGJFIIKAIBL(DKLAEGBPMFH IJAMCKPECNH, int CJHFCLKPEIH = 0, bool PMCADIMOLPL = false);

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CBHNMODAFOP MOADCMLOENM(DKLAEGBPMFH IJAMCKPECNH, FGFPKLDJIEL DFPCBMGPBFO, [In] UniformTRS EOEEDDENEGD, OFGAPOFKLNG CPFCGOKNPCH, [Optional] MAOEAFAIGNL EEFJHPPKOCK, bool KALIDFELLDG = true, bool DEHBHIPMENN = false, bool PMCADIMOLPL = false);

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PDPAFEIGHKP MAPPMLEGADO();

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PDPAFEIGHKP EIPNGMMJNJD(DPONIGJFOLB GAEDEONJGAN, [In] UniformTRS ACLAALDIHIB, [Optional] OFGAPOFKLNG BOHFDJLDMPJ);

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DPALLFCDBBI(FGFPKLDJIEL BFOCHEIFENC);

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KEIEKJJKBCC(FGFPKLDJIEL BFOCHEIFENC, [Out] Exception GEIIPKBBOEI);

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<EPFBCAMMJCA> AEAKHDKGNAH(FGFPKLDJIEL BFOCHEIFENC, Allocator KKCJNCNIICO);

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<EPFBCAMMJCA> ABOFOJLKMOE(FGFPKLDJIEL BFOCHEIFENC, Allocator KKCJNCNIICO);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DPONIGJFOLB JGKAFPICLOE(FGFPKLDJIEL BFOCHEIFENC, Allocator KKCJNCNIICO);

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DPONIGJFOLB GKPLIPAAOHD(FGFPKLDJIEL BFOCHEIFENC, Allocator KKCJNCNIICO);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DPONIGJFOLB EINLKHGOGIF(FGFPKLDJIEL BFOCHEIFENC, Allocator KKCJNCNIICO);

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> HBNCJKENJHP(FGFPKLDJIEL BFOCHEIFENC, Allocator KKCJNCNIICO);

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GJDOAFFOAPB(FGFPKLDJIEL BFOCHEIFENC);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int MCNMLAOKGIA(FGFPKLDJIEL BFOCHEIFENC, int PCFOAHIEPDL);
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[ServiceLifetime(Lifetime.Application)]
public interface FNPLLEGKKNG
{
	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0xDC2EA0", Offset = "0xDC16A0", VA = "0x180DC2EA0", Slot = "0")]
	bool AJHOHMFMDLC(object BKLKAFKNCOH, CFLKECDAFLH DIODEJNODIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class AGILFFLBJLE
{
	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9CA0", Offset = "0x7CA84A0", VA = "0x187CA9CA0")]
	public static bool AJHOHMFMDLC(this FNPLLEGKKNG KICOAPCJPFE, object BKLKAFKNCOH, [Out] CFLKECDAFLH DIODEJNODIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public enum KIHJBOJBAMA : byte
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
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public interface CFLKECDAFLH
{
	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	HGEBKJOJDLC PALJBODIBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	NDBHNEPADKO HEMNBGGGEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	bool IPJELIFADOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	bool NKPCAIKKMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0xF43B70", Offset = "0xF42370", VA = "0x180F43B70", Slot = "4")]
	(NDBHNEPADKO, Dictionary<object, object>) GNCMJKLCPOO()
	{
		return default((NDBHNEPADKO, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "5")]
	(EPFBCAMMJCA, NDBHNEPADKO) PNGMBMDKHEO()
	{
		return default((EPFBCAMMJCA, NDBHNEPADKO));
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "6")]
	PLJCCLMLPHN<(EPFBCAMMJCA, NDBHNEPADKO)> MKMCACKICAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "7")]
	PLJCCLMLPHN<PLHNHBJDBDH> DBFFFDLDECE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0xF43B70", Offset = "0xF42370", VA = "0x180F43B70", Slot = "8")]
	(FOELPGKCNLK, byte[]) PAHJNPBAHBE()
	{
		return default((FOELPGKCNLK, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0xF43B70", Offset = "0xF42370", VA = "0x180F43B70", Slot = "9")]
	(DDPIGKDCPAF, byte[]) HOFDNDKCOHP()
	{
		return default((DDPIGKDCPAF, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0xF43B70", Offset = "0xF42370", VA = "0x180F43B70", Slot = "10")]
	T ODHNOKNOKHI<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class CKPEAAFOPEC
{
	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC5F0", Offset = "0x7CAADF0", VA = "0x187CAC5F0")]
	public static bool NOHKJLIHMML(this CFLKECDAFLH NOIIIGMKIIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public interface PLHNHBJDBDH : PLJCCLMLPHN<DIDLPEBJDJK>
{
	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	EPFBCAMMJCA KLNMHOJGNFC
	{
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[DefaultMember("Item")]
public interface PLJCCLMLPHN<T>
{
	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	T EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	int GJDKFIAMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public enum HGEBKJOJDLC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	BulkInstantiate = 1,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	BulkDestroy = 2,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	EACMessage = 3,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	OMSendPacket = 4,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	RR_OutOfBandMessage = 5,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	RR_FastForwardMarker = 6,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	RR_SelfJoinMarker = 7,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	RR_DebugOp = 10,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	RR_CachedEvent = 11,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	RRRoomRequestEvent = 20,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	RRRoomRequestFailedResponseEvent = 21,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	RRBufferedRoomEvent = 22,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	RRClearBufferedRoomEvent = 23,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	RR_CreationOp = 24,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	RR_CreationOpResponse = 25,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	RR_CreationOp_Unchecked = 26,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RR_MasterLockBlockComplete = 27,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RPC = 200,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	SendSerialize = 201,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	Instantiation = 202,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	CloseConnection = 203,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	Destroy = 204,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RemoveCachedRPCs = 205,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	SendSerializeReliable = 206,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	DestroyPlayer = 207,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	OwnershipRequest = 209,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	OwnershipTransfer = 210,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	VacantViewIds = 211,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	OwnershipUpdate = 212,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	AuthEvent = 223,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	LobbyStats = 224,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	AppStats = 226,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Match = 227,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	QueueState = 228,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	GameListUpdate = 229,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	GameList = 230,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	CacheSliceChanged = 250,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	ErrorInfo = 251,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	PropertiesChanged = 253,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	Leave = 254,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Join = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public enum FOELPGKCNLK : uint
{
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	None = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	NetworkTransformInitializationData = 1314146628u,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	RestoreCreationData = 1380140064u,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	OldestCachedPacketId = 1329811529u,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	SnapshotPublished = 1397773634u,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	SnapshotPayload = 1397771332u,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	SnapshotClear = 1129337683u
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class MJCNMGPPBIG
{
	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB410", Offset = "0x7CB9C10", VA = "0x187CBB410")]
	public static EPFBCAMMJCA LAJIHJNEGJB(this EADJJHIPPCI NFNBKNAJBPN)
	{
		return default(EPFBCAMMJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB450", Offset = "0x7CB9C50", VA = "0x187CBB450")]
	public static EPFBCAMMJCA MIAJJPKILHD([In] this EADJJHIPPCI NFNBKNAJBPN)
	{
		return default(EPFBCAMMJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x7C3A720", Offset = "0x7C38F20", VA = "0x187C3A720")]
	public static EPFBCAMMJCA CKNBCDANKJE(this EADJJHIPPCI NFNBKNAJBPN)
	{
		return default(EPFBCAMMJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x7C3A720", Offset = "0x7C38F20", VA = "0x187C3A720")]
	public static ViewId FJKCCGDIOHO(this EADJJHIPPCI NFNBKNAJBPN)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x7CBAFE0", Offset = "0x7CB97E0", VA = "0x187CBAFE0")]
	public static FixedString64Bytes BKCIOHEBONH(this IHHMOLPFMOD MLBCMOLHELH)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB190", Offset = "0x7CB9990", VA = "0x187CBB190")]
	public static FixedString64Bytes KNIGOMNLMJE(this EPFBCAMMJCA MLBCMOLHELH)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x7CBAF50", Offset = "0x7CB9750", VA = "0x187CBAF50")]
	public static FixedString32Bytes BKCIOHEBONH(this Entity EAALLGNPDMK)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NJLFHHKBLFC : MDPOJJFDCFF
{
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public enum JFMKCIGCMCI
{
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MIMJJFLPJNJ
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<object> NGMJBDFMPEN;

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "2")]
	void LIGMPFGKHOP(object BKLKAFKNCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "3")]
	void DEJODFLPGOK(DDPIGKDCPAF MDFGJCKGNHP, ReadOnlySpan<byte> JDGDKOENECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	void OGGHEHBFNMM(FOELPGKCNLK PIJHKCJDAHO, ReadOnlySpan<byte> JDGDKOENECG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PFGPKBKEOBN
{
	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DDPIGKDCPAF MOBFGCHCMIL(ReadOnlySpan<byte> JDGDKOENECG);
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KGKIDNLLHHL
{
	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJBJKOCACHE(DDPIGKDCPAF BELIEAFHDAH, ReadOnlySpan<byte> JDGDKOENECG);

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKNCFJHBELD(ReadOnlySpan<DDPIGKDCPAF> PCKDKOCGMNI);
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct BEBLFGNDMDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public DDPIGKDCPAF MDFGJCKGNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public ReadOnlyMemory<byte> JDGDKOENECG;
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public struct DDPIGKDCPAF
{
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static DDPIGKDCPAF OENFHAEGICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public IHHMOLPFMOD HFHJKJDLFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public int POIJGMKAGKE;

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	public static IHHMOLPFMOD MIMPACKOKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x7CACC30", Offset = "0x7CAB430", VA = "0x187CACC30")]
		get
		{
			return default(IHHMOLPFMOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x4FBD890", Offset = "0x4FBC090", VA = "0x184FBD890")]
	public DDPIGKDCPAF(IHHMOLPFMOD HFHJKJDLFEL, int POIJGMKAGKE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x7CACDF0", Offset = "0x7CAB5F0", VA = "0x187CACDF0")]
	public static bool NIDGPKKMDPO([In] DDPIGKDCPAF ANGFJALIIBO, [In] DDPIGKDCPAF LNEMONKDKMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x7CACC80", Offset = "0x7CAB480", VA = "0x187CACC80", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x7CACD90", Offset = "0x7CAB590", VA = "0x187CACD90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x7CACE80", Offset = "0x7CAB680", VA = "0x187CACE80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x7CACD80", Offset = "0x7CAB580", VA = "0x187CACD80")]
	public void GBLJIMIKPOB([Out] IHHMOLPFMOD AOKFPIHOGDG, [Out] int POIJGMKAGKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public static class LNOBKBBJOBO
{
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public struct OEHDJONJJDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public Guid BGPPHEMBCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public string OLMKGDACLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public Vector3 NCGKJMOKFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public Quaternion PMHMEKBKJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public Vector3 EGLHBCAIJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public int MHNMNDINDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public FIGGFBFOHNG KIAKHLGFPAF;

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF0E0", Offset = "0x7CBD8E0", VA = "0x187CBF0E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public enum DEJAIHAHPNH
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public static class MOMFCHJDCMH
{
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB540", Offset = "0x7CB9D40", VA = "0x187CBB540")]
	public static bool PGPBGAHHIOA(this DEJAIHAHPNH PIJHKCJDAHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB530", Offset = "0x7CB9D30", VA = "0x187CBB530")]
	public static bool JPPFEDAGNMP(this DEJAIHAHPNH PIJHKCJDAHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB520", Offset = "0x7CB9D20", VA = "0x187CBB520")]
	public static bool BMPGKJICJIK(this DEJAIHAHPNH PIJHKCJDAHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[Flags]
public enum EKGOJIMONBA
{
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public interface OFGAPOFKLNG
{
	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMAENDMGFPO([In] Guid GGBFBJAOFOK, [Out] Guid EFGFBKMBCFL);
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[Flags]
public enum PNFECDNJPFK
{
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public interface PDPAFEIGHKP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	AGKHEMIBBDI NHIBGEAKIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString BIEDBGCDJHO();
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public enum IDBGLEOGKJL
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct IENPKBBONIO : ISystemStateComponentData, IComponentData, IEquatable<IENPKBBONIO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public float3 JMODEPAHCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public float3 OAAKIIMIFKI;

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4D20", Offset = "0x7CB3520", VA = "0x187CB4D20", Slot = "4")]
	public bool Equals(IENPKBBONIO PGPJMFPAKOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface POKELIMOBNP
{
	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NLBBEEMLPEG(long PPDNIIFPKHP);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBCFHBLPHAC(NativeParallelHashSet<long> CHCIKEFFOBO);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DEMHDKKEONP(World GOCNACMHICP, NativeParallelHashMap<Guid, long> PNHHMMPMDJM);

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DBEKFKEEJNG(EPFBCAMMJCA DMBOJOBJMEI);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IMLNFBDDBDH(EPFBCAMMJCA DMBOJOBJMEI, [Out] Guid GPNMCGIGBFH, [Out] long PPDNIIFPKHP);

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GKJIIOAAIKO(EPFBCAMMJCA DMBOJOBJMEI, Guid GPNMCGIGBFH, long PPDNIIFPKHP);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GKCHDKBGFDK(Guid GPNMCGIGBFH);

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NEADAIFFHDB(Guid GPNMCGIGBFH, [Out] int HPALJCDJKLF, [Out] int DDJHMKJIOFM);

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OGIJFDALDOH(Guid GPNMCGIGBFH, int HPALJCDJKLF, int DDJHMKJIOFM);

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HMIMHJCFAJI(Guid GPNMCGIGBFH);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public class AICHEIEOLIK
{
	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AICHEIEOLIK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
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
