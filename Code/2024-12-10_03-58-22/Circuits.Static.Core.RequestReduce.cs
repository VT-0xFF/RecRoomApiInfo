using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x21839A0", Offset = "0x21825A0", VA = "0x1821839A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate LCLGHMIJKDH<TActionKind, TPayload> LPLLCJBGOGH<TActionKind, TSerializedAction, TPayload>(TSerializedAction AMAECGLECHE);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface ILEAJPFBFCB<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OAMIPODNNBO<object, BDMFJEIOIAD>> BNBKCOCNFCG(TDeps DDNPAGAAIOD, TRoot AHFIDHNOIFE, TSerializedAction AMAECGLECHE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NLOMPJCOKLL<TActionKind, TSerializedAction, TRoot, TDeps> : LJHFFGOEJCA where TDeps : GCIANMOGIHK.GFDMALPGDKJ<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps KPJEAHOHOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction DJGIEGGGPPB;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4679830", Offset = "0x4678430", VA = "0x184679830")]
	public NLOMPJCOKLL([In] TDeps DDNPAGAAIOD, [In] TSerializedAction AMAECGLECHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4679710", Offset = "0x4678310", VA = "0x184679710", Slot = "7")]
	public override string GCHBDOEJPND()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct LCLGHMIJKDH<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind DNHEJJJPHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload INCHGLDPANM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x436AF30", Offset = "0x4369B30", VA = "0x18436AF30")]
	internal LCLGHMIJKDH(TActionKind PBEMJHKEFAJ, [In] TPayload NCPEFDMEFEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PCHPHDDHOJH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1D40", Offset = "0x2FD0940", VA = "0x182FD1D40")]
	public static LCLGHMIJKDH<TActionKind, TPayload> LMDPPDEOAIA<TActionKind, TPayload>([In] TActionKind PBEMJHKEFAJ, [In] TPayload NCPEFDMEFEF)
	{
		return default(LCLGHMIJKDH<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<OAMIPODNNBO<TOk, TErr>> HBNMFKNFODG<TRoot, TPayload, TOk, TErr>(TRoot AHFIDHNOIFE, TPayload NCPEFDMEFEF);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate OAMIPODNNBO<TOk, TErr> CFBJHIMHCPI<TRoot, TPayload, TOk, TErr>(TRoot AHFIDHNOIFE, [In] TPayload NCPEFDMEFEF);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct MGMMBFIBLIA<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : GCIANMOGIHK.GFDMALPGDKJ<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FDJEPFMFAFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<object, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MGMMBFIBLIA<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<OAMIPODNNBO<object, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5D90", Offset = "0x3DF4990", VA = "0x183DF5D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6220", Offset = "0x3DF4E20", VA = "0x183DF6220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, ILEAJPFBFCB<TSerializedAction, TRoot, TDeps>> ILJKJDKOPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps KPJEAHOHOKA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xC7E130", Offset = "0xC7CD30", VA = "0x180C7E130")]
	internal MGMMBFIBLIA(Dictionary<TActionKind, ILEAJPFBFCB<TSerializedAction, TRoot, TDeps>> LNAHEEMLJLC, TDeps DDNPAGAAIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x45B34E0", Offset = "0x45B20E0", VA = "0x1845B34E0")]
	[AsyncStateMachine(typeof(MGMMBFIBLIA<, , , >.FDJEPFMFAFC))]
	public Task<OAMIPODNNBO<object, BDMFJEIOIAD>> BNBKCOCNFCG(TRoot AHFIDHNOIFE, TSerializedAction AMAECGLECHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GCIANMOGIHK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GFDMALPGDKJ<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind CEMGALJKNON(TSerializedAction GMNCELIMKIF);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AOEJEOOBMIJ(TRoot AHFIDHNOIFE, TSerializedAction FNGNLBJEBKM);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IIILCNHMPKA(TRoot AHFIDHNOIFE, TSerializedAction FNGNLBJEBKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E420", Offset = "0x2B8D020", VA = "0x182B8E420")]
	internal static MGMMBFIBLIA<TActionKind, TSerializedAction, TRoot, TDeps> LMDPPDEOAIA<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, ILEAJPFBFCB<TSerializedAction, TRoot, TDeps>> LNAHEEMLJLC, TDeps DDNPAGAAIOD) where TDeps : GFDMALPGDKJ<TActionKind, TSerializedAction, TRoot>
	{
		return default(MGMMBFIBLIA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class MHDHAOOIAEB<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, ILEAJPFBFCB<TSerializedAction, TRoot, TDeps>> AKFNLPANKPB;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	private MHDHAOOIAEB(Dictionary<TActionKind, ILEAJPFBFCB<TSerializedAction, TRoot, TDeps>> LNAHEEMLJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x45BB8C0", Offset = "0x45BA4C0", VA = "0x1845BB8C0")]
	public static MHDHAOOIAEB<TActionKind, TSerializedAction, TRoot, TDeps> LMDPPDEOAIA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct LBJCDMIBGOD<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, GCIANMOGIHK.GFDMALPGDKJ<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class MGFAMPCFBGA<TPayload, TOk, TErr> : ILEAJPFBFCB<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, BDMFJEIOIAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LPLLCJBGOGH<TActionKind, TSerializedAction, TPayload> NIPDPPDNEHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly CFBJHIMHCPI<TRoot, TPayload, TOk, TErr> ECNDIMBEIIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool ABBMLELCOMN;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4586410", Offset = "0x4585010", VA = "0x184586410")]
		public MGFAMPCFBGA(LPLLCJBGOGH<TActionKind, TSerializedAction, TPayload> IFMLPIOEMFD, CFBJHIMHCPI<TRoot, TPayload, TOk, TErr> FHGMAPHGFEM, bool JECBNPICBHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4599FA0", Offset = "0x4598BA0", VA = "0x184599FA0", Slot = "4")]
		public Task<OAMIPODNNBO<object, BDMFJEIOIAD>> BNBKCOCNFCG(TDeps DDNPAGAAIOD, TRoot AHFIDHNOIFE, TSerializedAction AMAECGLECHE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class MCKHHLFIFHB<TPayload, TOk, TErr> : ILEAJPFBFCB<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, BDMFJEIOIAD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct OMMDOJHKINJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<OAMIPODNNBO<object?, BDMFJEIOIAD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public MCKHHLFIFHB<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private OAMIPODNNBO<object?, BDMFJEIOIAD> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<OAMIPODNNBO<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x47CB790", Offset = "0x47CA390", VA = "0x1847CB790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x47CBCC0", Offset = "0x47CA8C0", VA = "0x1847CBCC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly LPLLCJBGOGH<TActionKind, TSerializedAction, TPayload> NIPDPPDNEHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly HBNMFKNFODG<TRoot, TPayload, TOk, TErr> ECNDIMBEIIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool ABBMLELCOMN;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4586410", Offset = "0x4585010", VA = "0x184586410")]
		public MCKHHLFIFHB(LPLLCJBGOGH<TActionKind, TSerializedAction, TPayload> IFMLPIOEMFD, HBNMFKNFODG<TRoot, TPayload, TOk, TErr> FHGMAPHGFEM, bool JECBNPICBHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4585ED0", Offset = "0x4584AD0", VA = "0x184585ED0", Slot = "4")]
		[AsyncStateMachine(typeof(MCKHHLFIFHB<, , >.OMMDOJHKINJ))]
		public Task<OAMIPODNNBO<object, BDMFJEIOIAD>> BNBKCOCNFCG(TDeps DDNPAGAAIOD, TRoot AHFIDHNOIFE, TSerializedAction AMAECGLECHE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly MHDHAOOIAEB<TActionKind, TSerializedAction, TRoot, TDeps> OBDICJNJBFG;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xAE4B40", Offset = "0xAE3740", VA = "0x180AE4B40")]
	private LBJCDMIBGOD(MHDHAOOIAEB<TActionKind, TSerializedAction, TRoot, TDeps> BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4365F90", Offset = "0x4364B90", VA = "0x184365F90")]
	public static LBJCDMIBGOD<TActionKind, TSerializedAction, TRoot, TDeps> LMDPPDEOAIA()
	{
		return default(LBJCDMIBGOD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2C8D4C0", Offset = "0x2C8C0C0", VA = "0x182C8D4C0")]
	public LBJCDMIBGOD<TActionKind, TSerializedAction, TRoot, TDeps> LMHHLEBOOOI<TPayload, TOk, TErr>(TActionKind PBEMJHKEFAJ, LPLLCJBGOGH<TActionKind, TSerializedAction, TPayload> IFMLPIOEMFD, CFBJHIMHCPI<TRoot, TPayload, TOk, TErr> FHGMAPHGFEM, bool JECBNPICBHO = true) where TPayload : notnull where TOk : notnull where TErr : notnull, BDMFJEIOIAD
	{
		return default(LBJCDMIBGOD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2C8D4C0", Offset = "0x2C8C0C0", VA = "0x182C8D4C0")]
	public LBJCDMIBGOD<TActionKind, TSerializedAction, TRoot, TDeps> JOEEJJPLHOC<TPayload, TOk, TErr>(TActionKind PBEMJHKEFAJ, LPLLCJBGOGH<TActionKind, TSerializedAction, TPayload> IFMLPIOEMFD, HBNMFKNFODG<TRoot, TPayload, TOk, TErr> FHGMAPHGFEM, bool JECBNPICBHO = true) where TPayload : notnull where TOk : notnull where TErr : notnull, BDMFJEIOIAD
	{
		return default(LBJCDMIBGOD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4365ED0", Offset = "0x4364AD0", VA = "0x184365ED0")]
	public MGMMBFIBLIA<TActionKind, TSerializedAction, TRoot, TDeps> IJIDNBHBGFH(TDeps DDNPAGAAIOD)
	{
		return default(MGMMBFIBLIA<TActionKind, TSerializedAction, TRoot, TDeps>);
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
