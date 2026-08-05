using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x61638A0", Offset = "0x6162CA0", VA = "0x1861638A0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class AMHNMHDOKOB<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] NAPJGGKBGKJ;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x21F4D50", Offset = "0x21F4150", VA = "0x1821F4D50")]
	public static void FCKGPCBEPJG<TField>(int AHDNEIKOMIB, string GFBABMFGHOJ, MANIBFFNCCC EILCJNIEOFB, [Out] KBPPACLBKHK<TField> PLNALAIILFK) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x21F4A50", Offset = "0x21F3E50", VA = "0x1821F4A50")]
	public static void AJODONGOFMA<TField>(int AHDNEIKOMIB, string GFBABMFGHOJ, [Out] ONAGJBKEBCK<TField> GHNNEBBEGEC) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class LFAGDCDKEMA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x61640D0", Offset = "0x61634D0", VA = "0x1861640D0")]
	public static FieldInfo[] CAAKEHDEMBF(Type FICJMFBEBIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class NAIILPLDHJJ<View, Data> : PEPLKLBPNAK where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType NCPKANMPAAB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type LNGKFOFBJCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3E80040", Offset = "0x3E7F440", VA = "0x183E80040", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int KFABFNDPHCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3E82A70", Offset = "0x3E81E70", VA = "0x183E82A70", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3E81FC0", Offset = "0x3E813C0", VA = "0x183E81FC0")]
	public Data MCEJJBDHGHG(Entity JPDMAMIIECO)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View ICBDCDNKIIB(Entity JPDMAMIIECO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x25C6AF0", Offset = "0x25C5EF0", VA = "0x1825C6AF0", Slot = "14")]
	public override T ICBDCDNKIIB<T>(Entity JPDMAMIIECO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
	protected NAIILPLDHJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class PEPLKLBPNAK : MANIBFFNCCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle ECCABBCHGBG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager LHMCMOFKAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1271A30", Offset = "0x1270E30", VA = "0x181271A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type LNGKFOFBJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int KFABFNDPHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type EBBFNIDCHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A3190", Offset = "0x9A2590", VA = "0x1809A3190", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int DJHDJAMLMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x61648A0", Offset = "0x6163CA0", VA = "0x1861648A0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private NEKAIANIFDN[] OIBILMCOOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2177470", Offset = "0x2176870", VA = "0x182177470", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual NEKAIANIFDN[] ELKOJPELCCI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6164910", Offset = "0x6163D10", VA = "0x186164910", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6164A90", Offset = "0x6163E90", VA = "0x186164A90")]
	public void OBMDJKKOMOC(EntityManager NIHDJFAPFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T ICBDCDNKIIB<T>(Entity JPDMAMIIECO) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x61649A0", Offset = "0x6163DA0", VA = "0x1861649A0", Slot = "8")]
	public (uint, uint) NHOPECANBOE(Entity JPDMAMIIECO)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x61647B0", Offset = "0x6163BB0", VA = "0x1861647B0", Slot = "9")]
	public bool EDIOKDKMHKM(Entity JPDMAMIIECO, (uint order, uint change) MCCNLGBAILL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	protected PEPLKLBPNAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FJDJFJLEEHP
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KHLOJJPFJNP : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	DBPFIKIDBDF CDMKGGCMLPA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CGHNBNCFMIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IIGLGIHGCJH(Entity JPDMAMIIECO, object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NMIHNHEGLKL(Entity JPDMAMIIECO, object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JDMPGFMPOCD(Entity JPDMAMIIECO);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JKDKOFFCOFF(Entity JPDMAMIIECO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AFFPCCMANCH<TComponentData, TValue> : MHOJMDOLOKO<TValue>, IDisposable where TComponentData : struct, KHLOJJPFJNP
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class MBBCPKKLECK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private List<(object token, TValue value)> PHHAAPDMADG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int EKCLJKKLOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x30D6B80", Offset = "0x30D5F80", VA = "0x1830D6B80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3DAF890", Offset = "0x3DAEC90", VA = "0x183DAF890")]
		public bool BNGEIBFGGHH([Out] TValue ANJCCKHBJJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3DAF7E0", Offset = "0x3DAEBE0", VA = "0x183DAF7E0")]
		public void AFPNFDHLNMK(object BDHKJODLPCL, TValue ANJCCKHBJJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3DAFA60", Offset = "0x3DAEE60", VA = "0x183DAFA60")]
		public bool JJHPGEAJNEC(object BDHKJODLPCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3DAF980", Offset = "0x3DAED80", VA = "0x183DAF980")]
		public int FEBGCPPIJOA(object BDHKJODLPCL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3DAFAE0", Offset = "0x3DAEEE0", VA = "0x183DAFAE0")]
		public MBBCPKKLECK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Stack<MBBCPKKLECK> PPONKBBAMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private GJPKKCKLNIE<DBPFIKIDBDF, MBBCPKKLECK> COMGBIJFELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityManager NIHDJFAPFPF;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x36D03A0", Offset = "0x36CF7A0", VA = "0x1836D03A0")]
	public AFFPCCMANCH(EntityManager NIHDJFAPFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x36CFD90", Offset = "0x36CF190", VA = "0x1836CFD90", Slot = "4")]
	public void IIGLGIHGCJH(Entity JPDMAMIIECO, object BDHKJODLPCL, TValue ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x36D0140", Offset = "0x36CF540", VA = "0x1836D0140", Slot = "5")]
	public bool NMIHNHEGLKL(Entity JPDMAMIIECO, object BDHKJODLPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x36CFC50", Offset = "0x36CF050", VA = "0x1836CFC50", Slot = "6")]
	public bool BNGEIBFGGHH(Entity JPDMAMIIECO, [Out] TValue ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x36CFD50", Offset = "0x36CF150", VA = "0x1836CFD50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x36CFFC0", Offset = "0x36CF3C0", VA = "0x1836CFFC0")]
	private void LMPEFGNKAGG(MBBCPKKLECK AFHNGPKGKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x36D02E0", Offset = "0x36CF6E0", VA = "0x1836D02E0")]
	private bool OFHBHJAHOPA(Entity JPDMAMIIECO, [Out] DBPFIKIDBDF PPOPFLAHPIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x36D0050", Offset = "0x36CF450", VA = "0x1836D0050")]
	private void MDNMNKIBEIA(Entity JPDMAMIIECO, DBPFIKIDBDF PPOPFLAHPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x36CFD70", Offset = "0x36CF170", VA = "0x1836CFD70")]
	private bool IDEPPOEGLJA(DBPFIKIDBDF PPOPFLAHPIC, [Out] MBBCPKKLECK AFHNGPKGKNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x36CFED0", Offset = "0x36CF2D0", VA = "0x1836CFED0")]
	private MBBCPKKLECK KJHKDICLDAI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MHOJMDOLOKO<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIGLGIHGCJH(Entity JPDMAMIIECO, object BDHKJODLPCL, TValue ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NMIHNHEGLKL(Entity JPDMAMIIECO, object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BNGEIBFGGHH(Entity JPDMAMIIECO, [Out] TValue ANJCCKHBJJO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DBPFIKIDBDF : DAFDIAIBHKC, IEquatable<DBPFIKIDBDF>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly DBPFIKIDBDF FGEMAOBKBLF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[CreateProperty]
	public int BLAEHDOLMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88D230", Offset = "0x88C630", VA = "0x18088D230", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88D240", Offset = "0x88C640", VA = "0x18088D240", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[CreateProperty]
	public int IGAANOGKMJD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x21AF6D0", Offset = "0x21AEAD0", VA = "0x1821AF6D0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x550F1E0", Offset = "0x550E5E0", VA = "0x18550F1E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6163710", Offset = "0x6162B10", VA = "0x186163710", Slot = "8")]
	public bool Equals(DBPFIKIDBDF KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6163760", Offset = "0x6162B60", VA = "0x186163760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DIJCOAELLOD<THasTokensTag> : CGHNBNCFMIC, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OKECMMGLCGL ECHPFBNKINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Entity, DBPFIKIDBDF> MJBCPNHJPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly Stack<HashSet<object>> PPONKBBAMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private GJPKKCKLNIE<DBPFIKIDBDF, HashSet<object>> COMGBIJFELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EntityManager NIHDJFAPFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EntityCommandBufferSystem PBODHNEMJFE;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4FDE960", Offset = "0x4FDDD60", VA = "0x184FDE960")]
	public DIJCOAELLOD(EntityManager NIHDJFAPFPF, EntityCommandBufferSystem PBODHNEMJFE, OKECMMGLCGL BFMOKJAPLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4FDBBC0", Offset = "0x4FDAFC0", VA = "0x184FDBBC0", Slot = "4")]
	public bool IIGLGIHGCJH(Entity JPDMAMIIECO, object BDHKJODLPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4FDDF70", Offset = "0x4FDD370", VA = "0x184FDDF70", Slot = "5")]
	public bool NMIHNHEGLKL(Entity JPDMAMIIECO, object BDHKJODLPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4FDC500", Offset = "0x4FDB900", VA = "0x184FDC500", Slot = "6")]
	public bool JDMPGFMPOCD(Entity JPDMAMIIECO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4FDC6F0", Offset = "0x4FDBAF0", VA = "0x184FDC6F0", Slot = "9")]
	public bool JDMPGFMPOCD(DBPFIKIDBDF PPOPFLAHPIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4FDCA00", Offset = "0x4FDBE00", VA = "0x184FDCA00", Slot = "7")]
	public bool JKDKOFFCOFF(Entity JPDMAMIIECO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4FDB540", Offset = "0x4FDA940", VA = "0x184FDB540", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4FDD190", Offset = "0x4FDC590", VA = "0x184FDD190")]
	private void LMPEFGNKAGG(HashSet<object> AFHNGPKGKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4FDE590", Offset = "0x4FDD990", VA = "0x184FDE590")]
	private bool OFHBHJAHOPA(Entity JPDMAMIIECO, [Out] DBPFIKIDBDF PPOPFLAHPIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4FDD9A0", Offset = "0x4FDCDA0", VA = "0x184FDD9A0")]
	private bool NDOMJNFIIHO(Entity JPDMAMIIECO, [Out] DBPFIKIDBDF PPOPFLAHPIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4FDB3B0", Offset = "0x4FDA7B0", VA = "0x184FDB3B0")]
	private void DIMCPPIGOLD(Entity JPDMAMIIECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4FDC170", Offset = "0x4FDB570", VA = "0x184FDC170")]
	private void IIMBPAHJHJO(Entity JPDMAMIIECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4FDC300", Offset = "0x4FDB700", VA = "0x184FDC300")]
	private void IPJGPFIMDDO(Entity JPDMAMIIECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4FDD3C0", Offset = "0x4FDC7C0", VA = "0x184FDD3C0")]
	private void MDNMNKIBEIA(Entity JPDMAMIIECO, DBPFIKIDBDF PPOPFLAHPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4FDD5E0", Offset = "0x4FDC9E0", VA = "0x184FDD5E0")]
	private bool MOGDDAEAIPE(DBPFIKIDBDF PPOPFLAHPIC, [Out] HashSet<object> AFHNGPKGKNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4FDCEA0", Offset = "0x4FDC2A0", VA = "0x184FDCEA0")]
	private HashSet<object> KJHKDICLDAI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OFOLPGFMHCP
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct GAEKDACHHOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int JNLHAMBBADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int CBPPKGAPPDD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NEINPBOIFAF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x88D230", Offset = "0x88C630", VA = "0x18088D230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x21AF6D0", Offset = "0x21AEAD0", VA = "0x1821AF6D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x550F1E0", Offset = "0x550E5E0", VA = "0x18550F1E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int ICKOOHGBENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x88D230", Offset = "0x88C630", VA = "0x18088D230")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x88D240", Offset = "0x88C640", VA = "0x18088D240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int OHPJLJEBDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6163B90", Offset = "0x6162F90", VA = "0x186163B90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6163B80", Offset = "0x6162F80", VA = "0x186163B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA43A60", Offset = "0xA42E60", VA = "0x180A43A60")]
	private GAEKDACHHOG(int JNLHAMBBADE, int CBPPKGAPPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1D5BC70", Offset = "0x1D5B070", VA = "0x181D5BC70")]
	public static GAEKDACHHOG MBGCJJAHNJE(int JNLHAMBBADE, int CBPPKGAPPDD)
	{
		return default(GAEKDACHHOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6163BA0", Offset = "0x6162FA0", VA = "0x186163BA0")]
	public static GAEKDACHHOG ONLEFLDIALP(int PKHCCBJJMMB, int NDFFDHJCFBF)
	{
		return default(GAEKDACHHOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6163BB0", Offset = "0x6162FB0", VA = "0x186163BB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LOLCHMAAHKI : HLIKJLKLCHC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x614B260", Offset = "0x614A660", VA = "0x18614B260")]
	public float MECCLMMNDHG([In] float3 ANJCCKHBJJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x614B260", Offset = "0x614A660", VA = "0x18614B260", Slot = "4")]
	private float PDGFOFFJHFJ([In] float3 ANJCCKHBJJO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct IJGPGCCCBBC : HLIKJLKLCHC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x614E050", Offset = "0x614D450", VA = "0x18614E050")]
	public float MECCLMMNDHG([In] float3 ANJCCKHBJJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x614E050", Offset = "0x614D450", VA = "0x18614E050", Slot = "4")]
	private float PDGFOFFJHFJ([In] float3 ANJCCKHBJJO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct EMHNBJEKEBH : HLIKJLKLCHC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x19CC860", Offset = "0x19CBC60", VA = "0x1819CC860")]
	public float MECCLMMNDHG([In] float3 ANJCCKHBJJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x19CC860", Offset = "0x19CBC60", VA = "0x1819CC860", Slot = "4")]
	private float PDGFOFFJHFJ([In] float3 ANJCCKHBJJO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PHANFDOEIGP : HLIKJLKLCHC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1303C60", Offset = "0x1303060", VA = "0x181303C60")]
	public int MECCLMMNDHG([In] int3 ANJCCKHBJJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1303C60", Offset = "0x1303060", VA = "0x181303C60", Slot = "4")]
	private int POLDIBKDLJM([In] int3 ANJCCKHBJJO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct IBGMHEKCGFM : HLIKJLKLCHC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x614D320", Offset = "0x614C720", VA = "0x18614D320")]
	public int MECCLMMNDHG([In] int3 ANJCCKHBJJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x614D320", Offset = "0x614C720", VA = "0x18614D320", Slot = "4")]
	private int POLDIBKDLJM([In] int3 ANJCCKHBJJO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct AEHPJDIICAI : HLIKJLKLCHC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x15EF140", Offset = "0x15EE540", VA = "0x1815EF140")]
	public int MECCLMMNDHG([In] int3 ANJCCKHBJJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x15EF140", Offset = "0x15EE540", VA = "0x1815EF140", Slot = "4")]
	private int POLDIBKDLJM([In] int3 ANJCCKHBJJO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DGLOLPMECGH : HPEAGNKMHFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Type BDMOMFCHEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Type LNEKOAEINOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x61637B0", Offset = "0x6162BB0", VA = "0x1861637B0")]
	public DGLOLPMECGH(Type IDKFJKPHDAA, Type NECBEKMBEFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EKPJANNMBHI : HPEAGNKMHFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Type LNEKOAEINOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x606E970", Offset = "0x606DD70", VA = "0x18606E970")]
	public EKPJANNMBHI(Type NECBEKMBEFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OJGKPNOCHJG : HPEAGNKMHFJ
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7AF100", Offset = "0x7AE500", VA = "0x1807AF100")]
	public OJGKPNOCHJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class LDLCMKEMLOI<Data> : GFLJOJJBMJJ where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public virtual Data JPDBNDFGACM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3B65DA0", Offset = "0x3B651A0", VA = "0x183B65DA0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3B67C30", Offset = "0x3B67030", VA = "0x183B67C30", Slot = "8")]
	protected virtual bool EMJDLLGJOIL(ReadOnlySpan<Data> HAJDGKCJJAJ, IDIKLPDGNJN NOFCBEFCGBC, [Out] ReadOnlySpan<byte> PKHNCMEKMEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "9")]
	protected virtual bool DLMLPECBFGA(int MCCNLGBAILL, Span<Data> HAJDGKCJJAJ, [In] ReadOnlySpan<byte> PKHNCMEKMEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3B67B70", Offset = "0x3B66F70", VA = "0x183B67B70", Slot = "5")]
	internal sealed override bool EMJDLLGJOIL(Unity.Entities.Chunk BJMEJDHGOHJ, int AAMCKOOMKML, IDIKLPDGNJN NOFCBEFCGBC, [Out] ReadOnlySpan<byte> PKHNCMEKMEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3B672E0", Offset = "0x3B666E0", VA = "0x183B672E0", Slot = "6")]
	internal sealed override bool DLMLPECBFGA(int MCCNLGBAILL, Unity.Entities.Chunk BJMEJDHGOHJ, int AAMCKOOMKML, [In] ReadOnlySpan<byte> PKHNCMEKMEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x23A3540", Offset = "0x23A2940", VA = "0x1823A3540")]
	protected CCPEBEMMDKK<Protobuf> AONNGOGMCKA<Protobuf>(ReadOnlySpan<Data> HAJDGKCJJAJ) where Protobuf : IMessage, new()
	{
		return default(CCPEBEMMDKK<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x23A3590", Offset = "0x23A2990", VA = "0x1823A3590")]
	protected CKGOFOEDAEL<Protobuf> MGHNBPALNPD<Protobuf>(ReadOnlySpan<byte> PKHNCMEKMEL, ReadOnlySpan<Data> HAJDGKCJJAJ, Action<Protobuf> JJNOCPANMKJ) where Protobuf : IMessage, new()
	{
		return default(CKGOFOEDAEL<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
	protected LDLCMKEMLOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class GFLJOJJBMJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected abstract int IGAANOGKMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6163C40", Offset = "0x6163040", VA = "0x186163C40", Slot = "5")]
	internal virtual bool EMJDLLGJOIL(Unity.Entities.Chunk BJMEJDHGOHJ, int AAMCKOOMKML, IDIKLPDGNJN NOFCBEFCGBC, [Out] ReadOnlySpan<byte> PKHNCMEKMEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "6")]
	internal virtual bool DLMLPECBFGA(int MCCNLGBAILL, Unity.Entities.Chunk BJMEJDHGOHJ, int AAMCKOOMKML, [In] ReadOnlySpan<byte> PKHNCMEKMEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	protected GFLJOJJBMJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface POJEBDPAGJG
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class CCEFOGMOLEF : SystemBase, POJEBDPAGJG
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x61632F0", Offset = "0x61626F0", VA = "0x1861632F0")]
	public ComponentDataFromEntity BFPLGLOOHHJ(int MFEIPIKIEAE, bool ONEBMAJAAFH = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x61633B0", Offset = "0x61627B0", VA = "0x1861633B0")]
	public EntityExistenceLookupByEntity NLMJCMBCFHH()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x61633D0", Offset = "0x61627D0", VA = "0x1861633D0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7AF100", Offset = "0x7AE500", VA = "0x1807AF100")]
	protected CCEFOGMOLEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class OBABGDDLKAH : CCEFOGMOLEF
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x61644B0", Offset = "0x61638B0", VA = "0x1861644B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7AF100", Offset = "0x7AE500", VA = "0x1807AF100")]
	protected OBABGDDLKAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class HDKDAAJNFEI
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class MBCBDMGPEDM : AAFPEBPMNPJ
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x61642B0", Offset = "0x61636B0", VA = "0x1861642B0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase JPFGKEJJKHK();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6164210", Offset = "0x6163610", VA = "0x186164210")]
	protected ComponentSystemBase BKLLKAPGODH(params ComponentSystemBase[] CLHCLDFHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2748AB0", Offset = "0x2747EB0", VA = "0x182748AB0")]
	protected ComponentSystemBase BKLLKAPGODH<T>(params ComponentSystemBase[] CLHCLDFHFKO) where T : AAFPEBPMNPJ, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2748B40", Offset = "0x2747F40", VA = "0x182748B40")]
	protected ComponentSystemBase FFJDFPOAMAD<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2748B40", Offset = "0x2747F40", VA = "0x182748B40")]
	protected ComponentSystemBase FKLCLAKGGDE<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6164260", Offset = "0x6163660", VA = "0x186164260")]
	protected ComponentSystemBase OGECPHHCKPK(params SystemHandleUntyped[] CLHCLDFHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2748B80", Offset = "0x2747F80", VA = "0x182748B80")]
	protected ComponentSystemBase OGECPHHCKPK<T>(params SystemHandleUntyped[] CLHCLDFHFKO) where T : AAFPEBPMNPJ, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2748A50", Offset = "0x2747E50", VA = "0x182748A50")]
	protected SystemHandleUntyped AAMCKKPCJEP<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6162EE0", Offset = "0x61622E0", VA = "0x186162EE0")]
	protected MBCBDMGPEDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class AAFPEBPMNPJ : PNHNPNKJFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6162EB0", Offset = "0x61622B0", VA = "0x186162EB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6162EE0", Offset = "0x61622E0", VA = "0x186162EE0")]
	public AAFPEBPMNPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class PNHNPNKJFAP : ComponentSystemGroup, POJEBDPAGJG
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6162EE0", Offset = "0x61622E0", VA = "0x186162EE0")]
	protected PNHNPNKJFAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class FAMMPHOHCDI : EntityCommandBufferSystem, POJEBDPAGJG
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7AF100", Offset = "0x7AE500", VA = "0x1807AF100")]
	protected FAMMPHOHCDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HLIKJLKLCHC<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo MECCLMMNDHG([In] TFrom ANJCCKHBJJO);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface KAGIGHOABLE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNJBEKCFNPO(T ANJCCKHBJJO);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct MNDFDMGOBLO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> KMGEJEMFJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer EFCFEGIMPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ComponentTypes FOHLMOEEJKG;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6164300", Offset = "0x6163700", VA = "0x186164300", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct EIHBJFMEAPO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> KMGEJEMFJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer EFCFEGIMPCD;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6163800", Offset = "0x6162C00", VA = "0x186163800", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct MNLPJHHALGD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> KMGEJEMFJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer EFCFEGIMPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ComponentType IKEHJCJLCAI;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x61643F0", Offset = "0x61637F0", VA = "0x1861643F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct ONBADOGBEBG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<Entity> KMGEJEMFJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public NativeArray<T> ALPLHOOHPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EntityCommandBuffer EFCFEGIMPCD;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3FE2130", Offset = "0x3FE1530", VA = "0x183FE2130", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct IGEBEHJPOKG<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> KMGEJEMFJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<T> KOOGKOFEACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EntityCommandBuffer EFCFEGIMPCD;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct CBAIHPMMBDA<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> KMGEJEMFJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public T ANJCCKHBJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public EntityCommandBuffer EFCFEGIMPCD;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4833A50", Offset = "0x4832E50", VA = "0x184833A50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct GHFHLIOKKDL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, HLIKJLKLCHC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> FAOIILPLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<TTo> EHPLCFHDPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap HKJBPIINLDG;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct BINMCOPKIFH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity CPONBLONJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> FAOIILPLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[WriteOnly]
	public NativeArray<byte> EHPLCFHDPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int PFIBHENPKMO;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6163030", Offset = "0x6162430", VA = "0x186163030", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct LENEFBOEABM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IJBJABMPJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> FAOIILPLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[WriteOnly]
	public NativeList<T> CPKNMNIFOAN;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct FFOFBPLEKPF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, HLIKJLKLCHC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<TFrom> AIBDIDEGFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[WriteOnly]
	public NativeList<TTo> EHPLCFHDPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TMap HKJBPIINLDG;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct GMIJIKOGCEF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NECBEKMBEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<Entity> CFDGOIBKLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeArray<bool> OFHFFJPKCLD;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct CKKNKCDMOIE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NECBEKMBEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> CFDGOIBKLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeArray<bool> OFHFFJPKCLD;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4AFFFB0", Offset = "0x4AFF3B0", VA = "0x184AFFFB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct AENPMECBJLJ<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> FAOIILPLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> CPKNMNIFOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeParallelHashSet<T> DJGCKIJAAIG;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x36BBE70", Offset = "0x36BB270", VA = "0x1836BBE70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct FLINAPFBJNH<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : HLIKJLKLCHC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<TFrom> FAOIILPLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<TFrom> CPKNMNIFOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<TTo> DJGCKIJAAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TMap HKJBPIINLDG;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BurstCompile]
internal struct LEFOFHINAEG<T, TPredicate> : IJob where T : struct where TPredicate : struct, KAGIGHOABLE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<T> FAOIILPLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> LBLJMNMKCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> EAOAONLEKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TPredicate HKJBPIINLDG;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3B68720", Offset = "0x3B67B20", VA = "0x183B68720", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
internal struct PIPNMEHAKLB<T, TPredicate> : IJob where T : struct where TPredicate : struct, KAGIGHOABLE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> FAOIILPLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> CPKNMNIFOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate HKJBPIINLDG;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BurstCompile]
internal struct BMBPOGANDAJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity NECBEKMBEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> CFDGOIBKLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> GHMJEHHMAGN;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6163130", Offset = "0x6162530", VA = "0x186163130", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BurstCompile]
internal struct CELEPLELBCK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity NECBEKMBEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> CFDGOIBKLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> GHMJEHHMAGN;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x61633E0", Offset = "0x61627E0", VA = "0x1861633E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class BEPLECGOPLD
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class OHGGJNEOHGA
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x27DC280", Offset = "0x27DB680", VA = "0x1827DC280")]
	public static bool JBDFBAFPPMF<T>(this NativeArray<Entity> CFDGOIBKLDJ, EntityManager NIHDJFAPFPF, Allocator OLAJGHFDGHM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class PLGAOBNOOPM
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class MCGMEEICJPA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		public MCGMEEICJPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class OPGFBOIEMBL<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		public OPGFBOIEMBL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> JKJBIHLCODH;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6164BD0", Offset = "0x6163FD0", VA = "0x186164BD0")]
	public PLGAOBNOOPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class ONJOFNFIGFF
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class MGIMEEBMELM
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct JGABEBICPAN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct ICKAEACLLBH<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal JGABEBICPAN<TFrom> EMDODFFCGEF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator OLAJGHFDGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> KILNCFNEBFG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct LNIEGNOBAGB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct CABMNAEOCEM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal LNIEGNOBAGB<TFrom> EMDODFFCGEF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator OLAJGHFDGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> KILNCFNEBFG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct BJMHDAKKPKK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public struct DCLPOBNIMLC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal BJMHDAKKPKK<TFrom> EMDODFFCGEF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator OLAJGHFDGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> KILNCFNEBFG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct MKFOHHINMLD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct BKPGNGEPDFL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal MKFOHHINMLD<TFrom> EMDODFFCGEF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator OLAJGHFDGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> KILNCFNEBFG;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class KFLJJFADOAP
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class OHIOMAMCEIE
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x27DC590", Offset = "0x27DB990", VA = "0x1827DC590")]
	public static NativeList<T> AADNEENMCPJ<T>(this NativeList<T> PKPFNFBIBPM, Allocator OLAJGHFDGHM = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x27DC410", Offset = "0x27DB810", VA = "0x1827DC410")]
	public static NativeList<T> AADNEENMCPJ<T>(this NativeArray<T> PKPFNFBIBPM, Allocator OLAJGHFDGHM = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class MBKIIHKKIBE
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class FOBNDMJDNOF
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2670640", Offset = "0x266FA40", VA = "0x182670640")]
	[MGDCJEFAPMO]
	public static JobHandle HIEOGPBIDEC<T>(this EntityCommandBufferSystem PBODHNEMJFE, NativeArrayAsync<Entity> KMGEJEMFJBE, NativeArrayAsync<T> ALPLHOOHPEL, [Optional] JobHandle EMEGINGIMCG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2670A20", Offset = "0x266FE20", VA = "0x182670A20")]
	[MGDCJEFAPMO]
	public static JobHandle HIEOGPBIDEC<T>(this EntityCommandBufferSystem PBODHNEMJFE, NativeArrayAsync<Entity> KMGEJEMFJBE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x26707A0", Offset = "0x266FBA0", VA = "0x1826707A0")]
	[MGDCJEFAPMO]
	public static JobHandle HIEOGPBIDEC<T>(this EntityCommandBufferSystem PBODHNEMJFE, NativeArray<Entity> KMGEJEMFJBE, [Optional] JobHandle EMEGINGIMCG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6163A10", Offset = "0x6162E10", VA = "0x186163A10")]
	[MGDCJEFAPMO]
	public static JobHandle HIEOGPBIDEC(this EntityCommandBufferSystem PBODHNEMJFE, NativeArray<Entity> KMGEJEMFJBE, ComponentTypes FOHLMOEEJKG, [Optional] JobHandle EMEGINGIMCG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61638C0", Offset = "0x6162CC0", VA = "0x1861638C0")]
	[MGDCJEFAPMO]
	public static JobHandle HIEOGPBIDEC(this EntityCommandBufferSystem PBODHNEMJFE, EntityCommandBuffer EFCFEGIMPCD, NativeArray<Entity> KMGEJEMFJBE, ComponentTypes FOHLMOEEJKG, [Optional] JobHandle EMEGINGIMCG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class ADNLHMICHNE
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8810", Offset = "0x2CE7C10", VA = "0x182CE8810")]
	[MGDCJEFAPMO]
	public static JobHandle FIABNMFFOGJ<T>(this EntityCommandBufferSystem PBODHNEMJFE, EntityCommandBuffer EFCFEGIMPCD, EntityQuery PFEJNAONJGE, T ANJCCKHBJJO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class JHIMPJKFPEM
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6163F40", Offset = "0x6163340", VA = "0x186163F40")]
	[MGDCJEFAPMO]
	public static JobHandle POMJLKOLHED(this EntityCommandBufferSystem PBODHNEMJFE, NativeList<Entity> KMGEJEMFJBE, [Optional] JobHandle EMEGINGIMCG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6163E40", Offset = "0x6163240", VA = "0x186163E40")]
	[MGDCJEFAPMO]
	public static JobHandle POMJLKOLHED(this EntityCommandBufferSystem PBODHNEMJFE, NativeArrayAsync<Entity> KMGEJEMFJBE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class ENFIAFAJALH
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2547BA0", Offset = "0x2546FA0", VA = "0x182547BA0")]
	public static void PKEEBIPOCBM<T>(this EntityCommandBufferSystem PBODHNEMJFE, EntityQuery PFEJNAONJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2547AE0", Offset = "0x2546EE0", VA = "0x182547AE0")]
	[MGDCJEFAPMO]
	public static JobHandle FMFMACHLPFN<T>(this EntityCommandBufferSystem PBODHNEMJFE, NativeListAsync<Entity> KMGEJEMFJBE, [Optional] JobHandle EMEGINGIMCG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2547950", Offset = "0x2546D50", VA = "0x182547950")]
	[MGDCJEFAPMO]
	public static JobHandle FMFMACHLPFN<T>(this EntityCommandBufferSystem PBODHNEMJFE, NativeArrayAsync<Entity> KMGEJEMFJBE, [Optional] JobHandle EMEGINGIMCG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class DFKBAJCPPHK
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x251C820", Offset = "0x251BC20", VA = "0x18251C820")]
	[MGDCJEFAPMO]
	public static JobHandle HBPBGGLJONF<T>(this EntityCommandBufferSystem PBODHNEMJFE, NativeArray<Entity> KMGEJEMFJBE, NativeArray<T> ALPLHOOHPEL, JobHandle EMEGINGIMCG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class NCBOHHNFCKG
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x27B5C60", Offset = "0x27B5060", VA = "0x1827B5C60")]
	[MGDCJEFAPMO]
	public static JobHandle EBAAAKFGKFO<T>(this EntityCommandBufferSystem PBODHNEMJFE, NativeArray<Entity> KMGEJEMFJBE, T ANJCCKHBJJO, [Optional] JobHandle EMEGINGIMCG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x27B5D40", Offset = "0x27B5140", VA = "0x1827B5D40")]
	[MGDCJEFAPMO]
	public static JobHandle EBAAAKFGKFO<T>(this EntityCommandBufferSystem PBODHNEMJFE, EntityCommandBuffer EFCFEGIMPCD, NativeArray<Entity> KMGEJEMFJBE, T ANJCCKHBJJO, [Optional] JobHandle EMEGINGIMCG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class MDFCKMEIMID
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2749F40", Offset = "0x2749340", VA = "0x182749F40")]
	public static NativeList<T> AADNEENMCPJ<T>(NativeList<T> PKPFNFBIBPM, Allocator OLAJGHFDGHM) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class IBOLPHNPIAJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x269EF90", Offset = "0x269E390", VA = "0x18269EF90")]
	public static NativeArray<T> BFOOBJKIKJN<T>(this NativeList<Entity> PKPFNFBIBPM, EntityManager NIHDJFAPFPF, Allocator OLAJGHFDGHM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x269EC10", Offset = "0x269E010", VA = "0x18269EC10")]
	public static NativeArray<T> BFOOBJKIKJN<T>(this NativeArray<Entity> PKPFNFBIBPM, EntityManager NIHDJFAPFPF, Allocator OLAJGHFDGHM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6163C50", Offset = "0x6163050", VA = "0x186163C50")]
	public static NativeArray<Entity> IDMPACONGAK(this NativeArray<Entity> PKPFNFBIBPM, EntityManager NIHDJFAPFPF, ComponentType IKEHJCJLCAI, Allocator OLAJGHFDGHM = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x269F200", Offset = "0x269E600", VA = "0x18269F200")]
	public static NativeArray<T> JGNJCBOAMOH<T>(this NativeArray<Entity> PKPFNFBIBPM, EntityManager NIHDJFAPFPF, Allocator OLAJGHFDGHM = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class FEKGJPMKLDK
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct GNPPNMHKIID<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct ADGMOLGNMLC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public GNPPNMHKIID<TFrom> KILNCFNEBFG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator OLAJGHFDGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> FAOIILPLJKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct NJINMAKPLEF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct GKKCOEDEDAH<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public NJINMAKPLEF<TFrom> KILNCFNEBFG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator OLAJGHFDGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> FAOIILPLJKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct PBIPPCHOLOK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct LGIIAPBLECO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public PBIPPCHOLOK<TFrom> KILNCFNEBFG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator OLAJGHFDGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> FAOIILPLJKJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class IBCCNJEOCEL
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class DNKMGAMFIME
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct BFIPLGIFJGN : HLIKJLKLCHC<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> MGMPEDFABNO;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6163020", Offset = "0x6162420", VA = "0x186163020")]
		[BurstCompatible]
		public Entity MECCLMMNDHG([In] Entity ANJCCKHBJJO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6163020", Offset = "0x6162420", VA = "0x186163020", Slot = "4")]
		private Entity HICGHEGGBCG([In] Entity ANJCCKHBJJO)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class BMOOJFIINPC
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct LCJDOKFDLDP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator OLAJGHFDGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<Entity> LBLJMNMKCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeArray<T> FAOIILPLJKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct FDAFEJEINDL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator OLAJGHFDGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<Entity> LBLJMNMKCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArray<T> FAOIILPLJKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct FAAMKIAACEK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator OLAJGHFDGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<Entity> LBLJMNMKCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NativeArrayAsync<T> FAOIILPLJKJ;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2FB0A40", Offset = "0x2FAFE40", VA = "0x182FB0A40")]
		public NativeListAsync<Entity> DNJBEKCFNPO<TPredicate>() where TPredicate : struct, KAGIGHOABLE<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x24716B0", Offset = "0x2470AB0", VA = "0x1824716B0")]
	public static FAAMKIAACEK<T> JLMJLCNNNCH<T>(this NativeArrayAsync<Entity> CFDGOIBKLDJ, NativeArrayAsync<T> PKPFNFBIBPM, Allocator OLAJGHFDGHM = Allocator.TempJob) where T : struct
	{
		return default(FAAMKIAACEK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class NPLMFNPCNDD
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x27BD990", Offset = "0x27BCD90", VA = "0x1827BD990")]
	public static NativeListAsync<Entity> MDGBFPDPGLI<T, TPredicate>(this NativeArrayAsync<T> PKPFNFBIBPM, NativeArrayAsync<Entity> CFDGOIBKLDJ, Allocator OLAJGHFDGHM = Allocator.TempJob) where T : struct where TPredicate : struct, KAGIGHOABLE<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x27BDA50", Offset = "0x27BCE50", VA = "0x1827BDA50")]
	private static NativeListAsync<Entity> MFFLOFNIMGP<T, TPredicate>(NativeArrayAsync<T> JOBHCDOBEHL, NativeArrayAsync<Entity> CFDGOIBKLDJ, int FLCGLAMBOBC, Allocator OLAJGHFDGHM) where T : struct where TPredicate : struct, KAGIGHOABLE<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class IJPCIHNDMOL
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct GCCGLKFKBFA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Allocator OLAJGHFDGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NativeArray<T> FAOIILPLJKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct AFJCDLFBFKJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Allocator OLAJGHFDGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NativeList<T> FAOIILPLJKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct FPFMJKAABCN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Allocator OLAJGHFDGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NativeArrayAsync<T> FAOIILPLJKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct OMBDJNNMIMJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Allocator OLAJGHFDGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NativeListAsync<T> FAOIILPLJKJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class BHNFJJENAJF
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class IMDBBLDECJJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x26B9540", Offset = "0x26B8940", VA = "0x1826B9540")]
	public static NativeList<Entity> PJBGICJGLMH<T>(this NativeArray<Entity> CFDGOIBKLDJ, EntityManager NIHDJFAPFPF, Allocator OLAJGHFDGHM = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class LDGHBFJKHHJ
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class HJLPCBJJOLD
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct PGCNLIPGKKD<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<TSrc> MGNOJHKHDPK;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1D42690", Offset = "0x1D41A90", VA = "0x181D42690")]
		public PGCNLIPGKKD(NativeArray<TSrc> MGNOJHKHDPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700")]
		public HIOKEJEIDAE<TSrc, TValue> OFAKPKKKPIK<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(HIOKEJEIDAE<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct HIOKEJEIDAE<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly NativeArray<TSrc> MGNOJHKHDPK;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1D42690", Offset = "0x1D41A90", VA = "0x181D42690")]
		public HIOKEJEIDAE(NativeArray<TSrc> MGNOJHKHDPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700")]
		public HPMLMPDBMJK<TSrc, TValue, TSelector> GLNMOMAHILP<TSelector>() where TSelector : struct, HLIKJLKLCHC<TSrc, TValue>
		{
			return default(HPMLMPDBMJK<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct HPMLMPDBMJK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, HLIKJLKLCHC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<TSrc> MGNOJHKHDPK;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1D42690", Offset = "0x1D41A90", VA = "0x181D42690")]
		public HPMLMPDBMJK(NativeArray<TSrc> MGNOJHKHDPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3782260", Offset = "0x3781660", VA = "0x183782260")]
		public PDFHLJCOKKA<TSrc, TValue, TSelector> BKLLKAPGODH()
		{
			return default(PDFHLJCOKKA<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct KLCHOPFDHLM<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, HLIKJLKLCHC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<TSrc> MGNOJHKHDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TSelector NJAEFHOOELG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int AHDNEIKOMIB;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TValue PPPEJOJKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2DA0", Offset = "0x3AD21A0", VA = "0x183AD2DA0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int BLAEHDOLMPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x9AB360", Offset = "0x9AA760", VA = "0x1809AB360")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int BGGPFCEBPPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x1D39FD0", Offset = "0x1D393D0", VA = "0x181D39FD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2E40", Offset = "0x3AD2240", VA = "0x183AD2E40")]
		public KLCHOPFDHLM(NativeArray<TSrc> MGNOJHKHDPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2E30", Offset = "0x3AD2230", VA = "0x183AD2E30")]
		public bool PPMDMGNMJBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2CC0", Offset = "0x3AD20C0", VA = "0x183AD2CC0")]
		private TSrc AAFGDJAPIGG(int FPJGJJLGENP)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct PDFHLJCOKKA<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, HLIKJLKLCHC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private KLCHOPFDHLM<TSrc, TValue, TSelector> CPMPLPGKMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TValue HNIEADLPOEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int ACGCEBPHGCG;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public GAEKDACHHOG PMNJNKELPKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x4087FF0", Offset = "0x40873F0", VA = "0x184087FF0")]
			get
			{
				return default(GAEKDACHHOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public TValue AIANHAMCOAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x79E7B0", Offset = "0x79DBB0", VA = "0x18079E7B0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (TValue value, GAEKDACHHOG range) PPPEJOJKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x4087F10", Offset = "0x4087310", VA = "0x184087F10")]
			get
			{
				return default((TValue, GAEKDACHHOG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4088170", Offset = "0x4087570", VA = "0x184088170")]
		public PDFHLJCOKKA(NativeArray<TSrc> MGNOJHKHDPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3827810", Offset = "0x3826C10", VA = "0x183827810")]
		public PDFHLJCOKKA<TSrc, TValue, TSelector> JLFJDPHFECC()
		{
			return default(PDFHLJCOKKA<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4088030", Offset = "0x4087430", VA = "0x184088030")]
		public bool PPMDMGNMJBL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x268A5E0", Offset = "0x26899E0", VA = "0x18268A5E0")]
	public static PGCNLIPGKKD<T> OEMOKOMPAFH<T>(this NativeList<T> PHHAAPDMADG) where T : struct
	{
		return default(PGCNLIPGKKD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700")]
	public static PGCNLIPGKKD<T> OEMOKOMPAFH<T>(this NativeArray<T> MGNOJHKHDPK) where T : struct
	{
		return default(PGCNLIPGKKD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class KDDNHNCCGON
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct BMBAKNGFMNL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NativeArray<T>.ReadOnly MGNOJHKHDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int ACGCEBPHGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int CINFHKFPIHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private T HNIEADLPOEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private T LGINMOADOIB;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public GAEKDACHHOG PMNJNKELPKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x382A490", Offset = "0x3829890", VA = "0x18382A490")]
			get
			{
				return default(GAEKDACHHOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T AIANHAMCOAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x333EF80", Offset = "0x333E380", VA = "0x18333EF80")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, GAEKDACHHOG) PPPEJOJKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x4746B50", Offset = "0x4745F50", VA = "0x184746B50")]
			get
			{
				return default((T, GAEKDACHHOG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x47470C0", Offset = "0x47464C0", VA = "0x1847470C0")]
		public BMBAKNGFMNL(NativeArray<T> MGNOJHKHDPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4746CD0", Offset = "0x47460D0", VA = "0x184746CD0")]
		public BMBAKNGFMNL<T> JLFJDPHFECC()
		{
			return default(BMBAKNGFMNL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4746D10", Offset = "0x4746110", VA = "0x184746D10")]
		public bool PPMDMGNMJBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2FA4C60", Offset = "0x2FA4060", VA = "0x182FA4C60")]
		public IJMADIFNAMB<T, TComparer> MCEEFAEBFDM<TComparer>([Optional] TComparer CJBBBKOHIIH) where TComparer : struct, IEqualityComparer<T>
		{
			return default(IJMADIFNAMB<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct IJMADIFNAMB<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly NativeArray<T>.ReadOnly MGNOJHKHDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int ACGCEBPHGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int CINFHKFPIHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private T HNIEADLPOEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private T LGINMOADOIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TComparer CJBBBKOHIIH;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public GAEKDACHHOG PMNJNKELPKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x382A490", Offset = "0x3829890", VA = "0x18382A490")]
			get
			{
				return default(GAEKDACHHOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T AIANHAMCOAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x333EF80", Offset = "0x333E380", VA = "0x18333EF80")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, GAEKDACHHOG range) PPPEJOJKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x382A3C0", Offset = "0x38297C0", VA = "0x18382A3C0")]
			get
			{
				return default((T, GAEKDACHHOG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x382A6C0", Offset = "0x3829AC0", VA = "0x18382A6C0")]
		public IJMADIFNAMB(NativeArray<T>.ReadOnly MGNOJHKHDPK, TComparer CJBBBKOHIIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x382A4A0", Offset = "0x38298A0", VA = "0x18382A4A0")]
		public IJMADIFNAMB<T, TComparer> JLFJDPHFECC()
		{
			return default(IJMADIFNAMB<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x382A4E0", Offset = "0x38298E0", VA = "0x18382A4E0")]
		public bool PPMDMGNMJBL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x27082F0", Offset = "0x27076F0", VA = "0x1827082F0")]
	public static BMBAKNGFMNL<T> BKLLKAPGODH<T>(this NativeArray<T> MGNOJHKHDPK) where T : struct
	{
		return default(BMBAKNGFMNL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface JCNBHGDKKEE
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class BEADGDMMDGI
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct CKGOFOEDAEL<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class LCCAPLGPOJH : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public CKGOFOEDAEL<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA1FB90", Offset = "0xA1EF90", VA = "0x180A1FB90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x3672E00", Offset = "0x3672200", VA = "0x183672E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public LCCAPLGPOJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3B64E80", Offset = "0x3B64280", VA = "0x183B64E80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3B65030", Offset = "0x3B64430", VA = "0x183B65030", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Action<Protobuf> JJNOCPANMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream EADAADALBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedInputStream EBCAAKMHNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Protobuf DDIFDMJCCFB;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly int BGGPFCEBPPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BDD90", Offset = "0x8BD190", VA = "0x1808BDD90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4AFFE60", Offset = "0x4AFF260", VA = "0x184AFFE60")]
	private CKGOFOEDAEL(byte[] DICNEFJIMOI, Action<Protobuf> JJNOCPANMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2FAA280", Offset = "0x2FA9680", VA = "0x182FAA280")]
	public static CKGOFOEDAEL<Protobuf> HDHFILGDDKG<Data>(ReadOnlySpan<byte> PKHNCMEKMEL, ReadOnlySpan<Data> HAJDGKCJJAJ, Action<Protobuf> JJNOCPANMKJ)
	{
		return default(CKGOFOEDAEL<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4AFFCD0", Offset = "0x4AFF0D0", VA = "0x184AFFCD0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4AFFD10", Offset = "0x4AFF110", VA = "0x184AFFD10", Slot = "4")]
	[IteratorStateMachine(typeof(CKGOFOEDAEL<>.LCCAPLGPOJH))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4AFFE00", Offset = "0x4AFF200", VA = "0x184AFFE00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct CCPEBEMMDKK<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] DICNEFJIMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Protobuf DDIFDMJCCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MemoryStream EADAADALBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CodedOutputStream JIPOHOLKLII;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4925F30", Offset = "0x4925330", VA = "0x184925F30")]
	private CCPEBEMMDKK(byte[] DICNEFJIMOI, [In] Protobuf DDIFDMJCCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4D50", Offset = "0x2FA4150", VA = "0x182FA4D50")]
	public static CCPEBEMMDKK<Protobuf> HDHFILGDDKG<T>(ReadOnlySpan<T> HAJDGKCJJAJ)
	{
		return default(CCPEBEMMDKK<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4925D40", Offset = "0x4925140", VA = "0x184925D40")]
	public void BPPKCNGIIME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4925EA0", Offset = "0x49252A0", VA = "0x184925EA0")]
	public ByteString KGKFMPEBGGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4925D70", Offset = "0x4925170", VA = "0x184925D70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct NBFCGEMNEJH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MemoryStream EADAADALBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CodedInputStream EBCAAKMHNLP;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6164470", Offset = "0x6163870", VA = "0x186164470", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct CBJEKGMACJD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly byte[] DICNEFJIMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MemoryStream EADAADALBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CodedOutputStream JIPOHOLKLII;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x61631C0", Offset = "0x61625C0", VA = "0x1861631C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class OOCOEPBIJAH
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate void IOKLJAHLBAJ<From, To>(From KILNCFNEBFG, To LHDFPPNLHJD, IDIKLPDGNJN NOFCBEFCGBC);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class NIFLKECIFEF<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static IOKLJAHLBAJ<From, To> KBELLFDJDAL;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public NIFLKECIFEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x61644E0", Offset = "0x61638E0", VA = "0x1861644E0")]
	static OOCOEPBIJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x27EA3E0", Offset = "0x27E97E0", VA = "0x1827EA3E0")]
	public static void ACKLGLNDLNM<T>(IOKLJAHLBAJ<T, T> HDIDOCLMLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x27EB230", Offset = "0x27EA630", VA = "0x1827EB230")]
	public static void ACKLGLNDLNM<From, To>(IOKLJAHLBAJ<From, To> HDIDOCLMLJL, IOKLJAHLBAJ<To, From> DLHPDAEGADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x27EA5C0", Offset = "0x27E99C0", VA = "0x1827EA5C0")]
	public static void ACKLGLNDLNM<From, To>(IOKLJAHLBAJ<From, To> KBELLFDJDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x27EEA80", Offset = "0x27EDE80", VA = "0x1827EEA80")]
	public static IOKLJAHLBAJ<From, To> IKOPDLOIDEH<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x27F4080", Offset = "0x27F3480", VA = "0x1827F4080")]
	public static void PCONIGIIJJM<From, To>(From KILNCFNEBFG, To LHDFPPNLHJD, IDIKLPDGNJN NOFCBEFCGBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class IDIKLPDGNJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> GBBHCPIBMMM;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1A81360", Offset = "0x1A80760", VA = "0x181A81360")]
	public IDIKLPDGNJN(NativeArray<EntityRemapUtility.EntityRemapInfo> GBBHCPIBMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6163E30", Offset = "0x6163230", VA = "0x186163E30")]
	public Entity ILNKFFMAGEB(Entity HEKLPNHIOGD)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class BBHMNONEHKF
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6162F90", Offset = "0x6162390", VA = "0x186162F90")]
	public static ulong BELMCPOLBIC(Type FICJMFBEBIN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6162F30", Offset = "0x6162330", VA = "0x186162F30")]
	public static ulong BELMCPOLBIC(string IDMAOPLCPGL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Flags]
public enum AFAGLFLOGBC
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[AttributeUsage(AttributeTargets.Class)]
public class DBENNAMPBAG : HPEAGNKMHFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7AF100", Offset = "0x7AE500", VA = "0x1807AF100")]
	public DBENNAMPBAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal static class COHHIPOLIFK
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6163470", Offset = "0x6162870", VA = "0x186163470")]
	private unsafe static Span<byte> ACMAPDIPKPP(Unity.Entities.Chunk* BJMEJDHGOHJ, int AAMCKOOMKML)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x24F4E60", Offset = "0x24F4260", VA = "0x1824F4E60")]
	public unsafe static Span<T> OFAFPGFNNJP<T>(Unity.Entities.Chunk* BJMEJDHGOHJ, int AAMCKOOMKML)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x24F4E30", Offset = "0x24F4230", VA = "0x1824F4E30")]
	public static Span<T> OFAFPGFNNJP<T>(this Unity.Entities.Chunk BJMEJDHGOHJ, int AAMCKOOMKML)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x61636B0", Offset = "0x6162AB0", VA = "0x1861636B0")]
	public unsafe static Span<Entity> MJAMEPJJOCN(Unity.Entities.Chunk* BJMEJDHGOHJ)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6163540", Offset = "0x6162940", VA = "0x186163540")]
	public unsafe static void BILLODBOEME(Unity.Entities.Chunk* BJMEJDHGOHJ, int AAMCKOOMKML)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class CEDJFJLKOPL
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public CEDJFJLKOPL()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
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
