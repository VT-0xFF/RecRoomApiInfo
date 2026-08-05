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
	public interface CTVUVETPQOE
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		Task HLZDICRGBPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Task CHUQTSIYWAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool VOUBIOEWDEU
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool DAOTBEPJOZX
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		string CLHMIRDUYNC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		FLNMCZUDHDZ SJJPTTCCQBH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action WBCNPPDTBTX;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action JNWLRNTERIP;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action<ParameterAccessRecord> QRVPDUKDSXE;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task Initialize(string recNetEnv, [Optional] DKTJSSVNSVN userData);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task BNRHJUYZDCM(DKTJSSVNSVN a);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Task RUSBOCLDKPQ(DKTJSSVNSVN a, Dictionary<string, string> b);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool BBJUOUGISZV(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "16")]
		MRVVHUVMMYD VIWPSGSOZCF(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "17")]
		IEERDUSQQAN JNDCBZTBLML(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Shutdown();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface WXRMNKAYLEX
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface FJTYTOMVCZG<out a> : WXRMNKAYLEX
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string MSOVURVNCDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a WNIKEIXLQNZ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface BFYAEEAPRXV
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		FJTYTOMVCZG<a> PAAHNNAQUBQ<a>(string a, string b, a c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface RZTWUVTWFIS
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		string PXVKIBSMBWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		T Get<T>(string key, [Optional] T defaultValue);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface MRVVHUVMMYD : RZTWUVTWFIS
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool VDGPKFHIBVI
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool GNADVJQMDKB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		IReadOnlyList<string> RSHUEMODWDI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface IEERDUSQQAN : RZTWUVTWFIS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface FLNMCZUDHDZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		IReadOnlyDictionary<string, object> EHYLMOOHJQQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
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

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7FC02F0", Offset = "0x7FBF6F0", VA = "0x187FC02F0")]
		public static ParameterAccessRecord FLEOJOWJHRI(string a, string b, object c, bool d, string e)
		{
			return default(ParameterAccessRecord);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0380", Offset = "0x7FBF780", VA = "0x187FC0380")]
		public static ParameterAccessRecord RNBFXKXJBQG(string a, string b, object c, bool d, string e)
		{
			return default(ParameterAccessRecord);
		}
	}
}
namespace RecRoom.Analytics.AccessInterfaces
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface DKTJSSVNSVN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool QNMRQNZDWSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool MMHNRLVLFJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		bool AUFVYUZRSYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		bool? OLEQCRPGGEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		int? QOEILSPIXVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		int ROWPSTESDTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		int HJLCWSAOHZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		string DGITKBFEFOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string YBAHYSVSEJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		string LGMJVMWHRLT
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		long TAJXCEBACUD
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		string QMDEMZXROZE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		string ZIJRKOTIKUK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		string EXAUCYJXCEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		string BMDFHVWXURT
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		string YRDYYCZMVMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		double UBURAIXMYRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		int FKQUNPWDMNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		string QXRRIGDSYOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		string QNKKEHADWQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		string UCUNBKNYWWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		Guid? SEJQQXINTOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
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
