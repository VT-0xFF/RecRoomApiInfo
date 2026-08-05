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
using Microsoft.Toolkit.HighPerformance.Helpers;
using Mono.Math;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Jobs;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class LPAPKIHIPMA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4AAC1B0", Offset = "0x4AAADB0", VA = "0x184AAC1B0")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> LHONPPKFIII(this ref Unity.Entities.Archetype FMENGPOHLND)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PLBKPLCFMBB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4AAC640", Offset = "0x4AAB240", VA = "0x184AAC640")]
	public static Span<int> NGPJIEGDOBI(this EntityArchetype FMENGPOHLND)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PEMNBFNDBJE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4AAC4A0", Offset = "0x4AAB0A0", VA = "0x184AAC4A0")]
	public static bool PDABALEFEIL(this Entity OCMABEPCGDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NBMOEFMGGKC
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct HFKOIILHCNK<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FNBEBFJCMMH : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public global::HFKOIILHCNK<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5ED000", Offset = "0x5EBC00", VA = "0x1805ED000", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3A55580", Offset = "0x3A54180", VA = "0x183A55580", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1EB44D0", Offset = "0x1EB30D0", VA = "0x181EB44D0")]
		[DebuggerHidden]
		public FNBEBFJCMMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3A55380", Offset = "0x3A53F80", VA = "0x183A55380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3A55530", Offset = "0x3A54130", VA = "0x183A55530", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Action<Protobuf> DOOCODKHFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MemoryStream HAFHDPBBELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CodedInputStream EOBDLEEIICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Protobuf NGBBENHLGLF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BBJDPOLPLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCD0", Offset = "0x5EB8D0", VA = "0x1805ECCD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3A57B40", Offset = "0x3A56740", VA = "0x183A57B40")]
	private HFKOIILHCNK(byte[] LGIIJIKLGAE, Action<Protobuf> DOOCODKHFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x20CC860", Offset = "0x20CB460", VA = "0x1820CC860")]
	public static global::HFKOIILHCNK<Protobuf> DPFIJBHMAAN<Data>(ReadOnlySpan<byte> HJKNKKDBKMB, ReadOnlySpan<Data> FNLGPCALBEM, Action<Protobuf> DOOCODKHFLF)
	{
		return default(global::HFKOIILHCNK<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3A579A0", Offset = "0x3A565A0", VA = "0x183A579A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3A579E0", Offset = "0x3A565E0", VA = "0x183A579E0", Slot = "4")]
	[IteratorStateMachine(typeof(global::HFKOIILHCNK<>.FNBEBFJCMMH))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3A57AE0", Offset = "0x3A566E0", VA = "0x183A57AE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HCLOKPPBGKC<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly byte[] LGIIJIKLGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly Protobuf NGBBENHLGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MemoryStream HAFHDPBBELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CodedOutputStream PMLOMDDAIME;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3883630", Offset = "0x3882230", VA = "0x183883630")]
	private HCLOKPPBGKC(byte[] LGIIJIKLGAE, in Protobuf NGBBENHLGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x20C99D0", Offset = "0x20C85D0", VA = "0x1820C99D0")]
	public static global::HCLOKPPBGKC<Protobuf> DPFIJBHMAAN<T>(ReadOnlySpan<T> FNLGPCALBEM)
	{
		return default(global::HCLOKPPBGKC<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3883600", Offset = "0x3882200", VA = "0x183883600")]
	public void IKJGPAMPFGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3883440", Offset = "0x3882040", VA = "0x183883440")]
	public ByteString DLBADFEOGDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x38834D0", Offset = "0x38820D0", VA = "0x1838834D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GCBCNKMJEPE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly MemoryStream HAFHDPBBELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CodedInputStream EOBDLEEIICJ;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4AAA7B0", Offset = "0x4AA93B0", VA = "0x184AAA7B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct PFNNLNJLGKO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly byte[] LGIIJIKLGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MemoryStream HAFHDPBBELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CodedOutputStream PMLOMDDAIME;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4AAC510", Offset = "0x4AAB110", VA = "0x184AAC510", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public abstract class MGEHOLIJKFJ : LDEEMDKGMLN
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Type IDCPKBGBAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EC490", Offset = "0x5EB090", VA = "0x1805EC490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xE5B270", Offset = "0xE59E70", VA = "0x180E5B270")]
	public MGEHOLIJKFJ(Type PALACDECFCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NJDAPFLEPFB : MGEHOLIJKFJ
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xE5B270", Offset = "0xE59E70", VA = "0x180E5B270")]
	public NJDAPFLEPFB(Type PALACDECFCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PEPIFCLNICC : MGEHOLIJKFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Type LKGNIEFFLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4A0", Offset = "0x5EB0A0", VA = "0x1805EC4A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4AAC4C0", Offset = "0x4AAB0C0", VA = "0x184AAC4C0")]
	public PEPIFCLNICC(Type KKIFALNMIEF, Type PALACDECFCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JKKNHDGKACM : MGEHOLIJKFJ
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xE5B270", Offset = "0xE59E70", VA = "0x180E5B270")]
	public JKKNHDGKACM(Type PALACDECFCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NFGOFKINMIG : LDEEMDKGMLN
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public NFGOFKINMIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BKKFDCFMCDO : LDEEMDKGMLN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FLELDCIJFOA IIELCMHCHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5ECED0", Offset = "0x5EBAD0", VA = "0x1805ECED0")]
		[CompilerGenerated]
		get
		{
			return default(FLELDCIJFOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xE5B080", Offset = "0xE59C80", VA = "0x180E5B080")]
	public BKKFDCFMCDO(FLELDCIJFOA AJKANCOMGHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
public class BOCEAGHBLMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly IEEMDNAPKGD JFAHNIMFMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly EntityManager EJMLDDGCGJO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEEMDNAPKGD BONNMJFMGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9800", Offset = "0x4AA8400", VA = "0x184AA9800")]
	public BOCEAGHBLMC(IEEMDNAPKGD JFAHNIMFMGP, EntityManager EJMLDDGCGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9700", Offset = "0x4AA8300", VA = "0x184AA9700")]
	public int IGKHPOFCFGA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x312B800", Offset = "0x312A400", VA = "0x18312B800")]
	public bool MBFCEEMLDDO<T>(Entity OCMABEPCGDM) where T : struct, LJIGCIINKIP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x312B770", Offset = "0x312A370", VA = "0x18312B770")]
	public bool CKEHCFEGAFO<T>(Entity OCMABEPCGDM, out T KGJOJGIPNPH) where T : struct, LJIGCIINKIP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE160", Offset = "0x3BFCD60", VA = "0x183BFE160")]
	public T OJDIEFJKJBM<T>(Entity OCMABEPCGDM) where T : struct, LJIGCIINKIP
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3969F80", Offset = "0x3968B80", VA = "0x183969F80")]
	private ComponentType LOPLDIFDOLE<T>() where T : struct, LJIGCIINKIP
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9750", Offset = "0x4AA8350", VA = "0x184AA9750")]
	private ComponentType LOPLDIFDOLE(Type LIJLAEFJGCI)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class JKDPGOGJIHE
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	protected JKDPGOGJIHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class AJJDODDPHBI<View, Data> : BMGOEDLPBCC where View : struct, LJIGCIINKIP where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static ComponentType CCHJGMLCKGF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override Type NPEAHFBBKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x286F480", Offset = "0x286E080", VA = "0x18286F480", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override Type IPOMACPCDKD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x286FB00", Offset = "0x286E700", VA = "0x18286FB00", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override int FEFHONNFEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x286EAC0", Offset = "0x286D6C0", VA = "0x18286EAC0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x286EA40", Offset = "0x286D640", VA = "0x18286EA40")]
	public Data ACOBANBPCCC(Entity OCMABEPCGDM)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x286FA20", Offset = "0x286E620", VA = "0x18286FA20")]
	public Data JCAIIAAKNJB(Entity OCMABEPCGDM)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "17")]
	protected internal abstract View CJLAKDNHABE(Entity OCMABEPCGDM);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1EA06C0", Offset = "0x1E9F2C0", VA = "0x181EA06C0", Slot = "15")]
	protected internal override T CJLAKDNHABE<T>(Entity OCMABEPCGDM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2870940", Offset = "0x286F540", VA = "0x182870940", Slot = "16")]
	public override bool MBFCEEMLDDO(Entity OCMABEPCGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2870A30", Offset = "0x286F630", VA = "0x182870A30")]
	protected AJJDODDPHBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class BMGOEDLPBCC : PDFLHPLNHMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private ArchetypeChunkComponentTypeDynamic NNKEKOFOKDD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EntityManager JGHLJDFOODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x906B70", Offset = "0x905770", VA = "0x180906B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public abstract Type NPEAHFBBKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public abstract Type IPOMACPCDKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public abstract int FEFHONNFEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private Type MNJLCOHNHNP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6D2100", Offset = "0x6D0D00", VA = "0x1806D2100", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int NELHICPIJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4AA92A0", Offset = "0x4AA7EA0", VA = "0x184AA92A0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private FCAJCLOJKEA[] LNOFODDPHKP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC1FBF0", Offset = "0xC1E7F0", VA = "0x180C1FBF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	protected internal virtual FCAJCLOJKEA[] ALNEDOGAKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9310", Offset = "0x4AA7F10", VA = "0x184AA9310", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool EBMDDHMOFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9630", Offset = "0x4AA8230", VA = "0x184AA9630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4AA94A0", Offset = "0x4AA80A0", VA = "0x184AA94A0")]
	public void NEDKCOBOAHP(EntityManager EJMLDDGCGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F60", Offset = "0x6A0B60", VA = "0x1806A1F60")]
	protected PDFLHPLNHMF JLKDJMEKACH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T CJLAKDNHABE<T>(Entity OCMABEPCGDM) where T : struct, LJIGCIINKIP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract bool MBFCEEMLDDO(Entity OCMABEPCGDM);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4AA93D0", Offset = "0x4AA7FD0", VA = "0x184AA93D0", Slot = "8")]
	public (uint, uint) IIBDIJHBOIF(Entity OCMABEPCGDM)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9660", Offset = "0x4AA8260", VA = "0x184AA9660", Slot = "9")]
	public bool PKPOAPJFGGA(Entity OCMABEPCGDM, (uint order, uint change) MAAFFLODELA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	protected BMGOEDLPBCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class JJKGOFDDOIH<Data> : MFLEALOIALL where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public virtual Data KEBFNIGMDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x36681B0", Offset = "0x3666DB0", VA = "0x1836681B0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1EC11D0", Offset = "0x1EBFDD0", VA = "0x181EC11D0", Slot = "8")]
	protected virtual bool DAJIKKJPFJJ(ReadOnlySpan<Data> FNLGPCALBEM, PAFBNCGGKDO AGDOOHGFMOM, out ReadOnlySpan<byte> HJKNKKDBKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "9")]
	protected virtual bool DPIMGKAHLNA(int MAAFFLODELA, Span<Data> FNLGPCALBEM, in ReadOnlySpan<byte> HJKNKKDBKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x36681F0", Offset = "0x3666DF0", VA = "0x1836681F0", Slot = "5")]
	internal sealed override bool DAJIKKJPFJJ(ref Unity.Entities.Chunk JMFDNAKFNAC, int KEJAJBPDPAM, PAFBNCGGKDO AGDOOHGFMOM, out ReadOnlySpan<byte> HJKNKKDBKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x36695F0", Offset = "0x36681F0", VA = "0x1836695F0", Slot = "6")]
	internal sealed override bool DPIMGKAHLNA(int MAAFFLODELA, ref Unity.Entities.Chunk JMFDNAKFNAC, int KEJAJBPDPAM, in ReadOnlySpan<byte> HJKNKKDBKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x20D2030", Offset = "0x20D0C30", VA = "0x1820D2030")]
	protected global::HCLOKPPBGKC<Protobuf> AGCLANGPCAK<Protobuf>(ReadOnlySpan<Data> FNLGPCALBEM) where Protobuf : IMessage, new()
	{
		return default(global::HCLOKPPBGKC<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x20D2080", Offset = "0x20D0C80", VA = "0x1820D2080")]
	protected global::HFKOIILHCNK<Protobuf> LGDHHIHGMFI<Protobuf>(ReadOnlySpan<byte> HJKNKKDBKMB, ReadOnlySpan<Data> FNLGPCALBEM, Action<Protobuf> DOOCODKHFLF) where Protobuf : IMessage, new()
	{
		return default(global::HFKOIILHCNK<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2870A30", Offset = "0x286F630", VA = "0x182870A30")]
	protected JJKGOFDDOIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class MFLEALOIALL
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	protected internal abstract int EKKPBKBJINC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4AAC300", Offset = "0x4AAAF00", VA = "0x184AAC300", Slot = "5")]
	internal virtual bool DAJIKKJPFJJ(ref Unity.Entities.Chunk JMFDNAKFNAC, int KEJAJBPDPAM, PAFBNCGGKDO AGDOOHGFMOM, out ReadOnlySpan<byte> HJKNKKDBKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "6")]
	internal virtual bool DPIMGKAHLNA(int MAAFFLODELA, ref Unity.Entities.Chunk JMFDNAKFNAC, int KEJAJBPDPAM, in ReadOnlySpan<byte> HJKNKKDBKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	protected MFLEALOIALL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NOGILILIJPI
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[BurstCompile]
internal struct PMKJBLHNHFB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe Unity.Entities.EntityComponentStore* LEFPCHHIKPE;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4AAC6B0", Offset = "0x4AAB2B0", VA = "0x184AAC6B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface IBLCJPMAPNE
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGHMBOGBPHE(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class HGKCJPKAPKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x38B9D00", Offset = "0x38B8900", VA = "0x1838B9D00")]
	public static void CBICFPGBKNO<T>(this ref T PFDJCNBMCPN, ref ArchetypeChunkIterator JPJAOPEEIOG) where T : struct, IBLCJPMAPNE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2D41510", Offset = "0x2D40110", VA = "0x182D41510")]
	public static void CBICFPGBKNO<T>(this ref T PFDJCNBMCPN, EntityQuery HNEENJGBCID) where T : struct, IBLCJPMAPNE
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class EFGHDFIELEB
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4AAA110", Offset = "0x4AA8D10", VA = "0x184AAA110")]
	public static bool EGIPJCAAEAK(Type LIJLAEFJGCI, Type NGGOPJLNMLA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal abstract class KCBININPMDD<Attribute, BaseClass> : global::FKOEOCCJKIH<BaseClass>, LMBGBEAEDIF where Attribute : MGEHOLIJKFJ
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly LJFAOMOPGNF FFJIMJJJOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string FHNLBBBEDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<int, Type> BHHKOHDJOFO;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x366D6A0", Offset = "0x366C2A0", VA = "0x18366D6A0")]
	public KCBININPMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x366D080", Offset = "0x366BC80", VA = "0x18366D080", Slot = "4")]
	public bool ACOKKIFAPKJ(int OINILPILIOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x366D0E0", Offset = "0x366BCE0", VA = "0x18366D0E0", Slot = "5")]
	public global::MGMBGHBGHPD<BaseClass> DCPGGAJEOKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x366D3B0", Offset = "0x366BFB0", VA = "0x18366D3B0", Slot = "7")]
	protected virtual bool EGIPJCAAEAK(Type LIJLAEFJGCI, int FCBFMLHNBIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x366D4A0", Offset = "0x366C0A0", VA = "0x18366D4A0", Slot = "8")]
	protected virtual int HGMODEMALIC(Type LIJLAEFJGCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x366D530", Offset = "0x366C130", VA = "0x18366D530")]
	public void JHENDOAEKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x366D5A0", Offset = "0x366C1A0", VA = "0x18366D5A0", Slot = "6")]
	public void KIEPKILKNCN(Type LIJLAEFJGCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MGMBGHBGHPD<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<int, BaseClass> JOHAMCBFBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<Type, BaseClass> FPCBJKGOGKO;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IEnumerable<BaseClass> LMNMEBIGPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2A1B980", Offset = "0x2A1A580", VA = "0x182A1B980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2A1BE30", Offset = "0x2A1AA30", VA = "0x182A1BE30")]
	public MGMBGHBGHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2A1BC90", Offset = "0x2A1A890", VA = "0x182A1BC90")]
	public MGMBGHBGHPD(int LAODCMGHKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2A1BBB0", Offset = "0x2A1A7B0", VA = "0x182A1BBB0")]
	internal void LFMPFEAFMAL(int OINILPILIOE, BaseClass LPFHOFODDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x27E7400", Offset = "0x27E6000", VA = "0x1827E7400")]
	public bool EIJBPMGPJPA<T>(out BaseClass KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2A1B8E0", Offset = "0x2A1A4E0", VA = "0x182A1B8E0")]
	public bool EIJBPMGPJPA(Type KLFNKNLAGBI, out BaseClass KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2A1BC30", Offset = "0x2A1A830", VA = "0x182A1BC30")]
	public bool NHDHHHGLCEO(int OINILPILIOE, out BaseClass KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2027A40", Offset = "0x2026640", VA = "0x182027A40")]
	public T PDCHGGFNCCA<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2A1BC60", Offset = "0x2A1A860", VA = "0x182A1BC60")]
	public BaseClass PDCHGGFNCCA(Type EKAMMGLEKBL)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class DCIKGPHNBOK : global::KCBININPMDD<NJDAPFLEPFB, JKDPGOGJIHE>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4AA98D0", Offset = "0x4AA84D0", VA = "0x184AA98D0")]
	public DCIKGPHNBOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class EKINLKLCGJD : global::KCBININPMDD<PEPIFCLNICC, BMGOEDLPBCC>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4AAA720", Offset = "0x4AA9320", VA = "0x184AAA720")]
	public EKINLKLCGJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class AOGABPIGBIE : global::KCBININPMDD<JKKNHDGKACM, MFLEALOIALL>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8D70", Offset = "0x4AA7970", VA = "0x184AA8D70")]
	public AOGABPIGBIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct BMEEGIICBDB
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly LJFAOMOPGNF FFJIMJJJOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<Type> EKIKCADEFHL;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x72D470", Offset = "0x72C070", VA = "0x18072D470")]
	private BMEEGIICBDB(List<Type> EKIKCADEFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9150", Offset = "0x4AA7D50", VA = "0x184AA9150")]
	public static void JHENDOAEKLB(List<Type> EKIKCADEFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8FB0", Offset = "0x4AA7BB0", VA = "0x184AA8FB0")]
	private void EJICGBJFNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8DD0", Offset = "0x4AA79D0", VA = "0x184AA8DD0")]
	private bool EGIPJCAAEAK(Type LIJLAEFJGCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9200", Offset = "0x4AA7E00", VA = "0x184AA9200")]
	private void PAADCCMCNNM(Type LIJLAEFJGCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface FKOEOCCJKIH<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ACOKKIFAPKJ(int OINILPILIOE);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::MGMBGHBGHPD<BaseClass> DCPGGAJEOKK();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class GDMMHGMPDDN : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0")]
	protected GDMMHGMPDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EC480", Offset = "0x5EB080", VA = "0x1805EC480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class NPPAKIFENEO : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0")]
	protected NPPAKIFENEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC480", Offset = "0x5EB080", VA = "0x1805EC480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class FMDEGFFIOHG : GDMMHGMPDDN
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4AAA780", Offset = "0x4AA9380", VA = "0x184AAA780", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	protected void GAECHCABPCP(string LBDLHIHDENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0")]
	protected FMDEGFFIOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC480", Offset = "0x5EB080", VA = "0x1805EC480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4AAD3C0", Offset = "0x4AABFC0", VA = "0x184AAD3C0")]
		public static ComponentSystemGroup[] OOJJIMABJLI(World JFAHNIMFMGP, MEBLIMMOBGJ OAIGLDLDIIE = MEBLIMMOBGJ.Default, bool BINBHOICGLH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4AACFC0", Offset = "0x4AABBC0", VA = "0x184AACFC0")]
		private static Type[] IFFBFBJFHAM(MEBLIMMOBGJ OAIGLDLDIIE, bool BINBHOICGLH, ComponentSystemGroup[] NMOJGFFLPMK, ComponentSystemGroup MCLGFFFEMIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4AAC7C0", Offset = "0x4AAB3C0", VA = "0x184AAC7C0")]
		private static ComponentSystemGroup[] EHKLIMCIDHJ(World JFAHNIMFMGP, out ComponentSystemGroup MCLGFFFEMIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4AAD490", Offset = "0x4AAC090", VA = "0x184AAD490")]
		internal static bool OOKHBBCCDEJ(FLELDCIJFOA AJKANCOMGHN, out LHFFACOBHNF NCIGCLFHPIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4AACEF0", Offset = "0x4AABAF0", VA = "0x184AACEF0")]
		private static ComponentSystemGroup IDIBODBEOOB(Type LIJLAEFJGCI, World JFAHNIMFMGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4AAD2C0", Offset = "0x4AABEC0", VA = "0x184AAD2C0")]
		private static ComponentSystemGroup[] KOFGJHENJMP(Type[] EKIKCADEFHL, World JFAHNIMFMGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4AACA60", Offset = "0x4AAB660", VA = "0x184AACA60")]
		internal static void GNDKHKKJPEA(World JFAHNIMFMGP, Type[] CIKGDBGKGPH, ComponentSystemGroup[] NMOJGFFLPMK, ComponentSystemGroup MCLGFFFEMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4AAC760", Offset = "0x4AAB360", VA = "0x184AAC760")]
		internal static bool BDIOMFDEMBK(ComponentSystemBase NLIFFPLFBDI, ComponentSystemGroup[] NMOJGFFLPMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4AACE90", Offset = "0x4AABA90", VA = "0x184AACE90")]
		private static void ICBNGPMKANA(ComponentSystemGroup[] NMOJGFFLPMK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct BBLDBFOPGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly Dictionary<Type, List<Type>> KIOJKFIPAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly HashSet<Type> FLNJCBENHAJ;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6117B0", Offset = "0x6103B0", VA = "0x1806117B0")]
	public BBLDBFOPGBL(Dictionary<Type, List<Type>> KIOJKFIPAEL, HashSet<Type> FLNJCBENHAJ)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class JHGHMFCOODI : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private Type <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private IEnumerable<Type> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public IEnumerable<Type> <>3__types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public RRFilterWorldSystems <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public RRFilterWorldSystems <>3__<>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private IEnumerator<Type> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Type IEnumerator<Type>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6FD3E0", Offset = "0x6FBFE0", VA = "0x1806FD3E0")]
			[DebuggerHidden]
			public JHGHMFCOODI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x4AABE70", Offset = "0x4AAAA70", VA = "0x184AABE70", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x4AABBC0", Offset = "0x4AAA7C0", VA = "0x184AABBC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x4AABF20", Offset = "0x4AAAB20", VA = "0x184AABF20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x4AABE20", Offset = "0x4AAAA20", VA = "0x184AABE20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x4AABD70", Offset = "0x4AAA970", VA = "0x184AABD70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x4AABD70", Offset = "0x4AAA970", VA = "0x184AABD70", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct BFHDEFFEOOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Type CODFMAECDPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private MEBLIMMOBGJ OAIGLDLDIIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool CMDHNGLNLKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool EALJKBCBBHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool BINBHOICGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IEnumerable<Type> DGAIHIEBIHF;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4AAD710", Offset = "0x4AAC310", VA = "0x184AAD710")]
		public static RRFilterWorldSystems DPFIJBHMAAN()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4AAE4B0", Offset = "0x4AAD0B0", VA = "0x184AAE4B0")]
		public RRFilterWorldSystems NMNDADBLNNH(MEBLIMMOBGJ AJKANCOMGHN)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4AAD7D0", Offset = "0x4AAC3D0", VA = "0x184AAD7D0")]
		public RRFilterWorldSystems ELDCIMFIPFI(IEnumerable<Type> EKIKCADEFHL)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4AAD810", Offset = "0x4AAC410", VA = "0x184AAD810")]
		public RRFilterWorldSystems FODEBNPMFML(bool DJFBCOBFGAN)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4AAD700", Offset = "0x4AAC300", VA = "0x184AAD700")]
		public RRFilterWorldSystems AGLDPMINKKE(bool GIFKLBBIJMP)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4AAE420", Offset = "0x4AAD020", VA = "0x184AAE420")]
		public BBLDBFOPGBL NBBDAPNIJEO(Type[] MJKLKDHJMMG)
		{
			return default(BBLDBFOPGBL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4AAD740", Offset = "0x4AAC340", VA = "0x184AAD740")]
		[IteratorStateMachine(typeof(JHGHMFCOODI))]
		internal IEnumerable<Type> EJLFGCNBLFA(IEnumerable<Type> EKIKCADEFHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4AAD820", Offset = "0x4AAC420", VA = "0x184AAD820")]
		internal Dictionary<Type, List<Type>> HJMNLLBKJMN(IEnumerable<Type> EKIKCADEFHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4AADB30", Offset = "0x4AAC730", VA = "0x184AADB30")]
		private void KJALGEPFNAD(Dictionary<Type, List<Type>> HIGOGPMFHCJ, Type LIJLAEFJGCI, Type EJHJHBNGOIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4AAE2B0", Offset = "0x4AACEB0", VA = "0x184AAE2B0")]
		internal HashSet<Type> LFPEHAGFMOD(IEnumerable<Type> NMOJGFFLPMK, Dictionary<Type, List<Type>> BBDNOECODFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4AADD50", Offset = "0x4AAC950", VA = "0x184AADD50")]
		internal bool LCLNBGKGOBK(Type LIJLAEFJGCI, MEBLIMMOBGJ OAIGLDLDIIE, bool BINBHOICGLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4AADC10", Offset = "0x4AAC810", VA = "0x184AADC10")]
		[CompilerGenerated]
		internal static void KMGHFLMDKJM(Type LIJLAEFJGCI, ref BFHDEFFEOOE P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class IKPDCFGHJLF
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static bool NFIOFNHOFEP;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4AAB9F0", Offset = "0x4AAA5F0", VA = "0x184AAB9F0")]
	public static void NEDKCOBOAHP(bool CJFDGGNEKPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4AABA40", Offset = "0x4AAA640", VA = "0x184AABA40")]
	private static void NJKKIGDKFLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class GIEGIMIFAPB
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4AAAA60", Offset = "0x4AA9660", VA = "0x184AAAA60")]
	public static ulong PKGMLEFOPHG(Type LIJLAEFJGCI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4AAA9B0", Offset = "0x4AA95B0", VA = "0x184AAA9B0")]
	public static ulong PKGMLEFOPHG(string AICCPOCABOB)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private struct CEFPPPLODIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public readonly ulong OGMLHDGNPEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public readonly ulong NHKOMPPGHCG;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xDBC450", Offset = "0xDBB050", VA = "0x180DBC450")]
			public CEFPPPLODIB(ulong LGOJMMEAIII, ulong MMFILCHDLEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x4AA9850", Offset = "0x4AA8450", VA = "0x184AA9850", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static Dictionary<ulong, int> HIDEBHKFMKC;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static CEFPPPLODIB[] PIAIKDMLOID;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static bool NFIOFNHOFEP;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4AAE560", Offset = "0x4AAD160", VA = "0x184AAE560")]
		public static ulong ABLALLIIIMI(int OINILPILIOE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4AAEC20", Offset = "0x4AAD820", VA = "0x184AAEC20")]
		public static int GMCKNJDJEHD(ulong MMFILCHDLEB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4AAEFD0", Offset = "0x4AADBD0", VA = "0x184AAEFD0")]
		public static void NEDKCOBOAHP(bool CJFDGGNEKPC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4AAECC0", Offset = "0x4AAD8C0", VA = "0x184AAECC0")]
		private static void HPAKEBKDLFF(int HAHBHJIEJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4AAE920", Offset = "0x4AAD520", VA = "0x184AAE920")]
		private static void GJBFHENKBEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4AAEE10", Offset = "0x4AADA10", VA = "0x184AAEE10")]
		private static CEFPPPLODIB MCJGEEDDPMC(Type LIJLAEFJGCI)
		{
			return default(CEFPPPLODIB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4AAE8A0", Offset = "0x4AAD4A0", VA = "0x184AAE8A0")]
		private static ulong DKANJACANDB(Type LIJLAEFJGCI, ulong MMFILCHDLEB)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4AAE6B0", Offset = "0x4AAD2B0", VA = "0x184AAE6B0")]
		private static void BGBNNDKBKEG(in CEFPPPLODIB AAMEOPHCGAB, TypeManager.TypeInfo JKGOHDLIFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4AAE5C0", Offset = "0x4AAD1C0", VA = "0x184AAE5C0")]
		private static void AMHDIMPKMOH(CEFPPPLODIB JKGOHDLIFBH, int OINILPILIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4AAEEF0", Offset = "0x4AADAF0", VA = "0x184AAEEF0")]
		private static void MGHELFPGMDB(CEFPPPLODIB JKGOHDLIFBH, int OINILPILIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4AAED80", Offset = "0x4AAD980", VA = "0x184AAED80")]
		private static CEFPPPLODIB IHPKHGAOAMP(int OINILPILIOE)
		{
			return default(CEFPPPLODIB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x4AAE910", Offset = "0x4AAD510", VA = "0x184AAE910")]
		private static int EFEHPGDMLJP(int OINILPILIOE)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class DOEOGBHEALF
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly EKINLKLCGJD BKAMKOEBKMH;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly AOGABPIGBIE HJDKLKKCHDG;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly DCIKGPHNBOK LDGBGPGMOHF;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly List<Type> AAHADEMKNFL;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static bool NFIOFNHOFEP;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	internal static global::FKOEOCCJKIH<BMGOEDLPBCC> KBHFBFHCBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4AA99F0", Offset = "0x4AA85F0", VA = "0x184AA99F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal static global::FKOEOCCJKIH<MFLEALOIALL> AAKOIEKCMIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9930", Offset = "0x4AA8530", VA = "0x184AA9930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	internal static global::FKOEOCCJKIH<JKDPGOGJIHE> MABOGKPNJLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9AC0", Offset = "0x4AA86C0", VA = "0x184AA9AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9B20", Offset = "0x4AA8720", VA = "0x184AA9B20")]
	public static void NEDKCOBOAHP(bool CJFDGGNEKPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9A50", Offset = "0x4AA8650", VA = "0x184AA9A50")]
	public static Type[] JJKOBPGMKEO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EGMDOEDHFGD
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly Dictionary<int, int> MKIAIFKFLJK;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool NFIOFNHOFEP;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4AAA520", Offset = "0x4AA9120", VA = "0x184AAA520")]
	public static int IIBDIJHBOIF(int OINILPILIOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4AAA620", Offset = "0x4AA9220", VA = "0x184AAA620")]
	public static void NEDKCOBOAHP(bool CJFDGGNEKPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4AAA300", Offset = "0x4AA8F00", VA = "0x184AAA300")]
	private static void ICGFPNLLDBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4AAA2B0", Offset = "0x4AA8EB0", VA = "0x184AAA2B0")]
	private static int FDGLJJEJLBI(Type LIJLAEFJGCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4AAA5B0", Offset = "0x4AA91B0", VA = "0x184AAA5B0")]
	private static void LONCNHKPMCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class IEEMDNAPKGD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly World JFAHNIMFMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly World KNBPPIHJCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly BOCEAGHBLMC LPFHOFODDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly ComponentSystemGroup[] NMOJGFFLPMK;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public World BONNMJFMGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public World OGOLPPAGPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EntityManager JGHLJDFOODE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x1A556B0", Offset = "0x1A542B0", VA = "0x181A556B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public BOCEAGHBLMC CCJAAPJEOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public global::MGMBGHBGHPD<BMGOEDLPBCC> KBHFBFHCBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x614A30", Offset = "0x613630", VA = "0x180614A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x724880", Offset = "0x723480", VA = "0x180724880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public global::MGMBGHBGHPD<MFLEALOIALL> AAKOIEKCMIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5ED010", Offset = "0x5EBC10", VA = "0x1805ED010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5ED020", Offset = "0x5EBC20", VA = "0x1805ED020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public global::MGMBGHBGHPD<JKDPGOGJIHE> MABOGKPNJLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5FFD70", Offset = "0x5FE970", VA = "0x1805FFD70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x686FC0", Offset = "0x685BC0", VA = "0x180686FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> FLGGGNNJALI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1A67690", Offset = "0x1A66290", VA = "0x181A67690")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4AAB120", Offset = "0x4AA9D20", VA = "0x184AAB120")]
	public static IEEMDNAPKGD HFLEBPEOJOM(string FHNLBBBEDLN, FLELDCIJFOA AJKANCOMGHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4AAB520", Offset = "0x4AAA120", VA = "0x184AAB520")]
	public IEEMDNAPKGD(string FHNLBBBEDLN, FLELDCIJFOA AJKANCOMGHN = FLELDCIJFOA.Simulation, MEBLIMMOBGJ OAIGLDLDIIE = MEBLIMMOBGJ.Default, bool CJFDGGNEKPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4AAB0A0", Offset = "0x4AA9CA0", VA = "0x184AAB0A0")]
	public ComponentSystemBase GLAPEFBFFHB(Type LIJLAEFJGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x201EA80", Offset = "0x201D680", VA = "0x18201EA80")]
	public T GLAPEFBFFHB<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4AAB4C0", Offset = "0x4AAA0C0", VA = "0x184AAB4C0")]
	public void PDFHIIDCDPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4AAB260", Offset = "0x4AA9E60", VA = "0x184AAB260")]
	public void ILKEDGCDBCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4AAAEE0", Offset = "0x4AA9AE0", VA = "0x184AAAEE0")]
	public void FGAJFFMKEGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4AAB350", Offset = "0x4AA9F50", VA = "0x184AAB350")]
	public void KCKMCNLOINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4AAB040", Offset = "0x4AA9C40", VA = "0x184AAB040")]
	public void GLAJABEPNFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4AAAE60", Offset = "0x4AA9A60", VA = "0x184AAAE60")]
	public void EBDPBIBNAMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4AAB1A0", Offset = "0x4AA9DA0", VA = "0x184AAB1A0")]
	public void IFPEOLCCOAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4AAB200", Offset = "0x4AA9E00", VA = "0x184AAB200")]
	public void IKCOGJEBFCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4AAAF40", Offset = "0x4AA9B40", VA = "0x184AAAF40")]
	internal void GJJDAIEKOHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4AAB2C0", Offset = "0x4AA9EC0", VA = "0x184AAB2C0")]
	private bool JILCIEHNIGJ(ComponentSystemGroup MFEOBENMMAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4AAAC50", Offset = "0x4AA9850", VA = "0x184AAAC50")]
	private void AKANBOBPAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4AAB3B0", Offset = "0x4AA9FB0", VA = "0x184AAB3B0")]
	private ComponentSystemGroup[] OOJJIMABJLI(MEBLIMMOBGJ OAIGLDLDIIE, bool BINBHOICGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4AAB0C0", Offset = "0x4AA9CC0", VA = "0x184AAB0C0")]
	public void HAFAFDKGJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4AAADF0", Offset = "0x4AA99F0", VA = "0x184AAADF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
public enum FLELDCIJFOA
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Game = 5,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[AttributeUsage(AttributeTargets.Class)]
public sealed class DIAOEHLEPGN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public MEBLIMMOBGJ BPJKCDFKOFF;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Flags]
public enum MEBLIMMOBGJ
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	GameObjectConversion = 0x30,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	EntitySceneOptimizations = 4,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	ProcessAfterLoad = 8,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	HybridGameObjectConversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	DotsRuntimeGameObjectConversion = 0x20
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface LHFFACOBHNF
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	Type FOKNLFKLHED
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Type[] CAPGDNEBHCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class FOANKKIPPBC : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public virtual bool FDMKLOPPNCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFE0", Offset = "0x5EBBE0", VA = "0x1805ECFE0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	protected FOANKKIPPBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[DisableAutoCreation]
public sealed class PADMAICGBGP : FOANKKIPPBC
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public PADMAICGBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DisableAutoCreation]
public sealed class KLDIMHIKONI : FOANKKIPPBC
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public KLDIMHIKONI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[DisableAutoCreation]
public sealed class LHBFAJLGMFC : FOANKKIPPBC
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public LHBFAJLGMFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DisableAutoCreation]
public sealed class EDCAHLMDKIK : FOANKKIPPBC
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public EDCAHLMDKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DisableAutoCreation]
public sealed class FHLDCJIMBAF : FOANKKIPPBC
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public FHLDCJIMBAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DisableAutoCreation]
public sealed class NNGMJKHEMLP : FOANKKIPPBC
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public override bool FDMKLOPPNCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public NNGMJKHEMLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[AttributeUsage(AttributeTargets.Class)]
public class LGLOKJFMMGB : LDEEMDKGMLN
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public LGLOKJFMMGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class GKHFFCBGHNI
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate void GBHJGEHAPKN<From, To>(From MAGJNDGNDNI, ref To GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class HJNNNMOKPMJ<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static GBHJGEHAPKN<From, To> DLKNHJENJNL;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public HJNNNMOKPMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4AAAA90", Offset = "0x4AA9690", VA = "0x184AAAA90")]
	static GKHFFCBGHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x38A7600", Offset = "0x38A6200", VA = "0x1838A7600")]
	public static void DHPCLOFAIII<T>(GBHJGEHAPKN<T, T> CKDNPINJNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x38A7820", Offset = "0x38A6420", VA = "0x1838A7820")]
	public static void DHPCLOFAIII<From, To>(GBHJGEHAPKN<From, To> CKDNPINJNHC, GBHJGEHAPKN<To, From> DHKLJDIKLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3281E80", Offset = "0x3280A80", VA = "0x183281E80")]
	public static void DHPCLOFAIII<From, To>(GBHJGEHAPKN<From, To> DLKNHJENJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E350", Offset = "0x2E1CF50", VA = "0x182E1E350")]
	public static GBHJGEHAPKN<From, To> IFPEILJDDDH<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x38A9B20", Offset = "0x38A8720", VA = "0x1838A9B20")]
	public static void GDPAMAPBGDO<From, To>(From MAGJNDGNDNI, ref To GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class PAFBNCGGKDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> HGOCNJNHMOP;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0xD64B80", Offset = "0xD63780", VA = "0x180D64B80")]
	public PAFBNCGGKDO(NativeArray<EntityRemapUtility.EntityRemapInfo> HGOCNJNHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2636470", Offset = "0x2635070", VA = "0x182636470")]
	public Entity DBBOKDCGLCM(Entity FNNHACEFOCO)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class JPDPDAGFBFD
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Dictionary<(ulong hash, uint version), string> CKALEGLILFD;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4AAC020", Offset = "0x4AAAC20", VA = "0x184AAC020")]
	public static bool FCKBPPEOEKF(ulong CLFDHFBNGEA, uint MAAFFLODELA, out string FHNLBBBEDLN)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Serialization, new string[] { "Timing", "Deprecated", "Types", "Archetypes" })]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private struct HAOKINKFJBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int PAOIHHHPKNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int EKKPBKBJINC;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x775D30", Offset = "0x774930", VA = "0x180775D30")]
			public HAOKINKFJBL(int HIANDEDCLIF, int MAAFFLODELA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct NOFDMBIDCPE
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private static Stopwatch CMOAPILJKIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private long BNHFAGHFNBF;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public long HEMACNLHMDP
			{
				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x4AAC320", Offset = "0x4AAAF20", VA = "0x184AAC320")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public long JFCKMBLPDFE
			{
				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x4AAC430", Offset = "0x4AAB030", VA = "0x184AAC430")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x4AAC370", Offset = "0x4AAAF70", VA = "0x184AAC370")]
			public static NOFDMBIDCPE IBPCOHCJGHA()
			{
				return default(NOFDMBIDCPE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private struct ALOFMICHNIM : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public readonly struct JONCEOEHNCP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public unsafe readonly Unity.Entities.Archetype* MPOJOOKCNLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				public readonly KPIDKMHNKOG.KILDOODAANK.AALIGNGKEOJ JGBGIEAPEJE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000078")]
				public readonly PAFBNCGGKDO AGDOOHGFMOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000079")]
				public readonly global::MGMBGHBGHPD<MFLEALOIALL> JMDOFDJFGBC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public readonly int KEJAJBPDPAM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public readonly int MCGABOLBBIM;

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x4AABFC0", Offset = "0x4AAABC0", VA = "0x184AABFC0")]
				public unsafe JONCEOEHNCP(Unity.Entities.Archetype* MPOJOOKCNLJ, KPIDKMHNKOG.KILDOODAANK.AALIGNGKEOJ JGBGIEAPEJE, PAFBNCGGKDO AGDOOHGFMOM, global::MGMBGHBGHPD<MFLEALOIALL> JMDOFDJFGBC, int KEJAJBPDPAM, int MCGABOLBBIM = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x4AABF70", Offset = "0x4AAAB70", VA = "0x184AABF70")]
				public JONCEOEHNCP(in JONCEOEHNCP OAGMKJFIKKL, int MCGABOLBBIM)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public readonly JONCEOEHNCP[] FNLGPCALBEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public string[] BAOPKAIAHFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public int GPGGEBPHNNO;

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x4AA8B10", Offset = "0x4AA7710", VA = "0x184AA8B10")]
			public ALOFMICHNIM(JONCEOEHNCP[] FNLGPCALBEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x4AA84B0", Offset = "0x4AA70B0", VA = "0x184AA84B0", Slot = "4")]
			public void Invoke(int HIANDEDCLIF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x4AA8510", Offset = "0x4AA7110", VA = "0x184AA8510")]
			private void LDONCBICIHE(in JONCEOEHNCP OAGMKJFIKKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x4AA8870", Offset = "0x4AA7470", VA = "0x184AA8870")]
			private static void NLFJBFJFJGL(in JONCEOEHNCP OAGMKJFIKKL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class AHBEIOFPAOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public KPIDKMHNKOG asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public global::MGMBGHBGHPD<MFLEALOIALL> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
			public AHBEIOFPAOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x4AA7F90", Offset = "0x4AA6B90", VA = "0x184AA7F90")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class AAAKBFEGOED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public KPIDKMHNKOG.KILDOODAANK.AALIGNGKEOJ srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public AHBEIOFPAOI CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
			public AAAKBFEGOED()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class ANNJCPNODKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public AAAKBFEGOED CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
			public ANNJCPNODKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x4AA8C50", Offset = "0x4AA7850", VA = "0x184AA8C50")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static LJFAOMOPGNF DEBMIKHJFGE;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static LJFAOMOPGNF AHOMCMHNPNP;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static LJFAOMOPGNF CMIEAFGDGCL;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static LJFAOMOPGNF INEDHAAAFDO;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static bool CINBDGJINPM;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static KPIDKMHNKOG.KILDOODAANK.AABPJIGAMHM CEHEOLCJIDJ;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4AB1580", Offset = "0x4AB0180", VA = "0x184AB1580")]
		private unsafe static bool IJNLPJPJMEG(Unity.Entities.Archetype* FMENGPOHLND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4AB0A80", Offset = "0x4AAF680", VA = "0x184AB0A80")]
		internal unsafe static Unity.Entities.Archetype*[] FKCNPAGDJAA(ref Unity.Entities.EntityComponentStore LEFPCHHIKPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4AAF2B0", Offset = "0x4AADEB0", VA = "0x184AAF2B0")]
		public static void BHEHMICBHAA(IEEMDNAPKGD JFAHNIMFMGP, out ByteString HJKNKKDBKMB, out NativeArray<EntityRemapUtility.EntityRemapInfo> PEKGFGHMEAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4AAFF60", Offset = "0x4AAEB60", VA = "0x184AAFF60")]
		internal static void EEODHEMDEAH(IEEMDNAPKGD JFAHNIMFMGP, KPIDKMHNKOG DHPHBAFGKHP, out NativeArray<EntityRemapUtility.EntityRemapInfo> PEKGFGHMEAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4AB2310", Offset = "0x4AB0F10", VA = "0x184AB2310")]
		private unsafe static UnsafeHashMap<ulong, HAOKINKFJBL> PEPJKMPINOH(Unity.Entities.Archetype*[] KGMBLCODGNB)
		{
			return default(UnsafeHashMap<ulong, HAOKINKFJBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4AAF360", Offset = "0x4AADF60", VA = "0x184AAF360")]
		private static void BNMOPEDNBBE(KPIDKMHNKOG DHPHBAFGKHP, UnsafeHashMap<ulong, HAOKINKFJBL> BKMJEGAEJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4AB0C30", Offset = "0x4AAF830", VA = "0x184AB0C30")]
		private unsafe static void GLKKAMCIEAI(KPIDKMHNKOG DHPHBAFGKHP, Unity.Entities.Archetype*[] KGMBLCODGNB, UnsafeHashMap<ulong, HAOKINKFJBL> BKMJEGAEJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4AAF4F0", Offset = "0x4AAE0F0", VA = "0x184AAF4F0")]
		private unsafe static int CCANCMDOOPP(Unity.Entities.Archetype*[] KGMBLCODGNB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4AB10A0", Offset = "0x4AAFCA0", VA = "0x184AB10A0")]
		private unsafe static void IBAPMICDEKN(KPIDKMHNKOG DHPHBAFGKHP, Unity.Entities.Archetype*[] KGMBLCODGNB, global::MGMBGHBGHPD<MFLEALOIALL> JMDOFDJFGBC, NativeArray<EntityRemapUtility.EntityRemapInfo> PEKGFGHMEAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4AB0860", Offset = "0x4AAF460", VA = "0x184AB0860")]
		private static NativeArray<int> FJCCAPONDIG(KPIDKMHNKOG DHPHBAFGKHP)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4AB2570", Offset = "0x4AB1170", VA = "0x184AB2570")]
		private static Memory<EntityArchetype> PJHPDMAEPIB(KPIDKMHNKOG DHPHBAFGKHP, NativeArray<int> EKIKCADEFHL, EntityManager EJMLDDGCGJO, out int JONDGIHLDOG, out int KONPFCLEFGK)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4AB1670", Offset = "0x4AB0270", VA = "0x184AB1670")]
		private unsafe static void INJBGOPBBOE(Unity.Entities.Chunk* MBMOOHABPJI, ReadOnlySpan<byte> HJKNKKDBKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4AB1C60", Offset = "0x4AB0860", VA = "0x184AB1C60")]
		private static void NMJODPLKNAD(KPIDKMHNKOG DHPHBAFGKHP, NativeArray<int> EKIKCADEFHL, Span<EntityArchetype> KGMBLCODGNB, EntityManager EJMLDDGCGJO, global::MGMBGHBGHPD<MFLEALOIALL> JMDOFDJFGBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4AB1BE0", Offset = "0x4AB07E0", VA = "0x184AB1BE0")]
		private unsafe static void MIGAEMGDHJF(Unity.Entities.Chunk* JMFDNAKFNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4AAF560", Offset = "0x4AAE160", VA = "0x184AAF560")]
		private unsafe static void CMLHHCCEAFN(KPIDKMHNKOG.KILDOODAANK.AALIGNGKEOJ MPOJOOKCNLJ, int PPGDPIEPDGF, int IHEOIPICHFN, Unity.Entities.Chunk* MBMOOHABPJI, KPIDKMHNKOG DHPHBAFGKHP, NativeArray<int> EKIKCADEFHL, global::MGMBGHBGHPD<MFLEALOIALL> JMDOFDJFGBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4AAFD30", Offset = "0x4AAE930", VA = "0x184AAFD30")]
		public static void EABPGCDPJIF(IEEMDNAPKGD JFAHNIMFMGP, in ByteString HJKNKKDBKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4AAF830", Offset = "0x4AAE430", VA = "0x184AAF830")]
		public static void EABPGCDPJIF(EntityManager EJMLDDGCGJO, global::MGMBGHBGHPD<MFLEALOIALL> JMDOFDJFGBC, in ByteString HJKNKKDBKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4AB1940", Offset = "0x4AB0540", VA = "0x184AB1940")]
		private static bool JMFLLPNLJBJ(Type LIJLAEFJGCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4AB0EF0", Offset = "0x4AAFAF0", VA = "0x184AB0EF0")]
		private static void GMKFIBFGNKK(TypeManager.TypeInfo JKGOHDLIFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4AAFDC0", Offset = "0x4AAE9C0", VA = "0x184AAFDC0")]
		private unsafe static int EDEHOJHIHPI(Unity.Entities.Archetype*[] KGMBLCODGNB, NativeArray<EntityRemapUtility.EntityRemapInfo> PEKGFGHMEAP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4AB14A0", Offset = "0x4AB00A0", VA = "0x184AB14A0")]
		private static int IIBDIJHBOIF(int OINILPILIOE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4AAF210", Offset = "0x4AADE10", VA = "0x184AAF210")]
		private static ulong ABLALLIIIMI(int OINILPILIOE)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class AJIONBPOHAE
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8000", Offset = "0x4AA6C00", VA = "0x184AA8000")]
	private unsafe static Span<byte> APICHBLONKD(Unity.Entities.Chunk* JMFDNAKFNAC, int KEJAJBPDPAM)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x212F150", Offset = "0x212DD50", VA = "0x18212F150")]
	public unsafe static Span<T> GKKEEKDPCMI<T>(Unity.Entities.Chunk* JMFDNAKFNAC, int KEJAJBPDPAM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x212F0C0", Offset = "0x212DCC0", VA = "0x18212F0C0")]
	public static Span<T> GKKEEKDPCMI<T>(this ref Unity.Entities.Chunk JMFDNAKFNAC, int KEJAJBPDPAM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4AA81A0", Offset = "0x4AA6DA0", VA = "0x184AA81A0")]
	public unsafe static Span<Entity> HBPHDBKJHPH(Unity.Entities.Chunk* JMFDNAKFNAC)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8200", Offset = "0x4AA6E00", VA = "0x184AA8200")]
	public unsafe static void LONCNHKPMCG(Unity.Entities.Chunk* JMFDNAKFNAC, int KEJAJBPDPAM)
	{
	}
}
namespace RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[Preserve]
	internal class _RRAssemblyIndex : DGENKNGBBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC480", Offset = "0x5EB080", VA = "0x1805EC480")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4AB2AC0", Offset = "0x4AB16C0", VA = "0x184AB2AC0", Slot = "4")]
		public sealed override void JHENDOAEKLB()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class GGMACBOFMDA
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static byte[] HNILJCLIGCF;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int MHDNNHPLAAF;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static int JKLLCIMILJG;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static BigInteger JLHIBEKHFGK;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GGMACBOFMDA()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
