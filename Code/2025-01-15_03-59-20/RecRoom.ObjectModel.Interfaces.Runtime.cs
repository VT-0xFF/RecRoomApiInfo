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
	public class LogRegistrationIndex : IMPGLFODBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7154140", Offset = "0x7153540", VA = "0x187154140", Slot = "4")]
		public override void EMOBGIHOLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AFLAHPALBGC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x71434A0", Offset = "0x71428A0", VA = "0x1871434A0")]
	public static void CBAMNPLNKIC(this Rigidbody MFFABEIIKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7143620", Offset = "0x7142A20", VA = "0x187143620")]
	public static void CBAMNPLNKIC(this Rigidbody MFFABEIIKCC, Vector3 PGEJILJPGLH, Quaternion EGPIJFFLEJF, Vector3 DELOBDALGAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct DFMAFHIFHME : IReadOnlyList<AOMADBOBEAJ>, IEnumerable<AOMADBOBEAJ>, IEnumerable, IReadOnlyCollection<AOMADBOBEAJ>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct EBEAIBHPIMN : IEnumerator<AOMADBOBEAJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly ENHHHCAGNII LBFGHBIKLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator LGHHOJKALAL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AOMADBOBEAJ DLFFLJHEEDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x714ABF0", Offset = "0x7149FF0", VA = "0x18714ABF0", Slot = "4")]
			get
			{
				return default(AOMADBOBEAJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x714AB70", Offset = "0x7149F70", VA = "0x18714AB70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x47A7C70", Offset = "0x47A7070", VA = "0x1847A7C70")]
		public EBEAIBHPIMN(ENHHHCAGNII LBFGHBIKLLL, NativeArray<LocalId>.Enumerator LGHHOJKALAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x714AAB0", Offset = "0x7149EB0", VA = "0x18714AAB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x714AAF0", Offset = "0x7149EF0", VA = "0x18714AAF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x714AB30", Offset = "0x7149F30", VA = "0x18714AB30", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ENHHHCAGNII LBFGHBIKLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> LGIFMBNGOEI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AOMADBOBEAJ EEEHKFENLEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x71496B0", Offset = "0x7148AB0", VA = "0x1871496B0", Slot = "4")]
		get
		{
			return default(AOMADBOBEAJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x71490B0", Offset = "0x71484B0", VA = "0x1871490B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int CBHCCOLMJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C45A0", VA = "0x1808C51A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EPMKILCCCOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C45A0", VA = "0x1808C51A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MALNNEJEPGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7149030", Offset = "0x7148430", VA = "0x187149030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> MECIBONCDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x29330E0", Offset = "0x29324E0", VA = "0x1829330E0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> JOOPNNEGLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7149240", Offset = "0x7148640", VA = "0x187149240")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7149500", Offset = "0x7148900", VA = "0x187149500")]
	public DFMAFHIFHME(int GNOHMAFCFKD, ENHHHCAGNII LBFGHBIKLLL, Allocator MEFLJHAPKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x47A75A0", Offset = "0x47A69A0", VA = "0x1847A75A0")]
	public DFMAFHIFHME(ENHHHCAGNII LBFGHBIKLLL, NativeArray<LocalId> LGIFMBNGOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7149640", Offset = "0x7148A40", VA = "0x187149640")]
	internal DFMAFHIFHME(ENHHHCAGNII LBFGHBIKLLL, NativeArray<Entity> NNNALCFDKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7149460", Offset = "0x7148860", VA = "0x187149460")]
	public DFMAFHIFHME(ENHHHCAGNII LBFGHBIKLLL, int OIPEPMJNPGM, Allocator MEFLJHAPKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7149590", Offset = "0x7148990", VA = "0x187149590")]
	public DFMAFHIFHME(DFMAFHIFHME LPIDPBMAHEH, Allocator MEFLJHAPKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7149190", Offset = "0x7148590", VA = "0x187149190")]
	public DFMAFHIFHME JFAPBEGNFEK(Allocator MEFLJHAPKJF = Allocator.Temp)
	{
		return default(DFMAFHIFHME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7149070", Offset = "0x7148470", VA = "0x187149070", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7149100", Offset = "0x7148500", VA = "0x187149100")]
	public EBEAIBHPIMN JDJKPBEKJIJ()
	{
		return default(EBEAIBHPIMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x71492A0", Offset = "0x71486A0", VA = "0x1871492A0", Slot = "6")]
	private IEnumerator<AOMADBOBEAJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7149380", Offset = "0x7148780", VA = "0x187149380", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct NLMIKCIECCN : IList<AOMADBOBEAJ>, ICollection<AOMADBOBEAJ>, IEnumerable<AOMADBOBEAJ>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct EKKNCNBMDJE : IEnumerator<AOMADBOBEAJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly ENHHHCAGNII LBFGHBIKLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator LGHHOJKALAL;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AOMADBOBEAJ DLFFLJHEEDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x714C1F0", Offset = "0x714B5F0", VA = "0x18714C1F0", Slot = "4")]
			get
			{
				return default(AOMADBOBEAJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x714C170", Offset = "0x714B570", VA = "0x18714C170", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x47A7C70", Offset = "0x47A7070", VA = "0x1847A7C70")]
		public EKKNCNBMDJE(ENHHHCAGNII LBFGHBIKLLL, NativeArray<LocalId>.Enumerator LGHHOJKALAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x714C0B0", Offset = "0x714B4B0", VA = "0x18714C0B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x714C0F0", Offset = "0x714B4F0", VA = "0x18714C0F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x714C130", Offset = "0x714B530", VA = "0x18714C130", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly ENHHHCAGNII LBFGHBIKLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> LGIFMBNGOEI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public AOMADBOBEAJ EEEHKFENLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7155860", Offset = "0x7154C60", VA = "0x187155860", Slot = "4")]
		get
		{
			return default(AOMADBOBEAJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71558E0", Offset = "0x7154CE0", VA = "0x1871558E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7155320", Offset = "0x7154720", VA = "0x187155320", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int EPMKILCCCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7155320", Offset = "0x7154720", VA = "0x187155320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> MECIBONCDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x29330E0", Offset = "0x29324E0", VA = "0x1829330E0")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool DNNGBKHPAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x71557D0", Offset = "0x7154BD0", VA = "0x1871557D0")]
	public NLMIKCIECCN(int GNOHMAFCFKD, ENHHHCAGNII LBFGHBIKLLL, Allocator MEFLJHAPKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7155750", Offset = "0x7154B50", VA = "0x187155750")]
	public NLMIKCIECCN(ENHHHCAGNII LBFGHBIKLLL, Allocator MEFLJHAPKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x71556C0", Offset = "0x7154AC0", VA = "0x1871556C0")]
	public NLMIKCIECCN(ENHHHCAGNII LBFGHBIKLLL, int OIPEPMJNPGM, Allocator MEFLJHAPKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7155360", Offset = "0x7154760", VA = "0x187155360")]
	public DFMAFHIFHME OGBNKFALINP()
	{
		return default(DFMAFHIFHME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7154EF0", Offset = "0x71542F0", VA = "0x187154EF0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7154F30", Offset = "0x7154330", VA = "0x187154F30", Slot = "13")]
	public bool Contains(AOMADBOBEAJ FKIFNEPLBJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7154FC0", Offset = "0x71543C0", VA = "0x187154FC0", Slot = "14")]
	public void CopyTo(AOMADBOBEAJ[] CHDCMIMONFN, int ECPOGOHOPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7154E70", Offset = "0x7154270", VA = "0x187154E70", Slot = "11")]
	public void Add(AOMADBOBEAJ FKIFNEPLBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x71551E0", Offset = "0x71545E0", VA = "0x1871551E0", Slot = "7")]
	public void Insert(int IIACLAMOIEE, AOMADBOBEAJ FKIFNEPLBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7155430", Offset = "0x7154830", VA = "0x187155430", Slot = "15")]
	public bool Remove(AOMADBOBEAJ FKIFNEPLBJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7155150", Offset = "0x7154550", VA = "0x187155150", Slot = "6")]
	public int IndexOf(AOMADBOBEAJ FKIFNEPLBJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x71553E0", Offset = "0x71547E0", VA = "0x1871553E0", Slot = "8")]
	public void RemoveAt(int IIACLAMOIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7155110", Offset = "0x7154510", VA = "0x187155110", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7155290", Offset = "0x7154690", VA = "0x187155290")]
	public EKKNCNBMDJE JDJKPBEKJIJ()
	{
		return default(EKKNCNBMDJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7155500", Offset = "0x7154900", VA = "0x187155500", Slot = "16")]
	private IEnumerator<AOMADBOBEAJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x71555E0", Offset = "0x71549E0", VA = "0x1871555E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GEJGEECELOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int ANOBKOMNDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> OHANDJDHJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AOMADBOBEAJ BNFHFDDFGON(AOMADBOBEAJ LGIFMBNGOEI);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DNIELBFKBMA : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[ServiceLifetime(Lifetime.Application)]
public interface DEOPECBGOJI : FLCDEFBCBNA, DEIPDBHMECK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool MAIEPNIBMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CLFDOLBIAIC GAGBMGFNLPB
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	KDLOJNBAIFA MMLKHGLMMCD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	DPBGOKHEOOH MNPEGNPFGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface DEIPDBHMECK
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool NPJNGPAAGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface FNLAKKOLEGO
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCHBIBFNAEL(bool HCPAOILCJCB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface CJAFBPBMGOC
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MEDALIILIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEKMMMBABMF(bool JCDOMELOGPP);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LNPHLKDMNDJ();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DCGOJFLJBAO(ByteString NEENHFHMFPH);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ELNONPEMDME();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FGLKCNHBGJJ();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PICGKMBNKIL();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AGNIIBAHOEA();

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LPPBFOGOJAM();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EKNBOCIBODI();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.Application)]
public interface BDCOBEDGNIJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	PBPBPCOFCDM GAGBMGFNLPB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	KDLOJNBAIFA MMLKHGLMMCD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	HIKOLNFHCME OABPBFKKCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	AKBDDLEDNAN CBKFKMGLOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	DEOPECBGOJI LLBAMANAILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	CJAFBPBMGOC DOCHIJOLGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	LBKPIKLOHEL DPGHFLOOKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	LHAACOMCFDP OPNFIMNJJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	INMAOKDMPLF OEMIPDLJJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	ECCHFNFNPDK NFKMCNIAKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	IDONDGIODOA APJEDPLNMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	GPAICHKOAJA EBDLADFDMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	PNAJDFKGGGF HPDDLEEGKJF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	EKPNJFGMKPA KDPJIFBNJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	GGNLJCELGHD FJCBKMKDKCF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	PHHFLHINHJH MHMIMHLKAKC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	CMJCBAIFNMJ HCHNLCPEBGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	OEHGMMFAPNP ILCMEBPIHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	GNECANFGJMN ACCOFGKANHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	BFFMIOLCGHL GLOIJDCICDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	DAACFAIFOBE DHAHCAINFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NFNOBECIPIP DKADCPLIHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	JHCENPNMHDD IOKBINNEKLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	NEJHFIGADHH PABGODKKEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	KEDIDNHDFMK BOPOEJJDOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	DDGEDIGLLLM ACKNKEKGKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GMFLKOCNIBP HFLOICNEGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	KCIMBNFCFNI OIBCNJIFNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IHDKKIEEAME AELEAEEKMPB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KJOOLLFMMEE FGCGIBMBFHG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(GBDMPGJFJCF))]
public readonly struct AOMADBOBEAJ : IComparable<AOMADBOBEAJ>, IEquatable<AOMADBOBEAJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly AOMADBOBEAJ GBDBCKKFJEP;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int FNJDOIFNIDB = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int ECFIINDHHPB = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int LJFENHDGMGH = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int FCHJMKDKOPL = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId FCHDAFNGEPF;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DEOPECBGOJI LLBAMANAILB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7143D70", Offset = "0x7143170", VA = "0x187143D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public LocalId FDAJCMDLLKO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x71437F0", Offset = "0x7142BF0", VA = "0x1871437F0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal DPBGOKHEOOH MNPEGNPFGOG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7143CE0", Offset = "0x71430E0", VA = "0x187143CE0")]
		get
		{
			return default(DPBGOKHEOOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool BEGHCPGHHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7143DD0", Offset = "0x71431D0", VA = "0x187143DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private bool IILKHLEPNEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7143C90", Offset = "0x7143090", VA = "0x187143C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7144020", Offset = "0x7143420", VA = "0x187144020")]
	public AOMADBOBEAJ(ENHHHCAGNII KNBGPPIAHDK, LocalId FCHDAFNGEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
	public OBGLMNKFCEH OIMCMBBEJMB()
	{
		return default(OBGLMNKFCEH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7143C10", Offset = "0x7143010", VA = "0x187143C10")]
	public static LocalId IDKOEJANABA(AOMADBOBEAJ AGBBLOONFNP)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7143C50", Offset = "0x7143050", VA = "0x187143C50")]
	public static Entity IDKOEJANABA(AOMADBOBEAJ AGBBLOONFNP)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7143AC0", Offset = "0x7142EC0", VA = "0x187143AC0")]
	public static bool FANHDJJNLED(AOMADBOBEAJ DDIIBBHFODJ, AOMADBOBEAJ BCCGANGEINF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7143CF0", Offset = "0x71430F0", VA = "0x187143CF0")]
	public static bool KNIDLJBALLO(AOMADBOBEAJ DDIIBBHFODJ, AOMADBOBEAJ BCCGANGEINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7143EF0", Offset = "0x71432F0", VA = "0x187143EF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7143920", Offset = "0x7142D20", VA = "0x187143920", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7143830", Offset = "0x7142C30", VA = "0x187143830", Slot = "4")]
	public int CompareTo(AOMADBOBEAJ BMKPAKCEMFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "5")]
	public bool Equals(AOMADBOBEAJ BMKPAKCEMFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CBKFKOJAHAN
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x71444E0", Offset = "0x71438E0", VA = "0x1871444E0")]
	public static OKLHMMELOIN IMJICPEEANF(this AOMADBOBEAJ NCHBKHMIMGJ)
	{
		return default(OKLHMMELOIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7144430", Offset = "0x7143830", VA = "0x187144430")]
	public static OBGLMNKFCEH FMMMGJGJKLB(this AOMADBOBEAJ NCHBKHMIMGJ)
	{
		return default(OBGLMNKFCEH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class GBDMPGJFJCF
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct DPBGOKHEOOH : IEquatable<DPBGOKHEOOH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte KADPKBIGPFN;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] BLENOGEPAEK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static ENHHHCAGNII BNFOACOLLIP;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static DEOPECBGOJI MPLJLIKCMCE;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static ENHHHCAGNII[] JIPECINCOJJ;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static DEOPECBGOJI[] ABEEJHGJJCI;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> KIFPFCLCLGJ;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DEOPECBGOJI LLBAMANAILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x714A7C0", Offset = "0x7149BC0", VA = "0x18714A7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ENHHHCAGNII LNNIGFGKIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x714A6D0", Offset = "0x7149AD0", VA = "0x18714A6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x714AA10", Offset = "0x7149E10", VA = "0x18714AA10")]
	static DPBGOKHEOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2508F90", Offset = "0x2508390", VA = "0x182508F90")]
	internal DPBGOKHEOOH(byte HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x61E0650", Offset = "0x61DFA50", VA = "0x1861E0650", Slot = "4")]
	public bool Equals(DPBGOKHEOOH BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x714A620", Offset = "0x7149A20", VA = "0x18714A620", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xB13E00", Offset = "0xB13200", VA = "0x180B13E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x714A950", Offset = "0x7149D50", VA = "0x18714A950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7149DA0", Offset = "0x71491A0", VA = "0x187149DA0")]
	private static ENHHHCAGNII BCPMJAJNFJP(byte KADPKBIGPFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x714A8A0", Offset = "0x7149CA0", VA = "0x18714A8A0")]
	private static DEOPECBGOJI MOMFPNPFAFJ(byte KADPKBIGPFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x714A1A0", Offset = "0x71495A0", VA = "0x18714A1A0")]
	private static object EAIIHBBCANJ(byte KADPKBIGPFN, object[] KLODBELJCDF, object EKFBHIJFHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x714A940", Offset = "0x7149D40", VA = "0x18714A940")]
	private static int PPOELJDGNFD(byte KADPKBIGPFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x714A6C0", Offset = "0x7149AC0", VA = "0x18714A6C0")]
	private static int GMAAEMJEINI(byte KADPKBIGPFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x714A300", Offset = "0x7149700", VA = "0x18714A300")]
	private static (int, int) EMKADEEAKDC(byte KADPKBIGPFN)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x714A7B0", Offset = "0x7149BB0", VA = "0x18714A7B0")]
	private static byte LEHAEMIGPND(int GKEHKEEIHAE, int IIACLAMOIEE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x714A380", Offset = "0x7149780", VA = "0x18714A380")]
	internal static DPBGOKHEOOH EMOBGIHOLPD(DEOPECBGOJI JEJDEADNJOE, ENHHHCAGNII FCBGOFLIGDH)
	{
		return default(DPBGOKHEOOH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7149BB0", Offset = "0x7148FB0", VA = "0x187149BB0")]
	internal static void AFELCEKEOAN(DPBGOKHEOOH KADPKBIGPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7149E40", Offset = "0x7149240", VA = "0x187149E40")]
	private static void CJOIALOGEEG(int GNOHMAFCFKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface PABEMMNOLPE
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEOGHAHNGHP();

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNHEBAFMNFN(bool NBEEENNGBLJ);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNANACEKLAG(GameObject MCCIFMIMANN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[ServiceLifetime(Lifetime.Application)]
public interface DGENPHCKHLK
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Guid HLBMNOLFAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LGIOOLGOOPL(Guid HDCHPLOFPMJ, Guid DOKBOJKBDAO, Guid IHKPDLLCMMA);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task LANKOKNBIMM(Guid HDCHPLOFPMJ, Guid[] ECPIKMGHBDF, Guid IHKPDLLCMMA);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid HOFHLFHGPFM(Guid PAAPGLCPIFD);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task DCFEBLGNDEJ(AOMADBOBEAJ ANLBPNBAHHN);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CJPHAIABEOE(Guid PAAPGLCPIFD);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NBNEHPBFGEK(OGNDGMPNNMG FACLMJNGEJE, Guid HOGKNIFLAPG);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ICOBJPPKHJM(Guid PAAPGLCPIFD, bool JCDOMELOGPP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[ServiceLifetime(Lifetime.Application)]
public interface FCELLDBBGCG
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OKNAOEPPDCB(DFMAFHIFHME LGIFMBNGOEI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[ServiceLifetime(Lifetime.Application)]
public interface MOCDDJIAHAK
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ENILNNGMBCD(GameObject LDEMNGLECFL, GameObject JGKLILJGDCA, int HMHBLOONOPO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ServiceLifetime(Lifetime.Application)]
public interface KDLOJNBAIFA
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	PABEMMNOLPE LGMFGPFLCMP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	NNFHNMIMCCL PBOHCOLLADG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	MNBKNMOKHHI HKJKCAKKNIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	CAOPDBLPGNC KHDFBKMDMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	AODKBCACCLD ONFNGFHHAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	LPMKAHFHPOA LFMMLCBGAEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	NHILPNEDHBI JGIHHEKNAIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	EAMCJMOFABJ DNIOEKNFKMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	DPBFIENMPCK OHBLMBCHAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	LENDPAHFCIN FKDNHFNMFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	NOGLBOOOKFN INCHMIHMJOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[ServiceLifetime(Lifetime.Application)]
public interface NNFHNMIMCCL
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	string KNLBHJDHHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[ServiceLifetime(Lifetime.Application)]
public interface LJHEPJMDHBB
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEDFBNHKMOD(Action OLHFOBIBHCJ, bool EIHHGLJNGMH);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AJOOMBMJCED(string LJAGHAHCFHJ);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BHKCGDDIEFD(string LJAGHAHCFHJ, int EKFBHIJFHMA);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AJFPPIJGCPK([Out] bool HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PFHJJIMKNAG([Out] bool HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MKECMAMHOIP([Out] int HCPAOILCJCB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface MNBKNMOKHHI
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	string IGJOBCNBCGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] AJLOIBCHPGI(IEnumerable<FLOPKECBBDN> NODNNPCBDHO, bool BGMEKBMIKPD);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FBACALILNKJ(GameObject MCCIFMIMANN, [Out] OKLHMMELOIN[] GNENNFCAIBN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CDCJDMEDOKL(GameObject MCCIFMIMANN, [Out] int GBHIHJEBOAI, [Out] NABGOBFPKKK FPLGHFJHKOE);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OGNDGMPNNMG DKCKBFPDGBB(FLOPKECBBDN BLIDGDGMCAP);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OGNDGMPNNMG DKCKBFPDGBB(string JIMNKEIAGEA, OKLHMMELOIN[] LLAEJMCGGGB, Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP, Vector3 BMGLFPFGJFF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OGNDGMPNNMG EJAMLHENIEA(string JIMNKEIAGEA, OKLHMMELOIN[] LLAEJMCGGGB, Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP, Vector3 BMGLFPFGJFF);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject FCHCNHAHMDN(string JIMNKEIAGEA);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BLPEECKBONE(GameObject IMPFLDHDEON, bool PBDMKBICHHC);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LOOHMLALDJB(GameObject MCCIFMIMANN, bool EBIOJOGMAEG, bool CEMLAHLHNEJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class NEDAFIJPEIA
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x71549D0", Offset = "0x7153DD0", VA = "0x1871549D0")]
	public static OGNDGMPNNMG DKCKBFPDGBB(this MNBKNMOKHHI IHMGMGMEKPB, Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP, Vector3 BMGLFPFGJFF, params OKLHMMELOIN[] GNENNFCAIBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7154B20", Offset = "0x7153F20", VA = "0x187154B20")]
	public static OGNDGMPNNMG EJAMLHENIEA(this MNBKNMOKHHI IHMGMGMEKPB, Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP, Vector3 BMGLFPFGJFF, params OKLHMMELOIN[] GNENNFCAIBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[ServiceLifetime(Lifetime.Application)]
public interface CAOPDBLPGNC
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOOEPDECLEC(bool JCDOMELOGPP);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[ServiceLifetime(Lifetime.Application)]
public interface AODKBCACCLD
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool GHAEDLJMEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool FIJHLCJHAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool AMNCMFACPDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	int OIDMBDEEKLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool BLFLPAEABLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IFKKACAMGFG(object PBJNGGAILNG);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BBMOKBJLMHE(object PBJNGGAILNG);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HNDDMIKBHKC(object MGPMAFDHMLC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HLAGECJFPFO(object MGPMAFDHMLC);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ViewId ECIAMLOLBNP(GameObject HHPGFBGKJGL);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KNKBCLJMLBI(NativeArray<ViewId> EMIOICDFPND);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ALMAGLMAFMM(NativeArray<ViewId> NJMHCDADPJA);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DPGKFMJEAEI();

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MELGHMENNNC(uint DPKEOHFGHCO, ReadOnlySpan<byte> BHFPOEIPAAB, bool FBMDHBHBLGM = false);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MELGHMENNNC(uint DPKEOHFGHCO, ReadOnlySpan<byte> BHFPOEIPAAB, ReadOnlySpan<byte> PPPHHBHJHOM, bool FBMDHBHBLGM = false);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IBAABBAFHBB(Func<int, bool, int> DEPCLPEFFFB, bool LKOAMKGOLPF);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ACOEMHKIKBI(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HGEONCEDBBM(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	uint HIKFGLPCILI(uint ILIFBFJMIFP);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class GGDABFKKNPC
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x714D520", Offset = "0x714C920", VA = "0x18714D520")]
	public static OCAJDBHJLNG NOMKOKFFLDD(this AODKBCACCLD OGOGOLFFADO, object CMNJCPJBHGE)
	{
		return default(OCAJDBHJLNG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct OCAJDBHJLNG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private AODKBCACCLD OGOGOLFFADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private object CMNJCPJBHGE;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7156340", Offset = "0x7155740", VA = "0x187156340")]
	public OCAJDBHJLNG(AODKBCACCLD OGOGOLFFADO, object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x71562F0", Offset = "0x71556F0", VA = "0x1871562F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface LPMKAHFHPOA
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGEDEACFKOD(GameObject MCCIFMIMANN);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface NHILPNEDHBI
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct BJJABOMHBAE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private NHILPNEDHBI EDKLJCCMDKO;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x71441B0", Offset = "0x71435B0", VA = "0x1871441B0")]
		public BJJABOMHBAE(NHILPNEDHBI EDKLJCCMDKO, string LNICHECHJFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7144150", Offset = "0x7143550", VA = "0x187144150", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct GJPPFNCAENG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private NHILPNEDHBI EDKLJCCMDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Task LCFJPCOMAFL;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x714E370", Offset = "0x714D770", VA = "0x18714E370", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEKPADFIIDF(string LNICHECHJFC, float BOHBFCKDKCE = 5f);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFMNLCLICNN();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JEGJCLAPNCE(bool NNHBLAAAHHI, string LNICHECHJFC);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class ABFEOOCACFE
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x71432B0", Offset = "0x71426B0", VA = "0x1871432B0")]
	public static NHILPNEDHBI.BJJABOMHBAE MBOMEEJDDKG(this NHILPNEDHBI OGOGOLFFADO, string LNICHECHJFC)
	{
		return default(NHILPNEDHBI.BJJABOMHBAE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface EKFOEFKLGJH
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int ODOLFHNGHIJ(GameObject MCCIFMIMANN);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFOPLKGGLFN(GameObject MCCIFMIMANN);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FAJAGPJNIFD(int BHDCNGMMPLN);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object HPPHJKCEALG(AOMADBOBEAJ FCHDAFNGEPF, GameObject MCCIFMIMANN, Action<AOMADBOBEAJ, int> CPIKECCHPBJ);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BGABKFLKAMP(GameObject MCCIFMIMANN, object KNDMACFFECP);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface BNHIGBHCHHA
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool ABJJPKGPIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate HKFJFNGNJNN(GKJPHGPCIDG.DFBJCPOCOBK DHKDAAACNCE, Action<GKJPHGPCIDG.DFBJCPOCOBK> CPIKECCHPBJ);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDDGHEMPAMP(GKJPHGPCIDG.DFBJCPOCOBK DHKDAAACNCE, Delegate CPIKECCHPBJ);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate KDHKMDJMKOE(GKJPHGPCIDG.DFBJCPOCOBK DHKDAAACNCE, Action<GKJPHGPCIDG.DFBJCPOCOBK> KFHBGGHPHJB);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ANKAGFEEKDA(GKJPHGPCIDG.DFBJCPOCOBK DHKDAAACNCE, Delegate CPIKECCHPBJ);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GAJIHPBLAFA(GKJPHGPCIDG.DFBJCPOCOBK DHKDAAACNCE);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GKJPHGPCIDG.DFBJCPOCOBK APBHHICHBHB(GameObject MCCIFMIMANN);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface EAMCJMOFABJ
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int NDBOMJAFHJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int AKJFBCHBHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool FIJHLCJHAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool ECNCFLMIAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OCBELFEBAII(GameObject MCCIFMIMANN);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HNJENBCKDEK([Out] Vector3 CPGMOBFHDAC);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CAJHPNJEIJD();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AOMADBOBEAJ MNDGILDGAAL(int BHDCNGMMPLN);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PACMFFPAPMK();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface DPBFIENMPCK
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool MEDALIILIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[ServiceLifetime(Lifetime.Application)]
public interface LENDPAHFCIN
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	HAMODOLAMII NPJDIOBLFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	HPHPPPLGLDK FOHEHLJGJKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECAFCAOPDHP(Transform KELFOJAPBEF);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BADDIFJEGAN(Transform KELFOJAPBEF, PHLFHEADMAE CNDIEDAKGHC);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IFIHFDHABAC(Transform KELFOJAPBEF, BLEKIMGBKEH OLOMMHLDCCH);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OLAGFNFBHJA();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OCPLEMLJOEG();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[ServiceLifetime(Lifetime.Application)]
public interface OJGCLPFAIJN
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.Application)]
public interface NOGLBOOOKFN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action OHPOKBKHMMC;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FPMKFPOEEOO(DFMAFHIFHME OLODPOOHFNB, bool NNHBLAAAHHI);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ServiceLifetime(Lifetime.Application)]
public interface HEMFNNGEAJJ
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLJMENDLOFJ();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface DENNCHAFKHG
{
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NABGOBFPKKK AFNPEMKOCGP(GameObject HHPGFBGKJGL);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGPGPIJNMAD(GameObject MCCIFMIMANN, KLFGHHFCBOI NNOELJJFGPB, MADKIBJAIEL DFPFKOKELHG);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DMLOAEMDPHK(AOMADBOBEAJ FCHDAFNGEPF, bool AFMLHPEEPEL, float3 LLIKGLKCAAB, quaternion BMDJJBIHHEA);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BJPOAKNACEO(OBGLMNKFCEH JIIJJAKJBGA, OBGLMNKFCEH MGPMAFDHMLC, AEMLLOGJEJB HBOEBNCIJMJ);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HOKJOBLJGHK(OBGLMNKFCEH JIIJJAKJBGA, AEMLLOGJEJB HBOEBNCIJMJ);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MAFIENGABOJ(DFMAFHIFHME EKDPCGIEJEL);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BLALKNDHELM(DFMAFHIFHME LBFGHBIKLLL, NativeArray<LocalPoseData> EIBNECJNHBO, NativeArray<float3> AKGFPJOONBA);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JFDKMOMLCLE(DFMAFHIFHME LBFGHBIKLLL, DFMAFHIFHME ACLMGKMDAGK);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JBONNCIHLFN(DFMAFHIFHME LBFGHBIKLLL, bool NLNPHBHNEFL);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BJNDNMPOBPG(DFMAFHIFHME LBFGHBIKLLL, bool MBAIDAAPMLP);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject DBKJMEGOIEO(Guid FBEHIPOCNLH);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GBHMNGMFPKL(OEDMJPMNCAI LMACEGOCAOG);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct DDBKPHMEEGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly MEJDCPPJFOO JJJPINFOLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly MEJDCPPJFOO LACNKIEAGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint JNHECAJIOIJ;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7148DD0", Offset = "0x71481D0", VA = "0x187148DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct OFFKBMLPIMK
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly DDBKPHMEEGJ OLHFOBIBHCJ;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x714D490", Offset = "0x714C890", VA = "0x18714D490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct GGCAJFKPAKP
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal readonly DDBKPHMEEGJ OLHFOBIBHCJ;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x714D490", Offset = "0x714C890", VA = "0x18714D490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct ABJILIOFLJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal readonly uint JNHECAJIOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal readonly bool KMIEALILCIN;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7143330", Offset = "0x7142730", VA = "0x187143330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct MEJDCPPJFOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal int LHBPAMEKCBO;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7154210", Offset = "0x7153610", VA = "0x187154210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface MPOPBOGHFKB
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	IJMKMEMKALO MPPFBCGOJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum OFNNGGPGCLC
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
public interface OGNDGMPNNMG : LPGBKEPCJMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	OFNNGGPGCLC OPCFMAILLKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool DOFECONLDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	GameObject MCCIFMIMANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<OGNDGMPNNMG> NPGPKDCLMMG;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(HIKOLNFHCME GPOOJLKEOLB, AOMADBOBEAJ ODACIIAKALC);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool DEHOJKOGGKJ);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class LHFPBCKOMFB
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7154050", Offset = "0x7153450", VA = "0x187154050")]
	public static bool HNINFNKEODO(this OGNDGMPNNMG HJELLPHACAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x71540A0", Offset = "0x71534A0", VA = "0x1871540A0")]
	public static bool IKMEEIILOEN(this OGNDGMPNNMG HJELLPHACAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x71540F0", Offset = "0x71534F0", VA = "0x1871540F0")]
	public static bool JBCBPKDAGEI(this OGNDGMPNNMG HJELLPHACAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7153FC0", Offset = "0x71533C0", VA = "0x187153FC0")]
	public static bool BEICAADJBDO(this OGNDGMPNNMG HJELLPHACAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface LPGBKEPCJMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool MAIEPNIBMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EIGPLOHFJIE
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void IHPPHEBNPGO(HKDLHOKLBNJ FNALOFOPLLL);

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event IHPPHEBNPGO LIFIMEOJLBF;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface KEPJNCNCAEK
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCJAHBIHKPG(Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP, Vector3 BMGLFPFGJFF);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KAPGKFEMBMB(AOMADBOBEAJ AMMKPAGCALK);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EPHAIIOFIPL(bool KHAPJLLCNJP);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OAFJCDMANKP(bool MBAIDAAPMLP);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface HJCLDLDAPKF
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface CNFFBLBPPPF
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(AOMADBOBEAJ HIJFMCOLEBE);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool LIHAHJFLPEJ);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GKAGEFAOHAJ(AOMADBOBEAJ ODACIIAKALC);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EHFFGEOLJLF
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(JBMMKMCLEMD FNFANMKHHGD);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface JBMMKMCLEMD
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	GameObject MCCIFMIMANN
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	Transform KELFOJAPBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	EAMPMJFIPDM FDONJIEKIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	bool FGHCJCNLNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDKBNBEDJAP(EAMPMJFIPDM HKNABNLJGOH);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface EAMPMJFIPDM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Rigidbody EFNNEKIHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	JBMMKMCLEMD PFNMMGCNFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	GameObject ILKBGMGJJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	Transform DCIPDEOFAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	EAMPMJFIPDM HOBMCFDJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	EAMPMJFIPDM FFIKGEIEAOE
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	int AEJELDFABBC
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	bool HIBADHJGNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	bool GAJIHPBLAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool JKNAGOPJNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	GKJILOLAJBC ACBBEGKAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	EFFPCFBOJKN FEMJDGKAHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float KCCMLPPMEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 JMPOGBANHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 JLENKFHPDOO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 KIAHBPMMAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 HCAJPFEACIM
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	bool HOJJKJEOJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool ADDDOEGEEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool NGNHIINCLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Vector3 EJOMKAGJDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Vector3 LNMMMMLPDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 CEDOOBMGJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Vector3 BFDJIOFJCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	float EOKGHAGPAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	float HAEFLDKLGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Vector3 PCPJCDMIJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Quaternion GFOFBGIDMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	float ILOEMAEECMH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float CFNILIBNGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool HBECIGFHCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	NCPKOJCDALC LNHAPLKLDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool PPIIAABHJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Transform CDNEFHIOENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	Vector3 KFAAPGELFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	float IMHJPFNFNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "72")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	float NHIEPKPONDM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "73")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "74")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Quaternion GDDACFGNJEK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "75")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Vector3 JOKDPLOFCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "78")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	Quaternion LIEFADIIOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "79")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "80")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	RigidbodyConstraints HOIEFHNEJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "82")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool PBGGBENBKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	CollisionDetectionMode DMJBAPBDLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "86")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	bool NMPAHBDOMCI
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "87")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NNNLLNDCCPA KFLEHKABKMN;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event NNNLLNDCCPA CIMNDIFFJNI;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event NNNLLNDCCPA LPPJOENHEKM;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event NNNLLNDCCPA KNEGNLFJNMA;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NNNLLNDCCPA BMKCHOEGHLB;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event NNNLLNDCCPA IDKNKMIALCD;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event NNNLLNDCCPA CEFJFMIMOJO;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event BLIFDFFFFCN NGKAACAMJAP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<HODEOENILDN, HODEOENILDN> GEGDOIBPJAD;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "26")]
	EAMPMJFIPDM FPHHEOEFCOH(int IIACLAMOIEE);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void BPCKPJIFJPJ((Quaternion rot, Vector3 moments) ILJHDCDBMMG);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void OCFCMPGINLD();

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void JNCFIEEAJJD();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void ACEAJHFJPJB();

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void FMGABLBNPJO();

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void BIGDJFKKKCB();

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void KAPGKFEMBMB(EAMPMJFIPDM HCPAOILCJCB, bool JAMKBEGAKKK = false);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void BDMJEDOPIAF(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void MMLMFKMCNPK(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "96")]
	Vector3 BHCPJLJFLBG(Vector3 FPGFMPILIAN);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 FEKDHJGMJJI(Vector3 MJJIJGEDDJO);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void JFELHGOGIML();

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void AMIBEBEGNNE();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void LMHEOLDAMJG();

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void MFPPKFIOGGP(Vector3 IIPCJAOLCGL, Vector3 JDEICCDPEBF);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void LLMECHIHOOJ(Vector3 MODOOLGGFMH, Vector3 JMPPLOEFJOG);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void DGLHGNBFKOA(Vector3 KBBOLBHAJEC);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void ADHGKABNEOE(CHDHBDHLHKI BIEBDPIGOMG, Vector3 ONIFOJGMGJC, float LIIJBIKPANP, float GCHLECDEBPI = 8f, float LADGMJOCDMA = 1f);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void CBHLPJNCLIG(MFDGILLPOIO FLOMCHMPOIC, Vector3 JJADDKAGGLG, float GIIMKAIGAJH = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void MCHDDMAIDLM(MFDGILLPOIO FLOMCHMPOIC, Vector3 CBCAIPELAJP, float AMJKNOLCIOF = 7f, float LHJIPGKFCBJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "107")]
	Vector3 PLFHMGDBJLF(Vector3 HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 AEFADFHLLLF(Vector3 HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void MLIIOPEGDCK();

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void IJHCNDAPDLI(EAMPMJFIPDM IBDEDNMMKKK, object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void IBFMELFFPJL(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void KPAFAJAOCIK();

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void EHMNKDGDHDM();

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void PPMKFKODDLE();

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "115")]
	bool DDLEPECEOGG();

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void OADFMMHPIPB();

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void PPBAIDPEJJJ(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void CDFDHFNFKHE(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void GKPAEPIOIOB(object CMNJCPJBHGE, bool CKPMADLDOMI);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void OPBJAAGMMIH(Vector3 NAHFOOFADAD, Quaternion FDEFNOBEGJN);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void FCGPHNLBIID(Vector3 IIBFNIDFABP, Quaternion OEKHKEJMIDI);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "122")]
	bool HOCFMFENHCD(float MPACBOHCOML);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void PAFCIIEJBEB(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void BHIGFJOMPMH(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void CHMLNINGDIN(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void JGLMCCCILMF(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void BPGCMNFKCPM(Vector3 MKNFMGNFODH, ForceMode KKGJDJKIGAK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void DFPGKIIIKOP(Vector3 MKNFMGNFODH, Vector3 CPGMOBFHDAC, ForceMode KKGJDJKIGAK);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void ONGDOCOALPF(Vector3 FLGIFKEJPMG, ForceMode KKGJDJKIGAK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void MLNNFBLMKJP(Vector3 FLGIFKEJPMG, ForceMode KKGJDJKIGAK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "131")]
	bool APFBDCMHMKJ(Vector3 LIDLBHGKPBN, [Out] RaycastHit OEFCPHKEKMJ, float KIECEDCFNCJ);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void MKGHIBCBAHN();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface EFFPCFBOJKN
{
	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJGELCJEPAE(Vector3 FAFMJPECGNF);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNIFPHFPHBF(Vector3 KFMFAILJFNK);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KLENOMKFOBD(Vector3 FAFMJPECGNF);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HDCIAFHGEIB(Vector3 KFMFAILJFNK);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GKJILOLAJBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 ANPMKOPFKEF();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 PPMEFKCFOJA();
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public delegate void NNNLLNDCCPA(JBMMKMCLEMD FCDCCGFIKCO);
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum KKKJIJOJHCG
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
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum CHDHBDHLHKI
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
[Cpp2IlInjected.Token(Token = "0x2000045")]
public delegate void BLIFDFFFFCN(JBMMKMCLEMD FCDCCGFIKCO, bool JAMKBEGAKKK = false);
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum MFDGILLPOIO
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct LFGJEKNLFEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Rigidbody JKGEPDGLGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public object IAENBOLPMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector3 EDDMEOFJKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector3 JEBAPEFGHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public KBLCCMMKFLK ACMAJJOJKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool ADGFJNJIJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool GMPMHFEMCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool MDCJLGPPJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public bool KMJEJEFCKMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct OBGLMNKFCEH : IEquatable<OBGLMNKFCEH>, LPGBKEPCJMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly OBGLMNKFCEH OIMMEEJCOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "6")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public DBDKGGFJCGA DCIPDEOFAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(DBDKGGFJCGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public GFBFGDDLLEI DPGHFLOOKGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(GFBFGDDLLEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public GameObject MCCIFMIMANN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7155D50", Offset = "0x7155150", VA = "0x187155D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public OKLHMMELOIN KLNCMEILEHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7156170", Offset = "0x7155570", VA = "0x187156170")]
		get
		{
			return default(OKLHMMELOIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public BFFJDHLHCFI PHLBCCDDJJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7156020", Offset = "0x7155420", VA = "0x187156020")]
		get
		{
			return default(BFFJDHLHCFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public NABGOBFPKKK BCJONOOKNBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7155F40", Offset = "0x7155340", VA = "0x187155F40")]
		get
		{
			return default(NABGOBFPKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool EDPMGONPMCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7155EE0", Offset = "0x71552E0", VA = "0x187155EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool MNHGOMILFHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7155C90", Offset = "0x7155090", VA = "0x187155C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool BAEIAKGFJAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7156120", Offset = "0x7155520", VA = "0x187156120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool BAKFMEPPNNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7155D30", Offset = "0x7155130", VA = "0x187155D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool JHFAILMMDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7155970", Offset = "0x7154D70", VA = "0x187155970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool BKIHOIPDMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7155C70", Offset = "0x7155070", VA = "0x187155C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool LGLKIJLJDFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x71560C0", Offset = "0x71554C0", VA = "0x1871560C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool JONNGICGIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7155F00", Offset = "0x7155300", VA = "0x187155F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool KKDMAGIHPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7156100", Offset = "0x7155500", VA = "0x187156100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public POINDCMIGBF PAANCHGIJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(POINDCMIGBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public FMPEJPGBBKM FOJKLAGAIIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(FMPEJPGBBKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public GNFMLNJBANP KDPJIFBNJNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(GNFMLNJBANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public GILMFIKIADP ICDHLFDGHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(GILMFIKIADP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public LBHEMPKEDNP HPDDLEEGKJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(LBHEMPKEDNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public MPFPCCDMOJO DPAIBGOBMFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(MPFPCCDMOJO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public KGMBMAOJJAG CFFGNCODPLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(KGMBMAOJJAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public IODBGMCMFBA GABLOJMACCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(IODBGMCMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public COPDMDGHAKH EPCFBMECGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(COPDMDGHAKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public INCKFEHMLMG HAKAONFAJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(INCKFEHMLMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public JHCAJJBLDPD PHEBHMHODDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(JHCAJJBLDPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public KKGCGNFGKLD AIOHHDNICCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(KKGCGNFGKLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public CDGPDNONDOE PLEILFPLPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(CDGPDNONDOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool HNINFNKEODO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7155A90", Offset = "0x7154E90", VA = "0x187155A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool FKKEOLEPNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7155A50", Offset = "0x7154E50", VA = "0x187155A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool MKMMBKBFLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7155FE0", Offset = "0x71553E0", VA = "0x187155FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private bool PGCDOCFJDEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public OBGLMNKFCEH(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7145AB0", Offset = "0x7144EB0", VA = "0x187145AB0")]
	public static bool IDKOEJANABA(OBGLMNKFCEH HCPAOILCJCB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static AOMADBOBEAJ IDKOEJANABA(OBGLMNKFCEH HCPAOILCJCB)
	{
		return default(AOMADBOBEAJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x71455F0", Offset = "0x71449F0", VA = "0x1871455F0")]
	public static bool FANHDJJNLED(OBGLMNKFCEH DDIIBBHFODJ, OBGLMNKFCEH BCCGANGEINF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7143CF0", Offset = "0x71430F0", VA = "0x187143CF0")]
	public static bool KNIDLJBALLO(OBGLMNKFCEH DDIIBBHFODJ, OBGLMNKFCEH BCCGANGEINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x71559C0", Offset = "0x7154DC0", VA = "0x1871559C0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(OBGLMNKFCEH BMKPAKCEMFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static OBGLMNKFCEH IDKOEJANABA(AOMADBOBEAJ NKCFJFCLAAC)
	{
		return default(OBGLMNKFCEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7155CB0", Offset = "0x71550B0", VA = "0x187155CB0")]
	public CMDBFBNDMHD IKCPAEAKPEO()
	{
		return default(CMDBFBNDMHD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7155990", Offset = "0x7154D90", VA = "0x187155990")]
	public JIPGOOCICED DELFKGAJBPD()
	{
		return default(JIPGOOCICED);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7155C20", Offset = "0x7155020", VA = "0x187155C20")]
	public IDIJKEEILII GDOJPGNNAGF()
	{
		return default(IDIJKEEILII);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7156140", Offset = "0x7155540", VA = "0x187156140")]
	public HDHMPIGKHJC PHIDBKPMMNO()
	{
		return default(HDHMPIGKHJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7155B80", Offset = "0x7154F80", VA = "0x187155B80")]
	public void FMMMGJGJKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7156210", Offset = "0x7155610", VA = "0x187156210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct KGMBMAOJJAG : IEquatable<KGMBMAOJJAG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7152D10", Offset = "0x7152110", VA = "0x187152D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private CMJCBAIFNMJ NKCDCPHHIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7152EC0", Offset = "0x71522C0", VA = "0x187152EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool AFMGDGOCNFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x71529A0", Offset = "0x7151DA0", VA = "0x1871529A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Guid CHJILMAINAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7152A30", Offset = "0x7151E30", VA = "0x187152A30")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool EMIHMJLPOPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7152880", Offset = "0x7151C80", VA = "0x187152880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Guid IIDBDCCCCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7152630", Offset = "0x7151A30", VA = "0x187152630")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public KGMBMAOJJAG(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x71527F0", Offset = "0x7151BF0", VA = "0x1871527F0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(KGMBMAOJJAG BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7152B50", Offset = "0x7151F50", VA = "0x187152B50")]
	public bool LMBNOPAOPLN([Out] Guid PAAPGLCPIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7152DA0", Offset = "0x71521A0", VA = "0x187152DA0")]
	public void PHFFEBLFKAB(Guid BBFFJMPBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7152750", Offset = "0x7151B50", VA = "0x187152750")]
	public bool AHIAJHBJNLH([Out] Guid DOKBOJKBDAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7152BF0", Offset = "0x7151FF0", VA = "0x187152BF0")]
	public void MDJEJOIMBCB(Guid BBFFJMPBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7152910", Offset = "0x7151D10", VA = "0x187152910")]
	public void IGAOFKMFHBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct IDIJKEEILII : IEquatable<IDIJKEEILII>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x714F940", Offset = "0x714ED40", VA = "0x18714F940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private OEHGMMFAPNP ACFCJINCOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x714F5E0", Offset = "0x714E9E0", VA = "0x18714F5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public Vector3 ECNIMKGJMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x714F490", Offset = "0x714E890", VA = "0x18714F490")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Quaternion LAMLMBJDKDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x714F800", Offset = "0x714EC00", VA = "0x18714F800")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public OBGLMNKFCEH AFOOCBELGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x714F110", Offset = "0x714E510", VA = "0x18714F110")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public IDIJKEEILII(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7145AB0", Offset = "0x7144EB0", VA = "0x187145AB0")]
	public static bool IDKOEJANABA(IDIJKEEILII HCPAOILCJCB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static AOMADBOBEAJ IDKOEJANABA(IDIJKEEILII HCPAOILCJCB)
	{
		return default(AOMADBOBEAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x714F400", Offset = "0x714E800", VA = "0x18714F400", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(IDIJKEEILII BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x714F2B0", Offset = "0x714E6B0", VA = "0x18714F2B0")]
	public void EBLHMMDMGIN(Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x714F1A0", Offset = "0x714E5A0", VA = "0x18714F1A0")]
	public void DLKLHHNNIPH(float BMGLFPFGJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x714F640", Offset = "0x714EA40", VA = "0x18714F640")]
	public void LBHBFPPNMGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct CMDBFBNDMHD : IEquatable<CMDBFBNDMHD>
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly CMDBFBNDMHD OIMMEEJCOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DBDKGGFJCGA DCIPDEOFAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(DBDKGGFJCGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public GFBFGDDLLEI DPGHFLOOKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(GFBFGDDLLEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7145DE0", Offset = "0x71451E0", VA = "0x187145DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	private LBKPIKLOHEL OKLLLECMFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7145620", Offset = "0x7144A20", VA = "0x187145620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public DFMAFHIFHME BLHPGCKAHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7145F90", Offset = "0x7145390", VA = "0x187145F90")]
		get
		{
			return default(DFMAFHIFHME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public IEnumerable<OBGLMNKFCEH> GKKJFBEKOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7145880", Offset = "0x7144C80", VA = "0x187145880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public IEnumerable<OBGLMNKFCEH> HIHPELMKJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7145C30", Offset = "0x7145030", VA = "0x187145C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public int AEJELDFABBC
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x71457F0", Offset = "0x7144BF0", VA = "0x1871457F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public int KCGNPNAGMEP
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7145D90", Offset = "0x7145190", VA = "0x187145D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public string DKCJKHANLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7145A30", Offset = "0x7144E30", VA = "0x187145A30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7145B60", Offset = "0x7144F60", VA = "0x187145B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public IEEIAAPPNKJ NMMJPNMKHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7145EF0", Offset = "0x71452F0", VA = "0x187145EF0")]
		get
		{
			return default(IEEIAAPPNKJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7145B10", Offset = "0x7144F10", VA = "0x187145B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public OLIPBANBJJC OMMKOGBPCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7146100", Offset = "0x7145500", VA = "0x187146100")]
		get
		{
			return default(OLIPBANBJJC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x71460B0", Offset = "0x71454B0", VA = "0x1871460B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public DOEHBADGEDJ DEOGKBMEGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7145AD0", Offset = "0x7144ED0", VA = "0x187145AD0")]
		get
		{
			return default(DOEHBADGEDJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x71459E0", Offset = "0x7144DE0", VA = "0x1871459E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public float PHLKGNBIACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x7145290", Offset = "0x7144690", VA = "0x187145290")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x7145BE0", Offset = "0x7144FE0", VA = "0x187145BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool CBOFAFBCKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7145680", Offset = "0x7144A80", VA = "0x187145680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool FOLOIDKOIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x71452D0", Offset = "0x71446D0", VA = "0x1871452D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool PCCHBKLPKGG
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7145730", Offset = "0x7144B30", VA = "0x187145730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool FACDMFGLMHC
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7145790", Offset = "0x7144B90", VA = "0x187145790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool BGOADELOACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7145D50", Offset = "0x7145150", VA = "0x187145D50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x71451F0", Offset = "0x71445F0", VA = "0x1871451F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool ADLJBHIPPPL
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7145250", Offset = "0x7144650", VA = "0x187145250")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7145F30", Offset = "0x7145330", VA = "0x187145F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public CMDBFBNDMHD(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7145AB0", Offset = "0x7144EB0", VA = "0x187145AB0")]
	public static bool IDKOEJANABA(CMDBFBNDMHD HCPAOILCJCB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x71455F0", Offset = "0x71449F0", VA = "0x1871455F0")]
	public static bool FANHDJJNLED(CMDBFBNDMHD DDIIBBHFODJ, CMDBFBNDMHD BCCGANGEINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7145560", Offset = "0x7144960", VA = "0x187145560", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(CMDBFBNDMHD BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static OBGLMNKFCEH IDKOEJANABA(CMDBFBNDMHD MPLBPEBNKFP)
	{
		return default(OBGLMNKFCEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7145600", Offset = "0x7144A00", VA = "0x187145600")]
	public bool FBIEHGJFGPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x71456E0", Offset = "0x7144AE0", VA = "0x1871456E0")]
	public bool FPJAADGNGOC(LAKABHFBLCH NMJPBABDHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7145E70", Offset = "0x7145270", VA = "0x187145E70")]
	public void OAOIJMBFAOM(LAKABHFBLCH NMJPBABDHGL, bool GLCFJLGEAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7145330", Offset = "0x7144730", VA = "0x187145330")]
	public DFMAFHIFHME EOOKDBEHEGN(Allocator MEFLJHAPKJF)
	{
		return default(DFMAFHIFHME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7144E50", Offset = "0x7144250", VA = "0x187144E50")]
	public void AKBNCLDPCBA(CMDBFBNDMHD BMKPAKCEMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7144890", Offset = "0x7143C90", VA = "0x187144890")]
	public void AJIONPBKBCG(List<OBGLMNKFCEH> ECLEOKJMKCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct EAFBOFIPPAF : IEquatable<EAFBOFIPPAF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x714AA20", Offset = "0x7149E20", VA = "0x18714AA20", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(EAFBOFIPPAF BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct FMPEJPGBBKM : IEquatable<FMPEJPGBBKM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public FMPEJPGBBKM(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x714C930", Offset = "0x714BD30", VA = "0x18714C930", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(FMPEJPGBBKM BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x714C890", Offset = "0x714BC90", VA = "0x18714C890")]
	public void DNAOJJGPLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x714C9C0", Offset = "0x714BDC0", VA = "0x18714C9C0")]
	public void KPGBJGMKNDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x714C7F0", Offset = "0x714BBF0", VA = "0x18714C7F0")]
	public bool CIJIFFFDDNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct GFBFGDDLLEI : IEquatable<GFBFGDDLLEI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x714D370", Offset = "0x714C770", VA = "0x18714D370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private LBKPIKLOHEL OKLLLECMFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x714CBF0", Offset = "0x714BFF0", VA = "0x18714CBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public AOMADBOBEAJ GKIIMGMHIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x714CCE0", Offset = "0x714C0E0", VA = "0x18714CCE0")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public OBGLMNKFCEH HOBMCFDJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x714D400", Offset = "0x714C800", VA = "0x18714D400")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public OBGLMNKFCEH FFIKGEIEAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x714D2E0", Offset = "0x714C6E0", VA = "0x18714D2E0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public GFBFGDDLLEI(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x714CB00", Offset = "0x714BF00", VA = "0x18714CB00", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(GFBFGDDLLEI BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x714D1A0", Offset = "0x714C5A0", VA = "0x18714D1A0")]
	public bool KAPGKFEMBMB(OBGLMNKFCEH AMMKPAGCALK, bool HPLPJGIMICM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x714CA60", Offset = "0x714BE60", VA = "0x18714CA60")]
	public bool BKBJHNPHFPD(OBGLMNKFCEH IFFJEHOBPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x714CF20", Offset = "0x714C320", VA = "0x18714CF20")]
	private void IPDCJBPAKPL(OBGLMNKFCEH KHCJFEMPKNH, List<OBGLMNKFCEH> DPGIGMFFKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x714D2D0", Offset = "0x714C6D0", VA = "0x18714D2D0")]
	public void KGEIDOLNDFO(List<OBGLMNKFCEH> KLDIJOFKNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x714CD70", Offset = "0x714C170", VA = "0x18714CD70")]
	public CMDBFBNDMHD HMPNBJCAFAC()
	{
		return default(CMDBFBNDMHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x714CB90", Offset = "0x714BF90", VA = "0x18714CB90")]
	public void FGCAOONIEEP(List<OBGLMNKFCEH> KLDIJOFKNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x714CE00", Offset = "0x714C200", VA = "0x18714CE00")]
	public NativeArray<AOMADBOBEAJ> IDBDCGBKBKJ()
	{
		return default(NativeArray<AOMADBOBEAJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x714CC50", Offset = "0x714C050", VA = "0x18714CC50")]
	public int GDHBDDIKBFO()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct POINDCMIGBF : IEquatable<POINDCMIGBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public string ABEKIOKGBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7156990", Offset = "0x7155D90", VA = "0x187156990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public string ODHMJGDPGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7156BB0", Offset = "0x7155FB0", VA = "0x187156BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool ONCPEMNMADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7156A10", Offset = "0x7155E10", VA = "0x187156A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public string OGFEFMIJMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x71564D0", Offset = "0x71558D0", VA = "0x1871564D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string HOELFOAADBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x71565C0", Offset = "0x71559C0", VA = "0x1871565C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public string DCPKJCEOGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7156810", Offset = "0x7155C10", VA = "0x187156810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public POINDCMIGBF(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7156900", Offset = "0x7155D00", VA = "0x187156900", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(POINDCMIGBF BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct JHCAJJBLDPD : IEquatable<JHCAJJBLDPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7151E80", Offset = "0x7151280", VA = "0x187151E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private IHDKKIEEAME AELEAEEKMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7151BE0", Offset = "0x7150FE0", VA = "0x187151BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public PDKELJPCIHO CKIACGCPKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7151FA0", Offset = "0x71513A0", VA = "0x187151FA0")]
		get
		{
			return default(PDKELJPCIHO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7151CD0", Offset = "0x71510D0", VA = "0x187151CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool MDKPCKLFNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7151C40", Offset = "0x7151040", VA = "0x187151C40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7151AB0", Offset = "0x7150EB0", VA = "0x187151AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public string[] DLCBGNJEBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7151710", Offset = "0x7150B10", VA = "0x187151710")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x71518E0", Offset = "0x7150CE0", VA = "0x1871518E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public string[] AMNFIDLJECI
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7151680", Offset = "0x7150A80", VA = "0x187151680")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7151840", Offset = "0x7150C40", VA = "0x187151840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public string[] PIMKKHICLEH
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7151B50", Offset = "0x7150F50", VA = "0x187151B50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7151980", Offset = "0x7150D80", VA = "0x187151980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public string[] LJCKGMMFNGN
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7151F10", Offset = "0x7151310", VA = "0x187151F10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7151DE0", Offset = "0x71511E0", VA = "0x187151DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public JHCAJJBLDPD(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static AOMADBOBEAJ IDKOEJANABA(JHCAJJBLDPD HCPAOILCJCB)
	{
		return default(AOMADBOBEAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7151A20", Offset = "0x7150E20", VA = "0x187151A20", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(JHCAJJBLDPD BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x71517A0", Offset = "0x7150BA0", VA = "0x1871517A0")]
	public bool BFLECHCPPBP(AOMADBOBEAJ FFBDHANOEPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct GMKCJGEJMDO : IEquatable<GMKCJGEJMDO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x714E3C0", Offset = "0x714D7C0", VA = "0x18714E3C0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(GMKCJGEJMDO BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct GNFMLNJBANP : IEquatable<GNFMLNJBANP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Collider NBNNNLEFDGL
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x714E640", Offset = "0x714DA40", VA = "0x18714E640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public GNFMLNJBANP(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x714E450", Offset = "0x714D850", VA = "0x18714E450", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(GNFMLNJBANP BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x714E4E0", Offset = "0x714D8E0", VA = "0x18714E4E0")]
	public bool FKNHNFEJNCB([Out] CNFFBLBPPPF DALFGDJANJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x714E790", Offset = "0x714DB90", VA = "0x18714E790")]
	public bool ICBMLNKKJAA([Out] AOMADBOBEAJ NIMLNKDMKHI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct HDHMPIGKHJC : IEquatable<HDHMPIGKHJC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool BDNIMMKIDGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x714EA50", Offset = "0x714DE50", VA = "0x18714EA50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public HDHMPIGKHJC(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x714E9C0", Offset = "0x714DDC0", VA = "0x18714E9C0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(HDHMPIGKHJC BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct COPDMDGHAKH : IEquatable<COPDMDGHAKH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x71462D0", Offset = "0x71456D0", VA = "0x1871462D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private KEDIDNHDFMK BOPOEJJDOLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7146270", Offset = "0x7145670", VA = "0x187146270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public COPDMDGHAKH(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7146140", Offset = "0x7145540", VA = "0x187146140", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(COPDMDGHAKH BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x71461D0", Offset = "0x71455D0", VA = "0x1871461D0")]
	public void IJMLHBIKBIN(bool AENNCPMGIOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct GILMFIKIADP : IEquatable<GILMFIKIADP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x714DF80", Offset = "0x714D380", VA = "0x18714DF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool EFKPKHGPKFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x714DE30", Offset = "0x714D230", VA = "0x18714DE30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool MDPEJAGOKKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x714DAF0", Offset = "0x714CEF0", VA = "0x18714DAF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool LJICIKGLBED
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x714E130", Offset = "0x714D530", VA = "0x18714E130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool HKHNNLBLADO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x714D870", Offset = "0x714CC70", VA = "0x18714D870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool JJLMALOHPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x714DA20", Offset = "0x714CE20", VA = "0x18714DA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool PEFGHDHIHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x714E1D0", Offset = "0x714D5D0", VA = "0x18714E1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool FBKFMLDLKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x714DB90", Offset = "0x714CF90", VA = "0x18714DB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool BKPJOLIBIJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x714D820", Offset = "0x714CC20", VA = "0x18714D820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool JDNOKDMNNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x714DB40", Offset = "0x714CF40", VA = "0x18714DB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool FODLMGHDDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x714D6F0", Offset = "0x714CAF0", VA = "0x18714D6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool CGBHMOLKMED
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x714E180", Offset = "0x714D580", VA = "0x18714E180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool EFKLKADAJNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x714E090", Offset = "0x714D490", VA = "0x18714E090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool BCBMCMOGPFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x714D940", Offset = "0x714CD40", VA = "0x18714D940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool GLIDELAJCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x714D7E0", Offset = "0x714CBE0", VA = "0x18714D7E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x714DDD0", Offset = "0x714D1D0", VA = "0x18714DDD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public NPCMHJCAMLN GEFJNGPGIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x714DAB0", Offset = "0x714CEB0", VA = "0x18714DAB0")]
		get
		{
			return default(NPCMHJCAMLN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x714DF30", Offset = "0x714D330", VA = "0x18714DF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool KAFIOFMAPGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x714DC40", Offset = "0x714D040", VA = "0x18714DC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public MADKIBJAIEL DLKGLPBGFIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x714D5B0", Offset = "0x714C9B0", VA = "0x18714D5B0")]
		get
		{
			return default(MADKIBJAIEL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x714D740", Offset = "0x714CB40", VA = "0x18714D740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool DLBHPNJCCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x714DEF0", Offset = "0x714D2F0", VA = "0x18714DEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 HHIEAIBPHLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x714D8C0", Offset = "0x714CCC0", VA = "0x18714D8C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public Vector3 KBOBICABNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x714E010", Offset = "0x714D410", VA = "0x18714E010")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool PMCLCMJOFEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x714D5F0", Offset = "0x714C9F0", VA = "0x18714D5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public GILMFIKIADP(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x714D990", Offset = "0x714CD90", VA = "0x18714D990", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(GILMFIKIADP BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x714DBE0", Offset = "0x714CFE0", VA = "0x18714DBE0")]
	public bool HPOGOIJADHB(AGDPHKHJMJD NMJPBABDHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x714E0E0", Offset = "0x714D4E0", VA = "0x18714E0E0")]
	public bool NJLJBIFDNEP(KLFGHHFCBOI NMJPBABDHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x714DE70", Offset = "0x714D270", VA = "0x18714DE70")]
	public void JMBGOIOFBDE(KLFGHHFCBOI NMJPBABDHGL, bool GLCFJLGEAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x714DA70", Offset = "0x714CE70", VA = "0x18714DA70")]
	public KLFGHHFCBOI FKBEGMMHHJB()
	{
		return default(KLFGHHFCBOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x714D790", Offset = "0x714CB90", VA = "0x18714D790")]
	public bool BNOBGFAIDOE(KLFGHHFCBOI HCPAOILCJCB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct INCKFEHMLMG : IEquatable<INCKFEHMLMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x71507A0", Offset = "0x714FBA0", VA = "0x1871507A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	private KCIMBNFCFNI OIBCNJIFNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x714FD60", Offset = "0x714F160", VA = "0x18714FD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public INCKFEHMLMG(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7150000", Offset = "0x714F400", VA = "0x187150000", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(INCKFEHMLMG BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7150670", Offset = "0x714FA70", VA = "0x187150670")]
	public bool IIJKCEAIJAF(AEMLLOGJEJB HBOEBNCIJMJ, List<OBGLMNKFCEH> ECLEOKJMKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7150830", Offset = "0x714FC30", VA = "0x187150830")]
	public int OCMBMPGGFFC(AEMLLOGJEJB HBOEBNCIJMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x714FDC0", Offset = "0x714F1C0", VA = "0x18714FDC0")]
	public void CKBBHFPCNFB(List<OBGLMNKFCEH> ECLEOKJMKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7150250", Offset = "0x714F650", VA = "0x187150250")]
	public int GLPGCKAPGKN(OBGLMNKFCEH MGPMAFDHMLC, AEMLLOGJEJB HBOEBNCIJMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x714FED0", Offset = "0x714F2D0", VA = "0x18714FED0")]
	public OBGLMNKFCEH DOOPHGKDJMN(int IIACLAMOIEE, AEMLLOGJEJB HBOEBNCIJMJ)
	{
		return default(OBGLMNKFCEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7150540", Offset = "0x714F940", VA = "0x187150540")]
	public void IICOICDCKBM(OBGLMNKFCEH MGPMAFDHMLC, AEMLLOGJEJB HBOEBNCIJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7150090", Offset = "0x714F490", VA = "0x187150090")]
	public bool FOHAGEGBJLL(OBGLMNKFCEH MGPMAFDHMLC, AEMLLOGJEJB HBOEBNCIJMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7150140", Offset = "0x714F540", VA = "0x187150140")]
	public void GFFIKIKDKOH(AEMLLOGJEJB HBOEBNCIJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7150490", Offset = "0x714F890", VA = "0x187150490")]
	public bool IHBMJEKANAI(OBGLMNKFCEH MGPMAFDHMLC, AEMLLOGJEJB HBOEBNCIJMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7150380", Offset = "0x714F780", VA = "0x187150380")]
	public bool IAIAFLPCCFN(AEMLLOGJEJB HBOEBNCIJMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct MPFPCCDMOJO : IEquatable<MPFPCCDMOJO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x71544F0", Offset = "0x71538F0", VA = "0x1871544F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public MPFPCCDMOJO(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x71543D0", Offset = "0x71537D0", VA = "0x1871543D0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(MPFPCCDMOJO BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7154340", Offset = "0x7153740", VA = "0x187154340")]
	public void BGOFBKKKGJD(bool HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7154460", Offset = "0x7153860", VA = "0x187154460")]
	public void HHHHNHKCFKE(bool HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x3145060", Offset = "0x3144460", VA = "0x183145060")]
	public T DFOLMEFDGDG<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct KKGCGNFGKLD : IEquatable<KKGCGNFGKLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x7153130", Offset = "0x7152530", VA = "0x187153130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private NFNOBECIPIP KILBFBEFDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7152F20", Offset = "0x7152320", VA = "0x187152F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public bool KLKJHFFOEPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x7152F80", Offset = "0x7152380", VA = "0x187152F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public bool KGKAFBMNAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x71530A0", Offset = "0x71524A0", VA = "0x1871530A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public KKGCGNFGKLD(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7153010", Offset = "0x7152410", VA = "0x187153010", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(KKGCGNFGKLD BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct KCPCJIAOBBM : IEquatable<KCPCJIAOBBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x71525A0", Offset = "0x71519A0", VA = "0x1871525A0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(KCPCJIAOBBM BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct LBHEMPKEDNP : IEquatable<LBHEMPKEDNP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x7153BD0", Offset = "0x7152FD0", VA = "0x187153BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private PNAJDFKGGGF BGPNHOJHMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x7153D90", Offset = "0x7153190", VA = "0x187153D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private DAACFAIFOBE DHAHCAINFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x7153510", Offset = "0x7152910", VA = "0x187153510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool OGDOFMLLJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7153F00", Offset = "0x7153300", VA = "0x187153F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool EECIOJHFNHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x71536E0", Offset = "0x7152AE0", VA = "0x1871536E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool AMBFLOJEKEL
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7153F90", Offset = "0x7153390", VA = "0x187153F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool OHKKFCECPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x71531C0", Offset = "0x71525C0", VA = "0x1871531C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool NCCOOAIJIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7153470", Offset = "0x7152870", VA = "0x187153470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool CDFDDEILOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7153D00", Offset = "0x7153100", VA = "0x187153D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public bool PKAMODKGMNM
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7153920", Offset = "0x7152D20", VA = "0x187153920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool EIGKBNIDFFG
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7153570", Offset = "0x7152970", VA = "0x187153570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool JPONDHKADFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7153780", Offset = "0x7152B80", VA = "0x187153780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public LBHEMPKEDNP(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7145AB0", Offset = "0x7144EB0", VA = "0x187145AB0")]
	public static bool IDKOEJANABA(LBHEMPKEDNP HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x71533E0", Offset = "0x71527E0", VA = "0x1871533E0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(LBHEMPKEDNP BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x71534A0", Offset = "0x71528A0", VA = "0x1871534A0")]
	public bool FCEOGMFEHKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7153C60", Offset = "0x7153060", VA = "0x187153C60")]
	public OBGLMNKFCEH MMJEIOLMKPH(OBGLMNKFCEH MGPMAFDHMLC)
	{
		return default(OBGLMNKFCEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7153DF0", Offset = "0x71531F0", VA = "0x187153DF0")]
	public AOMADBOBEAJ NOKNAPBPKEI()
	{
		return default(AOMADBOBEAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7153340", Offset = "0x7152740", VA = "0x187153340")]
	public bool EOBGBOHDHDN(AOMADBOBEAJ CKHGFHIFINP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7153B30", Offset = "0x7152F30", VA = "0x187153B30")]
	public bool KJPJFANBFBE(AOMADBOBEAJ MACMOOKCMGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x7153290", Offset = "0x7152690", VA = "0x187153290")]
	public bool EDEMBCJFBNN(AOMADBOBEAJ MGPMAFDHMLC, [Out] AOMADBOBEAJ CKHGFHIFINP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct JIPGOOCICED : IEquatable<JIPGOOCICED>
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly JIPGOOCICED OIMMEEJCOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public DBDKGGFJCGA DCIPDEOFAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(DBDKGGFJCGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public GFBFGDDLLEI DPGHFLOOKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(GFBFGDDLLEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public EMNBECFOLHA ALGMBDLIENM
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x7152520", Offset = "0x7151920", VA = "0x187152520")]
		get
		{
			return default(EMNBECFOLHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public DGJCNJCEEEP FHAKFMIMKOL
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x7152410", Offset = "0x7151810", VA = "0x187152410")]
		get
		{
			return default(DGJCNJCEEEP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x71520F0", Offset = "0x71514F0", VA = "0x1871520F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public DIJCMKAGHOP DPDBIOCNEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x7152450", Offset = "0x7151850", VA = "0x187152450")]
		get
		{
			return default(DIJCMKAGHOP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7152340", Offset = "0x7151740", VA = "0x187152340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public float PMCAMOAGBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7152490", Offset = "0x7151890", VA = "0x187152490")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x71524D0", Offset = "0x71518D0", VA = "0x1871524D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public Vector3 EPODEPAPAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x7152390", Offset = "0x7151790", VA = "0x187152390")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x7152140", Offset = "0x7151540", VA = "0x187152140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public float JOELHIFOHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x71522F0", Offset = "0x71516F0", VA = "0x1871522F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public MCBOHJAEBBG NMFEKNPDLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7152560", Offset = "0x7151960", VA = "0x187152560")]
		get
		{
			return default(MCBOHJAEBBG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x7152210", Offset = "0x7151610", VA = "0x187152210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public JIPGOOCICED(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7145AB0", Offset = "0x7144EB0", VA = "0x187145AB0")]
	public static bool IDKOEJANABA(JIPGOOCICED HCPAOILCJCB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7143CF0", Offset = "0x71430F0", VA = "0x187143CF0")]
	public static bool KNIDLJBALLO(JIPGOOCICED DDIIBBHFODJ, JIPGOOCICED BCCGANGEINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7152260", Offset = "0x7151660", VA = "0x187152260", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(JIPGOOCICED BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x71521C0", Offset = "0x71515C0", VA = "0x1871521C0")]
	public MFNMJKMECLC BIPNCAMDCBI()
	{
		return default(MFNMJKMECLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x71520A0", Offset = "0x71514A0", VA = "0x1871520A0")]
	public EIGHLLMDFND AAPPKPMBGLO()
	{
		return default(EIGHLLMDFND);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct MFNMJKMECLC : IEquatable<MFNMJKMECLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public JIPGOOCICED LJJAEKPLBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(JIPGOOCICED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public LHOIJIFDHFN HJPEKEOHMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x7154300", Offset = "0x7153700", VA = "0x187154300")]
		get
		{
			return default(LHOIJIFDHFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public MFNMJKMECLC(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7145AB0", Offset = "0x7144EB0", VA = "0x187145AB0")]
	public static bool IDKOEJANABA(MFNMJKMECLC HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7154270", Offset = "0x7153670", VA = "0x187154270", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(MFNMJKMECLC BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DefaultMember("Item")]
public readonly struct EIGHLLMDFND : IEquatable<EIGHLLMDFND>
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly EIGHLLMDFND OIMMEEJCOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public DBDKGGFJCGA DCIPDEOFAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(DBDKGGFJCGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	private BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x714BC50", Offset = "0x714B050", VA = "0x18714BC50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private IDONDGIODOA APJEDPLNMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x714B810", Offset = "0x714AC10", VA = "0x18714B810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public JIPGOOCICED LJJAEKPLBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(JIPGOOCICED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public AHKAPNEMKGD GBHLLIIDLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x714B3E0", Offset = "0x714A7E0", VA = "0x18714B3E0")]
		get
		{
			return default(AHKAPNEMKGD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x714BF00", Offset = "0x714B300", VA = "0x18714BF00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public IEnumerable<IDNDILFAIKH> GFFDJAIJGDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x714B590", Offset = "0x714A990", VA = "0x18714B590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public IDNDILFAIKH EEEHKFENLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x714BAA0", Offset = "0x714AEA0", VA = "0x18714BAA0")]
		get
		{
			return default(IDNDILFAIKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x714C020", Offset = "0x714B420", VA = "0x18714C020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public EIGHLLMDFND(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7145AB0", Offset = "0x7144EB0", VA = "0x187145AB0")]
	public static bool IDKOEJANABA(EIGHLLMDFND HCPAOILCJCB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x71455F0", Offset = "0x71449F0", VA = "0x1871455F0")]
	public static bool FANHDJJNLED(EIGHLLMDFND DDIIBBHFODJ, EIGHLLMDFND BCCGANGEINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x714B780", Offset = "0x714AB80", VA = "0x18714B780", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(EIGHLLMDFND BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x714BCE0", Offset = "0x714B0E0", VA = "0x18714BCE0")]
	public IDNDILFAIKH NHPGNDAJLNG(float3? CPGMOBFHDAC, [Optional] quaternion? CBCAIPELAJP, [Optional] Vector3? BMGLFPFGJFF)
	{
		return default(IDNDILFAIKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x714B870", Offset = "0x714AC70", VA = "0x18714B870")]
	public IDNDILFAIKH FOCPHFOBPNF(int IIACLAMOIEE, float3? CPGMOBFHDAC, [Optional] quaternion? CBCAIPELAJP, [Optional] Vector3? BMGLFPFGJFF)
	{
		return default(IDNDILFAIKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x714BBB0", Offset = "0x714AFB0", VA = "0x18714BBB0")]
	public void IEMNCPPEKKN(int IIACLAMOIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x714B500", Offset = "0x714A900", VA = "0x18714B500")]
	public void CDMKLDGEKPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct IDNDILFAIKH : IEquatable<IDNDILFAIKH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public EIGHLLMDFND INDHHLEEEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x714FAF0", Offset = "0x714EEF0", VA = "0x18714FAF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float3 JOKDPLOFCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x714FC60", Offset = "0x714F060", VA = "0x18714FC60")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x714FA90", Offset = "0x714EE90", VA = "0x18714FA90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public quaternion LIEFADIIOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x714FA40", Offset = "0x714EE40", VA = "0x18714FA40")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x714FCC0", Offset = "0x714F0C0", VA = "0x18714FCC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public float3 LEHHCOIIHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x714FC00", Offset = "0x714F000", VA = "0x18714FC00")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x714F9E0", Offset = "0x714EDE0", VA = "0x18714F9E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public GPGJJHENEFG IPEMFHEPIBG
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x714FD10", Offset = "0x714F110", VA = "0x18714FD10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public IDNDILFAIKH(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x714FB70", Offset = "0x714EF70", VA = "0x18714FB70", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(IDNDILFAIKH BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x714F9D0", Offset = "0x714EDD0", VA = "0x18714F9D0")]
	public void BGDCOIHNDNK(EIGHLLMDFND HCPAOILCJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct IODBGMCMFBA : IEquatable<IODBGMCMFBA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	private BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7151390", Offset = "0x7150790", VA = "0x187151390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private NEJHFIGADHH JIBNPFGCLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7150B80", Offset = "0x714FF80", VA = "0x187150B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public bool NAHBOGDFMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7151340", Offset = "0x7150740", VA = "0x187151340")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7150F20", Offset = "0x7150320", VA = "0x187150F20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool DGAEJPOOMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x71509E0", Offset = "0x714FDE0", VA = "0x1871509E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7151150", Offset = "0x7150550", VA = "0x187151150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public float IOLKANPENGF
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7150B40", Offset = "0x714FF40", VA = "0x187150B40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x71511B0", Offset = "0x71505B0", VA = "0x1871511B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public bool DNAHEDIOEPE
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7151550", Offset = "0x7150950", VA = "0x187151550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public IODBGMCMFBA(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7150E40", Offset = "0x7150240", VA = "0x187150E40", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(IODBGMCMFBA BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x7150C70", Offset = "0x7150070", VA = "0x187150C70")]
	public void EBDIFLDLJBB(int JIIJJAKJBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7150A30", Offset = "0x714FE30", VA = "0x187150A30")]
	public bool DDOAMEHEOCC([Out] int JIIJJAKJBGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x7150940", Offset = "0x714FD40", VA = "0x187150940")]
	public void AHCGOHAMHKH(bool PHMAKHCONOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x7150ED0", Offset = "0x71502D0", VA = "0x187150ED0")]
	public bool HBKFKMCBOMO(NIJJNBEEDDJ NMJPBABDHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x71510D0", Offset = "0x71504D0", VA = "0x1871510D0")]
	public void HKIDAKGHPNN(NIJJNBEEDDJ NMJPBABDHGL, bool GLCFJLGEAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x7151200", Offset = "0x7150600", VA = "0x187151200")]
	public void LOAKGCJFLDP(float MLDNPEFOAAN, float AHIOLMAIBKM, float OCIGHIBLICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x7150F80", Offset = "0x7150380", VA = "0x187150F80")]
	public void HHIPOBKCOGN(float3 BJJJMODBPBL, quaternion BJJDHDCIOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x7150D10", Offset = "0x7150110", VA = "0x187150D10")]
	public bool EFCLCIGGPNL([Out] float3 BJJJMODBPBL, [Out] quaternion BJJDHDCIOPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x7151420", Offset = "0x7150820", VA = "0x187151420")]
	public bool NBDKJPJJOFI([Out] float LMIGHNPJHCJ, [Out] float FABFCBIDMEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x7150BE0", Offset = "0x714FFE0", VA = "0x187150BE0")]
	public void DLPNBPNPKAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct DBDKGGFJCGA : IEquatable<DBDKGGFJCGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public GFBFGDDLLEI DPGHFLOOKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(GFBFGDDLLEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	private LHAACOMCFDP NJMNCMNFLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7148B30", Offset = "0x7147F30", VA = "0x187148B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public bool ILPJLBBPEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7148AF0", Offset = "0x7147EF0", VA = "0x187148AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public Vector3 JOKDPLOFCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7147C40", Offset = "0x7147040", VA = "0x187147C40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7146D80", Offset = "0x7146180", VA = "0x187146D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Quaternion LIEFADIIOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x71468E0", Offset = "0x7145CE0", VA = "0x1871468E0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7148060", Offset = "0x7147460", VA = "0x187148060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public Vector3 KFAAPGELFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x71474E0", Offset = "0x71468E0", VA = "0x1871474E0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7148420", Offset = "0x7147820", VA = "0x187148420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public Quaternion GDDACFGNJEK
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7147B00", Offset = "0x7146F00", VA = "0x187147B00")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x71471C0", Offset = "0x71465C0", VA = "0x1871471C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public float IMHJPFNFNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7148D30", Offset = "0x7148130", VA = "0x187148D30")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7147290", Offset = "0x7146690", VA = "0x187147290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public float NHIEPKPONDM
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7146CE0", Offset = "0x71460E0", VA = "0x187146CE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public Vector3 LEHHCOIIHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7147630", Offset = "0x7146A30", VA = "0x187147630")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7146720", Offset = "0x7145B20", VA = "0x187146720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Vector3 NDELMMMGPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x71484F0", Offset = "0x71478F0", VA = "0x1871484F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public Vector3 OEDNBPCDCME
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7146AF0", Offset = "0x7145EF0", VA = "0x187146AF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public Matrix4x4 OCPCMEGGNJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7147AC0", Offset = "0x7146EC0", VA = "0x187147AC0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public DBDKGGFJCGA(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x7146FA0", Offset = "0x71463A0", VA = "0x187146FA0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(DBDKGGFJCGA BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x71466D0", Offset = "0x7145AD0", VA = "0x1871466D0")]
	public JBNHCDLOLNG CEMFEBBIOOE()
	{
		return default(JBNHCDLOLNG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x71464F0", Offset = "0x71458F0", VA = "0x1871464F0")]
	public void AKFOBNEMHPB([Out] Matrix4x4 KAFLPFIJPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x7146410", Offset = "0x7145810", VA = "0x187146410")]
	public void ACPFEPNGEGG([Out] Vector3 AMMGIBFFKGA, [Out] Quaternion PLAODALGBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x7146360", Offset = "0x7145760", VA = "0x187146360")]
	public void ACPFEPNGEGG([Out] RigidTransform CIOHEEHLAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7147820", Offset = "0x7146C20", VA = "0x187147820")]
	public void IFEJGOPGAPH([In] Vector3 AMMGIBFFKGA, [In] Quaternion PLAODALGBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x71470E0", Offset = "0x71464E0", VA = "0x1871470E0")]
	public void FADBEBNCFBD([Out] Vector3 AMMGIBFFKGA, [Out] Quaternion PLAODALGBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7147030", Offset = "0x7146430", VA = "0x187147030")]
	public void FADBEBNCFBD([Out] RigidTransform CIOHEEHLAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7148330", Offset = "0x7147730", VA = "0x187148330")]
	public UniformTRS MEJNGIOLGJC()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x7148360", Offset = "0x7147760", VA = "0x187148360")]
	public void MEJNGIOLGJC([Out] UniformTRS CFHDOPANNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x71468B0", Offset = "0x7145CB0", VA = "0x1871468B0")]
	public UniformTRS CLOCAGEPGGB()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x71467F0", Offset = "0x7145BF0", VA = "0x1871467F0")]
	public void CLOCAGEPGGB([Out] UniformTRS CIOHEEHLAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x7148710", Offset = "0x7147B10", VA = "0x187148710")]
	public Vector3 ODGDBOLCFKP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x71479F0", Offset = "0x7146DF0", VA = "0x1871479F0")]
	public void JIIPBINJHHJ([In] Vector3 HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7146E50", Offset = "0x7146250", VA = "0x187146E50")]
	public Vector3 EOBOLGCGPNM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7147F90", Offset = "0x7147390", VA = "0x187147F90")]
	public void KIIBDPKNIMB([In] Vector3 HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x7148860", Offset = "0x7147C60", VA = "0x187148860")]
	public Quaternion OEJOBLFOIGD()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x7146600", Offset = "0x7145A00", VA = "0x187146600")]
	public void CAAHAACMFLG([In] Quaternion HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x7148BF0", Offset = "0x7147FF0", VA = "0x187148BF0")]
	public Quaternion PCBKNLHCLBH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x7147920", Offset = "0x7146D20", VA = "0x187147920")]
	public void IFNFJNKOIAD([In] Quaternion HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x7146C40", Offset = "0x7146040", VA = "0x187146C40")]
	public float EDPMFGPKPJH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x7147EE0", Offset = "0x71472E0", VA = "0x187147EE0")]
	public void KGNIFFLLGHD(float HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7147780", Offset = "0x7146B80", VA = "0x187147780")]
	public float HPICLHGKNNM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x7148280", Offset = "0x7147680", VA = "0x187148280")]
	public void MBJIMPBEKOL(float HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x7147410", Offset = "0x7146810", VA = "0x187147410")]
	public void FMALOOFEHGD([In] Vector3 HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x71489A0", Offset = "0x7147DA0", VA = "0x1871489A0")]
	public Vector3 OHJMOEOCGNO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x7147340", Offset = "0x7146740", VA = "0x187147340")]
	public void FEGNNAILMCG([In] Vector3 HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7148130", Offset = "0x7147530", VA = "0x187148130")]
	public Vector3 LKPPBAPFPFF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7148640", Offset = "0x7147A40", VA = "0x187148640")]
	public void NHPCNHIKLDL([In] Vector3 HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x7147D90", Offset = "0x7147190", VA = "0x187147D90")]
	public Vector3 JPHMGFCPABP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7146A20", Offset = "0x7145E20", VA = "0x187146A20")]
	public void DAANEGOANMO([In] Vector3 HCPAOILCJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct CDGPDNONDOE : IEquatable<CDGPDNONDOE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	private ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7143D10", Offset = "0x7143110", VA = "0x187143D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	private BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x71447C0", Offset = "0x7143BC0", VA = "0x1871447C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	private GMFLKOCNIBP HFLOICNEGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7144760", Offset = "0x7143B60", VA = "0x187144760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	public CDGPDNONDOE(AOMADBOBEAJ FCHDAFNGEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7143BE0", Offset = "0x7142FE0", VA = "0x187143BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x71446D0", Offset = "0x7143AD0", VA = "0x1871446D0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7143AB0", Offset = "0x7142EB0", VA = "0x187143AB0", Slot = "4")]
	public bool Equals(CDGPDNONDOE BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7144850", Offset = "0x7143C50", VA = "0x187144850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x7144590", Offset = "0x7143990", VA = "0x187144590")]
	public void DEEJPFOJNIO(string ODCOLEGLGGM, NLMIKCIECCN LBFGHBIKLLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class ECJJNIMMFDD
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private struct FABLMHKLHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Guid FNECNONNEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ACACOCIJLNM BCMEGLPHCDP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private struct ACACOCIJLNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int HCPAOILCJCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int DFBOLFEDINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int DPKEOHFGHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int GPDLOLONICA;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x71433D0", Offset = "0x71427D0", VA = "0x1871433D0")]
		public bool DPMMIIIHBIE([Out] OKLHMMELOIN LLAEJMCGGGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7143460", Offset = "0x7142860", VA = "0x187143460")]
		public ACACOCIJLNM(OKLHMMELOIN LLAEJMCGGGB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x714AC60", Offset = "0x714A060", VA = "0x18714AC60")]
	public static Guid HOHBDIFGAEN(this OKLHMMELOIN LLAEJMCGGGB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x714AC40", Offset = "0x714A040", VA = "0x18714AC40")]
	public static bool AKKMBIMBIKA(this Guid FNECNONNEND, [Out] OKLHMMELOIN LLAEJMCGGGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal static class NCFIHLNJBHD
{
	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x7154870", Offset = "0x7153C70", VA = "0x187154870")]
	public static BDCOBEDGNIJ JGPGGCBIIEI(this AOMADBOBEAJ LPMIIFILJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x7154900", Offset = "0x7153D00", VA = "0x187154900")]
	public static HIKOLNFHCME OABPBFKKCKF(this AOMADBOBEAJ LPMIIFILJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x7154580", Offset = "0x7153980", VA = "0x187154580")]
	public static EntityManager BADBCGGHDNP(this AOMADBOBEAJ LPMIIFILJPI)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x31CD3A0", Offset = "0x31CC7A0", VA = "0x1831CD3A0")]
	internal static bool HLMFDMIOAKN<T>(this AOMADBOBEAJ LPMIIFILJPI, bool GLCFJLGEAHE) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x7154680", Offset = "0x7153A80", VA = "0x187154680")]
	public static bool FEIDJIJMOAD(this AOMADBOBEAJ LPMIIFILJPI, HFFALABIPJN LKGPHBHEBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x31CD070", Offset = "0x31CC470", VA = "0x1831CD070")]
	public static bool EKKOKEPKAJE<T>(this AOMADBOBEAJ LPMIIFILJPI) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x31CD2F0", Offset = "0x31CC6F0", VA = "0x1831CD2F0")]
	public static bool GLHBFCEJHGK<T>(this AOMADBOBEAJ LPMIIFILJPI) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x31CBB30", Offset = "0x31CAF30", VA = "0x1831CBB30")]
	[ADHNBKELKMB]
	public static T EDELMAPPNJH<T>(this AOMADBOBEAJ LPMIIFILJPI) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x31C9B20", Offset = "0x31C8F20", VA = "0x1831C9B20")]
	[ADHNBKELKMB]
	public static T CJDBINOFMLJ<T>(this AOMADBOBEAJ LPMIIFILJPI) where T : struct, IComponentData
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CMJCBAIFNMJ
{
	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EMIHMJLPOPB(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AFMGDGOCNFC(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task MCHFAMHBCDI(OBGLMNKFCEH NCHBKHMIMGJ);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LMBNOPAOPLN(AOMADBOBEAJ FCHDAFNGEPF, [Out] Guid PAAPGLCPIFD);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid LMNNOFDKPAO(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PHFFEBLFKAB(AOMADBOBEAJ FCHDAFNGEPF, Guid PAAPGLCPIFD);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool AHIAJHBJNLH(AOMADBOBEAJ FCHDAFNGEPF, [Out] Guid DOKBOJKBDAO);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Guid FMIOCFNJJBK(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MDJEJOIMBCB(AOMADBOBEAJ FCHDAFNGEPF, Guid DOKBOJKBDAO);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IGAOFKMFHBI(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task ADHHBDOBAFB(AOMADBOBEAJ FKLPGABAEFE, AOMADBOBEAJ AMMKPAGCALK);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface MABCOICGAFC
{
	[Cpp2IlInjected.Token(Token = "0x17000179")]
	Guid HLBMNOLFAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPNLPEHDEDA(NativeList<Guid> LLOLABKOJNM, NativeList<Guid> ECPIKMGHBDF, NativeList<FixedString64Bytes> EJICFJNMFNC);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NFNOBECIPIP
{
	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KFMPDFGLPLC(List<AOMADBOBEAJ> EMNOCMKKCJI);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POICINAFKLP(List<AOMADBOBEAJ> FEEAEGFDPMF);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JABMGICKJID(AOMADBOBEAJ ODACIIAKALC);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KLKJHFFOEPK(AOMADBOBEAJ ODACIIAKALC);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KGKAFBMNAML(AOMADBOBEAJ ODACIIAKALC);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int NJBDJOHKKCO(AOMADBOBEAJ ODACIIAKALC);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void POBKOJFCDII(AOMADBOBEAJ ODACIIAKALC, int EOMBDLJNDJM);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AOMADBOBEAJ OCJFMFBABEA(AOMADBOBEAJ HIMLPKFPGPM);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int CBIFPBHEAIB(AOMADBOBEAJ HIMLPKFPGPM);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LMPHHBEGMEI(AOMADBOBEAJ HIMLPKFPGPM, int GDMAHKDBBFD);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int JIJKCBBMAEJ(AOMADBOBEAJ HIMLPKFPGPM);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ADBLGCODDLH(AOMADBOBEAJ HIMLPKFPGPM, int COMOKAGBCJL);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OFBEEFOJEJM(AOMADBOBEAJ NKCFJFCLAAC);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LENMGCOOBML(AOMADBOBEAJ FCHDAFNGEPF, bool IAPHKFNBOAL);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CICCBOPAEKK(AOMADBOBEAJ[] LGIFMBNGOEI, bool IAPHKFNBOAL);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DMPFHFAAJAJ
{
	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OKLHMMELOIN[] ODFAOKEAPOI(string LJAGHAHCFHJ, OBGLMNKFCEH AAAEKNFCKDF, bool EHLPHGHLKMD = false);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGFBOEEMKGN(string JIMNKEIAGEA, OKLHMMELOIN[] GNENNFCAIBN);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface OEHGMMFAPNP
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<AOMADBOBEAJ, AOMADBOBEAJ> HAOFIBFJCEP;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<AOMADBOBEAJ, AOMADBOBEAJ> IEHILDJFPDL;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<AOMADBOBEAJ, AOMADBOBEAJ, AOMADBOBEAJ> KKPBHHIENGO;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<AOMADBOBEAJ> LBFIDMDEDNM;

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MIPFBDPLNGA(AOMADBOBEAJ FCHDAFNGEPF, AOMADBOBEAJ GPBLDNKFEEL);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AOMADBOBEAJ IPKCAKLBOHP(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DFMAFHIFHME APNNMGPAOCA(AOMADBOBEAJ FCHDAFNGEPF, Allocator MEFLJHAPKJF);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "11")]
	AOMADBOBEAJ ONKCNBNFPJF(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EBLHMMDMGIN(AOMADBOBEAJ FCHDAFNGEPF, Vector3 GENECOFMCJE, Quaternion MADPMBLAMGB);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DLKLHHNNIPH(AOMADBOBEAJ FCHDAFNGEPF, float KFDBLNFGAEG);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool ABIDKPFCGFP(AOMADBOBEAJ FCHDAFNGEPF, [Out] AOMADBOBEAJ AMMKPAGCALK);

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool FCONHMMBJNB(AOMADBOBEAJ FCHDAFNGEPF, [Out] RigidTransform KCDLNGOCKED);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool KBJEDHECMEE(AOMADBOBEAJ FCHDAFNGEPF, [Out] float PICJEGMALHI);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 AKDJOPFFOOC(IDIJKEEILII ECHMDKMCJFA);

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion FPPKFGPAPMC(IDIJKEEILII ECHMDKMCJFA);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class IAIOHGNGOKF
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FMCBKOLALGM
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	object JEBOAFAOOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKNAOEPPDCB(DFMAFHIFHME LGIFMBNGOEI);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface KJOOLLFMMEE
{
	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOJANFBBEAF(AOMADBOBEAJ NCHBKHMIMGJ, OEDMJPMNCAI LMACEGOCAOG);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMAAKNPLGLA(OEDMJPMNCAI LMACEGOCAOG);

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HMCOJFBOPJH(AOMADBOBEAJ FCHDAFNGEPF, [Out] OEDMJPMNCAI EHOJDCBOGGE);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct IOJECONGCHP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly string LJAGHAHCFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly T EKFBHIJFHMA;

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x43CB530", Offset = "0x43CA930", VA = "0x1843CB530")]
	public IOJECONGCHP(T EKFBHIJFHMA, [Optional][CallerMemberName] string LJAGHAHCFHJ)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly IOJECONGCHP<int> BFNHNOKJFNL;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly IOJECONGCHP<int> IMGDCCGKNDO;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly IOJECONGCHP<int> HGIECJKJNCG;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum MMLAPBFKPCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class FAJNDAAAONG
{
	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x114F170", Offset = "0x114E570", VA = "0x18114F170")]
	public static bool KJHIOLPIMDP(this MMLAPBFKPCJ MPLALBADMNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x114F180", Offset = "0x114E580", VA = "0x18114F180")]
	public static bool KMDCOOCPDDK(this MMLAPBFKPCJ MPLALBADMNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x291FCB0", Offset = "0x291F0B0", VA = "0x18291FCB0")]
	public static bool PEENPGKNEPA(this MMLAPBFKPCJ MPLALBADMNL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CDKNAEBHMJK
{
	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	bool AHBOFIGJIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[ServiceLifetime(Lifetime.Application)]
public interface BFFMIOLCGHL
{
	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	MMLAPBFKPCJ DGHAGDGNLDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	MMLAPBFKPCJ EIBGMEMLIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	MMLAPBFKPCJ FODEDAJPPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	MMLAPBFKPCJ JFAPBEGNFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	MMLAPBFKPCJ DHLMAHAKPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	MMLAPBFKPCJ FPJIIJPNBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	MMLAPBFKPCJ MGCICBFCJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	MMLAPBFKPCJ OCDGEJKEOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	MMLAPBFKPCJ IFICKKCJGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	MMLAPBFKPCJ KDPJIFBNJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	MMLAPBFKPCJ LHCGHGPAKJC
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	MMLAPBFKPCJ DHBEOEPEHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	MMLAPBFKPCJ LCBCKPKDEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	MMLAPBFKPCJ BMJNIBCIHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	MMLAPBFKPCJ EDNGABOLCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	MMLAPBFKPCJ LLOOKJCLEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	MMLAPBFKPCJ JMDFFHNFLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int AFFELPLAAIM(IOJECONGCHP<int> JAGODFHKNAI);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LBKPIKLOHEL
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event EIGPLOHFJIE.IHPPHEBNPGO LIFIMEOJLBF;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AOMADBOBEAJ IKGNBNHDPIJ(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HBENGLDCHIG(List<AOMADBOBEAJ> FEEAEGFDPMF);

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GPGJJHENEFG BOFJPHPIKFL(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AMBHKDAGMOD(IEnumerable<AOMADBOBEAJ> AMJHMKCHGGL);

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GPGJJHENEFG DFGEFBAJBFE(AOMADBOBEAJ AMMKPAGCALK, AOMADBOBEAJ DOELFDCMLHC, bool BLKJMBEKCNG, AOMADBOBEAJ MGPMAFDHMLC);

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AOMADBOBEAJ GIBBFBNMFJB(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KAPGKFEMBMB(AOMADBOBEAJ FCHDAFNGEPF, AOMADBOBEAJ AMMKPAGCALK, bool HPLPJGIMICM = false);

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DPNMANIEAHH(AOMADBOBEAJ FCHDAFNGEPF, AOMADBOBEAJ AMMKPAGCALK);

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool IMNLKFCMNJO(AOMADBOBEAJ LBLLADLLFAL, AOMADBOBEAJ OAGKEILAOIM);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int GDHBDDIKBFO(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DFMAFHIFHME AGIBGGHLLGF(AOMADBOBEAJ NKCFJFCLAAC);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<AOMADBOBEAJ> IDBDCGBKBKJ(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool CBOBFOIKELL(AOMADBOBEAJ FCHDAFNGEPF, AOMADBOBEAJ GCCEMINCEKN);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<AOMADBOBEAJ> CMMCKFKJOEL(AOMADBOBEAJ FCHDAFNGEPF, bool MOICAPIHCAB = false);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool BKBJHNPHFPD(AOMADBOBEAJ FCHDAFNGEPF, AOMADBOBEAJ IFFJEHOBPPL);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "17")]
	AOMADBOBEAJ DNGPLGBHAAK(AOMADBOBEAJ MGPMAFDHMLC, AOMADBOBEAJ FGHGKOGCAPJ);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool KNGJIEIIDJH(AOMADBOBEAJ MGPMAFDHMLC, AOMADBOBEAJ FGHGKOGCAPJ, [Out] AOMADBOBEAJ LCEPJCKONMJ);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "19")]
	AOMADBOBEAJ HLFBLKHFGGA(AOMADBOBEAJ[] LGIFMBNGOEI);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class NIGECPNJFHG
{
	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7154D00", Offset = "0x7154100", VA = "0x187154D00")]
	public static List<AOMADBOBEAJ> HBENGLDCHIG(this LBKPIKLOHEL BDGKALLONKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7154E00", Offset = "0x7154200", VA = "0x187154E00")]
	public static bool HIBADHJGNMI(this LBKPIKLOHEL BDGKALLONKG, AOMADBOBEAJ FCHDAFNGEPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IHDKKIEEAME
{
	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PDKELJPCIHO IOPJJIGFOAB(AOMADBOBEAJ ODACIIAKALC);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIJJJKHNMHI(AOMADBOBEAJ ODACIIAKALC, PDKELJPCIHO PAABJLCGFJP);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AJNCBKMHHPM(AOMADBOBEAJ ODACIIAKALC);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AAIJBLJJFAH(AOMADBOBEAJ ODACIIAKALC, bool HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string[] JFFPLONDNAD(AOMADBOBEAJ ODACIIAKALC);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DENJCJPDEHE(AOMADBOBEAJ ODACIIAKALC, IEnumerable<string> KDNNPAMIKAL);

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string[] GJKNMOAAEDH(AOMADBOBEAJ ODACIIAKALC);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PJBBFOFLELD(AOMADBOBEAJ ODACIIAKALC, IEnumerable<string> KDNNPAMIKAL);

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string[] ONBGCBCOLCN(AOMADBOBEAJ ODACIIAKALC);

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DLABEIDLMMH(AOMADBOBEAJ ODACIIAKALC, IEnumerable<string> KDNNPAMIKAL);

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] PPHIANAKOKH(AOMADBOBEAJ ODACIIAKALC);

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OCGIGFFILEN(AOMADBOBEAJ ODACIIAKALC, IEnumerable<string> KDNNPAMIKAL);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BFLECHCPPBP(AOMADBOBEAJ ODACIIAKALC, AOMADBOBEAJ FFBDHANOEPC);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BMGOFICAPAD
{
	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	bool PGPDJFAPNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	bool DJGOHKMHLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	bool IEEEIJHHBPH
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GPAICHKOAJA
{
	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GIKKDKAIKAJ([In] float3 KJLHJAKALDP, [In] float3 LIDLBHGKPBN, float KIECEDCFNCJ, [Out] FNFIDLOHCEN PCLFEHMMPAF, [Out] AOMADBOBEAJ GNDJONLPBDP);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CHLICCMJDNB
{
	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIKKDKAIKAJ([In] NativeArray<Entity> NNNALCFDKMF, [In] float3 KJLHJAKALDP, [In] float3 LIDLBHGKPBN, [In] NativeArray<FNFIDLOHCEN> AHAKOFLCKKG);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct AOADLPBBAMC : BCFJABJPHMG, IEquatable<AOADLPBBAMC>
{
	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public int MCCLHKLCIBG
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xD2A260", Offset = "0xD29660", VA = "0x180D2A260", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public int FALKEIDFDBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x293B520", Offset = "0x293A920", VA = "0x18293B520", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x634DE50", Offset = "0x634D250", VA = "0x18634DE50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7143750", Offset = "0x7142B50", VA = "0x187143750", Slot = "8")]
	public bool Equals(AOADLPBBAMC BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x71437A0", Offset = "0x7142BA0", VA = "0x1871437A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct FNFIDLOHCEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float OMAHLMEHPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float3 ADDIIGBEIBA;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CFDMJAHCMOO
{
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ENHHHCAGNII
{
	[Cpp2IlInjected.Token(Token = "0x17000192")]
	BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	DPBGOKHEOOH MNPEGNPFGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<DFMAFHIFHME, NativeArray<NABGOBFPKKK>> KLPDDCAKPBL;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<DFMAFHIFHME> ADDMAFPCBCN;

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BFFJDHLHCFI HIBPFBHOELC(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NABGOBFPKKK DIBMPFCPLIP(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EMOBGIHOLPD(OKLHMMELOIN LLAEJMCGGGB, OGNDGMPNNMG HJELLPHACAI);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OPPNNHJKOEH(OKLHMMELOIN[] GNENNFCAIBN, GameObject MCCIFMIMANN);

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OBGLMNKFCEH FMMMGJGJKLB(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IDMOLJNIFCF(AOMADBOBEAJ FCHDAFNGEPF, [Out] Transform KELFOJAPBEF);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HNINFNKEODO(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KKKOFEFALFA(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AOMADBOBEAJ HPFIBDBFOPH(OKLHMMELOIN LLAEJMCGGGB);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool GBAMDHMCOOI(OKLHMMELOIN LLAEJMCGGGB, [Out] AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "16")]
	OKLHMMELOIN IMJICPEEANF(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "17")]
	DFMAFHIFHME HPFIBDBFOPH(NativeArray<OKLHMMELOIN> LLAEJMCGGGB, Allocator MEFLJHAPKJF);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "18")]
	DFMAFHIFHME GHIKIPBNMBC(NABGOBFPKKK FPLGHFJHKOE, int ABPDJOGPHFP, Allocator MEFLJHAPKJF);

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "19")]
	DFMAFHIFHME AJFJAMIIFHH(NativeArray<OKLHMMELOIN> LLAEJMCGGGB, NativeArray<IPPNMBPPJNK> KAMLINHNLGB, Allocator MEFLJHAPKJF);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "20")]
	OKLHMMELOIN[] ODFAOKEAPOI(string JIMNKEIAGEA, OBGLMNKFCEH AAAEKNFCKDF, bool EHLPHGHLKMD);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AGFBOEEMKGN(string JIMNKEIAGEA, OKLHMMELOIN[] GNENNFCAIBN);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	OBGLMNKFCEH HOMJCOAMLDL(NABGOBFPKKK FPLGHFJHKOE, bool KCOCNFIFJKN);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	OBGLMNKFCEH HOMJCOAMLDL(NABGOBFPKKK FPLGHFJHKOE);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	OBGLMNKFCEH FGAGAFNLGBK(NABGOBFPKKK FPLGHFJHKOE);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	OBGLMNKFCEH FIPNPIAPFPB(NABGOBFPKKK FPLGHFJHKOE);

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "26")]
	OBGLMNKFCEH JKOHBKEEEHJ(OKLHMMELOIN LLAEJMCGGGB, NABGOBFPKKK FPLGHFJHKOE);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "27")]
	CMDBFBNDMHD JEMMLPOPHJF();

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "28")]
	EIGHLLMDFND PKEDGPPACCF();

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "29")]
	MFNMJKMECLC FBJNFLMOIBL(LHOIJIFDHFN IKGKPGDNGIC);

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KPGBJGMKNDM(DFMAFHIFHME LGIFMBNGOEI);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void DNAOJJGPLEN(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void OGPNPKOAJOH(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void KPGBJGMKNDM(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void FCFKBCEONEL(AOMADBOBEAJ LGIFMBNGOEI);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool CIJIFFFDDNM(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "36")]
	DFMAFHIFHME JKCIBCGJAHC(DFMAFHIFHME HGCKHIABLKB, Allocator MEFLJHAPKJF);

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool BEGHCPGHHPC(AOMADBOBEAJ FCHDAFNGEPF);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class EGJHMFDFJGG
{
	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x714B270", Offset = "0x714A670", VA = "0x18714B270")]
	public static void KKKOFEFALFA(this ENHHHCAGNII LBFGHBIKLLL, OGNDGMPNNMG HJELLPHACAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x714B160", Offset = "0x714A560", VA = "0x18714B160")]
	public static OBGLMNKFCEH FNJMLFIEANO(this ENHHHCAGNII LBFGHBIKLLL, LocalId FCHDAFNGEPF)
	{
		return default(OBGLMNKFCEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x714B190", Offset = "0x714A590", VA = "0x18714B190")]
	public static OBGLMNKFCEH FNJMLFIEANO(this ENHHHCAGNII LBFGHBIKLLL, OKLHMMELOIN LLAEJMCGGGB)
	{
		return default(OBGLMNKFCEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x714B160", Offset = "0x714A560", VA = "0x18714B160")]
	public static AOMADBOBEAJ HPFIBDBFOPH(this ENHHHCAGNII LBFGHBIKLLL, LocalId FCHDAFNGEPF)
	{
		return default(AOMADBOBEAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x714B1F0", Offset = "0x714A5F0", VA = "0x18714B1F0")]
	public static OKLHMMELOIN IMJICPEEANF(this ENHHHCAGNII LBFGHBIKLLL, LocalId FCHDAFNGEPF)
	{
		return default(OKLHMMELOIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x714AE00", Offset = "0x714A200", VA = "0x18714AE00")]
	public static bool BEGHCPGHHPC(this ENHHHCAGNII LBFGHBIKLLL, OKLHMMELOIN LLAEJMCGGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x714AE70", Offset = "0x714A270", VA = "0x18714AE70")]
	public static CMDBFBNDMHD BLOOJPFILFJ(this ENHHHCAGNII LBFGHBIKLLL, RigidTransform CFHDOPANNJD)
	{
		return default(CMDBFBNDMHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x714AD00", Offset = "0x714A100", VA = "0x18714AD00")]
	public static MFNMJKMECLC ALKGKIHODMI(this ENHHHCAGNII LBFGHBIKLLL, LHOIJIFDHFN AOPKOLCMLOH, RigidTransform CFHDOPANNJD)
	{
		return default(MFNMJKMECLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x714B2F0", Offset = "0x714A6F0", VA = "0x18714B2F0")]
	public static EIGHLLMDFND OKOMDJKAJPG(this ENHHHCAGNII LBFGHBIKLLL, RigidTransform CFHDOPANNJD)
	{
		return default(EIGHLLMDFND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x714AF60", Offset = "0x714A360", VA = "0x18714AF60")]
	private static void CJLKGFEIMGL(OBGLMNKFCEH PGOALMCALHL, RigidTransform CFHDOPANNJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PNAJDFKGGGF
{
	[Cpp2IlInjected.Token(Token = "0x17000194")]
	bool KDJFFBGECDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	AOMADBOBEAJ JEOCGCAAEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	OBGLMNKFCEH LJKLPIGDBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event DFPMNMMNEEP OJOJPHDDHLK;

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AOMADBOBEAJ DNGPLGBHAAK(AOMADBOBEAJ MGPMAFDHMLC, AOMADBOBEAJ FGHGKOGCAPJ);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KNGJIEIIDJH(AOMADBOBEAJ MGPMAFDHMLC, AOMADBOBEAJ FGHGKOGCAPJ, [Out] AOMADBOBEAJ LCEPJCKONMJ);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GBFDEAKFHID();

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GIEAPFEBFHP();

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OGDOFMLLJFH(AOMADBOBEAJ MGPMAFDHMLC);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CDFDDEILOKO(AOMADBOBEAJ MGPMAFDHMLC);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public delegate void DFPMNMMNEEP(OBGLMNKFCEH NOOOGJCHBJA, OBGLMNKFCEH MICJBKMALDJ);
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class HGPCHJFNAMD
{
	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x714EAA0", Offset = "0x714DEA0", VA = "0x18714EAA0")]
	public static bool DIHPDFDBMMO(this PNAJDFKGGGF JOBIFPGHLMO, OBGLMNKFCEH MGPMAFDHMLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x714EAF0", Offset = "0x714DEF0", VA = "0x18714EAF0")]
	public static bool FPLCIHMJDNE(this PNAJDFKGGGF JOBIFPGHLMO, AOMADBOBEAJ MGPMAFDHMLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x714EBD0", Offset = "0x714DFD0", VA = "0x18714EBD0")]
	public static bool OHKKFCECPIE(this PNAJDFKGGGF JOBIFPGHLMO, AOMADBOBEAJ MGPMAFDHMLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KCIMBNFCFNI
{
	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IIJKCEAIJAF(OBGLMNKFCEH PGOALMCALHL, AEMLLOGJEJB HBOEBNCIJMJ, List<OBGLMNKFCEH> ECLEOKJMKCI);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int OCMBMPGGFFC(OBGLMNKFCEH PGOALMCALHL, AEMLLOGJEJB HBOEBNCIJMJ);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CKBBHFPCNFB(OBGLMNKFCEH PGOALMCALHL, List<OBGLMNKFCEH> ECLEOKJMKCI);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GLPGCKAPGKN(OBGLMNKFCEH JIIJJAKJBGA, OBGLMNKFCEH MGPMAFDHMLC, AEMLLOGJEJB HBOEBNCIJMJ);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OBGLMNKFCEH DOOPHGKDJMN(OBGLMNKFCEH JIIJJAKJBGA, int IIACLAMOIEE, AEMLLOGJEJB HBOEBNCIJMJ);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IICOICDCKBM(OBGLMNKFCEH JIIJJAKJBGA, OBGLMNKFCEH MGPMAFDHMLC, AEMLLOGJEJB HBOEBNCIJMJ);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FOHAGEGBJLL(OBGLMNKFCEH JIIJJAKJBGA, OBGLMNKFCEH MGPMAFDHMLC, AEMLLOGJEJB HBOEBNCIJMJ);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GFFIKIKDKOH(OBGLMNKFCEH JIIJJAKJBGA, AEMLLOGJEJB HBOEBNCIJMJ);

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IHBMJEKANAI(OBGLMNKFCEH JIIJJAKJBGA, OBGLMNKFCEH MGPMAFDHMLC, AEMLLOGJEJB HBOEBNCIJMJ);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ADFEOBJPNEB(Entity JIIJJAKJBGA, Entity MGPMAFDHMLC, AEMLLOGJEJB HBOEBNCIJMJ);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EMNBFPIFMFO(Entity JIIJJAKJBGA, AEMLLOGJEJB HBOEBNCIJMJ);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IAIAFLPCCFN(OBGLMNKFCEH MGPMAFDHMLC, AEMLLOGJEJB HBOEBNCIJMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AIKMLPAGMDA
{
	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAMPJAJMOHA(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NIDNHLHKDKP(AOMADBOBEAJ FCHDAFNGEPF, Transform KELFOJAPBEF);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DAACFAIFOBE
{
	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EOBGBOHDHDN(AOMADBOBEAJ MGPMAFDHMLC, AOMADBOBEAJ CKHGFHIFINP);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KJPJFANBFBE(AOMADBOBEAJ MGPMAFDHMLC, AOMADBOBEAJ MACMOOKCMGA);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EDEMBCJFBNN(AOMADBOBEAJ MGPMAFDHMLC, [Out] AOMADBOBEAJ AANDIGKJJCF);
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PHHFLHINHJH
{
	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGOFBKKKGJD(AOMADBOBEAJ NKCFJFCLAAC, bool HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHHHNHKCFKE(AOMADBOBEAJ NKCFJFCLAAC, bool HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPLPOBPCKPE(AOMADBOBEAJ NKCFJFCLAAC, int HCPAOILCJCB);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IDONDGIODOA
{
	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<AOMADBOBEAJ> ENIFCMCKEIB(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AOMADBOBEAJ FDMOCAOMBNP(AOMADBOBEAJ FCHDAFNGEPF, int IIACLAMOIEE);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int ADBHBCANJCO(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AHKAPNEMKGD FMEJHHNNAAD(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EILJHPNFDOO(AOMADBOBEAJ FCHDAFNGEPF, AHKAPNEMKGD OKAMEPDCJCI);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AOMADBOBEAJ JDLPJCKDPEL(AOMADBOBEAJ FCHDAFNGEPF, [Optional] float3? CPGMOBFHDAC, [Optional] quaternion? CBCAIPELAJP, [Optional] float3? BMGLFPFGJFF);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AOMADBOBEAJ NILIBGGFHJP(AOMADBOBEAJ FCHDAFNGEPF, int IIACLAMOIEE, [Optional] float3? CPGMOBFHDAC, [Optional] quaternion? CBCAIPELAJP, [Optional] float3? BMGLFPFGJFF);

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FOCOPELHOHD(AOMADBOBEAJ FCHDAFNGEPF, int IIACLAMOIEE);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JBIMMBEDLEI(AOMADBOBEAJ FCHDAFNGEPF);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AKBDDLEDNAN
{
	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHPEAFGGDEP();

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKPPIFGKHCP();

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBJNIMIBMDE();

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IBJJOOLNHDG();

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OCPIAAOHCJA();

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LDCHEPLKGCN();

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DAEPKPKAOON();

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HNALHFCHAAO();

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FAFFPLGFHJA();

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LLEKGMBJANF();

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IKPBFBEOOMF();

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ODKLDIGKFGP();

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FDAPFDKIIBH();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface NEJHFIGADHH
{
	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DDOAMEHEOCC(AOMADBOBEAJ MGPMAFDHMLC, [Out] int JIIJJAKJBGA);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBDIFLDLJBB(AOMADBOBEAJ MGPMAFDHMLC, int JIIJJAKJBGA);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AHCGOHAMHKH(AOMADBOBEAJ MGPMAFDHMLC, bool PHMAKHCONOO);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LOAKGCJFLDP(AOMADBOBEAJ MGPMAFDHMLC, float MLDNPEFOAAN, float AHIOLMAIBKM, float OCIGHIBLICO);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NBDKJPJJOFI(AOMADBOBEAJ FCHDAFNGEPF, [Out] float AHIOLMAIBKM, [Out] float OCIGHIBLICO);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HHIPOBKCOGN(AOMADBOBEAJ MGPMAFDHMLC, float3 CPGMOBFHDAC, quaternion CBCAIPELAJP);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EFCLCIGGPNL(AOMADBOBEAJ MGPMAFDHMLC, [Out] float3 CPGMOBFHDAC, [Out] quaternion CBCAIPELAJP);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DLPNBPNPKAL(AOMADBOBEAJ MGPMAFDHMLC);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LHAACOMCFDP
{
	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KLJDAAJFAAO(Entity DGPOIOLCNNN);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIIPBINJHHJ(Entity DGPOIOLCNNN, [In] float3 HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 ODGDBOLCFKP(Entity DGPOIOLCNNN);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CAAHAACMFLG(Entity DGPOIOLCNNN, [In] quaternion HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion OEJOBLFOIGD(Entity DGPOIOLCNNN);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LECANOHPBBG(Entity DGPOIOLCNNN, [In] float3 CPGMOBFHDAC, [In] quaternion CBCAIPELAJP);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ACPFEPNGEGG(Entity DGPOIOLCNNN, [Out] float3 CPGMOBFHDAC, [Out] quaternion CBCAIPELAJP);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ACPFEPNGEGG(Entity DGPOIOLCNNN, [Out] RigidTransform HIMFFIEJFLL);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IFEJGOPGAPH(Entity DGPOIOLCNNN, [In] float3 CPGMOBFHDAC, [In] quaternion CBCAIPELAJP);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FADBEBNCFBD(Entity DGPOIOLCNNN, [Out] float3 CPGMOBFHDAC, [Out] quaternion CBCAIPELAJP);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FADBEBNCFBD(Entity DGPOIOLCNNN, [Out] RigidTransform HIMFFIEJFLL);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 KKMJLFHDCIF(Entity DGPOIOLCNNN);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FMALOOFEHGD(Entity DGPOIOLCNNN, [In] float3 HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KGNIFFLLGHD(Entity DGPOIOLCNNN, float HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	float EDPMFGPKPJH(Entity DGPOIOLCNNN);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NHPCNHIKLDL(Entity DGPOIOLCNNN, [In] float3 HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 LKPPBAPFPFF(Entity DGPOIOLCNNN);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KIIBDPKNIMB(Entity DGPOIOLCNNN, [In] float3 HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 EOBOLGCGPNM(Entity DGPOIOLCNNN);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IFNFJNKOIAD(Entity DGPOIOLCNNN, [In] quaternion HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	quaternion PCBKNLHCLBH(Entity DGPOIOLCNNN);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float3 OHJMOEOCGNO(Entity DGPOIOLCNNN);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FEGNNAILMCG(Entity DGPOIOLCNNN, [In] float3 HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MBJIMPBEKOL(Entity DGPOIOLCNNN, float HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "24")]
	float HPICLHGKNNM(Entity DGPOIOLCNNN);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void DAANEGOANMO(Entity DGPOIOLCNNN, [In] float3 HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "26")]
	float3 JPHMGFCPABP(Entity DGPOIOLCNNN);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NFMFOMBABBP(Entity DGPOIOLCNNN, [Out] float4x4 KAFLPFIJPOD);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CFJJIAMIEGA(Entity DGPOIOLCNNN, [In] float4x4 KAFLPFIJPOD);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void LGJLHLPGNJG(Entity DGPOIOLCNNN, [Out] float4x4 KAFLPFIJPOD);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool IDMOLJNIFCF(Entity DGPOIOLCNNN, [Out] Transform KELFOJAPBEF);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void DDPGDBLOJNA(Entity DGPOIOLCNNN);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void DOJJHOGKDGK(Entity DGPOIOLCNNN, Entity DKEOBCPHOMK, Entity NBJNONHAKJK);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class GMPKANDAICE
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DDGEDIGLLLM
{
	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHCCKNJGCDH(bool GMHKIAOJLFJ);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface GMFLKOCNIBP
{
	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FANJLIIENOL(AOMADBOBEAJ ODACIIAKALC, IEnumerable<string> KDNNPAMIKAL);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PAJINBOIKAB(AOMADBOBEAJ ODACIIAKALC, IEnumerable<string> KDNNPAMIKAL);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMIBFFOBEIG(AOMADBOBEAJ ODACIIAKALC, params string[] KDNNPAMIKAL);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INLAKDCDCGL(AOMADBOBEAJ ODACIIAKALC, params string[] KDNNPAMIKAL);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IJJOFOBJFMI(AOMADBOBEAJ ODACIIAKALC, params string[] KDNNPAMIKAL);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CFOKLMKNPMG(AOMADBOBEAJ ODACIIAKALC, params string[] KDNNPAMIKAL);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int NDFKOFGKOEE(AOMADBOBEAJ ODACIIAKALC);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int GMDDPNDFAKO(AOMADBOBEAJ ODACIIAKALC);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int KHOKGKPLCPM(AOMADBOBEAJ ODACIIAKALC);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MGDEDEOGEHI(AOMADBOBEAJ ODACIIAKALC, ICollection<string> LBOPGIPGBPO);

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KPCKBHBKKJE(AOMADBOBEAJ ODACIIAKALC);

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HJJFEIBHAGK(AOMADBOBEAJ ODACIIAKALC, ICollection<string> LBOPGIPGBPO);

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IIHFFADOIKO(AOMADBOBEAJ ODACIIAKALC, string ODCOLEGLGGM);

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OMMDMBFNDFM(string ODCOLEGLGGM, NLMIKCIECCN EGIGBAJDCKH);

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AOMADBOBEAJ DFGCHPCDFMH(string ODCOLEGLGGM);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HFIBJFNLJBA(string ODCOLEGLGGM, NLMIKCIECCN EGIGBAJDCKH);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DEEJPFOJNIO(AOMADBOBEAJ LNGOEEENHKB, string ODCOLEGLGGM, NLMIKCIECCN EGIGBAJDCKH);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool FAAOLGNBINE();

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MLFCEIEMPPB(IEnumerable<string> KDNNPAMIKAL);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface POLOFLBLMME
{
	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World BKLBNOPDLFF(string NDLIOHLNLCG = "Main");

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World IOKOOADMLAF(string NDLIOHLNLCG = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World CKPHLJCBLGO(string NDLIOHLNLCG = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World KNELLCIHMIE(string NDLIOHLNLCG = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HIKOLNFHCME
{
	[Cpp2IlInjected.Token(Token = "0x17000197")]
	World IGPLALDNCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	World GDJLDLMGIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	EntityManager BADBCGGHDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	bool MAIEPNIBMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase ENMNAGFMGMO(Type IFBDJLKPHIG);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class NEOKNGINGDA
{
	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x7154C70", Offset = "0x7154070", VA = "0x187154C70")]
	public static ComponentSystemBase NODOOPOOJHC(this World GPOOJLKEOLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x31D6010", Offset = "0x31D5410", VA = "0x1831D6010")]
	public static T ENMNAGFMGMO<T>(this HIKOLNFHCME EJMHJCFOOGD) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface APHFOFIBKLC
{
	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIOAADEAMFL(NativeListAsync<Entity> LPNLIFMILCP);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJJHNMHGDHO(LDOABBHIDMB EOJGGDJACIF);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DIBDOAAIGCG(NativeListAsync<Entity> PEOBDDPBLEF, bool HFMGCPKDCHN);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NDMEFMFBEEF();

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MLGLCBHNNOC(Entity NIMLNKDMKHI);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface JHCENPNMHDD
{
	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HFLHLLIMHPI(Collider DALFGDJANJG, [Out] GBFDJIMHAEC ADAFMLMAFML);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EKPNJFGMKPA
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider JIILNNICDCK(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject GDBBFOOGJKN(AOMADBOBEAJ PKJFKMIIHFK, GameObject FIDMHGJFAFJ, Vector3 ENJPHPPLHAI, Quaternion HONHOJHJMHK);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFIKJCGEGIH(GameObject DALFGDJANJG);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider OLCPMEIGNGL<TCollider>(GameObject BKBBPNCOPGE) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EOILNNICLGO(Collider DALFGDJANJG);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject LKNOEDHFGCK<TCollider>(string LJAGHAHCFHJ) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CNFFBLBPPPF HEMNBGPEDBD(AOMADBOBEAJ LNNEFOKCEPB, AOMADBOBEAJ GLNKDNKOIMH, LHOIJIFDHFN GGLGEJGEBBN, float3 BPKDIKELNLL, quaternion LMNBGCBJIGA, float3 CLMFONLEMEG);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FKNHNFEJNCB(AOMADBOBEAJ FCHDAFNGEPF, [Out] CNFFBLBPPPF DALFGDJANJG);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KFNFNJLHCHG(AOMADBOBEAJ FCHDAFNGEPF, [Out] AOMADBOBEAJ NIMLNKDMKHI);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public enum MEOMKBJJNBF
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface KJLMBHJGPEE
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public struct EKBNPFAOIIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int GGLGEJGEBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public GameObject FIDMHGJFAFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOJHFLHFOOE(AOMADBOBEAJ FCHDAFNGEPF, IEEIAAPPNKJ DGNGLKHPGLN, bool DODPCDHEDLD, LAKABHFBLCH AFOLPHGJKGF);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MEHEALNKBOD(AOMADBOBEAJ FCHDAFNGEPF, IEEIAAPPNKJ DGNGLKHPGLN, bool DODPCDHEDLD, bool NGGEDPMBEHP, bool FFLIGOJKIIB);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NMKEKCJFJFC CBGPFEJOLIE(AOMADBOBEAJ NIMLNKDMKHI, List<AOMADBOBEAJ> DJCEPCOIOGH);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CNFFBLBPPPF ENAKMJOADMM(GameObject HPNKDKHKFNL, GameObject IEPOKENOFDD);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ENBOBDFAKAI(GameObject HPNKDKHKFNL, List<GameObject> CMABIAAOONP);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JLJNGGKALOD(GameObject IEPOKENOFDD);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T OLCPMEIGNGL<T>(GameObject BKBBPNCOPGE) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EOILNNICLGO(Collider DALFGDJANJG);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject KKNJLBHNDMC<T>(string LJAGHAHCFHJ) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PJDLIIKKHPI(Collider DALFGDJANJG, [Out] AOMADBOBEAJ JIIJJAKJBGA);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EAFLACGJOBN(AOMADBOBEAJ FCHDAFNGEPF, [Out] GBFDJIMHAEC ADAFMLMAFML);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<MEOMKBJJNBF> DMPOJHLHECG(Allocator MEFLJHAPKJF = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] NAGFJAGABFJ();

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int DODBFKMNMHO(IEEIAAPPNKJ DGNGLKHPGLN);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "14")]
	string JNNIKDKEEFE(IEEIAAPPNKJ DGNGLKHPGLN);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GNECANFGJMN
{
	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJNGPMHDKCP(AOMADBOBEAJ FCHDAFNGEPF, AOMADBOBEAJ HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODKJMPDFDBB(AOMADBOBEAJ FCHDAFNGEPF, AOMADBOBEAJ HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GDHBDDIKBFO(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AOMADBOBEAJ FPHHEOEFCOH(AOMADBOBEAJ FCHDAFNGEPF, int IIACLAMOIEE);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DFMAFHIFHME GIIKPDIHJKD(AOMADBOBEAJ FCHDAFNGEPF, Allocator MEFLJHAPKJF = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OJBGIJLGDDM(AOMADBOBEAJ FCHDAFNGEPF, object CMNJCPJBHGE, AOMADBOBEAJ HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CCFANFDGIAA(AOMADBOBEAJ FCHDAFNGEPF, object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CEHEICOBPPK(AOMADBOBEAJ FCHDAFNGEPF, [Out] AOMADBOBEAJ HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FEJMINDHDEJ(AOMADBOBEAJ FCHDAFNGEPF, float3 HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OBKNLEHKFEL(AOMADBOBEAJ FCHDAFNGEPF, [Out] float3 HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AMIMIHIGOKN(AOMADBOBEAJ FCHDAFNGEPF, float3 HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HEMPDKMFFDC(AOMADBOBEAJ FCHDAFNGEPF, [Out] float3 HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GKPLNPEDJAD(AOMADBOBEAJ FCHDAFNGEPF, (Quaternion rot, Vector3 moments) ILJHDCDBMMG);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool OIONEEBEEML(AOMADBOBEAJ FCHDAFNGEPF, [Out] quaternion GIOBPCBFDIE, [Out] float3 GHAMHFENOCI);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DIFOBEKGOBM(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 CMJCNBPAKFE(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 CDPNANGCILI(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JEKAOOJNDEB(AOMADBOBEAJ FCHDAFNGEPF, float3 HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HIJGAJCPNHN(AOMADBOBEAJ FCHDAFNGEPF, float3 HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float PKCOALLGCBD(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float GJFINJKDGHD(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CPAGMOAOANL(AOMADBOBEAJ FCHDAFNGEPF, float HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CHBKAENLMAB(AOMADBOBEAJ FCHDAFNGEPF, float HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode IHHJCJFFJIC(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OEKAHLAMFLC(AOMADBOBEAJ FCHDAFNGEPF, CollisionDetectionMode HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	NCPKOJCDALC HFACILHPEBF(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FEJPBOAMJFE(AOMADBOBEAJ FCHDAFNGEPF, NCPKOJCDALC HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool PINBHNKCHNK(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GOKLKHLEJNP(AOMADBOBEAJ FCHDAFNGEPF, bool HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "29")]
	AOMADBOBEAJ IKGNBNHDPIJ(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GLPDNACGFDN(AOMADBOBEAJ FCHDAFNGEPF, AOMADBOBEAJ HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "31")]
	AOMADBOBEAJ GIBBFBNMFJB(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void KAPGKFEMBMB(AOMADBOBEAJ FCHDAFNGEPF, AOMADBOBEAJ HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "33")]
	KBLCCMMKFLK HIHBNOCENEA(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void KKBOICPDNBF(AOMADBOBEAJ FCHDAFNGEPF, KBLCCMMKFLK ACMAJJOJKEO);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool PFCHJJCFDCE(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void JPBKLOAHKFG(AOMADBOBEAJ FCHDAFNGEPF, bool HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool ANFLJDGJJFH(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void JNMBFHPOPNO(AOMADBOBEAJ FCHDAFNGEPF, bool HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints AIMCEIJMIJP(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void KEOECDJCGKE(AOMADBOBEAJ FCHDAFNGEPF, RigidbodyConstraints HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float DJNJFLLEICN(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void FJJMMKMIDEG(AOMADBOBEAJ FCHDAFNGEPF, float HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float KEHJAAKDNKE(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void PGAICEBCAJJ(AOMADBOBEAJ FCHDAFNGEPF, float HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool OMGKOFGMNIA(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void MFIPCPFCPNA(AOMADBOBEAJ FCHDAFNGEPF, bool HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool ICGDPHFMJFG(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void KENPGOJPOHM(AOMADBOBEAJ FCHDAFNGEPF, bool HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void CEICPGKCGMK(AOMADBOBEAJ FCHDAFNGEPF, int HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "50")]
	GKJILOLAJBC EMKEEAEELNH(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void MPPLGMBDHOJ(AOMADBOBEAJ FCHDAFNGEPF, GKJILOLAJBC HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "52")]
	EFFPCFBOJKN EBDONOIANKO(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void KAKKIAHKCPA(AOMADBOBEAJ FCHDAFNGEPF, EFFPCFBOJKN HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float OJOACPOHHGI(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void HKNFMFAJJMH(AOMADBOBEAJ FCHDAFNGEPF, float HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void DCIHJCGBKIJ(AOMADBOBEAJ FCHDAFNGEPF, object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void PKMNNKDGIEH(AOMADBOBEAJ FCHDAFNGEPF, object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool HLEPFDOOAGA(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void ANFAHJMPFDM(AOMADBOBEAJ FCHDAFNGEPF, object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void GNIGNNOKLLH(AOMADBOBEAJ FCHDAFNGEPF, object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool KGFFKKFFDLM(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool NOHDGOGBPBF(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody KMMEAKHNIDP(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void AJOAAEEFMBD(AOMADBOBEAJ FCHDAFNGEPF, Rigidbody LAANDEEMEGN);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void CHMLNINGDIN(AOMADBOBEAJ FCHDAFNGEPF, object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void JGLMCCCILMF(AOMADBOBEAJ FCHDAFNGEPF, object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool BMBGEJKFNLE(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void KGKMCJGGOEI(AOMADBOBEAJ FCHDAFNGEPF, float3 KLNNEIDEPKF);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void HFOGOOKNIJD(AOMADBOBEAJ FCHDAFNGEPF, float3 KFMFAILJFNK);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool ELMMHEIEJAL(AOMADBOBEAJ FCHDAFNGEPF, [Out] float3 KLNNEIDEPKF);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool AEIJPNAJDGL(AOMADBOBEAJ FCHDAFNGEPF, [Out] float3 KFMFAILJFNK);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool PPIIAABHJCO(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void LGJIGFGDMLG(AOMADBOBEAJ FCHDAFNGEPF, object CMNJCPJBHGE, bool CKPMADLDOMI);

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void AGJIOLDPFFK(AOMADBOBEAJ FCHDAFNGEPF, bool HFPOAFIFOHI);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void FOKMKNLHAON(AOMADBOBEAJ FCHDAFNGEPF);

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool CFDGKENAFLA(AOMADBOBEAJ FCHDAFNGEPF);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface POIMNCNOFBP
{
	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDLDCCFKEND(Entity JGFNJMPGIBM);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EAAMHKFLIFF(Entity JGFNJMPGIBM);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface KEDIDNHDFMK
{
	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHJKJGMGKJJ(AOMADBOBEAJ MGPMAFDHMLC, bool AENNCPMGIOK);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NIFCHICOMPP(AOMADBOBEAJ MGPMAFDHMLC, int BHDCNGMMPLN);
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public delegate void GBMDBAJNCLE(DOLBAMEOCKK MCPKPFGFCEA);
[Cpp2IlInjected.Token(Token = "0x200009C")]
public readonly ref struct DOLBAMEOCKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly DFMAFHIFHME EKDPCGIEJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly NativeArray<byte> CDPIPODOEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly NativeArray<byte> JGMMKHHPPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly HFFALABIPJN LKGPHBHEBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly int OLHPHJAEEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly Type MNLAMHDCPBG;

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public DFMAFHIFHME PJDGLCGIFJM
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x3CBABA0", Offset = "0x3CB9FA0", VA = "0x183CBABA0")]
		get
		{
			return default(DFMAFHIFHME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x7149B70", Offset = "0x7148F70", VA = "0x187149B70")]
	public DOLBAMEOCKK(DFMAFHIFHME EKDPCGIEJEL, NativeArray<byte> CDPIPODOEDP, NativeArray<byte> JGMMKHHPPHO, HFFALABIPJN LKGPHBHEBBE, int OLHPHJAEEPP, Type MNLAMHDCPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x2E9D430", Offset = "0x2E9C830", VA = "0x182E9D430")]
	public NativeArray<T> DAOAKCMGGNC<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x2E9D470", Offset = "0x2E9C870", VA = "0x182E9D470")]
	public NativeArray<T> IKNDKJKEBIM<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x2E9D340", Offset = "0x2E9C740", VA = "0x182E9D340")]
	public (DFMAFHIFHME, NativeArray<T>, NativeArray<T>) AFFELPLAAIM<T>() where T : struct
	{
		return default((DFMAFHIFHME, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x7149B40", Offset = "0x7148F40", VA = "0x187149B40")]
	public HKDLHOKLBNJ JKBDBDMPAHD()
	{
		return default(HKDLHOKLBNJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public interface EFIIOLPFONP
{
	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	string NGDLAKLOFEK
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	EFIIOLPFONP GNNIJEKMKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	IEnumerable<EFIIOLPFONP> KEAHCMOILKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface NIOCDOKHNKK
{
	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	EFIIOLPFONP HLGHBJJCFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	NativeArray<HFFALABIPJN> CMOELKLHBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AHFKPAHIAEK(HFFALABIPJN LKGPHBHEBBE, [Out] EFIIOLPFONP KOGDHKPKBPK);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EMOBGIHOLPD(HFFALABIPJN LKGPHBHEBBE, GBMDBAJNCLE IEBCGDAODCE);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AFELCEKEOAN(HFFALABIPJN LKGPHBHEBBE, GBMDBAJNCLE IEBCGDAODCE);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface ECCHFNFNPDK
{
	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMOBGIHOLPD(HFFALABIPJN LKGPHBHEBBE, GBMDBAJNCLE IEBCGDAODCE);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFELCEKEOAN(HFFALABIPJN LKGPHBHEBBE, GBMDBAJNCLE IEBCGDAODCE);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class EHCCFIOMAKI
{
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PMJAFECFBFF
{
	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	GJBOPACPELE PANNEBHEGMC
	{
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INMKGLOLPJE(OKLHMMELOIN LLAEJMCGGGB, HFFALABIPJN LKGPHBHEBBE);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIFJGBPPCAC(OKLHMMELOIN LLAEJMCGGGB, Span<HFFALABIPJN> DINAOAFDFPO, bool JFICPHOFGNG);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGBKCEOOMGC(NativeArray<OKLHMMELOIN> GNENNFCAIBN);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class FEJKPLAABNN
{
	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x714C240", Offset = "0x714B640", VA = "0x18714C240")]
	public static void BIFJGBPPCAC(this PMJAFECFBFF LKLFCAMBKBB, OKLHMMELOIN LLAEJMCGGGB, HFFALABIPJN LKGPHBHEBBE, bool JFICPHOFGNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public readonly ref struct HKDLHOKLBNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly DOLBAMEOCKK JGCOLLOOLHL;

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public DFMAFHIFHME PJDGLCGIFJM
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x3CBABA0", Offset = "0x3CB9FA0", VA = "0x183CBABA0")]
		get
		{
			return default(DFMAFHIFHME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x714F010", Offset = "0x714E410", VA = "0x18714F010")]
	public HKDLHOKLBNJ(DOLBAMEOCKK JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x714EE70", Offset = "0x714E270", VA = "0x18714EE70")]
	public DFMAFHIFHME DAOAKCMGGNC()
	{
		return default(DFMAFHIFHME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x714EF40", Offset = "0x714E340", VA = "0x18714EF40")]
	public DFMAFHIFHME IKNDKJKEBIM()
	{
		return default(DFMAFHIFHME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x714EC50", Offset = "0x714E050", VA = "0x18714EC50")]
	public (DFMAFHIFHME, DFMAFHIFHME, DFMAFHIFHME) AFFELPLAAIM()
	{
		return default((DFMAFHIFHME, DFMAFHIFHME, DFMAFHIFHME));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class DHLDMNJIIKJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public readonly struct GJBOPACPELE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly NativeBitArray LANHNAKCLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly NativeParallelHashMap<OKLHMMELOIN, int> DNECMDFGJJK;

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public bool NPJNGPAAGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x714E350", Offset = "0x714D750", VA = "0x18714E350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x47A7830", Offset = "0x47A6C30", VA = "0x1847A7830")]
	public GJBOPACPELE(NativeBitArray LANHNAKCLAA, NativeParallelHashMap<OKLHMMELOIN, int> DNECMDFGJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x714E220", Offset = "0x714D620", VA = "0x18714E220")]
	public bool INMKGLOLPJE(OKLHMMELOIN LLAEJMCGGGB, HFFALABIPJN LKGPHBHEBBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface HNOOAIEMFKP
{
	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PANCLOEJDMI(AOMADBOBEAJ FCHDAFNGEPF, EPEJGOLLHIL HCPAOILCJCB);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ABPNNEDOAIG
{
	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	BLEKIMGBKEH AOPMEINAEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JFGBOJIICBN
{
	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCHFMCOLFFL(World GPOOJLKEOLB);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MIPOPDIDLMM(World GPOOJLKEOLB);

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase FHFDOBFENIC(World GPOOJLKEOLB);

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NIHOMJLNLJH(World GPOOJLKEOLB);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KNIFFBJGEDJ(World GPOOJLKEOLB);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OEKFBJCODBG(World GPOOJLKEOLB);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OIAENJACMNI(World GPOOJLKEOLB);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> EHHLABMONHG();
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface GGNLJCELGHD
{
	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MOMABEPBLMP(AOMADBOBEAJ NKCFJFCLAAC, bool HCPAOILCJCB);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public readonly struct DJIOMCFNOBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly IEnumerable<FLOPKECBBDN> NODNNPCBDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly IReadOnlyList<GameObject> KAFNOJBGCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly IReadOnlyList<int> HIOIOFBPIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IReadOnlyList<(OKLHMMELOIN, OKLHMMELOIN)> LODDPIHDKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly int KPMIOFLDBGL;

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public bool BDPCGJLEFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x71496F0", Offset = "0x7148AF0", VA = "0x1871496F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public int JJFEFFLCPDO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x968260", Offset = "0x967660", VA = "0x180968260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public IEnumerable<GameObject> POCODJCFJJO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x9C07A0", Offset = "0x9BFBA0", VA = "0x1809C07A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public IEnumerable<(OKLHMMELOIN src, OKLHMMELOIN dst)> OPLMBOEALEG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x7149AD0", Offset = "0x7148ED0", VA = "0x187149AD0")]
	public DJIOMCFNOBD(IEnumerable<FLOPKECBBDN> NODNNPCBDHO, IReadOnlyList<GameObject> KAFNOJBGCIC, IReadOnlyList<int> HIOIOFBPIGG, IReadOnlyList<(OKLHMMELOIN src, OKLHMMELOIN dst)> LODDPIHDKEE, int KPMIOFLDBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x7149750", Offset = "0x7148B50", VA = "0x187149750")]
	public (GameObject, int)[] OKCJMOHGBDL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.Application)]
public interface INMAOKDMPLF
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public class IBEOIBFKECB
	{
		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public AOMADBOBEAJ HOBMCFDJPFK
		{
			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
			[CompilerGenerated]
			get
			{
				return default(AOMADBOBEAJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x957D40", Offset = "0x957140", VA = "0x180957D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public UniformTRS JDOHCEFDHLO
		{
			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x3D3ACE0", Offset = "0x3D3A0E0", VA = "0x183D3ACE0")]
			[CompilerGenerated]
			get
			{
				return default(UniformTRS);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x714F040", Offset = "0x714E440", VA = "0x18714F040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public bool OOBHCGDOOID
		{
			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x9F9000", Offset = "0x9F8400", VA = "0x1809F9000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x9F8960", Offset = "0x9F7D60", VA = "0x1809F8960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public OKFBGDAOOJL MHMLLCMEAGE
		{
			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DA0", Offset = "0x8C71A0", VA = "0x1808C7DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x8C7BA0", Offset = "0x8C6FA0", VA = "0x1808C7BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public bool BKBIOLMHBFC
		{
			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x9A2F80", Offset = "0x9A2380", VA = "0x1809A2F80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x9A3BD0", Offset = "0x9A2FD0", VA = "0x1809A3BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public InventionIdData FCJOEEAMNLN
		{
			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x8CAEF0", Offset = "0x8CA2F0", VA = "0x1808CAEF0")]
			[CompilerGenerated]
			get
			{
				return default(InventionIdData);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0xA549C0", Offset = "0xA53DC0", VA = "0x180A549C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public InventionInstanceIdData CNJAFNELCKB
		{
			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x96EF70", Offset = "0x96E370", VA = "0x18096EF70")]
			[CompilerGenerated]
			get
			{
				return default(InventionInstanceIdData);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0xC60470", Offset = "0xC5F870", VA = "0x180C60470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public bool JKMMBDIKGKN
		{
			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x96EF50", Offset = "0x96E350", VA = "0x18096EF50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0xB125C0", Offset = "0xB119C0", VA = "0x180B125C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x714F050", Offset = "0x714E450", VA = "0x18714F050")]
		public IBEOIBFKECB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	bool CBNEEDNJBPH
	{
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	bool GLJKDEKIJFO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	GKEHDPCCFBN EJCDGBILEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KFHICKKGIJM NHPACHBHEBF();

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KFHICKKGIJM CEDAHCNCLCE(IEnumerable<AOMADBOBEAJ> LGIFMBNGOEI, [In] UniformTRS FOIMNHKMJNO);

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NLCEFNHKPGK AAMOLDDFAAL(ByteString NBIJFDIADCF);

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PCEBDMGLJNC MLKAJBEIALH(ByteString NEENHFHMFPH, IBEOIBFKECB OKAMEPDCJCI);

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CHNLIJMKPAF();

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DJIOMCFNOBD BKKEADKGKAF(IEnumerable<FLOPKECBBDN> NODNNPCBDHO);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class FPCONNKMPKG
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.Application)]
public interface PPNNLDKCDEE
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action OBMLHHOBGGC;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct IPPNMBPPJNK : IEquatable<IPPNMBPPJNK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public NABGOBFPKKK FPLGHFJHKOE;

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x7151620", Offset = "0x7150A20", VA = "0x187151620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x1B28B80", Offset = "0x1B27F80", VA = "0x181B28B80", Slot = "4")]
	public bool Equals(IPPNMBPPJNK BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x71515A0", Offset = "0x71509A0", VA = "0x1871515A0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CLBMIKOPGDF
{
	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	uint PJHEKACBHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public enum AFGLOPBHKEI
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MOEOOPNKGOA
{
	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBFBHECFHAD(BMBLDJONBEB MAPPNBHJLPD, ReadOnlySpan<byte> PBJNGGAILNG);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGPFBLCEDMK(uint DPKEOHFGHCO, ReadOnlySpan<byte> PBJNGGAILNG);

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ELHBHJDPFNO(int DHHNDCJMMAD);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PBCGBMANGIK
{
	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMBLDJONBEB OJEPIGFAGEJ(ReadOnlySpan<byte> PBJNGGAILNG);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DHEGKPBKGND
{
	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFKKACAMGFG(BMBLDJONBEB LDCKBFKFIKC, ReadOnlySpan<byte> PBJNGGAILNG);

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMDHAAJNCGN(ReadOnlySpan<BMBLDJONBEB> BDPBOBHMNLD);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public struct AHLINKKALGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public BMBLDJONBEB MAPPNBHJLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public ReadOnlyMemory<byte> PBJNGGAILNG;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public struct BMBLDJONBEB
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public static BMBLDJONBEB MGLBFGBHGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public uint BLDKEJEIDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int PMEEJAGENJG;

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x961F80", Offset = "0x961380", VA = "0x180961F80")]
	public BMBLDJONBEB(uint BLDKEJEIDPH, int PMEEJAGENJG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x71442E0", Offset = "0x71436E0", VA = "0x1871442E0")]
	public static bool FANHDJJNLED([In] BMBLDJONBEB FGFJFGGJOII, [In] BMBLDJONBEB CABLGFIBABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x7144230", Offset = "0x7143630", VA = "0x187144230", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x7144300", Offset = "0x7143700", VA = "0x187144300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x7144340", Offset = "0x7143740", VA = "0x187144340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x7144330", Offset = "0x7143730", VA = "0x187144330")]
	public void MIAIEJBCOBI([Out] uint BLDKEJEIDPH, [Out] int PMEEJAGENJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public struct FLOPKECBBDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public Guid FNECNONNEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public string JIMNKEIAGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Vector3 CPGMOBFHDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public Quaternion CBCAIPELAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Vector3 BMGLFPFGJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int BJILGGJGIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Dictionary<string, object> OKAMEPDCJCI;

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x714C510", Offset = "0x714B910", VA = "0x18714C510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x714C390", Offset = "0x714B790", VA = "0x18714C390")]
	private static string OLGFIPBNHCE(Dictionary<string, object> ODFNNAJIIMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public enum HDBFFLNLMAI
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	SubGraphReplace,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class CGJIAGLCPFI
{
	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x7144870", Offset = "0x7143C70", VA = "0x187144870")]
	public static bool NIKFBPLOLPG(this HDBFFLNLMAI IFBDJLKPHIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[Flags]
public enum IFNJCNCCPJL
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	AdditivePhases = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public interface PCEBDMGLJNC : GKEHDPCCFBN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	OKFBGDAOOJL MHMLLCMEAGE
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKMNDLFOFHF();

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPFBBIBEOMC();
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public interface GKEHDPCCFBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	IEnumerable<FLOPKECBBDN> PCMLOHPPDNM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	DJIOMCFNOBD NLACADBKGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	HDBFFLNLMAI KBPCMAIENME
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	LocalId AFLHLPHOPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	GEJGEECELOA IIEFKCOLNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool POOMJEGGIFP(IFNJCNCCPJL MFFOFPKBFBM);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public interface OKFBGDAOOJL
{
	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLMBNCBNDFB(Guid DOELFDCMLHC, [Out] Guid LJFKJHDEOPC);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface NLCEFNHKPGK : GKEHDPCCFBN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[Flags]
public enum ACLHPOEDDEP
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface KFHICKKGIJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	GEJGEECELOA MONJHEDABEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString EIHLLNDPHLJ();
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public enum PDNACHGJDIB
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public struct OHBPGOIOEIL : ISystemStateComponentData, IComponentData, IEquatable<OHBPGOIOEIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float3 DJHCDMMFNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float3 NIIBKKFAGFH;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x7156450", Offset = "0x7155850", VA = "0x187156450", Slot = "4")]
	public bool Equals(OHBPGOIOEIL BMKPAKCEMFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JBBFAHDHLOD
{
	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGLABBIBLJC(long KMMEAJEAKJI);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMNPKNPDOPM(NativeParallelHashSet<long> NPENBPDDECL);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBANFENAJKN(World GPOOJLKEOLB, NativeParallelHashMap<Guid, long> DILABIKMCDK);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DJDLMBJNLJO(OKLHMMELOIN LLAEJMCGGGB);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MLHHFJIBGNE(OKLHMMELOIN LLAEJMCGGGB, [Out] Guid AMJLCBILEGA, [Out] long KMMEAJEAKJI);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DFCKEGEJKAE(OKLHMMELOIN LLAEJMCGGGB, Guid AMJLCBILEGA, long KMMEAJEAKJI);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PFOJOHOHDOC(Guid AMJLCBILEGA);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EONDNMGLABA(Guid AMJLCBILEGA, [Out] int DNCPBHDHNJP, [Out] int ECAGCDGFMJA);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DINJEOOOFPD(Guid AMJLCBILEGA, int DNCPBHDHNJP, int ECAGCDGFMJA);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HAFBPKELGBG(Guid AMJLCBILEGA);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class EIEKKDBLJLC
{
	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public EIEKKDBLJLC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
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
