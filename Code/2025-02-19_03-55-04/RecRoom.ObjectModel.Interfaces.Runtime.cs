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
	public class LogRegistrationIndex : NELPCBNCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7623B70", Offset = "0x7622770", VA = "0x187623B70", Slot = "4")]
		public override void CHOGICNNBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PMGMGLGPHDI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x762A280", Offset = "0x7628E80", VA = "0x18762A280")]
	public static void KMLNACJHPMC(this Rigidbody FFGLMLCIKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x762A150", Offset = "0x7628D50", VA = "0x18762A150")]
	public static void KMLNACJHPMC(this Rigidbody FFGLMLCIKAF, Vector3 GEHOKONCFIG, Quaternion OAIGKKJLCDC, Vector3 OLNPOFALPKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct OMGFNECLCEJ : IReadOnlyList<OJMCCDFHBJG>, IEnumerable<OJMCCDFHBJG>, IEnumerable, IReadOnlyCollection<OJMCCDFHBJG>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct GDHHFODINGE : IEnumerator<OJMCCDFHBJG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly JCGKMOCONDO NAKGBBMJOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator JOPPOBNNBDD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OJMCCDFHBJG OAKKBGDNIKI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x761F5A0", Offset = "0x761E1A0", VA = "0x18761F5A0", Slot = "4")]
			get
			{
				return default(OJMCCDFHBJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x761F550", Offset = "0x761E150", VA = "0x18761F550", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4B0D0A0", Offset = "0x4B0BCA0", VA = "0x184B0D0A0")]
		public GDHHFODINGE(JCGKMOCONDO NAKGBBMJOPP, NativeArray<LocalId>.Enumerator JOPPOBNNBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x761F490", Offset = "0x761E090", VA = "0x18761F490", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x761F4D0", Offset = "0x761E0D0", VA = "0x18761F4D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x761F510", Offset = "0x761E110", VA = "0x18761F510", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HDHHPHJGLDK EHNDIPGCOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> MCJEKJAABCE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public OJMCCDFHBJG MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7627490", Offset = "0x7626090", VA = "0x187627490", Slot = "4")]
		get
		{
			return default(OJMCCDFHBJG);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7626960", Offset = "0x7625560", VA = "0x187626960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int JGDHEGFFJHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9571A0", Offset = "0x955DA0", VA = "0x1809571A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7626EF0", Offset = "0x7625AF0", VA = "0x187626EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FMELMONACEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9571A0", Offset = "0x955DA0", VA = "0x1809571A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NHPIKHBJFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7626FE0", Offset = "0x7625BE0", VA = "0x187626FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> KODNPMHFONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B54360", Offset = "0x2B52F60", VA = "0x182B54360")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> ABJEKGEGIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7626900", Offset = "0x7625500", VA = "0x187626900")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x76271F0", Offset = "0x7625DF0", VA = "0x1876271F0")]
	public OMGFNECLCEJ(int MFFEHHIHGMB, JCGKMOCONDO NAKGBBMJOPP, Allocator LNBNGBBFCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7627100", Offset = "0x7625D00", VA = "0x187627100")]
	public OMGFNECLCEJ(HDHHPHJGLDK EHNDIPGCOKP, NativeArray<LocalId> MCJEKJAABCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7627110", Offset = "0x7625D10", VA = "0x187627110")]
	public OMGFNECLCEJ(HDHHPHJGLDK EHNDIPGCOKP, NativeArray<Entity> MCJEKJAABCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7627350", Offset = "0x7625F50", VA = "0x187627350")]
	internal OMGFNECLCEJ(JCGKMOCONDO NAKGBBMJOPP, NativeArray<Entity> BMGAGFMALJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7627180", Offset = "0x7625D80", VA = "0x187627180")]
	internal OMGFNECLCEJ(JCGKMOCONDO NAKGBBMJOPP, NativeArray<LocalId> MCJEKJAABCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x76273E0", Offset = "0x7625FE0", VA = "0x1876273E0")]
	public OMGFNECLCEJ(JCGKMOCONDO NAKGBBMJOPP, int OKLDJMDCMFC, Allocator LNBNGBBFCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x76272A0", Offset = "0x7625EA0", VA = "0x1876272A0")]
	public OMGFNECLCEJ(OMGFNECLCEJ OAOABPLEPBD, Allocator LNBNGBBFCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x76269C0", Offset = "0x76255C0", VA = "0x1876269C0")]
	public void GMALBHFEFIA(List<OJMCCDFHBJG> DGHHCPPFODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7626870", Offset = "0x7625470", VA = "0x187626870")]
	public void CEGPHMFCMEL(int BIEEMEKMINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7626E50", Offset = "0x7625A50", VA = "0x187626E50")]
	public OMGFNECLCEJ JNBLFNDBNCH(Allocator LNBNGBBFCIG)
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7626D00", Offset = "0x7625900", VA = "0x187626D00")]
	public Span<OJMCCDFHBJG> HPOOGBGHMCM()
	{
		return default(Span<OJMCCDFHBJG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7626F40", Offset = "0x7625B40", VA = "0x187626F40")]
	public OMGFNECLCEJ LGCPNDOAILM(int BICIFKAHIKL, int OKLDJMDCMFC)
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x76268C0", Offset = "0x76254C0", VA = "0x1876268C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7626C40", Offset = "0x7625840", VA = "0x187626C40")]
	public GDHHFODINGE HCMJLOGCBCL()
	{
		return default(GDHHFODINGE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7627020", Offset = "0x7625C20", VA = "0x187627020", Slot = "6")]
	private IEnumerator<OJMCCDFHBJG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7627090", Offset = "0x7625C90", VA = "0x187627090", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MINOEIHOFIO
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x34714C0", Offset = "0x34700C0", VA = "0x1834714C0")]
	public static EOGBGIGFMKC<T> GMMOIGCDEEP<T>(this OMGFNECLCEJ CGPMLCFDDHA) where T : Component
	{
		return default(EOGBGIGFMKC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct MEOGGIPDCEF : IList<OJMCCDFHBJG>, ICollection<OJMCCDFHBJG>, IEnumerable<OJMCCDFHBJG>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct AFBLPFIKMPO : IEnumerator<OJMCCDFHBJG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly JCGKMOCONDO NAKGBBMJOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator JOPPOBNNBDD;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public OJMCCDFHBJG OAKKBGDNIKI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7614CF0", Offset = "0x76138F0", VA = "0x187614CF0", Slot = "4")]
			get
			{
				return default(OJMCCDFHBJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7614CA0", Offset = "0x76138A0", VA = "0x187614CA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4B0D0A0", Offset = "0x4B0BCA0", VA = "0x184B0D0A0")]
		public AFBLPFIKMPO(JCGKMOCONDO NAKGBBMJOPP, NativeArray<LocalId>.Enumerator JOPPOBNNBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7614BE0", Offset = "0x76137E0", VA = "0x187614BE0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7614C20", Offset = "0x7613820", VA = "0x187614C20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7614C60", Offset = "0x7613860", VA = "0x187614C60", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly JCGKMOCONDO NAKGBBMJOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> MCJEKJAABCE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public OJMCCDFHBJG MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7624C60", Offset = "0x7623860", VA = "0x187624C60", Slot = "4")]
		get
		{
			return default(OJMCCDFHBJG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7624D50", Offset = "0x7623950", VA = "0x187624D50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7624830", Offset = "0x7623430", VA = "0x187624830", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FMELMONACEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7624830", Offset = "0x7623430", VA = "0x187624830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> KODNPMHFONF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B54360", Offset = "0x2B52F60", VA = "0x182B54360")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool EDFBHKBNGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7624B50", Offset = "0x7623750", VA = "0x187624B50")]
	public MEOGGIPDCEF(JCGKMOCONDO NAKGBBMJOPP, Allocator LNBNGBBFCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7624BD0", Offset = "0x76237D0", VA = "0x187624BD0")]
	public MEOGGIPDCEF(JCGKMOCONDO NAKGBBMJOPP, int OKLDJMDCMFC, Allocator LNBNGBBFCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7624270", Offset = "0x7622E70", VA = "0x187624270")]
	public OMGFNECLCEJ BDAMEBNIGIJ()
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7624380", Offset = "0x7622F80", VA = "0x187624380", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x76243C0", Offset = "0x7622FC0", VA = "0x1876243C0", Slot = "13")]
	public bool Contains(OJMCCDFHBJG HLGDOFMLIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7624450", Offset = "0x7623050", VA = "0x187624450", Slot = "14")]
	public void CopyTo(OJMCCDFHBJG[] CPOMPIIIEGC, int LECIFCCAAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x76241F0", Offset = "0x7622DF0", VA = "0x1876241F0", Slot = "11")]
	public void Add(OJMCCDFHBJG HLGDOFMLIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7624780", Offset = "0x7623380", VA = "0x187624780", Slot = "7")]
	public void Insert(int BIEEMEKMINN, OJMCCDFHBJG HLGDOFMLIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x76248C0", Offset = "0x76234C0", VA = "0x1876248C0", Slot = "15")]
	public bool Remove(OJMCCDFHBJG HLGDOFMLIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x76246F0", Offset = "0x76232F0", VA = "0x1876246F0", Slot = "6")]
	public int IndexOf(OJMCCDFHBJG HLGDOFMLIOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7624870", Offset = "0x7623470", VA = "0x187624870", Slot = "8")]
	public void RemoveAt(int BIEEMEKMINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7624620", Offset = "0x7623220", VA = "0x187624620", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7624660", Offset = "0x7623260", VA = "0x187624660")]
	public AFBLPFIKMPO HCMJLOGCBCL()
	{
		return default(AFBLPFIKMPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7624990", Offset = "0x7623590", VA = "0x187624990", Slot = "16")]
	private IEnumerator<OJMCCDFHBJG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7624A70", Offset = "0x7623670", VA = "0x187624A70", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GFGGBLHLLIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OJMCCDFHBJG FBEBPKAKPHB(OJMCCDFHBJG MCJEKJAABCE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BJNDHGKABJA : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface FAAHGBEEPPC : OOHICIOEPNC, PDNAPLMDGDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	IFKNHGHGOLD FEPNGGAFODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	HDHHPHJGLDK OIKDPCDAPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface PDNAPLMDGDP
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool DMHGNEEJOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface BKKLCMNNADO
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMBPADNDKNM(bool MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGMONOEHMBH();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface BEOGAMAAIFB
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool PLFEMNKNBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool HLPHHCFELEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool POIGOIDDHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool GKOAHADDDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LCFJHKLFMCA(bool BEPIDPDHFCG);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OMCDOPEFDOG(ByteString MFPPEDNFJPH);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JLKGIOAKHKC();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AGLDCHGMAKN();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PPFLHKGAMKB();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface JKCBDBLFMMD
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	AILCBCECHFO FEPNGGAFODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	MDGBNKPHFKM JILFFJDGMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	EHEBFLDBPJO MFHDDCDPDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	FAAHGBEEPPC DAGIOOPCFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	PAEFKDCHKEI FPAEFMGNGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	BEOGAMAAIFB CILPPHEGOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	NEOCDLGJFLO FFFFPBPFGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	CCLAFHOIELK LFGEOOACNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	NBNNMFACLOB OACOFHONLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	BFCGPAEHKNA DKHCKMBPBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	BAFDIDPMENC OLKLIAGFJEK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	GHABOPFKPCI MOINJPIKNEF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	KAALCMFCOAB FMJMCGCHCGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	DGDEPPHEOAH MBEPEDIHHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	MFKFHDEDLJM BNAOIHKFMJM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	JPHFFDNKLNF NFFCGICHCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	PFBHDOJMGLM MNKNFNDGBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	KNFJDMDLNGE DFEEHLLBMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	BAKIDPLEFKE IPDONPIKEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	GMCAHBACLOI OHFOMOLMNPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	AOFJFMJLAED AIEFINJJJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	GGODPBKOJHB FICHLNKMPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	PBBPCHGIGJC EDKIBKKOMBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	LNINCFCHAFH AIPLNCAFBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	OFBNHAOBLAJ NFCKJJBELJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	EOPDFLKMIAP CIDBCCECAMC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	JJLPEBMBDPJ BHFPLIEPHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	BNLKHDBJKHJ EPMHMCHBOCG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	JGEACCFLGMN FMKJKGDPNNN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PPBEEFOFLJP GJGJCHIILJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KNHPIELBCJK BFMNHKCMOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	PMKFHJKLGJJ HDCGKFCHFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(JGGEGIFGLMC))]
public readonly struct OJMCCDFHBJG : IComparable<OJMCCDFHBJG>, IEquatable<OJMCCDFHBJG>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly OJMCCDFHBJG GDEBNFLOOLE;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int BHPENAPLBNN = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int HMBAKDHPEOJ = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int KKAGIPOLCCK = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int KIDALHDFOFA = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId JKOPHJKJLOL;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public FAAHGBEEPPC DAGIOOPCFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7625FA0", Offset = "0x7624BA0", VA = "0x187625FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public LocalId IGDDOGNFOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x76263C0", Offset = "0x7624FC0", VA = "0x1876263C0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal HDHHPHJGLDK OIKDPCDAPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x76263B0", Offset = "0x7624FB0", VA = "0x1876263B0")]
		get
		{
			return default(HDHHPHJGLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NMMFNCKLIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7626290", Offset = "0x7624E90", VA = "0x187626290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool HFCBFOILKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7626520", Offset = "0x7625120", VA = "0x187626520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7626720", Offset = "0x7625320", VA = "0x187626720")]
	public OJMCCDFHBJG(JCGKMOCONDO JNENMDKIEKO, LocalId JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x76267E0", Offset = "0x76253E0", VA = "0x1876267E0")]
	public OJMCCDFHBJG(HDHHPHJGLDK EHNDIPGCOKP, LocalId JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
	public PADKPDAFIDF CPEIDJDOMEE()
	{
		return default(PADKPDAFIDF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7626570", Offset = "0x7625170", VA = "0x187626570")]
	public static LocalId NIBCGLOMJGK(OJMCCDFHBJG LOKBKPHNKME)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x76265B0", Offset = "0x76251B0", VA = "0x1876265B0")]
	public static Entity NIBCGLOMJGK(OJMCCDFHBJG LOKBKPHNKME)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7626400", Offset = "0x7625000", VA = "0x187626400")]
	public static bool LBLECGDECIN(OJMCCDFHBJG CEDOOEEEDCO, OJMCCDFHBJG LJEHMGANCNG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7624F20", Offset = "0x7623B20", VA = "0x187624F20")]
	public static bool AIDLCBIJBIF(OJMCCDFHBJG CEDOOEEEDCO, OJMCCDFHBJG LJEHMGANCNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x76265F0", Offset = "0x76251F0", VA = "0x1876265F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x76260F0", Offset = "0x7624CF0", VA = "0x1876260F0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7626000", Offset = "0x7624C00", VA = "0x187626000", Slot = "4")]
	public int CompareTo(OJMCCDFHBJG PELBNOCGOOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "5")]
	public bool Equals(OJMCCDFHBJG PELBNOCGOOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FOEGAKJJGLG
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x761F230", Offset = "0x761DE30", VA = "0x18761F230")]
	public static FCEEFAMELLC LEHNPLFPAKO(this OJMCCDFHBJG CFMCKCBBBKK)
	{
		return default(FCEEFAMELLC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class JGGEGIFGLMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct HDHHPHJGLDK : IEquatable<HDHHPHJGLDK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte EHNDIPGCOKP;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] ICGBHNFFINL;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static JCGKMOCONDO FIOKOBBCIFL;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static FAAHGBEEPPC LNAKMAHHGPC;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static JCGKMOCONDO[] JMJKNPKACDE;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static FAAHGBEEPPC[] KDLNLEGAFCN;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> NJANDEJHJEK;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public FAAHGBEEPPC DAGIOOPCFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7620EA0", Offset = "0x761FAA0", VA = "0x187620EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public JCGKMOCONDO KGBDIBKCIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7621030", Offset = "0x761FC30", VA = "0x187621030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7621700", Offset = "0x7620300", VA = "0x187621700")]
	static HDHHPHJGLDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x271C880", Offset = "0x271B480", VA = "0x18271C880")]
	internal HDHHPHJGLDK(byte MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x666E9D0", Offset = "0x666D5D0", VA = "0x18666E9D0", Slot = "4")]
	public bool Equals(HDHHPHJGLDK PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7620F90", Offset = "0x761FB90", VA = "0x187620F90", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xD681F0", Offset = "0xD66DF0", VA = "0x180D681F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7621640", Offset = "0x7620240", VA = "0x187621640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x76211C0", Offset = "0x761FDC0", VA = "0x1876211C0")]
	private static JCGKMOCONDO KENAAMFOIOP(byte EHNDIPGCOKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7621120", Offset = "0x761FD20", VA = "0x187621120")]
	private static FAAHGBEEPPC JOHMGOMGGMI(byte EHNDIPGCOKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7621260", Offset = "0x761FE60", VA = "0x187621260")]
	private static object LGLKDNNMBHA(byte EHNDIPGCOKP, object[] FKBJBKHIAAE, object NBKBMLNEBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7620F80", Offset = "0x761FB80", VA = "0x187620F80")]
	private static int DMFHPKOCMGJ(byte EHNDIPGCOKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x76215B0", Offset = "0x76201B0", VA = "0x1876215B0")]
	private static int PFNHNAGBAMA(byte EHNDIPGCOKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x76215C0", Offset = "0x76201C0", VA = "0x1876215C0")]
	private static (int, int) PGNAECMFCBG(byte EHNDIPGCOKP)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7621110", Offset = "0x761FD10", VA = "0x187621110")]
	private static byte HDNKLIPFNIC(int HBIBCNEICNM, int BIEEMEKMINN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7620C00", Offset = "0x761F800", VA = "0x187620C00")]
	internal static HDHHPHJGLDK CHOGICNNBDH(FAAHGBEEPPC BDJIKIAHLFH, JCGKMOCONDO MPJJNLJGOIF)
	{
		return default(HDHHPHJGLDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x76213C0", Offset = "0x761FFC0", VA = "0x1876213C0")]
	internal static void MKLJCELBDDO(HDHHPHJGLDK EHNDIPGCOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x76208A0", Offset = "0x761F4A0", VA = "0x1876208A0")]
	private static void AKIOEHCLHHD(int MFFEHHIHGMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum GAHCMOGCPEN
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
[ServiceLifetime(Lifetime.Application)]
public interface JMOHBFODEOB
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Guid FKLCMGPBGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PHOCBDNBGBH(Guid NFHEPCKJDMF, Guid HNIBCCHLOFE, Guid FMEOMMKFEEK);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task GNFAFMOKCMP(Guid NFHEPCKJDMF, Guid[] JLFFLLJFFON, Guid FMEOMMKFEEK);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid BOPMNMLIODG(Guid OJOHECDAGPC);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task OOHOKHLJPEI(OJMCCDFHBJG NBBBCKDKDMI);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CPIGLDJGJIJ(Guid OJOHECDAGPC);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FBEGDEEPCHC(JLDNHKJMMGM JLMCKEFINOB, Guid FLNBDJFMFKM);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BGPCHBIINCA(Guid OJOHECDAGPC, bool BEPIDPDHFCG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ServiceLifetime(Lifetime.Application)]
public interface NCGIDMDNHJD
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[ServiceLifetime(Lifetime.Application)]
public interface JIKPPEIIGEF
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEPGGIIJNLK(GameObject KNPFKHOBMJJ, GameObject INFGCEHNCGG, int BLLDGEOBAAE);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[ServiceLifetime(Lifetime.Application)]
public interface NMCBHDLIAGP
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "0")]
	void KNCJFILLGGI(bool KOGJFECFIAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface MDGBNKPHFKM
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	NMCBHDLIAGP COLAHJAKHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	HGNOODMPDJI JFNMEGMCIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	CKJIJPKFALB PJMNBOANAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	FNCGPIPMFDK LANLELLHFGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	PFNACAGABIF KILDBODBALI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	CKLJOAJMDKL IJPDLJBHBFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	HJGJLEKFDPI HHGLACBABNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	EGLINJBMFHL KGEEJBDOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface HGNOODMPDJI
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string DJEABALPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[ServiceLifetime(Lifetime.Application)]
public interface JGFPGCGPBOE
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHLEPLNNBNO(Action OAGMINHECCA, bool JPHCKMFIDNM);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BIEJOEHLNKH(string BGKKCEGMOKH);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HCMHMOAIAPG(string BGKKCEGMOKH, int NBKBMLNEBHK);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KHKJALBMBGP([Out] bool MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BBJHMMHIMCD([Out] bool MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LGAPKJKCADJ([Out] int MPDLOLIOGJL);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[ServiceLifetime(Lifetime.Application)]
public interface CKJIJPKFALB
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "0")]
	void ANCLLLNIJHN(bool BEPIDPDHFCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.Application)]
public interface FNCGPIPMFDK
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	protected static readonly Guid HONIKOMFODE;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	static readonly Guid IEJBPOCKLEK;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	static readonly Guid KOHJMCDKPAF;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	static readonly Guid DFPANAKNPKO;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool BPFOLAHBPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool FANLDHBIGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool OKFCFOJBJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x761F050", Offset = "0x761DC50", VA = "0x18761F050", Slot = "3")]
	string[] LNMHMFKJBGH(LKGOIGMMNHP KIOIJPLHDLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PNGCKCEGIKO();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x761F0E0", Offset = "0x761DCE0", VA = "0x18761F0E0", Slot = "5")]
	Guid NAJBDJEHMAE(Guid DKEBPGKCPEP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int OEOOGMALLOM(LKGOIGMMNHP KIOIJPLHDLK);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FBFAILNNHML(LKGOIGMMNHP KIOIJPLHDLK, NativeArray<DPKNGFGLDMJ> OPKGGFKLCAO, NativeList<UniformTRS> GDKBALPIFGC);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int IGOHNFFKMGA(Guid IEIMOIIMGDN);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EFGBMNIFHLC(string IMLADFAALMK, [Out] Guid IEIMOIIMGDN);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string BODHHDEJCKB(Guid IEIMOIIMGDN);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AGMOIADDBAL(RRObjectPrefabData HIBAADPCMLO, [Out] LocalId CANLONBNOKL);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GameObject OPKDAKDEFLE(string IMLADFAALMK);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void POILLPJPLIC(Transform FDCDPIOJPOG, RRObjectPrefabData KAECLFPEBIA, EEPNIHLMHOE HJIAOGEIAJO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool BAIBPDGGKFD(LKGOIGMMNHP KIOIJPLHDLK, NativeParallelHashMap<Guid, LocalId> ACCFNIMDKHH, [Out] Exception LIELHOAJGJM);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MDIOIAIBHDO(LKGOIGMMNHP KIOIJPLHDLK, NativeParallelHashMap<Guid, LocalId> ACCFNIMDKHH, [Out] NativeArray<LocalId> BMGAGFMALJB, [Out] NativeArray<LocalId> OIAAPHFFFEC, [Out] NativeArray<AuthoredLocalPoseData> HOJKJKCKJJG, Allocator LNBNGBBFCIG);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "16")]
	void FEGDPIILOKD(LKGOIGMMNHP FDFFMDBCAPG, NativeArray<int> LDOJKNAIJDP, HKBIAANNAOH<GameObject> HJPLGOABHEO, EOGBGIGFMKC<GameObject> LENKHDLGAGE, GAHCMOGCPEN IHFDLFIPENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EOHIGMPEGBE();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "18")]
	void FFNMBJDOKPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "19")]
	void DHPHHGBEOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x761F110", Offset = "0x761DD10", VA = "0x18761F110")]
	static FNCGPIPMFDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface OJBHDPGIMCD
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	long DFPOBFNEAFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	long AHAOONEMNPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface PFNACAGABIF
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool AAFFOOJAEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool LIHDKLBPKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	int FGCDCKFDHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool EDPPPPFEFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int PBLGNAAIMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "4")]
	void OMEGGDGJFLC(DOBJKAJCHGH JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
	void GCEPDPMBIJN(bool LAHBFONCBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "6")]
	bool LBLECHFELNO(GEDEGCEHLJI GMOJJMIJPJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "7")]
	void MEIPBIKJOCA(object BFDCDDMLJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "8")]
	void MCMLCFFGNJE(object BFDCDDMLJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "9")]
	void DOBIOFJKEDN(object EJGAMJDEIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "10")]
	void NCHEMBCCLEE(object EJGAMJDEIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "11")]
	void NJAENCHLIJM(NativeArray<ViewId> KPKAKDEJFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "12")]
	void ALPBAIFPLIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "13")]
	void LEAEMJNIBKG(KADFMNJDFHC ADFFEBFOCBD, ReadOnlySpan<byte> LLDJIJICLJF, GEDEGCEHLJI LMDPJCFOIAM, bool EHBBJKCBEON = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "14")]
	void LEAEMJNIBKG(KADFMNJDFHC ADFFEBFOCBD, ReadOnlySpan<byte> AGOFHAKDKIE, bool EHBBJKCBEON = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "15")]
	void LEAEMJNIBKG(KADFMNJDFHC ADFFEBFOCBD, ReadOnlySpan<byte> AGOFHAKDKIE, ReadOnlySpan<byte> PNLOJPGBKOM, bool EHBBJKCBEON = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "16")]
	void LIAAHCIFKIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "17")]
	void ILAFNEBDBNL(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "18")]
	void FKDEPGECIGO(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "19")]
	void OAOLHDFAEHN(Dictionary<object, object> OBBDNBEGFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "20")]
	void HEOBPNEIOHN(NativeList<FCEEFAMELLC> PHHFPFNGPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "22")]
	void DEGDECDLCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "23")]
	void NEJIAHFFBAI(List<object> IFDKMFMNDDG, int PKAJCFBDMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "24")]
	void DCMODEBFKKA(int MNOCOFLMADB, object MCKCODFDFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "25")]
	void EKJHAONNEOL(GEDEGCEHLJI GMOJJMIJPJF, Dictionary<object, object> HBMPGPFHEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "26")]
	void GPPHNGGGGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "27")]
	void MFHKAPLPKAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class MLJHOCFLNMH
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7625B00", Offset = "0x7624700", VA = "0x187625B00")]
	public static EMICDJHNKOM EKINNFLOBMI(this PFNACAGABIF ENEHENBPLMA, object IKLHDHMJFFL)
	{
		return default(EMICDJHNKOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct EMICDJHNKOM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private PFNACAGABIF ENEHENBPLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private object IKLHDHMJFFL;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x761E710", Offset = "0x761D310", VA = "0x18761E710")]
	public EMICDJHNKOM(PFNACAGABIF ENEHENBPLMA, object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x761E6C0", Offset = "0x761D2C0", VA = "0x18761E6C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface JLCKDOFBPHG
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface CKLJOAJMDKL
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct CNNOIKNKJLJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private CKLJOAJMDKL MPEFELMAHDC;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7619860", Offset = "0x7618460", VA = "0x187619860")]
		public CNNOIKNKJLJ(CKLJOAJMDKL MPEFELMAHDC, string EOKNCNFEICP, string DDGFILEOJLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x76197A0", Offset = "0x76183A0", VA = "0x1876197A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct FLAIJGPHOKN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private CKLJOAJMDKL MPEFELMAHDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Task LFJIOJDNNEN;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x761F000", Offset = "0x761DC00", VA = "0x18761F000", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "0")]
	void PLAKGGDIFGA(string KBPDEFFIKOJ, float ALPIBOHIFKI = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "1")]
	void LBIFFMNFEON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMDJNAJPJPB(bool FPPDIFLLMGH, string EOKNCNFEICP, string DDGFILEOJLO);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "3")]
	void EFFHLLPCBFH(string KBPDEFFIKOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class FJPBAIAPADB
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x761EBE0", Offset = "0x761D7E0", VA = "0x18761EBE0")]
	public static CKLJOAJMDKL.CNNOIKNKJLJ MHOFOJHFOPC(this CKLJOAJMDKL ENEHENBPLMA, string EOKNCNFEICP, string DDGFILEOJLO)
	{
		return default(CKLJOAJMDKL.CNNOIKNKJLJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface ABGOANOCJPE
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OEPEJMOCPHL(GameObject PHPLOOLODCB);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCHEOOAJJGJ(GameObject PHPLOOLODCB);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HNMMAAMKNAJ(int GMOJJMIJPJF);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object KDPHJMDMFAK(OJMCCDFHBJG JKOPHJKJLOL, GameObject PHPLOOLODCB, Action<OJMCCDFHBJG, int> DKDPAFJDNNF);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FKOJBHLDJAD(GameObject PHPLOOLODCB, object NHDPGGELJIH);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[ServiceLifetime(Lifetime.Application)]
public interface KEMAGNOOGJO
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHDDBDHCOJI(object CFMCKCBBBKK, NativeList<byte> LLDJIJICLJF);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object KOHMJABOPGF(NativeArray<byte> LLDJIJICLJF);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[ServiceLifetime(Lifetime.Application)]
public interface LNGFLPFGCCB
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool CHAHGBNADDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate MKBIEAPHILB(PEPDCBAKMHG PMLFHPALNKH, Action<PEPDCBAKMHG> DKDPAFJDNNF);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECMFCAMFGHC(PEPDCBAKMHG PMLFHPALNKH, Delegate DKDPAFJDNNF);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate PMAHDCOKKAC(PEPDCBAKMHG PMLFHPALNKH, Action<PEPDCBAKMHG> PNKEJIFLKIC);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HFHNPNJPNJA(PEPDCBAKMHG PMLFHPALNKH, Delegate DKDPAFJDNNF);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IDCMPKOIAME(PEPDCBAKMHG PMLFHPALNKH);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PEPDCBAKMHG EJFNLIAEPFL(GameObject PHPLOOLODCB);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.Application)]
public interface INNIPIANHGH
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	int NIKIEGCOHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	int PGGLIANDFPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool AAFFOOJAEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool PMGIFFMIKDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool HDALBJLNEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OJMCCDFHBJG AKCCDKMBHJP(int GMOJJMIJPJF);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ServiceLifetime(Lifetime.Application)]
public interface HJGJLEKFDPI
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool PLFEMNKNBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface OAIDNPCNLKP
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	LAHFEONIIDI BBBHJIHEOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	NPIAAOHMPJM GCHACOOLJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BABPHBDGPBD(Transform FDCDPIOJPOG);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FMFJHMBMGEH(Transform FDCDPIOJPOG, EOGPNMLBPJG MJLMKFMDLMK);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GAKNLMGPFPJ(Transform FDCDPIOJPOG, JCPBLDHJLEF PELCJAFICFI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[ServiceLifetime(Lifetime.Application)]
public interface EGLINJBMFHL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action HNBKGGEECGO;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[ServiceLifetime(Lifetime.Application)]
public interface GGCLBDGPFAL
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INHGGABALGB();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[ServiceLifetime(Lifetime.Application)]
public interface MEMKBKFKDKE
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKAAGPAKNKF(GameObject PHPLOOLODCB, MBIGAFAMMKG NCGCKOKLION, EEAIKJADKBJ GFKFEFPEJFC);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFKCCEGCLOI(OJMCCDFHBJG JKOPHJKJLOL, bool JLPOGLNPADJ, float3 MOMKIIIGMNL, quaternion ABEHJAAFDHL);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MNBNMAAAAKJ(PADKPDAFIDF MGIILDCJJIC, PADKPDAFIDF EJGAMJDEIEL, GDGOOJEEKEA KMMNOOJNABL);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CONELGKBDPN(PADKPDAFIDF MGIILDCJJIC, GDGOOJEEKEA KMMNOOJNABL);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJCFOLKMKBG(OMGFNECLCEJ OIKJKABHJIE);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject EBGKDKNMACG(Guid OPMDOHFDHAA);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BNHPAGKFBDM(BLCHCKFJGOA NCLOACDHFOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct ADMPECOONFL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly NativeArray<byte> LLDJIJICLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly GCHandle EHNDIPGCOKP;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7614970", Offset = "0x7613570", VA = "0x187614970")]
	public ADMPECOONFL(ReadOnlyMemory<byte> HHGIEJIAPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7614930", Offset = "0x7613530", VA = "0x187614930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public enum ANGECHLCMPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	V0PreObjectModel = 0,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	V1ObjectModelHierarchy = 1,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	V2ObjectModelHierarchy = 2,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	V3Entities050 = 3,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	V4Entities050Compressed = 4,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	V5BumpObjectModelVersionMay2024 = 5,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OldestCompatibleVersion = 3,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	LatestVersion = 5
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct LKGOIGMMNHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public ByteString LAHKADPNJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public object OOEGLEFHMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public object FBFKFDNKPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public IEnumerable<string> HGIGEEHKFCI;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x567E2A0", Offset = "0x567CEA0", VA = "0x18567E2A0")]
	public LKGOIGMMNHP(ByteString LAHKADPNJDJ, [Optional] object OOEGLEFHMLL, [Optional] object FBFKFDNKPNC, [Optional] IEnumerable<string> HGIGEEHKFCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct OKOCNIEDAEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public object GMNDLLOLLKK;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct DPKNGFGLDMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[Flags]
	public enum DJGMNLANOCE
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		IsInvalid = 1,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		IsStudioPrefab = 2,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		IsBetaOnly = 4,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		IsDevOnly = 8,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		IsR1Only = 0x10
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public RRObjectPrefabData JBGGDOMIMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Guid DIDCADGGMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Guid KAPAKDLAPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Guid KGHCNNJIPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Guid MOEAPHJPHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public DJGMNLANOCE HOHMEIEFKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Color32 KEGADFJLPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int IAAOCCMALBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public HNJGCLBEEGE BIIJCJCMCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int EDFIPMLOOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int EEHNMBKIEDC;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Guid KDGAIDOKOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4AE97E0", Offset = "0x4AE83E0", VA = "0x184AE97E0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool LDIAAAAEENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x761D320", Offset = "0x761BF20", VA = "0x18761D320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool NIHFACJMPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x761D300", Offset = "0x761BF00", VA = "0x18761D300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool IJMHODKOBJG
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x761D310", Offset = "0x761BF10", VA = "0x18761D310")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct HLFIBDIHFNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly CHDAFLBNAED BICIFKAHIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly CHDAFLBNAED AIHKABICJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly uint PCHLPMPFGFA;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7621710", Offset = "0x7620310", VA = "0x187621710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct CHIPPJFCFIC
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly HLFIBDIHFNJ OAGMINHECCA;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7618E00", Offset = "0x7617A00", VA = "0x187618E00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct OEKEPPPKBAO
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly HLFIBDIHFNJ OAGMINHECCA;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7618E00", Offset = "0x7617A00", VA = "0x187618E00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct KCCIOFGABGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal readonly uint PCHLPMPFGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal readonly bool IDOEDFPGDMJ;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7622710", Offset = "0x7621310", VA = "0x187622710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct CHDAFLBNAED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal int KKHFKGIPICC;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7618DA0", Offset = "0x76179A0", VA = "0x187618DA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[ServiceLifetime(Lifetime.Application)]
public interface KPCAJBMFCAB
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	KHCEKLDCAIN JIHDFGDKDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface JLDNHKJMMGM
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface EJJPGJLLJOB
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class MGNFIBCIJMC
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x346EF00", Offset = "0x346DB00", VA = "0x18346EF00")]
	public static PADKPDAFIDF CPEIDJDOMEE<T>(this T JKOPHJKJLOL) where T : JLDNHKJMMGM
	{
		return default(PADKPDAFIDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7624EA0", Offset = "0x7623AA0", VA = "0x187624EA0")]
	public static MonoBehaviour LJEMCKMEBPI(this JLDNHKJMMGM JKOPHJKJLOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7624DE0", Offset = "0x76239E0", VA = "0x187624DE0")]
	public static GameObject FOFMPGFPBEC(this JLDNHKJMMGM JKOPHJKJLOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface OFKEKAEGKPF : JLDNHKJMMGM
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(OJMCCDFHBJG KJFLIOABFFB);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface EHIOIIOOOFD : JLDNHKJMMGM
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface AKNPGIBPEEN
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate void EGIJDFPCIJF(AJLKKCKIALA AKKFKMLCFPH);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event EGIJDFPCIJF FJILPLCJFHH;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface NMANCFJABCG
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface BOCMIOGEADG
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface AOJHHHFEMKF
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(OJMCCDFHBJG HCPEEMDIMBI);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool KGKPOAKOCCN);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KPPHBHFEDHC(OJMCCDFHBJG PJGHLHDAMNE);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface IGJAFJEJLJA
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(JKJFLLICHBF OEHLBJJNDPN);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface JKJFLLICHBF
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	GameObject PHPLOOLODCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Transform FDCDPIOJPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	MMNADIEGNMF JOEEHBGLGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool PFKLMPHGBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MIKJHMPECHP(MMNADIEGNMF FOBBPKHANPP);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HJKIKFEINAB GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class DJNNIFPEELK
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x761C9B0", Offset = "0x761B5B0", VA = "0x18761C9B0")]
	public static void JEBHCBJMBGM(this JKJFLLICHBF PPJMBNBBIOK, EEPNIHLMHOE HJIAOGEIAJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface MMNADIEGNMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	Rigidbody LMCFJKNGFLC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	JKJFLLICHBF MJDOAILBGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	GameObject FOFMPGFPBEC
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Transform DKANJPNMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	MMNADIEGNMF HNLFKIAHAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	MMNADIEGNMF JHCLOFMDCND
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	int IHLOJNOIGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool KDDPDIGHGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool IDCMPKOIAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool DCAJBNFMLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	DDBGNDDKCOF DHBAJIEBKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	PGKFHALECKJ CEHBFLLMLHF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	float FHHLPKEKJCL
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 NDCIBIEBLGF
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 INGOOIDCCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Vector3 FDADPHGJIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 OOHNAEGHCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool MONADMKKLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool OOMJCKOOIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool MDCGNGJFFMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool MDKOMOAIIIA
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Vector3 IPPPMGEJPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Vector3 HAPHIOLJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Vector3 OMLAPECNAOI
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Vector3 PELDPPHALAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	float AIJIDCPBPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	float PIMPOCNJNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	Vector3 AEBPNODKHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	Quaternion JNBMHDELDLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	float LNFNJMGEGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	float PLONLIDEBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	bool IHDBOAJAICE
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	INJLACPLDPA BMIDJOFLCCH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool NNNLOIGOEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Transform GLLFOAFAGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Vector3 NAHOODPCOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	float AIHLPMDGINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	float OCAGNBGFEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Quaternion MPGKBGPDMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	Vector3 FIAHPIOKJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	Quaternion GFLBEFOIGBB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	RigidbodyConstraints EALBMOJKPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	bool NPKNNINDDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	CollisionDetectionMode MJDIBONEBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	bool EDFJJLKIMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GKDNFNOFKME MLLGBFINBNM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event GKDNFNOFKME ACBHKDBCCPP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event GKDNFNOFKME HFHAFGPCCJN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event GKDNFNOFKME MBAOJBPEGPH;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event GKDNFNOFKME NPAOOIFHPJL;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event GKDNFNOFKME PPLNAOMNMFN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event GKDNFNOFKME PCNPJOLDDHA;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event GKPCOHIAIAH CHABONFNFMP;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<CKBJHKOEDDL, CKBJHKOEDDL> GHPAPKAFGPO;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	MMNADIEGNMF LIGAJEJMKLO(int BIEEMEKMINN);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void EHOIEOIGCDD((Quaternion rot, Vector3 moments) GEKAGIBPJGO);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void DKEOJGLDIFP();

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void ALIGLFPBGAK();

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void OCDFJNNGHOI();

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void DOGLMGKBOGG();

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void FGFIKBBGNKB();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void JCGLDFHMCIJ(MMNADIEGNMF MPDLOLIOGJL, bool HDEDJGFEFFK = false);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void OHBDGFHCDOP(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void GMAKCBJGEFG(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 MEDMBNAIIBB(Vector3 KOBCHCGJLLB);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 FBECAFHGFMD(Vector3 CMHAGMHENKF);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void NDCHPBBDEKH();

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void JLDHACAJGFE();

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void FAGDFGFBAJJ();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void CLPCFJILFHH(Vector3 KPFDANNBDMG, Vector3 DJCOHPBIMGB);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void ILGOOKEKFNJ(Vector3 MDCKKGLAALC, Vector3 GIHMFKNIMAP);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void NJBIANIADOP(Vector3 FJMMHMJJINN);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void OINNCCJMKIA(HDEBMOKJEII AHLANEMEBKA, Vector3 CLHLJFLAFEF, float IKBHBGJMCJB, float HCNGNGAPDLK = 8f, float ECOAHHAENAE = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void CELABFNKMLM(NCBHFGHIKBE KJNADMEBEIF, Vector3 OEFJLLAMMJJ, float NBFMMJGHGJM = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void ECHEDHBNPAA(NCBHFGHIKBE KJNADMEBEIF, Vector3 APLHHNGOEFP, float ONMPAKODLON = 7f, float LJHKMJLPGFG = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 ENJNNDLEPCJ(Vector3 MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 IKIBKFMHDDD(Vector3 MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void CHNJMNIJNEM();

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void HOCDBNODBEI(MMNADIEGNMF APINEPJPKIP, object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void MOEGNJKHHMK(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void FKCLKJNLANB();

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void ENNOBFJFNFD();

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void LIIOCOMGKBC();

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool INDNBMGINBH();

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void COFJLBAIBME();

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void FOGKFAFEGLD(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void DJBOLPDJGPB(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void DBCMOEIEBPL(object IKLHDHMJFFL, bool IAKCGCGLECI);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void POBHHGFPNHM(Vector3 JMOMNLNOKEI, Quaternion FJBMELLBPLJ);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void IPNNFFJADLL(Vector3 MKMLABJLANA, Quaternion IADBBDDNDPB);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool OHMEGBDNIAB(float BPPKCFHOFCL);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void DOICKCEOPDP(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void JKBNBFHDLJF(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void GHBBILMDFLD(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void NBOHAKJBPKK(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void HIBENAEJGFN(Vector3 NBNIPGNLIMD, ForceMode KDJAPCNFGKA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void JIICJKOKFLH(Vector3 NBNIPGNLIMD, Vector3 FCININPMBGJ, ForceMode KDJAPCNFGKA);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void HLKADJAGMED(Vector3 PAOIBNHJPJJ, ForceMode KDJAPCNFGKA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void HNDAOKJAHHP(Vector3 PAOIBNHJPJJ, ForceMode KDJAPCNFGKA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool FHPNHGEDKKF(Vector3 JJPEELBONAL, [Out] RaycastHit NNKLPCEFCLH, float JOBEKHJDCMI);

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void MGIEJHBMCFJ();
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface PGKFHALECKJ
{
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKCLCHOBEOP(Vector3 HKFHNLKHPMI);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKOCGBANCEG(Vector3 NNJICJPFFMH);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBJEBDFMJHC(Vector3 HKFHNLKHPMI);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MNIIILDGFJE(Vector3 NNJICJPFFMH);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface DDBGNDDKCOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 PFIDBEMDOLK();

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 PPBIGEPBCJB();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PBMOBELDEOI(float HKNOKFFEMKD, float FBMDEKFLPPM);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate void GKDNFNOFKME(JKJFLLICHBF FCJPKMBDBOH);
[Cpp2IlInjected.Token(Token = "0x200004E")]
public enum DDADDDOOLBC
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	ChildAdded,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	ChildRemoved,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	HierarchyMassUpdated,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	SleepChanged,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	DistanceBandChanged,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	IsKinematicChanged,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Discontinuity,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Destroyed,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public enum HDEBMOKJEII
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate void GKPCOHIAIAH(JKJFLLICHBF FCJPKMBDBOH, bool HDEDJGFEFFK = false);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public enum NCBHFGHIKBE
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct HJKIKFEINAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Rigidbody GLAPFMEOBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public object FBABJFFKOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Vector3 GHLEGGNKMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Vector3 BAIOIKGIMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public HGFGAMBABML DBMDMGIFLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public bool OACKLEJDFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public bool JNEIOADHLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public bool IOPAIGEAPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public bool FLPOIAFNIJO;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct PADKPDAFIDF : IEquatable<PADKPDAFIDF>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static readonly PADKPDAFIDF LMLCJICMNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public GameObject PHPLOOLODCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7627D30", Offset = "0x7626930", VA = "0x187627D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public FCEEFAMELLC CAJKBIGFBMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x76275F0", Offset = "0x76261F0", VA = "0x1876275F0")]
		get
		{
			return default(FCEEFAMELLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public MCAMCBGPIBD IHILAPEPAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7627530", Offset = "0x7626130", VA = "0x187627530")]
		get
		{
			return default(MCAMCBGPIBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public RRObjectPrefabData OAGFFALHCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7627EC0", Offset = "0x7626AC0", VA = "0x187627EC0")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool POPCDBMNBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7628140", Offset = "0x7626D40", VA = "0x187628140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool MNNLIBGPAHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7627510", Offset = "0x7626110", VA = "0x187627510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool LGMCCFGBDCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7627AA0", Offset = "0x76266A0", VA = "0x187627AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool HHJADALJDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x76275D0", Offset = "0x76261D0", VA = "0x1876275D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool GCCBNPKJBKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7627CB0", Offset = "0x76268B0", VA = "0x187627CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool DNMLGKDAHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7627D00", Offset = "0x7626900", VA = "0x187627D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool DNGAIGLBDDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7627AC0", Offset = "0x76266C0", VA = "0x187627AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool EOIJFOPPPLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7628100", Offset = "0x7626D00", VA = "0x187628100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool KKDCADKEADL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7627990", Offset = "0x7626590", VA = "0x187627990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool LDKNJPICDOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x76280C0", Offset = "0x7626CC0", VA = "0x1876280C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public IAPPMGFMGLN PDEEEFMHFLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(IAPPMGFMGLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public BELDNHHLPOG GFANAAFMHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(BELDNHHLPOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public JALBPLPLNBE DGCDNECOHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(JALBPLPLNBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public CFGCPOJNIEN FMJMCGCHCGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(CFGCPOJNIEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public DOHMIKMOMLP IAAHKJMIBDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(DOHMIKMOMLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public DJBEJNAGPML APIFFKMGIAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(DJBEJNAGPML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public AOPFGOOFGMD NPBMEOFINGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(AOPFGOOFGMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public ELONAICMOLD LOMGGGHOAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(ELONAICMOLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public DLJJBKOIKPB MIDKHGJKDCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(DLJJBKOIKPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public CANPOGKHPMD MBEPEDIHHHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(CANPOGKHPMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public PKGPIJFNFDM CMDMOEKKNCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PKGPIJFNFDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public CNGMNHLLBAM DBMKHLBIJNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(CNGMNHLLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public MBMEPDGBDOK OMCPEIAFNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(MBMEPDGBDOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool KJKMJOMJPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x76278A0", Offset = "0x76264A0", VA = "0x1876278A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool MMIGNMPALMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7627B40", Offset = "0x7626740", VA = "0x187627B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool NAAIPBBEOOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7627BD0", Offset = "0x76267D0", VA = "0x187627BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool CPBCDELHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7627690", Offset = "0x7626290", VA = "0x187627690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool ELAOAMJFKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7627B00", Offset = "0x7626700", VA = "0x187627B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool FGHNEBPACNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x76276D0", Offset = "0x76262D0", VA = "0x1876276D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public DBFNJMJBMCM DKANJPNMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(DBFNJMJBMCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public ECEGMHKHOBC DKHCKMBPBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(ECEGMHKHOBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static PADKPDAFIDF NIBCGLOMJGK(OJMCCDFHBJG KJFLIOABFFB)
	{
		return default(PADKPDAFIDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7627FF0", Offset = "0x7626BF0", VA = "0x187627FF0")]
	public BDEPANKCFLP PGFHCDLMMOI()
	{
		return default(BDEPANKCFLP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7627A70", Offset = "0x7626670", VA = "0x187627A70")]
	public MHALOJNHFPJ HHEIHAMNGEJ()
	{
		return default(MHALOJNHFPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7627B80", Offset = "0x7626780", VA = "0x187627B80")]
	public PIEEGOKAPOI KJBBKFMAAIF()
	{
		return default(PIEEGOKAPOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7627CD0", Offset = "0x76268D0", VA = "0x187627CD0")]
	public KNOLOOLEGAN NIINFGGAGEB()
	{
		return default(KNOLOOLEGAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7628070", Offset = "0x7626C70", VA = "0x187628070")]
	public GICEGDEPNFN PHDCMNDGLLF()
	{
		return default(GICEGDEPNFN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7627710", Offset = "0x7626310", VA = "0x187627710")]
	public void EDNNANHDBPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7627C10", Offset = "0x7626810", VA = "0x187627C10")]
	public void LOIALHEPEBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x76279D0", Offset = "0x76265D0", VA = "0x1876279D0")]
	public bool HGKOGLNGEDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7628160", Offset = "0x7626D60", VA = "0x187628160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public PADKPDAFIDF(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7616920", Offset = "0x7615520", VA = "0x187616920")]
	public static bool NIBCGLOMJGK(PADKPDAFIDF MPDLOLIOGJL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static OJMCCDFHBJG NIBCGLOMJGK(PADKPDAFIDF MPDLOLIOGJL)
	{
		return default(OJMCCDFHBJG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7622F50", Offset = "0x7621B50", VA = "0x187622F50")]
	public static bool LBLECGDECIN(PADKPDAFIDF CEDOOEEEDCO, PADKPDAFIDF LJEHMGANCNG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7624F20", Offset = "0x7623B20", VA = "0x187624F20")]
	public static bool AIDLCBIJBIF(PADKPDAFIDF CEDOOEEEDCO, PADKPDAFIDF LJEHMGANCNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7627810", Offset = "0x7626410", VA = "0x187627810", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(PADKPDAFIDF PELBNOCGOOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct IAPPMGFMGLN : IEquatable<IAPPMGFMGLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public RigidTransform BKMFGHKEKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7621C20", Offset = "0x7620820", VA = "0x187621C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public float AIHLPMDGINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7621F00", Offset = "0x7620B00", VA = "0x187621F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public DBFNJMJBMCM DKANJPNMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(DBFNJMJBMCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7621D10", Offset = "0x7620910", VA = "0x187621D10")]
	public void HLPHLIJIGAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public IAPPMGFMGLN(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7621C80", Offset = "0x7620880", VA = "0x187621C80", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(IAPPMGFMGLN PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct BELDNHHLPOG : IEquatable<BELDNHHLPOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private NEOCDLGJFLO FHNJCJABEPA
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7617100", Offset = "0x7615D00", VA = "0x187617100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool LABKPDCHFHG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x76171E0", Offset = "0x7615DE0", VA = "0x1876171E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool JOBCPIOJKBG
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7616C50", Offset = "0x7615850", VA = "0x187616C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool LCEBIGHMDAF
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7617270", Offset = "0x7615E70", VA = "0x187617270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public Guid AIBEGIJMEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7617080", Offset = "0x7615C80", VA = "0x187617080")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Guid HAICHNBGFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7617160", Offset = "0x7615D60", VA = "0x187617160")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Guid MMCGGMEHFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x76169C0", Offset = "0x76155C0", VA = "0x1876169C0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public ECEGMHKHOBC DKHCKMBPBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(ECEGMHKHOBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7616F60", Offset = "0x7615B60", VA = "0x187616F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7617330", Offset = "0x7615F30", VA = "0x187617330")]
	public bool PBBPFAFDNEC([Out] Guid OJOHECDAGPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x76173D0", Offset = "0x7615FD0", VA = "0x1876173D0")]
	public bool PBCCINMKPDO([Out] Guid HNIBCCHLOFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7616E40", Offset = "0x7615A40", VA = "0x187616E40")]
	public void GLMDBCAFDGJ(Guid ODFJOPDFEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7616FF0", Offset = "0x7615BF0", VA = "0x187616FF0")]
	public void HBINOHDMONC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7616D20", Offset = "0x7615920", VA = "0x187616D20")]
	public Guid FIKLMFKJGDP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public BELDNHHLPOG(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7616C90", Offset = "0x7615890", VA = "0x187616C90", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(BELDNHHLPOG PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct PIEEGOKAPOI : IEquatable<PIEEGOKAPOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private NBNNMFACLOB LDIABDDEHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7628FD0", Offset = "0x7627BD0", VA = "0x187628FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public Vector3 NOOFOCLMLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7629280", Offset = "0x7627E80", VA = "0x187629280")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Quaternion EFHPKNMNDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7628C00", Offset = "0x7627800", VA = "0x187628C00")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public PADKPDAFIDF NJEEHMEFIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7628EB0", Offset = "0x7627AB0", VA = "0x187628EB0")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7629030", Offset = "0x7627C30", VA = "0x187629030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7628D40", Offset = "0x7627940", VA = "0x187628D40")]
	public OMGFNECLCEJ BFIDOLBKOND(Allocator LNBNGBBFCIG)
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7628E10", Offset = "0x7627A10", VA = "0x187628E10")]
	public bool BKBMDGEMNGG(PADKPDAFIDF KOIBCEOILEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7628AB0", Offset = "0x76276B0", VA = "0x187628AB0")]
	public void AGPFLNNOIMJ(Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x76293D0", Offset = "0x7627FD0", VA = "0x1876293D0")]
	public void LKLFBAOHOPJ(float PCNANBOKIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x76290C0", Offset = "0x7627CC0", VA = "0x1876290C0")]
	public void JIONBOEKMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public PIEEGOKAPOI(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7616920", Offset = "0x7615520", VA = "0x187616920")]
	public static bool NIBCGLOMJGK(PIEEGOKAPOI MPDLOLIOGJL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static OJMCCDFHBJG NIBCGLOMJGK(PIEEGOKAPOI MPDLOLIOGJL)
	{
		return default(OJMCCDFHBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7628F40", Offset = "0x7627B40", VA = "0x187628F40", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(PIEEGOKAPOI PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct BDEPANKCFLP : IEquatable<BDEPANKCFLP>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly BDEPANKCFLP LMLCJICMNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	private BFCGPAEHKNA CLANIJPFJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x76168C0", Offset = "0x76154C0", VA = "0x1876168C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<PADKPDAFIDF> GIFGPMEDCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x7616270", Offset = "0x7614E70", VA = "0x187616270")]
		get
		{
			return default(Span<PADKPDAFIDF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public string NMFKAOGOELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7616940", Offset = "0x7615540", VA = "0x187616940")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7616840", Offset = "0x7615440", VA = "0x187616840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DBFNJMJBMCM DKANJPNMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(DBFNJMJBMCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public ECEGMHKHOBC DKHCKMBPBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(ECEGMHKHOBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x76167B0", Offset = "0x76153B0", VA = "0x1876167B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7616370", Offset = "0x7614F70", VA = "0x187616370")]
	public void BMINAIEKCIO(BDEPANKCFLP PELBNOCGOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public BDEPANKCFLP(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7616920", Offset = "0x7615520", VA = "0x187616920")]
	public static bool NIBCGLOMJGK(BDEPANKCFLP MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7616720", Offset = "0x7615320", VA = "0x187616720", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(BDEPANKCFLP PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static PADKPDAFIDF NIBCGLOMJGK(BDEPANKCFLP DKGDAEBOJKO)
	{
		return default(PADKPDAFIDF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[DefaultMember("Item")]
public struct EHIKALDMBIK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Dictionary<int, object> LIJANAIJBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private INBEMIBMLGO EPFCDMJMBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool ALLIABLLMPB;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		[CompilerGenerated]
		readonly get
		{
			return default(PADKPDAFIDF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public IMFODMGAGGC MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x761E280", Offset = "0x761CE80", VA = "0x18761E280")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x761E3B0", Offset = "0x761CFB0", VA = "0x18761E3B0")]
	internal EHIKALDMBIK(PADKPDAFIDF CFMCKCBBBKK, bool ALLIABLLMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x761E150", Offset = "0x761CD50", VA = "0x18761E150", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x31E9EF0", Offset = "0x31E8AF0", VA = "0x1831E9EF0")]
	public void AHEKIFPJHGO<T>(IMFODMGAGGC NKANGPLHEGE, T MPDLOLIOGJL, [Optional] T NBKBMLNEBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x761E0A0", Offset = "0x761CCA0", VA = "0x18761E0A0")]
	public void BLAPNJAELFA(IMFODMGAGGC NKANGPLHEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xC3FAB0", Offset = "0xC3E6B0", VA = "0x180C3FAB0")]
	public Dictionary<int, object> GOIAKHMKCGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x761E340", Offset = "0x761CF40", VA = "0x18761E340")]
	private readonly void NKEJAKJMNGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class LIFNBPPFFDM
{
	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7623950", Offset = "0x7622550", VA = "0x187623950")]
	public static EHIKALDMBIK JMOGEPLMALP(this PADKPDAFIDF CFMCKCBBBKK)
	{
		return default(EHIKALDMBIK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct MBMEPDGBDOK : IEquatable<MBMEPDGBDOK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool KGDCIHMFFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x7624080", Offset = "0x7622C80", VA = "0x187624080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public Vector3 JDIBIGPLEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x7623ED0", Offset = "0x7622AD0", VA = "0x187623ED0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7623FE0", Offset = "0x7622BE0", VA = "0x187623FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7623ED0", Offset = "0x7622AD0", VA = "0x187623ED0")]
	public Vector3 COEOLLNPHMD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7624000", Offset = "0x7622C00", VA = "0x187624000")]
	public void JOPLKLCGDKO([In] Vector3 MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x76240C0", Offset = "0x7622CC0", VA = "0x1876240C0")]
	public bool NFGPFHIBEOM([In] Vector3 MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public MBMEPDGBDOK(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7623F50", Offset = "0x7622B50", VA = "0x187623F50", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(MBMEPDGBDOK PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct ECEGMHKHOBC : IEquatable<ECEGMHKHOBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private BFCGPAEHKNA CLANIJPFJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x761DCA0", Offset = "0x761C8A0", VA = "0x18761DCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public OJMCCDFHBJG KBFIGALBBMC
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x761D570", Offset = "0x761C170", VA = "0x18761D570")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public PADKPDAFIDF HNLFKIAHAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x761DB70", Offset = "0x761C770", VA = "0x18761DB70")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public PADKPDAFIDF JHCLOFMDCND
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x761D600", Offset = "0x761C200", VA = "0x18761D600")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x761D9B0", Offset = "0x761C5B0", VA = "0x18761D9B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x761D470", Offset = "0x761C070", VA = "0x18761D470")]
	public Span<PADKPDAFIDF> APFDCJMPNLJ()
	{
		return default(Span<PADKPDAFIDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x761D7B0", Offset = "0x761C3B0", VA = "0x18761D7B0")]
	public Span<PADKPDAFIDF> GDDNDCKGFNP()
	{
		return default(Span<PADKPDAFIDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x761DD00", Offset = "0x761C900", VA = "0x18761DD00")]
	public Span<PADKPDAFIDF> OEBBFJGAAMC()
	{
		return default(Span<PADKPDAFIDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x761D8B0", Offset = "0x761C4B0", VA = "0x18761D8B0")]
	public Span<PADKPDAFIDF> GFNMEOKNPLH()
	{
		return default(Span<PADKPDAFIDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x761DF10", Offset = "0x761CB10", VA = "0x18761DF10")]
	public Span<PADKPDAFIDF> POPCOBGBDIG()
	{
		return default(Span<PADKPDAFIDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x761DA40", Offset = "0x761C640", VA = "0x18761DA40")]
	public bool JCGLDFHMCIJ(PADKPDAFIDF KOIBCEOILEL, bool HFFFHCNLGBK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x761DC00", Offset = "0x761C800", VA = "0x18761DC00")]
	public bool JJOOMELKJPO(PADKPDAFIDF JECGKJCNLGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x761DE00", Offset = "0x761CA00", VA = "0x18761DE00")]
	public PADKPDAFIDF PIEBBONPAJE(uint JDNPACEFHDC)
	{
		return default(PADKPDAFIDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x761D690", Offset = "0x761C290", VA = "0x18761D690")]
	public BDEPANKCFLP DPPNKCBGHFN()
	{
		return default(BDEPANKCFLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public ECEGMHKHOBC(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7616920", Offset = "0x7615520", VA = "0x187616920")]
	public static bool NIBCGLOMJGK(ECEGMHKHOBC MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x761D720", Offset = "0x761C320", VA = "0x18761D720", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(ECEGMHKHOBC PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct JALBPLPLNBE : IEquatable<JALBPLPLNBE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public string GHINAKGEMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7622160", Offset = "0x7620D60", VA = "0x187622160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public string MJNDKHPABFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7622030", Offset = "0x7620C30", VA = "0x187622030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool HBCPEDMCHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x76224E0", Offset = "0x76210E0", VA = "0x1876224E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public string PNFCPFNBIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x76221E0", Offset = "0x7620DE0", VA = "0x1876221E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string BNBMBNKCACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7622290", Offset = "0x7620E90", VA = "0x187622290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public string NOLEFBMDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7622680", Offset = "0x7621280", VA = "0x187622680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public JALBPLPLNBE(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x7621FA0", Offset = "0x7620BA0", VA = "0x187621FA0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(JALBPLPLNBE PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct GICEGDEPNFN : IEquatable<GICEGDEPNFN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private BAFDIDPMENC OLKLIAGFJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x761F900", Offset = "0x761E500", VA = "0x18761F900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public AOMEDNFEJFK GOPOKPODOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x761F960", Offset = "0x761E560", VA = "0x18761F960")]
		get
		{
			return default(AOMEDNFEJFK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x76204A0", Offset = "0x761F0A0", VA = "0x1876204A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public bool HOOCOKHKCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x76205B0", Offset = "0x761F1B0", VA = "0x1876205B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7620240", Offset = "0x761EE40", VA = "0x187620240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public EOGBGIGFMKC<string> EKJOHCPIEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x761FC10", Offset = "0x761E810", VA = "0x18761FC10")]
		get
		{
			return default(EOGBGIGFMKC<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x761FD30", Offset = "0x761E930", VA = "0x18761FD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public EOGBGIGFMKC<string> MMOAIIJCFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x761FA60", Offset = "0x761E660", VA = "0x18761FA60")]
		get
		{
			return default(EOGBGIGFMKC<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7620000", Offset = "0x761EC00", VA = "0x187620000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public EOGBGIGFMKC<string> JPJNHBKIDHA
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x76202E0", Offset = "0x761EEE0", VA = "0x1876202E0")]
		get
		{
			return default(EOGBGIGFMKC<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7620120", Offset = "0x761ED20", VA = "0x187620120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public EOGBGIGFMKC<string> CNIOHDALIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x761FEE0", Offset = "0x761EAE0", VA = "0x18761FEE0")]
		get
		{
			return default(EOGBGIGFMKC<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7620640", Offset = "0x761F240", VA = "0x187620640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x761FE50", Offset = "0x761EA50", VA = "0x18761FE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x7620400", Offset = "0x761F000", VA = "0x187620400")]
	public bool MGIHFKPAGJI(OJMCCDFHBJG ECDFLCCNIEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public GICEGDEPNFN(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static OJMCCDFHBJG NIBCGLOMJGK(GICEGDEPNFN MPDLOLIOGJL)
	{
		return default(OJMCCDFHBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x761FB80", Offset = "0x761E780", VA = "0x18761FB80", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(GICEGDEPNFN PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct BCGAAPPOEMF : IEquatable<BCGAAPPOEMF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x76161E0", Offset = "0x7614DE0", VA = "0x1876161E0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(BCGAAPPOEMF PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct CFGCPOJNIEN : IEquatable<CFGCPOJNIEN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Collider MKIJNPKJDHL
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7618AB0", Offset = "0x76176B0", VA = "0x187618AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public LNEANCDCPBK JKAGJBHEPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7618A70", Offset = "0x7617670", VA = "0x187618A70")]
		get
		{
			return default(LNEANCDCPBK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7618A20", Offset = "0x7617620", VA = "0x187618A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public KHFGJEJADIN IJFPALGJCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7618D10", Offset = "0x7617910", VA = "0x187618D10")]
		get
		{
			return default(KHFGJEJADIN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7618840", Offset = "0x7617440", VA = "0x187618840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public GKJNGJEAINA LCEBCKFEAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7618C00", Offset = "0x7617800", VA = "0x187618C00")]
		get
		{
			return default(GKJNGJEAINA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7618990", Offset = "0x7617590", VA = "0x187618990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public float LIOEMKPMIPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7618570", Offset = "0x7617170", VA = "0x187618570")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x76187F0", Offset = "0x76173F0", VA = "0x1876187F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool AOHCIOBOODC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7618890", Offset = "0x7617490", VA = "0x187618890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public bool BDGJLMKMPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7618390", Offset = "0x7616F90", VA = "0x187618390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public bool DDFMBDMOGHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x76186A0", Offset = "0x76172A0", VA = "0x1876186A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public bool GNGLPKPMILN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7618780", Offset = "0x7617380", VA = "0x187618780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public bool HKLBHMPAFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x76189E0", Offset = "0x76175E0", VA = "0x1876189E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7618710", Offset = "0x7617310", VA = "0x187618710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public bool GKKOBJKAHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7618D50", Offset = "0x7617950", VA = "0x187618D50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7618CA0", Offset = "0x76178A0", VA = "0x187618CA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7618400", Offset = "0x7617000", VA = "0x187618400")]
	public bool BAEFCCAIJLM([Out] AOJHHHFEMKF IFONAJCBDBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x76185B0", Offset = "0x76171B0", VA = "0x1876185B0")]
	public bool BKFDCKCNPON([Out] OJMCCDFHBJG EBMDCHEPJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7618C40", Offset = "0x7617840", VA = "0x187618C40")]
	public bool KLGGKAEAOCM(KOKMBHAEOFP DLDAGIPJFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7618310", Offset = "0x7616F10", VA = "0x187618310")]
	public void AAMHGLNDMOB(KOKMBHAEOFP DLDAGIPJFND, bool KOGJFECFIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public CFGCPOJNIEN(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7618900", Offset = "0x7617500", VA = "0x187618900", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(CFGCPOJNIEN PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct KNOLOOLEGAN : IEquatable<KNOLOOLEGAN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool AIKBNMHKEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7622990", Offset = "0x7621590", VA = "0x187622990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public KNOLOOLEGAN(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7622900", Offset = "0x7621500", VA = "0x187622900", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(KNOLOOLEGAN PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct DOHMIKMOMLP : IEquatable<DOHMIKMOMLP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	private MFKFHDEDLJM BNAOIHKFMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x761D180", Offset = "0x761BD80", VA = "0x18761D180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x761D270", Offset = "0x761BE70", VA = "0x18761D270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x761D0E0", Offset = "0x761BCE0", VA = "0x18761D0E0")]
	public void ACBCPEECBFP(bool BGJGCAGNDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public DOHMIKMOMLP(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x761D1E0", Offset = "0x761BDE0", VA = "0x18761D1E0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(DOHMIKMOMLP PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct DJBEJNAGPML : IEquatable<DJBEJNAGPML>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool PLNDJBJNBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x761C5A0", Offset = "0x761B1A0", VA = "0x18761C5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool DLGBFACMNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x761BE80", Offset = "0x761AA80", VA = "0x18761BE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool DLLFCLGAMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x761C670", Offset = "0x761B270", VA = "0x18761C670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool MDKEGFOIPJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x761BD90", Offset = "0x761A990", VA = "0x18761BD90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool JMICOPBCPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x761C370", Offset = "0x761AF70", VA = "0x18761C370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool DAAKNJKBOAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x761C550", Offset = "0x761B150", VA = "0x18761C550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool IKPNJDODGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x761BD40", Offset = "0x761A940", VA = "0x18761BD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool GKHAMMPCDCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x761C3C0", Offset = "0x761AFC0", VA = "0x18761C3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool APCDPEJGOBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x761C500", Offset = "0x761B100", VA = "0x18761C500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool NMIOLPCLJHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x761C060", Offset = "0x761AC60", VA = "0x18761C060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool DGHMPABPMLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x761C5E0", Offset = "0x761B1E0", VA = "0x18761C5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public bool GHOBIPKKCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x761C320", Offset = "0x761AF20", VA = "0x18761C320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public bool BMJABLHJODC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x761C2D0", Offset = "0x761AED0", VA = "0x18761C2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool OFFNHBGMDMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x761C920", Offset = "0x761B520", VA = "0x18761C920")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x761C6C0", Offset = "0x761B2C0", VA = "0x18761C6C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public ILOIBFOGPCD ODFCPGICLIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x761C410", Offset = "0x761B010", VA = "0x18761C410")]
		get
		{
			return default(ILOIBFOGPCD);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x761C4B0", Offset = "0x761B0B0", VA = "0x18761C4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public bool PLFHGAHOJIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x761C140", Offset = "0x761AD40", VA = "0x18761C140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public EEAIKJADKBJ BNBOAGKNPID
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x761BF90", Offset = "0x761AB90", VA = "0x18761BF90")]
		get
		{
			return default(EEAIKJADKBJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x761BDE0", Offset = "0x761A9E0", VA = "0x18761BDE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool LCLBHJOHALA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x761C630", Offset = "0x761B230", VA = "0x18761C630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public Vector3 DMENOIHLFJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x761C7A0", Offset = "0x761B3A0", VA = "0x18761C7A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public Vector3 ONIKLMNMNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x761C720", Offset = "0x761B320", VA = "0x18761C720")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool LCEFLMLGJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x761C820", Offset = "0x761B420", VA = "0x18761C820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x761C0B0", Offset = "0x761ACB0", VA = "0x18761C0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x761C450", Offset = "0x761B050", VA = "0x18761C450")]
	public bool IDPDHLHCMIK(LNPHONEGEAD DLDAGIPJFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x761BE30", Offset = "0x761AA30", VA = "0x18761BE30")]
	public bool BOFIPBJPFOP(MBIGAFAMMKG DLDAGIPJFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x761BED0", Offset = "0x761AAD0", VA = "0x18761BED0")]
	public void DLJBJGJLPHE(MBIGAFAMMKG DLDAGIPJFND, bool KOGJFECFIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x761BF50", Offset = "0x761AB50", VA = "0x18761BF50")]
	public MBIGAFAMMKG ECDIHBLAHEE()
	{
		return default(MBIGAFAMMKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x761C960", Offset = "0x761B560", VA = "0x18761C960")]
	public bool PPKOKOGJBJF(MBIGAFAMMKG MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public DJBEJNAGPML(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x761BFD0", Offset = "0x761ABD0", VA = "0x18761BFD0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(DJBEJNAGPML PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct AOPFGOOFGMD : IEquatable<AOPFGOOFGMD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private KNFJDMDLNGE DFEEHLLBMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7615850", Offset = "0x7614450", VA = "0x187615850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x7615940", Offset = "0x7614540", VA = "0x187615940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7615E70", Offset = "0x7614A70", VA = "0x187615E70")]
	public bool NODOLNOHLBC(GDGOOJEEKEA KMMNOOJNABL, List<PADKPDAFIDF> NGCHBNELFOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7615580", Offset = "0x7614180", VA = "0x187615580")]
	public int AKKANNGBPPD(GDGOOJEEKEA KMMNOOJNABL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x76160B0", Offset = "0x7614CB0", VA = "0x1876160B0")]
	public void PGKHIJCEKLC(List<PADKPDAFIDF> NGCHBNELFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x76159D0", Offset = "0x76145D0", VA = "0x1876159D0")]
	public int HAJPGONHFGE(PADKPDAFIDF EJGAMJDEIEL, GDGOOJEEKEA KMMNOOJNABL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7615C90", Offset = "0x7614890", VA = "0x187615C90")]
	public PADKPDAFIDF KLJMAEKNMBH(int BIEEMEKMINN, GDGOOJEEKEA KMMNOOJNABL)
	{
		return default(PADKPDAFIDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7615B00", Offset = "0x7614700", VA = "0x187615B00")]
	public void KEJLEAODELP(PADKPDAFIDF EJGAMJDEIEL, GDGOOJEEKEA KMMNOOJNABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7615690", Offset = "0x7614290", VA = "0x187615690")]
	public bool DJPPDPAOAIF(PADKPDAFIDF EJGAMJDEIEL, GDGOOJEEKEA KMMNOOJNABL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7615740", Offset = "0x7614340", VA = "0x187615740")]
	public void DNNCANKKJKJ(GDGOOJEEKEA KMMNOOJNABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7615DC0", Offset = "0x76149C0", VA = "0x187615DC0")]
	public bool LKIMCJINEGG(PADKPDAFIDF EJGAMJDEIEL, GDGOOJEEKEA KMMNOOJNABL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7615FA0", Offset = "0x7614BA0", VA = "0x187615FA0")]
	public bool OADHOJLLEMG(GDGOOJEEKEA KMMNOOJNABL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public AOPFGOOFGMD(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x76158B0", Offset = "0x76144B0", VA = "0x1876158B0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(AOPFGOOFGMD PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct ELONAICMOLD : IEquatable<ELONAICMOLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x761E5A0", Offset = "0x761D1A0", VA = "0x18761E5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x761E630", Offset = "0x761D230", VA = "0x18761E630")]
	public void MDAIOAFAFLA(bool MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x761E510", Offset = "0x761D110", VA = "0x18761E510")]
	public void GKPKFJJLAGL(bool MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x31F8850", Offset = "0x31F7450", VA = "0x1831F8850")]
	public T AKOBFANNKJP<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public ELONAICMOLD(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x761E480", Offset = "0x761D080", VA = "0x18761E480", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(ELONAICMOLD PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct DLJJBKOIKPB : IEquatable<DLJJBKOIKPB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool BFOAMEONCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x761CDD0", Offset = "0x761B9D0", VA = "0x18761CDD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x761CE10", Offset = "0x761BA10", VA = "0x18761CE10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public int GONLCAPCCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x761CF80", Offset = "0x761BB80", VA = "0x18761CF80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x761CD40", Offset = "0x761B940", VA = "0x18761CD40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	private JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	private JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x761CEF0", Offset = "0x761BAF0", VA = "0x18761CEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public DLJJBKOIKPB(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x761CE60", Offset = "0x761BA60", VA = "0x18761CE60", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(DLJJBKOIKPB PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct FPLDLGAMELD : IEquatable<FPLDLGAMELD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public int PEDBKKLDKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x761F410", Offset = "0x761E010", VA = "0x18761F410")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x761F2E0", Offset = "0x761DEE0", VA = "0x18761F2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public int AJEIBPFFKAE
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x761F450", Offset = "0x761E050", VA = "0x18761F450")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x761F330", Offset = "0x761DF30", VA = "0x18761F330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public FPLDLGAMELD(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x761F380", Offset = "0x761DF80", VA = "0x18761F380", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(FPLDLGAMELD PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct CANPOGKHPMD : IEquatable<CANPOGKHPMD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private DGDEPPHEOAH LJKNHHELEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x76181E0", Offset = "0x7616DE0", VA = "0x1876181E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private AOFJFMJLAED AIEFINJJJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x7618180", Offset = "0x7616D80", VA = "0x187618180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public bool CMKCJMKMCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x7617860", Offset = "0x7616460", VA = "0x187617860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public bool NGIBCJPGPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x7617D10", Offset = "0x7616910", VA = "0x187617D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public bool JALMPCECMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x76182E0", Offset = "0x7616EE0", VA = "0x1876182E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool JCNCBAFGEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7617B80", Offset = "0x7616780", VA = "0x187617B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool KKFIGGPIMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7617CE0", Offset = "0x76168E0", VA = "0x187617CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public bool CMIOJKKPAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x7617A60", Offset = "0x7616660", VA = "0x187617A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool JCCIGNNJGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x7617EC0", Offset = "0x7616AC0", VA = "0x187617EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool FDHPJDECAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x76178F0", Offset = "0x76164F0", VA = "0x1876178F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool KLBJFKOPPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7617510", Offset = "0x7616110", VA = "0x187617510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x7617C50", Offset = "0x7616850", VA = "0x187617C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7617DB0", Offset = "0x76169B0", VA = "0x187617DB0")]
	public bool LHNGLOONFMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7617E20", Offset = "0x7616A20", VA = "0x187617E20")]
	public PADKPDAFIDF MABMCHHKJGP(PADKPDAFIDF EJGAMJDEIEL)
	{
		return default(PADKPDAFIDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7617750", Offset = "0x7616350", VA = "0x187617750")]
	public OJMCCDFHBJG CEIIMPOFOIF()
	{
		return default(OJMCCDFHBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x76176B0", Offset = "0x76162B0", VA = "0x1876176B0")]
	public bool BFELLOEFJIP(OJMCCDFHBJG FEMKKHLIJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7618240", Offset = "0x7616E40", VA = "0x187618240")]
	public bool ODMHCPHOIAF(OJMCCDFHBJG LIONDHHBAHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x76180D0", Offset = "0x7616CD0", VA = "0x1876180D0")]
	public bool MLOPLLEOMLM(OJMCCDFHBJG EJGAMJDEIEL, [Out] OJMCCDFHBJG FEMKKHLIJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public CANPOGKHPMD(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7616920", Offset = "0x7615520", VA = "0x187616920")]
	public static bool NIBCGLOMJGK(CANPOGKHPMD MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7617AF0", Offset = "0x76166F0", VA = "0x187617AF0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(CANPOGKHPMD PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct MHALOJNHFPJ : IEquatable<MHALOJNHFPJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly MHALOJNHFPJ LMLCJICMNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public AIILLNJMIAK DALKANCPAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7625120", Offset = "0x7623D20", VA = "0x187625120")]
		get
		{
			return default(AIILLNJMIAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public NECIPBBCOII HDIDGNBMAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x7625310", Offset = "0x7623F10", VA = "0x187625310")]
		get
		{
			return default(NECIPBBCOII);
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x76252C0", Offset = "0x7623EC0", VA = "0x1876252C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public GDJFDDEMAEB IAFLIEJMLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x7625160", Offset = "0x7623D60", VA = "0x187625160")]
		get
		{
			return default(GDJFDDEMAEB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x76251A0", Offset = "0x7623DA0", VA = "0x1876251A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public float EDDCLCBJGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7625490", Offset = "0x7624090", VA = "0x187625490")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7624FF0", Offset = "0x7623BF0", VA = "0x187624FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public Vector3 CMALFMDIBPH
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7625240", Offset = "0x7623E40", VA = "0x187625240")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x7625350", Offset = "0x7623F50", VA = "0x187625350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public float ALKEIMCGFGG
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x7625560", Offset = "0x7624160", VA = "0x187625560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public AELPFFMHMMC HPHKIBIIDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x76254D0", Offset = "0x76240D0", VA = "0x1876254D0")]
		get
		{
			return default(AELPFFMHMMC);
		}
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x7625510", Offset = "0x7624110", VA = "0x187625510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public bool CLEGDGHCDDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x7625450", Offset = "0x7624050", VA = "0x187625450")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x7624F40", Offset = "0x7623B40", VA = "0x187624F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public DBFNJMJBMCM DKANJPNMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(DBFNJMJBMCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public ECEGMHKHOBC DKHCKMBPBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(ECEGMHKHOBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x76251F0", Offset = "0x7623DF0", VA = "0x1876251F0")]
	public FDODDAMDMMJ LEJOJFJMNJK()
	{
		return default(FDODDAMDMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x7624FA0", Offset = "0x7623BA0", VA = "0x187624FA0")]
	public KPHGMKHMDMA CEECMLLAPLM()
	{
		return default(KPHGMKHMDMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x76250D0", Offset = "0x7623CD0", VA = "0x1876250D0")]
	private bool GNNPMPCMJCL(AELPFFMHMMC DLDAGIPJFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x76253D0", Offset = "0x7623FD0", VA = "0x1876253D0")]
	public void NCLCPLBNNLP(AELPFFMHMMC DLDAGIPJFND, bool KOGJFECFIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public MHALOJNHFPJ(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x7616920", Offset = "0x7615520", VA = "0x187616920")]
	public static bool NIBCGLOMJGK(MHALOJNHFPJ MPDLOLIOGJL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x7624F20", Offset = "0x7623B20", VA = "0x187624F20")]
	public static bool AIDLCBIJBIF(MHALOJNHFPJ CEDOOEEEDCO, MHALOJNHFPJ LJEHMGANCNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7625040", Offset = "0x7623C40", VA = "0x187625040", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(MHALOJNHFPJ PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct FDODDAMDMMJ : IEquatable<FDODDAMDMMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public MHALOJNHFPJ LKFGAKCPPJD
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(MHALOJNHFPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public PKHCDPIAIHH AFJHNFGAFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x761E830", Offset = "0x761D430", VA = "0x18761E830")]
		get
		{
			return default(PKHCDPIAIHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public FDODDAMDMMJ(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7616920", Offset = "0x7615520", VA = "0x187616920")]
	public static bool NIBCGLOMJGK(FDODDAMDMMJ MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x761E7A0", Offset = "0x761D3A0", VA = "0x18761E7A0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(FDODDAMDMMJ PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[DefaultMember("Item")]
public readonly struct KPHGMKHMDMA : IEquatable<KPHGMKHMDMA>
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static readonly KPHGMKHMDMA LMLCJICMNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private LNINCFCHAFH AIPLNCAFBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x7623180", Offset = "0x7621D80", VA = "0x187623180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public MHALOJNHFPJ LKFGAKCPPJD
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(MHALOJNHFPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public BGBHOGOFFCI LKDAEBNPLHH
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x76231E0", Offset = "0x7621DE0", VA = "0x1876231E0")]
		get
		{
			return default(BGBHOGOFFCI);
		}
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x76229E0", Offset = "0x76215E0", VA = "0x1876229E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public IEnumerable<FLAABHJOBCN> LFKAOMNJCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x7622C30", Offset = "0x7621830", VA = "0x187622C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public FLAABHJOBCN MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x76235D0", Offset = "0x76221D0", VA = "0x1876235D0")]
		get
		{
			return default(FLAABHJOBCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x7622BA0", Offset = "0x76217A0", VA = "0x187622BA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public DBFNJMJBMCM DKANJPNMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(DBFNJMJBMCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	private JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7622EC0", Offset = "0x7621AC0", VA = "0x187622EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7622F60", Offset = "0x7621B60", VA = "0x187622F60")]
	public FLAABHJOBCN LCFOPMOMLEC(float3? FCININPMBGJ, [Optional] quaternion? APLHHNGOEFP, [Optional] Vector3? PCNANBOKIPD)
	{
		return default(FLAABHJOBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7623310", Offset = "0x7621F10", VA = "0x187623310")]
	public FLAABHJOBCN NFGFOODEHEA(int BIEEMEKMINN, float3? FCININPMBGJ, [Optional] quaternion? APLHHNGOEFP, [Optional] Vector3? PCNANBOKIPD)
	{
		return default(FLAABHJOBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7622B00", Offset = "0x7621700", VA = "0x187622B00")]
	public void CDCOAOJOOAA(int BIEEMEKMINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7623540", Offset = "0x7622140", VA = "0x187623540")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public KPHGMKHMDMA(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7616920", Offset = "0x7615520", VA = "0x187616920")]
	public static bool NIBCGLOMJGK(KPHGMKHMDMA MPDLOLIOGJL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7622F50", Offset = "0x7621B50", VA = "0x187622F50")]
	public static bool LBLECGDECIN(KPHGMKHMDMA CEDOOEEEDCO, KPHGMKHMDMA LJEHMGANCNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7622E30", Offset = "0x7621A30", VA = "0x187622E30", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(KPHGMKHMDMA PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct FLAABHJOBCN : IEquatable<FLAABHJOBCN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public KPHGMKHMDMA EMPMCFJDHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x761EE20", Offset = "0x761DA20", VA = "0x18761EE20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public float3 FIAHPIOKJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x761EF40", Offset = "0x761DB40", VA = "0x18761EF40")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x761EFA0", Offset = "0x761DBA0", VA = "0x18761EFA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public quaternion GFLBEFOIGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x761EEA0", Offset = "0x761DAA0", VA = "0x18761EEA0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x761EC70", Offset = "0x761D870", VA = "0x18761EC70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public float3 LNLLHMMCGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x761ED20", Offset = "0x761D920", VA = "0x18761ED20")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x761ECC0", Offset = "0x761D8C0", VA = "0x18761ECC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public KNNDLIBEPCE GNOIKDFAHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x761EEF0", Offset = "0x761DAF0", VA = "0x18761EEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x761ED80", Offset = "0x761D980", VA = "0x18761ED80")]
	public void EPDCBLPDMPH(KPHGMKHMDMA MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public FLAABHJOBCN(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x761ED90", Offset = "0x761D990", VA = "0x18761ED90", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(FLAABHJOBCN PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct PKGPIJFNFDM : IEquatable<PKGPIJFNFDM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private EOPDFLKMIAP JPAEAHHFHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7629F60", Offset = "0x7628B60", VA = "0x187629F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public bool EEEPCDAEAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x76297A0", Offset = "0x76283A0", VA = "0x1876297A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7629C00", Offset = "0x7628800", VA = "0x187629C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool DBBPJEGGGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x762A060", Offset = "0x7628C60", VA = "0x18762A060")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x762A0B0", Offset = "0x7628CB0", VA = "0x18762A0B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public float MBPLGAAADFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x762A110", Offset = "0x7628D10", VA = "0x18762A110")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7629DE0", Offset = "0x76289E0", VA = "0x187629DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public bool FGLBCNGCDAN
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7629D90", Offset = "0x7628990", VA = "0x187629D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	private JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7629A20", Offset = "0x7628620", VA = "0x187629A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x76294E0", Offset = "0x76280E0", VA = "0x1876294E0")]
	public void CBGEKOMJLMK(int MGIILDCJJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x7629600", Offset = "0x7628200", VA = "0x187629600")]
	public bool EHFLEPMJGDP([Out] int MGIILDCJJIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7629FC0", Offset = "0x7628BC0", VA = "0x187629FC0")]
	public void MKCJKFIAIGP(bool BGLIANADLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x76297F0", Offset = "0x76283F0", VA = "0x1876297F0")]
	public bool FLLABAEHLCD(BOKJMHLAGIM DLDAGIPJFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x7629580", Offset = "0x7628180", VA = "0x187629580")]
	public void CPNHEIBGGCG(BOKJMHLAGIM DLDAGIPJFND, bool KOGJFECFIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x7629840", Offset = "0x7628440", VA = "0x187629840")]
	public void GHGCOHBFAJD(float JGKDMLAGOBN, float KBPEFKDCGAF, float OJKCNPPNLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x7629AB0", Offset = "0x76286B0", VA = "0x187629AB0")]
	public void HBKAFCMHCPF(float3 EAJHOHEPIDM, quaternion JMLEEONAAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x7629C60", Offset = "0x7628860", VA = "0x187629C60")]
	public bool HPIDFKMJFOE([Out] float3 EAJHOHEPIDM, [Out] quaternion JMLEEONAAIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x7629E30", Offset = "0x7628A30", VA = "0x187629E30")]
	public bool JDCOIBOLKJK([Out] float NLAEDBIGFLB, [Out] float NCKENMMOAAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x7629990", Offset = "0x7628590", VA = "0x187629990")]
	public void GMKBNHHKGFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public PKGPIJFNFDM(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7629710", Offset = "0x7628310", VA = "0x187629710", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(PKGPIJFNFDM PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct DBFNJMJBMCM : IEquatable<DBFNJMJBMCM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	private JJLPEBMBDPJ DEMBJJNBOFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x761AA60", Offset = "0x7619660", VA = "0x18761AA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Vector3 FIAHPIOKJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x761AED0", Offset = "0x7619AD0", VA = "0x18761AED0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x761B450", Offset = "0x761A050", VA = "0x18761B450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public Quaternion GFLBEFOIGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x761A220", Offset = "0x7618E20", VA = "0x18761A220")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x7619D40", Offset = "0x7618940", VA = "0x187619D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public Vector3 NAHOODPCOHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x761AB20", Offset = "0x7619720", VA = "0x18761AB20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7619FD0", Offset = "0x7618BD0", VA = "0x187619FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public Quaternion MPGKBGPDMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7619B60", Offset = "0x7618760", VA = "0x187619B60")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x761A5F0", Offset = "0x76191F0", VA = "0x18761A5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public float AIHLPMDGINB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7619CA0", Offset = "0x76188A0", VA = "0x187619CA0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x761AE20", Offset = "0x7619A20", VA = "0x18761AE20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public float OCAGNBGFEPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x761AFC0", Offset = "0x7619BC0", VA = "0x18761AFC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public Matrix4x4 OKCHPCGLPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x761A1E0", Offset = "0x7618DE0", VA = "0x18761A1E0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public ECEGMHKHOBC DKHCKMBPBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(ECEGMHKHOBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	private JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x761AC10", Offset = "0x7619810", VA = "0x18761AC10")]
	public MLDOPOKHGBO LENAEOCGLIN()
	{
		return default(MLDOPOKHGBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x761A800", Offset = "0x7619400", VA = "0x18761A800")]
	public void JOAKFELLFAO([Out] Matrix4x4 BMBNADKCDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x761AD20", Offset = "0x7619920", VA = "0x18761AD20")]
	public void LGJFLDEIPDM([In] Vector3 DDPAPHFNFJI, [In] Quaternion CIDNHFONBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x761AC60", Offset = "0x7619860", VA = "0x18761AC60")]
	public void LGJFLDEIPDM([In] RigidTransform KIJMKOAMCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x761A130", Offset = "0x7618D30", VA = "0x18761A130")]
	public void FKIMGLDCIFG([Out] RigidTransform KIJMKOAMCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x761A4F0", Offset = "0x76190F0", VA = "0x18761A4F0")]
	public void ILNKKEAIBBG([In] Vector3 MHHNEOCHIIE, [In] Quaternion OPGFBEBHMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x761A430", Offset = "0x7619030", VA = "0x18761A430")]
	public void ILNKKEAIBBG([In] RigidTransform EHFLCNPKDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x761B060", Offset = "0x7619C60", VA = "0x18761B060")]
	public void NILFEKMKDPD([Out] Vector3 MHHNEOCHIIE, [Out] Quaternion OPGFBEBHMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x761B140", Offset = "0x7619D40", VA = "0x18761B140")]
	public void NILFEKMKDPD([Out] RigidTransform KIJMKOAMCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7619A70", Offset = "0x7618670", VA = "0x187619A70")]
	public UniformTRS BADCKCGDEML()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7619AA0", Offset = "0x76186A0", VA = "0x187619AA0")]
	public void BADCKCGDEML([Out] UniformTRS EHFLCNPKDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7619EE0", Offset = "0x7618AE0", VA = "0x187619EE0")]
	public UniformTRS EKAIBIMHGBD()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7619F10", Offset = "0x7618B10", VA = "0x187619F10")]
	public void EKAIBIMHGBD([Out] UniformTRS KIJMKOAMCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x761B520", Offset = "0x761A120", VA = "0x18761B520")]
	public Vector3 PLBOFNLPBMD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x761B380", Offset = "0x7619F80", VA = "0x18761B380")]
	public void PIOFCCFCOMD([In] Vector3 MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x761B1F0", Offset = "0x7619DF0", VA = "0x18761B1F0")]
	public Vector3 OLNFOEHDBLB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x76198F0", Offset = "0x76184F0", VA = "0x1876198F0")]
	public void AGNCCKBJICL([In] Vector3 MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x761A920", Offset = "0x7619520", VA = "0x18761A920")]
	public Quaternion KAKHIKPGJDH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x761A360", Offset = "0x7618F60", VA = "0x18761A360")]
	public void IGMBLBIJEJF([In] Quaternion MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x761A6C0", Offset = "0x76192C0", VA = "0x18761A6C0")]
	public Quaternion JGDHBGIKLKI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x7619E10", Offset = "0x7618A10", VA = "0x187619E10")]
	public void DMKCFLLINHA([In] Quaternion MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x761B2E0", Offset = "0x7619EE0", VA = "0x18761B2E0")]
	public float ONLPFIJFBJL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x76199C0", Offset = "0x76185C0", VA = "0x1876199C0")]
	public void AJDLODBGNCH(float MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x761B6C0", Offset = "0x761A2C0", VA = "0x18761B6C0")]
	public float PPCOMCDGOCD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x761B610", Offset = "0x761A210", VA = "0x18761B610")]
	public void PNLKDAFIAMJ(float MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public DBFNJMJBMCM(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x761A0A0", Offset = "0x7618CA0", VA = "0x18761A0A0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(DBFNJMJBMCM PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct CNGMNHLLBAM : IEquatable<CNGMNHLLBAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	private JGEACCFLGMN FMKJKGDPNNN
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x76196B0", Offset = "0x76182B0", VA = "0x1876196B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	private JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7615C30", Offset = "0x7614830", VA = "0x187615C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	private JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7619710", Offset = "0x7618310", VA = "0x187619710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x76194E0", Offset = "0x76180E0", VA = "0x1876194E0")]
	public void EDNBAINJOHD(string PPIKKIDENAN, MEOGGIPDCEF NAKGBBMJOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public CNGMNHLLBAM(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x7619620", Offset = "0x7618220", VA = "0x187619620", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(CNGMNHLLBAM PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x76161C0", Offset = "0x7614DC0", VA = "0x1876161C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct AEMJDCKIJJF : IEquatable<AEMJDCKIJJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public BFMNJDOGAFP ABHIALIOBBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7614AF0", Offset = "0x76136F0", VA = "0x187614AF0")]
		get
		{
			return default(BFMNJDOGAFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public AEMJDCKIJJF(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7614A20", Offset = "0x7613620", VA = "0x187614A20", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(AEMJDCKIJJF PELBNOCGOOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct PGJBNHMGIKL : IEquatable<PGJBNHMGIKL>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public struct FIFNPIBFMMK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private OJMCCDFHBJG JKOPHJKJLOL;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x761EB40", Offset = "0x761D740", VA = "0x18761EB40")]
		public FIFNPIBFMMK(OJMCCDFHBJG JKOPHJKJLOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x761EAB0", Offset = "0x761D6B0", VA = "0x18761EAB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x76284C0", Offset = "0x76270C0", VA = "0x1876284C0")]
	public FIFNPIBFMMK AJHJIBHMJAA()
	{
		return default(FIFNPIBFMMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x7628550", Offset = "0x7627150", VA = "0x187628550")]
	public FEOMOBIALKH BEDPGFNKDJP(Allocator LNBNGBBFCIG = Allocator.Temp)
	{
		return default(FEOMOBIALKH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7628980", Offset = "0x7627580", VA = "0x187628980")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> MFHAKMIKJOK(Allocator LNBNGBBFCIG = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x7628850", Offset = "0x7627450", VA = "0x187628850")]
	public NativeArray<FCEEFAMELLC> MFEBFIJGOHG(Allocator LNBNGBBFCIG = Allocator.Temp)
	{
		return default(NativeArray<FCEEFAMELLC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x7628390", Offset = "0x7626F90", VA = "0x187628390")]
	public NativeArray<FCEEFAMELLC> ABIMCMEOMCG(Allocator LNBNGBBFCIG = Allocator.Temp)
	{
		return default(NativeArray<FCEEFAMELLC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7628640", Offset = "0x7627240", VA = "0x187628640")]
	public OMGFNECLCEJ CHIJLEMPJEB(Allocator LNBNGBBFCIG = Allocator.Temp)
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x76282D0", Offset = "0x7626ED0", VA = "0x1876282D0")]
	public OMGFNECLCEJ AAMMBIKPCDE(Allocator LNBNGBBFCIG = Allocator.Temp)
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x7628790", Offset = "0x7627390", VA = "0x187628790")]
	public OMGFNECLCEJ FIPPLDMKIID(Allocator LNBNGBBFCIG = Allocator.Temp)
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public PGJBNHMGIKL(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x7628700", Offset = "0x7627300", VA = "0x187628700", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(PGJBNHMGIKL PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x761D450", Offset = "0x761C050", VA = "0x18761D450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct JJNKNIMJGDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public int HGGNEFAKBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public int OEBPLNMAOIH;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct IADFBMFBFHC : IEquatable<IADFBMFBFHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public PGJBNHMGIKL MELJAPPLKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PGJBNHMGIKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public EAPKFLJDLAI CMBADIJPMCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(EAPKFLJDLAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public AEMJDCKIJJF LIMMJLJHFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(AEMJDCKIJJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7621980", Offset = "0x7620580", VA = "0x187621980")]
	public bool BGOCAJPABMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x7621AB0", Offset = "0x76206B0", VA = "0x187621AB0")]
	public bool FCFELOPADDE([Out] Exception MKDAJBJBGPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public IADFBMFBFHC(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static OJMCCDFHBJG NIBCGLOMJGK(IADFBMFBFHC MPDLOLIOGJL)
	{
		return default(OJMCCDFHBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7621A20", Offset = "0x7620620", VA = "0x187621A20", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(IADFBMFBFHC PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x761D450", Offset = "0x761C050", VA = "0x18761D450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct MAJAHNBKFPL : IDisposable, IEquatable<MAJAHNBKFPL>
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly MAJAHNBKFPL LMLCJICMNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public IADFBMFBFHC MMJDINNGFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(IADFBMFBFHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public PGJBNHMGIKL MELJAPPLKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(PGJBNHMGIKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7623C80", Offset = "0x7622880", VA = "0x187623C80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public MAJAHNBKFPL(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7623D50", Offset = "0x7622950", VA = "0x187623D50", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "5")]
	public bool Equals(MAJAHNBKFPL PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x7623DE0", Offset = "0x76229E0", VA = "0x187623DE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct EAPKFLJDLAI : IEquatable<EAPKFLJDLAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public bool LGNGCEEOIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x761D330", Offset = "0x761BF30", VA = "0x18761D330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	public EAPKFLJDLAI(OJMCCDFHBJG JKOPHJKJLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x7614AC0", Offset = "0x76136C0", VA = "0x187614AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x761D3C0", Offset = "0x761BFC0", VA = "0x18761D3C0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x7614AB0", Offset = "0x76136B0", VA = "0x187614AB0", Slot = "4")]
	public bool Equals(EAPKFLJDLAI PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x761D450", Offset = "0x761C050", VA = "0x18761D450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class MEICDMCKIPG
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private struct FLABCKMBLJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid IEIMOIIMGDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public FFPEJPAPKEM DPGNDCHIGLE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private struct FFPEJPAPKEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int MPDLOLIOGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int LNIKHLPMKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int AMMKPBECHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int FJAGOAADPOO;

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x761E9D0", Offset = "0x761D5D0", VA = "0x18761E9D0")]
		public bool GHMKGEGNGEL([Out] FCEEFAMELLC KFMOBMOKICC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x761EA70", Offset = "0x761D670", VA = "0x18761EA70")]
		public FFPEJPAPKEM(FCEEFAMELLC KFMOBMOKICC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x7624130", Offset = "0x7622D30", VA = "0x187624130")]
	public static Guid FPIOLCGGAJK(this FCEEFAMELLC KFMOBMOKICC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x76241D0", Offset = "0x7622DD0", VA = "0x1876241D0")]
	public static bool HBNOIOLDEMP(this Guid IEIMOIIMGDN, [Out] FCEEFAMELLC KFMOBMOKICC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class GEGNJJDMFAE
{
	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x761F6D0", Offset = "0x761E2D0", VA = "0x18761F6D0")]
	public static JKCBDBLFMMD HOOHOMDEKMP(this OJMCCDFHBJG HGEMPDBGGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x761F670", Offset = "0x761E270", VA = "0x18761F670")]
	public static KNHPIELBCJK BFMNHKCMOKC(this OJMCCDFHBJG HGEMPDBGGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x761F760", Offset = "0x761E360", VA = "0x18761F760")]
	public static EntityManager JKMHIGGDNBD(this OJMCCDFHBJG HGEMPDBGGBJ)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x3375790", Offset = "0x3374390", VA = "0x183375790")]
	internal static bool NMNFMEPECLK<T>(this OJMCCDFHBJG HGEMPDBGGBJ, bool KOGJFECFIAL) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x761F7F0", Offset = "0x761E3F0", VA = "0x18761F7F0")]
	public static bool PAFKIPGMPPN(this OJMCCDFHBJG HGEMPDBGGBJ, ILLBLIKIMND JENIGBAOHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x3375010", Offset = "0x3373C10", VA = "0x183375010")]
	public static bool LIHELEADKKP<T>(this OJMCCDFHBJG HGEMPDBGGBJ) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x3374E90", Offset = "0x3373A90", VA = "0x183374E90")]
	public static bool HDPFEJEKIOL<T>(this OJMCCDFHBJG HGEMPDBGGBJ) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x3375870", Offset = "0x3374470", VA = "0x183375870")]
	[NFDJEKGGDNI]
	public static T PKBEFMAJAJC<T>(this OJMCCDFHBJG HGEMPDBGGBJ) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x3372320", Offset = "0x3370F20", VA = "0x183372320")]
	[NFDJEKGGDNI]
	public static T DCDKBFKAHMA<T>(this OJMCCDFHBJG HGEMPDBGGBJ) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x3374D50", Offset = "0x3373950", VA = "0x183374D50")]
	public static bool FHIEALGCILN<T>(this OJMCCDFHBJG HGEMPDBGGBJ, [Out] T MPDLOLIOGJL) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x3374F40", Offset = "0x3373B40", VA = "0x183374F40")]
	public static T JGHNEOPNJKF<T>(this OJMCCDFHBJG HGEMPDBGGBJ) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x3374DF0", Offset = "0x33739F0", VA = "0x183374DF0")]
	public static T FPPBEFCJFPC<T>(this OJMCCDFHBJG HGEMPDBGGBJ) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal static class FGIDLOKGAKH
{
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DefaultMember("Item")]
public struct FEOMOBIALKH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private OMGFNECLCEJ CGPMLCFDDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> ABGCIMNJIMO;

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x5588B70", Offset = "0x5587770", VA = "0x185588B70")]
	public FEOMOBIALKH(OMGFNECLCEJ CGPMLCFDDHA, NativeArray<EntityRemapUtility.EntityRemapInfo> ABGCIMNJIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x761E990", Offset = "0x761D590", VA = "0x18761E990")]
	public LocalId FBEBPKAKPHB(LocalId CFMCKCBBBKK)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x761E940", Offset = "0x761D540", VA = "0x18761E940")]
	public LocalId FBEBPKAKPHB(int BIEEMEKMINN)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x761E8D0", Offset = "0x761D4D0", VA = "0x18761E8D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NEOCDLGJFLO
{
	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	Guid FKLCMGPBGEF
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	Guid NONFDPCJKBO
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LABKPDCHFHG(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task IGNMFMIGPAL(PADKPDAFIDF CFMCKCBBBKK);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid FIKLMFKJGDP(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GLMDBCAFDGJ(OJMCCDFHBJG JKOPHJKJLOL, Guid HNIBCCHLOFE);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HBINOHDMONC(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task BBPGGFDMGFG(OJMCCDFHBJG DEDKLMDDBBA, OJMCCDFHBJG KOIBCEOILEL);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AFENEELOFNG
{
	[Cpp2IlInjected.Token(Token = "0x17000191")]
	Guid FKLCMGPBGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDMEGHHNHOM(NativeList<Guid> NADHJHONEDI, NativeList<Guid> JLFFLLJFFON, NativeList<FixedString64Bytes> PABEHIJIKHL);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BAKIDPLEFKE
{
	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMGFNECLCEJ CBLEKOPGMEK(Allocator LNBNGBBFCIG);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OMGFNECLCEJ HLDDEPJJCJD(Allocator LNBNGBBFCIG);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KAAHHOGIOCD(OJMCCDFHBJG PJGHLHDAMNE);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BFOAMEONCDA(OJMCCDFHBJG PJGHLHDAMNE);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJNPNFFCNFO(OJMCCDFHBJG PJGHLHDAMNE, int BLMGFGJJCEO);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OJMCCDFHBJG HFEICIMBPAF(OJMCCDFHBJG BCCIBNIJLCO);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MDDPMJNGGFJ(OMGFNECLCEJ MCJEKJAABCE, bool BMCOHKHAEMN);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GEEDJAAIDMB(OJMCCDFHBJG KJFLIOABFFB, bool DABAOKMNKBH);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LPOAHMHLJDH(OJMCCDFHBJG PJGHLHDAMNE);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MFHPAACJLDG(OJMCCDFHBJG PJGHLHDAMNE, bool ENOGEBNAMFC);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int DGPLPILGCNP();
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NBNNMFACLOB
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<OJMCCDFHBJG, OJMCCDFHBJG> GJLIDAFBHHA;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<OJMCCDFHBJG, OJMCCDFHBJG> JKKFNEOJEAG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<OJMCCDFHBJG, OJMCCDFHBJG, OJMCCDFHBJG> ADLDEILDADP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<OJMCCDFHBJG> DEOCHDKKGDK;

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BKBMDGEMNGG(OJMCCDFHBJG JKOPHJKJLOL, OJMCCDFHBJG NHDBIBGECPD);

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OJMCCDFHBJG HPLENBIKJDJ(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OMGFNECLCEJ BFIDOLBKOND(OJMCCDFHBJG JKOPHJKJLOL, Allocator LNBNGBBFCIG);

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	OJMCCDFHBJG PKEBPDAAKBP(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AGPFLNNOIMJ(OJMCCDFHBJG JKOPHJKJLOL, Vector3 JKEOCFELGEH, Quaternion BOMOEFFKLHC);

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LKLFBAOHOPJ(OJMCCDFHBJG JKOPHJKJLOL, float CBPAGEIDANI);

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool BENELFMOENH(OJMCCDFHBJG JKOPHJKJLOL, [Out] OJMCCDFHBJG KOIBCEOILEL);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool CBGCACOCBKK(OJMCCDFHBJG JKOPHJKJLOL, [Out] RigidTransform EDKLNODJAGD);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 MKANNFNJIKH(PIEEGOKAPOI AKLAICMBCOK);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion OKEMCGIMMAE(PIEEGOKAPOI AKLAICMBCOK);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class EMNCDDJDCLI
{
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OPHOBJGEAKL
{
	[Cpp2IlInjected.Token(Token = "0x17000192")]
	object MCHLKABPDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CCLAFHOIELK
{
	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LAONEPFGNOA(OJMCCDFHBJG CFMCKCBBBKK, BLCHCKFJGOA NCLOACDHFOJ);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIAOJGKKBJP(BLCHCKFJGOA NCLOACDHFOJ);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GJNJHBBDMDC(OJMCCDFHBJG JKOPHJKJLOL, [Out] BLCHCKFJGOA DMBPPDCNADK);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[Flags]
public enum BBBDIMJLIDJ
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	IncludeSelf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	IncludeChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	IncludeDescendants = 6,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	IncludeMask = 7,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Disembodied = 8,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Embodied = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	IgnoreEmbodiment = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	EmbodimentMask = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Runtime = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Authored = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	AuthoredAndRuntime = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	HierarchyMask = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	HintInputsAreDisjoint = 0x80
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct LEMIFOMJJOO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly string BGKKCEGMOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly T NBKBMLNEBHK;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x4B25070", Offset = "0x4B23C70", VA = "0x184B25070")]
	public LEMIFOMJJOO(T NBKBMLNEBHK, [Optional][CallerMemberName] string BGKKCEGMOKH)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly LEMIFOMJJOO<int> ANCCFDHGIHM;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly LEMIFOMJJOO<int> HNHBAKDEOGN;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly LEMIFOMJJOO<int> OGAMBDALOBL;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum NHINKAILDEE
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class LLPCJDHOPBH
{
	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x104FE50", Offset = "0x104EA50", VA = "0x18104FE50")]
	public static bool BELJFNJDLNN(this NHINKAILDEE CMPEMMPBPLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x13FBD70", Offset = "0x13FA970", VA = "0x1813FBD70")]
	public static bool FCLMMPAFNFF(this NHINKAILDEE CMPEMMPBPLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2B43F40", Offset = "0x2B42B40", VA = "0x182B43F40")]
	public static bool IDNDHNECDDF(this NHINKAILDEE CMPEMMPBPLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface GFPLMNIAOHA
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public enum FBPPFJPJOHA
	{
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public enum HPGNGJPFMPO
	{
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	FBPPFJPJOHA BOOIEKBLAOH
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	bool PEHNPNFHBLI
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	bool IICIBGLLINN
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	HPGNGJPFMPO FAKLFJAEEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[ServiceLifetime(Lifetime.Application)]
public interface EHEBFLDBPJO
{
	[Cpp2IlInjected.Token(Token = "0x17000197")]
	NHINKAILDEE FGCHEGJGEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	NHINKAILDEE JNBLFNDBNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	NHINKAILDEE DBKCNIGGCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	NHINKAILDEE EIJHJGCMIKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	NHINKAILDEE MKEFPDEDOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	NHINKAILDEE IOIBDBFCNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	NHINKAILDEE OIBBDFBHJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	NHINKAILDEE FDLACDDDGPE
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	NHINKAILDEE FEBKECJJOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	NHINKAILDEE FMJMCGCHCGE
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	NHINKAILDEE HFKEFCJOBDP
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	NHINKAILDEE EBLHJCMCAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	NHINKAILDEE IAAHBLPDJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	NHINKAILDEE MLHDABBLKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	NHINKAILDEE CPBFHNJIOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	NHINKAILDEE HPCMPPKIFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	NHINKAILDEE MJNGPDLABMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int IMOGIGFHIEP(LEMIFOMJJOO<int> BKDMEACEJJF);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BFCGPAEHKNA
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event AKNPGIBPEEN.EGIJDFPCIJF FJILPLCJFHH;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OJMCCDFHBJG DAFGACEDLBJ(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OMGFNECLCEJ EMPAKICJFJI(Allocator LNBNGBBFCIG);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KNNDLIBEPCE FCFIGKMGIIC(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NBBJMKKBBPI(IEnumerable<OJMCCDFHBJG> BODPHKGICHL);

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KNNDLIBEPCE BNDAALFEOML(OJMCCDFHBJG KOIBCEOILEL, OJMCCDFHBJG CGPMLCFDDHA, bool OAPEIOLKDIP, OJMCCDFHBJG EJGAMJDEIEL);

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OJMCCDFHBJG BHGPEABHJBH(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JCGLDFHMCIJ(OJMCCDFHBJG JKOPHJKJLOL, OJMCCDFHBJG KOIBCEOILEL, bool HFFFHCNLGBK = false);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NPAFHDFAIKE(OJMCCDFHBJG JKOPHJKJLOL, OJMCCDFHBJG KOIBCEOILEL);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NNODEGEFBKF(OJMCCDFHBJG LFMDGBLBIJH, OJMCCDFHBJG IAIKAKBLLDN);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	OMGFNECLCEJ FACANJGIJBE(OJMCCDFHBJG KJFLIOABFFB);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GPNNALLKEME(OJMCCDFHBJG JKOPHJKJLOL, OJMCCDFHBJG JANECPAJEDG);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OMGFNECLCEJ GFNMEOKNPLH(OMGFNECLCEJ OBEFMIPAADD, BBBDIMJLIDJ HOHMEIEFKJJ, Allocator LNBNGBBFCIG);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool JJOOMELKJPO(OJMCCDFHBJG JKOPHJKJLOL, OJMCCDFHBJG JECGKJCNLGP);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "15")]
	OJMCCDFHBJG MLEEFADIKAN(OJMCCDFHBJG EJGAMJDEIEL, OJMCCDFHBJG BOCJKOKHCHE);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool HOHFCHELBLB(OJMCCDFHBJG EJGAMJDEIEL, OJMCCDFHBJG BOCJKOKHCHE, [Out] OJMCCDFHBJG NMLDEKKCDCO);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "17")]
	OJMCCDFHBJG HKKMCFINOGP(OJMCCDFHBJG[] MCJEKJAABCE);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "18")]
	OJMCCDFHBJG PIEBBONPAJE(OJMCCDFHBJG JKOPHJKJLOL, uint JDNPACEFHDC);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class DIMDDPFNEEP
{
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x761BC50", Offset = "0x761A850", VA = "0x18761BC50")]
	public static bool KDDPDIGHGFH(this BFCGPAEHKNA IFJIIPEPJID, OJMCCDFHBJG JKOPHJKJLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x761B820", Offset = "0x761A420", VA = "0x18761B820")]
	public static OMGFNECLCEJ GFNMEOKNPLH(this BFCGPAEHKNA KNJAHCCFIOL, OJMCCDFHBJG JKOPHJKJLOL, BBBDIMJLIDJ HOHMEIEFKJJ, Allocator LNBNGBBFCIG)
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x761B7E0", Offset = "0x761A3E0", VA = "0x18761B7E0")]
	public static OMGFNECLCEJ GDDNDCKGFNP(this BFCGPAEHKNA KNJAHCCFIOL, OJMCCDFHBJG JKOPHJKJLOL, Allocator LNBNGBBFCIG)
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x761BD00", Offset = "0x761A900", VA = "0x18761BD00")]
	public static OMGFNECLCEJ POPCOBGBDIG(this BFCGPAEHKNA KNJAHCCFIOL, OJMCCDFHBJG JKOPHJKJLOL, Allocator LNBNGBBFCIG)
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x761B7A0", Offset = "0x761A3A0", VA = "0x18761B7A0")]
	public static OMGFNECLCEJ EOANIFENHKA(this BFCGPAEHKNA KNJAHCCFIOL, OJMCCDFHBJG JKOPHJKJLOL, Allocator LNBNGBBFCIG)
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x761BCC0", Offset = "0x761A8C0", VA = "0x18761BCC0")]
	public static OMGFNECLCEJ OEBBFJGAAMC(this BFCGPAEHKNA KNJAHCCFIOL, OJMCCDFHBJG JKOPHJKJLOL, Allocator LNBNGBBFCIG)
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x761B760", Offset = "0x761A360", VA = "0x18761B760")]
	public static OMGFNECLCEJ APFDCJMPNLJ(this BFCGPAEHKNA KNJAHCCFIOL, OJMCCDFHBJG JKOPHJKJLOL, Allocator LNBNGBBFCIG)
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x761BAB0", Offset = "0x761A6B0", VA = "0x18761BAB0")]
	public static OMGFNECLCEJ GFNMEOKNPLH(this BFCGPAEHKNA KNJAHCCFIOL, OJMCCDFHBJG JKOPHJKJLOL, Allocator LNBNGBBFCIG)
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x761BAF0", Offset = "0x761A6F0", VA = "0x18761BAF0")]
	public static OMGFNECLCEJ IMNOIOIIKKK(this BFCGPAEHKNA KNJAHCCFIOL, OJMCCDFHBJG JKOPHJKJLOL, Allocator LNBNGBBFCIG)
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x761BB30", Offset = "0x761A730", VA = "0x18761BB30")]
	public static OMGFNECLCEJ IMNOIOIIKKK(this BFCGPAEHKNA KNJAHCCFIOL, OMGFNECLCEJ JKOPHJKJLOL, Allocator LNBNGBBFCIG)
	{
		return default(OMGFNECLCEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BAFDIDPMENC
{
	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AOMEDNFEJFK MIAMNCIPBEE(OJMCCDFHBJG PJGHLHDAMNE);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGILIJFBFKF(OJMCCDFHBJG PJGHLHDAMNE, AOMEDNFEJFK AGNNCKGHEAK);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KELLNOPILPI(OJMCCDFHBJG PJGHLHDAMNE);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CGPEMKDPFJD(OJMCCDFHBJG PJGHLHDAMNE, bool MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EOGBGIGFMKC<string> HPDKKKCMLKF(OJMCCDFHBJG PJGHLHDAMNE);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BBBCOBLGMDP(OJMCCDFHBJG PJGHLHDAMNE, EOGBGIGFMKC<string> AJOBKLGCIIG);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EOGBGIGFMKC<string> OJCDHKDJNPB(OJMCCDFHBJG PJGHLHDAMNE);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KGMPJHHANJP(OJMCCDFHBJG PJGHLHDAMNE, EOGBGIGFMKC<string> AJOBKLGCIIG);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EOGBGIGFMKC<string> CJNGPMMJGCO(OJMCCDFHBJG PJGHLHDAMNE);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HAOBKJOIEFD(OJMCCDFHBJG PJGHLHDAMNE, EOGBGIGFMKC<string> AJOBKLGCIIG);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EOGBGIGFMKC<string> EIDOGJJLEGF(OJMCCDFHBJG PJGHLHDAMNE);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BMOCDNIHPEG(OJMCCDFHBJG PJGHLHDAMNE, EOGBGIGFMKC<string> AJOBKLGCIIG);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MGIHFKPAGJI(OJMCCDFHBJG PJGHLHDAMNE, OJMCCDFHBJG ECDFLCCNIEO);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FEEOKHNNLEM
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x761E870", Offset = "0x761D470", VA = "0x18761E870", Slot = "0")]
	Task<IADFBMFBFHC> KNBEJJIGNAM(LKGOIGMMNHP HCOCJKLKJHF, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "1")]
	void FPPGEOKCMAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HMFAFNIBCMF
{
	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	bool MEGOAJBCLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	bool PAFDBONEFNF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	bool JJFDFLGFCBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PBBPCHGIGJC
{
	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CMEHANBJOGD([In] float3 FIJLHFKGIID, [In] float3 JJPEELBONAL, float JOBEKHJDCMI, [Out] LJPFMHLKKIN EELNBOHHFLJ, [Out] OJMCCDFHBJG IMBIPGAJGEI);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int MHCOKFEAEPE([In] float3 FIJLHFKGIID, float GHONGHPPDGL, List<OJMCCDFHBJG> MCJEKJAABCE);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int JABBKGKJMPF(Plane[] OAAAJEOGHEF, float3 FIJLHFKGIID, float3 LFLLFMOBELF, quaternion APLHHNGOEFP, List<OJMCCDFHBJG> MCJEKJAABCE);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ABMCLIBMJEL
{
	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMEHANBJOGD([In] NativeArray<Entity> BMGAGFMALJB, [In] float3 FIJLHFKGIID, [In] float3 JJPEELBONAL, [In] NativeArray<LJPFMHLKKIN> GJABGNPKPEI);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> MHCOKFEAEPE([In] NativeArray<Entity> BMGAGFMALJB, [In] float3 FIJLHFKGIID, float GHONGHPPDGL);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> JABBKGKJMPF([In] NativeArray<Entity> BMGAGFMALJB, [In] NativeArray<float4> FEHDDCNCNCH);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct BOGEMMDNDPJ : BJACBJHGLEM, IEquatable<BOGEMMDNDPJ>
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public int AHDPANGFLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public int IOKKPHFOFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B4ED10", Offset = "0x2B4D910", VA = "0x182B4ED10", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x67DD1D0", Offset = "0x67DBDD0", VA = "0x1867DD1D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x7617470", Offset = "0x7616070", VA = "0x187617470", Slot = "8")]
	public bool Equals(BOGEMMDNDPJ PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x76174C0", Offset = "0x76160C0", VA = "0x1876174C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct LJPFMHLKKIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public float DKJIEPCIPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public float3 HKFKAONALCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GBALJDMBCKB
{
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JCGKMOCONDO
{
	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	HDHHPHJGLDK OIKDPCDAPPA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<OMGFNECLCEJ, NativeArray<RRObjectPrefabData>> FACBJPCPNBK;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<OMGFNECLCEJ> JGLDIDEDLBC;

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MCAMCBGPIBD HLJMEGOFBAO(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	RRObjectPrefabData HFIEGGPDECN(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EAEJNKEAINN(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PADKPDAFIDF EDNNANHDBPE(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KJKMJOMJPLN(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ELGDNEAMGFK(OJMCCDFHBJG JKOPHJKJLOL, [Out] Transform FDCDPIOJPOG);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	OJMCCDFHBJG HCNIEKPEEAF(FCEEFAMELLC KFMOBMOKICC);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool OABKPPCOOKG(FCEEFAMELLC KFMOBMOKICC, [Out] OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FCEEFAMELLC LEHNPLFPAKO(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	OMGFNECLCEJ HCNIEKPEEAF(NativeArray<FCEEFAMELLC> KFMOBMOKICC, Allocator LNBNGBBFCIG, bool LAKKLIGOHKP = true);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KFAABAONLAM(RRObjectPrefabData FDCILKKFHHF, NativeArray<Entity> BMGAGFMALJB);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool NJIEAMIJFCC(NativeArray<EBJGFKOFGAE> IJGDGCDMGDJ, NativeArray<FCEEFAMELLC> CEGEKBDAAEO, NativeArray<Entity> MAPMIGHFIBB);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "18")]
	PADKPDAFIDF PJNDCPJMFHP();

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "19")]
	PADKPDAFIDF EIKFKHHDFFO(RRObjectPrefabData FDCILKKFHHF);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "20")]
	BDEPANKCFLP BIHHMOLNNMO();

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	KPHGMKHMDMA HDFJLIMMBMB();

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	FDODDAMDMMJ BMFFDJGOHPJ(PKHCDPIAIHH NNMANODDHMC);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void JIOGKNFDJNN();

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BGLOJICNAJJ(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool HGKOGLNGEDA(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "26")]
	OMGFNECLCEJ ICMCNOMMHCH(OMGFNECLCEJ GBGBCMCILIE, Allocator LNBNGBBFCIG);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool NMMFNCKLIDM(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	OJMCCDFHBJG DIFHJBCNBGA(Transform FDCDPIOJPOG);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class CKLMEGKOOGC
{
	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x7619180", Offset = "0x7617D80", VA = "0x187619180")]
	public static PADKPDAFIDF NAHALALHMDA(this JCGKMOCONDO NAKGBBMJOPP, LocalId JKOPHJKJLOL)
	{
		return default(PADKPDAFIDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x7619030", Offset = "0x7617C30", VA = "0x187619030")]
	public static OJMCCDFHBJG HCNIEKPEEAF(this JCGKMOCONDO NAKGBBMJOPP, LocalId JKOPHJKJLOL)
	{
		return default(OJMCCDFHBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x7619110", Offset = "0x7617D10", VA = "0x187619110")]
	public static FCEEFAMELLC LEHNPLFPAKO(this JCGKMOCONDO NAKGBBMJOPP, LocalId JKOPHJKJLOL)
	{
		return default(FCEEFAMELLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x7619190", Offset = "0x7617D90", VA = "0x187619190")]
	public static BDEPANKCFLP OGFHBEJKGDG(this JCGKMOCONDO NAKGBBMJOPP, RigidTransform EHFLCNPKDGL)
	{
		return default(BDEPANKCFLP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x7619330", Offset = "0x7617F30", VA = "0x187619330")]
	public static FDODDAMDMMJ PHPPCOLJGNG(this JCGKMOCONDO NAKGBBMJOPP, PKHCDPIAIHH BCNDEFGBDIH, RigidTransform EHFLCNPKDGL)
	{
		return default(FDODDAMDMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x7618E90", Offset = "0x7617A90", VA = "0x187618E90")]
	public static KPHGMKHMDMA FACGOPAHFJH(this JCGKMOCONDO NAKGBBMJOPP, RigidTransform EHFLCNPKDGL)
	{
		return default(KPHGMKHMDMA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x76190E0", Offset = "0x7617CE0", VA = "0x1876190E0")]
	private static void HFONJKCHLIE(PADKPDAFIDF ECEMEIJFCHP, RigidTransform EHFLCNPKDGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
internal interface GMKGNNILKAP
{
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DGDEPPHEOAH
{
	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	bool DKNJHHLDOJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	OJMCCDFHBJG MDMCNKCMICM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	PADKPDAFIDF BIJGDMHPMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event GJEBGEOBAKO MFMKHLKBAGD;

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OJMCCDFHBJG MLEEFADIKAN(OJMCCDFHBJG EJGAMJDEIEL, OJMCCDFHBJG BOCJKOKHCHE);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HOHFCHELBLB(OJMCCDFHBJG EJGAMJDEIEL, OJMCCDFHBJG BOCJKOKHCHE, [Out] OJMCCDFHBJG NMLDEKKCDCO);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CCFGAOBHJLL();

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GBDEJHBPHND();

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CMKCJMKMCAJ(OJMCCDFHBJG EJGAMJDEIEL);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CMIOJKKPAEI(OJMCCDFHBJG EJGAMJDEIEL);
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public delegate void GJEBGEOBAKO(PADKPDAFIDF PHJLMPFJHKI, PADKPDAFIDF HILCMMBGNGF);
[Cpp2IlInjected.Token(Token = "0x200009C")]
public static class LBOJLNGONCO
{
	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x7623870", Offset = "0x7622470", VA = "0x187623870")]
	public static bool PLEIGOPJDCK(this DGDEPPHEOAH LNEKECFEFOM, PADKPDAFIDF EJGAMJDEIEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x7623790", Offset = "0x7622390", VA = "0x187623790")]
	public static bool NNMGIIDOLLL(this DGDEPPHEOAH LNEKECFEFOM, OJMCCDFHBJG EJGAMJDEIEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x7623710", Offset = "0x7622310", VA = "0x187623710")]
	public static bool JCNCBAFGEJN(this DGDEPPHEOAH LNEKECFEFOM, OJMCCDFHBJG EJGAMJDEIEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PMKFHJKLGJJ
{
	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MACHPOLBJBO(NativeList<RRObjectPrefabData> POBLMBODMGA);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KNFJDMDLNGE
{
	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NODOLNOHLBC(PADKPDAFIDF ECEMEIJFCHP, GDGOOJEEKEA KMMNOOJNABL, List<PADKPDAFIDF> NGCHBNELFOG);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int AKKANNGBPPD(PADKPDAFIDF ECEMEIJFCHP, GDGOOJEEKEA KMMNOOJNABL);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PGKHIJCEKLC(PADKPDAFIDF ECEMEIJFCHP, List<PADKPDAFIDF> NGCHBNELFOG);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HAJPGONHFGE(PADKPDAFIDF MGIILDCJJIC, PADKPDAFIDF EJGAMJDEIEL, GDGOOJEEKEA KMMNOOJNABL);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PADKPDAFIDF KLJMAEKNMBH(PADKPDAFIDF MGIILDCJJIC, int BIEEMEKMINN, GDGOOJEEKEA KMMNOOJNABL);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KEJLEAODELP(PADKPDAFIDF MGIILDCJJIC, PADKPDAFIDF EJGAMJDEIEL, GDGOOJEEKEA KMMNOOJNABL);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DJPPDPAOAIF(PADKPDAFIDF MGIILDCJJIC, PADKPDAFIDF EJGAMJDEIEL, GDGOOJEEKEA KMMNOOJNABL);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DNNCANKKJKJ(PADKPDAFIDF MGIILDCJJIC, GDGOOJEEKEA KMMNOOJNABL);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LKIMCJINEGG(PADKPDAFIDF MGIILDCJJIC, PADKPDAFIDF EJGAMJDEIEL, GDGOOJEEKEA KMMNOOJNABL);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HHCMHOPOPNC(Entity MGIILDCJJIC, Entity EJGAMJDEIEL, GDGOOJEEKEA KMMNOOJNABL);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GOALBKOJBAI(Entity MGIILDCJJIC, GDGOOJEEKEA KMMNOOJNABL);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OADHOJLLEMG(PADKPDAFIDF EJGAMJDEIEL, GDGOOJEEKEA KMMNOOJNABL);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GMCAHBACLOI
{
	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	AEMJDCKIJJF ALBBPPELMNC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFMNJDOGAFP PDGFHBAECHP(AEMJDCKIJJF GEINBKBBJLL);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AEMJDCKIJJF ECLGNINNPKL();

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AEMJDCKIJJF OPCBCPJLENJ();
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AOFJFMJLAED
{
	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFELLOEFJIP(OJMCCDFHBJG EJGAMJDEIEL, OJMCCDFHBJG FEMKKHLIJJM);

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ODMHCPHOIAF(OJMCCDFHBJG EJGAMJDEIEL, OJMCCDFHBJG LIONDHHBAHE);

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MLOPLLEOMLM(OJMCCDFHBJG EJGAMJDEIEL, [Out] OJMCCDFHBJG OHENLPDEJKL);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GGODPBKOJHB
{
	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDAIOAFAFLA(OJMCCDFHBJG KJFLIOABFFB, bool MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKPKFJJLAGL(OJMCCDFHBJG KJFLIOABFFB, bool MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LAMODBHIBJC(OJMCCDFHBJG KJFLIOABFFB, int MPDLOLIOGJL);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LNINCFCHAFH
{
	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<OJMCCDFHBJG> GMNNCCAACKO(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OJMCCDFHBJG LGLGDHJPANI(OJMCCDFHBJG JKOPHJKJLOL, int BIEEMEKMINN);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int CHCNNANIEBP(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BGBHOGOFFCI MDHJDEPFNPB(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EGBCPBPLDNP(OJMCCDFHBJG JKOPHJKJLOL, BGBHOGOFFCI KNNHCEBFGKJ);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OJMCCDFHBJG FKKMFNNGPHE(OJMCCDFHBJG JKOPHJKJLOL, [Optional] float3? FCININPMBGJ, [Optional] quaternion? APLHHNGOEFP, [Optional] float3? PCNANBOKIPD);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OJMCCDFHBJG LNMPOCAKKJC(OJMCCDFHBJG JKOPHJKJLOL, int BIEEMEKMINN, [Optional] float3? FCININPMBGJ, [Optional] quaternion? APLHHNGOEFP, [Optional] float3? PCNANBOKIPD);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IBCJJOJJOOF(OJMCCDFHBJG JKOPHJKJLOL, int BIEEMEKMINN);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DMHNJJEAMCG(OJMCCDFHBJG JKOPHJKJLOL);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OFBNHAOBLAJ
{
	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	bool CHBFPONNKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DHCLPDCMGBA();

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GALKELNBOHN();

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LNGNGMINEJD();

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FOJHHBGBKBI();

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IOLKCMCJNLO();

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KLEBMJIBJMI();

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KGPNGPOHMFN();

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CLPCDGPNMLE();

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KMDNLOOKKNP();

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BOEMCLCJAKH();

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GPIMGMJFBLI();

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IPGNPABBBKF();
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EOPDFLKMIAP
{
	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EHFLEPMJGDP(OJMCCDFHBJG EJGAMJDEIEL, [Out] int MGIILDCJJIC);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBGEKOMJLMK(OJMCCDFHBJG EJGAMJDEIEL, int MGIILDCJJIC);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKCJKFIAIGP(OJMCCDFHBJG EJGAMJDEIEL, bool BGLIANADLHJ);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GHGCOHBFAJD(OJMCCDFHBJG EJGAMJDEIEL, float JGKDMLAGOBN, float KBPEFKDCGAF, float OJKCNPPNLMN);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JDCOIBOLKJK(OJMCCDFHBJG JKOPHJKJLOL, [Out] float KBPEFKDCGAF, [Out] float OJKCNPPNLMN);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HBKAFCMHCPF(OJMCCDFHBJG EJGAMJDEIEL, float3 FCININPMBGJ, quaternion APLHHNGOEFP);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HPIDFKMJFOE(OJMCCDFHBJG EJGAMJDEIEL, [Out] float3 FCININPMBGJ, [Out] quaternion APLHHNGOEFP);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GMKBNHHKGFA(OJMCCDFHBJG EJGAMJDEIEL);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JJLPEBMBDPJ
{
	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIOFCCFCOMD(Entity CANLONBNOKL, [In] float3 MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 PLBOFNLPBMD(Entity CANLONBNOKL);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IGMBLBIJEJF(Entity CANLONBNOKL, [In] quaternion MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion KAKHIKPGJDH(Entity CANLONBNOKL);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGJFLDEIPDM(Entity CANLONBNOKL, [In] float3 FCININPMBGJ, [In] quaternion APLHHNGOEFP);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FKIMGLDCIFG(Entity CANLONBNOKL, [Out] RigidTransform CBPEDMNKLFF);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ILNKKEAIBBG(Entity CANLONBNOKL, [In] float3 FCININPMBGJ, [In] quaternion APLHHNGOEFP);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NILFEKMKDPD(Entity CANLONBNOKL, [Out] float3 FCININPMBGJ, [Out] quaternion APLHHNGOEFP);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NILFEKMKDPD(Entity CANLONBNOKL, [Out] RigidTransform CBPEDMNKLFF);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AJDLODBGNCH(Entity CANLONBNOKL, float MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float ONLPFIJFBJL(Entity CANLONBNOKL);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AGNCCKBJICL(Entity CANLONBNOKL, [In] float3 MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 OLNFOEHDBLB(Entity CANLONBNOKL);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DMKCFLLINHA(Entity CANLONBNOKL, [In] quaternion MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion JGDHBGIKLKI(Entity CANLONBNOKL);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PNLKDAFIAMJ(Entity CANLONBNOKL, float MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float PPCOMCDGOCD(Entity CANLONBNOKL);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BHBCDHGCHNM(Entity CANLONBNOKL, [Out] float4x4 BMBNADKCDGO);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HCFOLBCEAHN(Entity CANLONBNOKL, [In] float4x4 BMBNADKCDGO);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JNLOCHIPKAL(Entity CANLONBNOKL);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LOMDBJFNPHE(Entity CANLONBNOKL, Entity MHNGCBODOJP, Entity BDHPANPFDPF);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class HONIECMLMEJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BNLKHDBJKHJ
{
	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGGHCBKAGAJ(bool BCGLHGDCEPK);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JGEACCFLGMN
{
	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLNCLKDBFFL(OJMCCDFHBJG PJGHLHDAMNE, EOGBGIGFMKC<string> AJOBKLGCIIG);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CFKACADENAF(OJMCCDFHBJG PJGHLHDAMNE, EOGBGIGFMKC<string> AJOBKLGCIIG);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNHMFGDNCFM(OJMCCDFHBJG PJGHLHDAMNE, EOGBGIGFMKC<string> AJOBKLGCIIG);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void APEMMKAIMNP(OJMCCDFHBJG PJGHLHDAMNE, EOGBGIGFMKC<string> AJOBKLGCIIG);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BHHCBICMOGL(OJMCCDFHBJG PJGHLHDAMNE, EOGBGIGFMKC<string> AJOBKLGCIIG);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AIEHBAGJCAD(OJMCCDFHBJG PJGHLHDAMNE, EOGBGIGFMKC<string> AJOBKLGCIIG);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int MIBFINMLDOP(OJMCCDFHBJG PJGHLHDAMNE);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int BPLMAHJGJMJ(OJMCCDFHBJG PJGHLHDAMNE);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int JCJJDILBNNB(OJMCCDFHBJG PJGHLHDAMNE);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HKBIAANNAOH<string> OAHGAGOLCPC(OJMCCDFHBJG PJGHLHDAMNE);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BLDOBNMFKGK(OJMCCDFHBJG PJGHLHDAMNE);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HKBIAANNAOH<string> KBKMIGBNIOA(OJMCCDFHBJG PJGHLHDAMNE);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MAKOOCJNOJP(OJMCCDFHBJG PJGHLHDAMNE, string PPIKKIDENAN);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AEFCMPBBIPG(string PPIKKIDENAN, MEOGGIPDCEF ONEEDNDADID);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OJMCCDFHBJG KMAFAJEEMBL(string PPIKKIDENAN);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PLOKCKDEBGA(string PPIKKIDENAN, MEOGGIPDCEF ONEEDNDADID);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EDNBAINJOHD(OJMCCDFHBJG NIKJEPENDHH, string PPIKKIDENAN, MEOGGIPDCEF ONEEDNDADID);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class MPAFFNGBKCF
{
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MCKHFDMCKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World ANABJILFIAE(string NDHJLNENKKD = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World MMDDBJCCDLF(string NDHJLNENKKD = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World DNMPEECFDEO(string NDHJLNENKKD = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World EMKHGJOPOAC(string NDHJLNENKKD = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KNHPIELBCJK
{
	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	World KIPGLKLKGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	World NFIGAKABLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	EntityManager JKMHIGGDNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	bool DFIMOLGJAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase INMLPILOPFA(Type ADFFEBFOCBD);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class EFECCAKAJKC
{
	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x761E010", Offset = "0x761CC10", VA = "0x18761E010")]
	public static ComponentSystemBase MIFOFCBGJCC(this World CDEKECFBCAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x31CEA30", Offset = "0x31CD630", VA = "0x1831CEA30")]
	public static T INMLPILOPFA<T>(this KNHPIELBCJK BDAGNDLJJCO) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EKMGMMMFEMP
{
	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ENJPADIHFAI(NativeListAsync<Entity> JCLKNGLHIED);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LONALBPEGBI(GKHGDFHCCMI IKFNAHKGPII);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KPCMECOAJEN(NativeListAsync<Entity> JECFHMFBPKP, bool MAPCCPLDLID);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MPAHOICJHLK();

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OGHOGLGBNBF(Entity EBMDCHEPJIM);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface GHABOPFKPCI
{
	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EMNHEGACLDO(Collider IFONAJCBDBF, [Out] HHFACALNCHA MAJKMKGIJJE);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KAALCMFCOAB
{
	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider GFMOMCOFHPI(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject EFNCPJNEDJI(OJMCCDFHBJG CJIDFMIPBEJ, GameObject DLFNGKIHPEG, Vector3 DDPAPHFNFJI, Quaternion CIDNHFONBIJ);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FHAKDNFHPCD(GameObject IFONAJCBDBF);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider KHAGCDHKMEF<TCollider>(GameObject FNCMEMLDAGM) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AMLFGPLBOBN(Collider IFONAJCBDBF);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject BNDKBAGOAEA<TCollider>(string BGKKCEGMOKH) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AOJHHHFEMKF BGLIDANBHHK(OJMCCDFHBJG KPIELFOMKKA, OJMCCDFHBJG LLPBNGFKJGI, PKHCDPIAIHH FIMLHMHBCCN, float3 FPJKDPJKCFC, quaternion MIEKGOFFJBE, float3 AHOEGMFCFON);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BAEFCCAIJLM(OJMCCDFHBJG JKOPHJKJLOL, [Out] AOJHHHFEMKF IFONAJCBDBF);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HKGNELBAEII(OJMCCDFHBJG JKOPHJKJLOL, [Out] OJMCCDFHBJG EBMDCHEPJIM);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public enum JFBCMENNCAH
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CCMEPOLNAJF
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public struct FNDAJBCLMCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int FIMLHMHBCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public GameObject DLFNGKIHPEG;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACKHLDNFEJL(OJMCCDFHBJG JKOPHJKJLOL, LNEANCDCPBK IEGNHNOHOFO, bool CALNINKNKAJ, KOKMBHAEOFP BNJLPMMADNM);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OBFILKEDJEA(OJMCCDFHBJG JKOPHJKJLOL, LNEANCDCPBK IEGNHNOHOFO, bool CALNINKNKAJ, bool NHKKPDFHDEA, bool PHDJONBHAHA);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CKNGAJFJNCH APGGJAPPLIM(OJMCCDFHBJG EBMDCHEPJIM, List<OJMCCDFHBJG> HFJAAOKINCG);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AOJHHHFEMKF NECMFKJHPGC(GameObject PEIFEHIMJPA, GameObject BBNJNMBKJDI);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IKGIMHMEPGE(GameObject PEIFEHIMJPA, List<GameObject> PHANIINACME);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GEJKODEIGPI(GameObject BBNJNMBKJDI);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T KHAGCDHKMEF<T>(GameObject FNCMEMLDAGM) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AMLFGPLBOBN(Collider IFONAJCBDBF);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject JKHDAHCPNBE<T>(string BGKKCEGMOKH) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OMDPNGMBFMA(Collider IFONAJCBDBF, [Out] OJMCCDFHBJG MGIILDCJJIC);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AANMDIFOFKI(OJMCCDFHBJG JKOPHJKJLOL, [Out] HHFACALNCHA MAJKMKGIJJE);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<JFBCMENNCAH> CCPMHPMMBEP(Allocator LNBNGBBFCIG = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] LLMAMGBLLMF();

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int AMLANNLIJDE(LNEANCDCPBK IEGNHNOHOFO);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "14")]
	string KKAKNANJDFH(LNEANCDCPBK IEGNHNOHOFO);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PFBHDOJMGLM
{
	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOMJBDKJEKF(OJMCCDFHBJG JKOPHJKJLOL, OJMCCDFHBJG MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCCNKLGIMBC(OJMCCDFHBJG JKOPHJKJLOL, OJMCCDFHBJG MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int NPPMAKLEJEI(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OJMCCDFHBJG LIGAJEJMKLO(OJMCCDFHBJG JKOPHJKJLOL, int BIEEMEKMINN);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OMGFNECLCEJ FBFHCOLAIOE(OJMCCDFHBJG JKOPHJKJLOL, Allocator LNBNGBBFCIG = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BNNBBAGFHKO(OJMCCDFHBJG JKOPHJKJLOL, object IKLHDHMJFFL, OJMCCDFHBJG MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OLJFJAJFPBP(OJMCCDFHBJG JKOPHJKJLOL, object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HCCBLPEIJNP(OJMCCDFHBJG JKOPHJKJLOL, [Out] OJMCCDFHBJG MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NGAFHKJEPIJ(OJMCCDFHBJG JKOPHJKJLOL, float3 MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EIBCJMBFMNH(OJMCCDFHBJG JKOPHJKJLOL, [Out] float3 MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DJLDCINPALM(OJMCCDFHBJG JKOPHJKJLOL, float3 MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FEJAPFGPICL(OJMCCDFHBJG JKOPHJKJLOL, [Out] float3 MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FJJEIKDFLCG(OJMCCDFHBJG JKOPHJKJLOL, (Quaternion rot, Vector3 moments) GEKAGIBPJGO);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool LJMNAMBBAJM(OJMCCDFHBJG JKOPHJKJLOL, [Out] quaternion PHEHLBBHLCL, [Out] float3 JIJINELIHGJ);

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FOPPFBCLNCP(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 LHPLJCOCHJO(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 GGBEMGJGLDE(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HMIMPDCJGHG(OJMCCDFHBJG JKOPHJKJLOL, float3 MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NKFIMHIPKEA(OJMCCDFHBJG JKOPHJKJLOL, float3 MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float EKGJLIIKKCO(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float MJGPBKCKFMG(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AMMDJMNEIGB(OJMCCDFHBJG JKOPHJKJLOL, float MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KCMHLMKEHMG(OJMCCDFHBJG JKOPHJKJLOL, float MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode HKABGNKJNIB(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JNJFKKGFPLE(OJMCCDFHBJG JKOPHJKJLOL, CollisionDetectionMode MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "25")]
	INJLACPLDPA BNPBOPJICNP(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IOHLMNNLBCF(OJMCCDFHBJG JKOPHJKJLOL, INJLACPLDPA MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool JKGFPCGMBME(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BNJOEINGFAG(OJMCCDFHBJG JKOPHJKJLOL, bool MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "29")]
	OJMCCDFHBJG DAFGACEDLBJ(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MFGCHDNPDNO(OJMCCDFHBJG JKOPHJKJLOL, OJMCCDFHBJG MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "31")]
	OJMCCDFHBJG BHGPEABHJBH(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void JCGLDFHMCIJ(OJMCCDFHBJG JKOPHJKJLOL, OJMCCDFHBJG MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "33")]
	HGFGAMBABML PAIANHCEGON(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void MHCAFAJOMFC(OJMCCDFHBJG JKOPHJKJLOL, HGFGAMBABML DBMDMGIFLNH);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool LMGBHDOKCAF(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void PGDBCKAMOFO(OJMCCDFHBJG JKOPHJKJLOL, bool MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool BMMPIPBCMKP(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void PDNHAHAGNEJ(OJMCCDFHBJG JKOPHJKJLOL, bool MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints ODIOFJHEGJH(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void HNILHLJMFEL(OJMCCDFHBJG JKOPHJKJLOL, RigidbodyConstraints MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float JKLGFKHONOF(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void DGEEOJHIHFJ(OJMCCDFHBJG JKOPHJKJLOL, float MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float HMKBDJOBCBN(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void DEJHAOIBOAO(OJMCCDFHBJG JKOPHJKJLOL, float MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool FECJJNBHMJO(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void HBGCAHDLIBF(OJMCCDFHBJG JKOPHJKJLOL, bool MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool KIBMFHGOEMJ(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void EBBCMHEJEOC(OJMCCDFHBJG JKOPHJKJLOL, bool MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void PFPMJJPOCPN(OJMCCDFHBJG JKOPHJKJLOL, int MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "50")]
	DDBGNDDKCOF HGCCLMAILIO(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void NIMKMFMJBJO(OJMCCDFHBJG JKOPHJKJLOL, DDBGNDDKCOF MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "52")]
	PGKFHALECKJ LKAKILPHCMC(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void AEGAAINKCFM(OJMCCDFHBJG JKOPHJKJLOL, PGKFHALECKJ MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float JAOKNKBAOHD(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void BLLPPMAJAPN(OJMCCDFHBJG JKOPHJKJLOL, float MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void FOBCGEHOGJC(OJMCCDFHBJG JKOPHJKJLOL, object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void NIPEHHMFNOE(OJMCCDFHBJG JKOPHJKJLOL, object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool JDIPCJCHANA(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void DHFNJAOGLPC(OJMCCDFHBJG JKOPHJKJLOL, object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void LNLGENBDEIJ(OJMCCDFHBJG JKOPHJKJLOL, object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool HOFKMFIOOMH(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool INBGCBDICKE(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody EJADLLOEDCC(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void AOPEAPHKLFG(OJMCCDFHBJG JKOPHJKJLOL, Rigidbody NIAHBPBMHAK);

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void GHBBILMDFLD(OJMCCDFHBJG JKOPHJKJLOL, object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void NBOHAKJBPKK(OJMCCDFHBJG JKOPHJKJLOL, object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool FHCKGNLFGCK(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void PJDLKNLDECA(OJMCCDFHBJG JKOPHJKJLOL, float3 CNPDFOJECOP);

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void CDCJLEEHENJ(OJMCCDFHBJG JKOPHJKJLOL, float3 NNJICJPFFMH);

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool JLJOHKDBNDI(OJMCCDFHBJG JKOPHJKJLOL, [Out] float3 CNPDFOJECOP);

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool ILBAJMKLNLA(OJMCCDFHBJG JKOPHJKJLOL, [Out] float3 NNJICJPFFMH);

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool NNNLOIGOEJJ(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void KELFDFHEODB(OJMCCDFHBJG JKOPHJKJLOL, object IKLHDHMJFFL, bool IAKCGCGLECI);

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void BPLHIKLMDMH(OJMCCDFHBJG JKOPHJKJLOL, bool DINPFPLHNFF);

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void LAINABOKDEM(OJMCCDFHBJG JKOPHJKJLOL);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool FCCONLABKHD(OJMCCDFHBJG JKOPHJKJLOL);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CHHBOLBJOBE
{
	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPGDPMLEKKM(Entity KEEMPPKBHCG);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHPCKOFCEDJ(Entity KEEMPPKBHCG);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MFKFHDEDLJM
{
	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCOAIOGCDJP(OJMCCDFHBJG EJGAMJDEIEL, bool BGJGCAGNDFP);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public delegate void HHOAJOOJKOB(LCFEJCOMHDH DECEMLLIHPF);
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public readonly ref struct LCFEJCOMHDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly OMGFNECLCEJ OIKJKABHJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly NativeArray<byte> KBPCKNBNLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly NativeArray<byte> HALAKJENNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly ILLBLIKIMND JENIGBAOHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly int FEKKBMFIFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Type EDPLEDJNHEE;

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public OMGFNECLCEJ DMHCNBNCKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x4AE9730", Offset = "0x4AE8330", VA = "0x184AE9730")]
		get
		{
			return default(OMGFNECLCEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public int FMELMONACEH
	{
		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x76238F0", Offset = "0x76224F0", VA = "0x1876238F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x7623910", Offset = "0x7622510", VA = "0x187623910")]
	public LCFEJCOMHDH(OMGFNECLCEJ OIKJKABHJIE, NativeArray<byte> KBPCKNBNLNJ, NativeArray<byte> HALAKJENNMD, ILLBLIKIMND JENIGBAOHNC, int FEKKBMFIFCO, Type EDPLEDJNHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x3447690", Offset = "0x3446290", VA = "0x183447690")]
	public NativeArray<T> AHHMPLDEDCF<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x34476D0", Offset = "0x34462D0", VA = "0x1834476D0")]
	public NativeArray<T> DHJGAIIEDKG<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x3447710", Offset = "0x3446310", VA = "0x183447710")]
	public (OMGFNECLCEJ, NativeArray<T>, NativeArray<T>) IMOGIGFHIEP<T>() where T : struct
	{
		return default((OMGFNECLCEJ, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x76238C0", Offset = "0x76224C0", VA = "0x1876238C0")]
	public AJLKKCKIALA FOIHJHLINGC()
	{
		return default(AJLKKCKIALA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public interface CFBPOGDLOCJ
{
	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	string GAJDCMJOLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	CFBPOGDLOCJ DHKIAFCAOFP
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	IEnumerable<CFBPOGDLOCJ> MFBBPAHJKGI
	{
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface OINCFBMLODL
{
	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	CFBPOGDLOCJ MDOEAPKLAKA
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	NativeArray<ILLBLIKIMND> PEHKLBJAILN
	{
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AJOIBDECCFG(ILLBLIKIMND JENIGBAOHNC, [Out] CFBPOGDLOCJ EFKBGLNDIKB);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CHOGICNNBDH(ILLBLIKIMND JENIGBAOHNC, HHOAJOOJKOB IHJCANBBLJE);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MKLJCELBDDO(ILLBLIKIMND JENIGBAOHNC, HHOAJOOJKOB IHJCANBBLJE);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JPHFFDNKLNF
{
	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHOGICNNBDH(ILLBLIKIMND JENIGBAOHNC, HHOAJOOJKOB IHJCANBBLJE);

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKLJCELBDDO(ILLBLIKIMND JENIGBAOHNC, HHOAJOOJKOB IHJCANBBLJE);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class HMIIEGNEANH
{
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JFJCNAGDFGL
{
	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	bool OEKFAKDKOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	AHHNMHODBOD ALMNLGKCNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NEIDEOMGPKI(BFMNJDOGAFP KFMOBMOKICC, bool JFPHMIHNIOM);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GHOMIMOALBJ(FCEEFAMELLC KFMOBMOKICC, ILLBLIKIMND JENIGBAOHNC);

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GLICKPIEFFM(NativeArray<FCEEFAMELLC> IMNICILBLOC);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class LAONIICJKIN
{
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public readonly ref struct AJLKKCKIALA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly LCFEJCOMHDH LLDJIJICLJF;

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	public OMGFNECLCEJ DMHCNBNCKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x4AE9730", Offset = "0x4AE8330", VA = "0x184AE9730")]
		get
		{
			return default(OMGFNECLCEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x7615550", Offset = "0x7614150", VA = "0x187615550")]
	public AJLKKCKIALA(LCFEJCOMHDH LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x7615000", Offset = "0x7613C00", VA = "0x187615000")]
	public OMGFNECLCEJ AHHMPLDEDCF()
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x7615130", Offset = "0x7613D30", VA = "0x187615130")]
	public OMGFNECLCEJ DHJGAIIEDKG()
	{
		return default(OMGFNECLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x7615260", Offset = "0x7613E60", VA = "0x187615260")]
	public (OMGFNECLCEJ, OMGFNECLCEJ, OMGFNECLCEJ) IMOGIGFHIEP()
	{
		return default((OMGFNECLCEJ, OMGFNECLCEJ, OMGFNECLCEJ));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class CEMCFGEJGFC
{
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public readonly struct AHHNMHODBOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly NativeBitArray NNIOMOCGEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly NativeParallelHashMap<FCEEFAMELLC, int> PBGINFCCFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly NativeParallelHashSet<BFMNJDOGAFP> BCKPHLPEIAD;

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	public bool JFEPPPLDGMF
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x7614FE0", Offset = "0x7613BE0", VA = "0x187614FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public bool OEKFAKDKOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x7614FB0", Offset = "0x7613BB0", VA = "0x187614FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x55FCAD0", Offset = "0x55FB6D0", VA = "0x1855FCAD0")]
	public AHHNMHODBOD(NativeBitArray NNIOMOCGEFC, NativeParallelHashMap<FCEEFAMELLC, int> PBGINFCCFKC, NativeParallelHashSet<BFMNJDOGAFP> BCKPHLPEIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x7614DC0", Offset = "0x76139C0", VA = "0x187614DC0")]
	public bool GHOMIMOALBJ(FCEEFAMELLC KFMOBMOKICC, ILLBLIKIMND JENIGBAOHNC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OBCIDGFICJO
{
	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	JCPBLDHJLEF DILIOJHFLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface ABBAFIAPMHL
{
	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IFEBBAMLMMD(OJMCCDFHBJG JKOPHJKJLOL, AIHLGPNPJOE MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IIPDOOIGMOL BHFFOAGAAKF();
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HDODKIPKMGF
{
	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCMGCKEPJCM(World CDEKECFBCAL);

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOGOMNLMFPE(World CDEKECFBCAL);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase OHENPFMDENE(World CDEKECFBCAL);

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MPEMPKFKCGN(World CDEKECFBCAL);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FNCEMCNHOGO(World CDEKECFBCAL);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HDGLGBAHDAB(World CDEKECFBCAL);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OKGECGHDLEB(World CDEKECFBCAL);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> MNJCIOILJOO();
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PPBEEFOFLJP
{
	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJOMOBABPNG(OJMCCDFHBJG KJFLIOABFFB, bool MPDLOLIOGJL);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public readonly struct DOPIIALOCFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly IEnumerable<DMOGAFEBNOC> EIJFKPMEDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly IReadOnlyList<GameObject> ODKHLABAMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly IReadOnlyList<int> FHLAADHNANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly IReadOnlyList<(FCEEFAMELLC, FCEEFAMELLC)> EILNLKFGPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly int MFGLHCLDJND;
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public struct IMDENHPFBAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public InventionIdData HGEMPDBGGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public InventionInstanceIdData KEBCHNMAOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public bool PMGCCGNBPDN;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x7621F50", Offset = "0x7620B50", VA = "0x187621F50")]
	public IMDENHPFBAL(long HGEMPDBGGBJ, Guid KEBCHNMAOCB, bool PMGCCGNBPDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[ServiceLifetime(Lifetime.Application)]
public interface PAEFKDCHKEI
{
	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IADFBMFBFHC MBDCBPDLHIM(LKGOIGMMNHP KIOIJPLHDLK, int KEDMAHIENJM = 0, bool AFACJIEJDDE = false);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MAJAHNBKFPL BMJKKDODDGM(LKGOIGMMNHP KIOIJPLHDLK, OJMCCDFHBJG KOIBCEOILEL, [In] UniformTRS AMGGEODHCDE, OCFNHOBIMFA DALIJOFADKG, [Optional] IMDENHPFBAL AFEHMJHDMKN, bool GFFAOJBJHEL = true, bool LACLOHLBFOK = false, bool AFACJIEJDDE = false);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CJKEHAEHNMM PKAAAPMAABF();

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CJKEHAEHNMM EKFKKGHDNPM(OMGFNECLCEJ MCJEKJAABCE, [In] UniformTRS CJHICJLMHOL);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BGOCAJPABMC(OJMCCDFHBJG GDCOLHBOCJL);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FCFELOPADDE(OJMCCDFHBJG GDCOLHBOCJL, [Out] Exception LIELHOAJGJM);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<FCEEFAMELLC> MFEBFIJGOHG(OJMCCDFHBJG GDCOLHBOCJL, Allocator LNBNGBBFCIG);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<FCEEFAMELLC> ABIMCMEOMCG(OJMCCDFHBJG GDCOLHBOCJL, Allocator LNBNGBBFCIG);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OMGFNECLCEJ CHIJLEMPJEB(OJMCCDFHBJG GDCOLHBOCJL, Allocator LNBNGBBFCIG);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OMGFNECLCEJ AAMMBIKPCDE(OJMCCDFHBJG GDCOLHBOCJL, Allocator LNBNGBBFCIG);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OMGFNECLCEJ PHCMGKCMLLP(OJMCCDFHBJG GDCOLHBOCJL, Allocator LNBNGBBFCIG);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> MFHAKMIKJOK(OJMCCDFHBJG GDCOLHBOCJL, Allocator LNBNGBBFCIG);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PLJIANPHGIL(OJMCCDFHBJG GDCOLHBOCJL);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int KOEEDAGFDKE(OJMCCDFHBJG GDCOLHBOCJL, int EBDKDADIOBA);
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.Application)]
public interface IEIPPIGEBCK
{
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[ServiceLifetime(Lifetime.Application)]
public interface BHJBHCMBGHP
{
	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0xC74980", Offset = "0xC73580", VA = "0x180C74980", Slot = "0")]
	bool BBJMAAOBHIC(object MCKCODFDFLP, HOPAMIAMLDJ BJHNBEPINCI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class LJDPHCOFPAO
{
	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x7623A10", Offset = "0x7622610", VA = "0x187623A10")]
	public static bool BBJMAAOBHIC(this BHJBHCMBGHP KNJAHCCFIOL, object MCKCODFDFLP, [Out] HOPAMIAMLDJ BJHNBEPINCI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public interface HOPAMIAMLDJ
{
	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	INFGBFLBCKM JCIALHFDOME
	{
		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	GEDEGCEHLJI FOCIBNHJEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	bool IIGOPABMBBE
	{
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	bool BLCBKHOOJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0xD96A10", Offset = "0xD95610", VA = "0x180D96A10", Slot = "4")]
	(GEDEGCEHLJI, Dictionary<object, object>) HEFGKBHDLNL()
	{
		return default((GEDEGCEHLJI, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "5")]
	(FCEEFAMELLC, GEDEGCEHLJI) KMCMEPOCEED()
	{
		return default((FCEEFAMELLC, GEDEGCEHLJI));
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "6")]
	OAGNJIFNMLM<(FCEEFAMELLC, GEDEGCEHLJI)> BMDEPHMBIBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "7")]
	OAGNJIFNMLM<ONFOCFJPNHC> PDOLKEAKFNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0xD96A10", Offset = "0xD95610", VA = "0x180D96A10", Slot = "8")]
	(KADFMNJDFHC, byte[]) AJMILBGJFPI()
	{
		return default((KADFMNJDFHC, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0xD96A10", Offset = "0xD95610", VA = "0x180D96A10", Slot = "9")]
	(NNOOGFJCHAK, byte[]) IAGMCIGJDJH()
	{
		return default((NNOOGFJCHAK, byte[]));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public static class KGINMCAJAGM
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x76227B0", Offset = "0x76213B0", VA = "0x1876227B0")]
	public static bool JFBDIJKFCLG(this HOPAMIAMLDJ JNFCOEGPMHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public interface ONFOCFJPNHC : OAGNJIFNMLM<KJOFAPGGGHI>
{
	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	FCEEFAMELLC CAJKBIGFBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[DefaultMember("Item")]
public interface OAGNJIFNMLM<T>
{
	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	T MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	int FMELMONACEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public enum INFGBFLBCKM : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	BulkInstantiate = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	BulkDestroy = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	EACMessage = 3,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	OMSendPacket = 4,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	RR_OutOfBandMessage = 5,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	RR_FastForwardMarker = 6,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	RR_SelfJoinMarker = 7,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	RR_DebugOp = 10,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	RR_CachedEvent = 11,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	RRRoomRequestEvent = 20,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	RRRoomRequestFailedResponseEvent = 21,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	RRBufferedRoomEvent = 22,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	RRClearBufferedRoomEvent = 23,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	RR_CreationOp = 24,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	RR_CreationOpResponse = 25,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	RR_CreationOp_Unchecked = 26,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	RPC = 200,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	SendSerialize = 201,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Instantiation = 202,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	CloseConnection = 203,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Destroy = 204,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	RemoveCachedRPCs = 205,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	SendSerializeReliable = 206,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	DestroyPlayer = 207,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	OwnershipRequest = 209,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	OwnershipTransfer = 210,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	VacantViewIds = 211,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	OwnershipUpdate = 212,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	AuthEvent = 223,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	LobbyStats = 224,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	AppStats = 226,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Match = 227,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	QueueState = 228,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GameListUpdate = 229,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GameList = 230,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	CacheSliceChanged = 250,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	ErrorInfo = 251,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	PropertiesChanged = 253,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Leave = 254,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Join = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public enum KADFMNJDFHC : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	None = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	NetworkTransformInitializationData = 1314146628u,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	RestoreCreationData = 1380140064u,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	OldestCachedPacketId = 1329811529u,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	SnapshotPublished = 1397773634u,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	SnapshotPayload = 1397771332u,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	SnapshotClear = 1129337683u
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public static class MLGAAGOEMGB
{
	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x7625A70", Offset = "0x7624670", VA = "0x187625A70")]
	public static FCEEFAMELLC NJIPJBINHMG(this AFJMLCJKBAK LLDJIJICLJF)
	{
		return default(FCEEFAMELLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x7625AB0", Offset = "0x76246B0", VA = "0x187625AB0")]
	public static FCEEFAMELLC OELJHMNJFAI([In] this AFJMLCJKBAK LLDJIJICLJF)
	{
		return default(FCEEFAMELLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x75A8AD0", Offset = "0x75A76D0", VA = "0x1875A8AD0")]
	public static FCEEFAMELLC OBDHGHCLNDM(this AFJMLCJKBAK LLDJIJICLJF)
	{
		return default(FCEEFAMELLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x75A8AD0", Offset = "0x75A76D0", VA = "0x1875A8AD0")]
	public static ViewId BJMNLGJGCPA(this AFJMLCJKBAK LLDJIJICLJF)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x76255B0", Offset = "0x76241B0", VA = "0x1876255B0")]
	public static FixedString64Bytes DJELBPMJGHG(this BFMNJDOGAFP HGEMPDBGGBJ)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x76257F0", Offset = "0x76243F0", VA = "0x1876257F0")]
	public static FixedString64Bytes FGKDCIHEMJP(this FCEEFAMELLC HGEMPDBGGBJ)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x7625760", Offset = "0x7624360", VA = "0x187625760")]
	public static FixedString32Bytes DJELBPMJGHG(this Entity CANLONBNOKL)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NACKJJHFAAP : DOBJKAJCHGH
{
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public enum MJJBKADKKKI
{
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	End,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DNIGMJDBIPO
{
	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event Action<object> EHLMIFEDNCK;

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "2")]
	void OIOFDOGJBHG(object MCKCODFDFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "3")]
	void HHKADOGMNBF(NNOOGFJCHAK BIKFHOMEEFN, ReadOnlySpan<byte> BFDCDDMLJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "4")]
	void FHGCFPJBAIC(KADFMNJDFHC ADFFEBFOCBD, ReadOnlySpan<byte> BFDCDDMLJOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OHHCFDPODEG
{
	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NNOOGFJCHAK NPFNJLFCFIG(ReadOnlySpan<byte> BFDCDDMLJOF);
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BHKAFKBCAGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEIPBIKJOCA(NNOOGFJCHAK NKANGPLHEGE, ReadOnlySpan<byte> BFDCDDMLJOF);

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DEEIPNMCPNA(ReadOnlySpan<NNOOGFJCHAK> DDEGCCKGOML);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public struct BCALDCGDKAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public NNOOGFJCHAK BIKFHOMEEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public ReadOnlyMemory<byte> BFDCDDMLJOF;
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public struct NNOOGFJCHAK
{
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static NNOOGFJCHAK NBNGOPMMIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public BFMNJDOGAFP CCDANHOALOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public int HHGPOFLGFJN;

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	public static BFMNJDOGAFP OKIBMGADFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x7625DA0", Offset = "0x76249A0", VA = "0x187625DA0")]
		get
		{
			return default(BFMNJDOGAFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x4AE8F10", Offset = "0x4AE7B10", VA = "0x184AE8F10")]
	public NNOOGFJCHAK(BFMNJDOGAFP CCDANHOALOK, int HHGPOFLGFJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x7625D10", Offset = "0x7624910", VA = "0x187625D10")]
	public static bool LBLECGDECIN([In] NNOOGFJCHAK IFMENDFGFGN, [In] NNOOGFJCHAK DPEOCFNLADP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x7625BA0", Offset = "0x76247A0", VA = "0x187625BA0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x7625CB0", Offset = "0x76248B0", VA = "0x187625CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x7625DF0", Offset = "0x76249F0", VA = "0x187625DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x7625B90", Offset = "0x7624790", VA = "0x187625B90")]
	public void EALEPKLOIDH([Out] BFMNJDOGAFP KPGCMDNDABC, [Out] int HHGPOFLGFJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class IGCPFDHMOLP
{
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct DMOGAFEBNOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public Guid IEIMOIIMGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public string IMLADFAALMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public Vector3 FCININPMBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public Quaternion APLHHNGOEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public Vector3 PCNANBOKIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public int FINPCFNNMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public JLHPGPMALFI KNNHCEBFGKJ;

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x761CFC0", Offset = "0x761BBC0", VA = "0x18761CFC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public enum ODCAJHMIBDJ
{
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class LAGDFINHCLF
{
	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x76236E0", Offset = "0x76222E0", VA = "0x1876236E0")]
	public static bool HOBIAMHFLJH(this ODCAJHMIBDJ ADFFEBFOCBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x7623700", Offset = "0x7622300", VA = "0x187623700")]
	public static bool LDOBNLNHNGG(this ODCAJHMIBDJ ADFFEBFOCBD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[Flags]
public enum EENOEMPCPMA
{
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public interface OCFNHOBIMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EECDKGABNNN([In] Guid CGPMLCFDDHA, [Out] Guid DNBDCKCECAB);
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[Flags]
public enum MEFNCELEMPL
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface CJKEHAEHNMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	GFGGBLHLLIA BFJNCMJFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString CJKHCBLJKKA();
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public enum BHDJKEMOIKM
{
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct LLIJJLHPBLI : ISystemStateComponentData, IComponentData, IEquatable<LLIJJLHPBLI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public float3 PFBJDGCBOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public float3 HNKOLPHBDHE;

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x7623AF0", Offset = "0x76226F0", VA = "0x187623AF0", Slot = "4")]
	public bool Equals(LLIJJLHPBLI PELBNOCGOOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DEDFBINFHKH
{
	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICMDPPJKEFE(long OOEDOCIBMMO);

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DPEPMAICHKO(NativeParallelHashSet<long> GGBGIHPDJPO);

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KOAKJIAFGPH(World CDEKECFBCAL, NativeParallelHashMap<Guid, long> BBBJPGEHKDE);

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JDJAIHABPFP(FCEEFAMELLC KFMOBMOKICC);

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AADJCABJLJA(FCEEFAMELLC KFMOBMOKICC, [Out] Guid LPLMDPCGKHK, [Out] long OOEDOCIBMMO);

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JPMGHNGGJJL(FCEEFAMELLC KFMOBMOKICC, Guid LPLMDPCGKHK, long OOEDOCIBMMO);

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MLALPGBABIN(Guid LPLMDPCGKHK);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HDLOLDPPKOF(Guid LPLMDPCGKHK, [Out] int OBCFAIIOHHH, [Out] int KCABODDPDLK);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IPHHHGICBMJ(Guid LPLMDPCGKHK, int OBCFAIIOHHH, int KCABODDPDLK);

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KCEKFKIOPGB(Guid LPLMDPCGKHK);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class DLABOHGMBLK
{
	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public DLABOHGMBLK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
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
