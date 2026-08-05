using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5F8C0E0", Offset = "0x5F8A8E0", VA = "0x185F8C0E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MOJECCFKIFI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MJMNDKPKIPJ<Texture2D> MIOHENGPGAM(string IGBMAIABMOM, [Optional] uint? MOIHNKKIBOI, bool JEJCNBPODIE = false, KOFCOEKHCBB OBFCBMDGLCJ = KOFCOEKHCBB.Default);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MJMNDKPKIPJ<Texture2D> MMBOIHDOCNF(HBKLIFPENPL OKJJICCFJFM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MJMNDKPKIPJ<Texture2D> IPPPMLGGCEN(DGBANILGEPE MHAFPKJPAIK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MJMNDKPKIPJ<Texture2D> KEOCILLLBEG(JHBBCONCKJI KCECNIOJLJJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MJMNDKPKIPJ<Texture2D> JGONPLLCHEG(HDDPBGJKOCD AEAJEKHMCIA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MJMNDKPKIPJ<Texture2D> MLMMCHGBMPF(DMFAHMNHKIH GPLEOIIPGOK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class MMFNMKDHIMH : MOJECCFKIFI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct EGJGLIJNGLG : IEquatable<EGJGLIJNGLG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly string OHMCNIFGANJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly uint? LMLDIHPFKDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly bool CDDPMFBINBP;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5F89970", Offset = "0x5F88170", VA = "0x185F89970")]
		public EGJGLIJNGLG(string IGBMAIABMOM, uint? MOIHNKKIBOI, bool JEJCNBPODIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5F89670", Offset = "0x5F87E70", VA = "0x185F89670", Slot = "4")]
		public bool Equals(EGJGLIJNGLG OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5F89730", Offset = "0x5F87F30", VA = "0x185F89730", Slot = "0")]
		public override bool Equals(object GHDJADLHPAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5F897E0", Offset = "0x5F87FE0", VA = "0x185F897E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5F89860", Offset = "0x5F88060", VA = "0x185F89860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct IFONAEEAMGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder<byte[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EGJGLIJNGLG imageId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5F8A250", Offset = "0x5F88A50", VA = "0x185F8A250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5F8A4F0", Offset = "0x5F88CF0", VA = "0x185F8A4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct NOEOCHNAAHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder<MJMNDKPKIPJ<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public uint? resizeWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public bool cropSquare;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public MMFNMKDHIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public KOFCOEKHCBB textureLoadOptions;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5F8BE80", Offset = "0x5F8A680", VA = "0x185F8BE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5F8C070", Offset = "0x5F8A870", VA = "0x185F8C070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct FPALAKBFNIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<MJMNDKPKIPJ<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public HBKLIFPENPL room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MMFNMKDHIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<MJMNDKPKIPJ<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5F89EB0", Offset = "0x5F886B0", VA = "0x185F89EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5F8A1E0", Offset = "0x5F889E0", VA = "0x185F8A1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct DHNLOGNKGPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<MJMNDKPKIPJ<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public DGBANILGEPE invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public MMFNMKDHIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<MJMNDKPKIPJ<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5F892D0", Offset = "0x5F87AD0", VA = "0x185F892D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5F89600", Offset = "0x5F87E00", VA = "0x185F89600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FJKOFIIENOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<MJMNDKPKIPJ<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public JHBBCONCKJI playerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public MMFNMKDHIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<HBKLIFPENPL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<MJMNDKPKIPJ<Texture2D>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5F899B0", Offset = "0x5F881B0", VA = "0x185F899B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5F89E40", Offset = "0x5F88640", VA = "0x185F89E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct LIFKGEIDEAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<MJMNDKPKIPJ<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public HDDPBGJKOCD account;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public MMFNMKDHIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<MJMNDKPKIPJ<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5F8A890", Offset = "0x5F89090", VA = "0x185F8A890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5F8ABD0", Offset = "0x5F893D0", VA = "0x185F8ABD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct JLELEFOOIND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<MJMNDKPKIPJ<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public DMFAHMNHKIH announcement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public MMFNMKDHIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<MJMNDKPKIPJ<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5F8A560", Offset = "0x5F88D60", VA = "0x185F8A560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5F8A820", Offset = "0x5F89020", VA = "0x185F8A820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly BBDNILLBACI.Resolution NFACMNIBPCC;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly BBDNILLBACI.Resolution PIBOFIKLAKK;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly BBDNILLBACI.Resolution LEJDLMANPFP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly BBDNILLBACI.Resolution DKMAIENMHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly HLJOJMNGLOF<EGJGLIJNGLG> FOJNFGALJEN;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5F8B210", Offset = "0x5F89A10", VA = "0x185F8B210")]
	[ANLGLDAOJJE(ELBANFBEGNE.GameOnly)]
	private static void IOJDKJKPMEL(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5F8BCD0", Offset = "0x5F8A4D0", VA = "0x185F8BCD0")]
	[Preserve]
	internal MMFNMKDHIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5F8B6E0", Offset = "0x5F89EE0", VA = "0x185F8B6E0", Slot = "4")]
	public MJMNDKPKIPJ<Texture2D> MIOHENGPGAM(string IGBMAIABMOM, [Optional] uint? MOIHNKKIBOI, bool JEJCNBPODIE = false, KOFCOEKHCBB OBFCBMDGLCJ = KOFCOEKHCBB.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5F8B8B0", Offset = "0x5F8A0B0", VA = "0x185F8B8B0", Slot = "5")]
	public MJMNDKPKIPJ<Texture2D> MMBOIHDOCNF(HBKLIFPENPL OKJJICCFJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5F8B310", Offset = "0x5F89B10", VA = "0x185F8B310", Slot = "6")]
	public MJMNDKPKIPJ<Texture2D> IPPPMLGGCEN(DGBANILGEPE MHAFPKJPAIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5F8B590", Offset = "0x5F89D90", VA = "0x185F8B590", Slot = "7")]
	public MJMNDKPKIPJ<Texture2D> KEOCILLLBEG(JHBBCONCKJI KCECNIOJLJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5F8B450", Offset = "0x5F89C50", VA = "0x185F8B450", Slot = "8")]
	public MJMNDKPKIPJ<Texture2D> JGONPLLCHEG(HDDPBGJKOCD AEAJEKHMCIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5F8B770", Offset = "0x5F89F70", VA = "0x185F8B770", Slot = "9")]
	public MJMNDKPKIPJ<Texture2D> MLMMCHGBMPF(DMFAHMNHKIH GPLEOIIPGOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5F8AC40", Offset = "0x5F89440", VA = "0x185F8AC40")]
	[AsyncStateMachine(typeof(IFONAEEAMGI))]
	private Task<byte[]> ALHDINAKENN(EGJGLIJNGLG AFIDADBILHB, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F8B0B0", Offset = "0x5F898B0", VA = "0x185F8B0B0")]
	[AsyncStateMachine(typeof(NOEOCHNAAHN))]
	private Task<MJMNDKPKIPJ<Texture2D>> EOFFHEBEPIM(string IGBMAIABMOM, [Optional] uint? MOIHNKKIBOI, bool JEJCNBPODIE = false, KOFCOEKHCBB OBFCBMDGLCJ = KOFCOEKHCBB.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F8AD70", Offset = "0x5F89570", VA = "0x185F8AD70")]
	[AsyncStateMachine(typeof(FPALAKBFNIN))]
	private Task<MJMNDKPKIPJ<Texture2D>> BLPJAJMBEHB(HBKLIFPENPL OKJJICCFJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5F8BB00", Offset = "0x5F8A300", VA = "0x185F8BB00")]
	[AsyncStateMachine(typeof(DHNLOGNKGPC))]
	private Task<MJMNDKPKIPJ<Texture2D>> NJFGAJNMOPN(DGBANILGEPE MHAFPKJPAIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5F8AE80", Offset = "0x5F89680", VA = "0x185F8AE80")]
	[AsyncStateMachine(typeof(FJKOFIIENOF))]
	private Task<MJMNDKPKIPJ<Texture2D>> BPFPDHFOBPE(JHBBCONCKJI KCECNIOJLJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5F8B9F0", Offset = "0x5F8A1F0", VA = "0x185F8B9F0")]
	[AsyncStateMachine(typeof(LIFKGEIDEAO))]
	private Task<MJMNDKPKIPJ<Texture2D>> NBKJADJDFOB(HDDPBGJKOCD AEAJEKHMCIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5F8AFA0", Offset = "0x5F897A0", VA = "0x185F8AFA0")]
	[AsyncStateMachine(typeof(JLELEFOOIND))]
	private Task<MJMNDKPKIPJ<Texture2D>> CILOBCPNIHH(DMFAHMNHKIH GPLEOIIPGOK)
	{
		return null;
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
