using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_UGCLocalization_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8E50", Offset = "0x7CB7C50", VA = "0x187CB8E50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[HLDENJBKDHO]
public class IMFNEHPBBLJ : PIEHGCCOPPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class EBKLGOEDLBI
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum MKDHDCHBNLD
		{
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			Needed = 0,
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			Requested = 1,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			Default = 0
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum KEDKCDIKHEA
		{
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			Modified,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			AddedFirstOrRemovedLast
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly HashSet<LFFMJHJMDIJ> OPNONFMGKEN;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public DLLPJGGLINI OKCAJEMOGBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool BKHPHBIJMPH
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7CB09A0", Offset = "0x7CAF7A0", VA = "0x187CB09A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool AIILKEANCLF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7CB09C0", Offset = "0x7CAF7C0", VA = "0x187CB09C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MKDHDCHBNLD GCACAOPMJBI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5DD0", Offset = "0xAB4BD0", VA = "0x180AB5DD0")]
			[CompilerGenerated]
			get
			{
				return default(MKDHDCHBNLD);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xB4A980", Offset = "0xB49780", VA = "0x180B4A980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0D90", Offset = "0x7CAFB90", VA = "0x187CB0D90")]
		public EBKLGOEDLBI(LFFMJHJMDIJ LFPDNPEJLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0BE0", Offset = "0x7CAF9E0", VA = "0x187CB0BE0")]
		public EBKLGOEDLBI(DLLPJGGLINI JBMJNCAPKBN, LFFMJHJMDIJ LFPDNPEJLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0A10", Offset = "0x7CAF810", VA = "0x187CB0A10")]
		public int GALMHKIBKBE(DLLPJGGLINI JBMJNCAPKBN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0A90", Offset = "0x7CAF890", VA = "0x187CB0A90")]
		public KEDKCDIKHEA JDNADPFJBCN(LFFMJHJMDIJ LFPDNPEJLGI)
		{
			return default(KEDKCDIKHEA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0B20", Offset = "0x7CAF920", VA = "0x187CB0B20")]
		public KEDKCDIKHEA NMFIJCLJLCJ(LFFMJHJMDIJ LFPDNPEJLGI)
		{
			return default(KEDKCDIKHEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class KKLGGMBLMAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public KeyValuePair<string, DLLPJGGLINI> pair;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public KKLGGMBLMAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB69B0", Offset = "0x7CB57B0", VA = "0x187CB69B0")]
		internal object JAFENJOFMJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class AKFKDMPHHHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public string localizationKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public IMFNEHPBBLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public EBKLGOEDLBI entry;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public AKFKDMPHHHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF1A0", Offset = "0x7CADFA0", VA = "0x187CAF1A0")]
		internal object NNCAHDPFOMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF150", Offset = "0x7CADF50", VA = "0x187CAF150")]
		internal object MCLHFICOFFL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class CEMCNHOEIIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public long requestorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AKFKDMPHHHP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public CEMCNHOEIIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7CAFA20", Offset = "0x7CAE820", VA = "0x187CAFA20")]
		internal object ELBEHLBFPPD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MGLPBGDLMMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string translationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AKFKDMPHHHP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MGLPBGDLMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7CB77E0", Offset = "0x7CB65E0", VA = "0x187CB77E0")]
		internal object NBKGBMBMADA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class BEDBNJJBBGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public LFFMJHJMDIJ requestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string localizationKey;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public BEDBNJJBBGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF410", Offset = "0x7CAE210", VA = "0x187CAF410")]
		internal object BJDGMFLABKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF4D0", Offset = "0x7CAE2D0", VA = "0x187CAF4D0")]
		internal object DBLLLEOCLCO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FFDAPGPBEIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<List<DLLPJGGLINI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public IMFNEHPBBLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public bool logExceptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private TaskAwaiter<HGBBKLHOHHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0DA0", Offset = "0x7CAFBA0", VA = "0x187CB0DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7CB11F0", Offset = "0x7CAFFF0", VA = "0x187CB11F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class DOGKILGLJFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public List<DLLPJGGLINI> translations;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DOGKILGLJFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0910", Offset = "0x7CAF710", VA = "0x187CB0910")]
		internal object GPGDGOMLJFL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LHDFHKOLOEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public IMFNEHPBBLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IEnumerable<DACMPOAMDBF> persistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private DOGKILGLJFK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<List<DLLPJGGLINI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB6C10", Offset = "0x7CB5A10", VA = "0x187CB6C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB76D0", Offset = "0x7CB64D0", VA = "0x187CB76D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class AECNBKLKCMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public NALMBKNFHEI notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IMFNEHPBBLJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public AECNBKLKCMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF0C0", Offset = "0x7CADEC0", VA = "0x187CAF0C0")]
		internal object MAJBFJKFGHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF030", Offset = "0x7CADE30", VA = "0x187CAF030")]
		internal object JPBBDCFBAEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF0A0", Offset = "0x7CADEA0", VA = "0x187CAF0A0")]
		internal void LAIMKHLGBMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class LKIFGJMBMHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int updatedStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IMFNEHPBBLJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public LKIFGJMBMHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7730", Offset = "0x7CB6530", VA = "0x187CB7730")]
		internal object BDDGPAIGGHF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CGOLDCODDJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IMFNEHPBBLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private LKIFGJMBMHE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<List<DLLPJGGLINI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7CAFAE0", Offset = "0x7CAE8E0", VA = "0x187CAFAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7CB08B0", Offset = "0x7CAF6B0", VA = "0x187CB08B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class PLHBDOGIIKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IMFNEHPBBLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<string> existingTranslations;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public PLHBDOGIIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7CB85D0", Offset = "0x7CB73D0", VA = "0x187CB85D0")]
		internal object ALJDBOOIPAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7CB86D0", Offset = "0x7CB74D0", VA = "0x187CB86D0")]
		internal object FJMIFCCHDCH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct KGAKDOOGJMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public IMFNEHPBBLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public BEPIOHBDIFE serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private PLHBDOGIIKF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Dictionary<string, EBKLGOEDLBI> <neededTranslationLookup>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Guid <nextScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4AB0", Offset = "0x7CB38B0", VA = "0x187CB4AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7CB6950", Offset = "0x7CB5750", VA = "0x187CB6950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct CBHAOLFELGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public IMFNEHPBBLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public HGCCILDLOLL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF520", Offset = "0x7CAE320", VA = "0x187CAF520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF9C0", Offset = "0x7CAE7C0", VA = "0x187CAF9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PNEKGFACNCG CIACCMNJCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly CEFBMPGBCKC LOFJHKDFNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly DDODMENECGH ONNJMGBGFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JPDCMPIABBH JGDMKGHAADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FFKAOHGMCOC PNHLJCBIBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly string ILHLHCHOHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly IDisposable NBAPBCHNOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<string, EBKLGOEDLBI> IHKBJJMHBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Dictionary<string, DLLPJGGLINI> IOCJCHPGEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int MLKGLMLJLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool EEEACHJJFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private long JIFPOPJKFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private long ENMEHBAANCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Guid PGOEJMLJEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool PGLCHBLMLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly bool ABIAJBFJMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool FLFKMHMKBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HashSet<NELJLFHKLDL> IKNIMMGCHCO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal Guid NGNGMFCFEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x44B59B0", Offset = "0x44B47B0", VA = "0x1844B59B0")]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3F10", Offset = "0x7CB2D10", VA = "0x187CB3F10")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long IPJEADBLJAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1F30", Offset = "0x7CB0D30", VA = "0x187CB1F30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string FMNGDDDEIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8FC450", Offset = "0x8FB250", VA = "0x1808FC450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8FC3E0", Offset = "0x8FB1E0", VA = "0x1808FC3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private string CGPHAEMBCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3A90", Offset = "0x7CB2890", VA = "0x187CB3A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal bool PFBIEDPHIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7CB21E0", Offset = "0x7CB0FE0", VA = "0x187CB21E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal bool BDEBCOBKADP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1CD0", Offset = "0x7CB0AD0", VA = "0x187CB1CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal bool JMOEMOOIPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1E50", Offset = "0x7CB0C50", VA = "0x187CB1E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EIDCNPKCBFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1D20", Offset = "0x7CB0B20", VA = "0x187CB1D20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private static EAJIBKCHNNC EHLDEPOENHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3A30", Offset = "0x7CB2830", VA = "0x187CB3A30")]
		get
		{
			return default(EAJIBKCHNNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private int PMOBCCHBFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4060", Offset = "0x7CB2E60", VA = "0x187CB4060")]
	private static void PGPPFIJMMAH(OIKBCHJGEKA KKBJAPCBOHH, EAJIBKCHNNC HGGECPHADJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4110", Offset = "0x7CB2F10", VA = "0x187CB4110")]
	[FOLINPJCBJN.OMHALDBFHHH.KGMEHFIGPOB]
	internal static void PIKBCINMJOC(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7CB43A0", Offset = "0x7CB31A0", VA = "0x187CB43A0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IMFNEHPBBLJ([NotNull][MHFJPMCEEAM(null)] PNEKGFACNCG CIACCMNJCNI, [NotNull][MHFJPMCEEAM(null)] CEFBMPGBCKC LOFJHKDFNLA, [NotNull][MHFJPMCEEAM(null)] DDODMENECGH ONNJMGBGFKL, [MHFJPMCEEAM(null)][NotNull] JPDCMPIABBH JGDMKGHAADE, [MHFJPMCEEAM(null)][NotNull] FFKAOHGMCOC PNHLJCBIBKD, [MHFJPMCEEAM(null)][NotNull] ABHLENGKOMK OKPJNBFDHJK, [MHFJPMCEEAM(null)][NotNull] DDJGAGKAGGH JFNPNLNAOPB, [NotNull][MHFJPMCEEAM(null)] DPIEDOFFLCF HMHLOFOACGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1B50", Offset = "0x7CB0950", VA = "0x187CB1B50", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1730", Offset = "0x7CB0530", VA = "0x187CB1730")]
	private static string ABHNMAPDMPH(Guid PMOIDCJPJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2230", Offset = "0x7CB1030", VA = "0x187CB2230")]
	private Dictionary<string, DLLPJGGLINI> HLKOAGKNEJO(IEnumerable<DLLPJGGLINI> JFDOFPKJNOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3C20", Offset = "0x7CB2A20", VA = "0x187CB3C20")]
	private void OLMNLIHMJAJ(Dictionary<string, DLLPJGGLINI> OIBAJPPDPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7CB25A0", Offset = "0x7CB13A0", VA = "0x187CB25A0")]
	internal static string KDNIOIFPCFH(string ONFJJDGHNJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1E70", Offset = "0x7CB0C70", VA = "0x187CB1E70", Slot = "4")]
	public bool GDALCLJJCDJ(NELJLFHKLDL GHFCPMAJEFM, bool KKHNIMMKCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7CB24C0", Offset = "0x7CB12C0", VA = "0x187CB24C0", Slot = "7")]
	public string JHLDJAIIAFJ(string HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3260", Offset = "0x7CB2060", VA = "0x187CB3260", Slot = "8")]
	public IOOOEBMKPOH LIEMOHBDAFO(string DJFNBBFOAGA, string EDLHCINOAKH, [CanBeNull] LFFMJHJMDIJ LFPDNPEJLGI)
	{
		return default(IOOOEBMKPOH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB17A0", Offset = "0x7CB05A0", VA = "0x187CB17A0", Slot = "9")]
	public void AMLKBLCAPBA(string DJFNBBFOAGA, [NotNull] LFFMJHJMDIJ LFPDNPEJLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB28C0", Offset = "0x7CB16C0", VA = "0x187CB28C0", Slot = "10")]
	public CONNCBNJPHG KKFHOGCOFFG(string DJFNBBFOAGA)
	{
		return default(CONNCBNJPHG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB27C0", Offset = "0x7CB15C0", VA = "0x187CB27C0")]
	[AsyncStateMachine(typeof(FFDAPGPBEIN))]
	private Task<List<DLLPJGGLINI>> KEPKHJLFMCC(bool IPLCEIKJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB23C0", Offset = "0x7CB11C0", VA = "0x187CB23C0")]
	[AsyncStateMachine(typeof(LHDFHKOLOEO))]
	private Task IGEJCNFMEMA(IEnumerable<DACMPOAMDBF> NOOBFGDNPPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2990", Offset = "0x7CB1790", VA = "0x187CB2990")]
	private void LEPAFFAGNFB(NALMBKNFHEI PIOAJJDENPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3190", Offset = "0x7CB1F90", VA = "0x187CB3190")]
	[AsyncStateMachine(typeof(CGOLDCODDJP))]
	private Task LFAMNMGOEHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7CB20C0", Offset = "0x7CB0EC0", VA = "0x187CB20C0", Slot = "11")]
	[AsyncStateMachine(typeof(KGAKDOOGJMD))]
	public Task HGOFKMBNNKN(BEPIOHBDIFE FLIOBDGHCMA, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3FD0", Offset = "0x7CB2DD0", VA = "0x187CB3FD0", Slot = "5")]
	public void PFPMBFOIKHJ(PPNKBAMJHHC BGIEPHNJHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4200", Offset = "0x7CB3000", VA = "0x187CB4200")]
	private void PNPGHAOJCLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3B30", Offset = "0x7CB2930", VA = "0x187CB3B30")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(CBHAOLFELGI))]
	private Task OJMOLJNOBNP(HGCCILDLOLL GNLCLPGKLAJ, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3AD0", Offset = "0x7CB28D0", VA = "0x187CB3AD0")]
	[CompilerGenerated]
	private object OFJDKLKBDNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2000", Offset = "0x7CB0E00", VA = "0x187CB2000")]
	[CompilerGenerated]
	private string HDGKJJNOPGD(DLLPJGGLINI JBMJNCAPKBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1DC0", Offset = "0x7CB0BC0", VA = "0x187CB1DC0")]
	[CompilerGenerated]
	private object FJCJAKJLOME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2510", Offset = "0x7CB1310", VA = "0x187CB2510")]
	[CompilerGenerated]
	private object JPKKPEBGFAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class NMLLEBGBFHM : LFFMJHJMDIJ, IEquatable<LFFMJHJMDIJ>
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long OFAGBBGFDNF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string MENCOOOAIJP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8530", Offset = "0x7CB7330", VA = "0x187CB8530")]
	public NMLLEBGBFHM(long MIFPCBFGGLI, string EDLHCINOAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7CB84C0", Offset = "0x7CB72C0", VA = "0x187CB84C0", Slot = "7")]
	public bool Equals(LFFMJHJMDIJ KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2533780", Offset = "0x2532580", VA = "0x182533780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class MNKGFLFIEBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly PIEHGCCOPPA HFEIDHFGJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private LFFMJHJMDIJ LFPDNPEJLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private bool OMKECBFLMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private string EDLHCINOAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private string HACFGBHNOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool IBMMBPEOGGD;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal long NCHPFLFHGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8350", Offset = "0x7CB7150", VA = "0x187CB8350")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string MENCOOOAIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7B90", Offset = "0x7CB6990", VA = "0x187CB7B90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7BE0", Offset = "0x7CB69E0", VA = "0x187CB7BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7CB83A0", Offset = "0x7CB71A0", VA = "0x187CB83A0")]
	public MNKGFLFIEBI([Optional] PIEHGCCOPPA HLDNIAJEGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8210", Offset = "0x7CB7010", VA = "0x187CB8210")]
	public CONNCBNJPHG IMLBFOMOOKE(NELJLFHKLDL KEKAMFBEIBO)
	{
		return default(CONNCBNJPHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7CA0", Offset = "0x7CB6AA0", VA = "0x187CB7CA0")]
	internal void IGIPDIBMNHA(NELJLFHKLDL FEHNANJJMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8200", Offset = "0x7CB7000", VA = "0x187CB8200")]
	public void IJPACGLADPK(NELJLFHKLDL FEHNANJJMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7A20", Offset = "0x7CB6820", VA = "0x187CB7A20")]
	private void AMLKBLCAPBA(NELJLFHKLDL FEHNANJJMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7B40", Offset = "0x7CB6940", VA = "0x187CB7B40")]
	[CompilerGenerated]
	private object GMBLGMGKENG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8160", Offset = "0x7CB6F60", VA = "0x187CB8160")]
	[CompilerGenerated]
	private object IHKBNNOLFKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ABJDKKJFDBJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private NELJLFHKLDL OOPCAPPHGNE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEFB0", Offset = "0x7CADDB0", VA = "0x187CAEFB0")]
	public ABJDKKJFDBJ(NELJLFHKLDL PHILCPIMGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEF60", Offset = "0x7CADD60", VA = "0x187CAEF60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HMFKNCPCAIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly NELJLFHKLDL DGGIHCMFAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MNKGFLFIEBI HBKMJNANMBN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public CONNCBNJPHG HJKEIKFEJAF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1390", Offset = "0x7CB0190", VA = "0x187CB1390")]
		get
		{
			return default(CONNCBNJPHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DCNLHNBNLII
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8F4420", Offset = "0x8F3220", VA = "0x1808F4420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string MENCOOOAIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1260", Offset = "0x7CB0060", VA = "0x187CB1260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7CB14D0", Offset = "0x7CB02D0", VA = "0x187CB14D0")]
	public HMFKNCPCAIP(NELJLFHKLDL FEHNANJJMGI, [Optional] PIEHGCCOPPA HLDNIAJEGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1330", Offset = "0x7CB0130", VA = "0x187CB1330")]
	public void HNJDEOCKABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1370", Offset = "0x7CB0170", VA = "0x187CB1370")]
	public void IJPACGLADPK()
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
