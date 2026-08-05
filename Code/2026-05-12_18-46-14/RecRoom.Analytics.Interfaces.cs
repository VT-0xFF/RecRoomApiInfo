using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.Analytics.AccessInterfaces;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Analytics.Statsig
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface XYNTEJINREW
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		Task PDTYECSCZNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Task KTUGBPZEEJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool VJORQXGFZZY
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool OFHVAEVYFGP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		string NSNBBKFRWXE
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		AQMTVIOULBH SQRJPYGFWYX
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action NOBLVTJAILF;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action POSZVTQDYTP;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action<ParameterAccessRecord> LLUMYUEDSDS;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task Initialize([Optional] HTFFKIPGVTX userData);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task HNJFFAEHPGC(HTFFKIPGVTX a);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool ZOZLJEVQCCJ(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		PUVMHJFHWAN OFQPAQWBPVV(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "16")]
		OZIZYFCGXMD FLDBZXELWSB(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task Shutdown();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface ZJOQZBYZDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface NZAUNJBMIBY<out a> : ZJOQZBYZDEB
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string HNGFVLOPUPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a GMMQTZQKPTX();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface WDYQPUIRQBT
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NZAUNJBMIBY<a> FHALKRQKNNK<a>(string a, string b, a c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface UOMRCXQBJPS
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string KPIDBUYRLLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		string VSCHLMLGBUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "2")]
		T Get<T>(string key, [Optional] T defaultValue);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface PUVMHJFHWAN : UOMRCXQBJPS
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool RHYCFIRBYKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool RBPWLESIHQT
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		IReadOnlyList<string> ODOCXYVSTMY
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface OZIZYFCGXMD : UOMRCXQBJPS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface AQMTVIOULBH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		IReadOnlyDictionary<string, object> WGBOWOOJHDE
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct ParameterAccessRecord
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public string LayerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string ExperimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string ParameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public object ParameterValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool HasOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public string BranchOverride;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x969A6C0", Offset = "0x96990C0", VA = "0x18969A6C0")]
		public static ParameterAccessRecord AFSHEUWUHHC(string a, string b, object c, bool d, string e)
		{
			return default(ParameterAccessRecord);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x969A750", Offset = "0x9699150", VA = "0x18969A750")]
		public static ParameterAccessRecord HLACYCFUQVG(string a, string b, object c, bool d, string e)
		{
			return default(ParameterAccessRecord);
		}
	}
}
namespace RecRoom.Analytics.AccessInterfaces
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface HTFFKIPGVTX
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool VWZVWBDIPDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool OWKKZJYQMGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		bool POXNBKGRTCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		bool? FXTMPGUNUPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		int? NNMIAEEXTZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		int QFKWFAPMAKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		int GZBEPJXJOEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		string NNTHEGSBKCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string QGDROPUOFKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		string JHVSZLNWYPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		long BTTRSUIZRHL
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		string NYTWMLEBYDG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		string KKSGBQRIIBS
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		string BCUUKXSQDOP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		string HIPJGZZQTQX
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		string GLYKKXHWCET
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		double RVBZQGAYQRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		int QCXZALVTWLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		string FEMBENNFPDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		string OMKHPGMRSZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		string QPMSSJUKUQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		Guid? LUILAUKBBWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}
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
