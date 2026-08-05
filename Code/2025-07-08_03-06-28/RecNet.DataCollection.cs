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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7587360", Offset = "0x7586160", VA = "0x187587360")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
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
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7584B30", Offset = "0x7583930", VA = "0x187584B30", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7587C30", Offset = "0x7586A30", VA = "0x187587C30", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ILJEPDICNEF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> CIGPHKPDKBK();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NMDKNCFBNLE
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7587260", Offset = "0x7586060", VA = "0x187587260")]
	public static void GCPPOFMNGHH(this PIGIIEFJEIP.NLNONFMLLBB AIDBMKGCNNA, string NGFMBNJAMHH, string PJFNNJEDHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x75872D0", Offset = "0x75860D0", VA = "0x1875872D0")]
	public static void GCPPOFMNGHH(this PIGIIEFJEIP.NLNONFMLLBB AIDBMKGCNNA, string NGFMBNJAMHH, bool PJFNNJEDHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7586E10", Offset = "0x7585C10", VA = "0x187586E10")]
	public static void GCPPOFMNGHH(this PIGIIEFJEIP.NLNONFMLLBB AIDBMKGCNNA, string NGFMBNJAMHH, float BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7586F10", Offset = "0x7585D10", VA = "0x187586F10")]
	public static void GCPPOFMNGHH(this PIGIIEFJEIP.NLNONFMLLBB AIDBMKGCNNA, string NGFMBNJAMHH, IADLDHPLKNE PJFNNJEDHCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PIGIIEFJEIP
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface PCABCDHFPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NLNONFMLLBB LOFLLFDJBNK(Guid HGLHDGHKJJM, string IHAEBDNDBPH, [Optional] string HIBMHLGALGH, [Optional] long? GFOBNMKBBFF, [Optional] string JJONDEPPKBO, [Optional] string FGNCFFIMJMF);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class LPPBBDDGGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7584920", Offset = "0x7583720", VA = "0x187584920")]
		public static NLNONFMLLBB IILGCCIOMCO(Guid HGLHDGHKJJM, string IHAEBDNDBPH, string HIBMHLGALGH, [Optional] long? GFOBNMKBBFF, [Optional] string JJONDEPPKBO, [Optional] string FGNCFFIMJMF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class NLNONFMLLBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected AADMBEEPJEG IHKPBFJODHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> DKIDEDACIDJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool CIBOLPGKJCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7586BC0", Offset = "0x75859C0", VA = "0x187586BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string KDCHGKMNPEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1276650", Offset = "0x1275450", VA = "0x181276650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7586D70", Offset = "0x7585B70", VA = "0x187586D70")]
		public NLNONFMLLBB(AADMBEEPJEG IHKPBFJODHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7586380", Offset = "0x7585180", VA = "0x187586380")]
		public NLNONFMLLBB BHFIFMDIJPM(string DAGPCGHBFAL, string BNECONOIKOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7586720", Offset = "0x7585520", VA = "0x187586720")]
		public NLNONFMLLBB CPFCNDBPPKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x42CCF50", Offset = "0x42CBD50", VA = "0x1842CCF50")]
		public NLNONFMLLBB BHFIFMDIJPM<T>(string DAGPCGHBFAL, T BNECONOIKOE) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7586C60", Offset = "0x7585A60", VA = "0x187586C60")]
		public NLNONFMLLBB INEFLPLMMHL(string DAGPCGHBFAL, object BNECONOIKOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x42CD2F0", Offset = "0x42CC0F0", VA = "0x1842CD2F0")]
		public NLNONFMLLBB JOEKMPONNBB<T>(string DAGPCGHBFAL, T? BNECONOIKOE) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7586CE0", Offset = "0x7585AE0", VA = "0x187586CE0")]
		public NLNONFMLLBB JOEKMPONNBB(string DAGPCGHBFAL, string BNECONOIKOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7586C00", Offset = "0x7585A00", VA = "0x187586C00")]
		public NLNONFMLLBB IJFIPBLEOFD(string DAGPCGHBFAL, string BNECONOIKOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x75865E0", Offset = "0x75853E0", VA = "0x1875865E0")]
		public NLNONFMLLBB BJPIKBOLINH(string JGGGOGKAHLP, string MAHBBBBCDEL, object BOIPFNOKGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7586500", Offset = "0x7585300", VA = "0x187586500")]
		public NLNONFMLLBB BJPIKBOLINH(string JGGGOGKAHLP, IDictionary<string, object> GAMMEDAFION)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7586B60", Offset = "0x7585960", VA = "0x187586B60")]
		private static IDictionary<string, object> FELALACGPGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x75868B0", Offset = "0x75856B0", VA = "0x1875868B0")]
		public void EBBADEIBDEP(bool GJDFOJJKLBE, string DEEIOMCFPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7586400", Offset = "0x7585200", VA = "0x187586400")]
		public Task BJLPCCNDGPM([Optional] CancellationToken HIMDFBHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x29AC9C0", Offset = "0x29AB7C0", VA = "0x1829AC9C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AADMBEEPJEG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct MJLEECOCJJP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public AADMBEEPJEG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7585160", Offset = "0x7583F60", VA = "0x187585160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x75855E0", Offset = "0x75843E0", VA = "0x1875855E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<AADMBEEPJEG> IHPHEFFLLCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string AHDIMGPOHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> KLBBMKHCKBE;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string KDCHGKMNPEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x757DD60", Offset = "0x757CB60", VA = "0x18757DD60")]
		private AADMBEEPJEG(string AHDIMGPOHGO, int ADHDKEKHIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x757DB80", Offset = "0x757C980", VA = "0x18757DB80")]
		public static NLNONFMLLBB LDFHHMLGJNG(string AHDIMGPOHGO, int ADHDKEKHIJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x757DA30", Offset = "0x757C830", VA = "0x18757DA30")]
		[AsyncStateMachine(typeof(MJLEECOCJJP))]
		public Task BJLPCCNDGPM([Optional] CancellationToken HIMDFBHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x757DCF0", Offset = "0x757CAF0", VA = "0x18757DCF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x39360E0", Offset = "0x3934EE0", VA = "0x1839360E0")]
		internal void KCDIFIJNEJN<T>(string DAGPCGHBFAL, T BNECONOIKOE) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x757DC90", Offset = "0x757CA90", VA = "0x18757DC90")]
		internal void ONILNJIBEAB(string DAGPCGHBFAL, object BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x757DB20", Offset = "0x757C920", VA = "0x18757DB20")]
		internal void KCDIFIJNEJN(string DAGPCGHBFAL, string BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x42C6A00", Offset = "0x42C5800", VA = "0x1842C6A00")]
		private void GOODFPAFHCI<T>(string DAGPCGHBFAL, T BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct BIFFKAEPIEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string BNJFDMAPCFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? NBAAIIHONBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? CDKHACIAJMK;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x757FC40", Offset = "0x757EA40", VA = "0x18757FC40")]
		public BIFFKAEPIEP(string EBLNJAOFKPI, [Optional] long? NCGHDDJNJOM, [Optional] short? IMAGGMHLKHH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct KMFGLPMKBFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int IHJHGAIAFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string KCCJFBIGOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short KGPMFOEJCKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string CIHBLCHIDOD;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7583E80", Offset = "0x7582C80", VA = "0x187583E80")]
		public KMFGLPMKBFA(int POKGNKCLMLJ, string HPHKIOMNNMK, short NAGJNGGAMOK, string NCLGGMMFPHI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class COJKIENHFAM : CDJNPPCKOHF<HPJIMFIDBOK, KMFGLPMKBFA, BIFFKAEPIEP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string HPHKIOMNNMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short NAGJNGGAMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string NCLGGMMFPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> BLEEOBONNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int KLNCCIHIKMP;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7581650", Offset = "0x7580450", VA = "0x187581650")]
		public COJKIENHFAM(string DPBKJDNMHKG, Guid IDCMPGCDJPK, long CDGHLBLIBBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7581360", Offset = "0x7580160", VA = "0x187581360", Slot = "4")]
		public override void OMAIMOHCKOB(KMFGLPMKBFA GGNEPBLPGFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7581280", Offset = "0x7580080", VA = "0x187581280")]
		public void MDNPJKOHKGD(short NAGJNGGAMOK, bool ACOBHAFDHHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4C87830", Offset = "0x4C86630", VA = "0x184C87830")]
		public void ECCBCILOPGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA5F340", Offset = "0xA5E140", VA = "0x180A5F340")]
		public void MNOLNPJKPIE(string BGBCCOGNFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x75801D0", Offset = "0x757EFD0", VA = "0x1875801D0", Slot = "5")]
		public override void CGNFOGGKGMB(bool LKFOHABFCKF, BIFFKAEPIEP LKPFONIJBEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7580FC0", Offset = "0x757FDC0", VA = "0x187580FC0", Slot = "6")]
		public override GCKNCGJIAAK IOEGECPGBOH(HPJIMFIDBOK JFMLOEKPFOG, int CKFKPOAGPKN, string MGMCAGDADHN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class LBDEMJPOFFH : GCKNCGJIAAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string HPHKIOMNNMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short NAGJNGGAMOK;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7584830", Offset = "0x7583630", VA = "0x187584830")]
		public LBDEMJPOFFH(long NENMJCEFFAO, int POKGNKCLMLJ, string HIBMHLGALGH, long CDGHLBLIBBM, int HPFDPDODKPE, string JJONDEPPKBO, short NAGJNGGAMOK, string HPHKIOMNNMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x75847A0", Offset = "0x75835A0", VA = "0x1875847A0")]
		public void LPIABBJPMOH(int POKGNKCLMLJ, string HPHKIOMNNMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7584670", Offset = "0x7583470", VA = "0x187584670", Slot = "5")]
		public override NLNONFMLLBB LOFLLFDJBNK(Guid HGLHDGHKJJM, string IHAEBDNDBPH, [Optional] string HIBMHLGALGH, [Optional] long? GFOBNMKBBFF, [Optional] string JJONDEPPKBO, [Optional] string FGNCFFIMJMF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class HBCIDMIAGOC
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class LAIIEKMKLDK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public LAIIEKMKLDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x75845D0", Offset = "0x75833D0", VA = "0x1875845D0")]
			internal bool JINEHICNKBD()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct NCCOHDBCPBL : IAsyncStateMachine
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
			private LAIIEKMKLDK <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7585640", Offset = "0x7584440", VA = "0x187585640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7586320", Offset = "0x7585120", VA = "0x187586320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct KCFHIJAFNKJ : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x7583890", Offset = "0x7582690", VA = "0x187583890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7583E20", Offset = "0x7582C20", VA = "0x187583E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float HEDLACEOHJP;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static EILEDNOBBBM BMDDNKKDAIM;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource DPALJNDEOHL;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool GLBKLJFLAFD;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int OPIAHCLHHHO;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly HLGFIGBDGLB<NLNONFMLLBB, bool> KEFMLDALMME;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static IDLEFJOKAJP<NLNONFMLLBB, bool> FNEJILLFMGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7583670", Offset = "0x7582470", VA = "0x187583670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool CPMDENMJAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7582550", Offset = "0x7581350", VA = "0x187582550")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7582B70", Offset = "0x7581970", VA = "0x187582B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool GDNLCFCKAPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7582D60", Offset = "0x7581B60", VA = "0x187582D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7582760", Offset = "0x7581560", VA = "0x187582760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float DMLCNBKIAJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x75830A0", Offset = "0x7581EA0", VA = "0x1875830A0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x75836C0", Offset = "0x75824C0", VA = "0x1875836C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7582BD0", Offset = "0x75819D0", VA = "0x187582BD0")]
		[ODKIEBDNNBP.PCKPOJFMDIC]
		internal static void HLIMBPHODGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x75827C0", Offset = "0x75815C0", VA = "0x1875827C0")]
		internal static void DGPDNICIDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x75825A0", Offset = "0x75813A0", VA = "0x1875825A0")]
		internal static void ANKJIMJKEFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7582CF0", Offset = "0x7581AF0", VA = "0x187582CF0")]
		internal static void JIIPGDFKDAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7583540", Offset = "0x7582340", VA = "0x187583540")]
		public static void NLJJDHLGPOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x75830F0", Offset = "0x7581EF0", VA = "0x1875830F0")]
		private static void NLILAPEEFGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7582DB0", Offset = "0x7581BB0", VA = "0x187582DB0")]
		private static void KBCCGPPDBOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7582AA0", Offset = "0x75818A0", VA = "0x187582AA0")]
		[AsyncStateMachine(typeof(NCCOHDBCPBL))]
		private static Task GIHGGCGMAMC(CancellationToken HIMDFBHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x75829C0", Offset = "0x75817C0", VA = "0x1875829C0")]
		private static void FNAHFACHDMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7583590", Offset = "0x7582390", VA = "0x187583590")]
		[AsyncStateMachine(typeof(KCFHIJAFNKJ))]
		private static Task NPOLNAAKAHF(bool HKBABBOEHIG, [Optional] CancellationToken HIMDFBHMPLL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class DHFAIAJLIFE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class CCCBIJEPHPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public DHFAIAJLIFE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public CCCBIJEPHPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6708050", Offset = "0x6706E50", VA = "0x186708050")]
			internal object OJLAIAJCCKH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class GNAPNPEFFKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public DHFAIAJLIFE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public GNAPNPEFFKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4DBE150", Offset = "0x4DBCF50", VA = "0x184DBE150")]
			internal object MCCCGNKFAMG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class LIJNCFDIOGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public DHFAIAJLIFE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public LIJNCFDIOGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x547E3C0", Offset = "0x547D1C0", VA = "0x18547E3C0")]
			internal object CNENOCFOFOI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class DPEDDJIDGDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public DHFAIAJLIFE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public DPEDDJIDGDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6E202C0", Offset = "0x6E1F0C0", VA = "0x186E202C0")]
			internal object GAKKKHNBDGF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class EHBBDEBBJMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public DHFAIAJLIFE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public EHBBDEBBJMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x4822780", Offset = "0x4821580", VA = "0x184822780")]
			internal object KEPFIMFALKK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class HNPKKDNNECK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public DHFAIAJLIFE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public HNPKKDNNECK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x4E46890", Offset = "0x4E45690", VA = "0x184E46890")]
			internal object GILEGNAAACE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class KJHDOFDJNBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public DHFAIAJLIFE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public KJHDOFDJNBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x52DCCB0", Offset = "0x52DBAB0", VA = "0x1852DCCB0")]
			internal object OIDGNDNNKCK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float JEKMNDHGAHA = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid HGLHDGHKJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Guid OHNAKIFODPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string JJONDEPPKBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string JACGMHFCLMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string MKEMEKJOEHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string FGNCFFIMJMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string PFCLKDOILGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string GNHHGDLMCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string AGKJAMJKPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string ICGDMFICNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string ODBAFMBKDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string MNDMGBEDAFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private string OEBCFNHEEBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Guid? ADHDICHLGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private (int, int)? LOJCECCPJMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly HashSet<T> EPOMOKAAFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(T, int), string> FNCABIHDAGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<(T, int), float> JMIACHAHIOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string> FMEFECKDAPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<T, string> IFDAKIKBKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<T, string> IDIDMGOCMEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Dictionary<T, string[]> INDNGFLLEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private string AAELHODFDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool GPHLBDKDCKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Task AAHGHOHLNHF;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6DE6DF0", Offset = "0x6DE5BF0", VA = "0x186DE6DF0")]
		public DHFAIAJLIFE(Guid HGLHDGHKJJM, Guid OHNAKIFODPI, string JACGMHFCLMH, string JJONDEPPKBO, string MKEMEKJOEHC, [Optional] string FGNCFFIMJMF, [Optional] string PFCLKDOILGD, [Optional] string GNHHGDLMCHO, [Optional] string ODBAFMBKDIK, [Optional] string AAELHODFDCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA60470", Offset = "0xA5F270", VA = "0x180A60470")]
		public void BHPOFOICBCJ(string FGNCFFIMJMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA5C310", Offset = "0xA5B110", VA = "0x180A5C310")]
		public void GBOEFMMBAEL(string MKEMEKJOEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xAD41E0", Offset = "0xAD2FE0", VA = "0x180AD41E0")]
		public void EMIBLDOHHBD(string AAELHODFDCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA5F350", Offset = "0xA5E150", VA = "0x180A5F350")]
		public void PKBKNMMODAN(string AGKJAMJKPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA66740", Offset = "0xA65540", VA = "0x180A66740")]
		public void GPOPBDOOBJP(string MNDMGBEDAFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA66710", Offset = "0xA65510", VA = "0x180A66710")]
		public void AJAOPBLJDPM(string OEBCFNHEEBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6DDFA00", Offset = "0x6DDE800", VA = "0x186DDFA00")]
		public void APGHJHCBDOE(Guid? HGLHDGHKJJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x18B9190", Offset = "0x18B7F90", VA = "0x1818B9190")]
		public void BINOIOMCPOK((int, int)? LOJCECCPJMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA5F340", Offset = "0xA5E140", VA = "0x180A5F340")]
		public void GKHENJEGAIP(string ICGDMFICNDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6DE69C0", Offset = "0x6DE57C0", VA = "0x186DE69C0")]
		public void PFMPHFBDHJI(T GFOBNMKBBFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2F60", Offset = "0x6DE1D60", VA = "0x186DE2F60")]
		public void DBHCMLKJINA(T GFOBNMKBBFF, int NKLNJMIBGPI, float CFEOPLEMNPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6DE6290", Offset = "0x6DE5090", VA = "0x186DE6290")]
		public void NFDCBKHFEIC(T GFOBNMKBBFF, int NKLNJMIBGPI, string MFABIJECOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6DE5F90", Offset = "0x6DE4D90", VA = "0x186DE5F90")]
		public void LGHILKPNNBB(T GFOBNMKBBFF, string AGFGPDGAIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6DDF880", Offset = "0x6DDE680", VA = "0x186DDF880")]
		public void AJGKDMIOFPG(T GFOBNMKBBFF, string PLIKFIIPHNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6DDF080", Offset = "0x6DDDE80", VA = "0x186DDF080")]
		public void ACGEDFMOJJC(T GFOBNMKBBFF, bool GPBALJLMKOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2C60", Offset = "0x6DE1A60", VA = "0x186DE2C60")]
		public void BPKIOAEKDEP(T GFOBNMKBBFF, string[] OBDHJEIDEBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE1980", Offset = "0x6DE0780", VA = "0x186DE1980")]
		public Task BJLPCCNDGPM(bool ADJOPEHJOFG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6DE40A0", Offset = "0x6DE2EA0", VA = "0x186DE40A0")]
		private (IEnumerable<T>, string) EJKIMJODDIK()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6DE5330", Offset = "0x6DE4130", VA = "0x186DE5330")]
		public static NLNONFMLLBB JPGEPAJGCLA(Guid HGLHDGHKJJM, Guid OHNAKIFODPI, string JACGMHFCLMH, T GFOBNMKBBFF, string JJONDEPPKBO, string LIBFBAIPCIG, string FGNCFFIMJMF, int? CKFKPOAGPKN, [Optional] string OBMEJFPBPPM, [Optional] string AGFGPDGAIDH, [Optional] int? NANJAHIOCPJ, [Optional] Guid? ADHDICHLGKM, [Optional] string AAELHODFDCO, [Optional] string HIBMHLGALGH, [Optional] (int, int)? LOJCECCPJMC, [Optional] string KDGAOEONNBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2930", Offset = "0x6DE1730", VA = "0x186DE2930")]
		[CompilerGenerated]
		private string BNBDPCBEMMF(T PPPFBKMGIMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6DE5D80", Offset = "0x6DE4B80", VA = "0x186DE5D80")]
		[CompilerGenerated]
		private string KPFMHJKPEFB(T PPPFBKMGIMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6DE38F0", Offset = "0x6DE26F0", VA = "0x186DE38F0")]
		[CompilerGenerated]
		private string DJCMIHLOGGO(T PPPFBKMGIMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6DE4CF0", Offset = "0x6DE3AF0", VA = "0x186DE4CF0")]
		[CompilerGenerated]
		private string JOBIBMOEMKP(T PPPFBKMGIMA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class CDJNPPCKOHF<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected readonly string DPBKJDNMHKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected readonly Guid IDCMPGCDJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected readonly long CDGHLBLIBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected int POKGNKCLMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected int HIDJKPNGAAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		protected DateTime MNBMLEJDCHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		protected bool FNLFNNBBBCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		protected Dictionary<long, GCKNCGJIAAK> POEBFHOPLPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		protected bool BPKGACOKGHA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool CCKFJFKMOIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD238E0", Offset = "0xD226E0", VA = "0x180D238E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool OCKPNKPDEEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xACBBC0", Offset = "0xACA9C0", VA = "0x180ACBBC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x67099C0", Offset = "0x67087C0", VA = "0x1867099C0")]
		public CDJNPPCKOHF(string DPBKJDNMHKG, Guid IDCMPGCDJPK, long CDGHLBLIBBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void OMAIMOHCKOB(TListSessionStartParams GGNEPBLPGFH);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x23A53D0", Offset = "0x23A41D0", VA = "0x1823A53D0")]
		public void NOCPOLKMIBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void CGNFOGGKGMB(bool LKFOHABFCKF, TListSessionLogParams LKPFONIJBEP);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6709700", Offset = "0x6708500", VA = "0x186709700")]
		public void KKCDBHEFJOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6709750", Offset = "0x6708550", VA = "0x186709750")]
		public void OFDJNIKNMKH(long NENMJCEFFAO, int CKFKPOAGPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6709590", Offset = "0x6708390", VA = "0x186709590")]
		public void HHKDGINBNLI(long NENMJCEFFAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract GCKNCGJIAAK IOEGECPGBOH(TItem EHKDLJBBGDB, int CKFKPOAGPKN, string MGMCAGDADHN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class GCKNCGJIAAK : PCABCDHFPBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int POKGNKCLMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private long NENMJCEFFAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private long CDGHLBLIBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly string FNOIEFBKCDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string AKAPPMNLOGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly int HPFDPDODKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private DateTime FPGHFMFBIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private double ILOHMCGLFIB;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool CIJJNDKEBDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xF56A60", Offset = "0xF55860", VA = "0x180F56A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xF56A50", Offset = "0xF55850", VA = "0x180F56A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7581DC0", Offset = "0x7580BC0", VA = "0x187581DC0")]
		public GCKNCGJIAAK(long NENMJCEFFAO, int POKGNKCLMLJ, string HIBMHLGALGH, long CDGHLBLIBBM, int HPFDPDODKPE, [Optional] string JJONDEPPKBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7581D50", Offset = "0x7580B50", VA = "0x187581D50")]
		public void PNBDADCICHM(int POKGNKCLMLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7581740", Offset = "0x7580540", VA = "0x187581740")]
		public void GBLLHLJEHJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7581C40", Offset = "0x7580A40", VA = "0x187581C40")]
		public void NMCMGDLJKLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x75816D0", Offset = "0x75804D0", VA = "0x1875816D0")]
		private void CIBJGGCIKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7581790", Offset = "0x7580590", VA = "0x187581790", Slot = "5")]
		public virtual NLNONFMLLBB LOFLLFDJBNK(Guid HGLHDGHKJJM, string IHAEBDNDBPH, [Optional] string HIBMHLGALGH, [Optional] long? GFOBNMKBBFF, [Optional] string JJONDEPPKBO, [Optional] string FGNCFFIMJMF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class BEDAAFAOEHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static Dictionary<string, Dictionary<string, object>> AGPCKLEJMBA;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static string AIEDEOKPJEI;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static int OCAKMHKLFPH;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly Dictionary<string, ILJEPDICNEF> GPCNBBHCBNB;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string JKEHCMDJBPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x757EF60", Offset = "0x757DD60", VA = "0x18757EF60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x757E5A0", Offset = "0x757D3A0", VA = "0x18757E5A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool FCEGABIGLMN
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x757E0A0", Offset = "0x757CEA0", VA = "0x18757E0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> AFCKIKHNBKH
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x757EA80", Offset = "0x757D880", VA = "0x18757EA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? GBNONBFMGNL
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x757E660", Offset = "0x757D460", VA = "0x18757E660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x757F210", Offset = "0x757E010", VA = "0x18757F210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? PCAFPCHFCIK
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x757E210", Offset = "0x757D010", VA = "0x18757E210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x757E280", Offset = "0x757D080", VA = "0x18757E280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x757EAD0", Offset = "0x757D8D0", VA = "0x18757EAD0")]
		public static void MLMNFPDHEHE(string IJAJACIJKDI, ILJEPDICNEF KPBLFDLJCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x757E4C0", Offset = "0x757D2C0", VA = "0x18757E4C0")]
		internal static void DGPDNICIDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x757E130", Offset = "0x757CF30", VA = "0x18757E130")]
		internal static void ANKJIMJKEFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x757E8E0", Offset = "0x757D6E0", VA = "0x18757E8E0")]
		internal static void JIIPGDFKDAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x757F310", Offset = "0x757E110", VA = "0x18757F310")]
		public static Guid OMAIMOHCKOB(string IJAJACIJKDI, [Optional] string? CONHPNLNOIP, [Optional] Dictionary<string, object>? MKHMHAFBAKI)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x757F270", Offset = "0x757E070", VA = "0x18757F270")]
		public static Guid OMAIMOHCKOB(string IJAJACIJKDI, long CONHPNLNOIP, [Optional] Dictionary<string, object>? MKHMHAFBAKI)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x757EFB0", Offset = "0x757DDB0", VA = "0x18757EFB0")]
		public static void NOCPOLKMIBK(string IJAJACIJKDI, [Optional] Guid? OKDHAOKOGCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x757E6D0", Offset = "0x757D4D0", VA = "0x18757E6D0")]
		public static void IOLMKAIACNA(string IJAJACIJKDI, string JGGGOGKAHLP, object ILAFGDBMMFB, bool GLBKLJFLAFD = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x757F8F0", Offset = "0x757E6F0", VA = "0x18757F8F0")]
		public static bool PMPFMDLCBLP(string IJAJACIJKDI, [Optional] string? CONHPNLNOIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x757E340", Offset = "0x757D140", VA = "0x18757E340")]
		private static void DDCJPLPNABH(bool CPBAEDKJHPE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x757E2E0", Offset = "0x757D0E0", VA = "0x18757E2E0")]
		public static void CHPNNFCJLNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x757E960", Offset = "0x757D760", VA = "0x18757E960")]
		private static void KBCCGPPDBOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x757EB60", Offset = "0x757D960", VA = "0x18757EB60")]
		private static void NKIKCDPOAMB(string IJAJACIJKDI, Guid HGLHDGHKJJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class GDNEEDMBMCN
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct JBDNLKOMMBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public bool BIFFJAIGCIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public string DBLHLEOMFHK;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xD253E0", Offset = "0xD241E0", VA = "0x180D253E0")]
			public JBDNLKOMMBP(bool BIFFJAIGCIP, string DBLHLEOMFHK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7582050", Offset = "0x7580E50", VA = "0x187582050")]
		public static JBDNLKOMMBP OJKKHHLLEBA(NLNONFMLLBB AIDBMKGCNNA)
		{
			return default(JBDNLKOMMBP);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7581F50", Offset = "0x7580D50", VA = "0x187581F50")]
		private static void JJGPBOAINNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7581E90", Offset = "0x7580C90", VA = "0x187581E90")]
		private static void IBLIEHGGCMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class HFGHLGILPCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7583830", Offset = "0x7582630", VA = "0x187583830")]
		public static NLNONFMLLBB NDLEJGEIFOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class MGMJDENINLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7584CE0", Offset = "0x7583AE0", VA = "0x187584CE0")]
		public static NLNONFMLLBB DHHPEPFKBFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7584F20", Offset = "0x7583D20", VA = "0x187584F20")]
		public static NLNONFMLLBB LKPGPJGFDFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7584E00", Offset = "0x7583C00", VA = "0x187584E00")]
		public static NLNONFMLLBB FENNJICCOMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7584D40", Offset = "0x7583B40", VA = "0x187584D40")]
		public static NLNONFMLLBB DODNAGIMOFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x75850A0", Offset = "0x7583EA0", VA = "0x1875850A0")]
		public static NLNONFMLLBB PCKHODFHJHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7585040", Offset = "0x7583E40", VA = "0x187585040")]
		public static NLNONFMLLBB ONKPBGPFGCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7584BC0", Offset = "0x75839C0", VA = "0x187584BC0")]
		public static NLNONFMLLBB CDOCAOGLBJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7584C80", Offset = "0x7583A80", VA = "0x187584C80")]
		public static NLNONFMLLBB CMKLDLDFHKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7584E60", Offset = "0x7583C60", VA = "0x187584E60")]
		public static NLNONFMLLBB KKIFBPEBOOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7585100", Offset = "0x7583F00", VA = "0x187585100")]
		public static NLNONFMLLBB PHPDLPFLKBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7584C20", Offset = "0x7583A20", VA = "0x187584C20")]
		public static NLNONFMLLBB CKNBCFJIOGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7584EC0", Offset = "0x7583CC0", VA = "0x187584EC0")]
		public static NLNONFMLLBB LAELBNGLEIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7584DA0", Offset = "0x7583BA0", VA = "0x187584DA0")]
		public static NLNONFMLLBB EBJLDLOIOLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7584F80", Offset = "0x7583D80", VA = "0x187584F80")]
		public static NLNONFMLLBB NBPDBAFLKFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7584FE0", Offset = "0x7583DE0", VA = "0x187584FE0")]
		public static NLNONFMLLBB OIBPCGMEDBI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class GKJPHPLHBPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7582370", Offset = "0x7581170", VA = "0x187582370")]
		public static NLNONFMLLBB APKLOPPBNMO(long NCGHDDJNJOM, long KAAGEAEADCM, bool IJANBICFOPA, string LPKDJKNJGHL, string MPMPDAHLNOG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class CJEEFHLLBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x757FC80", Offset = "0x757EA80", VA = "0x18757FC80")]
		public static NLNONFMLLBB ECIPPFNLDHK(string JIJAOIGEPPB, string LFALACKPEJL, bool OCAEEIHIGHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x757FDF0", Offset = "0x757EBF0", VA = "0x18757FDF0")]
		public static NLNONFMLLBB IMMMKGGEPEL(Guid OHNAKIFODPI, string IEOOLFDDEEF, string ANEKJEBCCOJ, string OADOKANOPOA, [Optional] int? ENHIJOONAOM, [Optional] double[] KOKALIINEJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x75800A0", Offset = "0x757EEA0", VA = "0x1875800A0")]
		public static NLNONFMLLBB KFJOGDLCNHE(Guid OHNAKIFODPI, Guid ANOLHJABADL, bool PFDKMCCCPKA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KNPEAKEHPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7583FB0", Offset = "0x7582DB0", VA = "0x187583FB0")]
		public static NLNONFMLLBB DHFMHJLMNPJ(string NNDNHNGFCNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7583ED0", Offset = "0x7582CD0", VA = "0x187583ED0")]
		public static NLNONFMLLBB AEEHLNFIJAN(string OPDIDEGOBPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7584090", Offset = "0x7582E90", VA = "0x187584090")]
		public static NLNONFMLLBB GNLIKKLBOBN(int ADHDKEKHIJI, string GGDFKFACHGG, string PPPFBKMGIMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7584300", Offset = "0x7583100", VA = "0x187584300")]
		public static NLNONFMLLBB OFMEECDDILO(int ADHDKEKHIJI, string GGDFKFACHGG, string PPPFBKMGIMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x75840F0", Offset = "0x7582EF0", VA = "0x1875840F0")]
		public static NLNONFMLLBB JIHAMPLIHFB(int ADHDKEKHIJI, string GGDFKFACHGG, string PPPFBKMGIMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7584150", Offset = "0x7582F50", VA = "0x187584150")]
		public static NLNONFMLLBB JMJPFPJJIMO(int ADHDKEKHIJI, string GGDFKFACHGG, string PPPFBKMGIMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x75841B0", Offset = "0x7582FB0", VA = "0x1875841B0")]
		public static NLNONFMLLBB MCDENGAHIOC(string GGDFKFACHGG, string PPPFBKMGIMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7584360", Offset = "0x7583160", VA = "0x187584360")]
		private static NLNONFMLLBB PDGPLIEANKF(string DPBKJDNMHKG, int ADHDKEKHIJI, string NGGDPEFMCCK, string NNHDOHAOFLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x75844A0", Offset = "0x75832A0", VA = "0x1875844A0")]
		private static NLNONFMLLBB PDGPLIEANKF(string DPBKJDNMHKG, string NGGDPEFMCCK, string NNHDOHAOFLG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly PHLHEDGDBJO OJKKHHLLEBA;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static CALDANMDCAE PGLPLMOMPKJ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static MDLFBMPACAJ BIJCLBCJINP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<NLNONFMLLBB> FNFNGNNGPBJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long CJFLEDOLMDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7587530", Offset = "0x7586330", VA = "0x187587530")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x75877B0", Offset = "0x75865B0", VA = "0x1875877B0")]
	[ODKIEBDNNBP.PCKPOJFMDIC]
	internal static void ODGHOGCLEON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x75873E0", Offset = "0x75861E0", VA = "0x1875873E0")]
	private static void EAAMKLPADPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x75874B0", Offset = "0x75862B0", VA = "0x1875874B0")]
	public static NLNONFMLLBB EMACDBFMCKL(string AHDIMGPOHGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x757DB80", Offset = "0x757C980", VA = "0x18757DB80")]
	public static NLNONFMLLBB EMACDBFMCKL(string AHDIMGPOHGO, int ADHDKEKHIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7587740", Offset = "0x7586540", VA = "0x187587740")]
	public static bool LLCBINMIBHD(this EILEDNOBBBM OFKHCEGFELJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7587620", Offset = "0x7586420", VA = "0x187587620")]
	[ODKIEBDNNBP.PCKPOJFMDIC]
	internal static void HCOGCDKBBOI()
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
