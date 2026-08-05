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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x71B7590", Offset = "0x71B6790", VA = "0x1871B7590")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71B7500", Offset = "0x71B6700", VA = "0x1871B7500", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x71BAD80", Offset = "0x71B9F80", VA = "0x1871BAD80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KMIMDJHMIGH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> PJNONGMPFPO();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BJHCEEABBLL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x71B1500", Offset = "0x71B0700", VA = "0x1871B1500")]
	public static void PIPNFJDGAJM(this KKJPKBKBFCL.LFJPICLPIGB CHCOILEEPGL, string MADCOKHMFJC, string GMEEOKAEECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x71B1010", Offset = "0x71B0210", VA = "0x1871B1010")]
	public static void PIPNFJDGAJM(this KKJPKBKBFCL.LFJPICLPIGB CHCOILEEPGL, string MADCOKHMFJC, bool GMEEOKAEECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x71B10A0", Offset = "0x71B02A0", VA = "0x1871B10A0")]
	public static void PIPNFJDGAJM(this KKJPKBKBFCL.LFJPICLPIGB CHCOILEEPGL, string MADCOKHMFJC, float MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x71B11A0", Offset = "0x71B03A0", VA = "0x1871B11A0")]
	public static void PIPNFJDGAJM(this KKJPKBKBFCL.LFJPICLPIGB CHCOILEEPGL, string MADCOKHMFJC, LBHDEGMBBKG GMEEOKAEECE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KKJPKBKBFCL
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface OIJHBHBKEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LFJPICLPIGB FDBCGGMFPIE(Guid ANPKGOFDOAE, string MGEEGCNDNFJ, [Optional] string OIJNCBGLHEG, [Optional] long? NKACBIHBMKK, [Optional] string NIHEKCHEINN, [Optional] string PJBDGAIDLPF);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class LDOHAGAMJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x71B6350", Offset = "0x71B5550", VA = "0x1871B6350")]
		public static LFJPICLPIGB PPDNIMPFFNA(Guid ANPKGOFDOAE, string MGEEGCNDNFJ, string OIJNCBGLHEG, [Optional] long? NKACBIHBMKK, [Optional] string NIHEKCHEINN, [Optional] string PJBDGAIDLPF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class LFJPICLPIGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected LOKLMKLLEHI ELJMGFIBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> ACHMJGMNINA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool GBFAAIJCDOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x71B68B0", Offset = "0x71B5AB0", VA = "0x1871B68B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string FHCNGHCDCLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1134C60", Offset = "0x1133E60", VA = "0x181134C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x71B6F00", Offset = "0x71B6100", VA = "0x1871B6F00")]
		public LFJPICLPIGB(LOKLMKLLEHI ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x71B6B10", Offset = "0x71B5D10", VA = "0x1871B6B10")]
		public LFJPICLPIGB DJBHIPDPHNB(string FOCHDHDPJJM, string MLCDCHNOCFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x71B6CF0", Offset = "0x71B5EF0", VA = "0x1871B6CF0")]
		public LFJPICLPIGB HKNNCIEMPBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3F9B890", Offset = "0x3F9AA90", VA = "0x183F9B890")]
		public LFJPICLPIGB DJBHIPDPHNB<T>(string FOCHDHDPJJM, T MLCDCHNOCFI) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x71B6E80", Offset = "0x71B6080", VA = "0x1871B6E80")]
		public LFJPICLPIGB JDKPMLIGEKK(string FOCHDHDPJJM, object MLCDCHNOCFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3F9B800", Offset = "0x3F9AA00", VA = "0x183F9B800")]
		public LFJPICLPIGB APFANHFLMOE<T>(string FOCHDHDPJJM, T? MLCDCHNOCFI) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x71B6820", Offset = "0x71B5A20", VA = "0x1871B6820")]
		public LFJPICLPIGB APFANHFLMOE(string FOCHDHDPJJM, string MLCDCHNOCFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71B68F0", Offset = "0x71B5AF0", VA = "0x1871B68F0")]
		public LFJPICLPIGB DEAOICDHKJC(string BOFCPJPPMFP, string AGBHGDFILGO, object DHAOEHNLNON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x71B6A30", Offset = "0x71B5C30", VA = "0x1871B6A30")]
		public LFJPICLPIGB DEAOICDHKJC(string BOFCPJPPMFP, IDictionary<string, object> KNGFDIDKBJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x71B6C90", Offset = "0x71B5E90", VA = "0x1871B6C90")]
		private static IDictionary<string, object> GBDHLCEKJEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x71B6560", Offset = "0x71B5760", VA = "0x1871B6560")]
		public void AAENIIOIALB(bool KCJNKFFIAFB, string LAHMLGHJCDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x71B6B90", Offset = "0x71B5D90", VA = "0x1871B6B90")]
		public Task FLPHKGMCFKE([Optional] CancellationToken HCELDNOKOAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x27A7050", Offset = "0x27A6250", VA = "0x1827A7050", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class LOKLMKLLEHI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct PADCCJDPFCL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public LOKLMKLLEHI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x71B7BF0", Offset = "0x71B6DF0", VA = "0x1871B7BF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x71B8070", Offset = "0x71B7270", VA = "0x1871B8070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<LOKLMKLLEHI> MCNJENEBELP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string HPNMACEOAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> ANLAJIEPODJ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string FHCNGHCDCLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x71B71C0", Offset = "0x71B63C0", VA = "0x1871B71C0")]
		private LOKLMKLLEHI(string HPNMACEOAJK, int JKLFDKBOKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71B5C50", Offset = "0x71B4E50", VA = "0x1871B5C50")]
		public static LFJPICLPIGB EAIFKKLDBGP(string HPNMACEOAJK, int JKLFDKBOKPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x71B6FA0", Offset = "0x71B61A0", VA = "0x1871B6FA0")]
		[AsyncStateMachine(typeof(PADCCJDPFCL))]
		public Task FLPHKGMCFKE([Optional] CancellationToken HCELDNOKOAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x71B7150", Offset = "0x71B6350", VA = "0x1871B7150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x37F2300", Offset = "0x37F1500", VA = "0x1837F2300")]
		internal void KEPFBNEFBCG<T>(string FOCHDHDPJJM, T MLCDCHNOCFI) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x71B7090", Offset = "0x71B6290", VA = "0x1871B7090")]
		internal void HKMFNLKLGFC(string FOCHDHDPJJM, object MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x71B70F0", Offset = "0x71B62F0", VA = "0x1871B70F0")]
		internal void KEPFBNEFBCG(string FOCHDHDPJJM, string MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3F9CD30", Offset = "0x3F9BF30", VA = "0x183F9CD30")]
		private void PPOKHHJMLCA<T>(string FOCHDHDPJJM, T MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct JNOBIMPNFAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string AMKNEDCCGBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? IDAIGHAHCBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? PLDMJKKGMHH;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x71B58E0", Offset = "0x71B4AE0", VA = "0x1871B58E0")]
		public JNOBIMPNFAL(string JNLOIAHFMOB, [Optional] long? BENLNHBBIME, [Optional] short? MDBFGJJAGPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct ENCJCDAIBMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int NEJODCIPMMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string CABBJCEOHEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short CJLGAAONEDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string JCIBCGGJBAP;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x71B29C0", Offset = "0x71B1BC0", VA = "0x1871B29C0")]
		public ENCJCDAIBMP(int KCAMAJHODGL, string PCPIOFPJLJL, short DCKELLHJBEB, string NKPBBGFKCHA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class PINOPFHLAAO : PHGENIGANCK<NMPNMAKDCPJ, ENCJCDAIBMP, JNOBIMPNFAL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string PCPIOFPJLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short DCKELLHJBEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string NKPBBGFKCHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> MNBDAPKMMMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int BOOHHPJHCBL;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x71BAA10", Offset = "0x71B9C10", VA = "0x1871BAA10")]
		public PINOPFHLAAO(string LNEPIHEFEID, Guid IIMEJKCCDKF, long LPPHMJBHDIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x71B9690", Offset = "0x71B8890", VA = "0x1871B9690", Slot = "4")]
		public override void DOJCNCMCPJL(ENCJCDAIBMP LKEJCBMJHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x71B95B0", Offset = "0x71B87B0", VA = "0x1871B95B0")]
		public void CGDHGMDPGDH(short DCKELLHJBEB, bool CLEFJFMJDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4984A30", Offset = "0x4983C30", VA = "0x184984A30")]
		public void FGKIFJOLBDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F24A0", VA = "0x1809F32A0")]
		public void GOOMJDMCPMK(string AAPCIHJMPII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x71B9C30", Offset = "0x71B8E30", VA = "0x1871B9C30", Slot = "5")]
		public override void PNMOFIIHPMA(bool KKJCMCJABMH, JNOBIMPNFAL CJDFBKLHGAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x71B9980", Offset = "0x71B8B80", VA = "0x1871B9980", Slot = "6")]
		public override DJNNEOMOIFE HPLBNEOOFNA(NMPNMAKDCPJ EPHACFPLAHE, int NIBICIJAIGM, string OLCINMKNKOH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PEBNNNHIJJG : DJNNEOMOIFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string PCPIOFPJLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short DCKELLHJBEB;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x71B94C0", Offset = "0x71B86C0", VA = "0x1871B94C0")]
		public PEBNNNHIJJG(long PJEBGIFFKDF, int KCAMAJHODGL, string OIJNCBGLHEG, long LPPHMJBHDIM, int JHGHBCMAONI, string NIHEKCHEINN, short DCKELLHJBEB, string PCPIOFPJLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x71B9310", Offset = "0x71B8510", VA = "0x1871B9310")]
		public void DKDHDLHAHKC(int KCAMAJHODGL, string PCPIOFPJLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x71B9390", Offset = "0x71B8590", VA = "0x1871B9390", Slot = "5")]
		public override LFJPICLPIGB FDBCGGMFPIE(Guid ANPKGOFDOAE, string MGEEGCNDNFJ, [Optional] string OIJNCBGLHEG, [Optional] long? NKACBIHBMKK, [Optional] string NIHEKCHEINN, [Optional] string PJBDGAIDLPF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class PCOEPAEJIBD
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class AOAFELLIGDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public AOAFELLIGDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x71B0F70", Offset = "0x71B0170", VA = "0x1871B0F70")]
			internal bool LEBIIHCKMAL()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct HOMGMMELNJM : IAsyncStateMachine
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
			private AOAFELLIGDH <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x71B30C0", Offset = "0x71B22C0", VA = "0x1871B30C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x71B3D80", Offset = "0x71B2F80", VA = "0x1871B3D80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct OBKEIINDLDO : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x71B7610", Offset = "0x71B6810", VA = "0x1871B7610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x71B7B90", Offset = "0x71B6D90", VA = "0x1871B7B90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float CCFNJNHAAPL;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static HJGCGGODOAD MIFPNJKPFOG;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource EEKCPHOKFOB;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool FPMAPPJFNDC;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int IJBCDMMINPO;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly PFCLJBDPGOA<LFJPICLPIGB, bool> HHNEFLCGFNB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static DMKBHGDJOCE<LFJPICLPIGB, bool> FJELMBNPPMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x71B89C0", Offset = "0x71B7BC0", VA = "0x1871B89C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool PNEOCHMOCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x71B91D0", Offset = "0x71B83D0", VA = "0x1871B91D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x71B8FF0", Offset = "0x71B81F0", VA = "0x1871B8FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool KOHFHACFALE
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x71B8130", Offset = "0x71B7330", VA = "0x1871B8130")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x71B8180", Offset = "0x71B7380", VA = "0x1871B8180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float IEHFGHCDNMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x71B81E0", Offset = "0x71B73E0", VA = "0x1871B81E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x71B9050", Offset = "0x71B8250", VA = "0x1871B9050")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x71B8BF0", Offset = "0x71B7DF0", VA = "0x1871B8BF0")]
		[CBBBKCBCELM.JEOCHIKIEPK]
		internal static void IPGLLCLPALB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x71B8A10", Offset = "0x71B7C10", VA = "0x1871B8A10")]
		internal static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x71B8730", Offset = "0x71B7930", VA = "0x1871B8730")]
		internal static void ELPJDBNOPIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x71B80D0", Offset = "0x71B72D0", VA = "0x1871B80D0")]
		internal static void CELDAGAAJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x71B90B0", Offset = "0x71B82B0", VA = "0x1871B90B0")]
		public static void MDIDIGHBPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x71B8230", Offset = "0x71B7430", VA = "0x1871B8230")]
		private static void EDHMKGMGGGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x71B8D10", Offset = "0x71B7F10", VA = "0x1871B8D10")]
		private static void JEGEDKIOKEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x71B9100", Offset = "0x71B8300", VA = "0x1871B9100")]
		[AsyncStateMachine(typeof(HOMGMMELNJM))]
		private static Task MIFCNPNCNBE(CancellationToken HCELDNOKOAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x71B8660", Offset = "0x71B7860", VA = "0x1871B8660")]
		private static void EGMEJDJAEJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x71B88E0", Offset = "0x71B7AE0", VA = "0x1871B88E0")]
		[AsyncStateMachine(typeof(OBKEIINDLDO))]
		private static Task FGBPOOCNGCI(bool LAGOFNHNBLE, [Optional] CancellationToken HCELDNOKOAM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class HOFKPBDEHNI<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class ECHIFILMCCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public HOFKPBDEHNI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public ECHIFILMCCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4527D00", Offset = "0x4526F00", VA = "0x184527D00")]
			internal object OJBHPOIDFFJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class KPBOKEMHMFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public HOFKPBDEHNI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public KPBOKEMHMFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x502A810", Offset = "0x5029A10", VA = "0x18502A810")]
			internal object GINMENNAMGP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class PJIKNBNBIMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public HOFKPBDEHNI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public PJIKNBNBIMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x562FA80", Offset = "0x562EC80", VA = "0x18562FA80")]
			internal object AFEACKDDMON()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class IFIGEBPHHLF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public HOFKPBDEHNI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public IFIGEBPHHLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4C76D60", Offset = "0x4C75F60", VA = "0x184C76D60")]
			internal object IOALNNIELMH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class NLJKCPLEFGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public HOFKPBDEHNI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public NLJKCPLEFGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x53BCF00", Offset = "0x53BC100", VA = "0x1853BCF00")]
			internal object BDMIKFKIBOP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class BAOGOOOJGMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public HOFKPBDEHNI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public BAOGOOOJGMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x5E682B0", Offset = "0x5E674B0", VA = "0x185E682B0")]
			internal object LPAKGAKFAIJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class OIHNLFIKNMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public HOFKPBDEHNI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public OIHNLFIKNMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5535690", Offset = "0x5534890", VA = "0x185535690")]
			internal object LIONAAMMLFJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float FMGFOFDDKDN = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid ANPKGOFDOAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly string NIHEKCHEINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string FMKKBELOAPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string ICMDBEJLHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string PJBDGAIDLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string CHFKIHNGAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string FEKKLBGIFNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string LBJDLLLOAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string KMKDEIGHKHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string JPHEFKMGIDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string HDOBPCHMLFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string AJCINJFMCDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Guid? CPCIJEENDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private (int, int)? KGDLHHKNJDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly HashSet<T> LNOEKMPJHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<(T, int), string> MPPIEHOPAND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(T, int), float> MHMDILEBPFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<T, string> AHGGOPMJODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string> BMENMJECGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<T, string> HMLOIJMJLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<T, string[]> LMDNCGEDBLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private string KCKJHGKMDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private bool BKDDIKLIADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Task AKPLANFMIFM;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4BB80F0", Offset = "0x4BB72F0", VA = "0x184BB80F0")]
		public HOFKPBDEHNI(Guid ANPKGOFDOAE, string FMKKBELOAPP, string NIHEKCHEINN, string ICMDBEJLHKI, [Optional] string PJBDGAIDLPF, [Optional] string CHFKIHNGAIE, [Optional] string FEKKLBGIFNK, [Optional] string JPHEFKMGIDL, [Optional] string KCKJHGKMDNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		public void EAAENAGIKCG(string PJBDGAIDLPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		public void JHEJFEKEGJO(string ICMDBEJLHKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xAA38F0", Offset = "0xAA2AF0", VA = "0x180AA38F0")]
		public void CBJBBINNNAI(string KCKJHGKMDNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F24B0", VA = "0x1809F32B0")]
		public void JDAIJMGKFBA(string LBJDLLLOAIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F24A0", VA = "0x1809F32A0")]
		public void PNBFFGGLHMI(string HDOBPCHMLFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9F3310", Offset = "0x9F2510", VA = "0x1809F3310")]
		public void HPGMBHILIOD(string AJCINJFMCDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4BB5EB0", Offset = "0x4BB50B0", VA = "0x184BB5EB0")]
		public void MJNMFNDFGMH(Guid? ANPKGOFDOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4BB0970", Offset = "0x4BAFB70", VA = "0x184BB0970")]
		public void BFGEIBLCFAA((int, int)? KGDLHHKNJDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9F3300", Offset = "0x9F2500", VA = "0x1809F3300")]
		public void JHNHDINBNFD(string KMKDEIGHKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4BB5B70", Offset = "0x4BB4D70", VA = "0x184BB5B70")]
		public void KHGFPCOKIGI(T NKACBIHBMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4BB0650", Offset = "0x4BAF850", VA = "0x184BB0650")]
		public void AIFDFACJBNJ(T NKACBIHBMKK, int LLGNEFCFKEH, float NJODBBGOGON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4BB5320", Offset = "0x4BB4520", VA = "0x184BB5320")]
		public void IEEHLLKACEN(T NKACBIHBMKK, int LLGNEFCFKEH, string NKNDGKKLDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4BB7890", Offset = "0x4BB6A90", VA = "0x184BB7890")]
		public void OBJHHDNPOPC(T NKACBIHBMKK, string HFJAKLEFEKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4BB5ED0", Offset = "0x4BB50D0", VA = "0x184BB5ED0")]
		public void MNIECLGCIOB(T NKACBIHBMKK, string ABCNAHJLEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4BB71A0", Offset = "0x4BB63A0", VA = "0x184BB71A0")]
		public void OAECHFIEMJG(T NKACBIHBMKK, bool PHEIPFPCMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4BB7D90", Offset = "0x4BB6F90", VA = "0x184BB7D90")]
		public void PKMDJNHINIF(T NKACBIHBMKK, string[] MDJAHDGNHDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4BB3050", Offset = "0x4BB2250", VA = "0x184BB3050")]
		public Task FLPHKGMCFKE(bool LIEHHNOLAGC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4BB0DB0", Offset = "0x4BAFFB0", VA = "0x184BB0DB0")]
		private (IEnumerable<T>, string) FGHHHENHIEN()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4BB6BE0", Offset = "0x4BB5DE0", VA = "0x184BB6BE0")]
		public static LFJPICLPIGB NEGFHAGFNOP(Guid ANPKGOFDOAE, string FMKKBELOAPP, T NKACBIHBMKK, string NIHEKCHEINN, string JDPIBELBAJG, string PJBDGAIDLPF, int? NIBICIJAIGM, [Optional] string DNODALHAEOI, [Optional] string HFJAKLEFEKO, [Optional] int? DJAAKPHJBME, [Optional] Guid? CPCIJEENDPA, [Optional] string KCKJHGKMDNA, [Optional] string OIJNCBGLHEG, [Optional] (int, int)? KGDLHHKNJDA, [Optional] string JNGEEJCDIJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4BB5E20", Offset = "0x4BB5020", VA = "0x184BB5E20")]
		[CompilerGenerated]
		private string LJOAHBNOBAH(T MKHHKDJKLDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4BB8060", Offset = "0x4BB7260", VA = "0x184BB8060")]
		[CompilerGenerated]
		private string POKLNLPEJDP(T MKHHKDJKLDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4BB0CE0", Offset = "0x4BAFEE0", VA = "0x184BB0CE0")]
		[CompilerGenerated]
		private string CHAIHHFFNFP(T MKHHKDJKLDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4BB0990", Offset = "0x4BAFB90", VA = "0x184BB0990")]
		[CompilerGenerated]
		private string BJHEOFNHGGJ(T MKHHKDJKLDN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class PHGENIGANCK<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected readonly string LNEPIHEFEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected readonly Guid IIMEJKCCDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected readonly long LPPHMJBHDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected int KCAMAJHODGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected int FBPBAPLAEIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected DateTime OCPIBJHDLIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		protected bool JFAPEJOHLJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		protected Dictionary<long, DJNNEOMOIFE> LINMMIKGHAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		protected bool NHJLKJDKHFK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool BFDEOBNNJEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xC1FDC0", Offset = "0xC1EFC0", VA = "0x180C1FDC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GFAEFMKIHNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xC63350", Offset = "0xC62550", VA = "0x180C63350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x56285E0", Offset = "0x56277E0", VA = "0x1856285E0")]
		public PHGENIGANCK(string LNEPIHEFEID, Guid IIMEJKCCDKF, long LPPHMJBHDIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void DOJCNCMCPJL(TListSessionStartParams LKEJCBMJHMD);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4990F20", Offset = "0x4990120", VA = "0x184990F20")]
		public void BLCOHIBMCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void PNMOFIIHPMA(bool KKJCMCJABMH, TListSessionLogParams CJDFBKLHGAL);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x56281B0", Offset = "0x56273B0", VA = "0x1856281B0")]
		public void KLGMLDMJPEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5628250", Offset = "0x5627450", VA = "0x185628250")]
		public void LLGNLADGPBM(long PJEBGIFFKDF, int NIBICIJAIGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5628480", Offset = "0x5627680", VA = "0x185628480")]
		public void PGINCAHNJDI(long PJEBGIFFKDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract DJNNEOMOIFE HPLBNEOOFNA(TItem CKEIAGIGCJK, int NIBICIJAIGM, string OLCINMKNKOH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class DJNNEOMOIFE : OIJHBHBKEEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int KCAMAJHODGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private long PJEBGIFFKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private long LPPHMJBHDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly string EGNOOBMLLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly string PCPKLEDBAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly int JHGHBCMAONI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private DateTime IFBFDCMEJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private double GIMGBFADGHG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool CPFAAAOJNLE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xE2D920", Offset = "0xE2CB20", VA = "0x180E2D920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xE2D500", Offset = "0xE2C700", VA = "0x180E2D500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x71B28F0", Offset = "0x71B1AF0", VA = "0x1871B28F0")]
		public DJNNEOMOIFE(long PJEBGIFFKDF, int KCAMAJHODGL, string OIJNCBGLHEG, long LPPHMJBHDIM, int JHGHBCMAONI, [Optional] string NIHEKCHEINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x71B2830", Offset = "0x71B1A30", VA = "0x1871B2830")]
		public void HMFDECBENAI(int KCAMAJHODGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x71B28A0", Offset = "0x71B1AA0", VA = "0x1871B28A0")]
		public void IGKIBEDLDEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x71B2270", Offset = "0x71B1470", VA = "0x1871B2270")]
		public void DPOIAFIBMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x71B2210", Offset = "0x71B1410", VA = "0x1871B2210")]
		private void DOOEHOKMDHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x71B2380", Offset = "0x71B1580", VA = "0x1871B2380", Slot = "5")]
		public virtual LFJPICLPIGB FDBCGGMFPIE(Guid ANPKGOFDOAE, string MGEEGCNDNFJ, [Optional] string OIJNCBGLHEG, [Optional] long? NKACBIHBMKK, [Optional] string NIHEKCHEINN, [Optional] string PJBDGAIDLPF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class IKJDCEKDBBC
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static Dictionary<string, Dictionary<string, object>> ALMMLNLOJFK;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static string ABFODFCEDFL;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static int FFNHOMPGDBG;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly Dictionary<string, KMIMDJHMIGH> AJMMFCMDJMB;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string NPDDKKJKLPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x71B4B20", Offset = "0x71B3D20", VA = "0x1871B4B20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x71B56F0", Offset = "0x71B48F0", VA = "0x1871B56F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool APOPPNMBNGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x71B5450", Offset = "0x71B4650", VA = "0x1871B5450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> BOBKNALFNJE
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x71B4FC0", Offset = "0x71B41C0", VA = "0x1871B4FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? AIJBJLKJEKI
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x71B52E0", Offset = "0x71B44E0", VA = "0x1871B52E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x71B49E0", Offset = "0x71B3BE0", VA = "0x1871B49E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? HEHOJDJPDMN
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x71B4980", Offset = "0x71B3B80", VA = "0x1871B4980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x71B4F60", Offset = "0x71B4160", VA = "0x1871B4F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x71B4280", Offset = "0x71B3480", VA = "0x1871B4280")]
		public static void CPHLICAHIAB(string LLGNBDCFOHK, KMIMDJHMIGH FGILFDCNMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x71B5200", Offset = "0x71B4400", VA = "0x1871B5200")]
		internal static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x71B4A40", Offset = "0x71B3C40", VA = "0x1871B4A40")]
		internal static void ELPJDBNOPIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x71B4200", Offset = "0x71B3400", VA = "0x1871B4200")]
		internal static void CELDAGAAJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x71B4310", Offset = "0x71B3510", VA = "0x1871B4310")]
		public static Guid DOJCNCMCPJL(string LLGNBDCFOHK, [Optional] string? MKIPFHIHNJP, [Optional] Dictionary<string, object>? JEOEJPJIJLP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x71B48E0", Offset = "0x71B3AE0", VA = "0x1871B48E0")]
		public static Guid DOJCNCMCPJL(string LLGNBDCFOHK, long MKIPFHIHNJP, [Optional] Dictionary<string, object>? JEOEJPJIJLP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x71B3E30", Offset = "0x71B3030", VA = "0x1871B3E30")]
		public static void BLCOHIBMCED(string LLGNBDCFOHK, [Optional] Guid? DIHOLCNHIND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x71B54E0", Offset = "0x71B46E0", VA = "0x1871B54E0")]
		public static void MHJIPJGEFCM(string LLGNBDCFOHK, string BOFCPJPPMFP, object BBDKNCIMIBJ, bool FPMAPPJFNDC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x71B5010", Offset = "0x71B4210", VA = "0x1871B5010")]
		public static bool HGJMDHPFCAK(string LLGNBDCFOHK, [Optional] string? MKIPFHIHNJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x71B4090", Offset = "0x71B3290", VA = "0x1871B4090")]
		private static void CAADNHANGEL(bool HOEJKLIJPIA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x71B3DE0", Offset = "0x71B2FE0", VA = "0x1871B3DE0")]
		public static void BBLEEPAMIFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x71B5340", Offset = "0x71B4540", VA = "0x1871B5340")]
		private static void JEGEDKIOKEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x71B4B70", Offset = "0x71B3D70", VA = "0x1871B4B70")]
		private static void GJAHPJKMFLB(string LLGNBDCFOHK, Guid ANPKGOFDOAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class GDMLAHHNGMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct FIBKJEAEPPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool MAEMMABLBFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string JGBHCJABAIH;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xC20D10", Offset = "0xC1FF10", VA = "0x180C20D10")]
			public FIBKJEAEPPB(bool MAEMMABLBFK, string JGBHCJABAIH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x71B2A10", Offset = "0x71B1C10", VA = "0x1871B2A10")]
		public static FIBKJEAEPPB GCMHLHCLEDM(LFJPICLPIGB CHCOILEEPGL)
		{
			return default(FIBKJEAEPPB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x71B2D20", Offset = "0x71B1F20", VA = "0x1871B2D20")]
		private static void JEIOODEOILK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x71B2E20", Offset = "0x71B2020", VA = "0x1871B2E20")]
		private static void NLKANMFLKCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KGHMOOHBBCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x71B5920", Offset = "0x71B4B20", VA = "0x1871B5920")]
		public static LFJPICLPIGB LKOMLPLEKFK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class CCHDEPMIGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x71B19F0", Offset = "0x71B0BF0", VA = "0x1871B19F0")]
		public static LFJPICLPIGB MPDNDLCNGOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x71B1870", Offset = "0x71B0A70", VA = "0x1871B1870")]
		public static LFJPICLPIGB LDGNFCLOIBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x71B1A50", Offset = "0x71B0C50", VA = "0x1871B1A50")]
		public static LFJPICLPIGB NGMKKGJBKHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x71B1810", Offset = "0x71B0A10", VA = "0x1871B1810")]
		public static LFJPICLPIGB LBPLJGMCNBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x71B1AB0", Offset = "0x71B0CB0", VA = "0x1871B1AB0")]
		public static LFJPICLPIGB NILPOCCEHJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x71B18D0", Offset = "0x71B0AD0", VA = "0x1871B18D0")]
		public static LFJPICLPIGB MBGPDKMKCLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x71B1630", Offset = "0x71B0830", VA = "0x1871B1630")]
		public static LFJPICLPIGB COGFPHDLIIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x71B1930", Offset = "0x71B0B30", VA = "0x1871B1930")]
		public static LFJPICLPIGB MKMPHIDMCBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x71B1690", Offset = "0x71B0890", VA = "0x1871B1690")]
		public static LFJPICLPIGB DHCLJFDFBJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x71B16F0", Offset = "0x71B08F0", VA = "0x1871B16F0")]
		public static LFJPICLPIGB HAADHEOEELA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x71B15D0", Offset = "0x71B07D0", VA = "0x1871B15D0")]
		public static LFJPICLPIGB CIPEFMNMHPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x71B1990", Offset = "0x71B0B90", VA = "0x1871B1990")]
		public static LFJPICLPIGB MNONNHIBDEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x71B1750", Offset = "0x71B0950", VA = "0x1871B1750")]
		public static LFJPICLPIGB JCPLPDCPLEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x71B17B0", Offset = "0x71B09B0", VA = "0x1871B17B0")]
		public static LFJPICLPIGB KEDEOPPOCCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x71B1570", Offset = "0x71B0770", VA = "0x1871B1570")]
		public static LFJPICLPIGB BLPOMBHJLCN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class HKCDOJBFOIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x71B2EE0", Offset = "0x71B20E0", VA = "0x1871B2EE0")]
		public static LFJPICLPIGB BONGPONAGGI(long BENLNHBBIME, long DLHGMNACNGF, bool DFJGEBCPJBE, string NBJIPAECLHI, string EGGJJEHBAIC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KNGAENIPBGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x71B5FB0", Offset = "0x71B51B0", VA = "0x1871B5FB0")]
		public static LFJPICLPIGB DJKEJNJGJFB(string GMOECBKPFLI, string LNPHAONAIDF, bool EINHIHPOAFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x71B6120", Offset = "0x71B5320", VA = "0x1871B6120")]
		public static LFJPICLPIGB PEPKMCIMLHA(string OPJOIGJBJKN, string KFEPIBPPEMN, string EDMOFAKKLOG, [Optional] int? JMJPFEJONHK, [Optional] double[] GIFJPIEINBN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class DIMJKGEHJOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x71B20D0", Offset = "0x71B12D0", VA = "0x1871B20D0")]
		public static LFJPICLPIGB HCDNJEPLDEI(string MHGOHJLIGCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x71B1FF0", Offset = "0x71B11F0", VA = "0x1871B1FF0")]
		public static LFJPICLPIGB GLGNLKDCMMK(string FJBGDINLJBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x71B1BD0", Offset = "0x71B0DD0", VA = "0x1871B1BD0")]
		public static LFJPICLPIGB EHCDHHILPPB(int JKLFDKBOKPI, string DGIAFBEDPNJ, string MKHHKDJKLDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x71B21B0", Offset = "0x71B13B0", VA = "0x1871B21B0")]
		public static LFJPICLPIGB PCOAOJEHOAF(int JKLFDKBOKPI, string DGIAFBEDPNJ, string MKHHKDJKLDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x71B1B70", Offset = "0x71B0D70", VA = "0x1871B1B70")]
		public static LFJPICLPIGB DCHOKKIIOCE(int JKLFDKBOKPI, string DGIAFBEDPNJ, string MKHHKDJKLDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x71B1B10", Offset = "0x71B0D10", VA = "0x1871B1B10")]
		public static LFJPICLPIGB BAOPNEPPJOF(int JKLFDKBOKPI, string DGIAFBEDPNJ, string MKHHKDJKLDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x71B1C30", Offset = "0x71B0E30", VA = "0x1871B1C30")]
		public static LFJPICLPIGB EHFAFFEKBJA(string DGIAFBEDPNJ, string MKHHKDJKLDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x71B1EB0", Offset = "0x71B10B0", VA = "0x1871B1EB0")]
		private static LFJPICLPIGB FHOLKKMNELG(string LNEPIHEFEID, int JKLFDKBOKPI, string GEIGGDKCHLE, string MPEAPBAANJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x71B1D80", Offset = "0x71B0F80", VA = "0x1871B1D80")]
		private static LFJPICLPIGB FHOLKKMNELG(string LNEPIHEFEID, string GEIGGDKCHLE, string MPEAPBAANJE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly FODGIOKBGBI GCMHLHCLEDM;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static OIEPOBHPALI AAJJNPHAJAI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static BGILDPHCOKN PPECIJJALEF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<LFJPICLPIGB> NJMDIJMMIIP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long OPNKANGOIBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x71B5AE0", Offset = "0x71B4CE0", VA = "0x1871B5AE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x71B5980", Offset = "0x71B4B80", VA = "0x1871B5980")]
	[CBBBKCBCELM.JEOCHIKIEPK]
	internal static void AMOOGCHHLCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x71B5D60", Offset = "0x71B4F60", VA = "0x1871B5D60")]
	private static void NONDLPDIMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x71B5BD0", Offset = "0x71B4DD0", VA = "0x1871B5BD0")]
	public static LFJPICLPIGB MPANBDMFFBL(string HPNMACEOAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x71B5C50", Offset = "0x71B4E50", VA = "0x1871B5C50")]
	public static LFJPICLPIGB MPANBDMFFBL(string HPNMACEOAJK, int JKLFDKBOKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x71B5A70", Offset = "0x71B4C70", VA = "0x1871B5A70")]
	public static bool FCKBMMEFIHI(this HJGCGGODOAD AHCMLKANJEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x71B5E20", Offset = "0x71B5020", VA = "0x1871B5E20")]
	[CBBBKCBCELM.JEOCHIKIEPK]
	internal static void PGGBCLBENCP()
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
