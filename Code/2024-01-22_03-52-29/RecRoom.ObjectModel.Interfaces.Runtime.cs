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
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DefaultMember("Item")]
public struct KAPJLDAAMDP : IReadOnlyList<PIKFEMDGCNE>, IEnumerable<PIKFEMDGCNE>, IEnumerable, IReadOnlyCollection<PIKFEMDGCNE>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct KJMHHBMBGFP : IEnumerator<PIKFEMDGCNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly PHBGNBDDIGC EFNPFLBMIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator JHGKLMJBPBK;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public PIKFEMDGCNE POOCHKNOAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6100D00", Offset = "0x6100100", VA = "0x186100D00", Slot = "4")]
			get
			{
				return default(PIKFEMDGCNE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6100C80", Offset = "0x6100080", VA = "0x186100C80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3BEB6E0", Offset = "0x3BEAAE0", VA = "0x183BEB6E0")]
		public KJMHHBMBGFP(PHBGNBDDIGC EFNPFLBMIPO, NativeArray<LocalId>.Enumerator JHGKLMJBPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6100BC0", Offset = "0x60FFFC0", VA = "0x186100BC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6100C00", Offset = "0x6100000", VA = "0x186100C00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6100C40", Offset = "0x6100040", VA = "0x186100C40", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PHBGNBDDIGC EFNPFLBMIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> ELECKCHAEHL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public PIKFEMDGCNE GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x60FC960", Offset = "0x60FBD60", VA = "0x1860FC960", Slot = "4")]
		get
		{
			return default(PIKFEMDGCNE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x60FC410", Offset = "0x60FB810", VA = "0x1860FC410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int HNIIGMDFKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x78F180", Offset = "0x78E580", VA = "0x18078F180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public PHBGNBDDIGC NFHHBLDGLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int KNKPDIOFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x78F180", Offset = "0x78E580", VA = "0x18078F180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CMNIMAPIALA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60FC4F0", Offset = "0x60FB8F0", VA = "0x1860FC4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> JEJGICLDLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3BE55A0", Offset = "0x3BE49A0", VA = "0x183BE55A0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60FC7B0", Offset = "0x60FBBB0", VA = "0x1860FC7B0")]
	public KAPJLDAAMDP(int BPEPAFIGLCD, PHBGNBDDIGC EFNPFLBMIPO, Allocator FHOLEANHCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3BEB470", Offset = "0x3BEA870", VA = "0x183BEB470")]
	public KAPJLDAAMDP(PHBGNBDDIGC EFNPFLBMIPO, NativeArray<LocalId> ELECKCHAEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60FC840", Offset = "0x60FBC40", VA = "0x1860FC840")]
	internal KAPJLDAAMDP(PHBGNBDDIGC EFNPFLBMIPO, NativeArray<Entity> NNLFMKFJDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60FC710", Offset = "0x60FBB10", VA = "0x1860FC710")]
	public KAPJLDAAMDP(PHBGNBDDIGC EFNPFLBMIPO, int OGHJPGGPGJL, Allocator FHOLEANHCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60FC8B0", Offset = "0x60FBCB0", VA = "0x1860FC8B0")]
	public KAPJLDAAMDP(KAPJLDAAMDP INIMIBNDFCB, Allocator FHOLEANHCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60FC360", Offset = "0x60FB760", VA = "0x1860FC360")]
	public KAPJLDAAMDP EFBMDIDFCOL(Allocator FHOLEANHCPH = Allocator.Temp)
	{
		return default(KAPJLDAAMDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60FC320", Offset = "0x60FB720", VA = "0x1860FC320", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60FC460", Offset = "0x60FB860", VA = "0x1860FC460")]
	public KJMHHBMBGFP FPDPCEFPILF()
	{
		return default(KJMHHBMBGFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x60FC530", Offset = "0x60FB930", VA = "0x1860FC530", Slot = "6")]
	private IEnumerator<PIKFEMDGCNE> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60FC620", Offset = "0x60FBA20", VA = "0x1860FC620", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct GJNJBLLLNKO : IList<PIKFEMDGCNE>, ICollection<PIKFEMDGCNE>, IEnumerable<PIKFEMDGCNE>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct IKABKCHNGPE : IEnumerator<PIKFEMDGCNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly PHBGNBDDIGC EFNPFLBMIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator JHGKLMJBPBK;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public PIKFEMDGCNE POOCHKNOAMB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x60FB100", Offset = "0x60FA500", VA = "0x1860FB100", Slot = "4")]
			get
			{
				return default(PIKFEMDGCNE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x60FB080", Offset = "0x60FA480", VA = "0x1860FB080", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3BEB6E0", Offset = "0x3BEAAE0", VA = "0x183BEB6E0")]
		public IKABKCHNGPE(PHBGNBDDIGC EFNPFLBMIPO, NativeArray<LocalId>.Enumerator JHGKLMJBPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60FAFC0", Offset = "0x60FA3C0", VA = "0x1860FAFC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x60FB000", Offset = "0x60FA400", VA = "0x1860FB000", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x60FB040", Offset = "0x60FA440", VA = "0x1860FB040", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PHBGNBDDIGC EFNPFLBMIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> ELECKCHAEHL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public PIKFEMDGCNE GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60F92F0", Offset = "0x60F86F0", VA = "0x1860F92F0", Slot = "4")]
		get
		{
			return default(PIKFEMDGCNE);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60F9370", Offset = "0x60F8770", VA = "0x1860F9370", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x60F8A70", Offset = "0x60F7E70", VA = "0x1860F8A70", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int KNKPDIOFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x60F8A70", Offset = "0x60F7E70", VA = "0x1860F8A70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool JMFGLNFGMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60F9260", Offset = "0x60F8660", VA = "0x1860F9260")]
	public GJNJBLLLNKO(PHBGNBDDIGC EFNPFLBMIPO, int OGHJPGGPGJL, Allocator FHOLEANHCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60F8DA0", Offset = "0x60F81A0", VA = "0x1860F8DA0")]
	public KAPJLDAAMDP HJFDKEJHKPJ()
	{
		return default(KAPJLDAAMDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60F8AB0", Offset = "0x60F7EB0", VA = "0x1860F8AB0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60F8AF0", Offset = "0x60F7EF0", VA = "0x1860F8AF0", Slot = "13")]
	public bool Contains(PIKFEMDGCNE JCBFPBHHLOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60F8B80", Offset = "0x60F7F80", VA = "0x1860F8B80", Slot = "14")]
	public void CopyTo(PIKFEMDGCNE[] CBCBEPHCJOP, int LNMJODKMHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60F89F0", Offset = "0x60F7DF0", VA = "0x1860F89F0", Slot = "11")]
	public void Add(PIKFEMDGCNE JCBFPBHHLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60F8EB0", Offset = "0x60F82B0", VA = "0x1860F8EB0", Slot = "7")]
	public void Insert(int FGBBDGJMFEH, PIKFEMDGCNE JCBFPBHHLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60F8FB0", Offset = "0x60F83B0", VA = "0x1860F8FB0", Slot = "15")]
	public bool Remove(PIKFEMDGCNE JCBFPBHHLOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60F8E20", Offset = "0x60F8220", VA = "0x1860F8E20", Slot = "6")]
	public int IndexOf(PIKFEMDGCNE JCBFPBHHLOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60F8F60", Offset = "0x60F8360", VA = "0x1860F8F60", Slot = "8")]
	public void RemoveAt(int FGBBDGJMFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60F8CD0", Offset = "0x60F80D0", VA = "0x1860F8CD0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60F8D10", Offset = "0x60F8110", VA = "0x1860F8D10")]
	public IKABKCHNGPE FPDPCEFPILF()
	{
		return default(IKABKCHNGPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60F9080", Offset = "0x60F8480", VA = "0x1860F9080", Slot = "16")]
	private IEnumerator<PIKFEMDGCNE> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60F9170", Offset = "0x60F8570", VA = "0x1860F9170", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EIINKJOJCJG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int JAEFNPHKOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> MNIABCLEDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PIKFEMDGCNE EIAINKJMNND(PIKFEMDGCNE ELECKCHAEHL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HAKMEMJNOEB : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface DEOCOMLDHOI : DNCFIHADBDG, BKLHCNIBAOL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool NABJPIJAAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NPNCALEHDCA PFBJNMLGGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MHHAOHABAJK CCOLBCGLJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NDJMIMDENEP HCOJGCBNHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	JCNOCIFAINA ELFLLOIBHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	INCPAOGFKKN DODJHGDBEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface BKLHCNIBAOL
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool BJKMFDFMJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface LEPMKPJPKJD
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBPAHHHOMOK(bool PAHKKNONPEO);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface JCNOCIFAINA
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool OAKEGEDOFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GFDFPEEPPCP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICNJOPFLIBL(bool MKECFCAPOLO);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JNIDCKOMEHN(ByteString PKBBOCAODJK);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DLBFDCKJNJM();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PEMAJNONMPF();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OIDPMJLLHPG();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface NDJMIMDENEP
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	NLGOFGOGHKI PFBJNMLGGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	MHHAOHABAJK CCOLBCGLJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	JAGKOLPEDFD FNFBPGOMGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	DEOCOMLDHOI GMAMDCBJPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	PHBGNBDDIGC NFHHBLDGLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	ONIKLEKCMGJ JOHGFLKEABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	OHIKFHHALBD NIGJOFLMBFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	OFPOBFBNBAM GEAJGOCKOKP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	GHNNAKLKJGM JKHOAEEOJED
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	KDEKDBHJJHD CAJNPBIGIGO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MJOMPALBFPJ LEEFBLJGEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	DJEOHCJHENI PDDMBMCIAEG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	BHJNCMEMGNN CLLCDKHFKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	DDNLKIONPAJ KDHJNPHIFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	BJOHEPPOIKB LNGJABJJEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	BHBILEMBLKP IDKGPGKEPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	FBPJCGBEEPB ACBAJHPGKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	KGBGGKOMJHD FCGHHHHCKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	IBANJFNBHAL KEMEOEMHEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	KLBJJLJMPOB PDONJOLMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	HDDDNNNEGOF JFIFBOAIKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	CPFJBIGGFPP GALLEOMDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(DCKHLBADKPK))]
public readonly struct PIKFEMDGCNE : IComparable<PIKFEMDGCNE>, IEquatable<PIKFEMDGCNE>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly PIKFEMDGCNE INDMNNFEIGN;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int FDFHOLCIFMB = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int MMJCNJIBEHG = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int PFNPNPPEICA = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int KADAFGHPKMG = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId NLDMFIFGFAP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public PHBGNBDDIGC NFHHBLDGLGM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x60F5670", Offset = "0x60F4A70", VA = "0x1860F5670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public DEOCOMLDHOI GMAMDCBJPHK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6104C40", Offset = "0x6104040", VA = "0x186104C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public LocalId NBPHDMOGLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6104C00", Offset = "0x6104000", VA = "0x186104C00")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	internal INCPAOGFKKN DODJHGDBEMH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6104CA0", Offset = "0x61040A0", VA = "0x186104CA0")]
		get
		{
			return default(INCPAOGFKKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool ANCJEEDCBON
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6104CB0", Offset = "0x61040B0", VA = "0x186104CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool DOHOMNFDBLG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6104A20", Offset = "0x6103E20", VA = "0x186104A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool MFLPGIPCJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x61049D0", Offset = "0x6103DD0", VA = "0x1861049D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6104F40", Offset = "0x6104340", VA = "0x186104F40")]
	public PIKFEMDGCNE(PHBGNBDDIGC ELGFJPMPCJE, LocalId NLDMFIFGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
	public CJDMOFLNOBE DIOKHFJPOCC()
	{
		return default(CJDMOFLNOBE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6104D90", Offset = "0x6104190", VA = "0x186104D90")]
	public static LocalId OOICJOKLJBF(PIKFEMDGCNE KMAPHNALNNH)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6104DD0", Offset = "0x61041D0", VA = "0x186104DD0")]
	public static Entity OOICJOKLJBF(PIKFEMDGCNE KMAPHNALNNH)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x61047D0", Offset = "0x6103BD0", VA = "0x1861047D0")]
	public static bool AODPLFIFGHC(PIKFEMDGCNE OJBODDLNJNK, PIKFEMDGCNE BLEBDLHLENH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x60F5E60", Offset = "0x60F5260", VA = "0x1860F5E60")]
	public static bool OFGNAAAHKLD(PIKFEMDGCNE OJBODDLNJNK, PIKFEMDGCNE BLEBDLHLENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6104E10", Offset = "0x6104210", VA = "0x186104E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6104A70", Offset = "0x6103E70", VA = "0x186104A70", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x61048F0", Offset = "0x6103CF0", VA = "0x1861048F0", Slot = "4")]
	public int CompareTo(PIKFEMDGCNE JLCJEDAFKJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "5")]
	public bool Equals(PIKFEMDGCNE JLCJEDAFKJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class APIOCPDAMII
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x60F44F0", Offset = "0x60F38F0", VA = "0x1860F44F0")]
	public static KDLKNOEDFHK DNBCCCECHDG(this PIKFEMDGCNE DFFBALIDCLL)
	{
		return default(KDLKNOEDFHK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x60F45E0", Offset = "0x60F39E0", VA = "0x1860F45E0")]
	public static CJDMOFLNOBE PDPDBFJKGLF(this PIKFEMDGCNE DFFBALIDCLL, [Optional] object KNOHBODGPLL)
	{
		return default(CJDMOFLNOBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2C67FD0", Offset = "0x2C673D0", VA = "0x182C67FD0")]
	public static T OECDDLOHDEB<T>(this PIKFEMDGCNE DFFBALIDCLL) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal sealed class DCKHLBADKPK
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct INCPAOGFKKN : IEquatable<INCPAOGFKKN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte AEBAPBHOHLJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] DEEBIKGCDFA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static PHBGNBDDIGC IDHCCLNFEDN;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static DEOCOMLDHOI GAHGCGHIHDB;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static PHBGNBDDIGC[] IAIHPOGMJKP;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static DEOCOMLDHOI[] FJEEOOHCLGN;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> GOCDDOKFCID;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DEOCOMLDHOI GMAMDCBJPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x60FB330", Offset = "0x60FA730", VA = "0x1860FB330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public PHBGNBDDIGC JPKDKHLOGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x60FB410", Offset = "0x60FA810", VA = "0x1860FB410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x60FC050", Offset = "0x60FB450", VA = "0x1860FC050")]
	static INCPAOGFKKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xC213A0", Offset = "0xC207A0", VA = "0x180C213A0")]
	internal INCPAOGFKKN(byte PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5349F60", Offset = "0x5349360", VA = "0x185349F60", Slot = "4")]
	public bool Equals(INCPAOGFKKN JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x60FB210", Offset = "0x60FA610", VA = "0x1860FB210", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1A363D0", Offset = "0x1A357D0", VA = "0x181A363D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x60FBF90", Offset = "0x60FB390", VA = "0x1860FBF90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x60FBC10", Offset = "0x60FB010", VA = "0x1860FBC10")]
	private static PHBGNBDDIGC NHADFNKBFHB(byte AEBAPBHOHLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x60FB150", Offset = "0x60FA550", VA = "0x1860FB150")]
	private static DEOCOMLDHOI AFIPCCIEIPD(byte AEBAPBHOHLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60FB4F0", Offset = "0x60FA8F0", VA = "0x1860FB4F0")]
	private static object JHLOENJFCGA(byte AEBAPBHOHLJ, object[] HHMCIHBKJAP, object MINBGACMFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x60FB200", Offset = "0x60FA600", VA = "0x1860FB200")]
	private static int EMMBDHJKCGF(byte AEBAPBHOHLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x60FBC00", Offset = "0x60FB000", VA = "0x1860FBC00")]
	private static int NAJBEKECBEB(byte AEBAPBHOHLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x60FB2B0", Offset = "0x60FA6B0", VA = "0x1860FB2B0")]
	private static (int, int) FOLGMPHADLE(byte AEBAPBHOHLJ)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x60FBF80", Offset = "0x60FB380", VA = "0x1860FBF80")]
	private static byte PFDCEMKFKPJ(int IEOKPDEFBIP, int FGBBDGJMFEH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x60FBCC0", Offset = "0x60FB0C0", VA = "0x1860FBCC0")]
	internal static INCPAOGFKKN OAIKDCNGOPG(DEOCOMLDHOI KLGLEPCGFNI, PHBGNBDDIGC JIOFFNNAKPP)
	{
		return default(INCPAOGFKKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60FB9F0", Offset = "0x60FADF0", VA = "0x1860FB9F0")]
	internal static void LJBJCLEGBND(INCPAOGFKKN AEBAPBHOHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x60FB660", Offset = "0x60FAA60", VA = "0x1860FB660")]
	private static void KPFOJKPBCOE(int BPEPAFIGLCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface CIMIAMPFBFF
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KLBLNABKBID();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PAAKDIJGHLO(bool FDFMBHCGMPE);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MILCNDEKIOF(GameObject IFGJJHCIEPA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface KJIECNJGCGA
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	Guid PGJMOKPMNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DPCNFPNJNFM(Guid IOGJMIAAODP, Guid KOMJDLDEFJE);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task GMCAIPBOIPL(PIKFEMDGCNE LJDBGJFHBEC);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LIBBLPHOFHN(PIKFEMDGCNE KDABCDIIADN, PIKFEMDGCNE AOGBEAODJPP, [Out] Vector3 MFMADJENJBL, [Out] Quaternion LMGFHFMPEAE);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HNALDIFKHCL(OBBFKOJHAPI NILBLHIHOJM, Vector3 MFMADJENJBL, Quaternion LMGFHFMPEAE);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BFHIMEFKIBA(PIKFEMDGCNE CBEBOEFIBIP, [Out] Vector3 MFIPMGNAGAB, [Out] Quaternion JMJLPNJENBL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface LGEAOBCPNBD
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DACOKKNPFME(KAPJLDAAMDP ELECKCHAEHL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface MHHAOHABAJK
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CIMIAMPFBFF PKHHCKGIMHI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	AGGHEKJCJLK BCDEPBKMEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	JOOAPNPEHCE IHHDPFAGNIE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	KHCACGLEOEM PMKFNNNOMMO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	GABDEJPBOGE NJMMDAOBLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	EHDOGFPFPLL OHDEJIJCFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	ELEBOKOELCM ABJLGEAENEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	EGBJFDBEEGP LLAENKNDNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface LEDMMNHHOID
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHGMDPOFGNE(Action EEEBGEOHFMI, bool BOAKFECNJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DCFNICDNDMJ(string ADLKEGECLOG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface AGGHEKJCJLK
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string JOAMLGOCCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] AJOPIPOHPAN(IEnumerable<MLCNMHOEFKC> KIOFBMLNCEC);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EFFFCFPEANE(GameObject IFGJJHCIEPA, [Out] KDLKNOEDFHK[] FHIOGCFCAIG);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DEPDBEFHJAA(GameObject IFGJJHCIEPA, [Out] int OHEPDDBIDEJ, [Out] GEIFGNPODDN LDBFOCMCGPO);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DBMHPHOGJOG DMJJMJKMLMA(MLCNMHOEFKC MGFKAMLOFJH);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DBMHPHOGJOG DMJJMJKMLMA(string JOJBJEEFDFC, KDLKNOEDFHK[] LMDNMFFNHAP, Vector3 BCGGHPIMKDA, Quaternion GIJALKLADPN, Vector3 GLDPLANNJMB);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject EGPFLFIICEN(string JOJBJEEFDFC);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PFDLEJOFBGO(GameObject BNPOODEFDLG, bool FGKEMBDNNLD);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OOJIFHFIELH(GameObject IFGJJHCIEPA, bool DHIABMCCCBL, bool JCEFKKAECPP);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class ACKJNKHPIDC
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x60F4310", Offset = "0x60F3710", VA = "0x1860F4310")]
	public static DBMHPHOGJOG DMJJMJKMLMA(this AGGHEKJCJLK HLPGFGOCKFB, Vector3 BCGGHPIMKDA, Quaternion GIJALKLADPN, Vector3 GLDPLANNJMB, params KDLKNOEDFHK[] FHIOGCFCAIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface JOOAPNPEHCE
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJPIGNMBACD(bool MKECFCAPOLO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface KHCACGLEOEM
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	bool MICJAOLPJMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool AECOKGLFCMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool LNBCNLIMDLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	int DMGMMIMALIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool LINFNGCAJHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KMCBLPKGLPP(object JFKHFDHADBL);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KCMDILFALBE(object JFKHFDHADBL);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FHONBPEDMEJ(object GOOANMNBGEP);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KBJOHPABLBK(object GOOANMNBGEP);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int OINKPOKBDOA(GameObject HDHABPIEJIF);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ONNEIAECFKP(NativeArray<int> CEFHMNAOPIG);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LFINDJOLLCM(NativeArray<int> HPCFIIGAIEO);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LILILNBAPJG();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AAHKBBHEPEE(uint AAEPHJHJCKN, ReadOnlySpan<byte> GCDGEBMFOJE, bool FBNOJIFJHPB = false);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AAHKBBHEPEE(uint AAEPHJHJCKN, ReadOnlySpan<byte> GCDGEBMFOJE, ReadOnlySpan<byte> BIFPMENFLJJ, bool FBNOJIFJHPB = false);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface GABDEJPBOGE
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPIAGFLNKFJ(GameObject IFGJJHCIEPA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface DDHGKNHEFMG
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHCFMMLKPIF(string AGOKDCAFCLN);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface CCCEIDFPAHM
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LEGPBBNEOOA(GameObject IFGJJHCIEPA);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ONNFMLGOHCN(GameObject IFGJJHCIEPA);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object NMAFPFDELDE(PIKFEMDGCNE NLDMFIFGFAP, GameObject IFGJJHCIEPA, Action<PIKFEMDGCNE, int> COPFOFGFOAL);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OPBBFMAHKMC(GameObject IFGJJHCIEPA, object INEAMEJNEOB);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface EHDOGFPFPLL
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	int ELKIFLMKFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int ELCNGIJBFHG(GameObject IFGJJHCIEPA);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FJENDNJHKPD([Out] Vector3 BCGGHPIMKDA);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AODOMKAKKBC();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface ELEBOKOELCM
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool OAKEGEDOFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool IIDEAOMHELA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface FAKHPFNOBCH
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	HKOEOHONHMB FJMDNIDGOCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	EJJKAFCJMFA ABDEKNOEIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IPIGLHHABCI(Transform FIFLCPFGAIF);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DBGJAMPPGLO(Transform FIFLCPFGAIF, HAIOPLIDGDM BNKAGDHPJEH);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPNLFGHIEAA(Transform FIFLCPFGAIF, JABODDDNBPD LENMFDEEMDE);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface EGBJFDBEEGP
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDEGJDPEOIA();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface OFJAONFIAIE
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NACOHMKAHHO();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface BJNGCLPBAHB
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GEIFGNPODDN FBJKPPKMAFH(GameObject HDHABPIEJIF);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGCCBOOMPFF(GameObject IFGJJHCIEPA, OMFPHENPPEJ MJKJLMFABAB, HHMMEMDOIJK NKEGMIAPKLJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string ALNIEDLGEKP(int NONJEEALACK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DGEOMDPBAHE(string GJDNBMNMHIJ);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BJGNBINLKOC(PIKFEMDGCNE NLDMFIFGFAP, int[] AMNFAGJAFEP);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JFFGKGFJHHM(GameObject ICFKMDOGHDJ, GameObject LPPNKBFHPMB, int CFIHNMNHMPH);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct GECCCABMANA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly GPFLFPPCEME ANFKDBDICOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly GPFLFPPCEME JICHEHMFLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint POMADCANPJF;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x60F8700", Offset = "0x60F7B00", VA = "0x1860F8700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct IDHJHIMHLME
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly KBKFCGENGMC ADLBEINOKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly GECCCABMANA EEEBGEOHFMI;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x60F54B0", Offset = "0x60F48B0", VA = "0x1860F54B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct CHOGBNKDEIE
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly KBKFCGENGMC ADLBEINOKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly GECCCABMANA EEEBGEOHFMI;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x60F54B0", Offset = "0x60F48B0", VA = "0x1860F54B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct LCJJOBEIGLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint POMADCANPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool OOANLDMHHPJ;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6101500", Offset = "0x6100900", VA = "0x186101500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct GPFLFPPCEME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int EIJFICIEABK;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x60F9580", Offset = "0x60F8980", VA = "0x1860F9580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface BOGFINDGFND
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	CHHPMBHGDLL BIPJNOLLEBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum GBJJJNNJJML
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
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface DBMHPHOGJOG : CFEIKGMCGIJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	GBJJJNNJJML JAKILFAENMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool GBEDBFIPBJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	GameObject IFGJJHCIEPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<DBMHPHOGJOG> MFNOCDAKNPP;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(JAGKOLPEDFD KCEHNBBOIGD, PIKFEMDGCNE OJEIOLMLEAL);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool BHPFHHKEHIF);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class JHLPOMOIGBG
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x60FC1A0", Offset = "0x60FB5A0", VA = "0x1860FC1A0")]
	public static bool JMEPPGPBLEL(this DBMHPHOGJOG BMHOFCNAKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x60FC100", Offset = "0x60FB500", VA = "0x1860FC100")]
	public static bool GHGMGMNKCOK(this DBMHPHOGJOG BMHOFCNAKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x60FC150", Offset = "0x60FB550", VA = "0x1860FC150")]
	public static bool IBMCLCNPOBH(this DBMHPHOGJOG BMHOFCNAKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x60FC1F0", Offset = "0x60FB5F0", VA = "0x1860FC1F0")]
	public static bool NABJPIJAAIJ(this DBMHPHOGJOG BMHOFCNAKIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface CFEIKGMCGIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool KJBEDCLLEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	PIKFEMDGCNE JLNBODNOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
internal interface OEGIKFEHBBI
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<KGPGOHGPLBM> EFPAIKFAPPD;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface MHPOOCEFGCE : IHNEHGIEGAJ<KDLKNOEDFHK>, BINABPNOFFN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface CBOKNPDDDHE<T> : EOHNBKAPMBD<KDLKNOEDFHK, T>, IHNEHGIEGAJ<KDLKNOEDFHK>, BINABPNOFFN, IDisposable, MHPOOCEFGCE where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FDDLIEEBGEE
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x25D84C0", Offset = "0x25D78C0", VA = "0x1825D84C0")]
	public static bool KBIKFGCAMJG<T>(this IHNEHGIEGAJ<KDLKNOEDFHK> JAOOJJKNLDO, KDLKNOEDFHK LMDNMFFNHAP, [Out] T PAHKKNONPEO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x25D8090", Offset = "0x25D7490", VA = "0x1825D8090")]
	public static bool NIEAIDPCAEB<T>(this IHNEHGIEGAJ<KDLKNOEDFHK> JAOOJJKNLDO, KDLKNOEDFHK LMDNMFFNHAP, [In] T NKJNNAKEBHP) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface PDNLOOAKMDB : IHNEHGIEGAJ<PIKFEMDGCNE>, BINABPNOFFN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface CDGNCMIHCDN<T> : EOHNBKAPMBD<PIKFEMDGCNE, T>, IHNEHGIEGAJ<PIKFEMDGCNE>, BINABPNOFFN, IDisposable, PDNLOOAKMDB where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OPLELILOBAO
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x24B3F00", Offset = "0x24B3300", VA = "0x1824B3F00")]
	public static T LBFOALNGCEO<T>(this IHNEHGIEGAJ<PIKFEMDGCNE> JAOOJJKNLDO, PIKFEMDGCNE NLDMFIFGFAP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x25D8050", Offset = "0x25D7450", VA = "0x1825D8050")]
	public static bool NIEAIDPCAEB<T>(this IHNEHGIEGAJ<PIKFEMDGCNE> JAOOJJKNLDO, PIKFEMDGCNE NLDMFIFGFAP, [In] T NKJNNAKEBHP) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct LFNJFOCLDOK : IComparable<LFNJFOCLDOK>, IEquatable<LFNJFOCLDOK>
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly LFNJFOCLDOK INDMNNFEIGN;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly LFNJFOCLDOK IMIAOADOOGM;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly LFNJFOCLDOK CIIAKADLBPK;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly LFNJFOCLDOK MGAHJFBMIGM;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly LFNJFOCLDOK KOHJLKMHJNN;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly LFNJFOCLDOK CGKDFGOLAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int GOBEDCIKOGJ;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool FOGKPCNDNCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6101E30", Offset = "0x6101230", VA = "0x186101E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int JBOCADNLJOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6101E40", Offset = "0x6101240", VA = "0x186101E40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x890600", Offset = "0x88FA00", VA = "0x180890600")]
	public LFNJFOCLDOK(int FGBBDGJMFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6101ED0", Offset = "0x61012D0", VA = "0x186101ED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6101E50", Offset = "0x6101250", VA = "0x186101E50", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x818E50", Offset = "0x818250", VA = "0x180818E50", Slot = "5")]
	public bool Equals(LFNJFOCLDOK JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x176B410", Offset = "0x176A810", VA = "0x18176B410", Slot = "4")]
	public int CompareTo(LFNJFOCLDOK JLCJEDAFKJL)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0xD85170", Offset = "0xD84570", VA = "0x180D85170")]
	public static LFNJFOCLDOK OOICJOKLJBF(int FGBBDGJMFEH)
	{
		return default(LFNJFOCLDOK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0xD85170", Offset = "0xD84570", VA = "0x180D85170")]
	public static int OOICJOKLJBF(LFNJFOCLDOK OBPHOMEOEEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6101F30", Offset = "0x6101330", VA = "0x186101F30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct CJDMOFLNOBE : IEquatable<CJDMOFLNOBE>, CFEIKGMCGIJ
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly CJDMOFLNOBE MJPOKAINLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public PIKFEMDGCNE JLNBODNOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360", Slot = "6")]
		get
		{
			return default(PIKFEMDGCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public KGKCEBDLBBG KKHBKNPBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(KGKCEBDLBBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public HKGKPIIKOKI JOHGFLKEABF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(HKGKPIIKOKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private PHBGNBDDIGC NFHHBLDGLGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x60F5670", Offset = "0x60F4A70", VA = "0x1860F5670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public GameObject IFGJJHCIEPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x60F5C10", Offset = "0x60F5010", VA = "0x1860F5C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public KDLKNOEDFHK NBCCMDJOJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x60F5DA0", Offset = "0x60F51A0", VA = "0x1860F5DA0")]
		get
		{
			return default(KDLKNOEDFHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public OEEGCNHLDOI APACKPIHJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x60F5F90", Offset = "0x60F5390", VA = "0x1860F5F90")]
		get
		{
			return default(OEEGCNHLDOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GEIFGNPODDN MJIOKLAAGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x60F58F0", Offset = "0x60F4CF0", VA = "0x1860F58F0")]
		get
		{
			return default(GEIFGNPODDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool CBOANKDMLOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x60F5990", Offset = "0x60F4D90", VA = "0x1860F5990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool PIMLBGNILID
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x60F5650", Offset = "0x60F4A50", VA = "0x1860F5650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool EMFDDJLNPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x60F59B0", Offset = "0x60F4DB0", VA = "0x1860F59B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool NFCIIGIHCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x60F5EA0", Offset = "0x60F52A0", VA = "0x1860F5EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool OHGKLLMGKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x60F5800", Offset = "0x60F4C00", VA = "0x1860F5800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool JKGLICOAMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x60F56D0", Offset = "0x60F4AD0", VA = "0x1860F56D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool BOBFMOHCPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x60F5B00", Offset = "0x60F4F00", VA = "0x1860F5B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool BFLJBENCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x60F5E40", Offset = "0x60F5240", VA = "0x1860F5E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public BDKLLNLGCLF MECNJBLCBEC
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(BDKLLNLGCLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public FEHBKOIMHLI LEJLLNGDDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(FEHBKOIMHLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public PMOLKNGIOEN CLLCDKHFKOK
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(PMOLKNGIOEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public KHGJJMOKNNC NOCEPPIHINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(KHGJJMOKNNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public OKPDPAFKDCO PDDMBMCIAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(OKPDPAFKDCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public HOOJGKKOCPL OFOGNIDHOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(HOOJGKKOCPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public OBBFKOJHAPI HLLNHFCJFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(OBBFKOJHAPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public GOLOGGPEFMM FKPLHNPMOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(GOLOGGPEFMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool JMEPPGPBLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x60F59D0", Offset = "0x60F4DD0", VA = "0x1860F59D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool JPJJHBBGOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x60F5AC0", Offset = "0x60F4EC0", VA = "0x1860F5AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool GKPGEIOPBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x60F58B0", Offset = "0x60F4CB0", VA = "0x1860F58B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private bool PMBMHAPJCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public CJDMOFLNOBE(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x60F5E80", Offset = "0x60F5280", VA = "0x1860F5E80")]
	public static bool OOICJOKLJBF(CJDMOFLNOBE PAHKKNONPEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
	public static PIKFEMDGCNE OOICJOKLJBF(CJDMOFLNOBE PAHKKNONPEO)
	{
		return default(PIKFEMDGCNE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x60F5550", Offset = "0x60F4950", VA = "0x1860F5550")]
	public static bool AODPLFIFGHC(CJDMOFLNOBE OJBODDLNJNK, CJDMOFLNOBE BLEBDLHLENH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x60F5E60", Offset = "0x60F5260", VA = "0x1860F5E60")]
	public static bool OFGNAAAHKLD(CJDMOFLNOBE OJBODDLNJNK, CJDMOFLNOBE BLEBDLHLENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x60F5820", Offset = "0x60F4C20", VA = "0x1860F5820", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(CJDMOFLNOBE JLCJEDAFKJL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
	public static CJDMOFLNOBE OOICJOKLJBF(PIKFEMDGCNE HICOIGNOKIJ)
	{
		return default(CJDMOFLNOBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x60F5B40", Offset = "0x60F4F40", VA = "0x1860F5B40")]
	public FHJCPCJGOOH JHKDMLHMPAD()
	{
		return default(FHJCPCJGOOH);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x60F5EC0", Offset = "0x60F52C0", VA = "0x1860F5EC0")]
	public HJJMLIHKKKP PAPMIGAGBIF()
	{
		return default(HJJMLIHKKKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x60F5BC0", Offset = "0x60F4FC0", VA = "0x1860F5BC0")]
	public MOMKGJNOBKK JMCNJGBKPBB()
	{
		return default(MOMKGJNOBKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x60F5EF0", Offset = "0x60F52F0", VA = "0x1860F5EF0")]
	public void PDPDBFJKGLF([Optional] object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x60F5560", Offset = "0x60F4960", VA = "0x1860F5560")]
	public bool BBHOMHDNJAO(object KNOHBODGPLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x60F5710", Offset = "0x60F4B10", VA = "0x1860F5710")]
	public bool EHKOFKAJAHP(object KNOHBODGPLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x60F6030", Offset = "0x60F5430", VA = "0x1860F6030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct OBBFKOJHAPI : IEquatable<OBBFKOJHAPI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public PIKFEMDGCNE JLNBODNOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(PIKFEMDGCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private PHBGNBDDIGC NFHHBLDGLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x60F5670", Offset = "0x60F4A70", VA = "0x1860F5670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private NDJMIMDENEP HCOJGCBNHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6102A80", Offset = "0x6101E80", VA = "0x186102A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private BHBILEMBLKP CLKHAIIBACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6102BA0", Offset = "0x6101FA0", VA = "0x186102BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool OFAIOPAHOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6103000", Offset = "0x6102400", VA = "0x186103000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Guid FJJPDNKJMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6102DC0", Offset = "0x61021C0", VA = "0x186102DC0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public bool HEPIPMICCOF
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6102B10", Offset = "0x6101F10", VA = "0x186102B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Guid HHEMLCFLGJE
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6103090", Offset = "0x6102490", VA = "0x186103090")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public OBBFKOJHAPI(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x60F5E80", Offset = "0x60F5280", VA = "0x1860F5E80")]
	public static bool OOICJOKLJBF(OBBFKOJHAPI PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6102CA0", Offset = "0x61020A0", VA = "0x186102CA0", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(OBBFKOJHAPI JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x61031B0", Offset = "0x61025B0", VA = "0x1861031B0")]
	public bool KFKBJHBJCIN([Out] Guid GILNCNDAFEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6103250", Offset = "0x6102650", VA = "0x186103250")]
	public void PHHNGKCEMGI(Guid OFNBMJMBJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6102C00", Offset = "0x6102000", VA = "0x186102C00")]
	public bool DPDFJJCOPLD([Out] Guid CEPBGHOOFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6102EE0", Offset = "0x61022E0", VA = "0x186102EE0")]
	public void HLDBLMNJGDG(Guid OFNBMJMBJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6102D30", Offset = "0x6102130", VA = "0x186102D30")]
	public void FJLDFLLFPEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct MOMKGJNOBKK : IEquatable<MOMKGJNOBKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public PIKFEMDGCNE JLNBODNOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(PIKFEMDGCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private PHBGNBDDIGC NFHHBLDGLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x60F5670", Offset = "0x60F4A70", VA = "0x1860F5670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private NDJMIMDENEP HCOJGCBNHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6102620", Offset = "0x6101A20", VA = "0x186102620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private FBPJCGBEEPB PDFHNFCKLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6102870", Offset = "0x6101C70", VA = "0x186102870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float3 OIGHIIDALMM
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x61026B0", Offset = "0x6101AB0", VA = "0x1861026B0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public quaternion MFBPALLGNHP
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x61028D0", Offset = "0x6101CD0", VA = "0x1861028D0")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public CJDMOFLNOBE ENEDDBOBEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x61029F0", Offset = "0x6101DF0", VA = "0x1861029F0")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public MOMKGJNOBKK(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
	public static PIKFEMDGCNE OOICJOKLJBF(MOMKGJNOBKK PAHKKNONPEO)
	{
		return default(PIKFEMDGCNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x61027E0", Offset = "0x6101BE0", VA = "0x1861027E0", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(MOMKGJNOBKK JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct FHJCPCJGOOH : IEquatable<FHJCPCJGOOH>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class KCJLKCONOGL : IEnumerable<CJDMOFLNOBE>, IEnumerable, IEnumerator<CJDMOFLNOBE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private CJDMOFLNOBE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public FHJCPCJGOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public FHJCPCJGOOH <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IEnumerator<CJDMOFLNOBE> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IEnumerator<PIKFEMDGCNE> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		private CJDMOFLNOBE System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.RRObject>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x334B6C0", Offset = "0x334AAC0", VA = "0x18334B6C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(CJDMOFLNOBE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x60FD0A0", Offset = "0x60FC4A0", VA = "0x1860FD0A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x34B71B0", Offset = "0x34B65B0", VA = "0x1834B71B0")]
		[DebuggerHidden]
		public KCJLKCONOGL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x60FD0F0", Offset = "0x60FC4F0", VA = "0x1860FD0F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x60FC9F0", Offset = "0x60FBDF0", VA = "0x1860FC9F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x60FCF60", Offset = "0x60FC360", VA = "0x1860FCF60")]
		private void OPFNICOLGEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x60FC9A0", Offset = "0x60FBDA0", VA = "0x1860FC9A0")]
		private void JJCMEKBDGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x60FCF10", Offset = "0x60FC310", VA = "0x1860FCF10")]
		private void NKDJBDEJMIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x60FD050", Offset = "0x60FC450", VA = "0x1860FD050", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x60FCFB0", Offset = "0x60FC3B0", VA = "0x1860FCFB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CJDMOFLNOBE> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.RRObject>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x60FCFB0", Offset = "0x60FC3B0", VA = "0x1860FCFB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly FHJCPCJGOOH MJPOKAINLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public PIKFEMDGCNE JLNBODNOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(PIKFEMDGCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public KGKCEBDLBBG KKHBKNPBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(KGKCEBDLBBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public HKGKPIIKOKI JOHGFLKEABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(HKGKPIIKOKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private PHBGNBDDIGC NFHHBLDGLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x60F5670", Offset = "0x60F4A70", VA = "0x1860F5670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private NDJMIMDENEP HCOJGCBNHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x60F6660", Offset = "0x60F5A60", VA = "0x1860F6660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private ONIKLEKCMGJ AKFAKGENHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x60F66F0", Offset = "0x60F5AF0", VA = "0x1860F66F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public KAPJLDAAMDP KGOGPKCOIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x60F7330", Offset = "0x60F6730", VA = "0x1860F7330")]
		get
		{
			return default(KAPJLDAAMDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public IEnumerable<CJDMOFLNOBE> PAEHHBBCFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x60F78A0", Offset = "0x60F6CA0", VA = "0x1860F78A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public IEnumerable<CJDMOFLNOBE> ONPENMKJPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x60F6B80", Offset = "0x60F5F80", VA = "0x1860F6B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int MELNNGOBLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x60F6D20", Offset = "0x60F6120", VA = "0x1860F6D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int IGPMPKNDCCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x60F7740", Offset = "0x60F6B40", VA = "0x1860F7740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public string DACJMNMHBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x60F7690", Offset = "0x60F6A90", VA = "0x1860F7690")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x60F75E0", Offset = "0x60F69E0", VA = "0x1860F75E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public MFHODNHFMAH EGDILENFLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x60F73F0", Offset = "0x60F67F0", VA = "0x1860F73F0")]
		get
		{
			return default(MFHODNHFMAH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x60F6A40", Offset = "0x60F5E40", VA = "0x1860F6A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public JPOBBOPPCMD AKHOKCOLEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x60F74B0", Offset = "0x60F68B0", VA = "0x1860F74B0")]
		get
		{
			return default(JPOBBOPPCMD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x60F71D0", Offset = "0x60F65D0", VA = "0x1860F71D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public HGBAIHOMHBA JMKBJPLFFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x60F7450", Offset = "0x60F6850", VA = "0x1860F7450")]
		get
		{
			return default(HGBAIHOMHBA);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x60F7570", Offset = "0x60F6970", VA = "0x1860F7570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public float MGMMLGJMDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x60F6750", Offset = "0x60F5B50", VA = "0x1860F6750")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x60F6AB0", Offset = "0x60F5EB0", VA = "0x1860F6AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool ELECPJNEBIO
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x60F7160", Offset = "0x60F6560", VA = "0x1860F7160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool EJGFBGDNOOK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x60F67B0", Offset = "0x60F5BB0", VA = "0x1860F67B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool ALJKIIBHJDG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x60F6820", Offset = "0x60F5C20", VA = "0x1860F6820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool AMKFEOMHHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x60F7790", Offset = "0x60F6B90", VA = "0x1860F7790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool LHNDBFOAFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x60F6B20", Offset = "0x60F5F20", VA = "0x1860F6B20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x60F70F0", Offset = "0x60F64F0", VA = "0x1860F70F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool KIBAIFGMEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x60F7510", Offset = "0x60F6910", VA = "0x1860F7510")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x60F72C0", Offset = "0x60F66C0", VA = "0x1860F72C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public FHJCPCJGOOH(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x60F5E80", Offset = "0x60F5280", VA = "0x1860F5E80")]
	public static bool OOICJOKLJBF(FHJCPCJGOOH PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x60F7060", Offset = "0x60F6460", VA = "0x1860F7060", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(FHJCPCJGOOH JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
	public static CJDMOFLNOBE OOICJOKLJBF(FHJCPCJGOOH MKEGOGNADMP)
	{
		return default(CJDMOFLNOBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x60F7880", Offset = "0x60F6C80", VA = "0x1860F7880")]
	public bool PJJFJBIPFFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x60F6CB0", Offset = "0x60F60B0", VA = "0x1860F6CB0")]
	public bool DLJHOPBNKJO(KNNICLABCMC EEEKFDACBJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x60F7800", Offset = "0x60F6C00", VA = "0x1860F7800")]
	public void OMDPCAGDCAA(KNNICLABCMC EEEKFDACBJK, bool PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x60F6890", Offset = "0x60F5C90", VA = "0x1860F6890")]
	public KAPJLDAAMDP BLLMMHBIHJD(Allocator FHOLEANHCPH)
	{
		return default(KAPJLDAAMDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x60F6DB0", Offset = "0x60F61B0", VA = "0x1860F6DB0")]
	public void EPGFDDLPOIM(FHJCPCJGOOH JLCJEDAFKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x60F7240", Offset = "0x60F6640", VA = "0x1860F7240")]
	[IteratorStateMachine(typeof(KCJLKCONOGL))]
	public IEnumerable<CJDMOFLNOBE> IJIHPENJLEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct DBGCHGJDDKF : IEquatable<DBGCHGJDDKF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x60F6110", Offset = "0x60F5510", VA = "0x1860F6110", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(DBGCHGJDDKF JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct FEHBKOIMHLI : IEquatable<FEHBKOIMHLI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private PHBGNBDDIGC NFHHBLDGLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x60F5670", Offset = "0x60F4A70", VA = "0x1860F5670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public FEHBKOIMHLI(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x60F6490", Offset = "0x60F5890", VA = "0x1860F6490", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(FEHBKOIMHLI JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x60F65C0", Offset = "0x60F59C0", VA = "0x1860F65C0")]
	public void GOHOEIHDKHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x60F6520", Offset = "0x60F5920", VA = "0x1860F6520")]
	public void GOBDIDNMEKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct IIOEDOFNJIJ : IEquatable<IIOEDOFNJIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x60FAF30", Offset = "0x60FA330", VA = "0x1860FAF30", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(IIOEDOFNJIJ JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct MOLGIBEKKJO : IEquatable<MOLGIBEKKJO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6102590", Offset = "0x6101990", VA = "0x186102590", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(MOLGIBEKKJO JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct LPPNLMIAHCG : IEquatable<LPPNLMIAHCG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6102080", Offset = "0x6101480", VA = "0x186102080", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(LPPNLMIAHCG JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct DHKDEEIPLFH : IEquatable<DHKDEEIPLFH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x60F62F0", Offset = "0x60F56F0", VA = "0x1860F62F0", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(DHKDEEIPLFH JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct HKGKPIIKOKI : IEquatable<HKGKPIIKOKI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public PIKFEMDGCNE JLNBODNOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(PIKFEMDGCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private PHBGNBDDIGC NFHHBLDGLGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x60F5670", Offset = "0x60F4A70", VA = "0x1860F5670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private NDJMIMDENEP HCOJGCBNHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x60FA020", Offset = "0x60F9420", VA = "0x1860FA020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private ONIKLEKCMGJ AKFAKGENHHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x60FA0B0", Offset = "0x60F94B0", VA = "0x1860FA0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public PIKFEMDGCNE LJANLPDMLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x60FA170", Offset = "0x60F9570", VA = "0x1860FA170")]
		get
		{
			return default(PIKFEMDGCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public CJDMOFLNOBE PDLABICHIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x60FA6E0", Offset = "0x60F9AE0", VA = "0x1860FA6E0")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public CJDMOFLNOBE KCJODJNNHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x60FA3C0", Offset = "0x60F97C0", VA = "0x1860FA3C0")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public HKGKPIIKOKI(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x60FA330", Offset = "0x60F9730", VA = "0x1860FA330", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(HKGKPIIKOKI JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x60FA200", Offset = "0x60F9600", VA = "0x1860FA200")]
	public bool DFODMMMMNPP(CJDMOFLNOBE AOGBEAODJPP, bool LEKOMNGDBPN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x60FA770", Offset = "0x60F9B70", VA = "0x1860FA770")]
	public bool PIALJHGPMDG(CJDMOFLNOBE JCCGNJNAHGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x60FA450", Offset = "0x60F9850", VA = "0x1860FA450")]
	private void LMDFCEIJMFE(CJDMOFLNOBE PCPNDADGGDA, List<CJDMOFLNOBE> EDCEFKDNNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x60FA110", Offset = "0x60F9510", VA = "0x1860FA110")]
	public void BKMLBOPNHBP(List<CJDMOFLNOBE> FJMINBEFACC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct BDKLLNLGCLF : IEquatable<BDKLLNLGCLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public string HMHLPEAAEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x60F5060", Offset = "0x60F4460", VA = "0x1860F5060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public string DAMKKGPLKJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x60F5250", Offset = "0x60F4650", VA = "0x1860F5250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private bool OEGMOJKCAIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x60F5110", Offset = "0x60F4510", VA = "0x1860F5110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string BCMCOPKNOPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x60F5320", Offset = "0x60F4720", VA = "0x1860F5320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public string IGFJMELNIJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x60F4D70", Offset = "0x60F4170", VA = "0x1860F4D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public string DLJAHBHBIJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x60F4CC0", Offset = "0x60F40C0", VA = "0x1860F4CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public BDKLLNLGCLF(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FD0", Offset = "0x60F43D0", VA = "0x1860F4FD0", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(BDKLLNLGCLF JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x60F46F0", Offset = "0x60F3AF0", VA = "0x1860F46F0")]
	private static string CKDLDAOPPBA(GEIFGNPODDN BHIEBIFNDMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct GHOFMCJDBMO : IEquatable<GHOFMCJDBMO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x60F8960", Offset = "0x60F7D60", VA = "0x1860F8960", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(GHOFMCJDBMO JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct PMOLKNGIOEN : IEquatable<PMOLKNGIOEN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public PMOLKNGIOEN(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6105080", Offset = "0x6104480", VA = "0x186105080", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(PMOLKNGIOEN JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6105110", Offset = "0x6104510", VA = "0x186105110")]
	public bool MOOEJDAFBPI([Out] Collider OHBBEBBKENI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct KHGJJMOKNNC : IEquatable<KHGJJMOKNNC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public PIKFEMDGCNE JLNBODNOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(PIKFEMDGCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private PHBGNBDDIGC NFHHBLDGLGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x60F5670", Offset = "0x60F4A70", VA = "0x1860F5670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private NDJMIMDENEP HCOJGCBNHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x60FFBD0", Offset = "0x60FEFD0", VA = "0x1860FFBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private FEMLGBNNBCF LOOLOLNBNLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x61009B0", Offset = "0x60FFDB0", VA = "0x1861009B0")]
		get
		{
			return default(FEMLGBNNBCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private MAHIMHEIKHO GAIACHJIOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x61003E0", Offset = "0x60FF7E0", VA = "0x1861003E0")]
		get
		{
			return default(MAHIMHEIKHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool OBFBGCGDAFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6100900", Offset = "0x60FFD00", VA = "0x186100900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool CMLMNKCPIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x60FFE10", Offset = "0x60FF210", VA = "0x1860FFE10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool BDGGGEIBJPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x61001B0", Offset = "0x60FF5B0", VA = "0x1861001B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool IIPPPDCKKDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x60FFEF0", Offset = "0x60FF2F0", VA = "0x1860FFEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool HPHKEIMKKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6100A10", Offset = "0x60FFE10", VA = "0x186100A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool BDJGMPFEHHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x60FFF60", Offset = "0x60FF360", VA = "0x1860FFF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool IPBLLKLAHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6100790", Offset = "0x60FFB90", VA = "0x186100790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool MEDABAEHDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6100AF0", Offset = "0x60FFEF0", VA = "0x186100AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool BMJFGDMAFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6100A80", Offset = "0x60FFE80", VA = "0x186100A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool LKEKEKEMCCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6100940", Offset = "0x60FFD40", VA = "0x186100940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool BECEJKOMBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x60FFCD0", Offset = "0x60FF0D0", VA = "0x1860FFCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool LBMPGHJHCBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6100370", Offset = "0x60FF770", VA = "0x186100370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool EKIAPAMMDOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6100040", Offset = "0x60FF440", VA = "0x186100040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool MKCHKCEKGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x61004A0", Offset = "0x60FF8A0", VA = "0x1861004A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool GCCOLJBBIII
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x60FFFD0", Offset = "0x60FF3D0", VA = "0x1860FFFD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x60FFC60", Offset = "0x60FF060", VA = "0x1860FFC60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public HOPFAKKCKLB IEAIBFHMKLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x60FFDB0", Offset = "0x60FF1B0", VA = "0x1860FFDB0")]
		get
		{
			return default(HOPFAKKCKLB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x60FFD40", Offset = "0x60FF140", VA = "0x1860FFD40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool JMJPOIACJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6100510", Offset = "0x60FF910", VA = "0x186100510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public HHMMEMDOIJK LNEMFJEJMJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6100440", Offset = "0x60FF840", VA = "0x186100440")]
		get
		{
			return default(HHMMEMDOIJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool MKBFOIELHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6100B60", Offset = "0x60FFF60", VA = "0x186100B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 CBPLJFNHEMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6100220", Offset = "0x60FF620", VA = "0x186100220")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public Vector3 DBBGDNPBFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x61006E0", Offset = "0x60FFAE0", VA = "0x1861006E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool DEONIBFECGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6100800", Offset = "0x60FFC00", VA = "0x186100800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public KHGJJMOKNNC(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x61000B0", Offset = "0x60FF4B0", VA = "0x1861000B0", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(KHGJJMOKNNC JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6100140", Offset = "0x60FF540", VA = "0x186100140")]
	public bool FJOLBPEACAN(OKJDBOEONLF EEEKFDACBJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x60FFE80", Offset = "0x60FF280", VA = "0x1860FFE80")]
	public bool CJAKDFNFALP(OMFPHENPPEJ EEEKFDACBJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x61002F0", Offset = "0x60FF6F0", VA = "0x1861002F0")]
	public void GOEACMECADH(OMFPHENPPEJ EEEKFDACBJK, bool PLPLMBNMHHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct HOOJGKKOCPL : IEquatable<HOOJGKKOCPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public PIKFEMDGCNE JLNBODNOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(PIKFEMDGCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private PHBGNBDDIGC NFHHBLDGLGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x60F5670", Offset = "0x60F4A70", VA = "0x1860F5670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private NDJMIMDENEP HCOJGCBNHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x60FA810", Offset = "0x60F9C10", VA = "0x1860FA810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public HOOJGKKOCPL(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x60FA8A0", Offset = "0x60F9CA0", VA = "0x1860FA8A0", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(HOOJGKKOCPL JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x60FA9C0", Offset = "0x60F9DC0", VA = "0x1860FA9C0")]
	public void MFONNNKPCCH(bool PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x60FA930", Offset = "0x60F9D30", VA = "0x1860FA930")]
	public void KNLHDEACOOG(bool PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x261CDC0", Offset = "0x261C1C0", VA = "0x18261CDC0")]
	public T GNFHOCJAIOE<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct OKPDPAFKDCO : IEquatable<OKPDPAFKDCO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public PIKFEMDGCNE JLNBODNOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(PIKFEMDGCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private PHBGNBDDIGC NFHHBLDGLGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x60F5670", Offset = "0x60F4A70", VA = "0x1860F5670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private NDJMIMDENEP HCOJGCBNHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6103720", Offset = "0x6102B20", VA = "0x186103720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private DJEOHCJHENI BDEOBLBCNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6103A00", Offset = "0x6102E00", VA = "0x186103A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private HDDDNNNEGOF JFIFBOAIKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6104020", Offset = "0x6103420", VA = "0x186104020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool OOKDCMFNFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6103A60", Offset = "0x6102E60", VA = "0x186103A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool HAGDFCILEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6103960", Offset = "0x6102D60", VA = "0x186103960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool HANFODCICGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6104080", Offset = "0x6103480", VA = "0x186104080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool LDGPPEIDHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6104140", Offset = "0x6103540", VA = "0x186104140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool LHJOOCKGCOL
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6104340", Offset = "0x6103740", VA = "0x186104340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public bool PEMKBMPFCKE
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x61040B0", Offset = "0x61034B0", VA = "0x1861040B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool MJDKDHIEMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6103D00", Offset = "0x6103100", VA = "0x186103D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool GAAEHBCPAOI
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6103B90", Offset = "0x6102F90", VA = "0x186103B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public OKPDPAFKDCO(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x60F5E80", Offset = "0x60F5280", VA = "0x1860F5E80")]
	public static bool OOICJOKLJBF(OKPDPAFKDCO PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x61038D0", Offset = "0x6102CD0", VA = "0x1861038D0", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(OKPDPAFKDCO JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x61037B0", Offset = "0x6102BB0", VA = "0x1861037B0")]
	public bool CADEFFODCML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6103AF0", Offset = "0x6102EF0", VA = "0x186103AF0")]
	public CJDMOFLNOBE HOLOFJLDEJJ(CJDMOFLNOBE GOOANMNBGEP)
	{
		return default(CJDMOFLNOBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6103F10", Offset = "0x6103310", VA = "0x186103F10")]
	public PIKFEMDGCNE JANGJKEIAPB()
	{
		return default(PIKFEMDGCNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6104210", Offset = "0x6103610", VA = "0x186104210")]
	public void OHMDBFNNKDC(PIKFEMDGCNE GOOANMNBGEP, PIKFEMDGCNE EDGMIFENGFK, PIKFEMDGCNE GOBFMAHOBKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct HJJMLIHKKKP : IEquatable<HJJMLIHKKKP>
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly HJJMLIHKKKP MJPOKAINLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public PIKFEMDGCNE JLNBODNOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(PIKFEMDGCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public KGKCEBDLBBG KKHBKNPBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(KGKCEBDLBBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private AKEKEIBFIDB PIAOCKBOACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x60F9FC0", Offset = "0x60F93C0", VA = "0x1860F9FC0")]
		get
		{
			return default(AKEKEIBFIDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public HODEMJLOJFC DJEOLJBDDFL
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x60F9940", Offset = "0x60F8D40", VA = "0x1860F9940")]
		get
		{
			return default(HODEMJLOJFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public HNFHFDANFHN BPDPPGGIJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x60F9D30", Offset = "0x60F9130", VA = "0x1860F9D30")]
		get
		{
			return default(HNFHFDANFHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public POAJPIMABBH EIHOKFIFGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x60F97F0", Offset = "0x60F8BF0", VA = "0x1860F97F0")]
		get
		{
			return default(POAJPIMABBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public BFLKFOAJFNF AIGEHFAFDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x60F9C60", Offset = "0x60F9060", VA = "0x1860F9C60")]
		get
		{
			return default(BFLKFOAJFNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public CDPNNMCPMDK JPJAEGPCJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x60F9C00", Offset = "0x60F9000", VA = "0x1860F9C00")]
		get
		{
			return default(CDPNNMCPMDK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x60F9DF0", Offset = "0x60F91F0", VA = "0x1860F9DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public GECCKCHIAEK AEACPPPKIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x60F9A90", Offset = "0x60F8E90", VA = "0x1860F9A90")]
		get
		{
			return default(GECCKCHIAEK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x60F9850", Offset = "0x60F8C50", VA = "0x1860F9850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public float PCCHJFFAENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x60F9D90", Offset = "0x60F9190", VA = "0x1860F9D90")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x60F9EE0", Offset = "0x60F92E0", VA = "0x1860F9EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 BEADICJNEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x60F9AF0", Offset = "0x60F8EF0", VA = "0x1860F9AF0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x60F9A10", Offset = "0x60F8E10", VA = "0x1860F9A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public float LKPPENLGDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x60F9F50", Offset = "0x60F9350", VA = "0x1860F9F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public IOIDOAIABDM.FPPJHIKPGPD JODDIGEJHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x60F9CD0", Offset = "0x60F90D0", VA = "0x1860F9CD0")]
		get
		{
			return default(IOIDOAIABDM.FPPJHIKPGPD);
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x60F99A0", Offset = "0x60F8DA0", VA = "0x1860F99A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public HJJMLIHKKKP(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x60F5E80", Offset = "0x60F5280", VA = "0x1860F5E80")]
	public static bool OOICJOKLJBF(HJJMLIHKKKP PAHKKNONPEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x60F5E60", Offset = "0x60F5260", VA = "0x1860F5E60")]
	public static bool OFGNAAAHKLD(HJJMLIHKKKP OJBODDLNJNK, HJJMLIHKKKP BLEBDLHLENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x60F9B70", Offset = "0x60F8F70", VA = "0x1860F9B70", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(HJJMLIHKKKP JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x60F98C0", Offset = "0x60F8CC0", VA = "0x1860F98C0")]
	public DEDFHDHFNNL CACGKAFPDGD()
	{
		return default(DEDFHDHFNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x60F9E60", Offset = "0x60F9260", VA = "0x1860F9E60")]
	public FJEOEANDMAA NGAMKNEOCNC()
	{
		return default(FJEOEANDMAA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct DEDFHDHFNNL : IEquatable<DEDFHDHFNNL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public PIKFEMDGCNE JLNBODNOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(PIKFEMDGCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public HJJMLIHKKKP KKPBLKAPLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(HJJMLIHKKKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private KPNMNIOPKCP APFHFABJCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x60F6200", Offset = "0x60F5600", VA = "0x1860F6200")]
		get
		{
			return default(KPNMNIOPKCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public IBKDJMDJCHE MPHBICABPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x60F61A0", Offset = "0x60F55A0", VA = "0x1860F61A0")]
		get
		{
			return default(IBKDJMDJCHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public DEDFHDHFNNL(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x60F5E80", Offset = "0x60F5280", VA = "0x1860F5E80")]
	public static bool OOICJOKLJBF(DEDFHDHFNNL PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x60F6260", Offset = "0x60F5660", VA = "0x1860F6260", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(DEDFHDHFNNL JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public readonly struct FJEOEANDMAA : IEquatable<FJEOEANDMAA>
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly FJEOEANDMAA MJPOKAINLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public PIKFEMDGCNE JLNBODNOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(PIKFEMDGCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public KGKCEBDLBBG KKHBKNPBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(KGKCEBDLBBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private PHBGNBDDIGC NFHHBLDGLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x60F5670", Offset = "0x60F4A70", VA = "0x1860F5670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private NDJMIMDENEP HCOJGCBNHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x60F7A10", Offset = "0x60F6E10", VA = "0x1860F7A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private KDEKDBHJJHD CAJNPBIGIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x60F81C0", Offset = "0x60F75C0", VA = "0x1860F81C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public HJJMLIHKKKP KKPBLKAPLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(HJJMLIHKKKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public MKCNMENAIME PACNIPJNOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x60F7AA0", Offset = "0x60F6EA0", VA = "0x1860F7AA0")]
		get
		{
			return default(MKCNMENAIME);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x60F7F10", Offset = "0x60F7310", VA = "0x1860F7F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public IEnumerable<KNHHOIGNKIN> OHBPGDBHJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x60F8030", Offset = "0x60F7430", VA = "0x1860F8030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public KNHHOIGNKIN GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x60F7BD0", Offset = "0x60F6FD0", VA = "0x1860F7BD0")]
		get
		{
			return default(KNHHOIGNKIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x60F8220", Offset = "0x60F7620", VA = "0x1860F8220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public FJEOEANDMAA(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x60F5E80", Offset = "0x60F5280", VA = "0x1860F5E80")]
	public static bool OOICJOKLJBF(FJEOEANDMAA PAHKKNONPEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x60F5550", Offset = "0x60F4950", VA = "0x1860F5550")]
	public static bool AODPLFIFGHC(FJEOEANDMAA OJBODDLNJNK, FJEOEANDMAA BLEBDLHLENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x60F7E80", Offset = "0x60F7280", VA = "0x1860F7E80", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(FJEOEANDMAA JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x60F84E0", Offset = "0x60F78E0", VA = "0x1860F84E0")]
	public KNHHOIGNKIN NKJIKCGDGFK(float3? BCGGHPIMKDA, [Optional] quaternion? GIJALKLADPN, [Optional] Vector3? GLDPLANNJMB)
	{
		return default(KNHHOIGNKIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x60F82B0", Offset = "0x60F76B0", VA = "0x1860F82B0")]
	public KNHHOIGNKIN NGBBCEMFLAB(int FGBBDGJMFEH, float3? BCGGHPIMKDA, [Optional] quaternion? GIJALKLADPN, [Optional] Vector3? GLDPLANNJMB)
	{
		return default(KNHHOIGNKIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x60F7CE0", Offset = "0x60F70E0", VA = "0x1860F7CE0")]
	public void DOAIIEDHOAA(int FGBBDGJMFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x60F7DF0", Offset = "0x60F71F0", VA = "0x1860F7DF0")]
	public void EKABOMHIFDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct KNHHOIGNKIN : IEquatable<KNHHOIGNKIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public PIKFEMDGCNE JLNBODNOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(PIKFEMDGCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public FJEOEANDMAA NHDNIPBCGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x6101160", Offset = "0x6100560", VA = "0x186101160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public float3 IIMAAFEMNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x6100F90", Offset = "0x6100390", VA = "0x186100F90")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x61013C0", Offset = "0x61007C0", VA = "0x1861013C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public quaternion NEELOJMOJMH
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6101250", Offset = "0x6100650", VA = "0x186101250")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6101090", Offset = "0x6100490", VA = "0x186101090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float3 GEAPALPPBOG
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6101340", Offset = "0x6100740", VA = "0x186101340")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6101010", Offset = "0x6100410", VA = "0x186101010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public APIHIBIIMFN LLGHNKGNBEH
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x61012D0", Offset = "0x61006D0", VA = "0x1861012D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private GJOAGJLMNEG ILDKEFJODBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6100F30", Offset = "0x6100330", VA = "0x186100F30")]
		get
		{
			return default(GJOAGJLMNEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private PINJCAHNJNI JADCMNPABAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6100DE0", Offset = "0x61001E0", VA = "0x186100DE0")]
		get
		{
			return default(PINJCAHNJNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	private MBIONMAAKNF HOMPLPMBKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6100E40", Offset = "0x6100240", VA = "0x186100E40")]
		get
		{
			return default(MBIONMAAKNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	private PGBOJALHONP AFFDOJFKFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6101100", Offset = "0x6100500", VA = "0x186101100")]
		get
		{
			return default(PGBOJALHONP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	private DJDFLBCMLGG GMIBMPKPBNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x61011F0", Offset = "0x61005F0", VA = "0x1861011F0")]
		get
		{
			return default(DJDFLBCMLGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public KNHHOIGNKIN(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6100EA0", Offset = "0x61002A0", VA = "0x186100EA0", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(KNHHOIGNKIN JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6101160", Offset = "0x6100560", VA = "0x186101160")]
	public void NOPAHEEIDFO(FJEOEANDMAA PAHKKNONPEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct KGKCEBDLBBG : IEquatable<KGKCEBDLBBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public HKGKPIIKOKI JOHGFLKEABF
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(HKGKPIIKOKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private PHBGNBDDIGC NFHHBLDGLGM
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x60F5670", Offset = "0x60F4A70", VA = "0x1860F5670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private OHIKFHHALBD LDHBMNPEIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x60FE6B0", Offset = "0x60FDAB0", VA = "0x1860FE6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool OHBCGGGJPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x60FE010", Offset = "0x60FD410", VA = "0x1860FE010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 IIMAAFEMNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x60FE420", Offset = "0x60FD820", VA = "0x1860FE420")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x60FF700", Offset = "0x60FEB00", VA = "0x1860FF700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Quaternion NEELOJMOJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x60FEE30", Offset = "0x60FE230", VA = "0x1860FEE30")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x60FE9E0", Offset = "0x60FDDE0", VA = "0x1860FE9E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 LMCJEHOICMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x60FF610", Offset = "0x60FEA10", VA = "0x1860FF610")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x60FF7D0", Offset = "0x60FEBD0", VA = "0x1860FF7D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion OENBJJAECOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x60FF320", Offset = "0x60FE720", VA = "0x1860FF320")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x60FDAB0", Offset = "0x60FCEB0", VA = "0x1860FDAB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float ILNIKCAKDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x60FE380", Offset = "0x60FD780", VA = "0x1860FE380")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x60FD910", Offset = "0x60FCD10", VA = "0x1860FD910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float LHMKDCAJKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x60FF0C0", Offset = "0x60FE4C0", VA = "0x1860FF0C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 GEAPALPPBOG
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x60FF230", Offset = "0x60FE630", VA = "0x1860FF230")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x60FE840", Offset = "0x60FDC40", VA = "0x1860FE840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 BBBPELJDMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x60FE290", Offset = "0x60FD690", VA = "0x1860FE290")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Matrix4x4 INKBPLNKNED
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x60FF8A0", Offset = "0x60FECA0", VA = "0x1860FF8A0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public KGKCEBDLBBG(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x60FDE30", Offset = "0x60FD230", VA = "0x1860FDE30", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(KGKCEBDLBBG JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x60FEBA0", Offset = "0x60FDFA0", VA = "0x1860FEBA0")]
	public LOMPFHDKEFP JFDNKEDGGAG()
	{
		return default(LOMPFHDKEFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x60FD6A0", Offset = "0x60FCAA0", VA = "0x1860FD6A0")]
	public void BJNBPICGBCF([Out] Matrix4x4 JKLNLJAJGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x60FEF80", Offset = "0x60FE380", VA = "0x1860FEF80")]
	public void MPMAHCIKHCB([Out] Vector3 MJKJFPCHIOO, [Out] Quaternion OLPEJOBGMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x60FD7C0", Offset = "0x60FCBC0", VA = "0x1860FD7C0")]
	public void BLLAJDHKICA([Out] RigidTransform KNICEENFLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x60FE510", Offset = "0x60FD910", VA = "0x1860FE510")]
	public JCNCEDDNMOO GCBBMCKPJCH()
	{
		return default(JCNCEDDNMOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x60FE540", Offset = "0x60FD940", VA = "0x1860FE540")]
	public void GCBBMCKPJCH([Out] JCNCEDDNMOO GCOJJOLKENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x60FD5C0", Offset = "0x60FC9C0", VA = "0x1860FD5C0")]
	public JCNCEDDNMOO AKGKNHJAKLN()
	{
		return default(JCNCEDDNMOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x60FD500", Offset = "0x60FC900", VA = "0x1860FD500")]
	public void AKGKNHJAKLN([Out] JCNCEDDNMOO KNICEENFLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x60FEAB0", Offset = "0x60FDEB0", VA = "0x1860FEAB0")]
	public Vector3 JDECPGLGMHJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x60FEBF0", Offset = "0x60FDFF0", VA = "0x1860FEBF0")]
	public void JHACPGGNEGO([In] Vector3 PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x60FDB80", Offset = "0x60FCF80", VA = "0x1860FDB80")]
	public Vector3 EGDCAMOFNOH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x60FDD60", Offset = "0x60FD160", VA = "0x1860FDD60")]
	public void EJGLFENOLCM([In] Vector3 PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x60FE050", Offset = "0x60FD450", VA = "0x1860FE050")]
	public Quaternion FHCECDBHOBN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x60FF470", Offset = "0x60FE870", VA = "0x1860FF470")]
	public void NPHKJKJIOCG([In] Quaternion PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x60FDEC0", Offset = "0x60FD2C0", VA = "0x1860FDEC0")]
	public Quaternion FDDOMECOAOK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x60FECC0", Offset = "0x60FE0C0", VA = "0x1860FECC0")]
	public void KPABJNKBDNB([In] Quaternion PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x60FED90", Offset = "0x60FE190", VA = "0x1860FED90")]
	public float LHKELEPHFPD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x60FD5F0", Offset = "0x60FC9F0", VA = "0x1860FD5F0")]
	public void ANFFPDBCKNP(float PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x60FD870", Offset = "0x60FCC70", VA = "0x1860FD870")]
	public float BNODKPNDJJN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x60FE600", Offset = "0x60FDA00", VA = "0x1860FE600")]
	public void HECCHMNJDDO(float PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x60FE910", Offset = "0x60FDD10", VA = "0x1860FE910")]
	public void INJAEFPMBFD([In] Vector3 PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x60FD9C0", Offset = "0x60FCDC0", VA = "0x1860FD9C0")]
	public Vector3 DIECMNHEOGC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x60FF160", Offset = "0x60FE560", VA = "0x1860FF160")]
	public void NMMOGEAJOMP([In] Vector3 PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x60FDC70", Offset = "0x60FD070", VA = "0x1860FDC70")]
	public Vector3 EIEAFJBECHL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x60FE770", Offset = "0x60FDB70", VA = "0x1860FE770")]
	public void IFDGABJCKFB([In] Vector3 PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x60FE1A0", Offset = "0x60FD5A0", VA = "0x1860FE1A0")]
	public Vector3 FIPLHNEDAKN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x60FF540", Offset = "0x60FE940", VA = "0x1860FF540")]
	public void NPMDOJPCJDP([In] Vector3 PAHKKNONPEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct GOLOGGPEFMM : IEquatable<GOLOGGPEFMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public PIKFEMDGCNE JLNBODNOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(PIKFEMDGCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public CJDMOFLNOBE PEGLAKOCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		get
		{
			return default(CJDMOFLNOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public int[] JKMKBPGLAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x60F9490", Offset = "0x60F8890", VA = "0x1860F9490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
	public GOLOGGPEFMM(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x60F50E0", Offset = "0x60F44E0", VA = "0x1860F50E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x60F9400", Offset = "0x60F8800", VA = "0x1860F9400", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x60F4FC0", Offset = "0x60F43C0", VA = "0x1860F4FC0", Slot = "4")]
	public bool Equals(GOLOGGPEFMM JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x60F5410", Offset = "0x60F4810", VA = "0x1860F5410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HEEKMHJJOFL
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct KBNPELIHNOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Guid EFNPBHMDENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public IPJALHPIACI JOLNEHIBKIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct IPJALHPIACI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int PAHKKNONPEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int ELAIIOGFPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int AAEPHJHJCKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int PLDDEMPDCBM;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x60FC060", Offset = "0x60FB460", VA = "0x1860FC060")]
		public bool HHFHBDPEJOC([Out] KDLKNOEDFHK LMDNMFFNHAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x60FC0E0", Offset = "0x60FB4E0", VA = "0x1860FC0E0")]
		public IPJALHPIACI(KDLKNOEDFHK LMDNMFFNHAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x60F9600", Offset = "0x60F8A00", VA = "0x1860F9600")]
	public static Guid HDDLCGOJGEE(this KDLKNOEDFHK LMDNMFFNHAP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x60F95E0", Offset = "0x60F89E0", VA = "0x1860F95E0")]
	public static bool BMHGKFFBIKD(this Guid EFNPBHMDENF, [Out] KDLKNOEDFHK LMDNMFFNHAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class OGGAOIOKHJF
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6103590", Offset = "0x6102990", VA = "0x186103590")]
	public static NDJMIMDENEP HCOJGCBNHFK(this PIKFEMDGCNE NONJEEALACK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x61034C0", Offset = "0x61028C0", VA = "0x1861034C0")]
	public static JAGKOLPEDFD FNFBPGOMGKG(this PIKFEMDGCNE NONJEEALACK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6103620", Offset = "0x6102A20", VA = "0x186103620")]
	public static EntityManager MFEBCDLDBJP(this PIKFEMDGCNE NONJEEALACK)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2787D00", Offset = "0x2787100", VA = "0x182787D00")]
	public static T CAJOCDDBEHJ<T>(this PIKFEMDGCNE NONJEEALACK) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x2788C70", Offset = "0x2788070", VA = "0x182788C70")]
	public static bool EMIPBJEFNFB<T>(this PIKFEMDGCNE NONJEEALACK) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2788F30", Offset = "0x2788330", VA = "0x182788F30")]
	public static bool GMAMNBHKFIM<T>(this PIKFEMDGCNE NONJEEALACK) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface BHBILEMBLKP
{
	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEPIPMICCOF(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OFAIOPAHOPM(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KFKBJHBJCIN(PIKFEMDGCNE NLDMFIFGFAP, [Out] Guid GILNCNDAFEF);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid LFCAMPCMMHM(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PHHNGKCEMGI(PIKFEMDGCNE NLDMFIFGFAP, Guid GILNCNDAFEF);

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DPDFJJCOPLD(PIKFEMDGCNE NLDMFIFGFAP, [Out] Guid CEPBGHOOFFL);

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid AMLNGKNDAPM(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HLDBLMNJGDG(PIKFEMDGCNE NLDMFIFGFAP, Guid CEPBGHOOFFL);

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FJLDFLLFPEI(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NGODOLDIAFB(PIKFEMDGCNE KDABCDIIADN, PIKFEMDGCNE AOGBEAODJPP);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface IHADCHJBFNF
{
	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	Guid PGJMOKPMNMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKLLDNIPBIC(NativeList<Guid> GANDBFLOKFE, NativeList<Guid> MEHONFMPEGJ, NativeList<FixedString64Bytes> CCOCMIIDGIN);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface CPFJBIGGFPP
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPOLHMJAEOK(List<PIKFEMDGCNE> OMOFINJPJEO);

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AOGHPPIMNIE(PIKFEMDGCNE OJEIOLMLEAL);

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EEFJLLCGPHB(PIKFEMDGCNE OJEIOLMLEAL);

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PIKFEMDGCNE JOACJJHKIAJ(PIKFEMDGCNE EONGDOJBMPN);

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHJGOFJICMB(PIKFEMDGCNE EONGDOJBMPN, PIKFEMDGCNE AMINMLGNPBM);

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MHNBMILFILB(PIKFEMDGCNE EONGDOJBMPN);

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LNNMPBLDJMI(PIKFEMDGCNE HICOIGNOKIJ);

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LPEBLLJIKJG(PIKFEMDGCNE OJEIOLMLEAL);

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BHAKNOGOKPH(PIKFEMDGCNE NLDMFIFGFAP, bool HLOFHEOLCOI);

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EBDEEBFINLA(PIKFEMDGCNE[] ELECKCHAEHL, bool HLOFHEOLCOI);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface KLBJJLJMPOB
{
	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	IReadOnlyCollection<EKIILBDMHIE> NACNNKBJPLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GJAOICJFBIA(int JDDFBAGKFLF, [Out] EKIILBDMHIE PGAFLLFBLMM);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EKIILBDMHIE EOFLAKPOOAE(Type KHENBEDBKDI);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class LOFBIGKFOBB
{
	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x26C4890", Offset = "0x26C3C90", VA = "0x1826C4890")]
	public static T MAFNLOEGPIP<T>(this KLBJJLJMPOB LLKLKENMMFB, Entity HJECHGCECJI) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x26C3CC0", Offset = "0x26C30C0", VA = "0x1826C3CC0")]
	public static EKIILBDMHIE EOFLAKPOOAE<T>(this KLBJJLJMPOB LLKLKENMMFB) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface KHKMMDFDCNC
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KDLKNOEDFHK[] KHHBJONJMCA(string ADLKEGECLOG, CJDMOFLNOBE CGPOOAIDKLC, bool DPHIOMIAHHI = false);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEBKGNCFJCD(string JOJBJEEFDFC, KDLKNOEDFHK[] FHIOGCFCAIG);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface FBPJCGBEEPB
{
	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<PIKFEMDGCNE, PIKFEMDGCNE> DLMGJKFONFI;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<PIKFEMDGCNE, PIKFEMDGCNE> AHJEMDHNIHI;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<PIKFEMDGCNE, PIKFEMDGCNE, PIKFEMDGCNE> OHOHLDNNHIK;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<PIKFEMDGCNE> DBNPAKNKNAP;

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PJKECLEBMJN(PIKFEMDGCNE NLDMFIFGFAP, PIKFEMDGCNE OKLMKFMFKLH);

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PIKFEMDGCNE JJCKABHNNCH(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<PIKFEMDGCNE> BKNAOLNPABG(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PIKFEMDGCNE OIKMMBKLBID(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AMMGHPAGHMG(PIKFEMDGCNE NLDMFIFGFAP, Vector3 IFELKENEBNH, Quaternion CAMLICDMCOD);

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JICFKCHFHHO(PIKFEMDGCNE NLDMFIFGFAP, float ADOIKFCFGFK);

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool LKOLNHDEJEB(PIKFEMDGCNE NLDMFIFGFAP, [Out] RigidTransform DECEMDBPCOA);

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool GMPFANACJIK(PIKFEMDGCNE NLDMFIFGFAP, [Out] float NAEPCPFMHPI);

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 NONMNDKPAKI(MOMKGJNOBKK LAMMJGELEOL);

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion GLLAEBBGAIJ(MOMKGJNOBKK LAMMJGELEOL);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class BAEAOIECMPO
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface EJEFMPHKCHI
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	object MFFMCKJCGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DACOKKNPFME(KAPJLDAAMDP ELECKCHAEHL);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum OJCMKOCGCME
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class KLBPKIJAAOK
{
	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0xB4F2D0", Offset = "0xB4E6D0", VA = "0x180B4F2D0")]
	public static bool BKMALKOMLFJ(this OJCMKOCGCME ADCHACEKJAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0xB4F0E0", Offset = "0xB4E4E0", VA = "0x180B4F0E0")]
	public static bool MDJBJKBILIO(this OJCMKOCGCME ADCHACEKJAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x214D530", Offset = "0x214C930", VA = "0x18214D530")]
	public static bool OEENBPCLBGH(this OJCMKOCGCME ADCHACEKJAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public enum FKFGBFLAGIB
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Neck,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Shoulders,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Stomach,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Hips,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	UpperArmR,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	LowerArmR,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	HandR,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	UpperArmL,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	LowerArmL,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	HandL,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	UpperLegR,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	LowerLegR,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	FootR,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	UpperLegL,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	LowerLegL,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	FootL,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class AAIHHKLHMBB
{
	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0xD85170", Offset = "0xD84570", VA = "0x180D85170")]
	public static int FANJFFHDMGO(this FKFGBFLAGIB PAHKKNONPEO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface NKAEJJFCGLA
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface IBANJFNBHAL
{
	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	OJCMKOCGCME NICGGPBEAAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	OJCMKOCGCME CFKKEBBHMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	OJCMKOCGCME BKBFLDHHCMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	OJCMKOCGCME EFBMDIDFCOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	OJCMKOCGCME ONLOPNKIKPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	OJCMKOCGCME OPMAEJPPHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	OJCMKOCGCME CLLCDKHFKOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	OJCMKOCGCME MMOEBFHKDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	OJCMKOCGCME KLBMHFBOHBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	OJCMKOCGCME MCHCBBPFJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	OJCMKOCGCME HIPHCCNJOGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	OJCMKOCGCME KJEIOLHIAJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	OJCMKOCGCME PEHODDHNIBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface ONIKLEKCMGJ
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<KGPGOHGPLBM> EFPAIKFAPPD;

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PIKFEMDGCNE NDNFDBCKLEG(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HKHMJCLOELA(List<PIKFEMDGCNE> OMOFINJPJEO);

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PIKFEMDGCNE EMHBODDIPIM(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DFODMMMMNPP(PIKFEMDGCNE NLDMFIFGFAP, PIKFEMDGCNE AOGBEAODJPP, bool LEKOMNGDBPN);

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HEHBLJDHKBO(PIKFEMDGCNE NLDMFIFGFAP, PIKFEMDGCNE AOGBEAODJPP);

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int IIDLBOCBDKL(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KAPJLDAAMDP GEAILDCBFJH(PIKFEMDGCNE HICOIGNOKIJ);

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<PIKFEMDGCNE> OPMBMBBCKCM(PIKFEMDGCNE HICOIGNOKIJ);

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LAGDLKNBJMH(PIKFEMDGCNE NLDMFIFGFAP, PIKFEMDGCNE BILCAJKFALG);

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool PIALJHGPMDG(PIKFEMDGCNE NLDMFIFGFAP, PIKFEMDGCNE JCCGNJNAHGH);

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PIKFEMDGCNE HELBHOENBIH(PIKFEMDGCNE GOOANMNBGEP, PIKFEMDGCNE JIDMOEDOPOD);

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool OFMLENFMJIM(PIKFEMDGCNE GOOANMNBGEP, PIKFEMDGCNE JIDMOEDOPOD, [Out] PIKFEMDGCNE GNKLEJKLDFN);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class DPKAGBBMGBL
{
	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x60F6380", Offset = "0x60F5780", VA = "0x1860F6380")]
	public static List<PIKFEMDGCNE> HKHMJCLOELA(this ONIKLEKCMGJ MFMFAILCOEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface KFLBBFHHKOK
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	bool ACKAAJLGMEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	bool FILJJHPFDII
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface NOHIOKOKBGI : CJAPHGFILGA
{
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OIDCJBEKEGF(Entity HJECHGCECJI, [Out] JNEEOCLFOHA AEBAPBHOHLJ);

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KIHNFCJPGAP(NativeArray<JNEEOCLFOHA> DEEBIKGCDFA, NativeArray<BICIHJMEDHB> JBLKEJADPLO);

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NIPHBGJJFFJ(JNEEOCLFOHA AEBAPBHOHLJ);

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JHLMAIPGLAB(JNEEOCLFOHA AEBAPBHOHLJ, [Out] Collider OHBBEBBKENI);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface CJAPHGFILGA
{
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLGONMFEPKB([In] float3 KNAFBGNLKFP, [In] float3 PLJNLCOFMBP, float IPFKFHJNJJM, Allocator FHOLEANHCPH, [Out] NativeArray<Entity> NNLFMKFJDMK);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface MJOMPALBFPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLGONMFEPKB([In] float3 KNAFBGNLKFP, [In] float3 PLJNLCOFMBP, float IPFKFHJNJJM, [Out] BHNBHBLKHFB IJDIINJHCGJ, [Out] PIKFEMDGCNE GKPBJKGCCAF);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface PGPMLIAJOFF
{
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLGONMFEPKB([In] NativeArray<Entity> NNLFMKFJDMK, [In] float3 KNAFBGNLKFP, [In] float3 PLJNLCOFMBP, [In] NativeArray<BHNBHBLKHFB> EJIOEEMIPIB);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct JNEEOCLFOHA : BJIOFLLCOHO, IEquatable<JNEEOCLFOHA>
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public int GOBEDCIKOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x890610", Offset = "0x88FA10", VA = "0x180890610", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x890600", Offset = "0x88FA00", VA = "0x180890600", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public int FNFGJIKMFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2167AC0", Offset = "0x2166EC0", VA = "0x182167AC0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x549B270", Offset = "0x549A670", VA = "0x18549B270", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x60FC280", Offset = "0x60FB680", VA = "0x1860FC280", Slot = "8")]
	public bool Equals(JNEEOCLFOHA JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x60FC2D0", Offset = "0x60FB6D0", VA = "0x1860FC2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct BHNBHBLKHFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float FOMCPMEEGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 KELADLMJIOC;
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface DNENJLKNEIM
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface PHBGNBDDIGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	NDJMIMDENEP HCOJGCBNHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	INCPAOGFKKN DODJHGDBEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<KAPJLDAAMDP, NativeArray<GEIFGNPODDN>> AJLNBCBDEEN;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<KAPJLDAAMDP> FFMJLIOBCKP;

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OEEGCNHLDOI BOKDDGDLKPP(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GEIFGNPODDN PIHCFJCAIAE(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OAIKDCNGOPG(KDLKNOEDFHK LMDNMFFNHAP, DBMHPHOGJOG BMHOFCNAKIL);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AGOBKOHILJP(KDLKNOEDFHK[] FHIOGCFCAIG, GameObject IFGJJHCIEPA);

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CJDMOFLNOBE PDPDBFJKGLF(PIKFEMDGCNE NLDMFIFGFAP, [Optional] object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EFHFKPOHPGN(PIKFEMDGCNE NLDMFIFGFAP, [Out] DBMHPHOGJOG BMHOFCNAKIL);

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KFJDINAEMIA(PIKFEMDGCNE NLDMFIFGFAP, [Out] Transform FIFLCPFGAIF);

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool JMEPPGPBLEL(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AAMCAFIJDCO(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool BBHOMHDNJAO(LocalId NLDMFIFGFAP, object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool EHKOFKAJAHP(LocalId NLDMFIFGFAP, object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	PIKFEMDGCNE NLHMHOGJDBP(KDLKNOEDFHK LMDNMFFNHAP);

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool FFDDNBPEMDL(KDLKNOEDFHK LMDNMFFNHAP, [Out] PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	KDLKNOEDFHK DNBCCCECHDG(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	KAPJLDAAMDP NLHMHOGJDBP(NativeArray<KDLKNOEDFHK> LMDNMFFNHAP, Allocator FHOLEANHCPH);

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "21")]
	KAPJLDAAMDP LHBKNGKNEFJ(GEIFGNPODDN LDBFOCMCGPO, int GNHCGOJHAJG, Allocator FHOLEANHCPH);

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "22")]
	KAPJLDAAMDP AOJLIJKNOCB(NativeArray<KDLKNOEDFHK> LMDNMFFNHAP, NativeArray<IGCNJDEPJCJ> FEAANJCAIPE, Allocator FHOLEANHCPH);

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "23")]
	KDLKNOEDFHK[] KHHBJONJMCA(string JOJBJEEFDFC, CJDMOFLNOBE CGPOOAIDKLC, bool DPHIOMIAHHI);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LEBKGNCFJCD(string JOJBJEEFDFC, KDLKNOEDFHK[] FHIOGCFCAIG);

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "25")]
	CJDMOFLNOBE IMIAOADOOGM(GEIFGNPODDN LDBFOCMCGPO, bool HHFCMPCBPBK);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CJDMOFLNOBE IMIAOADOOGM(GEIFGNPODDN LDBFOCMCGPO);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "27")]
	CJDMOFLNOBE FDALOBNJOBN(GEIFGNPODDN LDBFOCMCGPO);

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "28")]
	CJDMOFLNOBE GBFBAIPOCMI(GEIFGNPODDN LDBFOCMCGPO);

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "29")]
	CJDMOFLNOBE AOJLIJKNOCB(KDLKNOEDFHK LMDNMFFNHAP, GEIFGNPODDN LDBFOCMCGPO);

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "30")]
	FHJCPCJGOOH CLBEPMGIGCH();

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	FJEOEANDMAA FFKIPLLDLDL();

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	DEDFHDHFNNL HCHJAOGGPMK(IBKDJMDJCHE ILLDOIMLHJK);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void GOBDIDNMEKM(KAPJLDAAMDP ELECKCHAEHL);

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void GOHOEIHDKHJ(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void AHJEJHKMJPN(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void GOBDIDNMEKM(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "37")]
	KAPJLDAAMDP DKFDLPNIMLI(KAPJLDAAMDP KCFGLAPLBDB, Allocator FHOLEANHCPH);

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool ANCJEEDCBON(PIKFEMDGCNE NLDMFIFGFAP);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class LELDADOIPDA
{
	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6101700", Offset = "0x6100B00", VA = "0x186101700")]
	public static void AAMCAFIJDCO(this PHBGNBDDIGC EFNPFLBMIPO, DBMHPHOGJOG BMHOFCNAKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x6101CA0", Offset = "0x61010A0", VA = "0x186101CA0")]
	public static CJDMOFLNOBE JEJAIAPLBBI(this PHBGNBDDIGC EFNPFLBMIPO, LocalId NLDMFIFGFAP)
	{
		return default(CJDMOFLNOBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x6101CD0", Offset = "0x61010D0", VA = "0x186101CD0")]
	public static CJDMOFLNOBE JEJAIAPLBBI(this PHBGNBDDIGC EFNPFLBMIPO, KDLKNOEDFHK LMDNMFFNHAP)
	{
		return default(CJDMOFLNOBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x6101CA0", Offset = "0x61010A0", VA = "0x186101CA0")]
	public static PIKFEMDGCNE NLHMHOGJDBP(this PHBGNBDDIGC EFNPFLBMIPO, LocalId NLDMFIFGFAP)
	{
		return default(PIKFEMDGCNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x6101900", Offset = "0x6100D00", VA = "0x186101900")]
	public static KDLKNOEDFHK DNBCCCECHDG(this PHBGNBDDIGC EFNPFLBMIPO, LocalId NLDMFIFGFAP)
	{
		return default(KDLKNOEDFHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x6101780", Offset = "0x6100B80", VA = "0x186101780")]
	public static bool ANCJEEDCBON(this PHBGNBDDIGC EFNPFLBMIPO, KDLKNOEDFHK LMDNMFFNHAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x26A6250", Offset = "0x26A5650", VA = "0x1826A6250")]
	public static T OECDDLOHDEB<T>(this PHBGNBDDIGC EFNPFLBMIPO, LocalId NLDMFIFGFAP) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x6101BA0", Offset = "0x6100FA0", VA = "0x186101BA0")]
	public static FHJCPCJGOOH GLAINCBPGCP(this PHBGNBDDIGC EFNPFLBMIPO, RigidTransform GCOJJOLKENK, [Optional] object KNOHBODGPLL)
	{
		return default(FHJCPCJGOOH);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x61017F0", Offset = "0x6100BF0", VA = "0x1861017F0")]
	public static DEDFHDHFNNL DGJBJCMLCBE(this PHBGNBDDIGC EFNPFLBMIPO, IBKDJMDJCHE KAOKAJNPMEJ, RigidTransform GCOJJOLKENK, [Optional] object KNOHBODGPLL)
	{
		return default(DEDFHDHFNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x6101D30", Offset = "0x6101130", VA = "0x186101D30")]
	public static FJEOEANDMAA NGAEMLCCIKD(this PHBGNBDDIGC EFNPFLBMIPO, RigidTransform GCOJJOLKENK, [Optional] object KNOHBODGPLL)
	{
		return default(FJEOEANDMAA);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x6101980", Offset = "0x6100D80", VA = "0x186101980")]
	private static void EPKKJCJNMGF(CJDMOFLNOBE OOIOEJAIOAP, RigidTransform GCOJJOLKENK, [Optional] object KNOHBODGPLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface DJEOHCJHENI
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	bool KHECAKALMEN
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	PIKFEMDGCNE GBJKCCEIAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	CJDMOFLNOBE BKMEPGCOGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event JBGOJMAKCFO FHMPBBGJEJJ;

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PIKFEMDGCNE HELBHOENBIH(PIKFEMDGCNE GOOANMNBGEP, PIKFEMDGCNE JIDMOEDOPOD);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OFMLENFMJIM(PIKFEMDGCNE GOOANMNBGEP, PIKFEMDGCNE JIDMOEDOPOD, [Out] PIKFEMDGCNE GNKLEJKLDFN);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HDBNINPNAMP();

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BEINGLBHAJB();

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OOKDCMFNFGH(PIKFEMDGCNE GOOANMNBGEP);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PEMKBMPFCKE(PIKFEMDGCNE GOOANMNBGEP);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public delegate void JBGOJMAKCFO(CJDMOFLNOBE CHDLBFPLNPE, CJDMOFLNOBE GDKKBONFOGK);
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class HFIFAHDPDOL
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x60F9690", Offset = "0x60F8A90", VA = "0x1860F9690")]
	public static bool GOKHICPNOJL(this DJEOHCJHENI IMHJLNGJJPH, PIKFEMDGCNE GOOANMNBGEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x60F9770", Offset = "0x60F8B70", VA = "0x1860F9770")]
	public static bool LDGPPEIDHFH(this DJEOHCJHENI IMHJLNGJJPH, PIKFEMDGCNE GOOANMNBGEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface KLOIILEEOLG
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCEDBNDLILC(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFNGCLJEHBE(PIKFEMDGCNE NLDMFIFGFAP, Transform FIFLCPFGAIF);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface HDDDNNNEGOF
{
	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHMDBFNNKDC(PIKFEMDGCNE GOOANMNBGEP, PIKFEMDGCNE EDGMIFENGFK, PIKFEMDGCNE GOBFMAHOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PIKFEMDGCNE GCCJLDFNDIM(PIKFEMDGCNE GOOANMNBGEP);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface BJOHEPPOIKB
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFONNNKPCCH(PIKFEMDGCNE HICOIGNOKIJ, bool PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNLHDEACOOG(PIKFEMDGCNE HICOIGNOKIJ, bool PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBCGGNFPPCP(PIKFEMDGCNE HICOIGNOKIJ, int PAHKKNONPEO);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface KDEKDBHJJHD
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<PIKFEMDGCNE> ALEOMKPFOIA(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PIKFEMDGCNE JJHPIPJABKH(PIKFEMDGCNE NLDMFIFGFAP, int FGBBDGJMFEH);

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int KPJEJAPLHDK(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MKCNMENAIME DAECBEBCHLO(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HPOIGNJHKNE(PIKFEMDGCNE NLDMFIFGFAP, MKCNMENAIME LALAKJLPIGH);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PIKFEMDGCNE EBCEMKLBNAB(PIKFEMDGCNE NLDMFIFGFAP, [Optional] float3? BCGGHPIMKDA, [Optional] quaternion? GIJALKLADPN, [Optional] float3? GLDPLANNJMB);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PIKFEMDGCNE NFNNPLBPCCA(PIKFEMDGCNE NLDMFIFGFAP, int FGBBDGJMFEH, [Optional] float3? BCGGHPIMKDA, [Optional] quaternion? GIJALKLADPN, [Optional] float3? GLDPLANNJMB);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GKGNNFHNHOK(PIKFEMDGCNE NLDMFIFGFAP, int FGBBDGJMFEH);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OFFJNHIMIGA(PIKFEMDGCNE NLDMFIFGFAP);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface HINFCGHOGAM
{
	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJPBLNKGOHL();

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBFOHEOEJBI();

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFJPBBAFMPF();

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJGMJACCJDJ();

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DHKNAJNLNHG();

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IMHCLCENLOC();

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KPHLCLNKDOF();

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HJBANIOEEGL();

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ADMGOIGIANC();

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LGADKNBIKOC();

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LCBBNBNABKO();
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface OHIKFHHALBD
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HAJLNPJFNAG(Entity HJECHGCECJI);

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHACPGGNEGO(Entity HJECHGCECJI, [In] float3 PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 JDECPGLGMHJ(Entity HJECHGCECJI);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NPHKJKJIOCG(Entity HJECHGCECJI, [In] quaternion PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion FHCECDBHOBN(Entity HJECHGCECJI);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MPMAHCIKHCB(Entity HJECHGCECJI, [Out] float3 BCGGHPIMKDA, [Out] quaternion GIJALKLADPN);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MPMAHCIKHCB(Entity HJECHGCECJI, [Out] RigidTransform HMNNNGKLFCN);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BLLAJDHKICA(Entity HJECHGCECJI, [Out] RigidTransform HMNNNGKLFCN);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 MFIFPDMBNJD(Entity HJECHGCECJI);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void INJAEFPMBFD(Entity HJECHGCECJI, [In] float3 PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ANFFPDBCKNP(Entity HJECHGCECJI, float PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float LHKELEPHFPD(Entity HJECHGCECJI);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IFDGABJCKFB(Entity HJECHGCECJI, [In] float3 PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 EIEAFJBECHL(Entity HJECHGCECJI);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EJGLFENOLCM(Entity HJECHGCECJI, [In] float3 PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 EGDCAMOFNOH(Entity HJECHGCECJI);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KPABJNKBDNB(Entity HJECHGCECJI, [In] quaternion PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion FDDOMECOAOK(Entity HJECHGCECJI);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 DIECMNHEOGC(Entity HJECHGCECJI);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NMMOGEAJOMP(Entity HJECHGCECJI, [In] float3 PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HECCHMNJDDO(Entity HJECHGCECJI, float PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float BNODKPNDJJN(Entity HJECHGCECJI);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NPMDOJPCJDP(Entity HJECHGCECJI, [In] float3 PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 FIPLHNEDAKN(Entity HJECHGCECJI);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MJBACCEFMEL(Entity HJECHGCECJI, [Out] float4x4 JKLNLJAJGND);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void EKFAJOACDAI(Entity HJECHGCECJI, [In] float4x4 JKLNLJAJGND);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FKOFJMEGCIE(Entity HJECHGCECJI, [Out] float4x4 JKLNLJAJGND);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool KFJDINAEMIA(Entity HJECHGCECJI, [Out] Transform FIFLCPFGAIF);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void ALCFCAPPAAP(Entity HJECHGCECJI);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void IMABGMMCOEB(Entity HJECHGCECJI, Entity MCAELOEJBPL, Entity JOPIDNPFKKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class ANKOENMBBIN
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface KOJHPKPPCKA
{
	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World LPPBHFMKFED(string CKKBKPHHGNJ = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World NPPFEGKGGCD(string CKKBKPHHGNJ = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World DCBCBEOPPKI(string CKKBKPHHGNJ = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World JGDIBAEKAEF(string CKKBKPHHGNJ = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface JAGKOLPEDFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000135")]
	World DNDIDFNJDBF
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	World HPFKBGBPFHL
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	EntityManager MFEBCDLDBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	bool NABJPIJAAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase LHPGIJKCKLO(Type KHENBEDBKDI);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class KLJMGOEGPKG
{
	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6100D50", Offset = "0x6100150", VA = "0x186100D50")]
	public static ComponentSystemBase ACFFCADHFJP(this World KCEHNBBOIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x26A22E0", Offset = "0x26A16E0", VA = "0x1826A22E0")]
	public static T LHPGIJKCKLO<T>(this JAGKOLPEDFD PNNCNMHPIIB) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface FPCNOMOBEPC
{
	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLKABMBNDFC(NativeListAsync<Entity> KOMNHEHLKGM);

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHDIKFPEMAH(OJCPBFBBKCN JJGBLPHEOHF);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGKDHKNHAIG(NativeListAsync<Entity> MKEBHFBAGNC, bool GHLDBPIDINK);

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PNJCJGPKBLN();
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface BHJNCMEMGNN
{
	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMMENDBBAIP(PIKFEMDGCNE NLDMFIFGFAP, [Out] Collider OHBBEBBKENI);

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject EOIMKOGJHBL(PIKFEMDGCNE KMEIONCGHLN, GameObject PCKAKIJCIKM, Vector3 OHOMLOMNFJE, Quaternion MCGHOJEKKGM);

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CIJOCCKBOJO(GameObject OHBBEBBKENI);

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider ENBHEEPNJBI<TCollider>(GameObject EHNKKDDHDBE) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BNEMLMFACCM(Collider OHBBEBBKENI);

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject BDGPEJJAGGN<TCollider>(string ADLKEGECLOG) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface OOKLJKFKLMF
{
	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MOAEOCDNNII(PIKFEMDGCNE NLDMFIFGFAP, MFHODNHFMAH EFOOPEHGLFO, bool NOCOEFCKKFC, KNNICLABCMC GPCHCDOIECP);

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJABNBEAGLO(PIKFEMDGCNE NLDMFIFGFAP, MFHODNHFMAH EFOOPEHGLFO, bool NOCOEFCKKFC, bool LIJNGIIOKBH, bool CEAGOFIBAEF);

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FFIODFGLPHK DHPGBJBGEKP(PIKFEMDGCNE MMKDJDGOBEM, List<PIKFEMDGCNE> IKODODFFGLO);

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EOJDCDFIFJL(GameObject CJCCBLFBJBD, GameObject DNDBMNOPLJO);

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJCKJALHMBP(GameObject DNDBMNOPLJO);

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T ENBHEEPNJBI<T>(GameObject EHNKKDDHDBE) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BNEMLMFACCM(Collider OHBBEBBKENI);

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject IHLKMFIPJJF<T>(string ADLKEGECLOG) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface KGBGGKOMJHD
{
	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFFDONLLAMM(PIKFEMDGCNE NLDMFIFGFAP, BNGOJKAKFNA PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BNGOJKAKFNA OPOIAKAGKNG(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HOIHJCNCDNK(PIKFEMDGCNE NLDMFIFGFAP, PIKFEMDGCNE PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FMLLAAPNOHK(PIKFEMDGCNE NLDMFIFGFAP, PIKFEMDGCNE PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IIDLBOCBDKL(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PIKFEMDGCNE FKOFFCDOILJ(PIKFEMDGCNE NLDMFIFGFAP, int FGBBDGJMFEH);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NDKIJBDIDDJ(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CBLHHKLDGCJ(PIKFEMDGCNE NLDMFIFGFAP, object KNOHBODGPLL, PIKFEMDGCNE PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AGPGLGMDPJD(PIKFEMDGCNE NLDMFIFGFAP, object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CBNANGAAGKG(PIKFEMDGCNE NLDMFIFGFAP, [Out] PIKFEMDGCNE PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PLHIJCFOIAN(PIKFEMDGCNE NLDMFIFGFAP, float3 PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BHNFPGFHMPJ(PIKFEMDGCNE NLDMFIFGFAP, [Out] float3 PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BPOIAHLAKIA(PIKFEMDGCNE NLDMFIFGFAP, float3 PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool IMBJPJANDNO(PIKFEMDGCNE NLDMFIFGFAP, [Out] float3 PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MIHGNIDHFBI(PIKFEMDGCNE NLDMFIFGFAP, (Quaternion rot, Vector3 moments) CMOAOKDCAAH);

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool NHMEIOFCCJK(PIKFEMDGCNE NLDMFIFGFAP, [Out] quaternion LMGFHFMPEAE, [Out] float3 KDIPPMPFIED);

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AOOBBMHHPLP(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IKNCLGKCIEA(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 KBCJBNPNFLA(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 KKAFNOPPMDO(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LCOKIBAOACG(PIKFEMDGCNE NLDMFIFGFAP, float3 PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void PMHFJCACPFC(PIKFEMDGCNE NLDMFIFGFAP, float3 PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float DLNPEEKEMEN(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float JMGAOBDHNCB(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CIJKONBKKEM(PIKFEMDGCNE NLDMFIFGFAP, float PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void BKGOCMIKIJA(PIKFEMDGCNE NLDMFIFGFAP, float PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode FEBOGBBIJHF(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EJGBIONOHAE(PIKFEMDGCNE NLDMFIFGFAP, CollisionDetectionMode PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "28")]
	PLAOLPDBAPK MGIKGIKICJJ(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FPOBPCPIEOF(PIKFEMDGCNE NLDMFIFGFAP, PLAOLPDBAPK PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool BJJMGIHEKOG(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void HMPJKKEEOGM(PIKFEMDGCNE NLDMFIFGFAP, bool PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(Slot = "32")]
	PIKFEMDGCNE NDNFDBCKLEG(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void BDGOCGBHOIH(PIKFEMDGCNE NLDMFIFGFAP, PIKFEMDGCNE PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "34")]
	PIKFEMDGCNE EMHBODDIPIM(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void DFODMMMMNPP(PIKFEMDGCNE NLDMFIFGFAP, PIKFEMDGCNE PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "36")]
	MDABCJFKJMP POAKMPFGCNH(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void MBCOFOGKKCM(PIKFEMDGCNE NLDMFIFGFAP, MDABCJFKJMP MAEMLLLMPFG);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool CMEFJPLJNLC(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void PBOJHKLKDDD(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool MGILCILHJAJ(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void INLGEINDFJO(PIKFEMDGCNE NLDMFIFGFAP, bool PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool AKHBPGGOLJB(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void GOHPKJKHPJK(PIKFEMDGCNE NLDMFIFGFAP, bool PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints LHOMDJOOEFG(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void BONAMAGACAG(PIKFEMDGCNE NLDMFIFGFAP, RigidbodyConstraints PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float EFKJHPNFBKE(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void PJOFMDNDMBE(PIKFEMDGCNE NLDMFIFGFAP, float PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float IDMOIACKJHP(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void NILLLAAPMMF(PIKFEMDGCNE NLDMFIFGFAP, float PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool LECDADLPJDC(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void OAJMBOBLFME(PIKFEMDGCNE NLDMFIFGFAP, bool PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool KCLOEEMOEHN(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void DINABFELACN(PIKFEMDGCNE NLDMFIFGFAP, bool PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void PDANFLDKFNH(PIKFEMDGCNE NLDMFIFGFAP, int PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object NNJGOHOBBJP(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void HMNNKEKIDMJ(PIKFEMDGCNE NLDMFIFGFAP, object PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object MDDBFEDICFC(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void BGDHDOMNCKN(PIKFEMDGCNE NLDMFIFGFAP, object PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float ILHJGBFIJKK(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void IMKNDKIDFHL(PIKFEMDGCNE NLDMFIFGFAP, float PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void MPNPGEJIEMB(PIKFEMDGCNE NLDMFIFGFAP, object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void MGBNOHKHJFJ(PIKFEMDGCNE NLDMFIFGFAP, object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool OFFIHBPAEBE(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void LKOIFEGCGID(PIKFEMDGCNE NLDMFIFGFAP, object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void BEECECDCEJM(PIKFEMDGCNE NLDMFIFGFAP, object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool CCIADPLHDKH(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool POAGJLABOAK(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody IKOFMPCLFBC(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void LMMIHANDNDG(PIKFEMDGCNE NLDMFIFGFAP, Rigidbody PKDFFNNLBIJ);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void NKKMMACOGPC(PIKFEMDGCNE NLDMFIFGFAP, object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void FLFGGGFBBEG(PIKFEMDGCNE NLDMFIFGFAP, object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool CBCHHDPKGJD(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void KALPGEBKCDC(PIKFEMDGCNE NLDMFIFGFAP, float3 MADKEMKIPKF);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void EDEGCIBJHHE(PIKFEMDGCNE NLDMFIFGFAP, float3 PEAINEKGLBJ);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool APBHODLFHCG(PIKFEMDGCNE NLDMFIFGFAP, [Out] float3 MADKEMKIPKF);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool BOOODGEFANB(PIKFEMDGCNE NLDMFIFGFAP, [Out] float3 PEAINEKGLBJ);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool NLJLIAGNBHP(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void OPAGENGGIKL(PIKFEMDGCNE NLDMFIFGFAP, object KNOHBODGPLL, bool OFNKHCCEJML);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void ALLOBIHFKOK(PIKFEMDGCNE NLDMFIFGFAP, bool DABEOIBAMEA);

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void BKEAEEHMIFH(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool PALGALGCILB(PIKFEMDGCNE NLDMFIFGFAP);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface BPGACLDPFJK
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	bool NABJPIJAAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HCBLPJLOMFF(PIKFEMDGCNE NLDMFIFGFAP);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HJNMHEKNPFD(PIKFEMDGCNE NLDMFIFGFAP, bool NOCOEFCKKFC, bool LIJNGIIOKBH, bool GMGJFBJDGBP);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OFHCDGFMJDC(PIKFEMDGCNE NLDMFIFGFAP, float3 ACBJEELMNFK);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGNEFIENJEB(PIKFEMDGCNE NLDMFIFGFAP, float3 ACBJEELMNFK);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface OLCBMKFENIA
{
	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPJJHBJBMDB(Entity LHDFJOFPIGD);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNMILNKKLLG(Entity LHDFJOFPIGD);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public delegate void AKFKPNFFCBM(KOHIKLEKLLE GBILIOAHKMP);
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct KOHIKLEKLLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly KAPJLDAAMDP JBFPDIMNPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly NativeArray<byte> JBDKOGGCLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NativeArray<byte> MCNFPBNKOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly LFNJFOCLDOK OBPHOMEOEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly int POLBLALBKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Type FABCLOHKJIG;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public KAPJLDAAMDP FBBPCEJJDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x3B753A0", Offset = "0x3B747A0", VA = "0x183B753A0")]
		get
		{
			return default(KAPJLDAAMDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6101490", Offset = "0x6100890", VA = "0x186101490")]
	public KOHIKLEKLLE(KAPJLDAAMDP JBFPDIMNPKI, NativeArray<byte> JBDKOGGCLOE, NativeArray<byte> MCNFPBNKOPP, LFNJFOCLDOK OBPHOMEOEEI, int POLBLALBKMF, Type FABCLOHKJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x26A3A80", Offset = "0x26A2E80", VA = "0x1826A3A80")]
	public NativeArray<T> KKMLBEGKKCI<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x26A3A40", Offset = "0x26A2E40", VA = "0x1826A3A40")]
	public NativeArray<T> GHPIEIKHPHP<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x26A3AC0", Offset = "0x26A2EC0", VA = "0x1826A3AC0")]
	public (KAPJLDAAMDP, NativeArray<T>, NativeArray<T>) LBFOALNGCEO<T>() where T : struct
	{
		return default((KAPJLDAAMDP, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x6101440", Offset = "0x6100840", VA = "0x186101440")]
	public KGPGOHGPLBM EPAEALPCJDE()
	{
		return default(KGPGOHGPLBM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface MCNJCGGAPNA
{
	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	string DBFDJGCEILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	MCNJCGGAPNA NCEINDNIAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	IEnumerable<MCNJCGGAPNA> FKPOMAEHCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface HIILADGNMKM
{
	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	MCNJCGGAPNA NGHDFJHPALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	List<PDNLOOAKMDB> DDAMENEJCOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JPNIKDJHGEP(PDNLOOAKMDB JAOOJJKNLDO, [Out] MCNJCGGAPNA FMBECMFGEIP);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OAIKDCNGOPG(PDNLOOAKMDB JAOOJJKNLDO, AKFKPNFFCBM CFPHEOFKAOO);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LJBJCLEGBND(PDNLOOAKMDB JAOOJJKNLDO, AKFKPNFFCBM CFPHEOFKAOO);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct KGPGOHGPLBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly KOHIKLEKLLE GMLIPIALCHN;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public KAPJLDAAMDP FBBPCEJJDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x3B753A0", Offset = "0x3B747A0", VA = "0x183B753A0")]
		get
		{
			return default(KAPJLDAAMDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x60FFBA0", Offset = "0x60FEFA0", VA = "0x1860FFBA0")]
	public KGPGOHGPLBM(KOHIKLEKLLE GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x60FF9B0", Offset = "0x60FEDB0", VA = "0x1860FF9B0")]
	public KAPJLDAAMDP KKMLBEGKKCI()
	{
		return default(KAPJLDAAMDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x60FF8E0", Offset = "0x60FECE0", VA = "0x1860FF8E0")]
	public KAPJLDAAMDP GHPIEIKHPHP()
	{
		return default(KAPJLDAAMDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x60FFA80", Offset = "0x60FEE80", VA = "0x1860FFA80")]
	public (KAPJLDAAMDP, KAPJLDAAMDP, KAPJLDAAMDP) LBFOALNGCEO()
	{
		return default((KAPJLDAAMDP, KAPJLDAAMDP, KAPJLDAAMDP));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DefaultMember("Item")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface ODJPNEEHEHF : IEnumerable<BIPAFKAMHFJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000141")]
	NativeBitArray EFLMAKBGCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	NativeArray<int> DPCAACFIEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	BIPAFKAMHFJ GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	BIPAFKAMHFJ GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BIPAFKAMHFJ LJGMJDCNAPG(DIAMJOHNDFJ MAMIOIALJGO);

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LFNJFOCLDOK MDDLODHNKLB(DIAMJOHNDFJ MAMIOIALJGO);
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class LIAFLHGJHLI
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
[DefaultMember("Item")]
public interface NPABLDJDHJN : IEnumerable<MHPOOCEFGCE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000146")]
	int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	MHPOOCEFGCE GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MHPOOCEFGCE LJGMJDCNAPG(DIAMJOHNDFJ MAMIOIALJGO);

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LFNJFOCLDOK MDDLODHNKLB(DIAMJOHNDFJ MAMIOIALJGO);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class OBCIIBJGIFL
{
	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2780F70", Offset = "0x2780370", VA = "0x182780F70")]
	public static LFNJFOCLDOK MDDLODHNKLB<T>(this NPABLDJDHJN OGGBBPNBCPJ, LAJKGOLNJIJ<T> ADLKEGECLOG) where T : struct
	{
		return default(LFNJFOCLDOK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[DefaultMember("Item")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface IELCFCDCHDL : IEnumerable<PDNLOOAKMDB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000148")]
	int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	PDNLOOAKMDB GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PDNLOOAKMDB LJGMJDCNAPG(DIAMJOHNDFJ MAMIOIALJGO);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LFNJFOCLDOK MDDLODHNKLB(DIAMJOHNDFJ MAMIOIALJGO);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class BJJNIDGIIAN
{
	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x23F2AD0", Offset = "0x23F1ED0", VA = "0x1823F2AD0")]
	public static CDGNCMIHCDN<T> LJGMJDCNAPG<T>(this IELCFCDCHDL OGGBBPNBCPJ, DIAMJOHNDFJ ADLKEGECLOG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x23F2C10", Offset = "0x23F2010", VA = "0x1823F2C10")]
	public static LFNJFOCLDOK MDDLODHNKLB<T>(this IELCFCDCHDL OGGBBPNBCPJ, LAJKGOLNJIJ<T> ADLKEGECLOG) where T : struct
	{
		return default(LFNJFOCLDOK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface GHNNAKLKJGM
{
	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAIKDCNGOPG(DIAMJOHNDFJ JAOOJJKNLDO, AKFKPNFFCBM CFPHEOFKAOO);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJBJCLEGBND(DIAMJOHNDFJ JAOOJJKNLDO, AKFKPNFFCBM CFPHEOFKAOO);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class JEHMHFLJCBO
{
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface BANDECAHEAB
{
	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	OCHAJOCKKBL OBBOKGHGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NFOACFNGKCB(KDLKNOEDFHK LMDNMFFNHAP, LFNJFOCLDOK JAOOJJKNLDO);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIOEDBBIBCP(KDLKNOEDFHK LMDNMFFNHAP, Span<LFNJFOCLDOK> OGGBBPNBCPJ, bool LJENFNOPNBN);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONCFOCBJAEF(NativeArray<KDLKNOEDFHK> FHIOGCFCAIG);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class LCMOAMBFMPL
{
	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x61015A0", Offset = "0x61009A0", VA = "0x1861015A0")]
	public static void PIOEDBBIBCP(this BANDECAHEAB HFGAKAPEEIF, KDLKNOEDFHK LMDNMFFNHAP, LFNJFOCLDOK JAOOJJKNLDO, bool LJENFNOPNBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public readonly struct OCHAJOCKKBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly NativeBitArray GJGLIIAJNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly NativeParallelHashMap<KDLKNOEDFHK, int> EHBFEDCJLGE;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool BJKMFDFMJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6103370", Offset = "0x6102770", VA = "0x186103370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0xB5FB00", Offset = "0xB5EF00", VA = "0x180B5FB00")]
	public OCHAJOCKKBL(NativeBitArray GJGLIIAJNMG, NativeParallelHashMap<KDLKNOEDFHK, int> EHBFEDCJLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6103390", Offset = "0x6102790", VA = "0x186103390")]
	public bool NFOACFNGKCB(KDLKNOEDFHK LMDNMFFNHAP, LFNJFOCLDOK JAOOJJKNLDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface LMLMENEGPLG
{
	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NGCOCCIKDCM(PIKFEMDGCNE NLDMFIFGFAP, HJBJOPMAJKJ PAHKKNONPEO);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface JGJNCCBKCMD
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	JABODDDNBPD DAABPHJHAOF
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface HMAKCLADFMA
{
	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	Type HJKJIAIKBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[NBLGEMLEKLJ(BLCHILNGIEA.LoadInstance)]
public interface DDNLKIONPAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEGGLEDLAIN(PIKFEMDGCNE HICOIGNOKIJ, bool PAHKKNONPEO);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public readonly struct PFKKOPJFLDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly IEnumerable<MLCNMHOEFKC> KIOFBMLNCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly IReadOnlyList<GameObject> GALIAMMCDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly IReadOnlyList<int> BNKNIHLEDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly IReadOnlyList<(KDLKNOEDFHK, KDLKNOEDFHK)> FPHFINKBDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int KKJBBELIPAB;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool FOPNCONIKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x6104370", Offset = "0x6103770", VA = "0x186104370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public int AFFHALBAOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x8C5130", Offset = "0x8C4530", VA = "0x1808C5130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public IEnumerable<GameObject> COCKFIOABFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x886CF0", Offset = "0x8860F0", VA = "0x180886CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public IEnumerable<(KDLKNOEDFHK src, KDLKNOEDFHK dst)> JGBHDDHFBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6104760", Offset = "0x6103B60", VA = "0x186104760")]
	public PFKKOPJFLDM(IEnumerable<MLCNMHOEFKC> KIOFBMLNCEC, IReadOnlyList<GameObject> GALIAMMCDCI, IReadOnlyList<int> BNKNIHLEDGJ, IReadOnlyList<(KDLKNOEDFHK src, KDLKNOEDFHK dst)> FPHFINKBDPO, int KKJBBELIPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x61043D0", Offset = "0x61037D0", VA = "0x1861043D0")]
	public (GameObject, int)[] LFDFOAPGICJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface OFPOBFBNBAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000152")]
	bool DAOGBPJNNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	bool LHCDLIEBPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	BGNHJBIPOEL PMNAAMNFFGI
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LLPPIFJCKHI JNHOOCODJIP();

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LLPPIFJCKHI ILCKDBCACCC(IEnumerable<PIKFEMDGCNE> ELECKCHAEHL, [In] JCNCEDDNMOO MNMJHCAMKGA);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PJCJJDBPNBJ BBCFOIMEPFJ(ByteString IJMNDPELMLI);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ALJJFMCBHFE NLJLGCHKIGA(ByteString PKBBOCAODJK, PIKFEMDGCNE AOGBEAODJPP, [In] JCNCEDDNMOO HLHDBKOELAL, AEHBDJOBPIL NGNAELFIBGE, bool PJCKDEMBJIE = true);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NHNFEGOLHAK();

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PFKKOPJFLDM EDFDIFPNABJ(IEnumerable<MLCNMHOEFKC> KIOFBMLNCEC);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class GJEMNMFBPMO
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface DCCELKIMLGJ
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action PEMAJNONMPF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action HKLDFDCEPBB;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct IGCNJDEPJCJ : BBACAAOCDGJ, IEquatable<IGCNJDEPJCJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public GEIFGNPODDN LDBFOCMCGPO;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x60FADF0", Offset = "0x60FA1F0", VA = "0x1860FADF0", Slot = "5")]
	public void BOEOGBDBLGM(FDAPLEOACLI MAACBPKBLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x60FAEA0", Offset = "0x60FA2A0", VA = "0x1860FAEA0", Slot = "4")]
	public void GOGJDIDOEDD(CIFLEGMAKNF FJHMPBLBMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x60FAED0", Offset = "0x60FA2D0", VA = "0x1860FAED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x818E50", Offset = "0x818250", VA = "0x180818E50", Slot = "6")]
	public bool Equals(IGCNJDEPJCJ JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x60FAE20", Offset = "0x60FA220", VA = "0x1860FAE20", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x890610", Offset = "0x88FA10", VA = "0x180890610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct KDLKNOEDFHK : IComparable<KDLKNOEDFHK>, IEquatable<KDLKNOEDFHK>, BBACAAOCDGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public const uint GELPOJNFFLO = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const uint LBCDINAOHCI = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly KDLKNOEDFHK INDMNNFEIGN;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private const int DAHBHKLIEGA = 24;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private const uint GODLDHLBEDP = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private const int MPKBGCJPHAH = 8;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private const uint JAEFKCDLNDP = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly uint KLMLFNDOPAB;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public uint DMJAALKOCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x7E2950", Offset = "0x7E1D50", VA = "0x1807E2950")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public uint BFBAIKCHJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x60FD350", Offset = "0x60FC750", VA = "0x1860FD350")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public uint GGCDCPOOPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x890610", Offset = "0x88FA10", VA = "0x180890610")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool FOPNCONIKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x60536A0", Offset = "0x6052AA0", VA = "0x1860536A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xD85170", Offset = "0xD84570", VA = "0x180D85170")]
	public static KDLKNOEDFHK PAJIDGGECGM(uint KLMLFNDOPAB)
	{
		return default(KDLKNOEDFHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x60FD4F0", Offset = "0x60FC8F0", VA = "0x1860FD4F0")]
	public KDLKNOEDFHK(int CFLCIDJGEPC, int NJMAGLLAPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x60FD4F0", Offset = "0x60FC8F0", VA = "0x1860FD4F0")]
	public KDLKNOEDFHK(uint CFLCIDJGEPC, int NJMAGLLAPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x60FD4F0", Offset = "0x60FC8F0", VA = "0x1860FD4F0")]
	public KDLKNOEDFHK(uint CFLCIDJGEPC, uint NJMAGLLAPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x890600", Offset = "0x88FA00", VA = "0x180890600")]
	private KDLKNOEDFHK(uint KLMLFNDOPAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x175BF00", Offset = "0x175B300", VA = "0x18175BF00")]
	public static bool AODPLFIFGHC(KDLKNOEDFHK OJBODDLNJNK, KDLKNOEDFHK BLEBDLHLENH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x60FD450", Offset = "0x60FC850", VA = "0x1860FD450")]
	public static bool OFGNAAAHKLD(KDLKNOEDFHK OJBODDLNJNK, KDLKNOEDFHK BLEBDLHLENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x818E50", Offset = "0x818250", VA = "0x180818E50", Slot = "5")]
	public bool Equals(KDLKNOEDFHK NONJEEALACK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x60FD370", Offset = "0x60FC770", VA = "0x1860FD370", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x214D440", Offset = "0x214C840", VA = "0x18214D440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x60FD460", Offset = "0x60FC860", VA = "0x1860FD460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x60FD3F0", Offset = "0x60FC7F0", VA = "0x1860FD3F0", Slot = "6")]
	public void GOGJDIDOEDD(CIFLEGMAKNF FJHMPBLBMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x60FD2F0", Offset = "0x60FC6F0", VA = "0x1860FD2F0", Slot = "7")]
	public void BOEOGBDBLGM(FDAPLEOACLI MAACBPKBLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x60FD360", Offset = "0x60FC760", VA = "0x1860FD360", Slot = "4")]
	public int CompareTo(KDLKNOEDFHK JLCJEDAFKJL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct MLCNMHOEFKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Guid EFNPBHMDENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public string JOJBJEEFDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Vector3 BCGGHPIMKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Quaternion GIJALKLADPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Vector3 GLDPLANNJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public int IMGCDJAMONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Dictionary<string, object> LALAKJLPIGH;

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x61022A0", Offset = "0x61016A0", VA = "0x1861022A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6102110", Offset = "0x6101510", VA = "0x186102110")]
	private static string ACPFDOKBBGB(Dictionary<string, object> CNKEMCPDLKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public enum OCGNBHAEHKG
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public static class DAFCALFNKPL
{
	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x55C5310", Offset = "0x55C4710", VA = "0x1855C5310")]
	public static bool CKACNEOJGEK(this OCGNBHAEHKG KHENBEDBKDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[Flags]
public enum JOFPCNGJEKJ
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	AdditivePhases = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface ALJJFMCBHFE : BGNHJBIPOEL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000159")]
	AEHBDJOBPIL COIIPGNJBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENCHDBDKILG();

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JFBLNKBKBPN();
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface BGNHJBIPOEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	IEnumerable<MLCNMHOEFKC> DEKMPNNGBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	PFKKOPJFLDM JOEHCHOIOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	LocalId LNENLFKLNEN
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	EIINKJOJCJG EHMFPPKDJMA
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GMCNCCAGNOA(JOFPCNGJEKJ OHHNIDPDFLH);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public interface AEHBDJOBPIL
{
	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDJLNFIIGGE(Guid CFACMKCEEBG, [Out] Guid GDDIIAFGFJC);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface PJCJJDBPNBJ : BGNHJBIPOEL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[Flags]
public enum HENLMOMDGPI
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public interface LLPPIFJCKHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	EIINKJOJCJG MMDAMAHHELC
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString FJAOMEMEKGE();
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public enum EDCNIIBAPCF
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public delegate bool MLLCKNBBBOO(LEFIJANJEIE GJPKDNBFIAA, [In] BONMCOLIMCE PAHKKNONPEO);
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public delegate bool MPMIAFIDCAF<T>(LEFIJANJEIE GJPKDNBFIAA, [In] T PAHKKNONPEO);
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface DCHGDCOEECC
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAIKDCNGOPG(LFNJFOCLDOK OBPHOMEOEEI, Type MPMEGIPMKCE, MLLCKNBBBOO DOLPMPCMLKD);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KPEJJOACEBI(LFNJFOCLDOK OBPHOMEOEEI, [Out] MLLCKNBBBOO DOLPMPCMLKD);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class IDFDEFHLFDK
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class LFJCLPGBHKB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public MPMIAFIDCAF<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public LFJCLPGBHKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x3C11FA0", Offset = "0x3C113A0", VA = "0x183C11FA0")]
		internal bool AMKIKAMNDGJ(LEFIJANJEIE pendingList, [In] BONMCOLIMCE value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x263DF10", Offset = "0x263D310", VA = "0x18263DF10")]
	public static void OAIKDCNGOPG<T>(this DCHGDCOEECC AMNMACHIMML, LFNJFOCLDOK OBPHOMEOEEI, MPMIAFIDCAF<T> DOLPMPCMLKD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x60FAC50", Offset = "0x60FA050", VA = "0x1860FAC50")]
	public static bool LGFGCPONJIH(this DCHGDCOEECC AMNMACHIMML, LEFIJANJEIE GJPKDNBFIAA, LFNJFOCLDOK OBPHOMEOEEI, [In] BONMCOLIMCE PAHKKNONPEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface OJIHOOGCELK
{
	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	uint LIDADEKOHJI
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface LEFIJANJEIE
{
	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNDJFHLCNNP(KDLKNOEDFHK IKKDLPGKCFN, LFNJFOCLDOK OBPHOMEOEEI, ReadOnlySpan<byte> IBHLJFJBPLC, ReadOnlySpan<byte> ANJLIHAGPBC);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CBOFEAHJCNE(KDLKNOEDFHK IKKDLPGKCFN, LFNJFOCLDOK OBPHOMEOEEI);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NGNDAJCJKFB(KDLKNOEDFHK IKKDLPGKCFN, LFNJFOCLDOK OBPHOMEOEEI, ReadOnlySpan<byte> ANJLIHAGPBC);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ECFJKNDGMHN(KDLKNOEDFHK IKKDLPGKCFN, LFNJFOCLDOK OBPHOMEOEEI, Span<byte> IBHLJFJBPLC, Span<byte> ANJLIHAGPBC);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class IOHGAOENDND
{
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x26501A0", Offset = "0x264F5A0", VA = "0x1826501A0")]
	public static bool ECFJKNDGMHN<T>(this LEFIJANJEIE EJJLMOOGOGN, KDLKNOEDFHK IKKDLPGKCFN, LFNJFOCLDOK OBPHOMEOEEI, [Out] T IBHLJFJBPLC, [Out] T ANJLIHAGPBC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x2650350", Offset = "0x264F750", VA = "0x182650350")]
	public static bool NGNDAJCJKFB<T>(this LEFIJANJEIE EJJLMOOGOGN, KDLKNOEDFHK IKKDLPGKCFN, LFNJFOCLDOK OBPHOMEOEEI, T ANJLIHAGPBC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public enum BMJDEGPGLOO
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface DDKKPCJCKMB
{
	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBALJHAENKC(ICAGMHNMFKH GDMGHBDKKDG, ReadOnlySpan<byte> JFKHFDHADBL);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DPFOCPJCFCD(uint AAEPHJHJCKN, ReadOnlySpan<byte> JFKHFDHADBL);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface AEMCIDKIBGH
{
	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ICAGMHNMFKH AFFNOGACKAC(ReadOnlySpan<byte> JFKHFDHADBL);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface ABECIHIGANA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMCBLPKGLPP(ICAGMHNMFKH CONEAMPCFEL, ReadOnlySpan<byte> JFKHFDHADBL);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDOANALKEMB(ReadOnlySpan<ICAGMHNMFKH> DIMCKNJFHPM);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct FCIIMJMMPBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public ICAGMHNMFKH GDMGHBDKKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public ReadOnlyMemory<byte> JFKHFDHADBL;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct ICAGMHNMFKH
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static ICAGMHNMFKH CDPABNPGHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public uint CFLCIDJGEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public int NFOEMLAKAIA;

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0xA31A30", Offset = "0xA30E30", VA = "0x180A31A30")]
	public ICAGMHNMFKH(uint CFLCIDJGEPC, int NFOEMLAKAIA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x60FAA50", Offset = "0x60F9E50", VA = "0x1860FAA50")]
	public static bool AODPLFIFGHC([In] ICAGMHNMFKH KKNFIGGNDFK, [In] ICAGMHNMFKH PPBIBECNBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x60FAA70", Offset = "0x60F9E70", VA = "0x1860FAA70", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x60FAB20", Offset = "0x60F9F20", VA = "0x1860FAB20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x60FAB60", Offset = "0x60F9F60", VA = "0x1860FAB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x60FAB50", Offset = "0x60F9F50", VA = "0x1860FAB50")]
	public void OEGHLAHCHIH([Out] uint CFLCIDJGEPC, [Out] int NFOEMLAKAIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[NBLGEMLEKLJ(BLCHILNGIEA.OMRoom)]
public interface BCKKJDFLNIM : EHFJGICFFIO<BCKKJDFLNIM>
{
	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBIKFGCAMJG(LFNJFOCLDOK NONJEEALACK, [Out] BBNKJNAODON PGAFLLFBLMM);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public static class NCJFANEABJM
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public interface BBNKJNAODON
{
	[Cpp2IlInjected.Token(Token = "0x17000160")]
	Type MAJCGDCLGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOEOGBDBLGM(FDAPLEOACLI MAACBPKBLAG, Span<byte> GOOANMNBGEP);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GOGJDIDOEDD(CIFLEGMAKNF FJHMPBLBMAF, ReadOnlySpan<byte> GDMGHBDKKDG);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class DPAEAFCIKMP
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public struct BICIHJMEDHB : ISystemStateComponentData, IComponentData, IEquatable<BICIHJMEDHB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public float3 BJMFCKCLPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 LDICJNCABBI;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x60F5430", Offset = "0x60F4830", VA = "0x1860F5430", Slot = "4")]
	public bool Equals(BICIHJMEDHB JLCJEDAFKJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface PBPPKPBKJOE
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MONODIOLHJL DNNNGGHBOKG(int JDDFBAGKFLF);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int JHKKJCKPING(MONODIOLHJL JNCJNMOEDHH);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface AJFLHODKOIA
{
	[Cpp2IlInjected.Token(Token = "0x17000161")]
	IEnumerable<BIHEBKPBNLD> HKAFFLJABEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AHEKGPFLKAG(int JDDFBAGKFLF, [Out] BIHEBKPBNLD PGAFLLFBLMM);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface BEGLDCJBJPP
{
	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int EMMBDHJKCGF(int JDDFBAGKFLF);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface LCNELPNGBFM
{
	[Cpp2IlInjected.Token(Token = "0x17000162")]
	List<(MONODIOLHJL nameHash, JCHDDMHEBNK stableTypeHash, Type type)> HKPLHAAGMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public class MCHCGHGHNGD
{
	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public MCHCGHGHNGD()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
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
