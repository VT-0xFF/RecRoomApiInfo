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
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E8F0", Offset = "0x7E4DAF0", VA = "0x187E4E8F0", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DDJDJBFLEAE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7E44F60", Offset = "0x7E44160", VA = "0x187E44F60")]
	public static void NHCCLDCFMLM(this Rigidbody KKOLBCMIGGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7E44E30", Offset = "0x7E44030", VA = "0x187E44E30")]
	public static void NHCCLDCFMLM(this Rigidbody KKOLBCMIGGD, Vector3 GMNJMHDDPPB, Quaternion MACGMLFPELO, Vector3 NNMCPCJGFFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct AIKGNMJNLMB : IReadOnlyList<HAONCNNABLP>, IEnumerable<HAONCNNABLP>, IEnumerable, IReadOnlyCollection<HAONCNNABLP>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct HGLDAILFKHN : IEnumerator<HAONCNNABLP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly IPHDOCEGNCL PKCEHJLPOJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator BGMKKIIPDPD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HAONCNNABLP HJBNOIBEMOP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7E4B950", Offset = "0x7E4AB50", VA = "0x187E4B950", Slot = "4")]
			get
			{
				return default(HAONCNNABLP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7E4B900", Offset = "0x7E4AB00", VA = "0x187E4B900", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x50ACB60", Offset = "0x50ABD60", VA = "0x1850ACB60")]
		public HGLDAILFKHN(IPHDOCEGNCL PKCEHJLPOJN, NativeArray<LocalId>.Enumerator BGMKKIIPDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B840", Offset = "0x7E4AA40", VA = "0x187E4B840", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B880", Offset = "0x7E4AA80", VA = "0x187E4B880", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B8C0", Offset = "0x7E4AAC0", VA = "0x187E4B8C0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly DCLKAHOFBPL NLNGJFNOHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> LPJENNAHOBI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HAONCNNABLP JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7E41450", Offset = "0x7E40650", VA = "0x187E41450", Slot = "4")]
		get
		{
			return default(HAONCNNABLP);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7E40BF0", Offset = "0x7E3FDF0", VA = "0x187E40BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int AAGMHIIALFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IPHDOCEGNCL IOMPIJDCPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7E40A20", Offset = "0x7E3FC20", VA = "0x187E40A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int LNJBLGDGPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CGPGHNNJOHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7E40BB0", Offset = "0x7E3FDB0", VA = "0x187E40BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> DAPDKIHPIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2E29A90", Offset = "0x2E28C90", VA = "0x182E29A90")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> KHKPJGKLIGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7E40C50", Offset = "0x7E3FE50", VA = "0x187E40C50")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7E410D0", Offset = "0x7E402D0", VA = "0x187E410D0")]
	public AIKGNMJNLMB(int PIBKMAHMMLH, IPHDOCEGNCL PKCEHJLPOJN, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7E410C0", Offset = "0x7E402C0", VA = "0x187E410C0")]
	public AIKGNMJNLMB(DCLKAHOFBPL NLNGJFNOHGL, NativeArray<LocalId> LPJENNAHOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7E41330", Offset = "0x7E40530", VA = "0x187E41330")]
	public AIKGNMJNLMB(DCLKAHOFBPL NLNGJFNOHGL, NativeArray<Entity> LPJENNAHOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7E412A0", Offset = "0x7E404A0", VA = "0x187E412A0")]
	internal AIKGNMJNLMB(IPHDOCEGNCL PKCEHJLPOJN, NativeArray<Entity> EEOGDGCIFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7E41180", Offset = "0x7E40380", VA = "0x187E41180")]
	internal AIKGNMJNLMB(IPHDOCEGNCL PKCEHJLPOJN, NativeArray<LocalId> LPJENNAHOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E413A0", Offset = "0x7E405A0", VA = "0x187E413A0")]
	public AIKGNMJNLMB(IPHDOCEGNCL PKCEHJLPOJN, int LMMGFKFHEJP, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E411F0", Offset = "0x7E403F0", VA = "0x187E411F0")]
	public AIKGNMJNLMB(AIKGNMJNLMB BKMECIFFDGL, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E40CB0", Offset = "0x7E3FEB0", VA = "0x187E40CB0")]
	public void LHEIMFHDGOA(List<HAONCNNABLP> MEHAOGGFJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7E40840", Offset = "0x7E3FA40", VA = "0x187E40840")]
	public void CODPEDGJIHA(int NIBICIJAIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E40A70", Offset = "0x7E3FC70", VA = "0x187E40A70")]
	public AIKGNMJNLMB GIAPJGILOPE(Allocator FOPENOLHBOM)
	{
		return default(AIKGNMJNLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E40890", Offset = "0x7E3FA90", VA = "0x187E40890")]
	public Span<HAONCNNABLP> DKEIFKCMFLH()
	{
		return default(Span<HAONCNNABLP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E40B10", Offset = "0x7E3FD10", VA = "0x187E40B10")]
	public AIKGNMJNLMB HBKIMPJHDCG(int CAECICLJFEI, int LMMGFKFHEJP)
	{
		return default(AIKGNMJNLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E409E0", Offset = "0x7E3FBE0", VA = "0x187E409E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7E40F20", Offset = "0x7E40120", VA = "0x187E40F20")]
	public HGLDAILFKHN MAJHBAEJHEK()
	{
		return default(HGLDAILFKHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7E40FE0", Offset = "0x7E401E0", VA = "0x187E40FE0", Slot = "6")]
	private IEnumerator<HAONCNNABLP> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7E41050", Offset = "0x7E40250", VA = "0x187E41050", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EAOLHOBIKMI
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x368B780", Offset = "0x368A980", VA = "0x18368B780")]
	public static IAJOLCEBCCF<T> BNAODNEPJOG<T>(this AIKGNMJNLMB JIJCOIBMMGK) where T : Component
	{
		return default(IAJOLCEBCCF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct BDBEEIMNNKF : IList<HAONCNNABLP>, ICollection<HAONCNNABLP>, IEnumerable<HAONCNNABLP>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct JPIFKEAFFBB : IEnumerator<HAONCNNABLP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly IPHDOCEGNCL PKCEHJLPOJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator BGMKKIIPDPD;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HAONCNNABLP HJBNOIBEMOP
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7E4D520", Offset = "0x7E4C720", VA = "0x187E4D520", Slot = "4")]
			get
			{
				return default(HAONCNNABLP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7E4D4D0", Offset = "0x7E4C6D0", VA = "0x187E4D4D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x50ACB60", Offset = "0x50ABD60", VA = "0x1850ACB60")]
		public JPIFKEAFFBB(IPHDOCEGNCL PKCEHJLPOJN, NativeArray<LocalId>.Enumerator BGMKKIIPDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D410", Offset = "0x7E4C610", VA = "0x187E4D410", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D450", Offset = "0x7E4C650", VA = "0x187E4D450", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D490", Offset = "0x7E4C690", VA = "0x187E4D490", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IPHDOCEGNCL PKCEHJLPOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> LPJENNAHOBI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public HAONCNNABLP JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7E425C0", Offset = "0x7E417C0", VA = "0x187E425C0", Slot = "4")]
		get
		{
			return default(HAONCNNABLP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7E426B0", Offset = "0x7E418B0", VA = "0x187E426B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7E41FC0", Offset = "0x7E411C0", VA = "0x187E41FC0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LNJBLGDGPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7E41FC0", Offset = "0x7E411C0", VA = "0x187E41FC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> DAPDKIHPIDF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2E29A90", Offset = "0x2E28C90", VA = "0x182E29A90")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool FDKDJBEEIID
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E42540", Offset = "0x7E41740", VA = "0x187E42540")]
	public BDBEEIMNNKF(IPHDOCEGNCL PKCEHJLPOJN, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7E424B0", Offset = "0x7E416B0", VA = "0x187E424B0")]
	public BDBEEIMNNKF(IPHDOCEGNCL PKCEHJLPOJN, int LMMGFKFHEJP, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7E41EB0", Offset = "0x7E410B0", VA = "0x187E41EB0")]
	public AIKGNMJNLMB EAMOEODHEJP()
	{
		return default(AIKGNMJNLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7E41BD0", Offset = "0x7E40DD0", VA = "0x187E41BD0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E41C10", Offset = "0x7E40E10", VA = "0x187E41C10", Slot = "13")]
	public bool Contains(HAONCNNABLP CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7E41CA0", Offset = "0x7E40EA0", VA = "0x187E41CA0", Slot = "14")]
	public void CopyTo(HAONCNNABLP[] CABEAFGDMFF, int KLEAEAJOBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7E41B50", Offset = "0x7E40D50", VA = "0x187E41B50", Slot = "11")]
	public void Add(HAONCNNABLP CKEIAGIGCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E42090", Offset = "0x7E41290", VA = "0x187E42090", Slot = "7")]
	public void Insert(int NIBICIJAIGM, HAONCNNABLP CKEIAGIGCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E42220", Offset = "0x7E41420", VA = "0x187E42220", Slot = "15")]
	public bool Remove(HAONCNNABLP CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E42000", Offset = "0x7E41200", VA = "0x187E42000", Slot = "6")]
	public int IndexOf(HAONCNNABLP CKEIAGIGCJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7E421D0", Offset = "0x7E413D0", VA = "0x187E421D0", Slot = "8")]
	public void RemoveAt(int NIBICIJAIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E41E70", Offset = "0x7E41070", VA = "0x187E41E70", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7E42140", Offset = "0x7E41340", VA = "0x187E42140")]
	public JPIFKEAFFBB MAJHBAEJHEK()
	{
		return default(JPIFKEAFFBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7E422F0", Offset = "0x7E414F0", VA = "0x187E422F0", Slot = "16")]
	private IEnumerator<HAONCNNABLP> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7E423D0", Offset = "0x7E415D0", VA = "0x187E423D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BGGAMNCDPNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HAONCNNABLP PBGOAKFJNDL(HAONCNNABLP LPJENNAHOBI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LMPMCPMCINN : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface IOPLCAAAJJB : DCEPCLMJBHO, CGJALIPCGDB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	IDGKAHHDFEE EJDNLFGJMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DCLKAHOFBPL ODNNMAKBNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface CGJALIPCGDB
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CIPEIFINPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface JKIODEMNJGG
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFFADHGINCN(bool MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKFEALEGJFP();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface OCGFKBGDDAG
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool BBFAAKDJEEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool MNFKBDHELLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool KDMECDOOBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool EMIEKLMCMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool AOKBFDMAIHE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MBJOHGHFKNB(bool PGGLOGHIPPK);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MADNJLCHMIC(ByteString DICDKKLOOEO);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HKKNOKNLGCH();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HNOOONFKPEC();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OGBPJPEGEMN();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface NBELHCIHFBE
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	PJPDGGELCKG EJDNLFGJMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	ANAPIPHDKOH OPKIAJCANOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	NDMONOMACHB FIHCNOFNCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IOPLCAAAJJB HLNGGIHCAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	CFGPAIKLPJK APEEBNGNMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	OCGFKBGDDAG BEKDKCHMBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	BCOLMCEKFDN HACLAOOGNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	KKMLKFCMDOP LKPMGOKKIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	PIDMLFLMPKJ BJAFFOAEEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	FNKGGFNAPJH GAFOONPBFLA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	LFIPNAPDLLE EOJHFGNIHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	IDLEEBIKHJP INFACFOPLDC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	IPHDOCEGNCL IOMPIJDCPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	AOMPMOACLJO NPLNECFAOAG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	ENIPDEEILMA DOPAOOPALDD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CEDEDEJDLFE PIBMFBFCBIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	IGMEFNNMFGP NKGPHNHJEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	KFEOCCCEEKL KNFBLJKOENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	IELKIFCINDB NPDFNJGDMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	AHDNFKOIIEI OKBPGPHKPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	LPIPCGBGMEO PIJBLEJJMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	PLFNIKFIIFO PMDBCAIDJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	JCICKCLCDBP OGIKAAFHKHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	BFBCLLLEEEA HJFCPCOGPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	BFLPCLDCIGL NNAHJHBBAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	HGMOGKNNBOP DKBLLDOOMDL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	FIBGICHKMPL DJFAPCHLMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	EDLCJCKFFCD PNOBNGMACAC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	AKKDLPHNMAC EKBAJJIFKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	NKOKPFJMIDP EOJLBHEPKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HKOFEHOPJPF IFPHNDAPMAA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	JLPHHADBBLP JFEJDCOPDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	BAGCDPFCCMH CFMLOHIDILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	LPCKIHKBAAE DMDMCCEDJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	MJNIFJDKDCD DDMMHHHOJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerTypeProxy(typeof(LDIBMGHGAEK))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct HAONCNNABLP : IComparable<HAONCNNABLP>, IEquatable<HAONCNNABLP>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly HAONCNNABLP GOADDLNGGGH;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int NPGFKFJABJB = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int HOIFNBPAAKM = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int JOAFNMDEAPL = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int PIIKPMGBDEG = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId EANCCIKOAFJ;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public IPHDOCEGNCL IOMPIJDCPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B010", Offset = "0x7E4A210", VA = "0x187E4B010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IOPLCAAAJJB HLNGGIHCAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B560", Offset = "0x7E4A760", VA = "0x187E4B560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public LocalId KCFOPJDDHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B370", Offset = "0x7E4A570", VA = "0x187E4B370")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	internal DCLKAHOFBPL ODNNMAKBNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B550", Offset = "0x7E4A750", VA = "0x187E4B550")]
		get
		{
			return default(DCLKAHOFBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool BFOGLOCPFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B250", Offset = "0x7E4A450", VA = "0x187E4B250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private bool BFJCICPFLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B200", Offset = "0x7E4A400", VA = "0x187E4B200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B780", Offset = "0x7E4A980", VA = "0x187E4B780")]
	public HAONCNNABLP(IPHDOCEGNCL PGIMIDLFCJN, LocalId EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B6F0", Offset = "0x7E4A8F0", VA = "0x187E4B6F0")]
	public HAONCNNABLP(DCLKAHOFBPL NLNGJFNOHGL, LocalId EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
	public MCDCCMBIKEN KKKENCKFFLG()
	{
		return default(MCDCCMBIKEN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B4D0", Offset = "0x7E4A6D0", VA = "0x187E4B4D0")]
	public static LocalId NEKLFDMHCNA(HAONCNNABLP IFCFNFACFMK)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B510", Offset = "0x7E4A710", VA = "0x187E4B510")]
	public static Entity NEKLFDMHCNA(HAONCNNABLP IFCFNFACFMK)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B3B0", Offset = "0x7E4A5B0", VA = "0x187E4B3B0")]
	public static bool NDBPPCEOMJH(HAONCNNABLP FCKEKMKDGOB, HAONCNNABLP PMDPDEMGJJE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7E4AFF0", Offset = "0x7E4A1F0", VA = "0x187E4AFF0")]
	public static bool EFJOOJHLAGB(HAONCNNABLP FCKEKMKDGOB, HAONCNNABLP PMDPDEMGJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B5C0", Offset = "0x7E4A7C0", VA = "0x187E4B5C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B070", Offset = "0x7E4A270", VA = "0x187E4B070", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7E4AF00", Offset = "0x7E4A100", VA = "0x187E4AF00", Slot = "4")]
	public int CompareTo(HAONCNNABLP FNJGMJGALLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "5")]
	public bool Equals(HAONCNNABLP FNJGMJGALLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CLALPLPLNGI
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7E43420", Offset = "0x7E42620", VA = "0x187E43420")]
	public static KOAGADGMKNF GHBDNKNBKHN(this HAONCNNABLP DBCLNEGBNLN)
	{
		return default(KOAGADGMKNF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class LDIBMGHGAEK
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct DCLKAHOFBPL : IEquatable<DCLKAHOFBPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte NLNGJFNOHGL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] DCLFGGJMPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static IPHDOCEGNCL OHEKGLLOCGP;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static IOPLCAAAJJB OEAIDGLPAOD;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static IPHDOCEGNCL[] ONIKEILCEAC;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static IOPLCAAAJJB[] CLDCPHHGNJP;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> KENCHJENBEB;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IOPLCAAAJJB HLNGGIHCAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7E44B30", Offset = "0x7E43D30", VA = "0x187E44B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public IPHDOCEGNCL DIONGMGOEGL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7E447B0", Offset = "0x7E439B0", VA = "0x187E447B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7E44CD0", Offset = "0x7E43ED0", VA = "0x187E44CD0")]
	static DCLKAHOFBPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x29E56C0", Offset = "0x29E48C0", VA = "0x1829E56C0")]
	internal DCLKAHOFBPL(byte MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6D3DF70", Offset = "0x6D3D170", VA = "0x186D3DF70", Slot = "4")]
	public bool Equals(DCLKAHOFBPL FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7E444E0", Offset = "0x7E436E0", VA = "0x187E444E0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xF400B0", Offset = "0xF3F2B0", VA = "0x180F400B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7E44C10", Offset = "0x7E43E10", VA = "0x187E44C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7E44440", Offset = "0x7E43640", VA = "0x187E44440")]
	private static IPHDOCEGNCL EPDFGNBDPGJ(byte NLNGJFNOHGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7E445B0", Offset = "0x7E437B0", VA = "0x187E445B0")]
	private static IOPLCAAAJJB JHDPONGMKMP(byte NLNGJFNOHGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7E44650", Offset = "0x7E43850", VA = "0x187E44650")]
	private static object KIAKKGLAMNN(byte NLNGJFNOHGL, object[] CPMBLPBIGIH, object FAGKKFIFNNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7E44580", Offset = "0x7E43780", VA = "0x187E44580")]
	private static int HMFLPOGEKCC(byte NLNGJFNOHGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7E445A0", Offset = "0x7E437A0", VA = "0x187E445A0")]
	private static int IILKBHODFDK(byte NLNGJFNOHGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7E443C0", Offset = "0x7E435C0", VA = "0x187E443C0")]
	private static (int, int) DEKPDBFFPLH(byte NLNGJFNOHGL)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7E44590", Offset = "0x7E43790", VA = "0x187E44590")]
	private static byte IGDAIJBHHNO(int COBPGHDNJHM, int NIBICIJAIGM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7E44890", Offset = "0x7E43A90", VA = "0x187E44890")]
	internal static DCLKAHOFBPL OOCHIMKFMHO(IOPLCAAAJJB HDNKLDNKOJO, IPHDOCEGNCL KHJPABPEFGE)
	{
		return default(DCLKAHOFBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7E441D0", Offset = "0x7E433D0", VA = "0x187E441D0")]
	internal static void DDBNGFDLKBA(DCLKAHOFBPL NLNGJFNOHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7E43E70", Offset = "0x7E43070", VA = "0x187E43E70")]
	private static void BEOINBFOELK(int PIBKMAHMMLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum LLMJHMKAAMN
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
public interface APENBDFDEJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool GLHBDCLBBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool DKLAKGFBEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool MOLMFLNHFDM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool KCAJEHKLBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DCPMCLBGLBN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LFPFOENOFOF
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHNEKCMMEFC(ECMBBMCFMNA NPCDKJJJIDL, int NIBICIJAIGM);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BJLIPOEAJPF(ECMBBMCFMNA IMLGOFCEEEK, int NIBICIJAIGM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PAAOPLIHACL : ECMBBMCFMNA, APENBDFDEJJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int IOKHPDCFDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNNHLDGAEAB(HLDLNNLCIOO FDPAKEMBDAE, int NIBICIJAIGM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ECMBBMCFMNA : APENBDFDEJJ
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum PEANPILNDON
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
	bool BDAACFPLIOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool JHLHHOIDENL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool DBPHEOCEBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface HLDLNNLCIOO
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool PONFDJBAECC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	JNBMIBPKCDD MDHFODKHIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	EOEHHKPPNIH IDCMJFLCPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float3 PHGICKGLDGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	quaternion JPIDPNKLHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float3 MKNJDDMDEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	JMMJHJPMGML HKJLLEFIMBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	KFBMHGEEILN NLNHPPFMCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float BFACDLAHFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float3 DEJMIACCAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float CCIOMPKEIBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	OMNIHJEOLPK FGBHMDOHLKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KLKEBFJCOPJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float3 DPCPIKHAIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float3 KAFMAACCCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion BFKALBCHPOA(float3 OEDMDPPAFHE);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface EOEHHKPPNIH
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool KGAMKAHFDDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool PNMFKGACHKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool AKOHBLFNOPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	float MCGNGODPHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	int NGNCNBKFGFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int AGKCCCEDMGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OICCHHIMPKH(KLKEBFJCOPJ FDPAKEMBDAE, int NIBICIJAIGM);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.Application)]
public interface KEGHMDPFFED
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Guid FLJFLJNPONA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MCHPODHBGME(Guid NJPHHHODCEO, Guid CANDMCKMDKL, Guid MBFHPNMLPMK);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task JINBPIJKPJK(Guid NJPHHHODCEO, Guid[] MHMHBMFIPGB, Guid MBFHPNMLPMK);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid JEIBMNLILDI(Guid EEKBMGEEJKM);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task IJLDICMJBPA(HAONCNNABLP LINNNEJJKOH);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LNNKFJOIBJP(Guid EEKBMGEEJKM);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HOGPCHAOCMN(LJBHEOJIFOA EMNKIONGBHB, Guid BKDPPCOGOIB);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KKGFIEFHHMI(Guid EEKBMGEEJKM, bool PGGLOGHIPPK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NDGFPDIEFMI(Guid EEKBMGEEJKM, KOAGADGMKNF DJEKJFPAALG);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MEEBCMLKGHF(KOAGADGMKNF DJEKJFPAALG);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HEDPGGCOLBF(HAONCNNABLP EANCCIKOAFJ);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface AIOIFLCKICD
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface GEOABLFKPHE
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CAKJCBJHHPF(GameObject KOEJHOAMABM, GameObject JHEGBJONCMB, int OIKCJAGJBDC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface MJNMJDNOCJB
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "0")]
	void FFBALEHEGIE(bool BMBINDLKLHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface ANAPIPHDKOH
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	MJNMJDNOCJB AKAHLLCLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	EDGHPJDBMCI JDOPFIJHEFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	PDDMHIHEJAF ONBHMOEMJEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	ICHHOIBCBII NPKKAKLGIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	MILDICDGLJH DONAKGGJBLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	CEBCBOLHCFI LINFMFBFEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	PAAKIBFILGC AOIFHMMJMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	CHMEOHDLNPF FKMLHLJNFKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface EDGHPJDBMCI
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	string PLCDDDKCPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface PBFDMCGGNBD
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFMHIEPGMPM(Action HDKINMMJOHF, bool FIFEALIHPNH);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OAKFFKBFELC(string DGIAFBEDPNJ);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int DPCOCHBIIFH(string DGIAFBEDPNJ, int FAGKKFIFNNI);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BAAGIBHGKKI([Out] bool MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JHFJFIGAMEG([Out] bool MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EHFKFCCGGJK([Out] int MLCDCHNOCFI);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface PDDMHIHEJAF
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "0")]
	void OPCMFMMICJF(bool PGGLOGHIPPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface ICHHOIBCBII
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid PNHBHPKPOEN;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid CIACHAGNMIF;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid NNCHMBDOFGG;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid FDEJCKNJBGO;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool IJEDOKECGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool LFEEJDFNGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool CCOEMDHDCJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C0B0", Offset = "0x7E4B2B0", VA = "0x187E4C0B0", Slot = "3")]
	string[] CBMPLALDFII(HLDHGKEJCGP MLCJOCEBLKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PPFJNEJHJDH();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C140", Offset = "0x7E4B340", VA = "0x187E4C140", Slot = "5")]
	Guid OMMEDFEENOF(Guid IIHDNEENBPK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int IMHAAMCEKIH(HLDHGKEJCGP MLCJOCEBLKH);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KIPIKCOHNGG(HLDHGKEJCGP MLCJOCEBLKH, NativeArray<OCAAILGLKCH> MAKOPLCEEAH, NativeList<UniformTRS> ILLOFEJIHDC);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int JIMHKFMMADD(Guid DIHOLCNHIND);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ILKPEGIGKOK(string PGFEGIPOLEF, [Out] Guid DIHOLCNHIND);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string HKAGGJPICJG(Guid DIHOLCNHIND);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CJJLKCPGCKG(RRObjectPrefabData NOEAIBPOFDO, [Out] LocalId LBPCFJCJDPM);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IAJOLCEBCCF<byte[]> EMCIODGPANH(NativeArray<OCAAILGLKCH> KMEDMCCMEDM);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PKNDCLKLBJE(byte[] PLMCODJMPMH);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GameObject NECMAGNPOAF(string PGFEGIPOLEF);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BLKAJNJPMNL(Transform PMPOHKBNMIB, RRObjectPrefabData MNBNHGFOBNG, IFLFAPHLPOC OPJOIGJBJKN);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool HIBLFILALKE(HLDHGKEJCGP MLCJOCEBLKH, NativeParallelHashMap<Guid, LocalId> IEHKAICBKMO, [Out] Exception NNDKGEOCFFD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OHJGDJKJGKB(HLDHGKEJCGP MLCJOCEBLKH, NativeParallelHashMap<Guid, LocalId> IEHKAICBKMO, [Out] NativeArray<LocalId> EEOGDGCIFOA, [Out] NativeArray<LocalId> HINDHCKKJMJ, [Out] NativeArray<AuthoredLocalPoseData> ELKGJNJMJEK, Allocator FOPENOLHBOM);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "18")]
	void OIILCANHCEK(HLDHGKEJCGP GIKGHELDAKC, NativeArray<int> LHKGABDCFKK, GBAADKKOBIK<GameObject> FCKEDFDGIML, IAJOLCEBCCF<GameObject> BGLPJMJNHPO, LLMJHMKAAMN LJCGIMNFJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GGLPECHBMME();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "20")]
	void POMJNCBIGGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "21")]
	void GDDILDGEKLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "22")]
	bool IFBIECBMJHN(HLDHGKEJCGP MLCJOCEBLKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "23")]
	LFPFOENOFOF JGPKDANKHEL(HLDHGKEJCGP MLCJOCEBLKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "24")]
	void OLCMIOMLEEM(Guid LOKMKCNFKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "25")]
	bool MPOLMFJABKO(Guid LOKMKCNFKJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C170", Offset = "0x7E4B370", VA = "0x187E4C170")]
	static ICHHOIBCBII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface HEDKOOGLOPD
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	long PKMHIACEICB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	long MDKBNEEMIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface MILDICDGLJH
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool OPIIEEFNEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool OJJFMBAOPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int LCNGJOONIBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	int NFNNKKPFPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	int KBDEKHMFCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool GEKKIOBINBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	int GDPDHDGOJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "6")]
	void FAKHAOHBBKH(DGDACOEFOEH IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
	void CJCEOLNJHHD(bool LMHFADGHCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "8")]
	bool NCEEIGPOFJK(MMNMPKDPAGK KOCMKKLCMKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "9")]
	void NKHHLKHCCDB(object MGEJNDCFBJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "10")]
	void JKDAACHMBBM(object MGEJNDCFBJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LMCGMAIHICB(Action<object> EDCEBMLIDAL);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FLOMFNBIJBO(Action<object> EDCEBMLIDAL);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "13")]
	void CEKIKCMIIME(NativeArray<ViewId> ACPFFNJBOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "14")]
	void ALEPCKNLHAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "15")]
	void NHMJNKEIEKO(NLELEHKBKFK EDLOHJEBKFM, ReadOnlySpan<byte> DHAOEHNLNON, MMNMPKDPAGK HMFALEOPEFK, bool DOANFBOADDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "16")]
	void NHMJNKEIEKO(NLELEHKBKFK EDLOHJEBKFM, ReadOnlySpan<byte> NEPKEDPCFPK, bool DOANFBOADDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "17")]
	void NHMJNKEIEKO(NLELEHKBKFK EDLOHJEBKFM, ReadOnlySpan<byte> NEPKEDPCFPK, ReadOnlySpan<byte> PILDCNPGFDK, bool DOANFBOADDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "18")]
	void LBNJPFMLDHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "19")]
	void PPFIGANINED(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "20")]
	void PALNEKNLMKP(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "21")]
	void MACDLBPAEHL(Dictionary<object, object> HJFPGFLLFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "22")]
	void JHKHEMNFCCE(NativeList<KOAGADGMKNF> FHMHPBDBAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "24")]
	void KHABGGGLCIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "25")]
	void PCPLJINMKFP(List<object> HCMOKBCCKGO, int AIGLIPKHKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "26")]
	void OKKMFODDOOB(int LKGHDAJJCCG, object ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "27")]
	void KADHJHHAKFJ(MMNMPKDPAGK KOCMKKLCMKL, Dictionary<object, object> PPDPHFAEOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "28")]
	void FMLILAKBEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "29")]
	void KECLLKKMMGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class NKEPNIBFIDH
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7E51AD0", Offset = "0x7E50CD0", VA = "0x187E51AD0")]
	public static KLPGDMHJLFG FOKFNCGAIFB(this MILDICDGLJH GBEOAHCNHMI, object PPOILDCNBFL)
	{
		return default(KLPGDMHJLFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct KLPGDMHJLFG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MILDICDGLJH GBEOAHCNHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object PPOILDCNBFL;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D890", Offset = "0x7E4CA90", VA = "0x187E4D890")]
	public KLPGDMHJLFG(MILDICDGLJH GBEOAHCNHMI, object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D840", Offset = "0x7E4CA40", VA = "0x187E4D840", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GCNLKJNIIBG
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate void DDIFMKPJJDH(ViewId NDLKHGHIICJ, LKKBBGCNCDA GEOMNIANDLN, int NEGFBCIAAFG);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "0")]
	void MDMKHHJOEAI(DDIFMKPJJDH FGPOEHIOFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "1")]
	void FPKJECPPFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "2")]
	void AAFLBJEPAAB(GCJJOOFPNCM IMPAKIFFNDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface ECHFFMBKAGN
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[ServiceLifetime(Lifetime.Application)]
public interface CEBCBOLHCFI
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct KNNKCBOOIKH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private CEBCBOLHCFI IHCKCFKNODG;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7E4DB00", Offset = "0x7E4CD00", VA = "0x187E4DB00")]
		public KNNKCBOOIKH(CEBCBOLHCFI IHCKCFKNODG, string LBMHFAOKMJO, string AMOKIPMOALC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7E4DA40", Offset = "0x7E4CC40", VA = "0x187E4DA40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct CDECGJDPGIP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private CEBCBOLHCFI IHCKCFKNODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task LDLKICLCOAG;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7E43340", Offset = "0x7E42540", VA = "0x187E43340", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "0")]
	void NMBJKEHFMDC(string BDAAPBJEHGD, float NJODBBGOGON = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "1")]
	void PLDCHFBEPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MDGMBANIPOD(bool BEKPHECLEBC, string LBMHFAOKMJO, string AMOKIPMOALC);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "3")]
	void PCKCJBOEDIN(string BDAAPBJEHGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class EBAJOBFDIDI
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7E47B20", Offset = "0x7E46D20", VA = "0x187E47B20")]
	public static CEBCBOLHCFI.KNNKCBOOIKH KBGMEBJHDGI(this CEBCBOLHCFI GBEOAHCNHMI, string LBMHFAOKMJO, string AMOKIPMOALC)
	{
		return default(CEBCBOLHCFI.KNNKCBOOIKH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.Application)]
public interface PCAHPFJNOGP
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BCAGGGKGAMH(GameObject GNOLFLMODHC);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKGDGLDCMAP(GameObject GNOLFLMODHC);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JLNFOJKLEJG(int KOCMKKLCMKL);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object GODLGBHLBOL(HAONCNNABLP EANCCIKOAFJ, GameObject GNOLFLMODHC, Action<HAONCNNABLP, int> LKEPFHDAAED);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HHOANJBPDPA(GameObject GNOLFLMODHC, object KDGNIGMEJOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface BHIDBLICIFD
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEBCPPBDNIB(object DBCLNEGBNLN, NativeList<byte> DHAOEHNLNON);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object JKAINKAKBPB(NativeArray<byte> DHAOEHNLNON);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface NDFADBHPAKO
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool GLGOPFOIKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate IHDCBJNGOFI(GHFHANGICMB ONJKGMAPGIF, Action<GHFHANGICMB> LKEPFHDAAED);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EDMHPBAKAKH(GHFHANGICMB ONJKGMAPGIF, Delegate LKEPFHDAAED);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate NAFMCGBCGNH(GHFHANGICMB ONJKGMAPGIF, Action<GHFHANGICMB> OAIIMFIPFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HOMBNLDDCPM(GHFHANGICMB ONJKGMAPGIF, Delegate LKEPFHDAAED);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EAJMLDDJJDP(GHFHANGICMB ONJKGMAPGIF);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GHFHANGICMB GEPBBLHBNJI(GameObject GNOLFLMODHC);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface DBKGGLAPDOI
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int FOOIOJNNGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	int MOIOLIDMNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool OPIIEEFNEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool BJNPJFEONFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool DPAEBCIPLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HAONCNNABLP DLJMEHMAKIE(int KOCMKKLCMKL);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
public interface PAAKIBFILGC
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool BBFAAKDJEEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
public interface MDGGINJLEMI
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	PFOKOKEKMHK GLHLMKCHGNO
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	DNOHAGJNPAP INEBOCMAPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool PHIIABONAOA
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ICNHFFCCKPN(Transform PMPOHKBNMIB);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OMLMDHPAHHC(Transform PMPOHKBNMIB, CNMFJGBLGMD OJIOPDPLOGA);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GKMOODLNDDA(Transform PMPOHKBNMIB, LIGLMNBGNIO CFHFANILNME);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.Application)]
public interface CHMEOHDLNPF
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action IAKKGMCMIEL;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.Application)]
public interface CBLPPBAOKEF
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBKIKFKAFOP();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface FNMGCCLCKLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBGBMDBMFCP(GameObject GNOLFLMODHC, KHFPIIIDCNJ BMBDOPOALKH, LEFIJBDKMMH OPOHNMHBBND);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PPHBIJENBJA(HAONCNNABLP EANCCIKOAFJ, bool JMIKGNJILPB, float3 GLEIALDBKHF, quaternion PGIJPHJPAAF);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FIIIMKNOJGN(AIKGNMJNLMB MHGLNLEJLLG);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EDEAIANCCLE(MCDCCMBIKEN FNEFIOJLPDJ, MCDCCMBIKEN PJNHLGGHCLG, FKJDPJEKDDH HFFFCKALIAN);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABCANJAPEMC(MCDCCMBIKEN FNEFIOJLPDJ, FKJDPJEKDDH HFFFCKALIAN);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DHHGNFFHBGM(AIKGNMJNLMB OHPDKPICNDD);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject HPPIEDBOPND(Guid MCDMBOGIGEG);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LDGHJKANMIB(MLGJPNMDKJP DLGFIMAKDIN);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct FJDBDALJEIP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> DHAOEHNLNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle NLNGJFNOHGL;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7E49650", Offset = "0x7E48850", VA = "0x187E49650")]
	public FJDBDALJEIP(ReadOnlyMemory<byte> KFMEBMDKDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7E49610", Offset = "0x7E48810", VA = "0x187E49610", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public enum HFJHKJEPJCL
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
public struct HLDHGKEJCGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString EHMHOIKAILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object KFKFCGACBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object JBMAEFJAELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> HOHACPPMGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool NBHCJCJDBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public CGLILNKPNAK.IIFMNEOKPND? IMPONDEGOPN;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C030", Offset = "0x7E4B230", VA = "0x187E4C030")]
	public HLDHGKEJCGP(ByteString EHMHOIKAILK, [Optional] object KFKFCGACBIG, [Optional] object JBMAEFJAELL, [Optional] IEnumerable<string> HOHACPPMGLH, bool NBHCJCJDBCD = true, [Optional] CGLILNKPNAK.IIFMNEOKPND? IMPONDEGOPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct FDFGEAJEOAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object DBPLBMLNFAK;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct OCAAILGLKCH
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[Flags]
	public enum KKDPABDHENE
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
	public RRObjectPrefabData CKBDDAGAOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid PGKMPKPKBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid NGNHLMCKIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid LKNFKKMJAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid JAHAOPJICLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public KKDPABDHENE MJJLCGKEEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 JLHFCJIGKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int GOAAMMIIOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public GKMDNPOHGBA HJLFBBKDFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int AJPNKKDCHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int KOKGEIHBLMD;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Guid KAKNILOIEJI
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x50A8070", Offset = "0x50A7270", VA = "0x1850A8070")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public bool ICLEBKDOEOI
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7E51C50", Offset = "0x7E50E50", VA = "0x187E51C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public bool NFBCLHCJICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7E51C30", Offset = "0x7E50E30", VA = "0x187E51C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool NLEHFNNMHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7E51C40", Offset = "0x7E50E40", VA = "0x187E51C40")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct DJLJDEGBKAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal readonly IMFLKHJDKOM CAECICLJFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly IMFLKHJDKOM KAFOOAGKGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly uint AJLIACFHBJA;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7E46E20", Offset = "0x7E46020", VA = "0x187E46E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct NHHJJHINEFM
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal readonly DJLJDEGBKAH HDKINMMJOHF;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7E47080", Offset = "0x7E46280", VA = "0x187E47080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct DMKAJKGPDEG
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal readonly DJLJDEGBKAH HDKINMMJOHF;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7E47080", Offset = "0x7E46280", VA = "0x187E47080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct KENICCAONEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly uint AJLIACFHBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly bool EPFBFFLEFIJ;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D7A0", Offset = "0x7E4C9A0", VA = "0x187E4D7A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct IMFLKHJDKOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal int OEBFFKLMAPN;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C5C0", Offset = "0x7E4B7C0", VA = "0x187E4C5C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[ServiceLifetime(Lifetime.Application)]
public interface GMOPPIADJNH
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	JCALDKNEBGK GDOKOOFMNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface LJBHEOJIFOA
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface CMEKPNMEJPB
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class FOLNEBMHAJN
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x380D8D0", Offset = "0x380CAD0", VA = "0x18380D8D0")]
	public static MCDCCMBIKEN KKKENCKFFLG<T>(this T EANCCIKOAFJ) where T : LJBHEOJIFOA
	{
		return default(MCDCCMBIKEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A3C0", Offset = "0x7E495C0", VA = "0x187E4A3C0")]
	public static MonoBehaviour EPNHFBLMHIK(this LJBHEOJIFOA EANCCIKOAFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A440", Offset = "0x7E49640", VA = "0x187E4A440")]
	public static GameObject FMNMJJFPHEF(this LJBHEOJIFOA EANCCIKOAFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface DNBOPDGJDML : LJBHEOJIFOA
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(HAONCNNABLP CFNHEFEFHMG);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface OEBHOIJJOMJ : LJBHEOJIFOA
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface KDPIBFMNECC
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public delegate void EMJADIAPOIH(FAHPOPFMPNL CJBKNLFPOCO);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event EMJADIAPOIH CNEBMKIGOKP;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface BIMJGOAHLEN
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface DNPCLJCGFDL
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface KOGNBGJPJEL
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(HAONCNNABLP EOOJDNEPLIK);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool CPMPPIFBKJN);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LMHBFFFKGDD(HAONCNNABLP DJMGIDJHMIC);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface FAAMHDGKJLN
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(FLECLLPEPCA MEAAJOEHDME);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface FLECLLPEPCA
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	GameObject GNOLFLMODHC
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Transform PMPOHKBNMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	IOEJADJKHIM JDDJNJFOIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool IAHADEGNFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HOCDNCLMPGH(IOEJADJKHIM AHLPFPPNCPD);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FAECONBOANN GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class AMKNINBGODC
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7E41610", Offset = "0x7E40810", VA = "0x187E41610")]
	public static void JIACAEILCJE(this FLECLLPEPCA EACFJGMBJAK, IFLFAPHLPOC OPJOIGJBJKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface IOEJADJKHIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Rigidbody LGIHCHPLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	FLECLLPEPCA OPDCLENIIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	GameObject FMNMJJFPHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Transform NBDDMFIBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	IOEJADJKHIM EKNHDPMCHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	IOEJADJKHIM ADHDCGIKAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	int ODGEPMGANEG
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	bool MFLKPIINKAB
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	bool EAJMLDDJJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	bool HCBJHJGLDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	LNPGGOONBDB LLFMKIHDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	MFLENIHFHJN LAPBMFOBBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	float BDHDMNIBCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Vector3 AMMDCCBOLHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Vector3 LPCHJEJKCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	Vector3 LPALLCKFAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	Vector3 GBGAMCCIDAA
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	bool EHNMDGKDFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool AHOMCOHBDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	bool HMBJJPECPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	bool ECPHJGKPCNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 CMOGEHDGBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 HOPNPANBCLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Vector3 PCJFBMFFBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Vector3 KOIANDHHMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	float NHHPNGBFOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	float KCAEEJECADE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	Vector3 FGIKKMKKMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	Quaternion JAACGHDJFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	float HIPJLBHAJCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	float FJJIGHIFJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool GDBPPNLFOBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	PKLBDOAGHDH CKKIPNGAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	bool IOIGNCIKONB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	Transform POKNNEEEMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Vector3 NGDJNNKBJPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	float EBHAPFBFHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	float BPIFKBIOOBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	Quaternion LPOBAHMNGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	Vector3 DPCPIKHAIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	Quaternion PKAGPKPGINM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	RigidbodyConstraints OCLDFLBEGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	bool CIHILCEEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	CollisionDetectionMode PCOGNLHGBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	bool LOCPPNIGPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EIGFFHGOEIP MKKMLGMNILH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EIGFFHGOEIP FGJPKDEFFGC;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event EIGFFHGOEIP DFPFHJBACON;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event EIGFFHGOEIP HFKNPDAIAKJ;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event EIGFFHGOEIP EDAFALFGLEC;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event EIGFFHGOEIP GONDBPBAOCP;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event EIGFFHGOEIP JJLAFANPKPP;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event KHDGNNMJLLN DPDJNLLKPGD;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<MIPMLGOBAHP, MIPMLGOBAHP> HFJCODFCPBJ;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	IOEJADJKHIM LFDADDKHJDM(int NIBICIJAIGM);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void BIALOFJJKHE((Quaternion rot, Vector3 moments) LCCOOECAKAD);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void FONBPOKANLB();

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void BPGFCOKPKBO();

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void LDFMGEFGAAF();

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void FKEGBOAKPLO();

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void AODFOMLHKAI();

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void GDFLKEKMOMJ(IOEJADJKHIM MLCDCHNOCFI, bool JPKNJNJLHOB = false);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void CNOAADKGBAA(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void PGMGICPELAL(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 OHBLLPPHBCB(Vector3 NIBHLBJHDHN);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 GIHEBMGCAIP(Vector3 CELELBKKFCP);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void FIPMIKDFOCJ();

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void CCMNCCFIEHH();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void EOCBMDGKKCN();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void APJAJKJBHBB(Vector3 OEOLHIOPIKF, Vector3 FDDFJFKIJPO);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void EDJIPLHEOHA(Vector3 ACONPCMHOEF, Vector3 NHECMEGPDAP);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void HDJGNLFLNBD(Vector3 HJDDMJLLONP);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void JFBMLFMNAON(FCNAHGFPEBI PPLPNFAKIBE, Vector3 LNKNHOEJOPG, float MMDBNDOLIFK, float CLNJJNGJGFF = 8f, float DPJEKAKHGMH = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void LOGJHOACDLH(CIDMDLJNANB CJDMOKLIONI, Vector3 FCLIKHAFLJH, float JDPMGDPHLAK = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void NEAPMHMINOA(CIDMDLJNANB CJDMOKLIONI, Vector3 PANMBKPFLFA, float HLHGFNIDNBM = 7f, float KEEEAEPGIHB = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 JPJDLLDKEFD(Vector3 MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 PDOMIDNHFOL(Vector3 MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void POOMNEKLGFC();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void CMLLNFFMAEP(IOEJADJKHIM FMOFGFOJLHA, object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void JMMKHPLIFCI(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void CFOJHLOAKEF();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void PELLEGGGNPC();

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void NBFFMCPABNI();

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool KHEGMEICAOK();

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void FEFEDEJJBJD();

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void EOAFKIMAEBB(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void HOAIHPMGJDP(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void MAPHJDIBONG(object PPOILDCNBFL, bool BJEEFLICPDC);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void EGOJNHGIALK(Vector3 LKKAKBHJDDH, Quaternion IHKFAJHNMBP);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void MDELKKGDENB(Vector3 JJLEJJBGLEO, Quaternion CPBHBDHBHBD);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool JIDCNDJFGCI(float PFEJJJDICMM);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void PCAEBMGKNEO(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void CCNFEACHLPL(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void CKDMJAENEOD(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void IEGFLKADKBI(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void JNHPBKDAHHL(Vector3 LIEHHNOLAGC, ForceMode IDGMGBABBBG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void NBIPFJCNLHO(Vector3 LIEHHNOLAGC, Vector3 BJHAAAPCKLC, ForceMode IDGMGBABBBG);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void ODDCNNEBHFM(Vector3 NBMEFCPFMNK, ForceMode IDGMGBABBBG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void GKLADBDBBHB(Vector3 NBMEFCPFMNK, ForceMode IDGMGBABBBG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool NIJKCKLHCPD(Vector3 ACBMNMFGAEN, [Out] RaycastHit PIKNPKBEJMD, float BMKHJPOEOBG);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void DGGOFILANBN();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface MFLENIHFHJN
{
	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHDBFHOMKFN(Vector3 EKGLMKPBMFP);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MCEKKFADGAI(Vector3 HNMBFFBJHEC);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HEAFIFCNBMH(Vector3 EKGLMKPBMFP);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EDCCMHEEEEJ(Vector3 HNMBFFBJHEC);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface LNPGGOONBDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BHFEFKOODAF();

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 BKCGGGIDGAO();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DMAMNAFMCPM(float GFLLOEDMCMO, float AHHFOCKIKGG);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate void EIGFFHGOEIP(FLECLLPEPCA JNAHCDDONIN);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum FLIFJKIKCCB
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
public enum FCNAHGFPEBI
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
public delegate void KHDGNNMJLLN(FLECLLPEPCA JNAHCDDONIN, bool JPKNJNJLHOB = false);
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum CIDMDLJNANB
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct FAECONBOANN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Rigidbody ECNEPHPGPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public object EADLIFECOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Vector3 FMDFCPBCAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 NIFOKABFMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public IAGAFLNEHEJ IFBOOMJGNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool ODNGCBJCBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool MBJDFOCPHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool HIHNCLJCLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool NNNJIHLPEPC;
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct MCDCCMBIKEN : IEquatable<MCDCCMBIKEN>
{
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public static readonly MCDCCMBIKEN AIIEKMBHIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public GameObject GNOLFLMODHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7E4FE10", Offset = "0x7E4F010", VA = "0x187E4FE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public KOAGADGMKNF NBLOIEFHFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7E50240", Offset = "0x7E4F440", VA = "0x187E50240")]
		get
		{
			return default(KOAGADGMKNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public IANOFDJKDKE DDPCFHMBLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7E50090", Offset = "0x7E4F290", VA = "0x187E50090")]
		get
		{
			return default(IANOFDJKDKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public RRObjectPrefabData FEFFCIFBBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7E4FCE0", Offset = "0x7E4EEE0", VA = "0x187E4FCE0")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool FFEIIPFIOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7E4FBE0", Offset = "0x7E4EDE0", VA = "0x187E4FBE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool PEDEJFLIFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7E4FC00", Offset = "0x7E4EE00", VA = "0x187E4FC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool PONFDJBAECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7E50480", Offset = "0x7E4F680", VA = "0x187E50480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool AGNJGLIKOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7E50670", Offset = "0x7E4F870", VA = "0x187E50670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool JEMNBPFMDJD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7E4FB80", Offset = "0x7E4ED80", VA = "0x187E4FB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool GHHFEOFNOEP
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7E50750", Offset = "0x7E4F950", VA = "0x187E50750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool COPCJPMNKBO
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7E4FCA0", Offset = "0x7E4EEA0", VA = "0x187E4FCA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool BPOKICKACMD
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7E50330", Offset = "0x7E4F530", VA = "0x187E50330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool KPNKILAEJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7E502F0", Offset = "0x7E4F4F0", VA = "0x187E502F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool ILDHOPMBHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7E50440", Offset = "0x7E4F640", VA = "0x187E50440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool LPLBONDOJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7E506E0", Offset = "0x7E4F8E0", VA = "0x187E506E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool HLCNEMBHBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7E50200", Offset = "0x7E4F400", VA = "0x187E50200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public KOGMKDJKDEN PEDDIJLMPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(KOGMKDJKDEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public HLDFDEIBNMP DIKMDFKKEMO
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HLDFDEIBNMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public MAGLFLGKBFI NPLNECFAOAG
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MAGLFLGKBFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public OPHMOPJMGBA DPLGMBAODDG
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(OPHMOPJMGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public FLFOCNLLGFB MAHDOLAEOCA
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(FLFOCNLLGFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public NFCPFOBAADP MOIIIOGIIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(NFCPFOBAADP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public IHONNMHPEPM ELCGJMEDDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(IHONNMHPEPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public FDNELKFAALI OFMCHGOOGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(FDNELKFAALI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public PDBMANDGCLE DOPAOOPALDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(PDBMANDGCLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public FEOAOFALJOA JJHNGCJCAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(FEOAOFALJOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public LHGPGCNOHBL BIINKOLMGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(LHGPGCNOHBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public JEFBPNADKEF MEGKAACPEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(JEFBPNADKEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public BIOGAFBCPNH PMOCFNFIGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(BIOGAFBCPNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool MNNFAAIACOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7E4FFA0", Offset = "0x7E4F1A0", VA = "0x187E4FFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool GPCMBHHHGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7E4FC20", Offset = "0x7E4EE20", VA = "0x187E4FC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool OFAJNILAOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7E50630", Offset = "0x7E4F830", VA = "0x187E50630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool BFOGLOCPFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7E502E0", Offset = "0x7E4F4E0", VA = "0x187E502E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool KANCJKJLAAM
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7E4FC60", Offset = "0x7E4EE60", VA = "0x187E4FC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool GJFBMJKPDKD
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7E4FBA0", Offset = "0x7E4EDA0", VA = "0x187E4FBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool PHLDMDFJEGB
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7E501C0", Offset = "0x7E4F3C0", VA = "0x187E501C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public OFMNNNLLCMI NBDDMFIBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(OFMNNNLLCMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public DOIBMDKGMFE GAFOONPBFLA
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(DOIBMDKGMFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private IPHDOCEGNCL IOMPIJDCPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B010", Offset = "0x7E4A210", VA = "0x187E4B010")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static MCDCCMBIKEN NEKLFDMHCNA(HAONCNNABLP CFNHEFEFHMG)
	{
		return default(MCDCCMBIKEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7E50370", Offset = "0x7E4F570", VA = "0x187E50370")]
	public DGIHMJLOBAF IEJOBEMGHFP()
	{
		return default(DGIHMJLOBAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7E50720", Offset = "0x7E4F920", VA = "0x187E50720")]
	public PLKJKBMLEAE PCIDGJCDBGF()
	{
		return default(PLKJKBMLEAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7E50690", Offset = "0x7E4F890", VA = "0x187E50690")]
	public COEIAFAJCOK OPBHFMOHOOH()
	{
		return default(COEIAFAJCOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7E4FB50", Offset = "0x7E4ED50", VA = "0x187E4FB50")]
	public OFBJENPPHOI BFEJGEJCCKH()
	{
		return default(OFBJENPPHOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7E50540", Offset = "0x7E4F740", VA = "0x187E50540")]
	public DHNLJAOMAJA NMGPKEBEICD()
	{
		return default(DHNLJAOMAJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7E503F0", Offset = "0x7E4F5F0", VA = "0x187E503F0")]
	public JAGDBKPBNED JJKBFEBDFHD()
	{
		return default(JAGDBKPBNED);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7E50780", Offset = "0x7E4F980", VA = "0x187E50780")]
	public void PKPBBKKDJAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7E504A0", Offset = "0x7E4F6A0", VA = "0x187E504A0")]
	public void NHLEMPKJEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7E50590", Offset = "0x7E4F790", VA = "0x187E50590")]
	public bool OHACINNOJLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7E50880", Offset = "0x7E4FA80", VA = "0x187E50880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public MCDCCMBIKEN(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7E40760", Offset = "0x7E3F960", VA = "0x187E40760")]
	public static bool NEKLFDMHCNA(MCDCCMBIKEN MLCDCHNOCFI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static HAONCNNABLP NEKLFDMHCNA(MCDCCMBIKEN MLCDCHNOCFI)
	{
		return default(HAONCNNABLP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7E40740", Offset = "0x7E3F940", VA = "0x187E40740")]
	public static bool NDBPPCEOMJH(MCDCCMBIKEN FCKEKMKDGOB, MCDCCMBIKEN PMDPDEMGJJE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7E4AFF0", Offset = "0x7E4A1F0", VA = "0x187E4AFF0")]
	public static bool EFJOOJHLAGB(MCDCCMBIKEN FCKEKMKDGOB, MCDCCMBIKEN PMDPDEMGJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x7E50130", Offset = "0x7E4F330", VA = "0x187E50130", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(MCDCCMBIKEN FNJGMJGALLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct JEFBPNADKEF : IEquatable<JEFBPNADKEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private LPCKIHKBAAE IBIDAGHIHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7E4CBF0", Offset = "0x7E4BDF0", VA = "0x187E4CBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7E40750", Offset = "0x7E3F950", VA = "0x187E40750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C700", Offset = "0x7E4B900", VA = "0x187E4C700")]
	public void CAJLCJNGCJF(uint MKHHKDJKLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CAF0", Offset = "0x7E4BCF0", VA = "0x187E4CAF0")]
	public bool GAGFMJAIEOM([Out] uint MKHHKDJKLDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C960", Offset = "0x7E4BB60", VA = "0x187E4C960")]
	public bool DHOMONHANFA([Out] uint MKHHKDJKLDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C800", Offset = "0x7E4BA00", VA = "0x187E4C800")]
	public void CGOIMEGGHGJ(string MKHHKDJKLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CC50", Offset = "0x7E4BE50", VA = "0x187E4CC50")]
	[CanBeNull]
	public string LOEKAEBBGCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public JEFBPNADKEF(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CA60", Offset = "0x7E4BC60", VA = "0x187E4CA60", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(JEFBPNADKEF FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct KOGMKDJKDEN : IEquatable<KOGMKDJKDEN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private BCOLMCEKFDN BKOCLBBMPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E480", Offset = "0x7E4D680", VA = "0x187E4E480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private LPCKIHKBAAE DMDMCCEDJNB
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x7E4DBD0", Offset = "0x7E4CDD0", VA = "0x187E4DBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool MCIALDJDJPE
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E1D0", Offset = "0x7E4D3D0", VA = "0x187E4E1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool PMAKPPGEFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x7E4DB90", Offset = "0x7E4CD90", VA = "0x187E4DB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool HENMKIHEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7E4DE60", Offset = "0x7E4D060", VA = "0x187E4DE60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public Guid NKMFGNAPIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7E4DC30", Offset = "0x7E4CE30", VA = "0x187E4DC30")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Guid MEFPIDENKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E4E0", Offset = "0x7E4D6E0", VA = "0x187E4E4E0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Guid GNGCOBIEEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x7E4DFC0", Offset = "0x7E4D1C0", VA = "0x187E4DFC0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public DOIBMDKGMFE GAFOONPBFLA
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(DOIBMDKGMFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7E40750", Offset = "0x7E3F950", VA = "0x187E40750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7E4DF20", Offset = "0x7E4D120", VA = "0x187E4DF20")]
	public bool HMDOAECFDGA([Out] Guid EEKBMGEEJKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7E4E560", Offset = "0x7E4D760", VA = "0x187E4E560")]
	public bool PJJAKIEKNDC([Out] Guid CANDMCKMDKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7E4E360", Offset = "0x7E4D560", VA = "0x187E4E360")]
	public void MFLOJDDCDMN(Guid KFEGNKODPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7E4E260", Offset = "0x7E4D460", VA = "0x187E4E260")]
	public void LJALGCAMGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7E4DCB0", Offset = "0x7E4CEB0", VA = "0x187E4DCB0")]
	public Guid EIHFNCCANFF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public KOGMKDJKDEN(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7E4DDD0", Offset = "0x7E4CFD0", VA = "0x187E4DDD0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(KOGMKDJKDEN FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct COEIAFAJCOK : IEquatable<COEIAFAJCOK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private PIDMLFLMPKJ JDGIGICFBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7E43740", Offset = "0x7E42940", VA = "0x187E43740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public Vector3 HBKMLELBMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7E43C10", Offset = "0x7E42E10", VA = "0x187E43C10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Quaternion GJAOIAOJOPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7E43910", Offset = "0x7E42B10", VA = "0x187E43910")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public MCDCCMBIKEN HNNFFIOHBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7E43620", Offset = "0x7E42820", VA = "0x187E43620")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7E40750", Offset = "0x7E3F950", VA = "0x187E40750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7E43840", Offset = "0x7E42A40", VA = "0x187E43840")]
	public AIKGNMJNLMB KPLKIFMOHPB(Allocator FOPENOLHBOM)
	{
		return default(AIKGNMJNLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7E437A0", Offset = "0x7E429A0", VA = "0x187E437A0")]
	public bool JDMHPFKLFIM(MCDCCMBIKEN NJHDJGHEICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7E434D0", Offset = "0x7E426D0", VA = "0x187E434D0")]
	public void BNILOBFAKDC(Vector3 BJHAAAPCKLC, Quaternion PANMBKPFLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7E43D60", Offset = "0x7E42F60", VA = "0x187E43D60")]
	public void PHDPKILMLJF(float MMIJFAFPOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x7E43A50", Offset = "0x7E42C50", VA = "0x187E43A50")]
	public void NPNOKMJFIIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public COEIAFAJCOK(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7E40760", Offset = "0x7E3F960", VA = "0x187E40760")]
	public static bool NEKLFDMHCNA(COEIAFAJCOK MLCDCHNOCFI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static HAONCNNABLP NEKLFDMHCNA(COEIAFAJCOK MLCDCHNOCFI)
	{
		return default(HAONCNNABLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7E436B0", Offset = "0x7E428B0", VA = "0x187E436B0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(COEIAFAJCOK FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct DGIHMJLOBAF : IEquatable<DGIHMJLOBAF>
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly DGIHMJLOBAF AIIEKMBHIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private FNKGGFNAPJH JJEKIMELFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7E45F70", Offset = "0x7E45170", VA = "0x187E45F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<MCDCCMBIKEN> MKHNEOCCLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7E45D60", Offset = "0x7E44F60", VA = "0x187E45D60")]
		get
		{
			return default(Span<MCDCCMBIKEN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7E45FD0", Offset = "0x7E451D0", VA = "0x187E45FD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7E45E60", Offset = "0x7E45060", VA = "0x187E45E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public OFMNNNLLCMI NBDDMFIBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(OFMNNNLLCMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public DOIBMDKGMFE GAFOONPBFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(DOIBMDKGMFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7E40750", Offset = "0x7E3F950", VA = "0x187E40750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7E458C0", Offset = "0x7E44AC0", VA = "0x187E458C0")]
	public void BENOFAPECCN(DGIHMJLOBAF FNJGMJGALLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public DGIHMJLOBAF(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x7E40760", Offset = "0x7E3F960", VA = "0x187E40760")]
	public static bool NEKLFDMHCNA(DGIHMJLOBAF MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7E45EE0", Offset = "0x7E450E0", VA = "0x187E45EE0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(DGIHMJLOBAF FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static MCDCCMBIKEN NEKLFDMHCNA(DGIHMJLOBAF CEENCLMGJAM)
	{
		return default(MCDCCMBIKEN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public struct GMFHHFBCIEG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Dictionary<int, object> JPGJDFDDJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private GCPHFAECGBF CDCHJDEHFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private bool HAKDEDLGFPF;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		[CompilerGenerated]
		readonly get
		{
			return default(MCDCCMBIKEN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public DGOHIKJIHIE JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7E4AB80", Offset = "0x7E49D80", VA = "0x187E4AB80")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x7E4ACF0", Offset = "0x7E49EF0", VA = "0x187E4ACF0")]
	internal GMFHHFBCIEG(MCDCCMBIKEN DBCLNEGBNLN, bool HAKDEDLGFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x7E4AA50", Offset = "0x7E49C50", VA = "0x187E4AA50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x3822000", Offset = "0x3821200", VA = "0x183822000")]
	public void OKMNIJCMHMP<T>(DGOHIKJIHIE AGBHGDFILGO, T MLCDCHNOCFI, [Optional] T FAGKKFIFNNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7E4AC40", Offset = "0x7E49E40", VA = "0x187E4AC40")]
	public void KKKHDEJPLIG(DGOHIKJIHIE AGBHGDFILGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0xDAB610", Offset = "0xDAA810", VA = "0x180DAB610")]
	public Dictionary<int, object> LKBNIJDEABB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A9E0", Offset = "0x7E49BE0", VA = "0x187E4A9E0")]
	private readonly void CDDJDAFIABF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class BLGLCPNPHBJ
{
	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x7E43110", Offset = "0x7E42310", VA = "0x187E43110")]
	public static GMFHHFBCIEG ACPKCIMNLHL(this MCDCCMBIKEN DBCLNEGBNLN)
	{
		return default(GMFHHFBCIEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct BIOGAFBCPNH : IEquatable<BIOGAFBCPNH>
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly BIOGAFBCPNH AIIEKMBHIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private bool LPLBONDOJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7E42FF0", Offset = "0x7E421F0", VA = "0x187E42FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Vector3 PHJFPLBIKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7E42F40", Offset = "0x7E42140", VA = "0x187E42F40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7E42E60", Offset = "0x7E42060", VA = "0x187E42E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7E42CA0", Offset = "0x7E41EA0", VA = "0x187E42CA0")]
	public Vector3 DFLEFDNJEDP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7E42EC0", Offset = "0x7E420C0", VA = "0x187E42EC0")]
	public void LNELMKLELDG([In] Vector3 MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7E42C20", Offset = "0x7E41E20", VA = "0x187E42C20")]
	public void CNBKMBDEJGJ([In] Vector3 MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7E42DB0", Offset = "0x7E41FB0", VA = "0x187E42DB0")]
	public bool IJJBEEPNPHA([In] Vector3 MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public BIOGAFBCPNH(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7E42D20", Offset = "0x7E41F20", VA = "0x187E42D20", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(BIOGAFBCPNH FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7E43030", Offset = "0x7E42230", VA = "0x187E43030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct NBPBEIJFOPO : IEquatable<NBPBEIJFOPO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7E50D70", Offset = "0x7E4FF70", VA = "0x187E50D70", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(NBPBEIJFOPO FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct DOIBMDKGMFE : IEquatable<DOIBMDKGMFE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private FNKGGFNAPJH JJEKIMELFLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7E47AC0", Offset = "0x7E46CC0", VA = "0x187E47AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public HAONCNNABLP JGDEBFDHPNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7E47110", Offset = "0x7E46310", VA = "0x187E47110")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public MCDCCMBIKEN EKNHDPMCHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7E47A30", Offset = "0x7E46C30", VA = "0x187E47A30")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public MCDCCMBIKEN ADHDCGIKAEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E479A0", Offset = "0x7E46BA0", VA = "0x187E479A0")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7E40750", Offset = "0x7E3F950", VA = "0x187E40750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7E47710", Offset = "0x7E46910", VA = "0x187E47710")]
	public Span<MCDCCMBIKEN> IIKNEPBHAOK()
	{
		return default(Span<MCDCCMBIKEN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7E471A0", Offset = "0x7E463A0", VA = "0x187E471A0")]
	public Span<MCDCCMBIKEN> BFHACMJPBDL()
	{
		return default(Span<MCDCCMBIKEN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7E473D0", Offset = "0x7E465D0", VA = "0x187E473D0")]
	public Span<MCDCCMBIKEN> FIMALBFBGPI()
	{
		return default(Span<MCDCCMBIKEN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7E478A0", Offset = "0x7E46AA0", VA = "0x187E478A0")]
	public Span<MCDCCMBIKEN> LADOBBCFMKD()
	{
		return default(Span<MCDCCMBIKEN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7E474D0", Offset = "0x7E466D0", VA = "0x187E474D0")]
	public bool GDFLKEKMOMJ(MCDCCMBIKEN NJHDJGHEICO, bool NLMDKHPIEPA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7E472A0", Offset = "0x7E464A0", VA = "0x187E472A0")]
	public bool DGOGMDJPJJL(MCDCCMBIKEN GBGHCIFKFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7E47600", Offset = "0x7E46800", VA = "0x187E47600")]
	public MCDCCMBIKEN HHEOAPNCADH(uint GCGGFAHMFAL)
	{
		return default(MCDCCMBIKEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7E47810", Offset = "0x7E46A10", VA = "0x187E47810")]
	public DGIHMJLOBAF JKPAEADHKCF()
	{
		return default(DGIHMJLOBAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public DOIBMDKGMFE(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7E40760", Offset = "0x7E3F960", VA = "0x187E40760")]
	public static bool NEKLFDMHCNA(DOIBMDKGMFE MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7E47340", Offset = "0x7E46540", VA = "0x187E47340", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(DOIBMDKGMFE FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct HLDFDEIBNMP : IEquatable<HLDFDEIBNMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public string GKPIDFDNOIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7E4BE30", Offset = "0x7E4B030", VA = "0x187E4BE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public string HIFPNMIAFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7E4BF80", Offset = "0x7E4B180", VA = "0x187E4BF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public string LCCGEKBKMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E4BB90", Offset = "0x7E4AD90", VA = "0x187E4BB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E4BEC0", Offset = "0x7E4B0C0", VA = "0x187E4BEC0")]
	public bool LNHCFNELBFJ([Out] string HBKHCDNFAFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public HLDFDEIBNMP(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E4BB00", Offset = "0x7E4AD00", VA = "0x187E4BB00", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(HLDFDEIBNMP FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct DHNLJAOMAJA : IEquatable<DHNLJAOMAJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private LFIPNAPDLLE EOJHFGNIHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7E46D20", Offset = "0x7E45F20", VA = "0x187E46D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public OOJGIMJMHJA HCJPCFDGNPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E46B00", Offset = "0x7E45D00", VA = "0x187E46B00")]
		get
		{
			return default(OOJGIMJMHJA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7E46050", Offset = "0x7E45250", VA = "0x187E46050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool PGHECINBBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7E46680", Offset = "0x7E45880", VA = "0x187E46680")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7E46160", Offset = "0x7E45360", VA = "0x187E46160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public IAJOLCEBCCF<string> CIIBPNKMABI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7E46320", Offset = "0x7E45520", VA = "0x187E46320")]
		get
		{
			return default(IAJOLCEBCCF<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7E468C0", Offset = "0x7E45AC0", VA = "0x187E468C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public IAJOLCEBCCF<string> OJJLIPHNOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7E46C00", Offset = "0x7E45E00", VA = "0x187E46C00")]
		get
		{
			return default(IAJOLCEBCCF<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7E46200", Offset = "0x7E45400", VA = "0x187E46200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public IAJOLCEBCCF<string> LDFPOMHOGBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7E467A0", Offset = "0x7E459A0", VA = "0x187E467A0")]
		get
		{
			return default(IAJOLCEBCCF<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7E46440", Offset = "0x7E45640", VA = "0x187E46440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public IAJOLCEBCCF<string> NDMNMCOLEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7E469E0", Offset = "0x7E45BE0", VA = "0x187E469E0")]
		get
		{
			return default(IAJOLCEBCCF<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7E46560", Offset = "0x7E45760", VA = "0x187E46560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7E40750", Offset = "0x7E3F950", VA = "0x187E40750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7E46D80", Offset = "0x7E45F80", VA = "0x187E46D80")]
	public bool OCDEAPFNPOP(HAONCNNABLP PNBFNEJFAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public DHNLJAOMAJA(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static HAONCNNABLP NEKLFDMHCNA(DHNLJAOMAJA MLCDCHNOCFI)
	{
		return default(HAONCNNABLP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x7E46710", Offset = "0x7E45910", VA = "0x187E46710", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(DHNLJAOMAJA FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct CHKBOGDGNHE : IEquatable<CHKBOGDGNHE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7E43390", Offset = "0x7E42590", VA = "0x187E43390", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(CHKBOGDGNHE FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct KMPFGADNIEN : IEquatable<KMPFGADNIEN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D920", Offset = "0x7E4CB20", VA = "0x187E4D920", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(KMPFGADNIEN FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct MAGLFLGKBFI : IEquatable<MAGLFLGKBFI>
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly ComponentTypes HCNBNABGFND;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly MAGLFLGKBFI AIIEKMBHIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Collider LOJMIOKAGDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7E4EDB0", Offset = "0x7E4DFB0", VA = "0x187E4EDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public LFONANDBLOB GIPHNDEKGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7E4EC90", Offset = "0x7E4DE90", VA = "0x187E4EC90")]
		get
		{
			return default(LFONANDBLOB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F200", Offset = "0x7E4E400", VA = "0x187E4F200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public CLCCGGMNJHK OKHCFANBDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F700", Offset = "0x7E4E900", VA = "0x187E4F700")]
		get
		{
			return default(CLCCGGMNJHK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F0F0", Offset = "0x7E4E2F0", VA = "0x187E4F0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public EBPGAOAANLG LEMJDMCAGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F140", Offset = "0x7E4E340", VA = "0x187E4F140")]
		get
		{
			return default(EBPGAOAANLG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7E4ED60", Offset = "0x7E4DF60", VA = "0x187E4ED60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public float EKOJBIBGCLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7E4EB30", Offset = "0x7E4DD30", VA = "0x187E4EB30")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7E4EAE0", Offset = "0x7E4DCE0", VA = "0x187E4EAE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool BDAACFPLIOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F490", Offset = "0x7E4E690", VA = "0x187E4F490")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7E4EA40", Offset = "0x7E4DC40", VA = "0x187E4EA40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool MNECDHNIBBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F180", Offset = "0x7E4E380", VA = "0x187E4F180")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7E4EF00", Offset = "0x7E4E100", VA = "0x187E4EF00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool ILFNIJBPCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7E4EB70", Offset = "0x7E4DD70", VA = "0x187E4EB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F500", Offset = "0x7E4E700", VA = "0x187E4F500")]
	public static bool MHEKGJAJGMO(MCDCCMBIKEN CFHOHKBAAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F250", Offset = "0x7E4E450", VA = "0x187E4F250")]
	public static bool LONOHHPMJJI(MCDCCMBIKEN CFHOHKBAAHD, [Out] MAGLFLGKBFI NDEECHAPCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F740", Offset = "0x7E4E940", VA = "0x187E4F740")]
	public bool PCDKDJJCNOF([Out] KOGNBGJPJEL NKJGEEFAAOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7E4EFA0", Offset = "0x7E4E1A0", VA = "0x187E4EFA0")]
	public bool HPFMIKKDCKD([Out] HAONCNNABLP FHPKLENNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F090", Offset = "0x7E4E290", VA = "0x187E4F090")]
	public bool IFMMDINFIFP(PFDCBFKJOFO ONCELMGACCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F8B0", Offset = "0x7E4EAB0", VA = "0x187E4F8B0")]
	public void PNBHHIKOBBN(PFDCBFKJOFO ONCELMGACCP, bool BMBINDLKLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7E4EBF0", Offset = "0x7E4DDF0", VA = "0x187E4EBF0")]
	public void BNJMDOMCHIH(PFDCBFKJOFO ONCELMGACCP, bool BMBINDLKLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public MAGLFLGKBFI(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7E4ECD0", Offset = "0x7E4DED0", VA = "0x187E4ECD0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(MAGLFLGKBFI FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F930", Offset = "0x7E4EB30", VA = "0x187E4F930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct OFBJENPPHOI : IEquatable<OFBJENPPHOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public bool HBMJODMPBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7E51CF0", Offset = "0x7E50EF0", VA = "0x187E51CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public OFBJENPPHOI(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7E51C60", Offset = "0x7E50E60", VA = "0x187E51C60", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(OFBJENPPHOI FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct OPHMOPJMGBA : IEquatable<OPHMOPJMGBA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private CEDEDEJDLFE PIBMFBFCBIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x7E543D0", Offset = "0x7E535D0", VA = "0x187E543D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7E40750", Offset = "0x7E3F950", VA = "0x187E40750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7E544C0", Offset = "0x7E536C0", VA = "0x187E544C0")]
	public void PHENKJBHNBJ(bool PGKHDCKJOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public OPHMOPJMGBA(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7E54430", Offset = "0x7E53630", VA = "0x187E54430", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(OPHMOPJMGBA FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct FLFOCNLLGFB : IEquatable<FLFOCNLLGFB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public bool FHEOKOPEEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x7E49BB0", Offset = "0x7E48DB0", VA = "0x187E49BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public bool NGKMPEILLHI
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A0C0", Offset = "0x7E492C0", VA = "0x187E4A0C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool JPJEBJBHADH
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A230", Offset = "0x7E49430", VA = "0x187E4A230")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x7E49880", Offset = "0x7E48A80", VA = "0x187E49880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public bool DDFGAKGPPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x7E49960", Offset = "0x7E48B60", VA = "0x187E49960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool BBNIKCPOIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x7E49F10", Offset = "0x7E49110", VA = "0x187E49F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool KIEBOCOEMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x7E49F60", Offset = "0x7E49160", VA = "0x187E49F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool ELHKFFAFBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x7E49790", Offset = "0x7E48990", VA = "0x187E49790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool HPMIAGCKOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A280", Offset = "0x7E49480", VA = "0x187E4A280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool DJDJPGOCGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x7E499B0", Offset = "0x7E48BB0", VA = "0x187E499B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool LFMACPDAFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A2D0", Offset = "0x7E494D0", VA = "0x187E4A2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool KAAFNCAOGKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7E49FB0", Offset = "0x7E491B0", VA = "0x187E49FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool LBCNEKAOANJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7E497E0", Offset = "0x7E489E0", VA = "0x187E497E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool DKLAKGFBEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7E49EC0", Offset = "0x7E490C0", VA = "0x187E49EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool MOLMFLNHFDM
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A080", Offset = "0x7E49280", VA = "0x187E4A080")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7E498A0", Offset = "0x7E48AA0", VA = "0x187E498A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public INHFKGENNEJ DIJEGPHFBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A000", Offset = "0x7E49200", VA = "0x187E4A000")]
		get
		{
			return default(INHFKGENNEJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7E49B20", Offset = "0x7E48D20", VA = "0x187E49B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool LMPMOOAFJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A110", Offset = "0x7E49310", VA = "0x187E4A110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public LEFIJBDKMMH JKAFHGAHLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A040", Offset = "0x7E49240", VA = "0x187E4A040")]
		get
		{
			return default(LEFIJBDKMMH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7E49A00", Offset = "0x7E48C00", VA = "0x187E49A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public bool OCPPCPPGBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x7E49B70", Offset = "0x7E48D70", VA = "0x187E49B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 BJHJLMOENIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x7E49D70", Offset = "0x7E48F70", VA = "0x187E49D70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Vector3 BLMOEBANGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x7E49BF0", Offset = "0x7E48DF0", VA = "0x187E49BF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool OPPIJJOOOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x7E49C70", Offset = "0x7E48E70", VA = "0x187E49C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7E40750", Offset = "0x7E3F950", VA = "0x187E40750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7E49900", Offset = "0x7E48B00", VA = "0x187E49900")]
	public bool DHFBPOCAPBF(HBDBNMDAFGA ONCELMGACCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7E49700", Offset = "0x7E48900", VA = "0x187E49700")]
	public void ACBHDBMEPGP(HBDBNMDAFGA ONCELMGACCP, bool BMBINDLKLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7E49830", Offset = "0x7E48A30", VA = "0x187E49830")]
	public bool CBBCLDODOHK(KHFPIIIDCNJ ONCELMGACCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7E49E40", Offset = "0x7E49040", VA = "0x187E49E40")]
	public void HJCKHCIJOLB(KHFPIIIDCNJ ONCELMGACCP, bool BMBINDLKLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7E49A50", Offset = "0x7E48C50", VA = "0x187E49A50")]
	public KHFPIIIDCNJ EODBMLPIOOA()
	{
		return default(KHFPIIIDCNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7E49DF0", Offset = "0x7E48FF0", VA = "0x187E49DF0")]
	public bool HIHLKLCPOAO(KHFPIIIDCNJ MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public FLFOCNLLGFB(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7E49A90", Offset = "0x7E48C90", VA = "0x187E49A90", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(FLFOCNLLGFB FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct NFCPFOBAADP : IEquatable<NFCPFOBAADP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private IELKIFCINDB NPDFNJGDMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x7E50E00", Offset = "0x7E50000", VA = "0x187E50E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	private NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x7E40750", Offset = "0x7E3F950", VA = "0x187E40750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7E51150", Offset = "0x7E50350", VA = "0x187E51150")]
	public bool EBECCFCLKAJ(FKJDPJEKDDH HFFFCKALIAN, List<MCDCCMBIKEN> HEBIEBIPLCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7E51310", Offset = "0x7E50510", VA = "0x187E51310")]
	public int GEBIOEFKKNE(FKJDPJEKDDH HFFFCKALIAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7E51790", Offset = "0x7E50990", VA = "0x187E51790")]
	public void MEAIJGJFDLA(List<MCDCCMBIKEN> HEBIEBIPLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7E51530", Offset = "0x7E50730", VA = "0x187E51530")]
	public int IOLJJNDBKMM(MCDCCMBIKEN PJNHLGGHCLG, FKJDPJEKDDH HFFFCKALIAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7E51020", Offset = "0x7E50220", VA = "0x187E51020")]
	public MCDCCMBIKEN CNFKPCNDFFG(int NIBICIJAIGM, FKJDPJEKDDH HFFFCKALIAN)
	{
		return default(MCDCCMBIKEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7E51660", Offset = "0x7E50860", VA = "0x187E51660")]
	public void LHGCFELHPPO(MCDCCMBIKEN PJNHLGGHCLG, FKJDPJEKDDH HFFFCKALIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7E518A0", Offset = "0x7E50AA0", VA = "0x187E518A0")]
	public bool MHHDHLJNJJE(MCDCCMBIKEN PJNHLGGHCLG, FKJDPJEKDDH HFFFCKALIAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7E50F10", Offset = "0x7E50110", VA = "0x187E50F10")]
	public void CLBFAPGBFKP(FKJDPJEKDDH HFFFCKALIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7E50E60", Offset = "0x7E50060", VA = "0x187E50E60")]
	public bool CCNFBKLAINF(MCDCCMBIKEN PJNHLGGHCLG, FKJDPJEKDDH HFFFCKALIAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7E51420", Offset = "0x7E50620", VA = "0x187E51420")]
	public bool GJFGCCAOLKF(FKJDPJEKDDH HFFFCKALIAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public NFCPFOBAADP(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x7E51280", Offset = "0x7E50480", VA = "0x187E51280", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(NFCPFOBAADP FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct IHONNMHPEPM : IEquatable<IHONNMHPEPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x7E40750", Offset = "0x7E3F950", VA = "0x187E40750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C530", Offset = "0x7E4B730", VA = "0x187E4C530")]
	public void KKDBCDJMBDO(bool MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C4A0", Offset = "0x7E4B6A0", VA = "0x187E4C4A0")]
	public void GBBFKCHFMEK(bool MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x384A990", Offset = "0x3849B90", VA = "0x18384A990")]
	public T EIKNGFIDFBG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public IHONNMHPEPM(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C410", Offset = "0x7E4B610", VA = "0x187E4C410", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(IHONNMHPEPM FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct FDNELKFAALI : IEquatable<FDNELKFAALI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public bool AHHACALOFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x7E489F0", Offset = "0x7E47BF0", VA = "0x187E489F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x7E48840", Offset = "0x7E47A40", VA = "0x187E48840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool GNIHFNMANMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x7E487C0", Offset = "0x7E479C0", VA = "0x187E487C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public int OLDLBBDOKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7E48920", Offset = "0x7E47B20", VA = "0x187E48920")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x7E48960", Offset = "0x7E47B60", VA = "0x187E48960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x7E40750", Offset = "0x7E3F950", VA = "0x187E40750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public FDNELKFAALI(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7E48890", Offset = "0x7E47A90", VA = "0x187E48890", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(FDNELKFAALI FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct AOKBAJMKEFN : IEquatable<AOKBAJMKEFN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public int BGINMJKIODE
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x7E41AC0", Offset = "0x7E40CC0", VA = "0x187E41AC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x7E41B00", Offset = "0x7E40D00", VA = "0x187E41B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public int JNABHLOEOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x7E419A0", Offset = "0x7E40BA0", VA = "0x187E419A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x7E41A70", Offset = "0x7E40C70", VA = "0x187E41A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public AOKBAJMKEFN(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7E419E0", Offset = "0x7E40BE0", VA = "0x187E419E0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(AOKBAJMKEFN FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct PDBMANDGCLE : IEquatable<PDBMANDGCLE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	private ENIPDEEILMA IKDLJDINNJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x7E54C80", Offset = "0x7E53E80", VA = "0x187E54C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	private PLFNIKFIIFO PMDBCAIDJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x7E54830", Offset = "0x7E53A30", VA = "0x187E54830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public bool EADJFNDONMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7E54600", Offset = "0x7E53800", VA = "0x187E54600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public bool EGHAKEHPIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7E54EE0", Offset = "0x7E540E0", VA = "0x187E54EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool PALKKGEMFNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7E54F80", Offset = "0x7E54180", VA = "0x187E54F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool LDFBEPDFGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7E54890", Offset = "0x7E53A90", VA = "0x187E54890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool MMBJBAJMDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7E54960", Offset = "0x7E53B60", VA = "0x187E54960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool PMDHLGIAKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7E54E50", Offset = "0x7E54050", VA = "0x187E54E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool POCOFHGHNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7E55050", Offset = "0x7E54250", VA = "0x187E55050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool MGFKDPJAHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7E54CE0", Offset = "0x7E53EE0", VA = "0x187E54CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool DDOLPOBFIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7E54B50", Offset = "0x7E53D50", VA = "0x187E54B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	private NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7E40750", Offset = "0x7E3F950", VA = "0x187E40750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7E54A40", Offset = "0x7E53C40", VA = "0x187E54A40")]
	public bool HHLAJAGDMIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7E54AB0", Offset = "0x7E53CB0", VA = "0x187E54AB0")]
	public MCDCCMBIKEN LFCMMKCJOEN(MCDCCMBIKEN PJNHLGGHCLG)
	{
		return default(MCDCCMBIKEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7E54720", Offset = "0x7E53920", VA = "0x187E54720")]
	public HAONCNNABLP FBMEOJPMLDO()
	{
		return default(HAONCNNABLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7E54FB0", Offset = "0x7E541B0", VA = "0x187E54FB0")]
	public bool OOJOJCFKLBB(HAONCNNABLP GHOFKCGBING)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7E54560", Offset = "0x7E53760", VA = "0x187E54560")]
	public bool CBHHLMLDDLK(HAONCNNABLP CFPOLEILGCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7E54990", Offset = "0x7E53B90", VA = "0x187E54990")]
	public bool GBENNAMHIEO(HAONCNNABLP PJNHLGGHCLG, [Out] HAONCNNABLP GHOFKCGBING)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public PDBMANDGCLE(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7E40760", Offset = "0x7E3F960", VA = "0x187E40760")]
	public static bool NEKLFDMHCNA(PDBMANDGCLE MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x7E54690", Offset = "0x7E53890", VA = "0x187E54690", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(PDBMANDGCLE FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct PLKJKBMLEAE : IEquatable<PLKJKBMLEAE>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly PLKJKBMLEAE AIIEKMBHIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public NGNNDBBMKGO MDHFODKHIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7E55990", Offset = "0x7E54B90", VA = "0x187E55990")]
		get
		{
			return default(NGNNDBBMKGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public KFBMHGEEILN NLNHPPFMCIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7E55B60", Offset = "0x7E54D60", VA = "0x187E55B60")]
		get
		{
			return default(KFBMHGEEILN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7E55C60", Offset = "0x7E54E60", VA = "0x187E55C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public JMMJHJPMGML HKJLLEFIMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7E55740", Offset = "0x7E54940", VA = "0x187E55740")]
		get
		{
			return default(JMMJHJPMGML);
		}
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7E55A10", Offset = "0x7E54C10", VA = "0x187E55A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public float OENACJJILNA
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7E55BA0", Offset = "0x7E54DA0", VA = "0x187E55BA0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7E557D0", Offset = "0x7E549D0", VA = "0x187E557D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public Vector3 OELPKGLMJCF
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7E55CB0", Offset = "0x7E54EB0", VA = "0x187E55CB0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7E55D30", Offset = "0x7E54F30", VA = "0x187E55D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public float CCIOMPKEIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7E558F0", Offset = "0x7E54AF0", VA = "0x187E558F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public OMNIHJEOLPK FGBHMDOHLKP
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7E558B0", Offset = "0x7E54AB0", VA = "0x187E558B0")]
		get
		{
			return default(OMNIHJEOLPK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7E55A60", Offset = "0x7E54C60", VA = "0x187E55A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public bool KNCGLOHGPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7E559D0", Offset = "0x7E54BD0", VA = "0x187E559D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7E55AB0", Offset = "0x7E54CB0", VA = "0x187E55AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public OFMNNNLLCMI NBDDMFIBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(OFMNNNLLCMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public DOIBMDKGMFE GAFOONPBFLA
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(DOIBMDKGMFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x7E55940", Offset = "0x7E54B40", VA = "0x187E55940")]
	public NLNPCLAIEGP GOAOFJFIEPB()
	{
		return default(NLNPCLAIEGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x7E55B10", Offset = "0x7E54D10", VA = "0x187E55B10")]
	public AGHJBFIKNCN LJEPHOFOGFE()
	{
		return default(AGHJBFIKNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x7E55780", Offset = "0x7E54980", VA = "0x187E55780")]
	private bool BBMPLKOEGGM(OMNIHJEOLPK ONCELMGACCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x7E55BE0", Offset = "0x7E54DE0", VA = "0x187E55BE0")]
	public void NPEJEKGPPGO(OMNIHJEOLPK ONCELMGACCP, bool BMBINDLKLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public PLKJKBMLEAE(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x7E40760", Offset = "0x7E3F960", VA = "0x187E40760")]
	public static bool NEKLFDMHCNA(PLKJKBMLEAE MLCDCHNOCFI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x7E4AFF0", Offset = "0x7E4A1F0", VA = "0x187E4AFF0")]
	public static bool EFJOOJHLAGB(PLKJKBMLEAE FCKEKMKDGOB, PLKJKBMLEAE PMDPDEMGJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x7E55820", Offset = "0x7E54A20", VA = "0x187E55820", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(PLKJKBMLEAE FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct NLNPCLAIEGP : IEquatable<NLNPCLAIEGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public PLKJKBMLEAE OKCGBHEPGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(PLKJKBMLEAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public JNBMIBPKCDD GODHNAIMKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7E51BF0", Offset = "0x7E50DF0", VA = "0x187E51BF0")]
		get
		{
			return default(JNBMIBPKCDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public NLNPCLAIEGP(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x7E40760", Offset = "0x7E3F960", VA = "0x187E40760")]
	public static bool NEKLFDMHCNA(NLNPCLAIEGP MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x7E51B60", Offset = "0x7E50D60", VA = "0x187E51B60", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(NLNPCLAIEGP FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DefaultMember("Item")]
public readonly struct AGHJBFIKNCN : IEquatable<AGHJBFIKNCN>
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly AGHJBFIKNCN AIIEKMBHIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private BFLPCLDCIGL NNAHJHBBAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7E40650", Offset = "0x7E3F850", VA = "0x187E40650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public PLKJKBMLEAE OKCGBHEPGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(PLKJKBMLEAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public BKHKOHIOKMA IMJBLGLPMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x7E3FDB0", Offset = "0x7E3EFB0", VA = "0x187E3FDB0")]
		get
		{
			return default(BKHKOHIOKMA);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7E3FEE0", Offset = "0x7E3F0E0", VA = "0x187E3FEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public IEnumerable<BINKOKKDEAA> CLNFJDNPLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7E40450", Offset = "0x7E3F650", VA = "0x187E40450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public BINKOKKDEAA JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x7E40000", Offset = "0x7E3F200", VA = "0x187E40000")]
		get
		{
			return default(BINKOKKDEAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7E406B0", Offset = "0x7E3F8B0", VA = "0x187E406B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public OFMNNNLLCMI NBDDMFIBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(OFMNNNLLCMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	private NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E40750", Offset = "0x7E3F950", VA = "0x187E40750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7E40230", Offset = "0x7E3F430", VA = "0x187E40230")]
	public BINKOKKDEAA JBHHHNKAKMJ(float3? BJHAAAPCKLC, [Optional] quaternion? PANMBKPFLFA, [Optional] Vector3? MMIJFAFPOOH)
	{
		return default(BINKOKKDEAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FB80", Offset = "0x7E3ED80", VA = "0x187E3FB80")]
	public BINKOKKDEAA AINFJIJKHJI(int NIBICIJAIGM, float3? BJHAAAPCKLC, [Optional] quaternion? PANMBKPFLFA, [Optional] Vector3? MMIJFAFPOOH)
	{
		return default(BINKOKKDEAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x7E40780", Offset = "0x7E3F980", VA = "0x187E40780")]
	public void OKJKNKIJNEH(int NIBICIJAIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x7E401A0", Offset = "0x7E3F3A0", VA = "0x187E401A0")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public AGHJBFIKNCN(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E40760", Offset = "0x7E3F960", VA = "0x187E40760")]
	public static bool NEKLFDMHCNA(AGHJBFIKNCN MLCDCHNOCFI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E40740", Offset = "0x7E3F940", VA = "0x187E40740")]
	public static bool NDBPPCEOMJH(AGHJBFIKNCN FCKEKMKDGOB, AGHJBFIKNCN PMDPDEMGJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E40110", Offset = "0x7E3F310", VA = "0x187E40110", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(AGHJBFIKNCN FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct BINKOKKDEAA : IEquatable<BINKOKKDEAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public AGHJBFIKNCN IDCMJFLCPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7E42AF0", Offset = "0x7E41CF0", VA = "0x187E42AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public float3 DPCPIKHAIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7E42A30", Offset = "0x7E41C30", VA = "0x187E42A30")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7E42A90", Offset = "0x7E41C90", VA = "0x187E42A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public quaternion PKAGPKPGINM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7E428F0", Offset = "0x7E41AF0", VA = "0x187E428F0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7E42BC0", Offset = "0x7E41DC0", VA = "0x187E42BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public float3 KAFMAACCCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7E42940", Offset = "0x7E41B40", VA = "0x187E42940")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7E42890", Offset = "0x7E41A90", VA = "0x187E42890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public ABGKFFJDPAB IPGKACLMHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7E42B70", Offset = "0x7E41D70", VA = "0x187E42B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7E42C10", Offset = "0x7E41E10", VA = "0x187E42C10")]
	public void NCACMJDEIHD(AGHJBFIKNCN MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public BINKOKKDEAA(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x7E429A0", Offset = "0x7E41BA0", VA = "0x187E429A0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(BINKOKKDEAA FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct JAGDBKPBNED : IEquatable<JAGDBKPBNED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public bool HONCIFEOCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C6B0", Offset = "0x7E4B8B0", VA = "0x187E4C6B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public JAGDBKPBNED(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C620", Offset = "0x7E4B820", VA = "0x187E4C620", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(JAGDBKPBNED FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct FEOAOFALJOA : IEquatable<FEOAOFALJOA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	private FIBGICHKMPL ABLPIPHGOKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7E49400", Offset = "0x7E48600", VA = "0x187E49400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public bool BFJFDACEHCL
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7E48EF0", Offset = "0x7E480F0", VA = "0x187E48EF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7E48B30", Offset = "0x7E47D30", VA = "0x187E48B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public bool HECBJPFIMIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7E49540", Offset = "0x7E48740", VA = "0x187E49540")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7E48AD0", Offset = "0x7E47CD0", VA = "0x187E48AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public float AGPEAJJAGBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7E48B90", Offset = "0x7E47D90", VA = "0x187E48B90")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7E48E10", Offset = "0x7E48010", VA = "0x187E48E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public bool EMFOMPPDJPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7E48F40", Offset = "0x7E48140", VA = "0x187E48F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	private NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7E40750", Offset = "0x7E3F950", VA = "0x187E40750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7E48A30", Offset = "0x7E47C30", VA = "0x187E48A30")]
	public void AFDILLLCIMG(int FNEFIOJLPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x7E48BD0", Offset = "0x7E47DD0", VA = "0x187E48BD0")]
	public bool BHJBEALJBJH([Out] int FNEFIOJLPDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x7E48F90", Offset = "0x7E48190", VA = "0x187E48F90")]
	public void HNHKCPHDNOL(bool ICNBMDJMNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x7E494F0", Offset = "0x7E486F0", VA = "0x187E494F0")]
	public bool MAOKPNACLCE(MAEIDCFHPBM ONCELMGACCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x7E49590", Offset = "0x7E48790", VA = "0x187E49590")]
	public void PIOOFIDMLLN(MAEIDCFHPBM ONCELMGACCP, bool BMBINDLKLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7E49030", Offset = "0x7E48230", VA = "0x187E49030")]
	public void IDDEIHEECMN(float DMABBCGNHGC, float LOIAGAJJPON, float FIHLNFOMPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7E49180", Offset = "0x7E48380", VA = "0x187E49180")]
	public void JHFBEBMKJGM(float3 GHBAHGAHJIO, quaternion PNNAGLFDIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7E492D0", Offset = "0x7E484D0", VA = "0x187E492D0")]
	public bool KFFGCNBDHEB([Out] float3 GHBAHGAHJIO, [Out] quaternion PNNAGLFDIEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7E48CE0", Offset = "0x7E47EE0", VA = "0x187E48CE0")]
	public bool CLFGHCCLKGD([Out] float IFIHPIALIPL, [Out] float CGCPMEDEMIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7E49460", Offset = "0x7E48660", VA = "0x187E49460")]
	public void LAGCKNAJKHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public FEOAOFALJOA(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E48E60", Offset = "0x7E48060", VA = "0x187E48E60", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(FEOAOFALJOA FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct OFMNNNLLCMI : IEquatable<OFMNNNLLCMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	private EDLCJCKFFCD PMJDDMBLHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7E51E30", Offset = "0x7E51030", VA = "0x187E51E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public Vector3 DPCPIKHAIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7E52A20", Offset = "0x7E51C20", VA = "0x187E52A20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7E52BA0", Offset = "0x7E51DA0", VA = "0x187E52BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public Quaternion PKAGPKPGINM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7E525F0", Offset = "0x7E517F0", VA = "0x187E525F0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7E52F90", Offset = "0x7E52190", VA = "0x187E52F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public Vector3 NGDJNNKBJPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7E51D40", Offset = "0x7E50F40", VA = "0x187E51D40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7E53730", Offset = "0x7E52930", VA = "0x187E53730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public Quaternion LPOBAHMNGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x7E52400", Offset = "0x7E51600", VA = "0x187E52400")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7E535B0", Offset = "0x7E527B0", VA = "0x187E535B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public float EBHAPFBFHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7E52C70", Offset = "0x7E51E70", VA = "0x187E52C70")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7E52540", Offset = "0x7E51740", VA = "0x187E52540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public float BPIFKBIOOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7E52E00", Offset = "0x7E52000", VA = "0x187E52E00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public Matrix4x4 AGBIGMCLHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x7E53570", Offset = "0x7E52770", VA = "0x187E53570")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public DOIBMDKGMFE GAFOONPBFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(DOIBMDKGMFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	private IPHDOCEGNCL IOMPIJDCPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B010", Offset = "0x7E4A210", VA = "0x187E4B010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7E53B50", Offset = "0x7E52D50", VA = "0x187E53B50")]
	public AOECEAGCFFM PCMKBAMFGGO()
	{
		return default(AOECEAGCFFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x7E53450", Offset = "0x7E52650", VA = "0x187E53450")]
	public void LCMPIFDAMEL([Out] Matrix4x4 HBIIBPNLLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x7E51FB0", Offset = "0x7E511B0", VA = "0x187E51FB0")]
	public void AKBJMPBIAGH([In] Vector3 KGEICFIBDCA, [In] Quaternion JLBNIDPEHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7E51EF0", Offset = "0x7E510F0", VA = "0x187E51EF0")]
	public void AKBJMPBIAGH([In] RigidTransform EPGCLIOHMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x7E53680", Offset = "0x7E52880", VA = "0x187E53680")]
	public void MPOBJFMHGJC([Out] RigidTransform EPGCLIOHMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x7E53990", Offset = "0x7E52B90", VA = "0x187E53990")]
	public void OELKIMBICFL([In] Vector3 EJJBMIDIGHF, [In] Quaternion HPGKEAAFLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x7E53A90", Offset = "0x7E52C90", VA = "0x187E53A90")]
	public void OELKIMBICFL([In] RigidTransform PLCNEOBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x7E538B0", Offset = "0x7E52AB0", VA = "0x187E538B0")]
	public void NPOBAGFBAHN([Out] Vector3 EJJBMIDIGHF, [Out] Quaternion HPGKEAAFLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7E53800", Offset = "0x7E52A00", VA = "0x187E53800")]
	public void NPOBAGFBAHN([Out] RigidTransform EPGCLIOHMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7E52F60", Offset = "0x7E52160", VA = "0x187E52F60")]
	public UniformTRS IKAKFBBOBON()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x7E52EA0", Offset = "0x7E520A0", VA = "0x187E52EA0")]
	public void IKAKFBBOBON([Out] UniformTRS PLCNEOBDJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x7E52D10", Offset = "0x7E51F10", VA = "0x187E52D10")]
	public UniformTRS IAELKEOAMJD()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7E52D40", Offset = "0x7E51F40", VA = "0x187E52D40")]
	public void IAELKEOAMJD([Out] UniformTRS EPGCLIOHMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7E52730", Offset = "0x7E51930", VA = "0x187E52730")]
	public Vector3 DPNPPPGEKCP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x7E520B0", Offset = "0x7E512B0", VA = "0x187E520B0")]
	public void AOLFNNOFNKI([In] Vector3 MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x7E53360", Offset = "0x7E52560", VA = "0x187E53360")]
	public Vector3 LBLBEMOBNEM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x7E53060", Offset = "0x7E52260", VA = "0x187E53060")]
	public void JANKIMLILKM([In] Vector3 MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x7E522C0", Offset = "0x7E514C0", VA = "0x187E522C0")]
	public Quaternion BFKALBCHPOA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7E52820", Offset = "0x7E51A20", VA = "0x187E52820")]
	public void ELBPMEEKCJA([In] Quaternion MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7E52180", Offset = "0x7E51380", VA = "0x187E52180")]
	public Quaternion BEJEMMMCDJD()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x7E53290", Offset = "0x7E52490", VA = "0x187E53290")]
	public void LBAGNPMOCDL([In] Quaternion MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x7E53BA0", Offset = "0x7E52DA0", VA = "0x187E53BA0")]
	public float POMLBILHOIN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x7E53130", Offset = "0x7E52330", VA = "0x187E53130")]
	public void JFNEPGLPBJM(float MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7E52980", Offset = "0x7E51B80", VA = "0x187E52980")]
	public float FOALKNPLADL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x7E531E0", Offset = "0x7E523E0", VA = "0x187E531E0")]
	public void KBLDLGLCBAM(float MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7E52B10", Offset = "0x7E51D10", VA = "0x187E52B10")]
	public Vector3 GECHKGFFBEL([In] Vector3 ACBMNMFGAEN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public OFMNNNLLCMI(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x7E528F0", Offset = "0x7E51AF0", VA = "0x187E528F0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(OFMNNNLLCMI FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct LHGPGCNOHBL : IEquatable<LHGPGCNOHBL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	private NKOKPFJMIDP EOJLBHEPKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E850", Offset = "0x7E4DA50", VA = "0x187E4E850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	private NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x7E40750", Offset = "0x7E3F950", VA = "0x187E40750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7E4E710", Offset = "0x7E4D910", VA = "0x187E4E710")]
	public void IDOBANKADHF(string LHAEPBBBCAO, BDBEEIMNNKF PKCEHJLPOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public LHGPGCNOHBL(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x7E4E680", Offset = "0x7E4D880", VA = "0x187E4E680", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(LHGPGCNOHBL FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3FA20", VA = "0x187E40820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct IDMBGBIAMPO : IEquatable<IDMBGBIAMPO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public MAEKCOICONB NGPIHJJMIDD
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C320", Offset = "0x7E4B520", VA = "0x187E4C320")]
		get
		{
			return default(MAEKCOICONB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public IDMBGBIAMPO(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C290", Offset = "0x7E4B490", VA = "0x187E4C290", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(IDMBGBIAMPO FNJGMJGALLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public readonly struct DDLOAHIGJMN : IEquatable<DDLOAHIGJMN>
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public struct FCCMNNKGIJG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private HAONCNNABLP EANCCIKOAFJ;

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x7E48720", Offset = "0x7E47920", VA = "0x187E48720")]
		public FCCMNNKGIJG(HAONCNNABLP EANCCIKOAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x7E48690", Offset = "0x7E47890", VA = "0x187E48690", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x7E45740", Offset = "0x7E44940", VA = "0x187E45740")]
	public FCCMNNKGIJG OPFHKGILNAI()
	{
		return default(FCCMNNKGIJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x7E457D0", Offset = "0x7E449D0", VA = "0x187E457D0")]
	public NJAOJMHOGEE PJIHIJEGNLC(Allocator FOPENOLHBOM = Allocator.Temp)
	{
		return default(NJAOJMHOGEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7E452F0", Offset = "0x7E444F0", VA = "0x187E452F0")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> KCEJDHNDCBF(Allocator FOPENOLHBOM = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7E45610", Offset = "0x7E44810", VA = "0x187E45610")]
	public NativeArray<KOAGADGMKNF> NAOKIHEFFII(Allocator FOPENOLHBOM = Allocator.Temp)
	{
		return default(NativeArray<KOAGADGMKNF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7E45420", Offset = "0x7E44620", VA = "0x187E45420")]
	public NativeArray<KOAGADGMKNF> KHNLHENJJPE(Allocator FOPENOLHBOM = Allocator.Temp)
	{
		return default(NativeArray<KOAGADGMKNF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7E450E0", Offset = "0x7E442E0", VA = "0x187E450E0")]
	public AIKGNMJNLMB COGMMMPNCCJ(Allocator FOPENOLHBOM = Allocator.Temp)
	{
		return default(AIKGNMJNLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7E45230", Offset = "0x7E44430", VA = "0x187E45230")]
	public AIKGNMJNLMB HGKJELBIHAN(Allocator FOPENOLHBOM = Allocator.Temp)
	{
		return default(AIKGNMJNLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7E45550", Offset = "0x7E44750", VA = "0x187E45550")]
	public AIKGNMJNLMB LCJDGLANNKE(Allocator FOPENOLHBOM = Allocator.Temp)
	{
		return default(AIKGNMJNLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public DDLOAHIGJMN(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7E451A0", Offset = "0x7E443A0", VA = "0x187E451A0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(DDLOAHIGJMN FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FB60", Offset = "0x7E3ED60", VA = "0x187E3FB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct FCHFLMNLCGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int EIGAAKOPBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int JLLHAHIHDMC;
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct GCPJNNHNOAH : IEquatable<GCPJNNHNOAH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public DDLOAHIGJMN IHOEPNENKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(DDLOAHIGJMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public ACCDLGDKDDK JPOOALJFOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(ACCDLGDKDDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public IDMBGBIAMPO BCMJLHINLBA
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(IDMBGBIAMPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A8B0", Offset = "0x7E49AB0", VA = "0x187E4A8B0")]
	public bool COAMALDNBFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A740", Offset = "0x7E49940", VA = "0x187E4A740")]
	public bool APJHOPHGBDO([Out] Exception NHADLBPGDMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public GCPJNNHNOAH(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static HAONCNNABLP NEKLFDMHCNA(GCPJNNHNOAH MLCDCHNOCFI)
	{
		return default(HAONCNNABLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A950", Offset = "0x7E49B50", VA = "0x187E4A950", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(GCPJNNHNOAH FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FB60", Offset = "0x7E3ED60", VA = "0x187E3FB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct EPLJNHFJOPE : IDisposable, IEquatable<EPLJNHFJOPE>
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public static readonly EPLJNHFJOPE AIIEKMBHIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public GCPJNNHNOAH CNGNBGINFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(GCPJNNHNOAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public DDLOAHIGJMN IHOEPNENKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(DDLOAHIGJMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7E47FA0", Offset = "0x7E471A0", VA = "0x187E47FA0")]
	public void HNDGIINBMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7E47E40", Offset = "0x7E47040", VA = "0x187E47E40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public EPLJNHFJOPE(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7E47F10", Offset = "0x7E47110", VA = "0x187E47F10", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "5")]
	public bool Equals(EPLJNHFJOPE FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7E48020", Offset = "0x7E47220", VA = "0x187E48020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public readonly struct ACCDLGDKDDK : IEquatable<ACCDLGDKDDK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public bool DEFNBAFGODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x7E3FAD0", Offset = "0x7E3ECD0", VA = "0x187E3FAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	public ACCDLGDKDDK(HAONCNNABLP EANCCIKOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FAA0", Offset = "0x7E3ECA0", VA = "0x187E3FAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA00", Offset = "0x7E3EC00", VA = "0x187E3FA00", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FA90", Offset = "0x7E3EC90", VA = "0x187E3FA90", Slot = "4")]
	public bool Equals(ACCDLGDKDDK FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FB60", Offset = "0x7E3ED60", VA = "0x187E3FB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class JMHLIFCNIOJ
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private struct KMGNLBAOFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Guid DIHOLCNHIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AIMAOOOLCGN FBHMBJGEJIF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private struct AIMAOOOLCGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int MLCDCHNOCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int MJJPIMBMHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int DBMLHNFFOAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int IHLCBPLAPOB;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x7E414D0", Offset = "0x7E406D0", VA = "0x187E414D0")]
		public bool OIFNJIHODPA([Out] KOAGADGMKNF CBKIOLAOLGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x7E41570", Offset = "0x7E40770", VA = "0x187E41570")]
		public AIMAOOOLCGN(KOAGADGMKNF CBKIOLAOLGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D370", Offset = "0x7E4C570", VA = "0x187E4D370")]
	public static Guid OBMDKIJEEKL(this KOAGADGMKNF CBKIOLAOLGG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D350", Offset = "0x7E4C550", VA = "0x187E4D350")]
	public static bool CJHPIINLPHF(this Guid DIHOLCNHIND, [Out] KOAGADGMKNF CBKIOLAOLGG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal static class EBOKMJDBINE
{
	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x7E47D20", Offset = "0x7E46F20", VA = "0x187E47D20")]
	public static NBELHCIHFBE LACODNLCBFN(this HAONCNNABLP MKHHKDJKLDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x7E47CC0", Offset = "0x7E46EC0", VA = "0x187E47CC0")]
	public static JLPHHADBBLP JFEJDCOPDHM(this HAONCNNABLP MKHHKDJKLDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7E47DB0", Offset = "0x7E46FB0", VA = "0x187E47DB0")]
	public static EntityManager PAPACJKAMKM(this HAONCNNABLP MKHHKDJKLDN)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x368BFC0", Offset = "0x368B1C0", VA = "0x18368BFC0")]
	internal static bool AJBGBHKOMCI<T>(this HAONCNNABLP MKHHKDJKLDN, bool BMBINDLKLHL) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x7E47BB0", Offset = "0x7E46DB0", VA = "0x187E47BB0")]
	public static bool IJPBEHCIKMJ(this HAONCNNABLP MKHHKDJKLDN, GAPEBLBKPBD FOCHDHDPJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x368C180", Offset = "0x368B380", VA = "0x18368C180")]
	public static bool DGGHHJGJAAG<T>(this HAONCNNABLP MKHHKDJKLDN) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x3690F80", Offset = "0x3690180", VA = "0x183690F80")]
	public static bool NPOFJFCEEKA<T>(this HAONCNNABLP MKHHKDJKLDN) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x368CB80", Offset = "0x368BD80", VA = "0x18368CB80")]
	[AGILAHLGNKF]
	public static T KDDIIBNKOOL<T>(this HAONCNNABLP MKHHKDJKLDN) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x368E700", Offset = "0x368D900", VA = "0x18368E700")]
	[AGILAHLGNKF]
	public static T KDLILBOJKNE<T>(this HAONCNNABLP MKHHKDJKLDN) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x368C9A0", Offset = "0x368BBA0", VA = "0x18368C9A0")]
	public static bool DLMFINDGNIE<T>(this HAONCNNABLP MKHHKDJKLDN, [Out] T MLCDCHNOCFI) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x368BEF0", Offset = "0x368B0F0", VA = "0x18368BEF0")]
	public static T ADIGGOECLPO<T>(this HAONCNNABLP MKHHKDJKLDN) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x368CAE0", Offset = "0x368BCE0", VA = "0x18368CAE0")]
	public static T ENNKLHPPFLL<T>(this HAONCNNABLP MKHHKDJKLDN) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal static class FKEAIGLJBHK
{
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
public struct NJAOJMHOGEE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private AIKGNMJNLMB JIJCOIBMMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> PEDCLFJOAGN;

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x5B9CD70", Offset = "0x5B9BF70", VA = "0x185B9CD70")]
	public NJAOJMHOGEE(AIKGNMJNLMB JIJCOIBMMGK, NativeArray<EntityRemapUtility.EntityRemapInfo> PEDCLFJOAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x7E51A40", Offset = "0x7E50C40", VA = "0x187E51A40")]
	public LocalId PBGOAKFJNDL(LocalId DBCLNEGBNLN)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x7E51A80", Offset = "0x7E50C80", VA = "0x187E51A80")]
	public LocalId PBGOAKFJNDL(int NIBICIJAIGM)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x7E519D0", Offset = "0x7E50BD0", VA = "0x187E519D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PNBJONHJHDP
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMOPKGDMFDB(World NKENFIFGFHM, NativeParallelHashSet<FixedString64Bytes> DOHKKBEHEEE);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LPCKIHKBAAE
{
	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHOMONHANFA(HAONCNNABLP DJMGIDJHMIC, [Out] uint MKHHKDJKLDN);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GAGFMJAIEOM(HAONCNNABLP DJMGIDJHMIC, [Out] uint MKHHKDJKLDN);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CAJLCJNGCJF(HAONCNNABLP DJMGIDJHMIC, uint MKHHKDJKLDN);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HKKBEHHGGNN(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string LOEKAEBBGCL(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CGOIMEGGHGJ(HAONCNNABLP DJMGIDJHMIC, string MKHHKDJKLDN);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BCOLMCEKFDN
{
	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	Guid FLJFLJNPONA
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	Guid BEHKAOPGKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MCIALDJDJPE(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task EMDNHOJLAMK(MCDCCMBIKEN DBCLNEGBNLN);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid EIHFNCCANFF(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MFLOJDDCDMN(HAONCNNABLP EANCCIKOAFJ, Guid CANDMCKMDKL);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LJALGCAMGEC(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task PMPKBIAGMKF(HAONCNNABLP NCMJKLKGNMA, HAONCNNABLP NJHDJGHEICO);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FMJGCPFMGBF(HAONCNNABLP EANCCIKOAFJ, KOAGADGMKNF DJEKJFPAALG);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JKGBGKJJGCG
{
	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	Guid FLJFLJNPONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INNLGONFILO(NativeList<Guid> IKNNDGHBKNK, NativeList<Guid> MHMHBMFIPGB, NativeList<FixedString64Bytes> HAPBDAIDBLK);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AHDNFKOIIEI
{
	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AIKGNMJNLMB JMOOKCBEPIB(Allocator FOPENOLHBOM);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AIKGNMJNLMB ELODJNOLGFM(Allocator FOPENOLHBOM);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NABGEJDMDEA(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GNIHFNMANMI(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AHHACALOFKJ(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MNCNFFMCKIG(HAONCNNABLP DJMGIDJHMIC, int NAJOEFDLOFP);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HAONCNNABLP LNMAJLPIJFI(HAONCNNABLP PLEHFOHAMAD);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KEOGBLGCBLP(AIKGNMJNLMB LPJENNAHOBI, bool HDGMAGBFKJD);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ACAAPMDHLAF(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JBOJEAOPLBN(HAONCNNABLP DJMGIDJHMIC, bool COHOKFFKMIG);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int MFONCOIAGFH();

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PHOGHENAPOB(HAONCNNABLP EANCCIKOAFJ);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PIDMLFLMPKJ
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<HAONCNNABLP, HAONCNNABLP> BGMOHNNMMCJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<HAONCNNABLP, HAONCNNABLP> AAEICLNMKFN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<HAONCNNABLP, HAONCNNABLP, HAONCNNABLP> PEJMMDOADAC;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<HAONCNNABLP> CFIPBJDHHGF;

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JDMHPFKLFIM(HAONCNNABLP EANCCIKOAFJ, HAONCNNABLP BLOOPCJEKIK);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HAONCNNABLP EBEKLPPHPLH(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AIKGNMJNLMB KPLKIFMOHPB(HAONCNNABLP EANCCIKOAFJ, Allocator FOPENOLHBOM);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HAONCNNABLP DKHOOGPBIOB(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BNILOBFAKDC(HAONCNNABLP EANCCIKOAFJ, Vector3 CIJJBMEMMJD, Quaternion JDNLHFOOAEK);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PHDPKILMLJF(HAONCNNABLP EANCCIKOAFJ, float AHAJKIHFAHH);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool ELALJMAPNOA(HAONCNNABLP EANCCIKOAFJ, [Out] HAONCNNABLP NJHDJGHEICO);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool AIIDPMJGIFD(HAONCNNABLP EANCCIKOAFJ, [Out] RigidTransform GLJCFCKODOB);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 KGMGIPEJBOH(COEIAFAJCOK KKKHMJMHPKI);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion FCLDNLMDKBN(COEIAFAJCOK KKKHMJMHPKI);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class MKFOLPCBOLI
{
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DOCMNJKMPKG
{
	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	object CGLDIHNGOJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KKMLKFCMDOP
{
	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPOFHJHMJDE(HAONCNNABLP DBCLNEGBNLN, MLGJPNMDKJP DLGFIMAKDIN);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJPNGDGHJOM(MLGJPNMDKJP DLGFIMAKDIN);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JBGIPPABCIJ(HAONCNNABLP EANCCIKOAFJ, [Out] MLGJPNMDKJP KGBDKPKCFKL);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[Flags]
public enum EDKFPPLICCC
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	IncludeSelf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	IncludeChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	IncludeDescendants = 6,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	IncludeMask = 7,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Disembodied = 8,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Embodied = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	IgnoreEmbodiment = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	EmbodimentMask = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Runtime = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Authored = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	AuthoredAndRuntime = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	HierarchyMask = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	HintInputsAreDisjoint = 0x80
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public readonly struct EILLBLFLPBC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly string DGIAFBEDPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly T FAGKKFIFNNI;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x4536C30", Offset = "0x4535E30", VA = "0x184536C30")]
	public EILLBLFLPBC(T FAGKKFIFNNI, [Optional][CallerMemberName] string DGIAFBEDPNJ)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly EILLBLFLPBC<int> LFPFEJBKPAJ;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly EILLBLFLPBC<int> PHBKANJJKEM;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly EILLBLFLPBC<int> PHMGCNGCPHK;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public enum BMLHPEKPJKC
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class IAEBILFMCJB
{
	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x12527F0", Offset = "0x12519F0", VA = "0x1812527F0")]
	public static bool ALEFJCLKJOM(this BMLHPEKPJKC HPAPEOOKLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x1645BC0", Offset = "0x1644DC0", VA = "0x181645BC0")]
	public static bool LFFOLEABBMJ(this BMLHPEKPJKC HPAPEOOKLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x2E12190", Offset = "0x2E11390", VA = "0x182E12190")]
	public static bool JBPCLHKGMFG(this BMLHPEKPJKC HPAPEOOKLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x12527E0", Offset = "0x12519E0", VA = "0x1812527E0")]
	public static bool LHHBICPEDFE(this BMLHPEKPJKC HPAPEOOKLIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CGLILNKPNAK
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public enum PLAGPOGNBHI
	{
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum IIFMNEOKPND
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	PLAGPOGNBHI FCHHLJJDGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	bool LMKHNMJPPEO
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	bool OANBOBBNJPI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	IIFMNEOKPND OFDBPIIMODC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ServiceLifetime(Lifetime.Application)]
public interface NDMONOMACHB
{
	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	BMLHPEKPJKC JHDFMCBPNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	BMLHPEKPJKC GIAPJGILOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	BMLHPEKPJKC PDEAAFDOFIP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	BMLHPEKPJKC MAHOJFGCJHM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	BMLHPEKPJKC DFEBEHHEGDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	BMLHPEKPJKC LAPKHONEONH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	BMLHPEKPJKC NJGBNOLKHPK
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	BMLHPEKPJKC AJEFAJDOHEH
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	BMLHPEKPJKC BIBPLHCKLFE
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	BMLHPEKPJKC NPLNECFAOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	BMLHPEKPJKC JECEAOFEPDA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	BMLHPEKPJKC NCKLKHLOBMK
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	BMLHPEKPJKC GMEKPFHHHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	BMLHPEKPJKC HPJEKMCHAEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	BMLHPEKPJKC LEHJPCDAPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	BMLHPEKPJKC AABGOAGPLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	BMLHPEKPJKC PKPIGILMAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	BMLHPEKPJKC ICCFHGIOMGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	BMLHPEKPJKC KKPOKLDPALO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HKFPFFCEPKK(EILLBLFLPBC<int> EPCCHCFNMNH);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FNKGGFNAPJH
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event KDPIBFMNECC.EMJADIAPOIH CNEBMKIGOKP;

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HAONCNNABLP LABNBCMENJH(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AIKGNMJNLMB JNPEBCEHMAI(Allocator FOPENOLHBOM);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ABGKFFJDPAB NABELFFLAHG(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NDPEGLNDFMH(IEnumerable<HAONCNNABLP> JHEDIFOAAKM);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ABGKFFJDPAB BLGLEEMKOIL(HAONCNNABLP NJHDJGHEICO, HAONCNNABLP JIJCOIBMMGK, bool PPAAFAAAJBI, HAONCNNABLP PJNHLGGHCLG);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HAONCNNABLP DICAHIEPFHK(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GDFLKEKMOMJ(HAONCNNABLP EANCCIKOAFJ, HAONCNNABLP NJHDJGHEICO, bool NLMDKHPIEPA = false);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PHMCFNFELAI(HAONCNNABLP EANCCIKOAFJ, HAONCNNABLP NJHDJGHEICO);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NKBDBFOPMHD(HAONCNNABLP GEPKLAOFBFK, HAONCNNABLP DIOJHCPNJMP);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	AIKGNMJNLMB MMEMLJHJJLK(HAONCNNABLP CFNHEFEFHMG);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BJPIOIDNACC(HAONCNNABLP EANCCIKOAFJ, HAONCNNABLP OKNEALEDFMI);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AIKGNMJNLMB MNFCIIAANMF(AIKGNMJNLMB MALJMAFIKPF, EDKFPPLICCC MJJLCGKEEJD, Allocator FOPENOLHBOM);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool DGOGMDJPJJL(HAONCNNABLP EANCCIKOAFJ, HAONCNNABLP GBGHCIFKFNP);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HAONCNNABLP CFBOACFDDOA(HAONCNNABLP PJNHLGGHCLG, HAONCNNABLP NFOEKINLJAG);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool DBLHHNKGLAF(HAONCNNABLP PJNHLGGHCLG, HAONCNNABLP NFOEKINLJAG, [Out] HAONCNNABLP AHCOAEKFNCJ);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	HAONCNNABLP IGKALHLDFMB(HAONCNNABLP[] LPJENNAHOBI);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	HAONCNNABLP HHEOAPNCADH(HAONCNNABLP EANCCIKOAFJ, uint GCGGFAHMFAL);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class JGNGBOGHKGA
{
	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D050", Offset = "0x7E4C250", VA = "0x187E4D050")]
	public static bool MFLKPIINKAB(this FNKGGFNAPJH PGJKOLBGJKD, HAONCNNABLP EANCCIKOAFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D0C0", Offset = "0x7E4C2C0", VA = "0x187E4D0C0")]
	public static AIKGNMJNLMB MNFCIIAANMF(this FNKGGFNAPJH JJHEMKLPAME, HAONCNNABLP EANCCIKOAFJ, EDKFPPLICCC MJJLCGKEEJD, Allocator FOPENOLHBOM)
	{
		return default(AIKGNMJNLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CDB0", Offset = "0x7E4BFB0", VA = "0x187E4CDB0")]
	public static AIKGNMJNLMB BFHACMJPBDL(this FNKGGFNAPJH JJHEMKLPAME, HAONCNNABLP EANCCIKOAFJ, Allocator FOPENOLHBOM)
	{
		return default(AIKGNMJNLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D010", Offset = "0x7E4C210", VA = "0x187E4D010")]
	public static AIKGNMJNLMB LADOBBCFMKD(this FNKGGFNAPJH JJHEMKLPAME, HAONCNNABLP EANCCIKOAFJ, Allocator FOPENOLHBOM)
	{
		return default(AIKGNMJNLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CE30", Offset = "0x7E4C030", VA = "0x187E4CE30")]
	public static AIKGNMJNLMB HMLCEPEIJMA(this FNKGGFNAPJH JJHEMKLPAME, HAONCNNABLP EANCCIKOAFJ, Allocator FOPENOLHBOM)
	{
		return default(AIKGNMJNLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CDF0", Offset = "0x7E4BFF0", VA = "0x187E4CDF0")]
	public static AIKGNMJNLMB FIMALBFBGPI(this FNKGGFNAPJH JJHEMKLPAME, HAONCNNABLP EANCCIKOAFJ, Allocator FOPENOLHBOM)
	{
		return default(AIKGNMJNLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CE70", Offset = "0x7E4C070", VA = "0x187E4CE70")]
	public static AIKGNMJNLMB IIKNEPBHAOK(this FNKGGFNAPJH JJHEMKLPAME, HAONCNNABLP EANCCIKOAFJ, Allocator FOPENOLHBOM)
	{
		return default(AIKGNMJNLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CEB0", Offset = "0x7E4C0B0", VA = "0x187E4CEB0")]
	public static AIKGNMJNLMB JKIEECHJEJI(this FNKGGFNAPJH JJHEMKLPAME, HAONCNNABLP EANCCIKOAFJ, Allocator FOPENOLHBOM)
	{
		return default(AIKGNMJNLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CEF0", Offset = "0x7E4C0F0", VA = "0x187E4CEF0")]
	public static AIKGNMJNLMB JKIEECHJEJI(this FNKGGFNAPJH JJHEMKLPAME, AIKGNMJNLMB EANCCIKOAFJ, Allocator FOPENOLHBOM)
	{
		return default(AIKGNMJNLMB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LFIPNAPDLLE
{
	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OOJGIMJMHJA KENDNHCKDGL(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPFFNGFAHBG(HAONCNNABLP DJMGIDJHMIC, OOJGIMJMHJA GFFKKBAEGNJ);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EOKGACOCBAA(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LJGCMGBAIMH(HAONCNNABLP DJMGIDJHMIC, bool MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IAJOLCEBCCF<string> MIMILBOMOHI(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LAJFGLNEEDI(HAONCNNABLP DJMGIDJHMIC, IAJOLCEBCCF<string> BLGKPGNAIBK);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IAJOLCEBCCF<string> MGONEFCJEFD(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BJAPFLLDAKI(HAONCNNABLP DJMGIDJHMIC, IAJOLCEBCCF<string> BLGKPGNAIBK);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IAJOLCEBCCF<string> LFKBMFOAOGF(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KGMACDIMJKB(HAONCNNABLP DJMGIDJHMIC, IAJOLCEBCCF<string> BLGKPGNAIBK);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IAJOLCEBCCF<string> MOGHAMINGLL(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BLPIEMMAKFK(HAONCNNABLP DJMGIDJHMIC, IAJOLCEBCCF<string> BLGKPGNAIBK);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OCDEAPFNPOP(HAONCNNABLP DJMGIDJHMIC, HAONCNNABLP PNBFNEJFAPC);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ALCLNKJHOHL
{
	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x7E415B0", Offset = "0x7E407B0", VA = "0x187E415B0", Slot = "0")]
	Task<GCPJNNHNOAH> BIADNGJOAAP(HLDHGKEJCGP OJNIAPMBILN, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "1")]
	void MPMNIFODGGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface MJNIFJDKDCD
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event KDPIBFMNECC.EMJADIAPOIH CNEBMKIGOKP;

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HAONCNNABLP DICAHIEPFHK(HAONCNNABLP NCMJKLKGNMA);

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<HAONCNNABLP> ELDAJLCAPDC();

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<HAONCNNABLP> LMMJEHCCHMF(HAONCNNABLP NJHDJGHEICO);

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MFMMPEMIMPP(HAONCNNABLP EBILICPMMPM, HAONCNNABLP OLLMIJIPNMC, [Out] ABGKFFJDPAB FEGMMOBANPC);

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NANPALBNENK(HAONCNNABLP EBILICPMMPM, HAONCNNABLP DNDDLBBAOEB, [Out] ABGKFFJDPAB FEGMMOBANPC);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DCPIPFDCPLI(HAONCNNABLP EBILICPMMPM);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PHMCFNFELAI(HAONCNNABLP NBLCBFFBFCN, HAONCNNABLP LMLNPPNKKKE);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ABGKFFJDPAB NOMPBBPLFMP(HAONCNNABLP EANCCIKOAFJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PBNJILOJLGI
{
	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	bool LCMCEJNOMKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	bool MPPGOMBCGNN
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	bool FLJLFMKFLLF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BDGLBPBJNIC
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ODFMKELGHCJ
{
	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEPFBNEFBCG(HAONCNNABLP EANCCIKOAFJ, GAPEBLBKPBD FOCHDHDPJJM);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HCMJBMMIPOJ(HAONCNNABLP EANCCIKOAFJ, GAPEBLBKPBD FOCHDHDPJJM);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BFBCLLLEEEA
{
	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BOBCDBIDKKL([In] float3 CGNCLEEPDED, [In] float3 ACBMNMFGAEN, float BMKHJPOEOBG, [Out] LAAEKLDKMBE LPGLFKPBBMP, [Out] HAONCNNABLP KGNMGMAIJAA);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int FGOKFMLEFOO([In] float3 CGNCLEEPDED, float IHBIKJPLAHJ, List<HAONCNNABLP> LPJENNAHOBI);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int CHOAELBLLBJ(Plane[] AHBBMBNFADC, float3 CGNCLEEPDED, float3 MPHPEKFLJCC, quaternion PANMBKPFLFA, List<HAONCNNABLP> LPJENNAHOBI);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FDFEJGHGMIN
{
	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BOBCDBIDKKL([In] NativeArray<Entity> EEOGDGCIFOA, [In] float3 CGNCLEEPDED, [In] float3 ACBMNMFGAEN, [In] NativeArray<LAAEKLDKMBE> GJHCOIBKFNO);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> FGOKFMLEFOO([In] NativeArray<Entity> EEOGDGCIFOA, [In] float3 CGNCLEEPDED, float IHBIKJPLAHJ);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> CHOAELBLLBJ([In] NativeArray<Entity> EEOGDGCIFOA, [In] NativeArray<float4> ECOFGPEEIPN);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct FLPPHILBFOD : AKEBFDHKPEH, IEquatable<FLPPHILBFOD>
{
	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public int PMLOAHGMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public int EAJOLKMOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x2E1D960", Offset = "0x2E1CB60", VA = "0x182E1D960", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6EB12E0", Offset = "0x6EB04E0", VA = "0x186EB12E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A320", Offset = "0x7E49520", VA = "0x187E4A320", Slot = "8")]
	public bool Equals(FLPPHILBFOD FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A370", Offset = "0x7E49570", VA = "0x187E4A370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct LAAEKLDKMBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public float NHDJKIJDIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public float3 PLEIILPBIGD;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ICHOKNNCOIO
{
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IPHDOCEGNCL
{
	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	DCLKAHOFBPL ODNNMAKBNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<AIKGNMJNLMB, NativeArray<RRObjectPrefabData>> AEDLNNHEAHA;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<AIKGNMJNLMB> EGLFLAGHJDL;

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AIKGNMJNLMB EDFGBKGKCCJ();

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IANOFDJKDKE CEIMCNAOJGH(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "8")]
	RRObjectPrefabData EFDPKPINFIC(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LBMKMAEFCBL(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MCDCCMBIKEN PKPBBKKDJAC(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MNNFAAIACOJ(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HAABJPGGNMD(HAONCNNABLP EANCCIKOAFJ, [Out] Transform PMPOHKBNMIB);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HAONCNNABLP FJHOHMBGJFB(KOAGADGMKNF CBKIOLAOLGG);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool CELHANMJGKL(KOAGADGMKNF CBKIOLAOLGG, [Out] HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	KOAGADGMKNF GHBDNKNBKHN(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	AIKGNMJNLMB FJHOHMBGJFB(NativeArray<KOAGADGMKNF> CBKIOLAOLGG, Allocator FOPENOLHBOM, bool KOJDLBINFGJ = true);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MGELCFDLIOK(RRObjectPrefabData ONDECPHMAJI, NativeArray<Entity> EEOGDGCIFOA);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool JGPIMEDHNEL(NativeArray<OIAPHONGFCP> GAFFABFGOJL, NativeArray<KOAGADGMKNF> PIMHHIFLMFL, NativeArray<Entity> LFOLLLDGAGB);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "19")]
	MCDCCMBIKEN IFNNBMKAFMD();

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "20")]
	MCDCCMBIKEN NILPOCCEHJD(RRObjectPrefabData ONDECPHMAJI);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "21")]
	DGIHMJLOBAF MHEMBLMHBKH();

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "22")]
	AGHJBFIKNCN LJMCKMLEKAC();

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "23")]
	NLNPCLAIEGP JJCPABHANKH(JNBMIBPKCDD LOLFPMOAMFK);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DAGPLOILBNE(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool OHACINNOJLG(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "26")]
	AIKGNMJNLMB KOICLLGIMEO(AIKGNMJNLMB AHPPACEPBLK, Allocator FOPENOLHBOM);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool BFOGLOCPFFB(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool CABBLHCHKNO(HAONCNNABLP EANCCIKOAFJ, ComponentTypes KFBEOOBOHFF);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "29")]
	HAONCNNABLP DFGBIFGNFGG(Transform PMPOHKBNMIB);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class OIBCLFGNOKD
{
	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x7E540F0", Offset = "0x7E532F0", VA = "0x187E540F0")]
	internal static HAONCNNABLP OJCKHJLNKEI(this Entity LBPCFJCJDPM, IPHDOCEGNCL PKCEHJLPOJN)
	{
		return default(HAONCNNABLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x7E540E0", Offset = "0x7E532E0", VA = "0x187E540E0")]
	public static MCDCCMBIKEN IBLBKDLHDBE(this IPHDOCEGNCL PKCEHJLPOJN, LocalId EANCCIKOAFJ)
	{
		return default(MCDCCMBIKEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x7E53E20", Offset = "0x7E53020", VA = "0x187E53E20")]
	public static HAONCNNABLP FJHOHMBGJFB(this IPHDOCEGNCL PKCEHJLPOJN, LocalId EANCCIKOAFJ)
	{
		return default(HAONCNNABLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x7E53ED0", Offset = "0x7E530D0", VA = "0x187E53ED0")]
	public static KOAGADGMKNF GHBDNKNBKHN(this IPHDOCEGNCL PKCEHJLPOJN, LocalId EANCCIKOAFJ)
	{
		return default(KOAGADGMKNF);
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x7E541A0", Offset = "0x7E533A0", VA = "0x187E541A0")]
	public static DGIHMJLOBAF PLBDFPHJMKP(this IPHDOCEGNCL PKCEHJLPOJN, RigidTransform PLCNEOBDJKP)
	{
		return default(DGIHMJLOBAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x7E53C70", Offset = "0x7E52E70", VA = "0x187E53C70")]
	public static NLNPCLAIEGP EPBGLDBIHJF(this IPHDOCEGNCL PKCEHJLPOJN, JNBMIBPKCDD LNIKCCNMGEI, RigidTransform PLCNEOBDJKP)
	{
		return default(NLNPCLAIEGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x7E53F40", Offset = "0x7E53140", VA = "0x187E53F40")]
	public static AGHJBFIKNCN IAHIPMOJJAE(this IPHDOCEGNCL PKCEHJLPOJN, RigidTransform PLCNEOBDJKP)
	{
		return default(AGHJBFIKNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x7E53C40", Offset = "0x7E52E40", VA = "0x187E53C40")]
	private static void DJNJFNMPHHG(MCDCCMBIKEN CFHOHKBAAHD, RigidTransform PLCNEOBDJKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal interface KGOHCDHPLDG
{
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ENIPDEEILMA
{
	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	bool HBEEPHIFKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	HAONCNNABLP PHNJPHHIHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	MCDCCMBIKEN LFMPNKOJIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event KFELFALBLGB MPDJFGHIIOI;

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HAONCNNABLP CFBOACFDDOA(HAONCNNABLP PJNHLGGHCLG, HAONCNNABLP NFOEKINLJAG);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DBLHHNKGLAF(HAONCNNABLP PJNHLGGHCLG, HAONCNNABLP NFOEKINLJAG, [Out] HAONCNNABLP AHCOAEKFNCJ);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BLLCMFEPPDG();

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HPFKPGCMIKO();

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EADJFNDONMI(HAONCNNABLP PJNHLGGHCLG);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PMDHLGIAKJA(HAONCNNABLP PJNHLGGHCLG);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public delegate void KFELFALBLGB(MCDCCMBIKEN HFGIMAJNKKH, MCDCCMBIKEN LJMBLJJLJAJ);
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class JPLEIELFAHP
{
	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D6D0", Offset = "0x7E4C8D0", VA = "0x187E4D6D0")]
	public static bool JPPPIMNFJCD(this ENIPDEEILMA EALFDDLKEFJ, MCDCCMBIKEN PJNHLGGHCLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D5F0", Offset = "0x7E4C7F0", VA = "0x187E4D5F0")]
	public static bool ABNEFKLNNPD(this ENIPDEEILMA EALFDDLKEFJ, HAONCNNABLP PJNHLGGHCLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D720", Offset = "0x7E4C920", VA = "0x187E4D720")]
	public static bool LDFBEPDFGAB(this ENIPDEEILMA EALFDDLKEFJ, HAONCNNABLP PJNHLGGHCLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BAGCDPFCCMH
{
	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPDPKIKJNCG(NativeList<RRObjectPrefabData> OHAKLFDFBNO);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IELKIFCINDB
{
	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EBECCFCLKAJ(MCDCCMBIKEN CFHOHKBAAHD, FKJDPJEKDDH HFFFCKALIAN, List<MCDCCMBIKEN> HEBIEBIPLCB);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int GEBIOEFKKNE(MCDCCMBIKEN CFHOHKBAAHD, FKJDPJEKDDH HFFFCKALIAN);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MEAIJGJFDLA(MCDCCMBIKEN CFHOHKBAAHD, List<MCDCCMBIKEN> HEBIEBIPLCB);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IOLJJNDBKMM(MCDCCMBIKEN FNEFIOJLPDJ, MCDCCMBIKEN PJNHLGGHCLG, FKJDPJEKDDH HFFFCKALIAN);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MCDCCMBIKEN CNFKPCNDFFG(MCDCCMBIKEN FNEFIOJLPDJ, int NIBICIJAIGM, FKJDPJEKDDH HFFFCKALIAN);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LHGCFELHPPO(MCDCCMBIKEN FNEFIOJLPDJ, MCDCCMBIKEN PJNHLGGHCLG, FKJDPJEKDDH HFFFCKALIAN);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MHHDHLJNJJE(MCDCCMBIKEN FNEFIOJLPDJ, MCDCCMBIKEN PJNHLGGHCLG, FKJDPJEKDDH HFFFCKALIAN);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CLBFAPGBFKP(MCDCCMBIKEN FNEFIOJLPDJ, FKJDPJEKDDH HFFFCKALIAN);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CCNFBKLAINF(MCDCCMBIKEN FNEFIOJLPDJ, MCDCCMBIKEN PJNHLGGHCLG, FKJDPJEKDDH HFFFCKALIAN);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MNIBEJFPPMK(Entity FNEFIOJLPDJ, Entity PJNHLGGHCLG, FKJDPJEKDDH HFFFCKALIAN);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MLEGNICFGME(Entity FNEFIOJLPDJ, FKJDPJEKDDH HFFFCKALIAN);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GJFGCCAOLKF(MCDCCMBIKEN PJNHLGGHCLG, FKJDPJEKDDH HFFFCKALIAN);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LPIPCGBGMEO
{
	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	IDMBGBIAMPO OFDPFBAKOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MAEKCOICONB LMPBAIAGEFD(IDMBGBIAMPO IIPJDMFDDBF);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDMBGBIAMPO BIPCAFMGHGE();

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDMBGBIAMPO BEEJJIGILPJ();
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PLFNIKFIIFO
{
	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OOJOJCFKLBB(HAONCNNABLP PJNHLGGHCLG, HAONCNNABLP GHOFKCGBING);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CBHHLMLDDLK(HAONCNNABLP PJNHLGGHCLG, HAONCNNABLP CFPOLEILGCO);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GBENNAMHIEO(HAONCNNABLP PJNHLGGHCLG, [Out] HAONCNNABLP MDCNMNCCEKH);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JCICKCLCDBP
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKDBCDJMBDO(HAONCNNABLP CFNHEFEFHMG, bool MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBBFKCHFMEK(HAONCNNABLP CFNHEFEFHMG, bool MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HAFDDJOMELJ(HAONCNNABLP CFNHEFEFHMG, int MLCDCHNOCFI);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BFLPCLDCIGL
{
	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<HAONCNNABLP> GBMEBGAKKPD(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HAONCNNABLP CNFKAJHPDLE(HAONCNNABLP EANCCIKOAFJ, int NIBICIJAIGM);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int OFPNBICIMMI(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BKHKOHIOKMA LPGNHJIAMHG(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PFEPDIHNNPH(HAONCNNABLP EANCCIKOAFJ, BKHKOHIOKMA MGEECOGALOB);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HAONCNNABLP JHAHCMFAIPD(HAONCNNABLP EANCCIKOAFJ, [Optional] float3? BJHAAAPCKLC, [Optional] quaternion? PANMBKPFLFA, [Optional] float3? MMIJFAFPOOH);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HAONCNNABLP HHNCOHGFCHA(HAONCNNABLP EANCCIKOAFJ, int NIBICIJAIGM, [Optional] float3? BJHAAAPCKLC, [Optional] quaternion? PANMBKPFLFA, [Optional] float3? MMIJFAFPOOH);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KBDDHCPKELE(HAONCNNABLP EANCCIKOAFJ, int NIBICIJAIGM);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DEDLFIELPPN(HAONCNNABLP EANCCIKOAFJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DBNMPJJFCEO
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HGMOGKNNBOP
{
	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	bool EJMGCNKBFDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNDOACENCHN();

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GCHGPHNCDEJ();

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IBFGOIFGJJI();

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JENFCCHMPFD();

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IPEBLOBOFDJ();

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IGGBMECJFEK();

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IEBLOIOFBLC();

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BIJJKEHHCHG();

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HFKIAPAAPEG();

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JFLBAIALMHO();

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CMIPODFMFJI();

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IDLAFIFFPDO();
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FIBGICHKMPL
{
	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BHJBEALJBJH(HAONCNNABLP PJNHLGGHCLG, [Out] int FNEFIOJLPDJ);

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFDILLLCIMG(HAONCNNABLP PJNHLGGHCLG, int FNEFIOJLPDJ);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNHKCPHDNOL(HAONCNNABLP PJNHLGGHCLG, bool ICNBMDJMNJO);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IDDEIHEECMN(HAONCNNABLP PJNHLGGHCLG, float DMABBCGNHGC, float LOIAGAJJPON, float FIHLNFOMPGF);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CLFGHCCLKGD(HAONCNNABLP EANCCIKOAFJ, [Out] float LOIAGAJJPON, [Out] float FIHLNFOMPGF);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JHFBEBMKJGM(HAONCNNABLP PJNHLGGHCLG, float3 BJHAAAPCKLC, quaternion PANMBKPFLFA);

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KFFGCNBDHEB(HAONCNNABLP PJNHLGGHCLG, [Out] float3 BJHAAAPCKLC, [Out] quaternion PANMBKPFLFA);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LAGCKNAJKHK(HAONCNNABLP PJNHLGGHCLG);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EDLCJCKFFCD
{
	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOLFNNOFNKI(Entity LBPCFJCJDPM, [In] float3 MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 DPNPPPGEKCP(Entity LBPCFJCJDPM);

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ELBPMEEKCJA(Entity LBPCFJCJDPM, [In] quaternion MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion BFKALBCHPOA(Entity LBPCFJCJDPM);

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AKBJMPBIAGH(Entity LBPCFJCJDPM, [In] float3 BJHAAAPCKLC, [In] quaternion PANMBKPFLFA);

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MPOBJFMHGJC(Entity LBPCFJCJDPM, [Out] RigidTransform IHLJEKHPGID);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OELKIMBICFL(Entity LBPCFJCJDPM, [In] float3 BJHAAAPCKLC, [In] quaternion PANMBKPFLFA);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NPOBAGFBAHN(Entity LBPCFJCJDPM, [Out] float3 BJHAAAPCKLC, [Out] quaternion PANMBKPFLFA);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NPOBAGFBAHN(Entity LBPCFJCJDPM, [Out] RigidTransform IHLJEKHPGID);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JFNEPGLPBJM(Entity LBPCFJCJDPM, float MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float POMLBILHOIN(Entity LBPCFJCJDPM);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JANKIMLILKM(Entity LBPCFJCJDPM, [In] float3 MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 LBLBEMOBNEM(Entity LBPCFJCJDPM);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LBAGNPMOCDL(Entity LBPCFJCJDPM, [In] quaternion MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion BEJEMMMCDJD(Entity LBPCFJCJDPM);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KBLDLGLCBAM(Entity LBPCFJCJDPM, float MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float FOALKNPLADL(Entity LBPCFJCJDPM);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HOAIJFNCMHL(Entity LBPCFJCJDPM, [Out] float4x4 HBIIBPNLLIO);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MPHMEANBMLI(Entity LBPCFJCJDPM, [In] float4x4 HBIIBPNLLIO);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IELKONGJJPO(Entity LBPCFJCJDPM);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PBBEIIIHEEG(Entity LBPCFJCJDPM, Entity MABBFKJJEHJ, Entity LMLNPPNKKKE);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class PGGPHJEMFNC
{
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AKKDLPHNMAC
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGPHLDDIBIB(bool MNPKGGBNMNL);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NKOKPFJMIDP
{
	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGBNBGBHJPF(HAONCNNABLP DJMGIDJHMIC, IAJOLCEBCCF<string> BLGKPGNAIBK);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCCCHFJBHOL(HAONCNNABLP DJMGIDJHMIC, IAJOLCEBCCF<string> BLGKPGNAIBK);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GOFCKMBCCMF(HAONCNNABLP DJMGIDJHMIC, IAJOLCEBCCF<string> BLGKPGNAIBK);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CKNBLMLMNEF(HAONCNNABLP DJMGIDJHMIC, IAJOLCEBCCF<string> BLGKPGNAIBK);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NJEEDNFHPCA(HAONCNNABLP DJMGIDJHMIC, IAJOLCEBCCF<string> BLGKPGNAIBK);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NEAOPMMEGBP(HAONCNNABLP DJMGIDJHMIC, IAJOLCEBCCF<string> BLGKPGNAIBK);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JLBBMOBDLLH(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int CIILCKAPOKC(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int BCIJJMJGNMJ(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GBAADKKOBIK<string> KEKJCIJDDKL(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OBKJNAPGAGJ(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GBAADKKOBIK<string> AIAEOAMGELD(HAONCNNABLP DJMGIDJHMIC);

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DGOJAEKADCI(HAONCNNABLP DJMGIDJHMIC, string LHAEPBBBCAO);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AHDBNBDJOFF(string LHAEPBBBCAO, BDBEEIMNNKF LHMKLIGJOLD);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HAONCNNABLP BAEFHEKAAHH(string LHAEPBBBCAO);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NHHKFAOEDDB(string LHAEPBBBCAO, BDBEEIMNNKF LHMKLIGJOLD);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IDOBANKADHF(HAONCNNABLP ICALHEDDBED, string LHAEPBBBCAO, BDBEEIMNNKF LHMKLIGJOLD);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class KEFHAKMNJOI
{
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EPNLJJINFPI
{
	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World OCJHFMHFGEK(string HPGFNCHJLAN = "Main");

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World NGLBCFLEMDB(string HPGFNCHJLAN = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World EIHHBFHAKBL(string HPGFNCHJLAN = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World AJPCGBCIMOL(string HPGFNCHJLAN = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JLPHHADBBLP
{
	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	World EMGBCKKIBCO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	World OBCJKELFHDF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	EntityManager PAPACJKAMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	bool DBBHGEKFDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase OPJIHEKIJDA(Type EDLOHJEBKFM);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class KNICILPCBJN
{
	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D9B0", Offset = "0x7E4CBB0", VA = "0x187E4D9B0")]
	public static ComponentSystemBase GONENLMDEAL(this World NKENFIFGFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x38B6620", Offset = "0x38B5820", VA = "0x1838B6620")]
	public static T OPJIHEKIJDA<T>(this JLPHHADBBLP PFFKEGLOHLJ) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GNGGAIGEKCM
{
	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANNFPFONFNI(NativeListAsync<Entity> FFMMBIKEIFF);

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CENDHHAPHJK(CCGJHCPIDHJ MCIMPOJFBMP);

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOJPOILOIIE(NativeListAsync<Entity> EBGLOLGMGFF, bool KMGMJINOHKD);

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EGEHBPJPGMK();

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NAKMLBKNAPL(Entity FHPKLENNKKO);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IDLEEBIKHJP
{
	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FDHLDFMDGGJ(Collider NKJGEEFAAOO, [Out] LHGJHLHCDPK BEHMNCKEKMO);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AOMPMOACLJO
{
	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider OFJMFIIKGHD(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject ELEGHIIIHHI(HAONCNNABLP PNIOJJJACJH, GameObject IGJKKFNOEMM, Vector3 KGEICFIBDCA, Quaternion JLBNIDPEHNC);

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OILDLFLDKOJ(GameObject NKJGEEFAAOO);

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider HCCKILLNOEJ<TCollider>(GameObject HMBCFBGNMDH) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JDLEMPBMALI(Collider NKJGEEFAAOO);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject BNDIPBAMLPD<TCollider>(string DGIAFBEDPNJ) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KOGNBGJPJEL MGAMFNOEJPK(HAONCNNABLP LHAHFKMBNCK, HAONCNNABLP HAANNKEDLJC, JNBMIBPKCDD PNNKHDNLGGN, float3 PEOFBELHFJF, quaternion MAOEGLILAND, float3 MCNGNFFDHIC);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PCDKDJJCNOF(HAONCNNABLP EANCCIKOAFJ, [Out] KOGNBGJPJEL NKJGEEFAAOO);

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FEKOIDPHFAP(HAONCNNABLP EANCCIKOAFJ, [Out] HAONCNNABLP FHPKLENNKKO);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public enum ANNANPCDEDC
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GAEEGNJKMLI
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public struct DPBPLFBNHBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public int PNNKHDNLGGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public GameObject IGJKKFNOEMM;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHALDHKGNHA(HAONCNNABLP EANCCIKOAFJ, LFONANDBLOB MCDLKLADFCH, bool PCAEMEDKHBE, PFDCBFKJOFO EGIIJJIACFJ);

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFNIPEGPLAF(HAONCNNABLP EANCCIKOAFJ, LFONANDBLOB MCDLKLADFCH, bool PCAEMEDKHBE, bool PEJKIBJODBL, bool MFDHBBOGOGI);

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OCAJMGFGBPK HNKBAFKJLCP(HAONCNNABLP FHPKLENNKKO, List<HAONCNNABLP> INOHFCMDDPB);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KOGNBGJPJEL HOFEAEKELLC(GameObject NDHJPENHLLF, GameObject AILLDPFOPAI);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GBEAJMCOCFE(GameObject NDHJPENHLLF, List<GameObject> EJDKFAGHIEE);

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JHFMGMNJFHG(GameObject AILLDPFOPAI);

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T HCCKILLNOEJ<T>(GameObject HMBCFBGNMDH) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JDLEMPBMALI(Collider NKJGEEFAAOO);

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject ENEAENIDAIH<T>(string DGIAFBEDPNJ) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CHCIHDFECPE(Collider NKJGEEFAAOO, [Out] HAONCNNABLP FNEFIOJLPDJ);

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OEICHBLJDMI(HAONCNNABLP EANCCIKOAFJ, [Out] LHGJHLHCDPK BEHMNCKEKMO);

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<ANNANPCDEDC> ENGOHOFCDIF(Allocator FOPENOLHBOM = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] FHOHNOJDOOA();
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KFEOCCCEEKL
{
	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPBOLFEOHNB(HAONCNNABLP EANCCIKOAFJ, HAONCNNABLP MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADPCOKHPOPN(HAONCNNABLP EANCCIKOAFJ, HAONCNNABLP MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int LNDNOOHAIAE(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HAONCNNABLP LFDADDKHJDM(HAONCNNABLP EANCCIKOAFJ, int NIBICIJAIGM);

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AIKGNMJNLMB HECBCLELPJA(HAONCNNABLP EANCCIKOAFJ, Allocator FOPENOLHBOM = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NGIBEFHFDBP(HAONCNNABLP EANCCIKOAFJ, object PPOILDCNBFL, HAONCNNABLP MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ICLHAHMJIED(HAONCNNABLP EANCCIKOAFJ, object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ABLOHMNPALB(HAONCNNABLP EANCCIKOAFJ, [Out] HAONCNNABLP MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KAPOAGCGFGO(HAONCNNABLP EANCCIKOAFJ, float3 MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool LPBNLDBHKCC(HAONCNNABLP EANCCIKOAFJ, [Out] float3 MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ANMNPJOJODH(HAONCNNABLP EANCCIKOAFJ, float3 MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IGEANEEHGKP(HAONCNNABLP EANCCIKOAFJ, [Out] float3 MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EOALGBDDDKB(HAONCNNABLP EANCCIKOAFJ, (Quaternion rot, Vector3 moments) LCCOOECAKAD);

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool JLOKDCCGHOJ(HAONCNNABLP EANCCIKOAFJ, [Out] quaternion GKAAOLAMBLP, [Out] float3 JNNIMNDPGNF);

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IIEEEBCBMKG(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 FAAAAOCLDLN(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 NEECFLNOKDM(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LPIKPOGPNKO(HAONCNNABLP EANCCIKOAFJ, float3 MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ACAEJBJAEFA(HAONCNNABLP EANCCIKOAFJ, float3 MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float KNIDFFABCBC(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float OMOANNKMKJO(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GHMOIBHMFPF(HAONCNNABLP EANCCIKOAFJ, float MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PMMHBIAOPEC(HAONCNNABLP EANCCIKOAFJ, float MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode OODCKOLIDAI(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FGOPNKEKLHH(HAONCNNABLP EANCCIKOAFJ, CollisionDetectionMode MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "25")]
	PKLBDOAGHDH GPHGLKMKHNI(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DEMCEEAJNJE(HAONCNNABLP EANCCIKOAFJ, PKLBDOAGHDH MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool HGKJIPNJHFG(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BDNJGGBMAOE(HAONCNNABLP EANCCIKOAFJ, bool MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "29")]
	HAONCNNABLP LABNBCMENJH(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void APBPCDAAEGH(HAONCNNABLP EANCCIKOAFJ, HAONCNNABLP MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "31")]
	HAONCNNABLP DICAHIEPFHK(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void GDFLKEKMOMJ(HAONCNNABLP EANCCIKOAFJ, HAONCNNABLP MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "33")]
	IAGAFLNEHEJ GIFNNDOGBNG(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void NMEPCCDOGHI(HAONCNNABLP EANCCIKOAFJ, IAGAFLNEHEJ IFBOOMJGNNP);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool KJDMHFDNNKB(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void GCGMADDANOM(HAONCNNABLP EANCCIKOAFJ, bool MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool MEJMEFEPLFC(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void IMGDHJKFMFK(HAONCNNABLP EANCCIKOAFJ, bool MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints JCNHFEGBAFD(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void FNPOFBKOKDF(HAONCNNABLP EANCCIKOAFJ, RigidbodyConstraints MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float KAAGKGMEIHH(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void FDJDNAICIOO(HAONCNNABLP EANCCIKOAFJ, float MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float PCNPMLJCLNO(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void EMNMALNMFHA(HAONCNNABLP EANCCIKOAFJ, float MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool AAFIONELPLD(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void MDPNILBPONM(HAONCNNABLP EANCCIKOAFJ, bool MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool IMNDCKBOOGO(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void MKJGINJIHID(HAONCNNABLP EANCCIKOAFJ, bool MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void BNKLBNKNMAG(HAONCNNABLP EANCCIKOAFJ, int MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "50")]
	LNPGGOONBDB MOCOPNOEJLG(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void FHAEMABIJHB(HAONCNNABLP EANCCIKOAFJ, LNPGGOONBDB MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "52")]
	MFLENIHFHJN IIDKGHLLPII(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void MDABEMDKDEH(HAONCNNABLP EANCCIKOAFJ, MFLENIHFHJN MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float ONDNBCBJGLI(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void OGEPEKCOFGG(HAONCNNABLP EANCCIKOAFJ, float MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void PAOKDNOBJDI(HAONCNNABLP EANCCIKOAFJ, object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void BOOBMFCJEAB(HAONCNNABLP EANCCIKOAFJ, object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool BEODCPHPPNF(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void AEABPJNIDCM(HAONCNNABLP EANCCIKOAFJ, object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void IDAJABHLAEB(HAONCNNABLP EANCCIKOAFJ, object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool EFPLLPNLMGJ(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool BIOCBJPJLDO(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody NJMIMBNHOBE(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void EKMAKPPMHIA(HAONCNNABLP EANCCIKOAFJ, Rigidbody CIIHNEDACOI);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void CKDMJAENEOD(HAONCNNABLP EANCCIKOAFJ, object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void IEGFLKADKBI(HAONCNNABLP EANCCIKOAFJ, object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool GAGGEHBEHFB(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void FPKFJNBKIGC(HAONCNNABLP EANCCIKOAFJ, float3 JONPFBFHNDO);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void MGCECNHPEPK(HAONCNNABLP EANCCIKOAFJ, float3 HNMBFFBJHEC);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool HLCKCEKNMHJ(HAONCNNABLP EANCCIKOAFJ, [Out] float3 JONPFBFHNDO);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool FFGALHGBJCK(HAONCNNABLP EANCCIKOAFJ, [Out] float3 HNMBFFBJHEC);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool IOIGNCIKONB(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void DKBIPCOBAKO(HAONCNNABLP EANCCIKOAFJ, object PPOILDCNBFL, bool BJEEFLICPDC);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void GCEEKJHJIJL(HAONCNNABLP EANCCIKOAFJ, bool NPJBMOHLBMM);

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void LIFAIJNMEGD(HAONCNNABLP EANCCIKOAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool EJDHDGNCMAE(HAONCNNABLP EANCCIKOAFJ);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NGOHFLGOCHK
{
	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGADOGCIPLN(Entity LFHCMLPBONH);

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKGDGECDKJH(Entity LFHCMLPBONH);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IMNKJCAMPFM(Entity LFHCMLPBONH);
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CEDEDEJDLFE
{
	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGNAAHKFEDA(HAONCNNABLP PJNHLGGHCLG, bool PGKHDCKJOFG);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public delegate void PHJMAJBNCPG(OIDKPNHBNFJ FPAGFDGKOOL);
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public readonly ref struct OIDKPNHBNFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly AIKGNMJNLMB OHPDKPICNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly NativeArray<byte> KAFBMBFLMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly NativeArray<byte> EHCPKNNAGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly GAPEBLBKPBD FOCHDHDPJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly int HOEGHLBFNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Type OPILNKGFJOB;

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public AIKGNMJNLMB AGHNGIECFPH
	{
		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x50A8010", Offset = "0x50A7210", VA = "0x1850A8010")]
		get
		{
			return default(AIKGNMJNLMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public int LNJBLGDGPME
	{
		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x7E54370", Offset = "0x7E53570", VA = "0x187E54370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public GAPEBLBKPBD ODIKCIDEBDA
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7B0", Offset = "0xA0D9B0", VA = "0x180A0E7B0")]
		get
		{
			return default(GAPEBLBKPBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x7E54390", Offset = "0x7E53590", VA = "0x187E54390")]
	public OIDKPNHBNFJ(AIKGNMJNLMB OHPDKPICNDD, NativeArray<byte> KAFBMBFLMAN, NativeArray<byte> EHCPKNNAGCC, GAPEBLBKPBD FOCHDHDPJJM, int HOEGHLBFNGN, Type OPILNKGFJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x39EEB90", Offset = "0x39EDD90", VA = "0x1839EEB90")]
	public NativeArray<T> DPLHHKCHPCA<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x39EECC0", Offset = "0x39EDEC0", VA = "0x1839EECC0")]
	public NativeArray<T> MCBDOJDPHMC<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x39EEBD0", Offset = "0x39EDDD0", VA = "0x1839EEBD0")]
	public (AIKGNMJNLMB, NativeArray<T>, NativeArray<T>) HKFPFFCEPKK<T>() where T : struct
	{
		return default((AIKGNMJNLMB, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x7E54340", Offset = "0x7E53540", VA = "0x187E54340")]
	public FAHPOPFMPNL HJEAPBPIBCN()
	{
		return default(FAHPOPFMPNL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public interface GPDFEFPDHFG
{
	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	string MMMAFPDAHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	GPDFEFPDHFG OFHCLMPIINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	IEnumerable<GPDFEFPDHFG> EKAEIIABOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EJNJNIEMIEB
{
	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	GPDFEFPDHFG NCCEHEILJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	NativeArray<GAPEBLBKPBD> HNPCAONDDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MFLLAOADCLF(GAPEBLBKPBD FOCHDHDPJJM, [Out] GPDFEFPDHFG DHOGCHOHKLD);

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OOCHIMKFMHO(GAPEBLBKPBD FOCHDHDPJJM, PHJMAJBNCPG FFODIBOCBGL);

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDBNGFDLKBA(GAPEBLBKPBD FOCHDHDPJJM, PHJMAJBNCPG FFODIBOCBGL);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IGMEFNNMFGP
{
	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOCHIMKFMHO(GAPEBLBKPBD FOCHDHDPJJM, PHJMAJBNCPG FFODIBOCBGL);

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDBNGFDLKBA(GAPEBLBKPBD FOCHDHDPJJM, PHJMAJBNCPG FFODIBOCBGL);
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public static class DMANLDNBKCA
{
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NBONEOJHMCC
{
	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	bool KJHMFGJNKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	GACFDFKFPBM NDLIFCAHNAO
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GOHAJMKALFL(MAEKCOICONB CBKIOLAOLGG, bool LOAEFKFOEFN);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DPKNPHLHAOP(KOAGADGMKNF CBKIOLAOLGG, GAPEBLBKPBD FOCHDHDPJJM);

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MKNCCIJHMCI(NativeArray<KOAGADGMKNF> JFDLKKAEBPC);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public static class NFLKODABNOB
{
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public readonly ref struct FAHPOPFMPNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly OIDKPNHBNFJ DHAOEHNLNON;

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	public AIKGNMJNLMB AGHNGIECFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x50A8010", Offset = "0x50A7210", VA = "0x1850A8010")]
		get
		{
			return default(AIKGNMJNLMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x7E48660", Offset = "0x7E47860", VA = "0x187E48660")]
	public FAHPOPFMPNL(OIDKPNHBNFJ DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x7E48110", Offset = "0x7E47310", VA = "0x187E48110")]
	public AIKGNMJNLMB DPLHHKCHPCA()
	{
		return default(AIKGNMJNLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x7E48530", Offset = "0x7E47730", VA = "0x187E48530")]
	public AIKGNMJNLMB MCBDOJDPHMC()
	{
		return default(AIKGNMJNLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x7E48240", Offset = "0x7E47440", VA = "0x187E48240")]
	public (AIKGNMJNLMB, AIKGNMJNLMB, AIKGNMJNLMB) HKFPFFCEPKK()
	{
		return default((AIKGNMJNLMB, AIKGNMJNLMB, AIKGNMJNLMB));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public static class OHOPCLPODNG
{
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public readonly struct GACFDFKFPBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly NativeBitArray HPJAEEEKEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly NativeParallelHashMap<KOAGADGMKNF, int> PJFIKHGGJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly NativeParallelHashSet<MAEKCOICONB> PNKGHKNMMGC;

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public bool AGLHBBLJBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A720", Offset = "0x7E49920", VA = "0x187E4A720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public bool KJHMFGJNKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A500", Offset = "0x7E49700", VA = "0x187E4A500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x5C178A0", Offset = "0x5C16AA0", VA = "0x185C178A0")]
	public GACFDFKFPBM(NativeBitArray HPJAEEEKEOM, NativeParallelHashMap<KOAGADGMKNF, int> PJFIKHGGJHP, NativeParallelHashSet<MAEKCOICONB> PNKGHKNMMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A530", Offset = "0x7E49730", VA = "0x187E4A530")]
	public bool DPKNPHLHAOP(KOAGADGMKNF CBKIOLAOLGG, GAPEBLBKPBD FOCHDHDPJJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GILDGMCIDNJ
{
	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	LIGLMNBGNIO HMKMHDCAGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BHFLIOCIKLJ
{
	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEGGLIPOLKA(HAONCNNABLP EANCCIKOAFJ, JJCDHLJFLKO MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HEJBBJOONEM IMKKLNAJJJA();
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HIBHLLPIMIB
{
	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MICDPFELEAJ(World NKENFIFGFHM);

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFMIAKLMJJC(World NKENFIFGFHM);

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase IICBFLHAGFJ(World NKENFIFGFHM);

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DAIDFJHCNGE(World NKENFIFGFHM);

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GBJOIKBNBPF(World NKENFIFGFHM);

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LJGCNPKKGLH(World NKENFIFGFHM);

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KLIELDMEKOK(World NKENFIFGFHM);

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> EIAOFBIAPHJ();
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HKOFEHOPJPF
{
	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNHOGCOHIGB(HAONCNNABLP CFNHEFEFHMG, bool MLCDCHNOCFI);
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public readonly struct PJLLKOAHBMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly IEnumerable<CAGGKCFLCAM> AMEPKMJHNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly IReadOnlyList<GameObject> BHIBIIHGCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly IReadOnlyList<int> KNOPOJFMKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly IReadOnlyList<(KOAGADGMKNF, KOAGADGMKNF)> CPLDIAPCCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int LAGNLFFNPCP;
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct BNILCNOAGKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public InventionIdData MKHHKDJKLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public InventionInstanceIdData MBAJEJAKHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool JAFKJNNIBGL;

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x7E431D0", Offset = "0x7E423D0", VA = "0x187E431D0")]
	public BNILCNOAGKA(long MKHHKDJKLDN, Guid MBAJEJAKHJA, bool JAFKJNNIBGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[ServiceLifetime(Lifetime.Application)]
public interface CFGPAIKLPJK
{
	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GCPJNNHNOAH ODFNMBBBIMI(HLDHGKEJCGP MLCJOCEBLKH, int LNLLKDAKDBF = 0, bool JDDABABHDMA = false);

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EPLJNHFJOPE KIDHIAEEPFF(HLDHGKEJCGP MLCJOCEBLKH, HAONCNNABLP NJHDJGHEICO, [In] UniformTRS CLOFOIDMHNA, AFLPOFHFKFD CKLPHNHHHPP, [Optional] BNILCNOAGKA JAOENEKKNNJ, bool FGDFFJAAAPK = true, bool OLOMPNNHGGN = false, bool JDDABABHDMA = false);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DNDELDLEELO MEPFEFOOBEO();

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DNDELDLEELO OILCMLDGPEO(AIKGNMJNLMB LPJENNAHOBI, [In] UniformTRS HLLJJCBFIKK, [Optional] AFLPOFHFKFD JLABBBGMCCM);

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool COAMALDNBFC(HAONCNNABLP NEBMGFNGHFF);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool APJHOPHGBDO(HAONCNNABLP NEBMGFNGHFF, [Out] Exception NNDKGEOCFFD);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<KOAGADGMKNF> NAOKIHEFFII(HAONCNNABLP NEBMGFNGHFF, Allocator FOPENOLHBOM);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<KOAGADGMKNF> KHNLHENJJPE(HAONCNNABLP NEBMGFNGHFF, Allocator FOPENOLHBOM);

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AIKGNMJNLMB COGMMMPNCCJ(HAONCNNABLP NEBMGFNGHFF, Allocator FOPENOLHBOM);

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AIKGNMJNLMB HGKJELBIHAN(HAONCNNABLP NEBMGFNGHFF, Allocator FOPENOLHBOM);

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AIKGNMJNLMB DHHAOPAAHMN(HAONCNNABLP NEBMGFNGHFF, Allocator FOPENOLHBOM);

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> KCEJDHNDCBF(HAONCNNABLP NEBMGFNGHFF, Allocator FOPENOLHBOM);

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JCLDBOJGBHK(HAONCNNABLP NEBMGFNGHFF);

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int FBNCKNGEGOM(HAONCNNABLP NEBMGFNGHFF, int KIFHGDECLNI);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[ServiceLifetime(Lifetime.Application)]
public interface LPLCOIFICKC
{
	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0xDF2FF0", Offset = "0xDF21F0", VA = "0x180DF2FF0", Slot = "0")]
	bool ONGMIMEBEHB(object ELJMGFIBFCP, GCJJOOFPNCM CJAIDCAJGHP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class HIAMBKOMKJG
{
	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x7E4BA20", Offset = "0x7E4AC20", VA = "0x187E4BA20")]
	public static bool ONGMIMEBEHB(this LPLCOIFICKC JJHEMKLPAME, object ELJMGFIBFCP, [Out] GCJJOOFPNCM CJAIDCAJGHP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public enum OOHCNNKEIHA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	MaxPlayers = byte.MaxValue,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	IsVisible = 254,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	IsOpen = 253,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	PlayerCount = 252,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Removed = 251,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	PropsListedInLobby = 250,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	CleanupCacheOnLeave = 249,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	MasterClientId = 248,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	ExpectedUsers = 247,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	PlayerTtl = 246,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	EmptyRoomTtl = 245,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	HasDedicatedMaster = 87
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public interface GCJJOOFPNCM
{
	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	MGLHALCMAGB AFGCMPJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	MMNMPKDPAGK APNPGHGIJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	bool KOJAGNDKKAN
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	bool HMLNHOJBPDF
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object MGBIBOOCPJO();

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0xF75B40", Offset = "0xF74D40", VA = "0x180F75B40", Slot = "5")]
	(MMNMPKDPAGK, Dictionary<object, object>) ONPIEDFBJMG()
	{
		return default((MMNMPKDPAGK, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "6")]
	(KOAGADGMKNF, MMNMPKDPAGK) MNAPHDNAFMN()
	{
		return default((KOAGADGMKNF, MMNMPKDPAGK));
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "7")]
	IDLBAPNLABP<(KOAGADGMKNF, MMNMPKDPAGK)> EGFGKEIILIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0xF75B40", Offset = "0xF74D40", VA = "0x180F75B40", Slot = "8")]
	(NLELEHKBKFK, byte[]) IKBGJFJGHBC()
	{
		return default((NLELEHKBKFK, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0xF75B40", Offset = "0xF74D40", VA = "0x180F75B40", Slot = "9")]
	(MNHOIBJNOFD, byte[]) HCEDHCGJCKB()
	{
		return default((MNHOIBJNOFD, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0xF75B40", Offset = "0xF74D40", VA = "0x180F75B40", Slot = "10")]
	T PMCPABMNFGK<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class BDHMCKELIHG
{
	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x7E42740", Offset = "0x7E41940", VA = "0x187E42740")]
	public static bool MBPKOLFGBGP(this GCJJOOFPNCM IMPAKIFFNDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface DMJKJIBJPGD : IDLBAPNLABP<LKKBBGCNCDA>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[DefaultMember("Item")]
public interface IDLBAPNLABP<T>
{
	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	T JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	int LNJBLGDGPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public enum MGLHALCMAGB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	BulkInstantiate = 1,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	BulkDestroy = 2,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	OMSendPacket = 4,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	RR_OutOfBandMessage = 5,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	RR_FastForwardMarker = 6,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	RR_SelfJoinMarker = 7,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	RR_DebugOp = 10,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	RR_CachedEvent = 11,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	RRRoomRequestEvent = 20,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	RRRoomRequestFailedResponseEvent = 21,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	RRBufferedRoomEvent = 22,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	RRClearBufferedRoomEvent = 23,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	RR_CreationOp = 24,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	RR_CreationOpResponse = 25,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	RR_CreationOp_Unchecked = 26,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	RR_MasterLockBlockComplete = 27,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	RR_NetworkSynchronization = 28,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RR_NetworkInstantiate = 29,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RR_BulkInstantiate = 31,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	RR_Destroy = 32,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	RR_BulkDestroy = 33,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	RR_TransferOwnership = 34,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	RR_OwnershipUpdate = 35,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RR_RPC = 36,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	RPC = 200,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	SendSerialize = 201,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	Instantiation = 202,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	CloseConnection = 203,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	Destroy = 204,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	RemoveCachedRPCs = 205,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	SendSerializeReliable = 206,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	DestroyPlayer = 207,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	OwnershipRequest = 209,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	OwnershipTransfer = 210,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	VacantViewIds = 211,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	OwnershipUpdate = 212,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	AuthEvent = 223,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	LobbyStats = 224,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	AppStats = 226,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Match = 227,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	QueueState = 228,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	GameListUpdate = 229,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	GameList = 230,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	CacheSliceChanged = 250,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	ErrorInfo = 251,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	PropertiesChanged = 253,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	Leave = 254,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	Join = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public enum NLELEHKBKFK : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	None = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	NetworkTransformInitializationData = 1314146628u,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	RestoreCreationData = 1380140064u,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	OldestCachedPacketId = 1329811529u,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	SnapshotPublished = 1397773634u,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	SnapshotPayload = 1397771332u,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	SnapshotClear = 1129337683u
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public static class PJKEMPPGGJO
{
	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x7E55700", Offset = "0x7E54900", VA = "0x187E55700")]
	public static KOAGADGMKNF OLNGNEGLAJB(this NIAGBFEGOLJ DHAOEHNLNON)
	{
		return default(KOAGADGMKNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x7E551F0", Offset = "0x7E543F0", VA = "0x187E551F0")]
	public static KOAGADGMKNF JCHEFPBDELC([In] this NIAGBFEGOLJ DHAOEHNLNON)
	{
		return default(KOAGADGMKNF);
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x7DCFB90", Offset = "0x7DCED90", VA = "0x187DCFB90")]
	public static KOAGADGMKNF NJPMOOHGEKO(this NIAGBFEGOLJ DHAOEHNLNON)
	{
		return default(KOAGADGMKNF);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x7DCFB90", Offset = "0x7DCED90", VA = "0x187DCFB90")]
	public static ViewId DBNFNNGKLJI(this NIAGBFEGOLJ DHAOEHNLNON)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x7E552D0", Offset = "0x7E544D0", VA = "0x187E552D0")]
	public static FixedString64Bytes KNACEDMJJOC(this MAEKCOICONB MKHHKDJKLDN)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x7E55480", Offset = "0x7E54680", VA = "0x187E55480")]
	public static FixedString64Bytes NCDHAJLGKPI(this KOAGADGMKNF MKHHKDJKLDN)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x7E55240", Offset = "0x7E54440", VA = "0x187E55240")]
	public static FixedString32Bytes KNACEDMJJOC(this Entity LBPCFJCJDPM)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OLCBKEKEFIM : DGDACOEFOEH
{
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public enum MDAOMALHMEA
{
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	End,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BALMBNJMKBF
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<object> PNKHOOOHLJK;

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "2")]
	void DBPJELGEAJL(object ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "3")]
	void PCKKDEOLOHO(MNHOIBJNOFD LJMBANNFBIJ, ReadOnlySpan<byte> MGEJNDCFBJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	void MBJHKNCGLEA(NLELEHKBKFK EDLOHJEBKFM, ReadOnlySpan<byte> MGEJNDCFBJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EIAFAHFIKIP
{
	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MNHOIBJNOFD OOGLFJIGFND(ReadOnlySpan<byte> MGEJNDCFBJA);
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OCMHDHDOLBF
{
	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKHHLKHCCDB(MNHOIBJNOFD AGBHGDFILGO, ReadOnlySpan<byte> MGEJNDCFBJA);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ONKNOGMEPMP(ReadOnlySpan<MNHOIBJNOFD> BFODAAHBHNP);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public struct EPDBGHMCOOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public MNHOIBJNOFD LJMBANNFBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public ReadOnlyMemory<byte> MGEJNDCFBJA;
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public struct MNHOIBJNOFD
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static MNHOIBJNOFD EFMFHCMGPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public MAEKCOICONB NHJLLPIJPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public int IBLJEJNJPMH;

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	public static MAEKCOICONB PGHCMCCJHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x7E50B60", Offset = "0x7E4FD60", VA = "0x187E50B60")]
		get
		{
			return default(MAEKCOICONB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x50A78B0", Offset = "0x50A6AB0", VA = "0x1850A78B0")]
	public MNHOIBJNOFD(MAEKCOICONB NHJLLPIJPJG, int IBLJEJNJPMH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x7E50BB0", Offset = "0x7E4FDB0", VA = "0x187E50BB0")]
	public static bool NDBPPCEOMJH([In] MNHOIBJNOFD OGNDHFPFEOJ, [In] MNHOIBJNOFD ABBPAGLDFGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x7E50A00", Offset = "0x7E4FC00", VA = "0x187E50A00", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x7E50B00", Offset = "0x7E4FD00", VA = "0x187E50B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x7E50C40", Offset = "0x7E4FE40", VA = "0x187E50C40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x7E509F0", Offset = "0x7E4FBF0", VA = "0x187E509F0")]
	public void EFFIMEDBJAK([Out] MAEKCOICONB IHOGKNBNKOF, [Out] int IBLJEJNJPMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class IIBJOIJIIIF
{
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public struct CAGGKCFLCAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public Guid DIHOLCNHIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public string PGFEGIPOLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public Vector3 BJHAAAPCKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public Quaternion PANMBKPFLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public Vector3 MMIJFAFPOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public int GPBHJCHOEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public NPBKHGDHPBE MGEECOGALOB;

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x7E43220", Offset = "0x7E42420", VA = "0x187E43220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public enum JMLKFJLNDDE
{
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public static class LMBNEKFDMAL
{
	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x7E4E8D0", Offset = "0x7E4DAD0", VA = "0x187E4E8D0")]
	public static bool PNJOHMCCIFC(this JMLKFJLNDDE EDLOHJEBKFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x7E4E8B0", Offset = "0x7E4DAB0", VA = "0x187E4E8B0")]
	public static bool AGGOEEJBENH(this JMLKFJLNDDE EDLOHJEBKFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x7E4E8C0", Offset = "0x7E4DAC0", VA = "0x187E4E8C0")]
	public static bool LCIOBHMLKAM(this JMLKFJLNDDE EDLOHJEBKFM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[Flags]
public enum AILKHKLHDFO
{
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public interface AFLPOFHFKFD
{
	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJCDHICPGGF([In] Guid JIJCOIBMMGK, [Out] Guid PDBEAHFDFJA);
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[Flags]
public enum AFDJBGPKIBE
{
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public interface DNDELDLEELO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	BGGAMNCDPNK FFIKJNABJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString AAJPHJACHHN();
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public enum KFELKMDLLBM
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct LEGPEGJPBOH : ISystemStateComponentData, IComponentData, IEquatable<LEGPEGJPBOH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public float3 OGKOLPMBODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public float3 DJNFLJNLICJ;

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x7E4E600", Offset = "0x7E4D800", VA = "0x187E4E600", Slot = "4")]
	public bool Equals(LEGPEGJPBOH FNJGMJGALLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KDFBKEKJLMM
{
	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DBAGBNJMKEG(long HIBFKPNKEPG);

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCFIOGGPKLA(NativeParallelHashSet<long> MHNKIHJFHCP);

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMOONDLKHMM(World NKENFIFGFHM, NativeParallelHashMap<Guid, long> PMKGOMFOLBD);

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FJHNCCDFAFJ(KOAGADGMKNF CBKIOLAOLGG);

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JKBOHOLKFEK(KOAGADGMKNF CBKIOLAOLGG, [Out] Guid OFLMHNJBFLI, [Out] long HIBFKPNKEPG);

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ADBAKEIFNOD(KOAGADGMKNF CBKIOLAOLGG, Guid OFLMHNJBFLI, long HIBFKPNKEPG);

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ABIIOFFKJFK(Guid OFLMHNJBFLI);

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OEIOFBDKGKP(Guid OFLMHNJBFLI, [Out] int LLEKHBFEPND, [Out] int MOLANAACBAO);

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EENJAANDOCO(Guid OFLMHNJBFLI, int LLEKHBFEPND, int MOLANAACBAO);

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KOHJNECGPPD(Guid OFLMHNJBFLI);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public class HKJKGJGAGLN
{
	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HKJKGJGAGLN()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
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
