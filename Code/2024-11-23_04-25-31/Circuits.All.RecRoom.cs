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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x22561A0", Offset = "0x2254BA0", VA = "0x1822561A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D78D0", Offset = "0x8D62D0", VA = "0x1808D78D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class JLDPKGEOPEJ : IDisposable, AGEPHIJJIEI, NMDDJFGGNPN, CBFBEKENAFN, CLNGMFBJMKM
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class IEEBALFJPFF : CHBJMGAGLKO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int NAFPHDIPPDC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2244F40", Offset = "0x2243940", VA = "0x182244F40", Slot = "5")]
		public OBGADJKIEPI ENGEFBEHALO(OLBHGBECMMG.MCBIGBAJFAD JOIGIEDFOGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void LFPPCOFPIBE();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void JDKINKAHDHO();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2245110", Offset = "0x2243B10", VA = "0x182245110", Slot = "13")]
		public virtual void OGAPHOHOMLH(JLDPKGEOPEJ DAKMLHHEJJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2245090", Offset = "0x2243A90", VA = "0x182245090", Slot = "14")]
		public virtual void MGOMMHPDAOA(JLDPKGEOPEJ DAKMLHHEJJO, LEOAEGKNMKP EFFBNJEBEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		protected IEEBALFJPFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface CHBJMGAGLKO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int NAFPHDIPPDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		OBGADJKIEPI ENGEFBEHALO(OLBHGBECMMG.MCBIGBAJFAD JOIGIEDFOGO);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LFPPCOFPIBE();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JDKINKAHDHO();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OGAPHOHOMLH(JLDPKGEOPEJ DAKMLHHEJJO);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void MGOMMHPDAOA(JLDPKGEOPEJ DAKMLHHEJJO, LEOAEGKNMKP EFFBNJEBEKP);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct JGFOCIAHLHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly NMDDIJILECK<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ, APMCLBELNPF.GJEGCBPMDFF<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ>> CKLHPFDBJPC;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2251720", Offset = "0x2250120", VA = "0x182251720")]
		internal JGFOCIAHLHI(NMDDIJILECK<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ, APMCLBELNPF.GJEGCBPMDFF<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ>> OAAFMJBAJGL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class LOFMBNFAICN : APMCLBELNPF.GJEGCBPMDFF<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly LOFMBNFAICN JOLICDCBKGF;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		private LOFMBNFAICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1391480", Offset = "0x138FE80", VA = "0x181391480", Slot = "4")]
		public IHPBJPDOCPD KAMJIKPGJCN(LEOAEGKNMKP PCBICLOONMH)
		{
			return default(IHPBJPDOCPD);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2254280", Offset = "0x2252C80", VA = "0x182254280", Slot = "5")]
		public void OGAPHOHOMLH(JLDPKGEOPEJ ELFANOAFHKM, LEOAEGKNMKP EFFBNJEBEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2254170", Offset = "0x2252B70", VA = "0x182254170", Slot = "6")]
		public void MGOMMHPDAOA(JLDPKGEOPEJ ELFANOAFHKM, LEOAEGKNMKP EFFBNJEBEKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct KMHDCAGMAEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public PIMFGPKDBAH<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ, APMCLBELNPF.GJEGCBPMDFF<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ>> CKLHPFDBJPC;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2253AC0", Offset = "0x22524C0", VA = "0x182253AC0")]
		internal KMHDCAGMAEI(PIMFGPKDBAH<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ, APMCLBELNPF.GJEGCBPMDFF<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ>> OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2253A70", Offset = "0x2252470", VA = "0x182253A70")]
		public static KMHDCAGMAEI AELHPDENENI()
		{
			return default(KMHDCAGMAEI);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct FDKOMPLHOFH : GEJCEKPHLGB.PKJJHHPEFDD<LEOAEGKNMKP, JLDPKGEOPEJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct APCPPBIMPJA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public JLDPKGEOPEJ receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LEOAEGKNMKP action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public FDKOMPLHOFH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x223B780", Offset = "0x223A180", VA = "0x18223B780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x223B960", Offset = "0x223A360", VA = "0x18223B960", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA57E20", Offset = "0xA56820", VA = "0x180A57E20", Slot = "4")]
		public NOPFJADADBI<KALLOEFFFCG> COFFCNLEALA(JLDPKGEOPEJ PHIEHPFGCDC)
		{
			return default(NOPFJADADBI<KALLOEFFFCG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2240A80", Offset = "0x223F480", VA = "0x182240A80", Slot = "5")]
		[AsyncStateMachine(typeof(APCPPBIMPJA))]
		public Task<OKPKCEBGDLD<object, NJDGKLFLKEH>> ANLMDFNDFNK(JLDPKGEOPEJ PHIEHPFGCDC, LEOAEGKNMKP EFFBNJEBEKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2240BB0", Offset = "0x223F5B0", VA = "0x182240BB0", Slot = "6")]
		public LEOAEGKNMKP[] HAIGEOJHPLK(JLDPKGEOPEJ PHIEHPFGCDC)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CBAEAIHCING : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<bool, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public JLDPKGEOPEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public FFCPEAHNOAD rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HGLHNOLHPNH circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public GOMCODJKDBA superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<OKPKCEBGDLD<bool, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x223CE10", Offset = "0x223B810", VA = "0x18223CE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x223D090", Offset = "0x223BA90", VA = "0x18223D090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct GMEFFJJPBOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<bool, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public JLDPKGEOPEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<OKPKCEBGDLD<bool, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2241340", Offset = "0x223FD40", VA = "0x182241340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x22415D0", Offset = "0x223FFD0", VA = "0x1822415D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct DCHGHIEALGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public JLDPKGEOPEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x223F340", Offset = "0x223DD40", VA = "0x18223F340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x223F520", Offset = "0x223DF20", VA = "0x18223F520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct IGGBANMFGCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public JLDPKGEOPEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public LEOAEGKNMKP action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2245800", Offset = "0x2244200", VA = "0x182245800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x22459F0", Offset = "0x22443F0", VA = "0x1822459F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct OOCJOAALJAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public JLDPKGEOPEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<OKPKCEBGDLD<bool, NJDGKLFLKEH>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x22569B0", Offset = "0x22553B0", VA = "0x1822569B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2257190", Offset = "0x2255B90", VA = "0x182257190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly NOPFJADADBI<KALLOEFFFCG> PLJIEEADMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JGFOCIAHLHI NOLOGJGEOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DCGFKNHENKC DJCNFDILEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly FLMLMIIOKLN BNDEBHHGFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19F8")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly LCDCFGGEMGL JCFIHKHJCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A00")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly BBILELNDAIN.DMGGKPEGCKJ DMKLNKJPLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly FDLMCKJJOHO AAAIDCAAHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly JCILFAKGKNH PGONCFAAHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly HPEBDPBEOPH AHGDHLOKEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly DNBFJONHIDO FODGOFKHPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private OLBCPDNHHLA HHKOGEDGOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private OCGBFJNLLFP GBPOGNBENHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly DCGFKNHENKC.CJMJGNBIOBJ PIIJNHMFLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly DAFAABOOGLG LIKJHJPJCDC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DCGFKNHENKC BGEPDFEAHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2252940", Offset = "0x2251340", VA = "0x182252940")]
		get
		{
			return default(DCGFKNHENKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal CHBJMGAGLKO IOPBIKJGIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2252110", Offset = "0x2250B10", VA = "0x182252110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal OBGADJKIEPI ADENCINHPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2252250", Offset = "0x2250C50", VA = "0x182252250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2252CC0", Offset = "0x22516C0", VA = "0x182252CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool CIEICMBDNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2252D60", Offset = "0x2251760", VA = "0x182252D60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2252930", Offset = "0x2251330", VA = "0x182252930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JKNBOABKICI DLNJDFFOPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2253070", Offset = "0x2251A70", VA = "0x182253070", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public OLOGJMHIMFO DKGJELLJBBE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2253080", Offset = "0x2251A80", VA = "0x182253080", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CPAJIKPNOIC DNMMECKJBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x22530A0", Offset = "0x2251AA0", VA = "0x1822530A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MLALCDMCJBA HPIHKGPODOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2253090", Offset = "0x2251A90", VA = "0x182253090", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public BBILELNDAIN? BAICKPPGPBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2251CA0", Offset = "0x22506A0", VA = "0x182251CA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private HILPPLCNLDH? HCEHJFGIKLB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2252670", Offset = "0x2251070", VA = "0x182252670", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2252D70", Offset = "0x2251770", VA = "0x182252D70")]
	private JLDPKGEOPEJ(LCDCFGGEMGL BNEOBONNMCF, NOPFJADADBI<KALLOEFFFCG> ECMIGICIFIJ, [In] JGFOCIAHLHI ONHMMADLDIM, [In] DCGFKNHENKC GBOBNFONAON, [In] FLMLMIIOKLN EJCIJAGKGKD, OBGADJKIEPI GMBIGMMKCKG, [In] BBILELNDAIN.DMGGKPEGCKJ NLACPIBPBNH, DCGFKNHENKC.CJMJGNBIOBJ HHEEADNNCDL, DAFAABOOGLG DICOIDCKLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2251B60", Offset = "0x2250560", VA = "0x182251B60")]
	public static JLDPKGEOPEJ AELHPDENENI(LCDCFGGEMGL JOIGIEDFOGO, [In] LFMNIANIILC DLACLBLPPCN, JOOIEPKJCLK KPLAJIGFGKB, [In] KCGMNLKLEDM JIJBLOLJIFL, CDAJKKDFAIC HKKKBDFNJGF, NOPFJADADBI<KALLOEFFFCG> ECMIGICIFIJ, NOPFJADADBI<LPFFLCAFHIH> GAAFPEEAKAI, OMACJOGKKEK MKLEBBHLOIA, CCHNALDBDNN BDEEPEGOOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2251880", Offset = "0x2250280", VA = "0x182251880")]
	public static JLDPKGEOPEJ AELHPDENENI(LCDCFGGEMGL BNEOBONNMCF, [In] DCGFKNHENKC GBOBNFONAON, [In] FLMLMIIOKLN EJCIJAGKGKD, NOPFJADADBI<KALLOEFFFCG> ECMIGICIFIJ, NOPFJADADBI<LPFFLCAFHIH> GAAFPEEAKAI, OMACJOGKKEK MKLEBBHLOIA, CCHNALDBDNN BDEEPEGOOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2251F20", Offset = "0x2250920", VA = "0x182251F20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2252B60", Offset = "0x2251560", VA = "0x182252B60")]
	[AsyncStateMachine(typeof(CBAEAIHCING))]
	internal Task<OKPKCEBGDLD<bool, NJDGKLFLKEH>> NMDDHNALABH(FFCPEAHNOAD JNFLHLMGFNO, HGLHNOLHPNH NJPLBJBINNG, GOMCODJKDBA FGOFNGOIJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2251E30", Offset = "0x2250830", VA = "0x182251E30")]
	[AsyncStateMachine(typeof(GMEFFJJPBOB))]
	public Task<OKPKCEBGDLD<bool, NJDGKLFLKEH>> BNIDKOLOKNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2252160", Offset = "0x2250B60", VA = "0x182252160")]
	[AsyncStateMachine(typeof(DCHGHIEALGA))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> GHGPNMFPKJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2252950", Offset = "0x2251350", VA = "0x182252950")]
	internal void KOLNNAEOEEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x22525F0", Offset = "0x2250FF0", VA = "0x1822525F0")]
	internal BHEDPLGAJGK<LEOAEGKNMKP> HKKGKMJBBNC([In] JOFNOFALIEA DMJHNBOAALO)
	{
		return default(BHEDPLGAJGK<LEOAEGKNMKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x22527A0", Offset = "0x22511A0", VA = "0x1822527A0")]
	internal bool HOENPKDJIAD([In] JOFNOFALIEA DMJHNBOAALO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2252CE0", Offset = "0x22516E0", VA = "0x182252CE0")]
	internal BHEDPLGAJGK<LEOAEGKNMKP> OJHLIBJPGOP([In] HFDFPMOKGOA LHOFGHCNKKE)
	{
		return default(BHEDPLGAJGK<LEOAEGKNMKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2251D20", Offset = "0x2250720", VA = "0x182251D20")]
	[AsyncStateMachine(typeof(IGGBANMFGCN))]
	internal Task<OKPKCEBGDLD<object, NJDGKLFLKEH>> BIOEOGKAKHE(LEOAEGKNMKP EFFBNJEBEKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2252260", Offset = "0x2250C60", VA = "0x182252260")]
	private LEOAEGKNMKP[] HAIGEOJHPLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2252810", Offset = "0x2251210", VA = "0x182252810")]
	[AsyncStateMachine(typeof(OOCJOAALJAF))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> IJKBLFCOGEF(Guid NKHPGMNAECN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class IEOFLJFCOPM
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2F22A80", Offset = "0x2F21480", VA = "0x182F22A80")]
	public static KGMOBFEKOEJ<(TPrev?, JLDPKGEOPEJ?), HILPPLCNLDH> BFPAMLKMNMI<TPrev>([In] this KGMOBFEKOEJ<TPrev, JLDPKGEOPEJ> PCBICLOONMH)
	{
		return default(KGMOBFEKOEJ<(TPrev, JLDPKGEOPEJ), HILPPLCNLDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2F22D40", Offset = "0x2F21740", VA = "0x182F22D40")]
	public static KGMOBFEKOEJ<TPrev?, JLDPKGEOPEJ?> JBJBGMNBHKD<TPrev>([In] this KGMOBFEKOEJ<TPrev, JLDPKGEOPEJ> PCBICLOONMH)
	{
		return default(KGMOBFEKOEJ<TPrev, JLDPKGEOPEJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class CKGPIPGOOMB<TData> : JMDMKJMGBCA, GKOEDJJEFMC, FMGMBNHPFJE where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LNNCPMKFMDI<HAPKHKKGAFF>? MHGLOHOLGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string DGDPHPLNONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData DKIFFIMODLG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LNNCPMKFMDI<HAPKHKKGAFF>? DFCOBGICFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2484340", Offset = "0x2482D40", VA = "0x182484340", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8AD960", Offset = "0x8AC360", VA = "0x1808AD960", Slot = "7")]
	public override string BGELNEMCJAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x560E550", Offset = "0x560CF50", VA = "0x18560E550")]
	internal CKGPIPGOOMB([In] LNNCPMKFMDI<HAPKHKKGAFF>? NJMEGNOFLFE, NOPFJADADBI<KLADBCIODBD>? NFNMHBPELDP, IOKind? PPACHHKIPIK, string FCMDIEEAPHD, [In] TData GGEMPJLCHFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HHHBNOMLPOP
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2244590", Offset = "0x2242F90", VA = "0x182244590")]
	public static OKPKCEBGDLD<ELAFKMOMAKO, GKOEDJJEFMC> GCGKLCHHMBB([In] this CFMNANCGFMM<DCCMDPBGLNC> PMKBJJOGLAF)
	{
		return default(OKPKCEBGDLD<ELAFKMOMAKO, GKOEDJJEFMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2F002C0", Offset = "0x2EFECC0", VA = "0x182F002C0")]
	public static OKPKCEBGDLD<TOk, GKOEDJJEFMC> JPBPPBCJKKJ<TOk>([In] this OKPKCEBGDLD<TOk, GKOEDJJEFMC> PCBICLOONMH, [In] LNNCPMKFMDI<HAPKHKKGAFF>? NJMEGNOFLFE, NOPFJADADBI<KLADBCIODBD>? NFNMHBPELDP, IOKind? PPACHHKIPIK, string FCMDIEEAPHD) where TOk : notnull
	{
		return default(OKPKCEBGDLD<TOk, GKOEDJJEFMC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LCDCFGGEMGL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	DMJNGOIAOHC.FCJBBPHLLNO LDEDJFFOIPE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	OLBHGBECMMG.MCBIGBAJFAD DNPJFLABDMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	JLDPKGEOPEJ.CHBJMGAGLKO EJCBJAKBMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	IDJCLNMJOJC.CPADEMNMGAP GNHMJHEJNBK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	APMCLBELNPF.GJEGCBPMDFF<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ> MNAKEBEOBEE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	BJOPPGIOJJG OABKILOKGJN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IKBBPNOAHAG MFMILMOKOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	BPGBGPDHDLL ILGCHKCGIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	PJOLGJFIIJJ HGIFJEJCGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	DLFDMIENOIH BIELAKJICMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OPGDECLMBPA
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x22572D0", Offset = "0x2255CD0", VA = "0x1822572D0")]
	public static LEOAEGKNMKP EHNBGJLHLGC(this LEOAEGKNMKP PCBICLOONMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2257200", Offset = "0x2255C00", VA = "0x182257200")]
	public static LEOAEGKNMKP BLJMMLCJCKM(this MHMHAJCCHLB PCBICLOONMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct MHMHAJCCHLB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct CHIKIFFEKEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public JLDPKGEOPEJ root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public MHMHAJCCHLB self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x223D170", Offset = "0x223BB70", VA = "0x18223D170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x223D430", Offset = "0x223BE30", VA = "0x18223D430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString IPHIEALFCML;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x957790", Offset = "0x956190", VA = "0x180957790")]
	private MHMHAJCCHLB(ByteString PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x22549D0", Offset = "0x22533D0", VA = "0x1822549D0")]
	public static LEOAEGKNMKP LPCGPAGPDOI(ByteString PKCLPFEIPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2254810", Offset = "0x2253210", VA = "0x182254810")]
	public static LJJMNEDJEOL<IHPBJPDOCPD, MHMHAJCCHLB> BELOOHDJHDJ(LEOAEGKNMKP OBBGJLGDAOG)
	{
		return default(LJJMNEDJEOL<IHPBJPDOCPD, MHMHAJCCHLB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x22548C0", Offset = "0x22532C0", VA = "0x1822548C0")]
	[AsyncStateMachine(typeof(CHIKIFFEKEC))]
	public static Task<OKPKCEBGDLD<object, NJDGKLFLKEH>> BIOEOGKAKHE(JLDPKGEOPEJ ELFANOAFHKM, MHMHAJCCHLB PCBICLOONMH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct FEGOCGKEDMC
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2240DD0", Offset = "0x223F7D0", VA = "0x182240DD0")]
	public static LEOAEGKNMKP LPCGPAGPDOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2240CE0", Offset = "0x223F6E0", VA = "0x182240CE0")]
	public static LJJMNEDJEOL<IHPBJPDOCPD, FEGOCGKEDMC> BELOOHDJHDJ(LEOAEGKNMKP OBBGJLGDAOG)
	{
		return default(LJJMNEDJEOL<IHPBJPDOCPD, FEGOCGKEDMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2240D50", Offset = "0x223F750", VA = "0x182240D50")]
	public static OKPKCEBGDLD<NEDLODCHJKB, GEKPLBFPNLN> JMMDEJACDLH(JLDPKGEOPEJ ELFANOAFHKM, [In] FEGOCGKEDMC PCBICLOONMH)
	{
		return default(OKPKCEBGDLD<NEDLODCHJKB, GEKPLBFPNLN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct BMPDIGLOKHH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct FJBDPLLABJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, GEKPLBFPNLN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public JLDPKGEOPEJ root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public BMPDIGLOKHH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private OKPKCEBGDLD<NEDLODCHJKB, GEKPLBFPNLN> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2240E70", Offset = "0x223F870", VA = "0x182240E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x22411E0", Offset = "0x223FBE0", VA = "0x1822411E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly FFCPEAHNOAD? KGJDHKOMKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly HGLHNOLHPNH? BMNNABFAHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly GOMCODJKDBA? JFIMGPFLONO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x21752A0", Offset = "0x2173CA0", VA = "0x1821752A0")]
	private BMPDIGLOKHH(FFCPEAHNOAD? JNFLHLMGFNO, HGLHNOLHPNH? NJPLBJBINNG, GOMCODJKDBA? FGOFNGOIJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x223C8F0", Offset = "0x223B2F0", VA = "0x18223C8F0")]
	public static LEOAEGKNMKP? LPCGPAGPDOI(FFCPEAHNOAD? JNFLHLMGFNO, HGLHNOLHPNH? NJPLBJBINNG, GOMCODJKDBA? FGOFNGOIJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x223C6A0", Offset = "0x223B0A0", VA = "0x18223C6A0")]
	public static LJJMNEDJEOL<IHPBJPDOCPD, BMPDIGLOKHH> BELOOHDJHDJ(LEOAEGKNMKP OBBGJLGDAOG)
	{
		return default(LJJMNEDJEOL<IHPBJPDOCPD, BMPDIGLOKHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x223C7B0", Offset = "0x223B1B0", VA = "0x18223C7B0")]
	[AsyncStateMachine(typeof(FJBDPLLABJJ))]
	public static Task<OKPKCEBGDLD<NEDLODCHJKB, GEKPLBFPNLN>> BIOEOGKAKHE(JLDPKGEOPEJ ELFANOAFHKM, BMPDIGLOKHH PCBICLOONMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct HKEBFILMBGO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct KEGAADFHABL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<GNOHPBEEOMG, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public HKEBFILMBGO self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public JLDPKGEOPEJ root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private OKPKCEBGDLD<GNOHPBEEOMG, NJDGKLFLKEH> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private OKPKCEBGDLD<object, FMGMBNHPFJE>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private OKPKCEBGDLD<object, FMGMBNHPFJE> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private OKPKCEBGDLD<object, FMGMBNHPFJE>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2253590", Offset = "0x2251F90", VA = "0x182253590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2253A00", Offset = "0x2252400", VA = "0x182253A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<LEOAEGKNMKP> HHOGJNBGFNH;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x957790", Offset = "0x956190", VA = "0x180957790")]
	private HKEBFILMBGO(IReadOnlyList<LEOAEGKNMKP> OHBFICNMFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2244C10", Offset = "0x2243610", VA = "0x182244C10")]
	public static LEOAEGKNMKP LPCGPAGPDOI(IReadOnlyList<LEOAEGKNMKP> OHBFICNMFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2244A30", Offset = "0x2243430", VA = "0x182244A30")]
	public static LJJMNEDJEOL<IHPBJPDOCPD, HKEBFILMBGO> BELOOHDJHDJ(LEOAEGKNMKP OBBGJLGDAOG)
	{
		return default(LJJMNEDJEOL<IHPBJPDOCPD, HKEBFILMBGO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2244AD0", Offset = "0x22434D0", VA = "0x182244AD0")]
	[AsyncStateMachine(typeof(KEGAADFHABL))]
	public static Task<OKPKCEBGDLD<GNOHPBEEOMG, NJDGKLFLKEH>> BIOEOGKAKHE(JLDPKGEOPEJ ELFANOAFHKM, HKEBFILMBGO PCBICLOONMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct HFDFPMOKGOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int HMLBKDIMLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int BPKEJBPHLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] DKIFFIMODLG;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x205EA70", Offset = "0x205D470", VA = "0x18205EA70")]
	private HFDFPMOKGOA(int FPDJICFHLGM, int GCBONJOGHCD, byte[] GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2241920", Offset = "0x2240320", VA = "0x182241920")]
	public static LEOAEGKNMKP LPCGPAGPDOI(int FPDJICFHLGM, int GCBONJOGHCD, ByteString GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2241A00", Offset = "0x2240400", VA = "0x182241A00")]
	public static LEOAEGKNMKP[] NHDFIECAOLI(LEOAEGKNMKP EFFBNJEBEKP, int ACCOHLFDNPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2241720", Offset = "0x2240120", VA = "0x182241720")]
	public static LJJMNEDJEOL<IHPBJPDOCPD, HFDFPMOKGOA> BELOOHDJHDJ(LEOAEGKNMKP OBBGJLGDAOG)
	{
		return default(LJJMNEDJEOL<IHPBJPDOCPD, HFDFPMOKGOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2241800", Offset = "0x2240200", VA = "0x182241800")]
	public static OKPKCEBGDLD<LEOAEGKNMKP, GEKPLBFPNLN> JMMDEJACDLH(JLDPKGEOPEJ ELFANOAFHKM, [In] HFDFPMOKGOA PCBICLOONMH)
	{
		return default(OKPKCEBGDLD<LEOAEGKNMKP, GEKPLBFPNLN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct JOFNOFALIEA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct IGBFAHLBMJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<bool, GEKPLBFPNLN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public JLDPKGEOPEJ root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public JOFNOFALIEA self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private OKPKCEBGDLD<bool, GEKPLBFPNLN> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, GEKPLBFPNLN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2245150", Offset = "0x2243B50", VA = "0x182245150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2245790", Offset = "0x2244190", VA = "0x182245790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int HMLBKDIMLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int BPKEJBPHLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] DKIFFIMODLG;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x205EA70", Offset = "0x205D470", VA = "0x18205EA70")]
	private JOFNOFALIEA(int FPDJICFHLGM, int GCBONJOGHCD, byte[] GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x22534B0", Offset = "0x2251EB0", VA = "0x1822534B0")]
	public static LEOAEGKNMKP LPCGPAGPDOI(int FPDJICFHLGM, int GCBONJOGHCD, ByteString GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x22530B0", Offset = "0x2251AB0", VA = "0x1822530B0")]
	public static LEOAEGKNMKP?[]? AMCKEPJDFAK(int ACCOHLFDNPL, FFCPEAHNOAD? JNFLHLMGFNO, HGLHNOLHPNH? NJPLBJBINNG, GOMCODJKDBA? FGOFNGOIJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x22532A0", Offset = "0x2251CA0", VA = "0x1822532A0")]
	public static LJJMNEDJEOL<IHPBJPDOCPD, JOFNOFALIEA> BELOOHDJHDJ(LEOAEGKNMKP OBBGJLGDAOG)
	{
		return default(LJJMNEDJEOL<IHPBJPDOCPD, JOFNOFALIEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2253380", Offset = "0x2251D80", VA = "0x182253380")]
	[AsyncStateMachine(typeof(IGBFAHLBMJO))]
	public static Task<OKPKCEBGDLD<bool, GEKPLBFPNLN>> BIOEOGKAKHE(JLDPKGEOPEJ ELFANOAFHKM, JOFNOFALIEA PCBICLOONMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FDLMCKJJOHO : JKNBOABKICI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly JLDPKGEOPEJ KFPFICPDKJB;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public PLNLJPOGEJD? JOLICDCBKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2240BD0", Offset = "0x223F5D0", VA = "0x182240BD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	internal FDLMCKJJOHO(JLDPKGEOPEJ DAKMLHHEJJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JBEDNHHMCBE : PLNLJPOGEJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly JLDPKGEOPEJ KFPFICPDKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly JOCBBAFBPMG PGBADDHHEEA;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0D0", Offset = "0x8B9AD0", VA = "0x1808BB0D0")]
	public JBEDNHHMCBE(JLDPKGEOPEJ DAKMLHHEJJO, JOCBBAFBPMG FBDHPFGDMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2251160", Offset = "0x224FB60", VA = "0x182251160", Slot = "4")]
	public OKPKCEBGDLD<ELAFKMOMAKO, GKOEDJJEFMC> DMDHPODAABE(LNNCPMKFMDI<HAPKHKKGAFF> ICBLLOEAIEO, NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, NOPFJADADBI<LLAADLDMCOH> HLGPBDONICD)
	{
		return default(OKPKCEBGDLD<ELAFKMOMAKO, GKOEDJJEFMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2251440", Offset = "0x224FE40", VA = "0x182251440", Slot = "5")]
	public OKPKCEBGDLD<ELAFKMOMAKO, GKOEDJJEFMC> HNFBIKGMHPM(LNNCPMKFMDI<HAPKHKKGAFF> ICBLLOEAIEO, NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, NOPFJADADBI<LKGHPCANGJP> AIAAIMOKNLI)
	{
		return default(OKPKCEBGDLD<ELAFKMOMAKO, GKOEDJJEFMC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DMJNGOIAOHC : ELLHCHFCEGM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface FCJBBPHLLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<JOCBBAFBPMG> DICONEJEJLF(JLDPKGEOPEJ DAKMLHHEJJO, HGLHNOLHPNH? KALBKDCEBCJ, GOMCODJKDBA? COGLANFHEFJ, CancellationToken PPLDCJFFMEP);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IBBIHENBHNA NNIJHCBGODG(JLDPKGEOPEJ DAKMLHHEJJO, FFCPEAHNOAD PFPJHAJKIGP);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class FDCOHIBHKJE : FCJBBPHLLNO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct LMIJAFIDGIA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<JOCBBAFBPMG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public JLDPKGEOPEJ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public HGLHNOLHPNH cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public GOMCODJKDBA cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<IDJCLNMJOJC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2253F30", Offset = "0x2252930", VA = "0x182253F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2254100", Offset = "0x2252B00", VA = "0x182254100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly FDCOHIBHKJE JOLICDCBKGF;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		private FDCOHIBHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2240890", Offset = "0x223F290", VA = "0x182240890", Slot = "4")]
		[AsyncStateMachine(typeof(LMIJAFIDGIA))]
		public Task<JOCBBAFBPMG> DICONEJEJLF(JLDPKGEOPEJ DAKMLHHEJJO, HGLHNOLHPNH? KALBKDCEBCJ, GOMCODJKDBA? COGLANFHEFJ, CancellationToken PPLDCJFFMEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x22409F0", Offset = "0x223F3F0", VA = "0x1822409F0", Slot = "5")]
		public IBBIHENBHNA NNIJHCBGODG(JLDPKGEOPEJ DAKMLHHEJJO, FFCPEAHNOAD PFPJHAJKIGP)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct BABDBJMLLHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<DMJNGOIAOHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public JLDPKGEOPEJ circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public HGLHNOLHPNH cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public GOMCODJKDBA cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public FFCPEAHNOAD evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private FCJBBPHLLNO <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<JOCBBAFBPMG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x223B9D0", Offset = "0x223A3D0", VA = "0x18223B9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x223BED0", Offset = "0x223A8D0", VA = "0x18223BED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly JOCBBAFBPMG PGBADDHHEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly IBBIHENBHNA PGDMHEHLBBP;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public BBILELNDAIN BAICKPPGPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x223F840", Offset = "0x223E240", VA = "0x18223F840", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public HILPPLCNLDH GDFGLGAPDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x223FA60", Offset = "0x223E460", VA = "0x18223FA60", Slot = "5")]
		get
		{
			return default(HILPPLCNLDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public JBEDNHHMCBE MJKDKPMNBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public KEPFFHKMNMG ILMJMLCHJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xAF0B70", Offset = "0xAEF570", VA = "0x180AF0B70")]
	private DMJNGOIAOHC(JOCBBAFBPMG FBDHPFGDMMF, IBBIHENBHNA GFAAECGNFOC, JBEDNHHMCBE LIIIBCNGILE, KEPFFHKMNMG OPDGDBDDOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x223F890", Offset = "0x223E290", VA = "0x18223F890")]
	[AsyncStateMachine(typeof(BABDBJMLLHD))]
	public static Task<DMJNGOIAOHC> BFCFOJCNLLC(JLDPKGEOPEJ DAKMLHHEJJO, FFCPEAHNOAD PFPJHAJKIGP, HGLHNOLHPNH? KALBKDCEBCJ, GOMCODJKDBA? COGLANFHEFJ, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x223FA00", Offset = "0x223E400", VA = "0x18223FA00", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class OLBHGBECMMG : OBGADJKIEPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface MCBIGBAJFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<ELLHCHFCEGM> GINGLIGNFJK(JLDPKGEOPEJ DAKMLHHEJJO, FFCPEAHNOAD PFPJHAJKIGP, HGLHNOLHPNH? KALBKDCEBCJ, GOMCODJKDBA? COGLANFHEFJ, CancellationToken PPLDCJFFMEP);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CFKOFNCFGJK();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EAJGDFGODAB();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class LGLNBFCHOCC : MCBIGBAJFAD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct PCGAFLKKCLN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<ELLHCHFCEGM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public JLDPKGEOPEJ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public FFCPEAHNOAD evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public HGLHNOLHPNH cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public GOMCODJKDBA cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<DMJNGOIAOHC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2257740", Offset = "0x2256140", VA = "0x182257740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2257A80", Offset = "0x2256480", VA = "0x182257A80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x2253AD0", Offset = "0x22524D0", VA = "0x182253AD0", Slot = "4")]
		[AsyncStateMachine(typeof(PCGAFLKKCLN))]
		public Task<ELLHCHFCEGM> GINGLIGNFJK(JLDPKGEOPEJ DAKMLHHEJJO, FFCPEAHNOAD PFPJHAJKIGP, HGLHNOLHPNH? KALBKDCEBCJ, GOMCODJKDBA? COGLANFHEFJ, CancellationToken PPLDCJFFMEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void CFKOFNCFGJK();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void EAJGDFGODAB();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		protected LGLNBFCHOCC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct HLNBLCAICDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<ELLHCHFCEGM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public OLBHGBECMMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<NEDLODCHJKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2244CD0", Offset = "0x22436D0", VA = "0x182244CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2244ED0", Offset = "0x22438D0", VA = "0x182244ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct EPIFHEJLLCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public OLBHGBECMMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public JLDPKGEOPEJ circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public FFCPEAHNOAD evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public HGLHNOLHPNH cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public GOMCODJKDBA cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<ELLHCHFCEGM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x22402F0", Offset = "0x223ECF0", VA = "0x1822402F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2240830", Offset = "0x223F230", VA = "0x182240830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly MCBIGBAJFAD HMOBFPGDOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<NEDLODCHJKB> HEAHLBPCKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<NEDLODCHJKB> LLAKPMPOCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource NIIFONANOKP;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool CIEICMBDNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x964220", Offset = "0x962C20", VA = "0x180964220", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9630A0", Offset = "0x961AA0", VA = "0x1809630A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NPNEBPFKOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x96CF50", Offset = "0x96B950", VA = "0x18096CF50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xE2AE10", Offset = "0xE29810", VA = "0x180E2AE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DKIHLPICPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x145A7C0", Offset = "0x14591C0", VA = "0x18145A7C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2256890", Offset = "0x2255290", VA = "0x182256890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ELLHCHFCEGM? NPHOHPJHHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8AD530", Offset = "0x8ABF30", VA = "0x1808AD530", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8B00F0", Offset = "0x8AEAF0", VA = "0x1808B00F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x22564C0", Offset = "0x2254EC0", VA = "0x1822564C0", Slot = "7")]
	[AsyncStateMachine(typeof(HLNBLCAICDH))]
	public Task<ELLHCHFCEGM> ALJOIPPMJIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x22568A0", Offset = "0x22552A0", VA = "0x1822568A0")]
	public OLBHGBECMMG(MCBIGBAJFAD JOIGIEDFOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2256730", Offset = "0x2255130", VA = "0x182256730", Slot = "8")]
	[AsyncStateMachine(typeof(EPIFHEJLLCH))]
	public Task FLGHKFDPMLM(JLDPKGEOPEJ DAKMLHHEJJO, FFCPEAHNOAD PFPJHAJKIGP, HGLHNOLHPNH? KALBKDCEBCJ, GOMCODJKDBA? COGLANFHEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x22565B0", Offset = "0x2254FB0", VA = "0x1822565B0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class MHAPPAFBHLJ : LDMIAKDHCOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly KEPFFHKMNMG FDHKOEEIIGN;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	public MHAPPAFBHLJ(KEPFFHKMNMG OPDGDBDDOEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class AFHKIKEBCHH
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class ECNOHKNCIPO<TGraph> : KJCBGHAGEHM where TGraph : AMDCMDNINOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph CHOEJGOMGGO;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual BJBNDDINLPO? IOCNIEHMEBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x1274F30", Offset = "0x1273930", VA = "0x181274F30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public NOPFJADADBI<AEAAGMJLLLI> GBBAEGKGHJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x3B65540", Offset = "0x3B63F40", VA = "0x183B65540", Slot = "5")]
			get
			{
				return default(NOPFJADADBI<AEAAGMJLLLI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public NOPFJADADBI<AEAAGMJLLLI>? GNOOHCKNMBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3B65560", Offset = "0x3B63F60", VA = "0x183B65560", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
		public ECNOHKNCIPO(TGraph ADJABNNJNMI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class AMGCBICLPLM : ECNOHKNCIPO<OJDOEJMJCDE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override BJBNDDINLPO? IOCNIEHMEBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x223B690", Offset = "0x223A090", VA = "0x18223B690", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x223B6B0", Offset = "0x223A0B0", VA = "0x18223B6B0")]
		public AMGCBICLPLM(OJDOEJMJCDE MGMCLEKAJMH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x223A9C0", Offset = "0x22393C0", VA = "0x18223A9C0")]
	public static KJCBGHAGEHM AELHPDENENI(AMDCMDNINOO ADJABNNJNMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class HGKNBEFOHOK : IDKLBBDALLD, OGIGJDHBOLA, DNCDFCBKAAH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class FOLDLOHHBJE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public FOLDLOHHBJE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public BJOPPGIOJJG errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x2257D90", Offset = "0x2256790", VA = "0x182257D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2258000", Offset = "0x2256A00", VA = "0x182258000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public HGKNBEFOHOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public FOLDLOHHBJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2241250", Offset = "0x223FC50", VA = "0x182241250")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task IPKNMKIPKEA(BJOPPGIOJJG errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct EMNDOLDPDLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public HGKNBEFOHOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x223FB20", Offset = "0x223E520", VA = "0x18223FB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2240030", Offset = "0x223EA30", VA = "0x182240030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class JJPMKGBPDCF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public JJPMKGBPDCF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2258060", Offset = "0x2256A60", VA = "0x182258060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2258340", Offset = "0x2256D40", VA = "0x182258340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public HGKNBEFOHOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public JJPMKGBPDCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x22517B0", Offset = "0x22501B0", VA = "0x1822517B0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task GPFNCIHFGOH(BJOPPGIOJJG errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly ILKNMOMCCKI JBNJHELOPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<BCFACBBBDNM> FBELALLEPFG;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private LCDCFGGEMGL NEHPFNJEPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2243240", Offset = "0x2241C40", VA = "0x182243240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public NOPFJADADBI<LLAADLDMCOH> DKLHNKGHIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xAAB740", Offset = "0xAAA140", VA = "0x180AAB740", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(NOPFJADADBI<LLAADLDMCOH>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAABCC0", Offset = "0xAAA6C0", VA = "0x180AABCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private NOPFJADADBI<JDCGCGCDEHJ> OJOGPHLNOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xE00400", Offset = "0xDFEE00", VA = "0x180E00400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public NOPFJADADBI<KPPIPHEEJHD> KCGGAFLMGLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FC0", Offset = "0x8D29C0", VA = "0x1808D3FC0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(NOPFJADADBI<KPPIPHEEJHD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override NOPFJADADBI<KLADBCIODBD> HJMOFBBNEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2241F30", Offset = "0x2240930", VA = "0x182241F30", Slot = "20")]
		get
		{
			return default(NOPFJADADBI<KLADBCIODBD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool MFNBIPCPAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2243FE0", Offset = "0x22429E0", VA = "0x182243FE0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2244370", Offset = "0x2242D70", VA = "0x182244370")]
	private HGKNBEFOHOK(JLDPKGEOPEJ DAKMLHHEJJO, AELHMIHCAOH OFGAFPGJIKO, ILKNMOMCCKI DMKABFHHIBF, NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, NOPFJADADBI<LLAADLDMCOH> HLGPBDONICD, NOPFJADADBI<JDCGCGCDEHJ> GBNOGMDLOKK, bool DCBNNAGJMNJ, string JHJFHDOAMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2241B80", Offset = "0x2240580", VA = "0x182241B80")]
	public static HGKNBEFOHOK AELHPDENENI(JLDPKGEOPEJ DAKMLHHEJJO, AELHMIHCAOH OFGAFPGJIKO, ILKNMOMCCKI CPOLINJHFNA, NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, NOPFJADADBI<JDCGCGCDEHJ> GBNOGMDLOKK, NOPFJADADBI<LLAADLDMCOH> HLGPBDONICD, bool DCBNNAGJMNJ, bool IDACGFEICKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2242980", Offset = "0x2241380", VA = "0x182242980", Slot = "21")]
	protected override void GCHKJEOLKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x22421F0", Offset = "0x2240BF0", VA = "0x1822421F0", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x22424C0", Offset = "0x2240EC0", VA = "0x1822424C0", Slot = "30")]
	public void ECDFGINEIAE(BCFACBBBDNM FFBIKDDJCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2242A20", Offset = "0x2241420", VA = "0x182242A20", Slot = "27")]
	public void GHBPAOBAJPC(FNBEFHJFHEC HDJMDLOBKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x22433F0", Offset = "0x2241DF0", VA = "0x1822433F0", Slot = "28")]
	public void MBJNOFJDAHB(LPKMJHIJGGD DAENABOJLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x22430F0", Offset = "0x2241AF0", VA = "0x1822430F0", Slot = "23")]
	protected override void JFOJDGLOHDO(HNFOBOHIGFL MOPHMGOOGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2244060", Offset = "0x2242A60", VA = "0x182244060", Slot = "32")]
	public string NEIPEBEBIAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x22426C0", Offset = "0x22410C0", VA = "0x1822426C0", Slot = "29")]
	public string FHGBMDKCGPD(int FGAJAFBGABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2242290", Offset = "0x2240C90", VA = "0x182242290")]
	private void ECAGJLKFBBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x22441D0", Offset = "0x2242BD0", VA = "0x1822441D0", Slot = "31")]
	public void OKHIHKEAGAI(BCFACBBBDNM FFBIKDDJCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2242F30", Offset = "0x2241930", VA = "0x182242F30")]
	private void JBONOJNLKLK(bool PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2242E20", Offset = "0x2241820", VA = "0x182242E20", Slot = "33")]
	[AsyncStateMachine(typeof(EMNDOLDPDLJ))]
	public Task IKHLNECJMNK(string PKCLPFEIPFH, bool MHHNCEBFOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2241F80", Offset = "0x2240980", VA = "0x182241F80")]
	public void BOHGCNONNMK(string PKCLPFEIPFH, bool MHHNCEBFOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2242520", Offset = "0x2240F20", VA = "0x182242520")]
	private void EGIJNGKPBNF(int PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xAABCC0", Offset = "0xAAA6C0", VA = "0x180AABCC0")]
	internal void GDDHIGECCDK(NOPFJADADBI<LLAADLDMCOH> PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x22441C0", Offset = "0x2242BC0", VA = "0x1822441C0")]
	[CompilerGenerated]
	private void NGAFLJILFEE(string PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2243D90", Offset = "0x2242790", VA = "0x182243D90")]
	[CompilerGenerated]
	private bool MKKOGKENABG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2243260", Offset = "0x2241C60", VA = "0x182243260")]
	[CompilerGenerated]
	private bool JLKNJPEODLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x22433A0", Offset = "0x2241DA0", VA = "0x1822433A0")]
	[CompilerGenerated]
	private int LNIEIBHINIA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2242160", Offset = "0x2240B60", VA = "0x182242160")]
	[CompilerGenerated]
	private bool DBGMLMMCABK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2242D90", Offset = "0x2241790", VA = "0x182242D90")]
	[CompilerGenerated]
	private void HFGPGAMBDIC(string PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2243E50", Offset = "0x2242850", VA = "0x182243E50")]
	[CompilerGenerated]
	private bool MLHIIMDEKFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2241B30", Offset = "0x2240530", VA = "0x182241B30")]
	[CompilerGenerated]
	private bool AAIMINLNNKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x22420D0", Offset = "0x2240AD0", VA = "0x1822420D0")]
	[CompilerGenerated]
	private bool CCHOAGCNLIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x22433A0", Offset = "0x2241DA0", VA = "0x1822433A0")]
	[CompilerGenerated]
	private int NADAFBNCBOI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x22442A0", Offset = "0x2242CA0", VA = "0x1822442A0")]
	[CompilerGenerated]
	private bool POHEHNICMJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2243320", Offset = "0x2241D20", VA = "0x182243320")]
	[CompilerGenerated]
	private object KIMIKLMANPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2242DA0", Offset = "0x22417A0", VA = "0x182242DA0")]
	[CompilerGenerated]
	private void IJNHKDIBOMM(object PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2243F10", Offset = "0x2242910", VA = "0x182243F10")]
	[CompilerGenerated]
	private bool MOHADFBALEA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class NDNPOHEOILC
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private sealed class LLMFFNODKNN : CLCKKODOECE<GJBHHCBJLKC>
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class CAHJOBOENAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public LLMFFNODKNN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public CAHJOBOENAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x223CDA0", Offset = "0x223B7A0", VA = "0x18223CDA0")]
			internal object PCAMJMMFJCO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x223CCD0", Offset = "0x223B6D0", VA = "0x18223CCD0")]
			internal void CLCMLCCEFKP(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2253EC0", Offset = "0x22528C0", VA = "0x182253EC0")]
		public LLMFFNODKNN(JLDPKGEOPEJ DAKMLHHEJJO, GJBHHCBJLKC OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2253C30", Offset = "0x2252630", VA = "0x182253C30", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class MGPNPNGACOM : GOBEILMFPDJ<GGHABJFIIGK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override BMCMNKGELFP EJJMAPJLIIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x93C4F0", Offset = "0x93AEF0", VA = "0x18093C4F0", Slot = "128")]
			get
			{
				return default(BMCMNKGELFP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x22547B0", Offset = "0x22531B0", VA = "0x1822547B0")]
		public MGPNPNGACOM(JLDPKGEOPEJ DAKMLHHEJJO, GGHABJFIIGK OAAFMJBAJGL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class OPJDBOAALLM : CLCKKODOECE<JDKBMAMGGJC>
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x22576D0", Offset = "0x22560D0", VA = "0x1822576D0")]
		public OPJDBOAALLM(JLDPKGEOPEJ DAKMLHHEJJO, JDKBMAMGGJC OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x22573E0", Offset = "0x2255DE0", VA = "0x1822573E0", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2257560", Offset = "0x2255F60", VA = "0x182257560")]
		[CompilerGenerated]
		private bool LEJPMIGELAD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x22575B0", Offset = "0x2255FB0", VA = "0x1822575B0")]
		[CompilerGenerated]
		private void MCDKNCLOGCA(bool PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class MDMEGAHNIEM : CLCKKODOECE<CGCNOBKOGGF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class EOLLKLCGEGC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public MDMEGAHNIEM <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public EOLLKLCGEGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x22402A0", Offset = "0x223ECA0", VA = "0x1822402A0")]
			internal void PCAMJMMFJCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x22400E0", Offset = "0x223EAE0", VA = "0x1822400E0")]
			internal bool CLCMLCCEFKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2240090", Offset = "0x223EA90", VA = "0x182240090")]
			internal bool CJLHFJFDNAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2240130", Offset = "0x223EB30", VA = "0x182240130")]
			internal void MKKNACCAEML(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2240250", Offset = "0x223EC50", VA = "0x182240250")]
			internal bool NDPCAAEAIOM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2254740", Offset = "0x2253140", VA = "0x182254740")]
		public MDMEGAHNIEM(JLDPKGEOPEJ DAKMLHHEJJO, CGCNOBKOGGF OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2254400", Offset = "0x2252E00", VA = "0x182254400", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class IPBLNMDBIDL : CLCKKODOECE<AHPDNJFOBGB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class BLALPPKCGLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public IPBLNMDBIDL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public BLALPPKCGLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x223C5A0", Offset = "0x223AFA0", VA = "0x18223C5A0")]
			internal object PCAMJMMFJCO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x223C520", Offset = "0x223AF20", VA = "0x18223C520")]
			internal bool PBCPLFKNLHM(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x223C0F0", Offset = "0x223AAF0", VA = "0x18223C0F0")]
			internal void CLCMLCCEFKP(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x223BF90", Offset = "0x223A990", VA = "0x18223BF90")]
			internal string CJLHFJFDNAK(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x223C460", Offset = "0x223AE60", VA = "0x18223C460")]
			internal IReadOnlyList<object> MKKNACCAEML()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x223C4B0", Offset = "0x223AEB0", VA = "0x18223C4B0")]
			internal bool NDPCAAEAIOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x223BF40", Offset = "0x223A940", VA = "0x18223BF40")]
			internal bool BCDMOLLGAEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x223C340", Offset = "0x223AD40", VA = "0x18223C340")]
			internal void ICGFCKNGHHJ(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x22510F0", Offset = "0x224FAF0", VA = "0x1822510F0")]
		public IPBLNMDBIDL(JLDPKGEOPEJ DAKMLHHEJJO, AHPDNJFOBGB OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2250990", Offset = "0x224F390", VA = "0x182250990", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class PJAEABHEDFH : CLCKKODOECE<FNHCCCBMCCB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class BPBIJHOJEEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public PJAEABHEDFH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public BPBIJHOJEEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x223CB60", Offset = "0x223B560", VA = "0x18223CB60")]
			internal bool PCAMJMMFJCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x223CA40", Offset = "0x223B440", VA = "0x18223CA40")]
			internal void CLCMLCCEFKP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x223C9F0", Offset = "0x223B3F0", VA = "0x18223C9F0")]
			internal bool CJLHFJFDNAK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2257D20", Offset = "0x2256720", VA = "0x182257D20")]
		public PJAEABHEDFH(JLDPKGEOPEJ DAKMLHHEJJO, FNHCCCBMCCB OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2257AF0", Offset = "0x22564F0", VA = "0x182257AF0", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class GJOBNMEDLBN<TNode> : CLCKKODOECE<TNode> where TNode : notnull, FIGEIBCEGPP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct KOOHMLMMIHK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public AsyncTaskMethodBuilder<OKPKCEBGDLD<NOPFJADADBI<IMNAGMIGBGO>, NJDGKLFLKEH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public GJOBNMEDLBN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<OKPKCEBGDLD<NOPFJADADBI<IMNAGMIGBGO>, NJDGKLFLKEH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x45D7B40", Offset = "0x45D6540", VA = "0x1845D7B40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x45D7F40", Offset = "0x45D6940", VA = "0x1845D7F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct MKODIHNBKDP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public GJOBNMEDLBN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public NOPFJADADBI<IMNAGMIGBGO> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x48C4730", Offset = "0x48C3130", VA = "0x1848C4730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x48C4B30", Offset = "0x48C3530", VA = "0x1848C4B30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool DNJHDJOPIFA
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override NOPFJADADBI<IMNAGMIGBGO>? NLCDLGOBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x4110A90", Offset = "0x410F490", VA = "0x184110A90", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4110A40", Offset = "0x410F440", VA = "0x184110A40")]
		protected GJOBNMEDLBN(JLDPKGEOPEJ DAKMLHHEJJO, TNode OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4110770", Offset = "0x410F170", VA = "0x184110770", Slot = "102")]
		[AsyncStateMachine(typeof(GJOBNMEDLBN<>.KOOHMLMMIHK))]
		public override Task<OKPKCEBGDLD<NOPFJADADBI<IMNAGMIGBGO>, NJDGKLFLKEH>> EMDJAKPEBAG(string JHJFHDOAMLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x41109A0", Offset = "0x410F3A0", VA = "0x1841109A0", Slot = "126")]
		public sealed override bool LCONFNGKJMP(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x41106D0", Offset = "0x410F0D0", VA = "0x1841106D0", Slot = "114")]
		protected sealed override bool ECHALLHFPKP(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4110630", Offset = "0x410F030", VA = "0x184110630", Slot = "115")]
		protected override bool AMAFGAPLGEP(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4110890", Offset = "0x410F290", VA = "0x184110890", Slot = "103")]
		[AsyncStateMachine(typeof(GJOBNMEDLBN<>.MKODIHNBKDP))]
		public override Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> FFHMIAMHCEJ(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public sealed class DHCAFGKMKOI : KKHNKODEBNA<COHIMGAOAKB>
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class NFLNLJBNMIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public DHCAFGKMKOI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public NFLNLJBNMIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x2256000", Offset = "0x2254A00", VA = "0x182256000")]
			internal bool HOLGDMEPDKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x2256080", Offset = "0x2254A80", VA = "0x182256080")]
			internal void OJEKBMOIIEL(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x223F7E0", Offset = "0x223E1E0", VA = "0x18223F7E0")]
		public DHCAFGKMKOI(JLDPKGEOPEJ DAKMLHHEJJO, COHIMGAOAKB OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x223F590", Offset = "0x223DF90", VA = "0x18223F590", Slot = "128")]
		protected override void LBBFKPDLJNI(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class NIJIBEELNFF : JJMFPJJAEIG<EIEKPNOOALG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x941F40", Offset = "0x940940", VA = "0x180941F40", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2256140", Offset = "0x2254B40", VA = "0x182256140")]
		public NIJIBEELNFF(JLDPKGEOPEJ DAKMLHHEJJO, EIEKPNOOALG OFGAFPGJIKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public abstract class JJMFPJJAEIG<TNode> : CLCKKODOECE<TNode> where TNode : notnull, KONCBKPGJLF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct HGGKEPNDHAE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public AsyncTaskMethodBuilder<OKPKCEBGDLD<NOPFJADADBI<IMNAGMIGBGO>, NJDGKLFLKEH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public JJMFPJJAEIG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private TaskAwaiter<OKPKCEBGDLD<NOPFJADADBI<IMNAGMIGBGO>, NJDGKLFLKEH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x417AE00", Offset = "0x4179800", VA = "0x18417AE00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x417B2C0", Offset = "0x4179CC0", VA = "0x18417B2C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct JLEBMBCPEAC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public JJMFPJJAEIG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public NOPFJADADBI<IMNAGMIGBGO> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x443C630", Offset = "0x443B030", VA = "0x18443C630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x443CA40", Offset = "0x443B440", VA = "0x18443CA40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct FHOLHGGJOMP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public AsyncTaskMethodBuilder<OKPKCEBGDLD<GNOHPBEEOMG, NJDGKLFLKEH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public JJMFPJJAEIG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private TaskAwaiter<OKPKCEBGDLD<GNOHPBEEOMG, NJDGKLFLKEH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3FAA7A0", Offset = "0x3FA91A0", VA = "0x183FAA7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x3FAAE80", Offset = "0x3FA9880", VA = "0x183FAAE80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class PCMBFNIFCPH
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000052")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public PCMBFNIFCPH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000154")]
				[Cpp2IlInjected.Address(RVA = "0x38C6D40", Offset = "0x38C5740", VA = "0x1838C6D40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000155")]
				[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public GKGPCBCAOGC configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public JJMFPJJAEIG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public PCMBFNIFCPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x4B55F90", Offset = "0x4B54990", VA = "0x184B55F90")]
			internal bool ICGFCKNGHHJ(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x4B56110", Offset = "0x4B54B10", VA = "0x184B56110")]
			internal void PCAMJMMFJCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4B56070", Offset = "0x4B54A70", VA = "0x184B56070")]
			[AsyncStateMachine(typeof(JJMFPJJAEIG<>.PCMBFNIFCPH.<<BuildConfigMenuInternal>b__7>d))]
			internal void PBCPLFKNLHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x4B55B80", Offset = "0x4B54580", VA = "0x184B55B80")]
			internal bool CLCMLCCEFKP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class FIDCLBDEKCA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000054")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public FIDCLBDEKCA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x38C69C0", Offset = "0x38C53C0", VA = "0x1838C69C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public PCMBFNIFCPH CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public FIDCLBDEKCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x3FAE300", Offset = "0x3FACD00", VA = "0x183FAE300")]
			internal void CJLHFJFDNAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
			internal string MKKNACCAEML()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
			internal void NDPCAAEAIOM(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3FAE260", Offset = "0x3FACC60", VA = "0x183FAE260")]
			[AsyncStateMachine(typeof(JJMFPJJAEIG<>.FIDCLBDEKCA.<<BuildConfigMenuInternal>b__5>d))]
			internal void BCDMOLLGAEC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class MLCDPHMABGO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000056")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public MLCDPHMABGO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x38C64F0", Offset = "0x38C4EF0", VA = "0x1838C64F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000057")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public MLCDPHMABGO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				private TaskAwaiter<OKPKCEBGDLD<NOPFJADADBI<JDCGCGCDEHJ>, NJDGKLFLKEH>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0x38C66D0", Offset = "0x38C50D0", VA = "0x1838C66D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public MLCDPHMABGO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				private TaskAwaiter<OKPKCEBGDLD<NOPFJADADBI<HDHAJHHMIEL>, NJDGKLFLKEH>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x38C5E20", Offset = "0x38C4820", VA = "0x1838C5E20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public JJMFPJJAEIG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public NOPFJADADBI<IMNAGMIGBGO> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public GKGPCBCAOGC configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public JGOIMAGMGIM nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public FMKOOFOBEMG selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public List<LEJADFKGGMP> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public FMKOOFOBEMG selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public List<LEJADFKGGMP> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public MLCDPHMABGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x48C52F0", Offset = "0x48C3CF0", VA = "0x1848C52F0")]
			internal bool PIIHECNIGGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x48C4FC0", Offset = "0x48C39C0", VA = "0x1848C4FC0")]
			internal void HKAKJEIGMHP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x48C5210", Offset = "0x48C3C10", VA = "0x1848C5210")]
			internal bool PABPDNAKNKA(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x48C4CC0", Offset = "0x48C36C0", VA = "0x1848C4CC0")]
			internal bool EBCEHPNFBMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x48C4F20", Offset = "0x48C3920", VA = "0x1848C4F20")]
			[AsyncStateMachine(typeof(JJMFPJJAEIG<>.MLCDPHMABGO.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void HIOBHJEBBMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x48C4C10", Offset = "0x48C3610", VA = "0x1848C4C10")]
			internal bool ANJDFJKHECO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x48C4DA0", Offset = "0x48C37A0", VA = "0x1848C4DA0")]
			internal void HCGGLJGOGHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x48C5360", Offset = "0x48C3D60", VA = "0x1848C5360")]
			internal bool PJGHOMILBLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x48C4E60", Offset = "0x48C3860", VA = "0x1848C4E60")]
			internal void HCODNHOAJOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x48C5470", Offset = "0x48C3E70", VA = "0x1848C5470")]
			internal bool PNMFOFIENBN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x48C4BA0", Offset = "0x48C35A0", VA = "0x1848C4BA0")]
			internal bool AMLMNAEGKLC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x48C51A0", Offset = "0x48C3BA0", VA = "0x1848C51A0")]
			internal void LOIPBJIFDMO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x48C5100", Offset = "0x48C3B00", VA = "0x1848C5100")]
			[AsyncStateMachine(typeof(JJMFPJJAEIG<>.MLCDPHMABGO.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void JHPMMLKBFIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x48C50A0", Offset = "0x48C3AA0", VA = "0x1848C50A0")]
			internal bool IJGAFLEKLHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x48C4C50", Offset = "0x48C3650", VA = "0x1848C4C50")]
			internal bool BEFCNNHIPML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x48C5030", Offset = "0x48C3A30", VA = "0x1848C5030")]
			internal void IDKHHIAEFKK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x48C4D00", Offset = "0x48C3700", VA = "0x1848C4D00")]
			[AsyncStateMachine(typeof(JJMFPJJAEIG<>.MLCDPHMABGO.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void EMIMFBALGHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x48C5410", Offset = "0x48C3E10", VA = "0x1848C5410")]
			internal bool PNHCODPOEOM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class GBJIEFLDBDI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005A")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public GBJIEFLDBDI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x38C6110", Offset = "0x38C4B10", VA = "0x1838C6110", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public MLCDPHMABGO CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public GBJIEFLDBDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x40D3C00", Offset = "0x40D2600", VA = "0x1840D3C00")]
			internal void LHCCBOCNMFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
			internal string BMGFNCHECCE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
			internal void FCKANDCCLIF(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x40D3B60", Offset = "0x40D2560", VA = "0x1840D3B60")]
			[AsyncStateMachine(typeof(JJMFPJJAEIG<>.GBJIEFLDBDI.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void IMKKHDKIJJH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class GDINBBEJFEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public JGOIMAGMGIM nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public List<LEJADFKGGMP> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public JJMFPJJAEIG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public NOPFJADADBI<IMNAGMIGBGO> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public GDINBBEJFEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x40DECB0", Offset = "0x40DD6B0", VA = "0x1840DECB0")]
			internal bool LGCKLKJBJCA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class OMDACIABLHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public DNCDFCBKAAH port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public GDINBBEJFEP CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public OMDACIABLHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4ABB8C0", Offset = "0x4ABA2C0", VA = "0x184ABB8C0")]
			internal void KLBBMCMLLLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x4ABB870", Offset = "0x4ABA270", VA = "0x184ABB870")]
			internal bool HEMIKBAOBJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4ABB750", Offset = "0x4ABA150", VA = "0x184ABB750")]
			internal void ADOLEFPPGDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x4ABB9D0", Offset = "0x4ABA3D0", VA = "0x184ABB9D0")]
			internal bool LLFFIMCIDNN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class NCNKBCDFNIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public LEJADFKGGMP portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public OMDACIABLHC CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public NCNKBCDFNIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x4914B50", Offset = "0x4913550", VA = "0x184914B50")]
			internal void DCAAAABJMLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class NDPDMHJOIHF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				public NDPDMHJOIHF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x38C81C0", Offset = "0x38C6BC0", VA = "0x1838C81C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public FMKOOFOBEMG selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public JGOIMAGMGIM nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public DNCDFCBKAAH port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public NDPDMHJOIHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x492F6F0", Offset = "0x492E0F0", VA = "0x18492F6F0")]
			internal int NPKLMCCOOFE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x492F7F0", Offset = "0x492E1F0", VA = "0x18492F7F0")]
			internal void PBCGPNLPJPB(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8AD530", Offset = "0x8ABF30", VA = "0x1808AD530")]
			internal string NGEMCNOGKCD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x492F730", Offset = "0x492E130", VA = "0x18492F730")]
			[AsyncStateMachine(typeof(JJMFPJJAEIG<>.NDPDMHJOIHF.<<CreatePortItemV2>b__3>d))]
			internal void OACLGDJAOMM(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x492F610", Offset = "0x492E010", VA = "0x18492F610")]
			internal bool JEOKGGAJJDJ(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<NOPFJADADBI<IMNAGMIGBGO>, bool> CNKFACMOJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly Dictionary<NOPFJADADBI<IMNAGMIGBGO>, bool> ECPPKANBLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly Dictionary<NOPFJADADBI<IMNAGMIGBGO>, bool> MKHGALGBBAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<NOPFJADADBI<IMNAGMIGBGO>, bool> LDEEAEPIHNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private Dictionary<NOPFJADADBI<IMNAGMIGBGO>, bool> PJOCCFBBFPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private Dictionary<NOPFJADADBI<IMNAGMIGBGO>, bool> BMAKJEKGAOK;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool ONIDFMKHKGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "124")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool FBAHKLLEIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool MLHKJGCHMPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool LNEGDCGLPAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override NOPFJADADBI<AEAAGMJLLLI>? LPCIFHMMIIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x443C030", Offset = "0x443AA30", VA = "0x18443C030", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override NOPFJADADBI<IMNAGMIGBGO>? NLCDLGOBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x443C300", Offset = "0x443AD00", VA = "0x18443C300", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<LNNCPMKFMDI<HAPKHKKGAFF>>? HGAJKKLIAIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x443C0F0", Offset = "0x443AAF0", VA = "0x18443C0F0", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x443BE10", Offset = "0x443A810", VA = "0x18443BE10")]
		public JJMFPJJAEIG(JLDPKGEOPEJ DAKMLHHEJJO, TNode OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "131")]
		protected virtual bool DKGJDPIOPPP(int KAANAJOOJPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "132")]
		protected virtual bool HAGFDHDMOBL(int KAANAJOOJPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "133")]
		protected virtual bool LDBNPHFMKLH(int KAANAJOOJPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "134")]
		protected virtual void MCEPCJIPLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x443A560", Offset = "0x4438F60", VA = "0x18443A560", Slot = "126")]
		public override bool LCONFNGKJMP(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4438040", Offset = "0x4436A40", VA = "0x184438040", Slot = "102")]
		[AsyncStateMachine(typeof(JJMFPJJAEIG<>.HGGKEPNDHAE))]
		public override Task<OKPKCEBGDLD<NOPFJADADBI<IMNAGMIGBGO>, NJDGKLFLKEH>> EMDJAKPEBAG(string JHJFHDOAMLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x44392C0", Offset = "0x4437CC0", VA = "0x1844392C0", Slot = "103")]
		[AsyncStateMachine(typeof(JJMFPJJAEIG<>.JLEBMBCPEAC))]
		public override Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> FFHMIAMHCEJ(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4437EA0", Offset = "0x44368A0", VA = "0x184437EA0", Slot = "104")]
		public override void CKKLKAKODPO(NOPFJADADBI<IMNAGMIGBGO> GCBONJOGHCD, NOPFJADADBI<IMNAGMIGBGO> PCFKCJNPKCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x443A0F0", Offset = "0x4438AF0", VA = "0x18443A0F0", Slot = "105")]
		public override IEnumerable<LEOAEGKNMKP> KDPALKFBEIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x4437440", Offset = "0x4435E40", VA = "0x184437440")]
		[AsyncStateMachine(typeof(JJMFPJJAEIG<>.FHOLHGGJOMP))]
		private Task<OKPKCEBGDLD<GNOHPBEEOMG, NJDGKLFLKEH>> ALNPBHGILCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "135")]
		protected virtual bool KHKJGFILEHM(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "136")]
		protected virtual bool EDABLKJINHI(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "137")]
		protected virtual bool NOKKLICNAHF(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "138")]
		protected virtual bool MOCJBMIIDON(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "139")]
		protected virtual bool DJGDFJFGGJL(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, int EKDLLIOJGKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "140")]
		protected virtual bool JIEAEFAFAPL(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, int EKDLLIOJGKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "141")]
		protected virtual bool JCGDKIOKNBO(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, int CJFPDACAKOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "142")]
		protected virtual bool GKODMCLPNGL(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, int CJFPDACAKOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "143")]
		protected virtual bool JGEOCCFBPFJ(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, int AHDKBCJJOAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "144")]
		protected virtual bool MMNNMEHPIAC(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, int IDBFFINBLDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4439E50", Offset = "0x4438850", VA = "0x184439E50", Slot = "145")]
		protected virtual List<FMKOOFOBEMG> JOIAIIPIHNJ(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "146")]
		protected virtual void JDKEFGMKHJA(GKGPCBCAOGC JLHJCAJMIJE, KHFMKDKOPNO ANABDMLLGOF, JGOIMAGMGIM OKFEMEBLIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x44393D0", Offset = "0x4437DD0", VA = "0x1844393D0", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x443A600", Offset = "0x4439000", VA = "0x18443A600")]
		private KHFMKDKOPNO MODBEEMJKHF(GKGPCBCAOGC JLHJCAJMIJE, JGOIMAGMGIM OKFEMEBLIJC, NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4438160", Offset = "0x4436B60", VA = "0x184438160")]
		private List<LEJADFKGGMP> EMHLMOPMCCP(GKGPCBCAOGC JLHJCAJMIJE, JGOIMAGMGIM OKFEMEBLIJC, KHFMKDKOPNO CGEANGBKGLF, bool PLBFDFIBHMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x4437540", Offset = "0x4435F40", VA = "0x184437540")]
		private List<LEJADFKGGMP> BIDOECAPMKE(GKGPCBCAOGC JLHJCAJMIJE, JGOIMAGMGIM OKFEMEBLIJC, DNCDFCBKAAH AJIDDAEJHAF, bool PLBFDFIBHMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x443A370", Offset = "0x4438D70", VA = "0x18443A370")]
		private FMKOOFOBEMG KJAEPIKMMAN(List<FMKOOFOBEMG> DMLODLCEJOA, DNCDFCBKAAH AJIDDAEJHAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x443BD70", Offset = "0x443A770", VA = "0x18443BD70")]
		[CompilerGenerated]
		private LEOAEGKNMKP ONDOBCOKAHA(AELHMIHCAOH FNLONGIJDLD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class IJJILONCMDO : CLCKKODOECE<BAOEAEJBBNB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class GPKBNGDHEKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public IJJILONCMDO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public GPKBNGDHEKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x22416D0", Offset = "0x22400D0", VA = "0x1822416D0")]
			internal int PCAMJMMFJCO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x2241640", Offset = "0x2240040", VA = "0x182241640")]
			internal void CLCMLCCEFKP(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xBEBBF0", Offset = "0xBEA5F0", VA = "0x180BEBBF0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2245C20", Offset = "0x2244620", VA = "0x182245C20")]
		public IJJILONCMDO(JLDPKGEOPEJ DAKMLHHEJJO, BAOEAEJBBNB OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2245A60", Offset = "0x2244460", VA = "0x182245A60", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class OEIDCFFKOIN : KKHNKODEBNA<OAHDCHIOCEH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class CABDNHKIHKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public OEIDCFFKOIN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public CABDNHKIHKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x223CBB0", Offset = "0x223B5B0", VA = "0x18223CBB0")]
			internal int HOLGDMEPDKG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x223CC30", Offset = "0x223B630", VA = "0x18223CC30")]
			internal void OJEKBMOIIEL(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2256460", Offset = "0x2254E60", VA = "0x182256460")]
		public OEIDCFFKOIN(JLDPKGEOPEJ DAKMLHHEJJO, OAHDCHIOCEH OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2256220", Offset = "0x2254C20", VA = "0x182256220", Slot = "128")]
		protected override void LBBFKPDLJNI(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private sealed class CFLBFELLMMK : CLCKKODOECE<JANECCIOEHL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9483D0", Offset = "0x946DD0", VA = "0x1809483D0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x223D100", Offset = "0x223BB00", VA = "0x18223D100")]
		public CFLBFELLMMK(JLDPKGEOPEJ DAKMLHHEJJO, JANECCIOEHL OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class CKEJLLIIFKE : CLCKKODOECE<CBAMDICBAFO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class IOCDPJICHCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public CKEJLLIIFKE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public GKGPCBCAOGC configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public IOCDPJICHCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x22507F0", Offset = "0x224F1F0", VA = "0x1822507F0")]
			internal bool PCAMJMMFJCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x2246790", Offset = "0x2245190", VA = "0x182246790")]
			internal void CLCMLCCEFKP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x22501B0", Offset = "0x224EBB0", VA = "0x1822501B0")]
			internal bool NDPCAAEAIOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x2246300", Offset = "0x2244D00", VA = "0x182246300")]
			internal bool BCDMOLLGAEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x22483C0", Offset = "0x2246DC0", VA = "0x1822483C0")]
			internal void ICGFCKNGHHJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x2246990", Offset = "0x2245390", VA = "0x182246990")]
			internal bool CPKHNDLEINA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x22462B0", Offset = "0x2244CB0", VA = "0x1822462B0")]
			internal bool BBLHILOPHDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x22470D0", Offset = "0x2245AD0", VA = "0x1822470D0")]
			internal void DPLKPKIFKGL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x22475E0", Offset = "0x2245FE0", VA = "0x1822475E0")]
			internal bool FEAHPOLKHCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2248C40", Offset = "0x2247640", VA = "0x182248C40")]
			internal bool JKDFIEHEHMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x22481B0", Offset = "0x2246BB0", VA = "0x1822481B0")]
			internal void HKFJKNNBALN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x224F7A0", Offset = "0x224E1A0", VA = "0x18224F7A0")]
			internal bool LNDJKPMMAMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x22487B0", Offset = "0x22471B0", VA = "0x1822487B0")]
			internal bool IJPNAHPHFKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2246450", Offset = "0x2244E50", VA = "0x182246450")]
			internal bool BHHDIDFDAFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x22479B0", Offset = "0x22463B0", VA = "0x1822479B0")]
			internal bool GHABEENGOCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x22504A0", Offset = "0x224EEA0", VA = "0x1822504A0")]
			internal bool OADMCFIEHNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x2247540", Offset = "0x2245F40", VA = "0x182247540")]
			internal bool FALDGLAOFKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2246EA0", Offset = "0x22458A0", VA = "0x182246EA0")]
			internal bool DKIEOCIOKCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x2247870", Offset = "0x2246270", VA = "0x182247870")]
			internal bool GAEAJOLJDIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x22461B0", Offset = "0x2244BB0", VA = "0x1822461B0")]
			internal bool AOJFACMAMMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x2246CF0", Offset = "0x22456F0", VA = "0x182246CF0")]
			internal void DFNPPJPPDPA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x22503B0", Offset = "0x224EDB0", VA = "0x1822503B0")]
			internal bool NMLLPIGODFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x22504F0", Offset = "0x224EEF0", VA = "0x1822504F0")]
			internal bool OAFOAEDHKGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x2246600", Offset = "0x2245000", VA = "0x182246600")]
			internal bool CDGJPAENBJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x2246DA0", Offset = "0x22457A0", VA = "0x182246DA0")]
			internal bool DHKEHJFGLJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x2248E80", Offset = "0x2247880", VA = "0x182248E80")]
			internal bool KAJJPBHCFEL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x224FF50", Offset = "0x224E950", VA = "0x18224FF50")]
			internal bool MLFAFOJLPOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x2248C90", Offset = "0x2247690", VA = "0x182248C90")]
			internal bool JLNNNBFOMCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x224FBF0", Offset = "0x224E5F0", VA = "0x18224FBF0")]
			internal bool MKLBNCELNEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x2248A30", Offset = "0x2247430", VA = "0x182248A30")]
			internal void JBONBHGFMME(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x2245E80", Offset = "0x2244880", VA = "0x182245E80")]
			internal bool AIKMBNDHAAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x2246E50", Offset = "0x2245850", VA = "0x182246E50")]
			internal bool DKGADKGJKMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x2250930", Offset = "0x224F330", VA = "0x182250930")]
			internal void PPNJOEFLFGC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x2247030", Offset = "0x2245A30", VA = "0x182247030")]
			internal bool DNEGFJBKLBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x2248990", Offset = "0x2247390", VA = "0x182248990")]
			internal bool JAMCCALNPCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x224F930", Offset = "0x224E330", VA = "0x18224F930")]
			internal void MEKJAOAKMHF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x22492C0", Offset = "0x2247CC0", VA = "0x1822492C0")]
			internal List<LEJADFKGGMP> KPLJHGOEBIC(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x2248370", Offset = "0x2246D70", VA = "0x182248370")]
			internal bool IBJKLFBKPGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x22488A0", Offset = "0x22472A0", VA = "0x1822488A0")]
			internal int ILPPOBNLBAD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x224F650", Offset = "0x224E050", VA = "0x18224F650")]
			internal void LJAEFDAACOO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2248BA0", Offset = "0x22475A0", VA = "0x182248BA0")]
			internal bool JJCHOFNMLBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x2247A50", Offset = "0x2246450", VA = "0x182247A50")]
			internal bool GNGCDJBOJLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x2248940", Offset = "0x2247340", VA = "0x182248940")]
			internal bool JAGOEHJFHKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x22490E0", Offset = "0x2247AE0", VA = "0x1822490E0")]
			internal int KILBEILGONN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x2249030", Offset = "0x2247A30", VA = "0x182249030")]
			internal void KGJEGKNDGEC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x22485D0", Offset = "0x2246FD0", VA = "0x1822485D0")]
			internal bool IEPHPGBBCIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x2248710", Offset = "0x2247110", VA = "0x182248710")]
			internal bool IIFMJCPEJCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x2247130", Offset = "0x2245B30", VA = "0x182247130")]
			internal bool DPNLNHGLGFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x2246400", Offset = "0x2244E00", VA = "0x182246400")]
			internal bool BGOPKFEEOHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x22506F0", Offset = "0x224F0F0", VA = "0x1822506F0")]
			internal bool ONLDMBKJAMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x2250110", Offset = "0x224EB10", VA = "0x182250110")]
			internal bool MOGOBOBCENC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x22502A0", Offset = "0x224ECA0", VA = "0x1822502A0")]
			internal string NJLMIOLPENJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x22460A0", Offset = "0x2244AA0", VA = "0x1822460A0")]
			internal void ANBAGOMCPGH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x22507A0", Offset = "0x224F1A0", VA = "0x1822507A0")]
			internal int PALLNILHGNB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x22500B0", Offset = "0x224EAB0", VA = "0x1822500B0")]
			internal void MNMKEJFJCEK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x224FFA0", Offset = "0x224E9A0", VA = "0x18224FFA0")]
			internal bool MLMCAGPEDIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x2250840", Offset = "0x224F240", VA = "0x182250840")]
			internal bool PDIHCKLAGBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2247240", Offset = "0x2245C40", VA = "0x182247240")]
			internal bool EHEFHICKNAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2248FE0", Offset = "0x22479E0", VA = "0x182248FE0")]
			internal float KFHGJMENLHH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2248D30", Offset = "0x2247730", VA = "0x182248D30")]
			internal void JOBKGIJDOHJ(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x2247630", Offset = "0x2246030", VA = "0x182247630")]
			internal bool FGNJAOLIFDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2248AE0", Offset = "0x22474E0", VA = "0x182248AE0")]
			internal bool JFCHKFNFCFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x2245E30", Offset = "0x2244830", VA = "0x182245E30")]
			internal bool AGHCAEOLEJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x2250400", Offset = "0x224EE00", VA = "0x182250400")]
			internal bool NONPNEHEHMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x2248320", Offset = "0x2246D20", VA = "0x182248320")]
			internal bool IBGHLLFDFLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x2247EA0", Offset = "0x22468A0", VA = "0x182247EA0")]
			internal bool HCHIKPCBCEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x2247AA0", Offset = "0x22464A0", VA = "0x182247AA0")]
			internal void GODAEMGJCGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x224F2F0", Offset = "0x224DCF0", VA = "0x18224F2F0")]
			internal string LABMKAFPCFD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2246590", Offset = "0x2244F90", VA = "0x182246590")]
			internal void CCNFLMIHJCK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x2246EF0", Offset = "0x22458F0", VA = "0x182246EF0")]
			internal bool DLAEIBAAJAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x2246FE0", Offset = "0x22459E0", VA = "0x182246FE0")]
			internal bool DNCNJHHIABL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x2246B20", Offset = "0x2245520", VA = "0x182246B20")]
			internal bool DEBCLDPPGKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x224FC40", Offset = "0x224E640", VA = "0x18224FC40")]
			internal void MKPAADFFPFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2247820", Offset = "0x2246220", VA = "0x182247820")]
			internal bool FNBHIPJEEDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x224F340", Offset = "0x224DD40", VA = "0x18224F340")]
			internal bool LAEPJADFINO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x22502F0", Offset = "0x224ECF0", VA = "0x1822502F0")]
			internal bool NKLKDIMAFIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2247680", Offset = "0x2246080", VA = "0x182247680")]
			internal bool FIFPBCCOFBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x2250690", Offset = "0x224F090", VA = "0x182250690")]
			internal void OKPOEOFNOGD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x2247F90", Offset = "0x2246990", VA = "0x182247F90")]
			internal bool HFKDNAGADFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x2246940", Offset = "0x2245340", VA = "0x182246940")]
			internal bool COPHMILDPHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x2249130", Offset = "0x2247B30", VA = "0x182249130")]
			internal bool KIMNOLHFDDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x22488F0", Offset = "0x22472F0", VA = "0x1822488F0")]
			internal bool IOFPHCJEJFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x22467F0", Offset = "0x22451F0", VA = "0x1822467F0")]
			internal void CMGAMOACCGE(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x2250450", Offset = "0x224EE50", VA = "0x182250450")]
			internal bool NOOONIIMDCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x2247590", Offset = "0x2245F90", VA = "0x182247590")]
			internal bool FCMKJHCNLJD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x224F560", Offset = "0x224DF60", VA = "0x18224F560")]
			internal bool LELIMBNHGKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x2246C30", Offset = "0x2245630", VA = "0x182246C30")]
			internal bool DFKBHCMMMKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x2248B30", Offset = "0x2247530", VA = "0x182248B30")]
			internal object JIJBPABMPIJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x2245F70", Offset = "0x2244970", VA = "0x182245F70")]
			internal void ALLFGHDKBDJ(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x224F5B0", Offset = "0x224DFB0", VA = "0x18224F5B0")]
			internal bool LIBDEPHCMIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x22466A0", Offset = "0x22450A0", VA = "0x1822466A0")]
			internal bool CFPCCLMGPEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x2248160", Offset = "0x2246B60", VA = "0x182248160")]
			internal int HKBGIFOFOFF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x2246200", Offset = "0x2244C00", VA = "0x182246200")]
			internal void APLGKEJLIHL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x224F8E0", Offset = "0x224E2E0", VA = "0x18224F8E0")]
			internal bool MEBBEJFICBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x2246AD0", Offset = "0x22454D0", VA = "0x182246AD0")]
			internal bool DEAKOKAOCIF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x2248CE0", Offset = "0x22476E0", VA = "0x182248CE0")]
			internal int JMHNCPLEOMD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x2250740", Offset = "0x224F140", VA = "0x182250740")]
			internal void PAKMFEPLPCF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x2245DE0", Offset = "0x22447E0", VA = "0x182245DE0")]
			internal bool AGDFMJGOING()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x2248E30", Offset = "0x2247830", VA = "0x182248E30")]
			internal bool KAIFNLJOJHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x22478C0", Offset = "0x22462C0", VA = "0x1822478C0")]
			internal bool GBNJOKCACEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x22472E0", Offset = "0x2245CE0", VA = "0x1822472E0")]
			internal int EJKAPNDMLOM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x2247720", Offset = "0x2246120", VA = "0x182247720")]
			internal void FJMNBALNNPN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x2248620", Offset = "0x2247020", VA = "0x182248620")]
			internal bool IGFINDCEHCJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x224F990", Offset = "0x224E390", VA = "0x18224F990")]
			internal bool MENNBHOBPLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x2248110", Offset = "0x2246B10", VA = "0x182248110")]
			internal bool HJPCHCMGEKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x2245D70", Offset = "0x2244770", VA = "0x182245D70")]
			internal object AGCJKLCLGBB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x224FB10", Offset = "0x224E510", VA = "0x18224FB10")]
			internal void MIKBAKOOPIL(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2246F40", Offset = "0x2245940", VA = "0x182246F40")]
			internal bool DMAGLJLOAOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x2248850", Offset = "0x2247250", VA = "0x182248850")]
			internal bool IKPILOMKCGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x2245C90", Offset = "0x2244690", VA = "0x182245C90")]
			internal object AEEEBDGLMOD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x224F3E0", Offset = "0x224DDE0", VA = "0x18224F3E0")]
			internal void LCOJOIGOAGJ(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x2248BF0", Offset = "0x22475F0", VA = "0x182248BF0")]
			internal bool JJIAOBPGECJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x2250540", Offset = "0x224EF40", VA = "0x182250540")]
			internal int OBACMEHBJGM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x22463A0", Offset = "0x2244DA0", VA = "0x1822463A0")]
			internal void BFLPNKJJBLK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x2248D90", Offset = "0x2247790", VA = "0x182248D90")]
			internal bool JOHMCNDPIKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x2247080", Offset = "0x2245A80", VA = "0x182247080")]
			internal bool DNLLFFIMIBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x2248530", Offset = "0x2246F30", VA = "0x182248530")]
			internal bool IEFJKGLPNLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x2249220", Offset = "0x2247C20", VA = "0x182249220")]
			internal int KOEAMMJADKD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x2250630", Offset = "0x224F030", VA = "0x182250630")]
			internal void OJLBOLMPNBL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x224F6B0", Offset = "0x224E0B0", VA = "0x18224F6B0")]
			internal bool LJKNPPPGLJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2247E50", Offset = "0x2246850", VA = "0x182247E50")]
			internal bool GOLCIFEIAIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x224F700", Offset = "0x224E100", VA = "0x18224F700")]
			internal bool LKNPEOIJHBH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2250890", Offset = "0x224F290", VA = "0x182250890")]
			internal float PHDJJKAMELL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2248ED0", Offset = "0x22478D0", VA = "0x182248ED0")]
			internal void KDFNGDAOOGL(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2246F90", Offset = "0x2245990", VA = "0x182246F90")]
			internal bool DMFEFNKCFFA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x2247380", Offset = "0x2245D80", VA = "0x182247380")]
			internal bool EKAPEJELDFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x22477D0", Offset = "0x22461D0", VA = "0x1822477D0")]
			internal bool FKNBMFKFFJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x224F510", Offset = "0x224DF10", VA = "0x18224F510")]
			internal float LEDMHDKLOFB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x2248F80", Offset = "0x2247980", VA = "0x182248F80")]
			internal void KEBALBPMCDI(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x2246260", Offset = "0x2244C60", VA = "0x182246260")]
			internal bool BBEFDKMBIGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x22508E0", Offset = "0x224F2E0", VA = "0x1822508E0")]
			internal bool PPCEDGDHMCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x22468F0", Offset = "0x22452F0", VA = "0x1822468F0")]
			internal string CNIMJDPBLBK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x2246C80", Offset = "0x2245680", VA = "0x182246C80")]
			internal void DFLJOIIKMJD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x22491D0", Offset = "0x2247BD0", VA = "0x1822491D0")]
			internal bool KNFAFENJOKP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x224F840", Offset = "0x224E240", VA = "0x18224F840")]
			internal bool MCAEEOJFKDL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x2246160", Offset = "0x2244B60", VA = "0x182246160")]
			internal bool AOFAJDGEEDL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x2250200", Offset = "0x224EC00", VA = "0x182250200")]
			internal bool NGGNLAMPCGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x22471F0", Offset = "0x2245BF0", VA = "0x1822471F0")]
			internal string EEDNPBEBKBD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x22480A0", Offset = "0x2246AA0", VA = "0x1822480A0")]
			internal void HJGHBGBEEAO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x22469E0", Offset = "0x22453E0", VA = "0x1822469E0")]
			internal bool DCBIIJFPIEO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x2248210", Offset = "0x2246C10", VA = "0x182248210")]
			internal bool HLBPLHDIEGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x2246050", Offset = "0x2244A50", VA = "0x182246050")]
			internal bool AMOCFKANDKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x224F600", Offset = "0x224E000", VA = "0x18224F600")]
			internal bool LIPPIEKFODG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x2248670", Offset = "0x2247070", VA = "0x182248670")]
			internal string IHALBBBNAAK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x2247180", Offset = "0x2245B80", VA = "0x182247180")]
			internal void EAEKHDOIDFD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x22486C0", Offset = "0x22470C0", VA = "0x1822486C0")]
			internal bool IHGGLHAPLFA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2246000", Offset = "0x2244A00", VA = "0x182246000")]
			internal bool AMNJPELAPMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x2246BE0", Offset = "0x22455E0", VA = "0x182246BE0")]
			internal bool DECDLLOLOOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x22464A0", Offset = "0x2244EA0", VA = "0x1822464A0")]
			internal bool BJGMCLEFADM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x2250250", Offset = "0x224EC50", VA = "0x182250250")]
			internal string NJHAFPAFDGH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x2246B70", Offset = "0x2245570", VA = "0x182246B70")]
			internal void DEBNHJLNFMP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x22468A0", Offset = "0x22452A0", VA = "0x1822468A0")]
			internal bool CNFKDAGMKLK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x2250590", Offset = "0x224EF90", VA = "0x182250590")]
			internal bool OGBBDOKNADH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x2249180", Offset = "0x2247B80", VA = "0x182249180")]
			internal bool KLFBMMFKHKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x2248A90", Offset = "0x2247490", VA = "0x182248A90")]
			internal bool JFCECJKHHMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x224F4C0", Offset = "0x224DEC0", VA = "0x18224F4C0")]
			internal string LEDILAKPCLA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2248260", Offset = "0x2246C60", VA = "0x182248260")]
			internal void HLIGBOAEPFB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2248F30", Offset = "0x2247930", VA = "0x182248F30")]
			internal bool KDLDGPEJCNB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x2245ED0", Offset = "0x22448D0", VA = "0x182245ED0")]
			internal bool AILEOGLBLNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x2247A00", Offset = "0x2246400", VA = "0x182247A00")]
			internal bool GMLLGIECAIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x22466F0", Offset = "0x22450F0", VA = "0x1822466F0")]
			internal bool CICEFILFNFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x22474A0", Offset = "0x2245EA0", VA = "0x1822474A0")]
			internal string ENFOEKBAGNO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x224FFF0", Offset = "0x224E9F0", VA = "0x18224FFF0")]
			internal void MMBNNLJAAPN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x2247780", Offset = "0x2246180", VA = "0x182247780")]
			internal bool FKHEMINIINO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2246540", Offset = "0x2244F40", VA = "0x182246540")]
			internal bool BOEJOIAKMOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2247EF0", Offset = "0x22468F0", VA = "0x182247EF0")]
			internal bool HDNHDONCMNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2246D50", Offset = "0x2245750", VA = "0x182246D50")]
			internal bool DHICICDHECB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2247290", Offset = "0x2245C90", VA = "0x182247290")]
			internal string EHFJFPEPHJB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2245D00", Offset = "0x2244700", VA = "0x182245D00")]
			internal void AEKJFEMCODG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2248800", Offset = "0x2247200", VA = "0x182248800")]
			internal bool IKJECGDAAHP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x2245F20", Offset = "0x2244920", VA = "0x182245F20")]
			internal bool AJFBDLCIPLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x22505E0", Offset = "0x224EFE0", VA = "0x1822505E0")]
			internal bool OIEMNONKEHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x224FBA0", Offset = "0x224E5A0", VA = "0x18224FBA0")]
			internal bool MJCMKBHLBDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x22474F0", Offset = "0x2245EF0", VA = "0x1822474F0")]
			internal string EOLDAGJFBML()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x2248030", Offset = "0x2246A30", VA = "0x182248030")]
			internal void HIMJIMFFJJM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x2246650", Offset = "0x2245050", VA = "0x182246650")]
			internal bool CEDCBPBHKCL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x2247910", Offset = "0x2246310", VA = "0x182247910")]
			internal bool GELOOBGCMDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x224F7F0", Offset = "0x224E1F0", VA = "0x18224F7F0")]
			internal bool MADAMOKOHHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x2246110", Offset = "0x2244B10", VA = "0x182246110")]
			internal bool AOBBCMCMLLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x2247960", Offset = "0x2246360", VA = "0x182247960")]
			internal string GEMCOKKAIBN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x2250340", Offset = "0x224ED40", VA = "0x182250340")]
			internal void NLDIEIHOKIO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x224FAC0", Offset = "0x224E4C0", VA = "0x18224FAC0")]
			internal bool MIKABOHIIFP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x2246740", Offset = "0x2245140", VA = "0x182246740")]
			internal bool CIOFIPEOCGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x22489E0", Offset = "0x22473E0", VA = "0x1822489E0")]
			internal bool JBNCGNNOJPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x224F890", Offset = "0x224E290", VA = "0x18224F890")]
			internal bool MCDKODBDLCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x2250060", Offset = "0x224EA60", VA = "0x182250060")]
			internal string MNEEBMKNJDL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x2247430", Offset = "0x2245E30", VA = "0x182247430")]
			internal void ELHCAHJDNJD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x22476D0", Offset = "0x22460D0", VA = "0x1822476D0")]
			internal bool FIPONKHHOHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x2246350", Offset = "0x2244D50", VA = "0x182246350")]
			internal bool BDIPKJLBFGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x224F390", Offset = "0x224DD90", VA = "0x18224F390")]
			internal bool LCODEIFEBNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x2249270", Offset = "0x2247C70", VA = "0x182249270")]
			internal string KPDKIGHMFFD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x224F9E0", Offset = "0x224E3E0", VA = "0x18224F9E0")]
			internal void MEOJBKFMHJM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x2248420", Offset = "0x2246E20", VA = "0x182248420")]
			internal bool ICGLEGBAGNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x2247FE0", Offset = "0x22469E0", VA = "0x182247FE0")]
			internal bool HIDCHIHHAON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x2247330", Offset = "0x2245D30", VA = "0x182247330")]
			internal bool EKABMAGOCBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x224F750", Offset = "0x224E150", VA = "0x18224F750")]
			internal string LLNKIAMNEOO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x224FA50", Offset = "0x224E450", VA = "0x18224FA50")]
			internal void MHFAKCCHONM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x22482D0", Offset = "0x2246CD0", VA = "0x1822482D0")]
			internal bool HPDIBGBMKPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x2248760", Offset = "0x2247160", VA = "0x182248760")]
			internal bool IJBPEHBFDCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x2246A80", Offset = "0x2245480", VA = "0x182246A80")]
			internal bool DDHFJNGMAGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x224F470", Offset = "0x224DE70", VA = "0x18224F470")]
			internal string LDNFHPDFPCE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x22484C0", Offset = "0x2246EC0", VA = "0x1822484C0")]
			internal void IEBLPDBJNMG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x2246850", Offset = "0x2245250", VA = "0x182246850")]
			internal bool CMNIEKOINGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x2248580", Offset = "0x2246F80", VA = "0x182248580")]
			internal bool IEGLCFAGPIF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x2247F40", Offset = "0x2246940", VA = "0x182247F40")]
			internal float HFCPIKMEDBD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x2246DF0", Offset = "0x22457F0", VA = "0x182246DF0")]
			internal void DJLCPADKDOO(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x224FF00", Offset = "0x224E900", VA = "0x18224FF00")]
			internal bool MLEENPEEPAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x2246A30", Offset = "0x2245430", VA = "0x182246A30")]
			internal bool DDBGKPKINCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x2248470", Offset = "0x2246E70", VA = "0x182248470")]
			internal bool IEAAFIHBOOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x2249090", Offset = "0x2247A90", VA = "0x182249090")]
			internal int KHHCNPAIELF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x22473D0", Offset = "0x2245DD0", VA = "0x1822473D0")]
			internal void EKDPNAKALMG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x2248DE0", Offset = "0x22477E0", VA = "0x182248DE0")]
			internal bool JPDIBGONLAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x2250160", Offset = "0x224EB60", VA = "0x182250160")]
			internal bool NBMDOEALHBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x22464F0", Offset = "0x2244EF0", VA = "0x1822464F0")]
			internal bool BMFGBIAOIBI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class AHBDCIOAGJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public IOCDPJICHCP CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public AHBDCIOAGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x223AB50", Offset = "0x2239550", VA = "0x18223AB50")]
			internal void CFELMLAMGJC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class JHLKGNDKEBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public JHLKGNDKEBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x2251730", Offset = "0x2250130", VA = "0x182251730")]
			internal bool HKEDHOEJOKI(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly JFDEPBIGAAC MMLHGDONCHI;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x223F1E0", Offset = "0x223DBE0", VA = "0x18223F1E0")]
		public CKEJLLIIFKE(JLDPKGEOPEJ DAKMLHHEJJO, CBAMDICBAFO OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x223D4A0", Offset = "0x223BEA0", VA = "0x18223D4A0", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public sealed class IODIHGPBFOF : CLCKKODOECE<KLKEPIJEOCG>
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class AKJEGFCIPCA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006C")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public AKJEGFCIPCA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x2275560", Offset = "0x2273F60", VA = "0x182275560", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public IODIHGPBFOF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public AKJEGFCIPCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x2259F60", Offset = "0x2258960", VA = "0x182259F60")]
			internal string PCAMJMMFJCO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x2259E00", Offset = "0x2258800", VA = "0x182259E00")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void CLCMLCCEFKP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x2259DB0", Offset = "0x22587B0", VA = "0x182259DB0")]
			internal int CJLHFJFDNAK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x2259ED0", Offset = "0x22588D0", VA = "0x182259ED0")]
			internal void MKKNACCAEML(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xBEBBF0", Offset = "0xBEA5F0", VA = "0x180BEBBF0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x22691C0", Offset = "0x2267BC0", VA = "0x1822691C0")]
		public IODIHGPBFOF(JLDPKGEOPEJ DAKMLHHEJJO, KLKEPIJEOCG OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2268E70", Offset = "0x2267870", VA = "0x182268E70", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class DJOOFFJAMDG : CLCKKODOECE<NFCENPLELFM>
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class JJGDAKHNFIM
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006F")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				public JJGDAKHNFIM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x2275870", Offset = "0x2274270", VA = "0x182275870", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000070")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public JJGDAKHNFIM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000189")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400018A")]
				private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x2275BB0", Offset = "0x22745B0", VA = "0x182275BB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public DJOOFFJAMDG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public JJGDAKHNFIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x226A580", Offset = "0x2268F80", VA = "0x18226A580")]
			internal string PCAMJMMFJCO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x226A0C0", Offset = "0x2268AC0", VA = "0x18226A0C0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void CLCMLCCEFKP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x226A070", Offset = "0x2268A70", VA = "0x18226A070")]
			internal int CJLHFJFDNAK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x226A410", Offset = "0x2268E10", VA = "0x18226A410")]
			internal void MKKNACCAEML(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x226A4A0", Offset = "0x2268EA0", VA = "0x18226A4A0")]
			internal string NDPCAAEAIOM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x2269F40", Offset = "0x2268940", VA = "0x182269F40")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void BCDMOLLGAEC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x226A3C0", Offset = "0x2268DC0", VA = "0x18226A3C0")]
			internal bool ICGFCKNGHHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x226A4F0", Offset = "0x2268EF0", VA = "0x18226A4F0")]
			internal void PBCPLFKNLHM(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x2269EA0", Offset = "0x22688A0", VA = "0x182269EA0")]
			internal bool AMNGKOPJEGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x226A190", Offset = "0x2268B90", VA = "0x18226A190")]
			internal void CPKHNDLEINA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x2269EF0", Offset = "0x22688F0", VA = "0x182269EF0")]
			internal float BBLHILOPHDF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x226A220", Offset = "0x2268C20", VA = "0x18226A220")]
			internal void DPLKPKIFKGL(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x226A010", Offset = "0x2268A10", VA = "0x18226A010")]
			internal int BMEEMEHKLBL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x226A320", Offset = "0x2268D20", VA = "0x18226A320")]
			internal void FHPOMEOHEMJ(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x226A2B0", Offset = "0x2268CB0", VA = "0x18226A2B0")]
			internal bool FEAHPOLKHCB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xBEBBF0", Offset = "0xBEA5F0", VA = "0x180BEBBF0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2262750", Offset = "0x2261150", VA = "0x182262750")]
		public DJOOFFJAMDG(JLDPKGEOPEJ DAKMLHHEJJO, NFCENPLELFM OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2261D00", Offset = "0x2260700", VA = "0x182261D00", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class FGCDECKIAEK : CLCKKODOECE<BJFEGBFEDON>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class GLFCADBBONK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public FGCDECKIAEK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public GLFCADBBONK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x2264480", Offset = "0x2262E80", VA = "0x182264480")]
			internal Dictionary<string, PHCGGPIMKIC> PCAMJMMFJCO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x22643B0", Offset = "0x2262DB0", VA = "0x1822643B0")]
			internal int CLCMLCCEFKP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x2264290", Offset = "0x2262C90", VA = "0x182264290")]
			internal void CJLHFJFDNAK(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x2264400", Offset = "0x2262E00", VA = "0x182264400")]
			internal bool MKKNACCAEML()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xBEBBF0", Offset = "0xBEA5F0", VA = "0x180BEBBF0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x2263A10", Offset = "0x2262410", VA = "0x182263A10")]
		public FGCDECKIAEK(JLDPKGEOPEJ DAKMLHHEJJO, BJFEGBFEDON OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x2263740", Offset = "0x2262140", VA = "0x182263740", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class KCOFHKCHKFN : CLCKKODOECE<DFOKFLMGBML>
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class PEABNPELDJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public KCOFHKCHKFN <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public PEABNPELDJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x22749B0", Offset = "0x22733B0", VA = "0x1822749B0")]
			internal void PCAMJMMFJCO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xBEBBF0", Offset = "0xBEA5F0", VA = "0x180BEBBF0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x226AB50", Offset = "0x2269550", VA = "0x18226AB50")]
		public KCOFHKCHKFN(JLDPKGEOPEJ DAKMLHHEJJO, DFOKFLMGBML OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x226A9D0", Offset = "0x22693D0", VA = "0x18226A9D0", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class NPDCNMOGEPC : JJMFPJJAEIG<AKMLHGOPOCJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool CGFKGPCIKOE
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool DGGHOOEPFDE
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x2273A60", Offset = "0x2272460", VA = "0x182273A60", Slot = "119")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x936230", Offset = "0x934C30", VA = "0x180936230", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x2273A00", Offset = "0x2272400", VA = "0x182273A00")]
		public NPDCNMOGEPC(JLDPKGEOPEJ DAKMLHHEJJO, AKMLHGOPOCJ OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class IECEALCNPHB : CLCKKODOECE<PPFDDGCEOAN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xBBD3F0", Offset = "0xBBBDF0", VA = "0x180BBD3F0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2266AB0", Offset = "0x22654B0", VA = "0x182266AB0")]
		public IECEALCNPHB(JLDPKGEOPEJ DAKMLHHEJJO, PPFDDGCEOAN OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class OPOAKNFKNDK : CLCKKODOECE<GLCPNLLGPIN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x949760", Offset = "0x948160", VA = "0x180949760", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x22746F0", Offset = "0x22730F0", VA = "0x1822746F0")]
		public OPOAKNFKNDK(JLDPKGEOPEJ DAKMLHHEJJO, GLCPNLLGPIN OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "114")]
		protected override bool ECHALLHFPKP(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private sealed class FPPLGKCHNOE : CLCKKODOECE<AEJAMMPBFKO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x941530", Offset = "0x93FF30", VA = "0x180941530", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool PGJDODLBDEB
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x2263E80", Offset = "0x2262880", VA = "0x182263E80", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool KLMPMMOLOKH
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2263E10", Offset = "0x2262810", VA = "0x182263E10")]
		public FPPLGKCHNOE(JLDPKGEOPEJ DAKMLHHEJJO, AEJAMMPBFKO OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class MONDICIAFOE : CLCKKODOECE<AJPILCJFPMO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x93C4F0", Offset = "0x93AEF0", VA = "0x18093C4F0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool PGJDODLBDEB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x2273080", Offset = "0x2271A80", VA = "0x182273080", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool KLMPMMOLOKH
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x2273010", Offset = "0x2271A10", VA = "0x182273010")]
		public MONDICIAFOE(JLDPKGEOPEJ DAKMLHHEJJO, AJPILCJFPMO OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class COEPHPCAEPJ : KKHNKODEBNA<ACGBOHNHIOJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class LGJBFNGGMHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public COEPHPCAEPJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public LGJBFNGGMHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x2272B10", Offset = "0x2271510", VA = "0x182272B10")]
			internal float HOLGDMEPDKG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x2272B90", Offset = "0x2271590", VA = "0x182272B90")]
			internal void OJEKBMOIIEL(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x225B860", Offset = "0x225A260", VA = "0x18225B860")]
		public COEPHPCAEPJ(JLDPKGEOPEJ DAKMLHHEJJO, ACGBOHNHIOJ OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x225B5E0", Offset = "0x2259FE0", VA = "0x18225B5E0", Slot = "128")]
		protected override void LBBFKPDLJNI(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public sealed class NEANIKAPBOE : CLCKKODOECE<DIBHGNACFLF>
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class BDAHHCPEHKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public NEANIKAPBOE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public BDAHHCPEHKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x225A9A0", Offset = "0x22593A0", VA = "0x18225A9A0")]
			internal bool PCAMJMMFJCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x225A880", Offset = "0x2259280", VA = "0x18225A880")]
			internal void CLCMLCCEFKP(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2273860", Offset = "0x2272260", VA = "0x182273860")]
		public NEANIKAPBOE(JLDPKGEOPEJ DAKMLHHEJJO, DIBHGNACFLF OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x22735B0", Offset = "0x2271FB0", VA = "0x1822735B0", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class HPFIOBOBADG : CLCKKODOECE<JDGPKLOOKHD>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private sealed class CJMNFOFFAOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public HPFIOBOBADG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public CJMNFOFFAOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x225B190", Offset = "0x2259B90", VA = "0x18225B190")]
			internal object PCAMJMMFJCO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x225B110", Offset = "0x2259B10", VA = "0x18225B110")]
			internal bool PBCPLFKNLHM(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x225ACE0", Offset = "0x22596E0", VA = "0x18225ACE0")]
			internal void CLCMLCCEFKP(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x225AB80", Offset = "0x2259580", VA = "0x18225AB80")]
			internal string CJLHFJFDNAK(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x225B050", Offset = "0x2259A50", VA = "0x18225B050")]
			internal IReadOnlyList<object> MKKNACCAEML()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x225B0A0", Offset = "0x2259AA0", VA = "0x18225B0A0")]
			internal bool NDPCAAEAIOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x225AB30", Offset = "0x2259530", VA = "0x18225AB30")]
			internal bool BCDMOLLGAEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x225AF30", Offset = "0x2259930", VA = "0x18225AF30")]
			internal void ICGFCKNGHHJ(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x22653B0", Offset = "0x2263DB0", VA = "0x1822653B0")]
		public HPFIOBOBADG(JLDPKGEOPEJ DAKMLHHEJJO, JDGPKLOOKHD OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x2264B70", Offset = "0x2263570", VA = "0x182264B70", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public sealed class HFJFCABCOKB : GJOBNMEDLBN<AIKMDGBDMKI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x92F8B0", Offset = "0x92E2B0", VA = "0x18092F8B0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x22649C0", Offset = "0x22633C0", VA = "0x1822649C0")]
		public HFJFCABCOKB(JLDPKGEOPEJ DAKMLHHEJJO, AIKMDGBDMKI OFGAFPGJIKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class BCAIFNDADBD : KKHNKODEBNA<EJCFLFALMJH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class KIJIHHFPFCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public BCAIFNDADBD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public KIJIHHFPFCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x2271530", Offset = "0x226FF30", VA = "0x182271530")]
			internal int HOLGDMEPDKG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x22715B0", Offset = "0x226FFB0", VA = "0x1822715B0")]
			internal void OJEKBMOIIEL(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x225A820", Offset = "0x2259220", VA = "0x18225A820")]
		public BCAIFNDADBD(JLDPKGEOPEJ DAKMLHHEJJO, EJCFLFALMJH OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x225A590", Offset = "0x2258F90", VA = "0x18225A590", Slot = "128")]
		protected override void LBBFKPDLJNI(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class PBPJJKHNLJH : CLCKKODOECE<NOCAJLLLBAB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class BMCCIMJCMIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public PBPJJKHNLJH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public BMCCIMJCMIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x225AA80", Offset = "0x2259480", VA = "0x18225AA80")]
			internal bool PCAMJMMFJCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x225A9F0", Offset = "0x22593F0", VA = "0x18225A9F0")]
			internal void CLCMLCCEFKP(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2274940", Offset = "0x2273340", VA = "0x182274940")]
		public PBPJJKHNLJH(JLDPKGEOPEJ DAKMLHHEJJO, NOCAJLLLBAB OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2274760", Offset = "0x2273160", VA = "0x182274760", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class IFAABDABLJE : CLCKKODOECE<EDGCNEOHHLK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class GLJBFHHCIBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public IFAABDABLJE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public GLJBFHHCIBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x22645B0", Offset = "0x2262FB0", VA = "0x1822645B0")]
			internal bool PCAMJMMFJCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x2264520", Offset = "0x2262F20", VA = "0x182264520")]
			internal void CLCMLCCEFKP(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2266D00", Offset = "0x2265700", VA = "0x182266D00")]
		public IFAABDABLJE(JLDPKGEOPEJ DAKMLHHEJJO, EDGCNEOHHLK OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x2266B20", Offset = "0x2265520", VA = "0x182266B20", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class ACGMHJPBEML : CLCKKODOECE<OFONKCOCDJD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		[CompilerGenerated]
		private sealed class FIEFLDLFFGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public ACGMHJPBEML <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public FIEFLDLFFGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x2263B10", Offset = "0x2262510", VA = "0x182263B10")]
			internal int PCAMJMMFJCO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x2263A80", Offset = "0x2262480", VA = "0x182263A80")]
			internal void CLCMLCCEFKP(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x2259810", Offset = "0x2258210", VA = "0x182259810")]
		public ACGMHJPBEML(JLDPKGEOPEJ DAKMLHHEJJO, OFONKCOCDJD OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x22595A0", Offset = "0x2257FA0", VA = "0x1822595A0", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class NNAABBGFIFD : GOBEILMFPDJ<MJOFBNKPEHL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override BMCMNKGELFP EJJMAPJLIIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x941F40", Offset = "0x940940", VA = "0x180941F40", Slot = "128")]
			get
			{
				return default(BMCMNKGELFP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x2273940", Offset = "0x2272340", VA = "0x182273940")]
		public NNAABBGFIFD(JLDPKGEOPEJ DAKMLHHEJJO, MJOFBNKPEHL OAAFMJBAJGL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class PHJNHOFEGAK : CLCKKODOECE<AELHMIHCAOH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x22738D0", Offset = "0x22722D0", VA = "0x1822738D0")]
		public PHJNHOFEGAK(JLDPKGEOPEJ DAKMLHHEJJO, AELHMIHCAOH OFGAFPGJIKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public abstract class CLCKKODOECE<TNode> : FGJHFGGJHDK, IDisposable where TNode : notnull, AELHMIHCAOH
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private sealed class MOLLHBLJHHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public CLCKKODOECE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public JLDPKGEOPEJ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public MOLLHBLJHHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x48C8790", Offset = "0x48C7190", VA = "0x1848C8790")]
			internal COFJCJNKHJE FJFLJLEGNFP(JHIFFFEJNGA portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private struct LOFKIDOPGHD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public CLCKKODOECE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x4682A60", Offset = "0x4681460", VA = "0x184682A60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private struct LKEKPPPKOKI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public CLCKKODOECE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public PIGKNMNIKBG? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public LEFNAMLLENO? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x4676070", Offset = "0x4674A70", VA = "0x184676070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x4676320", Offset = "0x4674D20", VA = "0x184676320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class BGLADCOIILF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CA")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CC")]
				public BGLADCOIILF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CD")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0x38C6F50", Offset = "0x38C5950", VA = "0x1838C6F50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public CLCKKODOECE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public GKGPCBCAOGC configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public BGLADCOIILF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
			internal string EKFGPCIAEBD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
			internal void CNDMEBOLFFB(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x527A2C0", Offset = "0x5278CC0", VA = "0x18527A2C0")]
			[AsyncStateMachine(typeof(CLCKKODOECE<>.BGLADCOIILF.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void LHALINONENB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private sealed class LPNDCLBIIEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public LPNDCLBIIEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x468A450", Offset = "0x4688E50", VA = "0x18468A450")]
			internal bool ILGFNLNKNOK(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x468A530", Offset = "0x4688F30", VA = "0x18468A530")]
			internal bool KHJBFFHKFDL(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private struct CHHAEPOOFJB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public CLCKKODOECE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x54F9220", Offset = "0x54F7C20", VA = "0x1854F9220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x54F95B0", Offset = "0x54F7FB0", VA = "0x1854F95B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly JLDPKGEOPEJ KFPFICPDKJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private readonly bool CGGAOOKFMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private MJLNGMPMENC<IMNAGMIGBGO, COFJCJNKHJE> BBDACMNDKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private MJLNGMPMENC<IMNAGMIGBGO, JGOIMAGMGIM> MBJANMCGKNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private List<Action> IBHBHBPDIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[CompilerGenerated]
		private Action<NOPFJADADBI<IMNAGMIGBGO>>? COKHBEAIHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[CompilerGenerated]
		private Action<NOPFJADADBI<IMNAGMIGBGO>, JGOIMAGMGIM>? MJGILBINNDM;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected PJMLECBJJNJ ILMJMLCHJIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x560F5F0", Offset = "0x560DFF0", VA = "0x18560F5F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected OPNMKJDFIKH JKFPPDKCLLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x56115F0", Offset = "0x560FFF0", VA = "0x1856115F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode EFJLBHNFDOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public LNNCPMKFMDI<AKHMDDJPEIB> ICEDOMAHCPL
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xE60E10", Offset = "0xE5F810", VA = "0x180E60E10", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(LNNCPMKFMDI<AKHMDDJPEIB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public NOPFJADADBI<HAEIHINDMNN> NIOLEMIFGAN
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x5614550", Offset = "0x5612F50", VA = "0x185614550", Slot = "6")]
			get
			{
				return default(NOPFJADADBI<HAEIHINDMNN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object HGPJBMDALGM
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x3BF1B60", Offset = "0x3BF0560", VA = "0x183BF1B60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool EGCLBBKIMPB
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int OINFOILACMA
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x5614180", Offset = "0x5612B80", VA = "0x185614180", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public KIPLJPBBIKH IGGHFEBKMJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x5614120", Offset = "0x5612B20", VA = "0x185614120", Slot = "10")]
			get
			{
				return default(KIPLJPBBIKH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string FKFNIOMEPLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x5614770", Offset = "0x5613170", VA = "0x185614770", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool KLMPMMOLOKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public NOPFJADADBI<POHIJOMDHHG> MLABGCIONFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x9E5040", Offset = "0x9E3A40", VA = "0x1809E5040", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(NOPFJADADBI<POHIJOMDHHG>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x9E53B0", Offset = "0x9E3DB0", VA = "0x1809E53B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool PGJDODLBDEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool CGFKGPCIKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual FMKBAAOAPCG FBDFBPMHKOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0xAD65B0", Offset = "0xAD4FB0", VA = "0x180AD65B0", Slot = "96")]
			get
			{
				return default(FMKBAAOAPCG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool JKGCOHPMKGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x5613E30", Offset = "0x5612830", VA = "0x185613E30", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool DEBEPLPOHKI
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x5613EA0", Offset = "0x56128A0", VA = "0x185613EA0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool KPMOIDHBKHL
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x5613F10", Offset = "0x5612910", VA = "0x185613F10", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int FGCNPBEDNBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x56144F0", Offset = "0x5612EF0", VA = "0x1856144F0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool BLFGPEIKGAK
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x5614310", Offset = "0x5612D10", VA = "0x185614310", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool CFKPKEHPMMC
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x5614040", Offset = "0x5612A40", VA = "0x185614040", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool EHCCJPBAJOI
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x5613FD0", Offset = "0x56129D0", VA = "0x185613FD0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool PHEKJCIMDEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0xA9E200", Offset = "0xA9CC00", VA = "0x180A9E200", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0xFBB0B0", Offset = "0xFB9AB0", VA = "0x180FBB0B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool GKFLJGDCBAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "97")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool BPKJDCBANND
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x5613F80", Offset = "0x5612980", VA = "0x185613F80", Slot = "98")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool CFPMJGHBLFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x5614240", Offset = "0x5612C40", VA = "0x185614240", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public PIGKNMNIKBG IOMJHJIHLGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x5614430", Offset = "0x5612E30", VA = "0x185614430", Slot = "28")]
			get
			{
				return default(PIGKNMNIKBG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public LEFNAMLLENO FGEPHFKCKHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x5614490", Offset = "0x5612E90", VA = "0x185614490", Slot = "30")]
			get
			{
				return default(LEFNAMLLENO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool MLMDOJGKBAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual DMFHAJNKFLK? FAGBKGIMIFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual AABGOFGDPFJ? BBCGOPDFJOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "112")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<LNNCPMKFMDI<HAPKHKKGAFF>>? HGAJKKLIAIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool BJHCNFPJPGI
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x56140B0", Offset = "0x5612AB0", VA = "0x1856140B0", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public LNNCPMKFMDI<AEAAGMJLLLI> AJLDLCAMOPE
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x5614370", Offset = "0x5612D70", VA = "0x185614370", Slot = "62")]
			get
			{
				return default(LNNCPMKFMDI<AEAAGMJLLLI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public NOPFJADADBI<AEAAGMJLLLI> GBBAEGKGHJD
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x56141E0", Offset = "0x5612BE0", VA = "0x1856141E0", Slot = "56")]
			get
			{
				return default(NOPFJADADBI<AEAAGMJLLLI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool DNJHDJOPIFA
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual NOPFJADADBI<AEAAGMJLLLI>? LPCIFHMMIIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool DGGHOOEPFDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "119")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool LNBHJKPBPHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x56142A0", Offset = "0x5612CA0", VA = "0x1856142A0", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x8B96F0", Offset = "0x8B80F0", VA = "0x1808B96F0", Slot = "65")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x8B9690", Offset = "0x8B8090", VA = "0x1808B9690")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string HGIKLHEGAOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x8B96A0", Offset = "0x8B80A0", VA = "0x1808B96A0", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x8B96D0", Offset = "0x8B80D0", VA = "0x1808B96D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public NOPFJADADBI<HAPKHKKGAFF> PCCFHBFOIHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x56145E0", Offset = "0x5612FE0", VA = "0x1856145E0", Slot = "63")]
			get
			{
				return default(NOPFJADADBI<HAPKHKKGAFF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public LNNCPMKFMDI<HAPKHKKGAFF> IMCFDKINEFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x56143D0", Offset = "0x5612DD0", VA = "0x1856143D0", Slot = "64")]
			get
			{
				return default(LNNCPMKFMDI<HAPKHKKGAFF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public LNNCPMKFMDI<HAPKHKKGAFF>? CBEENHPCIDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x5614640", Offset = "0x5613040", VA = "0x185614640", Slot = "120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public INBOFADIBMC<IMNAGMIGBGO, JGOIMAGMGIM> HOPEJENNGGD
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x5614730", Offset = "0x5613130", VA = "0x185614730", Slot = "67")]
			get
			{
				return default(INBOFADIBMC<IMNAGMIGBGO, JGOIMAGMGIM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual NOPFJADADBI<IMNAGMIGBGO>? NLCDLGOBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool ONIDFMKHKGD
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "124")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public virtual bool MPMJDEAILKB
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "125")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CKDPKLLHLEH
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x5613780", Offset = "0x5612180", VA = "0x185613780", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x56122E0", Offset = "0x5610CE0", VA = "0x1856122E0", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event IIJGMFDGPGG FGMNGFINFGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x560F490", Offset = "0x560DE90", VA = "0x18560F490", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x560F150", Offset = "0x560DB50", VA = "0x18560F150", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event EFDOHMADBHH GNKDBFJBOLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x5611D80", Offset = "0x5610780", VA = "0x185611D80", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x5610430", Offset = "0x560EE30", VA = "0x185610430", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action JDBJEKKNOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x5610AE0", Offset = "0x560F4E0", VA = "0x185610AE0", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x56103D0", Offset = "0x560EDD0", VA = "0x1856103D0", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action OLELJIKKJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x5611810", Offset = "0x5610210", VA = "0x185611810", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x560EE80", Offset = "0x560D880", VA = "0x18560EE80", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<NOPFJADADBI<IMNAGMIGBGO>, JGOIMAGMGIM> NJPPMOBMPIA
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x560F7D0", Offset = "0x560E1D0", VA = "0x18560F7D0", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x56118B0", Offset = "0x56102B0", VA = "0x1856118B0", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<NOPFJADADBI<IMNAGMIGBGO>, JGOIMAGMGIM> FHNDENIHHMO
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x560F340", Offset = "0x560DD40", VA = "0x18560F340", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x560F650", Offset = "0x560E050", VA = "0x18560F650", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<NOPFJADADBI<IMNAGMIGBGO>> ALDKOMGFPCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x560F090", Offset = "0x560DA90", VA = "0x18560F090", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x560F890", Offset = "0x560E290", VA = "0x18560F890", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<NOPFJADADBI<IMNAGMIGBGO>, NOPFJADADBI<IMNAGMIGBGO>> JJJGDBBLHIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x5612E40", Offset = "0x5611840", VA = "0x185612E40", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x560F710", Offset = "0x560E110", VA = "0x18560F710", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<NOPFJADADBI<IMNAGMIGBGO>, JGOIMAGMGIM> EDGOGIMCDLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x560EF20", Offset = "0x560D920", VA = "0x18560EF20", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x56128F0", Offset = "0x56112F0", VA = "0x1856128F0", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<NOPFJADADBI<IMNAGMIGBGO>, NOPFJADADBI<IMNAGMIGBGO>> GGGHAEPKLFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x5611750", Offset = "0x5610150", VA = "0x185611750", Slot = "79")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x560F530", Offset = "0x560DF30", VA = "0x18560F530", Slot = "80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x5613820", Offset = "0x5612220", VA = "0x185613820")]
		[IEODDIDMNFH("Need to handle `Name` better.")]
		[IEODDIDMNFH("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected CLCKKODOECE(JLDPKGEOPEJ DAKMLHHEJJO, TNode OFGAFPGJIKO, bool IDACGFEICKE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x5610E80", Offset = "0x560F880", VA = "0x185610E80", Slot = "89")]
		protected virtual void GCHKJEOLKFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x560F950", Offset = "0x560E350", VA = "0x18560F950", Slot = "90")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x560EFE0", Offset = "0x560D9E0", VA = "0x18560EFE0", Slot = "9")]
		[AsyncStateMachine(typeof(CLCKKODOECE<>.LOFKIDOPGHD))]
		public void ALHKNEHPJCC(int LDFFADFEPAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x5613500", Offset = "0x5611F00", VA = "0x185613500")]
		public bool PLDMDHNKBDI([In] PIGKNMNIKBG PKCLPFEIPFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x5610360", Offset = "0x560ED60", VA = "0x185610360")]
		public bool EDNJBFOLMJC([In] LEFNAMLLENO PKCLPFEIPFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x5613570", Offset = "0x5611F70", VA = "0x185613570", Slot = "32")]
		public void PNALCFFAOCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x5612F50", Offset = "0x5611950", VA = "0x185612F50", Slot = "33")]
		[AsyncStateMachine(typeof(CLCKKODOECE<>.LKEKPPPKOKI))]
		public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> MOPEMFAFGLP(PIGKNMNIKBG? MBNCLINCGNN, LEFNAMLLENO? OMHOPFBFJAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "99")]
		public virtual void CJKGGKLBLBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "100")]
		public virtual void JBNAPHLKBFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "101")]
		public virtual void FNMHGJBBCCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA855C0", Offset = "0xA83FC0", VA = "0x180A855C0")]
		protected void GBAJGMFIOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x993270", Offset = "0x991C70", VA = "0x180993270")]
		protected void DBMIAABNIOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x247D600", Offset = "0x247C000", VA = "0x18247D600")]
		private void JPGOMIBHDMN([In] LEFNAMLLENO MHLCHCEFDAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x5610A10", Offset = "0x560F410", VA = "0x185610A10", Slot = "102")]
		public virtual Task<OKPKCEBGDLD<NOPFJADADBI<IMNAGMIGBGO>, NJDGKLFLKEH>> EMDJAKPEBAG(string JHJFHDOAMLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x5610BB0", Offset = "0x560F5B0", VA = "0x185610BB0", Slot = "103")]
		public virtual Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> FFHMIAMHCEJ(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "104")]
		public virtual void CKKLKAKODPO(NOPFJADADBI<IMNAGMIGBGO> KEMPCMAAPPH, NOPFJADADBI<IMNAGMIGBGO> BPJNKIKLOJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x5612250", Offset = "0x5610C50", VA = "0x185612250", Slot = "105")]
		public virtual IEnumerable<LEOAEGKNMKP> KDPALKFBEIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x560F400", Offset = "0x560DE00", VA = "0x18560F400", Slot = "106")]
		public OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH> BJJODICHBAO(string PIJAOIJPMFA)
		{
			return default(OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x560F1F0", Offset = "0x560DBF0", VA = "0x18560F1F0", Slot = "47")]
		public bool BFKPPDOLFAA([Out] Guid ANNFOGJFBPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x560EBC0", Offset = "0x560D5C0", VA = "0x18560EBC0")]
		public bool AKLLJDILHPL([In] Guid LIMKMANPJJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "107")]
		public virtual void ENPPBKGKMKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "108")]
		public virtual void CHAHCEPOMKP(bool NBFMHNLAKLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "109")]
		public virtual GJDOCADKEMG EDBEACDFMGO([In] BKKLPJIDOHD FIEGLPDHAMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x5610C80", Offset = "0x560F680", VA = "0x185610C80")]
		protected void FICPGJNHPEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x5610320", Offset = "0x560ED20", VA = "0x185610320", Slot = "114")]
		protected virtual bool ECHALLHFPKP(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "115")]
		protected virtual bool AMAFGAPLGEP(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "122")]
		protected virtual void IDPLFPMEDKB(GKGPCBCAOGC NDDCDHPCJCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x5612380", Offset = "0x5610D80", VA = "0x185612380")]
		protected void KKIIOFBLEBM(GKGPCBCAOGC JLHJCAJMIJE, Func<string> PIBNMDMMBBJ, Action<string> MEPPLLGMBHG, string FHNIMDODOJC, string OPCMAGCBCMM, string LOAHBLPDIGF, CDGJHKAFLGO IKDOGGKHDLA, BOGNDEMCALM NDMJLHMHINL, Func<string, bool> MJEMAFLKNEE, string EFPKKLJOLLK, Func<string, bool> JOIDOCFKMEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x5611F50", Offset = "0x5610950", VA = "0x185611F50")]
		protected void KBPMHMILNJG(GKGPCBCAOGC JLHJCAJMIJE, Func<string> PIBNMDMMBBJ, Action<string> MEPPLLGMBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x5613200", Offset = "0x5611C00", VA = "0x185613200", Slot = "123")]
		protected virtual void NOEFJOEDHNH(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x5612F00", Offset = "0x5611900", VA = "0x185612F00", Slot = "82")]
		public void MBJNOFJDAHB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x56133C0", Offset = "0x5611DC0", VA = "0x1856133C0", Slot = "83")]
		public IPKEGCJHFGM OIHIBIGLDOP()
		{
			return default(IPKEGCJHFGM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "126")]
		public virtual bool LCONFNGKJMP(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x184F280", Offset = "0x184DC80", VA = "0x18184F280")]
		private void JHLBLOKNBKC([In] PIGKNMNIKBG PCPIJKGKPCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x5612790", Offset = "0x5611190", VA = "0x185612790")]
		private void KMGEPOFACGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x56104D0", Offset = "0x560EED0", VA = "0x1856104D0")]
		private void EJPMBMJDIGE(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, JHIFFFEJNGA JHKFPFDKACD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xBD6CD0", Offset = "0xBD56D0", VA = "0x180BD6CD0")]
		private void JHMADOHFDOH(NOPFJADADBI<IMNAGMIGBGO> CMEADPACGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x5611E20", Offset = "0x5610820", VA = "0x185611E20")]
		private void JOBGPJNCCKK(NOPFJADADBI<IMNAGMIGBGO> CMEADPACGME, JHIFFFEJNGA IILDPCCAEKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x56129B0", Offset = "0x56113B0", VA = "0x1856129B0")]
		private void LDHPAOJFGIM(NOPFJADADBI<IMNAGMIGBGO> KEMPCMAAPPH, NOPFJADADBI<IMNAGMIGBGO> BPJNKIKLOJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xBD78C0", Offset = "0xBD62C0", VA = "0x180BD78C0")]
		private void LPGMONDBLKA(NOPFJADADBI<IMNAGMIGBGO> KEMPCMAAPPH, NOPFJADADBI<IMNAGMIGBGO> BPJNKIKLOJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x52AB5B0", Offset = "0x52A9FB0", VA = "0x1852AB5B0")]
		private void MAELIOJCOFM(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x5611970", Offset = "0x5610370", VA = "0x185611970")]
		private void IKPAMPBCMLA(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, JHIFFFEJNGA JHKFPFDKACD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x5612DD0", Offset = "0x56117D0", VA = "0x185612DD0")]
		private void LPIKJKNOLMH(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, JHIFFFEJNGA IILDPCCAEKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x56130E0", Offset = "0x5611AE0", VA = "0x1856130E0", Slot = "127")]
		[AsyncStateMachine(typeof(CLCKKODOECE<>.CHHAEPOOFJB))]
		public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> NMMOBONMCHP(string PIJAOIJPMFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x56116E0", Offset = "0x56100E0", VA = "0x1856116E0", Slot = "54")]
		private void GKLAKCKCEII(object NIICOGADNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x5612D60", Offset = "0x5611760", VA = "0x185612D60", Slot = "55")]
		private void LEKKFJMNEEE(object NIICOGADNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x56134C0", Offset = "0x5611EC0", VA = "0x1856134C0", Slot = "29")]
		private bool OOEDAMNMFEH([In] PIGKNMNIKBG PKCLPFEIPFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x56102E0", Offset = "0x560ECE0", VA = "0x1856102E0", Slot = "31")]
		private bool EBACELNHEFM([In] LEFNAMLLENO PKCLPFEIPFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x56130A0", Offset = "0x5611AA0", VA = "0x1856130A0", Slot = "48")]
		private bool NEMBOOAFOEB([In] Guid LIMKMANPJJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x510E0E0", Offset = "0x510CAE0", VA = "0x18510E0E0")]
		[CompilerGenerated]
		private string EFPCIMFCHDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x5610230", Offset = "0x560EC30", VA = "0x185610230")]
		[CompilerGenerated]
		private void EAIEANEDNFL(string JHJFHDOAMLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class LEDOGDPJJHE : GJOBNMEDLBN<MBLFFHKPIKH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x931D20", Offset = "0x930720", VA = "0x180931D20", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x22726F0", Offset = "0x22710F0", VA = "0x1822726F0")]
		public LEDOGDPJJHE(JLDPKGEOPEJ DAKMLHHEJJO, MBLFFHKPIKH OFGAFPGJIKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private sealed class NOILFDDNHFE : JJMFPJJAEIG<ANFBNBNOEHJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x941F40", Offset = "0x940940", VA = "0x180941F40", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x22739A0", Offset = "0x22723A0", VA = "0x1822739A0")]
		public NOILFDDNHFE(JLDPKGEOPEJ DAKMLHHEJJO, ANFBNBNOEHJ OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public abstract class GOBEILMFPDJ<T> : CLCKKODOECE<T> where T : notnull, PFILEAKMMFC
	{
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private sealed class LFDOKJOAMNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public IReadOnlyList<KeyValuePair<string, PHCGGPIMKIC>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public GOBEILMFPDJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public BMCMNKGELFP clipType;

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public LFDOKJOAMNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
			internal IReadOnlyList<KeyValuePair<string, PHCGGPIMKIC>> PCAMJMMFJCO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x4664A50", Offset = "0x4663450", VA = "0x184664A50")]
			internal int CLCMLCCEFKP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x4664830", Offset = "0x4663230", VA = "0x184664830")]
			internal void CJLHFJFDNAK(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x4664E40", Offset = "0x4663840", VA = "0x184664E40")]
			internal void MKKNACCAEML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x4664E90", Offset = "0x4663890", VA = "0x184664E90")]
			internal void NDPCAAEAIOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x4664740", Offset = "0x4663140", VA = "0x184664740")]
			internal bool BCDMOLLGAEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x4664DF0", Offset = "0x46637F0", VA = "0x184664DF0")]
			internal void ICGFCKNGHHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x4664740", Offset = "0x4663140", VA = "0x184664740")]
			internal bool PBCPLFKNLHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x4664680", Offset = "0x4663080", VA = "0x184664680")]
			internal float AMNGKOPJEGE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x4664BB0", Offset = "0x46635B0", VA = "0x184664BB0")]
			internal void CPKHNDLEINA(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x46646E0", Offset = "0x46630E0", VA = "0x1846646E0")]
			internal float BBLHILOPHDF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x4664C70", Offset = "0x4663670", VA = "0x184664C70")]
			internal void DPLKPKIFKGL(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x46647D0", Offset = "0x46631D0", VA = "0x1846647D0")]
			internal float BMEEMEHKLBL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x4664D30", Offset = "0x4663730", VA = "0x184664D30")]
			internal void FHPOMEOHEMJ(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0xBEBBF0", Offset = "0xBEA5F0", VA = "0x180BEBBF0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public abstract BMCMNKGELFP EJJMAPJLIIH
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(Slot = "128")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x411E4E0", Offset = "0x411CEE0", VA = "0x18411E4E0")]
		public GOBEILMFPDJ(JLDPKGEOPEJ DAKMLHHEJJO, T OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x411D9C0", Offset = "0x411C3C0", VA = "0x18411D9C0", Slot = "122")]
		protected sealed override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private sealed class DCFFOOCGBCF : CLCKKODOECE<LAJAGCEGNBO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x930C00", Offset = "0x92F600", VA = "0x180930C00", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x2261C90", Offset = "0x2260690", VA = "0x182261C90")]
		public DCFFOOCGBCF(JLDPKGEOPEJ DAKMLHHEJJO, LAJAGCEGNBO OFGAFPGJIKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class LJJJKECCILK : CLCKKODOECE<AEFEFDMDCON>
	{
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class OBPDONPFJLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public LJJJKECCILK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public OBPDONPFJLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x2273E30", Offset = "0x2272830", VA = "0x182273E30")]
			internal int CLCMLCCEFKP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x2273DA0", Offset = "0x22727A0", VA = "0x182273DA0")]
			internal void CJLHFJFDNAK(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private static Dictionary<string, PHCGGPIMKIC>? JEDBJIDNPPM;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x2272FA0", Offset = "0x22719A0", VA = "0x182272FA0")]
		public LJJJKECCILK(JLDPKGEOPEJ DAKMLHHEJJO, AEFEFDMDCON OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x2272C30", Offset = "0x2271630", VA = "0x182272C30", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public sealed class KDBDLFBGHFG : GOBEILMFPDJ<NAAGHCIEHPB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override BMCMNKGELFP EJJMAPJLIIH
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "128")]
			get
			{
				return default(BMCMNKGELFP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x226ABC0", Offset = "0x22695C0", VA = "0x18226ABC0")]
		public KDBDLFBGHFG(JLDPKGEOPEJ DAKMLHHEJJO, NAAGHCIEHPB OAAFMJBAJGL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private sealed class KLLNNCKBPFH : JJMFPJJAEIG<AOILDAFLILF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x941F40", Offset = "0x940940", VA = "0x180941F40", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x22722D0", Offset = "0x2270CD0", VA = "0x1822722D0")]
		public KLLNNCKBPFH(JLDPKGEOPEJ DAKMLHHEJJO, AOILDAFLILF OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private sealed class EDLDHJOKCLK : JJMFPJJAEIG<EKCCDEDMMEL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x941F40", Offset = "0x940940", VA = "0x180941F40", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x22632E0", Offset = "0x2261CE0", VA = "0x1822632E0")]
		public EDLDHJOKCLK(JLDPKGEOPEJ DAKMLHHEJJO, EKCCDEDMMEL OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class PMODAIMLLNF : KKHNKODEBNA<GJDJLODDMPD>
	{
		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class JFJLEFOGMDO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				public JFJLEFOGMDO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0x2275250", Offset = "0x2273C50", VA = "0x182275250", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public PMODAIMLLNF <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public JFJLEFOGMDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x2269CB0", Offset = "0x22686B0", VA = "0x182269CB0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void HOLGDMEPDKG(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x22751F0", Offset = "0x2273BF0", VA = "0x1822751F0")]
		public PMODAIMLLNF(JLDPKGEOPEJ DAKMLHHEJJO, GJDJLODDMPD OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x2274F10", Offset = "0x2273910", VA = "0x182274F10", Slot = "128")]
		protected override void LBBFKPDLJNI(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public sealed class BOIIHFLBEPG : GOBEILMFPDJ<ONHOBKIJBCM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override BMCMNKGELFP EJJMAPJLIIH
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x941530", Offset = "0x93FF30", VA = "0x180941530", Slot = "128")]
			get
			{
				return default(BMCMNKGELFP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x225AAD0", Offset = "0x22594D0", VA = "0x18225AAD0")]
		public BOIIHFLBEPG(JLDPKGEOPEJ DAKMLHHEJJO, ONHOBKIJBCM OAAFMJBAJGL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private sealed class CPPPDOGJDIO : CLCKKODOECE<MHCMLGJIIPA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0xC587D0", Offset = "0xC571D0", VA = "0x180C587D0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x22618A0", Offset = "0x22602A0", VA = "0x1822618A0")]
		public CPPPDOGJDIO(JLDPKGEOPEJ DAKMLHHEJJO, MHCMLGJIIPA OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class IGFKGPMOOEF : CLCKKODOECE<EOBEFGBCJLG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public sealed override bool PGJDODLBDEB
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected sealed override bool KLMPMMOLOKH
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x2267140", Offset = "0x2265B40", VA = "0x182267140")]
		public IGFKGPMOOEF(JLDPKGEOPEJ DAKMLHHEJJO, EOBEFGBCJLG OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2266E10", Offset = "0x2265810", VA = "0x182266E10", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2266D70", Offset = "0x2265770", VA = "0x182266D70")]
		private int FCPIOIJGGFG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2266DB0", Offset = "0x22657B0", VA = "0x182266DB0")]
		private void FLCCGGFMIPN(int COJJJGIBKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class NMIICKHDILL : PHJNHOFEGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x22738D0", Offset = "0x22722D0", VA = "0x1822738D0")]
		public NMIICKHDILL(JLDPKGEOPEJ DAKMLHHEJJO, AELHMIHCAOH OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class ADIDCFONPGB : KKHNKODEBNA<HAIEKPOPHDH>
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x2259880", Offset = "0x2258280", VA = "0x182259880")]
		public ADIDCFONPGB(JLDPKGEOPEJ DAKMLHHEJJO, HAIEKPOPHDH OFGAFPGJIKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public abstract class KKHNKODEBNA<TVariableNode> : CLCKKODOECE<TVariableNode> where TVariableNode : notnull, HAIEKPOPHDH
	{
		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private sealed class EAHCNHMGJCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public KKHNKODEBNA<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public EAHCNHMGJCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x3B61A70", Offset = "0x3B60470", VA = "0x183B61A70")]
			internal bool PCAMJMMFJCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x3B61840", Offset = "0x3B60240", VA = "0x183B61840")]
			internal void CLCMLCCEFKP(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x3B617E0", Offset = "0x3B601E0", VA = "0x183B617E0")]
			internal bool CJLHFJFDNAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x3B61900", Offset = "0x3B60300", VA = "0x183B61900")]
			internal void MKKNACCAEML(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x3B619C0", Offset = "0x3B603C0", VA = "0x183B619C0")]
			internal bool NDPCAAEAIOM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class DHIHLPEBMBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public OPNMKJDFIKH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public KKHNKODEBNA<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public DHIHLPEBMBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x5C84C20", Offset = "0x5C83620", VA = "0x185C84C20")]
			internal void HOLGDMEPDKG(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override NodeVisualizationKey HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x932500", Offset = "0x930F00", VA = "0x180932500", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public override FMKBAAOAPCG FBDFBPMHKOA
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x4562740", Offset = "0x4561140", VA = "0x184562740", Slot = "96")]
			get
			{
				return default(FMKBAAOAPCG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x4562590", Offset = "0x4560F90", VA = "0x184562590")]
		protected KKHNKODEBNA(JLDPKGEOPEJ DAKMLHHEJJO, TVariableNode OFGAFPGJIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x4561AA0", Offset = "0x45604A0", VA = "0x184561AA0", Slot = "90")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x4561D40", Offset = "0x4560740", VA = "0x184561D40", Slot = "122")]
		protected override void IDPLFPMEDKB(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x45621F0", Offset = "0x4560BF0", VA = "0x1845621F0", Slot = "128")]
		protected virtual void LBBFKPDLJNI(GKGPCBCAOGC JLHJCAJMIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x4561C40", Offset = "0x4560640", VA = "0x184561C40", Slot = "107")]
		public override void ENPPBKGKMKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2254A90", Offset = "0x2253490", VA = "0x182254A90")]
	public static FGJHFGGJHDK AELHPDENENI(JLDPKGEOPEJ DAKMLHHEJJO, AELHMIHCAOH OFGAFPGJIKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public sealed class JCIALCGBCNG : IDKLBBDALLD, IHLPIHDDJKP, DNCDFCBKAAH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public NOPFJADADBI<PIDGEANHJGE> AEBONCBGDKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x948EE0", Offset = "0x9478E0", VA = "0x180948EE0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(NOPFJADADBI<PIDGEANHJGE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public NOPFJADADBI<LKGHPCANGJP> LFJPKPBBGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xA22570", Offset = "0xA20F70", VA = "0x180A22570", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(NOPFJADADBI<LKGHPCANGJP>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x2269990", Offset = "0x2268390", VA = "0x182269990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private NOPFJADADBI<HDHAJHHMIEL> IMFOHBJEJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x93D860", Offset = "0x93C260", VA = "0x18093D860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public override NOPFJADADBI<KLADBCIODBD> HJMOFBBNEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x2269940", Offset = "0x2268340", VA = "0x182269940", Slot = "20")]
		get
		{
			return default(NOPFJADADBI<KLADBCIODBD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x22699A0", Offset = "0x22683A0", VA = "0x1822699A0")]
	private JCIALCGBCNG(JLDPKGEOPEJ DAKMLHHEJJO, AELHMIHCAOH OFGAFPGJIKO, HKGBHCONPKL JOMIMHFJGHP, NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, NOPFJADADBI<LKGHPCANGJP> AIAAIMOKNLI, NOPFJADADBI<HDHAJHHMIEL> DLNHNMIIKAN, bool DCBNNAGJMNJ, string JHJFHDOAMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x22695F0", Offset = "0x2267FF0", VA = "0x1822695F0")]
	public static JCIALCGBCNG AELHPDENENI(JLDPKGEOPEJ DAKMLHHEJJO, AELHMIHCAOH OFGAFPGJIKO, HKGBHCONPKL JFBDPBFFKPN, NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, NOPFJADADBI<HDHAJHHMIEL> DLNHNMIIKAN, NOPFJADADBI<LKGHPCANGJP> AIAAIMOKNLI, bool DCBNNAGJMNJ, bool IDACGFEICKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2269990", Offset = "0x2268390", VA = "0x182269990")]
	internal void GLLFEOCAMKO(NOPFJADADBI<LKGHPCANGJP> PKCLPFEIPFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public abstract class IDKLBBDALLD : DNCDFCBKAAH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private struct HJPOLHLMCDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private FGJKIMFIAIH? MNJBFBGNLAO;

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x2264A20", Offset = "0x2263420", VA = "0x182264A20")]
		public void CFGGIHGKNGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x2264A30", Offset = "0x2263430", VA = "0x182264A30")]
		public FGJKIMFIAIH EBNMCBFEJOA(IDKLBBDALLD NFPPNNOPNAJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	protected readonly JLDPKGEOPEJ KFPFICPDKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	protected readonly AELHMIHCAOH KIDLFDDGBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private HJPOLHLMCDL MFFAJBBEFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly KLFGOONOBKJ IBACKEDGGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly List<DDNDCMBKCLL> BMFDGECGLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly List<CLANPMBKAFD> ICCJMAKKCLE;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	[IEODDIDMNFH("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> OGFNAPOENBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2265750", Offset = "0x2264150", VA = "0x182265750", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public DisplayKind NGNHAIHHFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x8BBFB0", Offset = "0x8BA9B0", VA = "0x1808BBFB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public NOPFJADADBI<AEAAGMJLLLI> GBBAEGKGHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x2265F80", Offset = "0x2264980", VA = "0x182265F80", Slot = "6")]
		get
		{
			return default(NOPFJADADBI<AEAAGMJLLLI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public LNNCPMKFMDI<AEAAGMJLLLI> AJLDLCAMOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x2265DC0", Offset = "0x22647C0", VA = "0x182265DC0", Slot = "7")]
		get
		{
			return default(LNNCPMKFMDI<AEAAGMJLLLI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public PKMBJGLAFPA BCMOBHBMNBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x914ED0", Offset = "0x9138D0", VA = "0x180914ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public INOBDAKCMBN LEPOIPAMOCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x2266220", Offset = "0x2264C20", VA = "0x182266220", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	protected FGJKIMFIAIH KONAMNECOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x2266220", Offset = "0x2264C20", VA = "0x182266220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public PortImage ILFCDOJHCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x2266090", Offset = "0x2264A90", VA = "0x182266090", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public string OENPDLODONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x8B0160", Offset = "0x8AEB60", VA = "0x1808B0160", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8B0120", Offset = "0x8AEB20", VA = "0x1808B0120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public LNNCPMKFMDI<HAPKHKKGAFF> IMCFDKINEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x2265DA0", Offset = "0x22647A0", VA = "0x182265DA0", Slot = "9")]
		get
		{
			return default(LNNCPMKFMDI<HAPKHKKGAFF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public NOPFJADADBI<IMNAGMIGBGO> BLBDMFGNMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xA0CA60", Offset = "0xA0B460", VA = "0x180A0CA60", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(NOPFJADADBI<IMNAGMIGBGO>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xA0C6B0", Offset = "0xA0B0B0", VA = "0x180A0C6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public abstract NOPFJADADBI<KLADBCIODBD> HJMOFBBNEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2266950", Offset = "0x2265350", VA = "0x182266950")]
	protected IDKLBBDALLD(JLDPKGEOPEJ DAKMLHHEJJO, AELHMIHCAOH OFGAFPGJIKO, KLFGOONOBKJ AJIDDAEJHAF, NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, bool DCBNNAGJMNJ, string JHJFHDOAMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2265AA0", Offset = "0x22644A0", VA = "0x182265AA0", Slot = "21")]
	protected virtual void GCHKJEOLKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x22658F0", Offset = "0x22642F0", VA = "0x1822658F0", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x22661C0", Offset = "0x2264BC0", VA = "0x1822661C0", Slot = "14")]
	public void KIJMCMGGMML(DDNDCMBKCLL JDEHDHNEPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2266030", Offset = "0x2264A30", VA = "0x182266030", Slot = "15")]
	public void JMAJDKKOBHF(CLANPMBKAFD JDEHDHNEPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x22662C0", Offset = "0x2264CC0", VA = "0x1822662C0", Slot = "16")]
	public void NGHELGAPMCO(HNFOBOHIGFL MOPHMGOOGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2265FB0", Offset = "0x22649B0", VA = "0x182265FB0", Slot = "23")]
	protected virtual void JFOJDGLOHDO(HNFOBOHIGFL MOPHMGOOGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x2265DF0", Offset = "0x22647F0", VA = "0x182265DF0")]
	private void HKNOLFGKAIN(bool HBABIBCNPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x2265BF0", Offset = "0x22645F0", VA = "0x182265BF0")]
	private void GEFOCHGGBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x22655A0", Offset = "0x2263FA0", VA = "0x1822655A0")]
	private void CDFLBPGPNAE([In] ALKALDJCLIB JMMIAPOLAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2265A40", Offset = "0x2264440", VA = "0x182265A40", Slot = "17")]
	public void EPCKHEICABP(DDNDCMBKCLL JDEHDHNEPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2265890", Offset = "0x2264290", VA = "0x182265890", Slot = "18")]
	public void DLPDFEFKCMG(CLANPMBKAFD JDEHDHNEPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x8B0120", Offset = "0x8AEB20", VA = "0x1808B0120")]
	internal void AIJNBDBIBDA(string JHJFHDOAMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x2266010", Offset = "0x2264A10", VA = "0x182266010")]
	internal void JHOBHNDKMGM(KHGCHLLICLI JOIGIEDFOGO, PKMBJGLAFPA BKKHBFLPOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0xA0C6B0", Offset = "0xA0B0B0", VA = "0x180A0C6B0")]
	internal void KJCFJJMJDDD(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class COFJCJNKHJE : JGOIMAGMGIM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class JHACILNFAML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public JLDPKGEOPEJ circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public AELHMIHCAOH node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public NOPFJADADBI<IMNAGMIGBGO> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public JHACILNFAML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2269D80", Offset = "0x2268780", VA = "0x182269D80")]
		internal HGKNBEFOHOK AHDLDMBMBBF((int PortDescIndex, int PortIndex, ILKNMOMCCKI InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2269E10", Offset = "0x2268810", VA = "0x182269E10")]
		internal JCIALCGBCNG GIGACPKNHJO(HKGBHCONPKL i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct AEHMNHMAKKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public COFJCJNKHJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private BJOPPGIOJJG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x22598E0", Offset = "0x22582E0", VA = "0x1822598E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2259D40", Offset = "0x2258740", VA = "0x182259D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct LEMNCHANMJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public COFJCJNKHJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public NOPFJADADBI<JDCGCGCDEHJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private BJOPPGIOJJG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2272750", Offset = "0x2271150", VA = "0x182272750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2272AA0", Offset = "0x22714A0", VA = "0x182272AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct GOBFEEDBMDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public COFJCJNKHJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public NOPFJADADBI<HDHAJHHMIEL> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private BJOPPGIOJJG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2264600", Offset = "0x2263000", VA = "0x182264600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2264950", Offset = "0x2263350", VA = "0x182264950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct KLPPFAEPAKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public COFJCJNKHJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public NOPFJADADBI<JDCGCGCDEHJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public NOPFJADADBI<JDCGCGCDEHJ> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private BJOPPGIOJJG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2272330", Offset = "0x2270D30", VA = "0x182272330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2272680", Offset = "0x2271080", VA = "0x182272680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct IOMDAHGLOEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public COFJCJNKHJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public NOPFJADADBI<HDHAJHHMIEL> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public NOPFJADADBI<HDHAJHHMIEL> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private BJOPPGIOJJG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2269230", Offset = "0x2267C30", VA = "0x182269230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2269580", Offset = "0x2267F80", VA = "0x182269580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct MPBBNOOEFHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public COFJCJNKHJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private BJOPPGIOJJG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x22730D0", Offset = "0x2271AD0", VA = "0x1822730D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2273540", Offset = "0x2271F40", VA = "0x182273540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct GKABIHCOONI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public COFJCJNKHJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private BJOPPGIOJJG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2263ED0", Offset = "0x22628D0", VA = "0x182263ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2264220", Offset = "0x2262C20", VA = "0x182264220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct OOMGPJDOHGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public COFJCJNKHJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public NOPFJADADBI<JDCGCGCDEHJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private BJOPPGIOJJG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2274330", Offset = "0x2272D30", VA = "0x182274330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2274680", Offset = "0x2273080", VA = "0x182274680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct AMIHLHPPHLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public COFJCJNKHJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public NOPFJADADBI<HDHAJHHMIEL> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private BJOPPGIOJJG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x225A1D0", Offset = "0x2258BD0", VA = "0x18225A1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x225A520", Offset = "0x2258F20", VA = "0x18225A520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct EOIPIJDFFIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public COFJCJNKHJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public FMKOOFOBEMG type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public NOPFJADADBI<JDCGCGCDEHJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private BJOPPGIOJJG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x2263340", Offset = "0x2261D40", VA = "0x182263340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x22636D0", Offset = "0x22620D0", VA = "0x1822636D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct JJNFNAEMCGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public COFJCJNKHJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public FMKOOFOBEMG type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public NOPFJADADBI<HDHAJHHMIEL> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private BJOPPGIOJJG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x226A5D0", Offset = "0x2268FD0", VA = "0x18226A5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x226A960", Offset = "0x2269360", VA = "0x18226A960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly bool EGOJFHKBNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly JLDPKGEOPEJ KFPFICPDKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private readonly bool ONPKNJFENDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private INBOFADIBMC<LLAADLDMCOH, HGKNBEFOHOK> BCLMLOBMLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private INBOFADIBMC<LLAADLDMCOH, OGIGJDHBOLA> CGBPBEMJNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly AELHMIHCAOH KIDLFDDGBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private INBOFADIBMC<LKGHPCANGJP, JCIALCGBCNG> KIMLFJADBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private INBOFADIBMC<LKGHPCANGJP, IHLPIHDDJKP> NNOGMMBPCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private string? HMMHBLDEPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly JHIFFFEJNGA IKNMNJJLBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private NOPFJADADBI<IMNAGMIGBGO> PLIMMMDBMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly bool CGGAOOKFMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	[CompilerGenerated]
	private Action? BCEAMMELFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	[CompilerGenerated]
	private Action? EDEIDIKJLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	[CompilerGenerated]
	private Action<NOPFJADADBI<LLAADLDMCOH>>? LILIDJNMLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[CompilerGenerated]
	private Action<NOPFJADADBI<LKGHPCANGJP>>? IFEJENNFBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	[CompilerGenerated]
	private JGOIMAGMGIM.NPGCFBNJJGA? AOAJIBAPONC;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool EJFLENNDKCD
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x22611C0", Offset = "0x225FBC0", VA = "0x1822611C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool OPKBGPFEBPP
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x225F700", Offset = "0x225E100", VA = "0x18225F700", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool NADAPLFEFBC
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x225C5E0", Offset = "0x225AFE0", VA = "0x18225C5E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public LNNCPMKFMDI<AEAAGMJLLLI> AJLDLCAMOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x225F6D0", Offset = "0x225E0D0", VA = "0x18225F6D0", Slot = "7")]
		get
		{
			return default(LNNCPMKFMDI<AEAAGMJLLLI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool NKOLJEDPGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x225CFC0", Offset = "0x225B9C0", VA = "0x18225CFC0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public INBOFADIBMC<LLAADLDMCOH, OGIGJDHBOLA> JGBODAJIKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0", Slot = "9")]
		get
		{
			return default(INBOFADIBMC<LLAADLDMCOH, OGIGJDHBOLA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public string OENPDLODONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x225CE10", Offset = "0x225B810", VA = "0x18225CE10", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public LNNCPMKFMDI<HAPKHKKGAFF> IMCFDKINEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x225F6B0", Offset = "0x225E0B0", VA = "0x18225F6B0", Slot = "11")]
		get
		{
			return default(LNNCPMKFMDI<HAPKHKKGAFF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public INBOFADIBMC<LKGHPCANGJP, IHLPIHDDJKP> AHGKIKCIOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x8B0160", Offset = "0x8AEB60", VA = "0x1808B0160", Slot = "12")]
		get
		{
			return default(INBOFADIBMC<LKGHPCANGJP, IHLPIHDDJKP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public NOPFJADADBI<IMNAGMIGBGO> BLBDMFGNMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x93D850", Offset = "0x93C250", VA = "0x18093D850", Slot = "13")]
		get
		{
			return default(NOPFJADADBI<IMNAGMIGBGO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action PJNCOBLNGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2261060", Offset = "0x225FA60", VA = "0x182261060", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x225FED0", Offset = "0x225E8D0", VA = "0x18225FED0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action EPBGCNGPDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x225EE50", Offset = "0x225D850", VA = "0x18225EE50", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x225F9D0", Offset = "0x225E3D0", VA = "0x18225F9D0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<NOPFJADADBI<LLAADLDMCOH>, NOPFJADADBI<LLAADLDMCOH>> CKJBCPBNMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x225B8C0", Offset = "0x225A2C0", VA = "0x18225B8C0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x225C6A0", Offset = "0x225B0A0", VA = "0x18225C6A0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<NOPFJADADBI<LLAADLDMCOH>, NOPFJADADBI<LLAADLDMCOH>> LHHDDGAJHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x225D280", Offset = "0x225BC80", VA = "0x18225D280", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x225C520", Offset = "0x225AF20", VA = "0x18225C520", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<NOPFJADADBI<LKGHPCANGJP>, NOPFJADADBI<LKGHPCANGJP>> DHJBGMALAOA
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x225D400", Offset = "0x225BE00", VA = "0x18225D400", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x225C460", Offset = "0x225AE60", VA = "0x18225C460", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<NOPFJADADBI<LKGHPCANGJP>, NOPFJADADBI<LKGHPCANGJP>> FGGKPBEHIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x225CD50", Offset = "0x225B750", VA = "0x18225CD50", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x225DFC0", Offset = "0x225C9C0", VA = "0x18225DFC0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<NOPFJADADBI<LLAADLDMCOH>, OGIGJDHBOLA> EIHGKHICCCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2261280", Offset = "0x225FC80", VA = "0x182261280", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x225FE10", Offset = "0x225E810", VA = "0x18225FE10", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<NOPFJADADBI<LLAADLDMCOH>> BLHJFLLBFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2261100", Offset = "0x225FB00", VA = "0x182261100", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x225F820", Offset = "0x225E220", VA = "0x18225F820", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<NOPFJADADBI<LLAADLDMCOH>, OGIGJDHBOLA> LABDLGCDFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x225D340", Offset = "0x225BD40", VA = "0x18225D340", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x225CF00", Offset = "0x225B900", VA = "0x18225CF00", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<NOPFJADADBI<LKGHPCANGJP>, IHLPIHDDJKP> EPJBDJBLPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x2260F20", Offset = "0x225F920", VA = "0x182260F20", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x225C760", Offset = "0x225B160", VA = "0x18225C760", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<NOPFJADADBI<LKGHPCANGJP>> GLPKOBEHFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2261340", Offset = "0x225FD40", VA = "0x182261340", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x225CE40", Offset = "0x225B840", VA = "0x18225CE40", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<NOPFJADADBI<LKGHPCANGJP>, IHLPIHDDJKP> DEHCNPBDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x225F740", Offset = "0x225E140", VA = "0x18225F740", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x225CC90", Offset = "0x225B690", VA = "0x18225CC90", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x22617A0", Offset = "0x22601A0", VA = "0x1822617A0")]
	private COFJCJNKHJE(bool DCBNNAGJMNJ, JLDPKGEOPEJ DAKMLHHEJJO, bool DDGCNKCJMIP, INBOFADIBMC<LLAADLDMCOH, HGKNBEFOHOK> PLBFDFIBHMD, INBOFADIBMC<LLAADLDMCOH, OGIGJDHBOLA> DMHPNFMOFAP, AELHMIHCAOH OFGAFPGJIKO, INBOFADIBMC<LKGHPCANGJP, JCIALCGBCNG> MIKFPDPEONJ, INBOFADIBMC<LKGHPCANGJP, IHLPIHDDJKP> CIFCOGCGELG, string? LIKJAOKIICG, JHIFFFEJNGA JHKFPFDKACD, NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, bool IDACGFEICKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x225BDD0", Offset = "0x225A7D0", VA = "0x18225BDD0")]
	public static COFJCJNKHJE AELHPDENENI(bool DCBNNAGJMNJ, JLDPKGEOPEJ DAKMLHHEJJO, bool DDGCNKCJMIP, AELHMIHCAOH OFGAFPGJIKO, JHIFFFEJNGA JHKFPFDKACD, NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, bool IDACGFEICKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x225EF00", Offset = "0x225D900", VA = "0x18225EF00")]
	private void GCHKJEOLKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x225D4C0", Offset = "0x225BEC0", VA = "0x18225D4C0", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x225F8E0", Offset = "0x225E2E0", VA = "0x18225F8E0", Slot = "38")]
	[AsyncStateMachine(typeof(AEHMNHMAKKH))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> IENIHGCLCOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2260970", Offset = "0x225F370", VA = "0x182260970")]
	private (EFEOAONMCEH, int)? KPOGBNDJGKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x225FF70", Offset = "0x225E970", VA = "0x18225FF70")]
	private void JNIBODCPBCM(int ODMOEEFPKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x18AA0D0", Offset = "0x18A8AD0", VA = "0x1818AA0D0")]
	private void EAGOPNCOCGO(int ODMOEEFPKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x225E080", Offset = "0x225CA80", VA = "0x18225E080")]
	private void FANPDKOAONL(int IPPDGNINAAB, int ACIOAEJECLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2260FE0", Offset = "0x225F9E0", VA = "0x182260FE0")]
	private void MMNHBKIBPOF(int IPPDGNINAAB, int ACIOAEJECLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x225E570", Offset = "0x225CF70", VA = "0x18225E570")]
	private void FICLAFNGAHO(int ODMOEEFPKCN, NOPFJADADBI<LLAADLDMCOH> EDIPHOLAFAL, ILKNMOMCCKI CGOKOAJMBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x225F800", Offset = "0x225E200", VA = "0x18225F800")]
	private void IAGFCOJAMIC(int HBABIBCNPCH, NOPFJADADBI<LLAADLDMCOH> EDIPHOLAFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x225D260", Offset = "0x225BC60", VA = "0x18225D260")]
	private void COAIBOFLNND(int HBABIBCNPCH, NOPFJADADBI<LLAADLDMCOH> EDIPHOLAFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x225B980", Offset = "0x225A380", VA = "0x18225B980")]
	private void ABOHDCBDCDL(int ODMOEEFPKCN, NOPFJADADBI<LLAADLDMCOH> EDIPHOLAFAL, ILKNMOMCCKI CGOKOAJMBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2261530", Offset = "0x225FF30", VA = "0x182261530")]
	private void PMNILDENEGL(int ODMOEEFPKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0xE00C40", Offset = "0xDFF640", VA = "0x180E00C40")]
	private void OFHMMODMNJF(int ODMOEEFPKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x225FBF0", Offset = "0x225E5F0", VA = "0x18225FBF0")]
	private void JDENKKNMIDJ(int ODMOEEFPKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x18AA0D0", Offset = "0x18A8AD0", VA = "0x1818AA0D0")]
	private void LJMCBFGHBEC(int ODMOEEFPKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x225EAB0", Offset = "0x225D4B0", VA = "0x18225EAB0")]
	private void FJMOLDLFDMP(int IPPDGNINAAB, int ACIOAEJECLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x225FA80", Offset = "0x225E480", VA = "0x18225FA80")]
	private void IGHNFMJGJBO(int IPPDGNINAAB, int ACIOAEJECLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2260430", Offset = "0x225EE30", VA = "0x182260430")]
	private void KLGIINHKJLL(int ODMOEEFPKCN, NOPFJADADBI<LKGHPCANGJP> EDIPHOLAFAL, HKGBHCONPKL CGOKOAJMBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x225D130", Offset = "0x225BB30", VA = "0x18225D130")]
	private void CKGPCHFGNOB(int HBABIBCNPCH, NOPFJADADBI<LKGHPCANGJP> EDIPHOLAFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2261040", Offset = "0x225FA40", VA = "0x182261040")]
	private void NGHCMNNGNAA(int HBABIBCNPCH, NOPFJADADBI<LKGHPCANGJP> EDIPHOLAFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x225C820", Offset = "0x225B220", VA = "0x18225C820")]
	private void BGAPLFKPOJF(int ODMOEEFPKCN, NOPFJADADBI<LKGHPCANGJP> EDIPHOLAFAL, HKGBHCONPKL CGOKOAJMBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x225E420", Offset = "0x225CE20", VA = "0x18225E420")]
	private void FEMDFCOPPFO(int ODMOEEFPKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0xE00C40", Offset = "0xDFF640", VA = "0x180E00C40")]
	private void LPMNMCNKCHK(int ODMOEEFPKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x225FAE0", Offset = "0x225E4E0", VA = "0x18225FAE0", Slot = "39")]
	[AsyncStateMachine(typeof(LEMNCHANMJG))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> INPOHOGOFLI(NOPFJADADBI<JDCGCGCDEHJ> GBNOGMDLOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x225D150", Offset = "0x225BB50", VA = "0x18225D150", Slot = "40")]
	[AsyncStateMachine(typeof(GOBFEEDBMDJ))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> CLHNBHJFMIK(NOPFJADADBI<HDHAJHHMIEL> DLNHNMIIKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2260CD0", Offset = "0x225F6D0", VA = "0x182260CD0", Slot = "41")]
	[AsyncStateMachine(typeof(KLPPFAEPAKM))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> LGAMAFBLNMC(NOPFJADADBI<JDCGCGCDEHJ> GBNOGMDLOKK, NOPFJADADBI<JDCGCGCDEHJ> CIPEEKCBMCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x225C340", Offset = "0x225AD40", VA = "0x18225C340", Slot = "42")]
	[AsyncStateMachine(typeof(IOMDAHGLOEM))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> ALJJGGKGPIJ(NOPFJADADBI<HDHAJHHMIEL> DLNHNMIIKAN, NOPFJADADBI<HDHAJHHMIEL> CIPEEKCBMCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x225D040", Offset = "0x225BA40", VA = "0x18225D040", Slot = "43")]
	[AsyncStateMachine(typeof(MPBBNOOEFHC))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> CFHLACJGOOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2261680", Offset = "0x2260080", VA = "0x182261680", Slot = "44")]
	[AsyncStateMachine(typeof(GKABIHCOONI))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> PNFKCHJDLJK(string PIJAOIJPMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2260BA0", Offset = "0x225F5A0", VA = "0x182260BA0", Slot = "45")]
	[AsyncStateMachine(typeof(OOMGPJDOHGL))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> LCFAICFFNHG(NOPFJADADBI<JDCGCGCDEHJ> GBNOGMDLOKK, string JHJFHDOAMLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2261400", Offset = "0x225FE00", VA = "0x182261400", Slot = "46")]
	[AsyncStateMachine(typeof(AMIHLHPPHLH))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> PKBLMLNGIKA(NOPFJADADBI<HDHAJHHMIEL> DLNHNMIIKAN, string JHJFHDOAMLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2260DF0", Offset = "0x225F7F0", VA = "0x182260DF0", Slot = "47")]
	[AsyncStateMachine(typeof(EOIPIJDFFIG))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> LHCFPOEAOOL(NOPFJADADBI<JDCGCGCDEHJ> GBNOGMDLOKK, FMKOOFOBEMG BKKHBFLPOHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x225FCE0", Offset = "0x225E6E0", VA = "0x18225FCE0", Slot = "48")]
	[AsyncStateMachine(typeof(JJNFNAEMCGG))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> JEOGFGHMIAC(NOPFJADADBI<HDHAJHHMIEL> DLNHNMIIKAN, FMKOOFOBEMG BKKHBFLPOHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2260060", Offset = "0x225EA60", VA = "0x182260060")]
	internal void KJCFJJMJDDD(NOPFJADADBI<IMNAGMIGBGO> PKCLPFEIPFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public sealed class IDJCLNMJOJC : JOCBBAFBPMG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public interface CPADEMNMGAP
	{
		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public readonly struct HMAIKECNAEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000265")]
			public readonly IReadOnlyDictionary<LNNCPMKFMDI<AEAAGMJLLLI>, Guid>? JJHCGFMMELD;

			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x957790", Offset = "0x956190", VA = "0x180957790")]
			public HMAIKECNAEK(IReadOnlyDictionary<LNNCPMKFMDI<AEAAGMJLLLI>, Guid>? JJHCGFMMELD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		KHGCHLLICLI BDPEFOMNLNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<HGLHNOLHPNH> MMEEINNJPMO(CancellationToken PPLDCJFFMEP);

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<GOMCODJKDBA> HHNCMGLKFMO(CancellationToken PPLDCJFFMEP);

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<PBLIOBODKJG> FENNFCGLGEN(CancellationToken PPLDCJFFMEP);

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<HMAIKECNAEK> CGANNLINDFG(CancellationToken PPLDCJFFMEP);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct KKGEHBPFLGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public AsyncTaskMethodBuilder<IDJCLNMJOJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public JLDPKGEOPEJ circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public HGLHNOLHPNH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public GOMCODJKDBA superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private CPADEMNMGAP <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private GOMCODJKDBA <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private PBLIOBODKJG <playerSaveData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private TaskAwaiter<HGLHNOLHPNH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private TaskAwaiter<GOMCODJKDBA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private TaskAwaiter<PBLIOBODKJG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private TaskAwaiter<CPADEMNMGAP.HMAIKECNAEK> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<BBILELNDAIN> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2271650", Offset = "0x2270050", VA = "0x182271650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2272260", Offset = "0x2270C60", VA = "0x182272260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private readonly BBILELNDAIN OHOOFGBGHHJ;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public BBILELNDAIN BAICKPPGPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	private IDJCLNMJOJC(BBILELNDAIN JNPJNKCMPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x2265420", Offset = "0x2263E20", VA = "0x182265420")]
	[AsyncStateMachine(typeof(KKGEHBPFLGJ))]
	public static Task<IDJCLNMJOJC> BFCFOJCNLLC(JLDPKGEOPEJ DAKMLHHEJJO, HGLHNOLHPNH? GJLDCFIFFGA, GOMCODJKDBA? FGOFNGOIJIL, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x2265580", Offset = "0x2263F80", VA = "0x182265580", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public readonly struct DAFAABOOGLG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct OBKFJIMBCNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public DAFAABOOGLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public LEOAEGKNMKP action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private TaskAwaiter<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2273AA0", Offset = "0x22724A0", VA = "0x182273AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x2273D30", Offset = "0x2272730", VA = "0x182273D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct PEJDOGCLGPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<bool, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public FFCPEAHNOAD rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public HGLHNOLHPNH circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public GOMCODJKDBA superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public DAFAABOOGLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private LEOAEGKNMKP[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private TaskAwaiter<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x2274AC0", Offset = "0x22734C0", VA = "0x182274AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x2274EA0", Offset = "0x22738A0", VA = "0x182274EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct FMMNCIGBJII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public DAFAABOOGLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x2263B60", Offset = "0x2262560", VA = "0x182263B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x2263DA0", Offset = "0x22627A0", VA = "0x182263DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private readonly OMACJOGKKEK LDKOHLDBECD;

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x957790", Offset = "0x956190", VA = "0x180957790")]
	public DAFAABOOGLG(OMACJOGKKEK MKLEBBHLOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x2261A00", Offset = "0x2260400", VA = "0x182261A00")]
	[AsyncStateMachine(typeof(OBKFJIMBCNB))]
	private Task<OKPKCEBGDLD<object, NJDGKLFLKEH>> MNOLEKIGNEE(LEOAEGKNMKP EFFBNJEBEKP, bool MLOMCFLMJNH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x2261B30", Offset = "0x2260530", VA = "0x182261B30")]
	[AsyncStateMachine(typeof(PEJDOGCLGPM))]
	public Task<OKPKCEBGDLD<bool, NJDGKLFLKEH?>>? OHNIAOOCDLA(int ACCOHLFDNPL, FFCPEAHNOAD? JNFLHLMGFNO, HGLHNOLHPNH? NJPLBJBINNG, GOMCODJKDBA? FGOFNGOIJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2261910", Offset = "0x2260310", VA = "0x182261910")]
	[AsyncStateMachine(typeof(FMMNCIGBJII))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> GBEJNBBIIJK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public sealed class AMAHHEIOPOK : IBBIHENBHNA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private readonly EOGILNFLEJH NNJPLKJAEAB;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public EOGILNFLEJH NGPBMNOHICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	private AMAHHEIOPOK(EOGILNFLEJH HLNIBDAIFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x2259FB0", Offset = "0x22589B0", VA = "0x182259FB0")]
	public static AMAHHEIOPOK DLDAMIHNNNK(JLDPKGEOPEJ DAKMLHHEJJO, FFCPEAHNOAD PFPJHAJKIGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x225A1B0", Offset = "0x2258BB0", VA = "0x18225A1B0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public interface ELLHCHFCEGM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	BBILELNDAIN BAICKPPGPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	HILPPLCNLDH GDFGLGAPDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	JBEDNHHMCBE MJKDKPMNBJL
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	KEPFFHKMNMG ILMJMLCHJIG
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public interface OBGADJKIEPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	ELLHCHFCEGM? NPHOHPJHHME
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool NPNEBPFKOPN
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool CIEICMBDNDD
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<ELLHCHFCEGM?>? ALJOIPPMJIC();

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task FLGHKFDPMLM(JLDPKGEOPEJ DAKMLHHEJJO, FFCPEAHNOAD PFPJHAJKIGP, HGLHNOLHPNH? KALBKDCEBCJ, GOMCODJKDBA? COGLANFHEFJ);
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[JJJPBIKDBBE("IStaticCV2Instance")]
public interface JOCBBAFBPMG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	BBILELNDAIN BAICKPPGPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[JJJPBIKDBBE("IStaticEVInstance")]
public interface IBBIHENBHNA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	EOGILNFLEJH NGPBMNOHICE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public static class OILKMHMHDDL
{
	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x2273E80", Offset = "0x2272880", VA = "0x182273E80")]
	public static PIMFGPKDBAH<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ, APMCLBELNPF.GJEGCBPMDFF<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ>> BGEEJOMJMMM([In] this PIMFGPKDBAH<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ, APMCLBELNPF.GJEGCBPMDFF<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ>> PICEMNFDKGN)
	{
		return default(PIMFGPKDBAH<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ, APMCLBELNPF.GJEGCBPMDFF<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class JCILFAKGKNH : OLOGJMHIMFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private readonly JLDPKGEOPEJ KFPFICPDKJB;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool CIEICMBDNDD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x2269C90", Offset = "0x2268690", VA = "0x182269C90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	internal JCILFAKGKNH(JLDPKGEOPEJ DAKMLHHEJJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal sealed class HPEBDPBEOPH : MLALCDMCJBA
{
	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x2264AD0", Offset = "0x22634D0", VA = "0x182264AD0", Slot = "4")]
	public IEFOBNLOCNM? FIPGOJGKLIN(string? ADBMEIHFDEI, string? KAFPMIPKONC, string? ALOJPOOLHKK, CLBCLHJFBHL.MNFEGIMLNMF.EAPEPKEBNBA OBDEKJBJNHL, bool DNEJLHJJBAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public HPEBDPBEOPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class DNBFJONHIDO : CPAJIKPNOIC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct CLHBMNGBJBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public AsyncTaskMethodBuilder<PJMLECBJJNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public DNBFJONHIDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<ELLHCHFCEGM?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x225B2C0", Offset = "0x2259CC0", VA = "0x18225B2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x225B570", Offset = "0x2259F70", VA = "0x18225B570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private readonly JLDPKGEOPEJ KFPFICPDKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private IReadOnlyList<LNNCPMKFMDI<AKHMDDJPEIB>>? FPAENJDNDOO;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public PJMLECBJJNJ? JOLICDCBKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x2262AF0", Offset = "0x22614F0", VA = "0x182262AF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public KEPFFHKMNMG? MIIKCJDFPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x2262A70", Offset = "0x2261470", VA = "0x182262A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool FMJBPADLIJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x2262CF0", Offset = "0x22616F0", VA = "0x182262CF0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool DHHDGPJPAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x2262D50", Offset = "0x2261750", VA = "0x182262D50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	internal DNBFJONHIDO(JLDPKGEOPEJ DAKMLHHEJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x2262980", Offset = "0x2261380", VA = "0x182262980", Slot = "7")]
	[AsyncStateMachine(typeof(CLHBMNGBJBF))]
	public Task<PJMLECBJJNJ> BFPKNPLKFFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x2262DB0", Offset = "0x22617B0", VA = "0x182262DB0", Slot = "9")]
	public IReadOnlyDictionary<LNNCPMKFMDI<AEAAGMJLLLI>, Guid> NOCPEMBKAIE(IEnumerable<INNJJHKNLDI> NNIJPBNMMLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x2262B70", Offset = "0x2261570", VA = "0x182262B70", Slot = "10")]
	public LFBDJJCELLC DIMHJCJANLA(IEnumerable<INNJJHKNLDI> NNIJPBNMMLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x22627C0", Offset = "0x22611C0", VA = "0x1822627C0")]
	public OKPKCEBGDLD<IBDGOCKNGDC, FMGMBNHPFJE> AEPADKAEAOD([In] IBDGOCKNGDC CPOBEFNPAJB, IEnumerable<INNJJHKNLDI> AONGMDCDHCL, int AOHMFPFHKLA)
	{
		return default(OKPKCEBGDLD<IBDGOCKNGDC, FMGMBNHPFJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x2263120", Offset = "0x2261B20", VA = "0x182263120", Slot = "8")]
	private OKPKCEBGDLD<IBDGOCKNGDC, FMGMBNHPFJE> PDEMGCHBNLL([In] IBDGOCKNGDC CPOBEFNPAJB, IEnumerable<INNJJHKNLDI> AONGMDCDHCL, int AOHMFPFHKLA)
	{
		return default(OKPKCEBGDLD<IBDGOCKNGDC, FMGMBNHPFJE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class KEPFFHKMNMG : PJMLECBJJNJ
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	internal static class IIAOHLBNHGA
	{
		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		[CompilerGenerated]
		private sealed class FJHKGFGOLEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			public BBILELNDAIN state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400029C")]
			public AMDCMDNINOO spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600050D")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public FJHKGFGOLEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0x2278B00", Offset = "0x2277500", VA = "0x182278B00")]
			internal bool HHMOBAFOHDO(LADKILKBGME n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class HHDNMACKJFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029D")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public HHDNMACKJFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x2278E10", Offset = "0x2277810", VA = "0x182278E10")]
			internal void GNCANNDLDKG(LADKILKBGME n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x2268520", Offset = "0x2266F20", VA = "0x182268520")]
		public static OKPKCEBGDLD<PJMLECBJJNJ.KPNMKFLGHJD, ABPICNIEEFO> LDLLGDHEPIB(KEPFFHKMNMG PCBICLOONMH, [In] PJMLECBJJNJ.GGFLNJABIFC LPLPEHNKFMM)
		{
			return default(OKPKCEBGDLD<PJMLECBJJNJ.KPNMKFLGHJD, ABPICNIEEFO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x22671E0", Offset = "0x2265BE0", VA = "0x1822671E0")]
		internal static OKPKCEBGDLD<(ALBEKNAPBLA, EHAMOFBJMKL), ABPICNIEEFO> GMLGIDIIGKJ(KEPFFHKMNMG PCBICLOONMH, EHAMOFBJMKL AGGHGPKJCNG, bool AGOPEKLJCKG, [In] LNNCPMKFMDI<AEAAGMJLLLI> BNGFAFLHICN, [In] int? ENDOLHHLFDH, [In] IPKEGCJHFGM? NDECPBHFHKM, [In] IPKEGCJHFGM? NLHJNONCHFC)
		{
			return default(OKPKCEBGDLD<(ALBEKNAPBLA, EHAMOFBJMKL), ABPICNIEEFO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x2267FF0", Offset = "0x22669F0", VA = "0x182267FF0")]
		private static void HMGNEHKJIBD(bool AGOPEKLJCKG, INNJJHKNLDI MDLHGFCNBNN, ALBEKNAPBLA CCBGJFDFJDF, [In] LNNCPMKFMDI<AEAAGMJLLLI> BNGFAFLHICN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x2268A60", Offset = "0x2267460", VA = "0x182268A60")]
		public static void ODHFJLNABCD(DPKHFJKOHKM KOHDKBHEDFA, [In] PJMLECBJJNJ.EHOJJJJFNCC NIJEDHLAFGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x2268430", Offset = "0x2266E30", VA = "0x182268430")]
		[CompilerGenerated]
		internal static bool IOBJJIMJLOM(BBILELNDAIN GICLJBFBHDM, AMDCMDNINOO GGBPKPBOBOJ, LADKILKBGME LCDOOBNGGFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x22671B0", Offset = "0x2265BB0", VA = "0x1822671B0")]
		[CompilerGenerated]
		internal static bool CKIPNNAPKFI(LADKILKBGME KENDFLINCBC)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct NPNGEFMJCDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public KEPFFHKMNMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public NOPFJADADBI<AEAAGMJLLLI> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public NOPFJADADBI<HAPKHKKGAFF> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public PIGKNMNIKBG offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x227A630", Offset = "0x2279030", VA = "0x18227A630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x227A870", Offset = "0x2279270", VA = "0x18227A870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct KKDPILEOGIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public KEPFFHKMNMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public NOPFJADADBI<AEAAGMJLLLI> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public LNNCPMKFMDI<HAPKHKKGAFF> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public List<NOPFJADADBI<HAPKHKKGAFF>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public PIGKNMNIKBG localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public LEFNAMLLENO localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public PIGKNMNIKBG offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2279CE0", Offset = "0x22786E0", VA = "0x182279CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x2279FA0", Offset = "0x22789A0", VA = "0x182279FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct OGJGJNCOAGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public KEPFFHKMNMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public NOPFJADADBI<AEAAGMJLLLI> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public NOPFJADADBI<PIDGEANHJGE> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public NOPFJADADBI<KPPIPHEEJHD> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x227A940", Offset = "0x2279340", VA = "0x18227A940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x227AF90", Offset = "0x2279990", VA = "0x18227AF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct PGFIMBENGLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public KEPFFHKMNMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public LNNCPMKFMDI<HAPKHKKGAFF> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public LNNCPMKFMDI<AEAAGMJLLLI> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public NOPFJADADBI<IMNAGMIGBGO> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public NOPFJADADBI<LLAADLDMCOH> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x227B410", Offset = "0x2279E10", VA = "0x18227B410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x227B750", Offset = "0x227A150", VA = "0x18227B750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct OKDNPPIMKML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public KEPFFHKMNMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public LNNCPMKFMDI<HAPKHKKGAFF> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public LNNCPMKFMDI<AEAAGMJLLLI> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public NOPFJADADBI<IMNAGMIGBGO> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public NOPFJADADBI<LKGHPCANGJP> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private TaskAwaiter<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x227B000", Offset = "0x2279A00", VA = "0x18227B000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x227B340", Offset = "0x2279D40", VA = "0x18227B340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private readonly JLDPKGEOPEJ KFPFICPDKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private readonly JOCBBAFBPMG PGBADDHHEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private readonly IBBIHENBHNA PGDMHEHLBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private readonly JFDEPBIGAAC MMLHGDONCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private readonly DNBFJONHIDO GIPEEGNCNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private Dictionary<LNNCPMKFMDI<HAPKHKKGAFF>, FGJHFGGJHDK> MEDNJEGBAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	[CompilerGenerated]
	private Action<LNNCPMKFMDI<HAPKHKKGAFF>>? JDBJEKKNOGP;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public LNNCPMKFMDI<AEAAGMJLLLI> CLPGAFPHEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x226CDF0", Offset = "0x226B7F0", VA = "0x18226CDF0", Slot = "4")]
		get
		{
			return default(LNNCPMKFMDI<AEAAGMJLLLI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public JFDEPBIGAAC DPIMNFGNJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x2252940", Offset = "0x2251340", VA = "0x182252940", Slot = "5")]
		get
		{
			return default(JFDEPBIGAAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x2271010", Offset = "0x226FA10", VA = "0x182271010")]
	public KEPFFHKMNMG(JLDPKGEOPEJ DAKMLHHEJJO, JOCBBAFBPMG FBDHPFGDMMF, IBBIHENBHNA GFAAECGNFOC, DNBFJONHIDO LMBDHHCCILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x226F810", Offset = "0x226E210", VA = "0x18226F810", Slot = "55")]
	public NOPFJADADBI<EGBBCHMCOHB> LKNBHKFHJAN(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<KPPIPHEEJHD> HLGPBDONICD)
	{
		return default(NOPFJADADBI<EGBBCHMCOHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x2270C90", Offset = "0x226F690", VA = "0x182270C90", Slot = "56")]
	public NOPFJADADBI<KEAFABIHFOA> PBGPLDGIFHN(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<PIDGEANHJGE> AIAAIMOKNLI)
	{
		return default(NOPFJADADBI<KEAFABIHFOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x226D8F0", Offset = "0x226C2F0", VA = "0x18226D8F0", Slot = "6")]
	public (bool, bool) FADFKKNACLJ(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<PIDGEANHJGE> FJKPMADIAAJ, NOPFJADADBI<KPPIPHEEJHD> JNCPPIHANLG)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x226E5B0", Offset = "0x226CFB0", VA = "0x18226E5B0")]
	public bool HLINICGMOGI(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, [In] FGMLKGCJFAJ JIJBEECDEGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x2270170", Offset = "0x226EB70", VA = "0x182270170", Slot = "8")]
	public bool LOPOHCJHILN(OGIGJDHBOLA EOCNMCJPJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x22706B0", Offset = "0x226F0B0", VA = "0x1822706B0", Slot = "9")]
	public bool NJFJJONLDCC(IHLPIHDDJKP PAIPJFKDKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x226D5C0", Offset = "0x226BFC0", VA = "0x18226D5C0", Slot = "10")]
	public EIIDDHMDCKD? DEBFPOFELAG(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<KPPIPHEEJHD> HLGPBDONICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x2270D10", Offset = "0x226F710", VA = "0x182270D10", Slot = "11")]
	public KKMLDPIOJFL? PENEHOLEKBO(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<PIDGEANHJGE> AIAAIMOKNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x226F480", Offset = "0x226DE80", VA = "0x18226F480", Slot = "12")]
	public NOPFJADADBI<PIDGEANHJGE>? KLAANJIHBDH(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<HAPKHKKGAFF> ICBLLOEAIEO, NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, NOPFJADADBI<LKGHPCANGJP> IDBFFINBLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x226AD70", Offset = "0x2269770", VA = "0x18226AD70", Slot = "13")]
	public NOPFJADADBI<KPPIPHEEJHD>? AGCBBPAOOGN(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<HAPKHKKGAFF> ICBLLOEAIEO, NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, NOPFJADADBI<LLAADLDMCOH> AHDKBCJJOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x2270470", Offset = "0x226EE70", VA = "0x182270470", Slot = "14")]
	public IEnumerable<NOPFJADADBI<AEAAGMJLLLI>> MMOAIGIDDCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x226F760", Offset = "0x226E160", VA = "0x18226F760", Slot = "15")]
	public IEnumerable<NOPFJADADBI<BADICBOLJGK>> LIHPLNAMAIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x226CE50", Offset = "0x226B850", VA = "0x18226CE50", Slot = "16")]
	public string CEMBFCMPDKI(NOPFJADADBI<BADICBOLJGK> PFGJLOBACMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x226E060", Offset = "0x226CA60", VA = "0x18226E060", Slot = "17")]
	public string FFMDJFPADJI(NOPFJADADBI<BADICBOLJGK> PFGJLOBACMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x226E440", Offset = "0x226CE40", VA = "0x18226E440")]
	public FGJHFGGJHDK? HGHMNJHKFDK([In] LNNCPMKFMDI<HAPKHKKGAFF> ICBLLOEAIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x226CD70", Offset = "0x226B770", VA = "0x18226CD70")]
	public NOPFJADADBI<HAPKHKKGAFF> CDEGHEDCKOB(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, [In] LNNCPMKFMDI<HAPKHKKGAFF> DJMOGGHAIGK)
	{
		return default(NOPFJADADBI<HAPKHKKGAFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x226FA30", Offset = "0x226E430", VA = "0x18226FA30", Slot = "29")]
	public NOPFJADADBI<HAPKHKKGAFF> LOLKOPGJHJN(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<KPPIPHEEJHD> HLGPBDONICD)
	{
		return default(NOPFJADADBI<HAPKHKKGAFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x226D7E0", Offset = "0x226C1E0", VA = "0x18226D7E0", Slot = "30")]
	public NOPFJADADBI<HAPKHKKGAFF> EHNCPKNGLIB(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<PIDGEANHJGE> AIAAIMOKNLI)
	{
		return default(NOPFJADADBI<HAPKHKKGAFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x226D860", Offset = "0x226C260", VA = "0x18226D860")]
	private void EIJFCCFNKGJ(LNNCPMKFMDI<HAPKHKKGAFF> ICBLLOEAIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x226F1B0", Offset = "0x226DBB0", VA = "0x18226F1B0")]
	public IEnumerable<FGJHFGGJHDK> KGHADHOIJBN([In] LNNCPMKFMDI<AEAAGMJLLLI> LIMKMANPJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x226AE00", Offset = "0x2269800", VA = "0x18226AE00", Slot = "28")]
	public NOPFJADADBI<KPPIPHEEJHD> AGCBBPAOOGN(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<HAPKHKKGAFF> ICBLLOEAIEO, NOPFJADADBI<EGBBCHMCOHB> AHDKBCJJOAD)
	{
		return default(NOPFJADADBI<KPPIPHEEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x226F3F0", Offset = "0x226DDF0", VA = "0x18226F3F0", Slot = "31")]
	public NOPFJADADBI<PIDGEANHJGE> KLAANJIHBDH(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<HAPKHKKGAFF> ICBLLOEAIEO, NOPFJADADBI<KEAFABIHFOA> IDBFFINBLDL)
	{
		return default(NOPFJADADBI<PIDGEANHJGE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x226E250", Offset = "0x226CC50", VA = "0x18226E250")]
	private FGJHFGGJHDK? GNGKIHJDBKI([In] LNNCPMKFMDI<HAPKHKKGAFF> ICBLLOEAIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x226D260", Offset = "0x226BC60", VA = "0x18226D260")]
	private FGJHFGGJHDK CNPPOOEOINA([In] LNNCPMKFMDI<HAPKHKKGAFF> ICBLLOEAIEO, AELHMIHCAOH OFGAFPGJIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x226E1C0", Offset = "0x226CBC0", VA = "0x18226E1C0")]
	public AELHMIHCAOH? GKOHOHFIMOF([In] LNNCPMKFMDI<HAPKHKKGAFF> ICBLLOEAIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x226C810", Offset = "0x226B210", VA = "0x18226C810")]
	public KJCBGHAGEHM? KDJBLDMMGHL([In] LNNCPMKFMDI<AEAAGMJLLLI> LIMKMANPJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x2270BD0", Offset = "0x226F5D0", VA = "0x182270BD0", Slot = "23")]
	public IEnumerable<IGCDCKKPIKP> OBFEACECMJA(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x226CEC0", Offset = "0x226B8C0", VA = "0x18226CEC0", Slot = "24")]
	public bool CKJEEDNEBPI(NOPFJADADBI<BADICBOLJGK> PFGJLOBACMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x226D330", Offset = "0x226BD30", VA = "0x18226D330", Slot = "25")]
	public IEnumerable<FGMLKGCJFAJ> DANAMCDMLCC(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<PIDGEANHJGE> FJKPMADIAAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x22701F0", Offset = "0x226EBF0", VA = "0x1822701F0", Slot = "26")]
	public IEnumerable<FGMLKGCJFAJ> MHJEFMDIKLO(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<KPPIPHEEJHD> JNCPPIHANLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x226E9B0", Offset = "0x226D3B0", VA = "0x18226E9B0")]
	public NOPFJADADBI<AEAAGMJLLLI> IOAKBJFPCDI([In] LNNCPMKFMDI<AEAAGMJLLLI> LIMKMANPJJH)
	{
		return default(NOPFJADADBI<AEAAGMJLLLI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x226C840", Offset = "0x226B240", VA = "0x18226C840")]
	public NOPFJADADBI<AEAAGMJLLLI>? IBNHOJLGION([In] LNNCPMKFMDI<AEAAGMJLLLI> LIMKMANPJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x2270DD0", Offset = "0x226F7D0", VA = "0x182270DD0")]
	private AMDCMDNINOO? PIOMCGFIBBA([In] LNNCPMKFMDI<AEAAGMJLLLI> LIMKMANPJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x226C810", Offset = "0x226B210", VA = "0x18226C810")]
	private KJCBGHAGEHM? BLMGCNIADAL([In] LNNCPMKFMDI<AEAAGMJLLLI> LIMKMANPJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x226C8C0", Offset = "0x226B2C0", VA = "0x18226C8C0", Slot = "35")]
	public LNNCPMKFMDI<AEAAGMJLLLI> CAKECLJBBBP(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH)
	{
		return default(LNNCPMKFMDI<AEAAGMJLLLI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x226D680", Offset = "0x226C080", VA = "0x18226D680", Slot = "32")]
	public IEnumerable<FMKOOFOBEMG> DEJKKDNPPIL(EBIAAGDPDPI NPPJKAJHFCN, bool FLHBCABAMPJ, bool MNOMCOPICCB, bool JNEAPFEIPJM, bool PACCLBHPNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x226CF50", Offset = "0x226B950", VA = "0x18226CF50", Slot = "33")]
	public FMKOOFOBEMG CMNAHBAHCPC(EBIAAGDPDPI NPPJKAJHFCN, DNCDFCBKAAH LIAAMPHOIKE, bool FLHBCABAMPJ, bool MNOMCOPICCB, bool JNEAPFEIPJM, bool PACCLBHPNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x226F510", Offset = "0x226DF10", VA = "0x18226F510")]
	public IGCDCKKPIKP OIBBAKEJGDC(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, [In] FGMLKGCJFAJ JIJBEECDEGJ)
	{
		return default(IGCDCKKPIKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x226B890", Offset = "0x226A290", VA = "0x18226B890", Slot = "36")]
	public FGMLKGCJFAJ BAANMAKNCFE(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<PIDGEANHJGE> FJKPMADIAAJ, NOPFJADADBI<KPPIPHEEJHD> JNCPPIHANLG)
	{
		return default(FGMLKGCJFAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x226DDF0", Offset = "0x226C7F0", VA = "0x18226DDF0", Slot = "37")]
	[AsyncStateMachine(typeof(NPNGEFMJCDI))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> FBABHHKEGLL(NOPFJADADBI<AEAAGMJLLLI> POMHDOAMKMG, NOPFJADADBI<HAPKHKKGAFF> LDABPEMJBHK, PIGKNMNIKBG FDHHGENAMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2270E90", Offset = "0x226F890", VA = "0x182270E90", Slot = "38")]
	[AsyncStateMachine(typeof(KKDPILEOGIC))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> PKJOEHLDLHK(NOPFJADADBI<AEAAGMJLLLI> POMHDOAMKMG, LNNCPMKFMDI<HAPKHKKGAFF> LDABPEMJBHK, List<NOPFJADADBI<HAPKHKKGAFF>> EGLEJHLLMLE, PIGKNMNIKBG INBOMNLBADE, LEFNAMLLENO OANHCPGMMMF, PIGKNMNIKBG FDHHGENAMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x226E940", Offset = "0x226D340", VA = "0x18226E940", Slot = "39")]
	public bool IGIOLMNBEDB(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x226F890", Offset = "0x226E290", VA = "0x18226F890", Slot = "40")]
	public bool LMJHGIGOINI(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<KPPIPHEEJHD> HLGPBDONICD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x2270AF0", Offset = "0x226F4F0", VA = "0x182270AF0", Slot = "41")]
	public bool NOAEKPBIKHB(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<PIDGEANHJGE> AIAAIMOKNLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x226B860", Offset = "0x226A260", VA = "0x18226B860")]
	public OKPKCEBGDLD<PJMLECBJJNJ.KPNMKFLGHJD, ABPICNIEEFO> AOJPBFLDAJP([In] PJMLECBJJNJ.GGFLNJABIFC LPLPEHNKFMM)
	{
		return default(OKPKCEBGDLD<PJMLECBJJNJ.KPNMKFLGHJD, ABPICNIEEFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x226DF30", Offset = "0x226C930", VA = "0x18226DF30", Slot = "43")]
	[AsyncStateMachine(typeof(OGJGJNCOAGG))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> FDNBFFIGODE(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<PIDGEANHJGE> FJKPMADIAAJ, NOPFJADADBI<KPPIPHEEJHD> JNCPPIHANLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2270730", Offset = "0x226F130", VA = "0x182270730", Slot = "44")]
	public OKPKCEBGDLD<BIIBIFMJHIO, FMGMBNHPFJE> NMDAIFLBHAJ(LNNCPMKFMDI<AEAAGMJLLLI> LIMKMANPJJH, BIIBIFMJHIO GCLGCIMLHGM, LEFNAMLLENO NOLFGJJBNEF)
	{
		return default(OKPKCEBGDLD<BIIBIFMJHIO, FMGMBNHPFJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x226EB20", Offset = "0x226D520", VA = "0x18226EB20", Slot = "45")]
	[AsyncStateMachine(typeof(PGFIMBENGLF))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> JKJBHPGGEFH(LNNCPMKFMDI<AEAAGMJLLLI> LIMKMANPJJH, LNNCPMKFMDI<HAPKHKKGAFF> FAODHFCMMMJ, NOPFJADADBI<IMNAGMIGBGO> NKIENHMBELI, NOPFJADADBI<LLAADLDMCOH> HLGPBDONICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x226F290", Offset = "0x226DC90", VA = "0x18226F290", Slot = "46")]
	[AsyncStateMachine(typeof(OKDNPPIMKML))]
	public Task<OKPKCEBGDLD<NEDLODCHJKB, NJDGKLFLKEH>> KKPDOAEMNPB(LNNCPMKFMDI<AEAAGMJLLLI> LIMKMANPJJH, LNNCPMKFMDI<HAPKHKKGAFF> HLPOFOELEND, NOPFJADADBI<IMNAGMIGBGO> OKJLCDLNMNM, NOPFJADADBI<LKGHPCANGJP> AIAAIMOKNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x226F910", Offset = "0x226E310", VA = "0x18226F910", Slot = "47")]
	public NPGOIILHLMD LMMFKMIEGAF(IEnumerable<INNJJHKNLDI> AONGMDCDHCL)
	{
		return default(NPGOIILHLMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2270500", Offset = "0x226EF00", VA = "0x182270500", Slot = "48")]
	public NPGOIILHLMD MNBPMODAGGF()
	{
		return default(NPGOIILHLMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x226C930", Offset = "0x226B330", VA = "0x18226C930")]
	private FOFGEJDJHIP CALGAOPNFDD(COIPMGFHIMP GOPIFLFLIBE, NOPFJADADBI<AEAAGMJLLLI> HFHKIIBCJGO, IEnumerable<LNNCPMKFMDI<AEAAGMJLLLI>> JIKLHLEPKMN, IEnumerable<LNNCPMKFMDI<HAPKHKKGAFF>> EGLEJHLLMLE)
	{
		return default(FOFGEJDJHIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x226CAE0", Offset = "0x226B4E0", VA = "0x18226CAE0", Slot = "49")]
	public FOFGEJDJHIP CALGAOPNFDD(COIPMGFHIMP GOPIFLFLIBE, NOPFJADADBI<AEAAGMJLLLI> HFHKIIBCJGO, IEnumerable<LNNCPMKFMDI<HAPKHKKGAFF>> EGLEJHLLMLE, IEnumerable<INNJJHKNLDI> AONGMDCDHCL)
	{
		return default(FOFGEJDJHIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x226C490", Offset = "0x226AE90", VA = "0x18226C490")]
	private static IEnumerable<LNNCPMKFMDI<AEAAGMJLLLI>> BHCGIKAAANI(IEnumerable<INNJJHKNLDI> AONGMDCDHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x226EC80", Offset = "0x226D680", VA = "0x18226EC80")]
	private IEnumerable<LNNCPMKFMDI<HAPKHKKGAFF>> JNNNDDHBMHK(IEnumerable<INNJJHKNLDI> AONGMDCDHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x226F120", Offset = "0x226DB20", VA = "0x18226F120", Slot = "50")]
	public List<AFHOJMGDCAB> KBEBHJOPAPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x226FAB0", Offset = "0x226E4B0", VA = "0x18226FAB0")]
	public (List<AFHOJMGDCAB>, bool) LOMDBMHCCNI([In] AEBIJODLCLA BONDNOLGGFJ, string KMDNOIPDFGB, [In] BPBKMBJMGOF NLHKBBAAKEM, DAJIEAKKHFK PCDKLGLGIAG, MCNNCPBAAFB BKBKIPGAPKF)
	{
		return default((List<AFHOJMGDCAB>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x226E0D0", Offset = "0x226CAD0", VA = "0x18226E0D0", Slot = "52")]
	public bool FLIEGIDMHCB(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2270B70", Offset = "0x226F570", VA = "0x182270B70")]
	internal void OAJCJFGHAFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x226E300", Offset = "0x226CD00", VA = "0x18226E300")]
	internal Task GODODNBOEKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x226AE90", Offset = "0x2269890", VA = "0x18226AE90", Slot = "53")]
	public OKPKCEBGDLD<NOPFJADADBI<PIDGEANHJGE>?, NJDGKLFLKEH> ANOLMLNEJPN(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<HAPKHKKGAFF> ICBLLOEAIEO, NOPFJADADBI<KPPIPHEEJHD> HLGPBDONICD)
	{
		return default(OKPKCEBGDLD<NOPFJADADBI<PIDGEANHJGE>?, NJDGKLFLKEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x226BAC0", Offset = "0x226A4C0", VA = "0x18226BAC0", Slot = "54")]
	public OKPKCEBGDLD<NOPFJADADBI<KPPIPHEEJHD>?, NJDGKLFLKEH> BCJOOCHKPHN(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, NOPFJADADBI<HAPKHKKGAFF> ICBLLOEAIEO, NOPFJADADBI<PIDGEANHJGE> AIAAIMOKNLI)
	{
		return default(OKPKCEBGDLD<NOPFJADADBI<KPPIPHEEJHD>?, NJDGKLFLKEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2270620", Offset = "0x226F020", VA = "0x182270620", Slot = "7")]
	private bool MOEJHFCPLAE(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, [In] FGMLKGCJFAJ JIJBEECDEGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x226C810", Offset = "0x226B210", VA = "0x18226C810", Slot = "18")]
	private KJCBGHAGEHM EIIMPJENPMA([In] LNNCPMKFMDI<AEAAGMJLLLI> LIMKMANPJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x226E9B0", Offset = "0x226D3B0", VA = "0x18226E9B0", Slot = "19")]
	private NOPFJADADBI<AEAAGMJLLLI> JNCLKPGJLCO([In] LNNCPMKFMDI<AEAAGMJLLLI> LIMKMANPJJH)
	{
		return default(NOPFJADADBI<AEAAGMJLLLI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x226C840", Offset = "0x226B240", VA = "0x18226C840", Slot = "20")]
	private NOPFJADADBI<AEAAGMJLLLI>? BPNEMNOAODC([In] LNNCPMKFMDI<AEAAGMJLLLI> LIMKMANPJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x226AC20", Offset = "0x2269620", VA = "0x18226AC20", Slot = "21")]
	private FGJHFGGJHDK AELABPIJLDB([In] LNNCPMKFMDI<HAPKHKKGAFF> ICBLLOEAIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x226CD70", Offset = "0x226B770", VA = "0x18226CD70", Slot = "22")]
	private NOPFJADADBI<HAPKHKKGAFF> NFJJOBJHPBF(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, [In] LNNCPMKFMDI<HAPKHKKGAFF> DJMOGGHAIGK)
	{
		return default(NOPFJADADBI<HAPKHKKGAFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x226E360", Offset = "0x226CD60", VA = "0x18226E360", Slot = "27")]
	private IEnumerable<FGJHFGGJHDK> HBOOJHIBONL([In] LNNCPMKFMDI<AEAAGMJLLLI> LIMKMANPJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x226F510", Offset = "0x226DF10", VA = "0x18226F510", Slot = "34")]
	private IGCDCKKPIKP KOFEBBMFKOC(NOPFJADADBI<AEAAGMJLLLI> LIMKMANPJJH, [In] FGMLKGCJFAJ JIJBEECDEGJ)
	{
		return default(IGCDCKKPIKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x226B860", Offset = "0x226A260", VA = "0x18226B860", Slot = "42")]
	private OKPKCEBGDLD<PJMLECBJJNJ.KPNMKFLGHJD, ABPICNIEEFO> IEBNCODELKF([In] PJMLECBJJNJ.GGFLNJABIFC LPLPEHNKFMM)
	{
		return default(OKPKCEBGDLD<PJMLECBJJNJ.KPNMKFLGHJD, ABPICNIEEFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x226D780", Offset = "0x226C180", VA = "0x18226D780", Slot = "51")]
	private (List<AFHOJMGDCAB>, bool) DKGIMPDKIAH([In] AEBIJODLCLA BONDNOLGGFJ, string KMDNOIPDFGB, [In] BPBKMBJMGOF NLHKBBAAKEM, DAJIEAKKHFK PCDKLGLGIAG, MCNNCPBAAFB BKBKIPGAPKF)
	{
		return default((List<AFHOJMGDCAB>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x226EA30", Offset = "0x226D430", VA = "0x18226EA30")]
	[CompilerGenerated]
	private FGJHFGGJHDK IOPHMDJHAFG(AELHMIHCAOH FNLONGIJDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2270630", Offset = "0x226F030", VA = "0x182270630")]
	[CompilerGenerated]
	private DCGIPMPAHBC NIKBNJCINAE(PKMBJGLAFPA FNLONGIJDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x226F6F0", Offset = "0x226E0F0", VA = "0x18226F6F0")]
	[CompilerGenerated]
	private AELHMIHCAOH LGLEICBFDIK(LNNCPMKFMDI<HAPKHKKGAFF> FNLONGIJDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x226F680", Offset = "0x226E080", VA = "0x18226F680")]
	[CompilerGenerated]
	private AMDCMDNINOO LDJLAMKMCCB(LNNCPMKFMDI<AEAAGMJLLLI> FNLONGIJDLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class DCGIPMPAHBC : FMKOOFOBEMG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct FKEJHCJIMAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NOPFJADADBI<JDCGCGCDEHJ>, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public DCGIPMPAHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public LNNCPMKFMDI<AEAAGMJLLLI> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public LNNCPMKFMDI<HAPKHKKGAFF> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public NOPFJADADBI<IMNAGMIGBGO> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private TaskAwaiter<OKPKCEBGDLD<NOPFJADADBI<JDCGCGCDEHJ>, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x2278B20", Offset = "0x2277520", VA = "0x182278B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x2278DA0", Offset = "0x22777A0", VA = "0x182278DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct AGLBAALPJDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<NOPFJADADBI<HDHAJHHMIEL>, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public DCGIPMPAHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public LNNCPMKFMDI<AEAAGMJLLLI> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public LNNCPMKFMDI<HAPKHKKGAFF> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public NOPFJADADBI<IMNAGMIGBGO> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private TaskAwaiter<OKPKCEBGDLD<NOPFJADADBI<HDHAJHHMIEL>, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x22766A0", Offset = "0x22750A0", VA = "0x1822766A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x2276920", Offset = "0x2275320", VA = "0x182276920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private readonly PKMBJGLAFPA EADGGBMFHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private readonly JOCBBAFBPMG PGBADDHHEEA;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public TypeKey PDKPLCDEBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x9826F0", Offset = "0x9810F0", VA = "0x1809826F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string DGALPJFNBFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x2277150", Offset = "0x2275B50", VA = "0x182277150", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public PKMBJGLAFPA HFNFBFPAFAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x22772F0", Offset = "0x2275CF0", VA = "0x1822772F0")]
	public DCGIPMPAHBC(PKMBJGLAFPA MJIDNBLLNJI, JOCBBAFBPMG FBDHPFGDMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2277180", Offset = "0x2275B80", VA = "0x182277180", Slot = "6")]
	[AsyncStateMachine(typeof(FKEJHCJIMAF))]
	public Task<OKPKCEBGDLD<NOPFJADADBI<JDCGCGCDEHJ>, NJDGKLFLKEH>> ONKKHMFPMFP(LNNCPMKFMDI<AEAAGMJLLLI> LIMKMANPJJH, LNNCPMKFMDI<HAPKHKKGAFF> ICBLLOEAIEO, NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, string JHJFHDOAMLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2276FE0", Offset = "0x22759E0", VA = "0x182276FE0", Slot = "7")]
	[AsyncStateMachine(typeof(AGLBAALPJDP))]
	public Task<OKPKCEBGDLD<NOPFJADADBI<HDHAJHHMIEL>, NJDGKLFLKEH>> AEDDIMEAGKL(LNNCPMKFMDI<AEAAGMJLLLI> LIMKMANPJJH, LNNCPMKFMDI<HAPKHKKGAFF> ICBLLOEAIEO, NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB, string JHJFHDOAMLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class FGJKIMFIAIH : INOBDAKCMBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly PKMBJGLAFPA DLOAANIEKCO;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private static readonly HashSet<PKMBJGLAFPA> ADECACIGEBJ;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private static readonly HashSet<PKMBJGLAFPA> IHDANBIKJEM;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private static readonly HashSet<PKMBJGLAFPA> AJGFKAGOFLI;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public TypeKey HPAJNDJICEN
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x2278990", Offset = "0x2277390", VA = "0x182278990", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool FEPFGODHHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x2278980", Offset = "0x2277380", VA = "0x182278980", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool EHEEMDHPDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x22789E0", Offset = "0x22773E0", VA = "0x1822789E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool OACBIPCBMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x2278900", Offset = "0x2277300", VA = "0x182278900", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x22775C0", Offset = "0x2275FC0", VA = "0x1822775C0")]
	public bool OJFDLOMKAPC(string PKCLPFEIPFH, [Out] KEDFFPGLMPP LEIFLICMDKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	public FGJKIMFIAIH(PKMBJGLAFPA OAAFMJBAJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x2277430", Offset = "0x2275E30", VA = "0x182277430")]
	internal static TypeKey ALNNFAEIGFF(PKMBJGLAFPA BKKHBFLPOHJ)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x2277150", Offset = "0x2275B50", VA = "0x182277150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public readonly struct MCKAIEHOEEK : GEJCEKPHLGB.MBHIKBPALJO<LEOAEGKNMKP, NEDLODCHJKB>
{
	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x227A120", Offset = "0x2278B20", VA = "0x18227A120", Slot = "4")]
	public int AABIPLCLFCA(NEDLODCHJKB HBABIBCNPCH, LEOAEGKNMKP EFFBNJEBEKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x227A260", Offset = "0x2278C60", VA = "0x18227A260", Slot = "5")]
	public LEOAEGKNMKP OOABALMJBKE(NEDLODCHJKB HBABIBCNPCH, LEOAEGKNMKP EFFBNJEBEKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x227A160", Offset = "0x2278B60", VA = "0x18227A160", Slot = "6")]
	public LEOAEGKNMKP DJKIHMHAEOO(NEDLODCHJKB HBABIBCNPCH, LEOAEGKNMKP EFFBNJEBEKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x227A1B0", Offset = "0x2278BB0", VA = "0x18227A1B0", Slot = "7")]
	public IReadOnlyList<LEOAEGKNMKP> HACPCNOODII(NEDLODCHJKB HBABIBCNPCH, LEOAEGKNMKP EFFBNJEBEKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x227A1F0", Offset = "0x2278BF0", VA = "0x18227A1F0", Slot = "8")]
	public LEOAEGKNMKP[] JMLPOPBHPMF(NEDLODCHJKB HBABIBCNPCH, LEOAEGKNMKP EFFBNJEBEKP, int IAPIAMAIINP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x227A200", Offset = "0x2278C00", VA = "0x18227A200", Slot = "9")]
	public bool LPHOHDMCMFL(NEDLODCHJKB HBABIBCNPCH, LEOAEGKNMKP EFFBNJEBEKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x227A190", Offset = "0x2278B90", VA = "0x18227A190", Slot = "10")]
	public bool FLOLKKNJPKI(NEDLODCHJKB HBABIBCNPCH, LEOAEGKNMKP EFFBNJEBEKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x227A220", Offset = "0x2278C20", VA = "0x18227A220", Slot = "11")]
	public bool NIFOGNGIMAO(NEDLODCHJKB HBABIBCNPCH, LEOAEGKNMKP EFFBNJEBEKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x227A140", Offset = "0x2278B40", VA = "0x18227A140", Slot = "12")]
	public bool CNJENCKIEMJ(NEDLODCHJKB HBABIBCNPCH, LEOAEGKNMKP EFFBNJEBEKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x227A240", Offset = "0x2278C40", VA = "0x18227A240", Slot = "13")]
	public bool OICHHPEPKJE(NEDLODCHJKB GCCMFNNKNLE, LEOAEGKNMKP EFFBNJEBEKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x227A1D0", Offset = "0x2278BD0", VA = "0x18227A1D0", Slot = "14")]
	public bool IIAOJKOKHMJ(NEDLODCHJKB HBABIBCNPCH, LEOAEGKNMKP EFFBNJEBEKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public abstract class DGLIINHHPKM : LCDCFGGEMGL
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public DMJNGOIAOHC.FCJBBPHLLNO LDEDJFFOIPE
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x22773E0", Offset = "0x2275DE0", VA = "0x1822773E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract OLBHGBECMMG.MCBIGBAJFAD DNPJFLABDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract JLDPKGEOPEJ.CHBJMGAGLKO EJCBJAKBMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract IDJCLNMJOJC.CPADEMNMGAP GNHMJHEJNBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public APMCLBELNPF.GJEGCBPMDFF<IHPBJPDOCPD, LEOAEGKNMKP, JLDPKGEOPEJ> MNAKEBEOBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2277390", Offset = "0x2275D90", VA = "0x182277390", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract BJOPPGIOJJG OABKILOKGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract IKBBPNOAHAG MFMILMOKOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract BPGBGPDHDLL ILGCHKCGIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract PJOLGJFIIJJ HGIFJEJCGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract DLFDMIENOIH BIELAKJICMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	protected DGLIINHHPKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class CDAHJOLKIFG : JJCIABNFBPB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct JBBMGEEKNLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public CDAHJOLKIFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public LEOAEGKNMKP action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private TaskAwaiter<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x2279720", Offset = "0x2278120", VA = "0x182279720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x22799C0", Offset = "0x22783C0", VA = "0x1822799C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private struct BAANOKAHEPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<GNOHPBEEOMG, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public CDAHJOLKIFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public IReadOnlyList<LEOAEGKNMKP> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private TaskAwaiter<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x2276990", Offset = "0x2275390", VA = "0x182276990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x2276D10", Offset = "0x2275710", VA = "0x182276D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private readonly OMACJOGKKEK LDKOHLDBECD;

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	public CDAHJOLKIFG(OMACJOGKKEK MKLEBBHLOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2276EB0", Offset = "0x22758B0", VA = "0x182276EB0")]
	[AsyncStateMachine(typeof(JBBMGEEKNLP))]
	private Task<OKPKCEBGDLD<object, NJDGKLFLKEH>> MNOLEKIGNEE(LEOAEGKNMKP EFFBNJEBEKP, bool MLOMCFLMJNH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2276D80", Offset = "0x2275780", VA = "0x182276D80", Slot = "4")]
	[AsyncStateMachine(typeof(BAANOKAHEPH))]
	public Task<OKPKCEBGDLD<GNOHPBEEOMG, NJDGKLFLKEH>> HDLLDLPBDOK(IReadOnlyList<LEOAEGKNMKP> OHBFICNMFIF, bool MLOMCFLMJNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct OCGBFJNLLFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	internal CAOCOACDOCE<HFDFPMOKGOA, LEOAEGKNMKP, NEKODGOCOJJ> DLOAANIEKCO;

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2251720", Offset = "0x2250120", VA = "0x182251720")]
	private OCGBFJNLLFP([In] CAOCOACDOCE<HFDFPMOKGOA, LEOAEGKNMKP, NEKODGOCOJJ> CGJHBNBANEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x227A8E0", Offset = "0x22792E0", VA = "0x18227A8E0")]
	public static OCGBFJNLLFP AELHPDENENI()
	{
		return default(OCGBFJNLLFP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class BFAMHEENGEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
	public static CAOCOACDOCE<HFDFPMOKGOA, LEOAEGKNMKP, NEKODGOCOJJ> ACBNMHHGOOO(this OCGBFJNLLFP PCBICLOONMH)
	{
		return default(CAOCOACDOCE<HFDFPMOKGOA, LEOAEGKNMKP, NEKODGOCOJJ>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public struct NEKODGOCOJJ : IGBHOHLCEFB.EFPOICDAAPL<HFDFPMOKGOA, LEOAEGKNMKP>
{
	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x227A270", Offset = "0x2278C70", VA = "0x18227A270", Slot = "5")]
	public LEOAEGKNMKP BLDFKHJBDBG(HFDFPMOKGOA[] CIEHGJNKMFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x1A48C80", Offset = "0x1A47680", VA = "0x181A48C80")]
	public int KEEDGKPCJJC([In] HFDFPMOKGOA DLBDEDPPGKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x1A48C80", Offset = "0x1A47680", VA = "0x181A48C80", Slot = "4")]
	private int GBLFBPDDCKA([In] HFDFPMOKGOA KNEGDIEEEBM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public struct OLBCPDNHHLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	internal HJPHNMABFPO<JOFNOFALIEA, LEOAEGKNMKP, NHHBFPBAEIH> DLOAANIEKCO;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x2251720", Offset = "0x2250120", VA = "0x182251720")]
	private OLBCPDNHHLA([In] HJPHNMABFPO<JOFNOFALIEA, LEOAEGKNMKP, NHHBFPBAEIH> AACCACHELKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x227B3B0", Offset = "0x2279DB0", VA = "0x18227B3B0")]
	public static OLBCPDNHHLA AELHPDENENI()
	{
		return default(OLBCPDNHHLA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public static class PKCFBADKBKO
{
	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
	public static HJPHNMABFPO<JOFNOFALIEA, LEOAEGKNMKP, NHHBFPBAEIH> ACBNMHHGOOO(this OLBCPDNHHLA PCBICLOONMH)
	{
		return default(HJPHNMABFPO<JOFNOFALIEA, LEOAEGKNMKP, NHHBFPBAEIH>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public struct NHHBFPBAEIH : HGJAPPNPLCE.ADMKBKPHNBE<JOFNOFALIEA, LEOAEGKNMKP>
{
	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x1A48C80", Offset = "0x1A47680", VA = "0x181A48C80")]
	public int KBNMNKCMJOK([In] JOFNOFALIEA DLBDEDPPGKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x227A450", Offset = "0x2278E50", VA = "0x18227A450", Slot = "5")]
	public LEOAEGKNMKP JLNKJMIAHED(JOFNOFALIEA[] PALKOHEJHLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x1A48C80", Offset = "0x1A47680", VA = "0x181A48C80", Slot = "4")]
	private int OFCKCJJMDNF([In] JOFNOFALIEA DLBDEDPPGKH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class KAFHIGOPEFK : JMDMKJMGBCA, ABPICNIEEFO, NJDGKLFLKEH, FMGMBNHPFJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private readonly FMGMBNHPFJE? IKNICDNLBKD;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public NEHBELBMIEF AELIKNGBBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D20", Offset = "0x8B3720", VA = "0x1808B4D20", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(NEHBELBMIEF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D40", Offset = "0x8B3740", VA = "0x1808B4D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public override FMGMBNHPFJE? GECGMIHIOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x2279A30", Offset = "0x2278430", VA = "0x182279A30", Slot = "7")]
	public override string BGELNEMCJAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x2279CA0", Offset = "0x22786A0", VA = "0x182279CA0")]
	private KAFHIGOPEFK(NEHBELBMIEF CLPBJKNGJBH, FMGMBNHPFJE? NDHKBBJANPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x2279C20", Offset = "0x2278620", VA = "0x182279C20")]
	public static KAFHIGOPEFK OHCMLMMKMKG(FMGMBNHPFJE NDHKBBJANPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x2279B40", Offset = "0x2278540", VA = "0x182279B40")]
	public static KAFHIGOPEFK EJBIHMEPPDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x2279BB0", Offset = "0x22785B0", VA = "0x182279BB0")]
	public static KAFHIGOPEFK IICEDBKMAIK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public static class PEIJAPPDJFE
{
	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x308C2F0", Offset = "0x308ACF0", VA = "0x18308C2F0")]
	public static OKPKCEBGDLD<TOk, ABPICNIEEFO> KNHJNGKFNJA<TOk>([In] this OKPKCEBGDLD<TOk, ABPICNIEEFO> PCBICLOONMH, FMGMBNHPFJE NDHKBBJANPA) where TOk : notnull
	{
		return default(OKPKCEBGDLD<TOk, ABPICNIEEFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x308C3E0", Offset = "0x308ADE0", VA = "0x18308C3E0")]
	public static OKPKCEBGDLD<TOk?, ABPICNIEEFO?> MENOEHOCBHB<TOk>([In] this OKPKCEBGDLD<TOk, ABPICNIEEFO> PCBICLOONMH)
	{
		return default(OKPKCEBGDLD<TOk, ABPICNIEEFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x308C1F0", Offset = "0x308ABF0", VA = "0x18308C1F0")]
	public static OKPKCEBGDLD<TOk?, ABPICNIEEFO?> EBJBKHAICHI<TOk>([In] this OKPKCEBGDLD<TOk, ABPICNIEEFO> PCBICLOONMH)
	{
		return default(OKPKCEBGDLD<TOk, ABPICNIEEFO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface BJOPPGIOJJG
{
	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPJNMBIFJCG([In] OKPKCEBGDLD<NEDLODCHJKB, FMGMBNHPFJE> KIBAOEBFCJF);
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public static class BMLANBLCMHJ
{
	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x2C84BA0", Offset = "0x2C835A0", VA = "0x182C84BA0")]
	public static bool GPJNMBIFJCG<TOk, TErr>(this BJOPPGIOJJG PCBICLOONMH, [In] OKPKCEBGDLD<TOk, TErr> KIBAOEBFCJF) where TOk : notnull where TErr : notnull, FMGMBNHPFJE
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface IKBBPNOAHAG
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	AGGDMFNGHFL DBMNKFDAPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface BPGBGPDHDLL
{
	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KIPLJPBBIKH JKMJGNNCIKP(int AKDANOPEPEO);
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public interface NOBBKPJBELO
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string OENPDLODONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public interface HHLDAEJMMLL
{
	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OOKLHFDAKCA? HDDJOAHHJHL(NOPFJADADBI<IMNAGMIGBGO> GMCIGOIHPGB);
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public interface JKGILDBHBOC
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string OENPDLODONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public interface OOKLHFDAKCA
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	string OENPDLODONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JKGILDBHBOC? INNBBNEKOGF(NOPFJADADBI<JDCGCGCDEHJ> GBNOGMDLOKK);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NOBBKPJBELO? HPCAKHNMMBL(NOPFJADADBI<HDHAJHHMIEL> DLNHNMIIKAN);
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public interface PJOLGJFIIJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> CEAIPKNNOGL(string PKCLPFEIPFH, string KMDNOIPDFGB);
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public interface DLFDMIENOIH
{
	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HHLDAEJMMLL? NKMPDMPJJNO([In] LNNCPMKFMDI<AKHMDDJPEIB> NIMJBDMMJPB);
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public sealed class IEMJADHENGP
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	private struct KKNLBIEHDII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int BPKEJBPHLFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public HGLHNOLHPNH? EGCBFPLAJGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public HGLHNOLHPNH? PENGFCOGKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public readonly List<LEOAEGKNMKP> HHOGJNBGFNH;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x227A0D0", Offset = "0x2278AD0", VA = "0x18227A0D0")]
		private KKNLBIEHDII(int GCBONJOGHCD, HGLHNOLHPNH? MKILNEKLLLN, HGLHNOLHPNH? MDPABGIKEGB, List<LEOAEGKNMKP> OHBFICNMFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x227A010", Offset = "0x2278A10", VA = "0x18227A010")]
		public static KKNLBIEHDII AELHPDENENI()
		{
			return default(KKNLBIEHDII);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private readonly IICGMKNFHBE<KKNLBIEHDII> PAMADDJFFEM;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public static IEMJADHENGP JOLICDCBKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x2278E30", Offset = "0x2277830", VA = "0x182278E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool MAHHBLJLNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x930140", Offset = "0x92EB40", VA = "0x180930140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x9A2C60", Offset = "0x9A1660", VA = "0x1809A2C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x2278E80", Offset = "0x2277880", VA = "0x182278E80")]
	public void IJDNKKHHMAA(BBILELNDAIN MDPABGIKEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x2279280", Offset = "0x2277C80", VA = "0x182279280")]
	public void MLHCPAOBODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x2278F40", Offset = "0x2277940", VA = "0x182278F40")]
	private static string? JHPOKNEHIEB([In] KKNLBIEHDII INLABHKIHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x2279670", Offset = "0x2278070", VA = "0x182279670")]
	public IEMJADHENGP()
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
