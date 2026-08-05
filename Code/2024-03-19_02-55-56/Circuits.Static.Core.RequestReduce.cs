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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DE7040", Offset = "0x1DE6040", VA = "0x181DE7040")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E62B0", Offset = "0x7E52B0", VA = "0x1807E62B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E62F0", Offset = "0x7E52F0", VA = "0x1807E62F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate BOOPHCEICIM<TActionKind, TPayload> PHBJOIDOEJK<TActionKind, TSerializedAction, TPayload>(TSerializedAction JFGBKOKCFBO);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface HNDBOIDAPHL<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PBAOJGOHCMJ<object, OAAMPDEOGNE>> IOILAJCLNNK(TDeps DGILCEAPJEB, TRoot HLMIIECLDOF, TSerializedAction JFGBKOKCFBO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class BOLANFIDMMJ<TActionKind, TSerializedAction, TRoot, TDeps> : PHBMKBALCLH where TDeps : GKGPGLIMANN.KLFOOIIIPBL<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps KFNEOPKPPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction LBDKGKPCJNA;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x47EEEF0", Offset = "0x47EDEF0", VA = "0x1847EEEF0")]
	public BOLANFIDMMJ([In] TDeps DGILCEAPJEB, [In] TSerializedAction JFGBKOKCFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x47EECC0", Offset = "0x47EDCC0", VA = "0x1847EECC0", Slot = "7")]
	public override string OJGKBMCMILI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct BOOPHCEICIM<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind CIMFFLDIHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload FLBLIMOFKFG;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x47EF0F0", Offset = "0x47EE0F0", VA = "0x1847EF0F0")]
	internal BOOPHCEICIM(TActionKind IBPPHBFFACA, [In] TPayload CEFJMHIOKFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ODNBJCDEIJH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2913270", Offset = "0x2912270", VA = "0x182913270")]
	public static BOOPHCEICIM<TActionKind, TPayload> NAJBLLJFKKI<TActionKind, TPayload>([In] TActionKind IBPPHBFFACA, [In] TPayload CEFJMHIOKFM)
	{
		return default(BOOPHCEICIM<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<PBAOJGOHCMJ<TOk, TErr>> HCEMOINMPNB<TRoot, TPayload, TOk, TErr>(TRoot HLMIIECLDOF, TPayload CEFJMHIOKFM);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate PBAOJGOHCMJ<TOk, TErr> MABKENEDEEJ<TRoot, TPayload, TOk, TErr>(TRoot HLMIIECLDOF, [In] TPayload CEFJMHIOKFM);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct OFMJOGHJGCD<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : GKGPGLIMANN.KLFOOIIIPBL<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DEJPBFANDNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public OFMJOGHJGCD<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x50B9480", Offset = "0x50B8480", VA = "0x1850B9480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x50B9980", Offset = "0x50B8980", VA = "0x1850B9980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, HNDBOIDAPHL<TSerializedAction, TRoot, TDeps>> JKGPJMNDGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps KFNEOPKPPMN;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x909C10", Offset = "0x908C10", VA = "0x180909C10")]
	internal OFMJOGHJGCD(Dictionary<TActionKind, HNDBOIDAPHL<TSerializedAction, TRoot, TDeps>> HEAOKECONJM, TDeps DGILCEAPJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4072EC0", Offset = "0x4071EC0", VA = "0x184072EC0")]
	[AsyncStateMachine(typeof(OFMJOGHJGCD<, , , >.DEJPBFANDNG))]
	public Task<PBAOJGOHCMJ<object, OAAMPDEOGNE>> IOILAJCLNNK(TRoot HLMIIECLDOF, TSerializedAction JFGBKOKCFBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GKGPGLIMANN
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface KLFOOIIIPBL<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind EMPNDCMFKGE(TSerializedAction AOFEPADBPDL);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ALKPHKDIOOE(TRoot HLMIIECLDOF, TSerializedAction DFHNKDINOMO);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LAOKBCJKOFI(TRoot HLMIIECLDOF, TSerializedAction DFHNKDINOMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2799FF0", Offset = "0x2798FF0", VA = "0x182799FF0")]
	internal static OFMJOGHJGCD<TActionKind, TSerializedAction, TRoot, TDeps> NAJBLLJFKKI<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, HNDBOIDAPHL<TSerializedAction, TRoot, TDeps>> HEAOKECONJM, TDeps DGILCEAPJEB) where TDeps : KLFOOIIIPBL<TActionKind, TSerializedAction, TRoot>
	{
		return default(OFMJOGHJGCD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class BGAHAEBCOII<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, HNDBOIDAPHL<TSerializedAction, TRoot, TDeps>> ELHKPCAJOAC;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	private BGAHAEBCOII(Dictionary<TActionKind, HNDBOIDAPHL<TSerializedAction, TRoot, TDeps>> HEAOKECONJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x47ACAE0", Offset = "0x47ABAE0", VA = "0x1847ACAE0")]
	public static BGAHAEBCOII<TActionKind, TSerializedAction, TRoot, TDeps> NAJBLLJFKKI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct DNEFDDHLONC<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, GKGPGLIMANN.KLFOOIIIPBL<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class CCMOIGIKAEE<TPayload, TOk, TErr> : HNDBOIDAPHL<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, OAAMPDEOGNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly PHBJOIDOEJK<TActionKind, TSerializedAction, TPayload> FDCAKPLHANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MABKENEDEEJ<TRoot, TPayload, TOk, TErr> MJFAPHCNLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool KOOEMNEJBCC;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x443F690", Offset = "0x443E690", VA = "0x18443F690")]
		public CCMOIGIKAEE(PHBJOIDOEJK<TActionKind, TSerializedAction, TPayload> GHECEBFDBJB, MABKENEDEEJ<TRoot, TPayload, TOk, TErr> ADPLEPEMHJL, bool JHGEKONNBIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4B9D3C0", Offset = "0x4B9C3C0", VA = "0x184B9D3C0", Slot = "4")]
		public Task<PBAOJGOHCMJ<object, OAAMPDEOGNE>> IOILAJCLNNK(TDeps DGILCEAPJEB, TRoot HLMIIECLDOF, TSerializedAction JFGBKOKCFBO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class DDJJDHONALE<TPayload, TOk, TErr> : HNDBOIDAPHL<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, OAAMPDEOGNE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct LIMEGKEEDMP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<PBAOJGOHCMJ<object?, OAAMPDEOGNE>> <>t__builder;

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
			public DDJJDHONALE<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private PBAOJGOHCMJ<object?, OAAMPDEOGNE> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<PBAOJGOHCMJ<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3CEF910", Offset = "0x3CEE910", VA = "0x183CEF910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3CEFE80", Offset = "0x3CEEE80", VA = "0x183CEFE80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly PHBJOIDOEJK<TActionKind, TSerializedAction, TPayload> FDCAKPLHANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly HCEMOINMPNB<TRoot, TPayload, TOk, TErr> MJFAPHCNLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool KOOEMNEJBCC;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x443F690", Offset = "0x443E690", VA = "0x18443F690")]
		public DDJJDHONALE(PHBJOIDOEJK<TActionKind, TSerializedAction, TPayload> GHECEBFDBJB, HCEMOINMPNB<TRoot, TPayload, TOk, TErr> ADPLEPEMHJL, bool JHGEKONNBIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x50B36B0", Offset = "0x50B26B0", VA = "0x1850B36B0", Slot = "4")]
		[AsyncStateMachine(typeof(DDJJDHONALE<, , >.LIMEGKEEDMP))]
		public Task<PBAOJGOHCMJ<object, OAAMPDEOGNE>> IOILAJCLNNK(TDeps DGILCEAPJEB, TRoot HLMIIECLDOF, TSerializedAction JFGBKOKCFBO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BGAHAEBCOII<TActionKind, TSerializedAction, TRoot, TDeps> IGABGFMFCDJ;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9452D0", Offset = "0x9442D0", VA = "0x1809452D0")]
	private DNEFDDHLONC(BGAHAEBCOII<TActionKind, TSerializedAction, TRoot, TDeps> ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x50DE610", Offset = "0x50DD610", VA = "0x1850DE610")]
	public static DNEFDDHLONC<TActionKind, TSerializedAction, TRoot, TDeps> NAJBLLJFKKI()
	{
		return default(DNEFDDHLONC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x22D2040", Offset = "0x22D1040", VA = "0x1822D2040")]
	public DNEFDDHLONC<TActionKind, TSerializedAction, TRoot, TDeps> NEHFGKKBCOF<TPayload, TOk, TErr>(TActionKind IBPPHBFFACA, PHBJOIDOEJK<TActionKind, TSerializedAction, TPayload> GHECEBFDBJB, MABKENEDEEJ<TRoot, TPayload, TOk, TErr> ADPLEPEMHJL, bool JHGEKONNBIG = true) where TPayload : notnull where TOk : notnull where TErr : notnull, OAAMPDEOGNE
	{
		return default(DNEFDDHLONC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x22D2040", Offset = "0x22D1040", VA = "0x1822D2040")]
	public DNEFDDHLONC<TActionKind, TSerializedAction, TRoot, TDeps> GKPBIMCDNMD<TPayload, TOk, TErr>(TActionKind IBPPHBFFACA, PHBJOIDOEJK<TActionKind, TSerializedAction, TPayload> GHECEBFDBJB, HCEMOINMPNB<TRoot, TPayload, TOk, TErr> ADPLEPEMHJL, bool JHGEKONNBIG = true) where TPayload : notnull where TOk : notnull where TErr : notnull, OAAMPDEOGNE
	{
		return default(DNEFDDHLONC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x50DE6A0", Offset = "0x50DD6A0", VA = "0x1850DE6A0")]
	public OFMJOGHJGCD<TActionKind, TSerializedAction, TRoot, TDeps> NIKCELCOIAI(TDeps DGILCEAPJEB)
	{
		return default(OFMJOGHJGCD<TActionKind, TSerializedAction, TRoot, TDeps>);
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
