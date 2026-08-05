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
	public interface GAVJPVRYXKY
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		Task UPMNIBGDUUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Task QNYXTUJUWIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool BCOVCCWJXWI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool RMKLGFUYRPX
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		string ZXFIXZGAWJS
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		RRFFHEMFDLZ AJBTFVHYNRD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action LWFLSOUWPJL;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action LUNKNRPUPZN;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action<ParameterAccessRecord> LGVFXGOCMAK;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task Initialize([Optional] ZTGQNSMWSPB userData);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task QOEAGVHMTRO(ZTGQNSMWSPB a);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool ILSSEPHKGPZ(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		TFITJJSPDPZ BNLYSOWCYKJ(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "16")]
		NQBMZKVEQOB VNQFIPZRZBB(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task Shutdown();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface EGPBORTGHJV
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface PTTJZOWZKAA<out a> : EGPBORTGHJV
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string FNCAYAURJKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a IFWFWGZGPDZ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface FRYLGEWUQFV
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PTTJZOWZKAA<a> NAWQDDFIAHE<a>(string a, string b, a c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface OYDCKSLWPLM
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		string EKRTPDWKADH
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
	public interface TFITJJSPDPZ : OYDCKSLWPLM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool VLPYVPWFUKS
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool YIDBQPXFYUB
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		IReadOnlyList<string> ZKCVYTWMQYG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface NQBMZKVEQOB : OYDCKSLWPLM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface RRFFHEMFDLZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		IReadOnlyDictionary<string, object> CHTPRGSGKSQ
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
		[Cpp2IlInjected.Address(RVA = "0x96AD900", Offset = "0x96AC900", VA = "0x1896AD900")]
		public static ParameterAccessRecord BMRBVWEUITI(string a, string b, object c, bool d, string e)
		{
			return default(ParameterAccessRecord);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x96AD990", Offset = "0x96AC990", VA = "0x1896AD990")]
		public static ParameterAccessRecord ZDUYDWINAGO(string a, string b, object c, bool d, string e)
		{
			return default(ParameterAccessRecord);
		}
	}
}
namespace RecRoom.Analytics.AccessInterfaces
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface ZTGQNSMWSPB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool GDWKXCBHWOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool DDOZZTVIVCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		bool RWSRWTOFMIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		bool? FESTKMNQXBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		int? GJCKLSUOCUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		int WJMQERZQMDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		int YDIGEKKXDAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		string MLACDCHSBFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string NCNMOYOSMLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		string XXPDYQWJAND
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		long TVJRIFYHLJF
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		string GADBEAYCPYS
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		string QIPATATUHXY
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		string RTAKSVPMEQB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		string ECSJKBQKMKB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		string KTLEBGLTZFX
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		double IMYAJCLFLQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		int VFMMYLFFYXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		string ODIZYVIPSGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		string SRGAMMKKQTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		string RPKBOSYQCHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		Guid? UIVHUDEQPYO
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
