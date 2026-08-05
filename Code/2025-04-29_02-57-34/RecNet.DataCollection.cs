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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x7039EC0", Offset = "0x70392C0", VA = "0x187039EC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
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
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7039250", Offset = "0x7038650", VA = "0x187039250", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x703A460", Offset = "0x7039860", VA = "0x18703A460", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x25D0340", Offset = "0x25CF740", VA = "0x1825D0340")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NHKMFOIGABB
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> LPGEKJONOAM();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GCIJNPLKKDH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7035520", Offset = "0x7034920", VA = "0x187035520")]
	public static void AHOMMJHPEBA(this EFFOBBJCDDH.BAJPIFGIBCF OHCDCDNAHPO, string EBCFFGLHLLD, string MGPPGNMDGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7035590", Offset = "0x7034990", VA = "0x187035590")]
	public static void AHOMMJHPEBA(this EFFOBBJCDDH.BAJPIFGIBCF OHCDCDNAHPO, string EBCFFGLHLLD, bool MGPPGNMDGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7035620", Offset = "0x7034A20", VA = "0x187035620")]
	public static void AHOMMJHPEBA(this EFFOBBJCDDH.BAJPIFGIBCF OHCDCDNAHPO, string EBCFFGLHLLD, float OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x70351D0", Offset = "0x70345D0", VA = "0x1870351D0")]
	public static void AHOMMJHPEBA(this EFFOBBJCDDH.BAJPIFGIBCF OHCDCDNAHPO, string EBCFFGLHLLD, KIMGPCEMKIM MGPPGNMDGDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EFFOBBJCDDH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface KFMHAHHOCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		BAJPIFGIBCF COECNICIANP(Guid EPLNDGCAAIK, string ECLGICACINA, [Optional] string LFBFCCKOHBA, [Optional] long? NFNHJEDIBOM, [Optional] string JIHGIEGKKAF, [Optional] string MAPECHCMLFK);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class POONJHPIFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7039F40", Offset = "0x7039340", VA = "0x187039F40")]
		public static BAJPIFGIBCF EAFHJLJGBMA(Guid EPLNDGCAAIK, string ECLGICACINA, string LFBFCCKOHBA, [Optional] long? NFNHJEDIBOM, [Optional] string JIHGIEGKKAF, [Optional] string MAPECHCMLFK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class BAJPIFGIBCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected LNJHNKLNLJH NIIPCCMNFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> OINNLFLPOKM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool MKDGKPOHJNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7030DF0", Offset = "0x70301F0", VA = "0x187030DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string CEPAIFMODFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x10A6CF0", Offset = "0x10A60F0", VA = "0x1810A6CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7030E30", Offset = "0x7030230", VA = "0x187030E30")]
		public BAJPIFGIBCF(LNJHNKLNLJH NIIPCCMNFHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7030D70", Offset = "0x7030170", VA = "0x187030D70")]
		public BAJPIFGIBCF MPOICDHJMKG(string EKNPKHOHCLO, string OOEMJLHLIHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC1B0", Offset = "0x3DDB5B0", VA = "0x183DDC1B0")]
		public BAJPIFGIBCF MPOICDHJMKG<T>(string EKNPKHOHCLO, T OOEMJLHLIHJ) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7030770", Offset = "0x702FB70", VA = "0x187030770")]
		public BAJPIFGIBCF IJLAPKMCBPC(string EKNPKHOHCLO, object OOEMJLHLIHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC120", Offset = "0x3DDB520", VA = "0x183DDC120")]
		public BAJPIFGIBCF LAAINMFNMAJ<T>(string EKNPKHOHCLO, T? OOEMJLHLIHJ) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7030AB0", Offset = "0x702FEB0", VA = "0x187030AB0")]
		public BAJPIFGIBCF LAAINMFNMAJ(string EKNPKHOHCLO, string OOEMJLHLIHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7030C20", Offset = "0x7030020", VA = "0x187030C20")]
		public BAJPIFGIBCF LICDPKFONEK(string CKFODKCDADH, string IICGAABOENK, object AOFGGGKINCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7030B40", Offset = "0x702FF40", VA = "0x187030B40")]
		public BAJPIFGIBCF LICDPKFONEK(string CKFODKCDADH, IDictionary<string, object> NFMDGGFOHIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7030710", Offset = "0x702FB10", VA = "0x187030710")]
		private static IDictionary<string, object> IAHMIKNHNIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x70307F0", Offset = "0x702FBF0", VA = "0x1870307F0")]
		public void KCMFJHDBIDP(bool JBGPIHKPNPD, string EMJIDFDHLIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7030610", Offset = "0x702FA10", VA = "0x187030610")]
		public Task CDHIPNCMILL([Optional] CancellationToken JDDHIJBJNHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x26E82F0", Offset = "0x26E76F0", VA = "0x1826E82F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class LNJHNKLNLJH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct MIBBHPCJGJH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public LNJHNKLNLJH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x70392E0", Offset = "0x70386E0", VA = "0x1870392E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7039760", Offset = "0x7038B60", VA = "0x187039760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<LNJHNKLNLJH> LKGNBFFJCBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string KNHBECPAEPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> FBNDNMMIEOG;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CEPAIFMODFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7038F00", Offset = "0x7038300", VA = "0x187038F00")]
		private LNJHNKLNLJH(string KNHBECPAEPN, int KGKDIIKHGOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7033BC0", Offset = "0x7032FC0", VA = "0x187033BC0")]
		public static BAJPIFGIBCF BPKMLDCMEGB(string KNHBECPAEPN, int KGKDIIKHGOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7038CE0", Offset = "0x70380E0", VA = "0x187038CE0")]
		[AsyncStateMachine(typeof(MIBBHPCJGJH))]
		public Task CDHIPNCMILL([Optional] CancellationToken JDDHIJBJNHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7038E90", Offset = "0x7038290", VA = "0x187038E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3798320", Offset = "0x3797720", VA = "0x183798320")]
		internal void JBJAGCGPEFA<T>(string EKNPKHOHCLO, T OOEMJLHLIHJ) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7038DD0", Offset = "0x70381D0", VA = "0x187038DD0")]
		internal void ICDAGDPKMNN(string EKNPKHOHCLO, object OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7038E30", Offset = "0x7038230", VA = "0x187038E30")]
		internal void JBJAGCGPEFA(string EKNPKHOHCLO, string OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE37C0", Offset = "0x3DE2BC0", VA = "0x183DE37C0")]
		private void AJFIKNHMGIJ<T>(string EKNPKHOHCLO, T OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct CMHOBLPDLAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string KJMKCALAJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? OOPNDDKBIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? IFKGLIJJBGM;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7033850", Offset = "0x7032C50", VA = "0x187033850")]
		public CMHOBLPDLAD(string KNAFGFIPLIE, [Optional] long? NFMLPECGLEO, [Optional] short? HHJNNNEDAPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct BACBLIMGLGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int ELAFKJKCDMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string MMEKPCKEECG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short HEMFFGFIMLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string FCADMAPJMDB;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x70305C0", Offset = "0x702F9C0", VA = "0x1870305C0")]
		public BACBLIMGLGM(int NFGKGIELNGI, string COKIMAMLABM, short PMJKLPMHADC, string IIGCHPKAECA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class GNAALMNOLIG : NFOHBLIKDMH<KOGMGFFENJD, BACBLIMGLGM, CMHOBLPDLAD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string COKIMAMLABM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short PMJKLPMHADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string IIGCHPKAECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> APNJIHMMPDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int NHMHPAFBOEP;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7036F40", Offset = "0x7036340", VA = "0x187036F40")]
		public GNAALMNOLIG(string KCJIBHFNFKD, Guid OLLFBIGBIND, long KAGMGJINBIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7035E60", Offset = "0x7035260", VA = "0x187035E60", Slot = "4")]
		public override void JLIKDJIHONN(BACBLIMGLGM EDMMJKKGEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7035AC0", Offset = "0x7034EC0", VA = "0x187035AC0")]
		public void BDFNGAJAGOP(short PMJKLPMHADC, bool INNKMMOOGEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x47C2900", Offset = "0x47C1D00", VA = "0x1847C2900")]
		public void NKJBMFELLKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9CD850", Offset = "0x9CCC50", VA = "0x1809CD850")]
		public void GAFOBCGBAPL(string DKPKPGOFOGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7036150", Offset = "0x7035550", VA = "0x187036150", Slot = "5")]
		public override void PEDPOGIBKHE(bool ONMMEOIBLFM, CMHOBLPDLAD PINCLCFEFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7035BA0", Offset = "0x7034FA0", VA = "0x187035BA0", Slot = "6")]
		public override LIJIFPAJDCH HKKOJLNGCCD(KOGMGFFENJD NODPHGBANOA, int COPLIEINKOF, string BOLDNJGGIDM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class LHGAGPOFPLK : LIJIFPAJDCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string COKIMAMLABM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short PMJKLPMHADC;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7038430", Offset = "0x7037830", VA = "0x187038430")]
		public LHGAGPOFPLK(long OFMELAFEMHB, int NFGKGIELNGI, string LFBFCCKOHBA, long KAGMGJINBIJ, int NJMPKDPFOAC, string JIHGIEGKKAF, short PMJKLPMHADC, string COKIMAMLABM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x70383A0", Offset = "0x70377A0", VA = "0x1870383A0")]
		public void IAHDLDJDJDL(int NFGKGIELNGI, string COKIMAMLABM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7038270", Offset = "0x7037670", VA = "0x187038270", Slot = "5")]
		public override BAJPIFGIBCF COECNICIANP(Guid EPLNDGCAAIK, string ECLGICACINA, [Optional] string LFBFCCKOHBA, [Optional] long? NFNHJEDIBOM, [Optional] string JIHGIEGKKAF, [Optional] string MAPECHCMLFK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class FGHDONNCFBN
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class CBKANMIGPCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public CBKANMIGPCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7032A70", Offset = "0x7031E70", VA = "0x187032A70")]
			internal bool MBHCNKCKJPP()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct CIKOEKJANNN : IAsyncStateMachine
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
			private CBKANMIGPCN <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7032B10", Offset = "0x7031F10", VA = "0x187032B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x70337F0", Offset = "0x7032BF0", VA = "0x1870337F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct IGIEIKCDHBN : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x7037500", Offset = "0x7036900", VA = "0x187037500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7037A90", Offset = "0x7036E90", VA = "0x187037A90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float IIJLCODIICO;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static PCFGMNCOCPN MIBMBMCHHLM;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource NLANPGCNACM;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool GBKCNCGJFFG;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int PJDIIJNFEOG;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly DEBGLLPOJFA<BAJPIFGIBCF, bool> BCMKLIEKNEP;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static FBEJGFBHLEF<BAJPIFGIBCF, bool> NAMDELPLMJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7035070", Offset = "0x7034470", VA = "0x187035070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool ADKBMFKEHMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7034C80", Offset = "0x7034080", VA = "0x187034C80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7034EF0", Offset = "0x70342F0", VA = "0x187034EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool LADPFJPJNGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x70340C0", Offset = "0x70334C0", VA = "0x1870340C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7034DB0", Offset = "0x70341B0", VA = "0x187034DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float HDKMIEJLMIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7033EE0", Offset = "0x70332E0", VA = "0x187033EE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7034C20", Offset = "0x7034020", VA = "0x187034C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7033F30", Offset = "0x7033330", VA = "0x187033F30")]
		[GEMHNPPGODB.JLNPPECHEJF]
		internal static void DNJHDKEKBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7034110", Offset = "0x7033510", VA = "0x187034110")]
		internal static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7034600", Offset = "0x7033A00", VA = "0x187034600")]
		internal static void HAHHCGEAEBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7034050", Offset = "0x7033450", VA = "0x187034050")]
		internal static void EGGAJNGPAKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7035020", Offset = "0x7034420", VA = "0x187035020")]
		public static void ODAIJJDJDMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x70347C0", Offset = "0x7033BC0", VA = "0x1870347C0")]
		private static void IINBDDIKDIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7034310", Offset = "0x7033710", VA = "0x187034310")]
		private static void GFANFOACAGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7034F50", Offset = "0x7034350", VA = "0x187034F50")]
		[AsyncStateMachine(typeof(CIKOEKJANNN))]
		private static Task NPDLONCPLNH(CancellationToken JDDHIJBJNHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7034E10", Offset = "0x7034210", VA = "0x187034E10")]
		private static void LOMCIGHJHFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7034CD0", Offset = "0x70340D0", VA = "0x187034CD0")]
		[AsyncStateMachine(typeof(IGIEIKCDHBN))]
		private static Task JPMCNMMGDLL(bool LJJFNBEACOJ, [Optional] CancellationToken JDDHIJBJNHP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class HEGAKNGNOJP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class ILOPIDACHDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public HEGAKNGNOJP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public ILOPIDACHDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x4A66EB0", Offset = "0x4A662B0", VA = "0x184A66EB0")]
			internal object FLILIHNCALL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class ALGELIKOLIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public HEGAKNGNOJP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public ALGELIKOLIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4BCD850", Offset = "0x4BCCC50", VA = "0x184BCD850")]
			internal object FEHHFMGGBKG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class AKBNFJEFHED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public HEGAKNGNOJP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public AKBNFJEFHED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4BC3D80", Offset = "0x4BC3180", VA = "0x184BC3D80")]
			internal object DHHGLMMGNME()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class GHBFKFCCPPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public HEGAKNGNOJP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public GHBFKFCCPPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x48BC000", Offset = "0x48BB400", VA = "0x1848BC000")]
			internal object JHEFBLCMBKM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class MLONICANLAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public HEGAKNGNOJP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public MLONICANLAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x50DEEF0", Offset = "0x50DE2F0", VA = "0x1850DEEF0")]
			internal object GMKDJECNILG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class CKEOBPGLNEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public HEGAKNGNOJP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public CKEOBPGLNEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x662B2F0", Offset = "0x662A6F0", VA = "0x18662B2F0")]
			internal object JDINHBAJNAE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class DFBMNAEMHNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public HEGAKNGNOJP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public DFBMNAEMHNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x688C500", Offset = "0x688B900", VA = "0x18688C500")]
			internal object FJMHMPGHMHI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float PANMJNJBGMA = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid EPLNDGCAAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly string JIHGIEGKKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string PMIOGEIKPIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string MBEJBKDNEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string MAPECHCMLFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string BOHEHJKLKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string CGLIGOIPMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string LLLMHFHALLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string CAEEKMAHMFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string JDMNGJEEHNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string CANIMBCOLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string PCJLGDPHEII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Guid? AJIFIDJHIHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private (int, int)? HKKMNBOCCII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly HashSet<T> MDNGNKKPELP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<(T, int), string> BILDCJEGPIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(T, int), float> LJICFEMLGHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<T, string> OKFNGIGCLFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string> AOBFEBAHLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<T, string> KIGJPCMFIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<T, string[]> CJHOCJMCGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private string IPGFEBHNNHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private bool ICOILBOPBIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Task BPLFADLFAAJ;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x491D340", Offset = "0x491C740", VA = "0x18491D340")]
		public HEGAKNGNOJP(Guid EPLNDGCAAIK, string PMIOGEIKPIN, string JIHGIEGKKAF, string MBEJBKDNEMC, [Optional] string MAPECHCMLFK, [Optional] string BOHEHJKLKGH, [Optional] string CGLIGOIPMEH, [Optional] string JDMNGJEEHNH, [Optional] string IPGFEBHNNHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9C9210", Offset = "0x9C8610", VA = "0x1809C9210")]
		public void PEGJKOJIGBD(string MAPECHCMLFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9D24B0", Offset = "0x9D18B0", VA = "0x1809D24B0")]
		public void MKMPHEJGHKO(string MBEJBKDNEMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA633D0", Offset = "0xA627D0", VA = "0x180A633D0")]
		public void FBBIEGKILJE(string IPGFEBHNNHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9CD7E0", Offset = "0x9CCBE0", VA = "0x1809CD7E0")]
		public void FDKNBDIKNCE(string LLLMHFHALLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9CD850", Offset = "0x9CCC50", VA = "0x1809CD850")]
		public void IFAFOANOKEK(string CANIMBCOLCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9CD830", Offset = "0x9CCC30", VA = "0x1809CD830")]
		public void OEICHNJAGPM(string PCJLGDPHEII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4914C80", Offset = "0x4914080", VA = "0x184914C80")]
		public void ACIMPIOFALB(Guid? EPLNDGCAAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x491C6B0", Offset = "0x491BAB0", VA = "0x18491C6B0")]
		public void NMHOIHOBODJ((int, int)? HKKMNBOCCII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9CD7F0", Offset = "0x9CCBF0", VA = "0x1809CD7F0")]
		public void PAIECDDDLFB(string CAEEKMAHMFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4919F70", Offset = "0x4919370", VA = "0x184919F70")]
		public void FELCAKNBJOG(T NFNHJEDIBOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x49191F0", Offset = "0x49185F0", VA = "0x1849191F0")]
		public void DDBHAOINFEB(T NFNHJEDIBOM, int MIDLAFAELPN, float JGFPKIBNFLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x491AE10", Offset = "0x491A210", VA = "0x18491AE10")]
		public void LAJDPIBNJAI(T NFNHJEDIBOM, int MIDLAFAELPN, string LOBGOACPBMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x491A9C0", Offset = "0x4919DC0", VA = "0x18491A9C0")]
		public void JEHHCLOHFMN(T NFNHJEDIBOM, string LKJLOEKMMKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x491A120", Offset = "0x4919520", VA = "0x18491A120")]
		public void IJHOIOFCDIF(T NFNHJEDIBOM, string OOFKEMDPBKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x491C8A0", Offset = "0x491BCA0", VA = "0x18491C8A0")]
		public void OMMHFDCBDCC(T NFNHJEDIBOM, bool FLMFLPFPGBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x491CC60", Offset = "0x491C060", VA = "0x18491CC60")]
		public void PECIEKCIKKL(T NFNHJEDIBOM, string[] DCPJBPOJCAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4916C60", Offset = "0x4916060", VA = "0x184916C60")]
		public Task CDHIPNCMILL(bool IMJBLFBLNHJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x491C050", Offset = "0x491B450", VA = "0x18491C050")]
		private (IEnumerable<T>, string) LJHJCMOBOJE()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4914F10", Offset = "0x4914310", VA = "0x184914F10")]
		public static BAJPIFGIBCF CALGABBLJHF(Guid EPLNDGCAAIK, string PMIOGEIKPIN, T NFNHJEDIBOM, string JIHGIEGKKAF, string NFABHIMCEPG, string MAPECHCMLFK, int? COPLIEINKOF, [Optional] string LLJLHLCFEHF, [Optional] string LKJLOEKMMKE, [Optional] int? FKIGDBMAELA, [Optional] Guid? AJIFIDJHIHP, [Optional] string IPGFEBHNNHE, [Optional] string LFBFCCKOHBA, [Optional] (int, int)? HKKMNBOCCII, [Optional] string ODHFMJNIPMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x491D190", Offset = "0x491C590", VA = "0x18491D190")]
		[CompilerGenerated]
		private string PIOKBAGNGME(T FBLIJIPJKFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4919BA0", Offset = "0x4918FA0", VA = "0x184919BA0")]
		[CompilerGenerated]
		private string DNPPECFIIFB(T FBLIJIPJKFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4914D70", Offset = "0x4914170", VA = "0x184914D70")]
		[CompilerGenerated]
		private string AMFIKIOOHAJ(T FBLIJIPJKFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4919960", Offset = "0x4918D60", VA = "0x184919960")]
		[CompilerGenerated]
		private string DLEAIOBJKFF(T FBLIJIPJKFJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class NFOHBLIKDMH<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected readonly string KCJIBHFNFKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected readonly Guid OLLFBIGBIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected readonly long KAGMGJINBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected int NFGKGIELNGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected int PIKNCHHNMLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected DateTime OKBIIMGENAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		protected bool FGCPEMHKGGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		protected Dictionary<long, LIJIFPAJDCH> CJHNFKJGGLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		protected bool CDFMMBGHEPG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool CAKAJLHCMMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xBEB250", Offset = "0xBEA650", VA = "0x180BEB250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FFGLBGLJIOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xC3A520", Offset = "0xC39920", VA = "0x180C3A520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x51980F0", Offset = "0x51974F0", VA = "0x1851980F0")]
		public NFOHBLIKDMH(string KCJIBHFNFKD, Guid OLLFBIGBIND, long KAGMGJINBIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void JLIKDJIHONN(TListSessionStartParams EDMMJKKGEBM);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4A534C0", Offset = "0x4A528C0", VA = "0x184A534C0")]
		public void LHDDIJNNBPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void PEDPOGIBKHE(bool ONMMEOIBLFM, TListSessionLogParams PINCLCFEFJD);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5197F00", Offset = "0x5197300", VA = "0x185197F00")]
		public void LPGOJPGOFHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5198020", Offset = "0x5197420", VA = "0x185198020")]
		public void PHKAGNCDIBE(long OFMELAFEMHB, int COPLIEINKOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5197D90", Offset = "0x5197190", VA = "0x185197D90")]
		public void IBMAPJADHHH(long OFMELAFEMHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract LIJIFPAJDCH HKKOJLNGCCD(TItem NNAMOJMJBHC, int COPLIEINKOF, string BOLDNJGGIDM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class LIJIFPAJDCH : KFMHAHHOCHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int NFGKGIELNGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private long OFMELAFEMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private long KAGMGJINBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly string DBEKMECGCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly string MEOOFPPNINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly int NJMPKDPFOAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private DateTime PILEHOBDALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private double KOJJFNIOBMP;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BKOHILKJJME
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xDF1F70", Offset = "0xDF1370", VA = "0x180DF1F70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xDF2850", Offset = "0xDF1C50", VA = "0x180DF2850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7038C10", Offset = "0x7038010", VA = "0x187038C10")]
		public LIJIFPAJDCH(long OFMELAFEMHB, int NFGKGIELNGI, string LFBFCCKOHBA, long KAGMGJINBIJ, int NJMPKDPFOAC, [Optional] string JIHGIEGKKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7038520", Offset = "0x7037920", VA = "0x187038520")]
		public void AIGADNJBFFO(int NFGKGIELNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7038BC0", Offset = "0x7037FC0", VA = "0x187038BC0")]
		public void OFMEHMODLCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7038AB0", Offset = "0x7037EB0", VA = "0x187038AB0")]
		public void MMKMEHLDCJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7038590", Offset = "0x7037990", VA = "0x187038590")]
		private void CGACDDCJOPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7038600", Offset = "0x7037A00", VA = "0x187038600", Slot = "5")]
		public virtual BAJPIFGIBCF COECNICIANP(Guid EPLNDGCAAIK, string ECLGICACINA, [Optional] string LFBFCCKOHBA, [Optional] long? NFNHJEDIBOM, [Optional] string JIHGIEGKKAF, [Optional] string MAPECHCMLFK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class BHIDCNCBEBB
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static Dictionary<string, Dictionary<string, object>> PKKGNLAPBGB;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static string PDMFCLPAOGG;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static int PDEBEACDKKD;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly Dictionary<string, NHKMFOIGABB> LOPOLGKJJDM;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string HKKFFMKNACA
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7031800", Offset = "0x7030C00", VA = "0x187031800")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7031130", Offset = "0x7030530", VA = "0x187031130")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool PJBOKOFCPHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x70319C0", Offset = "0x7030DC0", VA = "0x1870319C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> MGGPCFBLJAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7032730", Offset = "0x7031B30", VA = "0x187032730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? FOCNBFPNEDB
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x70327E0", Offset = "0x7031BE0", VA = "0x1870327E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7032850", Offset = "0x7031C50", VA = "0x187032850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? EBEIHDKCDMC
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7030ED0", Offset = "0x70302D0", VA = "0x187030ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7032780", Offset = "0x7031B80", VA = "0x187032780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7031930", Offset = "0x7030D30", VA = "0x187031930")]
		public static void HIBLMLLICEI(string PKLBHKMOFDD, NHKMFOIGABB KKFILBPKAJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x70313F0", Offset = "0x70307F0", VA = "0x1870313F0")]
		internal static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7031850", Offset = "0x7030C50", VA = "0x187031850")]
		internal static void HAHHCGEAEBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7031370", Offset = "0x7030770", VA = "0x187031370")]
		internal static void EGGAJNGPAKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7031E50", Offset = "0x7031250", VA = "0x187031E50")]
		public static Guid JLIKDJIHONN(string PKLBHKMOFDD, [Optional] string? APBOEMPPFDP, [Optional] Dictionary<string, object>? HJMJJCAPMPK)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7032430", Offset = "0x7031830", VA = "0x187032430")]
		public static Guid JLIKDJIHONN(string PKLBHKMOFDD, long APBOEMPPFDP, [Optional] Dictionary<string, object>? HJMJJCAPMPK)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x70324D0", Offset = "0x70318D0", VA = "0x1870324D0")]
		public static void LHDDIJNNBPN(string PKLBHKMOFDD, [Optional] Guid? FIAGFFPOAHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x70314D0", Offset = "0x70308D0", VA = "0x1870314D0")]
		public static void GCICNMHFHME(string PKLBHKMOFDD, string CKFODKCDADH, object ALEHMIPMLGE, bool GBKCNCGJFFG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7030F40", Offset = "0x7030340", VA = "0x187030F40")]
		public static bool BEILLGPELJE(string PKLBHKMOFDD, [Optional] string? APBOEMPPFDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x70311F0", Offset = "0x70305F0", VA = "0x1870311F0")]
		private static void EABLIEDBPPM(bool HHAFNDKKNFI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x70328B0", Offset = "0x7031CB0", VA = "0x1870328B0")]
		public static void PPDEGNLIJCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x70316E0", Offset = "0x7030AE0", VA = "0x1870316E0")]
		private static void GFANFOACAGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7031A50", Offset = "0x7030E50", VA = "0x187031A50")]
		private static void JIFLHGGLHOH(string PKLBHKMOFDD, Guid EPLNDGCAAIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class HLGNJBICIKD
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct LBDNFFJFKGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool LCNFJJJGFFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string GDODLHCOCDP;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xBEBD00", Offset = "0xBEB100", VA = "0x180BEBD00")]
			public LBDNFFJFKGG(bool LCNFJJJGFFM, string GDODLHCOCDP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x70370E0", Offset = "0x70364E0", VA = "0x1870370E0")]
		public static LBDNFFJFKGG BKFDGJHNENK(BAJPIFGIBCF OHCDCDNAHPO)
		{
			return default(LBDNFFJFKGG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7037400", Offset = "0x7036800", VA = "0x187037400")]
		private static void CBENAOEEFOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7037020", Offset = "0x7036420", VA = "0x187037020")]
		private static void AHLPGDJLFJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class HAEBCEPDMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7036FC0", Offset = "0x70363C0", VA = "0x187036FC0")]
		public static BAJPIFGIBCF MCEEELCPDEB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KNBLJCLBDLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7037DF0", Offset = "0x70371F0", VA = "0x187037DF0")]
		public static BAJPIFGIBCF BKNEPDFEONK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7038150", Offset = "0x7037550", VA = "0x187038150")]
		public static BAJPIFGIBCF JNHGOKLIBLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7037D90", Offset = "0x7037190", VA = "0x187037D90")]
		public static BAJPIFGIBCF AOFHAJBADCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7038030", Offset = "0x7037430", VA = "0x187038030")]
		public static BAJPIFGIBCF IAFEHJPMIIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7037CD0", Offset = "0x70370D0", VA = "0x187037CD0")]
		public static BAJPIFGIBCF ANPECFOMIHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7038210", Offset = "0x7037610", VA = "0x187038210")]
		public static BAJPIFGIBCF OHPKJPJCIIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7037F10", Offset = "0x7037310", VA = "0x187037F10")]
		public static BAJPIFGIBCF GBIIMEFBGNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7037F70", Offset = "0x7037370", VA = "0x187037F70")]
		public static BAJPIFGIBCF GHIKGJBCMMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x70380F0", Offset = "0x70374F0", VA = "0x1870380F0")]
		public static BAJPIFGIBCF JAONOOHFIHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7037E50", Offset = "0x7037250", VA = "0x187037E50")]
		public static BAJPIFGIBCF CIJEHIHKEHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7037FD0", Offset = "0x70373D0", VA = "0x187037FD0")]
		public static BAJPIFGIBCF GPCOKLIHJBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7037EB0", Offset = "0x70372B0", VA = "0x187037EB0")]
		public static BAJPIFGIBCF EOBKFAAJJAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7037D30", Offset = "0x7037130", VA = "0x187037D30")]
		public static BAJPIFGIBCF AOBLAPFOAKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x70381B0", Offset = "0x70375B0", VA = "0x1870381B0")]
		public static BAJPIFGIBCF MHGKJGMKLAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7038090", Offset = "0x7037490", VA = "0x187038090")]
		public static BAJPIFGIBCF IOMIKPICDEO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class JKCKALAGODH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7037AF0", Offset = "0x7036EF0", VA = "0x187037AF0")]
		public static BAJPIFGIBCF GPOBFCIDFMJ(long NFMLPECGLEO, long AKJILJJKOFL, bool KMKOMFBCFGB, string FEDELDKANAB, string OCBMGJHDMID)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class GFEIIDDCJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7035720", Offset = "0x7034B20", VA = "0x187035720")]
		public static BAJPIFGIBCF BCBEEBDCJGL(string NLHOGIPPOBC, string POJACNOFJJA, bool LPABGJNEJOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7035890", Offset = "0x7034C90", VA = "0x187035890")]
		public static BAJPIFGIBCF EELPCLCEAFJ(string FAJBNOJIOHK, string EDECELOEIFD, string OBGBFKFFPIO, [Optional] int? NGMDNDMMCBK, [Optional] double[] PJGBMGPIHFE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class NABKCENGGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7039C40", Offset = "0x7039040", VA = "0x187039C40")]
		public static BAJPIFGIBCF GJJLMLHPKBJ(string FNGNGADLKIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7039D20", Offset = "0x7039120", VA = "0x187039D20")]
		public static BAJPIFGIBCF KENDCOONAOE(string NOBIIPDIFAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7039BE0", Offset = "0x7038FE0", VA = "0x187039BE0")]
		public static BAJPIFGIBCF FFLHCOHIOFK(int KGKDIIKHGOB, string KCCMEIDBNGP, string FBLIJIPJKFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7039E60", Offset = "0x7039260", VA = "0x187039E60")]
		public static BAJPIFGIBCF PEDDPPBLFPF(int KGKDIIKHGOB, string KCCMEIDBNGP, string FBLIJIPJKFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7039E00", Offset = "0x7039200", VA = "0x187039E00")]
		public static BAJPIFGIBCF MOJKAGLEEMP(int KGKDIIKHGOB, string KCCMEIDBNGP, string FBLIJIPJKFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7039B80", Offset = "0x7038F80", VA = "0x187039B80")]
		public static BAJPIFGIBCF DIEACNOKAAE(int KGKDIIKHGOB, string KCCMEIDBNGP, string FBLIJIPJKFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x70397C0", Offset = "0x7038BC0", VA = "0x1870397C0")]
		public static BAJPIFGIBCF BBBDNHPAEPB(string KCCMEIDBNGP, string FBLIJIPJKFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7039A40", Offset = "0x7038E40", VA = "0x187039A40")]
		private static BAJPIFGIBCF BEFHOGMFOJH(string KCJIBHFNFKD, int KGKDIIKHGOB, string IBBANOHBOBC, string GBJGAJHJOID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7039910", Offset = "0x7038D10", VA = "0x187039910")]
		private static BAJPIFGIBCF BEFHOGMFOJH(string KCJIBHFNFKD, string IBBANOHBOBC, string GBJGAJHJOID)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly LMKAPNBAFDO BKFDGJHNENK;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static MEMOJDCJIDB JAEGEMNAGLJ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static NKJJPPKIFKO HIIFFEJIMMM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<BAJPIFGIBCF> LIHEEEDAIBJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long INMGMCDMOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7033890", Offset = "0x7032C90", VA = "0x187033890")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7033A50", Offset = "0x7032E50", VA = "0x187033A50")]
	[GEMHNPPGODB.JLNPPECHEJF]
	internal static void MLGOHAIDJAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7033980", Offset = "0x7032D80", VA = "0x187033980")]
	private static void GMJFIIBEHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7033CD0", Offset = "0x70330D0", VA = "0x187033CD0")]
	public static BAJPIFGIBCF OMGIJEJJJCC(string KNHBECPAEPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7033BC0", Offset = "0x7032FC0", VA = "0x187033BC0")]
	public static BAJPIFGIBCF OMGIJEJJJCC(string KNHBECPAEPN, int KGKDIIKHGOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7033B50", Offset = "0x7032F50", VA = "0x187033B50")]
	public static bool NIEMNLLLIOK(this PCFGMNCOCPN CELNALJECPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7033D50", Offset = "0x7033150", VA = "0x187033D50")]
	[GEMHNPPGODB.JLNPPECHEJF]
	internal static void PKFBBDAKAIL()
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
