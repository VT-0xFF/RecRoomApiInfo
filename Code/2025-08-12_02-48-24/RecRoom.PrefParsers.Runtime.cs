using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OOECOAGPKCK : NEDJEPGLGDE<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8843020", Offset = "0x8841620", VA = "0x188843020", Slot = "9")]
	public override string CAELEDFILEL(bool EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8842FC0", Offset = "0x88415C0", VA = "0x188842FC0", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] bool FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8843070", Offset = "0x8841670", VA = "0x188843070")]
	public OOECOAGPKCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class OHCKDCPGFDI : NEDJEPGLGDE<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8842D50", Offset = "0x8841350", VA = "0x188842D50", Slot = "9")]
	public override string CAELEDFILEL(DateTime EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8842CB0", Offset = "0x88412B0", VA = "0x188842CB0", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] DateTime FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8842DE0", Offset = "0x88413E0", VA = "0x188842DE0")]
	public OHCKDCPGFDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LALOIFDLHLG<TEnum> : NEDJEPGLGDE<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type BDFOOGAJCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool CIABBGLHJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] DMJEPOICLBJ;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5687A20", Offset = "0x5686020", VA = "0x185687A20")]
	[Preserve]
	public LALOIFDLHLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5687730", Offset = "0x5685D30", VA = "0x185687730", Slot = "9")]
	public override string CAELEDFILEL(TEnum EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5687650", Offset = "0x5685C50", VA = "0x185687650", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] TEnum FKMNCAKIOFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NOGIFFHONDL<TEnum> : NEDJEPGLGDE<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type BDFOOGAJCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly EMDLCBKILHK JFIFODKBFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool CIABBGLHJIO;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5A04F00", Offset = "0x5A03500", VA = "0x185A04F00")]
	[Preserve]
	public NOGIFFHONDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5A04C00", Offset = "0x5A03200", VA = "0x185A04C00", Slot = "9")]
	public override string CAELEDFILEL(TEnum EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5A046D0", Offset = "0x5A02CD0", VA = "0x185A046D0", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] TEnum FKMNCAKIOFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class HADBJBOPOPG
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, EMDLCBKILHK> EFNLFHBOMCO;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8842060", Offset = "0x8840660", VA = "0x188842060")]
	public static EMDLCBKILHK CMPGDEEJFKL(Type KCIAIPLKCFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class AAPFAIONFIP<T> : NEDJEPGLGDE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3DB2250", Offset = "0x3DB0850", VA = "0x183DB2250", Slot = "9")]
	public override string CAELEDFILEL(T EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x51D6D90", Offset = "0x51D5390", VA = "0x1851D6D90", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] T FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A1F0", Offset = "0x4A387F0", VA = "0x184A3A1F0")]
	public AAPFAIONFIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class IAGNKOGHCBO<TCollection, T> : NEDJEPGLGDE<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly GODPFAGNMEF<T> GBAOONBNNDO;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5212DA0", Offset = "0x52113A0", VA = "0x185212DA0")]
	protected IAGNKOGHCBO(GODPFAGNMEF<T> GBAOONBNNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5212420", Offset = "0x5210A20", VA = "0x185212420", Slot = "9")]
	public override string CAELEDFILEL(TCollection EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x520F460", Offset = "0x520DA60", VA = "0x18520F460", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] TCollection FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection BNODILFEDOK(IEnumerable<T> KAGGBDPGCAH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5212880", Offset = "0x5210E80", VA = "0x185212880", Slot = "12")]
	internal virtual IEnumerable<string> JHCLPFGPPKD(string EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5212910", Offset = "0x5210F10", VA = "0x185212910")]
	[CompilerGenerated]
	private string LDECPBELHPE(T EFGJHINBPCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IHEOFGHBKBE<T> : IAGNKOGHCBO<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x45A4A90", Offset = "0x45A3090", VA = "0x1845A4A90")]
	[Preserve]
	public IHEOFGHBKBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4A43560", Offset = "0x4A41B60", VA = "0x184A43560")]
	[Preserve]
	public IHEOFGHBKBE(GODPFAGNMEF<T> GBAOONBNNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x523ADE0", Offset = "0x52393E0", VA = "0x18523ADE0", Slot = "11")]
	protected override T[] BNODILFEDOK(IEnumerable<T> KAGGBDPGCAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NANAIPBEBMO<T> : IAGNKOGHCBO<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x45A4A90", Offset = "0x45A3090", VA = "0x1845A4A90")]
	[Preserve]
	public NANAIPBEBMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4A43560", Offset = "0x4A41B60", VA = "0x184A43560")]
	[Preserve]
	public NANAIPBEBMO([Optional] GODPFAGNMEF<T> GBAOONBNNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x59C4B90", Offset = "0x59C3190", VA = "0x1859C4B90", Slot = "11")]
	protected override List<T> BNODILFEDOK(IEnumerable<T> KAGGBDPGCAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IMHDGDANCHF<T> : NEDJEPGLGDE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? JDDJGHEBCFL;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x52697B0", Offset = "0x5267DB0", VA = "0x1852697B0")]
	public IMHDGDANCHF(JsonSerializerSettings? BADOMCMFLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5269750", Offset = "0x5267D50", VA = "0x185269750", Slot = "9")]
	public override string CAELEDFILEL(T EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5269690", Offset = "0x5267C90", VA = "0x185269690", Slot = "10")]
	protected override bool AGNKKGCJGPC([NotNull] string EKNLPIEMHNC, [Out] T FKMNCAKIOFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class HLEFBFHLHIM : NEDJEPGLGDE<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8842860", Offset = "0x8840E60", VA = "0x188842860", Slot = "9")]
	public override string CAELEDFILEL(byte EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x88427D0", Offset = "0x8840DD0", VA = "0x1888427D0", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] byte FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x88428C0", Offset = "0x8840EC0", VA = "0x1888428C0")]
	public HLEFBFHLHIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class KCKCPDOBGBO : NEDJEPGLGDE<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8842AE0", Offset = "0x88410E0", VA = "0x188842AE0", Slot = "9")]
	public override string CAELEDFILEL(short EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8842A40", Offset = "0x8841040", VA = "0x188842A40", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] short FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8842B40", Offset = "0x8841140", VA = "0x188842B40")]
	public KCKCPDOBGBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class EOMAPLPKHPN : NEDJEPGLGDE<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8841FC0", Offset = "0x88405C0", VA = "0x188841FC0", Slot = "9")]
	public override string CAELEDFILEL(ushort EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8841F20", Offset = "0x8840520", VA = "0x188841F20", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] ushort FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8842020", Offset = "0x8840620", VA = "0x188842020")]
	public EOMAPLPKHPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LCDKJAGNDCK : NEDJEPGLGDE<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8842C10", Offset = "0x8841210", VA = "0x188842C10", Slot = "9")]
	public override string CAELEDFILEL(int EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8842B80", Offset = "0x8841180", VA = "0x188842B80", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] int FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8842C70", Offset = "0x8841270", VA = "0x188842C70")]
	public LCDKJAGNDCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class BEEDOIODHCL : NEDJEPGLGDE<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x88418E0", Offset = "0x883FEE0", VA = "0x1888418E0", Slot = "9")]
	public override string CAELEDFILEL(uint EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8841850", Offset = "0x883FE50", VA = "0x188841850", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] uint FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8841940", Offset = "0x883FF40", VA = "0x188841940")]
	public BEEDOIODHCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class OMJELEGELCF : NEDJEPGLGDE<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8842EC0", Offset = "0x88414C0", VA = "0x188842EC0", Slot = "9")]
	public override string CAELEDFILEL(long EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8842E20", Offset = "0x8841420", VA = "0x188842E20", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] long FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8842F20", Offset = "0x8841520", VA = "0x188842F20")]
	public OMJELEGELCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class JEGNGAFPHAK : NEDJEPGLGDE<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x88429A0", Offset = "0x8840FA0", VA = "0x1888429A0", Slot = "9")]
	public override string CAELEDFILEL(ulong EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8842900", Offset = "0x8840F00", VA = "0x188842900", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] ulong FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8842A00", Offset = "0x8841000", VA = "0x188842A00")]
	public JEGNGAFPHAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class CCIJLNKLFMK : NEDJEPGLGDE<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8841BA0", Offset = "0x88401A0", VA = "0x188841BA0", Slot = "9")]
	public override string CAELEDFILEL(float EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8841B10", Offset = "0x8840110", VA = "0x188841B10", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] float FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8841C10", Offset = "0x8840210", VA = "0x188841C10")]
	public CCIJLNKLFMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EMDLCBKILHK
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FHNJGABNNDP(object EKNLPIEMHNC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CMNHGCJJDBN([CanBeNull] string EKNLPIEMHNC, [Out] object FKMNCAKIOFK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GODPFAGNMEF<T> : EMDLCBKILHK
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CAELEDFILEL(T EKNLPIEMHNC);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ABLHAGFIIDN([CanBeNull] string EKNLPIEMHNC, [Out] T FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T NPHCDAMDBLP([CanBeNull] string EKNLPIEMHNC, [Optional] T DAKPJNHJLJO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class NEDJEPGLGDE<T> : GODPFAGNMEF<T>, EMDLCBKILHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type IAEJEEEHOBA;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x59D39F0", Offset = "0x59D1FF0", VA = "0x1859D39F0")]
	protected NEDJEPGLGDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x59D3390", Offset = "0x59D1990", VA = "0x1859D3390")]
	private T OBBMHFHPEMF(object NDBJJGOPOFO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string CAELEDFILEL(T EKNLPIEMHNC);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x59D28B0", Offset = "0x59D0EB0", VA = "0x1859D28B0", Slot = "7")]
	public string FHNJGABNNDP(object EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x59D2770", Offset = "0x59D0D70", VA = "0x1859D2770", Slot = "5")]
	public bool ABLHAGFIIDN(string EKNLPIEMHNC, [Out] T FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool AGNKKGCJGPC([NotNull] string EKNLPIEMHNC, [Out] T FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x59D2B50", Offset = "0x59D1150", VA = "0x1859D2B50", Slot = "8")]
	private bool MCJLGFNBKLP(string EKNLPIEMHNC, [Out] object FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x59D3050", Offset = "0x59D1650", VA = "0x1859D3050", Slot = "6")]
	public T NPHCDAMDBLP(string EKNLPIEMHNC, [Optional] T DAKPJNHJLJO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class EDOMBIGBEPN<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GODPFAGNMEF<T> COLNIIHALMI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4A68A80", Offset = "0x4A67080", VA = "0x184A68A80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x421CEA0", Offset = "0x421B4A0", VA = "0x18421CEA0")]
	public static GODPFAGNMEF<TSerialized> IMAGCOIFABH<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4A584D0", Offset = "0x4A56AD0", VA = "0x184A584D0")]
	public static EMDLCBKILHK IMAGCOIFABH(Type EBKDIIAMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4A6B5F0", Offset = "0x4A69BF0", VA = "0x184A6B5F0")]
	private static EMDLCBKILHK POLNDKMNOFM(Type MCCNLLIKKME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4A681F0", Offset = "0x4A667F0", VA = "0x184A681F0")]
	private static EMDLCBKILHK KHHGMBHNAKA(Type MCCNLLIKKME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class NDLKOLLPDJL<TCollection> : IAGNKOGHCBO<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class EAIDINDBKEN : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public string <>3__input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NDLKOLLPDJL<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private GGAJBCLHCIM<StringBuilder> <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private StringBuilder <partBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool <insideQuotes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <i>5__5;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x101AE80", Offset = "0x1019480", VA = "0x18101AE80")]
		[DebuggerHidden]
		public EAIDINDBKEN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x45C43D0", Offset = "0x45C29D0", VA = "0x1845C43D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4A42DB0", Offset = "0x4A413B0", VA = "0x184A42DB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4A43210", Offset = "0x4A41810", VA = "0x184A43210")]
		private void OFOMAIJNFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4A43360", Offset = "0x4A41960", VA = "0x184A43360", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4A43260", Offset = "0x4A41860", VA = "0x184A43260", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4A43330", Offset = "0x4A41930", VA = "0x184A43330", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool HBCNMLJDKLN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x59CF570", Offset = "0x59CDB70", VA = "0x1859CF570")]
	protected NDLKOLLPDJL(bool HBCNMLJDKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x59CF1E0", Offset = "0x59CD7E0", VA = "0x1859CF1E0", Slot = "9")]
	public override string CAELEDFILEL(TCollection EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x59CF4C0", Offset = "0x59CDAC0", VA = "0x1859CF4C0", Slot = "12")]
	[IteratorStateMachine(typeof(NDLKOLLPDJL<>.EAIDINDBKEN))]
	internal override IEnumerable<string> JHCLPFGPPKD(string EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x59CF440", Offset = "0x59CDA40", VA = "0x1859CF440")]
	[CompilerGenerated]
	internal static string CDGKGCNFJLL(StringBuilder ODAFEHBHNNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BGKHPJFPHCI : NDLKOLLPDJL<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8841AC0", Offset = "0x88400C0", VA = "0x188841AC0")]
	[Preserve]
	public BGKHPJFPHCI(bool HBCNMLJDKLN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8841A30", Offset = "0x8840030", VA = "0x188841A30", Slot = "11")]
	protected override List<string> BNODILFEDOK(IEnumerable<string> KAGGBDPGCAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BFJMAGFGELM : NDLKOLLPDJL<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x88419E0", Offset = "0x883FFE0", VA = "0x1888419E0")]
	[Preserve]
	public BFJMAGFGELM(bool HBCNMLJDKLN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8841980", Offset = "0x883FF80", VA = "0x188841980", Slot = "11")]
	protected override string[] BNODILFEDOK(IEnumerable<string> KAGGBDPGCAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class ONLPNNDFNAD : NEDJEPGLGDE<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAFB050", Offset = "0xAF9650", VA = "0x180AFB050", Slot = "9")]
	public override string CAELEDFILEL(string EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8842F60", Offset = "0x8841560", VA = "0x188842F60", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] string FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8842F80", Offset = "0x8841580", VA = "0x188842F80")]
	public ONLPNNDFNAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DJMACFDMAPJ : NEDJEPGLGDE<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8841DC0", Offset = "0x88403C0", VA = "0x188841DC0", Slot = "9")]
	public override string CAELEDFILEL(TimeSpan EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8841C50", Offset = "0x8840250", VA = "0x188841C50", Slot = "10")]
	protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] TimeSpan FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8841EE0", Offset = "0x88404E0", VA = "0x188841EE0")]
	public DJMACFDMAPJ()
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
