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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x7481550", Offset = "0x747FB50", VA = "0x187481550")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
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
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7480F00", Offset = "0x747F500", VA = "0x187480F00", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x74840D0", Offset = "0x74826D0", VA = "0x1874840D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LOOPHDDGFPC
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> JCFJCMBALOE();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BLADBFHAHCC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x747B640", Offset = "0x7479C40", VA = "0x18747B640")]
	public static void BOKMNGPGAEP(this FKGIJKHDKBL.JNGEIFEIKFD BEKBGGJGLNG, string MNPAKCIGHPL, string AODGIGLIOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x747B5B0", Offset = "0x7479BB0", VA = "0x18747B5B0")]
	public static void BOKMNGPGAEP(this FKGIJKHDKBL.JNGEIFEIKFD BEKBGGJGLNG, string MNPAKCIGHPL, bool AODGIGLIOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x747B6B0", Offset = "0x7479CB0", VA = "0x18747B6B0")]
	public static void BOKMNGPGAEP(this FKGIJKHDKBL.JNGEIFEIKFD BEKBGGJGLNG, string MNPAKCIGHPL, float KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x747B250", Offset = "0x7479850", VA = "0x18747B250")]
	public static void BOKMNGPGAEP(this FKGIJKHDKBL.JNGEIFEIKFD BEKBGGJGLNG, string MNPAKCIGHPL, JJABFMBOGCP AODGIGLIOBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FKGIJKHDKBL
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface OBNPDBJLEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JNGEIFEIKFD CKOFALFGHCK(Guid DLFENPHGOLM, string JFEADLMKIJK, [Optional] string NKEJPJICHLM, [Optional] long? BELLOCDEFEJ, [Optional] string BEGAKDHOPNB, [Optional] string BJOLGLHMLCM);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class LKJFLOLOGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7480CF0", Offset = "0x747F2F0", VA = "0x187480CF0")]
		public static JNGEIFEIKFD JALOFBIHAJF(Guid DLFENPHGOLM, string JFEADLMKIJK, string NKEJPJICHLM, [Optional] long? BELLOCDEFEJ, [Optional] string BEGAKDHOPNB, [Optional] string BJOLGLHMLCM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class JNGEIFEIKFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected MCAHKCFEDND FLDOIECLDLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> CKHFPFFJGCL;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool MCLPKLKJFOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x747ECE0", Offset = "0x747D2E0", VA = "0x18747ECE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string LGCEJFGCOOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x11A28C0", Offset = "0x11A0EC0", VA = "0x1811A28C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x747F2D0", Offset = "0x747D8D0", VA = "0x18747F2D0")]
		public JNGEIFEIKFD(MCAHKCFEDND FLDOIECLDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x747EFD0", Offset = "0x747D5D0", VA = "0x18747EFD0")]
		public JNGEIFEIKFD MAONDHJICOD(string PJAMOIBNMIO, string KKGBKLFKCPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x747EB50", Offset = "0x747D150", VA = "0x18747EB50")]
		public JNGEIFEIKFD HAPHBFKCCLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4235FC0", Offset = "0x42345C0", VA = "0x184235FC0")]
		public JNGEIFEIKFD MAONDHJICOD<T>(string PJAMOIBNMIO, T KKGBKLFKCPO) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x747E8E0", Offset = "0x747CEE0", VA = "0x18747E8E0")]
		public JNGEIFEIKFD BLIIBOILDNJ(string PJAMOIBNMIO, object KKGBKLFKCPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4235F40", Offset = "0x4234540", VA = "0x184235F40")]
		public JNGEIFEIKFD BPFAFIGBLNB<T>(string PJAMOIBNMIO, T? KKGBKLFKCPO) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x747E960", Offset = "0x747CF60", VA = "0x18747E960")]
		public JNGEIFEIKFD BPFAFIGBLNB(string PJAMOIBNMIO, string KKGBKLFKCPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x747F270", Offset = "0x747D870", VA = "0x18747F270")]
		public JNGEIFEIKFD PODELOEKJDH(string PJAMOIBNMIO, string KKGBKLFKCPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x747F050", Offset = "0x747D650", VA = "0x18747F050")]
		public JNGEIFEIKFD OHNJNMBBELJ(string CLLNGBABBOP, string BLIBAMJKLIA, object ACJFHCNBBBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x747F190", Offset = "0x747D790", VA = "0x18747F190")]
		public JNGEIFEIKFD OHNJNMBBELJ(string CLLNGBABBOP, IDictionary<string, object> BGKLAKBENNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x747EAF0", Offset = "0x747D0F0", VA = "0x18747EAF0")]
		private static IDictionary<string, object> CKMIBNJNODE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x747ED20", Offset = "0x747D320", VA = "0x18747ED20")]
		public void LFPLPNNIOMA(bool EHFEJPKCENG, string GELBLJHDINE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x747E9F0", Offset = "0x747CFF0", VA = "0x18747E9F0")]
		public Task CGJEBEIJAKD([Optional] CancellationToken KMHHNOGHBLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x295EC90", Offset = "0x295D290", VA = "0x18295EC90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MCAHKCFEDND
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct JBKEDKLNDNG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public MCAHKCFEDND <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x747E3B0", Offset = "0x747C9B0", VA = "0x18747E3B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x747E830", Offset = "0x747CE30", VA = "0x18747E830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<MCAHKCFEDND> GKPDIGNMPFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string KMNMKPMFEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> MAMONHADMIE;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string LGCEJFGCOOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x74811B0", Offset = "0x747F7B0", VA = "0x1874811B0")]
		private MCAHKCFEDND(string KMNMKPMFEDJ, int DKGJDLCFPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x747DA50", Offset = "0x747C050", VA = "0x18747DA50")]
		public static JNGEIFEIKFD MMBKOMPANAO(string KMNMKPMFEDJ, int DKGJDLCFPAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7480FF0", Offset = "0x747F5F0", VA = "0x187480FF0")]
		[AsyncStateMachine(typeof(JBKEDKLNDNG))]
		public Task CGJEBEIJAKD([Optional] CancellationToken KMHHNOGHBLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7481140", Offset = "0x747F740", VA = "0x187481140", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x38CF8B0", Offset = "0x38CDEB0", VA = "0x1838CF8B0")]
		internal void AKEBPODHGKH<T>(string PJAMOIBNMIO, T KKGBKLFKCPO) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x74810E0", Offset = "0x747F6E0", VA = "0x1874810E0")]
		internal void HEONBLBMBGH(string PJAMOIBNMIO, object KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7480F90", Offset = "0x747F590", VA = "0x187480F90")]
		internal void AKEBPODHGKH(string PJAMOIBNMIO, string KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4237F00", Offset = "0x4236500", VA = "0x184237F00")]
		private void ILBNKJEHFCN<T>(string PJAMOIBNMIO, T KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct EFEHADFGCPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string BNKPNIDFIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? HAHFIFLNJLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? MDFMHAKNGON;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x747D730", Offset = "0x747BD30", VA = "0x18747D730")]
		public EFEHADFGCPG(string LIFMMHKMACM, [Optional] long? CDFGHIILPDC, [Optional] short? IDPDFCHLECK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct JFGAHOCLACC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int EMGNIAHAKJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string KPFOCMDGANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short GODNPKFKIJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string IAFONDKEPBI;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x747E890", Offset = "0x747CE90", VA = "0x18747E890")]
		public JFGAHOCLACC(int LKIBIANEEEE, string FDCIKGNHABO, short NAOFBGGDPNG, string ODCFLCDAJJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class KCDIPIPNFEG : IMEEIJGEMNO<FEOKGPBGGCK, JFGAHOCLACC, EFEHADFGCPG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string FDCIKGNHABO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short NAOFBGGDPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string ODCFLCDAJJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> JJCANIAOPFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int PBAHKKHDCDL;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x74807E0", Offset = "0x747EDE0", VA = "0x1874807E0")]
		public KCDIPIPNFEG(string KFJBFNGNNAL, Guid LAIJIHBMJNJ, long DPGGFGHNNFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7480410", Offset = "0x747EA10", VA = "0x187480410", Slot = "4")]
		public override void JIDCOFIGJHO(JFGAHOCLACC MFDAIOFCIFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7480700", Offset = "0x747ED00", VA = "0x187480700")]
		public void OGGINAKPMGH(short NAOFBGGDPNG, bool GHMONDDPAFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4BDACB0", Offset = "0x4BD92B0", VA = "0x184BDACB0")]
		public void NGJMFCLJEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA44980", Offset = "0xA42F80", VA = "0x180A44980")]
		public void IADKCBBJGDM(string NLMNLADFHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x747F630", Offset = "0x747DC30", VA = "0x18747F630", Slot = "5")]
		public override void FEJENNIJFGN(bool GHICOCIIEMF, EFEHADFGCPG FMCODGKIAJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x747F370", Offset = "0x747D970", VA = "0x18747F370", Slot = "6")]
		public override CLMAALGGPJF BOKLDJANOEL(FEOKGPBGGCK EJJHGBDKMHO, int KHMHPNKMLMD, string EOBFMLKCLJL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class KNDIAJNHBAP : CLMAALGGPJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string FDCIKGNHABO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short NAOFBGGDPNG;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7480A20", Offset = "0x747F020", VA = "0x187480A20")]
		public KNDIAJNHBAP(long CFEMHJOKDLP, int LKIBIANEEEE, string NKEJPJICHLM, long DPGGFGHNNFB, int JNAEDOKJFKD, string BEGAKDHOPNB, short NAOFBGGDPNG, string FDCIKGNHABO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7480990", Offset = "0x747EF90", VA = "0x187480990")]
		public void IFLBGEKJIFH(int LKIBIANEEEE, string FDCIKGNHABO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7480860", Offset = "0x747EE60", VA = "0x187480860", Slot = "5")]
		public override JNGEIFEIKFD CKOFALFGHCK(Guid DLFENPHGOLM, string JFEADLMKIJK, [Optional] string NKEJPJICHLM, [Optional] long? BELLOCDEFEJ, [Optional] string BEGAKDHOPNB, [Optional] string BJOLGLHMLCM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class EEAAKDCEGJD
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class BBGBFDLCDLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public BBGBFDLCDLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x747AC10", Offset = "0x7479210", VA = "0x18747AC10")]
			internal bool BIGLILOEPKF()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct AJAENKHDLOL : IAsyncStateMachine
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
			private BBGBFDLCDLD <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7479ED0", Offset = "0x74784D0", VA = "0x187479ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x747ABB0", Offset = "0x74791B0", VA = "0x18747ABB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct IIPKOKJEECD : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x747DDC0", Offset = "0x747C3C0", VA = "0x18747DDC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x747E350", Offset = "0x747C950", VA = "0x18747E350", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float JCJHKPKINCI;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static MFFKJDDAJBP HINKJLIAKGN;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource ONMAMECOAPB;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool APKDHOLMPGG;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int HBBKNDIMDMD;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly BGABPBLPFLC<JNGEIFEIKFD, bool> NJOAPMMFNDA;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static PPKAELAFDIN<JNGEIFEIKFD, bool> IJENNBLFAFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x747D4F0", Offset = "0x747BAF0", VA = "0x18747D4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool BBCJGEIENIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x747C9C0", Offset = "0x747AFC0", VA = "0x18747C9C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x747D490", Offset = "0x747BA90", VA = "0x18747D490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool BHHKKJCDEBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x747CF00", Offset = "0x747B500", VA = "0x18747CF00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x747CFC0", Offset = "0x747B5C0", VA = "0x18747CFC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float JDOGOFBFLPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x747CAF0", Offset = "0x747B0F0", VA = "0x18747CAF0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x747D070", Offset = "0x747B670", VA = "0x18747D070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x747C450", Offset = "0x747AA50", VA = "0x18747C450")]
		[LDNNADOHHJB.IFEPGOAHMJA]
		internal static void BDAMIHLMMAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x747CB40", Offset = "0x747B140", VA = "0x18747CB40")]
		internal static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x747CD40", Offset = "0x747B340", VA = "0x18747CD40")]
		internal static void GLGIKECFEFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x747CF50", Offset = "0x747B550", VA = "0x18747CF50")]
		internal static void HAPFEHJBNCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x747D020", Offset = "0x747B620", VA = "0x18747D020")]
		public static void IKJLONHIPGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x747C570", Offset = "0x747AB70", VA = "0x18747C570")]
		private static void CEGOOGHOFHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x747D1A0", Offset = "0x747B7A0", VA = "0x18747D1A0")]
		private static void MFCKLIJCOJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x747D0D0", Offset = "0x747B6D0", VA = "0x18747D0D0")]
		[AsyncStateMachine(typeof(AJAENKHDLOL))]
		private static Task LIPHCMBGLJO(CancellationToken KMHHNOGHBLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x747CA10", Offset = "0x747B010", VA = "0x18747CA10")]
		private static void DDDLMIDHKNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x747D540", Offset = "0x747BB40", VA = "0x18747D540")]
		[AsyncStateMachine(typeof(IIPKOKJEECD))]
		private static Task OHBINLLKNFF(bool KLCMDCEPJBK, [Optional] CancellationToken KMHHNOGHBLL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class EFFGDCKGGOP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class KDKBCLPGJFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public EFFGDCKGGOP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public KDKBCLPGJFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x52965D0", Offset = "0x5294BD0", VA = "0x1852965D0")]
			internal object OJMDGHAEFCK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class IPIGPIDJJCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public EFFGDCKGGOP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public IPIGPIDJJCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4FA3D30", Offset = "0x4FA2330", VA = "0x184FA3D30")]
			internal object DHAIDLCDCIC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class DEEIAIBEPHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public EFFGDCKGGOP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public DEEIAIBEPHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6CC3480", Offset = "0x6CC1A80", VA = "0x186CC3480")]
			internal object CMLKIGLFEMG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class DMKADLMAOPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public EFFGDCKGGOP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public DMKADLMAOPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6D24BC0", Offset = "0x6D231C0", VA = "0x186D24BC0")]
			internal object LMLFAOEAKHP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class FLCKNJICMDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public EFFGDCKGGOP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public FLCKNJICMDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x4C53540", Offset = "0x4C51B40", VA = "0x184C53540")]
			internal object OFNJJNPMFMB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class EBDHGBMGBOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public EFFGDCKGGOP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public EBDHGBMGBOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x4756120", Offset = "0x4754720", VA = "0x184756120")]
			internal object JFELLNPJPNM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class HKCIFPOOOJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public EFFGDCKGGOP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public HKCIFPOOOJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x4E196C0", Offset = "0x4E17CC0", VA = "0x184E196C0")]
			internal object CBMHKCHCEBH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float ELHJIJKOGJP = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid DLFENPHGOLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Guid ENAKINOACAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string BEGAKDHOPNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string CGJPMLEMEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string HLIHIODNDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string BJOLGLHMLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string NOCLDPPOICC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string KLJGGAEAOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string OMILBNAKJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string FHMPGKGADCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string NNNMHPJONDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string HAHDADBCIEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private string AFBCHDHONMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Guid? MOOKELIDJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private (int, int)? PPDACHJMPPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly HashSet<T> OFFMIEEBBND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(T, int), string> HLCKPDCGGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<(T, int), float> INPPJBCGOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string> CJLGAAHHKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<T, string> HILDLMLMAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<T, string> JFJKHHOFMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Dictionary<T, string[]> LDKIGNMOFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private string IPMMFHHEFHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool KEEOEJAOOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Task NDFDKDOOJDO;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4773CC0", Offset = "0x47722C0", VA = "0x184773CC0")]
		public EFFGDCKGGOP(Guid DLFENPHGOLM, Guid ENAKINOACAD, string CGJPMLEMEHP, string BEGAKDHOPNB, string HLIHIODNDPF, [Optional] string BJOLGLHMLCM, [Optional] string NOCLDPPOICC, [Optional] string KLJGGAEAOPA, [Optional] string NNNMHPJONDA, [Optional] string IPMMFHHEFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4B0", Offset = "0xA4AAB0", VA = "0x180A4C4B0")]
		public void DBDBBEBMKCI(string BJOLGLHMLCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
		public void OPGJBFFKINP(string HLIHIODNDPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xACB8B0", Offset = "0xAC9EB0", VA = "0x180ACB8B0")]
		public void IKDDPEDOMMO(string IPMMFHHEFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA44950", Offset = "0xA42F50", VA = "0x180A44950")]
		public void PGDFKIGPEDJ(string OMILBNAKJAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4C0", Offset = "0xA4AAC0", VA = "0x180A4C4C0")]
		public void HIEDPOPAPAG(string HAHDADBCIEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2F0", Offset = "0xA4A8F0", VA = "0x180A4C2F0")]
		public void MGMMGEHMCNI(string AFBCHDHONMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x476FA90", Offset = "0x476E090", VA = "0x18476FA90")]
		public void DNJCLIEEMJM(Guid? DLFENPHGOLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1868CE0", Offset = "0x18672E0", VA = "0x181868CE0")]
		public void DOIEGFAINMM((int, int)? PPDACHJMPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA44980", Offset = "0xA42F80", VA = "0x180A44980")]
		public void EEFFPMGEHMB(string FHMPGKGADCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4772650", Offset = "0x4770C50", VA = "0x184772650")]
		public void OJIKJOPJEHF(T BELLOCDEFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x476BF50", Offset = "0x476A550", VA = "0x18476BF50")]
		public void AOLKJKLOFLO(T BELLOCDEFEJ, int CLJLEFLGGOO, float EMDIBPDBFEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4771640", Offset = "0x476FC40", VA = "0x184771640")]
		public void GFHGFDCILDN(T BELLOCDEFEJ, int CLJLEFLGGOO, string IJCGJOMLMCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4771A50", Offset = "0x4770050", VA = "0x184771A50")]
		public void HJMCDLAABJJ(T BELLOCDEFEJ, string KHCMMGNKDJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4772050", Offset = "0x4770650", VA = "0x184772050")]
		public void ICFBIJEIOOD(T BELLOCDEFEJ, string BAOGAAHNHII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4772950", Offset = "0x4770F50", VA = "0x184772950")]
		public void PEPDABBGKDP(T BELLOCDEFEJ, bool HMFLJMPIGHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x476FAB0", Offset = "0x476E0B0", VA = "0x18476FAB0")]
		public void EIKEOPHMMNF(T BELLOCDEFEJ, string[] JLDKKDHBGFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x476D980", Offset = "0x476BF80", VA = "0x18476D980")]
		public Task CGJEBEIJAKD(bool KKBNDFNEENM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4770550", Offset = "0x476EB50", VA = "0x184770550")]
		private (IEnumerable<T>, string) FLFGLJPGONC()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x47735D0", Offset = "0x4771BD0", VA = "0x1847735D0")]
		public static JNGEIFEIKFD PFKANJFLEDK(Guid DLFENPHGOLM, Guid ENAKINOACAD, string CGJPMLEMEHP, T BELLOCDEFEJ, string BEGAKDHOPNB, string IIAMAJKANDO, string BJOLGLHMLCM, int? KHMHPNKMLMD, [Optional] string HMANMPHBFPD, [Optional] string KHCMMGNKDJM, [Optional] int? NPBOFCEFAIC, [Optional] Guid? MOOKELIDJFG, [Optional] string IPMMFHHEFHH, [Optional] string NKEJPJICHLM, [Optional] (int, int)? PPDACHJMPPH, [Optional] string LBBLKHMGDII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x476F970", Offset = "0x476DF70", VA = "0x18476F970")]
		[CompilerGenerated]
		private string CGLBCJFMIJD(T HLIPPIOIAJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4772260", Offset = "0x4770860", VA = "0x184772260")]
		[CompilerGenerated]
		private string KKMKBKHLHDN(T HLIPPIOIAJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4773B30", Offset = "0x4772130", VA = "0x184773B30")]
		[CompilerGenerated]
		private string PGFLIINILCG(T HLIPPIOIAJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x476C820", Offset = "0x476AE20", VA = "0x18476C820")]
		[CompilerGenerated]
		private string BFKHKLCOKHB(T HLIPPIOIAJK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class IMEEIJGEMNO<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected readonly string KFJBFNGNNAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected readonly Guid LAIJIHBMJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected readonly long DPGGFGHNNFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected int LKIBIANEEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected int DNCBEDFEHAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		protected DateTime ODNDCBMLIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		protected bool NPFNAICPGLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		protected Dictionary<long, CLMAALGGPJF> AKKJIAMFEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		protected bool FOJDPGOPKND;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool JNHKEEAMOLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xCCADC0", Offset = "0xCC93C0", VA = "0x180CCADC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CJBDGPGFPIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD19390", Offset = "0xD17990", VA = "0x180D19390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4F79E30", Offset = "0x4F78430", VA = "0x184F79E30")]
		public IMEEIJGEMNO(string KFJBFNGNNAL, Guid LAIJIHBMJNJ, long DPGGFGHNNFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void JIDCOFIGJHO(TListSessionStartParams MFDAIOFCIFJ);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4F79D80", Offset = "0x4F78380", VA = "0x184F79D80")]
		public void NDOOHLEGNNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void FEJENNIJFGN(bool GHICOCIIEMF, TListSessionLogParams FMCODGKIAJJ);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4F79DE0", Offset = "0x4F783E0", VA = "0x184F79DE0")]
		public void NJFIEAHFDHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4F79B90", Offset = "0x4F78190", VA = "0x184F79B90")]
		public void BNAAGHPNLEO(long CFEMHJOKDLP, int KHMHPNKMLMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4F79CF0", Offset = "0x4F782F0", VA = "0x184F79CF0")]
		public void EHFPDNFNNPN(long CFEMHJOKDLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract CLMAALGGPJF BOKLDJANOEL(TItem GANFJJCKLGF, int KHMHPNKMLMD, string EOBFMLKCLJL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class CLMAALGGPJF : OBNPDBJLEDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int LKIBIANEEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private long CFEMHJOKDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private long DPGGFGHNNFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly string MIJOKOIEKNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string CDFOOFLIGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly int JNAEDOKJFKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private DateTime BAFBEEMDPKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private double JEHOPELBFLA;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JJFNDCFJDDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xF03940", Offset = "0xF01F40", VA = "0x180F03940")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xF02C80", Offset = "0xF01280", VA = "0x180F02C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x747BEA0", Offset = "0x747A4A0", VA = "0x18747BEA0")]
		public CLMAALGGPJF(long CFEMHJOKDLP, int LKIBIANEEEE, string NKEJPJICHLM, long DPGGFGHNNFB, int JNAEDOKJFKD, [Optional] string BEGAKDHOPNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x747B7B0", Offset = "0x7479DB0", VA = "0x18747B7B0")]
		public void BHKHDDOOMMM(int LKIBIANEEEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x747BCD0", Offset = "0x747A2D0", VA = "0x18747BCD0")]
		public void JOOANCOHPPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x747BD20", Offset = "0x747A320", VA = "0x18747BD20")]
		public void PBHKGDKJLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x747BE30", Offset = "0x747A430", VA = "0x18747BE30")]
		private void PHAFOOFNKFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x747B820", Offset = "0x7479E20", VA = "0x18747B820", Slot = "5")]
		public virtual JNGEIFEIKFD CKOFALFGHCK(Guid DLFENPHGOLM, string JFEADLMKIJK, [Optional] string NKEJPJICHLM, [Optional] long? BELLOCDEFEJ, [Optional] string BEGAKDHOPNB, [Optional] string BJOLGLHMLCM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class POMPKIEGAIA
	{
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static Dictionary<string, Dictionary<string, object>> EJAIFDNNDDE;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static string HMELEEHOHID;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static int CGDIMBDGGOC;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly Dictionary<string, LOOPHDDGFPC> IFLAHOFHPJK;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string CLDHHOJKCHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7483320", Offset = "0x7481920", VA = "0x187483320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7483AB0", Offset = "0x74820B0", VA = "0x187483AB0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool INIMKILIFMK
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7483B70", Offset = "0x7482170", VA = "0x187483B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> GMCEHPGPDOL
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x74838E0", Offset = "0x7481EE0", VA = "0x1874838E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? FGKMAKGMHOF
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7482EB0", Offset = "0x74814B0", VA = "0x187482EB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7483C00", Offset = "0x7482200", VA = "0x187483C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? MKLOGHNPDGC
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7482280", Offset = "0x7480880", VA = "0x187482280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7482220", Offset = "0x7480820", VA = "0x187482220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x74823D0", Offset = "0x74809D0", VA = "0x1874823D0")]
		public static void GGLDLNBJEAA(string KJJGDGEDAAN, LOOPHDDGFPC HFGFPOGMNCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x74822F0", Offset = "0x74808F0", VA = "0x1874822F0")]
		internal static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7482460", Offset = "0x7480A60", VA = "0x187482460")]
		internal static void GLGIKECFEFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x74825A0", Offset = "0x7480BA0", VA = "0x1874825A0")]
		internal static void HAPFEHJBNCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x74828D0", Offset = "0x7480ED0", VA = "0x1874828D0")]
		public static Guid JIDCOFIGJHO(string KJJGDGEDAAN, [Optional] string? PCIAOBJNEKA, [Optional] Dictionary<string, object>? DHOIFCELLJD)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7482830", Offset = "0x7480E30", VA = "0x187482830")]
		public static Guid JIDCOFIGJHO(string KJJGDGEDAAN, long PCIAOBJNEKA, [Optional] Dictionary<string, object>? DHOIFCELLJD)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7483680", Offset = "0x7481C80", VA = "0x187483680")]
		public static void NDOOHLEGNNG(string KJJGDGEDAAN, [Optional] Guid? PPIICOOCLEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7482620", Offset = "0x7480C20", VA = "0x187482620")]
		public static void IOCDOFHJLFO(string KJJGDGEDAAN, string CLLNGBABBOP, object DELFIPIBKBG, bool APKDHOLMPGG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7483490", Offset = "0x7481A90", VA = "0x187483490")]
		public static bool NBNJFLIEPMD(string KJJGDGEDAAN, [Optional] string? PCIAOBJNEKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7483930", Offset = "0x7481F30", VA = "0x187483930")]
		private static void NIMDFEODBGC(bool ENJAPLNHMPE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7482540", Offset = "0x7480B40", VA = "0x187482540")]
		public static void GODFPJHBFAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7483370", Offset = "0x7481970", VA = "0x187483370")]
		private static void MFCKLIJCOJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7482F20", Offset = "0x7481520", VA = "0x187482F20")]
		private static void KIFAIGEKADJ(string KJJGDGEDAAN, Guid DLFENPHGOLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class CNKLIJIKGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct FBFGHOOGFJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public bool DDMLMBGCPOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public string HJBLCFHEMEA;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCCBBE0", Offset = "0xCCA1E0", VA = "0x180CCBBE0")]
			public FBFGHOOGFJG(bool DDMLMBGCPOD, string HJBLCFHEMEA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x747C130", Offset = "0x747A730", VA = "0x18747C130")]
		public static FBFGHOOGFJG OAAFJAHOMDO(JNGEIFEIKFD BEKBGGJGLNG)
		{
			return default(FBFGHOOGFJG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x747BF70", Offset = "0x747A570", VA = "0x18747BF70")]
		private static void DBMBKILGDGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x747C070", Offset = "0x747A670", VA = "0x18747C070")]
		private static void KMILNNGABLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class MJHJAIDNFBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x74814F0", Offset = "0x747FAF0", VA = "0x1874814F0")]
		public static JNGEIFEIKFD MNFJLOMCMOH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class BKFBJHMKJIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x747B190", Offset = "0x7479790", VA = "0x18747B190")]
		public static JNGEIFEIKFD OCIKNFMLHBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x747AF50", Offset = "0x7479550", VA = "0x18747AF50")]
		public static JNGEIFEIKFD JFLMBOLHOLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x747B0D0", Offset = "0x74796D0", VA = "0x18747B0D0")]
		public static JNGEIFEIKFD NDMKAKCJNLG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x747ACB0", Offset = "0x74792B0", VA = "0x18747ACB0")]
		public static JNGEIFEIKFD BDBHJLDLFCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x747AEF0", Offset = "0x74794F0", VA = "0x18747AEF0")]
		public static JNGEIFEIKFD JCJCJCMAFJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x747B130", Offset = "0x7479730", VA = "0x18747B130")]
		public static JNGEIFEIKFD NFLPMPAMKBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x747B070", Offset = "0x7479670", VA = "0x18747B070")]
		public static JNGEIFEIKFD MLPJODFCCHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x747B010", Offset = "0x7479610", VA = "0x18747B010")]
		public static JNGEIFEIKFD MKIEIIMONKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x747AE90", Offset = "0x7479490", VA = "0x18747AE90")]
		public static JNGEIFEIKFD IBIJIIPOLOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x747AE30", Offset = "0x7479430", VA = "0x18747AE30")]
		public static JNGEIFEIKFD HGIKHOIMEAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x747AFB0", Offset = "0x74795B0", VA = "0x18747AFB0")]
		public static JNGEIFEIKFD LGANGEPOBHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x747ADD0", Offset = "0x74793D0", VA = "0x18747ADD0")]
		public static JNGEIFEIKFD FCDFKHHGBBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x747B1F0", Offset = "0x74797F0", VA = "0x18747B1F0")]
		public static JNGEIFEIKFD OGCIKJBCELK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x747AD70", Offset = "0x7479370", VA = "0x18747AD70")]
		public static JNGEIFEIKFD DOHFMIIEMGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x747AD10", Offset = "0x7479310", VA = "0x18747AD10")]
		public static JNGEIFEIKFD BPNLHPCCJPN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class LFGHFBKLCPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7480B10", Offset = "0x747F110", VA = "0x187480B10")]
		public static JNGEIFEIKFD GPJFOFNDCCM(long CDFGHIILPDC, long BKDNOJBOAHD, bool CMEBBDJKDOJ, string PBJFLMAGJAI, string INOCOPOLOKF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class OPIILEEHCLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x74815D0", Offset = "0x747FBD0", VA = "0x1874815D0")]
		public static JNGEIFEIKFD BOPPNDDLKAP(string GJFLEAAAMEL, string GJIFFMHPFAH, bool BFKPOJNOPPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7481740", Offset = "0x747FD40", VA = "0x187481740")]
		public static JNGEIFEIKFD DELOODGKHNM(Guid ENAKINOACAD, string HILCMKALFIH, string EPIICOCDDCD, string LIHJBCIFDIO, [Optional] int? PNMLIALCBCD, [Optional] double[] AGNJPKFKHDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x74819F0", Offset = "0x747FFF0", VA = "0x1874819F0")]
		public static JNGEIFEIKFD LCIOBMKPHMF(Guid ENAKINOACAD, Guid JIJBMFMDIEN, bool FGNDNIGHPMN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class PNFBAIOPMPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7481E70", Offset = "0x7480470", VA = "0x187481E70")]
		public static JNGEIFEIKFD KIAMOFJOMJK(string JEHDEABKIBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7481D90", Offset = "0x7480390", VA = "0x187481D90")]
		public static JNGEIFEIKFD IGMEOEIFEDM(string MEKNAMEECAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7481F50", Offset = "0x7480550", VA = "0x187481F50")]
		public static JNGEIFEIKFD PFGNEAJFDDN(int DKGJDLCFPAB, string IEDAJGLJHNI, string HLIPPIOIAJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7481B20", Offset = "0x7480120", VA = "0x187481B20")]
		public static JNGEIFEIKFD APLLMENMHKA(int DKGJDLCFPAB, string IEDAJGLJHNI, string HLIPPIOIAJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7481BE0", Offset = "0x74801E0", VA = "0x187481BE0")]
		public static JNGEIFEIKFD BMKHAMNJMPD(int DKGJDLCFPAB, string IEDAJGLJHNI, string HLIPPIOIAJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7481B80", Offset = "0x7480180", VA = "0x187481B80")]
		public static JNGEIFEIKFD BJBBFBHEDMC(int DKGJDLCFPAB, string IEDAJGLJHNI, string HLIPPIOIAJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7481C40", Offset = "0x7480240", VA = "0x187481C40")]
		public static JNGEIFEIKFD DCLALLFFDOB(string IEDAJGLJHNI, string HLIPPIOIAJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x74820E0", Offset = "0x74806E0", VA = "0x1874820E0")]
		private static JNGEIFEIKFD PJKMPMFPOCL(string KFJBFNGNNAL, int DKGJDLCFPAB, string FMLEEHDBLDH, string DCJGGNKDFOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7481FB0", Offset = "0x74805B0", VA = "0x187481FB0")]
		private static JNGEIFEIKFD PJKMPMFPOCL(string KFJBFNGNNAL, string FMLEEHDBLDH, string DCJGGNKDFOI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly LHMKAIAPMBI OAAFJAHOMDO;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static IJMNBIIDPGK LDADKFPMBGB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static MBOPCPOPDEN FAPKBONHNDO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<JNGEIFEIKFD> HPFBJPKPKGP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long BLDHBGIALHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x747DB60", Offset = "0x747C160", VA = "0x18747DB60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x747DC50", Offset = "0x747C250", VA = "0x18747DC50")]
	[LDNNADOHHJB.IFEPGOAHMJA]
	internal static void NEILGEAGLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x747D900", Offset = "0x747BF00", VA = "0x18747D900")]
	private static void JHHBDGEKKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x747D9D0", Offset = "0x747BFD0", VA = "0x18747D9D0")]
	public static JNGEIFEIKFD JLBJGKMBICP(string KMNMKPMFEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x747DA50", Offset = "0x747C050", VA = "0x18747DA50")]
	public static JNGEIFEIKFD JLBJGKMBICP(string KMNMKPMFEDJ, int DKGJDLCFPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x747D890", Offset = "0x747BE90", VA = "0x18747D890")]
	public static bool HEILDHIKEEB(this MFFKJDDAJBP JFMKNIGFFBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x747D770", Offset = "0x747BD70", VA = "0x18747D770")]
	[LDNNADOHHJB.IFEPGOAHMJA]
	internal static void EEDMMBDCNHB()
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
