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
internal static class KAAAINBEKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4B676D0", Offset = "0x4B662D0", VA = "0x184B676D0")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> NLFPOOFCIMI(this ref Unity.Entities.Archetype NHDMIJDMMIM)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JDKIBDICBHB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B67470", Offset = "0x4B66070", VA = "0x184B67470")]
	public static Span<int> EKDBEGHAFOJ(this EntityArchetype NHDMIJDMMIM)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class POPPHHPBOMI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4B68740", Offset = "0x4B67340", VA = "0x184B68740")]
	public static bool MLPCDHELIGA(this Entity NNCGIOJNJIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KDEMPAAFCND
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct MKKDAJILPHK<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class KIFCBJGMINI : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public global::MKKDAJILPHK<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5E5000", Offset = "0x5E3C00", VA = "0x1805E5000", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x32348F0", Offset = "0x32334F0", VA = "0x1832348F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1E35600", Offset = "0x1E34200", VA = "0x181E35600")]
		[DebuggerHidden]
		public KIFCBJGMINI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x32346F0", Offset = "0x32332F0", VA = "0x1832346F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x32348A0", Offset = "0x32334A0", VA = "0x1832348A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Action<Protobuf> FMKLGILPGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MemoryStream OEMDOONMCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CodedInputStream BAFDIJJFEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Protobuf COFALLJAJIH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JKHPADLGMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E4CD0", Offset = "0x5E38D0", VA = "0x1805E4CD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x323AB90", Offset = "0x3239790", VA = "0x18323AB90")]
	private MKKDAJILPHK(byte[] GDLCFFFAFKF, Action<Protobuf> FMKLGILPGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1E01E70", Offset = "0x1E00A70", VA = "0x181E01E70")]
	public static global::MKKDAJILPHK<Protobuf> NEKFKHFNPIG<Data>(ReadOnlySpan<byte> HNODBNMBHHD, ReadOnlySpan<Data> DDJJEIOCKHK, Action<Protobuf> FMKLGILPGCB)
	{
		return default(global::MKKDAJILPHK<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x323A9F0", Offset = "0x32395F0", VA = "0x18323A9F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x323AA30", Offset = "0x3239630", VA = "0x18323AA30", Slot = "4")]
	[IteratorStateMachine(typeof(global::MKKDAJILPHK<>.KIFCBJGMINI))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x323AB30", Offset = "0x3239730", VA = "0x18323AB30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct JGHPHOIPPNO<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly byte[] GDLCFFFAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly Protobuf COFALLJAJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MemoryStream OEMDOONMCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CodedOutputStream HELHGIDDEFJ;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x31FD2A0", Offset = "0x31FBEA0", VA = "0x1831FD2A0")]
	private JGHPHOIPPNO(byte[] GDLCFFFAFKF, in Protobuf COFALLJAJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1DF7BE0", Offset = "0x1DF67E0", VA = "0x181DF7BE0")]
	public static global::JGHPHOIPPNO<Protobuf> NEKFKHFNPIG<T>(ReadOnlySpan<T> DDJJEIOCKHK)
	{
		return default(global::JGHPHOIPPNO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x31FD0B0", Offset = "0x31FBCB0", VA = "0x1831FD0B0")]
	public void APCMLFCFNHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x31FD210", Offset = "0x31FBE10", VA = "0x1831FD210")]
	public ByteString FPGLHGOIMKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x31FD0E0", Offset = "0x31FBCE0", VA = "0x1831FD0E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct EICMBHFEEFL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly MemoryStream OEMDOONMCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CodedInputStream BAFDIJJFEGC;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4B657C0", Offset = "0x4B643C0", VA = "0x184B657C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LGPEADDIIAL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly byte[] GDLCFFFAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MemoryStream OEMDOONMCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CodedOutputStream HELHGIDDEFJ;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4B67A60", Offset = "0x4B66660", VA = "0x184B67A60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public abstract class EJMFKHKLBOG : COFBBNAOLMK
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Type JCPEJCNAAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E4490", Offset = "0x5E3090", VA = "0x1805E4490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xE532B0", Offset = "0xE51EB0", VA = "0x180E532B0")]
	public EJMFKHKLBOG(Type DHPLHEEBDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IAGIAPGFEBP : EJMFKHKLBOG
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xE532B0", Offset = "0xE51EB0", VA = "0x180E532B0")]
	public IAGIAPGFEBP(Type DHPLHEEBDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ANHFBIHPKHJ : EJMFKHKLBOG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Type JJAPNDFIGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E44A0", Offset = "0x5E30A0", VA = "0x1805E44A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4B63FB0", Offset = "0x4B62BB0", VA = "0x184B63FB0")]
	public ANHFBIHPKHJ(Type INOBLHNEAFL, Type DHPLHEEBDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FNDKJDPJFAD : EJMFKHKLBOG
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xE532B0", Offset = "0xE51EB0", VA = "0x180E532B0")]
	public FNDKJDPJFAD(Type DHPLHEEBDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EFHICEMKHKB : COFBBNAOLMK
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public EFHICEMKHKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FAINFJBGAAN : COFBBNAOLMK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICDFCBCPDHG PMEAFBHFGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5E4ED0", Offset = "0x5E3AD0", VA = "0x1805E4ED0")]
		[CompilerGenerated]
		get
		{
			return default(ICDFCBCPDHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xE53280", Offset = "0xE51E80", VA = "0x180E53280")]
	public FAINFJBGAAN(ICDFCBCPDHG PELMCJBBFEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
public class DMFKDOOKGAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly IMONMIBPEJJ DFJHEIJOIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly EntityManager DEFMCCAEPJC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IMONMIBPEJJ ADPEJAKCDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4B65310", Offset = "0x4B63F10", VA = "0x184B65310")]
	public DMFKDOOKGAJ(IMONMIBPEJJ DFJHEIJOIKC, EntityManager DEFMCCAEPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4B65210", Offset = "0x4B63E10", VA = "0x184B65210")]
	public int JKADKMLMJDL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x28B0540", Offset = "0x28AF140", VA = "0x1828B0540")]
	public bool HEHMPKOJNKO<T>(Entity NNCGIOJNJIH) where T : struct, CFEJBGAMNPP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x28B04B0", Offset = "0x28AF0B0", VA = "0x1828B04B0")]
	public bool EFKBNOFKJOH<T>(Entity NNCGIOJNJIH, out T PDMPLJICJLE) where T : struct, CFEJBGAMNPP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x33D3780", Offset = "0x33D2380", VA = "0x1833D3780")]
	public T PJFDAHJAJNA<T>(Entity NNCGIOJNJIH) where T : struct, CFEJBGAMNPP
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x364DA40", Offset = "0x364C640", VA = "0x18364DA40")]
	private ComponentType OAPKMCGIFON<T>() where T : struct, CFEJBGAMNPP
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4B65260", Offset = "0x4B63E60", VA = "0x184B65260")]
	private ComponentType OAPKMCGIFON(Type HCPDGKICMEB)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class CHPIMBEBNAB
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	protected CHPIMBEBNAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class KOJENGBGDPA<View, Data> : EFCKPAPAFFN where View : struct, CFEJBGAMNPP where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static ComponentType NAECLLDDILH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override Type NBKMGCPIALH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x44E6A50", Offset = "0x44E5650", VA = "0x1844E6A50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override Type FEGIBEIGOAA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x44E59B0", Offset = "0x44E45B0", VA = "0x1844E59B0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override int DCLPOMNJMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x44E6FF0", Offset = "0x44E5BF0", VA = "0x1844E6FF0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x44E6050", Offset = "0x44E4C50", VA = "0x1844E6050")]
	public Data KOKBCFENJJB(Entity NNCGIOJNJIH)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x44E60D0", Offset = "0x44E4CD0", VA = "0x1844E60D0")]
	public Data MICMPMHCAHM(Entity NNCGIOJNJIH)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "17")]
	protected internal abstract View GKJDNNOPLJJ(Entity NNCGIOJNJIH);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x33E1980", Offset = "0x33E0580", VA = "0x1833E1980", Slot = "15")]
	protected internal override T GKJDNNOPLJJ<T>(Entity NNCGIOJNJIH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x44E6010", Offset = "0x44E4C10", VA = "0x1844E6010", Slot = "16")]
	public override bool HEHMPKOJNKO(Entity NNCGIOJNJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x241E380", Offset = "0x241CF80", VA = "0x18241E380")]
	protected KOJENGBGDPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class EFCKPAPAFFN : EPHEKOJILAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private ArchetypeChunkComponentTypeDynamic DDEMHBMBDHC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EntityManager OOLEAOGIJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB70", Offset = "0x8FD770", VA = "0x1808FEB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public abstract Type NBKMGCPIALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public abstract Type FEGIBEIGOAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public abstract int DCLPOMNJMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private Type EAIEBNIEKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6CA100", Offset = "0x6C8D00", VA = "0x1806CA100", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int AOCLPBEKLIC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4B65720", Offset = "0x4B64320", VA = "0x184B65720", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private PIGCJKHMOBI[] NNGCJGPHCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC17BF0", Offset = "0xC167F0", VA = "0x180C17BF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	protected internal virtual PIGCJKHMOBI[] DKCAICEFIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4B65400", Offset = "0x4B64000", VA = "0x184B65400", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool OOFLFOHHDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4B65790", Offset = "0x4B64390", VA = "0x184B65790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4B654C0", Offset = "0x4B640C0", VA = "0x184B654C0")]
	public void CMEOLNMPNEL(EntityManager DEFMCCAEPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x699F60", Offset = "0x698B60", VA = "0x180699F60")]
	protected EPHEKOJILAC JFNCDPBJPKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T GKJDNNOPLJJ<T>(Entity NNCGIOJNJIH) where T : struct, CFEJBGAMNPP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract bool HEHMPKOJNKO(Entity NNCGIOJNJIH);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4B65650", Offset = "0x4B64250", VA = "0x184B65650", Slot = "8")]
	public (uint, uint) MCBCNNLNFHN(Entity NNCGIOJNJIH)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4B65360", Offset = "0x4B63F60", VA = "0x184B65360", Slot = "9")]
	public bool ACFFBFFJOOP(Entity NNCGIOJNJIH, (uint order, uint change) PGLJOAGFHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	protected EFCKPAPAFFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class KHMPCBKBEIA<Data> : PPFMHAEEBEC where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public virtual Data OAMALNNIHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3055FA0", Offset = "0x3054BA0", VA = "0x183055FA0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1EF70D0", Offset = "0x1EF5CD0", VA = "0x181EF70D0", Slot = "8")]
	protected virtual bool NIMFFOIGAEK(ReadOnlySpan<Data> DDJJEIOCKHK, OBMBDPDKGND IMPCIAHGEFF, out ReadOnlySpan<byte> HNODBNMBHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "9")]
	protected virtual bool ADMGDHIHENJ(int PGLJOAGFHIO, Span<Data> DDJJEIOCKHK, in ReadOnlySpan<byte> HNODBNMBHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3056070", Offset = "0x3054C70", VA = "0x183056070", Slot = "5")]
	internal sealed override bool NIMFFOIGAEK(ref Unity.Entities.Chunk DGJPCCHKBLD, int MNAGEKOCINK, OBMBDPDKGND IMPCIAHGEFF, out ReadOnlySpan<byte> HNODBNMBHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3055210", Offset = "0x3053E10", VA = "0x183055210", Slot = "6")]
	internal sealed override bool ADMGDHIHENJ(int PGLJOAGFHIO, ref Unity.Entities.Chunk DGJPCCHKBLD, int MNAGEKOCINK, in ReadOnlySpan<byte> HNODBNMBHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1DFA530", Offset = "0x1DF9130", VA = "0x181DFA530")]
	protected global::JGHPHOIPPNO<Protobuf> ICLOJPBBIGI<Protobuf>(ReadOnlySpan<Data> DDJJEIOCKHK) where Protobuf : IMessage, new()
	{
		return default(global::JGHPHOIPPNO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1DFA580", Offset = "0x1DF9180", VA = "0x181DFA580")]
	protected global::MKKDAJILPHK<Protobuf> PELJHONMBEG<Protobuf>(ReadOnlySpan<byte> HNODBNMBHHD, ReadOnlySpan<Data> DDJJEIOCKHK, Action<Protobuf> FMKLGILPGCB) where Protobuf : IMessage, new()
	{
		return default(global::MKKDAJILPHK<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x241E380", Offset = "0x241CF80", VA = "0x18241E380")]
	protected KHMPCBKBEIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class PPFMHAEEBEC
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	protected internal abstract int DBOCDBJDJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4B68760", Offset = "0x4B67360", VA = "0x184B68760", Slot = "5")]
	internal virtual bool NIMFFOIGAEK(ref Unity.Entities.Chunk DGJPCCHKBLD, int MNAGEKOCINK, OBMBDPDKGND IMPCIAHGEFF, out ReadOnlySpan<byte> HNODBNMBHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "6")]
	internal virtual bool ADMGDHIHENJ(int PGLJOAGFHIO, ref Unity.Entities.Chunk DGJPCCHKBLD, int MNAGEKOCINK, in ReadOnlySpan<byte> HNODBNMBHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	protected PPFMHAEEBEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FMFDJEMIENB
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[BurstCompile]
internal struct KCOFMCIOALA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe Unity.Entities.EntityComponentStore* HDACPMJLACO;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4B67820", Offset = "0x4B66420", VA = "0x184B67820", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HFOHGLLLBPF
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGHOBJEPAPD(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class EKOCDIMJHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x30AC710", Offset = "0x30AB310", VA = "0x1830AC710")]
	public static void LKEFLPHPHPH<T>(this ref T FCDKMBBNEOA, ref ArchetypeChunkIterator GFDOMFHEOLB) where T : struct, HFOHGLLLBPF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x30AC670", Offset = "0x30AB270", VA = "0x1830AC670")]
	public static void LKEFLPHPHPH<T>(this ref T FCDKMBBNEOA, EntityQuery PCDAJDFNNNN) where T : struct, HFOHGLLLBPF
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class PNKENDGGDLO
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4B685A0", Offset = "0x4B671A0", VA = "0x184B685A0")]
	public static bool AIAMOPMEFMD(Type HCPDGKICMEB, Type BMHEAKLFKPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal abstract class DAFIJJKIKPP<Attribute, BaseClass> : global::HFBLOEHGIOL<BaseClass>, IPALCPMEFDD where Attribute : EJMFKHKLBOG
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly PEOJNAGCHAI NLGECAJFNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string AMDKCMALAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<int, Type> OOAFJODKIDC;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3205790", Offset = "0x3204390", VA = "0x183205790")]
	public DAFIJJKIKPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3205530", Offset = "0x3204130", VA = "0x183205530", Slot = "4")]
	public bool HNMPINFIMAB(int DGOFBPBLNGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3205260", Offset = "0x3203E60", VA = "0x183205260", Slot = "5")]
	public global::BGGCDGNEJCN<BaseClass> HAEOCPPAGLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3205170", Offset = "0x3203D70", VA = "0x183205170", Slot = "7")]
	protected virtual bool AIAMOPMEFMD(Type HCPDGKICMEB, int FJJLDKFAKAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3205590", Offset = "0x3204190", VA = "0x183205590", Slot = "8")]
	protected virtual int KHOJHCKLJLJ(Type HCPDGKICMEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x32056C0", Offset = "0x32042C0", VA = "0x1832056C0")]
	public void PGNCHLHGPKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3205620", Offset = "0x3204220", VA = "0x183205620", Slot = "6")]
	public void LGPGOGPHNHB(Type HCPDGKICMEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BGGCDGNEJCN<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<int, BaseClass> AFPEOGEGDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<Type, BaseClass> MEKCICAFCNF;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IEnumerable<BaseClass> HBCDHOMMIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3B5E220", Offset = "0x3B5CE20", VA = "0x183B5E220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3B5E6A0", Offset = "0x3B5D2A0", VA = "0x183B5E6A0")]
	public BGGCDGNEJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3B5E500", Offset = "0x3B5D100", VA = "0x183B5E500")]
	public BGGCDGNEJCN(int EFOLPOOCAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3B5E450", Offset = "0x3B5D050", VA = "0x183B5E450")]
	internal void JNIPLPDFDNO(int DGOFBPBLNGG, BaseClass JHMAEGCBJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x28ABD20", Offset = "0x28AA920", VA = "0x1828ABD20")]
	public bool AOHDJCKDFGP<T>(out BaseClass PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3B5E180", Offset = "0x3B5CD80", VA = "0x183B5E180")]
	public bool AOHDJCKDFGP(Type ABLJKBEKADN, out BaseClass PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2F786F0", Offset = "0x2F772F0", VA = "0x182F786F0")]
	public bool PAGECNOIKON(int DGOFBPBLNGG, out BaseClass PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1D850B0", Offset = "0x1D83CB0", VA = "0x181D850B0")]
	public T MMKBHFPKKHC<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3B5E4D0", Offset = "0x3B5D0D0", VA = "0x183B5E4D0")]
	public BaseClass MMKBHFPKKHC(Type KJGPDOEODHO)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class AOINJCNEMMB : global::DAFIJJKIKPP<IAGIAPGFEBP, CHPIMBEBNAB>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4B64000", Offset = "0x4B62C00", VA = "0x184B64000")]
	public AOINJCNEMMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class CBKEAKMMKNJ : global::DAFIJJKIKPP<ANHFBIHPKHJ, EFCKPAPAFFN>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4B64980", Offset = "0x4B63580", VA = "0x184B64980")]
	public CBKEAKMMKNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class JEFKJJIGPDI : global::DAFIJJKIKPP<FNDKJDPJFAD, PPFMHAEEBEC>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4B674E0", Offset = "0x4B660E0", VA = "0x184B674E0")]
	public JEFKJJIGPDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct DKEOCJMHINC
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly PEOJNAGCHAI NLGECAJFNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<Type> GMEAGHGEJOI;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x725470", Offset = "0x724070", VA = "0x180725470")]
	private DKEOCJMHINC(List<Type> GMEAGHGEJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4B65120", Offset = "0x4B63D20", VA = "0x184B65120")]
	public static void PGNCHLHGPKH(List<Type> GMEAGHGEJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4B64F80", Offset = "0x4B63B80", VA = "0x184B64F80")]
	private void GFPBODFKDFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4B64D40", Offset = "0x4B63940", VA = "0x184B64D40")]
	private bool AIAMOPMEFMD(Type HCPDGKICMEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4B64F20", Offset = "0x4B63B20", VA = "0x184B64F20")]
	private void DGDIICDBBBK(Type HCPDGKICMEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface HFBLOEHGIOL<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HNMPINFIMAB(int DGOFBPBLNGG);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::BGGCDGNEJCN<BaseClass> HAEOCPPAGLH();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class GHIOHHHNFPK : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0")]
	protected GHIOHHHNFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class CHAPJLBBPNB : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0")]
	protected CHAPJLBBPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class OICGEACCMCG : GHIOHHHNFPK
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4B68570", Offset = "0x4B67170", VA = "0x184B68570", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	protected void PCFCKFGIIOI(string JFHNKPIPCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0")]
	protected OICGEACCMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[KHHGHKHGGFN(EOABPLMDMOL.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4B692E0", Offset = "0x4B67EE0", VA = "0x184B692E0")]
		public static ComponentSystemGroup[] KLFELOEBKFB(World DFJHEIJOIKC, DOIJKCLFKNJ NLNKNEBBIJC = DOIJKCLFKNJ.Default, bool DKEDGFOICAA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4B68780", Offset = "0x4B67380", VA = "0x184B68780")]
		private static Type[] BJODBHGPHHK(DOIJKCLFKNJ NLNKNEBBIJC, bool DKEDGFOICAA, ComponentSystemGroup[] KEGLMOCELKG, ComponentSystemGroup LMFPPBOOADF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4B68EB0", Offset = "0x4B67AB0", VA = "0x184B68EB0")]
		private static ComponentSystemGroup[] JIKCFFKNPDO(World DFJHEIJOIKC, out ComponentSystemGroup LMFPPBOOADF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4B694B0", Offset = "0x4B680B0", VA = "0x184B694B0")]
		internal static bool OPMDKHNMOGD(ICDFCBCPDHG PELMCJBBFEG, out CEAFPJPJKHJ DALELKDJLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4B691B0", Offset = "0x4B67DB0", VA = "0x184B691B0")]
		private static ComponentSystemGroup KGFNDCHODKM(Type HCPDGKICMEB, World DFJHEIJOIKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4B693B0", Offset = "0x4B67FB0", VA = "0x184B693B0")]
		private static ComponentSystemGroup[] NJAJGHDNOML(Type[] GMEAGHGEJOI, World DFJHEIJOIKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4B68A80", Offset = "0x4B67680", VA = "0x184B68A80")]
		internal static void COLNPMOILKD(World DFJHEIJOIKC, Type[] GLAKEELGKJP, ComponentSystemGroup[] KEGLMOCELKG, ComponentSystemGroup LMFPPBOOADF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4B69280", Offset = "0x4B67E80", VA = "0x184B69280")]
		internal static bool KJOOCMANEOL(ComponentSystemBase IIIOAELMNKN, ComponentSystemGroup[] KEGLMOCELKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4B69150", Offset = "0x4B67D50", VA = "0x184B69150")]
		private static void JMMOAEHIIEH(ComponentSystemGroup[] KEGLMOCELKG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct MALEODHLDEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly Dictionary<Type, List<Type>> AANLEAJIPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly HashSet<Type> KIMBEGNMEAJ;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6097B0", Offset = "0x6083B0", VA = "0x1806097B0")]
	public MALEODHLDEK(Dictionary<Type, List<Type>> AANLEAJIPHN, HashSet<Type> KIMBEGNMEAJ)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[KHHGHKHGGFN(EOABPLMDMOL.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class IDABNPMOFLE : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6F53E0", Offset = "0x6F3FE0", VA = "0x1806F53E0")]
			[DebuggerHidden]
			public IDABNPMOFLE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x4B665D0", Offset = "0x4B651D0", VA = "0x184B665D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x4B66320", Offset = "0x4B64F20", VA = "0x184B66320", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x4B66680", Offset = "0x4B65280", VA = "0x184B66680")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x4B66580", Offset = "0x4B65180", VA = "0x184B66580", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x4B664D0", Offset = "0x4B650D0", VA = "0x184B664D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x4B664D0", Offset = "0x4B650D0", VA = "0x184B664D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct MJNBJPFLBCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Type FGBMNPBMECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private DOIJKCLFKNJ NLNKNEBBIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool DLPGDMKJNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool CPFOGFPGFMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool DKEDGFOICAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IEnumerable<Type> LHCICNPJBIO;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4B6A360", Offset = "0x4B68F60", VA = "0x184B6A360")]
		public static RRFilterWorldSystems NEKFKHFNPIG()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4B6A390", Offset = "0x4B68F90", VA = "0x184B6A390")]
		public RRFilterWorldSystems PEIMCAHEAKC(DOIJKCLFKNJ PELMCJBBFEG)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4B69720", Offset = "0x4B68320", VA = "0x184B69720")]
		public RRFilterWorldSystems BENOPBMJGAH(IEnumerable<Type> GMEAGHGEJOI)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4B69D50", Offset = "0x4B68950", VA = "0x184B69D50")]
		public RRFilterWorldSystems COABNEPGNEN(bool HILPGDNBMJK)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4B69E40", Offset = "0x4B68A40", VA = "0x184B69E40")]
		public RRFilterWorldSystems IFNDKBIOEIG(bool IHNAILDNALO)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4B69CC0", Offset = "0x4B688C0", VA = "0x184B69CC0")]
		public MALEODHLDEK CGIFEFJHGFE(Type[] KOMOMBLFFEH)
		{
			return default(MALEODHLDEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4B69FC0", Offset = "0x4B68BC0", VA = "0x184B69FC0")]
		[IteratorStateMachine(typeof(IDABNPMOFLE))]
		internal IEnumerable<Type> KAIPEOFODMD(IEnumerable<Type> GMEAGHGEJOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4B6A050", Offset = "0x4B68C50", VA = "0x184B6A050")]
		internal Dictionary<Type, List<Type>> MBLHNCMDPGN(IEnumerable<Type> GMEAGHGEJOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4B69D60", Offset = "0x4B68960", VA = "0x184B69D60")]
		private void DOIOJFMEAEL(Dictionary<Type, List<Type>> PPLIDDKCFMM, Type HCPDGKICMEB, Type APGPKDENFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4B69E50", Offset = "0x4B68A50", VA = "0x184B69E50")]
		internal HashSet<Type> IIEOPOLCLKC(IEnumerable<Type> KEGLMOCELKG, Dictionary<Type, List<Type>> MIFOEAMJCKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4B69760", Offset = "0x4B68360", VA = "0x184B69760")]
		internal bool CBLJCCNHMMB(Type HCPDGKICMEB, DOIJKCLFKNJ NLNKNEBBIJC, bool DKEDGFOICAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4B6A3A0", Offset = "0x4B68FA0", VA = "0x184B6A3A0")]
		[CompilerGenerated]
		internal static void PPNEIKGNDHO(Type HCPDGKICMEB, ref MJNBJPFLBCH P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class COBMBNKNJDJ
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static bool LNOJIAHLGAM;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4B64B70", Offset = "0x4B63770", VA = "0x184B64B70")]
	public static void CMEOLNMPNEL(bool PPDFINNPBCJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4B64BC0", Offset = "0x4B637C0", VA = "0x184B64BC0")]
	private static void ENMIHOIMDCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class CDGAJGIEBKA
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4B64A90", Offset = "0x4B63690", VA = "0x184B64A90")]
	public static ulong ELBCDEMMGDP(Type HCPDGKICMEB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4B649E0", Offset = "0x4B635E0", VA = "0x184B649E0")]
	public static ulong ELBCDEMMGDP(string HPCADJDKLPN)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[KHHGHKHGGFN(EOABPLMDMOL.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private struct MAGAOKLBJJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public readonly ulong NFEBGMKGAAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public readonly ulong GMFOALMDIJO;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xDB4450", Offset = "0xDB3050", VA = "0x180DB4450")]
			public MAGAOKLBJJF(ulong ODMJFNHDAOP, ulong EGMELFCEFDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x4B67B90", Offset = "0x4B66790", VA = "0x184B67B90", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static Dictionary<ulong, int> EIKAPOLFHBP;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static MAGAOKLBJJF[] EMBLGGFDALN;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static bool LNOJIAHLGAM;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4B6A8F0", Offset = "0x4B694F0", VA = "0x184B6A8F0")]
		public static ulong DPHOPKPDJBJ(int DGOFBPBLNGG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4B6A950", Offset = "0x4B69550", VA = "0x184B6A950")]
		public static int ILJBAOKKBOG(ulong EGMELFCEFDC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4B6A730", Offset = "0x4B69330", VA = "0x184B6A730")]
		public static void CMEOLNMPNEL(bool PPDFINNPBCJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4B6A660", Offset = "0x4B69260", VA = "0x184B6A660")]
		private static void BAKCOBKMPDH(int CPOLNONNEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4B6AD30", Offset = "0x4B69930", VA = "0x184B6AD30")]
		private static void NKFLIOPBKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4B6A580", Offset = "0x4B69180", VA = "0x184B6A580")]
		private static MAGAOKLBJJF AMFACGNGKLK(Type HCPDGKICMEB)
		{
			return default(MAGAOKLBJJF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4B6ACC0", Offset = "0x4B698C0", VA = "0x184B6ACC0")]
		private static ulong MLMGKAICIBG(Type HCPDGKICMEB, ulong EGMELFCEFDC)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4B6A9F0", Offset = "0x4B695F0", VA = "0x184B6A9F0")]
		private static void JHHMCKGFBCE(in MAGAOKLBJJF INMLAOJGEKF, TypeManager.TypeInfo NPLAMPLIGIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4B6B030", Offset = "0x4B69C30", VA = "0x184B6B030")]
		private static void ONHFMPELFGG(MAGAOKLBJJF NPLAMPLIGIB, int DGOFBPBLNGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4B6ABE0", Offset = "0x4B697E0", VA = "0x184B6ABE0")]
		private static void JHLLAIGNBCA(MAGAOKLBJJF NPLAMPLIGIB, int DGOFBPBLNGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4B6B120", Offset = "0x4B69D20", VA = "0x184B6B120")]
		private static MAGAOKLBJJF PBNDDDIBAEI(int DGOFBPBLNGG)
		{
			return default(MAGAOKLBJJF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x4B6A720", Offset = "0x4B69320", VA = "0x184B6A720")]
		private static int BCCNEAOGABL(int DGOFBPBLNGG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class NJMOJFPNJDG
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly CBKEAKMMKNJ EHFDICDCBBI;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly JEFKJJIGPDI ILFEGFELCII;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly AOINJCNEMMB JDCBLOONOEN;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly List<Type> EAIFFOMIIJO;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static bool LNOJIAHLGAM;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	internal static global::HFBLOEHGIOL<EFCKPAPAFFN> MEEDMNDLGII
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4B68210", Offset = "0x4B66E10", VA = "0x184B68210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal static global::HFBLOEHGIOL<PPFMHAEEBEC> CKILALBCMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4B682E0", Offset = "0x4B66EE0", VA = "0x184B682E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	internal static global::HFBLOEHGIOL<CHPIMBEBNAB> DNFMACEKOGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4B67D90", Offset = "0x4B66990", VA = "0x184B67D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4B67DF0", Offset = "0x4B669F0", VA = "0x184B67DF0")]
	public static void CMEOLNMPNEL(bool PPDFINNPBCJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4B68270", Offset = "0x4B66E70", VA = "0x184B68270")]
	public static Type[] NJONNCKLEAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class BDFGECOLNKC
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly Dictionary<int, int> NNEOBPMKDKI;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool LNOJIAHLGAM;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4B64600", Offset = "0x4B63200", VA = "0x184B64600")]
	public static int MCBCNNLNFHN(int DGOFBPBLNGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4B64510", Offset = "0x4B63110", VA = "0x184B64510")]
	public static void CMEOLNMPNEL(bool PPDFINNPBCJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4B64700", Offset = "0x4B63300", VA = "0x184B64700")]
	private static void PGOOKFGEMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4B645B0", Offset = "0x4B631B0", VA = "0x184B645B0")]
	private static int HPIKLNIICKI(Type HCPDGKICMEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4B64690", Offset = "0x4B63290", VA = "0x184B64690")]
	private static void MNHBKLHOOAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class IMONMIBPEJJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly World DFJHEIJOIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly World KJLAAKPMFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly DMFKDOOKGAJ JHMAEGCBJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly ComponentSystemGroup[] KEGLMOCELKG;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public World ADPEJAKCDFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public World EFBFALBAFIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EntityManager OOLEAOGIJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x115C660", Offset = "0x115B260", VA = "0x18115C660")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DMFKDOOKGAJ AAEMACHOPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public global::BGGCDGNEJCN<EFCKPAPAFFN> MEEDMNDLGII
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x60CA30", Offset = "0x60B630", VA = "0x18060CA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x71C880", Offset = "0x71B480", VA = "0x18071C880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public global::BGGCDGNEJCN<PPFMHAEEBEC> CKILALBCMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E5010", Offset = "0x5E3C10", VA = "0x1805E5010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E5020", Offset = "0x5E3C20", VA = "0x1805E5020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public global::BGGCDGNEJCN<CHPIMBEBNAB> DNFMACEKOGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5F7D70", Offset = "0x5F6970", VA = "0x1805F7D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x67EFC0", Offset = "0x67DBC0", VA = "0x18067EFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> GBKMFNDEMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1C58170", Offset = "0x1C56D70", VA = "0x181C58170")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4B66950", Offset = "0x4B65550", VA = "0x184B66950")]
	public static IMONMIBPEJJ FPEFGECBIIN(string AMDKCMALAFD, ICDFCBCPDHG PELMCJBBFEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4B66FA0", Offset = "0x4B65BA0", VA = "0x184B66FA0")]
	public IMONMIBPEJJ(string AMDKCMALAFD, ICDFCBCPDHG PELMCJBBFEG = ICDFCBCPDHG.Simulation, DOIJKCLFKNJ NLNKNEBBIJC = DOIJKCLFKNJ.Default, bool PPDFINNPBCJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4B66930", Offset = "0x4B65530", VA = "0x184B66930")]
	public ComponentSystemBase FEKODGHOCPM(Type HCPDGKICMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x33DE3B0", Offset = "0x33DCFB0", VA = "0x1833DE3B0")]
	public T FEKODGHOCPM<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4B666D0", Offset = "0x4B652D0", VA = "0x184B666D0")]
	public void CFJDGPDNINL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4B66E80", Offset = "0x4B65A80", VA = "0x184B66E80")]
	public void MCDGPGJDKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4B66AF0", Offset = "0x4B656F0", VA = "0x184B66AF0")]
	public void KEODMLPJJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4B66F40", Offset = "0x4B65B40", VA = "0x184B66F40")]
	public void NPEOEGLJKCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4B66A30", Offset = "0x4B65630", VA = "0x184B66A30")]
	public void JJOOCMKMELE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4B66C60", Offset = "0x4B65860", VA = "0x184B66C60")]
	public void LEPNDECFFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4B669D0", Offset = "0x4B655D0", VA = "0x184B669D0")]
	public void IDHBFCGNKME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4B66A90", Offset = "0x4B65690", VA = "0x184B66A90")]
	public void JPECCCJKFMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4B667A0", Offset = "0x4B653A0", VA = "0x184B667A0")]
	internal void EHJIAPPHIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4B668A0", Offset = "0x4B654A0", VA = "0x184B668A0")]
	private bool EPFKCLEJIGH(ComponentSystemGroup DLDMJAINBHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4B66CE0", Offset = "0x4B658E0", VA = "0x184B66CE0")]
	private void LKEPAIMMBPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4B66B50", Offset = "0x4B65750", VA = "0x184B66B50")]
	private ComponentSystemGroup[] KLFELOEBKFB(DOIJKCLFKNJ NLNKNEBBIJC, bool DKEDGFOICAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4B66EE0", Offset = "0x4B65AE0", VA = "0x184B66EE0")]
	public void NCHFPGIOPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4B66730", Offset = "0x4B65330", VA = "0x184B66730", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
public enum ICDFCBCPDHG
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
public sealed class NGDBIDODKJO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public DOIJKCLFKNJ NPEIKOAHLHI;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Flags]
public enum DOIJKCLFKNJ
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
public interface CEAFPJPJKHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	Type JJCLBEPLDKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Type[] LPGANPPJHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class GAFHEOMIIPJ : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public virtual bool ANHFNNKMJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FE0", Offset = "0x5E3BE0", VA = "0x1805E4FE0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	protected GAFHEOMIIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[DisableAutoCreation]
public sealed class EFDMBJFEKAM : GAFHEOMIIPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public EFDMBJFEKAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DisableAutoCreation]
public sealed class HEMIJONFJFJ : GAFHEOMIIPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public HEMIJONFJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[DisableAutoCreation]
public sealed class IHMCNACMGCH : GAFHEOMIIPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public IHMCNACMGCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DisableAutoCreation]
public sealed class CPHPIILMJPB : GAFHEOMIIPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public CPHPIILMJPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DisableAutoCreation]
public sealed class JOMBINEMLFI : GAFHEOMIIPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public JOMBINEMLFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DisableAutoCreation]
public sealed class ABOMDPJBFJJ : GAFHEOMIIPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public override bool ANHFNNKMJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public ABOMDPJBFJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[AttributeUsage(AttributeTargets.Class)]
public class EBHLIKGFBFJ : COFBBNAOLMK
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public EBHLIKGFBFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class GMGEAKCLIOO
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate void PLEOMECBEMN<From, To>(From HOMNJBLAHAL, ref To DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class HEKOHBFEMJA<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static PLEOMECBEMN<From, To> HPIPMEAFDPK;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public HEKOHBFEMJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4B659C0", Offset = "0x4B645C0", VA = "0x184B659C0")]
	static GMGEAKCLIOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x30B0CB0", Offset = "0x30AF8B0", VA = "0x1830B0CB0")]
	public static void CCPJENIAPHJ<T>(PLEOMECBEMN<T, T> FFAAGDDDCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x30B0B00", Offset = "0x30AF700", VA = "0x1830B0B00")]
	public static void CCPJENIAPHJ<From, To>(PLEOMECBEMN<From, To> FFAAGDDDCLN, PLEOMECBEMN<To, From> IFBFBLJIOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x30B0AB0", Offset = "0x30AF6B0", VA = "0x1830B0AB0")]
	public static void CCPJENIAPHJ<From, To>(PLEOMECBEMN<From, To> HPIPMEAFDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x218A010", Offset = "0x2188C10", VA = "0x18218A010")]
	public static PLEOMECBEMN<From, To> IECAAOIFEBB<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x30B3140", Offset = "0x30B1D40", VA = "0x1830B3140")]
	public static void HOBKAINGHLD<From, To>(From HOMNJBLAHAL, ref To DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class OBMBDPDKGND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> GEINPGGAMME;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0xD5CB80", Offset = "0xD5B780", VA = "0x180D5CB80")]
	public OBMBDPDKGND(NativeArray<EntityRemapUtility.EntityRemapInfo> GEINPGGAMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2275400", Offset = "0x2274000", VA = "0x182275400")]
	public Entity KCHCMEMCLPD(Entity CHFHFNDILMF)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class JHLEGMNGOOI
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Dictionary<(ulong hash, uint version), string> ADDIFPFHBAF;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4B67540", Offset = "0x4B66140", VA = "0x184B67540")]
	public static bool MHONHJPELPC(ulong CAGODHOHMPP, uint PGLJOAGFHIO, out string AMDKCMALAFD)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[KHHGHKHGGFN(EOABPLMDMOL.Serialization, new string[] { "Timing", "Deprecated", "Types", "Archetypes" })]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private struct LDMFLKNGIKP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int LEADIMEMNFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int DBOCDBJDJNH;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x76DD30", Offset = "0x76C930", VA = "0x18076DD30")]
			public LDMFLKNGIKP(int BAOHKIGDOBF, int PGLJOAGFHIO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct NGLFBMGAMIH
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private static Stopwatch OBKMJENDMKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private long GHEBKHBNNDI;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public long DKKNJBIFDEE
			{
				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x4B67C10", Offset = "0x4B66810", VA = "0x184B67C10")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public long EDJOACFBHLC
			{
				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x4B67D20", Offset = "0x4B66920", VA = "0x184B67D20")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x4B67C60", Offset = "0x4B66860", VA = "0x184B67C60")]
			public static NGLFBMGAMIH LGIIPGLLNMC()
			{
				return default(NGLFBMGAMIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private struct GOHHDELNBMB : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public readonly struct CJCKLPLOONF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public unsafe readonly Unity.Entities.Archetype* OJOMBCMAHBO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				public readonly LICHKDFPNCB.NILKGCJOHMF.AJKFANHOFHC NHENFBBMCGN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000078")]
				public readonly OBMBDPDKGND IMPCIAHGEFF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000079")]
				public readonly global::BGGCDGNEJCN<PPFMHAEEBEC> JLNMBMPNDFH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public readonly int MNAGEKOCINK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public readonly int MDKHGGMOCNL;

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x4B64AC0", Offset = "0x4B636C0", VA = "0x184B64AC0")]
				public unsafe CJCKLPLOONF(Unity.Entities.Archetype* OJOMBCMAHBO, LICHKDFPNCB.NILKGCJOHMF.AJKFANHOFHC NHENFBBMCGN, OBMBDPDKGND IMPCIAHGEFF, global::BGGCDGNEJCN<PPFMHAEEBEC> JLNMBMPNDFH, int MNAGEKOCINK, int MDKHGGMOCNL = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x4B64B20", Offset = "0x4B63720", VA = "0x184B64B20")]
				public CJCKLPLOONF(in CJCKLPLOONF CEECNJJKNFO, int MDKHGGMOCNL)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public readonly CJCKLPLOONF[] DDJJEIOCKHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public string[] OKGOFOABPBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public int POOBEKKMHPD;

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x4B661E0", Offset = "0x4B64DE0", VA = "0x184B661E0")]
			public GOHHDELNBMB(CJCKLPLOONF[] DDJJEIOCKHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x4B65E20", Offset = "0x4B64A20", VA = "0x184B65E20", Slot = "4")]
			public void Invoke(int BAOHKIGDOBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x4B65E80", Offset = "0x4B64A80", VA = "0x184B65E80")]
			private void PIECCDCJIPO(in CJCKLPLOONF CEECNJJKNFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x4B65B80", Offset = "0x4B64780", VA = "0x184B65B80")]
			private static void CJACEBLCBEJ(in CJCKLPLOONF CEECNJJKNFO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class LCLOFMHFJMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public LICHKDFPNCB asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public global::BGGCDGNEJCN<PPFMHAEEBEC> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public LCLOFMHFJMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x4B679F0", Offset = "0x4B665F0", VA = "0x184B679F0")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class KIEBHFKNJKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public LICHKDFPNCB.NILKGCJOHMF.AJKFANHOFHC srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public LCLOFMHFJMC CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public KIEBHFKNJKM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class KJPFPKLEJBH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public KIEBHFKNJKM CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public KJPFPKLEJBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x4B678D0", Offset = "0x4B664D0", VA = "0x184B678D0")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static PEOJNAGCHAI BIIHLFCOHGB;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static PEOJNAGCHAI IBGBLINJHPP;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static PEOJNAGCHAI MINGCAJPKAL;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static PEOJNAGCHAI NKNNEAGLFHF;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static bool BIHFACMFIDF;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static LICHKDFPNCB.NILKGCJOHMF.OFHKPLGPJPO ELKBOBBIJCG;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4B6C160", Offset = "0x4B6AD60", VA = "0x184B6C160")]
		private unsafe static bool EFAMEDKEHHF(Unity.Entities.Archetype* NHDMIJDMMIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4B6D490", Offset = "0x4B6C090", VA = "0x184B6D490")]
		internal unsafe static Unity.Entities.Archetype*[] JCCEEMLCODO(ref Unity.Entities.EntityComponentStore HDACPMJLACO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4B6BCE0", Offset = "0x4B6A8E0", VA = "0x184B6BCE0")]
		public static void DFMHGIHJLOJ(IMONMIBPEJJ DFJHEIJOIKC, out ByteString HNODBNMBHHD, out NativeArray<EntityRemapUtility.EntityRemapInfo> JEIAFELIGAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4B6CB90", Offset = "0x4B6B790", VA = "0x184B6CB90")]
		internal static void IBINNJLABDM(IMONMIBPEJJ DFJHEIJOIKC, LICHKDFPNCB JGNEEPKNCCM, out NativeArray<EntityRemapUtility.EntityRemapInfo> JEIAFELIGAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4B6B230", Offset = "0x4B69E30", VA = "0x184B6B230")]
		private unsafe static UnsafeHashMap<ulong, LDMFLKNGIKP> BBIFDIPKLHK(Unity.Entities.Archetype*[] IEPMJACHLBK)
		{
			return default(UnsafeHashMap<ulong, LDMFLKNGIKP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4B6BD90", Offset = "0x4B6A990", VA = "0x184B6BD90")]
		private static void DMIJLONJDMI(LICHKDFPNCB JGNEEPKNCCM, UnsafeHashMap<ulong, LDMFLKNGIKP> FCIADGENPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4B6B490", Offset = "0x4B6A090", VA = "0x184B6B490")]
		private unsafe static void BKHCIFPOJJF(LICHKDFPNCB JGNEEPKNCCM, Unity.Entities.Archetype*[] IEPMJACHLBK, UnsafeHashMap<ulong, LDMFLKNGIKP> FCIADGENPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4B6D9F0", Offset = "0x4B6C5F0", VA = "0x184B6D9F0")]
		private unsafe static int LEGBJENLPHK(Unity.Entities.Archetype*[] IEPMJACHLBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4B6DB40", Offset = "0x4B6C740", VA = "0x184B6DB40")]
		private unsafe static void OKCJEBHPLAL(LICHKDFPNCB JGNEEPKNCCM, Unity.Entities.Archetype*[] IEPMJACHLBK, global::BGGCDGNEJCN<PPFMHAEEBEC> JLNMBMPNDFH, NativeArray<EntityRemapUtility.EntityRemapInfo> JEIAFELIGAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4B6C6D0", Offset = "0x4B6B2D0", VA = "0x184B6C6D0")]
		private static NativeArray<int> FLOACOIGEEL(LICHKDFPNCB JGNEEPKNCCM)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4B6D640", Offset = "0x4B6C240", VA = "0x184B6D640")]
		private static Memory<EntityArchetype> JHPKDHFHJOD(LICHKDFPNCB JGNEEPKNCCM, NativeArray<int> GMEAGHGEJOI, EntityManager DEFMCCAEPJC, out int BHCCPGBMEOM, out int BBIKJPJOPJH)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4B6DF40", Offset = "0x4B6CB40", VA = "0x184B6DF40")]
		private unsafe static void PBPDFKDGGKK(Unity.Entities.Chunk* PHBDHGHPEBM, ReadOnlySpan<byte> HNODBNMBHHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4B6E210", Offset = "0x4B6CE10", VA = "0x184B6E210")]
		private static void PFLKMOGMPEH(LICHKDFPNCB JGNEEPKNCCM, NativeArray<int> GMEAGHGEJOI, Span<EntityArchetype> IEPMJACHLBK, EntityManager DEFMCCAEPJC, global::BGGCDGNEJCN<PPFMHAEEBEC> JLNMBMPNDFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4B6D970", Offset = "0x4B6C570", VA = "0x184B6D970")]
		private unsafe static void KJFPMGOMLHP(Unity.Entities.Chunk* DGJPCCHKBLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4B6C400", Offset = "0x4B6B000", VA = "0x184B6C400")]
		private unsafe static void FJKKDAIADPA(LICHKDFPNCB.NILKGCJOHMF.AJKFANHOFHC OJOMBCMAHBO, int ACLEBCHMCCF, int HAENHFMIDCC, Unity.Entities.Chunk* PHBDHGHPEBM, LICHKDFPNCB JGNEEPKNCCM, NativeArray<int> GMEAGHGEJOI, global::BGGCDGNEJCN<PPFMHAEEBEC> JLNMBMPNDFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4B6BC50", Offset = "0x4B6A850", VA = "0x184B6BC50")]
		public static void BKPIBDDBHAN(IMONMIBPEJJ DFJHEIJOIKC, in ByteString HNODBNMBHHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4B6B750", Offset = "0x4B6A350", VA = "0x184B6B750")]
		public static void BKPIBDDBHAN(EntityManager DEFMCCAEPJC, global::BGGCDGNEJCN<PPFMHAEEBEC> JLNMBMPNDFH, in ByteString HNODBNMBHHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4B6C8F0", Offset = "0x4B6B4F0", VA = "0x184B6C8F0")]
		private static bool FNBDGLEFAEF(Type HCPDGKICMEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4B6C250", Offset = "0x4B6AE50", VA = "0x184B6C250")]
		private static void FDKFEAIFHLM(TypeManager.TypeInfo NPLAMPLIGIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4B6BFC0", Offset = "0x4B6ABC0", VA = "0x184B6BFC0")]
		private unsafe static int ECFFBCGNACF(Unity.Entities.Archetype*[] IEPMJACHLBK, NativeArray<EntityRemapUtility.EntityRemapInfo> JEIAFELIGAB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4B6DA60", Offset = "0x4B6C660", VA = "0x184B6DA60")]
		private static int MCBCNNLNFHN(int DGOFBPBLNGG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4B6BF20", Offset = "0x4B6AB20", VA = "0x184B6BF20")]
		private static ulong DPHOPKPDJBJ(int DGOFBPBLNGG)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class APPJCLLGDCO
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4B640C0", Offset = "0x4B62CC0", VA = "0x184B640C0")]
	private unsafe static Span<byte> MLNBKIPFBAE(Unity.Entities.Chunk* DGJPCCHKBLD, int MNAGEKOCINK)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x22070F0", Offset = "0x2205CF0", VA = "0x1822070F0")]
	public unsafe static Span<T> LJELONNGDON<T>(Unity.Entities.Chunk* DGJPCCHKBLD, int MNAGEKOCINK)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2207290", Offset = "0x2205E90", VA = "0x182207290")]
	public static Span<T> LJELONNGDON<T>(this ref Unity.Entities.Chunk DGJPCCHKBLD, int MNAGEKOCINK)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4B64060", Offset = "0x4B62C60", VA = "0x184B64060")]
	public unsafe static Span<Entity> HOLIPLHECGF(Unity.Entities.Chunk* DGJPCCHKBLD)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4B64260", Offset = "0x4B62E60", VA = "0x184B64260")]
	public unsafe static void MNHBKLHOOAC(Unity.Entities.Chunk* DGJPCCHKBLD, int MNAGEKOCINK)
	{
	}
}
namespace RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[Preserve]
	internal class _RRAssemblyIndex : GNPHCGOMALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4B6EAE0", Offset = "0x4B6D6E0", VA = "0x184B6EAE0", Slot = "4")]
		public sealed override void PGNCHLHGPKH()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class FFJPKCHAMHH
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static byte[] JNJHEFFMOCP;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int IPFMGPPGOLG;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static int LHFIEOGDAOP;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static BigInteger AMDHHIFBNAO;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FFJPKCHAMHH()
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
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
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
