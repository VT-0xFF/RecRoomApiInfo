using System;
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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E92030", Offset = "0x6E91230", VA = "0x186E92030")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E3190", Offset = "0x7E2390", VA = "0x1807E3190")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x17C7540", Offset = "0x17C6740", VA = "0x1817C7540")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class BFIIBCGEGFC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
	public BFIIBCGEGFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class AMJNMHIBJJF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x17C7540", Offset = "0x17C6740", VA = "0x1817C7540")]
	public AMJNMHIBJJF(bool FCAMOMDMDEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class DIKODGKOJKG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x17C7540", Offset = "0x17C6740", VA = "0x1817C7540")]
	public DIKODGKOJKG(bool FCAMOMDMDEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class OFJGCBEKJEH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
	public OFJGCBEKJEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class MIJKHJEOGPC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E91F50", Offset = "0x6E91150", VA = "0x186E91F50")]
	public MIJKHJEOGPC(bool FCAMOMDMDEG, string AIOGCOFGNBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.All)]
public class HCMLPCEGDDN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly string JNLFDIPLAMB;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E3190", Offset = "0x7E2390", VA = "0x1807E3190")]
	public HCMLPCEGDDN(string HBCOIOANGHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HGNIHKPAIPM
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FJPNBDFHOAJ<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public FJPNBDFHOAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2C1AE30", Offset = "0x2C1A030", VA = "0x182C1AE30")]
		internal void NMGKDGOOGEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class MIFBMAFPEPE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public MIFBMAFPEPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x209DE40", Offset = "0x209D040", VA = "0x18209DE40")]
		internal void EDMGCNAIBKI(Task<TResult> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class PKMKHCOKPGD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PKMKHCOKPGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6E921B0", Offset = "0x6E913B0", VA = "0x186E921B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F150", Offset = "0x6E8E350", VA = "0x186E8F150")]
	public static Task<TaskStatus> JFLPGBNGMGP(this Task KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2179620", Offset = "0x2178820", VA = "0x182179620")]
	public static Task<T> MGCCBHBCIID<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6E8EF20", Offset = "0x6E8E120", VA = "0x186E8EF20")]
	public static Task FNKBKGCKNOI(this Task EEILDIKJMBL, CancellationToken FDCOCHLAHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x21787B0", Offset = "0x21779B0", VA = "0x1821787B0")]
	public static Task<TResult> FNKBKGCKNOI<TResult>(this Task<TResult> EEILDIKJMBL, CancellationToken FDCOCHLAHJD) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2179260", Offset = "0x2178460", VA = "0x182179260")]
	public static TaskCompletionSource<TResult> FNKBKGCKNOI<TResult>(this TaskCompletionSource<TResult> HOKLKCIMMOI, CancellationToken FDCOCHLAHJD) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F2A0", Offset = "0x6E8E4A0", VA = "0x186E8F2A0")]
	[DebuggerStepThrough]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(PKMKHCOKPGD))]
	internal static Task<TaskStatus> LOCILMOLNLC(Task JDPAOINOBPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CFENLOCLIID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TimeSpan EDEMGFCBMKD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Action? JFBHMBEAAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DABAMEPEPCN();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HKKDEPEMCDJ();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JBECGDIMPGB();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct MDBHEKEBIOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string HDFPEMDEFEE;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8BADB0", Offset = "0x8B9FB0", VA = "0x1808BADB0")]
	public MDBHEKEBIOB(string NABCGCEIEGG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0")]
	public static string OMHOCPNBHHH(in MDBHEKEBIOB KPIHKJNPOFH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xB32B40", Offset = "0xB31D40", VA = "0x180B32B40")]
	public static MDBHEKEBIOB OMHOCPNBHHH(string JMNBIHILIIC)
	{
		return default(MDBHEKEBIOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E91F00", Offset = "0x6E91100", VA = "0x186E91F00")]
	public string PBALIILNINH(string LFGPCDPDPCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E91E00", Offset = "0x6E91000", VA = "0x186E91E00")]
	public string GIOILJBGMEL(object HGJLONEPADA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct OBKFPJJEEAC<T> : IEquatable<OBKFPJJEEAC<T>>, JGMIOPFGKLF<OBKFPJJEEAC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T HDFPEMDEFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int BBOMBIMAMPK;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x15BD060", Offset = "0x15BC260", VA = "0x1815BD060")]
	public OBKFPJJEEAC(in T NABCGCEIEGG, int NNAODBDJDNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x24DB020", Offset = "0x24DA220", VA = "0x1824DB020")]
	public static bool IJMFMDJGAHN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5FD0", Offset = "0x6E53D0")] in OBKFPJJEEAC<T> NPCLKEGHIKP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E6040", Offset = "0x6E5440")] in OBKFPJJEEAC<T> NCHMBLEIGHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x24DA950", Offset = "0x24D9B50", VA = "0x1824DA950", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E60B0", Offset = "0x6E54B0")] OBKFPJJEEAC<T> JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x24DA850", Offset = "0x24D9A50", VA = "0x1824DA850", Slot = "0")]
	public override bool Equals(object JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x24DA3A0", Offset = "0x24D95A0", VA = "0x1824DA3A0")]
	public bool AGDAPBIFCOO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E6110", Offset = "0x6E5510")] in OBKFPJJEEAC<T> JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x24DABD0", Offset = "0x24D9DD0", VA = "0x1824DABD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x24DBC90", Offset = "0x24DAE90", VA = "0x1824DBC90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x24DB430", Offset = "0x24DA630", VA = "0x1824DB430")]
	public void LOLPJHCGKNM(out T NABCGCEIEGG, out int NNAODBDJDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x24DA5B0", Offset = "0x24D97B0", VA = "0x1824DA5B0")]
	public (T, int) DALMAFGOGNL()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x24DB3E0", Offset = "0x24DA5E0", VA = "0x1824DB3E0", Slot = "5")]
	private bool JDHDECHILJJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E6180", Offset = "0x6E5580")] in OBKFPJJEEAC<T> JMNBIHILIIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GKJMAPMLMJL
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B210", Offset = "0x1E2A410", VA = "0x181E2B210")]
	public static OBKFPJJEEAC<T> HBHNAKPOBBF<T>(in T NABCGCEIEGG, int NNAODBDJDNJ) where T : notnull
	{
		return default(OBKFPJJEEAC<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct CKDLGNFJNCJ : IEquatable<CKDLGNFJNCJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "4")]
	public bool Equals(CKDLGNFJNCJ JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DB70", Offset = "0x6E8CD70", VA = "0x186E8DB70", Slot = "0")]
	public override bool Equals(object JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DBC0", Offset = "0x6E8CDC0", VA = "0x186E8DBC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DBD0", Offset = "0x6E8CDD0", VA = "0x186E8DBD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct IAOLLNEBLAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly FAOLDENDMNC FHABDNLPAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly LHLCMIDIHNF OFDHPNPGEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly AAPNJPAAPCO EDFHPHIIBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly DGHEAIKCMMB HHJNJJEJAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly PHNJFGFNCGO JMMHHPJAHOJ;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly AAPNJPAAPCO HGDFHNKELIL;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly DGHEAIKCMMB NIPJHBPBIBM;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly PHNJFGFNCGO GPIKIJKJLJP;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly IAOLLNEBLAJ LKJHINFHCEL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AIIPHFCAOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6E90A70", Offset = "0x6E8FC70", VA = "0x186E90A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E91040", Offset = "0x6E90240", VA = "0x186E91040")]
	public IAOLLNEBLAJ(in FAOLDENDMNC BJPCCKJGOFN, in LHLCMIDIHNF KKBBFPNNMHA, AAPNJPAAPCO OCNJMDNMGCE, DGHEAIKCMMB DMHGHEKOIJD, PHNJFGFNCGO DJDOAEAOEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E90BB0", Offset = "0x6E8FDB0", VA = "0x186E90BB0")]
	private static string FAEGGLJCJNM(object PPNJOAJJOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10")]
	private static long AFBMGDMLHGG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90")]
	private static string HOIGHMOEBEM(string EPIJKDGDFJN, string? FGHGMBCHLDB, bool AINHHONHKJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E90BF0", Offset = "0x6E8FDF0", VA = "0x186E90BF0")]
	private static IAOLLNEBLAJ JIKNBGIPALI()
	{
		return default(IAOLLNEBLAJ);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OBHKKHMMFKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ulong INBJKEEOGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public long DCEGGCBJDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public double IBLPBOCHPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public uint PPPCHGODIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public uint MKDAFBHMFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int FDPAFLIEDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int MEKBAALJNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float KMFHHMKFOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float NGCLAOGBFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public ushort LBGCOMHGNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public ushort JJGLEAIHFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public ushort BFBJIOFEEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public ushort ACNGJIDMGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public short GIHJFKEABML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public short PEPKPNEHKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public short AKJMFFMMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public short LPJIHCGOOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public char OFMKFAOAIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public char ABLKFNOMHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public char JCOEPDBJCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public char BFBPHEECCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public byte HBDONBBKMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte NDAINHHHINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public byte IAMBALHOAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public byte JKDIBKNEDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public byte DLNLLMILBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte KKEFOKKCKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public byte CKJCGGJEJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public byte NIFFOGIIJMD;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E920C0", Offset = "0x6E912C0", VA = "0x186E920C0")]
	public static OBHKKHMMFKE HBHNAKPOBBF(byte AHBMOFHDCHC, byte NINDHFBDBAA, byte GLOMABECHMG, byte IONJFCHOFIJ, byte GJAHJDKAICB, byte GOPIKKAFMIO, byte BEDGEBLHFBH, byte KECLGMNACMF)
	{
		return default(OBHKKHMMFKE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct FAOLDENDMNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly DDFAAPOKDKO HGKGHJIAHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly PJILNLPIOMK FGDFIEPNGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly DDFAAPOKDKO EFPJHMKCODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly PJILNLPIOMK KJFPONMBJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly DDFAAPOKDKO CLNJKMDPDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly PJILNLPIOMK EPDOAFGPJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly GHKABOAPIKG GMPNOIJACML;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly DDFAAPOKDKO CCKPFBKCJLI;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly PJILNLPIOMK CNJLEECLHKI;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly DDFAAPOKDKO GAGJKKHDBNP;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly PJILNLPIOMK LJLKKPJKEML;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly DDFAAPOKDKO BNLODDALKAF;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly PJILNLPIOMK EHIOHMGEGGN;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly GHKABOAPIKG ABDDJBJJJLI;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly FAOLDENDMNC LKJHINFHCEL;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly DDFAAPOKDKO BBECPMMHEHK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool AIIPHFCAOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6E8DDC0", Offset = "0x6E8CFC0", VA = "0x186E8DDC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C50", Offset = "0x7E4E50", VA = "0x1807E5C50")]
	public FAOLDENDMNC(DDFAAPOKDKO NAHNHLJFPMK, PJILNLPIOMK DMGEGKMBKPN, DDFAAPOKDKO MDICAJMNHCO, PJILNLPIOMK IIKBLHBNCLM, DDFAAPOKDKO PIAKGMNDFEJ, PJILNLPIOMK MCIEJHJHHCB, GHKABOAPIKG GMOOCJNBECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0")]
	private static bool DPBBDNOBHBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void HAKOPEOENHH(string JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0")]
	private static bool MBFJKBAANDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void PKECJKEOGCE(string JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0")]
	private static bool ODBMFDAAKBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void ABFPDEJECJK(string JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void FIFKCIAMIIE(Exception JBOMBKDPEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E170", Offset = "0x6E8D370", VA = "0x186E8E170")]
	private static FAOLDENDMNC JIKNBGIPALI()
	{
		return default(FAOLDENDMNC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0")]
	private static bool ALOGDKGFKHD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E000", Offset = "0x6E8D200", VA = "0x186E8E000")]
	public void GMDPMBHBMHO(object JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E100", Offset = "0x6E8D300", VA = "0x186E8E100")]
	public void IGJAGIEBANG(object JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E2B0", Offset = "0x6E8D4B0", VA = "0x186E8E2B0")]
	public void NIDIKBENFKN(Exception JBOMBKDPEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E070", Offset = "0x6E8D270", VA = "0x186E8E070")]
	public void IGJAGIEBANG(HDHBODPCCNM JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1933050", Offset = "0x1932250", VA = "0x181933050")]
	public void IGJAGIEBANG<T>(T CIKBJELAGAP, KPPKNGOOMPK<T> JPOEHOENKPI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1932F50", Offset = "0x1932150", VA = "0x181932F50")]
	public void GMDPMBHBMHO<T>(in T CIKBJELAGAP, OKPPENFMJJE<T> JPOEHOENKPI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DD40", Offset = "0x6E8CF40", VA = "0x186E8DD40")]
	public bool AIJLBHNOLPB(bool DGFAPLOODCD, string JPOEHOENKPI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class DLECFOIMMNL
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2447170", Offset = "0x2446370", VA = "0x182447170")]
	public static IEnumerable<T> CDGKFOAEOHM<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90")]
	public static T[] HEGNGDJHIHN<T>(params T[] PBHLPHLMCGJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90")]
	public static IEnumerable<T> HPPNCGBFFLH<T>(params T[] PBHLPHLMCGJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1249EC0", Offset = "0x12490C0", VA = "0x181249EC0")]
	public static HashSet<T> CHBBLMBAKOD<T>(params T[] PBHLPHLMCGJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x29D41D0", Offset = "0x29D33D0", VA = "0x1829D41D0")]
	public static KeyValuePair<TKey, TValue> AABPGOIHFNG<TKey, TValue>(in TKey JCEGKCPOPDM, in TValue NABCGCEIEGG) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1249EC0", Offset = "0x12490C0", VA = "0x181249EC0")]
	public static List<T> DAPMPCPGJHJ<T>(IEnumerable<T> JLPNEGMFCHO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[AttributeUsage(AttributeTargets.All)]
public sealed class OAEHNEMGJME : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly string NMLMDCEFAEE;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7E3190", Offset = "0x7E2390", VA = "0x1807E3190")]
	public OAEHNEMGJME(string OFKOJGJGMJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FANKMAJMFBI
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1932C10", Offset = "0x1931E10", VA = "0x181932C10")]
	public static MDBHEKEBIOB DDAJGMMEBML<T>()
	{
		return default(MDBHEKEBIOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1932E20", Offset = "0x1932020", VA = "0x181932E20")]
	public static MDBHEKEBIOB FPEJLOEDENN<T>([CallerMemberName] string JPKENOAMLIN = "") where T : notnull
	{
		return default(MDBHEKEBIOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1932B80", Offset = "0x1931D80", VA = "0x181932B80")]
	public static MDBHEKEBIOB DDAJGMMEBML<T>(this T JBFDNABELLI) where T : notnull
	{
		return default(MDBHEKEBIOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1932CA0", Offset = "0x1931EA0", VA = "0x181932CA0")]
	public static MDBHEKEBIOB FMLOEPMLLON<T>(this T JBFDNABELLI, [CallerMemberName] string JPKENOAMLIN = "") where T : notnull
	{
		return default(MDBHEKEBIOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1932EB0", Offset = "0x19320B0", VA = "0x181932EB0")]
	public static MDBHEKEBIOB FPEJLOEDENN<T>(this T KPIHKJNPOFH, [CallerMemberName] string JPKENOAMLIN = "") where T : notnull
	{
		return default(MDBHEKEBIOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DC00", Offset = "0x6E8CE00", VA = "0x186E8DC00")]
	public static MDBHEKEBIOB FPEJLOEDENN(string ELDBLELOBGL, [CallerMemberName] string JPKENOAMLIN = "")
	{
		return default(MDBHEKEBIOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DC80", Offset = "0x6E8CE80", VA = "0x186E8DC80")]
	public static string LBOCDCBHCII(this object KPIHKJNPOFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[ACMKPIHBDGI]
public delegate long DGHEAIKCMMB();
[Cpp2IlInjected.Token(Token = "0x200001D")]
public delegate void JIPMBINPMPP<T>(in T CIKBJELAGAP);
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class FOEFDABAAPN
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static IAOLLNEBLAJ BMCJDAGKKDA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static IAOLLNEBLAJ MMPELMKKJHA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6E8ED20", Offset = "0x6E8DF20", VA = "0x186E8ED20")]
		get
		{
			return default(IAOLLNEBLAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static FAOLDENDMNC FHABDNLPAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6E8E920", Offset = "0x6E8DB20", VA = "0x186E8E920")]
		get
		{
			return default(FAOLDENDMNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static LHLCMIDIHNF OFDHPNPGEDP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6E8EB90", Offset = "0x6E8DD90", VA = "0x186E8EB90")]
		get
		{
			return default(LHLCMIDIHNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E980", Offset = "0x6E8DB80", VA = "0x186E8E980")]
	public static void FMJDGGOBKCL(in IAOLLNEBLAJ DLNHKCANOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E8EAE0", Offset = "0x6E8DCE0", VA = "0x186E8EAE0")]
	public static void GMDPMBHBMHO(string JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E8EBF0", Offset = "0x6E8DDF0", VA = "0x186E8EBF0")]
	public static void IGJAGIEBANG(string JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1E233B0", Offset = "0x1E225B0", VA = "0x181E233B0")]
	public static void IGJAGIEBANG<T>(T CIKBJELAGAP, KPPKNGOOMPK<T> JPOEHOENKPI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E8ED80", Offset = "0x6E8DF80", VA = "0x186E8ED80")]
	public static void NIDIKBENFKN(Exception JBOMBKDPEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E8ECA0", Offset = "0x6E8DEA0", VA = "0x186E8ECA0")]
	public static string LBOCDCBHCII(object PPNJOAJJOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E8EE00", Offset = "0x6E8E000", VA = "0x186E8EE00")]
	public static long OGMACNFJDBC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E750", Offset = "0x6E8D950", VA = "0x186E8E750")]
	public static bool AIJLBHNOLPB(bool DGFAPLOODCD, string JPOEHOENKPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E830", Offset = "0x6E8DA30", VA = "0x186E8E830")]
	public static double DGEKAACNDDB()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ILCBOEOCDPE : JEBBKHBOEKA
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly JEBBKHBOEKA JHOAALADPKE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DateTime ANCAICGOPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6E910D0", Offset = "0x6E902D0", VA = "0x186E910D0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public ILCBOEOCDPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate)]
public class ACMKPIHBDGI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
	public ACMKPIHBDGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate TResult DABCLNLOMAJ<T, out TResult>(in T CIKBJELAGAP);
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate TResult JNCLEADFIOD<T1, T2, out TResult>(in T1 BPBJGKFLCNL, in T2 CBJDJGJKHMK);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HKKNALNPBMF : CFENLOCLIID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly TimeSpan GIHCDBMDKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly System.Timers.Timer ENNBBCEBKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private TimeSpan JOGKMNMDFDL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public TimeSpan EDEMGFCBMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6E8F560", Offset = "0x6E8E760", VA = "0x186E8F560", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Action? JFBHMBEAAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F9C0", Offset = "0x6E8EBC0", VA = "0x186E8F9C0")]
	[Preserve]
	public HKKNALNPBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F7A0", Offset = "0x6E8E9A0", VA = "0x186E8F7A0")]
	public HKKNALNPBMF(TimeSpan JOGKMNMDFDL, [Optional] Action? BFJFBONNKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F3F0", Offset = "0x6E8E5F0", VA = "0x186E8F3F0", Slot = "7")]
	public void DABAMEPEPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F4F0", Offset = "0x6E8E6F0", VA = "0x186E8F4F0", Slot = "8")]
	public void HKKDEPEMCDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F530", Offset = "0x6E8E730", VA = "0x186E8F530", Slot = "9")]
	public void JBECGDIMPGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8BEB00", Offset = "0x8BDD00", VA = "0x1808BEB00")]
	private void PGFBBMKEAFD(object JBFDNABELLI, ElapsedEventArgs KLDDALOCGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F6B0", Offset = "0x6E8E8B0", VA = "0x186E8F6B0")]
	private static void MCCAALBCLPP(ref TimeSpan HFBNKCNGDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F450", Offset = "0x6E8E650", VA = "0x186E8F450", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[AttributeUsage(AttributeTargets.Class)]
public class FDHBNKNBNCC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
	public FDHBNKNBNCC()
	{
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public class MDIIFFDEIBC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
	public MDIIFFDEIBC(string DMAGCJMPGCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface JEBBKHBOEKA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime ANCAICGOPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct HMAICEKAIGI : IEquatable<HMAICEKAIGI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint KDCJMDAFIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public int HCNMPMEANNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float KBOLLOJOHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public ushort LBGCOMHGNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public ushort JJGLEAIHFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public short GIHJFKEABML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public short PEPKPNEHKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public char OFMKFAOAIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public char ABLKFNOMHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public byte HBDONBBKMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public byte NDAINHHHINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public byte IAMBALHOAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public byte JKDIBKNEDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool GIJKNDDKGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool OGAKJIKNNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool NACGOECANPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool GBOINFKGMMG;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x146B210", Offset = "0x146A410", VA = "0x18146B210")]
	public static HMAICEKAIGI INNIGEIHNMA(uint KJCGBBCMEPN)
	{
		return default(HMAICEKAIGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x146B210", Offset = "0x146A410", VA = "0x18146B210")]
	public static HMAICEKAIGI HONIDGAPGBI(int OGLPDDIEPGN)
	{
		return default(HMAICEKAIGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FAC0", Offset = "0x6E8ECC0", VA = "0x186E8FAC0")]
	public static HMAICEKAIGI GNKDAIDNMIO(float EJLFLNIEHEG)
	{
		return default(HMAICEKAIGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FAD0", Offset = "0x6E8ECD0", VA = "0x186E8FAD0")]
	public static HMAICEKAIGI OICNBIFLNOH(byte AHBMOFHDCHC, byte NINDHFBDBAA, byte GLOMABECHMG, byte IONJFCHOFIJ)
	{
		return default(HMAICEKAIGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FAD0", Offset = "0x6E8ECD0", VA = "0x186E8FAD0")]
	public static HMAICEKAIGI KANCMNBJEFB(bool BOGILIEIBLH, bool CMMDHMODNEA, bool KKPNDKFNMCL, bool CCAEEMCPEMP)
	{
		return default(HMAICEKAIGI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5214370", Offset = "0x5213570", VA = "0x185214370")]
	public static bool IJMFMDJGAHN(HMAICEKAIGI MHFLHKLCNGM, HMAICEKAIGI NKPGENLIMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2CB0", Offset = "0x3AC1EB0", VA = "0x183AC2CB0", Slot = "4")]
	public bool Equals(HMAICEKAIGI JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FA30", Offset = "0x6E8EC30", VA = "0x186E8FA30", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x892930", Offset = "0x891B30", VA = "0x180892930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FAF0", Offset = "0x6E8ECF0", VA = "0x186E8FAF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[HCMLPCEGDDN("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct NODPJPPOKHP<T> : IEquatable<NODPJPPOKHP<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly T HDFPEMDEFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool OAHNIGFPIDF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool DBCKBLLMJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2D79130", Offset = "0x2D78330", VA = "0x182D79130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2D798A0", Offset = "0x2D78AA0", VA = "0x182D798A0")]
	public NODPJPPOKHP(in T NABCGCEIEGG, bool MLGLEPCPGFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2D79310", Offset = "0x2D78510", VA = "0x182D79310")]
	public static bool IJMFMDJGAHN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E64B0", Offset = "0x6E58B0")] in NODPJPPOKHP<T> NPCLKEGHIKP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E6520", Offset = "0x6E5920")] in NODPJPPOKHP<T> NCHMBLEIGHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x24DA950", Offset = "0x24D9B50", VA = "0x1824DA950", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E6590", Offset = "0x6E5990")] NODPJPPOKHP<T> JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2D78D50", Offset = "0x2D77F50", VA = "0x182D78D50", Slot = "0")]
	public override bool Equals(object JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2D78F10", Offset = "0x2D78110", VA = "0x182D78F10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2D79730", Offset = "0x2D78930", VA = "0x182D79730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class EEJFLPCEOFF
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0xF11500", Offset = "0xF10700", VA = "0x180F11500")]
	public static NODPJPPOKHP<T> NDIECJIKPIJ<T>(in T NABCGCEIEGG) where T : notnull
	{
		return default(NODPJPPOKHP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xF113F0", Offset = "0xF105F0", VA = "0x180F113F0")]
	public static NODPJPPOKHP<T?> LLCIFOAFEEI<T>()
	{
		return default(NODPJPPOKHP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0xF112B0", Offset = "0xF104B0", VA = "0x180F112B0")]
	public static bool KIGJDFGOCPH<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E65F0", Offset = "0x6E59F0")] this in NODPJPPOKHP<T> JMGLFLNLODO, [AMJNMHIBJJF(true)] out T NABCGCEIEGG) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface JGMIOPFGKLF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGDAPBIFCOO(in T JMNBIHILIIC);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct LHLCMIDIHNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly AMMALCHHLFO PLGKAJINMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly EKPPMIEACGJ NKBIBHEEBPI;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly AMMALCHHLFO FFKBEFJEKHD;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly EKPPMIEACGJ DHDLMAOAPDA;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly LHLCMIDIHNF LKJHINFHCEL;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool AIIPHFCAOIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E91B10", Offset = "0x6E90D10", VA = "0x186E91B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x949BA0", Offset = "0x948DA0", VA = "0x180949BA0")]
	public LHLCMIDIHNF(AMMALCHHLFO LJECGGCCCFP, EKPPMIEACGJ LGPEBFHCLBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void NCLIFKEGFLA(string JPKENOAMLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void KLNENKFNJNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E91BE0", Offset = "0x6E90DE0", VA = "0x186E91BE0")]
	private static LHLCMIDIHNF JIKNBGIPALI()
	{
		return default(LHLCMIDIHNF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class CLAPOLDHCIC
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2239B70", Offset = "0x2238D70", VA = "0x182239B70")]
	public static bool AGDAPBIFCOO<T, U>(in T KPIHKJNPOFH, in U PPNJOAJJOFF) where T : notnull, JGMIOPFGKLF<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class CPLPNFOKAGB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly EqualityComparer<T> EPHJLJLKNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public T HDFPEMDEFEE;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6D20", Offset = "0x2CA5F20", VA = "0x182CA6D20")]
	public CPLPNFOKAGB(in T NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6500", Offset = "0x2CA5700", VA = "0x182CA6500", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6870", Offset = "0x2CA5A70", VA = "0x182CA6870", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2CA69F0", Offset = "0x2CA5BF0", VA = "0x182CA69F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class KCGNFGBJLEM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long FIKMKHAKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E91520", Offset = "0x6E90720", VA = "0x186E91520")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static long IGDLMFBJGHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E91690", Offset = "0x6E90890", VA = "0x186E91690")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double KDNMHGLHEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6E917A0", Offset = "0x6E909A0", VA = "0x186E917A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double AAPNEBKJJOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6E914C0", Offset = "0x6E906C0", VA = "0x186E914C0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static double DFGJEFBCLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6E913A0", Offset = "0x6E905A0", VA = "0x186E913A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static double GDDLNLBMNBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E91630", Offset = "0x6E90830", VA = "0x186E91630")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6E91580", Offset = "0x6E90780", VA = "0x186E91580")]
	public static double KFDALGDAJDH(long JAAAFBEPDMA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6E91400", Offset = "0x6E90600", VA = "0x186E91400")]
	public static double EBDHJDMNKDK(long JAAAFBEPDMA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6E916F0", Offset = "0x6E908F0", VA = "0x186E916F0")]
	public static double NPDFGGLLEIL(double NOGFHAAAKPA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E91280", Offset = "0x6E90480", VA = "0x186E91280")]
	public static long BAFGLKJBCDJ(long IDAEOLGPOPH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6E914B0", Offset = "0x6E906B0", VA = "0x186E914B0")]
	public static long EOALJMLPKHE(long GFPMGCFMKFN, long JKCMOBEIBKA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6E91180", Offset = "0x6E90380", VA = "0x186E91180")]
	public static double ALMEGILLNDA(long GFPMGCFMKFN, long JKCMOBEIBKA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6E91330", Offset = "0x6E90530", VA = "0x186E91330")]
	public static double CLPLCBKEKFB(long GFPMGCFMKFN, long JKCMOBEIBKA)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[ACMKPIHBDGI]
public delegate void PJILNLPIOMK(string JPOEHOENKPI);
[Cpp2IlInjected.Token(Token = "0x2000031")]
[ACMKPIHBDGI]
public delegate string AAPNJPAAPCO(object PPNJOAJJOFF);
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ACMKPIHBDGI]
public delegate void EKPPMIEACGJ();
[Cpp2IlInjected.Token(Token = "0x2000033")]
public delegate object OKPPENFMJJE<T>(in T LCGFCGNMPHN);
[Cpp2IlInjected.Token(Token = "0x2000034")]
public delegate object HDHBODPCCNM();
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ACMKPIHBDGI]
public delegate string PHNJFGFNCGO(string EPIJKDGDFJN, string? FGHGMBCHLDB, bool AINHHONHKJC);
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ACMKPIHBDGI]
public delegate bool DDFAAPOKDKO();
[Cpp2IlInjected.Token(Token = "0x2000037")]
public delegate object KPPKNGOOMPK<T>(T LCGFCGNMPHN);
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ACMKPIHBDGI]
public delegate void AMMALCHHLFO(string JPKENOAMLIN);
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ACMKPIHBDGI]
public delegate void GHKABOAPIKG(Exception JBOMBKDPEGF);
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
