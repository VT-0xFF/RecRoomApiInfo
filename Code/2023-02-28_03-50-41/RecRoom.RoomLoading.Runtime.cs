using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Google.Protobuf;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Mono.Math;
using RecNet;
using RecRoom.NoEngine.Common;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.SceneManagement;
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
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2E42590", Offset = "0x2E40F90", VA = "0x182E42590")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6F0", Offset = "0x6DB0F0", VA = "0x1806DC6F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x90B660", Offset = "0x90A060", VA = "0x18090B660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CFJIIDIGKFE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x280CBA0", Offset = "0x280B5A0", VA = "0x18280CBA0")]
	public CFJIIDIGKFE(string EJEIJOMMNGK, Exception ELDKAOAIPEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class FEGMEJFNFJF : GBBJAOHMJHJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct ELMALMNKAGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<GEANGCAJNPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private TaskAwaiter<global::DJIHODNIJBG<GEANGCAJNPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x35721A0", Offset = "0x3570BA0", VA = "0x1835721A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3572380", Offset = "0x3570D80", VA = "0x183572380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct AKJBLOGGDBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<PLBBCNAGCNA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<PLBBCNAGCNA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x356D190", Offset = "0x356BB90", VA = "0x18356D190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x356D350", Offset = "0x356BD50", VA = "0x18356D350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	[UnityEngine.Scripting.Preserve]
	public FEGMEJFNFJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x281A010", Offset = "0x2818A10", VA = "0x18281A010", Slot = "4")]
	[AsyncStateMachine(typeof(ELMALMNKAGP))]
	public Task<IReadOnlyList<GEANGCAJNPB>> HJEEGMGMEMM(long ANAJKMBCHFB, long DJFDGMPNMLL, [Optional] CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x281A160", Offset = "0x2818B60", VA = "0x18281A160", Slot = "5")]
	[AsyncStateMachine(typeof(AKJBLOGGDBL))]
	public Task<IReadOnlyList<PLBBCNAGCNA>> JMMFJEFPEIJ(IReadOnlyList<int> IOFELDIKOJP, [Optional] CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DDLMIMOKCGH : IEquatable<DDLMIMOKCGH>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int HMEPIHNLLEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	PLBBCNAGCNA IHHPGMGEFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime BANPLJONNDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KNAEOEOHMIL? GOHJNNJLFFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KJBDBPPPEPG? DBEAPBKHOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	POJHIHGPMOK NBEFILFBAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<MPFEOFKMCLF> POIBBHNKAPL();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum POJHIHGPMOK
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GBBJAOHMJHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<GEANGCAJNPB>> HJEEGMGMEMM(long ANAJKMBCHFB, long DJFDGMPNMLL, [Optional] CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<PLBBCNAGCNA>> JMMFJEFPEIJ(IReadOnlyList<int> IOFELDIKOJP, [Optional] CancellationToken KAKEKEHNCME);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LNCBJOJEKMF
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class NLMFNDLPJKF : DDLMIMOKCGH, IEquatable<DDLMIMOKCGH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct JDFFMPHFFNI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<MPFEOFKMCLF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public NLMFNDLPJKF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private OBIAGMHMIFG <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<BIHOLPOPBIG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<MPFEOFKMCLF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4080220", Offset = "0x407EC20", VA = "0x184080220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x40806B0", Offset = "0x407F0B0", VA = "0x1840806B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly GEANGCAJNPB DPBDKJAMJNP;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int HMEPIHNLLEB
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6C2BD0", Offset = "0x6C15D0", VA = "0x1806C2BD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PLBBCNAGCNA IHHPGMGEFJD
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime HEPLFAIMHJE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x11B52D0", Offset = "0x11B3CD0", VA = "0x1811B52D0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KNAEOEOHMIL? GOHJNNJLFFK
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x898D20", Offset = "0x897720", VA = "0x180898D20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public KJBDBPPPEPG? DBEAPBKHOCG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x898CE0", Offset = "0x8976E0", VA = "0x180898CE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public POJHIHGPMOK NBEFILFBAEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6E7AA0", Offset = "0x6E64A0", VA = "0x1806E7AA0", Slot = "10")]
			get
			{
				return default(POJHIHGPMOK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x357FDC0", Offset = "0x357E7C0", VA = "0x18357FDC0", Slot = "9")]
		[AsyncStateMachine(typeof(JDFFMPHFFNI))]
		public Task<MPFEOFKMCLF> POIBBHNKAPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x357FEF0", Offset = "0x357E8F0", VA = "0x18357FEF0")]
		public NLMFNDLPJKF(int PHOHDAOEABL, PLBBCNAGCNA GLJNEFDOCHB, GEANGCAJNPB DPBDKJAMJNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x357FCA0", Offset = "0x357E6A0", VA = "0x18357FCA0", Slot = "11")]
		public bool Equals(DDLMIMOKCGH DFHJPOKNFFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x357FC00", Offset = "0x357E600", VA = "0x18357FC00", Slot = "0")]
		public override bool Equals(object LAFPICAOEAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x357FBC0", Offset = "0x357E5C0", VA = "0x18357FBC0")]
		private bool AMEIEJBLFGK(NLMFNDLPJKF DFHJPOKNFFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x357FD30", Offset = "0x357E730", VA = "0x18357FD30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class JCGKDNFMDLG : DDLMIMOKCGH, IEquatable<DDLMIMOKCGH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct FBLIGEDDIPB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<MPFEOFKMCLF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public JCGKDNFMDLG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<MPFEOFKMCLF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x407C200", Offset = "0x407AC00", VA = "0x18407C200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x407C440", Offset = "0x407AE40", VA = "0x18407C440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly BMIHFLGADPJ BNCADGBAPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly KNAEOEOHMIL PPNBPGEPBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly KJBDBPPPEPG GMFHAOCKINH;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int HMEPIHNLLEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x35772F0", Offset = "0x3575CF0", VA = "0x1835772F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public PLBBCNAGCNA IHHPGMGEFJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3576FD0", Offset = "0x35759D0", VA = "0x183576FD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime HEPLFAIMHJE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x3577250", Offset = "0x3575C50", VA = "0x183577250", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public KNAEOEOHMIL? GOHJNNJLFFK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x35772A0", Offset = "0x3575CA0", VA = "0x1835772A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public KJBDBPPPEPG? DBEAPBKHOCG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x3577340", Offset = "0x3575D40", VA = "0x183577340", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public POJHIHGPMOK NBEFILFBAEE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6DC2A0", Offset = "0x6DACA0", VA = "0x1806DC2A0", Slot = "10")]
			get
			{
				return default(POJHIHGPMOK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x766D10", Offset = "0x765710", VA = "0x180766D10")]
		public JCGKDNFMDLG(BMIHFLGADPJ CJMCLFOEGKH, KNAEOEOHMIL HMIPANHGDAD, KJBDBPPPEPG BNDPGLIHNPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3577390", Offset = "0x3575D90", VA = "0x183577390", Slot = "9")]
		[AsyncStateMachine(typeof(FBLIGEDDIPB))]
		public Task<MPFEOFKMCLF> POIBBHNKAPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3577070", Offset = "0x3575A70", VA = "0x183577070", Slot = "11")]
		public bool Equals(DDLMIMOKCGH DFHJPOKNFFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3577110", Offset = "0x3575B10", VA = "0x183577110", Slot = "0")]
		public override bool Equals(object LAFPICAOEAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3576F70", Offset = "0x3575970", VA = "0x183576F70")]
		private bool AMEIEJBLFGK(JCGKDNFMDLG DFHJPOKNFFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x35771C0", Offset = "0x3575BC0", VA = "0x1835771C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class EKEOGHICJEM : DDLMIMOKCGH, IEquatable<DDLMIMOKCGH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct CKNMJNECBMM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<MPFEOFKMCLF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<MPFEOFKMCLF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4079FD0", Offset = "0x40789D0", VA = "0x184079FD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x407A1B0", Offset = "0x4078BB0", VA = "0x18407A1B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly PLBBCNAGCNA JCJGJBGLAGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly KNAEOEOHMIL PPNBPGEPBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly KJBDBPPPEPG GMFHAOCKINH;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int HMEPIHNLLEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x3571D10", Offset = "0x3570710", VA = "0x183571D10", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public PLBBCNAGCNA IHHPGMGEFJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime HEPLFAIMHJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public KNAEOEOHMIL? GOHJNNJLFFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x3571CC0", Offset = "0x35706C0", VA = "0x183571CC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public KJBDBPPPEPG? DBEAPBKHOCG
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x3571D90", Offset = "0x3570790", VA = "0x183571D90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public POJHIHGPMOK NBEFILFBAEE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "10")]
			get
			{
				return default(POJHIHGPMOK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x766D10", Offset = "0x765710", VA = "0x180766D10")]
		public EKEOGHICJEM(PLBBCNAGCNA GLJNEFDOCHB, KNAEOEOHMIL HMIPANHGDAD, KJBDBPPPEPG BNDPGLIHNPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3571DE0", Offset = "0x35707E0", VA = "0x183571DE0", Slot = "9")]
		[AsyncStateMachine(typeof(CKNMJNECBMM))]
		public Task<MPFEOFKMCLF> POIBBHNKAPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3571980", Offset = "0x3570380", VA = "0x183571980", Slot = "11")]
		public bool Equals(DDLMIMOKCGH DFHJPOKNFFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3571AC0", Offset = "0x35704C0", VA = "0x183571AC0", Slot = "0")]
		public override bool Equals(object LAFPICAOEAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3571C10", Offset = "0x3570610", VA = "0x183571C10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3571880", Offset = "0x3570280", VA = "0x183571880")]
		private bool AMEIEJBLFGK(EKEOGHICJEM DFHJPOKNFFB)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct AFBJPGHOHCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<DDLMIMOKCGH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public LNCBJOJEKMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<GEANGCAJNPB> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<GEANGCAJNPB>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, PLBBCNAGCNA account, GEANGCAJNPB roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x356C1A0", Offset = "0x356ABA0", VA = "0x18356C1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x356CC30", Offset = "0x356B630", VA = "0x18356CC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct LMDEOJLIKDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, PLBBCNAGCNA account, GEANGCAJNPB roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<GEANGCAJNPB> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public LNCBJOJEKMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<PLBBCNAGCNA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x357B6D0", Offset = "0x357A0D0", VA = "0x18357B6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x357C050", Offset = "0x357AA50", VA = "0x18357C050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JGOBBHLAPLD BBKECIKKDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly GBBJAOHMJHJ ECOHMIOHIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly IPILFBEHJNA OIDDCCPIBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly global::HAENEOGNPHE<(long, long), IReadOnlyList<GEANGCAJNPB>> JBHDAKICPCA;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2E3C9D0", Offset = "0x2E3B3D0", VA = "0x182E3C9D0")]
	[UnityEngine.Scripting.Preserve]
	public LNCBJOJEKMF([HGGCKJALFAG(null)] GBBJAOHMJHJ FBCINKEIHJG, [HGGCKJALFAG(null)] IPILFBEHJNA BCIFJNAOGJE, [HGGCKJALFAG(null)] JGOBBHLAPLD DFIADMLNIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2E3C880", Offset = "0x2E3B280", VA = "0x182E3C880")]
	[AsyncStateMachine(typeof(AFBJPGHOHCJ))]
	public Task<IList<DDLMIMOKCGH>> JKIEMHNPDBL(long ANAJKMBCHFB, long DJKGICGFGOE, bool HLDIGHJIDAP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2E3C670", Offset = "0x2E3B070", VA = "0x182E3C670")]
	private bool HKDJDHCMDBM(DateTime? LOPHBLCCICH, long ANAJKMBCHFB, long DJKGICGFGOE, out BMIHFLGADPJ LKDJBANFPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2E3C530", Offset = "0x2E3AF30", VA = "0x182E3C530")]
	[AsyncStateMachine(typeof(LMDEOJLIKDI))]
	private Task<IReadOnlyList<(int, PLBBCNAGCNA, GEANGCAJNPB)>> HINMJMCFCBN(IReadOnlyList<GEANGCAJNPB> EKFKPEJHOIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IPILFBEHJNA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<BMIHFLGADPJ> AGNAJNPHALB;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FIBEANJPHEJ(long ANAJKMBCHFB, long DJKGICGFGOE, OCNLFCGGDIP KHEKPGMMFPH, EJAEMPHNCCB ADIFNIMFLJN);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AEEKGDBBEMI(long ANAJKMBCHFB, long DJKGICGFGOE, out BMIHFLGADPJ LKDJBANFPLK);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CIDGNBCLKPM(long ANAJKMBCHFB, long DJKGICGFGOE, EJAEMPHNCCB ADIFNIMFLJN, out BMIHFLGADPJ LKDJBANFPLK);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DBPLGOJBFFC(long ANAJKMBCHFB, long DJKGICGFGOE);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface DOBDOPNBODM : HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool GFKLNHPDJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task BLDNPKPBABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PNJCMFKJCEC(Task MBOEJHPPHJP, string DLNNMJGMNPP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface PPAMFDIKOID : HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MPFEOFKMCLF> PHJCGCNEJGP(BMIHFLGADPJ LKDJBANFPLK);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JDCIKCCGBGM(CancellationToken KAKEKEHNCME);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface LNOBPJKHKLG : HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	DFAGGIFGJFA KNFEBGIEFJN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLMKLCMKEGK();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLMOKHCPFKE();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface HLCHENPOKGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface FPBAPLBNEBI
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan FNCLKCAFEMM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan CELMMFIIENF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan PJKAKILJNPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan GECIMNLKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool BIEHKPJOHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool KDCAPEBEEOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool IJDFCJAOBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum DLPEGPAJGDH
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum GOJAKPCKBGA
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct BHPLPOAJICO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long LCDGPOCEBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long DJFDGMPNMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly DLPEGPAJGDH MAHAMGBPDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception LOCPFDMHCDK;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x280B7C0", Offset = "0x280A1C0", VA = "0x18280B7C0")]
	public BHPLPOAJICO(long LCDGPOCEBEF, long DJFDGMPNMLL, DLPEGPAJGDH MAHAMGBPDNB, [CanBeNull] Exception LOCPFDMHCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x280B770", Offset = "0x280A170", VA = "0x18280B770")]
	public static BHPLPOAJICO KHECJIFKKPO(CMGFGGHOKOI HHPPFLNINLK, DLPEGPAJGDH MAHAMGBPDNB, [Optional] Exception LOCPFDMHCDK)
	{
		return default(BHPLPOAJICO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate void CKIFCFOJOGB(BHPLPOAJICO OENKJBHANFK);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface MGDDGPMOLMK : HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JCEINNNJCGF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CKIFCFOJOGB OGMNEFAIFDN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event CKIFCFOJOGB LANNNNLBJDM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event CKIFCFOJOGB DLJBDIFAFNF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<GOJAKPCKBGA, bool> BHDELBGCPGL;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IFCEPKBDOMH();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FFJKJLPLICK(BHPLPOAJICO OENKJBHANFK);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FKHKBGDEOGB(BHPLPOAJICO OENKJBHANFK);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FBONDFAKGKC(BHPLPOAJICO OENKJBHANFK);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GAIFHKLABCA(GOJAKPCKBGA EPLCJFLCJCI, bool CHBAEKGGGBK);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface OBAMEKJKGCM : HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PHPHAIMMJKL();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMKHJNBDOKG();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IAHAIEIHBPC();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate Task KABKKHLEJLC(FDMJKHLGKCI FGCBFOCODMG, CancellationToken DEGCIHEAIBD);
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface GKAGLKPIBLL : HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool MHNPMIPGGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GGOAAODNOIA(KABKKHLEJLC JOOGBBDIEJD);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface GAAHNJFFAEA : HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TaskStatus HFEHCCDFOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KGNOFNFAJDJ(CMGFGGHOKOI IDOFMJNBFAM, LBGPKAJBJHG ODICGJJDDAC, CancellationToken HLIGFMLOMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class OAEBECPCPFP
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2E42890", Offset = "0x2E41290", VA = "0x182E42890")]
	public static bool MHDJDOMAMHE(this GAAHNJFFAEA IMLFFCHBOCH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface AHOGOPJAAEB : OBIAGMHMIFG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CancellationToken OMDODPCIOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	PLIBOCMCGIC NOEMDOJLBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	ONLFOKFFMFG LKKBLPEHGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	GLDIFALLLJC CDEOCNALKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	IIFGAMEMGIC KKDHBDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	IHIPIPFGNAC HBOCDCMDGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	IJGBLFJOLIK DBMHHAOCAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	LBNBLMOGAPL EOEMMGAKDDI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	BCJAKJOCBPE LAHFDJAKGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	DOBDOPNBODM KBEFDMMOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	PPAMFDIKOID HIJPBPCBEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	MGDDGPMOLMK NPALOFKONDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	OBAMEKJKGCM NPBBKAIPGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	GAAHNJFFAEA MGKKADOKKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	GKAGLKPIBLL AAKEPMLNJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	DJKFCMHMKGF DNMJPHADMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	PMIFGFAHMGD MJFGBLJMAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	HDEGNFEFHDD FLKKJKEFMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	BKNECNMLLAN IICOJNDEPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	CIBJEAPNFBB IPBJCHJDPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CFOAOPPKJBC GDIKJMLFDKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	BJMNMMHLEFF CEDHOFPAAPG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	JOEODCEIBNN CHBDMEBOICO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	EPEFGOAMBLL FJMBJPKJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	GJFNOIPJOFC ANJHALOEIKM
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	PCFAGBJEOFC OHMLBHKBCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	LNOBPJKHKLG ECDBLAFOEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	FPBAPLBNEBI LECEEKMMOEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	BMIFJPKMJCB NLIEFOKAADG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	IPILFBEHJNA HOPAECNADOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MBGBGKKNFHC(LBGPKAJBJHG PLFNIHFHGKB);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface DJKFCMHMKGF : HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLBDJHDHBDH CPLOAHMOJFD(Guid EPCIDCJCNKD);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OLCIACFECIH(Guid EPCIDCJCNKD);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GKIHEPPEAAC(Guid EPCIDCJCNKD, Task PDLCBPCEPCB);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IIHBJGFHELI(Guid EPCIDCJCNKD, MPFEOFKMCLF LGEALOMIKGO);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IAHAIEIHBPC(Guid EPCIDCJCNKD);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(MPFEOFKMCLF, Task)> LAFFJAHJEJL(Guid EPCIDCJCNKD);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface PMIFGFAHMGD : HLCHENPOKGP, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface HDEGNFEFHDD : HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLNNLCBPMLN(CBPIBEEEMBL EJEIJOMMNGK);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ABHKFKEJPHL(CBPIBEEEMBL EJEIJOMMNGK);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<KLANEEMABFB> CNCONPCIKKL(CancellationToken PKBPNBMKIFA);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public delegate MPFEOFKMCLF FGJNAJCKJHK(BNMLLFBMDOA LHPLFHANPPB, KLANEEMABFB EKGFPKDOIBA);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface BKNECNMLLAN : HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLBDJHDHBDH JNFAGJLAENC(CBPIBEEEMBL NJJHMBBHFOJ);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPBANNDMHDL(Guid EPCIDCJCNKD, Task PDLCBPCEPCB);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface CIBJEAPNFBB : HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MPFEOFKMCLF> IPBJCHJDPGP(CBPIBEEEMBL IKJODENKJBP);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface CFOAOPPKJBC : HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BKIFJPHNINC> KJJPPFJABPD(PPKCEHBLCJE IFNGEGAGDGH, CMGFGGHOKOI IDOFMJNBFAM, CancellationToken KAKEKEHNCME);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface JOEODCEIBNN : HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MPFEOFKMCLF PNHDFFMCHDL(BNMLLFBMDOA LHPLFHANPPB);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GEDLCCHBHGL(string NKNOOFILFKG);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface BJMNMMHLEFF : HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CBPIBEEEMBL> ALCPDMOLDNI(CBPIBEEEMBL NONPDGFJDAK, CAFOCDOFHHK NNBGOFHFNND, CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CBPIBEEEMBL> KEAPGKKGDEF(CancellationToken KAKEKEHNCME, CAFOCDOFHHK NNBGOFHFNND);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PHJKBIIFKDP PMPANJGBKMJ(BLIAEEPMOEN ECNKEMNJLAN, PPKCEHBLCJE IFNGEGAGDGH);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PHJKBIIFKDP LEGIAKKDMJB(BLIAEEPMOEN ECNKEMNJLAN, PPKCEHBLCJE IFNGEGAGDGH);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface EPEFGOAMBLL : HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MPFEOFKMCLF KHKGIJMFLLE(BNMLLFBMDOA LHPLFHANPPB, KLANEEMABFB EKGFPKDOIBA);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MPFEOFKMCLF GJAACCDLNBK(BNMLLFBMDOA BJOEAAODKCA);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MPFEOFKMCLF FLJJODPLDLO(BNMLLFBMDOA BJOEAAODKCA);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface GJFNOIPJOFC
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KLEGPJPJIFP(LDHNPMLOCFA HKPEIPBKBAM);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNKAMHKBEAP(LDHNPMLOCFA HKPEIPBKBAM);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FAEEHKLEHAD(LDHNPMLOCFA HKPEIPBKBAM);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BBELAJEPPPN(LDHNPMLOCFA HKPEIPBKBAM);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class LDHNPMLOCFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly CMGFGGHOKOI CIJAKKFLOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> FDCOEMDJEIC;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public global::CLGKLANEGOH<string> HCKOOEGMGPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6C2130", Offset = "0x6C0B30", VA = "0x1806C2130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F40", Offset = "0x6C0940", VA = "0x1806C1F40")]
	public LDHNPMLOCFA(CMGFGGHOKOI IDHGMFMNLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2E39990", Offset = "0x2E38390", VA = "0x182E39990")]
	public LDHNPMLOCFA DAIEDCNHHHL(string AJPNMLHDHNM, string MNIAGKNOHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2E39A60", Offset = "0x2E38460", VA = "0x182E39A60")]
	public bool INHKAPDKNCK(out IEnumerable<KeyValuePair<string, string>> CHLFAOBOBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x26828E0", Offset = "0x26812E0", VA = "0x1826828E0")]
	public LDHNPMLOCFA LIJNBPHABNI(global::CLGKLANEGOH<string> CEJBHGLMENF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface BMIFJPKMJCB
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool KLHFIANNFJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string KAGNHGDPFGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJENGHHEOBP();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CDPKCLHLDKA MIINAJFGLAO(long OPBDCCPJIKP);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::JPMELOFIHBA<BDADFHIJBPJ, FKLFOLGOGPE> LGHHAIIKAHG(long OPBDCCPJIKP);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::JPMELOFIHBA<BDADFHIJBPJ, NNPMFHIGJPA> PCEJFAEAMJO(long OPBDCCPJIKP);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::JPMELOFIHBA<long, IFELJMKMFJP> BHBNKLFMPEK();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> CBAKHHMJKOE(byte[] FFOFNJPDKLM, byte[] NOKMNHEPOPP, CancellationToken KAKEKEHNCME);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface OBIAGMHMIFG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool MHDJDOMAMHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool BBECIMFLFGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	Task MLJGBIADBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	LBGPKAJBJHG DJLKGKNDABG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action JCEINNNJCGF;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event CKIFCFOJOGB OGMNEFAIFDN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event CKIFCFOJOGB LANNNNLBJDM;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event CKIFCFOJOGB DLJBDIFAFNF;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<GOJAKPCKBGA, bool> BHDELBGCPGL;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AMKHJNBDOKG();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GAMHHFNCFOO GJPKJEGMKBG();

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DOIJMLLBAMJ JFAPJHHBNAE();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<MPFEOFKMCLF> PHJCGCNEJGP(BMIHFLGADPJ CJMCLFOEGKH);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task JDCIKCCGBGM(CancellationToken KAKEKEHNCME);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface IHIPIPFGNAC
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool LAIDMBJKFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string CHKBLDLLPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANOKBJONCAL(Scene KHGLPHMKHKM);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HEJMLLFCDFG(CFJLMNDGPFO DGMNBOKOBOE, CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PNCGNIAKNML();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface IIFGAMEMGIC
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	GDIIDHNMKBB FKJMHDJKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int IMAMNCLOFNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool JJEAIEAIFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool GOBABJHPMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool NNBEDCNLJJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool PBDMNOAPEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool MDONBCFIEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	BNMLLFBMDOA NELFCHDFPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool GFPKEGDOAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PLIBOCMCGIC JKDCOKBKPMG(PLIBOCMCGIC JDCEOEILIMC);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OJDDHMCLCIH(PLIBOCMCGIC KCKJCMPILDG);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task BKFHADOPMNM(PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task NNMKCGFFJFM(CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task ANBFOOJILPI(EKENHJPDEIN JMBFNCMEOEA, [Optional] CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AIIALANGNGM(float HDBBGEBNOID);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CILIIDAPNEA(string JBGIOGBCJPF);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<NAIAMOPHAKF> CGLGKOABHMN();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable HFMGJJJKPKE(object CGFEOLDGFLJ, NAIAMOPHAKF JEOLEIEPNGE);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FKLFOLGOGPE EIACOPCLDDI();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LHPLJPHLEIL(int HNMBPLNODFK);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task GGNFEGKLFEH();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IDHPDFPOHFL();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool JCBDJPDDPPF();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task KHPEMNFLEOP(CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task JCKJDCGIFIF(CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<IIMGBLENGCK> NLJNPOHBHOJ(DateTime NJFLJPBIDGM, CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> OGLJIDGMOPO(CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JJBCINEJLHB();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "25")]
	ANJDDDPAFFI ALCMHEHHDOL(EPCNJJPDOKP OAHECELLGFO, NNPMFHIGJPA OEHIKOADNEH, IEnumerable<PersistenceView> EDDDOFKJPMF, ref GNCDCAIKNKC LDDAKJJOCDP);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LKAIENJFMPA(NNPMFHIGJPA OEHIKOADNEH);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DJDJFBOKEOF(AOGDKFHKIOB GDCPPPKHAKB, in ANJDDDPAFFI JAGMMDGFNGO);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task KEPDHNAMANP(NNPMFHIGJPA JPCGJBHHDPC, bool HOKABNOPGOE, CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task AKPMGBEJDMP(CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void PAJCNAAADKH(long ANAJKMBCHFB, long DJFDGMPNMLL, BIHOLPOPBIG BBBLPIMMPAL, OCNLFCGGDIP KHEKPGMMFPH);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void OGBLOCLFJEO(long ANAJKMBCHFB, long DJFDGMPNMLL);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void DLIGKJAKDNJ(PersistenceView MOBJKJDOKOJ);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool KAOEJCOHDMK(PersistenceView DICLGEOGLMC);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool IBFJOFPFAHE(AOGDKFHKIOB GDCPPPKHAKB, GMCHMPCDOOP EODIEHDJNNA, out JBIPENBLOOE FCPLALCBMJF);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void IGLBKHFAKNP();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void KODHEBBCMLB();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable CDIBOHPGHPI();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void PIELKOBLCDN(NNPMFHIGJPA JPCGJBHHDPC, GMCHMPCDOOP EODIEHDJNNA);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> GFMPKEMEAKK(ONLFOKFFMFG LNMHPEDOLKI, CancellationToken KAKEKEHNCME, PPKCEHBLCJE IFNGEGAGDGH);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void HGLNNCJHEJK(CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<LFADINBGMLP> HAGPFJMLNAO(GHMNHFFBDFG NONPDGFJDAK);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<KDNHOHLLBHL> MCFEPDPCNLB(string NJCPAEPCFCM, long ANAJKMBCHFB, long DJFDGMPNMLL, string HLAOLJPPFIN, AEEJOBEHCBE.EEJEEEBFGDN FGCBFOCODMG, AEEJOBEHCBE.EEJEEEBFGDN NOKMNHEPOPP, int FGKCBIDBKEO);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<BIHOLPOPBIG> GHKMGEMFHPP(long ANAJKMBCHFB, bool KLLPMMMIPCI, CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool LJDGLGLNOJG();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool IMGAMMJMDJD();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool PBEDEGPKDBA(IEnumerable<JBIPENBLOOE> HOABEPGOGNN);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void JPFDKBCFPDF(List<GameObject> KDDNMEEBCIN);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float ECJPGCBLFAC();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool DLPMOBKGAEJ(string DHEPJJLJLLD, out Scene BBIKMOACHCN);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "52")]
	Task<Scene> ONBKHOLJIHN(string DHEPJJLJLLD, LoadSceneMode BJKFILCPGLL, bool BOHHGFEMLNH, PPKCEHBLCJE CEJBHGLMENF);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void HBIDINONJKG();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "54")]
	bool MPNHEDBDMMP(ByteString DBKEJGOGOOA);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void HPPHICKCNHJ();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void CAFJCKGCNAF();

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void EEBDJMHHEDC(CMGFGGHOKOI KDPHPMIMGMF);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task GAPDOFCOGEB(PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task MDDDLCGADGK(PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void LDNAHPHGIKB();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "62")]
	IDisposable JEFMJBGFDGJ();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "63")]
	DNIIACMEENK MFFGDGCHOHO();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface DNIIACMEENK
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LKCNGDDCCIK(CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EONHNIJIJOA(CancellationToken KAKEKEHNCME);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct ANJDDDPAFFI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> IHGHHNOAFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IDisposable KFIEEJAOFAH;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2808A30", Offset = "0x2807430", VA = "0x182808A30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum IIMGBLENGCK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface GDIIDHNMKBB
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	CMGFGGHOKOI LKBNBCGDNLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	BIHOLPOPBIG CABHAFJKBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	CKHPNKKDHCH MKGBNBJOINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool EDKKGIHDHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool GMKBIDHFBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	int IMAMNCLOFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action CLIHEAMLEEI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<int> CKFFMEIFEEE;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IFOIOLIFHHF();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.ENMLEDFMDLO> MCHIKHOFKKG();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task FJCOMCELEFM();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "13")]
	(CMGFGGHOKOI, LBGPKAJBJHG) FJJMMBEKPCM();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ABDJCJMAGOJ LOIHMOHFJBL();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HAOACEBNDHG(long OPBDCCPJIKP);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface PCFAGBJEOFC
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEPOJDIGACP(out IEnumerable<int> MHLIFCFBIPH);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHLMOBILNEF(BCNMCHLKHFL DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BKMLJBKPCOB(BCNMCHLKHFL DEGCIHEAIBD);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface FADGBLLDFAC
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MDHABMBAJJC(MPFEOFKMCLF FHLMNCKDHLL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IFFJBPOLGAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MMCDOCLDJPK(EOLBNIPGEBA.LJJINNPGJCA EFAOPCCHJNI);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFHOAKDJGDP(EOLBNIPGEBA.LJJINNPGJCA EFAOPCCHJNI);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface IJGBLFJOLIK : IFFJBPOLGAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MPFEOFKMCLF DHMHBCJIFLG(BNMLLFBMDOA BJOEAAODKCA);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface LBNBLMOGAPL : IFFJBPOLGAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MPFEOFKMCLF PNHDFFMCHDL(BNMLLFBMDOA BIJLNBDIJCB);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface CDPKCLHLDKA
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::HJJOMCAHDKC<CFJLMNDGPFO, PJMBHANDPHF>> KHKEPBODBEK(string HLAOLJPPFIN, long OPBDCCPJIKP, FEFPFDJPFJA.GNKGMJJDDPD HHFOMNMCPHO, CancellationToken KAKEKEHNCME);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface JPMELOFIHBA<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::HJJOMCAHDKC<byte[], PJMBHANDPHF>> EOIGPIONDGN(TGetDataArg NGMLAIALNFB, CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::HJJOMCAHDKC<global::MGCPIBOLANK<TData>, PJMBHANDPHF> POHKFKAKKBJ(byte[] NIPBPKPBPPP);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class HJLFDLCKHEI : AHOGOPJAAEB, OBIAGMHMIFG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct LGIHAKONKEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<MPFEOFKMCLF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public HJLFDLCKHEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public BMIHFLGADPJ autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<MPFEOFKMCLF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x357AD10", Offset = "0x3579710", VA = "0x18357AD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x357AFB0", Offset = "0x35799B0", VA = "0x18357AFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct OKBNGENEFOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public HJLFDLCKHEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x357FF50", Offset = "0x357E950", VA = "0x18357FF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class NCADIAJNEHI : IEnumerable<HLCHENPOKGP>, IEnumerable, IEnumerator<HLCHENPOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private HLCHENPOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public HJLFDLCKHEI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private HLCHENPOKGP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
		[DebuggerHidden]
		public NCADIAJNEHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x357E0D0", Offset = "0x357CAD0", VA = "0x18357E0D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x357E510", Offset = "0x357CF10", VA = "0x18357E510", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x357E470", Offset = "0x357CE70", VA = "0x18357E470", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HLCHENPOKGP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x357E470", Offset = "0x357CE70", VA = "0x18357E470", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource BMHBPBCEJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly PLIBOCMCGIC KCKJCMPILDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool DHFBGINHBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private JDGCJDPCHCK FLJBIACPMOD;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public ONLFOKFFMFG LKKBLPEHGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6C10D0", Offset = "0x6BFAD0", VA = "0x1806C10D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7B9310", Offset = "0x7B7D10", VA = "0x1807B9310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GLDIFALLLJC CDEOCNALKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6D7760", Offset = "0x6D6160", VA = "0x1806D7760", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x74B000", Offset = "0x749A00", VA = "0x18074B000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public IIFGAMEMGIC KKDHBDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6C10B0", Offset = "0x6BFAB0", VA = "0x1806C10B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7B9300", Offset = "0x7B7D00", VA = "0x1807B9300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public IHIPIPFGNAC HBOCDCMDGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6D7770", Offset = "0x6D6170", VA = "0x1806D7770", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x762AB0", Offset = "0x7614B0", VA = "0x180762AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public IJGBLFJOLIK DBMHHAOCAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6D7780", Offset = "0x6D6180", VA = "0x1806D7780", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7B92F0", Offset = "0x7B7CF0", VA = "0x1807B92F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public LBNBLMOGAPL EOEMMGAKDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6D7700", Offset = "0x6D6100", VA = "0x1806D7700", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6E9860", Offset = "0x6E8260", VA = "0x1806E9860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public BCJAKJOCBPE LAHFDJAKGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6D7710", Offset = "0x6D6110", VA = "0x1806D7710", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DB0", Offset = "0x6F77B0", VA = "0x1806F8DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public DOBDOPNBODM KBEFDMMOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6D0", Offset = "0x6FC0D0", VA = "0x1806FD6D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6F8D90", Offset = "0x6F7790", VA = "0x1806F8D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public PPAMFDIKOID HIJPBPCBEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D80", Offset = "0x6C6780", VA = "0x1806C7D80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8CBEB0", Offset = "0x8CA8B0", VA = "0x1808CBEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public MGDDGPMOLMK NPALOFKONDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E20", Offset = "0x6C6820", VA = "0x1806C7E20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x840610", Offset = "0x83F010", VA = "0x180840610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public OBAMEKJKGCM NPBBKAIPGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6A0", Offset = "0x6FC0A0", VA = "0x1806FD6A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8CB4D0", Offset = "0x8C9ED0", VA = "0x1808CB4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public GAAHNJFFAEA MGKKADOKKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6D7720", Offset = "0x6D6120", VA = "0x1806D7720", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DA0", Offset = "0x6F77A0", VA = "0x1806F8DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public GKAGLKPIBLL AAKEPMLNJBF
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6D7730", Offset = "0x6D6130", VA = "0x1806D7730", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x745540", Offset = "0x743F40", VA = "0x180745540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public DJKFCMHMKGF DNMJPHADMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6D7750", Offset = "0x6D6150", VA = "0x1806D7750", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7F4100", Offset = "0x7F2B00", VA = "0x1807F4100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public PMIFGFAHMGD MJFGBLJMAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6D7740", Offset = "0x6D6140", VA = "0x1806D7740", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DC0", Offset = "0x6F77C0", VA = "0x1806F8DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public HDEGNFEFHDD FLKKJKEFMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7F1820", Offset = "0x7F0220", VA = "0x1807F1820", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7F1F10", Offset = "0x7F0910", VA = "0x1807F1F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public BKNECNMLLAN IICOJNDEPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7797A0", Offset = "0x7781A0", VA = "0x1807797A0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7F1830", Offset = "0x7F0230", VA = "0x1807F1830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public CIBJEAPNFBB IPBJCHJDPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E40", Offset = "0x7F2840", VA = "0x1807F3E40", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3F30", Offset = "0x7F2930", VA = "0x1807F3F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public CFOAOPPKJBC GDIKJMLFDKL
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x83D9E0", Offset = "0x83C3E0", VA = "0x18083D9E0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x83DAC0", Offset = "0x83C4C0", VA = "0x18083DAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public BJMNMMHLEFF CEDHOFPAAPG
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7F24C0", Offset = "0x7F0EC0", VA = "0x1807F24C0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x83E730", Offset = "0x83D130", VA = "0x18083E730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public JOEODCEIBNN CHBDMEBOICO
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7F21C0", Offset = "0x7F0BC0", VA = "0x1807F21C0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7F24F0", Offset = "0x7F0EF0", VA = "0x1807F24F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public EPEFGOAMBLL FJMBJPKJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7F21A0", Offset = "0x7F0BA0", VA = "0x1807F21A0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7F24D0", Offset = "0x7F0ED0", VA = "0x1807F24D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public GJFNOIPJOFC ANJHALOEIKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7F21B0", Offset = "0x7F0BB0", VA = "0x1807F21B0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7F24E0", Offset = "0x7F0EE0", VA = "0x1807F24E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public PCFAGBJEOFC OHMLBHKBCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x83E720", Offset = "0x83D120", VA = "0x18083E720", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xF4A320", Offset = "0xF48D20", VA = "0x180F4A320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public LNOBPJKHKLG ECDBLAFOEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7F24A0", Offset = "0x7F0EA0", VA = "0x1807F24A0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7F2640", Offset = "0x7F1040", VA = "0x1807F2640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public FPBAPLBNEBI LECEEKMMOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7F24B0", Offset = "0x7F0EB0", VA = "0x1807F24B0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7F2650", Offset = "0x7F1050", VA = "0x1807F2650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public BMIFJPKMJCB NLIEFOKAADG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA69880", Offset = "0xA68280", VA = "0x180A69880", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA68F10", Offset = "0xA67910", VA = "0x180A68F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public IPILFBEHJNA HOPAECNADOC
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA679E0", Offset = "0xA663E0", VA = "0x180A679E0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public LBGPKAJBJHG DJLKGKNDABG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x105FBC0", Offset = "0x105E5C0", VA = "0x18105FBC0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x14BD210", Offset = "0x14BBC10", VA = "0x1814BD210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private bool LECIGDGFBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x281FB00", Offset = "0x281E500", VA = "0x18281FB00", Slot = "45")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private bool CHKDLPGCHDI
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x281FE00", Offset = "0x281E800", VA = "0x18281FE00", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private Task AOAODCDBKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x28200F0", Offset = "0x281EAF0", VA = "0x1828200F0", Slot = "47")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private CancellationToken KDACMEJONBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x281F7D0", Offset = "0x281E1D0", VA = "0x18281F7D0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private PLIBOCMCGIC NHIPAKALDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event Action PKOBEDEJEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x281FB70", Offset = "0x281E570", VA = "0x18281FB70", Slot = "35")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x281F770", Offset = "0x281E170", VA = "0x18281F770", Slot = "36")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event CKIFCFOJOGB JLBIDLBFANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x281FE80", Offset = "0x281E880", VA = "0x18281FE80", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x281FB10", Offset = "0x281E510", VA = "0x18281FB10", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event CKIFCFOJOGB OAAFGMPPBBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x281F980", Offset = "0x281E380", VA = "0x18281F980", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2820090", Offset = "0x281EA90", VA = "0x182820090", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event CKIFCFOJOGB GDOKHADJHIH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x281FA40", Offset = "0x281E440", VA = "0x18281FA40", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x281FAA0", Offset = "0x281E4A0", VA = "0x18281FAA0", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event Action<GOJAKPCKBGA, bool> MHNLIGPLIJF
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2820030", Offset = "0x281EA30", VA = "0x182820030", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2820260", Offset = "0x281EC60", VA = "0x182820260", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x14BD210", Offset = "0x14BBC10", VA = "0x1814BD210", Slot = "34")]
	public void MBGBGKKNFHC(LBGPKAJBJHG PLFNIHFHGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x28202C0", Offset = "0x281ECC0", VA = "0x1828202C0")]
	[UnityEngine.Scripting.Preserve]
	internal HJLFDLCKHEI([HGGCKJALFAG(null)] PLIBOCMCGIC KCKJCMPILDG, [HGGCKJALFAG(null)] ONLFOKFFMFG LNMHPEDOLKI, [HGGCKJALFAG(null)] GLDIFALLLJC BKAPJEHMPIB, [HGGCKJALFAG(null)] IIFGAMEMGIC EDFOBNPNANH, [HGGCKJALFAG(null)] IHIPIPFGNAC EJPHENLGLHB, [HGGCKJALFAG(null)] IJGBLFJOLIK AJGODMCHCBF, [HGGCKJALFAG(null)] LBNBLMOGAPL JJCLJDAGLPF, [HGGCKJALFAG(null)] BCJAKJOCBPE CFGLODANGMD, [HGGCKJALFAG(null)] DOBDOPNBODM MPIMBMLNILB, [HGGCKJALFAG(null)] PPAMFDIKOID JPELMBPFAIH, [HGGCKJALFAG(null)] MGDDGPMOLMK KJBMIMOPDKI, [HGGCKJALFAG(null)] OBAMEKJKGCM PPOAHOFKJCI, [HGGCKJALFAG(null)] GAAHNJFFAEA IMLFFCHBOCH, [HGGCKJALFAG(null)] GKAGLKPIBLL CADMCPODFHN, [HGGCKJALFAG(null)] DJKFCMHMKGF FOGNHMGNHJE, [HGGCKJALFAG(null)] PMIFGFAHMGD JBMPFLHGKFJ, [HGGCKJALFAG(null)] HDEGNFEFHDD FALMKJIBDGM, [HGGCKJALFAG(null)] BKNECNMLLAN BEJGEJIOJNK, [HGGCKJALFAG(null)] CIBJEAPNFBB OHALHMEGNLE, [HGGCKJALFAG(null)] CFOAOPPKJBC JLMEAOKHODO, [HGGCKJALFAG(null)] JOEODCEIBNN BCNJCEJEHGL, [HGGCKJALFAG(null)] BJMNMMHLEFF KDOGACEGKJM, [HGGCKJALFAG(null)] EPEFGOAMBLL BKHEOALBIHA, [HGGCKJALFAG(null)] GJFNOIPJOFC FDPJKGDENML, [HGGCKJALFAG(null)] PCFAGBJEOFC ECOABCAHCAH, [HGGCKJALFAG(null)] FPBAPLBNEBI NIFCFEIBHMP, [HGGCKJALFAG(null)] BMIFJPKMJCB POPCNHOPLAO, [HGGCKJALFAG(null)] IPILFBEHJNA JLIMHHGKJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x281FD10", Offset = "0x281E710", VA = "0x18281FD10")]
	private void JGKFDHOAMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x281F7F0", Offset = "0x281E1F0", VA = "0x18281F7F0", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x281F6B0", Offset = "0x281E0B0", VA = "0x18281F6B0", Slot = "48")]
	private void BJNJOFKPKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x281FEE0", Offset = "0x281E8E0", VA = "0x18281FEE0", Slot = "49")]
	private GAMHHFNCFOO NGHPGOKOBDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x281F500", Offset = "0x281DF00", VA = "0x18281F500", Slot = "50")]
	private DOIJMLLBAMJ BACBGMNKCLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x281FBD0", Offset = "0x281E5D0", VA = "0x18281FBD0", Slot = "51")]
	[AsyncStateMachine(typeof(LGIHAKONKEH))]
	private Task<MPFEOFKMCLF> HJPHGJAEHBC(BMIHFLGADPJ LKDJBANFPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2820140", Offset = "0x281EB40", VA = "0x182820140", Slot = "52")]
	[AsyncStateMachine(typeof(OKBNGENEFOP))]
	private Task OGJBCBFONPI(CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x281F700", Offset = "0x281E100", VA = "0x18281F700")]
	[IteratorStateMachine(typeof(NCADIAJNEHI))]
	private IEnumerable<HLCHENPOKGP> CCMAMMKFGOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x281F9E0", Offset = "0x281E3E0", VA = "0x18281F9E0")]
	[CompilerGenerated]
	private void FFEJMFBPOKL(HLCHENPOKGP DCIOCIFFEAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal class NPHOHMJPJLK : NIGAHIMKHBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct FPNNNIONBAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public NPHOHMJPJLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x407D270", Offset = "0x407BC70", VA = "0x18407D270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x407D600", Offset = "0x407C000", VA = "0x18407D600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly IIFGAMEMGIC EDFOBNPNANH;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C16E0", Offset = "0x6C00E0", VA = "0x1806C16E0")]
	public NPHOHMJPJLK(AHOGOPJAAEB BPCKLHHCJGL, IIFGAMEMGIC EDFOBNPNANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2E42390", Offset = "0x2E40D90", VA = "0x182E42390", Slot = "4")]
	[AsyncStateMachine(typeof(FPNNNIONBAD))]
	public Task<bool> IDJONJIAHBO(CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x2E424B0", Offset = "0x2E40EB0", VA = "0x182E424B0")]
	[CompilerGenerated]
	private object JCIOJEOLLJB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class LHHIMBJHDEH : NIGAHIMKHBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct IOPNDFACKMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public LHHIMBJHDEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3575CD0", Offset = "0x35746D0", VA = "0x183575CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x35763D0", Offset = "0x3574DD0", VA = "0x1835763D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const float AEAEKPGJKHK = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly IIFGAMEMGIC EDFOBNPNANH;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private GDIIDHNMKBB FKJMHDJKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A0F0", Offset = "0x2E38AF0", VA = "0x182E3A0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6C16E0", Offset = "0x6C00E0", VA = "0x1806C16E0")]
	public LHHIMBJHDEH(AHOGOPJAAEB BPCKLHHCJGL, IIFGAMEMGIC EDFOBNPNANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x2E3A140", Offset = "0x2E38B40", VA = "0x182E3A140", Slot = "4")]
	[AsyncStateMachine(typeof(IOPNDFACKMC))]
	public Task<bool> IDJONJIAHBO(CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x2E3A280", Offset = "0x2E38C80", VA = "0x182E3A280")]
	[CompilerGenerated]
	private object JOPGBADFNFD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class CLGDJMMIMFD : NIGAHIMKHBO
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class IAGGMNMHPPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CLGDJMMIMFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Matchmaking.ENMLEDFMDLO result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public CMGFGGHOKOI newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public IAGGMNMHPPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2E381C0", Offset = "0x2E36BC0", VA = "0x182E381C0")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2E382A0", Offset = "0x2E36CA0", VA = "0x182E382A0")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2E38310", Offset = "0x2E36D10", VA = "0x182E38310")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct DHPCOJLEEOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CLGDJMMIMFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private IAGGMNMHPPD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<Matchmaking.ENMLEDFMDLO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2E35130", Offset = "0x2E33B30", VA = "0x182E35130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2E35A80", Offset = "0x2E34480", VA = "0x182E35A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private const float AEAEKPGJKHK = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly IIFGAMEMGIC EDFOBNPNANH;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private GDIIDHNMKBB FKJMHDJKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x280D680", Offset = "0x280C080", VA = "0x18280D680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6C16E0", Offset = "0x6C00E0", VA = "0x1806C16E0")]
	public CLGDJMMIMFD(AHOGOPJAAEB BPCKLHHCJGL, IIFGAMEMGIC EDFOBNPNANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x280D6D0", Offset = "0x280C0D0", VA = "0x18280D6D0", Slot = "4")]
	[AsyncStateMachine(typeof(DHPCOJLEEOK))]
	public Task<bool> IDJONJIAHBO(CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal interface NIGAHIMKHBO
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> IDJONJIAHBO(CancellationToken KAKEKEHNCME);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal struct CFDDGBHCIBH
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class HHGPFCICIDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AHOGOPJAAEB manager;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public HHGPFCICIDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2E38120", Offset = "0x2E36B20", VA = "0x182E38120")]
		internal Task <CreateTask>b__0(FDMJKHLGKCI data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct GPHBKPMGGEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CFDDGBHCIBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private BMIHFLGADPJ <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<IIMGBLENGCK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<MPFEOFKMCLF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2E37B50", Offset = "0x2E36550", VA = "0x182E37B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2E380D0", Offset = "0x2E36AD0", VA = "0x182E380D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct BDPCGDKDOPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CFDDGBHCIBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2E338D0", Offset = "0x2E322D0", VA = "0x182E338D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CancellationToken KAKEKEHNCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly AHOGOPJAAEB MPEBEBMNLLA;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private ONLFOKFFMFG LKKBLPEHGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x280C420", Offset = "0x280AE20", VA = "0x18280C420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private IIFGAMEMGIC KKDHBDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x280C470", Offset = "0x280AE70", VA = "0x18280C470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private GDIIDHNMKBB FKJMHDJKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x280C4C0", Offset = "0x280AEC0", VA = "0x18280C4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private PPAMFDIKOID HIJPBPCBEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x280CA10", Offset = "0x280B410", VA = "0x18280CA10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x280CB60", Offset = "0x280B560", VA = "0x18280CB60")]
	public CFDDGBHCIBH(CancellationToken KAKEKEHNCME, AHOGOPJAAEB MPEBEBMNLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x280C950", Offset = "0x280B350", VA = "0x18280C950")]
	public static KABKKHLEJLC LPODNHBNJND(AHOGOPJAAEB MPEBEBMNLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x280C680", Offset = "0x280B080", VA = "0x18280C680")]
	[AsyncStateMachine(typeof(GPHBKPMGGEC))]
	public Task<bool> HHNJFAHFJBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x280C7B0", Offset = "0x280B1B0", VA = "0x18280C7B0")]
	private bool KOFPNNPPHFL(out BMIHFLGADPJ LKDJBANFPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x280CA60", Offset = "0x280B460", VA = "0x18280CA60")]
	[AsyncStateMachine(typeof(BDPCGDKDOPE))]
	private Task OONAOPJMDEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x280C540", Offset = "0x280AF40", VA = "0x18280C540")]
	private Task<IIMGBLENGCK> GPEMCIENIJH(BMIHFLGADPJ DAPJPNKBGHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal struct MLBDJHDHBDH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly DJKFCMHMKGF FOGNHMGNHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid EPCIDCJCNKD;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private Task<(MPFEOFKMCLF, Task)> FKEDDAABOEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2E3F1F0", Offset = "0x2E3DBF0", VA = "0x182E3F1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1FE41D0", Offset = "0x1FE2BD0", VA = "0x181FE41D0")]
	public MLBDJHDHBDH(DJKFCMHMKGF FOGNHMGNHJE, Guid EPCIDCJCNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2E3F1A0", Offset = "0x2E3DBA0", VA = "0x182E3F1A0")]
	public TaskAwaiter<(MPFEOFKMCLF, Task)> EKKKKMBFEEF()
	{
		return default(TaskAwaiter<(MPFEOFKMCLF, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2E3F0D0", Offset = "0x2E3DAD0", VA = "0x182E3F0D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal struct HKNCDDMGNEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly TaskCompletionSource<(MPFEOFKMCLF, Task)> BOCCENOMFKA;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Task<(MPFEOFKMCLF, Task)> FKEDDAABOEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2821ED0", Offset = "0x28208D0", VA = "0x182821ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2821FF0", Offset = "0x28209F0", VA = "0x182821FF0")]
	public HKNCDDMGNEG(TimeSpan BPABCDMAKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2821DF0", Offset = "0x28207F0", VA = "0x182821DF0")]
	public void BHONKFEMBEO(Task PDLCBPCEPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x2821F10", Offset = "0x2820910", VA = "0x182821F10")]
	public void JLDGDODDBGD(MPFEOFKMCLF FHLMNCKDHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2821FA0", Offset = "0x28209A0", VA = "0x182821FA0")]
	public void MOIIMJBMANK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2821D60", Offset = "0x2820760", VA = "0x182821D60")]
	internal void AMOEJLBJAOG(string EJEIJOMMNGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class HNPDGPLHDLF
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class CKGIMHBKCAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public long subRoomId;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public CKGIMHBKCAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x10FACE0", Offset = "0x10F96E0", VA = "0x1810FACE0")]
		internal bool <Create>b__0(CKHPNKKDHCH subRoom)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2822380", Offset = "0x2820D80", VA = "0x182822380")]
	public static BKIFJPHNINC GANMJPNFBJN(long LCDGPOCEBEF, long DJFDGMPNMLL, BDADFHIJBPJ FFOFNJPDKLM, string HLAOLJPPFIN, BDADFHIJBPJ NOKMNHEPOPP, string NJCPAEPCFCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x28224C0", Offset = "0x2820EC0", VA = "0x1828224C0")]
	public static BKIFJPHNINC GANMJPNFBJN(BIHOLPOPBIG EEKNGBBJLDK, GEANGCAJNPB HABKOHELDFN, [Optional] string NJCPAEPCFCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2822160", Offset = "0x2820B60", VA = "0x182822160")]
	public static BKIFJPHNINC GANMJPNFBJN(BIHOLPOPBIG EEKNGBBJLDK, long DJFDGMPNMLL, [Optional] string NJCPAEPCFCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x28227F0", Offset = "0x28211F0", VA = "0x1828227F0")]
	public static BKIFJPHNINC PPJJEDFFIFO(this BKIFJPHNINC EONCDECCEBA, BIHOLPOPBIG JJCMEGFGPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x2822630", Offset = "0x2821030", VA = "0x182822630")]
	public static BKIFJPHNINC HNBCBFONALN(this BKIFJPHNINC EONCDECCEBA, GEANGCAJNPB OHIFHLDGGGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2822710", Offset = "0x2821110", VA = "0x182822710")]
	public static BKIFJPHNINC HNBCBFONALN(this BKIFJPHNINC EONCDECCEBA, CKHPNKKDHCH BKEDFFJNJHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[UnityEngine.Scripting.Preserve]
internal class KAMGAFMIFEN : DOBDOPNBODM, HLCHENPOKGP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct HLLCPFHHJAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public KAMGAFMIFEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x35745C0", Offset = "0x3572FC0", VA = "0x1835745C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly BCNMCHLKHFL KCPADDLFIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private string ILAAMEFLJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Task MBMNJFIECIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool GFKLNHPDJII
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2825750", Offset = "0x2824150", VA = "0x182825750", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Task BLDNPKPBABF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2825780", Offset = "0x2824180", VA = "0x182825780", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7031C0", Offset = "0x701BC0", VA = "0x1807031C0", Slot = "7")]
	public void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2825910", Offset = "0x2824310", VA = "0x182825910", Slot = "6")]
	public void PNJCMFKJCEC(Task MBOEJHPPHJP, string DLNNMJGMNPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x28257E0", Offset = "0x28241E0", VA = "0x1828257E0")]
	[AsyncStateMachine(typeof(HLLCPFHHJAO))]
	private Task NFEEAHBIAKC(Task CMMLEMPHDEC, string DLNNMJGMNPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2825A90", Offset = "0x2824490", VA = "0x182825A90")]
	public KAMGAFMIFEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class JIOBKBPIKII : LNOBPJKHKLG, HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool GIBJGAKGDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private DFAGGIFGJFA KJMLDLPIBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private ONLFOKFFMFG LNMHPEDOLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private FPBAPLBNEBI NIFCFEIBHMP;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public DFAGGIFGJFA KNFEBGIEFJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2825190", Offset = "0x2823B90", VA = "0x182825190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2825400", Offset = "0x2823E00", VA = "0x182825400", Slot = "7")]
	public void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2825240", Offset = "0x2823C40", VA = "0x182825240", Slot = "5")]
	public void GLMKLCMKEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2825200", Offset = "0x2823C00", VA = "0x182825200", Slot = "6")]
	public void LLMOKHCPFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2825510", Offset = "0x2823F10", VA = "0x182825510")]
	private Task PCNKJAOPJJD(FBEKEDLLFLL PAGKANKNAEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2825200", Offset = "0x2823C00", VA = "0x182825200", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public JIOBKBPIKII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class OFHDMNLCDGK : FPBAPLBNEBI
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private class AOEFKCGPNFH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly ALJDLEMICMK MLDKGMPFOBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string AJPNMLHDHNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly T OGDNNKNPNAO;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public T ACPLDDIHALN
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x6C5250", Offset = "0x6C3C50", VA = "0x1806C5250")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x6C5270", Offset = "0x6C3C70", VA = "0x1806C5270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x35833B0", Offset = "0x3581DB0", VA = "0x1835833B0")]
		public AOEFKCGPNFH(ALJDLEMICMK MLDKGMPFOBE, string AJPNMLHDHNM, T OGDNNKNPNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3583000", Offset = "0x3581A00", VA = "0x183583000")]
		private void JDBMDGCKLMK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly AOEFKCGPNFH<TimeSpan> PLKAJIMMPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly AOEFKCGPNFH<TimeSpan> ICGCGHIDOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly AOEFKCGPNFH<TimeSpan> PPIMOFCJLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly AOEFKCGPNFH<TimeSpan> KBGBIKOIIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly AOEFKCGPNFH<bool> JOJPENGPFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly AOEFKCGPNFH<bool> CJJBLOBLADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly AOEFKCGPNFH<bool> JNKEMJIBFCD;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public TimeSpan FNCLKCAFEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2E43490", Offset = "0x2E41E90", VA = "0x182E43490", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public TimeSpan CELMMFIIENF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x2E434D0", Offset = "0x2E41ED0", VA = "0x182E434D0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public TimeSpan PJKAKILJNPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x2E43550", Offset = "0x2E41F50", VA = "0x182E43550", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan GECIMNLKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2E43590", Offset = "0x2E41F90", VA = "0x182E43590", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool BIEHKPJOHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x2E43450", Offset = "0x2E41E50", VA = "0x182E43450", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool KDCAPEBEEOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2E435D0", Offset = "0x2E41FD0", VA = "0x182E435D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool IJDFCJAOBIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x2E43510", Offset = "0x2E41F10", VA = "0x182E43510", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2E43610", Offset = "0x2E42010", VA = "0x182E43610")]
	[UnityEngine.Scripting.Preserve]
	public OFHDMNLCDGK([HGGCKJALFAG(null)] ALJDLEMICMK MLDKGMPFOBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[UnityEngine.Scripting.Preserve]
internal class JCAMLLNABDA : MGDDGPMOLMK, HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class JGANBPLEMMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public BHPLPOAJICO roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public JGANBPLEMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x35774B0", Offset = "0x3575EB0", VA = "0x1835774B0")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action JCEINNNJCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2824B90", Offset = "0x2823590", VA = "0x182824B90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2824730", Offset = "0x2823130", VA = "0x182824730", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event CKIFCFOJOGB OGMNEFAIFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x28249B0", Offset = "0x28233B0", VA = "0x1828249B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2824AF0", Offset = "0x28234F0", VA = "0x182824AF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event CKIFCFOJOGB LANNNNLBJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x28247D0", Offset = "0x28231D0", VA = "0x1828247D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2824A50", Offset = "0x2823450", VA = "0x182824A50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event CKIFCFOJOGB DLJBDIFAFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2824910", Offset = "0x2823310", VA = "0x182824910", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2824870", Offset = "0x2823270", VA = "0x182824870", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<GOJAKPCKBGA, bool> BHDELBGCPGL
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2824690", Offset = "0x2823090", VA = "0x182824690", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x2824370", Offset = "0x2822D70", VA = "0x182824370", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "19")]
	public void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2824410", Offset = "0x2822E10", VA = "0x182824410", Slot = "14")]
	public void IFCEPKBDOMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2824260", Offset = "0x2822C60", VA = "0x182824260", Slot = "15")]
	public void FFJKJLPLICK(BHPLPOAJICO OENKJBHANFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2824290", Offset = "0x2822C90", VA = "0x182824290", Slot = "16")]
	public void FKHKBGDEOGB(BHPLPOAJICO OENKJBHANFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x2824230", Offset = "0x2822C30", VA = "0x182824230", Slot = "17")]
	public void FBONDFAKGKC(BHPLPOAJICO OENKJBHANFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x28242C0", Offset = "0x2822CC0", VA = "0x1828242C0", Slot = "18")]
	public void GAIFHKLABCA(GOJAKPCKBGA EPLCJFLCJCI, bool CHBAEKGGGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2824C30", Offset = "0x2823630", VA = "0x182824C30")]
	private void OOHNAJGMKOC(CKIFCFOJOGB JEOLEIEPNGE, BHPLPOAJICO OENKJBHANFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public JCAMLLNABDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[UnityEngine.Scripting.Preserve]
internal class OLPABBEIKEN : OBAMEKJKGCM, HLCHENPOKGP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct FMJCALNHKLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public OLPABBEIKEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x407CB20", Offset = "0x407B520", VA = "0x18407CB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct AOAJLEBLDJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public OLPABBEIKEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x4078CF0", Offset = "0x40776F0", VA = "0x184078CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class FOPFHDFDINI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public FOPFHDFDINI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x407D200", Offset = "0x407BC00", VA = "0x18407D200")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct FCHGCKNHOOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public OLPABBEIKEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private FOPFHDFDINI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x407C490", Offset = "0x407AE90", VA = "0x18407C490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x407CA20", Offset = "0x407B420", VA = "0x18407CA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class LHDFEJGPFCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public LHDFEJGPFCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x40815F0", Offset = "0x407FFF0", VA = "0x1840815F0")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private IIFGAMEMGIC EDFOBNPNANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private NIGAHIMKHBO[] GONCKDBCGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private CancellationTokenSource FPCHIMCODNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private int NICKLHNDBHJ;

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2E45010", Offset = "0x2E43A10", VA = "0x182E45010", Slot = "7")]
	public void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2E44B70", Offset = "0x2E43570", VA = "0x182E44B70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2E44E90", Offset = "0x2E43890", VA = "0x182E44E90", Slot = "6")]
	public void IAHAIEIHBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2E448E0", Offset = "0x2E432E0", VA = "0x182E448E0", Slot = "5")]
	public void AMKHJNBDOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2E457B0", Offset = "0x2E441B0", VA = "0x182E457B0", Slot = "4")]
	[AsyncStateMachine(typeof(FMJCALNHKLN))]
	public Task PHPHAIMMJKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2E45450", Offset = "0x2E43E50", VA = "0x182E45450")]
	private void OMJHFDKEGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2E44A40", Offset = "0x2E43440", VA = "0x182E44A40")]
	[AsyncStateMachine(typeof(AOAJLEBLDJN))]
	private Task DGDLELIIPBO(CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x2E44D40", Offset = "0x2E43740", VA = "0x182E44D40")]
	[AsyncStateMachine(typeof(FCHGCKNHOOA))]
	private Task<bool> GFOFIHPHKNN(int GFDMFLGCBKB, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x2E451A0", Offset = "0x2E43BA0", VA = "0x182E451A0")]
	private void OFDFLKMAKFF(int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x2E45300", Offset = "0x2E43D00", VA = "0x182E45300")]
	private void OGLIIFMPFAL(int GFDMFLGCBKB, bool CHBAEKGGGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2E44B80", Offset = "0x2E43580", VA = "0x182E44B80")]
	private void FIOMOCADKFM(int GFDMFLGCBKB, Exception IJOOFLECOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x2E45090", Offset = "0x2E43A90", VA = "0x182E45090")]
	private void LCIEMHNGDMF(CancellationToken KAKEKEHNCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public OLPABBEIKEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[UnityEngine.Scripting.Preserve]
internal class KHMKJJGGKAL : GKAGLKPIBLL, HLCHENPOKGP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct DEIOLNIFIHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public KHMKJJGGKAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public FDMJKHLGKCI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x356FB80", Offset = "0x356E580", VA = "0x18356FB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class IHMFOEMFCEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public KHMKJJGGKAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public FDMJKHLGKCI roomData;

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public IHMFOEMFCEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3575170", Offset = "0x3573B70", VA = "0x183575170")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct FFOHCAPHFMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public KABKKHLEJLC taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3572D00", Offset = "0x3571700", VA = "0x183572D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct EKGIFAINDIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public KHMKJJGGKAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3571ED0", Offset = "0x35708D0", VA = "0x183571ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly HashSet<KABKKHLEJLC> FIEGBHLJGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private GLDIFALLLJC BKAPJEHMPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private NAIAMOPHAKF ODMOGJCOECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private HOKPMKCKLEB FFJNNDODGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private IDisposable LBOIADKFLEG;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool MHNPMIPGGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2827370", Offset = "0x2825D70", VA = "0x182827370", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	internal Task FKEDDAABOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2826D40", Offset = "0x2825740", VA = "0x182826D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2826D50", Offset = "0x2825750", VA = "0x182826D50", Slot = "6")]
	public void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2826760", Offset = "0x2825160", VA = "0x182826760", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2826BB0", Offset = "0x28255B0", VA = "0x182826BB0", Slot = "5")]
	public bool GGOAAODNOIA(KABKKHLEJLC JOOGBBDIEJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2827110", Offset = "0x2825B10", VA = "0x182827110")]
	private void KPENFNEADBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2826910", Offset = "0x2825310", VA = "0x182826910")]
	private void FMJPCPPHEAO(FDMJKHLGKCI FGCBFOCODMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2826FF0", Offset = "0x28259F0", VA = "0x182826FF0")]
	[AsyncStateMachine(typeof(DEIOLNIFIHD))]
	private Task KLNHDEGNIGM(FDMJKHLGKCI FGCBFOCODMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2826680", Offset = "0x2825080", VA = "0x182826680")]
	private Func<CancellationToken, List<Task>> CNPPIOBEOOH(FDMJKHLGKCI FGCBFOCODMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2826140", Offset = "0x2824B40", VA = "0x182826140")]
	private List<Task> CNOFHDDCKJD(FDMJKHLGKCI FGCBFOCODMG, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x28267E0", Offset = "0x28251E0", VA = "0x1828267E0")]
	[AsyncStateMachine(typeof(FFOHCAPHFMB))]
	private Task ECNPMPDACEK(KABKKHLEJLC OEGIILCLJPE, FDMJKHLGKCI NIPBPKPBPPP, CancellationToken DEGCIHEAIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x28273A0", Offset = "0x2825DA0", VA = "0x1828273A0")]
	[AsyncStateMachine(typeof(EKGIFAINDIH))]
	private Task PENHNOCADOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2826C10", Offset = "0x2825610", VA = "0x182826C10")]
	private void IAHAIEIHBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x28274A0", Offset = "0x2825EA0", VA = "0x1828274A0")]
	public KHMKJJGGKAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[RecRoom.NoEngine.Common.Preserve]
internal class FDLEABACAOP : GAAHNJFFAEA, HLCHENPOKGP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct BOGCOANKBKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CMGFGGHOKOI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public FDLEABACAOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public LBGPKAJBJHG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x356EF20", Offset = "0x356D920", VA = "0x18356EF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct OMPDGNMFNDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public FDLEABACAOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public CMGFGGHOKOI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public LBGPKAJBJHG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private global::CLGKLANEGOH<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private CAFOCDOFHHK <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private LDHNPMLOCFA <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3580120", Offset = "0x357EB20", VA = "0x183580120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class GILBKEHMAJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public Task<BKIFJPHNINC> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public GILBKEHMAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		internal Task<BKIFJPHNINC> <ConnectToRoomAndRunLoadLogic>b__0(PPKCEHBLCJE _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct ACDJHGDDCHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public FDLEABACAOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public CMGFGGHOKOI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public PPKCEHBLCJE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public LBGPKAJBJHG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public CAFOCDOFHHK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private GILBKEHMAJA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private LFKPEHEHBKJ <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private PPKCEHBLCJE <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private ACIKGHAHCMJ <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private CancellationTokenSource <photonJoinedTokenSource>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationToken <photonJoinedToken>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private Task <roomLoadTask>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter<BKIFJPHNINC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x2E31970", Offset = "0x2E30370", VA = "0x182E31970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct NGFCMOFLAIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public FDLEABACAOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public PPKCEHBLCJE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private PPKCEHBLCJE <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private PPKCEHBLCJE <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x357EC70", Offset = "0x357D670", VA = "0x18357EC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct DLCFIFHHKDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public FDLEABACAOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private PLIBOCMCGIC <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3570BF0", Offset = "0x356F5F0", VA = "0x183570BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct KBMEMNHEPHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public PPKCEHBLCJE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public CMGFGGHOKOI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public FDLEABACAOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public CAFOCDOFHHK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private PPKCEHBLCJE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter<NBFHEPKIFIG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3578710", Offset = "0x3577110", VA = "0x183578710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class HDMOPKFAABF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public CMGFGGHOKOI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public HDMOPKFAABF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3574030", Offset = "0x3572A30", VA = "0x183574030")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3573F30", Offset = "0x3572930", VA = "0x183573F30")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct DGPKGEBFMGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public CMGFGGHOKOI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public FDLEABACAOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private HDMOPKFAABF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x3570030", Offset = "0x356EA30", VA = "0x183570030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct AAACEJPHKMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public PPKCEHBLCJE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public FDLEABACAOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public CAFOCDOFHHK joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public BKIFJPHNINC initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public CMGFGGHOKOI targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public LFKPEHEHBKJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private PPKCEHBLCJE <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2E31400", Offset = "0x2E2FE00", VA = "0x182E31400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct BNNHGKPFKOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public PPKCEHBLCJE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public FDLEABACAOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private PPKCEHBLCJE <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2E34310", Offset = "0x2E32D10", VA = "0x182E34310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct GHCDKAMFLIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public FDLEABACAOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public PPKCEHBLCJE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3573230", Offset = "0x3571C30", VA = "0x183573230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct KLNPLCBABLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public PPKCEHBLCJE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public FDLEABACAOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private PPKCEHBLCJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x35797A0", Offset = "0x35781A0", VA = "0x1835797A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct NCMBGJFBJBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public FDLEABACAOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<MPFEOFKMCLF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x357E550", Offset = "0x357CF50", VA = "0x18357E550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct MMBDIKKEFDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public FDLEABACAOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private PPKCEHBLCJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x357CFE0", Offset = "0x357B9E0", VA = "0x18357CFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class HIGKDFJDBFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public CMGFGGHOKOI targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public HIGKDFJDBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x3574130", Offset = "0x3572B30", VA = "0x183574130")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class IBKPOMDPJPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public IBKPOMDPJPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x35750D0", Offset = "0x3573AD0", VA = "0x1835750D0")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class PEAMBPMIGCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public CMGFGGHOKOI targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public PEAMBPMIGCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3580B40", Offset = "0x357F540", VA = "0x183580B40")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class ENGFLELDNJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public CMGFGGHOKOI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ENGFLELDNJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x35723D0", Offset = "0x3570DD0", VA = "0x1835723D0")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly string MPEBJBLPPPF;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly string CGHKOAGAJMD;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly string JKPNOGMNKPF;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly Guid DGMOFHNEHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private BCJAKJOCBPE CFGLODANGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private GLDIFALLLJC BKAPJEHMPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private ONLFOKFFMFG LNMHPEDOLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IIFGAMEMGIC EDFOBNPNANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private OBAMEKJKGCM PPOAHOFKJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private DOBDOPNBODM MPIMBMLNILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private MGDDGPMOLMK KJBMIMOPDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private FPBAPLBNEBI NIFCFEIBHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private IDisposable LBOIADKFLEG;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public TaskStatus HFEHCCDFOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA1F1C0", Offset = "0xA1DBC0", VA = "0x180A1F1C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xA1F1D0", Offset = "0xA1DBD0", VA = "0x180A1F1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private GDIIDHNMKBB FKJMHDJKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2815F50", Offset = "0x2814950", VA = "0x182815F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2816B00", Offset = "0x2815500", VA = "0x182816B00", Slot = "6")]
	public void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2815C40", Offset = "0x2814640", VA = "0x182815C40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2817910", Offset = "0x2816310", VA = "0x182817910", Slot = "5")]
	[AsyncStateMachine(typeof(BOGCOANKBKN))]
	public Task KGNOFNFAJDJ(CMGFGGHOKOI IDOFMJNBFAM, LBGPKAJBJHG ODICGJJDDAC, CancellationToken HLIGFMLOMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2816410", Offset = "0x2814E10", VA = "0x182816410")]
	[AsyncStateMachine(typeof(OMPDGNMFNDD))]
	private Task GDLOGBDAHDC(CMGFGGHOKOI IDOFMJNBFAM, LBGPKAJBJHG ODICGJJDDAC, CancellationToken HLIGFMLOMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x2817750", Offset = "0x2816150", VA = "0x182817750")]
	private static void KFDIIKCONFC(CMGFGGHOKOI IDOFMJNBFAM, Exception IJOOFLECOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x2817F10", Offset = "0x2816910", VA = "0x182817F10")]
	private static void NCCPJOFKELO(LDHNPMLOCFA FAFPJGOJAMI, Exception IJOOFLECOBD, [Optional] List<int> JDDOMMKLDIJ, int NICKLHNDBHJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x2816570", Offset = "0x2814F70", VA = "0x182816570")]
	[AsyncStateMachine(typeof(ACDJHGDDCHL))]
	private Task GPNKMDIIGNG(PPKCEHBLCJE CEJBHGLMENF, CMGFGGHOKOI IDOFMJNBFAM, LBGPKAJBJHG ODICGJJDDAC, CAFOCDOFHHK FLJAJCDFJIB, CancellationToken HLIGFMLOMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x28166F0", Offset = "0x28150F0", VA = "0x1828166F0")]
	private void HBFJCHIBPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x2817610", Offset = "0x2816010", VA = "0x182817610")]
	[AsyncStateMachine(typeof(NGFCMOFLAIE))]
	private Task KEJPBFGIEMF(PPKCEHBLCJE CEJBHGLMENF, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x28172C0", Offset = "0x2815CC0", VA = "0x1828172C0")]
	private void KCHBANHNFKL(CMGFGGHOKOI IDOFMJNBFAM, CancellationToken HLIGFMLOMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x2817C50", Offset = "0x2816650", VA = "0x182817C50")]
	private void NAHBGLLFGMA(CMGFGGHOKOI IDOFMJNBFAM, CAFOCDOFHHK FLJAJCDFJIB, OperationCanceledException NOCIMJKKOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x2815FA0", Offset = "0x28149A0", VA = "0x182815FA0")]
	private void FJPNDLGFPHL(CMGFGGHOKOI IDOFMJNBFAM, CAFOCDOFHHK FLJAJCDFJIB, Exception IJOOFLECOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x2815910", Offset = "0x2814310", VA = "0x182815910")]
	private void BPMGAMINAHH(CMGFGGHOKOI IDOFMJNBFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x2815740", Offset = "0x2814140", VA = "0x182815740")]
	private static BHPLPOAJICO BEEKNJMEOEB(CMGFGGHOKOI IDOFMJNBFAM)
	{
		return default(BHPLPOAJICO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x2818750", Offset = "0x2817150", VA = "0x182818750")]
	[AsyncStateMachine(typeof(DLCFIFHHKDA))]
	private Task OKBDCLNPDPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2817BA0", Offset = "0x28165A0", VA = "0x182817BA0")]
	private static NBFHEPKIFIG LOMCKCEIMHD(CMGFGGHOKOI IDOFMJNBFAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x28155D0", Offset = "0x2813FD0", VA = "0x1828155D0")]
	[AsyncStateMachine(typeof(KBMEMNHEPHC))]
	private Task BBKJNMGNBNK(CMGFGGHOKOI IDOFMJNBFAM, CAFOCDOFHHK FLJAJCDFJIB, PPKCEHBLCJE CEJBHGLMENF, CancellationToken EPLLLGAGFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2818850", Offset = "0x2817250", VA = "0x182818850")]
	[AsyncStateMachine(typeof(DGPKGEBFMGO))]
	private Task OKJIFKGPDLD(CMGFGGHOKOI IDOFMJNBFAM, CancellationTokenSource JMBNOMMABMO, Task KKAPAKEJMAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2815DC0", Offset = "0x28147C0", VA = "0x182815DC0")]
	[AsyncStateMachine(typeof(AAACEJPHKMA))]
	private Task FFFBKHKBDPE(BKIFJPHNINC IBAGMGEICEB, LFKPEHEHBKJ OGLFEHBCGHJ, CMGFGGHOKOI JCBNALBNDLG, CAFOCDOFHHK KPLADMCNGDD, PPKCEHBLCJE CEJBHGLMENF, CancellationToken FJIKNELGDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x28168B0", Offset = "0x28152B0", VA = "0x1828168B0")]
	private CAFOCDOFHHK IMFCGFBAELE(CAFOCDOFHHK KPLADMCNGDD, ref CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2816F20", Offset = "0x2815920", VA = "0x182816F20")]
	[AsyncStateMachine(typeof(BNNHGKPFKOC))]
	private Task JHKEBMFIGJE(PPKCEHBLCJE CEJBHGLMENF, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2815C90", Offset = "0x2814690", VA = "0x182815C90")]
	[AsyncStateMachine(typeof(GHCDKAMFLIK))]
	private Task EKDMIFOEEAN(PPKCEHBLCJE CEJBHGLMENF, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2817A60", Offset = "0x2816460", VA = "0x182817A60")]
	[AsyncStateMachine(typeof(KLNPLCBABLM))]
	private Task KPBPACAPAPC(PPKCEHBLCJE CEJBHGLMENF, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x2818CC0", Offset = "0x28176C0", VA = "0x182818CC0")]
	[AsyncStateMachine(typeof(NCMBGJFBJBA))]
	private Task PGECJIAOPCE(FDMJKHLGKCI NIPBPKPBPPP, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2815490", Offset = "0x2813E90", VA = "0x182815490")]
	[AsyncStateMachine(typeof(MMBDIKKEFDJ))]
	private Task ANBFOOJILPI(PPKCEHBLCJE IFNGEGAGDGH, CancellationToken EPLLLGAGFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x28157A0", Offset = "0x28141A0", VA = "0x1828157A0")]
	private static void BJIMFPINMFF(CMGFGGHOKOI IDOFMJNBFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2817060", Offset = "0x2815A60", VA = "0x182817060")]
	private void JIMOANAJLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x28151C0", Offset = "0x2813BC0", VA = "0x1828151C0")]
	private void ADDHIBCBOLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x2817230", Offset = "0x2815C30", VA = "0x182817230")]
	private void JKKJEAEPGND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x2815BB0", Offset = "0x28145B0", VA = "0x182815BB0")]
	private void CFLDCOIBDEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2818B40", Offset = "0x2817540", VA = "0x182818B40")]
	private static void PAJMFKDBJOK(CMGFGGHOKOI IDOFMJNBFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2816350", Offset = "0x2814D50", VA = "0x182816350")]
	private static void GBKCFKEDGBM(CMGFGGHOKOI IDOFMJNBFAM, CancellationToken EPLLLGAGFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x28189B0", Offset = "0x28173B0", VA = "0x1828189B0")]
	private static void OLNJGJJHJCG(CMGFGGHOKOI IDOFMJNBFAM, Exception IJOOFLECOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2815250", Offset = "0x2813C50", VA = "0x182815250")]
	private void AFDOJCAHFJA(CMGFGGHOKOI IDOFMJNBFAM, Task KKAPAKEJMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x2816260", Offset = "0x2814C60", VA = "0x182816260")]
	private static void FOPPOIAFNDG(Func<string> DBIMPNPPPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x2818EF0", Offset = "0x28178F0", VA = "0x182818EF0")]
	public FDLEABACAOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[UnityEngine.Scripting.Preserve]
internal sealed class ALAGBBCKDMM : DJKFCMHMKGF, HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class BEPOIFIICPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public BEPOIFIICPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2E33B00", Offset = "0x2E32500", VA = "0x182E33B00")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class HKNHFJFHMHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public HKNHFJFHMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2E38160", Offset = "0x2E36B60", VA = "0x182E38160")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class LFBLGCKLNEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public LFBLGCKLNEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A030", Offset = "0x2E38A30", VA = "0x182E3A030")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class KBFCLODCEBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public KBFCLODCEBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2E38D50", Offset = "0x2E37750", VA = "0x182E38D50")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class LNIBELMCHHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public LNIBELMCHHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2E3CAF0", Offset = "0x2E3B4F0", VA = "0x182E3CAF0")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private readonly Dictionary<Guid, HKNCDDMGNEG> FOGNHMGNHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private readonly TimeSpan JOHIKCHJNHD;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "10")]
	public void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2807CF0", Offset = "0x28066F0", VA = "0x182807CF0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2807A50", Offset = "0x2806450", VA = "0x182807A50", Slot = "4")]
	public MLBDJHDHBDH CPLOAHMOJFD(Guid EPCIDCJCNKD)
	{
		return default(MLBDJHDHBDH);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x28086B0", Offset = "0x28070B0", VA = "0x1828086B0", Slot = "5")]
	public bool OLCIACFECIH(Guid EPCIDCJCNKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x28080D0", Offset = "0x2806AD0", VA = "0x1828080D0", Slot = "8")]
	public bool IAHAIEIHBPC(Guid EPCIDCJCNKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2807D00", Offset = "0x2806700", VA = "0x182807D00", Slot = "6")]
	public bool GKIHEPPEAAC(Guid EPCIDCJCNKD, Task PDLCBPCEPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2808350", Offset = "0x2806D50", VA = "0x182808350", Slot = "7")]
	public bool IIHBJGFHELI(Guid EPCIDCJCNKD, MPFEOFKMCLF FHLMNCKDHLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2808620", Offset = "0x2807020", VA = "0x182808620", Slot = "9")]
	public Task<(MPFEOFKMCLF, Task)> LAFFJAHJEJL(Guid EPCIDCJCNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2807790", Offset = "0x2806190", VA = "0x182807790")]
	private void AONABFMHNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x2808970", Offset = "0x2807370", VA = "0x182808970")]
	public ALAGBBCKDMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[UnityEngine.Scripting.Preserve]
internal class KOJAAGEFEKN : PMIFGFAHMGD, HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private class FDLBKGEABGH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private readonly CMGFGGHOKOI KDPHPMIMGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private readonly CancellationTokenSource FPCHIMCODNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public readonly CancellationToken JNNIGPBBPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private bool KLBHDDLNIHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private bool IAFLCEPGHIO;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x3572AD0", Offset = "0x35714D0", VA = "0x183572AD0")]
		public FDLBKGEABGH(CMGFGGHOKOI KDPHPMIMGMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x3572980", Offset = "0x3571380", VA = "0x183572980")]
		public void IAHAIEIHBPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x3572950", Offset = "0x3571350", VA = "0x183572950", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class EGDPBMILFDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public FBEKEDLLFLL disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public EGDPBMILFDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x35717D0", Offset = "0x35701D0", VA = "0x1835717D0")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct IIDNCLEFCNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public FBEKEDLLFLL disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public KOJAAGEFEKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x35751A0", Offset = "0x3573BA0", VA = "0x1835751A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class DHNKKFNKJPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public DHNKKFNKJPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x3570B80", Offset = "0x356F580", VA = "0x183570B80")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct LCKGMCKGNNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public KOJAAGEFEKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x3579A60", Offset = "0x3578460", VA = "0x183579A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6CAAD0", Offset = "0x6C94D0", VA = "0x1806CAAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class GALBCLBENMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public CMGFGGHOKOI newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public GALBCLBENMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3573110", Offset = "0x3571B10", VA = "0x183573110")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x35731B0", Offset = "0x3571BB0", VA = "0x1835731B0")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x35731F0", Offset = "0x3571BF0", VA = "0x1835731F0")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class GACDHPDHDCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public GACDHPDHDCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x3573070", Offset = "0x3571A70", VA = "0x183573070")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct BKECEAJKOBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public CMGFGGHOKOI newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public KOJAAGEFEKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public LBGPKAJBJHG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private GALBCLBENMB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x356DF70", Offset = "0x356C970", VA = "0x18356DF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private GLDIFALLLJC BKAPJEHMPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private OBAMEKJKGCM PPOAHOFKJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private IIFGAMEMGIC EDFOBNPNANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private FPBAPLBNEBI NIFCFEIBHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private GAAHNJFFAEA IMLFFCHBOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private long JGIIOMODMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private FDLBKGEABGH FGNOPOHLIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private bool CAAFOIPNDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private Task NNOGEDOMOOF;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private GDIIDHNMKBB FKJMHDJKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2827D90", Offset = "0x2826790", VA = "0x182827D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool BCMBCHHHCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1068E10", Offset = "0x1067810", VA = "0x181068E10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x28279B0", Offset = "0x28263B0", VA = "0x1828279B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x28280C0", Offset = "0x2826AC0", VA = "0x1828280C0", Slot = "4")]
	public void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2827C10", Offset = "0x2826610", VA = "0x182827C10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2827DE0", Offset = "0x28267E0", VA = "0x182827DE0")]
	[AsyncStateMachine(typeof(IIDNCLEFCNM))]
	private Task FNKLMIIPDAO(FBEKEDLLFLL HAICOBCMOFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2827790", Offset = "0x2826190", VA = "0x182827790")]
	private void CLIHEAMLEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2828310", Offset = "0x2826D10", VA = "0x182828310")]
	private void JPCLJMHDGLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2827A00", Offset = "0x2826400", VA = "0x182827A00")]
	private void DNJALILPBKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2828040", Offset = "0x2826A40", VA = "0x182828040")]
	private bool HDAJCBGCDPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x28276A0", Offset = "0x28260A0", VA = "0x1828276A0")]
	[AsyncStateMachine(typeof(LCKGMCKGNNE))]
	private void CKFFMEIFEEE(int OACKGFKLPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2828530", Offset = "0x2826F30", VA = "0x182828530")]
	private void KLLBFBMGHKG(out IDisposable BFDGFMPKFCM, out IDisposable COJHHHHGPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x28288F0", Offset = "0x28272F0", VA = "0x1828288F0")]
	private bool MPHJCCDOLMI(CMGFGGHOKOI KDPHPMIMGMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x28279C0", Offset = "0x28263C0", VA = "0x1828279C0")]
	private void DLGLIKEIFFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2827F00", Offset = "0x2826900", VA = "0x182827F00")]
	[AsyncStateMachine(typeof(BKECEAJKOBB))]
	private Task GDLOGBDAHDC(CMGFGGHOKOI KDPHPMIMGMF, LBGPKAJBJHG ODICGJJDDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x2828A80", Offset = "0x2827480", VA = "0x182828A80")]
	public KOJAAGEFEKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[UnityEngine.Scripting.Preserve]
internal sealed class NCCHALJMHJK : HDEGNFEFHDD, HLCHENPOKGP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct EHENLKFMDMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public AsyncTaskMethodBuilder<KLANEEMABFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public NCCHALJMHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private TaskAwaiter<KLANEEMABFB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x407ADB0", Offset = "0x40797B0", VA = "0x18407ADB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x407B000", Offset = "0x4079A00", VA = "0x18407B000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class LNNOBIOEGOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public CBPIBEEEMBL message;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public LNNOBIOEGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x4081720", Offset = "0x4080120", VA = "0x184081720")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class JEKMHKGEABC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public CBPIBEEEMBL messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public JEKMHKGEABC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x4080700", Offset = "0x407F100", VA = "0x184080700")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class GINOGECHJPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public CBPIBEEEMBL request;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public GINOGECHJPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x407E1A0", Offset = "0x407CBA0", VA = "0x18407E1A0")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct MNDOHGEAJHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public CBPIBEEEMBL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public NCCHALJMHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private TaskAwaiter<BLIAEEPMOEN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x4082CD0", Offset = "0x40816D0", VA = "0x184082CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class GHGGMNGKLPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public CBPIBEEEMBL operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public GHGGMNGKLPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x407E140", Offset = "0x407CB40", VA = "0x18407E140")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct CADNIDGGENH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public CBPIBEEEMBL operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public NCCHALJMHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private CAFOCDOFHHK <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter<CBPIBEEEMBL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x4079640", Offset = "0x4078040", VA = "0x184079640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct JGIIPFCFBEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public AsyncTaskMethodBuilder<BLIAEEPMOEN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public NCCHALJMHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public CBPIBEEEMBL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private CAFOCDOFHHK <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<CBPIBEEEMBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x4080760", Offset = "0x407F160", VA = "0x184080760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x4080BB0", Offset = "0x407F5B0", VA = "0x184080BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class ELDFJJMIFCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public BLIAEEPMOEN operation;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ELDFJJMIFCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x407BC40", Offset = "0x407A640", VA = "0x18407BC40")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct OODBFIFCMCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public BLIAEEPMOEN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public NCCHALJMHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private global::CLGKLANEGOH<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x4085030", Offset = "0x4083A30", VA = "0x184085030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class KGGOJKPCIIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public CBPIBEEEMBL request;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public KGGOJKPCIIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x4081590", Offset = "0x407FF90", VA = "0x184081590")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class IGOBAKJALDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public CBPIBEEEMBL request;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public IGOBAKJALDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x407FA80", Offset = "0x407E480", VA = "0x18407FA80")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private DOBDOPNBODM MPIMBMLNILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private BKNECNMLLAN BEJGEJIOJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private BJMNMMHLEFF KDOGACEGKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private ONLFOKFFMFG LNMHPEDOLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private TaskCompletionSource<KLANEEMABFB> EFEIPJPLHGJ;

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2E413A0", Offset = "0x2E3FDA0", VA = "0x182E413A0", Slot = "7")]
	public void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2E40BA0", Offset = "0x2E3F5A0", VA = "0x182E40BA0", Slot = "6")]
	[AsyncStateMachine(typeof(EHENLKFMDMA))]
	public Task<KLANEEMABFB> CNCONPCIKKL(CancellationToken PKBPNBMKIFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2E41700", Offset = "0x2E40100", VA = "0x182E41700", Slot = "4")]
	public void NLNNLCBPMLN(CBPIBEEEMBL EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2E40510", Offset = "0x2E3EF10", VA = "0x182E40510", Slot = "5")]
	public void ABHKFKEJPHL(CBPIBEEEMBL MJHKMGHPLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2E41140", Offset = "0x2E3FB40", VA = "0x182E41140")]
	[AsyncStateMachine(typeof(MNDOHGEAJHD))]
	private Task IDFNOKEOMBB(CBPIBEEEMBL NONPDGFJDAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2E41270", Offset = "0x2E3FC70", VA = "0x182E41270")]
	[AsyncStateMachine(typeof(CADNIDGGENH))]
	private Task IGAJAIDGJNO(CBPIBEEEMBL NOKAAOMALGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2E415B0", Offset = "0x2E3FFB0", VA = "0x182E415B0")]
	[AsyncStateMachine(typeof(JGIIPFCFBEL))]
	private Task<BLIAEEPMOEN> LBACAMNPJKE(CBPIBEEEMBL NONPDGFJDAK, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2E410C0", Offset = "0x2E3FAC0", VA = "0x182E410C0")]
	private CAFOCDOFHHK EBDJOMKEBKI(CBPIBEEEMBL IKJODENKJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2E41480", Offset = "0x2E3FE80", VA = "0x182E41480")]
	[AsyncStateMachine(typeof(OODBFIFCMCI))]
	private Task JLHEHAMCMHJ(BLIAEEPMOEN LDDMJCCAAEJ, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2E40920", Offset = "0x2E3F320", VA = "0x182E40920")]
	private BLIAEEPMOEN AGMDOFCNKMO(CBPIBEEEMBL NONPDGFJDAK, CAFOCDOFHHK NNBGOFHFNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2BEF560", Offset = "0x2BEDF60", VA = "0x182BEF560")]
	private T EOGANPFMHBL<T>(T MNIAGKNOHEJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2E40CE0", Offset = "0x2E3F6E0", VA = "0x182E40CE0")]
	private BLIAEEPMOEN DGCNMOHNGMI(CBPIBEEEMBL NONPDGFJDAK, CAFOCDOFHHK NNBGOFHFNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public NCCHALJMHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2E41B40", Offset = "0x2E40540", VA = "0x182E41B40")]
	[CompilerGenerated]
	private void PHGLEPOLHNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[UnityEngine.Scripting.Preserve]
internal sealed class DLFLIADNLCF : BKNECNMLLAN, HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class NNDKDDKDEFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public NNDKDDKDEFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x2E42320", Offset = "0x2E40D20", VA = "0x182E42320")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class MNCKINDIKFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public MNCKINDIKFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x2E3F2C0", Offset = "0x2E3DCC0", VA = "0x182E3F2C0")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private ONLFOKFFMFG LNMHPEDOLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private EPEFGOAMBLL BKHEOALBIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private HDEGNFEFHDD FALMKJIBDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private DJKFCMHMKGF FOGNHMGNHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private PCFAGBJEOFC ECOABCAHCAH;

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2811650", Offset = "0x2810050", VA = "0x182811650", Slot = "6")]
	public void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2811070", Offset = "0x280FA70", VA = "0x182811070", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x28117C0", Offset = "0x28101C0", VA = "0x1828117C0", Slot = "4")]
	public MLBDJHDHBDH JNFAGJLAENC(CBPIBEEEMBL NJJHMBBHFOJ)
	{
		return default(MLBDJHDHBDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2812710", Offset = "0x2811110", VA = "0x182812710", Slot = "5")]
	public void MPBANNDMHDL(Guid EPCIDCJCNKD, Task PDLCBPCEPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x28109B0", Offset = "0x280F3B0", VA = "0x1828109B0")]
	private void ALCMMCGCPMJ(byte NLMDNLDJIGP, int ANHHDEJOADH, object KLHHFLEELNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2811CC0", Offset = "0x28106C0", VA = "0x182811CC0")]
	private void LILCJHPJNCA(GFMBDLPCLFD PHDLBHDMOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2810D90", Offset = "0x280F790", VA = "0x182810D90")]
	private void DAEPLMEDECF(GFMBDLPCLFD PHDLBHDMOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2812990", Offset = "0x2811390", VA = "0x182812990")]
	private void NLCIOMMGGHJ(GFMBDLPCLFD PHDLBHDMOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x2812C50", Offset = "0x2811650", VA = "0x182812C50")]
	private MPFEOFKMCLF NNOJAGNJPIL(CBPIBEEEMBL IKJODENKJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x28113F0", Offset = "0x280FDF0", VA = "0x1828113F0")]
	private void HAGELELNHCJ(CBPIBEEEMBL NOKAAOMALGO, MPFEOFKMCLF FHLMNCKDHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x2810A80", Offset = "0x280F480", VA = "0x182810A80")]
	private bool BNINFKGIBNL(CBPIBEEEMBL NOKAAOMALGO, MPFEOFKMCLF FHLMNCKDHLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x2811110", Offset = "0x280FB10", VA = "0x182811110")]
	private bool FFAPOHKKOMF(CBPIBEEEMBL LKNFDABDGEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2812400", Offset = "0x2810E00", VA = "0x182812400")]
	private bool MBOHLJCPALI(byte NLMDNLDJIGP, ExitGames.Client.Photon.Hashtable PHDLBHDMOFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public DLFLIADNLCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[UnityEngine.Scripting.Preserve]
internal sealed class EFHKDNBICNN : CIBJEAPNFBB, HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class FCBFBHIKNNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public KLANEEMABFB operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public EFHKDNBICNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public CBPIBEEEMBL roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public FCBFBHIKNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2E36700", Offset = "0x2E35100", VA = "0x182E36700")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x2E36770", Offset = "0x2E35170", VA = "0x182E36770")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct PAMINAMMAKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public AsyncTaskMethodBuilder<MPFEOFKMCLF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public EFHKDNBICNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public CBPIBEEEMBL roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter<MPFEOFKMCLF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2E46060", Offset = "0x2E44A60", VA = "0x182E46060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x2E465F0", Offset = "0x2E44FF0", VA = "0x182E465F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class EOLOHDBGDDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public KLANEEMABFB operationType;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public EOLOHDBGDDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2E36690", Offset = "0x2E35090", VA = "0x182E36690")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class MBBFJDFAAMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public CBPIBEEEMBL request;

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public MBBFJDFAAMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2E3CB50", Offset = "0x2E3B550", VA = "0x182E3CB50")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2E3CBC0", Offset = "0x2E3B5C0", VA = "0x182E3CBC0")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2E3CC30", Offset = "0x2E3B630", VA = "0x182E3CC30")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct GCHFHDAKBGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public AsyncTaskMethodBuilder<MPFEOFKMCLF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public CBPIBEEEMBL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public EFHKDNBICNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private MBBFJDFAAMG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private MLBDJHDHBDH <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private MPFEOFKMCLF <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private TaskAwaiter<(MPFEOFKMCLF validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2E36F60", Offset = "0x2E35960", VA = "0x182E36F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x2E376A0", Offset = "0x2E360A0", VA = "0x182E376A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private ONLFOKFFMFG LNMHPEDOLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private EPEFGOAMBLL BKHEOALBIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private BKNECNMLLAN BEJGEJIOJNK;

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2813C90", Offset = "0x2812690", VA = "0x182813C90", Slot = "5")]
	public void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2813D40", Offset = "0x2812740", VA = "0x182813D40", Slot = "4")]
	[AsyncStateMachine(typeof(PAMINAMMAKH))]
	private Task<MPFEOFKMCLF> LNBHEFLJNIM(CBPIBEEEMBL IKJODENKJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x2813E80", Offset = "0x2812880", VA = "0x182813E80")]
	private bool NMKOFFFICHM(KLANEEMABFB EPLCJFLCJCI, out MPFEOFKMCLF OAFMFLFMLNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2814100", Offset = "0x2812B00", VA = "0x182814100")]
	[AsyncStateMachine(typeof(GCHFHDAKBGD))]
	private Task<MPFEOFKMCLF> ODMABJIGEPI(CBPIBEEEMBL NONPDGFJDAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public EFHKDNBICNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class OEHEFGLHJEI : CFOAOPPKJBC, HLCHENPOKGP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct APMAOJDDFJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<BKIFJPHNINC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public CMGFGGHOKOI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public OEHEFGLHJEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private TaskAwaiter<BIHOLPOPBIG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x40790B0", Offset = "0x4077AB0", VA = "0x1840790B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x4079290", Offset = "0x4077C90", VA = "0x184079290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class FMIPBFPBPKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public FMIPBFPBPKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x407CA70", Offset = "0x407B470", VA = "0x18407CA70")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct LPKFCLOCHBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<BIHOLPOPBIG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public OEHEFGLHJEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public CMGFGGHOKOI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private FMIPBFPBPKA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter<FPIHCDKPOGD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x4081B70", Offset = "0x4080570", VA = "0x184081B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x4081FC0", Offset = "0x40809C0", VA = "0x184081FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class PAOJEKDCILG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public PAOJEKDCILG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x10FACE0", Offset = "0x10F96E0", VA = "0x1810FACE0")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(CKHPNKKDHCH sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private IIFGAMEMGIC EDFOBNPNANH;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly (BDADFHIJBPJ superRoomData, string unityAssetId, BDADFHIJBPJ subRoomData) DAPEKBFJLNG;

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2E42DC0", Offset = "0x2E417C0", VA = "0x182E42DC0", Slot = "5")]
	public void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2E42E30", Offset = "0x2E41830", VA = "0x182E42E30", Slot = "4")]
	[AsyncStateMachine(typeof(APMAOJDDFJE))]
	public Task<BKIFJPHNINC> KJJPPFJABPD(PPKCEHBLCJE IFNGEGAGDGH, CMGFGGHOKOI IDOFMJNBFAM, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2E42C40", Offset = "0x2E41640", VA = "0x182E42C40")]
	[AsyncStateMachine(typeof(LPKFCLOCHBI))]
	private Task<BIHOLPOPBIG> FCCAEMHHNGJ(CMGFGGHOKOI IDOFMJNBFAM, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2E42AB0", Offset = "0x2E414B0", VA = "0x182E42AB0")]
	private BKIFJPHNINC DKKDMGIPNNA(CMGFGGHOKOI IDOFMJNBFAM, BIHOLPOPBIG LFALKNKLGGD, long DJKGICGFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2E42FB0", Offset = "0x2E419B0", VA = "0x182E42FB0")]
	private (BDADFHIJBPJ, string, BDADFHIJBPJ) MBIFMILGDAJ(CMGFGGHOKOI IDOFMJNBFAM, BIHOLPOPBIG LFALKNKLGGD, long DJKGICGFGOE)
	{
		return default((BDADFHIJBPJ, string, BDADFHIJBPJ));
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public OEHEFGLHJEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal sealed class BHOHLOJPGGN : BJMNMMHLEFF, HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class EMDFOBENLBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public CBPIBEEEMBL request;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public EMDFOBENLBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x2E36630", Offset = "0x2E35030", VA = "0x182E36630")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct NNBAPBBKEEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<CBPIBEEEMBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public CBPIBEEEMBL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public BHOHLOJPGGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public CAFOCDOFHHK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private TaskAwaiter<CBPIBEEEMBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2E41E50", Offset = "0x2E40850", VA = "0x182E41E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2E422D0", Offset = "0x2E40CD0", VA = "0x182E422D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct KEFDIKBHBAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public AsyncTaskMethodBuilder<CBPIBEEEMBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public BHOHLOJPGGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public CAFOCDOFHHK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<OFBMBPBFHMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x2E38DB0", Offset = "0x2E377B0", VA = "0x182E38DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x2E39390", Offset = "0x2E37D90", VA = "0x182E39390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class LFMGPMICIOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public CBPIBEEEMBL request;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public LFMGPMICIOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A090", Offset = "0x2E38A90", VA = "0x182E3A090")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct PLPGDPGNLHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public AsyncTaskMethodBuilder<CBPIBEEEMBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public CBPIBEEEMBL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public BHOHLOJPGGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public CAFOCDOFHHK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private DKPFGBILKAL <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private NMCAIPBHFAL <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<OFBMBPBFHMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x2E494A0", Offset = "0x2E47EA0", VA = "0x182E494A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2E49F30", Offset = "0x2E48930", VA = "0x182E49F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private ONLFOKFFMFG LNMHPEDOLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private LNOBPJKHKLG OJANFKJGNFC;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private DFAGGIFGJFA KNFEBGIEFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x280AF90", Offset = "0x2809990", VA = "0x18280AF90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x280B1C0", Offset = "0x2809BC0", VA = "0x18280B1C0", Slot = "8")]
	public void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x280AE20", Offset = "0x2809820", VA = "0x18280AE20", Slot = "4")]
	[AsyncStateMachine(typeof(NNBAPBBKEEO))]
	public Task<CBPIBEEEMBL> ALCPDMOLDNI(CBPIBEEEMBL NONPDGFJDAK, CAFOCDOFHHK NNBGOFHFNND, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x280B250", Offset = "0x2809C50", VA = "0x18280B250", Slot = "5")]
	[AsyncStateMachine(typeof(KEFDIKBHBAO))]
	public Task<CBPIBEEEMBL> KEAPGKKGDEF(CancellationToken KAKEKEHNCME, CAFOCDOFHHK NNBGOFHFNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x280B640", Offset = "0x280A040", VA = "0x18280B640", Slot = "6")]
	public PHJKBIIFKDP PMPANJGBKMJ(BLIAEEPMOEN ECNKEMNJLAN, PPKCEHBLCJE IFNGEGAGDGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x280B3B0", Offset = "0x2809DB0", VA = "0x18280B3B0", Slot = "7")]
	public PHJKBIIFKDP LEGIAKKDMJB(BLIAEEPMOEN ECNKEMNJLAN, PPKCEHBLCJE IFNGEGAGDGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x280B040", Offset = "0x2809A40", VA = "0x18280B040")]
	[AsyncStateMachine(typeof(PLPGDPGNLHL))]
	private Task<CBPIBEEEMBL> ICHKFDNHNKN(CBPIBEEEMBL NONPDGFJDAK, CAFOCDOFHHK NNBGOFHFNND, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x280B4E0", Offset = "0x2809EE0", VA = "0x18280B4E0")]
	private static byte[] LKKHJPLOLKJ(CBPIBEEEMBL EJEIJOMMNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x280B4F0", Offset = "0x2809EF0", VA = "0x18280B4F0")]
	private static string PHCNHAGGBMP(byte[] NGMLAIALNFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public BHOHLOJPGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[UnityEngine.Scripting.Preserve]
internal sealed class GLBBPDNACFL : EPEFGOAMBLL, HLCHENPOKGP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private IJGBLFJOLIK AJGODMCHCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private ONLFOKFFMFG LNMHPEDOLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private DOBDOPNBODM MPIMBMLNILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private JOEODCEIBNN BCNJCEJEHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private IIFGAMEMGIC EDFOBNPNANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private GAAHNJFFAEA IMLFFCHBOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private GKAGLKPIBLL CADMCPODFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private FPBAPLBNEBI NIFCFEIBHMP;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private GDIIDHNMKBB FKJMHDJKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x281C970", Offset = "0x281B370", VA = "0x18281C970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private static MPFEOFKMCLF MBCLGAIFBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x280D110", Offset = "0x280BB10", VA = "0x18280D110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x281CE60", Offset = "0x281B860", VA = "0x18281CE60", Slot = "7")]
	public void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x281CFC0", Offset = "0x281B9C0", VA = "0x18281CFC0", Slot = "4")]
	public MPFEOFKMCLF KHKGIJMFLLE(BNMLLFBMDOA LHPLFHANPPB, KLANEEMABFB EKGFPKDOIBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x281CBE0", Offset = "0x281B5E0", VA = "0x18281CBE0", Slot = "5")]
	public MPFEOFKMCLF GJAACCDLNBK(BNMLLFBMDOA BJOEAAODKCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x281C9C0", Offset = "0x281B3C0", VA = "0x18281C9C0", Slot = "6")]
	public MPFEOFKMCLF FLJJODPLDLO(BNMLLFBMDOA BJOEAAODKCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x280D0B0", Offset = "0x280BAB0", VA = "0x18280D0B0")]
	private static MPFEOFKMCLF JJDOAPFIOKJ(OAPFICFJIOF JMBFNCMEOEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public GLBBPDNACFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class NADEELNAPCG : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2E3FA80", Offset = "0x2E3E480", VA = "0x182E3FA80")]
	public NADEELNAPCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xC36660", Offset = "0xC35060", VA = "0x180C36660")]
	public NADEELNAPCG(string EJEIJOMMNGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class BGAMJCKOKFI : PPAMFDIKOID, HLCHENPOKGP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct BMEPGGKOBMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public AsyncTaskMethodBuilder<MPFEOFKMCLF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public BGAMJCKOKFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public BMIHFLGADPJ autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private global::CLGKLANEGOH<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private PPKCEHBLCJE <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private OABBKNEEALB <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private PPKCEHBLCJE <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<MPFEOFKMCLF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x2E33B60", Offset = "0x2E32560", VA = "0x182E33B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x2E342C0", Offset = "0x2E32CC0", VA = "0x182E342C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct EHFANMPEHIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public BGAMJCKOKFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x2E35AD0", Offset = "0x2E344D0", VA = "0x182E35AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct FDNIJCCGAKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public BGAMJCKOKFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x2E369B0", Offset = "0x2E353B0", VA = "0x182E369B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct JIAAJOMGLAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public BGAMJCKOKFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x2E38980", Offset = "0x2E37380", VA = "0x182E38980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct NABGDGPCLJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public BGAMJCKOKFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x2E3F330", Offset = "0x2E3DD30", VA = "0x182E3F330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct OMDHFMMCDEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public BGAMJCKOKFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public EJAEMPHNCCB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private global::CLGKLANEGOH<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x2E458C0", Offset = "0x2E442C0", VA = "0x182E458C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private static readonly TimeSpan ODCGGEPONLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private ONLFOKFFMFG LNMHPEDOLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private IIFGAMEMGIC EDFOBNPNANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private BJMNMMHLEFF KDOGACEGKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private DOBDOPNBODM MPIMBMLNILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private GKAGLKPIBLL CADMCPODFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private CancellationTokenSource BFMGDKEOLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private Task FFNKJKEHJNG;

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x280A360", Offset = "0x2808D60", VA = "0x18280A360", Slot = "6")]
	public void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x1277030", Offset = "0x1275A30", VA = "0x181277030", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x280AB60", Offset = "0x2809560", VA = "0x18280AB60", Slot = "4")]
	[AsyncStateMachine(typeof(BMEPGGKOBMH))]
	public Task<MPFEOFKMCLF> PHJCGCNEJGP(BMIHFLGADPJ LKDJBANFPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x280A120", Offset = "0x2808B20", VA = "0x18280A120", Slot = "5")]
	[AsyncStateMachine(typeof(EHFANMPEHIM))]
	public Task JDCIKCCGBGM([Optional] CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1277030", Offset = "0x1275A30", VA = "0x181277030")]
	public void GKDHNKIMHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x280A950", Offset = "0x2809350", VA = "0x18280A950")]
	private OABBKNEEALB NEFMJBANLCD(BMIHFLGADPJ LKDJBANFPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x280A820", Offset = "0x2809220", VA = "0x18280A820")]
	[AsyncStateMachine(typeof(FDNIJCCGAKJ))]
	private Task MOIOMJKKDAC(FDMJKHLGKCI PAGKANKNAEA, CancellationToken HLIGFMLOMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x280A240", Offset = "0x2808C40", VA = "0x18280A240")]
	[AsyncStateMachine(typeof(JIAAJOMGLAO))]
	private Task JFDDACILIDA([Optional] CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2809EC0", Offset = "0x28088C0", VA = "0x182809EC0")]
	[AsyncStateMachine(typeof(NABGDGPCLJF))]
	private Task HOMFHIDCDKH(TimeSpan GHNBICMEHFJ, CancellationToken HLIGFMLOMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x280A5B0", Offset = "0x2808FB0", VA = "0x18280A5B0")]
	private Task MAHEBBJHKGA(EJAEMPHNCCB ADIFNIMFLJN, CancellationToken HLIGFMLOMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2809FF0", Offset = "0x28089F0", VA = "0x182809FF0")]
	[AsyncStateMachine(typeof(OMDHFMMCDEM))]
	private Task IHKALHHPKEK(EJAEMPHNCCB ADIFNIMFLJN, CancellationToken HLIGFMLOMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x280ACA0", Offset = "0x28096A0", VA = "0x18280ACA0")]
	private bool PNHDFFMCHDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public BGAMJCKOKFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[UnityEngine.Scripting.Preserve]
internal class LENMIABIIAL : JOEODCEIBNN, HLCHENPOKGP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct CNBFAGEMLDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public LENMIABIIAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private global::CLGKLANEGOH<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x356F7E0", Offset = "0x356E1E0", VA = "0x18356F7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private LBNBLMOGAPL JJCLJDAGLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private EPEFGOAMBLL BKHEOALBIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private BJMNMMHLEFF KDOGACEGKJM;

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2E39DA0", Offset = "0x2E387A0", VA = "0x182E39DA0", Slot = "6")]
	public void JGKFDHOAMGH(AHOGOPJAAEB BPCKLHHCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2E39C30", Offset = "0x2E38630", VA = "0x182E39C30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2E39C80", Offset = "0x2E38680", VA = "0x182E39C80", Slot = "5")]
	[AsyncStateMachine(typeof(CNBFAGEMLDD))]
	public Task GEDLCCHBHGL(string NKNOOFILFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2E39FD0", Offset = "0x2E389D0", VA = "0x182E39FD0", Slot = "4")]
	public MPFEOFKMCLF PNHDFFMCHDL(BNMLLFBMDOA LHPLFHANPPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2E39AE0", Offset = "0x2E384E0", VA = "0x182E39AE0")]
	private PJGBKAGBAHD CLACDOFLGBH(string NKNOOFILFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public LENMIABIIAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class HIJEILPEIKK
{
	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x281F340", Offset = "0x281DD40", VA = "0x18281F340")]
	public static void MCNFBFNMHHG(PLIBOCMCGIC KCKJCMPILDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x281ED30", Offset = "0x281D730", VA = "0x18281ED30")]
	internal static void FEACPJAKDAN(PLIBOCMCGIC KCKJCMPILDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x281F260", Offset = "0x281DC60", VA = "0x18281F260")]
	internal static void LJHNBHIGGBE(PLIBOCMCGIC KCKJCMPILDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x281EE10", Offset = "0x281D810", VA = "0x18281EE10")]
	internal static void GINJOJOPLNA(PLIBOCMCGIC KCKJCMPILDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal class FPHJGACDOPE : global::PFEKCFPBNJH<CBPIBEEEMBL>
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class IIJGNNDNGKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public CBPIBEEEMBL message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public IIJGNNDNGKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x3575540", Offset = "0x3573F40", VA = "0x183575540")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly FPHJGACDOPE FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private const string GGDGPAILNBH = "pl";

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x281B380", Offset = "0x2819D80", VA = "0x18281B380")]
	public ExitGames.Client.Photon.Hashtable JHPOCMCIPNJ(CBPIBEEEMBL EJEIJOMMNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x281B0B0", Offset = "0x2819AB0", VA = "0x18281B0B0", Slot = "5")]
	protected override void ENDJNGBEPJA(CBPIBEEEMBL EJEIJOMMNGK, IDictionary<object, object> NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x281AEB0", Offset = "0x28198B0", VA = "0x18281AEB0", Slot = "6")]
	public override CBPIBEEEMBL AJGJBLGJHIK(IDictionary<object, object> NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x281B1F0", Offset = "0x2819BF0", VA = "0x18281B1F0")]
	private static void FOPPOIAFNDG(string PJOLHEJCFAC, CBPIBEEEMBL EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x281B7D0", Offset = "0x281A1D0", VA = "0x18281B7D0")]
	public FPHJGACDOPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x281B400", Offset = "0x2819E00", VA = "0x18281B400")]
	[CompilerGenerated]
	internal static string KIKHPLEDOJM(BKIFJPHNINC EONCDECCEBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class CHKKCPFDHPE
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public static MPFEOFKMCLF MBCLGAIFBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x280D110", Offset = "0x280BB10", VA = "0x18280D110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x280CE90", Offset = "0x280B890", VA = "0x18280CE90")]
	public static bool GMHBEIIKIOB(this MPFEOFKMCLF FHLMNCKDHLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x280D0B0", Offset = "0x280BAB0", VA = "0x18280D0B0")]
	public static MPFEOFKMCLF JJDOAPFIOKJ(OAPFICFJIOF BHEMOOALKFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x280D170", Offset = "0x280BB70", VA = "0x18280D170")]
	public static MPFEOFKMCLF PEEOGOONMJM(params MPFEOFKMCLF[] DBBLKJDOLKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x280CEB0", Offset = "0x280B8B0", VA = "0x18280CEB0")]
	public static MPFEOFKMCLF IMPNFEEDFHK(IEnumerable<MPFEOFKMCLF> DBBLKJDOLKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x280CC20", Offset = "0x280B620", VA = "0x18280CC20")]
	public static string CLGOMHKDKGG(this MPFEOFKMCLF OAFMFLFMLNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class EOLBNIPGEBA : IFFJBPOLGAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public delegate MPFEOFKMCLF LJJINNPGJCA([NotNull] BNMLLFBMDOA AMEKGOPDGPD);

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class OAFJGPKNFDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public BNMLLFBMDOA photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public OAFJGPKNFDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x2E42940", Offset = "0x2E41340", VA = "0x182E42940")]
		internal MPFEOFKMCLF <Validate>b__0(LJJINNPGJCA v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private bool DHFBGINHBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	protected readonly HashSet<LJJINNPGJCA> CGFMGJPALGB;

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x28150E0", Offset = "0x2813AE0", VA = "0x1828150E0", Slot = "4")]
	public void MMCDOCLDJPK(LJJINNPGJCA EFAOPCCHJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2814D90", Offset = "0x2813790", VA = "0x182814D90", Slot = "5")]
	public void BFHOAKDJGDP(LJJINNPGJCA EFAOPCCHJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2815090", Offset = "0x2813A90", VA = "0x182815090", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2814DF0", Offset = "0x28137F0", VA = "0x182814DF0")]
	protected MPFEOFKMCLF DGDDLBKNKEN(BNMLLFBMDOA BJOEAAODKCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2815140", Offset = "0x2813B40", VA = "0x182815140")]
	protected EOLBNIPGEBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public class LIJACNIBMBI : EOLBNIPGEBA, IJGBLFJOLIK, IFFJBPOLGAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class NJNMLMNDOCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public MPFEOFKMCLF result;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public NJNMLMNDOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x357FB60", Offset = "0x357E560", VA = "0x18357FB60")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x2E3B010", Offset = "0x2E39A10", VA = "0x182E3B010")]
	[UnityEngine.Scripting.Preserve]
	public LIJACNIBMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x2E3B020", Offset = "0x2E39A20", VA = "0x182E3B020", Slot = "8")]
	public MPFEOFKMCLF DHMHBCJIFLG(BNMLLFBMDOA BJOEAAODKCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class LHLGLDBECEL : EOLBNIPGEBA, LBNBLMOGAPL, IFFJBPOLGAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class CHMJIKBFINO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public MPFEOFKMCLF result;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public CHMJIKBFINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x356F780", Offset = "0x356E180", VA = "0x18356F780")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x2E3B010", Offset = "0x2E39A10", VA = "0x182E3B010")]
	[UnityEngine.Scripting.Preserve]
	public LHLGLDBECEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x2E3AE80", Offset = "0x2E39880", VA = "0x182E3AE80", Slot = "8")]
	public MPFEOFKMCLF PNHDFFMCHDL(BNMLLFBMDOA BIJLNBDIJCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public enum EKENHJPDEIN
{
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class OJHACOLPABK
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class NPMGDGHELEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public global::CLGKLANEGOH<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public NPMGDGHELEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x40849E0", Offset = "0x40833E0", VA = "0x1840849E0")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public const string KEBAIKAOPIC = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public const string DIPKINOCKPF = "END: ";

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2E43A60", Offset = "0x2E42460", VA = "0x182E43A60")]
	public static global::CLGKLANEGOH<string> HLBGGIGHGGD([Optional] string MDBGHLCIKCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x2E43B30", Offset = "0x2E42530", VA = "0x182E43B30")]
	private static void KCPBADIMJKI(string AJPNMLHDHNM, EPDEGEIGNNN CEJBHGLMENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2E43CF0", Offset = "0x2E426F0", VA = "0x182E43CF0")]
	private static void OGBKDOMFLHF(string AJPNMLHDHNM, EPDEGEIGNNN CEJBHGLMENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2E43DF0", Offset = "0x2E427F0", VA = "0x182E43DF0")]
	public static void PDGPCFJPHJL(global::CLGKLANEGOH<string> CEJBHGLMENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2E43C30", Offset = "0x2E42630", VA = "0x182E43C30")]
	public static string KLCEHLCKOEK(CBPIBEEEMBL IKJODENKJBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class JPIHCPGBJAI
{
	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x2825590", Offset = "0x2823F90", VA = "0x182825590")]
	public static void CADEFPLMMBI(this ONLFOKFFMFG LNMHPEDOLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x28256B0", Offset = "0x28240B0", VA = "0x1828256B0")]
	public static void PNJHINGKMKL(this ONLFOKFFMFG LNMHPEDOLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x28255A0", Offset = "0x2823FA0", VA = "0x1828255A0")]
	private static void EBFJJDDPINM(this ONLFOKFFMFG LNMHPEDOLKI, bool GPBEGFBDBGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class EIHDACAMGOB : AEHMKHDGACK, GPKIGGINJFJ, MMEGLAINFCK, BFJFCONHOMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private readonly GPKIGGINJFJ HLKOAOJIJFG;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public BNMLLFBMDOA NELFCHDFPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x28142D0", Offset = "0x2812CD0", VA = "0x1828142D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public int GCABPBICECE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x28143C0", Offset = "0x2812DC0", VA = "0x1828143C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int OFOCPNCAOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x2814660", Offset = "0x2813060", VA = "0x182814660", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool LLHDPIAHEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x6E2020", Offset = "0x6E0A20", VA = "0x1806E2020", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public int FEIBMCMJHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x6E7AA0", Offset = "0x6E64A0", VA = "0x1806E7AA0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event HMPKJKPIHFN.OBDIDKAAMCH HNCCKMBJIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event LDLFOCHHALH LHNDAKLHOAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x28147F0", Offset = "0x28131F0", VA = "0x1828147F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x2814750", Offset = "0x2813150", VA = "0x182814750", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event Action<bool> GNJINIMBPCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<BNMLLFBMDOA> LLHNFGGPJMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action GJOCJAJKMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x28146B0", Offset = "0x28130B0", VA = "0x1828146B0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2814510", Offset = "0x2812F10", VA = "0x182814510", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0xBFBD40", Offset = "0xBFA740", VA = "0x180BFBD40")]
	public EIHDACAMGOB(GPKIGGINJFJ HLKOAOJIJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x28145B0", Offset = "0x2812FB0", VA = "0x1828145B0", Slot = "8")]
	public bool KFHKNHIADHD(byte NLMDNLDJIGP, ExitGames.Client.Photon.Hashtable AABANDGGGIH, MFNIAKBHBEB OHACIAOONOI, SendOptions BCNIOGLMEKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2814320", Offset = "0x2812D20", VA = "0x182814320", Slot = "29")]
	public BNMLLFBMDOA CGHNAOJALIJ(int EJDIPHAOEMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2814410", Offset = "0x2812E10", VA = "0x182814410", Slot = "16")]
	public BNMLLFBMDOA COFAKKLLMDK(int IEDICPMHEEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "19")]
	public void GDPFHHOBGFM(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "20")]
	public void FGFBFPKBCAD(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "21")]
	public void KIPBABDOBHA(object DEGCIHEAIBD, bool CHAMEOMNKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2814890", Offset = "0x2813290", VA = "0x182814890", Slot = "22")]
	public IDisposable PCNBFCMNJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "23")]
	private bool NDCFBPAELAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "24")]
	public void EHKJBMHHKDF(StringBuilder DBFNGAMAEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x28144F0", Offset = "0x2812EF0", VA = "0x1828144F0", Slot = "25")]
	public bool DOELGCLJFKF(bool IEFKKGAIHKM, out string IMHLNJJFNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	public void LALBPKOLFLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x101B430", Offset = "0x1019E30", VA = "0x18101B430", Slot = "28")]
	public void BJNGDLMIJBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal struct GFMBDLPCLFD
{
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public const string KFEEOFCOGDF = "v_result";

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public const string HKMKOGDFECC = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private readonly IDictionary<object, object> PHDLBHDMOFH;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool MPANJOCJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x8E65F0", Offset = "0x8E4FF0", VA = "0x1808E65F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x897DB0", Offset = "0x8967B0", VA = "0x180897DB0")]
	public GFMBDLPCLFD(IDictionary<object, object> PHDLBHDMOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x281BE50", Offset = "0x281A850", VA = "0x18281BE50")]
	public bool ALNODOHKMCE(out CBPIBEEEMBL EJEIJOMMNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x281C070", Offset = "0x281AA70", VA = "0x18281C070")]
	public Guid COOIGAIOOGN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x281BF10", Offset = "0x281A910", VA = "0x18281BF10")]
	public MPFEOFKMCLF CEMGGJGHIFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x281C150", Offset = "0x281AB50", VA = "0x18281C150")]
	public static ExitGames.Client.Photon.Hashtable GANMJPNFBJN(CBPIBEEEMBL EJEIJOMMNGK, MPFEOFKMCLF FHLMNCKDHLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal static class IPILIDFIODB
{
	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2823B80", Offset = "0x2822580", VA = "0x182823B80")]
	public static string LFFDDIIPEEI(this CMGFGGHOKOI IDHGMFMNLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2823B00", Offset = "0x2822500", VA = "0x182823B00")]
	public static bool DIFKBDALOEC(this CMGFGGHOKOI IDHGMFMNLEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct HOKPMKCKLEB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct IOGKIJADGOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public HOKPMKCKLEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x3575B30", Offset = "0x3574530", VA = "0x183575B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly CancellationTokenSource FPCHIMCODNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private bool DHFBGINHBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private Task MBOEJHPPHJP;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool MPANJOCJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2822A70", Offset = "0x2821470", VA = "0x182822A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	internal Task FKEDDAABOEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2822AA0", Offset = "0x28214A0", VA = "0x182822AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x2822B20", Offset = "0x2821520", VA = "0x182822B20")]
	public HOKPMKCKLEB(CancellationToken KAKEKEHNCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2822940", Offset = "0x2821340", VA = "0x182822940")]
	[AsyncStateMachine(typeof(IOGKIJADGOC))]
	public Task FFGGKMFGILP(Func<CancellationToken, List<Task>> NJMOFBMFHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x28228F0", Offset = "0x28212F0", VA = "0x1828228F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public readonly struct CBADPBPJIBN<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct LDAJBKELELO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public AsyncTaskMethodBuilder<global::HJJOMCAHDKC<global::MGCPIBOLANK<TData>, PJMBHANDPHF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public PPKCEHBLCJE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public global::CBADPBPJIBN<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private PPKCEHBLCJE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private TaskAwaiter<global::HJJOMCAHDKC<byte[], PJMBHANDPHF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x254BD80", Offset = "0x254A780", VA = "0x18254BD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2303C30", Offset = "0x2302630", VA = "0x182303C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private readonly global::JPMELOFIHBA<TGetDataArg, TData> KCLACGDGMEA;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x897DB0", Offset = "0x8967B0", VA = "0x180897DB0")]
	internal CBADPBPJIBN(global::JPMELOFIHBA<TGetDataArg, TData> CFFEHCJNLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x33621E0", Offset = "0x3360BE0", VA = "0x1833621E0")]
	[AsyncStateMachine(typeof(global::CBADPBPJIBN<, >.LDAJBKELELO))]
	public Task<global::HJJOMCAHDKC<global::MGCPIBOLANK<TData>, PJMBHANDPHF>> ODIHINHDAMH(TGetDataArg NGMLAIALNFB, string HOKLHFPDJCL, PPKCEHBLCJE CEJBHGLMENF, CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public static class KLOJLBGPMDD
{
	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x23EAFB0", Offset = "0x23E99B0", VA = "0x1823EAFB0")]
	public static global::CBADPBPJIBN<TGetDataArg, TData> EEKKKHPKBPD<TGetDataArg, TData>(global::JPMELOFIHBA<TGetDataArg, TData> CFFEHCJNLHI)
	{
		return default(global::CBADPBPJIBN<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public class BCJAKJOCBPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private readonly DOAIHBCLGLJ NOKOHOFMEGH;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private const string ADKINIGMGDI = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private const string MADIJNOLDFH = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private const string ANFFKDLHGMN = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private const string GNPCEIMEHGD = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private const string FMMDINOACME = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private string MLAHHFJBHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private long? KHALPPEGCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private long? JHOOBLNAFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private CCBILGENNND EFDIGGMACOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private long? KIMPBBIHOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private bool NHIECDEHBPP;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string GDPLPFFHABH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public long LPIOOPIICMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x2809AD0", Offset = "0x28084D0", VA = "0x182809AD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public long IFEALAKHMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x2809980", Offset = "0x2808380", VA = "0x182809980")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public CCBILGENNND INIPNDLLHCI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x70E720", Offset = "0x70D120", VA = "0x18070E720")]
		get
		{
			return default(CCBILGENNND);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x28099E0", Offset = "0x28083E0", VA = "0x1828099E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public long JLEHCJODPCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2809E20", Offset = "0x2808820", VA = "0x182809E20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x2809E80", Offset = "0x2808880", VA = "0x182809E80")]
	[UnityEngine.Scripting.Preserve]
	public BCJAKJOCBPE([HGGCKJALFAG(null)] DOAIHBCLGLJ NOKOHOFMEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2809330", Offset = "0x2807D30", VA = "0x182809330")]
	private void CJDNFJKIPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x28094E0", Offset = "0x2807EE0", VA = "0x1828094E0")]
	public void GMNOBGDDLGH(long ANAJKMBCHFB, long DJKGICGFGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2809890", Offset = "0x2808290", VA = "0x182809890")]
	public void HKDPBDKHKGM(string JMODAAFHIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2809B30", Offset = "0x2808530", VA = "0x182809B30")]
	public void KHLEJLONLMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal class PHJKBIIFKDP : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct BFCGGCODFKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public AsyncTaskMethodBuilder<CBPIBEEEMBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public CBPIBEEEMBL roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public PHJKBIIFKDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private PPKCEHBLCJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private TaskAwaiter<DFAEGGONFLF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x40792E0", Offset = "0x4077CE0", VA = "0x1840792E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x40795F0", Offset = "0x4077FF0", VA = "0x1840795F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct AJNKNMOHCNO<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private sealed class IEDICDMNKKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public CBPIBEEEMBL roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public IEDICDMNKKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x407F7A0", Offset = "0x407E1A0", VA = "0x18407F7A0")]
		internal CBPIBEEEMBL <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct GJFEGCLHHFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public AsyncTaskMethodBuilder<DFAEGGONFLF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public CBPIBEEEMBL roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public PHJKBIIFKDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private DKPFGBILKAL <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private TaskAwaiter<DFAEGGONFLF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x407E200", Offset = "0x407CC00", VA = "0x18407E200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x407E9E0", Offset = "0x407D3E0", VA = "0x18407E9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct HMKDCOIBBNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public PHJKBIIFKDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x407F640", Offset = "0x407E040", VA = "0x18407F640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class IGANJLHKEMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public IGANJLHKEMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x407F8B0", Offset = "0x407E2B0", VA = "0x18407F8B0")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private sealed class IGKHPEPFGJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public IGKHPEPFGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x407FA20", Offset = "0x407E420", VA = "0x18407FA20")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private sealed class IOOKADFNGCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public IOOKADFNGCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x407FD70", Offset = "0x407E770", VA = "0x18407FD70")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class NCKHNOJNPAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public NCKHNOJNPAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x40834E0", Offset = "0x4081EE0", VA = "0x1840834E0")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class JPHBMBDGDHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public PHJKBIIFKDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public JPHBMBDGDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x4081310", Offset = "0x407FD10", VA = "0x184081310")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class MMKIGBNEMDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public PHJKBIIFKDP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public MMKIGBNEMDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x4082A30", Offset = "0x4081430", VA = "0x184082A30")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private static readonly Guid ACIPCLLLCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public readonly BLIAEEPMOEN KKGAEEABJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly DFAGGIFGJFA ONODKMAJPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly MMEGLAINFCK LNMHPEDOLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private readonly BFJFCONHOMF APIJOGANCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private bool KOKJAEEOBIE;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2E490A0", Offset = "0x2E47AA0", VA = "0x182E490A0")]
	public PHJKBIIFKDP(BLIAEEPMOEN LDDMJCCAAEJ, DFAGGIFGJFA ONODKMAJPGL, MMEGLAINFCK LNMHPEDOLKI, BFJFCONHOMF APIJOGANCLJ, PPKCEHBLCJE IFNGEGAGDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2E47ED0", Offset = "0x2E468D0", VA = "0x182E47ED0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2E47B60", Offset = "0x2E46560", VA = "0x182E47B60")]
	public void CALPLPPFCID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2E48A20", Offset = "0x2E47420", VA = "0x182E48A20")]
	public void NCECNDCEMFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2E47D80", Offset = "0x2E46780", VA = "0x182E47D80")]
	public void CKGJOCNOHME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2E48200", Offset = "0x2E46C00", VA = "0x182E48200")]
	[AsyncStateMachine(typeof(BFCGGCODFKH))]
	internal Task<CBPIBEEEMBL> HKGCKMBGAAD(PPKCEHBLCJE IFNGEGAGDGH, CBPIBEEEMBL IKJODENKJBP, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x280B4E0", Offset = "0x2809EE0", VA = "0x18280B4E0")]
	private static byte[] DENKBDGAMPJ<T>(T EJEIJOMMNGK) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x291A8E0", Offset = "0x29192E0", VA = "0x18291A8E0")]
	private static T JCCNIBGJFJF<T>(MessageParser<T> BAKMAMLDONF, byte[] EJEIJOMMNGK, T OLFHPKNHJOE) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2E48380", Offset = "0x2E46D80", VA = "0x182E48380")]
	[AsyncStateMachine(typeof(GJFEGCLHHFO))]
	private Task<DFAEGGONFLF> HPCOEPBIPFO(CBPIBEEEMBL IKJODENKJBP, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x291AF10", Offset = "0x2919910", VA = "0x18291AF10")]
	[AsyncStateMachine(typeof(DGINFFOMMLE))]
	internal Task<T> OPBLJLIDGLO<T>(CancellationToken HLIGFMLOMGA, Func<CancellationToken, Task<T>> DPGAOBOBNBF, int NIJEAHFEHOI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2E48C00", Offset = "0x2E47600", VA = "0x182E48C00")]
	[AsyncStateMachine(typeof(HMKDCOIBBNH))]
	internal Task OPBLJLIDGLO(CancellationToken HLIGFMLOMGA, Func<CancellationToken, Task> DPGAOBOBNBF, int NIJEAHFEHOI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2E484E0", Offset = "0x2E46EE0", VA = "0x182E484E0")]
	public CBPIBEEEMBL JAIJNCIEOIA(DKPFGBILKAL HANPFJGJLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2E47D10", Offset = "0x2E46710", VA = "0x182E47D10")]
	public GJPAIHKAMLN CGOKJPEJMEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2E489B0", Offset = "0x2E473B0", VA = "0x182E489B0")]
	public MJPFOJMOAII LJIAEGGEHHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2E48B70", Offset = "0x2E47570", VA = "0x182E48B70")]
	public HKGMKBEEMHC OFGMNBDFBIA([Optional] PLAMFHPFEGH? PMIMLGGAICF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2E47990", Offset = "0x2E46390", VA = "0x182E47990")]
	public void AEBNMJHHBGB(Func<Guid, bool> GLGBBCABHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x2E48570", Offset = "0x2E46F70", VA = "0x182E48570")]
	public void JEGNAFDBOFP(Func<Guid, bool> ECNGJONMNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2E479C0", Offset = "0x2E463C0", VA = "0x182E479C0")]
	public void AJCCMOKOABA(Func<Guid, bool> GLGBBCABHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x2E487A0", Offset = "0x2E471A0", VA = "0x182E487A0")]
	public Guid KHEFEIGEANF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x2E48D50", Offset = "0x2E47750", VA = "0x182E48D50")]
	public void OPMIMIAFNJD(Guid NNFEIEJOPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2E48EE0", Offset = "0x2E478E0", VA = "0x182E48EE0")]
	public void PEMJBAAEAFJ(CBPIBEEEMBL CKHIBOGADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2E48070", Offset = "0x2E46A70", VA = "0x182E48070")]
	public void FOPPOIAFNDG(string IDDHNGMOIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x2E47EE0", Offset = "0x2E468E0", VA = "0x182E47EE0")]
	public void FOPPOIAFNDG(Func<string> LMBBCHDMIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x291A800", Offset = "0x2919200", VA = "0x18291A800")]
	private T EOGANPFMHBL<T>(T MNIAGKNOHEJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2E48750", Offset = "0x2E47150", VA = "0x182E48750")]
	public void KFMINEMPHPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x291AA90", Offset = "0x2919490", VA = "0x18291AA90")]
	[CompilerGenerated]
	internal static string KPNOMDGHEAM<T>(byte[] FMIGDHLBIKP, int PCFIPALLPOI, ref AJNKNMOHCNO<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal sealed class DKDODKEBNCC : BLIAEEPMOEN
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class AOJFPMPOBOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public AOJFPMPOBOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2E33860", Offset = "0x2E32260", VA = "0x182E33860")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct GLKKNGCJPBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public DKDODKEBNCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public PHJKBIIFKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private MJPFOJMOAII <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2E376F0", Offset = "0x2E360F0", VA = "0x182E376F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class OJJAIBFNNAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public ABDJCJMAGOJ presence;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public OJJAIBFNNAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2E43F60", Offset = "0x2E42960", VA = "0x182E43F60")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private readonly BKIFJPHNINC IBAGMGEICEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private readonly CMGFGGHOKOI NLLKOGDPODM;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private const bool PBFIICOHKMN = false;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x2810620", Offset = "0x280F020", VA = "0x182810620")]
	public DKDODKEBNCC(BKIFJPHNINC IBAGMGEICEB, CMGFGGHOKOI NLLKOGDPODM, Guid EPCIDCJCNKD, AHOGOPJAAEB BPCKLHHCJGL, CAFOCDOFHHK NLKJBKOHEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x2810030", Offset = "0x280EA30", VA = "0x182810030", Slot = "8")]
	[AsyncStateMachine(typeof(GLKKNGCJPBC))]
	protected override Task HOFACKGPDEG(PHJKBIIFKDP FMCOAFCKPDJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x2810180", Offset = "0x280EB80", VA = "0x182810180")]
	private ABDJCJMAGOJ LOIHMOHFJBL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal class OABBKNEEALB : BLIAEEPMOEN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct NGIKCMMNNPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public OABBKNEEALB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public PHJKBIIFKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private PPKCEHBLCJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private TaskAwaiter<LFADINBGMLP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x4083A50", Offset = "0x4082450", VA = "0x184083A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private readonly int DLPCHMELHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private readonly BMIHFLGADPJ CJMCLFOEGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public readonly long PMIPIPDHLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public readonly long LGLBMOBFKLK;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public LFADINBGMLP CBCGALJNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D80", Offset = "0x6C6780", VA = "0x1806C7D80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x8CBEB0", Offset = "0x8CA8B0", VA = "0x1808CBEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x2E42760", Offset = "0x2E41160", VA = "0x182E42760")]
	public OABBKNEEALB(Guid EPCIDCJCNKD, AHOGOPJAAEB BPCKLHHCJGL, CAFOCDOFHHK NLKJBKOHEHE, int DLPCHMELHBI, BMIHFLGADPJ CJMCLFOEGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2E42620", Offset = "0x2E41020", VA = "0x182E42620", Slot = "8")]
	[AsyncStateMachine(typeof(NGIKCMMNNPK))]
	protected override Task HOFACKGPDEG(PHJKBIIFKDP FMCOAFCKPDJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal abstract class OKHBBHJFIJB : BLIAEEPMOEN
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class LMKDPGBHLBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public OKHBBHJFIJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public DNIIACMEENK playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public LMKDPGBHLBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x4081660", Offset = "0x4080060", VA = "0x184081660")]
		internal Task <RunAsync>b__0(PPKCEHBLCJE postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x40816A0", Offset = "0x40800A0", VA = "0x1840816A0")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct JLNKIPHMJEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public OKHBBHJFIJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public PHJKBIIFKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private LMKDPGBHLBB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x4080C00", Offset = "0x407F600", VA = "0x184080C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct MMKHMJAGDKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public PPKCEHBLCJE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public DNIIACMEENK playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public OKHBBHJFIJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private PPKCEHBLCJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x4082570", Offset = "0x4080F70", VA = "0x184082570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2E44890", Offset = "0x2E43290", VA = "0x182E44890")]
	public OKHBBHJFIJB(Guid EPCIDCJCNKD, AHOGOPJAAEB BPCKLHHCJGL, CAFOCDOFHHK NLKJBKOHEHE, string DGNIOHPLJIP, GOJAKPCKBGA EPLCJFLCJCI, bool JOGBLCODKCF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2E445E0", Offset = "0x2E42FE0", VA = "0x182E445E0", Slot = "8")]
	[AsyncStateMachine(typeof(JLNKIPHMJEO))]
	protected override Task HOFACKGPDEG(PHJKBIIFKDP FMCOAFCKPDJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task ABIAMICEBEI(PHJKBIIFKDP FMCOAFCKPDJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2E44730", Offset = "0x2E43130", VA = "0x182E44730")]
	[AsyncStateMachine(typeof(MMKHMJAGDKA))]
	private Task JIEKLDMEEOP(IDisposable NDMIOKPENCE, DNIIACMEENK ILFBJLHEGLH, PPKCEHBLCJE CEJBHGLMENF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal class NKPJDJABAMH : BLIAEEPMOEN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct ENKGKJLHNKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public NKPJDJABAMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public PHJKBIIFKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private TaskAwaiter<OCNLFCGGDIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x407BCC0", Offset = "0x407A6C0", VA = "0x18407BCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly EJAEMPHNCCB ADIFNIMFLJN;

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x2E41DB0", Offset = "0x2E407B0", VA = "0x182E41DB0")]
	public NKPJDJABAMH(Guid EPCIDCJCNKD, AHOGOPJAAEB BPCKLHHCJGL, CAFOCDOFHHK NLKJBKOHEHE, EJAEMPHNCCB ADIFNIMFLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2E41B90", Offset = "0x2E40590", VA = "0x182E41B90", Slot = "7")]
	protected override string CPPOHDGLHFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2E41C70", Offset = "0x2E40670", VA = "0x182E41C70", Slot = "8")]
	[AsyncStateMachine(typeof(ENKGKJLHNKP))]
	protected override Task HOFACKGPDEG(PHJKBIIFKDP FMCOAFCKPDJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal abstract class BLIAEEPMOEN : FBJINOEDIAP
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public delegate Task LMLHOOCAFHE(PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class CGIBGNIBNME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public PPKCEHBLCJE operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public BLIAEEPMOEN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public CGIBGNIBNME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x2E34700", Offset = "0x2E33100", VA = "0x182E34700")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class ELEMGNPCHAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public CGIBGNIBNME CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ELEMGNPCHAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2E364B0", Offset = "0x2E34EB0", VA = "0x182E364B0")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2E36570", Offset = "0x2E34F70", VA = "0x182E36570")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private struct PFAEMCNMPLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public BLIAEEPMOEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public Func<BLIAEEPMOEN, PPKCEHBLCJE, PHJKBIIFKDP> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private CGIBGNIBNME <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private PHJKBIIFKDP <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private TaskAwaiter<CBPIBEEEMBL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2E46640", Offset = "0x2E45040", VA = "0x182E46640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private struct JNLACLNJMKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public BLIAEEPMOEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2E38AC0", Offset = "0x2E374C0", VA = "0x182E38AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public readonly Guid ANPCHMGMLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public readonly ByteString CJFFGPMHGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public readonly CAFOCDOFHHK OFPIBHNCBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	protected readonly string FDEDALEGIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private readonly AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private readonly bool JOGBLCODKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private readonly Queue<LMLHOOCAFHE> IFOPFLACBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private readonly ACIKGHAHCMJ OKGOHDDOKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private readonly GOJAKPCKBGA EPLCJFLCJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private bool KHAGHONHJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public CCBILGENNND JKFODGIGGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public CCBILGENNND ANAOCIOPNED;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public AHOGOPJAAEB DOMPCIMBOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public IIFGAMEMGIC KKDHBDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x280B880", Offset = "0x280A280", VA = "0x18280B880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public IHIPIPFGNAC HBOCDCMDGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x280BEC0", Offset = "0x280A8C0", VA = "0x18280BEC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public GDIIDHNMKBB FKJMHDJKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x280B8D0", Offset = "0x280A2D0", VA = "0x18280B8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public float CEANHDGLAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x280B7E0", Offset = "0x280A1E0", VA = "0x18280B7E0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event CJKDEHHCCDO GBJJCCBNLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x280B860", Offset = "0x280A260", VA = "0x18280B860", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x280B840", Offset = "0x280A240", VA = "0x18280B840", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x280C0B0", Offset = "0x280AAB0", VA = "0x18280C0B0")]
	protected BLIAEEPMOEN(Guid EPCIDCJCNKD, AHOGOPJAAEB BPCKLHHCJGL, CAFOCDOFHHK NLKJBKOHEHE, string DGNIOHPLJIP, GOJAKPCKBGA EPLCJFLCJCI, bool JOGBLCODKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x280B800", Offset = "0x280A200", VA = "0x18280B800", Slot = "7")]
	protected virtual string CPPOHDGLHFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x280BF10", Offset = "0x280A910", VA = "0x18280BF10")]
	public void NMAPOIHEPGC(LMLHOOCAFHE OEGIILCLJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x280B950", Offset = "0x280A350", VA = "0x18280B950")]
	protected void GIKDBMGPEJK(float LHIIFNPNDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x280B970", Offset = "0x280A370", VA = "0x18280B970")]
	[AsyncStateMachine(typeof(PFAEMCNMPLD))]
	public Task HHNJFAHFJBP(CancellationToken KAKEKEHNCME, PPKCEHBLCJE IFNGEGAGDGH, [Optional] Func<BLIAEEPMOEN, PPKCEHBLCJE, PHJKBIIFKDP> MOJKFOEJDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x280BBA0", Offset = "0x280A5A0", VA = "0x18280BBA0")]
	private void IBNCAKFGPDA(bool CHBAEKGGGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x280BDB0", Offset = "0x280A7B0", VA = "0x18280BDB0")]
	private void MCBFELHHCBB(PHJKBIIFKDP FMCOAFCKPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task HOFACKGPDEG(PHJKBIIFKDP FMCOAFCKPDJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x280BF70", Offset = "0x280A970", VA = "0x18280BF70")]
	[AsyncStateMachine(typeof(JNLACLNJMKJ))]
	private Task OKFNHBOOIIG(PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x280BD30", Offset = "0x280A730", VA = "0x18280BD30")]
	public CBPIBEEEMBL JAIJNCIEOIA(DKPFGBILKAL HANPFJGJLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x280BAC0", Offset = "0x280A4C0", VA = "0x18280BAC0")]
	[CompilerGenerated]
	private Task HJOJPCEMOMD(CancellationToken KNGDLMLNDII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal sealed class AILKDPBBIEM : OKHBBHJFIJB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct IFADBCKEHEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public AILKDPBBIEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public PHJKBIIFKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private BHPLPOAJICO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private MJPFOJMOAII <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2E383B0", Offset = "0x2E36DB0", VA = "0x182E383B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private readonly BKIFJPHNINC OCMDGODIDJB;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x28076E0", Offset = "0x28060E0", VA = "0x1828076E0")]
	public AILKDPBBIEM(Guid EPCIDCJCNKD, AHOGOPJAAEB BPCKLHHCJGL, BKIFJPHNINC OCMDGODIDJB, CAFOCDOFHHK NLKJBKOHEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2807590", Offset = "0x2805F90", VA = "0x182807590", Slot = "9")]
	[AsyncStateMachine(typeof(IFADBCKEHEG))]
	protected override Task ABIAMICEBEI(PHJKBIIFKDP FMCOAFCKPDJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
internal class PJGBKAGBAHD : BLIAEEPMOEN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct DEKAGEGFONO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public PJGBKAGBAHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public PHJKBIIFKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private TaskAwaiter<OCNLFCGGDIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x407A570", Offset = "0x4078F70", VA = "0x18407A570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private readonly string BJJPGEOAONK;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x2E493F0", Offset = "0x2E47DF0", VA = "0x182E493F0")]
	public PJGBKAGBAHD(Guid EPCIDCJCNKD, AHOGOPJAAEB BPCKLHHCJGL, CAFOCDOFHHK NLKJBKOHEHE, string BJJPGEOAONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x2E492C0", Offset = "0x2E47CC0", VA = "0x182E492C0", Slot = "8")]
	[AsyncStateMachine(typeof(DEKAGEGFONO))]
	protected override Task HOFACKGPDEG(PHJKBIIFKDP FMCOAFCKPDJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class ELECHHCHJIK : OKHBBHJFIJB
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class OIPJLKGMBHP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public AsyncTaskMethodBuilder<CBPIBEEEMBL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public OIPJLKGMBHP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			private TaskAwaiter<OCNLFCGGDIP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			private TaskAwaiter<CBPIBEEEMBL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x40890E0", Offset = "0x4087AE0", VA = "0x1840890E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0x4089430", Offset = "0x4087E30", VA = "0x184089430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public ELECHHCHJIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public HKGMKBEEMHC serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public GJPAIHKAMLN uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public OIPJLKGMBHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2E43910", Offset = "0x2E42310", VA = "0x182E43910")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<CBPIBEEEMBL> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct LMOHPDJECLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public ELECHHCHJIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public PHJKBIIFKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private OIPJLKGMBHP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private BHPLPOAJICO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private MJPFOJMOAII <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TaskAwaiter<CBPIBEEEMBL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2E3BA30", Offset = "0x2E3A430", VA = "0x182E3BA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private readonly int FGKCBIDBKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	[CanBeNull]
	private readonly PGFLJPDKEFM MCIIIGHPBOK;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x2814CE0", Offset = "0x28136E0", VA = "0x182814CE0")]
	public ELECHHCHJIK(Guid EPCIDCJCNKD, AHOGOPJAAEB BPCKLHHCJGL, int FGKCBIDBKEO, PGFLJPDKEFM MCIIIGHPBOK, CAFOCDOFHHK NLKJBKOHEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x28148F0", Offset = "0x28132F0", VA = "0x1828148F0", Slot = "9")]
	[AsyncStateMachine(typeof(LMOHPDJECLC))]
	protected override Task ABIAMICEBEI(PHJKBIIFKDP FMCOAFCKPDJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x2814BF0", Offset = "0x28135F0", VA = "0x182814BF0")]
	private void HDNEBKLKKGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x2814A50", Offset = "0x2813450", VA = "0x182814A50")]
	private void AMFHJLJLJOH(PPKCEHBLCJE IFNGEGAGDGH, BHPLPOAJICO OENKJBHANFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal abstract class KJCOAHDLLHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public readonly BLIAEEPMOEN KKGAEEABJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public readonly PHJKBIIFKDP CDJGOIJFHOK;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public IIFGAMEMGIC KKDHBDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2827520", Offset = "0x2825F20", VA = "0x182827520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public GDIIDHNMKBB FKJMHDJKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2827570", Offset = "0x2825F70", VA = "0x182827570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x2827640", Offset = "0x2826040", VA = "0x182827640")]
	protected KJCOAHDLLHM(PHJKBIIFKDP FMCOAFCKPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x2827620", Offset = "0x2826020", VA = "0x182827620")]
	protected void FOPPOIAFNDG(string IDDHNGMOIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x2827600", Offset = "0x2826000", VA = "0x182827600")]
	public void FOPPOIAFNDG(Func<string> LMBBCHDMIDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal struct GPHGAPLLDOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public Dictionary<Guid, List<IIKJDPCCGKJ>> KCLKIFDHEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public Dictionary<Guid, List<IIKJDPCCGKJ>> GFIAIGELLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public Dictionary<Guid, List<IIKJDPCCGKJ>> OOIOCABMJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public List<Guid> AMIPKKNHHBN;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x281E2A0", Offset = "0x281CCA0", VA = "0x18281E2A0")]
	public static GPHGAPLLDOG AGGAFJIIBKL(IIFGAMEMGIC EDFOBNPNANH, CCBILGENNND EPGBDEENMAE, FDMJKHLGKCI OOAJGFHOJOG)
	{
		return default(GPHGAPLLDOG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal struct JGCOFJDONBC
{
	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00")]
	public static JGCOFJDONBC GANMJPNFBJN()
	{
		return default(JGCOFJDONBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void JDGNANEBJOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void BDHLMCNILPE(FDMJKHLGKCI NIPBPKPBPPP, object GDCPPPKHAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void DNCMCMHBHIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal struct FPIHCDKPOGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public readonly BIHOLPOPBIG BBBLPIMMPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public readonly CKHPNKKDHCH LJEEKDBBIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public readonly CKDIMAPEKCL FMIKCCJGKCO;

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x281B810", Offset = "0x281A210", VA = "0x18281B810")]
	public FPIHCDKPOGD(BIHOLPOPBIG BBBLPIMMPAL, CKHPNKKDHCH LJEEKDBBIPJ, CKDIMAPEKCL FMIKCCJGKCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal struct DEFNEMDKEKM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	private readonly PHJKBIIFKDP FMCOAFCKPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	private readonly Guid NNFEIEJOPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private bool CHBAEKGGGBK;

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x280DFA0", Offset = "0x280C9A0", VA = "0x18280DFA0")]
	public static DEFNEMDKEKM KHEFEIGEANF(PHJKBIIFKDP FMCOAFCKPDJ)
	{
		return default(DEFNEMDKEKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x1003D10", Offset = "0x1002710", VA = "0x181003D10")]
	public void FAKILPGEJMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x280DE90", Offset = "0x280C890", VA = "0x18280DE90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x280E000", Offset = "0x280CA00", VA = "0x18280E000")]
	private DEFNEMDKEKM(PHJKBIIFKDP FMCOAFCKPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x280DE90", Offset = "0x280C890", VA = "0x18280DE90")]
	private void OPMIMIAFNJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x280DEF0", Offset = "0x280C8F0", VA = "0x18280DEF0")]
	private Func<Guid, bool> KBFAGELHDNO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
internal class MJPFOJMOAII : KJCOAHDLLHM, FBJINOEDIAP
{
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public delegate Task<CCBILGENNND> OMAGJMIANND(FDMJKHLGKCI NIPBPKPBPPP, EJKMKHAAEAK JAHLACDPAJI, ACIKGHAHCMJ OGLFEHBCGHJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct GKIOEGCKMFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public MJPFOJMOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public BKIFJPHNINC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private DEFNEMDKEKM <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private TaskAwaiter<CBPIBEEEMBL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x407EA30", Offset = "0x407D430", VA = "0x18407EA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct DCOJHFBHLHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public AsyncTaskMethodBuilder<CBPIBEEEMBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public MJPFOJMOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public BKIFJPHNINC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private PPKCEHBLCJE <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private TaskAwaiter<CBPIBEEEMBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x407A200", Offset = "0x4078C00", VA = "0x18407A200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x407A520", Offset = "0x4078F20", VA = "0x18407A520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct PLEGONHIFAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public MJPFOJMOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public BKIFJPHNINC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private PPKCEHBLCJE <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x40856B0", Offset = "0x40840B0", VA = "0x1840856B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class LPIBMHPJIAG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010E")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public AsyncTaskMethodBuilder<FPIHCDKPOGD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public LPIBMHPJIAG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			private FPIHCDKPOGD <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			private TaskAwaiter<CCBILGENNND> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			private TaskAwaiter<FPIHCDKPOGD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x4087E20", Offset = "0x4086820", VA = "0x184087E20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x4088430", Offset = "0x4086E30", VA = "0x184088430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public AsyncTaskMethodBuilder<FDMJKHLGKCI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public LPIBMHPJIAG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			private FDMJKHLGKCI <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private TaskAwaiter<CCBILGENNND> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private TaskAwaiter<FDMJKHLGKCI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x4088480", Offset = "0x4086E80", VA = "0x184088480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x40889B0", Offset = "0x40873B0", VA = "0x1840889B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000110")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public LPIBMHPJIAG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private bool <isReloadingSceneForObjectModel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			private TaskAwaiter<CCBILGENNND> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			private EJKMKHAAEAK <timedYielder>5__3;

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x4086C00", Offset = "0x4085600", VA = "0x184086C00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public MJPFOJMOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public BKIFJPHNINC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public ACIKGHAHCMJ preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public ACIKGHAHCMJ downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public FPIHCDKPOGD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public ACIKGHAHCMJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public FDMJKHLGKCI phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public FEFPFDJPFJA.GNKGMJJDDPD <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public LPIBMHPJIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x40818B0", Offset = "0x40802B0", VA = "0x1840818B0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<FPIHCDKPOGD> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x40819F0", Offset = "0x40803F0", VA = "0x1840819F0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<FDMJKHLGKCI> <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x4081B30", Offset = "0x4080530", VA = "0x184081B30")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x4081780", Offset = "0x4080180", VA = "0x184081780")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct EHLKOMEBODG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public MJPFOJMOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public BKIFJPHNINC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		private LPIBMHPJIAG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private TaskAwaiter<FPIHCDKPOGD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private TaskAwaiter<FDMJKHLGKCI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x407B050", Offset = "0x4079A50", VA = "0x18407B050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct DKKBDEHMBHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public MJPFOJMOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public PPKCEHBLCJE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x407A890", Offset = "0x4079290", VA = "0x18407A890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct POGIPELNGEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public MJPFOJMOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public ACIKGHAHCMJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private PPKCEHBLCJE <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private TaskAwaiter<CCBILGENNND> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x4086510", Offset = "0x4084F10", VA = "0x184086510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct GEACGHDIHNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public AsyncTaskMethodBuilder<CCBILGENNND> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public MJPFOJMOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public ACIKGHAHCMJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private PPKCEHBLCJE <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private TaskAwaiter<CCBILGENNND> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x407D650", Offset = "0x407C050", VA = "0x18407D650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x407E0F0", Offset = "0x407CAF0", VA = "0x18407E0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct PNJEHGFMHGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public AsyncTaskMethodBuilder<CCBILGENNND> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public MJPFOJMOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public ACIKGHAHCMJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public EJKMKHAAEAK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private PPKCEHBLCJE <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter<CCBILGENNND> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x4085910", Offset = "0x4084310", VA = "0x184085910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x40864C0", Offset = "0x4084EC0", VA = "0x1840864C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct HJEMKLAKGIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public AsyncTaskMethodBuilder<CCBILGENNND> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public MJPFOJMOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public CCBILGENNND operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public ACIKGHAHCMJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public FDMJKHLGKCI deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private TaskAwaiter<CCBILGENNND> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x407F3F0", Offset = "0x407DDF0", VA = "0x18407F3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x407F5F0", Offset = "0x407DFF0", VA = "0x18407F5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class NJFGFEHCBED
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public AsyncTaskMethodBuilder<CCBILGENNND> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public NJFGFEHCBED <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			private TaskAwaiter<CCBILGENNND> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x4088A00", Offset = "0x4087400", VA = "0x184088A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DB")]
			[Cpp2IlInjected.Address(RVA = "0x4088F50", Offset = "0x4087950", VA = "0x184088F50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public MJPFOJMOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public ACIKGHAHCMJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public OMAGJMIANND masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public EJKMKHAAEAK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public CCBILGENNND originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public NJFGFEHCBED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x4084310", Offset = "0x4082D10", VA = "0x184084310")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<CCBILGENNND> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct AKIJEAOLDAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public AsyncTaskMethodBuilder<CCBILGENNND> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public MJPFOJMOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public ACIKGHAHCMJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public OMAGJMIANND masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public EJKMKHAAEAK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private TaskAwaiter<CCBILGENNND> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x40785B0", Offset = "0x4076FB0", VA = "0x1840785B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x4078A60", Offset = "0x4077460", VA = "0x184078A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct IPBEABNCCEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public MJPFOJMOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public ACIKGHAHCMJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private CCBILGENNND <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private IEnumerator<CCBILGENNND> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private TaskAwaiter<CCBILGENNND> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x407FDE0", Offset = "0x407E7E0", VA = "0x18407FDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct MPJBNIMJGFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public MJPFOJMOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x4083320", Offset = "0x4081D20", VA = "0x184083320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct PAHLBBLDFND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public MJPFOJMOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x4085580", Offset = "0x4083F80", VA = "0x184085580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class IMIIFCAEDEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public BIHOLPOPBIG roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public IMIIFCAEDEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x407FAE0", Offset = "0x407E4E0", VA = "0x18407FAE0")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private readonly BCNMCHLKHFL BPLNMIFBJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly BCNMCHLKHFL NMGIBIMEFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly BCJAKJOCBPE CFGLODANGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly FDONLJHLEIF FGMGCIIBAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private readonly OJLPHBJEHNP NONEKCBMNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	private readonly LFKPEHEHBKJ DGDADLIGNKA;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float CEANHDGLAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x2E3DF30", Offset = "0x2E3C930", VA = "0x182E3DF30", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private AHOGOPJAAEB DOMPCIMBOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x281C580", Offset = "0x281AF80", VA = "0x18281C580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event CJKDEHHCCDO GBJJCCBNLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E720", Offset = "0x2E3D120", VA = "0x182E3E720", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E410", Offset = "0x2E3CE10", VA = "0x182E3E410", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x2E3EEC0", Offset = "0x2E3D8C0", VA = "0x182E3EEC0")]
	public MJPFOJMOAII(PHJKBIIFKDP FMCOAFCKPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E5D0", Offset = "0x2E3CFD0", VA = "0x182E3E5D0")]
	[AsyncStateMachine(typeof(GKIOEGCKMFE))]
	public Task ENEJPNADEMK(BKIFJPHNINC NONPDGFJDAK, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x2E3DDB0", Offset = "0x2E3C7B0", VA = "0x182E3DDB0")]
	[AsyncStateMachine(typeof(DCOJHFBHLHC))]
	private Task<CBPIBEEEMBL> CENHHAOPOIA(BKIFJPHNINC NONPDGFJDAK, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x2E3DB60", Offset = "0x2E3C560", VA = "0x182E3DB60")]
	[AsyncStateMachine(typeof(PLEGONHIFAH))]
	private Task BPPHMGJIJDG(BKIFJPHNINC NONPDGFJDAK, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x2E3EC50", Offset = "0x2E3D650", VA = "0x182E3EC50")]
	[AsyncStateMachine(typeof(EHLKOMEBODG))]
	private Task PKHEAPNMHGL(BKIFJPHNINC NONPDGFJDAK, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken NJCBLGHLFKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E770", Offset = "0x2E3D170", VA = "0x182E3E770")]
	[AsyncStateMachine(typeof(DKKBDEHMBHP))]
	private Task GAPDOFCOGEB(PPKCEHBLCJE CEJBHGLMENF, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E930", Offset = "0x2E3D330", VA = "0x182E3E930")]
	[AsyncStateMachine(typeof(POGIPELNGEL))]
	private Task LAKHNFFBIFN(FDMJKHLGKCI NIPBPKPBPPP, ACIKGHAHCMJ OGLFEHBCGHJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D660", Offset = "0x2E3C060", VA = "0x182E3D660")]
	[AsyncStateMachine(typeof(GEACGHDIHNF))]
	private Task<CCBILGENNND> AEGIFKHANEL(FDMJKHLGKCI NIPBPKPBPPP, EJKMKHAAEAK JFMLDIGDPJP, ACIKGHAHCMJ OGLFEHBCGHJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E430", Offset = "0x2E3CE30", VA = "0x182E3E430")]
	[AsyncStateMachine(typeof(PNJEHGFMHGH))]
	private Task<CCBILGENNND> EKCKEHGGLDG(FDMJKHLGKCI NIPBPKPBPPP, EJKMKHAAEAK JFMLDIGDPJP, ACIKGHAHCMJ OGLFEHBCGHJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E280", Offset = "0x2E3CC80", VA = "0x182E3E280")]
	[AsyncStateMachine(typeof(HJEMKLAKGIJ))]
	private Task<CCBILGENNND> EGIJFGMJOEH(CCBILGENNND EPGBDEENMAE, FDMJKHLGKCI OOAJGFHOJOG, ACIKGHAHCMJ OGLFEHBCGHJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME, bool OFLDKCGMGEH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x2E3DCC0", Offset = "0x2E3C6C0", VA = "0x182E3DCC0")]
	private bool CADMCKIKFCJ(FDMJKHLGKCI OMKGMOPFDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E0D0", Offset = "0x2E3CAD0", VA = "0x182E3E0D0")]
	[AsyncStateMachine(typeof(AKIJEAOLDAB))]
	protected Task<CCBILGENNND> DNODHEICJLF(FDMJKHLGKCI NIPBPKPBPPP, EJKMKHAAEAK JFMLDIGDPJP, ACIKGHAHCMJ OGLFEHBCGHJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME, OMAGJMIANND ILLCLACKFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x2E3DF50", Offset = "0x2E3C950", VA = "0x182E3DF50")]
	[AsyncStateMachine(typeof(IPBEABNCCEC))]
	private Task DFJJMCIEFNA(FDMJKHLGKCI NIPBPKPBPPP, ACIKGHAHCMJ OGLFEHBCGHJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x2E3EA90", Offset = "0x2E3D490", VA = "0x182E3EA90")]
	private void LGGIEEOCGLJ(CCBILGENNND BDIBHEOCJAD, ACIKGHAHCMJ OGLFEHBCGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E8F0", Offset = "0x2E3D2F0", VA = "0x182E3E8F0")]
	private void ILGJGDLNINB(CCBILGENNND FPAMPOPPBAG, out CCBILGENNND ELNKGMDMFDA, out CCBILGENNND LILDIACIIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D850", Offset = "0x2E3C250", VA = "0x182E3D850")]
	private Task<FPIHCDKPOGD> BMBLKLJHHLG(BKIFJPHNINC NONPDGFJDAK, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D800", Offset = "0x2E3C200", VA = "0x182E3D800")]
	private Task<FDMJKHLGKCI> BIBBKJADLLH(BKIFJPHNINC NONPDGFJDAK, FPIHCDKPOGD NIPBPKPBPPP, FEFPFDJPFJA.GNKGMJJDDPD HHFOMNMCPHO, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x2E3EAE0", Offset = "0x2E3D4E0", VA = "0x182E3EAE0")]
	[AsyncStateMachine(typeof(MPJBNIMJGFN))]
	private Task LOIMNJAMBDH(FDMJKHLGKCI NIPBPKPBPPP, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME, bool BHDBKAMDFDJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x2E3EDA0", Offset = "0x2E3D7A0", VA = "0x182E3EDA0")]
	[AsyncStateMachine(typeof(PAHLBBLDFND))]
	private Task PMJMGEBGAKJ(FDMJKHLGKCI NIPBPKPBPPP, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E740", Offset = "0x2E3D140", VA = "0x182E3E740")]
	private Task FHCOBECHFMO(FDMJKHLGKCI NIPBPKPBPPP, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D640", Offset = "0x2E3C040", VA = "0x182E3D640")]
	private Task ACBCNJJFNMH(FDMJKHLGKCI NIPBPKPBPPP, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D7E0", Offset = "0x2E3C1E0", VA = "0x182E3D7E0")]
	private Task ALFHEPGKHHO(FDMJKHLGKCI NIPBPKPBPPP, EJKMKHAAEAK JFMLDIGDPJP, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E0B0", Offset = "0x2E3CAB0", VA = "0x182E3E0B0")]
	private Task DGIMBPNDLBL(FDMJKHLGKCI NIPBPKPBPPP, EJKMKHAAEAK JFMLDIGDPJP, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x2E3EC40", Offset = "0x2E3D640", VA = "0x182E3EC40")]
	private static Task NGNDIJGJACM(CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D890", Offset = "0x2E3C290", VA = "0x182E3D890")]
	private Task BOADCHLPAEL(FDMJKHLGKCI NIPBPKPBPPP, EJKMKHAAEAK JFMLDIGDPJP, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E8A0", Offset = "0x2E3D2A0", VA = "0x182E3E8A0")]
	private Task GCGHAJCKHAD(FDMJKHLGKCI NIPBPKPBPPP, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E8C0", Offset = "0x2E3D2C0", VA = "0x182E3E8C0")]
	private void IGHHOGICDJN(BKIFJPHNINC NONPDGFJDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D9F0", Offset = "0x2E3C3F0", VA = "0x182E3D9F0")]
	private static void BOHCCPKMBLM(BIHOLPOPBIG BBBLPIMMPAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct HGEAPEMBGGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	private FDMJKHLGKCI NIPBPKPBPPP;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private IIFGAMEMGIC KKDHBDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x281E9E0", Offset = "0x281D3E0", VA = "0x18281E9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x281EA30", Offset = "0x281D430", VA = "0x18281EA30")]
	public static Task HHNJFAHFJBP(AHOGOPJAAEB BPCKLHHCJGL, FDMJKHLGKCI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x281EAD0", Offset = "0x281D4D0", VA = "0x18281EAD0")]
	private void HHNJFAHFJBP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct GPCPIEMOGJH
{
	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x281E180", Offset = "0x281CB80", VA = "0x18281E180")]
	public static Task HHNJFAHFJBP(CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal struct HBMHFLBGBCO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct DNCNDMAKLLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public PHJKBIIFKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private PPKCEHBLCJE <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x3571010", Offset = "0x356FA10", VA = "0x183571010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x281E890", Offset = "0x281D290", VA = "0x18281E890")]
	[AsyncStateMachine(typeof(DNCNDMAKLLC))]
	public static Task HHNJFAHFJBP(PHJKBIIFKDP FMCOAFCKPDJ, FDMJKHLGKCI NIPBPKPBPPP, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal struct GCMAEIFHAAO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct LEJAJCAPEHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public PHJKBIIFKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public EJKMKHAAEAK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private CCBILGENNND <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private AHOGOPJAAEB <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private IIFGAMEMGIC <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private List<(PersistenceView, AOGDKFHKIOB)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private AOGDKFHKIOB <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x357A510", Offset = "0x3578F10", VA = "0x18357A510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x281BA70", Offset = "0x281A470", VA = "0x18281BA70")]
	[AsyncStateMachine(typeof(LEJAJCAPEHM))]
	public static Task HHNJFAHFJBP(PHJKBIIFKDP FMCOAFCKPDJ, FDMJKHLGKCI NIPBPKPBPPP, EJKMKHAAEAK JFMLDIGDPJP, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x281BBE0", Offset = "0x281A5E0", VA = "0x18281BBE0")]
	private static void PBFCJEIKGHD(PersistenceView DICLGEOGLMC, AOGDKFHKIOB GDCPPPKHAKB, FDMJKHLGKCI NIPBPKPBPPP, CCBILGENNND EPGBDEENMAE, bool HOKABNOPGOE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal struct CHNOHNBEACE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct KFFPEELOKAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public AHOGOPJAAEB roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x2E393E0", Offset = "0x2E37DE0", VA = "0x182E393E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x280D180", Offset = "0x280BB80", VA = "0x18280D180")]
	[AsyncStateMachine(typeof(KFFPEELOKAG))]
	public static Task HHNJFAHFJBP(AHOGOPJAAEB BPCKLHHCJGL, FDMJKHLGKCI NIPBPKPBPPP, CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct LHKADAOMFJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct FEAIDPJBELH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AHOGOPJAAEB roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public PHJKBIIFKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x3572B80", Offset = "0x3571580", VA = "0x183572B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct MOLHFGNAOKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public LHKADAOMFJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private TaskAwaiter<CBPIBEEEMBL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x357D2D0", Offset = "0x357BCD0", VA = "0x18357D2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class BMLMBCBBOFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public GMCHMPCDOOP version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public BMLMBCBBOFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x356ED20", Offset = "0x356D720", VA = "0x18356ED20")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x356EE00", Offset = "0x356D800", VA = "0x18356EE00")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private FDMJKHLGKCI NIPBPKPBPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private PHJKBIIFKDP FMCOAFCKPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private bool BHDBKAMDFDJ;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private static readonly ByteString OPDHGLEFHLH;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private IIFGAMEMGIC KKDHBDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A360", Offset = "0x2E38D60", VA = "0x182E3A360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private GDIIDHNMKBB FKJMHDJKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A3B0", Offset = "0x2E38DB0", VA = "0x182E3A3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2E3A570", Offset = "0x2E38F70", VA = "0x182E3A570")]
	[AsyncStateMachine(typeof(FEAIDPJBELH))]
	public static Task HHNJFAHFJBP(AHOGOPJAAEB BPCKLHHCJGL, FDMJKHLGKCI NIPBPKPBPPP, PHJKBIIFKDP FMCOAFCKPDJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME, bool BHDBKAMDFDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2E3A430", Offset = "0x2E38E30", VA = "0x182E3A430")]
	[AsyncStateMachine(typeof(MOLHFGNAOKL))]
	private Task HHNJFAHFJBP(PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2E3A6E0", Offset = "0x2E390E0", VA = "0x182E3A6E0")]
	private void MPPGPFOJCIJ([NotNull] NNPMFHIGJPA JPCGJBHHDPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2E3ADD0", Offset = "0x2E397D0", VA = "0x182E3ADD0")]
	private bool OPLCCDPKJNN(GMCHMPCDOOP FMHBAJCDDEI, NNPMFHIGJPA JPCGJBHHDPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal struct DKDOAFLHLNA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct MBKODINADFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public AsyncTaskMethodBuilder<FDMJKHLGKCI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public DKDOAFLHLNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public FEFPFDJPFJA.GNKGMJJDDPD downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private PPKCEHBLCJE <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private TaskAwaiter<(global::HJJOMCAHDKC<CFJLMNDGPFO, PJMBHANDPHF>, global::HJJOMCAHDKC<global::MGCPIBOLANK<NNPMFHIGJPA>, PJMBHANDPHF>, global::HJJOMCAHDKC<global::MGCPIBOLANK<FKLFOLGOGPE>, PJMBHANDPHF>, global::HJJOMCAHDKC<global::MGCPIBOLANK<IFELJMKMFJP>, PJMBHANDPHF>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x2E3CCA0", Offset = "0x2E3B6A0", VA = "0x182E3CCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x2E3D560", Offset = "0x2E3BF60", VA = "0x182E3D560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct DAFGPHLLOKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public AsyncTaskMethodBuilder<global::HJJOMCAHDKC<CFJLMNDGPFO, PJMBHANDPHF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public PPKCEHBLCJE downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public DKDOAFLHLNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public FEFPFDJPFJA.GNKGMJJDDPD downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private PPKCEHBLCJE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private TaskAwaiter<global::HJJOMCAHDKC<CFJLMNDGPFO, PJMBHANDPHF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x2E34BE0", Offset = "0x2E335E0", VA = "0x182E34BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x2E350E0", Offset = "0x2E33AE0", VA = "0x182E350E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	private global::CBADPBPJIBN<BDADFHIJBPJ, FKLFOLGOGPE> EEKNGBBJLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	private global::CBADPBPJIBN<BDADFHIJBPJ, NNPMFHIGJPA> LJEEKDBBIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private global::CBADPBPJIBN<long, IFELJMKMFJP> KNADNJKLODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private CDPKCLHLDKA BECDFKCOBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private BKIFJPHNINC NONPDGFJDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private BIHOLPOPBIG BBBLPIMMPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private CKHPNKKDHCH PKJLKDEKHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private long OPBDCCPJIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private PPKCEHBLCJE CEJBHGLMENF;

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x280FB60", Offset = "0x280E560", VA = "0x18280FB60")]
	public static Task<FDMJKHLGKCI> NEEOMGKNFIL(AHOGOPJAAEB BPCKLHHCJGL, BKIFJPHNINC NONPDGFJDAK, in FPIHCDKPOGD NIPBPKPBPPP, FEFPFDJPFJA.GNKGMJJDDPD HHFOMNMCPHO, PPKCEHBLCJE CEJBHGLMENF, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x280F9B0", Offset = "0x280E3B0", VA = "0x18280F9B0")]
	[AsyncStateMachine(typeof(MBKODINADFP))]
	private Task<FDMJKHLGKCI> HHNJFAHFJBP(FEFPFDJPFJA.GNKGMJJDDPD HHFOMNMCPHO, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x280FB20", Offset = "0x280E520", VA = "0x18280FB20")]
	private BDADFHIJBPJ KHECJIFKKPO(JONPHOMAPAG PEPLNAGMNLP)
	{
		return default(BDADFHIJBPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x280FE80", Offset = "0x280E880", VA = "0x18280FE80")]
	[AsyncStateMachine(typeof(DAFGPHLLOKP))]
	private Task<global::HJJOMCAHDKC<CFJLMNDGPFO, PJMBHANDPHF>> PIOFIKLKMHN(string HLAOLJPPFIN, long OPBDCCPJIKP, FEFPFDJPFJA.GNKGMJJDDPD HHFOMNMCPHO, PPKCEHBLCJE IDBJCBDNIND, CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal struct NAFMBOJFGCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct NCNPAGNHAFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public AsyncTaskMethodBuilder<FPIHCDKPOGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public NAFMBOJFGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private PPKCEHBLCJE <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private TaskAwaiter<FPIHCDKPOGD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x4083550", Offset = "0x4081F50", VA = "0x184083550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x4083A00", Offset = "0x4082400", VA = "0x184083A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct AMLLCEFEPOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public AsyncTaskMethodBuilder<FPIHCDKPOGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public NAFMBOJFGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private TaskAwaiter<FPIHCDKPOGD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x4078AB0", Offset = "0x40774B0", VA = "0x184078AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x4078CA0", Offset = "0x40776A0", VA = "0x184078CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class EGJIKFOJOPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public EGJIKFOJOPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x10FACE0", Offset = "0x10F96E0", VA = "0x1810FACE0")]
		internal bool <FetchRoomDetails>b__0(CKHPNKKDHCH sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct NLMOGCFEPDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public AsyncTaskMethodBuilder<FPIHCDKPOGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public IIFGAMEMGIC callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private EGJIKFOJOPN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private PPKCEHBLCJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private TaskAwaiter<BIHOLPOPBIG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x4084450", Offset = "0x4082E50", VA = "0x184084450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x4084990", Offset = "0x4083390", VA = "0x184084990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private IIFGAMEMGIC EDFOBNPNANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private BCJAKJOCBPE CFGLODANGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private PPKCEHBLCJE CEJBHGLMENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private long ANAJKMBCHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private long DJKGICGFGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private string CFAFGEFFFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private BDADFHIJBPJ GFIAHMGMOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private BDADFHIJBPJ HLLFMBGAPJF;

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2E40280", Offset = "0x2E3EC80", VA = "0x182E40280")]
	public static Task<FPIHCDKPOGD> NEEOMGKNFIL(AHOGOPJAAEB BPCKLHHCJGL, BKIFJPHNINC NONPDGFJDAK, PPKCEHBLCJE CEJBHGLMENF, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2E3FF70", Offset = "0x2E3E970", VA = "0x182E3FF70")]
	[AsyncStateMachine(typeof(NCNPAGNHAFO))]
	private Task<FPIHCDKPOGD> HHNJFAHFJBP(CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x2E3FC30", Offset = "0x2E3E630", VA = "0x182E3FC30")]
	[AsyncStateMachine(typeof(AMLLCEFEPOP))]
	private Task<FPIHCDKPOGD> BMBLKLJHHLG(long ANAJKMBCHFB, long DJKGICGFGOE, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME, bool JEKBFLANJFA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x2E3FDC0", Offset = "0x2E3E7C0", VA = "0x182E3FDC0")]
	[AsyncStateMachine(typeof(NLMOGCFEPDM))]
	public static Task<FPIHCDKPOGD> BMBLKLJHHLG(IIFGAMEMGIC EDFOBNPNANH, long ANAJKMBCHFB, long DJKGICGFGOE, CancellationToken KAKEKEHNCME, PPKCEHBLCJE IFNGEGAGDGH, bool JEKBFLANJFA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2E3FF40", Offset = "0x2E3E940", VA = "0x182E3FF40")]
	private void FFBFAHNPNBA(BIHOLPOPBIG BBBLPIMMPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2E3FAC0", Offset = "0x2E3E4C0", VA = "0x182E3FAC0")]
	private bool AAGGNODONPL(FPIHCDKPOGD NIPBPKPBPPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x2E400D0", Offset = "0x2E3EAD0", VA = "0x182E400D0")]
	private void IHPMMDKMCMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct EFFGOFGBEFM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct OPEDAFIDHFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public EFFGOFGBEFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private PPKCEHBLCJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x2E45CB0", Offset = "0x2E446B0", VA = "0x182E45CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private const int NALIIIGDDFB = 20;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	private const float GGLNPHJGDPN = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private IIFGAMEMGIC EDFOBNPNANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	private FDMJKHLGKCI NIPBPKPBPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private PPKCEHBLCJE CEJBHGLMENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private float MAFBEECJDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private float ECLAIDMAJKM;

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x28139C0", Offset = "0x28123C0", VA = "0x1828139C0")]
	public static Task HEFHLLBOCBO(AHOGOPJAAEB BPCKLHHCJGL, FDMJKHLGKCI NIPBPKPBPPP, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2813B60", Offset = "0x2812560", VA = "0x182813B60")]
	[AsyncStateMachine(typeof(OPEDAFIDHFM))]
	public Task HHNJFAHFJBP(CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2813810", Offset = "0x2812210", VA = "0x182813810")]
	private static void DKANGLBELPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2813610", Offset = "0x2812010", VA = "0x182813610")]
	private void BLFBHJOLCKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2813550", Offset = "0x2811F50", VA = "0x182813550")]
	private static float AKMPOOBOKNH(IIFGAMEMGIC EDFOBNPNANH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x28137F0", Offset = "0x28121F0", VA = "0x1828137F0")]
	private static float COJEIEBAEBB()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct IBJKLLGBHEL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct KJDJKHIHJFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public PHJKBIIFKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private BLIAEEPMOEN <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private AHOGOPJAAEB <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private AEBCLONOPAG.IIDMIDBPABG <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private TaskAwaiter<CBPIBEEEMBL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x3579210", Offset = "0x3577C10", VA = "0x183579210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct FAOIIJILOPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private KPIDALKBJAI.MLNCPJHMJEC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x35724D0", Offset = "0x3570ED0", VA = "0x1835724D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x2822CB0", Offset = "0x28216B0", VA = "0x182822CB0")]
	[AsyncStateMachine(typeof(KJDJKHIHJFP))]
	public static Task HHNJFAHFJBP(PHJKBIIFKDP FMCOAFCKPDJ, FDMJKHLGKCI NIPBPKPBPPP, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x2822C40", Offset = "0x2821640", VA = "0x182822C40")]
	private static Task<CBPIBEEEMBL> AHIGEJDJDAO(PHJKBIIFKDP FMCOAFCKPDJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x2822E10", Offset = "0x2821810", VA = "0x182822E10")]
	[AsyncStateMachine(typeof(FAOIIJILOPM))]
	private static Task LDENMCLBOHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct FGMDEJLEOLF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct PIJMKICJOHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public FGMDEJLEOLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private PPKCEHBLCJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x3580BC0", Offset = "0x357F5C0", VA = "0x183580BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class ONEELHCCOPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ONEELHCCOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x3580AC0", Offset = "0x357F4C0", VA = "0x183580AC0")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct MKGGOEHGNEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public FGMDEJLEOLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private CDKKMCIAJAD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x357CAE0", Offset = "0x357B4E0", VA = "0x18357CAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private bool BPCKBOJGBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private PPKCEHBLCJE CEJBHGLMENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	private CancellationToken KAKEKEHNCME;

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x281A770", Offset = "0x2819170", VA = "0x18281A770")]
	public static Task DKOEHJCDCLA(AHOGOPJAAEB BPCKLHHCJGL, bool BPCKBOJGBND, PPKCEHBLCJE CEJBHGLMENF, CancellationToken EPLLLGAGFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x281A7E0", Offset = "0x28191E0", VA = "0x18281A7E0")]
	[AsyncStateMachine(typeof(PIJMKICJOHG))]
	private Task HHNJFAHFJBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x281A8F0", Offset = "0x28192F0", VA = "0x18281A8F0")]
	[AsyncStateMachine(typeof(MKGGOEHGNEA))]
	private Task PKHICEFEFFG(bool BOHHGFEMLNH, string DHEPJJLJLLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00")]
	private bool JFJKLHIKDGF(bool BPCKBOJGBND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct JAAHKCICDJB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct KCDMEHGPAIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public JAAHKCICDJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private PPKCEHBLCJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x3578D70", Offset = "0x3577770", VA = "0x183578D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x35791C0", Offset = "0x3577BC0", VA = "0x1835791C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class GJKHPMACEKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public GJKHPMACEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x3573B50", Offset = "0x3572550", VA = "0x183573B50")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct NAFJOABOGKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public JAAHKCICDJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private CDKKMCIAJAD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x357DB90", Offset = "0x357C590", VA = "0x18357DB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x357E080", Offset = "0x357CA80", VA = "0x18357E080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private CKDIMAPEKCL JFAEIAJAHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private PPKCEHBLCJE CEJBHGLMENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private bool ECPANAKNPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private FDMJKHLGKCI NIPBPKPBPPP;

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x2824050", Offset = "0x2822A50", VA = "0x182824050")]
	public static Task<Scene> OPGAOALIENE(AHOGOPJAAEB BPCKLHHCJGL, CKDIMAPEKCL HBEBPICLBFE, PPKCEHBLCJE CEJBHGLMENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x2823E10", Offset = "0x2822810", VA = "0x182823E10")]
	public static Task<Scene> CKAFGGBHKPO(AHOGOPJAAEB BPCKLHHCJGL, FDMJKHLGKCI NIPBPKPBPPP, PPKCEHBLCJE CEJBHGLMENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x2823F20", Offset = "0x2822920", VA = "0x182823F20")]
	[AsyncStateMachine(typeof(KCDMEHGPAIG))]
	private Task<Scene> HHNJFAHFJBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x2823DD0", Offset = "0x28227D0", VA = "0x182823DD0")]
	private bool ADILNAEKDFI(FDMJKHLGKCI NIPBPKPBPPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x2823EB0", Offset = "0x28228B0", VA = "0x182823EB0")]
	private void HBIDINONJKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x28240D0", Offset = "0x2822AD0", VA = "0x1828240D0")]
	[AsyncStateMachine(typeof(NAFJOABOGKE))]
	private Task<Scene> PKHICEFEFFG(string DHEPJJLJLLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct OJLPHBJEHNP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct HBKJHADHCKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public AsyncTaskMethodBuilder<CCBILGENNND> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public OJLPHBJEHNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public CCBILGENNND nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public FDMJKHLGKCI deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private PPKCEHBLCJE <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private TaskAwaiter<CCBILGENNND> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x407EDB0", Offset = "0x407D7B0", VA = "0x18407EDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x407F3A0", Offset = "0x407DDA0", VA = "0x18407F3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct FNCBLGNLECH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public AsyncTaskMethodBuilder<CCBILGENNND> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public OJLPHBJEHNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public CCBILGENNND state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private TaskAwaiter<CBPIBEEEMBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x407CF30", Offset = "0x407B930", VA = "0x18407CF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x407D1B0", Offset = "0x407BBB0", VA = "0x18407D1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private readonly PHJKBIIFKDP FMCOAFCKPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private readonly BCJAKJOCBPE CFGLODANGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private readonly FDONLJHLEIF FGMGCIIBAOI;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private BLIAEEPMOEN KKGAEEABJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x931D10", Offset = "0x930710", VA = "0x180931D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2E44580", Offset = "0x2E42F80", VA = "0x182E44580")]
	public OJLPHBJEHNP(PHJKBIIFKDP FMCOAFCKPDJ, BCJAKJOCBPE CFGLODANGMD, FDONLJHLEIF FGMGCIIBAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2E44210", Offset = "0x2E42C10", VA = "0x182E44210")]
	[AsyncStateMachine(typeof(HBKJHADHCKC))]
	public Task<CCBILGENNND> ELJBCJMDGND(CCBILGENNND LEFEDGLPLNA, FDMJKHLGKCI OOAJGFHOJOG, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME, bool OFLDKCGMGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2E440A0", Offset = "0x2E42AA0", VA = "0x182E440A0")]
	[AsyncStateMachine(typeof(FNCBLGNLECH))]
	private Task<CCBILGENNND> EAFPMNDCCAC(PPKCEHBLCJE IFNGEGAGDGH, CCBILGENNND MKPFHFLNAEL, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2E44550", Offset = "0x2E42F50", VA = "0x182E44550")]
	private bool LPGKHJKIFJC(CCBILGENNND FPMGDBJPNCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2E443B0", Offset = "0x2E42DB0", VA = "0x182E443B0")]
	private void FOPPOIAFNDG(string DBIMPNPPPLB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal struct POMPHNFJEOE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct MJOHIDAEPMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public BLIAEEPMOEN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public EJKMKHAAEAK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private List<(PersistenceView, AOGDKFHKIOB)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private (PersistenceView, AOGDKFHKIOB) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x4082010", Offset = "0x4080A10", VA = "0x184082010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2E49F80", Offset = "0x2E48980", VA = "0x182E49F80")]
	[AsyncStateMachine(typeof(MJOHIDAEPMM))]
	public static Task HHNJFAHFJBP(BLIAEEPMOEN LDDMJCCAAEJ, FDMJKHLGKCI NIPBPKPBPPP, EJKMKHAAEAK JFMLDIGDPJP, CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct DNHLFBACGLF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct AFKOMJKBGJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public BLIAEEPMOEN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public EJKMKHAAEAK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private GMCHMPCDOOP <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private List<(PersistenceView, AOGDKFHKIOB)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private AOGDKFHKIOB <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x2E33090", Offset = "0x2E31A90", VA = "0x182E33090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2812F00", Offset = "0x2811900", VA = "0x182812F00")]
	[AsyncStateMachine(typeof(AFKOMJKBGJG))]
	public static Task HHNJFAHFJBP(BLIAEEPMOEN LDDMJCCAAEJ, FDMJKHLGKCI NIPBPKPBPPP, EJKMKHAAEAK JFMLDIGDPJP, CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal struct AEBCLONOPAG
{
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public struct IIDMIDBPABG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public List<JBIPENBLOOE> BPMCCKONOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public List<AOGDKFHKIOB> GBOPFBCHFBE;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x771A10", Offset = "0x770410", VA = "0x180771A10")]
		public IIDMIDBPABG(List<JBIPENBLOOE> BPMCCKONOCD, List<AOGDKFHKIOB> GBOPFBCHFBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class FCBLFFMEEDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public IEnumerable<JBIPENBLOOE> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public FCBLFFMEEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x2E368A0", Offset = "0x2E352A0", VA = "0x182E368A0")]
		internal object <TryBulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private FDMJKHLGKCI NIPBPKPBPPP;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private IIFGAMEMGIC KKDHBDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x2806A20", Offset = "0x2805420", VA = "0x182806A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x2806D90", Offset = "0x2805790", VA = "0x182806D90")]
	public static IIDMIDBPABG HHNJFAHFJBP(AHOGOPJAAEB BPCKLHHCJGL, FDMJKHLGKCI NIPBPKPBPPP)
	{
		return default(IIDMIDBPABG);
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x2806A70", Offset = "0x2805470", VA = "0x182806A70")]
	private IIDMIDBPABG HHNJFAHFJBP()
	{
		return default(IIDMIDBPABG);
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x2806DF0", Offset = "0x28057F0", VA = "0x182806DF0")]
	private IIDMIDBPABG IMJAGKKGNDK(NNPMFHIGJPA JPCGJBHHDPC, GMCHMPCDOOP EODIEHDJNNA)
	{
		return default(IIDMIDBPABG);
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x2807340", Offset = "0x2805D40", VA = "0x182807340")]
	private bool MEDIFIIJCIK(IEnumerable<JBIPENBLOOE> BPMCCKONOCD)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014D")]
internal struct ABEAKNGEKCD
{
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class AIOIGNDJMAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public AEBCLONOPAG.IIDMIDBPABG instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public AIOIGNDJMAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2E337B0", Offset = "0x2E321B0", VA = "0x182E337B0")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class FDKFOIPAALK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public FDKFOIPAALK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2E36920", Offset = "0x2E35320", VA = "0x182E36920")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x2806370", Offset = "0x2804D70", VA = "0x182806370")]
	public static void HHNJFAHFJBP(BLIAEEPMOEN LDDMJCCAAEJ, FDMJKHLGKCI NIPBPKPBPPP, AEBCLONOPAG.IIDMIDBPABG GMGPDFDDHEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
internal struct HKEFNKFCHKB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct FBLEPFAMBKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public AHOGOPJAAEB roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public PHJKBIIFKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x3572780", Offset = "0x3571180", VA = "0x183572780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct JPFCOBDNLNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public HKEFNKFCHKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x3577E40", Offset = "0x3576840", VA = "0x183577E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private FDMJKHLGKCI NIPBPKPBPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private ByteString IPCFABOJCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private PHJKBIIFKDP FMCOAFCKPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private bool MEDGBFONIKE;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private IIFGAMEMGIC KKDHBDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x28206A0", Offset = "0x281F0A0", VA = "0x1828206A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private bool GFPKEGDOAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2820990", Offset = "0x281F390", VA = "0x182820990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private bool KEOOJOCJDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x2820A10", Offset = "0x281F410", VA = "0x182820A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x2820820", Offset = "0x281F220", VA = "0x182820820")]
	[AsyncStateMachine(typeof(FBLEPFAMBKM))]
	public static Task HHNJFAHFJBP(AHOGOPJAAEB BPCKLHHCJGL, FDMJKHLGKCI NIPBPKPBPPP, PHJKBIIFKDP FMCOAFCKPDJ, bool MEDGBFONIKE, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x28206F0", Offset = "0x281F0F0", VA = "0x1828206F0")]
	[AsyncStateMachine(typeof(JPFCOBDNLNM))]
	private Task HHNJFAHFJBP(PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal class FDONLJHLEIF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct ECIGGDADKOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public FDONLJHLEIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public CCBILGENNND operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public FDMJKHLGKCI deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public PPKCEHBLCJE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x3571490", Offset = "0x356FE90", VA = "0x183571490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class AMJPEELBMOJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000156")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000590")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			public AMJPEELBMOJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x4088FA0", Offset = "0x40879A0", VA = "0x184088FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public FDONLJHLEIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public PPKCEHBLCJE handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public AMJPEELBMOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x356D3A0", Offset = "0x356BDA0", VA = "0x18356D3A0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct HNOBDMJJNFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public FDONLJHLEIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public PPKCEHBLCJE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private AMJPEELBMOJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x3574CB0", Offset = "0x35736B0", VA = "0x183574CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct BJEFNDBIMMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public FDONLJHLEIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public PPKCEHBLCJE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private PPKCEHBLCJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private Dictionary<Guid, List<IIKJDPCCGKJ>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x356D8A0", Offset = "0x356C2A0", VA = "0x18356D8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct MHABMIELNEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public FDONLJHLEIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public PPKCEHBLCJE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private PPKCEHBLCJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private Dictionary<Guid, List<IIKJDPCCGKJ>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x357C180", Offset = "0x357AB80", VA = "0x18357C180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class JJCECHKGGDN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200015B")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			public IIKJDPCCGKJ handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			public JJCECHKGGDN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0x4086AC0", Offset = "0x40854C0", VA = "0x184086AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public CGHPMNKCJCN runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public List<IIKJDPCCGKJ> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public JJCECHKGGDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x35775B0", Offset = "0x3575FB0", VA = "0x1835775B0")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x3577790", Offset = "0x3576190", VA = "0x183577790")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(IIKJDPCCGKJ handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x35776A0", Offset = "0x35760A0", VA = "0x1835776A0")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct JKPPHLOGNCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public CGHPMNKCJCN runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public List<IIKJDPCCGKJ> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private JJCECHKGGDN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x35778B0", Offset = "0x35762B0", VA = "0x1835778B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct GJDPGDLMDIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public FDONLJHLEIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public PPKCEHBLCJE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x35738D0", Offset = "0x35722D0", VA = "0x1835738D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class BNEBJBCICFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public BNEBJBCICFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x356EEB0", Offset = "0x356D8B0", VA = "0x18356EEB0")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct MJHOGINCDBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public FDONLJHLEIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x357C680", Offset = "0x357B080", VA = "0x18357C680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class MDIHLDMHKPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public MDIHLDMHKPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x357C110", Offset = "0x357AB10", VA = "0x18357C110")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct PJPMOLMNCGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public FDONLJHLEIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private TaskAwaiter<CBPIBEEEMBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x35810C0", Offset = "0x357FAC0", VA = "0x1835810C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class ELJJKGLAIML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ELJJKGLAIML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x3572130", Offset = "0x3570B30", VA = "0x183572130")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private readonly PHJKBIIFKDP FMCOAFCKPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	private GPHGAPLLDOG FGMGCIIBAOI;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private BLIAEEPMOEN KKGAEEABJHD
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x816680", Offset = "0x815080", VA = "0x180816680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F40", Offset = "0x6C0940", VA = "0x1806C1F40")]
	public FDONLJHLEIF(PHJKBIIFKDP FMCOAFCKPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2819AB0", Offset = "0x28184B0", VA = "0x182819AB0")]
	[AsyncStateMachine(typeof(ECIGGDADKOM))]
	public Task HHNJFAHFJBP(CCBILGENNND EPGBDEENMAE, FDMJKHLGKCI OOAJGFHOJOG, PPKCEHBLCJE CEJBHGLMENF, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x2819810", Offset = "0x2818210", VA = "0x182819810")]
	[AsyncStateMachine(typeof(HNOBDMJJNFO))]
	private Task GBIMGMNMGEM(FDMJKHLGKCI NIPBPKPBPPP, PPKCEHBLCJE CEJBHGLMENF, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x28196B0", Offset = "0x28180B0", VA = "0x1828196B0")]
	[AsyncStateMachine(typeof(BJEFNDBIMMK))]
	private Task FCOAOJJEHAA(FDMJKHLGKCI NIPBPKPBPPP, PPKCEHBLCJE CEJBHGLMENF, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x2819EB0", Offset = "0x28188B0", VA = "0x182819EB0")]
	[AsyncStateMachine(typeof(MHABMIELNEO))]
	private Task PBEFGGFFGFL(FDMJKHLGKCI NIPBPKPBPPP, PPKCEHBLCJE CEJBHGLMENF, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x2819440", Offset = "0x2817E40", VA = "0x182819440")]
	[AsyncStateMachine(typeof(JKPPHLOGNCA))]
	private Task EPPGEBMONEE(Guid IOHNAGKCOAN, List<IIKJDPCCGKJ> BOBNKDAJHEF, CGHPMNKCJCN BIFPEMJGJOE, FDMJKHLGKCI NIPBPKPBPPP, CancellationToken DEGCIHEAIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x2819C10", Offset = "0x2818610", VA = "0x182819C10")]
	[AsyncStateMachine(typeof(GJDPGDLMDIP))]
	private Task KFHFPODCNFB(FDMJKHLGKCI NIPBPKPBPPP, PPKCEHBLCJE CEJBHGLMENF, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x2819970", Offset = "0x2818370", VA = "0x182819970")]
	[AsyncStateMachine(typeof(MJHOGINCDBD))]
	private Task GHLJNLEAPCN(Guid HPLNJOABIGP, FDMJKHLGKCI NIPBPKPBPPP, PPKCEHBLCJE CEJBHGLMENF, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x2819D60", Offset = "0x2818760", VA = "0x182819D60")]
	[AsyncStateMachine(typeof(PJPMOLMNCGI))]
	private Task ODGOIBHAGNL(Guid HPLNJOABIGP, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x28192A0", Offset = "0x2817CA0", VA = "0x1828192A0")]
	private void COPLLNLEFLM(Guid HPLNJOABIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x2819580", Offset = "0x2817F80", VA = "0x182819580")]
	private void FCCEJLECLDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x28190D0", Offset = "0x2817AD0", VA = "0x1828190D0")]
	public Guid CFCNPLMIHNJ(CCBILGENNND BDIBHEOCJAD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x2818F00", Offset = "0x2817900", VA = "0x182818F00")]
	[CompilerGenerated]
	private object BKJHJFMMCMG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal struct FIFIDGIKKEB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct BJPOEIAIIAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public AHOGOPJAAEB roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public FDMJKHLGKCI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public PHJKBIIFKDP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x356DD20", Offset = "0x356C720", VA = "0x18356DD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x356DF20", Offset = "0x356C920", VA = "0x18356DF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct LHMBPKMNBGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public FIFIDGIKKEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private bool <reloadSceneForObjectModel>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x357B000", Offset = "0x3579A00", VA = "0x18357B000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x357B540", Offset = "0x3579F40", VA = "0x18357B540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private AHOGOPJAAEB BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private FDMJKHLGKCI NIPBPKPBPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private ByteString IPCFABOJCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private PHJKBIIFKDP FMCOAFCKPDJ;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private IIFGAMEMGIC KKDHBDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x281AA20", Offset = "0x2819420", VA = "0x18281AA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private bool GFPKEGDOAOL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x281AD60", Offset = "0x2819760", VA = "0x18281AD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private bool KEOOJOCJDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x281ADE0", Offset = "0x28197E0", VA = "0x18281ADE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private bool EHOMEJIDIEP
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x281AE70", Offset = "0x2819870", VA = "0x18281AE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x281ABD0", Offset = "0x28195D0", VA = "0x18281ABD0")]
	[AsyncStateMachine(typeof(BJPOEIAIIAK))]
	public static Task<bool> HHNJFAHFJBP(AHOGOPJAAEB BPCKLHHCJGL, FDMJKHLGKCI NIPBPKPBPPP, PHJKBIIFKDP FMCOAFCKPDJ, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x281AA70", Offset = "0x2819470", VA = "0x18281AA70")]
	[AsyncStateMachine(typeof(LHMBPKMNBGP))]
	private Task<bool> HHNJFAHFJBP(PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
public readonly struct OCNLFCGGDIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	[CanBeNull]
	public readonly NNPMFHIGJPA DGAOPADOAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	[NotNull]
	public readonly DJONLHOLBOA NNBEDHIGLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	[CanBeNull]
	public readonly string HNKHJEMCEGN;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public IReadOnlyCollection<string> MLPIKHALCIH
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x2E42970", Offset = "0x2E41370", VA = "0x182E42970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public IReadOnlyDictionary<long, int> LGHDCHEOIIA
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x2E42990", Offset = "0x2E41390", VA = "0x182E42990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x2E429B0", Offset = "0x2E413B0", VA = "0x182E429B0")]
	public OCNLFCGGDIP([CanBeNull] NNPMFHIGJPA FGCBFOCODMG, [NotNull] DJONLHOLBOA JOLGAMKJIIK, [CanBeNull] string HLAOLJPPFIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal class HKGMKBEEMHC : KJCOAHDLLHM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct KAFOPFIFHMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public AsyncTaskMethodBuilder<OCNLFCGGDIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public HKGMKBEEMHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public EPCNJJPDOKP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x3578220", Offset = "0x3576C20", VA = "0x183578220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x35786C0", Offset = "0x35770C0", VA = "0x1835786C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class IIKCNKIHLBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public EPCNJJPDOKP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public IIKCNKIHLBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x35758F0", Offset = "0x35742F0", VA = "0x1835758F0")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class DHMJBACNAMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public IIKCNKIHLBI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public DHMJBACNAMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x3570B10", Offset = "0x356F510", VA = "0x183570B10")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class HMGFBMANBGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public IIKCNKIHLBI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public HMGFBMANBGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x3574C70", Offset = "0x3573670", VA = "0x183574C70")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct NIEHLNAHODP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public EPCNJJPDOKP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public HKGMKBEEMHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private DHMJBACNAMD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private KPIDALKBJAI.EFKGHGOHEHH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x357F560", Offset = "0x357DF60", VA = "0x18357F560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private readonly PLAMFHPFEGH PMIMLGGAICF;

	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private static readonly TimeSpan DCICEIFHHAK;

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x2821C50", Offset = "0x2820650", VA = "0x182821C50")]
	public HKGMKBEEMHC(PHJKBIIFKDP FMCOAFCKPDJ, [Optional] PLAMFHPFEGH? PMIMLGGAICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x2821000", Offset = "0x281FA00", VA = "0x182821000")]
	[AsyncStateMachine(typeof(KAFOPFIFHMO))]
	public Task<OCNLFCGGDIP> JHPOCMCIPNJ(long DJKGICGFGOE, string HLAOLJPPFIN, EPCNJJPDOKP OAHECELLGFO, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x2820CC0", Offset = "0x281F6C0", VA = "0x182820CC0")]
	[AsyncStateMachine(typeof(NIEHLNAHODP))]
	private Task EJBEHFJJGPM(EPCNJJPDOKP OAHECELLGFO, IEnumerable<PersistenceView> EDDDOFKJPMF, StringBuilder APPMNPOOBKD, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x28216F0", Offset = "0x28200F0", VA = "0x1828216F0")]
	private OCNLFCGGDIP LMJEHFNABEN(long DJKGICGFGOE, string HLAOLJPPFIN, EPCNJJPDOKP OAHECELLGFO, IEnumerable<PersistenceView> EDDDOFKJPMF, StringBuilder APPMNPOOBKD)
	{
		return default(OCNLFCGGDIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x2820E20", Offset = "0x281F820", VA = "0x182820E20")]
	private NNPMFHIGJPA FJLIKPHDBFD(long DJKGICGFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x2820AA0", Offset = "0x281F4A0", VA = "0x182820AA0")]
	private void AHCMMBBGFJG(NNPMFHIGJPA OEHIKOADNEH, StringBuilder APPMNPOOBKD, IEnumerable<PersistenceView> EDDDOFKJPMF, in ANJDDDPAFFI JAGMMDGFNGO, ref GNCDCAIKNKC LDDAKJJOCDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x2821180", Offset = "0x281FB80", VA = "0x182821180")]
	private void KLPLHJMNHGE(NNPMFHIGJPA OEHIKOADNEH, StringBuilder APPMNPOOBKD, PersistenceView DICLGEOGLMC, ref GNCDCAIKNKC LDDAKJJOCDP, in ANJDDDPAFFI JAGMMDGFNGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
internal class GJPAIHKAMLN : KJCOAHDLLHM
{
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private sealed class HCBCKDHFGAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public AEEJOBEHCBE.EEJEEEBFGDN roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AEEJOBEHCBE.EEJEEEBFGDN subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public HCBCKDHFGAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x3573BA0", Offset = "0x35725A0", VA = "0x183573BA0")]
		internal object <UploadRoomDataToStorage>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x3573C30", Offset = "0x3572630", VA = "0x183573C30")]
		internal object <UploadRoomDataToStorage>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x3573C80", Offset = "0x3572680", VA = "0x183573C80")]
		internal object <UploadRoomDataToStorage>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x3573CF0", Offset = "0x35726F0", VA = "0x183573CF0")]
		internal object <UploadRoomDataToStorage>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct JAGEIBFCHKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public AsyncTaskMethodBuilder<(AEEJOBEHCBE.EEJEEEBFGDN roomDataUpload, AEEJOBEHCBE.EEJEEEBFGDN subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public OCNLFCGGDIP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public GJPAIHKAMLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private HCBCKDHFGAJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private TaskAwaiter<AEEJOBEHCBE.EEJEEEBFGDN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x3576420", Offset = "0x3574E20", VA = "0x183576420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x3576F20", Offset = "0x3575920", VA = "0x183576F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct AGIEJKJAMGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public AsyncTaskMethodBuilder<LFADINBGMLP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public GJPAIHKAMLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public OCNLFCGGDIP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public PGFLJPDKEFM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private TaskAwaiter<(AEEJOBEHCBE.EEJEEEBFGDN roomDataUpload, AEEJOBEHCBE.EEJEEEBFGDN subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private TaskAwaiter<LFADINBGMLP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x356CC80", Offset = "0x356B680", VA = "0x18356CC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x356D140", Offset = "0x356BB40", VA = "0x18356D140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct AOFPMPKPBAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public AsyncTaskMethodBuilder<KDNHOHLLBHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public GJPAIHKAMLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public OCNLFCGGDIP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private TaskAwaiter<(AEEJOBEHCBE.EEJEEEBFGDN roomDataUpload, AEEJOBEHCBE.EEJEEEBFGDN subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private TaskAwaiter<KDNHOHLLBHL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x356D4C0", Offset = "0x356BEC0", VA = "0x18356D4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x356D850", Offset = "0x356C250", VA = "0x18356D850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private sealed class LJFGCOBHIME
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000175")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000645")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000646")]
			public AsyncTaskMethodBuilder<CBPIBEEEMBL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000647")]
			public LJFGCOBHIME <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000648")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000649")]
			private CBPIBEEEMBL <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400064A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400064B")]
			private TaskAwaiter<KDNHOHLLBHL> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400064C")]
			private TaskAwaiter<LFADINBGMLP> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400064D")]
			private TaskAwaiter<CBPIBEEEMBL> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0x4089480", Offset = "0x4087E80", VA = "0x184089480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x408A000", Offset = "0x4088A00", VA = "0x18408A000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public GJPAIHKAMLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public OCNLFCGGDIP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public PGFLJPDKEFM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public LJFGCOBHIME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x357B590", Offset = "0x3579F90", VA = "0x18357B590")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<CBPIBEEEMBL> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct CAJHCNLDMKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public AsyncTaskMethodBuilder<CBPIBEEEMBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public GJPAIHKAMLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public OCNLFCGGDIP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public PGFLJPDKEFM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private TaskAwaiter<CBPIBEEEMBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x356F480", Offset = "0x356DE80", VA = "0x18356F480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x356F730", Offset = "0x356E130", VA = "0x18356F730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000619")]
	private const float DHFKBKLGMLO = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private readonly CFOAOPPKJBC JLMEAOKHODO;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private AHOGOPJAAEB DOMPCIMBOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x281C580", Offset = "0x281AF80", VA = "0x18281C580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x281C8B0", Offset = "0x281B2B0", VA = "0x18281C8B0")]
	public GJPAIHKAMLN(PHJKBIIFKDP FMCOAFCKPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x281C740", Offset = "0x281B140", VA = "0x18281C740")]
	[AsyncStateMachine(typeof(JAGEIBFCHKG))]
	private Task<(AEEJOBEHCBE.EEJEEEBFGDN, AEEJOBEHCBE.EEJEEEBFGDN)> OIOPBCMFCKB(OCNLFCGGDIP KHEKPGMMFPH, long ANAJKMBCHFB, long DJFDGMPNMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x281C5B0", Offset = "0x281AFB0", VA = "0x18281C5B0")]
	[AsyncStateMachine(typeof(AGIEJKJAMGN))]
	public Task<LFADINBGMLP> HFLHKOEBHFA(int FGKCBIDBKEO, [CanBeNull] PGFLJPDKEFM MCIIIGHPBOK, OCNLFCGGDIP KHEKPGMMFPH, long ANAJKMBCHFB, long DJFDGMPNMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x281C240", Offset = "0x281AC40", VA = "0x18281C240")]
	[AsyncStateMachine(typeof(AOFPMPKPBAE))]
	private Task<KDNHOHLLBHL> DHMEFKBILGC(string NJCPAEPCFCM, int FGKCBIDBKEO, OCNLFCGGDIP KHEKPGMMFPH, long ANAJKMBCHFB, long DJFDGMPNMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x281C3D0", Offset = "0x281ADD0", VA = "0x18281C3D0")]
	[AsyncStateMachine(typeof(CAJHCNLDMKD))]
	public Task<CBPIBEEEMBL> EGDDMLIJKHH(int FGKCBIDBKEO, [CanBeNull] PGFLJPDKEFM MCIIIGHPBOK, OCNLFCGGDIP KHEKPGMMFPH, long ANAJKMBCHFB, long DJFDGMPNMLL, PPKCEHBLCJE IFNGEGAGDGH, CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
public abstract class IMAGMOJCJKE<T> where T : global::IMAGMOJCJKE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000659")]
	internal readonly AHOGOPJAAEB HGDNMMOGLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400065A")]
	private int? DOOAACILNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400065B")]
	protected readonly Guid ANPCHMGMLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400065C")]
	protected readonly KLANEEMABFB CFJDFIKEPKF;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	protected T GKLMBHAHAMC
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x23A73C0", Offset = "0x23A5DC0", VA = "0x1823A73C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x23A7710", Offset = "0x23A6110", VA = "0x1823A7710")]
	internal IMAGMOJCJKE(AHOGOPJAAEB JMFBIGEENMB, KLANEEMABFB EKGFPKDOIBA, [Optional] Guid? EPCIDCJCNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x23A7630", Offset = "0x23A6030", VA = "0x1823A7630")]
	private CBPIBEEEMBL NEPADPOEOIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "4")]
	protected virtual void AMLCOIKGNJG(CBPIBEEEMBL EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x23A7420", Offset = "0x23A5E20", VA = "0x1823A7420")]
	public T ALJAELOCODO(BNMLLFBMDOA BIJLNBDIJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x23A75B0", Offset = "0x23A5FB0", VA = "0x1823A75B0")]
	public T FLBAFBKEMFC(int LCMEAHIFPED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x23A74B0", Offset = "0x23A5EB0", VA = "0x1823A74B0", Slot = "5")]
	public virtual Task<MPFEOFKMCLF> DLGOBHOOBCC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public class GAMHHFNCFOO : global::IMAGMOJCJKE<GAMHHFNCFOO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400065D")]
	private BKIFJPHNINC EONCDECCEBA;

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x281B940", Offset = "0x281A340", VA = "0x18281B940")]
	internal GAMHHFNCFOO(AHOGOPJAAEB JMFBIGEENMB, KLANEEMABFB EKGFPKDOIBA, [Optional] Guid? EPCIDCJCNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x281B920", Offset = "0x281A320", VA = "0x18281B920")]
	public GAMHHFNCFOO CJJBFMEMOCP(BKIFJPHNINC EONCDECCEBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x281B860", Offset = "0x281A260", VA = "0x18281B860", Slot = "4")]
	protected override void AMLCOIKGNJG(CBPIBEEEMBL EJEIJOMMNGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public class DOIJMLLBAMJ : global::IMAGMOJCJKE<DOIJMLLBAMJ>
{
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	internal enum EABPJHCMIBL
	{
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct EIPIFCFNLOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public AsyncTaskMethodBuilder<MPFEOFKMCLF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public DOIJMLLBAMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter<MPFEOFKMCLF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x2E36160", Offset = "0x2E34B60", VA = "0x182E36160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x2E36460", Offset = "0x2E34E60", VA = "0x182E36460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400065E")]
	private EABPJHCMIBL MOCMLIMJCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	private string ADLHGGFJGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	private PGFLJPDKEFM EONCDECCEBA;

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x28133D0", Offset = "0x2811DD0", VA = "0x1828133D0")]
	internal DOIJMLLBAMJ(AHOGOPJAAEB JMFBIGEENMB, KLANEEMABFB EKGFPKDOIBA, [Optional] Guid? EPCIDCJCNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x2813350", Offset = "0x2811D50", VA = "0x182813350")]
	public DOIJMLLBAMJ HHLAALGPBPB(string OKLCPOPPNGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x28133B0", Offset = "0x2811DB0", VA = "0x1828133B0")]
	public DOIJMLLBAMJ LLMKJECBJHN(bool GLFNBLJLODM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x2813380", Offset = "0x2811D80", VA = "0x182813380")]
	public DOIJMLLBAMJ LFHJEAHIDHM(string NKNOOFILFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x28131C0", Offset = "0x2811BC0", VA = "0x1828131C0")]
	public DOIJMLLBAMJ APFBLMCCFPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x2813050", Offset = "0x2811A50", VA = "0x182813050", Slot = "4")]
	protected override void AMLCOIKGNJG(CBPIBEEEMBL EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x2813230", Offset = "0x2811C30", VA = "0x182813230", Slot = "5")]
	[AsyncStateMachine(typeof(EIPIFCFNLOC))]
	public override Task<MPFEOFKMCLF> DLGOBHOOBCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x28131F0", Offset = "0x2811BF0", VA = "0x1828131F0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<MPFEOFKMCLF> CBLKBPCFGNB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal static class CEDBMNFGAKD
{
	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x280C2D0", Offset = "0x280ACD0", VA = "0x18280C2D0")]
	public static void FNCOMKCFNIF(this ABDJCJMAGOJ JNCPABDAECF, CMGFGGHOKOI NLLKOGDPODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x280C1F0", Offset = "0x280ABF0", VA = "0x18280C1F0")]
	public static void BJIMFPINMFF(this CMGFGGHOKOI IDHGMFMNLEP, [Optional] string EJEIJOMMNGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public static class LCHHIMGFDLL
{
	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x2E39830", Offset = "0x2E38230", VA = "0x182E39830")]
	public static BDADFHIJBPJ EJCHFBLJCMH(this JONPHOMAPAG PEPLNAGMNLP)
	{
		return default(BDADFHIJBPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x2E398D0", Offset = "0x2E382D0", VA = "0x182E398D0")]
	public static JONPHOMAPAG JNNDAPIDJBE(this BDADFHIJBPJ FJFHGALHLDM)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200017F")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400066D")]
			public OAPFICFJIOF ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400066E")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400066F")]
			public OAPFICFJIOF HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000670")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000671")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000672")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private static OAPFICFJIOF[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private Dictionary<OAPFICFJIOF, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2E4AAE0", Offset = "0x2E494E0", VA = "0x182E4AAE0")]
		public bool GNLBDMNBKEO(OAPFICFJIOF BHEMOOALKFC, out ResultConfig NIFCFEIBHMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2E4AB50", Offset = "0x2E49550", VA = "0x182E4AB50")]
		public ResultConfig NCLOICONNEH(OAPFICFJIOF JMBFNCMEOEA, [Optional] HashSet<OAPFICFJIOF> OAAOOIOJODP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2E4B1F0", Offset = "0x2E49BF0", VA = "0x182E4B1F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2E4AC70", Offset = "0x2E49670", VA = "0x182E4AC70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BFB0", Offset = "0xE1A9B0", VA = "0x180E1BFB0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
public static class GLIGENNEAPJ
{
	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x281D150", Offset = "0x281BB50", VA = "0x18281D150")]
	[CJJNALDLMHL(HFKENCJEONK.GameOnly)]
	private static void AMHBNEJDOHO(PLIBOCMCGIC BLCDILGLELM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
public interface BMIHFLGADPJ : IEquatable<BMIHFLGADPJ>
{
	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	IJFCFHFOBPN FHLGOHKIKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	DateTime CJMHOMMDOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EJALFGMIKGJ();

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HNIMIOJCGEJ(long ANAJKMBCHFB, long DJKGICGFGOE, out OCNLFCGGDIP KHEKPGMMFPH);
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal class IPFKGCDALEC : IPILFBEHJNA
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class LMLHHHKNGOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public EJAEMPHNCCB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public LMLHHHKNGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x357C0A0", Offset = "0x357AAA0", VA = "0x18357C0A0")]
		internal object <TrySaveAutosaveData>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	private readonly LGDCAGPKCBB LPMGNNOKGMK;

	[Cpp2IlInjected.Token(Token = "0x4000679")]
	private const int FMBPEJGKOMK = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event Action<BMIHFLGADPJ> AGNAJNPHALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x28232D0", Offset = "0x2821CD0", VA = "0x1828232D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x2823230", Offset = "0x2821C30", VA = "0x182823230", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F40", Offset = "0x6C0940", VA = "0x1806C1F40")]
	[UnityEngine.Scripting.Preserve]
	public IPFKGCDALEC([HGGCKJALFAG(null)] LGDCAGPKCBB LPMGNNOKGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x2823760", Offset = "0x2822160", VA = "0x182823760", Slot = "6")]
	public bool FIBEANJPHEJ(long ANAJKMBCHFB, long DJKGICGFGOE, OCNLFCGGDIP KHEKPGMMFPH, EJAEMPHNCCB ADIFNIMFLJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x2823A60", Offset = "0x2822460", VA = "0x182823A60")]
	private void LLGNLLBBOKL(BMIHFLGADPJ CJMCLFOEGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x2822EE0", Offset = "0x28218E0", VA = "0x182822EE0", Slot = "7")]
	public bool AEEKGDBBEMI(long ANAJKMBCHFB, long DJKGICGFGOE, out BMIHFLGADPJ LKDJBANFPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x2823060", Offset = "0x2821A60", VA = "0x182823060", Slot = "8")]
	public bool CIDGNBCLKPM(long ANAJKMBCHFB, long DJKGICGFGOE, EJAEMPHNCCB ADIFNIMFLJN, out BMIHFLGADPJ LKDJBANFPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x2823370", Offset = "0x2821D70", VA = "0x182823370")]
	private void EOJDMHDJEIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x2823110", Offset = "0x2821B10", VA = "0x182823110", Slot = "9")]
	public void DBPLGOJBFFC(long ANAJKMBCHFB, long DJKGICGFGOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal abstract class DHPOJECJBMM : LGDCAGPKCBB
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	protected enum POBPPJKPDDN : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class PGCJMKDJPBF : IEnumerable<BMIHFLGADPJ>, IEnumerable, IEnumerator<BMIHFLGADPJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private BMIHFLGADPJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public DHPOJECJBMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private EJAEMPHNCCB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public EJAEMPHNCCB <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		private BMIHFLGADPJ System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
		[DebuggerHidden]
		public PGCJMKDJPBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2E47740", Offset = "0x2E46140", VA = "0x182E47740", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x2E47950", Offset = "0x2E46350", VA = "0x182E47950", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x2E478A0", Offset = "0x2E462A0", VA = "0x182E478A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BMIHFLGADPJ> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x2E478A0", Offset = "0x2E462A0", VA = "0x182E478A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class MJFHDLHIBCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public EJAEMPHNCCB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public MJFHDLHIBCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x2E3D5B0", Offset = "0x2E3BFB0", VA = "0x182E3D5B0")]
		internal object <SaveAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class AIMABNMBKMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public DHPOJECJBMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public AIMABNMBKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x2E33780", Offset = "0x2E32180", VA = "0x182E33780")]
		internal void <TryReadAutosaveFile>b__0(GOJJMPLDEFA.IAIFOMJLLOD ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	protected readonly string JOMPFNGEOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	private readonly object DKKLAFPNEJP;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract IJFCFHFOBPN FHLGOHKIKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x280E920", Offset = "0x280D320", VA = "0x18280E920")]
	protected DHPOJECJBMM([CanBeNull] string GIECGMAANPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x280E740", Offset = "0x280D140", VA = "0x18280E740", Slot = "5")]
	public bool NOCFDHAGAHD(long ANAJKMBCHFB, long DJKGICGFGOE, EJAEMPHNCCB ADIFNIMFLJN, out BMIHFLGADPJ CJMCLFOEGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x280E050", Offset = "0x280CA50", VA = "0x18280E050", Slot = "6")]
	[IteratorStateMachine(typeof(PGCJMKDJPBF))]
	public IEnumerable<BMIHFLGADPJ> ABHOICFPPON(EJAEMPHNCCB ADIFNIMFLJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void IJMLADJCKJD(Stream NOPKCCFBOEB, long ANAJKMBCHFB, long DJKGICGFGOE, OCNLFCGGDIP KHEKPGMMFPH);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool AADBPFNPFFJ(Stream DMNGDKNOKDM, long ANAJKMBCHFB, long DJKGICGFGOE, EFPAELFAAKF PHIPGOOHPCG, out OCNLFCGGDIP KHEKPGMMFPH);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x280E3F0", Offset = "0x280CDF0", VA = "0x18280E3F0", Slot = "7")]
	public BMIHFLGADPJ MEIDKAJKFBG(long ANAJKMBCHFB, long DJKGICGFGOE, OCNLFCGGDIP KHEKPGMMFPH, EJAEMPHNCCB ADIFNIMFLJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo FNGLPIOBCFJ(long ANAJKMBCHFB, long DJKGICGFGOE, EJAEMPHNCCB ADIFNIMFLJN, POBPPJKPDDN ANJHHFKDIIB);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo ONPDIAPAAEO(EJAEMPHNCCB ADIFNIMFLJN, POBPPJKPDDN ANJHHFKDIIB);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x280E0D0", Offset = "0x280CAD0", VA = "0x18280E0D0")]
	protected void DCGKELBDMNI(GOJJMPLDEFA.IAIFOMJLLOD GBNPJLECHMI, string DBIMPNPPPLB, FileInfo DJCECPCGODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x280E140", Offset = "0x280CB40", VA = "0x18280E140")]
	internal bool JFIKHHNLBBM(FileInfo FBOOAMHIADJ, long ANAJKMBCHFB, long DJKGICGFGOE, out OCNLFCGGDIP KHEKPGMMFPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	private void LIHGDHIILBE(Exception IGKMPALPDNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal class GOHJNELDFCN : DHPOJECJBMM
{
	[Cpp2IlInjected.Token(Token = "0x4000690")]
	private const string NGHEJAFGHCK = "V2";

	[Cpp2IlInjected.Token(Token = "0x4000691")]
	private const string IJDFEDIPBAF = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x4000692")]
	private const string DEBMHPCIOJL = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public override IJFCFHFOBPN FHLGOHKIKEN
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x1342CF0", Offset = "0x13416F0", VA = "0x181342CF0", Slot = "8")]
		get
		{
			return default(IJFCFHFOBPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x281E0D0", Offset = "0x281CAD0", VA = "0x18281E0D0")]
	public GOHJNELDFCN([Optional] string GIECGMAANPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x281DBE0", Offset = "0x281C5E0", VA = "0x18281DBE0")]
	private void CJOHFDDHOIB(EJAEMPHNCCB ADIFNIMFLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x281DD50", Offset = "0x281C750", VA = "0x18281DD50", Slot = "9")]
	internal override void IJMLADJCKJD(Stream NOPKCCFBOEB, long ANAJKMBCHFB, long DJKGICGFGOE, OCNLFCGGDIP KHEKPGMMFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x281D5F0", Offset = "0x281BFF0", VA = "0x18281D5F0", Slot = "10")]
	internal override bool AADBPFNPFFJ(Stream DMNGDKNOKDM, long ANAJKMBCHFB, long DJKGICGFGOE, EFPAELFAAKF PHIPGOOHPCG, out OCNLFCGGDIP KHEKPGMMFPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x281DC60", Offset = "0x281C660", VA = "0x18281DC60", Slot = "11")]
	protected override FileInfo FNGLPIOBCFJ(long ANAJKMBCHFB, long DJKGICGFGOE, EJAEMPHNCCB ADIFNIMFLJN, POBPPJKPDDN ANJHHFKDIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x281DFC0", Offset = "0x281C9C0", VA = "0x18281DFC0", Slot = "12")]
	protected override DirectoryInfo ONPDIAPAAEO(EJAEMPHNCCB ADIFNIMFLJN, POBPPJKPDDN ANJHHFKDIIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
internal sealed class DKDIOAOMLHA : DHPOJECJBMM
{
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private static readonly byte[] AJPNMLHDHNM;

	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private const string IJDFEDIPBAF = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x4000695")]
	private const string DEBMHPCIOJL = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private const string OPOEDJGCHDJ = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private readonly byte[] KMNBGPGOFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private readonly byte[] KONJMJEPJGB;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public override IJFCFHFOBPN FHLGOHKIKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x77B020", Offset = "0x779A20", VA = "0x18077B020", Slot = "8")]
		get
		{
			return default(IJFCFHFOBPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x280F860", Offset = "0x280E260", VA = "0x18280F860")]
	public DKDIOAOMLHA([Optional] string GIECGMAANPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x280F410", Offset = "0x280DE10", VA = "0x18280F410", Slot = "9")]
	internal override void IJMLADJCKJD(Stream NOPKCCFBOEB, long ANAJKMBCHFB, long DJKGICGFGOE, OCNLFCGGDIP KHEKPGMMFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x280E9B0", Offset = "0x280D3B0", VA = "0x18280E9B0", Slot = "10")]
	internal override bool AADBPFNPFFJ(Stream DMNGDKNOKDM, long ANAJKMBCHFB, long DJKGICGFGOE, EFPAELFAAKF PHIPGOOHPCG, out OCNLFCGGDIP KHEKPGMMFPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x280F300", Offset = "0x280DD00", VA = "0x18280F300")]
	private void HOJKJPLNHBM(byte[] FMIGDHLBIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x280F1D0", Offset = "0x280DBD0", VA = "0x18280F1D0", Slot = "11")]
	protected override FileInfo FNGLPIOBCFJ(long ANAJKMBCHFB, long DJKGICGFGOE, EJAEMPHNCCB ADIFNIMFLJN, POBPPJKPDDN ANJHHFKDIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x280F6C0", Offset = "0x280E0C0", VA = "0x18280F6C0", Slot = "12")]
	protected override DirectoryInfo ONPDIAPAAEO(EJAEMPHNCCB ADIFNIMFLJN, POBPPJKPDDN ANJHHFKDIIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
public enum IJFCFHFOBPN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
internal class BBBKPIDDCJF : LGDCAGPKCBB
{
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class CHJAJODJHCH : IEnumerable<BMIHFLGADPJ>, IEnumerable, IEnumerator<BMIHFLGADPJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private BMIHFLGADPJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public BBBKPIDDCJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private EJAEMPHNCCB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public EJAEMPHNCCB <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private IJFCFHFOBPN[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private IEnumerator<BMIHFLGADPJ> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		private BMIHFLGADPJ System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
		[DebuggerHidden]
		public CHJAJODJHCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x2E34B00", Offset = "0x2E33500", VA = "0x182E34B00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x2E34730", Offset = "0x2E33130", VA = "0x182E34730", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x2E34B90", Offset = "0x2E33590", VA = "0x182E34B90")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x2E34AC0", Offset = "0x2E334C0", VA = "0x182E34AC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x2E34A10", Offset = "0x2E33410", VA = "0x182E34A10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BMIHFLGADPJ> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x2E34A10", Offset = "0x2E33410", VA = "0x182E34A10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private readonly IJFCFHFOBPN[] FGOPHNLBDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private readonly Dictionary<IJFCFHFOBPN, LGDCAGPKCBB> GLHIMKEJDBB;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public IJFCFHFOBPN FHLGOHKIKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x2808B00", Offset = "0x2807500", VA = "0x182808B00", Slot = "4")]
		get
		{
			return default(IJFCFHFOBPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x2808FC0", Offset = "0x28079C0", VA = "0x182808FC0")]
	[UnityEngine.Scripting.Preserve]
	public BBBKPIDDCJF(params LGDCAGPKCBB[] DOIMAGLMGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x2808C30", Offset = "0x2807630", VA = "0x182808C30", Slot = "5")]
	public bool NOCFDHAGAHD(long ANAJKMBCHFB, long DJKGICGFGOE, EJAEMPHNCCB ADIFNIMFLJN, out BMIHFLGADPJ CJMCLFOEGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x2808D90", Offset = "0x2807790", VA = "0x182808D90")]
	private void PPNPIMHPIAE(int JACLFABHMEN, long ANAJKMBCHFB, long DJKGICGFGOE, EJAEMPHNCCB ADIFNIMFLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x2808A80", Offset = "0x2807480", VA = "0x182808A80", Slot = "6")]
	[IteratorStateMachine(typeof(CHJAJODJHCH))]
	public IEnumerable<BMIHFLGADPJ> ABHOICFPPON(EJAEMPHNCCB ADIFNIMFLJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x2808B40", Offset = "0x2807540", VA = "0x182808B40", Slot = "7")]
	public BMIHFLGADPJ MEIDKAJKFBG(long ANAJKMBCHFB, long DJKGICGFGOE, OCNLFCGGDIP KHEKPGMMFPH, EJAEMPHNCCB ADIFNIMFLJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
internal static class JIFJHOHMKKP
{
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	internal const int LGDKPGHENLK = 32;

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x2825070", Offset = "0x2823A70", VA = "0x182825070")]
	internal static byte[] LDLDCBPEKMI(byte[] FMIGDHLBIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x2825110", Offset = "0x2823B10", VA = "0x182825110")]
	public static void MANMOABIPAM(Stream BODAGHDNFBD, byte[] OCJDCFDOHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x2824E90", Offset = "0x2823890", VA = "0x182824E90")]
	public static bool HHFGFIPDLPH(Stream BODAGHDNFBD, long DADDDMGHCNK, EFPAELFAAKF EAPMPFGACHK, out byte[] BMGOIIJEEEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
internal sealed class CLLDOELLJPN : BMIHFLGADPJ, IEquatable<BMIHFLGADPJ>, IEquatable<CLLDOELLJPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AD")]
	private readonly DHPOJECJBMM KAGFCDKMOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006AE")]
	public readonly FileInfo JAOIEKIKHHF;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public IJFCFHFOBPN FHLGOHKIKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xAA4780", Offset = "0xAA3180", VA = "0x180AA4780", Slot = "4")]
		get
		{
			return default(IJFCFHFOBPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public DateTime CJMHOMMDOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x280DB60", Offset = "0x280C560", VA = "0x18280DB60", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x280DD90", Offset = "0x280C790", VA = "0x18280DD90")]
	public CLLDOELLJPN(DHPOJECJBMM MELMCFEDDEM, FileInfo FBOOAMHIADJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x280DCE0", Offset = "0x280C6E0", VA = "0x18280DCE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x280D810", Offset = "0x280C210", VA = "0x18280D810", Slot = "6")]
	public void EJALFGMIKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x280DCA0", Offset = "0x280C6A0", VA = "0x18280DCA0", Slot = "7")]
	public bool HNIMIOJCGEJ(long ANAJKMBCHFB, long DJKGICGFGOE, out OCNLFCGGDIP KHEKPGMMFPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x280D8D0", Offset = "0x280C2D0", VA = "0x18280D8D0", Slot = "8")]
	public bool Equals(BMIHFLGADPJ DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x280D9B0", Offset = "0x280C3B0", VA = "0x18280D9B0", Slot = "9")]
	public bool Equals(CLLDOELLJPN DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x280DA60", Offset = "0x280C460", VA = "0x18280DA60", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x280DC00", Offset = "0x280C600", VA = "0x18280DC00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x1710590", Offset = "0x170EF90", VA = "0x181710590")]
	public static bool NENBKMMGKMN(CLLDOELLJPN POBMLHBNLMA, CLLDOELLJPN NMLIFIHDIKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x1710500", Offset = "0x170EF00", VA = "0x181710500")]
	public static bool HCCIHOFGPHE(CLLDOELLJPN POBMLHBNLMA, CLLDOELLJPN NMLIFIHDIKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
public delegate void EFPAELFAAKF(GOJJMPLDEFA.IAIFOMJLLOD LNJHKOONIDN, string EJEIJOMMNGK);
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal interface LGDCAGPKCBB
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	IJFCFHFOBPN FHLGOHKIKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NOCFDHAGAHD(long ANAJKMBCHFB, long DJKGICGFGOE, EJAEMPHNCCB ADIFNIMFLJN, out BMIHFLGADPJ CJMCLFOEGKH);

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<BMIHFLGADPJ> ABHOICFPPON(EJAEMPHNCCB ADIFNIMFLJN);

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BMIHFLGADPJ MEIDKAJKFBG(long ANAJKMBCHFB, long DJKGICGFGOE, OCNLFCGGDIP KHEKPGMMFPH, EJAEMPHNCCB ADIFNIMFLJN);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000197")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x40006B0")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x40006B1")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x2825E60", Offset = "0x2824860", VA = "0x182825E60")]
	private static string PBGMOKJNJDM(byte[] DLAMIJMLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x2825B10", Offset = "0x2824510", VA = "0x182825B10")]
	public static string NPAMJBENNGG(byte[] FMIGDHLBIKP, bool BLHGHBBBDBI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
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
