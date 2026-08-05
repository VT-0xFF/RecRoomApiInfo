using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F3E0", Offset = "0x6F0D9E0", VA = "0x186F0F3E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x986BA0", Offset = "0x9851A0", VA = "0x180986BA0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x11F2200", Offset = "0x11F0800", VA = "0x1811F2200")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class LALEOADOFJA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
	public LALEOADOFJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class HLBOCLLKMAH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x11F2200", Offset = "0x11F0800", VA = "0x1811F2200")]
	public HLBOCLLKMAH(bool OAGGKKPJEGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class FACIHPGOEDI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x11F2200", Offset = "0x11F0800", VA = "0x1811F2200")]
	public FACIHPGOEDI(bool OAGGKKPJEGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class ADDEPHJGGJM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
	public ADDEPHJGGJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class PAFEPMBGOCL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F470", Offset = "0x6F0DA70", VA = "0x186F0F470")]
	public PAFEPMBGOCL(bool OAGGKKPJEGF, string FDIBIHCDIJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.All)]
public class DFIJCPAOBAF : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly string FMJCBEDBABM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x986BA0", Offset = "0x9851A0", VA = "0x180986BA0")]
	public DFIJCPAOBAF(string MNBBLNHEBBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DAFNMPMHIBJ
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class JNAPLJIKLHB<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public JNAPLJIKLHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2D0A3E0", Offset = "0x2D089E0", VA = "0x182D0A3E0")]
		internal void DCBAMEFODJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class PFONMJFAAAE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public PFONMJFAAAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1F10BA0", Offset = "0x1F0F1A0", VA = "0x181F10BA0")]
		internal void CCFMACJPHEI(Task<TResult> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class BMGAGKEBHHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public Task selfInternal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Exception <ex>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BMGAGKEBHHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F0BD00", Offset = "0x6F0A300", VA = "0x186F0BD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C280", Offset = "0x6F0A880", VA = "0x186F0C280")]
	public static Task<TaskStatus> ABHKJAFGDPI(this Task CDBMADFDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2439C10", Offset = "0x2438210", VA = "0x182439C10")]
	public static Task<T> LBGCHKPBBBG<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C3D0", Offset = "0x6F0A9D0", VA = "0x186F0C3D0")]
	public static Task OMBBNKAHNHD(this Task JDOLHKOIGCI, CancellationToken DCEGGIJLHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x243AFC0", Offset = "0x24395C0", VA = "0x18243AFC0")]
	public static Task<TResult> OMBBNKAHNHD<TResult>(this Task<TResult> JDOLHKOIGCI, CancellationToken DCEGGIJLHGI) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x243BC50", Offset = "0x243A250", VA = "0x18243BC50")]
	public static TaskCompletionSource<TResult> OMBBNKAHNHD<TResult>(this TaskCompletionSource<TResult> BFAMIJBLGJJ, CancellationToken DCEGGIJLHGI) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C600", Offset = "0x6F0AC00", VA = "0x186F0C600")]
	[DebuggerStepThrough]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(BMGAGKEBHHG))]
	internal static Task<TaskStatus> PLHBKEIOFMG(Task OKJCLADHEOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GNBJENNEAME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TimeSpan KLJCHALKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Action? MLGHOFAMNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBLMNIJABOA();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OAMOALKAKAD();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DBLPHEPPIEC();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct EDKHBJFGOBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string INKIKMDHKDA;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x9C1FF0", Offset = "0x9C05F0", VA = "0x1809C1FF0")]
	public EDKHBJFGOBG(string MOLEJFDINLH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000")]
	public static string LBBGOAOJJNO(in EDKHBJFGOBG CDBMADFDGCE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xAC9090", Offset = "0xAC7690", VA = "0x180AC9090")]
	public static EDKHBJFGOBG LBBGOAOJJNO(string FKJGPCABBJN)
	{
		return default(EDKHBJFGOBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CD90", Offset = "0x6F0B390", VA = "0x186F0CD90")]
	public string MBIMCOBDDIA(string AODCBLNIDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CDE0", Offset = "0x6F0B3E0", VA = "0x186F0CDE0")]
	public string OMFLHGDGKIK(object IFIGOIHCFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct PCAAKDOPNBL<T> : IEquatable<PCAAKDOPNBL<T>>, BIMCIIHFHMF<PCAAKDOPNBL<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T INKIKMDHKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int FIFIFGFPIHM;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1F0A500", Offset = "0x1F08B00", VA = "0x181F0A500")]
	public PCAAKDOPNBL(in T MOLEJFDINLH, int OLGOBCPPPBB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1F086A0", Offset = "0x1F06CA0", VA = "0x181F086A0")]
	public static bool BDIEMMGDBNG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EDE20", Offset = "0x6ED220")] in PCAAKDOPNBL<T> CBNLLBDNGLG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EDE90", Offset = "0x6ED290")] in PCAAKDOPNBL<T> FDIDEGFPCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1F08C40", Offset = "0x1F07240", VA = "0x181F08C40", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EDF00", Offset = "0x6ED300")] PCAAKDOPNBL<T> FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1F08CC0", Offset = "0x1F072C0", VA = "0x181F08CC0", Slot = "0")]
	public override bool Equals(object FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1F09D90", Offset = "0x1F08390", VA = "0x181F09D90")]
	public bool OFNDPJHADPI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EDF60", Offset = "0x6ED360")] in PCAAKDOPNBL<T> FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1F091F0", Offset = "0x1F077F0", VA = "0x181F091F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1F0A260", Offset = "0x1F08860", VA = "0x181F0A260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1F09750", Offset = "0x1F07D50", VA = "0x181F09750")]
	public void MGGDHGPEKNI(out T MOLEJFDINLH, out int OLGOBCPPPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1F08F70", Offset = "0x1F07570", VA = "0x181F08F70")]
	public (T, int) GENLEDLCBJM()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1F09660", Offset = "0x1F07C60", VA = "0x181F09660", Slot = "5")]
	private bool MGFEJDNDDKE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EDFD0", Offset = "0x6ED3D0")] in PCAAKDOPNBL<T> FKJGPCABBJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GOOOMMLOGKC
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2B43560", Offset = "0x2B41B60", VA = "0x182B43560")]
	public static PCAAKDOPNBL<T> OGNDBCBGIDA<T>(in T MOLEJFDINLH, int OLGOBCPPPBB) where T : notnull
	{
		return default(PCAAKDOPNBL<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct CMCGOMMIJLE : IEquatable<CMCGOMMIJLE>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "4")]
	public bool Equals(CMCGOMMIJLE FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C1F0", Offset = "0x6F0A7F0", VA = "0x186F0C1F0", Slot = "0")]
	public override bool Equals(object FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C240", Offset = "0x6F0A840", VA = "0x186F0C240", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C250", Offset = "0x6F0A850", VA = "0x186F0C250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct ACEPDGIEPKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly JGGPPBGFMPG CNGJJBEOKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly CAPCOCAFFMB HPEJBMIKLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly BMAOMGEDAKM FMDOMEKHJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly HGOOMBHKOGD OFJHIHFOFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly HGJDHFHLOLD BAPAOEPHDPB;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly BMAOMGEDAKM FBGEGDOCANH;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly HGOOMBHKOGD NNPJIEHNGED;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly HGJDHFHLOLD CDFDICDEPPO;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly ACEPDGIEPKK OPDGLPPADOA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NAOMKKANDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B800", Offset = "0x6F09E00", VA = "0x186F0B800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BC70", Offset = "0x6F0A270", VA = "0x186F0BC70")]
	public ACEPDGIEPKK(in JGGPPBGFMPG IOPJBKGNAFL, in CAPCOCAFFMB DKPLAKNMJJO, BMAOMGEDAKM AIGNFMPGPOA, HGOOMBHKOGD HFBJMAHHPAA, HGJDHFHLOLD OPIMEAAEAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B7C0", Offset = "0x6F09DC0", VA = "0x186F0B7C0")]
	private static string EKNNKDGEION(object NKFOPKJGBEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40")]
	private static long IIOCHJAFPJJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00")]
	private static string DBFNODHCFDG(string NGKEJFEICEP, string? ADMFDBCFFFG, bool KDFMDLIIPAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B6A0", Offset = "0x6F09CA0", VA = "0x186F0B6A0")]
	private static ACEPDGIEPKK DEIGECCALDF()
	{
		return default(ACEPDGIEPKK);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct EPOAJMDFDHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ulong ICGHKPAHELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public long FCHKBGBKNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public double OBMIDFGJAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public uint LONEKOKCFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public uint CNJICNKNNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int GNEFJHECICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int DGBKJEJFNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float LPEHCEBOAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float FDKNJNKCCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public ushort LKPMKCLCBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public ushort JCHHNJOCPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public ushort JHJPCKFMJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public ushort JHNHJEJFBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public short BPPPEOEPIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public short AIKKPJNGIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public short LPKNDMMBAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public short EHCPGJAICBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public char EKIPBGCPBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public char OOJKOBCLEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public char HBCHHPOPBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public char HFBBAAOFHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public byte BLPDHKFIFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte JIIPJNJHOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public byte AAOHLJDIGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public byte OAKMEHCFOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public byte KFOOEHHIBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte EHNOPKDDOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public byte KHABEFMGGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public byte KOLJEMHHLOC;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CEE0", Offset = "0x6F0B4E0", VA = "0x186F0CEE0")]
	public static EPOAJMDFDHJ OGNDBCBGIDA(byte KBPIADEBPOC, byte DOJLLJIABOJ, byte FKBPAGLLMIE, byte GLHBOPJPJMH, byte OMGNFILEGKH, byte GAHHEFMMOGE, byte EBKBECGOODB, byte DKFILHOBAKA)
	{
		return default(EPOAJMDFDHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct JGGPPBGFMPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly JMFMHDLNMON EHMBHCCEELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly KLJNPIBKENH LGDIBPEJNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly JMFMHDLNMON EGKBBEKHBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly KLJNPIBKENH LBKODKGIJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly JMFMHDLNMON FKFKGCAFGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly KLJNPIBKENH NKBNHPGJIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly KNNGAHGLILM EDFAPHJNJPK;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly JMFMHDLNMON DMOLMAGHOBC;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly KLJNPIBKENH GGHMLKOCDPP;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly JMFMHDLNMON KGPGEGPGABK;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly KLJNPIBKENH EDOCDMPOPFB;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly JMFMHDLNMON OJOFIKPJAAI;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly KLJNPIBKENH GHOLOOMGGGJ;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly KNNGAHGLILM ONEKANIEDJA;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly JGGPPBGFMPG OPDGLPPADOA;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly JMFMHDLNMON BDIAAPCNLAF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NAOMKKANDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F0D320", Offset = "0x6F0B920", VA = "0x186F0D320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xCC6BF0", Offset = "0xCC51F0", VA = "0x180CC6BF0")]
	public JGGPPBGFMPG(JMFMHDLNMON JBHIIKFLNLG, KLJNPIBKENH EFBPEBGJDED, JMFMHDLNMON CFKOLKCAMGH, KLJNPIBKENH DDBIAHEENGF, JMFMHDLNMON EMLKHHKCIPH, KLJNPIBKENH BOJOAHDMFNM, KNNGAHGLILM KHIPHLIKMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850")]
	private static bool ACBGDLENMKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void PKAGFNDDPDB(string DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850")]
	private static bool OBJEIAJMONA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void OPOPFAILGMF(string DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850")]
	private static bool HCJCFBIJPPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void BBKLLBGGGCO(string DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void LNJJOABFGEL(Exception DHPILLFJNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D050", Offset = "0x6F0B650", VA = "0x186F0D050")]
	private static JGGPPBGFMPG DEIGECCALDF()
	{
		return default(JGGPPBGFMPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370")]
	private static bool GFDDBDIGEPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D2B0", Offset = "0x6F0B8B0", VA = "0x186F0D2B0")]
	public void ICFDANBOLEC(object DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D190", Offset = "0x6F0B790", VA = "0x186F0D190")]
	public void FGICHBFHLKN(object DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D290", Offset = "0x6F0B890", VA = "0x186F0D290")]
	public void GGGKAIHBEAP(Exception DHPILLFJNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D200", Offset = "0x6F0B800", VA = "0x186F0D200")]
	public void FGICHBFHLKN(ADFBKKKELCG DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2170AB0", Offset = "0x216F0B0", VA = "0x182170AB0")]
	public void FGICHBFHLKN<T>(T JBBIKBFHPNN, DKBMJFHLDJF<T> DPAJDIEBNKM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2170B30", Offset = "0x216F130", VA = "0x182170B30")]
	public void ICFDANBOLEC<T>(in T JBBIKBFHPNN, CPFIGNJOBNM<T> DPAJDIEBNKM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CFD0", Offset = "0x6F0B5D0", VA = "0x186F0CFD0")]
	public bool AHALPBECPMG(bool HCKMADLOLAI, string DPAJDIEBNKM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class CDAOHJKGMII
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xF34720", Offset = "0xF32D20", VA = "0x180F34720")]
	public static IEnumerable<T> GCPAMKONCKD<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00")]
	public static T[] CLFALLPFNNK<T>(params T[] FAAOFJNFBHC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00")]
	public static IEnumerable<T> FKKOBPFNGCO<T>(params T[] FAAOFJNFBHC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x11D8EC0", Offset = "0x11D74C0", VA = "0x1811D8EC0")]
	public static HashSet<T> OKBAAGOKBML<T>(params T[] FAAOFJNFBHC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3094950", Offset = "0x3092F50", VA = "0x183094950")]
	public static KeyValuePair<TKey, TValue> BJONAOINCEF<TKey, TValue>(in TKey BOMEFJIOGGM, in TValue MOLEJFDINLH) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x11D8EC0", Offset = "0x11D74C0", VA = "0x1811D8EC0")]
	public static List<T> KEMPLJEBADA<T>(IEnumerable<T> PBLKKAHMFFL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[AttributeUsage(AttributeTargets.All)]
public sealed class MFHNDIPIEJO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly string NMHMKGECPDK;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x986BA0", Offset = "0x9851A0", VA = "0x180986BA0")]
	public MFHNDIPIEJO(string CMDCMJNCHIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JJDLGDMGNDC
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2171BC0", Offset = "0x21701C0", VA = "0x182171BC0")]
	public static EDKHBJFGOBG OAOFEABCDLC<T>()
	{
		return default(EDKHBJFGOBG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2171970", Offset = "0x216FF70", VA = "0x182171970")]
	public static EDKHBJFGOBG HCFIGKCIABK<T>([CallerMemberName] string ECMAPGHKHFB = "") where T : notnull
	{
		return default(EDKHBJFGOBG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2171C50", Offset = "0x2170250", VA = "0x182171C50")]
	public static EDKHBJFGOBG OAOFEABCDLC<T>(this T OINELIMPDDO) where T : notnull
	{
		return default(EDKHBJFGOBG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x21717F0", Offset = "0x216FDF0", VA = "0x1821717F0")]
	public static EDKHBJFGOBG DHCHAKGGGOO<T>(this T OINELIMPDDO, [CallerMemberName] string ECMAPGHKHFB = "") where T : notnull
	{
		return default(EDKHBJFGOBG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2171A00", Offset = "0x2170000", VA = "0x182171A00")]
	public static EDKHBJFGOBG HCFIGKCIABK<T>(this T CDBMADFDGCE, [CallerMemberName] string ECMAPGHKHFB = "") where T : notnull
	{
		return default(EDKHBJFGOBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D9E0", Offset = "0x6F0BFE0", VA = "0x186F0D9E0")]
	public static EDKHBJFGOBG HCFIGKCIABK(string BDMIPDINBEN, [CallerMemberName] string ECMAPGHKHFB = "")
	{
		return default(EDKHBJFGOBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DA60", Offset = "0x6F0C060", VA = "0x186F0DA60")]
	public static string LDEIPPOALLL(this object CDBMADFDGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[LFJFALKGOOL]
public delegate long HGOOMBHKOGD();
[Cpp2IlInjected.Token(Token = "0x200001D")]
public delegate void NBDOCOAONPO<T>(in T JBBIKBFHPNN);
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class LGHAILGIMOG
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static ACEPDGIEPKK AEHNPLCIFMC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static ACEPDGIEPKK LMAJMFDJGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F1B0", Offset = "0x6F0D7B0", VA = "0x186F0F1B0")]
		get
		{
			return default(ACEPDGIEPKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static JGGPPBGFMPG CNGJJBEOKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F0ED30", Offset = "0x6F0D330", VA = "0x186F0ED30")]
		get
		{
			return default(JGGPPBGFMPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static CAPCOCAFFMB HPEJBMIKLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F0EEC0", Offset = "0x6F0D4C0", VA = "0x186F0EEC0")]
		get
		{
			return default(CAPCOCAFFMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EFD0", Offset = "0x6F0D5D0", VA = "0x186F0EFD0")]
	public static void IOCABBNGJOH(in ACEPDGIEPKK HNCIGEKDMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EF20", Offset = "0x6F0D520", VA = "0x186F0EF20")]
	public static void ICFDANBOLEC(string DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6F0ED90", Offset = "0x6F0D390", VA = "0x186F0ED90")]
	public static void FGICHBFHLKN(string DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xF44990", Offset = "0xF42F90", VA = "0x180F44990")]
	public static void FGICHBFHLKN<T>(T JBBIKBFHPNN, DKBMJFHLDJF<T> DPAJDIEBNKM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EE40", Offset = "0x6F0D440", VA = "0x186F0EE40")]
	public static void GGGKAIHBEAP(Exception DHPILLFJNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F130", Offset = "0x6F0D730", VA = "0x186F0F130")]
	public static string LDEIPPOALLL(object NKFOPKJGBEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F210", Offset = "0x6F0D810", VA = "0x186F0F210")]
	public static long NAKJHLBNOFD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EC50", Offset = "0x6F0D250", VA = "0x186F0EC50")]
	public static bool AHALPBECPMG(bool HCKMADLOLAI, string DPAJDIEBNKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EB60", Offset = "0x6F0D160", VA = "0x186F0EB60")]
	public static double ABPFCBBOPPP()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MOIPKKNLHAC : EFBDGHEJBKN
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly EFBDGHEJBKN HAMPJMKDJOL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DateTime CAFHIAPEAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F330", Offset = "0x6F0D930", VA = "0x186F0F330", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public MOIPKKNLHAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate)]
public class LFJFALKGOOL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
	public LFJFALKGOOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate TResult GPNEDPFOBOH<T, out TResult>(in T JBBIKBFHPNN);
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate TResult MBKONNCJCHM<T1, T2, out TResult>(in T1 BCFPENKGMGH, in T2 FOAJCOGOINJ);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DHHIGIMHJLE : GNBJENNEAME, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly TimeSpan CFDJGLBNAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly System.Timers.Timer MHKBFIBGEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private TimeSpan DNBGCDFFBOI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public TimeSpan KLJCHALKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C750", Offset = "0x6F0AD50", VA = "0x186F0C750", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Action? MLGHOFAMNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x97E0F0", Offset = "0x97C6F0", VA = "0x18097E0F0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CD20", Offset = "0x6F0B320", VA = "0x186F0CD20")]
	[Preserve]
	public DHHIGIMHJLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CB00", Offset = "0x6F0B100", VA = "0x186F0CB00")]
	public DHHIGIMHJLE(TimeSpan DNBGCDFFBOI, [Optional] Action? HBCMENOHFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C970", Offset = "0x6F0AF70", VA = "0x186F0C970", Slot = "7")]
	public void FBLMNIJABOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CA50", Offset = "0x6F0B050", VA = "0x186F0CA50", Slot = "8")]
	public void OAMOALKAKAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C8A0", Offset = "0x6F0AEA0", VA = "0x186F0C8A0", Slot = "9")]
	public void DBLPHEPPIEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA17710", Offset = "0xA15D10", VA = "0x180A17710")]
	private void HNAELCDAPGA(object OINELIMPDDO, ElapsedEventArgs PCEAAKKEACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C9D0", Offset = "0x6F0AFD0", VA = "0x186F0C9D0")]
	private static void IHEOJLGDAAK(ref TimeSpan POFKBBPJKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C8D0", Offset = "0x6F0AED0", VA = "0x186F0C8D0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[AttributeUsage(AttributeTargets.Class)]
public class ONEJPGBFBKC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
	public ONEJPGBFBKC()
	{
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public class PGBBCIKIPBH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
	public PGBBCIKIPBH(string GAOFGDFEEEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EFBDGHEJBKN
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime CAFHIAPEAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct LACNFLCPEGH : IEquatable<LACNFLCPEGH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint DKKNDOKIJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public int LEIAGBGMJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float KCCLBOMGFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public ushort LKPMKCLCBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public ushort JCHHNJOCPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public short BPPPEOEPIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public short AIKKPJNGIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public char EKIPBGCPBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public char OOJKOBCLEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public byte BLPDHKFIFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public byte JIIPJNJHOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public byte AAOHLJDIGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public byte OAKMEHCFOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool DMKICPAPEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool CFLICGOLIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool GOJIBPKNLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool BAILCEHIGHJ;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x19EE800", Offset = "0x19ECE00", VA = "0x1819EE800")]
	public static LACNFLCPEGH APGOAHFJBCL(uint ILFGDFLIKID)
	{
		return default(LACNFLCPEGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x19EE800", Offset = "0x19ECE00", VA = "0x1819EE800")]
	public static LACNFLCPEGH IIDNHLMFAIE(int OLBHAALONPD)
	{
		return default(LACNFLCPEGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DBD0", Offset = "0x6F0C1D0", VA = "0x186F0DBD0")]
	public static LACNFLCPEGH PNJNGHPCMLF(float EJMKNHKGLEE)
	{
		return default(LACNFLCPEGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DB20", Offset = "0x6F0C120", VA = "0x186F0DB20")]
	public static LACNFLCPEGH EHADCNNJABA(byte KBPIADEBPOC, byte DOJLLJIABOJ, byte FKBPAGLLMIE, byte GLHBOPJPJMH)
	{
		return default(LACNFLCPEGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DB20", Offset = "0x6F0C120", VA = "0x186F0DB20")]
	public static LACNFLCPEGH PHBKJFBLAIF(bool MBEDPELPKDH, bool LCFODLKPEIG, bool ALBDOHIOCOK, bool HACHEBBIEGH)
	{
		return default(LACNFLCPEGH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x52D7980", Offset = "0x52D5F80", VA = "0x1852D7980")]
	public static bool BDIEMMGDBNG(LACNFLCPEGH MBOGNALMNPH, LACNFLCPEGH NDCLMFPKHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3BDA010", Offset = "0x3BD8610", VA = "0x183BDA010", Slot = "4")]
	public bool Equals(LACNFLCPEGH FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DB40", Offset = "0x6F0C140", VA = "0x186F0DB40", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9BFD30", Offset = "0x9BE330", VA = "0x1809BFD30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DBE0", Offset = "0x6F0C1E0", VA = "0x186F0DBE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DFIJCPAOBAF("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct PGBDAGMDGBE<T> : IEquatable<PGBDAGMDGBE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly T INKIKMDHKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool CNCIPJMPPLL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool CIPLLPHGAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1F118C0", Offset = "0x1F0FEC0", VA = "0x181F118C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1F11D20", Offset = "0x1F10320", VA = "0x181F11D20")]
	public PGBDAGMDGBE(in T MOLEJFDINLH, bool MEAJCGOAALL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1F10C90", Offset = "0x1F0F290", VA = "0x181F10C90")]
	public static bool BDIEMMGDBNG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE340", Offset = "0x6ED740")] in PGBDAGMDGBE<T> CBNLLBDNGLG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE3B0", Offset = "0x6ED7B0")] in PGBDAGMDGBE<T> FDIDEGFPCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1F08C40", Offset = "0x1F07240", VA = "0x181F08C40", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE420", Offset = "0x6ED820")] PGBDAGMDGBE<T> FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1F11360", Offset = "0x1F0F960", VA = "0x181F11360", Slot = "0")]
	public override bool Equals(object FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1F11650", Offset = "0x1F0FC50", VA = "0x181F11650", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1F11B20", Offset = "0x1F10120", VA = "0x181F11B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FBGBOOIJCBA
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1C61980", Offset = "0x1C5FF80", VA = "0x181C61980")]
	public static PGBDAGMDGBE<T> ECGGMJOMLBN<T>(in T MOLEJFDINLH) where T : notnull
	{
		return default(PGBDAGMDGBE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1C61860", Offset = "0x1C5FE60", VA = "0x181C61860")]
	public static PGBDAGMDGBE<T?> ECDIJAPBKCB<T>()
	{
		return default(PGBDAGMDGBE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1C61A10", Offset = "0x1C60010", VA = "0x181C61A10")]
	public static bool ECIJECOFIPD<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE480", Offset = "0x6ED880")] this in PGBDAGMDGBE<T> JDOLGDKOJNO, [HLBOCLLKMAH(true)] out T MOLEJFDINLH) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BIMCIIHFHMF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OFNDPJHADPI(in T FKJGPCABBJN);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct CAPCOCAFFMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly GHGEFOGHDPK EJLLBNDGNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly DPFJPGOFKOH HOJLKOMKHNE;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly GHGEFOGHDPK MONOGFHKFBF;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly DPFJPGOFKOH CGBDOIOHEGI;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly CAPCOCAFFMB OPDGLPPADOA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool NAOMKKANDIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F0BF90", Offset = "0x6F0A590", VA = "0x186F0BF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0xBEFA40", Offset = "0xBEE040", VA = "0x180BEFA40")]
	public CAPCOCAFFMB(GHGEFOGHDPK DKHMIBABGGL, DPFJPGOFKOH DMPDAFDNJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void HKNJFEAPKJA(string ECMAPGHKHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void BKBBLFHLMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BF00", Offset = "0x6F0A500", VA = "0x186F0BF00")]
	private static CAPCOCAFFMB DEIGECCALDF()
	{
		return default(CAPCOCAFFMB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class KGDDIKDDKOA
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xF38420", Offset = "0xF36A20", VA = "0x180F38420")]
	public static bool OFNDPJHADPI<T, U>(in T CDBMADFDGCE, in U NKFOPKJGBEM) where T : notnull, BIMCIIHFHMF<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class FHPFJHFMMNK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly EqualityComparer<T> OMCMGBMDCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public T INKIKMDHKDA;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2CFB2C0", Offset = "0x2CF98C0", VA = "0x182CFB2C0")]
	public FHPFJHFMMNK(in T MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x391E410", Offset = "0x391CA10", VA = "0x18391E410", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x391EA10", Offset = "0x391D010", VA = "0x18391EA10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x391EBD0", Offset = "0x391D1D0", VA = "0x18391EBD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class PKGEMAJHLKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long GLAMHIPGHBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F7F0", Offset = "0x6F0DDF0", VA = "0x186F0F7F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static long MJJCELBDNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6F0FAC0", Offset = "0x6F0E0C0", VA = "0x186F0FAC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double KJOCKKDKLPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F0FA60", Offset = "0x6F0E060", VA = "0x186F0FA60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double LCBDJAGECGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F720", Offset = "0x6F0DD20", VA = "0x186F0F720")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static double JLJDFMELHDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F780", Offset = "0x6F0DD80", VA = "0x186F0F780")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static double ENOPEIDKBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F0FA00", Offset = "0x6F0E000", VA = "0x186F0FA00")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F0FB20", Offset = "0x6F0E120", VA = "0x186F0FB20")]
	public static double PNPINKCIGGI(long HFODBBOFCPC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F950", Offset = "0x6F0DF50", VA = "0x186F0F950")]
	public static double KPDPCDOHOBG(long HFODBBOFCPC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F670", Offset = "0x6F0DC70", VA = "0x186F0F670")]
	public static double CLLEAEJJJAJ(double BIILLKMHIGI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F5C0", Offset = "0x6F0DBC0", VA = "0x186F0F5C0")]
	public static long CEFKOLHELCM(long MIKGPKAPCMA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F7E0", Offset = "0x6F0DDE0", VA = "0x186F0F7E0")]
	public static long IKELBMPCNJD(long DIOOGPAGGAN, long ELHENGLOKKI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F850", Offset = "0x6F0DE50", VA = "0x186F0F850")]
	public static double KFHLAHNCKNA(long DIOOGPAGGAN, long ELHENGLOKKI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F550", Offset = "0x6F0DB50", VA = "0x186F0F550")]
	public static double BBNKMMCKPAE(long DIOOGPAGGAN, long ELHENGLOKKI)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class CCDAHCJAFAN
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private sealed class DGEHNFHKEGG<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly ISet<T> HAMPJMKDJOL;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int AEJJJIDCFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2DB7B10", Offset = "0x2DB6110", VA = "0x182DB7B10", Slot = "4")]
		public bool Add(T MDCAOIKFJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "6")]
		public void IntersectWith(IEnumerable<T> FKJGPCABBJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2DB7CF0", Offset = "0x2DB62F0", VA = "0x182DB7CF0", Slot = "5")]
		public void UnionWith(IEnumerable<T> FKJGPCABBJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2DB7C20", Offset = "0x2DB6220", VA = "0x182DB7C20", Slot = "9")]
		void ICollection<T>.Add(T MDCAOIKFJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "11")]
		public bool Contains(T MDCAOIKFJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "12")]
		public void CopyTo(T[] IACDCADJJAN, int AJIOAJHCAKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
		public bool Remove(T MDCAOIKFJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2DB7B60", Offset = "0x2DB6160", VA = "0x182DB7B60", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1E718D0", Offset = "0x1E6FED0", VA = "0x181E718D0", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public DGEHNFHKEGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8BD260", Offset = "0x8BB860", VA = "0x1808BD260")]
	public static ISet<T> HHJAABPDMAL<T>() where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[LFJFALKGOOL]
public delegate void KLJNPIBKENH(string DPAJDIEBNKM);
[Cpp2IlInjected.Token(Token = "0x2000033")]
[LFJFALKGOOL]
public delegate string BMAOMGEDAKM(object NKFOPKJGBEM);
[Cpp2IlInjected.Token(Token = "0x2000034")]
[LFJFALKGOOL]
public delegate void DPFJPGOFKOH();
[Cpp2IlInjected.Token(Token = "0x2000035")]
public delegate object CPFIGNJOBNM<T>(in T CHPIMGNELOI);
[Cpp2IlInjected.Token(Token = "0x2000036")]
public delegate object ADFBKKKELCG();
[Cpp2IlInjected.Token(Token = "0x2000037")]
[LFJFALKGOOL]
public delegate string HGJDHFHLOLD(string NGKEJFEICEP, string? ADMFDBCFFFG, bool KDFMDLIIPAH);
[Cpp2IlInjected.Token(Token = "0x2000038")]
[LFJFALKGOOL]
public delegate bool JMFMHDLNMON();
[Cpp2IlInjected.Token(Token = "0x2000039")]
public delegate object DKBMJFHLDJF<T>(T CHPIMGNELOI);
[Cpp2IlInjected.Token(Token = "0x200003A")]
[LFJFALKGOOL]
public delegate void GHGEFOGHDPK(string ECMAPGHKHFB);
[Cpp2IlInjected.Token(Token = "0x200003B")]
[LFJFALKGOOL]
public delegate void KNNGAHGLILM(Exception DHPILLFJNAN);
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
