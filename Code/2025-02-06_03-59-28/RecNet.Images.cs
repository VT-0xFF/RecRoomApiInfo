using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68C5290", Offset = "0x68C4090", VA = "0x1868C5290")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
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
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecNet_Images
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68C5390", Offset = "0x68C4190", VA = "0x1868C5390", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NCMBOMIDNHI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MEPEJIIMKOI<Texture2D> IAGGKGNKIIG(string GIEEKCOLJBD, [Optional] uint? JNPBJGPPCEH, bool MOIFFGNIHLJ = false, FODBEHMLOMO KAJLICHHHHD = FODBEHMLOMO.Default);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MEPEJIIMKOI<Texture2D> OMDGPANIELP(PJIJPHIAAAH EFFHEJGJIEE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MEPEJIIMKOI<Texture2D> HMDFEGMIFBM(KLEIEJMGDEL KDDNKFKJHJE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MEPEJIIMKOI<Texture2D> LIAMBOJJHOG(INMJDEGAJHE BBAHJHHPJKO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MEPEJIIMKOI<Texture2D> GDAMEGEENNL(HIKBLHEAMEM NBMOBJJCKCK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MEPEJIIMKOI<Texture2D> MLMJHOFBJCE(OPNDHOODKNG IAJLPLMHCKC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class NHDPMJHBJEH : NCMBOMIDNHI
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct JKHIENCBICC : IEquatable<JKHIENCBICC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly string PNPHKCCKGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly uint? JPCJJKFHIMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly bool KBNJEFFBDNB;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x68C3080", Offset = "0x68C1E80", VA = "0x1868C3080")]
		public JKHIENCBICC(string GIEEKCOLJBD, uint? JNPBJGPPCEH, bool MOIFFGNIHLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x68C2D80", Offset = "0x68C1B80", VA = "0x1868C2D80", Slot = "4")]
		public bool Equals(JKHIENCBICC LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68C2E40", Offset = "0x68C1C40", VA = "0x1868C2E40", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68C2EF0", Offset = "0x68C1CF0", VA = "0x1868C2EF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x68C2F70", Offset = "0x68C1D70", VA = "0x1868C2F70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct EENIIIFMHLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder<byte[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JKHIENCBICC imageId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x68C26D0", Offset = "0x68C14D0", VA = "0x1868C26D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x68C2970", Offset = "0x68C1770", VA = "0x1868C2970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct CHBELICDBGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder<MEPEJIIMKOI<Texture2D>> <>t__builder;

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
		public NHDPMJHBJEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public FODBEHMLOMO textureLoadOptions;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68C2470", Offset = "0x68C1270", VA = "0x1868C2470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68C2660", Offset = "0x68C1460", VA = "0x1868C2660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct NFEIDCLFDDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<MEPEJIIMKOI<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public PJIJPHIAAAH room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public NHDPMJHBJEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<MEPEJIIMKOI<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68C38F0", Offset = "0x68C26F0", VA = "0x1868C38F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x68C3C20", Offset = "0x68C2A20", VA = "0x1868C3C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HLPILEANJJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<MEPEJIIMKOI<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public KLEIEJMGDEL invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public NHDPMJHBJEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<MEPEJIIMKOI<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68C29E0", Offset = "0x68C17E0", VA = "0x1868C29E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68C2D10", Offset = "0x68C1B10", VA = "0x1868C2D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct LFPFHJMOIIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<MEPEJIIMKOI<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public INMJDEGAJHE playerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NHDPMJHBJEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<PJIJPHIAAAH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<MEPEJIIMKOI<Texture2D>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68C33F0", Offset = "0x68C21F0", VA = "0x1868C33F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68C3880", Offset = "0x68C2680", VA = "0x1868C3880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct NMAKDBGACNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<MEPEJIIMKOI<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public HIKBLHEAMEM account;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public NHDPMJHBJEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<MEPEJIIMKOI<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68C4EE0", Offset = "0x68C3CE0", VA = "0x1868C4EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68C5220", Offset = "0x68C4020", VA = "0x1868C5220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct JKMKMDHCKNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<MEPEJIIMKOI<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public OPNDHOODKNG announcement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NHDPMJHBJEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<MEPEJIIMKOI<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68C30C0", Offset = "0x68C1EC0", VA = "0x1868C30C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68C3380", Offset = "0x68C2180", VA = "0x1868C3380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly ENJMFFBDCKH.Resolution MAOLIPHOFAI;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly ENJMFFBDCKH.Resolution BLDCBHELKBG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ENJMFFBDCKH.Resolution LOEGLIDMDLO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ENJMFFBDCKH.Resolution ECEAJKPAHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly KNNJMPICKFL<JKHIENCBICC> NEBHFOOIPPC;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x68C3DF0", Offset = "0x68C2BF0", VA = "0x1868C3DF0")]
	[FOLINPJCBJN.HMBDLNHFFEJ.EKAOCHOMHGE]
	internal static void DIFEJPOBKHM(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x68C4D30", Offset = "0x68C3B30", VA = "0x1868C4D30")]
	[RecRoom.NoEngine.Common.Preserve]
	internal NHDPMJHBJEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x68C4390", Offset = "0x68C3190", VA = "0x1868C4390", Slot = "4")]
	public MEPEJIIMKOI<Texture2D> IAGGKGNKIIG(string GIEEKCOLJBD, [Optional] uint? JNPBJGPPCEH, bool MOIFFGNIHLJ = false, FODBEHMLOMO KAJLICHHHHD = FODBEHMLOMO.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68C4B10", Offset = "0x68C3910", VA = "0x1868C4B10", Slot = "5")]
	public MEPEJIIMKOI<Texture2D> OMDGPANIELP(PJIJPHIAAAH EFFHEJGJIEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x68C4250", Offset = "0x68C3050", VA = "0x1868C4250", Slot = "6")]
	public MEPEJIIMKOI<Texture2D> HMDFEGMIFBM(KLEIEJMGDEL KDDNKFKJHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x68C4770", Offset = "0x68C3570", VA = "0x1868C4770", Slot = "7")]
	public MEPEJIIMKOI<Texture2D> LIAMBOJJHOG(INMJDEGAJHE BBAHJHHPJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68C4110", Offset = "0x68C2F10", VA = "0x1868C4110", Slot = "8")]
	public MEPEJIIMKOI<Texture2D> GDAMEGEENNL(HIKBLHEAMEM NBMOBJJCKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68C48C0", Offset = "0x68C36C0", VA = "0x1868C48C0", Slot = "9")]
	public MEPEJIIMKOI<Texture2D> MLMJHOFBJCE(OPNDHOODKNG IAJLPLMHCKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68C4640", Offset = "0x68C3440", VA = "0x1868C4640")]
	[AsyncStateMachine(typeof(EENIIIFMHLO))]
	private Task<byte[]> LHOCOHGNOOP(JKHIENCBICC LLGIMAIFBOB, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68C3C90", Offset = "0x68C2A90", VA = "0x1868C3C90")]
	[AsyncStateMachine(typeof(CHBELICDBGK))]
	private Task<MEPEJIIMKOI<Texture2D>> AJGFKBJIJOG(string GIEEKCOLJBD, [Optional] uint? JNPBJGPPCEH, bool MOIFFGNIHLJ = false, FODBEHMLOMO KAJLICHHHHD = FODBEHMLOMO.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68C3EE0", Offset = "0x68C2CE0", VA = "0x1868C3EE0")]
	[AsyncStateMachine(typeof(NFEIDCLFDDM))]
	private Task<MEPEJIIMKOI<Texture2D>> DNCHBBGOMML(PJIJPHIAAAH EFFHEJGJIEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68C4420", Offset = "0x68C3220", VA = "0x1868C4420")]
	[AsyncStateMachine(typeof(HLPILEANJJB))]
	private Task<MEPEJIIMKOI<Texture2D>> IOMCLMIIOMP(KLEIEJMGDEL KDDNKFKJHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68C3FF0", Offset = "0x68C2DF0", VA = "0x1868C3FF0")]
	[AsyncStateMachine(typeof(LFPFHJMOIIP))]
	private Task<MEPEJIIMKOI<Texture2D>> DOJLHKNKECE(INMJDEGAJHE BBAHJHHPJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x68C4A00", Offset = "0x68C3800", VA = "0x1868C4A00")]
	[AsyncStateMachine(typeof(NMAKDBGACNO))]
	private Task<MEPEJIIMKOI<Texture2D>> OHGLHOBLCED(HIKBLHEAMEM NBMOBJJCKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68C4530", Offset = "0x68C3330", VA = "0x1868C4530")]
	[AsyncStateMachine(typeof(JKMKMDHCKNN))]
	private Task<MEPEJIIMKOI<Texture2D>> KFCJOJDAIEP(OPNDHOODKNG IAJLPLMHCKC)
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
