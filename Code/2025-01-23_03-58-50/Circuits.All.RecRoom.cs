using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Google.Protobuf;
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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x22E7F10", Offset = "0x22E6710", VA = "0x1822E7F10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class AOMCPFNEFFD : IDisposable, NOHHOPFDEEI, IGKJFKDFJEI, KGNPPDLAGJB, ELKEPJDNKDC
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class DHIFNBBOEFN : KMPMGGHPJPF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int HMMFEJNBPPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x22D1280", Offset = "0x22CFA80", VA = "0x1822D1280", Slot = "5")]
		public GOMIMGJHHHB HOIEGFINOJB(FFGMDCHKNFM.AOIOPLJEMJE HNBDHJIILED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void PHJJHECMDIO();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void MJLKBGEDHOP();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x22D11C0", Offset = "0x22CF9C0", VA = "0x1822D11C0", Slot = "13")]
		public virtual void EGFILCBCMEB(AOMCPFNEFFD LMIJAEAMIME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x22D1200", Offset = "0x22CFA00", VA = "0x1822D1200", Slot = "14")]
		public virtual void HEINPFLHAJL(AOMCPFNEFFD LMIJAEAMIME, MKGNMHKEPFM ILIPDNLABEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		protected DHIFNBBOEFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface KMPMGGHPJPF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int HMMFEJNBPPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GOMIMGJHHHB HOIEGFINOJB(FFGMDCHKNFM.AOIOPLJEMJE HNBDHJIILED);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PHJJHECMDIO();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MJLKBGEDHOP();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EGFILCBCMEB(AOMCPFNEFFD LMIJAEAMIME);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HEINPFLHAJL(AOMCPFNEFFD LMIJAEAMIME, MKGNMHKEPFM ILIPDNLABEN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct ADDLMCINBGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly GDOENMHIADM<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD, NIHBHKNCMKD.CAFEHNEHCJD<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD>> FNMDAPOIJFD;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x22CBA20", Offset = "0x22CA220", VA = "0x1822CBA20")]
		internal ADDLMCINBGL(GDOENMHIADM<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD, NIHBHKNCMKD.CAFEHNEHCJD<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD>> CLCEHBDJMEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class MKBKLMDBINB : NIHBHKNCMKD.CAFEHNEHCJD<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly MKBKLMDBINB ODDIIHPHFEL;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		private MKBKLMDBINB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x14398B0", Offset = "0x14380B0", VA = "0x1814398B0", Slot = "4")]
		public OFICMPDEKDE PNEJOIBDEDB(MKGNMHKEPFM EGGDEECAALI)
		{
			return default(OFICMPDEKDE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x22E6D20", Offset = "0x22E5520", VA = "0x1822E6D20", Slot = "5")]
		public void EGFILCBCMEB(AOMCPFNEFFD KAMAKIBPPKG, MKGNMHKEPFM ILIPDNLABEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x22E6E20", Offset = "0x22E5620", VA = "0x1822E6E20", Slot = "6")]
		public void HEINPFLHAJL(AOMCPFNEFFD KAMAKIBPPKG, MKGNMHKEPFM ILIPDNLABEN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct HFAGHEPFDEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public GGOLPAHLCHH<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD, NIHBHKNCMKD.CAFEHNEHCJD<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD>> FNMDAPOIJFD;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x22E30B0", Offset = "0x22E18B0", VA = "0x1822E30B0")]
		internal HFAGHEPFDEH(GGOLPAHLCHH<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD, NIHBHKNCMKD.CAFEHNEHCJD<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD>> CLCEHBDJMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x22E3060", Offset = "0x22E1860", VA = "0x1822E3060")]
		public static HFAGHEPFDEH DFLBOLBHLFN()
		{
			return default(HFAGHEPFDEH);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct KGPHPGGCJOE : HMGJAKFBCCP.NNAMCGCLGJB<MKGNMHKEPFM, AOMCPFNEFFD>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct MNPDBGEBDMM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<DNFCNMKAMCE<object?, OOJAGAFOLJL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AOMCPFNEFFD receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public MKGNMHKEPFM action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public KGPHPGGCJOE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<DNFCNMKAMCE<object?, OOJAGAFOLJL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x22E6FB0", Offset = "0x22E57B0", VA = "0x1822E6FB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x22E7190", Offset = "0x22E5990", VA = "0x1822E7190", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xAD4FB0", Offset = "0xAD37B0", VA = "0x180AD4FB0", Slot = "4")]
		public MFKBDIPIOIA<JHAGCFIKKAF> OKKKGJJJJKF(AOMCPFNEFFD HBCKNOINJJA)
		{
			return default(MFKBDIPIOIA<JHAGCFIKKAF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x22E6230", Offset = "0x22E4A30", VA = "0x1822E6230", Slot = "5")]
		public void FOIELAHKNKD(AOMCPFNEFFD HBCKNOINJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x22E6290", Offset = "0x22E4A90", VA = "0x1822E6290", Slot = "6")]
		[AsyncStateMachine(typeof(MNPDBGEBDMM))]
		public Task<DNFCNMKAMCE<object, OOJAGAFOLJL>> GBCEGNPBNCJ(AOMCPFNEFFD HBCKNOINJJA, MKGNMHKEPFM ILIPDNLABEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x22E63C0", Offset = "0x22E4BC0", VA = "0x1822E63C0", Slot = "7")]
		public MKGNMHKEPFM[] GJBGABBHCDL(AOMCPFNEFFD HBCKNOINJJA)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NOLGDBOGDJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<bool, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AOMCPFNEFFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public GCJNKFOOMCL rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public KMEGMNNEBLN circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public IKLNHKOGGAD superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<DNFCNMKAMCE<bool, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x22E7C20", Offset = "0x22E6420", VA = "0x1822E7C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x22E7EA0", Offset = "0x22E66A0", VA = "0x1822E7EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct DNBPHIACICA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<bool, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AOMCPFNEFFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<DNFCNMKAMCE<bool, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x22D1430", Offset = "0x22CFC30", VA = "0x1822D1430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x22D16C0", Offset = "0x22CFEC0", VA = "0x1822D16C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct FPOLHNMNJMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AOMCPFNEFFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x22DD2C0", Offset = "0x22DBAC0", VA = "0x1822DD2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x22DD4A0", Offset = "0x22DBCA0", VA = "0x1822DD4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct GCNLEPACFIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<object?, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AOMCPFNEFFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public MKGNMHKEPFM action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<DNFCNMKAMCE<object?, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x22DFF50", Offset = "0x22DE750", VA = "0x1822DFF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x22E0140", Offset = "0x22DE940", VA = "0x1822E0140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CHGBFNCGOKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AOMCPFNEFFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<DNFCNMKAMCE<bool, OOJAGAFOLJL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x22CF310", Offset = "0x22CDB10", VA = "0x1822CF310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x22CFAF0", Offset = "0x22CE2F0", VA = "0x1822CFAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MFKBDIPIOIA<JHAGCFIKKAF> AMLOECNGDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly ADDLMCINBGL BFDCHBBFLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly BOEPLFOHGIH FPDLNHBOFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly GEJDGNFALEJ PABIKHGKHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A90")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly EBNJEGNJANJ FLLBPNEHIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A98")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly KIOKJOJHBCJ.PMHMNJENAIF CCHFGFDJIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AB8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly DPFGOPHPGAC KJGGHCNMNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly PHHMKNHOBNC LPFDMOHJOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly JGLKLIHFAHM MKFBHNEBJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AD0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly CFLJFEEKLNO DNKPNHFMDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AD8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private NEKOMOOGNFE PNOCDDOHLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AE8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private PIOMPJCOGMM LPMPDMMCPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B08")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly BOEPLFOHGIH.GNNBPHOHOCH GIFGOGFCPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly CBALPKPBCNC JKHNNKHDILC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BOEPLFOHGIH MILPNNKHGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x22CCC50", Offset = "0x22CB450", VA = "0x1822CCC50")]
		get
		{
			return default(BOEPLFOHGIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal KMPMGGHPJPF IEAIEHIIEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x22CD120", Offset = "0x22CB920", VA = "0x1822CD120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal GOMIMGJHHHB ELCGNCOMPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x22CC800", Offset = "0x22CB000", VA = "0x1822CC800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x22CCC30", Offset = "0x22CB430", VA = "0x1822CCC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool KINKJHOIOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x22CC810", Offset = "0x22CB010", VA = "0x1822CC810")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x22CCD50", Offset = "0x22CB550", VA = "0x1822CCD50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MJBCJOCJHJJ CBGGFNGKPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x22CD470", Offset = "0x22CBC70", VA = "0x1822CD470", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LMHJPKAJJMK CHLKIFGAGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x22CD480", Offset = "0x22CBC80", VA = "0x1822CD480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JKLADEMEFPG FEFHAMAENFD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x22CD4A0", Offset = "0x22CBCA0", VA = "0x1822CD4A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public POKCGEAPCNE HPFMKHDNFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x22CD490", Offset = "0x22CBC90", VA = "0x1822CD490", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KIOKJOJHBCJ? ALGDGBNCDEI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x22CCBB0", Offset = "0x22CB3B0", VA = "0x1822CCBB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private DAFFNNBLCBC? NJICIMPJHGC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x22CCFF0", Offset = "0x22CB7F0", VA = "0x1822CCFF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22CD170", Offset = "0x22CB970", VA = "0x1822CD170")]
	private AOMCPFNEFFD(EBNJEGNJANJ AFFIFGJEAGI, MFKBDIPIOIA<JHAGCFIKKAF> LGAFEOMEGIH, [In] ADDLMCINBGL PACJCJIJPGD, [In] BOEPLFOHGIH IJDFIPGGMIF, [In] GEJDGNFALEJ LFEAFHCMFBP, GOMIMGJHHHB IPMJAHCHKBI, [In] KIOKJOJHBCJ.PMHMNJENAIF PPOGCIFJAPE, BOEPLFOHGIH.GNNBPHOHOCH GHHFKNDBNOF, CBALPKPBCNC NFJMBPKBKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x22CBE40", Offset = "0x22CA640", VA = "0x1822CBE40")]
	public static AOMCPFNEFFD DFLBOLBHLFN(EBNJEGNJANJ HNBDHJIILED, [In] ODJLILLAOGA HGKPMPPAGDJ, EOCAIHJFBFA LNNCDPNFHJC, [In] NDDIHCIFJAM FIAFOLPCHOL, IOAFAHDCHBH JOJMAMIFDHC, MFKBDIPIOIA<JHAGCFIKKAF> LGAFEOMEGIH, MFKBDIPIOIA<IKLPELIMJAF> DFEJIDNGIEM, GFPBIJPMNFJ CMECFNDONCA, LAILNAOLIMN IDONMELCKFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x22CBF80", Offset = "0x22CA780", VA = "0x1822CBF80")]
	public static AOMCPFNEFFD DFLBOLBHLFN(EBNJEGNJANJ AFFIFGJEAGI, [In] BOEPLFOHGIH IJDFIPGGMIF, [In] GEJDGNFALEJ LFEAFHCMFBP, MFKBDIPIOIA<JHAGCFIKKAF> LGAFEOMEGIH, MFKBDIPIOIA<IKLPELIMJAF> DFEJIDNGIEM, GFPBIJPMNFJ CMECFNDONCA, LAILNAOLIMN IDONMELCKFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x22CC260", Offset = "0x22CAA60", VA = "0x1822CC260", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x22CC4C0", Offset = "0x22CACC0", VA = "0x1822CC4C0")]
	[AsyncStateMachine(typeof(NOLGDBOGDJD))]
	internal Task<DNFCNMKAMCE<bool, OOJAGAFOLJL>> FNJLPKMHHAJ(GCJNKFOOMCL CMEOFAPCKNI, KMEGMNNEBLN DLOKACDBIFM, IKLNHKOGGAD MLNPIEGNENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x22CCC60", Offset = "0x22CB460", VA = "0x1822CCC60")]
	[AsyncStateMachine(typeof(DNBPHIACICA))]
	public Task<DNFCNMKAMCE<bool, OOJAGAFOLJL>> KOPCCGIBIOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x22CCD60", Offset = "0x22CB560", VA = "0x1822CCD60")]
	[AsyncStateMachine(typeof(FPOLHNMNJMD))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> MIKMHACEAMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x22CBB20", Offset = "0x22CA320", VA = "0x1822CBB20")]
	internal void CBJLNCNKJNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x22CCE50", Offset = "0x22CB650", VA = "0x1822CCE50")]
	internal CNCELCGNJHH<MKGNMHKEPFM> NILCKJEBHEH([In] ABEKDIHNEJC BDIENNPBMBN)
	{
		return default(CNCELCGNJHH<MKGNMHKEPFM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x22CC450", Offset = "0x22CAC50", VA = "0x1822CC450")]
	internal bool EJKCGMGPIMC([In] ABEKDIHNEJC BDIENNPBMBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x22CC670", Offset = "0x22CAE70", VA = "0x1822CC670")]
	internal DNFCNMKAMCE<MKGNMHKEPFM, OOJAGAFOLJL> GCCNFNFEDJM([In] JOGNGLJKLNK OGFBGPBHNNF)
	{
		return default(DNFCNMKAMCE<MKGNMHKEPFM, OOJAGAFOLJL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x22CC620", Offset = "0x22CAE20", VA = "0x1822CC620")]
	private void FOIELAHKNKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x22CBD30", Offset = "0x22CA530", VA = "0x1822CBD30")]
	[AsyncStateMachine(typeof(GCNLEPACFIL))]
	internal Task<DNFCNMKAMCE<object, OOJAGAFOLJL>> CDBEOGAGAOJ(MKGNMHKEPFM ILIPDNLABEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x22CC820", Offset = "0x22CB020", VA = "0x1822CC820")]
	private MKGNMHKEPFM[] GJBGABBHCDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x22CCED0", Offset = "0x22CB6D0", VA = "0x1822CCED0")]
	[AsyncStateMachine(typeof(CHGBFNCGOKO))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> PEJJFEJJNNE(Guid IKKOGAFPDKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ODJGPPLGHFL
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x31F3CB0", Offset = "0x31F24B0", VA = "0x1831F3CB0")]
	public static HIMDCEDKDGM<(TPrev?, AOMCPFNEFFD?), DAFFNNBLCBC> JJANMMLGOHG<TPrev>([In] this HIMDCEDKDGM<TPrev, AOMCPFNEFFD> EGGDEECAALI)
	{
		return default(HIMDCEDKDGM<(TPrev, AOMCPFNEFFD), DAFFNNBLCBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x31F3A90", Offset = "0x31F2290", VA = "0x1831F3A90")]
	public static HIMDCEDKDGM<TPrev?, AOMCPFNEFFD?> BPNGLILDKCL<TPrev>([In] this HIMDCEDKDGM<TPrev, AOMCPFNEFFD> EGGDEECAALI)
	{
		return default(HIMDCEDKDGM<TPrev, AOMCPFNEFFD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class EIGNNIABCLM<TData> : LHIOHJOJEEI, KKDFGNOCLGC, EPICLACHOCO where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly JOEFEFGKPAB<BAFEGHIGBOE>? LPPFLPCHGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly string NCOGKFNMLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly TData OPIJNNAEPFH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JOEFEFGKPAB<BAFEGHIGBOE>? AMAANBNGCDM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x251FAE0", Offset = "0x251E2E0", VA = "0x18251FAE0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8BD1D0", Offset = "0x8BB9D0", VA = "0x1808BD1D0", Slot = "7")]
	public override string DHOBPLNCIMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3CD83D0", Offset = "0x3CD6BD0", VA = "0x183CD83D0")]
	internal EIGNNIABCLM([In] JOEFEFGKPAB<BAFEGHIGBOE>? PMOHHCJAFJG, MFKBDIPIOIA<OIPDKGAIGFF>? FMCDNJELAMK, IOKind? FFEICADGHBD, string PJFOMDHJLBF, [In] TData EBNFOODJNOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NIAEANHJOKO
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x22E7390", Offset = "0x22E5B90", VA = "0x1822E7390")]
	public static DNFCNMKAMCE<CJPFALLKLPI, KKDFGNOCLGC> FIJGPBGFEHF([In] this IEKHOKIBFFB<GNBBNBHFOBI> KBBHIFJENMM)
	{
		return default(DNFCNMKAMCE<CJPFALLKLPI, KKDFGNOCLGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x31D2730", Offset = "0x31D0F30", VA = "0x1831D2730")]
	public static DNFCNMKAMCE<TOk, KKDFGNOCLGC> KBDOBPHOBKL<TOk>([In] this DNFCNMKAMCE<TOk, KKDFGNOCLGC> EGGDEECAALI, [In] JOEFEFGKPAB<BAFEGHIGBOE>? PMOHHCJAFJG, MFKBDIPIOIA<OIPDKGAIGFF>? FMCDNJELAMK, IOKind? FFEICADGHBD, string PJFOMDHJLBF) where TOk : notnull
	{
		return default(DNFCNMKAMCE<TOk, KKDFGNOCLGC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EBNJEGNJANJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FLIJEIJPGJF.AODLKIGACEJ OBMJJFECLHK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	FFGMDCHKNFM.AOIOPLJEMJE GIPNLEMEPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	AOMCPFNEFFD.KMPMGGHPJPF MCAGKFFIAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	FCKNIGOELJC.OPACNDIGFBE FIEIDJPBIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NIHBHKNCMKD.CAFEHNEHCJD<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD> BNACODNHLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	OMMGKJLDNMP IEEEAOOLCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	AJABLLLEEDI LBFCKOAFMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	HHEMAKBOGAO HDEAKFODONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	CBMFHDHLKFF INEHFOHFOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	KAJAMMHOPCI DKCMBPKNKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class FFJEDENHCIB
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x22D1ED0", Offset = "0x22D06D0", VA = "0x1822D1ED0")]
	public static MKGNMHKEPFM NLGHDIJIIDB(this MKGNMHKEPFM EGGDEECAALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x22D1E00", Offset = "0x22D0600", VA = "0x1822D1E00")]
	public static MKGNMHKEPFM IOEOIMNKPIA(this CJOKBBPJHEG EGGDEECAALI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct CJOKBBPJHEG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct POIBICLJNDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<object?, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AOMCPFNEFFD root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CJOKBBPJHEG self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private TaskAwaiter<DNFCNMKAMCE<object?, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x22E8B80", Offset = "0x22E7380", VA = "0x1822E8B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x22E8E40", Offset = "0x22E7640", VA = "0x1822E8E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly ByteString MHFLHGKPHDB;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x95E8E0", Offset = "0x95D0E0", VA = "0x18095E8E0")]
	private CJOKBBPJHEG(ByteString INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x22CFD20", Offset = "0x22CE520", VA = "0x1822CFD20")]
	public static MKGNMHKEPFM LOHNIPEKPGE(ByteString INDENPJBLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x22CFC70", Offset = "0x22CE470", VA = "0x1822CFC70")]
	public static NLAHBAMHBNN<OFICMPDEKDE, CJOKBBPJHEG> EIOCBPILIJJ(MKGNMHKEPFM EKCGMOBNPJL)
	{
		return default(NLAHBAMHBNN<OFICMPDEKDE, CJOKBBPJHEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x22CFB60", Offset = "0x22CE360", VA = "0x1822CFB60")]
	[AsyncStateMachine(typeof(POIBICLJNDH))]
	public static Task<DNFCNMKAMCE<object, OOJAGAFOLJL>> CDBEOGAGAOJ(AOMCPFNEFFD KAMAKIBPPKG, CJOKBBPJHEG EGGDEECAALI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct NCBGDEJPCFM
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x22E7270", Offset = "0x22E5A70", VA = "0x1822E7270")]
	public static MKGNMHKEPFM LOHNIPEKPGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x22E7200", Offset = "0x22E5A00", VA = "0x1822E7200")]
	public static NLAHBAMHBNN<OFICMPDEKDE, NCBGDEJPCFM> EIOCBPILIJJ(MKGNMHKEPFM EKCGMOBNPJL)
	{
		return default(NLAHBAMHBNN<OFICMPDEKDE, NCBGDEJPCFM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x22E7310", Offset = "0x22E5B10", VA = "0x1822E7310")]
	public static DNFCNMKAMCE<DOPPLCFNMND, DBICEFMNJAI> NHKKBFGFOCK(AOMCPFNEFFD KAMAKIBPPKG, [In] NCBGDEJPCFM EGGDEECAALI)
	{
		return default(DNFCNMKAMCE<DOPPLCFNMND, DBICEFMNJAI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct IBGBHHOJBHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct JKHILHMEKAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, DBICEFMNJAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AOMCPFNEFFD root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IBGBHHOJBHD self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private DNFCNMKAMCE<DOPPLCFNMND, DBICEFMNJAI> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x22E5920", Offset = "0x22E4120", VA = "0x1822E5920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x22E5C90", Offset = "0x22E4490", VA = "0x1822E5C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly GCJNKFOOMCL? AIMNCKBDKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly KMEGMNNEBLN? DMFPFEHCFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly IKLNHKOGGAD? BFIHJNAGCLN;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2204CA0", Offset = "0x22034A0", VA = "0x182204CA0")]
	private IBGBHHOJBHD(GCJNKFOOMCL? CMEOFAPCKNI, KMEGMNNEBLN? DLOKACDBIFM, IKLNHKOGGAD? MLNPIEGNENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x22E3A20", Offset = "0x22E2220", VA = "0x1822E3A20")]
	public static MKGNMHKEPFM? LOHNIPEKPGE(GCJNKFOOMCL? CMEOFAPCKNI, KMEGMNNEBLN? DLOKACDBIFM, IKLNHKOGGAD? MLNPIEGNENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x22E3910", Offset = "0x22E2110", VA = "0x1822E3910")]
	public static NLAHBAMHBNN<OFICMPDEKDE, IBGBHHOJBHD> EIOCBPILIJJ(MKGNMHKEPFM EKCGMOBNPJL)
	{
		return default(NLAHBAMHBNN<OFICMPDEKDE, IBGBHHOJBHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x22E37D0", Offset = "0x22E1FD0", VA = "0x1822E37D0")]
	[AsyncStateMachine(typeof(JKHILHMEKAK))]
	public static Task<DNFCNMKAMCE<DOPPLCFNMND, DBICEFMNJAI>> CDBEOGAGAOJ(AOMCPFNEFFD KAMAKIBPPKG, IBGBHHOJBHD EGGDEECAALI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct NNMMIPAEJLM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct CKEFOKLBNKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<GJKMPOLHKIA, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NNMMIPAEJLM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AOMCPFNEFFD root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private DNFCNMKAMCE<GJKMPOLHKIA, OOJAGAFOLJL> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private DNFCNMKAMCE<object?, EPICLACHOCO>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private DNFCNMKAMCE<object?, EPICLACHOCO> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private DNFCNMKAMCE<object?, EPICLACHOCO>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<DNFCNMKAMCE<object?, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x22CFDE0", Offset = "0x22CE5E0", VA = "0x1822CFDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x22D0240", Offset = "0x22CEA40", VA = "0x1822D0240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly IReadOnlyList<MKGNMHKEPFM> NOBPFPOGCBE;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x95E8E0", Offset = "0x95D0E0", VA = "0x18095E8E0")]
	private NNMMIPAEJLM(IReadOnlyList<MKGNMHKEPFM> GLAHDKCHLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x22E7B60", Offset = "0x22E6360", VA = "0x1822E7B60")]
	public static MKGNMHKEPFM LOHNIPEKPGE(IReadOnlyList<MKGNMHKEPFM> GLAHDKCHLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x22E7AC0", Offset = "0x22E62C0", VA = "0x1822E7AC0")]
	public static NLAHBAMHBNN<OFICMPDEKDE, NNMMIPAEJLM> EIOCBPILIJJ(MKGNMHKEPFM EKCGMOBNPJL)
	{
		return default(NLAHBAMHBNN<OFICMPDEKDE, NNMMIPAEJLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x22E7980", Offset = "0x22E6180", VA = "0x1822E7980")]
	[AsyncStateMachine(typeof(CKEFOKLBNKI))]
	public static Task<DNFCNMKAMCE<GJKMPOLHKIA, OOJAGAFOLJL>> CDBEOGAGAOJ(AOMCPFNEFFD KAMAKIBPPKG, NNMMIPAEJLM EGGDEECAALI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct JOGNGLJKLNK
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class ODGGCDDLHFF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LKHDDPAPCPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public JOEFEFGKPAB<ODGGCDDLHFF> actionId;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public LKHDDPAPCPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x22E6750", Offset = "0x22E4F50", VA = "0x1822E6750")]
		internal MKGNMHKEPFM PHBLJGCLDNA(int count, int index, [In] ReadOnlySpan<byte> span)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly JOEFEFGKPAB<ODGGCDDLHFF> JEAINJJLIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly int BMBFHPLNLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly int MBLPHBBBBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly byte[] OPIJNNAEPFH;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x22E6210", Offset = "0x22E4A10", VA = "0x1822E6210")]
	private JOGNGLJKLNK(JOEFEFGKPAB<ODGGCDDLHFF> EEJPAMKPNHH, int NELOIEKKMHO, int ECDOOAABOPD, byte[] EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x22E5E50", Offset = "0x22E4650", VA = "0x1822E5E50")]
	public static MKGNMHKEPFM LOHNIPEKPGE(JOEFEFGKPAB<ODGGCDDLHFF> EEJPAMKPNHH, int NELOIEKKMHO, int ECDOOAABOPD, ByteString EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x22E5F60", Offset = "0x22E4760", VA = "0x1822E5F60")]
	public static MKGNMHKEPFM[] NAHDAHDLGFG(MKGNMHKEPFM ILIPDNLABEN, int GEFHELCJEMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x22E5D00", Offset = "0x22E4500", VA = "0x1822E5D00")]
	public static NLAHBAMHBNN<OFICMPDEKDE, JOGNGLJKLNK> EIOCBPILIJJ(MKGNMHKEPFM EKCGMOBNPJL)
	{
		return default(NLAHBAMHBNN<OFICMPDEKDE, JOGNGLJKLNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x22E6070", Offset = "0x22E4870", VA = "0x1822E6070")]
	public static DNFCNMKAMCE<MKGNMHKEPFM, OOJAGAFOLJL> NHKKBFGFOCK(AOMCPFNEFFD KAMAKIBPPKG, [In] JOGNGLJKLNK EGGDEECAALI)
	{
		return default(DNFCNMKAMCE<MKGNMHKEPFM, OOJAGAFOLJL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct ABEKDIHNEJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct IDGEIMOOOJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<bool, DBICEFMNJAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AOMCPFNEFFD root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public ABEKDIHNEJC self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private DNFCNMKAMCE<bool, DBICEFMNJAI> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, DBICEFMNJAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x22E3B20", Offset = "0x22E2320", VA = "0x1822E3B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x22E4160", Offset = "0x22E2960", VA = "0x1822E4160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly int BMBFHPLNLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly int MBLPHBBBBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly byte[] OPIJNNAEPFH;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x21386B0", Offset = "0x2136EB0", VA = "0x1821386B0")]
	private ABEKDIHNEJC(int NELOIEKKMHO, int ECDOOAABOPD, byte[] EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x22CB740", Offset = "0x22C9F40", VA = "0x1822CB740")]
	public static MKGNMHKEPFM LOHNIPEKPGE(int NELOIEKKMHO, int ECDOOAABOPD, ByteString EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x22CB820", Offset = "0x22CA020", VA = "0x1822CB820")]
	public static MKGNMHKEPFM?[]? PBKLDBIMODF(int GEFHELCJEMK, GCJNKFOOMCL? CMEOFAPCKNI, KMEGMNNEBLN? DLOKACDBIFM, IKLNHKOGGAD? MLNPIEGNENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x22CB660", Offset = "0x22C9E60", VA = "0x1822CB660")]
	public static NLAHBAMHBNN<OFICMPDEKDE, ABEKDIHNEJC> EIOCBPILIJJ(MKGNMHKEPFM EKCGMOBNPJL)
	{
		return default(NLAHBAMHBNN<OFICMPDEKDE, ABEKDIHNEJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x22CB530", Offset = "0x22C9D30", VA = "0x1822CB530")]
	[AsyncStateMachine(typeof(IDGEIMOOOJG))]
	public static Task<DNFCNMKAMCE<bool, DBICEFMNJAI>> CDBEOGAGAOJ(AOMCPFNEFFD KAMAKIBPPKG, ABEKDIHNEJC EGGDEECAALI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DPFGOPHPGAC : MJBCJOCJHJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly AOMCPFNEFFD AHDBCMDLDJP;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public PANGCIGOLLP? ODDIIHPHFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x22D1730", Offset = "0x22CFF30", VA = "0x1822D1730", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	internal DPFGOPHPGAC(AOMCPFNEFFD LMIJAEAMIME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class GLHCPEIFFHC : PANGCIGOLLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly AOMCPFNEFFD AHDBCMDLDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly JBMLOFKPLDF CCCEGPCCDJG;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8C5E90", Offset = "0x8C4690", VA = "0x1808C5E90")]
	public GLHCPEIFFHC(AOMCPFNEFFD LMIJAEAMIME, JBMLOFKPLDF OOGOGIAGFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x22E0E50", Offset = "0x22DF650", VA = "0x1822E0E50", Slot = "4")]
	public DNFCNMKAMCE<CJPFALLKLPI, KKDFGNOCLGC> GNDNEIJBMCA(JOEFEFGKPAB<BAFEGHIGBOE> FJIFOJCFNEO, MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, MFKBDIPIOIA<MKADPEDLCGB> OHFAFGCBLBF)
	{
		return default(DNFCNMKAMCE<CJPFALLKLPI, KKDFGNOCLGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x22E0B70", Offset = "0x22DF370", VA = "0x1822E0B70", Slot = "5")]
	public DNFCNMKAMCE<CJPFALLKLPI, KKDFGNOCLGC> CBJLJIOABEM(JOEFEFGKPAB<BAFEGHIGBOE> FJIFOJCFNEO, MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, MFKBDIPIOIA<EGPAIJNGCOJ> FDJOEDBJICL)
	{
		return default(DNFCNMKAMCE<CJPFALLKLPI, KKDFGNOCLGC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class FLIJEIJPGJF : KKILICBDGJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface AODLKIGACEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<JBMLOFKPLDF> OAKJFPABDHP(AOMCPFNEFFD LMIJAEAMIME, KMEGMNNEBLN? EMGKPHLAKII, IKLNHKOGGAD? JPBPHGHNGLJ, CancellationToken ALKEMFHOMCA);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		OCKDFBJBEPI BENMFAKCBPB(AOMCPFNEFFD LMIJAEAMIME, GCJNKFOOMCL CDIHKOIKDGK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class FJDPFIKLGFB : AODLKIGACEJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct OCCJNMALLHF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<JBMLOFKPLDF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AOMCPFNEFFD circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public KMEGMNNEBLN cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public IKLNHKOGGAD cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<FCKNIGOELJC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x22E8060", Offset = "0x22E6860", VA = "0x1822E8060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x22E8230", Offset = "0x22E6A30", VA = "0x1822E8230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly FJDPFIKLGFB ODDIIHPHFEL;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		private FJDPFIKLGFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x22D2000", Offset = "0x22D0800", VA = "0x1822D2000", Slot = "4")]
		[AsyncStateMachine(typeof(OCCJNMALLHF))]
		public Task<JBMLOFKPLDF> OAKJFPABDHP(AOMCPFNEFFD LMIJAEAMIME, KMEGMNNEBLN? EMGKPHLAKII, IKLNHKOGGAD? JPBPHGHNGLJ, CancellationToken ALKEMFHOMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x22D1FE0", Offset = "0x22D07E0", VA = "0x1822D1FE0", Slot = "5")]
		public OCKDFBJBEPI BENMFAKCBPB(AOMCPFNEFFD LMIJAEAMIME, GCJNKFOOMCL CDIHKOIKDGK)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct JCOBLNPDCGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<FLIJEIJPGJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AOMCPFNEFFD circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public KMEGMNNEBLN cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public IKLNHKOGGAD cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GCJNKFOOMCL evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private AODLKIGACEJ <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<JBMLOFKPLDF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x22E4CF0", Offset = "0x22E34F0", VA = "0x1822E4CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x22E51E0", Offset = "0x22E39E0", VA = "0x1822E51E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly JBMLOFKPLDF CCCEGPCCDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly OCKDFBJBEPI ELHMEKMCPOO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public KIOKJOJHBCJ ALGDGBNCDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x22D2240", Offset = "0x22D0A40", VA = "0x1822D2240", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public DAFFNNBLCBC FDFNKFFBEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x22D2400", Offset = "0x22D0C00", VA = "0x1822D2400", Slot = "5")]
		get
		{
			return default(DAFFNNBLCBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GLHCPEIFFHC CCJMDPKBMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public EFIPKHIJODD NFEAJLIPOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFD0", Offset = "0x8B97D0", VA = "0x1808BAFD0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xB53240", Offset = "0xB51A40", VA = "0x180B53240")]
	private FLIJEIJPGJF(JBMLOFKPLDF OOGOGIAGFFG, OCKDFBJBEPI NBNKOOFNNFK, GLHCPEIFFHC OPEKPALBJHM, EFIPKHIJODD HEEIGDMLCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x22D2290", Offset = "0x22D0A90", VA = "0x1822D2290")]
	[AsyncStateMachine(typeof(JCOBLNPDCGE))]
	public static Task<FLIJEIJPGJF> NADGDMNNJMC(AOMCPFNEFFD LMIJAEAMIME, GCJNKFOOMCL CDIHKOIKDGK, KMEGMNNEBLN? EMGKPHLAKII, IKLNHKOGGAD? JPBPHGHNGLJ, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x22D21E0", Offset = "0x22D09E0", VA = "0x1822D21E0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class FFGMDCHKNFM : GOMIMGJHHHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface AOIOPLJEMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<KKILICBDGJN> JPKCMJIFLNI(AOMCPFNEFFD LMIJAEAMIME, GCJNKFOOMCL CDIHKOIKDGK, KMEGMNNEBLN? EMGKPHLAKII, IKLNHKOGGAD? JPBPHGHNGLJ, CancellationToken ALKEMFHOMCA);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LOOCDFDANCO();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IDGJINBHIDN();
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public abstract class IGBFMLMIIOE : AOIOPLJEMJE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct HOJJLOLEOCF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<KKILICBDGJN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public AOMCPFNEFFD circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public GCJNKFOOMCL evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public KMEGMNNEBLN cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public IKLNHKOGGAD cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<FLIJEIJPGJF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x22E3420", Offset = "0x22E1C20", VA = "0x1822E3420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x22E3760", Offset = "0x22E1F60", VA = "0x1822E3760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x22E41D0", Offset = "0x22E29D0", VA = "0x1822E41D0", Slot = "4")]
		[AsyncStateMachine(typeof(HOJJLOLEOCF))]
		public Task<KKILICBDGJN> JPKCMJIFLNI(AOMCPFNEFFD LMIJAEAMIME, GCJNKFOOMCL CDIHKOIKDGK, KMEGMNNEBLN? EMGKPHLAKII, IKLNHKOGGAD? JPBPHGHNGLJ, CancellationToken ALKEMFHOMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void LOOCDFDANCO();

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void IDGJINBHIDN();

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		protected IGBFMLMIIOE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct OIMKBJLLAFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<KKILICBDGJN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public FFGMDCHKNFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<DOPPLCFNMND> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x22E82A0", Offset = "0x22E6AA0", VA = "0x1822E82A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x22E84A0", Offset = "0x22E6CA0", VA = "0x1822E84A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct JIEJBPHLBKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public FFGMDCHKNFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AOMCPFNEFFD circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public GCJNKFOOMCL evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public KMEGMNNEBLN cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IKLNHKOGGAD cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter<KKILICBDGJN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x22E5390", Offset = "0x22E3B90", VA = "0x1822E5390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x22E58C0", Offset = "0x22E40C0", VA = "0x1822E58C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly AOIOPLJEMJE NNDMPDFKOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<DOPPLCFNMND> EMEINDGGLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly TaskCompletionSource<DOPPLCFNMND> LEIOKMNLMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CancellationTokenSource JBOIDGCPFAD;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool KINKJHOIOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8E3DA0", Offset = "0x8E25A0", VA = "0x1808E3DA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8E3B20", Offset = "0x8E2320", VA = "0x1808E3B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KNPGJHABEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9CF9B0", Offset = "0x9CE1B0", VA = "0x1809CF9B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xE835F0", Offset = "0xE81DF0", VA = "0x180E835F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NAMIGACAJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x14E0F40", Offset = "0x14DF740", VA = "0x1814E0F40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x22D1B80", Offset = "0x22D0380", VA = "0x1822D1B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public KKILICBDGJN? BJHEGGPMLEK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB260", Offset = "0x8B9A60", VA = "0x1808BB260", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFE0", Offset = "0x8B97E0", VA = "0x1808BAFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x22D1A90", Offset = "0x22D0290", VA = "0x1822D1A90", Slot = "7")]
	[AsyncStateMachine(typeof(OIMKBJLLAFG))]
	public Task<KKILICBDGJN> MDFBAHEHAFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x22D1CF0", Offset = "0x22D04F0", VA = "0x1822D1CF0")]
	public FFGMDCHKNFM(AOIOPLJEMJE HNBDHJIILED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x22D1B90", Offset = "0x22D0390", VA = "0x1822D1B90", Slot = "8")]
	[AsyncStateMachine(typeof(JIEJBPHLBKB))]
	public Task MKPLKOMPAGH(AOMCPFNEFFD LMIJAEAMIME, GCJNKFOOMCL CDIHKOIKDGK, KMEGMNNEBLN? EMGKPHLAKII, IKLNHKOGGAD? JPBPHGHNGLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x22D1910", Offset = "0x22D0110", VA = "0x1822D1910", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class JPENIJJMMGG : HCDMCPCCCMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly EFIPKHIJODD KFBFBHCGMBM;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	public JPENIJJMMGG(EFIPKHIJODD HEEIGDMLCAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class JALIEBFLHHO
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class OMJIJHLFKCC<TGraph> : HBOPAPPEAPD where TGraph : MDLGLPLIMFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		protected readonly TGraph MAAFKEMFGKH;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual GEMKKAEFFOE? LHFGEDPPDGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x13045E0", Offset = "0x1302DE0", VA = "0x1813045E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public MFKBDIPIOIA<JFDGELHFKII> PHABMAJJJLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x4B6EE50", Offset = "0x4B6D650", VA = "0x184B6EE50", Slot = "5")]
			get
			{
				return default(MFKBDIPIOIA<JFDGELHFKII>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public MFKBDIPIOIA<JFDGELHFKII>? COAPPBOKKJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x4B6EDD0", Offset = "0x4B6D5D0", VA = "0x184B6EDD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
		public OMJIJHLFKCC(TGraph KALPAHICNIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class AFJBLLMMIJF : OMJIJHLFKCC<MHJDOAGGBAA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override GEMKKAEFFOE? LHFGEDPPDGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x22CBA30", Offset = "0x22CA230", VA = "0x1822CBA30", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x22CBA50", Offset = "0x22CA250", VA = "0x1822CBA50")]
		public AFJBLLMMIJF(MHJDOAGGBAA LKKCPEOKEJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x22E43A0", Offset = "0x22E2BA0", VA = "0x1822E43A0")]
	public static HBOPAPPEAPD DFLBOLBHLFN(MDLGLPLIMFK KALPAHICNIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class GCDFAKIPPAO : MELIJAOBIDI, EHDAIELCBDF, JOAECAAFOOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class NKAHBPLEAEL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public NKAHBPLEAEL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public OMMGKJLDNMP errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x22E8EB0", Offset = "0x22E76B0", VA = "0x1822E8EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x22E9120", Offset = "0x22E7920", VA = "0x1822E9120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public GCDFAKIPPAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NKAHBPLEAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x22E7830", Offset = "0x22E6030", VA = "0x1822E7830")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task NJAOMGFMOAI(OMMGKJLDNMP errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct BGLGNHIPKEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public GCDFAKIPPAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x22CD4B0", Offset = "0x22CBCB0", VA = "0x1822CD4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x22CD9B0", Offset = "0x22CC1B0", VA = "0x1822CD9B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class OBCCFFLADKG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public OBCCFFLADKG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x22E9180", Offset = "0x22E7980", VA = "0x1822E9180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x22E9460", Offset = "0x22E7C60", VA = "0x1822E9460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public GCDFAKIPPAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public OBCCFFLADKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x22E7F90", Offset = "0x22E6790", VA = "0x1822E7F90")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task NMDOIEGEOBL(OMMGKJLDNMP errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly EJONBCNEKIH NLEKCEOBIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ICollection<FAJMCEEPMIP> KOMHEFNIPLO;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private EBNJEGNJANJ DKEFAIALOBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x22DD7C0", Offset = "0x22DBFC0", VA = "0x1822DD7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public MFKBDIPIOIA<MKADPEDLCGB> ICHOAGFFCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xB0E530", Offset = "0xB0CD30", VA = "0x180B0E530", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(MFKBDIPIOIA<MKADPEDLCGB>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xB0D4C0", Offset = "0xB0BCC0", VA = "0x180B0D4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private MFKBDIPIOIA<JPEJPKEPEEM> GGOFHEHPNNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xE7EE90", Offset = "0xE7D690", VA = "0x180E7EE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public MFKBDIPIOIA<EGENAIBALPJ> JGFGIIBDKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8DDBF0", Offset = "0x8DC3F0", VA = "0x1808DDBF0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(MFKBDIPIOIA<EGENAIBALPJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override MFKBDIPIOIA<OIPDKGAIGFF> DDPCEBLKNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x22DEB50", Offset = "0x22DD350", VA = "0x1822DEB50", Slot = "20")]
		get
		{
			return default(MFKBDIPIOIA<OIPDKGAIGFF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool MAMCHGLKJFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x22DF8B0", Offset = "0x22DE0B0", VA = "0x1822DF8B0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x22DFD30", Offset = "0x22DE530", VA = "0x1822DFD30")]
	private GCDFAKIPPAO(AOMCPFNEFFD LMIJAEAMIME, GLIPNLBBOGL JLFLGGOOAGI, EJONBCNEKIH EAEEEOJAJDA, MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, MFKBDIPIOIA<MKADPEDLCGB> OHFAFGCBLBF, MFKBDIPIOIA<JPEJPKEPEEM> MPMKNHFAGIC, bool LNFODNFBJDH, string IKMKCMDHFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x22DE5B0", Offset = "0x22DCDB0", VA = "0x1822DE5B0")]
	public static GCDFAKIPPAO DFLBOLBHLFN(AOMCPFNEFFD LMIJAEAMIME, GLIPNLBBOGL JLFLGGOOAGI, EJONBCNEKIH AOJEAJGBMCP, MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, MFKBDIPIOIA<JPEJPKEPEEM> MPMKNHFAGIC, MFKBDIPIOIA<MKADPEDLCGB> OHFAFGCBLBF, bool LNFODNFBJDH, bool NGGKGOLOAOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x22DEA00", Offset = "0x22DD200", VA = "0x1822DEA00", Slot = "21")]
	protected override void EHFCOOMFLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x22DE960", Offset = "0x22DD160", VA = "0x1822DE960", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x22DEAF0", Offset = "0x22DD2F0", VA = "0x1822DEAF0", Slot = "30")]
	public void GGEJHDOFMKB(FAJMCEEPMIP LDJLHJIPOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x22DE240", Offset = "0x22DCA40", VA = "0x1822DE240", Slot = "27")]
	public void CPODHHLBDNC(BAJEAFDIKOF ODDLGENCPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x22DD7E0", Offset = "0x22DBFE0", VA = "0x1822DD7E0", Slot = "28")]
	public void BBNNEENGLBI(DAGJDKDFPDM KDMGNFBPPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x22DF650", Offset = "0x22DDE50", VA = "0x1822DF650", Slot = "23")]
	protected override void LJKOENCFJAA(COLFFFFAMFM NPKDOLOBDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x22DFBC0", Offset = "0x22DE3C0", VA = "0x1822DFBC0", Slot = "32")]
	public string OJNAAKCFNHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x22DF180", Offset = "0x22DD980", VA = "0x1822DF180", Slot = "29")]
	public string KAEGAADBELC(int BOHJNNAGEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x22DEF60", Offset = "0x22DD760", VA = "0x1822DEF60")]
	private void JBBPPEEKDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x22DFB00", Offset = "0x22DE300", VA = "0x1822DFB00", Slot = "31")]
	public void OFJNLCBEMDA(FAJMCEEPMIP LDJLHJIPOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x22DF940", Offset = "0x22DE140", VA = "0x1822DF940")]
	private void OBONPLEHCOK(bool INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x22DD6B0", Offset = "0x22DBEB0", VA = "0x1822DD6B0", Slot = "33")]
	[AsyncStateMachine(typeof(BGLGNHIPKEH))]
	public Task AIHEAHBIFBF(string INDENPJBLHO, bool HCAAIPPLOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x22DED80", Offset = "0x22DD580", VA = "0x1822DED80")]
	public void IJNFNIAGBJJ(string INDENPJBLHO, bool HCAAIPPLOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x22DD510", Offset = "0x22DBD10", VA = "0x1822DD510")]
	private void ACBDFBKNBLC(int INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0xB0D4C0", Offset = "0xB0BCC0", VA = "0x180B0D4C0")]
	internal void NPFHPCFBJMA(MFKBDIPIOIA<MKADPEDLCGB> INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x22DF930", Offset = "0x22DE130", VA = "0x1822DF930")]
	[CompilerGenerated]
	private void NPCFDEKKMAK(string INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x22DF440", Offset = "0x22DDC40", VA = "0x1822DF440")]
	[CompilerGenerated]
	private bool KHAKOIDOJHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x22DEC40", Offset = "0x22DD440", VA = "0x1822DEC40")]
	[CompilerGenerated]
	private bool HIGOLAFFPMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x22DF7A0", Offset = "0x22DDFA0", VA = "0x1822DF7A0")]
	[CompilerGenerated]
	private int OCBMIEGLBKF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x22DEED0", Offset = "0x22DD6D0", VA = "0x1822DEED0")]
	[CompilerGenerated]
	private bool IMDIPBLGNHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x22DEC30", Offset = "0x22DD430", VA = "0x1822DEC30")]
	[CompilerGenerated]
	private void HGNLGFEAALE(string INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x22DF7F0", Offset = "0x22DDFF0", VA = "0x1822DF7F0")]
	[CompilerGenerated]
	private bool LPKKNLIJIOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x22DEAA0", Offset = "0x22DD2A0", VA = "0x1822DEAA0")]
	[CompilerGenerated]
	private bool FBEEECIGPEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x22DEBA0", Offset = "0x22DD3A0", VA = "0x1822DEBA0")]
	[CompilerGenerated]
	private bool HBBFMHMKGBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x22DF7A0", Offset = "0x22DDFA0", VA = "0x1822DF7A0")]
	[CompilerGenerated]
	private int LKJFLLPBLIP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x22DE170", Offset = "0x22DC970", VA = "0x1822DE170")]
	[CompilerGenerated]
	private bool BCLJIEPHCKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x22DED00", Offset = "0x22DD500", VA = "0x1822DED00")]
	[CompilerGenerated]
	private object HKHACGPBALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x22DF500", Offset = "0x22DDD00", VA = "0x1822DF500")]
	[CompilerGenerated]
	private void KMODAOFNDAL(object INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x22DF580", Offset = "0x22DDD80", VA = "0x1822DF580")]
	[CompilerGenerated]
	private bool KODFBGGHNDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class BOMJFBLBCJB
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private sealed class BKDAHDDEKPG : HLGBCEDEFMN<EBPBBHCJPGL>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class KPIEIIAMNJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public BKDAHDDEKPG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public KPIEIIAMNJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x22E63E0", Offset = "0x22E4BE0", VA = "0x1822E63E0")]
			internal object FBICKDEKDMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x22E6450", Offset = "0x22E4C50", VA = "0x1822E6450")]
			internal void JKEAAELNANL(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x22CDCA0", Offset = "0x22CC4A0", VA = "0x1822CDCA0")]
		public BKDAHDDEKPG(AOMCPFNEFFD LMIJAEAMIME, EBPBBHCJPGL CLCEHBDJMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x22CDA10", Offset = "0x22CC210", VA = "0x1822CDA10", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class DJOJKOPEIJK : JKIHCIKKFMD<JAGFHJIMDAE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override LKLBDLNAKHE AGINLCJIICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x926710", Offset = "0x924F10", VA = "0x180926710", Slot = "128")]
			get
			{
				return default(LKLBDLNAKHE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x22D13D0", Offset = "0x22CFBD0", VA = "0x1822D13D0")]
		public DJOJKOPEIJK(AOMCPFNEFFD LMIJAEAMIME, JAGFHJIMDAE CLCEHBDJMEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class HHLPEPDAMMJ : HLGBCEDEFMN<EAGKLJPANPC>
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x22E33B0", Offset = "0x22E1BB0", VA = "0x1822E33B0")]
		public HHLPEPDAMMJ(AOMCPFNEFFD LMIJAEAMIME, EAGKLJPANPC JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x22E3230", Offset = "0x22E1A30", VA = "0x1822E3230", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x22E31E0", Offset = "0x22E19E0", VA = "0x1822E31E0")]
		[CompilerGenerated]
		private bool MGPECNGJFLL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x22E30C0", Offset = "0x22E18C0", VA = "0x1822E30C0")]
		[CompilerGenerated]
		private void KPGBFECBCEF(bool INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class DAKNBHPFOCG : HLGBCEDEFMN<NMDIKFLBGED>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class GFGFCFOMJGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public DAKNBHPFOCG <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public GFGFCFOMJGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x22E0A80", Offset = "0x22DF280", VA = "0x1822E0A80")]
			internal void FBICKDEKDMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x22E0AD0", Offset = "0x22DF2D0", VA = "0x1822E0AD0")]
			internal bool JKEAAELNANL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x22E0A30", Offset = "0x22DF230", VA = "0x1822E0A30")]
			internal bool BCMIIJCJHFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x22E0910", Offset = "0x22DF110", VA = "0x1822E0910")]
			internal void ADJPFJJKDFB(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x22E0B20", Offset = "0x22DF320", VA = "0x1822E0B20")]
			internal bool NNIOHDHPNHD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x22D05F0", Offset = "0x22CEDF0", VA = "0x1822D05F0")]
		public DAKNBHPFOCG(AOMCPFNEFFD LMIJAEAMIME, NMDIKFLBGED JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x22D02B0", Offset = "0x22CEAB0", VA = "0x1822D02B0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class JBEDEEDPGKE : HLGBCEDEFMN<OHLAKJEGMDA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class GDJHKIODMBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public JBEDEEDPGKE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public GDJHKIODMBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x22E0550", Offset = "0x22DED50", VA = "0x1822E0550")]
			internal object FBICKDEKDMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x22E0360", Offset = "0x22DEB60", VA = "0x1822E0360")]
			internal bool BFLKOFCGAAC(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x22E0650", Offset = "0x22DEE50", VA = "0x1822E0650")]
			internal void JKEAAELNANL(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x22E0200", Offset = "0x22DEA00", VA = "0x1822E0200")]
			internal string BCMIIJCJHFG(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x22E01B0", Offset = "0x22DE9B0", VA = "0x1822E01B0")]
			internal IReadOnlyList<object> ADJPFJJKDFB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x22E08A0", Offset = "0x22DF0A0", VA = "0x1822E08A0")]
			internal bool NNIOHDHPNHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x22E0500", Offset = "0x22DED00", VA = "0x1822E0500")]
			internal bool CCDHILCAKBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x22E03E0", Offset = "0x22DEBE0", VA = "0x1822E03E0")]
			internal void BMMNDIJLGFO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x22E4C80", Offset = "0x22E3480", VA = "0x1822E4C80")]
		public JBEDEEDPGKE(AOMCPFNEFFD LMIJAEAMIME, OHLAKJEGMDA JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x22E4530", Offset = "0x22E2D30", VA = "0x1822E4530", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class LLJBPPIOMMP : HLGBCEDEFMN<KMPJOHIMHPI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class MAEHFDLDKBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public LLJBPPIOMMP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public MAEHFDLDKBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x22E6BB0", Offset = "0x22E53B0", VA = "0x1822E6BB0")]
			internal bool FBICKDEKDMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x22E6C00", Offset = "0x22E5400", VA = "0x1822E6C00")]
			internal void JKEAAELNANL(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x22E6B60", Offset = "0x22E5360", VA = "0x1822E6B60")]
			internal bool BCMIIJCJHFG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x22E6AF0", Offset = "0x22E52F0", VA = "0x1822E6AF0")]
		public LLJBPPIOMMP(AOMCPFNEFFD LMIJAEAMIME, KMPJOHIMHPI JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x22E68C0", Offset = "0x22E50C0", VA = "0x1822E68C0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class MBDFNDLNIFF<TNode> : HLGBCEDEFMN<TNode> where TNode : notnull, GFGNDFCNMND
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct IONOMNJJJEG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public AsyncTaskMethodBuilder<DNFCNMKAMCE<MFKBDIPIOIA<NONADBDKHEF>, OOJAGAFOLJL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public MBDFNDLNIFF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private TaskAwaiter<DNFCNMKAMCE<MFKBDIPIOIA<NONADBDKHEF>, OOJAGAFOLJL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x4342290", Offset = "0x4340A90", VA = "0x184342290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x4342680", Offset = "0x4340E80", VA = "0x184342680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct KKDCBJFLOOI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public MBDFNDLNIFF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public MFKBDIPIOIA<NONADBDKHEF> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x4648EC0", Offset = "0x46476C0", VA = "0x184648EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x46492B0", Offset = "0x4647AB0", VA = "0x1846492B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool KOBJMJEGBLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override MFKBDIPIOIA<NONADBDKHEF>? FIIEGOPMGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x493AA50", Offset = "0x4939250", VA = "0x18493AA50", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x476AAF0", Offset = "0x47692F0", VA = "0x18476AAF0")]
		protected MBDFNDLNIFF(AOMCPFNEFFD LMIJAEAMIME, TNode JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x493A640", Offset = "0x4938E40", VA = "0x18493A640", Slot = "102")]
		[AsyncStateMachine(typeof(MBDFNDLNIFF<>.IONOMNJJJEG))]
		public override Task<DNFCNMKAMCE<MFKBDIPIOIA<NONADBDKHEF>, OOJAGAFOLJL>> DFMDKDEHKMF(string IKMKCMDHFDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x493A910", Offset = "0x4939110", VA = "0x18493A910", Slot = "126")]
		public sealed override bool KJKBFGHOBBJ(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x493A9B0", Offset = "0x49391B0", VA = "0x18493A9B0", Slot = "114")]
		protected sealed override bool OLMHGCDDKKG(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x493A870", Offset = "0x4939070", VA = "0x18493A870", Slot = "115")]
		protected override bool JPKCPMCPLKO(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x493A760", Offset = "0x4938F60", VA = "0x18493A760", Slot = "103")]
		[AsyncStateMachine(typeof(MBDFNDLNIFF<>.KKDCBJFLOOI))]
		public override Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> DPCBHAPEKMM(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public sealed class POHALPFELAB : JGGDACCKCHI<MIFEKECIHPJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class JEPNOBNPDPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public POHALPFELAB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public JEPNOBNPDPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x22E5250", Offset = "0x22E3A50", VA = "0x1822E5250")]
			internal bool HAOODPDHEHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x22E52D0", Offset = "0x22E3AD0", VA = "0x1822E52D0")]
			internal void PBBLDMPBDPA(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x22E8B20", Offset = "0x22E7320", VA = "0x1822E8B20")]
		public POHALPFELAB(AOMCPFNEFFD LMIJAEAMIME, MIFEKECIHPJ CLCEHBDJMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x22E88D0", Offset = "0x22E70D0", VA = "0x1822E88D0", Slot = "128")]
		protected override void JFKPGMJHLNL(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private sealed class NKPIINMAHKI : DHGMGFCHOGH<GJNKGCMEEKH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x92F1C0", Offset = "0x92D9C0", VA = "0x18092F1C0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x22E7920", Offset = "0x22E6120", VA = "0x1822E7920")]
		public NKPIINMAHKI(AOMCPFNEFFD LMIJAEAMIME, GJNKGCMEEKH JLFLGGOOAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class DHGMGFCHOGH<TNode> : HLGBCEDEFMN<TNode> where TNode : notnull, IPJACONGPML
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct MMHOGMGJBLG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public AsyncTaskMethodBuilder<DNFCNMKAMCE<MFKBDIPIOIA<NONADBDKHEF>, OOJAGAFOLJL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public DHGMGFCHOGH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private TaskAwaiter<DNFCNMKAMCE<MFKBDIPIOIA<NONADBDKHEF>, OOJAGAFOLJL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x49E8050", Offset = "0x49E6850", VA = "0x1849E8050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x49E84E0", Offset = "0x49E6CE0", VA = "0x1849E84E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct GKMPOBHIIHL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public DHGMGFCHOGH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public MFKBDIPIOIA<NONADBDKHEF> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x413FEC0", Offset = "0x413E6C0", VA = "0x18413FEC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x4140330", Offset = "0x413EB30", VA = "0x184140330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private struct FLIDPALKMHB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public AsyncTaskMethodBuilder<DNFCNMKAMCE<GJKMPOLHKIA, OOJAGAFOLJL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public DHGMGFCHOGH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private TaskAwaiter<DNFCNMKAMCE<GJKMPOLHKIA, OOJAGAFOLJL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x4071820", Offset = "0x4070020", VA = "0x184071820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4071ED0", Offset = "0x40706D0", VA = "0x184071ED0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class HLLADMFILLN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000054")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public HLLADMFILLN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x39C5260", Offset = "0x39C3A60", VA = "0x1839C5260", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public AJNINOLHGBJ configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public DHGMGFCHOGH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public HLLADMFILLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x423D320", Offset = "0x423BB20", VA = "0x18423D320")]
			internal bool BMMNDIJLGFO(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x423D400", Offset = "0x423BC00", VA = "0x18423D400")]
			internal void FBICKDEKDMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x423D280", Offset = "0x423BA80", VA = "0x18423D280")]
			[AsyncStateMachine(typeof(DHGMGFCHOGH<>.HLLADMFILLN.<<BuildConfigMenuInternal>b__7>d))]
			internal void BFLKOFCGAAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x423D6E0", Offset = "0x423BEE0", VA = "0x18423D6E0")]
			internal bool JKEAAELNANL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class LPDHPPNMCCD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000056")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public LPDHPPNMCCD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0x39C4EF0", Offset = "0x39C36F0", VA = "0x1839C4EF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000160")]
				[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public HLLADMFILLN CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public LPDHPPNMCCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x47618C0", Offset = "0x47600C0", VA = "0x1847618C0")]
			internal void BCMIIJCJHFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
			internal string ADJPFJJKDFB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000")]
			internal void NNIOHDHPNHD(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x4761CC0", Offset = "0x47604C0", VA = "0x184761CC0")]
			[AsyncStateMachine(typeof(DHGMGFCHOGH<>.LPDHPPNMCCD.<<BuildConfigMenuInternal>b__5>d))]
			internal void CCDHILCAKBE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class LMFJAOEDOIG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public LMFJAOEDOIG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x39C4A20", Offset = "0x39C3220", VA = "0x1839C4A20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public LMFJAOEDOIG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<DNFCNMKAMCE<MFKBDIPIOIA<JPEJPKEPEEM>, OOJAGAFOLJL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x39C4C00", Offset = "0x39C3400", VA = "0x1839C4C00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005A")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000113")]
				public LMFJAOEDOIG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				private TaskAwaiter<DNFCNMKAMCE<MFKBDIPIOIA<EGNAIHIHHIJ>, OOJAGAFOLJL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0x39C4370", Offset = "0x39C2B70", VA = "0x1839C4370", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public DHGMGFCHOGH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public MFKBDIPIOIA<NONADBDKHEF> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public AJNINOLHGBJ configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public LFJDBLMIGGO nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public IPLLKAPKLNO selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public List<HHPHLGEDGLK> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public IPLLKAPKLNO selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public List<HHPHLGEDGLK> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public LMFJAOEDOIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x474D6D0", Offset = "0x474BED0", VA = "0x18474D6D0")]
			internal bool MGCFOGBMGKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x474D7F0", Offset = "0x474BFF0", VA = "0x18474D7F0")]
			internal void NEJIEPHKKDG(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x474D100", Offset = "0x474B900", VA = "0x18474D100")]
			internal bool EHNLIMDIIMB(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x474D5F0", Offset = "0x474BDF0", VA = "0x18474D5F0")]
			internal bool KCOCBMMPFBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x474D550", Offset = "0x474BD50", VA = "0x18474D550")]
			[AsyncStateMachine(typeof(DHGMGFCHOGH<>.LMFJAOEDOIG.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void KCGHBIHDLBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x474D690", Offset = "0x474BE90", VA = "0x18474D690")]
			internal bool LDFAAMNAPKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x474D420", Offset = "0x474BC20", VA = "0x18474D420")]
			internal void JAMLKOMDBKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x474D740", Offset = "0x474BF40", VA = "0x18474D740")]
			internal bool NAOJMFGHPEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x474D360", Offset = "0x474BB60", VA = "0x18474D360")]
			internal void IPMMCFGIGIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x474CF50", Offset = "0x474B750", VA = "0x18474CF50")]
			internal bool AOKLLKMIMJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x474D1E0", Offset = "0x474B9E0", VA = "0x18474D1E0")]
			internal bool EHODLBHMGEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x474D860", Offset = "0x474C060", VA = "0x18474D860")]
			internal void NOOKNENJMNE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x474D2C0", Offset = "0x474BAC0", VA = "0x18474D2C0")]
			[AsyncStateMachine(typeof(DHGMGFCHOGH<>.LMFJAOEDOIG.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void INNAONELLMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x474D0A0", Offset = "0x474B8A0", VA = "0x18474D0A0")]
			internal bool DJKFMHOPBFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x474D250", Offset = "0x474BA50", VA = "0x18474D250")]
			internal bool GEEPEHNFOEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x474D4E0", Offset = "0x474BCE0", VA = "0x18474D4E0")]
			internal void JHHPOKOJCLA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x474D000", Offset = "0x474B800", VA = "0x18474D000")]
			[AsyncStateMachine(typeof(DHGMGFCHOGH<>.LMFJAOEDOIG.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void CNBAIOCFPFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x474D630", Offset = "0x474BE30", VA = "0x18474D630")]
			internal bool LBNDMJNKEBJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class GCJPPCINAGA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public GCJPPCINAGA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x39C4660", Offset = "0x39C2E60", VA = "0x1839C4660", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000180")]
				[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public LMFJAOEDOIG CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public GCJPPCINAGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x4124430", Offset = "0x4122C30", VA = "0x184124430")]
			internal void MDJNODBOGEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
			internal string ADLNNNFFFEC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000")]
			internal void IADPFNJKLOE(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4124830", Offset = "0x4123030", VA = "0x184124830")]
			[AsyncStateMachine(typeof(DHGMGFCHOGH<>.GCJPPCINAGA.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void MDMCJFHAMDG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class FPPOJFLFEMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public LFJDBLMIGGO nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public List<HHPHLGEDGLK> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public DHGMGFCHOGH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public MFKBDIPIOIA<NONADBDKHEF> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public FPPOJFLFEMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4082400", Offset = "0x4080C00", VA = "0x184082400")]
			internal bool JNEADPBANLH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class DLDFHMLPAAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public JOAECAAFOOM port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public FPPOJFLFEMA CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public DLDFHMLPAAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x5DEE980", Offset = "0x5DED180", VA = "0x185DEE980")]
			internal void HJPEDJENIPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x5DEEA90", Offset = "0x5DED290", VA = "0x185DEEA90")]
			internal bool KCLFKEABEMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x5DEE800", Offset = "0x5DED000", VA = "0x185DEE800")]
			internal void EPNNAOEIMCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x5DEE920", Offset = "0x5DED120", VA = "0x185DEE920")]
			internal bool GLFAMKIBFCO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class DOBPBJBILBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public HHPHLGEDGLK portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public DLDFHMLPAAH CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public DOBPBJBILBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x5E020A0", Offset = "0x5E008A0", VA = "0x185E020A0")]
			internal void OCFCNHMAPIP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class NBLAONDCECL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000061")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public NBLAONDCECL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x39C6690", Offset = "0x39C4E90", VA = "0x1839C6690", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public IPLLKAPKLNO selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public LFJDBLMIGGO nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public JOAECAAFOOM port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public NBLAONDCECL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x4A3B3C0", Offset = "0x4A39BC0", VA = "0x184A3B3C0")]
			internal int OIBCMCCCDJA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x4A3B0A0", Offset = "0x4A398A0", VA = "0x184A3B0A0")]
			internal void CJOFAOCLMEH(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8BB260", Offset = "0x8B9A60", VA = "0x1808BB260")]
			internal string OLIJAFNIBGN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x4A3B400", Offset = "0x4A39C00", VA = "0x184A3B400")]
			[AsyncStateMachine(typeof(DHGMGFCHOGH<>.NBLAONDCECL.<<CreatePortItemV2>b__3>d))]
			internal void OLPFOBJJHNN(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x4A3B2E0", Offset = "0x4A39AE0", VA = "0x184A3B2E0")]
			internal bool NFFPAMJFKMF(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly Dictionary<MFKBDIPIOIA<NONADBDKHEF>, bool> NOJJICKLPLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly Dictionary<MFKBDIPIOIA<NONADBDKHEF>, bool> EEBPELNMGEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly Dictionary<MFKBDIPIOIA<NONADBDKHEF>, bool> GKLICJODFJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private Dictionary<MFKBDIPIOIA<NONADBDKHEF>, bool> AOPLFPGNBKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private Dictionary<MFKBDIPIOIA<NONADBDKHEF>, bool> FFEBICABOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private Dictionary<MFKBDIPIOIA<NONADBDKHEF>, bool> LFEONCNPNLO;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool GMCFANOMKPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "124")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool BJKKMNCOBKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool MKKNJGBGOJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool ALPOCFIFADC
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override MFKBDIPIOIA<JFDGELHFKII>? HMBGHOHADAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x5DE3DB0", Offset = "0x5DE25B0", VA = "0x185DE3DB0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override MFKBDIPIOIA<NONADBDKHEF>? FIIEGOPMGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5DE4080", Offset = "0x5DE2880", VA = "0x185DE4080", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<JOEFEFGKPAB<BAFEGHIGBOE>>? CFIMIOAADPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x5DE3E70", Offset = "0x5DE2670", VA = "0x185DE3E70", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3B90", Offset = "0x5DE2390", VA = "0x185DE3B90")]
		public DHGMGFCHOGH(AOMCPFNEFFD LMIJAEAMIME, TNode JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "131")]
		protected virtual bool HDMEKMHNEDF(int DJBKAPPAAHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "132")]
		protected virtual bool NEGNFLGPHHN(int DJBKAPPAAHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "133")]
		protected virtual bool KCNJOPFFCDA(int DJBKAPPAAHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "134")]
		protected virtual void NLOEFGLCLPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE1B90", Offset = "0x5DE0390", VA = "0x185DE1B90", Slot = "126")]
		public override bool KJKBFGHOBBJ(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF670", Offset = "0x5DDDE70", VA = "0x185DDF670", Slot = "102")]
		[AsyncStateMachine(typeof(DHGMGFCHOGH<>.MMHOGMGJBLG))]
		public override Task<DNFCNMKAMCE<MFKBDIPIOIA<NONADBDKHEF>, OOJAGAFOLJL>> DFMDKDEHKMF(string IKMKCMDHFDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFA10", Offset = "0x5DDE210", VA = "0x185DDFA10", Slot = "103")]
		[AsyncStateMachine(typeof(DHGMGFCHOGH<>.GKMPOBHIIHL))]
		public override Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> DPCBHAPEKMM(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3990", Offset = "0x5DE2190", VA = "0x185DE3990", Slot = "104")]
		public override void PMEIPEHPMLB(MFKBDIPIOIA<NONADBDKHEF> ECDOOAABOPD, MFKBDIPIOIA<NONADBDKHEF> BIINCLMPDMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF300", Offset = "0x5DDDB00", VA = "0x185DDF300", Slot = "105")]
		public override IEnumerable<MKGNMHKEPFM> APCMJBLNPKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF570", Offset = "0x5DDDD70", VA = "0x185DDF570")]
		[AsyncStateMachine(typeof(DHGMGFCHOGH<>.FLIDPALKMHB))]
		private Task<DNFCNMKAMCE<GJKMPOLHKIA, OOJAGAFOLJL>> CPNHHNKNNGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "135")]
		protected virtual bool GFNGNFAICGJ(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "136")]
		protected virtual bool KIBDIENAJGM(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "137")]
		protected virtual bool ONLHCJINOAJ(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "138")]
		protected virtual bool LANNLFIKHMI(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "139")]
		protected virtual bool FCHGIDCHBAO(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, int HFONNPCCCCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "140")]
		protected virtual bool FPOKLMICGAC(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, int HFONNPCCCCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "141")]
		protected virtual bool KKLJPLGPJIA(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, int CKMECACPDFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "142")]
		protected virtual bool IDAIAJGLAPH(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, int CKMECACPDFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "143")]
		protected virtual bool LCEONJFCAID(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, int MBDHFCHAHDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "144")]
		protected virtual bool JJAHHJNOLAL(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, int HFNEAMCNOBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF790", Offset = "0x5DDDF90", VA = "0x185DDF790", Slot = "145")]
		protected virtual List<IPLLKAPKLNO> DJOMCBBLDMD(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "146")]
		protected virtual void FHIIFPGNJMC(AJNINOLHGBJ DEFPDELPAGI, BGPJNADELIJ FNFHGLMMHIG, LFJDBLMIGGO AKCPKIPKPHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2F40", Offset = "0x5DE1740", VA = "0x185DE2F40", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFB20", Offset = "0x5DDE320", VA = "0x185DDFB20")]
		private BGPJNADELIJ EPDCEIODKMH(AJNINOLHGBJ DEFPDELPAGI, LFJDBLMIGGO AKCPKIPKPHN, MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5DE1C30", Offset = "0x5DE0430", VA = "0x185DE1C30")]
		private List<HHPHLGEDGLK> LBBJADFCOLE(AJNINOLHGBJ DEFPDELPAGI, LFJDBLMIGGO AKCPKIPKPHN, BGPJNADELIJ JHMHFCNMAEB, bool FMFMIBEMFDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5DE1250", Offset = "0x5DDFA50", VA = "0x185DE1250")]
		private List<HHPHLGEDGLK> JFENDEHJBOM(AJNINOLHGBJ DEFPDELPAGI, LFJDBLMIGGO AKCPKIPKPHN, JOAECAAFOOM NHIJINHMIHB, bool FMFMIBEMFDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2D50", Offset = "0x5DE1550", VA = "0x185DE2D50")]
		private IPLLKAPKLNO OMILINNLOFH(List<IPLLKAPKLNO> EHJLGDFKJOA, JOAECAAFOOM NHIJINHMIHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF270", Offset = "0x5DDDA70", VA = "0x185DDF270")]
		[CompilerGenerated]
		private MKGNMHKEPFM AMNBGMOPBIF(GLIPNLBBOGL KKPBEBNOEKN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class LEABLGBOAPH : HLGBCEDEFMN<NMFKHNEPDIF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class EOLPBBBCGHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public LEABLGBOAPH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public EOLPBBBCGHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x22D1830", Offset = "0x22D0030", VA = "0x1822D1830")]
			internal int FBICKDEKDMK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x22D1880", Offset = "0x22D0080", VA = "0x1822D1880")]
			internal void JKEAAELNANL(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xC76AB0", Offset = "0xC752B0", VA = "0x180C76AB0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x22E66E0", Offset = "0x22E4EE0", VA = "0x1822E66E0")]
		public LEABLGBOAPH(AOMCPFNEFFD LMIJAEAMIME, NMFKHNEPDIF JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x22E6520", Offset = "0x22E4D20", VA = "0x1822E6520", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class PKGKFGIFKDL : JGGDACCKCHI<HAPJPPGDKFC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class PAIBFAKAKGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public PKGKFGIFKDL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public PAIBFAKAKGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x22E8510", Offset = "0x22E6D10", VA = "0x1822E8510")]
			internal int HAOODPDHEHL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x22E8590", Offset = "0x22E6D90", VA = "0x1822E8590")]
			internal void PBBLDMPBDPA(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x22E8870", Offset = "0x22E7070", VA = "0x1822E8870")]
		public PKGKFGIFKDL(AOMCPFNEFFD LMIJAEAMIME, HAPJPPGDKFC CLCEHBDJMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x22E8630", Offset = "0x22E6E30", VA = "0x1822E8630", Slot = "128")]
		protected override void JFKPGMJHLNL(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private sealed class IIGJBNCHFKO : HLGBCEDEFMN<BPFOCFDFABA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x9918C0", Offset = "0x9900C0", VA = "0x1809918C0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x22E4330", Offset = "0x22E2B30", VA = "0x1822E4330")]
		public IIGJBNCHFKO(AOMCPFNEFFD LMIJAEAMIME, BPFOCFDFABA JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public sealed class GOHNICDDDJG : HLGBCEDEFMN<HIIMDDIMLFH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class FLLDAIMKAHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public GOHNICDDDJG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public AJNINOLHGBJ configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public FLLDAIMKAHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x22D9E00", Offset = "0x22D8600", VA = "0x1822D9E00")]
			internal bool FBICKDEKDMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x22DB830", Offset = "0x22DA030", VA = "0x1822DB830")]
			internal void JKEAAELNANL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x22DC9A0", Offset = "0x22DB1A0", VA = "0x1822DC9A0")]
			internal bool NNIOHDHPNHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x22D3140", Offset = "0x22D1940", VA = "0x1822D3140")]
			internal bool CCDHILCAKBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x22D2F10", Offset = "0x22D1710", VA = "0x1822D2F10")]
			internal void BMMNDIJLGFO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x22DA7D0", Offset = "0x22D8FD0", VA = "0x1822DA7D0")]
			internal bool GKAHJJPHGPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x22D2920", Offset = "0x22D1120", VA = "0x1822D2920")]
			internal bool BBIPEDMKAKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x22DA350", Offset = "0x22D8B50", VA = "0x1822DA350")]
			internal void FIDHDNALDIJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x22D9E50", Offset = "0x22D8650", VA = "0x1822D9E50")]
			internal bool FBMPBAKPIFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x22DBCA0", Offset = "0x22DA4A0", VA = "0x1822DBCA0")]
			internal bool KJGFDDHLKOB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x22D3520", Offset = "0x22D1D20", VA = "0x1822D3520")]
			internal void DAKOPIDPJLM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x22D3010", Offset = "0x22D1810", VA = "0x1822D3010")]
			internal bool BPFPDCMNIAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x22D3580", Offset = "0x22D1D80", VA = "0x1822D3580")]
			internal bool DBEIIINCEGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x22DC770", Offset = "0x22DAF70", VA = "0x1822DC770")]
			internal bool NEIKGOFALIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x22DA2B0", Offset = "0x22D8AB0", VA = "0x1822DA2B0")]
			internal bool FFLOBBHFPPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x22D36C0", Offset = "0x22D1EC0", VA = "0x1822D36C0")]
			internal bool DJPBBEHIEFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x22DB3C0", Offset = "0x22D9BC0", VA = "0x1822DB3C0")]
			internal bool INLHMKKFDAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x22D35D0", Offset = "0x22D1DD0", VA = "0x1822D35D0")]
			internal bool DDCDMEMLHOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x22DC9F0", Offset = "0x22DB1F0", VA = "0x1822DC9F0")]
			internal bool NNLCCLGPDGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x22DB4B0", Offset = "0x22D9CB0", VA = "0x1822DB4B0")]
			internal bool IOLBFDOOACN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x22DB930", Offset = "0x22DA130", VA = "0x1822DB930")]
			internal void JNPKPCJLNCP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x22DB370", Offset = "0x22D9B70", VA = "0x1822DB370")]
			internal bool ILKLLLJPBGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x22DA730", Offset = "0x22D8F30", VA = "0x1822DA730")]
			internal bool GILNIDOBBHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x22DC810", Offset = "0x22DB010", VA = "0x1822DC810")]
			internal bool NFFFGIHBGLC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x22DADA0", Offset = "0x22D95A0", VA = "0x1822DADA0")]
			internal bool HLPNGFDEPDP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x22DABC0", Offset = "0x22D93C0", VA = "0x1822DABC0")]
			internal bool HFHPHBCOOAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x22DBC50", Offset = "0x22DA450", VA = "0x1822DBC50")]
			internal bool KIFLDCMPCJD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x22DC2F0", Offset = "0x22DAAF0", VA = "0x1822DC2F0")]
			internal bool LMKNMEHPKKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x22D25B0", Offset = "0x22D0DB0", VA = "0x1822D25B0")]
			internal bool ABOECHNPNEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x22DCAB0", Offset = "0x22DB2B0", VA = "0x1822DCAB0")]
			internal void NPDOJCBADKI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x22DC200", Offset = "0x22DAA00", VA = "0x1822DC200")]
			internal bool LHAPFBILDII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x22DC480", Offset = "0x22DAC80", VA = "0x1822DC480")]
			internal bool MDKAGLJAJEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x22DAA20", Offset = "0x22D9220", VA = "0x1822DAA20")]
			internal void HAIIEEIDAGD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x22DB630", Offset = "0x22D9E30", VA = "0x1822DB630")]
			internal bool JEKCEMNOPJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x22DAE60", Offset = "0x22D9660", VA = "0x1822DAE60")]
			internal bool HOGAKPLKFMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x22DD0D0", Offset = "0x22DB8D0", VA = "0x1822DD0D0")]
			internal void PCMAFKEDAIO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x22D3C30", Offset = "0x22D2430", VA = "0x1822D3C30")]
			internal List<HHPHLGEDGLK> ELCMGELDCPC(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x22D3A60", Offset = "0x22D2260", VA = "0x1822D3A60")]
			internal bool ECOANJEILAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x22DC250", Offset = "0x22DAA50", VA = "0x1822DC250")]
			internal int LIICOIHBJNC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x22DB730", Offset = "0x22D9F30", VA = "0x1822DB730")]
			internal void JHBJNJHBMMA(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x22DCF70", Offset = "0x22DB770", VA = "0x1822DCF70")]
			internal bool OPLJKBCFHDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x22D3380", Offset = "0x22D1B80", VA = "0x1822D3380")]
			internal bool CGMNCNIBOEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x22D3420", Offset = "0x22D1C20", VA = "0x1822D3420")]
			internal bool CJEHFPHAPGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x22DB7E0", Offset = "0x22D9FE0", VA = "0x1822DB7E0")]
			internal int JIFHEMICAHD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x22DBA50", Offset = "0x22DA250", VA = "0x1822DBA50")]
			internal void KDBFOFNBNCK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x22D2510", Offset = "0x22D0D10", VA = "0x1822D2510")]
			internal bool ABAAMMOEINN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x22DD270", Offset = "0x22DBA70", VA = "0x1822DD270")]
			internal bool PIOCHHFLJBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x22DC160", Offset = "0x22DA960", VA = "0x1822DC160")]
			internal bool LFCPDJIICAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x22D2790", Offset = "0x22D0F90", VA = "0x1822D2790")]
			internal bool APKDIBDMEHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x22DCD20", Offset = "0x22DB520", VA = "0x1822DCD20")]
			internal bool OKCCEDJENDJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x22DAA80", Offset = "0x22D9280", VA = "0x1822DAA80")]
			internal bool HBHMMCEAPBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x22DA170", Offset = "0x22D8970", VA = "0x1822DA170")]
			internal string FCGOLBCPNFI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x22DBCF0", Offset = "0x22DA4F0", VA = "0x1822DBCF0")]
			internal void KKFAODIAABN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x22D2560", Offset = "0x22D0D60", VA = "0x1822D2560")]
			internal int ABBOCDNGOLP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x22DA920", Offset = "0x22D9120", VA = "0x1822DA920")]
			internal void GOPBMHPKHHD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x22D3240", Offset = "0x22D1A40", VA = "0x1822D3240")]
			internal bool CDKFCMBELFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x22DD130", Offset = "0x22DB930", VA = "0x1822DD130")]
			internal bool PDAKKKEGIBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x22DB790", Offset = "0x22D9F90", VA = "0x1822DB790")]
			internal bool JHMOOIOKLOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x22D3B00", Offset = "0x22D2300", VA = "0x1822D3B00")]
			internal float EJDBEINPCCJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x22DB680", Offset = "0x22D9E80", VA = "0x1822DB680")]
			internal void JEKNKPCKIJC(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x22DA580", Offset = "0x22D8D80", VA = "0x1822DA580")]
			internal bool GFBBFIADCEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x22DA300", Offset = "0x22D8B00", VA = "0x1822DA300")]
			internal bool FGOEGBENEAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x22D3760", Offset = "0x22D1F60", VA = "0x1822D3760")]
			internal bool DKMOHEEIMGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x22DB890", Offset = "0x22DA090", VA = "0x1822DB890")]
			internal bool JLICPODOEFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x22DCE60", Offset = "0x22DB660", VA = "0x1822DCE60")]
			internal bool ONEMOKLGHCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x22D2FC0", Offset = "0x22D17C0", VA = "0x1822D2FC0")]
			internal bool BNOALCJLAJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x22D2B50", Offset = "0x22D1350", VA = "0x1822D2B50")]
			internal void BKAGHHHJNIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x22DAF50", Offset = "0x22D9750", VA = "0x1822DAF50")]
			internal string IAFPLPONIMB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x22DCF00", Offset = "0x22DB700", VA = "0x1822DCF00")]
			internal void OPFCEIDJIAN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x22DC110", Offset = "0x22DA910", VA = "0x1822DC110")]
			internal bool LDEJEAICDNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x22D3BE0", Offset = "0x22D23E0", VA = "0x1822D3BE0")]
			internal bool ELCIEOILLMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x22DAF00", Offset = "0x22D9700", VA = "0x1822DAF00")]
			internal bool IADCCLOLDBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x22D9EA0", Offset = "0x22D86A0", VA = "0x1822D9EA0")]
			internal void FCCCBKOCJPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x22DD220", Offset = "0x22DBA20", VA = "0x1822DD220")]
			internal bool PIKDADJGBKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x22DB060", Offset = "0x22D9860", VA = "0x1822DB060")]
			internal bool IAPJBCDKLFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x22DC520", Offset = "0x22DAD20", VA = "0x1822DC520")]
			internal bool MLHFGIFLGJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x22DBC00", Offset = "0x22DA400", VA = "0x1822DBC00")]
			internal bool KGBMPGNNLCP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x22DC0B0", Offset = "0x22DA8B0", VA = "0x1822DC0B0")]
			internal void LCNKBNDBIBC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x22DC3E0", Offset = "0x22DABE0", VA = "0x1822DC3E0")]
			internal bool MBNHEHOEKNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x22DC390", Offset = "0x22DAB90", VA = "0x1822DC390")]
			internal bool MAGHOAGKBDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x22DBAB0", Offset = "0x22DA2B0", VA = "0x1822DBAB0")]
			internal bool KEGMFONPPFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x22DA530", Offset = "0x22D8D30", VA = "0x1822DA530")]
			internal bool GDEFNFBJALA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x22DBB50", Offset = "0x22DA350", VA = "0x1822DBB50")]
			internal void KFAKMLILPCB(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x22DA9D0", Offset = "0x22D91D0", VA = "0x1822DA9D0")]
			internal bool GPDNBJMKNIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x22DC5C0", Offset = "0x22DADC0", VA = "0x1822DC5C0")]
			internal bool MMDOEGOGFJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x22D9DB0", Offset = "0x22D85B0", VA = "0x1822D9DB0")]
			internal bool EMJNKBHHCLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x22DAAD0", Offset = "0x22D92D0", VA = "0x1822DAAD0")]
			internal bool HCBKEHEMIIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x22DAFA0", Offset = "0x22D97A0", VA = "0x1822DAFA0")]
			internal object IAKJBCIIEAL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x22D3B50", Offset = "0x22D2350", VA = "0x1822D3B50")]
			internal void EKIAMDDBKFC(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x22DC900", Offset = "0x22DB100", VA = "0x1822DC900")]
			internal bool NLIBCOLJKJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x22D3900", Offset = "0x22D2100", VA = "0x1822D3900")]
			internal bool ECAEOEKHBGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x22D37B0", Offset = "0x22D1FB0", VA = "0x1822D37B0")]
			internal int DLGHLIKIJCN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x22DA400", Offset = "0x22D8C00", VA = "0x1822DA400")]
			internal void FKIHBHDPBEL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x22D3860", Offset = "0x22D2060", VA = "0x1822D3860")]
			internal bool DMLNLMLAHFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x22DB010", Offset = "0x22D9810", VA = "0x1822DB010")]
			internal bool IALGENPIDNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x22DAEB0", Offset = "0x22D96B0", VA = "0x1822DAEB0")]
			internal int HPLGCDOHLMA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x22DCC20", Offset = "0x22DB420", VA = "0x1822DCC20")]
			internal void ODACBPONEJK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x22DA210", Offset = "0x22D8A10", VA = "0x1822DA210")]
			internal bool FDCOAJFDJMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x22DC7C0", Offset = "0x22DAFC0", VA = "0x1822DC7C0")]
			internal bool NELGPCJCMKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x22DB100", Offset = "0x22D9900", VA = "0x1822DB100")]
			internal bool ICBHDDDJPKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x22D2650", Offset = "0x22D0E50", VA = "0x1822D2650")]
			internal int AJHCGBBABND()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x22DA460", Offset = "0x22D8C60", VA = "0x1822DA460")]
			internal void FLJHCPFPPJF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x22D2830", Offset = "0x22D1030", VA = "0x1822D2830")]
			internal bool BADNONIFLOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x22D2A10", Offset = "0x22D1210", VA = "0x1822D2A10")]
			internal bool BECPFCFLMKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x22D26F0", Offset = "0x22D0EF0", VA = "0x1822D26F0")]
			internal bool AMKHLCEDFCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x22DA670", Offset = "0x22D8E70", VA = "0x1822DA670")]
			internal object GHFGOCHHPIE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x22D30B0", Offset = "0x22D18B0", VA = "0x1822D30B0")]
			internal void CBIIDHONEPK(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x22DBE00", Offset = "0x22DA600", VA = "0x1822DBE00")]
			internal bool KNFJIMNNMCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x22DA620", Offset = "0x22D8E20", VA = "0x1822DA620")]
			internal bool GGJNMPEBKLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x22DCFC0", Offset = "0x22DB7C0", VA = "0x1822DCFC0")]
			internal object PBMMKGKDBBB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x22DBE50", Offset = "0x22DA650", VA = "0x1822DBE50")]
			internal void KOGAFDFIBKM(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x22DCD70", Offset = "0x22DB570", VA = "0x1822DCD70")]
			internal bool OLFPNOCHBLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x22DCB80", Offset = "0x22DB380", VA = "0x1822DCB80")]
			internal int OCBCAJHEODL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x22D31E0", Offset = "0x22D19E0", VA = "0x1822D31E0")]
			internal void CCLGDKMDFBC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x22DC060", Offset = "0x22DA860", VA = "0x1822DC060")]
			internal bool LCHJHANMGFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x22DBFA0", Offset = "0x22DA7A0", VA = "0x1822DBFA0")]
			internal bool LALPGACHINL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x22DB1A0", Offset = "0x22D99A0", VA = "0x1822DB1A0")]
			internal bool IEEOPACDMKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x22DC430", Offset = "0x22DAC30", VA = "0x1822DC430")]
			internal int MCPGNGJFCGG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x22DBF40", Offset = "0x22DA740", VA = "0x1822DBF40")]
			internal void LAEALELNLKM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x22DAD00", Offset = "0x22D9500", VA = "0x1822DAD00")]
			internal bool HJCAGMPJGMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x22D3190", Offset = "0x22D1990", VA = "0x1822D3190")]
			internal bool CCIMHBIKOJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x22D3670", Offset = "0x22D1E70", VA = "0x1822D3670")]
			internal bool DJJPFGJJFDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x22D3710", Offset = "0x22D1F10", VA = "0x1822D3710")]
			internal float DKIHLGFGIPG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x22D3800", Offset = "0x22D2000", VA = "0x1822D3800")]
			internal void DMFAKGBPEHH(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x22D2880", Offset = "0x22D1080", VA = "0x1822D2880")]
			internal bool BALNOMNPNBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x22DB6E0", Offset = "0x22D9EE0", VA = "0x1822DB6E0")]
			internal bool JFPEPGCHDKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x22DBA00", Offset = "0x22DA200", VA = "0x1822DBA00")]
			internal bool KAFNIOHGMNH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x22DB1F0", Offset = "0x22D99F0", VA = "0x1822DB1F0")]
			internal float IIGLFNIKBAO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x22DBEE0", Offset = "0x22DA6E0", VA = "0x1822DBEE0")]
			internal void LAAFEPPCHEG(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x22DB460", Offset = "0x22D9C60", VA = "0x1822DB460")]
			internal bool IOKFGJLELNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x22D24C0", Offset = "0x22D0CC0", VA = "0x1822D24C0")]
			internal bool AABMHMFDNLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x22DC4D0", Offset = "0x22DACD0", VA = "0x1822DC4D0")]
			internal string MGAPOACJHLE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x22DC610", Offset = "0x22DAE10", VA = "0x1822DC610")]
			internal void MNIDHEPMPEO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x22DA780", Offset = "0x22D8F80", VA = "0x1822DA780")]
			internal bool GJPGJNHCKFG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x22DD030", Offset = "0x22DB830", VA = "0x1822DD030")]
			internal bool PCBPMLKLJOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x22D2AB0", Offset = "0x22D12B0", VA = "0x1822D2AB0")]
			internal bool BHKDPHAIOOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x22DCBD0", Offset = "0x22DB3D0", VA = "0x1822DCBD0")]
			internal bool OCFJJIOPIND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x22D2A60", Offset = "0x22D1260", VA = "0x1822D2A60")]
			internal string BFMKPCELLEB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x22DB990", Offset = "0x22DA190", VA = "0x1822DB990")]
			internal void KADKENEJIJK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x22DBBB0", Offset = "0x22DA3B0", VA = "0x1822DBBB0")]
			internal bool KGAJBMIAJHL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x22DAB20", Offset = "0x22D9320", VA = "0x1822DAB20")]
			internal bool HCOMDIMDEKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x22D2F70", Offset = "0x22D1770", VA = "0x1822D2F70")]
			internal bool BNJCDAOFILC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x22DA8D0", Offset = "0x22D90D0", VA = "0x1822DA8D0")]
			internal bool GMDPOJDHFBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x22D33D0", Offset = "0x22D1BD0", VA = "0x1822D33D0")]
			internal string CHINJMCCLID()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x22DADF0", Offset = "0x22D95F0", VA = "0x1822DADF0")]
			internal void HMEDPLKDHBO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x22DBB00", Offset = "0x22DA300", VA = "0x1822DBB00")]
			internal bool KFAABNGCILO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x22DA1C0", Offset = "0x22D89C0", VA = "0x1822DA1C0")]
			internal bool FCPGLALEPCM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x22DC2A0", Offset = "0x22DAAA0", VA = "0x1822DC2A0")]
			internal bool LJFIFNEKMBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x22DAC60", Offset = "0x22D9460", VA = "0x1822DAC60")]
			internal bool HHOKNNDBFBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x22D2600", Offset = "0x22D0E00", VA = "0x1822D2600")]
			internal string AHHCFEMOFKE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x22D39F0", Offset = "0x22D21F0", VA = "0x1822D39F0")]
			internal void ECMKHFLLAED(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x22DD080", Offset = "0x22DB880", VA = "0x1822DD080")]
			internal bool PCHMBKEIDLB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x22D2970", Offset = "0x22D1170", VA = "0x1822D2970")]
			internal bool BBNGONLEKLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x22D3060", Offset = "0x22D1860", VA = "0x1822D3060")]
			internal bool CAHFJDJKOHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x22DD1D0", Offset = "0x22DB9D0", VA = "0x1822DD1D0")]
			internal bool PFJHGOGFBMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x22D3330", Offset = "0x22D1B30", VA = "0x1822D3330")]
			internal string CFHGEBDHJPC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x22DB5C0", Offset = "0x22D9DC0", VA = "0x1822DB5C0")]
			internal void JDGHINGNADP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x22D28D0", Offset = "0x22D10D0", VA = "0x1822D28D0")]
			internal bool BBGJMLEHGBD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x22DC680", Offset = "0x22DAE80", VA = "0x1822DC680")]
			internal bool MPGOAJONGFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x22DC950", Offset = "0x22DB150", VA = "0x1822DC950")]
			internal bool NMDECDGCKAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x22D29C0", Offset = "0x22D11C0", VA = "0x1822D29C0")]
			internal bool BCIPLGEKFCP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x22DA3B0", Offset = "0x22D8BB0", VA = "0x1822DA3B0")]
			internal string FIIEOEFIMPH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x22DA4C0", Offset = "0x22D8CC0", VA = "0x1822DA4C0")]
			internal void FOGLMKPKOIN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x22DBDB0", Offset = "0x22DA5B0", VA = "0x1822DBDB0")]
			internal bool KLLHEJKPBOH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x22DC340", Offset = "0x22DAB40", VA = "0x1822DC340")]
			internal bool LPAMCHCDOBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x22DACB0", Offset = "0x22D94B0", VA = "0x1822DACB0")]
			internal bool HIOOBLKMKEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x22DB0B0", Offset = "0x22D98B0", VA = "0x1822DB0B0")]
			internal bool IBPANHMHIHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x22D39A0", Offset = "0x22D21A0", VA = "0x1822D39A0")]
			internal string ECLELKPCOII()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x22DBFF0", Offset = "0x22DA7F0", VA = "0x1822DBFF0")]
			internal void LBMJOBMILIC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x22D3620", Offset = "0x22D1E20", VA = "0x1822D3620")]
			internal bool DHPOPHPHHKN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x22DB2B0", Offset = "0x22D9AB0", VA = "0x1822DB2B0")]
			internal bool IKJNPMFDIKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x22DCE10", Offset = "0x22DB610", VA = "0x1822DCE10")]
			internal bool ONDGJLFNALM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x22DA880", Offset = "0x22D9080", VA = "0x1822DA880")]
			internal bool GLNLCPBPFOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x22DC6D0", Offset = "0x22DAED0", VA = "0x1822DC6D0")]
			internal string NBNJMLCKMEK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x22DB550", Offset = "0x22D9D50", VA = "0x1822DB550")]
			internal void JDBIAKKMKBE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x22D2740", Offset = "0x22D0F40", VA = "0x1822D2740")]
			internal bool ANEMENKBIGD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x22DC720", Offset = "0x22DAF20", VA = "0x1822DC720")]
			internal bool NDPOIGBMIME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x22D38B0", Offset = "0x22D20B0", VA = "0x1822D38B0")]
			internal bool DPADIMAJKLP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x22DA6E0", Offset = "0x22D8EE0", VA = "0x1822DA6E0")]
			internal bool GHGCJFEFPBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x22D34D0", Offset = "0x22D1CD0", VA = "0x1822D34D0")]
			internal string COFGOPBNBJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x22DCB10", Offset = "0x22DB310", VA = "0x1822DCB10")]
			internal void OBAGKADNHBL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x22D2B00", Offset = "0x22D1300", VA = "0x1822D2B00")]
			internal bool BJBPAEICEKL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x22DA5D0", Offset = "0x22D8DD0", VA = "0x1822DA5D0")]
			internal bool GGEDPMNBNJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x22DA260", Offset = "0x22D8A60", VA = "0x1822DA260")]
			internal bool FEIDPJFPAMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x22D27E0", Offset = "0x22D0FE0", VA = "0x1822D27E0")]
			internal bool BACJJECJPAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x22DCEB0", Offset = "0x22DB6B0", VA = "0x1822DCEB0")]
			internal string OPCJBNMFANC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x22DB240", Offset = "0x22D9A40", VA = "0x1822DB240")]
			internal void IJGNJEHEGFP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x22DB8E0", Offset = "0x22DA0E0", VA = "0x1822DB8E0")]
			internal bool JLILPFIPNGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x22DC860", Offset = "0x22DB060", VA = "0x1822DC860")]
			internal bool NFPJHPBODGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x22DB410", Offset = "0x22D9C10", VA = "0x1822DB410")]
			internal bool IOGAMNMDNAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x22D3290", Offset = "0x22D1A90", VA = "0x1822D3290")]
			internal string CEFKDCEANKC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x22DCA40", Offset = "0x22DB240", VA = "0x1822DCA40")]
			internal void NNNFJBMGAHD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x22DC1B0", Offset = "0x22DA9B0", VA = "0x1822DC1B0")]
			internal bool LHAKDHBLHNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x22DAB70", Offset = "0x22D9370", VA = "0x1822DAB70")]
			internal bool HEJMHIKCKPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x22DCDC0", Offset = "0x22DB5C0", VA = "0x1822DCDC0")]
			internal bool OLKEIIMGDJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x22DBD60", Offset = "0x22DA560", VA = "0x1822DBD60")]
			internal string KKGOGEMGIMG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x22D9D40", Offset = "0x22D8540", VA = "0x1822D9D40")]
			internal void ELFCDLLLDBD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x22DB150", Offset = "0x22D9950", VA = "0x1822DB150")]
			internal bool ICGOBJEABPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x22D26A0", Offset = "0x22D0EA0", VA = "0x1822D26A0")]
			internal bool AMGNIENDLLC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x22DB500", Offset = "0x22D9D00", VA = "0x1822DB500")]
			internal bool JAMIEFILDNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x22D32E0", Offset = "0x22D1AE0", VA = "0x1822D32E0")]
			internal string CFGCDEEPFID()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x22DB300", Offset = "0x22D9B00", VA = "0x1822DB300")]
			internal void ILHLCACBLNA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x22DC8B0", Offset = "0x22DB0B0", VA = "0x1822DC8B0")]
			internal bool NHIKIONNKNC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x22DAD50", Offset = "0x22D9550", VA = "0x1822DAD50")]
			internal bool HJOLBMHKPBP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x22DD180", Offset = "0x22DB980", VA = "0x1822DD180")]
			internal float PEGBKPJGECC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x22D3470", Offset = "0x22D1C70", VA = "0x1822D3470")]
			internal void COFFGLLKLIB(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x22DA980", Offset = "0x22D9180", VA = "0x1822DA980")]
			internal bool GPABKHIHPDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x22DC570", Offset = "0x22DAD70", VA = "0x1822DC570")]
			internal bool MLHJHPFHOBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x22DCC80", Offset = "0x22DB480", VA = "0x1822DCC80")]
			internal bool ODEHDEMMPDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x22D3950", Offset = "0x22D2150", VA = "0x1822D3950")]
			internal int ECDJJJHPAHK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x22DA820", Offset = "0x22D9020", VA = "0x1822DA820")]
			internal void GLFEBBFHJKH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x22D3AB0", Offset = "0x22D22B0", VA = "0x1822D3AB0")]
			internal bool EEEBNKLIEEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x22DCCD0", Offset = "0x22DB4D0", VA = "0x1822DCCD0")]
			internal bool OFPIMEAGAOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x22DAC10", Offset = "0x22D9410", VA = "0x1822DAC10")]
			internal bool HGKBNGDLFDL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class DFEMCJBDEMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public FLLDAIMKAHO CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public DFEMCJBDEMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x22D0660", Offset = "0x22CEE60", VA = "0x1822D0660")]
			internal void NBHKFBOCLAN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class HJAAMDDAKOJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public HJAAMDDAKOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x22FC650", Offset = "0x22FAE50", VA = "0x1822FC650")]
			internal bool OFNNFEBDJBL(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private readonly ICMGIGHAKCJ GOCLAAFHIBH;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x22E2F00", Offset = "0x22E1700", VA = "0x1822E2F00")]
		public GOHNICDDDJG(AOMCPFNEFFD LMIJAEAMIME, HIIMDDIMLFH JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x22E1130", Offset = "0x22DF930", VA = "0x1822E1130", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class EMDGFLNBCCB : HLGBCEDEFMN<NHCBCCKPOHL>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class HHHGHJJLIFN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006E")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public HHHGHJJLIFN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x2304A30", Offset = "0x2303230", VA = "0x182304A30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public EMDGFLNBCCB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public HHHGHJJLIFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x22FC530", Offset = "0x22FAD30", VA = "0x1822FC530")]
			internal string FBICKDEKDMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x22FC580", Offset = "0x22FAD80", VA = "0x1822FC580")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void JKEAAELNANL(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x22FC4E0", Offset = "0x22FACE0", VA = "0x1822FC4E0")]
			internal int BCMIIJCJHFG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x22FC450", Offset = "0x22FAC50", VA = "0x1822FC450")]
			internal void ADJPFJJKDFB(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xC76AB0", Offset = "0xC752B0", VA = "0x180C76AB0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x22F4180", Offset = "0x22F2980", VA = "0x1822F4180")]
		public EMDGFLNBCCB(AOMCPFNEFFD LMIJAEAMIME, NHCBCCKPOHL CLCEHBDJMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x22F3E30", Offset = "0x22F2630", VA = "0x1822F3E30", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class JMAPDNBGLFN : HLGBCEDEFMN<CNFFICCGCJL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class KKLJBDGBNPN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				public KKLJBDGBNPN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x2304D40", Offset = "0x2303540", VA = "0x182304D40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000072")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000189")]
				public KKLJBDGBNPN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400018A")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400018B")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400018C")]
				private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x2305080", Offset = "0x2303880", VA = "0x182305080", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public JMAPDNBGLFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public KKLJBDGBNPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x22FE540", Offset = "0x22FCD40", VA = "0x1822FE540")]
			internal string FBICKDEKDMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x22FE720", Offset = "0x22FCF20", VA = "0x1822FE720")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void JKEAAELNANL(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x22FE340", Offset = "0x22FCB40", VA = "0x1822FE340")]
			internal int BCMIIJCJHFG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x22FE210", Offset = "0x22FCA10", VA = "0x1822FE210")]
			internal void ADJPFJJKDFB(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x22FE850", Offset = "0x22FD050", VA = "0x1822FE850")]
			internal string NNIOHDHPNHD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x22FE470", Offset = "0x22FCC70", VA = "0x1822FE470")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void CCDHILCAKBE(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x22FE420", Offset = "0x22FCC20", VA = "0x1822FE420")]
			internal bool BMMNDIJLGFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x22FE390", Offset = "0x22FCB90", VA = "0x1822FE390")]
			internal void BFLKOFCGAAC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x22FE2A0", Offset = "0x22FCAA0", VA = "0x1822FE2A0")]
			internal bool AIHFDOAJKIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x22FE690", Offset = "0x22FCE90", VA = "0x1822FE690")]
			internal void GKAHJJPHGPE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x22FE2F0", Offset = "0x22FCAF0", VA = "0x1822FE2F0")]
			internal float BBIPEDMKAKM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x22FE600", Offset = "0x22FCE00", VA = "0x1822FE600")]
			internal void FIDHDNALDIJ(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x22FE7F0", Offset = "0x22FCFF0", VA = "0x1822FE7F0")]
			internal int MHDGOMDCJML()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x22FE8A0", Offset = "0x22FD0A0", VA = "0x1822FE8A0")]
			internal void PKADMEIDIEM(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x22FE590", Offset = "0x22FCD90", VA = "0x1822FE590")]
			internal bool FBMPBAKPIFO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xC76AB0", Offset = "0xC752B0", VA = "0x180C76AB0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x22FE0E0", Offset = "0x22FC8E0", VA = "0x1822FE0E0")]
		public JMAPDNBGLFN(AOMCPFNEFFD LMIJAEAMIME, CNFFICCGCJL JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x22FD6A0", Offset = "0x22FBEA0", VA = "0x1822FD6A0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class MAEPLGPKLMP : HLGBCEDEFMN<CONKGKOEPNG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class FEOBPGCMEJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public MAEPLGPKLMP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public FEOBPGCMEJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x22F49F0", Offset = "0x22F31F0", VA = "0x1822F49F0")]
			internal Dictionary<string, GMEKKAAMOLN> FBICKDEKDMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x22F4A90", Offset = "0x22F3290", VA = "0x1822F4A90")]
			internal int JKEAAELNANL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x22F48D0", Offset = "0x22F30D0", VA = "0x1822F48D0")]
			internal void BCMIIJCJHFG(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x22F4850", Offset = "0x22F3050", VA = "0x1822F4850")]
			internal bool ADJPFJJKDFB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xC76AB0", Offset = "0xC752B0", VA = "0x180C76AB0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x23008B0", Offset = "0x22FF0B0", VA = "0x1823008B0")]
		public MAEPLGPKLMP(AOMCPFNEFFD LMIJAEAMIME, CONKGKOEPNG CLCEHBDJMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x23005E0", Offset = "0x22FEDE0", VA = "0x1823005E0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public sealed class EOCKMIGMMGF : HLGBCEDEFMN<DKAEOBHIAEN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class GMMKKONABMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public EOCKMIGMMGF <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public GMMKKONABMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x22FBF80", Offset = "0x22FA780", VA = "0x1822FBF80")]
			internal void FBICKDEKDMK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xC76AB0", Offset = "0xC752B0", VA = "0x180C76AB0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x22F4370", Offset = "0x22F2B70", VA = "0x1822F4370")]
		public EOCKMIGMMGF(AOMCPFNEFFD LMIJAEAMIME, DKAEOBHIAEN CLCEHBDJMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x22F41F0", Offset = "0x22F29F0", VA = "0x1822F41F0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class KKFLHIGLAIP<TNode> : DHGMGFCHOGH<TNode> where TNode : notnull, GILLICHEFJO
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool JIPCLBOBPKA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override DJOKIJOCJDJ? FPBFMLCIOOG
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x4649A10", Offset = "0x4648210", VA = "0x184649A10", Slot = "112")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool PAFNLJNLEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x4649AC0", Offset = "0x46482C0", VA = "0x184649AC0", Slot = "119")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x99D1E0", Offset = "0x99B9E0", VA = "0x18099D1E0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x4649A80", Offset = "0x4648280", VA = "0x184649A80")]
		public KKFLHIGLAIP(AOMCPFNEFFD LMIJAEAMIME, TNode JLFLGGOOAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class OFBCNGNBFLP : KKFLHIGLAIP<DDHBFCGPJOM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class LJCPKEGEPEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public OFBCNGNBFLP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public LJCPKEGEPEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x23003E0", Offset = "0x22FEBE0", VA = "0x1823003E0")]
			internal object FBICKDEKDMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x2300450", Offset = "0x22FEC50", VA = "0x182300450")]
			internal void JKEAAELNANL(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x2300300", Offset = "0x22FEB00", VA = "0x182300300")]
			internal void BCMIIJCJHFG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static object[]? JKKNPDPGHIE;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x23041D0", Offset = "0x23029D0", VA = "0x1823041D0")]
		public OFBCNGNBFLP(AOMCPFNEFFD LMIJAEAMIME, DDHBFCGPJOM JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2303C20", Offset = "0x2302420", VA = "0x182303C20", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class LILPHNFLEIO : HLGBCEDEFMN<ANIJPGEOPKH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xC12B60", Offset = "0xC11360", VA = "0x180C12B60", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x2300290", Offset = "0x22FEA90", VA = "0x182300290")]
		public LILPHNFLEIO(AOMCPFNEFFD LMIJAEAMIME, ANIJPGEOPKH JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class ADGKMDFEMJA : HLGBCEDEFMN<BPKLOGIJIKN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x9A74F0", Offset = "0x9A5CF0", VA = "0x1809A74F0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x22E98B0", Offset = "0x22E80B0", VA = "0x1822E98B0")]
		public ADGKMDFEMJA(AOMCPFNEFFD LMIJAEAMIME, BPKLOGIJIKN JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "114")]
		protected override bool OLMHGCDDKKG(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private sealed class PGDKHGGHNDK : HLGBCEDEFMN<MBAAAOEADGK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x91D180", Offset = "0x91B980", VA = "0x18091D180", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool DJHBOMNOHPE
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x23042A0", Offset = "0x2302AA0", VA = "0x1823042A0", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override bool NPBBHDKPIPA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2304230", Offset = "0x2302A30", VA = "0x182304230")]
		public PGDKHGGHNDK(AOMCPFNEFFD LMIJAEAMIME, MBAAAOEADGK JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class OCKECEFHBKL : HLGBCEDEFMN<CGEHAFHOHIM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x926710", Offset = "0x924F10", VA = "0x180926710", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool DJHBOMNOHPE
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x2303BD0", Offset = "0x23023D0", VA = "0x182303BD0", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		protected override bool NPBBHDKPIPA
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2303B60", Offset = "0x2302360", VA = "0x182303B60")]
		public OCKECEFHBKL(AOMCPFNEFFD LMIJAEAMIME, CGEHAFHOHIM JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class EOPNLDJLKBC : JGGDACCKCHI<HKOJJINLHMP>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private sealed class AMGKEGEDIFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public EOPNLDJLKBC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public AMGKEGEDIFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x22EA0A0", Offset = "0x22E88A0", VA = "0x1822EA0A0")]
			internal float HAOODPDHEHL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x22EA120", Offset = "0x22E8920", VA = "0x1822EA120")]
			internal void PBBLDMPBDPA(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x22F4660", Offset = "0x22F2E60", VA = "0x1822F4660")]
		public EOPNLDJLKBC(AOMCPFNEFFD LMIJAEAMIME, HKOJJINLHMP CLCEHBDJMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x22F43E0", Offset = "0x22F2BE0", VA = "0x1822F43E0", Slot = "128")]
		protected override void JFKPGMJHLNL(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public sealed class BIMLEHJJNFM : HLGBCEDEFMN<FKBBMIFGMFJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		[CompilerGenerated]
		private sealed class IAPHJCDDGOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public BIMLEHJJNFM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public IAPHJCDDGOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x22FCAF0", Offset = "0x22FB2F0", VA = "0x1822FCAF0")]
			internal bool FBICKDEKDMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x22FCB40", Offset = "0x22FB340", VA = "0x1822FCB40")]
			internal void JKEAAELNANL(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x22EA4D0", Offset = "0x22E8CD0", VA = "0x1822EA4D0")]
		public BIMLEHJJNFM(AOMCPFNEFFD LMIJAEAMIME, FKBBMIFGMFJ CLCEHBDJMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x22EA230", Offset = "0x22E8A30", VA = "0x1822EA230", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class NNCEMHGEJNN : HLGBCEDEFMN<IPOMFDKKBKD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class EIFIMNGLHKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public NNCEMHGEJNN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public EIFIMNGLHKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x22F3A40", Offset = "0x22F2240", VA = "0x1822F3A40")]
			internal object FBICKDEKDMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x22F3850", Offset = "0x22F2050", VA = "0x1822F3850")]
			internal bool BFLKOFCGAAC(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x22F3B70", Offset = "0x22F2370", VA = "0x1822F3B70")]
			internal void JKEAAELNANL(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x22F36F0", Offset = "0x22F1EF0", VA = "0x1822F36F0")]
			internal string BCMIIJCJHFG(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x22F36A0", Offset = "0x22F1EA0", VA = "0x1822F36A0")]
			internal IReadOnlyList<object> ADJPFJJKDFB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x22F3DC0", Offset = "0x22F25C0", VA = "0x1822F3DC0")]
			internal bool NNIOHDHPNHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x22F39F0", Offset = "0x22F21F0", VA = "0x1822F39F0")]
			internal bool CCDHILCAKBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x22F38D0", Offset = "0x22F20D0", VA = "0x1822F38D0")]
			internal void BMMNDIJLGFO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2303A80", Offset = "0x2302280", VA = "0x182303A80")]
		public NNCEMHGEJNN(AOMCPFNEFFD LMIJAEAMIME, IPOMFDKKBKD CLCEHBDJMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2303280", Offset = "0x2301A80", VA = "0x182303280", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class BKOFJGEPJGJ : MBDFNDLNIFF<IFIMLMJEAIE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x9A8DC0", Offset = "0x9A75C0", VA = "0x1809A8DC0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x22EA540", Offset = "0x22E8D40", VA = "0x1822EA540")]
		public BKOFJGEPJGJ(AOMCPFNEFFD LMIJAEAMIME, IFIMLMJEAIE JLFLGGOOAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class HLMKLHIPKMI : JGGDACCKCHI<IKJHFOKKJCK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class MBMMPHCIDML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public HLMKLHIPKMI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public MBMMPHCIDML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x2300920", Offset = "0x22FF120", VA = "0x182300920")]
			internal int HAOODPDHEHL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x23009A0", Offset = "0x22FF1A0", VA = "0x1823009A0")]
			internal void PBBLDMPBDPA(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x22FC9D0", Offset = "0x22FB1D0", VA = "0x1822FC9D0")]
		public HLMKLHIPKMI(AOMCPFNEFFD LMIJAEAMIME, IKJHFOKKJCK CLCEHBDJMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x22FC740", Offset = "0x22FAF40", VA = "0x1822FC740", Slot = "128")]
		protected override void JFKPGMJHLNL(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class GIFJPIGHKJG : HLGBCEDEFMN<IEIFJGAMGKN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		[CompilerGenerated]
		private sealed class PJPBBDLGHDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public GIFJPIGHKJG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public PJPBBDLGHDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x23043F0", Offset = "0x2302BF0", VA = "0x1823043F0")]
			internal bool FBICKDEKDMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x2304440", Offset = "0x2302C40", VA = "0x182304440")]
			internal void JKEAAELNANL(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x22FBC10", Offset = "0x22FA410", VA = "0x1822FBC10")]
		public GIFJPIGHKJG(AOMCPFNEFFD LMIJAEAMIME, IEIFJGAMGKN CLCEHBDJMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x22FBA30", Offset = "0x22FA230", VA = "0x1822FBA30", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class PNGGHHFLIGD : HLGBCEDEFMN<CPINBENCPBO>
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class CPEPHJFCMHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public PNGGHHFLIGD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public CPEPHJFCMHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x22EBA00", Offset = "0x22EA200", VA = "0x1822EBA00")]
			internal bool FBICKDEKDMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x22EBA50", Offset = "0x22EA250", VA = "0x1822EBA50")]
			internal void JKEAAELNANL(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x23046B0", Offset = "0x2302EB0", VA = "0x1823046B0")]
		public PNGGHHFLIGD(AOMCPFNEFFD LMIJAEAMIME, CPINBENCPBO CLCEHBDJMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x23044D0", Offset = "0x2302CD0", VA = "0x1823044D0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class NEBCCADAKHA : HLGBCEDEFMN<BFJKBPMLDMD>
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private sealed class PIIDNKNPGDE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public NEBCCADAKHA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public PIIDNKNPGDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x2304310", Offset = "0x2302B10", VA = "0x182304310")]
			internal int FBICKDEKDMK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x2304360", Offset = "0x2302B60", VA = "0x182304360")]
			internal void JKEAAELNANL(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x2302D30", Offset = "0x2301530", VA = "0x182302D30")]
		public NEBCCADAKHA(AOMCPFNEFFD LMIJAEAMIME, BFJKBPMLDMD CLCEHBDJMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x2302AC0", Offset = "0x23012C0", VA = "0x182302AC0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public sealed class HMNAJPPJEKP : JKIHCIKKFMD<IOOILBIBDOO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override LKLBDLNAKHE AGINLCJIICC
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x92F1C0", Offset = "0x92D9C0", VA = "0x18092F1C0", Slot = "128")]
			get
			{
				return default(LKLBDLNAKHE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x22FCA30", Offset = "0x22FB230", VA = "0x1822FCA30")]
		public HMNAJPPJEKP(AOMCPFNEFFD LMIJAEAMIME, IOOILBIBDOO CLCEHBDJMEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class OBJHBNKOMBA : HLGBCEDEFMN<GLIPNLBBOGL>
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2303AF0", Offset = "0x23022F0", VA = "0x182303AF0")]
		public OBJHBNKOMBA(AOMCPFNEFFD LMIJAEAMIME, GLIPNLBBOGL JLFLGGOOAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public abstract class HLGBCEDEFMN<TNode> : BKMGNOHAAAA, IDisposable where TNode : notnull, GLIPNLBBOGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class POGMPAFFCKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public HLGBCEDEFMN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public AOMCPFNEFFD circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public POGMPAFFCKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x4C7F090", Offset = "0x4C7D890", VA = "0x184C7F090")]
			internal FMNHFAJKAJA DDINEAFKMHM(BAOKDDLDICK portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private struct IFGGMBBMPLN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public HLGBCEDEFMN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x430D030", Offset = "0x430B830", VA = "0x18430D030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private struct LGNJHJPDNLC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public HLGBCEDEFMN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public DFACKOPMILK? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public ADGOFHPALPO? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x4732D90", Offset = "0x4731590", VA = "0x184732D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x4733030", Offset = "0x4731830", VA = "0x184733030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private sealed class FAPFBKGPLOB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public FAPFBKGPLOB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60003A7")]
				[Cpp2IlInjected.Address(RVA = "0x39C5460", Offset = "0x39C3C60", VA = "0x1839C5460", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003A8")]
				[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public HLGBCEDEFMN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public AJNINOLHGBJ configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public FAPFBKGPLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
			internal string HBJEDLEELMN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000")]
			internal void BMOKIDLBFCD(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x4050D20", Offset = "0x404F520", VA = "0x184050D20")]
			[AsyncStateMachine(typeof(HLGBCEDEFMN<>.FAPFBKGPLOB.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void IOMEMMAAJDC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class DBMFKMOHBGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public DBMFKMOHBGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x5D906A0", Offset = "0x5D8EEA0", VA = "0x185D906A0")]
			internal bool COJBECAPPJK(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x5D90780", Offset = "0x5D8EF80", VA = "0x185D90780")]
			internal bool EDBHMJBBCOJ(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private struct COGNHLPMIFB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public HLGBCEDEFMN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x5A208A0", Offset = "0x5A1F0A0", VA = "0x185A208A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x5A20C20", Offset = "0x5A1F420", VA = "0x185A20C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly AOMCPFNEFFD AHDBCMDLDJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly bool DNEENAGNHJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private LFKIHBALAOF<NONADBDKHEF, FMNHFAJKAJA> COMMPAFIMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private LFKIHBALAOF<NONADBDKHEF, LFJDBLMIGGO> MPPLGBFAOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private List<Action> DCNJBDCLFBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[CompilerGenerated]
		private Action<MFKBDIPIOIA<NONADBDKHEF>>? EBJBIJNJNND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[CompilerGenerated]
		private Action<MFKBDIPIOIA<NONADBDKHEF>, LFJDBLMIGGO>? KLDLNBPECFH;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected LPEPBMDCHIC NFEAJLIPOIK
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x4239DF0", Offset = "0x42385F0", VA = "0x184239DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected BEMJKPMGLHF CLHHPJJIKEL
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x4239690", Offset = "0x4237E90", VA = "0x184239690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		protected TNode LNABFKHCDBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public JOEFEFGKPAB<MGGNKFDEDIG> EJDPPCBLCHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0xEF15A0", Offset = "0xEEFDA0", VA = "0x180EF15A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(JOEFEFGKPAB<MGGNKFDEDIG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public MFKBDIPIOIA<CIOMHJNJFLM> HJENIOKPPKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x423B6B0", Offset = "0x4239EB0", VA = "0x18423B6B0", Slot = "6")]
			get
			{
				return default(MFKBDIPIOIA<CIOMHJNJFLM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public object OKJEJOLANIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x3D3D750", Offset = "0x3D3BF50", VA = "0x183D3D750", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual bool NKDONHACJLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public int JLCDCPNFHLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x423B310", Offset = "0x4239B10", VA = "0x18423B310", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public KCHMMKLCIDB HOOOHPPBDKL
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x423B2B0", Offset = "0x4239AB0", VA = "0x18423B2B0", Slot = "10")]
			get
			{
				return default(KCHMMKLCIDB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string DBFHNNGNEKO
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x423B8B0", Offset = "0x423A0B0", VA = "0x18423B8B0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected virtual bool NPBBHDKPIPA
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public MFKBDIPIOIA<BGIDPEHPKFI> LEANFPPDDAL
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xA87F30", Offset = "0xA86730", VA = "0x180A87F30", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(MFKBDIPIOIA<BGIDPEHPKFI>);
			}
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0xA89B70", Offset = "0xA88370", VA = "0x180A89B70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool DJHBOMNOHPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual bool JIPCLBOBPKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual MEMLMGMKEHD JECDAJJPHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0xB38B30", Offset = "0xB37330", VA = "0x180B38B30", Slot = "96")]
			get
			{
				return default(MEMLMGMKEHD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool DFBMGOBOIAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x423B020", Offset = "0x4239820", VA = "0x18423B020", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool ECKDJJABKCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x423B080", Offset = "0x4239880", VA = "0x18423B080", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool EMNKJHKBIEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x423B0E0", Offset = "0x42398E0", VA = "0x18423B0E0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int ICBLKBBOFPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x423B660", Offset = "0x4239E60", VA = "0x18423B660", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool LMGMJBJPDIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x423B490", Offset = "0x4239C90", VA = "0x18423B490", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool GMGAKKFOBNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x423B1F0", Offset = "0x42399F0", VA = "0x18423B1F0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool AAKMGOJEFBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x423B190", Offset = "0x4239990", VA = "0x18423B190", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool GCBOPEPAOJC
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0xB009F0", Offset = "0xAFF1F0", VA = "0x180B009F0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0xEAE630", Offset = "0xEACE30", VA = "0x180EAE630")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool JJAJGCMFKOP
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "97")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual bool LOOGEEILOFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x423B140", Offset = "0x4239940", VA = "0x18423B140", Slot = "98")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool EHMCIJDBKLL
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x423B3C0", Offset = "0x4239BC0", VA = "0x18423B3C0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public DFACKOPMILK MAGAFCIBJGN
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x423B5A0", Offset = "0x4239DA0", VA = "0x18423B5A0", Slot = "28")]
			get
			{
				return default(DFACKOPMILK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public ADGOFHPALPO HPCBIJNFAAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x423B600", Offset = "0x4239E00", VA = "0x18423B600", Slot = "30")]
			get
			{
				return default(ADGOFHPALPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool DCHIOLMECNA
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual CFFBOCDBILN? PEDKCHLAMHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual DJOKIJOCJDJ? FPBFMLCIOOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "112")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public virtual IEnumerable<JOEFEFGKPAB<BAFEGHIGBOE>>? CFIMIOAADPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool HGJAJKAKDPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x423B250", Offset = "0x4239A50", VA = "0x18423B250", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public JOEFEFGKPAB<JFDGELHFKII> HIEMDNOBAOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x423B4E0", Offset = "0x4239CE0", VA = "0x18423B4E0", Slot = "62")]
			get
			{
				return default(JOEFEFGKPAB<JFDGELHFKII>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public MFKBDIPIOIA<JFDGELHFKII> PHABMAJJJLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x423B360", Offset = "0x4239B60", VA = "0x18423B360", Slot = "56")]
			get
			{
				return default(MFKBDIPIOIA<JFDGELHFKII>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual bool KOBJMJEGBLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual MFKBDIPIOIA<JFDGELHFKII>? HMBGHOHADAK
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public virtual bool PAFNLJNLEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "119")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool GCMANDMAJAE
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x423B420", Offset = "0x4239C20", VA = "0x18423B420", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x8BC110", Offset = "0x8BA910", VA = "0x1808BC110", Slot = "65")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x8BC160", Offset = "0x8BA960", VA = "0x1808BC160")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string EAJCJKLBNNG
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x8BC100", Offset = "0x8BA900", VA = "0x1808BC100", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x8BC0C0", Offset = "0x8BA8C0", VA = "0x1808BC0C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public MFKBDIPIOIA<BAFEGHIGBOE> LGBCBIAHNHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x423B730", Offset = "0x4239F30", VA = "0x18423B730", Slot = "63")]
			get
			{
				return default(MFKBDIPIOIA<BAFEGHIGBOE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public JOEFEFGKPAB<BAFEGHIGBOE> BEFFBGIIHMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x423B540", Offset = "0x4239D40", VA = "0x18423B540", Slot = "64")]
			get
			{
				return default(JOEFEFGKPAB<BAFEGHIGBOE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public JOEFEFGKPAB<BAFEGHIGBOE>? BBGIKPNDNNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x423B790", Offset = "0x4239F90", VA = "0x18423B790", Slot = "120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public PPJAPCKACCF<NONADBDKHEF, LFJDBLMIGGO> PFJNGJLKHKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x423B870", Offset = "0x423A070", VA = "0x18423B870", Slot = "67")]
			get
			{
				return default(PPJAPCKACCF<NONADBDKHEF, LFJDBLMIGGO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual MFKBDIPIOIA<NONADBDKHEF>? FIIEGOPMGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public virtual bool GMCFANOMKPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "124")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public virtual bool BKAHFCCDPNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "125")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PPLKCHMPGJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x4239D10", Offset = "0x4238510", VA = "0x184239D10", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x42384E0", Offset = "0x4236CE0", VA = "0x1842384E0", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event FDIGDJLEOJD JKEMNDNMGBO
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x42375A0", Offset = "0x4235DA0", VA = "0x1842375A0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x42381C0", Offset = "0x42369C0", VA = "0x1842381C0", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event JGIINGBNLBK NAKKLKKIIBH
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x4239950", Offset = "0x4238150", VA = "0x184239950", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x423A340", Offset = "0x4238B40", VA = "0x18423A340", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action HEDBMPOJLHL
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x423A0D0", Offset = "0x42388D0", VA = "0x18423A0D0", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x4238F20", Offset = "0x4237720", VA = "0x184238F20", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action OMGDDLFJGJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x42377D0", Offset = "0x4235FD0", VA = "0x1842377D0", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x423A8F0", Offset = "0x42390F0", VA = "0x18423A8F0", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<MFKBDIPIOIA<NONADBDKHEF>, LFJDBLMIGGO> AFJKDALIHON
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x4239F10", Offset = "0x4238710", VA = "0x184239F10", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x4239190", Offset = "0x4237990", VA = "0x184239190", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<MFKBDIPIOIA<NONADBDKHEF>, LFJDBLMIGGO> CDEFGAGOPGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x4239590", Offset = "0x4237D90", VA = "0x184239590", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x42390D0", Offset = "0x42378D0", VA = "0x1842390D0", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<MFKBDIPIOIA<NONADBDKHEF>> JPFFNNHLOOC
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x42392C0", Offset = "0x4237AC0", VA = "0x1842392C0", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x4237640", Offset = "0x4235E40", VA = "0x184237640", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<MFKBDIPIOIA<NONADBDKHEF>, MFKBDIPIOIA<NONADBDKHEF>> JEHMLMPACFG
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x423A3E0", Offset = "0x4238BE0", VA = "0x18423A3E0", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x4239E50", Offset = "0x4238650", VA = "0x184239E50", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<MFKBDIPIOIA<NONADBDKHEF>, LFJDBLMIGGO> DJJDIAIJGEL
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x423A010", Offset = "0x4238810", VA = "0x18423A010", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x423A990", Offset = "0x4239190", VA = "0x18423A990", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<MFKBDIPIOIA<NONADBDKHEF>, MFKBDIPIOIA<NONADBDKHEF>> MHMHENOHIHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x42394D0", Offset = "0x4237CD0", VA = "0x1842394D0", Slot = "79")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x423A1A0", Offset = "0x42389A0", VA = "0x18423A1A0", Slot = "80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x423AA50", Offset = "0x4239250", VA = "0x18423AA50")]
		[DGOKMPKFCKH("Need to handle `Name` better.")]
		[DGOKMPKFCKH("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected HLGBCEDEFMN(AOMCPFNEFFD LMIJAEAMIME, TNode JLFLGGOOAGI, bool NGGKGOLOAOO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x42385F0", Offset = "0x4236DF0", VA = "0x1842385F0", Slot = "89")]
		protected virtual void EHFCOOMFLME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x4237940", Offset = "0x4236140", VA = "0x184237940", Slot = "90")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x4238F80", Offset = "0x4237780", VA = "0x184238F80", Slot = "9")]
		[AsyncStateMachine(typeof(HLGBCEDEFMN<>.IFGGMBBMPLN))]
		public void FOBINEIGDFP(int FIBNJEGBKFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x4238580", Offset = "0x4236D80", VA = "0x184238580")]
		public bool EGHPADAMLCO([In] DFACKOPMILK INDENPJBLHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x423A2D0", Offset = "0x4238AD0", VA = "0x18423A2D0")]
		public bool NPCCLNBCLIP([In] ADGOFHPALPO INDENPJBLHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x4236B90", Offset = "0x4235390", VA = "0x184236B90", Slot = "32")]
		public void CBOMOKFODDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x4237300", Offset = "0x4235B00", VA = "0x184237300", Slot = "33")]
		[AsyncStateMachine(typeof(HLGBCEDEFMN<>.LGNJHJPDNLC))]
		public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> CDNFKEGOBPD(DFACKOPMILK? BIIIOAKOBBK, ADGOFHPALPO? HAODNGMNEJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "99")]
		public virtual void IMBEOIIOBKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "100")]
		public virtual void LFDLHIOIMMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "101")]
		public virtual void ECCFHHPPJMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xAE9260", Offset = "0xAE7A60", VA = "0x180AE9260")]
		protected void FKHDGOEMKIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xB30900", Offset = "0xB2F100", VA = "0x180B30900")]
		protected void KLHGOOECEII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x252C010", Offset = "0x252A810", VA = "0x18252C010")]
		private void OAHBCPOFBNA([In] ADGOFHPALPO OJEGGOKKPLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x4237700", Offset = "0x4235F00", VA = "0x184237700", Slot = "102")]
		public virtual Task<DNFCNMKAMCE<MFKBDIPIOIA<NONADBDKHEF>, OOJAGAFOLJL>> DFMDKDEHKMF(string IKMKCMDHFDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x4237870", Offset = "0x4236070", VA = "0x184237870", Slot = "103")]
		public virtual Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> DPCBHAPEKMM(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "104")]
		public virtual void PMEIPEHPMLB(MFKBDIPIOIA<NONADBDKHEF> MBJMFFOKPPF, MFKBDIPIOIA<NONADBDKHEF> DKPKBBICFFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x42361D0", Offset = "0x42349D0", VA = "0x1842361D0", Slot = "105")]
		public virtual IEnumerable<MKGNMHKEPFM> APCMJBLNPKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x42398C0", Offset = "0x42380C0", VA = "0x1842398C0", Slot = "106")]
		public DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL> JNEDJOHCGLF(string GPCMCGJDEKF)
		{
			return default(DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x4239770", Offset = "0x4237F70", VA = "0x184239770", Slot = "47")]
		public bool JCPFIDMJPPM([Out] Guid OKAKABGBPOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x4239A60", Offset = "0x4238260", VA = "0x184239A60")]
		public bool KCKMNKNKBCD([In] Guid JJFBINJJNLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "107")]
		public virtual void FGGFCKBCIEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "108")]
		public virtual void KPJGMBMAMGG(bool FMJOCHBKGJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "109")]
		public virtual JMODNFLMCGC KDJKIDBFEEO([In] GBEJMJOAHOJ DNGCECLPIFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x4237120", Offset = "0x4235920", VA = "0x184237120")]
		protected void CCKCKMOMJOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x423A8B0", Offset = "0x42390B0", VA = "0x18423A8B0", Slot = "114")]
		protected virtual bool OLMHGCDDKKG(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "115")]
		protected virtual bool JPKCPMCPLKO(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "122")]
		protected virtual void PIJPPECABKH(AJNINOLHGBJ FOBBPGOJCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x4236D30", Offset = "0x4235530", VA = "0x184236D30")]
		protected void CCEGACIFMMD(AJNINOLHGBJ DEFPDELPAGI, Func<string> FLMBJOALBJM, Action<string> HBFFDMMJNJD, string ENGLAEIDGMD, string CCADCBBBPBM, string FMLIMEFNABO, FCCDKLOMAMD PBCPNOBGJKK, HFEFIFOLFLO NLAKLGCBEIG, Func<string, bool> MEGIAJCBLAC, string MLHGLOFBLDB, Func<string, bool> CLBHCHDIGIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x4238260", Offset = "0x4236A60", VA = "0x184238260")]
		protected void ECDJIOPDABB(AJNINOLHGBJ DEFPDELPAGI, Func<string> FLMBJOALBJM, Action<string> HBFFDMMJNJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x4236020", Offset = "0x4234820", VA = "0x184236020", Slot = "123")]
		protected virtual void AKAMPFOPHGD(AJNINOLHGBJ DEFPDELPAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x4236260", Offset = "0x4234A60", VA = "0x184236260", Slot = "82")]
		public void BBNNEENGLBI(AJNINOLHGBJ DEFPDELPAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x4238E30", Offset = "0x4237630", VA = "0x184238E30", Slot = "83")]
		public EBOIACDJEEB EMFIOAHHLPK()
		{
			return default(EBOIACDJEEB);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "126")]
		public virtual bool KJKBFGHOBBJ(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x192FF20", Offset = "0x192E720", VA = "0x18192FF20")]
		private void CBDGNPHEDCC([In] DFACKOPMILK BALIIBCILHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x4237450", Offset = "0x4235C50", VA = "0x184237450")]
		private void CHFCMNHNNFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x42362B0", Offset = "0x4234AB0", VA = "0x1842362B0")]
		private void BLMENEHIBGL(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, BAOKDDLDICK JPGJANANMOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xC6BA40", Offset = "0xC6A240", VA = "0x180C6BA40")]
		private void GOAGEKFDPAD(MFKBDIPIOIA<NONADBDKHEF> DOBPKLNCBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x4239380", Offset = "0x4237B80", VA = "0x184239380")]
		private void HAMGKGOBOHL(MFKBDIPIOIA<NONADBDKHEF> DOBPKLNCBDO, BAOKDDLDICK BAOGEEHFEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x42367F0", Offset = "0x4234FF0", VA = "0x1842367F0")]
		private void BMPPJIMPLOA(MFKBDIPIOIA<NONADBDKHEF> MBJMFFOKPPF, MFKBDIPIOIA<NONADBDKHEF> DKPKBBICFFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xC6A240", Offset = "0xC68A40", VA = "0x180C6A240")]
		private void JCMCBAPKKKN(MFKBDIPIOIA<NONADBDKHEF> MBJMFFOKPPF, MFKBDIPIOIA<NONADBDKHEF> DKPKBBICFFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x42394B0", Offset = "0x4237CB0", VA = "0x1842394B0")]
		private void HIBOGOMNMOM(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x423A4A0", Offset = "0x4238CA0", VA = "0x18423A4A0")]
		private void OIEKNCKCFPP(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, BAOKDDLDICK JPGJANANMOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x42399F0", Offset = "0x42381F0", VA = "0x1842399F0")]
		private void KCKKLJONPLP(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, BAOKDDLDICK BAOGEEHFEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x4238D10", Offset = "0x4237510", VA = "0x184238D10", Slot = "127")]
		[AsyncStateMachine(typeof(HLGBCEDEFMN<>.COGNHLPMIFB))]
		public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> ELPBBEGDKHL(string GPCMCGJDEKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x423A260", Offset = "0x4238A60", VA = "0x18423A260", Slot = "54")]
		private void NFANANFMHOF(object PFEBOBGKMDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x4239250", Offset = "0x4237A50", VA = "0x184239250", Slot = "55")]
		private void GICAIAAPNCG(object PFEBOBGKMDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x4239FD0", Offset = "0x42387D0", VA = "0x184239FD0", Slot = "29")]
		private bool MAKCKHMCFKA([In] DFACKOPMILK INDENPJBLHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x4239650", Offset = "0x4237E50", VA = "0x184239650", Slot = "31")]
		private bool IHBEBMDFPCA([In] ADGOFHPALPO INDENPJBLHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x4239DB0", Offset = "0x42385B0", VA = "0x184239DB0", Slot = "48")]
		private bool LHJPJBLPIPO([In] Guid JJFBINJJNLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x4235FE0", Offset = "0x42347E0", VA = "0x184235FE0")]
		[CompilerGenerated]
		private string AAACFKOPFFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x4239030", Offset = "0x4237830", VA = "0x184239030")]
		[CompilerGenerated]
		private void FPEOLMDMMFA(string IKMKCMDHFDC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class HPIKKBKILGF : MBDFNDLNIFF<EBOABPLHMNE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x9A18E0", Offset = "0x9A00E0", VA = "0x1809A18E0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x22FCA90", Offset = "0x22FB290", VA = "0x1822FCA90")]
		public HPIKKBKILGF(AOMCPFNEFFD LMIJAEAMIME, EBOABPLHMNE JLFLGGOOAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private sealed class MKJGDNJIHPP : DHGMGFCHOGH<FNHGOCFLGPD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x92F1C0", Offset = "0x92D9C0", VA = "0x18092F1C0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x23022A0", Offset = "0x2300AA0", VA = "0x1823022A0")]
		public MKJGDNJIHPP(AOMCPFNEFFD LMIJAEAMIME, FNHGOCFLGPD JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public abstract class JKIHCIKKFMD<T> : HLGBCEDEFMN<T> where T : notnull, IHCIAJGNMIG
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class ABEIAMGDKBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public IReadOnlyList<KeyValuePair<string, GMEKKAAMOLN>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public JKIHCIKKFMD<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public LKLBDLNAKHE clipType;

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public ABEIAMGDKBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
			internal IReadOnlyList<KeyValuePair<string, GMEKKAAMOLN>> FBICKDEKDMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x40F8260", Offset = "0x40F6A60", VA = "0x1840F8260")]
			internal int JKEAAELNANL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x40F7DF0", Offset = "0x40F65F0", VA = "0x1840F7DF0")]
			internal void BCMIIJCJHFG(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x40F7D00", Offset = "0x40F6500", VA = "0x1840F7D00")]
			internal void ADJPFJJKDFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x40F8400", Offset = "0x40F6C00", VA = "0x1840F8400")]
			internal void NNIOHDHPNHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x40F8000", Offset = "0x40F6800", VA = "0x1840F8000")]
			internal bool CCDHILCAKBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x40F8090", Offset = "0x40F6890", VA = "0x1840F8090")]
			internal void BMMNDIJLGFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x40F8000", Offset = "0x40F6800", VA = "0x1840F8000")]
			internal bool BFLKOFCGAAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x40F7D50", Offset = "0x40F6550", VA = "0x1840F7D50")]
			internal float AIHFDOAJKIK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x40F81A0", Offset = "0x40F69A0", VA = "0x1840F81A0")]
			internal void GKAHJJPHGPE(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x40F7DA0", Offset = "0x40F65A0", VA = "0x1840F7DA0")]
			internal float BBIPEDMKAKM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x40F80E0", Offset = "0x40F68E0", VA = "0x1840F80E0")]
			internal void FIDHDNALDIJ(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x40F83B0", Offset = "0x40F6BB0", VA = "0x1840F83B0")]
			internal float MHDGOMDCJML()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x40F8550", Offset = "0x40F6D50", VA = "0x1840F8550")]
			internal void PKADMEIDIEM(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0xC76AB0", Offset = "0xC752B0", VA = "0x180C76AB0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public abstract LKLBDLNAKHE AGINLCJIICC
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(Slot = "128")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x4558A10", Offset = "0x4557210", VA = "0x184558A10")]
		public JKIHCIKKFMD(AOMCPFNEFFD LMIJAEAMIME, T JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x4557F60", Offset = "0x4556760", VA = "0x184557F60", Slot = "122")]
		protected sealed override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private sealed class HJBHOIGMNAI : HLGBCEDEFMN<KEKAEMCHAOL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x9A2010", Offset = "0x9A0810", VA = "0x1809A2010", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x22FC6D0", Offset = "0x22FAED0", VA = "0x1822FC6D0")]
		public HJBHOIGMNAI(AOMCPFNEFFD LMIJAEAMIME, KEKAEMCHAOL JLFLGGOOAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class CNPIONLBPFA : HLGBCEDEFMN<LHMOJECNKBD>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class EFGLNDALKHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public CNPIONLBPFA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public EFGLNDALKHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x22EC380", Offset = "0x22EAB80", VA = "0x1822EC380")]
			internal int JKEAAELNANL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x22EC2F0", Offset = "0x22EAAF0", VA = "0x1822EC2F0")]
			internal void BCMIIJCJHFG(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private static Dictionary<string, GMEKKAAMOLN>? DAKJOIFAAPA;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x22EB990", Offset = "0x22EA190", VA = "0x1822EB990")]
		public CNPIONLBPFA(AOMCPFNEFFD LMIJAEAMIME, LHMOJECNKBD JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x22EB600", Offset = "0x22E9E00", VA = "0x1822EB600", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class LMONCMEOGDI : JKIHCIKKFMD<APOJIHJABOK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override LKLBDLNAKHE AGINLCJIICC
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "128")]
			get
			{
				return default(LKLBDLNAKHE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x2300520", Offset = "0x22FED20", VA = "0x182300520")]
		public LMONCMEOGDI(AOMCPFNEFFD LMIJAEAMIME, APOJIHJABOK CLCEHBDJMEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private sealed class LNMEGGGOOHH : DHGMGFCHOGH<GNFIFBDJBAO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x92F1C0", Offset = "0x92D9C0", VA = "0x18092F1C0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2300580", Offset = "0x22FED80", VA = "0x182300580")]
		public LNMEGGGOOHH(AOMCPFNEFFD LMIJAEAMIME, GNFIFBDJBAO JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private sealed class JPNPEJCFAFF : DHGMGFCHOGH<BKOEDCPBOKO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x92F1C0", Offset = "0x92D9C0", VA = "0x18092F1C0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x22FE150", Offset = "0x22FC950", VA = "0x1822FE150")]
		public JPNPEJCFAFF(AOMCPFNEFFD LMIJAEAMIME, BKOEDCPBOKO JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public sealed class MDCCOCCLOIA : JGGDACCKCHI<BNLKDMLLJAE>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class JEOKHGBBLOE
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000A4")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public JEOKHGBBLOE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003DC")]
				[Cpp2IlInjected.Address(RVA = "0x2304720", Offset = "0x2302F20", VA = "0x182304720", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DD")]
				[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public MDCCOCCLOIA <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public JEOKHGBBLOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x22FD230", Offset = "0x22FBA30", VA = "0x1822FD230")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void HAOODPDHEHL(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x2300D20", Offset = "0x22FF520", VA = "0x182300D20")]
		public MDCCOCCLOIA(AOMCPFNEFFD LMIJAEAMIME, BNLKDMLLJAE CLCEHBDJMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x2300A40", Offset = "0x22FF240", VA = "0x182300A40", Slot = "128")]
		protected override void JFKPGMJHLNL(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class FJFANDNOPFJ : JKIHCIKKFMD<FANPCKBNPFA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override LKLBDLNAKHE AGINLCJIICC
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x91D180", Offset = "0x91B980", VA = "0x18091D180", Slot = "128")]
			get
			{
				return default(LKLBDLNAKHE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x22F4FB0", Offset = "0x22F37B0", VA = "0x1822F4FB0")]
		public FJFANDNOPFJ(AOMCPFNEFFD LMIJAEAMIME, FANPCKBNPFA CLCEHBDJMEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private sealed class BAHANFIAJIM : HLGBCEDEFMN<GLCAKLEPFLK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x9A0F80", Offset = "0x99F780", VA = "0x1809A0F80", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x22EA1C0", Offset = "0x22E89C0", VA = "0x1822EA1C0")]
		public BAHANFIAJIM(AOMCPFNEFFD LMIJAEAMIME, GLCAKLEPFLK JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class KOFHPBKFOJI : HLGBCEDEFMN<HHNIMNHHJEF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public sealed override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public sealed override bool DJHBOMNOHPE
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected sealed override bool NPBBHDKPIPA
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x22FECB0", Offset = "0x22FD4B0", VA = "0x1822FECB0")]
		public KOFHPBKFOJI(AOMCPFNEFFD LMIJAEAMIME, HHNIMNHHJEF JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x22FE9E0", Offset = "0x22FD1E0", VA = "0x1822FE9E0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x22FE9A0", Offset = "0x22FD1A0", VA = "0x1822FE9A0")]
		private int NHPFHJIEADH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x22FE940", Offset = "0x22FD140", VA = "0x1822FE940")]
		private void FPEIECAHDAE(int HGBJJIKLGEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class PDPOMCFNMAG : OBJHBNKOMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x2303AF0", Offset = "0x23022F0", VA = "0x182303AF0")]
		public PDPOMCFNMAG(AOMCPFNEFFD LMIJAEAMIME, GLIPNLBBOGL JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class KHAJONJKPMN : JGGDACCKCHI<PGIGHJFJOMM>
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x22FE1B0", Offset = "0x22FC9B0", VA = "0x1822FE1B0")]
		public KHAJONJKPMN(AOMCPFNEFFD LMIJAEAMIME, PGIGHJFJOMM JLFLGGOOAGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public abstract class JGGDACCKCHI<TVariableNode> : HLGBCEDEFMN<TVariableNode> where TVariableNode : notnull, PGIGHJFJOMM
	{
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		[CompilerGenerated]
		private sealed class FEKKFDMLDCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public JGGDACCKCHI<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public FEKKFDMLDCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x4068740", Offset = "0x4066F40", VA = "0x184068740")]
			internal bool FBICKDEKDMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x40687A0", Offset = "0x4066FA0", VA = "0x1840687A0")]
			internal void JKEAAELNANL(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x40686E0", Offset = "0x4066EE0", VA = "0x1840686E0")]
			internal bool BCMIIJCJHFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x4068620", Offset = "0x4066E20", VA = "0x184068620")]
			internal void ADJPFJJKDFB(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x4068860", Offset = "0x4067060", VA = "0x184068860")]
			internal bool NNIOHDHPNHD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class HJCPDBKIHII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public BEMJKPMGLHF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public JGGDACCKCHI<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public HJCPDBKIHII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x422B0B0", Offset = "0x42298B0", VA = "0x18422B0B0")]
			internal void HAOODPDHEHL(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public override NodeVisualizationKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x999490", Offset = "0x997C90", VA = "0x180999490", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public override MEMLMGMKEHD JECDAJJPHCE
		{
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x45300D0", Offset = "0x452E8D0", VA = "0x1845300D0", Slot = "96")]
			get
			{
				return default(MEMLMGMKEHD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x452FF30", Offset = "0x452E730", VA = "0x18452FF30")]
		protected JGGDACCKCHI(AOMCPFNEFFD LMIJAEAMIME, TVariableNode JLFLGGOOAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x452F4B0", Offset = "0x452DCB0", VA = "0x18452F4B0", Slot = "90")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x452FAA0", Offset = "0x452E2A0", VA = "0x18452FAA0", Slot = "122")]
		protected override void PIJPPECABKH(AJNINOLHGBJ DEFPDELPAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x452F720", Offset = "0x452DF20", VA = "0x18452F720", Slot = "128")]
		protected virtual void JFKPGMJHLNL(AJNINOLHGBJ DEFPDELPAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x452F630", Offset = "0x452DE30", VA = "0x18452F630", Slot = "107")]
		public override void FGGFCKBCIEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x22CDD10", Offset = "0x22CC510", VA = "0x1822CDD10")]
	public static BKMGNOHAAAA DFLBOLBHLFN(AOMCPFNEFFD LMIJAEAMIME, GLIPNLBBOGL JLFLGGOOAGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class EGJMGEONAFG : MELIJAOBIDI, IJBNLIOAEHI, JOAECAAFOOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public MFKBDIPIOIA<LICJAHLPDHN> HACFOHAOJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x99C870", Offset = "0x99B070", VA = "0x18099C870", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(MFKBDIPIOIA<LICJAHLPDHN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public MFKBDIPIOIA<EGPAIJNGCOJ> AHEHLFNBBKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA99A90", Offset = "0xA98290", VA = "0x180A99A90", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(MFKBDIPIOIA<EGPAIJNGCOJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x22F3010", Offset = "0x22F1810", VA = "0x1822F3010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private MFKBDIPIOIA<EGNAIHIHHIJ> KFNIOCPHBDK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x98EC30", Offset = "0x98D430", VA = "0x18098EC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public override MFKBDIPIOIA<OIPDKGAIGFF> DDPCEBLKNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x22F3370", Offset = "0x22F1B70", VA = "0x1822F3370", Slot = "20")]
		get
		{
			return default(MFKBDIPIOIA<OIPDKGAIGFF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x22F33C0", Offset = "0x22F1BC0", VA = "0x1822F33C0")]
	private EGJMGEONAFG(AOMCPFNEFFD LMIJAEAMIME, GLIPNLBBOGL JLFLGGOOAGI, FFMBGBKCDII CDMHGEDKKJE, MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, MFKBDIPIOIA<EGPAIJNGCOJ> FDJOEDBJICL, MFKBDIPIOIA<EGNAIHIHHIJ> HCNLJDIECEE, bool LNFODNFBJDH, string IKMKCMDHFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x22F3020", Offset = "0x22F1820", VA = "0x1822F3020")]
	public static EGJMGEONAFG DFLBOLBHLFN(AOMCPFNEFFD LMIJAEAMIME, GLIPNLBBOGL JLFLGGOOAGI, FFMBGBKCDII ADMFIJLEOCG, MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, MFKBDIPIOIA<EGNAIHIHHIJ> HCNLJDIECEE, MFKBDIPIOIA<EGPAIJNGCOJ> FDJOEDBJICL, bool LNFODNFBJDH, bool NGGKGOLOAOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x22F3010", Offset = "0x22F1810", VA = "0x1822F3010")]
	internal void JIGIMKPLCDL(MFKBDIPIOIA<EGPAIJNGCOJ> INDENPJBLHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public abstract class MELIJAOBIDI : JOAECAAFOOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private struct LBAMNOFEOAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private MMOHCJCBBKK? EBKMKAENKDN;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x22FF390", Offset = "0x22FDB90", VA = "0x1822FF390")]
		public void CPGLBCDJJEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x22FF2F0", Offset = "0x22FDAF0", VA = "0x1822FF2F0")]
		public MMOHCJCBBKK AKLGCMEDAKC(MELIJAOBIDI JPECMPDFFCB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	protected readonly AOMCPFNEFFD AHDBCMDLDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	protected readonly GLIPNLBBOGL JNHDGCALHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private LBAMNOFEOAL POBJINANCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly CFOMJJLGOFB OEKGKMOJGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly List<ENCGFFEDOHJ> DKGCNPNBKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly List<IDCJJOMOLPA> IANLEEDDNJM;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	[DGOKMPKFCKH("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> LKMCLJBAMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x2301FF0", Offset = "0x23007F0", VA = "0x182301FF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public DisplayKind EJKOLEPGAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x8C5EE0", Offset = "0x8C46E0", VA = "0x1808C5EE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public MFKBDIPIOIA<JFDGELHFKII> PHABMAJJJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x2301F60", Offset = "0x2300760", VA = "0x182301F60", Slot = "6")]
		get
		{
			return default(MFKBDIPIOIA<JFDGELHFKII>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public JOEFEFGKPAB<JFDGELHFKII> HIEMDNOBAOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x2301570", Offset = "0x22FFD70", VA = "0x182301570", Slot = "7")]
		get
		{
			return default(JOEFEFGKPAB<JFDGELHFKII>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public CAHPCBPNPAB GNHJAJIEALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x974220", Offset = "0x972A20", VA = "0x180974220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public FNIKEFPMCEM JNMNPHPAHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x2300F30", Offset = "0x22FF730", VA = "0x182300F30", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	protected MMOHCJCBBKK JPJNCDCCPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x2300F30", Offset = "0x22FF730", VA = "0x182300F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public PortImage EEFEBOBJPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x23015A0", Offset = "0x22FFDA0", VA = "0x1823015A0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public string AEHPFKGBHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB220", Offset = "0x8B9A20", VA = "0x1808BB220", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFC0", Offset = "0x8B97C0", VA = "0x1808BAFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public JOEFEFGKPAB<BAFEGHIGBOE> BEFFBGIIHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x23012F0", Offset = "0x22FFAF0", VA = "0x1823012F0", Slot = "9")]
		get
		{
			return default(JOEFEFGKPAB<BAFEGHIGBOE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public MFKBDIPIOIA<NONADBDKHEF> HALBJJMJABD
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x958990", Offset = "0x957190", VA = "0x180958990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(MFKBDIPIOIA<NONADBDKHEF>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xA994D0", Offset = "0xA97CD0", VA = "0x180A994D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public abstract MFKBDIPIOIA<OIPDKGAIGFF> DDPCEBLKNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2302140", Offset = "0x2300940", VA = "0x182302140")]
	protected MELIJAOBIDI(AOMCPFNEFFD LMIJAEAMIME, GLIPNLBBOGL JLFLGGOOAGI, CFOMJJLGOFB NHIJINHMIHB, MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, bool LNFODNFBJDH, string IKMKCMDHFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x23011A0", Offset = "0x22FF9A0", VA = "0x1823011A0", Slot = "21")]
	protected virtual void EHFCOOMFLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x2300FF0", Offset = "0x22FF7F0", VA = "0x182300FF0", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x2301140", Offset = "0x22FF940", VA = "0x182301140", Slot = "14")]
	public void EHBGFBHJBHK(ENCGFFEDOHJ POIPOHLPAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x23014B0", Offset = "0x22FFCB0", VA = "0x1823014B0", Slot = "15")]
	public void GJPJDMMEJHD(IDCJJOMOLPA POIPOHLPAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x23018B0", Offset = "0x23000B0", VA = "0x1823018B0", Slot = "16")]
	public void NHMJLBAIJMJ(COLFFFFAMFM NPKDOLOBDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x23016D0", Offset = "0x22FFED0", VA = "0x1823016D0", Slot = "23")]
	protected virtual void LJKOENCFJAA(COLFFFFAMFM NPKDOLOBDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2301730", Offset = "0x22FFF30", VA = "0x182301730")]
	private void MPDMCKNFGLD(bool FNGOEBINDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x2300D80", Offset = "0x22FF580", VA = "0x182300D80")]
	private void AOBHLECFPIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x2301310", Offset = "0x22FFB10", VA = "0x182301310")]
	private void GFNFPAEGEDA([In] IFLACLGCCHB JHCGAOBMGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2301510", Offset = "0x22FFD10", VA = "0x182301510", Slot = "17")]
	public void HICOIBGMMMK(ENCGFFEDOHJ POIPOHLPAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2301F90", Offset = "0x2300790", VA = "0x182301F90", Slot = "18")]
	public void OPBHKCOLOIE(IDCJJOMOLPA POIPOHLPAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x8BAFC0", Offset = "0x8B97C0", VA = "0x1808BAFC0")]
	internal void IMPNACNMCJB(string IKMKCMDHFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2300FD0", Offset = "0x22FF7D0", VA = "0x182300FD0")]
	internal void CNPLJJFADAP(JIOHIJHGEOA HNBDHJIILED, CAHPCBPNPAB OCLAPBNMMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0xA994D0", Offset = "0xA97CD0", VA = "0x180A994D0")]
	internal void FBGOELKNOIE(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public sealed class FMNHFAJKAJA : LFJDBLMIGGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class LAAEGHPHLJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AOMCPFNEFFD circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public GLIPNLBBOGL node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public MFKBDIPIOIA<NONADBDKHEF> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public LAAEGHPHLJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x22FED20", Offset = "0x22FD520", VA = "0x1822FED20")]
		internal GCDFAKIPPAO IDNHKJMBENI((int PortDescIndex, int PortIndex, EJONBCNEKIH InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x22FEDB0", Offset = "0x22FD5B0", VA = "0x1822FEDB0")]
		internal EGJMGEONAFG OJNAJECAJFI(FFMBGBKCDII i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct FGADPNPEBPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public FMNHFAJKAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private OMMGKJLDNMP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x22F4AE0", Offset = "0x22F32E0", VA = "0x1822F4AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x22F4F40", Offset = "0x22F3740", VA = "0x1822F4F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct DIGIHAMBEAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public FMNHFAJKAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public MFKBDIPIOIA<JPEJPKEPEEM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private OMMGKJLDNMP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x22EBF30", Offset = "0x22EA730", VA = "0x1822EBF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x22EC280", Offset = "0x22EAA80", VA = "0x1822EC280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct NBAAAIBNMJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public FMNHFAJKAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public MFKBDIPIOIA<EGNAIHIHHIJ> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private OMMGKJLDNMP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2302700", Offset = "0x2300F00", VA = "0x182302700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2302A50", Offset = "0x2301250", VA = "0x182302A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct FJLDAPDABEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public FMNHFAJKAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public MFKBDIPIOIA<JPEJPKEPEEM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public MFKBDIPIOIA<JPEJPKEPEEM> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private OMMGKJLDNMP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x22F5010", Offset = "0x22F3810", VA = "0x1822F5010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x22F5360", Offset = "0x22F3B60", VA = "0x1822F5360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct ALDFNIHPODF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public FMNHFAJKAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public MFKBDIPIOIA<EGNAIHIHHIJ> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public MFKBDIPIOIA<EGNAIHIHHIJ> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private OMMGKJLDNMP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x22E9920", Offset = "0x22E8120", VA = "0x1822E9920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x22E9C70", Offset = "0x22E8470", VA = "0x1822E9C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct NGDPIFHPPHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public FMNHFAJKAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private OMMGKJLDNMP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2302DA0", Offset = "0x23015A0", VA = "0x182302DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2303210", Offset = "0x2301A10", VA = "0x182303210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct ALDKNFHDBEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public FMNHFAJKAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private OMMGKJLDNMP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x22E9CE0", Offset = "0x22E84E0", VA = "0x1822E9CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x22EA030", Offset = "0x22E8830", VA = "0x1822EA030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct HCONGBEOJMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public FMNHFAJKAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public MFKBDIPIOIA<JPEJPKEPEEM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private OMMGKJLDNMP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x22FC090", Offset = "0x22FA890", VA = "0x1822FC090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x22FC3E0", Offset = "0x22FABE0", VA = "0x1822FC3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct IIKEDLGLKMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public FMNHFAJKAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public MFKBDIPIOIA<EGNAIHIHHIJ> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private OMMGKJLDNMP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x22FCC60", Offset = "0x22FB460", VA = "0x1822FCC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x22FCFB0", Offset = "0x22FB7B0", VA = "0x1822FCFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct MODOAGCGDKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public FMNHFAJKAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public IPLLKAPKLNO type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public MFKBDIPIOIA<JPEJPKEPEEM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private OMMGKJLDNMP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x2302300", Offset = "0x2300B00", VA = "0x182302300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x2302690", Offset = "0x2300E90", VA = "0x182302690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct FKPDGAKDAHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public FMNHFAJKAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public IPLLKAPKLNO type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public MFKBDIPIOIA<EGNAIHIHHIJ> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private OMMGKJLDNMP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x22F5680", Offset = "0x22F3E80", VA = "0x1822F5680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x22F5A10", Offset = "0x22F4210", VA = "0x1822F5A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly bool IDCFAEKGOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly AOMCPFNEFFD AHDBCMDLDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly bool NNMEIKCGGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private PPJAPCKACCF<MKADPEDLCGB, GCDFAKIPPAO> DDIMCPFEGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private PPJAPCKACCF<MKADPEDLCGB, EHDAIELCBDF> GILEFIPCFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly GLIPNLBBOGL JNHDGCALHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private PPJAPCKACCF<EGPAIJNGCOJ, EGJMGEONAFG> HOMFJFKHBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private PPJAPCKACCF<EGPAIJNGCOJ, IJBNLIOAEHI> JOONMEGIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private string? HCCALJLHAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private readonly BAOKDDLDICK OCBOLPODOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private MFKBDIPIOIA<NONADBDKHEF> LGFDHKPOHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly bool DNEENAGNHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	[CompilerGenerated]
	private Action? CHLCIEAEDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	[CompilerGenerated]
	private Action? IDNHDENPOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	[CompilerGenerated]
	private Action<MFKBDIPIOIA<MKADPEDLCGB>>? FMGGMGJLMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	[CompilerGenerated]
	private Action<MFKBDIPIOIA<EGPAIJNGCOJ>>? PPLHHGNEEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	[CompilerGenerated]
	private LFJDBLMIGGO.GNJKMMILOGN? ODHAGEKIEBO;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool JJKJHAIOPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x22FAD00", Offset = "0x22F9500", VA = "0x1822FAD00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool BKILCJAOGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x22FA4B0", Offset = "0x22F8CB0", VA = "0x1822FA4B0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool AFMMIJNEACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x22FA610", Offset = "0x22F8E10", VA = "0x1822FA610", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public JOEFEFGKPAB<JFDGELHFKII> HIEMDNOBAOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x22F9D80", Offset = "0x22F8580", VA = "0x1822F9D80", Slot = "7")]
		get
		{
			return default(JOEFEFGKPAB<JFDGELHFKII>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool IBPLJDJMLDN
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x22F65B0", Offset = "0x22F4DB0", VA = "0x1822F65B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public PPJAPCKACCF<MKADPEDLCGB, EHDAIELCBDF> GACMKHDBHNC
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240", Slot = "9")]
		get
		{
			return default(PPJAPCKACCF<MKADPEDLCGB, EHDAIELCBDF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public string AEHPFKGBHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x22F9F00", Offset = "0x22F8700", VA = "0x1822F9F00", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public JOEFEFGKPAB<BAFEGHIGBOE> BEFFBGIIHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x22F9540", Offset = "0x22F7D40", VA = "0x1822F9540", Slot = "11")]
		get
		{
			return default(JOEFEFGKPAB<BAFEGHIGBOE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public PPJAPCKACCF<EGPAIJNGCOJ, IJBNLIOAEHI> GBPADEPMBME
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB220", Offset = "0x8B9A20", VA = "0x1808BB220", Slot = "12")]
		get
		{
			return default(PPJAPCKACCF<EGPAIJNGCOJ, IJBNLIOAEHI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public MFKBDIPIOIA<NONADBDKHEF> HALBJJMJABD
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x98EBF0", Offset = "0x98D3F0", VA = "0x18098EBF0", Slot = "13")]
		get
		{
			return default(MFKBDIPIOIA<NONADBDKHEF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action OHNKAJKNNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x22F5D70", Offset = "0x22F4570", VA = "0x1822F5D70", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x22F6F90", Offset = "0x22F5790", VA = "0x1822F6F90", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action MJMEHONAIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x22FAC50", Offset = "0x22F9450", VA = "0x1822FAC50", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x22F92B0", Offset = "0x22F7AB0", VA = "0x1822F92B0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<MFKBDIPIOIA<MKADPEDLCGB>, MFKBDIPIOIA<MKADPEDLCGB>> JCEOAFGNPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x22F64F0", Offset = "0x22F4CF0", VA = "0x1822F64F0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x22FA4F0", Offset = "0x22F8CF0", VA = "0x1822FA4F0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<MFKBDIPIOIA<MKADPEDLCGB>, MFKBDIPIOIA<MKADPEDLCGB>> LLCBAIKPGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x22FB6A0", Offset = "0x22F9EA0", VA = "0x1822FB6A0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x22F8D90", Offset = "0x22F7590", VA = "0x1822F8D90", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<MFKBDIPIOIA<EGPAIJNGCOJ>, MFKBDIPIOIA<EGPAIJNGCOJ>> DIOCCPEHMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x22FAA10", Offset = "0x22F9210", VA = "0x1822FAA10", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x22F9560", Offset = "0x22F7D60", VA = "0x1822F9560", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<MFKBDIPIOIA<EGPAIJNGCOJ>, MFKBDIPIOIA<EGPAIJNGCOJ>> PIKIBIJBEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x22F6430", Offset = "0x22F4C30", VA = "0x1822F6430", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x22F6630", Offset = "0x22F4E30", VA = "0x1822F6630", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<MFKBDIPIOIA<MKADPEDLCGB>, EHDAIELCBDF> HOJALFCHOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x22F8520", Offset = "0x22F6D20", VA = "0x1822F8520", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x22FA050", Offset = "0x22F8850", VA = "0x1822FA050", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<MFKBDIPIOIA<MKADPEDLCGB>> NOEDAMAACKK
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x22F6250", Offset = "0x22F4A50", VA = "0x1822F6250", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x22F5A80", Offset = "0x22F4280", VA = "0x1822F5A80", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<MFKBDIPIOIA<MKADPEDLCGB>, EHDAIELCBDF> GHDKJPHOMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x22F8E50", Offset = "0x22F7650", VA = "0x1822F8E50", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x22FB760", Offset = "0x22F9F60", VA = "0x1822FB760", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<MFKBDIPIOIA<EGPAIJNGCOJ>, IJBNLIOAEHI> CLGDOHBKLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x22F9480", Offset = "0x22F7C80", VA = "0x1822F9480", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x22FA910", Offset = "0x22F9110", VA = "0x1822FA910", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<MFKBDIPIOIA<EGPAIJNGCOJ>> ELHGPODMGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x22FAB90", Offset = "0x22F9390", VA = "0x1822FAB90", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x22F6ED0", Offset = "0x22F56D0", VA = "0x1822F6ED0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<MFKBDIPIOIA<EGPAIJNGCOJ>, IJBNLIOAEHI> DBPCCKBHFEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x22FAAD0", Offset = "0x22F92D0", VA = "0x1822FAAD0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x22F6750", Offset = "0x22F4F50", VA = "0x1822F6750", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x22FB930", Offset = "0x22FA130", VA = "0x1822FB930")]
	private FMNHFAJKAJA(bool LNFODNFBJDH, AOMCPFNEFFD LMIJAEAMIME, bool DHDDDJHIIOG, PPJAPCKACCF<MKADPEDLCGB, GCDFAKIPPAO> FMFMIBEMFDO, PPJAPCKACCF<MKADPEDLCGB, EHDAIELCBDF> AAOFJDIMMCK, GLIPNLBBOGL JLFLGGOOAGI, PPJAPCKACCF<EGPAIJNGCOJ, EGJMGEONAFG> AFCJOLOFINI, PPJAPCKACCF<EGPAIJNGCOJ, IJBNLIOAEHI> AFODECPKDLA, string? CFPLBKOACFG, BAOKDDLDICK JPGJANANMOL, MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, bool NGGKGOLOAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x22F6810", Offset = "0x22F5010", VA = "0x1822F6810")]
	public static FMNHFAJKAJA DFLBOLBHLFN(bool LNFODNFBJDH, AOMCPFNEFFD LMIJAEAMIME, bool DHDDDJHIIOG, GLIPNLBBOGL JLFLGGOOAGI, BAOKDDLDICK JPGJANANMOL, MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, bool NGGKGOLOAOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x22F85E0", Offset = "0x22F6DE0", VA = "0x1822F85E0")]
	private void EHFCOOMFLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x22F7480", Offset = "0x22F5C80", VA = "0x1822F7480", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x22F9B60", Offset = "0x22F8360", VA = "0x1822F9B60", Slot = "38")]
	[AsyncStateMachine(typeof(FGADPNPEBPM))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> HPCDGFCKDEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x22F5B40", Offset = "0x22F4340", VA = "0x1822F5B40")]
	private (DLGPFBJLNDD, int)? AMEPBMMMBPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x22FA800", Offset = "0x22F9000", VA = "0x1822FA800")]
	private void MCJFNNNEGON(int HDKBHLNIHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x1949C90", Offset = "0x1948490", VA = "0x181949C90")]
	private void DKCPOKPCGGO(int HDKBHLNIHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x22FA110", Offset = "0x22F8910", VA = "0x1822FA110")]
	private void KOJHINFHLFP(int BEFJEBAOHLP, int MFKLFKCFFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x22F66F0", Offset = "0x22F4EF0", VA = "0x1822F66F0")]
	private void COHPMJNMHEP(int BEFJEBAOHLP, int MFKLFKCFFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x22FB160", Offset = "0x22F9960", VA = "0x1822FB160")]
	private void OLABNIEMNAK(int HDKBHLNIHEH, MFKBDIPIOIA<MKADPEDLCGB> GHFINLHKMLO, EJONBCNEKIH DOCBAALINAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x22FA9D0", Offset = "0x22F91D0", VA = "0x1822FA9D0")]
	private void MMNKCBGDLGL(int FNGOEBINDAF, MFKBDIPIOIA<MKADPEDLCGB> GHFINLHKMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x22FA9F0", Offset = "0x22F91F0", VA = "0x1822FA9F0")]
	private void MOCECNBHLLM(int FNGOEBINDAF, MFKBDIPIOIA<MKADPEDLCGB> GHFINLHKMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x22F7030", Offset = "0x22F5830", VA = "0x1822F7030")]
	private void DNLDGNOONFI(int HDKBHLNIHEH, MFKBDIPIOIA<MKADPEDLCGB> GHFINLHKMLO, EJONBCNEKIH DOCBAALINAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x22F9DB0", Offset = "0x22F85B0", VA = "0x1822F9DB0")]
	private void IIKACEFGACL(int HDKBHLNIHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0xE7F6D0", Offset = "0xE7DED0", VA = "0x180E7F6D0")]
	private void PNJPODMPIOD(int HDKBHLNIHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x22F6030", Offset = "0x22F4830", VA = "0x1822F6030")]
	private void APAMKIBNADO(int HDKBHLNIHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x1949C90", Offset = "0x1948490", VA = "0x181949C90")]
	private void OLOBJJBLCNO(int HDKBHLNIHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x22FADC0", Offset = "0x22F95C0", VA = "0x1822FADC0")]
	private void OIMOHAOGGNP(int BEFJEBAOHLP, int MFKLFKCFFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x22FA5B0", Offset = "0x22F8DB0", VA = "0x1822FA5B0")]
	private void LAOHBIAINAP(int BEFJEBAOHLP, int MFKLFKCFFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x22F9620", Offset = "0x22F7E20", VA = "0x1822F9620")]
	private void HAJJJFBGNBJ(int HDKBHLNIHEH, MFKBDIPIOIA<EGPAIJNGCOJ> GHFINLHKMLO, FFMBGBKCDII DOCBAALINAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x22FA8F0", Offset = "0x22F90F0", VA = "0x1822FA8F0")]
	private void MKPGCMCFKGH(int FNGOEBINDAF, MFKBDIPIOIA<EGPAIJNGCOJ> GHFINLHKMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x22FA7E0", Offset = "0x22F8FE0", VA = "0x1822FA7E0")]
	private void MBBDHBMEDGD(int FNGOEBINDAF, MFKBDIPIOIA<EGPAIJNGCOJ> GHFINLHKMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x22F80B0", Offset = "0x22F68B0", VA = "0x1822F80B0")]
	private void EFBPJJJFNKO(int HDKBHLNIHEH, MFKBDIPIOIA<EGPAIJNGCOJ> GHFINLHKMLO, FFMBGBKCDII DOCBAALINAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x22F6D80", Offset = "0x22F5580", VA = "0x1822F6D80")]
	private void DICOOHNCKHC(int HDKBHLNIHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xE7F6D0", Offset = "0xE7DED0", VA = "0x180E7F6D0")]
	private void ACMAKCCFMOC(int HDKBHLNIHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x22FA6D0", Offset = "0x22F8ED0", VA = "0x1822FA6D0", Slot = "39")]
	[AsyncStateMachine(typeof(DIGIHAMBEAK))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> LCNBFNOGMIA(MFKBDIPIOIA<JPEJPKEPEEM> MPMKNHFAGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x22FB820", Offset = "0x22FA020", VA = "0x1822FB820", Slot = "40")]
	[AsyncStateMachine(typeof(NBAAAIBNMJH))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> PPPPAGNLEBD(MFKBDIPIOIA<EGNAIHIHHIJ> HCNLJDIECEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x22F9360", Offset = "0x22F7B60", VA = "0x1822F9360", Slot = "41")]
	[AsyncStateMachine(typeof(FJLDAPDABEB))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> FKMHPDOGAMO(MFKBDIPIOIA<JPEJPKEPEEM> MPMKNHFAGIC, MFKBDIPIOIA<JPEJPKEPEEM> BMMLFKJNJNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x22F6310", Offset = "0x22F4B10", VA = "0x1822F6310", Slot = "42")]
	[AsyncStateMachine(typeof(ALDFNIHPODF))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> BIJNJKELGOJ(MFKBDIPIOIA<EGNAIHIHHIJ> HCNLJDIECEE, MFKBDIPIOIA<EGNAIHIHHIJ> BMMLFKJNJNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x22F5E10", Offset = "0x22F4610", VA = "0x1822F5E10", Slot = "43")]
	[AsyncStateMachine(typeof(NGDPIFHPPHD))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> AMFJPOBMGGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x22F9F30", Offset = "0x22F8730", VA = "0x1822F9F30", Slot = "44")]
	[AsyncStateMachine(typeof(ALDKNFHDBEN))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> JFBIAEHJCKE(string GPCMCGJDEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x22F5F00", Offset = "0x22F4700", VA = "0x1822F5F00", Slot = "45")]
	[AsyncStateMachine(typeof(HCONGBEOJMO))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> ANANHHFEHKP(MFKBDIPIOIA<JPEJPKEPEEM> MPMKNHFAGIC, string IKMKCMDHFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x22F6120", Offset = "0x22F4920", VA = "0x1822F6120", Slot = "46")]
	[AsyncStateMachine(typeof(IIKEDLGLKMC))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> BBAFPHDPIMI(MFKBDIPIOIA<EGNAIHIHHIJ> HCNLJDIECEE, string IKMKCMDHFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x22F9C50", Offset = "0x22F8450", VA = "0x1822F9C50", Slot = "47")]
	[AsyncStateMachine(typeof(MODOAGCGDKN))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> IAFPGMEOOGH(MFKBDIPIOIA<JPEJPKEPEEM> MPMKNHFAGIC, IPLLKAPKLNO OCLAPBNMMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x22F7F80", Offset = "0x22F6780", VA = "0x1822F7F80", Slot = "48")]
	[AsyncStateMachine(typeof(FKPDGAKDAHK))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> ECCOBDFFEKF(MFKBDIPIOIA<EGNAIHIHHIJ> HCNLJDIECEE, IPLLKAPKLNO OCLAPBNMMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x22F8F10", Offset = "0x22F7710", VA = "0x1822F8F10")]
	internal void FBGOELKNOIE(MFKBDIPIOIA<NONADBDKHEF> INDENPJBLHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public sealed class FCKNIGOELJC : JBMLOFKPLDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public interface OPACNDIGFBE
	{
		[Cpp2IlInjected.Token(Token = "0x20000C1")]
		public readonly struct LAJEILIFMEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026A")]
			public readonly IReadOnlyDictionary<JOEFEFGKPAB<JFDGELHFKII>, Guid>? LNGOHDGOBCN;

			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0x95E8E0", Offset = "0x95D0E0", VA = "0x18095E8E0")]
			public LAJEILIFMEI(IReadOnlyDictionary<JOEFEFGKPAB<JFDGELHFKII>, Guid>? LNGOHDGOBCN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		JIOHIJHGEOA ACFNGBNMALF
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<KMEGMNNEBLN> EIOIOLFKEIE(CancellationToken ALKEMFHOMCA);

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<IKLNHKOGGAD> HFHAGDEBPDF(CancellationToken ALKEMFHOMCA);

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<KNKCGNGKHLD> JCPGJCENNKN(CancellationToken ALKEMFHOMCA);

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<LAJEILIFMEI> LDDPIAHHLLB(CancellationToken ALKEMFHOMCA);

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<HEBIHEEFNAF> JPCGDKNPAAK(CancellationToken ALKEMFHOMCA);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct LFLKCAEECLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AsyncTaskMethodBuilder<FCKNIGOELJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public AOMCPFNEFFD circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public KMEGMNNEBLN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public IKLNHKOGGAD superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private OPACNDIGFBE <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private KMEGMNNEBLN <downloadedRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private KMEGMNNEBLN <actualRoomData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private HEBIHEEFNAF <actualStaticConfig>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private IKLNHKOGGAD <finalSuperRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private KNKCGNGKHLD <playerSaveData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<KMEGMNNEBLN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private KMEGMNNEBLN <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<HEBIHEEFNAF> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private TaskAwaiter<IKLNHKOGGAD> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private TaskAwaiter<KNKCGNGKHLD> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<OPACNDIGFBE.LAJEILIFMEI> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private TaskAwaiter<KIOKJOJHBCJ> <>u__6;

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x22FF3A0", Offset = "0x22FDBA0", VA = "0x1822FF3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x2300220", Offset = "0x22FEA20", VA = "0x182300220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private readonly KIOKJOJHBCJ CBCLGEBPPLA;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public KIOKJOJHBCJ ALGDGBNCDEI
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	private FCKNIGOELJC(KIOKJOJHBCJ LIDODDCPNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x22F46E0", Offset = "0x22F2EE0", VA = "0x1822F46E0")]
	[AsyncStateMachine(typeof(LFLKCAEECLC))]
	public static Task<FCKNIGOELJC> NADGDMNNJMC(AOMCPFNEFFD LMIJAEAMIME, KMEGMNNEBLN? NKIGLKBMOAI, IKLNHKOGGAD? MLNPIEGNENI, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x22F46C0", Offset = "0x22F2EC0", VA = "0x1822F46C0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public readonly struct CBALPKPBCNC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct GLBKBAECKLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<object, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public CBALPKPBCNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public MKGNMHKEPFM action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private TaskAwaiter<DNFCNMKAMCE<object, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x22FBC80", Offset = "0x22FA480", VA = "0x1822FBC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x22FBF10", Offset = "0x22FA710", VA = "0x1822FBF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct DEEAGKMEEOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<bool, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public GCJNKFOOMCL rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public KMEGMNNEBLN circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public IKLNHKOGGAD superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public CBALPKPBCNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private MKGNMHKEPFM[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter<DNFCNMKAMCE<object, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x22EBAE0", Offset = "0x22EA2E0", VA = "0x1822EBAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x22EBEC0", Offset = "0x22EA6C0", VA = "0x1822EBEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct FKCJAODHDDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public CBALPKPBCNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<DNFCNMKAMCE<object, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x22F53D0", Offset = "0x22F3BD0", VA = "0x1822F53D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x22F5610", Offset = "0x22F3E10", VA = "0x1822F5610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private readonly GFPBIJPMNFJ AOPJDLKOAGN;

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x95E8E0", Offset = "0x95D0E0", VA = "0x18095E8E0")]
	public CBALPKPBCNC(GFPBIJPMNFJ CMECFNDONCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x22EA690", Offset = "0x22E8E90", VA = "0x1822EA690")]
	[AsyncStateMachine(typeof(GLBKBAECKLH))]
	private Task<DNFCNMKAMCE<object, OOJAGAFOLJL>> BPOCLEJAMHG(MKGNMHKEPFM ILIPDNLABEN, bool MLCJJOIGOGP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x22EA7C0", Offset = "0x22E8FC0", VA = "0x1822EA7C0")]
	[AsyncStateMachine(typeof(DEEAGKMEEOM))]
	public Task<DNFCNMKAMCE<bool, OOJAGAFOLJL?>>? KCEAMMPBDIO(int GEFHELCJEMK, GCJNKFOOMCL? CMEOFAPCKNI, KMEGMNNEBLN? DLOKACDBIFM, IKLNHKOGGAD? MLNPIEGNENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x22EA5A0", Offset = "0x22E8DA0", VA = "0x1822EA5A0")]
	[AsyncStateMachine(typeof(FKCJAODHDDI))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> ANFLKJPBFFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public sealed class IKEAKKLPJCD : OCKDFBJBEPI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private readonly IHKNCBOJJNC INGKOHHKONB;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public IHKNCBOJJNC AJLHFBOBJJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	private IKEAKKLPJCD(IHKNCBOJJNC JOJAPINAABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x22FD040", Offset = "0x22FB840", VA = "0x1822FD040")]
	public static IKEAKKLPJCD KDFBDMHOPOO(AOMCPFNEFFD LMIJAEAMIME, GCJNKFOOMCL CDIHKOIKDGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x22FD020", Offset = "0x22FB820", VA = "0x1822FD020", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public interface KKILICBDGJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	KIOKJOJHBCJ ALGDGBNCDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	DAFFNNBLCBC FDFNKFFBEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	GLHCPEIFFHC CCJMDPKBMBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	EFIPKHIJODD NFEAJLIPOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public interface GOMIMGJHHHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	KKILICBDGJN? BJHEGGPMLEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool KNPGJHABEDH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool KINKJHOIOBF
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<KKILICBDGJN?>? MDFBAHEHAFA();

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task MKPLKOMPAGH(AOMCPFNEFFD LMIJAEAMIME, GCJNKFOOMCL CDIHKOIKDGK, KMEGMNNEBLN? EMGKPHLAKII, IKLNHKOGGAD? JPBPHGHNGLJ);
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[JCCIDHPDJJP("IStaticCV2Instance")]
public interface JBMLOFKPLDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	KIOKJOJHBCJ ALGDGBNCDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[JCCIDHPDJJP("IStaticEVInstance")]
public interface OCKDFBJBEPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	IHKNCBOJJNC AJLHFBOBJJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public static class LAJOJOCDHID
{
	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x22FEE40", Offset = "0x22FD640", VA = "0x1822FEE40")]
	public static GGOLPAHLCHH<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD, NIHBHKNCMKD.CAFEHNEHCJD<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD>> MCCGHHAFOEM([In] this GGOLPAHLCHH<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD, NIHBHKNCMKD.CAFEHNEHCJD<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD>> BEHPHKKJIBF)
	{
		return default(GGOLPAHLCHH<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD, NIHBHKNCMKD.CAFEHNEHCJD<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public sealed class PHHMKNHOBNC : LMHJPKAJJMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private readonly AOMCPFNEFFD AHDBCMDLDJP;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool KINKJHOIOBF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x23042F0", Offset = "0x2302AF0", VA = "0x1823042F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	internal PHHMKNHOBNC(AOMCPFNEFFD LMIJAEAMIME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal sealed class JGLKLIHFAHM : POKCGEAPCNE
{
	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x22FD600", Offset = "0x22FBE00", VA = "0x1822FD600", Slot = "4")]
	public ONAPCHHGCAM? AHLOELOKGMH(string? JBODGMCHKCE, string? IAANNDFCKGN, string? ALDCKNFAHCK, CHJIGCPIMNH.AJGMAJCPPBG.HOLNOHNPKML CMCKAINDMLE, bool KCOHNLIDKED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public JGLKLIHFAHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class CFLJFEEKLNO : JKLADEMEFPG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct JGEJFOBGAIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AsyncTaskMethodBuilder<LPEPBMDCHIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public CFLJFEEKLNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<KKILICBDGJN?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x22FD300", Offset = "0x22FBB00", VA = "0x1822FD300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x22FD590", Offset = "0x22FBD90", VA = "0x1822FD590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private readonly AOMCPFNEFFD AHDBCMDLDJP;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public LPEPBMDCHIC? ODDIIHPHFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x22EA920", Offset = "0x22E9120", VA = "0x1822EA920", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public EFIPKHIJODD? MIPCKJLFCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x22EAA00", Offset = "0x22E9200", VA = "0x1822EAA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool LBHJGFNJMKD
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x22EB210", Offset = "0x22E9A10", VA = "0x1822EB210", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool ALFEALEIJIN
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x22EA9A0", Offset = "0x22E91A0", VA = "0x1822EA9A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x22EB410", Offset = "0x22E9C10", VA = "0x1822EB410")]
	internal CFLJFEEKLNO(AOMCPFNEFFD LMIJAEAMIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x22EAF80", Offset = "0x22E9780", VA = "0x1822EAF80", Slot = "7")]
	[AsyncStateMachine(typeof(JGEJFOBGAIA))]
	public Task<LPEPBMDCHIC> LMHBNENLBDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x22EAC10", Offset = "0x22E9410", VA = "0x1822EAC10", Slot = "9")]
	public IReadOnlyDictionary<JOEFEFGKPAB<JFDGELHFKII>, Guid> KPFBACHAGDK(IEnumerable<MAAAODAGNHE> EBEGOLHLDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x22EAA80", Offset = "0x22E9280", VA = "0x1822EAA80", Slot = "10")]
	public OHLJLDLMFEA KNMKDJCOHEP(IEnumerable<MAAAODAGNHE> EBEGOLHLDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x22EB270", Offset = "0x22E9A70", VA = "0x1822EB270")]
	public DNFCNMKAMCE<PEIMGGKAPBD, EPICLACHOCO> POMKABDLFFA([In] PEIMGGKAPBD MJHHPNCPLLH)
	{
		return default(DNFCNMKAMCE<PEIMGGKAPBD, EPICLACHOCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x22EB070", Offset = "0x22E9870", VA = "0x1822EB070", Slot = "8")]
	private DNFCNMKAMCE<PEIMGGKAPBD, EPICLACHOCO> LNMGJNAFACE([In] PEIMGGKAPBD MJHHPNCPLLH)
	{
		return default(DNFCNMKAMCE<PEIMGGKAPBD, EPICLACHOCO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class EFIPKHIJODD : LPEPBMDCHIC
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	internal static class LKGGEAIOKDL
	{
		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class CENDFLMKDOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			public KIOKJOJHBCJ state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			public MDLGLPLIMFK spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600051C")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public CENDFLMKDOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0x2307460", Offset = "0x2305C60", VA = "0x182307460")]
			internal bool FCJNJCCIDHJ(NBDGNDNMGDB n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class APPGCLGCFKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A8")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public APPGCLGCFKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x2306CD0", Offset = "0x23054D0", VA = "0x182306CD0")]
			internal void GENGHIJMOPM(NBDGNDNMGDB n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x2309D10", Offset = "0x2308510", VA = "0x182309D10")]
		public static DNFCNMKAMCE<LPEPBMDCHIC.CMDCOGIPODK, PKCOADCNKKN> BDBMLJNBAHE(EFIPKHIJODD EGGDEECAALI, [In] LPEPBMDCHIC.FBNOPLHHNHO GIOJKAECAOO)
		{
			return default(DNFCNMKAMCE<LPEPBMDCHIC.CMDCOGIPODK, PKCOADCNKKN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x230A6D0", Offset = "0x2308ED0", VA = "0x18230A6D0")]
		internal static DNFCNMKAMCE<(LNCALEDHDDI, JFNAKGBMIPI), PKCOADCNKKN> DNIDLPEGPFP(EFIPKHIJODD EGGDEECAALI, JFNAKGBMIPI EIIHLMNAPCN, bool BACAGMCDLGF, [In] JOEFEFGKPAB<JFDGELHFKII> NFIEMNLGPGK, [In] int? PEGIOAPFJCH, [In] EBOIACDJEEB? EHKBOJMEFMK, [In] EBOIACDJEEB? GAMIMJIJCEL)
		{
			return default(DNFCNMKAMCE<(LNCALEDHDDI, JFNAKGBMIPI), PKCOADCNKKN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x230A250", Offset = "0x2308A50", VA = "0x18230A250")]
		private static void BFIEFMHDFCM(bool BACAGMCDLGF, MAAAODAGNHE EJLNBEBPJEL, LNCALEDHDDI AGPABBACCPO, [In] JOEFEFGKPAB<JFDGELHFKII> NFIEMNLGPGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x230B5F0", Offset = "0x2309DF0", VA = "0x18230B5F0")]
		public static void MBNMLDIPJNJ(IOCFMLAJICE BBKGHLDNIHG, [In] LPEPBMDCHIC.OBHLHKMHHNC HLENOIAOMCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x2309C20", Offset = "0x2308420", VA = "0x182309C20")]
		[CompilerGenerated]
		internal static bool ANGMDFPKGLK(KIOKJOJHBCJ CEAMHBHHIHN, MDLGLPLIMFK BMCKLLMNFNH, NBDGNDNMGDB GLNPPJDINFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x230B9F0", Offset = "0x230A1F0", VA = "0x18230B9F0")]
		[CompilerGenerated]
		internal static bool MGIFBDLDKGC(NBDGNDNMGDB JLMLAIIAOPK)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct EIIKIAMFOBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public EFIPKHIJODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public MFKBDIPIOIA<JFDGELHFKII> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public MFKBDIPIOIA<BAFEGHIGBOE> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public DFACKOPMILK offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x2307840", Offset = "0x2306040", VA = "0x182307840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x2307A80", Offset = "0x2306280", VA = "0x182307A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct PIEGCFNEOKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public EFIPKHIJODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public MFKBDIPIOIA<JFDGELHFKII> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public JOEFEFGKPAB<BAFEGHIGBOE> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public List<MFKBDIPIOIA<BAFEGHIGBOE>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public DFACKOPMILK localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public ADGOFHPALPO localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public DFACKOPMILK offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x230D930", Offset = "0x230C130", VA = "0x18230D930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x230DBF0", Offset = "0x230C3F0", VA = "0x18230DBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct BIOGFCNLDOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public EFIPKHIJODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public MFKBDIPIOIA<JFDGELHFKII> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public JOEFEFGKPAB<BAFEGHIGBOE> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public List<MFKBDIPIOIA<BAFEGHIGBOE>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x2306CF0", Offset = "0x23054F0", VA = "0x182306CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x2306F30", Offset = "0x2305730", VA = "0x182306F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct PJDLPLKOGMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public EFIPKHIJODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public MFKBDIPIOIA<JFDGELHFKII> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public JOEFEFGKPAB<BAFEGHIGBOE> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public MFKBDIPIOIA<JFDGELHFKII> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public List<MFKBDIPIOIA<BAFEGHIGBOE>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x230DCC0", Offset = "0x230C4C0", VA = "0x18230DCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x230DF00", Offset = "0x230C700", VA = "0x18230DF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct LJCCCLGMMBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public EFIPKHIJODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public MFKBDIPIOIA<JFDGELHFKII> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public MFKBDIPIOIA<LICJAHLPDHN> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public MFKBDIPIOIA<EGENAIBALPJ> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x2309560", Offset = "0x2307D60", VA = "0x182309560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x2309BB0", Offset = "0x23083B0", VA = "0x182309BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct GEKMNOAIFDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public EFIPKHIJODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public JOEFEFGKPAB<BAFEGHIGBOE> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public JOEFEFGKPAB<JFDGELHFKII> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public MFKBDIPIOIA<NONADBDKHEF> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public MFKBDIPIOIA<MKADPEDLCGB> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x2307E00", Offset = "0x2306600", VA = "0x182307E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x2308140", Offset = "0x2306940", VA = "0x182308140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct BOAEGCFMALE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public EFIPKHIJODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public JOEFEFGKPAB<BAFEGHIGBOE> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public JOEFEFGKPAB<JFDGELHFKII> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public MFKBDIPIOIA<NONADBDKHEF> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public MFKBDIPIOIA<EGPAIJNGCOJ> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x23070B0", Offset = "0x23058B0", VA = "0x1823070B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x23073F0", Offset = "0x2305BF0", VA = "0x1823073F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private readonly AOMCPFNEFFD AHDBCMDLDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private readonly JBMLOFKPLDF CCCEGPCCDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private readonly OCKDFBJBEPI ELHMEKMCPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private readonly ICMGIGHAKCJ GOCLAAFHIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private readonly CFLJFEEKLNO PGCLOHHPABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private Dictionary<JOEFEFGKPAB<BAFEGHIGBOE>, BKMGNOHAAAA> FEBIBKEHJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[CompilerGenerated]
	private Action<JOEFEFGKPAB<BAFEGHIGBOE>>? HEDBMPOJLHL;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public JOEFEFGKPAB<JFDGELHFKII> MHBKDKHLPEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x22EE330", Offset = "0x22ECB30", VA = "0x1822EE330", Slot = "4")]
		get
		{
			return default(JOEFEFGKPAB<JFDGELHFKII>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public ICMGIGHAKCJ JCCGPLKGDEH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x22CCC50", Offset = "0x22CB450", VA = "0x1822CCC50", Slot = "5")]
		get
		{
			return default(ICMGIGHAKCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x22F2AF0", Offset = "0x22F12F0", VA = "0x1822F2AF0")]
	public EFIPKHIJODD(AOMCPFNEFFD LMIJAEAMIME, JBMLOFKPLDF OOGOGIAGFFG, OCKDFBJBEPI NBNKOOFNNFK, CFLJFEEKLNO AGHBKNCLHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x22EC650", Offset = "0x22EAE50", VA = "0x1822EC650", Slot = "61")]
	public MFKBDIPIOIA<CDIJANMHJLH> ABHIMOPMGPG(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF)
	{
		return default(MFKBDIPIOIA<CDIJANMHJLH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x22F1440", Offset = "0x22EFC40", VA = "0x1822F1440", Slot = "62")]
	public MFKBDIPIOIA<PACBLAKJPKF> MKNBBPDNKKG(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<LICJAHLPDHN> FDJOEDBJICL)
	{
		return default(MFKBDIPIOIA<PACBLAKJPKF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x22ED800", Offset = "0x22EC000", VA = "0x1822ED800", Slot = "6")]
	public (bool, bool) EDCFLGBHKEH(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<LICJAHLPDHN> PAJDGBOEEGB, MFKBDIPIOIA<EGENAIBALPJ> NHHGLDMFOFN)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x22EF4E0", Offset = "0x22EDCE0", VA = "0x1822EF4E0")]
	public bool HHDNAHBKAKP(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, [In] PMJOPIFDLOG HGKHHHEEPBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x22ECF00", Offset = "0x22EB700", VA = "0x1822ECF00", Slot = "8")]
	public bool DCMGINJMOKI(EHDAIELCBDF JKMPEPHBGBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x22EC990", Offset = "0x22EB190", VA = "0x1822EC990", Slot = "9")]
	public bool ALAFNIGFLLG(IJBNLIOAEHI KKLDJHFOOME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x22ECF80", Offset = "0x22EB780", VA = "0x1822ECF80", Slot = "10")]
	public ODLBJJMHBNG? DDLGPNIPEDK(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x22EF420", Offset = "0x22EDC20", VA = "0x1822EF420", Slot = "11")]
	public IDEJLHECAGG? HBGLMKLDIFO(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<LICJAHLPDHN> FDJOEDBJICL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x22EE0C0", Offset = "0x22EC8C0", VA = "0x1822EE0C0", Slot = "12")]
	public MFKBDIPIOIA<LICJAHLPDHN>? EOPNGDCJBNF(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<BAFEGHIGBOE> FJIFOJCFNEO, MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, MFKBDIPIOIA<EGPAIJNGCOJ> HFNEAMCNOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x22EE6C0", Offset = "0x22ECEC0", VA = "0x1822EE6C0", Slot = "13")]
	public MFKBDIPIOIA<EGENAIBALPJ>? FMGPDEJEBDD(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<BAFEGHIGBOE> FJIFOJCFNEO, MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, MFKBDIPIOIA<MKADPEDLCGB> MBDHFCHAHDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x22F1570", Offset = "0x22EFD70", VA = "0x1822F1570", Slot = "14")]
	public IEnumerable<MFKBDIPIOIA<JFDGELHFKII>> NHMKGDNDMIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x22F14C0", Offset = "0x22EFCC0", VA = "0x1822F14C0", Slot = "15")]
	public IEnumerable<MFKBDIPIOIA<FBCIDBAFOIC>> NGEDNJFOOEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x22ECE90", Offset = "0x22EB690", VA = "0x1822ECE90", Slot = "16")]
	public string DAOFNCHHNFO(MFKBDIPIOIA<FBCIDBAFOIC> PMLFAFLLCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x22EE540", Offset = "0x22ECD40", VA = "0x1822EE540", Slot = "17")]
	public string FFJKDDCINNK(MFKBDIPIOIA<FBCIDBAFOIC> PMLFAFLLCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x22ECCC0", Offset = "0x22EB4C0", VA = "0x1822ECCC0")]
	public BKMGNOHAAAA? CFBJNPNBHEC([In] JOEFEFGKPAB<BAFEGHIGBOE> FJIFOJCFNEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x22F1120", Offset = "0x22EF920", VA = "0x1822F1120", Slot = "23")]
	public MFKBDIPIOIA<CIOMHJNJFLM> MDCLNDGAANJ(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<BAFEGHIGBOE> FJIFOJCFNEO)
	{
		return default(MFKBDIPIOIA<CIOMHJNJFLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x22ED040", Offset = "0x22EB840", VA = "0x1822ED040")]
	public MFKBDIPIOIA<BAFEGHIGBOE> DFCPANJNBMA(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, [In] JOEFEFGKPAB<BAFEGHIGBOE> LBLNODLNPIJ)
	{
		return default(MFKBDIPIOIA<BAFEGHIGBOE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x22F2A70", Offset = "0x22F1270", VA = "0x1822F2A70", Slot = "33")]
	public MFKBDIPIOIA<BAFEGHIGBOE> PPNPJPMCOFG(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF)
	{
		return default(MFKBDIPIOIA<BAFEGHIGBOE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x22EE5B0", Offset = "0x22ECDB0", VA = "0x1822EE5B0", Slot = "34")]
	public MFKBDIPIOIA<BAFEGHIGBOE> FGJDJFHINGJ(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<LICJAHLPDHN> FDJOEDBJICL)
	{
		return default(MFKBDIPIOIA<BAFEGHIGBOE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x22ED0C0", Offset = "0x22EB8C0", VA = "0x1822ED0C0", Slot = "25")]
	public KFMBONPEPKJ? DODDCIIGKBO(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x22F0430", Offset = "0x22EEC30", VA = "0x1822F0430", Slot = "26")]
	public long JCCDEAIELDO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x22F0B50", Offset = "0x22EF350", VA = "0x1822F0B50")]
	private void LJKFGENJAOH(JOEFEFGKPAB<BAFEGHIGBOE> FJIFOJCFNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x22EEB80", Offset = "0x22ED380", VA = "0x1822EEB80", Slot = "31")]
	public IEnumerable<(MFKBDIPIOIA<JFDGELHFKII>, MFKBDIPIOIA<BAFEGHIGBOE>)> GAKKABDPJBM(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x22EE630", Offset = "0x22ECE30", VA = "0x1822EE630", Slot = "32")]
	public MFKBDIPIOIA<EGENAIBALPJ> FMGPDEJEBDD(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<BAFEGHIGBOE> FJIFOJCFNEO, MFKBDIPIOIA<CDIJANMHJLH> MBDHFCHAHDG)
	{
		return default(MFKBDIPIOIA<EGENAIBALPJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x22EE150", Offset = "0x22EC950", VA = "0x1822EE150", Slot = "35")]
	public MFKBDIPIOIA<LICJAHLPDHN> EOPNGDCJBNF(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<BAFEGHIGBOE> FJIFOJCFNEO, MFKBDIPIOIA<PACBLAKJPKF> HFNEAMCNOBC)
	{
		return default(MFKBDIPIOIA<LICJAHLPDHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x22F0490", Offset = "0x22EEC90", VA = "0x1822F0490")]
	private BKMGNOHAAAA? JKOBLMBOIDL([In] JOEFEFGKPAB<BAFEGHIGBOE> FJIFOJCFNEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x22EC820", Offset = "0x22EB020", VA = "0x1822EC820")]
	public GLIPNLBBOGL? AGFLPAFCDEI([In] JOEFEFGKPAB<BAFEGHIGBOE> FJIFOJCFNEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x22EC8B0", Offset = "0x22EB0B0", VA = "0x1822EC8B0")]
	public HBOPAPPEAPD? FHBOMAHBOOK([In] JOEFEFGKPAB<JFDGELHFKII> JJFBINJJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x22F1060", Offset = "0x22EF860", VA = "0x1822F1060", Slot = "27")]
	public IEnumerable<NOKNCPBHPLM> LPLGIGIMNMI(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x22ECA90", Offset = "0x22EB290", VA = "0x1822ECA90", Slot = "28")]
	public bool BAHEJPGOIBB(MFKBDIPIOIA<FBCIDBAFOIC> PMLFAFLLCPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x22EEE20", Offset = "0x22ED620", VA = "0x1822EEE20", Slot = "29")]
	public IEnumerable<PMJOPIFDLOG> GICKDGFGAGB(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<LICJAHLPDHN> PAJDGBOEEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x22EC3D0", Offset = "0x22EABD0", VA = "0x1822EC3D0", Slot = "30")]
	public IEnumerable<PMJOPIFDLOG> AABCKCOLLON(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<EGENAIBALPJ> NHHGLDMFOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x22EDD00", Offset = "0x22EC500", VA = "0x1822EDD00")]
	public MFKBDIPIOIA<JFDGELHFKII> KBFLCGIBGFH([In] JOEFEFGKPAB<JFDGELHFKII> JJFBINJJNLK)
	{
		return default(MFKBDIPIOIA<JFDGELHFKII>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x22ECA10", Offset = "0x22EB210", VA = "0x1822ECA10")]
	public MFKBDIPIOIA<JFDGELHFKII>? HPHGJIBINLE([In] JOEFEFGKPAB<JFDGELHFKII> JJFBINJJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x22EED60", Offset = "0x22ED560", VA = "0x1822EED60")]
	private MDLGLPLIMFK? GHGDIBLAOKN([In] JOEFEFGKPAB<JFDGELHFKII> JJFBINJJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x22EC8B0", Offset = "0x22EB0B0", VA = "0x1822EC8B0")]
	private HBOPAPPEAPD? AIFGIEGOHBF([In] JOEFEFGKPAB<JFDGELHFKII> JJFBINJJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x22EEA50", Offset = "0x22ED250", VA = "0x1822EEA50", Slot = "21")]
	public MFKBDIPIOIA<JFDGELHFKII>? GAKELEBDPAH(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<BAFEGHIGBOE> FJIFOJCFNEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x22ED350", Offset = "0x22EBB50", VA = "0x1822ED350", Slot = "39")]
	public JOEFEFGKPAB<JFDGELHFKII> EBLCKNKKKPA(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK)
	{
		return default(JOEFEFGKPAB<JFDGELHFKII>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x22EDD80", Offset = "0x22EC580", VA = "0x1822EDD80", Slot = "36")]
	public IEnumerable<IPLLKAPKLNO> EGPGFGCBCFO(JDLAIPDIFEJ KAHNJPPGMDM, bool HLAADIMLGBO, bool MDCMBFAKCPH, bool DHFFJBGKIJN, bool FIAPKBLEGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x22EE750", Offset = "0x22ECF50", VA = "0x1822EE750", Slot = "37")]
	public IPLLKAPKLNO FOAHILDCGPG(JDLAIPDIFEJ KAHNJPPGMDM, JOAECAAFOOM FIDHBDDLPOP, bool HLAADIMLGBO, bool MDCMBFAKCPH, bool DHFFJBGKIJN, bool FIAPKBLEGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x22ECB20", Offset = "0x22EB320", VA = "0x1822ECB20")]
	public NOKNCPBHPLM BDJPLPBAHMA(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, [In] PMJOPIFDLOG HGKHHHEEPBK)
	{
		return default(NOKNCPBHPLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x22EDE80", Offset = "0x22EC680", VA = "0x1822EDE80", Slot = "40")]
	public PMJOPIFDLOG EIHIOJJGCKO(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<LICJAHLPDHN> PAJDGBOEEGB, MFKBDIPIOIA<EGENAIBALPJ> NHHGLDMFOFN)
	{
		return default(PMJOPIFDLOG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x22EE400", Offset = "0x22ECC00", VA = "0x1822EE400", Slot = "41")]
	[AsyncStateMachine(typeof(EIIKIAMFOBP))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> FCHEALFPECC(MFKBDIPIOIA<JFDGELHFKII> MDJMPIGHKLP, MFKBDIPIOIA<BAFEGHIGBOE> KEAIAJFAMLG, DFACKOPMILK MHPJBPKHONI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x22F11A0", Offset = "0x22EF9A0", VA = "0x1822F11A0", Slot = "42")]
	[AsyncStateMachine(typeof(PIEGCFNEOKP))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> MGEMALBFBEA(MFKBDIPIOIA<JFDGELHFKII> MDJMPIGHKLP, JOEFEFGKPAB<BAFEGHIGBOE> KEAIAJFAMLG, List<MFKBDIPIOIA<BAFEGHIGBOE>> AKNDAKIMFAD, DFACKOPMILK CPHMAGHOMEJ, ADGOFHPALPO JPFCEPAPECF, DFACKOPMILK MHPJBPKHONI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x22EE1E0", Offset = "0x22EC9E0", VA = "0x1822EE1E0", Slot = "43")]
	[AsyncStateMachine(typeof(BIOGFCNLDOL))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> EPFJMELOBPO(MFKBDIPIOIA<JFDGELHFKII> MDJMPIGHKLP, JOEFEFGKPAB<BAFEGHIGBOE> KEAIAJFAMLG, List<MFKBDIPIOIA<BAFEGHIGBOE>> AKNDAKIMFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x22ED1F0", Offset = "0x22EB9F0", VA = "0x1822ED1F0", Slot = "44")]
	[AsyncStateMachine(typeof(PJDLPLKOGMG))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> DONKBDMIBON(MFKBDIPIOIA<JFDGELHFKII> MDJMPIGHKLP, JOEFEFGKPAB<BAFEGHIGBOE> KEAIAJFAMLG, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, List<MFKBDIPIOIA<BAFEGHIGBOE>> AKNDAKIMFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x22F1600", Offset = "0x22EFE00", VA = "0x1822F1600", Slot = "45")]
	public bool NIAKGIFFJCI(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x22EF810", Offset = "0x22EE010", VA = "0x1822EF810", Slot = "46")]
	public bool IFAHAAHNLHJ(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x22F29F0", Offset = "0x22F11F0", VA = "0x1822F29F0", Slot = "47")]
	public bool PMMCCBNIHFD(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<LICJAHLPDHN> FDJOEDBJICL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x22ECC90", Offset = "0x22EB490", VA = "0x1822ECC90")]
	public DNFCNMKAMCE<LPEPBMDCHIC.CMDCOGIPODK, PKCOADCNKKN> IAJAGOGOBNF([In] LPEPBMDCHIC.FBNOPLHHNHO GIOJKAECAOO)
	{
		return default(DNFCNMKAMCE<LPEPBMDCHIC.CMDCOGIPODK, PKCOADCNKKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x22EEC30", Offset = "0x22ED430", VA = "0x1822EEC30", Slot = "49")]
	[AsyncStateMachine(typeof(LJCCCLGMMBO))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> GBLDLGMGAFM(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<LICJAHLPDHN> PAJDGBOEEGB, MFKBDIPIOIA<EGENAIBALPJ> NHHGLDMFOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x22F0790", Offset = "0x22EEF90", VA = "0x1822F0790", Slot = "50")]
	public DNFCNMKAMCE<HIFJACKPPCM, EPICLACHOCO> LFOPEOLGINC(JOEFEFGKPAB<JFDGELHFKII> JJFBINJJNLK, HIFJACKPPCM EBLEPOKPODC, ADGOFHPALPO HCJOCKLOPOP)
	{
		return default(DNFCNMKAMCE<HIFJACKPPCM, EPICLACHOCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x22F05D0", Offset = "0x22EEDD0", VA = "0x1822F05D0", Slot = "51")]
	[AsyncStateMachine(typeof(GEKMNOAIFDH))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> KKJFCGEAAIK(JOEFEFGKPAB<JFDGELHFKII> JJFBINJJNLK, JOEFEFGKPAB<BAFEGHIGBOE> HLJLFMAPENH, MFKBDIPIOIA<NONADBDKHEF> FLCFIMBEKPI, MFKBDIPIOIA<MKADPEDLCGB> OHFAFGCBLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x22F02D0", Offset = "0x22EEAD0", VA = "0x1822F02D0", Slot = "52")]
	[AsyncStateMachine(typeof(BOAEGCFMALE))]
	public Task<DNFCNMKAMCE<DOPPLCFNMND, OOJAGAFOLJL>> JAGCGAHALMP(JOEFEFGKPAB<JFDGELHFKII> JJFBINJJNLK, JOEFEFGKPAB<BAFEGHIGBOE> IHNNKJHOBIN, MFKBDIPIOIA<NONADBDKHEF> OLMPDPEDBDK, MFKBDIPIOIA<EGPAIJNGCOJ> FDJOEDBJICL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x22F1760", Offset = "0x22EFF60", VA = "0x1822F1760", Slot = "53")]
	public OGCCPFICJOI OGBBFGKEJMG()
	{
		return default(OGCCPFICJOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x22F1320", Offset = "0x22EFB20", VA = "0x1822F1320", Slot = "54")]
	public OGCCPFICJOI MGHKEEFPMGD()
	{
		return default(OGCCPFICJOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x22ED650", Offset = "0x22EBE50", VA = "0x1822ED650")]
	private JOMPLHMMNCG EBPLLDLBDGC(JJLHMKLCHPL KOKCBHFCCNM, MFKBDIPIOIA<JFDGELHFKII> BBIEJEFKCIE, IEnumerable<JOEFEFGKPAB<JFDGELHFKII>> ILKIKBEJMDI, IEnumerable<JOEFEFGKPAB<BAFEGHIGBOE>> AKNDAKIMFAD)
	{
		return default(JOMPLHMMNCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x22ED3C0", Offset = "0x22EBBC0", VA = "0x1822ED3C0", Slot = "55")]
	public JOMPLHMMNCG EBPLLDLBDGC(JJLHMKLCHPL KOKCBHFCCNM, MFKBDIPIOIA<JFDGELHFKII> BBIEJEFKCIE, IEnumerable<JOEFEFGKPAB<BAFEGHIGBOE>> AKNDAKIMFAD, IEnumerable<MAAAODAGNHE> CFLNIEPCKCH)
	{
		return default(JOMPLHMMNCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x22EF0A0", Offset = "0x22ED8A0", VA = "0x1822EF0A0")]
	private static IEnumerable<JOEFEFGKPAB<JFDGELHFKII>> GONJIAHFBDM(IEnumerable<MAAAODAGNHE> CFLNIEPCKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x22F0BE0", Offset = "0x22EF3E0", VA = "0x1822F0BE0")]
	private IEnumerable<JOEFEFGKPAB<BAFEGHIGBOE>> LNFNFAAIGCJ(IEnumerable<MAAAODAGNHE> CFLNIEPCKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x22F0540", Offset = "0x22EED40", VA = "0x1822F0540", Slot = "56")]
	public List<FCCJIJJOOEO> JLOKGEDKACK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x22F1880", Offset = "0x22F0080", VA = "0x1822F1880")]
	public (List<FCCJIJJOOEO>, bool) OPEDILIOAPO([In] IALJJIACPNH EKEMADCBHHF, string IKGPEBFFMPK, [In] DHCDPFIGGBN BLMLHOIGCEA, DAGJBMGPJJH FDIIFBNOAHP, DLHLLGCHHJJ NEKANMHHBNP)
	{
		return default((List<FCCJIJJOOEO>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x22F1670", Offset = "0x22EFE70", VA = "0x1822F1670", Slot = "58")]
	public bool NLEEJNECOJH(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x22ECE30", Offset = "0x22EB630", VA = "0x1822ECE30")]
	internal void CLKNEPFFHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x22F1FC0", Offset = "0x22F07C0", VA = "0x1822F1FC0")]
	internal Task PKIOKFDPEEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x22EF900", Offset = "0x22EE100", VA = "0x1822EF900", Slot = "59")]
	public DNFCNMKAMCE<MFKBDIPIOIA<LICJAHLPDHN>?, OOJAGAFOLJL> IPDINGAHFHP(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<BAFEGHIGBOE> FJIFOJCFNEO, MFKBDIPIOIA<EGENAIBALPJ> OHFAFGCBLBF)
	{
		return default(DNFCNMKAMCE<MFKBDIPIOIA<LICJAHLPDHN>?, OOJAGAFOLJL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x22F2020", Offset = "0x22F0820", VA = "0x1822F2020", Slot = "60")]
	public DNFCNMKAMCE<MFKBDIPIOIA<EGENAIBALPJ>?, OOJAGAFOLJL> PKOFBLLLDKI(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<BAFEGHIGBOE> FJIFOJCFNEO, MFKBDIPIOIA<LICJAHLPDHN> FDJOEDBJICL)
	{
		return default(DNFCNMKAMCE<MFKBDIPIOIA<EGENAIBALPJ>?, OOJAGAFOLJL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x22EC980", Offset = "0x22EB180", VA = "0x1822EC980", Slot = "7")]
	private bool AIKHNEHIAMC(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, [In] PMJOPIFDLOG HGKHHHEEPBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x22EE0B0", Offset = "0x22EC8B0", VA = "0x1822EE0B0", Slot = "18")]
	private HBOPAPPEAPD EMBOPMNDFNE([In] JOEFEFGKPAB<JFDGELHFKII> JJFBINJJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x22EDD00", Offset = "0x22EC500", VA = "0x1822EDD00", Slot = "19")]
	private MFKBDIPIOIA<JFDGELHFKII> EDENPDKFBIG([In] JOEFEFGKPAB<JFDGELHFKII> JJFBINJJNLK)
	{
		return default(MFKBDIPIOIA<JFDGELHFKII>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x22ECA10", Offset = "0x22EB210", VA = "0x1822ECA10", Slot = "20")]
	private MFKBDIPIOIA<JFDGELHFKII>? APIDPGMPIEF([In] JOEFEFGKPAB<JFDGELHFKII> JJFBINJJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x22EC6D0", Offset = "0x22EAED0", VA = "0x1822EC6D0", Slot = "22")]
	private BKMGNOHAAAA AFJPHNCMIMO([In] JOEFEFGKPAB<BAFEGHIGBOE> FJIFOJCFNEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x22ED040", Offset = "0x22EB840", VA = "0x1822ED040", Slot = "24")]
	private MFKBDIPIOIA<BAFEGHIGBOE> FIJJAAEAMNH(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, [In] JOEFEFGKPAB<BAFEGHIGBOE> LBLNODLNPIJ)
	{
		return default(MFKBDIPIOIA<BAFEGHIGBOE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x22ECB20", Offset = "0x22EB320", VA = "0x1822ECB20", Slot = "38")]
	private NOKNCPBHPLM DPMDFAHAAFO(MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, [In] PMJOPIFDLOG HGKHHHEEPBK)
	{
		return default(NOKNCPBHPLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x22ECC90", Offset = "0x22EB490", VA = "0x1822ECC90", Slot = "48")]
	private DNFCNMKAMCE<LPEPBMDCHIC.CMDCOGIPODK, PKCOADCNKKN> CAPGIJHLDIG([In] LPEPBMDCHIC.FBNOPLHHNHO GIOJKAECAOO)
	{
		return default(DNFCNMKAMCE<LPEPBMDCHIC.CMDCOGIPODK, PKCOADCNKKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x22F0730", Offset = "0x22EEF30", VA = "0x1822F0730", Slot = "57")]
	private (List<FCCJIJJOOEO>, bool) LAMNKKOJDOA([In] IALJJIACPNH EKEMADCBHHF, string IKGPEBFFMPK, [In] DHCDPFIGGBN BLMLHOIGCEA, DAGJBMGPJJH FDIIFBNOAHP, DLHLLGCHHJJ NEKANMHHBNP)
	{
		return default((List<FCCJIJJOOEO>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x22F1F40", Offset = "0x22F0740", VA = "0x1822F1F40")]
	[CompilerGenerated]
	private JLBAPCPCJJE PCHFHHOKLDJ(CAHPCBPNPAB KKPBEBNOEKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x22EF890", Offset = "0x22EE090", VA = "0x1822EF890")]
	[CompilerGenerated]
	private GLIPNLBBOGL IGHKAGKNNNE(JOEFEFGKPAB<BAFEGHIGBOE> KKPBEBNOEKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x22EE390", Offset = "0x22ECB90", VA = "0x1822EE390")]
	[CompilerGenerated]
	private MDLGLPLIMFK EPGMKALBHAK(JOEFEFGKPAB<JFDGELHFKII> KKPBEBNOEKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class JLBAPCPCJJE : IPLLKAPKLNO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct NNKAPNAPIKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<MFKBDIPIOIA<JPEJPKEPEEM>, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public JLBAPCPCJJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public JOEFEFGKPAB<JFDGELHFKII> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public JOEFEFGKPAB<BAFEGHIGBOE> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public MFKBDIPIOIA<NONADBDKHEF> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private TaskAwaiter<DNFCNMKAMCE<MFKBDIPIOIA<JPEJPKEPEEM>, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x230D250", Offset = "0x230BA50", VA = "0x18230D250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x230D4D0", Offset = "0x230BCD0", VA = "0x18230D4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private struct CIEJBEKFLPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<MFKBDIPIOIA<EGNAIHIHHIJ>, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public JLBAPCPCJJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public JOEFEFGKPAB<JFDGELHFKII> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public JOEFEFGKPAB<BAFEGHIGBOE> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public MFKBDIPIOIA<NONADBDKHEF> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private TaskAwaiter<DNFCNMKAMCE<MFKBDIPIOIA<EGNAIHIHHIJ>, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x2307550", Offset = "0x2305D50", VA = "0x182307550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x23077D0", Offset = "0x2305FD0", VA = "0x1823077D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private readonly CAHPCBPNPAB CEEBHNGINMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private readonly JBMLOFKPLDF CCCEGPCCDJG;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public TypeKey BFLHJLMHFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x958980", Offset = "0x957180", VA = "0x180958980", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public string KNKPBMCJFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x2308D60", Offset = "0x2307560", VA = "0x182308D60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public CAHPCBPNPAB CLDJLMDKJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x2309070", Offset = "0x2307870", VA = "0x182309070")]
	public JLBAPCPCJJE(CAHPCBPNPAB CAANMADLGDO, JBMLOFKPLDF OOGOGIAGFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2308D90", Offset = "0x2307590", VA = "0x182308D90", Slot = "6")]
	[AsyncStateMachine(typeof(NNKAPNAPIKB))]
	public Task<DNFCNMKAMCE<MFKBDIPIOIA<JPEJPKEPEEM>, OOJAGAFOLJL>> NJJNBLJJFOF(JOEFEFGKPAB<JFDGELHFKII> JJFBINJJNLK, JOEFEFGKPAB<BAFEGHIGBOE> FJIFOJCFNEO, MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, string IKMKCMDHFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2308F00", Offset = "0x2307700", VA = "0x182308F00", Slot = "7")]
	[AsyncStateMachine(typeof(CIEJBEKFLPB))]
	public Task<DNFCNMKAMCE<MFKBDIPIOIA<EGNAIHIHHIJ>, OOJAGAFOLJL>> OJPICKNFFEF(JOEFEFGKPAB<JFDGELHFKII> JJFBINJJNLK, JOEFEFGKPAB<BAFEGHIGBOE> FJIFOJCFNEO, MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB, string IKMKCMDHFDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class MMOHCJCBBKK : FNIKEFPMCEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private readonly CAHPCBPNPAB IHHCJAPPENJ;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private static readonly HashSet<CAHPCBPNPAB> FBKAFANIEMG;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private static readonly HashSet<CAHPCBPNPAB> KJDFMMEBPPE;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private static readonly HashSet<CAHPCBPNPAB> DLLFJAKEFFI;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public TypeKey GCHHHJJPOEP
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x230D080", Offset = "0x230B880", VA = "0x18230D080", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool LFHBKCGHOBF
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x230D070", Offset = "0x230B870", VA = "0x18230D070", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool EGBOFGIHFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x230D0D0", Offset = "0x230B8D0", VA = "0x18230D0D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool IIKJNBEMPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x230CFF0", Offset = "0x230B7F0", VA = "0x18230CFF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x230BAC0", Offset = "0x230A2C0", VA = "0x18230BAC0")]
	public bool CEDCPJIKNPD(string INDENPJBLHO, [Out] MEDFEENODHC MEHKNHBGIGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	public MMOHCJCBBKK(CAHPCBPNPAB CLCEHBDJMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x230BD30", Offset = "0x230A530", VA = "0x18230BD30")]
	internal static TypeKey OAHAAHIFGKH(CAHPCBPNPAB OCLAPBNMMGE)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2308D60", Offset = "0x2307560", VA = "0x182308D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public readonly struct AEBLCBNHOOK : HMGJAKFBCCP.OAHBIAIIOPM<MKGNMHKEPFM, DOPPLCFNMND>
{
	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2306A90", Offset = "0x2305290", VA = "0x182306A90", Slot = "4")]
	public int PBCJFEHMDDE(DOPPLCFNMND FNGOEBINDAF, MKGNMHKEPFM ILIPDNLABEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2306A40", Offset = "0x2305240", VA = "0x182306A40", Slot = "5")]
	public MKGNMHKEPFM IEBILHOIDAP(DOPPLCFNMND FNGOEBINDAF, MKGNMHKEPFM ILIPDNLABEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x23069C0", Offset = "0x23051C0", VA = "0x1823069C0", Slot = "6")]
	public MKGNMHKEPFM DMHHLKGLAHH(DOPPLCFNMND FNGOEBINDAF, MKGNMHKEPFM ILIPDNLABEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2306A50", Offset = "0x2305250", VA = "0x182306A50", Slot = "7")]
	public IReadOnlyList<MKGNMHKEPFM> IKEEEDBPEOG(DOPPLCFNMND FNGOEBINDAF, MKGNMHKEPFM ILIPDNLABEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2306A30", Offset = "0x2305230", VA = "0x182306A30", Slot = "8")]
	public MKGNMHKEPFM[] GNHIFANCNDB(DOPPLCFNMND FNGOEBINDAF, MKGNMHKEPFM ILIPDNLABEN, int LEABBFJELNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2306AB0", Offset = "0x23052B0", VA = "0x182306AB0", Slot = "9")]
	public bool PCDGAINPHJM(DOPPLCFNMND FNGOEBINDAF, MKGNMHKEPFM ILIPDNLABEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2306A70", Offset = "0x2305270", VA = "0x182306A70", Slot = "10")]
	public bool MDEOHLLIKIA(DOPPLCFNMND FNGOEBINDAF, MKGNMHKEPFM ILIPDNLABEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2306A10", Offset = "0x2305210", VA = "0x182306A10", Slot = "11")]
	public bool GCEINLGNIFG(DOPPLCFNMND FNGOEBINDAF, MKGNMHKEPFM ILIPDNLABEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x23069A0", Offset = "0x23051A0", VA = "0x1823069A0", Slot = "12")]
	public bool AKNOIHLAOCA(DOPPLCFNMND FNGOEBINDAF, MKGNMHKEPFM ILIPDNLABEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x23069F0", Offset = "0x23051F0", VA = "0x1823069F0", Slot = "13")]
	public bool EMDHPDOMPLC(DOPPLCFNMND GOKCLKGFJEB, MKGNMHKEPFM ILIPDNLABEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2306980", Offset = "0x2305180", VA = "0x182306980", Slot = "14")]
	public bool ABLEHPKPAFL(DOPPLCFNMND FNGOEBINDAF, MKGNMHKEPFM ILIPDNLABEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public abstract class MIALNENAGCI : EBNJEGNJANJ
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public FLIJEIJPGJF.AODLKIGACEJ OBMJJFECLHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x230BA20", Offset = "0x230A220", VA = "0x18230BA20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract FFGMDCHKNFM.AOIOPLJEMJE GIPNLEMEPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract AOMCPFNEFFD.KMPMGGHPJPF MCAGKFFIAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract FCKNIGOELJC.OPACNDIGFBE FIEIDJPBIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public NIHBHKNCMKD.CAFEHNEHCJD<OFICMPDEKDE, MKGNMHKEPFM, AOMCPFNEFFD> BNACODNHLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x230BA70", Offset = "0x230A270", VA = "0x18230BA70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract OMMGKJLDNMP IEEEAOOLCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract AJABLLLEEDI LBFCKOAFMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract HHEMAKBOGAO HDEAKFODONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract CBMFHDHLKFF INEHFOHFOCC
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract KAJAMMHOPCI DKCMBPKNKMA
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	protected MIALNENAGCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class JMBDBAGEKNF : IAHAAKODMND
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct FLPDAJLLDCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<object, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public JMBDBAGEKNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public MKGNMHKEPFM action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private TaskAwaiter<DNFCNMKAMCE<object, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2307AF0", Offset = "0x23062F0", VA = "0x182307AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2307D90", Offset = "0x2306590", VA = "0x182307D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private struct ODICDMJAFDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<GJKMPOLHKIA, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public JMBDBAGEKNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public IReadOnlyList<MKGNMHKEPFM> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private TaskAwaiter<DNFCNMKAMCE<object, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x230D540", Offset = "0x230BD40", VA = "0x18230D540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x230D8C0", Offset = "0x230C0C0", VA = "0x18230D8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private readonly GFPBIJPMNFJ AOPJDLKOAGN;

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	public JMBDBAGEKNF(GFPBIJPMNFJ CMECFNDONCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x2309240", Offset = "0x2307A40", VA = "0x182309240")]
	[AsyncStateMachine(typeof(FLPDAJLLDCG))]
	private Task<DNFCNMKAMCE<object, OOJAGAFOLJL>> BPOCLEJAMHG(MKGNMHKEPFM ILIPDNLABEN, bool MLCJJOIGOGP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x2309110", Offset = "0x2307910", VA = "0x182309110", Slot = "4")]
	[AsyncStateMachine(typeof(ODICDMJAFDN))]
	public Task<DNFCNMKAMCE<GJKMPOLHKIA, OOJAGAFOLJL>> AMPKFONIHAL(IReadOnlyList<MKGNMHKEPFM> GLAHDKCHLDI, bool MLCJJOIGOGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public struct PIOMPJCOGMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	internal INMOCHECCOK<JOGNGLJKLNK, JOEFEFGKPAB<JOGNGLJKLNK.ODGGCDDLHFF>, MKGNMHKEPFM, ANNFEIGLFBI> IHHCJAPPENJ;

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x22CBA20", Offset = "0x22CA220", VA = "0x1822CBA20")]
	private PIOMPJCOGMM([In] INMOCHECCOK<JOGNGLJKLNK, JOEFEFGKPAB<JOGNGLJKLNK.ODGGCDDLHFF>, MKGNMHKEPFM, ANNFEIGLFBI> PFBADPNANPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x230DC60", Offset = "0x230C460", VA = "0x18230DC60")]
	public static PIOMPJCOGMM DFLBOLBHLFN()
	{
		return default(PIOMPJCOGMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public static class BOIEOILKOFH
{
	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	public static INMOCHECCOK<JOGNGLJKLNK, JOEFEFGKPAB<JOGNGLJKLNK.ODGGCDDLHFF>, MKGNMHKEPFM, ANNFEIGLFBI> LJCCBPCEAAB(this PIOMPJCOGMM EGGDEECAALI)
	{
		return default(INMOCHECCOK<JOGNGLJKLNK, JOEFEFGKPAB<JOGNGLJKLNK.ODGGCDDLHFF>, MKGNMHKEPFM, ANNFEIGLFBI>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public struct ANNFEIGLFBI : ECFNKOLLPMP.MHLBFGNDICP<JOGNGLJKLNK, JOEFEFGKPAB<JOGNGLJKLNK.ODGGCDDLHFF>, MKGNMHKEPFM>
{
	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x2306AE0", Offset = "0x23052E0", VA = "0x182306AE0", Slot = "7")]
	public MKGNMHKEPFM LDHENEGCEEA(JOGNGLJKLNK[] MDPOKABKNMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0xE23180", Offset = "0xE21980", VA = "0x180E23180")]
	public JOEFEFGKPAB<JOGNGLJKLNK.ODGGCDDLHFF> JNMGDPOKCFJ([In] JOGNGLJKLNK GOEKBEEIPHM)
	{
		return default(JOEFEFGKPAB<JOGNGLJKLNK.ODGGCDDLHFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0xC84010", Offset = "0xC82810", VA = "0x180C84010")]
	public int LHANHNHIFCO([In] JOGNGLJKLNK EEGFKLHFIOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x2306AD0", Offset = "0x23052D0", VA = "0x182306AD0")]
	public int ECOCJDLMKOO([In] JOGNGLJKLNK GOEKBEEIPHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0xC84010", Offset = "0xC82810", VA = "0x180C84010", Slot = "4")]
	private int NBMDNGOGADA([In] JOGNGLJKLNK GOEKBEEIPHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x2306AD0", Offset = "0x23052D0", VA = "0x182306AD0", Slot = "5")]
	private int HGOPCOMGKPD([In] JOGNGLJKLNK GOEKBEEIPHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0xE23180", Offset = "0xE21980", VA = "0x180E23180", Slot = "6")]
	private JOEFEFGKPAB<JOGNGLJKLNK.ODGGCDDLHFF> DIAFABEECFM([In] JOGNGLJKLNK GOEKBEEIPHM)
	{
		return default(JOEFEFGKPAB<JOGNGLJKLNK.ODGGCDDLHFF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public struct NEKOMOOGNFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	internal BFJHFNFEEAD<ABEKDIHNEJC, MKGNMHKEPFM, KAALNOLOMMK> IHHCJAPPENJ;

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x22CBA20", Offset = "0x22CA220", VA = "0x1822CBA20")]
	private NEKOMOOGNFE([In] BFJHFNFEEAD<ABEKDIHNEJC, MKGNMHKEPFM, KAALNOLOMMK> IOPBCEBKKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x230D1F0", Offset = "0x230B9F0", VA = "0x18230D1F0")]
	public static NEKOMOOGNFE DFLBOLBHLFN()
	{
		return default(NEKOMOOGNFE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public static class CPKCKKKMCIG
{
	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	public static BFJHFNFEEAD<ABEKDIHNEJC, MKGNMHKEPFM, KAALNOLOMMK> LJCCBPCEAAB(this NEKOMOOGNFE EGGDEECAALI)
	{
		return default(BFJHFNFEEAD<ABEKDIHNEJC, MKGNMHKEPFM, KAALNOLOMMK>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public struct KAALNOLOMMK : JDCHCCIAKEJ.CBNAAHDLABH<ABEKDIHNEJC, MKGNMHKEPFM>
{
	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x1B39820", Offset = "0x1B38020", VA = "0x181B39820")]
	public int FDIHAGFGMEE([In] ABEKDIHNEJC EEGFKLHFIOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x2309370", Offset = "0x2307B70", VA = "0x182309370", Slot = "5")]
	public MKGNMHKEPFM LIEMHMNLDJG(ABEKDIHNEJC[] MJNMHGBFELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x1B39820", Offset = "0x1B38020", VA = "0x181B39820", Slot = "4")]
	private int NFGHBHKEJGL([In] ABEKDIHNEJC EEGFKLHFIOO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class GEOAEGHHICB : LHIOHJOJEEI, PKCOADCNKKN, OOJAGAFOLJL, EPICLACHOCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private readonly EPICLACHOCO? LDPMBOBJINJ;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public OMBHBCPAEKD IGPNDDGNGNA
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC040", Offset = "0x8BA840", VA = "0x1808BC040", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(OMBHBCPAEKD);
		}
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x8C38D0", Offset = "0x8C20D0", VA = "0x1808C38D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public override EPICLACHOCO? ECLNMKGKLBK
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x2308230", Offset = "0x2306A30", VA = "0x182308230", Slot = "7")]
	public override string DHOBPLNCIMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x2308420", Offset = "0x2306C20", VA = "0x182308420")]
	private GEOAEGHHICB(OMBHBCPAEKD NNGPPKEHFMP, EPICLACHOCO? HFBKFOGPOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x23081B0", Offset = "0x23069B0", VA = "0x1823081B0")]
	public static GEOAEGHHICB CDGAHJMOPCN(EPICLACHOCO HFBKFOGPOGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x23083B0", Offset = "0x2306BB0", VA = "0x1823083B0")]
	public static GEOAEGHHICB MNMPJDHLADL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x2308340", Offset = "0x2306B40", VA = "0x182308340")]
	public static GEOAEGHHICB MKEPPNIBNDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public static class EAJNNJENGGH
{
	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x2EC09D0", Offset = "0x2EBF1D0", VA = "0x182EC09D0")]
	public static DNFCNMKAMCE<TOk, PKCOADCNKKN> BFHKHIOAEHD<TOk>([In] this DNFCNMKAMCE<TOk, PKCOADCNKKN> EGGDEECAALI, EPICLACHOCO HFBKFOGPOGA) where TOk : notnull
	{
		return default(DNFCNMKAMCE<TOk, PKCOADCNKKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x2EC0AC0", Offset = "0x2EBF2C0", VA = "0x182EC0AC0")]
	public static DNFCNMKAMCE<TOk?, PKCOADCNKKN?> BHKNGJBOKOK<TOk>([In] this DNFCNMKAMCE<TOk, PKCOADCNKKN> EGGDEECAALI)
	{
		return default(DNFCNMKAMCE<TOk, PKCOADCNKKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x2EC0BB0", Offset = "0x2EBF3B0", VA = "0x182EC0BB0")]
	public static DNFCNMKAMCE<TOk?, PKCOADCNKKN?> MMKJJBMMEAJ<TOk>([In] this DNFCNMKAMCE<TOk, PKCOADCNKKN> EGGDEECAALI)
	{
		return default(DNFCNMKAMCE<TOk, PKCOADCNKKN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public interface OMMGKJLDNMP
{
	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CCLHAMLPBFJ([In] DNFCNMKAMCE<DOPPLCFNMND, EPICLACHOCO> HANDIANDCDI);
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public static class HPNLNMKLHAL
{
	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x308FEF0", Offset = "0x308E6F0", VA = "0x18308FEF0")]
	public static bool CCLHAMLPBFJ<TOk, TErr>(this OMMGKJLDNMP EGGDEECAALI, [In] DNFCNMKAMCE<TOk, TErr> HANDIANDCDI) where TOk : notnull where TErr : notnull, EPICLACHOCO
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public interface AJABLLLEEDI
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	LJGMJAHBPLG AMKDGEEOIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public interface HHEMAKBOGAO
{
	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KCHMMKLCIDB CEJCANELCEC(int EIFINMPPANI);
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public interface AOEBNKBJKDF
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string AEHPFKGBHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface IFBEFDBABLD
{
	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FMABNIBBBAB? BIOOCPEOGBL(MFKBDIPIOIA<NONADBDKHEF> NFGEIOCEOOB);
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface JNAABJBMDEH
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	string AEHPFKGBHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface FMABNIBBBAB
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string AEHPFKGBHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JNAABJBMDEH? HIFJBMBJDNM(MFKBDIPIOIA<JPEJPKEPEEM> MPMKNHFAGIC);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AOEBNKBJKDF? PFNPJGJIHFM(MFKBDIPIOIA<EGNAIHIHHIJ> HCNLJDIECEE);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface CBMFHDHLKFF
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> PECBCPOPJKN(string INDENPJBLHO, string IKGPEBFFMPK);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface KAJAMMHOPCI
{
	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IFBEFDBABLD? FMFIPHFJGPL([In] JOEFEFGKPAB<MGGNKFDEDIG> LGBJABNNGLL);
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class GKJEIPPFJBC
{
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private struct BJOMFOOEHJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public int MBLPHBBBBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public KMEGMNNEBLN? LELCHBBKCMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public KMEGMNNEBLN? EHGBPNLHAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public readonly List<MKGNMHKEPFM> NOBPFPOGCBE;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x2307060", Offset = "0x2305860", VA = "0x182307060")]
		private BJOMFOOEHJP(int ECDOOAABOPD, KMEGMNNEBLN? EHGHALLEJAB, KMEGMNNEBLN? KGJHNANILJI, List<MKGNMHKEPFM> GLAHDKCHLDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x2306FA0", Offset = "0x23057A0", VA = "0x182306FA0")]
		public static BJOMFOOEHJP DFLBOLBHLFN()
		{
			return default(BJOMFOOEHJP);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private readonly LKMDLGFLOGC<BJOMFOOEHJP> GBLHCDAEBDJ;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public static GKJEIPPFJBC ODDIIHPHFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x2308820", Offset = "0x2307020", VA = "0x182308820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool NEMAIJDKFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x95C5D0", Offset = "0x95ADD0", VA = "0x18095C5D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x95C5F0", Offset = "0x95ADF0", VA = "0x18095C5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x2308760", Offset = "0x2306F60", VA = "0x182308760")]
	public void EFBDDPNKBAH(KIOKJOJHBCJ KGJHNANILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2308460", Offset = "0x2306C60", VA = "0x182308460")]
	public void CINCPMFHKAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x2308870", Offset = "0x2307070", VA = "0x182308870")]
	private static string? PJCLDHFAJFO([In] BJOMFOOEHJP OFCCHANBCEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x2308CB0", Offset = "0x23074B0", VA = "0x182308CB0")]
	public GKJEIPPFJBC()
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
