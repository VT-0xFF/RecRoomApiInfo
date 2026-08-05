using System;
using System.Collections.Generic;
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
using RecRoom.Logging.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3420", Offset = "0x6DA2820", VA = "0x186DA3420")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6DA28F0", Offset = "0x6DA1CF0", VA = "0x186DA28F0", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6DA5280", Offset = "0x6DA4680", VA = "0x186DA5280", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface APMHFNKACFF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> KHFDKFKHADD();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DEPEDNPEKLC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D9EA00", Offset = "0x6D9DE00", VA = "0x186D9EA00")]
	public static void OFCIJBLMJIK(this ALFPIOBHACG.AOABGKKMKAF JGKNDGLLBMC, string KFJDDHHDNIN, string ENNCEAHDBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6D9EA70", Offset = "0x6D9DE70", VA = "0x186D9EA70")]
	public static void OFCIJBLMJIK(this ALFPIOBHACG.AOABGKKMKAF JGKNDGLLBMC, string KFJDDHHDNIN, bool ENNCEAHDBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6D9EB00", Offset = "0x6D9DF00", VA = "0x186D9EB00")]
	public static void OFCIJBLMJIK(this ALFPIOBHACG.AOABGKKMKAF JGKNDGLLBMC, string KFJDDHHDNIN, float FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6D9E6B0", Offset = "0x6D9DAB0", VA = "0x186D9E6B0")]
	public static void OFCIJBLMJIK(this ALFPIOBHACG.AOABGKKMKAF JGKNDGLLBMC, string KFJDDHHDNIN, MMNGFEBKGLC ENNCEAHDBCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ALFPIOBHACG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface OHAHPCECFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AOABGKKMKAF FMNOJHGOMHM(Guid HCKHGINLCBI, string POFHFOIBCDD, [Optional] string LJFMFHIMODL, [Optional] long? AJDLLPFIPBC, [Optional] string CCGMBFGAKLK, [Optional] string PELOBFMCILP);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class GAPAPIEGPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D9F1A0", Offset = "0x6D9E5A0", VA = "0x186D9F1A0")]
		public static AOABGKKMKAF AEJIHDAHFEC(Guid HCKHGINLCBI, string POFHFOIBCDD, string LJFMFHIMODL, [Optional] long? AJDLLPFIPBC, [Optional] string CCGMBFGAKLK, [Optional] string PELOBFMCILP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AOABGKKMKAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected KFCLOHPGAGH JNDPCNNCNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> IKHACHPEGHJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NLDDMFPNODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C860", Offset = "0x6D9BC60", VA = "0x186D9C860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string HKNJCKHOCFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xFE24B0", Offset = "0xFE18B0", VA = "0x180FE24B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C930", Offset = "0x6D9BD30", VA = "0x186D9C930")]
		public AOABGKKMKAF(KFCLOHPGAGH JNDPCNNCNMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C110", Offset = "0x6D9B510", VA = "0x186D9C110")]
		public AOABGKKMKAF ALENPICKODA(string ODLMGDFMFJG, string FIIKLGCIAGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3CFA1C0", Offset = "0x3CF95C0", VA = "0x183CFA1C0")]
		public AOABGKKMKAF ALENPICKODA<T>(string ODLMGDFMFJG, T FIIKLGCIAGG) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C420", Offset = "0x6D9B820", VA = "0x186D9C420")]
		public AOABGKKMKAF DNJBJJIIJKE(string ODLMGDFMFJG, object FIIKLGCIAGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3CFA550", Offset = "0x3CF9950", VA = "0x183CFA550")]
		public AOABGKKMKAF PBOIJGCIFAM<T>(string ODLMGDFMFJG, T? FIIKLGCIAGG) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C8A0", Offset = "0x6D9BCA0", VA = "0x186D9C8A0")]
		public AOABGKKMKAF PBOIJGCIFAM(string ODLMGDFMFJG, string FIIKLGCIAGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C270", Offset = "0x6D9B670", VA = "0x186D9C270")]
		public AOABGKKMKAF BGCIKKFJDBD(string ANEPNOIKMFB, string MCBJECJLDOM, object AMHCLKHIFKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C190", Offset = "0x6D9B590", VA = "0x186D9C190")]
		public AOABGKKMKAF BGCIKKFJDBD(string ANEPNOIKMFB, IDictionary<string, object> OBLBKNNLCEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C3C0", Offset = "0x6D9B7C0", VA = "0x186D9C3C0")]
		private static IDictionary<string, object> DDGACKIICEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C4A0", Offset = "0x6D9B8A0", VA = "0x186D9C4A0")]
		public void JJIPKJDMABH(bool OOKEBJGLGIO, string CAILNNPGEDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C760", Offset = "0x6D9BB60", VA = "0x186D9C760")]
		public Task KJCACHOOBFA([Optional] CancellationToken BLABAMPAGAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x26346D0", Offset = "0x2633AD0", VA = "0x1826346D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KFCLOHPGAGH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct AKAGKIALBNA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public KFCLOHPGAGH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6D9B610", Offset = "0x6D9AA10", VA = "0x186D9B610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BA80", Offset = "0x6D9AE80", VA = "0x186D9BA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<KFCLOHPGAGH> JFCGFHLFDPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string KBAABECKKLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> LBEHDMMDOIP;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string HKNJCKHOCFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6DA1190", Offset = "0x6DA0590", VA = "0x186DA1190")]
		private KFCLOHPGAGH(string KBAABECKKLP, int OJKFBILBJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6D9BAE0", Offset = "0x6D9AEE0", VA = "0x186D9BAE0")]
		public static AOABGKKMKAF DCJNBNANGBG(string KBAABECKKLP, int OJKFBILBJGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0F70", Offset = "0x6DA0370", VA = "0x186DA0F70")]
		[AsyncStateMachine(typeof(AKAGKIALBNA))]
		public Task KJCACHOOBFA([Optional] CancellationToken BLABAMPAGAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6DA1120", Offset = "0x6DA0520", VA = "0x186DA1120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x34013B0", Offset = "0x34007B0", VA = "0x1834013B0")]
		internal void MGLLGAIGOOF<T>(string ODLMGDFMFJG, T FIIKLGCIAGG) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6DA1060", Offset = "0x6DA0460", VA = "0x186DA1060")]
		internal void LHBGNPJEAOM(string ODLMGDFMFJG, object FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6DA10C0", Offset = "0x6DA04C0", VA = "0x186DA10C0")]
		internal void MGLLGAIGOOF(string ODLMGDFMFJG, string FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3D01960", Offset = "0x3D00D60", VA = "0x183D01960")]
		private void MMPHPPGHPAC<T>(string ODLMGDFMFJG, T FIIKLGCIAGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct BCPKIKNEMHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string JBMHIHPIEEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? BKLLPDKHGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? MGPBJBMHJOH;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C9D0", Offset = "0x6D9BDD0", VA = "0x186D9C9D0")]
		public BCPKIKNEMHF(string CHOIJBELBCK, [Optional] long? CCHPCHDJHAI, [Optional] short? KDPLNOOPNDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct JNMABGGAJIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int KIEJDFEEOJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string GPCLBEFDLPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short PCINFKCOAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string ELFINHIGHEI;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0470", Offset = "0x6D9F870", VA = "0x186DA0470")]
		public JNMABGGAJIH(int MFMDDKDHEDM, string LOJFLGHHFNI, short PHKINAJOCKE, string FEIPIAFIILB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class BHIPDHGPBDJ : AHNCPOGCMGN<ABNLKLCOPGP, JNMABGGAJIH, BCPKIKNEMHF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string LOJFLGHHFNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short PHKINAJOCKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string FEIPIAFIILB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> CIDMIAIKOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int NJCIAOPLEIC;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6D9DE80", Offset = "0x6D9D280", VA = "0x186D9DE80")]
		public BHIPDHGPBDJ(string BFOPMPHFJHJ, Guid GJNNGFNIDGE, long ICHOMOMIDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D800", Offset = "0x6D9CC00", VA = "0x186D9D800", Slot = "4")]
		public override void MGNPGMAJMPD(JNMABGGAJIH JGFOFEAGJPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6D9DAF0", Offset = "0x6D9CEF0", VA = "0x186D9DAF0")]
		public void NIBIMBHAIBA(short PHKINAJOCKE, bool NJFGBBOJEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x46B1B10", Offset = "0x46B0F10", VA = "0x1846B1B10")]
		public void FNHPOOJBDFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9932B0", Offset = "0x9926B0", VA = "0x1809932B0")]
		public void KCEIIDDIPOJ(string PPENPBFFLOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CA10", Offset = "0x6D9BE10", VA = "0x186D9CA10", Slot = "5")]
		public override void LFJOFHFMPHF(bool CEFDEHIJHOH, BCPKIKNEMHF FBJPMPAPJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6D9DBD0", Offset = "0x6D9CFD0", VA = "0x186D9DBD0", Slot = "6")]
		public override CJKINDOBOHN OHCFKOFJBBI(ABNLKLCOPGP HCPAAKJCOMN, int KDCAMOIGIMA, string NGGDGEGELFB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class GFPMCKELGGL : CJKINDOBOHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string LOJFLGHHFNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short PHKINAJOCKE;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6D9F560", Offset = "0x6D9E960", VA = "0x186D9F560")]
		public GFPMCKELGGL(long BLEHHCPCAAJ, int MFMDDKDHEDM, string LJFMFHIMODL, long ICHOMOMIDAH, int EIJKJJKIINE, string CCGMBFGAKLK, short PHKINAJOCKE, string LOJFLGHHFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6D9F4E0", Offset = "0x6D9E8E0", VA = "0x186D9F4E0")]
		public void JADBGLHMGCC(int MFMDDKDHEDM, string LOJFLGHHFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6D9F3B0", Offset = "0x6D9E7B0", VA = "0x186D9F3B0", Slot = "5")]
		public override AOABGKKMKAF FMNOJHGOMHM(Guid HCKHGINLCBI, string POFHFOIBCDD, [Optional] string LJFMFHIMODL, [Optional] long? AJDLLPFIPBC, [Optional] string CCGMBFGAKLK, [Optional] string PELOBFMCILP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class KMDFOMIJCLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class HAGHCPGONEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public HAGHCPGONEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6D9F650", Offset = "0x6D9EA50", VA = "0x186D9F650")]
			internal bool IMILJMFFPDG()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct HJEBFKLDGLH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private HAGHCPGONEH <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6D9F6F0", Offset = "0x6D9EAF0", VA = "0x186D9F6F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6DA03B0", Offset = "0x6D9F7B0", VA = "0x186DA03B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct JOPLBHANBPB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool isForcedEvent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6DA04C0", Offset = "0x6D9F8C0", VA = "0x186DA04C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6DA0A40", Offset = "0x6D9FE40", VA = "0x186DA0A40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float PCOFDICNCHK;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static KIKFEAEKMGH GOOAHAMPCLE;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource EJHLGJLBNOE;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool EIMNFEHCKHD;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int IEHHOEMHMLE;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly ABNIGPKKHEA<AOABGKKMKAF, bool> CBPMFGECOBJ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static IFIPMEBIOFP<AOABGKKMKAF, bool> FJAEKEIAKIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6DA1BE0", Offset = "0x6DA0FE0", VA = "0x186DA1BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool DCJCHKFFALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6DA15E0", Offset = "0x6DA09E0", VA = "0x186DA15E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6DA14D0", Offset = "0x6DA08D0", VA = "0x186DA14D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool APBJBLNNLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6DA1590", Offset = "0x6DA0990", VA = "0x186DA1590")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6DA2260", Offset = "0x6DA1660", VA = "0x186DA2260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float OJIPOHFPCID
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6DA1B90", Offset = "0x6DA0F90", VA = "0x186DA1B90")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6DA1530", Offset = "0x6DA0930", VA = "0x186DA1530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2500", Offset = "0x6DA1900", VA = "0x186DA2500")]
		[FGALJGDFECK.NDOKACNFLAD]
		internal static void PDFECDIDEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6DA22C0", Offset = "0x6DA16C0", VA = "0x186DA22C0")]
		internal static void MBHBIOMKKEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6DA1FE0", Offset = "0x6DA13E0", VA = "0x186DA1FE0")]
		internal static void LDOICLPCMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6DA24A0", Offset = "0x6DA18A0", VA = "0x186DA24A0")]
		internal static void MMLBCLBDLEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6DA1630", Offset = "0x6DA0A30", VA = "0x186DA1630")]
		public static void FACAFGBCEJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6DA1760", Offset = "0x6DA0B60", VA = "0x186DA1760")]
		private static void HDOIEACJENH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6DA1D00", Offset = "0x6DA1100", VA = "0x186DA1D00")]
		private static void KNJDFCJLPIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6DA1C30", Offset = "0x6DA1030", VA = "0x186DA1C30")]
		[AsyncStateMachine(typeof(HJEBFKLDGLH))]
		private static Task JHEHOBMIFPC(CancellationToken BLABAMPAGAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2190", Offset = "0x6DA1590", VA = "0x186DA2190")]
		private static void LKBBKPLFFOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6DA1680", Offset = "0x6DA0A80", VA = "0x186DA1680")]
		[AsyncStateMachine(typeof(JOPLBHANBPB))]
		private static Task FFINNKIOGOP(bool OCAKMALOMOD, [Optional] CancellationToken BLABAMPAGAH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class HFCBBJOANME<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class BBIJLJCLOBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public HFCBBJOANME<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public BBIJLJCLOBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5B5ABA0", Offset = "0x5B59FA0", VA = "0x185B5ABA0")]
			internal object CGBBPAHCICB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class NCJDPOOMKJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public HFCBBJOANME<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public NCJDPOOMKJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x4FE9950", Offset = "0x4FE8D50", VA = "0x184FE9950")]
			internal object JNCLEDPGPJH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class HLMLNICFNOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public HFCBBJOANME<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public HLMLNICFNOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4895A00", Offset = "0x4894E00", VA = "0x184895A00")]
			internal object FEJMFOIIFIN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class PKAJJIEMAEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public HFCBBJOANME<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public PKAJJIEMAEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x52E3FC0", Offset = "0x52E33C0", VA = "0x1852E3FC0")]
			internal object CDODGGNOGFJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class MJNIACLFFAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public HFCBBJOANME<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public MJNIACLFFAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4F98DE0", Offset = "0x4F981E0", VA = "0x184F98DE0")]
			internal object OHNHHBAKCEN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class GHJIOBDCNJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public HFCBBJOANME<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public GHJIOBDCNJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4822D10", Offset = "0x4822110", VA = "0x184822D10")]
			internal object PFCMNMIKIKB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float OLNFBBHLCPC = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid HCKHGINLCBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly string CCGMBFGAKLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string MFIEOAOIFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string JPNNBGAIBMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string PELOBFMCILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string LEFEFANEGOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string GNOJKNJJPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string GLPBEMFFNJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string NMFNPIMOECF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string DGPKJFAOADN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string NJBELPODFFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string ABGEIKJNAMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Guid? KAFCKNECDJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private (int, int)? KLCIMNJOBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly HashSet<T> EPNGCGCJBFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<(T, int), string> NIPBBBMHBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(T, int), float> JALHLEFPEGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<T, string> AIJIIBLPKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string> PENCFOGIHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<T, string[]> CMOFKIBFADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private string ELCFOHCODBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool BPKCGBJFAFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Task NOEHDMHMKEI;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x48839C0", Offset = "0x4882DC0", VA = "0x1848839C0")]
		public HFCBBJOANME(Guid HCKHGINLCBI, string MFIEOAOIFDN, string CCGMBFGAKLK, string JPNNBGAIBMD, [Optional] string PELOBFMCILP, [Optional] string LEFEFANEGOM, [Optional] string GNOJKNJJPDF, [Optional] string DGPKJFAOADN, [Optional] string ELCFOHCODBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x993560", Offset = "0x992960", VA = "0x180993560")]
		public void PAHHJABNDLP(string PELOBFMCILP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x991DA0", Offset = "0x9911A0", VA = "0x180991DA0")]
		public void LKBBMDGAGHG(string JPNNBGAIBMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xCCE510", Offset = "0xCCD910", VA = "0x180CCE510")]
		public void OBDJCLKNMNH(string ELCFOHCODBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9933A0", Offset = "0x9927A0", VA = "0x1809933A0")]
		public void MPEPALPELLJ(string GLPBEMFFNJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9932B0", Offset = "0x9926B0", VA = "0x1809932B0")]
		public void EGLBDOLHIJJ(string NJBELPODFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x993520", Offset = "0x992920", VA = "0x180993520")]
		public void OCIHJFCMHFC(string ABGEIKJNAMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x487D7B0", Offset = "0x487CBB0", VA = "0x18487D7B0")]
		public void JAIIAIIIMNN(Guid? HCKHGINLCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4882230", Offset = "0x4881630", VA = "0x184882230")]
		public void LGBOIAGHBDN((int, int)? KLCIMNJOBPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x993410", Offset = "0x992810", VA = "0x180993410")]
		public void ADCANKMBLKK(string NMFNPIMOECF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4882FF0", Offset = "0x48823F0", VA = "0x184882FF0")]
		public void MNKBMINDDNE(T AJDLLPFIPBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4881BA0", Offset = "0x4880FA0", VA = "0x184881BA0")]
		public void KNAIELCINII(T AJDLLPFIPBC, int PFMCMGGOMMN, float DAJECHOKOMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x48800E0", Offset = "0x487F4E0", VA = "0x1848800E0")]
		public void KMJFHPKMLEF(T AJDLLPFIPBC, int PFMCMGGOMMN, string IKDCCOKKGDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x48834C0", Offset = "0x48828C0", VA = "0x1848834C0")]
		public void PFOIDNGGMBM(T AJDLLPFIPBC, string CMBKNAOEAHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x487CF60", Offset = "0x487C360", VA = "0x18487CF60")]
		public void ENEPGGJAGID(T AJDLLPFIPBC, string BEEHONMKFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x487D600", Offset = "0x487CA00", VA = "0x18487D600")]
		public void FICEHLNFLHJ(T AJDLLPFIPBC, string[] GMDIFDBNMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x487D7D0", Offset = "0x487CBD0", VA = "0x18487D7D0")]
		public Task KJCACHOOBFA(bool HEGINIGEJIB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4881250", Offset = "0x4880650", VA = "0x184881250")]
		private (IEnumerable<T>, string) KMNNJGHBBEB()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4882A50", Offset = "0x4881E50", VA = "0x184882A50")]
		public static AOABGKKMKAF LOFEKPMNNFN(Guid HCKHGINLCBI, string MFIEOAOIFDN, T AJDLLPFIPBC, string CCGMBFGAKLK, string HODPNALLDAF, string PELOBFMCILP, int? KDCAMOIGIMA, [Optional] string MOLEHFPLNGF, [Optional] string CMBKNAOEAHI, [Optional] int? LGEEJAEKKMB, [Optional] Guid? KAFCKNECDJH, [Optional] string ELCFOHCODBC, [Optional] string LJFMFHIMODL, [Optional] (int, int)? KLCIMNJOBPC, [Optional] string IAHBFMJFNBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x487CC00", Offset = "0x487C000", VA = "0x18487CC00")]
		[CompilerGenerated]
		private string DLCEMHFKBBJ(T IIKCEJDFBDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x48833A0", Offset = "0x48827A0", VA = "0x1848833A0")]
		[CompilerGenerated]
		private string NGBBKPNNGEI(T IIKCEJDFBDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x487C990", Offset = "0x487BD90", VA = "0x18487C990")]
		[CompilerGenerated]
		private string CBELMMKPGEN(T IIKCEJDFBDH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class AHNCPOGCMGN<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected readonly string BFOPMPHFJHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected readonly Guid GJNNGFNIDGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		protected readonly long ICHOMOMIDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected int MFMDDKDHEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected int HLBIHEGBDJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected DateTime MHKJHEHALMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected bool MLLPMBNJAON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected Dictionary<long, CJKINDOBOHN> OLPIEAFAMCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected bool MCKMHCHPCEB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool EEIEAOPBBGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xB54C50", Offset = "0xB54050", VA = "0x180B54C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool KALGEMHOAOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xBACB90", Offset = "0xBABF90", VA = "0x180BACB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x48E54E0", Offset = "0x48E48E0", VA = "0x1848E54E0")]
		public AHNCPOGCMGN(string BFOPMPHFJHJ, Guid GJNNGFNIDGE, long ICHOMOMIDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void MGNPGMAJMPD(TListSessionStartParams JGFOFEAGJPE);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x48E5360", Offset = "0x48E4760", VA = "0x1848E5360")]
		public void NHIBGGGLJAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void LFJOFHFMPHF(bool CEFDEHIJHOH, TListSessionLogParams FBJPMPAPJLB);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x48E5370", Offset = "0x48E4770", VA = "0x1848E5370")]
		public void PNOBMKCGAIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x48E51C0", Offset = "0x48E45C0", VA = "0x1848E51C0")]
		public void IFGLKPIAMDJ(long BLEHHCPCAAJ, int KDCAMOIGIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x48E5130", Offset = "0x48E4530", VA = "0x1848E5130")]
		public void DHDIACMDHLI(long BLEHHCPCAAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract CJKINDOBOHN OHCFKOFJBBI(TItem DENKIGKMPCB, int KDCAMOIGIMA, string NGGDGEGELFB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class CJKINDOBOHN : OHAHPCECFNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private int MFMDDKDHEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private long BLEHHCPCAAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private long ICHOMOMIDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly string LGILOKJIMNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly string CLGMJHOJFCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly int EIJKJJKIINE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private DateTime NFCCDEMHPKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private double KBLLPLGGCJG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MDJAHCCAKHI
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xD77920", Offset = "0xD76D20", VA = "0x180D77920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xD78250", Offset = "0xD77650", VA = "0x180D78250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6D9E5E0", Offset = "0x6D9D9E0", VA = "0x186D9E5E0")]
		public CJKINDOBOHN(long BLEHHCPCAAJ, int MFMDDKDHEDM, string LJFMFHIMODL, long ICHOMOMIDAH, int EIJKJJKIINE, [Optional] string CCGMBFGAKLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6D9DF00", Offset = "0x6D9D300", VA = "0x186D9DF00")]
		public void AGBNIMPAGNO(int MFMDDKDHEDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6D9E590", Offset = "0x6D9D990", VA = "0x186D9E590")]
		public void ONJOEDLDLOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6D9E480", Offset = "0x6D9D880", VA = "0x186D9E480")]
		public void MEDHIGLAIOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6D9E420", Offset = "0x6D9D820", VA = "0x186D9E420")]
		private void GJBBMFGCDIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6D9DF70", Offset = "0x6D9D370", VA = "0x186D9DF70", Slot = "5")]
		public virtual AOABGKKMKAF FMNOJHGOMHM(Guid HCKHGINLCBI, string POFHFOIBCDD, [Optional] string LJFMFHIMODL, [Optional] long? AJDLLPFIPBC, [Optional] string CCGMBFGAKLK, [Optional] string PELOBFMCILP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class POPIDIEAPJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static Dictionary<string, Dictionary<string, object>> COLNEIBDLOL;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static string NAFJDPPGOOJ;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static int LALPDAOPJIE;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly Dictionary<string, APMHFNKACFF> MACOKPDIHPB;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string EKECEADHAAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6DA3980", Offset = "0x6DA2D80", VA = "0x186DA3980")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6DA45B0", Offset = "0x6DA39B0", VA = "0x186DA45B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool LFKNGBLAPFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6DA46F0", Offset = "0x6DA3AF0", VA = "0x186DA46F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> NJFGHBJDALA
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6DA39D0", Offset = "0x6DA2DD0", VA = "0x186DA39D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? DAKNIILLIOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6DA37B0", Offset = "0x6DA2BB0", VA = "0x186DA37B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6DA3750", Offset = "0x6DA2B50", VA = "0x186DA3750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? ONGDIEKAEFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6DA3E00", Offset = "0x6DA3200", VA = "0x186DA3E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6DA34A0", Offset = "0x6DA28A0", VA = "0x186DA34A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6DA4660", Offset = "0x6DA3A60", VA = "0x186DA4660")]
		public static void MKJOIANHDBC(string NHAOOKBNIGF, APMHFNKACFF DONKJPKKKNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3E60", Offset = "0x6DA3260", VA = "0x186DA3E60")]
		internal static void MBHBIOMKKEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3B30", Offset = "0x6DA2F30", VA = "0x186DA3B30")]
		internal static void LDOICLPCMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6DA4780", Offset = "0x6DA3B80", VA = "0x186DA4780")]
		internal static void MMLBCLBDLEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3FE0", Offset = "0x6DA33E0", VA = "0x186DA3FE0")]
		public static Guid MGNPGMAJMPD(string NHAOOKBNIGF, [Optional] string? GCDHBFNGNJI, [Optional] Dictionary<string, object>? HFHKCNBLJCJ)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3F40", Offset = "0x6DA3340", VA = "0x186DA3F40")]
		public static Guid MGNPGMAJMPD(string NHAOOKBNIGF, long GCDHBFNGNJI, [Optional] Dictionary<string, object>? HFHKCNBLJCJ)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6DA4800", Offset = "0x6DA3C00", VA = "0x186DA4800")]
		public static void NHIBGGGLJAF(string NHAOOKBNIGF, [Optional] Guid? IIBHEJCKGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3500", Offset = "0x6DA2900", VA = "0x186DA3500")]
		public static void BGPNGNGFPHO(string NHAOOKBNIGF, string ANEPNOIKMFB, object MACJJCOIDEJ, bool EIMNFEHCKHD = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3C10", Offset = "0x6DA3010", VA = "0x186DA3C10")]
		public static bool LHKINOOPMHE(string NHAOOKBNIGF, [Optional] string? GCDHBFNGNJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3810", Offset = "0x6DA2C10", VA = "0x186DA3810")]
		private static void GEDKJBMNKGA(bool NELEHCKICOB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3700", Offset = "0x6DA2B00", VA = "0x186DA3700")]
		public static void BIEABGDFIDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3A20", Offset = "0x6DA2E20", VA = "0x186DA3A20")]
		private static void KNJDFCJLPIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6DA4A60", Offset = "0x6DA3E60", VA = "0x186DA4A60")]
		private static void PDGHJPPFAOF(string NHAOOKBNIGF, Guid HCKHGINLCBI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class JPLABIEMEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public struct PAOJLKGPEPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public bool NIGNBIDEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string PCGENKDPJLI;

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xB6DDB0", Offset = "0xB6D1B0", VA = "0x180B6DDB0")]
			public PAOJLKGPEPD(bool NIGNBIDEMPO, string PCGENKDPJLI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0AA0", Offset = "0x6D9FEA0", VA = "0x186DA0AA0")]
		public static PAOJLKGPEPD DLBCFJLNCHA(AOABGKKMKAF JGKNDGLLBMC)
		{
			return default(PAOJLKGPEPD);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0E70", Offset = "0x6DA0270", VA = "0x186DA0E70")]
		private static void OEHAMKIKJNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0DB0", Offset = "0x6DA01B0", VA = "0x186DA0DB0")]
		private static void NHNLNADBJEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class IKICJEOPDOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0410", Offset = "0x6D9F810", VA = "0x186DA0410")]
		public static AOABGKKMKAF NDGKPLIPJMN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class DMDHEDMABKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6D9EC60", Offset = "0x6D9E060", VA = "0x186D9EC60")]
		public static AOABGKKMKAF DLAAACFDMGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6D9ECC0", Offset = "0x6D9E0C0", VA = "0x186D9ECC0")]
		public static AOABGKKMKAF FIFBJPJPDMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6D9EE40", Offset = "0x6D9E240", VA = "0x186D9EE40")]
		public static AOABGKKMKAF HFFBFCFMNNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6D9ED20", Offset = "0x6D9E120", VA = "0x186D9ED20")]
		public static AOABGKKMKAF FKEFDACJKBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6D9F080", Offset = "0x6D9E480", VA = "0x186D9F080")]
		public static AOABGKKMKAF OABGEBPNMEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6D9EF60", Offset = "0x6D9E360", VA = "0x186D9EF60")]
		public static AOABGKKMKAF JFLCKCEMOOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D9F020", Offset = "0x6D9E420", VA = "0x186D9F020")]
		public static AOABGKKMKAF MJBHCNIEDFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D9EDE0", Offset = "0x6D9E1E0", VA = "0x186D9EDE0")]
		public static AOABGKKMKAF GHAAKEGEPAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6D9EC00", Offset = "0x6D9E000", VA = "0x186D9EC00")]
		public static AOABGKKMKAF CIJLLPAMFAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6D9F140", Offset = "0x6D9E540", VA = "0x186D9F140")]
		public static AOABGKKMKAF PBPAKFGADNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6D9EF00", Offset = "0x6D9E300", VA = "0x186D9EF00")]
		public static AOABGKKMKAF JDLPBIMHOAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D9ED80", Offset = "0x6D9E180", VA = "0x186D9ED80")]
		public static AOABGKKMKAF FMDGPMINHBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D9EEA0", Offset = "0x6D9E2A0", VA = "0x186D9EEA0")]
		public static AOABGKKMKAF IMFANDHINML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6D9F0E0", Offset = "0x6D9E4E0", VA = "0x186D9F0E0")]
		public static AOABGKKMKAF OOGNMCCFDEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D9EFC0", Offset = "0x6D9E3C0", VA = "0x186D9EFC0")]
		public static AOABGKKMKAF KADKGCCNNAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class LHDKEHKCEGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2710", Offset = "0x6DA1B10", VA = "0x186DA2710")]
		public static AOABGKKMKAF OIACJALBBNH(long CCHPCHDJHAI, long DCFFKJJLEHN, bool IAKAGGKNKCO, string IPNKOFIHLIC, string EDNGIPEEFAP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class MEIJMFEGCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2BB0", Offset = "0x6DA1FB0", VA = "0x186DA2BB0")]
		public static AOABGKKMKAF DDNMOIBBCCJ(string GNBPGFEFOBO, string FNLCHJOGNJC, bool DHJEBKPEOLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2980", Offset = "0x6DA1D80", VA = "0x186DA2980")]
		public static AOABGKKMKAF CHNDGPLBGFO(string PFPNPMCGHHC, string DCBPLLGNODI, string DJAHGFKGEPG, [Optional] int? IECPPHGLLLA, [Optional] double[] FLBAMIDHGHK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class NDBOIKLJBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2ED0", Offset = "0x6DA22D0", VA = "0x186DA2ED0")]
		public static AOABGKKMKAF CLKHCMOIIDM(string BAIHADANHBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2FB0", Offset = "0x6DA23B0", VA = "0x186DA2FB0")]
		public static AOABGKKMKAF EPIPBKHDDLN(string BDFHKDNGDGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6DA30F0", Offset = "0x6DA24F0", VA = "0x186DA30F0")]
		public static AOABGKKMKAF KDBBOGGJCGM(int OJKFBILBJGP, string MPGDCPPMNJN, string IIKCEJDFBDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3150", Offset = "0x6DA2550", VA = "0x186DA3150")]
		public static AOABGKKMKAF LINFDFLMJJP(int OJKFBILBJGP, string MPGDCPPMNJN, string IIKCEJDFBDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2D20", Offset = "0x6DA2120", VA = "0x186DA2D20")]
		public static AOABGKKMKAF BDGBLGMLOHJ(int OJKFBILBJGP, string MPGDCPPMNJN, string IIKCEJDFBDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3090", Offset = "0x6DA2490", VA = "0x186DA3090")]
		public static AOABGKKMKAF FHDJPNKKANM(int OJKFBILBJGP, string MPGDCPPMNJN, string IIKCEJDFBDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2D80", Offset = "0x6DA2180", VA = "0x186DA2D80")]
		public static AOABGKKMKAF BJKODKDIGEP(string MPGDCPPMNJN, string IIKCEJDFBDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6DA31B0", Offset = "0x6DA25B0", VA = "0x186DA31B0")]
		private static AOABGKKMKAF PNECBBKABKB(string BFOPMPHFJHJ, int OJKFBILBJGP, string JFPHJEFJFGF, string OEOHHBEFPFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6DA32F0", Offset = "0x6DA26F0", VA = "0x186DA32F0")]
		private static AOABGKKMKAF PNECBBKABKB(string BFOPMPHFJHJ, string JFPHJEFJFGF, string OEOHHBEFPFN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly ABDDJEPKCOD DLBCFJLNCHA;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static BGFKOEMHHCL DMIKFAKPHEM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static MJHGAABFBGH ICIKBFCHNIM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<AOABGKKMKAF> PLEIJBMCDIH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long AHCPANLBINL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D9BEC0", Offset = "0x6D9B2C0", VA = "0x186D9BEC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BFB0", Offset = "0x6D9B3B0", VA = "0x186D9BFB0")]
	[FGALJGDFECK.NDOKACNFLAD]
	internal static void PJNDJCGFHJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BC70", Offset = "0x6D9B070", VA = "0x186D9BC70")]
	private static void EGNKODONMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BBF0", Offset = "0x6D9AFF0", VA = "0x186D9BBF0")]
	public static AOABGKKMKAF ANODDHHBLJA(string KBAABECKKLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BAE0", Offset = "0x6D9AEE0", VA = "0x186D9BAE0")]
	public static AOABGKKMKAF ANODDHHBLJA(string KBAABECKKLP, int OJKFBILBJGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BD30", Offset = "0x6D9B130", VA = "0x186D9BD30")]
	public static bool LCKCJOHKKDA(this KIKFEAEKMGH PIAPAGOPIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BDA0", Offset = "0x6D9B1A0", VA = "0x186D9BDA0")]
	[FGALJGDFECK.NDOKACNFLAD]
	internal static void LEHFNPHEPPB()
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
