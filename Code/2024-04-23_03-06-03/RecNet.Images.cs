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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x59F47B0", Offset = "0x59F37B0", VA = "0x1859F47B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB380", Offset = "0x7EA380", VA = "0x1807EB380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FNDAIJLACFF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBHPMDCPDMB<Texture2D> ABNKAMGCDIO(string PGHOFOPCAFH, [Optional] uint? CLBCNMBFOPK, bool EJFIBIEGANI = false, BLIOPMAIGDO GEHFHEALBPG = BLIOPMAIGDO.Default);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DBHPMDCPDMB<Texture2D> PNJHHBMBCLK(ENKJFBGPLAB LACONHJFCEL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DBHPMDCPDMB<Texture2D> HHAFNEELAGG(MEAKNBKJOLE GMJBDEICAPN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DBHPMDCPDMB<Texture2D> DKCFMCOPABH(KIPLEFCNIEB KFMNLEOANOP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DBHPMDCPDMB<Texture2D> LMKPFBKIEJJ(AFPKENLHNII DHAHMKKNEFJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DBHPMDCPDMB<Texture2D> AOGKEFEDBFJ(MMDIKDPLGFC LNCAOBNOLOD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class MLOGBEHOILM : FNDAIJLACFF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct ONICOHGDGAD : IEquatable<ONICOHGDGAD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly string ICGIALAOHHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly uint? FIPDIOMLFOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly bool MJBNOFHAFKN;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x59F4ED0", Offset = "0x59F3ED0", VA = "0x1859F4ED0")]
		public ONICOHGDGAD(string PGHOFOPCAFH, uint? CLBCNMBFOPK, bool EJFIBIEGANI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x59F4BD0", Offset = "0x59F3BD0", VA = "0x1859F4BD0", Slot = "4")]
		public bool Equals(ONICOHGDGAD JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x59F4C90", Offset = "0x59F3C90", VA = "0x1859F4C90", Slot = "0")]
		public override bool Equals(object KDEEPMDJGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x59F4D40", Offset = "0x59F3D40", VA = "0x1859F4D40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x59F4DC0", Offset = "0x59F3DC0", VA = "0x1859F4DC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct FMKBDOFNLPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder<byte[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public ONICOHGDGAD imageId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x59F2FE0", Offset = "0x59F1FE0", VA = "0x1859F2FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x59F3280", Offset = "0x59F2280", VA = "0x1859F3280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct NKFMEDGJGCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder<DBHPMDCPDMB<Texture2D>> <>t__builder;

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
		public MLOGBEHOILM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public BLIOPMAIGDO textureLoadOptions;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x59F4550", Offset = "0x59F3550", VA = "0x1859F4550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x59F4740", Offset = "0x59F3740", VA = "0x1859F4740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct BGDAKBNIGFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<DBHPMDCPDMB<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ENKJFBGPLAB room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MLOGBEHOILM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<DBHPMDCPDMB<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x59F2560", Offset = "0x59F1560", VA = "0x1859F2560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x59F2890", Offset = "0x59F1890", VA = "0x1859F2890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct OACCMHKCOPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<DBHPMDCPDMB<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public MEAKNBKJOLE invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public MLOGBEHOILM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<DBHPMDCPDMB<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x59F4830", Offset = "0x59F3830", VA = "0x1859F4830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x59F4B60", Offset = "0x59F3B60", VA = "0x1859F4B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BAJBHANLCNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<DBHPMDCPDMB<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public KIPLEFCNIEB playerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public MLOGBEHOILM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<ENKJFBGPLAB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<DBHPMDCPDMB<Texture2D>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x59F2060", Offset = "0x59F1060", VA = "0x1859F2060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x59F24F0", Offset = "0x59F14F0", VA = "0x1859F24F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct FGBCHKIMEOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<DBHPMDCPDMB<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AFPKENLHNII account;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public MLOGBEHOILM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<DBHPMDCPDMB<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x59F2C30", Offset = "0x59F1C30", VA = "0x1859F2C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x59F2F70", Offset = "0x59F1F70", VA = "0x1859F2F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct EEFFGEJBPBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<DBHPMDCPDMB<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public MMDIKDPLGFC announcement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public MLOGBEHOILM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<DBHPMDCPDMB<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x59F2900", Offset = "0x59F1900", VA = "0x1859F2900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x59F2BC0", Offset = "0x59F1BC0", VA = "0x1859F2BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HFGJKKGPMKC.Resolution GAEHFPKOJNC;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HFGJKKGPMKC.Resolution GHCNPCIMLLD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly HFGJKKGPMKC.Resolution EDCHOFGLPIJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly HFGJKKGPMKC.Resolution PGFOLBLGNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly KKGNHHCCIFN<ONICOHGDGAD> ILHKKDBKLOM;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x59F3AD0", Offset = "0x59F2AD0", VA = "0x1859F3AD0")]
	[ILJDPBHFAFI(DIDBPCEENMM.GameOnly)]
	private static void KDNIGEBECPO(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x59F43A0", Offset = "0x59F33A0", VA = "0x1859F43A0")]
	[Preserve]
	internal MLOGBEHOILM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x59F3400", Offset = "0x59F2400", VA = "0x1859F3400", Slot = "4")]
	public DBHPMDCPDMB<Texture2D> ABNKAMGCDIO(string PGHOFOPCAFH, [Optional] uint? CLBCNMBFOPK, bool EJFIBIEGANI = false, BLIOPMAIGDO GEHFHEALBPG = BLIOPMAIGDO.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x59F4180", Offset = "0x59F3180", VA = "0x1859F4180", Slot = "5")]
	public DBHPMDCPDMB<Texture2D> PNJHHBMBCLK(ENKJFBGPLAB LACONHJFCEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x59F3720", Offset = "0x59F2720", VA = "0x1859F3720", Slot = "6")]
	public DBHPMDCPDMB<Texture2D> HHAFNEELAGG(MEAKNBKJOLE GMJBDEICAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x59F35D0", Offset = "0x59F25D0", VA = "0x1859F35D0", Slot = "7")]
	public DBHPMDCPDMB<Texture2D> DKCFMCOPABH(KIPLEFCNIEB KFMNLEOANOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x59F3CF0", Offset = "0x59F2CF0", VA = "0x1859F3CF0", Slot = "8")]
	public DBHPMDCPDMB<Texture2D> LMKPFBKIEJJ(AFPKENLHNII DHAHMKKNEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x59F3490", Offset = "0x59F2490", VA = "0x1859F3490", Slot = "9")]
	public DBHPMDCPDMB<Texture2D> AOGKEFEDBFJ(MMDIKDPLGFC LNCAOBNOLOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x59F3F40", Offset = "0x59F2F40", VA = "0x1859F3F40")]
	[AsyncStateMachine(typeof(FMKBDOFNLPG))]
	private Task<byte[]> NPHFOIHKFOE(ONICOHGDGAD MMNNMJKOPKN, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x59F3970", Offset = "0x59F2970", VA = "0x1859F3970")]
	[AsyncStateMachine(typeof(NKFMEDGJGCO))]
	private Task<DBHPMDCPDMB<Texture2D>> KDMFMJNKEML(string PGHOFOPCAFH, [Optional] uint? CLBCNMBFOPK, bool EJFIBIEGANI = false, BLIOPMAIGDO GEHFHEALBPG = BLIOPMAIGDO.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x59F3E30", Offset = "0x59F2E30", VA = "0x1859F3E30")]
	[AsyncStateMachine(typeof(BGDAKBNIGFO))]
	private Task<DBHPMDCPDMB<Texture2D>> LOPPAEAIBFB(ENKJFBGPLAB LACONHJFCEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x59F32F0", Offset = "0x59F22F0", VA = "0x1859F32F0")]
	[AsyncStateMachine(typeof(OACCMHKCOPL))]
	private Task<DBHPMDCPDMB<Texture2D>> ABGEFJFMHJK(MEAKNBKJOLE GMJBDEICAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x59F3BD0", Offset = "0x59F2BD0", VA = "0x1859F3BD0")]
	[AsyncStateMachine(typeof(BAJBHANLCNE))]
	private Task<DBHPMDCPDMB<Texture2D>> LIJDEPNKBMJ(KIPLEFCNIEB KFMNLEOANOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x59F3860", Offset = "0x59F2860", VA = "0x1859F3860")]
	[AsyncStateMachine(typeof(FGBCHKIMEOK))]
	private Task<DBHPMDCPDMB<Texture2D>> JIPDMODJBLB(AFPKENLHNII DHAHMKKNEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x59F4070", Offset = "0x59F3070", VA = "0x1859F4070")]
	[AsyncStateMachine(typeof(EEFFGEJBPBL))]
	private Task<DBHPMDCPDMB<Texture2D>> PDMFFJFFPBA(MMDIKDPLGFC LNCAOBNOLOD)
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
