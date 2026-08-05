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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x781C750", Offset = "0x781B550", VA = "0x18781C750")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
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
		[Cpp2IlInjected.Address(RVA = "0x781C840", Offset = "0x781B640", VA = "0x18781C840", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BOAFLJEEBBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNDICJJKNNH<Texture2D> ONBCBLPKOOI(string ECFOLMEBCEO, [Optional] uint? DKHJBPJAEON, bool FADAABILNJA = false, AHOGMEIDPDA FOPMALPKDHE = AHOGMEIDPDA.Default);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HNDICJJKNNH<Texture2D> NJAMBLCGIFH(EBODNCFCALI NGAIIHDMKAH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HNDICJJKNNH<Texture2D> KAMIMPLMFJL(PODLFDCNJNO BCCJFILFKKN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HNDICJJKNNH<Texture2D> GNDJFCCCCIC(OJEJMGKECPJ NNIPPOGCGFP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HNDICJJKNNH<Texture2D> HCEIEDIDMNM(MPPKGBDBLNO HKLALGGFIFC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HNDICJJKNNH<Texture2D> EBMGBMBLICC(JKKEFIIHCOK LGFGAANLKEE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class EMPFHCOCHAK : BOAFLJEEBBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct NEFPLFJEOND : IEquatable<NEFPLFJEOND>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly string PHKHFNAGCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly uint? JCLILEOCDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly bool PLHAJPJDDHP;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x781C710", Offset = "0x781B510", VA = "0x18781C710")]
		public NEFPLFJEOND(string ECFOLMEBCEO, uint? DKHJBPJAEON, bool FADAABILNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x781C4C0", Offset = "0x781B2C0", VA = "0x18781C4C0", Slot = "4")]
		public bool Equals(NEFPLFJEOND FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x781C420", Offset = "0x781B220", VA = "0x18781C420", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x781C580", Offset = "0x781B380", VA = "0x18781C580", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x781C600", Offset = "0x781B400", VA = "0x18781C600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CLEOMKBBEEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder<byte[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public NEFPLFJEOND imageId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x781A0A0", Offset = "0x7818EA0", VA = "0x18781A0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x781A340", Offset = "0x7819140", VA = "0x18781A340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct KGFLLCBBMMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder<HNDICJJKNNH<Texture2D>> <>t__builder;

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
		public EMPFHCOCHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AHOGMEIDPDA textureLoadOptions;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x781B990", Offset = "0x781A790", VA = "0x18781B990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x781BB80", Offset = "0x781A980", VA = "0x18781BB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct AFIJJNPJJKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<HNDICJJKNNH<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public EBODNCFCALI room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public EMPFHCOCHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<HNDICJJKNNH<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7819950", Offset = "0x7818750", VA = "0x187819950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7819C80", Offset = "0x7818A80", VA = "0x187819C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct IFPKNICACLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<HNDICJJKNNH<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public PODLFDCNJNO invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public EMPFHCOCHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<HNDICJJKNNH<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x781B5F0", Offset = "0x781A3F0", VA = "0x18781B5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x781B920", Offset = "0x781A720", VA = "0x18781B920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct MBKGJANAGPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<HNDICJJKNNH<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public OJEJMGKECPJ playerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public EMPFHCOCHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<EBODNCFCALI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<HNDICJJKNNH<Texture2D>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x781BF20", Offset = "0x781AD20", VA = "0x18781BF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x781C3B0", Offset = "0x781B1B0", VA = "0x18781C3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct AIJMMFIEIBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<HNDICJJKNNH<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public MPPKGBDBLNO account;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public EMPFHCOCHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<HNDICJJKNNH<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7819CF0", Offset = "0x7818AF0", VA = "0x187819CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x781A030", Offset = "0x7818E30", VA = "0x18781A030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LBDHABJAFLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<HNDICJJKNNH<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public JKKEFIIHCOK announcement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public EMPFHCOCHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<HNDICJJKNNH<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x781BBF0", Offset = "0x781A9F0", VA = "0x18781BBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x781BEB0", Offset = "0x781ACB0", VA = "0x18781BEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly LODAIJAFMMK.Resolution LOGEHDIKKEP;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly LODAIJAFMMK.Resolution KDGMOLKAKLA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly LODAIJAFMMK.Resolution EEKMLJKLEGI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly LODAIJAFMMK.Resolution CDCOHJAKKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly EJFEKODECNO<NEFPLFJEOND> BFGCNNGKAJH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x781B1F0", Offset = "0x7819FF0", VA = "0x18781B1F0")]
	[NKOKDPHOKEP.APMGAGDLDLC.MJKDHMGHAOE]
	internal static void OEANNKJPBKB(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x781B440", Offset = "0x781A240", VA = "0x18781B440")]
	[RecRoom.NoEngine.Common.Preserve]
	internal EMPFHCOCHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x781B2F0", Offset = "0x781A0F0", VA = "0x18781B2F0", Slot = "4")]
	public HNDICJJKNNH<Texture2D> ONBCBLPKOOI(string ECFOLMEBCEO, [Optional] uint? DKHJBPJAEON, bool FADAABILNJA = false, AHOGMEIDPDA FOPMALPKDHE = AHOGMEIDPDA.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x781AE40", Offset = "0x7819C40", VA = "0x18781AE40", Slot = "5")]
	public HNDICJJKNNH<Texture2D> NJAMBLCGIFH(EBODNCFCALI NGAIIHDMKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x781AD00", Offset = "0x7819B00", VA = "0x18781AD00", Slot = "6")]
	public HNDICJJKNNH<Texture2D> KAMIMPLMFJL(PODLFDCNJNO BCCJFILFKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x781A940", Offset = "0x7819740", VA = "0x18781A940", Slot = "7")]
	public HNDICJJKNNH<Texture2D> GNDJFCCCCIC(OJEJMGKECPJ NNIPPOGCGFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x781ABC0", Offset = "0x78199C0", VA = "0x18781ABC0", Slot = "8")]
	public HNDICJJKNNH<Texture2D> HCEIEDIDMNM(MPPKGBDBLNO HKLALGGFIFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x781A6E0", Offset = "0x78194E0", VA = "0x18781A6E0", Slot = "9")]
	public HNDICJJKNNH<Texture2D> EBMGBMBLICC(JKKEFIIHCOK LGFGAANLKEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x781AA90", Offset = "0x7819890", VA = "0x18781AA90")]
	[AsyncStateMachine(typeof(CLEOMKBBEEK))]
	private Task<byte[]> GNFBDFMOKKP(NEFPLFJEOND LBCIAFJGJHM, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x781AF80", Offset = "0x7819D80", VA = "0x18781AF80")]
	[AsyncStateMachine(typeof(KGFLLCBBMMO))]
	private Task<HNDICJJKNNH<Texture2D>> NKCIBDADONF(string ECFOLMEBCEO, [Optional] uint? DKHJBPJAEON, bool FADAABILNJA = false, AHOGMEIDPDA FOPMALPKDHE = AHOGMEIDPDA.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x781A5D0", Offset = "0x78193D0", VA = "0x18781A5D0")]
	[AsyncStateMachine(typeof(AFIJJNPJJKA))]
	private Task<HNDICJJKNNH<Texture2D>> CIIJIBFKFPH(EBODNCFCALI NGAIIHDMKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x781B0E0", Offset = "0x7819EE0", VA = "0x18781B0E0")]
	[AsyncStateMachine(typeof(IFPKNICACLM))]
	private Task<HNDICJJKNNH<Texture2D>> ODCDOEAOPOB(PODLFDCNJNO BCCJFILFKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x781A820", Offset = "0x7819620", VA = "0x18781A820")]
	[AsyncStateMachine(typeof(MBKGJANAGPM))]
	private Task<HNDICJJKNNH<Texture2D>> FCNDJJGKPPH(OJEJMGKECPJ NNIPPOGCGFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x781A4C0", Offset = "0x78192C0", VA = "0x18781A4C0")]
	[AsyncStateMachine(typeof(AIJMMFIEIBL))]
	private Task<HNDICJJKNNH<Texture2D>> AIHJNDEODIA(MPPKGBDBLNO HKLALGGFIFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x781A3B0", Offset = "0x78191B0", VA = "0x18781A3B0")]
	[AsyncStateMachine(typeof(LBDHABJAFLC))]
	private Task<HNDICJJKNNH<Texture2D>> ABAPMMCPAIB(JKKEFIIHCOK LGFGAANLKEE)
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
