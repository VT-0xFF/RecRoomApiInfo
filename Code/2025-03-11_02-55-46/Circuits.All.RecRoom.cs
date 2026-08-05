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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2582650", Offset = "0x2581A50", VA = "0x182582650")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
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
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class NKCIHNNLLKD : IDisposable, BMPGHOKFICK, IPEIEHCHKAE, PMKAGMKOFNH, CMDEMMDLKDE
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class CIIICDGIDKL : DHFEHCPECKO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int ALKAKBHMKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x256A690", Offset = "0x2569A90", VA = "0x18256A690", Slot = "5")]
		public ICEINAGLPIE GCIPNEBOMCK(CFMFKDDNKAJ.HDBAEIJFPJI BDKFMFBFJII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void LFECPJFMNNN();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void ECDODKPEKAP();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x256A7E0", Offset = "0x2569BE0", VA = "0x18256A7E0", Slot = "13")]
		public virtual void NAMJEBEDBFA(NKCIHNNLLKD JGDGFDJAHBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x256A820", Offset = "0x2569C20", VA = "0x18256A820", Slot = "14")]
		public virtual void OHFOBIOOPLD(NKCIHNNLLKD JGDGFDJAHBD, CLANKEGLHHM NJNJGNMEACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		protected CIIICDGIDKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface DHFEHCPECKO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int ALKAKBHMKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ICEINAGLPIE GCIPNEBOMCK(CFMFKDDNKAJ.HDBAEIJFPJI BDKFMFBFJII);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LFECPJFMNNN();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ECDODKPEKAP();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NAMJEBEDBFA(NKCIHNNLLKD JGDGFDJAHBD);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OHFOBIOOPLD(NKCIHNNLLKD JGDGFDJAHBD, CLANKEGLHHM NJNJGNMEACN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct DDMADHLOJBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly FCAHJOKIPDH<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD, DPEINBLHDDE.AAMEMANMBDM<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD>> BCFJPNINOHE;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x256B010", Offset = "0x256A410", VA = "0x18256B010")]
		internal DDMADHLOJBK(FCAHJOKIPDH<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD, DPEINBLHDDE.AAMEMANMBDM<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD>> FBFIKJCNBGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class FHEDGNEKGLB : DPEINBLHDDE.AAMEMANMBDM<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly FHEDGNEKGLB AJPLFLPAHGP;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		private FHEDGNEKGLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9EBB80", Offset = "0x9EAF80", VA = "0x1809EBB80", Slot = "4")]
		public LOKGKIKHLGA FNNAPONHAJH(CLANKEGLHHM IIICNLIAPBJ)
		{
			return default(LOKGKIKHLGA);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x256C620", Offset = "0x256BA20", VA = "0x18256C620", Slot = "5")]
		public void NAMJEBEDBFA(NKCIHNNLLKD HAIKBOLEOOP, CLANKEGLHHM NJNJGNMEACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x256C730", Offset = "0x256BB30", VA = "0x18256C730", Slot = "6")]
		public void OHFOBIOOPLD(NKCIHNNLLKD HAIKBOLEOOP, CLANKEGLHHM NJNJGNMEACN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct LDALDJLBBPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public KLJEJOPBIHF<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD, DPEINBLHDDE.AAMEMANMBDM<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD>> BCFJPNINOHE;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2573520", Offset = "0x2572920", VA = "0x182573520")]
		internal LDALDJLBBPG(KLJEJOPBIHF<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD, DPEINBLHDDE.AAMEMANMBDM<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD>> FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x25734D0", Offset = "0x25728D0", VA = "0x1825734D0")]
		public static LDALDJLBBPG KMDIICJFNJF()
		{
			return default(LDALDJLBBPG);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct LODIBLKNBOD : JPKEPBEMGCD.EECJLCDFHNE<CLANKEGLHHM, NKCIHNNLLKD>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct LNDDLBAHOFD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<PHLGGJNOBDN<object?, MEENKFHCKIP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NKCIHNNLLKD receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public CLANKEGLHHM action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public LODIBLKNBOD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<PHLGGJNOBDN<object?, MEENKFHCKIP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x25749E0", Offset = "0x2573DE0", VA = "0x1825749E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2574BC0", Offset = "0x2573FC0", VA = "0x182574BC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xD89E50", Offset = "0xD89250", VA = "0x180D89E50", Slot = "4")]
		public DDIPAIMAGGM<OBONIKDKABJ> FDEIMDBGIPL(NKCIHNNLLKD DGAEDICPJIG)
		{
			return default(DDIPAIMAGGM<OBONIKDKABJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2574C30", Offset = "0x2574030", VA = "0x182574C30", Slot = "5")]
		public void ELGCGOAAPCA(NKCIHNNLLKD DGAEDICPJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2574C90", Offset = "0x2574090", VA = "0x182574C90", Slot = "6")]
		[AsyncStateMachine(typeof(LNDDLBAHOFD))]
		public Task<PHLGGJNOBDN<object, MEENKFHCKIP>> KAMKLFJKEOA(NKCIHNNLLKD DGAEDICPJIG, CLANKEGLHHM NJNJGNMEACN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2574DC0", Offset = "0x25741C0", VA = "0x182574DC0", Slot = "7")]
		public CLANKEGLHHM[] PKMKGCIAFOK(NKCIHNNLLKD DGAEDICPJIG)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DCOEHBJOBGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<bool, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NKCIHNNLLKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<PHLGGJNOBDN<bool, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x256AD10", Offset = "0x256A110", VA = "0x18256AD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x256AFA0", Offset = "0x256A3A0", VA = "0x18256AFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct LMJPDKMKLII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public NKCIHNNLLKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2574630", Offset = "0x2573A30", VA = "0x182574630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2574810", Offset = "0x2573C10", VA = "0x182574810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct FOCDNBPPKJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<object?, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public NKCIHNNLLKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public CLANKEGLHHM action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<PHLGGJNOBDN<object?, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x256CC20", Offset = "0x256C020", VA = "0x18256CC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x256CE10", Offset = "0x256C210", VA = "0x18256CE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly DDIPAIMAGGM<OBONIKDKABJ> CMKAHGACLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly DDMADHLOJBK EDPMMEGOAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NKKIGEIPMNP JJNEHFECIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly IPHHLICBDDI DPAMINLAJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B00")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly OANAJCCOJAC PJCJBNKFPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B08")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly IFOMDBLACAN.JEPPEMHEJJM BOOAGFKMGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly OILBPLJOJON CKFKPHKCMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly JADCGGBODIB BDFBKFLOFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly DHBDPCOFAMO OPHPOAGFFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly MNPKEKFKBMC PKMPCDNKHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private JAAFGAAHHPE MCCDBAIKKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GAMGKOKDNJP POCKEJBKCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B80")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly NKKIGEIPMNP.HEKDFICJCGK EFABAGBCIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B88")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly GFPIAOMKNJK LJBIHGBEONO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NKKIGEIPMNP JNMGPDMFNIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2580C60", Offset = "0x2580060", VA = "0x182580C60")]
		get
		{
			return default(NKKIGEIPMNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal DHFEHCPECKO NHPJLNCEDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x25809F0", Offset = "0x257FDF0", VA = "0x1825809F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal ICEINAGLPIE DHDLKOLIJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x25811E0", Offset = "0x25805E0", VA = "0x1825811E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2580C70", Offset = "0x2580070", VA = "0x182580C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool NDAEJFNJFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x25809E0", Offset = "0x257FDE0", VA = "0x1825809E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x25811D0", Offset = "0x25805D0", VA = "0x1825811D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LOPDNAOEMBE NAOGMDKOGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2581970", Offset = "0x2580D70", VA = "0x182581970", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GDMBKGJHBJF KFJAFJHOHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2581980", Offset = "0x2580D80", VA = "0x182581980", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NGENMGFIPPL OHDDFFFELGO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x25819A0", Offset = "0x2580DA0", VA = "0x1825819A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KNCPIPMMNGP DNMPPGNIFNA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2581990", Offset = "0x2580D90", VA = "0x182581990", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IFOMDBLACAN? IHINJDIOCHP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2581150", Offset = "0x2580550", VA = "0x182581150", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private FCCMKHGKDCH? BAMMCMEFLGD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2580B30", Offset = "0x257FF30", VA = "0x182580B30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2581670", Offset = "0x2580A70", VA = "0x182581670")]
	private NKCIHNNLLKD(OANAJCCOJAC GDFLHALIOAL, DDIPAIMAGGM<OBONIKDKABJ> OOHLOECMMAJ, [In] DDMADHLOJBK FDLPKFNDEJD, [In] NKKIGEIPMNP HBCJAJAGDBB, [In] IPHHLICBDDI GGMEFCICPKP, ICEINAGLPIE LHDKDGDFFNK, [In] IFOMDBLACAN.JEPPEMHEJJM EBOKEDIJCDE, NKKIGEIPMNP.HEKDFICJCGK BMAMMHBOHDH, GFPIAOMKNJK NCINCLLBCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2580C90", Offset = "0x2580090", VA = "0x182580C90")]
	public static NKCIHNNLLKD KMDIICJFNJF(OANAJCCOJAC BDKFMFBFJII, [In] DGEPOGGLINL GGCMDJGFMIK, NPFIDIKEAID IGCIEDJOHCI, [In] FPFCGGADBDG LFPDBFKOBCP, MHHCHLLKMHA HKDCMFELMFE, DDIPAIMAGGM<OBONIKDKABJ> OOHLOECMMAJ, DDIPAIMAGGM<JICIACJJKCG> OPLIFHOKAGK, DDLFMPNBOMD APBFOEBCMPA, CHIHAADLLGN OJDJGGMOIBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2580DD0", Offset = "0x25801D0", VA = "0x182580DD0")]
	public static NKCIHNNLLKD KMDIICJFNJF(OANAJCCOJAC GDFLHALIOAL, [In] NKKIGEIPMNP HBCJAJAGDBB, [In] IPHHLICBDDI GGMEFCICPKP, DDIPAIMAGGM<OBONIKDKABJ> OOHLOECMMAJ, DDIPAIMAGGM<JICIACJJKCG> OPLIFHOKAGK, DDLFMPNBOMD APBFOEBCMPA, CHIHAADLLGN OJDJGGMOIBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2580690", Offset = "0x257FA90", VA = "0x182580690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x25811F0", Offset = "0x25805F0", VA = "0x1825811F0")]
	[AsyncStateMachine(typeof(DCOEHBJOBGD))]
	public Task<PHLGGJNOBDN<bool, MEENKFHCKIP>> PBGKLIIHHBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2580A40", Offset = "0x257FE40", VA = "0x182580A40")]
	[AsyncStateMachine(typeof(LMJPDKMKLII))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> ILFKAOAPEMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2580270", Offset = "0x257F670", VA = "0x182580270")]
	internal void BECNNAKAFID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2580610", Offset = "0x257FA10", VA = "0x182580610")]
	internal CCAOJCEHJPO<CLANKEGLHHM> CNOJKIIMICG([In] PNNHPPGJKOL LGJMCAIMIJC)
	{
		return default(CCAOJCEHJPO<CLANKEGLHHM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x25810E0", Offset = "0x25804E0", VA = "0x1825810E0")]
	internal bool MNCPMFPEIOM([In] PNNHPPGJKOL LGJMCAIMIJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2580480", Offset = "0x257F880", VA = "0x182580480")]
	internal PHLGGJNOBDN<CLANKEGLHHM, MEENKFHCKIP> CJMLDDDNABC([In] CHDNCIEHFCE IIHMFJJELIL)
	{
		return default(PHLGGJNOBDN<CLANKEGLHHM, MEENKFHCKIP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2580880", Offset = "0x257FC80", VA = "0x182580880")]
	private void ELGCGOAAPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x25808D0", Offset = "0x257FCD0", VA = "0x1825808D0")]
	[AsyncStateMachine(typeof(FOCDNBPPKJN))]
	internal Task<PHLGGJNOBDN<object, MEENKFHCKIP>> FIGOFECCHPE(CLANKEGLHHM NJNJGNMEACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x25812E0", Offset = "0x25806E0", VA = "0x1825812E0")]
	private CLANKEGLHHM[] PKMKGCIAFOK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class FGKMIACCKCP<TData> : OGPHAGHJAIC, BBBPNHGJIBA, MOCCGNOLGDK where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly IIIMCLEJECC<MJBBEHHNFNA>? DJDPOHKNHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string KONAMMIBLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly TData IDIBBHDGOOI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IIIMCLEJECC<MJBBEHHNFNA>? MIIDPBALBKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x27CC990", Offset = "0x27CBD90", VA = "0x1827CC990", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x96E0E0", Offset = "0x96D4E0", VA = "0x18096E0E0", Slot = "7")]
	public override string CMLLJBLPAFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x44FCD60", Offset = "0x44FC160", VA = "0x1844FCD60")]
	internal FGKMIACCKCP([In] IIIMCLEJECC<MJBBEHHNFNA>? AAIGHMMBEPO, DDIPAIMAGGM<OKNMLBCIJPN>? FGBHMHOONOL, IOKind? CPDIHPPOPNL, string LPIFIOEEOGF, [In] TData MJFOKKFMONL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class BCCANAJFNIM
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2568C00", Offset = "0x2568000", VA = "0x182568C00")]
	public static PHLGGJNOBDN<APKIHILGHMH, BBBPNHGJIBA> IPJMJMHIJOB([In] this FMOELGGLLIJ<LGNHFAFPODE> NHHJAMMOOCM)
	{
		return default(PHLGGJNOBDN<APKIHILGHMH, BBBPNHGJIBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x31F7FE0", Offset = "0x31F73E0", VA = "0x1831F7FE0")]
	public static PHLGGJNOBDN<TOk, BBBPNHGJIBA> JHHEDKIJOPI<TOk>([In] this PHLGGJNOBDN<TOk, BBBPNHGJIBA> IIICNLIAPBJ, [In] IIIMCLEJECC<MJBBEHHNFNA>? AAIGHMMBEPO, DDIPAIMAGGM<OKNMLBCIJPN>? FGBHMHOONOL, IOKind? CPDIHPPOPNL, string LPIFIOEEOGF) where TOk : notnull
	{
		return default(PHLGGJNOBDN<TOk, BBBPNHGJIBA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OANAJCCOJAC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	ILKMIOOGCOB.EHPJJLGHBOE NGDICHKCLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	CFMFKDDNKAJ.HDBAEIJFPJI JPLAAGPKBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NKCIHNNLLKD.DHFEHCPECKO PFKBHOEOBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NLBLNAEPKLK.DFFDFJNJFKF BELOFBOPGLI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DPEINBLHDDE.AAMEMANMBDM<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD> GAFIOAODHMM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DAKCFEAIFAM.EKCDIEEEGBJ LCLDHONDNDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BEEAEKGKICI AFLGMJPAKOG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	JKNEJPMEIIO KDEPEJEBNGC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	ELJEIFDODCL FKNCKPGKMEM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	BHCGEAFMBGC PBNBIEICHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	MJLHKINPHPH PCKEMGCNPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class CHIMNGFEJIH
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x256A230", Offset = "0x2569630", VA = "0x18256A230")]
	public static CLANKEGLHHM JFGBFLNJBBD(this CLANKEGLHHM IIICNLIAPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x256A160", Offset = "0x2569560", VA = "0x18256A160")]
	public static CLANKEGLHHM EHICEBJJIFD(this FKIJPFCMNEM IIICNLIAPBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct FKIJPFCMNEM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct BFAAEGIJPLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<object?, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public NKCIHNNLLKD root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public FKIJPFCMNEM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<PHLGGJNOBDN<object?, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2569180", Offset = "0x2568580", VA = "0x182569180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2569440", Offset = "0x2568840", VA = "0x182569440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly ByteString KAMPPLLIEDO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xC1B040", Offset = "0xC1A440", VA = "0x180C1B040")]
	private FKIJPFCMNEM(ByteString PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x256CB60", Offset = "0x256BF60", VA = "0x18256CB60")]
	public static CLANKEGLHHM NDMIFPMJOFO(ByteString PEBNJNGMMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x256CAB0", Offset = "0x256BEB0", VA = "0x18256CAB0")]
	public static OHEPFANKILP<LOKGKIKHLGA, FKIJPFCMNEM> GAIBCKPOAGL(CLANKEGLHHM MEJAAODDDKA)
	{
		return default(OHEPFANKILP<LOKGKIKHLGA, FKIJPFCMNEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x256C9A0", Offset = "0x256BDA0", VA = "0x18256C9A0")]
	[AsyncStateMachine(typeof(BFAAEGIJPLN))]
	public static Task<PHLGGJNOBDN<object, MEENKFHCKIP>> FIGOFECCHPE(NKCIHNNLLKD HAIKBOLEOOP, FKIJPFCMNEM IIICNLIAPBJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct KKDEJAHDOEH
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2572D80", Offset = "0x2572180", VA = "0x182572D80")]
	public static CLANKEGLHHM NDMIFPMJOFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2572D10", Offset = "0x2572110", VA = "0x182572D10")]
	public static OHEPFANKILP<LOKGKIKHLGA, KKDEJAHDOEH> GAIBCKPOAGL(CLANKEGLHHM MEJAAODDDKA)
	{
		return default(OHEPFANKILP<LOKGKIKHLGA, KKDEJAHDOEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2572C90", Offset = "0x2572090", VA = "0x182572C90")]
	public static PHLGGJNOBDN<AOFFOIKPJDJ, MJOPIANFEAH> AIDNGKCAKPA(NKCIHNNLLKD HAIKBOLEOOP, [In] KKDEJAHDOEH IIICNLIAPBJ)
	{
		return default(PHLGGJNOBDN<AOFFOIKPJDJ, MJOPIANFEAH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct CHPBOBPBFJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct DMDDNFLKKAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MJOPIANFEAH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NKCIHNNLLKD root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CHPBOBPBFJA self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private PHLGGJNOBDN<AOFFOIKPJDJ, MJOPIANFEAH> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x256B440", Offset = "0x256A840", VA = "0x18256B440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x256B7B0", Offset = "0x256ABB0", VA = "0x18256B7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly MHIINPCBDCK? IOOKOIBMNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly EBPMLNHKOOL? EJALNHGNDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly LDEPJGKAOIB? BKJEAELBDHE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x24A2810", Offset = "0x24A1C10", VA = "0x1824A2810")]
	private CHPBOBPBFJA(MHIINPCBDCK? GIODPLCOFGH, EBPMLNHKOOL? CEHAGGGBMLL, LDEPJGKAOIB? IEFIJIFMMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x256A590", Offset = "0x2569990", VA = "0x18256A590")]
	public static CLANKEGLHHM? NDMIFPMJOFO(MHIINPCBDCK? GIODPLCOFGH, EBPMLNHKOOL? CEHAGGGBMLL, LDEPJGKAOIB? IEFIJIFMMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x256A480", Offset = "0x2569880", VA = "0x18256A480")]
	public static OHEPFANKILP<LOKGKIKHLGA, CHPBOBPBFJA> GAIBCKPOAGL(CLANKEGLHHM MEJAAODDDKA)
	{
		return default(OHEPFANKILP<LOKGKIKHLGA, CHPBOBPBFJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x256A340", Offset = "0x2569740", VA = "0x18256A340")]
	[AsyncStateMachine(typeof(DMDDNFLKKAA))]
	public static Task<PHLGGJNOBDN<AOFFOIKPJDJ, MJOPIANFEAH>> FIGOFECCHPE(NKCIHNNLLKD HAIKBOLEOOP, CHPBOBPBFJA IIICNLIAPBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct CFEGIEKJBCP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct NOCDKPAIKLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<PIPILNCCEGE, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CFEGIEKJBCP self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NKCIHNNLLKD root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private PHLGGJNOBDN<PIPILNCCEGE, MEENKFHCKIP> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private PHLGGJNOBDN<object?, MOCCGNOLGDK>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private PHLGGJNOBDN<object?, MOCCGNOLGDK> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private PHLGGJNOBDN<object?, MOCCGNOLGDK>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter<PHLGGJNOBDN<object?, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x25819B0", Offset = "0x2580DB0", VA = "0x1825819B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2581E20", Offset = "0x2581220", VA = "0x182581E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly IReadOnlyList<CLANKEGLHHM> NMMOBOHHPFI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xC1B040", Offset = "0xC1A440", VA = "0x180C1B040")]
	private CFEGIEKJBCP(IReadOnlyList<CLANKEGLHHM> LNLIOHBEPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2569690", Offset = "0x2568A90", VA = "0x182569690")]
	public static CLANKEGLHHM NDMIFPMJOFO(IReadOnlyList<CLANKEGLHHM> LNLIOHBEPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x25695F0", Offset = "0x25689F0", VA = "0x1825695F0")]
	public static OHEPFANKILP<LOKGKIKHLGA, CFEGIEKJBCP> GAIBCKPOAGL(CLANKEGLHHM MEJAAODDDKA)
	{
		return default(OHEPFANKILP<LOKGKIKHLGA, CFEGIEKJBCP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x25694B0", Offset = "0x25688B0", VA = "0x1825694B0")]
	[AsyncStateMachine(typeof(NOCDKPAIKLO))]
	public static Task<PHLGGJNOBDN<PIPILNCCEGE, MEENKFHCKIP>> FIGOFECCHPE(NKCIHNNLLKD HAIKBOLEOOP, CFEGIEKJBCP IIICNLIAPBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct CHDNCIEHFCE
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class ANIJNDMMDFN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class EEIIOMMPPNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IIIMCLEJECC<ANIJNDMMDFN> actionId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public EEIIOMMPPNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x256BE40", Offset = "0x256B240", VA = "0x18256BE40")]
		internal CLANKEGLHHM POBNMACHOJL(int count, int index, [In] ReadOnlySpan<byte> span)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly IIIMCLEJECC<ANIJNDMMDFN> OMCHKDIMHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly int ECPNGLCMABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly int NGGCGOFGPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly byte[] IDIBBHDGOOI;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x256A140", Offset = "0x2569540", VA = "0x18256A140")]
	private CHDNCIEHFCE(IIIMCLEJECC<ANIJNDMMDFN> GIEFBGABFFH, int LOHPPDCIAAL, int FFCBHHABFJN, byte[] MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x256A030", Offset = "0x2569430", VA = "0x18256A030")]
	public static CLANKEGLHHM NDMIFPMJOFO(IIIMCLEJECC<ANIJNDMMDFN> GIEFBGABFFH, int LOHPPDCIAAL, int FFCBHHABFJN, ByteString MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2569DD0", Offset = "0x25691D0", VA = "0x182569DD0")]
	public static CLANKEGLHHM[] CAPJDJOLNHH(CLANKEGLHHM NJNJGNMEACN, int LEFAFPBEKPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2569EE0", Offset = "0x25692E0", VA = "0x182569EE0")]
	public static OHEPFANKILP<LOKGKIKHLGA, CHDNCIEHFCE> GAIBCKPOAGL(CLANKEGLHHM MEJAAODDDKA)
	{
		return default(OHEPFANKILP<LOKGKIKHLGA, CHDNCIEHFCE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2569C40", Offset = "0x2569040", VA = "0x182569C40")]
	public static PHLGGJNOBDN<CLANKEGLHHM, MEENKFHCKIP> AIDNGKCAKPA(NKCIHNNLLKD HAIKBOLEOOP, [In] CHDNCIEHFCE IIICNLIAPBJ)
	{
		return default(PHLGGJNOBDN<CLANKEGLHHM, MEENKFHCKIP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct PNNHPPGJKOL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct LCEMIIMMGHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<bool, MJOPIANFEAH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NKCIHNNLLKD root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public PNNHPPGJKOL self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private PHLGGJNOBDN<bool, MJOPIANFEAH> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MJOPIANFEAH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2572E20", Offset = "0x2572220", VA = "0x182572E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2573460", Offset = "0x2572860", VA = "0x182573460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly int ECPNGLCMABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly int NGGCGOFGPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly byte[] IDIBBHDGOOI;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xB092E0", Offset = "0xB086E0", VA = "0x180B092E0")]
	private PNNHPPGJKOL(int LOHPPDCIAAL, int FFCBHHABFJN, byte[] MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2583520", Offset = "0x2582920", VA = "0x182583520")]
	public static CLANKEGLHHM NDMIFPMJOFO(int LOHPPDCIAAL, int FFCBHHABFJN, ByteString MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2583330", Offset = "0x2582730", VA = "0x182583330")]
	public static CLANKEGLHHM?[]? JDAKEGNMFCJ(int LEFAFPBEKPP, MHIINPCBDCK? GIODPLCOFGH, EBPMLNHKOOL? CEHAGGGBMLL, LDEPJGKAOIB? IEFIJIFMMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2583250", Offset = "0x2582650", VA = "0x182583250")]
	public static OHEPFANKILP<LOKGKIKHLGA, PNNHPPGJKOL> GAIBCKPOAGL(CLANKEGLHHM MEJAAODDDKA)
	{
		return default(OHEPFANKILP<LOKGKIKHLGA, PNNHPPGJKOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2583120", Offset = "0x2582520", VA = "0x182583120")]
	[AsyncStateMachine(typeof(LCEMIIMMGHL))]
	public static Task<PHLGGJNOBDN<bool, MJOPIANFEAH>> FIGOFECCHPE(NKCIHNNLLKD HAIKBOLEOOP, PNNHPPGJKOL IIICNLIAPBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class OILBPLJOJON : LOPDNAOEMBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly NKCIHNNLLKD GCLOKDKLDGK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public JJIOCLDDGAH? AJPLFLPAHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2582C70", Offset = "0x2582070", VA = "0x182582C70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	internal OILBPLJOJON(NKCIHNNLLKD JGDGFDJAHBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class LFOPINEOLBA : JJIOCLDDGAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly NKCIHNNLLKD GCLOKDKLDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly HBGCPCDJMAM LEJIPHKGPED;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x96FAD0", Offset = "0x96EED0", VA = "0x18096FAD0")]
	public LFOPINEOLBA(NKCIHNNLLKD JGDGFDJAHBD, HBGCPCDJMAM HOIGHFACGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2573530", Offset = "0x2572930", VA = "0x182573530", Slot = "4")]
	public PHLGGJNOBDN<APKIHILGHMH, BBBPNHGJIBA> AFPNCJMCGFF(IIIMCLEJECC<MJBBEHHNFNA> JFBLNBCAHJM, DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, DDIPAIMAGGM<PINAMAKOAOE> KPKAGMFKFEL)
	{
		return default(PHLGGJNOBDN<APKIHILGHMH, BBBPNHGJIBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2573810", Offset = "0x2572C10", VA = "0x182573810", Slot = "5")]
	public PHLGGJNOBDN<APKIHILGHMH, BBBPNHGJIBA> LLJCMPONBIM(IIIMCLEJECC<MJBBEHHNFNA> JFBLNBCAHJM, DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, DDIPAIMAGGM<BFEMAIFODOI> BFKOLDCFMBJ)
	{
		return default(PHLGGJNOBDN<APKIHILGHMH, BBBPNHGJIBA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class ILKMIOOGCOB : HJLILFOIKND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface EHPJJLGHBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HBGCPCDJMAM> IBDOKIDEGJL(NKCIHNNLLKD JGDGFDJAHBD, EBPMLNHKOOL? IJGJLIFIGDN, LDEPJGKAOIB? OFPDHOLPNAG, CancellationToken MLAPMBKLAOF);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		OEAAHDEFLFJ FKHHBNHJDJP(NKCIHNNLLKD JGDGFDJAHBD, MHIINPCBDCK KLPBHNMLJKB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class DMADNLPHFMH : EHPJJLGHBOE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct KDPKPAFHLLI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AsyncTaskMethodBuilder<HBGCPCDJMAM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public NKCIHNNLLKD circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public EBPMLNHKOOL cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public LDEPJGKAOIB cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<NLBLNAEPKLK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2572250", Offset = "0x2571650", VA = "0x182572250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2572420", Offset = "0x2571820", VA = "0x182572420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly DMADNLPHFMH AJPLFLPAHGP;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		private DMADNLPHFMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x256B270", Offset = "0x256A670", VA = "0x18256B270", Slot = "4")]
		[AsyncStateMachine(typeof(KDPKPAFHLLI))]
		public Task<HBGCPCDJMAM> IBDOKIDEGJL(NKCIHNNLLKD JGDGFDJAHBD, EBPMLNHKOOL? IJGJLIFIGDN, LDEPJGKAOIB? OFPDHOLPNAG, CancellationToken MLAPMBKLAOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x256B250", Offset = "0x256A650", VA = "0x18256B250", Slot = "5")]
		public OEAAHDEFLFJ FKHHBNHJDJP(NKCIHNNLLKD JGDGFDJAHBD, MHIINPCBDCK KLPBHNMLJKB)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct KFHCICAIICF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<ILKMIOOGCOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NKCIHNNLLKD circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public EBPMLNHKOOL cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public LDEPJGKAOIB cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public MHIINPCBDCK evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private EHPJJLGHBOE <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<HBGCPCDJMAM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2572490", Offset = "0x2571890", VA = "0x182572490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2572980", Offset = "0x2571D80", VA = "0x182572980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HBGCPCDJMAM LEJIPHKGPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly OEAAHDEFLFJ JCMCADOJBKG;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IFOMDBLACAN IHINJDIOCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2571930", Offset = "0x2570D30", VA = "0x182571930", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FCCMKHGKDCH GINCBJGKJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2571870", Offset = "0x2570C70", VA = "0x182571870", Slot = "5")]
		get
		{
			return default(FCCMKHGKDCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LFOPINEOLBA GDLDMCOOJOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public CLNANLDOMDG NCDLPEGHBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xE37540", Offset = "0xE36940", VA = "0x180E37540")]
	private ILKMIOOGCOB(HBGCPCDJMAM HOIGHFACGEC, OEAAHDEFLFJ FPCLKDBKCBE, LFOPINEOLBA FIOOBDBNHOG, CLNANLDOMDG GJOGDIDNDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2571700", Offset = "0x2570B00", VA = "0x182571700")]
	[AsyncStateMachine(typeof(KFHCICAIICF))]
	public static Task<ILKMIOOGCOB> FCBKLNEHMME(NKCIHNNLLKD JGDGFDJAHBD, MHIINPCBDCK KLPBHNMLJKB, EBPMLNHKOOL? IJGJLIFIGDN, LDEPJGKAOIB? OFPDHOLPNAG, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x25716A0", Offset = "0x2570AA0", VA = "0x1825716A0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class CFMFKDDNKAJ : ICEINAGLPIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface HDBAEIJFPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HJLILFOIKND> EBBAJLGEPDD(NKCIHNNLLKD JGDGFDJAHBD, MHIINPCBDCK KLPBHNMLJKB, EBPMLNHKOOL? IJGJLIFIGDN, LDEPJGKAOIB? OFPDHOLPNAG, CancellationToken MLAPMBKLAOF);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BOEFGLLLOGI();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NINHOPALOOO();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class LMPBAOLJHAC : HDBAEIJFPJI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct AMBHIHENNOP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public AsyncTaskMethodBuilder<HJLILFOIKND> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public NKCIHNNLLKD circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public MHIINPCBDCK evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public EBPMLNHKOOL cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public LDEPJGKAOIB cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private TaskAwaiter<ILKMIOOGCOB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x25687D0", Offset = "0x2567BD0", VA = "0x1825687D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2568B10", Offset = "0x2567F10", VA = "0x182568B10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2574880", Offset = "0x2573C80", VA = "0x182574880", Slot = "4")]
		[AsyncStateMachine(typeof(AMBHIHENNOP))]
		public Task<HJLILFOIKND> EBBAJLGEPDD(NKCIHNNLLKD JGDGFDJAHBD, MHIINPCBDCK KLPBHNMLJKB, EBPMLNHKOOL? IJGJLIFIGDN, LDEPJGKAOIB? OFPDHOLPNAG, CancellationToken MLAPMBKLAOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void BOEFGLLLOGI();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void NINHOPALOOO();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		protected LMPBAOLJHAC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct DNGEHGDMPCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<HJLILFOIKND> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public CFMFKDDNKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<AOFFOIKPJDJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x256B820", Offset = "0x256AC20", VA = "0x18256B820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x256BA20", Offset = "0x256AE20", VA = "0x18256BA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct ODJBBAHCJCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public CFMFKDDNKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public NKCIHNNLLKD circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public MHIINPCBDCK evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public EBPMLNHKOOL cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LDEPJGKAOIB cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<HJLILFOIKND> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x25826D0", Offset = "0x2581AD0", VA = "0x1825826D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2582C10", Offset = "0x2582010", VA = "0x182582C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly HDBAEIJFPJI JPIGDBMGNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TaskCompletionSource<AOFFOIKPJDJ> LEPGDBCPONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly TaskCompletionSource<AOFFOIKPJDJ> DANFJLGIKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly CancellationTokenSource IHCLAKADCFG;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NDAEJFNJFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x993140", Offset = "0x992540", VA = "0x180993140", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x992EC0", Offset = "0x9922C0", VA = "0x180992EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GJIAKANDJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xCB5070", Offset = "0xCB4470", VA = "0x180CB5070", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x11735D0", Offset = "0x11729D0", VA = "0x1811735D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool HNNFGEBAMHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x181F3E0", Offset = "0x181E7E0", VA = "0x18181F3E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x25699C0", Offset = "0x2568DC0", VA = "0x1825699C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public HJLILFOIKND? CLPBFOOMHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x96A710", Offset = "0x969B10", VA = "0x18096A710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x25698D0", Offset = "0x2568CD0", VA = "0x1825698D0", Slot = "7")]
	[AsyncStateMachine(typeof(DNGEHGDMPCE))]
	public Task<HJLILFOIKND> JAPKMBFJNPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2569B30", Offset = "0x2568F30", VA = "0x182569B30")]
	public CFMFKDDNKAJ(HDBAEIJFPJI BDKFMFBFJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x25699D0", Offset = "0x2568DD0", VA = "0x1825699D0", Slot = "8")]
	[AsyncStateMachine(typeof(ODJBBAHCJCD))]
	public Task NLFGDODMJDJ(NKCIHNNLLKD JGDGFDJAHBD, MHIINPCBDCK KLPBHNMLJKB, EBPMLNHKOOL? IJGJLIFIGDN, LDEPJGKAOIB? OFPDHOLPNAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2569750", Offset = "0x2568B50", VA = "0x182569750", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class CMCIBHPKLGK : OFENEMGKFIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CLNANLDOMDG AAABMHDPGIH;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	public CMCIBHPKLGK(CLNANLDOMDG GJOGDIDNDGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal static class AGJMCPCFPFI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class IAFGHIKICGF<TGraph> : DMEFLICKLLD where TGraph : PNKCBINOOLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		protected readonly TGraph HGKHEIGMPEJ;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual FLIIMMEGIPD? DKGAODONMLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x161E690", Offset = "0x161DA90", VA = "0x18161E690", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public DDIPAIMAGGM<HFJKEPEKFIF> MBEHCCKGFJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x47F85F0", Offset = "0x47F79F0", VA = "0x1847F85F0", Slot = "5")]
			get
			{
				return default(DDIPAIMAGGM<HFJKEPEKFIF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public DDIPAIMAGGM<HFJKEPEKFIF>? KIHCGKPNDLE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x47F8610", Offset = "0x47F7A10", VA = "0x1847F8610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
		public IAFGHIKICGF(TGraph ADKLABHDFKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class FHJAMOBAKIG : IAFGHIKICGF<NOJNBBKCMEK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override FLIIMMEGIPD? DKGAODONMLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x256C8B0", Offset = "0x256BCB0", VA = "0x18256C8B0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x256C8D0", Offset = "0x256BCD0", VA = "0x18256C8D0")]
		public FHJAMOBAKIG(NOJNBBKCMEK FPGACGCCFKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2568640", Offset = "0x2567A40", VA = "0x182568640")]
	public static DMEFLICKLLD KMDIICJFNJF(PNKCBINOOLI ADKLABHDFKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class IDBMMCFHKGB : ECMFCMJBHKI, DMPNDNPCPEA, GPCJCODIIKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class JCLEEDCIKBI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public JCLEEDCIKBI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public BEEAEKGKICI errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x25854A0", Offset = "0x25848A0", VA = "0x1825854A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x2585710", Offset = "0x2584B10", VA = "0x182585710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDBMMCFHKGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public JCLEEDCIKBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2572160", Offset = "0x2571560", VA = "0x182572160")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task LIHOMIDEEBC(BEEAEKGKICI errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct MOGDOHIOOND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IDBMMCFHKGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x257FD10", Offset = "0x257F110", VA = "0x18257FD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2580210", Offset = "0x257F610", VA = "0x182580210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class ONEFJHKBLGA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public ONEFJHKBLGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x2585770", Offset = "0x2584B70", VA = "0x182585770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x2585A50", Offset = "0x2584E50", VA = "0x182585A50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDBMMCFHKGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public ONEFJHKBLGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2582FF0", Offset = "0x25823F0", VA = "0x182582FF0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task JEMLAGFNFKG(BEEAEKGKICI errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly IGIMKCEAIAM MLKCJIPLFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly ICollection<LFGDMLKOCFK> IKDLDNAJCBL;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private OANAJCCOJAC ENCJOGKFABL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x256FDF0", Offset = "0x256F1F0", VA = "0x18256FDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public DDIPAIMAGGM<PINAMAKOAOE> NBHPLPGMEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xDF6DF0", Offset = "0xDF61F0", VA = "0x180DF6DF0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(DDIPAIMAGGM<PINAMAKOAOE>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xDF8A00", Offset = "0xDF7E00", VA = "0x180DF8A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private DDIPAIMAGGM<PEBJCIAAJKE> DCHBLHHBBMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x116F4D0", Offset = "0x116E8D0", VA = "0x18116F4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public DDIPAIMAGGM<HAEPGAFINPD> CFDCHFKHNHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x98D4D0", Offset = "0x98C8D0", VA = "0x18098D4D0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(DDIPAIMAGGM<HAEPGAFINPD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override DDIPAIMAGGM<OKNMLBCIJPN> PJBPAIBDABE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2570270", Offset = "0x256F670", VA = "0x182570270", Slot = "21")]
		get
		{
			return default(DDIPAIMAGGM<OKNMLBCIJPN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool HBDNALKNBEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2570620", Offset = "0x256FA20", VA = "0x182570620", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2571480", Offset = "0x2570880", VA = "0x182571480")]
	private IDBMMCFHKGB(NKCIHNNLLKD JGDGFDJAHBD, PEEGBFKPCLP IKAPMMHHNFM, IGIMKCEAIAM POCPKBAMPFK, DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, DDIPAIMAGGM<PINAMAKOAOE> KPKAGMFKFEL, DDIPAIMAGGM<PEBJCIAAJKE> OCGFCPNBLBK, bool KMLPACPOEJE, string OGOCCCFKJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x25707F0", Offset = "0x256FBF0", VA = "0x1825707F0")]
	public static IDBMMCFHKGB KMDIICJFNJF(NKCIHNNLLKD JGDGFDJAHBD, PEEGBFKPCLP IKAPMMHHNFM, IGIMKCEAIAM NIPDIMDKGGA, DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, DDIPAIMAGGM<PEBJCIAAJKE> OCGFCPNBLBK, DDIPAIMAGGM<PINAMAKOAOE> KPKAGMFKFEL, bool KMLPACPOEJE, bool GDIAMNAENEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2570E40", Offset = "0x2570240", VA = "0x182570E40", Slot = "22")]
	protected override void OBBALIPJEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2570000", Offset = "0x256F400", VA = "0x182570000", Slot = "23")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2571410", Offset = "0x2570810", VA = "0x182571410", Slot = "31")]
	public void PHJFDNGCHOG(LFGDMLKOCFK JEPGHMNCPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x256F820", Offset = "0x256EC20", VA = "0x18256F820", Slot = "28")]
	public void BGKGKDDJGPP(BPLLIBECNKE MKIMIMNFHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x256EE80", Offset = "0x256E280", VA = "0x18256EE80", Slot = "29")]
	public void AMAJONAILGF(MADABFHCILM AMMADKNDOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2570BA0", Offset = "0x256FFA0", VA = "0x182570BA0", Slot = "24")]
	protected override void LIFGFHNALCB(PBLNDGBEFPK PONIOPFBMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x256FEA0", Offset = "0x256F2A0", VA = "0x18256FEA0", Slot = "33")]
	public string DNMKKCBINHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2571150", Offset = "0x2570550", VA = "0x182571150", Slot = "30")]
	public string PFNHOBJHKON(int BIHHFABMMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2570340", Offset = "0x256F740", VA = "0x182570340")]
	private void HKCBDAADNFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x256ED70", Offset = "0x256E170", VA = "0x18256ED70", Slot = "32")]
	public void AIPBKEJEPCB(LFGDMLKOCFK JEPGHMNCPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x25700B0", Offset = "0x256F4B0", VA = "0x1825700B0")]
	private void FHFNHDPAKNB(bool PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x256FC20", Offset = "0x256F020", VA = "0x18256FC20", Slot = "34")]
	[AsyncStateMachine(typeof(MOGDOHIOOND))]
	public Task CDMENHMGLBA(string PEBNJNGMMHE, bool KGFCEKKPBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2570CF0", Offset = "0x25700F0", VA = "0x182570CF0")]
	public void NMANNKCMLCO(string PEBNJNGMMHE, bool KGFCEKKPBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2570FB0", Offset = "0x25703B0", VA = "0x182570FB0")]
	private void PBDCCJHECHL(int PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0xDF8A00", Offset = "0xDF7E00", VA = "0x180DF8A00")]
	internal void JKMGGEGOKOI(DDIPAIMAGGM<PINAMAKOAOE> PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x25700A0", Offset = "0x256F4A0", VA = "0x1825700A0")]
	[CompilerGenerated]
	private void FGDLKAHDCPH(string PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2570560", Offset = "0x256F960", VA = "0x182570560")]
	[CompilerGenerated]
	private bool HKGGDLCCLEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x256EC60", Offset = "0x256E060", VA = "0x18256EC60")]
	[CompilerGenerated]
	private bool AEMDOFOFMOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x256EE30", Offset = "0x256E230", VA = "0x18256EE30")]
	[CompilerGenerated]
	private int MMGJHEIPFFK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x256FE10", Offset = "0x256F210", VA = "0x18256FE10")]
	[CompilerGenerated]
	private bool DJHFGOAPOIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2571470", Offset = "0x2570870", VA = "0x182571470")]
	[CompilerGenerated]
	private void PLFBOFMEJDL(string PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x256FD30", Offset = "0x256F130", VA = "0x18256FD30")]
	[CompilerGenerated]
	private bool CEPONGCGPAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x256ED20", Offset = "0x256E120", VA = "0x18256ED20")]
	[CompilerGenerated]
	private bool AFLKAECBDMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x256FB90", Offset = "0x256EF90", VA = "0x18256FB90")]
	[CompilerGenerated]
	private bool BNCCGNIIGPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x256EE30", Offset = "0x256E230", VA = "0x18256EE30")]
	[CompilerGenerated]
	private int AKBCMEAEAIK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2570EE0", Offset = "0x25702E0", VA = "0x182570EE0")]
	[CompilerGenerated]
	private bool OHLNINPMFAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x25702C0", Offset = "0x256F6C0", VA = "0x1825702C0")]
	[CompilerGenerated]
	private object GOEFBKDCNGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x25706A0", Offset = "0x256FAA0", VA = "0x1825706A0")]
	[CompilerGenerated]
	private void JAJDJNKOLDC(object PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2570720", Offset = "0x256FB20", VA = "0x182570720")]
	[CompilerGenerated]
	private bool JMMMJCMLCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class GDJIKIPKAMH
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private sealed class EJOEDCHBDJB : KHLCMDBOIHF<AAIDJGLMNDI>
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class MKKEECGMOKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public EJOEDCHBDJB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public MKKEECGMOKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x257FBD0", Offset = "0x257EFD0", VA = "0x18257FBD0")]
			internal object CPIPOALEILF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x257FC40", Offset = "0x257F040", VA = "0x18257FC40")]
			internal void FLGHMPLIDOG(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x256C240", Offset = "0x256B640", VA = "0x18256C240")]
		public EJOEDCHBDJB(NKCIHNNLLKD JGDGFDJAHBD, AAIDJGLMNDI FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x256BFB0", Offset = "0x256B3B0", VA = "0x18256BFB0", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class ILMAPBPHDPG : HGHCPKPHDKE<HPEDEHHCECN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override HJOAEGEOEOA ACIKPPGGAOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xACB320", Offset = "0xACA720", VA = "0x180ACB320", Slot = "140")]
			get
			{
				return default(HJOAEGEOEOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2571980", Offset = "0x2570D80", VA = "0x182571980")]
		public ILMAPBPHDPG(NKCIHNNLLKD JGDGFDJAHBD, HPEDEHHCECN FBFIKJCNBGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class ELONPMONCAB : KHLCMDBOIHF<KDFNGKGPGMF>
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x256C5B0", Offset = "0x256B9B0", VA = "0x18256C5B0")]
		public ELONPMONCAB(NKCIHNNLLKD JGDGFDJAHBD, KDFNGKGPGMF IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x256C2B0", Offset = "0x256B6B0", VA = "0x18256C2B0", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x256C430", Offset = "0x256B830", VA = "0x18256C430")]
		[CompilerGenerated]
		private bool HHEIDOFLMJG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x256C480", Offset = "0x256B880", VA = "0x18256C480")]
		[CompilerGenerated]
		private void PFJNODGOHPN(bool PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class EBABJFPEACA : KHLCMDBOIHF<HBCNJNHGDMK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class AAGDDMEFIHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public EBABJFPEACA <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public AAGDDMEFIHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x25683D0", Offset = "0x25677D0", VA = "0x1825683D0")]
			internal void CPIPOALEILF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2568470", Offset = "0x2567870", VA = "0x182568470")]
			internal bool FLGHMPLIDOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2568420", Offset = "0x2567820", VA = "0x182568420")]
			internal bool EPKLEDOALFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x25684C0", Offset = "0x25678C0", VA = "0x1825684C0")]
			internal void LLPEOFFHJAI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x25685F0", Offset = "0x25679F0", VA = "0x1825685F0")]
			internal bool MLACHNNPFGB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x256BDD0", Offset = "0x256B1D0", VA = "0x18256BDD0")]
		public EBABJFPEACA(NKCIHNNLLKD JGDGFDJAHBD, HBCNJNHGDMK IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x256BA90", Offset = "0x256AE90", VA = "0x18256BA90", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class NOGAFJAJACA : KHLCMDBOIHF<PMIEGKJBAPC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class JCDOKBIENFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public NOGAFJAJACA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public JCDOKBIENFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2571A30", Offset = "0x2570E30", VA = "0x182571A30")]
			internal object CPIPOALEILF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x25720E0", Offset = "0x25714E0", VA = "0x1825720E0")]
			internal bool OOMNEMKOEAI(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2571C90", Offset = "0x2571090", VA = "0x182571C90")]
			internal void FLGHMPLIDOG(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2571B30", Offset = "0x2570F30", VA = "0x182571B30")]
			internal string EPKLEDOALFO(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x2571EF0", Offset = "0x25712F0", VA = "0x182571EF0")]
			internal IReadOnlyList<object> LLPEOFFHJAI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2571F40", Offset = "0x2571340", VA = "0x182571F40")]
			internal bool MLACHNNPFGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x25719E0", Offset = "0x2570DE0", VA = "0x1825719E0")]
			internal bool BFELNAFNPCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x2571FB0", Offset = "0x25713B0", VA = "0x182571FB0")]
			internal void NNDKFPHCDMP(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x25825E0", Offset = "0x25819E0", VA = "0x1825825E0")]
		public NOGAFJAJACA(NKCIHNNLLKD JGDGFDJAHBD, PMIEGKJBAPC IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2581E90", Offset = "0x2581290", VA = "0x182581E90", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class CJBIPAHANBP : KHLCMDBOIHF<DKADGNINLGN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class CMJKCOMLIEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public CJBIPAHANBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public CMJKCOMLIEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x256AB40", Offset = "0x2569F40", VA = "0x18256AB40")]
			internal bool CPIPOALEILF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x256ABE0", Offset = "0x2569FE0", VA = "0x18256ABE0")]
			internal void FLGHMPLIDOG(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x256AB90", Offset = "0x2569F90", VA = "0x18256AB90")]
			internal bool EPKLEDOALFO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x256AAD0", Offset = "0x2569ED0", VA = "0x18256AAD0")]
		public CJBIPAHANBP(NKCIHNNLLKD JGDGFDJAHBD, DKADGNINLGN IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x256A8A0", Offset = "0x2569CA0", VA = "0x18256A8A0", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class DEGCEMHKMIO<TNode> : KHLCMDBOIHF<TNode> where TNode : notnull, OLLAPGDPPGJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct FNJELMOFAOF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public AsyncTaskMethodBuilder<PHLGGJNOBDN<DDIPAIMAGGM<OPLLODEDJNC>, MEENKFHCKIP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public DEGCEMHKMIO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private TaskAwaiter<PHLGGJNOBDN<DDIPAIMAGGM<OPLLODEDJNC>, MEENKFHCKIP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x4587E60", Offset = "0x4587260", VA = "0x184587E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x4588270", Offset = "0x4587670", VA = "0x184588270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct LCFBJNGPFAA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public DEGCEMHKMIO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public DDIPAIMAGGM<OPLLODEDJNC> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x4BD5BD0", Offset = "0x4BD4FD0", VA = "0x184BD5BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x4BD5FE0", Offset = "0x4BD53E0", VA = "0x184BD5FE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override bool FBCJBPCIHBO
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public sealed override DDIPAIMAGGM<OPLLODEDJNC>? MDBKBOLEHOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x63EA1A0", Offset = "0x63E95A0", VA = "0x1863EA1A0", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4C24590", Offset = "0x4C23990", VA = "0x184C24590")]
		protected DEGCEMHKMIO(NKCIHNNLLKD JGDGFDJAHBD, TNode IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x63EA080", Offset = "0x63E9480", VA = "0x1863EA080", Slot = "114")]
		[AsyncStateMachine(typeof(DEGCEMHKMIO<>.FNJELMOFAOF))]
		public override Task<PHLGGJNOBDN<DDIPAIMAGGM<OPLLODEDJNC>, MEENKFHCKIP>> ICEGCFLOLFA(string OGOCCCFKJPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x63E9DF0", Offset = "0x63E91F0", VA = "0x1863E9DF0", Slot = "138")]
		public sealed override bool DBBDGGPKCAM(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x63E9D30", Offset = "0x63E9130", VA = "0x1863E9D30", Slot = "126")]
		protected sealed override bool AOMMJIEMHAI(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x63E9EB0", Offset = "0x63E92B0", VA = "0x1863E9EB0", Slot = "127")]
		protected override bool FDACKGKKFPH(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x63E9F70", Offset = "0x63E9370", VA = "0x1863E9F70", Slot = "115")]
		[AsyncStateMachine(typeof(DEGCEMHKMIO<>.LCFBJNGPFAA))]
		public override Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> GKOCFAONMMO(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class HNKJMLNGDIA : MLAHPDHAGLC<IBEDHKMJMBD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class GOGOGOLHMOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public HNKJMLNGDIA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public GOGOGOLHMOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x256E570", Offset = "0x256D970", VA = "0x18256E570")]
			internal bool POAKGAFIMML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x256E4B0", Offset = "0x256D8B0", VA = "0x18256E4B0")]
			internal void ECOFGBGBOGH(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x256EC00", Offset = "0x256E000", VA = "0x18256EC00")]
		public HNKJMLNGDIA(NKCIHNNLLKD JGDGFDJAHBD, IBEDHKMJMBD FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x256E9B0", Offset = "0x256DDB0", VA = "0x18256E9B0", Slot = "140")]
		protected override void NNBPHDJICKE(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class PAGHLEGKALN : NPGKLDLHHMJ<GIGDGALDFIP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xACC550", Offset = "0xACB950", VA = "0x180ACC550", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x25830C0", Offset = "0x25824C0", VA = "0x1825830C0")]
		public PAGHLEGKALN(NKCIHNNLLKD JGDGFDJAHBD, GIGDGALDFIP IKAPMMHHNFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public abstract class NPGKLDLHHMJ<TNode> : KHLCMDBOIHF<TNode> where TNode : notnull, JKPFBJIICHI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct FLBMIOPKIOD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public AsyncTaskMethodBuilder<PHLGGJNOBDN<DDIPAIMAGGM<OPLLODEDJNC>, MEENKFHCKIP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public NPGKLDLHHMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private TaskAwaiter<PHLGGJNOBDN<DDIPAIMAGGM<OPLLODEDJNC>, MEENKFHCKIP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x450E7F0", Offset = "0x450DBF0", VA = "0x18450E7F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x450EC90", Offset = "0x450E090", VA = "0x18450EC90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct HOGMFDCKGKM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public NPGKLDLHHMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public DDIPAIMAGGM<OPLLODEDJNC> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x475B3B0", Offset = "0x475A7B0", VA = "0x18475B3B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x475B830", Offset = "0x475AC30", VA = "0x18475B830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct DGCFOBEPJBI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<PHLGGJNOBDN<PIPILNCCEGE, MEENKFHCKIP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public NPGKLDLHHMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private TaskAwaiter<PHLGGJNOBDN<PIPILNCCEGE, MEENKFHCKIP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x63ECEC0", Offset = "0x63EC2C0", VA = "0x1863ECEC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x63ED570", Offset = "0x63EC970", VA = "0x1863ED570", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class AIEHAEDPALL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public AIEHAEDPALL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0x3D57ED0", Offset = "0x3D572D0", VA = "0x183D57ED0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000152")]
				[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public PJCGMMMJNCL configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public NPGKLDLHHMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public AIEHAEDPALL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x4723FE0", Offset = "0x47233E0", VA = "0x184723FE0")]
			internal bool NNDKFPHCDMP(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x4723920", Offset = "0x4722D20", VA = "0x184723920")]
			internal void CPIPOALEILF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x47240C0", Offset = "0x47234C0", VA = "0x1847240C0")]
			[AsyncStateMachine(typeof(NPGKLDLHHMJ<>.AIEHAEDPALL.<<BuildConfigMenuInternal>b__7>d))]
			internal void OOMNEMKOEAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x4723BF0", Offset = "0x4722FF0", VA = "0x184723BF0")]
			internal bool FLGHMPLIDOG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class OOCJJHODAHI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public OOCJJHODAHI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x3D57B60", Offset = "0x3D56F60", VA = "0x183D57B60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public AIEHAEDPALL CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public OOCJJHODAHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x4FDBCD0", Offset = "0x4FDB0D0", VA = "0x184FDBCD0")]
			internal void EPKLEDOALFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
			internal string LLPEOFFHJAI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
			internal void MLACHNNPFGB(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x4FDBC30", Offset = "0x4FDB030", VA = "0x184FDBC30")]
			[AsyncStateMachine(typeof(NPGKLDLHHMJ<>.OOCJJHODAHI.<<BuildConfigMenuInternal>b__5>d))]
			internal void BFELNAFNPCK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class JHIMGEBKIJK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public JHIMGEBKIJK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x3D57690", Offset = "0x3D56A90", VA = "0x183D57690", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000056")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				public JHIMGEBKIJK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				private TaskAwaiter<PHLGGJNOBDN<DDIPAIMAGGM<PEBJCIAAJKE>, MEENKFHCKIP>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x3D57870", Offset = "0x3D56C70", VA = "0x183D57870", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000057")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				public JHIMGEBKIJK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				private TaskAwaiter<PHLGGJNOBDN<DDIPAIMAGGM<EGDOMAELJCE>, MEENKFHCKIP>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x3D56FE0", Offset = "0x3D563E0", VA = "0x183D56FE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public NPGKLDLHHMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public DDIPAIMAGGM<OPLLODEDJNC> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public PJCGMMMJNCL configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public FCJCPEMKLMP nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public AMDOGBLKLIA selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public List<HKGKEPKKOLG> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public AMDOGBLKLIA selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public List<HKGKEPKKOLG> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public JHIMGEBKIJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x4A18A90", Offset = "0x4A17E90", VA = "0x184A18A90")]
			internal bool PMAJHCAKPDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x4A187D0", Offset = "0x4A17BD0", VA = "0x184A187D0")]
			internal void MCPIMOFOBGJ(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x4A188E0", Offset = "0x4A17CE0", VA = "0x184A188E0")]
			internal bool MPKFICEAKAP(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x4A18750", Offset = "0x4A17B50", VA = "0x184A18750")]
			internal bool KANKAGGJJHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x4A186B0", Offset = "0x4A17AB0", VA = "0x184A186B0")]
			[AsyncStateMachine(typeof(NPGKLDLHHMJ<>.JHIMGEBKIJK.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void INGCDGCNEJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x4A18790", Offset = "0x4A17B90", VA = "0x184A18790")]
			internal bool KFEJJBCNFPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4A18520", Offset = "0x4A17920", VA = "0x184A18520")]
			internal void HDNCLNJLDKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4A182F0", Offset = "0x4A176F0", VA = "0x184A182F0")]
			internal bool DKJLALLHFHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4A18180", Offset = "0x4A17580", VA = "0x184A18180")]
			internal void AHGGAFBBJPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4A18240", Offset = "0x4A17640", VA = "0x184A18240")]
			internal bool CEKCHKAPENL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4A189C0", Offset = "0x4A17DC0", VA = "0x184A189C0")]
			internal bool NANODGIDPJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x4A184B0", Offset = "0x4A178B0", VA = "0x184A184B0")]
			internal void EOFMLKKGKFA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x4A18840", Offset = "0x4A17C40", VA = "0x184A18840")]
			[AsyncStateMachine(typeof(NPGKLDLHHMJ<>.JHIMGEBKIJK.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void MNNPDAIJFNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x4A18650", Offset = "0x4A17A50", VA = "0x184A18650")]
			internal bool IMKHEIHMPIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4A185E0", Offset = "0x4A179E0", VA = "0x184A185E0")]
			internal bool IDBLJNMHMMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4A183A0", Offset = "0x4A177A0", VA = "0x184A183A0")]
			internal void DNKEBIJDJFF(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x4A18410", Offset = "0x4A17810", VA = "0x184A18410")]
			[AsyncStateMachine(typeof(NPGKLDLHHMJ<>.JHIMGEBKIJK.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void EGIGOJOAGAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x4A18A30", Offset = "0x4A17E30", VA = "0x184A18A30")]
			internal bool PCPDLNLJJEM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class AHCFKFMBOCL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public AHCFKFMBOCL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0x3D572D0", Offset = "0x3D566D0", VA = "0x183D572D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public JHIMGEBKIJK CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public AHCFKFMBOCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x4648120", Offset = "0x4647520", VA = "0x184648120")]
			internal void LONAINGOLLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
			internal string DDJAFGIFJDJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
			internal void IBEBCLKMOEP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x4648080", Offset = "0x4647480", VA = "0x184648080")]
			[AsyncStateMachine(typeof(NPGKLDLHHMJ<>.AHCFKFMBOCL.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void ANJJHFBNCKL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class GNDHGPNDMBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public FCJCPEMKLMP nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public List<HKGKEPKKOLG> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public NPGKLDLHHMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public DDIPAIMAGGM<OPLLODEDJNC> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public GNDHGPNDMBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x46C3670", Offset = "0x46C2A70", VA = "0x1846C3670")]
			internal bool JDEMJKCKDLE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class GJBHKMBMLJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public GPCJCODIIKO port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public GNDHGPNDMBA CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public GJBHKMBMLJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x466FA80", Offset = "0x466EE80", VA = "0x18466FA80")]
			internal void BMABDGBELJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x466FBF0", Offset = "0x466EFF0", VA = "0x18466FBF0")]
			internal bool OIIPBFHJHJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x466FC40", Offset = "0x466F040", VA = "0x18466FC40")]
			internal void PPHDAHNCLAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x466FB90", Offset = "0x466EF90", VA = "0x18466FB90")]
			internal bool FHKEAFFDGJE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class JMPIGDKEMAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public HKGKEPKKOLG portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public GJBHKMBMLJA CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public JMPIGDKEMAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4A34AE0", Offset = "0x4A33EE0", VA = "0x184A34AE0")]
			internal void ILGJILIONNH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class DAJGNGOCHKM
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public DAJGNGOCHKM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000189")]
				[Cpp2IlInjected.Address(RVA = "0x3D59300", Offset = "0x3D58700", VA = "0x183D59300", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public AMDOGBLKLIA selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public FCJCPEMKLMP nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public GPCJCODIIKO port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public DAJGNGOCHKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x63E0670", Offset = "0x63DFA70", VA = "0x1863E0670")]
			internal int JBBEOJEIHHM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x63E0430", Offset = "0x63DF830", VA = "0x1863E0430")]
			internal void FDHOFPJIAJP(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760")]
			internal string OFGDAADKCKL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x63E06B0", Offset = "0x63DFAB0", VA = "0x1863E06B0")]
			[AsyncStateMachine(typeof(NPGKLDLHHMJ<>.DAJGNGOCHKM.<<CreatePortItemV2>b__3>d))]
			internal void JCAGDJDHCFP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x63E0770", Offset = "0x63DFB70", VA = "0x1863E0770")]
			internal bool ONGJCHCAAIF(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly Dictionary<DDIPAIMAGGM<OPLLODEDJNC>, bool> JMEJHDDDKPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly Dictionary<DDIPAIMAGGM<OPLLODEDJNC>, bool> CEFJFBHMHBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly Dictionary<DDIPAIMAGGM<OPLLODEDJNC>, bool> NNKMHJMOBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private Dictionary<DDIPAIMAGGM<OPLLODEDJNC>, bool> DELEKMJFEMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<DDIPAIMAGGM<OPLLODEDJNC>, bool> MAHMAEJJPJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private Dictionary<DDIPAIMAGGM<OPLLODEDJNC>, bool> IOAELLMEJOM;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool NCEOFBCMLPI
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool GMKEAMPMHMH
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool KDOPJCBAKEA
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected virtual bool NBACDBJEMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "142")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override DDIPAIMAGGM<HFJKEPEKFIF>? JPDOACLBPGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x4EA04E0", Offset = "0x4E9F8E0", VA = "0x184EA04E0", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override DDIPAIMAGGM<OPLLODEDJNC>? MDBKBOLEHOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x4EA0790", Offset = "0x4E9FB90", VA = "0x184EA0790", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override IEnumerable<IIIMCLEJECC<MJBBEHHNFNA>>? MPLILGDKHMF
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x4EA0590", Offset = "0x4E9F990", VA = "0x184EA0590", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4EA02C0", Offset = "0x4E9F6C0", VA = "0x184EA02C0")]
		public NPGKLDLHHMJ(NKCIHNNLLKD JGDGFDJAHBD, TNode IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "143")]
		protected virtual bool JEJDFNPOCEF(int DBNMDGOMBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "144")]
		protected virtual bool NEIKHHAJGCB(int DBNMDGOMBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "145")]
		protected virtual bool BJGEEPNLDHM(int DBNMDGOMBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "146")]
		protected virtual void IHKOIALEDJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4E9C860", Offset = "0x4E9BC60", VA = "0x184E9C860", Slot = "138")]
		public override bool DBBDGGPKCAM(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4E9D560", Offset = "0x4E9C960", VA = "0x184E9D560", Slot = "114")]
		[AsyncStateMachine(typeof(NPGKLDLHHMJ<>.FLBMIOPKIOD))]
		public override Task<PHLGGJNOBDN<DDIPAIMAGGM<OPLLODEDJNC>, MEENKFHCKIP>> ICEGCFLOLFA(string OGOCCCFKJPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4E9CB10", Offset = "0x4E9BF10", VA = "0x184E9CB10", Slot = "115")]
		[AsyncStateMachine(typeof(NPGKLDLHHMJ<>.HOGMFDCKGKM))]
		public override Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> GKOCFAONMMO(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x4E9C900", Offset = "0x4E9BD00", VA = "0x184E9C900", Slot = "116")]
		public override void EIFEGDIJDOC(DDIPAIMAGGM<OPLLODEDJNC> FFCBHHABFJN, DDIPAIMAGGM<OPLLODEDJNC> GACPILKGIFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0060", Offset = "0x4E9F460", VA = "0x184EA0060", Slot = "117")]
		public override IEnumerable<CLANKEGLHHM> PPMMPIOGLAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4E9EE30", Offset = "0x4E9E230", VA = "0x184E9EE30")]
		[AsyncStateMachine(typeof(NPGKLDLHHMJ<>.DGCFOBEPJBI))]
		private Task<PHLGGJNOBDN<PIPILNCCEGE, MEENKFHCKIP>> MNCFICKCODF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "147")]
		protected virtual bool EKNAFMLMAMJ(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "148")]
		protected virtual bool OCGLOJBKJNK(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "149")]
		protected virtual bool EIGKCPFCBFP(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "150")]
		protected virtual bool CCPGEPIHNIA(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "151")]
		protected virtual bool HGJGHNEGJON(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, int GOJBKPNDDMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "152")]
		protected virtual bool MLFIKMLIIGB(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, int GOJBKPNDDMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "153")]
		protected virtual bool GBEFFBJHPCD(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, int GGHELIGMLFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "154")]
		protected virtual bool JDNFNEEONHM(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, int GGHELIGMLFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "155")]
		protected virtual bool AICLPMJPKCO(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, int DEHGFPGBPMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "156")]
		protected virtual bool MMKAONPEPPO(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, int EDIOMDNEKAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4E9B990", Offset = "0x4E9AD90", VA = "0x184E9B990", Slot = "157")]
		protected virtual List<AMDOGBLKLIA> AOJGFIKBJFA(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "158")]
		protected virtual void KLBBCOLKOEM(PJCGMMMJNCL JBEBACPNGMO, PDABNCNPMFE KKBFHGDCNIK, FCJCPEMKLMP GFNKAILOPLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4E9BE10", Offset = "0x4E9B210", VA = "0x184E9BE10", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4E9D680", Offset = "0x4E9CA80", VA = "0x184E9D680")]
		private PDABNCNPMFE IKIONILDEAB(PJCGMMMJNCL JBEBACPNGMO, FCJCPEMKLMP GFNKAILOPLP, DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4E9EF30", Offset = "0x4E9E330", VA = "0x184E9EF30")]
		private List<HKGKEPKKOLG> ONGIFBNAGFG(PJCGMMMJNCL JBEBACPNGMO, FCJCPEMKLMP GFNKAILOPLP, PDABNCNPMFE DIPEPMHDNPO, bool FOIJCGMBPJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4E9CC20", Offset = "0x4E9C020", VA = "0x184E9CC20")]
		private List<HKGKEPKKOLG> HDIAEEGMGCE(PJCGMMMJNCL JBEBACPNGMO, FCJCPEMKLMP GFNKAILOPLP, GPCJCODIIKO NFLKFIGLIHM, bool FOIJCGMBPJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4E9BC20", Offset = "0x4E9B020", VA = "0x184E9BC20")]
		private AMDOGBLKLIA CGNIBGCPLAD(List<AMDOGBLKLIA> OLJOHKMBICH, GPCJCODIIKO NFLKFIGLIHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4E9EDA0", Offset = "0x4E9E1A0", VA = "0x184E9EDA0")]
		[CompilerGenerated]
		private CLANKEGLHHM MLLFCOEHFGP(PEEGBFKPCLP ILOCIBNKPPB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class DJEMIJPDOPM : KHLCMDBOIHF<APHLFAHBFJJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class BEPGDNHEKFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public DJEMIJPDOPM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public BEPGDNHEKFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x25690A0", Offset = "0x25684A0", VA = "0x1825690A0")]
			internal int CPIPOALEILF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x25690F0", Offset = "0x25684F0", VA = "0x1825690F0")]
			internal void FLGHMPLIDOG(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xF40A90", Offset = "0xF3FE90", VA = "0x180F40A90", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x256B1E0", Offset = "0x256A5E0", VA = "0x18256B1E0")]
		public DJEMIJPDOPM(NKCIHNNLLKD JGDGFDJAHBD, APHLFAHBFJJ IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x256B020", Offset = "0x256A420", VA = "0x18256B020", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class KIBMOAGALJB : MLAHPDHAGLC<IEAIMCJIOBD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private sealed class MHHHIINOLCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public KIBMOAGALJB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public MHHHIINOLCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x257FB50", Offset = "0x257EF50", VA = "0x18257FB50")]
			internal int POAKGAFIMML()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x257FAB0", Offset = "0x257EEB0", VA = "0x18257FAB0")]
			internal void ECOFGBGBOGH(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2572C30", Offset = "0x2572030", VA = "0x182572C30")]
		public KIBMOAGALJB(NKCIHNNLLKD JGDGFDJAHBD, IEAIMCJIOBD FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x25729F0", Offset = "0x2571DF0", VA = "0x1825729F0", Slot = "140")]
		protected override void NNBPHDJICKE(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private sealed class OJMFDKAANGO : KHLCMDBOIHF<BFFFGBBCMBL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xCA5A80", Offset = "0xCA4E80", VA = "0x180CA5A80", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2582F80", Offset = "0x2582380", VA = "0x182582F80")]
		public OJMFDKAANGO(NKCIHNNLLKD JGDGFDJAHBD, BFFFGBBCMBL IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class POPAGJMGEHG : KHLCMDBOIHF<DANGHCMGDCN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class MDNCCOGMHLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public POPAGJMGEHG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public PJCGMMMJNCL configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public MDNCCOGMHLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x2575B90", Offset = "0x2574F90", VA = "0x182575B90")]
			internal bool CPIPOALEILF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x2576880", Offset = "0x2575C80", VA = "0x182576880")]
			internal void FLGHMPLIDOG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x257EC10", Offset = "0x257E010", VA = "0x18257EC10")]
			internal bool MLACHNNPFGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x2575130", Offset = "0x2574530", VA = "0x182575130")]
			internal bool BFELNAFNPCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x257EFD0", Offset = "0x257E3D0", VA = "0x18257EFD0")]
			internal void NNDKFPHCDMP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x257F700", Offset = "0x257EB00", VA = "0x18257F700")]
			internal bool PDBBEEKCDGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x2576730", Offset = "0x2575B30", VA = "0x182576730")]
			internal bool FHJOKNPINOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x257ED50", Offset = "0x257E150", VA = "0x18257ED50")]
			internal void NBEMADGGLJP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x257E410", Offset = "0x257D810", VA = "0x18257E410")]
			internal bool KIOIIHBIIBH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2575FF0", Offset = "0x25753F0", VA = "0x182575FF0")]
			internal bool DNNKHAICDEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x257EB60", Offset = "0x257DF60", VA = "0x18257EB60")]
			internal void MIFHPLELBLF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x257F320", Offset = "0x257E720", VA = "0x18257F320")]
			internal bool ODGGFCFOIMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2575230", Offset = "0x2574630", VA = "0x182575230")]
			internal bool BMBLGBOLJCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x25769D0", Offset = "0x2575DD0", VA = "0x1825769D0")]
			internal bool FPGBKMANHIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x2575090", Offset = "0x2574490", VA = "0x182575090")]
			internal bool BBOKMLGNBHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x2576040", Offset = "0x2575440", VA = "0x182576040")]
			internal bool DOJPIBPKFGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x257E9D0", Offset = "0x257DDD0", VA = "0x18257E9D0")]
			internal bool LMNICMIFADO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2575280", Offset = "0x2574680", VA = "0x182575280")]
			internal bool BNOOONKNNEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x2576A70", Offset = "0x2575E70", VA = "0x182576A70")]
			internal bool GAHMJDFAKMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x2577090", Offset = "0x2576490", VA = "0x182577090")]
			internal bool GPAHKDPKFPD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x257E8D0", Offset = "0x257DCD0", VA = "0x18257E8D0")]
			internal void LJDDGMAGDIB(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x257D350", Offset = "0x257C750", VA = "0x18257D350")]
			internal bool HKCDDIDFEAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x2575E70", Offset = "0x2575270", VA = "0x182575E70")]
			internal bool DJNEAJNEADB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x257F3C0", Offset = "0x257E7C0", VA = "0x18257F3C0")]
			internal bool OEAIPCNICLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x2577040", Offset = "0x2576440", VA = "0x182577040")]
			internal bool GLPLDIHLGHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x257DC60", Offset = "0x257D060", VA = "0x18257DC60")]
			internal bool JMPGLBPDPHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x2576230", Offset = "0x2575630", VA = "0x182576230")]
			internal bool EFGIAHNIGGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x25770E0", Offset = "0x25764E0", VA = "0x1825770E0")]
			internal bool HAHLILOMJHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x2575D60", Offset = "0x2575160", VA = "0x182575D60")]
			internal bool DHHCEBFFHKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x25757A0", Offset = "0x2574BA0", VA = "0x1825757A0")]
			internal void CDFADMFDOAJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x2576420", Offset = "0x2575820", VA = "0x182576420")]
			internal bool EJBPCKKOEDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x257F7A0", Offset = "0x257EBA0", VA = "0x18257F7A0")]
			internal bool PFMMCBNBLDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x257E5A0", Offset = "0x257D9A0", VA = "0x18257E5A0")]
			internal void KNGGHKOGBLI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x2576130", Offset = "0x2575530", VA = "0x182576130")]
			internal bool ECMCMHPCMHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x257D960", Offset = "0x257CD60", VA = "0x18257D960")]
			internal bool JACBKHMLOLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x257F0D0", Offset = "0x257E4D0", VA = "0x18257F0D0")]
			internal void NOCJKIMABDO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x25772A0", Offset = "0x25766A0", VA = "0x1825772A0")]
			internal List<HKGKEPKKOLG> HGKBLDAIKIJ(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x257F030", Offset = "0x257E430", VA = "0x18257F030")]
			internal bool NNHFENFGCAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x257F530", Offset = "0x257E930", VA = "0x18257F530")]
			internal int OJKJEHBJGID()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2575740", Offset = "0x2574B40", VA = "0x182575740")]
			internal void CCJGEPJEHAO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x2576830", Offset = "0x2575C30", VA = "0x182576830")]
			internal bool FKPBMIHDDKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x2574DE0", Offset = "0x25741E0", VA = "0x182574DE0")]
			internal bool AAPKGFDIOJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x2576FF0", Offset = "0x25763F0", VA = "0x182576FF0")]
			internal bool GLPGKKNGOCC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x257E170", Offset = "0x257D570", VA = "0x18257E170")]
			internal int JNNDGAMCOLM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x25767D0", Offset = "0x2575BD0", VA = "0x1825767D0")]
			internal void FKOCNEOCMAG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x257D4E0", Offset = "0x257C8E0", VA = "0x18257D4E0")]
			internal bool ICCFNDFOHNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x257E4B0", Offset = "0x257D8B0", VA = "0x18257E4B0")]
			internal bool KLOBKAJNBAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x257E500", Offset = "0x257D900", VA = "0x18257E500")]
			internal bool KMCFFGACMJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x257E600", Offset = "0x257DA00", VA = "0x18257E600")]
			internal bool KOJOIHGDPEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x25759E0", Offset = "0x2574DE0", VA = "0x1825759E0")]
			internal bool CLPBBFJACME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x2575AF0", Offset = "0x2574EF0", VA = "0x182575AF0")]
			internal bool CNKBMAEDAAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x2576F40", Offset = "0x2576340", VA = "0x182576F40")]
			internal string GJJJNJPIOJJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x2574F20", Offset = "0x2574320", VA = "0x182574F20")]
			internal void AIJNHCMNAKA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x257D710", Offset = "0x257CB10", VA = "0x18257D710")]
			internal int IHDJFMMEDKC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x25756E0", Offset = "0x2574AE0", VA = "0x1825756E0")]
			internal void CBAAAKBDNIP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x2575C80", Offset = "0x2575080", VA = "0x182575C80")]
			internal bool DFKALOCLCKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x257EA70", Offset = "0x257DE70", VA = "0x18257EA70")]
			internal bool LNLAHGCABCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x257F2D0", Offset = "0x257E6D0", VA = "0x18257F2D0")]
			internal bool ODFNAMECIFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x257E320", Offset = "0x257D720", VA = "0x18257E320")]
			internal float KGJEIFJFDOH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x25763C0", Offset = "0x25757C0", VA = "0x1825763C0")]
			internal void EIKCEKJMIMF(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x257D910", Offset = "0x257CD10", VA = "0x18257D910")]
			internal bool IPPDNEEJFHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x25764E0", Offset = "0x25758E0", VA = "0x1825764E0")]
			internal bool EMMODJNDOLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2575850", Offset = "0x2574C50", VA = "0x182575850")]
			internal bool CEIKLPLKFLD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x257F960", Offset = "0x257ED60", VA = "0x18257F960")]
			internal bool PLJOKJHBLHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x257F9B0", Offset = "0x257EDB0", VA = "0x18257F9B0")]
			internal bool PMNCENJHOEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x25765F0", Offset = "0x25759F0", VA = "0x1825765F0")]
			internal bool ENKNMEANMKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x257DD70", Offset = "0x257D170", VA = "0x18257DD70")]
			internal void JNBBHMADDPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x257EEE0", Offset = "0x257E2E0", VA = "0x18257EEE0")]
			internal string NKBDGGIEBJN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x2576E10", Offset = "0x2576210", VA = "0x182576E10")]
			internal void GIPGOEPJPJG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x257EF30", Offset = "0x257E330", VA = "0x18257EF30")]
			internal bool NLANGLOMKLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x2575800", Offset = "0x2574C00", VA = "0x182575800")]
			internal bool CDOOMEIOFLE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2576930", Offset = "0x2575D30", VA = "0x182576930")]
			internal bool FNNMBIKFGOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x25753C0", Offset = "0x25747C0", VA = "0x1825753C0")]
			internal void BPOLNLBJDPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x257F4E0", Offset = "0x257E8E0", VA = "0x18257F4E0")]
			internal bool OIBIHCEBMCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x2576BD0", Offset = "0x2575FD0", VA = "0x182576BD0")]
			internal bool GDFKHNOBGCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x257D670", Offset = "0x257CA70", VA = "0x18257D670")]
			internal bool IFPBJACHKCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2577130", Offset = "0x2576530", VA = "0x182577130")]
			internal bool HAJFJGMLOEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x2576F90", Offset = "0x2576390", VA = "0x182576F90")]
			internal void GLKJAGDMKGF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2576A20", Offset = "0x2575E20", VA = "0x182576A20")]
			internal bool FPKHPDJBGFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x25758A0", Offset = "0x2574CA0", VA = "0x1825758A0")]
			internal bool CIBDMFCFOIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x257F280", Offset = "0x257E680", VA = "0x18257F280")]
			internal bool ODFJGOIMOIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x257F370", Offset = "0x257E770", VA = "0x18257F370")]
			internal bool ODNKCPOMIJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x2577240", Offset = "0x2576640", VA = "0x182577240")]
			internal void HGJKJJPPEIC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x2576C20", Offset = "0x2576020", VA = "0x182576C20")]
			internal bool GDLIJDPAGFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x25750E0", Offset = "0x25744E0", VA = "0x1825750E0")]
			internal bool BEBCFMNHAEL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x257D8C0", Offset = "0x257CCC0", VA = "0x18257D8C0")]
			internal bool IPFIEGGJHDL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x257D3F0", Offset = "0x257C7F0", VA = "0x18257D3F0")]
			internal bool HPJJLKACKAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x257F410", Offset = "0x257E810", VA = "0x18257F410")]
			internal object OGPCDPKPFND()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x2575CD0", Offset = "0x25750D0", VA = "0x182575CD0")]
			internal void DFPDFCPLDGJ(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x257EA20", Offset = "0x257DE20", VA = "0x18257EA20")]
			internal bool LMOJPCINMJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x257EC60", Offset = "0x257E060", VA = "0x18257EC60")]
			internal bool MLKLGNEPOEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x257E1C0", Offset = "0x257D5C0", VA = "0x18257E1C0")]
			internal int JPJMIBJMMAI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x257F900", Offset = "0x257ED00", VA = "0x18257F900")]
			internal void PJHOPJMCCPG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x257E980", Offset = "0x257DD80", VA = "0x18257E980")]
			internal bool LJOJGOMEMDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x2576AC0", Offset = "0x2575EC0", VA = "0x182576AC0")]
			internal bool GAJMLHPGOBL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x257E830", Offset = "0x257DC30", VA = "0x18257E830")]
			internal int LGPCGMLDNIO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x2576180", Offset = "0x2575580", VA = "0x182576180")]
			internal void EDPPLJDIFGC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x257E6A0", Offset = "0x257DAA0", VA = "0x18257E6A0")]
			internal bool LBCNBIBMOMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x2576DC0", Offset = "0x25761C0", VA = "0x182576DC0")]
			internal bool GIOLJPHLAEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x2575BE0", Offset = "0x2574FE0", VA = "0x182575BE0")]
			internal bool DAPCENBLBDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x257D5D0", Offset = "0x257C9D0", VA = "0x18257D5D0")]
			internal int IEDLIAFLAPI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x2575180", Offset = "0x2574580", VA = "0x182575180")]
			internal void BGCKJDPIMIO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x257F1E0", Offset = "0x257E5E0", VA = "0x18257F1E0")]
			internal bool OADCGGPCMOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x257F750", Offset = "0x257EB50", VA = "0x18257F750")]
			internal bool PEDGFNLCMCP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x2575320", Offset = "0x2574720", VA = "0x182575320")]
			internal bool BPBODJBHIKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x2577180", Offset = "0x2576580", VA = "0x182577180")]
			internal object HCOLGFJHOLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x2575F10", Offset = "0x2575310", VA = "0x182575F10")]
			internal void DKCGDEAGNPL(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x2574E80", Offset = "0x2574280", VA = "0x182574E80")]
			internal bool AFGBKKMFMLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x2576E80", Offset = "0x2576280", VA = "0x182576E80")]
			internal bool GJGMLAKLDIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x2576ED0", Offset = "0x25762D0", VA = "0x182576ED0")]
			internal object GJIPACBNEDA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x257EE00", Offset = "0x257E200", VA = "0x18257EE00")]
			internal void NENPAOBOGEA(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x257FA60", Offset = "0x257EE60", VA = "0x18257FA60")]
			internal bool PPFOECIOODJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x25766E0", Offset = "0x2575AE0", VA = "0x1825766E0")]
			internal int FGEDJOEDLAB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x2576C70", Offset = "0x2576070", VA = "0x182576C70")]
			internal void GEAMGDAMHEP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x2576640", Offset = "0x2575A40", VA = "0x182576640")]
			internal bool EOBJKEBIBCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x257E260", Offset = "0x257D660", VA = "0x18257E260")]
			internal bool KCDJHELNMOK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x257D2B0", Offset = "0x257C6B0", VA = "0x18257D2B0")]
			internal bool HIIBDOANCGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x2575C30", Offset = "0x2575030", VA = "0x182575C30")]
			internal int DCJGIIPOLII()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x2574FE0", Offset = "0x25743E0", VA = "0x182574FE0")]
			internal void APFLEJBHJHE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x2576320", Offset = "0x2575720", VA = "0x182576320")]
			internal bool EHFJIOCLFMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x257DD20", Offset = "0x257D120", VA = "0x18257DD20")]
			internal bool JNAIPHHBOIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x25758F0", Offset = "0x2574CF0", VA = "0x1825758F0")]
			internal bool CLBHIOBDCDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x25761E0", Offset = "0x25755E0", VA = "0x1825761E0")]
			internal float EFDAOKKAHBF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x257F130", Offset = "0x257E530", VA = "0x18257F130")]
			internal void NOGEOIIGEAP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x257E550", Offset = "0x257D950", VA = "0x18257E550")]
			internal bool KMEHGDBPAIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2576280", Offset = "0x2575680", VA = "0x182576280")]
			internal bool EGCDHKHINLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2575A30", Offset = "0x2574E30", VA = "0x182575A30")]
			internal bool CMJMKKOCEMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x257F230", Offset = "0x257E630", VA = "0x18257F230")]
			internal float ODANDGFKJOG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x257DA50", Offset = "0x257CE50", VA = "0x18257DA50")]
			internal void JDMNPJJNEDE(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x257E210", Offset = "0x257D610", VA = "0x18257E210")]
			internal bool KAMCKNPFNNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x257DAB0", Offset = "0x257CEB0", VA = "0x18257DAB0")]
			internal bool JEFNNOINNAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x2576B80", Offset = "0x2575F80", VA = "0x182576B80")]
			internal string GDDPMIJKNFD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x2576470", Offset = "0x2575870", VA = "0x182576470")]
			internal void EKJNGONOOAP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x257F840", Offset = "0x257EC40", VA = "0x18257F840")]
			internal bool PIHDOEFANKB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x2574F90", Offset = "0x2574390", VA = "0x182574F90")]
			internal bool AOKOCBGBGPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x257E930", Offset = "0x257DD30", VA = "0x18257E930")]
			internal bool LJNLBGNCCDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x257D3A0", Offset = "0x257C7A0", VA = "0x18257D3A0")]
			internal bool HKHICEPKFMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x257DB50", Offset = "0x257CF50", VA = "0x18257DB50")]
			internal string JHHDGNFAOGN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x257F690", Offset = "0x257EA90", VA = "0x18257F690")]
			internal void PCKOMMFGMKE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x257E370", Offset = "0x257D770", VA = "0x18257E370")]
			internal bool KHJEPGPLJIA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x25751E0", Offset = "0x25745E0", VA = "0x1825751E0")]
			internal bool BIAJKFLJKGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x257D820", Offset = "0x257CC20", VA = "0x18257D820")]
			internal bool ILCIABKIPNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x257D440", Offset = "0x257C840", VA = "0x18257D440")]
			internal bool IAKMGGACFFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x257EF80", Offset = "0x257E380", VA = "0x18257EF80")]
			internal string NNABPJOEOKM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x257F890", Offset = "0x257EC90", VA = "0x18257F890")]
			internal void PINNGLLPLAE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x25765A0", Offset = "0x25759A0", VA = "0x1825765A0")]
			internal bool ENEMPHENEID(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x257ED00", Offset = "0x257E100", VA = "0x18257ED00")]
			internal bool MPAFIGDFAAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x257E7E0", Offset = "0x257DBE0", VA = "0x18257E7E0")]
			internal bool LGOIBFLMJLD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2575940", Offset = "0x2574D40", VA = "0x182575940")]
			internal bool CLEELNOILFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2575EC0", Offset = "0x25752C0", VA = "0x182575EC0")]
			internal string DJOFMBDODID()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x257F580", Offset = "0x257E980", VA = "0x18257F580")]
			internal void OLKKDJNLPKK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x257DBA0", Offset = "0x257CFA0", VA = "0x18257DBA0")]
			internal bool JLBONCACGJE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x2576090", Offset = "0x2575490", VA = "0x182576090")]
			internal bool EBNEBOEPJNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x2576370", Offset = "0x2575770", VA = "0x182576370")]
			internal bool EIAIMJNGOOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x257EAC0", Offset = "0x257DEC0", VA = "0x18257EAC0")]
			internal bool MEKBJKIEEEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x257D870", Offset = "0x257CC70", VA = "0x18257D870")]
			internal string IMOIHAFLBMJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x257DBF0", Offset = "0x257CFF0", VA = "0x18257DBF0")]
			internal void JLNHOFKGHBK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x257F5F0", Offset = "0x257E9F0", VA = "0x18257F5F0")]
			internal bool OOPOFMLONFM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x257E650", Offset = "0x257DA50", VA = "0x18257E650")]
			internal bool LAABGKNDKHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x257D6C0", Offset = "0x257CAC0", VA = "0x18257D6C0")]
			internal bool IGNOBBKFOHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2575B40", Offset = "0x2574F40", VA = "0x182575B40")]
			internal bool COGGHKLEDAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x2576CD0", Offset = "0x25760D0", VA = "0x182576CD0")]
			internal string GFBBKFHLDIJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x2576B10", Offset = "0x2575F10", VA = "0x182576B10")]
			internal void GBIBNJOCFBC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x2576D70", Offset = "0x2576170", VA = "0x182576D70")]
			internal bool GINFJHJAOCB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2576980", Offset = "0x2575D80", VA = "0x182576980")]
			internal bool FOFELLINELA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x257D300", Offset = "0x257C700", VA = "0x18257D300")]
			internal bool HIMGOFOCCFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x257E3C0", Offset = "0x257D7C0", VA = "0x18257E3C0")]
			internal bool KHOENIMKFDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2575040", Offset = "0x2574440", VA = "0x182575040")]
			internal string BBOIFICGCNL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x257DCB0", Offset = "0x257D0B0", VA = "0x18257DCB0")]
			internal void JNADJMCNONB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2576D20", Offset = "0x2576120", VA = "0x182576D20")]
			internal bool GHNMMCPPOKD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x257D530", Offset = "0x257C930", VA = "0x18257D530")]
			internal bool IDJHHGCLJBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x257EB10", Offset = "0x257DF10", VA = "0x18257EB10")]
			internal bool MICHPJGBAGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x257F640", Offset = "0x257EA40", VA = "0x18257F640")]
			internal bool OPAHAIFBNCC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x257EE90", Offset = "0x257E290", VA = "0x18257EE90")]
			internal string NGADKJIJDGF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x2576530", Offset = "0x2575930", VA = "0x182576530")]
			internal void EMOJOGMNHBE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x25768E0", Offset = "0x2575CE0", VA = "0x1825768E0")]
			internal bool FLJHNBKOGAD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x257F080", Offset = "0x257E480", VA = "0x18257F080")]
			internal bool NOBLJFGHIKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x2575FA0", Offset = "0x25753A0", VA = "0x182575FA0")]
			internal bool DLOKGEJDEOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x257E460", Offset = "0x257D860", VA = "0x18257E460")]
			internal bool KLNAPIJJMEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x257E120", Offset = "0x257D520", VA = "0x18257E120")]
			internal string JNMLPFGHAGF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x257D760", Offset = "0x257CB60", VA = "0x18257D760")]
			internal void IIPODIAMOML(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x257E740", Offset = "0x257DB40", VA = "0x18257E740")]
			internal bool LDCMEJFJIDC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x25771F0", Offset = "0x25765F0", VA = "0x1825771F0")]
			internal bool HEGADDNKBBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x25762D0", Offset = "0x25756D0", VA = "0x1825762D0")]
			internal bool EGIMFJHKOJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x25760E0", Offset = "0x25754E0", VA = "0x1825760E0")]
			internal bool ECHMBBKNJLC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x257EBC0", Offset = "0x257DFC0", VA = "0x18257EBC0")]
			internal string MJBLLLHAECM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x2575670", Offset = "0x2574A70", VA = "0x182575670")]
			internal void CAFFJBCGBMC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x257F190", Offset = "0x257E590", VA = "0x18257F190")]
			internal bool NPFJEKJJJGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x257E880", Offset = "0x257DC80", VA = "0x18257E880")]
			internal bool LHOBPMPGGPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x257E6F0", Offset = "0x257DAF0", VA = "0x18257E6F0")]
			internal bool LCABKLLNPNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x257D7D0", Offset = "0x257CBD0", VA = "0x18257D7D0")]
			internal string IJNBGLAGFJK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x2575E00", Offset = "0x2575200", VA = "0x182575E00")]
			internal void DIPABLEDKML(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x2575DB0", Offset = "0x25751B0", VA = "0x182575DB0")]
			internal bool DILEFGGKOOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x257DA00", Offset = "0x257CE00", VA = "0x18257DA00")]
			internal bool JCMDCFJFENK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x257D620", Offset = "0x257CA20", VA = "0x18257D620")]
			internal bool IFKGJNEFCIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x25752D0", Offset = "0x25746D0", VA = "0x1825752D0")]
			internal string BOEOAEKHPBP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x2575A80", Offset = "0x2574E80", VA = "0x182575A80")]
			internal void CMPNLGMNGCL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x257D9B0", Offset = "0x257CDB0", VA = "0x18257D9B0")]
			internal bool JBLFKOKDMFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x257EDB0", Offset = "0x257E1B0", VA = "0x18257EDB0")]
			internal bool NDFANABLKPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x2576690", Offset = "0x2575A90", VA = "0x182576690")]
			internal bool FEJDCOGOJHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x257D580", Offset = "0x257C980", VA = "0x18257D580")]
			internal string IECOMDIKEJN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x257E2B0", Offset = "0x257D6B0", VA = "0x18257E2B0")]
			internal void KEDMOBJJMLE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x2574E30", Offset = "0x2574230", VA = "0x182574E30")]
			internal bool AEKOCGCMFHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x257E790", Offset = "0x257DB90", VA = "0x18257E790")]
			internal bool LDPGFJEIKBJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x2575990", Offset = "0x2574D90", VA = "0x182575990")]
			internal float CLFGFBHJOID()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x257F480", Offset = "0x257E880", VA = "0x18257F480")]
			internal void OIBFEJJGGNP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x2574ED0", Offset = "0x25742D0", VA = "0x182574ED0")]
			internal bool AFJCLEPBGND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x257DB00", Offset = "0x257CF00", VA = "0x18257DB00")]
			internal bool JHGAAEGJABC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x2575370", Offset = "0x2574770", VA = "0x182575370")]
			internal bool BPLJMJCHEAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x257F7F0", Offset = "0x257EBF0", VA = "0x18257F7F0")]
			internal int PIFPMBEKOHE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x257FA00", Offset = "0x257EE00", VA = "0x18257FA00")]
			internal void PPEGICPHLEK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x257D490", Offset = "0x257C890", VA = "0x18257D490")]
			internal bool IBLLDFFODDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x257ECB0", Offset = "0x257E0B0", VA = "0x18257ECB0")]
			internal bool MOAAEDPJJKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x2576780", Offset = "0x2575B80", VA = "0x182576780")]
			internal bool FKAJMGMNLFE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class LMAOFAIFFIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public MDNCCOGMHLA CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public LMAOFAIFFIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x2573AF0", Offset = "0x2572EF0", VA = "0x182573AF0")]
			internal void AIHLGJPKIHC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class AMILHDFHMGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public AMILHDFHMGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x2568B80", Offset = "0x2567F80", VA = "0x182568B80")]
			internal bool AANDGGFNJGE(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly CIIKNGDEPEP KHCNGDMBPNC;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2585340", Offset = "0x2584740", VA = "0x182585340")]
		public POPAGJMGEHG(NKCIHNNLLKD JGDGFDJAHBD, DANGHCMGDCN IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2583600", Offset = "0x2582A00", VA = "0x182583600", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class HCNDMPJGINC : KHLCMDBOIHF<NCBOGFBGDEN>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class OJENPLBOIIF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public OJENPLBOIIF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x25A2E70", Offset = "0x25A2270", VA = "0x1825A2E70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public HCNDMPJGINC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public OJENPLBOIIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x2582D80", Offset = "0x2582180", VA = "0x182582D80")]
			internal string CPIPOALEILF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x2582E20", Offset = "0x2582220", VA = "0x182582E20")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void FLGHMPLIDOG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x2582DD0", Offset = "0x25821D0", VA = "0x182582DD0")]
			internal int EPKLEDOALFO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x2582EF0", Offset = "0x25822F0", VA = "0x182582EF0")]
			internal void LLPEOFFHJAI(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xF40A90", Offset = "0xF3FE90", VA = "0x180F40A90", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x256E940", Offset = "0x256DD40", VA = "0x18256E940")]
		public HCNDMPJGINC(NKCIHNNLLKD JGDGFDJAHBD, NCBOGFBGDEN FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x256E5F0", Offset = "0x256D9F0", VA = "0x18256E5F0", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class NKPDOKGCOLL : KHLCMDBOIHF<EMJMKFNNIPE>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class BPAOENIIAPI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006E")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public BPAOENIIAPI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x25A3180", Offset = "0x25A2580", VA = "0x1825A3180", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006F")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public BPAOENIIAPI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x25A34C0", Offset = "0x25A28C0", VA = "0x1825A34C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public NKPDOKGCOLL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public BPAOENIIAPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x2589090", Offset = "0x2588490", VA = "0x182589090")]
			internal string CPIPOALEILF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x2589180", Offset = "0x2588580", VA = "0x182589180")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void FLGHMPLIDOG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x25890E0", Offset = "0x25884E0", VA = "0x1825890E0")]
			internal int EPKLEDOALFO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x25893B0", Offset = "0x25887B0", VA = "0x1825893B0")]
			internal void LLPEOFFHJAI(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x2589440", Offset = "0x2588840", VA = "0x182589440")]
			internal string MLACHNNPFGB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x2588FC0", Offset = "0x25883C0", VA = "0x182588FC0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void BFELNAFNPCK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x2589520", Offset = "0x2588920", VA = "0x182589520")]
			internal bool NNDKFPHCDMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x2589570", Offset = "0x2588970", VA = "0x182589570")]
			internal void OOMNEMKOEAI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x2589250", Offset = "0x2588650", VA = "0x182589250")]
			internal bool JEFNFEHICCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x2589600", Offset = "0x2588A00", VA = "0x182589600")]
			internal void PDBBEEKCDGB(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x2589130", Offset = "0x2588530", VA = "0x182589130")]
			internal float FHJOKNPINOA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x2589490", Offset = "0x2588890", VA = "0x182589490")]
			internal void NBEMADGGLJP(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x2589690", Offset = "0x2588A90", VA = "0x182589690")]
			internal int PDLHGBKKCKH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x25892A0", Offset = "0x25886A0", VA = "0x1825892A0")]
			internal void JMDNDEMMFKB(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x2589340", Offset = "0x2588740", VA = "0x182589340")]
			internal bool KIOIIHBIIBH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xF40A90", Offset = "0xF3FE90", VA = "0x180F40A90", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x25A0E70", Offset = "0x25A0270", VA = "0x1825A0E70")]
		public NKPDOKGCOLL(NKCIHNNLLKD JGDGFDJAHBD, EMJMKFNNIPE IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x25A0430", Offset = "0x259F830", VA = "0x1825A0430", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class ALJHKFIOCLP : KHLCMDBOIHF<LOBEABADHFA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class LGOHLAPMLBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public ALJHKFIOCLP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public LGOHLAPMLBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x259D890", Offset = "0x259CC90", VA = "0x18259D890")]
			internal Dictionary<string, BFNODLBAELJ> CPIPOALEILF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x259DA60", Offset = "0x259CE60", VA = "0x18259DA60")]
			internal int FLGHMPLIDOG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x259D930", Offset = "0x259CD30", VA = "0x18259D930")]
			internal void EPKLEDOALFO(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x259DAB0", Offset = "0x259CEB0", VA = "0x18259DAB0")]
			internal bool LLPEOFFHJAI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0xF40A90", Offset = "0xF3FE90", VA = "0x180F40A90", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x2588080", Offset = "0x2587480", VA = "0x182588080")]
		public ALJHKFIOCLP(NKCIHNNLLKD JGDGFDJAHBD, LOBEABADHFA FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2587DB0", Offset = "0x25871B0", VA = "0x182587DB0", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class MPJCPFPDBCA : KHLCMDBOIHF<HCMBPGGNFLK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class JJJBLHPLIDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public MPJCPFPDBCA <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public JJJBLHPLIDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x259C390", Offset = "0x259B790", VA = "0x18259C390")]
			internal void CPIPOALEILF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xF40A90", Offset = "0xF3FE90", VA = "0x180F40A90", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x25A01E0", Offset = "0x259F5E0", VA = "0x1825A01E0")]
		public MPJCPFPDBCA(NKCIHNNLLKD JGDGFDJAHBD, HCMBPGGNFLK FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x25A0060", Offset = "0x259F460", VA = "0x1825A0060", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class DGIPGAPKOAG<TNode> : NPGKLDLHHMJ<TNode> where TNode : notnull, HMGJGLKPKPD
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool GPNDAFEAGEK
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override DNDLFOONKGP? HKAACFHNBNI
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x63ED700", Offset = "0x63ECB00", VA = "0x1863ED700", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool FMNGOENBMPE
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x63ED770", Offset = "0x63ECB70", VA = "0x1863ED770", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xC92010", Offset = "0xC91410", VA = "0x180C92010", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x52D0770", Offset = "0x52CFB70", VA = "0x1852D0770")]
		public DGIPGAPKOAG(NKCIHNNLLKD JGDGFDJAHBD, TNode IKAPMMHHNFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class MACLAPKKJND : DGIPGAPKOAG<HAJBIEOMIFJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class ODIPJLEGMCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public MACLAPKKJND <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public ODIPJLEGMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x25A1520", Offset = "0x25A0920", VA = "0x1825A1520")]
			internal object CPIPOALEILF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x25A1680", Offset = "0x25A0A80", VA = "0x1825A1680")]
			internal void FLGHMPLIDOG(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x25A1590", Offset = "0x25A0990", VA = "0x1825A1590")]
			internal void EPKLEDOALFO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static object[]? PJGGOEGCCMH;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x259E550", Offset = "0x259D950", VA = "0x18259E550")]
		public MACLAPKKJND(NKCIHNNLLKD JGDGFDJAHBD, HAJBIEOMIFJ IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x259DFB0", Offset = "0x259D3B0", VA = "0x18259DFB0", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class DNLNKDBNAKC : KHLCMDBOIHF<GHBHDEKAGJB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xB8FA30", Offset = "0xB8EE30", VA = "0x180B8FA30", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x2595FA0", Offset = "0x25953A0", VA = "0x182595FA0")]
		public DNLNKDBNAKC(NKCIHNNLLKD JGDGFDJAHBD, GHBHDEKAGJB IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private sealed class JFEHDEOICJP : KHLCMDBOIHF<PDKADJOMPFN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xAC50C0", Offset = "0xAC44C0", VA = "0x180AC50C0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x259BC30", Offset = "0x259B030", VA = "0x18259BC30")]
		public JFEHDEOICJP(NKCIHNNLLKD JGDGFDJAHBD, PDKADJOMPFN IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "126")]
		protected override bool AOMMJIEMHAI(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class KCIOOGBOICD : KHLCMDBOIHF<PEKCPOCCDIK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xAB2660", Offset = "0xAB1A60", VA = "0x180AB2660", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool OGGGHKEJEKI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x259D700", Offset = "0x259CB00", VA = "0x18259D700", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override bool CEKNFLAGCAK
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x259D690", Offset = "0x259CA90", VA = "0x18259D690")]
		public KCIOOGBOICD(NKCIHNNLLKD JGDGFDJAHBD, PEKCPOCCDIK IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class CDINFBIAPFI : KHLCMDBOIHF<CICCKFHPHDG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xACB320", Offset = "0xACA720", VA = "0x180ACB320", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool OGGGHKEJEKI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x2589760", Offset = "0x2588B60", VA = "0x182589760", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		protected override bool CEKNFLAGCAK
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x25896F0", Offset = "0x2588AF0", VA = "0x1825896F0")]
		public CDINFBIAPFI(NKCIHNNLLKD JGDGFDJAHBD, CICCKFHPHDG IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class OPFCGEKIEGE : MLAHPDHAGLC<NBGEEIGINDM>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class HKMDIMHOHJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public OPFCGEKIEGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public HKMDIMHOHJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x259B800", Offset = "0x259AC00", VA = "0x18259B800")]
			internal float POAKGAFIMML()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x259B760", Offset = "0x259AB60", VA = "0x18259B760")]
			internal void ECOFGBGBOGH(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x25A2740", Offset = "0x25A1B40", VA = "0x1825A2740")]
		public OPFCGEKIEGE(NKCIHNNLLKD JGDGFDJAHBD, NBGEEIGINDM FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x25A24C0", Offset = "0x25A18C0", VA = "0x1825A24C0", Slot = "140")]
		protected override void NNBPHDJICKE(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class JIIHHFANGKP : KHLCMDBOIHF<BEHHOHGODHI>
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class NGOGOIKOFBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public JIIHHFANGKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public NGOGOIKOFBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x25A0250", Offset = "0x259F650", VA = "0x1825A0250")]
			internal bool CPIPOALEILF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x25A02A0", Offset = "0x259F6A0", VA = "0x1825A02A0")]
			internal void FLGHMPLIDOG(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x259BF40", Offset = "0x259B340", VA = "0x18259BF40")]
		public JIIHHFANGKP(NKCIHNNLLKD JGDGFDJAHBD, BEHHOHGODHI FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x259BCA0", Offset = "0x259B0A0", VA = "0x18259BCA0", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class AKBCIJGALPC : KHLCMDBOIHF<HFELPMHHBBP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class MILOAAPLMGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public AKBCIJGALPC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public MILOAAPLMGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x259EB00", Offset = "0x259DF00", VA = "0x18259EB00")]
			internal object CPIPOALEILF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x259F1E0", Offset = "0x259E5E0", VA = "0x18259F1E0")]
			internal bool OOMNEMKOEAI(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x259ED90", Offset = "0x259E190", VA = "0x18259ED90")]
			internal void FLGHMPLIDOG(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x259EC30", Offset = "0x259E030", VA = "0x18259EC30")]
			internal string EPKLEDOALFO(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x259EFF0", Offset = "0x259E3F0", VA = "0x18259EFF0")]
			internal IReadOnlyList<object> LLPEOFFHJAI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x259F040", Offset = "0x259E440", VA = "0x18259F040")]
			internal bool MLACHNNPFGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x259EAB0", Offset = "0x259DEB0", VA = "0x18259EAB0")]
			internal bool BFELNAFNPCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x259F0B0", Offset = "0x259E4B0", VA = "0x18259F0B0")]
			internal void NNDKFPHCDMP(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x2587D40", Offset = "0x2587140", VA = "0x182587D40")]
		public AKBCIJGALPC(NKCIHNNLLKD JGDGFDJAHBD, HFELPMHHBBP FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x2587520", Offset = "0x2586920", VA = "0x182587520", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class MMALOCKOAAK : DEGCEMHKMIO<EEHAGCFOLCA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xC95140", Offset = "0xC94540", VA = "0x180C95140", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x259F260", Offset = "0x259E660", VA = "0x18259F260")]
		public MMALOCKOAAK(NKCIHNNLLKD JGDGFDJAHBD, EEHAGCFOLCA IKAPMMHHNFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class LOCILHMGJGC : MLAHPDHAGLC<EANKKFHLJKA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class MCPCDDDJJMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public LOCILHMGJGC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public MCPCDDDJJMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x259E650", Offset = "0x259DA50", VA = "0x18259E650")]
			internal int POAKGAFIMML()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x259E5B0", Offset = "0x259D9B0", VA = "0x18259E5B0")]
			internal void ECOFGBGBOGH(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x259DF50", Offset = "0x259D350", VA = "0x18259DF50")]
		public LOCILHMGJGC(NKCIHNNLLKD JGDGFDJAHBD, EANKKFHLJKA FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x259DC50", Offset = "0x259D050", VA = "0x18259DC50", Slot = "140")]
		protected override void NNBPHDJICKE(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class CIBACHEOEBG : KHLCMDBOIHF<JACPCHIHHCI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class BAEBMHAFNKP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public CIBACHEOEBG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public BAEBMHAFNKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x25880F0", Offset = "0x25874F0", VA = "0x1825880F0")]
			internal bool CPIPOALEILF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x2588140", Offset = "0x2587540", VA = "0x182588140")]
			internal void FLGHMPLIDOG(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x2589990", Offset = "0x2588D90", VA = "0x182589990")]
		public CIBACHEOEBG(NKCIHNNLLKD JGDGFDJAHBD, JACPCHIHHCI FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x25897B0", Offset = "0x2588BB0", VA = "0x1825897B0", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class ADGGAADPBEP : KHLCMDBOIHF<GBJNKKFOGHF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class LBOKBPPLKEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public ADGGAADPBEP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public LBOKBPPLKEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x259D7B0", Offset = "0x259CBB0", VA = "0x18259D7B0")]
			internal bool CPIPOALEILF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x259D800", Offset = "0x259CC00", VA = "0x18259D800")]
			internal void FLGHMPLIDOG(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x2586D30", Offset = "0x2586130", VA = "0x182586D30")]
		public ADGGAADPBEP(NKCIHNNLLKD JGDGFDJAHBD, GBJNKKFOGHF FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x2586B50", Offset = "0x2585F50", VA = "0x182586B50", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class GFBCONBODGG : KHLCMDBOIHF<EDLCIICIAAB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class NMMHMBGCCDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public GFBCONBODGG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public NMMHMBGCCDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x25A1070", Offset = "0x25A0470", VA = "0x1825A1070")]
			internal int CPIPOALEILF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x25A10C0", Offset = "0x25A04C0", VA = "0x1825A10C0")]
			internal void FLGHMPLIDOG(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x259AAD0", Offset = "0x2599ED0", VA = "0x18259AAD0")]
		public GFBCONBODGG(NKCIHNNLLKD JGDGFDJAHBD, EDLCIICIAAB FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x259A860", Offset = "0x2599C60", VA = "0x18259A860", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class AHGJPNIBOBI : HGHCPKPHDKE<BBPCPKOCBME>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override HJOAEGEOEOA ACIKPPGGAOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xACC550", Offset = "0xACB950", VA = "0x180ACC550", Slot = "140")]
			get
			{
				return default(HJOAEGEOEOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x2587050", Offset = "0x2586450", VA = "0x182587050")]
		public AHGJPNIBOBI(NKCIHNNLLKD JGDGFDJAHBD, BBPCPKOCBME FBFIKJCNBGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class GLLAAOBNFEL : KHLCMDBOIHF<PEEGBFKPCLP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x259B310", Offset = "0x259A710", VA = "0x18259B310")]
		public GLLAAOBNFEL(NKCIHNNLLKD JGDGFDJAHBD, PEEGBFKPCLP IKAPMMHHNFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public abstract class KHLCMDBOIHF<TNode> : AGCPOGDEIKB, IDisposable where TNode : notnull, PEEGBFKPCLP
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class DNDIHFIMJLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public KHLCMDBOIHF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public NKCIHNNLLKD circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public DNDIHFIMJLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x640E530", Offset = "0x640D930", VA = "0x18640E530")]
			internal DKHLMIDBOAM AAADALBHBLJ(OPIMDIFADKK portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private struct KLLDHGKAMMO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public KHLCMDBOIHF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x4B35AE0", Offset = "0x4B34EE0", VA = "0x184B35AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private struct PKECFCJKJPM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public KHLCMDBOIHF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public INFNEOIMIIP? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public HLENJKBPEOD? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x50CA470", Offset = "0x50C9870", VA = "0x1850CA470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x50CA710", Offset = "0x50C9B10", VA = "0x1850CA710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class JGBAIHHILEL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000091")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C2")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C3")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C4")]
				public JGBAIHHILEL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0x3D580D0", Offset = "0x3D574D0", VA = "0x183D580D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public KHLCMDBOIHF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public PJCGMMMJNCL configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public JGBAIHHILEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
			internal string OBKFJKJIKCA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
			internal void PDONPJBEKGF(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x4A10790", Offset = "0x4A0FB90", VA = "0x184A10790")]
			[AsyncStateMachine(typeof(KHLCMDBOIHF<>.JGBAIHHILEL.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void IAIBBAIKAEM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private sealed class HPFEJKFOCGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public HPFEJKFOCGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x475D0E0", Offset = "0x475C4E0", VA = "0x18475D0E0")]
			internal bool DPOKPDMCFJM(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x475D1C0", Offset = "0x475C5C0", VA = "0x18475D1C0")]
			internal bool OEAAAEAFAGC(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private struct LLCIFFGLCAC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public KHLCMDBOIHF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x4C126E0", Offset = "0x4C11AE0", VA = "0x184C126E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x4C12A60", Offset = "0x4C11E60", VA = "0x184C12A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private readonly NKCIHNNLLKD GCLOKDKLDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private readonly bool DHJOHEDEIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private MANIMEFDFFM<OPLLODEDJNC, DKHLMIDBOAM> PGPPPBKBPBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private MANIMEFDFFM<OPLLODEDJNC, FCJCPEMKLMP> MAEMBJMNICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private List<Action> FFBGBLCOIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[CompilerGenerated]
		private Action<DDIPAIMAGGM<OPLLODEDJNC>>? GHFHKNILEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[CompilerGenerated]
		private Action<DDIPAIMAGGM<OPLLODEDJNC>, FCJCPEMKLMP>? PHHBCNBPFBM;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected HCCJEMAFJIA NCDLPEGHBIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x4B20980", Offset = "0x4B1FD80", VA = "0x184B20980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		protected IMGPKAMKKBB LFFDCGGNCMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x4B23500", Offset = "0x4B22900", VA = "0x184B23500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected TNode NDKCPGBFCLM
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public IIIMCLEJECC<PKJLNCOHJCL> BOFOCOLODFB
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x11D8480", Offset = "0x11D7880", VA = "0x1811D8480", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(IIIMCLEJECC<PKJLNCOHJCL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DDIPAIMAGGM<KBGLEEGJHEA> JOPFEBDIBKL
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x4B24640", Offset = "0x4B23A40", VA = "0x184B24640", Slot = "6")]
			get
			{
				return default(DDIPAIMAGGM<KBGLEEGJHEA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public object DPIDLKACMMH
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x411D450", Offset = "0x411C850", VA = "0x18411D450", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual bool HAECNMNCLAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int HCJHNHMBDDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x4B242A0", Offset = "0x4B236A0", VA = "0x184B242A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public IPJFNEFALHK GJJNJPBJJBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x4B24240", Offset = "0x4B23640", VA = "0x184B24240", Slot = "10")]
			get
			{
				return default(IPJFNEFALHK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string OIAELNHANLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x4B24840", Offset = "0x4B23C40", VA = "0x184B24840", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual bool CEKNFLAGCAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public DDIPAIMAGGM<GFJIOFKBLLH> KKKMBMDFNPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xD32200", Offset = "0xD31600", VA = "0x180D32200", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(DDIPAIMAGGM<GFJIOFKBLLH>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0xD46180", Offset = "0xD45580", VA = "0x180D46180")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual bool ACELIPDCFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual bool OGGGHKEJEKI
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool GPNDAFEAGEK
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual MNGAIPCHADO NNJHGMGCBEE
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xE05BB0", Offset = "0xE04FB0", VA = "0x180E05BB0", Slot = "108")]
			get
			{
				return default(MNGAIPCHADO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool FFFCLOFFBCE
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x4B23FB0", Offset = "0x4B233B0", VA = "0x184B23FB0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool ANBEPDJAFGE
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x4B24010", Offset = "0x4B23410", VA = "0x184B24010", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool OBAGOLHBGEB
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x4B24070", Offset = "0x4B23470", VA = "0x184B24070", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int MHGJKCMKHFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x4B245F0", Offset = "0x4B239F0", VA = "0x184B245F0", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool OLJAEENGLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x4B24420", Offset = "0x4B23820", VA = "0x184B24420", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool EJJKCCNBJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x4B24180", Offset = "0x4B23580", VA = "0x184B24180", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool AAFJJDKGBIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x4B24120", Offset = "0x4B23520", VA = "0x184B24120", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool CPJEPPEMNJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0xDE0C70", Offset = "0xDE0070", VA = "0x180DE0C70", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x119F9B0", Offset = "0x119EDB0", VA = "0x18119F9B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool AGOINPJHDBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public virtual bool HEEOLDEADPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x4B240D0", Offset = "0x4B234D0", VA = "0x184B240D0", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool FIOJNGHHNLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x4B24350", Offset = "0x4B23750", VA = "0x184B24350", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public INFNEOIMIIP FCBPBALDGPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x4B24530", Offset = "0x4B23930", VA = "0x184B24530", Slot = "29")]
			get
			{
				return default(INFNEOIMIIP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public HLENJKBPEOD OFMDIGBJIDB
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x4B24590", Offset = "0x4B23990", VA = "0x184B24590", Slot = "31")]
			get
			{
				return default(HLENJKBPEOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual bool BGFCFAGFDHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public virtual NMMANGPDHIA? ICLLJOAAHOC
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "123")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual DNDLFOONKGP? HKAACFHNBNI
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public virtual IEnumerable<IIIMCLEJECC<MJBBEHHNFNA>>? MPLILGDKHMF
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool LCBHAHKHLMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x4B241E0", Offset = "0x4B235E0", VA = "0x184B241E0", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public IIIMCLEJECC<HFJKEPEKFIF> MKPDHOJMMKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x4B24470", Offset = "0x4B23870", VA = "0x184B24470", Slot = "63")]
			get
			{
				return default(IIIMCLEJECC<HFJKEPEKFIF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public DDIPAIMAGGM<HFJKEPEKFIF> MBEHCCKGFJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x4B242F0", Offset = "0x4B236F0", VA = "0x184B242F0", Slot = "57")]
			get
			{
				return default(DDIPAIMAGGM<HFJKEPEKFIF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public virtual bool FBCJBPCIHBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public virtual DDIPAIMAGGM<HFJKEPEKFIF>? JPDOACLBPGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public virtual bool FMNGOENBMPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool MMGHCJICOJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x4B243B0", Offset = "0x4B237B0", VA = "0x184B243B0", Slot = "62")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x971410", Offset = "0x970810", VA = "0x180971410", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x971400", Offset = "0x970800", VA = "0x180971400")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public string JHMMFNPLCEL
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x9712F0", Offset = "0x9706F0", VA = "0x1809712F0", Slot = "67")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x9712E0", Offset = "0x9706E0", VA = "0x1809712E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public DDIPAIMAGGM<MJBBEHHNFNA> CDGNDGKCOFK
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x4B246C0", Offset = "0x4B23AC0", VA = "0x184B246C0", Slot = "64")]
			get
			{
				return default(DDIPAIMAGGM<MJBBEHHNFNA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public IIIMCLEJECC<MJBBEHHNFNA> CLDOMJKGKCC
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x4B244D0", Offset = "0x4B238D0", VA = "0x184B244D0", Slot = "65")]
			get
			{
				return default(IIIMCLEJECC<MJBBEHHNFNA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public IIIMCLEJECC<MJBBEHHNFNA>? FJNFIFEAFHI
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x4B24720", Offset = "0x4B23B20", VA = "0x184B24720", Slot = "132")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public IHDDGPKENBI<OPLLODEDJNC, FCJCPEMKLMP> DDEOFKPIDMG
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x4B24800", Offset = "0x4B23C00", VA = "0x184B24800", Slot = "68")]
			get
			{
				return default(IHDDGPKENBI<OPLLODEDJNC, FCJCPEMKLMP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public virtual DDIPAIMAGGM<OPLLODEDJNC>? MDBKBOLEHOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public virtual bool NCEOFBCMLPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public virtual bool DCPMPOGAHOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "137")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action BFLGHLFLNCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x4B21D20", Offset = "0x4B21120", VA = "0x184B21D20", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x4B22380", Offset = "0x4B21780", VA = "0x184B22380", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event EDCALCKDCOA ABMHEAKHKBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x4B21570", Offset = "0x4B20970", VA = "0x184B21570", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x4B235F0", Offset = "0x4B229F0", VA = "0x184B235F0", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event NEFHMJFODJP PDANPJCCMHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x4B20F70", Offset = "0x4B20370", VA = "0x184B20F70", Slot = "42")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x4B1FBC0", Offset = "0x4B1EFC0", VA = "0x184B1FBC0", Slot = "43")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action CFBMLMKELMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x4B21290", Offset = "0x4B20690", VA = "0x184B21290", Slot = "44")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x4B20F10", Offset = "0x4B20310", VA = "0x184B20F10", Slot = "45")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action HNIDEFDJPNI
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x4B20110", Offset = "0x4B1F510", VA = "0x184B20110", Slot = "46")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x4B1FCF0", Offset = "0x4B1F0F0", VA = "0x184B1FCF0", Slot = "47")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<DDIPAIMAGGM<OPLLODEDJNC>, FCJCPEMKLMP> IPDEPDEBJIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x4B210E0", Offset = "0x4B204E0", VA = "0x184B210E0", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x4B216E0", Offset = "0x4B20AE0", VA = "0x184B216E0", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<DDIPAIMAGGM<OPLLODEDJNC>, FCJCPEMKLMP> NFPPKIMDHLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x4B21BF0", Offset = "0x4B20FF0", VA = "0x184B21BF0", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x4B211D0", Offset = "0x4B205D0", VA = "0x184B211D0", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<DDIPAIMAGGM<OPLLODEDJNC>> KEJGIPJDLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x4B1FF00", Offset = "0x4B1F300", VA = "0x184B1FF00", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x4B22900", Offset = "0x4B21D00", VA = "0x184B22900", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<DDIPAIMAGGM<OPLLODEDJNC>, DDIPAIMAGGM<OPLLODEDJNC>> HICAEJAIAFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x4B202D0", Offset = "0x4B1F6D0", VA = "0x184B202D0", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x4B1F660", Offset = "0x4B1EA60", VA = "0x184B1F660", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<DDIPAIMAGGM<OPLLODEDJNC>, FCJCPEMKLMP> IHBLIGCADHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x4B217E0", Offset = "0x4B20BE0", VA = "0x184B217E0", Slot = "78")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x4B23440", Offset = "0x4B22840", VA = "0x184B23440", Slot = "79")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<DDIPAIMAGGM<OPLLODEDJNC>, DDIPAIMAGGM<OPLLODEDJNC>> BKFOBAFNFEG
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x4B21360", Offset = "0x4B20760", VA = "0x184B21360", Slot = "80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x4B229C0", Offset = "0x4B21DC0", VA = "0x184B229C0", Slot = "81")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x4B239D0", Offset = "0x4B22DD0", VA = "0x184B239D0")]
		[FDIEMNELNCN("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[FDIEMNELNCN("Need to handle `Name` better.")]
		protected KHLCMDBOIHF(NKCIHNNLLKD JGDGFDJAHBD, TNode IKAPMMHHNFM, bool GDIAMNAENEJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x4B22AF0", Offset = "0x4B21EF0", VA = "0x184B22AF0", Slot = "100")]
		protected virtual void OBBALIPJEND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x4B20390", Offset = "0x4B1F790", VA = "0x184B20390", Slot = "101")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x4B22D90", Offset = "0x4B22190", VA = "0x184B22D90", Slot = "9")]
		[AsyncStateMachine(typeof(KHLCMDBOIHF<>.KLLDHGKAMMO))]
		public void OJGLEFEDMBO(int LGPCJJCBKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x4B218A0", Offset = "0x4B20CA0", VA = "0x184B218A0")]
		public bool JCLACOBMOAF([In] INFNEOIMIIP PEBNJNGMMHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x4B22A80", Offset = "0x4B21E80", VA = "0x184B22A80")]
		public bool NPDBENHOFIG([In] HLENJKBPEOD PEBNJNGMMHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x4B21F70", Offset = "0x4B21370", VA = "0x184B21F70", Slot = "33")]
		public void KMABNHANOIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x4B1FFC0", Offset = "0x4B1F3C0", VA = "0x184B1FFC0", Slot = "34")]
		[AsyncStateMachine(typeof(KHLCMDBOIHF<>.PKECFCJKJPM))]
		public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> CPBJIOHGBDA(INFNEOIMIIP? ODMGDEIMGFO, HLENJKBPEOD? NNFHCIFKIPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "111")]
		public virtual void CEPBEAMLMCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "112")]
		public virtual void LIOKEDNOLOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "113")]
		public virtual void FJOLLFFIADA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xDAFC50", Offset = "0xDAF050", VA = "0x180DAFC50")]
		protected void JEMBKHOAPNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xE00210", Offset = "0xDFF610", VA = "0x180E00210")]
		protected void DBAPJKFCOGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x4B1FEE0", Offset = "0x4B1F2E0", VA = "0x184B1FEE0")]
		private void CPBEIHLPLHF([In] HLENJKBPEOD NBFJKGINHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x4B21610", Offset = "0x4B20A10", VA = "0x184B21610", Slot = "114")]
		public virtual Task<PHLGGJNOBDN<DDIPAIMAGGM<OPLLODEDJNC>, MEENKFHCKIP>> ICEGCFLOLFA(string OGOCCCFKJPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x4B21010", Offset = "0x4B20410", VA = "0x184B21010", Slot = "115")]
		public virtual Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> GKOCFAONMMO(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "116")]
		public virtual void EIFEGDIJDOC(DDIPAIMAGGM<OPLLODEDJNC> MJBMIGBCBJA, DDIPAIMAGGM<OPLLODEDJNC> NMOJJMPFOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x4B23940", Offset = "0x4B22D40", VA = "0x184B23940", Slot = "117")]
		public virtual IEnumerable<CLANKEGLHHM> PPMMPIOGLAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x4B1FC60", Offset = "0x4B1F060", VA = "0x184B1FC60", Slot = "118")]
		public PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP> CFHMABBJKIH(string KOLLPJNEOCL)
		{
			return default(PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x4B21420", Offset = "0x4B20820", VA = "0x184B21420", Slot = "48")]
		public bool HDOBAFPDHGG([Out] Guid IFBMLAJKEHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x4B23690", Offset = "0x4B22A90", VA = "0x184B23690")]
		public bool PNDHDDANNBO([In] Guid BPHNGBDIGAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "119")]
		public virtual void HKGADJFONBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "120")]
		public virtual void NGOFAFMPMPD(bool LHHNJCGNCHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "121")]
		public virtual FJFCPKPDMFC LGHOJFJOFNH([In] GANEENEPNCE JAFDJNEKCIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x4B22130", Offset = "0x4B21530", VA = "0x184B22130")]
		protected void LGMPCGLEAAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x4B1F770", Offset = "0x4B1EB70", VA = "0x184B1F770", Slot = "126")]
		protected virtual bool AOMMJIEMHAI(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x4B211A0", Offset = "0x4B205A0", VA = "0x184B211A0", Slot = "89")]
		public bool GOPMODCBOIH(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "127")]
		protected virtual bool FDACKGKKFPH(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "134")]
		protected virtual void CNDJIIPHNLN(PJCGMMMJNCL FKHODJHJOPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x4B22420", Offset = "0x4B21820", VA = "0x184B22420")]
		protected void MNBDFGBBOIO(PJCGMMMJNCL JBEBACPNGMO, Func<string> CFLPHAHOGEE, Action<string> GGMPNFMCEBM, string OLAMBIADHEB, string OGDGKHPFKJF, string MCPOLPDCHMJ, FEANGHIEHJA KFDEBFGMKIG, ICILMGKOOJF POJOCCGMCMH, Func<string, bool> NNHGGIHKBNK, string MJMPMPIDBPJ, Func<string, bool> LHFFIFMJJAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x4B21910", Offset = "0x4B20D10", VA = "0x184B21910")]
		protected void JKPIKJGLACL(PJCGMMMJNCL JBEBACPNGMO, Func<string> CFLPHAHOGEE, Action<string> GGMPNFMCEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x4B21DC0", Offset = "0x4B211C0", VA = "0x184B21DC0", Slot = "135")]
		protected virtual void KLJLFKKOJEE(PJCGMMMJNCL JBEBACPNGMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x4B1F720", Offset = "0x4B1EB20", VA = "0x184B1F720", Slot = "83")]
		public void AMAJONAILGF(PJCGMMMJNCL JBEBACPNGMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x4B22810", Offset = "0x4B21C10", VA = "0x184B22810", Slot = "84")]
		public IJJACHJMKKP NEDCPBHOFEO()
		{
			return default(IJJACHJMKKP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "138")]
		public virtual bool DBBDGGPKCAM(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x1D793F0", Offset = "0x1D787F0", VA = "0x181D793F0")]
		private void FPEDJPLHNHM([In] INFNEOIMIIP HJBDDDIFEBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x4B1FD90", Offset = "0x4B1F190", VA = "0x184B1FD90")]
		private void CMJHEICGJDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x4B217A0", Offset = "0x4B20BA0", VA = "0x184B217A0", Slot = "90")]
		private void IGDLANEEHAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x4B22E40", Offset = "0x4B22240", VA = "0x184B22E40", Slot = "92")]
		private void OOODFJIANGI(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xF37100", Offset = "0xF36500", VA = "0x180F37100", Slot = "94")]
		private void BGDEOJCBCGO(DDIPAIMAGGM<OPLLODEDJNC> NNKBGKICBEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x4B20790", Offset = "0x4B1FB90", VA = "0x184B20790", Slot = "96")]
		private void EFNMHOGMBAK(DDIPAIMAGGM<OPLLODEDJNC> NNKBGKICBEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x4B1F7B0", Offset = "0x4B1EBB0", VA = "0x184B1F7B0", Slot = "97")]
		private void BBKOICIIJCA(DDIPAIMAGGM<OPLLODEDJNC> MJBMIGBCBJA, DDIPAIMAGGM<OPLLODEDJNC> NMOJJMPFOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xF37120", Offset = "0xF36520", VA = "0x180F37120", Slot = "98")]
		private void FDKKCEHLJKA(DDIPAIMAGGM<OPLLODEDJNC> MJBMIGBCBJA, DDIPAIMAGGM<OPLLODEDJNC> NMOJJMPFOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x4B1FBA0", Offset = "0x4B1EFA0", VA = "0x184B1FBA0", Slot = "91")]
		private void BLLOICMAMNN(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x4B20AF0", Offset = "0x4B1FEF0", VA = "0x184B20AF0", Slot = "93")]
		private void FGLPPGJIALC(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x4B20A80", Offset = "0x4B1FE80", VA = "0x184B20A80", Slot = "95")]
		private void FGIBIBGIAAA(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x4B201B0", Offset = "0x4B1F5B0", VA = "0x184B201B0", Slot = "139")]
		[AsyncStateMachine(typeof(KHLCMDBOIHF<>.LLCIFFGLCAC))]
		public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> DEPHIFOPDJC(string KOLLPJNEOCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x4B22310", Offset = "0x4B21710", VA = "0x184B22310", Slot = "55")]
		private void MMHJBDAKPOD(object CNFNOOCKANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x4B21CB0", Offset = "0x4B210B0", VA = "0x184B21CB0", Slot = "56")]
		private void JPFDIAFNAOH(object CNFNOOCKANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x4110790", Offset = "0x410FB90", VA = "0x184110790", Slot = "30")]
		private bool EKHHFPKFFNO([In] INFNEOIMIIP PEBNJNGMMHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x4B20940", Offset = "0x4B1FD40", VA = "0x184B20940", Slot = "32")]
		private bool EJNAFGOEIEA([In] HLENJKBPEOD PEBNJNGMMHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x4B23400", Offset = "0x4B22800", VA = "0x184B23400", Slot = "49")]
		private bool PABOIMFAAGJ([In] Guid BPHNGBDIGAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x4B1FB60", Offset = "0x4B1EF60", VA = "0x184B1FB60")]
		[CompilerGenerated]
		private string BFJEAJAOFHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x4B209E0", Offset = "0x4B1FDE0", VA = "0x184B209E0")]
		[CompilerGenerated]
		private void FEEOIILDJLF(string OGOCCCFKJPG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class NIDHLEAKEPK : DEGCEMHKMIO<OGKGGCDKNDK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0xC987F0", Offset = "0xC97BF0", VA = "0x180C987F0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x25A03D0", Offset = "0x259F7D0", VA = "0x1825A03D0")]
		public NIDHLEAKEPK(NKCIHNNLLKD JGDGFDJAHBD, OGKGGCDKNDK IKAPMMHHNFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class LBCKENCGLCI : NPGKLDLHHMJ<GGOMEOOKLBF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0xACC550", Offset = "0xACB950", VA = "0x180ACC550", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x259D750", Offset = "0x259CB50", VA = "0x18259D750")]
		public LBCKENCGLCI(NKCIHNNLLKD JGDGFDJAHBD, GGOMEOOKLBF IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public abstract class HGHCPKPHDKE<T> : KHLCMDBOIHF<T> where T : notnull, EOOHKEFJIHK
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class JCJCLFONCOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public IReadOnlyList<KeyValuePair<string, BFNODLBAELJ>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public HGHCPKPHDKE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public HJOAEGEOEOA clipType;

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public JCJCLFONCOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
			internal IReadOnlyList<KeyValuePair<string, BFNODLBAELJ>> CPIPOALEILF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x49F8530", Offset = "0x49F7930", VA = "0x1849F8530")]
			internal int FLGHMPLIDOG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x49F82C0", Offset = "0x49F76C0", VA = "0x1849F82C0")]
			internal void EPKLEDOALFO(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x49F8790", Offset = "0x49F7B90", VA = "0x1849F8790")]
			internal void LLPEOFFHJAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x49F87E0", Offset = "0x49F7BE0", VA = "0x1849F87E0")]
			internal void MLACHNNPFGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x49F8230", Offset = "0x49F7630", VA = "0x1849F8230")]
			internal bool BFELNAFNPCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x49F89F0", Offset = "0x49F7DF0", VA = "0x1849F89F0")]
			internal void NNDKFPHCDMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x49F8230", Offset = "0x49F7630", VA = "0x1849F8230")]
			internal bool OOMNEMKOEAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x49F8680", Offset = "0x49F7A80", VA = "0x1849F8680")]
			internal float JEFNFEHICCE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x49F8A40", Offset = "0x49F7E40", VA = "0x1849F8A40")]
			internal void PDBBEEKCDGB(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x49F84E0", Offset = "0x49F78E0", VA = "0x1849F84E0")]
			internal float FHJOKNPINOA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x49F8930", Offset = "0x49F7D30", VA = "0x1849F8930")]
			internal void NBEMADGGLJP(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x49F8B00", Offset = "0x49F7F00", VA = "0x1849F8B00")]
			internal float PDLHGBKKCKH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x49F86D0", Offset = "0x49F7AD0", VA = "0x1849F86D0")]
			internal void JMDNDEMMFKB(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0xF40A90", Offset = "0xF3FE90", VA = "0x180F40A90", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public abstract HJOAEGEOEOA ACIKPPGGAOA
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(Slot = "140")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x474A170", Offset = "0x4749570", VA = "0x18474A170")]
		public HGHCPKPHDKE(NKCIHNNLLKD JGDGFDJAHBD, T IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x47496C0", Offset = "0x4748AC0", VA = "0x1847496C0", Slot = "134")]
		protected sealed override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private sealed class CPJPKNPOMFH : KHLCMDBOIHF<JFDMHJMJCNH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0xC98EC0", Offset = "0xC982C0", VA = "0x180C98EC0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x2590D60", Offset = "0x2590160", VA = "0x182590D60")]
		public CPJPKNPOMFH(NKCIHNNLLKD JGDGFDJAHBD, JFDMHJMJCNH IKAPMMHHNFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class MFOFMKLFEMO : KHLCMDBOIHF<GJDFDIGLPEG>
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class MNAAHNKJGKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public MFOFMKLFEMO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public MNAAHNKJGKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x259F350", Offset = "0x259E750", VA = "0x18259F350")]
			internal int FLGHMPLIDOG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x259F2C0", Offset = "0x259E6C0", VA = "0x18259F2C0")]
			internal void EPKLEDOALFO(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static Dictionary<string, BFNODLBAELJ>? ILEBFIJJMDB;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x259EA40", Offset = "0x259DE40", VA = "0x18259EA40")]
		public MFOFMKLFEMO(NKCIHNNLLKD JGDGFDJAHBD, GJDFDIGLPEG IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x259E6D0", Offset = "0x259DAD0", VA = "0x18259E6D0", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class JPCBMNIFEKE : HGHCPKPHDKE<NIHIDHEAGHG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override HJOAEGEOEOA ACIKPPGGAOA
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "140")]
			get
			{
				return default(HJOAEGEOEOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x259D5D0", Offset = "0x259C9D0", VA = "0x18259D5D0")]
		public JPCBMNIFEKE(NKCIHNNLLKD JGDGFDJAHBD, NIHIDHEAGHG FBFIKJCNBGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private sealed class AJMGDGEEFOC : NPGKLDLHHMJ<OPMABLHEPDP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0xACC550", Offset = "0xACB950", VA = "0x180ACC550", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x25874C0", Offset = "0x25868C0", VA = "0x1825874C0")]
		public AJMGDGEEFOC(NKCIHNNLLKD JGDGFDJAHBD, OPMABLHEPDP IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private sealed class KALHAKGDJGH : NPGKLDLHHMJ<IOAIBAJLMIO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0xACC550", Offset = "0xACB950", VA = "0x180ACC550", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x259D630", Offset = "0x259CA30", VA = "0x18259D630")]
		public KALHAKGDJGH(NKCIHNNLLKD JGDGFDJAHBD, IOAIBAJLMIO IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class BGFHCDIDHHE : MLAHPDHAGLC<MDBNBBAGJMP>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private sealed class JEFMMNCFOFK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000A1")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D9")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001DA")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001DB")]
				public JEFMMNCFOFK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001DC")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001DD")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001DE")]
				private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x25A2B60", Offset = "0x25A1F60", VA = "0x1825A2B60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D9")]
				[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public BGFHCDIDHHE <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public JEFMMNCFOFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x259BB60", Offset = "0x259AF60", VA = "0x18259BB60")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void POAKGAFIMML(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2588870", Offset = "0x2587C70", VA = "0x182588870")]
		public BGFHCDIDHHE(NKCIHNNLLKD JGDGFDJAHBD, MDBNBBAGJMP FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2588590", Offset = "0x2587990", VA = "0x182588590", Slot = "140")]
		protected override void NNBPHDJICKE(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public sealed class BKJCBNIJGPP : HGHCPKPHDKE<OCJPJPMGBAA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public override HJOAEGEOEOA ACIKPPGGAOA
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xAB2660", Offset = "0xAB1A60", VA = "0x180AB2660", Slot = "140")]
			get
			{
				return default(HJOAEGEOEOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x25888D0", Offset = "0x2587CD0", VA = "0x1825888D0")]
		public BKJCBNIJGPP(NKCIHNNLLKD JGDGFDJAHBD, OCJPJPMGBAA FBFIKJCNBGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private sealed class CLOKLBIPBCH : KHLCMDBOIHF<PLFHHEJDIHB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xC685D0", Offset = "0xC679D0", VA = "0x180C685D0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2590CF0", Offset = "0x25900F0", VA = "0x182590CF0")]
		public CLOKLBIPBCH(NKCIHNNLLKD JGDGFDJAHBD, PLFHHEJDIHB IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class HABAHKFLOKM : KHLCMDBOIHF<IBNNEHEHDLG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public sealed override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public sealed override bool OGGGHKEJEKI
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected sealed override bool CEKNFLAGCAK
		{
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x259B6F0", Offset = "0x259AAF0", VA = "0x18259B6F0")]
		public HABAHKFLOKM(NKCIHNNLLKD JGDGFDJAHBD, IBNNEHEHDLG IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x259B380", Offset = "0x259A780", VA = "0x18259B380", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x259B6B0", Offset = "0x259AAB0", VA = "0x18259B6B0")]
		private int GPINNKNPGBA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x259B650", Offset = "0x259AA50", VA = "0x18259B650")]
		private void DMDLFIOFPNP(int BJDHLMBEIKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class OKANHGPIAOD : GLLAAOBNFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x259B310", Offset = "0x259A710", VA = "0x18259B310")]
		public OKANHGPIAOD(NKCIHNNLLKD JGDGFDJAHBD, PEEGBFKPCLP IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class FPKALHPLJDH : MLAHPDHAGLC<INDKCDNEACG>
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x2598B00", Offset = "0x2597F00", VA = "0x182598B00")]
		public FPKALHPLJDH(NKCIHNNLLKD JGDGFDJAHBD, INDKCDNEACG IKAPMMHHNFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public abstract class MLAHPDHAGLC<TVariableNode> : KHLCMDBOIHF<TVariableNode> where TVariableNode : notnull, INDKCDNEACG
	{
		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class EDJAABAGBNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public MLAHPDHAGLC<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public EDJAABAGBNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x40E8010", Offset = "0x40E7410", VA = "0x1840E8010")]
			internal bool CPIPOALEILF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x40E80D0", Offset = "0x40E74D0", VA = "0x1840E80D0")]
			internal void FLGHMPLIDOG(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x40E8070", Offset = "0x40E7470", VA = "0x1840E8070")]
			internal bool EPKLEDOALFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x40E8190", Offset = "0x40E7590", VA = "0x1840E8190")]
			internal void LLPEOFFHJAI(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x40E8250", Offset = "0x40E7650", VA = "0x1840E8250")]
			internal bool MLACHNNPFGB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		[CompilerGenerated]
		private sealed class OJDKBDOHDIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public IMGPKAMKKBB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public MLAHPDHAGLC<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public OJDKBDOHDIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x4FABD00", Offset = "0x4FAB100", VA = "0x184FABD00")]
			internal void POAKGAFIMML(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public override NodeVisualizationKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0xAD6ED0", Offset = "0xAD62D0", VA = "0x180AD6ED0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public override MNGAIPCHADO NNJHGMGCBEE
		{
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x4E0B6A0", Offset = "0x4E0AAA0", VA = "0x184E0B6A0", Slot = "108")]
			get
			{
				return default(MNGAIPCHADO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x4E0B500", Offset = "0x4E0A900", VA = "0x184E0B500")]
		protected MLAHPDHAGLC(NKCIHNNLLKD JGDGFDJAHBD, TVariableNode IKAPMMHHNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x4E0AF10", Offset = "0x4E0A310", VA = "0x184E0AF10", Slot = "101")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x4E0AA80", Offset = "0x4E09E80", VA = "0x184E0AA80", Slot = "134")]
		protected override void CNDJIIPHNLN(PJCGMMMJNCL JBEBACPNGMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x4E0B180", Offset = "0x4E0A580", VA = "0x184E0B180", Slot = "140")]
		protected virtual void NNBPHDJICKE(PJCGMMMJNCL JBEBACPNGMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x4E0B090", Offset = "0x4E0A490", VA = "0x184E0B090", Slot = "119")]
		public override void HKGADJFONBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x256CE80", Offset = "0x256C280", VA = "0x18256CE80")]
	public static AGCPOGDEIKB KMDIICJFNJF(NKCIHNNLLKD JGDGFDJAHBD, PEEGBFKPCLP IKAPMMHHNFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class BMBACLHJLDJ : ECMFCMJBHKI, JHLFHOPFFDM, GPCJCODIIKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public DDIPAIMAGGM<BIIAPNECPOC> MPPPMJMKLDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xC5B340", Offset = "0xC5A740", VA = "0x180C5B340", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(DDIPAIMAGGM<BIIAPNECPOC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DDIPAIMAGGM<BFEMAIFODOI> NELHILILFKP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xD50470", Offset = "0xD4F870", VA = "0x180D50470", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(DDIPAIMAGGM<BFEMAIFODOI>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2588CD0", Offset = "0x25880D0", VA = "0x182588CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private DDIPAIMAGGM<EGDOMAELJCE> DDAMPIGPFBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xC5B8C0", Offset = "0xC5ACC0", VA = "0x180C5B8C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public override DDIPAIMAGGM<OKNMLBCIJPN> PJBPAIBDABE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x2588930", Offset = "0x2587D30", VA = "0x182588930", Slot = "21")]
		get
		{
			return default(DDIPAIMAGGM<OKNMLBCIJPN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2588CE0", Offset = "0x25880E0", VA = "0x182588CE0")]
	private BMBACLHJLDJ(NKCIHNNLLKD JGDGFDJAHBD, PEEGBFKPCLP IKAPMMHHNFM, MANGDHOAEGH MEAECCADDKB, DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, DDIPAIMAGGM<BFEMAIFODOI> BFKOLDCFMBJ, DDIPAIMAGGM<EGDOMAELJCE> BLINDGLNPJJ, bool KMLPACPOEJE, string OGOCCCFKJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2588980", Offset = "0x2587D80", VA = "0x182588980")]
	public static BMBACLHJLDJ KMDIICJFNJF(NKCIHNNLLKD JGDGFDJAHBD, PEEGBFKPCLP IKAPMMHHNFM, MANGDHOAEGH NJJHNKHIEKN, DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, DDIPAIMAGGM<EGDOMAELJCE> BLINDGLNPJJ, DDIPAIMAGGM<BFEMAIFODOI> BFKOLDCFMBJ, bool KMLPACPOEJE, bool GDIAMNAENEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2588CD0", Offset = "0x25880D0", VA = "0x182588CD0")]
	internal void OJEOCGCKOHP(DDIPAIMAGGM<BFEMAIFODOI> PEBNJNGMMHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public abstract class ECMFCMJBHKI : GPCJCODIIKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private struct IIHFEEFMGKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private DJLNGMHBIKC? HNPGCHOMPJF;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x259B920", Offset = "0x259AD20", VA = "0x18259B920")]
		public void JIMFDDOIBMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x259B880", Offset = "0x259AC80", VA = "0x18259B880")]
		public DJLNGMHBIKC FEIPCMIIEPK(ECMFCMJBHKI KFDNONKACFA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	protected readonly NKCIHNNLLKD GCLOKDKLDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	protected readonly PEEGBFKPCLP BMFFCIGONLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private IIHFEEFMGKN CGPDFIHNLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private readonly FGGBPBKEMME EDBOGGLLAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private readonly List<ANAJOLMCKLN> GODJNMLDJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly List<PIKBMIOJHGL> NOAFKHOHPIJ;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	[FDIEMNELNCN("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> IPJMIHFLIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x25971C0", Offset = "0x25965C0", VA = "0x1825971C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public DisplayKind COPECOEMGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x975090", Offset = "0x974490", VA = "0x180975090", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public DDIPAIMAGGM<HFJKEPEKFIF> MBEHCCKGFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x2596280", Offset = "0x2595680", VA = "0x182596280", Slot = "6")]
		get
		{
			return default(DDIPAIMAGGM<HFJKEPEKFIF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public IIIMCLEJECC<HFJKEPEKFIF> MKPDHOJMMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x2596600", Offset = "0x2595A00", VA = "0x182596600", Slot = "7")]
		get
		{
			return default(IIIMCLEJECC<HFJKEPEKFIF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public GBHOAMIGJIM HPPFNAPDABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xC3A550", Offset = "0xC39950", VA = "0x180C3A550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public GHGFNKIPOAK DIDLPBMJNOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x2596010", Offset = "0x2595410", VA = "0x182596010", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	protected DJLNGMHBIKC ENKLBOBDBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x2596010", Offset = "0x2595410", VA = "0x182596010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public PortImage JPAJBCAKIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x25962B0", Offset = "0x25956B0", VA = "0x1825962B0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public string NAMECGEJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x96A720", Offset = "0x969B20", VA = "0x18096A720", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x96A970", Offset = "0x969D70", VA = "0x18096A970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IIIMCLEJECC<MJBBEHHNFNA> CLDOMJKGKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x25960B0", Offset = "0x25954B0", VA = "0x1825960B0", Slot = "9")]
		get
		{
			return default(IIIMCLEJECC<MJBBEHHNFNA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public DDIPAIMAGGM<OPLLODEDJNC> BMFMCPBKKEA
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xC23280", Offset = "0xC22680", VA = "0x180C23280", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(DDIPAIMAGGM<OPLLODEDJNC>);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xD4FFA0", Offset = "0xD4F3A0", VA = "0x180D4FFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public abstract DDIPAIMAGGM<OKNMLBCIJPN> PJBPAIBDABE
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2597300", Offset = "0x2596700", VA = "0x182597300")]
	protected ECMFCMJBHKI(NKCIHNNLLKD JGDGFDJAHBD, PEEGBFKPCLP IKAPMMHHNFM, FGGBPBKEMME NFLKFIGLIHM, DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, bool KMLPACPOEJE, string OGOCCCFKJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x25970D0", Offset = "0x25964D0", VA = "0x1825970D0", Slot = "22")]
	protected virtual void OBBALIPJEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x2596130", Offset = "0x2595530", VA = "0x182596130", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x25960D0", Offset = "0x25954D0", VA = "0x1825960D0", Slot = "14")]
	public void CNPHPJHMGBF(ANAJOLMCKLN PEPKMEKLMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2596630", Offset = "0x2595A30", VA = "0x182596630", Slot = "15")]
	public void MKCGHDBBEMF(PIKBMIOJHGL PEPKMEKLMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2596810", Offset = "0x2595C10", VA = "0x182596810", Slot = "16")]
	public void NDNDMLMFMOE(PBLNDGBEFPK PONIOPFBMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x25965A0", Offset = "0x25959A0", VA = "0x1825965A0", Slot = "24")]
	protected virtual void LIFGFHNALCB(PBLNDGBEFPK PONIOPFBMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x2596690", Offset = "0x2595A90", VA = "0x182596690", Slot = "19")]
	private void MLLEMCOGIHN(bool NCCMNNBGHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x2596EC0", Offset = "0x25962C0", VA = "0x182596EC0")]
	private void NEBNOJMLANB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x25963E0", Offset = "0x25957E0", VA = "0x1825963E0")]
	private void JNDEIKMJGIJ([In] APAAMLAHAMB MPDCJBOJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2597070", Offset = "0x2596470", VA = "0x182597070", Slot = "17")]
	public void NJEBOBDEDHM(ANAJOLMCKLN PEPKMEKLMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2596220", Offset = "0x2595620", VA = "0x182596220", Slot = "18")]
	public void EABBHCMFEFL(PIKBMIOJHGL PEPKMEKLMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x96A970", Offset = "0x969D70", VA = "0x18096A970")]
	internal void AKMJHAOKJEI(string OGOCCCFKJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x2596580", Offset = "0x2595980", VA = "0x182596580")]
	internal void JNDKABBGPMO(CHDHDGMCICL BDKFMFBFJII, GBHOAMIGJIM ANONBNLNHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0xD4FFA0", Offset = "0xD4F3A0", VA = "0x180D4FFA0")]
	internal void ALELGIEGKKF(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class DKHLMIDBOAM : FCJCPEMKLMP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class LJDLKPMACBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public NKCIHNNLLKD circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public PEEGBFKPCLP node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public DDIPAIMAGGM<OPLLODEDJNC> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public LJDLKPMACBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x259DB30", Offset = "0x259CF30", VA = "0x18259DB30")]
		internal IDBMMCFHKGB DGIPHIADAMI((int PortDescIndex, int PortIndex, IGIMKCEAIAM InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x259DBC0", Offset = "0x259CFC0", VA = "0x18259DBC0")]
		internal BMBACLHJLDJ HMCLABJEKIL(MANGDHOAEGH i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct OEPAEOMNGAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public DKHLMIDBOAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private BEEAEKGKICI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x25A1750", Offset = "0x25A0B50", VA = "0x1825A1750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x25A1BC0", Offset = "0x25A0FC0", VA = "0x1825A1BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct ELNKKFKGBGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public DKHLMIDBOAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public DDIPAIMAGGM<PEBJCIAAJKE> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private BEEAEKGKICI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2597D60", Offset = "0x2597160", VA = "0x182597D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x25980B0", Offset = "0x25974B0", VA = "0x1825980B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct BAKOBIBHHEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public DKHLMIDBOAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public DDIPAIMAGGM<EGDOMAELJCE> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private BEEAEKGKICI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x25881D0", Offset = "0x25875D0", VA = "0x1825881D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2588520", Offset = "0x2587920", VA = "0x182588520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct EPCKLNNOLEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public DKHLMIDBOAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public DDIPAIMAGGM<PEBJCIAAJKE> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public DDIPAIMAGGM<PEBJCIAAJKE> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private BEEAEKGKICI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2598120", Offset = "0x2597520", VA = "0x182598120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2598480", Offset = "0x2597880", VA = "0x182598480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct NPIGOHKCNJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public DKHLMIDBOAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public DDIPAIMAGGM<EGDOMAELJCE> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public DDIPAIMAGGM<EGDOMAELJCE> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private BEEAEKGKICI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x25A1150", Offset = "0x25A0550", VA = "0x1825A1150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x25A14B0", Offset = "0x25A08B0", VA = "0x1825A14B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct EFMDBPIBGFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public DKHLMIDBOAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private BEEAEKGKICI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2597870", Offset = "0x2596C70", VA = "0x182597870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x2597CF0", Offset = "0x25970F0", VA = "0x182597CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct PJCOBKLKIEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public DKHLMIDBOAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private BEEAEKGKICI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x25A27A0", Offset = "0x25A1BA0", VA = "0x1825A27A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x25A2AF0", Offset = "0x25A1EF0", VA = "0x1825A2AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct OOKOONBKJNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public DKHLMIDBOAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public DDIPAIMAGGM<PEBJCIAAJKE> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private BEEAEKGKICI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x25A20E0", Offset = "0x25A14E0", VA = "0x1825A20E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x25A2450", Offset = "0x25A1850", VA = "0x1825A2450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct JIMAHCAOPMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public DKHLMIDBOAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public DDIPAIMAGGM<EGDOMAELJCE> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private BEEAEKGKICI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x259BFB0", Offset = "0x259B3B0", VA = "0x18259BFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x259C320", Offset = "0x259B720", VA = "0x18259C320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct EDBADCGPHDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public DKHLMIDBOAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public AMDOGBLKLIA type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public DDIPAIMAGGM<PEBJCIAAJKE> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private BEEAEKGKICI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2597460", Offset = "0x2596860", VA = "0x182597460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2597800", Offset = "0x2596C00", VA = "0x182597800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct AHMCKDCPJPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public DKHLMIDBOAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public AMDOGBLKLIA type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public DDIPAIMAGGM<EGDOMAELJCE> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private BEEAEKGKICI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x25870B0", Offset = "0x25864B0", VA = "0x1825870B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x2587450", Offset = "0x2586850", VA = "0x182587450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly bool DMJCKIGKKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly NKCIHNNLLKD GCLOKDKLDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private readonly bool IKMLAPEEHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private IHDDGPKENBI<PINAMAKOAOE, IDBMMCFHKGB> GEOMDHIIEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private IHDDGPKENBI<PINAMAKOAOE, DMPNDNPCPEA> KEEPMALJAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly PEEGBFKPCLP BMFFCIGONLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private IHDDGPKENBI<BFEMAIFODOI, BMBACLHJLDJ> CDMCKEMHKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private IHDDGPKENBI<BFEMAIFODOI, JHLFHOPFFDM> FIEHFMEDFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private string? HGAPMJLGOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly OPIMDIFADKK PBHAAFDBOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private DDIPAIMAGGM<OPLLODEDJNC> MMHELBIJIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly bool DHJOHEDEIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	[CompilerGenerated]
	private Action? KLKBDGCEKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	[CompilerGenerated]
	private Action? NDFJKCDELJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	[CompilerGenerated]
	private Action<DDIPAIMAGGM<PINAMAKOAOE>>? IOBIIPPIENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	[CompilerGenerated]
	private Action<DDIPAIMAGGM<BFEMAIFODOI>>? PDKDBNLAGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private FCJCPEMKLMP.KFCJEIPDKJA? CEPAALEIHGI;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool NPDGMPEGHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x25917F0", Offset = "0x2590BF0", VA = "0x1825917F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool ODFIBNENFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2593EC0", Offset = "0x25932C0", VA = "0x182593EC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool EEANDNIKJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x2594940", Offset = "0x2593D40", VA = "0x182594940", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public IIIMCLEJECC<HFJKEPEKFIF> MKPDHOJMMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2594910", Offset = "0x2593D10", VA = "0x182594910", Slot = "7")]
		get
		{
			return default(IIIMCLEJECC<HFJKEPEKFIF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool KBOABEIAALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2592A20", Offset = "0x2591E20", VA = "0x182592A20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public IHDDGPKENBI<PINAMAKOAOE, DMPNDNPCPEA> NKGONEFCHJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440", Slot = "9")]
		get
		{
			return default(IHDDGPKENBI<PINAMAKOAOE, DMPNDNPCPEA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public string NAMECGEJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x2592C50", Offset = "0x2592050", VA = "0x182592C50", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public IIIMCLEJECC<MJBBEHHNFNA> CLDOMJKGKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x25918B0", Offset = "0x2590CB0", VA = "0x1825918B0", Slot = "11")]
		get
		{
			return default(IIIMCLEJECC<MJBBEHHNFNA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public IHDDGPKENBI<BFEMAIFODOI, JHLFHOPFFDM> CEBEEENIJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x96A720", Offset = "0x969B20", VA = "0x18096A720", Slot = "12")]
		get
		{
			return default(IHDDGPKENBI<BFEMAIFODOI, JHLFHOPFFDM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public DDIPAIMAGGM<OPLLODEDJNC> BMFMCPBKKEA
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xAC3E40", Offset = "0xAC3240", VA = "0x180AC3E40", Slot = "13")]
		get
		{
			return default(DDIPAIMAGGM<OPLLODEDJNC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? BMCCJHMEFNH
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2594240", Offset = "0x2593640", VA = "0x182594240", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2594850", Offset = "0x2593C50", VA = "0x182594850", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action? NEEAFEDHGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2592E00", Offset = "0x2592200", VA = "0x182592E00", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2591AB0", Offset = "0x2590EB0", VA = "0x182591AB0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<DDIPAIMAGGM<PINAMAKOAOE?>, DDIPAIMAGGM<PINAMAKOAOE?>>? DPFJFHMPNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2592D40", Offset = "0x2592140", VA = "0x182592D40", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2595730", Offset = "0x2594B30", VA = "0x182595730", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<DDIPAIMAGGM<PINAMAKOAOE?>, DDIPAIMAGGM<PINAMAKOAOE?>>? KNILJEMIBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2593D20", Offset = "0x2593120", VA = "0x182593D20", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2593710", Offset = "0x2592B10", VA = "0x182593710", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<DDIPAIMAGGM<BFEMAIFODOI?>, DDIPAIMAGGM<BFEMAIFODOI?>>? BFNPOCCIMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x25919F0", Offset = "0x2590DF0", VA = "0x1825919F0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x2594F90", Offset = "0x2594390", VA = "0x182594F90", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<DDIPAIMAGGM<BFEMAIFODOI?>, DDIPAIMAGGM<BFEMAIFODOI?>>? MKIFKENEBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x25925E0", Offset = "0x25919E0", VA = "0x1825925E0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2592B90", Offset = "0x2591F90", VA = "0x182592B90", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<DDIPAIMAGGM<PINAMAKOAOE?>, DMPNDNPCPEA?>? LKFCNBKCBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x25953F0", Offset = "0x25947F0", VA = "0x1825953F0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x25957F0", Offset = "0x2594BF0", VA = "0x1825957F0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<DDIPAIMAGGM<PINAMAKOAOE?>>? LHDEPPONPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x25931C0", Offset = "0x25925C0", VA = "0x1825931C0", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x2593920", Offset = "0x2592D20", VA = "0x182593920", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<DDIPAIMAGGM<PINAMAKOAOE?>, DMPNDNPCPEA?>? JJIMMHDHPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x2590E70", Offset = "0x2590270", VA = "0x182590E70", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x2591C20", Offset = "0x2591020", VA = "0x182591C20", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<DDIPAIMAGGM<BFEMAIFODOI?>, JHLFHOPFFDM?>? MCAIFKGMBPA
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x2593DE0", Offset = "0x25931E0", VA = "0x182593DE0", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x2594ED0", Offset = "0x25942D0", VA = "0x182594ED0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<DDIPAIMAGGM<BFEMAIFODOI?>>? LAEDLJGEFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2591B60", Offset = "0x2590F60", VA = "0x182591B60", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2590F30", Offset = "0x2590330", VA = "0x182590F30", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<DDIPAIMAGGM<BFEMAIFODOI?>, JHLFHOPFFDM?>? JHAGPMNAHIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2592C80", Offset = "0x2592080", VA = "0x182592C80", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2592FC0", Offset = "0x25923C0", VA = "0x182592FC0", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2595EA0", Offset = "0x25952A0", VA = "0x182595EA0")]
	private DKHLMIDBOAM(bool KMLPACPOEJE, NKCIHNNLLKD JGDGFDJAHBD, bool GFJGMPDGDMB, IHDDGPKENBI<PINAMAKOAOE, IDBMMCFHKGB> FOIJCGMBPJG, IHDDGPKENBI<PINAMAKOAOE, DMPNDNPCPEA> MCJLHCANJLP, PEEGBFKPCLP IKAPMMHHNFM, IHDDGPKENBI<BFEMAIFODOI, BMBACLHJLDJ> JDNCMMJEKKH, IHDDGPKENBI<BFEMAIFODOI, JHLFHOPFFDM> KLBAMOMJKIF, string? MAFNIOHHDHO, OPIMDIFADKK HPNMGLJJNHN, DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, bool GDIAMNAENEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x25942E0", Offset = "0x25936E0", VA = "0x1825942E0")]
	public static DKHLMIDBOAM KMDIICJFNJF(bool KMLPACPOEJE, NKCIHNNLLKD JGDGFDJAHBD, bool GFJGMPDGDMB, PEEGBFKPCLP IKAPMMHHNFM, OPIMDIFADKK HPNMGLJJNHN, DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, bool GDIAMNAENEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x25926A0", Offset = "0x2591AA0", VA = "0x1825926A0", Slot = "69")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2591CE0", Offset = "0x25910E0", VA = "0x182591CE0", Slot = "38")]
	[AsyncStateMachine(typeof(OEPAEOMNGAN))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP?>>? DJNNKGCKODI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2594010", Offset = "0x2593410", VA = "0x182594010")]
	private (ECBBHJKDFAK?, int)? KJAMEONNHBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2593B10", Offset = "0x2592F10", VA = "0x182593B10", Slot = "58")]
	private void HPCMCOEGKMF(int MENJKHHFHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x1D99280", Offset = "0x1D98680", VA = "0x181D99280", Slot = "57")]
	private void PJMLKDKPNCA(int MENJKHHFHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2594B30", Offset = "0x2593F30", VA = "0x182594B30", Slot = "61")]
	private void MOKEBLMKCNE(int EAHCFAHLIBB, int HGMEGGLDMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x25958B0", Offset = "0x2594CB0", VA = "0x1825958B0", Slot = "63")]
	private void PDDDGMCEFGP(int EAHCFAHLIBB, int HGMEGGLDMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2595910", Offset = "0x2594D10", VA = "0x182595910", Slot = "50")]
	private void PGCCBLHHMFL(int MENJKHHFHBP, DDIPAIMAGGM<PINAMAKOAOE> JPFONPFNDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2593080", Offset = "0x2592480", VA = "0x182593080", Slot = "54")]
	private void FHIDDLBPACB(int NCCMNNBGHEA, DDIPAIMAGGM<PINAMAKOAOE> JPFONPFNDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x25948F0", Offset = "0x2593CF0", VA = "0x1825948F0", Slot = "49")]
	private void MGFCBFPLJEK(int NCCMNNBGHEA, DDIPAIMAGGM<PINAMAKOAOE> JPFONPFNDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x25913A0", Offset = "0x25907A0", VA = "0x1825913A0", Slot = "53")]
	private void ANKLBBBFBPK(int MENJKHHFHBP, DDIPAIMAGGM<PINAMAKOAOE> JPFONPFNDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x25937D0", Offset = "0x2592BD0", VA = "0x1825937D0", Slot = "66")]
	private void GJLHNMBBPLG(int MENJKHHFHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x116FD10", Offset = "0x116F110", VA = "0x18116FD10", Slot = "65")]
	private void LAMDLAECAOJ(int MENJKHHFHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2592AA0", Offset = "0x2591EA0", VA = "0x182592AA0", Slot = "60")]
	private void EFJCGJHKLDP(int MENJKHHFHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1D99280", Offset = "0x1D98680", VA = "0x181D99280", Slot = "59")]
	private void PKJFOJIADNE(int MENJKHHFHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2595050", Offset = "0x2594450", VA = "0x182595050", Slot = "62")]
	private void NDOINEGAOIF(int EAHCFAHLIBB, int HGMEGGLDMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x25956D0", Offset = "0x2594AD0", VA = "0x1825956D0", Slot = "64")]
	private void OGKBLKBMCFN(int EAHCFAHLIBB, int HGMEGGLDMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2591F20", Offset = "0x2591320", VA = "0x182591F20", Slot = "52")]
	private void DOAHFNNDMAB(int MENJKHHFHBP, DDIPAIMAGGM<BFEMAIFODOI> JPFONPFNDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2593280", Offset = "0x2592680", VA = "0x182593280", Slot = "56")]
	private void GCOKFJNMOKC(int NCCMNNBGHEA, DDIPAIMAGGM<BFEMAIFODOI> JPFONPFNDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2593EA0", Offset = "0x25932A0", VA = "0x182593EA0", Slot = "51")]
	private void JFIKEDJHHPD(int NCCMNNBGHEA, DDIPAIMAGGM<BFEMAIFODOI> JPFONPFNDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x25932A0", Offset = "0x25926A0", VA = "0x1825932A0", Slot = "55")]
	private void GEBIIIGOMEJ(int MENJKHHFHBP, DDIPAIMAGGM<BFEMAIFODOI> JPFONPFNDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2591DD0", Offset = "0x25911D0", VA = "0x182591DD0", Slot = "68")]
	private void DLMOOKMLHKD(int MENJKHHFHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x116FD10", Offset = "0x116F110", VA = "0x18116FD10", Slot = "67")]
	private void PIPNCLDEPHF(int MENJKHHFHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2592EB0", Offset = "0x25922B0", VA = "0x182592EB0", Slot = "39")]
	[AsyncStateMachine(typeof(ELNKKFKGBGL))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP?>>? FEMKMCFIAAJ(DDIPAIMAGGM<PEBJCIAAJKE> OCGFCPNBLBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2593F00", Offset = "0x2593300", VA = "0x182593F00", Slot = "40")]
	[AsyncStateMachine(typeof(BAKOBIBHHEN))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP?>>? JPGGELCPCGD(DDIPAIMAGGM<EGDOMAELJCE> BLINDGLNPJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2593C00", Offset = "0x2593000", VA = "0x182593C00", Slot = "41")]
	[AsyncStateMachine(typeof(EPCKLNNOLEA))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP?>>? IJLFMMGMKFN(DDIPAIMAGGM<PEBJCIAAJKE> OCGFCPNBLBK, DDIPAIMAGGM<PEBJCIAAJKE> GAHHPPHMADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x25918D0", Offset = "0x2590CD0", VA = "0x1825918D0", Slot = "42")]
	[AsyncStateMachine(typeof(NPIGOHKCNJI))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP?>>? BIDBDACNGOK(DDIPAIMAGGM<EGDOMAELJCE> BLINDGLNPJJ, DDIPAIMAGGM<EGDOMAELJCE> GAHHPPHMADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x25955E0", Offset = "0x25949E0", VA = "0x1825955E0", Slot = "43")]
	[AsyncStateMachine(typeof(EFMDBPIBGFI))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP?>>? NLIFPECLPJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x25930A0", Offset = "0x25924A0", VA = "0x1825930A0", Slot = "44")]
	[AsyncStateMachine(typeof(PJCOBKLKIEI))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> FKEPPDLONDL(string KOLLPJNEOCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x25954B0", Offset = "0x25948B0", VA = "0x1825954B0", Slot = "45")]
	[AsyncStateMachine(typeof(OOKOONBKJNP))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> NHJEHDHLMNJ(DDIPAIMAGGM<PEBJCIAAJKE> OCGFCPNBLBK, string OGOCCCFKJPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x25924B0", Offset = "0x25918B0", VA = "0x1825924B0", Slot = "46")]
	[AsyncStateMachine(typeof(JIMAHCAOPMA))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> DPIBMHGLLJI(DDIPAIMAGGM<EGDOMAELJCE> BLINDGLNPJJ, string OGOCCCFKJPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x25939E0", Offset = "0x2592DE0", VA = "0x1825939E0", Slot = "47")]
	[AsyncStateMachine(typeof(EDBADCGPHDF))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> HLLGFILKEPG(DDIPAIMAGGM<PEBJCIAAJKE> OCGFCPNBLBK, AMDOGBLKLIA ANONBNLNHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2594A00", Offset = "0x2593E00", VA = "0x182594A00", Slot = "48")]
	[AsyncStateMachine(typeof(AHMCKDCPJPE))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> MNHAJKKJIBL(DDIPAIMAGGM<EGDOMAELJCE> BLINDGLNPJJ, AMDOGBLKLIA ANONBNLNHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2590FF0", Offset = "0x25903F0", VA = "0x182590FF0")]
	internal void ALELGIEGKKF(DDIPAIMAGGM<OPLLODEDJNC> PEBNJNGMMHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public sealed class NLBLNAEPKLK : HBGCPCDJMAM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public interface DFFDFJNJFKF
	{
		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public readonly struct JCCGPBBNIDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public readonly IReadOnlyDictionary<IIIMCLEJECC<HFJKEPEKFIF>, Guid>? COPFCAMHKPD;

			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xC1B040", Offset = "0xC1A440", VA = "0x180C1B040")]
			public JCCGPBBNIDD(IReadOnlyDictionary<IIIMCLEJECC<HFJKEPEKFIF>, Guid>? COPFCAMHKPD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		CHDHDGMCICL GPNIPOGMJBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<EBPMLNHKOOL> GKOENJOEALM(CancellationToken MLAPMBKLAOF);

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<LDEPJGKAOIB> NOLFDPJPHLF(CancellationToken MLAPMBKLAOF);

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<AHFADEOIIIE> NCIMGMIKDNA(CancellationToken MLAPMBKLAOF);

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<PLFDEBDPAHA> PGGGLCNBDMG(CancellationToken MLAPMBKLAOF);

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<JCCGPBBNIDD> ODBMDBPNNDP(CancellationToken MLAPMBKLAOF);

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<GOKMGIFMDCE> MNGEDGDEBPA(CancellationToken MLAPMBKLAOF);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct JKLCFCNFJCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public AsyncTaskMethodBuilder<NLBLNAEPKLK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public NKCIHNNLLKD circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public EBPMLNHKOOL roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public LDEPJGKAOIB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private DFFDFJNJFKF <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private EBPMLNHKOOL <downloadedRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private EBPMLNHKOOL <actualRoomData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private GOKMGIFMDCE <actualStaticConfig>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private LDEPJGKAOIB <finalSuperRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private AHFADEOIIIE <roomAssetData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private PLFDEBDPAHA <playerSaveData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<EBPMLNHKOOL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private EBPMLNHKOOL <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<GOKMGIFMDCE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<LDEPJGKAOIB> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private TaskAwaiter<AHFADEOIIIE> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private TaskAwaiter<PLFDEBDPAHA> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private TaskAwaiter<DFFDFJNJFKF.JCCGPBBNIDD> <>u__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private TaskAwaiter<IFOMDBLACAN> <>u__7;

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x259C4A0", Offset = "0x259B8A0", VA = "0x18259C4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x259D560", Offset = "0x259C960", VA = "0x18259D560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private readonly IFOMDBLACAN LIDJBFPCFOP;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public IFOMDBLACAN IHINJDIOCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	private NLBLNAEPKLK(IFOMDBLACAN BLMKHLDEGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x25A0F00", Offset = "0x25A0300", VA = "0x1825A0F00")]
	[AsyncStateMachine(typeof(JKLCFCNFJCD))]
	public static Task<NLBLNAEPKLK> FCBKLNEHMME(NKCIHNNLLKD JGDGFDJAHBD, EBPMLNHKOOL? EDHFGAMFCNC, LDEPJGKAOIB? IEFIJIFMMAE, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x25A0EE0", Offset = "0x25A02E0", VA = "0x1825A0EE0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public readonly struct GFPIAOMKNJK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct FAKFJNFOAHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<object, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public GFPIAOMKNJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public CLANKEGLHHM action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<PHLGGJNOBDN<object, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x25984F0", Offset = "0x25978F0", VA = "0x1825984F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2598780", Offset = "0x2597B80", VA = "0x182598780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct GJEJEKOOMFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<bool, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public MHIINPCBDCK rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public EBPMLNHKOOL circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public LDEPJGKAOIB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public GFPIAOMKNJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private CLANKEGLHHM[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<PHLGGJNOBDN<object, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x259AEC0", Offset = "0x259A2C0", VA = "0x18259AEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x259B2A0", Offset = "0x259A6A0", VA = "0x18259B2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct AENJODDLOCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public GFPIAOMKNJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private TaskAwaiter<PHLGGJNOBDN<object, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x2586DA0", Offset = "0x25861A0", VA = "0x182586DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2586FE0", Offset = "0x25863E0", VA = "0x182586FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private readonly DDLFMPNBOMD LOFJNOAIFAL;

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0xC1B040", Offset = "0xC1A440", VA = "0x180C1B040")]
	public GFPIAOMKNJK(DDLFMPNBOMD APBFOEBCMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x259AB40", Offset = "0x2599F40", VA = "0x18259AB40")]
	[AsyncStateMachine(typeof(FAKFJNFOAHH))]
	private Task<PHLGGJNOBDN<object, MEENKFHCKIP>> FCJMDEBFNEC(CLANKEGLHHM NJNJGNMEACN, bool GIKCANOKEJN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x259AD60", Offset = "0x259A160", VA = "0x18259AD60")]
	[AsyncStateMachine(typeof(GJEJEKOOMFK))]
	public Task<PHLGGJNOBDN<bool, MEENKFHCKIP?>>? LIANAIDFPEA(int LEFAFPBEKPP, MHIINPCBDCK? GIODPLCOFGH, EBPMLNHKOOL? CEHAGGGBMLL, LDEPJGKAOIB? IEFIJIFMMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x259AC70", Offset = "0x259A070", VA = "0x18259AC70")]
	[AsyncStateMachine(typeof(AENJODDLOCP))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> FKLDNICNGJG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public sealed class IIHIEMGBGOE : OEAAHDEFLFJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private readonly OADGFOLJFEH KGBONHMIIFF;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public OADGFOLJFEH JJOGNCHBOPN
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	private IIHIEMGBGOE(OADGFOLJFEH BDLDMBKLBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x259B950", Offset = "0x259AD50", VA = "0x18259B950")]
	public static IIHIEMGBGOE NHMCOOCBIHH(NKCIHNNLLKD JGDGFDJAHBD, MHIINPCBDCK KLPBHNMLJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x259B930", Offset = "0x259AD30", VA = "0x18259B930", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public interface HJLILFOIKND : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	IFOMDBLACAN IHINJDIOCHP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	FCCMKHGKDCH GINCBJGKJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	LFOPINEOLBA GDLDMCOOJOD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	CLNANLDOMDG NCDLPEGHBIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public interface ICEINAGLPIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	HJLILFOIKND? CLPBFOOMHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	bool GJIAKANDJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	bool NDAEJFNJFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<HJLILFOIKND?>? JAPKMBFJNPP();

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task NLFGDODMJDJ(NKCIHNNLLKD JGDGFDJAHBD, MHIINPCBDCK KLPBHNMLJKB, EBPMLNHKOOL? IJGJLIFIGDN, LDEPJGKAOIB? OFPDHOLPNAG);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[AJMJIHOHNKK("IStaticCV2Instance")]
public interface HBGCPCDJMAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	IFOMDBLACAN IHINJDIOCHP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[AJMJIHOHNKK("IStaticEVInstance")]
public interface OEAAHDEFLFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	OADGFOLJFEH JJOGNCHBOPN
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class OIMENKJFIBB
{
	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x25A1C30", Offset = "0x25A1030", VA = "0x1825A1C30")]
	public static KLJEJOPBIHF<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD, DPEINBLHDDE.AAMEMANMBDM<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD>> BCAGPEMEKLE([In] this KLJEJOPBIHF<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD, DPEINBLHDDE.AAMEMANMBDM<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD>> CIHPJJACMNO)
	{
		return default(KLJEJOPBIHF<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD, DPEINBLHDDE.AAMEMANMBDM<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class JADCGGBODIB : GDMBKGJHBJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private readonly NKCIHNNLLKD GCLOKDKLDGK;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool NDAEJFNJFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x259BB40", Offset = "0x259AF40", VA = "0x18259BB40", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	internal JADCGGBODIB(NKCIHNNLLKD JGDGFDJAHBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal sealed class DHBDPCOFAMO : KNCPIPMMNGP
{
	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x2590DD0", Offset = "0x25901D0", VA = "0x182590DD0", Slot = "4")]
	public DHCPGFBHOME? ODOBFKBDFIO(string? FKMAEDHOLFD, string? COJOGMNELDD, string? NPJFMJEANDM, LEAAHHGDPPB.DOOFFIGLFNC.GBNDDLPKILG AELBNKGGBPP, bool KLGOEDEENJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public DHBDPCOFAMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class MNPKEKFKBMC : NGENMGFIPPL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct FCFOCBLJIHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public AsyncTaskMethodBuilder<HCCJEMAFJIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public MNPKEKFKBMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<HJLILFOIKND?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x25987F0", Offset = "0x2597BF0", VA = "0x1825987F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x2598A90", Offset = "0x2597E90", VA = "0x182598A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private readonly NKCIHNNLLKD GCLOKDKLDGK;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public HCCJEMAFJIA? AJPLFLPAHGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x259FC00", Offset = "0x259F000", VA = "0x18259FC00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public CLNANLDOMDG? PMLEEFOLIID
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x259F520", Offset = "0x259E920", VA = "0x18259F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool FOBJKIFAHNP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x259F5A0", Offset = "0x259E9A0", VA = "0x18259F5A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool DBFHCIDOIFP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x259FE20", Offset = "0x259F220", VA = "0x18259FE20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x259FE80", Offset = "0x259F280", VA = "0x18259FE80")]
	internal MNPKEKFKBMC(NKCIHNNLLKD JGDGFDJAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x259F600", Offset = "0x259EA00", VA = "0x18259F600", Slot = "7")]
	[AsyncStateMachine(typeof(FCFOCBLJIHP))]
	public Task<HCCJEMAFJIA> IIOGHIHEMEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x259F6F0", Offset = "0x259EAF0", VA = "0x18259F6F0", Slot = "9")]
	public IReadOnlyDictionary<IIIMCLEJECC<HFJKEPEKFIF>, Guid> LFOPPNNKCCH(IEnumerable<FMDAPGFGAFB> HCEDFFHHHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x259F3A0", Offset = "0x259E7A0", VA = "0x18259F3A0", Slot = "10")]
	public JDMABPBGFDA CBEFFHJCPBM(IEnumerable<FMDAPGFGAFB> HCEDFFHHHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x259FC80", Offset = "0x259F080", VA = "0x18259FC80")]
	public PHLGGJNOBDN<LAJKIEPBPFL, MOCCGNOLGDK> OEEKMFNOJNH([In] LAJKIEPBPFL LMKPHKPJNJK)
	{
		return default(PHLGGJNOBDN<LAJKIEPBPFL, MOCCGNOLGDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x259FA60", Offset = "0x259EE60", VA = "0x18259FA60", Slot = "8")]
	private PHLGGJNOBDN<LAJKIEPBPFL, MOCCGNOLGDK> NAKFOODNDAP([In] LAJKIEPBPFL LMKPHKPJNJK)
	{
		return default(PHLGGJNOBDN<LAJKIEPBPFL, MOCCGNOLGDK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class CLNANLDOMDG : HCCJEMAFJIA
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	internal static class GDAMDBLHOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class DAFCMOAAGAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			public IFOMDBLACAN state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400029C")]
			public PNKCBINOOLI spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public DAFCMOAAGAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x25A5F50", Offset = "0x25A5350", VA = "0x1825A5F50")]
			internal bool BFCECOBMGLN(OMBGDEFIBAC n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class HBFHKBGFMOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029D")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public HBFHKBGFMOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0x25A8070", Offset = "0x25A7470", VA = "0x1825A8070")]
			internal void POIOJKKENEJ(OMBGDEFIBAC n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2599010", Offset = "0x2598410", VA = "0x182599010")]
		public static PHLGGJNOBDN<HCCJEMAFJIA.JNDCDBJOOHJ, ADKFHONBPGC> GNAFMGAEBCA(CLNANLDOMDG IIICNLIAPBJ, [In] HCCJEMAFJIA.LBKDPNOIAJO BKIADHLGJLK)
		{
			return default(PHLGGJNOBDN<HCCJEMAFJIA.JNDCDBJOOHJ, ADKFHONBPGC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x2599960", Offset = "0x2598D60", VA = "0x182599960")]
		internal static PHLGGJNOBDN<(CLGHMLOEHNP, BMIOEMBLONM), ADKFHONBPGC> KPNGCMMFKGM(CLNANLDOMDG IIICNLIAPBJ, BMIOEMBLONM PMIMOEEPDNJ, bool JADLKGJEPGC, [In] IIIMCLEJECC<HFJKEPEKFIF> IMEAKONDCFF, [In] int? PPODNANMBAN, [In] IJJACHJMKKP? DACPFLGMJJE, [In] IJJACHJMKKP? FHDFPEECOAB)
		{
			return default(PHLGGJNOBDN<(CLGHMLOEHNP, BMIOEMBLONM), ADKFHONBPGC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x2598B90", Offset = "0x2597F90", VA = "0x182598B90")]
		private static void FHOPIAFPBCK(bool JADLKGJEPGC, FMDAPGFGAFB MCHMPDGPNBP, CLGHMLOEHNP LIKAFNOPLLK, [In] IIIMCLEJECC<HFJKEPEKFIF> IMEAKONDCFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x2599550", Offset = "0x2598950", VA = "0x182599550")]
		public static void JDBHLMDBBJJ(JGPBJIMDDKJ OGFPNHDAGAJ, [In] HCCJEMAFJIA.KJHNCNCLJEB IEBPCJPPNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x259A770", Offset = "0x2599B70", VA = "0x18259A770")]
		[CompilerGenerated]
		internal static bool NKOLAFDANNM(IFOMDBLACAN BIKALPIOMCG, PNKCBINOOLI BEICLNJLMBD, OMBGDEFIBAC LIGEJNOFCEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x2598B60", Offset = "0x2597F60", VA = "0x182598B60")]
		[CompilerGenerated]
		internal static bool BHHEBMIHIEG(OMBGDEFIBAC HGLMIIIBLAB)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct JAIBLMPNJGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public CLNANLDOMDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public DDIPAIMAGGM<HFJKEPEKFIF> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public DDIPAIMAGGM<MJBBEHHNFNA> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public INFNEOIMIIP offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public bool deleteBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x25A8CD0", Offset = "0x25A80D0", VA = "0x1825A8CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x25A8F20", Offset = "0x25A8320", VA = "0x1825A8F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct MMALIMDBLNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CLNANLDOMDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public DDIPAIMAGGM<HFJKEPEKFIF> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public IIIMCLEJECC<MJBBEHHNFNA> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public List<DDIPAIMAGGM<MJBBEHHNFNA>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public INFNEOIMIIP localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public HLENJKBPEOD localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public INFNEOIMIIP offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x25A9240", Offset = "0x25A8640", VA = "0x1825A9240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x25A9500", Offset = "0x25A8900", VA = "0x1825A9500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct HPBFFKPLAIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public CLNANLDOMDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public DDIPAIMAGGM<HFJKEPEKFIF> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public IIIMCLEJECC<MJBBEHHNFNA> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public List<DDIPAIMAGGM<MJBBEHHNFNA>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x25A8320", Offset = "0x25A7720", VA = "0x1825A8320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x25A8560", Offset = "0x25A7960", VA = "0x1825A8560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct PIIHAHCLGDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public CLNANLDOMDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public DDIPAIMAGGM<HFJKEPEKFIF> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public IIIMCLEJECC<MJBBEHHNFNA> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public DDIPAIMAGGM<HFJKEPEKFIF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public List<DDIPAIMAGGM<MJBBEHHNFNA>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x25A9EB0", Offset = "0x25A92B0", VA = "0x1825A9EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x25AA0F0", Offset = "0x25A94F0", VA = "0x1825AA0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct BCOOCPNPCBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public CLNANLDOMDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public IIIMCLEJECC<HFJKEPEKFIF> legacyGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public IIIMCLEJECC<MJBBEHHNFNA> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public IReadOnlyList<IIIMCLEJECC<MJBBEHHNFNA>> nodeLegacyIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public IReadOnlyDictionary<MJLPFDOLPML, (DDIPAIMAGGM<OPLLODEDJNC>, DDIPAIMAGGM<PINAMAKOAOE>)> inputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public IReadOnlyDictionary<NFKEGFCJKFD, (DDIPAIMAGGM<OPLLODEDJNC>, DDIPAIMAGGM<BFEMAIFODOI>)> outputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x25A4110", Offset = "0x25A3510", VA = "0x1825A4110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x25A4730", Offset = "0x25A3B30", VA = "0x1825A4730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct CFEHMBLEFMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public CLNANLDOMDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public DDIPAIMAGGM<HFJKEPEKFIF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public DDIPAIMAGGM<BIIAPNECPOC> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public DDIPAIMAGGM<HAEPGAFINPD> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x25A51D0", Offset = "0x25A45D0", VA = "0x1825A51D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x25A5820", Offset = "0x25A4C20", VA = "0x1825A5820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct IHCKODKCGHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public CLNANLDOMDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public IIIMCLEJECC<MJBBEHHNFNA> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public IIIMCLEJECC<HFJKEPEKFIF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public DDIPAIMAGGM<OPLLODEDJNC> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public DDIPAIMAGGM<PINAMAKOAOE> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x25A88C0", Offset = "0x25A7CC0", VA = "0x1825A88C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x25A8C00", Offset = "0x25A8000", VA = "0x1825A8C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct CJDFBILFJHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public CLNANLDOMDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public IIIMCLEJECC<MJBBEHHNFNA> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public IIIMCLEJECC<HFJKEPEKFIF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public DDIPAIMAGGM<OPLLODEDJNC> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public DDIPAIMAGGM<BFEMAIFODOI> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x25A5890", Offset = "0x25A4C90", VA = "0x1825A5890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x25A5BD0", Offset = "0x25A4FD0", VA = "0x1825A5BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct HOIFHBGIDHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public CLNANLDOMDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private TaskAwaiter<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x25A8090", Offset = "0x25A7490", VA = "0x1825A8090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x25A82B0", Offset = "0x25A76B0", VA = "0x1825A82B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private readonly NKCIHNNLLKD GCLOKDKLDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private readonly HBGCPCDJMAM LEJIPHKGPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private readonly OEAAHDEFLFJ JCMCADOJBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private readonly CIIKNGDEPEP KHCNGDMBPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private readonly MNPKEKFKBMC LBIFMDGDNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private Dictionary<IIIMCLEJECC<MJBBEHHNFNA>, AGCPOGDEIKB> GPDIHLMCAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	[CompilerGenerated]
	private Action<IIIMCLEJECC<MJBBEHHNFNA>>? CFBMLMKELMO;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public IIIMCLEJECC<HFJKEPEKFIF> LBALFDKMFLB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x258D1D0", Offset = "0x258C5D0", VA = "0x18258D1D0", Slot = "4")]
		get
		{
			return default(IIIMCLEJECC<HFJKEPEKFIF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public CIIKNGDEPEP JLCLPNCHONG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x2580C60", Offset = "0x2580060", VA = "0x182580C60", Slot = "5")]
		get
		{
			return default(CIIKNGDEPEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x25907D0", Offset = "0x258FBD0", VA = "0x1825907D0")]
	public CLNANLDOMDG(NKCIHNNLLKD JGDGFDJAHBD, HBGCPCDJMAM HOIGHFACGEC, OEAAHDEFLFJ FPCLKDBKCBE, MNPKEKFKBMC FKHJJLLLBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x258E660", Offset = "0x258DA60", VA = "0x18258E660", Slot = "65")]
	public DDIPAIMAGGM<ABOEGKAFJDM> KBFOJKEHLOI(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL)
	{
		return default(DDIPAIMAGGM<ABOEGKAFJDM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x2589C30", Offset = "0x2589030", VA = "0x182589C30", Slot = "66")]
	public DDIPAIMAGGM<EJEEOIMCMBG> AGMJOBOAKFE(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<BIIAPNECPOC> BFKOLDCFMBJ)
	{
		return default(DDIPAIMAGGM<EJEEOIMCMBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x2589F80", Offset = "0x2589380", VA = "0x182589F80", Slot = "6")]
	public (bool, bool) BGNGBCBBMGO(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<BIIAPNECPOC> FCCDKGKKFDG, DDIPAIMAGGM<HAEPGAFINPD> NBGPCEAFJMG)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x258CA20", Offset = "0x258BE20", VA = "0x18258CA20")]
	public bool GCJNLGIOAHE(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, [In] GGNGBBOFIMO HGNAKMGDJDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x258B820", Offset = "0x258AC20", VA = "0x18258B820", Slot = "8")]
	public bool EDPEEKCLFJC(DMPNDNPCPEA KKEFANGFGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x258D150", Offset = "0x258C550", VA = "0x18258D150", Slot = "9")]
	public bool HKMAHBCDIBO(JHLFHOPFFDM MJLAJAFMPJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x258FC10", Offset = "0x258F010", VA = "0x18258FC10", Slot = "10")]
	public APLNEMPBEIA? NICKEOAJHHL(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x258E240", Offset = "0x258D640", VA = "0x18258E240", Slot = "11")]
	public COMIOLOMOLN? JHANFCPMNLN(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<BIIAPNECPOC> BFKOLDCFMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x258F610", Offset = "0x258EA10", VA = "0x18258F610", Slot = "12")]
	public DDIPAIMAGGM<BIIAPNECPOC>? MNOHJFECEJN(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<MJBBEHHNFNA> JFBLNBCAHJM, DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, DDIPAIMAGGM<BFEMAIFODOI> EDIOMDNEKAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x258EEC0", Offset = "0x258E2C0", VA = "0x18258EEC0", Slot = "13")]
	public DDIPAIMAGGM<HAEPGAFINPD>? MHNEKGIFILG(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<MJBBEHHNFNA> JFBLNBCAHJM, DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, DDIPAIMAGGM<PINAMAKOAOE> DEHGFPGBPMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x258C930", Offset = "0x258BD30", VA = "0x18258C930", Slot = "14")]
	public IEnumerable<DDIPAIMAGGM<HFJKEPEKFIF>> FOOECJNOALK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x25905F0", Offset = "0x258F9F0", VA = "0x1825905F0", Slot = "15")]
	public IEnumerable<DDIPAIMAGGM<CFALJJGAKHG>> PLJNGNJAANA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x258B520", Offset = "0x258A920", VA = "0x18258B520", Slot = "16")]
	public string COPBIMHKKEA(DDIPAIMAGGM<CFALJJGAKHG> ODAOACEEPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x258ED90", Offset = "0x258E190", VA = "0x18258ED90", Slot = "17")]
	public string LOKNLNABIIA(DDIPAIMAGGM<CFALJJGAKHG> ODAOACEEPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x258D5F0", Offset = "0x258C9F0", VA = "0x18258D5F0")]
	public AGCPOGDEIKB? IJPOIADOGGJ([In] IIIMCLEJECC<MJBBEHHNFNA> JFBLNBCAHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x25901F0", Offset = "0x258F5F0", VA = "0x1825901F0", Slot = "23")]
	public DDIPAIMAGGM<KBGLEEGJHEA> PDEHCHIANHJ(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<MJBBEHHNFNA> JFBLNBCAHJM)
	{
		return default(DDIPAIMAGGM<KBGLEEGJHEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x258D0D0", Offset = "0x258C4D0", VA = "0x18258D0D0")]
	public DDIPAIMAGGM<MJBBEHHNFNA> HJFOEHJIEAJ(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, [In] IIIMCLEJECC<MJBBEHHNFNA> FOHLLKAKDOB)
	{
		return default(DDIPAIMAGGM<MJBBEHHNFNA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x258B6B0", Offset = "0x258AAB0", VA = "0x18258B6B0", Slot = "33")]
	public DDIPAIMAGGM<MJBBEHHNFNA> DICAIGAPKAD(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL)
	{
		return default(DDIPAIMAGGM<MJBBEHHNFNA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x258A480", Offset = "0x2589880", VA = "0x18258A480", Slot = "34")]
	public DDIPAIMAGGM<MJBBEHHNFNA> BJBGCLEDNCG(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<BIIAPNECPOC> BFKOLDCFMBJ)
	{
		return default(DDIPAIMAGGM<MJBBEHHNFNA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x2590170", Offset = "0x258F570", VA = "0x182590170")]
	public DDIPAIMAGGM<MJBBEHHNFNA>? PBEONDEGEKP(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, [In] IIIMCLEJECC<MJBBEHHNFNA> FOHLLKAKDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x258AA20", Offset = "0x2589E20", VA = "0x18258AA20", Slot = "25")]
	public MALNENCMIFK? CGEIBJCDOAJ(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x258C9C0", Offset = "0x258BDC0", VA = "0x18258C9C0", Slot = "26")]
	public long GBJOHCDFFFH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x258E8A0", Offset = "0x258DCA0", VA = "0x18258E8A0")]
	private void LECECILMALO(IIIMCLEJECC<MJBBEHHNFNA> JFBLNBCAHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x258EB90", Offset = "0x258DF90", VA = "0x18258EB90", Slot = "31")]
	public IEnumerable<(DDIPAIMAGGM<HFJKEPEKFIF>, DDIPAIMAGGM<MJBBEHHNFNA>)> LKLFHANONBJ(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x258EE30", Offset = "0x258E230", VA = "0x18258EE30", Slot = "32")]
	public DDIPAIMAGGM<HAEPGAFINPD> MHNEKGIFILG(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<MJBBEHHNFNA> JFBLNBCAHJM, DDIPAIMAGGM<ABOEGKAFJDM> DEHGFPGBPMM)
	{
		return default(DDIPAIMAGGM<HAEPGAFINPD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x258F6A0", Offset = "0x258EAA0", VA = "0x18258F6A0", Slot = "35")]
	public DDIPAIMAGGM<BIIAPNECPOC> MNOHJFECEJN(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<MJBBEHHNFNA> JFBLNBCAHJM, DDIPAIMAGGM<EJEEOIMCMBG> EDIOMDNEKAO)
	{
		return default(DDIPAIMAGGM<BIIAPNECPOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2590060", Offset = "0x258F460", VA = "0x182590060")]
	private AGCPOGDEIKB? OGEELEMEDLH([In] IIIMCLEJECC<MJBBEHHNFNA> JFBLNBCAHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x258D760", Offset = "0x258CB60", VA = "0x18258D760")]
	public PEEGBFKPCLP? IMMMLAGLIDC([In] IIIMCLEJECC<MJBBEHHNFNA> JFBLNBCAHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x258BEA0", Offset = "0x258B2A0", VA = "0x18258BEA0")]
	public DMEFLICKLLD? NEOGEPALPED([In] IIIMCLEJECC<HFJKEPEKFIF> BPHNGBDIGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x258E5A0", Offset = "0x258D9A0", VA = "0x18258E5A0", Slot = "27")]
	public IEnumerable<IKHKBDGBIAI> JNBLMBBHMCB(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x258CD50", Offset = "0x258C150", VA = "0x18258CD50", Slot = "28")]
	public bool GHBOGDCCGIE(DDIPAIMAGGM<CFALJJGAKHG> ODAOACEEPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x258CDE0", Offset = "0x258C1E0", VA = "0x18258CDE0", Slot = "29")]
	public IEnumerable<GGNGBBOFIMO> GMJJIELNPAK(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<BIIAPNECPOC> FCCDKGKKFDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x258FDE0", Offset = "0x258F1E0", VA = "0x18258FDE0", Slot = "30")]
	public IEnumerable<GGNGBBOFIMO> OBECNPIKEOP(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<HAEPGAFINPD> NBGPCEAFJMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x258E1C0", Offset = "0x258D5C0", VA = "0x18258E1C0")]
	public DDIPAIMAGGM<HFJKEPEKFIF> IMOEGBKHMOI([In] IIIMCLEJECC<HFJKEPEKFIF> BPHNGBDIGAJ)
	{
		return default(DDIPAIMAGGM<HFJKEPEKFIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x2589CB0", Offset = "0x25890B0", VA = "0x182589CB0")]
	public DDIPAIMAGGM<HFJKEPEKFIF>? AHIPGFDOGCM([In] IIIMCLEJECC<HFJKEPEKFIF> BPHNGBDIGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x258C6A0", Offset = "0x258BAA0", VA = "0x18258C6A0")]
	private PNKCBINOOLI? FMNJIBJJCBN([In] IIIMCLEJECC<HFJKEPEKFIF> BPHNGBDIGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x258BEA0", Offset = "0x258B2A0", VA = "0x18258BEA0")]
	private DMEFLICKLLD? PGEMENMHKGJ([In] IIIMCLEJECC<HFJKEPEKFIF> BPHNGBDIGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x258E300", Offset = "0x258D700", VA = "0x18258E300", Slot = "21")]
	public DDIPAIMAGGM<HFJKEPEKFIF>? JILGNIPPGFN(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<MJBBEHHNFNA> JFBLNBCAHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x25903A0", Offset = "0x258F7A0", VA = "0x1825903A0", Slot = "39")]
	public IIIMCLEJECC<HFJKEPEKFIF> PJNDJAKLEII(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ)
	{
		return default(IIIMCLEJECC<HFJKEPEKFIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x258FCD0", Offset = "0x258F0D0", VA = "0x18258FCD0", Slot = "36")]
	public IEnumerable<AMDOGBLKLIA> NJKEDNHIPOH(BLFFMEJGFCL HJMHONOMIKB, bool IMECJBKPPFN, bool LLBBNFAKEKN, bool IBEDNFPKLFA, bool GKLEODJFEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x258F7B0", Offset = "0x258EBB0", VA = "0x18258F7B0", Slot = "37")]
	public AMDOGBLKLIA NDKJDLHDFHA(BLFFMEJGFCL HJMHONOMIKB, GPCJCODIIKO ECLLBMBJFGN, bool IMECJBKPPFN, bool LLBBNFAKEKN, bool IBEDNFPKLFA, bool GKLEODJFEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x258E930", Offset = "0x258DD30", VA = "0x18258E930")]
	public IKHKBDGBIAI LPPMPDKCCCJ(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, [In] GGNGBBOFIMO HGNAKMGDJDJ)
	{
		return default(IKHKBDGBIAI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x258C020", Offset = "0x258B420", VA = "0x18258C020", Slot = "40")]
	public GGNGBBOFIMO FBAJGBKDKEO(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<BIIAPNECPOC> FCCDKGKKFDG, DDIPAIMAGGM<HAEPGAFINPD> NBGPCEAFJMG)
	{
		return default(GGNGBBOFIMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2589A00", Offset = "0x2588E00", VA = "0x182589A00", Slot = "41")]
	[AsyncStateMachine(typeof(JAIBLMPNJGA))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> ABMEDOOGOEG(DDIPAIMAGGM<HFJKEPEKFIF> LLHCFOHMJDD, DDIPAIMAGGM<MJBBEHHNFNA> ECPIPHEMJPF, INFNEOIMIIP FGCNBOMLCIC, bool JPMJMNDALLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x258A570", Offset = "0x2589970", VA = "0x18258A570", Slot = "42")]
	[AsyncStateMachine(typeof(MMALIMDBLNF))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> CDKMDEDODMH(DDIPAIMAGGM<HFJKEPEKFIF> LLHCFOHMJDD, IIIMCLEJECC<MJBBEHHNFNA> ECPIPHEMJPF, List<DDIPAIMAGGM<MJBBEHHNFNA>> KCFHIMCPEKI, INFNEOIMIIP JNOBKKCKMCH, HLENJKBPEOD FGKMCHOJNAK, INFNEOIMIIP FGCNBOMLCIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x258EC40", Offset = "0x258E040", VA = "0x18258EC40", Slot = "45")]
	[AsyncStateMachine(typeof(HPBFFKPLAIA))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> LNMFHKJJFCL(DDIPAIMAGGM<HFJKEPEKFIF> LLHCFOHMJDD, IIIMCLEJECC<MJBBEHHNFNA> ECPIPHEMJPF, List<DDIPAIMAGGM<MJBBEHHNFNA>> KCFHIMCPEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x258B8A0", Offset = "0x258ACA0", VA = "0x18258B8A0", Slot = "46")]
	[AsyncStateMachine(typeof(PIIHAHCLGDN))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> EENLMGKHHOM(DDIPAIMAGGM<HFJKEPEKFIF> LLHCFOHMJDD, IIIMCLEJECC<MJBBEHHNFNA> ECPIPHEMJPF, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, List<DDIPAIMAGGM<MJBBEHHNFNA>> KCFHIMCPEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x258E430", Offset = "0x258D830", VA = "0x18258E430", Slot = "43")]
	public (IReadOnlyDictionary<MJLPFDOLPML, (DDIPAIMAGGM<OPLLODEDJNC>, DDIPAIMAGGM<PINAMAKOAOE>)>, IReadOnlyDictionary<NFKEGFCJKFD, (DDIPAIMAGGM<OPLLODEDJNC>, DDIPAIMAGGM<BFEMAIFODOI>)>) JMHIBIHKDDG(IIIMCLEJECC<HFJKEPEKFIF> KOOADEEIFFF, DDIPAIMAGGM<MJBBEHHNFNA> ECPIPHEMJPF)
	{
		return default((IReadOnlyDictionary<MJLPFDOLPML, (DDIPAIMAGGM<OPLLODEDJNC>, DDIPAIMAGGM<PINAMAKOAOE>)>, IReadOnlyDictionary<NFKEGFCJKFD, (DDIPAIMAGGM<OPLLODEDJNC>, DDIPAIMAGGM<BFEMAIFODOI>)>));
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x258BED0", Offset = "0x258B2D0", VA = "0x18258BED0", Slot = "44")]
	[AsyncStateMachine(typeof(BCOOCPNPCBJ))]
	public Task EOLNGIKOHCJ(IIIMCLEJECC<HFJKEPEKFIF> KOOADEEIFFF, IIIMCLEJECC<MJBBEHHNFNA> ECPIPHEMJPF, IReadOnlyList<IIIMCLEJECC<MJBBEHHNFNA>> CEHCAFNHBMM, IReadOnlyDictionary<MJLPFDOLPML, (DDIPAIMAGGM<OPLLODEDJNC>, DDIPAIMAGGM<PINAMAKOAOE>)> DOFGKICCNHJ, IReadOnlyDictionary<NFKEGFCJKFD, (DDIPAIMAGGM<OPLLODEDJNC>, DDIPAIMAGGM<BFEMAIFODOI>)> DJEAFHLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x258A500", Offset = "0x2589900", VA = "0x18258A500", Slot = "47")]
	public bool CDDGAPABNNE(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2589B50", Offset = "0x2588F50", VA = "0x182589B50", Slot = "48")]
	public bool AENHPECLCAD(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x258F730", Offset = "0x258EB30", VA = "0x18258F730", Slot = "49")]
	public bool NCNKMPJPHOG(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<BIIAPNECPOC> BFKOLDCFMBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x258EE00", Offset = "0x258E200", VA = "0x18258EE00")]
	public PHLGGJNOBDN<HCCJEMAFJIA.JNDCDBJOOHJ, ADKFHONBPGC> MFJLKAKGOEM([In] HCCJEMAFJIA.LBKDPNOIAJO BKIADHLGJLK)
	{
		return default(PHLGGJNOBDN<HCCJEMAFJIA.JNDCDBJOOHJ, ADKFHONBPGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2590270", Offset = "0x258F670", VA = "0x182590270", Slot = "51")]
	[AsyncStateMachine(typeof(CFEHMBLEFMD))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> PEMPEEAPPHK(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<BIIAPNECPOC> FCCDKGKKFDG, DDIPAIMAGGM<HAEPGAFINPD> NBGPCEAFJMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x258D230", Offset = "0x258C630", VA = "0x18258D230", Slot = "52")]
	public PHLGGJNOBDN<FNNBPPLGAKA, MOCCGNOLGDK> IABCIHKCDAO(IIIMCLEJECC<HFJKEPEKFIF> BPHNGBDIGAJ, FNNBPPLGAKA DIKJOPICKGJ, HLENJKBPEOD LIEODBPJDMI)
	{
		return default(PHLGGJNOBDN<FNNBPPLGAKA, MOCCGNOLGDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2589E20", Offset = "0x2589220", VA = "0x182589E20", Slot = "53")]
	[AsyncStateMachine(typeof(IHCKODKCGHO))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> BGFBMKBGDJH(IIIMCLEJECC<HFJKEPEKFIF> BPHNGBDIGAJ, IIIMCLEJECC<MJBBEHHNFNA> CCDNGDMIJEP, DDIPAIMAGGM<OPLLODEDJNC> KPCKEFPHBCG, DDIPAIMAGGM<PINAMAKOAOE> KPKAGMFKFEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x258C760", Offset = "0x258BB60", VA = "0x18258C760", Slot = "54")]
	[AsyncStateMachine(typeof(CJDFBILFJHI))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> FNBKHBKNHFN(IIIMCLEJECC<HFJKEPEKFIF> BPHNGBDIGAJ, IIIMCLEJECC<MJBBEHHNFNA> FCAIFEJHJOG, DDIPAIMAGGM<OPLLODEDJNC> DIMMDKEFKFI, DDIPAIMAGGM<BFEMAIFODOI> BFKOLDCFMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x258B590", Offset = "0x258A990", VA = "0x18258B590", Slot = "55")]
	public EGOOLEAPNKM DCOAJGIKBHP()
	{
		return default(EGOOLEAPNKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x25906B0", Offset = "0x258FAB0", VA = "0x1825906B0", Slot = "56")]
	public EGOOLEAPNKM PPHHGCCPBCD()
	{
		return default(EGOOLEAPNKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x2590410", Offset = "0x258F810", VA = "0x182590410", Slot = "58")]
	public COGFAOEHIFJ PKCDNMGFCGB(PPACMFCOMCD OMJNDKMFMJD, DDIPAIMAGGM<HFJKEPEKFIF> PANNLOGHBIH, IEnumerable<IIIMCLEJECC<HFJKEPEKFIF>> HBAOGCIDPJD, IEnumerable<IIIMCLEJECC<MJBBEHHNFNA>> KCFHIMCPEKI, ISet<IIIMCLEJECC<LICLOCDPKIK>>? EEDIHPCELJD)
	{
		return default(COGFAOEHIFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x258E6E0", Offset = "0x258DAE0", VA = "0x18258E6E0")]
	private COGFAOEHIFJ KMBGAMMIFDE(PPACMFCOMCD OMJNDKMFMJD, DDIPAIMAGGM<HFJKEPEKFIF> PANNLOGHBIH, IEnumerable<IIIMCLEJECC<HFJKEPEKFIF>> HBAOGCIDPJD, IEnumerable<IIIMCLEJECC<MJBBEHHNFNA>> KCFHIMCPEKI, ISet<IIIMCLEJECC<LICLOCDPKIK>>? EEDIHPCELJD)
	{
		return default(COGFAOEHIFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x258A780", Offset = "0x2589B80", VA = "0x18258A780", Slot = "57")]
	public COGFAOEHIFJ CFIJBBHPJEP(PPACMFCOMCD OMJNDKMFMJD, DDIPAIMAGGM<HFJKEPEKFIF> PANNLOGHBIH, IEnumerable<IIIMCLEJECC<MJBBEHHNFNA>> KCFHIMCPEKI, IEnumerable<FMDAPGFGAFB> BLJMJAOHHCI, ISet<IIIMCLEJECC<LICLOCDPKIK>>? EEDIHPCELJD)
	{
		return default(COGFAOEHIFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x258C2B0", Offset = "0x258B6B0", VA = "0x18258C2B0")]
	private static IEnumerable<IIIMCLEJECC<HFJKEPEKFIF>> FEGBMOILJII(IEnumerable<FMDAPGFGAFB> BLJMJAOHHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x258BA00", Offset = "0x258AE00", VA = "0x18258BA00")]
	private IEnumerable<IIIMCLEJECC<MJBBEHHNFNA>> EMCKOHEILHC(IEnumerable<FMDAPGFGAFB> BLJMJAOHHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x258A6F0", Offset = "0x2589AF0", VA = "0x18258A6F0", Slot = "59")]
	public List<KGEIELIAEGB> CFCIBPDICGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x258EF50", Offset = "0x258E350", VA = "0x18258EF50")]
	public (List<KGEIELIAEGB>, bool) MIGBOJCPLOG([In] OGAHDEDPCHF HEJLJBHFACL, string MEBLJIBNLCL, [In] ABLGJAKKLME GJKEJELMNJB, ADFHIBHPJAB LOMJGCBNOIH, AMHPIIEKEFE CPLHPGAPPHO)
	{
		return default((List<KGEIELIAEGB>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x258B730", Offset = "0x258AB30", VA = "0x18258B730", Slot = "61")]
	public bool EDJACGGNAFN(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2589BD0", Offset = "0x2588FD0", VA = "0x182589BD0")]
	internal void AGGOPDPEMIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x2590110", Offset = "0x258F510", VA = "0x182590110")]
	internal Task OIAHCPOCBGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x258D7F0", Offset = "0x258CBF0", VA = "0x18258D7F0", Slot = "62")]
	public PHLGGJNOBDN<DDIPAIMAGGM<BIIAPNECPOC>?, MEENKFHCKIP> IMODECEBEEA(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<MJBBEHHNFNA> JFBLNBCAHJM, DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL)
	{
		return default(PHLGGJNOBDN<DDIPAIMAGGM<BIIAPNECPOC>?, MEENKFHCKIP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x258AB50", Offset = "0x2589F50", VA = "0x18258AB50", Slot = "63")]
	public PHLGGJNOBDN<DDIPAIMAGGM<HAEPGAFINPD>?, MEENKFHCKIP> CIJMJPGEMJK(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<MJBBEHHNFNA> JFBLNBCAHJM, DDIPAIMAGGM<BIIAPNECPOC> BFKOLDCFMBJ)
	{
		return default(PHLGGJNOBDN<DDIPAIMAGGM<HAEPGAFINPD>?, MEENKFHCKIP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x258EAA0", Offset = "0x258DEA0", VA = "0x18258EAA0", Slot = "64")]
	[AsyncStateMachine(typeof(HOIFHBGIDHH))]
	public Task<PHLGGJNOBDN<AOFFOIKPJDJ, MEENKFHCKIP>> LINDMAFPGJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x258FDD0", Offset = "0x258F1D0", VA = "0x18258FDD0", Slot = "7")]
	private bool NNDEJHFKJAL(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, [In] GGNGBBOFIMO HGNAKMGDJDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x258BEA0", Offset = "0x258B2A0", VA = "0x18258BEA0", Slot = "18")]
	private DMEFLICKLLD EMKLKJMOJFA([In] IIIMCLEJECC<HFJKEPEKFIF> BPHNGBDIGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x25906A0", Offset = "0x258FAA0", VA = "0x1825906A0", Slot = "19")]
	private DDIPAIMAGGM<HFJKEPEKFIF> PPABJMCLGLM([In] IIIMCLEJECC<HFJKEPEKFIF> BPHNGBDIGAJ)
	{
		return default(DDIPAIMAGGM<HFJKEPEKFIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2589CB0", Offset = "0x25890B0", VA = "0x182589CB0", Slot = "20")]
	private DDIPAIMAGGM<HFJKEPEKFIF>? BHJDJCFNFGJ([In] IIIMCLEJECC<HFJKEPEKFIF> BPHNGBDIGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x258FAC0", Offset = "0x258EEC0", VA = "0x18258FAC0", Slot = "22")]
	private AGCPOGDEIKB NEPMBPLKEGC([In] IIIMCLEJECC<MJBBEHHNFNA> JFBLNBCAHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x258D0D0", Offset = "0x258C4D0", VA = "0x18258D0D0", Slot = "24")]
	private DDIPAIMAGGM<MJBBEHHNFNA> KCLEJNBGAPD(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, [In] IIIMCLEJECC<MJBBEHHNFNA> FOHLLKAKDOB)
	{
		return default(DDIPAIMAGGM<MJBBEHHNFNA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x258E930", Offset = "0x258DD30", VA = "0x18258E930", Slot = "38")]
	private IKHKBDGBIAI LGBKOADEBIN(DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, [In] GGNGBBOFIMO HGNAKMGDJDJ)
	{
		return default(IKHKBDGBIAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x258EE00", Offset = "0x258E200", VA = "0x18258EE00", Slot = "50")]
	private PHLGGJNOBDN<HCCJEMAFJIA.JNDCDBJOOHJ, ADKFHONBPGC> PFFMIMFJJEA([In] HCCJEMAFJIA.LBKDPNOIAJO BKIADHLGJLK)
	{
		return default(PHLGGJNOBDN<HCCJEMAFJIA.JNDCDBJOOHJ, ADKFHONBPGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x258C250", Offset = "0x258B650", VA = "0x18258C250", Slot = "60")]
	private (List<KGEIELIAEGB>, bool) FCCCDCNAMBO([In] OGAHDEDPCHF HEJLJBHFACL, string MEBLJIBNLCL, [In] ABLGJAKKLME GJKEJELMNJB, ADFHIBHPJAB LOMJGCBNOIH, AMHPIIEKEFE CPLHPGAPPHO)
	{
		return default((List<KGEIELIAEGB>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x2589D30", Offset = "0x2589130", VA = "0x182589D30")]
	[CompilerGenerated]
	private DKAHLKKMFFK BEFCECJLCJO(GBHOAMIGJIM ILOCIBNKPPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2589DB0", Offset = "0x25891B0", VA = "0x182589DB0")]
	[CompilerGenerated]
	private PEEGBFKPCLP BGCOEDFHKPF(IIIMCLEJECC<MJBBEHHNFNA> ILOCIBNKPPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x258D060", Offset = "0x258C460", VA = "0x18258D060")]
	[CompilerGenerated]
	private PNKCBINOOLI HEOLGKBPKKK(IIIMCLEJECC<HFJKEPEKFIF> ILOCIBNKPPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x258C630", Offset = "0x258BA30", VA = "0x18258C630")]
	[CompilerGenerated]
	private PEEGBFKPCLP FEMBNLNHKJO(IIIMCLEJECC<MJBBEHHNFNA> ILOCIBNKPPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x258C8C0", Offset = "0x258BCC0", VA = "0x18258C8C0")]
	[CompilerGenerated]
	private PNKCBINOOLI FNDIOPAHACH(IIIMCLEJECC<HFJKEPEKFIF> ILOCIBNKPPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class DKAHLKKMFFK : AMDOGBLKLIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct GKDPECKINFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<DDIPAIMAGGM<PEBJCIAAJKE>, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public DKAHLKKMFFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public IIIMCLEJECC<HFJKEPEKFIF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public IIIMCLEJECC<MJBBEHHNFNA> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public DDIPAIMAGGM<OPLLODEDJNC> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private TaskAwaiter<PHLGGJNOBDN<DDIPAIMAGGM<PEBJCIAAJKE>, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x25A7D80", Offset = "0x25A7180", VA = "0x1825A7D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x25A8000", Offset = "0x25A7400", VA = "0x1825A8000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct OBMPKLBJNAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<DDIPAIMAGGM<EGDOMAELJCE>, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public DKAHLKKMFFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public IIIMCLEJECC<HFJKEPEKFIF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public IIIMCLEJECC<MJBBEHHNFNA> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public DDIPAIMAGGM<OPLLODEDJNC> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private TaskAwaiter<PHLGGJNOBDN<DDIPAIMAGGM<EGDOMAELJCE>, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x25A9960", Offset = "0x25A8D60", VA = "0x1825A9960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x25A9BE0", Offset = "0x25A8FE0", VA = "0x1825A9BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private readonly GBHOAMIGJIM HPKJMLLIMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private readonly HBGCPCDJMAM LEJIPHKGPED;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public TypeKey CFHEMNMAGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xAE5990", Offset = "0xAE4D90", VA = "0x180AE5990", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public string EOBMCCNNFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x25A6410", Offset = "0x25A5810", VA = "0x1825A6410", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public GBHOAMIGJIM DNLOLAIGODA
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x25A7A90", Offset = "0x25A6E90", VA = "0x1825A7A90")]
	public DKAHLKKMFFK(GBHOAMIGJIM EBMAGINFGAO, HBGCPCDJMAM HOIGHFACGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x25A77B0", Offset = "0x25A6BB0", VA = "0x1825A77B0", Slot = "6")]
	[AsyncStateMachine(typeof(GKDPECKINFF))]
	public Task<PHLGGJNOBDN<DDIPAIMAGGM<PEBJCIAAJKE>, MEENKFHCKIP>> EMNNKGLBKHP(IIIMCLEJECC<HFJKEPEKFIF> BPHNGBDIGAJ, IIIMCLEJECC<MJBBEHHNFNA> JFBLNBCAHJM, DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, string OGOCCCFKJPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x25A7920", Offset = "0x25A6D20", VA = "0x1825A7920", Slot = "7")]
	[AsyncStateMachine(typeof(OBMPKLBJNAH))]
	public Task<PHLGGJNOBDN<DDIPAIMAGGM<EGDOMAELJCE>, MEENKFHCKIP>> MHCCHKLLHBG(IIIMCLEJECC<HFJKEPEKFIF> BPHNGBDIGAJ, IIIMCLEJECC<MJBBEHHNFNA> JFBLNBCAHJM, DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK, string OGOCCCFKJPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class DJLNGMHBIKC : GHGFNKIPOAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private readonly GBHOAMIGJIM DLJAHPJAFDH;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private static readonly HashSet<GBHOAMIGJIM> IKHDLJCIJPM;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private static readonly HashSet<GBHOAMIGJIM> CNKFOGEPHIJ;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private static readonly HashSet<GBHOAMIGJIM> OCIPOCHOJNI;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TypeKey AMKBEFCENEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x25A7640", Offset = "0x25A6A40", VA = "0x1825A7640", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool CLNEEAABBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x25A7630", Offset = "0x25A6A30", VA = "0x1825A7630", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool NFDMIMILEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x25A7690", Offset = "0x25A6A90", VA = "0x1825A7690", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool BOBGHMPJGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x25A75B0", Offset = "0x25A69B0", VA = "0x1825A75B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x25A6010", Offset = "0x25A5410", VA = "0x1825A6010")]
	public bool DCOFCMLKDBO(string PEBNJNGMMHE, [Out] MHHOODJHFEI KCPDEMEBNNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	public DJLNGMHBIKC(GBHOAMIGJIM FBFIKJCNBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x25A6280", Offset = "0x25A5680", VA = "0x1825A6280")]
	internal static TypeKey ENGODOJOJLF(GBHOAMIGJIM ANONBNLNHHL)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x25A6410", Offset = "0x25A5810", VA = "0x1825A6410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public readonly struct BGBEIPHADNE : JPKEPBEMGCD.FFIMPOKJGII<CLANKEGLHHM, AOFFOIKPJDJ>
{
	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x25A4820", Offset = "0x25A3C20", VA = "0x1825A4820", Slot = "4")]
	public int JDNLMJDFAFM(AOFFOIKPJDJ NCCMNNBGHEA, CLANKEGLHHM NJNJGNMEACN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x25A4810", Offset = "0x25A3C10", VA = "0x1825A4810", Slot = "5")]
	public CLANKEGLHHM IAFAFNJHPMC(AOFFOIKPJDJ NCCMNNBGHEA, CLANKEGLHHM NJNJGNMEACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x25A48A0", Offset = "0x25A3CA0", VA = "0x1825A48A0", Slot = "6")]
	public CLANKEGLHHM OOEPECONFLJ(AOFFOIKPJDJ NCCMNNBGHEA, CLANKEGLHHM NJNJGNMEACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x25A4880", Offset = "0x25A3C80", VA = "0x1825A4880", Slot = "7")]
	public IReadOnlyList<CLANKEGLHHM> ONLCKJAKEOA(AOFFOIKPJDJ NCCMNNBGHEA, CLANKEGLHHM NJNJGNMEACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x25A48D0", Offset = "0x25A3CD0", VA = "0x1825A48D0", Slot = "8")]
	public CLANKEGLHHM[] PGKEJOOAPPB(AOFFOIKPJDJ NCCMNNBGHEA, CLANKEGLHHM NJNJGNMEACN, int FNHKHGHAKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x25A47B0", Offset = "0x25A3BB0", VA = "0x1825A47B0", Slot = "9")]
	public bool DDGOKJHNFCP(AOFFOIKPJDJ NCCMNNBGHEA, CLANKEGLHHM NJNJGNMEACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x25A4790", Offset = "0x25A3B90", VA = "0x1825A4790", Slot = "10")]
	public bool DDBHLBMCAKD(AOFFOIKPJDJ NCCMNNBGHEA, CLANKEGLHHM NJNJGNMEACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x25A47D0", Offset = "0x25A3BD0", VA = "0x1825A47D0", Slot = "11")]
	public bool EOAHNNEEMDL(AOFFOIKPJDJ NCCMNNBGHEA, CLANKEGLHHM NJNJGNMEACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x25A4860", Offset = "0x25A3C60", VA = "0x1825A4860", Slot = "12")]
	public bool LHNHNMLOGPB(AOFFOIKPJDJ NCCMNNBGHEA, CLANKEGLHHM NJNJGNMEACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x25A4840", Offset = "0x25A3C40", VA = "0x1825A4840", Slot = "13")]
	public bool JLOEDNNINAI(AOFFOIKPJDJ FDMNIIJFCMI, CLANKEGLHHM NJNJGNMEACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x25A47F0", Offset = "0x25A3BF0", VA = "0x1825A47F0", Slot = "14")]
	public bool FMMFEKEJAHP(AOFFOIKPJDJ NCCMNNBGHEA, CLANKEGLHHM NJNJGNMEACN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public abstract class DHAAAKOKGGO : OANAJCCOJAC
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public ILKMIOOGCOB.EHPJJLGHBOE NGDICHKCLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x25A5FC0", Offset = "0x25A53C0", VA = "0x1825A5FC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract CFMFKDDNKAJ.HDBAEIJFPJI JPLAAGPKBME
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract NKCIHNNLLKD.DHFEHCPECKO PFKBHOEOBND
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract NLBLNAEPKLK.DFFDFJNJFKF BELOFBOPGLI
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public DPEINBLHDDE.AAMEMANMBDM<LOKGKIKHLGA, CLANKEGLHHM, NKCIHNNLLKD> GAFIOAODHMM
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x25A5F70", Offset = "0x25A5370", VA = "0x1825A5F70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract DAKCFEAIFAM.EKCDIEEEGBJ LCLDHONDNDB
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract BEEAEKGKICI AFLGMJPAKOG
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract JKNEJPMEIIO KDEPEJEBNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public abstract ELJEIFDODCL FKNCKPGKMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public abstract BHCGEAFMBGC PBNBIEICHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public abstract MJLHKINPHPH PCKEMGCNPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	protected DHAAAKOKGGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class OHBIGLGFHJJ : ADAKCEGDIMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private struct CJEIIGFINKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<object, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public OHBIGLGFHJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public CLANKEGLHHM action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter<PHLGGJNOBDN<object, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x25A5C40", Offset = "0x25A5040", VA = "0x1825A5C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x25A5EE0", Offset = "0x25A52E0", VA = "0x1825A5EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct NJMCIHHCLPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<PIPILNCCEGE, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public OHBIGLGFHJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public IReadOnlyList<CLANKEGLHHM> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private TaskAwaiter<PHLGGJNOBDN<object, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x25A9570", Offset = "0x25A8970", VA = "0x1825A9570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x25A98F0", Offset = "0x25A8CF0", VA = "0x1825A98F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly DDLFMPNBOMD LOFJNOAIFAL;

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	public OHBIGLGFHJJ(DDLFMPNBOMD APBFOEBCMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x25A9D80", Offset = "0x25A9180", VA = "0x1825A9D80")]
	[AsyncStateMachine(typeof(CJEIIGFINKF))]
	private Task<PHLGGJNOBDN<object, MEENKFHCKIP>> FCJMDEBFNEC(CLANKEGLHHM NJNJGNMEACN, bool GIKCANOKEJN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x25A9C50", Offset = "0x25A9050", VA = "0x1825A9C50", Slot = "4")]
	[AsyncStateMachine(typeof(NJMCIHHCLPN))]
	public Task<PHLGGJNOBDN<PIPILNCCEGE, MEENKFHCKIP>> DKFLKEDNCIO(IReadOnlyList<CLANKEGLHHM> LNLIOHBEPFC, bool GIKCANOKEJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public struct GAMGKOKDNJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	internal NNFFDCFDMAK<CHDNCIEHFCE, IIIMCLEJECC<CHDNCIEHFCE.ANIJNDMMDFN>, CLANKEGLHHM, DONDEMJPINB> DLJAHPJAFDH;

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x256B010", Offset = "0x256A410", VA = "0x18256B010")]
	private GAMGKOKDNJP([In] NNFFDCFDMAK<CHDNCIEHFCE, IIIMCLEJECC<CHDNCIEHFCE.ANIJNDMMDFN>, CLANKEGLHHM, DONDEMJPINB> KFAJCNEFKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x25A7D20", Offset = "0x25A7120", VA = "0x1825A7D20")]
	public static GAMGKOKDNJP KMDIICJFNJF()
	{
		return default(GAMGKOKDNJP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public static class LFDECLAKMLB
{
	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
	public static NNFFDCFDMAK<CHDNCIEHFCE, IIIMCLEJECC<CHDNCIEHFCE.ANIJNDMMDFN>, CLANKEGLHHM, DONDEMJPINB> GBHPEMEJJNM(this GAMGKOKDNJP IIICNLIAPBJ)
	{
		return default(NNFFDCFDMAK<CHDNCIEHFCE, IIIMCLEJECC<CHDNCIEHFCE.ANIJNDMMDFN>, CLANKEGLHHM, DONDEMJPINB>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct DONDEMJPINB : JGFNJLKGLAK.GBMHIDDOGED<CHDNCIEHFCE, IIIMCLEJECC<CHDNCIEHFCE.ANIJNDMMDFN>, CLANKEGLHHM>
{
	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x25A7B30", Offset = "0x25A6F30", VA = "0x1825A7B30", Slot = "7")]
	public CLANKEGLHHM AHOPDPELKDN(CHDNCIEHFCE[] AJOOLJIDONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0xF328A0", Offset = "0xF31CA0", VA = "0x180F328A0")]
	public IIIMCLEJECC<CHDNCIEHFCE.ANIJNDMMDFN> HCIMNAPCJBL([In] CHDNCIEHFCE PIOJPAPNDDP)
	{
		return default(IIIMCLEJECC<CHDNCIEHFCE.ANIJNDMMDFN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0xF4DCB0", Offset = "0xF4D0B0", VA = "0x180F4DCB0")]
	public int PHBLALAAOOB([In] CHDNCIEHFCE BGDLHIAOBHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x25A7D10", Offset = "0x25A7110", VA = "0x1825A7D10")]
	public int OKKKLBLHMGH([In] CHDNCIEHFCE PIOJPAPNDDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0xF4DCB0", Offset = "0xF4D0B0", VA = "0x180F4DCB0", Slot = "4")]
	private int CHEKDIGECGL([In] CHDNCIEHFCE PIOJPAPNDDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x25A7D10", Offset = "0x25A7110", VA = "0x1825A7D10", Slot = "5")]
	private int BOBCAJLDGOG([In] CHDNCIEHFCE PIOJPAPNDDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0xF328A0", Offset = "0xF31CA0", VA = "0x180F328A0", Slot = "6")]
	private IIIMCLEJECC<CHDNCIEHFCE.ANIJNDMMDFN> BFIPAAGIFBO([In] CHDNCIEHFCE PIOJPAPNDDP)
	{
		return default(IIIMCLEJECC<CHDNCIEHFCE.ANIJNDMMDFN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public struct JAAFGAAHHPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	internal NEOHKIFFOFG<PNNHPPGJKOL, CLANKEGLHHM, IDCDKNIMBBF> DLJAHPJAFDH;

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x256B010", Offset = "0x256A410", VA = "0x18256B010")]
	private JAAFGAAHHPE([In] NEOHKIFFOFG<PNNHPPGJKOL, CLANKEGLHHM, IDCDKNIMBBF> FIOILLPCBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x25A8C70", Offset = "0x25A8070", VA = "0x1825A8C70")]
	public static JAAFGAAHHPE KMDIICJFNJF()
	{
		return default(JAAFGAAHHPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class LALLAFMHBCE
{
	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
	public static NEOHKIFFOFG<PNNHPPGJKOL, CLANKEGLHHM, IDCDKNIMBBF> GBHPEMEJJNM(this JAAFGAAHHPE IIICNLIAPBJ)
	{
		return default(NEOHKIFFOFG<PNNHPPGJKOL, CLANKEGLHHM, IDCDKNIMBBF>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public struct IDCDKNIMBBF : CJJMGPLBDGB.MIDCCPFOFNM<PNNHPPGJKOL, CLANKEGLHHM>
{
	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x1F83240", Offset = "0x1F82640", VA = "0x181F83240")]
	public int EACNHMOLILI([In] PNNHPPGJKOL BGDLHIAOBHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x25A85D0", Offset = "0x25A79D0", VA = "0x1825A85D0", Slot = "5")]
	public CLANKEGLHHM ELMOOMEKDLJ(PNNHPPGJKOL[] NFAFLNGCFIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x1F83240", Offset = "0x1F82640", VA = "0x181F83240", Slot = "4")]
	private int PGBKFEBOHPP([In] PNNHPPGJKOL BGDLHIAOBHD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class JOKBAHJOEIF : OGPHAGHJAIC, ADKFHONBPGC, MEENKFHCKIP, MOCCGNOLGDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private readonly MOCCGNOLGDK? AGADEOHGKAB;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public JEGABILFNGK NMKEFHILICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x9712B0", Offset = "0x9706B0", VA = "0x1809712B0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(JEGABILFNGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x973060", Offset = "0x972460", VA = "0x180973060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public override MOCCGNOLGDK? LCCLGMNLAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x25A8F90", Offset = "0x25A8390", VA = "0x1825A8F90", Slot = "7")]
	public override string CMLLJBLPAFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x25A9200", Offset = "0x25A8600", VA = "0x1825A9200")]
	private JOKBAHJOEIF(JEGABILFNGK CALDBNGCNDJ, MOCCGNOLGDK? BCOJLPJMFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x25A9180", Offset = "0x25A8580", VA = "0x1825A9180")]
	public static JOKBAHJOEIF MLJKEENCBJB(MOCCGNOLGDK BCOJLPJMFBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x25A9110", Offset = "0x25A8510", VA = "0x1825A9110")]
	public static JOKBAHJOEIF KBMEFFDOBBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x25A90A0", Offset = "0x25A84A0", VA = "0x1825A90A0")]
	public static JOKBAHJOEIF GBGKAGFGHOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public static class KNNHAJBFDGK
{
	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x354F830", Offset = "0x354EC30", VA = "0x18354F830")]
	public static PHLGGJNOBDN<TOk, ADKFHONBPGC> EJGIIEFOAGO<TOk>([In] this PHLGGJNOBDN<TOk, ADKFHONBPGC> IIICNLIAPBJ, MOCCGNOLGDK BCOJLPJMFBP) where TOk : notnull
	{
		return default(PHLGGJNOBDN<TOk, ADKFHONBPGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x354F730", Offset = "0x354EB30", VA = "0x18354F730")]
	public static PHLGGJNOBDN<TOk?, ADKFHONBPGC?> DDNIBDJIIIN<TOk>([In] this PHLGGJNOBDN<TOk, ADKFHONBPGC> IIICNLIAPBJ)
	{
		return default(PHLGGJNOBDN<TOk, ADKFHONBPGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x354F920", Offset = "0x354ED20", VA = "0x18354F920")]
	public static PHLGGJNOBDN<TOk?, ADKFHONBPGC?> FNJGMAICPMB<TOk>([In] this PHLGGJNOBDN<TOk, ADKFHONBPGC> IIICNLIAPBJ)
	{
		return default(PHLGGJNOBDN<TOk, ADKFHONBPGC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public interface BEEAEKGKICI
{
	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALBLBMJCNAD([In] PHLGGJNOBDN<AOFFOIKPJDJ, MOCCGNOLGDK> HOCIBOCHCFJ);
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public static class IMOHKCBBCJA
{
	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x3508DD0", Offset = "0x35081D0", VA = "0x183508DD0")]
	public static bool ALBLBMJCNAD<TOk, TErr>(this BEEAEKGKICI IIICNLIAPBJ, [In] PHLGGJNOBDN<TOk, TErr> HOCIBOCHCFJ) where TOk : notnull where TErr : notnull, MOCCGNOLGDK
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public interface JKNEJPMEIIO
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	NFPCDKONFNJ GIOHJEHBFKG
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public interface ELJEIFDODCL
{
	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IPJFNEFALHK CEGNBNHHLCL(int NPJNOPHGDLF);
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public interface CBPFGCKMJKA
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	string NAMECGEJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public interface MKIFGIDCAMP
{
	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MJKFHHFHHGA? LKJAAJPDHPA(DDIPAIMAGGM<OPLLODEDJNC> IKEJLCKIJDK);
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface PANFHGJGBBE
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	string NAMECGEJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface MJKFHHFHHGA
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	string NAMECGEJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PANFHGJGBBE? DDCDDMGDKOH(DDIPAIMAGGM<PEBJCIAAJKE> OCGFCPNBLBK);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CBPFGCKMJKA? KHLILPHLEFM(DDIPAIMAGGM<EGDOMAELJCE> BLINDGLNPJJ);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface BHCGEAFMBGC
{
	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> CAHEGOBHIFI(string PEBNJNGMMHE, string MEBLJIBNLCL);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface MJLHKINPHPH
{
	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MKIFGIDCAMP? AANHHMHLKKE([In] IIIMCLEJECC<PKJLNCOHJCL> BNCMPOJKPPA);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class CBHECCFHEAD
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private struct IGBMBPCPOAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public int NGGCGOFGPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public EBPMLNHKOOL? KIANDFEKNDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public EBPMLNHKOOL? BNGLOJPHHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public readonly List<CLANKEGLHHM> NMMOBOHHPFI;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x25A8870", Offset = "0x25A7C70", VA = "0x1825A8870")]
		private IGBMBPCPOAN(int FFCBHHABFJN, EBPMLNHKOOL? BDMLJCDFLCD, EBPMLNHKOOL? DOCFGJOMGFA, List<CLANKEGLHHM> LNLIOHBEPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x25A87B0", Offset = "0x25A7BB0", VA = "0x1825A87B0")]
		public static IGBMBPCPOAN KMDIICJFNJF()
		{
			return default(IGBMBPCPOAN);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private readonly EMJBJDEPDNG<IGBMBPCPOAN> EKJDPBCBHGH;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public static CBHECCFHEAD AJPLFLPAHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x25A4FD0", Offset = "0x25A43D0", VA = "0x1825A4FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool MINENKHDJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xB8D840", Offset = "0xB8CC40", VA = "0x180B8D840")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xB8D080", Offset = "0xB8C480", VA = "0x180B8D080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x25A48E0", Offset = "0x25A3CE0", VA = "0x1825A48E0")]
	public void BJHPMCKCDFL(IFOMDBLACAN DOCFGJOMGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x25A4CE0", Offset = "0x25A40E0", VA = "0x1825A4CE0")]
	public void KJFAGDKKDNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x25A49A0", Offset = "0x25A3DA0", VA = "0x1825A49A0")]
	private static string? CJCBJEMPKFJ([In] IGBMBPCPOAN HMDLKFIKABP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x25A5120", Offset = "0x25A4520", VA = "0x1825A5120")]
	public CBHECCFHEAD()
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
