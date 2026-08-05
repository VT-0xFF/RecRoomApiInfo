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
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
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
		[Cpp2IlInjected.Address(RVA = "0x63EA480", Offset = "0x63E8C80", VA = "0x1863EA480")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79CCC0", Offset = "0x79B4C0", VA = "0x18079CCC0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x79CD00", Offset = "0x79B500", VA = "0x18079CD00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GNIOFLAIJEH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x63E0590", Offset = "0x63DED90", VA = "0x1863E0590")]
	public GNIOFLAIJEH(string OLDFIJBKFKG, Exception BBKFELJJBDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class LHDFPDDODKJ : EINFAIMECBB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct PIJBDLOJKGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<FEAFPIIILAH>> <>t__builder;

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
		private TaskAwaiter<PHNGINNFMMB<FEAFPIIILAH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x63F0240", Offset = "0x63EEA40", VA = "0x1863F0240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x63F0480", Offset = "0x63EEC80", VA = "0x1863F0480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct BHGNHMHOMIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<LPFNMEDDCCA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<LPFNMEDDCCA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x63D5DF0", Offset = "0x63D45F0", VA = "0x1863D5DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x63D6000", Offset = "0x63D4800", VA = "0x1863D6000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	[UnityEngine.Scripting.Preserve]
	public LHDFPDDODKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x63E5F40", Offset = "0x63E4740", VA = "0x1863E5F40", Slot = "4")]
	[AsyncStateMachine(typeof(PIJBDLOJKGF))]
	public Task<IReadOnlyList<FEAFPIIILAH>> EGENOEEDKPA(long AKDANPAICOC, long NOJFBKAHMKA, [Optional] CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x63E5E30", Offset = "0x63E4630", VA = "0x1863E5E30", Slot = "5")]
	[AsyncStateMachine(typeof(BHGNHMHOMIG))]
	public Task<IReadOnlyList<LPFNMEDDCCA>> DPKNKHIOCDC(IReadOnlyList<int> EMFNIPDDBIE, [Optional] CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FFLBEGPJBLK : IEquatable<FFLBEGPJBLK>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int MIMKKGCLDAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	LPFNMEDDCCA AGMBHFNLMMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime PLADJJNDCNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	BCHOCHKPLCC? ANKEHKPFKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OJFDCIOBANB? HMDAOHCFEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	EMDEAAHDDJE LCLDDHIKOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<HACEOFOLLHI> EHPOJFNIFGL();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum EMDEAAHDDJE
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EINFAIMECBB
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<FEAFPIIILAH>> EGENOEEDKPA(long AKDANPAICOC, long NOJFBKAHMKA, [Optional] CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<LPFNMEDDCCA>> DPKNKHIOCDC(IReadOnlyList<int> EMFNIPDDBIE, [Optional] CancellationToken GANAOLJLMGA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NODKELNAFAE
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class BAEGENKFPIJ : FFLBEGPJBLK, IEquatable<FFLBEGPJBLK>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct OJGBHHLLKAI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<HACEOFOLLHI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public BAEGENKFPIJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private JHAGMPIKOBD <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<IKGFEJPGNIE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<HACEOFOLLHI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x63EFB40", Offset = "0x63EE340", VA = "0x1863EFB40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x63EFFE0", Offset = "0x63EE7E0", VA = "0x1863EFFE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly FEAFPIIILAH HOHPGFGIMJC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int MIMKKGCLDAD
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x773AF0", Offset = "0x7722F0", VA = "0x180773AF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LPFNMEDDCCA AGMBHFNLMMG
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime AKHFOPLDKNE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x97CF40", Offset = "0x97B740", VA = "0x18097CF40", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BCHOCHKPLCC? ANKEHKPFKOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x188C4B0", Offset = "0x188ACB0", VA = "0x18188C4B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public OJFDCIOBANB? HMDAOHCFEHC
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1E09B70", Offset = "0x1E08370", VA = "0x181E09B70", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EMDEAAHDDJE LCLDDHIKOCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x869250", Offset = "0x867A50", VA = "0x180869250", Slot = "10")]
			get
			{
				return default(EMDEAAHDDJE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x63D5AA0", Offset = "0x63D42A0", VA = "0x1863D5AA0", Slot = "9")]
		[AsyncStateMachine(typeof(OJGBHHLLKAI))]
		public Task<HACEOFOLLHI> EHPOJFNIFGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x63D5D90", Offset = "0x63D4590", VA = "0x1863D5D90")]
		public BAEGENKFPIJ(int LIKOIMFIEHO, LPFNMEDDCCA PKOCCGNKMMH, FEAFPIIILAH HOHPGFGIMJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x63D5BA0", Offset = "0x63D43A0", VA = "0x1863D5BA0", Slot = "11")]
		public bool Equals(FFLBEGPJBLK FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x63D5C30", Offset = "0x63D4430", VA = "0x1863D5C30", Slot = "0")]
		public override bool Equals(object BEKFGDCEJDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x63D5CD0", Offset = "0x63D44D0", VA = "0x1863D5CD0")]
		private bool FDBLBDEOEKF(BAEGENKFPIJ FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x63D5D10", Offset = "0x63D4510", VA = "0x1863D5D10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class DMFBAAANEEJ : FFLBEGPJBLK, IEquatable<FFLBEGPJBLK>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct BNDGELGFLCJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<HACEOFOLLHI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public DMFBAAANEEJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<HACEOFOLLHI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x63D6240", Offset = "0x63D4A40", VA = "0x1863D6240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x63D6470", Offset = "0x63D4C70", VA = "0x1863D6470", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly GMPFCCLMDAG JLHFOIHMJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly BCHOCHKPLCC IOAGJHDBIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly OJFDCIOBANB JKGBJFBHCHP;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int MIMKKGCLDAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x63D8090", Offset = "0x63D6890", VA = "0x1863D8090", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LPFNMEDDCCA AGMBHFNLMMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x63D8370", Offset = "0x63D6B70", VA = "0x1863D8370", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime AKHFOPLDKNE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x63D8480", Offset = "0x63D6C80", VA = "0x1863D8480", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BCHOCHKPLCC? ANKEHKPFKOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x63D7FF0", Offset = "0x63D67F0", VA = "0x1863D7FF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public OJFDCIOBANB? HMDAOHCFEHC
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x63D8040", Offset = "0x63D6840", VA = "0x1863D8040", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public EMDEAAHDDJE LCLDDHIKOCG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x857730", Offset = "0x855F30", VA = "0x180857730", Slot = "10")]
			get
			{
				return default(EMDEAAHDDJE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xE0C670", Offset = "0xE0AE70", VA = "0x180E0C670")]
		public DMFBAAANEEJ(GMPFCCLMDAG JLDOKOHKLMM, BCHOCHKPLCC JKNLBFIENIF, OJFDCIOBANB BLBPIOCBNPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x63D80D0", Offset = "0x63D68D0", VA = "0x1863D80D0", Slot = "9")]
		[AsyncStateMachine(typeof(BNDGELGFLCJ))]
		public Task<HACEOFOLLHI> EHPOJFNIFGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x63D81C0", Offset = "0x63D69C0", VA = "0x1863D81C0", Slot = "11")]
		public bool Equals(FFLBEGPJBLK FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x63D8260", Offset = "0x63D6A60", VA = "0x1863D8260", Slot = "0")]
		public override bool Equals(object BEKFGDCEJDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x63D8310", Offset = "0x63D6B10", VA = "0x1863D8310")]
		private bool FDBLBDEOEKF(DMFBAAANEEJ FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x63D8400", Offset = "0x63D6C00", VA = "0x1863D8400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class JHPPOEHEPKH : FFLBEGPJBLK, IEquatable<FFLBEGPJBLK>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct KPEHDGEODKC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<HACEOFOLLHI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<HACEOFOLLHI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x63E5640", Offset = "0x63E3E40", VA = "0x1863E5640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x63E5880", Offset = "0x63E4080", VA = "0x1863E5880", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly LPFNMEDDCCA HANEDECPKEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly BCHOCHKPLCC IOAGJHDBIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly OJFDCIOBANB JKGBJFBHCHP;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int MIMKKGCLDAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x63E3D10", Offset = "0x63E2510", VA = "0x1863E3D10", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public LPFNMEDDCCA AGMBHFNLMMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime AKHFOPLDKNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x772210", Offset = "0x770A10", VA = "0x180772210", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public BCHOCHKPLCC? ANKEHKPFKOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x63E3C70", Offset = "0x63E2470", VA = "0x1863E3C70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public OJFDCIOBANB? HMDAOHCFEHC
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x63E3CC0", Offset = "0x63E24C0", VA = "0x1863E3CC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public EMDEAAHDDJE LCLDDHIKOCG
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x772210", Offset = "0x770A10", VA = "0x180772210", Slot = "10")]
			get
			{
				return default(EMDEAAHDDJE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xE0C670", Offset = "0xE0AE70", VA = "0x180E0C670")]
		public JHPPOEHEPKH(LPFNMEDDCCA PKOCCGNKMMH, BCHOCHKPLCC JKNLBFIENIF, OJFDCIOBANB BLBPIOCBNPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x63E3D30", Offset = "0x63E2530", VA = "0x1863E3D30", Slot = "9")]
		[AsyncStateMachine(typeof(KPEHDGEODKC))]
		public Task<HACEOFOLLHI> EHPOJFNIFGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x63E3E00", Offset = "0x63E2600", VA = "0x1863E3E00", Slot = "11")]
		public bool Equals(FFLBEGPJBLK FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x63E3F10", Offset = "0x63E2710", VA = "0x1863E3F10", Slot = "0")]
		public override bool Equals(object BEKFGDCEJDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x63E4110", Offset = "0x63E2910", VA = "0x1863E4110", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x63E4030", Offset = "0x63E2830", VA = "0x1863E4030")]
		private bool FDBLBDEOEKF(JHPPOEHEPKH FPJCFKAMJHL)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct IAIPBGDALGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<FFLBEGPJBLK>> <>t__builder;

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
		public NODKELNAFAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<FEAFPIIILAH> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<FEAFPIIILAH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, LPFNMEDDCCA account, FEAFPIIILAH roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x63E0B20", Offset = "0x63DF320", VA = "0x1863E0B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x63E1900", Offset = "0x63E0100", VA = "0x1863E1900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct LHIABHBGNLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, LPFNMEDDCCA account, FEAFPIIILAH roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<FEAFPIIILAH> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NODKELNAFAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<LPFNMEDDCCA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x63E6060", Offset = "0x63E4860", VA = "0x1863E6060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x63E6A50", Offset = "0x63E5250", VA = "0x1863E6A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CKINHEAEGIP MCBFMBOIBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly EINFAIMECBB LGDPCHJJIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly GMGDMAEDGAB CCHADMLAOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly LGKMPKEEEKH<(long, long), IReadOnlyList<FEAFPIIILAH>> CLBJJABEPKF;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x63EA350", Offset = "0x63E8B50", VA = "0x1863EA350")]
	[UnityEngine.Scripting.Preserve]
	public NODKELNAFAE([NBBCAEDCKMG(null)] EINFAIMECBB DIJEHGEHKCN, [NBBCAEDCKMG(null)] GMGDMAEDGAB BHIMLJPFLHI, [NBBCAEDCKMG(null)] CKINHEAEGIP EMEFBIGPGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x63EA0F0", Offset = "0x63E88F0", VA = "0x1863EA0F0")]
	[AsyncStateMachine(typeof(IAIPBGDALGG))]
	public Task<IList<FFLBEGPJBLK>> AKAPCKIJAGP(long AKDANPAICOC, long DILOHLKKNAL, bool KEHBHEAEPIH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63E9F50", Offset = "0x63E8750", VA = "0x1863E9F50")]
	private bool AEBCHMAGIGH(DateTime? GFAPHCPDFBH, long AKDANPAICOC, long DILOHLKKNAL, [Out] GMPFCCLMDAG FKGBPLGHMDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x63EA240", Offset = "0x63E8A40", VA = "0x1863EA240")]
	[AsyncStateMachine(typeof(LHIABHBGNLH))]
	private Task<IReadOnlyList<(int, LPFNMEDDCCA, FEAFPIIILAH)>> JKEIMPBFJKE(IReadOnlyList<FEAFPIIILAH> IBAKFNADKGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GMGDMAEDGAB
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GMPFCCLMDAG> OKNKOKOHDMA;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OMBEDKFLHMI(long AKDANPAICOC, long DILOHLKKNAL, EFLNKJCLGNC LAEGELMPHIN, KJDIKEMCNIP NFNANJHMKCJ);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FINCDGFKKGO(long AKDANPAICOC, long DILOHLKKNAL, [Out] GMPFCCLMDAG FKGBPLGHMDA);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KCBPIHLDPPK(long AKDANPAICOC, long DILOHLKKNAL, KJDIKEMCNIP NFNANJHMKCJ, [Out] GMPFCCLMDAG FKGBPLGHMDA);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JMBHPCMMJAA(long AKDANPAICOC, long DILOHLKKNAL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface JGKDFFLBMIA : IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool OFIGFJMPKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task MEJMJECHLDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OCFBFAINICH(Task KONAOGGENMJ, string JFLDCBLMJBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface FDAEBAMNBME : IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HACEOFOLLHI> EDNDINJHAHI(GMPFCCLMDAG FKGBPLGHMDA);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NCKIGBLFJPO(CancellationToken GANAOLJLMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface EHFEEEKODIH : IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	IJFKBIOGJOO LFMALPIIKOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJPDKKOMFEL();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMOOGMICMCE();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface IPOCNADENOB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface GKHIKPLJOCM
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan DEJMMKGPMJA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan IMMOAFONNLP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan LMGKBIMEEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan NLFFOKOFJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool EJAGLMEBIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool BAEIKFLFNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool AIMAGBMBENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int OCEPPFKANNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool JIJCMDBNJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool LJEGCBGDBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum NLOLJPHDDNL
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum DKPFOLLMHMN
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
public struct IKHDPBEDCBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long INBENEPJAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long NOJFBKAHMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly NLOLJPHDDNL HJNJPNKDEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception IDGGBHIOKBD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x63E2230", Offset = "0x63E0A30", VA = "0x1863E2230")]
	public IKHDPBEDCBP(long INBENEPJAAJ, long NOJFBKAHMKA, NLOLJPHDDNL HJNJPNKDEFH, [CanBeNull] Exception IDGGBHIOKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x63E21E0", Offset = "0x63E09E0", VA = "0x1863E21E0")]
	public static IKHDPBEDCBP MJJLONPCGJI(MPLKHMAMHAD NINGHGBJMMI, NLOLJPHDDNL HJNJPNKDEFH, [Optional] Exception IDGGBHIOKBD)
	{
		return default(IKHDPBEDCBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate void BCIMBFIJGNN(IKHDPBEDCBP MPAGHDFMNKE);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface LOAOKGHANBJ : IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HENCOOCCDPP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event BCIMBFIJGNN LFGPFANCFKM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event BCIMBFIJGNN MJAMMBMGBKI;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event BCIMBFIJGNN FAEMNBGCEFD;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<DKPFOLLMHMN, bool> DFOHCCEMJIK;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OINJPKCDJGF();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LHCNIDACLKE(IKHDPBEDCBP MPAGHDFMNKE);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HCLMAOKBBKG(IKHDPBEDCBP MPAGHDFMNKE);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DLCBHOEMKBL(IKHDPBEDCBP MPAGHDFMNKE);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ELLFBKFNLDB(DKPFOLLMHMN CGNHLHIMGDH, bool DGADJKHCOBI);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface CEJNHAIMKDD : IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JBDMEHKNOCF();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLOACLMEDKK();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface FMDDGLKNNGC : IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus KOKOHCFNFJE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NGALEGOLMDN(MPLKHMAMHAD EFGEAIMNMOK, IPAGPBHPJOP IGCPFPEAMHJ, CancellationToken LCNDAGMDGPL);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal static class PKGFGBBDNCA
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x63F04F0", Offset = "0x63EECF0", VA = "0x1863F04F0")]
	public static bool BJCMJDFADFI(this FMDDGLKNNGC PNPLNECKMPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public delegate Task COIKDGIFMGF(NKCNOMEENDM HCADKDIKPMA, CancellationToken JECMOKMEJED);
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface MDKLFKJDOIN : IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBPPKOFBHNJ(COIKDGIFMGF BGODJLAGPMO);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface NGLGDOHLABH : JHAGMPIKOBD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken ABOEIPENJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	PHIPPCBHDOE LOMJOEIIJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	FBOMPCMDFLJ CFKJLAKOPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	LGLBIEKGAIJ AANBFCHJFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	MFLPEJLBJBB PELEPLGFCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	LOMEIBMCEJC PODIJEFIIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	IJECHOENAHN AAOOCEHIPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	ENCKFKHFNFN NNGCOGBFJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HJJOGJKLCEL GDAILBLBDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	JGKDFFLBMIA GNCAEHPEIBB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	FDAEBAMNBME BKPPHLKDJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	LOAOKGHANBJ OFDFOBCHLIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	CEJNHAIMKDD JIHHLIKKAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	FMDDGLKNNGC BLECKPIDFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	MDKLFKJDOIN EHJBFJCLNCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ONBCPOOPKHA KBIIOFHIOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PHKMEHELHKE DBGNMLPGHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	GHFIBDMAJAD LLKDCAILBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	EOMDHBEAOKF LGLHDBOOHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	LAGBFNECIOK FILGDDMBICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	BJDBCHOFMKL MOENNCOHDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	KFILGLIIBBP GJNFNLNDEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	GGJAJFCIBLE NIDMOMIEBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	NBMNPPBCGEI ECPAJFDJGCF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	FHLPDKLILOI FAMKNDCIMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	EHFEEEKODIH KNAEFALIFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	GKHIKPLJOCM LOLLMOEFHBO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	ACDFEAPAJND CACAPAEAABC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	GMGDMAEDGAB ONFICLLDJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	MAFDAMMHAPC FHNPPAOAPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	MGDEIDEPHGI KABOEFCPDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void BNNNPCCIJDF(IPAGPBHPJOP IHNPIOCKLCA);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface ONBCPOOPKHA : IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMGAFAPCPKA INCGBOEKEGG(Guid HGCENGMCDHK);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FMCALLKJEMI(Guid HGCENGMCDHK);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MOHLGCNNIMC(Guid HGCENGMCDHK, Task GLIIHKJPDHD);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KOIJPDNPBDL(Guid HGCENGMCDHK, HACEOFOLLHI GOFJGMKELLM);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(HACEOFOLLHI, Task)> GPCLEBKBBHA(Guid HGCENGMCDHK);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface AGAFALABMDK : IPOCNADENOB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface PHKMEHELHKE : IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPKCIDHMBJD(CDCBGIGPIJK OLDFIJBKFKG);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LMGLOFGGLDE(CDCBGIGPIJK OLDFIJBKFKG);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<NDCFBNKNGBO> FACCDKEJGIH(CancellationToken PNKGCELIPMG);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface GHFIBDMAJAD : IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMGAFAPCPKA HDGLHLLGMPN(CDCBGIGPIJK JEJHPOCBFNB);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMAMBOIKKBL(Guid HGCENGMCDHK, Task GLIIHKJPDHD);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface EOMDHBEAOKF : IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HACEOFOLLHI> LGLHDBOOHJB(CDCBGIGPIJK DKLDLKBOBKK);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface LAGBFNECIOK : IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MDONEMLENMD> LFFKIHIDMIC(FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, MPLKHMAMHAD EFGEAIMNMOK, CancellationToken GANAOLJLMGA);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface KFILGLIIBBP : IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HACEOFOLLHI NLOKOGJFJOA(PDJKNJCPPID HMGDBFENEOK);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KLCECHACIEO(string LIAIPLNEAGD);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface BJDBCHOFMKL : IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CDCBGIGPIJK> FJEPOJIKDDE(CDCBGIGPIJK KOFJNFGLAFK, ENLDEMGODIF DJAFFFBJGEM, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CDCBGIGPIJK> IJOBMBPKDJN(CancellationToken GANAOLJLMGA, ENLDEMGODIF DJAFFFBJGEM);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LEGAMHNOHAM PECODMFMMAH(MPFKLGFLPPO ODAHPMOLINL, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LEGAMHNOHAM NACKNBBBPIJ(MPFKLGFLPPO ODAHPMOLINL, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface GGJAJFCIBLE : IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HACEOFOLLHI GEGGOHOPOKJ(PDJKNJCPPID HMGDBFENEOK, NDCFBNKNGBO JHGFLHMNDIE);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HACEOFOLLHI DLMJKNEADPB(PDJKNJCPPID PKIGHFCGLKN);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface NBMNPPBCGEI
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBNMJPGFLHA(EDAANACKNFJ JJOJAEGEEAO);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFMJCACEKJJ(EDAANACKNFJ JJOJAEGEEAO);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DHDLMBEHFEM(EDAANACKNFJ JJOJAEGEEAO);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GFHCNHNNPIH(EDAANACKNFJ JJOJAEGEEAO);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class EDAANACKNFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly MPLKHMAMHAD HLFMGIIDCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> EOOLPBBCFNF;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public FHBHLKGBKLK<string> LDKMGGHLDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x773B60", Offset = "0x772360", VA = "0x180773B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
	public EDAANACKNFJ(MPLKHMAMHAD FAMNCMCAAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x63D8560", Offset = "0x63D6D60", VA = "0x1863D8560")]
	public EDAANACKNFJ LIPPBHAFEGP(string EMBEECDJLJB, string DOLICEBFIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x63D84D0", Offset = "0x63D6CD0", VA = "0x1863D84D0")]
	public bool HMLPHPKHLPP([Out] IEnumerable<KeyValuePair<string, string>> DAJJEFKELCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x57CCC20", Offset = "0x57CB420", VA = "0x1857CCC20")]
	public EDAANACKNFJ GOCCJKFABPC(FHBHLKGBKLK<string> PFAPIIDDMDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface ACDFEAPAJND
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool PBEIDIJKCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string HFDHHKGPILD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LGNIAAFIJMC();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FNJDAFJDGMO KEJMFCMKNDC(long GPPJMLIGEEN);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FBNCEFDBDGE<LJEPICPLNFE, LFFIBBNOHMB> CAKIIJGEDCD(long GPPJMLIGEEN);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FBNCEFDBDGE<LJEPICPLNFE, IJMHNDANHLN> ENKHOILMLNI(long GPPJMLIGEEN);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FBNCEFDBDGE<long, AIEANEPJBIM> HLIBGCNPOIG();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JANOGOIIJCG([Out] bool OGDJLDPDLHK);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<bool> CBKCDLGGAGK(byte[] GDEABNLEJPG, byte[] EAFNDEMPLNF, CancellationToken GANAOLJLMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface JHAGMPIKOBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool BJCMJDFADFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool APGGEELEILC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IPAGPBHPJOP BKCFBEBBEGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action HENCOOCCDPP;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event BCIMBFIJGNN LFGPFANCFKM;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event BCIMBFIJGNN MJAMMBMGBKI;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event BCIMBFIJGNN FAEMNBGCEFD;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<DKPFOLLMHMN, bool> DFOHCCEMJIK;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PLOACLMEDKK();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DOPJAAIDEEK LFDGPBAPIBL();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KEJGCHFLKAC ONAPEKFBAEK();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<HACEOFOLLHI> EDNDINJHAHI(GMPFCCLMDAG JLDOKOHKLMM);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task NCKIGBLFJPO(CancellationToken GANAOLJLMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface LOMEIBMCEJC
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool HPLKBJCDMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	string CKOKPJPJOMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFLFLGGINNH(Scene GJPOBIPECDE);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HOPAHMKDNAF(MCCNMKMHCPC GBEAANDLJGM, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task AIHACBLPFHJ();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface MFLPEJLBJBB
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	DJPPJKIGHMC DMKFBEHIHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool GAEPAJFIDFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool ANGEFJKINJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool PBEFBCEGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool BFLMNNKCGDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool OPGIDMDGEMC
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool BJHNDCBAODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool EPAMGOLIHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float CAHPJLLMJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> FHOCACAGKMH;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PHIPPCBHDOE NBFKGNLPPEA(PHIPPCBHDOE JPFLHFFBHBM);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODAJKGHHICG(PHIPPCBHDOE EFKPBKMFDOG);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void COEIPFFHIFK();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task HBOGMPDAEMO(FHBHLKGBKLK<string>.CAOEJONIOII EGDJFGFNAHO, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DLEHNHFOBEM(float BEHNLCDHMOA);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MKNEOLBNBCA(string FIKFKHLEGOG);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<PDJBLODEPPI> DCKDENNLFAF();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable GDBOKKBEPNA(object LFDLOIPEDMO, PDJBLODEPPI NGHAPAIADFF);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LFFIBBNOHMB MLNPJGEKBAH(IEnumerable<CPNGAJPMGHC> OAJCFDMDJAD);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MEFLCPHHMJD(int CNEDHPANOLF);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task GNEGGMLBJMF();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HKMEILMBLKL();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool OGJPKFEDFNG();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task BGPMNKBCPLM(CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task BBOBNFDJEFJ(CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<CDLCKNOBODL> HNJFIEFEKID(DateTime OHGKKKGBIJH, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> PKCFFCMKDBM(CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IHFJJLOBAEO(string FOHAKOHDJKM = "", float IMMFEJCLFDE = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	BCCKIGFJGJE CMOBFFOGLPG(EMLBGBMHHHE HPOAOCANGIC, DCEHBKPGOLL BACBPNHMEDD, IJMHNDANHLN CICJBBCACPF, IEnumerable<PersistenceView> DFPBMEHHDBJ, EKKBAPOPLPH ECHFOGDAGEI);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GGJEMNILCMH(IJMHNDANHLN CICJBBCACPF);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void GHOCJMDEPOL(CPNGAJPMGHC ODHHDFDFIMM, [In] BCCKIGFJGJE FBJABCNIDOB);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task COLNBHFIPLG(IJMHNDANHLN PLLIEGAKAKM, bool GEMNKFEKNOE, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task GMAPLPFGACP(CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EGLFCJAGLMJ(long AKDANPAICOC, long NOJFBKAHMKA, IKGFEJPGNIE JLEOAIBABON, FEAFPIIILAH GCMCANBNCCA, EFLNKJCLGNC LAEGELMPHIN, JNNCDNMFPJN? BPFJIMPDFLM, GMPDBAAEMGG? BIIHPNICJPK);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void JCBEMKPEKAF(long AKDANPAICOC, long NOJFBKAHMKA, GMPDBAAEMGG? BIIHPNICJPK);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void AJNLLKLKCDL(PersistenceView PLGKGCDNLIK);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool DGNBIHFANJM(PersistenceView JFILAMEFOEI);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool MCIMGFKGCBD(CPNGAJPMGHC ODHHDFDFIMM, NEHBJOKJCJG EDMPIIAFFHL, [Out] CKEABANGALJ DHFBPHDHDOH);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task FIBPHJMKNCL(CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void MNLBDGIKGCD();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable KNGLEBGBAPM();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void EPOADEEPICP(IJMHNDANHLN PLLIEGAKAKM, NEHBJOKJCJG EDMPIIAFFHL);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> EEDDPECPOPF(FBOMPCMDFLJ GJLGCABGOLK, CancellationToken GANAOLJLMGA, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void IMHHELCHHFE(CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<DBLJMINNAMP> KNBCKFMALHM(HBKCLIMNDMA KOFJNFGLAFK);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<IKGFEJPGNIE> OMMCBBALLND(long AKDANPAICOC, bool AJACGNCLAJG, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<FEAFPIIILAH> LOGIPAGHDDP(long AKDANPAICOC, long NOJFBKAHMKA, long MGLCKKIMBHK, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<KHNCGBFPFIA> CALIFINOAAH(string JDODMIBKHHJ, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<KHNCGBFPFIA> OIDPECMEHEI(string JDODMIBKHHJ, long AKDANPAICOC, long NOJFBKAHMKA, string LNCOOBMHJOG, PLEPKDPNJHM.CLLLLHGPAMH HCADKDIKPMA, PLEPKDPNJHM.CLLLLHGPAMH EAFNDEMPLNF, int BJMHHJDOGHA);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool LCEFHBGCLOP();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool LKCEJIIBCIL();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool NFPLNGJEMNB(IEnumerable<CKEABANGALJ> LLDPNHDJMGP);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void MJKOJPKIJDJ(List<GameObject> MOBFMNHFJFG);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float HMNMIOCNOAM();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task<Scene> NPMEMPADKAP(string FLNADIENFAK, LoadSceneMode FLHNHLCHLLL, bool HACNHMJCJDJ, FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void NCLMLMMOHGM();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void JFINLHFCLGM(bool KAJOKJADDID);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void PDDBAMOEFKO(MPLKHMAMHAD GHBONMCFMLM);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task OOOELIMEMEL(FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task CCOJEPPPEGF(FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task PIIKDANGLDH(FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "62")]
	IDisposable LKDCAOIHGDN();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "63")]
	KHGFECHILNH IPLCMDOOCKP();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task OKBGNNHMCCI(CancellationToken GANAOLJLMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface KHGFECHILNH
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FBNEOPBHHPK(CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LDHJFJGJJJH(CancellationToken GANAOLJLMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct BCCKIGFJGJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> OIELLBNLBHA;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum CDLCKNOBODL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct EMLBGBMHHHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string ICEOJBHJCEG;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface DJPPJKIGHMC
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	MPLKHMAMHAD HKMBNOMAFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	IKGFEJPGNIE JONLPDEFLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	LKADGOEJKMM FLOEKCIIMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool AFEHGLCAGPB
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool LIDNGCFEKND
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	int IGIMDBNFPHO
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action PMELKJOMHNJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> CLKNJMGAOAO;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CBHMBOIIGEF();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.HOEJMGOGBLE> LPEPMFHOPGL(long GPPJMLIGEEN, [Optional] CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<JGINHPAKLAK> NDNBGOECJNG();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task GPBKJKLKLIL();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(MPLKHMAMHAD, IPAGPBHPJOP) FMLAHMJIEPM();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DPEHCBMLNGE KCKAEJLCGPP();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HOLABEOIKNL(long GPPJMLIGEEN);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface FHLPDKLILOI
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FOGMLEBGMKG([Out] IEnumerable<int> HMLBDPNCBPI);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGCEHKECPHL(CCHLDLOCDCI JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BBECEJNKHHJ(CCHLDLOCDCI JECMOKMEJED);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface KNADINCKGPE
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DDDIILLPAHA(HACEOFOLLHI EEFAEJINOOG);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface LICKPOLLCDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEGFLKNDLMM(DEBIIAGGONB.IJIGLCNMNAB DPLECAFONDG);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFOMDELNAPB(DEBIIAGGONB.IJIGLCNMNAB DPLECAFONDG);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface IJECHOENAHN : LICKPOLLCDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HACEOFOLLHI IMPGLJILPJB(PDJKNJCPPID PKIGHFCGLKN);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface ENCKFKHFNFN : LICKPOLLCDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HACEOFOLLHI NLOKOGJFJOA(PDJKNJCPPID MNBNFIINGLG);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface FNJDAFJDGMO
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LBFOJMHFNLD<MCCNMKMHCPC, CLJHHCKGBLK>> AMJNFPENNHG(string LNCOOBMHJOG, long GPPJMLIGEEN, NGNENMBJNCM.HLGHPDPFLFD DMKIJOEDLNH, CancellationToken GANAOLJLMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface FBNCEFDBDGE<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LBFOJMHFNLD<byte[], CLJHHCKGBLK>> PDNMKIBOFEH(TGetDataArg AKIAGKECAIA, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LBFOJMHFNLD<KINNJCBMFJP<TData>, CLJHHCKGBLK> BILAFCPJKFE(byte[] FCHBDAMJEHN);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class OGJEAHHFEII : NGLGDOHLABH, JHAGMPIKOBD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct ELPOIAJPGIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<HACEOFOLLHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public OGJEAHHFEII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GMPFCCLMDAG autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<HACEOFOLLHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x63D8630", Offset = "0x63D6E30", VA = "0x1863D8630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x63D88B0", Offset = "0x63D70B0", VA = "0x1863D88B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct EPDCGOHLKGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public OGJEAHHFEII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x63D9580", Offset = "0x63D7D80", VA = "0x1863D9580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x63D97B0", Offset = "0x63D7FB0", VA = "0x1863D97B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class HNNHOJNKKHN : IEnumerable<IPOCNADENOB>, IEnumerable, IEnumerator<IPOCNADENOB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private IPOCNADENOB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public OGJEAHHFEII <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		private IPOCNADENOB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8F6270", Offset = "0x8F4A70", VA = "0x1808F6270")]
		[DebuggerHidden]
		public HNNHOJNKKHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x63E0670", Offset = "0x63DEE70", VA = "0x1863E0670", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x63E0AD0", Offset = "0x63DF2D0", VA = "0x1863E0AD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x63E0A20", Offset = "0x63DF220", VA = "0x1863E0A20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IPOCNADENOB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x63E0A20", Offset = "0x63DF220", VA = "0x1863E0A20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource NIHGNGPPIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly PHIPPCBHDOE EFKPBKMFDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool HDNMPGDBKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private GIHDMGFFLEG EBOMCDLLKNF;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public FBOMPCMDFLJ CFKJLAKOPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7771E0", Offset = "0x7759E0", VA = "0x1807771E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x777250", Offset = "0x775A50", VA = "0x180777250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public LGLBIEKGAIJ AANBFCHJFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x772C80", Offset = "0x771480", VA = "0x180772C80", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x772CA0", Offset = "0x7714A0", VA = "0x180772CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public MFLPEJLBJBB PELEPLGFCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x772C70", Offset = "0x771470", VA = "0x180772C70", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x772C90", Offset = "0x771490", VA = "0x180772C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public LOMEIBMCEJC PODIJEFIIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x772CC0", Offset = "0x7714C0", VA = "0x180772CC0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x772CB0", Offset = "0x7714B0", VA = "0x180772CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public IJECHOENAHN AAOOCEHIPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x779ED0", Offset = "0x7786D0", VA = "0x180779ED0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x779EE0", Offset = "0x7786E0", VA = "0x180779EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public ENCKFKHFNFN NNGCOGBFJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x779F00", Offset = "0x778700", VA = "0x180779F00", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x779EF0", Offset = "0x7786F0", VA = "0x180779EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public HJJOGJKLCEL GDAILBLBDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x777190", Offset = "0x775990", VA = "0x180777190", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7771F0", Offset = "0x7759F0", VA = "0x1807771F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public JGKDFFLBMIA GNCAEHPEIBB
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x777290", Offset = "0x775A90", VA = "0x180777290", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7770E0", Offset = "0x7758E0", VA = "0x1807770E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public FDAEBAMNBME BKPPHLKDJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x777280", Offset = "0x775A80", VA = "0x180777280", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x777160", Offset = "0x775960", VA = "0x180777160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public LOAOKGHANBJ OFDFOBCHLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8AF760", Offset = "0x8ADF60", VA = "0x1808AF760", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8AF840", Offset = "0x8AE040", VA = "0x1808AF840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public CEJNHAIMKDD JIHHLIKKAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x777260", Offset = "0x775A60", VA = "0x180777260", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7770F0", Offset = "0x7758F0", VA = "0x1807770F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public FMDDGLKNNGC BLECKPIDFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x839580", Offset = "0x837D80", VA = "0x180839580", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x838E00", Offset = "0x837600", VA = "0x180838E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public MDKLFKJDOIN EHJBFJCLNCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x776220", Offset = "0x774A20", VA = "0x180776220", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x776200", Offset = "0x774A00", VA = "0x180776200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public ONBCPOOPKHA KBIIOFHIOBL
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x966B70", Offset = "0x965370", VA = "0x180966B70", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x966CE0", Offset = "0x9654E0", VA = "0x180966CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public AGAFALABMDK HOBGAMIAMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4180", Offset = "0x8C2980", VA = "0x1808C4180", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x966CC0", Offset = "0x9654C0", VA = "0x180966CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public PHKMEHELHKE DBGNMLPGHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x966B80", Offset = "0x965380", VA = "0x180966B80", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x966D00", Offset = "0x965500", VA = "0x180966D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public GHFIBDMAJAD LLKDCAILBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x89A8F0", Offset = "0x8990F0", VA = "0x18089A8F0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x92D500", Offset = "0x92BD00", VA = "0x18092D500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public EOMDHBEAOKF LGLHDBOOHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x92F470", Offset = "0x92DC70", VA = "0x18092F470", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x92D520", Offset = "0x92BD20", VA = "0x18092D520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public LAGBFNECIOK FILGDDMBICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x776190", Offset = "0x774990", VA = "0x180776190", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x776150", Offset = "0x774950", VA = "0x180776150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public BJDBCHOFMKL MOENNCOHDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x865EF0", Offset = "0x8646F0", VA = "0x180865EF0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x865F00", Offset = "0x864700", VA = "0x180865F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public KFILGLIIBBP GJNFNLNDEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x82D920", Offset = "0x82C120", VA = "0x18082D920", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x82D930", Offset = "0x82C130", VA = "0x18082D930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public GGJAJFCIBLE NIDMOMIEBKL
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x966B60", Offset = "0x965360", VA = "0x180966B60", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x966CA0", Offset = "0x9654A0", VA = "0x180966CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public NBMNPPBCGEI ECPAJFDJGCF
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x828CC0", Offset = "0x8274C0", VA = "0x180828CC0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x828DF0", Offset = "0x8275F0", VA = "0x180828DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public FHLPDKLILOI FAMKNDCIMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x966C10", Offset = "0x965410", VA = "0x180966C10", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x966EE0", Offset = "0x9656E0", VA = "0x180966EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public EHFEEEKODIH KNAEFALIFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x84A900", Offset = "0x849100", VA = "0x18084A900", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x966E20", Offset = "0x965620", VA = "0x180966E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public GKHIKPLJOCM LOLLMOEFHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x84A910", Offset = "0x849110", VA = "0x18084A910", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x966DC0", Offset = "0x9655C0", VA = "0x180966DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public ACDFEAPAJND CACAPAEAABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x833AB0", Offset = "0x8322B0", VA = "0x180833AB0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x966F00", Offset = "0x965700", VA = "0x180966F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public GMGDMAEDGAB ONFICLLDJJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x833AA0", Offset = "0x8322A0", VA = "0x180833AA0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public MAFDAMMHAPC FHNPPAOAPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x833AC0", Offset = "0x8322C0", VA = "0x180833AC0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public MGDEIDEPHGI KABOEFCPDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x833920", Offset = "0x832120", VA = "0x180833920", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IPAGPBHPJOP BKCFBEBBEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x833900", Offset = "0x832100", VA = "0x180833900", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x966D40", Offset = "0x965540", VA = "0x180966D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private bool MDLAHPCBMHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x63EB1F0", Offset = "0x63E99F0", VA = "0x1863EB1F0", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private bool OOELPCBKOEK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x63EB760", Offset = "0x63E9F60", VA = "0x1863EB760", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private CancellationToken IDFCKMKIIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x63EB960", Offset = "0x63EA160", VA = "0x1863EB960", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private PHIPPCBHDOE LABIMIGACMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action CHCEOMIFEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x63EB840", Offset = "0x63EA040", VA = "0x1863EB840", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x63EB250", Offset = "0x63E9A50", VA = "0x1863EB250", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event BCIMBFIJGNN EHEIBHDDJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x63EBAC0", Offset = "0x63EA2C0", VA = "0x1863EBAC0", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x63EB900", Offset = "0x63EA100", VA = "0x1863EB900", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event BCIMBFIJGNN FIPGOBOFIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x63EB7E0", Offset = "0x63E9FE0", VA = "0x1863EB7E0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x63EB640", Offset = "0x63E9E40", VA = "0x1863EB640", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event BCIMBFIJGNN LKGIBBMNLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x63EB500", Offset = "0x63E9D00", VA = "0x1863EB500", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x63EB8A0", Offset = "0x63EA0A0", VA = "0x1863EB8A0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<DKPFOLLMHMN, bool> BLNDCGBMPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x63EB5E0", Offset = "0x63E9DE0", VA = "0x1863EB5E0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x63EB6A0", Offset = "0x63E9EA0", VA = "0x1863EB6A0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x966D40", Offset = "0x965540", VA = "0x180966D40", Slot = "35")]
	public void BNNNPCCIJDF(IPAGPBHPJOP IHNPIOCKLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x63EBBB0", Offset = "0x63EA3B0", VA = "0x1863EBBB0")]
	[UnityEngine.Scripting.Preserve]
	internal OGJEAHHFEII([NBBCAEDCKMG(null)] PHIPPCBHDOE EFKPBKMFDOG, [NBBCAEDCKMG(null)] FBOMPCMDFLJ GJLGCABGOLK, [NBBCAEDCKMG(null)] LGLBIEKGAIJ NAIJBMLKBBM, [NBBCAEDCKMG(null)] MFLPEJLBJBB NFMOFHCEAPK, [NBBCAEDCKMG(null)] LOMEIBMCEJC GKBCDKPMHEG, [NBBCAEDCKMG(null)] IJECHOENAHN JOGKBPMKDIJ, [NBBCAEDCKMG(null)] ENCKFKHFNFN IFBNIECCPDC, [NBBCAEDCKMG(null)] HJJOGJKLCEL BLACKCPDDOE, [NBBCAEDCKMG(null)] JGKDFFLBMIA OHLLKMLNBIP, [NBBCAEDCKMG(null)] FDAEBAMNBME OGEJBBHBEKD, [NBBCAEDCKMG(null)] LOAOKGHANBJ PHPFDGNPHMG, [NBBCAEDCKMG(null)] CEJNHAIMKDD JBOKIKCLMOB, [NBBCAEDCKMG(null)] FMDDGLKNNGC PNPLNECKMPE, [NBBCAEDCKMG(null)] MDKLFKJDOIN MNAEIPCIBOP, [NBBCAEDCKMG(null)] ONBCPOOPKHA LPOIOLANENE, [NBBCAEDCKMG(null)] AGAFALABMDK OGHAFPBDFCK, [NBBCAEDCKMG(null)] PHKMEHELHKE DPHOHOAIEMG, [NBBCAEDCKMG(null)] GHFIBDMAJAD MEKLELNNIBL, [NBBCAEDCKMG(null)] EOMDHBEAOKF AGAENNCMLCO, [NBBCAEDCKMG(null)] LAGBFNECIOK KJCOKCAFMMG, [NBBCAEDCKMG(null)] KFILGLIIBBP GLDFONPOICH, [NBBCAEDCKMG(null)] BJDBCHOFMKL JEKKIHIOPFL, [NBBCAEDCKMG(null)] GGJAJFCIBLE DMAPPLNDPHD, [NBBCAEDCKMG(null)] NBMNPPBCGEI ELILFOPPFFA, [NBBCAEDCKMG(null)] FHLPDKLILOI OEJCKHGCGPF, [NBBCAEDCKMG(null)] GKHIKPLJOCM MIIMIMJDOBA, [NBBCAEDCKMG(null)] ACDFEAPAJND PMLPMKDPPPF, [NBBCAEDCKMG(null)] GMGDMAEDGAB PPPMFNHGPKF, [NBBCAEDCKMG(null)] MAFDAMMHAPC IJOLNPPNEAD, [NBBCAEDCKMG(null)] MGDEIDEPHGI DLGNCINAPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x63EB450", Offset = "0x63E9C50", VA = "0x1863EB450")]
	private void EBEAKPIECKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x63EB2B0", Offset = "0x63E9AB0", VA = "0x1863EB2B0", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x63EB980", Offset = "0x63EA180", VA = "0x1863EB980", Slot = "48")]
	private void NPIHLMCMBDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x63EB050", Offset = "0x63E9850", VA = "0x1863EB050", Slot = "49")]
	private DOPJAAIDEEK ACFMBJPFOBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x63EBB20", Offset = "0x63EA320", VA = "0x1863EBB20", Slot = "50")]
	private KEJGCHFLKAC PPFLLDFAOEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x63EB0E0", Offset = "0x63E98E0", VA = "0x1863EB0E0", Slot = "51")]
	[AsyncStateMachine(typeof(ELPOIAJPGIL))]
	private Task<HACEOFOLLHI> CBPOGLMJALM(GMPFCCLMDAG FKGBPLGHMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x63EB9D0", Offset = "0x63EA1D0", VA = "0x1863EB9D0", Slot = "52")]
	[AsyncStateMachine(typeof(EPDCGOHLKGE))]
	private Task OOOFLGIFDOD(CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x63EB560", Offset = "0x63E9D60", VA = "0x1863EB560")]
	[IteratorStateMachine(typeof(HNNHOJNKKHN))]
	private IEnumerable<IPOCNADENOB> EPBNIDOHNLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x63EB700", Offset = "0x63E9F00", VA = "0x1863EB700")]
	[CompilerGenerated]
	private void HHMPPCGEGNK(IPOCNADENOB MPHNJKMAKJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class BLMOOLBABKK : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0xCA7B60", Offset = "0xCA6360", VA = "0x180CA7B60")]
	public BLMOOLBABKK(string OLDFIJBKFKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class BLOLLNHBFKJ : CPCDBBGNHIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct MPEDABCCFKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public BLOLLNHBFKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x63E9340", Offset = "0x63E7B40", VA = "0x1863E9340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x63E9680", Offset = "0x63E7E80", VA = "0x1863E9680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MFLPEJLBJBB NFMOFHCEAPK;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x77D5B0", Offset = "0x77BDB0", VA = "0x18077D5B0")]
	public BLOLLNHBFKJ(NGLGDOHLABH JKOJLJMCFCA, MFLPEJLBJBB NFMOFHCEAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x63D6070", Offset = "0x63D4870", VA = "0x1863D6070", Slot = "4")]
	[AsyncStateMachine(typeof(MPEDABCCFKM))]
	public Task<bool> HBLHJFBFBAH(CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x63D6160", Offset = "0x63D4960", VA = "0x1863D6160")]
	[CompilerGenerated]
	private object PMIEIEJEMEA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class PPDJFDBCACN : CPCDBBGNHIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct CJNBMAKILAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public PPDJFDBCACN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x63D7490", Offset = "0x63D5C90", VA = "0x1863D7490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x63D7BA0", Offset = "0x63D63A0", VA = "0x1863D7BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MFLPEJLBJBB NFMOFHCEAPK;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private DJPPJKIGHMC DMKFBEHIHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x63F07E0", Offset = "0x63EEFE0", VA = "0x1863F07E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x77D5B0", Offset = "0x77BDB0", VA = "0x18077D5B0")]
	public PPDJFDBCACN(NGLGDOHLABH JKOJLJMCFCA, MFLPEJLBJBB NFMOFHCEAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x63F0830", Offset = "0x63EF030", VA = "0x1863F0830", Slot = "4")]
	[AsyncStateMachine(typeof(CJNBMAKILAB))]
	public Task<bool> HBLHJFBFBAH(CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x63F0960", Offset = "0x63EF160", VA = "0x1863F0960")]
	[CompilerGenerated]
	private object MGBEIAFFKGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class LFMLFPDJGGN : CPCDBBGNHIE
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class LKADAHKHDMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public LFMLFPDJGGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public JGINHPAKLAK result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public MPLKHMAMHAD newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public LKADAHKHDMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x63E6BD0", Offset = "0x63E53D0", VA = "0x1863E6BD0")]
		internal object MECILHBHLPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x63E6AC0", Offset = "0x63E52C0", VA = "0x1863E6AC0")]
		internal object IKCMPCIDBKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x63E6B30", Offset = "0x63E5330", VA = "0x1863E6B30")]
		internal object KAKFOFMBDLP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct FEBNJKCKGHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public LFMLFPDJGGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private LKADAHKHDMA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<JGINHPAKLAK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x63D98C0", Offset = "0x63D80C0", VA = "0x1863D98C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x63DA1F0", Offset = "0x63D89F0", VA = "0x1863DA1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MFLPEJLBJBB NFMOFHCEAPK;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private DJPPJKIGHMC DMKFBEHIHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x63E5CC0", Offset = "0x63E44C0", VA = "0x1863E5CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x77D5B0", Offset = "0x77BDB0", VA = "0x18077D5B0")]
	public LFMLFPDJGGN(NGLGDOHLABH JKOJLJMCFCA, MFLPEJLBJBB NFMOFHCEAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x63E5D10", Offset = "0x63E4510", VA = "0x1863E5D10", Slot = "4")]
	[AsyncStateMachine(typeof(FEBNJKCKGHB))]
	public Task<bool> HBLHJFBFBAH(CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal interface CPCDBBGNHIE
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> HBLHJFBFBAH(CancellationToken GANAOLJLMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct LPGNOFPDAPK
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class JBEMNOEFDFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public NGLGDOHLABH manager;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JBEMNOEFDFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x63E2350", Offset = "0x63E0B50", VA = "0x1863E2350")]
		internal Task ELBFNLDKIGB(NKCNOMEENDM data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct ALDHKJJLFLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public LPGNOFPDAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private GMPFCCLMDAG <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<CDLCKNOBODL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<HACEOFOLLHI> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x63D49B0", Offset = "0x63D31B0", VA = "0x1863D49B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x63D4F40", Offset = "0x63D3740", VA = "0x1863D4F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct KEKBMDGNECC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public LPGNOFPDAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x63E41A0", Offset = "0x63E29A0", VA = "0x1863E41A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x63E44C0", Offset = "0x63E2CC0", VA = "0x1863E44C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CancellationToken GANAOLJLMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly NGLGDOHLABH CLDKLPDMMOI;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private FBOMPCMDFLJ CFKJLAKOPEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x63E8310", Offset = "0x63E6B10", VA = "0x1863E8310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private MFLPEJLBJBB PELEPLGFCGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x63E80B0", Offset = "0x63E68B0", VA = "0x1863E80B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private DJPPJKIGHMC DMKFBEHIHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x63E7F60", Offset = "0x63E6760", VA = "0x1863E7F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private FDAEBAMNBME BKPPHLKDJHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x63E8410", Offset = "0x63E6C10", VA = "0x1863E8410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB280", Offset = "0x1CC9A80", VA = "0x181CCB280")]
	public LPGNOFPDAPK(CancellationToken GANAOLJLMGA, NGLGDOHLABH CLDKLPDMMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x63E8360", Offset = "0x63E6B60", VA = "0x1863E8360")]
	public static COIKDGIFMGF DONJMEJPFFG(NGLGDOHLABH CLDKLPDMMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x63E8590", Offset = "0x63E6D90", VA = "0x1863E8590")]
	[AsyncStateMachine(typeof(ALDHKJJLFLM))]
	public Task<bool> PODNDBGONHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x63E8100", Offset = "0x63E6900", VA = "0x1863E8100")]
	private bool CJIGHHJMICJ([Out] GMPFCCLMDAG FKGBPLGHMDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x63E7FE0", Offset = "0x63E67E0", VA = "0x1863E7FE0")]
	[AsyncStateMachine(typeof(KEKBMDGNECC))]
	private Task BOIGJMCPHAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x63E8460", Offset = "0x63E6C60", VA = "0x1863E8460")]
	private Task<CDLCKNOBODL> JLMCMEEJGCC(GMPFCCLMDAG NIEILFLFHFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal struct OMGAFAPCPKA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly ONBCPOOPKHA LPOIOLANENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid HGCENGMCDHK;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private Task<(HACEOFOLLHI, Task)> EMLANCIAMOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x63F0120", Offset = "0x63EE920", VA = "0x1863F0120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x39CDA40", Offset = "0x39CC240", VA = "0x1839CDA40")]
	public OMGAFAPCPKA(ONBCPOOPKHA LPOIOLANENE, Guid HGCENGMCDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x63F01F0", Offset = "0x63EE9F0", VA = "0x1863F01F0")]
	public TaskAwaiter<(HACEOFOLLHI, Task)> NDIAGNCOELE()
	{
		return default(TaskAwaiter<(HACEOFOLLHI, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x63F0050", Offset = "0x63EE850", VA = "0x1863F0050", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct DAICCAAPEMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly TaskCompletionSource<(HACEOFOLLHI, Task)> KAHJHKGKLIE;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Task<(HACEOFOLLHI, Task)> EMLANCIAMOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x63D7E20", Offset = "0x63D6620", VA = "0x1863D7E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x63D7E60", Offset = "0x63D6660", VA = "0x1863D7E60")]
	public DAICCAAPEMA(TimeSpan ILOOJEFCFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x63D7CF0", Offset = "0x63D64F0", VA = "0x1863D7CF0")]
	public void JIIINDKFBEF(Task GLIIHKJPDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x63D7D90", Offset = "0x63D6590", VA = "0x1863D7D90")]
	public void LEPNEEENONK(HACEOFOLLHI EEFAEJINOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x63D7C10", Offset = "0x63D6410", VA = "0x1863D7C10")]
	public void DFLNIEDJDAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x63D7C60", Offset = "0x63D6460", VA = "0x1863D7C60")]
	internal void IFGHMABIMDO(string OLDFIJBKFKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class ICEGGKEFPLE
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class PMFCDELAEKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public FEAFPIIILAH subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public PMFCDELAEKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x63F0740", Offset = "0x63EEF40", VA = "0x1863F0740")]
		internal bool PPAGPPNNBMH(LKADGOEJKMM s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x63E1CD0", Offset = "0x63E04D0", VA = "0x1863E1CD0")]
	public static MDONEMLENMD OEONKPJDENI(long INBENEPJAAJ, long NOJFBKAHMKA, string JDODMIBKHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x63E1D60", Offset = "0x63E0560", VA = "0x1863E1D60")]
	public static MDONEMLENMD OEONKPJDENI(long INBENEPJAAJ, long NOJFBKAHMKA, LJEPICPLNFE GDEABNLEJPG, long MGLCKKIMBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x63E2050", Offset = "0x63E0850", VA = "0x1863E2050")]
	public static MDONEMLENMD OEONKPJDENI(DBLJMINNAMP CPNOFCJGBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x63E1E20", Offset = "0x63E0620", VA = "0x1863E1E20")]
	public static MDONEMLENMD OEONKPJDENI(IKGFEJPGNIE JFMPNPDEIDL, FEAFPIIILAH GMGCCBCHBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x63E1A50", Offset = "0x63E0250", VA = "0x1863E1A50")]
	public static MDONEMLENMD JOGHOIFEJHN(this MDONEMLENMD IOHCLNMNKCI, IKGFEJPGNIE KLMHPHGAIBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x63E1B40", Offset = "0x63E0340", VA = "0x1863E1B40")]
	public static MDONEMLENMD KBLBPBEOGOF(this MDONEMLENMD IOHCLNMNKCI, FEAFPIIILAH GKEKPCICLLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[RecRoom.NoEngine.Common.Preserve]
internal class LBPGNFCFAII : JGKDFFLBMIA, IPOCNADENOB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct NLAOMFOOPOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public LBPGNFCFAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x63E9810", Offset = "0x63E8010", VA = "0x1863E9810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x63E9EF0", Offset = "0x63E86F0", VA = "0x1863E9EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly CCHLDLOCDCI ILFBCKJMMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private string OIIDCOJBLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Task CANNDCDJCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool OFIGFJMPKOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x63E5AA0", Offset = "0x63E42A0", VA = "0x1863E5AA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public Task MEJMJECHLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x63E58F0", Offset = "0x63E40F0", VA = "0x1863E58F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x778B30", Offset = "0x777330", VA = "0x180778B30", Slot = "7")]
	public void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x63E5AD0", Offset = "0x63E42D0", VA = "0x1863E5AD0", Slot = "6")]
	public void OCFBFAINICH(Task KONAOGGENMJ, string JFLDCBLMJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x63E5980", Offset = "0x63E4180", VA = "0x1863E5980")]
	[AsyncStateMachine(typeof(NLAOMFOOPOE))]
	private Task KBIBJHINMDA(Task OLMLCCFLFCJ, string JFLDCBLMJBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x63E5C30", Offset = "0x63E4430", VA = "0x1863E5C30")]
	public LBPGNFCFAII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class FEPKJPBLHLI : EHFEEEKODIH, IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool CLKCDIDBIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private IJFKBIOGJOO JKFLNPFEKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private FBOMPCMDFLJ GJLGCABGOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private GKHIKPLJOCM MIIMIMJDOBA;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public IJFKBIOGJOO LFMALPIIKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x63DA5D0", Offset = "0x63D8DD0", VA = "0x1863DA5D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x63DA2A0", Offset = "0x63D8AA0", VA = "0x1863DA2A0", Slot = "7")]
	public void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x63DA420", Offset = "0x63D8C20", VA = "0x1863DA420", Slot = "5")]
	public void LJPDKKOMFEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x63DA260", Offset = "0x63D8A60", VA = "0x1863DA260", Slot = "6")]
	public void KMOOGMICMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x63DA640", Offset = "0x63D8E40", VA = "0x1863DA640")]
	private Task PKEGPECIJIK(PFHACEOLJGC CCHIEENNEGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x63DA260", Offset = "0x63D8A60", VA = "0x1863DA260", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public FEPKJPBLHLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class MDPBFJAMKMN : GKHIKPLJOCM
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class HINJAMEAEMG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly MFLHIKJNAFF CAMBNMFHNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly string EMBEECDJLJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly T OGJIDOCEOED;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public T HMHFMLFLMGB
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x7C5270", Offset = "0x7C3A70", VA = "0x1807C5270")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x952690", Offset = "0x950E90", VA = "0x180952690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x359E130", Offset = "0x359C930", VA = "0x18359E130")]
		public HINJAMEAEMG(MFLHIKJNAFF CAMBNMFHNGC, string EMBEECDJLJB, T OGJIDOCEOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x359DB60", Offset = "0x359C360", VA = "0x18359DB60")]
		private void FJLHNCECJPD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly MFLHIKJNAFF CAMBNMFHNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly HINJAMEAEMG<TimeSpan> MEGIPJPDIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly HINJAMEAEMG<TimeSpan> FHIAGOKLJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly HINJAMEAEMG<TimeSpan> ACENNKHMJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly HINJAMEAEMG<TimeSpan> EBCOLKJBDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly HINJAMEAEMG<bool> LINJNHOLJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly HINJAMEAEMG<bool> FMECNIPCMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly HINJAMEAEMG<bool> KFLFGNFIGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly HINJAMEAEMG<int> MNLJMMIFOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly HINJAMEAEMG<bool> BFMDMNIPLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly HINJAMEAEMG<bool> JHJPCPBICGB;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan DEJMMKGPMJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x63E87E0", Offset = "0x63E6FE0", VA = "0x1863E87E0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public TimeSpan IMMOAFONNLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x63E88E0", Offset = "0x63E70E0", VA = "0x1863E88E0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public TimeSpan LMGKBIMEEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x63E8720", Offset = "0x63E6F20", VA = "0x1863E8720", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public TimeSpan NLFFOKOFJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x63E8760", Offset = "0x63E6F60", VA = "0x1863E8760", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool EJAGLMEBIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x63E86E0", Offset = "0x63E6EE0", VA = "0x1863E86E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool BAEIKFLFNAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x63E86A0", Offset = "0x63E6EA0", VA = "0x1863E86A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool AIMAGBMBENL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x63E88A0", Offset = "0x63E70A0", VA = "0x1863E88A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int OCEPPFKANNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x63E8860", Offset = "0x63E7060", VA = "0x1863E8860", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool JIJCMDBNJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x63E8820", Offset = "0x63E7020", VA = "0x1863E8820", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool LJEGCBGDBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x63E87A0", Offset = "0x63E6FA0", VA = "0x1863E87A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x63E8920", Offset = "0x63E7120", VA = "0x1863E8920")]
	[UnityEngine.Scripting.Preserve]
	public MDPBFJAMKMN([NBBCAEDCKMG(null)] MFLHIKJNAFF CAMBNMFHNGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[UnityEngine.Scripting.Preserve]
internal class OGAOCLMCFBC : LOAOKGHANBJ, IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class ICAFLLJJGFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public IKHDPBEDCBP roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public ICAFLLJJGFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x63E1970", Offset = "0x63E0170", VA = "0x1863E1970")]
		internal object AAKOCHCEJPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action HENCOOCCDPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x63EA620", Offset = "0x63E8E20", VA = "0x1863EA620", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x63EA990", Offset = "0x63E9190", VA = "0x1863EA990", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event BCIMBFIJGNN LFGPFANCFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x63EA530", Offset = "0x63E8D30", VA = "0x1863EA530", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x63EACE0", Offset = "0x63E94E0", VA = "0x1863EACE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event BCIMBFIJGNN MJAMMBMGBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x63EAA30", Offset = "0x63E9230", VA = "0x1863EAA30", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x63EAB70", Offset = "0x63E9370", VA = "0x1863EAB70", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event BCIMBFIJGNN FAEMNBGCEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x63EAC10", Offset = "0x63E9410", VA = "0x1863EAC10", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x63EAAD0", Offset = "0x63E92D0", VA = "0x1863EAAD0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<DKPFOLLMHMN, bool> DFOHCCEMJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x63EAD80", Offset = "0x63E9580", VA = "0x1863EAD80", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x63EA6C0", Offset = "0x63E8EC0", VA = "0x1863EA6C0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "19")]
	public void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x63EAE30", Offset = "0x63E9630", VA = "0x1863EAE30", Slot = "14")]
	public void OINJPKCDJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x63EACB0", Offset = "0x63E94B0", VA = "0x1863EACB0", Slot = "15")]
	public void LHCNIDACLKE(IKHDPBEDCBP MPAGHDFMNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x63EA770", Offset = "0x63E8F70", VA = "0x1863EA770", Slot = "16")]
	public void HCLMAOKBBKG(IKHDPBEDCBP MPAGHDFMNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x63EA500", Offset = "0x63E8D00", VA = "0x1863EA500", Slot = "17")]
	public void DLCBHOEMKBL(IKHDPBEDCBP MPAGHDFMNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x63EA5D0", Offset = "0x63E8DD0", VA = "0x1863EA5D0", Slot = "18")]
	public void ELLFBKFNLDB(DKPFOLLMHMN CGNHLHIMGDH, bool DGADJKHCOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x63EA7A0", Offset = "0x63E8FA0", VA = "0x1863EA7A0")]
	private void HFBCPPDOIOJ(BCIMBFIJGNN NGHAPAIADFF, IKHDPBEDCBP MPAGHDFMNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public OGAOCLMCFBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal class LMCNEKFJDNI : CEJNHAIMKDD, IPOCNADENOB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct MJKLOPCMEOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public LMCNEKFJDNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x63E8D90", Offset = "0x63E7590", VA = "0x1863E8D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x63E92E0", Offset = "0x63E7AE0", VA = "0x1863E92E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct KNBEMABNELM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public LMCNEKFJDNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x63E4F40", Offset = "0x63E3740", VA = "0x1863E4F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x63E55E0", Offset = "0x63E3DE0", VA = "0x1863E55E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class PMIFDNALKJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public PMIFDNALKJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x63F0770", Offset = "0x63EEF70", VA = "0x1863F0770")]
		internal object FJBCGEEOOKL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct PPOEOAPNHKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public LMCNEKFJDNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private PMIFDNALKJG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x63F12D0", Offset = "0x63EFAD0", VA = "0x1863F12D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x63F1A60", Offset = "0x63F0260", VA = "0x1863F1A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class HGMDMHODPEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public HGMDMHODPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x63E0600", Offset = "0x63DEE00", VA = "0x1863E0600")]
		internal object MINPMJNJMAE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly DNJICJAPBOC KIDCMOJGGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private MFLPEJLBJBB NFMOFHCEAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private CPCDBBGNHIE[] LMIPIMOGCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private CancellationTokenSource LFJFOBIGOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private int IMEBMMBOLHJ;

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x63E70C0", Offset = "0x63E58C0", VA = "0x1863E70C0", Slot = "6")]
	public void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x63E70B0", Offset = "0x63E58B0", VA = "0x1863E70B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x63E7140", Offset = "0x63E5940", VA = "0x1863E7140", Slot = "8")]
	public void GGPHDHEGLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x63E7880", Offset = "0x63E6080", VA = "0x1863E7880", Slot = "5")]
	public void PLOACLMEDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x63E7250", Offset = "0x63E5A50", VA = "0x1863E7250", Slot = "4")]
	[AsyncStateMachine(typeof(MJKLOPCMEOD))]
	public Task JBDMEHKNOCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x63E6CC0", Offset = "0x63E54C0", VA = "0x1863E6CC0")]
	private void BIDNNLAAEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x63E7660", Offset = "0x63E5E60", VA = "0x1863E7660")]
	[AsyncStateMachine(typeof(KNBEMABNELM))]
	private Task MJJDGFNCPCC(CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x63E7400", Offset = "0x63E5C00", VA = "0x1863E7400")]
	[AsyncStateMachine(typeof(PPOEOAPNHKB))]
	private Task<bool> LHAOEIGOAPH(int EAHCFBMNNCF, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x63E6FD0", Offset = "0x63E57D0", VA = "0x1863E6FD0")]
	private void CJAMKLKKLHC(int EAHCFBMNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x63E7320", Offset = "0x63E5B20", VA = "0x1863E7320")]
	private void JIJFBNMDBMM(int EAHCFBMNNCF, bool DGADJKHCOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x63E7750", Offset = "0x63E5F50", VA = "0x1863E7750")]
	private void NDKNNFDPBKJ(int EAHCFBMNNCF, Exception IOPFKNIOMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x63E7530", Offset = "0x63E5D30", VA = "0x1863E7530")]
	private void MHMKDFOGKBI(CancellationToken GANAOLJLMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public LMCNEKFJDNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class OIMMEEEIPEJ : FMDDGLKNNGC, IPOCNADENOB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct KEPACJILCJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public MPLKHMAMHAD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public OIMMEEEIPEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public IPAGPBHPJOP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x63E4520", Offset = "0x63E2D20", VA = "0x1863E4520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x63E4EE0", Offset = "0x63E36E0", VA = "0x1863E4EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct EMAOGDAMJJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public OIMMEEEIPEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public MPLKHMAMHAD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public IPAGPBHPJOP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private FHBHLKGBKLK<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private ENLDEMGODIF <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private EDAANACKNFJ <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x63D8920", Offset = "0x63D7120", VA = "0x1863D8920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x63D9520", Offset = "0x63D7D20", VA = "0x1863D9520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class FBFEEEKFPOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Matchmaking.HDFPNDPOFOA result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public NGFNOMHKLFB errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public FBFEEEKFPOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x63D9810", Offset = "0x63D8010", VA = "0x1863D9810")]
		internal object GCLFIBCNPOK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class OKLLDLFBDOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public Task<MDONEMLENMD> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public OKLLDLFBDOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		internal Task<MDONEMLENMD> JFPCDBDMJJG(FHBHLKGBKLK<string>.CAOEJONIOII _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct FIFCGGONHHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public OIMMEEEIPEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public MPLKHMAMHAD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public FHBHLKGBKLK<string>.CAOEJONIOII timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IPAGPBHPJOP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public ENLDEMGODIF joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private OKLLDLFBDOA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private GBLKFKJHOMM <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private ECDOFACJIHE <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private Task<Matchmaking.HOEJMGOGBLE> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private BEIFODEBFBO <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter<Matchmaking.HOEJMGOGBLE> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter<MDONEMLENMD> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x63DB390", Offset = "0x63D9B90", VA = "0x1863DB390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x63E0530", Offset = "0x63DED30", VA = "0x1863E0530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct AMIFKEOEGKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public OIMMEEEIPEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public FHBHLKGBKLK<string>.CAOEJONIOII timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x63D4FB0", Offset = "0x63D37B0", VA = "0x1863D4FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x63D5A40", Offset = "0x63D4240", VA = "0x1863D5A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct ADFMAAKKFMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public OIMMEEEIPEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private PHIPPCBHDOE <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x63D3B60", Offset = "0x63D2360", VA = "0x1863D3B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x63D3FE0", Offset = "0x63D27E0", VA = "0x1863D3FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct LMMNBINHJJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder<Matchmaking.HOEJMGOGBLE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public MPLKHMAMHAD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public FHBHLKGBKLK<string>.CAOEJONIOII timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public OIMMEEEIPEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter<Matchmaking.HOEJMGOGBLE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x63E79F0", Offset = "0x63E61F0", VA = "0x1863E79F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x63E7EF0", Offset = "0x63E66F0", VA = "0x1863E7EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct ABPALGFBBCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public FHBHLKGBKLK<string>.CAOEJONIOII timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Matchmaking.HOEJMGOGBLE serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public OIMMEEEIPEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public ENLDEMGODIF joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter<OBDFJKGIPOH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x63D33D0", Offset = "0x63D1BD0", VA = "0x1863D33D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x63D3B00", Offset = "0x63D2300", VA = "0x1863D3B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class PLIEBFBJDPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public MPLKHMAMHAD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public PLIEBFBJDPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x63F0640", Offset = "0x63EEE40", VA = "0x1863F0640")]
		internal object LOJIPJHONFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x63F0540", Offset = "0x63EED40", VA = "0x1863F0540")]
		internal string DMAOMAEFHLH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct FFCDDOONCME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public MPLKHMAMHAD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public OIMMEEEIPEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private PLIEBFBJDPN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x63DA700", Offset = "0x63D8F00", VA = "0x1863DA700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x63DB330", Offset = "0x63D9B30", VA = "0x1863DB330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct AGCNJEPBODG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public FHBHLKGBKLK<string>.CAOEJONIOII timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public OIMMEEEIPEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public ENLDEMGODIF joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public MDONEMLENMD initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public MPLKHMAMHAD targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public GBLKFKJHOMM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x63D4040", Offset = "0x63D2840", VA = "0x1863D4040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x63D4950", Offset = "0x63D3150", VA = "0x1863D4950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct JBGIDCKACGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public FHBHLKGBKLK<string>.CAOEJONIOII timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public OIMMEEEIPEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x63E23A0", Offset = "0x63E0BA0", VA = "0x1863E23A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x63E3A40", Offset = "0x63E2240", VA = "0x1863E3A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct PPLDGKAEPLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public OIMMEEEIPEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<HACEOFOLLHI> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x63F0A40", Offset = "0x63EF240", VA = "0x1863F0A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x63F1270", Offset = "0x63EFA70", VA = "0x1863F1270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class JCPHGMCBKKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public MPLKHMAMHAD targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JCPHGMCBKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x63E3AA0", Offset = "0x63E22A0", VA = "0x1863E3AA0")]
		internal object NLMOCPJMGKE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class NEALCLPOCDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public NEALCLPOCDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x63E9770", Offset = "0x63E7F70", VA = "0x1863E9770")]
		internal void BEPAGGCIMLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class NCEHGNEODPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public MPLKHMAMHAD targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public NCEHGNEODPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x63E96F0", Offset = "0x63E7EF0", VA = "0x1863E96F0")]
		internal object BEGLEGCGFLM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class IPDLDMCPBHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public MPLKHMAMHAD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public IPDLDMCPBHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x63E2250", Offset = "0x63E0A50", VA = "0x1863E2250")]
		internal string ONMJBHDFICA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly DNJICJAPBOC KIDCMOJGGGC;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly DNJICJAPBOC ANNEOODNFFL;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly DNJICJAPBOC JOBDCGPJHCA;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly DNJICJAPBOC BLKPPCPAINL;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly string MEMOCGFPIGN;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string HABLHMOMPFG;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string BEGDODAFEIN;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static readonly Guid IKGCHCAIDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private HJJOGJKLCEL BLACKCPDDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private LGLBIEKGAIJ NAIJBMLKBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private FBOMPCMDFLJ GJLGCABGOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private MFLPEJLBJBB NFMOFHCEAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private CEJNHAIMKDD JBOKIKCLMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private JGKDFFLBMIA OHLLKMLNBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private LOAOKGHANBJ PHPFDGNPHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private MGDEIDEPHGI DLGNCINAPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private MAFDAMMHAPC IJOLNPPNEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private IDisposable KMOAPMNGJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly CCHLDLOCDCI BDPCGGADNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly CCHLDLOCDCI HEEPIEFAOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private BEIFODEBFBO APFOGFEOLHG;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public TaskStatus KOKOHCFNFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9FDA70", Offset = "0x9FC270", VA = "0x1809FDA70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA4B760", Offset = "0xA49F60", VA = "0x180A4B760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private DJPPJKIGHMC DMKFBEHIHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x63EC3A0", Offset = "0x63EABA0", VA = "0x1863EC3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x63EC850", Offset = "0x63EB050", VA = "0x1863EC850", Slot = "6")]
	public void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x63EC800", Offset = "0x63EB000", VA = "0x1863EC800", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x63EE7B0", Offset = "0x63ECFB0", VA = "0x1863EE7B0", Slot = "5")]
	[AsyncStateMachine(typeof(KEPACJILCJA))]
	public Task NGALEGOLMDN(MPLKHMAMHAD EFGEAIMNMOK, IPAGPBHPJOP IGCPFPEAMHJ, CancellationToken LCNDAGMDGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x63EDB50", Offset = "0x63EC350", VA = "0x1863EDB50")]
	[AsyncStateMachine(typeof(EMAOGDAMJJP))]
	private Task KJJHJIHHAIN(MPLKHMAMHAD EFGEAIMNMOK, IPAGPBHPJOP IGCPFPEAMHJ, CancellationToken LCNDAGMDGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x63EE3F0", Offset = "0x63ECBF0", VA = "0x1863EE3F0")]
	private static void NALOAIDPCGE(MGDEIDEPHGI DLGNCINAPDI, MPLKHMAMHAD EFGEAIMNMOK, Exception IOPFKNIOMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x63EEC20", Offset = "0x63ED420", VA = "0x1863EEC20")]
	private static void PCPAOEGKAIN(EDAANACKNFJ MMICAMGCMIC, Exception IOPFKNIOMEG, [Optional] List<int> BFHIJEPGDCE, int IMEBMMBOLHJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x63EC540", Offset = "0x63EAD40", VA = "0x1863EC540")]
	[AsyncStateMachine(typeof(FIFCGGONHHK))]
	private Task DCCILLGJPKH(FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, MPLKHMAMHAD EFGEAIMNMOK, IPAGPBHPJOP IGCPFPEAMHJ, ENLDEMGODIF OJDMHELEOFH, CancellationToken LCNDAGMDGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x63ECD10", Offset = "0x63EB510", VA = "0x1863ECD10")]
	private void FAEEGPHIMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x63EEAF0", Offset = "0x63ED2F0", VA = "0x1863EEAF0")]
	[AsyncStateMachine(typeof(AMIFKEOEGKJ))]
	private Task OJNILENFBGC(FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x63EF4B0", Offset = "0x63EDCB0", VA = "0x1863EF4B0")]
	private void PJMAADEJEJO(MPLKHMAMHAD EFGEAIMNMOK, CancellationToken LCNDAGMDGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x63ED5D0", Offset = "0x63EBDD0", VA = "0x1863ED5D0")]
	private void JKKLILMMBCC(MPLKHMAMHAD EFGEAIMNMOK, ENLDEMGODIF OJDMHELEOFH, OperationCanceledException KBKIKMIEBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x63EDF60", Offset = "0x63EC760", VA = "0x1863EDF60")]
	private void LNECOEELJOJ(MPLKHMAMHAD EFGEAIMNMOK, ENLDEMGODIF OJDMHELEOFH, Exception IOPFKNIOMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x63EBFF0", Offset = "0x63EA7F0", VA = "0x1863EBFF0")]
	private void AAFBOFIFKGK(MPLKHMAMHAD EFGEAIMNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x63EF7F0", Offset = "0x63EDFF0", VA = "0x1863EF7F0")]
	private static IKHDPBEDCBP PKPPPJEJHCF(MPLKHMAMHAD EFGEAIMNMOK)
	{
		return default(IKHDPBEDCBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x63EC6A0", Offset = "0x63EAEA0", VA = "0x1863EC6A0")]
	[AsyncStateMachine(typeof(ADFMAAKKFMI))]
	private Task DFDNAMILAKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x63EE290", Offset = "0x63ECA90", VA = "0x1863EE290")]
	[AsyncStateMachine(typeof(LMMNBINHJJB))]
	private Task<Matchmaking.HOEJMGOGBLE> LPEPMFHOPGL(MPLKHMAMHAD EFGEAIMNMOK, FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x63ED3A0", Offset = "0x63EBBA0", VA = "0x1863ED3A0")]
	private static OBDFJKGIPOH JELADBEPFFI(Matchmaking.HOEJMGOGBLE PDCGMIFPALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x63EC3F0", Offset = "0x63EABF0", VA = "0x1863EC3F0")]
	[AsyncStateMachine(typeof(ABPALGFBBCM))]
	private Task CKBFODANKPD(Matchmaking.HOEJMGOGBLE PDCGMIFPALF, ENLDEMGODIF OJDMHELEOFH, FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, CancellationToken IFDNJLLFNBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x63ED800", Offset = "0x63EC000", VA = "0x1863ED800")]
	[AsyncStateMachine(typeof(FFCDDOONCME))]
	private Task JNPICBEBCIE(MPLKHMAMHAD EFGEAIMNMOK, CancellationTokenSource MFOONNHELDE, Task KFJPMDGNJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x63ED230", Offset = "0x63EBA30", VA = "0x1863ED230")]
	[AsyncStateMachine(typeof(AGCNJEPBODG))]
	private Task ICGEDCDMIFB(MDONEMLENMD IFIMLDHIAJE, GBLKFKJHOMM NLBECEHADAK, MPLKHMAMHAD PEEDKCGBPMJ, ENLDEMGODIF CJLMEOHJLGJ, FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, CancellationToken LGLOGJOFJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x63ED950", Offset = "0x63EC150", VA = "0x1863ED950")]
	private ENLDEMGODIF KBPKFHALKCP(ENLDEMGODIF CJLMEOHJLGJ, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x63ED100", Offset = "0x63EB900", VA = "0x1863ED100")]
	[AsyncStateMachine(typeof(JBGIDCKACGP))]
	private Task HLPNFLFPGPK(FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x63ED4B0", Offset = "0x63EBCB0", VA = "0x1863ED4B0")]
	[AsyncStateMachine(typeof(PPLDGKAEPLA))]
	private Task JEPFPPMAINE(NKCNOMEENDM FCHBDAMJEHN, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x63EC220", Offset = "0x63EAA20", VA = "0x1863EC220")]
	private static void ABJJJNAJPIC(MPLKHMAMHAD EFGEAIMNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x63EDCA0", Offset = "0x63EC4A0", VA = "0x1863EDCA0")]
	private void KNEHCMHIEOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x63EC770", Offset = "0x63EAF70", VA = "0x1863EC770")]
	private void DJJDHIFLJBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x63EDE70", Offset = "0x63EC670", VA = "0x1863EDE70")]
	private void KPGNNHCKOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x63EE8F0", Offset = "0x63ED0F0", VA = "0x1863EE8F0")]
	private void OAIKIACMBIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x63ED010", Offset = "0x63EB810", VA = "0x1863ED010")]
	private static void GLAPFINJLPI(MPLKHMAMHAD EFGEAIMNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x63EE9E0", Offset = "0x63ED1E0", VA = "0x1863EE9E0")]
	private static CancellationTokenRegistration OJBLAPEFFKE(MPLKHMAMHAD EFGEAIMNMOK, CancellationToken IFDNJLLFNBJ)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x63EE190", Offset = "0x63EC990", VA = "0x1863EE190")]
	private static void LOFIGMGCKAG(MPLKHMAMHAD EFGEAIMNMOK, Exception IOPFKNIOMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x63ECE60", Offset = "0x63EB660", VA = "0x1863ECE60")]
	private void FOLHHBPNNCK(MPLKHMAMHAD EFGEAIMNMOK, Task KFJPMDGNJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x63EE980", Offset = "0x63ED180", VA = "0x1863EE980")]
	private static void OHIILDFJLAF(Func<string> GENKKDFBIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x63EFA70", Offset = "0x63EE270", VA = "0x1863EFA70")]
	public OIMMEEEIPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x63EDF00", Offset = "0x63EC700", VA = "0x1863EDF00")]
	[CompilerGenerated]
	internal static (int, int?) LCEAMKLKEAF(NGFNOMHKLFB PIKNFMIHJEE)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[RecRoom.NoEngine.Common.Preserve]
internal class BPCOMHANNBN : MDKLFKJDOIN, IPOCNADENOB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct HFGAEEEPMDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public BPCOMHANNBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public NKCNOMEENDM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x63FC2F0", Offset = "0x63FAAF0", VA = "0x1863FC2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x63FC6B0", Offset = "0x63FAEB0", VA = "0x1863FC6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class GNLNKLHFNOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public BPCOMHANNBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public NKCNOMEENDM roomData;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public GNLNKLHFNOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x63F9D70", Offset = "0x63F8570", VA = "0x1863F9D70")]
		internal List<Task> CGAELKMLDGN(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct CCBKEGFNBOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public COIKDGIFMGF taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x63F5010", Offset = "0x63F3810", VA = "0x1863F5010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x63F53E0", Offset = "0x63F3BE0", VA = "0x1863F53E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct EMFJKFJIOFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public BPCOMHANNBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x63F88F0", Offset = "0x63F70F0", VA = "0x1863F88F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x63F8BB0", Offset = "0x63F73B0", VA = "0x1863F8BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly HashSet<COIKDGIFMGF> JEALJIELPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private LGLBIEKGAIJ NAIJBMLKBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private PDJBLODEPPI FMBJKDPMIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private NBHHAOHOHCI CJOFNGADOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private IDisposable KMOAPMNGJNM;

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x63D6AD0", Offset = "0x63D52D0", VA = "0x1863D6AD0", Slot = "5")]
	public void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x63D6A70", Offset = "0x63D5270", VA = "0x1863D6A70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x63D73A0", Offset = "0x63D5BA0", VA = "0x1863D73A0", Slot = "4")]
	public bool OBPPKOFBHNJ(COIKDGIFMGF BGODJLAGPMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x63D7190", Offset = "0x63D5990", VA = "0x1863D7190")]
	private void KHJLBIBKDPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x63D6F90", Offset = "0x63D5790", VA = "0x1863D6F90")]
	private void INEGKEFCPJA(NKCNOMEENDM HCADKDIKPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x63D6DD0", Offset = "0x63D55D0", VA = "0x1863D6DD0")]
	[AsyncStateMachine(typeof(HFGAEEEPMDD))]
	private Task GNKDHENGDOE(NKCNOMEENDM HCADKDIKPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x63D72D0", Offset = "0x63D5AD0", VA = "0x1863D72D0")]
	private Func<CancellationToken, List<Task>> MCKFJFBANCM(NKCNOMEENDM HCADKDIKPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x63D64E0", Offset = "0x63D4CE0", VA = "0x1863D64E0")]
	private List<Task> BGCFCBEEBCC(NKCNOMEENDM HCADKDIKPMA, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x63D6950", Offset = "0x63D5150", VA = "0x1863D6950")]
	[AsyncStateMachine(typeof(CCBKEGFNBOH))]
	private Task CHNBINBLOGO(COIKDGIFMGF JGEDAGPGKBM, NKCNOMEENDM FCHBDAMJEHN, CancellationToken JECMOKMEJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x63D6EC0", Offset = "0x63D56C0", VA = "0x1863D6EC0")]
	[AsyncStateMachine(typeof(EMFJKFJIOFL))]
	private Task GOHEBDALBJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x63D6D50", Offset = "0x63D5550", VA = "0x1863D6D50")]
	private void GGPHDHEGLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x63D7400", Offset = "0x63D5C00", VA = "0x1863D7400")]
	public BPCOMHANNBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[UnityEngine.Scripting.Preserve]
internal sealed class NGBHDAJHHIA : ONBCPOOPKHA, IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class JBCODLMLGDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JBCODLMLGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6403570", Offset = "0x6401D70", VA = "0x186403570")]
		internal object AMEDNCMLIJB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class IADCGAPKODI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public IADCGAPKODI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x63FF9B0", Offset = "0x63FE1B0", VA = "0x1863FF9B0")]
		internal object CEIOHLINFHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class KMKMADGAAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public KMKMADGAAGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class JHHDLGNHMLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JHHDLGNHMLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6403670", Offset = "0x6401E70", VA = "0x186403670")]
		internal object FACHKNMJEKA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class AMBCPOHMCLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public AMBCPOHMCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x63F2650", Offset = "0x63F0E50", VA = "0x1863F2650")]
		internal object BDHPACLNAKO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly Dictionary<Guid, DAICCAAPEMA> LPOIOLANENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly TimeSpan AIPJJAKGODF;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "9")]
	public void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x640B520", Offset = "0x6409D20", VA = "0x18640B520", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x640B7D0", Offset = "0x6409FD0", VA = "0x18640B7D0", Slot = "4")]
	public OMGAFAPCPKA INCGBOEKEGG(Guid HGCENGMCDHK)
	{
		return default(OMGAFAPCPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x640B530", Offset = "0x6409D30", VA = "0x18640B530", Slot = "5")]
	public bool FMCALLKJEMI(Guid HGCENGMCDHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x640BE40", Offset = "0x640A640", VA = "0x18640BE40", Slot = "6")]
	public bool MOHLGCNNIMC(Guid HGCENGMCDHK, Task GLIIHKJPDHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x640BC40", Offset = "0x640A440", VA = "0x18640BC40", Slot = "7")]
	public bool KOIJPDNPBDL(Guid HGCENGMCDHK, HACEOFOLLHI EEFAEJINOOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x640B760", Offset = "0x6409F60", VA = "0x18640B760", Slot = "8")]
	public Task<(HACEOFOLLHI, Task)> GPCLEBKBBHA(Guid HGCENGMCDHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x640BA00", Offset = "0x640A200", VA = "0x18640BA00")]
	private void IPECJBCLIII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x640C190", Offset = "0x640A990", VA = "0x18640C190")]
	public NGBHDAJHHIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[RecRoom.NoEngine.Common.Preserve]
internal class HLGHALIGFHG : AGAFALABMDK, IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private class CFDFJNOPDOI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private readonly MPLKHMAMHAD GHBONMCFMLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly CancellationTokenSource LFJFOBIGOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public readonly CancellationToken GEFKAGHCNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private bool KDNOHJDGICG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool INDDNGMBDBO;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x63F56E0", Offset = "0x63F3EE0", VA = "0x1863F56E0")]
		public CFDFJNOPDOI(MPLKHMAMHAD GHBONMCFMLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x63F5590", Offset = "0x63F3D90", VA = "0x1863F5590")]
		public void GGPHDHEGLGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x63F5560", Offset = "0x63F3D60", VA = "0x1863F5560", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class NLDBAFIDLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public PFHACEOLJGC disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public NLDBAFIDLPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x640C330", Offset = "0x640AB30", VA = "0x18640C330")]
		internal object NCHDEHLGBMN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct HOOBNBGFFIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public PFHACEOLJGC disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public HLGHALIGFHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x63FF520", Offset = "0x63FDD20", VA = "0x1863FF520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x63FF950", Offset = "0x63FE150", VA = "0x1863FF950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class OOAMMADNDPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public OOAMMADNDPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x64100E0", Offset = "0x640E8E0", VA = "0x1864100E0")]
		internal object LHOLAKCBPOP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct CGLMAFPFDFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public HLGHALIGFHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x63F57F0", Offset = "0x63F3FF0", VA = "0x1863F57F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7EDD10", Offset = "0x7EC510", VA = "0x1807EDD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class NOFKHHLMGDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public MPLKHMAMHAD newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public NOFKHHLMGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x640C3C0", Offset = "0x640ABC0", VA = "0x18640C3C0")]
		internal object HDGCOELGAJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x640C460", Offset = "0x640AC60", VA = "0x18640C460")]
		internal object HHCABFCGDOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x640C4A0", Offset = "0x640ACA0", VA = "0x18640C4A0")]
		internal object JFKFBPADDIL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class JGKHGEOFNKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JGKHGEOFNKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x64035D0", Offset = "0x6401DD0", VA = "0x1864035D0")]
		internal void AKMBCLGPKGM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct HEDNJGLNGOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public MPLKHMAMHAD newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public HLGHALIGFHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public IPAGPBHPJOP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private NOFKHHLMGDK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x63FAAE0", Offset = "0x63F92E0", VA = "0x1863FAAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x63FBAE0", Offset = "0x63FA2E0", VA = "0x1863FBAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly DNJICJAPBOC KIDCMOJGGGC;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly MBHNHPHHFDO.FJNIGHDHEJI CGMOPNCHIDP;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly KPGKPEANGAD COKAAOEBKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private LGLBIEKGAIJ NAIJBMLKBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private CEJNHAIMKDD JBOKIKCLMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private MFLPEJLBJBB NFMOFHCEAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private GKHIKPLJOCM MIIMIMJDOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private FMDDGLKNNGC PNPLNECKMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private long NMNEHMJIPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private CFDFJNOPDOI PAMNOHMILEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private bool IKNMONNNPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private Task KICIFNLNMMC;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private DJPPJKIGHMC DMKFBEHIHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x63FDFD0", Offset = "0x63FC7D0", VA = "0x1863FDFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool MOLEHPNBODO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xAE5CC0", Offset = "0xAE44C0", VA = "0x180AE5CC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x63FE0F0", Offset = "0x63FC8F0", VA = "0x1863FE0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x63FE270", Offset = "0x63FCA70", VA = "0x1863FE270", Slot = "4")]
	public void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x63FE100", Offset = "0x63FC900", VA = "0x1863FE100", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x63FE510", Offset = "0x63FCD10", VA = "0x1863FE510")]
	[AsyncStateMachine(typeof(HOOBNBGFFIK))]
	private Task FMMJJOCNDHN(PFHACEOLJGC MJBKCBPBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x63FEEC0", Offset = "0x63FD6C0", VA = "0x1863FEEC0")]
	private void PMELKJOMHNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x63FEC10", Offset = "0x63FD410", VA = "0x1863FEC10")]
	private void OMEJCKMIMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x63FE8E0", Offset = "0x63FD0E0", VA = "0x1863FE8E0")]
	private void IHPNMCMHBJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x63FEBA0", Offset = "0x63FD3A0", VA = "0x1863FEBA0")]
	private bool LPPNLBMLNMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x63FE020", Offset = "0x63FC820", VA = "0x1863FE020")]
	[AsyncStateMachine(typeof(CGLMAFPFDFP))]
	private void CLKNJMGAOAO(int AHHIAMNNOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x63FE650", Offset = "0x63FCE50", VA = "0x1863FE650")]
	private void GBKHJLGHJLI([Out] IDisposable KHDCIHKDLAG, [Out] IDisposable DCPLBLEFNKJ, [Out] IDisposable GGODIJIOMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x63FEDB0", Offset = "0x63FD5B0", VA = "0x1863FEDB0")]
	private bool PICEFPHMLNN(MPLKHMAMHAD GHBONMCFMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x63FE600", Offset = "0x63FCE00", VA = "0x1863FE600")]
	private void FNGPIDGGPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x63FEA70", Offset = "0x63FD270", VA = "0x1863FEA70")]
	[AsyncStateMachine(typeof(HEDNJGLNGOH))]
	private Task KJJHJIHHAIN(MPLKHMAMHAD GHBONMCFMLM, IPAGPBHPJOP IGCPFPEAMHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x63FF450", Offset = "0x63FDC50", VA = "0x1863FF450")]
	public HLGHALIGFHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[UnityEngine.Scripting.Preserve]
internal sealed class JAIJJKOIGFB : PHKMEHELHKE, IPOCNADENOB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct HIJBFKOOOLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public AsyncTaskMethodBuilder<NDCFBNKNGBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public JAIJJKOIGFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter<NDCFBNKNGBO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x63FCE60", Offset = "0x63FB660", VA = "0x1863FCE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x63FD0F0", Offset = "0x63FB8F0", VA = "0x1863FD0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class LJIODEMOMJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public CDCBGIGPIJK message;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public LJIODEMOMJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x64080E0", Offset = "0x64068E0", VA = "0x1864080E0")]
		internal object ACHFCLIHALI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class HOIDODGIGHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public CDCBGIGPIJK messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public HOIDODGIGHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x63FF4C0", Offset = "0x63FDCC0", VA = "0x1863FF4C0")]
		internal object LKHPOKDGKMA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class DOBPIFKIDHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public CDCBGIGPIJK request;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public DOBPIFKIDHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x63F7DE0", Offset = "0x63F65E0", VA = "0x1863F7DE0")]
		internal object JEIPGMBELPI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct GMGGGJBLFNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public CDCBGIGPIJK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public JAIJJKOIGFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<MPFKLGFLPPO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x63F9400", Offset = "0x63F7C00", VA = "0x1863F9400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x63F9D10", Offset = "0x63F8510", VA = "0x1863F9D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class PAJEFLFAPFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public CDCBGIGPIJK operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public PAJEFLFAPFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x64106C0", Offset = "0x640EEC0", VA = "0x1864106C0")]
		internal object NBLLKKJDGCN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct IHFBKNEEBMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public CDCBGIGPIJK operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public JAIJJKOIGFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private ENLDEMGODIF <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<CDCBGIGPIJK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6401330", Offset = "0x63FFB30", VA = "0x186401330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6401EE0", Offset = "0x64006E0", VA = "0x186401EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct KJAKMEOCCLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder<MPFKLGFLPPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public JAIJJKOIGFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public CDCBGIGPIJK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private IHICNCPIPKD.OOHHMKNCBHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private ENLDEMGODIF <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter<CDCBGIGPIJK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6403D50", Offset = "0x6402550", VA = "0x186403D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x6404270", Offset = "0x6402A70", VA = "0x186404270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class CLJFBMHLBLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public MPFKLGFLPPO operation;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public CLJFBMHLBLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x63F69E0", Offset = "0x63F51E0", VA = "0x1863F69E0")]
		internal object PAAAFJPDJGI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct HCHIEPMKILD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public MPFKLGFLPPO operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public JAIJJKOIGFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private FHBHLKGBKLK<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x63F9DA0", Offset = "0x63F85A0", VA = "0x1863F9DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x63FA420", Offset = "0x63F8C20", VA = "0x1863FA420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class LLNLHJBKPFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public CDCBGIGPIJK request;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public LLNLHJBKPFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x64087F0", Offset = "0x6406FF0", VA = "0x1864087F0")]
		internal object EPNEDFMNEMN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class DICFLELMAOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public CDCBGIGPIJK request;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public DICFLELMAOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x63F75E0", Offset = "0x63F5DE0", VA = "0x1863F75E0")]
		internal object DCEBOIBHIJI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private JGKDFFLBMIA OHLLKMLNBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private GHFIBDMAJAD MEKLELNNIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private BJDBCHOFMKL JEKKIHIOPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private FBOMPCMDFLJ GJLGCABGOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private TaskCompletionSource<NDCFBNKNGBO> ONBIEDBPLMG;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6402670", Offset = "0x6400E70", VA = "0x186402670", Slot = "7")]
	public void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6402760", Offset = "0x6400F60", VA = "0x186402760", Slot = "6")]
	[AsyncStateMachine(typeof(HIJBFKOOOLG))]
	public Task<NDCFBNKNGBO> FACCDKEJGIH(CancellationToken PNKGCELIPMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x64022D0", Offset = "0x6400AD0", VA = "0x1864022D0", Slot = "4")]
	public void DPKCIDHMBJD(CDCBGIGPIJK OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6402C30", Offset = "0x6401430", VA = "0x186402C30", Slot = "5")]
	public void LMGLOFGGLDE(CDCBGIGPIJK NKJEIFFCICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6402870", Offset = "0x6401070", VA = "0x186402870")]
	[AsyncStateMachine(typeof(GMGGGJBLFNE))]
	private Task GMMKFAFKKNA(CDCBGIGPIJK KOFJNFGLAFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6402970", Offset = "0x6401170", VA = "0x186402970")]
	[AsyncStateMachine(typeof(IHFBKNEEBMP))]
	private Task HADFNINMLKM(CDCBGIGPIJK HHINFHPDCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6402180", Offset = "0x6400980", VA = "0x186402180")]
	[AsyncStateMachine(typeof(KJAKMEOCCLB))]
	private Task<MPFKLGFLPPO> DBOFMJFLMAF(CDCBGIGPIJK KOFJNFGLAFK, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6402BA0", Offset = "0x64013A0", VA = "0x186402BA0")]
	private ENLDEMGODIF KDICGBELEHM(CDCBGIGPIJK DKLDLKBOBKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6402A80", Offset = "0x6401280", VA = "0x186402A80")]
	[AsyncStateMachine(typeof(HCHIEPMKILD))]
	private Task IPGIHOGIDPP(MPFKLGFLPPO CGOMHOMLHEB, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6402FA0", Offset = "0x64017A0", VA = "0x186402FA0")]
	private MPFKLGFLPPO MIGCFBGJKBD(CDCBGIGPIJK KOFJNFGLAFK, ENLDEMGODIF DJAFFFBJGEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2530750", Offset = "0x252EF50", VA = "0x182530750")]
	private T JCKALKMEOIF<T>(T DOLICEBFIPF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x64031D0", Offset = "0x64019D0", VA = "0x1864031D0")]
	private MPFKLGFLPPO MNEAOOJKPLL(CDCBGIGPIJK KOFJNFGLAFK, ENLDEMGODIF DJAFFFBJGEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public JAIJJKOIGFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[UnityEngine.Scripting.Preserve]
internal sealed class KMJHMEFEBPB : GHFIBDMAJAD, IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class BMHNCDDLEGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public BMHNCDDLEGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x63F4A30", Offset = "0x63F3230", VA = "0x1863F4A30")]
		internal object LGNALJAIIIO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class NFLPBMLOHFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public NFLPBMLOHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x640AD00", Offset = "0x6409500", VA = "0x18640AD00")]
		internal object NECNMOGJBHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private FBOMPCMDFLJ GJLGCABGOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private GGJAJFCIBLE DMAPPLNDPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private PHKMEHELHKE DPHOHOAIEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private ONBCPOOPKHA LPOIOLANENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private FHLPDKLILOI OEJCKHGCGPF;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6404BF0", Offset = "0x64033F0", VA = "0x186404BF0", Slot = "6")]
	public void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6404B40", Offset = "0x6403340", VA = "0x186404B40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6404D60", Offset = "0x6403560", VA = "0x186404D60", Slot = "4")]
	public OMGAFAPCPKA HDGLHLLGMPN(CDCBGIGPIJK JEJHPOCBFNB)
	{
		return default(OMGAFAPCPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6405430", Offset = "0x6403C30", VA = "0x186405430", Slot = "5")]
	public void HMAMBOIKKBL(Guid HGCENGMCDHK, Task GLIIHKJPDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6405BD0", Offset = "0x64043D0", VA = "0x186405BD0")]
	private void JAMDPLOKPCB(byte GKBPPPKCOAB, int MFBGJFAHOLK, object LJJFHAGPGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6405CA0", Offset = "0x64044A0", VA = "0x186405CA0")]
	private void KFPALEHFLCA(IGEAOHLEBBD EMCOMEIJNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6405650", Offset = "0x6403E50", VA = "0x186405650")]
	private void IPDMJJNDHGK(IGEAOHLEBBD EMCOMEIJNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x64046C0", Offset = "0x6402EC0", VA = "0x1864046C0")]
	private void BNFAHKEPHGC(IGEAOHLEBBD EMCOMEIJNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6405970", Offset = "0x6404170", VA = "0x186405970")]
	private HACEOFOLLHI JALLMGEAJKP(CDCBGIGPIJK DKLDLKBOBKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6404910", Offset = "0x6403110", VA = "0x186404910")]
	private void CCKEJGOBPNL(CDCBGIGPIJK HHINFHPDCOO, HACEOFOLLHI EEFAEJINOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6404400", Offset = "0x6402C00", VA = "0x186404400")]
	private bool BCLGOFIFFPK(CDCBGIGPIJK HHINFHPDCOO, HACEOFOLLHI EEFAEJINOOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x64051B0", Offset = "0x64039B0", VA = "0x1864051B0")]
	private bool HLNMLHMPIIJ(CDCBGIGPIJK KNEFIDDIKNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6406270", Offset = "0x6404A70", VA = "0x186406270")]
	private bool LHKIEAEIFBH(byte GKBPPPKCOAB, ExitGames.Client.Photon.Hashtable EMCOMEIJNKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public KMJHMEFEBPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[UnityEngine.Scripting.Preserve]
internal sealed class OHBPDLBPHJH : EOMDHBEAOKF, IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class DDKLOCCPNFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public NDCFBNKNGBO operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public OHBPDLBPHJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public CDCBGIGPIJK roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public DDKLOCCPNFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x63F7130", Offset = "0x63F5930", VA = "0x1863F7130")]
		internal object MIMPPOALBBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x63F7000", Offset = "0x63F5800", VA = "0x1863F7000")]
		internal object BFEKPFNOIGB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct HGIINHKPDMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<HACEOFOLLHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public OHBPDLBPHJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public CDCBGIGPIJK roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private TaskAwaiter<HACEOFOLLHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x63FC710", Offset = "0x63FAF10", VA = "0x1863FC710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x63FCDF0", Offset = "0x63FB5F0", VA = "0x1863FCDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class BIOGMCCCDGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public NDCFBNKNGBO operationType;

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public BIOGMCCCDGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x63F3D30", Offset = "0x63F2530", VA = "0x1863F3D30")]
		internal object LKNBLNIPAMO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class GKPKMOJBPAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public CDCBGIGPIJK request;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public GKPKMOJBPAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x63F9320", Offset = "0x63F7B20", VA = "0x1863F9320")]
		internal object JBOLAHBDBLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x63F92B0", Offset = "0x63F7AB0", VA = "0x1863F92B0")]
		internal object FHBENPLNEGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x63F9390", Offset = "0x63F7B90", VA = "0x1863F9390")]
		internal object JPJHJGJMDGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct EBPMJBPCIBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<HACEOFOLLHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public CDCBGIGPIJK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public OHBPDLBPHJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private GKPKMOJBPAN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private OMGAFAPCPKA <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private HACEOFOLLHI <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter<(HACEOFOLLHI validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x63F7E40", Offset = "0x63F6640", VA = "0x1863F7E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x63F8740", Offset = "0x63F6F40", VA = "0x1863F8740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private FBOMPCMDFLJ GJLGCABGOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private GGJAJFCIBLE DMAPPLNDPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private GHFIBDMAJAD MEKLELNNIBL;

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x640CE80", Offset = "0x640B680", VA = "0x18640CE80", Slot = "5")]
	public void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x640CD60", Offset = "0x640B560", VA = "0x18640CD60", Slot = "4")]
	[AsyncStateMachine(typeof(HGIINHKPDMH))]
	private Task<HACEOFOLLHI> AEFKGIJFPAA(CDCBGIGPIJK DKLDLKBOBKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x640D070", Offset = "0x640B870", VA = "0x18640D070")]
	private bool PJEKJMKFJEA(NDCFBNKNGBO CGNHLHIMGDH, [Out] HACEOFOLLHI MLABNLLFODC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x640CF30", Offset = "0x640B730", VA = "0x18640CF30")]
	[AsyncStateMachine(typeof(EBPMJBPCIBM))]
	private Task<HACEOFOLLHI> NDPGDBOODPJ(CDCBGIGPIJK KOFJNFGLAFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public OHBPDLBPHJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class BCDJNOBCCGA : LAGBFNECIOK, IPOCNADENOB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct JIEHBJOKBAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public AsyncTaskMethodBuilder<MDONEMLENMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public MPLKHMAMHAD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public BCDJNOBCCGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<IKGFEJPGNIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x64036D0", Offset = "0x6401ED0", VA = "0x1864036D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6403B80", Offset = "0x6402380", VA = "0x186403B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class OLADFNBJGGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public OLADFNBJGGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x640E8F0", Offset = "0x640D0F0", VA = "0x18640E8F0")]
		internal object OIDLBHKANLK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct HCOLKAAOACH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<IKGFEJPGNIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public BCDJNOBCCGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public MPLKHMAMHAD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private OLADFNBJGGH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<IKGFEJPGNIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x63FA480", Offset = "0x63F8C80", VA = "0x1863FA480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x63FAA70", Offset = "0x63F9270", VA = "0x1863FAA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class EHODKOPNGCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public EHODKOPNGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x13B6F80", Offset = "0x13B5780", VA = "0x1813B6F80")]
		internal bool MPBBOOMCOKH(LKADGOEJKMM sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private MFLPEJLBJBB NFMOFHCEAPK;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static readonly (LJEPICPLNFE superRoomData, long subRoomDataSaveId) HALGJKOAOOA;

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x63F2950", Offset = "0x63F1150", VA = "0x1863F2950", Slot = "5")]
	public void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x63F2D00", Offset = "0x63F1500", VA = "0x1863F2D00", Slot = "4")]
	[AsyncStateMachine(typeof(JIEHBJOKBAP))]
	public Task<MDONEMLENMD> LFFKIHIDMIC(FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, MPLKHMAMHAD EFGEAIMNMOK, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x63F27F0", Offset = "0x63F0FF0", VA = "0x1863F27F0")]
	[AsyncStateMachine(typeof(HCOLKAAOACH))]
	private Task<IKGFEJPGNIE> DPAGONDOLDH(MPLKHMAMHAD EFGEAIMNMOK, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x63F26B0", Offset = "0x63F0EB0", VA = "0x1863F26B0")]
	private MDONEMLENMD ABFFJHCNHJE(MPLKHMAMHAD EFGEAIMNMOK, IKGFEJPGNIE AHIPEEBEEBE, long DILOHLKKNAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x63F29C0", Offset = "0x63F11C0", VA = "0x1863F29C0")]
	private (LJEPICPLNFE, long) GNDJJHPAGND(MPLKHMAMHAD EFGEAIMNMOK, IKGFEJPGNIE AHIPEEBEEBE, long DILOHLKKNAL)
	{
		return default((LJEPICPLNFE, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public BCDJNOBCCGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal sealed class IFKMOJDMHAP : BJDBCHOFMKL, IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class LNOBLNCMFFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public CDCBGIGPIJK request;

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public LNOBLNCMFFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x6408E10", Offset = "0x6407610", VA = "0x186408E10")]
		internal object HFAGHHDDPPP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct LLEJCMBFMFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<CDCBGIGPIJK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public CDCBGIGPIJK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public IFKMOJDMHAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public ENLDEMGODIF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<CDCBGIGPIJK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x6408140", Offset = "0x6406940", VA = "0x186408140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x6408780", Offset = "0x6406F80", VA = "0x186408780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct OKMOMEBLPFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<CDCBGIGPIJK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public IFKMOJDMHAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public ENLDEMGODIF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private TaskAwaiter<GDGFPGHHEBH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x640E250", Offset = "0x640CA50", VA = "0x18640E250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x640E880", Offset = "0x640D080", VA = "0x18640E880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class JJFIEEHPCDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public CDCBGIGPIJK request;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JJFIEEHPCDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6403BF0", Offset = "0x64023F0", VA = "0x186403BF0")]
		internal object DNHOCLNELJM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct BLFGDNNANOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<CDCBGIGPIJK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public CDCBGIGPIJK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public IFKMOJDMHAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public ENLDEMGODIF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private LBFNNNBNHFN <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private DLHAHPHAAGF <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskAwaiter<GDGFPGHHEBH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x63F3DA0", Offset = "0x63F25A0", VA = "0x1863F3DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x63F49C0", Offset = "0x63F31C0", VA = "0x1863F49C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private FBOMPCMDFLJ GJLGCABGOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private EHFEEEKODIH KAIJCMNIFIM;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private IJFKBIOGJOO LFMALPIIKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x64000D0", Offset = "0x63FE8D0", VA = "0x1864000D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x63FFA10", Offset = "0x63FE210", VA = "0x1863FFA10", Slot = "8")]
	public void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x63FFAA0", Offset = "0x63FE2A0", VA = "0x1863FFAA0", Slot = "4")]
	[AsyncStateMachine(typeof(LLEJCMBFMFB))]
	public Task<CDCBGIGPIJK> FJEPOJIKDDE(CDCBGIGPIJK KOFJNFGLAFK, ENLDEMGODIF DJAFFFBJGEM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x63FFC00", Offset = "0x63FE400", VA = "0x1863FFC00", Slot = "5")]
	[AsyncStateMachine(typeof(OKMOMEBLPFE))]
	public Task<CDCBGIGPIJK> IJOBMBPKDJN(CancellationToken GANAOLJLMGA, ENLDEMGODIF DJAFFFBJGEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x6400190", Offset = "0x63FE990", VA = "0x186400190", Slot = "6")]
	public LEGAMHNOHAM PECODMFMMAH(MPFKLGFLPPO ODAHPMOLINL, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x63FFEA0", Offset = "0x63FE6A0", VA = "0x1863FFEA0", Slot = "7")]
	public LEGAMHNOHAM NACKNBBBPIJ(MPFKLGFLPPO ODAHPMOLINL, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x63FFD40", Offset = "0x63FE540", VA = "0x1863FFD40")]
	[AsyncStateMachine(typeof(BLFGDNNANOM))]
	private Task<CDCBGIGPIJK> LFPEBMMAGHE(CDCBGIGPIJK KOFJNFGLAFK, ENLDEMGODIF DJAFFFBJGEM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2565CA0", Offset = "0x25644A0", VA = "0x182565CA0")]
	private static byte[] MCIAAJELDFJ(CDCBGIGPIJK OLDFIJBKFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public IFKMOJDMHAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[UnityEngine.Scripting.Preserve]
internal sealed class LFELLKMCPDL : GGJAJFCIBLE, IPOCNADENOB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private IJECHOENAHN JOGKBPMKDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private FBOMPCMDFLJ GJLGCABGOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private JGKDFFLBMIA OHLLKMLNBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private KFILGLIIBBP GLDFONPOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private MFLPEJLBJBB NFMOFHCEAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private FMDDGLKNNGC PNPLNECKMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private MDKLFKJDOIN MNAEIPCIBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private GKHIKPLJOCM MIIMIMJDOBA;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private DJPPJKIGHMC DMKFBEHIHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x6407AB0", Offset = "0x64062B0", VA = "0x186407AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private static HACEOFOLLHI KIOICOHGGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x63F8D90", Offset = "0x63F7590", VA = "0x1863F8D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x6407E00", Offset = "0x6406600", VA = "0x186407E00", Slot = "6")]
	public void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6407F70", Offset = "0x6406770", VA = "0x186407F70", Slot = "4")]
	public HACEOFOLLHI GEGGOHOPOKJ(PDJKNJCPPID HMGDBFENEOK, NDCFBNKNGBO JHGFLHMNDIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6407B00", Offset = "0x6406300", VA = "0x186407B00", Slot = "5")]
	public HACEOFOLLHI DLMJKNEADPB(PDJKNJCPPID PKIGHFCGLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x63F8D10", Offset = "0x63F7510", VA = "0x1863F8D10")]
	private static HACEOFOLLHI CFCAHBDCPGF(GAGMMKJLLHM DMEJPDINNBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public LFELLKMCPDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class FFHBJLOIECC : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x63F8CD0", Offset = "0x63F74D0", VA = "0x1863F8CD0")]
	public FFHBJLOIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x5A08600", Offset = "0x5A06E00", VA = "0x185A08600")]
	public FFHBJLOIECC(string OLDFIJBKFKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class NAMMBIOAJLJ : FDAEBAMNBME, IPOCNADENOB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct IGCKJJFPCJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public AsyncTaskMethodBuilder<HACEOFOLLHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public NAMMBIOAJLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public GMPFCCLMDAG autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private FHBHLKGBKLK<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private LMFPNJOPLKO <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter<HACEOFOLLHI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x64003A0", Offset = "0x63FEBA0", VA = "0x1864003A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x6400F30", Offset = "0x63FF730", VA = "0x186400F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct HFBCLMBAFLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public NAMMBIOAJLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x63FBB40", Offset = "0x63FA340", VA = "0x1863FBB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x63FC290", Offset = "0x63FAA90", VA = "0x1863FC290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct CCBHBLDMECM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public NAMMBIOAJLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x63F4AA0", Offset = "0x63F32A0", VA = "0x1863F4AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x63F4FB0", Offset = "0x63F37B0", VA = "0x1863F4FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct NFODFJEKANJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public NAMMBIOAJLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x640AD70", Offset = "0x6409570", VA = "0x18640AD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x640B4C0", Offset = "0x6409CC0", VA = "0x18640B4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct DJLIMALKPFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public NAMMBIOAJLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x63F7640", Offset = "0x63F5E40", VA = "0x1863F7640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x63F77E0", Offset = "0x63F5FE0", VA = "0x1863F77E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct OKECEDHFCOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public NAMMBIOAJLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x640DAD0", Offset = "0x640C2D0", VA = "0x18640DAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x640E1F0", Offset = "0x640C9F0", VA = "0x18640E1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct PCGAFNGEPFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public NAMMBIOAJLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6410720", Offset = "0x640EF20", VA = "0x186410720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6410B90", Offset = "0x640F390", VA = "0x186410B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct DDGDPFNAGHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public NAMMBIOAJLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public KJDIKEMCNIP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private FHBHLKGBKLK<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x63F6A60", Offset = "0x63F5260", VA = "0x1863F6A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x63F6FA0", Offset = "0x63F57A0", VA = "0x1863F6FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private FBOMPCMDFLJ GJLGCABGOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private MFLPEJLBJBB NFMOFHCEAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private BJDBCHOFMKL JEKKIHIOPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private JGKDFFLBMIA OHLLKMLNBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private MDKLFKJDOIN MNAEIPCIBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private CancellationTokenSource FFLMNNEACPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private Task FBNFCHPGNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private TaskCompletionSource<int> MOCCOINFCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private int LIDHCFNOCNC;

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x6409D90", Offset = "0x6408590", VA = "0x186409D90", Slot = "6")]
	public void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x860150", Offset = "0x85E950", VA = "0x180860150", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x640A960", Offset = "0x6409160", VA = "0x18640A960")]
	private void NNMDFIOGMMP(float GAOEDLMHCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x6409F40", Offset = "0x6408740", VA = "0x186409F40", Slot = "4")]
	[AsyncStateMachine(typeof(IGCKJJFPCJD))]
	public Task<HACEOFOLLHI> EDNDINJHAHI(GMPFCCLMDAG FKGBPLGHMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x640A660", Offset = "0x6408E60", VA = "0x18640A660", Slot = "5")]
	[AsyncStateMachine(typeof(HFBCLMBAFLB))]
	public Task NCKIGBLFJPO([Optional] CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x860150", Offset = "0x85E950", VA = "0x180860150")]
	public void CLNOBMDNDML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x640A400", Offset = "0x6408C00", VA = "0x18640A400")]
	private LMFPNJOPLKO IJJAFKGBGLC(GMPFCCLMDAG FKGBPLGHMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x6409CA0", Offset = "0x64084A0", VA = "0x186409CA0")]
	[AsyncStateMachine(typeof(CCBHBLDMECM))]
	private Task DEFGLGGBJIA(NKCNOMEENDM CCHIEENNEGK, CancellationToken LCNDAGMDGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x640A750", Offset = "0x6408F50", VA = "0x18640A750")]
	[AsyncStateMachine(typeof(NFODFJEKANJ))]
	private Task NEHDNIGOOII(CancellationToken LCNDAGMDGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x6409AA0", Offset = "0x64082A0", VA = "0x186409AA0")]
	[AsyncStateMachine(typeof(DJLIMALKPFI))]
	private Task CEJCJADHNGH([Optional] CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x640A570", Offset = "0x6408D70", VA = "0x18640A570")]
	[AsyncStateMachine(typeof(OKECEDHFCOO))]
	private Task JKFEAPCNBKL(CancellationToken LCNDAGMDGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x640A070", Offset = "0x6408870", VA = "0x18640A070")]
	[AsyncStateMachine(typeof(PCGAFNGEPFG))]
	private Task FHIOGEPPFLJ(CancellationToken JGDAGGKLPOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x640A170", Offset = "0x6408970", VA = "0x18640A170")]
	private Task GAGOIHHPHIO(KJDIKEMCNIP NFNANJHMKCJ, CancellationToken LCNDAGMDGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x6409B90", Offset = "0x6408390", VA = "0x186409B90")]
	[AsyncStateMachine(typeof(DDGDPFNAGHL))]
	private Task CHONKBMADME(KJDIKEMCNIP NFNANJHMKCJ, CancellationToken LCNDAGMDGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x640A850", Offset = "0x6409050", VA = "0x18640A850")]
	private bool NLOKOGJFJOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public NAMMBIOAJLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[UnityEngine.Scripting.Preserve]
internal class BHBLINPFAIG : KFILGLIIBBP, IPOCNADENOB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct LNLIOOPAOMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public BHBLINPFAIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private FHBHLKGBKLK<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6408850", Offset = "0x6407050", VA = "0x186408850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6408DB0", Offset = "0x64075B0", VA = "0x186408DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private ENCKFKHFNFN IFBNIECCPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private GGJAJFCIBLE DMAPPLNDPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private BJDBCHOFMKL JEKKIHIOPFL;

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x63F3720", Offset = "0x63F1F20", VA = "0x1863F3720", Slot = "6")]
	public void EBEAKPIECKB(NGLGDOHLABH JKOJLJMCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x63F36D0", Offset = "0x63F1ED0", VA = "0x1863F36D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x63F3A00", Offset = "0x63F2200", VA = "0x1863F3A00", Slot = "5")]
	[AsyncStateMachine(typeof(LNLIOOPAOMD))]
	public Task KLCECHACIEO(string LIAIPLNEAGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x63F3BF0", Offset = "0x63F23F0", VA = "0x1863F3BF0", Slot = "4")]
	public HACEOFOLLHI NLOKOGJFJOA(PDJKNJCPPID HMGDBFENEOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x63F3B00", Offset = "0x63F2300", VA = "0x1863F3B00")]
	private GMLOHEFDFDB MNODJIFOBCK(string LIAIPLNEAGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public BHBLINPFAIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class OIFGBBEGFIK
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x640D6D0", Offset = "0x640BED0", VA = "0x18640D6D0")]
	public static void COCLNDONOOG(PHIPPCBHDOE EFKPBKMFDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x640D9B0", Offset = "0x640C1B0", VA = "0x18640D9B0")]
	internal static void MGCDHMKJKOB(PHIPPCBHDOE EFKPBKMFDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x640D8D0", Offset = "0x640C0D0", VA = "0x18640D8D0")]
	internal static void FCLMMDHOPOF(PHIPPCBHDOE EFKPBKMFDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x640D280", Offset = "0x640BA80", VA = "0x18640D280")]
	internal static void ANPDGILFGFK(PHIPPCBHDOE EFKPBKMFDOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal class ODGGBEPENMB : LHNBGCECNFC<CDCBGIGPIJK>
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class MNFEHGBNKBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public CDCBGIGPIJK message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public MNFEHGBNKBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x6409750", Offset = "0x6407F50", VA = "0x186409750")]
		internal object HMGHHHHBAON()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly ODGGBEPENMB ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x640C710", Offset = "0x640AF10", VA = "0x18640C710")]
	public ExitGames.Client.Photon.Hashtable JMOOMJHDBEG(CDCBGIGPIJK OLDFIJBKFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x640C7A0", Offset = "0x640AFA0", VA = "0x18640C7A0", Slot = "5")]
	protected override void LLJEBJLJCGK(CDCBGIGPIJK OLDFIJBKFKG, IDictionary<object, object> FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x640C4E0", Offset = "0x640ACE0", VA = "0x18640C4E0", Slot = "6")]
	public override CDCBGIGPIJK AEDPLFCAHJC(IDictionary<object, object> FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x640C8D0", Offset = "0x640B0D0", VA = "0x18640C8D0")]
	private static void OHIILDFJLAF(string GDIPGIEADIE, CDCBGIGPIJK OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x640CD20", Offset = "0x640B520", VA = "0x18640CD20")]
	public ODGGBEPENMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x640C9E0", Offset = "0x640B1E0", VA = "0x18640C9E0")]
	[CompilerGenerated]
	internal static string PPELGBCOMKJ(MDONEMLENMD IOHCLNMNKCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class FJDJPHPOMJI
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public static HACEOFOLLHI KIOICOHGGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x63F8D90", Offset = "0x63F7590", VA = "0x1863F8D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x63F8D70", Offset = "0x63F7570", VA = "0x1863F8D70")]
	public static bool DELGLOLEIHN(this HACEOFOLLHI EEFAEJINOOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x63F8D10", Offset = "0x63F7510", VA = "0x1863F8D10")]
	public static HACEOFOLLHI CFCAHBDCPGF(GAGMMKJLLHM LCNJKGEMOPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x63F8DF0", Offset = "0x63F75F0", VA = "0x1863F8DF0")]
	public static HACEOFOLLHI GCJHOPBDEJN(IEnumerable<HACEOFOLLHI> DOCMJFPHAJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x63F8FF0", Offset = "0x63F77F0", VA = "0x1863F8FF0")]
	public static string KNPLLLNNJMD(this HACEOFOLLHI MLABNLLFODC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class DEBIIAGGONB : LICKPOLLCDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public delegate HACEOFOLLHI IJIGLCNMNAB([NotNull] PDJKNJCPPID MOILIHLADPB);

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class EIDCPBEHCLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public PDJKNJCPPID photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public EIDCPBEHCLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5BE7380", Offset = "0x5BE5B80", VA = "0x185BE7380")]
		internal HACEOFOLLHI NPEHODNMHEI(IJIGLCNMNAB v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private bool HDNMPGDBKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	protected readonly HashSet<IJIGLCNMNAB> JHCIFNBFMIN;

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x63F7250", Offset = "0x63F5A50", VA = "0x1863F7250", Slot = "4")]
	public void JEGFLKNDLMM(IJIGLCNMNAB DPLECAFONDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x63F71F0", Offset = "0x63F59F0", VA = "0x1863F71F0", Slot = "5")]
	public void EFOMDELNAPB(IJIGLCNMNAB DPLECAFONDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x63F71A0", Offset = "0x63F59A0", VA = "0x1863F71A0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x63F72B0", Offset = "0x63F5AB0", VA = "0x1863F72B0")]
	protected HACEOFOLLHI MBMBEOEGDLL(PDJKNJCPPID PKIGHFCGLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x63F7550", Offset = "0x63F5D50", VA = "0x1863F7550")]
	protected DEBIIAGGONB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class KKJPGPKNPOP : DEBIIAGGONB, IJECHOENAHN, LICKPOLLCDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class KOKINKCHBAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public HACEOFOLLHI result;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public KOKINKCHBAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x6406510", Offset = "0x6404D10", VA = "0x186406510")]
		internal object LEGAOABNGLF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x64043F0", Offset = "0x6402BF0", VA = "0x1864043F0")]
	[UnityEngine.Scripting.Preserve]
	public KKJPGPKNPOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x64042E0", Offset = "0x6402AE0", VA = "0x1864042E0", Slot = "8")]
	public HACEOFOLLHI IMPGLJILPJB(PDJKNJCPPID PKIGHFCGLKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class PKNHCODOHCF : DEBIIAGGONB, ENCKFKHFNFN, LICKPOLLCDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class GGIKIJCBCEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public HACEOFOLLHI result;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public GGIKIJCBCEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x63F9250", Offset = "0x63F7A50", VA = "0x1863F9250")]
		internal object DHFIBPIKEDA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x64043F0", Offset = "0x6402BF0", VA = "0x1864043F0")]
	[UnityEngine.Scripting.Preserve]
	public PKNHCODOHCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6411680", Offset = "0x640FE80", VA = "0x186411680", Slot = "8")]
	public HACEOFOLLHI NLOKOGJFJOA(PDJKNJCPPID MNBNFIINGLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal static class MHMLOHMBDHA
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class KAJCGHJNELM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public FHBHLKGBKLK<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public KAJCGHJNELM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x6403C50", Offset = "0x6402450", VA = "0x186403C50")]
		internal object LGPHOEBAHGP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6408FF0", Offset = "0x64077F0", VA = "0x186408FF0")]
	public static FHBHLKGBKLK<string> LGKNAMOLIEH(DNJICJAPBOC KIDCMOJGGGC, [Optional] string HMPKMKJPMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6408F30", Offset = "0x6407730", VA = "0x186408F30")]
	public static void IEHLGHJFNOA(FHBHLKGBKLK<string> PFAPIIDDMDA, DNJICJAPBOC KIDCMOJGGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6408E70", Offset = "0x6407670", VA = "0x186408E70")]
	public static string IAICHEHJJIK(CDCBGIGPIJK DKLDLKBOBKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal static class EGMEEEBEKMC
{
	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x63F88E0", Offset = "0x63F70E0", VA = "0x1863F88E0")]
	public static void HKCCJFFNKNP(this FBOMPCMDFLJ GJLGCABGOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x63F88D0", Offset = "0x63F70D0", VA = "0x1863F88D0")]
	public static void BHMGMMOIOOP(this FBOMPCMDFLJ GJLGCABGOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x63F87B0", Offset = "0x63F6FB0", VA = "0x1863F87B0")]
	private static void BFIBLNBPCAK(this FBOMPCMDFLJ GJLGCABGOLK, bool PPBHEAAKNPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class PACLDMJCGPD : BMONNKBBKKL, MNCNKKJLBBN, NLKMEMNLAFE, MLGLJJAJFDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private readonly MNCNKKJLBBN MJBNJIHNHLL;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public PDJKNJCPPID BDBPKPKNPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x6410620", Offset = "0x640EE20", VA = "0x186410620", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public int OKEHNCCFKEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x6410670", Offset = "0x640EE70", VA = "0x186410670", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int NFNPLEDFOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x64102C0", Offset = "0x640EAC0", VA = "0x1864102C0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool EMOEEOPMKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x78D2A0", Offset = "0x78BAA0", VA = "0x18078D2A0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int JDKJBJIGGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x869250", Offset = "0x867A50", VA = "0x180869250", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event IMEGACCGMEK.PDHOALKDPPB FAMJOHFDOBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event NCICOIIMKIA NFJEBGKOEGK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x6410200", Offset = "0x640EA00", VA = "0x186410200", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x6410580", Offset = "0x640ED80", VA = "0x186410580", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> PKMIPFPKOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<PDJKNJCPPID> MJENFFAEKCM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action BNMBHCEADBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x6410310", Offset = "0x640EB10", VA = "0x186410310", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x6410400", Offset = "0x640EC00", VA = "0x186410400", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0xC7DA90", Offset = "0xC7C290", VA = "0x180C7DA90")]
	public PACLDMJCGPD(MNCNKKJLBBN MJBNJIHNHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6410150", Offset = "0x640E950", VA = "0x186410150", Slot = "8")]
	public bool CMEGJIBLFNP(byte GKBPPPKCOAB, ExitGames.Client.Photon.Hashtable PDCCJLNBJPF, EJKNNKHBDKB EIOOCJGFFIA, SendOptions IBKGCFKOBDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x64104A0", Offset = "0x640ECA0", VA = "0x1864104A0", Slot = "16")]
	public PDJKNJCPPID IIGPPKEEPHC(int OBBDABPEFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "19")]
	public void NDPDLKDMFPD(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "20")]
	public void PMPMHDEPEJD(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "21")]
	public void OJPOKLGEPDO(object JECMOKMEJED, bool MLFCCKHAIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x64103B0", Offset = "0x640EBB0", VA = "0x1864103B0", Slot = "22")]
	public IDisposable GJLGLBPEFFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "23")]
	private bool GIEDFLLNNBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "24")]
	public void KFPGEEODODF(StringBuilder OAKKIFHHOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x64102A0", Offset = "0x640EAA0", VA = "0x1864102A0", Slot = "25")]
	public bool FACPKIOCMGE(bool DLFCPMFIIJJ, [Out] string MFCNDEMKIPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xB5DBC0", Offset = "0xB5C3C0", VA = "0x180B5DBC0", Slot = "28")]
	public void MFGMBGMMGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal struct IGEAOHLEBBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private readonly IDictionary<object, object> EMCOMEIJNKO;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x873730", Offset = "0x871F30", VA = "0x180873730")]
	public IGEAOHLEBBD(IDictionary<object, object> EMCOMEIJNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6400FA0", Offset = "0x63FF7A0", VA = "0x186400FA0")]
	public bool BLCODLHLJKF([Out] CDCBGIGPIJK OLDFIJBKFKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6401190", Offset = "0x63FF990", VA = "0x186401190")]
	public Guid KIIAPIMDEDE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6401050", Offset = "0x63FF850", VA = "0x186401050")]
	public HACEOFOLLHI DFDNNDEFJNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6401240", Offset = "0x63FFA40", VA = "0x186401240")]
	public static ExitGames.Client.Photon.Hashtable OEONKPJDENI(CDCBGIGPIJK OLDFIJBKFKG, HACEOFOLLHI EEFAEJINOOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal static class KDAPKCBHAOA
{
	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6403CD0", Offset = "0x64024D0", VA = "0x186403CD0")]
	public static bool DBMGCGKDFKH(this MPLKHMAMHAD FAMNCMCAAPI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal struct NBHHAOHOHCI : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct JAGGPHLOAMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public NBHHAOHOHCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x6401F40", Offset = "0x6400740", VA = "0x186401F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x6402120", Offset = "0x6400920", VA = "0x186402120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private readonly CancellationTokenSource LFJFOBIGOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private bool HDNMPGDBKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private Task KONAOGGENMJ;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool AFICHJEBJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x640AA40", Offset = "0x6409240", VA = "0x18640AA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x640ABD0", Offset = "0x64093D0", VA = "0x18640ABD0")]
	public NBHHAOHOHCI(CancellationToken GANAOLJLMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x640AAC0", Offset = "0x64092C0", VA = "0x18640AAC0")]
	[AsyncStateMachine(typeof(JAGGPHLOAMJ))]
	public Task IDMOKBPHMPH(Func<CancellationToken, List<Task>> LLOHMLPPOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x640AA70", Offset = "0x6409270", VA = "0x18640AA70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public readonly struct IOIAEMALEDF<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct OGFMPGLNNLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder<LBFOJMHFNLD<KINNJCBMFJP<TData>, CLJHHCKGBLK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public FHBHLKGBKLK<string>.CAOEJONIOII timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public IOIAEMALEDF<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private TaskAwaiter<LBFOJMHFNLD<byte[], CLJHHCKGBLK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x3E0FCE0", Offset = "0x3E0E4E0", VA = "0x183E0FCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x3E116E0", Offset = "0x3E0FEE0", VA = "0x183E116E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private readonly FBNCEFDBDGE<TGetDataArg, TData> LPEEHBCIPOH;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x873730", Offset = "0x871F30", VA = "0x180873730")]
	internal IOIAEMALEDF(FBNCEFDBDGE<TGetDataArg, TData> JFHMOFHDJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x36C7B20", Offset = "0x36C6320", VA = "0x1836C7B20")]
	[AsyncStateMachine(typeof(IOIAEMALEDF<, >.OGFMPGLNNLK))]
	public Task<LBFOJMHFNLD<KINNJCBMFJP<TData>, CLJHHCKGBLK>> DDIAGLOFOPE(TGetDataArg AKIAGKECAIA, string IKGHJDPMONI, FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class PIAOEGLBBPP
{
	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x24DABF0", Offset = "0x24D93F0", VA = "0x1824DABF0")]
	public static IOIAEMALEDF<TGetDataArg, TData> AKKFLOCCMNP<TGetDataArg, TData>(FBNCEFDBDGE<TGetDataArg, TData> JFHMOFHDJOF)
	{
		return default(IOIAEMALEDF<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct NGFNOMHKLFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public readonly int MBFCLMPFMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public readonly int? AIGNBDMEICE;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x39CDDD0", Offset = "0x39CC5D0", VA = "0x1839CDDD0")]
	public NGFNOMHKLFB(int CNEDHPANOLF, [Optional] int? OHIIBMIAGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x640C250", Offset = "0x640AA50", VA = "0x18640C250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface FOCAHGJDFLB<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOPMMBDMJJF();

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FOCAHGJDFLB<T> MHFHNDMMKFF(string IMOHDDFOBNB);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FOCAHGJDFLB<T> OBAJBPNGMKK(CPDPNFBCJHD<T> DHBFOOLJOFM);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FOCAHGJDFLB<T> EPDDINPBELK(int PIKNFMIHJEE);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FOCAHGJDFLB<T> ECJDOKCKPEI(int PIKNFMIHJEE, GONPJMKHOJH<T> DNGBIBLCNHA);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface MGDEIDEPHGI
{
	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FOCAHGJDFLB<T> LNPBNJPCMFP<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ENIINDFPOMO GAMDBGMAAIE(Exception IOPFKNIOMEG);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NGFNOMHKLFB MEHNCDAKGCG(Exception IOPFKNIOMEG);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public delegate string CPDPNFBCJHD<in T>(T IOPFKNIOMEG) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate int GONPJMKHOJH<in T>(T IOPFKNIOMEG) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class ONADLOPEKHJ : MGDEIDEPHGI
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private delegate string MCILAPMACHM(Exception IOPFKNIOMEG);

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate int OIDJMOLAOMG(Exception IOPFKNIOMEG);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private class JHFLIFMJCGO<T> : FOCAHGJDFLB<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class BKHMEFAIBLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public BKHMEFAIBLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
			internal string DGLMOPIPNGN(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class DKCJBIIKJGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public CPDPNFBCJHD<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public DKCJBIIKJGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x36B8130", Offset = "0x36B6930", VA = "0x1836B8130")]
			internal string LGIEBAACAGN(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class IGNNMMBDMEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public GONPJMKHOJH<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public IGNNMMBDMEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x36B8130", Offset = "0x36B6930", VA = "0x1836B8130")]
			internal int AHDONBNMNMD(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly ONADLOPEKHJ DLGNCINAPDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private readonly Type NLHABGGNEKK;

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x3890310", Offset = "0x388EB10", VA = "0x183890310")]
		internal JHFLIFMJCGO(ONADLOPEKHJ DLGNCINAPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x388FF60", Offset = "0x388E760", VA = "0x18388FF60", Slot = "4")]
		public void AOPMMBDMJJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x38900F0", Offset = "0x388E8F0", VA = "0x1838900F0", Slot = "5")]
		public FOCAHGJDFLB<T> MHFHNDMMKFF(string IMOHDDFOBNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x3890200", Offset = "0x388EA00", VA = "0x183890200", Slot = "6")]
		public FOCAHGJDFLB<T> OBAJBPNGMKK(CPDPNFBCJHD<T> DHBFOOLJOFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x38900B0", Offset = "0x388E8B0", VA = "0x1838900B0", Slot = "7")]
		public FOCAHGJDFLB<T> EPDDINPBELK(int PIKNFMIHJEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x388FF90", Offset = "0x388E790", VA = "0x18388FF90", Slot = "8")]
		public FOCAHGJDFLB<T> ECJDOKCKPEI(int PIKNFMIHJEE, GONPJMKHOJH<T> DNGBIBLCNHA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class PFEMACOCPOL<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private bool HHAGGJJMCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private readonly List<Type> KFKOBJJGLIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private readonly Dictionary<Type, TVal> OBPCMOIGGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private readonly Dictionary<Type, int> LFILDLGLLHE;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public IReadOnlyList<Type> PEFPIKGDECA
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x3EF1DE0", Offset = "0x3EF05E0", VA = "0x183EF1DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x3EF21F0", Offset = "0x3EF09F0", VA = "0x183EF21F0")]
		public PFEMACOCPOL(Dictionary<Type, int> LFILDLGLLHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x3EF2000", Offset = "0x3EF0800", VA = "0x183EF2000")]
		public void INCGBOEKEGG(Type EMBEECDJLJB, TVal IDCGMKDPLPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x3EF1DA0", Offset = "0x3EF05A0", VA = "0x183EF1DA0")]
		public bool CJMOEAINBIO(Type NLHABGGNEKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x3EF20A0", Offset = "0x3EF08A0", VA = "0x183EF20A0")]
		public bool PNHOCBOGFHC(TVal DOLICEBFIPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x3EF1C20", Offset = "0x3EF0420", VA = "0x183EF1C20")]
		public TVal BGCBNLKDELI(Type HJNJPNKDEFH)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF1D00", Offset = "0x3EF0500", VA = "0x183EF1D00")]
		[CompilerGenerated]
		private int BHMEJMLLFHB(Type CKJACCLMNIE, Type OHPDCGGJPDF)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class PFIHABOCHAJ : IEnumerable<NGFNOMHKLFB>, IEnumerable, IEnumerator<NGFNOMHKLFB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private NGFNOMHKLFB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public ONADLOPEKHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private IEnumerator<NGFNOMHKLFB> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private NGFNOMHKLFB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x317C2E0", Offset = "0x317AAE0", VA = "0x18317C2E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(NGFNOMHKLFB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x64112C0", Offset = "0x640FAC0", VA = "0x1864112C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x8F6270", Offset = "0x8F4A70", VA = "0x1808F6270")]
		[DebuggerHidden]
		public PFIHABOCHAJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x6411310", Offset = "0x640FB10", VA = "0x186411310", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x6410CB0", Offset = "0x640F4B0", VA = "0x186410CB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x6410C60", Offset = "0x640F460", VA = "0x186410C60")]
		private void JLELDKFKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6411160", Offset = "0x640F960", VA = "0x186411160")]
		private void PHMELMLAGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6411270", Offset = "0x640FA70", VA = "0x186411270", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x64111B0", Offset = "0x640F9B0", VA = "0x1864111B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NGFNOMHKLFB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x64111B0", Offset = "0x640F9B0", VA = "0x1864111B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private static readonly NGFNOMHKLFB NFEMLCPMEGL;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private static readonly Dictionary<Type, int> JHOKBHHIHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private readonly HashSet<Type> KNGIJBFGGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private readonly PFEMACOCPOL<int> PMKJDFJMNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly PFEMACOCPOL<OIDJMOLAOMG> ANNKMMLACAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly PFEMACOCPOL<MCILAPMACHM> MGFNANBFJDP;

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x640F2C0", Offset = "0x640DAC0", VA = "0x18640F2C0")]
	[IOOPNJKFHOG(FICJCHGEBPC.GameOnly)]
	private static void IEHGJHACKNO(PHIPPCBHDOE OFJPADAKEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x640FDA0", Offset = "0x640E5A0", VA = "0x18640FDA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public ONADLOPEKHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2509FE0", Offset = "0x25087E0", VA = "0x182509FE0", Slot = "4")]
	public FOCAHGJDFLB<T> LNPBNJPCMFP<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x640F230", Offset = "0x640DA30", VA = "0x18640F230", Slot = "5")]
	public ENIINDFPOMO GAMDBGMAAIE(Exception IOPFKNIOMEG)
	{
		return default(ENIINDFPOMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x640F330", Offset = "0x640DB30", VA = "0x18640F330", Slot = "6")]
	public NGFNOMHKLFB MEHNCDAKGCG(Exception? IOPFKNIOMEG)
	{
		return default(NGFNOMHKLFB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x640E9A0", Offset = "0x640D1A0", VA = "0x18640E9A0", Slot = "7")]
	[IteratorStateMachine(typeof(PFIHABOCHAJ))]
	public IEnumerable<NGFNOMHKLFB> ACBEJIAHOKM(Exception IOPFKNIOMEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x640EA40", Offset = "0x640D240", VA = "0x18640EA40", Slot = "8")]
	public string BCINPHGGHBP(Exception? IOPFKNIOMEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x640F530", Offset = "0x640DD30", VA = "0x18640F530")]
	private string NDCAAONMBHE(AggregateException FCFOLLALFEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x640F840", Offset = "0x640E040", VA = "0x18640F840")]
	private void NMKJGPCLPPO(Type NLHABGGNEKK, int PIKNFMIHJEE, OIDJMOLAOMG? MAKODIDEHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x640EFE0", Offset = "0x640D7E0", VA = "0x18640EFE0")]
	private void BPCDLNIKCHB(Type NLHABGGNEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x640ED10", Offset = "0x640D510", VA = "0x18640ED10")]
	private void BLKCMJILLMN(Type NLHABGGNEKK, MCILAPMACHM GCBMKHBJJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x640EB90", Offset = "0x640D390", VA = "0x18640EB90")]
	private static int BHNGOLOJNJC(Type NLHABGGNEKK, Dictionary<Type, int> LFILDLGLLHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2650280", Offset = "0x264EA80", VA = "0x182650280")]
	private static bool PABIPOCBBPL<TVal>(PFEMACOCPOL<TVal> JCBAGKALIOD, Type NLHABGGNEKK, [Out] TVal DOLICEBFIPF) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x640FBF0", Offset = "0x640E3F0", VA = "0x18640FBF0")]
	[CompilerGenerated]
	internal static int PGDNFLGAAPG(Type ODODABFNIEG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public struct ENIINDFPOMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public readonly NGFNOMHKLFB GJGFPCBNLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public readonly string DGOODHCAFLD;

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x63F8CB0", Offset = "0x63F74B0", VA = "0x1863F8CB0")]
	public ENIINDFPOMO(string HIFPLONNMGB, NGFNOMHKLFB PIKNFMIHJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x63F8C10", Offset = "0x63F7410", VA = "0x1863F8C10")]
	public string IFKBOCDPECF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class HJJOGJKLCEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private readonly KMGFKBEAAGE AFOONKOPKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private string JCKGNEBCILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private long? OECNBMLGOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private long? AENEFHPANMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private long? OMMIKKPNOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private string LKDEEPEPFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private JGJBELIGIKL FGHCKKADDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private long? HKJJFILMLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private bool EGLFCLAJLME;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public string PNIGLOAOCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public long DJEJNJCGINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x63FD5E0", Offset = "0x63FBDE0", VA = "0x1863FD5E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public long LFJBPHGHJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x63FD200", Offset = "0x63FBA00", VA = "0x1863FD200")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public long FLPIENFGLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x63FD160", Offset = "0x63FB960", VA = "0x1863FD160")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public string NAFNHKCFMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x63FD1C0", Offset = "0x63FB9C0", VA = "0x1863FD1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public JGJBELIGIKL GIGBJHACAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xCDA880", Offset = "0xCD9080", VA = "0x180CDA880")]
		get
		{
			return default(JGJBELIGIKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x63FDEA0", Offset = "0x63FC6A0", VA = "0x1863FDEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public long KELEEPNLDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x63FD640", Offset = "0x63FBE40", VA = "0x1863FD640")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x63FDF90", Offset = "0x63FC790", VA = "0x1863FDF90")]
	[UnityEngine.Scripting.Preserve]
	public HJJOGJKLCEL([NBBCAEDCKMG(null)] KMGFKBEAAGE AFOONKOPKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x63FDB30", Offset = "0x63FC330", VA = "0x1863FDB30")]
	private void MFEGLAGEGNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x63FD6A0", Offset = "0x63FBEA0", VA = "0x1863FD6A0")]
	public void LKJKODHGHBK(long AKDANPAICOC, long DILOHLKKNAL, [Optional] long? GPPJMLIGEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x63FDD80", Offset = "0x63FC580", VA = "0x1863FDD80")]
	public void NDNMBKMBJPN(long GPPJMLIGEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x63FDE20", Offset = "0x63FC620", VA = "0x1863FDE20")]
	public void OOIEHPGFNEA(string OCKAHBFMGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x63FD260", Offset = "0x63FBA60", VA = "0x1863FD260")]
	public void IKCKEIEPFHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class LEGAMHNOHAM : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct DNOOJCELEND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public AsyncTaskMethodBuilder<CDCBGIGPIJK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public CDCBGIGPIJK roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public LEGAMHNOHAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private TaskAwaiter<IJFKBIOGJOO.FLIDAHGDNMG<CDCBGIGPIJK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x63F7840", Offset = "0x63F6040", VA = "0x1863F7840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x63F7D70", Offset = "0x63F6570", VA = "0x1863F7D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct CGKLJIACBKL<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private sealed class BHNMIBDHPFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public CDCBGIGPIJK roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public BHNMIBDHPFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x63F3C50", Offset = "0x63F2450", VA = "0x1863F3C50")]
		internal CDCBGIGPIJK EDFHMEGPEOP(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct MKJMALIADHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public AsyncTaskMethodBuilder<IJFKBIOGJOO.FLIDAHGDNMG<CDCBGIGPIJK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public CDCBGIGPIJK roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public LEGAMHNOHAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private LBFNNNBNHFN <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private TaskAwaiter<IJFKBIOGJOO.FLIDAHGDNMG<CDCBGIGPIJK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x64090D0", Offset = "0x64078D0", VA = "0x1864090D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x64096E0", Offset = "0x6407EE0", VA = "0x1864096E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct KOCFJGPLIBJ<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public LEGAMHNOHAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x3974910", Offset = "0x3973110", VA = "0x183974910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x30F69A0", Offset = "0x30F51A0", VA = "0x1830F69A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct PFPEDAJOJIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public LEGAMHNOHAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x6411460", Offset = "0x640FC60", VA = "0x186411460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x6411620", Offset = "0x640FE20", VA = "0x186411620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class CDPFBEDBCPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public CDPFBEDBCPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x63F5500", Offset = "0x63F3D00", VA = "0x1863F5500")]
		internal object HKPGNFIGGPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x63F5440", Offset = "0x63F3C40", VA = "0x1863F5440")]
		internal bool APBCGBEDELN(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class CFJDKKAHPLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public CFJDKKAHPLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x63F5790", Offset = "0x63F3F90", VA = "0x1863F5790")]
		internal object FNONMBPKHJJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class PDJHAKPBFOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public PDJHAKPBFOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x6410BF0", Offset = "0x640F3F0", VA = "0x186410BF0")]
		internal object BCPCJKAHGOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class AGEDAEEFLCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public AGEDAEEFLCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x63F25E0", Offset = "0x63F0DE0", VA = "0x1863F25E0")]
		internal object FCLDAHIFFMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class LEOLPBMLCJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public LEGAMHNOHAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public LEOLPBMLCJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x6407870", Offset = "0x6406070", VA = "0x186407870")]
		internal object HMGHHHHBAON()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private static readonly Guid LCOKAOMBGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public readonly MPFKLGFLPPO FLGMPCIKGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private readonly IJFKBIOGJOO AHLMJEFJIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly NLKMEMNLAFE GJLGCABGOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly MLGLJJAJFDI JBPCMCLICEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private bool DAFOIPCDBGG;

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6407640", Offset = "0x6405E40", VA = "0x186407640")]
	public LEGAMHNOHAM(MPFKLGFLPPO CGOMHOMLHEB, IJFKBIOGJOO AHLMJEFJIJI, NLKMEMNLAFE GJLGCABGOLK, MLGLJJAJFDI JBPCMCLICEH, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x6406680", Offset = "0x6404E80", VA = "0x186406680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x6406680", Offset = "0x6404E80", VA = "0x186406680")]
	public void BFCJKNGMLCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x6406C60", Offset = "0x6405460", VA = "0x186406C60")]
	public void IFAJFJJALHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6406BA0", Offset = "0x64053A0", VA = "0x186406BA0")]
	public void IDDBBNPCDLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6406E70", Offset = "0x6405670", VA = "0x186406E70")]
	[AsyncStateMachine(typeof(DNOOJCELEND))]
	internal Task<CDCBGIGPIJK> IKMAPKNIKPN(FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CDCBGIGPIJK DKLDLKBOBKK, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x2565CA0", Offset = "0x25644A0", VA = "0x182565CA0")]
	private static byte[] BDOLBBCLMPP<T>(T OLDFIJBKFKG) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x2565CB0", Offset = "0x25644B0", VA = "0x182565CB0")]
	private static T HAHKEFALJDC<T>(MessageParser<T> KLMLLDJNBHH, byte[] OLDFIJBKFKG, T MKLOMBGFNAM) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6406A60", Offset = "0x6405260", VA = "0x186406A60")]
	[AsyncStateMachine(typeof(MKJMALIADHI))]
	private Task<IJFKBIOGJOO.FLIDAHGDNMG<CDCBGIGPIJK>> FFMEDONPAKP(CDCBGIGPIJK DKLDLKBOBKK, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x25661A0", Offset = "0x25649A0", VA = "0x1825661A0")]
	[AsyncStateMachine(typeof(KOCFJGPLIBJ<>))]
	internal Task<T> MNIJCFMANPE<T>(CancellationToken LCNDAGMDGPL, Func<CancellationToken, Task<T>> NPBJKPKLBIC, int HMOEOBKFFJG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x64070E0", Offset = "0x64058E0", VA = "0x1864070E0")]
	[AsyncStateMachine(typeof(PFPEDAJOJIB))]
	internal Task MNIJCFMANPE(CancellationToken LCNDAGMDGPL, Func<CancellationToken, Task> NPBJKPKLBIC, int HMOEOBKFFJG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6407290", Offset = "0x6405A90", VA = "0x186407290")]
	public GPGKAHJABEC NLKHILPFJOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6407210", Offset = "0x6405A10", VA = "0x186407210")]
	public OHFBJMNNBFP NFJGPCPINBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x6406D20", Offset = "0x6405520", VA = "0x186406D20")]
	public FACKGFEHHCH IGILEGDDGFH([Optional] DNJICJAPBOC? KIDCMOJGGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6407310", Offset = "0x6405B10", VA = "0x186407310")]
	public void OAMHKPCHFEI(Func<Guid, bool> FBLEBPFCIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6406FD0", Offset = "0x64057D0", VA = "0x186406FD0")]
	public void LLHHHIHMKPK(Func<Guid, bool> HBCMFJBEOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x64067A0", Offset = "0x6404FA0", VA = "0x1864067A0")]
	public Guid CBIPMAHGOJL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x6406570", Offset = "0x6404D70", VA = "0x186406570")]
	public void ACLECFBCGCI(Guid KHCHAGFCLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x6406920", Offset = "0x6405120", VA = "0x186406920")]
	public void DFKKLHBGNDL(CDCBGIGPIJK BAPPABFCMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x64074C0", Offset = "0x6405CC0", VA = "0x1864074C0")]
	public void OHIILDFJLAF(string PFENAFHMLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2565E00", Offset = "0x2564600", VA = "0x182565E00")]
	private T JCKALKMEOIF<T>(T DOLICEBFIPF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6407470", Offset = "0x6405C70", VA = "0x186407470")]
	public void OCLHMCCCNMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2565EF0", Offset = "0x25646F0", VA = "0x182565EF0")]
	[CompilerGenerated]
	internal static string KPJDOIBMAAM<T>(byte[] OCKHPPLPLMN, int BFJEEHIDFEO, CGKLJIACBKL<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal sealed class BEMBAIPBAIJ : MPFKLGFLPPO
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class IMCFAMDMDOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public IMCFAMDMDOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x641E940", Offset = "0x641D140", VA = "0x18641E940")]
		internal object KBIKAAMEJFK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private struct FGFAMOFBGIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public BEMBAIPBAIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public LEGAMHNOHAM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private DPEHCBMLNGE <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private OHFBJMNNBFP <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x6419000", Offset = "0x6417800", VA = "0x186419000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x64197E0", Offset = "0x6417FE0", VA = "0x1864197E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct JNDIHAKNDOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public BEMBAIPBAIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private TaskAwaiter<IKGFEJPGNIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x641FA30", Offset = "0x641E230", VA = "0x18641FA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x64200D0", Offset = "0x641E8D0", VA = "0x1864200D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct NHFGMLOMJNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public BEMBAIPBAIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private TaskAwaiter<FEAFPIIILAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x6425040", Offset = "0x6423840", VA = "0x186425040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x6425360", Offset = "0x6423B60", VA = "0x186425360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class EKMBPLBDJIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public DPEHCBMLNGE presence;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public EKMBPLBDJIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x6416820", Offset = "0x6415020", VA = "0x186416820")]
		internal object EINGOHKAKLP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static readonly DNJICJAPBOC KIDCMOJGGGC;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly DNJICJAPBOC CGJBNFHKICF;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly DNJICJAPBOC PKIJJBMAFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private readonly MDONEMLENMD IFIMLDHIAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private readonly MPLKHMAMHAD JOLGKJAGAJF;

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x63F3540", Offset = "0x63F1D40", VA = "0x1863F3540")]
	public BEMBAIPBAIJ(MDONEMLENMD IFIMLDHIAJE, MPLKHMAMHAD JOLGKJAGAJF, Guid HGCENGMCDHK, NGLGDOHLABH JKOJLJMCFCA, ENLDEMGODIF JEIEFDFLMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x63F3210", Offset = "0x63F1A10", VA = "0x1863F3210", Slot = "7")]
	[AsyncStateMachine(typeof(FGFAMOFBGIA))]
	protected override Task MKAMGJMJEKO(LEGAMHNOHAM ABKLOKKPJKM, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x63F2F30", Offset = "0x63F1730", VA = "0x1863F2F30")]
	[AsyncStateMachine(typeof(JNDIHAKNDOB))]
	private Task JFINLHFCLGM(CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x63F3350", Offset = "0x63F1B50", VA = "0x1863F3350")]
	[AsyncStateMachine(typeof(NHFGMLOMJNE))]
	private Task<byte> PCBJOLDAONN(CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x63F3030", Offset = "0x63F1830", VA = "0x1863F3030")]
	private DPEHCBMLNGE KCKAEJLCGPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class LMFPNJOPLKO : MPFKLGFLPPO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct GFIFCOGKHLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public LMFPNJOPLKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public LEGAMHNOHAM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private TaskAwaiter<DBLJMINNAMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x641AB30", Offset = "0x6419330", VA = "0x18641AB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x641B4B0", Offset = "0x6419CB0", VA = "0x18641B4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private readonly int NPEDPJEDHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private readonly GMPFCCLMDAG JLDOKOHKLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public readonly long BIGMFDGONPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public readonly long DMPPBFNFENM;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public DBLJMINNAMP KJNIDKLNLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x777280", Offset = "0x775A80", VA = "0x180777280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x777160", Offset = "0x775960", VA = "0x180777160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x64221F0", Offset = "0x64209F0", VA = "0x1864221F0")]
	public LMFPNJOPLKO(Guid HGCENGMCDHK, NGLGDOHLABH JKOJLJMCFCA, ENLDEMGODIF JEIEFDFLMCF, int NPEDPJEDHHL, GMPFCCLMDAG JLDOKOHKLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x64220D0", Offset = "0x64208D0", VA = "0x1864220D0", Slot = "7")]
	[AsyncStateMachine(typeof(GFIFCOGKHLI))]
	protected override Task MKAMGJMJEKO(LEGAMHNOHAM ABKLOKKPJKM, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal abstract class JBLIJIHGMIK : MPFKLGFLPPO
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class AHAMHMPOFNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public JBLIJIHGMIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public KHGFECHILNH playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public AHAMHMPOFNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x6412D50", Offset = "0x6411550", VA = "0x186412D50")]
		internal Task EOJBJJGHNHO(FHBHLKGBKLK<string>.CAOEJONIOII postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x6412D90", Offset = "0x6411590", VA = "0x186412D90")]
		internal object HKDLICNFIDO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct PHCBCHBFNOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public JBLIJIHGMIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public LEGAMHNOHAM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private AHAMHMPOFNJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x6427710", Offset = "0x6425F10", VA = "0x186427710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x6427ED0", Offset = "0x64266D0", VA = "0x186427ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct ABICHOAMPBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public FHBHLKGBKLK<string>.CAOEJONIOII timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public KHGFECHILNH playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public JBLIJIHGMIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x64121D0", Offset = "0x64109D0", VA = "0x1864121D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6412760", Offset = "0x6410F60", VA = "0x186412760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x641F3D0", Offset = "0x641DBD0", VA = "0x18641F3D0")]
	public JBLIJIHGMIK(Guid HGCENGMCDHK, NGLGDOHLABH JKOJLJMCFCA, ENLDEMGODIF JEIEFDFLMCF, string IPDMKIMPBBH, DKPFOLLMHMN CGNHLHIMGDH, bool MHIHBGEILPK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x641F150", Offset = "0x641D950", VA = "0x18641F150", Slot = "7")]
	[AsyncStateMachine(typeof(PHCBCHBFNOP))]
	protected override Task MKAMGJMJEKO(LEGAMHNOHAM ABKLOKKPJKM, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task LJGALECMMKO(LEGAMHNOHAM ABKLOKKPJKM, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x641F290", Offset = "0x641DA90", VA = "0x18641F290")]
	[AsyncStateMachine(typeof(ABICHOAMPBH))]
	private Task PAFOPJOOEGF(IDisposable MLCEJFAMGKC, KHGFECHILNH BJJLOIMPOCK, FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class HINBIELOEMP : MPFKLGFLPPO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct LFDEPIPAAAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public HINBIELOEMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public LEGAMHNOHAM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private TaskAwaiter<EFLNKJCLGNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x64209C0", Offset = "0x641F1C0", VA = "0x1864209C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6420F30", Offset = "0x641F730", VA = "0x186420F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	private readonly KJDIKEMCNIP NFNANJHMKCJ;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x641D4F0", Offset = "0x641BCF0", VA = "0x18641D4F0")]
	public HINBIELOEMP(Guid HGCENGMCDHK, NGLGDOHLABH JKOJLJMCFCA, ENLDEMGODIF JEIEFDFLMCF, KJDIKEMCNIP NFNANJHMKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x641D2F0", Offset = "0x641BAF0", VA = "0x18641D2F0", Slot = "6")]
	protected override string GAMJPLLKLHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x641D3D0", Offset = "0x641BBD0", VA = "0x18641D3D0", Slot = "7")]
	[AsyncStateMachine(typeof(LFDEPIPAAAI))]
	protected override Task MKAMGJMJEKO(LEGAMHNOHAM ABKLOKKPJKM, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class MPFKLGFLPPO : AABILMCHNAC
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public delegate Task NKIGADDAEJK(FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class EGBJJEEFBIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public FHBHLKGBKLK<string>.CAOEJONIOII operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public MPFKLGFLPPO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public EGBJJEEFBIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6416250", Offset = "0x6414A50", VA = "0x186416250")]
		internal Task CBBKJCADPKC(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class ACNCHJPEBEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public EGBJJEEFBIL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public ACNCHJPEBEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x6412880", Offset = "0x6411080", VA = "0x186412880")]
		internal object PIGCFBJGMPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x64127C0", Offset = "0x6410FC0", VA = "0x1864127C0")]
		internal object MEMOJOHAMLJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct FFAOHFCBFLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public MPFKLGFLPPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public Func<MPFKLGFLPPO, FHBHLKGBKLK<string>.CAOEJONIOII, LEGAMHNOHAM> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private EGBJJEEFBIL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private LEGAMHNOHAM <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<CDCBGIGPIJK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6417DA0", Offset = "0x64165A0", VA = "0x186417DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6418FA0", Offset = "0x64177A0", VA = "0x186418FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct GILFBNMKENI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x641B880", Offset = "0x641A080", VA = "0x18641B880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x641C300", Offset = "0x641AB00", VA = "0x18641C300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct GLPHIFMNJIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public MPFKLGFLPPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x641C360", Offset = "0x641AB60", VA = "0x18641C360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x641C6C0", Offset = "0x641AEC0", VA = "0x18641C6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public readonly Guid NDGGCDDLEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly ByteString PGDOFNHMEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public readonly ENLDEMGODIF PGIIGPKLPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	protected readonly string PJPNAPCGABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private readonly bool MHIHBGEILPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly Queue<NKIGADDAEJK> FAOGDMCOMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly ECDOFACJIHE MMMLOGGBLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly DKPFOLLMHMN CGNHLHIMGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private bool EKNHOJJGHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public JGJBELIGIKL JIOAKGKPGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public JGJBELIGIKL KKLMPEFFDLB;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public NGLGDOHLABH BLEONBLAGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x778B40", Offset = "0x777340", VA = "0x180778B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public MFLPEJLBJBB PELEPLGFCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6423200", Offset = "0x6421A00", VA = "0x186423200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public LOMEIBMCEJC PODIJEFIIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x6423340", Offset = "0x6421B40", VA = "0x186423340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public DJPPJKIGHMC DMKFBEHIHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x6422F40", Offset = "0x6421740", VA = "0x186422F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event JDEIGOMEKDB ADPLNPHONGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x6423470", Offset = "0x6421C70", VA = "0x186423470", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x6423450", Offset = "0x6421C50", VA = "0x186423450", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6423780", Offset = "0x6421F80", VA = "0x186423780")]
	protected MPFKLGFLPPO(Guid HGCENGMCDHK, NGLGDOHLABH JKOJLJMCFCA, ENLDEMGODIF JEIEFDFLMCF, string IPDMKIMPBBH, DKPFOLLMHMN CGNHLHIMGDH, bool MHIHBGEILPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6423390", Offset = "0x6421B90", VA = "0x186423390", Slot = "6")]
	protected virtual string GAMJPLLKLHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x64235B0", Offset = "0x6421DB0", VA = "0x1864235B0")]
	public void OJLHOAINDEO(NKIGADDAEJK JGEDAGPGKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6423610", Offset = "0x6421E10", VA = "0x186423610")]
	protected void OPFBNIGEHLH(float NDMBOLPNCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x6423630", Offset = "0x6421E30", VA = "0x186423630")]
	[AsyncStateMachine(typeof(FFAOHFCBFLJ))]
	public Task PODNDBGONHN(CancellationToken GANAOLJLMGA, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, [Optional] Func<MPFKLGFLPPO, FHBHLKGBKLK<string>.CAOEJONIOII, LEGAMHNOHAM> APJBFLADECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6422E10", Offset = "0x6421610", VA = "0x186422E10")]
	[AsyncStateMachine(typeof(GILFBNMKENI))]
	private static Task AACBNONHPJK(Func<CancellationToken, Task> JIBDPGOIPKA, Func<CancellationToken, Task> DBCKCIDFDHF, CancellationToken LCNDAGMDGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x64230B0", Offset = "0x64218B0", VA = "0x1864230B0")]
	private void BLKAFGANEKE(bool DGADJKHCOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x6423250", Offset = "0x6421A50", VA = "0x186423250")]
	private void EBMJEKNAHCP(LEGAMHNOHAM ABKLOKKPJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task MKAMGJMJEKO(LEGAMHNOHAM ABKLOKKPJKM, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x6423490", Offset = "0x6421C90", VA = "0x186423490")]
	[AsyncStateMachine(typeof(GLPHIFMNJIC))]
	private Task LPDELHEBONP(FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x64233D0", Offset = "0x6421BD0", VA = "0x1864233D0")]
	public CDCBGIGPIJK GJNEOKAPGFD(LBFNNNBNHFN GGDCPKJKPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6422FC0", Offset = "0x64217C0", VA = "0x186422FC0")]
	[CompilerGenerated]
	private Task AMFOCKMAHOH(CancellationToken OPLOPEJIHLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
internal sealed class IJIKDICHHLD : JBLIJIHGMIK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct LMCJOGNCLGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public IJIKDICHHLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public LEGAMHNOHAM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private IKHDPBEDCBP <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private OHFBJMNNBFP <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6421690", Offset = "0x641FE90", VA = "0x186421690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x6421E00", Offset = "0x6420600", VA = "0x186421E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly MDONEMLENMD NMPNCAMLMDD;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x641E890", Offset = "0x641D090", VA = "0x18641E890")]
	public IJIKDICHHLD(Guid HGCENGMCDHK, NGLGDOHLABH JKOJLJMCFCA, MDONEMLENMD NMPNCAMLMDD, ENLDEMGODIF JEIEFDFLMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x641E740", Offset = "0x641CF40", VA = "0x18641E740", Slot = "8")]
	[AsyncStateMachine(typeof(LMCJOGNCLGF))]
	protected override Task LJGALECMMKO(LEGAMHNOHAM ABKLOKKPJKM, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
internal class GMLOHEFDFDB : MPFKLGFLPPO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct AFONHLAHIEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public GMLOHEFDFDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public LEGAMHNOHAM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private TaskAwaiter<EFLNKJCLGNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x6412940", Offset = "0x6411140", VA = "0x186412940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6412CF0", Offset = "0x64114F0", VA = "0x186412CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	private readonly string OKDIJDNOGGH;

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x641C830", Offset = "0x641B030", VA = "0x18641C830")]
	public GMLOHEFDFDB(Guid HGCENGMCDHK, NGLGDOHLABH JKOJLJMCFCA, ENLDEMGODIF JEIEFDFLMCF, string OKDIJDNOGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x641C720", Offset = "0x641AF20", VA = "0x18641C720", Slot = "7")]
	[AsyncStateMachine(typeof(AFONHLAHIEB))]
	protected override Task MKAMGJMJEKO(LEGAMHNOHAM ABKLOKKPJKM, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal class OGOLGNLPPHC : JBLIJIHGMIK
{
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class GOLJGJLHCFE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public AsyncTaskMethodBuilder<CDCBGIGPIJK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public GOLJGJLHCFE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<EFLNKJCLGNC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			private TaskAwaiter<CDCBGIGPIJK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x642BED0", Offset = "0x642A6D0", VA = "0x18642BED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x642C390", Offset = "0x642AB90", VA = "0x18642C390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public OGOLGNLPPHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public FACKGFEHHCH serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public EMLBGBMHHHE roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public GPGKAHJABEC uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public GMPDBAAEMGG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public GOLJGJLHCFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x641C8E0", Offset = "0x641B0E0", VA = "0x18641C8E0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<CDCBGIGPIJK> MFGNGJDDOOE(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct HOCJEDMLBPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public OGOLGNLPPHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public LEGAMHNOHAM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private GOLJGJLHCFE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private IKHDPBEDCBP <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private OHFBJMNNBFP <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private TaskAwaiter<CDCBGIGPIJK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x641D840", Offset = "0x641C040", VA = "0x18641D840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x641E6E0", Offset = "0x641CEE0", VA = "0x18641E6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private static readonly DNJICJAPBOC KIDCMOJGGGC;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private static readonly DNJICJAPBOC CGJBNFHKICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private readonly int BJMHHJDOGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	[CanBeNull]
	private readonly JNNCDNMFPJN BPFJIMPDFLM;

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x64259E0", Offset = "0x64241E0", VA = "0x1864259E0")]
	public OGOLGNLPPHC(Guid HGCENGMCDHK, NGLGDOHLABH JKOJLJMCFCA, int BJMHHJDOGHA, JNNCDNMFPJN BPFJIMPDFLM, ENLDEMGODIF JEIEFDFLMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6425620", Offset = "0x6423E20", VA = "0x186425620", Slot = "8")]
	[AsyncStateMachine(typeof(HOCJEDMLBPP))]
	protected override Task LJGALECMMKO(LEGAMHNOHAM ABKLOKKPJKM, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x6425520", Offset = "0x6423D20", VA = "0x186425520")]
	private void DODLNNDLLHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x6425760", Offset = "0x6423F60", VA = "0x186425760")]
	private void PDHCHFEHHEK(FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, IKHDPBEDCBP MPAGHDFMNKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal abstract class FOMLOJPKICM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly MPFKLGFLPPO FLGMPCIKGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly LEGAMHNOHAM GMDDOJCPLLL;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public MFLPEJLBJBB PELEPLGFCGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x641AA60", Offset = "0x6419260", VA = "0x18641AA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public DJPPJKIGHMC DMKFBEHIHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x641A9D0", Offset = "0x64191D0", VA = "0x18641A9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x641AAD0", Offset = "0x64192D0", VA = "0x18641AAD0")]
	protected FOMLOJPKICM(LEGAMHNOHAM ABKLOKKPJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x641AAB0", Offset = "0x64192B0", VA = "0x18641AAB0")]
	protected void OHIILDFJLAF(string PFENAFHMLJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal struct CIIEJDCAIMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public Dictionary<Guid, List<KPDECMOJBLE>> EICCPMBOIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public Dictionary<Guid, List<KPDECMOJBLE>> MOODBGOMKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public Dictionary<Guid, List<KPDECMOJBLE>> OCDHJCLEDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public List<Guid> IOECEJGDDGH;

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x6414AA0", Offset = "0x64132A0", VA = "0x186414AA0")]
	public static CIIEJDCAIMA BGCBNLKDELI(MFLPEJLBJBB NFMOFHCEAPK, JGJBELIGIKL BDHILLIJKAH, NKCNOMEENDM LJKBIABPLPJ)
	{
		return default(CIIEJDCAIMA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal struct POBBCDLLIPH
{
	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0")]
	public static POBBCDLLIPH OEONKPJDENI()
	{
		return default(POBBCDLLIPH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct PNIAKBIICLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public readonly IKGFEJPGNIE JLEOAIBABON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly LKADGOEJKMM ADOFHFANKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly string LNCOOBMHJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public readonly LJEPICPLNFE GDEABNLEJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public readonly LJEPICPLNFE EAFNDEMPLNF;

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x6429120", Offset = "0x6427920", VA = "0x186429120")]
	public PNIAKBIICLJ(IKGFEJPGNIE JLEOAIBABON, LKADGOEJKMM ADOFHFANKAL, string LNCOOBMHJOG, LJEPICPLNFE GDEABNLEJPG, LJEPICPLNFE EAFNDEMPLNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct OMBIFFOIJBP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly LEGAMHNOHAM ABKLOKKPJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private readonly Guid KHCHAGFCLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private bool DGADJKHCOBI;

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x6427660", Offset = "0x6425E60", VA = "0x186427660")]
	public static OMBIFFOIJBP CBIPMAHGOJL(LEGAMHNOHAM ABKLOKKPJKM)
	{
		return default(OMBIFFOIJBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x855A00", Offset = "0x854200", VA = "0x180855A00")]
	public void INIKMAKJBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x6427560", Offset = "0x6425D60", VA = "0x186427560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x64276C0", Offset = "0x6425EC0", VA = "0x1864276C0")]
	private OMBIFFOIJBP(LEGAMHNOHAM ABKLOKKPJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x6427560", Offset = "0x6425D60", VA = "0x186427560")]
	private void ACLECFBCGCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x64275C0", Offset = "0x6425DC0", VA = "0x1864275C0")]
	private Func<Guid, bool> BECDNFPMAIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal class OHFBJMNNBFP : FOMLOJPKICM, AABILMCHNAC
{
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	public delegate Task<JGJBELIGIKL> EJBBLGJJDNK(NKCNOMEENDM FCHBDAMJEHN, DGBKKMPLFNE NDDPDFOJKCH, ECDOFACJIHE NLBECEHADAK, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct HIJCDGGCAPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public OHFBJMNNBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public MDONEMLENMD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private OMBIFFOIJBP <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private TaskAwaiter<CDCBGIGPIJK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x641CB20", Offset = "0x641B320", VA = "0x18641CB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x641D290", Offset = "0x641BA90", VA = "0x18641D290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct FHOGEJPAAKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder<CDCBGIGPIJK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public OHFBJMNNBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public MDONEMLENMD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private TaskAwaiter<CDCBGIGPIJK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x6419840", Offset = "0x6418040", VA = "0x186419840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x6419C50", Offset = "0x6418450", VA = "0x186419C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct JFAENKBDIKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public OHFBJMNNBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public MDONEMLENMD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x641F420", Offset = "0x641DC20", VA = "0x18641F420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x641F8B0", Offset = "0x641E0B0", VA = "0x18641F8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class EIKLLOLAHDO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public AsyncTaskMethodBuilder<PNIAKBIICLJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public EIKLLOLAHDO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			private PNIAKBIICLJ <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<JGJBELIGIKL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			private TaskAwaiter<PNIAKBIICLJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x642A540", Offset = "0x6428D40", VA = "0x18642A540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x642ACD0", Offset = "0x64294D0", VA = "0x18642ACD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public AsyncTaskMethodBuilder<NKCNOMEENDM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public EIKLLOLAHDO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			private NKCNOMEENDM <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			private TaskAwaiter<JGJBELIGIKL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			private TaskAwaiter<NKCNOMEENDM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x642AD40", Offset = "0x6429540", VA = "0x18642AD40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x642B390", Offset = "0x6429B90", VA = "0x18642B390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public EIKLLOLAHDO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private TaskAwaiter<JGJBELIGIKL> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			private DGBKKMPLFNE <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x64291A0", Offset = "0x64279A0", VA = "0x1864291A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x642A4E0", Offset = "0x6428CE0", VA = "0x18642A4E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public OHFBJMNNBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public MDONEMLENMD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public ECDOFACJIHE preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public ECDOFACJIHE downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public PNIAKBIICLJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public ECDOFACJIHE postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public NKCNOMEENDM phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public NGNENMBJNCM.HLGHPDPFLFD <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public EIKLLOLAHDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x64165E0", Offset = "0x6414DE0", VA = "0x1864165E0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<PNIAKBIICLJ> MLLKIHFDIHM(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x6416380", Offset = "0x6414B80", VA = "0x186416380")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<NKCNOMEENDM> CMIPOLMBICP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x64165A0", Offset = "0x6414DA0", VA = "0x1864165A0")]
		internal void GEKOLDONGCC(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x64164A0", Offset = "0x6414CA0", VA = "0x1864164A0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task FLKIEHKPKPM(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct NCNKHBEHCEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public OHFBJMNNBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public MDONEMLENMD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private EIKLLOLAHDO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter<PNIAKBIICLJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter<NKCNOMEENDM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x64238E0", Offset = "0x64220E0", VA = "0x1864238E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x64244F0", Offset = "0x6422CF0", VA = "0x1864244F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct IMLIAOFHJJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public OHFBJMNNBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public FHBHLKGBKLK<string>.CAOEJONIOII timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x641E9B0", Offset = "0x641D1B0", VA = "0x18641E9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x641F0F0", Offset = "0x641D8F0", VA = "0x18641F0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct FIABOLBOGJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public OHFBJMNNBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public ECDOFACJIHE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private TaskAwaiter<JGJBELIGIKL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x6419CC0", Offset = "0x64184C0", VA = "0x186419CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x641A620", Offset = "0x6418E20", VA = "0x18641A620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct PLICHDNLAEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public AsyncTaskMethodBuilder<JGJBELIGIKL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public OHFBJMNNBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public ECDOFACJIHE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private TaskAwaiter<JGJBELIGIKL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x6427F30", Offset = "0x6426730", VA = "0x186427F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x64290B0", Offset = "0x64278B0", VA = "0x1864290B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct FELAJNMGFKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public AsyncTaskMethodBuilder<JGJBELIGIKL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public OHFBJMNNBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public ECDOFACJIHE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public DGBKKMPLFNE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private TaskAwaiter<JGJBELIGIKL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6416960", Offset = "0x6415160", VA = "0x186416960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x6417D30", Offset = "0x6416530", VA = "0x186417D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct JOCNEHOOFBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public AsyncTaskMethodBuilder<JGJBELIGIKL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public OHFBJMNNBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public JGJBELIGIKL operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public ECDOFACJIHE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public NKCNOMEENDM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private TaskAwaiter<JGJBELIGIKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x64206C0", Offset = "0x641EEC0", VA = "0x1864206C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x6420950", Offset = "0x641F150", VA = "0x186420950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class GPGCLEEEHHF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012C")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public AsyncTaskMethodBuilder<JGJBELIGIKL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public GPGCLEEEHHF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private TaskAwaiter<JGJBELIGIKL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x642B400", Offset = "0x6429C00", VA = "0x18642B400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x642BA70", Offset = "0x642A270", VA = "0x18642BA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public OHFBJMNNBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public ECDOFACJIHE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public EJBBLGJJDNK masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public DGBKKMPLFNE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public JGJBELIGIKL originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public GPGCLEEEHHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x641CA00", Offset = "0x641B200", VA = "0x18641CA00")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<JGJBELIGIKL> EACDDBALEJA(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct CCNIHIILCAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public AsyncTaskMethodBuilder<JGJBELIGIKL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public OHFBJMNNBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public ECDOFACJIHE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public EJBBLGJJDNK masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public DGBKKMPLFNE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private TaskAwaiter<JGJBELIGIKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x64144F0", Offset = "0x6412CF0", VA = "0x1864144F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x6414A30", Offset = "0x6413230", VA = "0x186414A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct JNEGNKKDEIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public OHFBJMNNBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public ECDOFACJIHE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private JGJBELIGIKL <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private IEnumerator<JGJBELIGIKL> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private TaskAwaiter<JGJBELIGIKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x6420130", Offset = "0x641E930", VA = "0x186420130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6420660", Offset = "0x641EE60", VA = "0x186420660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct GILBFPKPNDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public OHFBJMNNBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x641B510", Offset = "0x6419D10", VA = "0x18641B510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x641B820", Offset = "0x641A020", VA = "0x18641B820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct HNJMDDDOJMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public OHFBJMNNBFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x641D590", Offset = "0x641BD90", VA = "0x18641D590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x641D7E0", Offset = "0x641BFE0", VA = "0x18641D7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly CCHLDLOCDCI DMIBMAPOPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly CCHLDLOCDCI JKNIBOLFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private readonly HJJOGJKLCEL BLACKCPDDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private readonly OKOOEMNBGKJ PJOJIMOPBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly KHNMBHKJNOO GFKHAKHPINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly GBLKFKJHOMM BNNODCGEFFE;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private NGLGDOHLABH BLEONBLAGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x6425AD0", Offset = "0x64242D0", VA = "0x186425AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event JDEIGOMEKDB ADPLNPHONGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x6426BC0", Offset = "0x64253C0", VA = "0x186426BC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x64261F0", Offset = "0x64249F0", VA = "0x1864261F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x64272B0", Offset = "0x6425AB0", VA = "0x1864272B0")]
	public OHFBJMNNBFP(LEGAMHNOHAM ABKLOKKPJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x6426630", Offset = "0x6424E30", VA = "0x186426630")]
	[AsyncStateMachine(typeof(HIJCDGGCAPL))]
	public Task IEPACLEMIJI(MDONEMLENMD KOFJNFGLAFK, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x6426A20", Offset = "0x6425220", VA = "0x186426A20")]
	[AsyncStateMachine(typeof(FHOGEJPAAKI))]
	private Task<CDCBGIGPIJK> JDBHPJHELOM(MDONEMLENMD KOFJNFGLAFK, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x64268E0", Offset = "0x64250E0", VA = "0x1864268E0")]
	[AsyncStateMachine(typeof(JFAENKBDIKE))]
	private Task IJHLCMKPHDL(MDONEMLENMD KOFJNFGLAFK, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x6426E60", Offset = "0x6425660", VA = "0x186426E60")]
	[AsyncStateMachine(typeof(NCNKHBEHCEN))]
	private Task NJPCADBIGOC(MDONEMLENMD KOFJNFGLAFK, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken HDFNENNFENC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x6427180", Offset = "0x6425980", VA = "0x186427180")]
	[AsyncStateMachine(typeof(IMLIAOFHJJE))]
	private Task OOOELIMEMEL(FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x6425F50", Offset = "0x6424750", VA = "0x186425F50")]
	[AsyncStateMachine(typeof(FIABOLBOGJI))]
	private Task EPMPDPEJKMK(NKCNOMEENDM FCHBDAMJEHN, ECDOFACJIHE NLBECEHADAK, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x6426780", Offset = "0x6424F80", VA = "0x186426780")]
	[AsyncStateMachine(typeof(PLICHDNLAEG))]
	private Task<JGJBELIGIKL> IIAEONACJNF(NKCNOMEENDM FCHBDAMJEHN, DGBKKMPLFNE HMAINPNOOAF, ECDOFACJIHE NLBECEHADAK, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6426360", Offset = "0x6424B60", VA = "0x186426360")]
	[AsyncStateMachine(typeof(FELAJNMGFKP))]
	private Task<JGJBELIGIKL> HKAOOJKPNJN(NKCNOMEENDM FCHBDAMJEHN, DGBKKMPLFNE HMAINPNOOAF, ECDOFACJIHE NLBECEHADAK, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x6426FE0", Offset = "0x64257E0", VA = "0x186426FE0")]
	[AsyncStateMachine(typeof(JOCNEHOOFBB))]
	private Task<JGJBELIGIKL> OENEMABIPFM(JGJBELIGIKL BDHILLIJKAH, NKCNOMEENDM LJKBIABPLPJ, ECDOFACJIHE NLBECEHADAK, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA, bool DECACBIDOAD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6426BE0", Offset = "0x64253E0", VA = "0x186426BE0")]
	private bool JIOEKDEDHLK(NKCNOMEENDM IHGCGJGFCHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x6425C60", Offset = "0x6424460", VA = "0x186425C60")]
	[AsyncStateMachine(typeof(CCNIHIILCAJ))]
	protected Task<JGJBELIGIKL> DDBEEHCGJJF(NKCNOMEENDM FCHBDAMJEHN, DGBKKMPLFNE HMAINPNOOAF, ECDOFACJIHE NLBECEHADAK, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA, EJBBLGJJDNK OCPJMPJFOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x6426210", Offset = "0x6424A10", VA = "0x186426210")]
	[AsyncStateMachine(typeof(JNEGNKKDEIH))]
	private Task HJEGLMNPGOA(NKCNOMEENDM FCHBDAMJEHN, ECDOFACJIHE NLBECEHADAK, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6425F00", Offset = "0x6424700", VA = "0x186425F00")]
	private void ENHEBKGNPKF(JGJBELIGIKL NBLEGFFLIPI, ECDOFACJIHE NLBECEHADAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x6426B80", Offset = "0x6425380", VA = "0x186426B80")]
	private void JFBJLEOCIGI(JGJBELIGIKL IAFJOCJFIAC, [Out] JGJBELIGIKL BMOOJEGDKEB, [Out] JGJBELIGIKL NKAIBPAEMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x6425A90", Offset = "0x6424290", VA = "0x186425A90")]
	private Task<PNIAKBIICLJ> ANMMHHMEJDO(MDONEMLENMD KOFJNFGLAFK, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6426FA0", Offset = "0x64257A0", VA = "0x186426FA0")]
	private Task<NKCNOMEENDM> OBBNDIEHLMH(PNIAKBIICLJ FCHBDAMJEHN, NGNENMBJNCM.HLGHPDPFLFD DMKIJOEDLNH, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x64260A0", Offset = "0x64248A0", VA = "0x1864260A0")]
	[AsyncStateMachine(typeof(GILBFPKPNDC))]
	private Task GDPCKJMEEPG(NKCNOMEENDM FCHBDAMJEHN, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA, bool GKHKFAGOPOJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x6425E10", Offset = "0x6424610", VA = "0x186425E10")]
	[AsyncStateMachine(typeof(HNJMDDDOJMI))]
	private Task DOCCJFHAGLG(NKCNOMEENDM FCHBDAMJEHN, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x6425B20", Offset = "0x6424320", VA = "0x186425B20")]
	private Task CDHIPNCMBPA(NKCNOMEENDM FCHBDAMJEHN, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6425B00", Offset = "0x6424300", VA = "0x186425B00")]
	private Task CDELOAHPJFL(NKCNOMEENDM FCHBDAMJEHN, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x6427160", Offset = "0x6425960", VA = "0x186427160")]
	private Task ONPNMMOPBJA(NKCNOMEENDM FCHBDAMJEHN, DGBKKMPLFNE HMAINPNOOAF, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x64264E0", Offset = "0x6424CE0", VA = "0x1864264E0")]
	private Task HPPKMGBICPI(NKCNOMEENDM FCHBDAMJEHN, DGBKKMPLFNE HMAINPNOOAF, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x6422320", Offset = "0x6420B20", VA = "0x186422320")]
	private static Task AFOEOCIIIOA(CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x6427290", Offset = "0x6425A90", VA = "0x186427290")]
	private Task PFNGOOCKCIO(NKCNOMEENDM FCHBDAMJEHN, DGBKKMPLFNE HMAINPNOOAF, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x6426D20", Offset = "0x6425520", VA = "0x186426D20")]
	private Task MHBEBKMAOIJ(NKCNOMEENDM FCHBDAMJEHN, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6426CD0", Offset = "0x64254D0", VA = "0x186426CD0")]
	private void LMFAHIHLKDH(MDONEMLENMD KOFJNFGLAFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x6425DF0", Offset = "0x64245F0", VA = "0x186425DF0")]
	public void DMOEDGGCIGF(long GPPJMLIGEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200")]
	private static void HEAPCOENKLH(IKGFEJPGNIE JLEOAIBABON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal struct ALGMOPHLNMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private NKCNOMEENDM FCHBDAMJEHN;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private MFLPEJLBJBB PELEPLGFCGL
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x6412E20", Offset = "0x6411620", VA = "0x186412E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6413070", Offset = "0x6411870", VA = "0x186413070")]
	public static Task PODNDBGONHN(NGLGDOHLABH JKOJLJMCFCA, NKCNOMEENDM FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x6412E70", Offset = "0x6411670", VA = "0x186412E70")]
	private void PODNDBGONHN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct MEENOGJNBAL
{
	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x6422320", Offset = "0x6420B20", VA = "0x186422320")]
	public static Task PODNDBGONHN(CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct LHOHLNGMBNL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct LJOOKKEACCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public LEGAMHNOHAM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x64210D0", Offset = "0x641F8D0", VA = "0x1864210D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x6421630", Offset = "0x641FE30", VA = "0x186421630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x6420F90", Offset = "0x641F790", VA = "0x186420F90")]
	[AsyncStateMachine(typeof(LJOOKKEACCP))]
	public static Task PODNDBGONHN(LEGAMHNOHAM ABKLOKKPJKM, NKCNOMEENDM FCHBDAMJEHN, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct FNNDKDDMPMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct CNIIGDDCMEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public LEGAMHNOHAM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public DGBKKMPLFNE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private JGJBELIGIKL <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private NGLGDOHLABH <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private MFLPEJLBJBB <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private IDisposable <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private List<(PersistenceView, CPNGAJPMGHC)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private CPNGAJPMGHC <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x64150B0", Offset = "0x64138B0", VA = "0x1864150B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x6415D50", Offset = "0x6414550", VA = "0x186415D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x641A880", Offset = "0x6419080", VA = "0x18641A880")]
	[AsyncStateMachine(typeof(CNIIGDDCMEM))]
	public static Task PODNDBGONHN(LEGAMHNOHAM ABKLOKKPJKM, NKCNOMEENDM FCHBDAMJEHN, DGBKKMPLFNE HMAINPNOOAF, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x641A680", Offset = "0x6418E80", VA = "0x18641A680")]
	private static void KLBGFEBELJM(PersistenceView JFILAMEFOEI, CPNGAJPMGHC ODHHDFDFIMM, NKCNOMEENDM FCHBDAMJEHN, JGJBELIGIKL BDHILLIJKAH, bool GEMNKFEKNOE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct BHPELLACAJB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct DBOOHHKINKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public NGLGDOHLABH roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x6415DB0", Offset = "0x64145B0", VA = "0x186415DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x64161F0", Offset = "0x64149F0", VA = "0x1864161F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x64137F0", Offset = "0x6411FF0", VA = "0x1864137F0")]
	[AsyncStateMachine(typeof(DBOOHHKINKE))]
	public static Task PODNDBGONHN(NGLGDOHLABH JKOJLJMCFCA, NKCNOMEENDM FCHBDAMJEHN, CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct NHANFHHPAKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct LMFEKJHKGNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public NGLGDOHLABH roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public LEGAMHNOHAM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x6421E60", Offset = "0x6420660", VA = "0x186421E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x6422070", Offset = "0x6420870", VA = "0x186422070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class JJHIKKIIAFD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013D")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public FHBHLKGBKLK<string>.CAOEJONIOII timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public JJHIKKIIAFD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0x642BAE0", Offset = "0x642A2E0", VA = "0x18642BAE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x642BE70", Offset = "0x642A670", VA = "0x18642BE70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JJHIKKIIAFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x641F910", Offset = "0x641E110", VA = "0x18641F910")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task ABLGPMNILDG(FHBHLKGBKLK<string>.CAOEJONIOII timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct MHNOAMEHHLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public NHANFHHPAKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private TaskAwaiter<CDCBGIGPIJK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6422400", Offset = "0x6420C00", VA = "0x186422400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6422DB0", Offset = "0x64215B0", VA = "0x186422DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class BMGPBEICEEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public NEHBJOKJCJG version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public BMGPBEICEEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x64139B0", Offset = "0x64121B0", VA = "0x1864139B0")]
		internal object NMNDMFEEMBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x6413900", Offset = "0x6412100", VA = "0x186413900")]
		internal object ANOODOJBEOI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private NKCNOMEENDM FCHBDAMJEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private LEGAMHNOHAM ABKLOKKPJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private bool GKHKFAGOPOJ;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private static readonly ByteString CEJGGJDACFD;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private MFLPEJLBJBB PELEPLGFCGL
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x64245F0", Offset = "0x6422DF0", VA = "0x1864245F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private DJPPJKIGHMC DMKFBEHIHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x6424550", Offset = "0x6422D50", VA = "0x186424550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x6424E60", Offset = "0x6423660", VA = "0x186424E60")]
	[AsyncStateMachine(typeof(LMFEKJHKGNG))]
	public static Task PODNDBGONHN(NGLGDOHLABH JKOJLJMCFCA, NKCNOMEENDM FCHBDAMJEHN, LEGAMHNOHAM ABKLOKKPJKM, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA, bool GKHKFAGOPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x6424D20", Offset = "0x6423520", VA = "0x186424D20")]
	[AsyncStateMachine(typeof(MHNOAMEHHLB))]
	private Task PODNDBGONHN(FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x6424680", Offset = "0x6422E80", VA = "0x186424680")]
	private void LNDHIDHHNJB([NotNull] IJMHNDANHLN PLLIEGAKAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x6424640", Offset = "0x6422E40", VA = "0x186424640")]
	private bool COKIAJGOJBM(NEHBJOKJCJG GLPKPIDPHCF, IJMHNDANHLN PLLIEGAKAKM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct BABFPHKPLOD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct BOCIPOFBPHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public AsyncTaskMethodBuilder<NKCNOMEENDM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public BABFPHKPLOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public NGNENMBJNCM.HLGHPDPFLFD downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private TaskAwaiter<(LBFOJMHFNLD<MCCNMKMHCPC, CLJHHCKGBLK>, LBFOJMHFNLD<KINNJCBMFJP<IJMHNDANHLN>, CLJHHCKGBLK>, LBFOJMHFNLD<KINNJCBMFJP<LFFIBBNOHMB>, CLJHHCKGBLK>, LBFOJMHFNLD<KINNJCBMFJP<AIEANEPJBIM>, CLJHHCKGBLK>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x6413A90", Offset = "0x6412290", VA = "0x186413A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x6414480", Offset = "0x6412C80", VA = "0x186414480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct JKALBGFBPLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public AsyncTaskMethodBuilder<LBFOJMHFNLD<MCCNMKMHCPC, CLJHHCKGBLK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public FHBHLKGBKLK<string>.CAOEJONIOII downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public BABFPHKPLOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public NGNENMBJNCM.HLGHPDPFLFD downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private TaskAwaiter<LBFOJMHFNLD<MCCNMKMHCPC, CLJHHCKGBLK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x643B110", Offset = "0x6439910", VA = "0x18643B110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x643B700", Offset = "0x6439F00", VA = "0x18643B700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	private IOIAEMALEDF<LJEPICPLNFE, LFFIBBNOHMB> LPICLDJOMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private IOIAEMALEDF<LJEPICPLNFE, IJMHNDANHLN> EDCNLNEAKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private IOIAEMALEDF<long, AIEANEPJBIM> GHLAEOMAFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private FNJDAFJDGMO CKDMMBPIJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private IKGFEJPGNIE JLEOAIBABON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private LKADGOEJKMM ADOFHFANKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private string LNCOOBMHJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private LJEPICPLNFE GDEABNLEJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private LJEPICPLNFE EAFNDEMPLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private long GPPJMLIGEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA;

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x6413300", Offset = "0x6411B00", VA = "0x186413300")]
	public static Task<NKCNOMEENDM> LKNLLKIPNLK(NGLGDOHLABH JKOJLJMCFCA, [In] PNIAKBIICLJ FCHBDAMJEHN, NGNENMBJNCM.HLGHPDPFLFD DMKIJOEDLNH, FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x6413670", Offset = "0x6411E70", VA = "0x186413670")]
	[AsyncStateMachine(typeof(BOCIPOFBPHP))]
	private Task<NKCNOMEENDM> PODNDBGONHN(NGNENMBJNCM.HLGHPDPFLFD DMKIJOEDLNH, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x6413150", Offset = "0x6411950", VA = "0x186413150")]
	[AsyncStateMachine(typeof(JKALBGFBPLF))]
	private Task<LBFOJMHFNLD<MCCNMKMHCPC, CLJHHCKGBLK>> LGLPHINFFCL(string LNCOOBMHJOG, long GPPJMLIGEEN, NGNENMBJNCM.HLGHPDPFLFD DMKIJOEDLNH, FHBHLKGBKLK<string>.CAOEJONIOII HJLEKINCFMK, CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct AGDNJDJLHKL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct LDLODNCENED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public AsyncTaskMethodBuilder<PNIAKBIICLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public AGDNJDJLHKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private TaskAwaiter<PNIAKBIICLJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x643D670", Offset = "0x643BE70", VA = "0x18643D670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x643DA70", Offset = "0x643C270", VA = "0x18643DA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct FMJMOMLJJOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public AsyncTaskMethodBuilder<PNIAKBIICLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public AGDNJDJLHKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private TaskAwaiter<PNIAKBIICLJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x6435A70", Offset = "0x6434270", VA = "0x186435A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x6435E70", Offset = "0x6434670", VA = "0x186435E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class NJAJJKKFGPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public NJAJJKKFGPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x13B6F80", Offset = "0x13B5780", VA = "0x1813B6F80")]
		internal bool AMHDKEPEPHJ(LKADGOEJKMM sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct JMFJHJFJDEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder<PNIAKBIICLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public LJEPICPLNFE superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public MFLPEJLBJBB callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private NJAJJKKFGPD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private IKGFEJPGNIE <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private LKADGOEJKMM <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private LJEPICPLNFE <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private LJEPICPLNFE <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private TaskAwaiter<IKGFEJPGNIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private TaskAwaiter<KHNCGBFPFIA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private TaskAwaiter<FEAFPIIILAH> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x643B770", Offset = "0x6439F70", VA = "0x18643B770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x643C810", Offset = "0x643B010", VA = "0x18643C810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private MFLPEJLBJBB NFMOFHCEAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private HJJOGJKLCEL BLACKCPDDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private long AKDANPAICOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private long DILOHLKKNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private long MGLCKKIMBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private string JDODMIBKHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private LJEPICPLNFE KMEKLMGGHHO;

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x642D2C0", Offset = "0x642BAC0", VA = "0x18642D2C0")]
	public static Task<PNIAKBIICLJ> LKNLLKIPNLK(NGLGDOHLABH JKOJLJMCFCA, MDONEMLENMD KOFJNFGLAFK, FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x642D570", Offset = "0x642BD70", VA = "0x18642D570")]
	[AsyncStateMachine(typeof(LDLODNCENED))]
	private Task<PNIAKBIICLJ> PODNDBGONHN(CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x642CFD0", Offset = "0x642B7D0", VA = "0x18642CFD0")]
	[AsyncStateMachine(typeof(FMJMOMLJJOH))]
	private Task<PNIAKBIICLJ> ANMMHHMEJDO(FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x642D130", Offset = "0x642B930", VA = "0x18642D130")]
	[AsyncStateMachine(typeof(JMFJHJFJDEP))]
	private static Task<PNIAKBIICLJ> ANMMHHMEJDO(MFLPEJLBJBB NFMOFHCEAPK, long AKDANPAICOC, long DILOHLKKNAL, long MGLCKKIMBHK, string JDODMIBKHHJ, LJEPICPLNFE KMEKLMGGHHO, CancellationToken GANAOLJLMGA, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x642D540", Offset = "0x642BD40", VA = "0x18642D540")]
	private void NINLGHAHMNN(IKGFEJPGNIE JLEOAIBABON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct NIDOMNABIAP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct DGMFPAFBPHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public NIDOMNABIAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x6430AA0", Offset = "0x642F2A0", VA = "0x186430AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x6431030", Offset = "0x642F830", VA = "0x186431030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private MFLPEJLBJBB NFMOFHCEAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private NKCNOMEENDM FCHBDAMJEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	private float LOPPHMCDBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private float FHCPKPKOHDH;

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x6440AF0", Offset = "0x643F2F0", VA = "0x186440AF0")]
	public static Task OMFNKNBKJKO(NGLGDOHLABH JKOJLJMCFCA, NKCNOMEENDM FCHBDAMJEHN, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x6440C90", Offset = "0x643F490", VA = "0x186440C90")]
	[AsyncStateMachine(typeof(DGMFPAFBPHH))]
	public Task PODNDBGONHN(CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6440990", Offset = "0x643F190", VA = "0x186440990")]
	private static void EBDGDOLGJFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x6440830", Offset = "0x643F030", VA = "0x186440830")]
	private void DPMNGKHGBLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x6440770", Offset = "0x643EF70", VA = "0x186440770")]
	private static float AONGOFMHHPA(MFLPEJLBJBB NFMOFHCEAPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x6440AD0", Offset = "0x643F2D0", VA = "0x186440AD0")]
	private static float KKHHPJMMCMA()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct COIPGHIMICC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct IOAPADIHGJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public LEGAMHNOHAM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private MPFKLGFLPPO <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private NGLGDOHLABH <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private GOFCHFBDBHB.PILDDBNKKDK <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private TaskAwaiter<CDCBGIGPIJK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x6439F30", Offset = "0x6438730", VA = "0x186439F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x643A920", Offset = "0x6439120", VA = "0x18643A920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct ILBPAFFGEHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x6439BA0", Offset = "0x64383A0", VA = "0x186439BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x6439ED0", Offset = "0x64386D0", VA = "0x186439ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x6430960", Offset = "0x642F160", VA = "0x186430960")]
	[AsyncStateMachine(typeof(IOAPADIHGJH))]
	public static Task PODNDBGONHN(LEGAMHNOHAM ABKLOKKPJKM, NKCNOMEENDM FCHBDAMJEHN, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x6430840", Offset = "0x642F040", VA = "0x186430840")]
	private static Task<CDCBGIGPIJK> MCHKHIBAJNP(LEGAMHNOHAM ABKLOKKPJKM, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x64308B0", Offset = "0x642F0B0", VA = "0x1864308B0")]
	[AsyncStateMachine(typeof(ILBPAFFGEHL))]
	private static Task OPONNDJBLII()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct NKHDODDLCNP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct LOAPLMFPFCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public NKHDODDLCNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x643FFD0", Offset = "0x643E7D0", VA = "0x18643FFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x6440680", Offset = "0x643EE80", VA = "0x186440680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class EIHMMDAPANP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public EIHMMDAPANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x64323E0", Offset = "0x6430BE0", VA = "0x1864323E0")]
		internal object KPIHOAHHBBB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct EABBJINIHAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public NKHDODDLCNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private LGLAKAKIFOC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x6431470", Offset = "0x642FC70", VA = "0x186431470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x6431A80", Offset = "0x6430280", VA = "0x186431A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private bool MKBAFIHAPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private CancellationToken GANAOLJLMGA;

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x6440F90", Offset = "0x643F790", VA = "0x186440F90")]
	public static Task LEOAKENAMBM(NGLGDOHLABH JKOJLJMCFCA, bool MKBAFIHAPDM, FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, CancellationToken IFDNJLLFNBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x6441000", Offset = "0x643F800", VA = "0x186441000")]
	[AsyncStateMachine(typeof(LOAPLMFPFCH))]
	private Task PODNDBGONHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x6440E60", Offset = "0x643F660", VA = "0x186440E60")]
	[AsyncStateMachine(typeof(EABBJINIHAF))]
	private Task BDNKDLJPCIK(bool HACNHMJCJDJ, string FLNADIENFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0")]
	private bool PGHGOPLEAOF(bool MKBAFIHAPDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal struct IHHMKBHLPLD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct BILMKMMDHDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public IHHMKBHLPLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x642F6C0", Offset = "0x642DEC0", VA = "0x18642F6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x642FC30", Offset = "0x642E430", VA = "0x18642FC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class GEHPPKNIJKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public GEHPPKNIJKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x6435EE0", Offset = "0x64346E0", VA = "0x186435EE0")]
		internal object KPIHOAHHBBB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct ALBDHHMJJED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public IHHMKBHLPLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private LGLAKAKIFOC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x642EA60", Offset = "0x642D260", VA = "0x18642EA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x642F040", Offset = "0x642D840", VA = "0x18642F040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400057E")]
	private ANMFDCMMPJG LEABAHBMJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400057F")]
	private FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000580")]
	private NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000581")]
	private bool FOJPKDBOHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private NKCNOMEENDM FCHBDAMJEHN;

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x6439070", Offset = "0x6437870", VA = "0x186439070")]
	public static Task<Scene> FBGBAADLDIM(NGLGDOHLABH JKOJLJMCFCA, ANMFDCMMPJG JACPNLBJMCC, FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x6439160", Offset = "0x6437960", VA = "0x186439160")]
	[AsyncStateMachine(typeof(BILMKMMDHDL))]
	private Task<Scene> PODNDBGONHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x6439040", Offset = "0x6437840", VA = "0x186439040")]
	private bool BOGJJPFDGLB(NKCNOMEENDM FCHBDAMJEHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x64390F0", Offset = "0x64378F0", VA = "0x1864390F0")]
	private void NCLMLMMOHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x6438EF0", Offset = "0x64376F0", VA = "0x186438EF0")]
	[AsyncStateMachine(typeof(ALBDHHMJJED))]
	private Task<Scene> BDNKDLJPCIK(string FLNADIENFAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct KHNMBHKJNOO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct LILAFLIMEGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public AsyncTaskMethodBuilder<JGJBELIGIKL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public KHNMBHKJNOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public JGJBELIGIKL nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public NKCNOMEENDM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private TaskAwaiter<JGJBELIGIKL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x643E630", Offset = "0x643CE30", VA = "0x18643E630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x643F110", Offset = "0x643D910", VA = "0x18643F110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct FKIBJECMHJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public AsyncTaskMethodBuilder<JGJBELIGIKL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public KHNMBHKJNOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public JGJBELIGIKL state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private TaskAwaiter<CDCBGIGPIJK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x6435720", Offset = "0x6433F20", VA = "0x186435720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x6435A00", Offset = "0x6434200", VA = "0x186435A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private readonly LEGAMHNOHAM ABKLOKKPJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private readonly HJJOGJKLCEL BLACKCPDDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private readonly OKOOEMNBGKJ PJOJIMOPBIB;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private MPFKLGFLPPO FLGMPCIKGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x4D66E30", Offset = "0x4D65630", VA = "0x184D66E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x643D4D0", Offset = "0x643BCD0", VA = "0x18643D4D0")]
	public KHNMBHKJNOO(LEGAMHNOHAM ABKLOKKPJKM, HJJOGJKLCEL BLACKCPDDOE, OKOOEMNBGKJ PJOJIMOPBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x643D330", Offset = "0x643BB30", VA = "0x18643D330")]
	[AsyncStateMachine(typeof(LILAFLIMEGC))]
	public Task<JGJBELIGIKL> LIMJMEDACHM(JGJBELIGIKL GFCIBDOHFBI, NKCNOMEENDM LJKBIABPLPJ, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA, bool DECACBIDOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x643D1A0", Offset = "0x643B9A0", VA = "0x18643D1A0")]
	[AsyncStateMachine(typeof(FKIBJECMHJH))]
	private Task<JGJBELIGIKL> APBHGOOANPN(FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, JGJBELIGIKL KPFMIIFGAKP, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x643D300", Offset = "0x643BB00", VA = "0x18643D300")]
	private bool KKNEBHOKOCI(JGJBELIGIKL FNILFFBMLKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x643D4B0", Offset = "0x643BCB0", VA = "0x18643D4B0")]
	private void OHIILDFJLAF(string GENKKDFBIEL)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct LCDNHJGPCJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct HBEEPCMKBJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public MPFKLGFLPPO operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public DGBKKMPLFNE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private List<(PersistenceView, CPNGAJPMGHC)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private (PersistenceView, CPNGAJPMGHC) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x64373D0", Offset = "0x6435BD0", VA = "0x1864373D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x6437A10", Offset = "0x6436210", VA = "0x186437A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x643D530", Offset = "0x643BD30", VA = "0x18643D530")]
	[AsyncStateMachine(typeof(HBEEPCMKBJP))]
	public static Task PODNDBGONHN(MPFKLGFLPPO CGOMHOMLHEB, NKCNOMEENDM FCHBDAMJEHN, DGBKKMPLFNE HMAINPNOOAF, CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal struct JGJIDPMOCPI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct OEKIBDHCIKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public MPFKLGFLPPO operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public DGBKKMPLFNE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private NEHBJOKJCJG <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private List<(PersistenceView, CPNGAJPMGHC)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private CPNGAJPMGHC <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x64410F0", Offset = "0x643F8F0", VA = "0x1864410F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x6441950", Offset = "0x6440150", VA = "0x186441950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x643AC50", Offset = "0x6439450", VA = "0x18643AC50")]
	[AsyncStateMachine(typeof(OEKIBDHCIKK))]
	public static Task PODNDBGONHN(MPFKLGFLPPO CGOMHOMLHEB, NKCNOMEENDM FCHBDAMJEHN, DGBKKMPLFNE HMAINPNOOAF, CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct GOFCHFBDBHB
{
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	public struct PILDDBNKKDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public List<CKEABANGALJ> ICCLCJEDPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public List<CPNGAJPMGHC> MDFKBCEBJDM;

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x8384B0", Offset = "0x836CB0", VA = "0x1808384B0")]
		public PILDDBNKKDK(List<CKEABANGALJ> ICCLCJEDPNN, List<CPNGAJPMGHC> MDFKBCEBJDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class FCGNCJGIHAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public IEnumerable<CKEABANGALJ> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public FCGNCJGIHAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x6433A10", Offset = "0x6432210", VA = "0x186433A10")]
		internal object HOBACMKBBML()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private NGLGDOHLABH JKOJLJMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private NKCNOMEENDM FCHBDAMJEHN;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private MFLPEJLBJBB PELEPLGFCGL
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x6436250", Offset = "0x6434A50", VA = "0x186436250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x6436C80", Offset = "0x6435480", VA = "0x186436C80")]
	public static PILDDBNKKDK PODNDBGONHN(NGLGDOHLABH JKOJLJMCFCA, NKCNOMEENDM FCHBDAMJEHN)
	{
		return default(PILDDBNKKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x6436A20", Offset = "0x6435220", VA = "0x186436A20")]
	private PILDDBNKKDK PODNDBGONHN()
	{
		return default(PILDDBNKKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x6436470", Offset = "0x6434C70", VA = "0x186436470")]
	private PILDDBNKKDK FPJHAFEIGIJ(IJMHNDANHLN PLLIEGAKAKM, NEHBJOKJCJG EDMPIIAFFHL)
	{
		return default(PILDDBNKKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x64362A0", Offset = "0x6434AA0", VA = "0x1864362A0")]
	private bool FMMOAELCCME(IEnumerable<CKEABANGALJ> ICCLCJEDPNN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct ALAADILFDHB
{
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class NIJILAHFENN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public GOFCHFBDBHB.PILDDBNKKDK instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public NIJILAHFENN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x6440DB0", Offset = "0x643F5B0", VA = "0x186440DB0")]
		internal object ABLGPMNILDG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class MJOPKPKBPNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public MJOPKPKBPNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x64406E0", Offset = "0x643EEE0", VA = "0x1864406E0")]
		internal object CBBKJCADPKC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x642E4B0", Offset = "0x642CCB0", VA = "0x18642E4B0")]
	public static void PODNDBGONHN(MPFKLGFLPPO CGOMHOMLHEB, NKCNOMEENDM FCHBDAMJEHN, GOFCHFBDBHB.PILDDBNKKDK OECLAOILNEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal class OKOOEMNBGKJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct ABFAHEAGPIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public OKOOEMNBGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public JGJBELIGIKL operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public NKCNOMEENDM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public FHBHLKGBKLK<string>.CAOEJONIOII timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x642C800", Offset = "0x642B000", VA = "0x18642C800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x642CF70", Offset = "0x642B770", VA = "0x18642CF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private sealed class FCLILJDENON
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000166")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			public FCLILJDENON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x64450B0", Offset = "0x64438B0", VA = "0x1864450B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x6445370", Offset = "0x6443B70", VA = "0x186445370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public OKOOEMNBGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public FHBHLKGBKLK<string>.CAOEJONIOII handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public FCLILJDENON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x6433A90", Offset = "0x6432290", VA = "0x186433A90")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task MGPDGDBLGDG(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct PHNONDFEKNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public OKOOEMNBGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public FHBHLKGBKLK<string>.CAOEJONIOII timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private FCLILJDENON <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x6443C90", Offset = "0x6442490", VA = "0x186443C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x64441C0", Offset = "0x64429C0", VA = "0x1864441C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct LGDJOGDJJCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public OKOOEMNBGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public FHBHLKGBKLK<string>.CAOEJONIOII timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private Dictionary<Guid, List<KPDECMOJBLE>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x643E020", Offset = "0x643C820", VA = "0x18643E020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x643E5D0", Offset = "0x643CDD0", VA = "0x18643E5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct HCIHAPJDBGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public OKOOEMNBGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public FHBHLKGBKLK<string>.CAOEJONIOII timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private FHBHLKGBKLK<string>.CAOEJONIOII <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private Dictionary<Guid, List<KPDECMOJBLE>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x6437A70", Offset = "0x6436270", VA = "0x186437A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x64380F0", Offset = "0x64368F0", VA = "0x1864380F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class IOPBMDKMONP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005F9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005FA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005FB")]
			public KPDECMOJBLE handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005FC")]
			public IOPBMDKMONP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x6444EB0", Offset = "0x64436B0", VA = "0x186444EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x6445050", Offset = "0x6443850", VA = "0x186445050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public MOMMMJHCODC runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public List<KPDECMOJBLE> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public IOPBMDKMONP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x643AB60", Offset = "0x6439360", VA = "0x18643AB60")]
		internal object JKHDIAEFHLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x643AA70", Offset = "0x6439270", VA = "0x18643AA70")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task ICFODGFBFIF(KPDECMOJBLE handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x643A980", Offset = "0x6439180", VA = "0x18643A980")]
		internal object GGFEHNFDANM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct LKPDNOJBAHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public MOMMMJHCODC runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public List<KPDECMOJBLE> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private IOPBMDKMONP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x643FA30", Offset = "0x643E230", VA = "0x18643FA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x643FF00", Offset = "0x643E700", VA = "0x18643FF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct BIJGDKMFHEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public OKOOEMNBGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public FHBHLKGBKLK<string>.CAOEJONIOII timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x642F0B0", Offset = "0x642D8B0", VA = "0x18642F0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x642F660", Offset = "0x642DE60", VA = "0x18642F660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class PKLKCJGAGME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public PKLKCJGAGME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x6444E40", Offset = "0x6443640", VA = "0x186444E40")]
		internal object CDCHNCAAGJN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct OJHNIOEDIAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public OKOOEMNBGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public NKCNOMEENDM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x64419B0", Offset = "0x64401B0", VA = "0x1864419B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x6441EC0", Offset = "0x64406C0", VA = "0x186441EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private sealed class IEEFCDBABGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public IEEFCDBABGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x6438E80", Offset = "0x6437680", VA = "0x186438E80")]
		internal object BJMIKKPLEAO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct AHKLFOOEMFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public OKOOEMNBGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private TaskAwaiter<CDCBGIGPIJK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x642D6C0", Offset = "0x642BEC0", VA = "0x18642D6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x642DD40", Offset = "0x642C540", VA = "0x18642DD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class LMADHHNJAHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public LMADHHNJAHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x643FF60", Offset = "0x643E760", VA = "0x18643FF60")]
		internal object BKCFEKPELMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private readonly LEGAMHNOHAM ABKLOKKPJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private CIIEJDCAIMA PJOJIMOPBIB;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private MPFKLGFLPPO FLGMPCIKGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xF8B020", Offset = "0xF89820", VA = "0x180F8B020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
	public OKOOEMNBGKJ(LEGAMHNOHAM ABKLOKKPJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x6443810", Offset = "0x6442010", VA = "0x186443810")]
	[AsyncStateMachine(typeof(ABFAHEAGPIK))]
	public Task PODNDBGONHN(JGJBELIGIKL BDHILLIJKAH, NKCNOMEENDM LJKBIABPLPJ, FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x6443460", Offset = "0x6441C60", VA = "0x186443460")]
	[AsyncStateMachine(typeof(PHNONDFEKNB))]
	private Task JHGNIIBHJGP(NKCNOMEENDM FCHBDAMJEHN, FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x6442D30", Offset = "0x6441530", VA = "0x186442D30")]
	[AsyncStateMachine(typeof(LGDJOGDJJCI))]
	private Task FENDPEAAFLG(NKCNOMEENDM FCHBDAMJEHN, FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x6443140", Offset = "0x6441940", VA = "0x186443140")]
	[AsyncStateMachine(typeof(HCIHAPJDBGJ))]
	private Task HLEMKEDKNGK(NKCNOMEENDM FCHBDAMJEHN, FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x64435A0", Offset = "0x6441DA0", VA = "0x1864435A0")]
	[AsyncStateMachine(typeof(LKPDNOJBAHA))]
	private Task KILGDENJGKK(Guid CKDIAOGLLCK, List<KPDECMOJBLE> PMGDPBKGCKP, MOMMMJHCODC NMMMJPPLPJF, NKCNOMEENDM FCHBDAMJEHN, CancellationToken JECMOKMEJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x6442AB0", Offset = "0x64412B0", VA = "0x186442AB0")]
	[AsyncStateMachine(typeof(BIJGDKMFHEG))]
	private Task CMANONNABHG(NKCNOMEENDM FCHBDAMJEHN, FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x6442BF0", Offset = "0x64413F0", VA = "0x186442BF0")]
	[AsyncStateMachine(typeof(OJHNIOEDIAK))]
	private Task FDGOCFBNFBH(Guid JMGHHCGPKFH, NKCNOMEENDM FCHBDAMJEHN, FHBHLKGBKLK<string>.CAOEJONIOII PFAPIIDDMDA, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x6443000", Offset = "0x6441800", VA = "0x186443000")]
	[AsyncStateMachine(typeof(AHKLFOOEMFM))]
	private Task GIJCOIBKMCH(Guid JMGHHCGPKFH, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x64436F0", Offset = "0x6441EF0", VA = "0x1864436F0")]
	private void KJDHFBJPLCG(Guid JMGHHCGPKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x6442A00", Offset = "0x6441200", VA = "0x186442A00")]
	private void AGEFFJKOCCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x6442E70", Offset = "0x6441670", VA = "0x186442E70")]
	public Guid FKEEFMENGOC(JGJBELIGIKL NBLEGFFLIPI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x6443280", Offset = "0x6441A80", VA = "0x186443280")]
	[CompilerGenerated]
	private object IKACEIIPAKJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public readonly struct GMPDBAAEMGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000625")]
	public readonly bool FODICKAFDCK;

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0xBD0370", Offset = "0xBCEB70", VA = "0x180BD0370")]
	public GMPDBAAEMGG(bool LBMKIKDHAMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public readonly struct EFLNKJCLGNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000626")]
	public readonly IJMHNDANHLN? IIDNFPOBMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000627")]
	public readonly FOELCIKKIFK EGLJEGJINHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000628")]
	public readonly string? ICEOJBHJCEG;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public IReadOnlyCollection<string> LBPJNFJMHDP
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x6431FC0", Offset = "0x64307C0", VA = "0x186431FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public IReadOnlyDictionary<long, int> HAAEPAHLIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x6431FA0", Offset = "0x64307A0", VA = "0x186431FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x6431FE0", Offset = "0x64307E0", VA = "0x186431FE0")]
	public EFLNKJCLGNC(IJMHNDANHLN? HCADKDIKPMA, FOELCIKKIFK KAMLPJFMGBE, string? LNCOOBMHJOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
internal class FACKGFEHHCH : FOMLOJPKICM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct AIGEFINCLGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public AsyncTaskMethodBuilder<EFLNKJCLGNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public FACKGFEHHCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public DCEHBKPGOLL serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public EMLBGBMHHHE roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x642DDA0", Offset = "0x642C5A0", VA = "0x18642DDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x642E440", Offset = "0x642CC40", VA = "0x18642E440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class EHPDHJEPAAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public DCEHBKPGOLL serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public FACKGFEHHCH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public EHPDHJEPAAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x64321C0", Offset = "0x64309C0", VA = "0x1864321C0")]
		internal Task PEJIICHCNNF(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x64320E0", Offset = "0x64308E0", VA = "0x1864320E0")]
		internal Task AHGBGBEEGHG(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class CELCIDFPHNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public EHPDHJEPAAI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public CELCIDFPHNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x6430650", Offset = "0x642EE50", VA = "0x186430650")]
		internal object IHGJGDKJCCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class OKOBMALLPIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public EHPDHJEPAAI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public OKOBMALLPIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x64429C0", Offset = "0x64411C0", VA = "0x1864429C0")]
		internal Task ADBFIEACKAG(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct IKJPPJMLJMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public DCEHBKPGOLL serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public FACKGFEHHCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private CELCIDFPHNB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x6439280", Offset = "0x6437A80", VA = "0x186439280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x6439B40", Offset = "0x6438340", VA = "0x186439B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000629")]
	private readonly DNJICJAPBOC KIDCMOJGGGC;

	[Cpp2IlInjected.Token(Token = "0x400062A")]
	private static readonly TimeSpan HPHCMFIEBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private readonly DBJFKBCPIIO ADOHCNHMLKM;

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x6433920", Offset = "0x6432120", VA = "0x186433920")]
	public FACKGFEHHCH(LEGAMHNOHAM ABKLOKKPJKM, DBJFKBCPIIO ADOHCNHMLKM, DNJICJAPBOC KIDCMOJGGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x6432C20", Offset = "0x6431420", VA = "0x186432C20")]
	[AsyncStateMachine(typeof(AIGEFINCLGH))]
	public Task<EFLNKJCLGNC> JMOOMJHDBEG(long DILOHLKKNAL, EMLBGBMHHHE HPOAOCANGIC, DCEHBKPGOLL BACBPNHMEDD, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x6432AD0", Offset = "0x64312D0", VA = "0x186432AD0")]
	[AsyncStateMachine(typeof(IKJPPJMLJMB))]
	private Task BACKAJMGALP(DCEHBKPGOLL BACBPNHMEDD, IEnumerable<PersistenceView> DFPBMEHHDBJ, StringBuilder DGKEPJDIJOJ, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x6432D80", Offset = "0x6431580", VA = "0x186432D80")]
	private EFLNKJCLGNC KAABFLEFFPP(long DILOHLKKNAL, EMLBGBMHHHE HPOAOCANGIC, DCEHBKPGOLL BACBPNHMEDD, IEnumerable<PersistenceView> DFPBMEHHDBJ, StringBuilder DGKEPJDIJOJ)
	{
		return default(EFLNKJCLGNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x6433220", Offset = "0x6431A20", VA = "0x186433220")]
	private IJMHNDANHLN LLKLOBLMKNH(long DILOHLKKNAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x6432880", Offset = "0x6431080", VA = "0x186432880")]
	private void ABGMMFAFCIE(IJMHNDANHLN CICJBBCACPF, StringBuilder DGKEPJDIJOJ, IEnumerable<PersistenceView> DFPBMEHHDBJ, [In] BCCKIGFJGJE FBJABCNIDOB, EKKBAPOPLPH ECHFOGDAGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x64333E0", Offset = "0x6431BE0", VA = "0x1864333E0")]
	private void NADGMOKECHG(IJMHNDANHLN CICJBBCACPF, StringBuilder DGKEPJDIJOJ, PersistenceView JFILAMEFOEI, EKKBAPOPLPH ECHFOGDAGEI, [In] BCCKIGFJGJE FBJABCNIDOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal class GPGKAHJABEC : FOMLOJPKICM
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class CHLJJOMOAAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public PLEPKDPNJHM.CLLLLHGPAMH roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public CHLJJOMOAAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x64307F0", Offset = "0x642EFF0", VA = "0x1864307F0")]
		internal object MPLGIHGCCAA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct LJLLKHAFKNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public AsyncTaskMethodBuilder<(PLEPKDPNJHM.CLLLLHGPAMH roomDataUpload, PLEPKDPNJHM.CLLLLHGPAMH subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public EFLNKJCLGNC roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public GPGKAHJABEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private CHLJJOMOAAK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private TaskAwaiter<PLEPKDPNJHM.CLLLLHGPAMH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x643F180", Offset = "0x643D980", VA = "0x18643F180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x643F9C0", Offset = "0x643E1C0", VA = "0x18643F9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct IDECEJKBAML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public AsyncTaskMethodBuilder<DBLJMINNAMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public GPGKAHJABEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public EFLNKJCLGNC roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public JNNCDNMFPJN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private TaskAwaiter<(PLEPKDPNJHM.CLLLLHGPAMH roomDataUpload, PLEPKDPNJHM.CLLLLHGPAMH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private TaskAwaiter<DBLJMINNAMP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x64387F0", Offset = "0x6436FF0", VA = "0x1864387F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x6438E10", Offset = "0x6437610", VA = "0x186438E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct JNPKODIKCEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public AsyncTaskMethodBuilder<KHNCGBFPFIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public GPGKAHJABEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public EFLNKJCLGNC roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private TaskAwaiter<(PLEPKDPNJHM.CLLLLHGPAMH roomDataUpload, PLEPKDPNJHM.CLLLLHGPAMH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private TaskAwaiter<KHNCGBFPFIA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x643C880", Offset = "0x643B080", VA = "0x18643C880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x643CCA0", Offset = "0x643B4A0", VA = "0x18643CCA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class CGHBKPBEEJB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000183")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000677")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000678")]
			public AsyncTaskMethodBuilder<CDCBGIGPIJK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000679")]
			public CGHBKPBEEJB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400067A")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400067B")]
			private CDCBGIGPIJK <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400067C")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400067D")]
			private TaskAwaiter<KHNCGBFPFIA> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400067E")]
			private TaskAwaiter<DBLJMINNAMP> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			private TaskAwaiter<CDCBGIGPIJK> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x64453D0", Offset = "0x6443BD0", VA = "0x1864453D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x64463D0", Offset = "0x6444BD0", VA = "0x1864463D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public GPGKAHJABEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public EFLNKJCLGNC roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public JNNCDNMFPJN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public GMPDBAAEMGG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public CGHBKPBEEJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x64306C0", Offset = "0x642EEC0", VA = "0x1864306C0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<CDCBGIGPIJK> JNBBCMJGEHL(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private struct JJDBGPDFIDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public AsyncTaskMethodBuilder<CDCBGIGPIJK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public GPGKAHJABEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public EFLNKJCLGNC roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public JNNCDNMFPJN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public GMPDBAAEMGG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public FHBHLKGBKLK<string>.CAOEJONIOII stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private TaskAwaiter<CDCBGIGPIJK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x643AD90", Offset = "0x6439590", VA = "0x18643AD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x643B0A0", Offset = "0x64398A0", VA = "0x18643B0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400064E")]
	private static readonly DNJICJAPBOC KIDCMOJGGGC;

	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private static readonly DNJICJAPBOC CGJBNFHKICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private readonly LAGBFNECIOK KJCOKCAFMMG;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private NGLGDOHLABH BLEONBLAGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x6425AD0", Offset = "0x64242D0", VA = "0x186425AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x6437340", Offset = "0x6435B40", VA = "0x186437340")]
	public GPGKAHJABEC(LEGAMHNOHAM ABKLOKKPJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x6436CE0", Offset = "0x64354E0", VA = "0x186436CE0")]
	[AsyncStateMachine(typeof(LJLLKHAFKNB))]
	private Task<(PLEPKDPNJHM.CLLLLHGPAMH, PLEPKDPNJHM.CLLLLHGPAMH)> CCKBBGEPBOL(EFLNKJCLGNC LAEGELMPHIN, long AKDANPAICOC, long NOJFBKAHMKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x6436E20", Offset = "0x6435620", VA = "0x186436E20")]
	[AsyncStateMachine(typeof(IDECEJKBAML))]
	public Task<DBLJMINNAMP> IFABLFDJDDP(int BJMHHJDOGHA, [CanBeNull] JNNCDNMFPJN BPFJIMPDFLM, EFLNKJCLGNC LAEGELMPHIN, long AKDANPAICOC, long NOJFBKAHMKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x6436F90", Offset = "0x6435790", VA = "0x186436F90")]
	[AsyncStateMachine(typeof(JNPKODIKCEL))]
	private Task<KHNCGBFPFIA> MKHIFHBICFN(string JDODMIBKHHJ, int BJMHHJDOGHA, EFLNKJCLGNC LAEGELMPHIN, long AKDANPAICOC, long NOJFBKAHMKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x6437100", Offset = "0x6435900", VA = "0x186437100")]
	[AsyncStateMachine(typeof(JJDBGPDFIDM))]
	public Task<CDCBGIGPIJK> PPKKGOMPOBJ(int BJMHHJDOGHA, JNNCDNMFPJN? BPFJIMPDFLM, EFLNKJCLGNC LAEGELMPHIN, long AKDANPAICOC, long NOJFBKAHMKA, GMPDBAAEMGG BIIHPNICJPK, FHBHLKGBKLK<string>.CAOEJONIOII FKDNJLBGFKM, CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public abstract class NFJMPKIEOFI<T> where T : NFJMPKIEOFI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	internal readonly NGLGDOHLABH LGAOHMOFBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	private int? NLBAOEDEINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068E")]
	protected readonly Guid NDGGCDDLEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	protected readonly NDCFBNKNGBO CNJECEBEDHM;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	protected T HCKEHEBOJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x3D25160", Offset = "0x3D23960", VA = "0x183D25160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x3D251C0", Offset = "0x3D239C0", VA = "0x183D251C0")]
	internal NFJMPKIEOFI(NGLGDOHLABH OKPFNCNAEID, NDCFBNKNGBO JHGFLHMNDIE, [Optional] Guid? HGCENGMCDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x3D24F90", Offset = "0x3D23790", VA = "0x183D24F90")]
	private CDCBGIGPIJK HBPBMKCOLGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "4")]
	protected virtual void MNJFGGJNLBG(CDCBGIGPIJK OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x3D25070", Offset = "0x3D23870", VA = "0x183D25070")]
	public T OMBGGGHKFHO(PDJKNJCPPID MNBNFIINGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x3D24F00", Offset = "0x3D23700", VA = "0x183D24F00")]
	public T DNOENMLELHE(int NLMHNPPJCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x3D24DE0", Offset = "0x3D235E0", VA = "0x183D24DE0", Slot = "5")]
	public virtual Task<HACEOFOLLHI> BCNMOOBFLFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public class DOPJAAIDEEK : NFJMPKIEOFI<DOPJAAIDEEK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000690")]
	private MDONEMLENMD IOHCLNMNKCI;

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x64313A0", Offset = "0x642FBA0", VA = "0x1864313A0")]
	internal DOPJAAIDEEK(NGLGDOHLABH OKPFNCNAEID, NDCFBNKNGBO JHGFLHMNDIE, [Optional] Guid? HGCENGMCDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5310", Offset = "0x5AC3B10", VA = "0x185AC5310")]
	public DOPJAAIDEEK JBJNEACBGJD(MDONEMLENMD IOHCLNMNKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x64312D0", Offset = "0x642FAD0", VA = "0x1864312D0", Slot = "4")]
	protected override void MNJFGGJNLBG(CDCBGIGPIJK OLDFIJBKFKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
public class KEJGCHFLKAC : NFJMPKIEOFI<KEJGCHFLKAC>
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	internal enum BONJCMBPLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct EMMGDGOINGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public AsyncTaskMethodBuilder<HACEOFOLLHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public KEJGCHFLKAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private TaskAwaiter<HACEOFOLLHI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x6432460", Offset = "0x6430C60", VA = "0x186432460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x6432810", Offset = "0x6431010", VA = "0x186432810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	private BONJCMBPLCJ CEPIIDNOKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	private string MONMLCICAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private JNNCDNMFPJN IOHCLNMNKCI;

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x643D030", Offset = "0x643B830", VA = "0x18643D030")]
	internal KEJGCHFLKAC(NGLGDOHLABH OKPFNCNAEID, NDCFBNKNGBO JHGFLHMNDIE, [Optional] Guid? HGCENGMCDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x643CE70", Offset = "0x643B670", VA = "0x18643CE70")]
	public KEJGCHFLKAC CMDEHANLHCK(string MMOFPMCDOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x643CEA0", Offset = "0x643B6A0", VA = "0x18643CEA0")]
	public KEJGCHFLKAC IDENCCKNOIL(bool FIPBGIGDKBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x643CE40", Offset = "0x643B640", VA = "0x18643CE40")]
	public KEJGCHFLKAC BFLOGNJHGBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x643CEC0", Offset = "0x643B6C0", VA = "0x18643CEC0", Slot = "4")]
	protected override void MNJFGGJNLBG(CDCBGIGPIJK OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x643CD50", Offset = "0x643B550", VA = "0x18643CD50", Slot = "5")]
	[AsyncStateMachine(typeof(EMMGDGOINGJ))]
	public override Task<HACEOFOLLHI> BCNMOOBFLFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x643CD10", Offset = "0x643B510", VA = "0x18643CD10")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<HACEOFOLLHI> AMFONKKHJKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal static class DNHHIDAOHDP
{
	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x6431110", Offset = "0x642F910", VA = "0x186431110")]
	public static void IPDMFGHCCBA(this DPEHCBMLNGE GMKMPLJCNHJ, MPLKHMAMHAD JOLGKJAGAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x6431090", Offset = "0x642F890", VA = "0x186431090")]
	public static void ABJJJNAJPIC(this MPLKHMAMHAD FAMNCMCAAPI, [Optional] string OLDFIJBKFKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
public static class CCLHFGOIOHB
{
	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x642FD50", Offset = "0x642E550", VA = "0x18642FD50")]
	public static LJEPICPLNFE MDIMFPNFJCH(this DHENJAJALGN EIDPIAALDBB)
	{
		return default(LJEPICPLNFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x642FCA0", Offset = "0x642E4A0", VA = "0x18642FCA0")]
	public static DHENJAJALGN KJOBFJNKCEP(this LJEPICPLNFE PFPNKAMAHAP)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200018D")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006A0")]
			public GAGMMKJLLHM ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006A1")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006A2")]
			public GAGMMKJLLHM HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006A3")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006A4")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006A5")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private static GAGMMKJLLHM[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private Dictionary<GAGMMKJLLHM, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x6446AD0", Offset = "0x64452D0", VA = "0x186446AD0")]
		public bool IOHAGMBDEDE(GAGMMKJLLHM LCNJKGEMOPJ, [Out] ResultConfig MIIMIMJDOBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x6446B40", Offset = "0x6445340", VA = "0x186446B40")]
		public ResultConfig OJDNOKNENEB(GAGMMKJLLHM DMEJPDINNBL, [Optional] HashSet<GAGMMKJLLHM> FJPHDFDMLDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x64471E0", Offset = "0x64459E0", VA = "0x1864471E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x6446C80", Offset = "0x6445480", VA = "0x186446C80", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A90", Offset = "0x7F6290", VA = "0x1807F7A90")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public static class EDEEFJNABDB
{
	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x6431AE0", Offset = "0x64302E0", VA = "0x186431AE0")]
	[IOOPNJKFHOG(FICJCHGEBPC.GameOnly)]
	private static void OIMDAPJKMGI(PHIPPCBHDOE OFJPADAKEMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public interface GMPFCCLMDAG : IEquatable<GMPFCCLMDAG>
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	DateTime LNPJKAADFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGAKADHCLPB();

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool APFEADJAHLC(long AKDANPAICOC, long DILOHLKKNAL, [Out] EFLNKJCLGNC LAEGELMPHIN);
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
internal class FFOHIKFOHOA : GMGDMAEDGAB
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private sealed class DOFHJFJJANI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public KJDIKEMCNIP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public DOFHJFJJANI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x6431260", Offset = "0x642FA60", VA = "0x186431260")]
		internal object AJNMCLDKMHO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	private readonly CECCMBAHFGA ABCGAGNFGHH;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<GMPFCCLMDAG> OKNKOKOHDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x64343B0", Offset = "0x6432BB0", VA = "0x1864343B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x6434300", Offset = "0x6432B00", VA = "0x186434300", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
	[UnityEngine.Scripting.Preserve]
	public FFOHIKFOHOA([NBBCAEDCKMG(null)] CECCMBAHFGA ABCGAGNFGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x6434460", Offset = "0x6432C60", VA = "0x186434460", Slot = "6")]
	public bool OMBEDKFLHMI(long AKDANPAICOC, long DILOHLKKNAL, EFLNKJCLGNC LAEGELMPHIN, KJDIKEMCNIP NFNANJHMKCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x18DFD10", Offset = "0x18DE510", VA = "0x1818DFD10")]
	private void PECNLEJAINK(GMPFCCLMDAG JLDOKOHKLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x6433B80", Offset = "0x6432380", VA = "0x186433B80", Slot = "7")]
	public bool FINCDGFKKGO(long AKDANPAICOC, long DILOHLKKNAL, [Out] GMPFCCLMDAG FKGBPLGHMDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x6434250", Offset = "0x6432A50", VA = "0x186434250", Slot = "8")]
	public bool KCBPIHLDPPK(long AKDANPAICOC, long DILOHLKKNAL, KJDIKEMCNIP NFNANJHMKCJ, [Out] GMPFCCLMDAG FKGBPLGHMDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x6433CF0", Offset = "0x64324F0", VA = "0x186433CF0")]
	private void JEPAEHIDBPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x6434120", Offset = "0x6432920", VA = "0x186434120", Slot = "9")]
	public void JMBHPCMMJAA(long AKDANPAICOC, long DILOHLKKNAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal abstract class OKFDGMAFCGO : CECCMBAHFGA
{
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	protected enum EDFNJCKJHFG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class OLMKHGLPICM : IEnumerable<GMPFCCLMDAG>, IEnumerable, IEnumerator<GMPFCCLMDAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private GMPFCCLMDAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public OKFDGMAFCGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private KJDIKEMCNIP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public KJDIKEMCNIP <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		private GMPFCCLMDAG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x8F6270", Offset = "0x8F4A70", VA = "0x1808F6270")]
		[DebuggerHidden]
		public OLMKHGLPICM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x6443960", Offset = "0x6442160", VA = "0x186443960", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x6443C40", Offset = "0x6442440", VA = "0x186443C40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x6443B90", Offset = "0x6442390", VA = "0x186443B90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GMPFCCLMDAG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x6443B90", Offset = "0x6442390", VA = "0x186443B90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class FAPAHMGAPIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public KJDIKEMCNIP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public FAPAHMGAPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x6433970", Offset = "0x6432170", VA = "0x186433970")]
		internal object JKBKMPOOGLO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class LEIGPCMLJGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public OKFDGMAFCGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public LEIGPCMLJGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x643DAE0", Offset = "0x643C2E0", VA = "0x18643DAE0")]
		internal void DEHKFDLDHJM(LPJIFILDDBO.NFCEBFFBKKH ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B1")]
	protected readonly string KABJJFEFGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private readonly object JAIGOIEFNFF;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract MMJKLKAPCFJ DAFLMBDBNGI
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x6442920", Offset = "0x6441120", VA = "0x186442920")]
	protected OKFDGMAFCGO([CanBeNull] string HBBFNHABFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x6441F20", Offset = "0x6440720", VA = "0x186441F20", Slot = "5")]
	public bool AODIBNJNCMJ(long AKDANPAICOC, long DILOHLKKNAL, KJDIKEMCNIP NFNANJHMKCJ, [Out] GMPFCCLMDAG JLDOKOHKLMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x6442890", Offset = "0x6441090", VA = "0x186442890", Slot = "6")]
	[IteratorStateMachine(typeof(OLMKHGLPICM))]
	public IEnumerable<GMPFCCLMDAG> NLAPFHJHAJH(KJDIKEMCNIP NFNANJHMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void AJLILJEHJME(Stream OPAEAELDHEG, long AKDANPAICOC, long DILOHLKKNAL, EFLNKJCLGNC LAEGELMPHIN);

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool IFNDBGHCKBL(Stream AJHMPDGAJNA, long AKDANPAICOC, long DILOHLKKNAL, CMPIABONMAE PIDLICHECLB, [Out] EFLNKJCLGNC LAEGELMPHIN);

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x64424A0", Offset = "0x6440CA0", VA = "0x1864424A0", Slot = "7")]
	public GMPFCCLMDAG IDKDHGFMNKN(long AKDANPAICOC, long DILOHLKKNAL, EFLNKJCLGNC LAEGELMPHIN, KJDIKEMCNIP NFNANJHMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo GELFKNFHOCO(long AKDANPAICOC, long DILOHLKKNAL, KJDIKEMCNIP NFNANJHMKCJ, EDFNJCKJHFG PIEINFJFMEO);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo BLBFOADKNMM(KJDIKEMCNIP NFNANJHMKCJ, EDFNJCKJHFG PIEINFJFMEO);

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x6442820", Offset = "0x6441020", VA = "0x186442820")]
	protected void LFBGEBMGEHC(LPJIFILDDBO.NFCEBFFBKKH LGGKFIKEBED, string GENKKDFBIEL, FileInfo EJPKKNBFDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x6442110", Offset = "0x6440910", VA = "0x186442110")]
	internal bool GCLKJCJNGFJ(FileInfo EKJCMPNLFGH, long AKDANPAICOC, long DILOHLKKNAL, [Out] EFLNKJCLGNC LAEGELMPHIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200")]
	private void BIMPMBDEPEC(Exception KPBHHHEDHGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
internal class PJAIALDKNDO : OKFDGMAFCGO
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public override MMJKLKAPCFJ DAFLMBDBNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xA75A90", Offset = "0xA74290", VA = "0x180A75A90", Slot = "8")]
		get
		{
			return default(MMJKLKAPCFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x6444D80", Offset = "0x6443580", VA = "0x186444D80")]
	public PJAIALDKNDO([Optional] string HBBFNHABFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x64445C0", Offset = "0x6442DC0", VA = "0x1864445C0")]
	private void DBDJMFODCGP(KJDIKEMCNIP NFNANJHMKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x6444220", Offset = "0x6442A20", VA = "0x186444220", Slot = "9")]
	internal override void AJLILJEHJME(Stream OPAEAELDHEG, long AKDANPAICOC, long DILOHLKKNAL, EFLNKJCLGNC LAEGELMPHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x6444730", Offset = "0x6442F30", VA = "0x186444730", Slot = "10")]
	internal override bool IFNDBGHCKBL(Stream AJHMPDGAJNA, long AKDANPAICOC, long DILOHLKKNAL, CMPIABONMAE PIDLICHECLB, [Out] EFLNKJCLGNC LAEGELMPHIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x6444640", Offset = "0x6442E40", VA = "0x186444640", Slot = "11")]
	protected override FileInfo GELFKNFHOCO(long AKDANPAICOC, long DILOHLKKNAL, KJDIKEMCNIP NFNANJHMKCJ, EDFNJCKJHFG PIEINFJFMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x64444B0", Offset = "0x6442CB0", VA = "0x1864444B0", Slot = "12")]
	protected override DirectoryInfo BLBFOADKNMM(KJDIKEMCNIP NFNANJHMKCJ, EDFNJCKJHFG PIEINFJFMEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal sealed class FIOIFHGLIAD : OKFDGMAFCGO
{
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private static readonly byte[] EMBEECDJLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private readonly byte[] FJDGPEFIIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private readonly byte[] OJDNLOIAJHC;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override MMJKLKAPCFJ DAFLMBDBNGI
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x53CD910", Offset = "0x53CC110", VA = "0x1853CD910", Slot = "8")]
		get
		{
			return default(MMJKLKAPCFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x64355C0", Offset = "0x6433DC0", VA = "0x1864355C0")]
	public FIOIFHGLIAD([Optional] string HBBFNHABFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x6434740", Offset = "0x6432F40", VA = "0x186434740", Slot = "9")]
	internal override void AJLILJEHJME(Stream OPAEAELDHEG, long AKDANPAICOC, long DILOHLKKNAL, EFLNKJCLGNC LAEGELMPHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x6434D00", Offset = "0x6433500", VA = "0x186434D00", Slot = "10")]
	internal override bool IFNDBGHCKBL(Stream AJHMPDGAJNA, long AKDANPAICOC, long DILOHLKKNAL, CMPIABONMAE PIDLICHECLB, [Out] EFLNKJCLGNC LAEGELMPHIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x6434B10", Offset = "0x6433310", VA = "0x186434B10")]
	private void DPGMGAKMHJK(byte[] OCKHPPLPLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x6434BD0", Offset = "0x64333D0", VA = "0x186434BD0", Slot = "11")]
	protected override FileInfo GELFKNFHOCO(long AKDANPAICOC, long DILOHLKKNAL, KJDIKEMCNIP NFNANJHMKCJ, EDFNJCKJHFG PIEINFJFMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x6434A00", Offset = "0x6433200", VA = "0x186434A00", Slot = "12")]
	protected override DirectoryInfo BLBFOADKNMM(KJDIKEMCNIP NFNANJHMKCJ, EDFNJCKJHFG PIEINFJFMEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public enum MMJKLKAPCFJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
internal class CDGDGOBDAGJ : CECCMBAHFGA
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private sealed class LEOLMKDNGMH : IEnumerable<GMPFCCLMDAG>, IEnumerable, IEnumerator<GMPFCCLMDAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		private GMPFCCLMDAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public CDGDGOBDAGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private KJDIKEMCNIP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public KJDIKEMCNIP <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private MMJKLKAPCFJ[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private IEnumerator<GMPFCCLMDAG> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		private GMPFCCLMDAG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000667")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x8F6270", Offset = "0x8F4A70", VA = "0x1808F6270")]
		[DebuggerHidden]
		public LEOLMKDNGMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x643DF90", Offset = "0x643C790", VA = "0x18643DF90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x643DBB0", Offset = "0x643C3B0", VA = "0x18643DBB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x643DB60", Offset = "0x643C360", VA = "0x18643DB60")]
		private void JLELDKFKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x643DF40", Offset = "0x643C740", VA = "0x18643DF40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x643DE90", Offset = "0x643C690", VA = "0x18643DE90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GMPFCCLMDAG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x643DE90", Offset = "0x643C690", VA = "0x18643DE90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private readonly MMJKLKAPCFJ[] COJOOEPIKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private readonly Dictionary<MMJKLKAPCFJ, CECCMBAHFGA> NHBMKJMGCCI;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public MMJKLKAPCFJ DAFLMBDBNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x642FF40", Offset = "0x642E740", VA = "0x18642FF40", Slot = "4")]
		get
		{
			return default(MMJKLKAPCFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x6430300", Offset = "0x642EB00", VA = "0x186430300")]
	[UnityEngine.Scripting.Preserve]
	public CDGDGOBDAGJ(params CECCMBAHFGA[] EGECOHFDFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x642FDF0", Offset = "0x642E5F0", VA = "0x18642FDF0", Slot = "5")]
	public bool AODIBNJNCMJ(long AKDANPAICOC, long DILOHLKKNAL, KJDIKEMCNIP NFNANJHMKCJ, [Out] GMPFCCLMDAG JLDOKOHKLMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x642FF70", Offset = "0x642E770", VA = "0x18642FF70")]
	private void GPKLJMOLCEE(int IBCOLPKGCJK, long AKDANPAICOC, long DILOHLKKNAL, KJDIKEMCNIP NFNANJHMKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x6430270", Offset = "0x642EA70", VA = "0x186430270", Slot = "6")]
	[IteratorStateMachine(typeof(LEOLMKDNGMH))]
	public IEnumerable<GMPFCCLMDAG> NLAPFHJHAJH(KJDIKEMCNIP NFNANJHMKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x6430190", Offset = "0x642E990", VA = "0x186430190", Slot = "7")]
	public GMPFCCLMDAG IDKDHGFMNKN(long AKDANPAICOC, long DILOHLKKNAL, EFLNKJCLGNC LAEGELMPHIN, KJDIKEMCNIP NFNANJHMKCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal static class GGOHPLPJDPD
{
	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x6436190", Offset = "0x6434990", VA = "0x186436190")]
	internal static byte[] PBFFDHACMDH(byte[] OCKHPPLPLMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x6436110", Offset = "0x6434910", VA = "0x186436110")]
	public static void NKPHBKIEPMP(Stream HLAKDKDHKBE, byte[] HKKADJFIEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x6435F30", Offset = "0x6434730", VA = "0x186435F30")]
	public static bool MAKBJEKOFJI(Stream HLAKDKDHKBE, long GKHJODDEDGF, CMPIABONMAE FMFAJFCMHKD, [Out] byte[] HNFGPLBKMBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal sealed class HFCBGIJMNAP : GMPFCCLMDAG, IEquatable<GMPFCCLMDAG>, IEquatable<HFCBGIJMNAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private readonly OKFDGMAFCGO HHPJABMOLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	public readonly FileInfo FNFHFPDDBHA;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public MMJKLKAPCFJ DAFLMBDBNGI
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x6438250", Offset = "0x6436A50", VA = "0x186438250", Slot = "9")]
		get
		{
			return default(MMJKLKAPCFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public DateTime LNPJKAADFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x64385A0", Offset = "0x6436DA0", VA = "0x1864385A0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x64386E0", Offset = "0x6436EE0", VA = "0x1864386E0")]
	public HFCBGIJMNAP(OKFDGMAFCGO BKJNLDBAIMD, FileInfo EKJCMPNLFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x6438630", Offset = "0x6436E30", VA = "0x186438630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x6438190", Offset = "0x6436990", VA = "0x186438190", Slot = "5")]
	public void BGAKADHCLPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x6438150", Offset = "0x6436950", VA = "0x186438150", Slot = "6")]
	public bool APFEADJAHLC(long AKDANPAICOC, long DILOHLKKNAL, [Out] EFLNKJCLGNC LAEGELMPHIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x6438430", Offset = "0x6436C30", VA = "0x186438430", Slot = "7")]
	public bool Equals(GMPFCCLMDAG FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x6438370", Offset = "0x6436B70", VA = "0x186438370", Slot = "8")]
	public bool Equals(HFCBGIJMNAP FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x6438280", Offset = "0x6436A80", VA = "0x186438280", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x6438510", Offset = "0x6436D10", VA = "0x186438510", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
public delegate void CMPIABONMAE(LPJIFILDDBO.NFCEBFFBKKH MDDEIDOJNFK, string OLDFIJBKFKG);
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal interface CECCMBAHFGA
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	MMJKLKAPCFJ DAFLMBDBNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AODIBNJNCMJ(long AKDANPAICOC, long DILOHLKKNAL, KJDIKEMCNIP NFNANJHMKCJ, [Out] GMPFCCLMDAG JLDOKOHKLMM);

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<GMPFCCLMDAG> NLAPFHJHAJH(KJDIKEMCNIP NFNANJHMKCJ);

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GMPFCCLMDAG IDKDHGFMNKN(long AKDANPAICOC, long DILOHLKKNAL, EFLNKJCLGNC LAEGELMPHIN, KJDIKEMCNIP NFNANJHMKCJ);
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
